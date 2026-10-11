# AiSettingsStore.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4797467984A9EDFE96A696A30C836685BBFEAA3CA5E16D088AD6120B395F549F`。来源：[源码](../../AiSettingsStore.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiSettingsStore`、`NationalSpire.AiSettingsStore.Blob`。

字段、事件及初始值（源码原样）：

```csharp
private static AiOptions? _options;
private static string _saved = "", _savedPath = "";
public int Length;
public IntPtr Data;
```

<a id="symbol-ec0f0fe61ab2"></a>

## `NationalSpire.AiSettingsStore.SettingsPath — private static string SettingsPath`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_ai_settings.json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_ai_settings.json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6eafcc5cdb79"></a>

## `NationalSpire.AiSettingsStore.SecretPath — private static string SecretPath`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_ai_key.bin")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_ai_key.bin")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b37e55b3af97"></a>

## `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions) — public static AiOptions Load(AiOptions legacy)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Current()`](Coop/CoopGroupChats.cs.md#symbol-2c4dd6def46d)；[`Current()`](Coop/CoopPrivateMessages.cs.md#symbol-b02c38cdc4a6)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](Coop/CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopCareerSession.Refresh()`](Coop/CoopCareerSession.cs.md#symbol-d972d69103cb)；[`NationalSpire.Coop.CoopCoordinator.Broadcast()`](Coop/CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** `Godot.GD.PushWarning(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore._options`；`NationalSpire.AiSettingsStore.SettingsPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] AI 配置无法读取，使用生涯中的配置副本。")`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] AI 配置无法读取，使用生涯中的配置副本。");`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(SettingsPath)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(SettingsPath)) _options = JsonSerializer.Deserialize<AiOptions>(File.ReadAllText(SettingsPath));`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(SettingsPath)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(SettingsPath)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<AiOptions>(File.ReadAllText(SettingsPath))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _options = JsonSerializer.Deserialize<AiOptions>(File.ReadAllText(SettingsPath))`

**赋值（含属性/字段和局部值）：**

- `_options` ??= `legacy`
- `_options` = `JsonSerializer.Deserialize<AiOptions>(File.ReadAllText(SettingsPath))`

<a id="symbol-ba3b31b1bb7c"></a>

## `NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions) — public static void Save(AiOptions options)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Coop.CoopCareerSession.SaveAi(NationalSpire.CareerData)`](Coop/CoopCareerSession.cs.md#symbol-6fb4f052a4e3)

