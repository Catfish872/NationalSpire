# LifeScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`65CA40E3088892F714A4FAB8E972DB8DD22BF339A4F97F5F990157319E6AA2A2`。来源：[源码](../../LifeScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private string _lifeSection = "活动与计划";
private int _lifeHistoryLimit = 8;
```

<a id="symbol-0cdff88b6131"></a>

## `NationalSpire.CareerScreen.Life(NationalSpire.CareerData) — private void Life(CareerData d)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-efe3762d8665)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)；[`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Abs(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.Ledger`；`NationalSpire.CareerLifeState.PrizeTotal`；`NationalSpire.CareerLifeState.RepairNotices`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen.AddHeading(string, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.FinanceEntry.Amount`；`NationalSpire.FinanceEntry.Balance`；`NationalSpire.FinanceEntry.Day`；`NationalSpire.FinanceEntry.Title`；`NationalSpire.LifeActivity.ExpiresDay`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.LifestyleArt.Sections`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tab.AddThemeConstantOverride("icon_max_width", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: tab.AddThemeConstantOverride("icon_max_width", 22);`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("查看更多经历", () => { _lifeHistoryLimit += 8; Render(); }, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("查看更多经历", () => { _lifeHistoryLimit += 8; Render(); }, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("这轮先不安排", () => ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); }), 210))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("这轮先不安排", () => ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); }), 210));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("留下的经历", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("留下的经历", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("新的收入和花销会记在这里。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("新的收入和花销会记在这里。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("暂时没有新的活动邀请。日程推进后，会陆续出现新的机会。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("暂时没有新的活动邀请。日程推进后，会陆续出现新的机会。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("这一轮，想做些什么？", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("这一轮，想做些什么？", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("正在进行", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("正在进行", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"从 {available.Count} 项安排中选择一项。其他邀请随本轮结束，之后还会有新的机会。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"从 {available.Count} 项安排中选择一项。其他邀请随本轮结束，之后还会有新的机会。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"第{entry.Day}天 · {entry.Title}\n{(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))} · 余额 {CareerMoney.Format(entry.Balance)}", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"第{entry.Day}天 · {entry.Title}\n{(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))} · 余额 {CareerMoney.Format(entry.Balance)}", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"可用资金 {CareerMoney.Format(CareerMoney.Balance(d))} · 已记录比赛奖金 {CareerMoney.Format(d.Life.PrizeTotal)}", 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"可用资金 {CareerMoney.Format(CareerMoney.Balance(d))} · 已记录比赛奖金 {CareerMoney.Format(d.Life.PrizeTotal)}", 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text(message, 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text(message, 16, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(tab);`
- `NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`；输入表达式：`CareerLife.SkipRound(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.SkipRound(d);`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(d)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerMoney.Balance(d))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(CareerMoney.Balance(d))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(d.Life.PrizeTotal)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(d.Life.PrizeTotal)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(entry.Balance)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(entry.Balance)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(Math.Abs((long)entry.Amount))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(Math.Abs((long)entry.Amount))}`
- `NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ActivityCard(d, a)`；返回值紧邻使用处：`ExpressionStatementSyntax: ActivityCard(d, a);`
- `NationalSpire.CareerScreen.AddHeading(string, string)`；输入表达式：`AddHeading("赛场之外", "安排一点自己的生活，也看看这些选择后来怎样了。")`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading("赛场之外", "安排一点自己的生活，也看看这些选择后来怎样了。");`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看更多经历", () => { _lifeHistoryLimit += 8; Render(); }, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看更多经历", () => { _lifeHistoryLimit += 8; Render(); }, 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("这轮先不安排", () => ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); }), 210)`；返回值紧邻使用处：`ArgumentSyntax: Button("这轮先不安排", () => ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); }), 210)`
- `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；输入表达式：`ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); })`
- `NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`；输入表达式：`ConsumerShop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerShop(d);`
- `NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`；输入表达式：`FanChart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: FanChart(d);`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(name, _lifeSection == name, () => { _lifeSection = name; _lifeHistoryLimit = 8; Render(); }, 165)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(name, _lifeSection == name, () => { _lifeSection = name; _lifeHistoryLimit = 8; Render(); }, 165)`
- `NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`；输入表达式：`LifeCollection(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: LifeCollection(d);`
- `NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`；输入表达式：`LifeNews(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: LifeNews(d);`
- `NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`；输入表达式：`MarketScreen(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketScreen(d);`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("skip")`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("skip")) return;`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("留下的经历", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("留下的经历", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("新的收入和花销会记在这里。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("新的收入和花销会记在这里。", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂时没有新的活动邀请。日程推进后，会陆续出现新的机会。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂时没有新的活动邀请。日程推进后，会陆续出现新的机会。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("这一轮，想做些什么？", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("这一轮，想做些什么？", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("正在进行", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("正在进行", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"从 {available.Count} 项安排中选择一项。其他邀请随本轮结束，之后还会有新的机会。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"从 {available.Count} 项安排中选择一项。其他邀请随本轮结束，之后还会有新的机会。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第{entry.Day}天 · {entry.Title}\n{(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))} · 余额 {CareerMoney.Format(entry.Balance)}", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第{entry.Day}天 · {entry.Title}\n{(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))} · 余额 {CareerMoney.Format(entry.Balance)}", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"可用资金 {CareerMoney.Format(CareerMoney.Balance(d))} · 已记录比赛奖金 {CareerMoney.Format(d.Life.PrizeTotal)}", 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"可用资金 {CareerMoney.Format(CareerMoney.Balance(d))} · 已记录比赛奖金 {CareerMoney.Format(d.Life.PrizeTotal)}", 18, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(message, 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(message, 16, CareerVisuals.Teal)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: tab.Icon = LifestyleArt.Icon(name)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`d.Life.Ledger.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Ledger.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "进行中").OrderBy(a => a.FinishDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "进行中").OrderBy(a => a.FinishDay).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "已完成").OrderByDescending(a => a.FinishDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "已完成").OrderByDescending(a => a.FinishDay).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`d.Life.Ledger.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Ledger.AsEnumerable().Reverse().Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`completed.Take(_lifeHistoryLimit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in completed.Take(_lifeHistoryLimit)) ActivityCard(d, a);`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Life.Ledger.AsEnumerable().Reverse().Take(40)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var entry in d.Life.Ledger.AsEnumerable().Reverse().Take(40))                  _content.AddChild(Text($"第{entry.Day}天 · {entry.Title}\n{(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))} · 余额 {CareerMoney.Format(entry.Balance)}", 18, _ink));`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`d.Life.RepairNotices.TakeLast(4)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string message in d.Life.RepairNotices.TakeLast(4)) _content.AddChild(Text(message, 16, CareerVisuals.Teal));`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status == "进行中").OrderBy(a => a.FinishDay).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.Where(a => a.Status == "进行中").OrderBy(a => a.FinishDay).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status == "已完成").OrderByDescending(a => a.FinishDay).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.Where(a => a.Status == "已完成").OrderByDescending(a => a.FinishDay).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "进行中")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "进行中").OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "已完成")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "已完成").OrderByDescending`
- `System.Math.Abs(long)`；输入表达式：`Math.Abs((long)entry.Amount)`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs((long)entry.Amount)`

