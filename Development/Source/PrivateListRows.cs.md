# PrivateListRows.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5A5C9C4F6E2CBD9D176A82D79E34DBD472F1ECF8D1C3CE3B5971FBA9FB31786B`。来源：[源码](../../PrivateListRows.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.PrivateListRow`。

字段、事件及初始值（源码原样）：

```csharp
public required Button Button;
public required MarginContainer Inset;
public required HBoxContainer Layout;
public required VBoxContainer Words;
public required CareerAvatar Picture;
public required Label Emblem, Title, Preview;
public string Id = "";
public bool Group;
private readonly List<PrivateListRow> _privateRows = [];
private readonly List<(string Id, bool Group)> _privateEntries = [];
private ScrollContainer? _privateListScroll;
private Label? _privateListEmpty;
```

<a id="symbol-ae3a09702cbd"></a>

## `NationalSpire.CareerScreen.CreatePrivateListRow() — private PrivateListRow CreatePrivateListRow()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerAvatar.CareerAvatar()`；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；`NationalSpire.CareerScreen.PrivateListRow.PrivateListRow()`；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-ddace6dd7c79)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateListRow.Button`；`NationalSpire.CareerScreen.PrivateListRow.Emblem`；`NationalSpire.CareerScreen.PrivateListRow.Group`；`NationalSpire.CareerScreen.PrivateListRow.Id`；`NationalSpire.CareerScreen.PrivateListRow.Inset`；`NationalSpire.CareerScreen.PrivateListRow.Layout`；`NationalSpire.CareerScreen.PrivateListRow.Picture`；`NationalSpire.CareerScreen.PrivateListRow.Preview`；`NationalSpire.CareerScreen.PrivateListRow.Title`；`NationalSpire.CareerScreen.PrivateListRow.Words`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.SelectPrivate(string, int)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateList`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateList!.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateList!.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(layout)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(layout);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(emblem)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(emblem);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(picture);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(title);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 82)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(0, 82)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(38, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: emblem.CustomMinimumSize = new(38, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 40)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { CustomMinimumSize = new(40, 40), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { CustomMinimumSize = new(40, 40), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => { }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => { }, 0)`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(inset);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 17, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("", 17, _ink)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("群", 23, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("群", 23, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.PrivateListRow.PrivateListRow()`；输入表达式：`new PrivateListRow { Button = button, Inset = inset, Layout = layout, Words = words, Picture = picture, Emblem = emblem, Title = title, Preview = preview }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateListRow { Button = button, Inset = inset, Layout = layout, Words = words, Picture = picture, Emblem = emblem, Title = title, Preview = preview }`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(row.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(row.Id);`
- `NationalSpire.CareerScreen.SelectPrivate(string, int)`；输入表达式：`SelectPrivate(row.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectPrivate(row.Id);`

**赋值（含属性/字段和局部值）：**

