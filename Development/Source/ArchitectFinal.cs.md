# ArchitectFinal.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`234C16FEE5D852549200B8C336187ED557D4D1174B15C3DB48781A286AE2CF71`。来源：[源码](../../ArchitectFinal.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ArchitectFinal`、`NationalSpire.StartArchitectPage`、`NationalSpire.FinalChoiceEvent`、`NationalSpire.LeagueNativeMatch`、`NationalSpire.LeagueNativeMatch.Adventure`、`NationalSpire.FinalEndHooks`、`NationalSpire.ArchitectCombatOutcome`、`NationalSpire.ArchitectCombatLoss`。

字段、事件及初始值（源码原样）：

```csharp
internal static EventRoom? Destination;
internal static bool Returning;
internal static double Arrival;
private const string WinKey="FINAL_CHOICE_EVENT.result.win",LossKey="FINAL_CHOICE_EVENT.result.loss";
internal static readonly Func<EventRoom,Action<EventModel>?> OnStart=AccessTools.PropertyGetter(typeof(EventRoom),"OnStart").CreateDelegate<Func<EventRoom,Action<EventModel>?>>();
private static readonly List<LeagueDuel> Team=[];
private static readonly HashSet<LeagueDuel> Opened=[];
internal bool? Outcome;
private readonly string? entryTrack=PlayingTrack(MusicProxy);
readonly bool replay=RunManager.Instance.CombatReplayWriter.IsEnabled;
readonly SerializablePlayer[] players=run.Players.Select(p=>p.ToSerializable()).ToArray();
readonly SerializableRunRngSet rng=run.Rng.ToSerializable();
readonly MapPointHistoryEntry? floor=run.CurrentMapPointHistoryEntry;
readonly List<MapPointRoomHistoryEntry>? rooms=run.CurrentMapPointHistoryEntry?.Rooms;
readonly List<PlayerMapPointHistoryEntry>? stats=run.CurrentMapPointHistoryEntry?.PlayerStats;
private static Adventure? _adventure;
private static Action<CombatManager> StopLoop=null!;
internal static readonly Type? Turn=typeof(CombatManager).Assembly.GetType("MegaCrit.Sts2.Core.Combat.CombatTurnState");
```

<a id="symbol-d0e6bb92184c"></a>

## `NationalSpire.ArchitectFinal.Result(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>>) — internal static bool? Result(IEnumerable<IEnumerable<MapPointHistoryEntry>> history)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ArchitectFinal.Prefix(MegaCrit.Sts2.Core.Rooms.AbstractRoom)`](ArchitectFinal.cs.md#symbol-3be2f7b68ae9)；[`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](Coop/CoopRuntime.cs.md#symbol-732476d12d29)；[`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.LossKey`；`NationalSpire.ArchitectFinal.WinKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.SelectMany(act=>act).SelectMany(f=>f.PlayerStats).SelectMany(p=>p.EventChoices)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var choice in history.SelectMany(act=>act).SelectMany(f=>f.PlayerStats).SelectMany(p=>p.EventChoices)){             if(choice.Title?.LocTable!="events")continue;             if(choice.Title.LocEntryKey==WinKey)return true;             if(choice.Title.LocEntryKey==LossKey)return false;         }`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.SelectMany(act=>act).SelectMany(f=>f.PlayerStats)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.SelectMany(act=>act).SelectMany(f=>f.PlayerStats).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.SelectMany(act=>act)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.SelectMany(act=>act).SelectMany`

**赋值（含属性/字段和局部值）：**


<a id="symbol-833efec7ee8d"></a>

## `NationalSpire.ArchitectFinal.Report(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>>) — internal static DuelReport? Report(IEnumerable<IEnumerable<MapPointHistoryEntry>> history)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-3b790044a598)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.LossKey`；`NationalSpire.ArchitectFinal.WinKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.SelectMany(a=>a).SelectMany(f=>f.PlayerStats).SelectMany(p=>p.EventChoices)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var e in history.SelectMany(a=>a).SelectMany(f=>f.PlayerStats).SelectMany(p=>p.EventChoices))             if(e.Title?.LocTable=="events" && e.Title.LocEntryKey is WinKey or LossKey && e.Variables?.GetValueOrDefault("nationalSpireDuel") is string json)                 return System.Text.Json.JsonSerializer.Deserialize<DuelReport>(json);`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.SelectMany(a=>a).SelectMany(f=>f.PlayerStats)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.SelectMany(a=>a).SelectMany(f=>f.PlayerStats).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.SelectMany(a=>a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.SelectMany(a=>a).SelectMany`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault("nationalSpireDuel")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: e.Variables?.GetValueOrDefault("nationalSpireDuel")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<DuelReport>(json)`；返回值紧邻使用处：`ReturnStatementSyntax: return System.Text.Json.JsonSerializer.Deserialize<DuelReport>(json);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-28d314792588"></a>

## `NationalSpire.ArchitectFinal.Record(MegaCrit.Sts2.Core.Runs.RunState, bool, NationalSpire.DuelReport?) — internal static void Record(RunState run,bool won,DuelReport? report=null)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)

**调用：** `MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；`MegaCrit.Sts2.Core.Runs.History.EventOptionHistoryEntry.EventOptionHistoryEntry()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.LossKey`；`NationalSpire.ArchitectFinal.WinKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；输入表达式：`new LocString("events",won?WinKey:LossKey)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Title=new LocString("events",won?WinKey:LossKey)`
- `MegaCrit.Sts2.Core.Runs.History.EventOptionHistoryEntry.EventOptionHistoryEntry()`；输入表达式：`new(){Title=new LocString("events",won?WinKey:LossKey), Variables= report==null ? null : new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}}`；返回值紧邻使用处：`ArgumentSyntax: new(){Title=new LocString("events",won?WinKey:LossKey), Variables= report==null ? null : new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}`；返回值紧邻使用处：`ConditionalExpressionSyntax: report==null ? null : new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`p.EventChoices.Add(new(){Title=new LocString("events",won?WinKey:LossKey), Variables= report==null ? null : new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}})`；返回值紧邻使用处：`ExpressionStatementSyntax: p.EventChoices.Add(new(){Title=new LocString("events",won?WinKey:LossKey), Variables= report==null ? null : new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}});`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(report)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)`

**赋值（含属性/字段和局部值）：**

- `["nationalSpireDuel"]` = `System.Text.Json.JsonSerializer.Serialize(report)`
- `report` = `null`
- `Title` = `new LocString("events",won?WinKey:LossKey)`
- `Variables` = `report==null ? null : new(){["nationalSpireDuel"]=System.Text.Json.JsonSerializer.Serialize(report)}`

<a id="symbol-3956d0a87e48"></a>

