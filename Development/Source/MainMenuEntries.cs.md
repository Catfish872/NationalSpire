# MainMenuEntries.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D4903A7851E103E8FED8EB21B9CECC0B95BADE29AA130E92B2ACEF5C45B2D654`。来源：[源码](../../MainMenuEntries.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MainMenuEntries`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-04f3caa98ff1"></a>

## `NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button) — public static void Bind(NMainMenu menu, Button button)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopMenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](Coop/CoopRuntime.cs.md#symbol-898c6637244f)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** [`NationalSpire.CareerListCache.For(Godot.Node)`](CareerListCache.cs.md#symbol-eba9914ced8b)；[`UpdateVisibility()`](MainMenuEntries.cs.md#symbol-0a3ef1becb23)；`Godot.Callable.From(System.Action)`；`Godot.GodotObject.Connect(Godot.StringName, Godot.Callable, uint)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache.For(Godot.Node)`；`UpdateVisibility()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(UpdateVisibility)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(UpdateVisibility)`
- `Godot.GodotObject.Connect(Godot.StringName, Godot.Callable, uint)`；输入表达式：`menu.SubmenuStack.Connect(NSubmenuStack.SignalName.StackModified, Callable.From(UpdateVisibility))`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.SubmenuStack.Connect(NSubmenuStack.SignalName.StackModified, Callable.From(UpdateVisibility));`
- `NationalSpire.CareerListCache.For(Godot.Node)`；输入表达式：`CareerListCache.For(menu)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = CareerListCache.For(menu)`
- `UpdateVisibility()`；输入表达式：`UpdateVisibility()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateVisibility();`

**赋值（含属性/字段和局部值）：**

- `_` = `CareerListCache.For(menu)`
- `menu.PatchNotesScreen.VisibilityChanged` += `UpdateVisibility`

<a id="symbol-0a3ef1becb23"></a>

## `UpdateVisibility() — void UpdateVisibility()`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`](MainMenuEntries.cs.md#symbol-04f3caa98ff1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Current`；`NationalSpire.Coop.CoopScreen.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `button.Visible` = `!menu.SubmenuStack.SubmenusOpen             && !menu.PatchNotesScreen.IsOpen && CareerScreen.Current == null && Coop.CoopScreen.Current == null`
