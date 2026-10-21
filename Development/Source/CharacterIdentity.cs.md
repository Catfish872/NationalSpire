# CharacterIdentity.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BD4A2C07D00691A195001AC87DF5205D3403C84F96119847FB83D2EE3D9B05AD`。来源：[源码](../../CharacterIdentity.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CharacterDefinition`、`NationalSpire.CharacterIdentity`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly IReadOnlyDictionary<string, string> Empty = new Dictionary<string, string>();
```

<a id="symbol-ea46b6245542"></a>

## `NationalSpire.CharacterIdentity.Source — public static Func<IEnumerable<CharacterDefinition>> Source`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-18b52e705d7c"></a>

## `NationalSpire.CharacterIdentity.OriginalSource — public static Func<IReadOnlyDictionary<string, string>> OriginalSource`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterIdentity.Empty`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-94292e3754dd"></a>

## `NationalSpire.CharacterIdentity.OriginalName(string) — public static string? OriginalName(string id)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string, string, string?)`](CharacterIdentity.cs.md#symbol-af17e7fe683c)；[`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-3c3ff9c389dd)；[`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`](CharacterIdentity.cs.md#symbol-4d068357a08b)；[`NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`](CharacterIdentity.cs.md#symbol-3e35ac458848)；[`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`](PrivateProfileChanges.cs.md#symbol-ad07c3469174)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterIdentity.OriginalSource`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`OriginalSource().GetValueOrDefault(id)`；返回值紧邻使用处：`ReturnStatementSyntax: return OriginalSource().GetValueOrDefault(id);`
- `System.Func<TResult>.Invoke()`；输入表达式：`OriginalSource()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OriginalSource().GetValueOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6c3ca5d0abad"></a>

## `NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult) — public static string ForResult(CareerResult result)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.AiService.PlayerPublicRecord(NationalSpire.CareerData, int, bool)`](AiContext.cs.md#symbol-99772c8e0814)；[`NationalSpire.CommunityThreads.RememberMatch(NationalSpire.CareerData, NationalSpire.CareerResult)`](CommunityThreads.cs.md#symbol-fe6de6f8dd52)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.PrivatePublicContext.AppendPlayerProfile(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson?, System.Collections.Generic.HashSet<string>, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-8909708d3f8d)；[`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`](CharacterIdentity.cs.md#symbol-3e35ac458848)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CharacterIdentity.ReadDefinitions()`；`NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CharacterName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`；输入表达式：`Resolve(result.CharacterId, result.Character, ReadDefinitions)`；返回值紧邻使用处：`ReturnStatementSyntax: return Resolve(result.CharacterId, result.Character, ReadDefinitions);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterName)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CharacterName)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3e35ac458848"></a>

## `NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>) — private static string Resolve(string id, string display, Func<IEnumerable<CharacterDefinition>> source)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData)`](CharacterIdentity.cs.md#symbol-7612117e6b1e)；[`NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`](CharacterIdentity.cs.md#symbol-6c3ca5d0abad)

**调用：** [`NationalSpire.CharacterIdentity.OriginalName(string)`](CharacterIdentity.cs.md#symbol-94292e3754dd)；`string.Equals(string?, string?, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterDefinition.DisplayName`；`NationalSpire.CharacterDefinition.Id`；`NationalSpire.CharacterIdentity.OriginalName(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterIdentity.OriginalName(string)`；输入表达式：`OriginalName(id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: OriginalName(id) is { } original`
- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => string.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`source().FirstOrDefault(c => string.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: source().FirstOrDefault(c => string.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase))?.DisplayName`
- `System.Func<TResult>.Invoke()`；输入表达式：`source()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source().FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4d068357a08b"></a>

## `NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string) — public static string Name(CareerData data, string name)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)；[`NationalSpire.AiService.PlayerPublicRecord(NationalSpire.CareerData, int, bool)`](AiContext.cs.md#symbol-99772c8e0814)；[`NationalSpire.CareerNarrative.Feature(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CareerNarrative.cs.md#symbol-d15ddefbd3f2)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivatePublicContext.AppendPlayerProfile(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson?, System.Collections.Generic.HashSet<string>, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-8909708d3f8d)；[`NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivatePublicContext.cs.md#symbol-9d0bf89294e6)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData)`](CharacterIdentity.cs.md#symbol-7612117e6b1e)；[`NationalSpire.CharacterIdentity.OriginalName(string)`](CharacterIdentity.cs.md#symbol-94292e3754dd)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData)`；`NationalSpire.CharacterIdentity.OriginalName(string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CharacterName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData)`；输入表达式：`Aliases(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Aliases(data)`
- `NationalSpire.CharacterIdentity.OriginalName(string)`；输入表达式：`OriginalName(name)`；返回值紧邻使用处：`IsPatternExpressionSyntax: OriginalName(name) is { } original`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterName)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CharacterName)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`aliases.TryGetValue(name, out string? converted)`；返回值紧邻使用处：`IfStatementSyntax: if (aliases.TryGetValue(name, out string? converted)) return converted;`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7612117e6b1e"></a>

## `NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData) — internal static Dictionary<string, string> Aliases(CareerData data)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`](CharacterIdentity.cs.md#symbol-4d068357a08b)

**调用：** [`Add(string, string, string?)`](CharacterIdentity.cs.md#symbol-af17e7fe683c)；[`NationalSpire.CharacterIdentity.ReadDefinitions()`](CharacterIdentity.cs.md#symbol-201cf0836885)；[`NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`](CharacterIdentity.cs.md#symbol-3e35ac458848)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `(string Alias, string Original).Alias`；`(string Alias, string Original).Original`；`Add(string, string, string?)`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CharacterDefinition.DisplayName`；`NationalSpire.CharacterDefinition.Id`；`NationalSpire.CharacterIdentity.OriginalSource`；`NationalSpire.CharacterIdentity.ReadDefinitions()`；`NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string, string, string?)`；输入表达式：`Add(character.Id, character.DisplayName)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(character.Id, character.DisplayName);`
- `Add(string, string, string?)`；输入表达式：`Add(pair.Key, pair.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(pair.Key, pair.Value);`
- `Add(string, string, string?)`；输入表达式：`Add(result.CharacterId, result.Character, Resolve(result.CharacterId, result.Character, () => definitions))`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(result.CharacterId, result.Character, Resolve(result.CharacterId, result.Character, () => definitions));`
- `NationalSpire.CharacterIdentity.ReadDefinitions()`；输入表达式：`ReadDefinitions()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadDefinitions()`
- `NationalSpire.CharacterIdentity.Resolve(string, string, System.Func<System.Collections.Generic.IEnumerable<NationalSpire.CharacterDefinition>>)`；输入表达式：`Resolve(result.CharacterId, result.Character, () => definitions)`；返回值紧邻使用处：`ArgumentSyntax: Resolve(result.CharacterId, result.Character, () => definitions)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Select(p => p.Original).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Select(p => p.Original).Distinct().Count() == 1`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`g.Select(p => p.Original).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(p => p.Original).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`g.First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.First().Original`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`candidates.GroupBy(p => p.Alias, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.GroupBy(p => p.Alias, StringComparer.Ordinal)              .ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(p => p.Original)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(p => p.Original).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`candidates.GroupBy(p => p.Alias, StringComparer.Ordinal)              .ToDictionary(g => g.Key, g => g.Select(p => p.Original).Distinct().Count() == 1 ? g.First().Original : g.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`ReturnStatementSyntax: return candidates.GroupBy(p => p.Alias, StringComparer.Ordinal)              .ToDictionary(g => g.Key, g => g.Select(p => p.Original).Distinct().Count() == 1 ? g.First().Original : g.Key, StringComparer.Ordinal);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Where(r => r.CharacterId.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var result in data.Results.Where(r => r.CharacterId.Length > 0))              Add(result.CharacterId, result.Character, Resolve(result.CharacterId, result.Character, () => definitions));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Alias, string Original)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Alias, string Original)>()`
- `System.Func<TResult>.Invoke()`；输入表达式：`OriginalSource()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var pair in OriginalSource()) Add(pair.Key, pair.Value);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af17e7fe683c"></a>

## `Add(string, string, string?) — void Add(string id, string display, string? resolved = null)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData)`](CharacterIdentity.cs.md#symbol-7612117e6b1e)

**调用：** [`NationalSpire.CharacterIdentity.OriginalName(string)`](CharacterIdentity.cs.md#symbol-94292e3754dd)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterIdentity.OriginalName(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterIdentity.OriginalName(string)`；输入表达式：`OriginalName(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: OriginalName(id) ?? display`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`candidates.Add((display, original))`；返回值紧邻使用处：`ExpressionStatementSyntax: candidates.Add((display, original));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`candidates.Add((id, original))`；返回值紧邻使用处：`ExpressionStatementSyntax: candidates.Add((id, original));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-201cf0836885"></a>

## `NationalSpire.CharacterIdentity.ReadDefinitions() — private static CharacterDefinition[] ReadDefinitions()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterIdentity.Aliases(NationalSpire.CareerData)`](CharacterIdentity.cs.md#symbol-7612117e6b1e)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterIdentity.Source`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("character.identity", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("character.identity", e);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Source().ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return Source().ToArray();`
- `System.Func<TResult>.Invoke()`；输入表达式：`Source()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Source().ToArray`

**赋值（含属性/字段和局部值）：**