## `NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState) — internal static CareerMatch? Match(RunState run)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ArchitectFinal.Prefix(MegaCrit.Sts2.Core.Rooms.AbstractRoom)`](ArchitectFinal.cs.md#symbol-3be2f7b68ae9)；[`NationalSpire.FinalChoiceEvent.GenerateInitialOptions()`](ArchitectFinal.cs.md#symbol-f58ddea45ef0)；[`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** [`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`](CareerRunBinding.cs.md#symbol-98b98bdd8fa3)；[`NationalSpire.CareerRunBinding.SameSeed(string, string)`](CareerRunBinding.cs.md#symbol-33566aec03ac)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`；`NationalSpire.CareerRunBinding.SameSeed(string, string)`；`NationalSpire.CareerStore.Data`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`run.Players[0].Character.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: run.Players[0].Character.Id.ToString()`
- `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`；输入表达式：`CareerRunBinding.Find(CareerStore.Data,run.Rng.StringSeed,run.Players[0].Character.Id.ToString(),run.AscensionLevel,1,run.GameMode.ToString())`；返回值紧邻使用处：`ReturnStatementSyntax: return CareerRunBinding.Find(CareerStore.Data,run.Rng.StringSeed,run.Players[0].Character.Id.ToString(),run.AscensionLevel,1,run.GameMode.ToString());`
- `NationalSpire.CareerRunBinding.SameSeed(string, string)`；输入表达式：`CareerRunBinding.SameSeed(team.Seed,run.Rng.StringSeed)`；返回值紧邻使用处：`BinaryExpressionSyntax: session?.World is { Run: {} team } world&&CareerRunBinding.SameSeed(team.Seed,run.Rng.StringSeed)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.World.Matches.FirstOrDefault(m=>m.Id==team.MatchId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: session?.World is { Run: {} team } world&&CareerRunBinding.SameSeed(team.Seed,run.Rng.StringSeed)?world.World.Matches.FirstOrDefault(m=>m.Id==team.MatchId):null`
- `System.Enum.ToString()`；输入表达式：`run.GameMode.ToString()`；返回值紧邻使用处：`ArgumentSyntax: run.GameMode.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3be2f7b68ae9"></a>

## `NationalSpire.ArchitectFinal.Prefix(MegaCrit.Sts2.Core.Rooms.AbstractRoom) — static void Prefix(AbstractRoom room)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`](ArchitectFinal.cs.md#symbol-3956d0a87e48)；[`NationalSpire.ArchitectFinal.Result(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>>)`](ArchitectFinal.cs.md#symbol-d0e6bb92184c)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Arrival`；`NationalSpire.ArchitectFinal.Destination`；`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.ArchitectFinal.Result(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>>)`；`NationalSpire.ArchitectFinal.Returning`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`IsPatternExpressionSyntax: RunManager.Instance.DebugOnlyGetState() is not {} run`
- `NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`Match(run)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Match(run) is not {DateGame:null} match`
- `NationalSpire.ArchitectFinal.Result(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>>)`；输入表达式：`Result(run.MapPointHistory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Result(run.MapPointHistory).HasValue`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(match)`；返回值紧邻使用处：`BinaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState() is not {} run||Match(run) is not {DateGame:null} match||Result(run.MapPointHistory).HasValue||PrivateAppointments.IsPrivate(match)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(architect,Destination)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReferenceEquals(architect,Destination)&&Returning`

**赋值（含属性/字段和局部值）：**

- `Arrival` = `RunManager.Instance.RunTime`
- `Destination` = `architect`
- `Destination` = `null`
- `Returning` = `false`

<a id="symbol-42cc1c0a9ec8"></a>

## `NationalSpire.ArchitectFinal.Continue() — internal static async Task Continue()`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choice(string, bool)`](ArchitectFinal.cs.md#symbol-f35424e52f43)；[`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)

**调用：** [`NationalSpire.FinalChoiceEvent.FinishPage()`](ArchitectFinal.cs.md#symbol-41f1996b8ea9)；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.EventModel.AfterEventStarted()`；`MegaCrit.Sts2.Core.Models.EventModel.OnRoomEnter()`；`MegaCrit.Sts2.Core.Models.EventModel.SetNode(Godot.Control)`；`MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.AwaitPendingOptionTasks()`；`MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.BeginEvent(MegaCrit.Sts2.Core.Models.EventModel, bool, System.Action<MegaCrit.Sts2.Core.Models.EventModel>?)`；`MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.GetLocalEvent()`；`MegaCrit.Sts2.Core.Nodes.Events.NEventLayout.SetTitle(string)`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`MegaCrit.Sts2.Core.Runs.RunManager.EnterRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom)`；`object.GetType()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Reflection.FieldInfo.SetValue(object?, object?)`；`System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；`System.Type.GetField(string, System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Destination`；`NationalSpire.ArchitectFinal.Returning`；`NationalSpire.FinalChoiceEvent.FinishPage()`；`NationalSpire.StartArchitectPage.OnStart`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(combat.GetType(),"_canonicalEvent")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(combat.GetType(),"_canonicalEvent").SetValue`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(EventModel),name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Field(typeof(EventModel),name)`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(NEventLayout),"_event")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(typeof(NEventLayout),"_event").SetValue`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(NEventRoom),"_event")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(typeof(NEventRoom),"_event").SetValue`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NEventRoom),"OnEnteringEventCombat")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Method(typeof(NEventRoom),"OnEnteringEventCombat").CreateDelegate<Action>`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NEventRoom),"RefreshEventState")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Method(typeof(NEventRoom),"RefreshEventState").CreateDelegate<Action<EventModel>>`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`dialogue.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: dialogue.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.EventModel.AfterEventStarted()`；输入表达式：`dialogue.AfterEventStarted()`；返回值紧邻使用处：`AwaitExpressionSyntax: await dialogue.AfterEventStarted()`
- `MegaCrit.Sts2.Core.Models.EventModel.OnRoomEnter()`；输入表达式：`dialogue.OnRoomEnter()`；返回值紧邻使用处：`ExpressionStatementSyntax: dialogue.OnRoomEnter();`
- `MegaCrit.Sts2.Core.Models.EventModel.SetNode(Godot.Control)`；输入表达式：`dialogue.SetNode(layout)`；返回值紧邻使用处：`ExpressionStatementSyntax: dialogue.SetNode(layout);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.AwaitPendingOptionTasks()`；输入表达式：`sync.AwaitPendingOptionTasks()`；返回值紧邻使用处：`AwaitExpressionSyntax: await sync.AwaitPendingOptionTasks()`
- `MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.BeginEvent(MegaCrit.Sts2.Core.Models.EventModel, bool, System.Action<MegaCrit.Sts2.Core.Models.EventModel>?)`；输入表达式：`sync.BeginEvent(room.CanonicalEvent,room.IsPreFinished,StartArchitectPage.OnStart(room))`；返回值紧邻使用处：`ExpressionStatementSyntax: sync.BeginEvent(room.CanonicalEvent,room.IsPreFinished,StartArchitectPage.OnStart(room));`
- `MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.GetLocalEvent()`；输入表达式：`sync.GetLocalEvent()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sync.GetLocalEvent()`
- `MegaCrit.Sts2.Core.Nodes.Events.NEventLayout.SetTitle(string)`；输入表达式：`layout.SetTitle(dialogue.Title.GetFormattedText())`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.SetTitle(dialogue.Title.GetFormattedText());`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`manager.DebugOnlyGetState()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: manager.DebugOnlyGetState()?.CurrentRoom`
- `MegaCrit.Sts2.Core.Runs.RunManager.EnterRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom)`；输入表达式：`manager.EnterRoom(room)`；返回值紧邻使用处：`AwaitExpressionSyntax: await manager.EnterRoom(room)`
- `NationalSpire.FinalChoiceEvent.FinishPage()`；输入表达式：`page.FinishPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: page.FinishPage();`
- `object.GetType()`；输入表达式：`combat.GetType()`；返回值紧邻使用处：`ArgumentSyntax: combat.GetType()`
- `System.Action<T>.Invoke(T)`；输入表达式：`refresh(dialogue)`；返回值紧邻使用处：`ExpressionStatementSyntax: refresh(dialogue);`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`sync.Events.OfType<FinalChoiceEvent>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var page in sync.Events.OfType<FinalChoiceEvent>())page.FinishPage();`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`StartArchitectPage.OnStart(room)`；返回值紧邻使用处：`ArgumentSyntax: StartArchitectPage.OnStart(room)`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(sync)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(EventSynchronizer).GetField("_combatSynchronizer",BindingFlags.NonPublic|BindingFlags.Instance)?.GetValue(sync)`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`field.GetValue(choice)`；返回值紧邻使用处：`ArgumentSyntax: field.GetValue(choice)`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`AccessTools.Field(combat.GetType(),"_canonicalEvent").SetValue(combat,room.CanonicalEvent)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Field(combat.GetType(),"_canonicalEvent").SetValue(combat,room.CanonicalEvent);`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`AccessTools.Field(typeof(NEventLayout),"_event").SetValue(layout,dialogue)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Field(typeof(NEventLayout),"_event").SetValue(layout,dialogue);`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`AccessTools.Field(typeof(NEventRoom),"_event").SetValue(view,dialogue)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Field(typeof(NEventRoom),"_event").SetValue(view,dialogue);`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`field.SetValue(choice,null)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.SetValue(choice,null);`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`field.SetValue(dialogue,field.GetValue(choice))`；返回值紧邻使用处：`ExpressionStatementSyntax: field.SetValue(dialogue,field.GetValue(choice));`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`AccessTools.Method(typeof(NEventRoom),"OnEnteringEventCombat").CreateDelegate<Action>(view)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Method(typeof(NEventRoom),"OnEnteringEventCombat").CreateDelegate<Action>(view)`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`AccessTools.Method(typeof(NEventRoom),"RefreshEventState").CreateDelegate<Action<EventModel>>(view)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Method(typeof(NEventRoom),"RefreshEventState").CreateDelegate<Action<EventModel>>(view)`
- `System.Type.GetField(string, System.Reflection.BindingFlags)`；输入表达式：`typeof(EventSynchronizer).GetField("_combatSynchronizer",BindingFlags.NonPublic|BindingFlags.Instance)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(EventSynchronizer).GetField("_combatSynchronizer",BindingFlags.NonPublic|BindingFlags.Instance)?.GetValue(sync)`

**赋值（含属性/字段和局部值）：**

- `choice.EnteringEventCombat` -= `entering`
- `choice.StateChanged` -= `refresh`
- `Destination` = `null`
- `dialogue.EnteringEventCombat` += `entering`
- `dialogue.StateChanged` += `refresh`
- `Returning` = `false`
- `Returning` = `true`

<a id="symbol-ce5c0a0367d6"></a>

## `NationalSpire.StartArchitectPage.Prefix(ref MegaCrit.Sts2.Core.Models.EventModel, ref System.Action<MegaCrit.Sts2.Core.Models.EventModel>?) — static void Prefix(ref EventModel canonicalEvent,ref Action<EventModel>? debugOnStart)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Event<T>()`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Destination`；`NationalSpire.ArchitectFinal.Returning`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Event<T>()`；输入表达式：`ModelDb.Event<FinalChoiceEvent>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: canonicalEvent=ModelDb.Event<FinalChoiceEvent>()`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RunManager.Instance.DebugOnlyGetState()?.CurrentRoom`

**赋值（含属性/字段和局部值）：**

- `canonicalEvent` = `ModelDb.Event<FinalChoiceEvent>()`
- `debugOnStart` = `null`

<a id="symbol-41f1996b8ea9"></a>

## `NationalSpire.FinalChoiceEvent.FinishPage() — internal void FinishPage()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ArchitectFinal.Continue()`](ArchitectFinal.cs.md#symbol-42cc1c0a9ec8)

