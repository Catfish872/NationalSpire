# PrivateListRows.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5EC24F4FF09AF28A27284C69B15963B29D4F90DAF8B43CBD3E6E96DD4A142181`。来源：[源码](../../PrivateListRows.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.PrivateListRow`。

字段、事件及初始值（源码原样）：

```csharp
public required ContactRowButton Button;
public required MarginContainer Inset;
public required HBoxContainer Layout;
public required Control Words;
public required CareerAvatar Picture;
public required GroupAvatar Emblem;
public required Label Title, Preview, LastChat;
public required Control Symbol;
public required RelationshipIcon Relationship;
public required TextureRect GroupSymbol;
public string Id = "";
public bool Group;
private readonly List<PrivateListRow> _privateRows = [];
private readonly List<ChatContact> _privateEntries = [];
private Dictionary<string, ChatContacts.Events> _privateEvents = [];
private ScrollContainer? _privateListScroll;
private Label? _privateListEmpty;
```

<a id="symbol-ae3a09702cbd"></a>

## `NationalSpire.CareerScreen.CreatePrivateListRow() — private PrivateListRow CreatePrivateListRow()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** `Godot.CanvasItem.GetLocalMousePosition()`；`Godot.Control.AcceptEvent()`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextureRect.TextureRect()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；`NationalSpire.CareerAvatar.CareerAvatar()`；[`NationalSpire.CareerScreen.ContactActions(string, bool, Godot.Vector2)`](ChatContactScreen.cs.md#symbol-aa5e711d4bd4)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；`NationalSpire.CareerScreen.PrivateListRow.PrivateListRow()`；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；`NationalSpire.ContactRowButton.ContactRowButton()`；`NationalSpire.GroupAvatar.GroupAvatar()`；`NationalSpire.RelationshipIcon.RelationshipIcon()`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.CareerScreen.ContactActions(string, bool, Godot.Vector2)`；`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateListRow.Button`；`NationalSpire.CareerScreen.PrivateListRow.Emblem`；`NationalSpire.CareerScreen.PrivateListRow.Group`；`NationalSpire.CareerScreen.PrivateListRow.GroupSymbol`；`NationalSpire.CareerScreen.PrivateListRow.Id`；`NationalSpire.CareerScreen.PrivateListRow.Inset`；`NationalSpire.CareerScreen.PrivateListRow.LastChat`；`NationalSpire.CareerScreen.PrivateListRow.Layout`；`NationalSpire.CareerScreen.PrivateListRow.Picture`；`NationalSpire.CareerScreen.PrivateListRow.Preview`；`NationalSpire.CareerScreen.PrivateListRow.Relationship`；`NationalSpire.CareerScreen.PrivateListRow.Symbol`；`NationalSpire.CareerScreen.PrivateListRow.Title`；`NationalSpire.CareerScreen.PrivateListRow.Words`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.SelectPrivate(string, int)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateList`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.RelationshipIcon.Tight`；`PositionDetails()`；`PositionWords()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetLocalMousePosition()`；输入表达式：`_privateOverlay!.GetLocalMousePosition()`；返回值紧邻使用处：`ArgumentSyntax: _privateOverlay!.GetLocalMousePosition()`
- `Godot.Control.AcceptEvent()`；输入表达式：`button.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AcceptEvent();`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(40, 40), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(40, 40), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "ContactRightSymbol", Size = new(18, 18), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "ContactRightSymbol", Size = new(18, 18), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`groupSymbol.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: groupSymbol.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateList!.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateList!.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(lastChat)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(lastChat);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(symbol)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(symbol);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(layout)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(layout);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(portrait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portrait.AddChild(emblem)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddChild(emblem);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portrait.AddChild(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddChild(picture);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`symbol.AddChild(groupSymbol)`；返回值紧邻使用处：`ExpressionStatementSyntax: symbol.AddChild(groupSymbol);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`symbol.AddChild(relationship)`；返回值紧邻使用处：`ExpressionStatementSyntax: symbol.AddChild(relationship);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(title);`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = AffectionArt.Texture("contact-group"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Texture = AffectionArt.Texture("contact-group"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, -2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position = new(0, -2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 94)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 94)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(18, 18)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(18, 18)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(40, 40)`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("contact-group")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = AffectionArt.Texture("contact-group")`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Size = new(40, 40), Position = new(0, -2) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Size = new(40, 40), Position = new(0, -2) }`
- `NationalSpire.CareerScreen.ContactActions(string, bool, Godot.Vector2)`；输入表达式：`ContactActions(row.Id, row.Group, _privateOverlay!.GetLocalMousePosition())`；返回值紧邻使用处：`ExpressionStatementSyntax: ContactActions(row.Id, row.Group, _privateOverlay!.GetLocalMousePosition());`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(inset);`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(symbol)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(symbol);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 11, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("", 11, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 19, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("", 19, _ink)`
- `NationalSpire.CareerScreen.PrivateListRow.PrivateListRow()`；输入表达式：`new PrivateListRow { Button = button, Inset = inset, Layout = layout, Words = words, Picture = picture, Emblem = emblem, Title = title, Preview = preview, Relationship = relationship, GroupSymbol = groupSymbol, LastChat = lastChat, Symbol = symbol }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateListRow { Button = button, Inset = inset, Layout = layout, Words = words, Picture = picture, Emblem = emblem, Title = title, Preview = preview, Relationship = relationship, GroupSymbol = groupSymbol, LastChat = lastChat, Symbol = symbol }`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(row.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(row.Id);`
- `NationalSpire.CareerScreen.SelectPrivate(string, int)`；输入表达式：`SelectPrivate(row.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectPrivate(row.Id);`
- `NationalSpire.ContactRowButton.ContactRowButton()`；输入表达式：`new ContactRowButton { CustomMinimumSize = new(0, 94) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ContactRowButton { CustomMinimumSize = new(0, 94) }`
- `NationalSpire.GroupAvatar.GroupAvatar()`；输入表达式：`new GroupAvatar { Size = new(40, 40), Position = new(0, -2) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupAvatar { Size = new(40, 40), Position = new(0, -2) }`
- `NationalSpire.RelationshipIcon.RelationshipIcon()`；输入表达式：`new RelationshipIcon { Tight = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RelationshipIcon { Tight = true }`

**赋值（含属性/字段和局部值）：**

- `Button` = `button`
- `CustomMinimumSize` = `new(0, 94)`
- `CustomMinimumSize` = `new(40, 40)`
- `Emblem` = `emblem`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `GroupSymbol` = `groupSymbol`
- `Inset` = `inset`
- `LastChat` = `lastChat`
- `Layout` = `layout`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"ContactRightSymbol"`
- `Picture` = `picture`
- `Position` = `new(0, -2)`
- `Preview` = `preview`
- `Relationship` = `relationship`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Size` = `new(18, 18)`
- `Size` = `new(40, 40)`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Symbol` = `symbol`
- `Texture` = `AffectionArt.Texture("contact-group")`
- `Tight` = `true`
- `Title` = `title`
- `Words` = `words`
- `button.GuiInput` += `input => { if (input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Right }) { button.AcceptEvent(); ContactActions(row.Id, row.Group, _privateOverlay!.GetLocalMousePosition()); } }`
- `button.Pressed` += `() => { if (row.Group) SelectGroup(row.Id); else SelectPrivate(row.Id); }`
- `button.Resized` += `PositionDetails`
- `lastChat.HorizontalAlignment` = `HorizontalAlignment.Right`
- `lastChat.MouseFilter` = `MouseFilterEnum.Ignore`
- `lastChat.Name` = `"ContactLastChat"`
- `preview.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `title.ItemRectChanged` += `PositionDetails`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `words.Resized` += `PositionWords`

