# LiveCompatibility.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`68A71EC8603461ECCDDAAB107345097F4EC84BA87F43124F47A31D4A43BC9CD7`。来源：[源码](../../LiveCompatibility.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveCompatibility`、`NationalSpire.LiveCompatibility.DateTimer`。

字段、事件及初始值（源码原样）：

```csharp
private const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
private static readonly PropertyInfo? Pause = typeof(RunManager).GetProperty("IsPaused", Flags);
internal static readonly Func<RunManager, bool>? Read = Pause?.GetMethod?.CreateDelegate<Func<RunManager, bool>>();
internal static readonly Action<RunManager, bool>? Write = Pause?.SetMethod?.CreateDelegate<Action<RunManager, bool>>();
private static readonly MethodInfo? StateReader = new[] { "GetRunState", "GetState", "DebugOnlyGetState" }
        .Select(name => typeof(RunManager).GetMethod(name, Flags, Type.EmptyTypes))
        .FirstOrDefault(m => m != null && typeof(RunState).IsAssignableFrom(m.ReturnType));
private static readonly FieldInfo? RunField = typeof(NRun).GetFields(Flags).FirstOrDefault(f => f.FieldType == typeof(RunState));
```

<a id="symbol-b752ad935441"></a>

## `NationalSpire.LiveCompatibility.IsDateRunPaused() — internal static bool IsDateRunPaused()`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.CanOpenDateChat()`](LiveDateGame.cs.md#symbol-ae2a19aa7c3a)；[`NationalSpire.LiveRunBridge.TickDateRequestClock(double)`](LiveDateGame.cs.md#symbol-85266af9ae90)；[`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)

**调用：** `System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LiveCompatibility.DateTimer.Read`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(RunManager.Instance)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateTimer.Read?.Invoke(RunManager.Instance)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7978d8a89b5c"></a>

## `NationalSpire.LiveCompatibility.SetDateTimerPaused(bool) — internal static void SetDateTimerPaused(bool paused)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGamePause.Acquire()`](LiveDateGame.cs.md#symbol-c615b37330ed)；[`NationalSpire.DateGamePause.Dispose()`](LiveDateGame.cs.md#symbol-1b8e2cb9178c)

**调用：** `System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LiveCompatibility.DateTimer.Write`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(RunManager.Instance, paused)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateTimer.Write?.Invoke(RunManager.Instance, paused)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b0c55be23807"></a>

## `NationalSpire.LiveCompatibility.ReadState(MegaCrit.Sts2.Core.Nodes.NRun) — public static RunState? ReadState(NRun node)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunReadyPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NRun)`](LiveRunBridge.cs.md#symbol-5639c4c6edfd)

**调用：** `System.Reflection.FieldInfo.GetValue(object?)`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveCompatibility.RunField`；`NationalSpire.LiveCompatibility.StateReader`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(node)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RunField?.GetValue(node)`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`.Invoke(RunManager.Instance, null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: StateReader?.Invoke(RunManager.Instance, null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e7d2ddafdb60"></a>

## `NationalSpire.LiveCompatibility.MapPoints(Godot.Node) — public static Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, NMapPoint> MapPoints(Node screen)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Runs.IRunState, System.Collections.Generic.IReadOnlyList<NationalSpire.LiveMapRival>)`](Coop/CoopLive.cs.md#symbol-a444164580e0)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** [`Visit(Godot.Node)`](LiveCompatibility.cs.md#symbol-dccab061568e)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** `Visit(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, NMapPoint>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, NMapPoint>()`
- `Visit(Godot.Node)`；输入表达式：`Visit(screen)`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(screen);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dccab061568e"></a>

## `Visit(Godot.Node) — void Visit(Node node)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`](LiveCompatibility.cs.md#symbol-e7d2ddafdb60)；[`Visit(Godot.Node)`](LiveCompatibility.cs.md#symbol-dccab061568e)

**调用：** [`Visit(Godot.Node)`](LiveCompatibility.cs.md#symbol-dccab061568e)；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetChildren(bool)`

**字段、属性、事件及方法组引用：** `Visit(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`point.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !point.IsQueuedForDeletion()`
- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in node.GetChildren()) Visit(child);`
- `Visit(Godot.Node)`；输入表达式：`Visit(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(child);`

**赋值（含属性/字段和局部值）：**

- `result[point.Point.coord]` = `point`

<a id="symbol-a0d94fdc9a3a"></a>

## `NationalSpire.LiveCompatibility.Install(HarmonyLib.Harmony, System.Reflection.Assembly) — public static void Install(Harmony harmony, Assembly assembly)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`Godot.GD.PushWarning(string)`；`HarmonyLib.Harmony.CreateClassProcessor(System.Type)`；`HarmonyLib.PatchClassProcessor.Patch()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Exception.GetBaseException()`；`System.Reflection.Assembly.GetTypes()`；`System.Reflection.MemberInfo.GetCustomAttributes(System.Type, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning($"[NationalSpire] {type.Name} 接口暂不可用，其他模块继续加载：{e.GetBaseException().Message}")`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning($"[NationalSpire] {type.Name} 接口暂不可用，其他模块继续加载：{e.GetBaseException().Message}");`
- `HarmonyLib.Harmony.CreateClassProcessor(System.Type)`；输入表达式：`harmony.CreateClassProcessor(type)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: harmony.CreateClassProcessor(type).Patch`
- `HarmonyLib.PatchClassProcessor.Patch()`；输入表达式：`harmony.CreateClassProcessor(type).Patch()`；返回值紧邻使用处：`ExpressionStatementSyntax: harmony.CreateClassProcessor(type).Patch();`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("patch:" + type.Name, e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("patch:" + type.Name, e);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`assembly.GetTypes().Where(t => t.GetCustomAttributes(typeof(HarmonyPatch), false).Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var type in assembly.GetTypes().Where(t => t.GetCustomAttributes(typeof(HarmonyPatch), false).Length > 0))         {             try { harmony.CreateClassProcessor(type).Patch(); }             catch (Exception e) { Diagnostics.Error("patch:" + type.Name, e); GD.PushWarning($"[NationalSpire] {type.Name} 接口暂不可用，其他模块继续加载：{e.GetBaseException().Message}"); }         }`
- `System.Exception.GetBaseException()`；输入表达式：`e.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetBaseException().Message`
- `System.Reflection.Assembly.GetTypes()`；输入表达式：`assembly.GetTypes()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: assembly.GetTypes().Where`
- `System.Reflection.MemberInfo.GetCustomAttributes(System.Type, bool)`；输入表达式：`t.GetCustomAttributes(typeof(HarmonyPatch), false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.GetCustomAttributes(typeof(HarmonyPatch), false).Length`

**赋值（含属性/字段和局部值）：**
