# PortraitPackageImport.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`66CA8EBDFF5A2AE56E2B9F7A6E63E6044C55B106970687F2C39F7EDA10C7EDC3`。来源：[源码](../../PortraitPackageImport.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PortraitPackageImport`、`NationalSpire.PortraitPackageImport.Sprite`、`NationalSpire.PortraitPackageImport.Plan`。

字段、事件及初始值（源码原样）：

```csharp
private const long MaxTotal = 512L * 1024 * 1024;
```

<a id="symbol-c3227e96cac7"></a>

## `NationalSpire.PortraitPackageImport.Plan.Character — public CharacterDesignPackage.Imported? Character`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-55ae23223ac0"></a>

## `NationalSpire.PortraitPackageImport.Plan.SourceDesign — public PortraitDesign? SourceDesign`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b20f8323734"></a>

## `NationalSpire.PortraitPackageImport.Plan.Sprites — public List<Sprite> Sprites`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c60dfaaef123"></a>

## `NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign) — public Sprite[] Unknown(PortraitDesign design)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>)`](PortraitPackageImportScreen.cs.md#symbol-af6372ed4930)；[`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)；[`NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>)`](PortraitPackageImport.cs.md#symbol-63ab2a20968e)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitPackageImport.Plan.Sprites`；`NationalSpire.PortraitPackageImport.Sprite.Emotion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Sprites.Where(s => !design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion)).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Sprites.Where(s => !design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Sprites.Where(s => !design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Sprites.Where(s => !design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion)).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-162da4e9ac7a"></a>

## `NationalSpire.PortraitPackageImport.CheckPath(string) — private static void CheckPath(string name)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Bytes(string, int)`](PortraitPackageImport.cs.md#symbol-803c14e9a214)；[`NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-f3684b8edd44)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`string.Contains(char)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(char)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`name.Split('/').Any(p => p is "." or "..")`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/') || name.Contains(':') || name.Split('/').Any(p => p is "." or "..")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("压缩包含有无效路径：" + name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("压缩包含有无效路径：" + name);`
- `string.Contains(char)`；输入表达式：`name.Contains(':')`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/') || name.Contains(':')`
- `string.Contains(char)`；输入表达式：`name.Contains('\\')`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/')`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`name.Split('/')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: name.Split('/').Any`
- `string.StartsWith(char)`；输入表达式：`name.StartsWith('/')`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f33e3556719a"></a>

## `NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string) — public static string EmotionId(PortraitDesign design, string id)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](PortraitPackageImport.cs.md#symbol-df572b3fedc4)；[`NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-f3684b8edd44)

