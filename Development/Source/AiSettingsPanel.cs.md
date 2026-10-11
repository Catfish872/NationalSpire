# AiSettingsPanel.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`858E769867B70BE6CA3B076795201C7BB9CBE343F0823C7D0E73DE417EC22BA3`。来源：[源码](../../AiSettingsPanel.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiSettingsPanel`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-f3d78e0ed656"></a>

## `NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string) — public static Label Build(VBoxContainer box, AiOptions options, Action save, Action generate, Action prompts,          Action<string, bool> notice, Action? editing = null, string saveText = "保存设置")`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** [`Button(string, System.Action)`](AiSettingsPanel.cs.md#symbol-267b46013d75)；[`CommitKey()`](AiSettingsPanel.cs.md#symbol-b768a66bdbcb)；[`Current()`](AiSettingsPanel.cs.md#symbol-042dcd65a46f)；[`FilterModels()`](AiSettingsPanel.cs.md#symbol-24d96ada4dab)；[`Input(string, string, string)`](AiSettingsPanel.cs.md#symbol-e0565c8b5a2a)；[`InvalidateModels()`](AiSettingsPanel.cs.md#symbol-c6418f8cdbe2)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.FetchModelsAsync(string, string?)`](AiModels.cs.md#symbol-e41aed0c4d95)；[`NationalSpire.AiService.PersistKey(string)`](AiService.cs.md#symbol-1db4f1f2513d)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.PlayerFacingText.AiStatus(string)`](PlayerFacingText.cs.md#symbol-6179a4a56aad)；[`Number(string, string, int, int, int, System.Action<int>)`](AiSettingsPanel.cs.md#symbol-a53cee6ac550)；[`Save()`](AiSettingsPanel.cs.md#symbol-fbc778bc683b)；[`Text(string)`](AiSettingsPanel.cs.md#symbol-1f1961594be0)；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.OptionButton()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.List<T>.List()`；`System.Exception.GetType()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`

