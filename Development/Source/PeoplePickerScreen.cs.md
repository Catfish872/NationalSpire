# PeoplePickerScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`64136DD01B8891D1F23859841A183C2446EB078F8CB0307299A05BA812F70BF0`。来源：[源码](../../PeoplePickerScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-80a307ead785"></a>

## `NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int) — private void PeoplePicker(VBoxContainer box, IReadOnlyList<CareerPerson> candidates, HashSet<string> selected, bool single, Action changed, int height = 220)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Members()`](ConsumerPickerScreen.cs.md#symbol-b19728da69ca)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`Show(bool)`](ConsumerPickerScreen.cs.md#symbol-8f92d347159a)

**调用：** [`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`Refresh()`](PeoplePickerScreen.cs.md#symbol-dd4db64669ab)；[`ShowRows()`](PeoplePickerScreen.cs.md#symbol-0dac44c0ee6b)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Vector2.Vector2(float, float)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `(string id, int i).i`；`(string id, int i).id`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CareerResult.OpponentParticipants`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateTurn.Status`；`Refresh()`；`ShowRows()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`b.SetPressedNoSignal(b.Text == f)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.SetPressedNoSignal(b.Text == f);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(f == filter)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(f == filter);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`filters.AddThemeConstantOverride("h_separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddThemeConstantOverride("h_separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`filters.AddThemeConstantOverride("v_separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddThemeConstantOverride("v_separation", 6);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "RecipientSearch", PlaceholderText = "搜索人物名称", CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "RecipientSearch", PlaceholderText = "搜索人物名称", CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(count)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(count);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(filters)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(filters);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(searchBox)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(searchBox);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`filters.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: filters.GetChildren().OfType<Button>`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`scroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scroll.GetVScrollBar().ValueChanged`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "RecipientScroll", CustomMinimumSize = new(0, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { Name = "RecipientScroll", CustomMinimumSize = new(0, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 34)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(0, 34)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, height)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(f, f == filter, () => { filter = f; foreach (var b in filters.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == f); Refresh(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(f, f == filter, () => { filter = f; foreach (var b in filters.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == f); Refresh(); }, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 14, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 14, CareerVisuals.Teal)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).OrderByDescending`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).SelectMany`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `ShowRows()`；输入表达式：`ShowRows()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => ShowRows()`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: search = value.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Value.Turns.Any(t => t.Status == "complete")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Value.Turns.Any(t => t.Status == "complete")`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`r.OpponentParticipants.Append(r.OpponentId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.OpponentParticipants.Append(r.OpponentId)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`d.Results.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`p.Replies.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat(d.Life.Mailbox.Relations.Keys).Concat(GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat(d.Life.Mailbox.Relations.Keys).Concat(GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat(d.Life.Mailbox.Relations.Keys)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat(d.Life.Mailbox.Relations.Keys).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(d).OrderByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`d.Results.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.AsEnumerable().Reverse().SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`p.Replies.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.AsEnumerable().Reverse().Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select((id, i) => (id, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select((id, i) => (id, i)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select((id, i) => (id, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select((id, i) => (id, i)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`GroupChats.Visible(d).SelectMany(g => g.Turns)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat(d.Life.Mailbox.Relations.Keys).Concat(GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)              .Concat(d.Life.Mailbox.Relations.Keys).Concat(GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(HBoxContainer Row, CheckBox Check)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(HBoxContainer Row, CheckBox Check)>()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`filters.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var b in filters.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == f);`

**赋值（含属性/字段和局部值）：**

- `button.CustomMinimumSize` = `new(0, 34)`
- `button.ToggleMode` = `true`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(0, height)`
- `filter` = `f`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `list.Resized` += `ShowRows`
- `Name` = `"RecipientScroll"`
- `Name` = `"RecipientSearch"`
- `PlaceholderText` = `"搜索人物名称"`
- `scroll.GetVScrollBar().ValueChanged` += `_ => ShowRows()`
- `scroll.Resized` += `ShowRows`
- `search` = `value.Trim()`
- `searchBox.TextChanged` += `value => { search = value.Trim(); Refresh(); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-0dac44c0ee6b"></a>

## `ShowRows() — void ShowRows()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)；[`Refresh()`](PeoplePickerScreen.cs.md#symbol-dd4db64669ab)

**调用：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`](ConsumerGiftControls.cs.md#symbol-e35b8d3e088f)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Variant.AsString()`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Ceiling(double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(Godot.HBoxContainer Row, Godot.CheckBox Check).Check`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.MemberRows`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`check.SetPressedNoSignal(selected.Contains(person.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: check.SetPressedNoSignal(selected.Contains(person.Id));`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`other.Check.SetPressedNoSignal(selected.Contains(other.Check.GetMeta("person", "").AsString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: other.Check.SetPressedNoSignal(selected.Contains(other.Check.GetMeta("person", "").AsString()));`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { SizeFlagsHorizontal = SizeFlags.ExpandFill, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { SizeFlagsHorizontal = SizeFlags.ExpandFill, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`check.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: check.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`check.AddThemeStyleboxOverride("normal", CareerVisuals.Box("172c3b", "324e60", 6, 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: check.AddThemeStyleboxOverride("normal", CareerVisuals.Box("172c3b", "324e60", 6, 8));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`check.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("2a4854", "70d4bc", 6, 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: check.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("2a4854", "70d4bc", 6, 8));`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`check.GetMeta("person", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: check.GetMeta("person", "").AsString`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`check.GetMeta("person")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: check.GetMeta("person").AsString`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`other.Check.GetMeta("person", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: other.Check.GetMeta("person", "").AsString`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`check.SetMeta("person", person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: check.SetMeta("person", person.Id);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(check)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(check);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`row.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<Control>`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`row.MoveChild(avatar, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.MoveChild(avatar, 0);`
- `Godot.Node.QueueFree()`；输入表达式：`old.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: old.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`row.RemoveChild(old)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.RemoveChild(old);`
- `Godot.Variant.AsString()`；输入表达式：`check.GetMeta("person", "").AsString()`；返回值紧邻使用处：`BinaryExpressionSyntax: check.GetMeta("person", "").AsString() != person.Id`
- `Godot.Variant.AsString()`；输入表达式：`check.GetMeta("person").AsString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = check.GetMeta("person").AsString()`
- `Godot.Variant.AsString()`；输入表达式：`other.Check.GetMeta("person", "").AsString()`；返回值紧邻使用处：`ArgumentSyntax: other.Check.GetMeta("person", "").AsString()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, (first + i) * rowHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Position = new(0, (first + i) * rowHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(list.Size.X, rowHeight - 8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Size = new(list.Size.X, rowHeight - 8)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(d, person.Id, 38, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Avatar(d, person.Id, 38, false)`
- `NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`；输入表达式：`PickerRing(row, d, person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PickerRing(row, d, person.Id);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172c3b", "324e60", 6, 8)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172c3b", "324e60", 6, 8)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("2a4854", "70d4bc", 6, 8)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("2a4854", "70d4bc", 6, 8)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(d, person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: person.PublicName + " · " + person.Role + " · 好感 " + PrivateMessages.Favour(d, person.Id)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.MemberRows)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.MemberRows)`
- `System.Action.Invoke()`；输入表达式：`changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: changed();`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`selected.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Add(id);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`selected.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Clear();`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`selected.Contains(other.Check.GetMeta("person", "").AsString())`；返回值紧邻使用处：`ArgumentSyntax: selected.Contains(other.Check.GetMeta("person", "").AsString())`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`selected.Contains(person.Id)`；返回值紧邻使用处：`ArgumentSyntax: selected.Contains(person.Id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`selected.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Remove(id);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`row.GetChildren().OfType<Control>().Where(c => c != check).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in row.GetChildren().OfType<Control>().Where(c => c != check).ToArray()) { row.RemoveChild(old); old.QueueFree(); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`row.GetChildren().OfType<Control>().Where(c => c != check)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<Control>().Where(c => c != check).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`rows.Add((row, check))`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.Add((row, check));`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`row.GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<Control>().Where`
- `System.Math.Ceiling(double)`；输入表达式：`Math.Ceiling(Math.Max(height, scroll.Size.Y) / rowHeight)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Ceiling(Math.Max(height, scroll.Size.Y) / rowHeight)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(height, scroll.Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(height, scroll.Size.Y) / rowHeight`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, people.Length - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, people.Length - 1)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(height, scroll.Size.Y) / rowHeight) + 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(height, scroll.Size.Y) / rowHeight) + 1)`

**赋值（含属性/字段和局部值）：**

- `check.Name` = `"Recipient_" + person.Id`
- `check.Text` = `person.PublicName + " · " + person.Role`
- `check.Toggled` += `value =>                  {                      string id = check.GetMeta("person").AsString();                      if (value) { if (single) selected.Clear(); selected.Add(id); } else selected.Remove(id);                      foreach (var other in rows) other.Check.SetPressedNoSignal(selected.Contains(other.Check.GetMeta("person", "").AsString()));                      count.Text = "已选择 " + selected.Count + " 人"; changed();                  }`
- `check.TooltipText` = `person.PublicName + " · " + person.Role + " · 好感 " + PrivateMessages.Favour(d, person.Id)`
- `count.Text` = `"已选择 " + selected.Count + " 人"`
- `row.Position` = `new(0, (first + i) * rowHeight)`
- `row.Size` = `new(list.Size.X, rowHeight - 8)`
- `row.Visible` = `i < visible`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `var (row, check)` = `rows[i]`

<a id="symbol-dd4db64669ab"></a>

## `Refresh() — void Refresh()`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)

**调用：** [`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`ShowRows()`](PeoplePickerScreen.cs.md#symbol-0dac44c0ee6b)；`Godot.Vector2.Vector2(float, float)`；`string.Contains(string, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.MemberFilter`；`ShowRows()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, people.Length * rowHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: list.CustomMinimumSize = new(0, people.Length * rowHeight)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(d, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -PrivateMessages.Favour(d, p.Id)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.MemberFilter)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.MemberFilter)`
- `ShowRows()`；输入表达式：`ShowRows()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowRows();`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`authors.ContainsKey(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "近期发帖回帖者" => authors.ContainsKey(p.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`opponents.ContainsKey(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "近期对手" => opponents.ContainsKey(p.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`familiar.Contains(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "熟悉的人" => familiar.Contains(p.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`selected.Contains(p.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: selected.Contains(p.Id) ? -1 : 0`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })                  .OrderBy(p => filter == "熟悉的人" ? -PrivateMessages.Favour(d, p.Id) : filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })                  .OrderBy(p => filter == "熟悉的人" ? -PrivateMessages.Favour(d, p.Id) : filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })                  .OrderBy(p => filter == "熟悉的人" ? -PrivateMessages.Favour(d, p.Id) : filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: people = candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })                  .OrderBy(p => filter == "熟悉的人" ? -PrivateMessages.Favour(d, p.Id) : filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })                  .OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where`

**赋值（含属性/字段和局部值）：**

- `count.Text` = `people.Length == 0 ? "暂无匹配人物，请调整搜索或分类。" : "已选择 " + selected.Count + " 人 · 共 " + people.Length + " 人"`
- `list.CustomMinimumSize` = `new(0, people.Length * rowHeight)`
- `people` = `candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))                  .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })                  .OrderBy(p => filter == "熟悉的人" ? -PrivateMessages.Favour(d, p.Id) : filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0).ToArray()`
- `scroll.ScrollVertical` = `0`
