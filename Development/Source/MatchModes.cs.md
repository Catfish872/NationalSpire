# MatchModes.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7DC605B548328ABD1BDEC3623292D013034C1432A08E0A34B1374AF90C4E1FF7`。来源：[源码](../../MatchModes.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MatchModes`。

字段、事件及初始值（源码原样）：

```csharp
public const string Standard = "Standard", Blitz = "Blitz", Dread = "Dread";
public static readonly string[] All = [Standard, Blitz, Dread];
```

<a id="symbol-ff2018804a08"></a>

## `NationalSpire.MatchModes.Available(string) — public static bool Available(string mode)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModes.Preferred(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchModes.cs.md#symbol-a20fef0677c1)；[`NationalSpire.MatchModes.Valid(string, int, int)`](MatchModes.cs.md#symbol-29ba5300e7ae)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Enum.TryParse<TEnum>(string?, out TEnum)`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.All`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`All.Contains(mode)`；返回值紧邻使用处：`BinaryExpressionSyntax: All.Contains(mode) && Enum.TryParse<GameMode>(mode, out _)`
- `System.Enum.TryParse<TEnum>(string?, out TEnum)`；输入表达式：`Enum.TryParse<GameMode>(mode, out _)`；返回值紧邻使用处：`BinaryExpressionSyntax: All.Contains(mode) && Enum.TryParse<GameMode>(mode, out _)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c0b5a07fb3c"></a>

## `NationalSpire.MatchModes.Native(string) — public static GameMode Native(string mode)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](Coop/CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](Coop/CoopNativeRun.cs.md#symbol-a3ff2d717caf)；[`NationalSpire.GameCompatibility.StartSingleplayer(System.Reflection.MethodInfo, MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Models.CharacterModel, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string, int, string)`](GameCompatibility.cs.md#symbol-48e9860a31ce)

**调用：** `System.Enum.Parse<TEnum>(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Enum.Parse<TEnum>(string)`；输入表达式：`Enum.Parse<GameMode>(mode)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Enum.Parse<GameMode>(mode)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a1829e04c6f6"></a>

## `NationalSpire.MatchModes.Name(string) — public static string Name(string mode)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)；[`NationalSpire.MatchModeSelector.Refresh()`](MatchModeSelector.cs.md#symbol-a545b72dd8c3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-438383af5a8b"></a>

## `NationalSpire.MatchModes.Minimum(string, int) — public static int Minimum(string mode, int required)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`](MatchModes.cs.md#symbol-e35c7590a177)；[`NationalSpire.MatchModes.Valid(string, int, int)`](MatchModes.cs.md#symbol-29ba5300e7ae)；[`NationalSpire.MatchModeSelector.Adjust(int)`](MatchModeSelector.cs.md#symbol-01759e00270d)；[`NationalSpire.MatchModeSelector.Refresh()`](MatchModeSelector.cs.md#symbol-a545b72dd8c3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1f84e144cf3c"></a>

## `NationalSpire.MatchModes.Maximum(string) — public static int Maximum(string mode)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`](MatchModes.cs.md#symbol-e35c7590a177)；[`NationalSpire.MatchModes.Valid(string, int, int)`](MatchModes.cs.md#symbol-29ba5300e7ae)；[`NationalSpire.MatchModeSelector.Adjust(int)`](MatchModeSelector.cs.md#symbol-01759e00270d)；[`NationalSpire.MatchModeSelector.Refresh()`](MatchModeSelector.cs.md#symbol-a545b72dd8c3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8f51795c3dbb"></a>

## `NationalSpire.MatchModes.RecordedAscension(string, int) — public static int RecordedAscension(string mode, int native)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.MatchModes.Select(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int)`](MatchModes.cs.md#symbol-51d0719d4fbb)；[`NationalSpire.MatchModes.Valid(string, int, int)`](MatchModes.cs.md#symbol-29ba5300e7ae)；[`NationalSpire.MatchModeSelector.RecordedAscension`](MatchModeSelector.cs.md#symbol-eb2e7b96be62)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b712e7af8426"></a>

## `NationalSpire.MatchModes.NativeAscension(string, int) — public static int NativeAscension(string mode, int recorded)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`](CareerRunBinding.cs.md#symbol-98b98bdd8fa3)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?, string)`](Coop/CoopRules.cs.md#symbol-037a2d6843fd)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.MatchModes.PendingNativeAscension(NationalSpire.CareerData)`](MatchModes.cs.md#symbol-98ba1a2623e5)；[`NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`](MatchModes.cs.md#symbol-e35c7590a177)；[`NationalSpire.MatchModes.Valid(string, int, int)`](MatchModes.cs.md#symbol-29ba5300e7ae)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?, string?)`](PlayerSimulation.cs.md#symbol-bd0770601593)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-29ba5300e7ae"></a>

## `NationalSpire.MatchModes.Valid(string, int, int) — public static bool Valid(string mode, int required, int recorded)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?, string)`](Coop/CoopRules.cs.md#symbol-037a2d6843fd)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.MatchModes.Available(string)`](MatchModes.cs.md#symbol-ff2018804a08)；[`NationalSpire.MatchModes.Maximum(string)`](MatchModes.cs.md#symbol-1f84e144cf3c)；[`NationalSpire.MatchModes.Minimum(string, int)`](MatchModes.cs.md#symbol-438383af5a8b)；[`NationalSpire.MatchModes.NativeAscension(string, int)`](MatchModes.cs.md#symbol-b712e7af8426)；[`NationalSpire.MatchModes.RecordedAscension(string, int)`](MatchModes.cs.md#symbol-8f51795c3dbb)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Available(string)`；`NationalSpire.MatchModes.Maximum(string)`；`NationalSpire.MatchModes.Minimum(string, int)`；`NationalSpire.MatchModes.NativeAscension(string, int)`；`NationalSpire.MatchModes.RecordedAscension(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.Available(string)`；输入表达式：`Available(mode)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(mode) && NativeAscension(mode, recorded) is var level`
- `NationalSpire.MatchModes.Maximum(string)`；输入表达式：`Maximum(mode)`；返回值紧邻使用处：`BinaryExpressionSyntax: level <= Maximum(mode)`
- `NationalSpire.MatchModes.Minimum(string, int)`；输入表达式：`Minimum(mode, required)`；返回值紧邻使用处：`BinaryExpressionSyntax: level >= Minimum(mode, required)`
- `NationalSpire.MatchModes.NativeAscension(string, int)`；输入表达式：`NativeAscension(mode, recorded)`；返回值紧邻使用处：`IsPatternExpressionSyntax: NativeAscension(mode, recorded) is var level`
- `NationalSpire.MatchModes.RecordedAscension(string, int)`；输入表达式：`RecordedAscension(mode, level)`；返回值紧邻使用处：`BinaryExpressionSyntax: RecordedAscension(mode, level) == recorded`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ba9495de2f03"></a>

## `NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch) — public static string ForMatch(CareerMatch match)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`](CareerRunBinding.cs.md#symbol-98b98bdd8fa3)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.MatchModes.PendingNativeAscension(NationalSpire.CareerData)`](MatchModes.cs.md#symbol-98ba1a2623e5)；[`NationalSpire.MatchModes.Select(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int)`](MatchModes.cs.md#symbol-51d0719d4fbb)；[`NationalSpire.MatchRules.SimulateOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`](MatchRules.cs.md#symbol-4ab34fe7daf2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.ChosenMode`；`NationalSpire.MatchModes.Standard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a20fef0677c1"></a>

## `NationalSpire.MatchModes.Preferred(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static string Preferred(CareerData data, CareerMatch match)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** [`NationalSpire.MatchModes.Available(string)`](MatchModes.cs.md#symbol-ff2018804a08)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.SelectedMode`；`NationalSpire.CareerMatch.ChosenMode`；`NationalSpire.MatchModes.Available(string)`；`NationalSpire.MatchModes.Standard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.Available(string)`；输入表达式：`Available(mode)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Available(mode) ? mode : Standard`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e35c7590a177"></a>

## `NationalSpire.MatchModes.PreferredLevel(NationalSpire.CareerData, NationalSpire.CareerMatch, string) — public static int PreferredLevel(CareerData data, CareerMatch match, string mode)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchModeSelector.MatchModeSelector(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](MatchModeSelector.cs.md#symbol-40bbec50deea)

**调用：** [`NationalSpire.MatchModes.Maximum(string)`](MatchModes.cs.md#symbol-1f84e144cf3c)；[`NationalSpire.MatchModes.Minimum(string, int)`](MatchModes.cs.md#symbol-438383af5a8b)；[`NationalSpire.MatchModes.NativeAscension(string, int)`](MatchModes.cs.md#symbol-b712e7af8426)；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerData.SelectedBlitzAscension`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.ChosenMode`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.Dread`；`NationalSpire.MatchModes.Maximum(string)`；`NationalSpire.MatchModes.Minimum(string, int)`；`NationalSpire.MatchModes.NativeAscension(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.Maximum(string)`；输入表达式：`Maximum(mode)`；返回值紧邻使用处：`ArgumentSyntax: Maximum(mode)`
- `NationalSpire.MatchModes.Minimum(string, int)`；输入表达式：`Minimum(mode, match.RequiredAscension)`；返回值紧邻使用处：`ArgumentSyntax: Minimum(mode, match.RequiredAscension)`
- `NationalSpire.MatchModes.Minimum(string, int)`；输入表达式：`Minimum(mode, match.RequiredAscension)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.SelectedBlitzAscension ?? Minimum(mode, match.RequiredAscension)`
- `NationalSpire.MatchModes.NativeAscension(string, int)`；输入表达式：`NativeAscension(mode, chosen)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match.ChosenMode == mode && match.ChosenAscension is { } chosen ? NativeAscension(mode, chosen)             : mode == Blitz ? data.SelectedBlitzAscension ?? Minimum(mode, match.RequiredAscension)             : mode == Dread ? 10 : match.ChosenMode == null ? match.ChosenAscension ?? data.SelectedAscension : data.SelectedAscension`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(value, Minimum(mode, match.RequiredAscension), Maximum(mode))`；返回值紧邻使用处：`ReturnStatementSyntax: return Math.Clamp(value, Minimum(mode, match.RequiredAscension), Maximum(mode));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-51d0719d4fbb"></a>

## `NationalSpire.MatchModes.Select(NationalSpire.CareerData, NationalSpire.CareerMatch, string, int) — public static void Select(CareerData data, CareerMatch match, string mode, int native)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?, string)`](Coop/CoopRules.cs.md#symbol-037a2d6843fd)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?, string?)`](PlayerSimulation.cs.md#symbol-bd0770601593)

**调用：** [`NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch)`](MatchModes.cs.md#symbol-ba9495de2f03)；[`NationalSpire.MatchModes.RecordedAscension(string, int)`](MatchModes.cs.md#symbol-8f51795c3dbb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerData.SelectedBlitzAscension`；`NationalSpire.CareerData.SelectedMode`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.ChosenMode`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.MatchModes.Blitz`；`NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch)`；`NationalSpire.MatchModes.RecordedAscension(string, int)`；`NationalSpire.MatchModes.Standard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch)`；输入表达式：`ForMatch(match)`；返回值紧邻使用处：`BinaryExpressionSyntax: ForMatch(match) == Blitz`
- `NationalSpire.MatchModes.RecordedAscension(string, int)`；输入表达式：`RecordedAscension(mode, native)`；返回值紧邻使用处：`AssignmentExpressionSyntax: match.ChosenAscension = RecordedAscension(mode, native)`

**赋值（含属性/字段和局部值）：**

- `data.SelectedAscension` = `native`
- `data.SelectedBlitzAscension` = `native`
- `data.SelectedMode` = `mode`
- `match.ChosenAscension` = `RecordedAscension(mode, native)`
- `match.ChosenMode` = `data.SelectedMode = mode`
- `match.Live` = `null`
- `match.OpponentPrepared` = `false`
- `match.OpponentSeconds` = `null`

<a id="symbol-98ba1a2623e5"></a>

## `NationalSpire.MatchModes.PendingNativeAscension(NationalSpire.CareerData) — public static int PendingNativeAscension(CareerData data)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-87d1dc26f106)

**调用：** [`NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch)`](MatchModes.cs.md#symbol-ba9495de2f03)；[`NationalSpire.MatchModes.NativeAscension(string, int)`](MatchModes.cs.md#symbol-b712e7af8426)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.Id`；`NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch)`；`NationalSpire.MatchModes.NativeAscension(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchModes.ForMatch(NationalSpire.CareerMatch)`；输入表达式：`ForMatch(match)`；返回值紧邻使用处：`ArgumentSyntax: ForMatch(match)`
- `NationalSpire.MatchModes.NativeAscension(string, int)`；输入表达式：`NativeAscension(ForMatch(match), match.ChosenAscension ?? data.SelectedAscension)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match == null ? data.SelectedAscension             : NativeAscension(ForMatch(match), match.ChosenAscension ?? data.SelectedAscension)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e5d2cc8b11c5"></a>

## `NationalSpire.MatchModes.RivalTimeScale(string) — public static double RivalTimeScale(string mode)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.SimulateOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch, string)`](MatchRules.cs.md#symbol-4ab34fe7daf2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Blitz`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
