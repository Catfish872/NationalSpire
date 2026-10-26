# CareerNavigation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CB0124A88E6E6B7955939165675873FE27A48DC43C7E7FC046BAF6BF7356BEA6`。来源：[源码](../../CareerNavigation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.Location`、`NationalSpire.CareerScreen.TabVisit`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Stack<Location> _backHistory = new();
private readonly Dictionary<string, TabVisit> _tabVisits = new();
private readonly Dictionary<string, CommunityPost> _readPosts = new();
private Button _backButton = null!;
private Label _breadcrumb = null!;
```

<a id="symbol-67f7f7696f8a"></a>

## `NationalSpire.CareerScreen.CaptureLocation() — private Location CaptureLocation()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenGroupPerson(string)`](GroupChatScreen.cs.md#symbol-1eb7b9a65ede)；[`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-730bf8884640)；[`NationalSpire.CareerScreen.OpenPrivatePerson(string)`](PrivateMessageScreen.cs.md#symbol-bae5675b92b9)；[`NationalSpire.CareerScreen.RememberTab()`](CareerNavigation.cs.md#symbol-217738bbaf70)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**调用：** `NationalSpire.CareerScreen.Location.Location(string, string?, string?, string, string?, string, string, int, int, int, int, string, string, int, string, int, int, string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._eventId`；`NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._postLimit`；`NationalSpire.CareerScreen._profileFilter`；`NationalSpire.CareerScreen._profileLimit`；`NationalSpire.CareerScreen._profileQuery`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Location.Location(string, string?, string?, string, string?, string, string, int, int, int, int, string, string, int, string, int, int, string, string)`；输入表达式：`new(_tab, _personId, _postId, _worldSection, _competitionId,          _profileFilter, _communityFilter, _postLimit, _selectedDay, _scroll.ScrollVertical, _profileLimit, _profileQuery, _lifeSection, _lifeHistoryLimit,          Event: _eventView?.Visible == true ? _eventId : "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(_tab, _personId, _postId, _worldSection, _competitionId,          _profileFilter, _communityFilter, _postLimit, _selectedDay, _scroll.ScrollVertical, _profileLimit, _profileQuery, _lifeSection, _lifeHistoryLimit,          Event: _eventView?.Visible == true ? _eventId : "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-326019f9e7f5"></a>

## `NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location) — private void ApplyLocation(Location location)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.SwitchTab(string)`](CareerNavigation.cs.md#symbol-64b01d2d7cc1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._postLimit`；`NationalSpire.CareerScreen._profileFilter`；`NationalSpire.CareerScreen._profileLimit`；`NationalSpire.CareerScreen._profileQuery`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.Location.CommunityFilter`；`NationalSpire.CareerScreen.Location.Competition`；`NationalSpire.CareerScreen.Location.LifeLimit`；`NationalSpire.CareerScreen.Location.LifeSection`；`NationalSpire.CareerScreen.Location.Person`；`NationalSpire.CareerScreen.Location.Post`；`NationalSpire.CareerScreen.Location.PostLimit`；`NationalSpire.CareerScreen.Location.ProfileFilter`；`NationalSpire.CareerScreen.Location.ProfileLimit`；`NationalSpire.CareerScreen.Location.ProfileQuery`；`NationalSpire.CareerScreen.Location.SelectedDay`；`NationalSpire.CareerScreen.Location.Tab`；`NationalSpire.CareerScreen.Location.WorldSection`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_communityFilter` = `location.CommunityFilter`
- `_competitionId` = `location.Competition`
- `_lifeHistoryLimit` = `location.LifeLimit`
- `_lifeSection` = `location.LifeSection`
- `_personId` = `location.Person`
- `_postId` = `location.Post`
- `_postLimit` = `location.PostLimit`
- `_profileFilter` = `location.ProfileFilter`
- `_profileLimit` = `location.ProfileLimit`
- `_profileQuery` = `location.ProfileQuery`
- `_selectedDay` = `location.SelectedDay`
- `_tab` = `location.Tab`
- `_worldSection` = `location.WorldSection`

<a id="symbol-217738bbaf70"></a>

## `NationalSpire.CareerScreen.RememberTab() — private void RememberTab()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.SwitchTab(string)`](CareerNavigation.cs.md#symbol-64b01d2d7cc1)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**调用：** [`NationalSpire.CareerScreen.CaptureLocation()`](CareerNavigation.cs.md#symbol-67f7f7696f8a)；`NationalSpire.CareerScreen.TabVisit.TabVisit(NationalSpire.CareerScreen.Location, NationalSpire.CareerScreen.Location[])`；`System.Collections.Generic.Stack<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._tabVisits`；`NationalSpire.CareerScreen.CaptureLocation()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CaptureLocation()`；输入表达式：`CaptureLocation()`；返回值紧邻使用处：`ArgumentSyntax: CaptureLocation()`
- `NationalSpire.CareerScreen.TabVisit.TabVisit(NationalSpire.CareerScreen.Location, NationalSpire.CareerScreen.Location[])`；输入表达式：`new(CaptureLocation(), _backHistory.ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _tabVisits[_tab] = new(CaptureLocation(), _backHistory.ToArray())`
- `System.Collections.Generic.Stack<T>.ToArray()`；输入表达式：`_backHistory.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: _backHistory.ToArray()`

**赋值（含属性/字段和局部值）：**

- `_tabVisits[_tab]` = `new(CaptureLocation(), _backHistory.ToArray())`

<a id="symbol-d49752019228"></a>

## `NationalSpire.CareerScreen.Visit(System.Action) — private void Visit(Action destination)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.OpenCommunity()`](CareerNavigation.cs.md#symbol-9428027fc287)；[`NationalSpire.CareerScreen.OpenCompetition(string)`](CareerNavigation.cs.md#symbol-d88417a19f38)；[`NationalSpire.CareerScreen.OpenGroupPerson(string)`](GroupChatScreen.cs.md#symbol-1eb7b9a65ede)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-730bf8884640)；[`NationalSpire.CareerScreen.OpenPrivatePerson(string)`](PrivateMessageScreen.cs.md#symbol-bae5675b92b9)；[`NationalSpire.CareerScreen.OpenProfileList(string?)`](CareerNavigation.cs.md#symbol-fa604705ef07)；[`NationalSpire.CareerScreen.OpenUpdates()`](CommunityScreen.cs.md#symbol-8c3d08bdf705)；[`NationalSpire.CareerScreen.OpenWeekly(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](WeeklyScreen.cs.md#symbol-d2f4067bf23e)；[`NationalSpire.CareerScreen.OpenWorldSection(string)`](CareerNavigation.cs.md#symbol-e41ea7b0d93d)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)

**调用：** [`NationalSpire.CareerScreen.CaptureLocation()`](CareerNavigation.cs.md#symbol-67f7f7696f8a)；[`NationalSpire.CareerScreen.RememberTab()`](CareerNavigation.cs.md#symbol-217738bbaf70)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.Stack<T>.Clear()`；`System.Collections.Generic.Stack<T>.Push(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._confirmReset`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.CaptureLocation()`；`NationalSpire.CareerScreen.RememberTab()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ViewData`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CaptureLocation()`；输入表达式：`CaptureLocation()`；返回值紧邻使用处：`ArgumentSyntax: CaptureLocation()`
- `NationalSpire.CareerScreen.RememberTab()`；输入表达式：`RememberTab()`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberTab();`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `System.Action.Invoke()`；输入表达式：`destination()`；返回值紧邻使用处：`ExpressionStatementSyntax: destination();`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`_backHistory.Take(64).Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _backHistory.Take(64).Reverse().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`_backHistory.Take(64)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _backHistory.Take(64).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_backHistory.Take(64).Reverse().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _backHistory.Take(64).Reverse().ToArray()`
- `System.Collections.Generic.Stack<T>.Clear()`；输入表达式：`_backHistory.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Clear();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_backHistory.Push(CaptureLocation())`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Push(CaptureLocation());`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_backHistory.Push(location)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Push(location);`

**赋值（含属性/字段和局部值）：**

- `_confirmReset` = `false`
- `_scroll.ScrollVertical` = `0`

<a id="symbol-64b01d2d7cc1"></a>

## `NationalSpire.CareerScreen.SwitchTab(string) — private void SwitchTab(string tab)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location)`](CareerNavigation.cs.md#symbol-326019f9e7f5)；[`NationalSpire.CareerScreen.RememberTab()`](CareerNavigation.cs.md#symbol-217738bbaf70)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.Stack<T>.Clear()`；`System.Collections.Generic.Stack<T>.Push(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._confirmReset`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._tabVisits`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location)`；`NationalSpire.CareerScreen.Location.Scroll`；`NationalSpire.CareerScreen.RememberTab()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.TabVisit.History`；`NationalSpire.CareerScreen.TabVisit.Location`；`NationalSpire.CareerScreen.ViewData`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location)`；输入表达式：`ApplyLocation(visit.Location)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyLocation(visit.Location);`
- `NationalSpire.CareerScreen.RememberTab()`；输入表达式：`RememberTab()`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberTab();`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(position, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(position, _renderVersion)`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(scroll, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(scroll, _renderVersion)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_tabVisits.TryGetValue(tab, out var visit)`；返回值紧邻使用处：`IfStatementSyntax: if (_tabVisits.TryGetValue(tab, out var visit))          {              ApplyLocation(visit.Location); scroll = visit.Location.Scroll;              foreach (var previous in visit.History.Reverse()) _backHistory.Push(previous);          }          else { _tab = tab; _personId = null; _postId = null; _competitionId = null; _worldSection = "国运榜"; }`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`visit.History.Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var previous in visit.History.Reverse()) _backHistory.Push(previous);`
- `System.Collections.Generic.Stack<T>.Clear()`；输入表达式：`_backHistory.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Clear();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_backHistory.Push(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Push(previous);`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(position, _renderVersion)`
- `_` = `RestoreScrollAsync(scroll, _renderVersion)`
- `_competitionId` = `null`
- `_confirmReset` = `false`
- `_personId` = `null`
- `_postId` = `null`
- `_scroll.ScrollVertical` = `0`
- `_tab` = `"结算"`
- `_tab` = `tab`
- `_worldSection` = `"国运榜"`
- `scroll` = `visit.Location.Scroll`

<a id="symbol-4430ec2bce8b"></a>

## `NationalSpire.CareerScreen.OpenPerson(string) — private void OpenPerson(string id)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.OpenMention(Godot.Variant)`](MentionScreen.cs.md#symbol-1c66c471dc01)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`ShowSavedCard()`](CharacterCardScreen.cs.md#symbol-f40deb845b48)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；`Godot.CanvasItem.Hide()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _eventView?.Hide()`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _eventView?.Hide(); _personId = id; _tab = "选手档案"; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _eventView?.Hide(); _personId = id; _tab = "选手档案"; });`

**赋值（含属性/字段和局部值）：**

- `_personId` = `id`
- `_tab` = `"选手档案"`

<a id="symbol-3888620952df"></a>

## `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost) — private void OpenPost(CommunityPost post)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._readPosts`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "社区"; _postId = post.Id; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "社区"; _postId = post.Id; });`

**赋值（含属性/字段和局部值）：**

- `_postId` = `post.Id`
- `_readPosts[post.Id]` = `post`
- `_tab` = `"社区"`

<a id="symbol-9428027fc287"></a>

## `NationalSpire.CareerScreen.OpenCommunity() — private void OpenCommunity()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "社区"; _postId = null; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Visit(() => { _tab = "社区"; _postId = null; })`

**赋值（含属性/字段和局部值）：**

- `_postId` = `null`
- `_tab` = `"社区"`

<a id="symbol-fa604705ef07"></a>

## `NationalSpire.CareerScreen.OpenProfileList(string?) — private void OpenProfileList(string? filter = null)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`SelectFilter()`](CareerNavigation.cs.md#symbol-9fe1509623f4)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.Visit(System.Action)`；`SelectFilter()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "选手档案"; _personId = null; SelectFilter(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "选手档案"; _personId = null; SelectFilter(); });`
- `SelectFilter()`；输入表达式：`SelectFilter()`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectFilter();`

**赋值（含属性/字段和局部值）：**

- `_personId` = `null`
- `_scroll.ScrollVertical` = `0`
- `_tab` = `"选手档案"`

<a id="symbol-9fe1509623f4"></a>

## `SelectFilter() — void SelectFilter()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenProfileList(string?)`](CareerNavigation.cs.md#symbol-fa604705ef07)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._profileFilter`；`NationalSpire.CareerScreen._profileLimit`；`NationalSpire.CareerScreen._profileQuery`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_profileFilter` = `filter`
- `_profileLimit` = `36`
- `_profileQuery` = `""`

<a id="symbol-e41ea7b0d93d"></a>

## `NationalSpire.CareerScreen.OpenWorldSection(string) — private void OpenWorldSection(string section)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginClubDraft()`](OwnedClubScreen.cs.md#symbol-09bdfebb252f)；[`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenCeremony()`](CeremonyScreen.cs.md#symbol-f5db35fa605b)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "赛事与俱乐部"; _worldSection = section; _competitionId = null; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "赛事与俱乐部"; _worldSection = section; _competitionId = null; });`

**赋值（含属性/字段和局部值）：**

- `_competitionId` = `null`
- `_tab` = `"赛事与俱乐部"`
- `_worldSection` = `section`

<a id="symbol-d88417a19f38"></a>

## `NationalSpire.CareerScreen.OpenCompetition(string) — private void OpenCompetition(string id)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)

**调用：** [`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "赛事与俱乐部"; _worldSection = "赛事总览"; _competitionId = id; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Visit(() => { _tab = "赛事与俱乐部"; _worldSection = "赛事总览"; _competitionId = id; })`

**赋值（含属性/字段和局部值）：**

- `_competitionId` = `id`
- `_tab` = `"赛事与俱乐部"`
- `_worldSection` = `"赛事总览"`

<a id="symbol-5e641d6b16d9"></a>

## `NationalSpire.CareerScreen.CanGoBack — private bool CanGoBack`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-08af62207fef"></a>

## `NationalSpire.CareerScreen.Back() — private void Back()`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)

**调用：** [`NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location)`](CareerNavigation.cs.md#symbol-326019f9e7f5)；[`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)；[`NationalSpire.CareerScreen.RememberTab()`](CareerNavigation.cs.md#symbol-217738bbaf70)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreGroupScroll(string, int)`](GroupChatScreen.cs.md#symbol-b8810762e549)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerScreen.ScrollChatTo(int)`](ChatHistoryScreen.cs.md#symbol-b728511cec65)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；`System.Collections.Generic.Stack<T>.TryPop(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._confirmReset`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location)`；`NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.Location.ChatPage`；`NationalSpire.CareerScreen.Location.ChatScroll`；`NationalSpire.CareerScreen.Location.Event`；`NationalSpire.CareerScreen.Location.Group`；`NationalSpire.CareerScreen.Location.PrivatePerson`；`NationalSpire.CareerScreen.Location.Scroll`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.OpenRandomEvent(string)`；`NationalSpire.CareerScreen.RememberTab()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreGroupScroll(string, int)`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.ScrollChatTo(int)`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.ViewData`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ApplyLocation(NationalSpire.CareerScreen.Location)`；输入表达式：`ApplyLocation(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyLocation(previous);`
- `NationalSpire.CareerScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(previous.PrivatePerson, page: previous.ChatPage)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(previous.PrivatePerson, page: previous.ChatPage);`
- `NationalSpire.CareerScreen.OpenRandomEvent(string)`；输入表达式：`OpenRandomEvent(previous.Event)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenRandomEvent(previous.Event);`
- `NationalSpire.CareerScreen.RememberTab()`；输入表达式：`RememberTab()`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberTab();`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreGroupScroll(string, int)`；输入表达式：`RestoreGroupScroll(previous.Group, previous.ChatScroll)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreGroupScroll(previous.Group, previous.ChatScroll)`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(previous.Scroll, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(previous.Scroll, _renderVersion)`
- `NationalSpire.CareerScreen.ScrollChatTo(int)`；输入表达式：`ScrollChatTo(previous.ChatScroll)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ScrollChatTo(previous.ChatScroll)`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(previous.Group, previous.ChatPage)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(previous.Group, previous.ChatPage);`
- `System.Collections.Generic.Stack<T>.TryPop(out T)`；输入表达式：`_backHistory.TryPop(out var previous)`；返回值紧邻使用处：`IfStatementSyntax: if (_backHistory.TryPop(out var previous))          {              ApplyLocation(previous); Render(); _ = RestoreScrollAsync(previous.Scroll, _renderVersion);              if (previous.Group.Length > 0) { SelectGroup(previous.Group, previous.ChatPage); _ = RestoreGroupScroll(previous.Group, previous.ChatScroll); }              else if (previous.PrivatePerson.Length > 0) { OpenPrivateMessages(previous.PrivatePerson, page: previous.ChatPage); _ = ScrollChatTo(previous.ChatScroll); }              else if (previous.Event.Length > 0) OpenRandomEvent(previous.Event);          }          else if (_tab == "社区" && _postId != null) { _postId = null; _scroll.ScrollVertical = 0; Render(); }          else if (_tab == "选手档案" && _personId != null) { _personId = null; _scroll.ScrollVertical = 0; Render(); }          else if (_tab == "赛事与俱乐部" && _competitionId != null) { _competitionId = null; _scroll.ScrollVertical = 0; Render(); }          else if (_tab == "赛事与俱乐部" && _worldSection == "颁奖盛典") { _worldSection = "荣誉室"; _scroll.ScrollVertical = 0; Render(); }          else Close();`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreGroupScroll(previous.Group, previous.ChatScroll)`
- `_` = `RestoreScrollAsync(previous.Scroll, _renderVersion)`
- `_` = `ScrollChatTo(previous.ChatScroll)`
- `_competitionId` = `null`
- `_confirmReset` = `false`
- `_personId` = `null`
- `_postId` = `null`
- `_scroll.ScrollVertical` = `0`
- `_worldSection` = `"荣誉室"`

<a id="symbol-a6094a69b6d7"></a>

## `NationalSpire.CareerScreen.UpdateNavigation() — private void UpdateNavigation()`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenGroupPerson(string)`](GroupChatScreen.cs.md#symbol-1eb7b9a65ede)；[`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-730bf8884640)；[`NationalSpire.CareerScreen.OpenPrivatePerson(string)`](PrivateMessageScreen.cs.md#symbol-bae5675b92b9)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.Stack<T>.TryPeek(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._backButton`；`NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._breadcrumb`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._readPosts`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._worldSection`；`NationalSpire.CareerScreen.CanGoBack`；`NationalSpire.CareerScreen.ComposePostId`；`NationalSpire.CareerScreen.Location.Competition`；`NationalSpire.CareerScreen.Location.Event`；`NationalSpire.CareerScreen.Location.Group`；`NationalSpire.CareerScreen.Location.Person`；`NationalSpire.CareerScreen.Location.Post`；`NationalSpire.CareerScreen.Location.PrivatePerson`；`NationalSpire.CareerScreen.Location.Tab`；`NationalSpire.CareerScreen.Location.WorldSection`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, _personId)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "选手档案" when _personId != null => CareerEngine.DisplayName(ViewData, _personId)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(ViewData).FirstOrDefault`
- `string.StartsWith(string)`；输入表达式：`.StartsWith("weekly:")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _postId?.StartsWith("weekly:")`
- `string.StartsWith(string)`；输入表达式：`.StartsWith("weekly:")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: previous.Post?.StartsWith("weekly:")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == _postId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == _postId)?.Title`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.Esports.Competitions.FirstOrDefault(c => c.Id == _competitionId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ViewData.Esports.Competitions.FirstOrDefault(c => c.Id == _competitionId)?.Name`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_readPosts.GetValueOrDefault(_postId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _readPosts.GetValueOrDefault(_postId)?.Title`
- `System.Collections.Generic.Stack<T>.TryPeek(out T)`；输入表达式：`_backHistory.TryPeek(out var chat)`；返回值紧邻使用处：`BinaryExpressionSyntax: _backHistory.TryPeek(out var chat) && chat.Group.Length > 0`
- `System.Collections.Generic.Stack<T>.TryPeek(out T)`；输入表达式：`_backHistory.TryPeek(out var previous)`；返回值紧邻使用处：`IfStatementSyntax: if (_backHistory.TryPeek(out var previous)) destination = previous.Tab switch          {              "社区" => previous.Post?.StartsWith("weekly:") == true ? "周刊" : previous.Post != null ? "帖子" : "社区",              "选手档案" => previous.Person != null ? "人物档案" : "选手名录",              "赛事与俱乐部" => previous.Competition != null ? "赛事详情" : previous.WorldSection,              _ => previous.Tab          };          else if (_tab == "社区" && _postId != null) destination = "社区";          else if (_tab == "选手档案" && _personId != null) destination = "选手名录";          else if (_tab == "赛事与俱乐部" && _competitionId != null) destination = "赛事总览";          else if (_tab == "赛事与俱乐部" && _worldSection == "颁奖盛典") destination = "荣誉室";`

**赋值（含属性/字段和局部值）：**

- `_backButton.Disabled` = `!CanGoBack`
- `_backButton.Text` = `"← 返回" + destination`
- `_backButton.TooltipText` = `CanGoBack ? "返回上一处内容，恢复筛选和阅读位置。快捷键：Esc" : "当前已是栏目入口。"`
- `_breadcrumb.Text` = `_tab + (detail.Length > 0 ? "  /  " + detail : "")`
- `_breadcrumb.TooltipText` = `_breadcrumb.Text`
- `destination` = `"群聊"`
- `destination` = `"荣誉室"`
- `destination` = `"赛事总览"`
- `destination` = `"社区"`
- `destination` = `"私聊"`
- `destination` = `"随机事件"`
- `destination` = `"选手名录"`
- `destination` = `previous.Tab switch          {              "社区" => previous.Post?.StartsWith("weekly:") == true ? "周刊" : previous.Post != null ? "帖子" : "社区",              "选手档案" => previous.Person != null ? "人物档案" : "选手名录",              "赛事与俱乐部" => previous.Competition != null ? "赛事详情" : previous.WorldSection,              _ => previous.Tab          }`

<a id="symbol-870e8f5590bb"></a>

## `NationalSpire.CareerScreen.ResetNavigation() — private void ResetNavigation()`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Stack<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._ceremonyRules`；`NationalSpire.CareerScreen._ceremonySeason`；`NationalSpire.CareerScreen._ceremonySection`；`NationalSpire.CareerScreen._collapsedDiscussions`；`NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._newPostBody`；`NationalSpire.CareerScreen._newPostTitle`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._postLimit`；`NationalSpire.CareerScreen._profileFilter`；`NationalSpire.CareerScreen._profileLimit`；`NationalSpire.CareerScreen._profileQuery`；`NationalSpire.CareerScreen._readPosts`；`NationalSpire.CareerScreen._replyDrafts`；`NationalSpire.CareerScreen._replyTargets`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._tabVisits`；`NationalSpire.CareerScreen._worldSection`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_collapsedDiscussions.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _collapsedDiscussions.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_readPosts.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _readPosts.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_replyDrafts.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyDrafts.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_replyTargets.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _replyTargets.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_tabVisits.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _tabVisits.Clear();`
- `System.Collections.Generic.Stack<T>.Clear()`；输入表达式：`_backHistory.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Clear();`

**赋值（含属性/字段和局部值）：**

- `_ceremonyRules` = `false`
- `_ceremonySeason` = `0`
- `_ceremonySection` = `"获奖名单"`
- `_communityFilter` = `"全部"`
- `_competitionId` = `null`
- `_lifeHistoryLimit` = `8`
- `_lifeSection` = `"活动与计划"`
- `_newPostBody` = `""`
- `_newPostTitle` = `""`
- `_personId` = `null`
- `_postId` = `null`
- `_postLimit` = `30`
- `_profileFilter` = `"国内职业"`
- `_profileLimit` = `36`
- `_profileQuery` = `""`
- `_selectedDay` = `0`
- `_tab` = `"首页"`
- `_worldSection` = `"国运榜"`
