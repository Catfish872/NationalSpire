# AiSettingsPanel.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`962A9C96205D1A07B80F2E465E3C4E6A051ECE55BAED35A5D37D67A4139C1DAD`。来源：[源码](../../AiSettingsPanel.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiSettingsPanel`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-8fb9cbc85381"></a>

## `NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?) — public static Label Build(VBoxContainer box, AiOptions options, Action save, Action generate, Action prompts,          Action<string, bool> notice, Action? editing = null, string saveText = "保存设置", Action<Action>? confirmSwitch = null)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** [`Button(string, System.Action)`](AiSettingsPanel.cs.md#symbol-1774d28a11bf)；[`CommitKey()`](AiSettingsPanel.cs.md#symbol-965bdffd5689)；[`Current()`](AiSettingsPanel.cs.md#symbol-9680f9c80a3e)；[`FilterModels()`](AiSettingsPanel.cs.md#symbol-edc96cae7912)；[`Input(string, string, string)`](AiSettingsPanel.cs.md#symbol-b3d3d5d7a42f)；[`InvalidateModels()`](AiSettingsPanel.cs.md#symbol-0c17fb6f7f49)；[`Load(string, bool)`](AiSettingsPanel.cs.md#symbol-96678e748257)；[`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-7a203ffde56e)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`](AiModels.cs.md#symbol-142ecf753d1d)；[`NationalSpire.AiService.HasProfileKey(string)`](AiService.cs.md#symbol-79f735f59baf)；[`NationalSpire.AiService.ProfileKey(string)`](AiService.cs.md#symbol-96c9adf50cfa)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.PlayerFacingText.AiStatus(string)`](PlayerFacingText.cs.md#symbol-6179a4a56aad)；[`Number(string, string, int, int, int, System.Action<int>)`](AiSettingsPanel.cs.md#symbol-a2e61442cbfd)；[`RefreshProfiles()`](AiSettingsPanel.cs.md#symbol-0d7456fd0036)；[`RefreshRoutes()`](AiSettingsPanel.cs.md#symbol-7d731dbc5403)；[`Save()`](AiSettingsPanel.cs.md#symbol-f1fd5937e73b)；[`Switch(System.Action)`](AiSettingsPanel.cs.md#symbol-a8cc5f502137)；[`Text(string)`](AiSettingsPanel.cs.md#symbol-1b91d4c01f99)；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.GetItemMetadata(int)`；`Godot.OptionButton.OptionButton()`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextEdit.TextEdit()`；`Godot.Variant.AsString()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AiConnectionProfile.AiConnectionProfile()`；`NationalSpire.BroadcastButton.BroadcastButton()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Exception.GetType()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`