**赋值（含属性/字段和局部值）：**

- `_lifeHistoryLimit` += `8`
- `_lifeHistoryLimit` = `8`
- `_lifeSection` = `name`
- `tab.Icon` = `LifestyleArt.Icon(name)`

<a id="symbol-5b3e0aaad277"></a>

## `NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity) — private void ActivityCard(CareerData d, LifeActivity a)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-44d430d90686)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-648cf5a95449)；[`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-5a1db0b8215e)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`](CareerTraining.cs.md#symbol-4b84e446c2e4)；[`NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-2710ec7157e0)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.CareerTraining.Kind(string)`](CareerTraining.cs.md#symbol-f1d9371f3455)；[`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-89a5b7a8727b)；[`NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-53ba79900734)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Kind(string)`；`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Detail`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.PaidCost`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(accept)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(accept);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(effects)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(effects);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(select)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(select);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"费用 {CareerMoney.Format(cost)} · {duration} 天", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"费用 {CareerMoney.Format(cost)} · {duration} 天", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"原价 {CareerMoney.Format(a.Cost)} / {a.Duration} 天 · 已计入当前筹备与手办优惠", 14, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"原价 {CareerMoney.Format(a.Cost)} / {a.Duration} 天 · 已计入当前筹备与手办优惠", 14, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(a.Result, 18, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(a.Result, 18, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(a.Status == "进行中" ? $"第{a.StartedDay}天开始 · 预计第{a.FinishDay}天完成" : $"第{a.FinishDay}天完成 · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(a.Status == "进行中" ? $"第{a.StartedDay}天开始 · 预计第{a.FinishDay}天完成" : $"第{a.FinishDay}天完成 · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(a.Title + " · " + a.Kind, 22, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(a.Title + " · " + a.Kind, 22, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(CareerLife.Expected(d, a), 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(CareerLife.Expected(d, a), 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(detail, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(detail, 17, _ink));`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`select.AddItem(p.PublicName + (CareerTraining.ActiveRoster(d, p.Id) ? " · 当前参赛" : " · 轮换"))`；返回值紧邻使用处：`ExpressionStatementSyntax: select.AddItem(p.PublicName + (CareerTraining.ActiveRoster(d, p.Id) ? " · 当前参赛" : " · 轮换"));`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { CustomMinimumSize = new Vector2(280, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { CustomMinimumSize = new Vector2(280, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.OptionButton.Select(int)`；输入表达式：`select.Select(Math.Max(0, people.FindIndex(p => p.Id == a.PersonId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: select.Select(Math.Max(0, people.FindIndex(p => p.Id == a.PersonId)));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(280, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(280, 44)`
- `NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`；输入表达式：`CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : "")`
- `NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerLife.Expected(d, a)`；返回值紧邻使用处：`ArgumentSyntax: CareerLife.Expected(d, a)`
- `NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerLife.Expected(d, a)`；返回值紧邻使用处：`InterpolationSyntax: {CareerLife.Expected(d, a)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(a.Cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(a.Cost)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerRelics.Cost(d, a))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(CareerRelics.Cost(d, a))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(cost)}`
- `NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Cost(d, a)`；返回值紧邻使用处：`ArgumentSyntax: CareerRelics.Cost(d, a)`
- `NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Cost(d, a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Cost(d, a)`
- `NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Duration(d, a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Duration(d, a)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("选择这项安排", () => ConfirmLife("确认安排", $"{a.Title}\n{CareerLife.Expected(d, a)}\n费用 {CareerMoney.Format(CareerRelics.Cost(d, a))}，本轮只选这一项。", () => { if (MultiplayerCommand("activity", a.Id)) return; var error = CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : ""); Render(); Notice(error ?? "安排已确认，可以在这里查看进展。", error != null); }), 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("选择这项安排", () => ConfirmLife("确认安排", $"{a.Title}\n{CareerLife.Expected(d, a)}\n费用 {CareerMoney.Format(CareerRelics.Cost(d, a))}，本轮只选这一项。", () => { if (MultiplayerCommand("activity", a.Id)) return; var error = CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : ""); Render(); Notice(error ?? "安排已确认，可以在这里查看进展。", error != null); }), 180)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；输入表达式：`ConfirmLife("确认安排", $"{a.Title}\n{CareerLife.Expected(d, a)}\n费用 {CareerMoney.Format(CareerRelics.Cost(d, a))}，本轮只选这一项。", () => { if (MultiplayerCommand("activity", a.Id)) return; var error = CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : ""); Render(); Notice(error ?? "安排已确认，可以在这里查看进展。", error != null); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmLife("确认安排", $"{a.Title}\n{CareerLife.Expected(d, a)}\n费用 {CareerMoney.Format(CareerRelics.Cost(d, a))}，本轮只选这一项。", () => { if (MultiplayerCommand("activity", a.Id)) return; var error = CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : ""); Render(); Notice(error ?? "安排已确认，可以在这里查看进展。", error != null); })`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("activity", a.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("activity", a.Id)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error ?? "安排已确认，可以在这里查看进展。", error != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error ?? "安排已确认，可以在这里查看进展。", error != null);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"费用 {CareerMoney.Format(cost)} · {duration} 天", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"费用 {CareerMoney.Format(cost)} · {duration} 天", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"原价 {CareerMoney.Format(a.Cost)} / {a.Duration} 天 · 已计入当前筹备与手办优惠", 14, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"原价 {CareerMoney.Format(a.Cost)} / {a.Duration} 天 · 已计入当前筹备与手办优惠", 14, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(a.Result, 18, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(a.Result, 18, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(a.Status == "进行中" ? $"第{a.StartedDay}天开始 · 预计第{a.FinishDay}天完成" : $"第{a.FinishDay}天完成 · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(a.Status == "进行中" ? $"第{a.StartedDay}天开始 · 预计第{a.FinishDay}天完成" : $"第{a.FinishDay}天完成 · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(a.Title + " · " + a.Kind, 22, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(a.Title + " · " + a.Kind, 22, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerLife.Expected(d, a), 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerLife.Expected(d, a), 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerLife.Expected(d, a), 19, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(CareerLife.Expected(d, a), 19, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(detail, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(detail, 17, _ink)`
- `NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`；输入表达式：`CareerTraining.ActiveRoster(d, p.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerTraining.ActiveRoster(d, p.Id) ? " · 当前参赛" : " · 轮换"`
- `NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Details(d, a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubPrograms.IsTraining(a) ? ClubPrograms.Details(d, a) : CareerTraining.Details(d, a)`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) && CareerTraining.Kind(a.Title) is not ("team" or "team-growth")`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerTraining.IsTraining(a) ? a.PersonId : ""`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerTraining.IsTraining(a)`
- `NationalSpire.CareerTraining.Kind(string)`；输入表达式：`CareerTraining.Kind(a.Title)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerTraining.Kind(a.Title) is not ("team" or "team-growth")`
- `NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Targets(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerTraining.Targets(d)`
- `NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Details(d, a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubPrograms.IsTraining(a) ? ClubPrograms.Details(d, a) : CareerTraining.Details(d, a)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubPrograms.IsTraining(a) ? ClubPrograms.Details(d, a) : CareerTraining.Details(d, a)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubPrograms.IsTraining(a)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`a.Detail.Split('。')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: a.Detail.Split('。')[0]`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")`；返回值紧邻使用处：`BinaryExpressionSyntax: a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`people.FindIndex(p => p.Id == a.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: people.FindIndex(p => p.Id == a.PersonId)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, people.FindIndex(p => p.Id == a.PersonId))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, people.FindIndex(p => p.Id == a.PersonId))`

**赋值（含属性/字段和局部值）：**

- `a.PersonId` = `people[(int)index].Id`
- `accept.Disabled` = `d.Credits < cost || a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")`
- `CustomMinimumSize` = `new Vector2(280, 44)`
- `effects.MouseDefaultCursorShape` = `CursorShape.Help`
- `effects.MouseFilter` = `MouseFilterEnum.Pass`
- `effects.TooltipText` = `ClubPrograms.IsTraining(a) ? ClubPrograms.Details(d, a) : CareerTraining.Details(d, a)`
- `select.ItemSelected` += `index => { a.PersonId = people[(int)index].Id; Render(); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-d61ca43b835f"></a>

## `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action) — private void ConfirmLife(string title, string question, Action action)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`](CareerDialog.cs.md#symbol-ecc011933bb1)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；输入表达式：`ShowCareerDialog(title, question, () => { action(); return true; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ShowCareerDialog(title, question, () => { action(); return true; })`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7fd7cd27279c"></a>

## `NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData) — private void LifeCollection(CareerData d)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-5393973f2695)；[`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-b30378b84f42)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-4344e458a80a)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `(string Country, int Points).Country`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Collection`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerLifeState.RestockDay`；`NationalSpire.CareerLifeState.Shop`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`；`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`owned.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`owned.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.AddThemeConstantOverride("v_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`store.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: store.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`store.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: store.AddThemeConstantOverride("v_separation", 16);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(owned)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(owned);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(store)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(store);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("◆ " + item, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("◆ " + item, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("生活纪念", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("生活纪念", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("已拥有的收藏", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("已拥有的收藏", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · 第 {d.Life.RestockDay} 天上新", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · 第 {d.Life.RestockDay} 天上新", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold));`
- `NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Offers(d)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in CareerRelics.Offers(d)) FigurineCard(d, store, item, false);`
- `NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Shop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Shop(d);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190)`
- `NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`；输入表达式：`FigurineCard(d, owned, item, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: FigurineCard(d, owned, item, true);`
- `NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`；输入表达式：`FigurineCard(d, store, item, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: FigurineCard(d, store, item, false);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("◆ " + item, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("◆ " + item, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("生活纪念", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("生活纪念", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("已拥有的收藏", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("已拥有的收藏", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · 第 {d.Life.RestockDay} 天上新", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · 第 {d.Life.RestockDay} 天上新", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold)`
- `NationalSpire.CircuitLedger.NationTable(NationalSpire.CareerData)`；输入表达式：`CircuitLedger.NationTable(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CircuitLedger.NationTable(d).FindIndex`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Life.Figurines.ContainsKey(r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => d.Life.Figurines.ContainsKey(r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse()) _content.AddChild(Text("◆ " + item, 17, _ink));`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`d.Life.Collection.Values.TakeLast(_lifeHistoryLimit)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerRelics.Catalog.Where(r => d.Life.Figurines.ContainsKey(r.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in CareerRelics.Catalog.Where(r => d.Life.Figurines.ContainsKey(r.Id))) FigurineCard(d, owned, item, true);`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1`

**赋值（含属性/字段和局部值）：**

- `_lifeHistoryLimit` += `12`
- `Columns` = `2`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-8732620351f6"></a>

## `NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool) — private void FigurineCard(CareerData d, GridContainer parent, CareerRelics.Item item, bool owned)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-0475739162e2)；[`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-27dcdb7c3aa9)；[`NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-cdd79095d49f)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.RelicArt.Read(string)`](RelicArt.cs.md#symbol-1d35c476ee42)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Item.Effect`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerRelics.Item.Price`；`NationalSpire.CareerRelics.Item.Uses`；`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.RelicArt.Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(purchase)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(purchase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(item.Effect, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(item.Effect, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text("◆", 40, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text("◆", 40, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(Text(item.Name + " · 手办", 22, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(Text(item.Name + " · 手办", 22, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal));`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(76, 76)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(76, 76)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerRelics.PurchasePrice(d, item))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(item.Price)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(item.Price)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price)`
- `NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`；输入表达式：`CareerRelics.Buy(d, item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Buy(d, item.Id)`
- `NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.CanBuy(d, item)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.CanBuy(d, item)`
- `NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.PurchasePrice(d, item)`；返回值紧邻使用处：`ArgumentSyntax: CareerRelics.PurchasePrice(d, item)`
- `NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.PurchasePrice(d, item)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.PurchasePrice(d, item)`
- `NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CareerRelics.Status(d, item)`；返回值紧邻使用处：`ConditionalExpressionSyntax: owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(refill ? "重新购买 · 恢复次数" : collected ? "已经收藏" : "购买手办", () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); }), 170)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(refill ? "重新购买 · 恢复次数" : collected ? "已经收藏" : "购买手办", () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); }), 170)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；输入表达式：`ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>              { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); })`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("relic", item.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("relic", item.Id)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("◆", 40, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("◆", 40, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(item.Effect, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(item.Effect, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(item.Name + " · 手办", 22, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(item.Name + " · 手办", 22, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal)`
- `NationalSpire.RelicArt.Read(string)`；输入表达式：`RelicArt.Read(item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RelicArt.Read(item.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Life.Figurines.ContainsKey(item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Figurines.ContainsKey(item.Id)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(76, 76)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `purchase.Disabled` = `!canBuy || d.Credits < price`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `texture`

<a id="symbol-b0bc87216d33"></a>

## `NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData) — private void RenamePlayer(CareerData data)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`](CareerNames.cs.md#symbol-68b4cb4672cb)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`](CareerDialog.cs.md#symbol-ecc011933bb1)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.GrabFocus()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`.GrabFocus()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: input?.GrabFocus()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(500, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(500, 48)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = CareerEngine.Name(data)`
- `NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`；输入表达式：`CareerNames.Rename(data, input.Text)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerNames.Rename(data, input.Text) is { } error`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("rename", text: input.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("rename", text: input.Text)) return true;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("游戏名已更新。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("游戏名已更新。", false);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；输入表达式：`ShowCareerDialog("修改游戏名", "只修改当前生涯的名字。旧帖子保留原文，点击旧名字仍可查看你的档案。", () =>          {              if (MultiplayerCommand("rename", text: input.Text)) return true;              if (CareerNames.Rename(data, input.Text) is { } error) { status.Text = error; return false; }              Render(); Notice("游戏名已更新。", false); return true;          }, "确认改名", box =>          {              input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }; box.AddChild(input);              status = Text("旧内容保留原名。", 16, _muted); box.AddChild(status);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("修改游戏名", "只修改当前生涯的名字。旧帖子保留原文，点击旧名字仍可查看你的档案。", () =>          {              if (MultiplayerCommand("rename", text: input.Text)) return true;              if (CareerNames.Rename(data, input.Text) is { } error) { status.Text = error; return false; }              Render(); Notice("游戏名已更新。", false); return true;          }, "确认改名", box =>          {              input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }; box.AddChild(input);              status = Text("旧内容保留原名。", 16, _muted); box.AddChild(status);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("旧内容保留原名。", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("旧内容保留原名。", 16, _muted)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(500, 48)`
- `input` = `new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }`
- `Name` = `"CareerRenameInput"`
- `status.Text` = `error`
- `status` = `Text("旧内容保留原名。", 16, _muted)`
- `Text` = `CareerEngine.Name(data)`

<a id="symbol-825caeb63a3b"></a>

## `NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData) — private void LifeNews(CareerData d)`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.LifeEvent.Day`；`NationalSpire.LifeEvent.Detail`；`NationalSpire.LifeEvent.Important`；`NationalSpire.LifeEvent.PostId`；`NationalSpire.LifeEvent.Title`；`NationalSpire.LifeEvent.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("公开活动和项目成果会在这里公布。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("公开活动和项目成果会在这里公布。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("活动公告与公开进展", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("活动公告与公开进展", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第{e.Day}天 · {e.Topic}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第{e.Day}天 · {e.Topic}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(e.Detail, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(e.Detail, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(e.Title, 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(e.Title, 21, _gold));`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看相关讨论", () => OpenPost(post), 190)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看相关讨论", () => OpenPost(post), 190)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPost(post)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("公开活动和项目成果会在这里公布。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("公开活动和项目成果会在这里公布。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("活动公告与公开进展", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("活动公告与公开进展", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第{e.Day}天 · {e.Topic}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第{e.Day}天 · {e.Topic}", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(e.Detail, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(e.Detail, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(e.Title, 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(e.Title, 21, _gold)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed")`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Events.OrderByDescending(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`events.Take(_lifeHistoryLimit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var e in events.Take(_lifeHistoryLimit))          {              var card = Card(); _content.AddChild(card); var box = Inner(card);              box.AddChild(Text(e.Title, 21, _gold)); box.AddChild(Text($"第{e.Day}天 · {e.Topic}", 15, _muted)); box.AddChild(Text(e.Detail, 17, _ink));              var post = CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed");              if (post != null) box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190));          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList`

**赋值（含属性/字段和局部值）：**

- `_lifeHistoryLimit` += `12`
