# GroupChatDialogs.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A1389B39757F74D5C30496792B01DEBE08EE685E9A399859FD663D2E69F0F854`。来源：[源码](../../GroupChatDialogs.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private List<string> _groupSelection = [];
```

<a id="symbol-38cd67d996b6"></a>

## `NationalSpire.CareerScreen.GroupActions() — private void GroupActions()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)

**调用：** [`Choice(string, string, System.Action)`](GroupChatDialogs.cs.md#symbol-3dc272602b7d)；[`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`Pick(string, System.Action, bool)`](GroupChatDialogs.cs.md#symbol-859a67dfed9d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `Choice(string, string, System.Action)`；`NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupArbitrationDialog()`；`NationalSpire.CareerScreen.GroupTrainingPicker()`；`NationalSpire.CareerScreen.PrivateLineupPicker()`；`NationalSpire.CareerScreen.PrivateMatchPicker()`；`NationalSpire.CareerScreen.PrivateSharePicker(string)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChat.Members`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Kind`；`Pick(string, System.Action, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choice(string, string, System.Action)`；输入表达式：`Choice("调整阵容", "选择本队教练", () => Pick("选择负责教练", PrivateLineupPicker))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("调整阵容", "选择本队教练", () => Pick("选择负责教练", PrivateLineupPicker));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("分享帖子", "选择一篇社区讨论", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("post"); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("分享帖子", "选择一篇社区讨论", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("post"); });`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("复盘比赛", "附上真实比赛记录", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("result"); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("复盘比赛", "附上真实比赛记录", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("result"); });`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("尖塔仲裁", "选择本次争议涉及的人物", () => Pick("选择被申请人", GroupArbitrationDialog, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("尖塔仲裁", "选择本次争议涉及的人物", () => Pick("选择被申请人", GroupArbitrationDialog, false));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("商谈合同", "选择报价对象", () => Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("商谈合同", "选择报价对象", () => Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("约一局", "选择群内对手", () => Pick("选择约战对象", PrivateMatchPicker))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("约一局", "选择群内对手", () => Pick("选择约战对象", PrivateMatchPicker));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("制定训练计划", "选择受训队员与教练", () => Pick("选择受训队员", GroupTrainingPicker, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("制定训练计划", "选择受训队员与教练", () => Pick("选择受训队员", GroupTrainingPicker, false));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2 }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(new() { Kind = "contract" })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => AttachPrivate(new() { Kind = "contract" })`
- `NationalSpire.CareerScreen.PrivateSharePicker(string)`；输入表达式：`PrivateSharePicker("post")`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateSharePicker("post");`
- `NationalSpire.CareerScreen.PrivateSharePicker(string)`；输入表达式：`PrivateSharePicker("result")`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateSharePicker("result");`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("添加到群聊消息", "", () => true, "关闭", box =>          {              var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); box.AddChild(grid);              void Choice(string title, string detail, Action action)              { var b = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); Callable.From(action).CallDeferred(); }, 285); b.CustomMinimumSize = new(285, 78); grid.AddChild(b); }              Choice("约一局", "选择群内对手", () => Pick("选择约战对象", PrivateMatchPicker));              Choice("制定训练计划", "选择受训队员与教练", () => Pick("选择受训队员", GroupTrainingPicker, false));              Choice("调整阵容", "选择本队教练", () => Pick("选择负责教练", PrivateLineupPicker));              Choice("商谈合同", "选择报价对象", () => Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false));              Choice("复盘比赛", "附上真实比赛记录", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("result"); });              Choice("分享帖子", "选择一篇社区讨论", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("post"); });              Choice("尖塔仲裁", "选择本次争议涉及的人物", () => Pick("选择被申请人", GroupArbitrationDialog, false));          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("添加到群聊消息", "", () => true, "关闭", box =>          {              var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); box.AddChild(grid);              void Choice(string title, string detail, Action action)              { var b = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); Callable.From(action).CallDeferred(); }, 285); b.CustomMinimumSize = new(285, 78); grid.AddChild(b); }              Choice("约一局", "选择群内对手", () => Pick("选择约战对象", PrivateMatchPicker));              Choice("制定训练计划", "选择受训队员与教练", () => Pick("选择受训队员", GroupTrainingPicker, false));              Choice("调整阵容", "选择本队教练", () => Pick("选择负责教练", PrivateLineupPicker));              Choice("商谈合同", "选择报价对象", () => Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false));              Choice("复盘比赛", "附上真实比赛记录", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("result"); });              Choice("分享帖子", "选择一篇社区讨论", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("post"); });              Choice("尖塔仲裁", "选择本次争议涉及的人物", () => Pick("选择被申请人", GroupArbitrationDialog, false));          }, showCancel: false);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(ViewData, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => PrivateMessages.CanChat(ViewData, id)`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = "contract" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = "contract" }`
- `Pick(string, System.Action, bool)`；输入表达式：`Pick("选择被申请人", GroupArbitrationDialog, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Pick("选择被申请人", GroupArbitrationDialog, false)`
- `Pick(string, System.Action, bool)`；输入表达式：`Pick("选择负责教练", PrivateLineupPicker)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Pick("选择负责教练", PrivateLineupPicker)`
- `Pick(string, System.Action, bool)`；输入表达式：`Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false)`
- `Pick(string, System.Action, bool)`；输入表达式：`Pick("选择受训队员", GroupTrainingPicker, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Pick("选择受训队员", GroupTrainingPicker, false)`
- `Pick(string, System.Action, bool)`；输入表达式：`Pick("选择约战对象", PrivateMatchPicker)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Pick("选择约战对象", PrivateMatchPicker)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_groupSelection.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupSelection.Clear();`

**赋值（含属性/字段和局部值）：**

- `_privatePerson` = `g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""`
- `Columns` = `2`
- `Kind` = `"contract"`

<a id="symbol-859a67dfed9d"></a>

## `Pick(string, System.Action, bool) — void Pick(string title, Action action, bool single = true)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)

**调用：** [`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`；输入表达式：`GroupMemberPicker(g, people =>          {              _groupSelection = people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList();              if (_groupSelection.Count == 0) return;              _privatePerson = _groupSelection[0]; action();          }, existing: true, title: title, single: single)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GroupMemberPicker(g, people =>          {              _groupSelection = people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList();              if (_groupSelection.Count == 0) return;              _privatePerson = _groupSelection[0]; action();          }, existing: true, title: title, single: single)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(ViewData, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => PrivateMessages.CanChat(ViewData, id)`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _groupSelection = people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(id => PrivateMessages.CanChat(ViewData, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList`

**赋值（含属性/字段和局部值）：**

- `_groupSelection` = `people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList()`
- `_privatePerson` = `_groupSelection[0]`

<a id="symbol-3dc272602b7d"></a>

## `Choice(string, string, System.Action) — void Choice(string title, string detail, Action action)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)

**调用：** [`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(action).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(action).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(action)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(action).CallDeferred`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(b);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(285, 78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.CustomMinimumSize = new(285, 78)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); Callable.From(action).CallDeferred(); }, 285)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); Callable.From(action).CallDeferred(); }, 285)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `b.CustomMinimumSize` = `new(285, 78)`

