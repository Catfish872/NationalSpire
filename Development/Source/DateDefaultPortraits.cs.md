# DateDefaultPortraits.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E8FCB451C82DCBC2F72BA2DFED83B5A25F2D8D260CC3C9F1E017355F938BE145`。来源：[源码](../../DateDefaultPortraits.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateDefaultPortraits`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-09d5b70c6210"></a>

## `NationalSpire.DateDefaultPortraits.Design(string) — public static PortraitDesign Design(string person)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)

**调用：** `NationalSpire.PortraitDesign.PortraitDesign()`；`NationalSpire.PortraitEmotion.PortraitEmotion()`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.PersonId`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitEmotion.Description`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitEmotion.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesign.PortraitDesign()`；输入表达式：`new() { PersonId = person, SelectedOutfit = "default", Emotions = [new() { Id = "neutral", Name = "平淡", Description = "默认人物剪影" }] }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { PersonId = person, SelectedOutfit = "default", Emotions = [new() { Id = "neutral", Name = "平淡", Description = "默认人物剪影" }] }`
- `NationalSpire.PortraitEmotion.PortraitEmotion()`；输入表达式：`new() { Id = "neutral", Name = "平淡", Description = "默认人物剪影" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "neutral", Name = "平淡", Description = "默认人物剪影" }`

**赋值（含属性/字段和局部值）：**

- `Description` = `"默认人物剪影"`
- `Emotions` = `[new() { Id = "neutral", Name = "平淡", Description = "默认人物剪影" }]`
- `Id` = `"neutral"`
- `Name` = `"平淡"`
- `PersonId` = `person`
- `SelectedOutfit` = `"default"`

<a id="symbol-5c7df7a4e40d"></a>

## `NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string) — public static Texture2D Texture(CareerData data, string person)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Default(string)`](DatePresentationScreen.cs.md#symbol-927bbd82bd6a)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](DateSceneTesting.cs.md#symbol-91667df79532)

**调用：** `Godot.Image.Image()`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(bytes.ToArray())`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadPngFromBuffer(bytes.ToArray()) != Error.Ok`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`ReturnStatementSyntax: return ImageTexture.CreateFromImage(image);`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: IdentityGender.Of(data, person) == "女"`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("默认人物剪影读取失败。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("默认人物剪影读取失败。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`bytes.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: bytes.ToArray()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`stream.CopyTo(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.CopyTo(bytes);`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(DateDefaultPortraits).Assembly.GetManifestResourceStream("NationalSpire.DateDefaults." + gender + ".png")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: typeof(DateDefaultPortraits).Assembly.GetManifestResourceStream("NationalSpire.DateDefaults." + gender + ".png")!`

**赋值（含属性/字段和局部值）：**
