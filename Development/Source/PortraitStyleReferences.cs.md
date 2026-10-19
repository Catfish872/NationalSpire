# PortraitStyleReferences.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`512C4C3A97D6AA669356B779605771CA539110591A835F26AD66F9BFF9CF17A2`。来源：[源码](../../PortraitStyleReferences.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PortraitStyleGroup`、`NationalSpire.PortraitStyleImage`、`NationalSpire.PortraitStyleEntry`、`NationalSpire.PortraitStyleReferences`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-b508a6d1d682"></a>

## `NationalSpire.PortraitStyleGroup.Id — public string Id`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "style_" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5be9eb43fca2"></a>

## `NationalSpire.PortraitStyleGroup.Name — public string Name`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7d9a8b67062c"></a>

## `NationalSpire.PortraitStyleGroup.Requirements — public string Requirements`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fee2ea1564ae"></a>

## `NationalSpire.PortraitStyleGroup.PrimaryId — public string PrimaryId`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0638f4727462"></a>

## `NationalSpire.PortraitStyleGroup.Images — public List<PortraitStyleImage> Images`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-00225070cade"></a>

## `NationalSpire.PortraitStyleImage.Id — public string Id`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d5bdac4a0ce6"></a>

## `NationalSpire.PortraitStyleImage.Extension — public string Extension`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e06c1d60adcf"></a>

## `NationalSpire.PortraitStyleImage.Name — public string Name`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1f57f1746340"></a>

## `NationalSpire.PortraitStyleImage.Enabled — public bool Enabled`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-31a5ffe2810f"></a>

## `NationalSpire.PortraitStyleReferences.CacheDirectory — public static string CacheDirectory`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_portraits/references")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_portraits/references")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c0a008243b14"></a>

## `NationalSpire.PortraitStyleReferences.LibraryDirectory — public static string LibraryDirectory`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.OS.GetExecutablePath()`；`Godot.ProjectSettings.GlobalizePath(string)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.IO.File.Exists(string?)`；`System.IO.Path.Combine(params string[])`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.Combine(string, string, string, string)`；`System.IO.Path.GetDirectoryName(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OS.GetExecutablePath()`；输入表达式：`OS.GetExecutablePath()`；返回值紧邻使用处：`ArgumentSyntax: OS.GetExecutablePath()`
- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("res://")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProjectSettings.GlobalizePath("res://")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.FirstOrDefault(p => File.Exists(Path.Combine(p, "library.json")))`；返回值紧邻使用处：`BinaryExpressionSyntax: candidates.FirstOrDefault(p => File.Exists(Path.Combine(p, "library.json"))) ?? candidates[1]`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(Path.Combine(p, "library.json"))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => File.Exists(Path.Combine(p, "library.json"))`
- `System.IO.Path.Combine(params string[])`；输入表达式：`Path.Combine(project, ".godot", "mono", "temp", "bin", "Debug", "portrait-style-library")`；返回值紧邻使用处：`ExpressionElementSyntax: Path.Combine(project, ".godot", "mono", "temp", "bin", "Debug", "portrait-style-library")`
- `System.IO.Path.Combine(params string[])`；输入表达式：`Path.Combine(project, ".godot", "mono", "temp", "bin", "Release", "portrait-style-library")`；返回值紧邻使用处：`ExpressionElementSyntax: Path.Combine(project, ".godot", "mono", "temp", "bin", "Release", "portrait-style-library")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(assembly ?? executable, "portrait-style-library")`；返回值紧邻使用处：`ExpressionElementSyntax: Path.Combine(assembly ?? executable, "portrait-style-library")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(p, "library.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(p, "library.json")`
- `System.IO.Path.Combine(string, string, string, string)`；输入表达式：`Path.Combine(executable, "mods", "NationalSpire", "portrait-style-library")`；返回值紧邻使用处：`ExpressionElementSyntax: Path.Combine(executable, "mods", "NationalSpire", "portrait-style-library")`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(OS.GetExecutablePath())`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetDirectoryName(OS.GetExecutablePath()) ?? AppContext.BaseDirectory`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(typeof(PortraitStyleReferences).Assembly.Location)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetDirectoryName(typeof(PortraitStyleReferences).Assembly.Location)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9378112df23b"></a>