<a id="symbol-1e2068d8bf79"></a>

## `NationalSpire.CareerScreen.GroupTrainingPicker() — private void GroupTrainingPicker()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-7ddb21934c39)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.SpinBox.SpinBox()`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.IsNullOrWhiteSpace(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.CoachId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(duration)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(duration);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText("负责教练", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText("负责教练", 16, _muted));`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem("由我负责训练")`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem("由我负责训练");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(GroupChats.Name(d, id))`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(GroupChats.Name(d, id));`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { CustomMinimumSize = new(600, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { CustomMinimumSize = new(600, 44) }`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = 1, MaxValue = 4, Value = 4, Suffix = "周", CustomMinimumSize = new(180, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { MinValue = 1, MaxValue = 4, Value = 4, Suffix = "周", CustomMinimumSize = new(180, 42) }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(600, 180), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(600, 180), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(180, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 180)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 44)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() })`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() });`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("", 15, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = PrivateText("", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("负责教练", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("负责教练", 16, _muted)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("制定训练计划", "受训队员：" + string.Join("、", _groupSelection.Select(id => GroupChats.Name(d, id))), () =>          {              if (!ClubCoaching.PlayerCoach(d) && coach.Length == 0) { error!.Text = "请先添加本队教练，或在俱乐部兼任教练。"; return false; }              if (string.IsNullOrWhiteSpace(text)) { error!.Text = "请填写训练内容。"; return false; }              AttachPrivate(new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() }); return true;          }, "添加到消息", box =>          {              box.AddChild(PrivateText("负责教练", 16, _muted));              var picker = new OptionButton { CustomMinimumSize = new(600, 44) }; var choices = new List<string>();              if (ClubCoaching.PlayerCoach(d)) { picker.AddItem("由我负责训练"); choices.Add(""); }              foreach (string id in coaches) { picker.AddItem(GroupChats.Name(d, id)); choices.Add(id); }              picker.ItemSelected += i => coach = choices[(int)i]; box.AddChild(picker);              var input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(600, 180), WrapMode = TextEdit.LineWrappingMode.Boundary }; input.TextChanged += () => text = input.Text; box.AddChild(input);              var duration = new SpinBox { MinValue = 1, MaxValue = 4, Value = 4, Suffix = "周", CustomMinimumSize = new(180, 42) }; duration.ValueChanged += v => weeks = (int)v; box.AddChild(duration);              error = PrivateText("", 15, new Color("ee929d")); box.AddChild(error);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("制定训练计划", "受训队员：" + string.Join("、", _groupSelection.Select(id => GroupChats.Name(d, id))), () =>          {              if (!ClubCoaching.PlayerCoach(d) && coach.Length == 0) { error!.Text = "请先添加本队教练，或在俱乐部兼任教练。"; return false; }              if (string.IsNullOrWhiteSpace(text)) { error!.Text = "请填写训练内容。"; return false; }              AttachPrivate(new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() }); return true;          }, "添加到消息", box =>          {              box.AddChild(PrivateText("负责教练", 16, _muted));              var picker = new OptionButton { CustomMinimumSize = new(600, 44) }; var choices = new List<string>();              if (ClubCoaching.PlayerCoach(d)) { picker.AddItem("由我负责训练"); choices.Add(""); }              foreach (string id in coaches) { picker.AddItem(GroupChats.Name(d, id)); choices.Add(id); }              picker.ItemSelected += i => coach = choices[(int)i]; box.AddChild(picker);              var input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(600, 180), WrapMode = TextEdit.LineWrappingMode.Boundary }; input.TextChanged += () => text = input.Text; box.AddChild(input);              var duration = new SpinBox { MinValue = 1, MaxValue = 4, Value = 4, Suffix = "周", CustomMinimumSize = new(180, 42) }; duration.ValueChanged += v => weeks = (int)v; box.AddChild(duration);              error = PrivateText("", 15, new Color("ee929d")); box.AddChild(error);          });`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(d)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubCoaching.PlayerCoach(d)) { picker.AddItem("由我负责训练"); choices.Add(""); }`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubCoaching.PlayerCoach(d)`
- `NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.CanRequest(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CoachLineups.CanRequest(d, id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(d, id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) { error!.Text = "请填写训练内容。"; return false; }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", _groupSelection.Select(id => GroupChats.Name(d, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "受训队员：" + string.Join("、", _groupSelection.Select(id => GroupChats.Name(d, id)))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`coaches.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: coaches.FirstOrDefault() ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_groupSelection.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: _groupSelection.Select(id => GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_groupSelection.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Participants = _groupSelection.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`g.Members.Where(id => CoachLineups.CanRequest(d, id)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Members.Where(id => CoachLineups.CanRequest(d, id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.Where(id => CoachLineups.CanRequest(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Members.Where(id => CoachLineups.CanRequest(d, id)).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`choices.Add("")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Add("");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`choices.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Add(id);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**

- `coach` = `choices[(int)i]`
- `coach` = `coaches.FirstOrDefault() ?? ""`
- `CoachId` = `coach`
- `CustomMinimumSize` = `new(180, 42)`
- `CustomMinimumSize` = `new(600, 180)`
- `CustomMinimumSize` = `new(600, 44)`
- `Detail` = `text`
- `duration.ValueChanged` += `v => weeks = (int)v`
- `error!.Text` = `"请填写训练内容。"`
- `error!.Text` = `"请先添加本队教练，或在俱乐部兼任教练。"`
- `error` = `PrivateText("", 15, new Color("ee929d"))`
- `input.TextChanged` += `() => text = input.Text`
- `Kind` = `"training"`
- `MaxValue` = `4`
- `MinValue` = `1`
- `Participants` = `_groupSelection.ToList()`
- `picker.ItemSelected` += `i => coach = choices[(int)i]`
- `PlaceholderText` = `"填写训练内容"`
- `Suffix` = `"周"`
- `text` = `input.Text`
- `Value` = `4`
- `weeks` = `(int)v`
- `Weeks` = `weeks`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-b436b0c3aa2f"></a>

## `NationalSpire.CareerScreen.GroupArbitrationDialog() — private void GroupArbitrationDialog()`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.GroupCommand.GroupCommand()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupCommand.People`；`NationalSpire.GroupCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { PlaceholderText = "说明需要审理的争议", CustomMinimumSize = new(620, 230), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { PlaceholderText = "说明需要审理的争议", CustomMinimumSize = new(620, 230), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(620, 230)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(620, 230)`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-arbitrate", new() { People = targets, Text = text })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-arbitrate", new() { People = targets, Text = text });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("申请群聊仲裁", "被申请人：" + string.Join("、", targets.Select(id => GroupChats.Name(ViewData, id))), () =>          { GroupCommand("group-arbitrate", new() { People = targets, Text = text }); return true; }, "提交申请", box =>          {              var input = new TextEdit { PlaceholderText = "说明需要审理的争议", CustomMinimumSize = new(620, 230), WrapMode = TextEdit.LineWrappingMode.Boundary };              input.TextChanged += () => text = input.Text; box.AddChild(input);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("申请群聊仲裁", "被申请人：" + string.Join("、", targets.Select(id => GroupChats.Name(ViewData, id))), () =>          { GroupCommand("group-arbitrate", new() { People = targets, Text = text }); return true; }, "提交申请", box =>          {              var input = new TextEdit { PlaceholderText = "说明需要审理的争议", CustomMinimumSize = new(620, 230), WrapMode = TextEdit.LineWrappingMode.Boundary };              input.TextChanged += () => text = input.Text; box.AddChild(input);          });`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(ViewData, id)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { People = targets, Text = text }`；返回值紧邻使用处：`ArgumentSyntax: new() { People = targets, Text = text }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", targets.Select(id => GroupChats.Name(ViewData, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "被申请人：" + string.Join("、", targets.Select(id => GroupChats.Name(ViewData, id)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targets.Select(id => GroupChats.Name(ViewData, id))`；返回值紧邻使用处：`ArgumentSyntax: targets.Select(id => GroupChats.Name(ViewData, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_groupSelection.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _groupSelection.ToList()`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(620, 230)`
- `input.TextChanged` += `() => text = input.Text`
- `People` = `targets`
- `PlaceholderText` = `"说明需要审理的争议"`
- `text` = `input.Text`
- `Text` = `text`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-a263539cc71f"></a>

## `NationalSpire.CareerScreen.GroupSettings() — private void GroupSettings()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateSettings()`](PrivateMessageScreen.cs.md#symbol-e86e401f7314)

**调用：** [`Field(string, int)`](GroupChatDialogs.cs.md#symbol-3e1134f6a6ce)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.GroupHistorySettings.GroupHistorySettings()`

**字段、属性、事件及方法组引用：** `Field(string, int)`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.GroupChat.Settings`；`NationalSpire.GroupCommand.Settings`；`NationalSpire.GroupHistorySettings.MergeOldest`；`NationalSpire.GroupHistorySettings.RecentRounds`；`NationalSpire.GroupHistorySettings.SmallSummaryLimit`；`NationalSpire.GroupHistorySettings.SummaryEvery`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string, int)`；输入表达式：`Field("保留近期原文轮数", g.Settings.RecentRounds)`；返回值紧邻使用处：`AssignmentExpressionSyntax: recent = Field("保留近期原文轮数", g.Settings.RecentRounds)`
- `Field(string, int)`；输入表达式：`Field("每次合并最早几份", g.Settings.MergeOldest)`；返回值紧邻使用处：`AssignmentExpressionSyntax: merge = Field("每次合并最早几份", g.Settings.MergeOldest)`
- `Field(string, int)`；输入表达式：`Field("每隔多少轮生成小总结", g.Settings.SummaryEvery)`；返回值紧邻使用处：`AssignmentExpressionSyntax: every = Field("每隔多少轮生成小总结", g.Settings.SummaryEvery)`
- `Field(string, int)`；输入表达式：`Field("小总结合并阈值", g.Settings.SmallSummaryLimit)`；返回值紧邻使用处：`AssignmentExpressionSyntax: limit = Field("小总结合并阈值", g.Settings.SmallSummaryLimit)`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-settings", new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-settings", new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("群聊记录设置", "", () => { GroupCommand("group-settings", new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } }); return true; }, "保存", box =>          {              SpinBox Field(string name, int value)              {                  var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); box.AddChild(row);                  var label = PrivateLine(name, 18, _ink); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);                  var number = new SpinBox { MinValue = 0, MaxValue = int.MaxValue, Value = value, CustomMinimumSize = new(160, 44) }; row.AddChild(number); return number;              }              every = Field("每隔多少轮生成小总结", g.Settings.SummaryEvery); recent = Field("保留近期原文轮数", g.Settings.RecentRounds);              limit = Field("小总结合并阈值", g.Settings.SmallSummaryLimit); merge = Field("每次合并最早几份", g.Settings.MergeOldest);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("群聊记录设置", "", () => { GroupCommand("group-settings", new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } }); return true; }, "保存", box =>          {              SpinBox Field(string name, int value)              {                  var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); box.AddChild(row);                  var label = PrivateLine(name, 18, _ink); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);                  var number = new SpinBox { MinValue = 0, MaxValue = int.MaxValue, Value = value, CustomMinimumSize = new(160, 44) }; row.AddChild(number); return number;              }              every = Field("每隔多少轮生成小总结", g.Settings.SummaryEvery); recent = Field("保留近期原文轮数", g.Settings.RecentRounds);              limit = Field("小总结合并阈值", g.Settings.SmallSummaryLimit); merge = Field("每次合并最早几份", g.Settings.MergeOldest);          });`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } }`
- `NationalSpire.GroupHistorySettings.GroupHistorySettings()`；输入表达式：`new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }`

