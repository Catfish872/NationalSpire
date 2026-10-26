# LiveVoices.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`236169C26A06FFE32491331015C69920FE6AF02633AEE05CDB3DA74824A86A08`。来源：[源码](../../LiveVoices.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveVoiceState`、`NationalSpire.LiveVoices`、`NationalSpire.LiveVoices.Pending`。

字段、事件及初始值（源码原样）：

```csharp
private readonly CareerData _data;
private readonly CareerMatch _match;
private readonly BroadcastMemory _memory;
private readonly CareerPerson[] _audience;
private readonly Queue<Pending> _pending = new();
private readonly string[] _opponents;
private double _lastClock;
private int _lastRivalFloor = -1;
```

<a id="symbol-01d4a16c2add"></a>

## `NationalSpire.LiveVoiceState.Sequence — public int Sequence`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-716e8242d4d1"></a>

## `NationalSpire.LiveVoiceState.LastOptional — public double LastOptional`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0dc9b8659ca9"></a>

## `NationalSpire.LiveVoiceState.Floors — public Dictionary<string, int> Floors`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-68e15382442b"></a>

## `NationalSpire.LiveVoiceState.Recent — public Dictionary<string, List<int>> Recent`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d4475870b18"></a>

## `NationalSpire.LiveVoiceState.NextCrowdAt — public double NextCrowdAt`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-05d54bdb90e9"></a>

## `NationalSpire.LiveVoiceState.LastCueAt — public double LastCueAt`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3ffa230aebe8"></a>

## `NationalSpire.LiveVoices.LiveVoices(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.BroadcastMemory, System.Collections.Generic.IEnumerable<string>) — public LiveVoices(CareerData data, CareerMatch match, BroadcastMemory memory, IEnumerable<string> opponents)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](CommentatorSelection.cs.md#symbol-2c2966603311)；[`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](CommentatorSelection.cs.md#symbol-e47ee769b462)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices._audience`；`NationalSpire.LiveVoices._data`；`NationalSpire.LiveVoices._match`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._opponents`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)`
- `NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommentatorSelection.ForMatch(data, match, _opponents)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommentatorSelection.ForMatch(data, match, _opponents).Select`
- `NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommentatorSelection.Participants(data, match, _opponents)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommentatorSelection.Participants(data, match, _opponents)`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("club:" + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Hash("club:" + p.Id)`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("foreign:" + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Hash("foreign:" + p.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`excluded.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !excluded.Contains(p.Id)`
- `System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`excluded.UnionWith(CommentatorSelection.ForMatch(data, match, _opponents).Select(p => p.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: excluded.UnionWith(CommentatorSelection.ForMatch(data, match, _opponents).Select(p => p.Id));`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)) .DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)) .DistinctBy(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)) .DistinctBy(p => p.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommentatorSelection.ForMatch(data, match, _opponents).Select(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: CommentatorSelection.ForMatch(data, match, _opponents).Select(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)`；返回值紧邻使用处：`ArgumentSyntax: candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)`；返回值紧邻使用处：`ArgumentSyntax: candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)) .DistinctBy(p => p.Id).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _audience = candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)) .DistinctBy(p => p.Id).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.People.Where(p => !excluded.Contains(p.Id) && p.Role is not ("解说" or "解说员" or "教练")).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.Where(p => !excluded.Contains(p.Id) && p.Role is not ("解说" or "解说员" or "教练")).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`opponents.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _opponents = opponents.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(p => p.Country != data.Esports.Country)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.Country != data.Esports.Country).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(p => p.SupportedClubId.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => !excluded.Contains(p.Id) && p.Role is not ("解说" or "解说员" or "教练"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => !excluded.Contains(p.Id) && p.Role is not ("解说" or "解说员" or "教练")).ToArray`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take`

**赋值（含属性/字段和局部值）：**

- `_audience` = `[]`
- `_audience` = `candidates .OrderBy(p => p.Role == "普通玩家" ? 0 : 1) .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20) .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4)) .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4)) .DistinctBy(p => p.Id).ToArray()`
- `_data` = `data`
- `_match` = `match`
- `_memory` = `memory`
- `_opponents` = `opponents.ToArray()`

<a id="symbol-258e03700c96"></a>

## `NationalSpire.LiveVoices.Byline(string, string) — public static string Byline(string name, string role)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8ecd046e0f8e"></a>

