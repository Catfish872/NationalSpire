# MentionComposer.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`568937A18B316E440C1D25A13300DC4856CB06AA5D2FE77E76FC3F40BFE6ECCE`。来源：[源码](../../MentionComposer.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-8702f28d36a7"></a>

## `NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer) — private void AddMentionPicker(TextEdit editor, VBoxContainer parent)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)

**调用：** [`Choose(int)`](MentionComposer.cs.md#symbol-c6ce7c91e139)；`Godot.CanvasItem.Hide()`；`Godot.Control.AcceptEvent()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；[`Highlight()`](MentionComposer.cs.md#symbol-62ce1e6b06e1)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `Choose(int)`；`Highlight()`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choose(int)`；输入表达式：`Choose(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choose(selected);`
- `Godot.CanvasItem.Hide()`；输入表达式：`panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Hide();`
- `Godot.Control.AcceptEvent()`；输入表达式：`editor.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AcceptEvent();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102431", "7294aa", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102431", "7294aa", 8, 12));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "MentionSuggestions", Visible = false, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "MentionSuggestions", Visible = false, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Highlight()`；输入表达式：`Highlight()`；返回值紧邻使用处：`ExpressionStatementSyntax: Highlight();`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("102431", "7294aa", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("102431", "7294aa", 8, 12)`

**赋值（含属性/字段和局部值）：**

- `Name` = `"MentionSuggestions"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Visible` = `false`
- `editor.CaretChanged` += `Refresh`
- `editor.GuiInput` += `ev => { if (!panel.Visible || ev is not InputEventKey { Pressed: true } key) return; if (key.Keycode is Key.Up or Key.Left or Key.Down or Key.Right) { selected = (selected + (key.Keycode is Key.Up or Key.Left ? -1 : 1) + people.Count) % people.Count; Highlight(); editor.AcceptEvent(); } else if (key.Keycode is Key.Enter or Key.KpEnter or Key.Tab) { Choose(selected); editor.AcceptEvent(); } else if (key.Keycode == Key.Escape) { panel.Hide(); editor.AcceptEvent(); } }`
- `editor.TextChanged` += `Refresh`
- `selected` = `(selected + (key.Keycode is Key.Up or Key.Left ? -1 : 1) + people.Count) % people.Count`

<a id="symbol-c6ce7c91e139"></a>

## `Choose(int) — void Choose(int index)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`Refresh()`](MentionComposer.cs.md#symbol-4f3b085d9a1d)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Control.GrabFocus()`；`Godot.TextEdit.GetCaretColumn(int)`；`Godot.TextEdit.InsertTextAtCaret(string, int)`；`Godot.TextEdit.Select(int, int, int, int, int)`；[`NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CommunityMentions.cs.md#symbol-ca8974eb53ca)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ViewData`；`NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Hide();`
- `Godot.Control.GrabFocus()`；输入表达式：`editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.GrabFocus();`
- `Godot.TextEdit.GetCaretColumn(int)`；输入表达式：`editor.GetCaretColumn()`；返回值紧邻使用处：`ArgumentSyntax: editor.GetCaretColumn()`
- `Godot.TextEdit.InsertTextAtCaret(string, int)`；输入表达式：`editor.InsertTextAtCaret(CommunityMentions.Token(ViewData, people[index]) + " ")`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.InsertTextAtCaret(CommunityMentions.Token(ViewData, people[index]) + " ");`
- `Godot.TextEdit.Select(int, int, int, int, int)`；输入表达式：`editor.Select(line, at, line, editor.GetCaretColumn())`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.Select(line, at, line, editor.GetCaretColumn());`
- `NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CommunityMentions.Token(ViewData, people[index])`；返回值紧邻使用处：`BinaryExpressionSyntax: CommunityMentions.Token(ViewData, people[index]) + " "`

**赋值（含属性/字段和局部值）：**

- `choosing` = `false`
- `choosing` = `true`

<a id="symbol-62ce1e6b06e1"></a>

## `Highlight() — void Highlight()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`Refresh()`](MentionComposer.cs.md#symbol-4f3b085d9a1d)

**调用：** `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`buttons[i].AddThemeStyleboxOverride("normal", CareerVisuals.Box(i == selected ? "365369" : "102431", i == selected ? "ddc58c" : "102431", 5, 9))`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons[i].AddThemeStyleboxOverride("normal", CareerVisuals.Box(i == selected ? "365369" : "102431", i == selected ? "ddc58c" : "102431", 5, 9));`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(i == selected ? "365369" : "102431", i == selected ? "ddc58c" : "102431", 5, 9)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(i == selected ? "365369" : "102431", i == selected ? "ddc58c" : "102431", 5, 9)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4f3b085d9a1d"></a>

## `Refresh() — void Refresh()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Choose(int)`](MentionComposer.cs.md#symbol-c6ce7c91e139)；`Godot.CanvasItem.Hide()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.GetCaretColumn(int)`；`Godot.TextEdit.GetCaretLine(int)`；`Godot.TextEdit.GetLine(int)`；[`Highlight()`](MentionComposer.cs.md#symbol-62ce1e6b06e1)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`string.Contains(char)`；`string.Contains(string, System.StringComparison)`；`string.EnumerateRunes()`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `Choose(int)`；`Highlight()`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choose(int)`；输入表达式：`Choose(index)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Choose(index)`
- `Godot.CanvasItem.Hide()`；输入表达式：`panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Hide();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(button);`
- `Godot.TextEdit.GetCaretColumn(int)`；输入表达式：`editor.GetCaretColumn()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = editor.GetCaretColumn()`
- `Godot.TextEdit.GetCaretLine(int)`；输入表达式：`editor.GetCaretLine()`；返回值紧邻使用处：`AssignmentExpressionSyntax: line = editor.GetCaretLine()`
- `Godot.TextEdit.GetLine(int)`；输入表达式：`editor.GetLine(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = editor.GetLine(line)`
- `Highlight()`；输入表达式：`Highlight()`；返回值紧邻使用处：`ExpressionStatementSyntax: Highlight();`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(p.PublicName + " · " + p.Role + " · " + p.Country, () => Choose(index))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(p.PublicName + " · " + p.Role + " · " + p.Country, () => Choose(index))`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(list);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(ViewData, p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`query.Any(char.IsWhiteSpace)`；返回值紧邻使用处：`BinaryExpressionSyntax: at < 0 || query.Any(char.IsWhiteSpace)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take(6)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take(6).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take(6).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: people = ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take(6).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`buttons.Add(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.Add(button);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`buttons.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.Clear();`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take`
- `string.Contains(char)`；输入表达式：`query.Contains('〔')`；返回值紧邻使用处：`BinaryExpressionSyntax: at < 0 || query.Any(char.IsWhiteSpace) || query.Contains('〔')`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.EnumerateRunes()`；输入表达式：`text.EnumerateRunes()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var rune in text.EnumerateRunes()) { if (column >= caretColumn) break; if (rune.Value == '@') { at = column; atOffset = offset; } offset += rune.Utf16SequenceLength; column++; }`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `atOffset` = `offset`
- `at` = `-1`
- `at` = `column`
- `button.FocusMode` = `FocusModeEnum.None`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `line` = `editor.GetCaretLine()`
- `offset` += `rune.Utf16SequenceLength`
- `panel.Visible` = `people.Count > 0`
- `people` = `ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))) .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take(6).ToList()`
- `selected` = `0`
