# PlayerArchive.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C4E5A08B5B10FA97FBB990B5C3E61ED5B4BB8789C2B473D5A37AAE6E302F19C2`。来源：[源码](../../PlayerArchive.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ArchiveCharacter`、`NationalSpire.ArchiveSnapshot`、`NationalSpire.PlayerArchive`。

字段、事件及初始值（源码原样）：

```csharp
private static string _key = "";
private static bool _recentLoaded;
private static ArchiveSnapshot? _cached;
```

<a id="symbol-6dc32ca130f3"></a>

## `NationalSpire.ArchiveSnapshot.Profile — public int Profile`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a952e63b2410"></a>

## `NationalSpire.ArchiveSnapshot.Wins — public int Wins`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e0b9cf60201c"></a>

## `NationalSpire.ArchiveSnapshot.Losses — public int Losses`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cb2fdf39636b"></a>

## `NationalSpire.ArchiveSnapshot.Playtime — public long Playtime`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1158f09b3dca"></a>

## `NationalSpire.ArchiveSnapshot.Floors — public long Floors`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7cf5d5f19dfd"></a>

## `NationalSpire.ArchiveSnapshot.Streak — public long Streak`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-41bc52e6ec02"></a>

## `NationalSpire.ArchiveSnapshot.Cards — public int Cards`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9199d36cbe51"></a>

## `NationalSpire.ArchiveSnapshot.Relics — public int Relics`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-342de7264f54"></a>

## `NationalSpire.ArchiveSnapshot.Characters — public List<ArchiveCharacter> Characters`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-65b379de8708"></a>

## `NationalSpire.ArchiveSnapshot.Recent — public List<RunHistory> Recent`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f6104151bd19"></a>

## `NationalSpire.ArchiveSnapshot.WinRate — public string WinRate`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveSnapshot.Losses`；`NationalSpire.ArchiveSnapshot.Wins`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2f435607cb43"></a>

## `NationalSpire.PlayerArchive.Invalidate() — public static void Invalidate()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerArchive._cached`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_cached` = `null`

<a id="symbol-153514d4aa72"></a>

## `NationalSpire.PlayerArchive.Read(bool) — public static ArchiveSnapshot Read(bool includeRecent = true)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatars.HomeCardVariation(NationalSpire.CareerData)`](CareerAvatars.cs.md#symbol-eb2a2d40fdf7)；[`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)

