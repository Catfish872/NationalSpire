# DateSceneBackgroundScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D1D6D6A30E0FA63A13719D8C93D3FBC4A3981594198B7ADFB213168512D7D16C`。来源：[源码](../../DateSceneBackgroundScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-887a25fb10fa"></a>

## `NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string) — private void OpenDateBackgroundLibrary(CareerData data, string person)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)

**调用：** [`Choices()`](DateSceneBackgroundScreen.cs.md#symbol-310f36e34c8c)；[`Commit()`](DateSceneBackgroundScreen.cs.md#symbol-b8afde8353d5)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-ca0ccac08c64)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.Remove(string)`](DateSceneBackgrounds.cs.md#symbol-b7d6d0097052)；[`Preview()`](DateSceneBackgroundScreen.cs.md#symbol-1531e6366b73)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.OptionButton()`；`Godot.TextEdit.TextEdit()`；`Godot.TextureRect.TextureRect()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `Choices()`；`Commit()`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.Import(string)`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；`NationalSpire.DateSceneBackgrounds.Remove(string)`；`Preview()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choices()`；输入表达式：`Choices()`；返回值紧邻使用处：`ExpressionStatementSyntax: Choices();`
- `Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit();`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 16);`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: texture?.Dispose()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && CareerStore.IsCurrent(data)`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(import)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(import);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(remove)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(remove);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateBackgroundLibraryChoice", CustomMinimumSize = new(0, 44), FitToLongestItem = false }`；返回值紧邻使用处：`AssignmentExpressionSyntax: choices = new OptionButton { Name = "DateBackgroundLibraryChoice", CustomMinimumSize = new(0, 44), FitToLongestItem = false }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "DateBackgroundDescription", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary, PlaceholderText = "例如：海边步道，傍晚，夕阳，晴天，室外" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: description = new TextEdit { Name = "DateBackgroundDescription", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary, PlaceholderText = "例如：海边步道，傍晚，夕阳，晴天，室外" }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { CustomMinimumSize = new(0, 180), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview = new TextureRect { CustomMinimumSize = new(0, 180), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 180)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 90)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 90)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(820, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(820, 0)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入背景图片 / 背景包 ZIP", () =>              {                  try { Commit(); } catch (Exception e) { status.Text = e.Message; return; }                  PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>                  {                      try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }                      catch (Exception e) { status.Text = "导入失败：" + e.Message; }                  });              }, 360)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("导入背景图片 / 背景包 ZIP", () =>              {                  try { Commit(); } catch (Exception e) { status.Text = e.Message; return; }                  PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>                  {                      try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }                      catch (Exception e) { status.Text = "导入失败：" + e.Message; }                  });              }, 360)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除所选背景", () =>              {                  try { DateSceneBackgrounds.Remove(selected); items = DateSceneBackgrounds.Read(out _); status.Text = "所选背景已从背景库移除。"; Choices(); }                  catch (Exception e) { status.Text = e.Message; }              }, 220)`；返回值紧邻使用处：`AssignmentExpressionSyntax: remove = Button("删除所选背景", () =>              {                  try { DateSceneBackgrounds.Remove(selected); items = DateSceneBackgrounds.Read(out _); status.Text = "所选背景已从背景库移除。"; Choices(); }                  catch (Exception e) { status.Text = e.Message; }              }, 220)`
- `NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`；输入表达式：`OpenDateAssets(data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateAssets(data, person);`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>)`；输入表达式：`PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>                  {                      try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }                      catch (Exception e) { status.Text = "导入失败：" + e.Message; }                  })`；返回值紧邻使用处：`ExpressionStatementSyntax: PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>                  {                      try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }                      catch (Exception e) { status.Text = "导入失败：" + e.Message; }                  });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("背景库", "各角色共用。文件名作为背景ID，说明可填写地点、室内外、时间和天气，供场景匹配使用。", () =>          {              try { Commit(); } catch (Exception e) { status.Text = e.Message; return false; }              Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred(); return true;          }, "返回立绘与场景", box =>          {              box.Name = "DateBackgroundLibrary"; box.CustomMinimumSize = new(820, 0);              var import = Button("导入背景图片 / 背景包 ZIP", () =>              {                  try { Commit(); } catch (Exception e) { status.Text = e.Message; return; }                  PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>                  {                      try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }                      catch (Exception e) { status.Text = "导入失败：" + e.Message; }                  });              }, 360); import.Name = "DateBackgroundImport";              var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); box.AddChild(actions); actions.AddChild(import);              remove = Button("删除所选背景", () =>              {                  try { DateSceneBackgrounds.Remove(selected); items = DateSceneBackgrounds.Read(out _); status.Text = "所选背景已从背景库移除。"; Choices(); }                  catch (Exception e) { status.Text = e.Message; }              }, 220); remove.Name = "DateBackgroundDelete"; actions.AddChild(remove);              choices = new OptionButton { Name = "DateBackgroundLibraryChoice", CustomMinimumSize = new(0, 44), FitToLongestItem = false }; box.AddChild(choices);              preview = new TextureRect { CustomMinimumSize = new(0, 180), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }; box.AddChild(preview);              description = new TextEdit { Name = "DateBackgroundDescription", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary, PlaceholderText = "例如：海边步道，傍晚，夕阳，晴天，室外" }; box.AddChild(description);              choices.ItemSelected += index => { try { Commit(); selected = items[(int)index].Id; Preview(); } catch (Exception e) { status.Text = e.Message; } };              status = Text(warning, 15, _muted); box.AddChild(status); Choices();          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("背景库", "各角色共用。文件名作为背景ID，说明可填写地点、室内外、时间和天气，供场景匹配使用。", () =>          {              try { Commit(); } catch (Exception e) { status.Text = e.Message; return false; }              Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred(); return true;          }, "返回立绘与场景", box =>          {              box.Name = "DateBackgroundLibrary"; box.CustomMinimumSize = new(820, 0);              var import = Button("导入背景图片 / 背景包 ZIP", () =>              {                  try { Commit(); } catch (Exception e) { status.Text = e.Message; return; }                  PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>                  {                      try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }                      catch (Exception e) { status.Text = "导入失败：" + e.Message; }                  });              }, 360); import.Name = "DateBackgroundImport";              var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); box.AddChild(actions); actions.AddChild(import);              remove = Button("删除所选背景", () =>              {                  try { DateSceneBackgrounds.Remove(selected); items = DateSceneBackgrounds.Read(out _); status.Text = "所选背景已从背景库移除。"; Choices(); }                  catch (Exception e) { status.Text = e.Message; }              }, 220); remove.Name = "DateBackgroundDelete"; actions.AddChild(remove);              choices = new OptionButton { Name = "DateBackgroundLibraryChoice", CustomMinimumSize = new(0, 44), FitToLongestItem = false }; box.AddChild(choices);              preview = new TextureRect { CustomMinimumSize = new(0, 180), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }; box.AddChild(preview);              description = new TextEdit { Name = "DateBackgroundDescription", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary, PlaceholderText = "例如：海边步道，傍晚，夕阳，晴天，室外" }; box.AddChild(description);              choices.ItemSelected += index => { try { Commit(); selected = items[(int)index].Id; Preview(); } catch (Exception e) { status.Text = e.Message; } };              status = Text(warning, 15, _muted); box.AddChild(status); Choices();          }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(warning, 15, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text(warning, 15, _muted)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && CareerStore.IsCurrent(data)`
- `NationalSpire.DateSceneBackgrounds.Import(string)`；输入表达式：`DateSceneBackgrounds.Import(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: selected = DateSceneBackgrounds.Import(path)`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out _)`；返回值紧邻使用处：`AssignmentExpressionSyntax: items = DateSceneBackgrounds.Read(out _)`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out string issues)`；返回值紧邻使用处：`AssignmentExpressionSyntax: items = DateSceneBackgrounds.Read(out string issues)`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out string warning)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneBackgrounds.Read(out string warning)`
- `NationalSpire.DateSceneBackgrounds.Remove(string)`；输入表达式：`DateSceneBackgrounds.Remove(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneBackgrounds.Remove(selected);`
- `Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`items.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: items.FirstOrDefault()?.Id`

**赋值（含属性/字段和局部值）：**

- `_dialogOverlay.TreeExiting` += `() => { texture?.Dispose(); texture = null; }`
- `box.CustomMinimumSize` = `new(820, 0)`
- `box.Name` = `"DateBackgroundLibrary"`
- `choices.ItemSelected` += `index => { try { Commit(); selected = items[(int)index].Id; Preview(); } catch (Exception e) { status.Text = e.Message; } }`
- `choices` = `new OptionButton { Name = "DateBackgroundLibraryChoice", CustomMinimumSize = new(0, 44), FitToLongestItem = false }`
- `CustomMinimumSize` = `new(0, 180)`
- `CustomMinimumSize` = `new(0, 44)`
- `CustomMinimumSize` = `new(0, 90)`
- `description` = `new TextEdit { Name = "DateBackgroundDescription", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary, PlaceholderText = "例如：海边步道，傍晚，夕阳，晴天，室外" }`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `FitToLongestItem` = `false`
- `import.Name` = `"DateBackgroundImport"`
- `items` = `DateSceneBackgrounds.Read(out _)`
- `items` = `DateSceneBackgrounds.Read(out string issues)`
- `Name` = `"DateBackgroundDescription"`
- `Name` = `"DateBackgroundLibraryChoice"`
- `PlaceholderText` = `"例如：海边步道，傍晚，夕阳，晴天，室外"`
- `preview` = `new TextureRect { CustomMinimumSize = new(0, 180), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `remove.Name` = `"DateBackgroundDelete"`
- `remove` = `Button("删除所选背景", () =>              {                  try { DateSceneBackgrounds.Remove(selected); items = DateSceneBackgrounds.Read(out _); status.Text = "所选背景已从背景库移除。"; Choices(); }                  catch (Exception e) { status.Text = e.Message; }              }, 220)`
- `selected` = `DateSceneBackgrounds.Import(path)`
- `selected` = `items[(int)index].Id`
- `status.Text` = `"导入失败：" + e.Message`
- `status.Text` = `"所选背景已从背景库移除。"`
- `status.Text` = `e.Message`
- `status.Text` = `issues.Length > 0 ? issues : "导入完成。可填写背景说明。"`
- `status` = `Text(warning, 15, _muted)`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `texture` = `null`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-b8afde8353d5"></a>

## `Commit() — void Commit()`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)

**调用：** [`NationalSpire.DateSceneBackgrounds.Describe(string, string)`](DateSceneBackgrounds.cs.md#symbol-c96b7de63f9b)；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.Describe(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneBackgrounds.Describe(string, string)`；输入表达式：`DateSceneBackgrounds.Describe(selected, description.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneBackgrounds.Describe(selected, description.Text);`
- `string.Trim()`；输入表达式：`description.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Description = description.Text.Trim()`
- `string.Trim()`；输入表达式：`description.Text.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Description == description.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.FirstOrDefault(i => i.Id == selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = items.FirstOrDefault(i => i.Id == selected)`

**赋值（含属性/字段和局部值）：**

- `item.Description` = `description.Text.Trim()`

<a id="symbol-1531e6366b73"></a>

## `Preview() — void Preview()`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choices()`](DateSceneBackgroundScreen.cs.md#symbol-310f36e34c8c)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)

**调用：** [`NationalSpire.DateSceneView.CreateBackground(string)`](DateSceneView.cs.md#symbol-30a197722f91)；`Godot.GodotObject.Dispose()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneView.CreateBackground(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: texture?.Dispose()`
- `NationalSpire.DateSceneView.CreateBackground(string)`；输入表达式：`DateSceneView.CreateBackground(item.Image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: texture = DateSceneView.CreateBackground(item.Image)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.FirstOrDefault(i => i.Id == selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = items.FirstOrDefault(i => i.Id == selected)`

**赋值（含属性/字段和局部值）：**

- `description.Editable` = `item != null`
- `description.Text` = `item?.Description ?? ""`
- `preview.Texture` = `null`
- `preview.Texture` = `texture`
- `status.Text` = `e.Message`
- `texture` = `DateSceneView.CreateBackground(item.Image)`
- `texture` = `null`

<a id="symbol-310f36e34c8c"></a>

## `Choices() — void Choices()`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)

**调用：** [`Preview()`](DateSceneBackgroundScreen.cs.md#symbol-1531e6366b73)；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Id`；`Preview()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem("请导入背景图片或ZIP背景包")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem("请导入背景图片或ZIP背景包");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem(item.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem(item.Id);`
- `Godot.OptionButton.Clear()`；输入表达式：`choices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`choices.Select(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Select(0);`
- `Godot.OptionButton.Select(int)`；输入表达式：`choices.Select(items.FindIndex(i => i.Id == selected))`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Select(items.FindIndex(i => i.Id == selected));`
- `Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.Any(i => i.Id == selected)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !items.Any(i => i.Id == selected)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`items.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: items.FirstOrDefault()?.Id`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`items.FindIndex(i => i.Id == selected)`；返回值紧邻使用处：`ArgumentSyntax: items.FindIndex(i => i.Id == selected)`

**赋值（含属性/字段和局部值）：**

- `choices.Disabled` = `remove.Disabled = items.Count == 0`
- `remove.Disabled` = `items.Count == 0`
- `selected` = `items.FirstOrDefault()?.Id ?? ""`