**字段、属性、事件及方法组引用：** `(string Id, string Name).Id`；`(string Id, string Name).Name`；`<anonymous type: bool enabled, bool available>.available`；`<anonymous type: bool enabled, bool available>.enabled`；`<anonymous type: bool enteredCredential, bool available>.available`；`<anonymous type: bool enteredCredential, bool available>.enteredCredential`；`<anonymous type: string error>.error`；`<anonymous type: string reason>.reason`；`Button(string, System.Action)`；`CommitKey()`；`Current()`；`FilterModels()`；`Input(string, string, string)`；`InvalidateModels()`；`Load(string, bool)`；`NationalSpire.AiConnectionProfile.Endpoint`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.Endpoint`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.MaximumNewsPostCount`；`NationalSpire.AiOptions.MaxNewsPosts`；`NationalSpire.AiOptions.MinimumIntervalSeconds`；`NationalSpire.AiOptions.Model`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiOptions.TaskProfiles`；`NationalSpire.AiRouting.Default`；`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；`NationalSpire.AiRouting.Tasks`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.FetchModelsAsync(string, string?, string)`；`NationalSpire.AiService.HasKey`；`NationalSpire.AiService.HasProfileKey(string)`；`NationalSpire.AiService.ProfileKey(string)`；`NationalSpire.AiService.Status`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.PlayerFacingText.AiStatus(string)`；`Number(string, string, int, int, int, System.Action<int>)`；`RefreshProfiles()`；`RefreshRoutes()`；`Save()`；`Switch(System.Action)`；`Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Button(string, System.Action)`；输入表达式：`Button("删除已保存密钥", () => { deleteKey = true; draftKey = ""; key.Text = ""; key.PlaceholderText = "保存后删除此方案密钥"; editing?.Invoke(); InvalidateModels(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Button("删除已保存密钥", () => { deleteKey = true; draftKey = ""; key.Text = ""; key.PlaceholderText = "保存后删除此方案密钥"; editing?.Invoke(); InvalidateModels(); });`
- `Button(string, System.Action)`；输入表达式：`Button("提示词配置", prompts)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button("提示词配置", prompts);`
- `CommitKey()`；输入表达式：`CommitKey()`；返回值紧邻使用处：`ExpressionStatementSyntax: CommitKey();`
- `Current()`；输入表达式：`Current()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Current()`
- `FilterModels()`；输入表达式：`FilterModels()`；返回值紧邻使用处：`ExpressionStatementSyntax: FilterModels();`
- `FilterModels()`；输入表达式：`FilterModels()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => FilterModels()`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "启用 AI 社区", ButtonPressed = options.Enabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Text = "启用 AI 社区", ButtonPressed = options.Enabled }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`detail.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`routeTitle.AddThemeColorOverride("font_color", CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: routeTitle.AddThemeColorOverride("font_color", CareerVisuals.Gold);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`Text("连接方案").AddThemeColorOverride("font_color", CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text("连接方案").AddThemeColorOverride("font_color", CareerVisuals.Gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`editor.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`routes.AddThemeConstantOverride("separation", 13)`；返回值紧邻使用处：`ExpressionStatementSyntax: routes.AddThemeConstantOverride("separation", 13);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 5);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`detail.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`details.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`routeTitle.AddThemeFontSizeOverride("font_size", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: routeTitle.AddThemeFontSizeOverride("font_size", 22);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`editorPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102330", "385565", 10, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: editorPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102330", "385565", 10, 18));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172f3c", "345363", 7, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172f3c", "345363", 7, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`routePanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("122735", "426575", 10, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: routePanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("122735", "426575", 10, 18));`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(fetch)`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`fetch.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fetch.IsQueuedForDeletion()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label { AutowrapMode = TextServer.AutowrapMode.WordSmart }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { AutowrapMode = TextServer.AutowrapMode.WordSmart }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "任务使用方案" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "任务使用方案" }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = task.Name }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = task.Name }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: key = new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AiModelFilter", PlaceholderText = "搜索模型", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "AiModelFilter", PlaceholderText = "搜索模型", CustomMinimumSize = new(0, 42) }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AiProfileName", Text = options.ConnectionProfiles[selected].Name, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "AiProfileName", Text = options.ConnectionProfiles[selected].Name, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(editorPanel)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(editorPanel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(routePanel)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(routePanel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(fetch)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(fetch);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(key);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(modelChoices)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(modelChoices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(saveRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(saveRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(selectionRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(selectionRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editorPanel.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: editorPanel.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`modelChoices.AddChild(filter)`；返回值紧邻使用处：`ExpressionStatementSyntax: modelChoices.AddChild(filter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`modelChoices.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: modelChoices.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`routePanel.AddChild(routes)`；返回值紧邻使用处：`ExpressionStatementSyntax: routePanel.AddChild(routes);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`routes.AddChild(applyAll)`；返回值紧邻使用处：`ExpressionStatementSyntax: routes.AddChild(applyAll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`routes.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: routes.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`routes.AddChild(routeTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: routes.AddChild(routeTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(choice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`saveRow.AddChild(profileName)`；返回值紧邻使用处：`ExpressionStatementSyntax: saveRow.AddChild(profileName);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`saveRow.AddChild(saveButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: saveRow.AddChild(saveButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`selectionRow.AddChild(create)`；返回值紧邻使用处：`ExpressionStatementSyntax: selectionRow.AddChild(create);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`selectionRow.AddChild(profiles)`；返回值紧邻使用处：`ExpressionStatementSyntax: selectionRow.AddChild(profiles);`
- `Godot.OptionButton.GetItemMetadata(int)`；输入表达式：`choice.GetItemMetadata((int)index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choice.GetItemMetadata((int)index).AsString`
- `Godot.OptionButton.GetItemMetadata(int)`；输入表达式：`profiles.GetItemMetadata((int)index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: profiles.GetItemMetadata((int)index).AsString`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "AiModelList", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "AiModelList", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "AiProfiles", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "AiProfiles", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "AiRoute_" + task.Id, FitToLongestItem = false, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "AiRoute_" + task.Id, FitToLongestItem = false, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.2f }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.2f }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "AiModelError", Visible = false, Editable = false, CustomMinimumSize = new(0, 110), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "AiModelError", Visible = false, Editable = false, CustomMinimumSize = new(0, 110), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Variant.AsString()`；输入表达式：`choice.GetItemMetadata((int)index).AsString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.TaskProfiles[task.Id] = choice.GetItemMetadata((int)index).AsString()`
- `Godot.Variant.AsString()`；输入表达式：`profiles.GetItemMetadata((int)index).AsString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = profiles.GetItemMetadata((int)index).AsString()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Visible = false }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 110)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 110)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(128, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(128, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(220, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(96, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(96, 46)`
- `Input(string, string, string)`；输入表达式：`Input("服务地址（自动补全 /chat/completions）", options.ConnectionProfiles[selected].Endpoint, "AiEndpoint")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input("服务地址（自动补全 /chat/completions）", options.ConnectionProfiles[selected].Endpoint, "AiEndpoint")`
- `Input(string, string, string)`；输入表达式：`Input("模型名称", options.ConnectionProfiles[selected].Model, "AiModel")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input("模型名称", options.ConnectionProfiles[selected].Model, "AiModel")`
- `InvalidateModels()`；输入表达式：`InvalidateModels()`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateModels();`
- `InvalidateModels()`；输入表达式：`InvalidateModels()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => InvalidateModels()`
- `Load(string, bool)`；输入表达式：`Load(source, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Load(source, true)`
- `Load(string, bool)`；输入表达式：`Load(target, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Load(target, false)`
- `NationalSpire.AiConnectionProfile.AiConnectionProfile()`；输入表达式：`new() { Name = name, Endpoint = address, Model = modelId }`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.ConnectionProfiles[selected] = new() { Name = name, Endpoint = address, Model = modelId }`
- `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；输入表达式：`AiRouting.Ensure(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiRouting.Ensure(options);`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`AiService.FailureReason(e)`；返回值紧邻使用处：`AssignmentExpressionSyntax: details.Text = AiService.FailureReason(e)`
- `NationalSpire.AiService.FetchModelsAsync(string, string?, string)`；输入表达式：`AiService.FetchModelsAsync(address, credential, selected)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.FetchModelsAsync(address, credential, selected)`
- `NationalSpire.AiService.HasProfileKey(string)`；输入表达式：`AiService.HasProfileKey(selected)`；返回值紧邻使用处：`ConditionalExpressionSyntax: AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥"`
- `NationalSpire.AiService.HasProfileKey(string)`；输入表达式：`AiService.HasProfileKey(selected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AiService.HasProfileKey(selected)`
- `NationalSpire.AiService.ProfileKey(string)`；输入表达式：`AiService.ProfileKey(selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.ProfileKey(selected)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Name = "AiApplyAll", Text = "将当前方案应用到所有", CustomMinimumSize = new(0, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Name = "AiApplyAll", Text = "将当前方案应用到所有", CustomMinimumSize = new(0, 46) }`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Name = "AiFetchModels", Text = "获取模型列表", CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Name = "AiFetchModels", Text = "获取模型列表", CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Name = "AiNewProfile", Text = "＋ 新建", CustomMinimumSize = new(96, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Name = "AiNewProfile", Text = "＋ 新建", CustomMinimumSize = new(96, 46) }`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Name = "AiSaveProfile", Text = saveText, CustomMinimumSize = new(128, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Name = "AiSaveProfile", Text = saveText, CustomMinimumSize = new(128, 46) }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("102330", "385565", 10, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("102330", "385565", 10, 18)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("122735", "426575", 10, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("122735", "426575", 10, 18)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172f3c", "345363", 7, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172f3c", "345363", 7, 12)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });`
- `NationalSpire.PlayerFacingText.AiStatus(string)`；输入表达式：`PlayerFacingText.AiStatus(AiService.Status)`；返回值紧邻使用处：`BinaryExpressionSyntax: "当前状态：" + PlayerFacingText.AiStatus(AiService.Status)`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("每次最多生成帖子数", "AiNewsPostCount", options.MaxNewsPosts, 1, AiOptions.MaximumNewsPostCount, value => options.MaxNewsPosts = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("每次最多生成帖子数", "AiNewsPostCount", options.MaxNewsPosts, 1, AiOptions.MaximumNewsPostCount, value => options.MaxNewsPosts = value);`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("请求发送间隔 · 秒，0 表示无需间隔", "AiRequestInterval", options.MinimumIntervalSeconds, 0, 300, value => options.MinimumIntervalSeconds = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("请求发送间隔 · 秒，0 表示无需间隔", "AiRequestInterval", options.MinimumIntervalSeconds, 0, 300, value => options.MinimumIntervalSeconds = value);`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("最大并发数", "AiConcurrency", options.MaxConcurrentRequests, 1, 16, value => options.MaxConcurrentRequests = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("最大并发数", "AiConcurrency", options.MaxConcurrentRequests, 1, 16, value => options.MaxConcurrentRequests = value);`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("最长等待时间 · 分钟", "AiTimeout", options.RequestTimeoutMinutes, 2, 30, value => options.RequestTimeoutMinutes = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("最长等待时间 · 分钟", "AiTimeout", options.RequestTimeoutMinutes, 2, 30, value => options.RequestTimeoutMinutes = value);`
- `RefreshProfiles()`；输入表达式：`RefreshProfiles()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshProfiles();`
- `RefreshRoutes()`；输入表达式：`RefreshRoutes()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshRoutes();`
- `Save()`；输入表达式：`Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: Save();`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key.Text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(key.Text) ? draftKey : key.Text`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key.Text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(key.Text)`
- `string.Trim()`；输入表达式：`endpoint.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = endpoint.Text.Trim()`
- `string.Trim()`；输入表达式：`model.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = model.Text.Trim()`
- `string.Trim()`；输入表达式：`profileName.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = profileName.Text.Trim()`
- `Switch(System.Action)`；输入表达式：`Switch(() => Load(source, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: Switch(() => Load(source, true));`
- `Switch(System.Action)`；输入表达式：`Switch(() => Load(target, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: Switch(() => Load(target, false));`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: editing?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`generate()`；返回值紧邻使用处：`ExpressionStatementSyntax: generate();`
- `System.Action.Invoke()`；输入表达式：`save()`；返回值紧邻使用处：`ExpressionStatementSyntax: save();`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("当前方案已应用到所有任务。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("当前方案已应用到所有任务。", false);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置已保存，请填写 API 密钥。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置已保存，请填写 API 密钥。", true);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置已保存。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置已保存。", false);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice(e.Message, true);`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("方案名称已存在，请修改名称。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("方案名称已存在，请修改名称。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写方案名称。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写方案名称。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写有效的服务地址和模型名称。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写有效的服务地址和模型名称。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`options.ConnectionProfiles.Remove(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.ConnectionProfiles.Remove(selected);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`options.ConnectionProfiles.Any(p => p.Key != selected && p.Value.Name == name)`；返回值紧邻使用处：`IfStatementSyntax: if (options.ConnectionProfiles.Any(p => p.Key != selected && p.Value.Name == name)) throw new ArgumentException("方案名称已存在，请修改名称。");`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`options.ConnectionProfiles.GetValueOrDefault(selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = options.ConnectionProfiles.GetValueOrDefault(selected)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`routeControls.Add((task.Id, choice, detail))`；返回值紧邻使用处：`ExpressionStatementSyntax: routeControls.Add((task.Id, choice, detail));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Task, OptionButton Picker, Label Model)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Task, OptionButton Picker, Label Model)>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Func<bool>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Func<bool>>()`
- `System.Exception.GetType()`；输入表达式：`e.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetType().Name`
- `System.Func<TResult>.Invoke()`；输入表达式：`commit()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !commit()`
- `System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；输入表达式：`Uri.TryCreate(address, UriKind.Absolute, out var uri)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Uri.TryCreate(address, UriKind.Absolute, out var uri)`
- `Text(string)`；输入表达式：`Text("按待生成事件选取，不足时不会凑数。数量越多，生成时间和用量通常越高；默认 3 篇。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Text("按待生成事件选取，不足时不会凑数。数量越多，生成时间和用量通常越高；默认 3 篇。");`
- `Text(string)`；输入表达式：`Text("当前状态：" + PlayerFacingText.AiStatus(AiService.Status))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("当前状态：" + PlayerFacingText.AiStatus(AiService.Status))`
- `Text(string)`；输入表达式：`Text("连接方案")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Text("连接方案").AddThemeColorOverride`
- `Text(string)`；输入表达式：`Text("使用当前填写的密钥查询，留空时使用已保存密钥。")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("使用当前填写的密钥查询，留空时使用已保存密钥。")`
- `Text(string)`；输入表达式：`Text("API 密钥（加密保存在本机）")`；返回值紧邻使用处：`ExpressionStatementSyntax: Text("API 密钥（加密保存在本机）");`

**赋值（含属性/字段和局部值）：**

- `applyAll.Pressed` += `() => { foreach (var task in AiRouting.Tasks) options.TaskProfiles[task.Id] = selected; Save(); RefreshRoutes(); notice("当前方案已应用到所有任务。", false); }`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `ButtonPressed` = `options.Enabled`
- `choice.ItemSelected` += `index => { if (loading) return; options.TaskProfiles[task.Id] = choice.GetItemMetadata((int)index).AsString(); Save(); RefreshRoutes(); }`
- `create.Pressed` += `() => { string source = creating ? AiRouting.Default : selected; Switch(() => Load(source, true)); }`
- `creating` = `false`
- `CustomMinimumSize` = `new(0, 110)`
- `CustomMinimumSize` = `new(0, 40)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(0, 46)`
- `CustomMinimumSize` = `new(128, 46)`
- `CustomMinimumSize` = `new(220, 48)`
- `CustomMinimumSize` = `new(96, 46)`
- `deleteKey` = `true`
- `details.Text` = `AiService.FailureReason(e)`
- `details.Visible` = `false`
- `details.Visible` = `true`
- `draftKey` = `""`
- `Editable` = `false`
- `enabled.Toggled` += `value => { editing?.Invoke(); options.Enabled = value; Save(); }`
- `endpoint.TextChanged` += `_ => InvalidateModels()`
- `Endpoint` = `address`
- `fetch.Disabled` = `false`
- `fetch.Disabled` = `true`
- `fetch.Pressed` += `async () =>          {              if (fetch.Disabled) return;              editing?.Invoke();              int revision = queryRevision; string address = endpoint.Text.Trim(); string? credential = string.IsNullOrWhiteSpace(key.Text) ? draftKey : key.Text;              fetch.Disabled = true; fetch.Text = "正在获取…"; modelStatus.Text = "正在查询模型列表…"; details.Visible = false;              bool Current() => GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion() && fetch.IsInsideTree() && revision == queryRevision;              try              {                  var result = await AiService.FetchModelsAsync(address, credential, selected);                  if (!Current()) return;                  models = result; filter.Text = ""; FilterModels(); modelChoices.Visible = models.Count > 0;                  modelStatus.Text = models.Count == 0 ? "接口返回的模型列表为空，可手动填写模型名称。" : $"已获取 {models.Count} 个模型，支持搜索选择。";              }              catch (Exception e)              {                  if (!Current()) return;                  modelStatus.Text = "获取失败，详情如下。也可手动填写模型名称。";                  details.Text = AiService.FailureReason(e); details.Visible = true;              }              finally              {                  if (GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()) { fetch.Disabled = false; fetch.Text = "获取模型列表"; }              }          }`
- `fetch.Text` = `"获取模型列表"`
- `fetch.Text` = `"正在获取…"`
- `filter.Text` = `""`
- `filter.TextChanged` += `_ => FilterModels()`
- `FitToLongestItem` = `false`
- `key.PlaceholderText` = `"保存后删除此方案密钥"`
- `key.Text` = `""`
- `key.TextChanged` += `_ => editing?.Invoke()`
- `key.TextChanged` += `_ => InvalidateModels()`
- `key` = `new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) }`
- `model.Text` = `filtered[(int)index - 1]`
- `Model` = `modelId`
- `modelChoices.Visible` = `models.Count > 0`
- `models` = `result`
- `modelStatus.Name` = `"AiModelStatus"`
- `modelStatus.Text` = `"获取失败，详情如下。也可手动填写模型名称。"`
- `modelStatus.Text` = `"已填入模型名称，点击保存后生效。"`
- `modelStatus.Text` = `"正在查询模型列表…"`
- `modelStatus.Text` = `models.Count == 0 ? "接口返回的模型列表为空，可手动填写模型名称。" : $"已获取 {models.Count} 个模型，支持搜索选择。"`
- `Name` = `"AiApplyAll"`
- `Name` = `"AiFetchModels"`
- `Name` = `"AiKey"`
- `Name` = `"AiModelError"`
- `Name` = `"AiModelFilter"`
- `Name` = `"AiModelList"`
- `Name` = `"AiNewProfile"`
- `Name` = `"AiProfileName"`
- `Name` = `"AiProfiles"`
- `Name` = `"AiRoute_" + task.Id`
- `Name` = `"AiSaveProfile"`
- `Name` = `name`
- `options.ConnectionProfiles[selected]` = `new() { Name = name, Endpoint = address, Model = modelId }`
- `options.ConnectionProfiles[selected]` = `prior`
- `options.Enabled` = `value`
- `options.Endpoint` = `address`
- `options.Endpoint` = `prior.Endpoint`
- `options.MaxConcurrentRequests` = `value`
- `options.MaxNewsPosts` = `value`
- `options.MinimumIntervalSeconds` = `value`
- `options.Model` = `modelId`
- `options.Model` = `prior.Model`
- `options.RequestTimeoutMinutes` = `value`
- `options.TaskProfiles[task.Id]` = `choice.GetItemMetadata((int)index).AsString()`
- `options.TaskProfiles[task.Id]` = `selected`
- `picker.ItemSelected` += `index =>          {              if (index < 1 || index > filtered.Length) return;              model.Text = filtered[(int)index - 1]; editing?.Invoke(); modelStatus.Text = "已填入模型名称，点击保存后生效。";          }`
- `PlaceholderText` = `"搜索模型"`
- `PlaceholderText` = `AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥"`
- `profileName.TextChanged` += `_ => editing?.Invoke()`
- `profiles.ItemSelected` += `index =>          {              if (loading) return;              string target = profiles.GetItemMetadata((int)index).AsString();              if (target != selected) Switch(() => Load(target, false));          }`
- `saveButton.Pressed` += `() =>          {              Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });              try              {                  // 点击保存时也提交仍在编辑的数字，不依赖焦点事件先后顺序。                  bool valid = true;                  foreach (var commit in commitNumbers) if (!commit()) valid = false;                  if (!valid) { Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" }); return; }                  string name = profileName.Text.Trim(), address = endpoint.Text.Trim(), modelId = model.Text.Trim();                  if (name.Length == 0) throw new ArgumentException("请填写方案名称。");                  if (options.ConnectionProfiles.Any(p => p.Key != selected && p.Value.Name == name)) throw new ArgumentException("方案名称已存在，请修改名称。");                  if (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme is not ("http" or "https") || modelId.Length == 0)                      throw new ArgumentException("请填写有效的服务地址和模型名称。");                  var prior = options.ConnectionProfiles.GetValueOrDefault(selected);                  options.ConnectionProfiles[selected] = new() { Name = name, Endpoint = address, Model = modelId };                  if (selected == AiRouting.Default) { options.Endpoint = address; options.Model = modelId; }                  try { save(); }                  catch                  {                      if (prior == null) options.ConnectionProfiles.Remove(selected); else options.ConnectionProfiles[selected] = prior;                      if (selected == AiRouting.Default && prior != null) { options.Endpoint = prior.Endpoint; options.Model = prior.Model; }                      throw;                  }                  CommitKey(); creating = false;                  RefreshProfiles(); RefreshRoutes();                  Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });                  if (!options.Enabled) { notice("设置已保存。", false); return; }                  if (!AiService.HasProfileKey(selected)) { notice("设置已保存，请填写 API 密钥。", true); return; }                  generate(); notice("设置已保存。", false);              }              catch (Exception e) { Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name }); notice(e.Message, true); }          }`
- `Secret` = `true`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ShrinkBegin`
- `SizeFlagsStretchRatio` = `1.2f`
- `Text` = `"＋ 新建"`
- `Text` = `"获取模型列表"`
- `Text` = `"将当前方案应用到所有"`
- `Text` = `"启用 AI 社区"`
- `Text` = `"任务使用方案"`
- `Text` = `options.ConnectionProfiles[selected].Name`
- `Text` = `saveText`
- `Text` = `task.Name`
- `valid` = `false`
- `Visible` = `false`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-1b91d4c01f99"></a>

## `Text(string) — Label Text(string value)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Input(string, string, string)`](AiSettingsPanel.cs.md#symbol-b3d3d5d7a42f)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`Number(string, string, int, int, int, System.Action<int>)`](AiSettingsPanel.cs.md#symbol-a2e61442cbfd)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(label);`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-1774d28a11bf"></a>

## `Button(string, System.Action) — void Button(string title, Action action)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(220, 48)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text = title, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text = title, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(220, 48)`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ShrinkBegin`
- `Text` = `title`

<a id="symbol-f1fd5937e73b"></a>

## `Save() — void Save()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit()`](AiSettingsPanel.cs.md#symbol-4b717c808863)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** `System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action.Invoke()`；输入表达式：`save()`；返回值紧邻使用处：`ExpressionStatementSyntax: save();`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置未能保存：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置未能保存：" + e.Message, true);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b3d3d5d7a42f"></a>

## `Input(string, string, string) — LineEdit Input(string title, string value, string name)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`Text(string)`](AiSettingsPanel.cs.md#symbol-1b91d4c01f99)；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(input);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: editing?.Invoke()`
- `Text(string)`；输入表达式：`Text(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(title);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 42)`
- `input.TextChanged` += `_ => editing?.Invoke()`
- `Name` = `name`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-a2e61442cbfd"></a>

## `Number(string, string, int, int, int, System.Action<int>) — void Number(string title, string name, int value, int min, int max, Action<int> update)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`Commit()`](AiSettingsPanel.cs.md#symbol-4b717c808863)；[`Text(string)`](AiSettingsPanel.cs.md#symbol-1b91d4c01f99)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`NationalSpire.BroadcastButton.BroadcastButton()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Commit()`；`Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit();`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Commit()`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Commit()`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Commit()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = saved.ToString(), CustomMinimumSize = new(150, 44), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = saved.ToString(), CustomMinimumSize = new(150, 44), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`editor.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(step)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(step);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(44, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(44, 44)`
- `int.ToString()`；输入表达式：`Math.Clamp(saved + delta, min, max).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: input.Text = Math.Clamp(saved + delta, min, max).ToString()`
- `int.ToString()`；输入表达式：`saved.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = saved.ToString()`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text = delta < 0 ? "−" : "+", CustomMinimumSize = new(44, 44), FocusMode = Control.FocusModeEnum.None }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text = delta < 0 ? "−" : "+", CustomMinimumSize = new(44, 44), FocusMode = Control.FocusModeEnum.None }`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: editing?.Invoke()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`commitNumbers.Add(Commit)`；返回值紧邻使用处：`ExpressionStatementSyntax: commitNumbers.Add(Commit);`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(saved + delta, min, max)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Math.Clamp(saved + delta, min, max).ToString`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(value, min, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(value, min, max)`
- `Text(string)`；输入表达式：`Text($"{title}（{min}—{max}）")`；返回值紧邻使用处：`ExpressionStatementSyntax: Text($"{title}（{min}—{max}）");`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(150, 44)`
- `CustomMinimumSize` = `new(44, 44)`
- `FocusMode` = `Control.FocusModeEnum.None`
- `input.FocusExited` += `() => Commit()`
- `input.Text` = `Math.Clamp(saved + delta, min, max).ToString()`
- `input.TextChanged` += `_ => editing?.Invoke()`
- `input.TextSubmitted` += `_ => Commit()`
- `Name` = `name`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `step.Pressed` += `() => { if (!Commit()) return; editing?.Invoke(); input.Text = Math.Clamp(saved + delta, min, max).ToString(); Commit(); }`
- `Text` = `delta < 0 ? "−" : "+"`
- `Text` = `saved.ToString()`

<a id="symbol-4b717c808863"></a>

## `Commit() — bool Commit()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Number(string, string, int, int, int, System.Action<int>)`](AiSettingsPanel.cs.md#symbol-a2e61442cbfd)

**调用：** [`Save()`](AiSettingsPanel.cs.md#symbol-f1fd5937e73b)；`int.ToString()`；`int.TryParse(string?, out int)`；`string.Trim()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`number.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: input.Text = number.ToString()`
- `int.ToString()`；输入表达式：`saved.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: input.Text = saved.ToString()`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(input.Text.Trim(), out int number)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !int.TryParse(input.Text.Trim(), out int number)`
- `Save()`；输入表达式：`Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: Save();`
- `string.Trim()`；输入表达式：`input.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: input.Text.Trim()`
- `System.Action<T>.Invoke(T)`；输入表达式：`update(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: update(number);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice($"{title}请输入 {min}—{max} 之间的整数，已保留原值 {saved}。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice($"{title}请输入 {min}—{max} 之间的整数，已保留原值 {saved}。", true);`

**赋值（含属性/字段和局部值）：**

- `input.Text` = `number.ToString()`
- `input.Text` = `saved.ToString()`
- `saved` = `number`

<a id="symbol-965bdffd5689"></a>

## `CommitKey() — void CommitKey()`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`NationalSpire.AiService.HasProfileKey(string)`](AiService.cs.md#symbol-79f735f59baf)；[`NationalSpire.AiService.PersistKey(string, string)`](AiService.cs.md#symbol-017daf4a239c)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.HasProfileKey(string)`；`NationalSpire.AiService.PersistKey(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.HasProfileKey(string)`；输入表达式：`AiService.HasProfileKey(selected)`；返回值紧邻使用处：`ConditionalExpressionSyntax: AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥"`
- `NationalSpire.AiService.PersistKey(string, string)`；输入表达式：`AiService.PersistKey(value, selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.PersistKey(value, selected)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key!.Text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(key!.Text)`
- `string.Trim()`；输入表达式：`key.Text.Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: !string.IsNullOrWhiteSpace(key!.Text) ? key.Text.Trim() : creating ? draftKey : null`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice(error, true);`

**赋值（含属性/字段和局部值）：**

- `deleteKey` = `false`
- `draftKey` = `value`
- `key!.Text` = `""`
- `key.PlaceholderText` = `AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥"`

<a id="symbol-edc96cae7912"></a>

## `FilterModels() — void FilterModels()`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** `Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(filtered.Length == 0 ? "没有匹配的模型" : "选择模型，填入上方输入框")`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(filtered.Length == 0 ? "没有匹配的模型" : "选择模型，填入上方输入框");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(id);`
- `Godot.OptionButton.Clear()`；输入表达式：`picker.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Select(0);`
- `string.Contains(string, System.StringComparison)`；输入表达式：`m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`filter.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: filter.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`models.Where(m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: filtered = models.Where(m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`models.Where(m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: models.Where(m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray`

**赋值（含属性/字段和局部值）：**

- `filtered` = `models.Where(m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray()`
- `picker.Disabled` = `filtered.Length == 0`

<a id="symbol-0c17fb6f7f49"></a>

## `InvalidateModels() — void InvalidateModels()`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Load(string, bool)`](AiSettingsPanel.cs.md#symbol-96678e748257)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `details.Visible` = `false`
- `modelChoices.Visible` = `false`
- `models` = `[]`
- `modelStatus.Text` = `"地址或密钥已修改，请重新获取模型列表。"`

<a id="symbol-9680f9c80a3e"></a>

## `Current() — bool Current()`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(fetch)`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`fetch.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fetch.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`fetch.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion() && fetch.IsInsideTree()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7d731dbc5403"></a>

## `RefreshRoutes() — void RefreshRoutes()`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Load(string, bool)`](AiSettingsPanel.cs.md#symbol-96678e748257)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`

**字段、属性、事件及方法组引用：** `(string Task, Godot.OptionButton Picker, Godot.Label Model).Model`；`(string Task, Godot.OptionButton Picker, Godot.Label Model).Picker`；`(string Task, Godot.OptionButton Picker, Godot.Label Model).Task`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`route.Picker.AddItem(entry.Value.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: route.Picker.AddItem(entry.Value.Name);`
- `Godot.OptionButton.Clear()`；输入表达式：`route.Picker.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: route.Picker.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`route.Picker.Select(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: route.Picker.Select(i);`
- `Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`；输入表达式：`route.Picker.SetItemMetadata(i, entry.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: route.Picker.SetItemMetadata(i, entry.Key);`
- `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；输入表达式：`AiRouting.ProfileId(options, route.Task)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiRouting.ProfileId(options, route.Task)`

**赋值（含属性/字段和局部值）：**

- `applyAll.Disabled` = `creating`
- `loading` = `false`
- `loading` = `true`
- `route.Model.Text` = `options.ConnectionProfiles[assigned].Model`

<a id="symbol-0d7456fd0036"></a>

## `RefreshProfiles() — void RefreshProfiles()`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Load(string, bool)`](AiSettingsPanel.cs.md#symbol-96678e748257)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`Switch(System.Action)`](AiSettingsPanel.cs.md#symbol-a8cc5f502137)

**调用：** `Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`profiles.AddItem(entry.Value.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: profiles.AddItem(entry.Value.Name);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`profiles.AddItem(profileName.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: profiles.AddItem(profileName.Text);`
- `Godot.OptionButton.Clear()`；输入表达式：`profiles.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: profiles.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`profiles.Select(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: profiles.Select(i);`
- `Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`；输入表达式：`profiles.SetItemMetadata(i, entry.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: profiles.SetItemMetadata(i, entry.Key);`
- `Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`；输入表达式：`profiles.SetItemMetadata(i, selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: profiles.SetItemMetadata(i, selected);`

**赋值（含属性/字段和局部值）：**

- `loading` = `false`
- `loading` = `true`

<a id="symbol-b55c6d251317"></a>

## `Dirty() — bool Dirty()`

来源：源码第 218 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Switch(System.Action)`](AiSettingsPanel.cs.md#symbol-a8cc5f502137)

**调用：** `string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Endpoint`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key.Text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(key.Text)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-96678e748257"></a>

## `Load(string, bool) — void Load(string id, bool fresh)`

来源：源码第 224 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`InvalidateModels()`](AiSettingsPanel.cs.md#symbol-0c17fb6f7f49)；[`NationalSpire.AiRouting.NextName(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-761de1a86dc4)；[`NationalSpire.AiService.ProfileKey(string)`](AiService.cs.md#symbol-96c9adf50cfa)；[`RefreshProfiles()`](AiSettingsPanel.cs.md#symbol-0d7456fd0036)；[`RefreshRoutes()`](AiSettingsPanel.cs.md#symbol-7d731dbc5403)；`string.IsNullOrWhiteSpace(string?)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `InvalidateModels()`；`NationalSpire.AiConnectionProfile.Endpoint`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.NextName(NationalSpire.AiOptions)`；`NationalSpire.AiService.ProfileKey(string)`；`RefreshProfiles()`；`RefreshRoutes()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `InvalidateModels()`；输入表达式：`InvalidateModels()`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateModels();`
- `NationalSpire.AiRouting.NextName(NationalSpire.AiOptions)`；输入表达式：`AiRouting.NextName(options)`；返回值紧邻使用处：`ConditionalExpressionSyntax: fresh ? AiRouting.NextName(options) : source.Name`
- `NationalSpire.AiService.ProfileKey(string)`；输入表达式：`AiService.ProfileKey(id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: draftKey = AiService.ProfileKey(id)`
- `RefreshProfiles()`；输入表达式：`RefreshProfiles()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshProfiles();`
- `RefreshRoutes()`；输入表达式：`RefreshRoutes()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshRoutes();`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(draftKey)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(draftKey)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ConditionalExpressionSyntax: fresh ? Guid.NewGuid().ToString("N") : id`

**赋值（含属性/字段和局部值）：**

- `creating` = `fresh`
- `deleteKey` = `false`
- `draftKey` = `AiService.ProfileKey(id)`
- `endpoint.Text` = `source.Endpoint`
- `key.PlaceholderText` = `!string.IsNullOrWhiteSpace(draftKey) ? "已保存，留空保留当前密钥" : "请输入 API 密钥"`
- `key.Text` = `""`
- `model.Text` = `source.Model`
- `profileName.Text` = `fresh ? AiRouting.NextName(options) : source.Name`
- `selected` = `fresh ? Guid.NewGuid().ToString("N") : id`

<a id="symbol-a8cc5f502137"></a>

## `Switch(System.Action) — void Switch(Action action)`

来源：源码第 233 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** [`Dirty()`](AiSettingsPanel.cs.md#symbol-b55c6d251317)；[`RefreshProfiles()`](AiSettingsPanel.cs.md#symbol-0d7456fd0036)；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Dirty()`；`RefreshProfiles()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Dirty()`；输入表达式：`Dirty()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Dirty()`
- `RefreshProfiles()`；输入表达式：`RefreshProfiles()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshProfiles();`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`
- `System.Action<T>.Invoke(T)`；输入表达式：`confirmSwitch(action)`；返回值紧邻使用处：`ExpressionStatementSyntax: confirmSwitch(action);`

**赋值（含属性/字段和局部值）：**