## `NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign) — public static PortraitStyleGroup? Selected(PortraitDesign design)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.Entries(NationalSpire.PortraitDesign)`](PortraitStyleReferences.cs.md#symbol-36810afabe68)；[`NationalSpire.PortraitStyleReferences.Instructions(NationalSpire.PortraitDesign, bool, string)`](PortraitStyleReferences.cs.md#symbol-5a43303b8efd)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.SingleOrDefault<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.SelectedStyleGroup`；`NationalSpire.PortraitDesign.StyleGroups`；`NationalSpire.PortraitStyleGroup.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.SingleOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.StyleGroups.SingleOrDefault(g => g.Id == design.SelectedStyleGroup)`；返回值紧邻使用处：`BinaryExpressionSyntax: design.StyleGroups.SingleOrDefault(g => g.Id == design.SelectedStyleGroup) ?? throw new InvalidDataException("画风参考组已失效，请重新选择。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("画风参考组已失效，请重新选择。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("画风参考组已失效，请重新选择。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2b0f0dd2a172"></a>

## `NationalSpire.PortraitStyleReferences.AddGroup(NationalSpire.PortraitDesign) — public static PortraitStyleGroup AddGroup(PortraitDesign design)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PortraitStyleGroup.PortraitStyleGroup()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.SelectedStyleGroup`；`NationalSpire.PortraitDesign.StyleGroups`；`NationalSpire.PortraitDesign.StyleLibraryInitialized`；`NationalSpire.PortraitStyleGroup.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitStyleGroup.PortraitStyleGroup()`；输入表达式：`new PortraitStyleGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PortraitStyleGroup()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`design.StyleGroups.Add(group)`；返回值紧邻使用处：`ExpressionStatementSyntax: design.StyleGroups.Add(group);`

**赋值（含属性/字段和局部值）：**

- `design.SelectedStyleGroup` = `group.Id`
- `design.StyleLibraryInitialized` = `true`

<a id="symbol-545c98f9afe4"></a>

## `NationalSpire.PortraitStyleReferences.EnsureLibrary(NationalSpire.PortraitDesign, string?) — public static void EnsureLibrary(PortraitDesign design, string? directory = null)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PortraitDesigns.SafeId(string)`](PortraitDesign.cs.md#symbol-7497548faaf1)；[`NationalSpire.PortraitStyleReferences.Bytes(NationalSpire.PortraitStyleImage, string?)`](PortraitStyleReferences.cs.md#symbol-79f6d9abc7df)；[`NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup)`](PortraitStyleReferences.cs.md#symbol-d49e42385613)；[`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-305cedf5de7f)；[`NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`](PortraitStyleReferences.cs.md#symbol-0a6c9f2034e7)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.SelectedStyleGroup`；`NationalSpire.PortraitDesign.StyleGroups`；`NationalSpire.PortraitDesign.StyleLibraryInitialized`；`NationalSpire.PortraitDesigns.Json`；`NationalSpire.PortraitDesigns.SafeId(string)`；`NationalSpire.PortraitStyleGroup.Id`；`NationalSpire.PortraitStyleGroup.Images`；`NationalSpire.PortraitStyleImage.Id`；`NationalSpire.PortraitStyleReferences.Bytes(NationalSpire.PortraitStyleImage, string?)`；`NationalSpire.PortraitStyleReferences.CacheDirectory`；`NationalSpire.PortraitStyleReferences.LibraryDirectory`；`NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup)`；`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`；`NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(g.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(g.Id)`
- `NationalSpire.PortraitStyleReferences.Bytes(NationalSpire.PortraitStyleImage, string?)`；输入表达式：`Bytes(item, Path.Combine(source, "images"))`；返回值紧邻使用处：`ArgumentSyntax: Bytes(item, Path.Combine(source, "images"))`
- `NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup)`；输入表达式：`NormalizePrimary(group)`；返回值紧邻使用处：`ExpressionStatementSyntax: NormalizePrimary(group);`
- `NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`；输入表达式：`ReadBytes(item, CacheDirectory)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ReadBytes(item, CacheDirectory)`
- `NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`；输入表达式：`Store(item, Bytes(item, Path.Combine(source, "images")))`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(item, Bytes(item, Path.Combine(source, "images")));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`groups.Any(g => !PortraitDesigns.SafeId(g.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: groups.Any(g => !PortraitDesigns.SafeId(g.Id)) || groups.Select(g => g.Id).Distinct().Count() != groups.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`group.Images.Select(i => i.Id).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Images.Select(i => i.Id).Distinct().Count() != group.Images.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`groups.Select(g => g.Id).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: groups.Select(g => g.Id).Distinct().Count() != groups.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`group.Images.Select(i => i.Id).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Images.Select(i => i.Id).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`groups.Select(g => g.Id).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: groups.Select(g => g.Id).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`groups.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: groups.FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Images.Select(i => i.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Images.Select(i => i.Id).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`groups.Select(g => g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: groups.Select(g => g.Id).Distinct`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path)`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("参考组中存在重复图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("参考组中存在重复图片。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("画风参考库为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("画风参考库为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("画风参考库编号无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("画风参考库编号无效。");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(source, "images")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(source, "images")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(source, "library.json")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(source, "library.json")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<List<PortraitStyleGroup>>(File.ReadAllText(path), PortraitDesigns.Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<List<PortraitStyleGroup>>(File.ReadAllText(path), PortraitDesigns.Json) ?? throw new InvalidDataException("画风参考库为空。")`

