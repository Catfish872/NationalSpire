# UiPerformance.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5935BB133969BCCBBBAD3D6F68909B7FD4B266DE7C1947BDF45FC925B62AB9BB`。来源：[源码](../../UiPerformance.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.UiPerformance`、`NationalSpire.UiPerformance.Work`、`NationalSpire.UiPerformance.Cost`、`NationalSpire.UiPerformance.SlowOperation`、`NationalSpire.UiPerformance.Scope`。

字段、事件及初始值（源码原样）：

```csharp
internal static event Action<Work, double, long>? Measured;
public long Calls, Ticks, Bytes, Maximum;
public long Over50;
private static readonly Cost[] Costs = Enumerable.Range(0, (int)Work.Count).Select(_ => new Cost()).ToArray();
private static readonly object Gate = new();
private static readonly string[] Pages = ["首页", "日程", "赛事", "赛事与俱乐部", "结算", "社区", "选手档案", "模组设置", "生涯生活", "通讯", "其他"];
private static readonly Cost[] PageFrames = Pages.Select(_ => new Cost()).ToArray();
private static readonly SlowOperation?[] Recent = new SlowOperation?[32];
private static int _next;
private readonly Work _work;
private readonly string? _page;
private readonly long _time, _bytes;
```

<a id="symbol-d4add07631bd"></a>

## `NationalSpire.UiPerformance.Scope.Scope(NationalSpire.UiPerformance.Work, string?) — public Scope(Work work, string? page)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)

**调用：** `System.Diagnostics.Stopwatch.GetTimestamp()`；`System.GC.GetAllocatedBytesForCurrentThread()`

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance.Scope._bytes`；`NationalSpire.UiPerformance.Scope._page`；`NationalSpire.UiPerformance.Scope._time`；`NationalSpire.UiPerformance.Scope._work`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _time = Stopwatch.GetTimestamp()`
- `System.GC.GetAllocatedBytesForCurrentThread()`；输入表达式：`GC.GetAllocatedBytesForCurrentThread()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _bytes = GC.GetAllocatedBytesForCurrentThread()`

**赋值（含属性/字段和局部值）：**

- `_bytes` = `GC.GetAllocatedBytesForCurrentThread()`
- `_page` = `page`
- `_time` = `Stopwatch.GetTimestamp()`
- `_work` = `work`

<a id="symbol-a737ce8fdbf5"></a>

## `NationalSpire.UiPerformance.Scope.Dispose() — public void Dispose()`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long)`](UiPerformance.cs.md#symbol-f0c911ecc2ea)；`NationalSpire.UiPerformance.SlowOperation.SlowOperation(System.DateTime, string, double, long)`；`System.Diagnostics.Stopwatch.GetTimestamp()`；`System.GC.GetAllocatedBytesForCurrentThread()`

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance._next`；`NationalSpire.UiPerformance.Gate`；`NationalSpire.UiPerformance.Recent`；`NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long)`；`NationalSpire.UiPerformance.Scope._bytes`；`NationalSpire.UiPerformance.Scope._page`；`NationalSpire.UiPerformance.Scope._time`；`NationalSpire.UiPerformance.Scope._work`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long)`；输入表达式：`Record(_work, ticks, bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(_work, ticks, bytes);`
- `NationalSpire.UiPerformance.SlowOperation.SlowOperation(System.DateTime, string, double, long)`；输入表达式：`new(DateTime.UtcNow, _page, ticks * 1000.0 / Stopwatch.Frequency, bytes)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Recent[_next] = new(DateTime.UtcNow, _page, ticks * 1000.0 / Stopwatch.Frequency, bytes)`
- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`BinaryExpressionSyntax: Stopwatch.GetTimestamp() - _time`
- `System.GC.GetAllocatedBytesForCurrentThread()`；输入表达式：`GC.GetAllocatedBytesForCurrentThread()`；返回值紧邻使用处：`BinaryExpressionSyntax: GC.GetAllocatedBytesForCurrentThread() - _bytes`

