# AppearanceLibrary.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8037B60BF68EE2537DDFB752952F465A6DB799F70CA64F11B3DD68BECE6C7C45`。来源：[源码](../../AppearanceLibrary.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AppearanceLibrary`、`NationalSpire.AppearanceLibrary.Entry`、`NationalSpire.AppearanceLibrary.Package`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Entry[] BuiltIns = [new("haruka", "井上遥香", true), new("charlotte", "夏洛特·赖特", true), new("alili", "阿莉莉", true)];
```

<a id="symbol-e61c0fac622d"></a>

## `NationalSpire.AppearanceLibrary.Package.Name — public string Name`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a5b9bd2cda4c"></a>

## `NationalSpire.AppearanceLibrary.Package.Design — public PortraitDesign Design`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PortraitDesign.PortraitDesign()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesign.PortraitDesign()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1539a3c76cc2"></a>

## `NationalSpire.AppearanceLibrary.Package.Outfits — public Dictionary<string, Dictionary<string, string>> Outfits`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cabbdcc950d1"></a>

## `NationalSpire.AppearanceLibrary.DirectoryPath — public static string DirectoryPath`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_portraits/library")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_portraits/library")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57a16bc4af68"></a>

## `NationalSpire.AppearanceLibrary.PathFor(string) — private static string PathFor(string id)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?)`](AppearanceLibrary.cs.md#symbol-e5bd2a2cd1b7)；[`NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`](AppearanceLibrary.cs.md#symbol-310593b772c6)；[`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`](AppearanceLibrary.cs.md#symbol-c4c0756e8854)

**调用：** `System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.DirectoryPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(DirectoryPath, id + ".json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Path.Combine(DirectoryPath, id + ".json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1f96a80ecca2"></a>

## `NationalSpire.AppearanceLibrary.List() — public static Entry[] List()`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Refresh(string)`](AppearanceLibraryScreen.cs.md#symbol-6a433a7b81b7)

**调用：** `NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.ToArray()`；`System.IO.Directory.EnumerateFiles(string, string)`；`System.IO.Directory.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.BuiltIns`；`NationalSpire.AppearanceLibrary.DirectoryPath`；`NationalSpire.AppearanceLibrary.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；输入表达式：`new(id, json.RootElement.GetProperty("Name").GetString()!, false)`；返回值紧邻使用处：`ArgumentSyntax: new(id, json.RootElement.GetProperty("Name").GetString()!, false)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`BuiltIns.Any(e => e.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (BuiltIns.Any(e => e.Id == id)) continue;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entries.Add(new(id, json.RootElement.GetProperty("Name").GetString()!, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.Add(new(id, json.RootElement.GetProperty("Name").GetString()!, false));`
- `System.Collections.Generic.List<T>.List(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new List<Entry>(BuiltIns)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Entry>(BuiltIns)`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`entries.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return entries.ToArray();`
- `System.IO.Directory.EnumerateFiles(string, string)`；输入表达式：`Directory.EnumerateFiles(DirectoryPath, "*.json")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string path in Directory.EnumerateFiles(DirectoryPath, "*.json"))             {                 string id = Path.GetFileNameWithoutExtension(path);                 if (BuiltIns.Any(e => e.Id == id)) continue;                 using var json = JsonDocument.Parse(File.ReadAllText(path));                 entries.Add(new(id, json.RootElement.GetProperty("Name").GetString()!, false));             }`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(DirectoryPath)`；返回值紧邻使用处：`IfStatementSyntax: if (Directory.Exists(DirectoryPath))             foreach (string path in Directory.EnumerateFiles(DirectoryPath, "*.json"))             {                 string id = Path.GetFileNameWithoutExtension(path);                 if (BuiltIns.Any(e => e.Id == id)) continue;                 using var json = JsonDocument.Parse(File.ReadAllText(path));                 entries.Add(new(id, json.RootElement.GetProperty("Name").GetString()!, false));             }`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFileNameWithoutExtension(path)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(File.ReadAllText(path))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(File.ReadAllText(path))`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`json.RootElement.GetProperty("Name")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: json.RootElement.GetProperty("Name").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`json.RootElement.GetProperty("Name").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: json.RootElement.GetProperty("Name").GetString()!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e5bd2a2cd1b7"></a>

## `NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?) — public static Entry Import(CareerData data, string path, CharacterDesignPackage.Imported? imported = null)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>)`](AppearanceLibraryScreen.cs.md#symbol-6c40b8e1641a)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)

**调用：** [`NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`](AppearanceLibrary.cs.md#symbol-310593b772c6)；[`NationalSpire.AppearanceLibrary.PathFor(string)`](AppearanceLibrary.cs.md#symbol-57a16bc4af68)；[`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`](AppearanceLibrary.cs.md#symbol-c4c0756e8854)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`](CharacterDesignPackage.cs.md#symbol-b6e606c27a93)；`NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；`string.ToLowerInvariant()`；`System.Convert.ToHexString(byte[])`；`System.IO.File.Exists(string?)`；`System.IO.File.OpenRead(string)`；`System.Security.Cryptography.SHA256.HashData(System.IO.Stream)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`；`NationalSpire.AppearanceLibrary.Package.Name`；`NationalSpire.AppearanceLibrary.PathFor(string)`；`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`；`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；输入表达式：`new(id, "", false)`；返回值紧邻使用处：`ArgumentSyntax: new(id, "", false)`
- `NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；输入表达式：`new(id, Load(data, new(id, "", false)).Name, false)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(id, Load(data, new(id, "", false)).Name, false);`
- `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`；输入表达式：`Load(data, new(id, "", false))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Load(data, new(id, "", false)).Name`
- `NationalSpire.AppearanceLibrary.PathFor(string)`；输入表达式：`PathFor(id)`；返回值紧邻使用处：`ArgumentSyntax: PathFor(id)`
- `NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`；输入表达式：`Save(id, imported ?? CharacterDesignPackage.Read(data, file))`；返回值紧邻使用处：`ReturnStatementSyntax: return Save(id, imported ?? CharacterDesignPackage.Read(data, file));`
- `NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`；输入表达式：`CharacterDesignPackage.Read(data, file)`；返回值紧邻使用处：`BinaryExpressionSyntax: imported ?? CharacterDesignPackage.Read(data, file)`
- `string.ToLowerInvariant()`；输入表达式：`Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(file)).ToLowerInvariant()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(file)).ToLowerInvariant()`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(file))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(file)).ToLowerInvariant`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(PathFor(id))`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(PathFor(id))) return new(id, Load(data, new(id, "", false)).Name, false);`
- `System.IO.File.OpenRead(string)`；输入表达式：`File.OpenRead(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.OpenRead(path)`
- `System.Security.Cryptography.SHA256.HashData(System.IO.Stream)`；输入表达式：`System.Security.Cryptography.SHA256.HashData(file)`；返回值紧邻使用处：`ArgumentSyntax: System.Security.Cryptography.SHA256.HashData(file)`