**赋值（含属性/字段和局部值）：**

- `_` = `ReadBytes(item, CacheDirectory)`
- `design.SelectedStyleGroup` = `groups.FirstOrDefault()?.Id ?? ""`
- `design.StyleGroups` = `groups`
- `design.StyleLibraryInitialized` = `true`

<a id="symbol-1978611d6c14"></a>

## `NationalSpire.PortraitStyleReferences.Import(NationalSpire.PortraitStyleGroup, string) — public static PortraitStyleImage Import(PortraitStyleGroup group, string path)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PortraitStyleImage.PortraitStyleImage()`；[`NationalSpire.PortraitStyleReferences.Decode(byte[], string)`](PortraitStyleReferences.cs.md#symbol-f6ac6cf512f8)；[`NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup)`](PortraitStyleReferences.cs.md#symbol-d49e42385613)；[`NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`](PortraitStyleReferences.cs.md#symbol-0a6c9f2034e7)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Convert.ToHexString(byte[])`；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetExtension(string?)`；`System.IO.Path.GetFileName(string?)`；`System.Security.Cryptography.SHA256.HashData(byte[])`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleGroup.Images`；`NationalSpire.PortraitStyleImage.Enabled`；`NationalSpire.PortraitStyleImage.Extension`；`NationalSpire.PortraitStyleImage.Id`；`NationalSpire.PortraitStyleImage.Name`；`NationalSpire.PortraitStyleReferences.Decode(byte[], string)`；`NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup)`；`NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitStyleImage.PortraitStyleImage()`；输入表达式：`new PortraitStyleImage { Id = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant(), Extension = extension, Name = Path.GetFileName(path) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PortraitStyleImage { Id = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant(), Extension = extension, Name = Path.GetFileName(path) }`
- `NationalSpire.PortraitStyleReferences.Decode(byte[], string)`；输入表达式：`Decode(bytes, extension)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Decode(bytes, extension)`
- `NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup)`；输入表达式：`NormalizePrimary(group)`；返回值紧邻使用处：`ExpressionStatementSyntax: NormalizePrimary(group);`
- `NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`；输入表达式：`Store(item, bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(item, bytes);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Images.FirstOrDefault(i => i.Id == item.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Images.FirstOrDefault(i => i.Id == item.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`group.Images.Add(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: group.Images.Add(item);`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllBytes(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请选择 PNG、JPG 或 WebP 图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请选择 PNG、JPG 或 WebP 图片。");`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(path).ToLowerInvariant`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = Path.GetFileName(path)`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(bytes)`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(bytes)`
- `string.ToLowerInvariant()`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Id = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`
- `string.ToLowerInvariant()`；输入表达式：`Path.GetExtension(path).ToLowerInvariant()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetExtension(path).ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**

- `Extension` = `extension`
- `Id` = `Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`
- `Name` = `Path.GetFileName(path)`
- `existing.Enabled` = `true`
- `extension` = `".jpg"`

<a id="symbol-0a6c9f2034e7"></a>

## `NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[]) — private static void Store(PortraitStyleImage item, byte[] bytes)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.EnsureLibrary(NationalSpire.PortraitDesign, string?)`](PortraitStyleReferences.cs.md#symbol-545c98f9afe4)；[`NationalSpire.PortraitStyleReferences.Import(NationalSpire.PortraitStyleGroup, string)`](PortraitStyleReferences.cs.md#symbol-1978611d6c14)

**调用：** [`NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-a4ea2e81556b)；`System.Convert.ToHexString(byte[])`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`；`string.Equals(string?, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleImage.Id`；`NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`；`NationalSpire.PortraitStyleReferences.CacheDirectory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`；输入表达式：`AssetPath(item, CacheDirectory)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AssetPath(item, CacheDirectory)`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))).Equals`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + "." + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(CacheDirectory)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(CacheDirectory);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: File.Exists(path) && Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))).Equals(item.Id, StringComparison.OrdinalIgnoreCase)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temporary, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path, true);`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(path)`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(temporary, bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(temporary, bytes);`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(File.ReadAllBytes(path))`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(File.ReadAllBytes(path))`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))).Equals(item.Id, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: File.Exists(path) && Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))).Equals(item.Id, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a4ea2e81556b"></a>

## `NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string) — private static string AssetPath(PortraitStyleImage item, string directory)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.Entries(NationalSpire.PortraitDesign)`](PortraitStyleReferences.cs.md#symbol-36810afabe68)；[`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-305cedf5de7f)；[`NationalSpire.PortraitStyleReferences.Store(NationalSpire.PortraitStyleImage, byte[])`](PortraitStyleReferences.cs.md#symbol-0a6c9f2034e7)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string)`；`char.IsAsciiHexDigit(char)`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleImage.Extension`；`NationalSpire.PortraitStyleImage.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`item.Id.Any(c => !char.IsAsciiHexDigit(c))`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Id.Length != 64 || item.Id.Any(c => !char.IsAsciiHexDigit(c))`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("参考图编号或格式无效，请重新导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("参考图编号或格式无效，请重新导入。");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, item.Id.ToLowerInvariant() + item.Extension)`；返回值紧邻使用处：`ReturnStatementSyntax: return Path.Combine(directory, item.Id.ToLowerInvariant() + item.Extension);`
- `char.IsAsciiHexDigit(char)`；输入表达式：`char.IsAsciiHexDigit(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !char.IsAsciiHexDigit(c)`
- `string.ToLowerInvariant()`；输入表达式：`item.Id.ToLowerInvariant()`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Id.ToLowerInvariant() + item.Extension`

**赋值（含属性/字段和局部值）：**


<a id="symbol-79f6d9abc7df"></a>

## `NationalSpire.PortraitStyleReferences.Bytes(NationalSpire.PortraitStyleImage, string?) — public static byte[] Bytes(PortraitStyleImage item, string? directory = null)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.EnsureLibrary(NationalSpire.PortraitDesign, string?)`](PortraitStyleReferences.cs.md#symbol-545c98f9afe4)

**调用：** [`NationalSpire.PortraitStyleReferences.Decode(byte[], string)`](PortraitStyleReferences.cs.md#symbol-f6ac6cf512f8)；[`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-305cedf5de7f)

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleImage.Extension`；`NationalSpire.PortraitStyleReferences.CacheDirectory`；`NationalSpire.PortraitStyleReferences.Decode(byte[], string)`；`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitStyleReferences.Decode(byte[], string)`；输入表达式：`Decode(bytes, item.Extension)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Decode(bytes, item.Extension)`
- `NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`；输入表达式：`ReadBytes(item, directory ?? CacheDirectory)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadBytes(item, directory ?? CacheDirectory)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-305cedf5de7f"></a>

