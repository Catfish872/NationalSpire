# DateHistoryList.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`94F997AA27F12C0A0742683BF8230B62AACDA3DBCEC34F7BBB864A2F050F1392`。来源：[源码](../../DateHistoryList.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateHistoryEntry`、`NationalSpire.DateHistoryList`、`NationalSpire.DateHistoryGuide`。

字段、事件及初始值（源码原样）：

```csharp
private readonly VBoxContainer _rows = new() { SizeFlagsHorizontal = SizeFlags.ExpandFill };
private readonly Dictionary<(string Turn, bool Reply), (HBoxContainer Row, RichTextLabel Text)> _cache = [];
private readonly StyleBoxFlat _normal = CareerVisuals.Box("00000000", "00000000", 6, 10);
private readonly StyleBoxFlat _highlighted = CareerVisuals.Box("29485970", "00000000", 6, 10);
private Action<string>? _delete;
private Font? _font;
private int _size;
```

<a id="symbol-cb983449c64c"></a>

## `NationalSpire.DateHistoryList._Ready() — public override void _Ready()`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateHistoryList._rows`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_rows.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _rows.AddThemeConstantOverride("separation", 18);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_rows)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_rows);`

**赋值（含属性/字段和局部值）：**

- `FocusMode` = `FocusModeEnum.All`
- `HorizontalScrollMode` = `ScrollMode.Disabled`

<a id="symbol-49f0126dc7e3"></a>

## `NationalSpire.DateHistoryList.Populate(System.Collections.Generic.IReadOnlyList<NationalSpire.DateHistoryEntry>, Godot.Font, int, System.Action<string>?) — public void Populate(IReadOnlyList<DateHistoryEntry> entries, Font font, int size, Action<string>? delete)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.RefreshHistory(bool)`](DateSceneView.cs.md#symbol-0762d57cebb4)

**调用：** `Godot.Button.Button()`；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.HasFocus()`；`Godot.GodotObject.GetInstanceId()`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.RichTextLabel.RichTextLabel()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`Highlight(bool)`](DateHistoryList.cs.md#symbol-23b190fd703e)；`NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；`NationalSpire.DateHistoryGuide.DateHistoryGuide()`；`NationalSpire.DateMemoryEraser.DateMemoryEraser()`；`System.Action<T>.Invoke(T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Highlight(bool)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.DateHistoryEntry.Reply`；`NationalSpire.DateHistoryEntry.Text`；`NationalSpire.DateHistoryEntry.TurnId`；`NationalSpire.DateHistoryList._cache`；`NationalSpire.DateHistoryList._delete`；`NationalSpire.DateHistoryList._font`；`NationalSpire.DateHistoryList._normal`；`NationalSpire.DateHistoryList._rows`；`NationalSpire.DateHistoryList._size`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = "DateHistoryErase", CustomMinimumSize = new(40, 38), MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = "DateHistoryErase", CustomMinimumSize = new(40, 38), MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.CanvasItem.Hide()`；输入表达式：`old.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: old.Hide();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, .55f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Modulate = new Color(1, 1, 1, .55f)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`text.AddThemeColorOverride("default_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeColorOverride("default_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`cached.Text.AddThemeFontOverride("normal_font", font)`；返回值紧邻使用处：`ExpressionStatementSyntax: cached.Text.AddThemeFontOverride("normal_font", font);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`text.AddThemeFontOverride("normal_font", font)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeFontOverride("normal_font", font);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`cached.Text.AddThemeFontSizeOverride("normal_font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: cached.Text.AddThemeFontSizeOverride("normal_font_size", size);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeFontSizeOverride("normal_font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeFontSizeOverride("normal_font_size", size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`erase.AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: erase.AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", _normal)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", _normal);`
- `Godot.Control.HasFocus()`；输入表达式：`erase.HasFocus()`；返回值紧邻使用处：`ArgumentSyntax: erase.HasFocus()`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`old.GetInstanceId()`；返回值紧邻使用处：`BinaryExpressionSyntax: "Retired_" + old.GetInstanceId()`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`row.SetMeta("turn", entry.TurnId)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.SetMeta("turn", entry.TurnId);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = entry.Reply ? "DateHistoryReply" : "DateHistoryPlayer", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = entry.Reply ? "DateHistoryReply" : "DateHistoryPlayer", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_rows.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _rows.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`erase.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: erase.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(text);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rail.AddChild(erase)`；返回值紧邻使用处：`ExpressionStatementSyntax: rail.AddChild(erase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rail.AddChild(guide)`；返回值紧邻使用处：`ExpressionStatementSyntax: rail.AddChild(guide);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(rail)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(rail);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`cached.Row.GetIndex()`；返回值紧邻使用处：`BinaryExpressionSyntax: cached.Row.GetIndex() != order`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`_rows.MoveChild(cached.Row, order)`；返回值紧邻使用处：`ExpressionStatementSyntax: _rows.MoveChild(cached.Row, order);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`_rows.MoveChild(row, order++)`；返回值紧邻使用处：`ExpressionStatementSyntax: _rows.MoveChild(row, order++);`
- `Godot.Node.QueueFree()`；输入表达式：`old.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: old.QueueFree();`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { Text = entry.Text, BbcodeEnabled = false, FitContent = true, ScrollActive = false, SelectionEnabled = true, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RichTextLabel { Text = entry.Text, BbcodeEnabled = false, FitContent = true, ScrollActive = false, SelectionEnabled = true, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(40, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(40, 0) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 18)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 18)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 38)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 38)`
- `Highlight(bool)`；输入表达式：`Highlight(erase.HasFocus())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Highlight(erase.HasFocus())`
- `Highlight(bool)`；输入表达式：`Highlight(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Highlight(false)`
- `Highlight(bool)`；输入表达式：`Highlight(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Highlight(true)`
- `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；输入表达式：`new("", "约会开始后的对话会显示在这里。", false)`；返回值紧邻使用处：`ExpressionElementSyntax: new("", "约会开始后的对话会显示在这里。", false)`
- `NationalSpire.DateHistoryGuide.DateHistoryGuide()`；输入表达式：`new DateHistoryGuide { SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 18), MouseFilter = MouseFilterEnum.Ignore, Visible = entry.Reply }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateHistoryGuide { SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 18), MouseFilter = MouseFilterEnum.Ignore, Visible = entry.Reply }`
- `NationalSpire.DateMemoryEraser.DateMemoryEraser()`；输入表达式：`new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore, Modulate = new Color(1, 1, 1, .55f) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore, Modulate = new Color(1, 1, 1, .55f) }`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(entry.TurnId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _delete?.Invoke(entry.TurnId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_cache.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _cache.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_cache.TryGetValue((entry.TurnId, entry.Reply), out var cached)`；返回值紧邻使用处：`IfStatementSyntax: if (_cache.TryGetValue((entry.TurnId, entry.Reply), out var cached)) { if (cached.Text.Text != entry.Text) cached.Text.Text = entry.Text; if (appearanceChanged) { cached.Text.AddThemeFontOverride("normal_font", font); cached.Text.AddThemeFontSizeOverride("normal_font_size", size); } if (cached.Row.GetIndex() != order) _rows.MoveChild(cached.Row, order); order++; continue; }`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`keys.Contains(k)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !keys.Contains(k)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => (e.TurnId, e.Reply))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Select(e => (e.TurnId, e.Reply)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_cache.Keys.Where(k => !keys.Contains(k)).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var key in _cache.Keys.Where(k => !keys.Contains(k)).ToArray()) { var old = _cache[key].Row; old.Hide(); old.Name = "Retired_" + old.GetInstanceId(); old.QueueFree(); _cache.Remove(key); }`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`entries.Select(e => (e.TurnId, e.Reply)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.Select(e => (e.TurnId, e.Reply)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cache.Keys.Where(k => !keys.Contains(k))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _cache.Keys.Where(k => !keys.Contains(k)).ToArray`

