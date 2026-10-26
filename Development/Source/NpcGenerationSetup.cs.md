# NpcGenerationSetup.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8F3988EAB361863D48FCE3403E47CC30CA0FC0A482F5F9B07B91137498D6BCFB`。来源：[源码](../../NpcGenerationSetup.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.NpcGenerationSetup`、`NationalSpire.NpcGeneration`、`NationalSpire.NpcGeneration.ImportBatch`。

字段、事件及初始值（源码原样）：

```csharp
private readonly List<CharacterDesignPackage.Installation> _assets = [];
```

<a id="symbol-cc4d488cfd93"></a>

## `NationalSpire.NpcGenerationSetup.Pool — public PersonalityPool Pool`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PersonalityPools.Defaults()`](PersonalityPools.cs.md#symbol-992b7f26d8a7)

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityPools.Defaults()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalityPools.Defaults()`；输入表达式：`PersonalityPools.Defaults()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PersonalityPools.Defaults()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a6021ad9db53"></a>

## `NationalSpire.NpcGenerationSetup.Files — public List<string> Files`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-520811d29523"></a>

## `NationalSpire.NpcGenerationSetup.RivalLevel — public int RivalLevel`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2fa9b3f97299"></a>

## `NationalSpire.NpcGenerationSetup.Ai — public AiOptions? Ai`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-11e663521a5c"></a>

## `NationalSpire.NpcGenerationSetup.PlayerName — public string PlayerName`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.PlayerName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8f4ea5d136e7"></a>

## `NationalSpire.NpcGeneration.ResolvePlayerName(NationalSpire.NpcGenerationSetup) — public static string ResolvePlayerName(NpcGenerationSetup setup)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.NpcGeneration.Create(NationalSpire.AiOptions, NationalSpire.NpcGenerationSetup)`](NpcGenerationSetup.cs.md#symbol-c3f59c3c9460)

**调用：** `string.IsNullOrWhiteSpace(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.PlayerName`；`NationalSpire.NpcGenerationSetup.PlayerName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(setup.PlayerName)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(setup.PlayerName) ? CareerEngine.PlayerName : setup.PlayerName.Trim()`
- `string.Trim()`；输入表达式：`setup.PlayerName.Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(setup.PlayerName) ? CareerEngine.PlayerName : setup.PlayerName.Trim()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3f59c3c9460"></a>

## `NationalSpire.NpcGeneration.Create(NationalSpire.AiOptions, NationalSpire.NpcGenerationSetup) — public static CareerData Create(AiOptions ai, NpcGenerationSetup setup)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)

