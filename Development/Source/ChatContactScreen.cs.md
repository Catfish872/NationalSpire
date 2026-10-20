# ChatContactScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`31261F8ABF82DE381209D01A4DD771E31559290AEBE33B4D2AEDE88303CE0312`。来源：[源码](../../ChatContactScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.ContactMenuCheck`、`NationalSpire.ContactSortIcon`。

字段、事件及初始值（源码原样）：

```csharp
private ChatContactPreferences _contactPreferences = new();
private Control? _contactMenu;
```

<a id="symbol-e08a92c62c9a"></a>

## `NationalSpire.CareerScreen.LoadContactPreferences() — private void LoadContactPreferences()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LoadChatPreferences()`](ChatHistoryScreen.cs.md#symbol-d1d5bc5023c7)

**调用：** `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.Variant.AsString()`；`NationalSpire.ChatContactPreferences.ChatContactPreferences()`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`；`NationalSpire.ChatContactPreferences.Hidden`；`NationalSpire.ChatContactPreferences.Pinned`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString`
- `Godot.Variant.AsString()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString()`；返回值紧邻使用处：`ArgumentSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString()`
- `NationalSpire.ChatContactPreferences.ChatContactPreferences()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _contactPreferences = new()`
- `NationalSpire.ChatContactPreferences.ChatContactPreferences()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<ChatContactPreferences>(ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString()) ?? new()`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<ChatContactPreferences>(ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString())`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<ChatContactPreferences>(ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString()) ?? new()`

**赋值（含属性/字段和局部值）：**

- `_contactPreferences.Hidden` ??= `[]`
- `_contactPreferences.Pinned` ??= `[]`
- `_contactPreferences` = `JsonSerializer.Deserialize<ChatContactPreferences>(ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString()) ?? new()`
- `_contactPreferences` = `new()`

<a id="symbol-ecb1bd4e6ac2"></a>

## `NationalSpire.CareerScreen.SaveContactPreferences() — private void SaveContactPreferences()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ContactSort(Godot.Control)`](ChatContactScreen.cs.md#symbol-b15a59ff01fb)