**赋值（含属性/字段和局部值）：**

- `_next` = `(_next + 1) % Recent.Length`
- `Recent[_next]` = `new(DateTime.UtcNow, _page, ticks * 1000.0 / Stopwatch.Frequency, bytes)`

<a id="symbol-fb8ca8555fbe"></a>

## `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?) — public static Scope Measure(Work work, string? page = null)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-c5235b150918)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`](CharacterIdentity.cs.md#symbol-6c3ca5d0abad)；[`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`](CharacterIdentity.cs.md#symbol-4d068357a08b)；[`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-5c9e3196ce58)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?)`](CommunityMemorySearch.cs.md#symbol-43d223752125)；[`NationalSpire.CommunityPromptContext.SelectReplies(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int, System.Collections.Generic.IEnumerable<string>, string, NationalSpire.CommunityMemorySearch.Request, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?)`](CommunityPromptContext.cs.md#symbol-20bcf5974618)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)；[`NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`](Coop/CoopWire.cs.md#symbol-8c8a54666033)；[`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`](Coop/CoopWire.cs.md#symbol-d89dceccb833)；[`NationalSpire.Coop.CoopCoordinator.Broadcast()`](Coop/CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopCoordinator.PumpReceived()`](Coop/CoopReception.cs.md#symbol-a09fec904cc1)；[`NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong)`](Coop/CoopReception.cs.md#symbol-a9de6eef033e)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`](Coop/CoopPrivateMessages.cs.md#symbol-f433d36af14b)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](Coop/CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](Coop/CoopStorage.cs.md#symbol-a4c240447248)；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；[`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](EconomicActions.cs.md#symbol-f0516c3ecf95)；[`NationalSpire.GameCharacterNames.Definitions(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`](GameCharacterNames.cs.md#symbol-2ba1db314dbc)；[`NationalSpire.GameCharacterNames.Originals()`](GameCharacterNames.cs.md#symbol-1e5c21407883)；[`NationalSpire.GameCharacterNames.Read(string)`](GameCharacterNames.cs.md#symbol-cf770f36edc2)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.LiveRunBridge.PlanningMap()`](LiveRunBridge.cs.md#symbol-733c41e89044)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)；[`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int, string)`](NationalDevelopment.cs.md#symbol-c1f2a8832691)；[`NationalSpire.PlayerSimulation.Sample(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<NationalSpire.CareerResult>?, int?, double?)`](PlayerSimulation.cs.md#symbol-bf5a9912f02b)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivatePublicContext.SelectCommunity(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-434624537026)；[`Refresh()`](ConsumerPickerScreen.cs.md#symbol-8376c45db5bc)；[`Refresh()`](PeoplePickerScreen.cs.md#symbol-dd4db64669ab)；[`ShowRows()`](PeoplePickerScreen.cs.md#symbol-0dac44c0ee6b)；[`Step()`](Coop/CoopReception.cs.md#symbol-41b14a0db411)