**赋值（含属性/字段和局部值）：**

- `BbcodeEnabled` = `false`
- `CustomMinimumSize` = `new(40, 0)`
- `CustomMinimumSize` = `new(40, 18)`
- `CustomMinimumSize` = `new(40, 38)`
- `FitContent` = `true`
- `Modulate` = `new Color(1, 1, 1, .55f)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateHistoryErase"`
- `Name` = `entry.Reply ? "DateHistoryReply" : "DateHistoryPlayer"`
- `ScrollActive` = `false`
- `SelectionEnabled` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Text` = `entry.Text`
- `Visible` = `entry.Reply`
- `_cache[(entry.TurnId, entry.Reply)]` = `(row, text)`
- `_delete` = `delete`
- `_font` = `font`
- `_size` = `size`
- `cached.Text.Text` = `entry.Text`
- `entries` = `[new("", "约会开始后的对话会显示在这里。", false)]`
- `erase.FocusEntered` += `() => Highlight(true)`
- `erase.FocusExited` += `() => Highlight(false)`
- `erase.MouseEntered` += `() => Highlight(true)`
- `erase.MouseExited` += `() => Highlight(erase.HasFocus())`
- `erase.Pressed` += `() => _delete?.Invoke(entry.TurnId)`
- `old.Name` = `"Retired_" + old.GetInstanceId()`

<a id="symbol-23b190fd703e"></a>

## `Highlight(bool) — void Highlight(bool active)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateHistoryList.Populate(System.Collections.Generic.IReadOnlyList<NationalSpire.DateHistoryEntry>, Godot.Font, int, System.Action<string>?)`](DateHistoryList.cs.md#symbol-49f0126dc7e3)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateHistoryGuide.Highlighted`；`NationalSpire.DateHistoryList._highlighted`；`NationalSpire.DateHistoryList._normal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`guide.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: guide.QueueRedraw();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, active ? 1 : .55f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: icon.Modulate = new Color(1, 1, 1, active ? 1 : .55f)`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", active ? _highlighted : _normal)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", active ? _highlighted : _normal);`

**赋值（含属性/字段和局部值）：**

- `guide.Highlighted` = `active`
- `icon.Modulate` = `new Color(1, 1, 1, active ? 1 : .55f)`

<a id="symbol-1889f7ebb5b0"></a>

## `NationalSpire.DateHistoryGuide.Highlighted — public bool Highlighted`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fd522aa9860a"></a>

## `NationalSpire.DateHistoryGuide._Draw() — public override void _Draw()`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(float, float, float, float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateHistoryGuide.Highlighted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(Size.X / 2, 7), new(Size.X / 2, Math.Max(8, Size.Y - 4)), new Color(.66f, .86f, .9f, Highlighted ? .95f : .45f), 2, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawLine(new(Size.X / 2, 7), new(Size.X / 2, Math.Max(8, Size.Y - 4)), new Color(.66f, .86f, .9f, Highlighted ? .95f : .45f), 2, true)`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(.66f, .86f, .9f, Highlighted ? .95f : .45f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(.66f, .86f, .9f, Highlighted ? .95f : .45f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X / 2, 7)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X / 2, 7)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X / 2, Math.Max(8, Size.Y - 4))`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X / 2, Math.Max(8, Size.Y - 4))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(8, Size.Y - 4)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(8, Size.Y - 4)`

**赋值（含属性/字段和局部值）：**
