# CommunityScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`067D26C29AA896983F08DAFE508DBE7C70702647AE7137BFC909D357C6E76E36`。来源：[源码](../../CommunityScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CommunityUpdateButton`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, string> _replyTargets = new();
private readonly Dictionary<string, string> _replyDrafts = new();
private readonly Dictionary<string, Control> _replyControls = new();
private readonly HashSet<string> _expandedPostBackgrounds = [];
private Button? _updatesButton;
private string _newPostTitle = "", _newPostBody = "";
private const string ComposePostId = "compose-new-post";
private double _elapsed;
```

<a id="symbol-02ed3035beb3"></a>

## `NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData) — private void RenderPostComposer(CareerData data)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._newPostBody`；`NationalSpire.CareerScreen._newPostTitle`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen.AddHeading(string, string)`；`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Back()`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "CommunityPostTitle", Text = _newPostTitle, PlaceholderText = "帖子标题", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "CommunityPostTitle", Text = _newPostTitle, PlaceholderText = "帖子标题", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("发布帖子", () =>          {              try              {                  if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;                  var post = CommunityThreads.Publish(data, title.Text, body.Text);                  _newPostTitle = ""; _newPostBody = "";                  _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);              }              catch (Exception e) { Notice(e.Message, true); }          }, 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("发布帖子", () =>          {              try              {                  if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;                  var post = CommunityThreads.Publish(data, title.Text, body.Text);                  _newPostTitle = ""; _newPostBody = "";                  _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);              }              catch (Exception e) { Notice(e.Message, true); }          }, 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("返回社区", Back, 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("返回社区", Back, 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(title);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "CommunityPostBody", Text = _newPostBody, PlaceholderText = "分享想法，或向社区发起讨论……",              CustomMinimumSize = new Vector2(0, 250), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "CommunityPostBody", Text = _newPostBody, PlaceholderText = "分享想法，或向社区发起讨论……",              CustomMinimumSize = new Vector2(0, 250), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 250)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 250)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([post.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([post.Id])`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(data)}`
- `NationalSpire.CareerScreen.AddHeading(string, string)`；输入表达式：`AddHeading("发布帖子", $"{CareerEngine.Name(data)} · {data.Esports.Country}社区")`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading("发布帖子", $"{CareerEngine.Name(data)} · {data.Esports.Country}社区");`
- `NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；输入表达式：`AddMentionPicker(body, box)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddMentionPicker(body, box);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("发布帖子", () =>          {              try              {                  if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;                  var post = CommunityThreads.Publish(data, title.Text, body.Text);                  _newPostTitle = ""; _newPostBody = "";                  _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);              }              catch (Exception e) { Notice(e.Message, true); }          }, 160)`；返回值紧邻使用处：`ArgumentSyntax: Button("发布帖子", () =>          {              try              {                  if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;                  var post = CommunityThreads.Publish(data, title.Text, body.Text);                  _newPostTitle = ""; _newPostBody = "";                  _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);              }              catch (Exception e) { Notice(e.Message, true); }          }, 160)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("返回社区", Back, 160)`；返回值紧邻使用处：`ArgumentSyntax: Button("返回社区", Back, 160)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`；输入表达式：`CommunityThreads.Publish(data, title.Text, body.Text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.Publish(data, title.Text, body.Text)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([post.Id])`
- `_newPostBody` = `""`
- `_newPostBody` = `body.Text`
- `_newPostTitle` = `_newPostBody = ""`
- `_newPostTitle` = `""`
- `_newPostTitle` = `value`
- `_postId` = `null`
- `_postId` = `post.Id`
- `body.TextChanged` += `() => _newPostBody = body.Text`
- `CustomMinimumSize` = `new Vector2(0, 250)`
- `Name` = `"CommunityPostBody"`
- `Name` = `"CommunityPostTitle"`
- `PlaceholderText` = `"分享想法，或向社区发起讨论……"`
- `PlaceholderText` = `"帖子标题"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `_newPostBody`
- `Text` = `_newPostTitle`
- `title.TextChanged` += `value => _newPostTitle = value`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-ad7fb59cd134"></a>

## `NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost) — private void RefreshDiscussion(CareerData data, CommunityPost post)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)