## `NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string) — private static byte[] ReadBytes(PortraitStyleImage item, string directory)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.Bytes(NationalSpire.PortraitStyleImage, string?)`](PortraitStyleReferences.cs.md#symbol-79f6d9abc7df)；[`NationalSpire.PortraitStyleReferences.EnsureLibrary(NationalSpire.PortraitDesign, string?)`](PortraitStyleReferences.cs.md#symbol-545c98f9afe4)；[`NationalSpire.PortraitStyleReferences.Thumbnail(NationalSpire.PortraitStyleImage)`](PortraitStyleReferences.cs.md#symbol-4569d1f013cf)

**调用：** [`NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-a4ea2e81556b)；`System.Convert.ToHexString(byte[])`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.FileNotFoundException.FileNotFoundException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Security.Cryptography.SHA256.HashData(byte[])`；`string.Equals(string?, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleImage.Id`；`NationalSpire.PortraitStyleImage.Name`；`NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`；输入表达式：`AssetPath(item, directory)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AssetPath(item, directory)`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(bytes)).Equals`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path)`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllBytes(path)`
- `System.IO.FileNotFoundException.FileNotFoundException(string?)`；输入表达式：`new FileNotFoundException($"参考图“{item.Name}”缺失，请重新导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new FileNotFoundException($"参考图“{item.Name}”缺失，请重新导入。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException($"参考图“{item.Name}”内容已变化，请重新导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException($"参考图“{item.Name}”内容已变化，请重新导入。");`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(bytes)`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(bytes)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes)).Equals(item.Id, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Convert.ToHexString(SHA256.HashData(bytes)).Equals(item.Id, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f6ac6cf512f8"></a>

## `NationalSpire.PortraitStyleReferences.Decode(byte[], string) — private static Image Decode(byte[] bytes, string extension)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.Bytes(NationalSpire.PortraitStyleImage, string?)`](PortraitStyleReferences.cs.md#symbol-79f6d9abc7df)；[`NationalSpire.PortraitStyleReferences.Import(NationalSpire.PortraitStyleGroup, string)`](PortraitStyleReferences.cs.md#symbol-1978611d6c14)；[`NationalSpire.PortraitStyleReferences.Thumbnail(NationalSpire.PortraitStyleImage)`](PortraitStyleReferences.cs.md#symbol-4569d1f013cf)

**调用：** `Godot.GodotObject.Dispose()`；`Godot.Image.Image()`；`Godot.Image.IsEmpty()`；`Godot.Image.LoadJpgFromBuffer(byte[])`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.Image.LoadWebpFromBuffer(byte[])`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`image.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Dispose();`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.IsEmpty()`；输入表达式：`image.IsEmpty()`；返回值紧邻使用处：`BinaryExpressionSyntax: error != Error.Ok || image.IsEmpty()`
- `Godot.Image.LoadJpgFromBuffer(byte[])`；输入表达式：`image.LoadJpgFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".jpg" => image.LoadJpgFromBuffer(bytes)`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".png" => image.LoadPngFromBuffer(bytes)`
- `Godot.Image.LoadWebpFromBuffer(byte[])`；输入表达式：`image.LoadWebpFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".webp" => image.LoadWebpFromBuffer(bytes)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("参考图解码失败，请选择完整的 PNG、JPG 或 WebP 图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("参考图解码失败，请选择完整的 PNG、JPG 或 WebP 图片。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4569d1f013cf"></a>

## `NationalSpire.PortraitStyleReferences.Thumbnail(NationalSpire.PortraitStyleImage) — public static Texture2D Thumbnail(PortraitStyleImage item)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Image.GetHeight()`；`Godot.Image.GetWidth()`；`Godot.Image.Resize(int, int, Godot.Image.Interpolation)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；[`NationalSpire.PortraitStyleReferences.Decode(byte[], string)`](PortraitStyleReferences.cs.md#symbol-f6ac6cf512f8)；[`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-305cedf5de7f)；`System.Math.Max(int, int)`；`System.Math.Min(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleImage.Extension`；`NationalSpire.PortraitStyleReferences.CacheDirectory`；`NationalSpire.PortraitStyleReferences.Decode(byte[], string)`；`NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.GetHeight()`；输入表达式：`image.GetHeight()`；返回值紧邻使用处：`ArgumentSyntax: image.GetHeight()`
- `Godot.Image.GetHeight()`；输入表达式：`image.GetHeight()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.GetHeight() * scale`
- `Godot.Image.GetWidth()`；输入表达式：`image.GetWidth()`；返回值紧邻使用处：`ArgumentSyntax: image.GetWidth()`
- `Godot.Image.GetWidth()`；输入表达式：`image.GetWidth()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.GetWidth() * scale`
- `Godot.Image.Resize(int, int, Godot.Image.Interpolation)`；输入表达式：`image.Resize(Math.Max(1, (int)(image.GetWidth() * scale)), Math.Max(1, (int)(image.GetHeight() * scale)), Image.Interpolation.Lanczos)`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Resize(Math.Max(1, (int)(image.GetWidth() * scale)), Math.Max(1, (int)(image.GetHeight() * scale)), Image.Interpolation.Lanczos);`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`ReturnStatementSyntax: return ImageTexture.CreateFromImage(image);`
- `NationalSpire.PortraitStyleReferences.Decode(byte[], string)`；输入表达式：`Decode(ReadBytes(item, CacheDirectory), item.Extension)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Decode(ReadBytes(item, CacheDirectory), item.Extension)`
- `NationalSpire.PortraitStyleReferences.ReadBytes(NationalSpire.PortraitStyleImage, string)`；输入表达式：`ReadBytes(item, CacheDirectory)`；返回值紧邻使用处：`ArgumentSyntax: ReadBytes(item, CacheDirectory)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (int)(image.GetHeight() * scale))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, (int)(image.GetHeight() * scale))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (int)(image.GetWidth() * scale))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, (int)(image.GetWidth() * scale))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(image.GetWidth(), image.GetHeight())`；返回值紧邻使用处：`BinaryExpressionSyntax: 220d / Math.Max(image.GetWidth(), image.GetHeight())`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(1, 220d / Math.Max(image.GetWidth(), image.GetHeight()))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(1, 220d / Math.Max(image.GetWidth(), image.GetHeight()))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af2e4fe54f74"></a>

## `NationalSpire.PortraitStyleReferences.SetPrimary(NationalSpire.PortraitStyleGroup, NationalSpire.PortraitStyleImage) — public static void SetPrimary(PortraitStyleGroup group, PortraitStyleImage item)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.List<T>.Contains(T)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleGroup.Images`；`NationalSpire.PortraitStyleGroup.PrimaryId`；`NationalSpire.PortraitStyleImage.Enabled`；`NationalSpire.PortraitStyleImage.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`group.Images.Contains(item)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !group.Images.Contains(item)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("参考图已移出当前组。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("参考图已移出当前组。");`

