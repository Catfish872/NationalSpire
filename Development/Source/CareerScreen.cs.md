# CareerScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E736BB0AB9C174E57EBB38345968CAE425BB4EAED51775ED5B4462C18ECDC7BB`。来源：[源码](../../CareerScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.DiscussionRevision`、`NationalSpire.SpireBackdrop`、`NationalSpire.ResultChart`。

字段、事件及初始值（源码原样）：

```csharp
private static CareerScreen? _open;
protected readonly Color _gold = CareerVisuals.Gold, _muted = CareerVisuals.Muted, _ink = CareerVisuals.Ink;
private VBoxContainer _content = null!;
private Label _status = null!;
private Label _notice = null!;
private double _noticeRemaining;
private Label _pageTitle = null!;
private Button _seasonDate = null!;
private Label? _aiStatus;
private bool _aiSettingsDirty;
private string _profileFilter = "国内职业";
private string _profileOrigin = "全部来源";
private int _profileLimit = 36;
private string _profileQuery = "";
private string _communityFilter = "全部";
private int _postLimit = 30;
private ScrollContainer _scroll = null!;
protected Control _stage = null!;
private readonly Dictionary<string, Button> _navButtons = new();
private readonly List<(CanvasItem Node, bool Visible)> _hidden = [];
private string _tab = "首页";
private int _noticedCeremonySeason;
private string? _personId, _postId;
private int _renderVersion;
private int _selectedDay;
private double _refreshClock;
private DiscussionRevision _postSignature;
private readonly HashSet<string> _signaturePostIds = new(StringComparer.Ordinal);
private CareerData _boundData = null!;
private bool _starting;
private bool _confirmReset;
private string? _latestEvent;
private long _frameTime;
```

<a id="symbol-d996e84455c5"></a>

## `NationalSpire.CareerScreen.Current — public static CareerScreen? Current`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._open`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_open)`；返回值紧邻使用处：`BinaryExpressionSyntax: _open != null && GodotObject.IsInstanceValid(_open)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_open.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_open.IsQueuedForDeletion()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57163732a857"></a>

## `NationalSpire.CareerScreen.DefaultFocusedControl — public Control? DefaultFocusedControl`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backButton`；`NationalSpire.CareerScreen._navButtons`；`NationalSpire.CareerScreen._tab`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_navButtons.GetValueOrDefault(_tab)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _backButton is { Disabled: false } ? _backButton : _navButtons.GetValueOrDefault(_tab)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9df94d88557a"></a>

## `NationalSpire.CareerScreen.RestoreScrollAsync(int, int) — private async Task RestoreScrollAsync(int position, int version)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-5700a0d050b5)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`](CommunityScreen.cs.md#symbol-d9fcfe778254)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.RefreshClub()`](OwnedClubScreen.cs.md#symbol-29d092fa090a)；[`NationalSpire.CareerScreen.SwitchTab(string)`](CareerNavigation.cs.md#symbol-64b01d2d7cc1)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)；[`ShowSavedCard()`](CharacterCardScreen.cs.md#symbol-b8738fabd73d)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`；`Godot.Node.IsInsideTree()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(this) || !IsInsideTree() || IsQueuedForDeletion()`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(tree, SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(tree, SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`

**赋值（含属性/字段和局部值）：**

- `_scroll.ScrollVertical` = `position`

<a id="symbol-a9891646fd75"></a>

## `NationalSpire.CareerScreen._Input(Godot.InputEvent) — public override void _Input(InputEvent e)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)；[`NationalSpire.CareerScreen.CloseChatContextMenu()`](ChatContextMenuScreen.cs.md#symbol-02269de4e133)；[`NationalSpire.CareerScreen.CloseContactMenu()`](ChatContactScreen.cs.md#symbol-878c75543fa8)；[`NationalSpire.CareerScreen.ClosePrivateMessages()`](PrivateMessageScreen.cs.md#symbol-eb21fd76632c)；[`NationalSpire.CareerScreen.DateSceneExitChoices()`](DateSceneScreen.cs.md#symbol-52133982acce)；[`NationalSpire.DateMemoryPlayback.GoBack()`](DateSceneMemoryPlayback.cs.md#symbol-c036240ab245)；`Godot.Node.GetViewport()`；`Godot.Viewport.GuiGetFocusOwner()`；`Godot.Viewport.SetInputAsHandled()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._avatarOverlay`；`NationalSpire.CareerScreen._characterCardOverlay`；`NationalSpire.CareerScreen._chatContextMenu`；`NationalSpire.CareerScreen._closeAvatar`；`NationalSpire.CareerScreen._closeCharacterCard`；`NationalSpire.CareerScreen._closePromptTest`；`NationalSpire.CareerScreen._contactMenu`；`NationalSpire.CareerScreen._dateMemoryPlayback`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._promptOverlay`；`NationalSpire.CareerScreen._returnDialog`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Back()`；`NationalSpire.CareerScreen.ChatModelPickerOpen`；`NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.CloseChatContextMenu()`；`NationalSpire.CareerScreen.CloseContactMenu()`；`NationalSpire.CareerScreen.ClosePrivateMessages()`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.DateSceneExitChoices()`；`NationalSpire.DateMemoryPlayback.GoBack()`；`NationalSpire.EventStoryView.Close`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`IsPatternExpressionSyntax: GetViewport().GuiGetFocusOwner() is LineEdit { Name: var inputName }`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `NationalSpire.CareerScreen.Back()`；输入表达式：`Back()`；返回值紧邻使用处：`ExpressionStatementSyntax: Back();`
- `NationalSpire.CareerScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerScreen.CloseChatContextMenu()`；输入表达式：`CloseChatContextMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseChatContextMenu();`
- `NationalSpire.CareerScreen.CloseContactMenu()`；输入表达式：`CloseContactMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseContactMenu();`
- `NationalSpire.CareerScreen.ClosePrivateMessages()`；输入表达式：`ClosePrivateMessages()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessages();`
- `NationalSpire.CareerScreen.DateSceneExitChoices()`；输入表达式：`DateSceneExitChoices()`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneExitChoices();`
- `NationalSpire.DateMemoryPlayback.GoBack()`；输入表达式：`_dateMemoryPlayback.GoBack()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMemoryPlayback.GoBack();`
- `System.Action.Invoke()`；输入表达式：`_closePromptTest()`；返回值紧邻使用处：`ExpressionStatementSyntax: _closePromptTest();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _closeAvatar?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _closeCharacterCard?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _eventView.Close?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _returnDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-de0dbc5f9504"></a>