**调用：** [`NationalSpire.UiPerformance.Scope.Scope(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-d4add07631bd)

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.UiPerformance.Scope.Scope(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`new(work, page)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(work, page)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f0c911ecc2ea"></a>

## `NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long) — private static void Record(Work work, long ticks, long bytes)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.UiPerformance.Frame(ref long, string)`](UiPerformance.cs.md#symbol-aef0950310da)；[`NationalSpire.UiPerformance.Scope.Dispose()`](UiPerformance.cs.md#symbol-a737ce8fdbf5)

**调用：** `System.Action<T1, T2, T3>.Invoke(T1, T2, T3)`（委托实际目标见流程文档）；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance.Cost.Bytes`；`NationalSpire.UiPerformance.Cost.Calls`；`NationalSpire.UiPerformance.Cost.Maximum`；`NationalSpire.UiPerformance.Cost.Over50`；`NationalSpire.UiPerformance.Cost.Ticks`；`NationalSpire.UiPerformance.Costs`；`NationalSpire.UiPerformance.Gate`；`NationalSpire.UiPerformance.Measured`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action<T1, T2, T3>.Invoke(T1, T2, T3)`；输入表达式：`.Invoke(work, ticks * 1000.0 / Stopwatch.Frequency, bytes)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Measured?.Invoke(work, ticks * 1000.0 / Stopwatch.Frequency, bytes)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(c.Maximum, ticks)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.Maximum = Math.Max(c.Maximum, ticks)`

**赋值（含属性/字段和局部值）：**

- `c.Bytes` += `bytes`
- `c.Maximum` = `Math.Max(c.Maximum, ticks)`
- `c.Ticks` += `ticks`

<a id="symbol-aef0950310da"></a>

## `NationalSpire.UiPerformance.Frame(ref long, string) — public static void Frame(ref long previous, string page)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)

**调用：** [`NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long)`](UiPerformance.cs.md#symbol-f0c911ecc2ea)；`System.Array.IndexOf<T>(T[], T)`；`System.Diagnostics.Stopwatch.GetTimestamp()`；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance.Cost.Calls`；`NationalSpire.UiPerformance.Cost.Maximum`；`NationalSpire.UiPerformance.Cost.Over50`；`NationalSpire.UiPerformance.Cost.Ticks`；`NationalSpire.UiPerformance.Gate`；`NationalSpire.UiPerformance.PageFrames`；`NationalSpire.UiPerformance.Pages`；`NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long)`；`NationalSpire.UiPerformance.Work.Frame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.UiPerformance.Record(NationalSpire.UiPerformance.Work, long, long)`；输入表达式：`Record(Work.Frame, ticks, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(Work.Frame, ticks, 0);`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(Pages, page)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.IndexOf(Pages, page)`
- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Stopwatch.GetTimestamp()`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(c.Maximum,ticks)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.Maximum = Math.Max(c.Maximum,ticks)`

**赋值（含属性/字段和局部值）：**

- `c.Maximum` = `Math.Max(c.Maximum,ticks)`
- `c.Ticks` += `ticks`
- `index` = `Pages.Length - 1`
- `previous` = `now`

<a id="symbol-962540a1e803"></a>

## `NationalSpire.UiPerformance.Snapshot() — public static object Snapshot()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.CapturePeerLogs(string, string, string?)`](Diagnostics.cs.md#symbol-8481032d98dd)；[`NationalSpire.Diagnostics.SaveLoggingPerformance()`](LogPerformance.cs.md#symbol-076f9dd0d161)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>.FramesOver50Ms`；`<anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>.MaxFrameMs`；`<anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>.Page`；`<anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>.FramesOrCallsOver50Ms`；`<anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>.MaxMs`；`<anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>.Stage`；`<anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>.TotalMs`；`<anonymous type: System.DateTime CapturedUtc, int ProcessId, string Note, <anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>[] Stages, <anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>[] Pages, NationalSpire.UiPerformance.SlowOperation[] RecentSlowOperations>.CapturedUtc`；`<anonymous type: System.DateTime CapturedUtc, int ProcessId, string Note, <anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>[] Stages, <anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>[] Pages, NationalSpire.UiPerformance.SlowOperation[] RecentSlowOperations>.Note`；`<anonymous type: System.DateTime CapturedUtc, int ProcessId, string Note, <anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>[] Stages, <anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>[] Pages, NationalSpire.UiPerformance.SlowOperation[] RecentSlowOperations>.Pages`；`<anonymous type: System.DateTime CapturedUtc, int ProcessId, string Note, <anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>[] Stages, <anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>[] Pages, NationalSpire.UiPerformance.SlowOperation[] RecentSlowOperations>.ProcessId`；`<anonymous type: System.DateTime CapturedUtc, int ProcessId, string Note, <anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>[] Stages, <anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>[] Pages, NationalSpire.UiPerformance.SlowOperation[] RecentSlowOperations>.RecentSlowOperations`；`<anonymous type: System.DateTime CapturedUtc, int ProcessId, string Note, <anonymous type: string Stage, long Calls, double TotalMs, double MaxMs, long Bytes, long FramesOrCallsOver50Ms>[] Stages, <anonymous type: string Page, long Calls, double MaxFrameMs, long FramesOver50Ms>[] Pages, NationalSpire.UiPerformance.SlowOperation[] RecentSlowOperations>.Stages`；`NationalSpire.UiPerformance.Cost.Bytes`；`NationalSpire.UiPerformance.Cost.Calls`；`NationalSpire.UiPerformance.Cost.Maximum`；`NationalSpire.UiPerformance.Cost.Over50`；`NationalSpire.UiPerformance.Cost.Ticks`；`NationalSpire.UiPerformance.Costs`；`NationalSpire.UiPerformance.Gate`；`NationalSpire.UiPerformance.PageFrames`；`NationalSpire.UiPerformance.Pages`；`NationalSpire.UiPerformance.Recent`；`NationalSpire.UiPerformance.SlowOperation.Utc`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Recent.Where(x=>x!=null).OrderBy(x=>x!.Utc)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Recent.Where(x=>x!=null).OrderBy(x=>x!.Utc).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`Costs.Select((c, i) => new { Stage = ((Work)i).ToString(), c.Calls,              TotalMs = c.Ticks * 1000.0 / Stopwatch.Frequency, MaxMs = c.Maximum * 1000.0 / Stopwatch.Frequency,              c.Bytes, FramesOrCallsOver50Ms = c.Over50 })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Costs.Select((c, i) => new { Stage = ((Work)i).ToString(), c.Calls,              TotalMs = c.Ticks * 1000.0 / Stopwatch.Frequency, MaxMs = c.Maximum * 1000.0 / Stopwatch.Frequency,              c.Bytes, FramesOrCallsOver50Ms = c.Over50 }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`PageFrames.Select((c,i)=>new { Page=Pages[i], c.Calls, MaxFrameMs=c.Maximum*1000.0/Stopwatch.Frequency, FramesOver50Ms=c.Over50 })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PageFrames.Select((c,i)=>new { Page=Pages[i], c.Calls, MaxFrameMs=c.Maximum*1000.0/Stopwatch.Frequency, FramesOver50Ms=c.Over50 }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Costs.Select((c, i) => new { Stage = ((Work)i).ToString(), c.Calls,              TotalMs = c.Ticks * 1000.0 / Stopwatch.Frequency, MaxMs = c.Maximum * 1000.0 / Stopwatch.Frequency,              c.Bytes, FramesOrCallsOver50Ms = c.Over50 }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: Stages = Costs.Select((c, i) => new { Stage = ((Work)i).ToString(), c.Calls,              TotalMs = c.Ticks * 1000.0 / Stopwatch.Frequency, MaxMs = c.Maximum * 1000.0 / Stopwatch.Frequency,              c.Bytes, FramesOrCallsOver50Ms = c.Over50 }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PageFrames.Select((c,i)=>new { Page=Pages[i], c.Calls, MaxFrameMs=c.Maximum*1000.0/Stopwatch.Frequency, FramesOver50Ms=c.Over50 }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: Pages = PageFrames.Select((c,i)=>new { Page=Pages[i], c.Calls, MaxFrameMs=c.Maximum*1000.0/Stopwatch.Frequency, FramesOver50Ms=c.Over50 }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Recent.Where(x=>x!=null).OrderBy(x=>x!.Utc).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: RecentSlowOperations = Recent.Where(x=>x!=null).OrderBy(x=>x!.Utc).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Recent.Where(x=>x!=null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Recent.Where(x=>x!=null).OrderBy`
- `System.Enum.ToString()`；输入表达式：`((Work)i).ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: Stage = ((Work)i).ToString()`

**赋值（含属性/字段和局部值）：**