**调用：** `System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore._options`；`NationalSpire.AiSettingsStore._saved`；`NationalSpire.AiSettingsStore._savedPath`；`NationalSpire.AiSettingsStore.SettingsPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath)!);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(SettingsPath)`；返回值紧邻使用处：`BinaryExpressionSyntax: _saved == content && _savedPath == SettingsPath && File.Exists(SettingsPath)`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(SettingsPath + ".tmp", SettingsPath, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(SettingsPath + ".tmp", SettingsPath, true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(SettingsPath + ".tmp", content)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(SettingsPath + ".tmp", content);`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(SettingsPath)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(SettingsPath)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(options)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(options)`

**赋值（含属性/字段和局部值）：**

- `_options` = `options`
- `_saved` = `content`
- `_savedPath` = `SettingsPath`

<a id="symbol-625514a0b3ae"></a>

## `NationalSpire.AiSettingsStore.ReadKey() — public static string? ReadKey()`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.ExportDiagnostics()`](CareerStore.cs.md#symbol-bdb986450a1c)；[`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)

**调用：** [`NationalSpire.AiSettingsStore.Transform(byte[], bool)`](AiSettingsStore.cs.md#symbol-a6a1804ed111)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RegisterSecret(string?)`](Diagnostics.cs.md#symbol-4f621c46a4ca)；`Godot.GD.PushWarning(string)`；`string.IsNullOrWhiteSpace(string?)`；`System.Exception.GetType()`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllBytes(string)`；`System.OperatingSystem.IsWindows()`；`System.Text.Encoding.GetString(byte[])`

**字段、属性、事件及方法组引用：** `<anonymous type: string status, string error>.error`；`<anonymous type: string status, string error>.status`；`<anonymous type: string status>.status`；`NationalSpire.AiSettingsStore.SecretPath`；`NationalSpire.AiSettingsStore.Transform(byte[], bool)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RegisterSecret(string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 已保存密钥无法解密，请重新输入。")`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 已保存密钥无法解密，请重新输入。");`
- `NationalSpire.AiSettingsStore.Transform(byte[], bool)`；输入表达式：`Transform(File.ReadAllBytes(SecretPath), false)`；返回值紧邻使用处：`ArgumentSyntax: Transform(File.ReadAllBytes(SecretPath), false)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.credential.read", new { status = "failed", error = e.GetType().Name })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.credential.read", new { status = "failed", error = e.GetType().Name });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.credential.read", new { status = OperatingSystem.IsWindows() ? "missing" : "unsupported" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.credential.read", new { status = OperatingSystem.IsWindows() ? "missing" : "unsupported" });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("ai.credential.read", new { status = string.IsNullOrWhiteSpace(value) ? "empty" : "loaded" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("ai.credential.read", new { status = string.IsNullOrWhiteSpace(value) ? "empty" : "loaded" });`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(value);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(value) ? "empty" : "loaded"`
- `System.Exception.GetType()`；输入表达式：`e.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetType().Name`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(SecretPath)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(SecretPath)`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(SecretPath)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(SecretPath)`
- `System.OperatingSystem.IsWindows()`；输入表达式：`OperatingSystem.IsWindows()`；返回值紧邻使用处：`ConditionalExpressionSyntax: OperatingSystem.IsWindows() ? "missing" : "unsupported"`
- `System.OperatingSystem.IsWindows()`；输入表达式：`OperatingSystem.IsWindows()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OperatingSystem.IsWindows()`
- `System.Text.Encoding.GetString(byte[])`；输入表达式：`Encoding.UTF8.GetString(Transform(File.ReadAllBytes(SecretPath), false))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Encoding.UTF8.GetString(Transform(File.ReadAllBytes(SecretPath), false))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2bce026c34b0"></a>

## `NationalSpire.AiSettingsStore.SaveKey(string) — public static void SaveKey(string key)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.PersistKey(string)`](AiService.cs.md#symbol-1db4f1f2513d)

**调用：** [`NationalSpire.AiSettingsStore.Transform(byte[], bool)`](AiSettingsStore.cs.md#symbol-a6a1804ed111)；`string.IsNullOrWhiteSpace(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.IO.Path.GetDirectoryName(string?)`；`System.OperatingSystem.IsWindows()`；`System.PlatformNotSupportedException.PlatformNotSupportedException(string?)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.SecretPath`；`NationalSpire.AiSettingsStore.Transform(byte[], bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiSettingsStore.Transform(byte[], bool)`；输入表达式：`Transform(Encoding.UTF8.GetBytes(key), true)`；返回值紧邻使用处：`ArgumentSyntax: Transform(Encoding.UTF8.GetBytes(key), true)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(key)) { if (File.Exists(SecretPath)) File.Delete(SecretPath); return; }`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(SecretPath)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(SecretPath)!);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(SecretPath)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(SecretPath);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(SecretPath)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(SecretPath)) File.Delete(SecretPath);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(SecretPath + ".tmp", SecretPath, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(SecretPath + ".tmp", SecretPath, true);`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(SecretPath + ".tmp", Transform(Encoding.UTF8.GetBytes(key), true))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(SecretPath + ".tmp", Transform(Encoding.UTF8.GetBytes(key), true));`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(SecretPath)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(SecretPath)!`
- `System.OperatingSystem.IsWindows()`；输入表达式：`OperatingSystem.IsWindows()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OperatingSystem.IsWindows()`
- `System.PlatformNotSupportedException.PlatformNotSupportedException(string?)`；输入表达式：`new PlatformNotSupportedException("当前系统仅支持临时密钥。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new PlatformNotSupportedException("当前系统仅支持临时密钥。");`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(key)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-185a9677b029"></a>

## `NationalSpire.AiSettingsStore.CryptProtectData(ref NationalSpire.AiSettingsStore.Blob, string?, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob) — [DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]      [return: MarshalAs(UnmanagedType.Bool)]      private static extern bool CryptProtectData(ref Blob input, string? description, IntPtr entropy, IntPtr reserved, IntPtr prompt, int flags, out Blob output);`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsStore.Transform(byte[], bool)`](AiSettingsStore.cs.md#symbol-a6a1804ed111)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7dfdad80d4ea"></a>

## `NationalSpire.AiSettingsStore.CryptUnprotectData(ref NationalSpire.AiSettingsStore.Blob, nint, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob) — [DllImport("crypt32.dll", SetLastError = true)]      [return: MarshalAs(UnmanagedType.Bool)]      private static extern bool CryptUnprotectData(ref Blob input, IntPtr description, IntPtr entropy, IntPtr reserved, IntPtr prompt, int flags, out Blob output);`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsStore.Transform(byte[], bool)`](AiSettingsStore.cs.md#symbol-a6a1804ed111)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eac23c65d2fc"></a>

## `NationalSpire.AiSettingsStore.LocalFree(nint) — [DllImport("kernel32.dll")] private static extern IntPtr LocalFree(IntPtr memory);`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsStore.Transform(byte[], bool)`](AiSettingsStore.cs.md#symbol-a6a1804ed111)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a6a1804ed111"></a>

## `NationalSpire.AiSettingsStore.Transform(byte[], bool) — private static byte[] Transform(byte[] bytes, bool protect)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsStore.ReadKey()`](AiSettingsStore.cs.md#symbol-625514a0b3ae)；[`NationalSpire.AiSettingsStore.SaveKey(string)`](AiSettingsStore.cs.md#symbol-2bce026c34b0)

**调用：** [`NationalSpire.AiSettingsStore.CryptProtectData(ref NationalSpire.AiSettingsStore.Blob, string?, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob)`](AiSettingsStore.cs.md#symbol-185a9677b029)；[`NationalSpire.AiSettingsStore.CryptUnprotectData(ref NationalSpire.AiSettingsStore.Blob, nint, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob)`](AiSettingsStore.cs.md#symbol-7dfdad80d4ea)；[`NationalSpire.AiSettingsStore.LocalFree(nint)`](AiSettingsStore.cs.md#symbol-eac23c65d2fc)；`NationalSpire.AiSettingsStore.Blob.Blob()`；`System.Array.Clear(System.Array)`；`System.ComponentModel.Win32Exception.Win32Exception(int)`；`System.Runtime.InteropServices.Marshal.AllocHGlobal(int)`；`System.Runtime.InteropServices.Marshal.Copy(byte[], int, nint, int)`；`System.Runtime.InteropServices.Marshal.Copy(nint, byte[], int, int)`；`System.Runtime.InteropServices.Marshal.FreeHGlobal(nint)`；`System.Runtime.InteropServices.Marshal.GetLastWin32Error()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Blob.Data`；`NationalSpire.AiSettingsStore.Blob.Length`；`NationalSpire.AiSettingsStore.CryptProtectData(ref NationalSpire.AiSettingsStore.Blob, string?, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob)`；`NationalSpire.AiSettingsStore.CryptUnprotectData(ref NationalSpire.AiSettingsStore.Blob, nint, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob)`；`NationalSpire.AiSettingsStore.LocalFree(nint)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiSettingsStore.Blob.Blob()`；输入表达式：`new Blob { Length = bytes.Length, Data = Marshal.AllocHGlobal(bytes.Length) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Blob { Length = bytes.Length, Data = Marshal.AllocHGlobal(bytes.Length) }`
- `NationalSpire.AiSettingsStore.CryptProtectData(ref NationalSpire.AiSettingsStore.Blob, string?, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob)`；输入表达式：`CryptProtectData(ref input, "NationalSpire", IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)`；返回值紧邻使用处：`ConditionalExpressionSyntax: protect ? CryptProtectData(ref input, "NationalSpire", IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)                  : CryptUnprotectData(ref input, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)`
- `NationalSpire.AiSettingsStore.CryptUnprotectData(ref NationalSpire.AiSettingsStore.Blob, nint, nint, nint, nint, int, out NationalSpire.AiSettingsStore.Blob)`；输入表达式：`CryptUnprotectData(ref input, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)`；返回值紧邻使用处：`ConditionalExpressionSyntax: protect ? CryptProtectData(ref input, "NationalSpire", IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)                  : CryptUnprotectData(ref input, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)`
- `NationalSpire.AiSettingsStore.LocalFree(nint)`；输入表达式：`LocalFree(output.Data)`；返回值紧邻使用处：`ExpressionStatementSyntax: LocalFree(output.Data);`
- `System.Array.Clear(System.Array)`；输入表达式：`Array.Clear(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: Array.Clear(bytes);`
- `System.ComponentModel.Win32Exception.Win32Exception(int)`；输入表达式：`new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());`
- `System.Runtime.InteropServices.Marshal.AllocHGlobal(int)`；输入表达式：`Marshal.AllocHGlobal(bytes.Length)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Data = Marshal.AllocHGlobal(bytes.Length)`
- `System.Runtime.InteropServices.Marshal.Copy(byte[], int, nint, int)`；输入表达式：`Marshal.Copy(bytes, 0, input.Data, bytes.Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: Marshal.Copy(bytes, 0, input.Data, bytes.Length);`
- `System.Runtime.InteropServices.Marshal.Copy(nint, byte[], int, int)`；输入表达式：`Marshal.Copy(output.Data, result, 0, result.Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: Marshal.Copy(output.Data, result, 0, result.Length);`
- `System.Runtime.InteropServices.Marshal.FreeHGlobal(nint)`；输入表达式：`Marshal.FreeHGlobal(input.Data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Marshal.FreeHGlobal(input.Data);`
- `System.Runtime.InteropServices.Marshal.GetLastWin32Error()`；输入表达式：`Marshal.GetLastWin32Error()`；返回值紧邻使用处：`ArgumentSyntax: Marshal.GetLastWin32Error()`

**赋值（含属性/字段和局部值）：**

- `Data` = `Marshal.AllocHGlobal(bytes.Length)`
- `Length` = `bytes.Length`
