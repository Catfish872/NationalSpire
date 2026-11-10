# CalendarDayButton.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`45A21898454B3582E87C16504B98A27E68C0B7C676A4CE9BE0980BE7AD800441`。来源：[源码](../../CalendarDayButton.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CalendarDayButton`。

字段、事件及初始值（源码原样）：

```csharp
private const int CopyBottom=13;
private HBoxContainer _heading = null!;
private Label _description = null!;
private Label? _secondary;
private VBoxContainer? _copy;
private HFlowContainer? _markers;
private Tween? _hoverTween, _pressTween;
private float _hover, _press;
```

<a id="symbol-c484d4b02ad7"></a>

## `NationalSpire.CalendarDayButton.Number — public string Number`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-edf5513c4724"></a>

## `NationalSpire.CalendarDayButton.Description — public string Description`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-25953166218b"></a>

## `NationalSpire.CalendarDayButton.Markers — public List<(string Icon,string Title)> Markers`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d495928ec9ed"></a>

## `NationalSpire.CalendarDayButton.CalendarLayout — public bool CalendarLayout`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-75afc3513719"></a>

## `NationalSpire.CalendarDayButton.CalendarHeight — public int CalendarHeight`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ce4ed98d9003"></a>

## `NationalSpire.CalendarDayButton.PlanWindow — public bool PlanWindow`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eeb892566969"></a>

## `NationalSpire.CalendarDayButton.Day — public int Day`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-34051a037475"></a>

## `NationalSpire.CalendarDayButton.Preview — public bool Preview`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-98dd56dc07b6"></a>

## `NationalSpire.CalendarDayButton.SetPlanPreview(bool) — internal void SetPlanPreview(bool value)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-69912311170c)