**调用：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-d891e2f0e3ea)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._postSignature`；`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.UpdateCommunityBadge()`；`NationalSpire.CareerScreen.UpdateNavigation()`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderDiscussion(data, post, discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderDiscussion(data, post, discussion);`
- `NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderPostHeader(data, post, header)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostHeader(data, post, header);`
- `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；输入表达式：`Signature(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _postSignature = Signature(data)`
- `NationalSpire.CareerScreen.UpdateCommunityBadge()`；输入表达式：`UpdateCommunityBadge()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateCommunityBadge();`
- `NationalSpire.CareerScreen.UpdateNavigation()`；输入表达式：`UpdateNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateNavigation();`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(discussion);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(header);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "SubmitThreadReply")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "SubmitThreadReply") is Button submit`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadDiscussion")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadDiscussion") is not VBoxContainer discussion`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadHeader")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadHeader") is VBoxContainer header`
- `NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.MarkRead(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.MarkRead(data, post);`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`AssignmentExpressionSyntax: submit.Disabled = CommunityThreads.NewsPending(data, post)`

**赋值（含属性/字段和局部值）：**

- `_postSignature` = `Signature(data)`
- `submit.Disabled` = `CommunityThreads.NewsPending(data, post)`

<a id="symbol-09dc30b97d0c"></a>

## `NationalSpire.CareerScreen.UpdateCommunityBadge() — private void UpdateCommunityBadge()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-a39689737c6f)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._updatesButton`；`NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f07878")`；返回值紧邻使用处：`ConditionalExpressionSyntax: count > 0 ? new Color("f07878") : _muted`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_updatesButton.AddThemeColorOverride("font_color", count > 0 ? new Color("f07878") : _muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _updatesButton.AddThemeColorOverride("font_color", count > 0 ? new Color("f07878") : _muted);`
- `NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.Unread(_boundData)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.Unread(_boundData)`

**赋值（含属性/字段和局部值）：**

- `_updatesButton.Text` = `count > 0 ? $"●  {count} 个帖子有更新" : "社区暂无未读更新"`

<a id="symbol-8c3d08bdf705"></a>

## `NationalSpire.CareerScreen.OpenUpdates() — private void OpenUpdates()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "社区"; _postId = null; _communityFilter = "未读更新"; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Visit(() => { _tab = "社区"; _postId = null; _communityFilter = "未读更新"; })`

**赋值（含属性/字段和局部值）：**

- `_communityFilter` = `"未读更新"`
- `_postId` = `null`
- `_tab` = `"社区"`

<a id="symbol-054ede707cf5"></a>

