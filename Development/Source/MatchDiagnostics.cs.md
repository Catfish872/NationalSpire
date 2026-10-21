# MatchDiagnostics.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9D1F9A605A726670F002DDE58CD628B3B18449A74168C170153C51CA4E365D5D`。来源：[源码](../../MatchDiagnostics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Diagnostics`、`NationalSpire.Diagnostics.TraceSnapshot`。

字段、事件及初始值（源码原样）：

```csharp
private readonly long _length = length;
private long _remaining = length;
```

<a id="symbol-a74e8a9c83f1"></a>

## `NationalSpire.Diagnostics.TraceKey(string) — private static string TraceKey(string value)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.ReadMatchTraces(string?)`](MatchDiagnostics.cs.md#symbol-98c47503da5b)；[`NationalSpire.Diagnostics.RecordEventCheck(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption, string)`](EventDiagnostics.cs.md#symbol-cb8ce43827bb)

**调用：** `System.Convert.ToHexString(byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value)))`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(Encoding.UTF8.GetBytes(value))`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(Encoding.UTF8.GetBytes(value))`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(value)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2f83ebe4626e"></a>

## `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool) — public static void RecordMatch(CoopWorld world, string stage, object? detail = null, bool includePlan = false)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](Coop/CoopNativeRun.cs.md#symbol-5825a51bfef3)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?)`](Coop/CoopRules.cs.md#symbol-570bf786ec18)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](Coop/CoopRuntime.cs.md#symbol-732476d12d29)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](Coop/CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.LogMeasure.Dispose()`](LogPerformance.cs.md#symbol-75d22d30761d)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.Diagnostics.WriteLog(string, string)`](LogStorage.cs.md#symbol-8e704b8bed92)；[`Progress(NationalSpire.LiveMatchState?)`](MatchDiagnostics.cs.md#symbol-3f2e20b8f687)；`NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Abs(double)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.match`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.memberPlans`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.members`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.opponents`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.plan`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.plannedEnd`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.progress`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.utc`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.version`；`<anonymous type: System.DateTimeOffset utc, string version, string stage, string world, string Attempt, string MatchId, string Seed, int ResumeCount, string Phase, double Clock, int Act, int Floor, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> Players, System.Collections.Generic.List<string> opponents, object progress, System.Collections.Generic.Dictionary<string, object> members, <anonymous type: bool OpponentPrepared, bool OpponentWon, int OpponentFloor, double? OpponentSeconds, string Status> match, <anonymous type: int Floor, double End, bool Cleared> plannedEnd, System.Collections.Generic.List<string> differences, NationalSpire.LiveMatchState plan, System.Collections.Generic.Dictionary<string, NationalSpire.LiveMatchState> memberPlans, object detail>.world`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.Status`；`NationalSpire.Coop.CoopRun.Act`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Clock`；`NationalSpire.Coop.CoopRun.Floor`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Players`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRun.Rival`；`NationalSpire.Coop.CoopRun.RivalMembers`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics._directory`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Gate`；`NationalSpire.Diagnostics.Json`；`NationalSpire.Diagnostics.LogMeasure.Dispose()`；`NationalSpire.Diagnostics.LogWork.Match`；`NationalSpire.Diagnostics.LogWork.Serialize`；`NationalSpire.Diagnostics.LogWork.WaitForWrite`；`NationalSpire.Diagnostics.LogWork.Write`；`NationalSpire.Diagnostics.ModVersion`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.WriteLog(string, string)`；`NationalSpire.LiveMatchState.Cleared`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.RivalStep.End`；`NationalSpire.RivalStep.Floor`；`Progress(NationalSpire.LiveMatchState?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Error("match.diagnostics", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("match.diagnostics", e);`
- `NationalSpire.Diagnostics.LogMeasure.Dispose()`；输入表达式：`waiting.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: waiting.Dispose();`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Match, stage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Match, stage)`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Serialize, stage)`；返回值紧邻使用处：`UsingStatementSyntax: using (new LogMeasure(LogWork.Serialize, stage)) line = JsonSerializer.Serialize(new             {                 utc = DateTimeOffset.UtcNow, version = ModVersion, stage, world = world.World.WorldId,                 run.Attempt, run.MatchId, run.Seed, run.ResumeCount, run.Phase, run.Clock, run.Act, run.Floor,                 run.Players, opponents = run.Opponents, progress = Progress(run.Rival),                 members = run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value)),                 match = match == null ? null : new { match.OpponentPrepared, match.OpponentWon, match.OpponentFloor, match.OpponentSeconds, match.Status },                 plannedEnd = last == null ? null : new { last.Floor, last.End, run.Rival!.Cleared }, differences,                 plan = includePlan ? run.Rival : null, memberPlans = includePlan ? run.RivalMembers : null, detail             }, Json);`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.WaitForWrite, stage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.WaitForWrite, stage)`
- `NationalSpire.Diagnostics.LogMeasure.LogMeasure(NationalSpire.Diagnostics.LogWork, string)`；输入表达式：`new LogMeasure(LogWork.Write, stage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LogMeasure(LogWork.Write, stage)`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(line)`；返回值紧邻使用处：`AssignmentExpressionSyntax: line = Redact(line)`
- `NationalSpire.Diagnostics.WriteLog(string, string)`；输入表达式：`WriteLog("matches.jsonl", line)`；返回值紧邻使用处：`ExpressionStatementSyntax: WriteLog("matches.jsonl", line);`
- `Progress(NationalSpire.LiveMatchState?)`；输入表达式：`Progress(p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Progress(p.Value)`
- `Progress(NationalSpire.LiveMatchState?)`；输入表达式：`Progress(run.Rival)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: progress = Progress(run.Rival)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.World.Matches.FirstOrDefault(m => m.Id == run.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = world.World.Matches.FirstOrDefault(m => m.Id == run.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`.Steps.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: run.Rival?.Steps.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value))`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: members = run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`differences.Add("路线结束时间与结算依据不同")`；返回值紧邻使用处：`ExpressionStatementSyntax: differences.Add("路线结束时间与结算依据不同");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`differences.Add("路线死亡楼层与结算依据不同")`；返回值紧邻使用处：`ExpressionStatementSyntax: differences.Add("路线死亡楼层与结算依据不同");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`differences.Add("路线通关结果与结算依据不同")`；返回值紧邻使用处：`ExpressionStatementSyntax: differences.Add("路线通关结果与结算依据不同");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Math.Abs(double)`；输入表达式：`Math.Abs(last.End - seconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(last.End - seconds) > .01`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new             {                 utc = DateTimeOffset.UtcNow, version = ModVersion, stage, world = world.World.WorldId,                 run.Attempt, run.MatchId, run.Seed, run.ResumeCount, run.Phase, run.Clock, run.Act, run.Floor,                 run.Players, opponents = run.Opponents, progress = Progress(run.Rival),                 members = run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value)),                 match = match == null ? null : new { match.OpponentPrepared, match.OpponentWon, match.OpponentFloor, match.OpponentSeconds, match.Status },                 plannedEnd = last == null ? null : new { last.Floor, last.End, run.Rival!.Cleared }, differences,                 plan = includePlan ? run.Rival : null, memberPlans = includePlan ? run.RivalMembers : null, detail             }, Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: line = JsonSerializer.Serialize(new             {                 utc = DateTimeOffset.UtcNow, version = ModVersion, stage, world = world.World.WorldId,                 run.Attempt, run.MatchId, run.Seed, run.ResumeCount, run.Phase, run.Clock, run.Act, run.Floor,                 run.Players, opponents = run.Opponents, progress = Progress(run.Rival),                 members = run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value)),                 match = match == null ? null : new { match.OpponentPrepared, match.OpponentWon, match.OpponentFloor, match.OpponentSeconds, match.Status },                 plannedEnd = last == null ? null : new { last.Floor, last.End, run.Rival!.Cleared }, differences,                 plan = includePlan ? run.Rival : null, memberPlans = includePlan ? run.RivalMembers : null, detail             }, Json)`

**赋值（含属性/字段和局部值）：**

- `line` = `JsonSerializer.Serialize(new             {                 utc = DateTimeOffset.UtcNow, version = ModVersion, stage, world = world.World.WorldId,                 run.Attempt, run.MatchId, run.Seed, run.ResumeCount, run.Phase, run.Clock, run.Act, run.Floor,                 run.Players, opponents = run.Opponents, progress = Progress(run.Rival),                 members = run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value)),                 match = match == null ? null : new { match.OpponentPrepared, match.OpponentWon, match.OpponentFloor, match.OpponentSeconds, match.Status },                 plannedEnd = last == null ? null : new { last.Floor, last.End, run.Rival!.Cleared }, differences,                 plan = includePlan ? run.Rival : null, memberPlans = includePlan ? run.RivalMembers : null, detail             }, Json)`
- `line` = `Redact(line)`

<a id="symbol-3f2e20b8f687"></a>

## `Progress(NationalSpire.LiveMatchState?) — object? Progress(LiveMatchState? live)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](MatchDiagnostics.cs.md#symbol-2f83ebe4626e)

**调用：** [`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`](LiveMatch.cs.md#symbol-78308976d2a9)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRun.Clock`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(live, run.Clock)`；返回值紧邻使用处：`ConditionalExpressionSyntax: live is { Steps.Count: > 0 } ? RivalSimulation.At(live, run.Clock) : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-98c47503da5b"></a>

## `NationalSpire.Diagnostics.ReadMatchTraces(string?) — private static IEnumerable<KeyValuePair<string, string>> ReadMatchTraces(string? worldId)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](Diagnostics.cs.md#symbol-8481032d98dd)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.LegacyLogs(string, string)`](LogStorage.cs.md#symbol-365cff1c19cd)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)；[`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；[`NationalSpire.Diagnostics.TraceKey(string)`](MatchDiagnostics.cs.md#symbol-a74e8a9c83f1)；`string.IsNullOrEmpty(string?)`；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；`System.IO.Path.Combine(string, string)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.LegacyLogs(string, string)`；`NationalSpire.Diagnostics.ReadLogs(string)`；`NationalSpire.Diagnostics.Redact(string)`；`NationalSpire.Diagnostics.TraceKey(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Error("match.diagnostics.read", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Error("match.diagnostics.read", error);`
- `NationalSpire.Diagnostics.LegacyLogs(string, string)`；输入表达式：`LegacyLogs(Path.Combine("matches", TraceKey(worldId)), "*.jsonl")`；返回值紧邻使用处：`ArgumentSyntax: LegacyLogs(Path.Combine("matches", TraceKey(worldId)), "*.jsonl")`
- `NationalSpire.Diagnostics.ReadLogs(string)`；输入表达式：`ReadLogs("matches.jsonl")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ReadLogs("matches.jsonl").Concat`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Redact(content.ToString())`；返回值紧邻使用处：`ArgumentSyntax: Redact(content.ToString())`
- `NationalSpire.Diagnostics.TraceKey(string)`；输入表达式：`TraceKey(worldId)`；返回值紧邻使用处：`ArgumentSyntax: TraceKey(worldId)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(worldId)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrEmpty(worldId)) yield break;`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`file.Value.Split('\n', StringSplitOptions.RemoveEmptyEntries)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string line in file.Value.Split('\n', StringSplitOptions.RemoveEmptyEntries))                 try                 {                     using var record = JsonDocument.Parse(line);                     if (record.RootElement.GetProperty("world").GetString() == worldId) content.AppendLine(line);                 }                 catch (Exception error) { Error("match.diagnostics.read", error); }`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`ReadLogs("matches.jsonl").Concat(LegacyLogs(Path.Combine("matches", TraceKey(worldId)), "*.jsonl"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var file in ReadLogs("matches.jsonl").Concat(LegacyLogs(Path.Combine("matches", TraceKey(worldId)), "*.jsonl")))         {             var content = new StringBuilder();             foreach (string line in file.Value.Split('\n', StringSplitOptions.RemoveEmptyEntries))                 try                 {                     using var record = JsonDocument.Parse(line);                     if (record.RootElement.GetProperty("world").GetString() == worldId) content.AppendLine(line);                 }                 catch (Exception error) { Error("match.diagnostics.read", error); }             if (content.Length > 0) yield return new(file.Key, Redact(content.ToString()));         }`
- `System.Collections.Generic.KeyValuePair<TKey, TValue>.KeyValuePair(TKey, TValue)`；输入表达式：`new(file.Key, Redact(content.ToString()))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(file.Key, Redact(content.ToString()));`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine("matches", TraceKey(worldId))`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine("matches", TraceKey(worldId))`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(line)`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`record.RootElement.GetProperty("world")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: record.RootElement.GetProperty("world").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`record.RootElement.GetProperty("world").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: record.RootElement.GetProperty("world").GetString() == worldId`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`content.AppendLine(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AppendLine(line);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`content.ToString()`；返回值紧邻使用处：`ArgumentSyntax: content.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8f11b54b7a73"></a>

## `NationalSpire.Diagnostics.OpenTraceSnapshot(string, out long) — private static FileStream OpenTraceSnapshot(string path, out long length)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.LegacyLogs(string, string)`](LogStorage.cs.md#symbol-365cff1c19cd)；[`NationalSpire.Diagnostics.ReadLogs(string)`](LogStorage.cs.md#symbol-a180c6c02b7d)

**调用：** `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；`System.IO.Stream.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Gate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)`；输入表达式：`new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)`
- `System.IO.Stream.Dispose()`；输入表达式：`input.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: input.Dispose();`

**赋值（含属性/字段和局部值）：**

- `length` = `input.Length`

<a id="symbol-7fdaff540df3"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.CanRead — public override bool CanRead`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f850f9d3f3a7"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.CanSeek — public override bool CanSeek`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7b5124e65a19"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.CanWrite — public override bool CanWrite`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0812a9b4b90a"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Length — public override long Length`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.TraceSnapshot._length`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e8a67e62ca56"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Position — public override long Position`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.TraceSnapshot._length`；`NationalSpire.Diagnostics.TraceSnapshot._remaining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-deaab34f1e00"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Read(byte[], int, int) — public override int Read(byte[] buffer, int offset, int count)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.IO.FileStream.Read(byte[], int, int)`；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.TraceSnapshot._remaining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.FileStream.Read(byte[], int, int)`；输入表达式：`input.Read(buffer, offset, (int)Math.Min(count, _remaining))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = input.Read(buffer, offset, (int)Math.Min(count, _remaining))`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(count, _remaining)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(count, _remaining)`

**赋值（含属性/字段和局部值）：**

- `_remaining` -= `read`

<a id="symbol-c8d1502301a4"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Read(System.Span<byte>) — public override int Read(Span<byte> buffer)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.IO.FileStream.Read(System.Span<byte>)`；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.TraceSnapshot._remaining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.FileStream.Read(System.Span<byte>)`；输入表达式：`input.Read(buffer[..(int)Math.Min(buffer.Length, _remaining)])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = input.Read(buffer[..(int)Math.Min(buffer.Length, _remaining)])`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(buffer.Length, _remaining)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(buffer.Length, _remaining)`

**赋值（含属性/字段和局部值）：**

- `_remaining` -= `read`

<a id="symbol-485fe3e707c1"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Flush() — public override void Flush()`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-79b4390245f1"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Seek(long, System.IO.SeekOrigin) — public override long Seek(long offset, SeekOrigin origin)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9f20cdebf76"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.SetLength(long) — public override void SetLength(long value)`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-922f4d94a032"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Write(byte[], int, int) — public override void Write(byte[] buffer, int offset, int count)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.NotSupportedException.NotSupportedException()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-23161c5cb2be"></a>

## `NationalSpire.Diagnostics.TraceSnapshot.Dispose(bool) — protected override void Dispose(bool disposing)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.IO.Stream.Dispose()`；`System.IO.Stream.Dispose(bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Stream.Dispose()`；输入表达式：`input.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: input.Dispose();`
- `System.IO.Stream.Dispose(bool)`；输入表达式：`base.Dispose(disposing)`；返回值紧邻使用处：`ExpressionStatementSyntax: base.Dispose(disposing);`

**赋值（含属性/字段和局部值）：**
