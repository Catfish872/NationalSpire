# CareerFilePicker.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`43CD0F9F1D003322582595F7B7A6D95DF4541CC086CF122BE6B587258C51C470`。来源：[源码](../../CareerFilePicker.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private string _filePickerDirectory = PromptTransfer.Desktop;
```

<a id="symbol-e74b66910ad6"></a>

## `NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>) — private void OpenFilePicker(string title, string[] extensions, Action<string> selected)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.OpenPromptImport(NationalSpire.CareerData, System.Action)`](PromptScreen.cs.md#symbol-f1958720b9f6)

**调用：** [`Complete()`](CareerFilePicker.cs.md#symbol-030f76cc1393)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`](CareerDialog.cs.md#symbol-ecc011933bb1)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Navigate(string, bool)`](CareerFilePicker.cs.md#symbol-5b46b0bdcf0c)；[`Refresh()`](CareerFilePicker.cs.md#symbol-5b755bd864b3)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.ItemList.ItemList()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.Vector2.Vector2(float, float)`；`string.Join(string?, params string?[])`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.Stack<T>.Pop()`；`System.Collections.Generic.Stack<T>.Stack()`；`System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；`System.IO.Directory.GetParent(string)`；`System.IO.DriveInfo.GetDrives()`；`System.IO.File.Exists(string?)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `(string Path, bool Directory).Directory`；`(string Path, bool Directory).Path`；`Complete()`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._filePickerDirectory`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.PromptTransfer.Desktop`；`Navigate(string, bool)`；`Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Complete()`；输入表达式：`Complete()`；返回值紧邻使用处：`ExpressionStatementSyntax: Complete();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`list.AddThemeColorOverride("font_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeColorOverride("font_color", _ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`nav.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.ItemList.ItemList()`；输入表达式：`new ItemList { Name = "FilePickerList", CustomMinimumSize = new(0, 340), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: list = new ItemList { Name = "FilePickerList", CustomMinimumSize = new(0, 340), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "FilePickerLocation", Editable = false, CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: location = new LineEdit { Name = "FilePickerLocation", Editable = false, CustomMinimumSize = new(0, 42) }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "FilePickerSearch", PlaceholderText = "搜索当前文件夹中的名称", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: search = new LineEdit { Name = "FilePickerSearch", PlaceholderText = "搜索当前文件夹中的名称", CustomMinimumSize = new(0, 42) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(location)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(location);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(nav)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(nav);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(Button("桌面", () => Navigate(PromptTransfer.Desktop), 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(Button("桌面", () => Navigate(PromptTransfer.Desktop), 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(drives)`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(drives);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`drives.AddItem("选择磁盘")`；返回值紧邻使用处：`ExpressionStatementSyntax: drives.AddItem("选择磁盘");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`drives.AddItem(root)`；返回值紧邻使用处：`ExpressionStatementSyntax: drives.AddItem(root);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "FilePickerDrive", CustomMinimumSize = new(150, 48), FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "FilePickerDrive", CustomMinimumSize = new(150, 48), FitToLongestItem = false }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 340)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 340)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(900, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(900, 0)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100)`；返回值紧邻使用处：`ArgumentSyntax: Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120)`；返回值紧邻使用处：`ArgumentSyntax: Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100)`；返回值紧邻使用处：`ArgumentSyntax: Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100)`；返回值紧邻使用处：`ArgumentSyntax: Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("桌面", () => Navigate(PromptTransfer.Desktop), 100)`；返回值紧邻使用处：`ArgumentSyntax: Button("桌面", () => Navigate(PromptTransfer.Desktop), 100)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；输入表达式：`ShowCareerDialog(title, "浏览文件夹并选择文件。支持 " + string.Join("、", extensions), () =>         {             if (chosen.Length == 0 || !File.Exists(chosen)) { status.Text = "请先选中一个文件。"; return false; }             Complete(); return true;         }, "选择文件", box =>         {             box.Name = "CareerFilePicker"; box.CustomMinimumSize = new(900, 0); box.AddThemeConstantOverride("separation", 12);             var nav = new HBoxContainer(); nav.AddThemeConstantOverride("separation", 10); box.AddChild(nav);             nav.AddChild(Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100));             nav.AddChild(Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120));             var drives = new OptionButton { Name = "FilePickerDrive", CustomMinimumSize = new(150, 48), FitToLongestItem = false }; nav.AddChild(drives);             var roots = DriveInfo.GetDrives().Select(d => d.Name).ToArray();             drives.AddItem("选择磁盘"); foreach (string root in roots) drives.AddItem(root);             drives.ItemSelected += index => { if (index > 0) Navigate(roots[index - 1]); };             nav.AddChild(Button("桌面", () => Navigate(PromptTransfer.Desktop), 100));             nav.AddChild(Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100));             nav.AddChild(Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100));             location = new LineEdit { Name = "FilePickerLocation", Editable = false, CustomMinimumSize = new(0, 42) }; box.AddChild(location);             search = new LineEdit { Name = "FilePickerSearch", PlaceholderText = "搜索当前文件夹中的名称", CustomMinimumSize = new(0, 42) }; box.AddChild(search);             list = new ItemList { Name = "FilePickerList", CustomMinimumSize = new(0, 340), SizeFlagsHorizontal = SizeFlags.ExpandFill };             list.AddThemeFontSizeOverride("font_size", 18); list.AddThemeColorOverride("font_color", _ink); box.AddChild(list);             status = Text("", 16, _muted); box.AddChild(status);             list.ItemSelected += index => { chosen = entries[(int)index].Directory ? "" : entries[(int)index].Path; status.Text = chosen.Length == 0 ? "双击进入文件夹。" : "已选择 " + Path.GetFileName(chosen); };             list.ItemActivated += index =>             {                 var entry = entries[(int)index];                 if (entry.Directory) Navigate(entry.Path);                 else { chosen = entry.Path; _cancelDialog?.Invoke(); Complete(); }             };             search.TextChanged += _ => Refresh(); Refresh();         })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(title, "浏览文件夹并选择文件。支持 " + string.Join("、", extensions), () =>         {             if (chosen.Length == 0 || !File.Exists(chosen)) { status.Text = "请先选中一个文件。"; return false; }             Complete(); return true;         }, "选择文件", box =>         {             box.Name = "CareerFilePicker"; box.CustomMinimumSize = new(900, 0); box.AddThemeConstantOverride("separation", 12);             var nav = new HBoxContainer(); nav.AddThemeConstantOverride("separation", 10); box.AddChild(nav);             nav.AddChild(Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100));             nav.AddChild(Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120));             var drives = new OptionButton { Name = "FilePickerDrive", CustomMinimumSize = new(150, 48), FitToLongestItem = false }; nav.AddChild(drives);             var roots = DriveInfo.GetDrives().Select(d => d.Name).ToArray();             drives.AddItem("选择磁盘"); foreach (string root in roots) drives.AddItem(root);             drives.ItemSelected += index => { if (index > 0) Navigate(roots[index - 1]); };             nav.AddChild(Button("桌面", () => Navigate(PromptTransfer.Desktop), 100));             nav.AddChild(Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100));             nav.AddChild(Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100));             location = new LineEdit { Name = "FilePickerLocation", Editable = false, CustomMinimumSize = new(0, 42) }; box.AddChild(location);             search = new LineEdit { Name = "FilePickerSearch", PlaceholderText = "搜索当前文件夹中的名称", CustomMinimumSize = new(0, 42) }; box.AddChild(search);             list = new ItemList { Name = "FilePickerList", CustomMinimumSize = new(0, 340), SizeFlagsHorizontal = SizeFlags.ExpandFill };             list.AddThemeFontSizeOverride("font_size", 18); list.AddThemeColorOverride("font_color", _ink); box.AddChild(list);             status = Text("", 16, _muted); box.AddChild(status);             list.ItemSelected += index => { chosen = entries[(int)index].Directory ? "" : entries[(int)index].Path; status.Text = chosen.Length == 0 ? "双击进入文件夹。" : "已选择 " + Path.GetFileName(chosen); };             list.ItemActivated += index =>             {                 var entry = entries[(int)index];                 if (entry.Directory) Navigate(entry.Path);                 else { chosen = entry.Path; _cancelDialog?.Invoke(); Complete(); }             };             search.TextChanged += _ => Refresh(); Refresh();         });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("", 16, _muted)`
- `Navigate(string, bool)`；输入表达式：`Navigate(Directory.GetParent(folder)?.FullName ?? folder)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Navigate(Directory.GetParent(folder)?.FullName ?? folder)`
- `Navigate(string, bool)`；输入表达式：`Navigate(entry.Path)`；返回值紧邻使用处：`ExpressionStatementSyntax: Navigate(entry.Path);`
- `Navigate(string, bool)`；输入表达式：`Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))`
- `Navigate(string, bool)`；输入表达式：`Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))`
- `Navigate(string, bool)`；输入表达式：`Navigate(history.Pop(), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Navigate(history.Pop(), false);`
- `Navigate(string, bool)`；输入表达式：`Navigate(PromptTransfer.Desktop)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Navigate(PromptTransfer.Desktop)`
- `Navigate(string, bool)`；输入表达式：`Navigate(roots[index - 1])`；返回值紧邻使用处：`ExpressionStatementSyntax: Navigate(roots[index - 1]);`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Refresh()`
- `string.Join(string?, params string?[])`；输入表达式：`string.Join("、", extensions)`；返回值紧邻使用处：`BinaryExpressionSyntax: "浏览文件夹并选择文件。支持 " + string.Join("、", extensions)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DriveInfo.GetDrives().Select(d => d.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DriveInfo.GetDrives().Select(d => d.Name).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`DriveInfo.GetDrives().Select(d => d.Name).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DriveInfo.GetDrives().Select(d => d.Name).ToArray()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Path, bool Directory)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Path, bool Directory)>()`
- `System.Collections.Generic.Stack<T>.Pop()`；输入表达式：`history.Pop()`；返回值紧邻使用处：`ArgumentSyntax: history.Pop()`
- `System.Collections.Generic.Stack<T>.Stack()`；输入表达式：`new Stack<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Stack<string>()`
- `System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；输入表达式：`Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)`；返回值紧邻使用处：`ArgumentSyntax: Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)`
- `System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；输入表达式：`Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)`；返回值紧邻使用处：`ArgumentSyntax: Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)`
- `System.IO.Directory.GetParent(string)`；输入表达式：`Directory.GetParent(folder)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Directory.GetParent(folder)?.FullName`
- `System.IO.DriveInfo.GetDrives()`；输入表达式：`DriveInfo.GetDrives()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DriveInfo.GetDrives().Select`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(chosen)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(chosen)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(chosen)`；返回值紧邻使用处：`BinaryExpressionSyntax: "已选择 " + Path.GetFileName(chosen)`

**赋值（含属性/字段和局部值）：**

- `box.CustomMinimumSize` = `new(900, 0)`
- `box.Name` = `"CareerFilePicker"`
- `chosen` = `entries[(int)index].Directory ? "" : entries[(int)index].Path`
- `chosen` = `entry.Path`
- `CustomMinimumSize` = `new(0, 340)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(150, 48)`
- `drives.ItemSelected` += `index => { if (index > 0) Navigate(roots[index - 1]); }`
- `Editable` = `false`
- `FitToLongestItem` = `false`
- `list.ItemActivated` += `index =>             {                 var entry = entries[(int)index];                 if (entry.Directory) Navigate(entry.Path);                 else { chosen = entry.Path; _cancelDialog?.Invoke(); Complete(); }             }`
- `list.ItemSelected` += `index => { chosen = entries[(int)index].Directory ? "" : entries[(int)index].Path; status.Text = chosen.Length == 0 ? "双击进入文件夹。" : "已选择 " + Path.GetFileName(chosen); }`
- `list` = `new ItemList { Name = "FilePickerList", CustomMinimumSize = new(0, 340), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `location` = `new LineEdit { Name = "FilePickerLocation", Editable = false, CustomMinimumSize = new(0, 42) }`
- `Name` = `"FilePickerDrive"`
- `Name` = `"FilePickerList"`
- `Name` = `"FilePickerLocation"`
- `Name` = `"FilePickerSearch"`
- `PlaceholderText` = `"搜索当前文件夹中的名称"`
- `search.TextChanged` += `_ => Refresh()`
- `search` = `new LineEdit { Name = "FilePickerSearch", PlaceholderText = "搜索当前文件夹中的名称", CustomMinimumSize = new(0, 42) }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `status.Text` = `"请先选中一个文件。"`
- `status.Text` = `chosen.Length == 0 ? "双击进入文件夹。" : "已选择 " + Path.GetFileName(chosen)`
- `status` = `Text("", 16, _muted)`

<a id="symbol-5b755bd864b3"></a>

## `Refresh() — void Refresh()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-e74b66910ad6)；[`Navigate(string, bool)`](CareerFilePicker.cs.md#symbol-5b46b0bdcf0c)

**调用：** `Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；`Godot.ItemList.Clear()`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Clear()`；`System.IO.Directory.EnumerateDirectories(string)`；`System.IO.Directory.EnumerateFiles(string)`；`System.IO.File.GetAttributes(string)`；`System.IO.Path.GetExtension(string?)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `(string Path, bool Directory).Directory`；`(string Path, bool Directory).Path`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ItemList.AddItem(string, Godot.Texture2D, bool)`；输入表达式：`list.AddItem((entry.Directory ? "▸  " : "     ") + Path.GetFileName(entry.Path))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddItem((entry.Directory ? "▸  " : "     ") + Path.GetFileName(entry.Path));`
- `Godot.ItemList.Clear()`；输入表达式：`list.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Clear();`
- `string.Contains(string, System.StringComparison)`；输入表达式：`Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = search.Text.Trim()`
- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select`
- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`extensions.Contains(Path.GetExtension(p), StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => extensions.Contains(Path.GetExtension(p), StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true)).Take(2000)`；返回值紧邻使用处：`ArgumentSyntax: dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true)).Take(2000)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false)).Take(2000)`；返回值紧邻使用处：`ArgumentSyntax: files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false)).Take(2000)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Directory.EnumerateDirectories(folder).Where(p => (File.GetAttributes(p) & FileAttributes.Hidden) == 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Directory.EnumerateDirectories(folder).Where(p => (File.GetAttributes(p) & FileAttributes.Hidden) == 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Directory.EnumerateFiles(folder).Where(p => extensions.Contains(Path.GetExtension(p), StringComparer.OrdinalIgnoreCase))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Directory.EnumerateFiles(folder).Where(p => extensions.Contains(Path.GetExtension(p), StringComparer.OrdinalIgnoreCase))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`entries.AddRange(dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true)).Take(2000))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.AddRange(dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true)).Take(2000));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`entries.AddRange(files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false)).Take(2000))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.AddRange(files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false)).Take(2000));`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`entries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.Clear();`
- `System.IO.Directory.EnumerateDirectories(string)`；输入表达式：`Directory.EnumerateDirectories(folder)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateDirectories(folder).Where`
- `System.IO.Directory.EnumerateFiles(string)`；输入表达式：`Directory.EnumerateFiles(folder)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateFiles(folder).Where`
- `System.IO.File.GetAttributes(string)`；输入表达式：`File.GetAttributes(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: File.GetAttributes(p) & FileAttributes.Hidden`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(p)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetExtension(p)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(entry.Path)`；返回值紧邻使用处：`BinaryExpressionSyntax: (entry.Directory ? "▸  " : "     ") + Path.GetFileName(entry.Path)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetFileName(p).Contains`

**赋值（含属性/字段和局部值）：**

- `chosen` = `""`
- `location.Text` = `folder`
- `status.Text` = `"无法访问此文件夹，请选择其他位置。"`
- `status.Text` = `entries.Count == 0 ? "此文件夹没有匹配的文件。" : "双击文件夹进入，选中文件后点击“选择文件”。"`

<a id="symbol-5b46b0bdcf0c"></a>

## `Navigate(string, bool) — void Navigate(string path, bool remember = true)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-e74b66910ad6)

**调用：** [`Refresh()`](CareerFilePicker.cs.md#symbol-5b755bd864b3)；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.Stack<T>.Push(T)`

**字段、属性、事件及方法组引用：** `Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(path)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(path)) return;`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`history.Push(folder)`；返回值紧邻使用处：`ExpressionStatementSyntax: history.Push(folder);`

**赋值（含属性/字段和局部值）：**

- `folder` = `path`
- `search.Text` = `""`

<a id="symbol-030f76cc1393"></a>

## `Complete() — void Complete()`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-e74b66910ad6)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._filePickerDirectory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) selected(path); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) selected(path); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) selected(path); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) selected(path); }).CallDeferred`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && !IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsQueuedForDeletion()`
- `System.Action<T>.Invoke(T)`；输入表达式：`selected(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: selected(path);`

**赋值（含属性/字段和局部值）：**

- `_filePickerDirectory` = `folder`