**调用：** [`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.NpcGeneration.ApplySettings(NationalSpire.CareerData, NationalSpire.NpcGenerationSetup, NationalSpire.AiOptions)`](NpcGenerationSetup.cs.md#symbol-1e7661675ad1)；[`NationalSpire.NpcGeneration.ResolvePlayerName(NationalSpire.NpcGenerationSetup)`](NpcGenerationSetup.cs.md#symbol-8f4ea5d136e7)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`；`NationalSpire.NpcGeneration.ApplySettings(NationalSpire.CareerData, NationalSpire.NpcGenerationSetup, NationalSpire.AiOptions)`；`NationalSpire.NpcGeneration.ResolvePlayerName(NationalSpire.NpcGenerationSetup)`；`NationalSpire.NpcGenerationSetup.Pool`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`；输入表达式：`CareerEngine.CreateNew(personalityPool: setup.Pool, playerName: ResolvePlayerName(setup))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.CreateNew(personalityPool: setup.Pool, playerName: ResolvePlayerName(setup))`
- `NationalSpire.NpcGeneration.ApplySettings(NationalSpire.CareerData, NationalSpire.NpcGenerationSetup, NationalSpire.AiOptions)`；输入表达式：`ApplySettings(data, setup, ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplySettings(data, setup, ai);`
- `NationalSpire.NpcGeneration.ResolvePlayerName(NationalSpire.NpcGenerationSetup)`；输入表达式：`ResolvePlayerName(setup)`；返回值紧邻使用处：`ArgumentSyntax: playerName: ResolvePlayerName(setup)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1e7661675ad1"></a>

## `NationalSpire.NpcGeneration.ApplySettings(NationalSpire.CareerData, NationalSpire.NpcGenerationSetup, NationalSpire.AiOptions) — public static void ApplySettings(CareerData data, NpcGenerationSetup setup, AiOptions inherited)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.NpcGeneration.Create(NationalSpire.AiOptions, NationalSpire.NpcGenerationSetup)`](NpcGenerationSetup.cs.md#symbol-c3f59c3c9460)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int)`](MatchRules.cs.md#symbol-7a4196460ee7)；[`NationalSpire.PublicSchedule.Capture(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](PublicSchedule.cs.md#symbol-0253014360da)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.PersonalityPool`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Posts`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Schedule`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int)`；`NationalSpire.NpcGenerationSetup.Ai`；`NationalSpire.NpcGenerationSetup.Pool`；`NationalSpire.NpcGenerationSetup.RivalLevel`；`NationalSpire.PublicSchedule.Capture(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(setup.Ai ?? inherited)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai = Coop.CoopJson.Copy(setup.Ai ?? inherited)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(setup.Pool)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai.PersonalityPool = Coop.CoopJson.Copy(setup.Pool)`
- `NationalSpire.MatchRules.SetRivalLevel(NationalSpire.CareerData, int)`；输入表达式：`MatchRules.SetRivalLevel(data, setup.RivalLevel)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.SetRivalLevel(data, setup.RivalLevel);`
- `NationalSpire.PublicSchedule.Capture(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`PublicSchedule.Capture(data, opening.RelatedPeople)`；返回值紧邻使用处：`AssignmentExpressionSyntax: opening.Schedule ??= PublicSchedule.Capture(data, opening.RelatedPeople)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Posts.FirstOrDefault(p => p.EventKey == "ecosystem")`；返回值紧邻使用处：`IsPatternExpressionSyntax: data.Posts.FirstOrDefault(p => p.EventKey == "ecosystem") is { } opening`

**赋值（含属性/字段和局部值）：**

- `data.Ai.PersonalityPool` = `Coop.CoopJson.Copy(setup.Pool)`
- `data.Ai` = `Coop.CoopJson.Copy(setup.Ai ?? inherited)`
- `opening.AiPending` = `true`
- `opening.Schedule` ??= `PublicSchedule.Capture(data, opening.RelatedPeople)`

<a id="symbol-023f02ec9cbf"></a>

## `NationalSpire.NpcGeneration.ImportBatch.ImportBatch(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>) — public ImportBatch(CareerData fresh, IEnumerable<string> paths)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** `NationalSpire.CharacterCardEdit.CharacterCardEdit()`；[`NationalSpire.CharacterCardPng.Import(NationalSpire.CareerData, byte[], System.Func<byte[], NationalSpire.PlayerAvatar>?)`](CharacterCardPng.cs.md#symbol-c7101cd02992)；[`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`](CharacterCards.cs.md#symbol-a50771d297a5)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, NationalSpire.CharacterDesignPackage.Imported)`](CharacterDesignPackage.cs.md#symbol-f40a9f8b3b92)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, string, bool)`](CharacterDesignPackage.cs.md#symbol-fbaf14871e47)；[`NationalSpire.NpcGeneration.ImportBatch.Dispose()`](NpcGenerationSetup.cs.md#symbol-91acee9b5250)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.List<T>.Add(T)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.FileInfo.FileInfo(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?, System.Exception?)`；`System.IO.Path.GetExtension(string?)`；`System.IO.Path.GetFileName(string?)`；`string.Equals(string?, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.CharacterCardPng.Import(NationalSpire.CareerData, byte[], System.Func<byte[], NationalSpire.PlayerAvatar>?)`；`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`；`NationalSpire.CharacterDesignPackage.Imported.Person`；`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, string, bool)`；`NationalSpire.NpcGeneration.ImportBatch.Dispose()`；`NationalSpire.NpcGeneration.ImportBatch._assets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterCardEdit.CharacterCardEdit()`；输入表达式：`new() { Create = true, Target = person.Id, Person = person }`；返回值紧邻使用处：`ArgumentSyntax: new() { Create = true, Target = person.Id, Person = person }`
- `NationalSpire.CharacterCardPng.Import(NationalSpire.CareerData, byte[], System.Func<byte[], NationalSpire.PlayerAvatar>?)`；输入表达式：`CharacterCardPng.Import(fresh, File.ReadAllBytes(path))`；返回值紧邻使用处：`BinaryExpressionSyntax: package?.Person ?? CharacterCardPng.Import(fresh, File.ReadAllBytes(path))`
- `NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`；输入表达式：`CharacterCards.Apply(fresh, new() { Create = true, Target = person.Id, Person = person })`；返回值紧邻使用处：`IsPatternExpressionSyntax: CharacterCards.Apply(fresh, new() { Create = true, Target = person.Id, Person = person }) is { } error`
- `NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, NationalSpire.CharacterDesignPackage.Imported)`；输入表达式：`new(fresh, package)`；返回值紧邻使用处：`ArgumentSyntax: new(fresh, package)`
- `NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, string, bool)`；输入表达式：`CharacterDesignPackage.Read(fresh, path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? CharacterDesignPackage.Read(fresh, path) : null`
- `NationalSpire.NpcGeneration.ImportBatch.Dispose()`；输入表达式：`Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dispose();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`paths.Distinct(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string path in paths.Distinct(StringComparer.OrdinalIgnoreCase)) { try { var info = new FileInfo(path); if (info.Length > 512L * 1024 * 1024) throw new InvalidDataException("文件超过 512 MiB。"); CharacterDesignPackage.Imported? package = Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? CharacterDesignPackage.Read(fresh, path) : null; var person = package?.Person ?? CharacterCardPng.Import(fresh, File.ReadAllBytes(path)); if (CharacterCards.Apply(fresh, new() { Create = true, Target = person.Id, Person = person }) is { } error) throw new InvalidDataException(error); if (package != null) _assets.Add(new(fresh, package)); } catch (Exception e) { throw new InvalidDataException(Path.GetFileName(path) + "：" + e.Message, e); } }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_assets.Add(new(fresh, package))`；返回值紧邻使用处：`ExpressionStatementSyntax: _assets.Add(new(fresh, package));`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(path)`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileInfo(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("文件超过 512 MiB。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("文件超过 512 MiB。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error);`
- `System.IO.InvalidDataException.InvalidDataException(string?, System.Exception?)`；输入表达式：`new InvalidDataException(Path.GetFileName(path) + "：" + e.Message, e)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(Path.GetFileName(path) + "：" + e.Message, e);`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(path).Equals`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFileName(path) + "："`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? CharacterDesignPackage.Read(fresh, path) : null`

**赋值（含属性/字段和局部值）：**

- `Create` = `true`
- `Person` = `person`
- `Target` = `person.Id`

<a id="symbol-9e8174232934"></a>

## `NationalSpire.NpcGeneration.ImportBatch.Commit() — public void Commit()`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.CharacterDesignPackage.Installation.Commit()`](CharacterDesignPackage.cs.md#symbol-6147750def14)

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterDesignPackage.Installation.Commit()`；`NationalSpire.NpcGeneration.ImportBatch._assets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterDesignPackage.Installation.Commit()`；输入表达式：`asset.Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: asset.Commit();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-91acee9b5250"></a>

## `NationalSpire.NpcGeneration.ImportBatch.Dispose() — public void Dispose()`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.NpcGeneration.ImportBatch.ImportBatch(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](NpcGenerationSetup.cs.md#symbol-023f02ec9cbf)

**调用：** [`NationalSpire.CharacterDesignPackage.Installation.Dispose()`](CharacterDesignPackage.cs.md#symbol-9c5c348e084c)；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterDesignPackage.Installation.Dispose()`；`NationalSpire.NpcGeneration.ImportBatch._assets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterDesignPackage.Installation.Dispose()`；输入表达式：`asset.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: asset.Dispose();`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`_assets.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _assets.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`_assets.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var asset in _assets.AsEnumerable().Reverse()) asset.Dispose();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_assets.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _assets.Clear();`

**赋值（含属性/字段和局部值）：**
