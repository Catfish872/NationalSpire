# CameoAssets.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`03CCD8EEA99A622D10CFA5933B698D2AD0E47477F8C1BA92A1375B3A6B77A7A5`。来源：[源码](../../CameoAssets.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CameoAssets`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, Texture2D> Cache = new();
```

<a id="symbol-c95ad2877552"></a>

## `NationalSpire.CameoAssets.ForPerson(string) — public static AvatarArt? ForPerson(string key)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AutomaticPortrait()`](CharacterCardScreen.cs.md#symbol-545b829b2369)；[`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)

**调用：** [`NationalSpire.AvatarAssets.LoadCard(string, string)`](AvatarAssets.cs.md#symbol-5b05259c8c83)；[`NationalSpire.CameoAssets.Load(string, string)`](CameoAssets.cs.md#symbol-2f79106cbc73)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.LoadCard(string, string)`；`NationalSpire.CameoAssets.Load(string, string)`；`NationalSpire.CameoContent.People`；`NationalSpire.CameoContent.Person.Key`；`NationalSpire.CameoContent.Person.Name`；`NationalSpire.CameoContent.Person.Portrait`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarAssets.LoadCard(string, string)`；输入表达式：`AvatarAssets.LoadCard("COSMIC_INDIFFERENCE", "宇宙冷漠")`；返回值紧邻使用处：`ReturnStatementSyntax: return AvatarAssets.LoadCard("COSMIC_INDIFFERENCE", "宇宙冷漠");`
- `NationalSpire.CameoAssets.Load(string, string)`；输入表达式：`Load(person.Portrait, person.Name)`；返回值紧邻使用处：`ReturnStatementSyntax: return Load(person.Portrait, person.Name);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("cameo.card", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("cameo.card", e);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CameoContent.People.FirstOrDefault(p => p.Key == key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CameoContent.People.FirstOrDefault(p => p.Key == key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-89a6e69b1880"></a>

## `NationalSpire.CameoAssets.ForStory(NationalSpire.WeeklySlide) — public static AvatarArt? ForStory(WeeklySlide slide)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)

**调用：** [`NationalSpire.CameoAssets.Load(string, string)`](CameoAssets.cs.md#symbol-2f79106cbc73)；[`NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`](CameoContent.cs.md#symbol-37cea0979aaf)

**字段、属性、事件及方法组引用：** `NationalSpire.CameoAssets.Load(string, string)`；`NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；`NationalSpire.CameoContent.Story.Image`；`NationalSpire.CameoContent.Story.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoAssets.Load(string, string)`；输入表达式：`Load(story.Image, story.Title)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CameoContent.FindStory(slide) is { } story ? Load(story.Image, story.Title) : null`
- `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；输入表达式：`CameoContent.FindStory(slide)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CameoContent.FindStory(slide) is { } story`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2f79106cbc73"></a>

## `NationalSpire.CameoAssets.Load(string, string) — private static AvatarArt? Load(string file, string description)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoAssets.ForPerson(string)`](CameoAssets.cs.md#symbol-c95ad2877552)；[`NationalSpire.CameoAssets.ForStory(NationalSpire.WeeklySlide)`](CameoAssets.cs.md#symbol-89a6e69b1880)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`Godot.Image.Image()`；`Godot.Image.LoadJpgFromBuffer(byte[])`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`string.EndsWith(string, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.CameoAssets.Cache`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadJpgFromBuffer(byte[])`；输入表达式：`image.LoadJpgFromBuffer(buffer.ToArray())`；返回值紧邻使用处：`ConditionalExpressionSyntax: file.EndsWith(".jpg", StringComparison.Ordinal) ? image.LoadJpgFromBuffer(buffer.ToArray()) : image.LoadPngFromBuffer(buffer.ToArray())`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(buffer.ToArray())`；返回值紧邻使用处：`ConditionalExpressionSyntax: file.EndsWith(".jpg", StringComparison.Ordinal) ? image.LoadJpgFromBuffer(buffer.ToArray()) : image.LoadPngFromBuffer(buffer.ToArray())`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageTexture.CreateFromImage(image)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(existing, CareerVisuals.Teal, description)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(existing, CareerVisuals.Teal, description);`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(texture, CareerVisuals.Teal, description)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(texture, CareerVisuals.Teal, description);`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(existing)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(file, out var existing) && AvatarAssets.Usable(existing)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("cameo.image", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("cameo.image", e);`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`file.EndsWith(".jpg", StringComparison.Ordinal)`；返回值紧邻使用处：`ConditionalExpressionSyntax: file.EndsWith(".jpg", StringComparison.Ordinal) ? image.LoadJpgFromBuffer(buffer.ToArray()) : image.LoadPngFromBuffer(buffer.ToArray())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cache.TryGetValue(file, out var existing)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(file, out var existing) && AvatarAssets.Usable(existing)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("彩蛋图片无法读取：" + file)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("彩蛋图片无法读取：" + file);`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`buffer.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: buffer.ToArray()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`stream.CopyTo(buffer)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.CopyTo(buffer);`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(CameoAssets).Assembly.GetManifestResourceStream("NationalSpire.Cameos." + file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(CameoAssets).Assembly.GetManifestResourceStream("NationalSpire.Cameos." + file)`

**赋值（含属性/字段和局部值）：**

- `Cache[file]` = `texture`