- `Button` = `button`
- `CustomMinimumSize` = `new(40, 40)`
- `Emblem` = `emblem`
- `Inset` = `inset`
- `Layout` = `layout`
- `Picture` = `picture`
- `Preview` = `preview`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Title` = `title`
- `Words` = `words`
- `button.CustomMinimumSize` = `new(0, 82)`
- `button.Pressed` += `() => { if (row.Group) SelectGroup(row.Id); else SelectPrivate(row.Id); }`
- `emblem.CustomMinimumSize` = `new(38, 0)`
- `preview.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`

<a id="symbol-a42f68b15faf"></a>

## `NationalSpire.CareerScreen.ShowPrivateListRows() — private void ShowPrivateListRows()`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Vector2.Vector2(float, float)`；`string.Replace(char, char)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Ceiling(double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerScreen._chatFilter`；`NationalSpire.CareerScreen._privateEntries`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateList`；`NationalSpire.CareerScreen._privateListEmpty`；`NationalSpire.CareerScreen._privateListScroll`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateRows`；`NationalSpire.CareerScreen.CreatePrivateListRow()`；`NationalSpire.CareerScreen.PrivateListRow.Button`；`NationalSpire.CareerScreen.PrivateListRow.Emblem`；`NationalSpire.CareerScreen.PrivateListRow.Group`；`NationalSpire.CareerScreen.PrivateListRow.Id`；`NationalSpire.CareerScreen.PrivateListRow.Inset`；`NationalSpire.CareerScreen.PrivateListRow.Layout`；`NationalSpire.CareerScreen.PrivateListRow.Picture`；`NationalSpire.CareerScreen.PrivateListRow.Preview`；`NationalSpire.CareerScreen.PrivateListRow.Title`；`NationalSpire.CareerScreen.PrivateListRow.Words`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Seen`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PrivateListRows`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_privateRows[i].Button.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateRows[i].Button.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`row.Button.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Button.Show();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Inset.AddThemeConstantOverride("margin_" + edge, margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Inset.AddThemeConstantOverride("margin_" + edge, margin);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Layout.AddThemeConstantOverride("separation", margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Layout.AddThemeConstantOverride("separation", margin);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Words.AddThemeConstantOverride("separation", row.Group ? 6 : 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Words.AddThemeConstantOverride("separation", row.Group ? 6 : 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`row.Button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(selected ? "334b60" : "142536", selected ? "d8bc7e" : "334b60", 8, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(selected ? "334b60" : "142536", selected ? "d8bc7e" : "334b60", 8, 10));`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateList)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_privateList)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(_privateList.Size.X, 82)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Button.Size = new(_privateList.Size.X, 82)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, (first + i) * 94)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Button.Position = new(0, (first + i) * 94)`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, p.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Picture.Identity = AvatarHonors.ForPerson(data, p.Id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, p.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Picture.Art = CareerAvatars.ForPerson(data, p.Id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, row.Id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, row.Id)!`
- `NationalSpire.CareerScreen.CreatePrivateListRow()`；输入表达式：`CreatePrivateListRow()`；返回值紧邻使用处：`ArgumentSyntax: CreatePrivateListRow()`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(selected ? "334b60" : "142536", selected ? "d8bc7e" : "334b60", 8, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(selected ? "334b60" : "142536", selected ? "d8bc7e" : "334b60", 8, 10)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PrivateListRows, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PrivateListRows, "通讯")`
- `string.Replace(char, char)`；输入表达式：`preview.Replace('\n', ' ')`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Preview.Text = preview.Replace('\n', ' ')`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Turns.Count(t => t.Status == "complete") - c.SeenCount`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`.Replies.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Replies.LastOrDefault()?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.Turns.LastOrDefault()?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.LastOrDefault(t => !(t.UserDeleted && t.ReplyDeleted))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c?.Turns.LastOrDefault(t => !(t.UserDeleted && t.ReplyDeleted))`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Chats.Groups.Single(g => g.Id == row.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Chats.Groups.Single(g => g.Id == row.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Conversations.GetValueOrDefault(row.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = box.Conversations.GetValueOrDefault(row.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`g.Seen.GetValueOrDefault(GroupChats.Human(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_privateRows.Add(CreatePrivateListRow())`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateRows.Add(CreatePrivateListRow());`
- `System.Math.Ceiling(double)`；输入表达式：`Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(_privateListScroll.ScrollVertical / 94 - 1, 0, Math.Max(0, _privateEntries.Count - 1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(_privateListScroll.ScrollVertical / 94 - 1, 0, Math.Max(0, _privateEntries.Count - 1))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(500, _privateListScroll.Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(500, _privateListScroll.Size.Y) / 94`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _privateEntries.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, _privateEntries.Count - 1)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_privateEntries.Count - first, (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94) + 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(_privateEntries.Count - first, (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94) + 3)`

**赋值（含属性/字段和局部值）：**

- `_privateListEmpty.Visible` = `_privateEntries.Count == 0 && _chatFilter != "群聊"`
- `(row.Id, row.Group)` = `_privateEntries[first + i]`
- `preview` = `c?.Turns.LastOrDefault(t => !(t.UserDeleted && t.ReplyDeleted)) is { } t ? t.Status == "complete" && !t.ReplyDeleted ? t.Reply : t.User : "开始聊天"`
- `preview` = `g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text ?? g.Turns.LastOrDefault()?.Text ?? $"{g.Members.Count} 位成员"`
- `preview` = `preview[..25] + "…"`
- `row.Button.Position` = `new(0, (first + i) * 94)`
- `row.Button.Size` = `new(_privateList.Size.X, 82)`
- `row.Emblem.Visible` = `row.Group`
- `row.Picture.Art` = `CareerAvatars.ForPerson(data, p.Id)`
- `row.Picture.Identity` = `AvatarHonors.ForPerson(data, p.Id)`
- `row.Picture.PersonId` = `p.Id`
- `row.Picture.Visible` = `!row.Group`
- `row.Preview.Text` = `preview.Replace('\n', ' ')`
- `row.Title.Text` = `g.Name + (unread > 0 ? "  ●" : "")`
- `row.Title.Text` = `p.PublicName + (unread > 0 ? "  ●" : "")`
- `unread` = `c == null ? 0 : c.Turns.Count(t => t.Status == "complete") - c.SeenCount`
- `unread` = `g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data))`
