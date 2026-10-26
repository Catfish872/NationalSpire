# DateSceneHistoryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`495B4F28C2B80A682C82DD777260E7A9783D81D02770AF800CD25A28342EC60B`。来源：[源码](../../DateSceneHistoryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-aab4554aa037"></a>

## `NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?) — private void DeleteDateHistoryReply(string person, string offerId, string turnId, DateSceneMemory? playback = null, Action? refresh = null)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`Fail(string)`](DateSceneHistoryScreen.cs.md#symbol-68e8762b1b52)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `Applied()`；`Fail(string)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._muted`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Applied()`；输入表达式：`Applied()`；返回值紧邻使用处：`ExpressionStatementSyntax: Applied();`
- `Fail(string)`；输入表达式：`Fail("当前生涯已切换，请重新打开历史记录。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail("当前生涯已切换，请重新打开历史记录。");`
- `Fail(string)`；输入表达式：`Fail("这条回复已不存在，请重新打开历史记录。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail("这条回复已不存在，请重新打开历史记录。");`
- `Fail(string)`；输入表达式：`Fail("这条回复的约会来源已变化，请重新打开历史记录。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail("这条回复的约会来源已变化，请重新打开历史记录。");`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-delete", new() { Entry = turnId, Part = "reply" }, Applied, person, Fail)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-delete", new() { Entry = turnId, Part = "reply" }, Applied, person, Fail);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("删除这轮回复", "将删除这一轮 AI 回复的全部发言、旁白及对应回忆画面，并移除相关未确认交互。玩家输入、记忆摘要、好感变化及已确认事项保留。", () => { if (DateSceneMemories.FilePath(ViewData, offerId) != key) { Fail("当前生涯已切换，请重新打开历史记录。"); return false; } var conversation = PrivateMessages.Mailbox(ViewData).Conversations.GetValueOrDefault(person); var turn = conversation?.Turns.FirstOrDefault(t => t.Id == turnId); if (turn != null && turn.Scene?.OfferId != offerId) { Fail("这条回复的约会来源已变化，请重新打开历史记录。"); return false; } void Applied() { _multiplayer?.Refresh(); if (!IsInsideTree() || DateSceneMemories.FilePath(ViewData, offerId) != key) return; try { if (_dateMemory != null && _dateMemoryKey == key) { if (DateSceneMemories.RemoveReply(_dateMemory.Memory, turnId)) _dateMemory.Dirty = true; } // Persist only the already recorded subset when recording has been turned off. var saved = playback ?? DateSceneMemories.Read(ViewData, offerId); if (saved != null) { DateSceneMemories.RemoveReply(saved, turnId); DateSceneMemories.Save(ViewData, saved); } if (_dateView != null && _datePerson == person && _dateOffer == offerId) { if (_dateTurn == turnId || _dateView.InputMode && _dateInputTurn == turnId) { _dateTurn = _dateSource = _dateEditingTurn = ""; _dateLines = []; _dateIndex = 0; _dateState = "history-deleted"; ShowDateInput(manualGame: CanResumeDateGame()); } _dateView.RefreshHistory(); } refresh?.Invoke(); if (_dialogOverlay == dialog) _cancelDialog?.Invoke(); } catch (Exception e) { Fail("回复已删除，回忆文件保存失败。请再次确认以重试：" + e.Message); } } if (turn == null) { if (playback == null) { Fail("这条回复已不存在，请重新打开历史记录。"); return false; } // Archived-only replies have already left the conversation's raw context. Applied(); } else PrivateCommand("dm-delete", new() { Entry = turnId, Part = "reply" }, Applied, person, Fail); return false; }, "删除回复", box => { error = Text("", 17, _muted); error.Name = "DateAttendanceError"; box.AddChild(error); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("删除这轮回复", "将删除这一轮 AI 回复的全部发言、旁白及对应回忆画面，并移除相关未确认交互。玩家输入、记忆摘要、好感变化及已确认事项保留。", () => { if (DateSceneMemories.FilePath(ViewData, offerId) != key) { Fail("当前生涯已切换，请重新打开历史记录。"); return false; } var conversation = PrivateMessages.Mailbox(ViewData).Conversations.GetValueOrDefault(person); var turn = conversation?.Turns.FirstOrDefault(t => t.Id == turnId); if (turn != null && turn.Scene?.OfferId != offerId) { Fail("这条回复的约会来源已变化，请重新打开历史记录。"); return false; } void Applied() { _multiplayer?.Refresh(); if (!IsInsideTree() || DateSceneMemories.FilePath(ViewData, offerId) != key) return; try { if (_dateMemory != null && _dateMemoryKey == key) { if (DateSceneMemories.RemoveReply(_dateMemory.Memory, turnId)) _dateMemory.Dirty = true; } // Persist only the already recorded subset when recording has been turned off. var saved = playback ?? DateSceneMemories.Read(ViewData, offerId); if (saved != null) { DateSceneMemories.RemoveReply(saved, turnId); DateSceneMemories.Save(ViewData, saved); } if (_dateView != null && _datePerson == person && _dateOffer == offerId) { if (_dateTurn == turnId || _dateView.InputMode && _dateInputTurn == turnId) { _dateTurn = _dateSource = _dateEditingTurn = ""; _dateLines = []; _dateIndex = 0; _dateState = "history-deleted"; ShowDateInput(manualGame: CanResumeDateGame()); } _dateView.RefreshHistory(); } refresh?.Invoke(); if (_dialogOverlay == dialog) _cancelDialog?.Invoke(); } catch (Exception e) { Fail("回复已删除，回忆文件保存失败。请再次确认以重试：" + e.Message); } } if (turn == null) { if (playback == null) { Fail("这条回复已不存在，请重新打开历史记录。"); return false; } // Archived-only replies have already left the conversation's raw context. Applied(); } else PrivateCommand("dm-delete", new() { Entry = turnId, Part = "reply" }, Applied, person, Fail); return false; }, "删除回复", box => { error = Text("", 17, _muted); error.Name = "DateAttendanceError"; box.AddChild(error); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 17, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 17, _muted)`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.FilePath(ViewData, offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneMemories.FilePath(ViewData, offerId) != key`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.FilePath(data, offerId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneMemories.FilePath(data, offerId)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = turnId, Part = "reply" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = turnId, Part = "reply" }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.FirstOrDefault(t => t.Id == turnId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversation?.Turns.FirstOrDefault(t => t.Id == turnId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(ViewData).Conversations.GetValueOrDefault(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(ViewData).Conversations.GetValueOrDefault(person)`

**赋值（含属性/字段和局部值）：**

- `Entry` = `turnId`
- `Part` = `"reply"`
- `dialog` = `_dialogOverlay`
- `error.Name` = `"DateAttendanceError"`
- `error` = `Text("", 17, _muted)`

<a id="symbol-68e8762b1b52"></a>

## `Fail(string) — void Fail(string message)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(error)`；返回值紧邻使用处：`BinaryExpressionSyntax: error != null && IsInstanceValid(error)`

**赋值（含属性/字段和局部值）：**

- `error.Text` = `message`

<a id="symbol-4386f1155e7c"></a>

## `Applied() — void Applied()`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)

**调用：** [`Fail(string)`](DateSceneHistoryScreen.cs.md#symbol-68e8762b1b52)；`Godot.Node.IsInsideTree()`；[`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-99fb40e5b954)；[`NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`](DateSceneMemories.cs.md#symbol-f4609a0121d1)；[`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-4fa62fbdceed)；[`NationalSpire.DateSceneView.RefreshHistory(bool)`](DateSceneView.cs.md#symbol-0762d57cebb4)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `Fail(string)`；`NationalSpire.CareerScreen.CanResumeDateGame()`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInputTurn`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dateMemoryKey`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateSource`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.DateMemoryRecorder.Dirty`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`；`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.RefreshHistory(bool)`；`NationalSpire.ICareerSession.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fail(string)`；输入表达式：`Fail("回复已删除，回忆文件保存失败。请再次确认以重试：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail("回复已删除，回忆文件保存失败。请再次确认以重试：" + e.Message);`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `NationalSpire.CareerScreen.CanResumeDateGame()`；输入表达式：`CanResumeDateGame()`；返回值紧邻使用处：`ArgumentSyntax: manualGame: CanResumeDateGame()`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput(manualGame: CanResumeDateGame())`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput(manualGame: CanResumeDateGame());`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.FilePath(ViewData, offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneMemories.FilePath(ViewData, offerId) != key`
- `NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.Read(ViewData, offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: playback ?? DateSceneMemories.Read(ViewData, offerId)`
- `NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`；输入表达式：`DateSceneMemories.RemoveReply(_dateMemory.Memory, turnId)`；返回值紧邻使用处：`IfStatementSyntax: if (DateSceneMemories.RemoveReply(_dateMemory.Memory, turnId)) _dateMemory.Dirty = true;`
- `NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`；输入表达式：`DateSceneMemories.RemoveReply(saved, turnId)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneMemories.RemoveReply(saved, turnId);`
- `NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`DateSceneMemories.Save(ViewData, saved)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneMemories.Save(ViewData, saved);`
- `NationalSpire.DateSceneView.RefreshHistory(bool)`；输入表达式：`_dateView.RefreshHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.RefreshHistory();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: refresh?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_dateEditingTurn` = `""`
- `_dateIndex` = `0`
- `_dateLines` = `[]`
- `_dateMemory.Dirty` = `true`
- `_dateSource` = `_dateEditingTurn = ""`
- `_dateState` = `"history-deleted"`
- `_dateTurn` = `_dateSource = _dateEditingTurn = ""`