<a id="symbol-6881a0293ca6"></a>

## `PositionDetails() — void PositionDetails()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`PositionWords()`](PrivateListRows.cs.md#symbol-e09f4db2032b)

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.Node.IsInsideTree()`；`Godot.Transform2D.AffineInverse()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`button.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: button.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.Node.IsInsideTree()`；输入表达式：`title.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !title.IsInsideTree()`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`button.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: button.GetGlobalTransformWithCanvas().AffineInverse() * title.GlobalPosition`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(72, button.Size.Y - 24)`；返回值紧邻使用处：`AssignmentExpressionSyntax: lastChat.Position = new(72, button.Size.Y - 24)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Max(0, button.Size.X - 24), at.Y + (title.Size.Y - 18) / 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: symbol.Position = new(Math.Max(0, button.Size.X - 24), at.Y + (title.Size.Y - 18) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Max(0, button.Size.X - 78), 18)`；返回值紧邻使用处：`AssignmentExpressionSyntax: lastChat.Size = new(Math.Max(0, button.Size.X - 78), 18)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, button.Size.X - 24)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, button.Size.X - 24)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, button.Size.X - 78)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, button.Size.X - 78)`

**赋值（含属性/字段和局部值）：**

- `lastChat.Position` = `new(72, button.Size.Y - 24)`
- `lastChat.Size` = `new(Math.Max(0, button.Size.X - 78), 18)`
- `symbol.Position` = `new(Math.Max(0, button.Size.X - 24), at.Y + (title.Size.Y - 18) / 2)`

<a id="symbol-e09f4db2032b"></a>

## `PositionWords() — void PositionWords()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.GetMinimumSize()`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Font.GetHeight(int)`；`Godot.Vector2.Vector2(float, float)`；[`PositionDetails()`](PrivateListRows.cs.md#symbol-6881a0293ca6)；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateListRow.Group`；`PositionDetails()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetMinimumSize()`；输入表达式：`preview.GetMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: preview.GetMinimumSize().Y`
- `Godot.Control.GetMinimumSize()`；输入表达式：`title.GetMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: title.GetMinimumSize().Y`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`title.GetThemeFont("font")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: title.GetThemeFont("font").GetHeight`
- `Godot.Font.GetHeight(int)`；输入表达式：`title.GetThemeFont("font").GetHeight(17)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = title.GetThemeFont("font").GetHeight(17)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 4)`；返回值紧邻使用处：`AssignmentExpressionSyntax: title.Position = new(0, 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, oldHeight + (row.Group ? 6 : 8) + 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview.Position = new(0, oldHeight + (row.Group ? 6 : 8) + 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Max(0, words.Size.X - 22), title.GetMinimumSize().Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: title.Size = new(Math.Max(0, words.Size.X - 22), title.GetMinimumSize().Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(words.Size.X, preview.GetMinimumSize().Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview.Size = new(words.Size.X, preview.GetMinimumSize().Y)`
- `PositionDetails()`；输入表达式：`PositionDetails()`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionDetails();`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, words.Size.X - 22)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, words.Size.X - 22)`

**赋值（含属性/字段和局部值）：**

- `preview.Position` = `new(0, oldHeight + (row.Group ? 6 : 8) + 2)`
- `preview.Size` = `new(words.Size.X, preview.GetMinimumSize().Y)`
- `title.Position` = `new(0, 4)`
- `title.Size` = `new(Math.Max(0, words.Size.X - 22), title.GetMinimumSize().Y)`

<a id="symbol-a42f68b15faf"></a>

## `NationalSpire.CareerScreen.ShowPrivateListRows() — private void ShowPrivateListRows()`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.QueueRedraw()`；`Godot.CanvasItem.Show()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.ChatContacts.LastChatText(int, int)`](ChatContacts.cs.md#symbol-f0f9556075d1)；[`NationalSpire.ContactRowButton.Bind(bool, bool, bool)`](ContactRowButton.cs.md#symbol-9183c2f045e6)；[`NationalSpire.ContactRowButton.EventIndicators(NationalSpire.ChatContacts.Events)`](ContactRowButton.cs.md#symbol-dce5f4626186)；[`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`](GroupAvatar.cs.md#symbol-5d97e2be271b)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-8f55a4576019)；`NationalSpire.PrivateRelation.PrivateRelation()`；[`NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-d6b37bf58f98)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Globalization.StringInfo.StringInfo(string)`；`System.Globalization.StringInfo.SubstringByTextElements(int, int)`；`System.Math.Ceiling(double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`；`string.Replace(char, char)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerScreen.CreatePrivateListRow()`；`NationalSpire.CareerScreen.PrivateListRow.Button`；`NationalSpire.CareerScreen.PrivateListRow.Emblem`；`NationalSpire.CareerScreen.PrivateListRow.Group`；`NationalSpire.CareerScreen.PrivateListRow.GroupSymbol`；`NationalSpire.CareerScreen.PrivateListRow.Id`；`NationalSpire.CareerScreen.PrivateListRow.Inset`；`NationalSpire.CareerScreen.PrivateListRow.LastChat`；`NationalSpire.CareerScreen.PrivateListRow.Layout`；`NationalSpire.CareerScreen.PrivateListRow.Picture`；`NationalSpire.CareerScreen.PrivateListRow.Preview`；`NationalSpire.CareerScreen.PrivateListRow.Relationship`；`NationalSpire.CareerScreen.PrivateListRow.Title`；`NationalSpire.CareerScreen.PrivateListRow.Words`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._chatFilter`；`NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.CareerScreen._privateEntries`；`NationalSpire.CareerScreen._privateEvents`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateList`；`NationalSpire.CareerScreen._privateListEmpty`；`NationalSpire.CareerScreen._privateListScroll`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateRows`；`NationalSpire.ChatContact.Day`；`NationalSpire.ChatContact.Group`；`NationalSpire.ChatContact.Id`；`NationalSpire.ChatContactPreferences.Hidden`；`NationalSpire.ChatContactPreferences.Pinned`；`NationalSpire.ChatContactPreferences.ShowHidden`；`NationalSpire.ChatContactPreferences.ShowRelationships`；`NationalSpire.ChatContacts.LastChatText(int, int)`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.ContactRowButton.Bind(bool, bool, bool)`；`NationalSpire.ContactRowButton.EventIndicators(NationalSpire.ChatContacts.Events)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Seen`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.RelationshipIcon.Bond`；`NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PrivateListRows`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_privateRows[i].Button.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateRows[i].Button.Hide();`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`row.Relationship.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Relationship.QueueRedraw();`
- `Godot.CanvasItem.Show()`；输入表达式：`row.Button.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Button.Show();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Inset.AddThemeConstantOverride("margin_" + edge, margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Inset.AddThemeConstantOverride("margin_" + edge, margin);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Inset.AddThemeConstantOverride("margin_bottom", margin + 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Inset.AddThemeConstantOverride("margin_bottom", margin + 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Inset.AddThemeConstantOverride("margin_left", margin + 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Inset.AddThemeConstantOverride("margin_left", margin + 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.Layout.AddThemeConstantOverride("separation", margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Layout.AddThemeConstantOverride("separation", margin);`
- `Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；输入表达式：`row.Words.EmitSignal(Control.SignalName.Resized)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Words.EmitSignal(Control.SignalName.Resized);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateList)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_privateList)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, (first + i) * 94)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Button.Position = new(0, (first + i) * 94)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(_privateList.Size.X, 94)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Button.Size = new(_privateList.Size.X, 94)`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, p.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Picture.Identity = AvatarHonors.ForPerson(data, p.Id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, p.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Picture.Art = CareerAvatars.ForPerson(data, p.Id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, row.Id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, row.Id)!`
- `NationalSpire.CareerScreen.CreatePrivateListRow()`；输入表达式：`CreatePrivateListRow()`；返回值紧邻使用处：`ArgumentSyntax: CreatePrivateListRow()`
- `NationalSpire.ChatContacts.LastChatText(int, int)`；输入表达式：`ChatContacts.LastChatText(data.Day, entry.Day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.LastChat.Text = ChatContacts.LastChatText(data.Day, entry.Day)`
- `NationalSpire.ContactRowButton.Bind(bool, bool, bool)`；输入表达式：`row.Button.Bind(_contactPreferences.Pinned.Contains(contactKey), _contactPreferences.Hidden.Contains(contactKey) && _contactPreferences.ShowHidden, selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Button.Bind(_contactPreferences.Pinned.Contains(contactKey), _contactPreferences.Hidden.Contains(contactKey) && _contactPreferences.ShowHidden, selected);`
- `NationalSpire.ContactRowButton.EventIndicators(NationalSpire.ChatContacts.Events)`；输入表达式：`row.Button.EventIndicators(_privateEvents.GetValueOrDefault(contactKey))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Button.EventIndicators(_privateEvents.GetValueOrDefault(contactKey));`
- `NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`；输入表达式：`row.Emblem.Update(data, g)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Emblem.Update(data, g);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data)`
- `NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`；输入表达式：`PrivateMessages.UnreadInCommunications(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c == null ? 0 : PrivateMessages.UnreadInCommunications(c)`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: box.Relations.GetValueOrDefault(p.Id) ?? new()`
- `NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`；输入表达式：`RelationshipPresentation.IconBond(box.Relations.GetValueOrDefault(p.Id) ?? new())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RelationshipPresentation.IconBond(box.Relations.GetValueOrDefault(p.Id) ?? new())`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PrivateListRows, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PrivateListRows, "通讯")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_contactPreferences.Hidden.Contains(contactKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: _contactPreferences.Hidden.Contains(contactKey) && _contactPreferences.ShowHidden`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`.Replies.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Replies.LastOrDefault()?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.Turns.LastOrDefault()?.Text`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c?.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Chats.Groups.Single(g => g.Id == row.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Chats.Groups.Single(g => g.Id == row.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_privateEvents.GetValueOrDefault(contactKey)`；返回值紧邻使用处：`ArgumentSyntax: _privateEvents.GetValueOrDefault(contactKey)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Conversations.GetValueOrDefault(row.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = box.Conversations.GetValueOrDefault(row.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Relations.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: box.Relations.GetValueOrDefault(p.Id) ?? new()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`g.Seen.GetValueOrDefault(GroupChats.Human(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_privateRows.Add(CreatePrivateListRow())`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateRows.Add(CreatePrivateListRow());`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`_contactPreferences.Pinned.Contains(contactKey)`；返回值紧邻使用处：`ArgumentSyntax: _contactPreferences.Pinned.Contains(contactKey)`
- `System.Globalization.StringInfo.StringInfo(string)`；输入表达式：`new System.Globalization.StringInfo(preview)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.Globalization.StringInfo(preview)`
- `System.Globalization.StringInfo.SubstringByTextElements(int, int)`；输入表达式：`elements.SubstringByTextElements(0, 12)`；返回值紧邻使用处：`BinaryExpressionSyntax: elements.SubstringByTextElements(0, 12) + "…"`
- `System.Math.Ceiling(double)`；输入表达式：`Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(_privateListScroll.ScrollVertical / 94 - 1, 0, Math.Max(0, _privateEntries.Count - 1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(_privateListScroll.ScrollVertical / 94 - 1, 0, Math.Max(0, _privateEntries.Count - 1))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(500, _privateListScroll.Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(500, _privateListScroll.Size.Y) / 94`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _privateEntries.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, _privateEntries.Count - 1)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_privateEntries.Count - first, (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94) + 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(_privateEntries.Count - first, (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94) + 3)`
- `string.Replace(char, char)`；输入表达式：`preview.Replace('\n', ' ')`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview = preview.Replace('\n', ' ')`

**赋值（含属性/字段和局部值）：**

- `(row.Id, row.Group)` = `(entry.Id, entry.Group)`
- `_privateListEmpty.Visible` = `_privateEntries.Count == 0 && _chatFilter != "群聊"`
- `preview` = `c?.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications) is { } t ? t.Status == "complete" && !t.ReplyDeleted ? t.Reply : t.Scene?.Ending == true ? "正在整理约会感想" : t.User : "开始聊天"`
- `preview` = `g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text ?? g.Turns.LastOrDefault()?.Text ?? $"{g.Members.Count} 位成员"`
- `preview` = `preview.Replace('\n', ' ')`
- `row.Button.Position` = `new(0, (first + i) * 94)`
- `row.Button.Size` = `new(_privateList.Size.X, 94)`
- `row.Emblem.Visible` = `row.Group`
- `row.GroupSymbol.Visible` = `row.Group`
- `row.LastChat.Text` = `ChatContacts.LastChatText(data.Day, entry.Day)`
- `row.Picture.Art` = `CareerAvatars.ForPerson(data, p.Id)`
- `row.Picture.Identity` = `AvatarHonors.ForPerson(data, p.Id)`
- `row.Picture.PersonId` = `p.Id`
- `row.Picture.Visible` = `!row.Group`
- `row.Preview.Text` = `elements.LengthInTextElements > 12 ? elements.SubstringByTextElements(0, 12) + "…" : preview`
- `row.Relationship.Bond` = `bond`
- `row.Relationship.Visible` &= `bond != "unfamiliar"`
- `row.Relationship.Visible` = `!row.Group && _contactPreferences.ShowRelationships`
- `row.Title.Text` = `g.Name + (unread > 0 ? " ●" : "")`
- `row.Title.Text` = `p.PublicName + (unread > 0 ? " ●" : "")`
- `unread` = `c == null ? 0 : PrivateMessages.UnreadInCommunications(c)`
- `unread` = `g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data))`