## `NationalSpire.LiveVoices.Hash(string) — private int Hash(string key)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)；[`NationalSpire.LiveVoices.LiveVoices(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.BroadcastMemory, System.Collections.Generic.IEnumerable<string>)`](LiveVoices.cs.md#symbol-3ffa230aebe8)；[`NationalSpire.LiveVoices.Phrase(string, System.Collections.Generic.Dictionary<string, string>, out System.Func<System.Func<string, string>, string>?)`](LiveVoices.cs.md#symbol-f50a3454a330)；[`NationalSpire.LiveVoices.Poll(double, double)`](LiveVoices.cs.md#symbol-fc95fe2519bc)；[`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`](LiveVoices.cs.md#symbol-ea0ff7a1e0eb)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](LiveVoices.cs.md#symbol-44512aead226)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.LiveVoices._match`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(_match.Seed + ":voices:" + key)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CareerEngine.StableHash(_match.Seed + ":voices:" + key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f50a3454a330"></a>

## `NationalSpire.LiveVoices.Phrase(string, System.Collections.Generic.Dictionary<string, string>, out System.Func<System.Func<string, string>, string>?) — private string Phrase(string bank, Dictionary<string, string> facts, out Func<Func<string, string>, string>? rewrite)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)

**调用：** [`NationalSpire.LiveCommentary.RewriteParts(System.Func<string, string>, string, string, string, System.Collections.Generic.IReadOnlyDictionary<string, string>)`](LiveCommentary.cs.md#symbol-fd0c02e9b862)；[`NationalSpire.LiveSpeechComposer.Compose(string, string, NationalSpire.BroadcastMemory, string, int, System.Collections.Generic.IReadOnlyDictionary<string, string>?, System.Action<string, string>?)`](LiveSpeechComposer.cs.md#symbol-360bdc1037c5)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Min(int, int)`；`string.Contains(char)`；`string.Replace(string, string?, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.SharedPhrases`；`NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.LiveCommentary.RewriteParts(System.Func<string, string>, string, string, string, System.Collections.Generic.IReadOnlyDictionary<string, string>)`；`NationalSpire.LiveSpeechComposer.Compose(string, string, NationalSpire.BroadcastMemory, string, int, System.Collections.Generic.IReadOnlyDictionary<string, string>?, System.Action<string, string>?)`；`NationalSpire.LiveVoiceCatalog.Banks`；`NationalSpire.LiveVoiceState.Recent`；`NationalSpire.LiveVoiceState.Sequence`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices._match`；`NationalSpire.LiveVoices._memory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveCommentary.RewriteParts(System.Func<string, string>, string, string, string, System.Collections.Generic.IReadOnlyDictionary<string, string>)`；输入表达式：`LiveCommentary.RewriteParts(replace, main, separator, tail, capturedFacts)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: replace => LiveCommentary.RewriteParts(replace, main, separator, tail, capturedFacts)`
- `NationalSpire.LiveSpeechComposer.Compose(string, string, NationalSpire.BroadcastMemory, string, int, System.Collections.Generic.IReadOnlyDictionary<string, string>?, System.Action<string, string>?)`；输入表达式：`LiveSpeechComposer.Compose(main, bank, _memory, _match.Seed, state.Sequence, facts, (join, source) => { separator = join; tail = source; })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveSpeechComposer.Compose(main, bank, _memory, _match.Seed, state.Sequence, facts, (join, source) => { separator = join; tail = source; })`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash(bank + ":" + state.Sequence++)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(bank + ":" + state.Sequence++) % lines.Length`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new Dictionary<string, string>(facts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(facts)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`LiveVoiceCatalog.Banks.TryGetValue(bank, out var lines)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LiveVoiceCatalog.Banks.TryGetValue(bank, out var lines)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_memory.SharedPhrases.TryGetValue(historyKey, out var history)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_memory.SharedPhrases.TryGetValue(historyKey, out var history)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`state.Recent.TryGetValue(bank, out var recent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !state.Recent.TryGetValue(bank, out var recent)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；输入表达式：`Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length) .FirstOrDefault(i => !recent.Contains(i) && !history.Contains(lines[i]), Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length).FirstOrDefault(i => !history.Contains(lines[i]), start))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length) .FirstOrDefault(i => !recent.Contains(i) && !history.Contains(lines[i]), Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length).FirstOrDefault(i => !history.Contains(lines[i]), start))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；输入表达式：`Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length).FirstOrDefault(i => !history.Contains(lines[i]), start)`；返回值紧邻使用处：`ArgumentSyntax: Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length).FirstOrDefault(i => !history.Contains(lines[i]), start)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length) .FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length).FirstOrDefault`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`history.Add(lines[index])`；返回值紧邻使用处：`ExpressionStatementSyntax: history.Add(lines[index]);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`recent.Add(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.Add(index);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`history.Contains(lines[i])`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !history.Contains(lines[i])`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`recent.Contains(i)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !recent.Contains(i)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`history.Remove(lines[index])`；返回值紧邻使用处：`ExpressionStatementSyntax: history.Remove(lines[index]);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`recent.Remove(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.Remove(index);`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`history.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: history.RemoveAt(0);`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`recent.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: recent.RemoveAt(0);`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, lines.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, lines.Length).Select`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(10, lines.Length - 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: recent.Count > Math.Min(10, lines.Length - 1)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(10, lines.Length - 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: history.Count > Math.Min(10, lines.Length - 1)`
- `string.Contains(char)`；输入表达式：`text.Contains('{')`；返回值紧邻使用处：`ConditionalExpressionSyntax: text.Contains('{') ? "" : text`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace("{" + key + "}", value, StringComparison.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("{" + key + "}", value, StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**

- `_memory.SharedPhrases[historyKey]` = `history = []`
- `history` = `[]`
- `recent` = `[]`
- `rewrite` = `null`
- `rewrite` = `replace => LiveCommentary.RewriteParts(replace, main, separator, tail, capturedFacts)`
- `separator` = `join`
- `state.Recent[bank]` = `recent = []`
- `tail` = `source`
- `text` = `text.Replace("{" + key + "}", value, StringComparison.Ordinal)`

<a id="symbol-c3c21233cc88"></a>

## `NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson) — private string Tone(CareerPerson person)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.React(string, int, double)`](LiveVoices.cs.md#symbol-ca2aacab4a81)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](LiveVoices.cs.md#symbol-44512aead226)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)

**调用：** [`NationalSpire.PersonalityLibrary.Attitude(NationalSpire.CareerData, string, NationalSpire.PersonalityProfile, string, int)`](PersonalityLibrary.cs.md#symbol-7eb96c180f4e)；[`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityLibrary.cs.md#symbol-902b2bd837d2)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.LiveVoices._data`；`NationalSpire.LiveVoices._match`；`NationalSpire.PersonalityLibrary.Attitude(NationalSpire.CareerData, string, NationalSpire.PersonalityProfile, string, int)`；`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.PersonalityProfile.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalityLibrary.Attitude(NationalSpire.CareerData, string, NationalSpire.PersonalityProfile, string, int)`；输入表达式：`PersonalityLibrary.Attitude(_data, person.Id, person.Personality, _match.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PersonalityLibrary.Attitude(_data, person.Id, person.Personality, _match.Seed)`
- `NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PersonalityLibrary.Ensure(_data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.Ensure(_data, person);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57831f321298"></a>

## `NationalSpire.LiveVoices.Spectator(string, string?, bool) — private CareerPerson? Spectator(string scene, string? exclude = null, bool reply = false)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)；[`NationalSpire.LiveVoices.Poll(double, double)`](LiveVoices.cs.md#symbol-fc95fe2519bc)；[`NationalSpire.LiveVoices.React(string, int, double)`](LiveVoices.cs.md#symbol-ca2aacab4a81)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](LiveVoices.cs.md#symbol-44512aead226)

**调用：** [`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；[`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`](LiveVoices.cs.md#symbol-c3c21233cc88)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerPerson.Id`；`NationalSpire.LiveVoices._audience`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；`NationalSpire.LiveVoiceState.Sequence`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash(scene + _memory.Voices.Sequence)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(scene + _memory.Voices.Sequence) % people.Length`
- `NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；输入表达式：`Tone(p)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Tone(p) is "support" or "tease"`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_audience.Where(p => p.Id != exclude).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _audience.Where(p => p.Id != exclude).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`people.Where(p => Tone(p) is "support" or "tease").ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: people = people.Where(p => Tone(p) is "support" or "tease").ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_audience.Where(p => p.Id != exclude)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _audience.Where(p => p.Id != exclude).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(p => Tone(p) is "support" or "tease")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(p => Tone(p) is "support" or "tease").ToArray`

**赋值（含属性/字段和局部值）：**

- `people` = `people.Where(p => Tone(p) is "support" or "tease").ToArray()`

<a id="symbol-1b186645d9df"></a>

## `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>) — private BroadcastLine? Line(string bank, string role, CareerPerson? person, Dictionary<string, string> facts)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)；[`NationalSpire.LiveVoices.Poll(double, double)`](LiveVoices.cs.md#symbol-fc95fe2519bc)；[`NationalSpire.LiveVoices.React(string, int, double)`](LiveVoices.cs.md#symbol-ca2aacab4a81)；[`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`](LiveVoices.cs.md#symbol-ea0ff7a1e0eb)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](LiveVoices.cs.md#symbol-44512aead226)

**调用：** `NationalSpire.BroadcastLine.BroadcastLine(string, string, bool)`；[`NationalSpire.LiveVoices.Phrase(string, System.Collections.Generic.Dictionary<string, string>, out System.Func<System.Func<string, string>, string>?)`](LiveVoices.cs.md#symbol-f50a3454a330)

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastLine.Rewrite`；`NationalSpire.BroadcastLine.Role`；`NationalSpire.BroadcastLine.SpeakerId`；`NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerPerson.Id`；`NationalSpire.LiveVoiceState.Sequence`；`NationalSpire.LiveVoices.Phrase(string, System.Collections.Generic.Dictionary<string, string>, out System.Func<System.Func<string, string>, string>?)`；`NationalSpire.LiveVoices._memory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastLine.BroadcastLine(string, string, bool)`；输入表达式：`new BroadcastLine(bank, text, _memory.Voices.Sequence % 2 == 0) { SpeakerId = person?.Id ?? "", Role = role, Rewrite = rewrite }`；返回值紧邻使用处：`ConditionalExpressionSyntax: text.Length == 0 ? null : new BroadcastLine(bank, text, _memory.Voices.Sequence % 2 == 0) { SpeakerId = person?.Id ?? "", Role = role, Rewrite = rewrite }`
- `NationalSpire.LiveVoices.Phrase(string, System.Collections.Generic.Dictionary<string, string>, out System.Func<System.Func<string, string>, string>?)`；输入表达式：`Phrase(bank, facts, out var rewrite)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Phrase(bank, facts, out var rewrite)`

**赋值（含属性/字段和局部值）：**

- `Rewrite` = `rewrite`
- `Role` = `role`
- `SpeakerId` = `person?.Id ?? ""`

<a id="symbol-09cc5837543a"></a>

## `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double) — private void Add(BroadcastLine? line, double now, string? replyBank = null, bool priority = false, double lifetime = 35)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)；[`NationalSpire.LiveVoices.Poll(double, double)`](LiveVoices.cs.md#symbol-fc95fe2519bc)；[`NationalSpire.LiveVoices.React(string, int, double)`](LiveVoices.cs.md#symbol-ca2aacab4a81)；[`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`](LiveVoices.cs.md#symbol-ea0ff7a1e0eb)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](LiveVoices.cs.md#symbol-44512aead226)

**调用：** `NationalSpire.LiveVoices.Pending.Pending(NationalSpire.BroadcastLine, double, double, string?)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveVoices._pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveVoices.Pending.Pending(NationalSpire.BroadcastLine, double, double, string?)`；输入表达式：`new(line, now + (priority ? 0 : 8), now + lifetime, replyBank)`；返回值紧邻使用处：`ArgumentSyntax: new(line, now + (priority ? 0 : 8), now + lifetime, replyBank)`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_pending.Enqueue(new(line, now + (priority ? 0 : 8), now + lifetime, replyBank))`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Enqueue(new(line, now + (priority ? 0 : 8), now + lifetime, replyBank));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ca2aacab4a81"></a>

## `NationalSpire.LiveVoices.React(string, int, double) — public void React(string topic, int floor, double now)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](Coop/CoopBroadcast.cs.md#symbol-647e8c7161ba)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`](LiveVoices.cs.md#symbol-09cc5837543a)；[`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)；[`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`](LiveVoices.cs.md#symbol-c3c21233cc88)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.LiveVoiceCatalog.Banks`；`NationalSpire.LiveVoices._data`；`NationalSpire.LiveVoices._finished`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.LiveVoices.Spectator(string, string?, bool)`；`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；`NationalSpire.LiveVoiceState.Floors`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["name"] = CareerEngine.Name(_data)`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line(bank, "audience", person, facts), now, reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line(bank, "audience", person, facts), now, reply);`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line(bank, "audience", person, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line(bank, "audience", person, facts)`
- `NationalSpire.LiveVoices.Spectator(string, string?, bool)`；输入表达式：`Spectator(scene)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Spectator(scene)`
- `NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；输入表达式：`Tone(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Tone(person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: tone == "doubt" && LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data) }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_memory.Voices.Floors.GetValueOrDefault(scene, -10)`；返回值紧邻使用处：`BinaryExpressionSyntax: floor - _memory.Voices.Floors.GetValueOrDefault(scene, -10)`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`

**赋值（含属性/字段和局部值）：**

- `_finished` = `true`
- `_memory.Voices.Floors[scene]` = `floor`
- `["name"]` = `CareerEngine.Name(_data)`

<a id="symbol-44512aead226"></a>

## `NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string) — public void Shop(string kind, string item, int deckSize, int gold, string name, int floor, double now, string cardType = "")`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)

**调用：** [`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`](LiveVoices.cs.md#symbol-09cc5837543a)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；[`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)；[`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`](LiveVoices.cs.md#symbol-c3c21233cc88)；`int.ToString()`；`string.StartsWith(string)`；`string.ToLowerInvariant()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.Voices`；`NationalSpire.LiveVoiceCatalog.Banks`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.LiveVoices.Spectator(string, string?, bool)`；`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；`NationalSpire.LiveVoiceState.Floors`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`deckSize.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["deck"] = deckSize.ToString()`
- `int.ToString()`；输入表达式：`gold.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["gold"] = gold.ToString()`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line("audience_" + scene + "_" + tone, "audience", person, facts), now,             tone == "doubt" && LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene) ? "reply_" + scene : null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line("audience_" + scene + "_" + tone, "audience", person, facts), now,             tone == "doubt" && LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene) ? "reply_" + scene : null);`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line("audience_gain_" + type, "audience", viewer, facts), now, lifetime: 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line("audience_gain_" + type, "audience", viewer, facts), now, lifetime: 24);`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line("shop_" + kind, "commentator", null, facts), now, priority: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line("shop_" + kind, "commentator", null, facts), now, priority: true);`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("card_gain:" + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("card_gain:" + floor) % 3`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line("audience_" + scene + "_" + tone, "audience", person, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line("audience_" + scene + "_" + tone, "audience", person, facts)`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line("audience_gain_" + type, "audience", viewer, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line("audience_gain_" + type, "audience", viewer, facts)`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line("shop_" + kind, "commentator", null, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line("shop_" + kind, "commentator", null, facts)`
- `NationalSpire.LiveVoices.Spectator(string, string?, bool)`；输入表达式：`Spectator("card_gain")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Spectator("card_gain")`
- `NationalSpire.LiveVoices.Spectator(string, string?, bool)`；输入表达式：`Spectator(scene)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Spectator(scene)`
- `NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；输入表达式：`Tone(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Tone(person)`
- `string.StartsWith(string)`；输入表达式：`kind.StartsWith("remove")`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind.StartsWith("remove") ? deckSize <= 10 ? "small" : "remove" : "buy"`
- `string.ToLowerInvariant()`；输入表达式：`cardType.ToLowerInvariant()`；返回值紧邻使用处：`ConditionalExpressionSyntax: cardType is "Attack" or "Skill" or "Power" ? cardType.ToLowerInvariant() : "other"`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: tone == "doubt" && LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["item"] = item, ["name"] = name, ["deck"] = deckSize.ToString(), ["gold"] = gold.ToString() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["item"] = item, ["name"] = name, ["deck"] = deckSize.ToString(), ["gold"] = gold.ToString() }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_memory.Voices.Floors.GetValueOrDefault("card_gain", -10)`；返回值紧邻使用处：`BinaryExpressionSyntax: _memory.Voices.Floors.GetValueOrDefault("card_gain", -10) == floor`

**赋值（含属性/字段和局部值）：**

- `_memory.Voices.Floors["card_gain"]` = `floor`
- `["deck"]` = `deckSize.ToString()`
- `["gold"]` = `gold.ToString()`
- `["item"]` = `item`
- `["name"]` = `name`

<a id="symbol-ea0ff7a1e0eb"></a>

## `NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?) — public void Rival(int floor, int act, int hp, int maxHp, RivalProgress progress, LiveMatchState live, double now,         IEnumerable<(string Id, RivalProgress Progress, int MaxHp)>? members = null)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`](LiveVoices.cs.md#symbol-09cc5837543a)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；[`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)；[`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityLibrary.cs.md#symbol-902b2bd837d2)；[`NationalSpire.RivalSimulation.Combat(string)`](LiveMatch.cs.md#symbol-c1fca9bc3395)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Math.Abs(int)`

**字段、属性、事件及方法组引用：** `(string Id, NationalSpire.RivalProgress Progress, int MaxHp).Id`；`(string Id, NationalSpire.RivalProgress Progress, int MaxHp).MaxHp`；`(string Id, NationalSpire.RivalProgress Progress, int MaxHp).Progress`；`NationalSpire.BroadcastLine.Role`；`NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.PaceNeutralUntil`；`NationalSpire.LiveVoices._data`；`NationalSpire.LiveVoices._lastRivalFloor`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._opponents`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.LiveVoices.Pending.Line`；`NationalSpire.LiveVoiceState.Floors`；`NationalSpire.LiveVoiceState.LastOptional`；`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.PersonalityProfile.AttitudeMin`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.Combat(string)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`Math.Abs(gap).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["gap"] = Math.Abs(gap).ToString()`
- `int.ToString()`；输入表达式：`rival.Progress.Hp.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["hp"] = rival.Progress.Hp.ToString()`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["name"] = CareerEngine.Name(_data)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(_data, rival.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(_data, rival.Id)`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line("thought_" + scene + "_" + temper, "thought", person, facts), now)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line("thought_" + scene + "_" + temper, "thought", person, facts), now);`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("rival:" + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("rival:" + floor) % candidates.Length`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line("thought_" + scene + "_" + temper, "thought", person, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line("thought_" + scene + "_" + temper, "thought", person, facts)`
- `NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PersonalityLibrary.Ensure(_data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.Ensure(_data, person);`
- `NationalSpire.RivalSimulation.Combat(string)`；输入表达式：`RivalSimulation.Combat(rival.Progress.Step.Kind)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !RivalSimulation.Combat(rival.Progress.Step.Kind)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["gap"] = Math.Abs(gap).ToString(), ["hp"] = rival.Progress.Hp.ToString(), ["name"] = CareerEngine.Name(_data) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["gap"] = Math.Abs(gap).ToString(), ["hp"] = rival.Progress.Hp.ToString(), ["name"] = CareerEngine.Name(_data) }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_opponents.Select(id => (Id: id, Progress: progress, MaxHp: live.MaxHp))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _opponents.Select(id => (Id: id, Progress: progress, MaxHp: live.MaxHp)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_opponents.Select(id => (Id: id, Progress: progress, MaxHp: live.MaxHp)).ToArray()`；返回值紧邻使用处：`BinaryExpressionSyntax: members?.Where(m => !m.Progress.Finished).ToArray()             ?? _opponents.Select(id => (Id: id, Progress: progress, MaxHp: live.MaxHp)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_pending.Where(p => p.Line.Role != "thought").ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _pending.Where(p => p.Line.Role != "thought").ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`.Where(m => !m.Progress.Finished).ToArray()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: members?.Where(m => !m.Progress.Finished).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_pending.Where(p => p.Line.Role != "thought")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pending.Where(p => p.Line.Role != "thought").ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Where(m => !m.Progress.Finished)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Where(m => !m.Progress.Finished).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_memory.Voices.Floors.GetValueOrDefault("thought:" + scene, -12)`；返回值紧邻使用处：`BinaryExpressionSyntax: floor - _memory.Voices.Floors.GetValueOrDefault("thought:" + scene, -12)`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_pending.Enqueue(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Enqueue(entry);`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(gap)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Math.Abs(gap).ToString`

**赋值（含属性/字段和局部值）：**

- `_lastRivalFloor` = `floor`
- `_memory.Voices.Floors["thought:" + scene]` = `floor`
- `["gap"]` = `Math.Abs(gap).ToString()`
- `["hp"]` = `rival.Progress.Hp.ToString()`
- `["name"]` = `CareerEngine.Name(_data)`

<a id="symbol-fc95fe2519bc"></a>

## `NationalSpire.LiveVoices.Poll(double, double) — public BroadcastLine? Poll(double now, double lastCommentary)`

来源：源码第 171 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`](LiveVoices.cs.md#symbol-09cc5837543a)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；[`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)；[`NationalSpire.LiveVoices.RestoreVoiceClock(double)`](LiveCrowd.cs.md#symbol-ee58b4cd422c)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.TryPeek(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastLine.Role`；`NationalSpire.BroadcastLine.SpeakerId`；`NationalSpire.BroadcastLine.Text`；`NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.LiveVoices._data`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.LiveVoices.Pending.At`；`NationalSpire.LiveVoices.Pending.Expires`；`NationalSpire.LiveVoices.Pending.Line`；`NationalSpire.LiveVoices.Pending.ReplyBank`；`NationalSpire.LiveVoices.RestoreVoiceClock(double)`；`NationalSpire.LiveVoices.Spectator(string, string?, bool)`；`NationalSpire.LiveVoiceState.LastOptional`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["name"] = CareerEngine.Name(_data)`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line(next.ReplyBank, "audience", responder, facts), now)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line(next.ReplyBank, "audience", responder, facts), now);`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash(next.Line.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(next.Line.Text) % 3`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line(next.ReplyBank, "audience", responder, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line(next.ReplyBank, "audience", responder, facts)`
- `NationalSpire.LiveVoices.RestoreVoiceClock(double)`；输入表达式：`RestoreVoiceClock(now)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVoiceClock(now);`
- `NationalSpire.LiveVoices.Spectator(string, string?, bool)`；输入表达式：`Spectator(next.ReplyBank, next.Line.SpeakerId, true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Spectator(next.ReplyBank, next.Line.SpeakerId, true) is { } responder`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data) }`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`_pending.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Dequeue();`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`_pending.TryPeek(out var next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_pending.TryPeek(out var next)`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`_pending.TryPeek(out var old)`；返回值紧邻使用处：`BinaryExpressionSyntax: _pending.TryPeek(out var old) && old.Expires < now`

**赋值（含属性/字段和局部值）：**

- `_memory.Voices.LastOptional` = `now`
- `["name"]` = `CareerEngine.Name(_data)`
