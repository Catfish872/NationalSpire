# GameCompatibility.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`586D177491986B4940568F6153D4CC2DF1BC0ECD38F1A921290CAA96D6B1918E`。来源：[源码](../../GameCompatibility.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCompatibility`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Lazy<SeedApi> Seeds = new(() => new(typeof(StringHelper), typeof(Rng)));
```

<a id="symbol-9bd705ffd995"></a>

## `NationalSpire.GameCompatibility.SeedMode — public static string SeedMode`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.Description`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-68363869a9cf"></a>

## `NationalSpire.GameCompatibility.ActRng(string) — public static Rng ActRng(string seed)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCompatibility.Check(bool)`](Coop/CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.GameBridge.CreateActSelectionRng(string)`](GameBridge.cs.md#symbol-e22050f58fa0)

**调用：** [`NationalSpire.SeedApi.FromText(string, string)`](RuntimeApi.cs.md#symbol-84805f281f9e)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.FromText(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromText(string, string)`；输入表达式：`Seeds.Value.FromText(seed, "act_selection")`；返回值紧邻使用处：`CastExpressionSyntax: (Rng)Seeds.Value.FromText(seed, "act_selection")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a2187753991c"></a>

## `NationalSpire.GameCompatibility.MapRng(object, int) — public static Rng MapRng(object runRng, int act)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)

**调用：** [`NationalSpire.SeedApi.FromRun(object, string)`](RuntimeApi.cs.md#symbol-e32ac6048df2)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.FromRun(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromRun(object, string)`；输入表达式：`Seeds.Value.FromRun(runRng, $"act_{act}_map")`；返回值紧邻使用处：`CastExpressionSyntax: (Rng)Seeds.Value.FromRun(runRng, $"act_{act}_map")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f20a223e98d6"></a>

## `NationalSpire.GameCompatibility.Version() — public static string Version()`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.Path.Combine(string, string, string)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Reflection.Assembly.GetName()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`；`System.Version.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("compat.version", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("compat.version", e);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(file)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(file))                 { using var json = JsonDocument.Parse(File.ReadAllText(file)); return json.RootElement.GetProperty("version").GetString() ?? "未知版本"; }`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(file)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(file)`
- `System.IO.Path.Combine(string, string, string)`；输入表达式：`Path.Combine(directory, "..", "release_info.json")`；返回值紧邻使用处：`InitializerExpressionSyntax: { Path.Combine(directory, "release_info.json"), Path.Combine(directory, "..", "release_info.json") }`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, "release_info.json")`；返回值紧邻使用处：`InitializerExpressionSyntax: { Path.Combine(directory, "release_info.json"), Path.Combine(directory, "..", "release_info.json") }`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(typeof(NGame).Assembly.Location)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(typeof(NGame).Assembly.Location)!`
- `System.Reflection.Assembly.GetName()`；输入表达式：`typeof(NGame).Assembly.GetName()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(NGame).Assembly.GetName().Version`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`.Invoke(null, null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: reader?.Invoke(null, null)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(File.ReadAllText(file))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(File.ReadAllText(file))`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`json.RootElement.GetProperty("version")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: json.RootElement.GetProperty("version").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`json.RootElement.GetProperty("version").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: json.RootElement.GetProperty("version").GetString() ?? "未知版本"`
- `System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`；输入表达式：`typeof(NGame).GetMethod("GetGameVersion", BindingFlags.Public | BindingFlags.Static, Type.EmptyTypes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(NGame).GetMethod("GetGameVersion", BindingFlags.Public | BindingFlags.Static, Type.EmptyTypes)`
- `System.Version.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(NGame).Assembly.GetName().Version?.ToString()`

**赋值（含属性/字段和局部值）：**