**调用：** [`NationalSpire.PortraitDesigns.SafeId(string)`](PortraitDesign.cs.md#symbol-7497548faaf1)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`string.LastIndexOf(char)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesigns.SafeId(string)`；`NationalSpire.PortraitEmotion.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(id)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id[(split + 1)..].All(char.IsAsciiDigit)`；返回值紧邻使用处：`BinaryExpressionSyntax: split > 0 && split < id.Length - 1 && id[(split + 1)..].All(char.IsAsciiDigit)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Any(e => e.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (design.Emotions.Any(e => e.Id == id)) return id;`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("PNG文件名请使用小写英文字母开头的情绪ID，可附加_数字：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("PNG文件名请使用小写英文字母开头的情绪ID，可附加_数字：" + id);`
- `string.LastIndexOf(char)`；输入表达式：`id.LastIndexOf('_')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = id.LastIndexOf('_')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f3684b8edd44"></a>

## `NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign) — public static Plan Read(CareerData? data, string path, PortraitDesign design)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ImportPackage(string, System.Action?)`](DateSceneAssetScreen.cs.md#symbol-e552da41d09b)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)

**调用：** [`Add(string)`](PortraitPackageImport.cs.md#symbol-df572b3fedc4)；[`Bytes(string, int)`](PortraitPackageImport.cs.md#symbol-803c14e9a214)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, string, bool)`](CharacterDesignPackage.cs.md#symbol-fbaf14871e47)；[`NationalSpire.PortraitPackageImport.CheckPath(string)`](PortraitPackageImport.cs.md#symbol-162da4e9ac7a)；[`NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string)`](PortraitPackageImport.cs.md#symbol-f33e3556719a)；`NationalSpire.PortraitPackageImport.Plan.Plan()`；`NationalSpire.PortraitPackageImport.Sprite.Sprite(string, string, string, string, byte[])`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.Compression.ZipFile.OpenRead(string)`；`System.IO.FileInfo.FileInfo(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetExtension(string?)`；`System.IO.Path.GetFileName(string?)`；`System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory<byte>, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`string.EndsWith(string, System.StringComparison)`；`string.Equals(string?, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `Add(string)`；`Bytes(string, int)`；`NationalSpire.CharacterDesignPackage.Binding.File`；`NationalSpire.CharacterDesignPackage.Binding.Id`；`NationalSpire.CharacterDesignPackage.Binding.Outfit`；`NationalSpire.CharacterDesignPackage.Imported.Design`；`NationalSpire.CharacterDesignPackage.Imported.Images`；`NationalSpire.CharacterDesignPackage.Imported.Metadata`；`NationalSpire.CharacterDesignPackage.Manifest.Sprites`；`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, string, bool)`；`NationalSpire.PortraitPackageImport.CheckPath(string)`；`NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string)`；`NationalSpire.PortraitPackageImport.MaxTotal`；`NationalSpire.PortraitPackageImport.Plan.Character`；`NationalSpire.PortraitPackageImport.Plan.SourceDesign`；`NationalSpire.PortraitPackageImport.Plan.Sprites`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string)`；输入表达式：`Add(entry.FullName)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(entry.FullName);`
- `Add(string)`；输入表达式：`Add(sprite.GetProperty("file").GetString() ?? "")`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(sprite.GetProperty("file").GetString() ?? "");`
- `Bytes(string, int)`；输入表达式：`Bytes(archive == null ? Path.GetFileName(path) : "manifest.json", 4 * 1024 * 1024)`；返回值紧邻使用处：`ArgumentSyntax: Bytes(archive == null ? Path.GetFileName(path) : "manifest.json", 4 * 1024 * 1024)`
- `NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, string, bool)`；输入表达式：`CharacterDesignPackage.Read(data, path, portraitsOnly: !hasCard)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterDesignPackage.Read(data, path, portraitsOnly: !hasCard)`
- `NationalSpire.PortraitPackageImport.CheckPath(string)`；输入表达式：`CheckPath(entry.FullName)`；返回值紧邻使用处：`ExpressionStatementSyntax: CheckPath(entry.FullName);`
- `NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionId(design, s.Id)`；返回值紧邻使用处：`ArgumentSyntax: EmotionId(design, s.Id)`
- `NationalSpire.PortraitPackageImport.Plan.Plan()`；输入表达式：`new Plan { Character = hasCard ? character : null, SourceDesign = character.Design, Sprites = character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList() }`；返回值紧邻使用处：`ReturnStatementSyntax: return new Plan { Character = hasCard ? character : null, SourceDesign = character.Design, Sprites = character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList() };`
- `NationalSpire.PortraitPackageImport.Plan.Plan()`；输入表达式：`new Plan()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Plan()`
- `NationalSpire.PortraitPackageImport.Sprite.Sprite(string, string, string, string, byte[])`；输入表达式：`new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`entries.ContainsKey("character-design.json")`；返回值紧邻使用处：`IfStatementSyntax: if (entries.ContainsKey("character-design.json")) { if (data == null) throw new InvalidDataException("这是角色设计包，请通过立绘与场景或导入角色入口选择导入方式。"); bool hasCard = entries.ContainsKey("character.png"); var character = CharacterDesignPackage.Read(data, path, portraitsOnly: !hasCard); return new Plan { Character = hasCard ? character : null, SourceDesign = character.Design, Sprites = character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList() }; }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`entries.ContainsKey("character.png")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.ContainsKey("character.png")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`entries.ContainsKey("manifest.json")`；返回值紧邻使用处：`BinaryExpressionSyntax: archive == null || entries.ContainsKey("manifest.json")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, ZipArchiveEntry>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, ZipArchiveEntry>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`entries.TryAdd(entry.FullName, entry)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !entries.TryAdd(entry.FullName, entry)`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`archive.Entries.Sum(e => e.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: archive.Entries.Sum(e => e.Length) > MaxTotal`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Sprites = character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`archive!.Entries.Where(e => e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/", StringComparison.Ordinal))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var entry in archive!.Entries.Where(e => e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/", StringComparison.Ordinal))) Add(entry.FullName);`
- `System.IO.Compression.ZipFile.OpenRead(string)`；输入表达式：`ZipFile.OpenRead(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? ZipFile.OpenRead(path) : null`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new FileInfo(path).Length`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("压缩包内容过大，请分批导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("压缩包内容过大，请分批导入。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("压缩包内没有立绘PNG图片，请选择包含立绘的文件包。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("压缩包内没有立绘PNG图片，请选择包含立绘的文件包。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("压缩包含有重复路径：" + entry.FullName)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("压缩包含有重复路径：" + entry.FullName);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("压缩包超过512MB，请分批导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("压缩包超过512MB，请分批导入。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("这是角色设计包，请通过立绘与场景或导入角色入口选择导入方式。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("这是角色设计包，请通过立绘与场景或导入角色入口选择导入方式。");`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(path).Equals`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: archive == null ? Path.GetFileName(path) : "manifest.json"`
- `System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory<byte>, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(Bytes(archive == null ? Path.GetFileName(path) : "manifest.json", 4 * 1024 * 1024))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(Bytes(archive == null ? Path.GetFileName(path) : "manifest.json", 4 * 1024 * 1024))`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`json.RootElement.GetProperty("sprites").EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sprite in json.RootElement.GetProperty("sprites").EnumerateArray()) Add(sprite.GetProperty("file").GetString() ?? "");`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`json.RootElement.GetProperty("sprites")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: json.RootElement.GetProperty("sprites").EnumerateArray`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`sprite.GetProperty("file")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sprite.GetProperty("file").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`sprite.GetProperty("file").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: sprite.GetProperty("file").GetString() ?? ""`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/", StringComparison.Ordinal)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? ZipFile.OpenRead(path) : null`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`e.FullName.StartsWith("__MACOSX/", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.FullName.StartsWith("__MACOSX/", StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**

- `Character` = `hasCard ? character : null`
- `SourceDesign` = `character.Design`
- `Sprites` = `character.Metadata.Sprites.Select(s => new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList()`

<a id="symbol-803c14e9a214"></a>

## `Bytes(string, int) — byte[] Bytes(string name, int limit)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](PortraitPackageImport.cs.md#symbol-df572b3fedc4)；[`NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-f3684b8edd44)

**调用：** [`NationalSpire.PortraitPackageImport.CheckPath(string)`](PortraitPackageImport.cs.md#symbol-162da4e9ac7a)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.File.OpenRead(string)`；`System.IO.FileInfo.FileInfo(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFullPath(string)`；`System.IO.Stream.ReadByte()`；`System.IO.Stream.ReadExactly(System.Span<byte>)`；`string.Replace(char, char)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitPackageImport.CheckPath(string)`；`NationalSpire.PortraitPackageImport.MaxTotal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitPackageImport.CheckPath(string)`；输入表达式：`CheckPath(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: CheckPath(name);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`entries.TryGetValue(name, out var entry)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !entries.TryGetValue(name, out var entry)`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`entry.Open()`；返回值紧邻使用处：`AssignmentExpressionSyntax: stream = entry.Open()`
- `System.IO.File.OpenRead(string)`；输入表达式：`File.OpenRead(file)`；返回值紧邻使用处：`AssignmentExpressionSyntax: stream = File.OpenRead(file)`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(file)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new FileInfo(file).Length`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("图片路径超出清单目录。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("图片路径超出清单目录。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("文件长度校验失败。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("文件长度校验失败。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包文件过大或为空：" + name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包文件过大或为空：" + name);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包缺少文件：" + name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包缺少文件：" + name);`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar))`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar))`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFullPath(Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar)))`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFullPath(Path.GetDirectoryName(path)!) + Path.DirectorySeparatorChar`
- `System.IO.Stream.ReadByte()`；输入表达式：`stream.ReadByte()`；返回值紧邻使用处：`BinaryExpressionSyntax: stream.ReadByte() != -1`
- `System.IO.Stream.ReadExactly(System.Span<byte>)`；输入表达式：`stream.ReadExactly(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.ReadExactly(bytes);`
- `string.Replace(char, char)`；输入表达式：`name.Replace('/', Path.DirectorySeparatorChar)`；返回值紧邻使用处：`ArgumentSyntax: name.Replace('/', Path.DirectorySeparatorChar)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`file.StartsWith(root, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !file.StartsWith(root, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `length` = `entry.Length`
- `length` = `new FileInfo(file).Length`
- `stream` = `File.OpenRead(file)`
- `stream` = `entry.Open()`
- `total` += `length`

<a id="symbol-df572b3fedc4"></a>

## `Add(string) — void Add(string file)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-f3684b8edd44)

**调用：** [`Bytes(string, int)`](PortraitPackageImport.cs.md#symbol-803c14e9a214)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；[`NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string)`](PortraitPackageImport.cs.md#symbol-f33e3556719a)；`NationalSpire.PortraitPackageImport.Sprite.Sprite(string, string, string, string, byte[])`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.List<T>.Add(T)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`；`string.EndsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `Bytes(string, int)`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string)`；`NationalSpire.PortraitPackageImport.Plan.Sprites`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Bytes(string, int)`；输入表达式：`Bytes(file, 64 * 1024 * 1024)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Bytes(file, 64 * 1024 * 1024)`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`DateSceneAssetStore.ReadImage(bytes, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.ReadImage(bytes, true)`
- `NationalSpire.PortraitPackageImport.EmotionId(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionId(design, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EmotionId(design, id)`
- `NationalSpire.PortraitPackageImport.Sprite.Sprite(string, string, string, string, byte[])`；输入表达式：`new(file, id, emotion, design.SelectedOutfit, bytes)`；返回值紧邻使用处：`ArgumentSyntax: new(file, id, emotion, design.SelectedOutfit, bytes)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`ids.Add(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.Add(id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Sprites.Add(new(file, id, emotion, design.SelectedOutfit, bytes))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Sprites.Add(new(file, id, emotion, design.SelectedOutfit, bytes));`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包中的PNG文件名重复：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包中的PNG文件名重复：" + id);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘清单请引用PNG文件：" + file)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘清单请引用PNG文件：" + file);`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFileNameWithoutExtension(file)`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`file.EndsWith(".png", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !file.EndsWith(".png", StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-63ab2a20968e"></a>

## `NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>) — public static (PortraitDesign Design, DateSceneAssets Assets, int Count) Merge(Plan plan, PortraitDesign source, DateSceneAssets original, ISet<string> acceptedUnknown)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ImportSprites()`](DateSceneAssetScreen.cs.md#symbol-6a30a901510f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；[`NationalSpire.PortraitDesigns.Error(NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-4591e55fbd90)；`NationalSpire.PortraitEmotion.PortraitEmotion()`；`NationalSpire.PortraitOutfit.PortraitOutfit()`；[`NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-c60dfaaef123)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Outfits`；`NationalSpire.DateSceneAssets.UseDefaultPortrait`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesigns.Error(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitEmotion.Name`；`NationalSpire.PortraitOutfit.Id`；`NationalSpire.PortraitOutfit.Name`；`NationalSpire.PortraitPackageImport.Plan.SourceDesign`；`NationalSpire.PortraitPackageImport.Plan.Sprites`；`NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitPackageImport.Sprite.Bytes`；`NationalSpire.PortraitPackageImport.Sprite.Emotion`；`NationalSpire.PortraitPackageImport.Sprite.File`；`NationalSpire.PortraitPackageImport.Sprite.Id`；`NationalSpire.PortraitPackageImport.Sprite.Outfit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(incoming)`；返回值紧邻使用处：`ConditionalExpressionSyntax: incoming == null ? new PortraitOutfit { Name = outfit } : Coop.CoopJson.Copy(incoming)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(original)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(original)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(source)`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(sprite.Bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Hash(sprite.Bytes)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`DateSceneAssetStore.Store(sprite.Bytes, hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Store(sprite.Bytes, hash);`
- `NationalSpire.PortraitDesigns.Error(NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesigns.Error(design)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PortraitDesigns.Error(design) is { } error`
- `NationalSpire.PortraitEmotion.PortraitEmotion()`；输入表达式：`new() { Id = sprite.Emotion, Name = sprite.Emotion }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = sprite.Emotion, Name = sprite.Emotion }`
- `NationalSpire.PortraitOutfit.PortraitOutfit()`；输入表达式：`new PortraitOutfit { Name = outfit }`；返回值紧邻使用处：`ConditionalExpressionSyntax: incoming == null ? new PortraitOutfit { Name = outfit } : Coop.CoopJson.Copy(incoming)`
- `NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`；输入表达式：`plan.Unknown(source)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plan.Unknown(source).Select`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`assets.Outfits.TryGetValue(outfit, out var bindings)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !assets.Outfits.TryGetValue(outfit, out var bindings)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`reservedOutfits.Add(destination)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !reservedOutfits.Add(destination)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`unknown.Contains(s.File)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !unknown.Contains(s.File)`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`acceptedUnknown.Contains(s.File)`；返回值紧邻使用处：`BinaryExpressionSyntax: !unknown.Contains(s.File) || acceptedUnknown.Contains(s.File)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Outfits.Any(o => o.Id == outfit)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !design.Outfits.Any(o => o.Id == outfit)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys).Concat(outfits.Keys)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys).Concat(outfits.Keys).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`sprites.Select(s => s.Outfit).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sprites.Select(s => s.Outfit).Distinct().ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Outfits.FirstOrDefault(o => o.Id == sprite.Outfit)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: plan.SourceDesign?.Outfits.FirstOrDefault(o => o.Id == sprite.Outfit)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.FirstOrDefault(e => e.Id == sprite.Emotion)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = design.Emotions.FirstOrDefault(e => e.Id == sprite.Emotion)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`design.Outfits.Select(o => o.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Outfits.Select(o => o.Id).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`plan.Unknown(source).Select(s => s.File)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plan.Unknown(source).Select(s => s.File).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`sprites.Select(s => s.Outfit)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sprites.Select(s => s.Outfit).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`outfits.Keys.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in outfits.Keys.ToArray()) { if (id == sourceDesign.SelectedOutfit) outfits[id] = design.SelectedOutfit; else if (id == design.SelectedOutfit) { string stem = id[..Math.Min(48, id.Length)] + "_import", destination = stem; int suffix = 2; while (!reservedOutfits.Add(destination)) destination = stem + suffix++; outfits[id] = destination; } }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`plan.Sprites.Where(s => !unknown.Contains(s.File) || acceptedUnknown.Contains(s.File)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = plan.Sprites.Where(s => !unknown.Contains(s.File) || acceptedUnknown.Contains(s.File)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`sprites.Select(s => s.Outfit).Distinct().ToDictionary(id => id, id => id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = sprites.Select(s => s.Outfit).Distinct().ToDictionary(id => id, id => id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys).Concat(outfits.Keys).ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys).Concat(outfits.Keys).ToHashSet(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`plan.Unknown(source).Select(s => s.File).ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = plan.Unknown(source).Select(s => s.File).ToHashSet(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`plan.Sprites.Where(s => !unknown.Contains(s.File) || acceptedUnknown.Contains(s.File))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plan.Sprites.Where(s => !unknown.Contains(s.File) || acceptedUnknown.Contains(s.File)).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`design.Emotions.Add(new() { Id = sprite.Emotion, Name = sprite.Emotion })`；返回值紧邻使用处：`ExpressionStatementSyntax: design.Emotions.Add(new() { Id = sprite.Emotion, Name = sprite.Emotion });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`design.Outfits.Add(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: design.Outfits.Add(copy);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(48, id.Length)`；返回值紧邻使用处：`RangeExpressionSyntax: ..Math.Min(48, id.Length)`

**赋值（含属性/字段和局部值）：**

- `Id` = `sprite.Emotion`
- `Name` = `outfit`
- `Name` = `sprite.Emotion`
- `assets.OutfitId` = `design.SelectedOutfit`
- `assets.Outfits[outfit]` = `bindings = []`
- `assets.UseDefaultPortrait` = `false`
- `bindings[sprite.Id]` = `hash`
- `bindings` = `[]`
- `copy.Id` = `outfit`
- `destination` = `stem + suffix++`
- `emotion.Enabled` = `true`
- `outfits[id]` = `design.SelectedOutfit`
- `outfits[id]` = `destination`