**赋值（含属性/字段和局部值）：**

- `file.Position` = `0`

<a id="symbol-c4c0756e8854"></a>

## `NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?) — private static Entry Save(string id, CharacterDesignPackage.Imported imported, string? name = null)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?)`](AppearanceLibrary.cs.md#symbol-e5bd2a2cd1b7)；[`NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`](AppearanceLibrary.cs.md#symbol-310593b772c6)

**调用：** [`NationalSpire.AppearanceLibrary.PathFor(string)`](AppearanceLibrary.cs.md#symbol-57a16bc4af68)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；`NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；`NationalSpire.AppearanceLibrary.Package.Package()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.DirectoryPath`；`NationalSpire.AppearanceLibrary.Package.Design`；`NationalSpire.AppearanceLibrary.Package.Name`；`NationalSpire.AppearanceLibrary.Package.Outfits`；`NationalSpire.AppearanceLibrary.PathFor(string)`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CharacterDesignPackage.Binding.File`；`NationalSpire.CharacterDesignPackage.Binding.Hash`；`NationalSpire.CharacterDesignPackage.Binding.Id`；`NationalSpire.CharacterDesignPackage.Binding.Outfit`；`NationalSpire.CharacterDesignPackage.Imported.Design`；`NationalSpire.CharacterDesignPackage.Imported.Images`；`NationalSpire.CharacterDesignPackage.Imported.Metadata`；`NationalSpire.CharacterDesignPackage.Imported.Person`；`NationalSpire.CharacterDesignPackage.Manifest.Sprites`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AppearanceLibrary.Entry.Entry(string, string, bool)`；输入表达式：`new(id, package.Name, false)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(id, package.Name, false);`
- `NationalSpire.AppearanceLibrary.Package.Package()`；输入表达式：`new Package { Name = name ?? imported.Person.PublicName, Design = imported.Design }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Package { Name = name ?? imported.Person.PublicName, Design = imported.Design }`
- `NationalSpire.AppearanceLibrary.PathFor(string)`；输入表达式：`PathFor(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PathFor(id)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`DateSceneAssetStore.Store(imported.Images[item.File], hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Store(imported.Images[item.File], hash);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`sprites.Add(item.Id, hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: sprites.Add(item.Id, hash);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`package.Outfits.TryGetValue(item.Outfit, out var sprites)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !package.Outfits.TryGetValue(item.Outfit, out var sprites)`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(DirectoryPath)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(DirectoryPath);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temp)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temp);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temp)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temp)) File.Delete(temp);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temp, target, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temp, target, true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(temp, JsonSerializer.Serialize(package, PortraitDesigns.Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temp, JsonSerializer.Serialize(package, PortraitDesigns.Json));`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(package, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(package, PortraitDesigns.Json)`

**赋值（含属性/字段和局部值）：**

- `Design` = `imported.Design`
- `Name` = `name ?? imported.Person.PublicName`
- `package.Outfits[item.Outfit]` = `sprites = []`
- `sprites` = `[]`

<a id="symbol-310593b772c6"></a>

## `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry) — public static Package Load(CareerData data, Entry entry)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Import(NationalSpire.CareerData, string, NationalSpire.CharacterDesignPackage.Imported?)`](AppearanceLibrary.cs.md#symbol-e5bd2a2cd1b7)；[`Select(int)`](AppearanceLibraryScreen.cs.md#symbol-76eb3d9afaf1)

**调用：** [`NationalSpire.AppearanceLibrary.PathFor(string)`](AppearanceLibrary.cs.md#symbol-57a16bc4af68)；[`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`](AppearanceLibrary.cs.md#symbol-c4c0756e8854)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`](CharacterDesignPackage.cs.md#symbol-b6e606c27a93)；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Entry.BuiltIn`；`NationalSpire.AppearanceLibrary.Entry.Id`；`NationalSpire.AppearanceLibrary.Entry.Name`；`NationalSpire.AppearanceLibrary.PathFor(string)`；`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`；`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AppearanceLibrary.PathFor(string)`；输入表达式：`PathFor(entry.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PathFor(entry.Id)`
- `NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`；输入表达式：`Save(entry.Id, CharacterDesignPackage.Read(data, stream), entry.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(entry.Id, CharacterDesignPackage.Read(data, stream), entry.Name);`
- `NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`；输入表达式：`CharacterDesignPackage.Read(data, stream)`；返回值紧邻使用处：`ArgumentSyntax: CharacterDesignPackage.Read(data, stream)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path)`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(AppearanceLibrary).Assembly.GetManifestResourceStream("NationalSpire.Appearance." + entry.Id + ".zip")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: typeof(AppearanceLibrary).Assembly.GetManifestResourceStream("NationalSpire.Appearance." + entry.Id + ".zip")!`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<Package>(File.ReadAllText(path), PortraitDesigns.Json)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<Package>(File.ReadAllText(path), PortraitDesigns.Json)!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-35fa453dd634"></a>

## `NationalSpire.AppearanceLibrary.Apply(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package) — public static (PortraitDesign Design, DateSceneAssets Assets) Apply(CareerData data, string person, Package package)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>)`](AppearanceLibraryScreen.cs.md#symbol-6c40b8e1641a)

**调用：** [`NationalSpire.CharacterDesignPackage.Installation.Commit()`](CharacterDesignPackage.cs.md#symbol-6147750def14)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Package.Design`；`NationalSpire.AppearanceLibrary.Package.Outfits`；`NationalSpire.CharacterDesignPackage.Installation.Commit()`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Outfits`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesign.PersonId`；`NationalSpire.PortraitDesign.SelectedOutfit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterDesignPackage.Installation.Commit()`；输入表达式：`installation.Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: installation.Commit();`
- `NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`；输入表达式：`new CharacterDesignPackage.Installation(data, person, design, assets)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CharacterDesignPackage.Installation(data, person, design, assets)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(package.Design)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(package.Design)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(package.Outfits)`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets.Outfits = Coop.CoopJson.Copy(package.Outfits)`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Read(data, person)`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `design.SelectedOutfit`
- `assets.Outfits` = `Coop.CoopJson.Copy(package.Outfits)`
- `design.PersonId` = `person`

<a id="symbol-2cbd15385625"></a>

## `NationalSpire.AppearanceLibrary.Preview(NationalSpire.AppearanceLibrary.Package) — public static string? Preview(Package package)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Select(int)`](AppearanceLibraryScreen.cs.md#symbol-76eb3d9afaf1)

**调用：** `string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Package.Design`；`NationalSpire.AppearanceLibrary.Package.Outfits`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.SelectedOutfit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith(package.Design.DefaultEmotionId + "_", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key == package.Design.DefaultEmotionId || p.Key.StartsWith(package.Design.DefaultEmotionId + "_", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.FirstOrDefault(p => p.Key == package.Design.DefaultEmotionId || p.Key.StartsWith(package.Design.DefaultEmotionId + "_", StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .FirstOrDefault(p => p.Key == package.Design.DefaultEmotionId || p.Key.StartsWith(package.Design.DefaultEmotionId + "_", StringComparison.Ordinal)).Value`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`package.Outfits.GetValueOrDefault(package.Design.SelectedOutfit)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: package.Outfits.GetValueOrDefault(package.Design.SelectedOutfit)?         .FirstOrDefault(p => p.Key == package.Design.DefaultEmotionId || p.Key.StartsWith(package.Design.DefaultEmotionId + "_", StringComparison.Ordinal)).Value`

**赋值（含属性/字段和局部值）：**
