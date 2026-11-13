# SettlementScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6BD40DAA229BD66FF82195C3DF23C92E63C9DD9FCBDDFA16E9743662E64D83C4`。来源：[源码](../../SettlementScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.MatchMedallion`。

字段、事件及初始值（源码原样）：

```csharp
private Label? _settlementCommunity;
private string _settlementMatch = "";
```

<a id="symbol-ab0215572f9e"></a>

## `NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData) — private void RefreshSettlementDiscussion(CareerData data)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen._settlementCommunity`；`NationalSpire.CareerScreen._settlementMatch`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_settlementCommunity)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_settlementCommunity)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_settlementCommunity.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: _settlementCommunity == null || !IsInstanceValid(_settlementCommunity) || _settlementCommunity.IsQueuedForDeletion()`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.EventKey == "match" + _settlementMatch)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).FirstOrDefault(p => p.EventKey == "match" + _settlementMatch)`

**赋值（含属性/字段和局部值）：**

- `_settlementCommunity.Text` = `post == null ? "本场战报已保存。" : post.NewsGeneration.State == "completed" ? $"赛后讨论已更新 · {post.Replies.Count} 条回复"              : post.NewsGeneration.State == "failed" ? "赛后讨论暂未完成，可在社区重试。"              : post.AiPending && data.Ai.Enabled ? "赛后讨论正在整理，可以先看看本场成绩。" : "本场战报已刊登，去社区看看。"`

<a id="symbol-ec46df6667fd"></a>