**调用：** `MegaCrit.Sts2.Core.Models.EventModel.SetEventFinished(MegaCrit.Sts2.Core.Localization.LocString)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.EventModel.SetEventFinished(MegaCrit.Sts2.Core.Localization.LocString)`；输入表达式：`SetEventFinished(InitialDescription)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>SetEventFinished(InitialDescription)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-89a5dd686ea9"></a>

## `NationalSpire.FinalChoiceEvent.IsShared — public override bool IsShared`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-30474b4233bb"></a>

## `NationalSpire.FinalChoiceEvent.AfterEventStarted() — public override async Task AfterEventStarted()`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Models.EventModel.AfterEventStarted()`；`MegaCrit.Sts2.Core.Saves.SaveManager.SaveRun(MegaCrit.Sts2.Core.Rooms.AbstractRoom?, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Destination`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.EventModel.AfterEventStarted()`；输入表达式：`base.AfterEventStarted()`；返回值紧邻使用处：`AwaitExpressionSyntax: await base.AfterEventStarted()`
- `MegaCrit.Sts2.Core.Saves.SaveManager.SaveRun(MegaCrit.Sts2.Core.Rooms.AbstractRoom?, bool)`；输入表达式：`SaveManager.Instance.SaveRun(room,false)`；返回值紧邻使用处：`AwaitExpressionSyntax: await SaveManager.Instance.SaveRun(room,false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-32500db91b1c"></a>

## `NationalSpire.FinalChoiceEvent.LayoutType — public override EventLayoutType LayoutType`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2b975d0e07e3"></a>

## `NationalSpire.FinalChoiceEvent.CanonicalEncounter — public override EncounterModel CanonicalEncounter`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()`；输入表达式：`ModelDb.Encounter<TheArchitectEventEncounter>()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>ModelDb.Encounter<TheArchitectEventEncounter>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f58ddea45ef0"></a>

## `NationalSpire.FinalChoiceEvent.GenerateInitialOptions() — protected override IReadOnlyList<EventOption> GenerateInitialOptions()`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Choice(string, bool)`](ArchitectFinal.cs.md#symbol-f35424e52f43)；[`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`](ArchitectFinal.cs.md#symbol-3956d0a87e48)；`MegaCrit.Sts2.Core.Localization.LocManager.GetTable(string)`；`MegaCrit.Sts2.Core.Localization.LocTable.MergeWith(System.Collections.Generic.Dictionary<string, string>)`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** `Choice(string, bool)`；`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.LeagueSolverLink.Supported`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choice(string, bool)`；输入表达式：`Choice("fight",true)`；返回值紧邻使用处：`ExpressionElementSyntax: Choice("fight",true)`
- `Choice(string, bool)`；输入表达式：`Choice("time",false)`；返回值紧邻使用处：`ExpressionElementSyntax: Choice("time",false)`
- `MegaCrit.Sts2.Core.Localization.LocManager.GetTable(string)`；输入表达式：`LocManager.Instance.GetTable(LocTable)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LocManager.Instance.GetTable(LocTable).MergeWith`
- `MegaCrit.Sts2.Core.Localization.LocTable.MergeWith(System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`LocManager.Instance.GetTable(LocTable).MergeWith(new(){             [key+".title"]="最终决战",[key+".pages.INITIAL.description"]=ranked?"双方都已通关。可以按通关用时判定比赛，也可以在建筑师面前决出胜负。":"对手没有通关。本场比赛按原有规则结算，你仍可与对手进行一场对战。",             [key+".result.win"]="建筑师对决获胜",[key+".result.loss"]="建筑师对决失利",             [key+".time.title"]=ranked?"按通关用时判定":"继续建筑师对话",[key+".time.description"]=ranked?"较快的一方获胜，随后继续建筑师对话。":"保留本场成绩，继续建筑师对话。",             [key+".fight.title"]=!LeagueSolverLink.Supported?"当前游戏版本不支持建筑师对决":ranked?"与对手决战":"与对手进行表演赛",[key+".fight.description"]=!LeagueSolverLink.Supported?"请选择上方选项，继续本局建筑师对话。":ranked?"通关较快的一队先手。此战决定比赛胜负，双方的冒险都已通关。":"对手没有通关。仍然进行对战，但不会影响比赛结果。"})`；返回值紧邻使用处：`ExpressionStatementSyntax: LocManager.Instance.GetTable(LocTable).MergeWith(new(){             [key+".title"]="最终决战",[key+".pages.INITIAL.description"]=ranked?"双方都已通关。可以按通关用时判定比赛，也可以在建筑师面前决出胜负。":"对手没有通关。本场比赛按原有规则结算，你仍可与对手进行一场对战。",             [key+".result.win"]="建筑师对决获胜",[key+".result.loss"]="建筑师对决失利",             [key+".time.title"]=ranked?"按通关用时判定":"继续建筑师对话",[key+".time.description"]=ranked?"较快的一方获胜，随后继续建筑师对话。":"保留本场成绩，继续建筑师对话。",             [key+".fight.title"]=!LeagueSolverLink.Supported?"当前游戏版本不支持建筑师对决":ranked?"与对手决战":"与对手进行表演赛",[key+".fight.description"]=!LeagueSolverLink.Supported?"请选择上方选项，继续本局建筑师对话。":ranked?"通关较快的一队先手。此战决定比赛胜负，双方的冒险都已通关。":"对手没有通关。仍然进行对战，但不会影响比赛结果。"});`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState()!`
- `NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`ArchitectFinal.Match(RunManager.Instance.DebugOnlyGetState()!)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ArchitectFinal.Match(RunManager.Instance.DebugOnlyGetState()!)!`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new(){             [key+".title"]="最终决战",[key+".pages.INITIAL.description"]=ranked?"双方都已通关。可以按通关用时判定比赛，也可以在建筑师面前决出胜负。":"对手没有通关。本场比赛按原有规则结算，你仍可与对手进行一场对战。",             [key+".result.win"]="建筑师对决获胜",[key+".result.loss"]="建筑师对决失利",             [key+".time.title"]=ranked?"按通关用时判定":"继续建筑师对话",[key+".time.description"]=ranked?"较快的一方获胜，随后继续建筑师对话。":"保留本场成绩，继续建筑师对话。",             [key+".fight.title"]=!LeagueSolverLink.Supported?"当前游戏版本不支持建筑师对决":ranked?"与对手决战":"与对手进行表演赛",[key+".fight.description"]=!LeagueSolverLink.Supported?"请选择上方选项，继续本局建筑师对话。":ranked?"通关较快的一队先手。此战决定比赛胜负，双方的冒险都已通关。":"对手没有通关。仍然进行对战，但不会影响比赛结果。"}`；返回值紧邻使用处：`ArgumentSyntax: new(){             [key+".title"]="最终决战",[key+".pages.INITIAL.description"]=ranked?"双方都已通关。可以按通关用时判定比赛，也可以在建筑师面前决出胜负。":"对手没有通关。本场比赛按原有规则结算，你仍可与对手进行一场对战。",             [key+".result.win"]="建筑师对决获胜",[key+".result.loss"]="建筑师对决失利",             [key+".time.title"]=ranked?"按通关用时判定":"继续建筑师对话",[key+".time.description"]=ranked?"较快的一方获胜，随后继续建筑师对话。":"保留本场成绩，继续建筑师对话。",             [key+".fight.title"]=!LeagueSolverLink.Supported?"当前游戏版本不支持建筑师对决":ranked?"与对手决战":"与对手进行表演赛",[key+".fight.description"]=!LeagueSolverLink.Supported?"请选择上方选项，继续本局建筑师对话。":ranked?"通关较快的一队先手。此战决定比赛胜负，双方的冒险都已通关。":"对手没有通关。仍然进行对战，但不会影响比赛结果。"}`

**赋值（含属性/字段和局部值）：**

- `[key+".fight.description"]` = `!LeagueSolverLink.Supported?"请选择上方选项，继续本局建筑师对话。":ranked?"通关较快的一队先手。此战决定比赛胜负，双方的冒险都已通关。":"对手没有通关。仍然进行对战，但不会影响比赛结果。"`
- `[key+".fight.title"]` = `!LeagueSolverLink.Supported?"当前游戏版本不支持建筑师对决":ranked?"与对手决战":"与对手进行表演赛"`
- `[key+".pages.INITIAL.description"]` = `ranked?"双方都已通关。可以按通关用时判定比赛，也可以在建筑师面前决出胜负。":"对手没有通关。本场比赛按原有规则结算，你仍可与对手进行一场对战。"`
- `[key+".result.loss"]` = `"建筑师对决失利"`
- `[key+".result.win"]` = `"建筑师对决获胜"`
- `[key+".time.description"]` = `ranked?"较快的一方获胜，随后继续建筑师对话。":"保留本场成绩，继续建筑师对话。"`
- `[key+".time.title"]` = `ranked?"按通关用时判定":"继续建筑师对话"`
- `[key+".title"]` = `"最终决战"`

<a id="symbol-f35424e52f43"></a>

## `Choice(string, bool) — EventOption Choice(string id,bool fight)`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.FinalChoiceEvent.GenerateInitialOptions()`](ArchitectFinal.cs.md#symbol-f58ddea45ef0)

**调用：** [`NationalSpire.ArchitectFinal.Continue()`](ArchitectFinal.cs.md#symbol-42cc1c0a9ec8)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`MegaCrit.Sts2.Core.Context.LocalContext.IsMe(MegaCrit.Sts2.Core.Entities.Players.Player?)`；`MegaCrit.Sts2.Core.Events.EventOption.EventOption(MegaCrit.Sts2.Core.Models.EventModel, System.Func<System.Threading.Tasks.Task>?, MegaCrit.Sts2.Core.Localization.LocString, MegaCrit.Sts2.Core.Localization.LocString, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip>)`；`MegaCrit.Sts2.Core.Events.EventOption.ThatWontSaveToChoiceHistory()`；`MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(System.Threading.Tasks.Task)`；`MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Continue()`；`NationalSpire.LeagueNativeMatch.StartFinal()`；`NationalSpire.LeagueSolverLink.Supported`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred`
- `MegaCrit.Sts2.Core.Context.LocalContext.IsMe(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner)`；返回值紧邻使用处：`IfStatementSyntax: if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner))                 Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();`
- `MegaCrit.Sts2.Core.Events.EventOption.EventOption(MegaCrit.Sts2.Core.Models.EventModel, System.Func<System.Threading.Tasks.Task>?, MegaCrit.Sts2.Core.Localization.LocString, MegaCrit.Sts2.Core.Localization.LocString, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip>)`；输入表达式：`new EventOption(this,fight&&!LeagueSolverLink.Supported?null:()=>{             if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner))                 Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();             return Task.CompletedTask;         },new LocString(LocTable,key+"."+id+".title"),new LocString(LocTable,key+"."+id+".description"),id,[])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new EventOption(this,fight&&!LeagueSolverLink.Supported?null:()=>{             if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner))                 Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();             return Task.CompletedTask;         },new LocString(LocTable,key+"."+id+".title"),new LocString(LocTable,key+"."+id+".description"),id,[]).ThatWontSaveToChoiceHistory`
- `MegaCrit.Sts2.Core.Events.EventOption.ThatWontSaveToChoiceHistory()`；输入表达式：`new EventOption(this,fight&&!LeagueSolverLink.Supported?null:()=>{             if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner))                 Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();             return Task.CompletedTask;         },new LocString(LocTable,key+"."+id+".title"),new LocString(LocTable,key+"."+id+".description"),id,[]).ThatWontSaveToChoiceHistory()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>new EventOption(this,fight&&!LeagueSolverLink.Supported?null:()=>{             if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner))                 Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();             return Task.CompletedTask;         },new LocString(LocTable,key+"."+id+".title"),new LocString(LocTable,key+"."+id+".description"),id,[]).ThatWontSaveToChoiceHistory()`
- `MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(System.Threading.Tasks.Task)`；输入表达式：`MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue())`
- `MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；输入表达式：`new LocString(LocTable,key+"."+id+".description")`；返回值紧邻使用处：`ArgumentSyntax: new LocString(LocTable,key+"."+id+".description")`
- `MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；输入表达式：`new LocString(LocTable,key+"."+id+".title")`；返回值紧邻使用处：`ArgumentSyntax: new LocString(LocTable,key+"."+id+".title")`
- `NationalSpire.ArchitectFinal.Continue()`；输入表达式：`ArchitectFinal.Continue()`；返回值紧邻使用处：`ConditionalExpressionSyntax: fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue()`
- `NationalSpire.LeagueNativeMatch.StartFinal()`；输入表达式：`LeagueNativeMatch.StartFinal()`；返回值紧邻使用处：`ConditionalExpressionSyntax: fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue()`

**赋值（含属性/字段和局部值）：**

- `_` = `MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue())`

<a id="symbol-0fc450ced28c"></a>

## `NationalSpire.LeagueNativeMatch.Fighters — internal static IEnumerable<LeagueDuel> Fighters`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Team`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-943fdb98d018"></a>

## `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?) — internal static LeagueDuel? For(Creature? c)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.ArrowOwner(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref System.Threading.Tasks.Task)`](LeagueNativeMatch.cs.md#symbol-3daab8f54d5d)；[`NationalSpire.LeagueNativeMatch.DuelBlockScaling(MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref decimal)`](LeagueEffectTargets.cs.md#symbol-197d5e8af68f)；[`NationalSpire.LeagueNativeMatch.EffectEnemies(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.AbstractModel)`](LeagueEffectTargets.cs.md#symbol-1504862aee7d)；[`NationalSpire.LeagueNativeMatch.FighterDisplayName(MegaCrit.Sts2.Core.Platform.PlatformType, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-bcf1bbec184b)；[`NationalSpire.LeagueNativeMatch.FighterForHooks(MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AbstractModel>)`](LeagueEffectTargets.cs.md#symbol-a8e0498a1bba)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；[`NationalSpire.LeagueNativeMatch.GenerateForTarget<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`](LeagueEffectTargets.cs.md#symbol-07799f66fb88)；[`NationalSpire.LeagueNativeMatch.LeaguePlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueNativeMatch.cs.md#symbol-130a97fef955)；[`NationalSpire.LeagueNativeMatch.MelodySide(MegaCrit.Sts2.Core.Models.PowerModel, ref MegaCrit.Sts2.Core.Combat.CombatSide)`](LeagueNativeMatch.cs.md#symbol-d5f6c0324093)；[`NationalSpire.LeagueNativeMatch.PreparePowerOwner(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-a0a1c444bf34)；[`NationalSpire.LeagueNativeMatch.ShowTeamIntent(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`](LeagueNativeMatch.cs.md#symbol-50df0eb4b7be)；[`NationalSpire.LeagueNativeMatch.StunFighter(MegaCrit.Sts2.Core.Entities.Creatures.Creature, ref System.Threading.Tasks.Task)`](LeagueNativeMatch.cs.md#symbol-1084f38840f0)；[`NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](ArchitectFinal.cs.md#symbol-bf4f2e6056f3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dfa68774ae32"></a>

## `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?) — internal static LeagueDuel? For(Player? p)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)；[`NationalSpire.LeagueNativeMatch.AutoAllies(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.CardModel)`](LeagueEffectTargets.cs.md#symbol-cf54dad36cc2)；[`NationalSpire.LeagueNativeMatch.CardOpponents(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.CardModel)`](LeagueEffectTargets.cs.md#symbol-e03fa69528cb)；[`NationalSpire.LeagueNativeMatch.DuelBlockScaling(MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref decimal)`](LeagueEffectTargets.cs.md#symbol-197d5e8af68f)；[`NationalSpire.LeagueNativeMatch.DuelPet(MegaCrit.Sts2.Core.Entities.Creatures.Creature, ref bool)`](LeagueEffectTargets.cs.md#symbol-5a8f63229113)；[`NationalSpire.LeagueNativeMatch.EffectEnemies(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.AbstractModel)`](LeagueEffectTargets.cs.md#symbol-1504862aee7d)；[`NationalSpire.LeagueNativeMatch.EffectsEnded(MegaCrit.Sts2.Core.Combat.CombatManager, MegaCrit.Sts2.Core.Entities.Players.Player)`](LeagueBattleVisuals.cs.md#symbol-421e23a3b0e9)；[`NationalSpire.LeagueNativeMatch.EndExtraPlay(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, ref System.Threading.Tasks.Task)`](LeagueBattleVisuals.cs.md#symbol-9f371d65a62b)；[`NationalSpire.LeagueNativeMatch.PetAdded(MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueBattleVisuals.cs.md#symbol-4b556b6aac88)；[`NationalSpire.LeagueNativeMatch.PetGrew(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`](LeagueBattleVisuals.cs.md#symbol-3dd73d89fb14)；[`NationalSpire.LeagueNativeMatch.PrepareAutoPlay(MegaCrit.Sts2.Core.Models.CardModel, ref MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref bool)`](LeagueEffectTargets.cs.md#symbol-a955401df3dc)；[`NationalSpire.LeagueNativeMatch.RevealBeforePlay(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Entities.Cards.CardPlay, NationalSpire.LeagueDuel)`](LeagueBattleVisuals.cs.md#symbol-c3a8ead47ec7)；[`NationalSpire.LeagueNativeMatch.ShowPlayedCard(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, ref System.Threading.Tasks.Task)`](LeagueBattleVisuals.cs.md#symbol-21d742c9c5dc)；[`NationalSpire.LeagueNativeMatch.SummonerTeam(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`](LeagueEffectTargets.cs.md#symbol-dca4c0c18a8f)；[`NationalSpire.LeagueNativeMatch.TeamPlayers(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.OrbModel)`](LeagueEffectTargets.cs.md#symbol-ebd81f72bada)；[`NationalSpire.LeagueOpponent.AfterPlayerTurnStartEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Players.Player)`](LeagueNativeMatch.cs.md#symbol-611d7429d107)；[`NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int)`](LeagueSolverLink.cs.md#symbol-09cdebc60677)

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(p.Creature)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(p.Creature) is {} fighter`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cc520ed0d782"></a>

## `NationalSpire.LeagueNativeMatch.FirstLiving — internal static MonsterModel? FirstLiving`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Fighters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Fighters.FirstOrDefault(f=>f.Rival.Creature.IsAlive)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Fighters.FirstOrDefault(f=>f.Rival.Creature.IsAlive)?.Rival.Creature.Monster`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d8650169559f"></a>

## `NationalSpire.LeagueNativeMatch.HumanLead — internal static ulong HumanLead`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Players.FirstOrDefault(p=>p.Creature.IsAlive)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Players.FirstOrDefault(p=>p.Creature.IsAlive)?.NetId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf4f2e6056f3"></a>

## `NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static string TargetName(Creature c)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.ShowTeamIntent(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`](LeagueNativeMatch.cs.md#symbol-50df0eb4b7be)

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.LeagueDuel.OpponentName`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(c)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: For(c)?.OpponentName`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Members.FirstOrDefault(m=>m.SteamId==c.Player?.NetId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Members.FirstOrDefault(m=>m.SteamId==c.Player?.NetId)?.Name`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9cee1b48fd83"></a>

## `NationalSpire.LeagueNativeMatch.Opponents() — internal static IReadOnlyList<(MonsterModel,string?)> Opponents()`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueEncounter.GenerateMonsters()`](LeagueNativeMatch.cs.md#symbol-a892fa6c9367)

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；`MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Team`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<LeagueOpponent>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.Monster<LeagueOpponent>().ToMutable`
- `MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；输入表达式：`ModelDb.Monster<LeagueOpponent>().ToMutable()`；返回值紧邻使用处：`ArgumentSyntax: ModelDb.Monster<LeagueOpponent>().ToMutable()`
- `MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；输入表达式：`ModelDb.Monster<LeagueOpponent>().ToMutable()`；返回值紧邻使用处：`CastExpressionSyntax: (LeagueOpponent)ModelDb.Monster<LeagueOpponent>().ToMutable()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Team.Select(f=>{var m=(LeagueOpponent)ModelDb.Monster<LeagueOpponent>().ToMutable();m.Fighter=f;return ((MonsterModel)m,(string?)null);})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Team.Select(f=>{var m=(LeagueOpponent)ModelDb.Monster<LeagueOpponent>().ToMutable();m.Fighter=f;return ((MonsterModel)m,(string?)null);}).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Team.Select(f=>{var m=(LeagueOpponent)ModelDb.Monster<LeagueOpponent>().ToMutable();m.Fighter=f;return ((MonsterModel)m,(string?)null);}).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return Team.Select(f=>{var m=(LeagueOpponent)ModelDb.Monster<LeagueOpponent>().ToMutable();m.Fighter=f;return ((MonsterModel)m,(string?)null);}).ToList();`

**赋值（含属性/字段和局部值）：**

- `m.Fighter` = `f`

<a id="symbol-656f28d1e5ef"></a>

## `NationalSpire.LeagueNativeMatch.PlanHost — internal static bool PlanHost`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.LeagueNativeMatch._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-09629ccb5931"></a>

## `NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>) — internal static async Task<List<int>> SharePlan(List<int> actions)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.PlayTurn()`](LeagueDuel.cs.md#symbol-e8cbe8f2353a)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.ReserveChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.SyncLocalChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.WaitForRemoteChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint)`；`MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.AsIndexes()`；`MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(System.Collections.Generic.List<int>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.PlanHost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.ReserveChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sync.ReserveChoiceId(host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sync.ReserveChoiceId(host)`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.SyncLocalChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult)`；输入表达式：`sync.SyncLocalChoice(host,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(actions))`；返回值紧邻使用处：`ExpressionStatementSyntax: sync.SyncLocalChoice(host,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(actions));`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.WaitForRemoteChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint)`；输入表达式：`sync.WaitForRemoteChoice(host,id)`；返回值紧邻使用处：`AwaitExpressionSyntax: await sync.WaitForRemoteChoice(host,id)`
- `MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.AsIndexes()`；输入表达式：`(await sync.WaitForRemoteChoice(host,id)).AsIndexes()`；返回值紧邻使用处：`ReturnStatementSyntax: return (await sync.WaitForRemoteChoice(host,id)).AsIndexes();`
- `MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(System.Collections.Generic.List<int>)`；输入表达式：`MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(actions)`；返回值紧邻使用处：`ArgumentSyntax: MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(actions)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`_run.Players.Single(p=>p.NetId==CoopRuntime.Current!.Session!.World!.Owner)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_run.Players.Single(p=>p.NetId==CoopRuntime.Current!.Session!.World!.Owner)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d13397092776"></a>

## `NationalSpire.LeagueNativeMatch.Adventure.MusicProxy — private static Node? MusicProxy`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`.GetNodeOrNull<Node>("Proxy")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance?.GetNodeOrNull<Node>("Proxy")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e763da8483c1"></a>

## `NationalSpire.LeagueNativeMatch.Adventure.PlayingTrack(Godot.Node?) — private static string? PlayingTrack(Node? proxy)`

来源：源码第 166 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Adventure.RestoreMusic()`](ArchitectFinal.cs.md#symbol-3e499134d996)

**调用：** `Godot.GodotObject.Get(Godot.StringName)`；`Godot.Variant.AsGodotObject()`；`Godot.Variant.AsString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Get(Godot.StringName)`；输入表达式：`proxy.Get("_currentTrack")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: proxy.Get("_currentTrack").AsString`
- `Godot.GodotObject.Get(Godot.StringName)`；输入表达式：`proxy.Get("_musicEv")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: proxy.Get("_musicEv").AsGodotObject`
- `Godot.Variant.AsGodotObject()`；输入表达式：`proxy.Get("_musicEv").AsGodotObject()`；返回值紧邻使用处：`BinaryExpressionSyntax: proxy.Get("_musicEv").AsGodotObject()==null`
- `Godot.Variant.AsString()`；输入表达式：`proxy.Get("_currentTrack").AsString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: proxy.Get("_musicEv").AsGodotObject()==null?"":proxy.Get("_currentTrack").AsString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3e499134d996"></a>

## `NationalSpire.LeagueNativeMatch.Adventure.RestoreMusic() — internal void RestoreMusic()`

来源：源码第 169 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)

