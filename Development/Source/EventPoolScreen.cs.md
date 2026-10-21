# EventPoolScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`79172676822C9EC44A0E00C0A3F484B84FCC68ABC7148C856AF7E2587DA9DB04`。来源：[源码](../../EventPoolScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-8608563c139b"></a>

## `NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData) — private void OpenEventPoolSettings(CareerData data)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)

**调用：** [`Changed()`](EventPoolScreen.cs.md#symbol-119f7a697df0)；[`Commit()`](EventPoolScreen.cs.md#symbol-15a258d19400)；[`Daily()`](EventPoolScreen.cs.md#symbol-fcefc2b20b8b)；[`Edit()`](EventPoolScreen.cs.md#symbol-bbf42e580d6a)；[`FillList()`](EventPoolScreen.cs.md#symbol-2e2243be29fa)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-485b9c9c8acb)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`](EventPools.cs.md#symbol-2eb5f48b0ab7)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](EventPools.cs.md#symbol-5c94170cef9e)；[`NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`](EventPools.cs.md#symbol-bc809b41fa9c)；[`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`](EventPools.cs.md#symbol-a7331058425b)；[`NationalSpire.PromptLibrary.Template(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-facad1ba9cab)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；[`SelectEntry(int)`](EventPoolScreen.cs.md#symbol-96639ae36d66)；[`ShowCategories(bool)`](EventPoolScreen.cs.md#symbol-2d86237cc2e7)；[`ShowCategory()`](EventPoolScreen.cs.md#symbol-e27bbf8a9d14)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.CodeEdit.CodeEdit()`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.ItemList.GetItemMetadata(int)`；`Godot.ItemList.ItemList()`；`Godot.ItemList.Select(int, bool)`；`Godot.LineEdit.InsertTextAtCaret(string)`；`Godot.LineEdit.LineEdit()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetNodeOrNull(Godot.NodePath)`；`Godot.Node.QueueFree()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.TextEdit.InsertTextAtCaret(string, int)`；`Godot.TextEdit.TextEdit()`；`Godot.Variant.AsString()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.EventPoolEntry.EventPoolEntry(string, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `Changed()`；`Commit()`；`Daily()`；`Edit()`；`FillList()`；`NationalSpire.AiOptions.EventPoolOverrides`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`；`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；`NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`；`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`；`NationalSpire.EventPools.Snapshot.DailyCount`；`NationalSpire.EventPools.Snapshot.Random`；`NationalSpire.EventPools.Snapshot.RandomUsesDefault`；`NationalSpire.PromptLibrary.Template(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；`NationalSpire.PromptTemplate.Name`；`SelectEntry(int)`；`ShowCategories(bool)`；`ShowCategory()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Changed()`；输入表达式：`Changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed();`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Commit()`
- `Daily()`；输入表达式：`Daily()`；返回值紧邻使用处：`BinaryExpressionSyntax: pair.Key == Daily()`
- `Edit()`；输入表达式：`Edit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Edit();`
- `Edit()`；输入表达式：`Edit()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Edit()`
- `FillList()`；输入表达式：`FillList()`；返回值紧邻使用处：`ExpressionStatementSyntax: FillList();`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`pair.Value.SetPressedNoSignal(pair.Key == Daily())`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.Value.SetPressedNoSignal(pair.Key == Daily());`
- `Godot.CanvasItem.Hide()`；输入表达式：`bulkBox.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: bulkBox.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`single.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: single.Show();`
- `Godot.CodeEdit.CodeEdit()`；输入表达式：`new CodeEdit { Name = "PoolBulkText", GuttersDrawLineNumbers = true, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CodeEdit { Name = "PoolBulkText", GuttersDrawLineNumbers = true, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Color.Color(string)`；输入表达式：`new("09131df5")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new("09131df5")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "EventPoolEditor", Color = new("09131df5"), MouseFilter = MouseFilterEnum.Stop, ZIndex = 22 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "EventPoolEditor", Color = new("09131df5"), MouseFilter = MouseFilterEnum.Stop, ZIndex = 22 }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`input.AddThemeColorOverride("font_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeColorOverride("font_color", _ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`items.AddThemeColorOverride("font_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeColorOverride("font_color", _ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`items.AddThemeColorOverride("font_selected_color", _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeColorOverride("font_selected_color", _gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("h_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("h_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`form.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: form.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`items.AddThemeConstantOverride("v_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeConstantOverride("v_separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 26)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 26);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`single.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: single.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tabs.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`toolbar.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`bulk.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: bulk.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`detail.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`items.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`input.AddThemeStyleboxOverride("focus", CareerVisuals.Box("0c1c29", "70c8bd", 6, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeStyleboxOverride("focus", CareerVisuals.Box("0c1c29", "70c8bd", 6, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1c29", "355568", 6, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1c29", "355568", 6, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`items.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`items.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0e202e", "355568", 6, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0e202e", "355568", 6, 10));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`items.AddThemeStyleboxOverride(state, CareerVisuals.Box("284b57", "70c8bd", 4, 5))`；返回值紧邻使用处：`ExpressionStatementSyntax: items.AddThemeStyleboxOverride(state, CareerVisuals.Box("284b57", "70c8bd", 4, 5));`
- `Godot.Control.GrabFocus()`；输入表达式：`detail.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.ItemList.GetItemMetadata(int)`；输入表达式：`categories.GetItemMetadata((int)i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: categories.GetItemMetadata((int)i).AsString`
- `Godot.ItemList.GetItemMetadata(int)`；输入表达式：`categories.GetItemMetadata(n)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: categories.GetItemMetadata(n).AsString`
- `Godot.ItemList.ItemList()`；输入表达式：`new ItemList { Name = "PoolCategories", CustomMinimumSize = new(170, 0), SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ItemList { Name = "PoolCategories", CustomMinimumSize = new(170, 0), SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.ItemList.ItemList()`；输入表达式：`new ItemList { Name = "PoolEntries", CustomMinimumSize = new(240, 0), SizeFlagsVertical = SizeFlags.ExpandFill, MaxTextLines = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ItemList { Name = "PoolEntries", CustomMinimumSize = new(240, 0), SizeFlagsVertical = SizeFlags.ExpandFill, MaxTextLines = 2 }`
- `Godot.ItemList.Select(int, bool)`；输入表达式：`categories.Select(n)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.Select(n);`
- `Godot.LineEdit.InsertTextAtCaret(string)`；输入表达式：`title.InsertTextAtCaret(token)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.InsertTextAtCaret(token);`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "PoolEntryTitle", PlaceholderText = "标题" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "PoolEntryTitle", PlaceholderText = "标题" }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("返回提示词配置", () =>          {              if (dirty) ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回");              else shade.QueueFree();          }, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("返回提示词配置", () =>          {              if (dirty) ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回");              else shade.QueueFree();          }, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("恢复当前分类默认", () => ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>          { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; }), 220))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("恢复当前分类默认", () => ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>          { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; }), 220));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(save)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(save);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(categories)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(categories);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bulkBox.AddChild(bulk)`；返回值紧邻使用处：`ExpressionStatementSyntax: bulkBox.AddChild(bulk);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bulkBox.AddChild(bulkHelp)`；返回值紧邻使用处：`ExpressionStatementSyntax: bulkBox.AddChild(bulkHelp);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(bulkBox)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(bulkBox);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(section)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(section);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(single)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(single);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`form.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: form.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`form.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: form.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`form.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: form.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`form.AddChild(tokens)`；返回值紧邻使用处：`ExpressionStatementSyntax: form.AddChild(tokens);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(templateName)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(templateName);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(Text("事件池", 28, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(Text("事件池", 28, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`single.AddChild(form)`；返回值紧邻使用处：`ExpressionStatementSyntax: single.AddChild(form);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`single.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: single.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tokens.AddChild(Button("插入" + token, () =>          { if (titleFocused) { title.InsertTextAtCaret(token); Edit(); } else detail.InsertTextAtCaret(token); }, 110))`；返回值紧邻使用处：`ExpressionStatementSyntax: tokens.AddChild(Button("插入" + token, () =>          { if (titleFocused) { title.InsertTextAtCaret(token); Edit(); } else detail.InsertTextAtCaret(token); }, 110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("删除", () => { if (!Commit() || selected < 0) return; entries.RemoveAt(selected); Changed(); FillList(); loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }, 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("删除", () => { if (!Commit() || selected < 0) return; entries.RemoveAt(selected); Changed(); FillList(); loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }, 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("新增", () => { if (!Commit()) return; bulkMode = false; single.Show(); bulkBox.Hide(); toggle.Text = "批量编辑"; entries.Add(new("", "")); Changed(); selected = entries.Count - 1; FillList(); detail.GrabFocus(); }, 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("新增", () => { if (!Commit()) return; bulkMode = false; single.Show(); bulkBox.Hide(); toggle.Text = "批量编辑"; entries.Add(new("", "")); Changed(); selected = entries.Count - 1; FillList(); detail.GrabFocus(); }, 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(toggle);`
- `Godot.Node.GetNodeOrNull(Godot.NodePath)`；输入表达式：`_stage.GetNodeOrNull("EventPoolEditor")`；返回值紧邻使用处：`BinaryExpressionSyntax: _stage.GetNodeOrNull("EventPoolEditor") != null`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.TextEdit.InsertTextAtCaret(string, int)`；输入表达式：`detail.InsertTextAtCaret(token)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.InsertTextAtCaret(token);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PoolEntryDetail", SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "PoolEntryDetail", SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Variant.AsString()`；输入表达式：`categories.GetItemMetadata((int)i).AsString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = categories.GetItemMetadata((int)i).AsString()`
- `Godot.Variant.AsString()`；输入表达式：`categories.GetItemMetadata(n).AsString()`；返回值紧邻使用处：`BinaryExpressionSyntax: categories.GetItemMetadata(n).AsString() == category`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Visible = false, SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Visible = false, SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview.CustomMinimumSize = new(0, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(170, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(170, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(240, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(240, 0)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("保存事件池", () =>          {              if (!Commit()) return;              var previous = data.Ai.EventPoolOverrides.GetValueOrDefault(template);              try              {                  EventPools.Save(data.Ai, drafts, template); SaveAiSettings(data); dirty = false;                  var current = EventPools.Get(data.Ai);                  status.Text = $"已保存 · 随机事件 {current.Random.Length} 条 · 选手日常 {current.DailyCount} 条" + (current.RandomUsesDefault ? " · 随机事件全部为空，使用内置池" : "");              }              catch (Exception error)              {                  if (previous == null) data.Ai.EventPoolOverrides.Remove(template); else data.Ai.EventPoolOverrides[template] = previous;                  status.Text = error is ArgumentException ? error.Message : "未能保存，请检查配置文件夹的写入权限。";              }          }, 170)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("保存事件池", () =>          {              if (!Commit()) return;              var previous = data.Ai.EventPoolOverrides.GetValueOrDefault(template);              try              {                  EventPools.Save(data.Ai, drafts, template); SaveAiSettings(data); dirty = false;                  var current = EventPools.Get(data.Ai);                  status.Text = $"已保存 · 随机事件 {current.Random.Length} 条 · 选手日常 {current.DailyCount} 条" + (current.RandomUsesDefault ? " · 随机事件全部为空，使用内置池" : "");              }              catch (Exception error)              {                  if (previous == null) data.Ai.EventPoolOverrides.Remove(template); else data.Ai.EventPoolOverrides[template] = previous;                  status.Text = error is ArgumentException ? error.Message : "未能保存，请检查配置文件夹的写入权限。";              }          }, 170)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("插入" + token, () =>          { if (titleFocused) { title.InsertTextAtCaret(token); Edit(); } else detail.InsertTextAtCaret(token); }, 110)`；返回值紧邻使用处：`ArgumentSyntax: Button("插入" + token, () =>          { if (titleFocused) { title.InsertTextAtCaret(token); Edit(); } else detail.InsertTextAtCaret(token); }, 110)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("返回提示词配置", () =>          {              if (dirty) ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回");              else shade.QueueFree();          }, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("返回提示词配置", () =>          {              if (dirty) ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回");              else shade.QueueFree();          }, 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("恢复当前分类默认", () => ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>          { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; }), 220)`；返回值紧邻使用处：`ArgumentSyntax: Button("恢复当前分类默认", () => ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>          { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; }), 220)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("批量编辑", () =>          {              if (!Commit()) return; bulkMode = !bulkMode; single.Visible = !bulkMode; bulkBox.Visible = bulkMode;              toggle.Text = bulkMode ? "单条编辑" : "批量编辑";              if (bulkMode) { loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }              else FillList();          }, 145)`；返回值紧邻使用处：`AssignmentExpressionSyntax: toggle = Button("批量编辑", () =>          {              if (!Commit()) return; bulkMode = !bulkMode; single.Visible = !bulkMode; bulkBox.Visible = bulkMode;              toggle.Text = bulkMode ? "单条编辑" : "批量编辑";              if (bulkMode) { loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }              else FillList();          }, 145)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除", () => { if (!Commit() || selected < 0) return; entries.RemoveAt(selected); Changed(); FillList(); loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }, 90)`；返回值紧邻使用处：`ArgumentSyntax: Button("删除", () => { if (!Commit() || selected < 0) return; entries.RemoveAt(selected); Changed(); FillList(); loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }, 90)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("新增", () => { if (!Commit()) return; bulkMode = false; single.Show(); bulkBox.Hide(); toggle.Text = "批量编辑"; entries.Add(new("", "")); Changed(); selected = entries.Count - 1; FillList(); detail.GrabFocus(); }, 90)`；返回值紧邻使用处：`ArgumentSyntax: Button("新增", () => { if (!Commit()) return; bulkMode = false; single.Show(); bulkBox.Hide(); toggle.Text = "批量编辑"; entries.Add(new("", "")); Changed(); selected = entries.Count - 1; FillList(); detail.GrabFocus(); }, 90)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(daily ? "选手日常" : "随机事件", () =>              { if (!Commit()) { foreach (var pair in typeButtons) pair.Value.SetPressedNoSignal(pair.Key == Daily()); return; } category = daily ? "daily:观众" : "event:日常"; ShowCategories(daily); ShowCategory(); }, 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(daily ? "选手日常" : "随机事件", () =>              { if (!Commit()) { foreach (var pair in typeButtons) pair.Value.SetPressedNoSignal(pair.Key == Daily()); return; } category = daily ? "daily:观众" : "event:日常"; ShowCategories(daily); ShowCategory(); }, 150)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；输入表达式：`SaveAiSettings(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveAiSettings(data);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回");`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>          { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>          { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; })`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 21, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 21, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("事件池", 28, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("事件池", 28, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(PromptLibrary.Template(data.Ai).Name, 17, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(PromptLibrary.Template(data.Ai).Name, 17, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0c1c29", "355568", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0c1c29", "355568", 6, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0c1c29", "70c8bd", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0c1c29", "70c8bd", 6, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0e202e", "355568", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0e202e", "355568", 6, 10)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("284b57", "70c8bd", 4, 5)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("284b57", "70c8bd", 4, 5)`
- `NationalSpire.EventPoolEntry.EventPoolEntry(string, string)`；输入表达式：`new("", "")`；返回值紧邻使用处：`ArgumentSyntax: new("", "")`
- `NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`；输入表达式：`EventPools.BulkText(category, entries)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bulk.Text = EventPools.BulkText(category, entries)`
- `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；输入表达式：`EventPools.Get(data.Ai)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EventPools.Get(data.Ai)`
- `NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`；输入表达式：`EventPools.Overrides(data.Ai)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EventPools.Overrides(data.Ai)`
- `NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`；输入表达式：`EventPools.Save(data.Ai, drafts, template)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventPools.Save(data.Ai, drafts, template);`
- `NationalSpire.PromptLibrary.Template(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.Template(data.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PromptLibrary.Template(data.Ai).Name`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.TemplateId(data.Ai)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PromptLibrary.TemplateId(data.Ai)`
- `SelectEntry(int)`；输入表达式：`SelectEntry((int)i)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => SelectEntry((int)i)`
- `ShowCategories(bool)`；输入表达式：`ShowCategories(daily)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCategories(daily);`
- `ShowCategories(bool)`；输入表达式：`ShowCategories(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCategories(false);`
- `ShowCategory()`；输入表达式：`ShowCategory()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCategory();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<bool, Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<bool, Button>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`data.Ai.EventPoolOverrides.Remove(template)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Ai.EventPoolOverrides.Remove(template);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`drafts.Remove(category)`；返回值紧邻使用处：`ExpressionStatementSyntax: drafts.Remove(category);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.Ai.EventPoolOverrides.GetValueOrDefault(template)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Ai.EventPoolOverrides.GetValueOrDefault(template)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entries.Add(new("", ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.Add(new("", ""));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<EventPoolEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<EventPoolEntry>()`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`entries.RemoveAt(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.RemoveAt(selected);`

**赋值（含属性/字段和局部值）：**

- `bulk.Text` = `EventPools.BulkText(category, entries)`
- `bulk.TextChanged` += `() => { if (!loading) { dirty = true; status.Text = "批量编辑尚未保存"; } }`
- `bulkBox.Visible` = `bulkMode`
- `bulkHelp.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `bulkMode` = `!bulkMode`
- `bulkMode` = `false`
- `button.Name` = `daily ? "DailyPoolTab" : "RandomPoolTab"`
- `button.ToggleMode` = `true`
- `categories.ItemSelected` += `i =>          {              string next = categories.GetItemMetadata((int)i).AsString();              if (!Commit()) { for (int n = 0; n < categories.ItemCount; n++) if (categories.GetItemMetadata(n).AsString() == category) categories.Select(n); return; }              category = next; ShowCategory();          }`
- `category` = `daily ? "daily:观众" : "event:日常"`
- `category` = `next`
- `Color` = `new("09131df5")`
- `CustomMinimumSize` = `new(170, 0)`
- `CustomMinimumSize` = `new(240, 0)`
- `data.Ai.EventPoolOverrides[template]` = `previous`
- `detail.FocusEntered` += `() => titleFocused = false`
- `detail.TextChanged` += `Edit`
- `dirty` = `false`
- `dirty` = `true`
- `GuttersDrawLineNumbers` = `true`
- `list.ItemSelected` += `i => SelectEntry((int)i)`
- `loading` = `false`
- `loading` = `true`
- `MaxTextLines` = `2`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"EventPoolEditor"`
- `Name` = `"PoolBulkText"`
- `Name` = `"PoolCategories"`
- `Name` = `"PoolEntries"`
- `Name` = `"PoolEntryDetail"`
- `Name` = `"PoolEntryTitle"`
- `PlaceholderText` = `"标题"`
- `preview.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `preview.CustomMinimumSize` = `new(0, 48)`
- `save.Name` = `"SaveEventPools"`
- `selected` = `entries.Count - 1`
- `single.Visible` = `!bulkMode`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `status.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `status.Text` = `"批量编辑尚未保存"`
- `status.Text` = `"已恢复默认，保存后生效。"`
- `status.Text` = `$"已保存 · 随机事件 {current.Random.Length} 条 · 选手日常 {current.DailyCount} 条" + (current.RandomUsesDefault ? " · 随机事件全部为空，使用内置池" : "")`
- `status.Text` = `error is ArgumentException ? error.Message : "未能保存，请检查配置文件夹的写入权限。"`
- `templateName.HorizontalAlignment` = `HorizontalAlignment.Right`
- `templateName.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `title.FocusEntered` += `() => titleFocused = true`
- `title.TextChanged` += `_ => Edit()`
- `titleFocused` = `false`
- `titleFocused` = `true`
- `toggle.Name` = `"TogglePoolBulk"`
- `toggle.Text` = `"批量编辑"`
- `toggle.Text` = `bulkMode ? "单条编辑" : "批量编辑"`
- `toggle` = `Button("批量编辑", () =>          {              if (!Commit()) return; bulkMode = !bulkMode; single.Visible = !bulkMode; bulkBox.Visible = bulkMode;              toggle.Text = bulkMode ? "单条编辑" : "批量编辑";              if (bulkMode) { loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }              else FillList();          }, 145)`
- `typeButtons[daily]` = `button`
- `Visible` = `false`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `ZIndex` = `22`

<a id="symbol-fcefc2b20b8b"></a>

## `Daily() — bool Daily()`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Caption(NationalSpire.EventPoolEntry)`](EventPoolScreen.cs.md#symbol-cf86154a4135)；[`Edit()`](EventPoolScreen.cs.md#symbol-bbf42e580d6a)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`Preview()`](EventPoolScreen.cs.md#symbol-b782199d79a0)；[`ShowCategory()`](EventPoolScreen.cs.md#symbol-e27bbf8a9d14)

**调用：** `string.StartsWith(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string)`；输入表达式：`category.StartsWith("daily:")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => category.StartsWith("daily:")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e5eb0aeda11a"></a>

## `Heading() — void Heading()`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed()`](EventPoolScreen.cs.md#symbol-119f7a697df0)；[`ShowCategory()`](EventPoolScreen.cs.md#symbol-e27bbf8a9d14)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPoolCategory.Group`；`NationalSpire.EventPoolCategory.Id`；`NationalSpire.EventPoolCategory.Name`；`NationalSpire.EventPools.Categories`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`EventPools.Categories.Single(c => c.Id == category)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EventPools.Categories.Single(c => c.Id == category)`

**赋值（含属性/字段和局部值）：**

- `section.Text` = `definition.Group + " / " + definition.Name + $" · {entries.Count} 条"`

<a id="symbol-119f7a697df0"></a>

## `Changed() — void Changed()`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit()`](EventPoolScreen.cs.md#symbol-15a258d19400)；[`Edit()`](EventPoolScreen.cs.md#symbol-bbf42e580d6a)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** [`Heading()`](EventPoolScreen.cs.md#symbol-e5eb0aeda11a)

**字段、属性、事件及方法组引用：** `Heading()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Heading()`；输入表达式：`Heading()`；返回值紧邻使用处：`ExpressionStatementSyntax: Heading();`

**赋值（含属性/字段和局部值）：**

- `dirty` = `true`
- `drafts[category]` = `entries`
- `status.Text` = `"修改尚未保存"`

<a id="symbol-15a258d19400"></a>

## `Commit() — bool Commit()`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** [`Changed()`](EventPoolScreen.cs.md#symbol-119f7a697df0)；[`NationalSpire.EventPools.ParseBulk(string, string)`](EventPools.cs.md#symbol-4888d28a4905)；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Changed()`；`NationalSpire.EventPools.ParseBulk(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Changed()`；输入表达式：`Changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed();`
- `NationalSpire.EventPools.ParseBulk(string, string)`；输入表达式：`EventPools.ParseBulk(category, bulk.Text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EventPools.ParseBulk(category, bulk.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`parsed.SequenceEqual(entries)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !parsed.SequenceEqual(entries)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(selected, 0, entries.Count - 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: entries.Count == 0 ? -1 : Math.Clamp(selected, 0, entries.Count - 1)`

**赋值（含属性/字段和局部值）：**

- `entries` = `parsed`
- `selected` = `entries.Count == 0 ? -1 : Math.Clamp(selected, 0, entries.Count - 1)`
- `status.Text` = `error.Message`

<a id="symbol-b782199d79a0"></a>

## `Preview() — void Preview()`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Edit()`](EventPoolScreen.cs.md#symbol-bbf42e580d6a)；[`SelectEntry(int)`](EventPoolScreen.cs.md#symbol-96639ae36d66)

**调用：** [`Daily()`](EventPoolScreen.cs.md#symbol-fcefc2b20b8b)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`string.Replace(string, string?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Daily()`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Daily()`；输入表达式：`Daily()`；返回值紧邻使用处：`BinaryExpressionSyntax: Daily() && selected >= 0`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, person.ClubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: person == null ? "俱乐部" : EsportsWorld.ClubName(data, person.ClubId)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, GroupChats.Human(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: person?.PublicName ?? GroupChats.Name(data, GroupChats.Human(data))`
- `string.Replace(string, string?)`；输入表达式：`(title.Text + "\n" + detail.Text).Replace("{人}", name).Replace("{队}", team)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (title.Text + "\n" + detail.Text).Replace("{人}", name).Replace("{队}", team)`
- `string.Replace(string, string?)`；输入表达式：`(title.Text + "\n" + detail.Text).Replace("{人}", name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (title.Text + "\n" + detail.Text).Replace("{人}", name).Replace`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.FirstOrDefault(p => p.ClubId.Length > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.FirstOrDefault(p => p.ClubId.Length > 0)`

**赋值（含属性/字段和局部值）：**

- `preview.Text` = `Daily() && selected >= 0 ? "替换预览：" + (rendered.Length > 90 ? rendered[..90] + "…" : rendered) : ""`

<a id="symbol-cf86154a4135"></a>

## `Caption(NationalSpire.EventPoolEntry) — string Caption(EventPoolEntry e)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Edit()`](EventPoolScreen.cs.md#symbol-bbf42e580d6a)；[`FillList()`](EventPoolScreen.cs.md#symbol-2e2243be29fa)

**调用：** [`Daily()`](EventPoolScreen.cs.md#symbol-fcefc2b20b8b)；`string.Replace(char, char)`

**字段、属性、事件及方法组引用：** `Daily()`；`NationalSpire.EventPoolEntry.Detail`；`NationalSpire.EventPoolEntry.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Daily()`；输入表达式：`Daily()`；返回值紧邻使用处：`ConditionalExpressionSyntax: Daily() ? e.Title : e.Detail`
- `string.Replace(char, char)`；输入表达式：`s.Replace('\n', ' ')`；返回值紧邻使用处：`AssignmentExpressionSyntax: s = s.Replace('\n', ' ')`

**赋值（含属性/字段和局部值）：**

- `s` = `s.Replace('\n', ' ')`

<a id="symbol-96639ae36d66"></a>

## `SelectEntry(int) — void SelectEntry(int index)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`FillList()`](EventPoolScreen.cs.md#symbol-2e2243be29fa)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** [`Preview()`](EventPoolScreen.cs.md#symbol-b782199d79a0)

**字段、属性、事件及方法组引用：** `NationalSpire.EventPoolEntry.Detail`；`NationalSpire.EventPoolEntry.Title`；`Preview()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`

**赋值（含属性/字段和局部值）：**

- `detail.Editable` = `index >= 0`
- `detail.PlaceholderText` = `index >= 0 ? "" : "此分类暂无素材，点击新增或批量编辑添加。"`
- `detail.Text` = `index >= 0 ? entries[index].Detail : ""`
- `loading` = `false`
- `loading` = `true`
- `selected` = `index`
- `title.Editable` = `detail.Editable = index >= 0`
- `title.Text` = `index >= 0 ? entries[index].Title : ""`

<a id="symbol-2e2243be29fa"></a>

## `FillList() — void FillList()`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`ShowCategory()`](EventPoolScreen.cs.md#symbol-e27bbf8a9d14)

**调用：** [`Caption(NationalSpire.EventPoolEntry)`](EventPoolScreen.cs.md#symbol-cf86154a4135)；[`SelectEntry(int)`](EventPoolScreen.cs.md#symbol-96639ae36d66)；`Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；`Godot.ItemList.Clear()`；`Godot.ItemList.Select(int, bool)`；`Godot.ItemList.SetItemTooltip(int, string)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Caption(NationalSpire.EventPoolEntry)`；`NationalSpire.EventPoolEntry.Detail`；`SelectEntry(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Caption(NationalSpire.EventPoolEntry)`；输入表达式：`Caption(entry)`；返回值紧邻使用处：`ArgumentSyntax: Caption(entry)`
- `Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；输入表达式：`list.AddItem(Caption(entry))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = list.AddItem(Caption(entry))`
- `Godot.ItemList.Clear()`；输入表达式：`list.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Clear();`
- `Godot.ItemList.Select(int, bool)`；输入表达式：`list.Select(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Select(selected);`
- `Godot.ItemList.SetItemTooltip(int, string)`；输入表达式：`list.SetItemTooltip(i, entry.Detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.SetItemTooltip(i, entry.Detail);`
- `SelectEntry(int)`；输入表达式：`SelectEntry(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectEntry(selected);`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(selected, 0, entries.Count - 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: entries.Count == 0 ? -1 : Math.Clamp(selected, 0, entries.Count - 1)`

**赋值（含属性/字段和局部值）：**

- `selected` = `entries.Count == 0 ? -1 : Math.Clamp(selected, 0, entries.Count - 1)`

<a id="symbol-e27bbf8a9d14"></a>

## `ShowCategory() — void ShowCategory()`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** [`Daily()`](EventPoolScreen.cs.md#symbol-fcefc2b20b8b)；[`FillList()`](EventPoolScreen.cs.md#symbol-2e2243be29fa)；[`Heading()`](EventPoolScreen.cs.md#symbol-e5eb0aeda11a)；[`NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`](EventPools.cs.md#symbol-2eb5f48b0ab7)；[`NationalSpire.EventPools.Entries(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string)`](EventPools.cs.md#symbol-fd48371b9a06)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Daily()`；`FillList()`；`Heading()`；`NationalSpire.EventPoolCategory.Group`；`NationalSpire.EventPoolCategory.Id`；`NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`；`NationalSpire.EventPools.Categories`；`NationalSpire.EventPools.Entries(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Daily()`；输入表达式：`Daily()`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview.Visible = Daily()`
- `Daily()`；输入表达式：`Daily()`；返回值紧邻使用处：`ConditionalExpressionSyntax: Daily() ? "每行填写：标题｜内容。{人}替换为选手，{队}替换为俱乐部；内容换行写为 \\n。" : "每行一条故事素材；素材中的换行写为 \\n。"`
- `FillList()`；输入表达式：`FillList()`；返回值紧邻使用处：`ExpressionStatementSyntax: FillList();`
- `Heading()`；输入表达式：`Heading()`；返回值紧邻使用处：`ExpressionStatementSyntax: Heading();`
- `NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`；输入表达式：`EventPools.BulkText(category, entries)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bulk.Text = EventPools.BulkText(category, entries)`
- `NationalSpire.EventPools.Entries(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string)`；输入表达式：`EventPools.Entries(drafts, c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EventPools.Entries(drafts, c.Id).Count`
- `NationalSpire.EventPools.Entries(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string)`；输入表达式：`EventPools.Entries(drafts, category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EventPools.Entries(drafts, category).ToList`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`drafts.ContainsKey(category)`；返回值紧邻使用处：`ConditionalExpressionSyntax: drafts.ContainsKey(category) ? "当前分类使用自定义内容" : "当前分类跟随内置内容更新"`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`EventPools.Categories.Where(c => c.Group == "随机事件").All(c => EventPools.Entries(drafts, c.Id).Count == 0)`；返回值紧邻使用处：`IfStatementSyntax: if (EventPools.Categories.Where(c => c.Group == "随机事件").All(c => EventPools.Entries(drafts, c.Id).Count == 0))                  status.Text += " · 随机事件全部为空，使用内置池";`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`EventPools.Entries(drafts, category).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: entries = EventPools.Entries(drafts, category).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`EventPools.Categories.Where(c => c.Group == "随机事件")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EventPools.Categories.Where(c => c.Group == "随机事件").All`

**赋值（含属性/字段和局部值）：**

- `bulk.Text` = `EventPools.BulkText(category, entries)`
- `bulkHelp.Text` = `Daily() ? "每行填写：标题｜内容。{人}替换为选手，{队}替换为俱乐部；内容换行写为 \\n。" : "每行一条故事素材；素材中的换行写为 \\n。"`
- `entries` = `EventPools.Entries(drafts, category).ToList()`
- `loading` = `false`
- `loading` = `true`
- `preview.Visible` = `Daily()`
- `selected` = `entries.Count > 0 ? 0 : -1`
- `status.Text` += `" · 随机事件全部为空，使用内置池"`
- `status.Text` = `drafts.ContainsKey(category) ? "当前分类使用自定义内容" : "当前分类跟随内置内容更新"`
- `summary.Text` = `"分类固定，内容可自由增删。保存后用于后续抽取，已有故事和帖子保留原文。"`
- `title.Visible` = `tokens.Visible = preview.Visible = Daily()`
- `tokens.Visible` = `preview.Visible = Daily()`

<a id="symbol-2d86237cc2e7"></a>

## `ShowCategories(bool) — void ShowCategories(bool daily)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；`Godot.ItemList.Clear()`；`Godot.ItemList.Select(int, bool)`；`Godot.ItemList.SetItemDisabled(int, bool)`；`Godot.ItemList.SetItemMetadata(int, Godot.Variant)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPoolCategory.Group`；`NationalSpire.EventPoolCategory.Id`；`NationalSpire.EventPoolCategory.Name`；`NationalSpire.EventPools.Categories`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`pair.Value.SetPressedNoSignal(pair.Key == daily)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.Value.SetPressedNoSignal(pair.Key == daily);`
- `Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；输入表达式：`categories.AddItem(c.Group)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = categories.AddItem(c.Group)`
- `Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；输入表达式：`categories.AddItem(c.Name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = categories.AddItem(c.Name)`
- `Godot.ItemList.Clear()`；输入表达式：`categories.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.Clear();`
- `Godot.ItemList.Select(int, bool)`；输入表达式：`categories.Select(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.Select(i);`
- `Godot.ItemList.SetItemDisabled(int, bool)`；输入表达式：`categories.SetItemDisabled(header, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.SetItemDisabled(header, true);`
- `Godot.ItemList.SetItemMetadata(int, Godot.Variant)`；输入表达式：`categories.SetItemMetadata(header, "")`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.SetItemMetadata(header, "");`
- `Godot.ItemList.SetItemMetadata(int, Godot.Variant)`；输入表达式：`categories.SetItemMetadata(i, c.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.SetItemMetadata(i, c.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`EventPools.Categories.Where(c => (c.Group != "随机事件") == daily)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in EventPools.Categories.Where(c => (c.Group != "随机事件") == daily))              {                  if (c.Group != group) { int header = categories.AddItem(c.Group); categories.SetItemDisabled(header, true); categories.SetItemMetadata(header, ""); group = c.Group; }                  int i = categories.AddItem(c.Name); categories.SetItemMetadata(i, c.Id); if (c.Id == category) categories.Select(i);              }`

**赋值（含属性/字段和局部值）：**

- `group` = `c.Group`

<a id="symbol-bbf42e580d6a"></a>

## `Edit() — void Edit()`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** [`Caption(NationalSpire.EventPoolEntry)`](EventPoolScreen.cs.md#symbol-cf86154a4135)；[`Changed()`](EventPoolScreen.cs.md#symbol-119f7a697df0)；[`Daily()`](EventPoolScreen.cs.md#symbol-fcefc2b20b8b)；[`Preview()`](EventPoolScreen.cs.md#symbol-b782199d79a0)；`Godot.ItemList.SetItemText(int, string)`；`NationalSpire.EventPoolEntry.EventPoolEntry(string, string)`

**字段、属性、事件及方法组引用：** `Caption(NationalSpire.EventPoolEntry)`；`Changed()`；`Daily()`；`Preview()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Caption(NationalSpire.EventPoolEntry)`；输入表达式：`Caption(entries[selected])`；返回值紧邻使用处：`ArgumentSyntax: Caption(entries[selected])`
- `Changed()`；输入表达式：`Changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed();`
- `Daily()`；输入表达式：`Daily()`；返回值紧邻使用处：`ConditionalExpressionSyntax: Daily() ? title.Text : ""`
- `Godot.ItemList.SetItemText(int, string)`；输入表达式：`list.SetItemText(selected, Caption(entries[selected]))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.SetItemText(selected, Caption(entries[selected]));`
- `NationalSpire.EventPoolEntry.EventPoolEntry(string, string)`；输入表达式：`new(Daily() ? title.Text : "", detail.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: entries[selected] = new(Daily() ? title.Text : "", detail.Text)`
- `Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`

**赋值（含属性/字段和局部值）：**

- `entries[selected]` = `new(Daily() ? title.Text : "", detail.Text)`
