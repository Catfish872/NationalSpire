# PortraitPackageImportScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`299DFC3A64A4020F67C1B7C96595993566C96FB642745B1334D00DE77B381FAF`。来源：[源码](../../PortraitPackageImportScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-138e5fab7560"></a>

## `NationalSpire.CareerScreen.PortraitImportDialog(string, string, System.Action<Godot.VBoxContainer, System.Action<System.Action>>) — private void PortraitImportDialog(string title, string message, Action<VBoxContainer, Action<Action>> contents)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ImportPackage(string, System.Action?)`](DateSceneAssetScreen.cs.md#symbol-e552da41d09b)；[`NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>)`](PortraitPackageImportScreen.cs.md#symbol-af6372ed4930)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；`System.Action.Invoke()`；`System.Action<T1, T2>.Invoke(T1, T2)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._returnDialog`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; if (parent != null) { if (!IsInstanceValid(parent) || parent.IsQueuedForDeletion()) return; if (_dialogOverlay != null && _dialogOverlay != child) return; _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnTo; parent.Show(); } next?.Invoke(); }).CallDeferred()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Callable.From(() => { if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; if (parent != null) { if (!IsInstanceValid(parent) || parent.IsQueuedForDeletion()) return; if (_dialogOverlay != null && _dialogOverlay != child) return; _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnTo; parent.Show(); } next?.Invoke(); }).CallDeferred()`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; if (parent != null) { if (!IsInstanceValid(parent) || parent.IsQueuedForDeletion()) return; if (_dialogOverlay != null && _dialogOverlay != child) return; _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnTo; parent.Show(); } next?.Invoke(); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; if (parent != null) { if (!IsInstanceValid(parent) || parent.IsQueuedForDeletion()) return; if (_dialogOverlay != null && _dialogOverlay != child) return; _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnTo; parent.Show(); } next?.Invoke(); }).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: parent?.Hide()`
- `Godot.CanvasItem.Show()`；输入表达式：`parent.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.Show();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(parent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(parent)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(this) || IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`parent.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(parent) || parent.IsQueuedForDeletion()`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(title, message, () => true, "返回", box => contents(box, action => { next = action; _cancelDialog?.Invoke(); }), showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(title, message, () => true, "返回", box => contents(box, action => { next = action; _cancelDialog?.Invoke(); }), showCancel: false);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: next?.Invoke()`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`contents(box, action => { next = action; _cancelDialog?.Invoke(); })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: box => contents(box, action => { next = action; _cancelDialog?.Invoke(); })`

**赋值（含属性/字段和局部值）：**

- `_cancelDialog` = `_returnDialog = null`
- `_cancelDialog` = `cancel`
- `_dialogOverlay` = `null`
- `_dialogOverlay` = `parent`
- `_returnDialog` = `null`
- `_returnDialog` = `returnTo`
- `child.TreeExiting` += `() => Callable.From(() => { if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; if (parent != null) { if (!IsInstanceValid(parent) || parent.IsQueuedForDeletion()) return; if (_dialogOverlay != null && _dialogOverlay != child) return; _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnTo; parent.Show(); } next?.Invoke(); }).CallDeferred()`
- `next` = `action`

<a id="symbol-af6372ed4930"></a>

## `NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>) — private void ConfirmPortraitEmotions(CareerData data, PortraitPackageImport.Plan plan, PortraitDesign design, Action<HashSet<string>> apply)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ImportSprites()`](DateSceneAssetScreen.cs.md#symbol-6a30a901510f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)

