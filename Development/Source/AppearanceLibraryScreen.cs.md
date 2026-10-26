# AppearanceLibraryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`05F876D314E0687D49F9B9A74DD81285211CA078C7F7147F5D853A7356D8AF21`。来源：[源码](../../AppearanceLibraryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-6c40b8e1641a"></a>

## `NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?) — private void BuildAppearanceLibrary(VBoxContainer parent, CareerData data, string person, Action<(PortraitDesign Design, DateSceneAssets Assets)> applied, Action<string, Action>? importPackage = null)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.OptionButton()`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AppearanceLibrary.Apply(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`](AppearanceLibrary.cs.md#symbol-35fa453dd634)；[`NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?)`](AppearanceLibrary.cs.md#symbol-e5bd2a2cd1b7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`](CareerFilePicker.cs.md#symbol-ca0ccac08c64)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`Refresh(string)`](AppearanceLibraryScreen.cs.md#symbol-6a433a7b81b7)；[`Select(int)`](AppearanceLibraryScreen.cs.md#symbol-76eb3d9afaf1)；`System.Action<T1, T2>.Invoke(T1, T2)`；`System.Action<T>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Apply(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`；`NationalSpire.AppearanceLibrary.Entry.Id`；`NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?)`；`NationalSpire.AppearanceLibrary.Package.Name`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`Refresh(string)`；`Select(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232f", "365664", 12, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232f", "365664", 12, 14));`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: preview.Texture?.Dispose()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(info)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } });`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button(importPackage == null ? "导入并保存形象包" : "导入角色 / 立绘包", () => PickNestedFile("导入角色形象包", [".zip"], path => { if (!CareerStore.IsCurrent(data)) return; if (importPackage != null) { Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred(); return; } try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "导入失败：" + e.Message; } }), 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button(importPackage == null ? "导入并保存形象包" : "导入角色 / 立绘包", () => PickNestedFile("导入角色形象包", [".zip"], path => { if (!CareerStore.IsCurrent(data)) return; if (importPackage != null) { Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred(); return; } try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "导入失败：" + e.Message; } }), 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(apply)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(apply);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("形象包库", 21, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("形象包库", 21, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(info)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(info);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(preview);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "AppearancePackages", FitToLongestItem = false, CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "AppearancePackages", FitToLongestItem = false, CustomMinimumSize = new(0, 42) }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Name = "AppearancePreview", CustomMinimumSize = new(112, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Name = "AppearancePreview", CustomMinimumSize = new(112, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(112, 154)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(112, 154)`
- `NationalSpire.AppearanceLibrary.Apply(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`；输入表达式：`AppearanceLibrary.Apply(data, person, selected)`；返回值紧邻使用处：`ArgumentSyntax: AppearanceLibrary.Apply(data, person, selected)`
- `NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?)`；输入表达式：`AppearanceLibrary.Import(data, path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AppearanceLibrary.Import(data, path)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("应用到当前角色", () => { if (selected == null || !CareerStore.IsCurrent(data)) return; try { applied(AppearanceLibrary.Apply(data, person, selected)); info.Text = "已应用 · " + selected.Name; } catch (Exception e) { info.Text = "应用失败：" + e.Message; } }, 190)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("应用到当前角色", () => { if (selected == null || !CareerStore.IsCurrent(data)) return; try { applied(AppearanceLibrary.Apply(data, person, selected)); info.Text = "已应用 · " + selected.Name; } catch (Exception e) { info.Text = "应用失败：" + e.Message; } }, 190)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(importPackage == null ? "导入并保存形象包" : "导入角色 / 立绘包", () => PickNestedFile("导入角色形象包", [".zip"], path => { if (!CareerStore.IsCurrent(data)) return; if (importPackage != null) { Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred(); return; } try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "导入失败：" + e.Message; } }), 200)`；返回值紧邻使用处：`ArgumentSyntax: Button(importPackage == null ? "导入并保存形象包" : "导入角色 / 立绘包", () => PickNestedFile("导入角色形象包", [".zip"], path => { if (!CareerStore.IsCurrent(data)) return; if (importPackage != null) { Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred(); return; } try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "导入失败：" + e.Message; } }), 200)`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；输入表达式：`PickNestedFile("导入角色形象包", [".zip"], path => { if (!CareerStore.IsCurrent(data)) return; if (importPackage != null) { Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred(); return; } try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "导入失败：" + e.Message; } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PickNestedFile("导入角色形象包", [".zip"], path => { if (!CareerStore.IsCurrent(data)) return; if (importPackage != null) { Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } }); }).CallDeferred(); return; } try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "导入失败：" + e.Message; } })`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("形象包库", 21, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("形象包库", 21, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("选择形象包后预览；导入的形象包可供其他角色直接使用。", 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("选择形象包后预览；导入的形象包可供其他角色直接使用。", 15, _muted)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10232f", "365664", 12, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10232f", "365664", 12, 14)`
- `Refresh(string)`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `Refresh(string)`；输入表达式：`Refresh(entry.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(entry.Id);`
- `Select(int)`；输入表达式：`Select((int)index)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: index => Select((int)index)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } })`；返回值紧邻使用处：`ExpressionStatementSyntax: importPackage(path, () => { try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); } catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; } });`
- `System.Action<T>.Invoke(T)`；输入表达式：`applied(AppearanceLibrary.Apply(data, person, selected))`；返回值紧邻使用处：`ExpressionStatementSyntax: applied(AppearanceLibrary.Apply(data, person, selected));`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(112, 154)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `FitToLongestItem` = `false`
- `Name` = `"AppearancePackages"`
- `Name` = `"AppearancePreview"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `apply.Disabled` = `true`
- `apply.Name` = `"AppearanceApply"`
- `choices.ItemSelected` += `index => Select((int)index)`
- `info.Text` = `"导入失败：" + e.Message`
- `info.Text` = `"已应用 · " + selected.Name`
- `info.Text` = `"应用失败：" + e.Message`
- `info.Text` = `"立绘已导入，形象库保存失败：" + e.Message`
- `preview.TreeExiting` += `() => preview.Texture?.Dispose()`

