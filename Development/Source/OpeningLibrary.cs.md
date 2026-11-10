# OpeningLibrary.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4E43CE8740E0F6B42D7CA6933B7A1971EF8D46B49067005B3AFE79D8F0D4A594`。来源：[源码](../../OpeningLibrary.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningRole`、`NationalSpire.OpeningLibrary`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-35e8c63641f5"></a>

## `NationalSpire.OpeningLibrary.SavedRoles(string) — internal static List<OpeningRole> SavedRoles(string original)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool, string)`](NpcGenerationScreen.cs.md#symbol-7f1e60697c26)

**调用：** `NationalSpire.OpeningRole.OpeningRole(string, string, string, string)`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.DirectoryInfo.DirectoryInfo(string)`；`System.IO.DirectoryInfo.EnumerateDirectories(string)`；`System.IO.File.Open(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`；`System.Text.Json.JsonDocument.Parse(System.IO.Stream, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLibrary.SavedPaths(string)`；`NationalSpire.OpeningRole.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OpeningRole.OpeningRole(string, string, string, string)`；输入表达式：`new(path,p.GetProperty("Id").GetString()!,handle,career)`；返回值紧邻使用处：`ArgumentSyntax: new(path,p.GetProperty("Id").GetString()!,handle,career)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(label.GetString())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(label.GetString())`
- `string.StartsWith(string)`；输入表达式：`folder.Name.StartsWith("profile")`；返回值紧邻使用处：`BinaryExpressionSyntax: folder.Parent is { } parent && folder.Name.StartsWith("profile")`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`names.Add(handle)`；返回值紧邻使用处：`IfStatementSyntax: if(names.Add(handle))result.Add(new(path,p.GetProperty("Id").GetString()!,handle,career));`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`result.OrderBy(c=>c.Name,StringComparer.CurrentCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.OrderBy(c=>c.Name,StringComparer.CurrentCulture).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`profiles.SelectMany(CareerLibrary.SavedPaths).OrderByDescending(File.GetLastWriteTimeUtc)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var path in profiles.SelectMany(CareerLibrary.SavedPaths).OrderByDescending(File.GetLastWriteTimeUtc))         {             using var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);             using var json = JsonDocument.Parse(file);             var root=json.RootElement;             if(!root.TryGetProperty("People",out var people)) continue;             string career=root.TryGetProperty("SaveName",out var label) && !string.IsNullOrWhiteSpace(label.GetString()) ? label.GetString()! : Path.GetFileNameWithoutExtension(path);             foreach(var p in people.EnumerateArray())                 if(p.TryGetProperty("CreatedCard",out var created) && created.ValueKind==JsonValueKind.True)                 {                     string handle=p.GetProperty("Handle").GetString()!;                     if(names.Add(handle))result.Add(new(path,p.GetProperty("Id").GetString()!,handle,career));                 }         }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parent.EnumerateDirectories("profile*").Select(p=>p.FullName)`；返回值紧邻使用处：`ConditionalExpressionSyntax: folder.Parent is { } parent && folder.Name.StartsWith("profile") && parent.Exists             ? parent.EnumerateDirectories("profile*").Select(p=>p.FullName) : [folder.FullName]`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`profiles.SelectMany(CareerLibrary.SavedPaths)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: profiles.SelectMany(CareerLibrary.SavedPaths).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`result.OrderBy(c=>c.Name,StringComparer.CurrentCulture).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.OrderBy(c=>c.Name,StringComparer.CurrentCulture).ToList();`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(path,p.GetProperty("Id").GetString()!,handle,career))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(path,p.GetProperty("Id").GetString()!,handle,career));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<OpeningRole>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<OpeningRole>()`
- `System.IO.DirectoryInfo.DirectoryInfo(string)`；输入表达式：`new DirectoryInfo(Path.GetDirectoryName(original)!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DirectoryInfo(Path.GetDirectoryName(original)!)`
- `System.IO.DirectoryInfo.EnumerateDirectories(string)`；输入表达式：`parent.EnumerateDirectories("profile*")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parent.EnumerateDirectories("profile*").Select`
- `System.IO.File.Open(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；输入表达式：`File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(original)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(original)!`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: root.TryGetProperty("SaveName",out var label) && !string.IsNullOrWhiteSpace(label.GetString()) ? label.GetString()! : Path.GetFileNameWithoutExtension(path)`
- `System.Text.Json.JsonDocument.Parse(System.IO.Stream, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(file)`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`people.EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var p in people.EnumerateArray())                 if(p.TryGetProperty("CreatedCard",out var created) && created.ValueKind==JsonValueKind.True)                 {                     string handle=p.GetProperty("Handle").GetString()!;                     if(names.Add(handle))result.Add(new(path,p.GetProperty("Id").GetString()!,handle,career));                 }`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`p.GetProperty("Handle")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.GetProperty("Handle").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`p.GetProperty("Id")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.GetProperty("Id").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`label.GetString()`；返回值紧邻使用处：`ArgumentSyntax: label.GetString()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`label.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: label.GetString()!`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`p.GetProperty("Handle").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: p.GetProperty("Handle").GetString()!`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`p.GetProperty("Id").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: p.GetProperty("Id").GetString()!`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`p.TryGetProperty("CreatedCard",out var created)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.TryGetProperty("CreatedCard",out var created) && created.ValueKind==JsonValueKind.True`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("People",out var people)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !root.TryGetProperty("People",out var people)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("SaveName",out var label)`；返回值紧邻使用处：`BinaryExpressionSyntax: root.TryGetProperty("SaveName",out var label) && !string.IsNullOrWhiteSpace(label.GetString())`

**赋值（含属性/字段和局部值）：**


<a id="symbol-08b1eb3bfbc4"></a>

## `NationalSpire.OpeningLibrary.Apply(NationalSpire.CareerData, NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.OpeningRole>, System.Collections.Generic.List<NationalSpire.CharacterDesignPackage.Installation>) — internal static void Apply(CareerData fresh,CareerData artOwner,IEnumerable<OpeningRole> roles,List<CharacterDesignPackage.Installation> installs)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NpcGeneration.ImportBatch.ImportBatch(NationalSpire.CareerData, NationalSpire.NpcGenerationSetup, NationalSpire.CareerData?)`](NpcGenerationSetup.cs.md#symbol-5a833e369893)

**调用：** [`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`](CharacterCards.cs.md#symbol-a50771d297a5)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；`NationalSpire.CareerData.CareerData()`；`NationalSpire.CharacterCardEdit.CharacterCardEdit()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.IO.File.OpenRead(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonDocument.Parse(System.IO.Stream, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.OpeningRole.Id`；`NationalSpire.OpeningRole.Path`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { WorldId=json.RootElement.GetProperty("WorldId").GetString()! }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CareerData { WorldId=json.RootElement.GetProperty("WorldId").GetString()! }`
- `NationalSpire.CharacterCardEdit.CharacterCardEdit()`；输入表达式：`new(){Create=true,Target=p.Id,Person=p}`；返回值紧邻使用处：`ArgumentSyntax: new(){Create=true,Target=p.Id,Person=p}`
- `NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`；输入表达式：`CharacterCards.Apply(fresh,new(){Create=true,Target=p.Id,Person=p})`；返回值紧邻使用处：`IsPatternExpressionSyntax: CharacterCards.Apply(fresh,new(){Create=true,Target=p.Id,Person=p}) is { } error`
- `NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`；输入表达式：`new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id))`；返回值紧邻使用处：`ArgumentSyntax: new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id))`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(source,p.Id)`；返回值紧邻使用处：`ArgumentSyntax: DateSceneAssetStore.Read(source,p.Id)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(fresh,p.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(fresh,p.ClubId)==null`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(fresh,p.SupportedClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(fresh,p.SupportedClubId)==null`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(source,p.Id)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(source,p.Id)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(source,p.Id),p.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PortraitDesignStore.Read(PortraitDesignStore.FilePath(source,p.Id),p.Id) is { } art`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(element.GetProperty("Id").GetString()!)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.Contains(element.GetProperty("Id").GetString()!)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`roles.GroupBy(r=>r.Path)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var group in roles.GroupBy(r=>r.Path))         {             using var file=File.OpenRead(group.Key);using var json=JsonDocument.Parse(file);             var source=new CareerData { WorldId=json.RootElement.GetProperty("WorldId").GetString()! };             var ids=group.Select(r=>r.Id).ToHashSet();             foreach(var element in json.RootElement.GetProperty("People").EnumerateArray())             {                 if(!ids.Contains(element.GetProperty("Id").GetString()!))continue;                 var p=element.Deserialize<CareerPerson>(CoopJson.Options)!;                 if(EsportsWorld.Club(fresh,p.ClubId)==null)p.ClubId="";                 if(EsportsWorld.Club(fresh,p.SupportedClubId)==null)p.SupportedClubId="";                 if(CharacterCards.Apply(fresh,new(){Create=true,Target=p.Id,Person=p}) is { } error)throw new InvalidDataException(p.PublicName+" · "+error);                 if(PortraitDesignStore.Read(PortraitDesignStore.FilePath(source,p.Id),p.Id) is { } art)                     installs.Add(new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id)));             }         }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Select(r=>r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(r=>r.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`group.Select(r=>r.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =group.Select(r=>r.Id).ToHashSet()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`installs.Add(new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id)))`；返回值紧邻使用处：`ExpressionStatementSyntax: installs.Add(new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id)));`
- `System.IO.File.OpenRead(string)`；输入表达式：`File.OpenRead(group.Key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =File.OpenRead(group.Key)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(p.PublicName+" · "+error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(p.PublicName+" · "+error);`
- `System.Text.Json.JsonDocument.Parse(System.IO.Stream, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =JsonDocument.Parse(file)`
- `System.Text.Json.JsonElement.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`element.Deserialize<CareerPerson>(CoopJson.Options)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: element.Deserialize<CareerPerson>(CoopJson.Options)!`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`json.RootElement.GetProperty("People").EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var element in json.RootElement.GetProperty("People").EnumerateArray())             {                 if(!ids.Contains(element.GetProperty("Id").GetString()!))continue;                 var p=element.Deserialize<CareerPerson>(CoopJson.Options)!;                 if(EsportsWorld.Club(fresh,p.ClubId)==null)p.ClubId="";                 if(EsportsWorld.Club(fresh,p.SupportedClubId)==null)p.SupportedClubId="";                 if(CharacterCards.Apply(fresh,new(){Create=true,Target=p.Id,Person=p}) is { } error)throw new InvalidDataException(p.PublicName+" · "+error);                 if(PortraitDesignStore.Read(PortraitDesignStore.FilePath(source,p.Id),p.Id) is { } art)                     installs.Add(new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id)));             }`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`element.GetProperty("Id")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: element.GetProperty("Id").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`json.RootElement.GetProperty("People")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: json.RootElement.GetProperty("People").EnumerateArray`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`json.RootElement.GetProperty("WorldId")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: json.RootElement.GetProperty("WorldId").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`element.GetProperty("Id").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: element.GetProperty("Id").GetString()!`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`json.RootElement.GetProperty("WorldId").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: json.RootElement.GetProperty("WorldId").GetString()!`

**赋值（含属性/字段和局部值）：**

- `Create` = `true`
- `p.ClubId` = `""`
- `p.SupportedClubId` = `""`
- `Person` = `p`
- `Target` = `p.Id`
- `WorldId` = `json.RootElement.GetProperty("WorldId").GetString()!`
