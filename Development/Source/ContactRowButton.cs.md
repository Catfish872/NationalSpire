# ContactRowButton.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`19932AEA72192057C7270767AEE415595EA743CAC1BF26D8E9379E556624707C`。来源：[源码](../../ContactRowButton.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ContactRowButton`。

字段、事件及初始值（源码原样）：

```csharp
private bool _pinned, _hidden, _selected;
private ChatContacts.Events _events;
```

<a id="symbol-dce5f4626186"></a>

## `NationalSpire.ContactRowButton.EventIndicators(NationalSpire.ChatContacts.Events) — public void EventIndicators(ChatContacts.Events events)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.ContactRowButton._events`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_events` = `events`

<a id="symbol-9183c2f045e6"></a>

## `NationalSpire.ContactRowButton.Bind(bool, bool, bool) — public void Bind(bool pinned, bool hidden, bool selected)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.ContactRowButton._hidden`；`NationalSpire.ContactRowButton._pinned`；`NationalSpire.ContactRowButton._selected`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_hidden` = `hidden`
- `_pinned` = `pinned`
- `_selected` = `selected`

<a id="symbol-44943539ef86"></a>

## `NationalSpire.ContactRowButton._Ready() — public override void _Ready()`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxFlat.StyleBoxFlat()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("294353")`；返回值紧邻使用处：`ConditionalExpressionSyntax: state is "normal" or "focus" ? Colors.Transparent : new Color("294353")`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state, new StyleBoxFlat { BgColor = state is "normal" or "focus" ? Colors.Transparent : new Color("294353") })`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state, new StyleBoxFlat { BgColor = state is "normal" or "focus" ? Colors.Transparent : new Color("294353") });`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = state is "normal" or "focus" ? Colors.Transparent : new Color("294353") }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor = state is "normal" or "focus" ? Colors.Transparent : new Color("294353") }`

**赋值（含属性/字段和局部值）：**

- `BgColor` = `state is "normal" or "focus" ? Colors.Transparent : new Color("294353")`
- `Resized` += `QueueRedraw`

<a id="symbol-4e5488f37cc5"></a>

## `NationalSpire.ContactRowButton._Draw() — public override void _Draw()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color)`](ConsumerGiftControls.cs.md#symbol-f09cb809a74c)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.ChatContacts.Events.Date`；`NationalSpire.ChatContacts.Events.DateToday`；`NationalSpire.ChatContacts.Events.Match`；`NationalSpire.ChatContacts.Events.MatchToday`；`NationalSpire.ChatContacts.Events.Wedding`；`NationalSpire.ChatContacts.Events.WeddingToday`；`NationalSpire.ContactRowButton._events`；`NationalSpire.ContactRowButton._hidden`；`NationalSpire.ContactRowButton._pinned`；`NationalSpire.ContactRowButton._selected`；`NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(0, Size.Y - 1), new(Size.X, Size.Y - 1), new Color("29465899"), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(0, Size.Y - 1), new(Size.X, Size.Y - 1), new Color("29465899"), 1, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color("7298af20"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color("7298af20"));`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture("calendar-crossed-swords"), new Rect2(x, Size.Y - 26, 17, 17), false, _events.MatchToday ? new Color("d9bd7e") : Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture("calendar-crossed-swords"), new Rect2(x, Size.Y - 26, 17, 17), false, _events.MatchToday ? new Color("d9bd7e") : Colors.White);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture("calendar-date"), new Rect2(x, Size.Y - 26, 17, 17), false, _events.DateToday ? new Color("d9bd7e") : Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture("calendar-date"), new Rect2(x, Size.Y - 26, 17, 17), false, _events.DateToday ? new Color("d9bd7e") : Colors.White);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture("contact-hidden"), new Rect2(3, y, 17, 17), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture("contact-hidden"), new Rect2(3, y, 17, 17), false);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture("contact-pin"), new Rect2(3, y, 17, 17), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture("contact-pin"), new Rect2(3, y, 17, 17), false);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("29465899")`；返回值紧邻使用处：`ArgumentSyntax: new Color("29465899")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("7298af20")`；返回值紧邻使用处：`ArgumentSyntax: new Color("7298af20")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d9bd7e")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _events.MatchToday ? new Color("d9bd7e") : Colors.White`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d9bd7e")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _events.DateToday ? new Color("d9bd7e") : Colors.White`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d9bd7e")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _events.WeddingToday ? new Color("d9bd7e") : Colors.White`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(3, y, 17, 17)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(3, y, 17, 17)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(x, Size.Y - 26, 17, 17)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(x, Size.Y - 26, 17, 17)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Size.Y - 1)`；返回值紧邻使用处：`ArgumentSyntax: new(0, Size.Y - 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X, Size.Y - 1)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X, Size.Y - 1)`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("calendar-crossed-swords")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("calendar-crossed-swords")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("calendar-date")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("calendar-date")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("contact-hidden")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("contact-hidden")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("contact-pin")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("contact-pin")`
- `NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color)`；输入表达式：`GiftRingMark.DrawDiamond(this, new Rect2(x, Size.Y - 26, 17, 17), false, _events.WeddingToday ? new Color("d9bd7e") : Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: GiftRingMark.DrawDiamond(this, new Rect2(x, Size.Y - 26, 17, 17), false, _events.WeddingToday ? new Color("d9bd7e") : Colors.White);`

**赋值（含属性/字段和局部值）：**

- `x` += `24`
- `y` += `20`