**调用：** [`NationalSpire.LeagueNativeMatch.Adventure.PlayingTrack(Godot.Node?)`](ArchitectFinal.cs.md#symbol-e763da8483c1)；`Godot.GodotObject.Call(Godot.StringName, params Godot.Variant[])`；`MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.PlayCustomMusic(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Adventure.entryTrack`；`NationalSpire.LeagueNativeMatch.Adventure.MusicProxy`；`NationalSpire.LeagueNativeMatch.Adventure.PlayingTrack(Godot.Node?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Call(Godot.StringName, params Godot.Variant[])`；输入表达式：`proxy.Call("stop_music")`；返回值紧邻使用处：`ExpressionStatementSyntax: proxy.Call("stop_music");`
- `MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.PlayCustomMusic(string)`；输入表达式：`MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance!.PlayCustomMusic(entryTrack)`；返回值紧邻使用处：`ExpressionStatementSyntax: MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance!.PlayCustomMusic(entryTrack);`
- `NationalSpire.LeagueNativeMatch.Adventure.PlayingTrack(Godot.Node?)`；输入表达式：`PlayingTrack(proxy)`；返回值紧邻使用处：`BinaryExpressionSyntax: PlayingTrack(proxy)==entryTrack`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0baba77b0229"></a>

## `NationalSpire.LeagueNativeMatch.Adventure.Begin() — internal void Begin()`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；`MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry.MapPointRoomHistoryEntry()`；`MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry.PlayerMapPointHistoryEntry()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Adventure.floor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；输入表达式：`p.Creature.SetCurrentHpInternal(hp+100)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.Creature.SetCurrentHpInternal(hp+100);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；输入表达式：`p.Creature.SetMaxHpInternal(p.Creature.MaxHp+100)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.Creature.SetMaxHpInternal(p.Creature.MaxHp+100);`
- `MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry.MapPointRoomHistoryEntry()`；输入表达式：`new(){RoomType=RoomType.Monster}`；返回值紧邻使用处：`ExpressionElementSyntax: new(){RoomType=RoomType.Monster}`
- `MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry.PlayerMapPointHistoryEntry()`；输入表达式：`new PlayerMapPointHistoryEntry{PlayerId=p.NetId}`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId}`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`run.Players.Select(p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: run.Players.Select(p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId}).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`run.Players.Select(p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId}).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: floor.PlayerStats=run.Players.Select(p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId}).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`run.Players.Where(p=>p.Creature.IsAlive)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var p in run.Players.Where(p=>p.Creature.IsAlive)){int hp=p.Creature.CurrentHp;p.Creature.SetMaxHpInternal(p.Creature.MaxHp+100);p.Creature.SetCurrentHpInternal(hp+100);}`

**赋值（含属性/字段和局部值）：**

- `floor.PlayerStats` = `run.Players.Select(p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId}).ToList()`
- `floor.Rooms` = `[new(){RoomType=RoomType.Monster}]`
- `PlayerId` = `p.NetId`
- `RoomType` = `RoomType.Monster`
- `RunManager.Instance.CombatReplayWriter.IsEnabled` = `false`

<a id="symbol-ec43de6aedd4"></a>

## `NationalSpire.LeagueNativeMatch.Adventure.Restore() — internal void Restore()`

来源：源码第 186 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；[`NationalSpire.LeagueNativeMatch.OnAdventureExit()`](ArchitectFinal.cs.md#symbol-86926a42c207)

**调用：** `MegaCrit.Sts2.Core.Entities.Players.Player.SyncWithSerializedPlayer(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer)`；`MegaCrit.Sts2.Core.Runs.RunRngSet.LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Adventure.floor`；`NationalSpire.LeagueNativeMatch.Adventure.players`；`NationalSpire.LeagueNativeMatch.Adventure.replay`；`NationalSpire.LeagueNativeMatch.Adventure.rng`；`NationalSpire.LeagueNativeMatch.Adventure.rooms`；`NationalSpire.LeagueNativeMatch.Adventure.stats`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Players.Player.SyncWithSerializedPlayer(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer)`；输入表达式：`run.Players.Single(x=>x.NetId==p.NetId).SyncWithSerializedPlayer(p)`；返回值紧邻使用处：`ExpressionStatementSyntax: run.Players.Single(x=>x.NetId==p.NetId).SyncWithSerializedPlayer(p);`
- `MegaCrit.Sts2.Core.Runs.RunRngSet.LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet)`；输入表达式：`run.Rng.LoadFromSerializable(rng)`；返回值紧邻使用处：`ExpressionStatementSyntax: run.Rng.LoadFromSerializable(rng);`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`run.Players.Single(x=>x.NetId==p.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: run.Players.Single(x=>x.NetId==p.NetId).SyncWithSerializedPlayer`

