# CommunityScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`33D6CAAEC596BDFA609CD886B4D9FB4CF9FAD66AA6F9B1B5485259653496F1D1`。来源：[源码](../../CommunityScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CommunityUpdateButton`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, string> _replyTargets = new();
private readonly Dictionary<string, string> _replyDrafts = new();
private readonly Dictionary<string, HashSet<string>> _collapsedDiscussions = new();
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

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)；[`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._newPostBody`；`NationalSpire.CareerScreen._newPostTitle`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen.AddHeading(string, string)`；`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Back()`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "CommunityPostTitle", Text = _newPostTitle, PlaceholderText = "帖子标题", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "CommunityPostTitle", Text = _newPostTitle, PlaceholderText = "帖子标题", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("发布帖子", () =>          {              try              {                  if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;                  var post = CommunityThreads.Publish(data, title.Text, body.Text);                  _newPostTitle = ""; _newPostBody = "";                  _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);              }              catch (Exception e) { Notice(e.Message, true); }          }, 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("发布帖子", () =>          {              try              {                  if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;                  var post = CommunityThreads.Publish(data, title.Text, body.Text);                  _newPostTitle = ""; _newPostBody = "";                  _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);              }              catch (Exception e) { Notice(e.Message, true); }          }, 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("返回社区", Back, 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("返回社区", Back, 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
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
- `NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；输入表达式：`CommunityReplyExpressions.Attach(body, box, actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityReplyExpressions.Attach(body, box, actions);`
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

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`](CommunityScreen.cs.md#symbol-d9fcfe778254)

**调用：** [`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`](CommunityScreen.cs.md#symbol-283b456d2a7a)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-d891e2f0e3ea)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._postSignature`；`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`；`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.UpdateCommunityBadge()`；`NationalSpire.CareerScreen.UpdateNavigation()`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`；输入表达式：`RebuildThreadReplies(data, post, () =>          {              if (CareerVisuals.FindContent(_content, "ThreadHeader") is VBoxContainer header)              {                  CareerVisuals.ClearContent(header);                  RenderPostHeader(data, post, header); UpdateNavigation();              }              if (CareerVisuals.FindContent(_content, "ThreadDiscussion") is VBoxContainer discussion)              {                  CareerVisuals.ClearContent(discussion); RenderDiscussion(data, post, discussion);              }          })`；返回值紧邻使用处：`ExpressionStatementSyntax: RebuildThreadReplies(data, post, () =>          {              if (CareerVisuals.FindContent(_content, "ThreadHeader") is VBoxContainer header)              {                  CareerVisuals.ClearContent(header);                  RenderPostHeader(data, post, header); UpdateNavigation();              }              if (CareerVisuals.FindContent(_content, "ThreadDiscussion") is VBoxContainer discussion)              {                  CareerVisuals.ClearContent(discussion); RenderDiscussion(data, post, discussion);              }          });`
- `NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderDiscussion(data, post, discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderDiscussion(data, post, discussion);`
- `NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderPostHeader(data, post, header)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostHeader(data, post, header);`
- `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；输入表达式：`Signature(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _postSignature = Signature(data)`
- `NationalSpire.CareerScreen.UpdateCommunityBadge()`；输入表达式：`UpdateCommunityBadge()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateCommunityBadge();`
- `NationalSpire.CareerScreen.UpdateNavigation()`；输入表达式：`UpdateNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateNavigation();`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(discussion);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(header);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadDiscussion")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadDiscussion") is VBoxContainer discussion`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadHeader")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadHeader") is VBoxContainer header`
- `NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.MarkRead(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.MarkRead(data, post);`

**赋值（含属性/字段和局部值）：**

- `_postSignature` = `Signature(data)`

<a id="symbol-09dc30b97d0c"></a>

## `NationalSpire.CareerScreen.UpdateCommunityBadge() — private void UpdateCommunityBadge()`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-f92fad8b113e)；[`NationalSpire.CareerScreen.UpdateCommunityBadge()`](CommunityScreen.cs.md#symbol-09dc30b97d0c)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-d891e2f0e3ea)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`；`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.UpdateCommunityBadge()`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(discussion);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(header);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ThreadDiscussion", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ThreadDiscussion", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ThreadHeader", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ThreadHeader", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderDiscussion(data, post, discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderDiscussion(data, post, discussion);`
- `NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderPostHeader(data, post, header)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostHeader(data, post, header);`
- `NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`；输入表达式：`RenderReplyComposer(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderReplyComposer(data, post);`
- `NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`RenderRootReplyComposer(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderRootReplyComposer(data, post);`
- `NationalSpire.CareerScreen.UpdateCommunityBadge()`；输入表达式：`UpdateCommunityBadge()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateCommunityBadge();`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Any`
- `NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.MarkRead(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.MarkRead(data, post);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Any(p => p.Id == post.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.All(data).Any(p => p.Id == post.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.SavedThreads.Add(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.SavedThreads.Add(post);`

**赋值（含属性/字段和局部值）：**

- `Name` = `"ThreadDiscussion"`
- `Name` = `"ThreadHeader"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-f92fad8b113e"></a>

## `NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost) — private void RenderRootReplyComposer(CareerData data, CommunityPost post)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`](CommunityScreen.cs.md#symbol-283b456d2a7a)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(CreateReplyComposer(data, post, ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(CreateReplyComposer(data, post, ""));`
- `NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`；输入表达式：`CreateReplyComposer(data, post, "")`；返回值紧邻使用处：`ArgumentSyntax: CreateReplyComposer(data, post, "")`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "RootReplyComposer")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "RootReplyComposer") is Control composer`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.NewsPending(data, post)`

**赋值（含属性/字段和局部值）：**

- `composer.Visible` = `!pending`

<a id="symbol-85990747d510"></a>

