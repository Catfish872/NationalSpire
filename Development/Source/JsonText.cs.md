# JsonText.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`05B6EE8EC6EA82AA43FCFA00B697D3BC5707A2351C526D434CEACACCDF6805B3`。来源：[源码](../../JsonText.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.JsonText`、`NationalSpire.JsonText.PrefixStream`。

字段、事件及初始值（源码原样）：

```csharp
private int _position;
```

<a id="symbol-3f401a852f9d"></a>

## `NationalSpire.JsonText.Read<T>(System.IO.Stream, System.Text.Json.JsonSerializerOptions) — internal static T? Read<T>(Stream input, JsonSerializerOptions options)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.Import(string, byte[])`](CareerLibrary.cs.md#symbol-b347de421d96)；[`NationalSpire.CareerLibrary.List(string)`](CareerLibrary.cs.md#symbol-49ca8927a7b3)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`](DateSceneMemories.cs.md#symbol-8302de288689)；[`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-99fb40e5b954)

**调用：** [`NationalSpire.JsonText.EncodingOf(System.ReadOnlySpan<byte>)`](JsonText.cs.md#symbol-f0c08d7d4d34)；`NationalSpire.JsonText.PrefixStream.PrefixStream(System.IO.Stream, System.ReadOnlyMemory<byte>)`；`System.IO.Stream.ReadAtLeast(System.Span<byte>, int, bool)`；`System.Text.Encoding.CreateTranscodingStream(System.IO.Stream, System.Text.Encoding, System.Text.Encoding, bool)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(System.IO.Stream, System.Text.Json.JsonSerializerOptions?)`；`T[]?.AsMemory<T>(int, int)`；`T[]?.AsSpan<T>(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.JsonText.EncodingOf(System.ReadOnlySpan<byte>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.JsonText.EncodingOf(System.ReadOnlySpan<byte>)`；输入表达式：`EncodingOf(prefix.AsSpan(0, count))`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (encoding, skip) = EncodingOf(prefix.AsSpan(0, count))`
- `NationalSpire.JsonText.PrefixStream.PrefixStream(System.IO.Stream, System.ReadOnlyMemory<byte>)`；输入表达式：`new PrefixStream(input, prefix.AsMemory(skip, count - skip))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrefixStream(input, prefix.AsMemory(skip, count - skip))`
- `System.IO.Stream.ReadAtLeast(System.Span<byte>, int, bool)`；输入表达式：`input.ReadAtLeast(prefix, prefix.Length, throwOnEndOfStream: false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = input.ReadAtLeast(prefix, prefix.Length, throwOnEndOfStream: false)`
- `System.Text.Encoding.CreateTranscodingStream(System.IO.Stream, System.Text.Encoding, System.Text.Encoding, bool)`；输入表达式：`Encoding.CreateTranscodingStream(content, encoding, Encoding.UTF8, leaveOpen: true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Encoding.CreateTranscodingStream(content, encoding, Encoding.UTF8, leaveOpen: true)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(System.IO.Stream, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<T>(content, options)`；返回值紧邻使用处：`ReturnStatementSyntax: return JsonSerializer.Deserialize<T>(content, options);`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(System.IO.Stream, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<T>(utf8, options)`；返回值紧邻使用处：`ReturnStatementSyntax: return JsonSerializer.Deserialize<T>(utf8, options);`
- `T[]?.AsMemory<T>(int, int)`；输入表达式：`prefix.AsMemory(skip, count - skip)`；返回值紧邻使用处：`ArgumentSyntax: prefix.AsMemory(skip, count - skip)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`prefix.AsSpan(0, count)`；返回值紧邻使用处：`ArgumentSyntax: prefix.AsSpan(0, count)`

**赋值（含属性/字段和局部值）：**

- `var (encoding, skip)` = `EncodingOf(prefix.AsSpan(0, count))`

<a id="symbol-f0c08d7d4d34"></a>

## `NationalSpire.JsonText.EncodingOf(System.ReadOnlySpan<byte>) — private static (Encoding Encoding, int Skip) EncodingOf(ReadOnlySpan<byte> prefix)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.JsonText.Read<T>(System.IO.Stream, System.Text.Json.JsonSerializerOptions)`](JsonText.cs.md#symbol-3f401a852f9d)

**调用：** `System.Text.UTF32Encoding.UTF32Encoding(bool, bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.UTF32Encoding.UTF32Encoding(bool, bool)`；输入表达式：`new UTF32Encoding(true, true)`；返回值紧邻使用处：`ArgumentSyntax: new UTF32Encoding(true, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-04627d105a90"></a>

## `NationalSpire.JsonText.PrefixStream.Read(System.Span<byte>) — public override int Read(Span<byte> buffer)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.JsonText.PrefixStream.Read(byte[], int, int)`](JsonText.cs.md#symbol-e45bae5511ec)

**调用：** `System.IO.Stream.Read(System.Span<byte>)`；`System.Math.Min(int, int)`；`System.ReadOnlySpan<T>.CopyTo(System.Span<T>)`；`System.ReadOnlySpan<T>.Slice(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.JsonText.PrefixStream._position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Stream.Read(System.Span<byte>)`；输入表达式：`source.Read(buffer)`；返回值紧邻使用处：`ReturnStatementSyntax: return source.Read(buffer);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(buffer.Length, prefix.Length - _position)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(buffer.Length, prefix.Length - _position)`
- `System.ReadOnlySpan<T>.CopyTo(System.Span<T>)`；输入表达式：`prefix.Span.Slice(_position, count).CopyTo(buffer)`；返回值紧邻使用处：`ExpressionStatementSyntax: prefix.Span.Slice(_position, count).CopyTo(buffer);`
- `System.ReadOnlySpan<T>.Slice(int, int)`；输入表达式：`prefix.Span.Slice(_position, count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: prefix.Span.Slice(_position, count).CopyTo`

**赋值（含属性/字段和局部值）：**

- `_position` += `count`

<a id="symbol-e45bae5511ec"></a>

## `NationalSpire.JsonText.PrefixStream.Read(byte[], int, int) — public override int Read(byte[] buffer, int offset, int count)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.JsonText.PrefixStream.Read(System.Span<byte>)`](JsonText.cs.md#symbol-04627d105a90)；`T[]?.AsSpan<T>(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.JsonText.PrefixStream.Read(System.Span<byte>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.JsonText.PrefixStream.Read(System.Span<byte>)`；输入表达式：`Read(buffer.AsSpan(offset, count))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Read(buffer.AsSpan(offset, count))`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`buffer.AsSpan(offset, count)`；返回值紧邻使用处：`ArgumentSyntax: buffer.AsSpan(offset, count)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4211bda1455c"></a>

## `NationalSpire.JsonText.PrefixStream.CanRead — public override bool CanRead`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fd700c4d3e8f"></a>

## `NationalSpire.JsonText.PrefixStream.CanSeek — public override bool CanSeek`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8f06889832db"></a>

## `NationalSpire.JsonText.PrefixStream.CanWrite — public override bool CanWrite`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-26bbd57da257"></a>

## `NationalSpire.JsonText.PrefixStream.Length — public override long Length`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2a91d494dd8d"></a>

## `NationalSpire.JsonText.PrefixStream.Position — public override long Position`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8fc027b33d01"></a>

## `NationalSpire.JsonText.PrefixStream.Flush() — public override void Flush()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7e16019705d3"></a>

## `NationalSpire.JsonText.PrefixStream.Seek(long, System.IO.SeekOrigin) — public override long Seek(long offset, SeekOrigin origin)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2f083a64f059"></a>

## `NationalSpire.JsonText.PrefixStream.SetLength(long) — public override void SetLength(long value)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3c1a1c41065"></a>

## `NationalSpire.JsonText.PrefixStream.Write(byte[], int, int) — public override void Write(byte[] buffer, int offset, int count)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**