**赋值（含属性/字段和局部值）：**

- `floor.PlayerStats` = `stats!`
- `floor.Rooms` = `rooms!`
- `RunManager.Instance.CombatReplayWriter.IsEnabled` = `replay`

<a id="symbol-41111cc49b99"></a>

## `NationalSpire.LeagueNativeMatch.InFinal — internal static bool InFinal`

来源：源码第 194 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._adventure`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bdca44c3d251"></a>

## `NationalSpire.LeagueNativeMatch.StartFinal() — internal static async Task StartFinal()`

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choice(string, bool)`](ArchitectFinal.cs.md#symbol-f35424e52f43)

**调用：** [`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`](ArchitectFinal.cs.md#symbol-3956d0a87e48)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameCharacterNames.StartingHp(string)`](GameCharacterNames.cs.md#symbol-1bb238743407)；[`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)；[`NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?)`](LeagueDuel.cs.md#symbol-83cd52462f7a)；[`NationalSpire.LeagueEncounter.ForFinal(MegaCrit.Sts2.Core.Runs.RunState)`](LeagueNativeMatch.cs.md#symbol-3e81b2d050ae)；[`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`NationalSpire.LeagueLadder.RivalOpens(int)`](LeagueLadder.cs.md#symbol-3b4c257e5975)；[`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`](LeagueLadder.cs.md#symbol-1b55dcf28341)；[`NationalSpire.LeagueNativeMatch.Adventure.Begin()`](ArchitectFinal.cs.md#symbol-0baba77b0229)；[`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；[`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)；[`NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>)`](ArchitectFinal.cs.md#symbol-09629ccb5931)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)；[`NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`](MatchRules.cs.md#symbol-08f53c7e29ff)；[`NationalSpire.NpcCharacters.Index(string)`](NpcCharacters.cs.md#symbol-8f7f43f17d89)；[`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`](LiveMatch.cs.md#symbol-d351643744da)；[`NationalSpire.RivalSimulation.Route(System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, NationalSpire.CareerPerson, string)`](LiveMatch.cs.md#symbol-6158dbb0d19d)；`MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Entities.Players.Player.InitializeSeed(string)`；`MegaCrit.Sts2.Core.Rooms.CombatRoom.CombatRoom(MegaCrit.Sts2.Core.Models.EncounterModel, MegaCrit.Sts2.Core.Runs.IRunState?)`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`MegaCrit.Sts2.Core.Runs.RunManager.EnterRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom)`；`NationalSpire.LeagueNativeMatch.Adventure.Adventure(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Random.Next()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Arrival`；`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerStore.Data`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRun.RivalMembers`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameCharacterNames.StartingHp(string)`；`NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`；`NationalSpire.LeagueCards.OriginalRoles`；`NationalSpire.LeagueDuel.OpeningHp`；`NationalSpire.LeagueDuel.OpeningMax`；`NationalSpire.LeagueDuel.PersonId`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueDuel.SetupCards`；`NationalSpire.LeagueEncounter.ForFinal(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`；`NationalSpire.LeagueLadder.RivalOpens(int)`；`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`；`NationalSpire.LeagueNativeMatch._adventure`；`NationalSpire.LeagueNativeMatch._opener`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Adventure.Begin()`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`；`NationalSpire.LeagueNativeMatch.Install()`；`NationalSpire.LeagueNativeMatch.OnAdventureExit()`；`NationalSpire.LeagueNativeMatch.PlayerTurn(MegaCrit.Sts2.Core.Combat.CombatState)`；`NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>)`；`NationalSpire.LeagueNativeMatch.Team`；`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`；`NationalSpire.NpcCharacters.Index(string)`；`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；`NationalSpire.RivalSimulation.Route(System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, NationalSpire.CareerPerson, string)`；`NationalSpire.RivalStep.HpAfter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`；输入表达式：`MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList())`；返回值紧邻使用处：`AwaitExpressionSyntax: await MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList())`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(role,run.Players[0].UnlockState,netId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Player.CreateForNewRun(role,run.Players[0].UnlockState,netId)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.InitializeSeed(string)`；输入表达式：`bot.InitializeSeed(seed+":"+id)`；返回值紧邻使用处：`ExpressionStatementSyntax: bot.InitializeSeed(seed+":"+id);`
- `MegaCrit.Sts2.Core.Rooms.CombatRoom.CombatRoom(MegaCrit.Sts2.Core.Models.EncounterModel, MegaCrit.Sts2.Core.Runs.IRunState?)`；输入表达式：`new CombatRoom(encounter,run)`；返回值紧邻使用处：`ArgumentSyntax: new CombatRoom(encounter,run)`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`mgr.DebugOnlyGetState()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: mgr.DebugOnlyGetState()!`
- `MegaCrit.Sts2.Core.Runs.RunManager.EnterRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom)`；输入表达式：`mgr.EnterRoom(new CombatRoom(encounter,run))`；返回值紧邻使用处：`AwaitExpressionSyntax: await mgr.EnterRoom(new CombatRoom(encounter,run))`
- `NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`ArchitectFinal.Match(run)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ArchitectFinal.Match(run)!`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data,id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data,id)!`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data,ids[0])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data,ids[0])!`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(match.Seed+":final:"+id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(match.Seed+":final:"+id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(match.Seed+":final")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.StableHash(match.Seed+":final")`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("league-match",e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("league-match",e);`
- `NationalSpire.GameCharacterNames.StartingHp(string)`；输入表达式：`GameCharacterNames.StartingHp(npc.Character)`；返回值紧邻使用处：`ArgumentSyntax: GameCharacterNames.StartingHp(npc.Character)`
- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`LeagueArchetypes.Resolve(role.Id.Entry,npc.Style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueArchetypes.Resolve(role.Id.Entry,npc.Style)`
- `NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?)`；输入表达式：`new(bot,deck,rng.Next(),npc.PublicName,tier,LeagueLadder.Upgrades(deck,plan,tier,rng,true),pending){PersonId=id,OpeningMax=live.MaxHp+100,OpeningHp=live.Steps[^1].HpAfter+100,SetupCards=plan.Anchors}`；返回值紧邻使用处：`ArgumentSyntax: new(bot,deck,rng.Next(),npc.PublicName,tier,LeagueLadder.Upgrades(deck,plan,tier,rng,true),pending){PersonId=id,OpeningMax=live.MaxHp+100,OpeningHp=live.Steps[^1].HpAfter+100,SetupCards=plan.Anchors}`
- `NationalSpire.LeagueEncounter.ForFinal(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`LeagueEncounter.ForFinal(run)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueEncounter.ForFinal(run)`
- `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`；输入表达式：`LeagueLadder.BuildFor(role,rng,tier,npc.Style,true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueLadder.BuildFor(role,rng,tier,npc.Style,true).ToArray`
- `NationalSpire.LeagueLadder.RivalOpens(int)`；输入表达式：`LeagueLadder.RivalOpens(seed)`；返回值紧邻使用处：`BinaryExpressionSyntax: time==0&&LeagueLadder.RivalOpens(seed)`
- `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`；输入表达式：`LeagueLadder.Upgrades(deck,plan,tier,rng,true)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Upgrades(deck,plan,tier,rng,true)`
- `NationalSpire.LeagueNativeMatch.Adventure.Adventure(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`new(run)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _adventure=new(run)`
- `NationalSpire.LeagueNativeMatch.Adventure.Begin()`；输入表达式：`_adventure.Begin()`；返回值紧邻使用处：`ExpressionStatementSyntax: _adventure.Begin();`
- `NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`；输入表达式：`FinishFinal(null)`；返回值紧邻使用处：`AwaitExpressionSyntax: await FinishFinal(null)`
- `NationalSpire.LeagueNativeMatch.Install()`；输入表达式：`Install()`；返回值紧邻使用处：`ExpressionStatementSyntax: Install();`
- `NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>)`；输入表达式：`SharePlan([_opener?1:0,..Team.SelectMany(f=>new[]{f.OpeningHp!.Value,f.OpeningMax})])`；返回值紧邻使用处：`AwaitExpressionSyntax: await SharePlan([_opener?1:0,..Team.SelectMany(f=>new[]{f.OpeningHp!.Value,f.OpeningMax})])`
- `NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`；输入表达式：`LiveMaps.Read(run,match,world!=null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LiveMaps.Read(run,match,world!=null)`
- `NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`；输入表达式：`MatchRules.Compare(new(true,0,ArchitectFinal.Arrival),new(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds!.Value))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =MatchRules.Compare(new(true,0,ArchitectFinal.Arrival),new(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds!.Value))`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(npc.Character)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(npc.Character)`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(r.Id.Entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(npc.Character)`
- `NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；输入表达式：`RivalSimulation.Create(match,npc,route,GameCharacterNames.StartingHp(npc.Character))`；返回值紧邻使用处：`AssignmentExpressionSyntax: live=RivalSimulation.Create(match,npc,route,GameCharacterNames.StartingHp(npc.Character))`
- `NationalSpire.RivalSimulation.Route(System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, NationalSpire.CareerPerson, string)`；输入表达式：`RivalSimulation.Route(nodes,world==null?npc:CareerEngine.Person(data,ids[0])!,match.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RivalSimulation.Route(nodes,world==null?npc:CareerEngine.Person(data,ids[0])!,match.Seed)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds!.Value)`；返回值紧邻使用处：`ArgumentSyntax: new(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds!.Value)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(true,0,ArchitectFinal.Arrival)`；返回值紧邻使用处：`ArgumentSyntax: new(true,0,ArchitectFinal.Arrival)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`run.Players.Any(p=>p.NetId==netId)`；返回值紧邻使用处：`BinaryExpressionSyntax: run.Players.Any(p=>p.NetId==netId)||Team.Any(f=>f.Rival.NetId==netId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Team.Any(f=>f.Rival.NetId==netId)`；返回值紧邻使用处：`BinaryExpressionSyntax: run.Players.Any(p=>p.NetId==netId)||Team.Any(f=>f.Rival.NetId==netId)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`run.Players.Select(p=>p.Character)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: run.Players.Select(p=>p.Character).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Team.Select(f=>f.Rival.Character)`；返回值紧邻使用处：`ArgumentSyntax: Team.Select(f=>f.Rival.Character)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Team.SelectMany(f=>new[]{f.OpeningHp!.Value,f.OpeningMax})`；返回值紧邻使用处：`SpreadElementSyntax: ..Team.SelectMany(f=>new[]{f.OpeningHp!.Value,f.OpeningMax})`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.OriginalRoles.Single(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(npc.Character))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.OriginalRoles.Single(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(npc.Character))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList()`；返回值紧邻使用处：`ArgumentSyntax: run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.RivalMembers.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Run?.RivalMembers.GetValueOrDefault(id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Team.Add(new(bot,deck,rng.Next(),npc.PublicName,tier,LeagueLadder.Upgrades(deck,plan,tier,rng,true),pending){PersonId=id,OpeningMax=live.MaxHp+100,OpeningHp=live.Steps[^1].HpAfter+100,SetupCards=plan.Anchors})`；返回值紧邻使用处：`ExpressionStatementSyntax: Team.Add(new(bot,deck,rng.Next(),npc.PublicName,tier,LeagueLadder.Upgrades(deck,plan,tier,rng,true),pending){PersonId=id,OpeningMax=live.MaxHp+100,OpeningHp=live.Steps[^1].HpAfter+100,SetupCards=plan.Anchors});`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<LeagueDuel.Hit>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<LeagueDuel.Hit>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`LeagueLadder.BuildFor(role,rng,tier,npc.Style,true).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueLadder.BuildFor(role,rng,tier,npc.Style,true).ToArray()`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`ArgumentSyntax: rng.Next()`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(match.Seed+":final:"+id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Random(CareerEngine.StableHash(match.Seed+":final:"+id))`

**赋值（含属性/字段和局部值）：**

- `_adventure` = `new(run)`
- `_opener` = `opening[0]==1`
- `_opener` = `time<0||time==0&&LeagueLadder.RivalOpens(seed)`
- `_returning` = `false`
- `_run` = `run`
- `bot.RunState` = `run`
- `CombatManager.Instance.TurnStarted` += `PlayerTurn`
- `Current` = `Team[0]`
- `live` = `RivalSimulation.Create(match,npc,route,GameCharacterNames.StartingHp(npc.Character))`
- `OpeningHp` = `live.Steps[^1].HpAfter+100`
- `OpeningMax` = `live.MaxHp+100`
- `PersonId` = `id`
- `scene.TreeExiting` += `OnAdventureExit`
- `SetupCards` = `plan.Anchors`
- `Team[i].OpeningHp` = `opening[1+2*i]`
- `Team[i].OpeningMax` = `opening[2+2*i]`

<a id="symbol-86926a42c207"></a>

## `NationalSpire.LeagueNativeMatch.OnAdventureExit() — private static void OnAdventureExit()`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.Adventure.Restore()`](ArchitectFinal.cs.md#symbol-ec43de6aedd4)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Destination`；`NationalSpire.ArchitectFinal.Returning`；`NationalSpire.LeagueNativeMatch._adventure`；`NationalSpire.LeagueNativeMatch.Adventure.Restore()`；`NationalSpire.LeagueNativeMatch.Release()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.Adventure.Restore()`；输入表达式：`_adventure.Restore()`；返回值紧邻使用处：`ExpressionStatementSyntax: _adventure.Restore();`
- `NationalSpire.LeagueNativeMatch.Release()`；输入表达式：`Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: Release();`

**赋值（含属性/字段和局部值）：**

- `_adventure` = `null`
- `ArchitectFinal.Destination` = `null`
- `ArchitectFinal.Returning` = `false`

<a id="symbol-012638fdea11"></a>

## `NationalSpire.LeagueNativeMatch.OwnsFinal(MegaCrit.Sts2.Core.Combat.CombatState) — internal static bool OwnsFinal(CombatState state)`

来源：源码第 233 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`](ArchitectFinal.cs.md#symbol-5e275c755b3b)

**调用：** `object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._adventure`；`NationalSpire.LeagueNativeMatch._room`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_room?.CombatState,state)`；返回值紧邻使用处：`BinaryExpressionSyntax: _adventure!=null&&ReferenceEquals(_room?.CombatState,state)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eaba38f606ba"></a>

## `NationalSpire.LeagueNativeMatch.AwaitFinalProceed(bool) — internal static void AwaitFinalProceed(bool won)`

来源：源码第 234 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`](ArchitectFinal.cs.md#symbol-5e275c755b3b)

**调用：** [`Proceed()`](ArchitectFinal.cs.md#symbol-5945f5272a84)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Show()`；`MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(System.Threading.Tasks.Task)`；`MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi.Deactivate()`；`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl.Disable()`；`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl.Enable()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._adventure`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch.Adventure.Outcome`；`Proceed()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{             if(_adventure!=adventure||_returning)return;             var view=NCombatRoom.Instance!;             view.Ui.Deactivate();             var arrow=view.ProceedButton;             arrow.Released+=button=>{                 if(!arrow.IsEnabled)return;                 arrow.Disable();                 _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed());             };             arrow.Show();arrow.Enable();         }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{             if(_adventure!=adventure||_returning)return;             var view=NCombatRoom.Instance!;             view.Ui.Deactivate();             var arrow=view.ProceedButton;             arrow.Released+=button=>{                 if(!arrow.IsEnabled)return;                 arrow.Disable();                 _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed());             };             arrow.Show();arrow.Enable();         }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{             if(_adventure!=adventure||_returning)return;             var view=NCombatRoom.Instance!;             view.Ui.Deactivate();             var arrow=view.ProceedButton;             arrow.Released+=button=>{                 if(!arrow.IsEnabled)return;                 arrow.Disable();                 _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed());             };             arrow.Show();arrow.Enable();         })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{             if(_adventure!=adventure||_returning)return;             var view=NCombatRoom.Instance!;             view.Ui.Deactivate();             var arrow=view.ProceedButton;             arrow.Released+=button=>{                 if(!arrow.IsEnabled)return;                 arrow.Disable();                 _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed());             };             arrow.Show();arrow.Enable();         }).CallDeferred`
- `Godot.CanvasItem.Show()`；输入表达式：`arrow.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: arrow.Show();`
- `MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(System.Threading.Tasks.Task)`；输入表达式：`MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed())`
- `MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi.Deactivate()`；输入表达式：`view.Ui.Deactivate()`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Ui.Deactivate();`
- `MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl.Disable()`；输入表达式：`arrow.Disable()`；返回值紧邻使用处：`ExpressionStatementSyntax: arrow.Disable();`
- `MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl.Enable()`；输入表达式：`arrow.Enable()`；返回值紧邻使用处：`ExpressionStatementSyntax: arrow.Enable();`
- `Proceed()`；输入表达式：`Proceed()`；返回值紧邻使用处：`ArgumentSyntax: Proceed()`

**赋值（含属性/字段和局部值）：**

- `_` = `MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed())`
- `adventure.Outcome` = `won`
- `arrow.Released` += `button=>{                 if(!arrow.IsEnabled)return;                 arrow.Disable();                 _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed());             }`

<a id="symbol-5945f5272a84"></a>

## `Proceed() — async Task Proceed()`

来源：源码第 250 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.AwaitFinalProceed(bool)`](ArchitectFinal.cs.md#symbol-eaba38f606ba)

**调用：** [`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；`MegaCrit.Sts2.Core.Context.LocalContext.IsMe(MegaCrit.Sts2.Core.Entities.Players.Player?)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.ReserveChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.SyncLocalChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.WaitForRemoteChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint)`；`MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(System.Collections.Generic.List<int>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._adventure`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Context.LocalContext.IsMe(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`MegaCrit.Sts2.Core.Context.LocalContext.IsMe(player)`；返回值紧邻使用处：`IfStatementSyntax: if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(player))                         sync.SyncLocalChoice(player,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes([]));                     else ready.Add(sync.WaitForRemoteChoice(player,id));`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.ReserveChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`sync.ReserveChoiceId(player)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =sync.ReserveChoiceId(player)`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.SyncLocalChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult)`；输入表达式：`sync.SyncLocalChoice(player,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes([]))`；返回值紧邻使用处：`ExpressionStatementSyntax: sync.SyncLocalChoice(player,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes([]));`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer.WaitForRemoteChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint)`；输入表达式：`sync.WaitForRemoteChoice(player,id)`；返回值紧邻使用处：`ArgumentSyntax: sync.WaitForRemoteChoice(player,id)`
- `MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(System.Collections.Generic.List<int>)`；输入表达式：`MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes([])`；返回值紧邻使用处：`ArgumentSyntax: MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes([])`
- `NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`；输入表达式：`FinishFinal(won)`；返回值紧邻使用处：`AwaitExpressionSyntax: await FinishFinal(won)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`ready.Add(sync.WaitForRemoteChoice(player,id))`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.Add(sync.WaitForRemoteChoice(player,id));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Task>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Task>()`
- `System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>)`；输入表达式：`Task.WhenAll(ready)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.WhenAll(ready)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb8d4b32d343"></a>

## `NationalSpire.LeagueNativeMatch.FinishFinal(bool?) — internal static async Task FinishFinal(bool? won)`

来源：源码第 266 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；[`Proceed()`](ArchitectFinal.cs.md#symbol-5945f5272a84)

**调用：** [`NationalSpire.ArchitectFinal.Continue()`](ArchitectFinal.cs.md#symbol-42cc1c0a9ec8)；[`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`](ArchitectFinal.cs.md#symbol-3956d0a87e48)；[`NationalSpire.ArchitectFinal.Record(MegaCrit.Sts2.Core.Runs.RunState, bool, NationalSpire.DuelReport?)`](ArchitectFinal.cs.md#symbol-28d314792588)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.DuelRecorder.Finish(bool)`](DuelRecorder.cs.md#symbol-2f331da503dd)；[`NationalSpire.LeagueNativeMatch.Adventure.Restore()`](ArchitectFinal.cs.md#symbol-ec43de6aedd4)；[`NationalSpire.LeagueNativeMatch.Adventure.RestoreMusic()`](ArchitectFinal.cs.md#symbol-3e499134d996)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`MegaCrit.Sts2.Core.Entities.Players.Player.AfterCombatEnd()`；`MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.UpdateTrack()`；`object.ReferenceEquals(object?, object?)`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectFinal.Continue()`；`NationalSpire.ArchitectFinal.Destination`；`NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.ArchitectFinal.Record(MegaCrit.Sts2.Core.Runs.RunState, bool, NationalSpire.DuelReport?)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerStore.Data`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.DuelRecorder.Finish(bool)`；`NationalSpire.DuelReport.Note`；`NationalSpire.LeagueNativeMatch._adventure`；`NationalSpire.LeagueNativeMatch._report`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Adventure.Restore()`；`NationalSpire.LeagueNativeMatch.Adventure.RestoreMusic()`；`NationalSpire.LeagueNativeMatch.OnAdventureExit()`；`NationalSpire.LeagueNativeMatch.Release()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb),"OnCombatEnded")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb),"OnCombatEnded")?.Invoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb.Instance,[_room])`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RunManager),"ExitCurrentRoom")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Method(typeof(RunManager),"ExitCurrentRoom").Invoke`
- `MegaCrit.Sts2.Core.Entities.Players.Player.AfterCombatEnd()`；输入表达式：`player.AfterCombatEnd()`；返回值紧邻使用处：`ExpressionStatementSyntax: player.AfterCombatEnd();`
- `MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.UpdateTrack()`；输入表达式：`.UpdateTrack()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance?.UpdateTrack()`
- `NationalSpire.ArchitectFinal.Continue()`；输入表达式：`ArchitectFinal.Continue()`；返回值紧邻使用处：`AwaitExpressionSyntax: await ArchitectFinal.Continue()`
- `NationalSpire.ArchitectFinal.Match(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`ArchitectFinal.Match(run)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ArchitectFinal.Match(run) is {OpponentWon:false} match`
- `NationalSpire.ArchitectFinal.Record(MegaCrit.Sts2.Core.Runs.RunState, bool, NationalSpire.DuelReport?)`；输入表达式：`ArchitectFinal.Record(run,won.Value,report)`；返回值紧邻使用处：`ExpressionStatementSyntax: ArchitectFinal.Record(run,won.Value,report);`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(Coop.CoopRuntime.Current?.Session?.World?.World??CareerStore.Data,match.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "因为"+CareerEngine.DisplayName(Coop.CoopRuntime.Current?.Session?.World?.World??CareerStore.Data,match.OpponentId)`
- `NationalSpire.DuelRecorder.Finish(bool)`；输入表达式：`.Finish(victory)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _report?.Finish(victory)`
- `NationalSpire.LeagueNativeMatch.Adventure.Restore()`；输入表达式：`.Restore()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: adventure?.Restore()`
- `NationalSpire.LeagueNativeMatch.Adventure.RestoreMusic()`；输入表达式：`.RestoreMusic()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: adventure?.RestoreMusic()`
- `NationalSpire.LeagueNativeMatch.Release()`；输入表达式：`Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: Release();`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(run.CurrentRoom,destination)`；返回值紧邻使用处：`BinaryExpressionSyntax: ArchitectFinal.Destination is {} destination&&ReferenceEquals(run.CurrentRoom,destination)`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`.Invoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb.Instance,[_room])`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb),"OnCombatEnded")?.Invoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb.Instance,[_room])`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`AccessTools.Method(typeof(RunManager),"ExitCurrentRoom").Invoke(RunManager.Instance,null)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: AccessTools.Method(typeof(RunManager),"ExitCurrentRoom").Invoke(RunManager.Instance,null)!`

**赋值（含属性/字段和局部值）：**

- `_adventure` = `null`
- `_returning` = `true`
- `report.Note` = `"因为"+CareerEngine.DisplayName(Coop.CoopRuntime.Current?.Session?.World?.World??CareerStore.Data,match.OpponentId)+"没有通关，所以最后对决为表演赛，不影响比赛结果。"`
- `scene.TreeExiting` -= `OnAdventureExit`

<a id="symbol-e1677896058b"></a>

## `NationalSpire.FinalEndHooks.Install(HarmonyLib.Harmony) — internal static void Install(Harmony harmony)`

来源：源码第 289 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)

**调用：** `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Reflection.MethodBase.GetParameters()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.FinalEndHooks.StopLoop`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(kill)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(kill)`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(CombatManager),"_turnState")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Field(typeof(CombatManager),"_turnState")`
- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(CombatManager))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(typeof(CombatManager)).Where`
- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(CreatureCmd))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where`
- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(SaveManager))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(typeof(SaveManager)).Single`
- `HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；输入表达式：`AccessTools.PropertySetter(state?.FieldType??typeof(CombatManager),"IsInProgress")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertySetter(state?.FieldType??typeof(CombatManager),"IsInProgress")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.AsyncMoveNext(kill),transpiler:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepAdventure)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.AsyncMoveNext(kill),transpiler:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepAdventure)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(AccessTools.GetDeclaredMethods(typeof(SaveManager)).Single(m=>m.Name=="SaveRun"&&m.GetParameters()[0].ParameterType==typeof(AbstractRoom)),prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepCheckpoint)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(AccessTools.GetDeclaredMethods(typeof(SaveManager)).Single(m=>m.Name=="SaveRun"&&m.GetParameters()[0].ParameterType==typeof(AbstractRoom)),prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepCheckpoint)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`harmony.Patch(m,prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(Check)))`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.Patch(m,prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(Check)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(FinalEndHooks),nameof(Check))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(Check))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepAdventure))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepAdventure))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepCheckpoint))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepCheckpoint))`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>)).OrderByDescending(m=>m.GetParameters().Length).First()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>)).OrderByDescending(m=>m.GetParameters().Length).First()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>)).OrderByDescending(m=>m.GetParameters().Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>)).OrderByDescending(m=>m.GetParameters().Length).First`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(SaveManager)).Single(m=>m.Name=="SaveRun"&&m.GetParameters()[0].ParameterType==typeof(AbstractRoom))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.GetDeclaredMethods(typeof(SaveManager)).Single(m=>m.Name=="SaveRun"&&m.GetParameters()[0].ParameterType==typeof(AbstractRoom))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(CombatManager)).Where(m=>m.Name=="CheckWinCondition")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var m in AccessTools.GetDeclaredMethods(typeof(CombatManager)).Where(m=>m.Name=="CheckWinCondition"))             harmony.Patch(m,prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(Check)));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>)).OrderByDescending`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`state.GetValue(manager)`；返回值紧邻使用处：`ConditionalExpressionSyntax: state==null?manager:state.GetValue(manager)`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: m.GetParameters()[0]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`flag.Invoke(state==null?manager:state.GetValue(manager),[false])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: manager=>flag.Invoke(state==null?manager:state.GetValue(manager),[false])`

