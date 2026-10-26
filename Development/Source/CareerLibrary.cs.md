# CareerLibrary.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`01FFD1C6FCF432BF00157E14F0281DC260490C394E1ECC49D6114363338BCF54`。来源：[源码](../../CareerLibrary.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerLibraryEntry`、`NationalSpire.CareerLibrary`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-aa9eb7491d1b"></a>

## `NationalSpire.CareerLibrary.Selection(string) — private static string Selection(string original)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.Select(string, string)`](CareerLibrary.cs.md#symbol-e83d55812872)；[`NationalSpire.CareerLibrary.SelectedPath(string)`](CareerLibrary.cs.md#symbol-8caea35cd8af)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8caea35cd8af"></a>

## `NationalSpire.CareerLibrary.SelectedPath(string) — public static string SelectedPath(string original)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.Delete(string, string)`](CareerLibrary.cs.md#symbol-261c89b42954)；[`NationalSpire.CareerLibrary.List(string)`](CareerLibrary.cs.md#symbol-49ca8927a7b3)；[`NationalSpire.CareerStore.FilePath`](CareerStore.cs.md#symbol-1b56b90e6589)

**调用：** [`NationalSpire.CareerLibrary.Selection(string)`](CareerLibrary.cs.md#symbol-aa9eb7491d1b)；[`NationalSpire.CareerLibrary.ValidName(string)`](CareerLibrary.cs.md#symbol-42ea11f25dc4)；`string.Trim()`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLibrary.Selection(string)`；`NationalSpire.CareerLibrary.ValidName(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.Selection(string)`；输入表达式：`Selection(original)`；返回值紧邻使用处：`ArgumentSyntax: Selection(original)`
- `NationalSpire.CareerLibrary.ValidName(string)`；输入表达式：`ValidName(file)`；返回值紧邻使用处：`BinaryExpressionSyntax: ValidName(file) && File.Exists(path)`
- `string.Trim()`；输入表达式：`File.ReadAllText(Selection(original)).Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllText(Selection(original)).Trim()`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: ValidName(file) && File.Exists(path)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(Selection(original))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(Selection(original))`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(Selection(original))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: File.ReadAllText(Selection(original)).Trim`
- `System.IO.Path.Combine(string, string)`；输入表达式：`System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, file)`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(original)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.IO.Path.GetDirectoryName(original)!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-42ea11f25dc4"></a>

## `NationalSpire.CareerLibrary.ValidName(string) — private static bool ValidName(string file)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.Delete(string, string)`](CareerLibrary.cs.md#symbol-261c89b42954)；[`NationalSpire.CareerLibrary.List(string)`](CareerLibrary.cs.md#symbol-49ca8927a7b3)；[`NationalSpire.CareerLibrary.Select(string, string)`](CareerLibrary.cs.md#symbol-e83d55812872)；[`NationalSpire.CareerLibrary.SelectedPath(string)`](CareerLibrary.cs.md#symbol-8caea35cd8af)

**调用：** `string.EndsWith(string)`；`string.StartsWith(string)`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.EndsWith(string)`；输入表达式：`file.EndsWith(".json")`；返回值紧邻使用处：`BinaryExpressionSyntax: file.StartsWith("national_spire_career-") && file.EndsWith(".json")`
- `string.StartsWith(string)`；输入表达式：`file.StartsWith("national_spire_career-")`；返回值紧邻使用处：`BinaryExpressionSyntax: file.StartsWith("national_spire_career-") && file.EndsWith(".json")`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(file[22..^5], "N", out _)`；返回值紧邻使用处：`BinaryExpressionSyntax: file.StartsWith("national_spire_career-") && file.EndsWith(".json") && Guid.TryParseExact(file[22..^5], "N", out _)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e83d55812872"></a>

## `NationalSpire.CareerLibrary.Select(string, string) — public static void Select(string original, string path)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.SwitchCareer(string)`](CareerStore.cs.md#symbol-67c415b86d89)

**调用：** [`NationalSpire.CareerLibrary.Selection(string)`](CareerLibrary.cs.md#symbol-aa9eb7491d1b)；[`NationalSpire.CareerLibrary.ValidName(string)`](CareerLibrary.cs.md#symbol-42ea11f25dc4)；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFileName(string?)`；`System.IO.Path.GetFullPath(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLibrary.Selection(string)`；`NationalSpire.CareerLibrary.ValidName(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.Selection(string)`；输入表达式：`Selection(original)`；返回值紧邻使用处：`ArgumentSyntax: Selection(original)`
- `NationalSpire.CareerLibrary.Selection(string)`；输入表达式：`Selection(original)`；返回值紧邻使用处：`BinaryExpressionSyntax: Selection(original) + ".tmp"`
- `NationalSpire.CareerLibrary.ValidName(string)`；输入表达式：`ValidName(System.IO.Path.GetFileName(path))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ValidName(System.IO.Path.GetFileName(path))`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(Selection(original) + ".tmp", Selection(original), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(Selection(original) + ".tmp", Selection(original), true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(Selection(original) + ".tmp", System.IO.Path.GetFileName(path))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(Selection(original) + ".tmp", System.IO.Path.GetFileName(path));`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯路径无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("生涯路径无效。");`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(original))`；返回值紧邻使用处：`BinaryExpressionSyntax: System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(original)) != System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(path))`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(path))`；返回值紧邻使用处：`BinaryExpressionSyntax: System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(original)) != System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(path))`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`System.IO.Path.GetFileName(path)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetFileName(path)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`System.IO.Path.GetFullPath(original)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetFullPath(original)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`System.IO.Path.GetFullPath(path)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetFullPath(path)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-49ca8927a7b3"></a>

## `NationalSpire.CareerLibrary.List(string) — public static IEnumerable<CareerLibraryEntry> List(string original)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLibrary.SelectedPath(string)`](CareerLibrary.cs.md#symbol-8caea35cd8af)；[`NationalSpire.CareerLibrary.ValidName(string)`](CareerLibrary.cs.md#symbol-42ea11f25dc4)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](Coop/CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`NationalSpire.CareerLibraryEntry.CareerLibraryEntry(string, string, int, int, bool, string)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.Directory.Exists(string?)`；`System.IO.Directory.GetFiles(string, string)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLibrary.SelectedPath(string)`；`NationalSpire.CareerLibrary.ValidName(string)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(d)`
- `NationalSpire.CareerLibrary.SelectedPath(string)`；输入表达式：`SelectedPath(original)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SelectedPath(original)`
- `NationalSpire.CareerLibrary.ValidName(string)`；输入表达式：`ValidName(System.IO.Path.GetFileName(f))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => ValidName(System.IO.Path.GetFileName(f))`
- `NationalSpire.CareerLibraryEntry.CareerLibraryEntry(string, string, int, int, bool, string)`；输入表达式：`new(file, CareerEngine.Name(d), d.Season, SeasonCalendar.Day(d, d.Day), file == selected, GameCalendar.Text(d, d.Day))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(file, CareerEngine.Name(d), d.Season, SeasonCalendar.Day(d, d.Day), file == selected, GameCalendar.Text(d, d.Day));`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CareerData>(File.ReadAllBytes(file))`；返回值紧邻使用处：`AssignmentExpressionSyntax: d = CoopJson.Read<CareerData>(File.ReadAllBytes(file))`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, d.Day)`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Text(d, d.Day)`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, d.Day)`；返回值紧邻使用处：`ArgumentSyntax: SeasonCalendar.Day(d, d.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Directory.GetFiles(folder, "national_spire_career*.json").Where(f => ValidName(System.IO.Path.GetFileName(f))).OrderByDescending(File.GetLastWriteTimeUtc)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string file in Directory.GetFiles(folder, "national_spire_career*.json").Where(f => ValidName(System.IO.Path.GetFileName(f))).OrderByDescending(File.GetLastWriteTimeUtc))          {              CareerData? d = null; try { d = CoopJson.Read<CareerData>(File.ReadAllBytes(file)); } catch { }              if (d != null) yield return new(file, CareerEngine.Name(d), d.Season, SeasonCalendar.Day(d, d.Day), file == selected, GameCalendar.Text(d, d.Day));          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Directory.GetFiles(folder, "national_spire_career*.json").Where(f => ValidName(System.IO.Path.GetFileName(f)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.GetFiles(folder, "national_spire_career*.json").Where(f => ValidName(System.IO.Path.GetFileName(f))).OrderByDescending`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(folder)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Directory.Exists(folder)`
- `System.IO.Directory.GetFiles(string, string)`；输入表达式：`Directory.GetFiles(folder, "national_spire_career*.json")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.GetFiles(folder, "national_spire_career*.json").Where`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(file)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(file)`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(original)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.IO.Path.GetDirectoryName(original)!`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`System.IO.Path.GetFileName(f)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetFileName(f)`

**赋值（含属性/字段和局部值）：**

- `d` = `CoopJson.Read<CareerData>(File.ReadAllBytes(file))`

<a id="symbol-bb2b0ce2be9d"></a>

## `NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData) — public static string Create(string original, CareerData data)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.Import(string, byte[])`](CareerLibrary.cs.md#symbol-b347de421d96)；[`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)

**调用：** [`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](Coop/CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData)`](GameCalendar.cs.md#symbol-006ea3a9bcad)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；`NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(data)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.PublicBytes(data)`
- `NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData)`；输入表达式：`GameCalendar.Initialize(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: GameCalendar.Initialize(data);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "national_spire_career-" + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!);`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(path, CoopJson.PublicBytes(data))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(path, CoopJson.PublicBytes(data));`
- `System.IO.Path.Combine(string, string)`；输入表达式：`System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, "national_spire_career-" + Guid.NewGuid().ToString("N") + ".json")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, "national_spire_career-" + Guid.NewGuid().ToString("N") + ".json")`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(original)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.IO.Path.GetDirectoryName(original)!`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.IO.Path.GetDirectoryName(path)!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-261c89b42954"></a>

## `NationalSpire.CareerLibrary.Delete(string, string) — public static string Delete(string original, string path)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.DeleteCareer(string, string)`](CareerStore.cs.md#symbol-1b17c0b3af7f)

**调用：** [`NationalSpire.CareerLibrary.SelectedPath(string)`](CareerLibrary.cs.md#symbol-8caea35cd8af)；[`NationalSpire.CareerLibrary.ValidName(string)`](CareerLibrary.cs.md#symbol-42ea11f25dc4)；`string.Equals(string?, string?, System.StringComparison)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.Directory.Delete(string)`；`System.IO.Directory.GetFiles(string, string)`；`System.IO.File.Move(string, string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string, string)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFileName(string?)`；`System.IO.Path.GetFullPath(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLibrary.SelectedPath(string)`；`NationalSpire.CareerLibrary.ValidName(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.SelectedPath(string)`；输入表达式：`SelectedPath(original)`；返回值紧邻使用处：`ArgumentSyntax: SelectedPath(original)`
- `NationalSpire.CareerLibrary.ValidName(string)`；输入表达式：`ValidName(file)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ValidName(file)`
- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(folder, System.IO.Path.GetDirectoryName(path), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.Equals(folder, System.IO.Path.GetDirectoryName(path), StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(path, System.IO.Path.GetFullPath(SelectedPath(original)), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (string.Equals(path, System.IO.Path.GetFullPath(SelectedPath(original)), StringComparison.OrdinalIgnoreCase))              throw new InvalidOperationException("请先切换到另一份生涯，再删除当前生涯。");`
- `string.StartsWith(string)`；输入表达式：`suffix.StartsWith(".broken-")`；返回值紧邻使用处：`BinaryExpressionSyntax: suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-")`
- `string.StartsWith(string)`；输入表达式：`suffix.StartsWith(".pre-")`；返回值紧邻使用处：`BinaryExpressionSyntax: suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-")`
- `string.StartsWith(string)`；输入表达式：`suffix.StartsWith(".reset-")`；返回值紧邻使用处：`BinaryExpressionSyntax: suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-")`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`Directory.GetFiles(folder, file + ".*").Where(p =>          {              string suffix = p[path.Length..];              return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");          }).Append(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.GetFiles(folder, file + ".*").Where(p =>          {              string suffix = p[path.Length..];              return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");          }).Append(path).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`moved.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: moved.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`moved.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string source in moved.AsEnumerable().Reverse()) File.Move(System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source)), source);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Directory.GetFiles(folder, file + ".*").Where(p =>          {              string suffix = p[path.Length..];              return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");          }).Append(path).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Directory.GetFiles(folder, file + ".*").Where(p =>          {              string suffix = p[path.Length..];              return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");          }).Append(path).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Directory.GetFiles(folder, file + ".*").Where(p =>          {              string suffix = p[path.Length..];              return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.GetFiles(folder, file + ".*").Where(p =>          {              string suffix = p[path.Length..];              return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");          }).Append`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`moved.Add(source)`；返回值紧邻使用处：`ExpressionStatementSyntax: moved.Add(source);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: file + "-" + Guid.NewGuid().ToString("N")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先切换到另一份生涯，再删除当前生涯。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先切换到另一份生涯，再删除当前生涯。");`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(backup)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(backup);`
- `System.IO.Directory.Delete(string)`；输入表达式：`Directory.Delete(backup)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.Delete(backup);`
- `System.IO.Directory.GetFiles(string, string)`；输入表达式：`Directory.GetFiles(folder, file + ".*")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.GetFiles(folder, file + ".*").Where`
- `System.IO.File.Move(string, string)`；输入表达式：`File.Move(source, System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source)))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(source, System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source)));`
- `System.IO.File.Move(string, string)`；输入表达式：`File.Move(System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source)), source)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source)), source);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯路径无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("生涯路径无效。");`
- `System.IO.Path.Combine(string, string, string)`；输入表达式：`System.IO.Path.Combine(folder, ".deleted", file + "-" + Guid.NewGuid().ToString("N"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.IO.Path.Combine(folder, ".deleted", file + "-" + Guid.NewGuid().ToString("N"))`
- `System.IO.Path.Combine(string, string)`；输入表达式：`System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source))`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source))`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(original)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.IO.Path.GetDirectoryName(original)!`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`System.IO.Path.GetDirectoryName(path)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetDirectoryName(path)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`System.IO.Path.GetFileName(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.IO.Path.GetFileName(path)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`System.IO.Path.GetFileName(source)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetFileName(source)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`System.IO.Path.GetFullPath(original)`；返回值紧邻使用处：`AssignmentExpressionSyntax: original = System.IO.Path.GetFullPath(original)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`System.IO.Path.GetFullPath(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: path = System.IO.Path.GetFullPath(path)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`System.IO.Path.GetFullPath(SelectedPath(original))`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.GetFullPath(SelectedPath(original))`

**赋值（含属性/字段和局部值）：**

- `original` = `System.IO.Path.GetFullPath(original)`
- `path` = `System.IO.Path.GetFullPath(path)`

<a id="symbol-6f1ccfef974f"></a>

## `NationalSpire.CareerLibrary.Export(NationalSpire.CareerData, byte[]?, byte[]?) — public static byte[] Export(CareerData data, byte[]? run = null, byte[]? backup = null)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](Coop/CoopData.cs.md#symbol-3f5e7638f9e9)；`System.IO.Compression.ZipArchive.CreateEntry(string)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode, bool)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.Write(System.ReadOnlySpan<byte>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(data)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.PublicBytes(data)`
- `System.IO.Compression.ZipArchive.CreateEntry(string)`；输入表达式：`zip.CreateEntry("career.json")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry("career.json").Open`
- `System.IO.Compression.ZipArchive.CreateEntry(string)`；输入表达式：`zip.CreateEntry("run.backup")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry("run.backup").Open`
- `System.IO.Compression.ZipArchive.CreateEntry(string)`；输入表达式：`zip.CreateEntry("run.save")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry("run.save").Open`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode, bool)`；输入表达式：`new ZipArchive(buffer, ZipArchiveMode.Create, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ZipArchive(buffer, ZipArchiveMode.Create, true)`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry("career.json").Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = zip.CreateEntry("career.json").Open()`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry("run.backup").Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = zip.CreateEntry("run.backup").Open()`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry("run.save").Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = zip.CreateEntry("run.save").Open()`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`buffer.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return buffer.ToArray();`
- `System.IO.Stream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`stream.Write(backup)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Write(backup);`
- `System.IO.Stream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`stream.Write(CoopJson.PublicBytes(data))`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Write(CoopJson.PublicBytes(data));`
- `System.IO.Stream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`stream.Write(run)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Write(run);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b347de421d96"></a>

## `NationalSpire.CareerLibrary.Import(string, byte[]) — public static string Import(string original, byte[] bytes)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`](CareerLibrary.cs.md#symbol-bb2b0ce2be9d)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.IO.Compression.ZipArchive.GetEntry(string)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.MemoryStream(byte[])`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.LongSeasonsFrom`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerData.Version`；`NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`；输入表达式：`Create(original, data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Create(original, data)`
- `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.End(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day > SeasonCalendar.End(data)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day <= SeasonCalendar.Start(data)`
- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`zip.GetEntry("career.json")`；返回值紧邻使用处：`BinaryExpressionSyntax: zip.GetEntry("career.json") ?? throw new InvalidDataException("文件没有单人生涯记录。")`
- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`zip.GetEntry("run.backup")`；返回值紧邻使用处：`IsPatternExpressionSyntax: zip.GetEntry("run.backup") is { } nativeBackup`
- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`zip.GetEntry("run.save")`；返回值紧邻使用处：`IsPatternExpressionSyntax: zip.GetEntry("run.save") is { } native`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；输入表达式：`new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read)`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`entry.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entry.Open()`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`native.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = native.Open()`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`nativeBackup.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = nativeBackup.Open()`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(path + ".run.backup", backup)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(path + ".run.backup", backup);`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(path + ".run", run)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(path + ".run", run);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯版本或内容无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("生涯版本或内容无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯内容为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("生涯内容为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("文件没有单人生涯记录。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("文件没有单人生涯记录。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("这份生涯包缺少未完成对局的原版存档。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("这份生涯包缺少未完成对局的原版存档。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.MemoryStream(byte[])`；输入表达式：`new MemoryStream(bytes)`；返回值紧邻使用处：`ArgumentSyntax: new MemoryStream(bytes)`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`target.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: backup = target.ToArray()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`target.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: run = target.ToArray()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`source.CopyTo(target)`；返回值紧邻使用处：`ExpressionStatementSyntax: source.CopyTo(target);`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`ArgumentSyntax: reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream)`；输入表达式：`new StreamReader(stream)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(stream)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<CareerData>(reader.ReadToEnd(), CoopJson.Options)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<CareerData>(reader.ReadToEnd(), CoopJson.Options) ?? throw new InvalidDataException("生涯内容为空。")`

**赋值（含属性/字段和局部值）：**

- `backup` = `target.ToArray()`
- `run` = `target.ToArray()`

<a id="symbol-67e3d9bcf4e6"></a>

## `NationalSpire.CareerLibrary.ExportDesktop(string, byte[]) — public static string ExportDesktop(string name, byte[] bytes)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** `string.Concat<T>(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.DateTime.ToString(string?)`；`System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetInvalidFileNameChars()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Concat<T>(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Concat(name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c))`；返回值紧邻使用处：`BinaryExpressionSyntax: "国运尖塔-" + string.Concat(name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c))`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`System.IO.Path.GetInvalidFileNameChars().Contains(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)`；返回值紧邻使用处：`ArgumentSyntax: name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.Now.ToString("yyyyMMdd-HHmmssfff")`；返回值紧邻使用处：`BinaryExpressionSyntax: "国运尖塔-" + string.Concat(name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)) + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff")`
- `System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；输入表达式：`Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)`；返回值紧邻使用处：`ArgumentSyntax: Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(path, bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(path, bytes);`
- `System.IO.Path.Combine(string, string)`；输入表达式：`System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "国运尖塔-" + string.Concat(name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)) + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".zip")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "国运尖塔-" + string.Concat(name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)) + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".zip")`
- `System.IO.Path.GetInvalidFileNameChars()`；输入表达式：`System.IO.Path.GetInvalidFileNameChars()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: System.IO.Path.GetInvalidFileNameChars().Contains`

**赋值（含属性/字段和局部值）：**
