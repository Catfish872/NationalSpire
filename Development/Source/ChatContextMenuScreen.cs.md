# ChatContextMenuScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9AFFBD6B985E38C36A0C4BAABAE78D5AEFC2FCB38A7997A18E22698B0F23BF59`。来源：[源码](../../ChatContextMenuScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Control? _chatContextMenu;
private Dictionary<string, int> _chatPinRanks = new(StringComparer.Ordinal);
```

<a id="symbol-7291798431e8"></a>

## `NationalSpire.CareerScreen.ChatPinned(string) — private bool ChatPinned(string key)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`Removed()`](ChatManagementScreen.cs.md#symbol-0702711e2eee)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatPinRanks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_chatPinRanks.ContainsKey(key)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _chatPinRanks.ContainsKey(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-925212811342"></a>

## `NationalSpire.CareerScreen.LoadChatPins() — private void LoadChatPins()`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LoadChatPreferences()`](ChatHistoryScreen.cs.md#symbol-d1d5bc5023c7)；[`NationalSpire.CareerScreen.SetChatPinned(string, bool)`](ChatContextMenuScreen.cs.md#symbol-8689933c2c76)

**调用：** `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.Variant.AsStringArray()`；`System.Array.Empty<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `(string key, int rank).key`；`(string key, int rank).rank`；`NationalSpire.CareerScreen._chatPinRanks`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray`
- `Godot.Variant.AsStringArray()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<string>()`；返回值紧邻使用处：`ArgumentSyntax: Array.Empty<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal).Select((key, rank) => (key, rank))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal).Select((key, rank) => (key, rank)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal).Select((key, rank) => (key, rank)).ToDictionary(x => x.key, x => x.rank, StringComparer.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatPinRanks = ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal).Select((key, rank) => (key, rank)).ToDictionary(x => x.key, x => x.rank, StringComparer.Ordinal)`

**赋值（含属性/字段和局部值）：**

- `_chatPinRanks` = `ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()             .Distinct(StringComparer.Ordinal).Select((key, rank) => (key, rank)).ToDictionary(x => x.key, x => x.rank, StringComparer.Ordinal)`

<a id="symbol-8689933c2c76"></a>

## `NationalSpire.CareerScreen.SetChatPinned(string, bool) — private void SetChatPinned(string key, bool pinned)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`Removed()`](ChatManagementScreen.cs.md#symbol-0702711e2eee)

**调用：** [`NationalSpire.CareerScreen.LoadChatPins()`](ChatContextMenuScreen.cs.md#symbol-925212811342)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.WriteChatPreferences()`](ChatHistoryScreen.cs.md#symbol-15e26075b1d4)；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Insert(int, T)`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatPinRanks`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`；`NationalSpire.CareerScreen.LoadChatPins()`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen.WriteChatPreferences()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.SetValue(ChatPreferenceKey, "pins", pins.ToArray())`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.SetValue(ChatPreferenceKey, "pins", pins.ToArray());`
- `NationalSpire.CareerScreen.LoadChatPins()`；输入表达式：`LoadChatPins()`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadChatPins();`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.CareerScreen.WriteChatPreferences()`；输入表达式：`WriteChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: WriteChatPreferences();`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _chatPinRanks.OrderBy(p => p.Value).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).Where(p => p != key).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).Where(p => p != key).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).Where(p => p != key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).Where(p => p != key).ToList`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`pins.Insert(0, key)`；返回值紧邻使用处：`ExpressionStatementSyntax: pins.Insert(0, key);`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`pins.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: pins.ToArray()`

**赋值（含属性/字段和局部值）：**

- `_privateListSignature` = `""`

<a id="symbol-02269de4e133"></a>

## `NationalSpire.CareerScreen.CloseChatContextMenu() — private void CloseChatContextMenu()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)；[`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.ShowChatContextMenu(string, bool, Godot.Vector2)`](ChatContextMenuScreen.cs.md#symbol-0f3f090eb3e9)；[`Open(System.Action)`](ChatManagementScreen.cs.md#symbol-f889b0a7e3d1)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatContextMenu`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_chatContextMenu.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatContextMenu.Hide();`
- `Godot.Node.QueueFree()`；输入表达式：`_chatContextMenu.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatContextMenu.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_chatContextMenu` = `null`

<a id="symbol-0f3f090eb3e9"></a>

## `NationalSpire.CareerScreen.ShowChatContextMenu(string, bool, Godot.Vector2) — private void ShowChatContextMenu(string id, bool group, Vector2 position)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)

**调用：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.CloseChatContextMenu()`](ChatContextMenuScreen.cs.md#symbol-02269de4e133)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`Godot.Control.AcceptEvent()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.ResetSize()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `(string Title, System.Action Run).Run`；`(string Title, System.Action Run).Title`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerScreen._chatContextMenu`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`；`NationalSpire.CareerScreen.CloseChatContextMenu()`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AcceptEvent()`；输入表达式：`shade.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AcceptEvent();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 5);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 5, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 5, 12));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "ChatContextMenu", MouseFilter = MouseFilterEnum.Stop, ZIndex = 45 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "ChatContextMenu", MouseFilter = MouseFilterEnum.Stop, ZIndex = 45 }`
- `Godot.Control.ResetSize()`；输入表达式：`panel.ResetSize()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.ResetSize();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateOverlay!.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateOverlay!.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Stop }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { MouseFilter = MouseFilterEnum.Stop }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(210, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: title.CustomMinimumSize = new(210, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(210, 38)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(210, 38)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Clamp(position.X, 8, Math.Max(8, shade.Size.X - panel.Size.X - 8)),             Math.Clamp(position.Y, 8, Math.Max(8, shade.Size.Y - panel.Size.Y - 8)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.Position = new(Math.Clamp(position.X, 8, Math.Max(8, shade.Size.X - panel.Size.X - 8)),             Math.Clamp(position.Y, 8, Math.Max(8, shade.Size.Y - panel.Size.Y - 8)))`
- `NationalSpire.CareerScreen.ChatMenuItems(string, bool)`；输入表达式：`ChatMenuItems(id, group)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in ChatMenuItems(id, group))         {             var button = PrivateButton(item.Title, item.Run, 210); button.CustomMinimumSize = new(210, 38);             button.AddThemeFontSizeOverride("font_size", 16); box.AddChild(button);         }`
- `NationalSpire.CareerScreen.CloseChatContextMenu()`；输入表达式：`CloseChatContextMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseChatContextMenu();`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(item.Title, item.Run, 210)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(item.Title, item.Run, 210)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(group ? ViewData.Chats.Groups.Single(g => g.Id == id).Name : GroupChats.Name(ViewData, id), 16, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(group ? ViewData.Chats.Groups.Single(g => g.Id == id).Name : GroupChats.Name(ViewData, id), 16, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152635", "657888", 5, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("152635", "657888", 5, 12)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: group ? ViewData.Chats.Groups.Single(g => g.Id == id).Name : GroupChats.Name(ViewData, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.Chats.Groups.Single(g => g.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ViewData.Chats.Groups.Single(g => g.Id == id).Name`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(position.X, 8, Math.Max(8, shade.Size.X - panel.Size.X - 8))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(position.X, 8, Math.Max(8, shade.Size.X - panel.Size.X - 8))`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(position.Y, 8, Math.Max(8, shade.Size.Y - panel.Size.Y - 8))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(position.Y, 8, Math.Max(8, shade.Size.Y - panel.Size.Y - 8))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(8, shade.Size.X - panel.Size.X - 8)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(8, shade.Size.X - panel.Size.X - 8)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(8, shade.Size.Y - panel.Size.Y - 8)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(8, shade.Size.Y - panel.Size.Y - 8)`

**赋值（含属性/字段和局部值）：**

- `_chatContextMenu` = `shade`
- `button.CustomMinimumSize` = `new(210, 38)`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"ChatContextMenu"`
- `panel.Position` = `new(Math.Clamp(position.X, 8, Math.Max(8, shade.Size.X - panel.Size.X - 8)),             Math.Clamp(position.Y, 8, Math.Max(8, shade.Size.Y - panel.Size.Y - 8)))`
- `shade.GuiInput` += `input =>         {             if (input is InputEventMouseButton { Pressed: true }) { CloseChatContextMenu(); shade.AcceptEvent(); }         }`
- `title.CustomMinimumSize` = `new(210, 0)`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `ZIndex` = `45`