**赋值（含属性/字段和局部值）：**

- `every` = `Field("每隔多少轮生成小总结", g.Settings.SummaryEvery)`
- `limit` = `Field("小总结合并阈值", g.Settings.SmallSummaryLimit)`
- `merge` = `Field("每次合并最早几份", g.Settings.MergeOldest)`
- `MergeOldest` = `(int)merge!.Value`
- `recent` = `Field("保留近期原文轮数", g.Settings.RecentRounds)`
- `RecentRounds` = `(int)recent!.Value`
- `Settings` = `new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }`
- `SmallSummaryLimit` = `(int)limit!.Value`
- `SummaryEvery` = `(int)every!.Value`

<a id="symbol-3e1134f6a6ce"></a>

## `Field(string, int) — SpinBox Field(string name, int value)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupSettings()`](GroupChatDialogs.cs.md#symbol-a263539cc71f)

**调用：** [`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 24);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(number);`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = 0, MaxValue = int.MaxValue, Value = value, CustomMinimumSize = new(160, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { MinValue = 0, MaxValue = int.MaxValue, Value = value, CustomMinimumSize = new(160, 44) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(160, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(160, 44)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(name, 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(name, 18, _ink)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(160, 44)`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MaxValue` = `int.MaxValue`
- `MinValue` = `0`
- `Value` = `value`

<a id="symbol-bf729ae9b3eb"></a>

## `NationalSpire.CareerScreen.GroupMemory() — private void GroupMemory()`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`](PrivateMessageData.cs.md#symbol-db2a1a2d7b09)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Text`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`items.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(edit)`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(edit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`items.AddChild(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddChild(entry);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("删除", () =>                  {                      string warning = s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                      _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");                  }, 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("删除", () =>                  {                      string warning = s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                      _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");                  }, 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(items)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(items);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(670, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(670, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = s.Text, WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(630, 130) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = s.Text, WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(630, 130) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(630, 130)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(630, 130)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(670, 350)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(670, 350)`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-clear", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-clear", new());`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } });`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } })`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-summary", new() { Text = "big" })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-summary", new() { Text = "big" })`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-summary", new() { Text = "small" })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-summary", new() { Text = "small" })`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("删除", () =>                  {                      string warning = s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                      _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");                  }, 90)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("删除", () =>                  {                      string warning = s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                      _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");                  }, 90)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空");`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("群聊记忆", "", () => true, "关闭", box =>          {              var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);              actions.AddChild(PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140));              actions.AddChild(PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150));              actions.AddChild(PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110));              var scroll = new ScrollContainer { CustomMinimumSize = new(670, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var items = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; items.AddThemeConstantOverride("separation", 14); scroll.AddChild(items);              foreach (var (part, summaries) in new[] { ("big", g.BigSummaries), ("small", g.SmallSummaries) }) foreach (var s in summaries)              {                  var entry = new VBoxContainer(); items.AddChild(entry); entry.AddChild(PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold));                  var edit = new TextEdit { Text = s.Text, WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(630, 130) }; entry.AddChild(edit);                  var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); entry.AddChild(row);                  row.AddChild(PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90));                  row.AddChild(PrivateButton("删除", () =>                  {                      string warning = s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                      _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");                  }, 90));              }          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("群聊记忆", "", () => true, "关闭", box =>          {              var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);              actions.AddChild(PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140));              actions.AddChild(PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150));              actions.AddChild(PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110));              var scroll = new ScrollContainer { CustomMinimumSize = new(670, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var items = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; items.AddThemeConstantOverride("separation", 14); scroll.AddChild(items);              foreach (var (part, summaries) in new[] { ("big", g.BigSummaries), ("small", g.SmallSummaries) }) foreach (var s in summaries)              {                  var entry = new VBoxContainer(); items.AddChild(entry); entry.AddChild(PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold));                  var edit = new TextEdit { Text = s.Text, WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(630, 130) }; entry.AddChild(edit);                  var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); entry.AddChild(row);                  row.AddChild(PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90));                  row.AddChild(PrivateButton("删除", () =>                  {                      string warning = s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                      _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");                  }, 90));              }          }, showCancel: false);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("删除这条总结", warning, () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); return true; }, "确认删除");`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Interaction = new() { Entry = s.Id, Part = part } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Interaction = new() { Entry = s.Id, Part = part } }`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = "big" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = "big" }`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = "small" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = "small" }`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = s.Id, Part = part }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Interaction = new() { Entry = s.Id, Part = part }`
- `NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；输入表达式：`s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries))`；返回值紧邻使用处：`ConditionalExpressionSyntax: s.IsLatest(g.SmallSummaries.Concat(g.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。"`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries)`；返回值紧邻使用处：`ArgumentSyntax: g.SmallSummaries.Concat(g.BigSummaries)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(630, 130)`
- `CustomMinimumSize` = `new(670, 350)`
- `Entry` = `s.Id`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Interaction` = `new() { Entry = s.Id, Part = part }`
- `Part` = `part`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `"big"`
- `Text` = `"small"`
- `Text` = `edit.Text`
- `Text` = `s.Text`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-b6bc7a2d0206"></a>

## `NationalSpire.CareerScreen.PreviewGroupPrompt() — private void PreviewGroupPrompt()`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PreviewPrivatePrompt()`](PrivateMessageScreen.cs.md#symbol-aefc38a1fba3)

**调用：** `Godot.DisplayServer.ClipboardSet(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`NationalSpire.GroupTurn.GroupTurn()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.ChatWorld.Order`；`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupTurn.Attachments`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.DisplayServer.ClipboardSet(string)`；输入表达式：`DisplayServer.ClipboardSet(text)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DisplayServer.ClipboardSet(text)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(edit)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(edit);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = text, Editable = false, CustomMinimumSize = new(900, 520), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = text, Editable = false, CustomMinimumSize = new(900, 520), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(900, 520)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(900, 520)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("群聊提示词预览", "", () => true, "关闭", box => { var edit = new TextEdit { Text = text, Editable = false, CustomMinimumSize = new(900, 520), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(edit); box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180)); }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("群聊提示词预览", "", () => true, "关闭", box => { var edit = new TextEdit { Text = text, Editable = false, CustomMinimumSize = new(900, 520), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(edit); box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180)); }, showCancel: false);`
- `NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`；输入表达式：`GroupChatPrompts.Compose(ViewData, g, new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments })`；返回值紧邻使用处：`ArgumentSyntax: GroupChatPrompts.Compose(ViewData, g, new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments })`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Sender = GroupChats.Human(ViewData)`
- `NationalSpire.GroupTurn.GroupTurn()`；输入表达式：`new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments }`；返回值紧邻使用处：`ArgumentSyntax: new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments }`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(GroupChatPrompts.Compose(ViewData, g, new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments }), new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(GroupChatPrompts.Compose(ViewData, g, new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments }), new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`

**赋值（含属性/字段和局部值）：**

- `Attachments` = `PrivateAttachments`
- `CustomMinimumSize` = `new(900, 520)`
- `Day` = `ViewData.Day`
- `Editable` = `false`
- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `Order` = `ViewData.Chats.Order + 1`
- `Sender` = `GroupChats.Human(ViewData)`
- `Text` = `_privateInput!.Text`
- `Text` = `text`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `WriteIndented` = `true`