**赋值（含属性/字段和局部值）：**

- `StopLoop` = `manager=>flag.Invoke(state==null?manager:state.GetValue(manager),[false])`

<a id="symbol-633404b06faa"></a>

## `NationalSpire.FinalEndHooks.KeepCheckpoint(ref System.Threading.Tasks.Task) — static bool KeepCheckpoint(ref Task __result)`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.InFinal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__result` = `Task.CompletedTask`

<a id="symbol-45c020867c72"></a>

## `NationalSpire.FinalEndHooks.Check(MegaCrit.Sts2.Core.Combat.CombatManager, ref System.Threading.Tasks.Task<bool>) — static bool Check(CombatManager __instance,ref Task<bool> __result)`

来源：源码第 301 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.EndTeam(bool)`](LeagueTeamMatch.cs.md#symbol-20c50965f995)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(System.Threading.Tasks.Task)`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.FinalEndHooks.StopLoop`；`NationalSpire.LeagueNativeMatch.EndTeam(bool)`；`NationalSpire.LeagueNativeMatch.IsTeamMatch`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won));}).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won));}).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won));})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won));}).CallDeferred`
- `MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(System.Threading.Tasks.Task)`；输入表达式：`MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won))`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState()!`
- `NationalSpire.LeagueNativeMatch.EndTeam(bool)`；输入表达式：`LeagueNativeMatch.EndTeam(won)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNativeMatch.EndTeam(won)`
- `System.Action<T>.Invoke(T)`；输入表达式：`StopLoop(__instance)`；返回值紧邻使用处：`ExpressionStatementSyntax: StopLoop(__instance);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`RunManager.Instance.DebugOnlyGetState()!.Players.Any(p=>p.Creature.IsAlive)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RunManager.Instance.DebugOnlyGetState()!.Players.Any(p=>p.Creature.IsAlive)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult(true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult(true)`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult(true)`
- `_` = `MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won))`

<a id="symbol-bc421b59cb3b"></a>

## `NationalSpire.FinalEndHooks.KeepAdventure(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — static IEnumerable<CodeInstruction> KeepAdventure(IEnumerable<CodeInstruction> code)`

来源：源码第 308 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(CombatManager),"LoseCombat")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(CombatManager),"LoseCombat")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(FinalEndHooks),nameof(EndAdventure))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(FinalEndHooks),nameof(EndAdventure))`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`i.Calls(AccessTools.Method(typeof(CombatManager),"LoseCombat"))`；返回值紧邻使用处：`IfStatementSyntax: if(i.Calls(AccessTools.Method(typeof(CombatManager),"LoseCombat")))loss=true;`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(FinalEndHooks),nameof(EndAdventure)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(FinalEndHooks),nameof(EndAdventure)));`

**赋值（含属性/字段和局部值）：**

- `loss` = `false`
- `loss` = `true`

<a id="symbol-7880456fdce3"></a>

## `NationalSpire.FinalEndHooks.EndAdventure(bool) — static bool EndAdventure(bool original)`

来源：源码第 318 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.InFinal`；`NationalSpire.LeagueNativeMatch.IsTeamMatch`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-918f6aed8cae"></a>

