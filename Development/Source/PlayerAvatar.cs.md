# PlayerAvatar.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`34EE13E574840163C5314A6357CAACDF17B82E509CE26C0D01DE04B53B45EDF4`。来源：[源码](../../PlayerAvatar.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PlayerAvatar`。

字段、事件及初始值（源码原样）：

```csharp
public const int MaxBytes = 36 * 1024;
public const int MaxText = 52000;
```

<a id="symbol-d92a5fb95139"></a>

## `NationalSpire.PlayerAvatar.Source — public string Source`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ed105c26b2c3"></a>

## `NationalSpire.PlayerAvatar.Label — public string Label`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-00a9257868c3"></a>

## `NationalSpire.PlayerAvatar.Png — public string Png`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-56103d474cac"></a>

## `NationalSpire.PlayerAvatar.Read(string) — public static PlayerAvatar Read(string json)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.PlayerAvatar.Validate()`](PlayerAvatar.cs.md#symbol-96ff07617629)；`System.ArgumentException.ArgumentException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerAvatar.MaxText`；`NationalSpire.PlayerAvatar.Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PlayerAvatar.Validate()`；输入表达式：`value.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: value.Validate();`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像内容过大。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像内容过大。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像内容为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new ArgumentException("头像内容为空。")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PlayerAvatar>(json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PlayerAvatar>(json) ?? throw new ArgumentException("头像内容为空。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-96ff07617629"></a>

## `NationalSpire.PlayerAvatar.Validate() — public void Validate()`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`](AvatarImages.cs.md#symbol-14844fefd20e)；[`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`](AvatarImages.cs.md#symbol-1edd50772202)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CharacterCardPng.Export(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar)`](CharacterCardPng.cs.md#symbol-e9bb5cec943f)；[`NationalSpire.CharacterCardPng.Import(NationalSpire.CareerData, byte[], System.Func<byte[], NationalSpire.PlayerAvatar>?)`](CharacterCardPng.cs.md#symbol-c7101cd02992)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)；[`NationalSpire.PlayerAvatar.Read(string)`](PlayerAvatar.cs.md#symbol-56103d474cac)

**调用：** `System.ArgumentException.ArgumentException(string?)`；`System.Buffers.Binary.BinaryPrimitives.ReadInt32BigEndian(System.ReadOnlySpan<byte>)`；`System.Convert.FromBase64String(string)`；`System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；`T[]?.AsSpan<T>(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerAvatar.Label`；`NationalSpire.PlayerAvatar.MaxBytes`；`NationalSpire.PlayerAvatar.Png`；`NationalSpire.PlayerAvatar.Source`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像尺寸无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像尺寸无效。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像设置无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像设置无效。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像图片不完整。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像图片不完整。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像图片格式无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像图片格式无效。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像图片过大。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像图片过大。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("头像需要有效的 PNG 图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("头像需要有效的 PNG 图片。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("自动头像不应包含图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("自动头像不应包含图片。");`
- `System.Buffers.Binary.BinaryPrimitives.ReadInt32BigEndian(System.ReadOnlySpan<byte>)`；输入表达式：`BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(16, 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(16, 4))`
- `System.Buffers.Binary.BinaryPrimitives.ReadInt32BigEndian(System.ReadOnlySpan<byte>)`；输入表达式：`BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(20, 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(20, 4))`
- `System.Buffers.Binary.BinaryPrimitives.ReadInt32BigEndian(System.ReadOnlySpan<byte>)`；输入表达式：`BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(8, 4))`；返回值紧邻使用处：`BinaryExpressionSyntax: BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(8, 4)) != 13`
- `System.Buffers.Binary.BinaryPrimitives.ReadInt32BigEndian(System.ReadOnlySpan<byte>)`；输入表达式：`BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(offset, 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(offset, 4))`
- `System.Convert.FromBase64String(string)`；输入表达式：`Convert.FromBase64String(Png)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bytes = Convert.FromBase64String(Png)`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`bytes.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !bytes.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`bytes.AsSpan(12, 4).SequenceEqual("IHDR"u8)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !bytes.AsSpan(12, 4).SequenceEqual("IHDR"u8)`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`type.SequenceEqual("IDAT"u8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: pixels |= type.SequenceEqual("IDAT"u8)`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`type.SequenceEqual("IEND"u8)`；返回值紧邻使用处：`IfStatementSyntax: if (type.SequenceEqual("IEND"u8)) { ended = length == 0 && offset == bytes.Length; break; }`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(0, 8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bytes.AsSpan(0, 8).SequenceEqual`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(12, 4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bytes.AsSpan(12, 4).SequenceEqual`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(16, 4)`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(16, 4)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(20, 4)`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(20, 4)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(8, 4)`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(8, 4)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(offset + 4, 4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bytes.AsSpan(offset + 4, 4)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(offset, 4)`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(offset, 4)`

**赋值（含属性/字段和局部值）：**

- `bytes` = `Convert.FromBase64String(Png)`
- `ended` = `length == 0 && offset == bytes.Length`
- `offset` += `length + 12`
- `pixels` |= `type.SequenceEqual("IDAT"u8)`