**调用：** [`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.WriteChatPreferences()`](ChatHistoryScreen.cs.md#symbol-15e26075b1d4)；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen.WriteChatPreferences()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.SetValue(ChatPreferenceKey, "contacts", JsonSerializer.Serialize(_contactPreferences))`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.SetValue(ChatPreferenceKey, "contacts", JsonSerializer.Serialize(_contactPreferences));`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.CareerScreen.WriteChatPreferences()`；输入表达式：`WriteChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: WriteChatPreferences();`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(_contactPreferences)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(_contactPreferences)`

**赋值（含属性/字段和局部值）：**

- `_privateListSignature` = `""`

<a id="symbol-878c75543fa8"></a>

## `NationalSpire.CareerScreen.CloseContactMenu() — private void CloseContactMenu()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int)`](ChatContactScreen.cs.md#symbol-20cc99232e33)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._contactMenu`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_contactMenu!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _contactMenu!.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_contactMenu)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_contactMenu)) { _contactMenu!.Hide(); _contactMenu.QueueFree(); }`
- `Godot.Node.QueueFree()`；输入表达式：`_contactMenu.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _contactMenu.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_contactMenu` = `null`

<a id="symbol-20cc99232e33"></a>

## `NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int) — private void ContactMenu(Vector2 position, Action<VBoxContainer> contents, int width = 216)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ContactSort(Godot.Control)`](ChatContactScreen.cs.md#symbol-b15a59ff01fb)

**调用：** [`NationalSpire.CareerScreen.CloseContactMenu()`](ChatContactScreen.cs.md#symbol-878c75543fa8)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AcceptEvent()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._contactMenu`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.CloseContactMenu()`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AcceptEvent()`；输入表达式：`overlay.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.AcceptEvent();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 2);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192d3e", "526d80", 6, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192d3e", "526d80", 6, 4));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "ContactMenu", MouseFilter = MouseFilterEnum.Stop, ZIndex = 42 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "ContactMenu", MouseFilter = MouseFilterEnum.Stop, ZIndex = 42 }`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`panel.GetCombinedMinimumSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = panel.GetCombinedMinimumSize()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateOverlay!.AddChild(overlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateOverlay!.AddChild(overlay);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`overlay.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(box);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "ContactMenuPanel", MouseFilter = MouseFilterEnum.Stop }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "ContactMenuPanel", MouseFilter = MouseFilterEnum.Stop }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(width, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(width, 0) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Clamp(position.X, 4, Math.Max(4, overlay.Size.X - size.X - 4)), Math.Clamp(position.Y, 4, Math.Max(4, overlay.Size.Y - size.Y - 4)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.Position = new(Math.Clamp(position.X, 4, Math.Max(4, overlay.Size.X - size.X - 4)), Math.Clamp(position.Y, 4, Math.Max(4, overlay.Size.Y - size.Y - 4)))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width, 0)`
- `NationalSpire.CareerScreen.CloseContactMenu()`；输入表达式：`CloseContactMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseContactMenu();`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("192d3e", "526d80", 6, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("192d3e", "526d80", 6, 4)`
- `System.Action<T>.Invoke(T)`；输入表达式：`contents(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents(box);`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(position.X, 4, Math.Max(4, overlay.Size.X - size.X - 4))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(position.X, 4, Math.Max(4, overlay.Size.X - size.X - 4))`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(position.Y, 4, Math.Max(4, overlay.Size.Y - size.Y - 4))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(position.Y, 4, Math.Max(4, overlay.Size.Y - size.Y - 4))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(4, overlay.Size.X - size.X - 4)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(4, overlay.Size.X - size.X - 4)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(4, overlay.Size.Y - size.Y - 4)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(4, overlay.Size.Y - size.Y - 4)`

**赋值（含属性/字段和局部值）：**

- `_contactMenu` = `overlay`
- `CustomMinimumSize` = `new(width, 0)`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"ContactMenu"`
- `Name` = `"ContactMenuPanel"`
- `overlay.GuiInput` += `e => { if (e is InputEventMouseButton { Pressed: true }) { overlay.AcceptEvent(); CloseContactMenu(); } }`
- `panel.Position` = `new(Math.Clamp(position.X, 4, Math.Max(4, overlay.Size.X - size.X - 4)), Math.Clamp(position.Y, 4, Math.Max(4, overlay.Size.Y - size.Y - 4)))`
- `ZIndex` = `42`

<a id="symbol-264ab6f4d753"></a>

## `NationalSpire.CareerScreen.ContactMenuItem(string, System.Action, bool) — private Button ContactMenuItem(string text, Action action, bool check = false)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ContactSort(Godot.Control)`](ChatContactScreen.cs.md#symbol-b15a59ff01fb)

**调用：** [`NationalSpire.ContactMenuCheck.ContactMenuCheck()`](ChatContactScreen.cs.md#symbol-a0bdf3d719db)；`Godot.Button.Button()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button()`；返回值紧邻使用处：`ConditionalExpressionSyntax: check ? new ContactMenuCheck() : new Button()`
- `Godot.Color.Color(string)`；输入表达式：`new Color("375468")`；返回值紧邻使用处：`ConditionalExpressionSyntax: state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state, _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state, _ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, new StyleBoxFlat { BgColor = state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468"),                  ContentMarginLeft = 12, ContentMarginRight = check ? 38 : 12, ContentMarginTop = 6, ContentMarginBottom = 6 })`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, new StyleBoxFlat { BgColor = state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468"),                  ContentMarginLeft = 12, ContentMarginRight = check ? 38 : 12, ContentMarginTop = 6, ContentMarginBottom = 6 });`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468"),                  ContentMarginLeft = 12, ContentMarginRight = check ? 38 : 12, ContentMarginTop = 6, ContentMarginBottom = 6 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor = state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468"),                  ContentMarginLeft = 12, ContentMarginRight = check ? 38 : 12, ContentMarginTop = 6, ContentMarginBottom = 6 }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(0, 36)`
- `NationalSpire.ContactMenuCheck.ContactMenuCheck()`；输入表达式：`new ContactMenuCheck()`；返回值紧邻使用处：`ConditionalExpressionSyntax: check ? new ContactMenuCheck() : new Button()`

**赋值（含属性/字段和局部值）：**

- `BgColor` = `state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468")`
- `button.Alignment` = `HorizontalAlignment.Left`
- `button.CustomMinimumSize` = `new(0, 36)`
- `button.FocusMode` = `FocusModeEnum.None`
- `button.Pressed` += `action`
- `button.Text` = `text`
- `ContentMarginBottom` = `6`
- `ContentMarginLeft` = `12`
- `ContentMarginRight` = `check ? 38 : 12`
- `ContentMarginTop` = `6`

<a id="symbol-b15a59ff01fb"></a>

## `NationalSpire.CareerScreen.ContactSort(Godot.Control) — private void ContactSort(Control anchor)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildContactSearch(Godot.VBoxContainer)`](ChatContactScreen.cs.md#symbol-3c7d41806831)

**调用：** [`Highlight()`](ChatContactScreen.cs.md#symbol-a1734e817870)；[`NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int)`](ChatContactScreen.cs.md#symbol-20cc99232e33)；[`NationalSpire.CareerScreen.ContactMenuItem(string, System.Action, bool)`](ChatContactScreen.cs.md#symbol-264ab6f4d753)；[`NationalSpire.CareerScreen.SaveContactPreferences()`](ChatContactScreen.cs.md#symbol-ecb1bd4e6ac2)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** `Highlight()`；`NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int)`；`NationalSpire.CareerScreen.ContactMenuItem(string, System.Action, bool)`；`NationalSpire.CareerScreen.SaveContactPreferences()`；`NationalSpire.ChatContactPreferences.Reverse`；`NationalSpire.ChatContactPreferences.ShowRelationships`；`NationalSpire.ChatContactPreferences.Sort`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(relationships)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(relationships);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, anchor.Size.Y + 6)`；返回值紧邻使用处：`BinaryExpressionSyntax: anchor.GlobalPosition + new Vector2(0, anchor.Size.Y + 6)`
- `Highlight()`；输入表达式：`Highlight()`；返回值紧邻使用处：`ExpressionStatementSyntax: Highlight();`
- `NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int)`；输入表达式：`ContactMenu(anchor.GlobalPosition + new Vector2(0, anchor.Size.Y + 6) - _privateOverlay!.GlobalPosition, box =>          {              var buttons = new Dictionary<string, Button>();              void Highlight()              {                  foreach (var (id, button) in buttons)                      ((StyleBoxFlat)button.GetThemeStylebox("normal")).BgColor = _contactPreferences.Sort == id ? new Color("2b4355") : Colors.Transparent;              }              foreach (var (id, label) in new[] { ("favour", "按好感度"), ("time", "按时间"), ("name", "按首字母"), ("type", "按类别") })              {                  bool nextReverse = _contactPreferences.Sort == id ? !_contactPreferences.Reverse : false;                  var button = ContactMenuItem(label + (_contactPreferences.Sort == id && _contactPreferences.Reverse ? "倒序" : "正序"), () =>                  {                      _contactPreferences.Sort = id; _contactPreferences.Reverse = nextReverse; nextReverse = !nextReverse;                      foreach (var pair in buttons) pair.Value.Text = pair.Value.Text[..^2] + (pair.Key == id && _contactPreferences.Reverse ? "倒序" : "正序"); SaveContactPreferences(); Highlight();                  });                  button.Name = "ContactSort_" + id; buttons[id] = button; box.AddChild(button);              }              Highlight();              var relationships = ContactMenuItem("展示人物关系图标", () => { }, true); relationships.Name = "ShowContactRelationships"; relationships.ButtonPressed = _contactPreferences.ShowRelationships; box.AddChild(relationships);              relationships.Toggled += value => { _contactPreferences.ShowRelationships = value; SaveContactPreferences(); };          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ContactMenu(anchor.GlobalPosition + new Vector2(0, anchor.Size.Y + 6) - _privateOverlay!.GlobalPosition, box =>          {              var buttons = new Dictionary<string, Button>();              void Highlight()              {                  foreach (var (id, button) in buttons)                      ((StyleBoxFlat)button.GetThemeStylebox("normal")).BgColor = _contactPreferences.Sort == id ? new Color("2b4355") : Colors.Transparent;              }              foreach (var (id, label) in new[] { ("favour", "按好感度"), ("time", "按时间"), ("name", "按首字母"), ("type", "按类别") })              {                  bool nextReverse = _contactPreferences.Sort == id ? !_contactPreferences.Reverse : false;                  var button = ContactMenuItem(label + (_contactPreferences.Sort == id && _contactPreferences.Reverse ? "倒序" : "正序"), () =>                  {                      _contactPreferences.Sort = id; _contactPreferences.Reverse = nextReverse; nextReverse = !nextReverse;                      foreach (var pair in buttons) pair.Value.Text = pair.Value.Text[..^2] + (pair.Key == id && _contactPreferences.Reverse ? "倒序" : "正序"); SaveContactPreferences(); Highlight();                  });                  button.Name = "ContactSort_" + id; buttons[id] = button; box.AddChild(button);              }              Highlight();              var relationships = ContactMenuItem("展示人物关系图标", () => { }, true); relationships.Name = "ShowContactRelationships"; relationships.ButtonPressed = _contactPreferences.ShowRelationships; box.AddChild(relationships);              relationships.Toggled += value => { _contactPreferences.ShowRelationships = value; SaveContactPreferences(); };          });`
- `NationalSpire.CareerScreen.ContactMenuItem(string, System.Action, bool)`；输入表达式：`ContactMenuItem("展示人物关系图标", () => { }, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ContactMenuItem("展示人物关系图标", () => { }, true)`
- `NationalSpire.CareerScreen.ContactMenuItem(string, System.Action, bool)`；输入表达式：`ContactMenuItem(label + (_contactPreferences.Sort == id && _contactPreferences.Reverse ? "倒序" : "正序"), () =>                  {                      _contactPreferences.Sort = id; _contactPreferences.Reverse = nextReverse; nextReverse = !nextReverse;                      foreach (var pair in buttons) pair.Value.Text = pair.Value.Text[..^2] + (pair.Key == id && _contactPreferences.Reverse ? "倒序" : "正序"); SaveContactPreferences(); Highlight();                  })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ContactMenuItem(label + (_contactPreferences.Sort == id && _contactPreferences.Reverse ? "倒序" : "正序"), () =>                  {                      _contactPreferences.Sort = id; _contactPreferences.Reverse = nextReverse; nextReverse = !nextReverse;                      foreach (var pair in buttons) pair.Value.Text = pair.Value.Text[..^2] + (pair.Key == id && _contactPreferences.Reverse ? "倒序" : "正序"); SaveContactPreferences(); Highlight();                  })`
- `NationalSpire.CareerScreen.SaveContactPreferences()`；输入表达式：`SaveContactPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveContactPreferences();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Button>()`

**赋值（含属性/字段和局部值）：**

- `_contactPreferences.Reverse` = `nextReverse`
- `_contactPreferences.ShowRelationships` = `value`
- `_contactPreferences.Sort` = `id`
- `button.Name` = `"ContactSort_" + id`
- `buttons[id]` = `button`
- `nextReverse` = `!nextReverse`
- `pair.Value.Text` = `pair.Value.Text[..^2] + (pair.Key == id && _contactPreferences.Reverse ? "倒序" : "正序")`
- `relationships.ButtonPressed` = `_contactPreferences.ShowRelationships`
- `relationships.Name` = `"ShowContactRelationships"`
- `relationships.Toggled` += `value => { _contactPreferences.ShowRelationships = value; SaveContactPreferences(); }`

<a id="symbol-a1734e817870"></a>

## `Highlight() — void Highlight()`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ContactSort(Godot.Control)`](ChatContactScreen.cs.md#symbol-b15a59ff01fb)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.ChatContactPreferences.Sort`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("2b4355")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _contactPreferences.Sort == id ? new Color("2b4355") : Colors.Transparent`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`button.GetThemeStylebox("normal")`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBoxFlat)button.GetThemeStylebox("normal")`

**赋值（含属性/字段和局部值）：**

- `((StyleBoxFlat)button.GetThemeStylebox("normal")).BgColor` = `_contactPreferences.Sort == id ? new Color("2b4355") : Colors.Transparent`

<a id="symbol-3c7d41806831"></a>

## `NationalSpire.CareerScreen.BuildContactSearch(Godot.VBoxContainer) — private void BuildContactSearch(VBoxContainer sidebar)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)

**调用：** [`NationalSpire.CareerScreen.ContactSort(Godot.Control)`](ChatContactScreen.cs.md#symbol-b15a59ff01fb)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Resource.Duplicate(bool)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.ContactSortIcon.ContactSortIcon()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privateQuery`；`NationalSpire.CareerScreen.ContactSort(Godot.Control)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.RefreshPrivateList()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`search.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: search.AddThemeStyleboxOverride(state, style);`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`search.GetThemeStylebox(state)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: search.GetThemeStylebox(state).Duplicate`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`icon.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "ContactSearch", PlaceholderText = "搜索选手或群聊", CustomMinimumSize = new(216, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "ContactSearch", PlaceholderText = "搜索选手或群聊", CustomMinimumSize = new(216, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(sort)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(sort);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sidebar.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: sidebar.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sort.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: sort.AddChild(icon);`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`search.GetThemeStylebox(state).Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBox)search.GetThemeStylebox(state).Duplicate()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(216, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(216, 42)`
- `NationalSpire.CareerScreen.ContactSort(Godot.Control)`；输入表达式：`ContactSort(sort)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ContactSort(sort)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => { }, 42)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => { }, 42)`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.ContactSortIcon.ContactSortIcon()`；输入表达式：`new ContactSortIcon { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ContactSortIcon { MouseFilter = MouseFilterEnum.Ignore }`

**赋值（含属性/字段和局部值）：**

- `_privateListSignature` = `""`
- `_privateQuery` = `value`
- `CustomMinimumSize` = `new(216, 42)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"ContactSearch"`
- `PlaceholderText` = `"搜索选手或群聊"`
- `search.TextChanged` += `value => { _privateQuery = value; _privateListSignature = ""; RefreshPrivateList(); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `sort.Name` = `"ContactSort"`
- `sort.Pressed` += `() => ContactSort(sort)`
- `sort.TooltipText` = `"聊天排序"`
- `style.ContentMarginBottom` = `8`
- `style.ContentMarginTop` = `style.ContentMarginBottom = 8`

<a id="symbol-a0bdf3d719db"></a>

## `NationalSpire.ContactMenuCheck.ContactMenuCheck() — public ContactMenuCheck()`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ContactMenuItem(string, System.Action, bool)`](ChatContactScreen.cs.md#symbol-264ab6f4d753)

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => QueueRedraw()`

**赋值（含属性/字段和局部值）：**

- `Resized` += `QueueRedraw`
- `Toggled` += `_ => QueueRedraw()`
- `ToggleMode` = `true`

<a id="symbol-59f2f1cf73a3"></a>

## `NationalSpire.ContactMenuCheck._Draw() — public override void _Draw()`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([origin + new Vector2(3, 8), origin + new Vector2(7, 12), origin + new Vector2(13, 4)], CareerVisuals.Teal, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([origin + new Vector2(3, 8), origin + new Vector2(7, 12), origin + new Vector2(13, 4)], CareerVisuals.Teal, 2, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(new Rect2(origin, new(16, 16)), new Color("b6cad4"), false, 1.2f)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(origin, new(16, 16)), new Color("b6cad4"), false, 1.2f);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("b6cad4")`；返回值紧邻使用处：`ArgumentSyntax: new Color("b6cad4")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(origin, new(16, 16))`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(origin, new(16, 16))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(13, 4)`；返回值紧邻使用处：`BinaryExpressionSyntax: origin + new Vector2(13, 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(3, 8)`；返回值紧邻使用处：`BinaryExpressionSyntax: origin + new Vector2(3, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(7, 12)`；返回值紧邻使用处：`BinaryExpressionSyntax: origin + new Vector2(7, 12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X - 28, (Size.Y - 16) / 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(Size.X - 28, (Size.Y - 16) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16, 16)`；返回值紧邻使用处：`ArgumentSyntax: new(16, 16)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f5047693afbe"></a>

## `NationalSpire.ContactSortIcon._Draw() — public override void _Draw()`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Line(float, float, float, float)`](ChatContactScreen.cs.md#symbol-13c184e70dea)；`Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** `Line(float, float, float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("dce7ee")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("dce7ee")`
- `Line(float, float, float, float)`；输入表达式：`Line(-1, -7, 12, -7)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-1, -7, 12, -7);`
- `Line(float, float, float, float)`；输入表达式：`Line(-1, 0, 9, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-1, 0, 9, 0);`
- `Line(float, float, float, float)`；输入表达式：`Line(-1, 7, 6, 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-1, 7, 6, 7);`
- `Line(float, float, float, float)`；输入表达式：`Line(-13, 4, -9, 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-13, 4, -9, 8);`
- `Line(float, float, float, float)`；输入表达式：`Line(-9, -8, -9, 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-9, -8, -9, 8);`
- `Line(float, float, float, float)`；输入表达式：`Line(-9, 8, -5, 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-9, 8, -5, 4);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-13c184e70dea"></a>

## `Line(float, float, float, float) — void Line(float x, float y, float a, float b)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ContactSortIcon._Draw()`](ChatContactScreen.cs.md#symbol-f5047693afbe)

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(c + new Vector2(x, y), c + new Vector2(a, b), ink, 1.8f, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawLine(c + new Vector2(x, y), c + new Vector2(a, b), ink, 1.8f, true)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(a, b)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(a, b)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(x, y)`

**赋值（含属性/字段和局部值）：**