**赋值（含属性/字段和局部值）：**

- `group.PrimaryId` = `item.Id`
- `item.Enabled` = `true`

<a id="symbol-d49e42385613"></a>

## `NationalSpire.PortraitStyleReferences.NormalizePrimary(NationalSpire.PortraitStyleGroup) — public static void NormalizePrimary(PortraitStyleGroup group)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.EnsureLibrary(NationalSpire.PortraitDesign, string?)`](PortraitStyleReferences.cs.md#symbol-545c98f9afe4)；[`NationalSpire.PortraitStyleReferences.Import(NationalSpire.PortraitStyleGroup, string)`](PortraitStyleReferences.cs.md#symbol-1978611d6c14)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleGroup.Images`；`NationalSpire.PortraitStyleGroup.PrimaryId`；`NationalSpire.PortraitStyleImage.Enabled`；`NationalSpire.PortraitStyleImage.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Images.Any(i => i.Enabled && i.Id == group.PrimaryId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !group.Images.Any(i => i.Enabled && i.Id == group.PrimaryId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Images.FirstOrDefault(i => i.Enabled)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: group.Images.FirstOrDefault(i => i.Enabled)?.Id`

**赋值（含属性/字段和局部值）：**

- `group.PrimaryId` = `group.Images.FirstOrDefault(i => i.Enabled)?.Id ?? ""`

