# PortraitDesignStore.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`55E552B5C53ABD006C8545EE30D7BC1A0C8FFBDA1BFB6F3D318F17286E5138A8`。来源：[源码](../../PortraitDesignStore.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PortraitDesignStore`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-2ed1ee155b2d"></a>

## `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string) — public static string Key(CareerData data, string person)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-81bb8bd9a964)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)

**调用：** `System.Convert.ToHexString(byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`；`System.Text.Encoding.GetBytes(string)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person }))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })))).ToLowerInvariant`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })))`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })))`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person }))`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person }))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })`
- `string.ToLowerInvariant()`；输入表达式：`Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })))).ToLowerInvariant()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes( JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })))).ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8db102d73ed8"></a>

## `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string) — public static string FilePath(CareerData data, string person)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, NationalSpire.CharacterDesignPackage.Imported)`](CharacterDesignPackage.cs.md#symbol-f40a9f8b3b92)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string)`](DateSceneAssets.cs.md#symbol-e6562f4576e9)

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_portraits")`；返回值紧邻使用处：`ArgumentSyntax: ProjectSettings.GlobalizePath("user://national_spire_portraits")`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`Key(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: Key(data, person) + ".json"`
- `System.IO.Path.Combine(string, string)`；输入表达式：`System.IO.Path.Combine(ProjectSettings.GlobalizePath("user://national_spire_portraits"), Key(data, person) + ".json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => System.IO.Path.Combine(ProjectSettings.GlobalizePath("user://national_spire_portraits"), Key(data, person) + ".json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2eeba99f517d"></a>

## `NationalSpire.PortraitDesignStore.Read(string, string) — public static PortraitDesign? Read(string path, string person)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)

**调用：** [`NationalSpire.PortraitDesigns.UpgradeDefaults(NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-f416cbcbe973)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.Basics`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesign.PersonId`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesign.StyleGroups`；`NationalSpire.PortraitDesign.Version`；`NationalSpire.PortraitDesigns.Json`；`NationalSpire.PortraitDesigns.UpgradeDefaults(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitOutfit.Fields`；`NationalSpire.PortraitOutfit.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesigns.UpgradeDefaults(NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesigns.UpgradeDefaults(design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesigns.UpgradeDefaults(design);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Outfits.Any(o => o.Id == design.SelectedOutfit)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !design.Outfits.Any(o => o.Id == design.SelectedOutfit)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path)`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘资料为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("立绘资料为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘资料的角色或版本不匹配。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘资料的角色或版本不匹配。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘资料缺少当前套装。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘资料缺少当前套装。");`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PortraitDesign>(File.ReadAllText(path), PortraitDesigns.Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PortraitDesign>(File.ReadAllText(path), PortraitDesigns.Json) ?? throw new InvalidDataException("立绘资料为空。")`

**赋值（含属性/字段和局部值）：**

- `design.Basics` ??= `[]`
- `design.Emotions` ??= `[]`
- `design.Outfits` ??= `[]`
- `design.StyleGroups` ??= `[]`
- `outfit.Fields` ??= `[]`

<a id="symbol-2f8c936a01d4"></a>

## `NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign) — public static void Save(string path, PortraitDesign design)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Close()`](PortraitDesignScreen.cs.md#symbol-5a1ede54f61b)；[`Infer()`](PortraitDesignScreen.cs.md#symbol-b6bca0ac19b5)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, NationalSpire.CharacterDesignPackage.Imported)`](CharacterDesignPackage.cs.md#symbol-f40a9f8b3b92)；[`NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string)`](DateSceneAssets.cs.md#symbol-e6562f4576e9)

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?, System.Text.Encoding)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.UTF8Encoding.UTF8Encoding(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + "." + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temporary, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path, true);`
- `System.IO.File.WriteAllText(string, string?, System.Text.Encoding)`；输入表达式：`File.WriteAllText(temporary, JsonSerializer.Serialize(design, PortraitDesigns.Json), new UTF8Encoding(false))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temporary, JsonSerializer.Serialize(design, PortraitDesigns.Json), new UTF8Encoding(false));`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.IO.Path.GetDirectoryName(path)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(design, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(design, PortraitDesigns.Json)`
- `System.Text.UTF8Encoding.UTF8Encoding(bool)`；输入表达式：`new UTF8Encoding(false)`；返回值紧邻使用处：`ArgumentSyntax: new UTF8Encoding(false)`

**赋值（含属性/字段和局部值）：**