## `NationalSpire.ArchitectCombatOutcome.Prepare() — static bool Prepare()`

来源：源码第 324 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink.Supported`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e9845c449599"></a>

## `NationalSpire.ArchitectCombatOutcome.TargetMethod() — static MethodBase TargetMethod()`

来源：源码第 326 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectCombatOutcome.Turn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CombatManager),"EndCombatInternal",[Turn!])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>AccessTools.DeclaredMethod(typeof(CombatManager),"EndCombatInternal",[Turn!])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5e275c755b3b"></a>

## `NationalSpire.ArchitectCombatOutcome.Handle(object, bool) — internal static bool Handle(object turn,bool won)`

来源：源码第 327 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ArchitectCombatLoss.Prefix(object)`](ArchitectFinal.cs.md#symbol-b41d55325ed2)；[`NationalSpire.ArchitectCombatOutcome.Prefix(object, ref System.Threading.Tasks.Task)`](ArchitectFinal.cs.md#symbol-b2ba2aa82e81)

**调用：** [`NationalSpire.LeagueNativeMatch.AwaitFinalProceed(bool)`](ArchitectFinal.cs.md#symbol-eaba38f606ba)；[`NationalSpire.LeagueNativeMatch.OwnsFinal(MegaCrit.Sts2.Core.Combat.CombatState)`](ArchitectFinal.cs.md#symbol-012638fdea11)；`HarmonyLib.AccessTools.Property(System.Type, string)`；`System.Reflection.PropertyInfo.GetValue(object?)`；`System.Reflection.PropertyInfo.SetValue(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectCombatOutcome.Turn`；`NationalSpire.LeagueNativeMatch.AwaitFinalProceed(bool)`；`NationalSpire.LeagueNativeMatch.InFinal`；`NationalSpire.LeagueNativeMatch.OwnsFinal(MegaCrit.Sts2.Core.Combat.CombatState)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Property(System.Type, string)`；输入表达式：`AccessTools.Property(Turn,"IsInProgress")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Property(Turn,"IsInProgress").SetValue`
- `HarmonyLib.AccessTools.Property(System.Type, string)`；输入表达式：`AccessTools.Property(Turn,"PendingLoss")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Property(Turn,"PendingLoss").SetValue`
- `HarmonyLib.AccessTools.Property(System.Type, string)`；输入表达式：`AccessTools.Property(Turn,"State")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Property(Turn,"State").GetValue`
- `NationalSpire.LeagueNativeMatch.AwaitFinalProceed(bool)`；输入表达式：`LeagueNativeMatch.AwaitFinalProceed(won)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueNativeMatch.AwaitFinalProceed(won);`
- `NationalSpire.LeagueNativeMatch.OwnsFinal(MegaCrit.Sts2.Core.Combat.CombatState)`；输入表达式：`LeagueNativeMatch.OwnsFinal((CombatState)AccessTools.Property(Turn,"State").GetValue(turn)!)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueNativeMatch.OwnsFinal((CombatState)AccessTools.Property(Turn,"State").GetValue(turn)!)`
- `System.Reflection.PropertyInfo.GetValue(object?)`；输入表达式：`AccessTools.Property(Turn,"State").GetValue(turn)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: AccessTools.Property(Turn,"State").GetValue(turn)!`
- `System.Reflection.PropertyInfo.SetValue(object?, object?)`；输入表达式：`AccessTools.Property(Turn,"IsInProgress").SetValue(turn,false)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Property(Turn,"IsInProgress").SetValue(turn,false);`
- `System.Reflection.PropertyInfo.SetValue(object?, object?)`；输入表达式：`AccessTools.Property(Turn,"PendingLoss").SetValue(turn,null)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Property(Turn,"PendingLoss").SetValue(turn,null);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b2ba2aa82e81"></a>

## `NationalSpire.ArchitectCombatOutcome.Prefix(object, ref System.Threading.Tasks.Task) — static bool Prefix(object __0,ref Task __result)`

来源：源码第 333 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`](ArchitectFinal.cs.md#symbol-5e275c755b3b)

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`；输入表达式：`Handle(__0,true)`；返回值紧邻使用处：`IfStatementSyntax: if(Handle(__0,true))return true;`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.CompletedTask`

<a id="symbol-36173614524c"></a>

## `NationalSpire.ArchitectCombatLoss.Prepare() — static bool Prepare()`

来源：源码第 340 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink.Supported`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0982aec37169"></a>

## `NationalSpire.ArchitectCombatLoss.TargetMethod() — static MethodBase TargetMethod()`

来源：源码第 341 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectCombatOutcome.Turn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CombatManager),"ProcessPendingLoss",[ArchitectCombatOutcome.Turn!])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>AccessTools.DeclaredMethod(typeof(CombatManager),"ProcessPendingLoss",[ArchitectCombatOutcome.Turn!])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b41d55325ed2"></a>

## `NationalSpire.ArchitectCombatLoss.Prefix(object) — static bool Prefix(object __0)`

来源：源码第 342 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`](ArchitectFinal.cs.md#symbol-5e275c755b3b)

**字段、属性、事件及方法组引用：** `NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ArchitectCombatOutcome.Handle(object, bool)`；输入表达式：`ArchitectCombatOutcome.Handle(__0,false)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>ArchitectCombatOutcome.Handle(__0,false)`

**赋值（含属性/字段和局部值）：**