**字段、属性、事件及方法组引用：** `<anonymous type: bool enabled, bool available>.available`；`<anonymous type: bool enabled, bool available>.enabled`；`<anonymous type: bool enteredCredential, bool available>.available`；`<anonymous type: bool enteredCredential, bool available>.enteredCredential`；`<anonymous type: string error>.error`；`<anonymous type: string reason>.reason`；`Button(string, System.Action)`；`CommitKey()`；`Current()`；`FilterModels()`；`Input(string, string, string)`；`InvalidateModels()`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.Endpoint`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.MaximumNewsPostCount`；`NationalSpire.AiOptions.MaxNewsPosts`；`NationalSpire.AiOptions.MinimumIntervalSeconds`；`NationalSpire.AiOptions.Model`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.FetchModelsAsync(string, string?)`；`NationalSpire.AiService.HasKey`；`NationalSpire.AiService.PersistKey(string)`；`NationalSpire.AiService.Status`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.PlayerFacingText.AiStatus(string)`；`Number(string, string, int, int, int, System.Action<int>)`；`Save()`；`Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Button(string, System.Action)`；输入表达式：`Button("删除已保存密钥", () => { var error = AiService.PersistKey(""); key.Text = ""; key.PlaceholderText = "请输入 API 密钥"; InvalidateModels(); notice(error ?? "本机密钥已删除。", error != null); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Button("删除已保存密钥", () => { var error = AiService.PersistKey(""); key.Text = ""; key.PlaceholderText = "请输入 API 密钥"; InvalidateModels(); notice(error ?? "本机密钥已删除。", error != null); });`
- `Button(string, System.Action)`；输入表达式：`Button("提示词配置", prompts)`；返回值紧邻使用处：`ExpressionStatementSyntax: Button("提示词配置", prompts);`
- `Button(string, System.Action)`；输入表达式：`Button(saveText, () =>          {              Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });              try              {                  // 点击保存时也提交仍在编辑的数字，不依赖焦点事件先后顺序。                  bool valid = true;                  foreach (var commit in commitNumbers) if (!commit()) valid = false;                  if (!valid) { Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" }); return; }                  options.Endpoint = endpoint.Text.Trim(); options.Model = model.Text.Trim();                  if (!Uri.TryCreate(options.Endpoint, UriKind.Absolute, out var uri) || uri.Scheme is not ("http" or "https") || options.Model.Length == 0)                      throw new ArgumentException("请填写有效的服务地址和模型名称。");                  save();                  CommitKey();                  Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });                  if (!options.Enabled) { notice("设置已保存。", false); return; }                  if (!AiService.HasKey) { notice("设置已保存，请填写 API 密钥。", true); return; }                  generate(); notice("设置已保存。", false);              }              catch (Exception e) { Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name }); notice(e.Message, true); }          })`；返回值紧邻使用处：`ExpressionStatementSyntax: Button(saveText, () =>          {              Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });              try              {                  // 点击保存时也提交仍在编辑的数字，不依赖焦点事件先后顺序。                  bool valid = true;                  foreach (var commit in commitNumbers) if (!commit()) valid = false;                  if (!valid) { Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" }); return; }                  options.Endpoint = endpoint.Text.Trim(); options.Model = model.Text.Trim();                  if (!Uri.TryCreate(options.Endpoint, UriKind.Absolute, out var uri) || uri.Scheme is not ("http" or "https") || options.Model.Length == 0)                      throw new ArgumentException("请填写有效的服务地址和模型名称。");                  save();                  CommitKey();                  Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });                  if (!options.Enabled) { notice("设置已保存。", false); return; }                  if (!AiService.HasKey) { notice("设置已保存，请填写 API 密钥。", true); return; }                  generate(); notice("设置已保存。", false);              }              catch (Exception e) { Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name }); notice(e.Message, true); }          });`
- `CommitKey()`；输入表达式：`CommitKey()`；返回值紧邻使用处：`ExpressionStatementSyntax: CommitKey();`
- `Current()`；输入表达式：`Current()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Current()`
- `FilterModels()`；输入表达式：`FilterModels()`；返回值紧邻使用处：`ExpressionStatementSyntax: FilterModels();`
- `FilterModels()`；输入表达式：`FilterModels()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => FilterModels()`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "启用 AI 社区", ButtonPressed = options.Enabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Text = "启用 AI 社区", ButtonPressed = options.Enabled }`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`details.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(fetch)`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`fetch.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fetch.IsQueuedForDeletion()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasKey ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: key = new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasKey ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AiModelFilter", PlaceholderText = "搜索模型", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "AiModelFilter", PlaceholderText = "搜索模型", CustomMinimumSize = new(0, 42) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fetch)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fetch);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(key);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(modelChoices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(modelChoices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`modelChoices.AddChild(filter)`；返回值紧邻使用处：`ExpressionStatementSyntax: modelChoices.AddChild(filter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`modelChoices.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: modelChoices.AddChild(picker);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "AiModelList", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "AiModelList", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "AiModelError", Visible = false, Editable = false, CustomMinimumSize = new(0, 110), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "AiModelError", Visible = false, Editable = false, CustomMinimumSize = new(0, 110), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Visible = false }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 110)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 110)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(220, 48)`
- `Input(string, string, string)`；输入表达式：`Input("服务地址（自动补全 /chat/completions）", options.Endpoint, "AiEndpoint")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input("服务地址（自动补全 /chat/completions）", options.Endpoint, "AiEndpoint")`
- `Input(string, string, string)`；输入表达式：`Input("模型名称", options.Model, "AiModel")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Input("模型名称", options.Model, "AiModel")`
- `InvalidateModels()`；输入表达式：`InvalidateModels()`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateModels();`
- `InvalidateModels()`；输入表达式：`InvalidateModels()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => InvalidateModels()`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`AiService.FailureReason(e)`；返回值紧邻使用处：`AssignmentExpressionSyntax: details.Text = AiService.FailureReason(e)`
- `NationalSpire.AiService.FetchModelsAsync(string, string?)`；输入表达式：`AiService.FetchModelsAsync(address, credential)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.FetchModelsAsync(address, credential)`
- `NationalSpire.AiService.PersistKey(string)`；输入表达式：`AiService.PersistKey("")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.PersistKey("")`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Name = "AiFetchModels", Text = "获取模型列表", CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Name = "AiFetchModels", Text = "获取模型列表", CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });`
- `NationalSpire.PlayerFacingText.AiStatus(string)`；输入表达式：`PlayerFacingText.AiStatus(AiService.Status)`；返回值紧邻使用处：`BinaryExpressionSyntax: "当前状态：" + PlayerFacingText.AiStatus(AiService.Status)`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("每次最多生成帖子数", "AiNewsPostCount", options.MaxNewsPosts, 1, AiOptions.MaximumNewsPostCount, value => options.MaxNewsPosts = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("每次最多生成帖子数", "AiNewsPostCount", options.MaxNewsPosts, 1, AiOptions.MaximumNewsPostCount, value => options.MaxNewsPosts = value);`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("请求发送间隔 · 秒，0 表示无需间隔", "AiRequestInterval", options.MinimumIntervalSeconds, 0, 300, value => options.MinimumIntervalSeconds = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("请求发送间隔 · 秒，0 表示无需间隔", "AiRequestInterval", options.MinimumIntervalSeconds, 0, 300, value => options.MinimumIntervalSeconds = value);`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("最大并发数", "AiConcurrency", options.MaxConcurrentRequests, 1, 16, value => options.MaxConcurrentRequests = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("最大并发数", "AiConcurrency", options.MaxConcurrentRequests, 1, 16, value => options.MaxConcurrentRequests = value);`
- `Number(string, string, int, int, int, System.Action<int>)`；输入表达式：`Number("最长等待时间 · 分钟", "AiTimeout", options.RequestTimeoutMinutes, 2, 30, value => options.RequestTimeoutMinutes = value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("最长等待时间 · 分钟", "AiTimeout", options.RequestTimeoutMinutes, 2, 30, value => options.RequestTimeoutMinutes = value);`
- `Save()`；输入表达式：`Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: Save();`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key.Text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(key.Text)`
- `string.Trim()`；输入表达式：`endpoint.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.Endpoint = endpoint.Text.Trim()`
- `string.Trim()`；输入表达式：`endpoint.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = endpoint.Text.Trim()`
- `string.Trim()`；输入表达式：`model.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.Model = model.Text.Trim()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: editing?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`generate()`；返回值紧邻使用处：`ExpressionStatementSyntax: generate();`
- `System.Action.Invoke()`；输入表达式：`save()`；返回值紧邻使用处：`ExpressionStatementSyntax: save();`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置已保存，请填写 API 密钥。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置已保存，请填写 API 密钥。", true);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置已保存。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置已保存。", false);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice(e.Message, true);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice(error ?? "本机密钥已删除。", error != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice(error ?? "本机密钥已删除。", error != null);`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写有效的服务地址和模型名称。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写有效的服务地址和模型名称。");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Func<bool>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Func<bool>>()`
- `System.Exception.GetType()`；输入表达式：`e.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetType().Name`
- `System.Func<TResult>.Invoke()`；输入表达式：`commit()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !commit()`
- `System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；输入表达式：`Uri.TryCreate(options.Endpoint, UriKind.Absolute, out var uri)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Uri.TryCreate(options.Endpoint, UriKind.Absolute, out var uri)`
- `Text(string)`；输入表达式：`Text("按待生成事件选取，不足时不会凑数。数量越多，生成时间和用量通常越高；默认 3 篇。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Text("按待生成事件选取，不足时不会凑数。数量越多，生成时间和用量通常越高；默认 3 篇。");`
- `Text(string)`；输入表达式：`Text("当前状态：" + PlayerFacingText.AiStatus(AiService.Status))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("当前状态：" + PlayerFacingText.AiStatus(AiService.Status))`
- `Text(string)`；输入表达式：`Text("使用当前填写的密钥查询，留空时使用已保存密钥。")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("使用当前填写的密钥查询，留空时使用已保存密钥。")`
- `Text(string)`；输入表达式：`Text("API 密钥（加密保存在本机）")`；返回值紧邻使用处：`ExpressionStatementSyntax: Text("API 密钥（加密保存在本机）");`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `options.Enabled`
- `CustomMinimumSize` = `new(0, 110)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(0, 46)`
- `CustomMinimumSize` = `new(220, 48)`
- `details.Text` = `AiService.FailureReason(e)`
- `details.Visible` = `false`
- `details.Visible` = `true`
- `Editable` = `false`
- `enabled.Toggled` += `value => { editing?.Invoke(); options.Enabled = value; Save(); }`
- `endpoint.TextChanged` += `_ => InvalidateModels()`
- `fetch.Disabled` = `false`
- `fetch.Disabled` = `true`
- `fetch.Pressed` += `async () =>          {              if (fetch.Disabled) return;              editing?.Invoke();              int revision = queryRevision; string address = endpoint.Text.Trim(), credential = key.Text;              fetch.Disabled = true; fetch.Text = "正在获取…"; modelStatus.Text = "正在查询模型列表…"; details.Visible = false;              bool Current() => GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion() && fetch.IsInsideTree() && revision == queryRevision;              try              {                  var result = await AiService.FetchModelsAsync(address, credential);                  if (!Current()) return;                  models = result; filter.Text = ""; FilterModels(); modelChoices.Visible = models.Count > 0;                  modelStatus.Text = models.Count == 0 ? "接口返回的模型列表为空，可手动填写模型名称。" : $"已获取 {models.Count} 个模型，支持搜索选择。";              }              catch (Exception e)              {                  if (!Current()) return;                  modelStatus.Text = "获取失败，详情如下。也可手动填写模型名称。";                  details.Text = AiService.FailureReason(e); details.Visible = true;              }              finally              {                  if (GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()) { fetch.Disabled = false; fetch.Text = "获取模型列表"; }              }          }`
- `fetch.Text` = `"获取模型列表"`
- `fetch.Text` = `"正在获取…"`
- `filter.Text` = `""`
- `filter.TextChanged` += `_ => FilterModels()`
- `FitToLongestItem` = `false`
- `key.PlaceholderText` = `"请输入 API 密钥"`
- `key.Text` = `""`
- `key.TextChanged` += `_ => editing?.Invoke()`
- `key.TextChanged` += `_ => InvalidateModels()`
- `key` = `new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasKey ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) }`
- `model.Text` = `filtered[(int)index - 1]`
- `modelChoices.Visible` = `models.Count > 0`
- `models` = `result`
- `modelStatus.Name` = `"AiModelStatus"`
- `modelStatus.Text` = `"获取失败，详情如下。也可手动填写模型名称。"`
- `modelStatus.Text` = `"已填入模型名称，点击保存后生效。"`
- `modelStatus.Text` = `"正在查询模型列表…"`
- `modelStatus.Text` = `models.Count == 0 ? "接口返回的模型列表为空，可手动填写模型名称。" : $"已获取 {models.Count} 个模型，支持搜索选择。"`
- `Name` = `"AiFetchModels"`
- `Name` = `"AiKey"`
- `Name` = `"AiModelError"`
- `Name` = `"AiModelFilter"`
- `Name` = `"AiModelList"`
- `options.Enabled` = `value`
- `options.Endpoint` = `endpoint.Text.Trim()`
- `options.MaxConcurrentRequests` = `value`
- `options.MaxNewsPosts` = `value`
- `options.MinimumIntervalSeconds` = `value`
- `options.Model` = `model.Text.Trim()`
- `options.RequestTimeoutMinutes` = `value`
- `picker.ItemSelected` += `index =>          {              if (index < 1 || index > filtered.Length) return;              model.Text = filtered[(int)index - 1]; editing?.Invoke(); modelStatus.Text = "已填入模型名称，点击保存后生效。";          }`
- `PlaceholderText` = `"搜索模型"`
- `PlaceholderText` = `AiService.HasKey ? "已保存，留空保留当前密钥" : "请输入 API 密钥"`
- `Secret` = `true`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ShrinkBegin`
- `Text` = `"获取模型列表"`
- `Text` = `"启用 AI 社区"`
- `valid` = `false`
- `Visible` = `false`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-1f1961594be0"></a>

## `Text(string) — Label Text(string value)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Input(string, string, string)`](AiSettingsPanel.cs.md#symbol-e0565c8b5a2a)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)；[`Number(string, string, int, int, int, System.Action<int>)`](AiSettingsPanel.cs.md#symbol-a53cee6ac550)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(label);`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-267b46013d75"></a>

## `Button(string, System.Action) — void Button(string title, Action action)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(220, 48)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text = title, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text = title, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin }`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(220, 48)`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ShrinkBegin`
- `Text` = `title`

<a id="symbol-fbc778bc683b"></a>

## `Save() — void Save()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit()`](AiSettingsPanel.cs.md#symbol-e1359e995417)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** `System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action.Invoke()`；输入表达式：`save()`；返回值紧邻使用处：`ExpressionStatementSyntax: save();`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置未能保存：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置未能保存：" + e.Message, true);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e0565c8b5a2a"></a>

## `Input(string, string, string) — LineEdit Input(string title, string value, string name)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** [`Text(string)`](AiSettingsPanel.cs.md#symbol-1f1961594be0)；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: editing?.Invoke()`
- `Text(string)`；输入表达式：`Text(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: Text(title);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 42)`
- `input.TextChanged` += `_ => editing?.Invoke()`
- `Name` = `name`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-a53cee6ac550"></a>

## `Number(string, string, int, int, int, System.Action<int>) — void Number(string title, string name, int value, int min, int max, Action<int> update)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** [`Commit()`](AiSettingsPanel.cs.md#symbol-e1359e995417)；[`Text(string)`](AiSettingsPanel.cs.md#symbol-1f1961594be0)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`NationalSpire.BroadcastButton.BroadcastButton()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Commit()`；`Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit();`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Commit()`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Commit()`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Commit()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = saved.ToString(), CustomMinimumSize = new(150, 44), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = saved.ToString(), CustomMinimumSize = new(150, 44), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
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

<a id="symbol-e1359e995417"></a>

## `Commit() — bool Commit()`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Number(string, string, int, int, int, System.Action<int>)`](AiSettingsPanel.cs.md#symbol-a53cee6ac550)

**调用：** [`Save()`](AiSettingsPanel.cs.md#symbol-fbc778bc683b)；`int.ToString()`；`int.TryParse(string?, out int)`；`string.Trim()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

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

<a id="symbol-b768a66bdbcb"></a>

## `CommitKey() — void CommitKey()`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** [`NationalSpire.AiService.PersistKey(string)`](AiService.cs.md#symbol-1db4f1f2513d)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `<anonymous type: string source>.source`；`NationalSpire.AiService.PersistKey(string)`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PersistKey(string)`；输入表达式：`AiService.PersistKey(key.Text.Trim())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.PersistKey(key.Text.Trim())`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.credential.commit", new { source = "save-button" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.credential.commit", new { source = "save-button" });`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: key == null || string.IsNullOrWhiteSpace(key.Text)`
- `string.Trim()`；输入表达式：`key.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: key.Text.Trim()`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice(error, true);`

**赋值（含属性/字段和局部值）：**

- `key.PlaceholderText` = `error == null ? "已保存，留空保留当前密钥" : "已暂存，本次启动可用"`
- `key.Text` = `""`

<a id="symbol-24d96ada4dab"></a>

## `FilterModels() — void FilterModels()`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

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

<a id="symbol-c6418f8cdbe2"></a>

## `InvalidateModels() — void InvalidateModels()`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `details.Visible` = `false`
- `modelChoices.Visible` = `false`
- `models` = `[]`
- `modelStatus.Text` = `"地址或密钥已修改，请重新获取模型列表。"`

<a id="symbol-042dcd65a46f"></a>

## `Current() — bool Current()`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string)`](AiSettingsPanel.cs.md#symbol-f3d78e0ed656)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(fetch)`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`fetch.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fetch.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`fetch.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion() && fetch.IsInsideTree()`

**赋值（含属性/字段和局部值）：**