## `NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData) — private void Settlement(CareerData data)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`Column(string)`](SettlementScreen.cs.md#symbol-4daeb87466ef)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-7436948d6a10)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`](MatchArenaScreen.cs.md#symbol-c4eb3ccea4ca)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.OpenCommunity()`](CareerNavigation.cs.md#symbol-9428027fc287)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ab0215572f9e)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`](MatchArenaScreen.cs.md#symbol-2553d6834735)；[`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8f255f3d5c6b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult)`](MatchRules.cs.md#symbol-a28dd7ef0ece)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`Reward(string, string, string)`](SettlementScreen.cs.md#symbol-bedc2a0e9320)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.ResultChart.ResultChart()`；`string.StartsWith(char)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `(T1, T2).Item1`；`(T1, T2).Item2`；`Column(string)`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerMatch.Decider`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.CareerResult.FansDelta`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.LifeEffects`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Mode`；`NationalSpire.CareerResult.Opponent`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.Prize`；`NationalSpire.CareerResult.RatingDelta`；`NationalSpire.CareerResult.RewardMultiplier`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Settlement`；`NationalSpire.CareerResult.Simulated`；`NationalSpire.CareerResult.Win`；`NationalSpire.CareerResult.WorldImpact`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._settlementCommunity`；`NationalSpire.CareerScreen._settlementMatch`；`NationalSpire.CareerScreen._starting`；`NationalSpire.CareerScreen.AddHeading(string, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.OpenCommunity()`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.RenderTeam()`；`NationalSpire.CareerScreen.ResolveFailure(string)`；`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`；`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.ICareerSession.HasVoted`；`NationalSpire.ICareerSession.Host`；`NationalSpire.ICareerSession.ProposalId`；`NationalSpire.ICareerSession.ProposalText`；`NationalSpire.MatchModes.Dread`；`NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult)`；`NationalSpire.MatchRules.Performance(bool, int, double?)`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.ResultChart.Results`；`NationalSpire.RunBadge.Description`；`NationalSpire.RunBadge.Name`；`NationalSpire.RunEncounter.Act`；`NationalSpire.RunEncounter.Floor`；`NationalSpire.RunEncounter.Kind`；`NationalSpire.RunEncounter.Name`；`NationalSpire.RunEvidence.Badges`；`NationalSpire.RunEvidence.DefeatedEncounters`；`NationalSpire.RunEvidence.FinalHp`；`NationalSpire.RunEvidence.MaxHp`；`NationalSpire.RunEvidence.PotionsRecorded`；`NationalSpire.RunEvidence.PotionsUsed`；`NationalSpire.RunEvidence.RemainingPotions`；`NationalSpire.SettlementRecord.Competition`；`NationalSpire.SettlementRecord.Decider`；`NationalSpire.SettlementRecord.Fans`；`NationalSpire.SettlementRecord.Honors`；`NationalSpire.SettlementRecord.OpponentPerformance`；`NationalSpire.SettlementRecord.Rating`；`NationalSpire.SettlementRecord.Standings`；`NationalSpire.SettlementStanding.Detail`；`NationalSpire.SettlementStanding.Nearby`；`NationalSpire.SettlementStanding.Title`；`NationalSpire.SettlementStanding.Value`；`Reward(string, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Column(string)`；输入表达式：`Column("本局记录")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Column("本局记录")`
- `Column(string)`；输入表达式：`Column("对局回顾")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Column("对局回顾")`
- `Column(string)`；输入表达式：`Column("赛后变化")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Column("赛后变化")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("a5bcd5")`；返回值紧邻使用处：`ConditionalExpressionSyntax: won ? _gold : new Color("a5bcd5")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rankings.AddThemeConstantOverride("h_separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: rankings.AddThemeConstantOverride("h_separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rankings.AddThemeConstantOverride("v_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: rankings.AddThemeConstantOverride("v_separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`report.AddThemeConstantOverride("separation",25)`；返回值紧邻使用处：`ExpressionStatementSyntax: report.AddThemeConstantOverride("separation",25);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rewards.AddThemeConstantOverride("h_separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: rewards.AddThemeConstantOverride("h_separation", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("263b49", "71889b", 8, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("263b49", "71889b", 8, 16));`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Name="SettlementReport"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {Name="SettlementReport"}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(DashboardLabel("详细战报",24,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(DashboardLabel("详细战报",24,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(DashboardLabel(IsLatestReview(data)?"本场成绩已记录":"历史战报 · "+GameCalendar.Text(data,result.Day),16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(DashboardLabel(IsLatestReview(data)?"本场成绩已记录":"历史战报 · "+GameCalendar.Text(data,result.Day),16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(preparation)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(preparation);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(rankings)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(rankings);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(report)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(report);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(rewards)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(rewards);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("排名记录于本场结算时；同日其他比赛尚未结束时，名次仍可能变化。", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("排名记录于本场结算时；同日其他比赛尚未结束时，名次仍可能变化。", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("赛后排名", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("赛后排名", 24, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("这份旧战报未保存当时的排名。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("这份旧战报未保存当时的排名。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(approval)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(approval);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("取消准备", () => MultiplayerCommand("cancel", _multiplayer.ProposalId), 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("取消准备", () => MultiplayerCommand("cancel", _multiplayer.ProposalId), 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("等待房主选择。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("等待房主选择。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(_multiplayer != null ? "全队击败的精英与 BOSS" : "本局击败的精英与 BOSS", 22, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(_multiplayer != null ? "全队击败的精英与 BOSS" : "本局击败的精英与 BOSS", 22, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第 {act.Key} 幕", 17, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第 {act.Key} 幕", 17, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第 {encounter.Floor} 层 · {(encounter.Kind == "Boss" ? "BOSS" : "精英")} · {encounter.Name}", 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第 {encounter.Floor} 层 · {(encounter.Kind == "Boss" ? "BOSS" : "精英")} · {encounter.Name}", 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(nearby, 15, nearby.StartsWith('▸') ? _gold : _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(nearby, 15, nearby.StartsWith('▸') ? _gold : _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(standing.Detail, 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(standing.Detail, 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(standing.Title, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(standing.Title, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(standing.Value, 31, accent))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(standing.Value, 31, accent));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(_settlementCommunity)`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(_settlementCommunity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(CaptionButton("查看社区讨论",()=>{              var post=CommunityThreads.All(data).FirstOrDefault(p=>p.EventKey=="match"+result.MatchId);              if(post!=null) OpenPost(post); else OpenCommunity();          }))`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(CaptionButton("查看社区讨论",()=>{              var post=CommunityThreads.All(data).FirstOrDefault(p=>p.EventKey=="match"+result.MatchId);              if(post!=null) OpenPost(post); else OpenCommunity();          }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(DashboardLabel("◆ "+honor,17,_gold,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(DashboardLabel("◆ "+honor,17,_gold,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(DashboardLabel($"本场挑战进阶 {result.PlayedAscension} · 挑战奖励 ×{result.RewardMultiplier:0.00}",16,CareerVisuals.Teal,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(DashboardLabel($"本场挑战进阶 {result.PlayedAscension} · 挑战奖励 ×{result.RewardMultiplier:0.00}",16,CareerVisuals.Teal,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(DashboardLabel(decider,16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(DashboardLabel(decider,16,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(DashboardLabel(effect,16,CareerVisuals.Teal,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(DashboardLabel(effect,16,CareerVisuals.Teal,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`changes.AddChild(DashboardLabel(result.WorldImpact,16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: changes.AddChild(DashboardLabel(result.WorldImpact,16,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rankings.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: rankings.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ready.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ready.AddChild(Text(_multiplayer.ProposalText, 19, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.AddChild(Text(_multiplayer.ProposalText, 19, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`review.AddChild(DashboardLabel("◆ "+badge.Name+" · "+badge.Description,16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: review.AddChild(DashboardLabel("◆ "+badge.Name+" · "+badge.Description,16,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`review.AddChild(DashboardLabel("最近八场 · 到达楼层",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: review.AddChild(DashboardLabel("最近八场 · 到达楼层",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`review.AddChild(new ResultChart {Results=data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList(),              CustomMinimumSize=new(0,110),SizeFlagsHorizontal=SizeFlags.ExpandFill})`；返回值紧邻使用处：`ExpressionStatementSyntax: review.AddChild(new ResultChart {Results=data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList(),              CustomMinimumSize=new(0,110),SizeFlagsHorizontal=SizeFlags.ExpandFill});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`run.AddChild(DashboardLabel(GameCalendar.Text(data,result.Day)+" · "+MatchRules.AscensionLabel(result)+(result.Simulated?" · 模拟赛果":""),16,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: run.AddChild(DashboardLabel(GameCalendar.Text(data,result.Day)+" · "+MatchRules.AscensionLabel(result)+(result.Simulated?" · 模拟赛果":""),16,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`run.AddChild(DashboardLabel(item,16,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: run.AddChild(DashboardLabel(item,16,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`run.AddChild(DashboardLabel(ownPerformance,17,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: run.AddChild(DashboardLabel(ownPerformance,17,_ink,true));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 58)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(0, 58)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,110)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,110)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(result.Prize)`；返回值紧邻使用处：`BinaryExpressionSyntax: "+" + CareerMoney.Format(result.Prize)`
- `NationalSpire.CareerScreen.AddHeading(string, string)`；输入表达式：`AddHeading("尚无比赛结算", "完成一场已报名赛事后，战报会显示在这里。")`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading("尚无比赛结算", "完成一场已报名赛事后，战报会显示在这里。");`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(_multiplayer.HasVoted ? "已准备，等待队友" : "准备重赛", () => MultiplayerCommand("confirm", _multiplayer.ProposalId), 240)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(_multiplayer.HasVoted ? "已准备，等待队友" : "准备重赛", () => MultiplayerCommand("confirm", _multiplayer.ProposalId), 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消准备", () => MultiplayerCommand("cancel", _multiplayer.ProposalId), 160)`；返回值紧邻使用处：`ArgumentSyntax: Button("取消准备", () => MultiplayerCommand("cancel", _multiplayer.ProposalId), 160)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(choice.Item1, () => ResolveFailure(choice.Item2), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(choice.Item1, () => ResolveFailure(choice.Item2), 0)`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("查看社区讨论",()=>{              var post=CommunityThreads.All(data).FirstOrDefault(p=>p.EventKey=="match"+result.MatchId);              if(post!=null) OpenPost(post); else OpenCommunity();          })`；返回值紧邻使用处：`ArgumentSyntax: CaptionButton("查看社区讨论",()=>{              var post=CommunityThreads.All(data).FirstOrDefault(p=>p.EventKey=="match"+result.MatchId);              if(post!=null) OpenPost(post); else OpenCommunity();          })`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`；输入表达式：`CompetitionOverview(data, competition)`；返回值紧邻使用处：`ExpressionStatementSyntax: CompetitionOverview(data, competition);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("",16,CareerVisuals.Teal,true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _settlementCommunity=DashboardLabel("",16,CareerVisuals.Teal,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("◆ "+badge.Name+" · "+badge.Description,16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("◆ "+badge.Name+" · "+badge.Description,16,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("◆ "+honor,17,_gold,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("◆ "+honor,17,_gold,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("详细战报",24,_ink)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("详细战报",24,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("最近八场 · 到达楼层",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("最近八场 · 到达楼层",16,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"本场挑战进阶 {result.PlayedAscension} · 挑战奖励 ×{result.RewardMultiplier:0.00}",16,CareerVisuals.Teal,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"本场挑战进阶 {result.PlayedAscension} · 挑战奖励 ×{result.RewardMultiplier:0.00}",16,CareerVisuals.Teal,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(decider,16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(decider,16,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(effect,16,CareerVisuals.Teal,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(effect,16,CareerVisuals.Teal,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(GameCalendar.Text(data,result.Day)+" · "+MatchRules.AscensionLabel(result)+(result.Simulated?" · 模拟赛果":""),16,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(GameCalendar.Text(data,result.Day)+" · "+MatchRules.AscensionLabel(result)+(result.Simulated?" · 模拟赛果":""),16,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(IsLatestReview(data)?"本场成绩已记录":"历史战报 · "+GameCalendar.Text(data,result.Day),16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(IsLatestReview(data)?"本场成绩已记录":"历史战报 · "+GameCalendar.Text(data,result.Day),16,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(item,16,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(item,16,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(ownPerformance,17,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(ownPerformance,17,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(result.WorldImpact,16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(result.WorldImpact,16,_ink,true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(choices)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(choices)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(preparation)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(preparation)`
- `NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`；输入表达式：`IsLatestReview(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsLatestReview(data)?"本场成绩已记录":"历史战报 · "+GameCalendar.Text(data,result.Day)`
- `NationalSpire.CareerScreen.IsLatestReview(NationalSpire.CareerData)`；输入表达式：`IsLatestReview(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsLatestReview(data)?"本场战报":"历史战报"`
- `NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`；输入表达式：`MatchArena(data,result.Event,result.OpponentId,result.Opponent,draw?"平局":won?"胜利":"失败",result.Character,accent,out var heroActions,result.Day,              playerPerformance:ownPerformance,rivalPerformance:rivalPerformance,source:IsLatestReview(data)?"本场战报":"历史战报")`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchArena(data,result.Event,result.OpponentId,result.Opponent,draw?"平局":won?"胜利":"失败",result.Character,accent,out var heroActions,result.Day,              playerPerformance:ownPerformance,rivalPerformance:rivalPerformance,source:IsLatestReview(data)?"本场战报":"历史战报");`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("cancel", _multiplayer.ProposalId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => MultiplayerCommand("cancel", _multiplayer.ProposalId)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("confirm", _multiplayer.ProposalId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => MultiplayerCommand("confirm", _multiplayer.ProposalId)`
- `NationalSpire.CareerScreen.OpenCommunity()`；输入表达式：`OpenCommunity()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCommunity();`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPost(post);`
- `NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`；输入表达式：`RefreshSettlementDiscussion(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshSettlementDiscussion(data);`
- `NationalSpire.CareerScreen.RenderTeam()`；输入表达式：`RenderTeam()`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderTeam();`
- `NationalSpire.CareerScreen.ResolveFailure(string)`；输入表达式：`ResolveFailure(choice.Item2)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ResolveFailure(choice.Item2)`
- `NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`；输入表达式：`ReviewPager(data,result,heroActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReviewPager(data,result,heroActions);`
- `NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；输入表达式：`ReviewRecord(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReviewRecord(data)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_multiplayer != null ? "全队击败的精英与 BOSS" : "本局击败的精英与 BOSS", 22, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(_multiplayer != null ? "全队击败的精英与 BOSS" : "本局击败的精英与 BOSS", 22, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_multiplayer.ProposalText, 19, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(_multiplayer.ProposalText, 19, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("等待房主选择。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("等待房主选择。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("排名记录于本场结算时；同日其他比赛尚未结束时，名次仍可能变化。", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("排名记录于本场结算时；同日其他比赛尚未结束时，名次仍可能变化。", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("赛后排名", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("赛后排名", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("这份旧战报未保存当时的排名。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("这份旧战报未保存当时的排名。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第 {act.Key} 幕", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第 {act.Key} 幕", 17, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第 {encounter.Floor} 层 · {(encounter.Kind == "Boss" ? "BOSS" : "精英")} · {encounter.Name}", 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第 {encounter.Floor} 层 · {(encounter.Kind == "Boss" ? "BOSS" : "精英")} · {encounter.Name}", 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(nearby, 15, nearby.StartsWith('▸') ? _gold : _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(nearby, 15, nearby.StartsWith('▸') ? _gold : _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(standing.Detail, 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(standing.Detail, 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(standing.Title, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(standing.Title, 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(standing.Value, 31, accent)`；返回值紧邻使用处：`ArgumentSyntax: Text(standing.Value, 31, accent)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("263b49", "71889b", 8, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("263b49", "71889b", 8, 16)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data,result.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "历史战报 · "+GameCalendar.Text(data,result.Day)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data,result.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Text(data,result.Day)+" · "`
- `NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult)`；输入表达式：`MatchRules.AscensionLabel(result)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Text(data,result.Day)+" · "+MatchRules.AscensionLabel(result)`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match!=null ? MatchRules.Performance(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds) : "对手详细成绩未记录"`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(result.Win,result.Floor,result.RunSeconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: MatchRules.Performance(result.Win,result.Floor,result.RunSeconds)              + (!result.Win && result.RunSeconds>0 ? " · "+MatchRules.Time(result.RunSeconds) : "")`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(result.RunSeconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: " · "+MatchRules.Time(result.RunSeconds)`
- `NationalSpire.ResultChart.ResultChart()`；输入表达式：`new ResultChart {Results=data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList(),              CustomMinimumSize=new(0,110),SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`ArgumentSyntax: new ResultChart {Results=data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList(),              CustomMinimumSize=new(0,110),SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Reward(string, string, string)`；输入表达式：`Reward("本场收入", "+" + CareerMoney.Format(result.Prize), "含本场合同与荣誉奖励")`；返回值紧邻使用处：`ExpressionStatementSyntax: Reward("本场收入", "+" + CareerMoney.Format(result.Prize), "含本场合同与荣誉奖励");`
- `Reward(string, string, string)`；输入表达式：`Reward("关注变化", $"{result.FansDelta:+0;-0;0}", result.Settlement is { } snapshot ? $"赛后关注 {snapshot.Fans}" : "本场新增关注")`；返回值紧邻使用处：`ExpressionStatementSyntax: Reward("关注变化", $"{result.FansDelta:+0;-0;0}", result.Settlement is { } snapshot ? $"赛后关注 {snapshot.Fans}" : "本场新增关注");`
- `Reward(string, string, string)`；输入表达式：`Reward("选手评分", $"{result.RatingDelta:+0;-0;0}", result.Settlement is { } record ? $"赛后评分 {record.Rating}" : "本场评分变化")`；返回值紧邻使用处：`ExpressionStatementSyntax: Reward("选手评分", $"{result.RatingDelta:+0;-0;0}", result.Settlement is { } record ? $"赛后评分 {record.Rating}" : "本场评分变化");`
- `string.StartsWith(char)`；输入表达式：`nearby.StartsWith('▸')`；返回值紧邻使用处：`ConditionalExpressionSyntax: nearby.StartsWith('▸') ? _gold : _muted`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p=>p.EventKey=="match"+result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CommunityThreads.All(data).FirstOrDefault(p=>p.EventKey=="match"+result.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`encounters.GroupBy(e => e.Act)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var act in encounters.GroupBy(e => e.Act))              {                  box.AddChild(Text($"第 {act.Key} 幕", 17, CareerVisuals.Teal));                  foreach (var encounter in act)                      box.AddChild(Text($"第 {encounter.Floor} 层 · {(encounter.Kind == "Boss" ? "BOSS" : "精英")} · {encounter.Name}", 16, _ink));              }`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.LastOrDefault(m => m.Id == result.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.LastOrDefault(m => m.Id == result.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Results.Take(data.Results.IndexOf(result)+1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Take(data.Results.IndexOf(result)+1).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`result.Evidence.Badges.Take(6)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var badge in result.Evidence.Badges.Take(6)) review.AddChild(DashboardLabel("◆ "+badge.Name+" · "+badge.Description,16,_ink,true));`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Results=data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`evidence.Add($"本局用药 {result.Evidence.PotionsUsed} 次")`；返回值紧邻使用处：`ExpressionStatementSyntax: evidence.Add($"本局用药 {result.Evidence.PotionsUsed} 次");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`evidence.Add($"生命 {result.Evidence.FinalHp}/{result.Evidence.MaxHp}")`；返回值紧邻使用处：`ExpressionStatementSyntax: evidence.Add($"生命 {result.Evidence.FinalHp}/{result.Evidence.MaxHp}");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`evidence.Add($"剩余药水 {result.Evidence.RemainingPotions.Count} 瓶")`；返回值紧邻使用处：`ExpressionStatementSyntax: evidence.Add($"剩余药水 {result.Evidence.RemainingPotions.Count} 瓶");`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`data.Results.IndexOf(result)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Results.IndexOf(result)+1`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**

- `_reviewId` = `result.MatchId`
- `_settlementCommunity` = `DashboardLabel("",16,CareerVisuals.Teal,true)`
- `_settlementMatch` = `result.MatchId`
- `approval.Disabled` = `_multiplayer.HasVoted`
- `button.CustomMinimumSize` = `new(0, 58)`
- `button.Disabled` = `_starting || _multiplayer is { Host: false } || _multiplayer?.ProposalId.Length > 0`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `choices.Name` = `"FailureChoices"`
- `Columns` = `2`
- `Columns` = `3`
- `CustomMinimumSize` = `new(0,110)`
- `Name` = `"SettlementReport"`
- `Results` = `data.Results.Take(data.Results.IndexOf(result)+1).TakeLast(8).ToList()`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-bedc2a0e9320"></a>

## `Reward(string, string, string) — void Reward(string title, string value, string description)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",11)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",11);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel",CareerVisuals.Box("142633","304a5a",7,22))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel",CareerVisuals.Box("142633","304a5a",7,22));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rewards.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: rewards.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(amount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(DashboardLabel(title,17,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(DashboardLabel(title,17,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph(title=="本场收入"?"coins":title=="关注变化"?"users-round":"chart-no-axes-combined",20,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph(title=="本场收入"?"coins":title=="关注变化"?"users-round":"chart-no-axes-combined",20,_muted));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,CustomMinimumSize=new(0,94),TooltipText=description}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,CustomMinimumSize=new(0,94),TooltipText=description}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,94)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,94)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,17,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(title,17,_muted)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(title=="本场收入"?"coins":title=="关注变化"?"users-round":"chart-no-axes-combined",20,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Glyph(title=="本场收入"?"coins":title=="关注变化"?"users-round":"chart-no-axes-combined",20,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value,30,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(value,30,_gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142633","304a5a",7,22)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142633","304a5a",7,22)`

**赋值（含属性/字段和局部值）：**

- `amount.HorizontalAlignment` = `HorizontalAlignment.Right`
- `CustomMinimumSize` = `new(0,94)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `TooltipText` = `description`

<a id="symbol-4daeb87466ef"></a>

## `Column(string) — VBoxContainer Column(string title)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation",8);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(DashboardLabel(title,19,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(DashboardLabel(title,19,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`report.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: report.AddChild(column);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,19,_gold)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(title,19,_gold)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-f0fb4e109457"></a>

## `NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview) — private void CompetitionOverview(CareerData data, CompetitionReview review)`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`AddScore(int)`](SettlementScreen.cs.md#symbol-b679d06f3022)；[`Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`](SettlementScreen.cs.md#symbol-580816a1e5fe)；[`Line(Godot.Control)`](SettlementScreen.cs.md#symbol-046f975d03d3)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SettlementRecords.ScoreDuels(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementRecord.cs.md#symbol-0e3bef1aba9f)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `AddScore(int)`；`Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；`Line(Godot.Control)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CompetitionReview.Name`；`NationalSpire.CompetitionReview.PreviousMatchDay`；`NationalSpire.CompetitionReview.Scores`；`NationalSpire.CompetitionReview.Tables`；`NationalSpire.CompetitionRow.Name`；`NationalSpire.CompetitionRow.PlayerRelated`；`NationalSpire.CompetitionRow.Points`；`NationalSpire.CompetitionRow.PreviousPoints`；`NationalSpire.CompetitionRow.PreviousRank`；`NationalSpire.CompetitionRow.Rank`；`NationalSpire.CompetitionRow.Record`；`NationalSpire.CompetitionTable.Id`；`NationalSpire.CompetitionTable.Note`；`NationalSpire.CompetitionTable.Rows`；`NationalSpire.CompetitionTable.Title`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SettlementRecords.ScoreDuels(NationalSpire.CareerData, NationalSpire.CompetitionReview)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AddScore(int)`；输入表达式：`AddScore(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddScore(i);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(header, "累计战绩", 140, _muted, 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(header, "累计战绩", 140, _muted, 14);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(header, "名次", 50, _muted, 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(header, "名次", 50, _muted, 14);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(header, "名次变化", 80, _muted, 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(header, "名次变化", 80, _muted, 14);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(header, table.Id == "nations" ? "国运 / 增量" : "积分 / 增量", 160, _muted, 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(header, table.Id == "nations" ? "国运 / 增量" : "积分 / 增量", 160, _muted, 14);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(header, table.Id == "teams" ? "俱乐部" : table.Id == "nations" ? "国家 / 地区" : "选手", 180, _muted, 14, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(header, table.Id == "teams" ? "俱乐部" : table.Id == "nations" ? "国家 / 地区" : "选手", 180, _muted, 14, true);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(row, change, 80, changeColor, 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(row, change, 80, changeColor, 16);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(row, r.Name + marker, 180, r.PlayerRelated ? _gold : _ink, 18, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(row, r.Name + marker, 180, r.PlayerRelated ? _gold : _ink, 18, true);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(row, r.Points + delta, 160, CareerVisuals.Teal, 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(row, r.Points + delta, 160, CareerVisuals.Teal, 18);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(row, r.Rank > 0 ? $"{r.Rank:00}" : "—", 50, r.Rank is > 0 and <= 3 ? _gold : _muted, 21)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(row, r.Rank > 0 ? $"{r.Rank:00}" : "—", 50, r.Rank is > 0 and <= 3 ? _gold : _muted, 21);`
- `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`；输入表达式：`Cell(row, r.Record, 140, _muted, 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cell(row, r.Record, 140, _muted, 15);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d5a59a")`；返回值紧邻使用处：`ConditionalExpressionSyntax: movement < 0 ? new Color("d5a59a") : _muted`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`headerMargin.AddThemeConstantOverride("margin_left", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: headerMargin.AddThemeConstantOverride("margin_left", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`headerMargin.AddThemeConstantOverride("margin_right", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: headerMargin.AddThemeConstantOverride("margin_right", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(r.PlayerRelated ? "254247" : i % 2 == 0 ? "192d3b" : "152532", r.PlayerRelated ? "5c9a9b" : "263e4c", 5, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(r.PlayerRelated ? "254247" : i % 2 == 0 ? "192d3b" : "152532", r.PlayerRelated ? "5c9a9b" : "263e4c", 5, 10));`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(scores)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(scores);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(headerMargin)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(headerMargin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(strip);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(table.Note, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(table.Note, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(table.Title, 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(table.Title, 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text("本赛事暂无新增完赛记录。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text("本赛事暂无新增完赛记录。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text(review.PreviousMatchDay != null ? "这期间的对阵" : "已结束的对阵", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text(review.PreviousMatchDay != null ? "这期间的对阵" : "已结束的对阵", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`intro.AddChild(Text("同期赛况   /   " + review.Name, 25, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: intro.AddChild(Text("同期赛况   /   " + review.Name, 25, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`intro.AddChild(Text(review.PreviousMatchDay is { } day              ? $"从你上次参加本赛事（{GameCalendar.Text(data, day)}）至本次结算 · 名次与积分变化均以该场结算为起点"              : "截至本次结算的赛事全貌 · 尚无上次排名记录，暂不显示升降", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: intro.AddChild(Text(review.PreviousMatchDay is { } day              ? $"从你上次参加本赛事（{GameCalendar.Text(data, day)}）至本次结算 · 名次与积分变化均以该场结算为起点"              : "截至本次结算的赛事全貌 · 尚无上次排名记录，暂不显示升降", 15, _muted));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Line(Godot.Control)`；输入表达式：`Line(headerMargin)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Line(headerMargin)`
- `Line(Godot.Control)`；输入表达式：`Line(strip)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Line(strip)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button($"查看全部对阵 · 共 {review.Scores.Count} 场", () => { }, 240)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button($"查看全部对阵 · 共 {review.Scores.Count} 场", () => { }, 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button($"展开完整榜单 · 共 {table.Rows.Count} {unit}", () => { }, 240)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button($"展开完整榜单 · 共 {table.Rows.Count} {unit}", () => { }, 240)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(heading)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(heading)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(scores)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(scores)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本赛事暂无新增完赛记录。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本赛事暂无新增完赛记录。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("同期赛况   /   " + review.Name, 25, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("同期赛况   /   " + review.Name, 25, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(review.PreviousMatchDay != null ? "这期间的对阵" : "已结束的对阵", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(review.PreviousMatchDay != null ? "这期间的对阵" : "已结束的对阵", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(review.PreviousMatchDay is { } day              ? $"从你上次参加本赛事（{GameCalendar.Text(data, day)}）至本次结算 · 名次与积分变化均以该场结算为起点"              : "截至本次结算的赛事全貌 · 尚无上次排名记录，暂不显示升降", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(review.PreviousMatchDay is { } day              ? $"从你上次参加本赛事（{GameCalendar.Text(data, day)}）至本次结算 · 名次与积分变化均以该场结算为起点"              : "截至本次结算的赛事全貌 · 尚无上次排名记录，暂不显示升降", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(table.Note, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(table.Note, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(table.Title, 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(table.Title, 23, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(r.PlayerRelated ? "254247" : i % 2 == 0 ? "192d3b" : "152532", r.PlayerRelated ? "5c9a9b" : "263e4c", 5, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(r.PlayerRelated ? "254247" : i % 2 == 0 ? "192d3b" : "152532", r.PlayerRelated ? "5c9a9b" : "263e4c", 5, 10)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, day)}`
- `NationalSpire.SettlementRecords.ScoreDuels(NationalSpire.CareerData, NationalSpire.CompetitionReview)`；输入表达式：`SettlementRecords.ScoreDuels(data, review)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SettlementRecords.ScoreDuels(data, review)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`table.Rows.Any(r => r.Record.Length > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = table.Rows.Any(r => r.Record.Length > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`review.Tables.Where(t => t.Rows.Count > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var table in review.Tables.Where(t => t.Rows.Count > 0))          {              var card = Card(); _content.AddChild(card); var box = Inner(card);              box.AddChild(Text(table.Title, 23, _gold)); box.AddChild(Text(table.Note, 14, _muted));              bool hasRecord = table.Rows.Any(r => r.Record.Length > 0);              HBoxContainer Line(Control parent)              {                  var line = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };                  line.AddThemeConstantOverride("separation", 16); parent.AddChild(line); return line;              }              void Cell(HBoxContainer row, string value, int width, Color color, int size = 17, bool expand = false)              {                  var label = Text(value, size, color); label.CustomMinimumSize = new Vector2(width, 0);                  label.SizeFlagsHorizontal = expand ? SizeFlags.ExpandFill : SizeFlags.Fill; row.AddChild(label);              }              var headerMargin = new MarginContainer(); headerMargin.AddThemeConstantOverride("margin_left", 10); headerMargin.AddThemeConstantOverride("margin_right", 10); box.AddChild(headerMargin);              var header = Line(headerMargin);              Cell(header, "名次", 50, _muted, 14); Cell(header, table.Id == "teams" ? "俱乐部" : table.Id == "nations" ? "国家 / 地区" : "选手", 180, _muted, 14, true);              if (hasRecord) Cell(header, "累计战绩", 140, _muted, 14);              Cell(header, table.Id == "nations" ? "国运 / 增量" : "积分 / 增量", 160, _muted, 14); Cell(header, "名次变化", 80, _muted, 14);              var extra = new List<Control>();              for (int i = 0; i < table.Rows.Count; i++)              {                  var r = table.Rows[i];                  var strip = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };                  strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(r.PlayerRelated ? "254247" : i % 2 == 0 ? "192d3b" : "152532", r.PlayerRelated ? "5c9a9b" : "263e4c", 5, 10));                  box.AddChild(strip); var row = Line(strip);                  Cell(row, r.Rank > 0 ? $"{r.Rank:00}" : "—", 50, r.Rank is > 0 and <= 3 ? _gold : _muted, 21);                  string marker = !r.PlayerRelated ? "" : table.Id == "teams" ? " · 你的俱乐部" : table.Id == "nations" ? " · 你的赛区" : " · 你";                  Cell(row, r.Name + marker, 180, r.PlayerRelated ? _gold : _ink, 18, true);                  if (hasRecord) Cell(row, r.Record, 140, _muted, 15);                  string delta = r.PreviousPoints is { } oldPoints ? $"   ({r.Points - oldPoints:+0;-0;0})" : "";                  Cell(row, r.Points + delta, 160, CareerVisuals.Teal, 18);                  string change = "—"; Color changeColor = _muted;                  if (r.PreviousRank is { } oldRank)                  {                      int movement = oldRank - r.Rank;                      change = oldRank == 0 && r.Rank > 0 ? "新上榜" : r.Rank == 0 && oldRank > 0 ? "暂未上榜" : movement == 0 ? "持平" : movement > 0 ? $"↑ {movement}" : $"↓ {-movement}";                      changeColor = change == "新上榜" || movement > 0 && r.Rank > 0 ? CareerVisuals.Teal : movement < 0 ? new Color("d5a59a") : _muted;                  }                  Cell(row, change, 80, changeColor, 16);                  if (i >= 8 && !r.PlayerRelated) { strip.Visible = false; extra.Add(strip); }              }              if (extra.Count > 0)              {                  bool expanded = false;                  string unit = table.Id == "teams" ? "支队伍" : table.Id == "nations" ? "个国家 / 地区" : "位";                  var toggle = Button($"展开完整榜单 · 共 {table.Rows.Count} {unit}", () => { }, 240); box.AddChild(toggle);                  toggle.Pressed += () => { expanded = !expanded; foreach (var row in extra) row.Visible = expanded; toggle.Text = expanded ? "收起榜单" : $"展开完整榜单 · 共 {table.Rows.Count} {unit}"; };              }          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`extra.Add(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: extra.Add(strip);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Control>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Control>()`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(6, review.Scores.Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: i < Math.Min(6, review.Scores.Count)`

**赋值（含属性/字段和局部值）：**

- `card.Visible` = `expanded`
- `change` = `oldRank == 0 && r.Rank > 0 ? "新上榜" : r.Rank == 0 && oldRank > 0 ? "暂未上榜" : movement == 0 ? "持平" : movement > 0 ? $"↑ {movement}" : $"↓ {-movement}"`
- `changeColor` = `change == "新上榜" || movement > 0 && r.Rank > 0 ? CareerVisuals.Teal : movement < 0 ? new Color("d5a59a") : _muted`
- `Columns` = `2`
- `expanded` = `!expanded`
- `heading.Name` = `"CompetitionOverview"`
- `row.Visible` = `expanded`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `strip.Visible` = `false`
- `toggle.Pressed` += `() =>              {                  expanded = !expanded;                  if (expanded && hidden.Count == 0) for (int i = 6; i < review.Scores.Count; i++) AddScore(i);                  foreach (var card in hidden) card.Visible = expanded;                  toggle.Text = expanded ? "收起对阵" : $"查看全部对阵 · 共 {review.Scores.Count} 场";              }`
- `toggle.Pressed` += `() => { expanded = !expanded; foreach (var row in extra) row.Visible = expanded; toggle.Text = expanded ? "收起榜单" : $"展开完整榜单 · 共 {table.Rows.Count} {unit}"; }`
- `toggle.Text` = `expanded ? "收起榜单" : $"展开完整榜单 · 共 {table.Rows.Count} {unit}"`
- `toggle.Text` = `expanded ? "收起对阵" : $"查看全部对阵 · 共 {review.Scores.Count} 场"`

<a id="symbol-046f975d03d3"></a>

## `Line(Godot.Control) — HBoxContainer Line(Control parent)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(line);`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-580816a1e5fe"></a>

## `Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool) — void Cell(HBoxContainer row, string value, int width, Color color, int size = 17, bool expand = false)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(width, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: label.CustomMinimumSize = new Vector2(width, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value, size, color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(value, size, color)`

**赋值（含属性/字段和局部值）：**

- `label.CustomMinimumSize` = `new Vector2(width, 0)`
- `label.SizeFlagsHorizontal` = `expand ? SizeFlags.ExpandFill : SizeFlags.Fill`

<a id="symbol-b679d06f3022"></a>

## `AddScore(int) — void AddScore(int i)`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)

**调用：** [`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.FixtureDetails(NationalSpire.CareerData, NationalSpire.CompetitionDuel)`](SettlementScreen.cs.md#symbol-432510bdd12f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.FixtureDetails(NationalSpire.CareerData, NationalSpire.CompetitionDuel)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CompetitionReview.Scores`；`NationalSpire.CompetitionScore.Away`；`NationalSpire.CompetitionScore.Day`；`NationalSpire.CompetitionScore.Home`；`NationalSpire.CompetitionScore.Outcome`；`NationalSpire.CompetitionScore.PlayerRelated`；`NationalSpire.CompetitionScore.Round`；`NationalSpire.CompetitionScore.Score`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(FixtureDetails(data, duel))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(FixtureDetails(data, duel));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{GameCalendar.Text(data, score.Day)} · {score.Round}", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{GameCalendar.Text(data, score.Day)} · {score.Round}", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{score.Home}   {score.Score}   {score.Away}", 20, score.PlayerRelated ? _gold : _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{score.Home}   {score.Score}   {score.Away}", 20, score.PlayerRelated ? _gold : _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(score.Outcome, 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(score.Outcome, 16, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(card);`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.FixtureDetails(NationalSpire.CareerData, NationalSpire.CompetitionDuel)`；输入表达式：`FixtureDetails(data, duel)`；返回值紧邻使用处：`ArgumentSyntax: FixtureDetails(data, duel)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, score.Day)} · {score.Round}", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, score.Day)} · {score.Round}", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{score.Home}   {score.Score}   {score.Away}", 20, score.PlayerRelated ? _gold : _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{score.Home}   {score.Score}   {score.Away}", 20, score.PlayerRelated ? _gold : _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(score.Outcome, 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(score.Outcome, 16, CareerVisuals.Teal)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, score.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, score.Day)}`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`hidden.Add(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: hidden.Add(card);`

**赋值（含属性/字段和局部值）：**

- `card.Name` = `"CompetitionScore" + i`

<a id="symbol-432510bdd12f"></a>

## `NationalSpire.CareerScreen.FixtureDetails(NationalSpire.CareerData, NationalSpire.CompetitionDuel) — private HBoxContainer FixtureDetails(CareerData data, CompetitionDuel duel)`

来源：源码第 222 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddScore(int)`](SettlementScreen.cs.md#symbol-b679d06f3022)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`](SettlementScreen.cs.md#symbol-ba1a6d1e9b72)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CompetitionDuel.Away`；`NationalSpire.CompetitionDuel.AwayPerformance`；`NationalSpire.CompetitionDuel.Home`；`NationalSpire.CompetitionDuel.HomePerformance`；`NationalSpire.CompetitionDuel.Status`；`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 8);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "FixtureDetails", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "FixtureDetails", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(versus)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(versus);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(20, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: versus.CustomMinimumSize = new(20, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(duel.Status == "平局" ? "平" : "VS", 12, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(duel.Status == "平局" ? "平" : "VS", 12, _muted)`
- `Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`；输入表达式：`Side(duel.Away, duel.AwayPerformance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(duel.Away, duel.AwayPerformance);`
- `Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`；输入表达式：`Side(duel.Home, duel.HomePerformance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(duel.Home, duel.HomePerformance);`

**赋值（含属性/字段和局部值）：**

- `Name` = `"FixtureDetails"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `versus.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `versus.CustomMinimumSize` = `new(20, 0)`
- `versus.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `versus.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-ba1a6d1e9b72"></a>

## `Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string) — void Side(List<CompetitionPlayer> players, string performance)`

来源：源码第 226 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureDetails(NationalSpire.CareerData, NationalSpire.CompetitionDuel)`](SettlementScreen.cs.md#symbol-432510bdd12f)

**调用：** [`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CompetitionDuel.Status`；`NationalSpire.CompetitionDuel.WinnerId`；`NationalSpire.CompetitionPlayer.Id`；`NationalSpire.CompetitionPlayer.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`name.AddThemeColorOverride("font_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddThemeColorOverride("font_color", _ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`link.AddThemeConstantOverride("separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: link.AddThemeConstantOverride("separation", 7);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`name.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", style)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", style);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(link)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(link);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(result)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(result);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`link.GetChild<Button>(1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = link.GetChild<Button>(1)`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 32)`；返回值紧邻使用处：`AssignmentExpressionSyntax: name.CustomMinimumSize = new(0, 32)`
- `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；输入表达式：`PersonLink(data, player.Id, player.Name, 32)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PersonLink(data, player.Id, player.Name, 32)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("胜", 14, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("胜", 14, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(performance.Length > 0 ? performance : duel.Status, 14, color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(performance.Length > 0 ? performance : duel.Status, 14, color)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(won ? "14332f" : "10232f", won ? "437e70" : "29424f", 6, 9)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box(won ? "14332f" : "10232f", won ? "437e70" : "29424f", 6, 9)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`players.Any(p => p.Id == duel.WinnerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: duel.WinnerId.Length > 0 && players.Any(p => p.Id == duel.WinnerId)`

**赋值（含属性/字段和局部值）：**

- `badge.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `badge.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `name.CustomMinimumSize` = `new(0, 32)`
- `name.Flat` = `true`
- `result.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `1`
- `style.BorderWidthLeft` = `won ? 3 : 1`

<a id="symbol-9da5b512a4ff"></a>

## `NationalSpire.MatchMedallion.Victory — public bool Victory`

来源：源码第 264 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d0ce5e7dbf45"></a>

## `NationalSpire.MatchMedallion.Accent — public Color Accent`

来源：源码第 265 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Gold`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-511923326c2e"></a>

## `NationalSpire.MatchMedallion._Draw() — public override void _Draw()`

来源：源码第 266 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](SettlementScreen.cs.md#symbol-13aca1a9022b)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.CanvasItem.DrawSetTransform(Godot.Vector2, float, Godot.Vector2?)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Darkened(float)`；`Godot.Color.Lightened(float)`；`Godot.Mathf.Cos(float)`；`Godot.Mathf.DegToRad(float)`；`Godot.Mathf.Sin(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchMedallion.Accent`；`NationalSpire.MatchMedallion.Victory`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(P(-24, -17), 12, Mathf.Pi * .5f, Mathf.Pi * 1.5f, 14, Accent, 4, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(P(-24, -17), 12, Mathf.Pi * .5f, Mathf.Pi * 1.5f, 14, Accent, 4, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(P(24, -17), 12, -Mathf.Pi * .5f, Mathf.Pi * .5f, 14, Accent, 4, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(P(24, -17), 12, -Mathf.Pi * .5f, Mathf.Pi * .5f, 14, Accent, 4, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center, 77, new Color(Accent, .07f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center, 77, new Color(Accent, .07f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(-25, -27), P(0, -27), P(0, 17), P(-19, 1)], Accent.Lightened(.22f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(-25, -27), P(0, -27), P(0, 17), P(-19, 1)], Accent.Lightened(.22f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(-25, -27), P(25, -27), P(19, 1), P(0, 17), P(-19, 1)], Accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(-25, -27), P(25, -27), P(19, 1), P(0, 17), P(-19, 1)], Accent);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(0, -29), P(0, 29), P(-21, 0)], Accent.Lightened(.22f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(0, -29), P(0, 29), P(-21, 0)], Accent.Lightened(.22f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(0, -29), P(21, 0), P(0, 29), P(-21, 0)], Accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(0, -29), P(21, 0), P(0, 29), P(-21, 0)], Accent);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([stem, stem + new Vector2(side * 15, -9), stem + new Vector2(side * 12, -24), stem + new Vector2(side * 2, -14)], i % 2 == 0 ? Accent : Accent.Darkened(.3f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([stem, stem + new Vector2(side * 15, -9), stem + new Vector2(side * 12, -24), stem + new Vector2(side * 2, -14)], i % 2 == 0 ? Accent : Accent.Darkened(.3f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(rim[..^1], new Color("122435"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(rim[..^1], new Color("122435"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-16, 30), P(16, 30), Accent, 5, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-16, 30), P(16, 30), Accent, 5, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(0, 12), P(0, 29), Accent, 5, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(0, 12), P(0, 29), Accent, 5, true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(rim, Accent, 3, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(rim, Accent, 3, true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(rim.Select(p => center + (p - center) * .86f).ToArray(), Accent.Darkened(.45f), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(rim.Select(p => center + (p - center) * .86f).ToArray(), Accent.Darkened(.45f), 1, true);`
- `Godot.CanvasItem.DrawSetTransform(Godot.Vector2, float, Godot.Vector2?)`；输入表达式：`DrawSetTransform(Size/2,0,Vector2.One*scale)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawSetTransform(Size/2,0,Vector2.One*scale);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Accent, .07f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Accent, .07f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("122435")`；返回值紧邻使用处：`ArgumentSyntax: new Color("122435")`
- `Godot.Color.Darkened(float)`；输入表达式：`Accent.Darkened(.3f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i % 2 == 0 ? Accent : Accent.Darkened(.3f)`
- `Godot.Color.Darkened(float)`；输入表达式：`Accent.Darkened(.45f)`；返回值紧邻使用处：`ArgumentSyntax: Accent.Darkened(.45f)`
- `Godot.Color.Lightened(float)`；输入表达式：`Accent.Lightened(.22f)`；返回值紧邻使用处：`ArgumentSyntax: Accent.Lightened(.22f)`
- `Godot.Mathf.Cos(float)`；输入表达式：`Mathf.Cos(angle)`；返回值紧邻使用处：`BinaryExpressionSyntax: 65 * Mathf.Cos(angle)`
- `Godot.Mathf.DegToRad(float)`；输入表达式：`Mathf.DegToRad(24 + i * 18)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mathf.DegToRad(24 + i * 18)`
- `Godot.Mathf.Sin(float)`；输入表达式：`Mathf.Sin(angle)`；返回值紧邻使用处：`BinaryExpressionSyntax: side * 65 * Mathf.Sin(angle)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side * 12, -24)`；返回值紧邻使用处：`BinaryExpressionSyntax: stem + new Vector2(side * 12, -24)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side * 15, -9)`；返回值紧邻使用处：`BinaryExpressionSyntax: stem + new Vector2(side * 15, -9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side * 2, -14)`；返回值紧邻使用处：`BinaryExpressionSyntax: stem + new Vector2(side * 2, -14)`
- `P(float, float)`；输入表达式：`P(-16, 30)`；返回值紧邻使用处：`ArgumentSyntax: P(-16, 30)`
- `P(float, float)`；输入表达式：`P(-19, 1)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-19, 1)`
- `P(float, float)`；输入表达式：`P(-21, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-21, 0)`
- `P(float, float)`；输入表达式：`P(-24, -17)`；返回值紧邻使用处：`ArgumentSyntax: P(-24, -17)`
- `P(float, float)`；输入表达式：`P(-25, -27)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-25, -27)`
- `P(float, float)`；输入表达式：`P(-48, -34)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-48, -34)`
- `P(float, float)`；输入表达式：`P(-48, 26)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-48, 26)`
- `P(float, float)`；输入表达式：`P(0, -27)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -27)`
- `P(float, float)`；输入表达式：`P(0, -29)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -29)`
- `P(float, float)`；输入表达式：`P(0, -64)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -64)`
- `P(float, float)`；输入表达式：`P(0, 12)`；返回值紧邻使用处：`ArgumentSyntax: P(0, 12)`
- `P(float, float)`；输入表达式：`P(0, 17)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, 17)`
- `P(float, float)`；输入表达式：`P(0, 29)`；返回值紧邻使用处：`ArgumentSyntax: P(0, 29)`
- `P(float, float)`；输入表达式：`P(0, 29)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, 29)`
- `P(float, float)`；输入表达式：`P(0, 59)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, 59)`
- `P(float, float)`；输入表达式：`P(16, 30)`；返回值紧邻使用处：`ArgumentSyntax: P(16, 30)`
- `P(float, float)`；输入表达式：`P(19, 1)`；返回值紧邻使用处：`ExpressionElementSyntax: P(19, 1)`
- `P(float, float)`；输入表达式：`P(21, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: P(21, 0)`
- `P(float, float)`；输入表达式：`P(24, -17)`；返回值紧邻使用处：`ArgumentSyntax: P(24, -17)`
- `P(float, float)`；输入表达式：`P(25, -27)`；返回值紧邻使用处：`ExpressionElementSyntax: P(25, -27)`
- `P(float, float)`；输入表达式：`P(48, -34)`；返回值紧邻使用处：`ExpressionElementSyntax: P(48, -34)`
- `P(float, float)`；输入表达式：`P(48, 26)`；返回值紧邻使用处：`ExpressionElementSyntax: P(48, 26)`
- `P(float, float)`；输入表达式：`P(side * 65 * Mathf.Sin(angle), 65 * Mathf.Cos(angle))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = P(side * 65 * Mathf.Sin(angle), 65 * Mathf.Cos(angle))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rim.Select(p => center + (p - center) * .86f)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rim.Select(p => center + (p - center) * .86f).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`rim.Select(p => center + (p - center) * .86f).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: rim.Select(p => center + (p - center) * .86f).ToArray()`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1f,Math.Min(Size.X/162f,Size.Y/162f))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(1f,Math.Min(Size.X/162f,Size.Y/162f))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X/162f,Size.Y/162f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(Size.X/162f,Size.Y/162f)`

**赋值（含属性/字段和局部值）：**

- `side` += `2`

<a id="symbol-13aca1a9022b"></a>

## `P(float, float) — Vector2 P(float x,float y)`

来源：源码第 271 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchMedallion._Draw()`](SettlementScreen.cs.md#symbol-511923326c2e)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,y)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(x,y)`

**赋值（含属性/字段和局部值）：**
