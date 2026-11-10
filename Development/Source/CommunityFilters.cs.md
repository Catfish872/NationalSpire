# CommunityFilters.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`254A0010D1C72CE15DE0F4AEA8E608E1DC81CAE0536E5A79EDA5B39B028ED10E`。来源：[源码](../../CommunityFilters.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] PostCategories = ["比赛战报","国际赛事","俱乐部动态","人物日常","我的讨论","其他动态"];
private HashSet<string> _checkedCategories = [];
```

<a id="symbol-19e3d9d8326a"></a>

## `NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData) — private VBoxContainer BuildCommunityToolbar(CareerData data)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)

**调用：** [`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`](DashboardControls.cs.md#symbol-34af00babbac)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`](DashboardControls.cs.md#symbol-f6780ccb3f84)；[`NationalSpire.CareerScreen.EnsureChatPreferencesLoaded()`](ChatHistoryScreen.cs.md#symbol-36884b55f7cb)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.CareerScreen.WriteChatPreferences()`](ChatHistoryScreen.cs.md#symbol-15e26075b1d4)；[`NationalSpire.CommunityThreads.MarkAllRead(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-d7df547dd0ac)；[`NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-7398f6d1a869)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；[`ShowSelection()`](CommunityFilters.cs.md#symbol-1e51b01bad2f)；`Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MenuButton.GetPopup()`；`Godot.MenuButton.MenuButton()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PopupMenu.AddCheckItem(string, int, Godot.Key)`；`Godot.Variant.AsStringArray()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Intersect<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._checkedCategories`；`NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._postLimit`；`NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`；`NationalSpire.CareerScreen.ComposePostId`；`NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；`NationalSpire.CareerScreen.EnsureChatPreferencesLoaded()`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenLifePage(string)`；`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.PostCategories`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CareerScreen.WriteChatPreferences()`；`NationalSpire.CommunityThreads.MarkAllRead(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData)`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`ShowSelection()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.SetValue(ChatPreferenceKey,"post-categories",PostCategories.Where(_checkedCategories.Contains).ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.SetValue(ChatPreferenceKey,"post-categories",PostCategories.Where(_checkedCategories.Contains).ToArray());`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`feed.AddThemeConstantOverride("separation",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: feed.AddThemeConstantOverride("separation",18);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`filter.AddThemeFontSizeOverride("font_size",17)`；返回值紧邻使用处：`ExpressionStatementSyntax: filter.AddThemeFontSizeOverride("font_size",17);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "CommunityToolbar" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "CommunityToolbar" }`
- `Godot.MenuButton.GetPopup()`；输入表达式：`filter.GetPopup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = filter.GetPopup()`
- `Godot.MenuButton.MenuButton()`；输入表达式：`new MenuButton { Name = "CommunityCategories", CustomMinimumSize = new(164,42), Flat = false,             MouseDefaultCursorShape = CursorShape.PointingHand, TooltipText = "筛选社区内容分类" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MenuButton { Name = "CommunityCategories", CustomMinimumSize = new(164,42), Flat = false,             MouseDefaultCursorShape = CursorShape.PointingHand, TooltipText = "筛选社区内容分类" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(briefs)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(briefs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(filter)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(filter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(FramedAction("查看公告", () => OpenLifePage("公开消息"),"notice-board",width:128))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(FramedAction("查看公告", () => OpenLifePage("公开消息"),"notice-board",width:128));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(FramedAction("发表新帖", () => Visit(() => _postId = ComposePostId),"plus",width:128))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(FramedAction("发表新帖", () => Visit(() => _postId = ComposePostId),"plus",width:128));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(read)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(read);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(unread)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(unread);`
- `Godot.PopupMenu.AddCheckItem(string, int, Godot.Key)`；输入表达式：`menu.AddCheckItem("全部分类",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddCheckItem("全部分类",0);`
- `Godot.PopupMenu.AddCheckItem(string, int, Godot.Key)`；输入表达式：`menu.AddCheckItem(PostCategories[i],i+1)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddCheckItem(PostCategories[i],i+1);`
- `Godot.Variant.AsStringArray()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()             .Intersect`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "CommunityFeed" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "CommunityFeed" }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(164,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(164,42)`
- `NationalSpire.CareerScreen.ButtonIcon(Godot.Button, string, int, bool)`；输入表达式：`ButtonIcon(filter,"chevron-down",15,trailing:true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonIcon(filter,"chevron-down",15,trailing:true);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(filter,"15232f","354b58","28434c","658c91",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(filter,"15232f","354b58","28434c","658c91",6);`
- `NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；输入表达式：`DashboardSwitch("仅看未读", _communityFilter == "未读更新", on => {             _communityFilter = on ? "未读更新" : "全部"; _postLimit = 30; PopulateCommunityFeed(data,feed);         },126,42)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardSwitch("仅看未读", _communityFilter == "未读更新", on => {             _communityFilter = on ? "未读更新" : "全部"; _postLimit = 30; PopulateCommunityFeed(data,feed);         },126,42)`
- `NationalSpire.CareerScreen.EnsureChatPreferencesLoaded()`；输入表达式：`EnsureChatPreferencesLoaded()`；返回值紧邻使用处：`ExpressionStatementSyntax: EnsureChatPreferencesLoaded();`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("查看公告", () => OpenLifePage("公开消息"),"notice-board",width:128)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("查看公告", () => OpenLifePage("公开消息"),"notice-board",width:128)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("发表新帖", () => Visit(() => _postId = ComposePostId),"plus",width:128)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("发表新帖", () => Visit(() => _postId = ComposePostId),"plus",width:128)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("简讯已读", () => {             int count = CommunityThreads.MarkProgramRead(data); Render();             Notice($"已将 {count} 篇简讯标为已读。",false);         },"mail-check",width:128)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FramedAction("简讯已读", () => {             int count = CommunityThreads.MarkProgramRead(data); Render();             Notice($"已将 {count} 篇简讯标为已读。",false);         },"mail-check",width:128)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("全部已读", () => {             if (_multiplayer != null)             {                 _multiplayer.Send("read-all", accepted: () => { _multiplayer.Refresh(); _boundData = ViewData; Render(); });                 return;             }             CommunityThreads.MarkAllRead(data);             Render(); Notice("社区更新已全部标为已读。",false);         },"mail-check",width:128)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FramedAction("全部已读", () => {             if (_multiplayer != null)             {                 _multiplayer.Send("read-all", accepted: () => { _multiplayer.Refresh(); _boundData = ViewData; Render(); });                 return;             }             CommunityThreads.MarkAllRead(data);             Render(); Notice("社区更新已全部标为已读。",false);         },"mail-check",width:128)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("社区更新已全部标为已读。",false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("社区更新已全部标为已读。",false);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice($"已将 {count} 篇简讯标为已读。",false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice($"已将 {count} 篇简讯标为已读。",false);`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage("公开消息")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenLifePage("公开消息")`
- `NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`PopulateCommunityFeed(data,feed)`；返回值紧邻使用处：`ExpressionStatementSyntax: PopulateCommunityFeed(data,feed);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => _postId = ComposePostId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Visit(() => _postId = ComposePostId)`
- `NationalSpire.CareerScreen.WriteChatPreferences()`；输入表达式：`WriteChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: WriteChatPreferences();`
- `NationalSpire.CommunityThreads.MarkAllRead(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.MarkAllRead(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.MarkAllRead(data);`
- `NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.MarkProgramRead(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.MarkProgramRead(data)`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer.Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Refresh();`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("read-all", accepted: () => { _multiplayer.Refresh(); _boundData = ViewData; Render(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("read-all", accepted: () => { _multiplayer.Refresh(); _boundData = ViewData; Render(); });`
- `ShowSelection()`；输入表达式：`ShowSelection()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowSelection();`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_checkedCategories.Add(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: _checkedCategories.Add(name);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_checkedCategories.Remove(name)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_checkedCategories.Remove(name)`
- `System.Collections.Generic.IEnumerable<TSource>.Intersect<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()             .Intersect(PostCategories)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()             .Intersect(PostCategories).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PostCategories.Where(_checkedCategories.Contains).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: PostCategories.Where(_checkedCategories.Contains).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()             .Intersect(PostCategories).ToHashSet()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _checkedCategories = ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()             .Intersect(PostCategories).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`PostCategories.ToHashSet()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _checkedCategories.Count == PostCategories.Length ? [] : PostCategories.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PostCategories.Where(_checkedCategories.Contains)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PostCategories.Where(_checkedCategories.Contains).ToArray`

**赋值（含属性/字段和局部值）：**

- `_boundData` = `ViewData`
- `_checkedCategories` = `_checkedCategories.Count == PostCategories.Length ? [] : PostCategories.ToHashSet()`
- `_checkedCategories` = `ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()             .Intersect(PostCategories).ToHashSet()`
- `_communityFilter` = `on ? "未读更新" : "全部"`
- `_postId` = `ComposePostId`
- `_postLimit` = `30`
- `briefs.TooltipText` = `"将没有玩家发言或 AI 回复的程序简讯标为已读。"`
- `CustomMinimumSize` = `new(164,42)`
- `Flat` = `false`
- `menu.HideOnCheckableItemSelection` = `false`
- `menu.IdPressed` += `id => {             if (id == 0) _checkedCategories = _checkedCategories.Count == PostCategories.Length ? [] : PostCategories.ToHashSet();             else if (id > 0 && id <= PostCategories.Length)             {                 var name = PostCategories[(int)id-1];                 if (!_checkedCategories.Remove(name)) _checkedCategories.Add(name);             }             ChatPreferences.SetValue(ChatPreferenceKey,"post-categories",PostCategories.Where(_checkedCategories.Contains).ToArray());             WriteChatPreferences(); ShowSelection(); _postLimit = 30; PopulateCommunityFeed(data,feed);         }`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"CommunityCategories"`
- `Name` = `"CommunityFeed"`
- `Name` = `"CommunityToolbar"`
- `read.TooltipText` = `"将当前所有社区帖子和双周刊更新标为已读。"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `TooltipText` = `"筛选社区内容分类"`

<a id="symbol-1e51b01bad2f"></a>

## `ShowSelection() — void ShowSelection()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)

**调用：** `Godot.PopupMenu.SetItemChecked(int, bool)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._checkedCategories`；`NationalSpire.CareerScreen.PostCategories`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.PopupMenu.SetItemChecked(int, bool)`；输入表达式：`menu.SetItemChecked(0,all)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.SetItemChecked(0,all);`
- `Godot.PopupMenu.SetItemChecked(int, bool)`；输入表达式：`menu.SetItemChecked(i+1,_checkedCategories.Contains(PostCategories[i]))`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.SetItemChecked(i+1,_checkedCategories.Contains(PostCategories[i]));`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains(PostCategories[i])`；返回值紧邻使用处：`ArgumentSyntax: _checkedCategories.Contains(PostCategories[i])`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`_checkedCategories.First()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _checkedCategories.Count == 1 ? _checkedCategories.First() : $"分类 · {_checkedCategories.Count}"`

**赋值（含属性/字段和局部值）：**

- `filter.Text` = `all ? "全部分类" : _checkedCategories.Count == 1 ? _checkedCategories.First() : $"分类 · {_checkedCategories.Count}"`

<a id="symbol-09f2fb6e4563"></a>

## `NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer) — private void PopulateCommunityFeed(CareerData data,VBoxContainer feed)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildCommunityToolbar(NationalSpire.CareerData)`](CommunityFilters.cs.md#symbol-19e3d9d8326a)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)

**调用：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Matches(NationalSpire.CommunityPost)`；`Mine(NationalSpire.CommunityPost)`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerScreen._checkedCategories`；`NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._postLimit`；`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.PostCategories`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`feed.AddChild(Button("显示更早动态",() => { _postLimit += 30; PopulateCommunityFeed(data,feed); },190))`；返回值紧邻使用处：`ExpressionStatementSyntax: feed.AddChild(Button("显示更早动态",() => { _postLimit += 30; PopulateCommunityFeed(data,feed); },190));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`feed.AddChild(Text("所选分类暂无动态。",18,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: feed.AddChild(Text("所选分类暂无动态。",18,_muted));`
- `NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`；输入表达式：`AddPostCard(data,post,feed)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPostCard(data,post,feed);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("显示更早动态",() => { _postLimit += 30; PopulateCommunityFeed(data,feed); },190)`；返回值紧邻使用处：`ArgumentSyntax: Button("显示更早动态",() => { _postLimit += 30; PopulateCommunityFeed(data,feed); },190)`
- `NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`PopulateCommunityFeed(data,feed)`；返回值紧邻使用处：`ExpressionStatementSyntax: PopulateCommunityFeed(data,feed);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("所选分类暂无动态。",18,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("所选分类暂无动态。",18,_muted)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(feed)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(feed);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: unread ? CommunityThreads.All(data) :             _checkedCategories.Contains("我的讨论") ? data.Posts.Concat(data.SavedThreads.Where(Mine)).DistinctBy(p => p.Id) : data.Posts`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Human(data)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("我的讨论")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _checkedCategories.Contains("我的讨论") ? data.Posts.Concat(data.SavedThreads.Where(Mine)).DistinctBy(p => p.Id) : data.Posts`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Posts.Concat(data.SavedThreads.Where(Mine))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Posts.Concat(data.SavedThreads.Where(Mine)).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Posts.Concat(data.SavedThreads.Where(Mine)).DistinctBy(p => p.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _checkedCategories.Contains("我的讨论") ? data.Posts.Concat(data.SavedThreads.Where(Mine)).DistinctBy(p => p.Id) : data.Posts`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`page.Take(_postLimit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in page.Take(_postLimit)) AddPostCard(data,post,feed);`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`posts.Where(Matches).Take(_postLimit+1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(Matches).Take(_postLimit+1).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`posts.Where(Matches).Take(_postLimit+1).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.Where(Matches).Take(_postLimit+1).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.SavedThreads.Where(Mine)`；返回值紧邻使用处：`ArgumentSyntax: data.SavedThreads.Where(Mine)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.Where(Matches)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(Matches).Take`

**赋值（含属性/字段和局部值）：**

- `_postLimit` += `30`

<a id="symbol-1e323c41240e"></a>

## `IsMe(string) — bool IsMe(string id)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Mine(NationalSpire.CommunityPost)`](CommunityFilters.cs.md#symbol-32f6e17eed6a)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-32f6e17eed6a"></a>

## `Mine(NationalSpire.CommunityPost) — bool Mine(CommunityPost p)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Matches(NationalSpire.CommunityPost)`](CommunityFilters.cs.md#symbol-1824fe81fb2c)

**调用：** [`IsMe(string)`](CommunityFilters.cs.md#symbol-1e323c41240e)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `IsMe(string)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `IsMe(string)`；输入表达式：`IsMe(p.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsMe(p.AuthorId) || p.Replies.Any(r => IsMe(r.AuthorId))`
- `IsMe(string)`；输入表达式：`IsMe(r.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => IsMe(r.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Any(r => IsMe(r.AuthorId))`；返回值紧邻使用处：`BinaryExpressionSyntax: IsMe(p.AuthorId) || p.Replies.Any(r => IsMe(r.AuthorId))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1824fe81fb2c"></a>

## `Matches(NationalSpire.CommunityPost) — bool Matches(CommunityPost post)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Mine(NationalSpire.CommunityPost)`](CommunityFilters.cs.md#symbol-32f6e17eed6a)；`string.Contains(string)`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `Mine(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen._checkedCategories`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SeenRevision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Mine(NationalSpire.CommunityPost)`；输入表达式：`Mine(post)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mine(post)`
- `string.Contains(string)`；输入表达式：`post.Category.Contains("世界杯")`；返回值紧邻使用处：`BinaryExpressionSyntax: post.Category == "国际赛事" || post.Category.Contains("洲际") || post.Category.Contains("世界杯")`
- `string.Contains(string)`；输入表达式：`post.Category.Contains("洲际")`；返回值紧邻使用处：`BinaryExpressionSyntax: post.Category == "国际赛事" || post.Category.Contains("洲际")`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`post.EventKey.StartsWith("match",StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.EventKey.StartsWith("match",StringComparison.Ordinal)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("比赛战报")`；返回值紧邻使用处：`BinaryExpressionSyntax: match && _checkedCategories.Contains("比赛战报")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("国际赛事")`；返回值紧邻使用处：`BinaryExpressionSyntax: international && _checkedCategories.Contains("国际赛事")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("俱乐部动态")`；返回值紧邻使用处：`BinaryExpressionSyntax: club && _checkedCategories.Contains("俱乐部动态")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("其他动态")`；返回值紧邻使用处：`BinaryExpressionSyntax: !(match || international || club || person || mine) && _checkedCategories.Contains("其他动态")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("人物日常")`；返回值紧邻使用处：`BinaryExpressionSyntax: person && _checkedCategories.Contains("人物日常")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_checkedCategories.Contains("我的讨论")`；返回值紧邻使用处：`BinaryExpressionSyntax: mine && _checkedCategories.Contains("我的讨论")`

**赋值（含属性/字段和局部值）：**