**调用：** [`Choose(bool)`](PortraitPackageImportScreen.cs.md#symbol-2130593bf5a8)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.PortraitImportDialog(string, string, System.Action<Godot.VBoxContainer, System.Action<System.Action>>)`](PortraitPackageImportScreen.cs.md#symbol-138e5fab7560)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-c60dfaaef123)；`System.Action<T>.Invoke(T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.Path.GetFileName(string?)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `Choose(bool)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.PortraitImportDialog(string, string, System.Action<Godot.VBoxContainer, System.Action<System.Action>>)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitPackageImport.Sprite.Emotion`；`NationalSpire.PortraitPackageImport.Sprite.File`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choose(bool)`；输入表达式：`Choose(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Choose(false)`
- `Choose(bool)`；输入表达式：`Choose(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Choose(true)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rows.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(confirm)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(confirm);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rows.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(rows)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(rows);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Min(360, unknown.Length * 66))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, Math.Min(360, unknown.Length * 66))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(180, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(380, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: name.CustomMinimumSize = new(380, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(860, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(860, 0)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { CustomMinimumSize = new(0, Math.Min(360, unknown.Length * 66)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { CustomMinimumSize = new(0, Math.Min(360, unknown.Length * 66)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消导入", () => { }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("取消导入", () => { }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("新建并导入", () => { }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("新建并导入", () => { }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("确认导入", () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); }), 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: confirm = Button("确认导入", () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); }), 180)`
- `NationalSpire.CareerScreen.PortraitImportDialog(string, string, System.Action<Godot.VBoxContainer, System.Action<System.Action>>)`；输入表达式：`PortraitImportDialog("确认新情绪差分", "以下PNG对应新的或尚未启用的情绪ID。请逐项选择，再确认导入。", (box, finish) => { box.Name = "PortraitUnknownEmotions"; box.CustomMinimumSize = new(860, 0); var choices = new Dictionary<string, bool>(); var scroll = new BroadcastScroll { CustomMinimumSize = new(0, Math.Min(360, unknown.Length * 66)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; rows.AddThemeConstantOverride("separation", 12); scroll.AddChild(rows); Button confirm = null!; for (int i = 0; i < unknown.Length; i++) { var item = unknown[i]; var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); rows.AddChild(row); var name = Text(Path.GetFileName(item.File) + " → " + item.Emotion, 18, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.CustomMinimumSize = new(380, 48); name.ClipText = true; name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; name.TooltipText = item.File; row.AddChild(name); var skip = Button("取消导入", () => { }, 180); skip.Name = "PortraitSkip_" + i; var accept = Button("新建并导入", () => { }, 180); accept.Name = "PortraitAccept_" + i; foreach (var button in new[] { skip, accept }) { button.CustomMinimumSize = new(180, 48); button.ToggleMode = true; row.AddChild(button); } void Choose(bool value) { choices[item.File] = value; skip.SetPressedNoSignal(!value); accept.SetPressedNoSignal(value); skip.Modulate = value ? Colors.White : CareerVisuals.Teal; accept.Modulate = value ? CareerVisuals.Teal : Colors.White; confirm.Disabled = choices.Count != unknown.Length; } skip.Pressed += () => Choose(false); accept.Pressed += () => Choose(true); } confirm = Button("确认导入", () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); }), 180); confirm.Name = "PortraitConfirmImport"; confirm.Disabled = true; confirm.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; box.AddChild(confirm); })`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitImportDialog("确认新情绪差分", "以下PNG对应新的或尚未启用的情绪ID。请逐项选择，再确认导入。", (box, finish) => { box.Name = "PortraitUnknownEmotions"; box.CustomMinimumSize = new(860, 0); var choices = new Dictionary<string, bool>(); var scroll = new BroadcastScroll { CustomMinimumSize = new(0, Math.Min(360, unknown.Length * 66)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; rows.AddThemeConstantOverride("separation", 12); scroll.AddChild(rows); Button confirm = null!; for (int i = 0; i < unknown.Length; i++) { var item = unknown[i]; var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); rows.AddChild(row); var name = Text(Path.GetFileName(item.File) + " → " + item.Emotion, 18, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.CustomMinimumSize = new(380, 48); name.ClipText = true; name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; name.TooltipText = item.File; row.AddChild(name); var skip = Button("取消导入", () => { }, 180); skip.Name = "PortraitSkip_" + i; var accept = Button("新建并导入", () => { }, 180); accept.Name = "PortraitAccept_" + i; foreach (var button in new[] { skip, accept }) { button.CustomMinimumSize = new(180, 48); button.ToggleMode = true; row.AddChild(button); } void Choose(bool value) { choices[item.File] = value; skip.SetPressedNoSignal(!value); accept.SetPressedNoSignal(value); skip.Modulate = value ? Colors.White : CareerVisuals.Teal; accept.Modulate = value ? CareerVisuals.Teal : Colors.White; confirm.Disabled = choices.Count != unknown.Length; } skip.Pressed += () => Choose(false); accept.Pressed += () => Choose(true); } confirm = Button("确认导入", () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); }), 180); confirm.Name = "PortraitConfirmImport"; confirm.Disabled = true; confirm.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; box.AddChild(confirm); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(Path.GetFileName(item.File) + " → " + item.Emotion, 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(Path.GetFileName(item.File) + " → " + item.Emotion, 18, _ink)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal));`
- `NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`；输入表达式：`plan.Unknown(design)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = plan.Unknown(design)`
- `System.Action<T>.Invoke(T)`；输入表达式：`apply([])`；返回值紧邻使用处：`ExpressionStatementSyntax: apply([]);`
- `System.Action<T>.Invoke(T)`；输入表达式：`apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal))`；返回值紧邻使用处：`ExpressionStatementSyntax: apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal));`
- `System.Action<T>.Invoke(T)`；输入表达式：`finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); })`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, bool>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, bool>()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`choices.Where(p => p.Value).Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.Where(p => p.Value).Select(p => p.Key).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`ArgumentSyntax: choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`choices.Where(p => p.Value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.Where(p => p.Value).Select`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(item.File)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFileName(item.File) + " → "`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(360, unknown.Length * 66)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(360, unknown.Length * 66)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, Math.Min(360, unknown.Length * 66))`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `accept.Name` = `"PortraitAccept_" + i`
- `accept.Pressed` += `() => Choose(true)`
- `box.CustomMinimumSize` = `new(860, 0)`
- `box.Name` = `"PortraitUnknownEmotions"`
- `button.CustomMinimumSize` = `new(180, 48)`
- `button.ToggleMode` = `true`
- `confirm.Disabled` = `true`
- `confirm.Name` = `"PortraitConfirmImport"`
- `confirm.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `confirm` = `Button("确认导入", () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); }), 180)`
- `name.ClipText` = `true`
- `name.CustomMinimumSize` = `new(380, 48)`
- `name.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `name.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `name.TooltipText` = `item.File`
- `skip.Name` = `"PortraitSkip_" + i`
- `skip.Pressed` += `() => Choose(false)`

<a id="symbol-2130593bf5a8"></a>

## `Choose(bool) — void Choose(bool value)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>)`](PortraitPackageImportScreen.cs.md#symbol-af6372ed4930)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.PortraitPackageImport.Sprite.File`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`accept.SetPressedNoSignal(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.SetPressedNoSignal(value);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`skip.SetPressedNoSignal(!value)`；返回值紧邻使用处：`ExpressionStatementSyntax: skip.SetPressedNoSignal(!value);`

**赋值（含属性/字段和局部值）：**

- `accept.Modulate` = `value ? CareerVisuals.Teal : Colors.White`
- `choices[item.File]` = `value`
- `confirm.Disabled` = `choices.Count != unknown.Length`
- `skip.Modulate` = `value ? Colors.White : CareerVisuals.Teal`
