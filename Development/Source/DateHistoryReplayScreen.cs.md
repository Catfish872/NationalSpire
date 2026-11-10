# DateHistoryReplayScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`63AD8FA1159AF4F873C7FD2879972C4C3ADCEB27F971726CF194E44C37A56AD3`。来源：[源码](../../DateHistoryReplayScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
protected PrivateTurn? _dateHistoryTurn;
protected List<DateSceneLine> _dateHistoryLines = [];
protected int _dateHistoryIndex;
private Button? _dateHistoryReturn;
```

<a id="symbol-ee12d7e844a1"></a>

## `NationalSpire.CareerScreen.DateHistoryCursor() — private (string Turn, int Index) DateHistoryCursor()`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateHistoryIndex`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5cbf74282e4b"></a>

## `NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn) — private static bool DateHistoryHasInput(PrivateTurn turn)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-989c9d87cc4f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.JumpDateHistory(string)`](DateHistoryReplayScreen.cs.md#symbol-7a7ba1016ab5)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7558f6f313ac"></a>

## `NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn) — private static bool DateHistoryHasReply(PrivateTurn turn)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-989c9d87cc4f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.JumpDateHistory(string)`](DateHistoryReplayScreen.cs.md#symbol-7a7ba1016ab5)

**调用：** [`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)

**字段、属性、事件及方法组引用：** `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(turn)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateScenes.Lines(turn).Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7a7ba1016ab5"></a>

## `NationalSpire.CareerScreen.JumpDateHistory(string) — private void JumpDateHistory(string id)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-989c9d87cc4f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** `Godot.CanvasItem.Show()`；[`NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`](DateHistoryReplayScreen.cs.md#symbol-5cbf74282e4b)；[`NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`](DateHistoryReplayScreen.cs.md#symbol-7558f6f313ac)；[`NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`](CareerScreenExtensions.cs.md#symbol-a2e85e8c1bbb)；[`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`](DateHistoryReplayScreen.cs.md#symbol-9cf8a8172aa4)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`；`NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`；`NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateHistoryIndex`；`NationalSpire.CareerScreen._dateHistoryLines`；`NationalSpire.CareerScreen._dateHistoryReturn`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`.Show()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateHistoryReturn?.Show()`
- `NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`；输入表达式：`DateHistoryHasInput(turn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateHistoryHasInput(turn)`
- `NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`；输入表达式：`DateHistoryHasInput(turn)`；返回值紧邻使用处：`ConditionalExpressionSyntax: DateHistoryHasInput(turn) ? -1 : 0`
- `NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`；输入表达式：`DateHistoryHasReply(turn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateHistoryHasReply(turn)`
- `NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`；输入表达式：`DateHistoryHasReply(turn)`；返回值紧邻使用处：`ConditionalExpressionSyntax: DateHistoryHasReply(turn) ? DateScenes.Lines(turn) : []`
- `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；输入表达式：`DatePlaybackInterrupted()`；返回值紧邻使用处：`ExpressionStatementSyntax: DatePlaybackInterrupted();`
- `NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`；输入表达式：`ShowDateHistoryPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateHistoryPage();`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(turn)`；返回值紧邻使用处：`ConditionalExpressionSyntax: DateHistoryHasReply(turn) ? DateScenes.Lines(turn) : []`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.FirstOrDefault(t => t.Id == id && t.Scene?.OfferId == _dateOffer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Turns.FirstOrDefault(t => t.Id == id && t.Scene?.OfferId == _dateOffer)`

**赋值（含属性/字段和局部值）：**

- `_dateHistoryIndex` = `DateHistoryHasInput(turn) ? -1 : 0`
- `_dateHistoryLines` = `DateHistoryHasReply(turn) ? DateScenes.Lines(turn) : []`
- `_dateHistoryTurn` = `turn`

<a id="symbol-9cf8a8172aa4"></a>

## `NationalSpire.CareerScreen.ShowDateHistoryPage(bool) — private void ShowDateHistoryPage(bool notify = true)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-989c9d87cc4f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.JumpDateHistory(string)`](DateHistoryReplayScreen.cs.md#symbol-7a7ba1016ab5)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.ApplyDateHistoryBackground()`](DateHistoryReplayScreen.cs.md#symbol-7fde49dd3258)；[`NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`](DateSceneScreen.cs.md#symbol-270cb56b5044)；[`NationalSpire.CareerScreen.DateLineShown(NationalSpire.DateSceneLine, string?, int)`](CareerScreenExtensions.cs.md#symbol-476eceb6dba4)；[`NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`](CareerScreenExtensions.cs.md#symbol-a2e85e8c1bbb)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；`NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`](DateSceneView.cs.md#symbol-1801b5d93aa1)；[`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`](DateSceneCast.cs.md#symbol-35177f2945fc)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ApplyDateHistoryBackground()`；`NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`；`NationalSpire.CareerScreen.DateLineShown(NationalSpire.DateSceneLine, string?, int)`；`NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；`NationalSpire.CareerScreen.PartyTexture(string, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateHistoryIndex`；`NationalSpire.CareerScreen._dateHistoryLines`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneView.EditPreviousButton`；`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`；`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Streaming(bool)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, speaker)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(ViewData, speaker)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(ViewData)`
- `NationalSpire.CareerScreen.ApplyDateHistoryBackground()`；输入表达式：`ApplyDateHistoryBackground()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDateHistoryBackground();`
- `NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`；输入表达式：`CanEditPreviousDate(_dateHistoryTurn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanEditPreviousDate(_dateHistoryTurn)`
- `NationalSpire.CareerScreen.DateLineShown(NationalSpire.DateSceneLine, string?, int)`；输入表达式：`DateLineShown(_dateHistoryLines[_dateHistoryIndex], _dateHistoryTurn.Id, _dateHistoryIndex)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateLineShown(_dateHistoryLines[_dateHistoryIndex], _dateHistoryTurn.Id, _dateHistoryIndex);`
- `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；输入表达式：`DatePlaybackInterrupted()`；返回值紧邻使用处：`ExpressionStatementSyntax: DatePlaybackInterrupted();`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(_datePerson, _dateDesign!.DefaultEmotionId)`；返回值紧邻使用处：`ArgumentSyntax: PartyTexture(_datePerson, _dateDesign!.DefaultEmotionId)`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(speaker, line.Emotion)`；返回值紧邻使用处：`ArgumentSyntax: PartyTexture(speaker, line.Emotion)`
- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Text = _dateHistoryTurn.User, Speaker = _datePerson }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = _dateHistoryTurn.User, Speaker = _datePerson }`
- `NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`；输入表达式：`_dateView.ShowLine(new() { Text = _dateHistoryTurn.User, Speaker = _datePerson }, CareerEngine.Name(ViewData), PartyTexture(_datePerson, _dateDesign!.DefaultEmotionId))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowLine(new() { Text = _dateHistoryTurn.User, Speaker = _datePerson }, CareerEngine.Name(ViewData), PartyTexture(_datePerson, _dateDesign!.DefaultEmotionId));`
- `NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`；输入表达式：`_dateView.ShowRoundLine(_dateHistoryLines, _dateHistoryIndex, CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowRoundLine(_dateHistoryLines, _dateHistoryIndex, CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion));`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_dateView.Streaming(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Streaming(false);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_datePartyArt.ContainsKey(line.Speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson`

**赋值（含属性/字段和局部值）：**

- `Speaker` = `_datePerson`
- `Text` = `_dateHistoryTurn.User`
- `_dateView.EditPreviousButton.Disabled` = `_dateHistoryTurn.Status != "complete" || !CanEditPreviousDate(_dateHistoryTurn) || _dateHistoryTurn.Scene!.GameEvent.Length > 0`
- `_dateView.Status.Text` = `"历史回放 · 点击继续查看已保存的对话"`

<a id="symbol-7fde49dd3258"></a>

## `NationalSpire.CareerScreen.ApplyDateHistoryBackground() — private void ApplyDateHistoryBackground()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`](DateHistoryReplayScreen.cs.md#symbol-9cf8a8172aa4)

**调用：** [`NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`](DateSceneBackgrounds.cs.md#symbol-0f51af8c0e19)；[`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateHistoryIndex`；`NationalSpire.CareerScreen._dateHistoryLines`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneAssets.AutoBackground`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneView.Background(string, bool, double)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`；输入表达式：`DateSceneBackgrounds.At(_dateBackgrounds, _dateHistoryLines, _dateHistoryIndex, _dateHistoryTurn.Scene!.CurrentBackground, "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: id = DateSceneBackgrounds.At(_dateBackgrounds, _dateHistoryLines, _dateHistoryIndex, _dateHistoryTurn.Scene!.CurrentBackground, "")`
- `NationalSpire.DateSceneView.Background(string, bool, double)`；输入表达式：`_dateView.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == id)?.Image ?? "", true, _dateAssets.BlurAmount)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == id)?.Image ?? "", true, _dateAssets.BlurAmount);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.FirstOrDefault(b => b.Id == id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateBackgrounds.FirstOrDefault(b => b.Id == id)?.Image`

**赋值（含属性/字段和局部值）：**

- `_dateView.Status.Text` = `e.Message`
- `id` = `DateSceneBackgrounds.At(_dateBackgrounds, _dateHistoryLines, _dateHistoryIndex, _dateHistoryTurn.Scene!.CurrentBackground, "")`

<a id="symbol-989c9d87cc4f"></a>

## `NationalSpire.CareerScreen.AdvanceDateHistory() — private void AdvanceDateHistory()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)

**调用：** [`NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`](DateHistoryReplayScreen.cs.md#symbol-5cbf74282e4b)；[`NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`](DateHistoryReplayScreen.cs.md#symbol-7558f6f313ac)；[`NationalSpire.CareerScreen.FinishDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-fe282030be0f)；[`NationalSpire.CareerScreen.JumpDateHistory(string)`](DateHistoryReplayScreen.cs.md#symbol-7a7ba1016ab5)；[`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`](DateHistoryReplayScreen.cs.md#symbol-9cf8a8172aa4)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`；`NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`；`NationalSpire.CareerScreen.FinishDateHistory()`；`NationalSpire.CareerScreen.JumpDateHistory(string)`；`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateHistoryIndex`；`NationalSpire.CareerScreen._dateHistoryLines`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DateHistoryHasInput(NationalSpire.PrivateTurn)`；输入表达式：`DateHistoryHasInput(turn)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateHistoryHasInput(turn) || DateHistoryHasReply(turn)`
- `NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`；输入表达式：`DateHistoryHasReply(turn)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateHistoryHasInput(turn) || DateHistoryHasReply(turn)`
- `NationalSpire.CareerScreen.FinishDateHistory()`；输入表达式：`FinishDateHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishDateHistory();`
- `NationalSpire.CareerScreen.JumpDateHistory(string)`；输入表达式：`JumpDateHistory(next.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: JumpDateHistory(next.Id);`
- `NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`；输入表达式：`ShowDateHistoryPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateHistoryPage();`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`turns.Skip(current + 1).FirstOrDefault(turn => turn.Scene?.OfferId == _dateOffer && (DateHistoryHasInput(turn) || DateHistoryHasReply(turn)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turns.Skip(current + 1).FirstOrDefault(turn => turn.Scene?.OfferId == _dateOffer && (DateHistoryHasInput(turn) || DateHistoryHasReply(turn)))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`turns.Skip(current + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turns.Skip(current + 1).FirstOrDefault`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`turns.FindIndex(turn => turn.Id == _dateHistoryTurn?.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turns.FindIndex(turn => turn.Id == _dateHistoryTurn?.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fe282030be0f"></a>

## `NationalSpire.CareerScreen.FinishDateHistory() — private void FinishDateHistory()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-989c9d87cc4f)

**调用：** [`NationalSpire.CareerScreen.ClearDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-7d3932131466)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ClearDateHistory()`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateSource`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ClearDateHistory()`；输入表达式：`ClearDateHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearDateHistory();`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput();`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(System.Text.Encoding.UTF8.GetBytes(latest.Reply))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateReply = DateSceneAssetStore.Hash(System.Text.Encoding.UTF8.GetBytes(latest.Reply))`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets!.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(latest)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateLines = DateScenes.Lines(latest)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault(turn => turn.Scene?.OfferId == _dateOffer && !turn.ReplyDeleted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault(turn => turn.Scene?.OfferId == _dateOffer && !turn.ReplyDeleted)`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`System.Text.Encoding.UTF8.GetBytes(latest.Reply)`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Encoding.UTF8.GetBytes(latest.Reply)`

**赋值（含属性/字段和局部值）：**

- `Index` = `_dateIndex`
- `ReplyHash` = `_dateReply`
- `Turn` = `_dateTurn`
- `_dateAssets!.Bookmarks[_dateOffer]` = `new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `_dateIndex` = `_dateLines.Count`
- `_dateInitialBackground` = `latest.Scene?.CurrentBackground ?? ""`
- `_dateLines` = `DateScenes.Lines(latest)`
- `_dateReply` = `DateSceneAssetStore.Hash(System.Text.Encoding.UTF8.GetBytes(latest.Reply))`
- `_dateSource` = `latest.Reply`
- `_dateState` = `""`
- `_dateState` = `"complete"`
- `_dateTurn` = `latest.Id`
- `_dateView.Status.Text` = `"播放进度保存失败：" + e.Message`

<a id="symbol-7d3932131466"></a>

## `NationalSpire.CareerScreen.ClearDateHistory() — private void ClearDateHistory()`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FinishDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-fe282030be0f)；[`NationalSpire.CareerScreen.ReturnFromDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-5fa807ec8766)

**调用：** `Godot.CanvasItem.Hide()`；[`NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`](CareerScreenExtensions.cs.md#symbol-a2e85e8c1bbb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；`NationalSpire.CareerScreen._dateHistoryLines`；`NationalSpire.CareerScreen._dateHistoryReturn`；`NationalSpire.CareerScreen._dateHistoryTurn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateHistoryReturn?.Hide()`
- `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；输入表达式：`DatePlaybackInterrupted()`；返回值紧邻使用处：`ExpressionStatementSyntax: DatePlaybackInterrupted();`

**赋值（含属性/字段和局部值）：**

- `_dateHistoryLines` = `[]`
- `_dateHistoryTurn` = `null`

<a id="symbol-5fa807ec8766"></a>

## `NationalSpire.CareerScreen.ReturnFromDateHistory() — private void ReturnFromDateHistory()`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerScreen.ClearDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-7d3932131466)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateSceneView.GoBack()`](DateSceneView.cs.md#symbol-c97afbe9881b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ClearDateHistory()`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneView.GoBack()`；`NationalSpire.DateSceneView.HistoryOpen`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ClearDateHistory()`；输入表达式：`ClearDateHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearDateHistory();`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput();`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.DateSceneView.GoBack()`；输入表达式：`_dateView.GoBack()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.GoBack();`

**赋值（含属性/字段和局部值）：**

- `_dateState` = `""`

<a id="symbol-e9d44f3bf0bb"></a>

## `NationalSpire.CareerScreen.ConfirmDateHistoryInput() — private void ConfirmDateHistoryInput()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditPreviousDateScene()`](DateSceneScreen.cs.md#symbol-68bbfe92ebcf)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`](CareerScreenExtensions.cs.md#symbol-a2e85e8c1bbb)；[`NationalSpire.CareerScreen.EditPreviousDateScene()`](DateSceneScreen.cs.md#symbol-68bbfe92ebcf)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.SyncDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-4103852c245a)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Action.Invoke()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`long.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；`NationalSpire.CareerScreen.EditPreviousDateScene()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SaveDateMemory(bool)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.SyncDateMemory()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateHistoryLines`；`NationalSpire.CareerScreen._dateHistoryReturn`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateKey`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Replacement`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateHistoryReturn?.Hide()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool)`；输入表达式：`DatePlaybackInterrupted(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DatePlaybackInterrupted(true);`
- `NationalSpire.CareerScreen.EditPreviousDateScene()`；输入表达式：`EditPreviousDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: EditPreviousDateScene();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-rewind", command, () => { _multiplayer?.Refresh(); _cancelDialog?.Invoke(); if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return; _dateHistoryTurn = null; _dateHistoryLines = []; _dateHistoryReturn?.Hide(); DatePlaybackInterrupted(true); _dateEditingTurn = ""; _dateState = ""; _dateLines = []; _dateIndex = 0; _dateAssets?.Bookmarks.Remove(offer); _privateDrafts.Remove(person); SyncDateMemory(); SaveDateMemory(); EditPreviousDateScene(); }, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-rewind", command, () => { _multiplayer?.Refresh(); _cancelDialog?.Invoke(); if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return; _dateHistoryTurn = null; _dateHistoryLines = []; _dateHistoryReturn?.Hide(); DatePlaybackInterrupted(true); _dateEditingTurn = ""; _dateState = ""; _dateLines = []; _dateIndex = 0; _dateAssets?.Bookmarks.Remove(offer); _privateDrafts.Remove(person); SyncDateMemory(); SaveDateMemory(); EditPreviousDateScene(); }, person);`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("从这里重新输入？", "这里使用重新输入会跳回到之前的对话内容，这一段已有的回复以及之后已经发生的对话将消失。确认后返回当时的输入界面。", () => { if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return true; PrivateCommand("dm-date-rewind", command, () => { _multiplayer?.Refresh(); _cancelDialog?.Invoke(); if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return; _dateHistoryTurn = null; _dateHistoryLines = []; _dateHistoryReturn?.Hide(); DatePlaybackInterrupted(true); _dateEditingTurn = ""; _dateState = ""; _dateLines = []; _dateIndex = 0; _dateAssets?.Bookmarks.Remove(offer); _privateDrafts.Remove(person); SyncDateMemory(); SaveDateMemory(); EditPreviousDateScene(); }, person); return false; }, "确认并返回输入", box => { var error = Text("", 17, _muted); error.Name = "DateAttendanceError"; box.AddChild(error); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("从这里重新输入？", "这里使用重新输入会跳回到之前的对话内容，这一段已有的回复以及之后已经发生的对话将消失。确认后返回当时的输入界面。", () => { if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return true; PrivateCommand("dm-date-rewind", command, () => { _multiplayer?.Refresh(); _cancelDialog?.Invoke(); if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return; _dateHistoryTurn = null; _dateHistoryLines = []; _dateHistoryReturn?.Hide(); DatePlaybackInterrupted(true); _dateEditingTurn = ""; _dateState = ""; _dateLines = []; _dateIndex = 0; _dateAssets?.Bookmarks.Remove(offer); _privateDrafts.Remove(person); SyncDateMemory(); SaveDateMemory(); EditPreviousDateScene(); }, person); return false; }, "确认并返回输入", box => { var error = Text("", 17, _muted); error.Name = "DateAttendanceError"; box.AddChild(error); });`
- `NationalSpire.CareerScreen.SyncDateMemory()`；输入表达式：`SyncDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SyncDateMemory();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 17, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 17, _muted)`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(ViewData, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Key(ViewData, person) != key`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new PrivateMessageCommand { Entry = turn.Id, Offer = offer, Part = conversation.MemoryRevision.ToString(), Text = conversation.Turns.LastOrDefault()?.Id ?? "", Replacement = Guid.NewGuid().ToString("N") }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateMessageCommand { Entry = turn.Id, Offer = offer, Part = conversation.MemoryRevision.ToString(), Text = conversation.Turns.LastOrDefault()?.Id ?? "", Replacement = Guid.NewGuid().ToString("N") }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, person)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`.Bookmarks.Remove(offer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateAssets?.Bookmarks.Remove(offer)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_privateDrafts.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateDrafts.Remove(person);`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`conversation.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversation.Turns.LastOrDefault()?.Id`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Replacement = Guid.NewGuid().ToString("N")`
- `long.ToString()`；输入表达式：`conversation.MemoryRevision.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Part = conversation.MemoryRevision.ToString()`

**赋值（含属性/字段和局部值）：**

- `Entry` = `turn.Id`
- `Offer` = `offer`
- `Part` = `conversation.MemoryRevision.ToString()`
- `Replacement` = `Guid.NewGuid().ToString("N")`
- `Text` = `conversation.Turns.LastOrDefault()?.Id ?? ""`
- `_dateEditingTurn` = `""`
- `_dateHistoryLines` = `[]`
- `_dateHistoryTurn` = `null`
- `_dateIndex` = `0`
- `_dateLines` = `[]`
- `_dateState` = `""`
- `error.Name` = `"DateAttendanceError"`