## `NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?) — private void RenderReplyComposer(CareerData data, CommunityPost post, PanelContainer? retained = null)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`](CommunityScreen.cs.md#symbol-283b456d2a7a)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(CreateReplyComposer(data, post, parentId))`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(CreateReplyComposer(data, post, parentId));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(retained)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(retained);`
- `Godot.Node.QueueFree()`；输入表达式：`.QueueFree()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: retained?.QueueFree()`
- `NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`；输入表达式：`CreateReplyComposer(data, post, parentId)`；返回值紧邻使用处：`ArgumentSyntax: CreateReplyComposer(data, post, parentId)`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ReplyHost_" + parentId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ReplyHost_" + parentId) is not VBoxContainer host`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.NewsPending(data, post) || !_replyTargets.TryGetValue(post.Id, out string? parentId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_replyTargets.TryGetValue(post.Id, out string? parentId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_replyTargets.TryGetValue(post.Id, out string? parentId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-592b8f5f225f"></a>

## `NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string) — private PanelContainer CreateReplyComposer(CareerData data, CommunityPost post, string parentId)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-f92fad8b113e)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CloseThreadReply(string, string)`](CommunityScreen.cs.md#symbol-65baf7e888c9)；[`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`](CommunityScreen.cs.md#symbol-d9fcfe778254)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`](CommunityThreads.cs.md#symbol-4de765d004ff)；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.GetCaretLine(int)`；`Godot.TextEdit.GetLine(int)`；`Godot.TextEdit.GetLineCount()`；`Godot.TextEdit.SetCaretColumn(int, bool, int)`；`Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._replyDrafts`；`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CloseThreadReply(string, string)`；`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(close)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(close);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(submit)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(submit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cb.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: cb.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cb.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: cb.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cb.AddChild(Text(target == null ? "回复帖子" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)}", 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: cb.AddChild(Text(target == null ? "回复帖子" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)}", 18, _gold));`
- `Godot.TextEdit.GetCaretLine(int)`；输入表达式：`editor.GetCaretLine()`；返回值紧邻使用处：`ArgumentSyntax: editor.GetCaretLine()`
- `Godot.TextEdit.GetLine(int)`；输入表达式：`editor.GetLine(editor.GetCaretLine())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: editor.GetLine(editor.GetCaretLine()).Length`
- `Godot.TextEdit.GetLineCount()`；输入表达式：`editor.GetLineCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: editor.GetLineCount() - 1`
- `Godot.TextEdit.SetCaretColumn(int, bool, int)`；输入表达式：`editor.SetCaretColumn(editor.GetLine(editor.GetCaretLine()).Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.SetCaretColumn(editor.GetLine(editor.GetCaretLine()).Length);`
- `Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；输入表达式：`editor.SetCaretLine(editor.GetLineCount() - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.SetCaretLine(editor.GetLineCount() - 1);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = root ? "RootReplyEditor" : "CommunityReplyEditor", Text = _replyDrafts.GetValueOrDefault(draftKey, ""),              PlaceholderText = "说说你的想法，或继续上面的讨论……", CustomMinimumSize = new Vector2(0, 130),              SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = root ? "RootReplyEditor" : "CommunityReplyEditor", Text = _replyDrafts.GetValueOrDefault(draftKey, ""),              PlaceholderText = "说说你的想法，或继续上面的讨论……", CustomMinimumSize = new Vector2(0, 130),              SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 130)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 130)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([sent.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([sent.Id])`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, target.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, target.AuthorId)}`
- `NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`；输入表达式：`AddMentionPicker(editor, cb)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddMentionPicker(editor, cb);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("发布回复", () =>          {              try              {                  string submitted = editor.Text;                  _replyDrafts[draftKey] = submitted;                  if (MultiplayerCommand("reply", post.Id, submitted, parent: parentId,                      accepted: () => CompleteThreadReply(post.Id, parentId, submitted))) return;                  var current = ViewData;                  var thread = CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)                      ?? throw new InvalidOperationException("帖子已不存在。");                  var sent = CommunityThreads.Submit(current, thread, parentId, submitted);                  CompleteThreadReply(post.Id, parentId, submitted);                  _ = AiService.ProcessInteractionsAsync([sent.Id]);                  Notice("回复已发布。", false);              }              catch (Exception e) { Notice(e.Message, true); }          }, 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("发布回复", () =>          {              try              {                  string submitted = editor.Text;                  _replyDrafts[draftKey] = submitted;                  if (MultiplayerCommand("reply", post.Id, submitted, parent: parentId,                      accepted: () => CompleteThreadReply(post.Id, parentId, submitted))) return;                  var current = ViewData;                  var thread = CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)                      ?? throw new InvalidOperationException("帖子已不存在。");                  var sent = CommunityThreads.Submit(current, thread, parentId, submitted);                  CompleteThreadReply(post.Id, parentId, submitted);                  _ = AiService.ProcessInteractionsAsync([sent.Id]);                  Notice("回复已发布。", false);              }              catch (Exception e) { Notice(e.Message, true); }          }, 150)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("收起", () => CloseThreadReply(post.Id, parentId), 100)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("收起", () => CloseThreadReply(post.Id, parentId), 100)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CloseThreadReply(string, string)`；输入表达式：`CloseThreadReply(post.Id, parentId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CloseThreadReply(post.Id, parentId)`
- `NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`；输入表达式：`CompleteThreadReply(post.Id, parentId, submitted)`；返回值紧邻使用处：`ExpressionStatementSyntax: CompleteThreadReply(post.Id, parentId, submitted);`
- `NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`；输入表达式：`CompleteThreadReply(post.Id, parentId, submitted)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CompleteThreadReply(post.Id, parentId, submitted)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(composer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(composer)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("reply", post.Id, submitted, parent: parentId,                      accepted: () => CompleteThreadReply(post.Id, parentId, submitted))`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("reply", post.Id, submitted, parent: parentId,                      accepted: () => CompleteThreadReply(post.Id, parentId, submitted))) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("回复已发布。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("回复已发布。", false);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(target == null ? "回复帖子" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)}", 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(target == null ? "回复帖子" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)}", 18, _gold)`
- `NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；输入表达式：`CommunityReplyExpressions.Attach(editor, cb, actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityReplyExpressions.Attach(editor, cb, actions);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(current)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(current).FirstOrDefault`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`AssignmentExpressionSyntax: submit.Disabled = CommunityThreads.NewsPending(data, post)`
- `NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`；输入表达式：`CommunityThreads.Submit(current, thread, parentId, submitted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.Submit(current, thread, parentId, submitted)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)                      ?? throw new InvalidOperationException("帖子已不存在。")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.FirstOrDefault(r => r.Id == parentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.FirstOrDefault(r => r.Id == parentId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_replyDrafts.GetValueOrDefault(draftKey, "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = _replyDrafts.GetValueOrDefault(draftKey, "")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("帖子已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("帖子已不存在。")`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([sent.Id])`
- `_replyDrafts[draftKey]` = `editor.Text`
- `_replyDrafts[draftKey]` = `submitted`
- `close.Name` = `"CloseThreadReply"`
- `close.TooltipText` = `"收起回复栏，保留草稿"`
- `composer.Name` = `root ? "RootReplyComposer" : "ThreadReplyComposer"`
- `CustomMinimumSize` = `new Vector2(0, 130)`
- `editor.TextChanged` += `() => _replyDrafts[draftKey] = editor.Text`
- `Name` = `root ? "RootReplyEditor" : "CommunityReplyEditor"`
- `PlaceholderText` = `"说说你的想法，或继续上面的讨论……"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `submit.Disabled` = `CommunityThreads.NewsPending(data, post)`
- `submit.Name` = `root ? "SubmitRootReply" : "SubmitThreadReply"`
- `Text` = `_replyDrafts.GetValueOrDefault(draftKey, "")`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-283b456d2a7a"></a>

## `NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action) — private void RebuildThreadReplies(CareerData data, CommunityPost post, Action rebuild)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)

**调用：** [`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-f92fad8b113e)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetParent()`；`Godot.Node.GetViewport()`；`Godot.Node.IsAncestorOf(Godot.Node)`；`Godot.Node.IsInsideTree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.TextEdit.GetCaretColumn(int)`；`Godot.TextEdit.GetCaretLine(int)`；`Godot.TextEdit.GetSelectionOriginColumn(int)`；`Godot.TextEdit.GetSelectionOriginLine(int)`；`Godot.TextEdit.HasSelection(int)`；`Godot.TextEdit.Select(int, int, int, int, int)`；`Godot.Viewport.GuiGetFocusOwner()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `(int Line, int Column, int CaretLine, int CaretColumn).CaretColumn`；`(int Line, int Column, int CaretLine, int CaretColumn).CaretLine`；`(int Line, int Column, int CaretLine, int CaretColumn).Column`；`(int Line, int Column, int CaretLine, int CaretColumn).Line`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`；`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`focused.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: focused.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(editor)`；返回值紧邻使用处：`BinaryExpressionSyntax: selection is { } selected && editor != null && IsInstanceValid(editor)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(focused)`；返回值紧邻使用处：`BinaryExpressionSyntax: restoreFocus && focused != null && IsInstanceValid(focused)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`editor.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !editor.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`focused.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !focused.IsQueuedForDeletion()`
- `Godot.Node.GetParent()`；输入表达式：`composer.GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: composer.GetParent().RemoveChild`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Node.IsAncestorOf(Godot.Node)`；输入表达式：`composer.IsAncestorOf(focused)`；返回值紧邻使用处：`BinaryExpressionSyntax: composer != null && focused != null && composer.IsAncestorOf(focused)`
- `Godot.Node.IsInsideTree()`；输入表达式：`editor.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: selection is { } selected && editor != null && IsInstanceValid(editor) && editor.IsInsideTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`focused.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: restoreFocus && focused != null && IsInstanceValid(focused) && focused.IsInsideTree()`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`composer.GetParent().RemoveChild(composer)`；返回值紧邻使用处：`ExpressionStatementSyntax: composer.GetParent().RemoveChild(composer);`
- `Godot.TextEdit.GetCaretColumn(int)`；输入表达式：`editor.GetCaretColumn()`；返回值紧邻使用处：`ArgumentSyntax: CaretColumn: editor.GetCaretColumn()`
- `Godot.TextEdit.GetCaretLine(int)`；输入表达式：`editor.GetCaretLine()`；返回值紧邻使用处：`ArgumentSyntax: CaretLine: editor.GetCaretLine()`
- `Godot.TextEdit.GetSelectionOriginColumn(int)`；输入表达式：`editor.GetSelectionOriginColumn()`；返回值紧邻使用处：`ArgumentSyntax: Column: editor.GetSelectionOriginColumn()`
- `Godot.TextEdit.GetSelectionOriginLine(int)`；输入表达式：`editor.GetSelectionOriginLine()`；返回值紧邻使用处：`ArgumentSyntax: Line: editor.GetSelectionOriginLine()`
- `Godot.TextEdit.HasSelection(int)`；输入表达式：`.HasSelection()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: editor?.HasSelection()`
- `Godot.TextEdit.Select(int, int, int, int, int)`；输入表达式：`editor.Select(selected.Line, selected.Column, selected.CaretLine, selected.CaretColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.Select(selected.Line, selected.Column, selected.CaretLine, selected.CaretColumn);`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetFocusOwner()`
- `NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`；输入表达式：`RenderReplyComposer(data, post, composer)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderReplyComposer(data, post, composer);`
- `NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`RenderRootReplyComposer(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderRootReplyComposer(data, post);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadReplyComposer")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadReplyComposer") as PanelContainer`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(composer, "CommunityReplyEditor")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerVisuals.FindContent(composer, "CommunityReplyEditor") as TextEdit`
- `System.Action.Invoke()`；输入表达式：`rebuild()`；返回值紧邻使用处：`ExpressionStatementSyntax: rebuild();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9fcfe778254"></a>

## `NationalSpire.CareerScreen.CompleteThreadReply(string, string, string) — private void CompleteThreadReply(string postId, string parentId, string submitted)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)

**调用：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._replyDrafts`；`NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`RefreshDiscussion(ViewData, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDiscussion(ViewData, post);`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(position, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(position, _renderVersion)`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "RootReplyEditor")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "RootReplyEditor") is TextEdit editor`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(ViewData).FirstOrDefault`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_replyDrafts.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyDrafts.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_replyTargets.Remove(postId)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyTargets.Remove(postId);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_replyTargets.TryGetValue(postId, out string? active)`；返回值紧邻使用处：`BinaryExpressionSyntax: _replyTargets.TryGetValue(postId, out string? active) && active == parentId`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == postId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == postId) is { } post`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_replyDrafts.GetValueOrDefault(key, "")`；返回值紧邻使用处：`BinaryExpressionSyntax: _replyDrafts.GetValueOrDefault(key, "") == submitted`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(position, _renderVersion)`
- `editor.Text` = `""`

<a id="symbol-65baf7e888c9"></a>

## `NationalSpire.CareerScreen.CloseThreadReply(string, string) — private void CloseThreadReply(string postId, string parentId)`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；[`NationalSpire.CareerScreen.RetireReplyComposer()`](CommunityScreen.cs.md#symbol-aebacdaad363)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.Control.GrabFocus()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.StopMotion()`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.RetireReplyComposer()`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`button.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: button.GrabFocus();`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`scrolling.StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: scrolling.StopMotion();`
- `NationalSpire.CareerScreen.RetireReplyComposer()`；输入表达式：`RetireReplyComposer()`；返回值紧邻使用处：`ExpressionStatementSyntax: RetireReplyComposer();`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, buttonName)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, buttonName) is Button button`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_replyTargets.Remove(postId)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyTargets.Remove(postId);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_replyTargets.TryGetValue(postId, out string? active)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_replyTargets.TryGetValue(postId, out string? active)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aebacdaad363"></a>

## `NationalSpire.CareerScreen.RetireReplyComposer() — private void RetireReplyComposer()`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.CloseThreadReply(string, string)`](CommunityScreen.cs.md#symbol-65baf7e888c9)

**调用：** [`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.CanvasItem.Hide()`；`Godot.GodotObject.GetInstanceId()`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`composer.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: composer.Hide();`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`composer.GetInstanceId()`；返回值紧邻使用处：`BinaryExpressionSyntax: "Retired_" + composer.GetInstanceId()`
- `Godot.Node.QueueFree()`；输入表达式：`composer.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: composer.QueueFree();`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadReplyComposer")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadReplyComposer") is not Control composer`

**赋值（含属性/字段和局部值）：**

- `composer.Name` = `"Retired_" + composer.GetInstanceId()`
- `composer.ProcessMode` = `ProcessModeEnum.Disabled`

<a id="symbol-4c514e4927ad"></a>

## `NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer) — private void RenderPostHeader(CareerData data, CommunityPost post, VBoxContainer header)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.RetryNewsAsync(string)`](AiService.cs.md#symbol-4e15401241c3)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityShareScreen.cs.md#symbol-411381a49420)；[`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-28983a9b63fd)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.AiService.RetryNewsAsync(string)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CommunityPost.Analysis`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.ReactionGeneration`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`authorMargin.AddThemeConstantOverride("margin_right", (int)card.GetThemeStylebox("panel").ContentMarginRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: authorMargin.AddThemeConstantOverride("margin_right", (int)card.GetThemeStylebox("panel").ContentMarginRight);`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`card.GetThemeStylebox("panel")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: card.GetThemeStylebox("panel").ContentMarginRight`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`author.AddChild(DiscussionVotes(data, post))`；返回值紧邻使用处：`ExpressionStatementSyntax: author.AddChild(DiscussionVotes(data, post));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`author.AddChild(WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56))`；返回值紧邻使用处：`ExpressionStatementSyntax: author.AddChild(WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`authorMargin.AddChild(author)`；返回值紧邻使用处：`ExpressionStatementSyntax: authorMargin.AddChild(author);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(DiscussionActions(data, post))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(DiscussionActions(data, post));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(authorMargin)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(authorMargin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(Text($"{GameCalendar.Text(data, post.Day)} · {post.Category}", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(Text($"{GameCalendar.Text(data, post.Day)} · {post.Category}", 16, _muted));`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([post.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([post.Id])`
- `NationalSpire.AiService.RetryNewsAsync(string)`；输入表达式：`AiService.RetryNewsAsync(post.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.RetryNewsAsync(post.Id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, post.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, post.AuthorId)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, post.AuthorId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, post.AuthorId)?.Country`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`DiscussionActions(data, post)`；返回值紧邻使用处：`ArgumentSyntax: DiscussionActions(data, post)`
- `NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`DiscussionVotes(data, post)`；返回值紧邻使用处：`ArgumentSyntax: DiscussionVotes(data, post)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople)`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId))`
- `NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderPostBackground(data, post, header)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderPostBackground(data, post, header);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(header, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(header, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(header, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(header, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, post.Day)} · {post.Category}", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, post.Day)} · {post.Category}", 16, _muted)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, post.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.NewsPending(data, post)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, post.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, post.Day)}`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: post.RelatedPeople.Append(post.AuthorId)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([post.Id])`
- `_` = `AiService.RetryNewsAsync(post.Id)`
- `body.Name` = `"ReplyHost_"`

<a id="symbol-2d520c5b6596"></a>

## `NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer) — private void RenderPostBackground(CareerData data, CommunityPost post, VBoxContainer header)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderThread(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-054ede707cf5)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)

**调用：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityShareScreen.cs.md#symbol-411381a49420)；[`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-28983a9b63fd)；[`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`NationalSpire.CommunityDiscussionLayout.Build(NationalSpire.CommunityPost, System.Collections.Generic.IReadOnlySet<string>)`](CommunityDiscussionLayout.cs.md#symbol-abc2f068bbc7)；[`NationalSpire.CommunityDiscussionLines.ConnectReply(Godot.Control, Godot.Control)`](CommunityDiscussionVisuals.cs.md#symbol-1122f82357ce)；[`NationalSpire.CommunityDiscussionLines.RegisterToggle(Godot.Control)`](CommunityDiscussionVisuals.cs.md#symbol-bd63ab26d1a0)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CommunityBranchToggle.CommunityBranchToggle()`；`NationalSpire.CommunityDiscussionLines.CommunityDiscussionLines()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerScreen._collapsedDiscussions`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CommunityBranchToggle.Collapsed`；`NationalSpire.CommunityDiscussionLayout.Build(NationalSpire.CommunityPost, System.Collections.Generic.IReadOnlySet<string>)`；`NationalSpire.CommunityDiscussionLayout.Item.Depth`；`NationalSpire.CommunityDiscussionLayout.Item.Descendants`；`NationalSpire.CommunityDiscussionLayout.Item.Floor`；`NationalSpire.CommunityDiscussionLayout.Item.Parent`；`NationalSpire.CommunityDiscussionLayout.Item.Reply`；`NationalSpire.CommunityDiscussionLayout.Item.Visible`；`NationalSpire.CommunityDiscussionLines.AnchorY`；`NationalSpire.CommunityDiscussionLines.ConnectReply(Godot.Control, Godot.Control)`；`NationalSpire.CommunityDiscussionLines.Gutter`；`NationalSpire.CommunityDiscussionLines.Indent`；`NationalSpire.CommunityDiscussionLines.MaximumIndentDepth`；`NationalSpire.CommunityDiscussionLines.RegisterToggle(Godot.Control)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.NeedsReaction`；`NationalSpire.CommunityReply.ReactionGeneration`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 0);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new Vector2(inset, 0), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new Vector2(inset, 0), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "Comment_" + reply.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "Comment_" + reply.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(DiscussionActions(data, post, reply))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(DiscussionActions(data, post, reply));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(head)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(head);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"已收起 {item.Descendants} 条回复", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"已收起 {item.Descendants} 条回复", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`discussion.AddChild(Text("大家还在赶来……", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: discussion.AddChild(Text("大家还在赶来……", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`discussion.AddChild(Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: discussion.AddChild(Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`discussion.AddChild(tree)`；返回值紧邻使用处：`ExpressionStatementSyntax: discussion.AddChild(tree);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`gutter.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: gutter.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(DiscussionVotes(data, post, reply))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(DiscussionVotes(data, post, reply));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(c);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(gutter)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(gutter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tree.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: tree.AddChild(row);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position = new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(inset, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(inset, 0)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([reply.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([reply.Id])`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, reply.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, reply.AuthorId)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, reply.AuthorId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, reply.AuthorId)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`DiscussionActions(data, post, reply)`；返回值紧邻使用处：`ArgumentSyntax: DiscussionActions(data, post, reply)`
- `NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`DiscussionVotes(data, post, reply)`；返回值紧邻使用处：`ArgumentSyntax: DiscussionVotes(data, post, reply)`
- `NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`；输入表达式：`GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(c)`
- `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId))`
- `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`；输入表达式：`RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("大家还在赶来……", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("大家还在赶来……", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"已收起 {item.Descendants} 条回复", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"已收起 {item.Descendants} 条回复", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink)`
- `NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`；输入表达式：`ToggleDiscussion(post, reply.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ToggleDiscussion(post, reply.Id)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42)`
- `NationalSpire.CommunityBranchToggle.CommunityBranchToggle()`；输入表达式：`new CommunityBranchToggle                  {                      Name = "ToggleReplies_" + reply.Id, Collapsed = isCollapsed,                      Position = new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14),                      TooltipText = $"{(isCollapsed ? "展开" : "收起")}这条评论下的 {item.Descendants} 条回复"                  }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityBranchToggle                  {                      Name = "ToggleReplies_" + reply.Id, Collapsed = isCollapsed,                      Position = new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14),                      TooltipText = $"{(isCollapsed ? "展开" : "收起")}这条评论下的 {item.Descendants} 条回复"                  }`
- `NationalSpire.CommunityDiscussionLayout.Build(NationalSpire.CommunityPost, System.Collections.Generic.IReadOnlySet<string>)`；输入表达式：`CommunityDiscussionLayout.Build(post, collapsed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityDiscussionLayout.Build(post, collapsed)`
- `NationalSpire.CommunityDiscussionLines.CommunityDiscussionLines()`；输入表达式：`new CommunityDiscussionLines { Name = "DiscussionTree", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityDiscussionLines { Name = "DiscussionTree", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CommunityDiscussionLines.ConnectReply(Godot.Control, Godot.Control)`；输入表达式：`tree.ConnectReply(parentCard, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: tree.ConnectReply(parentCard, c);`
- `NationalSpire.CommunityDiscussionLines.RegisterToggle(Godot.Control)`；输入表达式：`tree.RegisterToggle(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: tree.RegisterToggle(c);`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`IfStatementSyntax: if (CommunityThreads.NewsPending(data, post)) { discussion.AddChild(Text("大家还在赶来……", 17, _muted)); return; }`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, reply.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, reply.Day)}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Control>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Control>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_collapsedDiscussions.TryGetValue(post.Id, out var collapsed)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_collapsedDiscussions.TryGetValue(post.Id, out var collapsed)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`cards.TryGetValue(parent.Reply.Id, out var parentCard)`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Parent is { } parent && cards.TryGetValue(parent.Reply.Id, out var parentCard)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`collapsed.Contains(reply.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = collapsed.Contains(reply.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`post.RelatedPeople.Append(post.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Append(post.AuthorId).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.Where(item => item.Visible)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in items.Where(item => item.Visible))          {              var reply = item.Reply;              int inset = CommunityDiscussionLines.Gutter + Math.Min(item.Depth, CommunityDiscussionLines.MaximumIndentDepth) * CommunityDiscussionLines.Indent;              var row = new HBoxContainer { Name = "Comment_" + reply.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill };              row.AddThemeConstantOverride("separation", 0); tree.AddChild(row);              var gutter = new Control { CustomMinimumSize = new Vector2(inset, 0), MouseFilter = MouseFilterEnum.Ignore };              row.AddChild(gutter);              var c = Card(); row.AddChild(c); var box = Inner(c); box.Name = "ReplyHost_" + reply.Id; cards[reply.Id] = c;              if (item.Parent is { } parent && cards.TryGetValue(parent.Reply.Id, out var parentCard)) tree.ConnectReply(parentCard, c);              bool isCollapsed = collapsed.Contains(reply.Id);              if (item.Descendants > 0)              {                  tree.RegisterToggle(c);                  var toggle = new CommunityBranchToggle                  {                      Name = "ToggleReplies_" + reply.Id, Collapsed = isCollapsed,                      Position = new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14),                      TooltipText = $"{(isCollapsed ? "展开" : "收起")}这条评论下的 {item.Descendants} 条回复"                  };                  toggle.Pressed += () => ToggleDiscussion(post, reply.Id);                  gutter.AddChild(toggle);              }              var head = new HBoxContainer(); box.AddChild(head);              var speaker = CareerEngine.Person(data, reply.AuthorId);              string caption = $"{CareerEngine.DisplayName(data, reply.AuthorId)}  ·  {speaker?.Country ?? data.Esports.Country}赛区\n{item.Floor}L" + (item.Depth > 0 ? $" · 楼中楼" : "") + $"  ·  {GameCalendar.Text(data, reply.Day)}";              head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42));              head.AddChild(DiscussionVotes(data, post, reply));              box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)));              box.AddChild(DiscussionActions(data, post, reply));              if (isCollapsed && item.Descendants > 0) box.AddChild(Text($"已收起 {item.Descendants} 条回复", 14, _muted));              if (reply.NeedsReaction) RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id);          }`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(item.Depth, CommunityDiscussionLines.MaximumIndentDepth)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(item.Depth, CommunityDiscussionLines.MaximumIndentDepth) * CommunityDiscussionLines.Indent`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([reply.Id])`
- `_collapsedDiscussions[post.Id]` = `collapsed = []`
- `box.Name` = `"ReplyHost_" + reply.Id`
- `cards[reply.Id]` = `c`
- `collapsed` = `[]`
- `Collapsed` = `isCollapsed`
- `CustomMinimumSize` = `new Vector2(inset, 0)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"Comment_" + reply.Id`
- `Name` = `"DiscussionTree"`
- `Name` = `"ToggleReplies_" + reply.Id`
- `Position` = `new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `toggle.Pressed` += `() => ToggleDiscussion(post, reply.Id)`
- `TooltipText` = `$"{(isCollapsed ? "展开" : "收起")}这条评论下的 {item.Descendants} 条回复"`

<a id="symbol-28983a9b63fd"></a>

## `NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?) — private HBoxContainer DiscussionVotes(CareerData data, CommunityPost post, CommunityReply? reply = null)`

来源：源码第 274 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-9e2d9445fdf4)；[`Vote(int)`](CommunityScreen.cs.md#symbol-8f211a670431)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CommunityVoteButton.CommunityVoteButton()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityVoteButton.Direction`；`NationalSpire.CommunityVoteButton.MainPost`；`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；`Vote(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 4);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(down)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(down);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(score)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(score);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(up)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(up);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(32, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: score.CustomMinimumSize = new Vector2(32, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", reply == null ? 18 : 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", reply == null ? 18 : 16, _ink)`
- `NationalSpire.CommunityVoteButton.CommunityVoteButton()`；输入表达式：`new CommunityVoteButton { Name = "VoteDown_" + suffix, Direction = -1, MainPost = reply == null, ToggleMode = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityVoteButton { Name = "VoteDown_" + suffix, Direction = -1, MainPost = reply == null, ToggleMode = true }`
- `NationalSpire.CommunityVoteButton.CommunityVoteButton()`；输入表达式：`new CommunityVoteButton { Name = "VoteUp_" + suffix, Direction = 1, MainPost = reply == null, ToggleMode = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityVoteButton { Name = "VoteUp_" + suffix, Direction = 1, MainPost = reply == null, ToggleMode = true }`
- `Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`Update(data, post, reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(data, post, reply);`
- `Vote(int)`；输入表达式：`Vote(-1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Vote(-1)`
- `Vote(int)`；输入表达式：`Vote(1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Vote(1)`

**赋值（含属性/字段和局部值）：**

- `Direction` = `-1`
- `Direction` = `1`
- `down.Pressed` += `() => Vote(-1)`
- `MainPost` = `reply == null`
- `Name` = `"VoteDown_" + suffix`
- `Name` = `"VoteUp_" + suffix`
- `score.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `score.CustomMinimumSize` = `new Vector2(32, 0)`
- `score.HorizontalAlignment` = `HorizontalAlignment.Center`
- `score.MouseFilter` = `MouseFilterEnum.Pass`
- `score.Name` = `"VoteScore_" + suffix`
- `score.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `ToggleMode` = `true`
- `up.Pressed` += `() => Vote(1)`

<a id="symbol-9e2d9445fdf4"></a>

## `Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?) — void Update(CareerData current, CommunityPost currentPost, CommunityReply? currentReply)`

来源：源码第 289 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-28983a9b63fd)；[`Vote(int)`](CommunityScreen.cs.md#symbol-8f211a670431)

**调用：** [`NationalSpire.CommunityVotes.AudienceScore(int?)`](CommunityVotes.cs.md#symbol-9f70e52b989b)；[`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-64a35a4c39c2)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-37dbe54453ea)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-9cdbeae87bc5)；[`NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-c51f3ec0b04f)；[`NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-90f30ba43b83)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CanvasItem.QueueRedraw()`；`long.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AudienceScore`；`NationalSpire.CommunityReply.AudienceScore`；`NationalSpire.CommunityVotes.AudienceScore(int?)`；`NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`；`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`；`NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`；`NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`down.SetPressedNoSignal(choice == -1)`；返回值紧邻使用处：`ExpressionStatementSyntax: down.SetPressedNoSignal(choice == -1);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`up.SetPressedNoSignal(choice == 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: up.SetPressedNoSignal(choice == 1);`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`down.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: down.QueueRedraw();`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`up.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: up.QueueRedraw();`
- `long.ToString()`；输入表达式：`total.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: score.Text = total.ToString()`
- `NationalSpire.CommunityVotes.AudienceScore(int?)`；输入表达式：`CommunityVotes.AudienceScore(basis)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.AudienceScore(basis) : CommunityVotes.AudienceScore(current, currentReply)`
- `NationalSpire.CommunityVotes.AudienceScore(NationalSpire.CareerData, NationalSpire.CommunityReply)`；输入表达式：`CommunityVotes.AudienceScore(current, currentReply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.AudienceScore(basis) : CommunityVotes.AudienceScore(current, currentReply)`
- `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityVotes.Choice(current, currentPost)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.Choice(current, currentPost) : CommunityVotes.Choice(current, currentReply)`
- `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`；输入表达式：`CommunityVotes.Choice(current, currentReply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.Choice(current, currentPost) : CommunityVotes.Choice(current, currentReply)`
- `NationalSpire.CommunityVotes.Score(NationalSpire.CareerData, NationalSpire.CommunityReply)`；输入表达式：`CommunityVotes.Score(current, currentReply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.Score(currentPost) : CommunityVotes.Score(current, currentReply)`
- `NationalSpire.CommunityVotes.Score(NationalSpire.CommunityPost)`；输入表达式：`CommunityVotes.Score(currentPost)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.Score(currentPost) : CommunityVotes.Score(current, currentReply)`

**赋值（含属性/字段和局部值）：**

- `down.TooltipText` = `choice == -1 ? "取消点踩" : "点踩"`
- `score.Text` = `total.ToString()`
- `score.TooltipText` = `$"受众净赞数：{audience}"                  + (choice == 1 ? "\n你已点赞（+1）" : choice == -1 ? "\n你已点踩（-1）" : "\n点击赞踩表达态度")`
- `up.TooltipText` = `choice == 1 ? "取消点赞" : "点赞"`

<a id="symbol-8f211a670431"></a>

## `Vote(int) — void Vote(int direction)`

来源：源码第 303 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DiscussionVotes(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-28983a9b63fd)

**调用：** [`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-cfc51eea9b9f)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityVotes.cs.md#symbol-37dbe54453ea)；[`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`](CommunityVotes.cs.md#symbol-9cdbeae87bc5)；[`NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`](CommunityVotes.cs.md#symbol-99e71e3dfed8)；[`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`](CommunityVotes.cs.md#symbol-6ae34f6f4987)；[`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityScreen.cs.md#symbol-9e2d9445fdf4)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._postSignature`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.VoteRevision`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`；`NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`；`NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`；`Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("community-vote", post.Id, number: next, parent: replyId)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("community-vote", post.Id, number: next, parent: replyId))                  { Update(current, currentPost, currentReply); return; }`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；输入表达式：`Signature(current)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _postSignature = Signature(current)`
- `NationalSpire.CareerScreen.Signature(NationalSpire.CareerData)`；输入表达式：`Signature(current)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Signature(current)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(current)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(current);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(current)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(current).FirstOrDefault`
- `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityVotes.Choice(current, currentPost)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.Choice(current, currentPost) : CommunityVotes.Choice(current, currentReply)`
- `NationalSpire.CommunityVotes.Choice(NationalSpire.CareerData, NationalSpire.CommunityReply)`；输入表达式：`CommunityVotes.Choice(current, currentReply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: currentReply == null ? CommunityVotes.Choice(current, currentPost) : CommunityVotes.Choice(current, currentReply)`
- `NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`；输入表达式：`CommunityVotes.SetVote(current, post.Id, replyId, choice, voter)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityVotes.SetVote(current, post.Id, replyId, choice, voter);`
- `NationalSpire.CommunityVotes.SetVote(NationalSpire.CareerData, string, string, int, string)`；输入表达式：`CommunityVotes.SetVote(current, post.Id, replyId, next, voter)`；返回值紧邻使用处：`IfStatementSyntax: if (CommunityVotes.SetVote(current, post.Id, replyId, next, voter))                  {                      try { CareerStore.Save(current); }                      catch                      {                          CommunityVotes.SetVote(current, post.Id, replyId, choice, voter);                          currentPost.VoteRevision = voteRevision;                          throw;                      }                  }`
- `NationalSpire.CommunityVotes.VoterId(NationalSpire.CareerData)`；输入表达式：`CommunityVotes.VoterId(current)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityVotes.VoterId(current)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)                      ?? throw new InvalidOperationException("帖子已不存在。")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`currentPost.Replies.FirstOrDefault(r => r.Id == replyId)`；返回值紧邻使用处：`BinaryExpressionSyntax: currentPost.Replies.FirstOrDefault(r => r.Id == replyId)                      ?? throw new InvalidOperationException("回复的楼层已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("回复的楼层已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("回复的楼层已不存在。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("帖子已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("帖子已不存在。")`
- `Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`Update(current, currentPost, currentReply)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(current, currentPost, currentReply);`
- `Update(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`；输入表达式：`Update(data, post, reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(data, post, reply);`

**赋值（含属性/字段和局部值）：**

- `_postSignature` = `Signature(current)`
- `currentPost.VoteRevision` = `voteRevision`

<a id="symbol-8aac83a49357"></a>

## `NationalSpire.CareerScreen.DiscussionReplyButton(NationalSpire.CommunityPost, string, bool) — private Button DiscussionReplyButton(CommunityPost post, string parent, bool mainPost = false)`

来源：源码第 339 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DiscussionActions(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CommunityReply?)`](CommunityShareScreen.cs.md#symbol-411381a49420)

**调用：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；`NationalSpire.CommunityReplyButton.CommunityReplyButton()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`；`NationalSpire.CommunityReplyButton.MainPost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`；输入表达式：`BeginReply(post, parent)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => BeginReply(post, parent)`
- `NationalSpire.CommunityReplyButton.CommunityReplyButton()`；输入表达式：`new CommunityReplyButton          {              Name = parent.Length == 0 ? "ReplyToPost" : "ReplyTo_" + parent,              MainPost = mainPost, TooltipText = parent.Length == 0 ? "回复帖子" : "回复这条评论"          }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityReplyButton          {              Name = parent.Length == 0 ? "ReplyToPost" : "ReplyTo_" + parent,              MainPost = mainPost, TooltipText = parent.Length == 0 ? "回复帖子" : "回复这条评论"          }`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `() => BeginReply(post, parent)`
- `MainPost` = `mainPost`
- `Name` = `parent.Length == 0 ? "ReplyToPost" : "ReplyTo_" + parent`
- `TooltipText` = `parent.Length == 0 ? "回复帖子" : "回复这条评论"`

<a id="symbol-10637dfc37f0"></a>

## `NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string) — private void ToggleDiscussion(CommunityPost post, string replyId)`

来源：源码第 349 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；[`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`](CommunityScreen.cs.md#symbol-283b456d2a7a)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.Control.GrabFocus()`；`Godot.Node.GetViewport()`；`Godot.Viewport.GuiGetFocusOwner()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.StopMotion()`；`NationalSpire.CareerScreen._collapsedDiscussions`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`；`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`toggle.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.GrabFocus();`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GetViewport().GuiGetFocusOwner()?.Name`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`scrolling.StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: scrolling.StopMotion();`
- `NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`；输入表达式：`RebuildThreadReplies(ViewData, post, () => { CareerVisuals.ClearContent(discussion); RenderDiscussion(ViewData, post, discussion); })`；返回值紧邻使用处：`ExpressionStatementSyntax: RebuildThreadReplies(ViewData, post, () => { CareerVisuals.ClearContent(discussion); RenderDiscussion(ViewData, post, discussion); });`
- `NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`；输入表达式：`RenderDiscussion(ViewData, post, discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderDiscussion(ViewData, post, discussion);`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(position, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(position, _renderVersion)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(discussion)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(discussion);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "ThreadDiscussion")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, "ThreadDiscussion") is not VBoxContainer discussion`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(discussion, toggleName)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(discussion, toggleName) is Button toggle`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_collapsedDiscussions.TryGetValue(post.Id, out var collapsed)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_collapsedDiscussions.TryGetValue(post.Id, out var collapsed)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`collapsed.Add(replyId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !collapsed.Add(replyId)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`collapsed.Remove(replyId)`；返回值紧邻使用处：`ExpressionStatementSyntax: collapsed.Remove(replyId);`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(position, _renderVersion)`

<a id="symbol-6bc7befbb991"></a>

## `NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string) — private void BeginReply(CommunityPost post, string parent)`

来源：源码第 363 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DiscussionReplyButton(NationalSpire.CommunityPost, string, bool)`](CommunityScreen.cs.md#symbol-8aac83a49357)

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；[`NationalSpire.CareerScreen.CloseThreadReply(string, string)`](CommunityScreen.cs.md#symbol-65baf7e888c9)；[`NationalSpire.CareerScreen.FocusComposerAsync(string)`](CommunityScreen.cs.md#symbol-1b316c95919c)；[`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RetireReplyComposer()`](CommunityScreen.cs.md#symbol-aebacdaad363)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.StopMotion()`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.CloseThreadReply(string, string)`；`NationalSpire.CareerScreen.FocusComposerAsync(string)`；`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`；`NationalSpire.CareerScreen.RetireReplyComposer()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`rootScroll.StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: rootScroll.StopMotion();`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`scrolling.StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: scrolling.StopMotion();`
- `NationalSpire.CareerScreen.CloseThreadReply(string, string)`；输入表达式：`CloseThreadReply(post.Id, parent)`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseThreadReply(post.Id, parent);`
- `NationalSpire.CareerScreen.FocusComposerAsync(string)`；输入表达式：`FocusComposerAsync("RootReplyEditor")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = FocusComposerAsync("RootReplyEditor")`
- `NationalSpire.CareerScreen.FocusComposerAsync(string)`；输入表达式：`FocusComposerAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = FocusComposerAsync()`
- `NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`；输入表达式：`RenderReplyComposer(ViewData, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderReplyComposer(ViewData, post);`
- `NationalSpire.CareerScreen.RetireReplyComposer()`；输入表达式：`RetireReplyComposer()`；返回值紧邻使用处：`ExpressionStatementSyntax: RetireReplyComposer();`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "CommunityReplyEditor")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerVisuals.FindContent(_content, "CommunityReplyEditor") != null`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, "CommunityReplyEditor")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerVisuals.FindContent(_content, "CommunityReplyEditor") == null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_replyTargets.TryGetValue(post.Id, out string? active)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_replyTargets.TryGetValue(post.Id, out string? active)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_replyTargets.TryGetValue(post.Id, out string? current)`；返回值紧邻使用处：`BinaryExpressionSyntax: _replyTargets.TryGetValue(post.Id, out string? current) && current == parent`

**赋值（含属性/字段和局部值）：**

- `_` = `FocusComposerAsync("RootReplyEditor")`
- `_` = `FocusComposerAsync()`
- `_replyTargets[post.Id]` = `parent`

<a id="symbol-6bdab2812eba"></a>

## `NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string) — private void RenderWorkStatus(VBoxContainer box, AiWorkState work, Action retry, string id)`

来源：源码第 384 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.Diagnostics.ErrorDetail(string)`](ErrorDiagnostics.cs.md#symbol-1825d5559456)；[`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；[`NationalSpire.PlayerFacingText.AiErrorPreview(string)`](PlayerFacingText.cs.md#symbol-fc1bb7a47c87)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.DisplayServer.ClipboardSet(string)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`string.StartsWith(string)`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.AiWorkState.WaitReason`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.Diagnostics.ErrorDetail(string)`；`NationalSpire.PlayerFacingText.AiError(string)`；`NationalSpire.PlayerFacingText.AiErrorPreview(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f07878")`；返回值紧邻使用处：`ConditionalExpressionSyntax: work.State == "failed" ? new Color("f07878") : _muted`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`editor.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.DisplayServer.ClipboardSet(string)`；输入表达式：`DisplayServer.ClipboardSet(original)`；返回值紧邻使用处：`ExpressionStatementSyntax: DisplayServer.ClipboardSet(original);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));                  });              }, 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));                  });              }, 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(600, 280)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(600, 280)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));                  });              }, 120)`；返回值紧邻使用处：`ArgumentSyntax: Button("错误详情", () =>              {                  string detail = PlayerFacingText.AiError(work.Error);                  ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));                  });              }, 120)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150)`；返回值紧邻使用处：`ArgumentSyntax: Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("重试" + scope, retry, 120)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("重试" + scope, retry, 120)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));                  })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>                  {                      var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };                      editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);                      contents.AddChild(Button("复制错误", async () =>                      {                          string error = work.Error;                          string original = await Task.Run(() => Diagnostics.ErrorDetail(error));                          DisplayServer.ClipboardSet(original);                      }, 150));                  });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(caption, 14, work.State == "failed" ? new Color("f07878") : _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(caption, 14, work.State == "failed" ? new Color("f07878") : _muted)`
- `NationalSpire.Diagnostics.ErrorDetail(string)`；输入表达式：`Diagnostics.ErrorDetail(error)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Diagnostics.ErrorDetail(error)`
- `NationalSpire.PlayerFacingText.AiError(string)`；输入表达式：`PlayerFacingText.AiError(work.Error)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerFacingText.AiError(work.Error)`
- `NationalSpire.PlayerFacingText.AiErrorPreview(string)`；输入表达式：`PlayerFacingText.AiErrorPreview(work.Error)`；返回值紧邻使用处：`BinaryExpressionSyntax: "生成失败：" + PlayerFacingText.AiErrorPreview(work.Error)`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("News_")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("News_") ? "此帖" : "回应"`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("WeeklyNews_")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("WeeklyNews_") ? "周刊" : id.StartsWith("News_") ? "此帖" : "回应"`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("WeeklyProfiles_")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("WeeklyProfiles_") ? "档案" : id.StartsWith("WeeklyNews_") ? "周刊" : id.StartsWith("News_") ? "此帖" : "回应"`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(() => Diagnostics.ErrorDetail(error))`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Run(() => Diagnostics.ErrorDetail(error))`

**赋值（含属性/字段和局部值）：**

- `button.Name` = `"Retry_" + id`
- `CustomMinimumSize` = `new Vector2(600, 280)`
- `Editable` = `false`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `detail`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-1b316c95919c"></a>

## `NationalSpire.CareerScreen.FocusComposerAsync(string) — private async Task FocusComposerAsync(string editorName = "CommunityReplyEditor")`

来源：源码第 412 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)

**调用：** [`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`；`Godot.Node.IsInsideTree()`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`editor.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !editor.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(editor)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(editor)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`editor.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(this) || !IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion                  || !IsInstanceValid(editor) || editor.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(this) || !IsInsideTree() || IsQueuedForDeletion()`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(tree, SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(tree, SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`_scroll.EnsureControlVisible(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.EnsureControlVisible(editor);`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content, editorName)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content, editorName) is not TextEdit editor`

**赋值（含属性/字段和局部值）：**

- `_scroll.ScrollVertical` = `int.MaxValue`

<a id="symbol-ae698159460a"></a>

## `NationalSpire.CommunityUpdateButton._Process(double) — public override void _Process(double delta)`

来源：源码第 432 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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