<a id="symbol-76eb3d9afaf1"></a>

## `Select(int) — void Select(int index)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?)`](AppearanceLibraryScreen.cs.md#symbol-6c40b8e1641a)；[`Refresh(string)`](AppearanceLibraryScreen.cs.md#symbol-6a433a7b81b7)

**调用：** [`NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`](AppearanceLibrary.cs.md#symbol-310593b772c6)；[`NationalSpire.AppearanceLibrary.Preview(NationalSpire.AppearanceLibrary.Package)`](AppearanceLibrary.cs.md#symbol-2cbd15385625)；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；`Godot.GodotObject.Dispose()`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`；`NationalSpire.AppearanceLibrary.Package.Outfits`；`NationalSpire.AppearanceLibrary.Preview(NationalSpire.AppearanceLibrary.Package)`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: preview.Texture?.Dispose()`
- `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`；输入表达式：`AppearanceLibrary.Load(data, entries[index - 1])`；返回值紧邻使用处：`AssignmentExpressionSyntax: selected = AppearanceLibrary.Load(data, entries[index - 1])`
- `NationalSpire.AppearanceLibrary.Preview(NationalSpire.AppearanceLibrary.Package)`；输入表达式：`AppearanceLibrary.Preview(selected)`；返回值紧邻使用处：`IsPatternExpressionSyntax: AppearanceLibrary.Preview(selected) is { } hash`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`DateSceneAssetStore.Texture(hash)`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview.Texture = DateSceneAssetStore.Texture(hash)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`selected.Outfits.Values.Sum(s => s.Count)`；返回值紧邻使用处：`InterpolationSyntax: {selected.Outfits.Values.Sum(s => s.Count)}`

**赋值（含属性/字段和局部值）：**

- `apply.Disabled` = `false`
- `apply.Disabled` = `true`
- `info.Text` = `"读取失败：" + e.Message`
- `info.Text` = `$"{selected.Outfits.Count}套服装 · {selected.Outfits.Values.Sum(s => s.Count)}张立绘 · 可供所有存档选择"`
- `preview.Texture` = `DateSceneAssetStore.Texture(hash)`
- `preview.Texture` = `null`
- `selected` = `AppearanceLibrary.Load(data, entries[index - 1])`
- `selected` = `null`

<a id="symbol-6a433a7b81b7"></a>

## `Refresh(string) — void Refresh(string id = "")`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?)`](AppearanceLibraryScreen.cs.md#symbol-6c40b8e1641a)

**调用：** [`NationalSpire.AppearanceLibrary.List()`](AppearanceLibrary.cs.md#symbol-1f96a80ecca2)；[`Select(int)`](AppearanceLibraryScreen.cs.md#symbol-76eb3d9afaf1)；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Entry.BuiltIn`；`NationalSpire.AppearanceLibrary.Entry.Id`；`NationalSpire.AppearanceLibrary.Entry.Name`；`NationalSpire.AppearanceLibrary.List()`；`Select(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem("选择已保存的形象包")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem("选择已保存的形象包");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem(entry.Name + (entry.BuiltIn ? " · 内置" : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem(entry.Name + (entry.BuiltIn ? " · 内置" : ""));`
- `Godot.OptionButton.Clear()`；输入表达式：`choices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`choices.Select(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Select(index);`
- `NationalSpire.AppearanceLibrary.List()`；输入表达式：`AppearanceLibrary.List()`；返回值紧邻使用处：`AssignmentExpressionSyntax: entries = AppearanceLibrary.List()`
- `Select(int)`；输入表达式：`Select(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(index);`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(entries, e => e.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Array.FindIndex(entries, e => e.Id == id) + 1`

**赋值（含属性/字段和局部值）：**

- `entries` = `AppearanceLibrary.List()`