## `NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost) — private void RenderThread(CareerData data, CommunityPost post)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.FocusComposerAsync()`](CommunityScreen.cs.md#symbol-8e1aa9b68d26)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-d891e2f0e3ea)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`](CommunityThreads.cs.md#symbol-fd915269624a)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`](CommunityThreads.cs.md#symbol-4de765d004ff)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `(int Floor, int Depth).Floor`；`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._replyDrafts`；`NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.FocusComposerAsync()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.UpdateCommunityBadge()`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`；`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(composer)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(composer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(discussion);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("改为回复帖子", () => BeginReply(post, ""), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("改为回复帖子", () => BeginReply(post, ""), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(submit)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(submit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cb.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: cb.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cb.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: cb.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cb.AddChild(Text(target == null ? "发表回复" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)} · {CommunityThreads.Position(post, target).Floor}L", 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: cb.AddChild(Text(target == null ? "发表回复" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)} · {CommunityThreads.Position(post, target).Floor}L", 20, _gold));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "CommunityReplyEditor", Text = _replyDrafts.GetValueOrDefault(draftKey, ""),              PlaceholderText = "说说你的想法，或继续上面的讨论……", CustomMinimumSize = new Vector2(0, 130),              SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "CommunityReplyEditor", Text = _replyDrafts.GetValueOrDefault(draftKey, ""),              PlaceholderText = "说说你的想法，或继续上面的讨论……", CustomMinimumSize = new Vector2(0, 130),              SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ThreadDiscussion", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ThreadDiscussion", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ThreadHeader", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ThreadHeader", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 130)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 130)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([sent.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([sent.Id])`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, target.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, target.AuthorId)}`
- `NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；输入表达式：`AddMentionPicker(editor, cb)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddMentionPicker(editor, cb);`
- `NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`；输入表达式：`BeginReply(post, "")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => BeginReply(post, "")`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("发布回复", () =>          {              try              {                  if (MultiplayerCommand("reply", post.Id, editor.Text, parent: parentId, accepted: () => { _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render(); })) return;                  var sent = CommunityThreads.Submit(data, post, parentId, editor.Text);                  _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render();                  _ = FocusComposerAsync(); _ = AiService.ProcessInteractionsAsync([sent.Id]);                  Notice("回复已发布。", false);              }              catch (Exception e) { Notice(e.Message, true); }          }, 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("发布回复", () =>          {              try              {                  if (MultiplayerCommand("reply", post.Id, editor.Text, parent: parentId, accepted: () => { _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render(); })) return;                  var sent = CommunityThreads.Submit(data, post, parentId, editor.Text);                  _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render();                  _ = FocusComposerAsync(); _ = AiService.ProcessInteractionsAsync([sent.Id]);                  Notice("回复已发布。", false);              }              catch (Exception e) { Notice(e.Message, true); }          }, 150)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("改为回复帖子", () => BeginReply(post, ""), 180)`；返回值紧邻使用处：`ArgumentSyntax: Button("改为回复帖子", () => BeginReply(post, ""), 180)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.FocusComposerAsync()`；输入表达式：`FocusComposerAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = FocusComposerAsync()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(composer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(composer)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("reply", post.Id, editor.Text, parent: parentId, accepted: () => { _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render(); })`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("reply", post.Id, editor.Text, parent: parentId, accepted: () => { _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render(); })) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("回复已发布。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("回复已发布。", false);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderDiscussion(data, post, discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderDiscussion(data, post, discussion);`
- `NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderPostHeader(data, post, header)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostHeader(data, post, header);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(target == null ? "发表回复" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)} · {CommunityThreads.Position(post, target).Floor}L", 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(target == null ? "发表回复" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)} · {CommunityThreads.Position(post, target).Floor}L", 20, _gold)`
- `NationalSpire.CareerScreen.UpdateCommunityBadge()`；输入表达式：`UpdateCommunityBadge()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateCommunityBadge();`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Any`
- `NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.MarkRead(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.MarkRead(data, post);`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`AssignmentExpressionSyntax: submit.Disabled = CommunityThreads.NewsPending(data, post)`
- `NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`；输入表达式：`CommunityThreads.Position(post, target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.Position(post, target).Floor`
- `NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`；输入表达式：`CommunityThreads.Submit(data, post, parentId, editor.Text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.Submit(data, post, parentId, editor.Text)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_replyDrafts.Remove(draftKey)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyDrafts.Remove(draftKey);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_replyTargets.Remove(post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyTargets.Remove(post.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Any(p => p.Id == post.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.All(data).Any(p => p.Id == post.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == parentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.FirstOrDefault(r => r.Id == parentId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_replyDrafts.GetValueOrDefault(draftKey, "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = _replyDrafts.GetValueOrDefault(draftKey, "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_replyTargets.GetValueOrDefault(post.Id, "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _replyTargets.GetValueOrDefault(post.Id, "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.SavedThreads.Add(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.SavedThreads.Add(post);`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([sent.Id])`
- `_` = `FocusComposerAsync()`
- `_replyDrafts[draftKey]` = `editor.Text`
- `CustomMinimumSize` = `new Vector2(0, 130)`
- `editor.TextChanged` += `() => _replyDrafts[draftKey] = editor.Text`
- `Name` = `"CommunityReplyEditor"`
- `Name` = `"ThreadDiscussion"`
- `Name` = `"ThreadHeader"`
- `parentId` = `""`
- `PlaceholderText` = `"说说你的想法，或继续上面的讨论……"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `submit.Disabled` = `CommunityThreads.NewsPending(data, post)`
- `submit.Name` = `"SubmitThreadReply"`
- `Text` = `_replyDrafts.GetValueOrDefault(draftKey, "")`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-4c514e4927ad"></a>

## `NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer) — private void RenderPostHeader(CareerData data, CommunityPost post, VBoxContainer header)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.RetryNewsAsync(string)`](AiService.cs.md#symbol-4e15401241c3)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.AiService.RetryNewsAsync(string)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CommunityPost.Analysis`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(Text($"第 {post.Day} 天 · {post.Category}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(Text($"第 {post.Day} 天 · {post.Category}", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Inner(card).AddChild(MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: Inner(card).AddChild(MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId)));`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([post.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([post.Id])`
- `NationalSpire.AiService.RetryNewsAsync(string)`；输入表达式：`AiService.RetryNewsAsync(post.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.RetryNewsAsync(post.Id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, post.AuthorId)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, post.AuthorId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, post.AuthorId)?.Country`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Inner(card).AddChild`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople)`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderPostBackground(data, post, header)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostBackground(data, post, header);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(header, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(header, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(header, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(header, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第 {post.Day} 天 · {post.Category}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"第 {post.Day} 天 · {post.Category}", 16, _muted)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.NewsPending(data, post)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: post.RelatedPeople.Append(post.AuthorId)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([post.Id])`
- `_` = `AiService.RetryNewsAsync(post.Id)`

<a id="symbol-2d520c5b6596"></a>

## `NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer) — private void RenderPostBackground(CareerData data, CommunityPost post, VBoxContainer header)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`string.TrimEnd()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Globalization.StringInfo.StringInfo(string)`；`System.Globalization.StringInfo.SubstringByTextElements(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._expandedPostBackgrounds`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.SourceTitle`；`NationalSpire.CommunityPost.Title`；`NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(record)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(record);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("事件背景", 19, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("事件背景", 19, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(title, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(title, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(card);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`toggle.GetIndex()`；返回值紧邻使用处：`ArgumentSyntax: toggle.GetIndex()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`box.MoveChild(record, toggle.GetIndex())`；返回值紧邻使用处：`ExpressionStatementSyntax: box.MoveChild(record, toggle.GetIndex());`
- `Godot.Node.QueueFree()`；输入表达式：`record.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: record.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`box.RemoveChild(record)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.RemoveChild(record);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(expanded ? "收起详情" : "展开详情", () => { })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(expanded ? "收起详情" : "展开详情", () => { })`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`AssignmentExpressionSyntax: record = MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("事件背景", 19, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text("事件背景", 19, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 18, _ink)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(post.SourceBody)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameText.Plain(post.SourceBody).Trim`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(post.SourceTitle)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameText.Plain(post.SourceTitle).Trim`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(post.SourceBody)`；返回值紧邻使用处：`BinaryExpressionSyntax: post.AuthorId == "player" || string.IsNullOrWhiteSpace(post.SourceBody)`
- `string.Trim()`；输入表达式：`GameText.Plain(post.SourceBody).Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameText.Plain(post.SourceBody).Trim()`
- `string.Trim()`；输入表达式：`GameText.Plain(post.SourceTitle).Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameText.Plain(post.SourceTitle).Trim()`
- `string.TrimEnd()`；输入表达式：`elements.SubstringByTextElements(0, 240).TrimEnd()`；返回值紧邻使用处：`BinaryExpressionSyntax: elements.SubstringByTextElements(0, 240).TrimEnd() + "……"`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_expandedPostBackgrounds.Add(post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _expandedPostBackgrounds.Add(post.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_expandedPostBackgrounds.Contains(post.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _expandedPostBackgrounds.Contains(post.Id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_expandedPostBackgrounds.Remove(post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _expandedPostBackgrounds.Remove(post.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: post.RelatedPeople.Append(post.AuthorId)`
- `System.Globalization.StringInfo.StringInfo(string)`；输入表达式：`new System.Globalization.StringInfo(facts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.Globalization.StringInfo(facts)`
- `System.Globalization.StringInfo.SubstringByTextElements(int, int)`；输入表达式：`elements.SubstringByTextElements(0, 240)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: elements.SubstringByTextElements(0, 240).TrimEnd`

**赋值（含属性/字段和局部值）：**

- `card.Name` = `"PostBackground"`
- `expanded` = `!expanded`
- `record.Name` = `"PostBackgroundFacts"`
- `record` = `MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId))`
- `toggle.Name` = `"TogglePostBackground"`
- `toggle.Pressed` += `() =>          {              expanded = !expanded;              if (expanded) _expandedPostBackgrounds.Add(post.Id); else _expandedPostBackgrounds.Remove(post.Id);              box.RemoveChild(record); record.QueueFree();              record = MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId));              record.Name = "PostBackgroundFacts"; box.AddChild(record); box.MoveChild(record, toggle.GetIndex());              toggle.Text = expanded ? "收起详情" : "展开详情";          }`
- `toggle.Text` = `expanded ? "收起详情" : "展开详情"`

<a id="symbol-1799ee450143"></a>

## `NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer) — private void RenderDiscussion(CareerData data, CommunityPost post, VBoxContainer discussion)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`](CommunityThreads.cs.md#symbol-fd915269624a)；[`NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-7120f3e9af63)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._replyControls`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityReply.ReactionGeneration`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`；`NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost)`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`indent.AddThemeConstantOverride("margin_left", Math.Min(depth, 3) * 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: indent.AddThemeConstantOverride("margin_left", Math.Min(depth, 3) * 20);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(above)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(above);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(head)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(head);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`discussion.AddChild(indent)`；返回值紧邻使用处：`ExpressionStatementSyntax: discussion.AddChild(indent);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`discussion.AddChild(Text("大家还在赶来……", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: discussion.AddChild(Text("大家还在赶来……", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`discussion.AddChild(Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: discussion.AddChild(Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(respond)`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(respond);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`indent.AddChild(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: indent.AddChild(c);`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`_scroll.EnsureControlVisible(control)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.EnsureControlVisible(control);`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([reply.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([reply.Id])`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, parent.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "↳ 回复 " + CareerEngine.DisplayName(data, parent.AuthorId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, reply.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, reply.AuthorId)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, reply.AuthorId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, reply.AuthorId)`
- `NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`；输入表达式：`BeginReply(post, reply.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => BeginReply(post, reply.Id)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("↳ 回复 " + CareerEngine.DisplayName(data, parent.AuthorId) + " · 查看上文", () =>                  { if (_replyControls.TryGetValue(parent.Id, out var control)) _scroll.EnsureControlVisible(control); })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("↳ 回复 " + CareerEngine.DisplayName(data, parent.AuthorId) + " · 查看上文", () =>                  { if (_replyControls.TryGetValue(parent.Id, out var control)) _scroll.EnsureControlVisible(control); })`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("回复", () => BeginReply(post, reply.Id), 80)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("回复", () => BeginReply(post, reply.Id), 80)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(c)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId))`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("大家还在赶来……", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("大家还在赶来……", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42)`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`IfStatementSyntax: if (CommunityThreads.NewsPending(data, post)) { discussion.AddChild(Text("大家还在赶来……", 17, _muted)); return; }`
- `NationalSpire.CommunityThreads.Position(NationalSpire.CommunityPost, NationalSpire.CommunityReply)`；输入表达式：`CommunityThreads.Position(post, reply)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (floor, depth) = CommunityThreads.Position(post, reply)`
- `NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.ReadingOrder(post)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in CommunityThreads.ReadingOrder(post))          {              var (floor, depth) = CommunityThreads.Position(post, reply);              var indent = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };              indent.AddThemeConstantOverride("margin_left", Math.Min(depth, 3) * 20); discussion.AddChild(indent);              var c = Card(); indent.AddChild(c); var box = Inner(c); _replyControls[reply.Id] = c;              var head = new HBoxContainer(); box.AddChild(head);              var speaker = CareerEngine.Person(data, reply.AuthorId);              string caption = $"{CareerEngine.DisplayName(data, reply.AuthorId)}  ·  {speaker?.Country ?? data.Esports.Country}赛区\n{floor}L" + (depth > 0 ? $" · 楼中楼" : "") + $"  ·  第 {reply.Day} 天";              head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42));              var respond = Button("回复", () => BeginReply(post, reply.Id), 80); respond.Name = "ReplyTo_" + reply.Id; head.AddChild(respond);              if (reply.ParentId.Length > 0 && post.Replies.FirstOrDefault(r => r.Id == reply.ParentId) is { } parent)              {                  var above = Button("↳ 回复 " + CareerEngine.DisplayName(data, parent.AuthorId) + " · 查看上文", () =>                  { if (_replyControls.TryGetValue(parent.Id, out var control)) _scroll.EnsureControlVisible(control); });                  above.AutowrapMode = TextServer.AutowrapMode.WordSmart; above.SizeFlagsHorizontal = SizeFlags.ExpandFill; box.AddChild(above);              }              box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)));              if (reply.NeedsReaction) RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id);          }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_replyControls.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyControls.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_replyControls.TryGetValue(parent.Id, out var control)`；返回值紧邻使用处：`IfStatementSyntax: if (_replyControls.TryGetValue(parent.Id, out var control)) _scroll.EnsureControlVisible(control);`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Append(post.AuthorId).Append`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == reply.ParentId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: post.Replies.FirstOrDefault(r => r.Id == reply.ParentId) is { } parent`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(depth, 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(depth, 3) * 20`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([reply.Id])`
- `_replyControls[reply.Id]` = `c`
- `above.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `above.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `respond.Name` = `"ReplyTo_" + reply.Id`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `var (floor, depth)` = `CommunityThreads.Position(post, reply)`

<a id="symbol-6bc7befbb991"></a>

## `NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string) — private void BeginReply(CommunityPost post, string parent)`

来源：源码第 161 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.CareerScreen.FocusComposerAsync()`](CommunityScreen.cs.md#symbol-8e1aa9b68d26)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen.FocusComposerAsync()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.FocusComposerAsync()`；输入表达式：`FocusComposerAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = FocusComposerAsync()`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**

- `_` = `FocusComposerAsync()`
- `_replyTargets[post.Id]` = `parent`

<a id="symbol-6bdab2812eba"></a>

## `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string) — private void RenderWorkStatus(VBoxContainer box, AiWorkState work, Action retry, string id)`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；[`NationalSpire.PlayerFacingText.AiErrorPreview(string)`](PlayerFacingText.cs.md#symbol-fc1bb7a47c87)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.DisplayServer.ClipboardSet(string)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.AiWorkState.WaitReason`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.PlayerFacingText.AiError(string)`；`NationalSpire.PlayerFacingText.AiErrorPreview(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f07878")`；返回值紧邻使用处：`ConditionalExpressionSyntax: work.State == "failed" ? new Color("f07878") : _muted`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`editor.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.DisplayServer.ClipboardSet(string)`；输入表达式：`DisplayServer.ClipboardSet(detail)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DisplayServer.ClipboardSet(detail)`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));                  });              }, 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));                  });              }, 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(600, 280)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(600, 280)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));                  });              }, 120)`；返回值紧邻使用处：`ArgumentSyntax: Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));                  });              }, 120)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150)`；返回值紧邻使用处：`ArgumentSyntax: Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("重试" + scope, retry, 120)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("重试" + scope, retry, 120)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));                  })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));                  });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(caption, 14, work.State == "failed" ? new Color("f07878") : _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(caption, 14, work.State == "failed" ? new Color("f07878") : _muted)`
- `NationalSpire.PlayerFacingText.AiError(string)`；输入表达式：`PlayerFacingText.AiError(work.Error)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerFacingText.AiError(work.Error)`
- `NationalSpire.PlayerFacingText.AiErrorPreview(string)`；输入表达式：`PlayerFacingText.AiErrorPreview(work.Error)`；返回值紧邻使用处：`BinaryExpressionSyntax: "生成失败：" + PlayerFacingText.AiErrorPreview(work.Error)`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("News_")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("News_") ? "此帖" : "回应"`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("WeeklyNews_")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("WeeklyNews_") ? "周刊" : id.StartsWith("News_") ? "此帖" : "回应"`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("WeeklyProfiles_")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("WeeklyProfiles_") ? "档案" : id.StartsWith("WeeklyNews_") ? "周刊" : id.StartsWith("News_") ? "此帖" : "回应"`

**赋值（含属性/字段和局部值）：**

- `button.Name` = `"Retry_" + id`
- `CustomMinimumSize` = `new Vector2(600, 280)`
- `Editable` = `false`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `detail`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-8e1aa9b68d26"></a>

## `NationalSpire.CareerScreen.FocusComposerAsync() — private async Task FocusComposerAsync()`

来源：源码第 186 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`；`Godot.Node.IsInsideTree()`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；`Godot.TextEdit.SetCaretColumn(int, bool, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`ArgumentSyntax: GetTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`_scroll.EnsureControlVisible(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.EnsureControlVisible(editor);`
- `Godot.TextEdit.SetCaretColumn(int, bool, int)`；输入表达式：`editor.SetCaretColumn(editor.Text.Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.SetCaretColumn(editor.Text.Length);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "CommunityReplyEditor")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "CommunityReplyEditor") is TextEdit editor`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ae698159460a"></a>

## `NationalSpire.CommunityUpdateButton._Process(double) — public override void _Process(double delta)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-a39689737c6f)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Data`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`；`NationalSpire.CommunityUpdateButton._elapsed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f07878")`；返回值紧邻使用处：`ConditionalExpressionSyntax: count > 0 ? new Color("f07878") : CareerVisuals.Muted`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`AddThemeColorOverride("font_color", count > 0 ? new Color("f07878") : CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeColorOverride("font_color", count > 0 ? new Color("f07878") : CareerVisuals.Muted);`
- `NationalSpire.CommunityThreads.Unread(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.Unread(CareerStore.Data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.Unread(CareerStore.Data)`

**赋值（含属性/字段和局部值）：**

- `_elapsed` += `delta`
- `_elapsed` = `0`
- `Text` = `count > 0 ? $"●  社区更新 {count}" : "社区"`
