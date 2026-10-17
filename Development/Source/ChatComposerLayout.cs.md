# ChatComposerLayout.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1F715E9E23CE2DBB0C93CD65E84EB15E76932130EE551FC60BAC63C1C5B32263`。来源：[源码](../../ChatComposerLayout.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatComposerLayout`、`NationalSpire.ChatComposerButtonSlot`、`NationalSpire.ChatComposerPanel`、`NationalSpire.ChatComposerExpandIcon`。

字段、事件及初始值（源码原样）：

```csharp
internal const float ButtonScale = .9f;
internal const float SendWidthIncrease = 20;
internal const float SendEdgeCompensation = SendWidthIncrease * (1 - ButtonScale) / 2;
private bool _centerPages;
private Control? _bounds;
private VBoxContainer? _body;
private TextEdit? _editor;
private ScrollContainer? _attachments;
private Control? _heading;
private ScrollContainer? _headingViewport;
private float _attachmentHeight = 72;
private bool _resizeQueued;
public event Action<bool>? ExpansionChanged;
```

<a id="symbol-50b5fb8cff87"></a>

## `NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control) — internal static void CompactButtons(Control parent)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`](ChatComposerLayout.cs.md#symbol-50b5fb8cff87)

**调用：** [`NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`](ChatComposerLayout.cs.md#symbol-50b5fb8cff87)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.RemoveChild(Godot.Node)`；`NationalSpire.ChatComposerButtonSlot.ChatComposerButtonSlot()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(slot)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(slot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slot.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: slot.AddChild(button);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`parent.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parent.GetChildren().OfType<Control>`
- `Godot.Node.GetIndex(bool)`；输入表达式：`button.GetIndex()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = button.GetIndex()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`parent.MoveChild(slot, index)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.MoveChild(slot, index);`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`parent.RemoveChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.RemoveChild(button);`
- `NationalSpire.ChatComposerButtonSlot.ChatComposerButtonSlot()`；输入表达式：`new ChatComposerButtonSlot { Name = button.Name + "Slot", Visible = button.Visible,                  SizeFlagsHorizontal = button.SizeFlagsHorizontal, SizeFlagsVertical = button.SizeFlagsVertical }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ChatComposerButtonSlot { Name = button.Name + "Slot", Visible = button.Visible,                  SizeFlagsHorizontal = button.SizeFlagsHorizontal, SizeFlagsVertical = button.SizeFlagsVertical }`
- `NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`；输入表达式：`CompactButtons(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: CompactButtons(child);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`parent.GetChildren().OfType<Control>().ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in parent.GetChildren().OfType<Control>().ToArray())          {              if (child is not BaseButton button) { CompactButtons(child); continue; }              int index = button.GetIndex();              var slot = new ChatComposerButtonSlot { Name = button.Name + "Slot", Visible = button.Visible,                  SizeFlagsHorizontal = button.SizeFlagsHorizontal, SizeFlagsVertical = button.SizeFlagsVertical };              parent.RemoveChild(button); parent.AddChild(slot); parent.MoveChild(slot, index); slot.AddChild(button);              button.VisibilityChanged += () => slot.Visible = button.Visible;          }`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`parent.GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parent.GetChildren().OfType<Control>().ToArray`

**赋值（含属性/字段和局部值）：**

- `button.VisibilityChanged` += `() => slot.Visible = button.Visible`
- `Name` = `button.Name + "Slot"`
- `SizeFlagsHorizontal` = `button.SizeFlagsHorizontal`
- `SizeFlagsVertical` = `button.SizeFlagsVertical`
- `slot.Visible` = `button.Visible`
- `Visible` = `button.Visible`

<a id="symbol-12a05a82e4a8"></a>

## `NationalSpire.ChatComposerLayout.CenterPages — public bool CenterPages`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Container.QueueSort()`；`Godot.Control.UpdateMinimumSize()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerLayout._centerPages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Container.QueueSort()`；输入表达式：`QueueSort()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueSort();`
- `Godot.Control.UpdateMinimumSize()`；输入表达式：`UpdateMinimumSize()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateMinimumSize();`

**赋值（含属性/字段和局部值）：**

- `_centerPages` = `value`

<a id="symbol-f80626c2ca18"></a>

## `NationalSpire.ChatComposerLayout._GetMinimumSize() — public override Vector2 _GetMinimumSize()`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Node.GetChildren(bool)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, float>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, float>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerLayout.CenterPages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`p.GetCombinedMinimumSize()`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero`
- `Godot.Node.GetChildren(bool)`；输入表达式：`GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChildren().OfType<Control>`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, sizes.Max(s => s.Y))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(width, sizes.Max(s => s.Y));`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, float>)`；输入表达式：`sizes.Max(s => s.Y)`；返回值紧邻使用处：`ArgumentSyntax: sizes.Max(s => s.Y)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, float>)`；输入表达式：`sizes.Sum(s => s.X)`；返回值紧邻使用处：`BinaryExpressionSyntax: sizes.Sum(s => s.X) + 34`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`GetChildren().OfType<Control>().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetChildren().OfType<Control>().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChildren().OfType<Control>().ToArray`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(sizes[0].X + 14 + halfPages, halfPages + 14 + sizes[3].X)`；返回值紧邻使用处：`BinaryExpressionSyntax: 2 * Math.Max(sizes[0].X + 14 + halfPages, halfPages + 14 + sizes[3].X)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eeea474dcd68"></a>

## `NationalSpire.ChatComposerLayout._Notification(int) — public override void _Notification(int what)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetChildren(bool)`；`Godot.Rect2.Rect2(float, float, float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerLayout.ButtonScale`；`NationalSpire.ChatComposerLayout.CenterPages`；`NationalSpire.ChatComposerLayout.SendEdgeCompensation`；`NationalSpire.ChatComposerLayout.SendWidthIncrease`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(parts[0], new Rect2(0, 0, sizes[0].X, Size.Y))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(parts[0], new Rect2(0, 0, sizes[0].X, Size.Y));`
- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(parts[1], new Rect2(pageX, 0, sizes[1].X, Size.Y))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(parts[1], new Rect2(pageX, 0, sizes[1].X, Size.Y));`
- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(parts[2], new Rect2(optionsX, 0, sizes[2].X, Size.Y))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(parts[2], new Rect2(optionsX, 0, sizes[2].X, Size.Y));`
- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(parts[3], new Rect2(Size.X - sendWidth + SendEdgeCompensation, 0, sendWidth, Size.Y))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(parts[3], new Rect2(Size.X - sendWidth + SendEdgeCompensation, 0, sendWidth, Size.Y));`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`p.GetCombinedMinimumSize()`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`parts[1].GetChild<Control>(0).GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parts[1].GetChild<Control>(0).GetCombinedMinimumSize().X`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`parts[2].GetChild<Control>(parts[2].GetChildCount() - 1).GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parts[2].GetChild<Control>(parts[2].GetChildCount() - 1).GetCombinedMinimumSize().X`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`parts[1].GetChild<Control>(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parts[1].GetChild<Control>(0).GetCombinedMinimumSize`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`parts[2].GetChild<Control>(parts[2].GetChildCount() - 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parts[2].GetChild<Control>(parts[2].GetChildCount() - 1).GetCombinedMinimumSize`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`parts[2].GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: parts[2].GetChildCount() - 1`
- `Godot.Node.GetChildren(bool)`；输入表达式：`GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChildren().OfType<Control>`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(0, 0, sizes[0].X, Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(0, 0, sizes[0].X, Size.Y)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(optionsX, 0, sizes[2].X, Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(optionsX, 0, sizes[2].X, Size.Y)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(pageX, 0, sizes[1].X, Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(pageX, 0, sizes[1].X, Size.Y)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(Size.X - sendWidth + SendEdgeCompensation, 0, sendWidth, Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Size.X - sendWidth + SendEdgeCompensation, 0, sendWidth, Size.Y)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`GetChildren().OfType<Control>().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetChildren().OfType<Control>().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChildren().OfType<Control>().ToArray`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(sendSpace, originalMinimum, Math.Max(150, originalMinimum))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(sendSpace, originalMinimum, Math.Max(150, originalMinimum)) + extra`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(150, originalMinimum)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(150, originalMinimum)`

**赋值（含属性/字段和局部值）：**

- `pageX` = `(Size.X - sizes[1].X - 6 - sizes[2].X) / 2 + (last - first) * (1 - ButtonScale) / 4`

<a id="symbol-18db48c3b5c0"></a>

## `NationalSpire.ChatComposerButtonSlot._GetMinimumSize() — public override Vector2 _GetMinimumSize()`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetChildCount(bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`GetChild<Control>(0).GetCombinedMinimumSize()`；返回值紧邻使用处：`ConditionalExpressionSyntax: GetChildCount() == 0 ? Vector2.Zero : GetChild<Control>(0).GetCombinedMinimumSize()`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`GetChild<Control>(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChild<Control>(0).GetCombinedMinimumSize`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetChildCount() == 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-533d48480292"></a>

## `NationalSpire.ChatComposerButtonSlot._Notification(int) — public override void _Notification(int what)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetChildCount(bool)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerLayout.ButtonScale`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(button, new Rect2(Vector2.Zero, Size))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(button, new Rect2(Vector2.Zero, Size));`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`GetChild<Control>(0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetChild<Control>(0)`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetChildCount() == 0`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`

**赋值（含属性/字段和局部值）：**

- `button.PivotOffset` = `button.Size / 2`
- `button.Scale` = `Vector2.One * ChatComposerLayout.ButtonScale`

<a id="symbol-0179a5b248ee"></a>

## `NationalSpire.ChatComposerPanel.Expanded — public bool Expanded`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-65c9c36a106d"></a>

## `NationalSpire.ChatComposerPanel.Bind(Godot.Control, Godot.VBoxContainer, Godot.TextEdit, Godot.ScrollContainer, Godot.Control) — public void Bind(Control bounds, VBoxContainer body, TextEdit editor, ScrollContainer attachments, Control heading)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)

**调用：** [`NationalSpire.ChatComposerPanel.QueueResize()`](ChatComposerLayout.cs.md#symbol-f90f839a1baa)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.GetParent<T>()`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.ScrollContainer.ScrollContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerPanel._attachments`；`NationalSpire.ChatComposerPanel._body`；`NationalSpire.ChatComposerPanel._bounds`；`NationalSpire.ChatComposerPanel._editor`；`NationalSpire.ChatComposerPanel._heading`；`NationalSpire.ChatComposerPanel._headingViewport`；`NationalSpire.ChatComposerPanel.QueueResize()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_headingViewport.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: _headingViewport.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`chat.AddChild(_headingViewport)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.AddChild(_headingViewport);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`heading.GetIndex()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = heading.GetIndex()`
- `Godot.Node.GetParent<T>()`；输入表达式：`heading.GetParent<Container>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = heading.GetParent<Container>()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`chat.MoveChild(_headingViewport, index)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.MoveChild(_headingViewport, index);`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`chat.RemoveChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.RemoveChild(heading);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "PrivateIdentityViewport", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, FollowFocus = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _headingViewport = new ScrollContainer { Name = "PrivateIdentityViewport", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, FollowFocus = true }`
- `NationalSpire.ChatComposerPanel.QueueResize()`；输入表达式：`QueueResize()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueResize();`

**赋值（含属性/字段和局部值）：**

- `_attachments` = `attachments`
- `_body` = `body`
- `_bounds` = `bounds`
- `_editor` = `editor`
- `_heading` = `heading`
- `_headingViewport` = `new ScrollContainer { Name = "PrivateIdentityViewport", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, FollowFocus = true }`
- `body.MinimumSizeChanged` += `QueueResize`
- `bounds.Resized` -= `QueueResize`
- `bounds.Resized` += `QueueResize`
- `editor.SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `FollowFocus` = `true`
- `heading.MinimumSizeChanged` += `QueueResize`
- `heading.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"PrivateIdentityViewport"`
- `TreeExiting` += `() => bounds.Resized -= QueueResize`

<a id="symbol-19c3c4544409"></a>

## `NationalSpire.ChatComposerPanel.Toggle() — public void Toggle()`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)

**调用：** [`NationalSpire.ChatComposerPanel.SetExpanded(bool)`](ChatComposerLayout.cs.md#symbol-37f504323d88)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerPanel.Expanded`；`NationalSpire.ChatComposerPanel.SetExpanded(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatComposerPanel.SetExpanded(bool)`；输入表达式：`SetExpanded(!Expanded)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SetExpanded(!Expanded)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-37f504323d88"></a>

## `NationalSpire.ChatComposerPanel.SetExpanded(bool) — public void SetExpanded(bool value)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.ChatComposerPanel.Toggle()`](ChatComposerLayout.cs.md#symbol-19c3c4544409)

**调用：** [`NationalSpire.ChatComposerPanel.QueueResize()`](ChatComposerLayout.cs.md#symbol-f90f839a1baa)；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerPanel.Expanded`；`NationalSpire.ChatComposerPanel.ExpansionChanged`；`NationalSpire.ChatComposerPanel.QueueResize()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatComposerPanel.QueueResize()`；输入表达式：`QueueResize()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueResize();`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(value)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ExpansionChanged?.Invoke(value)`

**赋值（含属性/字段和局部值）：**

- `Expanded` = `value`

<a id="symbol-b5a6e5f6347c"></a>

## `NationalSpire.ChatComposerPanel.SetAttachmentHeight(float) — public void SetAttachmentHeight(float height)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)

**调用：** [`NationalSpire.ChatComposerPanel.QueueResize()`](ChatComposerLayout.cs.md#symbol-f90f839a1baa)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerPanel._attachmentHeight`；`NationalSpire.ChatComposerPanel.QueueResize()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatComposerPanel.QueueResize()`；输入表达式：`QueueResize()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueResize();`

**赋值（含属性/字段和局部值）：**

- `_attachmentHeight` = `height`

<a id="symbol-f90f839a1baa"></a>

## `NationalSpire.ChatComposerPanel.QueueResize() — private void QueueResize()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatComposerPanel.Bind(Godot.Control, Godot.VBoxContainer, Godot.TextEdit, Godot.ScrollContainer, Godot.Control)`](ChatComposerLayout.cs.md#symbol-65c9c36a106d)；[`NationalSpire.ChatComposerPanel.SetAttachmentHeight(float)`](ChatComposerLayout.cs.md#symbol-b5a6e5f6347c)；[`NationalSpire.ChatComposerPanel.SetExpanded(bool)`](ChatComposerLayout.cs.md#symbol-37f504323d88)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Node.IsInsideTree()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerPanel._resizeQueued`；`NationalSpire.ChatComposerPanel.ResizeComposer()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(ResizeComposer).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(ResizeComposer).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(ResizeComposer)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(ResizeComposer).CallDeferred`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`

**赋值（含属性/字段和局部值）：**

- `_resizeQueued` = `true`

<a id="symbol-34bdcf47b03a"></a>

## `NationalSpire.ChatComposerPanel.ResizeComposer() — private void ResizeComposer()`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetThemeConstant(Godot.StringName, Godot.StringName)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetChildren(bool)`；`Godot.Node.GetParent<T>()`；`Godot.Node.IsInsideTree()`；`Godot.StyleBox.GetMinimumSize()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, float>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatComposerPanel._attachmentHeight`；`NationalSpire.ChatComposerPanel._attachments`；`NationalSpire.ChatComposerPanel._body`；`NationalSpire.ChatComposerPanel._bounds`；`NationalSpire.ChatComposerPanel._editor`；`NationalSpire.ChatComposerPanel._heading`；`NationalSpire.ChatComposerPanel._headingViewport`；`NationalSpire.ChatComposerPanel._resizeQueued`；`NationalSpire.ChatComposerPanel.Expanded`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_attachments.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _attachments.GetCombinedMinimumSize().Y`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_body.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _body.GetCombinedMinimumSize().Y`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_heading.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _heading.GetCombinedMinimumSize().Y`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`c.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.GetCombinedMinimumSize().Y`
- `Godot.Control.GetThemeConstant(Godot.StringName, Godot.StringName)`；输入表达式：`chat.GetThemeConstant("separation")`；返回值紧邻使用处：`BinaryExpressionSyntax: chat.GetThemeConstant("separation") * (siblings.Length - 1)`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`_bounds.GetThemeStylebox("panel")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _bounds.GetThemeStylebox("panel").GetMinimumSize`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`GetThemeStylebox("panel")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetThemeStylebox("panel").GetMinimumSize`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInsideTree() || IsQueuedForDeletion()`
- `Godot.Node.GetChildren(bool)`；输入表达式：`chat.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: chat.GetChildren().OfType<Control>`
- `Godot.Node.GetParent<T>()`；输入表达式：`GetParent<VBoxContainer>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetParent<VBoxContainer>()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `Godot.StyleBox.GetMinimumSize()`；输入表达式：`_bounds.GetThemeStylebox("panel").GetMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _bounds.GetThemeStylebox("panel").GetMinimumSize().Y`
- `Godot.StyleBox.GetMinimumSize()`；输入表达式：`GetThemeStylebox("panel").GetMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetThemeStylebox("panel").GetMinimumSize().Y`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, attachmentHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _attachments.CustomMinimumSize = new(0, attachmentHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Expanded ? 36 : 68)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _editor.CustomMinimumSize = new(0, Expanded ? 36 : 68)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, headingHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _headingViewport.CustomMinimumSize = new(0, headingHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, height)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, float>)`；输入表达式：`siblings.Where(c => c != this && c != _headingViewport).Sum(c => c.GetCombinedMinimumSize().Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = siblings.Where(c => c != this && c != _headingViewport).Sum(c => c.GetCombinedMinimumSize().Y)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`chat.GetChildren().OfType<Control>().Where(c => c.Visible).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = chat.GetChildren().OfType<Control>().Where(c => c.Visible).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`chat.GetChildren().OfType<Control>().Where(c => c.Visible)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: chat.GetChildren().OfType<Control>().Where(c => c.Visible).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`siblings.Where(c => c != this && c != _headingViewport)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: siblings.Where(c => c != this && c != _headingViewport).Sum`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`chat.GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: chat.GetChildren().OfType<Control>().Where`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, _bounds.Size.Y - height - margins - otherHeight)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, _bounds.Size.Y - height - margins - otherHeight)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, height - fixedHeight)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, height - fixedHeight)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(attachmentHeight, Math.Max(0, height - fixedHeight))`；返回值紧邻使用处：`AssignmentExpressionSyntax: attachmentHeight = Math.Min(attachmentHeight, Math.Max(0, height - fixedHeight))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(headingHeight, Math.Max(0, _bounds.Size.Y - height - margins - otherHeight))`；返回值紧邻使用处：`AssignmentExpressionSyntax: headingHeight = Math.Min(headingHeight, Math.Max(0, _bounds.Size.Y - height - margins - otherHeight))`

**赋值（含属性/字段和局部值）：**

- `_attachments.CustomMinimumSize` = `new(0, attachmentHeight)`
- `_editor.CustomMinimumSize` = `new(0, Expanded ? 36 : 68)`
- `_headingViewport.CustomMinimumSize` = `new(0, headingHeight)`
- `_resizeQueued` = `false`
- `attachmentHeight` = `Math.Min(attachmentHeight, Math.Max(0, height - fixedHeight))`
- `CustomMinimumSize` = `new(0, height)`
- `headingHeight` = `Math.Min(headingHeight, Math.Max(0, _bounds.Size.Y - height - margins - otherHeight))`

<a id="symbol-356f95251eb3"></a>

## `NationalSpire.ChatComposerExpandIcon.Expanded — public bool Expanded`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c593ddef3bf0"></a>

## `NationalSpire.ChatComposerExpandIcon._Ready() — public override void _Ready()`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`

**赋值（含属性/字段和局部值）：**

- `Resized` += `QueueRedraw`

<a id="symbol-727c04eb8bed"></a>

## `NationalSpire.ChatComposerExpandIcon._Draw() — public override void _Draw()`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`；`NationalSpire.ChatComposerExpandIcon.Expanded`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(inner, outer, color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(inner, outer, color, 1.8f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([tip + new Vector2(direction * 6, 0), tip, tip + new Vector2(0, -direction * 6)], color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([tip + new Vector2(direction * 6, 0), tip, tip + new Vector2(0, -direction * 6)], color, 1.8f, true);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -direction * 6)`；返回值紧邻使用处：`BinaryExpressionSyntax: tip + new Vector2(0, -direction * 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(direction * 6, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: tip + new Vector2(direction * 6, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side * 2, -side * 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(side * 2, -side * 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side * 9, -side * 9)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(side * 9, -side * 9)`

**赋值（含属性/字段和局部值）：**
