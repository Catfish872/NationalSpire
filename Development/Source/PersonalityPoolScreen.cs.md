# PersonalityPoolScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`014B6D3D530D5D4D8502854660D1FD12D51BF246339261A92C21455395C2E9E1`。来源：[源码](../../PersonalityPoolScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-13f6866c9d3b"></a>

## `NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?) — private void OpenPersonalityPool(CareerData data, PersonalityPool? initial = null, Action<PersonalityPool>? accepted = null)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-485b9c9c8acb)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.PersonalityPools.Import(string)`](PersonalityPools.cs.md#symbol-a524890425ed)；[`NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`](PersonalityPools.cs.md#symbol-80fcf785b385)；[`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)；[`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)；[`Replace(NationalSpire.PersonalityPool)`](PersonalityPoolScreen.cs.md#symbol-c5dc06d4fb96)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PersonalityPool`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._returnDialog`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.PersonalityPools.Import(string)`；`NationalSpire.PersonalityPools.Json`；`NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`；`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；`Rebuild()`；`Replace(NationalSpire.PersonalityPool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred()`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`parent!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: parent!.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`parent.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.Show();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`fields.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`toolbar.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddThemeConstantOverride("separation", 12);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(parent)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(parent) && !parent.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`parent.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !parent.IsQueuedForDeletion()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(bulk)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(bulk);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(fields);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("批量分类编辑", () =>             {                 var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;                 TextEdit bulk = null!; Label error = null!;                 ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });                 _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();             }, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("批量分类编辑", () =>             {                 var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;                 TextEdit bulk = null!; Label error = null!;                 ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });                 _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();             }, 180));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 460)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 460)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(880, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(880, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(880, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: content.CustomMinimumSize = new(880, 0)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { CustomMinimumSize = new(0, 460), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { CustomMinimumSize = new(0, 460), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("批量分类编辑", () =>             {                 var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;                 TextEdit bulk = null!; Label error = null!;                 ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });                 _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();             }, 180)`；返回值紧邻使用处：`ArgumentSyntax: Button("批量分类编辑", () =>             {                 var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;                 TextEdit bulk = null!; Label error = null!;                 ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });                 _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();             }, 180)`
- `NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；输入表达式：`SaveAiSettings(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveAiSettings(data);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("性格池", "类别可指定男性、女性或中性（男女均可）。人物同时使用类别与具体性格两份提示词；已保存的人物保留自己的版本。", () =>         {             try             {                 PersonalityPools.Validate(draft);                 if (accepted != null) { accepted(Coop.CoopJson.Copy(draft)); return true; }                 var old = data.Ai.PersonalityPool; data.Ai.PersonalityPool = Coop.CoopJson.Copy(draft);                 try { SaveAiSettings(data); } catch { data.Ai.PersonalityPool = old; throw; }                 return true;             }             catch (Exception e) { status.Text = e.Message; return false; }         }, "保存性格池", box =>         {             box.CustomMinimumSize = new(880, 0);             var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); box.AddChild(toolbar);             toolbar.AddChild(Button("批量分类编辑", () =>             {                 var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;                 TextEdit bulk = null!; Label error = null!;                 ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });                 _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();             }, 180));             var scroll = new BroadcastScroll { CustomMinimumSize = new(0, 460), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);             fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; fields.AddThemeConstantOverride("separation", 10); scroll.AddChild(fields);             status = Text("新建生涯时可调整两级生成比例。", 16, _muted); box.AddChild(status); Rebuild();         })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("性格池", "类别可指定男性、女性或中性（男女均可）。人物同时使用类别与具体性格两份提示词；已保存的人物保留自己的版本。", () =>         {             try             {                 PersonalityPools.Validate(draft);                 if (accepted != null) { accepted(Coop.CoopJson.Copy(draft)); return true; }                 var old = data.Ai.PersonalityPool; data.Ai.PersonalityPool = Coop.CoopJson.Copy(draft);                 try { SaveAiSettings(data); } catch { data.Ai.PersonalityPool = old; throw; }                 return true;             }             catch (Exception e) { status.Text = e.Message; return false; }         }, "保存性格池", box =>         {             box.CustomMinimumSize = new(880, 0);             var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); box.AddChild(toolbar);             toolbar.AddChild(Button("批量分类编辑", () =>             {                 var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;                 TextEdit bulk = null!; Label error = null!;                 ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>                 { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>                 {                     content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);                     error = Text("", 16, _muted); content.AddChild(error);                 });                 _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();             }, 180));             var scroll = new BroadcastScroll { CustomMinimumSize = new(0, 460), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);             fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; fields.AddThemeConstantOverride("separation", 10); scroll.AddChild(fields);             status = Text("新建生涯时可调整两级生成比例。", 16, _muted); box.AddChild(status); Rebuild();         });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("新建生涯时可调整两级生成比例。", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("新建生涯时可调整两级生成比例。", 16, _muted)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(draft)`；返回值紧邻使用处：`ArgumentSyntax: Coop.CoopJson.Copy(draft)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(draft)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai.PersonalityPool = Coop.CoopJson.Copy(draft)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(initial)`；返回值紧邻使用处：`ConditionalExpressionSyntax: initial == null ? PersonalityPools.Read(data.Ai) : Coop.CoopJson.Copy(initial)`
- `NationalSpire.PersonalityPools.Import(string)`；输入表达式：`PersonalityPools.Import(bulk.Text)`；返回值紧邻使用处：`ArgumentSyntax: PersonalityPools.Import(bulk.Text)`
- `NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`；输入表达式：`PersonalityPools.Read(data.Ai)`；返回值紧邻使用处：`ConditionalExpressionSyntax: initial == null ? PersonalityPools.Read(data.Ai) : Coop.CoopJson.Copy(initial)`
- `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；输入表达式：`PersonalityPools.Validate(draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityPools.Validate(draft);`
- `Rebuild()`；输入表达式：`Rebuild()`；返回值紧邻使用处：`ExpressionStatementSyntax: Rebuild();`
- `Replace(NationalSpire.PersonalityPool)`；输入表达式：`Replace(PersonalityPools.Import(bulk.Text))`；返回值紧邻使用处：`ExpressionStatementSyntax: Replace(PersonalityPools.Import(bulk.Text));`
- `System.Action<T>.Invoke(T)`；输入表达式：`accepted(Coop.CoopJson.Copy(draft))`；返回值紧邻使用处：`ExpressionStatementSyntax: accepted(Coop.CoopJson.Copy(draft));`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(draft, PersonalityPools.Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = JsonSerializer.Serialize(draft, PersonalityPools.Json)`

**赋值（含属性/字段和局部值）：**

- `_cancelDialog` = `cancel`
- `_cancelDialog` = `null`
- `_dialogOverlay!.TreeExiting` += `() => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred()`
- `_dialogOverlay` = `null`
- `_dialogOverlay` = `parent`
- `_returnDialog` = `returnDialog`
- `box.CustomMinimumSize` = `new(880, 0)`
- `bulk` = `new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }`
- `content.CustomMinimumSize` = `new(880, 0)`
- `CustomMinimumSize` = `new(0, 460)`
- `data.Ai.PersonalityPool` = `Coop.CoopJson.Copy(draft)`
- `data.Ai.PersonalityPool` = `old`
- `error.Text` = `e.Message`
- `error` = `Text("", 16, _muted)`
- `fields` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"PersonalityPoolBulk"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `status.Text` = `e.Message`
- `status` = `Text("新建生涯时可调整两级生成比例。", 16, _muted)`
- `Text` = `JsonSerializer.Serialize(draft, PersonalityPools.Json)`

<a id="symbol-5fbd99cba947"></a>

## `Rebuild() — void Rebuild()`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)；[`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)；[`Replace(NationalSpire.PersonalityPool)`](PersonalityPoolScreen.cs.md#symbol-c5dc06d4fb96)

**调用：** [`Line(string, string, System.Action<string>, string)`](PersonalityPoolScreen.cs.md#symbol-dc43ee9109c6)；[`Memo(string, string, System.Action<string>, string)`](PersonalityPoolScreen.cs.md#symbol-4dd5c03478ac)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`Options(Godot.Node, string, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](PersonalityPoolScreen.cs.md#symbol-e532b141db9d)；[`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)；[`Weight(string, double, System.Action<double>)`](PersonalityPoolScreen.cs.md#symbol-43db0c5144bf)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PersonalityCategory.PersonalityCategory()`；`NationalSpire.PersonalityStyle.PersonalityStyle()`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Line(string, string, System.Action<string>, string)`；`Memo(string, string, System.Action<string>, string)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Id`；`NationalSpire.PersonalityCategory.Name`；`NationalSpire.PersonalityCategory.Prompt`；`NationalSpire.PersonalityCategory.Styles`；`NationalSpire.PersonalityCategory.Weight`；`NationalSpire.PersonalityPool.Categories`；`NationalSpire.PersonalityPools.Genders`；`NationalSpire.PersonalityPools.NeutralGender`；`NationalSpire.PersonalityStyle.Id`；`NationalSpire.PersonalityStyle.Name`；`NationalSpire.PersonalityStyle.Prompt`；`NationalSpire.PersonalityStyle.Weight`；`Options(Godot.Node, string, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；`Rebuild()`；`Weight(string, double, System.Action<double>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`categories.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`gender.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: gender.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`styles.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: styles.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`categories.AddChild(Button("新增类别", () => { draft.Categories.Add(new() { Styles = [new()] }); categoryIndex = draft.Categories.Count - 1; styleIndex = 0; Rebuild(); }, 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddChild(Button("新增类别", () => { draft.Categories.Add(new() { Styles = [new()] }); categoryIndex = draft.Categories.Count - 1; styleIndex = 0; Rebuild(); }, 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`categories.AddChild(deleteCategory)`；返回值紧邻使用处：`ExpressionStatementSyntax: categories.AddChild(deleteCategory);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(categories)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(categories);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(gender)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(gender);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(styles)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(styles);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`gender.AddChild(Text("适用性别", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: gender.AddChild(Text("适用性别", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`styles.AddChild(Button("新增性格", () => { c.Styles.Add(new()); styleIndex = c.Styles.Count - 1; Rebuild(); }, 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: styles.AddChild(Button("新增性格", () => { c.Styles.Add(new()); styleIndex = c.Styles.Count - 1; Rebuild(); }, 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`styles.AddChild(deleteStyle)`；返回值紧邻使用处：`ExpressionStatementSyntax: styles.AddChild(deleteStyle);`
- `Line(string, string, System.Action<string>, string)`；输入表达式：`Line("类别 ID", c.Id, s => c.Id = s, "PersonalityCategoryId")`；返回值紧邻使用处：`ExpressionStatementSyntax: Line("类别 ID", c.Id, s => c.Id = s, "PersonalityCategoryId");`
- `Line(string, string, System.Action<string>, string)`；输入表达式：`Line("类别名称", c.Name, s => c.Name = s, "PersonalityCategoryName")`；返回值紧邻使用处：`ExpressionStatementSyntax: Line("类别名称", c.Name, s => c.Name = s, "PersonalityCategoryName");`
- `Line(string, string, System.Action<string>, string)`；输入表达式：`Line("性格 ID", s.Id, v => s.Id = v, "PersonalityStyleId")`；返回值紧邻使用处：`ExpressionStatementSyntax: Line("性格 ID", s.Id, v => s.Id = v, "PersonalityStyleId");`
- `Line(string, string, System.Action<string>, string)`；输入表达式：`Line("性格名称", s.Name, v => s.Name = v, "PersonalityStyleName")`；返回值紧邻使用处：`ExpressionStatementSyntax: Line("性格名称", s.Name, v => s.Name = v, "PersonalityStyleName");`
- `Memo(string, string, System.Action<string>, string)`；输入表达式：`Memo("具体性格提示词", s.Prompt, v => s.Prompt = v, "PersonalityStylePrompt")`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo("具体性格提示词", s.Prompt, v => s.Prompt = v, "PersonalityStylePrompt");`
- `Memo(string, string, System.Action<string>, string)`；输入表达式：`Memo("类别共同提示词", c.Prompt, s => c.Prompt = s, "PersonalityCategoryPrompt")`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo("类别共同提示词", c.Prompt, s => c.Prompt = s, "PersonalityCategoryPrompt");`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除类别", () => { draft.Categories.RemoveAt(categoryIndex); Rebuild(); }, 130)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("删除类别", () => { draft.Categories.RemoveAt(categoryIndex); Rebuild(); }, 130)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除性格", () => { c.Styles.RemoveAt(styleIndex); Rebuild(); }, 130)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("删除性格", () => { c.Styles.RemoveAt(styleIndex); Rebuild(); }, 130)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("新增类别", () => { draft.Categories.Add(new() { Styles = [new()] }); categoryIndex = draft.Categories.Count - 1; styleIndex = 0; Rebuild(); }, 130)`；返回值紧邻使用处：`ArgumentSyntax: Button("新增类别", () => { draft.Categories.Add(new() { Styles = [new()] }); categoryIndex = draft.Categories.Count - 1; styleIndex = 0; Rebuild(); }, 130)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("新增性格", () => { c.Styles.Add(new()); styleIndex = c.Styles.Count - 1; Rebuild(); }, 130)`；返回值紧邻使用处：`ArgumentSyntax: Button("新增性格", () => { c.Styles.Add(new()); styleIndex = c.Styles.Count - 1; Rebuild(); }, 130)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("适用性别", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("适用性别", 17, _muted)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(fields);`
- `NationalSpire.PersonalityCategory.PersonalityCategory()`；输入表达式：`new() { Styles = [new()] }`；返回值紧邻使用处：`ArgumentSyntax: new() { Styles = [new()] }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new()`；返回值紧邻使用处：`ExpressionElementSyntax: new()`
- `Options(Godot.Node, string, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；输入表达式：`Options(categories, "PersonalityCategory", draft.Categories.Select(x => x.Name), categoryIndex, n => { categoryIndex = n; styleIndex = 0; Rebuild(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Options(categories, "PersonalityCategory", draft.Categories.Select(x => x.Name), categoryIndex, n => { categoryIndex = n; styleIndex = 0; Rebuild(); });`
- `Options(Godot.Node, string, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；输入表达式：`Options(gender, "PersonalityCategoryGender", PersonalityPools.Genders.Select(g => g == PersonalityPools.NeutralGender ? "中性（男女均可）" : g),                 Array.IndexOf(PersonalityPools.Genders, c.Gender), n => c.Gender = PersonalityPools.Genders[n])`；返回值紧邻使用处：`ExpressionStatementSyntax: Options(gender, "PersonalityCategoryGender", PersonalityPools.Genders.Select(g => g == PersonalityPools.NeutralGender ? "中性（男女均可）" : g),                 Array.IndexOf(PersonalityPools.Genders, c.Gender), n => c.Gender = PersonalityPools.Genders[n]);`
- `Options(Godot.Node, string, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；输入表达式：`Options(styles, "PersonalityStyle", c.Styles.Select(s => s.Name), styleIndex, n => { styleIndex = n; Rebuild(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Options(styles, "PersonalityStyle", c.Styles.Select(s => s.Name), styleIndex, n => { styleIndex = n; Rebuild(); });`
- `Rebuild()`；输入表达式：`Rebuild()`；返回值紧邻使用处：`ExpressionStatementSyntax: Rebuild();`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(PersonalityPools.Genders, c.Gender)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(PersonalityPools.Genders, c.Gender)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Styles.Select(s => s.Name)`；返回值紧邻使用处：`ArgumentSyntax: c.Styles.Select(s => s.Name)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`draft.Categories.Select(x => x.Name)`；返回值紧邻使用处：`ArgumentSyntax: draft.Categories.Select(x => x.Name)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PersonalityPools.Genders.Select(g => g == PersonalityPools.NeutralGender ? "中性（男女均可）" : g)`；返回值紧邻使用处：`ArgumentSyntax: PersonalityPools.Genders.Select(g => g == PersonalityPools.NeutralGender ? "中性（男女均可）" : g)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Styles.Add(new())`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Styles.Add(new());`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`draft.Categories.Add(new() { Styles = [new()] })`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Categories.Add(new() { Styles = [new()] });`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`c.Styles.RemoveAt(styleIndex)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Styles.RemoveAt(styleIndex);`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`draft.Categories.RemoveAt(categoryIndex)`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Categories.RemoveAt(categoryIndex);`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(categoryIndex, 0, draft.Categories.Count - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: categoryIndex = Math.Clamp(categoryIndex, 0, draft.Categories.Count - 1)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(styleIndex, 0, c.Styles.Count - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: styleIndex = Math.Clamp(styleIndex, 0, c.Styles.Count - 1)`
- `Weight(string, double, System.Action<double>)`；输入表达式：`Weight("类别内生成权重", s.Weight, v => s.Weight = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Weight("类别内生成权重", s.Weight, v => s.Weight = v);`
- `Weight(string, double, System.Action<double>)`；输入表达式：`Weight("类别生成权重", c.Weight, v => c.Weight = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Weight("类别生成权重", c.Weight, v => c.Weight = v);`

**赋值（含属性/字段和局部值）：**

- `c.Gender` = `PersonalityPools.Genders[n]`
- `c.Id` = `s`
- `c.Name` = `s`
- `c.Prompt` = `s`
- `c.Weight` = `v`
- `categoryIndex` = `draft.Categories.Count - 1`
- `categoryIndex` = `Math.Clamp(categoryIndex, 0, draft.Categories.Count - 1)`
- `categoryIndex` = `n`
- `deleteCategory.Disabled` = `draft.Categories.Count == 1`
- `deleteStyle.Disabled` = `c.Styles.Count == 1`
- `loading` = `false`
- `loading` = `true`
- `s.Id` = `v`
- `s.Name` = `v`
- `s.Prompt` = `v`
- `s.Weight` = `v`
- `styleIndex` = `0`
- `styleIndex` = `c.Styles.Count - 1`
- `styleIndex` = `Math.Clamp(styleIndex, 0, c.Styles.Count - 1)`
- `styleIndex` = `n`
- `Styles` = `[new()]`

<a id="symbol-e532b141db9d"></a>

## `Options(Godot.Node, string, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>) — OptionButton Options(Node parent, string name, IEnumerable<string> choices, int value, Action<int> changed)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(option)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(option);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`option.AddItem(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: option.AddItem(choice);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = name, CustomMinimumSize = new(200, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = name, CustomMinimumSize = new(200, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }`
- `Godot.OptionButton.Select(int)`；输入表达式：`option.Select(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: option.Select(value);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(200, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(200, 44)`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed((int)n)`；返回值紧邻使用处：`ExpressionStatementSyntax: changed((int)n);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(200, 44)`
- `FitToLongestItem` = `false`
- `Name` = `name`
- `option.ItemSelected` += `n => { if (!loading) changed((int)n); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-dc43ee9109c6"></a>

## `Line(string, string, System.Action<string>, string) — void Line(string label, string value, Action<string> changed, string name)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(edit)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(edit);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(130, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: caption.CustomMinimumSize = new(130, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 17, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(label, 17, _muted)`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed(s)`；返回值紧邻使用处：`ExpressionStatementSyntax: changed(s);`

**赋值（含属性/字段和局部值）：**

- `caption.CustomMinimumSize` = `new(130, 0)`
- `CustomMinimumSize` = `new(0, 42)`
- `edit.TextChanged` += `s => { if (!loading) changed(s); }`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-4dd5c03478ac"></a>

## `Memo(string, string, System.Action<string>, string) — void Memo(string label, string value, Action<string> changed, string name)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`edit.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(edit)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(edit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(Text(label, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(Text(label, 17, _muted));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = name, Text = value, CustomMinimumSize = new(0, 105), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = name, Text = value, CustomMinimumSize = new(0, 105), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 105)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 105)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(label, 17, _muted)`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed(edit.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: changed(edit.Text);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 105)`
- `edit.TextChanged` += `() => { if (!loading) changed(edit.Text); }`
- `Name` = `name`
- `Text` = `value`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-43db0c5144bf"></a>

## `Weight(string, double, System.Action<double>) — void Weight(string label, double value, Action<double> changed)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(number);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text(label, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text(label, 17, _muted));`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = 0, MaxValue = 1000000, Step = .1, Value = value, CustomMinimumSize = new(160, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { MinValue = 0, MaxValue = 1000000, Step = .1, Value = value, CustomMinimumSize = new(160, 42) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(160, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(160, 42)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(label, 17, _muted)`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed(n)`；返回值紧邻使用处：`ExpressionStatementSyntax: changed(n);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(160, 42)`
- `MaxValue` = `1000000`
- `MinValue` = `0`
- `number.ValueChanged` += `n => { if (!loading) changed(n); }`
- `Step` = `.1`
- `Value` = `value`

<a id="symbol-c5dc06d4fb96"></a>

## `Replace(NationalSpire.PersonalityPool) — void Replace(PersonalityPool pool)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)

**调用：** [`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-5fbd99cba947)

**字段、属性、事件及方法组引用：** `Rebuild()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Rebuild()`；输入表达式：`Rebuild()`；返回值紧邻使用处：`ExpressionStatementSyntax: Rebuild();`

**赋值（含属性/字段和局部值）：**

- `categoryIndex` = `styleIndex = 0`
- `draft` = `pool`
- `status.Text` = `"已加载到编辑草稿，保存后应用。"`
- `styleIndex` = `0`