<a id="symbol-36810afabe68"></a>

## `NationalSpire.PortraitStyleReferences.Entries(NationalSpire.PortraitDesign) — public static List<PortraitStyleEntry> Entries(PortraitDesign design)`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitStyleReferences.Instructions(NationalSpire.PortraitDesign, bool, string)`](PortraitStyleReferences.cs.md#symbol-5a43303b8efd)

**调用：** [`NationalSpire.PortraitDesigns.SafeId(string)`](PortraitDesign.cs.md#symbol-7497548faaf1)；`NationalSpire.PortraitStyleEntry.PortraitStyleEntry(NationalSpire.PortraitStyleImage, string, int)`；[`NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`](PortraitStyleReferences.cs.md#symbol-a4ea2e81556b)；[`NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign)`](PortraitStyleReferences.cs.md#symbol-9378112df23b)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesigns.SafeId(string)`；`NationalSpire.PortraitStyleGroup.Id`；`NationalSpire.PortraitStyleGroup.Images`；`NationalSpire.PortraitStyleGroup.Name`；`NationalSpire.PortraitStyleGroup.PrimaryId`；`NationalSpire.PortraitStyleImage.Enabled`；`NationalSpire.PortraitStyleImage.Extension`；`NationalSpire.PortraitStyleImage.Id`；`NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`；`NationalSpire.PortraitStyleReferences.CacheDirectory`；`NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(group.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(group.Id)`
- `NationalSpire.PortraitStyleEntry.PortraitStyleEntry(NationalSpire.PortraitStyleImage, string, int)`；输入表达式：`new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1)`；返回值紧邻使用处：`ReturnStatementSyntax: return new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1);`
- `NationalSpire.PortraitStyleReferences.AssetPath(NationalSpire.PortraitStyleImage, string)`；输入表达式：`AssetPath(item, CacheDirectory)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AssetPath(item, CacheDirectory)`
- `NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign)`；输入表达式：`Selected(design)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Selected(design)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`group.Images.Select(i => i.Id).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Images.Select(i => i.Id).Distinct().Count() != group.Images.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`group.Images.Select(i => i.Id).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Images.Select(i => i.Id).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`group.Images.Where(i => i.Enabled).OrderBy(i => i.Id == group.PrimaryId ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Images.Where(i => i.Enabled).OrderBy(i => i.Id == group.PrimaryId ? 0 : 1).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Images.Select(i => i.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Images.Select(i => i.Id).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`selected.Select((item, i) => { _ = AssetPath(item, CacheDirectory); return new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selected.Select((item, i) => { _ = AssetPath(item, CacheDirectory); return new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1); }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`group.Images.Where(i => i.Enabled).OrderBy(i => i.Id == group.PrimaryId ? 0 : 1).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Images.Where(i => i.Enabled).OrderBy(i => i.Id == group.PrimaryId ? 0 : 1).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`selected.Select((item, i) => { _ = AssetPath(item, CacheDirectory); return new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1); }).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return selected.Select((item, i) => { _ = AssetPath(item, CacheDirectory); return new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1); }).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Images.Where(i => i.Enabled)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Images.Where(i => i.Enabled).OrderBy`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("参考组中存在重复图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("参考组中存在重复图片。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请勾选参考图片并选择主参考。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请勾选参考图片并选择主参考。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请填写有效的画风参考组名称与编号。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请填写有效的画风参考组名称与编号。");`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(group.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: !PortraitDesigns.SafeId(group.Id) || string.IsNullOrWhiteSpace(group.Name)`

**赋值（含属性/字段和局部值）：**

- `_` = `AssetPath(item, CacheDirectory)`

<a id="symbol-5a43303b8efd"></a>

## `NationalSpire.PortraitStyleReferences.Instructions(NationalSpire.PortraitDesign, bool, string) — public static string Instructions(PortraitDesign design, bool editing, string neutral)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PortraitStyleReferences.Entries(NationalSpire.PortraitDesign)`](PortraitStyleReferences.cs.md#symbol-36810afabe68)；[`NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign)`](PortraitStyleReferences.cs.md#symbol-9378112df23b)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitStyleEntry.File`；`NationalSpire.PortraitStyleEntry.Image`；`NationalSpire.PortraitStyleEntry.Order`；`NationalSpire.PortraitStyleGroup.Name`；`NationalSpire.PortraitStyleGroup.Requirements`；`NationalSpire.PortraitStyleImage.Name`；`NationalSpire.PortraitStyleReferences.Entries(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitStyleReferences.Entries(NationalSpire.PortraitDesign)`；输入表达式：`Entries(design)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Entries(design)`
- `NationalSpire.PortraitStyleReferences.Selected(NationalSpire.PortraitDesign)`；输入表达式：`Selected(design)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Selected(design)!`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => $"上传图{e.Order + (editing ? 1 : 0)}：{e.File}，{(e.Order == 1 ? "主画风参考" : "辅助画风参考")}（{e.Image.Name}）。")`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => $"上传图{e.Order + (editing ? 1 : 0)}：{e.File}，{(e.Order == 1 ? "主画风参考" : "辅助画风参考")}（{e.Image.Name}）。")`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", entries.Select(e => $"上传图{e.Order + (editing ? 1 : 0)}：{e.File}，{(e.Order == 1 ? "主画风参考" : "辅助画风参考")}（{e.Image.Name}）。"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n", entries.Select(e => $"上传图{e.Order + (editing ? 1 : 0)}：{e.File}，{(e.Order == 1 ? "主画风参考" : "辅助画风参考")}（{e.Image.Name}）。"))`

**赋值（含属性/字段和局部值）：**