**调用：** [`NationalSpire.CalendarDayButton.SelectDate(bool)`](CalendarDayButton.cs.md#symbol-c7e15f459308)

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton.Preview`；`NationalSpire.CalendarDayButton.SelectDate(bool)`；`NationalSpire.CalendarDayButton.Selected`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CalendarDayButton.SelectDate(bool)`；输入表达式：`SelectDate(Selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectDate(Selected);`

**赋值（含属性/字段和局部值）：**

- `Preview` = `value`

<a id="symbol-824d89cdf502"></a>

## `NationalSpire.CalendarDayButton.SecondLine — public string SecondLine`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6fd70f7be150"></a>

## `NationalSpire.CalendarDayButton.Today — public bool Today`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9ffee768bf1c"></a>

## `NationalSpire.CalendarDayButton.Selected — public bool Selected`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5a805e16ce6d"></a>

## `NationalSpire.CalendarDayButton.HasMatch — public bool HasMatch`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9e26774c7ac2"></a>

## `NationalSpire.CalendarDayButton.Registered — public bool Registered`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0549b0b56dae"></a>

## `NationalSpire.CalendarDayButton.Bond — public string? Bond`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-da30ddddf6dc"></a>

## `NationalSpire.CalendarDayButton.Wedding — public bool Wedding`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f4b0c60f8034"></a>

## `NationalSpire.CalendarDayButton.Question — public bool Question`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c7e15f459308"></a>

## `NationalSpire.CalendarDayButton.SelectDate(bool) — public void SelectDate(bool selected)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton.SetPlanPreview(bool)`](CalendarDayButton.cs.md#symbol-98dd56dc07b6)；[`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)；[`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton.CalendarLayout`；`NationalSpire.CalendarDayButton.Preview`；`NationalSpire.CalendarDayButton.Selected`；`NationalSpire.CalendarDayButton.Today`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state,CareerVisuals.Box(fill,CalendarLayout && (Selected || Preview)?"80e7db":"395365",CalendarLayout?5:8,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state,CareerVisuals.Box(fill,CalendarLayout && (Selected || Preview)?"80e7db":"395365",CalendarLayout?5:8,0));`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill,CalendarLayout && (Selected || Preview)?"80e7db":"395365",CalendarLayout?5:8,0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(fill,CalendarLayout && (Selected || Preview)?"80e7db":"395365",CalendarLayout?5:8,0)`

**赋值（含属性/字段和局部值）：**

- `Selected` = `selected`

<a id="symbol-48874665eb45"></a>

## `NationalSpire.CalendarDayButton._Ready() — public override void _Ready()`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.TextureRect.TextureRect()`；`Godot.Tween.Kill()`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.CalendarDayButton.Hover(float)`](CalendarDayButton.cs.md#symbol-bfa28fe74288)；[`NationalSpire.CalendarDayButton.Layout()`](CalendarDayButton.cs.md#symbol-e632f32accc6)；[`NationalSpire.CalendarDayButton.SelectDate(bool)`](CalendarDayButton.cs.md#symbol-c7e15f459308)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`NationalSpire.EventEmblem.EventEmblem()`；[`NationalSpire.GiftRingMark.GiftRingMark()`](ConsumerGiftControls.cs.md#symbol-6a60dc1ee43f)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.CalendarDayButton.Bond`；`NationalSpire.CalendarDayButton.CalendarHeight`；`NationalSpire.CalendarDayButton.CalendarLayout`；`NationalSpire.CalendarDayButton.CopyBottom`；`NationalSpire.CalendarDayButton.Description`；`NationalSpire.CalendarDayButton.FitCalendarCopy()`；`NationalSpire.CalendarDayButton.HasMatch`；`NationalSpire.CalendarDayButton.Hover(float)`；`NationalSpire.CalendarDayButton.Layout()`；`NationalSpire.CalendarDayButton.Markers`；`NationalSpire.CalendarDayButton.Number`；`NationalSpire.CalendarDayButton.Question`；`NationalSpire.CalendarDayButton.Registered`；`NationalSpire.CalendarDayButton.SecondLine`；`NationalSpire.CalendarDayButton.SelectDate(bool)`；`NationalSpire.CalendarDayButton.Selected`；`NationalSpire.CalendarDayButton.Today`；`NationalSpire.CalendarDayButton.Wedding`；`NationalSpire.CalendarDayButton._copy`；`NationalSpire.CalendarDayButton._description`；`NationalSpire.CalendarDayButton._heading`；`NationalSpire.CalendarDayButton._markers`；`NationalSpire.CalendarDayButton._press`；`NationalSpire.CalendarDayButton._pressTween`；`NationalSpire.CalendarDayButton._secondary`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v => { _press = v; QueueRedraw(); })`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v => { _press = v; QueueRedraw(); })`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_description.AddThemeColorOverride("font_color",Description=="训练 / 新闻" ? CareerVisuals.Muted : CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: _description.AddThemeColorOverride("font_color",Description=="训练 / 新闻" ? CareerVisuals.Muted : CareerVisuals.Ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_secondary.AddThemeColorOverride("font_color",CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _secondary.AddThemeColorOverride("font_color",CareerVisuals.Muted);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`today.AddThemeColorOverride("font_color",CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: today.AddThemeColorOverride("font_color",CareerVisuals.Teal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_copy.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: _copy.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_description.AddThemeConstantOverride("line_spacing",1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _description.AddThemeConstantOverride("line_spacing",1);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_heading.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_markers.AddThemeConstantOverride("h_separation",2)`；返回值紧邻使用处：`ExpressionStatementSyntax: _markers.AddThemeConstantOverride("h_separation",2);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_markers.AddThemeConstantOverride("v_separation",1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _markers.AddThemeConstantOverride("v_separation",1);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_secondary.AddThemeConstantOverride("line_spacing",1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _secondary.AddThemeConstantOverride("line_spacing",1);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`number.AddThemeFontOverride("font", CareerVisuals.InterfaceText(700))`；返回值紧邻使用处：`ExpressionStatementSyntax: number.AddThemeFontOverride("font", CareerVisuals.InterfaceText(700));`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_description.AddThemeFontSizeOverride("font_size", CalendarLayout ? Description=="训练 / 新闻" ? 12 : 14 : 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: _description.AddThemeFontSizeOverride("font_size", CalendarLayout ? Description=="训练 / 新闻" ? 12 : 14 : 16);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_secondary.AddThemeFontSizeOverride("font_size",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _secondary.AddThemeFontSizeOverride("font_size",12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`dot.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: dot.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`number.AddThemeFontSizeOverride("font_size", CalendarLayout ? 21 : 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: number.AddThemeFontSizeOverride("font_size", CalendarLayout ? 21 : 18);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`today.AddThemeFontSizeOverride("font_size",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: today.AddThemeFontSizeOverride("font_size",12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "CalendarRelationship", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "CalendarRelationship", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_copy.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _copy.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`date.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: date.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = CalendarLayout ? BoxContainer.AlignmentMode.Begin : BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = CalendarLayout ? BoxContainer.AlignmentMode.Begin : BoxContainer.AlignmentMode.Center }`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer {MouseFilter=MouseFilterEnum.Ignore,Alignment=FlowContainer.AlignmentMode.End}`；返回值紧邻使用处：`AssignmentExpressionSyntax: _markers = new HFlowContainer {MouseFilter=MouseFilterEnum.Ignore,Alignment=FlowContainer.AlignmentMode.End}`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "CalendarDescription", Text = Description, HorizontalAlignment = HorizontalAlignment.Center, AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _description = new Label { Name = "CalendarDescription", Text = Description, HorizontalAlignment = HorizontalAlignment.Center, AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "CalendarNumber", Text = Number, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Name = "CalendarNumber", Text = Number, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "·", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "·", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label {Name="CalendarDetail",Text=SecondLine,Visible=SecondLine.Length>0, AutowrapMode=TextServer.AutowrapMode.WordSmart,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`AssignmentExpressionSyntax: _secondary=new Label {Name="CalendarDetail",Text=SecondLine,Visible=SecondLine.Length>0, AutowrapMode=TextServer.AutowrapMode.WordSmart,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Label.Label()`；输入表达式：`new Label {Text="今天"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label {Text="今天"}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_description)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_markers)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_markers);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_copy.AddChild(_description)`；返回值紧邻使用处：`ExpressionStatementSyntax: _copy.AddChild(_description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_copy.AddChild(_secondary)`；返回值紧邻使用处：`ExpressionStatementSyntax: _copy.AddChild(_secondary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(dot)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(dot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(host)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(host);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(new EventEmblem { CustomMinimumSize = new(24, 24), SizeFlagsVertical = SizeFlags.ShrinkCenter })`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(new EventEmblem { CustomMinimumSize = new(24, 24), SizeFlagsVertical = SizeFlags.ShrinkCenter });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(new GiftRingMark { Name = "CalendarWedding", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter })`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(new GiftRingMark { Name = "CalendarWedding", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(number);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(swords)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(swords);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_heading.AddChild(today)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heading.AddChild(today);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_markers.AddChild(mark)`；返回值紧邻使用处：`ExpressionStatementSyntax: _markers.AddChild(mark);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`host.AddChild(date)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.AddChild(date);`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pressTween = CreateTween()`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Name = "CalendarMatchIcon", Texture = AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword"), CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Name = "CalendarMatchIcon", Texture = AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword"), CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = AffectionArt.Texture("calendar-date"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Texture = AffectionArt.Texture("calendar-date"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect {Texture=AffectionArt.Texture(icon),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered}`；返回值紧邻使用处：`ConditionalExpressionSyntax: icon=="wedding" ? new GiftRingMark() : new TextureRect {Texture=AffectionArt.Texture(icon),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered}`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pressTween?.Kill()`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name="CalendarCopy",GrowVertical=GrowDirection.Begin,Alignment=BoxContainer.AlignmentMode.End,MouseFilter=MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _copy=new VBoxContainer { Name="CalendarCopy",GrowVertical=GrowDirection.Begin,Alignment=BoxContainer.AlignmentMode.End,MouseFilter=MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, CalendarLayout ? CalendarHeight : 88)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, CalendarLayout ? CalendarHeight : 88)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16,16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: mark.CustomMinimumSize=new(16,16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(22, 22)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(22, 22)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(24, 24)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(24, 24)`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("calendar-date")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = AffectionArt.Texture("calendar-date")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture(icon)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture=AffectionArt.Texture(icon)`
- `NationalSpire.CalendarDayButton.Hover(float)`；输入表达式：`Hover(0)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Hover(0)`
- `NationalSpire.CalendarDayButton.Hover(float)`；输入表达式：`Hover(1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Hover(1)`
- `NationalSpire.CalendarDayButton.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.CalendarDayButton.SelectDate(bool)`；输入表达式：`SelectDate(Selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectDate(Selected);`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText(700)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.InterfaceText(700)`
- `NationalSpire.EventEmblem.EventEmblem()`；输入表达式：`new EventEmblem { CustomMinimumSize = new(24, 24), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`ArgumentSyntax: new EventEmblem { CustomMinimumSize = new(24, 24), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.EventEmblem.EventEmblem()`；输入表达式：`new EventEmblem()`；返回值紧邻使用处：`ConditionalExpressionSyntax: icon=="question" ? new EventEmblem() : icon=="wedding" ? new GiftRingMark() : new TextureRect {Texture=AffectionArt.Texture(icon),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered}`
- `NationalSpire.GiftRingMark.GiftRingMark()`；输入表达式：`new GiftRingMark { Name = "CalendarWedding", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`ArgumentSyntax: new GiftRingMark { Name = "CalendarWedding", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.GiftRingMark.GiftRingMark()`；输入表达式：`new GiftRingMark()`；返回值紧邻使用处：`ConditionalExpressionSyntax: icon=="wedding" ? new GiftRingMark() : new TextureRect {Texture=AffectionArt.Texture(icon),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered}`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct()`；返回值紧邻使用处：`ArgumentSyntax: new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Markers.Select(m=>m.Title)`；返回值紧邻使用处：`ArgumentSyntax: Markers.Select(m=>m.Title)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct())`；返回值紧邻使用处：`AssignmentExpressionSyntax: TooltipText = string.Join("\n", new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct())`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.End`
- `Alignment` = `CalendarLayout ? BoxContainer.AlignmentMode.Begin : BoxContainer.AlignmentMode.Center`
- `Alignment` = `FlowContainer.AlignmentMode.End`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `ButtonDown` += `() => { _pressTween?.Kill(); _press = 1; QueueRedraw(); _pressTween = CreateTween(); _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24); }`
- `ClipContents` = `true`
- `CustomMinimumSize` = `new(0, CalendarLayout ? CalendarHeight : 88)`
- `CustomMinimumSize` = `new(22, 22)`
- `CustomMinimumSize` = `new(24, 24)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `GrowVertical` = `GrowDirection.Begin`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `MaxLinesVisible` = `2`
- `MouseEntered` += `() => Hover(1)`
- `MouseExited` += `() => Hover(0)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"CalendarCopy"`
- `Name` = `"CalendarDescription"`
- `Name` = `"CalendarDetail"`
- `Name` = `"CalendarMatchIcon"`
- `Name` = `"CalendarNumber"`
- `Name` = `"CalendarRelationship"`
- `Name` = `"CalendarWedding"`
- `Resized` += `Layout`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Text` = `"·"`
- `Text` = `"今天"`
- `Text` = `Description`
- `Text` = `Number`
- `Text` = `SecondLine`
- `Texture` = `AffectionArt.Texture("calendar-date")`
- `Texture` = `AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword")`
- `Texture` = `AffectionArt.Texture(icon)`
- `TooltipText` = `string.Join("\n", new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct())`
- `Visible` = `SecondLine.Length>0`
- `_copy.MinimumSizeChanged` += `FitCalendarCopy`
- `_copy.OffsetBottom` = `-CopyBottom`
- `_copy.OffsetLeft` = `7`
- `_copy.OffsetRight` = `-7`
- `_copy.OffsetTop` = `39`
- `_copy` = `new VBoxContainer { Name="CalendarCopy",GrowVertical=GrowDirection.Begin,Alignment=BoxContainer.AlignmentMode.End,MouseFilter=MouseFilterEnum.Ignore }`
- `_description.HorizontalAlignment` = `HorizontalAlignment.Left`
- `_description.MaxLinesVisible` = `-1`
- `_description` = `new Label { Name = "CalendarDescription", Text = Description, HorizontalAlignment = HorizontalAlignment.Center, AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }`
- `_heading` = `new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = CalendarLayout ? BoxContainer.AlignmentMode.Begin : BoxContainer.AlignmentMode.Center }`
- `_markers` = `new HFlowContainer {MouseFilter=MouseFilterEnum.Ignore,Alignment=FlowContainer.AlignmentMode.End}`
- `_pressTween` = `CreateTween()`
- `_press` = `1`
- `_press` = `v`
- `_secondary` = `new Label {Name="CalendarDetail",Text=SecondLine,Visible=SecondLine.Length>0, AutowrapMode=TextServer.AutowrapMode.WordSmart,MouseFilter=MouseFilterEnum.Ignore}`
- `mark.CustomMinimumSize` = `new(16,16)`
- `mark.MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-e632f32accc6"></a>

## `NationalSpire.CalendarDayButton.Layout() — private void Layout()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CalendarDayButton.FitCalendarCopy()`](CalendarDayButton.cs.md#symbol-842c57e153f8)；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`string.IndexOf(string, System.StringComparison)`；`string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton.CalendarLayout`；`NationalSpire.CalendarDayButton.FitCalendarCopy()`；`NationalSpire.CalendarDayButton.Markers`；`NationalSpire.CalendarDayButton.SecondLine`；`NationalSpire.CalendarDayButton.Today`；`NationalSpire.CalendarDayButton._copy`；`NationalSpire.CalendarDayButton._description`；`NationalSpire.CalendarDayButton._heading`；`NationalSpire.CalendarDayButton._markers`；`NationalSpire.CalendarDayButton._secondary`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_heading.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _heading.GetCombinedMinimumSize().X`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`_secondary!.GetThemeFont("font")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _secondary!.GetThemeFont("font").GetStringSize`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`_secondary!.GetThemeFont("font").GetStringSize(detail.Split('\n')[0],fontSize:12)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _secondary!.GetThemeFont("font").GetStringSize(detail.Split('\n')[0],fontSize:12).X`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(4, CalendarLayout ? CustomMinimumSize.Y-55 : 47)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _description.Position = new(4, CalendarLayout ? CustomMinimumSize.Y-55 : 47)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, CalendarLayout ? 0 : 17)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _heading.Position = new(8, CalendarLayout ? 0 : 17)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8,6)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _heading.Position=new(8,6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Max(0, Size.X - 16), 26)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _heading.Size = new(Math.Max(0, Size.X - 16), 26)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Max(0, Size.X - 16), 36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _description.Size = new(Math.Max(0, Size.X - 16), 36)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,Math.Max(16,rows*18))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _markers.Size=new(width,Math.Max(16,rows*18))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,13)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _markers.Position=new(x,13)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,33)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _heading.Size=new(x,33)`
- `NationalSpire.CalendarDayButton.FitCalendarCopy()`；输入表达式：`FitCalendarCopy()`；返回值紧邻使用处：`ExpressionStatementSyntax: FitCalendarCopy();`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, Size.X - 16)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, Size.X - 16)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1,Size.X-14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(1,Size.X-14)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(18,Size.X-x-7)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(18,Size.X-x-7)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(Today ? 65 : 39, _heading.GetCombinedMinimumSize().X+14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(Today ? 65 : 39, _heading.GetCombinedMinimumSize().X+14)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(int)((width+2)/18))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(1,(int)((width+2)/18))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(16,rows*18)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(16,rows*18)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(39,16+rows*18)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _copy!.OffsetTop=Math.Max(39,16+rows*18)`
- `string.IndexOf(string, System.StringComparison)`；输入表达式：`detail.IndexOf(" · 对手：",StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =detail.IndexOf(" · 对手：",StringComparison.Ordinal)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`detail.Split('\n')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: detail.Split('\n')[0]`

**赋值（含属性/字段和局部值）：**

- `_copy!.OffsetTop` = `Math.Max(39,16+rows*18)`
- `_description.Position` = `new(4, CalendarLayout ? CustomMinimumSize.Y-55 : 47)`
- `_description.Size` = `new(Math.Max(0, Size.X - 16), 36)`
- `_heading.Position` = `new(8, CalendarLayout ? 0 : 17)`
- `_heading.Position` = `new(8,6)`
- `_heading.Size` = `new(Math.Max(0, Size.X - 16), 26)`
- `_heading.Size` = `new(x,33)`
- `_markers.Position` = `new(x,13)`
- `_markers.Size` = `new(width,Math.Max(16,rows*18))`
- `_secondary.Text` = `detail`
- `detail` = `detail[..split]+"\n"+detail[(split+3)..]`

<a id="symbol-842c57e153f8"></a>

## `NationalSpire.CalendarDayButton.FitCalendarCopy() — private void FitCalendarCopy()`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton.Layout()`](CalendarDayButton.cs.md#symbol-e632f32accc6)

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Mathf.Ceil(float)`；`Godot.Mathf.IsEqualApprox(float, float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton.CalendarHeight`；`NationalSpire.CalendarDayButton.CopyBottom`；`NationalSpire.CalendarDayButton._copy`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_copy.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _copy.GetCombinedMinimumSize().Y`
- `Godot.Mathf.Ceil(float)`；输入表达式：`Mathf.Ceil(_copy.OffsetTop+_copy.GetCombinedMinimumSize().Y+CopyBottom)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Ceil(_copy.OffsetTop+_copy.GetCombinedMinimumSize().Y+CopyBottom)`
- `Godot.Mathf.IsEqualApprox(float, float)`；输入表达式：`Mathf.IsEqualApprox(CustomMinimumSize.Y,height)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Mathf.IsEqualApprox(CustomMinimumSize.Y,height)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,height)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(CalendarHeight,Mathf.Ceil(_copy.OffsetTop+_copy.GetCombinedMinimumSize().Y+CopyBottom))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(CalendarHeight,Mathf.Ceil(_copy.OffsetTop+_copy.GetCombinedMinimumSize().Y+CopyBottom))`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0,height)`

<a id="symbol-bfa28fe74288"></a>

## `NationalSpire.CalendarDayButton.Hover(float) — private void Hover(float value)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)

