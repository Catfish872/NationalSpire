# MatchStartWatch.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8A06CC41785A30D06E37F26615CDBED059397F92C6C923C70540714E0476435C`。来源：[源码](../../MatchStartWatch.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MatchStartWatch`、`NationalSpire.MatchStartLoadPatch`。

字段、事件及初始值（源码原样）：

```csharp
private const double NoticeSeconds = 30;
private static MatchStartWatch? _active;
private readonly Stopwatch _clock = Stopwatch.StartNew();
private string _match = "", _stage = "准备开局";
private readonly Dictionary<Task, string> _loads = [];
private Func<bool> _hasSave = () => false;
private Action _quit = () => { };
private Control? _panel;
private Label? _detail;
private double _nextNotice = NoticeSeconds, _refreshAt;
private bool _finished;
```

<a id="symbol-3c0b6b3e7a3b"></a>

## `NationalSpire.MatchStartWatch.IsActive — public static bool IsActive`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch._active`；`NationalSpire.MatchStartWatch._finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(watch)`；返回值紧邻使用处：`BinaryExpressionSyntax: _active is { _finished: false } watch && IsInstanceValid(watch)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a39a7334ee0a"></a>

## `NationalSpire.MatchStartWatch.Begin(Godot.Node, string, System.Func<bool>, System.Action) — public static MatchStartWatch Begin(Node parent, string match, Func<bool> hasSave, Action quit)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.MatchStartWatch.MatchStartWatch()`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch.IsActive`；`NationalSpire.MatchStartWatch._active`；`NationalSpire.MatchStartWatch._hasSave`；`NationalSpire.MatchStartWatch._match`；`NationalSpire.MatchStartWatch._quit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(watch)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(watch);`
- `NationalSpire.MatchStartWatch.MatchStartWatch()`；输入表达式：`new MatchStartWatch { Name = "NationalSpireMatchLoading", Layer = 1024, ProcessMode = ProcessModeEnum.Always, _match = match, _hasSave = hasSave, _quit = quit }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MatchStartWatch { Name = "NationalSpireMatchLoading", Layer = 1024, ProcessMode = ProcessModeEnum.Always, _match = match, _hasSave = hasSave, _quit = quit }`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("已有一场对局正在加载，请等待加载完成。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("已有一场对局正在加载，请等待加载完成。");`

**赋值（含属性/字段和局部值）：**

- `Layer` = `1024`
- `Name` = `"NationalSpireMatchLoading"`
- `ProcessMode` = `ProcessModeEnum.Always`
- `_active` = `watch`
- `_hasSave` = `hasSave`
- `_match` = `match`
- `_quit` = `quit`

<a id="symbol-ad0a1e036443"></a>

## `NationalSpire.MatchStartWatch.Stage(string) — public void Stage(string stage)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.MatchStartWatch._clock`；`NationalSpire.MatchStartWatch._finished`；`NationalSpire.MatchStartWatch._match`；`NationalSpire.MatchStartWatch._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.loading.stage", new { match = _match, stage, elapsedMs = _clock.ElapsedMilliseconds })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.loading.stage", new { match = _match, stage, elapsedMs = _clock.ElapsedMilliseconds });`

**赋值（含属性/字段和局部值）：**

- `_stage` = `stage`

<a id="symbol-e2f08ce47fcb"></a>

## `NationalSpire.MatchStartWatch.Observe(System.Threading.Tasks.Task, string) — internal static Task Observe(Task original, string stage)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartLoadPatch.Postfix(System.Reflection.MethodBase, ref System.Threading.Tasks.Task)`](MatchStartWatch.cs.md#symbol-1823c1ed83e0)

**调用：** [`NationalSpire.MatchStartWatch.ObserveLoad(System.Threading.Tasks.Task, string)`](MatchStartWatch.cs.md#symbol-c5e7fd26211f)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch.IsActive`；`NationalSpire.MatchStartWatch.ObserveLoad(System.Threading.Tasks.Task, string)`；`NationalSpire.MatchStartWatch._active`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchStartWatch.ObserveLoad(System.Threading.Tasks.Task, string)`；输入表达式：`_active!.ObserveLoad(original, stage)`；返回值紧邻使用处：`ReturnStatementSyntax: return _active!.ObserveLoad(original, stage);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c5e7fd26211f"></a>

## `NationalSpire.MatchStartWatch.ObserveLoad(System.Threading.Tasks.Task, string) — private async Task ObserveLoad(Task original, string stage)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch.Observe(System.Threading.Tasks.Task, string)`](MatchStartWatch.cs.md#symbol-e2f08ce47fcb)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.MatchStartWatch._clock`；`NationalSpire.MatchStartWatch._loads`；`NationalSpire.MatchStartWatch._match`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.loading.assets.failure:" + stage, error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.loading.assets.failure:" + stage, error);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.loading.assets", new { match = _match, stage, elapsedMs = started })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.loading.assets", new { match = _match, stage, elapsedMs = started });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.loading.assets.finished", new { match = _match, stage, status = original.Status.ToString(), milliseconds = _clock.ElapsedMilliseconds - started })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.loading.assets.finished", new { match = _match, stage, status = original.Status.ToString(), milliseconds = _clock.ElapsedMilliseconds - started });`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_loads.Remove(original)`；返回值紧邻使用处：`ExpressionStatementSyntax: _loads.Remove(original);`
- `System.Enum.ToString()`；输入表达式：`original.Status.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: status = original.Status.ToString()`

**赋值（含属性/字段和局部值）：**

- `_loads[original]` = `stage`

<a id="symbol-6da2a524591e"></a>

## `NationalSpire.MatchStartWatch._Process(double) — public override void _Process(double delta)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MatchStartWatch.RefreshDetail()`](MatchStartWatch.cs.md#symbol-9a000b3e68aa)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch.RefreshDetail()`；`NationalSpire.MatchStartWatch.ShowNotice()`；`NationalSpire.MatchStartWatch._clock`；`NationalSpire.MatchStartWatch._detail`；`NationalSpire.MatchStartWatch._finished`；`NationalSpire.MatchStartWatch._nextNotice`；`NationalSpire.MatchStartWatch._panel`；`NationalSpire.MatchStartWatch._refreshAt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchStartWatch.RefreshDetail()`；输入表达式：`RefreshDetail()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDetail();`
- `NationalSpire.MatchStartWatch.ShowNotice()`；输入表达式：`ShowNotice()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowNotice();`

**赋值（含属性/字段和局部值）：**

- `_refreshAt` = `seconds + 1`

<a id="symbol-932ad28c7853"></a>

## `NationalSpire.MatchStartWatch.CurrentStage — private string CurrentStage`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch._loads`；`NationalSpire.MatchStartWatch._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`_loads.Values.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: _loads.Values.LastOrDefault() ?? _stage`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d420f386eebf"></a>

## `NationalSpire.MatchStartWatch.HasSavedRun() — private bool HasSavedRun()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch.RefreshDetail()`](MatchStartWatch.cs.md#symbol-9a000b3e68aa)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Func<TResult>.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.MatchStartWatch._hasSave`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.loading.save_status", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.loading.save_status", error);`
- `System.Func<TResult>.Invoke()`；输入表达式：`_hasSave()`；返回值紧邻使用处：`ReturnStatementSyntax: return _hasSave();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c904f0fb2bfd"></a>

## `NationalSpire.MatchStartWatch.ShowNotice() — private void ShowNotice()`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch._Process(double)`](MatchStartWatch.cs.md#symbol-6da2a524591e)

**调用：** `Godot.Button.Button()`；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(float, float, float, float)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.GameCompatibility.AssetLoadingStatus()`](GameCompatibility.cs.md#symbol-a00822d68705)；[`NationalSpire.MatchStartWatch.ClearNotice()`](MatchStartWatch.cs.md#symbol-af68067deb85)；[`NationalSpire.MatchStartWatch.HasSavedRun()`](MatchStartWatch.cs.md#symbol-d420f386eebf)；[`NationalSpire.MatchStartWatch.RefreshDetail()`](MatchStartWatch.cs.md#symbol-9a000b3e68aa)；`System.Action.Invoke()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Enum.ToString()`；`System.Exception.GetBaseException()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.GameCompatibility.AssetLoadingStatus()`；`NationalSpire.MatchStartWatch.ClearNotice()`；`NationalSpire.MatchStartWatch.CurrentStage`；`NationalSpire.MatchStartWatch.HasSavedRun()`；`NationalSpire.MatchStartWatch.NoticeSeconds`；`NationalSpire.MatchStartWatch.RefreshDetail()`；`NationalSpire.MatchStartWatch._clock`；`NationalSpire.MatchStartWatch._detail`；`NationalSpire.MatchStartWatch._loads`；`NationalSpire.MatchStartWatch._match`；`NationalSpire.MatchStartWatch._nextNotice`；`NationalSpire.MatchStartWatch._panel`；`NationalSpire.MatchStartWatch._quit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = "继续等待", CustomMinimumSize = new Vector2(150, 48), Name = "KeepWaiting" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = "继续等待", CustomMinimumSize = new Vector2(150, 48), Name = "KeepWaiting" }`
- `Godot.Button.Button()`；输入表达式：`new Button { Text = "退出游戏", CustomMinimumSize = new Vector2(150, 48), Name = "QuitGame" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = "退出游戏", CustomMinimumSize = new Vector2(150, 48), Name = "QuitGame" }`
- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CenterContainer()`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0, 0, 0, .8f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color(0, 0, 0, .8f)`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color = new Color(0, 0, 0, .8f), MouseFilter = Control.MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Color = new Color(0, 0, 0, .8f), MouseFilter = Control.MouseFilterEnum.Ignore }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`title.AddThemeColorOverride("font_color", CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeColorOverride("font_color", CareerVisuals.Gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, 24);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeFontSizeOverride("font_size", 25)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeFontSizeOverride("font_size", 25);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`box.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182b3b", "789aa4", 12, 24))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182b3b", "789aa4", 12, 24));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "LoadingNotice", Theme = CareerVisuals.CreateTheme(), MouseFilter = Control.MouseFilterEnum.Stop }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _panel = new Control { Name = "LoadingNotice", Theme = CareerVisuals.CreateTheme(), MouseFilter = Control.MouseFilterEnum.Stop }`
- `Godot.Control.GrabFocus()`；输入表达式：`wait.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: wait.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_panel.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _panel.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`
- `Godot.Label.Label()`；输入表达式：`new Label { CustomMinimumSize = new Vector2(470, 0) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _detail = new Label { CustomMinimumSize = new Vector2(470, 0) }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "对局加载时间较长" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "对局加载时间较长" }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_panel.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: _panel.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_panel.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _panel.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(column);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(quit)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(quit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(wait)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(wait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(_detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(_detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(buttons)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(buttons);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(center);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { CustomMinimumSize = new Vector2(520, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { CustomMinimumSize = new Vector2(520, 0) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(150, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(150, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(470, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(470, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(520, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(520, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("182b3b", "789aa4", 12, 24)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("182b3b", "789aa4", 12, 24)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.loading.quit.failure", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.loading.quit.failure", error);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.loading.quit", new { match = _match, stage = CurrentStage, hasRunSave = HasSavedRun() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.loading.quit", new { match = _match, stage = CurrentStage, hasRunSave = HasSavedRun() });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.loading.slow", new { match = _match, stage = CurrentStage, elapsedMs = _clock.ElapsedMilliseconds, hasRunSave = saved, loads = _loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() }).ToArray(), nativeAssets = GameCompatibility.AssetLoadingStatus(), build = typeof(GameBridge).Assembly.ManifestModule.ModuleVersionId })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.loading.slow", new { match = _match, stage = CurrentStage, elapsedMs = _clock.ElapsedMilliseconds, hasRunSave = saved, loads = _loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() }).ToArray(), nativeAssets = GameCompatibility.AssetLoadingStatus(), build = typeof(GameBridge).Assembly.ManifestModule.ModuleVersionId });`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(error.GetBaseException().Message)`；返回值紧邻使用处：`BinaryExpressionSyntax: "退出游戏时出现异常：\n" + Diagnostics.Redact(error.GetBaseException().Message)`
- `NationalSpire.GameCompatibility.AssetLoadingStatus()`；输入表达式：`GameCompatibility.AssetLoadingStatus()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: nativeAssets = GameCompatibility.AssetLoadingStatus()`
- `NationalSpire.MatchStartWatch.ClearNotice()`；输入表达式：`ClearNotice()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearNotice();`
- `NationalSpire.MatchStartWatch.HasSavedRun()`；输入表达式：`HasSavedRun()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = HasSavedRun()`
- `NationalSpire.MatchStartWatch.HasSavedRun()`；输入表达式：`HasSavedRun()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: hasRunSave = HasSavedRun()`
- `NationalSpire.MatchStartWatch.RefreshDetail()`；输入表达式：`RefreshDetail()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDetail();`
- `System.Action.Invoke()`；输入表达式：`_quit()`；返回值紧邻使用处：`ExpressionStatementSyntax: _quit();`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: loads = _loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() }).ToArray()`
- `System.Enum.ToString()`；输入表达式：`p.Key.Status.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: status = p.Key.Status.ToString()`
- `System.Exception.GetBaseException()`；输入表达式：`error.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: error.GetBaseException().Message`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.End`
- `Color` = `new Color(0, 0, 0, .8f)`
- `CustomMinimumSize` = `new Vector2(150, 48)`
- `CustomMinimumSize` = `new Vector2(470, 0)`
- `CustomMinimumSize` = `new Vector2(520, 0)`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `MouseFilter` = `Control.MouseFilterEnum.Stop`
- `Name` = `"KeepWaiting"`
- `Name` = `"LoadingNotice"`
- `Name` = `"QuitGame"`
- `Text` = `"对局加载时间较长"`
- `Text` = `"继续等待"`
- `Text` = `"退出游戏"`
- `Theme` = `CareerVisuals.CreateTheme()`
- `_detail!.Text` = `"退出游戏时出现异常：\n" + Diagnostics.Redact(error.GetBaseException().Message)`
- `_detail` = `new Label { CustomMinimumSize = new Vector2(470, 0) }`
- `_nextNotice` = `_clock.Elapsed.TotalSeconds + NoticeSeconds`
- `_panel` = `new Control { Name = "LoadingNotice", Theme = CareerVisuals.CreateTheme(), MouseFilter = Control.MouseFilterEnum.Stop }`
- `quit.Pressed` += `() => { try { Diagnostics.Record("match.loading.quit", new { match = _match, stage = CurrentStage, hasRunSave = HasSavedRun() }); _quit(); } catch (Exception error) { Diagnostics.Error("match.loading.quit.failure", error); _detail!.Text = "退出游戏时出现异常：\n" + Diagnostics.Redact(error.GetBaseException().Message); } }`
- `wait.Pressed` += `() => { ClearNotice(); _nextNotice = _clock.Elapsed.TotalSeconds + NoticeSeconds; }`

<a id="symbol-9a000b3e68aa"></a>

## `NationalSpire.MatchStartWatch.RefreshDetail() — private void RefreshDetail()`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)；[`NationalSpire.MatchStartWatch._Process(double)`](MatchStartWatch.cs.md#symbol-6da2a524591e)

**调用：** [`NationalSpire.MatchStartWatch.HasSavedRun()`](MatchStartWatch.cs.md#symbol-d420f386eebf)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch.CurrentStage`；`NationalSpire.MatchStartWatch.HasSavedRun()`；`NationalSpire.MatchStartWatch._clock`；`NationalSpire.MatchStartWatch._detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchStartWatch.HasSavedRun()`；输入表达式：`HasSavedRun()`；返回值紧邻使用处：`ConditionalExpressionSyntax: HasSavedRun() ? "对局已保存；重启后可从主菜单继续游戏。" : "生涯资料已保留；原版对局尚未完成保存。"`

**赋值（含属性/字段和局部值）：**

- `_detail.Text` = `$"正在等待：{CurrentStage}\n开局已用时 {(int)_clock.Elapsed.TotalSeconds} 秒。\n\n" + "可以继续等待，或退出游戏后重新进入。\n" + (HasSavedRun() ? "对局已保存；重启后可从主菜单继续游戏。" : "生涯资料已保留；原版对局尚未完成保存。") + "\n加载阶段已记录到诊断日志。"`

<a id="symbol-af68067deb85"></a>

## `NationalSpire.MatchStartWatch.ClearNotice() — private void ClearNotice()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch.Finish()`](MatchStartWatch.cs.md#symbol-2b2800aa6a80)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch._detail`；`NationalSpire.MatchStartWatch._panel`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _panel.Hide();`
- `Godot.Node.QueueFree()`；输入表达式：`_panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _panel.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_detail` = `null`
- `_panel` = `null`

<a id="symbol-2b2800aa6a80"></a>

## `NationalSpire.MatchStartWatch.Finish() — public void Finish()`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** `Godot.Node.QueueFree()`；[`NationalSpire.MatchStartWatch.ClearNotice()`](MatchStartWatch.cs.md#symbol-af68067deb85)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch.ClearNotice()`；`NationalSpire.MatchStartWatch._active`；`NationalSpire.MatchStartWatch._finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`
- `NationalSpire.MatchStartWatch.ClearNotice()`；输入表达式：`ClearNotice()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearNotice();`

**赋值（含属性/字段和局部值）：**

- `_active` = `null`
- `_finished` = `true`

<a id="symbol-20e5aeb111c4"></a>

## `NationalSpire.MatchStartWatch._ExitTree() — public override void _ExitTree()`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch._active`；`NationalSpire.MatchStartWatch._finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_active` = `null`
- `_finished` = `true`

<a id="symbol-315e6a1a5440"></a>

## `NationalSpire.MatchStartLoadPatch.TargetMethods() — public static IEnumerable<MethodBase> TargetMethods()`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PreloadManager), name)`；返回值紧邻使用处：`IsPatternExpressionSyntax: AccessTools.Method(typeof(PreloadManager), name) is { ReturnType: var type } method`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1823c1ed83e0"></a>

## `NationalSpire.MatchStartLoadPatch.Postfix(System.Reflection.MethodBase, ref System.Threading.Tasks.Task) — public static void Postfix(MethodBase __originalMethod, ref Task __result)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MatchStartWatch.Observe(System.Threading.Tasks.Task, string)`](MatchStartWatch.cs.md#symbol-e2f08ce47fcb)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchStartWatch.Observe(System.Threading.Tasks.Task, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchStartWatch.Observe(System.Threading.Tasks.Task, string)`；输入表达式：`MatchStartWatch.Observe(__result, stage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result = MatchStartWatch.Observe(__result, stage)`

**赋值（含属性/字段和局部值）：**

- `__result` = `MatchStartWatch.Observe(__result, stage)`
