# DateScenePortraitSettings.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`30271F6C9C2AF1940CF9763AC79CE6B7DF20D907729362AEBECE03A412F95678`。来源：[源码](../../DateScenePortraitSettings.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-9e6a2d77a042"></a>

## `NationalSpire.CareerScreen.ApplyDatePortraitPlacements() — private void ApplyDatePortraitPlacements()`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply()`](DateSceneScreen.cs.md#symbol-1f00e77adbe1)；[`Change(bool, double)`](DateScenePortraitSettings.cs.md#symbol-985446d7dd94)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-841784a6385f)；[`NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`](DateSceneCast.cs.md#symbol-80abec64fd7f)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateView)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView != null && IsInstanceValid(_dateView)`
- `NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`；输入表达式：`DatePortraitPlacement.FromAssets(p.Value.Assets)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => DatePortraitPlacement.FromAssets(p.Value.Assets)`
- `NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`；输入表达式：`_dateView.PortraitPlacements(_datePartyArt.ToDictionary(p => p.Key, p => DatePortraitPlacement.FromAssets(p.Value.Assets)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.PortraitPlacements(_datePartyArt.ToDictionary(p => p.Key, p => DatePortraitPlacement.FromAssets(p.Value.Assets)));`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`_datePartyArt.ToDictionary(p => p.Key, p => DatePortraitPlacement.FromAssets(p.Value.Assets))`；返回值紧邻使用处：`ArgumentSyntax: _datePartyArt.ToDictionary(p => p.Key, p => DatePortraitPlacement.FromAssets(p.Value.Assets))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-354a9a454cf2"></a>

## `NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData) — private void AddDatePortraitSettings(VBoxContainer box, CareerData data)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** [`Change(bool, double)`](DateScenePortraitSettings.cs.md#symbol-985446d7dd94)；[`Commit(Godot.LineEdit, bool)`](DateScenePortraitSettings.cs.md#symbol-2a982aac4aea)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSlider.HSlider()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；[`Number(Godot.HBoxContainer, string, string)`](DateScenePortraitSettings.cs.md#symbol-6e7435e9c42b)；[`SaveDirty()`](DateScenePortraitSettings.cs.md#symbol-66856ca56b04)；[`ShowValues()`](DateScenePortraitSettings.cs.md#symbol-092acdac73f7)；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `Change(bool, double)`；`Commit(Godot.LineEdit, bool)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._ink`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；`Number(Godot.HBoxContainer, string, string)`；`SaveDirty()`；`ShowValues()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Change(bool, double)`；输入表达式：`Change(false, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Change(false, 0);`
- `Change(bool, double)`；输入表达式：`Change(false, value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => Change(false, value)`
- `Change(bool, double)`；输入表达式：`Change(true, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: Change(true, 1);`
- `Change(bool, double)`；输入表达式：`Change(true, value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => Change(true, value)`
- `Commit(Godot.LineEdit, bool)`；输入表达式：`Commit(scaleNumber, true)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Commit(scaleNumber, true)`
- `Commit(Godot.LineEdit, bool)`；输入表达式：`Commit(scaleNumber, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Commit(scaleNumber, true)`
- `Commit(Godot.LineEdit, bool)`；输入表达式：`Commit(yNumber, false)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Commit(yNumber, false)`
- `Commit(Godot.LineEdit, bool)`；输入表达式：`Commit(yNumber, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Commit(yNumber, false)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`heading.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateSpriteY", MinValue = -200, MaxValue = 200, Step = 1, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateSpriteY", MinValue = -200, MaxValue = 200, Step = 1, CustomMinimumSize = new(600, 35) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("恢复所选对象默认大小与位置", () => { Change(true, 1); Change(false, 0); SaveDirty(); }, 340))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("恢复所选对象默认大小与位置", () => { Change(true, 1); Change(false, 0); SaveDirty(); }, 340));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scale)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scale);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(verticalHeading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(verticalHeading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(y)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(y);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(Text("立绘缩放", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(Text("立绘缩放", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(peopleChoice)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(peopleChoice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`verticalHeading.AddChild(Text("上下位置 · 正值向上", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: verticalHeading.AddChild(Text("上下位置 · 正值向上", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`verticalHeading.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: verticalHeading.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`peopleChoice.AddItem("所有对象")`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleChoice.AddItem("所有对象");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`peopleChoice.AddItem(CareerEngine.DisplayName(data, id))`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleChoice.AddItem(CareerEngine.DisplayName(data, id));`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DatePortraitPerson", FitToLongestItem = false, CustomMinimumSize = new(220, 36) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DatePortraitPerson", FitToLongestItem = false, CustomMinimumSize = new(220, 36) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`peopleChoice.Select(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleChoice.Select(0);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220, 36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(220, 36)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 35)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 35)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data, id)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("恢复所选对象默认大小与位置", () => { Change(true, 1); Change(false, 0); SaveDirty(); }, 340)`；返回值紧邻使用处：`ArgumentSyntax: Button("恢复所选对象默认大小与位置", () => { Change(true, 1); Change(false, 0); SaveDirty(); }, 340)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("上下位置 · 正值向上", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("上下位置 · 正值向上", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("立绘缩放", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("立绘缩放", 18, _ink)`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, keyPerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.Key(data, keyPerson)`
- `Number(Godot.HBoxContainer, string, string)`；输入表达式：`Number(heading, "DateSpriteScaleValue", "%")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(heading, "DateSpriteScaleValue", "%")`
- `Number(Godot.HBoxContainer, string, string)`；输入表达式：`Number(verticalHeading, "DateSpriteYValue", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(verticalHeading, "DateSpriteYValue", "")`
- `SaveDirty()`；输入表达式：`SaveDirty()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => SaveDirty()`
- `SaveDirty()`；输入表达式：`SaveDirty()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDirty();`
- `ShowValues()`；输入表达式：`ShowValues()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowValues();`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_datePartyArt.Keys.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _datePartyArt.Keys.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`_datePartyArt.ToDictionary(p => p.Key, p => p.Value.Assets)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _datePartyArt.ToDictionary(p => p.Key, p => p.Value.Assets)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(220, 36)`
- `CustomMinimumSize` = `new(600, 35)`
- `FitToLongestItem` = `false`
- `MaxValue` = `2.5`
- `MaxValue` = `200`
- `MinValue` = `-200`
- `MinValue` = `.25`
- `Name` = `"DatePortraitPerson"`
- `Name` = `"DateSpriteScale"`
- `Name` = `"DateSpriteY"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `.01`
- `Step` = `1`
- `_dialogOverlay.TreeExiting` += `SaveDirty`
- `peopleChoice.ItemSelected` += `index => { SaveDirty(); selected = index == 0 ? "" : people[(int)index - 1]; ShowValues(); }`
- `scale.DragEnded` += `_ => SaveDirty()`
- `scale.ValueChanged` += `value => Change(true, value)`
- `scaleNumber.FocusExited` += `() => Commit(scaleNumber, true)`
- `scaleNumber.TextSubmitted` += `_ => Commit(scaleNumber, true)`
- `selected` = `index == 0 ? "" : people[(int)index - 1]`
- `y.DragEnded` += `_ => SaveDirty()`
- `y.ValueChanged` += `value => Change(false, value)`
- `yNumber.FocusExited` += `() => Commit(yNumber, false)`
- `yNumber.TextSubmitted` += `_ => Commit(yNumber, false)`

<a id="symbol-2f44f0bb0b2f"></a>

## `CurrentWorld() — bool CurrentWorld()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Change(bool, double)`](DateScenePortraitSettings.cs.md#symbol-985446d7dd94)；[`SaveDirty()`](DateScenePortraitSettings.cs.md#symbol-66856ca56b04)

**调用：** [`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ViewData`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(ViewData, keyPerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Key(ViewData, keyPerson) == worldKey`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0a9d75e1cc2a"></a>

## `Targets() — IEnumerable<string> Targets()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Change(bool, double)`](DateScenePortraitSettings.cs.md#symbol-985446d7dd94)；[`Commit(Godot.LineEdit, bool)`](DateScenePortraitSettings.cs.md#symbol-2a982aac4aea)；[`ShowValues()`](DateScenePortraitSettings.cs.md#symbol-092acdac73f7)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6e7435e9c42b"></a>

## `Number(Godot.HBoxContainer, string, string) — LineEdit Number(HBoxContainer row, string name, string suffix)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)

**调用：** `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`input.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, CustomMinimumSize = new(86, 36), Alignment = HorizontalAlignment.Right, SelectAllOnFocus = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, CustomMinimumSize = new(86, 36), Alignment = HorizontalAlignment.Right, SelectAllOnFocus = true }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text(suffix, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text(suffix, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(input);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(86, 36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(86, 36)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(suffix, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(suffix, 18, _ink)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Right`
- `CustomMinimumSize` = `new(86, 36)`
- `Name` = `name`
- `SelectAllOnFocus` = `true`

<a id="symbol-66856ca56b04"></a>

## `SaveDirty() — void SaveDirty()`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit(Godot.LineEdit, bool)`](DateScenePortraitSettings.cs.md#symbol-2a982aac4aea)；[`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)

**调用：** [`CurrentWorld()`](DateScenePortraitSettings.cs.md#symbol-2f44f0bb0b2f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `CurrentWorld()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CurrentWorld()`；输入表达式：`CurrentWorld()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CurrentWorld()`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("立绘设置保存失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("立绘设置保存失败：" + e.Message, true);`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(data, id, settings[id])`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(data, id, settings[id]);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`dirty.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: dirty.Remove(id);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`dirty.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in dirty.ToArray()) { try { DateSceneAssetStore.Save(data, id, settings[id]); dirty.Remove(id); } catch (Exception e) { Notice("立绘设置保存失败：" + e.Message, true); } }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-092acdac73f7"></a>

## `ShowValues() — void ShowValues()`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Change(bool, double)`](DateScenePortraitSettings.cs.md#symbol-985446d7dd94)；[`Commit(Godot.LineEdit, bool)`](DateScenePortraitSettings.cs.md#symbol-2a982aac4aea)；[`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)

**调用：** `Godot.Range.SetValueNoSignal(double)`；[`NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-841784a6385f)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；[`Targets()`](DateScenePortraitSettings.cs.md#symbol-0a9d75e1cc2a)；`double.ToString(string?, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`；`NationalSpire.DatePortraitPlacement.Scale`；`NationalSpire.DatePortraitPlacement.Y`；`Targets()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`scale.SetValueNoSignal(value.Scale)`；返回值紧邻使用处：`ExpressionStatementSyntax: scale.SetValueNoSignal(value.Scale);`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`y.SetValueNoSignal(value.Y)`；返回值紧邻使用处：`ExpressionStatementSyntax: y.SetValueNoSignal(value.Y);`
- `NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`；输入表达式：`DatePortraitPlacement.FromAssets(settings[id])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => DatePortraitPlacement.FromAssets(settings[id])`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`values.All(v => v.Scale == value.Scale)`；返回值紧邻使用处：`ConditionalExpressionSyntax: values.All(v => v.Scale == value.Scale) ? (value.Scale * 100).ToString("0", CultureInfo.InvariantCulture) : ""`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`values.All(v => v.Y == value.Y)`；返回值紧邻使用处：`ConditionalExpressionSyntax: values.All(v => v.Y == value.Y) ? value.Y.ToString("0", CultureInfo.InvariantCulture) : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).ToArray()`
- `Targets()`；输入表达式：`Targets()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Targets().Select`
- `double.ToString(string?, System.IFormatProvider?)`；输入表达式：`(value.Scale * 100).ToString("0", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ConditionalExpressionSyntax: values.All(v => v.Scale == value.Scale) ? (value.Scale * 100).ToString("0", CultureInfo.InvariantCulture) : ""`
- `double.ToString(string?, System.IFormatProvider?)`；输入表达式：`value.Y.ToString("0", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ConditionalExpressionSyntax: values.All(v => v.Y == value.Y) ? value.Y.ToString("0", CultureInfo.InvariantCulture) : ""`

**赋值（含属性/字段和局部值）：**

- `scaleNumber.PlaceholderText` = `yNumber.PlaceholderText = "多值"`
- `scaleNumber.Text` = `values.All(v => v.Scale == value.Scale) ? (value.Scale * 100).ToString("0", CultureInfo.InvariantCulture) : ""`
- `yNumber.PlaceholderText` = `"多值"`
- `yNumber.Text` = `values.All(v => v.Y == value.Y) ? value.Y.ToString("0", CultureInfo.InvariantCulture) : ""`

<a id="symbol-985446d7dd94"></a>

## `Change(bool, double) — void Change(bool scaling, double value)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit(Godot.LineEdit, bool)`](DateScenePortraitSettings.cs.md#symbol-2a982aac4aea)；[`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)

**调用：** [`CurrentWorld()`](DateScenePortraitSettings.cs.md#symbol-2f44f0bb0b2f)；[`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`](DateScenePortraitSettings.cs.md#symbol-9e6a2d77a042)；[`ShowValues()`](DateScenePortraitSettings.cs.md#symbol-092acdac73f7)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Math.Round(double)`；[`Targets()`](DateScenePortraitSettings.cs.md#symbol-0a9d75e1cc2a)

**字段、属性、事件及方法组引用：** `CurrentWorld()`；`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；`NationalSpire.DateSceneAssets.SpriteScale`；`NationalSpire.DateSceneAssets.SpriteY`；`ShowValues()`；`Targets()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CurrentWorld()`；输入表达式：`CurrentWorld()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CurrentWorld()`
- `NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；输入表达式：`ApplyDatePortraitPlacements()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDatePortraitPlacements();`
- `ShowValues()`；输入表达式：`ShowValues()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowValues();`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`dirty.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: dirty.Add(id);`
- `System.Math.Round(double)`；输入表达式：`Math.Round(value * 100)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Round(value * 100) / 100`
- `System.Math.Round(double)`；输入表达式：`Math.Round(value)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Math.Round(value)`
- `Targets()`；输入表达式：`Targets()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in Targets()) { var assets = settings[id]; if (scaling) assets.SpriteScale = Math.Round(value * 100) / 100; else assets.SpriteY = -Math.Round(value); dirty.Add(id); }`

**赋值（含属性/字段和局部值）：**

- `assets.SpriteScale` = `Math.Round(value * 100) / 100`
- `assets.SpriteY` = `-Math.Round(value)`

<a id="symbol-2a982aac4aea"></a>

## `Commit(Godot.LineEdit, bool) — void Commit(LineEdit input, bool scaling)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)

**调用：** [`Change(bool, double)`](DateScenePortraitSettings.cs.md#symbol-985446d7dd94)；[`NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-841784a6385f)；[`SaveDirty()`](DateScenePortraitSettings.cs.md#symbol-66856ca56b04)；[`ShowValues()`](DateScenePortraitSettings.cs.md#symbol-092acdac73f7)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Math.Clamp(double, double, double)`；`System.Math.Round(double)`；[`Targets()`](DateScenePortraitSettings.cs.md#symbol-0a9d75e1cc2a)；`double.IsFinite(double)`；`double.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out double)`；`string.Trim()`；`string.TrimEnd(params char[]?)`

**字段、属性、事件及方法组引用：** `Change(bool, double)`；`NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`；`NationalSpire.DatePortraitPlacement.Scale`；`NationalSpire.DatePortraitPlacement.Y`；`SaveDirty()`；`ShowValues()`；`Targets()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Change(bool, double)`；输入表达式：`Change(scaling, value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Change(scaling, value);`
- `NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`；输入表达式：`DatePortraitPlacement.FromAssets(settings[id])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => DatePortraitPlacement.FromAssets(settings[id])`
- `SaveDirty()`；输入表达式：`SaveDirty()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDirty();`
- `ShowValues()`；输入表达式：`ShowValues()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowValues();`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).Any(current => value != (scaling ? current.Scale : current.Y))`；返回值紧邻使用处：`IfStatementSyntax: if (Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).Any(current => value != (scaling ? current.Scale : current.Y))) Change(scaling, value);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).Any`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(Math.Round(value), -200, 200)`；返回值紧邻使用处：`ConditionalExpressionSyntax: scaling ? Math.Clamp(Math.Round(value), 25, 250) / 100 : Math.Clamp(Math.Round(value), -200, 200)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(Math.Round(value), 25, 250)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(Math.Round(value), 25, 250) / 100`
- `System.Math.Round(double)`；输入表达式：`Math.Round(value)`；返回值紧邻使用处：`ArgumentSyntax: Math.Round(value)`
- `Targets()`；输入表达式：`Targets()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Targets().Select`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(value)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.TryParse(input.Text.Trim().TrimEnd('%', '％'), NumberStyles.Float, CultureInfo.InvariantCulture, out double value) && double.IsFinite(value)`
- `double.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out double)`；输入表达式：`double.TryParse(input.Text.Trim().TrimEnd('%', '％'), NumberStyles.Float, CultureInfo.InvariantCulture, out double value)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.TryParse(input.Text.Trim().TrimEnd('%', '％'), NumberStyles.Float, CultureInfo.InvariantCulture, out double value) && double.IsFinite(value)`
- `string.Trim()`；输入表达式：`input.Text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: input.Text.Trim().TrimEnd`
- `string.TrimEnd(params char[]?)`；输入表达式：`input.Text.Trim().TrimEnd('%', '％')`；返回值紧邻使用处：`ArgumentSyntax: input.Text.Trim().TrimEnd('%', '％')`

**赋值（含属性/字段和局部值）：**

- `value` = `scaling ? Math.Clamp(Math.Round(value), 25, 250) / 100 : Math.Clamp(Math.Round(value), -200, 200)`