**调用：** `Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.CanvasItem.QueueRedraw()`；`Godot.Node.CreateTween()`；`Godot.Tween.Kill()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton._hover`；`NationalSpire.CalendarDayButton._hoverTween`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v => { _hover = v; QueueRedraw(); })`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v => { _hover = v; QueueRedraw(); })`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _hoverTween?.Kill()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase(Tween.EaseType.Out).SetTrans`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hoverTween = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_hoverTween.TweenMethod(Callable.From<float>(v => { _hover = v; QueueRedraw(); }), _hover, value, .16)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hoverTween.TweenMethod(Callable.From<float>(v => { _hover = v; QueueRedraw(); }), _hover, value, .16);`

**赋值（含属性/字段和局部值）：**

- `_hover` = `v`
- `_hoverTween` = `CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`

<a id="symbol-6bd58719d1a6"></a>

## `NationalSpire.CalendarDayButton.Sweep(Godot.Vector2[], float) — private void Sweep(Vector2[] points, float fraction)`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton._Draw()`](CalendarDayButton.cs.md#symbol-2a43960975d8)

**调用：** `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.Vector2.DistanceTo(Godot.Vector2)`；`Godot.Vector2.Lerp(Godot.Vector2, float)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(path.ToArray(), CareerVisuals.Teal, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(path.ToArray(), CareerVisuals.Teal, 2, true);`
- `Godot.Vector2.DistanceTo(Godot.Vector2)`；输入表达式：`points[i - 1].DistanceTo(points[i])`；返回值紧邻使用处：`AssignmentExpressionSyntax: length += points[i - 1].DistanceTo(points[i])`
- `Godot.Vector2.DistanceTo(Godot.Vector2)`；输入表达式：`points[i - 1].DistanceTo(points[i])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = points[i - 1].DistanceTo(points[i])`
- `Godot.Vector2.Lerp(Godot.Vector2, float)`；输入表达式：`points[i - 1].Lerp(points[i], Math.Min(1, remaining / segment))`；返回值紧邻使用处：`ArgumentSyntax: points[i - 1].Lerp(points[i], Math.Min(1, remaining / segment))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`path.Add(points[i - 1].Lerp(points[i], Math.Min(1, remaining / segment)))`；返回值紧邻使用处：`ExpressionStatementSyntax: path.Add(points[i - 1].Lerp(points[i], Math.Min(1, remaining / segment)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Vector2> { points[0] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Vector2> { points[0] }`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`path.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: path.ToArray()`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1, remaining / segment)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(1, remaining / segment)`

**赋值（含属性/字段和局部值）：**

- `length` += `points[i - 1].DistanceTo(points[i])`
- `remaining` -= `segment`

<a id="symbol-2a43960975d8"></a>

## `NationalSpire.CalendarDayButton._Draw() — public override void _Draw()`

来源：源码第 164 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Vector2.FromAngle(float)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CalendarDayButton.Sweep(Godot.Vector2[], float)`](CalendarDayButton.cs.md#symbol-6bd58719d1a6)；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.Reverse()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton.PlanWindow`；`NationalSpire.CalendarDayButton.Preview`；`NationalSpire.CalendarDayButton.Selected`；`NationalSpire.CalendarDayButton.Sweep(Godot.Vector2[], float)`；`NationalSpire.CalendarDayButton.Today`；`NationalSpire.CalendarDayButton._hover`；`NationalSpire.CalendarDayButton._press`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(14, Size.Y - 5), new(14 + Math.Max(0, Size.X - 28) * _hover, Size.Y - 5), new Color(CareerVisuals.Teal, _hover), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(14, Size.Y - 5), new(14 + Math.Max(0, Size.X - 28) * _hover, Size.Y - 5), new Color(CareerVisuals.Teal, _hover), 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(5, 10), new(5, Size.Y - 10), CareerVisuals.Teal, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(5, 10), new(5, Size.Y - 10), CareerVisuals.Teal, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(7, Size.Y - 3), new(Size.X - 7, Size.Y - 3), CareerVisuals.Teal, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(7, Size.Y - 3), new(Size.X - 7, Size.Y - 3), CareerVisuals.Teal, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(Size.X - 5, 10), new(Size.X - 5, Size.Y - 10), CareerVisuals.Teal, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(Size.X - 5, 10), new(Size.X - 5, Size.Y - 10), CareerVisuals.Teal, 2, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(3,3,Size.X-6,Size.Y-6),new Color(CareerVisuals.Teal,.05f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(3,3,Size.X-6,Size.Y-6),new Color(CareerVisuals.Teal,.05f));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(4, 4, Size.X - 8, Size.Y - 8), new Color(CareerVisuals.Teal, .045f * (Selected ? 1 : _hover)))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(4, 4, Size.X - 8, Size.Y - 8), new Color(CareerVisuals.Teal, .045f * (Selected ? 1 : _hover)));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color(CareerVisuals.Teal, _press * .15f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color(CareerVisuals.Teal, _press * .15f));`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal, .045f * (Selected ? 1 : _hover))`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal, .045f * (Selected ? 1 : _hover))`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal, _hover)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal, _hover)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal, _press * .15f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal, _press * .15f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal,.05f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal,.05f)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(3,3,Size.X-6,Size.Y-6)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(3,3,Size.X-6,Size.Y-6)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(4, 4, Size.X - 8, Size.Y - 8)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(4, 4, Size.X - 8, Size.Y - 8)`
- `Godot.Vector2.FromAngle(float)`；输入表达式：`Vector2.FromAngle(Mathf.Pi - i * Mathf.Pi / 16)`；返回值紧邻使用处：`BinaryExpressionSyntax: Vector2.FromAngle(Mathf.Pi - i * Mathf.Pi / 16) * 5`
- `Godot.Vector2.FromAngle(float)`；输入表达式：`Vector2.FromAngle(Mathf.Pi / 2 - i * Mathf.Pi / 16)`；返回值紧邻使用处：`BinaryExpressionSyntax: Vector2.FromAngle(Mathf.Pi / 2 - i * Mathf.Pi / 16) * 5`
- `Godot.Vector2.FromAngle(float)`；输入表达式：`Vector2.FromAngle(angle)`；返回值紧邻使用处：`BinaryExpressionSyntax: Vector2.FromAngle(angle) * 5`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(10, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(10, 10) + Vector2.FromAngle(angle) * 5`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(10, Size.Y - 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi - i * Mathf.Pi / 16) * 5`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X - 10, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(Size.X - 10, 10) + Vector2.FromAngle(angle) * 5`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X - 10, Size.Y - 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(Size.X - 10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi / 2 - i * Mathf.Pi / 16) * 5`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(14 + Math.Max(0, Size.X - 28) * _hover, Size.Y - 5)`；返回值紧邻使用处：`ArgumentSyntax: new(14 + Math.Max(0, Size.X - 28) * _hover, Size.Y - 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(14, Size.Y - 5)`；返回值紧邻使用处：`ArgumentSyntax: new(14, Size.Y - 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(5, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(5, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(5, Size.Y - 10)`；返回值紧邻使用处：`ArgumentSyntax: new(5, Size.Y - 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(7, Size.Y - 3)`；返回值紧邻使用处：`ArgumentSyntax: new(7, Size.Y - 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 5, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X - 5, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 5, Size.Y - 10)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X - 5, Size.Y - 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 7, Size.Y - 3)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X - 7, Size.Y - 3)`
- `NationalSpire.CalendarDayButton.Sweep(Godot.Vector2[], float)`；输入表达式：`Sweep(bottom.ToArray(), _hover)`；返回值紧邻使用处：`ExpressionStatementSyntax: Sweep(bottom.ToArray(), _hover);`
- `NationalSpire.CalendarDayButton.Sweep(Godot.Vector2[], float)`；输入表达式：`Sweep(top.ToArray(), _hover)`；返回值紧邻使用处：`ExpressionStatementSyntax: Sweep(top.ToArray(), _hover);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`bottom.Add(new Vector2(10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi - i * Mathf.Pi / 16) * 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: bottom.Add(new Vector2(10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi - i * Mathf.Pi / 16) * 5);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`bottom.Add(new Vector2(Size.X - 10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi / 2 - i * Mathf.Pi / 16) * 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: bottom.Add(new Vector2(Size.X - 10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi / 2 - i * Mathf.Pi / 16) * 5);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`top.Add(new Vector2(10, 10) + Vector2.FromAngle(angle) * 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: top.Add(new Vector2(10, 10) + Vector2.FromAngle(angle) * 5);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`top.Add(new Vector2(Size.X - 10, 10) + Vector2.FromAngle(angle) * 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: top.Add(new Vector2(Size.X - 10, 10) + Vector2.FromAngle(angle) * 5);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Vector2>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Vector2>()`
- `System.Collections.Generic.List<T>.Reverse()`；输入表达式：`top.Reverse()`；返回值紧邻使用处：`ExpressionStatementSyntax: top.Reverse();`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`bottom.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: bottom.ToArray()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`top.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: top.ToArray()`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, Size.X - 28)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, Size.X - 28) * _hover`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7343fd9e5688"></a>

## `NationalSpire.CalendarDayButton._ExitTree() — public override void _ExitTree()`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton._hoverTween`；`NationalSpire.CalendarDayButton._pressTween`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _hoverTween?.Kill()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pressTween?.Kill()`

**赋值（含属性/字段和局部值）：**
