# WeeklyScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D44610F00B600A0037201B080AAE5D8C5EABE16200C1A1099E26CC0DDD136C67`。来源：[源码](../../WeeklyScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private int _weeklyIndex;
private int _weeklyWeek;
private int _latestWeeklyPublished;
private VBoxContainer? _weeklyContent;
private double _weeklyClock;
private const double WeeklyInterval = 10;
private Tween? _weeklyTween;
private bool _weeklyAuto = true;
private ProgressBar? _weeklyProgress;
private OptionButton? _weeklySelector;
private readonly HashSet<int> _weeklyCeremonyShown = [];
```

<a id="symbol-86166c5fd833"></a>

## `NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData) — private void WeeklyCarousel(CareerData data)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`](AiWeekly.cs.md#symbol-fbf35e9ecdeb)；[`NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-29d9526009c4)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemId(int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.PanelContainer.PanelContainer()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`；`NationalSpire.AiWorkState.State`；`NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._latestWeeklyPublished`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._weeklyCeremonyShown`；`NationalSpire.CareerScreen._weeklyClock`；`NationalSpire.CareerScreen._weeklyContent`；`NationalSpire.CareerScreen._weeklyIndex`；`NationalSpire.CareerScreen._weeklySelector`；`NationalSpire.CareerScreen._weeklyWeek`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.WeeklyEdition.EndDay`；`NationalSpire.WeeklyEdition.NewsWork`；`NationalSpire.WeeklyEdition.PeriodLabel`；`NationalSpire.WeeklyEdition.ProfilesWork`；`NationalSpire.WeeklyEdition.StartDay`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklySlide.CeremonySeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`viewport.AddThemeStyleboxOverride("panel", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: viewport.AddThemeStyleboxOverride("panel", new StyleBoxEmpty());`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(section)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(section);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第 {edition.Week} 周 · 选手介绍", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第 {edition.Week} 周 · 选手介绍", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"第 {edition.Week} 周 · 周刊精选", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"第 {edition.Week} 周 · 周刊精选", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(latest.NewsWork.State == "disabled" ? "开启 AI 后，这里会刊登双周精选。" : "本期精选正在整理，稍后就能阅读。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(latest.NewsWork.State == "disabled" ? "开启 AI 后，这里会刊登双周精选。" : "本期精选正在整理，稍后就能阅读。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(viewport)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(viewport);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(headingText)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(headingText);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(select)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(select);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`viewport.AddChild(_weeklyContent)`；返回值紧邻使用处：`ExpressionStatementSyntax: viewport.AddChild(_weeklyContent);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`select.AddItem($"{edition.PeriodLabel} · 第 {edition.StartDay}—{edition.EndDay} 天", edition.Week)`；返回值紧邻使用处：`ExpressionStatementSyntax: select.AddItem($"{edition.PeriodLabel} · 第 {edition.StartDay}—{edition.EndDay} 天", edition.Week);`
- `Godot.OptionButton.GetItemId(int)`；输入表达式：`select.GetItemId((int)index)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _weeklyWeek = select.GetItemId((int)index)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "WeeklyEditionSelector", CustomMinimumSize = new Vector2(210, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "WeeklyEditionSelector", CustomMinimumSize = new Vector2(210, 44) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`select.Select(published.FindIndex(w => w.Week == _weeklyWeek))`；返回值紧邻使用处：`ExpressionStatementSyntax: select.Select(published.FindIndex(w => w.Week == _weeklyWeek));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { ClipContents = true, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { ClipContents = true, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "WeeklyCarousel", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _weeklyContent = new VBoxContainer { Name = "WeeklyCarousel", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(210, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(210, 44)`
- `NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`；输入表达式：`AiService.RetryWeeklyAsync(edition.Week, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.RetryWeeklyAsync(edition.Week, false)`
- `NationalSpire.AiService.RetryWeeklyAsync(int, bool, NationalSpire.CareerData?)`；输入表达式：`AiService.RetryWeeklyAsync(edition.Week, true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.RetryWeeklyAsync(edition.Week, true)`
- `NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；输入表达式：`CameoContent.VisibleSlides(published[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CameoContent.VisibleSlides(published[0]).FirstOrDefault`
- `NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；输入表达式：`CameoContent.VisibleSlides(w)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CameoContent.VisibleSlides(w).Count`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, false); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, false); }, true)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, true); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, true); }, true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(section)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(section)`
- `NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；输入表达式：`RenderWeeklySlide(data, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWeeklySlide(data, false);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(box, edition.NewsWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, false); }, true), "WeeklyNews_" + edition.Week)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(box, edition.NewsWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, false); }, true), "WeeklyNews_" + edition.Week);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(box, edition.ProfilesWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, true); }, true), "WeeklyProfiles_" + edition.Week)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(box, edition.ProfilesWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, true); }, true), "WeeklyProfiles_" + edition.Week);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("尖塔双周刊", 25, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("尖塔双周刊", 25, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第 {edition.Week} 周 · 选手介绍", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第 {edition.Week} 周 · 选手介绍", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第 {edition.Week} 周 · 周刊精选", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第 {edition.Week} 周 · 周刊精选", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(latest.NewsWork.State == "disabled" ? "开启 AI 后，这里会刊登双周精选。" : "本期精选正在整理，稍后就能阅读。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(latest.NewsWork.State == "disabled" ? "开启 AI 后，这里会刊登双周精选。" : "本期精选正在整理，稍后就能阅读。", 17, _muted)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_weeklyCeremonyShown.Add(cover.CeremonySeason)`；返回值紧邻使用处：`BinaryExpressionSyntax: cover != null && _weeklyCeremonyShown.Add(cover.CeremonySeason)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`published.Any(w => w.Week == _weeklyWeek)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !published.Any(w => w.Week == _weeklyWeek)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CameoContent.VisibleSlides(published[0]).FirstOrDefault(s => s.CeremonySeason > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CameoContent.VisibleSlides(published[0]).FirstOrDefault(s => s.CeremonySeason > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`data.WeeklyEditions.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0).OrderByDescending(w => w.Week)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0).OrderByDescending(w => w.Week).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0).OrderByDescending(w => w.Week).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0).OrderByDescending(w => w.Week).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Where(w => w.ProfilesWork.State == "failed" || w.NewsWork.State == "failed" || w == latest)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var edition in data.WeeklyEditions.Where(w => w.ProfilesWork.State == "failed" || w.NewsWork.State == "failed" || w == latest))          {              if (edition.ProfilesWork.State is "failed" or "queued" or "sending") box.AddChild(Text($"第 {edition.Week} 周 · 选手介绍", 14, _muted));              if (edition.ProfilesWork.State is "failed" or "queued" or "sending") RenderWorkStatus(box, edition.ProfilesWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, true); }, true), "WeeklyProfiles_" + edition.Week);              if (edition.NewsWork.State is "failed" or "queued" or "sending") box.AddChild(Text($"第 {edition.Week} 周 · 周刊精选", 14, _muted));              if (edition.NewsWork.State is "failed" or "queued" or "sending") RenderWorkStatus(box, edition.NewsWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, false); }, true), "WeeklyNews_" + edition.Week);          }`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`published.FindIndex(w => w.Week == _weeklyWeek)`；返回值紧邻使用处：`ArgumentSyntax: published.FindIndex(w => w.Week == _weeklyWeek)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.RetryWeeklyAsync(edition.Week, false)`
- `_` = `AiService.RetryWeeklyAsync(edition.Week, true)`
- `_latestWeeklyPublished` = `published[0].Week`
- `_weeklyClock` = `0`
- `_weeklyContent` = `new VBoxContainer { Name = "WeeklyCarousel", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_weeklyIndex` = `0`
- `_weeklySelector` = `select`
- `_weeklyWeek` = `published[0].Week`
- `_weeklyWeek` = `select.GetItemId((int)index)`
- `ClipContents` = `true`
- `CustomMinimumSize` = `new Vector2(210, 44)`
- `headingText.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Name` = `"WeeklyCarousel"`
- `Name` = `"WeeklyEditionSelector"`
- `section.Name` = `"WeeklySection"`
- `select.ItemSelected` += `index => { _weeklyWeek = select.GetItemId((int)index); _weeklyIndex = 0; _weeklyClock = 0; RenderWeeklySlide(data, false); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-184e7ff58940"></a>

## `NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool) — private void RenderWeeklySlide(CareerData data, bool animate)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Change(int)`](WeeklyScreen.cs.md#symbol-8e94ac344d8d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.TickWeekly(double)`](WeeklyScreen.cs.md#symbol-90f7d7772fea)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)

**调用：** [`Change(int)`](WeeklyScreen.cs.md#symbol-8e94ac344d8d)；[`NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-29d9526009c4)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.OpenWeekly(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](WeeklyScreen.cs.md#symbol-d2f4067bf23e)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Node.GetViewport()`；`Godot.Node.IsAncestorOf(Godot.Node)`；`Godot.Node.IsInsideTree()`；`Godot.ProgressBar.ProgressBar()`；`Godot.PropertyTweener.From(Godot.Variant)`；`Godot.StringName.ToString()`；`Godot.Tween.Kill()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetParallel(bool)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetFocusOwner()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Change(int)`；`NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._weeklyAuto`；`NationalSpire.CareerScreen._weeklyClock`；`NationalSpire.CareerScreen._weeklyContent`；`NationalSpire.CareerScreen._weeklyIndex`；`NationalSpire.CareerScreen._weeklyProgress`；`NationalSpire.CareerScreen._weeklyTween`；`NationalSpire.CareerScreen._weeklyWeek`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.OpenWeekly(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`；`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`；`NationalSpire.CareerScreen.WeeklyInterval`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.WeeklyEdition.Revision`；`NationalSpire.WeeklyEdition.SeenRevision`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklySlide.Advertisement`；`NationalSpire.WeeklySlide.CeremonySeason`；`NationalSpire.WeeklySlide.Importance`；`NationalSpire.WeeklySlide.Title`；`NationalSpire.WeeklySlide.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Change(int)`；输入表达式：`Change(_weeklyIndex - 1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Change(_weeklyIndex - 1)`
- `Change(int)`；输入表达式：`Change(_weeklyIndex + 1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Change(_weeklyIndex + 1)`
- `Change(int)`；输入表达式：`Change(index)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Change(index)`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(target) && target.IsInsideTree()) target.GrabFocus(); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(target) && target.IsInsideTree()) target.GrabFocus(); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(target) && target.IsInsideTree()) target.GrabFocus(); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(target) && target.IsInsideTree()) target.GrabFocus(); }).CallDeferred`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, .4f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Modulate = new Color(1, 1, 1, .4f)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 24);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeFontSizeOverride("font_size", 26)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeFontSizeOverride("font_size", 26);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_weeklyProgress.AddThemeStyleboxOverride("background", CareerVisuals.Box("142532", "142532", 0, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyProgress.AddThemeStyleboxOverride("background", CareerVisuals.Box("142532", "142532", 0, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_weeklyProgress.AddThemeStyleboxOverride("fill", CareerVisuals.Box("527e85", "527e85", 0, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyProgress.AddThemeStyleboxOverride("fill", CareerVisuals.Box("527e85", "527e85", 0, 0));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "WeeklyFeatureViewport", CustomMinimumSize = new Vector2(0, 180), SizeFlagsHorizontal = SizeFlags.ExpandFill, ClipContents = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "WeeklyFeatureViewport", CustomMinimumSize = new Vector2(0, 180), SizeFlagsHorizontal = SizeFlags.ExpandFill, ClipContents = true }`
- `Godot.Control.GrabFocus()`；输入表达式：`target.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: target.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`row.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_weeklyContent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_weeklyContent)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(target) && target.IsInsideTree()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_weeklyContent!.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(_weeklyContent) || _weeklyContent!.IsQueuedForDeletion()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "WeeklyControls" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "WeeklyControls" }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "WeeklyFeature", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "WeeklyFeature", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_weeklyContent.AddChild(_weeklyProgress)`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyContent.AddChild(_weeklyProgress);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_weeklyContent.AddChild(controls)`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyContent.AddChild(controls);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_weeklyContent.AddChild(featureViewport)`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyContent.AddChild(featureViewport);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`artButton.AddChild(WeeklyArt(issue, slide, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: artButton.AddChild(WeeklyArt(issue, slide, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(dot)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(dot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(next);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(pause)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(pause);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(previous);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(Text($"{_weeklyIndex + 1} / {slides.Count}", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(Text($"{_weeklyIndex + 1} / {slides.Count}", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text((slide.CeremonySeason > 0 ? "本期封面 · 荣誉特刊" : slide.Advertisement ? "俱乐部推广" : slide.Importance >= 3 ? "本期头条" : "本期精选")              + (issue.Revision > issue.SeenRevision ? "   ● 新双周刊" : ""), 14, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text((slide.CeremonySeason > 0 ? "本期封面 · 荣誉特刊" : slide.Advertisement ? "俱乐部推广" : slide.Importance >= 3 ? "本期头条" : "本期精选")              + (issue.Revision > issue.SeenRevision ? "   ● 新双周刊" : ""), 14, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text(slide.Topic, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text(slide.Topic, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`featureViewport.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: featureViewport.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(artButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(artButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(copy);`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetParallel`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Node.IsAncestorOf(Godot.Node)`；输入表达式：`_weeklyContent.IsAncestorOf(focus)`；返回值紧邻使用处：`BinaryExpressionSyntax: GetViewport().GuiGetFocusOwner() is { } focus && _weeklyContent.IsAncestorOf(focus)`
- `Godot.Node.IsInsideTree()`；输入表达式：`target.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(target) && target.IsInsideTree()`
- `Godot.ProgressBar.ProgressBar()`；输入表达式：`new ProgressBar { Name = "WeeklyProgress", CustomMinimumSize = new Vector2(0, 3), ShowPercentage = false, MaxValue = WeeklyInterval, Step = 0, Value = _weeklyClock, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _weeklyProgress = new ProgressBar { Name = "WeeklyProgress", CustomMinimumSize = new Vector2(0, 3), ShowPercentage = false, MaxValue = WeeklyInterval, Step = 0, Value = _weeklyClock, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.PropertyTweener.From(Godot.Variant)`；输入表达式：`_weeklyTween.TweenProperty(row, "position:x", 0f, .28).From(20f)`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyTween.TweenProperty(row, "position:x", 0f, .28).From(20f);`
- `Godot.StringName.ToString()`；输入表达式：`focus.Name.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: GetViewport().GuiGetFocusOwner() is { } focus && _weeklyContent.IsAncestorOf(focus) ? focus.Name.ToString() : null`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _weeklyTween?.Kill()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetParallel().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _weeklyTween = CreateTween().SetParallel().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`
- `Godot.Tween.SetParallel(bool)`；输入表达式：`CreateTween().SetParallel()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetParallel().SetTrans`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetParallel().SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetParallel().SetTrans(Tween.TransitionType.Cubic).SetEase`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`_weeklyTween.TweenProperty(row, "modulate:a", 1.0, .28)`；返回值紧邻使用处：`ExpressionStatementSyntax: _weeklyTween.TweenProperty(row, "modulate:a", 1.0, .28);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`_weeklyTween.TweenProperty(row, "position:x", 0f, .28)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _weeklyTween.TweenProperty(row, "position:x", 0f, .28).From`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 180)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 3)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(240, 170)`；返回值紧邻使用处：`AssignmentExpressionSyntax: artButton.CustomMinimumSize = new Vector2(240, 170)`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`IsPatternExpressionSyntax: GetViewport().GuiGetFocusOwner() is { } focus`
- `NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；输入表达式：`CameoContent.VisibleSlides(issue)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CameoContent.VisibleSlides(issue)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(_weeklyAuto ? "暂停轮播" : "自动轮播", () => { _weeklyAuto = !_weeklyAuto; _weeklyClock = 0; RenderWeeklySlide(data, false); }, 112)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(_weeklyAuto ? "暂停轮播" : "自动轮播", () => { _weeklyAuto = !_weeklyAuto; _weeklyClock = 0; RenderWeeklySlide(data, false); }, 112)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("‹", () => Change(_weeklyIndex - 1), 46)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("‹", () => Change(_weeklyIndex - 1), 46)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("›", () => Change(_weeklyIndex + 1), 46)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("›", () => Change(_weeklyIndex + 1), 46)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("", () => OpenWeekly(issue, slide), 240)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("", () => OpenWeekly(issue, slide), 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(i == _weeklyIndex ? "●" : "○", () => Change(index), 42)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(i == _weeklyIndex ? "●" : "○", () => Change(index), 42)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(slide.Title, () => OpenWeekly(issue, slide))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(slide.Title, () => OpenWeekly(issue, slide))`
- `NationalSpire.CareerScreen.OpenWeekly(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`；输入表达式：`OpenWeekly(issue, slide)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenWeekly(issue, slide)`
- `NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；输入表达式：`RenderWeeklySlide(data, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWeeklySlide(data, false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((slide.CeremonySeason > 0 ? "本期封面 · 荣誉特刊" : slide.Advertisement ? "俱乐部推广" : slide.Importance >= 3 ? "本期头条" : "本期精选")              + (issue.Revision > issue.SeenRevision ? "   ● 新双周刊" : ""), 14, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text((slide.CeremonySeason > 0 ? "本期封面 · 荣誉特刊" : slide.Advertisement ? "俱乐部推广" : slide.Importance >= 3 ? "本期头条" : "本期精选")              + (issue.Revision > issue.SeenRevision ? "   ● 新双周刊" : ""), 14, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{_weeklyIndex + 1} / {slides.Count}", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{_weeklyIndex + 1} / {slides.Count}", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(slide.Topic, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(slide.Topic, 16, _muted)`
- `NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`；输入表达式：`WeeklyArt(issue, slide, false)`；返回值紧邻使用处：`ArgumentSyntax: WeeklyArt(issue, slide, false)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142532", "142532", 0, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142532", "142532", 0, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("527e85", "527e85", 0, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("527e85", "527e85", 0, 0)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_weeklyContent)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_weeklyContent);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_weeklyContent, focusName)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerVisuals.FindContent(_weeklyContent, focusName) as Control`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.FirstOrDefault(w => w.Week == _weeklyWeek)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.FirstOrDefault(w => w.Week == _weeklyWeek)`

**赋值（含属性/字段和局部值）：**

- `_weeklyAuto` = `!_weeklyAuto`
- `_weeklyClock` = `0`
- `_weeklyIndex` = `(_weeklyIndex % slides.Count + slides.Count) % slides.Count`
- `_weeklyProgress` = `new ProgressBar { Name = "WeeklyProgress", CustomMinimumSize = new Vector2(0, 3), ShowPercentage = false, MaxValue = WeeklyInterval, Step = 0, Value = _weeklyClock, MouseFilter = MouseFilterEnum.Ignore }`
- `_weeklyTween` = `CreateTween().SetParallel().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`
- `artButton.CustomMinimumSize` = `new Vector2(240, 170)`
- `artButton.Name` = `"WeeklyArtLink"`
- `artButton.TooltipText` = `"阅读：" + slide.Title`
- `ClipContents` = `true`
- `CustomMinimumSize` = `new Vector2(0, 180)`
- `CustomMinimumSize` = `new Vector2(0, 3)`
- `dot.Name` = `"WeeklyDot_" + i`
- `dot.TooltipText` = `slides[i].Advertisement ? "俱乐部推广" : slides[i].Title`
- `MaxValue` = `WeeklyInterval`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"WeeklyControls"`
- `Name` = `"WeeklyFeature"`
- `Name` = `"WeeklyFeatureViewport"`
- `Name` = `"WeeklyProgress"`
- `next.Name` = `"WeeklyNext"`
- `pause.Name` = `"WeeklyAuto"`
- `previous.Name` = `"WeeklyPrevious"`
- `row.Modulate` = `new Color(1, 1, 1, .4f)`
- `ShowPercentage` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `0`
- `title.Alignment` = `HorizontalAlignment.Left`
- `title.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `title.Name` = `"WeeklyHeadline"`
- `title.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Value` = `_weeklyClock`

<a id="symbol-8e94ac344d8d"></a>

## `Change(int) — void Change(int index)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)

**调用：** [`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._weeklyClock`；`NationalSpire.CareerScreen._weeklyIndex`；`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；输入表达式：`RenderWeeklySlide(data, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWeeklySlide(data, true);`

**赋值（含属性/字段和局部值）：**

- `_weeklyClock` = `0`
- `_weeklyIndex` = `index`

<a id="symbol-d6f13958bba4"></a>

## `NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool) — private Control WeeklyArt(WeeklyEdition issue, WeeklySlide slide, bool large)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)

**调用：** [`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)；[`NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool)`](CeremonyScreen.cs.md#symbol-96e48591b6f3)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextureRect.TextureRect()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Description`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.WeeklySlide.CeremonySeason`；`NationalSpire.WeeklySlide.Character`；`NationalSpire.WeeklySlide.Importance`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10242b", slide.Importance >= 3 ? "d6b77a" : slide.Importance == 2 ? "70d4bc" : "627c86", 10, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10242b", slide.Importance >= 3 ? "d6b77a" : slide.Importance == 2 ? "70d4bc" : "627c86", 10, 4));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`panel.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(art.Texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: art.Texture != null && GodotObject.IsInstanceValid(art.Texture)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(new TextureRect { Texture = art.Texture, MouseFilter = MouseFilterEnum.Ignore, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,                  StretchMode = large ? TextureRect.StretchModeEnum.KeepAspectCentered : TextureRect.StretchModeEnum.KeepAspectCovered, TooltipText = art.Description })`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(new TextureRect { Texture = art.Texture, MouseFilter = MouseFilterEnum.Ignore, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,                  StretchMode = large ? TextureRect.StretchModeEnum.KeepAspectCentered : TextureRect.StretchModeEnum.KeepAspectCovered, TooltipText = art.Description });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(Text(slide.Character, 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(Text(slide.Character, 24, _gold));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "WeeklyIllustration", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "WeeklyIllustration", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = art.Texture, MouseFilter = MouseFilterEnum.Ignore, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,                  StretchMode = large ? TextureRect.StretchModeEnum.KeepAspectCentered : TextureRect.StretchModeEnum.KeepAspectCovered, TooltipText = art.Description }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = art.Texture, MouseFilter = MouseFilterEnum.Ignore, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,                  StretchMode = large ? TextureRect.StretchModeEnum.KeepAspectCentered : TextureRect.StretchModeEnum.KeepAspectCovered, TooltipText = art.Description }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 280)`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.CustomMinimumSize = new Vector2(0, 280)`
- `NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`；输入表达式：`AvatarAssets.LoadWeekly(_boundData, issue, slide)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarAssets.LoadWeekly(_boundData, issue, slide)`
- `NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool)`；输入表达式：`CeremonyWeeklyCover(_boundData, slide, large)`；返回值紧邻使用处：`ReturnStatementSyntax: return CeremonyWeeklyCover(_boundData, slide, large);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(slide.Character, 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(slide.Character, 24, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10242b", slide.Importance >= 3 ? "d6b77a" : slide.Importance == 2 ? "70d4bc" : "627c86", 10, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10242b", slide.Importance >= 3 ? "d6b77a" : slide.Importance == 2 ? "70d4bc" : "627c86", 10, 4)`

**赋值（含属性/字段和局部值）：**

- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"WeeklyIllustration"`
- `panel.CustomMinimumSize` = `new Vector2(0, 280)`
- `panel.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `large ? TextureRect.StretchModeEnum.KeepAspectCentered : TextureRect.StretchModeEnum.KeepAspectCovered`
- `Texture` = `art.Texture`
- `TooltipText` = `art.Description`

<a id="symbol-90f7d7772fea"></a>

## `NationalSpire.CareerScreen.TickWeekly(double) — private void TickWeekly(double delta)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)

**调用：** [`NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-29d9526009c4)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GetGlobalRect()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.OptionButton.GetPopup()`；`Godot.Rect2.Intersects(Godot.Rect2, bool)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._weeklyAuto`；`NationalSpire.CareerScreen._weeklyClock`；`NationalSpire.CareerScreen._weeklyContent`；`NationalSpire.CareerScreen._weeklyIndex`；`NationalSpire.CareerScreen._weeklyProgress`；`NationalSpire.CareerScreen._weeklySelector`；`NationalSpire.CareerScreen._weeklyWeek`；`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；`NationalSpire.CareerScreen.WeeklyInterval`；`NationalSpire.WeeklyEdition.Week`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`_weeklyContent!.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_weeklyContent!.IsVisibleInTree()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_scroll.GetGlobalRect()`；返回值紧邻使用处：`ArgumentSyntax: _scroll.GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_weeklyContent.GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _weeklyContent.GetGlobalRect().Intersects`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_weeklyContent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_weeklyContent)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_weeklyProgress)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_weeklyProgress)) _weeklyProgress!.Value = _weeklyClock;`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_weeklySelector)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_weeklySelector) && _weeklySelector!.GetPopup().Visible`
- `Godot.OptionButton.GetPopup()`；输入表达式：`_weeklySelector!.GetPopup()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _weeklySelector!.GetPopup().Visible`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`_weeklyContent.GetGlobalRect().Intersects(_scroll.GetGlobalRect())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_weeklyContent.GetGlobalRect().Intersects(_scroll.GetGlobalRect())`
- `NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`；输入表达式：`CameoContent.VisibleSlides(issue)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CameoContent.VisibleSlides(issue).Count`
- `NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`；输入表达式：`RenderWeeklySlide(_boundData, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWeeklySlide(_boundData, true);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_boundData.WeeklyEditions.FirstOrDefault(w => w.Week == _weeklyWeek)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _boundData.WeeklyEditions.FirstOrDefault(w => w.Week == _weeklyWeek)`

**赋值（含属性/字段和局部值）：**

- `_weeklyClock` += `delta`
- `_weeklyClock` = `0`
- `_weeklyProgress!.Value` = `_weeklyClock`

<a id="symbol-d2f4067bf23e"></a>

## `NationalSpire.CareerScreen.OpenWeekly(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide) — private void OpenWeekly(WeeklyEdition issue, WeeklySlide slide)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklySlide.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "社区"; _postId = $"weekly:{issue.Week}:{slide.Id}"; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Visit(() => { _tab = "社区"; _postId = $"weekly:{issue.Week}:{slide.Id}"; })`

**赋值（含属性/字段和局部值）：**

- `_postId` = `$"weekly:{issue.Week}:{slide.Id}"`
- `_tab` = `"社区"`

<a id="symbol-b3f0ffc5fb7d"></a>

## `NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData) — private bool RenderWeeklyDetail(CareerData data)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`](CameoContent.cs.md#symbol-37cea0979aaf)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Emphasize(Godot.Button)`](BroadcastVisuals.cs.md#symbol-ddd68d13b687)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.OpenCeremony()`](CeremonyScreen.cs.md#symbol-f5db35fa605b)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OS.ShellOpen(string)`；`Godot.Vector2.Vector2(float, float)`；`int.TryParse(string?, out int)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；`NationalSpire.CameoContent.Story.Video`；`NationalSpire.CareerData.Ceremonies`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._ceremonySeason`；`NationalSpire.CareerScreen._ceremonySection`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen.AddHeading(string, string)`；`NationalSpire.CareerScreen.Back()`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Emphasize(Godot.Button)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.OpenCeremony()`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CeremonyRecord.Season`；`NationalSpire.WeeklyEdition.EndDay`；`NationalSpire.WeeklyEdition.PeriodLabel`；`NationalSpire.WeeklyEdition.Revision`；`NationalSpire.WeeklyEdition.SeenRevision`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklyEdition.StartDay`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklySlide.Advertisement`；`NationalSpire.WeeklySlide.Body`；`NationalSpire.WeeklySlide.CeremonySeason`；`NationalSpire.WeeklySlide.Id`；`NationalSpire.WeeklySlide.People`；`NationalSpire.WeeklySlide.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`video.AddThemeColorOverride("font_color", _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: video.AddThemeColorOverride("font_color", _gold);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`video.AddThemeStyleboxOverride("normal", CareerVisuals.Box("18333d", "d6b77a", 10, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: video.AddThemeStyleboxOverride("normal", CareerVisuals.Box("18333d", "d6b77a", 10, 2));`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("返回周刊", Back, 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("返回周刊", Back, 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(ceremony)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(ceremony);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(people)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(people);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("这期周刊尚不可用。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("这期周刊尚不可用。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(video)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(video);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(WeeklyArt(issue, slide, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(WeeklyArt(issue, slide, true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Inner(card).AddChild(MentionText(data, slide.Body, 21, _ink, slide.People))`；返回值紧邻使用处：`ExpressionStatementSyntax: Inner(card).AddChild(MentionText(data, slide.Body, 21, _ink, slide.People));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`people.AddChild(Button(CareerEngine.DisplayName(data, id) + " ↗", () => OpenPerson(id), 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: people.AddChild(Button(CareerEngine.DisplayName(data, id) + " ↗", () => OpenPerson(id), 160));`
- `Godot.OS.ShellOpen(string)`；输入表达式：`OS.ShellOpen(story.Video)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OS.ShellOpen(story.Video)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(320, 76)`；返回值紧邻使用处：`AssignmentExpressionSyntax: video.CustomMinimumSize = new Vector2(320, 76)`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(parts[1], out int week)`；返回值紧邻使用处：`BinaryExpressionSyntax: parts.Length == 3 && int.TryParse(parts[1], out int week)`
- `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；输入表达式：`CameoContent.FindStory(slide)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CameoContent.FindStory(slide) is { } story`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, id) + " ↗"`
- `NationalSpire.CareerScreen.AddHeading(string, string)`；输入表达式：`AddHeading(slide.Title, $"尖塔双周刊 · {issue.PeriodLabel} · 第 {issue.StartDay}—{issue.EndDay} 天" + (slide.Advertisement ? " · 俱乐部推广" : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading(slide.Title, $"尖塔双周刊 · {issue.PeriodLabel} · 第 {issue.StartDay}—{issue.EndDay} 天" + (slide.Advertisement ? " · 俱乐部推广" : ""));`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("▶  珍贵历史影像  ↗", () => OS.ShellOpen(story.Video), 320)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("▶  珍贵历史影像  ↗", () => OS.ShellOpen(story.Video), 320)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看完整颁奖盛典   →", () =>              { _ceremonySeason = slide.CeremonySeason; _ceremonySection = "获奖名单"; OpenCeremony(); }, 300)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("查看完整颁奖盛典   →", () =>              { _ceremonySeason = slide.CeremonySeason; _ceremonySection = "获奖名单"; OpenCeremony(); }, 300)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("返回周刊", Back, 160)`；返回值紧邻使用处：`ArgumentSyntax: Button("返回周刊", Back, 160)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(CareerEngine.DisplayName(data, id) + " ↗", () => OpenPerson(id), 160)`；返回值紧邻使用处：`ArgumentSyntax: Button(CareerEngine.DisplayName(data, id) + " ↗", () => OpenPerson(id), 160)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Emphasize(Godot.Button)`；输入表达式：`Emphasize(ceremony)`；返回值紧邻使用处：`ExpressionStatementSyntax: Emphasize(ceremony);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Inner(card).AddChild`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, slide.Body, 21, _ink, slide.People)`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, slide.Body, 21, _ink, slide.People)`
- `NationalSpire.CareerScreen.OpenCeremony()`；输入表达式：`OpenCeremony()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCeremony();`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPerson(id)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("这期周刊尚不可用。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("这期周刊尚不可用。", 18, _muted)`
- `NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`；输入表达式：`WeeklyArt(issue, slide, true)`；返回值紧邻使用处：`ArgumentSyntax: WeeklyArt(issue, slide, true)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("18333d", "d6b77a", 10, 2)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("18333d", "d6b77a", 10, 2)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`_postId.Split(':')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _postId.Split(':')`
- `string.StartsWith(string)`；输入表达式：`.StartsWith("weekly:")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _postId?.StartsWith("weekly:")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Ceremonies.Any(c => c.Season == slide.CeremonySeason)`；返回值紧邻使用处：`BinaryExpressionSyntax: slide.CeremonySeason > 0 && data.Ceremonies.Any(c => c.Season == slide.CeremonySeason)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`slide.People.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: slide.People.Distinct().Take`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Slides.FirstOrDefault(s => s.Id == parts[2])`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: issue?.Slides.FirstOrDefault(s => s.Id == parts[2])`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.FirstOrDefault(w => w.Week == week)`；返回值紧邻使用处：`ConditionalExpressionSyntax: parts.Length == 3 && int.TryParse(parts[1], out int week) ? data.WeeklyEditions.FirstOrDefault(w => w.Week == week) : null`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`slide.People.Distinct().Take(8)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in slide.People.Distinct().Take(8)) people.AddChild(Button(CareerEngine.DisplayName(data, id) + " ↗", () => OpenPerson(id), 160));`

**赋值（含属性/字段和局部值）：**

- `_ceremonySeason` = `slide.CeremonySeason`
- `_ceremonySection` = `"获奖名单"`
- `issue.SeenRevision` = `issue.Revision`
- `video.CustomMinimumSize` = `new Vector2(320, 76)`
- `video.Name` = `"CameoHistoricalVideo"`
- `video.TooltipText` = `"在浏览器中观看视频"`