## `NationalSpire.CareerScreen._Process(double) — public override void _Process(double delta)`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)；[`NationalSpire.CareerScreen.OpenConfirmedTiebreak(NationalSpire.CareerData, NationalSpire.CareerResult?)`](FailureScreen.cs.md#symbol-31204c23bc58)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ab0215572f9e)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)；[`NationalSpire.CareerScreen.TickWeekly(double)`](WeeklyScreen.cs.md#symbol-90f7d7772fea)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.PlayerFacingText.AiStatus(string)`](PlayerFacingText.cs.md#symbol-6179a4a56aad)；[`NationalSpire.UiPerformance.Frame(ref long, string)`](UiPerformance.cs.md#symbol-aef0950310da)；`Godot.CanvasItem.Hide()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.GetViewport()`；`Godot.Viewport.GuiGetFocusOwner()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.RequestsToday`；`NationalSpire.AiService.Status`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._aiSettingsDirty`；`NationalSpire.CareerScreen._aiStatus`；`NationalSpire.CareerScreen._avatarOverlay`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._characterCardOverlay`；`NationalSpire.CareerScreen._closePromptTest`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._frameTime`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._notice`；`NationalSpire.CareerScreen._noticeRemaining`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._postSignature`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._promptOverlay`；`NationalSpire.CareerScreen._refreshClock`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.ComposePostId`；`NationalSpire.CareerScreen.OpenConfirmedTiebreak(NationalSpire.CareerData, NationalSpire.CareerResult?)`；`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.TickPrivate(double)`；`NationalSpire.CareerScreen.TickWeekly(double)`；`NationalSpire.CareerScreen.UpdateCommunityBadge()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.FailureDecision.Result`；`NationalSpire.ICareerSession.Alive`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.PlayerFacingText.AiStatus(string)`；`NationalSpire.UiPerformance.Frame(ref long, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_notice.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _notice.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_aiStatus)`；返回值紧邻使用处：`BinaryExpressionSyntax: _tab == "模组设置" && _aiStatus != null && GodotObject.IsInstanceValid(_aiStatus)`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`IsPatternExpressionSyntax: GetViewport().GuiGetFocusOwner() is LineEdit or TextEdit or SpinBox`
- `NationalSpire.CareerScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerScreen.OpenConfirmedTiebreak(NationalSpire.CareerData, NationalSpire.CareerResult?)`；输入表达式：`OpenConfirmedTiebreak(_boundData, previousDecision)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenConfirmedTiebreak(_boundData, previousDecision);`
- `NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`RefreshDiscussion(_boundData, thread)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDiscussion(_boundData, thread);`
- `NationalSpire.CareerScreen.RefreshSettlementDiscussion(NationalSpire.CareerData)`；输入表达式：`RefreshSettlementDiscussion(_boundData)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshSettlementDiscussion(_boundData);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(position, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(position, _renderVersion)`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(y, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(y, _renderVersion)`
- `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；输入表达式：`Signature(_boundData)`；返回值紧邻使用处：`BinaryExpressionSyntax: Signature(_boundData) != _postSignature`
- `NationalSpire.CareerScreen.TickPrivate(double)`；输入表达式：`TickPrivate(delta)`；返回值紧邻使用处：`ExpressionStatementSyntax: TickPrivate(delta);`
- `NationalSpire.CareerScreen.TickWeekly(double)`；输入表达式：`TickWeekly(delta)`；返回值紧邻使用处：`ExpressionStatementSyntax: TickWeekly(delta);`
- `NationalSpire.CareerScreen.UpdateCommunityBadge()`；输入表达式：`UpdateCommunityBadge()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateCommunityBadge();`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(_boundData)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(_boundData)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(_boundData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(_boundData).FirstOrDefault`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer.Refresh()`；返回值紧邻使用处：`BinaryExpressionSyntax: !editing && _multiplayer.Refresh()`
- `NationalSpire.PlayerFacingText.AiStatus(string)`；输入表达式：`PlayerFacingText.AiStatus(AiService.Status)`；返回值紧邻使用处：`BinaryExpressionSyntax: "当前状态：" + PlayerFacingText.AiStatus(AiService.Status)`
- `NationalSpire.UiPerformance.Frame(ref long, string)`；输入表达式：`UiPerformance.Frame(ref _frameTime, _privateOverlay == null ? _tab : "通讯")`；返回值紧邻使用处：`ExpressionStatementSyntax: UiPerformance.Frame(ref _frameTime, _privateOverlay == null ? _tab : "通讯");`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(_boundData).FirstOrDefault(p => p.Id == _postId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CommunityThreads.All(_boundData).FirstOrDefault(p => p.Id == _postId) is { } thread`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`_boundData.Results.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _boundData.Results.LastOrDefault()?.MatchId`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`_boundData.Results.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _boundData.Results.LastOrDefault()`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(position, _renderVersion)`
- `_` = `RestoreScrollAsync(y, _renderVersion)`
- `_aiStatus.Text` = `"当前状态：" + PlayerFacingText.AiStatus(AiService.Status) + $"  ·  今日请求次数 {_boundData.Ai.RequestsToday}"`
- `_boundData` = `ViewData`
- `_noticeRemaining` -= `delta`
- `_refreshClock` += `delta`
- `_refreshClock` = `0`
- `_reviewId` = `result!.MatchId`
- `_tab` = `"结算"`

<a id="symbol-b760e48de501"></a>

## `NationalSpire.CareerScreen.Open(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, string?) — public static void Open(NMainMenu menu, string? initialTab = null)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** [`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`](Coop/CoopScreen.cs.md#symbol-eee7991d404e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`OpenView(menu, null, initialTab)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenView(menu, null, initialTab);`
- `NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`；输入表达式：`Coop.CoopScreen.OpenCareerOrRoom(menu)`；返回值紧邻使用处：`ExpressionStatementSyntax: Coop.CoopScreen.OpenCareerOrRoom(menu);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2b6ef58a9693"></a>

## `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?) — public static void OpenView(Control menu, ICareerSession? multiplayer, string? initialTab = null)`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Open(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, string?)`](CareerScreen.cs.md#symbol-b760e48de501)；[`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`](DateGameScreen.cs.md#symbol-c74330b4dd26)；[`NationalSpire.Coop.CoopScreen.EnterCareer()`](Coop/CoopScreen.cs.md#symbol-88e296cd2158)；[`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`](Coop/CoopScreen.cs.md#symbol-eee7991d404e)

**调用：** [`NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`](CareerScreen.cs.md#symbol-3d547eb16e05)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`；输入表达式：`OpenCareerView(menu, multiplayer, initialTab, "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => OpenCareerView(menu, multiplayer, initialTab, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3d547eb16e05"></a>

## `NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string) — private static void OpenCareerView(Control menu, ICareerSession? multiplayer, string? initialTab, string reviewId)`

来源：源码第 173 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)

**调用：** [`NationalSpire.CareerListCache.For(Godot.Node)`](CareerListCache.cs.md#symbol-eba9914ced8b)；[`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.DashboardTheme()`](DashboardControls.cs.md#symbol-72d1c6b180c3)；[`NationalSpire.SettlementRecords.InitialTab(NationalSpire.CareerData)`](SettlementRecord.cs.md#symbol-1035c20d576a)；`Godot.CanvasItem.Hide()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext.Update()`；`NationalSpire.CareerScreen.CareerScreen()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache.For(Godot.Node)`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._hidden`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._open`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Build()`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.DashboardTheme()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.Data`；`NationalSpire.DateSceneExtensions.CreateCareerScreen`；`NationalSpire.ICareerSession.Data`；`NationalSpire.ICareerSession.Message`；`NationalSpire.SettlementRecords.InitialTab(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`child.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: child.Hide();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`menu.AddChild(screen)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddChild(screen);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`menu.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: menu.GetChildren().OfType<CanvasItem>`
- `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext.Update()`；输入表达式：`ActiveScreenContext.Instance.Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: ActiveScreenContext.Instance.Update();`
- `NationalSpire.CareerListCache.For(Godot.Node)`；输入表达式：`CareerListCache.For(menu)`；返回值紧邻使用处：`AssignmentExpressionSyntax: screen._listCache = CareerListCache.For(menu)`
- `NationalSpire.CareerScreen.Build()`；输入表达式：`screen.Build()`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.Build();`
- `NationalSpire.CareerScreen.CareerScreen()`；输入表达式：`new CareerScreen()`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneExtensions.CreateCareerScreen?.Invoke() ?? new CareerScreen()`
- `NationalSpire.CareerScreen.DashboardTheme()`；输入表达式：`DashboardTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: screen.Theme = DashboardTheme()`
- `NationalSpire.SettlementRecords.InitialTab(NationalSpire.CareerData)`；输入表达式：`SettlementRecords.InitialTab(multiplayer?.Data ?? CareerStore.Data)`；返回值紧邻使用处：`BinaryExpressionSyntax: initialTab ?? SettlementRecords.InitialTab(multiplayer?.Data ?? CareerStore.Data)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`screen._hidden.Add((child, child.Visible))`；返回值紧邻使用处：`ExpressionStatementSyntax: screen._hidden.Add((child, child.Visible));`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`menu.GetChildren().OfType<CanvasItem>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in menu.GetChildren().OfType<CanvasItem>())          { screen._hidden.Add((child, child.Visible)); child.Hide(); }`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.CreateCareerScreen?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_open` = `screen`
- `multiplayer.Message` += `screen.Notice`
- `screen._boundData` = `screen.ViewData`
- `screen._listCache` = `CareerListCache.For(menu)`
- `screen._multiplayer` = `multiplayer`
- `screen._reviewId` = `reviewId`
- `screen._tab` = `initialTab ?? SettlementRecords.InitialTab(multiplayer?.Data ?? CareerStore.Data)`
- `screen.MouseFilter` = `MouseFilterEnum.Stop`
- `screen.Name` = `"NationalSpireCareer"`
- `screen.Theme` = `DashboardTheme()`
- `screen.ZIndex` = `100`

<a id="symbol-80dfd99fda3e"></a>

## `NationalSpire.CareerScreen.Close() — private void Close()`

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.CloseCurrent()`](CareerSession.cs.md#symbol-5830f879d8f9)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)

**调用：** [`NationalSpire.CareerScreen.Close(bool)`](CareerScreen.cs.md#symbol-9bfd6bc6f6d3)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Close(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Close(bool)`；输入表达式：`Close(false)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Close(false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9bfd6bc6f6d3"></a>

## `NationalSpire.CareerScreen.Close(bool) — private void Close(bool force)`

来源：源码第 192 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`](DateGameScreen.cs.md#symbol-c74330b4dd26)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)

**调用：** [`NationalSpire.CareerListCache.Release()`](CareerListCache.cs.md#symbol-395e4ab9a213)；[`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-e39690a57e80)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.QueueFree()`；`MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext.Update()`；`System.IDisposable.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerListCache.Release()`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._hidden`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._open`；`NationalSpire.CareerScreen._starting`；`NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ICareerSession.Message`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(node)`；返回值紧邻使用处：`IfStatementSyntax: if (GodotObject.IsInstanceValid(node)) node.Visible = visible;`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsQueuedForDeletion() || !force && ViewData.Failure != null && _dateRunResume == null`
- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`
- `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext.Update()`；输入表达式：`ActiveScreenContext.Instance.Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: ActiveScreenContext.Instance.Update();`
- `NationalSpire.CareerListCache.Release()`；输入表达式：`.Release()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _listCache?.Release()`
- `NationalSpire.CareerScreen.AcknowledgeReview(NationalSpire.CareerData)`；输入表达式：`AcknowledgeReview(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: AcknowledgeReview(ViewData);`
- `System.IDisposable.Dispose()`；输入表达式：`_multiplayer.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_multiplayer.Message` -= `Notice`
- `_open` = `null`
- `node.Visible` = `visible`

<a id="symbol-5aaebf0ee0ab"></a>

## `NationalSpire.CareerScreen._ExitTree() — public override void _ExitTree()`

来源：源码第 202 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerListCache.Release()`](CareerListCache.cs.md#symbol-395e4ab9a213)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`Godot.Tween.Kill()`；`System.IDisposable.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache.Release()`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._open`；`NationalSpire.CareerScreen._pageTween`；`NationalSpire.CareerScreen._weeklyTween`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.ICareerSession.Message`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_listCache)`；返回值紧邻使用处：`BinaryExpressionSyntax: _listCache != null && IsInstanceValid(_listCache)`
- `Godot.Node.IsInsideTree()`；输入表达式：`_listCache.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: _listCache != null && IsInstanceValid(_listCache) && _listCache.IsInsideTree()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pageTween?.Kill()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _weeklyTween?.Kill()`
- `NationalSpire.CareerListCache.Release()`；输入表达式：`_listCache.Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: _listCache.Release();`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `System.IDisposable.Dispose()`；输入表达式：`_multiplayer.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_multiplayer.Message` -= `Notice`
- `_open` = `null`

<a id="symbol-8b4784fe3138"></a>

## `NationalSpire.CareerScreen.Build() — private void Build()`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerView(Godot.Control, NationalSpire.ICareerSession?, string?, string)`](CareerScreen.cs.md#symbol-3d547eb16e05)

**调用：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.LandscapeViewport.Mount(Godot.Control)`](DashboardViewport.cs.md#symbol-adb87fe8fef5)；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.BroadcastBackdrop.BroadcastBackdrop()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.BuildDashboardShell()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerStore.LoadNotice`；`NationalSpire.LandscapeViewport.Mount(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(background)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(background);`
- `NationalSpire.BroadcastBackdrop.BroadcastBackdrop()`；输入表达式：`new BroadcastBackdrop()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastBackdrop()`
- `NationalSpire.CareerScreen.BuildDashboardShell()`；输入表达式：`BuildDashboardShell()`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildDashboardShell();`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(CareerStore.LoadNotice, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(CareerStore.LoadNotice, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.LandscapeViewport.Mount(Godot.Control)`；输入表达式：`LandscapeViewport.Mount(this)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _stage = LandscapeViewport.Mount(this)`

**赋值（含属性/字段和局部值）：**

- `_stage` = `LandscapeViewport.Mount(this)`

<a id="symbol-d4a4496fddb9"></a>

## `NationalSpire.CareerScreen.Render() — private void Render()`

来源：源码第 220 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Launch()`](CareerScreen.cs.md#symbol-9971cb44a804)；[`Month(int)`](CareerScreen.cs.md#symbol-37a56bda571d)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.AdvanceCareerDay()`](MarketScreen.cs.md#symbol-871f6318461f)；[`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.BeginClubDraft()`](OwnedClubScreen.cs.md#symbol-09bdfebb252f)；[`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`](CalendarPlansScreen.cs.md#symbol-0019411c0ad4)；[`NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`](CareerScreen.cs.md#symbol-b27d08d34395)；[`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-5700a0d050b5)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.ClubLeaveDialog()`](ClubDepartureScreen.cs.md#symbol-6954ceb20cdf)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-f212593005f6)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.FinishPlan(string?)`](CalendarPlansScreen.cs.md#symbol-100b2aec3e40)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenProfileList(string?)`](CareerNavigation.cs.md#symbol-fa604705ef07)；[`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)；[`NationalSpire.CareerScreen.OpenShopShelf(string?)`](ConsumerScreen.cs.md#symbol-76b18b4a51c9)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`](CoachScreen.cs.md#symbol-a537f69fc7d9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)；[`NationalSpire.CareerScreen.RefreshClub()`](OwnedClubScreen.cs.md#symbol-29d092fa090a)；[`NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-b0bc87216d33)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch)`](DateGameReturn.cs.md#symbol-9e75de0044f4)；[`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`](MatchArenaScreen.cs.md#symbol-2553d6834735)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.SwitchTab(string)`](CareerNavigation.cs.md#symbol-64b01d2d7cc1)；[`NationalSpire.CareerScreen.TravelTo(int)`](CalendarPlansScreen.cs.md#symbol-898d70175a58)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`Page(int)`](MatchArenaScreen.cs.md#symbol-9cee07a82214)；[`Search()`](CareerScreen.cs.md#symbol-a9415bdffe1f)；[`ShowSavedCard()`](CharacterCardScreen.cs.md#symbol-b8738fabd73d)；[`Updated()`](RandomEventScreen.cs.md#symbol-a180dd9f851f)

**调用：** [`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`](AiService.cs.md#symbol-4f47e0824ca3)；[`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`](AiWeekly.cs.md#symbol-bb0ee823dfc4)；[`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；[`NationalSpire.CareerListCache.Release()`](CareerListCache.cs.md#symbol-395e4ab9a213)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.AddSessionStatus(NationalSpire.ICareerSession)`](CareerSession.cs.md#symbol-74ce1c353daf)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.AnimatePage()`](BroadcastVisuals.cs.md#symbol-2d2341b9ff8a)；[`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)；[`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8f255f3d5c6b)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowDueAppointments()`](EventJourneyScreen.cs.md#symbol-0633783689c3)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)；[`NationalSpire.CareerScreen.StyleNavigationRail()`](CareerScreen.cs.md#symbol-d4c2ebafd21b)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-52ec8ee2b3ad)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`](EventJourney.cs.md#symbol-5010e9adc2fd)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.ProactiveChats.StartQueued(NationalSpire.CareerData)`](ProactiveChats.cs.md#symbol-67e715945068)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetParent<T>()`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`；`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`；`NationalSpire.AiWorkState.State`；`NationalSpire.BroadcastScroll.StopMotion()`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Journey`；`NationalSpire.CareerData.NpcSetupPending`；`NationalSpire.CareerData.PendingCeremonySeason`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Rating`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerListCache.Release()`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._backButton`；`NationalSpire.CareerScreen._ceremonySeason`；`NationalSpire.CareerScreen._ceremonySection`；`NationalSpire.CareerScreen._characterCardInPage`；`NationalSpire.CareerScreen._closeCharacterCard`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._latestEvent`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen._mentionsChecked`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._notice`；`NationalSpire.CareerScreen._noticedCeremonySeason`；`NationalSpire.CareerScreen._npcSetupOpening`；`NationalSpire.CareerScreen._pageTitle`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postSignature`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._status`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.AddSessionStatus(NationalSpire.ICareerSession)`；`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.AnimatePage()`；`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.BeginNpcSetup(bool)`；`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MainWidth`；`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.RenderTeam()`；`NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ShowDueAppointments()`；`NationalSpire.CareerScreen.ShowJourneyEncounter()`；`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.StyleNavigationRail()`；`NationalSpire.CareerScreen.UpdateCommunityBadge()`；`NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.UpdateNavigation()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`；`NationalSpire.EventJourney.ResumePublications`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.ProactiveChats.StartQueued(NationalSpire.CareerData)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Render`；`NationalSpire.WeeklyEdition.NewsWork`；`NationalSpire.WeeklyEdition.ProfilesWork`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) BeginNpcSetup(true); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) BeginNpcSetup(true); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) BeginNpcSetup(true); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) BeginNpcSetup(true); }).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`_notice.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _notice.Hide();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_status.AddThemeColorOverride("font_color", _muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _status.AddThemeColorOverride("font_color", _muted);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_content.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_scroll.GetVScrollBar().GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _scroll.GetVScrollBar().GetCombinedMinimumSize().X`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && !IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsQueuedForDeletion()`
- `Godot.Node.GetParent<T>()`；输入表达式：`_scroll.GetParent<Control>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _scroll.GetParent<Control>()`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_scroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _scroll.GetVScrollBar().GetCombinedMinimumSize`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(MainWidth + (_tab == "首页" ? _scroll.GetVScrollBar().GetCombinedMinimumSize().X : 0), 840)`；返回值紧邻使用处：`AssignmentExpressionSyntax: main.Size = new(MainWidth + (_tab == "首页" ? _scroll.GetVScrollBar().GetCombinedMinimumSize().X : 0), 840)`
- `int.ToString()`；输入表达式：`pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: pending.ToString()`
- `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`；输入表达式：`AiService.ProcessPendingAsync(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPendingAsync(data)`
- `NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessWeeklyAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessWeeklyAsync()`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`scrolling.StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: scrolling.StopMotion();`
- `NationalSpire.CareerListCache.Release()`；输入表达式：`.Release()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _listCache?.Release()`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(data)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(data)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(CareerMoney.Balance(data))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Compact(CareerMoney.Balance(data))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerMoney.Balance(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: "可用资金 " + CareerMoney.Format(CareerMoney.Balance(data))`
- `NationalSpire.CareerScreen.AddSessionStatus(NationalSpire.ICareerSession)`；输入表达式：`AddSessionStatus(session)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddSessionStatus(session);`
- `NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`；输入表达式：`AiSettings(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiSettings(data);`
- `NationalSpire.CareerScreen.AnimatePage()`；输入表达式：`AnimatePage()`；返回值紧邻使用处：`ExpressionStatementSyntax: AnimatePage();`
- `NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`；输入表达式：`AssetsPage(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: AssetsPage(data);`
- `NationalSpire.CareerScreen.BeginNpcSetup(bool)`；输入表达式：`BeginNpcSetup(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginNpcSetup(true);`
- `NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`；输入表达式：`Calendar(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Calendar(data);`
- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessagesCore(false);`
- `NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`；输入表达式：`Community(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Community(data);`
- `NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`；输入表达式：`DashboardHeader(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: DashboardHeader(ViewData);`
- `NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`；输入表达式：`FixtureSchedule(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: FixtureSchedule(data);`
- `NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`；输入表达式：`Home(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Home(data);`
- `NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`；输入表达式：`Life(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Life(data);`
- `NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`；输入表达式：`Matches(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Matches(data);`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("ceremony-read", pending.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: MultiplayerCommand("ceremony-read", pending.ToString());`
- `NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；输入表达式：`OpenCharacterCard(data, null)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCharacterCard(data, null);`
- `NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`；输入表达式：`Profiles(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Profiles(data);`
- `NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`；输入表达式：`RankingPage(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: RankingPage(data);`
- `NationalSpire.CareerScreen.RenderTeam()`；输入表达式：`RenderTeam()`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderTeam();`
- `NationalSpire.CareerScreen.ReviewRecord(NationalSpire.CareerData)`；输入表达式：`ReviewRecord(data)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ReviewRecord(data)?.MatchId`
- `NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`；输入表达式：`Settlement(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Settlement(data);`
- `NationalSpire.CareerScreen.ShowDueAppointments()`；输入表达式：`ShowDueAppointments()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDueAppointments();`
- `NationalSpire.CareerScreen.ShowJourneyEncounter()`；输入表达式：`ShowJourneyEncounter()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowJourneyEncounter();`
- `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；输入表达式：`Signature(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _postSignature = Signature(data)`
- `NationalSpire.CareerScreen.StyleNavigationRail()`；输入表达式：`StyleNavigationRail()`；返回值紧邻使用处：`ExpressionStatementSyntax: StyleNavigationRail();`
- `NationalSpire.CareerScreen.UpdateCommunityBadge()`；输入表达式：`UpdateCommunityBadge()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateCommunityBadge();`
- `NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`；输入表达式：`UpdateHeaderAccount(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateHeaderAccount(ViewData);`
- `NationalSpire.CareerScreen.UpdateNavigation()`；输入表达式：`UpdateNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateNavigation();`
- `NationalSpire.CareerScreen.World(NationalSpire.CareerData)`；输入表达式：`World(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: World(data);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(ViewData);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_content)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_content);`
- `NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData)`；输入表达式：`EventJourney.PublicationsPaused(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !EventJourney.PublicationsPaused(data)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, data.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, data.Day)}`
- `NationalSpire.ProactiveChats.StartQueued(NationalSpire.CareerData)`；输入表达式：`ProactiveChats.StartQueued(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProactiveChats.StartQueued(data);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Render, _tab)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Render, _tab)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _closeCharacterCard?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Any(w => w.ProfilesWork.State == "idle" || w.NewsWork.State == "idle")`；返回值紧邻使用处：`BinaryExpressionSyntax: _multiplayer == null && !data.NpcSetupPending && !EventJourney.PublicationsPaused(data) && data.Ai.Enabled && data.WeeklyEditions.Any(w => w.ProfilesWork.State == "idle" || w.NewsWork.State == "idle")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`data.Posts.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Posts.FirstOrDefault()?.AuthorId`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`data.Posts.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Posts.FirstOrDefault()?.Id`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPendingAsync(data)`
- `_` = `AiService.ProcessWeeklyAsync()`
- `_backButton.Disabled` |= `data.Failure != null`
- `_ceremonySeason` = `pending`
- `_ceremonySection` = `"获奖名单"`
- `_competitionId` = `null`
- `_content.SizeFlagsVertical` = `SizeFlags.Fill`
- `_latestEvent` = `latestEvent`
- `_mentionsChecked` = `false`
- `_noticedCeremonySeason` = `pending`
- `_npcSetupOpening` = `true`
- `_pageTitle.Text` = `_tab == "首页" ? "生涯大厅" : _tab == "赛事与俱乐部" && _worldSection == "颁奖盛典" ? "颁奖盛典" : _tab`
- `_personId` = `null`
- `_postSignature` = `Signature(data)`
- `_reviewId` = `ReviewRecord(data)?.MatchId??""`
- `_scroll.VerticalScrollMode` = `ScrollContainer.ScrollMode.Reserve`
- `_scroll.Visible` = `_tab != "创建角色"`
- `_status.MouseFilter` = `MouseFilterEnum.Pass`
- `_status.Text` = `$"第 {data.Season} 赛季 · {GameCalendar.Text(data, data.Day)}   评分 {data.Rating}   关注 {data.Fans}   可用资金 {CareerMoney.Compact(CareerMoney.Balance(data))}"`
- `_status.TooltipText` = `"可用资金 " + CareerMoney.Format(CareerMoney.Balance(data))`
- `_tab` = `"结算"`
- `_tab` = `"赛事与俱乐部"`
- `_tab` = `"选手档案"`
- `_worldSection` = `"颁奖盛典"`
- `data.Journey.ResumePublications` = `false`
- `main.Size` = `new(MainWidth + (_tab == "首页" ? _scroll.GetVScrollBar().GetCombinedMinimumSize().X : 0), 840)`
- `ViewData.PendingCeremonySeason` = `0`

<a id="symbol-d4c2ebafd21b"></a>

## `NationalSpire.CareerScreen.StyleNavigationRail() — private void StyleNavigationRail()`

来源：源码第 304 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；`Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._navButtons`；`NationalSpire.CareerScreen._styledRail`；`NationalSpire.CareerScreen.ActiveRail`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.ViewData`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`button.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: button.QueueRedraw();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color",active ? _gold : _muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color",active ? _gold : _muted);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_focus_color",_gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_focus_color",_gold);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_hover_color",active ? _gold : _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_hover_color",active ? _gold : _ink);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(76,name=="社区" ? 88 : name=="模组设置" ? 55 : 78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.Size = new(76,name=="社区" ? 88 : name=="模组设置" ? 55 : 78)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(button,fill,edge,active ? "34545d" : "213945","658c91",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(button,fill,edge,active ? "34545d" : "213945","658c91",0);`

**赋值（含属性/字段和局部值）：**

- `_styledRail` = `activeRail`
- `button.Disabled` = `ViewData.Failure != null && name != "结算"`
- `button.Size` = `new(76,name=="社区" ? 88 : name=="模组设置" ? 55 : 78)`

<a id="symbol-cfc51eea9b9f"></a>

## `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData) — private DiscussionRevision Signature(CareerData data)`

来源：源码第 324 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`Vote(int)`](CommunityScreen.cs.md#symbol-c7fecf2b615f)

**调用：** [`Collect(System.Collections.Generic.List<NationalSpire.CommunityPost>)`](CareerScreen.cs.md#symbol-0e46053316c7)；[`Work(ref System.HashCode, NationalSpire.AiWorkState)`](CareerScreen.cs.md#symbol-95fb1b1f1415)；`NationalSpire.CareerScreen.DiscussionRevision.DiscussionRevision(int, int, int, long)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.HashCode.Add<T>(T)`；`System.HashCode.HashCode()`；`System.HashCode.ToHashCode()`

**字段、属性、事件及方法组引用：** `Collect(System.Collections.Generic.List<NationalSpire.CommunityPost>)`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerScreen._signaturePostIds`；`NationalSpire.CareerScreen._tab`；`NationalSpire.ChatWorld.Order`；`NationalSpire.WeeklyEdition.NewsWork`；`NationalSpire.WeeklyEdition.ProfilesWork`；`NationalSpire.WeeklyEdition.Revision`；`NationalSpire.WeeklyEdition.SeenRevision`；`NationalSpire.WeeklyEdition.Week`；`Work(ref System.HashCode, NationalSpire.AiWorkState)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Collect(System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`Collect(data.Posts)`；返回值紧邻使用处：`ExpressionStatementSyntax: Collect(data.Posts);`
- `Collect(System.Collections.Generic.List<NationalSpire.CommunityPost>)`；输入表达式：`Collect(data.SavedThreads)`；返回值紧邻使用处：`ExpressionStatementSyntax: Collect(data.SavedThreads);`
- `NationalSpire.CareerScreen.DiscussionRevision.DiscussionRevision(int, int, int, long)`；输入表达式：`new(posts.ToHashCode(), editions.ToHashCode(), _signaturePostIds.Count, _tab == "首页" ? data.Chats.Order : 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(posts.ToHashCode(), editions.ToHashCode(), _signaturePostIds.Count, _tab == "首页" ? data.Chats.Order : 0);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_signaturePostIds.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _signaturePostIds.Clear();`
- `System.HashCode.Add<T>(T)`；输入表达式：`editions.Add(w.Revision)`；返回值紧邻使用处：`ExpressionStatementSyntax: editions.Add(w.Revision);`
- `System.HashCode.Add<T>(T)`；输入表达式：`editions.Add(w.SeenRevision)`；返回值紧邻使用处：`ExpressionStatementSyntax: editions.Add(w.SeenRevision);`
- `System.HashCode.Add<T>(T)`；输入表达式：`editions.Add(w.Week)`；返回值紧邻使用处：`ExpressionStatementSyntax: editions.Add(w.Week);`
- `System.HashCode.HashCode()`；输入表达式：`new HashCode()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashCode()`
- `System.HashCode.ToHashCode()`；输入表达式：`editions.ToHashCode()`；返回值紧邻使用处：`ArgumentSyntax: editions.ToHashCode()`
- `System.HashCode.ToHashCode()`；输入表达式：`posts.ToHashCode()`；返回值紧邻使用处：`ArgumentSyntax: posts.ToHashCode()`
- `Work(ref System.HashCode, NationalSpire.AiWorkState)`；输入表达式：`Work(ref editions, w.NewsWork)`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(ref editions, w.NewsWork);`
- `Work(ref System.HashCode, NationalSpire.AiWorkState)`；输入表达式：`Work(ref editions, w.ProfilesWork)`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(ref editions, w.ProfilesWork);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-95fb1b1f1415"></a>

## `Work(ref System.HashCode, NationalSpire.AiWorkState) — static void Work(ref HashCode hash, AiWorkState work)`

来源：源码第 329 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Collect(System.Collections.Generic.List<NationalSpire.CommunityPost>)`](CareerScreen.cs.md#symbol-0e46053316c7)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)

**调用：** `System.HashCode.Add<T>(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.AiWorkState.WaitReason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.HashCode.Add<T>(T)`；输入表达式：`hash.Add(work.Error)`；返回值紧邻使用处：`ExpressionStatementSyntax: hash.Add(work.Error);`
- `System.HashCode.Add<T>(T)`；输入表达式：`hash.Add(work.State)`；返回值紧邻使用处：`ExpressionStatementSyntax: hash.Add(work.State);`
- `System.HashCode.Add<T>(T)`；输入表达式：`hash.Add(work.WaitReason)`；返回值紧邻使用处：`ExpressionStatementSyntax: hash.Add(work.WaitReason);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0e46053316c7"></a>

## `Collect(System.Collections.Generic.List<NationalSpire.CommunityPost>) — void Collect(List<CommunityPost> source)`

来源：源码第 333 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)

**调用：** [`Work(ref System.HashCode, NationalSpire.AiWorkState)`](CareerScreen.cs.md#symbol-95fb1b1f1415)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.HashCode.Add<T>(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._signaturePostIds`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityPost.VoteRevision`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ReactionGeneration`；`Work(ref System.HashCode, NationalSpire.AiWorkState)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_signaturePostIds.Add(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_signaturePostIds.Add(p.Id)`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(p.AiPending)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(p.AiPending);`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(p.Id);`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(p.Revision)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(p.Revision);`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(p.SeenRevision)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(p.SeenRevision);`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(p.VoteRevision)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(p.VoteRevision);`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(reply.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(reply.Id);`
- `System.HashCode.Add<T>(T)`；输入表达式：`posts.Add(reply.NeedsReaction)`；返回值紧邻使用处：`ExpressionStatementSyntax: posts.Add(reply.NeedsReaction);`
- `Work(ref System.HashCode, NationalSpire.AiWorkState)`；输入表达式：`Work(ref posts, p.NewsGeneration)`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(ref posts, p.NewsGeneration);`
- `Work(ref System.HashCode, NationalSpire.AiWorkState)`；输入表达式：`Work(ref posts, p.ReactionGeneration)`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(ref posts, p.ReactionGeneration);`
- `Work(ref System.HashCode, NationalSpire.AiWorkState)`；输入表达式：`Work(ref posts, reply.ReactionGeneration)`；返回值紧邻使用处：`ExpressionStatementSyntax: Work(ref posts, reply.ReactionGeneration);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-059910dfde25"></a>

## `NationalSpire.CareerScreen.Home(NationalSpire.CareerData) — private void Home(CareerData data)`

来源：源码第 356 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.CareerAvatars.HomeCardVariation(NationalSpire.CareerData)`](CareerAvatars.cs.md#symbol-eb2a2d40fdf7)；[`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-0b8521a25ad9)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-1eb97a843d59)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData, Godot.Container)`](CeremonyScreen.cs.md#symbol-071fb0b79ec4)；[`NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-2eeae75151b7)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Dot(Godot.Control)`](CareerDashboard.cs.md#symbol-15e9bc391bf6)；[`NationalSpire.CareerScreen.EnsureChatPreferencesLoaded()`](ChatHistoryScreen.cs.md#symbol-36884b55f7cb)；[`NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`](RandomEventScreen.cs.md#symbol-e27dca18c72a)；[`NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int)`](CareerDashboard.cs.md#symbol-a0e5a4138c47)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.GoHub(string)`](CareerDashboard.cs.md#symbol-06744bf6f9f0)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.HomeButtonPair(string)`](CareerDashboard.cs.md#symbol-a7b926e9dfcd)；[`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerDashboard.cs.md#symbol-69636991bb5e)；[`NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action)`](CareerDashboard.cs.md#symbol-45b939cf9037)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.JourneyResumeButton(NationalSpire.CareerData, Godot.VBoxContainer)`](EventJourneyScreen.cs.md#symbol-a869d888b335)；[`NationalSpire.CareerScreen.LoadContactPreferences()`](ChatContactScreen.cs.md#symbol-e08a92c62c9a)；[`NationalSpire.CareerScreen.OpenAgendaItem(NationalSpire.CareerData, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-c0f0934f723d)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)；[`NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`](FixtureScheduleScreen.cs.md#symbol-b367c62d489f)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenProfileList(string?)`](CareerNavigation.cs.md#symbol-fa604705ef07)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerScreen.TravelTo(int)`](CalendarPlansScreen.cs.md#symbol-898d70175a58)；[`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`](CalendarPlansScreen.cs.md#symbol-4e05fc1196b2)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；[`NationalSpire.ChatContacts.Recent(NationalSpire.CareerData, System.Collections.Generic.HashSet<string>)`](ChatContacts.cs.md#symbol-e1ca2103614f)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`](GroupAvatar.cs.md#symbol-5d97e2be271b)；[`NationalSpire.MarketTerminal.ShowAsset(string)`](MarketTerminal.cs.md#symbol-6e818241b8fb)；[`NationalSpire.MarketTerminal.WatchedAssets(NationalSpire.CareerData)`](MarketTerminal.cs.md#symbol-2d829232b7a3)；[`NationalSpire.PrivateInteractionHistory.LatestFavourChange(NationalSpire.PrivateConversation, NationalSpire.PrivateRelation?)`](PrivateInteractionUndo.cs.md#symbol-5795d52a2117)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.SeasonCeremony.ShowInvitation(NationalSpire.CareerData)`](SeasonCeremony.cs.md#symbol-e0254247811d)；[`Primary(string, System.Action)`](CareerScreen.cs.md#symbol-1038401c1d6f)；[`Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`](CareerScreen.cs.md#symbol-fed969ea23f7)；`char.ToString()`；`decimal.ToString(string?)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.Free()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetParent()`；`Godot.PanelContainer.PanelContainer()`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`int.ToString(string?)`；`NationalSpire.BroadcastPortrait.BroadcastPortrait()`；`NationalSpire.GroupAvatar.GroupAvatar()`；`string.IsNullOrEmpty(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<decimal>.Max()`；`System.Collections.Generic.IEnumerable<decimal>.Min()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.DateOnly.ToString(string?)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.BroadcastPortrait.Art`；`NationalSpire.CareerAvatars.HomeCardVariation(NationalSpire.CareerData)`；`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerListCache.Market`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerScreen._arenaCharacter`；`NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._weekDay`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`；`NationalSpire.CareerScreen.AgendaItem.Day`；`NationalSpire.CareerScreen.AgendaItem.Detail`；`NationalSpire.CareerScreen.AgendaItem.Match`；`NationalSpire.CareerScreen.AgendaItem.Person`；`NationalSpire.CareerScreen.AgendaItem.Title`；`NationalSpire.CareerScreen.AgendaItem.Visit`；`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData, Godot.Container)`；`NationalSpire.CareerScreen.ChoosePrivateContact()`；`NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Dot(Godot.Control)`；`NationalSpire.CareerScreen.EnsureChatPreferencesLoaded()`；`NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`；`NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.GoHub(string)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.HomeButtonPair(string)`；`NationalSpire.CareerScreen.HomeColumnGap`；`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action)`；`NationalSpire.CareerScreen.HomeSideWidth`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.JourneyResumeButton(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.LoadContactPreferences()`；`NationalSpire.CareerScreen.OpenAgendaItem(NationalSpire.CareerData, NationalSpire.CareerScreen.AgendaItem)`；`NationalSpire.CareerScreen.OpenCalendarDay(int)`；`NationalSpire.CareerScreen.OpenCommunity()`；`NationalSpire.CareerScreen.OpenLifePage(string)`；`NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.OpenProfileList(string?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerScreen.TravelTo(int)`；`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Lime`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChatContact.Favour`；`NationalSpire.ChatContact.Group`；`NationalSpire.ChatContact.Id`；`NationalSpire.ChatContact.Name`；`NationalSpire.ChatContactPreferences.Hidden`；`NationalSpire.ChatContacts.Recent(NationalSpire.CareerData, System.Collections.Generic.HashSet<string>)`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Title`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketPoint.Price`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketTerminal.ShowAsset(string)`；`NationalSpire.MarketTerminal.WatchedAssets(NationalSpire.CareerData)`；`NationalSpire.PrivateInteractionHistory.LatestFavourChange(NationalSpire.PrivateConversation, NationalSpire.PrivateRelation?)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.SeasonCeremony.ShowInvitation(NationalSpire.CareerData)`；`OpenMarket()`；`Primary(string, System.Action)`；`Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.ToString()`；输入表达式：`"一二三四五六日"[i].ToString()`；返回值紧邻使用处：`ArgumentSyntax: "一二三四五六日"[i].ToString()`
- `decimal.ToString(string?)`；输入表达式：`(quote.Price/quote.Previous-1).ToString("+0.00%;-0.00%;0.00%")`；返回值紧邻使用处：`ConditionalExpressionSyntax: quote.Previous>0?(quote.Price/quote.Previous-1).ToString("+0.00%;-0.00%;0.00%"):""`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`heroPanel.DrawColoredPolygon([new(x-251,1),new(x-2,1),new(x-2,y-2),new(x-350,y-2)],new Color("24495822"))`；返回值紧邻使用处：`ExpressionStatementSyntax: heroPanel.DrawColoredPolygon([new(x-251,1),new(x-2,1),new(x-2,y-2),new(x-350,y-2)],new Color("24495822"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`b.DrawLine(new(2,b.Size.Y-2),new(b.Size.X-2,b.Size.Y-2),CareerVisuals.Teal,2)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>b.DrawLine(new(2,b.Size.Y-2),new(b.Size.X-2,b.Size.Y-2),CareerVisuals.Teal,2)`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`trend.DrawPolyline(points, tint, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: trend.DrawPolyline(points, tint, 1.5f, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`heroPanel.DrawRect(new(31,1,72,3),CareerVisuals.Lime)`；返回值紧邻使用处：`ExpressionStatementSyntax: heroPanel.DrawRect(new(31,1,72,3),CareerVisuals.Lime);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("24495822")`；返回值紧邻使用处：`ArgumentSyntax: new Color("24495822")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ef9295")`；返回值紧邻使用处：`ConditionalExpressionSyntax: delta>0?CareerVisuals.Teal:new Color("ef9295")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ef9295")`；返回值紧邻使用处：`ConditionalExpressionSyntax: quote.Price >= quote.Previous ? CareerVisuals.Teal : new Color("ef9295")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`openWeek.AddThemeColorOverride("font_color",_ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: openWeek.AddThemeColorOverride("font_color",_ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("h_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("h_separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("v_separation",5)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("v_separation",5);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",2)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",2);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`days.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: days.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`due.AddThemeConstantOverride("h_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: due.AddThemeConstantOverride("h_separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`focus.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: focus.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`gap.AddThemeConstantOverride("margin_top",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: gap.AddThemeConstantOverride("margin_top",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("separation", HomeColumnGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("separation", HomeColumnGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`main.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddThemeConstantOverride("separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`meta.AddThemeConstantOverride("separation",13)`；返回值紧邻使用处：`ExpressionStatementSyntax: meta.AddThemeConstantOverride("separation",13);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`poster.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: poster.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`posterCaption.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: posterCaption.AddThemeConstantOverride("separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`side.AddThemeConstantOverride("separation",24)`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddThemeConstantOverride("separation",24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`stats.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: stats.AddThemeConstantOverride("separation",6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`strip.AddThemeConstantOverride("separation",14)`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddThemeConstantOverride("separation",14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`updates.AddThemeConstantOverride("separation",26)`；返回值紧邻使用处：`ExpressionStatementSyntax: updates.AddThemeConstantOverride("separation",26);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`words.AddThemeConstantOverride("separation",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddThemeConstantOverride("separation",15);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`headline.AddThemeFontOverride("font",CareerVisuals.InterfaceText(tracking:2))`；返回值紧邻使用处：`ExpressionStatementSyntax: headline.AddThemeFontOverride("font",CareerVisuals.InterfaceText(tracking:2));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`heroPanel.AddThemeStyleboxOverride("panel",heroStyle)`；返回值紧邻使用处：`ExpressionStatementSyntax: heroPanel.AddThemeStyleboxOverride("panel",heroStyle);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`tag.AddThemeStyleboxOverride("panel",border)`；返回值紧邻使用处：`ExpressionStatementSyntax: tag.AddThemeStyleboxOverride("panel",border);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(90, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(90, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.Control()`；输入表达式：`new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Control.Control()`；输入表达式：`new Control{CustomMinimumSize=new(0,16)}`；返回值紧邻使用处：`ArgumentSyntax: new Control{CustomMinimumSize=new(0,16)}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.Free()`；输入表达式：`due.Free()`；返回值紧邻使用处：`ExpressionStatementSyntax: due.Free();`
- `Godot.GodotObject.Free()`；输入表达式：`eventColumn.Free()`；返回值紧邻使用处：`ExpressionStatementSyntax: eventColumn.Free();`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer {Name="HomeToday"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer {Name="HomeToday"}`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(due)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(due);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(calendarAction)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(calendarAction);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(FramedAction("查看赛程", () => OpenMatchFixture(data, nextMatch), width: 112, height: 46, quiet: true))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(FramedAction("查看赛程", () => OpenMatchFixture(data, nextMatch), width: 112, height: 46, quiet: true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel($"群聊 · {group.Members.Distinct().Count()} 人",14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel($"群聊 · {group.Members.Distinct().Count()} 人",14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(post.Category+" · "+post.Replies.Count+" 条回复",13,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(post.Category+" · "+post.Replies.Count+" 条回复",13,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(number);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(postTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(postTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(stats)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(stats);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(weekday)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(weekday);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`due.AddChild(eventColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: due.AddChild(eventColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(figures)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(figures);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(trend)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(trend);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`focus.AddChild(poster)`；返回值紧邻使用处：`ExpressionStatementSyntax: focus.AddChild(poster);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`focus.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: focus.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`gap.AddChild(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: gap.AddChild(strip);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(main)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(main);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(side)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(side);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(TextLink("公开消息",()=>OpenLifePage("公开消息")))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: header=>header.AddChild(TextLink("公开消息",()=>OpenLifePage("公开消息")))`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`hero.AddChild(focus)`；返回值紧邻使用处：`ExpressionStatementSyntax: hero.AddChild(focus);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(Glyph("chevron-right",14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(Glyph("chevron-right",14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`links.AddChild(link)`；返回值紧邻使用处：`ExpressionStatementSyntax: links.AddChild(link);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(Text(single?"当日暂无安排":"本周暂无后续安排",15,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(Text(single?"当日暂无安排":"本周暂无后续安排",15,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`main.AddChild(new Control{CustomMinimumSize=new(0,16)})`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddChild(new Control{CustomMinimumSize=new(0,16)});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`main.AddChild(Text("最近更新",24,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddChild(Text("最近更新",24,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`main.AddChild(updates)`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddChild(updates);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`market.AddChild(Hairline())`；返回值紧邻使用处：`ExpressionStatementSyntax: market.AddChild(Hairline());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`meta.AddChild(DashboardLabel(next.Match is { } m ? $"已报名    进阶 {m.RequiredAscension}" :                  next.Visit!=null ? "已确认" : next.Detail,16,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: meta.AddChild(DashboardLabel(next.Match is { } m ? $"已报名    进阶 {m.RequiredAscension}" :                  next.Visit!=null ? "已确认" : next.Detail,16,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`meta.AddChild(tag)`；返回值紧邻使用处：`ExpressionStatementSyntax: meta.AddChild(tag);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`news.AddChild(Hairline())`；返回值紧邻使用处：`ExpressionStatementSyntax: news.AddChild(Hairline());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portrait.AddChild(art)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddChild(art);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`poster.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: poster.AddChild(portrait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`posterCaption.AddChild(DashboardLabel(displayName,18,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: posterCaption.AddChild(DashboardLabel(displayName,18,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`posterCaption.AddChild(posterArrow)`；返回值紧邻使用处：`ExpressionStatementSyntax: posterCaption.AddChild(posterArrow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`posterCaption.AddChild(roleText)`；返回值紧邻使用处：`ExpressionStatementSyntax: posterCaption.AddChild(roleText);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`recent.AddChild(gap)`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.AddChild(gap);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(mosaic)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(mosaic);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`side.AddChild(links)`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddChild(links);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stats.AddChild(change)`；返回值紧邻使用处：`ExpressionStatementSyntax: stats.AddChild(change);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stats.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: stats.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`strip.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tag.AddChild(DashboardLabel(next.Match!=null?"比赛":next.Visit!=null?"约会":"际遇",14,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: tag.AddChild(DashboardLabel(next.Match!=null?"比赛":next.Visit!=null?"约会":"际遇",14,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`week.AddChild(days)`；返回值紧邻使用处：`ExpressionStatementSyntax: week.AddChild(days);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`week.AddChild(weekHeader)`；返回值紧邻使用处：`ExpressionStatementSyntax: week.AddChild(weekHeader);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`week.AddChild(weekScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: week.AddChild(weekScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`weekHeader.AddChild(openWeek)`；返回值紧邻使用处：`ExpressionStatementSyntax: weekHeader.AddChild(openWeek);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`weekHeader.AddChild(weekRange)`；返回值紧邻使用处：`ExpressionStatementSyntax: weekHeader.AddChild(weekRange);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`weekScroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: weekScroll.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(DashboardLabel("下一项安排"+(next==null?"":" · "+(day==data.Day?"今天":GameCalendar.Date(data,day).ToString("M/d"))),15,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(DashboardLabel("下一项安排"+(next==null?"":" · "+(day==data.Day?"今天":GameCalendar.Date(data,day).ToString("M/d"))),15,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(headline)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(headline);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(meta)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(meta);`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`due.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: due.GetChildCount()>0`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`eventColumn.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: eventColumn.GetChildCount()>0`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`strip.GetChildCount()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =strip.GetChildCount()`
- `Godot.Node.GetParent()`；输入表达式：`hero.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (PanelContainer)hero.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`week.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)week.GetParent()`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {SizeFlagsVertical=SizeFlags.ShrinkCenter}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {SizeFlagsVertical=SizeFlags.ShrinkCenter}`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new(31,1,72,3)`；返回值紧邻使用处：`ArgumentSyntax: new(31,1,72,3)`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer {SizeFlagsVertical=SizeFlags.ExpandFill,HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ScrollContainer {SizeFlagsVertical=SizeFlags.ExpandFill,HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {CustomMinimumSize=new(276,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {CustomMinimumSize=new(276,0)}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {CustomMinimumSize=new(490,0),SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {CustomMinimumSize=new(490,0),SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {CustomMinimumSize=new(HomeSideWidth,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {CustomMinimumSize=new(HomeSideWidth,0)}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,204)`；返回值紧邻使用处：`AssignmentExpressionSyntax: recent.CustomMinimumSize=new(0,204)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,50)`；返回值紧邻使用处：`AssignmentExpressionSyntax: link.CustomMinimumSize=new(0,50)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,833)`；返回值紧邻使用处：`AssignmentExpressionSyntax: grid.CustomMinimumSize=new(0,833)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(2,b.Size.Y-2)`；返回值紧邻使用处：`ArgumentSyntax: new(2,b.Size.Y-2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(276,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(276,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(276,192)`；返回值紧邻使用处：`AssignmentExpressionSyntax: portrait.CustomMinimumSize=new(276,192)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(490,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(490,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(56,56)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(56,56)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8,8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: posterArrow.PivotOffset=new(8,8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(90, 26)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(90, 26)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(96, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: figures.CustomMinimumSize = new(96, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(b.Size.X-2,b.Size.Y-2)`；返回值紧邻使用处：`ArgumentSyntax: new(b.Size.X-2,b.Size.Y-2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(HomeSideWidth,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(HomeSideWidth,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x-2,1)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x-2,1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x-2,y-2)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x-2,y-2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x-251,1)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x-251,1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x-350,y-2)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x-350,y-2)`
- `int.ToString()`；输入表达式：`GameCalendar.Date(data,n).Day.ToString()`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Date(data,n).Day.ToString()`
- `int.ToString(string?)`；输入表达式：`delta.ToString("+0;-0;0")`；返回值紧邻使用处：`ArgumentSyntax: delta.ToString("+0;-0;0")`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(CareerAvatars.MainCharacter(data,person),person=="player"?CareerAvatars.HomeCardVariation(data):0,true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art=AvatarAssets.Load(CareerAvatars.MainCharacter(data,person),person=="player"?CareerAvatars.HomeCardVariation(data):0,true)`
- `NationalSpire.BroadcastPortrait.BroadcastPortrait()`；输入表达式：`new BroadcastPortrait {Art=AvatarAssets.Load(CareerAvatars.MainCharacter(data,person),person=="player"?CareerAvatars.HomeCardVariation(data):0,true),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastPortrait {Art=AvatarAssets.Load(CareerAvatars.MainCharacter(data,person),person=="player"?CareerAvatars.HomeCardVariation(data):0,true),MouseFilter=MouseFilterEnum.Ignore}`
- `NationalSpire.CareerAvatars.HomeCardVariation(NationalSpire.CareerData)`；输入表达式：`CareerAvatars.HomeCardVariation(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: person=="player"?CareerAvatars.HomeCardVariation(data):0`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.MainCharacter(data,person)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.MainCharacter(data,person)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.DisplayName(data,person)`
- `NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`；输入表达式：`CareerEngine.NextAvailable(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.NextAvailable(data)!=null`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(days,"Weekday_"+n,number.Text,()=>{_weekDay=n;Render();},copy,56,0,3,                  chosen?"28495a":n==data.Day?"28434c":"00000000","00000000","28434c")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ActionRow(days,"Weekday_"+n,number.Text,()=>{_weekDay=n;Render();},copy,56,0,3,                  chosen?"28495a":n==data.Day?"28434c":"00000000","00000000","28434c")`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(market, "HomeMarket_" + id, asset.Name, () => {                  OpenLifePage("交易市场"); _listCache!.Market.ShowAsset(id);              }, fields, updateRowHeight, 0, 5, "00000000", "00000000", "172c38")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActionRow(market, "HomeMarket_" + id, asset.Name, () => {                  OpenLifePage("交易市场"); _listCache!.Market.ShowAsset(id);              }, fields, updateRowHeight, 0, 5, "00000000", "00000000", "172c38")`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(news,"HomeNewsItem",post.Title,()=>OpenPost(post),line,updateRowHeight,0,5,"00000000","00000000","172c38")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ActionRow(news,"HomeNewsItem",post.Title,()=>OpenPost(post),line,updateRowHeight,0,5,"00000000","00000000","172c38")`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(poster,"HomePosterId",displayName,()=>OpenPerson(person),posterCaption,35,8,1,"00000000","00000000","203744")`；返回值紧邻使用处：`ExpressionStatementSyntax: ActionRow(poster,"HomePosterId",displayName,()=>OpenPerson(person),posterCaption,35,8,1,"00000000","00000000","203744");`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(strip,(contact.Group ? "GroupContact_" : "Contact_") + contact.Id,contact.Name,                  () => OpenPrivateMessages(contact.Group ? "" : contact.Id,contact.Group ? contact.Id : ""),row,90,14,10,"122432","304a5a","1c3441")`；返回值紧邻使用处：`ExpressionStatementSyntax: ActionRow(strip,(contact.Group ? "GroupContact_" : "Contact_") + contact.Id,contact.Name,                  () => OpenPrivateMessages(contact.Group ? "" : contact.Id,contact.Group ? contact.Id : ""),row,90,14,10,"122432","304a5a","1c3441");`
- `NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`；输入表达式：`AgendaEntry(data,list,item)`；返回值紧邻使用处：`ExpressionStatementSyntax: AgendaEntry(data,list,item);`
- `NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`；输入表达式：`AvailablePlans(data)`；返回值紧邻使用处：`IfStatementSyntax: if (AvailablePlans(data)) Dot(calendarAction);`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data,contact.Id,56,false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Avatar(data,contact.Id,56,false)`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("",()=>OpenPerson(person))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CaptionButton("",()=>OpenPerson(person))`
- `NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData, Godot.Container)`；输入表达式：`CeremonyInvitation(data,due)`；返回值紧邻使用处：`ExpressionStatementSyntax: CeremonyInvitation(data,due);`
- `NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`；输入表达式：`ClubInvitation(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubInvitation(data);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("下一项安排"+(next==null?"":" · "+(day==data.Day?"今天":GameCalendar.Date(data,day).ToString("M/d"))),15,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("下一项安排"+(next==null?"":" · "+(day==data.Day?"今天":GameCalendar.Date(data,day).ToString("M/d"))),15,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("一二三四五六日"[i].ToString(),11,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("一二三四五六日"[i].ToString(),11,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel((relation?.Relationship ?? "初识") + " · 好感 " + contact.Favour,14,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel((relation?.Relationship ?? "初识") + " · 好感 " + contact.Favour,14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"{quote.Price:0.####}\n{change}", 14, tint)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel($"{quote.Price:0.####}\n{change}", 14, tint)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"群聊 · {group.Members.Distinct().Count()} 人",14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel($"群聊 · {group.Members.Distinct().Count()} 人",14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(asset.Name, 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(asset.Name, 16, _ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(contact.Name,19,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(contact.Name,19,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(delta.ToString("+0;-0;0"),14,delta>0?CareerVisuals.Teal:new Color("ef9295"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(delta.ToString("+0;-0;0"),14,delta>0?CareerVisuals.Teal:new Color("ef9295"))`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(displayName,18,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(displayName,18,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(GameCalendar.Date(data,n).Day.ToString(),16,n==data.Day?_gold:_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(GameCalendar.Date(data,n).Day.ToString(),16,n==data.Day?_gold:_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(next?.Match is {Event.Length:>0} scheduled ? scheduled.Event : next?.Title??"暂无待处理的安排",38,_ink,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(next?.Match is {Event.Length:>0} scheduled ? scheduled.Event : next?.Title??"暂无待处理的安排",38,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(next.Match is { } m ? $"已报名    进阶 {m.RequiredAscension}" :                  next.Visit!=null ? "已确认" : next.Detail,16,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(next.Match is { } m ? $"已报名    进阶 {m.RequiredAscension}" :                  next.Visit!=null ? "已确认" : next.Detail,16,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(next.Match!=null?"比赛":next.Visit!=null?"约会":"际遇",14,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(next.Match!=null?"比赛":next.Visit!=null?"约会":"际遇",14,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(post.Category+" · "+post.Replies.Count+" 条回复",13,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(post.Category+" · "+post.Replies.Count+" 条回复",13,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(post.Title,16,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(post.Title,16,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(role,13,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(role,13,_muted)`
- `NationalSpire.CareerScreen.Dot(Godot.Control)`；输入表达式：`Dot(calendarAction)`；返回值紧邻使用处：`ExpressionStatementSyntax: Dot(calendarAction);`
- `NationalSpire.CareerScreen.EnsureChatPreferencesLoaded()`；输入表达式：`EnsureChatPreferencesLoaded()`；返回值紧邻使用处：`ExpressionStatementSyntax: EnsureChatPreferencesLoaded();`
- `NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`；输入表达式：`EventCards(data,eventColumn,data.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventCards(data,eventColumn,data.Day);`
- `NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int)`；输入表达式：`FlatPanel(main,"HomeNext",286,"172b3b",24)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FlatPanel(main,"HomeNext",286,"172b3b",24)`
- `NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int)`；输入表达式：`FlatPanel(side,"HomeWeek",0,"11222e",20)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FlatPanel(side,"HomeWeek",0,"11222e",20)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("查看赛程", () => OpenMatchFixture(data, nextMatch), width: 112, height: 46, quiet: true)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("查看赛程", () => OpenMatchFixture(data, nextMatch), width: 112, height: 46, quiet: true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("日程安排",()=>OpenCalendarDay(day),width:112,height:46,quiet:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FramedAction("日程安排",()=>OpenCalendarDay(day),width:112,height:46,quiet:true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction(label,open,icon,height:50,quiet:true,iconColor:_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FramedAction(label,open,icon,height:50,quiet:true,iconColor:_gold)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("arrow-right",16,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Glyph("arrow-right",16,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("chevron-right",14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("chevron-right",14,_muted)`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("排行榜")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("排行榜")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("日程")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GoHub("日程")`
- `NationalSpire.CareerScreen.GoHub(string)`；输入表达式：`GoHub("赛事")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>GoHub("赛事")`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline()`；返回值紧邻使用处：`ArgumentSyntax: Hairline()`
- `NationalSpire.CareerScreen.HomeButtonPair(string)`；输入表达式：`HomeButtonPair("HomeUtilities")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HomeButtonPair("HomeUtilities")`
- `NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`HomeIdentity(data,side)`；返回值紧邻使用处：`ExpressionStatementSyntax: HomeIdentity(data,side);`
- `NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action)`；输入表达式：`HomeInvitation(market,"还没有持仓或关注的资产。","去市场关注或投资",OpenMarket)`；返回值紧邻使用处：`ExpressionStatementSyntax: HomeInvitation(market,"还没有持仓或关注的资产。","去市场关注或投资",OpenMarket);`
- `NationalSpire.CareerScreen.HomeInvitation(Godot.Container, string, string, System.Action)`；输入表达式：`HomeInvitation(strip,"还没有最近联系人。","找熟悉的人聊聊",ChoosePrivateContact)`；返回值紧邻使用处：`ExpressionStatementSyntax: HomeInvitation(strip,"还没有最近联系人。","找熟悉的人聊聊",ChoosePrivateContact);`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inset(0,0)`
- `NationalSpire.CareerScreen.JourneyResumeButton(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`JourneyResumeButton(data,words)`；返回值紧邻使用处：`ExpressionStatementSyntax: JourneyResumeButton(data,words);`
- `NationalSpire.CareerScreen.LoadContactPreferences()`；输入表达式：`LoadContactPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadContactPreferences();`
- `NationalSpire.CareerScreen.OpenAgendaItem(NationalSpire.CareerData, NationalSpire.CareerScreen.AgendaItem)`；输入表达式：`OpenAgendaItem(data,item)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenAgendaItem(data,item);`
- `NationalSpire.CareerScreen.OpenCalendarDay(int)`；输入表达式：`OpenCalendarDay(day)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenCalendarDay(day)`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("公开消息")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenLifePage("公开消息")`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("交易市场")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenLifePage("交易市场");`
- `NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`OpenMatchFixture(data, nextMatch)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenMatchFixture(data, nextMatch)`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(person)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPerson(person)`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPost(post)`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPrivateMessages()`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(contact.Group ? "" : contact.Id,contact.Group ? contact.Id : "")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPrivateMessages(contact.Group ? "" : contact.Id,contact.Group ? contact.Id : "")`
- `NationalSpire.CareerScreen.OpenProfileList(string?)`；输入表达式：`OpenProfileList()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenProfileList()`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("最近更新",24,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("最近更新",24,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(GameCalendar.Date(data, start).ToString("M/d") + " – " + GameCalendar.Date(data, start + 6).ToString("M/d"), 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(GameCalendar.Date(data, start).ToString("M/d") + " – " + GameCalendar.Date(data, start + 6).ToString("M/d"), 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(single?"当日暂无安排":"本周暂无后续安排",15,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(single?"当日暂无安排":"本周暂无后续安排",15,_muted)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("本周日程", () => GoHub("日程"),20)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TextLink("本周日程", () => GoHub("日程"),20)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("公开消息",()=>OpenLifePage("公开消息"))`；返回值紧邻使用处：`ArgumentSyntax: TextLink("公开消息",()=>OpenLifePage("公开消息"))`
- `NationalSpire.CareerScreen.TravelTo(int)`；输入表达式：`TravelTo(day)`；返回值紧邻使用处：`ExpressionStatementSyntax: TravelTo(day);`
- `NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`；输入表达式：`Upcoming(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Upcoming(data).ToList`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172b3b","406577",8,24)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box("172b3b","406577",8,24)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172e39","466473",3,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box("172e39","466473",3,0)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText(tracking:2)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.InterfaceText(tracking:2)`
- `NationalSpire.ChatContacts.Recent(NationalSpire.CareerData, System.Collections.Generic.HashSet<string>)`；输入表达式：`ChatContacts.Recent(data, _contactPreferences.Hidden)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatContacts.Recent(data, _contactPreferences.Hidden).Take`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data, data.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data, data.Day).DayOfWeek`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data, start + 6)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data, start + 6).ToString`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data, start)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data, start).ToString`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data,day).ToString`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,n)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data,n).Day`
- `NationalSpire.GroupAvatar.GroupAvatar()`；输入表达式：`new GroupAvatar { CustomMinimumSize = new(56,56), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupAvatar { CustomMinimumSize = new(56,56), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`；输入表达式：`mosaic.Update(data,group)`；返回值紧邻使用处：`ExpressionStatementSyntax: mosaic.Update(data,group);`
- `NationalSpire.MarketTerminal.ShowAsset(string)`；输入表达式：`_listCache!.Market.ShowAsset(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _listCache!.Market.ShowAsset(id);`
- `NationalSpire.MarketTerminal.WatchedAssets(NationalSpire.CareerData)`；输入表达式：`MarketTerminal.WatchedAssets(data)`；返回值紧邻使用处：`ArgumentSyntax: MarketTerminal.WatchedAssets(data)`
- `NationalSpire.PrivateInteractionHistory.LatestFavourChange(NationalSpire.PrivateConversation, NationalSpire.PrivateRelation?)`；输入表达式：`PrivateInteractionHistory.LatestFavourChange(mailbox.Conversations[contact.Id],relation)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateInteractionHistory.LatestFavourChange(mailbox.Conversations[contact.Id],relation) is int delta`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data)`
- `NationalSpire.SeasonCeremony.ShowInvitation(NationalSpire.CareerData)`；输入表达式：`SeasonCeremony.ShowInvitation(data)`；返回值紧邻使用处：`IfStatementSyntax: if(SeasonCeremony.ShowInvitation(data)) CeremonyInvitation(data,due);`
- `Primary(string, System.Action)`；输入表达式：`Primary("查看进行中的比赛",()=>GoHub("赛事"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Primary("查看进行中的比赛",()=>GoHub("赛事"));`
- `Primary(string, System.Action)`；输入表达式：`Primary("选择参赛赛事",()=>GoHub("赛事"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Primary("选择参赛赛事",()=>GoHub("赛事"));`
- `Primary(string, System.Action)`；输入表达式：`Primary(title,()=>{if(day==data.Day) OpenAgendaItem(data,item); else TravelTo(day);})`；返回值紧邻使用处：`ExpressionStatementSyntax: Primary(title,()=>{if(day==data.Day) OpenAgendaItem(data,item); else TravelTo(day);});`
- `Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`；输入表达式：`Section(main,"HomeContacts","最近联系","私信",()=>OpenPrivateMessages())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Section(main,"HomeContacts","最近联系","私信",()=>OpenPrivateMessages())`
- `Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`；输入表达式：`Section(updates,"HomeMarkets","投资与关注","交易市场",OpenMarket)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Section(updates,"HomeMarkets","投资与关注","交易市场",OpenMarket)`
- `Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`；输入表达式：`Section(updates,"HomeNews","社区动态","全部",OpenCommunity,              header=>header.AddChild(TextLink("公开消息",()=>OpenLifePage("公开消息"))))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Section(updates,"HomeNews","社区动态","全部",OpenCommunity,              header=>header.AddChild(TextLink("公开消息",()=>OpenLifePage("公开消息"))))`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(next?.Person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrEmpty(next?.Person) ? "player" : next.Person`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`data.Market.Quotes.ContainsKey(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)`
- `System.Collections.Generic.IEnumerable<decimal>.Max()`；输入表达式：`history.Max()`；返回值紧邻使用处：`BinaryExpressionSyntax: history.Max() - low`
- `System.Collections.Generic.IEnumerable<decimal>.Min()`；输入表达式：`history.Min()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = history.Min()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`group.Members.Distinct().Count()`；返回值紧邻使用处：`InterpolationSyntax: {group.Members.Distinct().Count()}`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`group.Members.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Members.Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`agendaItems.Where(i=>i.Day==day && (i.Match!=null || i.Visit!=null)).DistinctBy(i=>i.Match!=null)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var item in agendaItems.Where(i=>i.Day==day && (i.Match!=null || i.Visit!=null)).DistinctBy(i=>i.Match!=null))              {                  var title=item.Match!=null ? day==data.Day?"进入赛场":"前往比赛日" : day==data.Day?"查看今日约定":"前往活动日";                  Primary(title,()=>{if(day==data.Day) OpenAgendaItem(data,item); else TravelTo(day);});              }`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Chats.Groups.First(g => g.Id == contact.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Chats.Groups.First(g => g.Id == contact.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`agendaItems.FirstOrDefault(item => item.Match != null || item.Visit != null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =agendaItems.FirstOrDefault(item => item.Match != null || item.Visit != null)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`history.Select((price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.Select((price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Life.Trading.Positions.Select(p=>p.Asset)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Select(p=>p.Asset).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`quote.History.TakeLast(24).Select(p => p.Price)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: quote.History.TakeLast(24).Select(p => p.Price).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`ChatContacts.Recent(data, _contactPreferences.Hidden).Take(3)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var contact in ChatContacts.Recent(data, _contactPreferences.Hidden).Take(3))          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation",12);              var copy = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore };              copy.AddThemeConstantOverride("separation",4);              var name = DashboardLabel(contact.Name,19,_ink); name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;              copy.AddChild(name);              if (contact.Group)              {                  var group = data.Chats.Groups.First(g => g.Id == contact.Id);                  var mosaic = new GroupAvatar { CustomMinimumSize = new(56,56), SizeFlagsVertical = SizeFlags.ShrinkCenter };                  row.AddChild(mosaic); mosaic.Update(data,group);                  copy.AddChild(DashboardLabel($"群聊 · {group.Members.Distinct().Count()} 人",14,_muted));              }              else              {                  var avatar = Avatar(data,contact.Id,56,false); avatar.SizeFlagsVertical = SizeFlags.ShrinkCenter; row.AddChild(avatar);                  var relation = mailbox.Relations.GetValueOrDefault(contact.Id);                  var stats = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; stats.AddThemeConstantOverride("separation",6); copy.AddChild(stats);                  var status = DashboardLabel((relation?.Relationship ?? "初识") + " · 好感 " + contact.Favour,14,_muted);                  status.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; stats.AddChild(status);                  if (PrivateInteractionHistory.LatestFavourChange(mailbox.Conversations[contact.Id],relation) is int delta && delta != 0)                  {                      var change = DashboardLabel(delta.ToString("+0;-0;0"),14,delta>0?CareerVisuals.Teal:new Color("ef9295"));                      change.TooltipText="最近一次好感变动"; stats.AddChild(change);                  }              }              row.AddChild(copy);              ActionRow(strip,(contact.Group ? "GroupContact_" : "Contact_") + contact.Id,contact.Name,                  () => OpenPrivateMessages(contact.Group ? "" : contact.Id,contact.Group ? contact.Id : ""),row,90,14,10,"122432","304a5a","1c3441");          }`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)).Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)).Take(3).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Posts.Take(3)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in data.Posts.Take(3))          {              var line=new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}; line.AddThemeConstantOverride("separation",8);              var copy=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore};              copy.AddThemeConstantOverride("separation",2); line.AddChild(copy);              var postTitle = DashboardLabel(post.Title,16,_ink);              postTitle.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;              copy.AddChild(postTitle);              copy.AddChild(DashboardLabel(post.Category+" · "+post.Replies.Count+" 条回复",13,_muted));              line.AddChild(Glyph("chevron-right",14,_muted));              var open=ActionRow(news,"HomeNewsItem",post.Title,()=>OpenPost(post),line,updateRowHeight,0,5,"00000000","00000000","172c38");              open.TooltipText=post.Title;              news.AddChild(Hairline());          }`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`quote.History.TakeLast(24)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: quote.History.TakeLast(24).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)).Take(3).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)).Take(3).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`history.Select((price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = history.Select((price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`quote.History.TakeLast(24).Select(p => p.Price).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = quote.History.TakeLast(24).Select(p => p.Price).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`agendaItems.Where(x=>single?x.Day==_weekDay:x.Day<start+7).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =agendaItems.Where(x=>single?x.Day==_weekDay:x.Day<start+7).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Upcoming(data).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Upcoming(data).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`agendaItems.Where(i=>i.Day==day && (i.Match!=null || i.Visit!=null))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: agendaItems.Where(i=>i.Day==day && (i.Match!=null || i.Visit!=null)).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`agendaItems.Where(x=>single?x.Day==_weekDay:x.Day<start+7)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: agendaItems.Where(x=>single?x.Day==_weekDay:x.Day<start+7).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()              .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)).Take`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`MarketCatalog.ById.ContainsKey(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`mailbox.Relations.GetValueOrDefault(contact.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = mailbox.Relations.GetValueOrDefault(contact.Id)`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(data, start + 6).ToString("M/d")`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Date(data, start).ToString("M/d") + " – " + GameCalendar.Date(data, start + 6).ToString("M/d")`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(data, start).ToString("M/d")`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Date(data, start).ToString("M/d") + " – "`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(data,day).ToString("M/d")`；返回值紧邻使用处：`ConditionalExpressionSyntax: day==data.Day?"今天":GameCalendar.Date(data,day).ToString("M/d")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,start)`；返回值紧邻使用处：`BinaryExpressionSyntax: _weekDay>=Math.Max(1,start)`

**赋值（含属性/字段和局部值）：**

- `_arenaCharacter` = `null`
- `_weekDay` = `n`
- `((Control)week.GetParent()).SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `Art` = `AvatarAssets.Load(CareerAvatars.MainCharacter(data,person),person=="player"?CareerAvatars.HomeCardVariation(data):0,true)`
- `avatar.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `b.Disabled` = `n<1`
- `b.Draw` += `()=>b.DrawLine(new(2,b.Size.Y-2),new(b.Size.X-2,b.Size.Y-2),CareerVisuals.Teal,2)`
- `border.ContentMarginLeft` = `border.ContentMarginRight=7`
- `border.ContentMarginRight` = `7`
- `change.TooltipText` = `"最近一次好感变动"`
- `CustomMinimumSize` = `new(0,16)`
- `CustomMinimumSize` = `new(276,0)`
- `CustomMinimumSize` = `new(490,0)`
- `CustomMinimumSize` = `new(56,56)`
- `CustomMinimumSize` = `new(90, 26)`
- `CustomMinimumSize` = `new(HomeSideWidth,0)`
- `figures.CustomMinimumSize` = `new(96, 0)`
- `figures.HorizontalAlignment` = `HorizontalAlignment.Right`
- `figures.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `figures.VerticalAlignment` = `VerticalAlignment.Center`
- `gap.SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `grid.CustomMinimumSize` = `new(0,833)`
- `headline.Name` = `"NextTitle"`
- `heroPanel.Draw` += `()=>{              float x=heroPanel.Size.X, y=heroPanel.Size.Y;              heroPanel.DrawColoredPolygon([new(x-251,1),new(x-2,1),new(x-2,y-2),new(x-350,y-2)],new Color("24495822"));              heroPanel.DrawRect(new(31,1,72,3),CareerVisuals.Lime);          }`
- `heroStyle.ContentMarginLeft` = `31`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `line.TooltipText` = `$"{asset.Name}   {quote.Price:0.####}   {change}"`
- `link.CustomMinimumSize` = `new(0,50)`
- `link.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `name.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `Name` = `"HomeToday"`
- `news.SizeFlagsStretchRatio` = `1.08f`
- `number.HorizontalAlignment` = `HorizontalAlignment.Center`
- `open.TooltipText` = `post.Title`
- `openWeek.Alignment` = `HorizontalAlignment.Left`
- `openWeek.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `portrait.CustomMinimumSize` = `new(276,192)`
- `posterArrow.PivotOffset` = `new(8,8)`
- `posterArrow.Rotation` = `-Mathf.Pi/4`
- `postTitle.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `recent.CustomMinimumSize` = `new(0,204)`
- `roleText.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `status.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `title.VerticalAlignment` = `VerticalAlignment.Center`
- `trend.Draw` += `() =>              {                  if (history.Length < 2) return;                  decimal low = history.Min(), range = history.Max() - low;                  var points = history.Select((price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),                      range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))).ToArray();                  trend.DrawPolyline(points, tint, 1.5f, true);              }`
- `updates.SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `weekday.HorizontalAlignment` = `HorizontalAlignment.Center`
- `weekRange.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `weekRange.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`

<a id="symbol-1038401c1d6f"></a>

## `Primary(string, System.Action) — void Primary(string title, Action open)`

来源：源码第 398 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(enter)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(enter);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(enter,"2b4b51","7b9487","385d61","eed39b",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(enter,"2b4b51","7b9487","385d61","eed39b",6);`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction(title,open,"arrow-right",trailing:true,width:180,height:51,ink:_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FramedAction(title,open,"arrow-right",trailing:true,width:180,height:51,ink:_gold)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fed969ea23f7"></a>

## `Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?) — VBoxContainer Section(Container parent,string key,string title,string shortcut,Action open,Action<HBoxContainer>? extras=null)`

来源：源码第 474 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_top",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_top",16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Hairline("45616d99"))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Hairline("45616d99"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text(title,21,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text(title,21,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(TextLink(shortcut,open,16,icon:"arrow-up-right"))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(TextLink(shortcut,open,16,icon:"arrow-up-right"));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Name=key,SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {Name=key,SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline("45616d99")`；返回值紧邻使用处：`ArgumentSyntax: Hairline("45616d99")`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title,21,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(title,21,_ink)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink(shortcut,open,16,icon:"arrow-up-right")`；返回值紧邻使用处：`ArgumentSyntax: TextLink(shortcut,open,16,icon:"arrow-up-right")`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(row)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: extras?.Invoke(row)`

**赋值（含属性/字段和局部值）：**

- `Name` = `key`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-b56f5758541f"></a>

## `OpenMarket() — void OpenMarket()`

来源：源码第 501 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenLifePage(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("交易市场")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => OpenLifePage("交易市场")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c9c29fc0844"></a>

## `NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string) — private void Metric(HBoxContainer row, string caption, string value, string detail)`

来源：源码第 582 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)

**调用：** [`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(caption, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(caption, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(detail, 13, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(detail, 13, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(value, 38, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(value, 38, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(card);`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(caption, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(caption, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(detail, 13, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(detail, 13, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value, 38, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(value, 38, _ink)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ce008839cea8"></a>

## `NationalSpire.CareerScreen.ShowArchive() — private void ShowArchive()`

来源：源码第 588 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-5c9c29fc0844)；[`NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`](ProfileScreen.cs.md#symbol-69bc6ca2a621)；[`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-578cf06bda89)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithCharacterAvatar(string, Godot.Control)`](CareerAvatars.cs.md#symbol-eadfa70c0822)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；[`NationalSpire.PlayerArchive.Read(bool)`](PlayerArchive.cs.md#symbol-153514d4aa72)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`int.ToString()`；`long.ToString()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.DateTimeOffset.FromUnixTimeSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveCharacter.CharacterId`；`NationalSpire.ArchiveCharacter.Losses`；`NationalSpire.ArchiveCharacter.Name`；`NationalSpire.ArchiveCharacter.Playtime`；`NationalSpire.ArchiveCharacter.Streak`；`NationalSpire.ArchiveCharacter.UnlockedAscension`；`NationalSpire.ArchiveCharacter.Wins`；`NationalSpire.ArchiveSnapshot.Cards`；`NationalSpire.ArchiveSnapshot.Characters`；`NationalSpire.ArchiveSnapshot.Floors`；`NationalSpire.ArchiveSnapshot.Losses`；`NationalSpire.ArchiveSnapshot.Playtime`；`NationalSpire.ArchiveSnapshot.Recent`；`NationalSpire.ArchiveSnapshot.Relics`；`NationalSpire.ArchiveSnapshot.Streak`；`NationalSpire.ArchiveSnapshot.WinRate`；`NationalSpire.ArchiveSnapshot.Wins`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`；`NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`；`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；`NationalSpire.CareerScreen.ProfileSection(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WithCharacterAvatar(string, Godot.Control)`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；`NationalSpire.PlayerArchive.Read(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`metrics.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(metrics)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(metrics);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("游戏总档案 · 含生涯外对局", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("游戏总档案 · 含生涯外对局", 24, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{DateTimeOffset.FromUnixTimeSeconds(r.StartTime).LocalDateTime:yyyy.MM.dd HH:mm}    ·    {r.MapPointHistory.Sum(x => x.Count)} 层    ·    {MatchRules.Time(r.RunTime)}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{DateTimeOffset.FromUnixTimeSeconds(r.StartTime).LocalDateTime:yyyy.MM.dd HH:mm}    ·    {r.MapPointHistory.Sum(x => x.Count)} 层    ·    {MatchRules.Time(r.RunTime)}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(WithCharacterAvatar(c.CharacterId.Length > 0 ? c.CharacterId : c.Name, Text(c.Name, 23, _gold)))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(WithCharacterAvatar(c.CharacterId.Length > 0 ? c.CharacterId : c.Name, Text(c.Name, 23, _gold)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`characters.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: characters.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`recent.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`recent.AddChild(Text("暂无游戏对局", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.AddChild(Text("暂无游戏对局", 17, _muted));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `int.ToString()`；输入表达式：`a.Wins.ToString()`；返回值紧邻使用处：`ArgumentSyntax: a.Wins.ToString()`
- `long.ToString()`；输入表达式：`a.Streak.ToString()`；返回值紧邻使用处：`ArgumentSyntax: a.Streak.ToString()`
- `NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`；输入表达式：`Metric(metrics, "游玩时长", $"{a.Playtime / 3600.0:0.#} h", $"发现 {a.Cards} 张卡牌 · {a.Relics} 件遗物")`；返回值紧邻使用处：`ExpressionStatementSyntax: Metric(metrics, "游玩时长", $"{a.Playtime / 3600.0:0.#} h", $"发现 {a.Cards} 张卡牌 · {a.Relics} 件遗物");`
- `NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`；输入表达式：`Metric(metrics, "游戏总通关", a.Wins.ToString(), $"总对局 {a.Wins + a.Losses} · 通关率 {a.WinRate}")`；返回值紧邻使用处：`ExpressionStatementSyntax: Metric(metrics, "游戏总通关", a.Wins.ToString(), $"总对局 {a.Wins + a.Losses} · 通关率 {a.WinRate}");`
- `NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`；输入表达式：`Metric(metrics, "最佳连胜", a.Streak.ToString(), $"累计攀登 {a.Floors} 层")`；返回值紧邻使用处：`ExpressionStatementSyntax: Metric(metrics, "最佳连胜", a.Streak.ToString(), $"累计攀登 {a.Floors} 层");`
- `NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`；输入表达式：`ProfileEntry(box, $"{name} · 进阶 {r.Ascension}", r.Win ? "通关" : r.WasAbandoned ? "放弃" : "挑战结束", r.Win ? _gold : _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileEntry(box, $"{name} · 进阶 {r.Ascension}", r.Win ? "通关" : r.WasAbandoned ? "放弃" : "挑战结束", r.Win ? _gold : _ink);`
- `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；输入表达式：`ProfileFields(box, ("游戏战绩", $"{c.Wins} 次通关 · {c.Losses} 次失败"), ("解锁进阶", $"进阶 {c.UnlockedAscension}"),                  ("最佳连胜", $"{c.Streak} 场"), ("游玩时长", $"{c.Playtime / 3600.0:0.#} 小时"))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileFields(box, ("游戏战绩", $"{c.Wins} 次通关 · {c.Losses} 次失败"), ("解锁进阶", $"进阶 {c.UnlockedAscension}"),                  ("最佳连胜", $"{c.Streak} 场"), ("游玩时长", $"{c.Playtime / 3600.0:0.#} 小时"));`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("角色履历")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("角色履历")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("近期游戏对局")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("近期游戏对局")`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("游戏总档案 · 含生涯外对局", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("游戏总档案 · 含生涯外对局", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂无游戏对局", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂无游戏对局", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{DateTimeOffset.FromUnixTimeSeconds(r.StartTime).LocalDateTime:yyyy.MM.dd HH:mm}    ·    {r.MapPointHistory.Sum(x => x.Count)} 层    ·    {MatchRules.Time(r.RunTime)}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{DateTimeOffset.FromUnixTimeSeconds(r.StartTime).LocalDateTime:yyyy.MM.dd HH:mm}    ·    {r.MapPointHistory.Sum(x => x.Count)} 层    ·    {MatchRules.Time(r.RunTime)}", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(c.Name, 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(c.Name, 23, _gold)`
- `NationalSpire.CareerScreen.WithCharacterAvatar(string, Godot.Control)`；输入表达式：`WithCharacterAvatar(c.CharacterId.Length > 0 ? c.CharacterId : c.Name, Text(c.Name, 23, _gold))`；返回值紧邻使用处：`ArgumentSyntax: WithCharacterAvatar(c.CharacterId.Length > 0 ? c.CharacterId : c.Name, Text(c.Name, 23, _gold))`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(r.RunTime)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Time(r.RunTime)}`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(p.Character)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PlayerArchive.CharacterName(p.Character)`
- `NationalSpire.PlayerArchive.Read(bool)`；输入表达式：`PlayerArchive.Read()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerArchive.Read()`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" / ", r.Players.Select(p => PlayerArchive.CharacterName(p.Character)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join(" / ", r.Players.Select(p => PlayerArchive.CharacterName(p.Character)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`r.Players.Select(p => PlayerArchive.CharacterName(p.Character))`；返回值紧邻使用处：`ArgumentSyntax: r.Players.Select(p => PlayerArchive.CharacterName(p.Character))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`r.MapPointHistory.Sum(x => x.Count)`；返回值紧邻使用处：`InterpolationSyntax: {r.MapPointHistory.Sum(x => x.Count)}`
- `System.DateTimeOffset.FromUnixTimeSeconds(long)`；输入表达式：`DateTimeOffset.FromUnixTimeSeconds(r.StartTime)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateTimeOffset.FromUnixTimeSeconds(r.StartTime).LocalDateTime`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a96caa224878"></a>

## `NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData) — private void Calendar(CareerData data)`

来源：源码第 617 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`Blank()`](CareerScreen.cs.md#symbol-454826c2504f)；[`MonthArrow(bool, int)`](CareerScreen.cs.md#symbol-950248099d2c)；[`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`](CalendarMonth.cs.md#symbol-9c0d6943fe74)；[`NationalSpire.CalendarMonth.Owner(System.DateOnly)`](CalendarMonth.cs.md#symbol-94d3db2afd40)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)；[`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`](CalendarPlansScreen.cs.md#symbol-9c53a348d954)；[`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-1eb97a843d59)；[`NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`](CalendarPlansScreen.cs.md#symbol-0019411c0ad4)；[`NationalSpire.CareerScreen.CalendarEncounters(NationalSpire.CareerData, Godot.VBoxContainer, int, System.Collections.Generic.IEnumerable<NationalSpire.RandomEventRecord>)`](RandomEventScreen.cs.md#symbol-e447383e7699)；[`NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-2a8cdab11ad9)；[`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.ClearPlan()`](CareerDashboard.cs.md#symbol-26b8e8ad029b)；[`NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`](CalendarPlansScreen.cs.md#symbol-217e72b481b2)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-6b6d63fc08b3)；[`NationalSpire.CareerScreen.Dot(Godot.Control)`](CareerDashboard.cs.md#symbol-15e9bc391bf6)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-06ff02fddd30)；[`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-a9a3a3c86347)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`](FixtureScheduleScreen.cs.md#symbol-b6e54268cac8)；[`NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`](FixtureScheduleScreen.cs.md#symbol-b367c62d489f)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerScreen.TravelTo(int)`](CalendarPlansScreen.cs.md#symbol-898d70175a58)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer)`](CalendarPlansScreen.cs.md#symbol-33f94161db0f)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`](GameCalendar.cs.md#symbol-c755526e8036)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-d6b37bf58f98)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；[`NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-56b98eeeac09)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetChildren(bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`NationalSpire.CalendarDayButton.CalendarDayButton()`；`NationalSpire.PrivateRelation.PrivateRelation()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.DateOnly.AddDays(int)`；`System.DateOnly.AddMonths(int)`；`System.DateOnly.ToString(string?, System.IFormatProvider?)`；`System.DateOnly.ToString(string?)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Globalization.CultureInfo.GetCultureInfo(string)`；`System.Linq.ILookup<TKey, TElement>.Contains(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Conversation`；`(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Offer`；`(NationalSpire.WorldCompetition Competition, NationalSpire.WorldFixture Fixture).Competition`；`(NationalSpire.WorldCompetition Competition, NationalSpire.WorldFixture Fixture).Fixture`；`(string Icon, string Title).Icon`；`Blank()`；`MonthArrow(bool, int)`；`NationalSpire.CalendarDayButton.Bond`；`NationalSpire.CalendarDayButton.CalendarHeight`；`NationalSpire.CalendarDayButton.CalendarLayout`；`NationalSpire.CalendarDayButton.Day`；`NationalSpire.CalendarDayButton.Description`；`NationalSpire.CalendarDayButton.HasMatch`；`NationalSpire.CalendarDayButton.Markers`；`NationalSpire.CalendarDayButton.Number`；`NationalSpire.CalendarDayButton.PlanWindow`；`NationalSpire.CalendarDayButton.Preview`；`NationalSpire.CalendarDayButton.Question`；`NationalSpire.CalendarDayButton.Registered`；`NationalSpire.CalendarDayButton.SecondLine`；`NationalSpire.CalendarDayButton.Selected`；`NationalSpire.CalendarDayButton.Today`；`NationalSpire.CalendarDayButton.Wedding`；`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`；`NationalSpire.CalendarMonth.Owner(System.DateOnly)`；`NationalSpire.CalendarMonth.Slots`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerScreen._arenaMatchId`；`NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._calendarMonth`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._planKey`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._showCalendarPlans`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；`NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`；`NationalSpire.CareerScreen.CalendarEncounters(NationalSpire.CareerData, Godot.VBoxContainer, int, System.Collections.Generic.IEnumerable<NationalSpire.RandomEventRecord>)`；`NationalSpire.CareerScreen.CalendarPeriod.FinishDay`；`NationalSpire.CareerScreen.CalendarPeriod.StartedDay`；`NationalSpire.CareerScreen.CalendarPeriod.Status`；`NationalSpire.CareerScreen.CalendarPeriod.Title`；`NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.CalendarPlan.Covers`；`NationalSpire.CareerScreen.CalendarPlan.Key`；`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`；`NationalSpire.CareerScreen.Dot(Godot.Control)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerScreen.TravelTo(int)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.LifeActivity.ExpiresDay`；`NationalSpire.LifeActivity.OfferedDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Title`；`NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`；`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；`NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayParticipants`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeParticipants`；`NationalSpire.WorldFixture.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Blank()`；输入表达式：`Blank()`；返回值紧邻使用处：`ExpressionStatementSyntax: Blank();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("8591a0")`；返回值紧邻使用处：`ConditionalExpressionSyntax: day < data.Day ? new Color("8591a0") : Colors.White`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`monthName.AddThemeColorOverride("font_color",_gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: monthName.AddThemeColorOverride("font_color",_gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`commands.AddThemeConstantOverride("separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: commands.AddThemeConstantOverride("separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_"+edge,19)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_"+edge,19);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`left.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`links.AddThemeConstantOverride("separation",14)`；返回值紧邻使用处：`ExpressionStatementSyntax: links.AddThemeConstantOverride("separation",14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`months.AddThemeConstantOverride("separation",24)`；返回值紧邻使用处：`ExpressionStatementSyntax: months.AddThemeConstantOverride("separation",24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`right.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: right.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`monthName.AddThemeFontSizeOverride("font_size",25)`；返回值紧邻使用处：`ExpressionStatementSyntax: monthName.AddThemeFontSizeOverride("font_size",25);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`side.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101e2b","324c5c",6,1))`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101e2b","324c5c",6,1));`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 7, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 7, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(DashboardLabel("当日暂无安排",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(DashboardLabel("当日暂无安排",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(DashboardLabel("接下来的安排",20,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(DashboardLabel("接下来的安排",20,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(DashboardLabel(GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN")),20,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(DashboardLabel(GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN")),20,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(jump)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(jump);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(left)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(left);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(side)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(side);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(DashboardLabel(reason,14,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(DashboardLabel(reason,14,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(links)`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(links);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(registration)`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(registration);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(TextLink("查看赛程",()=>OpenFixtureFor(data,shown,group.Key),icon:"arrow-right"))`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(TextLink("查看赛程",()=>OpenFixtureFor(data,shown,group.Key),icon:"arrow-right"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(TextLink("查看私信 ↗",()=>{ if(activity.GroupId.Length>0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(TextLink("查看私信 ↗",()=>{ if(activity.GroupId.Length>0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(weekday)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(weekday);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`innerScroll.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: innerScroll.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(commands)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(commands);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`links.AddChild(TextLink("查看赛程",()=>OpenMatchFixture(data,match),icon:"arrow-right"))`；返回值紧邻使用处：`ExpressionStatementSyntax: links.AddChild(TextLink("查看赛程",()=>OpenMatchFixture(data,match),icon:"arrow-right"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`links.AddChild(TextLink("进入赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;}),icon:"arrow-right"))`；返回值紧邻使用处：`ExpressionStatementSyntax: links.AddChild(TextLink("进入赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;}),icon:"arrow-right"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`months.AddChild(monthName)`；返回值紧邻使用处：`ExpressionStatementSyntax: months.AddChild(monthName);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`right.AddChild(innerScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: right.AddChild(innerScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(tab);`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`box.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: box.GetChildCount()==initialCount`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`box.GetChildCount()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =box.GetChildCount()`
- `Godot.Node.GetChildren(bool)`；输入表达式：`grid.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: grid.GetChildren().OfType<CalendarDayButton>`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name="CalendarSidebar", CustomMinimumSize=new(376,840) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name="CalendarSidebar", CustomMinimumSize=new(376,840) }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "CalendarSideScroll", CustomMinimumSize = new(0, 555),              SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { Name = "CalendarSideScroll", CustomMinimumSize = new(0, 555),              SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "CalendarSideContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "CalendarSideContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 555)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 555)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,22)`；返回值紧邻使用处：`AssignmentExpressionSyntax: weekday.CustomMinimumSize = new(0,22)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,53)`；返回值紧邻使用处：`AssignmentExpressionSyntax: tabs.CustomMinimumSize=new(0,53)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,70)`；返回值紧邻使用处：`AssignmentExpressionSyntax: months.CustomMinimumSize = new(0,70)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(376,840)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(376,840)`
- `int.ToString()`；输入表达式：`date.Day.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: date.Month==month.Month ? date.Day.ToString() : date.ToString("M/d")`
- `MonthArrow(bool, int)`；输入表达式：`MonthArrow(month<CalendarMonth.Owner(GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84))),1)`；返回值紧邻使用处：`ExpressionStatementSyntax: MonthArrow(month<CalendarMonth.Owner(GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84))),1);`
- `MonthArrow(bool, int)`；输入表达式：`MonthArrow(month>CalendarMonth.Owner(GameCalendar.Date(data,1)),-1)`；返回值紧邻使用处：`ExpressionStatementSyntax: MonthArrow(month>CalendarMonth.Owner(GameCalendar.Date(data,1)),-1);`
- `NationalSpire.CalendarDayButton.CalendarDayButton()`；输入表达式：`new CalendarDayButton { Day=day, Markers=markers.DistinctBy(m=>m.Icon).ToList(), CalendarHeight=cellHeight, Name = "CalendarDay_" + day, Number = date.Month==month.Month ? date.Day.ToString() : date.ToString("M/d"), CalendarLayout = true,                  PlanWindow = _calendarMode == "计划" && offered.Any(a => day >= a.OfferedDay && day <= a.ExpiresDay),                  Preview = preview?.Covers(day) == true,                  Description=title, SecondLine=detail,                  Today = day == data.Day, Selected = _calendarMode == "当日" && day == shown, HasMatch = match != null || world != null, Registered = entered,                  Question = encounters.Contains(day),                  Bond = ordinaryDate.Conversation == null ? null : RelationshipPresentation.IconBond(PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new()),                  Wedding = appointments[day].Any(a => a.Offer.GoodId == "grand-wedding") }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CalendarDayButton { Day=day, Markers=markers.DistinctBy(m=>m.Icon).ToList(), CalendarHeight=cellHeight, Name = "CalendarDay_" + day, Number = date.Month==month.Month ? date.Day.ToString() : date.ToString("M/d"), CalendarLayout = true,                  PlanWindow = _calendarMode == "计划" && offered.Any(a => day >= a.OfferedDay && day <= a.ExpiresDay),                  Preview = preview?.Covers(day) == true,                  Description=title, SecondLine=detail,                  Today = day == data.Day, Selected = _calendarMode == "当日" && day == shown, HasMatch = match != null || world != null, Registered = entered,                  Question = encounters.Contains(day),                  Bond = ordinaryDate.Conversation == null ? null : RelationshipPresentation.IconBond(PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new()),                  Wedding = appointments[day].Any(a => a.Offer.GoodId == "grand-wedding") }`
- `NationalSpire.CalendarMonth.GridStart(System.DateOnly)`；输入表达式：`CalendarMonth.GridStart(month)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CalendarMonth.GridStart(month)`
- `NationalSpire.CalendarMonth.Owner(System.DateOnly)`；输入表达式：`CalendarMonth.Owner(date)`；返回值紧邻使用处：`BinaryExpressionSyntax: CalendarMonth.Owner(date)!=month`
- `NationalSpire.CalendarMonth.Owner(System.DateOnly)`；输入表达式：`CalendarMonth.Owner(GameCalendar.Date(data,1))`；返回值紧邻使用处：`BinaryExpressionSyntax: month>CalendarMonth.Owner(GameCalendar.Date(data,1))`
- `NationalSpire.CalendarMonth.Owner(System.DateOnly)`；输入表达式：`CalendarMonth.Owner(GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84)))`；返回值紧邻使用处：`BinaryExpressionSyntax: month<CalendarMonth.Owner(GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84)))`
- `NationalSpire.CalendarMonth.Owner(System.DateOnly)`；输入表达式：`CalendarMonth.Owner(today)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarMonth.Owner(today).AddMonths`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,appointment.Conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对象："+CareerEngine.DisplayName(data,appointment.Conversation.PersonId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对象："+CareerEngine.DisplayName(data,conversation.PersonId)`
- `NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；输入表达式：`CareerEngine.SetRegistration(data,match,!match.Registered)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.SetRegistration(data,match,!match.Registered)`
- `NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；输入表达式：`AgendaRange(data,plan.StartedDay,plan.FinishDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: plan.Status+" · "+AgendaRange(data,plan.StartedDay,plan.FinishDay)`
- `NationalSpire.CareerScreen.AvailablePlans(NationalSpire.CareerData)`；输入表达式：`AvailablePlans(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: mode == "计划" && AvailablePlans(data)`
- `NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`；输入表达式：`CalendarCommands(data, commands)`；返回值紧邻使用处：`ExpressionStatementSyntax: CalendarCommands(data, commands);`
- `NationalSpire.CareerScreen.CalendarEncounters(NationalSpire.CareerData, Godot.VBoxContainer, int, System.Collections.Generic.IEnumerable<NationalSpire.RandomEventRecord>)`；输入表达式：`CalendarEncounters(data,box,shown,encounters[shown])`；返回值紧邻使用处：`ExpressionStatementSyntax: CalendarEncounters(data,box,shown,encounters[shown]);`
- `NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData)`；输入表达式：`CalendarPeriods(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarPeriods(data).Where`
- `NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`；输入表达式：`CalendarPlans(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _calendarMode == "计划" ? CalendarPlans(data) : []`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton($"{month.Year}年{monthNames[month.Month - 1]}月",()=>{},true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CaptionButton($"{month.Year}年{monthNames[month.Month - 1]}月",()=>{},true)`
- `NationalSpire.CareerScreen.ClearPlan()`；输入表达式：`ClearPlan()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearPlan();`
- `NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`；输入表达式：`ClubPlan(a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubPlan(a)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("当日暂无安排",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("当日暂无安排",16,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("接下来的安排",20,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("接下来的安排",20,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN")),20,_ink)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN")),20,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(reason,14,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(reason,14,_muted,true)`
- `NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`；输入表达式：`DayEntry(box,"calendar-days",plan.Title,plan.Status+" · "+AgendaRange(data,plan.StartedDay,plan.FinishDay))`；返回值紧邻使用处：`ExpressionStatementSyntax: DayEntry(box,"calendar-days",plan.Title,plan.Status+" · "+AgendaRange(data,plan.StartedDay,plan.FinishDay));`
- `NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`；输入表达式：`DayEntry(box,"heart",activity.Title,"对象："+CareerEngine.DisplayName(data,conversation.PersonId)+" · "+SocialAppointments.StatusText(data,activity))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DayEntry(box,"heart",activity.Title,"对象："+CareerEngine.DisplayName(data,conversation.PersonId)+" · "+SocialAppointments.StatusText(data,activity))`
- `NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`；输入表达式：`DayEntry(box,"swords",group.Key.Name,$"世界赛场 · {group.Count(x=>x.Fixture.Finished)}/{group.Count()} 场已结束")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DayEntry(box,"swords",group.Key.Name,$"世界赛场 · {group.Count(x=>x.Fixture.Finished)}/{group.Count()} 场已结束")`
- `NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string)`；输入表达式：`DayEntry(box,"swords",MatchTitle(data,match),string.Join(" · ",new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DayEntry(box,"swords",MatchTitle(data,match),string.Join(" · ",new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0)))`
- `NationalSpire.CareerScreen.Dot(Godot.Control)`；输入表达式：`Dot(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: Dot(tab);`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("跳转到此日",()=>{                  TravelTo(shown);              },"arrow-right",trailing:true,height:43,quiet:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FramedAction("跳转到此日",()=>{                  TravelTo(shown);              },"arrow-right",trailing:true,height:43,quiet:true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(side)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(side)`
- `NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchDetail(data,match)`；返回值紧邻使用处：`ArgumentSyntax: MatchDetail(data,match)`
- `NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchDetail(data,match)`；返回值紧邻使用处：`InitializerExpressionSyntax: {MatchDetail(data,match),status}`
- `NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchTitle(data,match)`；返回值紧邻使用处：`ArgumentSyntax: MatchTitle(data,match)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-register",match.Id,number:match.Registered?0:1)`；返回值紧邻使用处：`IfStatementSyntax: if(MultiplayerCommand("propose-register",match.Id,number:match.Registered?0:1)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error,true);`
- `NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`；输入表达式：`OpenFixtureFor(data,shown,group.Key)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenFixtureFor(data,shown,group.Key)`
- `NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`OpenMatchFixture(data,match)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenMatchFixture(data,match)`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(conversation.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(conversation.PersonId);`
- `NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`；输入表达式：`PlanPane(data,box,innerScroll,plans,grid.GetChildren().OfType<CalendarDayButton>().ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: PlanPane(data,box,innerScroll,plans,grid.GetChildren().OfType<CalendarDayButton>().ToArray());`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(activity.GroupId)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(activity.GroupId);`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(left)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TabStrip(left)`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(right,18,true,secondary:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TabStrip(right,18,true,secondary:true)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("周"+label,14,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("周"+label,14,_muted)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("查看赛程",()=>OpenFixtureFor(data,shown,group.Key),icon:"arrow-right")`；返回值紧邻使用处：`ArgumentSyntax: TextLink("查看赛程",()=>OpenFixtureFor(data,shown,group.Key),icon:"arrow-right")`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("查看赛程",()=>OpenMatchFixture(data,match),icon:"arrow-right")`；返回值紧邻使用处：`ArgumentSyntax: TextLink("查看赛程",()=>OpenMatchFixture(data,match),icon:"arrow-right")`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("查看私信 ↗",()=>{ if(activity.GroupId.Length>0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); })`；返回值紧邻使用处：`ArgumentSyntax: TextLink("查看私信 ↗",()=>{ if(activity.GroupId.Length>0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); })`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("进入赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;}),icon:"arrow-right")`；返回值紧邻使用处：`ArgumentSyntax: TextLink("进入赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;}),icon:"arrow-right")`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink(match.Registered?"取消报名":"报名这场比赛",()=>{                      if(MultiplayerCommand("propose-register",match.Id,number:match.Registered?0:1)) return;                      var error=CareerEngine.SetRegistration(data,match,!match.Registered); Render(); if(error!=null) Notice(error,true);                  })`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TextLink(match.Registered?"取消报名":"报名这场比赛",()=>{                      if(MultiplayerCommand("propose-register",match.Id,number:match.Registered?0:1)) return;                      var error=CareerEngine.SetRegistration(data,match,!match.Registered); Render(); if(error!=null) Notice(error,true);                  })`
- `NationalSpire.CareerScreen.TravelTo(int)`；输入表达式：`TravelTo(shown)`；返回值紧邻使用处：`ExpressionStatementSyntax: TravelTo(shown);`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab(mode, () => { _calendarMode = mode; ClearPlan(); Render(); }, mode == "计划" ? _calendarMode == mode : _calendarMode != "计划",90)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UnderlineTab(mode, () => { _calendarMode = mode; ClearPlan(); Render(); }, mode == "计划" ? _calendarMode == mode : _calendarMode != "计划",90)`
- `NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`UpcomingDays(data, box)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpcomingDays(data, box);`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;})`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;})`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101e2b","324c5c",6,1)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("101e2b","324c5c",6,1)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(data,m)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(data,m) == null`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(data,match)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EsportsWorld.EntryReason(data,match)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data, data.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameCalendar.Date(data, data.Day)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,1)`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Date(data,1)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84))`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84))`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,shown)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data,shown).ToString`
- `NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`；输入表达式：`GameCalendar.Day(data,start)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GameCalendar.Day(data,start)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, x.Offer)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => PrivateAppointments.Date(data, x.Offer)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data,x.Offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data,x.Offer)==shown`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new()`
- `NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`；输入表达式：`RelationshipPresentation.IconBond(PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new())`；返回值紧邻使用处：`ConditionalExpressionSyntax: ordinaryDate.Conversation == null ? null : RelationshipPresentation.IconBond(PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new())`
- `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.End(data)`；返回值紧邻使用处：`ArgumentSyntax: SeasonCalendar.End(data)`
- `NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；输入表达式：`SocialAppointments.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SocialAppointments.All(data).Where`
- `NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`SocialAppointments.StatusText(data,activity)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对象："+CareerEngine.DisplayName(data,conversation.PersonId)+" · "+SocialAppointments.StatusText(data,activity)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0))`；返回值紧邻使用处：`ArgumentSyntax: string.Join(" · ",new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n",new[]{detail,encounter.Title}.Where(s=>s.Length>0))`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail=string.Join("\n",new[]{detail,encounter.Title}.Where(s=>s.Length>0))`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(f.HomeId) || humans.Contains(f.AwayId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`humans.Contains(f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(f.HomeId) || humans.Contains(f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`appointments[day].Any(a => a.Offer.GoodId == "grand-wedding")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Wedding = appointments[day].Any(a => a.Offer.GoodId == "grand-wedding")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`f.AwayParticipants.Any(humans.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`f.HomeParticipants.Any(humans.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`matchesByDay[day].Any(m => m.Registered)`；返回值紧邻使用处：`BinaryExpressionSyntax: matchesByDay[day].Any(m => m.Registered) || world != null`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`offered.Any(a => day >= a.OfferedDay && day <= a.ExpiresDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: _calendarMode == "计划" && offered.Any(a => day >= a.OfferedDay && day <= a.ExpiresDay)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`data.HumanIds.Append("player").Append(data.LocalHumanId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Append("player").Append(data.LocalHumanId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`data.HumanIds.Append("player")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Append("player").Append`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`group.Count()`；返回值紧邻使用处：`InterpolationSyntax: {group.Count()}`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Count(x=>x.Fixture.Finished)`；返回值紧邻使用处：`InterpolationSyntax: {group.Count(x=>x.Fixture.Finished)}`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`markers.DistinctBy(m=>m.Icon)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: markers.DistinctBy(m=>m.Icon).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`appointments[day].FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = appointments[day].FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`encounters[day].FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =encounters[day].FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`fixturesByDay[day].FirstOrDefault()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fixturesByDay[day].FirstOrDefault().Competition`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`matchesByDay[day].OrderByDescending(m => m.Registered).ThenByDescending(m => m.CompetitionId.Length > 0).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = matchesByDay[day].OrderByDescending(m => m.Registered).ThenByDescending(m => m.CompetitionId.Length > 0).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`appointments[day].FirstOrDefault(a => a.Offer.GoodId != "grand-wedding")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = appointments[day].FirstOrDefault(a => a.Offer.GoodId != "grand-wedding")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`monthPlans.FirstOrDefault(a=>a.StartedDay<=day && day<=a.FinishDay)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =monthPlans.FirstOrDefault(a=>a.StartedDay<=day && day<=a.FinishDay)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`plans.FirstOrDefault(p => p.Key == _planKey)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = plans.FirstOrDefault(p => p.Key == _planKey)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`fixturesByDay[shown].Where(x=>!matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id)).GroupBy(x=>x.Competition)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in fixturesByDay[shown].Where(x=>!matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id)).GroupBy(x=>x.Competition))          {              var entry=DayEntry(box,"swords",group.Key.Name,$"世界赛场 · {group.Count(x=>x.Fixture.Finished)}/{group.Count()} 场已结束");              entry.AddChild(TextLink("查看赛程",()=>OpenFixtureFor(data,shown,group.Key),icon:"arrow-right"));          }`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)              .OrderByDescending(a=>a.StartedDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)              .OrderByDescending(a=>a.StartedDay).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`matchesByDay[day].OrderByDescending(m => m.Registered)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matchesByDay[day].OrderByDescending(m => m.Registered).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select(f => (Competition:c,Fixture:f))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select(f => (Competition:c,Fixture:f))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select(f => (Competition:c,Fixture:f)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Competitions.SelectMany(c => c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select(f => (Competition:c,Fixture:f))).ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`grid.GetChildren().OfType<CalendarDayButton>().ToArray()`；返回值紧邻使用处：`ArgumentSyntax: grid.GetChildren().OfType<CalendarDayButton>().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`data.HumanIds.Append("player").Append(data.LocalHumanId).Where(id=>id.Length>0).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.HumanIds.Append("player").Append(data.LocalHumanId).Where(id=>id.Length>0).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)              .OrderByDescending(a=>a.StartedDay).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _showCalendarPlans ? CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)              .OrderByDescending(a=>a.StartedDay).ToList() : []`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= data.Day && (data.Esports.ClubId.Length > 0 || !ClubPlan(a))).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= data.Day && (data.Esports.ClubId.Length > 0 || !ClubPlan(a))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`markers.DistinctBy(m=>m.Icon).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Markers=markers.DistinctBy(m=>m.Icon).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select(f => (Competition:c,Fixture:f))).ToLookup(x=>x.Fixture.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Esports.Competitions.SelectMany(c => c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select(f => (Competition:c,Fixture:f))).ToLookup(x=>x.Fixture.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Life.RandomEvents.Where(e=>e.State!="skipped").ToLookup(e=>e.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =data.Life.RandomEvents.Where(e=>e.State!="skipped").ToLookup(e=>e.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Matches.Where(m => m.Registered || m.Day >= data.Day && m.Status == "待赛" && EsportsWorld.EntryReason(data,m) == null).ToLookup(m => m.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.Where(m => m.Registered || m.Day >= data.Day && m.Status == "待赛" && EsportsWorld.EntryReason(data,m) == null).ToLookup(m => m.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`SocialAppointments.All(data).Where(x => x.Offer.State is "已确认" or "已赴约" or "已结束")              .ToLookup(x => PrivateAppointments.Date(data, x.Offer))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SocialAppointments.All(data).Where(x => x.Offer.State is "已确认" or "已赴约" or "已结束")              .ToLookup(x => PrivateAppointments.Date(data, x.Offer))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures              .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.HumanIds.Append("player").Append(data.LocalHumanId).Where(id=>id.Length>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Append("player").Append(data.LocalHumanId).Where(id=>id.Length>0).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= data.Day && (data.Esports.ClubId.Length > 0 || !ClubPlan(a)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= data.Day && (data.Esports.ClubId.Length > 0 || !ClubPlan(a))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.RandomEvents.Where(e=>e.State!="skipped")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.RandomEvents.Where(e=>e.State!="skipped").ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Registered || m.Day >= data.Day && m.Status == "待赛" && EsportsWorld.EntryReason(data,m) == null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Registered || m.Day >= data.Day && m.Status == "待赛" && EsportsWorld.EntryReason(data,m) == null).ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`fixturesByDay[shown].Where(x=>!matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fixturesByDay[shown].Where(x=>!matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id)).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`monthPlans.Where(a=>a.StartedDay<=shown && shown<=a.FinishDay)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var plan in monthPlans.Where(a=>a.StartedDay<=shown && shown<=a.FinishDay))              DayEntry(box,"calendar-days",plan.Title,plan.Status+" · "+AgendaRange(data,plan.StartedDay,plan.FinishDay));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{detail,encounter.Title}.Where(s=>s.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{detail,encounter.Title}.Where(s=>s.Length>0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`SocialAppointments.All(data).Where(x => x.Offer.State is "已确认" or "已赴约" or "已结束")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SocialAppointments.All(data).Where(x => x.Offer.State is "已确认" or "已赴约" or "已结束")              .ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`SocialAppointments.All(data).Where(x=>PrivateAppointments.Date(data,x.Offer)==shown &&                       x.Offer.State is "已确认" or "已赴约" or "已结束" or "未赴约")`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (conversation,activity) in SocialAppointments.All(data).Where(x=>PrivateAppointments.Date(data,x.Offer)==shown &&                       x.Offer.State is "已确认" or "已赴约" or "已结束" or "未赴约"))          {              var entry=DayEntry(box,"heart",activity.Title,"对象："+CareerEngine.DisplayName(data,conversation.PersonId)+" · "+SocialAppointments.StatusText(data,activity));              entry.AddChild(TextLink("查看私信 ↗",()=>{ if(activity.GroupId.Length>0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); }));          }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`markers.Add(("question",ev.Title))`；返回值紧邻使用处：`ExpressionStatementSyntax: markers.Add(("question",ev.Title));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`markers.Add((a.Offer.GoodId=="grand-wedding"?"wedding":"calendar-date",a.Offer.Title))`；返回值紧邻使用处：`ExpressionStatementSyntax: markers.Add((a.Offer.GoodId=="grand-wedding"?"wedding":"calendar-date",a.Offer.Title));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`markers.Add((entered ? "calendar-crossed-swords" : "calendar-sword",match?.Event ?? world!.Name))`；返回值紧邻使用处：`ExpressionStatementSyntax: markers.Add((entered ? "calendar-crossed-swords" : "calendar-sword",match?.Event ?? world!.Name));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Icon,string Title)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<(string Icon,string Title)>()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`grid.GetChildren().OfType<CalendarDayButton>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: grid.GetChildren().OfType<CalendarDayButton>().ToArray`
- `System.DateOnly.AddDays(int)`；输入表达式：`start.AddDays(i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =start.AddDays(i)`
- `System.DateOnly.AddMonths(int)`；输入表达式：`CalendarMonth.Owner(today).AddMonths(_calendarMonth)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CalendarMonth.Owner(today).AddMonths(_calendarMonth)`
- `System.DateOnly.ToString(string?, System.IFormatProvider?)`；输入表达式：`GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN"))`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN"))`
- `System.DateOnly.ToString(string?)`；输入表达式：`date.ToString("M/d")`；返回值紧邻使用处：`ConditionalExpressionSyntax: date.Month==month.Month ? date.Day.ToString() : date.ToString("M/d")`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Covers(day)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: preview?.Covers(day)`
- `System.Globalization.CultureInfo.GetCultureInfo(string)`；输入表达式：`System.Globalization.CultureInfo.GetCultureInfo("zh-CN")`；返回值紧邻使用处：`ArgumentSyntax: System.Globalization.CultureInfo.GetCultureInfo("zh-CN")`
- `System.Linq.ILookup<TKey, TElement>.Contains(TKey)`；输入表达式：`encounters.Contains(day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Question = encounters.Contains(day)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`matchesByDay[day].OrderByDescending(m => m.Registered).ThenByDescending(m => m.CompetitionId.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matchesByDay[day].OrderByDescending(m => m.Registered).ThenByDescending(m => m.CompetitionId.Length > 0).FirstOrDefault`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(SeasonCalendar.End(data),data.Day+84)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(SeasonCalendar.End(data),data.Day+84)`

**赋值（含属性/字段和局部值）：**

- `_arenaMatchId` = `match.Id`
- `_calendarMode` = `"当日"`
- `_calendarMode` = `mode`
- `_planKey` = `""`
- `_selectedDay` = `day`
- `_tab` = `"赛事"`
- `(title,detail)` = `("训练 / 新闻","")`
- `(title,detail)` = `(activePlan.Title,$"第 {day-activePlan.StartedDay+1} / {activePlan.FinishDay-activePlan.StartedDay+1} 天")`
- `(title,detail)` = `(appointment.Offer.Title,"对象："+CareerEngine.DisplayName(data,appointment.Conversation.PersonId))`
- `(title,detail)` = `(encounter.Title,"随机事件")`
- `(title,detail)` = `(MatchTitle(data,match),MatchDetail(data,match))`
- `(title,detail)` = `(world.Name,world.Country)`
- `b.Modulate` = `day < data.Day ? new Color("8591a0") : Colors.White`
- `b.Pressed` += `() =>              {                  _selectedDay = day; _calendarMode = "当日"; ClearPlan(); Render();              }`
- `Bond` = `ordinaryDate.Conversation == null ? null : RelationshipPresentation.IconBond(PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new())`
- `CalendarHeight` = `cellHeight`
- `CalendarLayout` = `true`
- `Columns` = `7`
- `CustomMinimumSize` = `new(0, 555)`
- `CustomMinimumSize` = `new(376,840)`
- `Day` = `day`
- `Description` = `title`
- `detail` = `string.Join("\n",new[]{detail,encounter.Title}.Where(s=>s.Length>0))`
- `HasMatch` = `match != null || world != null`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `jump.Disabled` = `_multiplayer is {Host:false}`
- `jump.Name` = `"CalendarDayJump"`
- `Markers` = `markers.DistinctBy(m=>m.Icon).ToList()`
- `monthName.FocusMode` = `FocusModeEnum.None`
- `monthName.MouseFilter` = `MouseFilterEnum.Ignore`
- `monthName.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `months.CustomMinimumSize` = `new(0,70)`
- `Name` = `"CalendarDay_" + day`
- `Name` = `"CalendarSidebar"`
- `Name` = `"CalendarSideContent"`
- `Name` = `"CalendarSideScroll"`
- `Number` = `date.Month==month.Month ? date.Day.ToString() : date.ToString("M/d")`
- `PlanWindow` = `_calendarMode == "计划" && offered.Any(a => day >= a.OfferedDay && day <= a.ExpiresDay)`
- `Preview` = `preview?.Covers(day) == true`
- `Question` = `encounters.Contains(day)`
- `Registered` = `entered`
- `registration.Disabled` = `_multiplayer is {Host:false}`
- `SecondLine` = `detail`
- `Selected` = `_calendarMode == "当日" && day == shown`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `tabs.CustomMinimumSize` = `new(0,53)`
- `Today` = `day == data.Day`
- `Wedding` = `appointments[day].Any(a => a.Offer.GoodId == "grand-wedding")`
- `weekday.CustomMinimumSize` = `new(0,22)`
- `weekday.HorizontalAlignment` = `HorizontalAlignment.Center`

<a id="symbol-37a56bda571d"></a>

## `Month(int) — void Month(int delta)`

来源：源码第 635 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`MonthArrow(bool, int)`](CareerScreen.cs.md#symbol-950248099d2c)

**调用：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._calendarMonth`；`NationalSpire.CareerScreen.Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**

- `_calendarMode` = `"日程"`
- `_calendarMonth` += `delta`

<a id="symbol-950248099d2c"></a>

## `MonthArrow(bool, int) — void MonthArrow(bool visible,int direction)`

来源：源码第 641 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`Month(int)`](CareerScreen.cs.md#symbol-37a56bda571d)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `Month(int)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.NavigationIcon(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`arrow.AddThemeConstantOverride("icon_max_width",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: arrow.AddThemeConstantOverride("icon_max_width",18);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize=new(36,36) }`；返回值紧邻使用处：`ArgumentSyntax: new Control { CustomMinimumSize=new(36,36) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`months.AddChild(arrow)`；返回值紧邻使用处：`ExpressionStatementSyntax: months.AddChild(arrow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`months.AddChild(new Control { CustomMinimumSize=new(36,36) })`；返回值紧邻使用处：`ExpressionStatementSyntax: months.AddChild(new Control { CustomMinimumSize=new(36,36) });`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(36,36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: arrow.CustomMinimumSize=new(36,36)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(36,36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(36,36)`
- `Month(int)`；输入表达式：`Month(direction)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Month(direction)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(arrow,"00000000","00000000","1c3441","00000000")`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(arrow,"00000000","00000000","1c3441","00000000");`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("",()=>Month(direction))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CaptionButton("",()=>Month(direction))`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon(direction<0?"chevron-left":"chevron-right")`；返回值紧邻使用处：`AssignmentExpressionSyntax: arrow.Icon=NavigationIcon(direction<0?"chevron-left":"chevron-right")`

**赋值（含属性/字段和局部值）：**

- `arrow.AccessibilityName` = `direction<0?"上个月":"下个月"`
- `arrow.CustomMinimumSize` = `new(36,36)`
- `arrow.ExpandIcon` = `true`
- `arrow.Icon` = `NavigationIcon(direction<0?"chevron-left":"chevron-right")`
- `arrow.IconAlignment` = `HorizontalAlignment.Center`
- `arrow.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `CustomMinimumSize` = `new(36,36)`

<a id="symbol-454826c2504f"></a>

## `Blank() — void Blank()`

来源：源码第 664 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Panel.Panel()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`blank.AddThemeStyleboxOverride("panel",CareerVisuals.Box("0b1520","192a37",5,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: blank.AddThemeStyleboxOverride("panel",CareerVisuals.Box("0b1520","192a37",5,0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(blank)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(blank);`
- `Godot.Panel.Panel()`；输入表达式：`new Panel { CustomMinimumSize=new(0,cellHeight), SizeFlagsHorizontal=SizeFlags.ExpandFill, MouseFilter=MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Panel { CustomMinimumSize=new(0,cellHeight), SizeFlagsHorizontal=SizeFlags.ExpandFill, MouseFilter=MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,cellHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,cellHeight)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0b1520","192a37",5,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0b1520","192a37",5,0)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0,cellHeight)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-6b6d63fc08b3"></a>

## `NationalSpire.CareerScreen.DayEntry(Godot.VBoxContainer, string, string, string) — private VBoxContainer DayEntry(VBoxContainer parent,string icon,string title,string detail)`

来源：源码第 790 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CalendarEncounters(NationalSpire.CareerData, Godot.VBoxContainer, int, System.Collections.Generic.IEnumerable<NationalSpire.RandomEventRecord>)`](RandomEventScreen.cs.md#symbol-e447383e7699)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",5)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",5);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",10);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(detail,13,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(detail,13,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(title,17,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(title,17,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(Hairline())`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(Hairline());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(mark)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(mark);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(detail,13,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(detail,13,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,17,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(title,17,_ink,true)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(icon,18,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Glyph(icon,18,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline()`；返回值紧邻使用处：`ArgumentSyntax: Hairline()`

**赋值（含属性/字段和局部值）：**

- `mark.SizeFlagsVertical` = `SizeFlags.ShrinkBegin`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-c8051d511377"></a>

## `NationalSpire.CareerScreen.Matches(NationalSpire.CareerData) — private void Matches(CareerData data)`

来源：源码第 800 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`ChooseCharacter(int)`](CareerScreen.cs.md#symbol-30f08a055164)；[`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Forfeit(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerEngine.cs.md#symbol-0b1ace8ede4f)；[`NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-0b8521a25ad9)；[`NationalSpire.CareerEngine.NextMatch(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-c3698aa12773)；[`NationalSpire.CareerScreen.ArenaCharacterMenu(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CharacterModel>, int, int, System.Action<int>)`](MatchArenaScreen.cs.md#symbol-22155287ec1d)；[`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`](MatchArenaScreen.cs.md#symbol-a95468bbc287)；[`NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action)`](MatchArenaScreen.cs.md#symbol-2b8f5772ff95)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`](MatchArenaScreen.cs.md#symbol-c4eb3ccea4ca)；[`NationalSpire.CareerScreen.MatchReviewButton(NationalSpire.CareerData)`](MatchArenaScreen.cs.md#symbol-8876eaeddb03)；[`NationalSpire.CareerScreen.Matchup(NationalSpire.CareerData, NationalSpire.CareerMatch)`](BroadcastVisuals.cs.md#symbol-dc5a27245e42)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`](CareerSession.cs.md#symbol-a13f3923812a)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.GameBridge.RandomChoice()`](GameBridge.cs.md#symbol-e436ec882e7b)；[`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)；[`NationalSpire.GameBridge.RecoveryMessageFor(bool)`](GameBridge.cs.md#symbol-6b85087ac133)；[`NationalSpire.GameBridge.ReleaseMissingRun()`](GameBridge.cs.md#symbol-0d1c45a81336)；[`NationalSpire.MatchModes.Select(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int)`](MatchModes.cs.md#symbol-51d0719d4fbb)；[`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?, string?)`](PlayerSimulation.cs.md#symbol-bd0770601593)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`SelectCharacter(int)`](CareerScreen.cs.md#symbol-370ecae65cca)；[`UpdateReward()`](CareerScreen.cs.md#symbol-604e399794c6)；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.CareerAvatar.CareerAvatar()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `ChooseCharacter(int)`；`Launch()`；`NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatarIcon.Pixels`；`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerData.RandomCharacter`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Forfeit(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.NextMatch(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Decider`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._arenaMatchId`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.AdvanceCareerDay()`；`NationalSpire.CareerScreen.ArenaCharacterMenu(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CharacterModel>, int, int, System.Action<int>)`；`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`；`NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CharacterCaptionGap`；`NationalSpire.CareerScreen.CharacterTileHeight`；`NationalSpire.CareerScreen.CharacterTileInset`；`NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`；`NationalSpire.CareerScreen.MatchReviewButton(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Matchup(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.GameBridge.CanReleaseMissingRun`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.GameBridge.RandomChoice()`；`NationalSpire.GameBridge.RecoverPending()`；`NationalSpire.GameBridge.RecoveryMessageFor(bool)`；`NationalSpire.GameBridge.ReleaseMissingRun()`；`NationalSpire.ICareerSession.CanResume`；`NationalSpire.ICareerSession.Host`；`NationalSpire.ICareerSession.RunStatus`；`NationalSpire.MatchModes.Select(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int)`；`NationalSpire.MatchModeSelector.Changed`；`NationalSpire.MatchModeSelector.Mode`；`NationalSpire.MatchModeSelector.RecordedAscension`；`NationalSpire.MatchRecovery.SingleplayerInUse`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?, string?)`；`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Matches`；`SelectCharacter(int)`；`UpdateReward()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ChooseCharacter(int)`；输入表达式：`ChooseCharacter(chars.Count)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChooseCharacter(chars.Count);`
- `ChooseCharacter(int)`；输入表达式：`ChooseCharacter(index)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChooseCharacter(index)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("47788a55")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color("47788a55")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("e7a6a6")`；返回值紧邻使用处：`ArgumentSyntax: new Color("e7a6a6")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ef9295")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ef9295")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color = new Color("47788a55"), CustomMinimumSize = new(0, 1), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new ColorRect { Color = new Color("47788a55"), CustomMinimumSize = new(0, 1), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`ascRow.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: ascRow.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation",14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation",14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`characterGrid.AddThemeConstantOverride("h_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterGrid.AddThemeConstantOverride("h_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`characterGrid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterGrid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inner.AddThemeConstantOverride("separation", CharacterCaptionGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddThemeConstantOverride("separation", CharacterCaptionGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rewardRow.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: rewardRow.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`rewardBadge.AddThemeStyleboxOverride("panel", CareerVisuals.Box("173b46aa", "47788a66", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: rewardBadge.AddThemeStyleboxOverride("panel", CareerVisuals.Box("173b46aa", "47788a66", 8, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`selection.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102b39", "47788a", 10, 20))`；返回值紧邻使用处：`ExpressionStatementSyntax: selection.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102b39", "47788a", 10, 20));`
- `Godot.Control.Control()`；输入表达式：`new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`ArgumentSyntax: new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`inner.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Name = "MatchCharacterGrid", Columns = columns, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Name = "MatchCharacterGrid", Columns = columns, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(empty)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(empty);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(MatchReviewButton(data))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(MatchReviewButton(data));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(pendingCard)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(pendingCard);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(TeamButton("推进一天", AdvanceCareerDay, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(TeamButton("推进一天", AdvanceCareerDay, 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(TeamButton("下个赛季", () =>              {                  if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;                  CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); Render();              }, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(TeamButton("下个赛季", () =>              {                  if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;                  CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); Render();              }, 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ascRow.AddChild(asc)`；返回值紧邻使用处：`ExpressionStatementSyntax: ascRow.AddChild(asc);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ascRow.AddChild(MatchReviewButton(data))`；返回值紧邻使用处：`ExpressionStatementSyntax: ascRow.AddChild(MatchReviewButton(data));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ascRow.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill})`；返回值紧邻使用处：`ExpressionStatementSyntax: ascRow.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ascRow.AddChild(rewardBadge)`；返回值紧邻使用处：`ExpressionStatementSyntax: ascRow.AddChild(rewardBadge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Matchup(data,match))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Matchup(data,match));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(selection)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(selection);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(match.Decider, 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(match.Decider, 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(MatchRecovery.SingleplayerInUse, 16, new Color("e7a6a6")))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(MatchRecovery.SingleplayerInUse, 16, new Color("e7a6a6")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`characterGrid.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterGrid.AddChild(choice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`characterGrid.AddChild(overflow)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterGrid.AddChild(overflow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choice.AddChild(inner)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddChild(inner);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(ascRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(ascRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(characterGrid)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(characterGrid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(new ColorRect { Color = new Color("47788a55"), CustomMinimumSize = new(0, 1), MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(new ColorRect { Color = new Color("47788a55"), CustomMinimumSize = new(0, 1), MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(ArenaTextAction("放弃本场", "flag", new Color("ef9295"), () =>              { CareerEngine.Forfeit(data, match); if(data.PendingSettlementId==match.Id) { _tab="结算"; _reviewId=match.Id; } Render(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(ArenaTextAction("放弃本场", "flag", new Color("ef9295"), () =>              { CareerEngine.Forfeit(data, match); if(data.PendingSettlementId==match.Id) { _tab="结算"; _reviewId=match.Id; } Render(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(ArenaTextAction("模拟本场", "fast-forward", CareerVisuals.Teal, () =>              {                  if (MultiplayerCommand("propose-simulate", match.Id, text: asc.Mode, number: asc.RecordedAscension)) return;                  if (chars.Count == 0) return;                  var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];                  var error = PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), asc.RecordedAscension, asc.Mode);                  if (error == null && data.PendingSettlementId == match.Id && data.Results.Any(r => r.MatchId == match.Id)) { _tab="结算"; _reviewId=match.Id; }                  Render(); if (error != null) Notice(error, true);              }))`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(ArenaTextAction("模拟本场", "fast-forward", CareerVisuals.Teal, () =>              {                  if (MultiplayerCommand("propose-simulate", match.Id, text: asc.Mode, number: asc.RecordedAscension)) return;                  if (chars.Count == 0) return;                  var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];                  var error = PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), asc.RecordedAscension, asc.Mode);                  if (error == null && data.PendingSettlementId == match.Id && data.Results.Any(r => r.MatchId == match.Id)) { _tab="结算"; _reviewId=match.Id; }                  Render(); if (error != null) Notice(error, true);              }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`eb.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: eb.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`eb.AddChild(Text("推进期间会在已报名的比赛日停下。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: eb.AddChild(Text("推进期间会在已报名的比赛日停下。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`eb.AddChild(Text(available ? "可以从赛程分页报名，也可以继续推进日期。"                  : $"本赛季共 {SeasonCalendar.Length(data)} 天。没有比赛时仍可继续生活、等待后续赛程，或进入下个赛季。", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: eb.AddChild(Text(available ? "可以从赛程分页报名，也可以继续推进日期。"                  : $"本赛季共 {SeasonCalendar.Length(data)} 天。没有比赛时仍可继续生活、等待后续赛程，或进入下个赛季。", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`eb.AddChild(Text(available ? "尚未报名比赛" : "暂时没有可参赛比赛", 26, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: eb.AddChild(Text(available ? "尚未报名比赛" : "暂时没有可参赛比赛", 26, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(randomCharacter)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(randomCharacter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(selectedLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(selectedLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(Text("出战角色", 25, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(Text("出战角色", 25, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(new CareerAvatar { Art = AvatarAssets.Load(chars[i].Id.ToString(), 0, false),                      CustomMinimumSize = new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels),                      SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(new CareerAvatar { Art = AvatarAssets.Load(chars[i].Id.ToString(), 0, false),                      CustomMinimumSize = new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels),                      SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pb.AddChild(Button("返回主菜单", Close, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: pb.AddChild(Button("返回主菜单", Close, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pb.AddChild(Button("取消失效的比赛", () =>                      ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; }), 260))`；返回值紧邻使用处：`ExpressionStatementSyntax: pb.AddChild(Button("取消失效的比赛", () =>                      ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; }), 260));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pb.AddChild(Button("重新检查比赛存档", () => { GameBridge.RecoverPending(); Render(); }, 260))`；返回值紧邻使用处：`ExpressionStatementSyntax: pb.AddChild(Button("重新检查比赛存档", () => { GameBridge.RecoverPending(); Render(); }, 260));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pb.AddChild(resume)`；返回值紧邻使用处：`ExpressionStatementSyntax: pb.AddChild(resume);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pb.AddChild(Text(_multiplayer == null ? "比赛进行中" : _multiplayer.CanResume ? "比赛已暂停" : "比赛连接状态", 28, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: pb.AddChild(Text(_multiplayer == null ? "比赛进行中" : _multiplayer.CanResume ? "比赛已暂停" : "比赛连接状态", 28, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pb.AddChild(Text(_multiplayer?.RunStatus ?? GameBridge.RecoveryMessageFor(false), 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: pb.AddChild(Text(_multiplayer?.RunStatus ?? GameBridge.RecoveryMessageFor(false), 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rewardBadge.AddChild(rewardRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: rewardBadge.AddChild(rewardRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rewardRow.AddChild(DashboardLabel("奖励", 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: rewardRow.AddChild(DashboardLabel("奖励", 16, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rewardRow.AddChild(rewardPreview)`；返回值紧邻使用处：`ExpressionStatementSyntax: rewardRow.AddChild(rewardPreview);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`_content.MoveChild(box,-1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.MoveChild(box,-1);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`heading.MoveChild(selectedLabel, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.MoveChild(selectedLabel, 1);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "MatchRewardMultiplier", SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "MatchRewardMultiplier", SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, CharacterTileHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: choice.CustomMinimumSize = new(0, CharacterTileHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels)`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`character.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: character.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == data.SelectedCharacter`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`character.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: character.Id.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`chars[i].Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: chars[i].Id.ToString()`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(chars[i].Id.ToString(), 0, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = AvatarAssets.Load(chars[i].Id.ToString(), 0, false)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = AvatarAssets.Load(chars[i].Id.ToString(), 0, false),                      CustomMinimumSize = new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels),                      SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar { Art = AvatarAssets.Load(chars[i].Id.ToString(), 0, false),                      CustomMinimumSize = new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels),                      SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.MainCharacter(data,"player")`；返回值紧邻使用处：`ConditionalExpressionSyntax: chars.Count>0?PlayerArchive.CharacterName(chars[Math.Clamp(selectedCharacter,0,chars.Count-1)].Id):CareerAvatars.MainCharacter(data,"player")`
- `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；输入表达式：`CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1);`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data,match.OpponentId)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data,match.OpponentId)`
- `NationalSpire.CareerEngine.Forfeit(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`CareerEngine.Forfeit(data, match)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Forfeit(data, match);`
- `NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`；输入表达式：`CareerEngine.NextAvailable(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.NextAvailable(data) != null`
- `NationalSpire.CareerEngine.NextMatch(NationalSpire.CareerData)`；输入表达式：`CareerEngine.NextMatch(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.NextMatch(data)              ?? data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day).FirstOrDefault(m=>EsportsWorld.EntryReason(data,m)==null)`
- `NationalSpire.CareerScreen.ArenaCharacterMenu(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CharacterModel>, int, int, System.Action<int>)`；输入表达式：`ArenaCharacterMenu(chars, directCount, selectedCharacter, ChooseCharacter)`；返回值紧邻使用处：`AssignmentExpressionSyntax: overflow = ArenaCharacterMenu(chars, directCount, selectedCharacter, ChooseCharacter)`
- `NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`；输入表达式：`ArenaIconButton("随机角色","shuffle",() => { if (chars.Count > 0) ChooseCharacter(chars.Count); },choice:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ArenaIconButton("随机角色","shuffle",() => { if (chars.Count > 0) ChooseCharacter(chars.Count); },choice:true)`
- `NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action)`；输入表达式：`ArenaTextAction("放弃本场", "flag", new Color("ef9295"), () =>              { CareerEngine.Forfeit(data, match); if(data.PendingSettlementId==match.Id) { _tab="结算"; _reviewId=match.Id; } Render(); })`；返回值紧邻使用处：`ArgumentSyntax: ArenaTextAction("放弃本场", "flag", new Color("ef9295"), () =>              { CareerEngine.Forfeit(data, match); if(data.PendingSettlementId==match.Id) { _tab="结算"; _reviewId=match.Id; } Render(); })`
- `NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action)`；输入表达式：`ArenaTextAction("模拟本场", "fast-forward", CareerVisuals.Teal, () =>              {                  if (MultiplayerCommand("propose-simulate", match.Id, text: asc.Mode, number: asc.RecordedAscension)) return;                  if (chars.Count == 0) return;                  var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];                  var error = PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), asc.RecordedAscension, asc.Mode);                  if (error == null && data.PendingSettlementId == match.Id && data.Results.Any(r => r.MatchId == match.Id)) { _tab="结算"; _reviewId=match.Id; }                  Render(); if (error != null) Notice(error, true);              })`；返回值紧邻使用处：`ArgumentSyntax: ArenaTextAction("模拟本场", "fast-forward", CareerVisuals.Teal, () =>              {                  if (MultiplayerCommand("propose-simulate", match.Id, text: asc.Mode, number: asc.RecordedAscension)) return;                  if (chars.Count == 0) return;                  var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];                  var error = PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), asc.RecordedAscension, asc.Mode);                  if (error == null && data.PendingSettlementId == match.Id && data.Results.Any(r => r.MatchId == match.Id)) { _tab="结算"; _reviewId=match.Id; }                  Render(); if (error != null) Notice(error, true);              })`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("", () => ChooseCharacter(index), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("", () => ChooseCharacter(index), 0)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("返回主菜单", Close, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("返回主菜单", Close, 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消失效的比赛", () =>                      ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; }), 260)`；返回值紧邻使用处：`ArgumentSyntax: Button("取消失效的比赛", () =>                      ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; }), 260)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("全队继续比赛", () => MultiplayerCommand("propose-resume"), 240)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("全队继续比赛", () => MultiplayerCommand("propose-resume"), 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("重新检查比赛存档", () => { GameBridge.RecoverPending(); Render(); }, 260)`；返回值紧邻使用处：`ArgumentSyntax: Button("重新检查比赛存档", () => { GameBridge.RecoverPending(); Render(); }, 260)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("", 18, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel("", 18, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("", 26, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel("", 26, _gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("奖励", 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("奖励", 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title, 22, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(title, 22, _ink)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(empty)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(empty)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(pendingCard)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(pendingCard)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(selection)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(selection)`
- `NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`；输入表达式：`MatchArena(data,match.Event,match.OpponentId,CareerEngine.DisplayName(data,match.OpponentId),future?"前往比赛日":due?"开赛":"报名比赛",                  data.RandomCharacter?"随机角色":chars.Count>0?PlayerArchive.CharacterName(chars[Math.Clamp(selectedCharacter,0,chars.Count-1)].Id):CareerAvatars.MainCharacter(data,"player"),CareerVisuals.Teal,out var controls,match.Day,Launch,seed:match.Seed)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchArena(data,match.Event,match.OpponentId,CareerEngine.DisplayName(data,match.OpponentId),future?"前往比赛日":due?"开赛":"报名比赛",                  data.RandomCharacter?"随机角色":chars.Count>0?PlayerArchive.CharacterName(chars[Math.Clamp(selectedCharacter,0,chars.Count-1)].Id):CareerAvatars.MainCharacter(data,"player"),CareerVisuals.Teal,out var controls,match.Day,Launch,seed:match.Seed);`
- `NationalSpire.CareerScreen.MatchReviewButton(NationalSpire.CareerData)`；输入表达式：`MatchReviewButton(data)`；返回值紧邻使用处：`ArgumentSyntax: MatchReviewButton(data)`
- `NationalSpire.CareerScreen.Matchup(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`Matchup(data,match)`；返回值紧邻使用处：`ArgumentSyntax: Matchup(data,match)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("ascension", match.Id, text: mode, number: asc.RecordedAscension)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("ascension", match.Id, text: mode, number: asc.RecordedAscension)) return;`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-resume")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => MultiplayerCommand("propose-resume")`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-simulate", match.Id, text: asc.Mode, number: asc.RecordedAscension)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-simulate", match.Id, text: asc.Mode, number: asc.RecordedAscension)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () =>                      ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; })`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("推进一天", AdvanceCareerDay, 180)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("推进一天", AdvanceCareerDay, 180)`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("下个赛季", () =>              {                  if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;                  CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); Render();              }, 180)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("下个赛季", () =>              {                  if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;                  CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); Render();              }, 180)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_multiplayer == null ? "比赛进行中" : _multiplayer.CanResume ? "比赛已暂停" : "比赛连接状态", 28, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(_multiplayer == null ? "比赛进行中" : _multiplayer.CanResume ? "比赛已暂停" : "比赛连接状态", 28, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_multiplayer?.RunStatus ?? GameBridge.RecoveryMessageFor(false), 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(_multiplayer?.RunStatus ?? GameBridge.RecoveryMessageFor(false), 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("出战角色", 25, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("出战角色", 25, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("推进期间会在已报名的比赛日停下。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("推进期间会在已报名的比赛日停下。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(available ? "可以从赛程分页报名，也可以继续推进日期。"                  : $"本赛季共 {SeasonCalendar.Length(data)} 天。没有比赛时仍可继续生活、等待后续赛程，或进入下个赛季。", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(available ? "可以从赛程分页报名，也可以继续推进日期。"                  : $"本赛季共 {SeasonCalendar.Length(data)} 天。没有比赛时仍可继续生活、等待后续赛程，或进入下个赛季。", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(available ? "尚未报名比赛" : "暂时没有可参赛比赛", 26, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(available ? "尚未报名比赛" : "暂时没有可参赛比赛", 26, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(match.Decider, 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(match.Decider, 18, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(MatchRecovery.SingleplayerInUse, 16, new Color("e7a6a6"))`；返回值紧邻使用处：`ArgumentSyntax: Text(MatchRecovery.SingleplayerInUse, 16, new Color("e7a6a6"))`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("102b39", "47788a", 10, 20)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("102b39", "47788a", 10, 20)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("173b46aa", "47788a66", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("173b46aa", "47788a66", 8, 12)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(data,m)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(data,m)==null`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters()`
- `NationalSpire.GameBridge.RandomChoice()`；输入表达式：`GameBridge.RandomChoice()`；返回值紧邻使用处：`ConditionalExpressionSyntax: selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)]`
- `NationalSpire.GameBridge.RecoverPending()`；输入表达式：`GameBridge.RecoverPending()`；返回值紧邻使用处：`ExpressionStatementSyntax: GameBridge.RecoverPending();`
- `NationalSpire.GameBridge.RecoveryMessageFor(bool)`；输入表达式：`GameBridge.RecoveryMessageFor(false)`；返回值紧邻使用处：`BinaryExpressionSyntax: _multiplayer?.RunStatus ?? GameBridge.RecoveryMessageFor(false)`
- `NationalSpire.GameBridge.ReleaseMissingRun()`；输入表达式：`GameBridge.ReleaseMissingRun()`；返回值紧邻使用处：`ExpressionStatementSyntax: GameBridge.ReleaseMissingRun();`
- `NationalSpire.MatchModes.Select(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int)`；输入表达式：`MatchModes.Select(data, match, mode, level)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchModes.Select(data, match, mode, level);`
- `NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；输入表达式：`new MatchModeSelector(data, match, _multiplayer is not { Host: false }) { SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MatchModeSelector(data, match, _multiplayer is not { Host: false }) { SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(chars[i].Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerArchive.CharacterName(chars[i].Id)`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(chars[Math.Clamp(selectedCharacter,0,chars.Count-1)].Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: chars.Count>0?PlayerArchive.CharacterName(chars[Math.Clamp(selectedCharacter,0,chars.Count-1)].Id):CareerAvatars.MainCharacter(data,"player")`
- `NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?, string?)`；输入表达式：`PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), asc.RecordedAscension, asc.Mode)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), asc.RecordedAscension, asc.Mode)`
- `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.End(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.End(data) + 1`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(data)`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCalendar.Length(data)}`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Matches)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Matches)`
- `SelectCharacter(int)`；输入表达式：`SelectCharacter(selectedCharacter)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectCharacter(selectedCharacter);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`characterButtons.Add(chars.Count, randomCharacter)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterButtons.Add(chars.Count, randomCharacter);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`characterButtons.Add(index, choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterButtons.Add(index, choice);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<int, Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<int, Button>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Any(r => r.MatchId == match.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: error == null && data.PendingSettlementId == match.Id && data.Results.Any(r => r.MatchId == match.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m=>m.Id==_arenaMatchId && m.Status=="待赛" && m.Registered && m.Day==data.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Matches.FirstOrDefault(m=>m.Id==_arenaMatchId && m.Status=="待赛" && m.Registered && m.Day==data.Day) ?? CareerEngine.NextMatch(data)              ?? data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day).FirstOrDefault(m=>EsportsWorld.EntryReason(data,m)==null)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day).FirstOrDefault(m=>EsportsWorld.EntryReason(data,m)==null)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.NextMatch(data)              ?? data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day).FirstOrDefault(m=>EsportsWorld.EntryReason(data,m)==null)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`chars.FindIndex(c => c.Id.ToString() == data.SelectedCharacter)`；返回值紧邻使用处：`ArgumentSyntax: chars.FindIndex(c => c.Id.ToString() == data.SelectedCharacter)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(selectedCharacter, 0, chars.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(selectedCharacter, 0, chars.Count - 1)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(selectedCharacter,0,chars.Count-1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(selectedCharacter,0,chars.Count-1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, chars.FindIndex(c => c.Id.ToString() == data.SelectedCharacter))`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.RandomCharacter ? chars.Count : Math.Max(0, chars.FindIndex(c => c.Id.ToString() == data.SelectedCharacter))`
- `UpdateReward()`；输入表达式：`UpdateReward()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateReward();`

**赋值（含属性/字段和局部值）：**

- `_reviewId` = `match.Id`
- `_tab` = `"结算"`
- `Art` = `AvatarAssets.Load(chars[i].Id.ToString(), 0, false)`
- `asc.Changed` += `(mode, level) =>              {                  UpdateReward();                  if (MultiplayerCommand("ascension", match.Id, text: mode, number: asc.RecordedAscension)) return;                  MatchModes.Select(data, match, mode, level); CareerStore.Save(data);              }`
- `choice.AccessibilityName` = `choice.TooltipText = title`
- `choice.CustomMinimumSize` = `new(0, CharacterTileHeight)`
- `choice.Name` = `"MatchCharacter_" + i`
- `choice.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `choice.ToggleMode` = `true`
- `choice.TooltipText` = `title`
- `Color` = `new Color("47788a55")`
- `Columns` = `columns`
- `CustomMinimumSize` = `new(0, 1)`
- `CustomMinimumSize` = `new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels)`
- `inner.OffsetBottom` = `-5`
- `inner.OffsetLeft` = `CharacterTileInset`
- `inner.OffsetRight` = `-CharacterTileInset`
- `inner.OffsetTop` = `5`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `name.ClipText` = `true`
- `name.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `name.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `Name` = `"MatchCharacterGrid"`
- `Name` = `"MatchRewardMultiplier"`
- `overflow` = `ArenaCharacterMenu(chars, directCount, selectedCharacter, ChooseCharacter)`
- `randomCharacter.Disabled` = `chars.Count == 0`
- `randomCharacter.Name` = `"MatchRandomCharacter"`
- `randomCharacter.TooltipText` = `"开赛时从当前可用角色中随机确定，包含已启用的模组角色；继续比赛沿用存档角色。"`
- `resume.Disabled` = `!_multiplayer.CanResume`
- `selectedLabel.ClipText` = `true`
- `selectedLabel.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `selectedLabel.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `selectedLabel.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `selection.Name` = `"MatchCharacterSelection"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-370ecae65cca"></a>

## `SelectCharacter(int) — void SelectCharacter(int index)`

来源：源码第 839 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ChooseCharacter(int)`](CareerScreen.cs.md#symbol-30f08a055164)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.OptionButton.GetItemIndex(int)`；`Godot.OptionButton.Select(int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AvatarHighestClear`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerScreen._arenaCharacter`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(option == index)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(option == index);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_arenaCharacter)`；返回值紧邻使用处：`BinaryExpressionSyntax: _arenaCharacter != null && IsInstanceValid(_arenaCharacter)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_arenaCharacter.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_arenaCharacter.IsQueuedForDeletion()`
- `Godot.OptionButton.GetItemIndex(int)`；输入表达式：`overflow.GetItemIndex(index)`；返回值紧邻使用处：`ConditionalExpressionSyntax: !random && index >= directCount ? overflow.GetItemIndex(index) : -1`
- `Godot.OptionButton.Select(int)`；输入表达式：`overflow.Select(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: overflow.Select(item);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data,data.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(data,data.Esports.ClubId)}`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(chars[index].Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: random ? "随机角色" : PlayerArchive.CharacterName(chars[index].Id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,data.AvatarHighestClear)`；返回值紧邻使用处：`InterpolationSyntax: {Math.Max(0,data.AvatarHighestClear)}`

**赋值（含属性/字段和局部值）：**

- `_arenaCharacter.Text` = `$"{data.Esports.Country} · {EsportsWorld.ClubName(data,data.Esports.ClubId)}\n最高进阶 {Math.Max(0,data.AvatarHighestClear)} · {chosen}"`
- `overflow.Text` = `"更多角色"`
- `overflow.TooltipText` = `overflow.Text`
- `selectedCharacter` = `index`
- `selectedLabel.Text` = `"没有可用角色。"`
- `selectedLabel.Text` = `random ? "随机角色 · 开赛时确定" : "已选择：" + chosen`
- `selectedLabel.TooltipText` = `selectedLabel.Text`

<a id="symbol-30f08a055164"></a>

## `ChooseCharacter(int) — void ChooseCharacter(int index)`

来源：源码第 859 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`SelectCharacter(int)`](CareerScreen.cs.md#symbol-370ecae65cca)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.RandomCharacter`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerEngine.RandomCharacterChoice`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`SelectCharacter(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`chars[index].Id.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: random ? CareerEngine.RandomCharacterChoice : chars[index].Id.ToString()`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("character", id)`；返回值紧邻使用处：`ExpressionStatementSyntax: MultiplayerCommand("character", id);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `SelectCharacter(int)`；输入表达式：`SelectCharacter(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectCharacter(index);`
- `SelectCharacter(int)`；输入表达式：`SelectCharacter(selectedCharacter)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectCharacter(selectedCharacter);`

**赋值（含属性/字段和局部值）：**

- `data.RandomCharacter` = `random`
- `data.SelectedCharacter` = `id`

<a id="symbol-604e399794c6"></a>

## `UpdateReward() — void UpdateReward()`

来源：源码第 915 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.MatchRules.RewardMultiplier(int, int, string)`](MatchRules.cs.md#symbol-fb4fadca1f66)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.MatchModeSelector.Mode`；`NationalSpire.MatchModeSelector.RecordedAscension`；`NationalSpire.MatchRules.RewardMultiplier(int, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.RewardMultiplier(int, int, string)`；输入表达式：`MatchRules.RewardMultiplier(match.RequiredAscension, asc.RecordedAscension, asc.Mode)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.RewardMultiplier(match.RequiredAscension, asc.RecordedAscension, asc.Mode):0.00}`

**赋值（含属性/字段和局部值）：**

- `rewardPreview.Text` = `$"×{MatchRules.RewardMultiplier(match.RequiredAscension, asc.RecordedAscension, asc.Mode):0.00}"`

<a id="symbol-9971cb44a804"></a>

## `Launch() — async void Launch()`

来源：源码第 932 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.GameBridge.RandomChoice()`](GameBridge.cs.md#symbol-e436ec882e7b)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerScreen._starting`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.GameBridge.RandomChoice()`；`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；`NationalSpire.MatchModeSelector.Mode`；`NationalSpire.MatchModeSelector.RecordedAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && !IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsQueuedForDeletion()`
- `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；输入表达式：`CareerEngine.AdvanceToDay(data,match.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.AdvanceToDay(data,match.Day);`
- `NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；输入表达式：`CareerEngine.SetRegistration(data,match,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.SetRegistration(data,match,true)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-advance", "direct", number: match.Day)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-advance", "direct", number: match.Day)) return;`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-register",match.Id,number:1)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-register",match.Id,number:1)) return;`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-start", match.Id, text: asc.Mode, number: asc.RecordedAscension)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-start", match.Id, text: asc.Mode, number: asc.RecordedAscension)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("没有可用角色。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("没有可用角色。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(registration,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(registration,true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.GameBridge.RandomChoice()`；输入表达式：`GameBridge.RandomChoice()`；返回值紧邻使用处：`ConditionalExpressionSyntax: selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)]`
- `NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`GameBridge.StartMatch(match, character, asc.RecordedAscension)`；返回值紧邻使用处：`AwaitExpressionSyntax: await GameBridge.StartMatch(match, character, asc.RecordedAscension)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(selectedCharacter, 0, chars.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(selectedCharacter, 0, chars.Count - 1)`

**赋值（含属性/字段和局部值）：**

- `_starting` = `false`
- `_starting` = `true`

<a id="symbol-75337b99e622"></a>

## `NationalSpire.CareerScreen.Community(NationalSpire.CareerData) — private void Community(CareerData data)`

来源：源码第 986 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.AiService.RetryFailedNewsAsync()`](AiService.cs.md#symbol-411839f2efbd)；[`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.RetryFailedNewsAsync()`；`NationalSpire.AiWorkState.State`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._readPosts`；`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ComposePostId`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.OpenCommunity()`；`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Community`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("查看社区列表", OpenCommunity, 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("查看社区列表", OpenCommunity, 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("重试失败的帖子", () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true), 245))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("重试失败的帖子", () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true), 245));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(feed)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(feed);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("暂时找不到这篇帖子。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("暂时找不到这篇帖子。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"有 {failedNews} 篇帖子没能生成，可以重试。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"有 {failedNews} 篇帖子没能生成，可以重试。", 15, _muted));`
- `NationalSpire.AiService.RetryFailedNewsAsync()`；输入表达式：`AiService.RetryFailedNewsAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.RetryFailedNewsAsync()`
- `NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`；输入表达式：`BuildCommunityToolbar(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BuildCommunityToolbar(data)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看社区列表", OpenCommunity, 170)`；返回值紧邻使用处：`ArgumentSyntax: Button("查看社区列表", OpenCommunity, 170)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("重试失败的帖子", () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true), 245)`；返回值紧邻使用处：`ArgumentSyntax: Button("重试失败的帖子", () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true), 245)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true)`
- `NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`PopulateCommunityFeed(data,feed)`；返回值紧邻使用处：`ExpressionStatementSyntax: PopulateCommunityFeed(data,feed);`
- `NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`；输入表达式：`RenderPostComposer(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostComposer(data);`
- `NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`RenderThread(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderThread(data, post);`
- `NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`；输入表达式：`RenderWeeklyDetail(data)`；返回值紧邻使用处：`IfStatementSyntax: if (RenderWeeklyDetail(data)) return;`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂时找不到这篇帖子。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂时找不到这篇帖子。", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"有 {failedNews} 篇帖子没能生成，可以重试。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"有 {failedNews} 篇帖子没能生成，可以重试。", 15, _muted)`
- `NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`；输入表达式：`WeeklyCarousel(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyCarousel(data);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Count`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Community)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Community)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Count(p => p.AuthorId != "player" && p.NewsGeneration.State == "failed")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).Count(p => p.AuthorId != "player" && p.NewsGeneration.State == "failed")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.All(data).FirstOrDefault(p => p.Id == id) ?? _readPosts.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_readPosts.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.All(data).FirstOrDefault(p => p.Id == id) ?? _readPosts.GetValueOrDefault(id)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.RetryFailedNewsAsync()`

<a id="symbol-ce65b4128fee"></a>

## `NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container) — private void AddPostCard(CareerData data, CommunityPost post, Container feed)`

来源：源码第 1011 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.RetryNewsAsync(string)`](AiService.cs.md#symbol-4e15401241c3)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.AiService.RetryNewsAsync(string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PostCard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f07878")`；返回值紧邻使用处：`ArgumentSyntax: new Color("f07878")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(MentionText(data, post.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(MentionText(data, post.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("● 有新内容", 14, new Color("f07878")))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("● 有新内容", 14, new Color("f07878")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(titleButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(titleButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(WithAvatar(data, post.AuthorId, Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted), 48, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(WithAvatar(data, post.AuthorId, Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted), 48, true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`feed.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: feed.AddChild(card);`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([post.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([post.Id])`
- `NationalSpire.AiService.RetryNewsAsync(string)`；输入表达式：`AiService.RetryNewsAsync(post.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.RetryNewsAsync(post.Id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, post.AuthorId)}`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(post.Title, () => OpenPost(post))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(post.Title, () => OpenPost(post))`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, post.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, post.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPost(post)`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(box, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(box, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(box, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(box, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("● 有新内容", 14, new Color("f07878"))`；返回值紧邻使用处：`ArgumentSyntax: Text("● 有新内容", 14, new Color("f07878"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, post.AuthorId, Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted), 48, true)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(data, post.AuthorId, Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted), 48, true)`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.NewsPending(data, post)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, post.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, post.Day)}`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PostCard)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PostCard)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: post.RelatedPeople.Append(post.AuthorId)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([post.Id])`
- `_` = `AiService.RetryNewsAsync(post.Id)`
- `titleButton.Alignment` = `HorizontalAlignment.Left`
- `titleButton.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `titleButton.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-70740adc3b48"></a>

## `NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData) — private void Profiles(CareerData data)`

来源：源码第 1027 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.OpenProfileList(string?)`](CareerNavigation.cs.md#symbol-fa604705ef07)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.ProfileActions()`](ProfileScreen.cs.md#symbol-70ada758a361)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`](CareerDashboard.cs.md#symbol-fc9ce0453d21)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`Search()`](CareerScreen.cs.md#symbol-a9415bdffe1f)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemText(int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；`string.Contains(string, System.StringComparison)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.CreatedCard`；`NationalSpire.CareerPerson.EditedCard`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._profileFilter`；`NationalSpire.CareerScreen._profileLimit`；`NationalSpire.CareerScreen._profileOrigin`；`NationalSpire.CareerScreen._profileQuery`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.OpenProfileList(string?)`；`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ProfileActions()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Profiles`；`Search()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_content.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddThemeConstantOverride("separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`searchRow.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: searchRow.AddThemeConstantOverride("separation", 16);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Text = _profileQuery, PlaceholderText = "搜索 ID、姓名、国家或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(200, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Text = _profileQuery, PlaceholderText = "搜索 ID、姓名、国家或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(200, 46) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button("显示更多人物", () => { int scroll = _scroll.ScrollVertical; _profileLimit += 36; Render(); _ = RestoreScrollAsync(scroll, _renderVersion); }, 210))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button("显示更多人物", () => { int scroll = _scroll.ScrollVertical; _profileLimit += 36; Render(); _ = RestoreScrollAsync(scroll, _renderVersion); }, 210));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(searchRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(searchRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text($"当前：{(_profileQuery.Length > 0 ? "全名录搜索" : _profileFilter)} · 找到 {people.Count} 人 / 世界共 {data.People.Count} 人 · 当前显示 {Math.Min(_profileLimit, people.Count)} 人", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text($"当前：{(_profileQuery.Length > 0 ? "全名录搜索" : _profileFilter)} · 找到 {people.Count} 人 / 世界共 {data.People.Count} 人 · 当前显示 {Math.Min(_profileLimit, people.Count)} 人", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`categories.AddChild(FilterButton("真人队员", _profileFilter == "真人队员", () => OpenProfileList("真人队员"), 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddChild(FilterButton("真人队员", _profileFilter == "真人队员", () => OpenProfileList("真人队员"), 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`categories.AddChild(FilterButton(filter, _profileFilter == filter, () => OpenProfileList(filter), 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddChild(FilterButton(filter, _profileFilter == filter, () => OpenProfileList(filter), 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`searchRow.AddChild(Button("搜索", Search, 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: searchRow.AddChild(Button("搜索", Search, 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`searchRow.AddChild(origin)`；返回值紧邻使用处：`ExpressionStatementSyntax: searchRow.AddChild(origin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`searchRow.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: searchRow.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`SecondaryTabInset(_content).AddChild(categories)`；返回值紧邻使用处：`ExpressionStatementSyntax: SecondaryTabInset(_content).AddChild(categories);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`origin.AddItem(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: origin.AddItem(label);`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`origin.GetItemText((int)n)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _profileOrigin = origin.GetItemText((int)n)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "ProfileOriginFilter", CustomMinimumSize = new(150, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "ProfileOriginFilter", CustomMinimumSize = new(150, 46) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`origin.Select(Array.IndexOf(new[] { "全部来源", "原生", "自定义" }, _profileOrigin))`；返回值紧邻使用处：`ExpressionStatementSyntax: origin.Select(Array.IndexOf(new[] { "全部来源", "原生", "自定义" }, _profileOrigin));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(200, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(200, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 46)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, _personId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, _personId) is { } selectedPerson`
- `NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`；输入表达式：`AddProfileCards(data, grid, people.Take(_profileLimit))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddProfileCards(data, grid, people.Take(_profileLimit));`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("搜索", Search, 100)`；返回值紧邻使用处：`ArgumentSyntax: Button("搜索", Search, 100)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("显示更多人物", () => { int scroll = _scroll.ScrollVertical; _profileLimit += 36; Render(); _ = RestoreScrollAsync(scroll, _renderVersion); }, 210)`；返回值紧邻使用处：`ArgumentSyntax: Button("显示更多人物", () => { int scroll = _scroll.ScrollVertical; _profileLimit += 36; Render(); _ = RestoreScrollAsync(scroll, _renderVersion); }, 210)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton("真人队员", _profileFilter == "真人队员", () => OpenProfileList("真人队员"), 150)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton("真人队员", _profileFilter == "真人队员", () => OpenProfileList("真人队员"), 150)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(filter, _profileFilter == filter, () => OpenProfileList(filter), 150)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton(filter, _profileFilter == filter, () => OpenProfileList(filter), 150)`
- `NationalSpire.CareerScreen.OpenProfileList(string?)`；输入表达式：`OpenProfileList("真人队员")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenProfileList("真人队员")`
- `NationalSpire.CareerScreen.OpenProfileList(string?)`；输入表达式：`OpenProfileList(filter)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenProfileList(filter)`
- `NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PersonProfile(data, selectedPerson)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonProfile(data, selectedPerson);`
- `NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`；输入表达式：`PlayerProfile(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerProfile(data);`
- `NationalSpire.CareerScreen.ProfileActions()`；输入表达式：`ProfileActions()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileActions()`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(scroll, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(scroll, _renderVersion)`
- `NationalSpire.CareerScreen.SecondaryTabInset(Godot.Container)`；输入表达式：`SecondaryTabInset(_content)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SecondaryTabInset(_content).AddChild`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"当前：{(_profileQuery.Length > 0 ? "全名录搜索" : _profileFilter)} · 找到 {people.Count} 人 / 世界共 {data.People.Count} 人 · 当前显示 {Math.Min(_profileLimit, people.Count)} 人", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"当前：{(_profileQuery.Length > 0 ? "全名录搜索" : _profileFilter)} · 找到 {people.Count} 人 / 世界共 {data.People.Count} 人 · 当前显示 {Math.Min(_profileLimit, people.Count)} 人", 15, _muted)`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, p.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, p.Id)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Profiles)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Profiles)`
- `Search()`；输入表达式：`Search()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Search()`
- `string.Contains(string, System.StringComparison)`；输入表达式：`(p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" ", p.HandleAliases)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Handle + string.Join(" ", p.HandleAliases)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(new[] { "全部来源", "原生", "自定义" }, _profileOrigin)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(new[] { "全部来源", "原生", "自定义" }, _profileOrigin)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.Rating).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`people.Take(_profileLimit)`；返回值紧邻使用处：`ArgumentSyntax: people.Take(_profileLimit)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.Rating).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.Rating).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,              "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",              "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))              .Where`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "真人队员" => data.HumanIds.Contains(p.Id)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_profileLimit, people.Count)`；返回值紧邻使用处：`InterpolationSyntax: {Math.Min(_profileLimit, people.Count)}`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(scroll, _renderVersion)`
- `_profileLimit` += `36`
- `_profileLimit` = `36`
- `_profileOrigin` = `origin.GetItemText((int)n)`
- `Columns` = `3`
- `CustomMinimumSize` = `new Vector2(200, 46)`
- `CustomMinimumSize` = `new(150, 46)`
- `Name` = `"ProfileOriginFilter"`
- `origin.ItemSelected` += `n => { _profileOrigin = origin.GetItemText((int)n); _profileLimit = 36; Render(); }`
- `PlaceholderText` = `"搜索 ID、姓名、国家或俱乐部"`
- `search.TextSubmitted` += `_ => Search()`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `_profileQuery`

<a id="symbol-a9415bdffe1f"></a>

## `Search() — void Search()`

来源：源码第 1039 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._profileLimit`；`NationalSpire.CareerScreen._profileQuery`；`NationalSpire.CareerScreen.Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _profileQuery = search.Text.Trim()`

**赋值（含属性/字段和局部值）：**

- `_profileLimit` = `36`
- `_profileQuery` = `search.Text.Trim()`

<a id="symbol-6dafb04d04fd"></a>

## `NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData) — private void AiSettings(CareerData data)`

来源：源码第 1056 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`LevelIndex()`](CareerScreen.cs.md#symbol-b2c1c96a3fb9)；[`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`](AiService.cs.md#symbol-4f47e0824ca3)；[`NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`](AiService.cs.md#symbol-19e0ca89f9d7)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.AiSettingsPanel.Columns(Godot.VBoxContainer)`](AiSettingsPanel.cs.md#symbol-c1842fa7a32e)；[`NationalSpire.AiSettingsPanel.RivalLevelPicker(int, bool)`](AiSettingsPanel.cs.md#symbol-6ea5b8b2d06c)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`](CareerScreen.cs.md#symbol-b27d08d34395)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-485b9c9c8acb)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int)`](MatchRules.cs.md#symbol-7a4196460ee7)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.Select(int)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `LevelIndex()`；`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`；`NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`；`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`；`NationalSpire.AiSettingsPanel.Columns(Godot.VBoxContainer)`；`NationalSpire.AiSettingsPanel.RivalLevelPicker(int, bool)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.RivalLevel`；`NationalSpire.CareerScreen._aiSettingsDirty`；`NationalSpire.CareerScreen._aiStatus`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.ICareerSession.ProposalId`；`NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`mark.AddThemeColorOverride("font_color", _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: mark.AddThemeColorOverride("font_color", _gold);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`mark.AddThemeFontSizeOverride("font_size", 44)`；返回值紧邻使用处：`ExpressionStatementSyntax: mark.AddThemeFontSizeOverride("font_size", 44);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("AI 内容设置", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("AI 内容设置", 24, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("AI 由主机统一生成，你无需配置服务或密钥。帖子、解说与周刊会自动同步。", 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("AI 由主机统一生成，你无需配置服务或密钥。帖子、解说与周刊会自动同步。", 20, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(mark)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(mark);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`matchBox.AddChild(levelPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: matchBox.AddChild(levelPicker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`matchBox.AddChild(Text("各类选手用时同比调整，通关率不变。" + (data.PendingMatchId != null ? "本场结束后可修改。" : _multiplayer != null ? "由房主设置，全队同步。" : "对本生涯后续比赛生效。"), 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: matchBox.AddChild(Text("各类选手用时同比调整，通关率不变。" + (data.PendingMatchId != null ? "本场结束后可修改。" : _multiplayer != null ? "由房主设置，全队同步。" : "对本生涯后续比赛生效。"), 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`matchBox.AddChild(Text("局内 AI 水平", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: matchBox.AddChild(Text("局内 AI 水平", 24, _gold));`
- `Godot.OptionButton.Select(int)`；输入表达式：`levelPicker.Select(LevelIndex())`；返回值紧邻使用处：`ExpressionStatementSyntax: levelPicker.Select(LevelIndex());`
- `LevelIndex()`；输入表达式：`LevelIndex()`；返回值紧邻使用处：`ArgumentSyntax: LevelIndex()`
- `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`；输入表达式：`AiService.ProcessPendingAsync(data, automatic: false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPendingAsync(data, automatic: false)`
- `NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`；输入表达式：`AiService.RefreshConcurrency(data.Ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.RefreshConcurrency(data.Ai);`
- `NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`；输入表达式：`AiSettingsPanel.Build(box, data.Ai,              () => { SaveAiSettings(data); AiService.RefreshConcurrency(data.Ai); },              () => GenerateContent(() => { _ = AiService.ProcessPendingAsync(data, automatic: false); }), () => OpenPromptSettings(data), Notice, () => _aiSettingsDirty = true,              confirmSwitch: action => ShowCareerDialog("方案没有保存", "方案没有保存，确认切换吗？", () => { action(); return true; }, "确认切换",                  contents: content =>                  {                      var mark = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }; mark.AddThemeFontSizeOverride("font_size", 44); mark.AddThemeColorOverride("font_color", _gold); content.AddChild(mark);                  }, cancelText: "继续编辑"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _aiStatus = AiSettingsPanel.Build(box, data.Ai,              () => { SaveAiSettings(data); AiService.RefreshConcurrency(data.Ai); },              () => GenerateContent(() => { _ = AiService.ProcessPendingAsync(data, automatic: false); }), () => OpenPromptSettings(data), Notice, () => _aiSettingsDirty = true,              confirmSwitch: action => ShowCareerDialog("方案没有保存", "方案没有保存，确认切换吗？", () => { action(); return true; }, "确认切换",                  contents: content =>                  {                      var mark = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }; mark.AddThemeFontSizeOverride("font_size", 44); mark.AddThemeColorOverride("font_color", _gold); content.AddChild(mark);                  }, cancelText: "继续编辑"))`
- `NationalSpire.AiSettingsPanel.Columns(Godot.VBoxContainer)`；输入表达式：`AiSettingsPanel.Columns(box)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (matchBox, management) = AiSettingsPanel.Columns(box)`
- `NationalSpire.AiSettingsPanel.RivalLevelPicker(int, bool)`；输入表达式：`AiSettingsPanel.RivalLevelPicker(data.RivalLevel, _multiplayer != null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiSettingsPanel.RivalLevelPicker(data.RivalLevel, _multiplayer != null)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`；输入表达式：`CareerManagement(management)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerManagement(management);`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.ProcessPendingAsync(data, automatic: false); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.ProcessPendingAsync(data, automatic: false); })`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("rival-level", number: level)`；返回值紧邻使用处：`ExpressionStatementSyntax: MultiplayerCommand("rival-level", number: level);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("局内 AI 水平已保存。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("局内 AI 水平已保存。", false);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`；输入表达式：`OpenPromptSettings(data)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPromptSettings(data)`
- `NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；输入表达式：`SaveAiSettings(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveAiSettings(data);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("方案没有保存", "方案没有保存，确认切换吗？", () => { action(); return true; }, "确认切换",                  contents: content =>                  {                      var mark = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }; mark.AddThemeFontSizeOverride("font_size", 44); mark.AddThemeColorOverride("font_color", _gold); content.AddChild(mark);                  }, cancelText: "继续编辑")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: action => ShowCareerDialog("方案没有保存", "方案没有保存，确认切换吗？", () => { action(); return true; }, "确认切换",                  contents: content =>                  {                      var mark = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }; mark.AddThemeFontSizeOverride("font_size", 44); mark.AddThemeColorOverride("font_color", _gold); content.AddChild(mark);                  }, cancelText: "继续编辑")`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("各类选手用时同比调整，通关率不变。" + (data.PendingMatchId != null ? "本场结束后可修改。" : _multiplayer != null ? "由房主设置，全队同步。" : "对本生涯后续比赛生效。"), 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("各类选手用时同比调整，通关率不变。" + (data.PendingMatchId != null ? "本场结束后可修改。" : _multiplayer != null ? "由房主设置，全队同步。" : "对本生涯后续比赛生效。"), 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("局内 AI 水平", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("局内 AI 水平", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("AI 内容设置", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("AI 内容设置", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("AI 由主机统一生成，你无需配置服务或密钥。帖子、解说与周刊会自动同步。", 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("AI 由主机统一生成，你无需配置服务或密钥。帖子、解说与周刊会自动同步。", 20, _ink)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int)`；输入表达式：`MatchRules.SetRivalLevel(data, level)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.SetRivalLevel(data, level);`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPendingAsync(data, automatic: false)`
- `_aiSettingsDirty` = `false`
- `_aiSettingsDirty` = `true`
- `_aiStatus` = `AiSettingsPanel.Build(box, data.Ai,              () => { SaveAiSettings(data); AiService.RefreshConcurrency(data.Ai); },              () => GenerateContent(() => { _ = AiService.ProcessPendingAsync(data, automatic: false); }), () => OpenPromptSettings(data), Notice, () => _aiSettingsDirty = true,              confirmSwitch: action => ShowCareerDialog("方案没有保存", "方案没有保存，确认切换吗？", () => { action(); return true; }, "确认切换",                  contents: content =>                  {                      var mark = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }; mark.AddThemeFontSizeOverride("font_size", 44); mark.AddThemeColorOverride("font_color", _gold); content.AddChild(mark);                  }, cancelText: "继续编辑"))`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `levelPicker.Disabled` = `data.PendingMatchId != null || _multiplayer is { Host: false } || _multiplayer?.ProposalId.Length > 0`
- `levelPicker.ItemSelected` += `index =>          {              int level = levels[(int)index];              if (_multiplayer != null) { levelPicker.Select(LevelIndex()); MultiplayerCommand("rival-level", number: level); return; }              try { MatchRules.SetRivalLevel(data, level); CareerStore.Save(data); Notice("局内 AI 水平已保存。", false); }              catch (Exception e) { levelPicker.Select(LevelIndex()); Notice(e.Message, true); }          }`
- `Text` = `"◇"`
- `var (matchBox, management)` = `AiSettingsPanel.Columns(box)`

<a id="symbol-b2c1c96a3fb9"></a>

## `LevelIndex() — int LevelIndex()`

来源：源码第 1065 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** `System.Array.IndexOf<T>(T[], T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.RivalLevel`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(levels, data.RivalLevel)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Array.IndexOf(levels, data.RivalLevel) is var i`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b27d08d34395"></a>

## `NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer) — private void CareerManagement(VBoxContainer db)`

来源：源码第 1089 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** [`NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`](CareerSession.cs.md#symbol-a90f33a1d9ae)；[`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowDiagnosticFile(string)`](CareerSession.cs.md#symbol-b345ad92eddb)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.ExportDiagnostics()`](CareerStore.cs.md#symbol-bdb986450a1c)；[`NationalSpire.PlayerArchive.Invalidate()`](PlayerArchive.cs.md#symbol-2f435607cb43)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GD.PushWarning(string)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Exception.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._confirmReset`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.BeginNpcSetup(bool)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenCareerLibrary()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowDiagnosticFile(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStore.ExportDiagnostics()`；`NationalSpire.ICareerSession.Host`；`NationalSpire.PlayerArchive.Invalidate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("e9b09a")`；返回值紧邻使用处：`ArgumentSyntax: new Color("e9b09a")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("h_separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("h_separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("v_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("v_separation",8);`
- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning(e.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning(e.ToString());`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer {Columns=2,SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer {Columns=2,SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("切换、导入与导出生涯", OpenCareerLibrary, 208))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("切换、导入与导出生涯", OpenCareerLibrary, 208));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("刷新游戏战绩", () => { PlayerArchive.Invalidate(); Notice("游戏战绩已刷新。", false); }, 156))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("刷新游戏战绩", () => { PlayerArchive.Invalidate(); Notice("游戏战绩已刷新。", false); }, 156));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("重置当前生涯", () => { _confirmReset = true; Render(); }, 156))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("重置当前生涯", () => { _confirmReset = true; Render(); }, 156));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(export)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(export);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`confirm.AddChild(Button("取消", () => { _confirmReset = false; Render(); }, 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: confirm.AddChild(Button("取消", () => { _confirmReset = false; Render(); }, 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`confirm.AddChild(Button("确认重置生涯", () =>              {                  try { BeginNpcSetup(true); }                  catch (Exception e) { GD.PushWarning(e.ToString()); Notice("生涯未能重置，请检查存档文件夹的写入权限。", true); }              }, 210))`；返回值紧邻使用处：`ExpressionStatementSyntax: confirm.AddChild(Button("确认重置生涯", () =>              {                  try { BeginNpcSetup(true); }                  catch (Exception e) { GD.PushWarning(e.ToString()); Notice("生涯未能重置，请检查存档文件夹的写入权限。", true); }              }, 210));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`db.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: db.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`db.AddChild(Button("导入与导出生涯", OpenCareerLibrary, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: db.AddChild(Button("导入与导出生涯", OpenCareerLibrary, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`db.AddChild(confirm)`；返回值紧邻使用处：`ExpressionStatementSyntax: db.AddChild(confirm);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`db.AddChild(Text("生涯管理", 24, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: db.AddChild(Text("生涯管理", 24, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`db.AddChild(Text("重新开始生涯？当前赛程、人物、帖子和生涯奖励都会重置。旧生涯会先备份，原版战绩和 AI 设置保留。正在进行的对局将不再计入这段生涯。", 18, new Color("e9b09a")))`；返回值紧邻使用处：`ExpressionStatementSyntax: db.AddChild(Text("重新开始生涯？当前赛程、人物、帖子和生涯奖励都会重置。旧生涯会先备份，原版战绩和 AI 设置保留。正在进行的对局将不再计入这段生涯。", 18, new Color("e9b09a")));`
- `Godot.Node.GetChildren(bool)`；输入表达式：`actions.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: actions.GetChildren().OfType<Button>`
- `NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`；输入表达式：`AddMultiplayerReportButton(db)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddMultiplayerReportButton(db);`
- `NationalSpire.CareerScreen.BeginNpcSetup(bool)`；输入表达式：`BeginNpcSetup(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginNpcSetup(true);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导出问题报告", () => { try { ShowDiagnosticFile(CareerStore.ExportDiagnostics()); } catch (Exception e) { GD.PushWarning(e.ToString()); Notice("问题报告未能保存，请检查文件夹的写入权限。", true); } }, 156)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("导出问题报告", () => { try { ShowDiagnosticFile(CareerStore.ExportDiagnostics()); } catch (Exception e) { GD.PushWarning(e.ToString()); Notice("问题报告未能保存，请检查文件夹的写入权限。", true); } }, 156)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入与导出生涯", OpenCareerLibrary, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("导入与导出生涯", OpenCareerLibrary, 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("切换、导入与导出生涯", OpenCareerLibrary, 208)`；返回值紧邻使用处：`ArgumentSyntax: Button("切换、导入与导出生涯", OpenCareerLibrary, 208)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消", () => { _confirmReset = false; Render(); }, 120)`；返回值紧邻使用处：`ArgumentSyntax: Button("取消", () => { _confirmReset = false; Render(); }, 120)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("确认重置生涯", () =>              {                  try { BeginNpcSetup(true); }                  catch (Exception e) { GD.PushWarning(e.ToString()); Notice("生涯未能重置，请检查存档文件夹的写入权限。", true); }              }, 210)`；返回值紧邻使用处：`ArgumentSyntax: Button("确认重置生涯", () =>              {                  try { BeginNpcSetup(true); }                  catch (Exception e) { GD.PushWarning(e.ToString()); Notice("生涯未能重置，请检查存档文件夹的写入权限。", true); }              }, 210)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("刷新游戏战绩", () => { PlayerArchive.Invalidate(); Notice("游戏战绩已刷新。", false); }, 156)`；返回值紧邻使用处：`ArgumentSyntax: Button("刷新游戏战绩", () => { PlayerArchive.Invalidate(); Notice("游戏战绩已刷新。", false); }, 156)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("重置当前生涯", () => { _confirmReset = true; Render(); }, 156)`；返回值紧邻使用处：`ArgumentSyntax: Button("重置当前生涯", () => { _confirmReset = true; Render(); }, 156)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("生涯未能重置，请检查存档文件夹的写入权限。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("生涯未能重置，请检查存档文件夹的写入权限。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("问题报告未能保存，请检查文件夹的写入权限。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("问题报告未能保存，请检查文件夹的写入权限。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("游戏战绩已刷新。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("游戏战绩已刷新。", false);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowDiagnosticFile(string)`；输入表达式：`ShowDiagnosticFile(CareerStore.ExportDiagnostics())`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDiagnosticFile(CareerStore.ExportDiagnostics());`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("生涯管理", 24, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("生涯管理", 24, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("重新开始生涯？当前赛程、人物、帖子和生涯奖励都会重置。旧生涯会先备份，原版战绩和 AI 设置保留。正在进行的对局将不再计入这段生涯。", 18, new Color("e9b09a"))`；返回值紧邻使用处：`ArgumentSyntax: Text("重新开始生涯？当前赛程、人物、帖子和生涯奖励都会重置。旧生涯会先备份，原版战绩和 AI 设置保留。正在进行的对局将不再计入这段生涯。", 18, new Color("e9b09a"))`
- `NationalSpire.CareerStore.ExportDiagnostics()`；输入表达式：`CareerStore.ExportDiagnostics()`；返回值紧邻使用处：`ArgumentSyntax: CareerStore.ExportDiagnostics()`
- `NationalSpire.PlayerArchive.Invalidate()`；输入表达式：`PlayerArchive.Invalidate()`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerArchive.Invalidate();`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`actions.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var action in actions.GetChildren().OfType<Button>()) action.SizeFlagsHorizontal=SizeFlags.ExpandFill;`
- `System.Exception.ToString()`；输入表达式：`e.ToString()`；返回值紧邻使用处：`ArgumentSyntax: e.ToString()`

**赋值（含属性/字段和局部值）：**

- `_confirmReset` = `false`
- `_confirmReset` = `true`
- `action.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Columns` = `2`
- `export.TooltipText` = `"打包当前生涯、运行日志和近期 AI 对话，供反馈问题时附上。密钥会自动隐藏。"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-40a63c9955a7"></a>

## `NationalSpire.CareerScreen.AddHeading(string, string) — private void AddHeading(string title, string description)`

来源：源码第 1120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.ModernRules()`](CircuitScreen.cs.md#symbol-864cbf1e3904)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text(description, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text(description, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text(title, 30, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text(title, 30, _gold));`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(description, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(description, 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 30, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 30, _gold)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-04588f02c308"></a>

## `NationalSpire.CareerScreen.Notice(string, bool) — protected void Notice(string message, bool error)`

来源：源码第 1126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit()`](CareerLibraryScreen.cs.md#symbol-60cd55e373bd)；[`DeleteAsync()`](CareerLibraryScreen.cs.md#symbol-8515ac0a1b17)；[`Launch()`](CareerScreen.cs.md#symbol-9971cb44a804)；[`NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`](DateSceneMemoryScreen.cs.md#symbol-e85e0fc39965)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`](CareerSession.cs.md#symbol-a90f33a1d9ae)；[`NationalSpire.CareerScreen.AdvanceCareerDay()`](MarketScreen.cs.md#symbol-871f6318461f)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`](CareerScreen.cs.md#symbol-b27d08d34395)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.ConfirmCareerDeletion(string, int, string, System.Action, System.Func<System.Threading.Tasks.Task>?)`](CareerLibraryScreen.cs.md#symbol-9210e619e828)；[`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-f212593005f6)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.FinishPlan(string?)`](CalendarPlansScreen.cs.md#symbol-100b2aec3e40)；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](DateGameScreen.cs.md#symbol-60cf62536a73)；[`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.OpenProfileCreator()`](CharacterCardScreen.cs.md#symbol-ea7be3662f2e)；[`NationalSpire.CareerScreen.PrivateOathAttachment()`](ChatAttachmentScreen.cs.md#symbol-cefd5039c4e6)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)；[`NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-b0bc87216d33)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.ReportDiscussion(string, string)`](ArbitrationScreen.cs.md#symbol-4223b2b95c14)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.ShowDiagnosticFile(string)`](CareerSession.cs.md#symbol-b345ad92eddb)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`SaveDirty()`](DateScenePortraitSettings.cs.md#symbol-32b8805a9f1e)；[`Vote(int)`](CommunityScreen.cs.md#symbol-c7fecf2b615f)

**调用：** [`NationalSpire.CareerScreen.ShowPrivateCommandError(string)`](PrivateMessageScreen.cs.md#symbol-b6171f4aaa2c)；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)；`Godot.CanvasItem.Show()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._notice`；`NationalSpire.CareerScreen._noticeRemaining`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.ShowPrivateCommandError(string)`；`NationalSpire.PlayerFacingText.LongError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_notice.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _notice.Show();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f29b9b")`；返回值紧邻使用处：`ConditionalExpressionSyntax: error ? new Color("f29b9b") : _gold`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_notice.AddThemeColorOverride("font_color", error ? new Color("f29b9b") : _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: _notice.AddThemeColorOverride("font_color", error ? new Color("f29b9b") : _gold);`
- `NationalSpire.CareerScreen.ShowPrivateCommandError(string)`；输入表达式：`ShowPrivateCommandError(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowPrivateCommandError(message);`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(message)`；返回值紧邻使用处：`ConditionalExpressionSyntax: error ? PlayerFacingText.LongError(message) : message`

**赋值（含属性/字段和局部值）：**

- `_notice.Text` = `error ? PlayerFacingText.LongError(message) : message`
- `_noticeRemaining` = `error ? 0 : 4`

<a id="symbol-1542c756f2eb"></a>

## `NationalSpire.CareerScreen.Card() — private static PanelContainer Card()`

来源：源码第 1133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddScore(int)`](SettlementScreen.cs.md#symbol-b679d06f3022)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.AddSessionStatus(NationalSpire.ICareerSession)`](CareerSession.cs.md#symbol-74ce1c353daf)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.BoardNotice(string, string, string)`](CareerBoardsScreen.cs.md#symbol-837344ae2c72)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData, Godot.Container)`](CeremonyScreen.cs.md#symbol-071fb0b79ec4)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.CompetitionRules()`](CareerWorldScreen.cs.md#symbol-f461a145611c)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-5c9c29fc0844)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.ModernRules()`](CircuitScreen.cs.md#symbol-864cbf1e3904)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)；[`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-ddfd88d78cf2)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.SaveRow(Godot.VBoxContainer, string, string, string, bool, System.Func<string, System.Threading.Tasks.Task>, bool)`](CareerLibraryScreen.cs.md#symbol-ba7dbc5dacaa)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`PointsRule(string, string)`](CircuitScreen.cs.md#symbol-11515dfcbb43)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-c3c634913058)；[`Stat(string)`](ProfileScreen.cs.md#symbol-1c920dfaebbd)；[`Summary(string, decimal, decimal, Godot.Color)`](MarketScreen.cs.md#symbol-79a28ef9c10b)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`NationalSpire.BroadcastPanel.BroadcastPanel()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332"))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332"));`
- `NationalSpire.BroadcastPanel.BroadcastPanel()`；输入表达式：`new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142332")`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142332")`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-e9950886933d"></a>

## `NationalSpire.CareerScreen.Inner(Godot.PanelContainer) — private static VBoxContainer Inner(PanelContainer card)`

来源：源码第 1140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddScore(int)`](SettlementScreen.cs.md#symbol-b679d06f3022)；[`CardBody(string)`](ClubRosterScreen.cs.md#symbol-cda52497e13b)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddSessionStatus(NationalSpire.ICareerSession)`](CareerSession.cs.md#symbol-74ce1c353daf)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.BoardNotice(string, string, string)`](CareerBoardsScreen.cs.md#symbol-837344ae2c72)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.CompetitionRules()`](CareerWorldScreen.cs.md#symbol-f461a145611c)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int)`](CareerDashboard.cs.md#symbol-a0e5a4138c47)；[`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`](ChatAttachmentScreen.cs.md#symbol-bb34e71c1240)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-5c9c29fc0844)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.ModernRules()`](CircuitScreen.cs.md#symbol-864cbf1e3904)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)；[`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-ddfd88d78cf2)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`PointsRule(string, string)`](CircuitScreen.cs.md#symbol-11515dfcbb43)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-c3c634913058)；[`Stat(string)`](ProfileScreen.cs.md#symbol-1c920dfaebbd)；[`Summary(string, decimal, decimal, Godot.Color)`](MarketScreen.cs.md#symbol-79a28ef9c10b)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 9);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(box);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c08624e2a07c"></a>

## `NationalSpire.CareerScreen.Text(string, int, Godot.Color) — protected static Label Text(string text, int size, Color color)`

来源：源码第 1145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddScore(int)`](SettlementScreen.cs.md#symbol-b679d06f3022)；[`Cell(Godot.HBoxContainer, string, int, Godot.Color, int, bool)`](SettlementScreen.cs.md#symbol-580816a1e5fe)；[`Choice(string, string, System.Action)`](ChatManagementScreen.cs.md#symbol-318b4fbf31cb)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Field(Godot.Control, string, string, System.Action<string>, string)`](PortraitDesignScreen.cs.md#symbol-559316585c52)；[`Field(Godot.Control, string)`](CharacterCardScreen.cs.md#symbol-6f20abe83821)；[`Field(string, int, int, int, string)`](ChatManagementScreen.cs.md#symbol-e4c9cef415ba)；[`Field(string, int, int, int)`](PrivateMessageScreen.cs.md#symbol-d71483ba2ec2)；[`Field(string, int, string)`](RandomEventScreen.cs.md#symbol-c5dfd2e85a06)；[`Files()`](NpcGenerationScreen.cs.md#symbol-8686a8cedf62)；[`Line(string, int, Godot.Color)`](MatchArenaScreen.cs.md#symbol-dd5effa95879)；[`Line(string, string, System.Action<string>, string)`](PersonalityPoolScreen.cs.md#symbol-5d61565e1857)；[`Members()`](ConsumerPickerScreen.cs.md#symbol-cecffca41c86)；[`Memo(string, string, System.Action<string>, string)`](PersonalityPoolScreen.cs.md#symbol-b7c4b86135fa)；[`Metric(string, string, string, Godot.Color, bool)`](OwnedClubScreen.cs.md#symbol-b9ed96fa6cf3)；[`NationalSpire.CareerScreen.AchievementOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-f467edff90d1)；[`NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`](DateSceneMemoryScreen.cs.md#symbol-e85e0fc39965)；[`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)；[`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`](DateGameScreen.cs.md#symbol-ad300bbb552d)；[`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.AddLifeRepairNotices(NationalSpire.CareerData, Godot.VBoxContainer)`](LifeScreen.cs.md#symbol-e1843514c51a)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddSessionStatus(NationalSpire.ICareerSession)`](CareerSession.cs.md#symbol-74ce1c353daf)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.BoardNotice(string, string, string)`](CareerBoardsScreen.cs.md#symbol-837344ae2c72)；[`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`](FixtureScheduleScreen.cs.md#symbol-1daead3fab8e)；[`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?)`](AppearanceLibraryScreen.cs.md#symbol-c3f5843ac40d)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`](CareerScreen.cs.md#symbol-b27d08d34395)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData, Godot.Container)`](CeremonyScreen.cs.md#symbol-071fb0b79ec4)；[`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`](CeremonyScreen.cs.md#symbol-746b7a635071)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.ChatManageDialog()`](ChatManagementScreen.cs.md#symbol-785feea0fa06)；[`NationalSpire.CareerScreen.ChatSettingsMenu()`](ChatManagementScreen.cs.md#symbol-282c1fec9c65)；[`NationalSpire.CareerScreen.ChoiceField(Godot.Container, string)`](CareerClubPresentation.cs.md#symbol-13fc3204a4de)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubBrandOffers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](CareerClubPresentation.cs.md#symbol-7094bac60c25)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.ClubEntry(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-cebea5b172ab)；[`NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-2eeae75151b7)；[`NationalSpire.CareerScreen.ClubLeaveDialog()`](ClubDepartureScreen.cs.md#symbol-6954ceb20cdf)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.ClubWeeklyFinance(Godot.VBoxContainer, NationalSpire.OwnedSponsor?, int, decimal, int)`](OwnedClubScreen.cs.md#symbol-e4836a392d68)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.CompetitionRules()`](CareerWorldScreen.cs.md#symbol-f461a145611c)；[`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)；[`NationalSpire.CareerScreen.ConfirmCareerDeletion(string, int, string, System.Action, System.Func<System.Threading.Tasks.Task>?)`](CareerLibraryScreen.cs.md#symbol-9210e619e828)；[`NationalSpire.CareerScreen.ConfirmDateHistoryInput()`](DateHistoryReplayScreen.cs.md#symbol-e9d44f3bf0bb)；[`NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>)`](PortraitPackageImportScreen.cs.md#symbol-af6372ed4930)；[`NationalSpire.CareerScreen.ConfirmPromptImport(NationalSpire.CareerData, string, System.Action)`](PromptScreen.cs.md#symbol-b9da8509093b)；[`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`](ConsumerPickerScreen.cs.md#symbol-e5ebf63e6d3e)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)；[`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-28983a9b63fd)；[`NationalSpire.CareerScreen.Dot(Godot.Control)`](CareerDashboard.cs.md#symbol-15e9bc391bf6)；[`NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`](PortraitStyleScreen.cs.md#symbol-f030328fcc3e)；[`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.FixtureDetails(NationalSpire.CareerData, NationalSpire.CompetitionDuel)`](SettlementScreen.cs.md#symbol-432510bdd12f)；[`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.LeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CareerBoardsScreen.cs.md#symbol-8456ab4b34a8)；[`NationalSpire.CareerScreen.LegacyLeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-56f2bf2ccf4f)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string, string?)`](MatchArenaScreen.cs.md#symbol-c4eb3ccea4ca)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.Matchup(NationalSpire.CareerData, NationalSpire.CareerMatch)`](BroadcastVisuals.cs.md#symbol-dc5a27245e42)；[`NationalSpire.CareerScreen.Metric(Godot.HBoxContainer, string, string, string)`](CareerScreen.cs.md#symbol-5c9c29fc0844)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.ModernRules()`](CircuitScreen.cs.md#symbol-864cbf1e3904)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>, System.Action<string[]>?)`](CareerFilePicker.cs.md#symbol-ff4f80838b9c)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool, string)`](NpcGenerationScreen.cs.md#symbol-7f1e60697c26)；[`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool, string)`](PeoplePickerScreen.cs.md#symbol-bb0e3159d994)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData, string?)`](CoachScreen.cs.md#symbol-a537f69fc7d9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)；[`NationalSpire.CareerScreen.PracticeRules(Godot.Container)`](CareerClubPresentation.cs.md#symbol-e9f9acda2cd5)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateLineupPicker()`](CoachScreen.cs.md#symbol-78315f2693ca)；[`NationalSpire.CareerScreen.PrivateMatchPicker()`](PrivateMessageScreen.cs.md#symbol-aa7339f37b26)；[`NationalSpire.CareerScreen.PrivateSettings()`](PrivateMessageScreen.cs.md#symbol-e86e401f7314)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.PrivateTrainingPicker()`](CoachScreen.cs.md#symbol-2609d8a7ba68)；[`NationalSpire.CareerScreen.ProactiveChatDialog()`](ChatManagementScreen.cs.md#symbol-f9397f5fb6b7)；[`NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`](ProfileScreen.cs.md#symbol-69bc6ca2a621)；[`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-578cf06bda89)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.RailCount(Godot.Button)`](CareerDashboard.cs.md#symbol-980545ae56ef)；[`NationalSpire.CareerScreen.RandomEventSettings()`](RandomEventScreen.cs.md#symbol-6c1195d3802b)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RefreshPrivateProposal()`](PrivateMessageScreen.cs.md#symbol-fcf77d9c4194)；[`NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-b0bc87216d33)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)；[`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-ddfd88d78cf2)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.ReportDiscussion(string, string)`](ArbitrationScreen.cs.md#symbol-4223b2b95c14)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)；[`NationalSpire.CareerScreen.ShowAttendanceChoices(bool, System.Action<bool>)`](DateSceneScreen.cs.md#symbol-edff9abeda12)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.StatStrip(Godot.Container, Godot.Color, params (string Title, string Value)[])`](CareerClubPresentation.cs.md#symbol-b07f4ae318bc)；[`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`Number(Godot.HBoxContainer, string, string)`](DateScenePortraitSettings.cs.md#symbol-86a9f11c1f70)；[`PointsRule(string, string)`](CircuitScreen.cs.md#symbol-11515dfcbb43)；[`Preview(string, string)`](PromptTestScreen.cs.md#symbol-d9ae57cb97e1)；[`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-14ef851f121d)；[`Refresh()`](ConsumerPickerScreen.cs.md#symbol-5ea2a34a3129)；[`Reward(string, string, string)`](SettlementScreen.cs.md#symbol-bedc2a0e9320)；[`Section(Godot.Container, string, string, string, System.Action, System.Action<Godot.HBoxContainer>?)`](CareerScreen.cs.md#symbol-fed969ea23f7)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-c3c634913058)；[`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`](SettlementScreen.cs.md#symbol-ba1a6d1e9b72)；[`Summary(string, decimal, decimal, Godot.Color)`](MarketScreen.cs.md#symbol-79a28ef9c10b)；[`Terms(Godot.VBoxContainer, NationalSpire.SponsorContract, bool)`](CircuitScreen.cs.md#symbol-f6f24e76befe)；[`WeddingChoices()`](ConsumerPickerScreen.cs.md#symbol-744c8ab57890)；[`Weight(string, double, System.Action<double>)`](PersonalityPoolScreen.cs.md#symbol-80f94d60cee5)；[`Weights()`](NpcGenerationScreen.cs.md#symbol-293317477bcb)

**调用：** [`NationalSpire.CareerMoney.Display(string)`](LifeData.cs.md#symbol-4a2afc43261a)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Display(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", color)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", color);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeConstantOverride("line_spacing", 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeConstantOverride("line_spacing", 3);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", size);`
- `Godot.Label.Label()`；输入表达式：`new Label { MouseFilter = MouseFilterEnum.Ignore, Text = CareerMoney.Display(text), AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { MouseFilter = MouseFilterEnum.Ignore, Text = CareerMoney.Display(text), AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = CareerMoney.Display(text)`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `CareerMoney.Display(text)`

<a id="symbol-716373f2517f"></a>

## `NationalSpire.CareerScreen.Button(string, System.Action, float) — protected static Button Button(string text, Action action, float width = 0)`

来源：源码第 1154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-09d945672cca)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Files()`](NpcGenerationScreen.cs.md#symbol-8686a8cedf62)；[`Gallery()`](AvatarScreen.cs.md#symbol-c2473d06e9db)；[`ImportPackage(string, System.Action?)`](DateSceneAssetScreen.cs.md#symbol-b036d6d393e7)；[`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)；[`NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`](CareerSession.cs.md#symbol-a90f33a1d9ae)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?)`](AppearanceLibraryScreen.cs.md#symbol-c3f5843ac40d)；[`NationalSpire.CareerScreen.CareerManagement(Godot.VBoxContainer)`](CareerScreen.cs.md#symbol-b27d08d34395)；[`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData, Godot.Container)`](CeremonyScreen.cs.md#symbol-071fb0b79ec4)；[`NationalSpire.CareerScreen.ClubButton(string, System.Action, int)`](OwnedClubScreen.cs.md#symbol-745c5ca62e51)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>)`](PortraitPackageImportScreen.cs.md#symbol-af6372ed4930)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`](ConsumerPickerScreen.cs.md#symbol-e5ebf63e6d3e)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`](PortraitStyleScreen.cs.md#symbol-f030328fcc3e)；[`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`](RandomEventScreen.cs.md#symbol-e27dca18c72a)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.JourneyResumeButton(NationalSpire.CareerData, Godot.VBoxContainer)`](EventJourneyScreen.cs.md#symbol-a869d888b335)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>, System.Action<string[]>?)`](CareerFilePicker.cs.md#symbol-ff4f80838b9c)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool, string)`](NpcGenerationScreen.cs.md#symbol-7f1e60697c26)；[`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-ddfd88d78cf2)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.ShowDueAppointments()`](EventJourneyScreen.cs.md#symbol-0633783689c3)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`](CareerSession.cs.md#symbol-a13f3923812a)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-14ef851f121d)；[`Section(string)`](CharacterCardScreen.cs.md#symbol-8f9ff7ef0f6a)；[`Vote(string, string, int)`](CareerSession.cs.md#symbol-aa31b21a8cf9)

**调用：** [`NationalSpire.CareerMoney.Display(string)`](LifeData.cs.md#symbol-4a2afc43261a)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Display(string)`；`NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(width, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(width, 48)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text = CareerMoney.Display(text), CustomMinimumSize = new Vector2(width, 48), FocusMode = FocusModeEnum.All, SizeFlagsHorizontal = SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text = CareerMoney.Display(text), CustomMinimumSize = new Vector2(width, 48), FocusMode = FocusModeEnum.All, SizeFlagsHorizontal = SizeFlags.ShrinkBegin }`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = CareerMoney.Display(text)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new Vector2(width, 48)`
- `FocusMode` = `FocusModeEnum.All`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `Text` = `CareerMoney.Display(text)`

<a id="symbol-bfadad1b0324"></a>

## `NationalSpire.SpireBackdrop._Ready() — public override void _Ready()`

来源：源码第 1166 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2592c5db08f5"></a>

## `NationalSpire.SpireBackdrop._Draw() — public override void _Draw()`

来源：源码第 1167 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Random.NextSingle()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(new Vector2(w * .87f, h * .24f), 150, 0, Mathf.Tau, 80, new Color(0.91f, 0.76f, 0.45f, 0.13f), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(new Vector2(w * .87f, h * .24f), 150, 0, Mathf.Tau, 80, new Color(0.91f, 0.76f, 0.45f, 0.13f), 2);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(pos, i % 9 == 0 ? 2.2f : 1.1f, new Color(0.95f, 0.86f, 0.65f, i % 9 == 0 ? 0.42f : 0.18f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(pos, i % 9 == 0 ? 2.2f : 1.1f, new Color(0.95f, 0.86f, 0.65f, i % 9 == 0 ? 0.42f : 0.18f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(mountain, new Color("142436"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(mountain, new Color("142436"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(w * .87f, h * .14f), new Vector2(w * .87f, h * .73f), new Color("766646"), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(w * .87f, h * .14f), new Vector2(w * .87f, h * .73f), new Color("766646"), 2);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(x, 0), new Vector2(x - 180, h), new Color(0.45f, 0.52f, 0.58f, 0.06f), 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(x, 0), new Vector2(x - 180, h), new Color(0.45f, 0.52f, 0.58f, 0.06f), 1);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color("0c1623"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color("0c1623"));`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0.45f, 0.52f, 0.58f, 0.06f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(0.45f, 0.52f, 0.58f, 0.06f)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0.91f, 0.76f, 0.45f, 0.13f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(0.91f, 0.76f, 0.45f, 0.13f)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0.95f, 0.86f, 0.65f, i % 9 == 0 ? 0.42f : 0.18f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(0.95f, 0.86f, 0.65f, i % 9 == 0 ? 0.42f : 0.18f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0c1623")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0c1623")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("142436")`；返回值紧邻使用处：`ArgumentSyntax: new Color("142436")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("766646")`；返回值紧邻使用处：`ArgumentSyntax: new Color("766646")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(stars.NextSingle() * w, stars.NextSingle() * h * .75f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(stars.NextSingle() * w, stars.NextSingle() * h * .75f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .62f, h)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new Vector2(w * .62f, h), new Vector2(w * .73f, h * .27f), new Vector2(w * .78f, h * .58f), new Vector2(w * .87f, h * .14f), new Vector2(w, h) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .73f, h * .27f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new Vector2(w * .62f, h), new Vector2(w * .73f, h * .27f), new Vector2(w * .78f, h * .58f), new Vector2(w * .87f, h * .14f), new Vector2(w, h) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .78f, h * .58f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new Vector2(w * .62f, h), new Vector2(w * .73f, h * .27f), new Vector2(w * .78f, h * .58f), new Vector2(w * .87f, h * .14f), new Vector2(w, h) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .87f, h * .14f)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .87f, h * .14f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .87f, h * .14f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new Vector2(w * .62f, h), new Vector2(w * .73f, h * .27f), new Vector2(w * .78f, h * .58f), new Vector2(w * .87f, h * .14f), new Vector2(w, h) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .87f, h * .24f)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .87f, h * .24f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .87f, h * .73f)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .87f, h * .73f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w, h)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new Vector2(w * .62f, h), new Vector2(w * .73f, h * .27f), new Vector2(w * .78f, h * .58f), new Vector2(w * .87f, h * .14f), new Vector2(w, h) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x - 180, h)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(x - 180, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, 0)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(x, 0)`
- `System.Random.NextSingle()`；输入表达式：`stars.NextSingle()`；返回值紧邻使用处：`BinaryExpressionSyntax: stars.NextSingle() * h`
- `System.Random.NextSingle()`；输入表达式：`stars.NextSingle()`；返回值紧邻使用处：`BinaryExpressionSyntax: stars.NextSingle() * w`
- `System.Random.Random(int)`；输入表达式：`new Random(71)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(71)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e6a1cf7239af"></a>

## `NationalSpire.ResultChart.Results — public List<CareerResult> Results`

来源：源码第 1191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cf447bab1c4a"></a>

## `NationalSpire.ResultChart._Draw() — public override void _Draw()`

来源：源码第 1193 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.Win`；`NationalSpire.ResultChart.Results`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(left, bottom), new Vector2(right, bottom), new Color("526174"), 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(left, bottom), new Vector2(right, bottom), new Color("526174"), 1);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(left, y), new Vector2(right, y), new Color(1, 1, 1, 0.07f), 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(left, y), new Vector2(right, y), new Color(1, 1, 1, 0.07f), 1);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(left + i * slot + slot * .18f, bottom - height, slot * .64f, height), color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(left + i * slot + slot * .18f, bottom - height, slot * .64f, height), color);`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, 0.07f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(1, 1, 1, 0.07f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("526174")`；返回值紧邻使用处：`ArgumentSyntax: new Color("526174")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("5b8098")`；返回值紧邻使用处：`ConditionalExpressionSyntax: result.Win ? new Color("efc777") : new Color("5b8098")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("efc777")`；返回值紧邻使用处：`ConditionalExpressionSyntax: result.Win ? new Color("efc777") : new Color("5b8098")`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(left + i * slot + slot * .18f, bottom - height, slot * .64f, height)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(left + i * slot + slot * .18f, bottom - height, slot * .64f, height)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(left, bottom)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(left, bottom)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(left, y)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(left, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(right, bottom)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(right, bottom)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(right, y)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(right, y)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(result.Floor / 55f, 0.03f, 1f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: result.Win ? 1f : Math.Clamp(result.Floor / 55f, 0.03f, 1f)`

**赋值（含属性/字段和局部值）：**