**调用：** [`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`MegaCrit.Sts2.Core.Saves.SaveManager.GetAllRunHistoryNames()`；`MegaCrit.Sts2.Core.Saves.SaveManager.LoadRunHistory(string)`；`NationalSpire.ArchiveCharacter.ArchiveCharacter(string, int, int, int, long, long, string)`；`NationalSpire.ArchiveSnapshot.ArchiveSnapshot()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.Enumerable.Empty<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveCharacter.Losses`；`NationalSpire.ArchiveCharacter.Wins`；`NationalSpire.ArchiveSnapshot.Cards`；`NationalSpire.ArchiveSnapshot.Characters`；`NationalSpire.ArchiveSnapshot.Floors`；`NationalSpire.ArchiveSnapshot.Losses`；`NationalSpire.ArchiveSnapshot.Playtime`；`NationalSpire.ArchiveSnapshot.Profile`；`NationalSpire.ArchiveSnapshot.Recent`；`NationalSpire.ArchiveSnapshot.Relics`；`NationalSpire.ArchiveSnapshot.Streak`；`NationalSpire.ArchiveSnapshot.Wins`；`NationalSpire.PlayerArchive._cached`；`NationalSpire.PlayerArchive._key`；`NationalSpire.PlayerArchive._recentLoaded`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`kv.Key.ToString()`；返回值紧邻使用处：`ArgumentSyntax: kv.Key.ToString()`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GetAllRunHistoryNames()`；输入表达式：`save.GetAllRunHistoryNames()`；返回值紧邻使用处：`ConditionalExpressionSyntax: includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()`
- `MegaCrit.Sts2.Core.Saves.SaveManager.LoadRunHistory(string)`；输入表达式：`save.LoadRunHistory(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = save.LoadRunHistory(file)`
- `NationalSpire.ArchiveCharacter.ArchiveCharacter(string, int, int, int, long, long, string)`；输入表达式：`new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString())`
- `NationalSpire.ArchiveSnapshot.ArchiveSnapshot()`；输入表达式：`new ArchiveSnapshot          {              Profile = save.CurrentProfileId, Wins = p.Wins, Losses = p.Losses, Playtime = p.TotalPlaytime,              Floors = p.FloorsClimbed, Streak = p.BestWinStreak, Cards = p.DiscoveredCards.Count, Relics = p.DiscoveredRelics.Count,              Characters = p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList(),              Recent = recent.OrderByDescending(r => r.StartTime).ToList()          }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _cached = new ArchiveSnapshot          {              Profile = save.CurrentProfileId, Wins = p.Wins, Losses = p.Losses, Playtime = p.TotalPlaytime,              Floors = p.FloorsClimbed, Streak = p.BestWinStreak, Cards = p.DiscoveredCards.Count, Relics = p.DiscoveredRelics.Count,              Characters = p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList(),              Recent = recent.OrderByDescending(r => r.StartTime).ToList()          }`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`CharacterName(kv.Key)`；返回值紧邻使用处：`ArgumentSyntax: CharacterName(kv.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`(includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()).OrderByDescending(x => x, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()).OrderByDescending(x => x, StringComparer.Ordinal).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`recent.OrderByDescending(r => r.StartTime)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.OrderByDescending(r => r.StartTime).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`(includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()).OrderByDescending(x => x, StringComparer.Ordinal).Take(12)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var file in (includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()).OrderByDescending(x => x, StringComparer.Ordinal).Take(12))          {              try { var r = save.LoadRunHistory(file); if (r.Success && r.SaveData != null) recent.Add(r.SaveData); }              catch { /* 单份历史损坏不影响其他统计。 */ }          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Characters = p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`recent.OrderByDescending(r => r.StartTime).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Recent = recent.OrderByDescending(r => r.StartTime).ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`recent.Add(r.SaveData)`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.Add(r.SaveData);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<RunHistory>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<RunHistory>()`
- `System.Linq.Enumerable.Empty<TResult>()`；输入表达式：`Enumerable.Empty<string>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: includeRecent ? save.GetAllRunHistoryNames() : Enumerable.Empty<string>()`

**赋值（含属性/字段和局部值）：**

- `_cached` = `new ArchiveSnapshot          {              Profile = save.CurrentProfileId, Wins = p.Wins, Losses = p.Losses, Playtime = p.TotalPlaytime,              Floors = p.FloorsClimbed, Streak = p.BestWinStreak, Cards = p.DiscoveredCards.Count, Relics = p.DiscoveredRelics.Count,              Characters = p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList(),              Recent = recent.OrderByDescending(r => r.StartTime).ToList()          }`
- `_key` = `key`
- `_recentLoaded` = `includeRecent`
- `Cards` = `p.DiscoveredCards.Count`
- `Characters` = `p.CharacterStats.Select(kv => new ArchiveCharacter(CharacterName(kv.Key), kv.Value.TotalWins,                  kv.Value.TotalLosses, kv.Value.MaxAscension, kv.Value.BestWinStreak, kv.Value.Playtime, kv.Key.ToString()))                  .OrderByDescending(c => c.Wins + c.Losses).ToList()`
- `Floors` = `p.FloorsClimbed`
- `Losses` = `p.Losses`
- `Playtime` = `p.TotalPlaytime`
- `Profile` = `save.CurrentProfileId`
- `Recent` = `recent.OrderByDescending(r => r.StartTime).ToList()`
- `Relics` = `p.DiscoveredRelics.Count`
- `Streak` = `p.BestWinStreak`
- `Wins` = `p.Wins`

<a id="symbol-9ab35bc5f38f"></a>

## `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId) — public static string CharacterName(ModelId id)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`](GameBridge.cs.md#symbol-2ddde8df91f3)；[`NationalSpire.GameBridge.ResolveCharacter(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel)`](GameBridge.cs.md#symbol-5bd0ab28ef2c)；[`NationalSpire.PlayerArchive.Read(bool)`](PlayerArchive.cs.md#symbol-153514d4aa72)

**调用：** `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`.Title.GetFormattedText()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ModelDb.GetByIdOrNull<CharacterModel>(id)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<CharacterModel>(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ModelDb.GetByIdOrNull<CharacterModel>(id)?.Title.GetFormattedText()`

**赋值（含属性/字段和局部值）：**
