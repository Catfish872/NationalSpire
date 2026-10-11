# AvatarImages.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E463B3A21DF4AF4BA5F0B9E7232EA15AA919299CC1974AD9759D25B3126653F2`。来源：[源码](../../AvatarImages.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AvatarImages`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, AvatarArt> Cache = [];
```

<a id="symbol-2455dc6874f9"></a>

## `NationalSpire.AvatarImages.FromFile(string) — public static PlayerAvatar FromFile(string path)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** [`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`](AvatarImages.cs.md#symbol-14844fefd20e)；`Godot.Image.Image()`；`Godot.Image.LoadJpgFromBuffer(byte[])`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.Image.LoadWebpFromBuffer(byte[])`；`string.ToLowerInvariant()`；`System.ArgumentException.ArgumentException(string?)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.Path.GetExtension(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadJpgFromBuffer(byte[])`；输入表达式：`image.LoadJpgFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".jpg" or ".jpeg" => image.LoadJpgFromBuffer(bytes)`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".png" => image.LoadPngFromBuffer(bytes)`
- `Godot.Image.LoadWebpFromBuffer(byte[])`；输入表达式：`image.LoadWebpFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".webp" => image.LoadWebpFromBuffer(bytes)`
- `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；输入表达式：`FromImage(image, "image", "自定义头像")`；返回值紧邻使用处：`ReturnStatementSyntax: return FromImage(image, "image", "自定义头像");`
- `string.ToLowerInvariant()`；输入表达式：`Path.GetExtension(path).ToLowerInvariant()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetExtension(path).ToLowerInvariant()`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("无法读取图片，请选择 PNG、JPG 或 WebP 图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("无法读取图片，请选择 PNG、JPG 或 WebP 图片。");`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllBytes(path)`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(path).ToLowerInvariant`

**赋值（含属性/字段和局部值）：**


<a id="symbol-11dcaf1a0f5d"></a>

## `NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string) — public static PlayerAvatar FromArt(AvatarArt art, string source)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)；[`NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt)`](AvatarImages.cs.md#symbol-f46bb00e33dc)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`](AvatarImages.cs.md#symbol-14844fefd20e)；[`NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`](AvatarImages.cs.md#symbol-b10dde67e8a0)；`System.ArgumentException.ArgumentException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Description`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；`NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(art.Texture)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvatarAssets.Usable(art.Texture)`
- `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；输入表达式：`FromImage(image, source, art.Description)`；返回值紧邻使用处：`ReturnStatementSyntax: return FromImage(image, source, art.Description);`
- `NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`；输入表达式：`TextureImage(art.Texture!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TextureImage(art.Texture!)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("这张图片当前不可用。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("这张图片当前不可用。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1bd15f735eef"></a>

## `NationalSpire.AvatarImages.FromCardPng(byte[]) — public static PlayerAvatar FromCardPng(byte[] png)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`](AvatarImages.cs.md#symbol-14844fefd20e)；`Godot.Image.Image()`；`Godot.Image.LoadPngFromBuffer(byte[])`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(png)`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadPngFromBuffer(png) != Error.Ok`
- `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；输入表达式：`FromImage(image, "image", "角色卡头像")`；返回值紧邻使用处：`ReturnStatementSyntax: return FromImage(image, "image", "角色卡头像");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("无法解码角色卡头像。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("无法解码角色卡头像。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f46bb00e33dc"></a>

## `NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt) — public static async Task<PlayerAvatar> FromCharacterCardArt(Node owner, AvatarArt art)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`](AvatarImages.cs.md#symbol-11dcaf1a0f5d)；[`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`](AvatarImages.cs.md#symbol-14844fefd20e)；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.SubViewport.SubViewport()`；`Godot.Texture2D.GetImage()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Vector2I.Vector2I(int, int)`；`Godot.Viewport.GetTexture()`；`NationalSpire.CareerAvatar.CareerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Description`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`；`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；`NationalSpire.CareerAvatar.Art`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`owner.ToSignal(RenderingServer.Singleton, RenderingServer.SignalName.FramePostDraw)`；返回值紧邻使用处：`AwaitExpressionSyntax: await owner.ToSignal(RenderingServer.Singleton, RenderingServer.SignalName.FramePostDraw)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`owner.AddChild(viewport)`；返回值紧邻使用处：`ExpressionStatementSyntax: owner.AddChild(viewport);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`viewport.AddChild(new CareerAvatar { Size = new(192, 192), Art = art })`；返回值紧邻使用处：`ExpressionStatementSyntax: viewport.AddChild(new CareerAvatar { Size = new(192, 192), Art = art });`
- `Godot.Node.QueueFree()`；输入表达式：`viewport.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: viewport.QueueFree();`
- `Godot.SubViewport.SubViewport()`；输入表达式：`new SubViewport { Size = new(192, 192), TransparentBg = true, Disable3D = true,             RenderTargetUpdateMode = SubViewport.UpdateMode.Once }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SubViewport { Size = new(192, 192), TransparentBg = true, Disable3D = true,             RenderTargetUpdateMode = SubViewport.UpdateMode.Once }`
- `Godot.Texture2D.GetImage()`；输入表达式：`viewport.GetTexture().GetImage()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = viewport.GetTexture().GetImage()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(192, 192)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(192, 192)`
- `Godot.Vector2I.Vector2I(int, int)`；输入表达式：`new(192, 192)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(192, 192)`
- `Godot.Viewport.GetTexture()`；输入表达式：`viewport.GetTexture()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: viewport.GetTexture().GetImage`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(art.Texture)`；返回值紧邻使用处：`IfStatementSyntax: if (AvatarAssets.Usable(art.Texture)) return FromArt(art, "image");`
- `NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`；输入表达式：`FromArt(art, "image")`；返回值紧邻使用处：`ReturnStatementSyntax: return FromArt(art, "image");`
- `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；输入表达式：`FromImage(image, "image", art.Description)`；返回值紧邻使用处：`ReturnStatementSyntax: return FromImage(image, "image", art.Description);`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Size = new(192, 192), Art = art }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar { Size = new(192, 192), Art = art }`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `Disable3D` = `true`
- `RenderTargetUpdateMode` = `SubViewport.UpdateMode.Once`
- `Size` = `new(192, 192)`
- `TransparentBg` = `true`

<a id="symbol-b10dde67e8a0"></a>

## `NationalSpire.AvatarImages.TextureImage(Godot.Texture2D) — private static Image TextureImage(Texture2D texture)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`](AvatarImages.cs.md#symbol-11dcaf1a0f5d)；[`NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`](AvatarImages.cs.md#symbol-b10dde67e8a0)

**调用：** [`NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`](AvatarImages.cs.md#symbol-b10dde67e8a0)；`Godot.GodotObject.Dispose()`；`Godot.Image.Decompress()`；`Godot.Image.GetHeight()`；`Godot.Image.GetRegion(Godot.Rect2I)`；`Godot.Image.GetWidth()`；`Godot.Image.IsCompressed()`；`Godot.Rect2I.Rect2I(int, int, int, int)`；`Godot.Texture2D.GetImage()`；`Godot.Vector2.Vector2(float, float)`；`System.ArgumentException.ArgumentException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`image.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Dispose();`
- `Godot.Image.Decompress()`；输入表达式：`image.Decompress()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.Decompress() != Error.Ok`
- `Godot.Image.GetHeight()`；输入表达式：`source.GetHeight()`；返回值紧邻使用处：`ArgumentSyntax: source.GetHeight()`
- `Godot.Image.GetRegion(Godot.Rect2I)`；输入表达式：`source.GetRegion(new((int)region.Position.X, (int)region.Position.Y, (int)region.Size.X, (int)region.Size.Y))`；返回值紧邻使用处：`ReturnStatementSyntax: return source.GetRegion(new((int)region.Position.X, (int)region.Position.Y, (int)region.Size.X, (int)region.Size.Y));`
- `Godot.Image.GetWidth()`；输入表达式：`source.GetWidth()`；返回值紧邻使用处：`ArgumentSyntax: source.GetWidth()`
- `Godot.Image.IsCompressed()`；输入表达式：`image.IsCompressed()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.IsCompressed() && image.Decompress() != Error.Ok`
- `Godot.Rect2I.Rect2I(int, int, int, int)`；输入表达式：`new((int)region.Position.X, (int)region.Position.Y, (int)region.Size.X, (int)region.Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new((int)region.Position.X, (int)region.Position.Y, (int)region.Size.X, (int)region.Size.Y)`
- `Godot.Texture2D.GetImage()`；输入表达式：`texture.GetImage()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetImage()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(region.Size.X, source.GetHeight())`；返回值紧邻使用处：`AssignmentExpressionSyntax: region.Size = new(region.Size.X, source.GetHeight())`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(source.GetWidth(), region.Size.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: region.Size = new(source.GetWidth(), region.Size.Y)`
- `NationalSpire.AvatarImages.TextureImage(Godot.Texture2D)`；输入表达式：`TextureImage(atlas.Atlas)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TextureImage(atlas.Atlas)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("无法解码这张图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("无法解码这张图片。");`

**赋值（含属性/字段和局部值）：**

- `region.Size` = `new(region.Size.X, source.GetHeight())`
- `region.Size` = `new(source.GetWidth(), region.Size.Y)`

<a id="symbol-14844fefd20e"></a>

## `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string) — public static PlayerAvatar FromImage(Image image, string source, string label)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`](AvatarImages.cs.md#symbol-11dcaf1a0f5d)；[`NationalSpire.AvatarImages.FromCardPng(byte[])`](AvatarImages.cs.md#symbol-1bd15f735eef)；[`NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt)`](AvatarImages.cs.md#symbol-f46bb00e33dc)；[`NationalSpire.AvatarImages.FromFile(string)`](AvatarImages.cs.md#symbol-2455dc6874f9)；[`NationalSpire.AvatarSources.Steam()`](AvatarSources.cs.md#symbol-bc266fec0f45)

**调用：** [`NationalSpire.PlayerAvatar.Validate()`](PlayerAvatar.cs.md#symbol-96ff07617629)；`Godot.Image.Convert(Godot.Image.Format)`；`Godot.Image.Decompress()`；`Godot.Image.GetHeight()`；`Godot.Image.GetRegion(Godot.Rect2I)`；`Godot.Image.GetWidth()`；`Godot.Image.IsCompressed()`；`Godot.Image.IsEmpty()`；`Godot.Image.Resize(int, int, Godot.Image.Interpolation)`；`Godot.Image.SavePngToBuffer()`；`Godot.Rect2I.Rect2I(int, int, int, int)`；`NationalSpire.PlayerAvatar.PlayerAvatar()`；`System.ArgumentException.ArgumentException(string?)`；`System.Convert.ToBase64String(byte[])`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerAvatar.Label`；`NationalSpire.PlayerAvatar.MaxBytes`；`NationalSpire.PlayerAvatar.Png`；`NationalSpire.PlayerAvatar.Source`；`NationalSpire.PlayerAvatar.Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Convert(Godot.Image.Format)`；输入表达式：`square.Convert(Image.Format.Rgba8)`；返回值紧邻使用处：`ExpressionStatementSyntax: square.Convert(Image.Format.Rgba8);`
- `Godot.Image.Decompress()`；输入表达式：`image.Decompress()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.Decompress() != Error.Ok`
- `Godot.Image.GetHeight()`；输入表达式：`image.GetHeight()`；返回值紧邻使用处：`ArgumentSyntax: image.GetHeight()`
- `Godot.Image.GetHeight()`；输入表达式：`image.GetHeight()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.GetHeight() - edge`
- `Godot.Image.GetRegion(Godot.Rect2I)`；输入表达式：`image.GetRegion(new((image.GetWidth() - edge) / 2, (image.GetHeight() - edge) / 2, edge, edge))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = image.GetRegion(new((image.GetWidth() - edge) / 2, (image.GetHeight() - edge) / 2, edge, edge))`
- `Godot.Image.GetWidth()`；输入表达式：`image.GetWidth()`；返回值紧邻使用处：`ArgumentSyntax: image.GetWidth()`
- `Godot.Image.GetWidth()`；输入表达式：`image.GetWidth()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.GetWidth() - edge`
- `Godot.Image.IsCompressed()`；输入表达式：`image.IsCompressed()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.IsCompressed() && image.Decompress() != Error.Ok`
- `Godot.Image.IsEmpty()`；输入表达式：`image.IsEmpty()`；返回值紧邻使用处：`IfStatementSyntax: if (image.IsEmpty()) throw new ArgumentException("图片尺寸无效。");`
- `Godot.Image.Resize(int, int, Godot.Image.Interpolation)`；输入表达式：`square.Resize(size, size, Image.Interpolation.Lanczos)`；返回值紧邻使用处：`ExpressionStatementSyntax: square.Resize(size, size, Image.Interpolation.Lanczos);`
- `Godot.Image.SavePngToBuffer()`；输入表达式：`square.SavePngToBuffer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: png = square.SavePngToBuffer()`
- `Godot.Image.SavePngToBuffer()`；输入表达式：`square.SavePngToBuffer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = square.SavePngToBuffer()`
- `Godot.Rect2I.Rect2I(int, int, int, int)`；输入表达式：`new((image.GetWidth() - edge) / 2, (image.GetHeight() - edge) / 2, edge, edge)`；返回值紧邻使用处：`ArgumentSyntax: new((image.GetWidth() - edge) / 2, (image.GetHeight() - edge) / 2, edge, edge)`
- `NationalSpire.PlayerAvatar.PlayerAvatar()`；输入表达式：`new PlayerAvatar { Source = source, Label = label[..Math.Min(label.Length, 128)], Png = Convert.ToBase64String(png) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PlayerAvatar { Source = source, Label = label[..Math.Min(label.Length, 128)], Png = Convert.ToBase64String(png) }`
- `NationalSpire.PlayerAvatar.Validate()`；输入表达式：`avatar.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: avatar.Validate();`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("图片尺寸无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("图片尺寸无效。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("无法解码这张图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("无法解码这张图片。");`
- `System.Convert.ToBase64String(byte[])`；输入表达式：`Convert.ToBase64String(png)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Png = Convert.ToBase64String(png)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(edge, 192)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(edge, 192)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(image.GetWidth(), image.GetHeight())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(image.GetWidth(), image.GetHeight())`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(label.Length, 128)`；返回值紧邻使用处：`RangeExpressionSyntax: ..Math.Min(label.Length, 128)`

**赋值（含属性/字段和局部值）：**

- `Label` = `label[..Math.Min(label.Length, 128)]`
- `Png` = `Convert.ToBase64String(png)`
- `png` = `square.SavePngToBuffer()`
- `size` = `size * 3 / 4`
- `Source` = `source`

<a id="symbol-1edd50772202"></a>

## `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?) — public static AvatarArt? Read(PlayerAvatar? avatar)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`Select(NationalSpire.PlayerAvatar)`](AvatarScreen.cs.md#symbol-07697461993d)

**调用：** [`NationalSpire.PlayerAvatar.Validate()`](PlayerAvatar.cs.md#symbol-96ff07617629)；`Godot.Image.Image()`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Convert.FromBase64String(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.Cache`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PlayerAvatar.Label`；`NationalSpire.PlayerAvatar.Png`；`NationalSpire.PlayerAvatar.Source`；`NationalSpire.PlayerAvatar.Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(Convert.FromBase64String(avatar.Png))`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadPngFromBuffer(Convert.FromBase64String(avatar.Png)) != Error.Ok`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`ArgumentSyntax: ImageTexture.CreateFromImage(image)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(ImageTexture.CreateFromImage(image), CareerVisuals.Teal, avatar.Label)`；返回值紧邻使用处：`AssignmentExpressionSyntax: art = new(ImageTexture.CreateFromImage(image), CareerVisuals.Teal, avatar.Label)`
- `NationalSpire.PlayerAvatar.Validate()`；输入表达式：`avatar.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: avatar.Validate();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`Cache.Remove(Cache.Keys.First())`；返回值紧邻使用处：`ExpressionStatementSyntax: Cache.Remove(Cache.Keys.First());`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cache.TryGetValue(avatar.Png, out var art)`；返回值紧邻使用处：`IfStatementSyntax: if (Cache.TryGetValue(avatar.Png, out var art)) return art;`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`Cache.Keys.First()`；返回值紧邻使用处：`ArgumentSyntax: Cache.Keys.First()`
- `System.Convert.FromBase64String(string)`；输入表达式：`Convert.FromBase64String(avatar.Png)`；返回值紧邻使用处：`ArgumentSyntax: Convert.FromBase64String(avatar.Png)`

**赋值（含属性/字段和局部值）：**

- `art` = `new(ImageTexture.CreateFromImage(image), CareerVisuals.Teal, avatar.Label)`
- `Cache[avatar.Png]` = `art`
