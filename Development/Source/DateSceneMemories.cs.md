# DateSceneMemories.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`2BCB0A37523E81A5EABE2FA5F2A092031B72679556AEDB945BBD0E03644572ED`。来源：[源码](../../DateSceneMemories.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneMemory`、`NationalSpire.DateMemoryRecorder`、`NationalSpire.DateMemoryPerson`、`NationalSpire.DateMemoryTurn`、`NationalSpire.DateMemoryFrame`、`NationalSpire.DateSceneMemories`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, (string User, string Reply, string Status, bool Deleted)> _seen = [];
private const string SettingsPath = "user://NationalSpire_date_scene.cfg";
private static readonly Dictionary<string, (string Stamp, List<DateSceneMemory> Memories, string Warning)> Cache = [];
```

<a id="symbol-f287cf56f1d3"></a>

## `NationalSpire.DateSceneMemory.Version — public int Version`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-49e711df2b2a"></a>

## `NationalSpire.DateSceneMemory.OfferId — public string OfferId`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-16ffe879ccde"></a>

## `NationalSpire.DateSceneMemory.Host — public string Host`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c81f29810a00"></a>

## `NationalSpire.DateSceneMemory.Player — public string Player`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9bae22419f11"></a>

## `NationalSpire.DateSceneMemory.Title — public string Title`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0f33e5c4ffdc"></a>

## `NationalSpire.DateSceneMemory.Season — public int Season`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-171147e89ff8"></a>

## `NationalSpire.DateSceneMemory.Day — public int Day`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d700f9c8f262"></a>

## `NationalSpire.DateSceneMemory.Ended — public bool Ended`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-be8bf9c07285"></a>

## `NationalSpire.DateSceneMemory.People — public Dictionary<string, DateMemoryPerson> People`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-93ccd2969550"></a>

## `NationalSpire.DateSceneMemory.Backgrounds — public Dictionary<string, string> Backgrounds`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e305df04b671"></a>

## `NationalSpire.DateSceneMemory.Turns — public List<DateMemoryTurn> Turns`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4ba78cbdd7db"></a>

## `NationalSpire.DateSceneMemory.Initial — public DateMemoryFrame? Initial`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-20feb9978441"></a>

## `NationalSpire.DateMemoryRecorder.Memory — public DateSceneMemory Memory`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9f55598a223c"></a>

## `NationalSpire.DateMemoryRecorder.Dirty — public bool Dirty`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3b5969777f04"></a>

## `NationalSpire.DateMemoryRecorder.PendingChoice — public string PendingChoice`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d69e26428aaf"></a>

## `NationalSpire.DateMemoryRecorder.LastFrame — public DateMemoryFrame? LastFrame`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryTurn.Frames`；`NationalSpire.DateSceneMemory.Initial`；`NationalSpire.DateSceneMemory.Turns`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`memory.Turns.SelectMany(t => t.Frames.OrderBy(p => p.Key).Select(p => p.Value)).LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: memory.Turns.SelectMany(t => t.Frames.OrderBy(p => p.Key).Select(p => p.Value)).LastOrDefault() ?? memory.Initial`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`t.Frames.OrderBy(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Frames.OrderBy(p => p.Key).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.Frames.OrderBy(p => p.Key).Select(p => p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => t.Frames.OrderBy(p => p.Key).Select(p => p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`memory.Turns.SelectMany(t => t.Frames.OrderBy(p => p.Key).Select(p => p.Value))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: memory.Turns.SelectMany(t => t.Frames.OrderBy(p => p.Key).Select(p => p.Value)).LastOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-949d37f3d89e"></a>

## `NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation) — public void Sync(PrivateConversation conversation)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SyncDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-4103852c245a)

**调用：** `NationalSpire.DateMemoryTurn.DateMemoryTurn()`；[`NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`](DateSceneMemories.cs.md#symbol-f89ef1794aeb)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryRecorder.Dirty`；`NationalSpire.DateMemoryRecorder.LastFrame`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateMemoryRecorder.PendingChoice`；`NationalSpire.DateMemoryRecorder._seen`；`NationalSpire.DateMemoryTurn.Choice`；`NationalSpire.DateMemoryTurn.Complete`；`NationalSpire.DateMemoryTurn.Frames`；`NationalSpire.DateMemoryTurn.Id`；`NationalSpire.DateMemoryTurn.Lines`；`NationalSpire.DateMemoryTurn.User`；`NationalSpire.DateMemoryTurn.UserFrame`；`NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.DateSceneMemory.Turns`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryTurn.DateMemoryTurn()`；输入表达式：`new() { Id = turn.Id, UserFrame = LastFrame }`；返回值紧邻使用处：`AssignmentExpressionSyntax: entry = new() { Id = turn.Id, UserFrame = LastFrame }`
- `NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`；输入表达式：`DateSceneMemories.SameLine(lines[index], entry.Lines[index])`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateSceneMemories.SameLine(lines[index], entry.Lines[index])`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(turn)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateScenes.Lines(turn).Select`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`entry.Frames.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.Frames.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`entry.Frames.Remove(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.Frames.Remove(index);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_seen.TryGetValue(turn.Id, out var before)`；返回值紧邻使用处：`BinaryExpressionSyntax: _seen.TryGetValue(turn.Id, out var before) && before == signature`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Memory.Turns.FirstOrDefault(t => t.Id == turn.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Memory.Turns.FirstOrDefault(t => t.Id == turn.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateScenes.Lines(turn).Select(DateSceneMemories.CopyLine)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateScenes.Lines(turn).Select(DateSceneMemories.CopyLine).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`DateScenes.Lines(turn).Select(DateSceneMemories.CopyLine).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateScenes.Lines(turn).Select(DateSceneMemories.CopyLine).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entry.Frames.Keys.ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (int index in entry.Frames.Keys.ToList()) if (index >= lines.Count || index >= entry.Lines.Count || !DateSceneMemories.SameLine(lines[index], entry.Lines[index])) entry.Frames.Remove(index);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene?.OfferId == Memory.OfferId && !t.Scene.Ending)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == Memory.OfferId && !t.Scene.Ending)) { var signature = (turn.User, turn.Reply, turn.Status, turn.ReplyDeleted); if (_seen.TryGetValue(turn.Id, out var before) && before == signature) continue; _seen[turn.Id] = signature; var entry = Memory.Turns.FirstOrDefault(t => t.Id == turn.Id); if (entry == null) { entry = new() { Id = turn.Id, UserFrame = LastFrame }; Memory.Turns.Add(entry); } // 重试也可来自已播放部分内容的失败轮次；界面可能只观察到重新开始发送。 if (turn.Status == "queued" || turn.Status == "sending" && (entry.Complete || before.Status != "sending")) { entry.Lines.Clear(); entry.Frames.Clear(); } string user = turn.UserDeleted || turn.Scene!.Opening || turn.Scene.GameEvent.Length > 0 ? "" : turn.User; if (entry.User != user) entry.Choice = false; entry.User = user; if (PendingChoice.Length > 0 && entry.User == PendingChoice) { entry.Choice = true; PendingChoice = ""; } entry.Complete = turn.Status == "complete" && !turn.ReplyDeleted; if (entry.Complete) { var lines = DateScenes.Lines(turn).Select(DateSceneMemories.CopyLine).ToList(); foreach (int index in entry.Frames.Keys.ToList()) if (index >= lines.Count || index >= entry.Lines.Count || !DateSceneMemories.SameLine(lines[index], entry.Lines[index])) entry.Frames.Remove(index); entry.Lines = lines; } if (turn.ReplyDeleted) { entry.Lines.Clear(); entry.Frames.Clear(); } Dirty = true; }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Memory.Turns.Add(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memory.Turns.Add(entry);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`entry.Lines.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.Lines.Clear();`

**赋值（含属性/字段和局部值）：**

- `Dirty` = `true`
- `Id` = `turn.Id`
- `PendingChoice` = `""`
- `UserFrame` = `LastFrame`
- `_seen[turn.Id]` = `signature`
- `entry.Choice` = `false`
- `entry.Choice` = `true`
- `entry.Complete` = `turn.Status == "complete" && !turn.ReplyDeleted`
- `entry.Lines` = `lines`
- `entry.User` = `user`
- `entry` = `new() { Id = turn.Id, UserFrame = LastFrame }`

<a id="symbol-9b3816f4efa8"></a>

## `NationalSpire.DateMemoryRecorder.Capture(string, int, NationalSpire.DateSceneLine, NationalSpire.DateMemoryFrame) — public void Capture(string turn, int index, DateSceneLine line, DateMemoryFrame frame)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)

**调用：** `NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`](DateSceneMemories.cs.md#symbol-0929ad334607)；[`NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`](DateSceneMemories.cs.md#symbol-f89ef1794aeb)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryRecorder.Dirty`；`NationalSpire.DateMemoryRecorder.LastFrame`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateMemoryTurn.Frames`；`NationalSpire.DateMemoryTurn.Id`；`NationalSpire.DateMemoryTurn.Lines`；`NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneMemory.Initial`；`NationalSpire.DateSceneMemory.Turns`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`；输入表达式：`DateSceneMemories.CopyLine(line)`；返回值紧邻使用处：`AssignmentExpressionSyntax: entry.Lines[index] = DateSceneMemories.CopyLine(line)`
- `NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`；输入表达式：`DateSceneMemories.SameLine(entry.Lines[index], line)`；返回值紧邻使用处：`BinaryExpressionSyntax: index < entry.Lines.Count && DateSceneMemories.SameLine(entry.Lines[index], line)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`entry.Frames.TryGetValue(index, out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: index < entry.Lines.Count && DateSceneMemories.SameLine(entry.Lines[index], line) && entry.Frames.TryGetValue(index, out var previous)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Memory.Turns.FirstOrDefault(t => t.Id == turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Memory.Turns.FirstOrDefault(t => t.Id == turn)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entry.Lines.Add(new())`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.Lines.Add(new());`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(frame)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Serialize(previous) == JsonSerializer.Serialize(frame)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Serialize(previous) == JsonSerializer.Serialize(frame)`

**赋值（含属性/字段和局部值）：**

- `Dirty` = `true`
- `LastFrame` = `frame`
- `Memory.Initial` ??= `frame`
- `entry.Frames[index]` = `frame`
- `entry.Lines[index]` = `DateSceneMemories.CopyLine(line)`

<a id="symbol-2866ac3717ef"></a>

## `NationalSpire.DateMemoryPerson.Name — public string Name`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-40a3a209b678"></a>

## `NationalSpire.DateMemoryPerson.Default — public string Default`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3611ab8f5cca"></a>

## `NationalSpire.DateMemoryPerson.Emotions — public Dictionary<string, string> Emotions`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-736bdba5176f"></a>

## `NationalSpire.DateMemoryTurn.Id — public string Id`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-efdc01be977b"></a>

## `NationalSpire.DateMemoryTurn.User — public string User`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a80f27cc4255"></a>

## `NationalSpire.DateMemoryTurn.Choice — public bool Choice`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-21e4ae57cf3a"></a>

## `NationalSpire.DateMemoryTurn.Complete — public bool Complete`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-60302772b5c6"></a>

## `NationalSpire.DateMemoryTurn.UserFrame — public DateMemoryFrame? UserFrame`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7cf34b9f85b2"></a>

## `NationalSpire.DateMemoryTurn.Lines — public List<DateSceneLine> Lines`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6f023e1a46bb"></a>

## `NationalSpire.DateMemoryTurn.Frames — public Dictionary<int, DateMemoryFrame> Frames`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3ce4f50b21f3"></a>

## `NationalSpire.DateMemoryFrame.Placements — public Dictionary<string, DatePortraitPlacement> Placements`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8df0ffda616c"></a>

## `NationalSpire.DateMemoryFrame.Background — public string Background`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e48bf4eca17b"></a>

## `NationalSpire.DateMemoryFrame.Speaker — public string Speaker`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-899396cf26b3"></a>

## `NationalSpire.DateMemoryFrame.Cast — public List<string> Cast`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a8a5ca2001ee"></a>

## `NationalSpire.DateMemoryFrame.Portraits — public Dictionary<string, string> Portraits`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c22316863eee"></a>

## `NationalSpire.DateMemoryFrame.Anchors — public Dictionary<string, string> Anchors`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f4e87eadbb0d"></a>

## `NationalSpire.DateMemoryFrame.FontSize — public int FontSize`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b21dd886dbca"></a>

## `NationalSpire.DateMemoryFrame.Fade — public double Fade`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4eed8c35317c"></a>

## `NationalSpire.DateMemoryFrame.Spacing — public double Spacing`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2663f854ec06"></a>

## `NationalSpire.DateMemoryFrame.Blur — public double Blur`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-83a39008f6a1"></a>

## `NationalSpire.DateMemoryFrame.Scale — public double Scale`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8a269e5d1525"></a>

## `NationalSpire.DateMemoryFrame.X — public double X`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-719031594633"></a>

## `NationalSpire.DateMemoryFrame.Y — public double Y`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2778c44d4c7a"></a>

## `NationalSpire.DateMemoryFrame.Outline — public bool Outline`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-476f325eb0e1"></a>

## `NationalSpire.DateMemoryFrame.Badge — public bool Badge`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c1cbf44daebe"></a>

## `NationalSpire.DateMemoryFrame.Favour — public int Favour`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-611f677c1f19"></a>

## `NationalSpire.DateMemoryFrame.Relationship — public string Relationship`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7288b467cc14"></a>

## `NationalSpire.DateMemoryFrame.Bond — public int? Bond`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3fd02ff37413"></a>

## `NationalSpire.DateMemoryFrame.Oath — public bool Oath`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2d93a9b26c1f"></a>

## `NationalSpire.DateSceneMemories.Recording — public static bool Recording`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ConfigFile.ConfigFile()`；`Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.Load(string)`；`Godot.ConfigFile.Save(string)`；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`Godot.Variant.AsBool()`；`System.IO.IOException.IOException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneMemories.SettingsPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.ConfigFile()`；输入表达式：`new ConfigFile()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConfigFile()`
- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`config.GetValue("scene", "record_dates", true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: config.GetValue("scene", "record_dates", true).AsBool`
- `Godot.ConfigFile.Load(string)`；输入表达式：`config.Load(SettingsPath)`；返回值紧邻使用处：`ExpressionStatementSyntax: config.Load(SettingsPath);`
- `Godot.ConfigFile.Save(string)`；输入表达式：`config.Save(SettingsPath)`；返回值紧邻使用处：`BinaryExpressionSyntax: config.Save(SettingsPath) != Error.Ok`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`config.SetValue("scene", "record_dates", value)`；返回值紧邻使用处：`ExpressionStatementSyntax: config.SetValue("scene", "record_dates", value);`
- `Godot.Variant.AsBool()`；输入表达式：`config.GetValue("scene", "record_dates", true).AsBool()`；返回值紧邻使用处：`ReturnStatementSyntax: return config.GetValue("scene", "record_dates", true).AsBool();`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("保存回忆记录设置失败。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException("保存回忆记录设置失败。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9455c4e36faf"></a>

## `NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData) — public static string DirectoryPath(CareerData data)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-a32b756f581f)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`](DateSceneMemories.cs.md#symbol-8302de288689)；[`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-4fa62fbdceed)

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_date_memories")`；返回值紧邻使用处：`ArgumentSyntax: ProjectSettings.GlobalizePath("user://national_spire_date_memories")`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, "date-memories")`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.Key(data, "date-memories")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(ProjectSettings.GlobalizePath("user://national_spire_date_memories"), PortraitDesignStore.Key(data, "date-memories"))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Path.Combine(ProjectSettings.GlobalizePath("user://national_spire_date_memories"), PortraitDesignStore.Key(data, "date-memories"))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c6266089e238"></a>

## `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string) — public static string FilePath(CareerData data, string offer)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateSceneMemoryScreen.cs.md#symbol-e0190873cf74)；[`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.SyncDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-4103852c245a)；[`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-a32b756f581f)；[`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-99fb40e5b954)；[`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-4fa62fbdceed)

**调用：** [`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`](DateSceneMemories.cs.md#symbol-9455c4e36faf)；`System.IO.Path.Combine(string, string)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(offer))`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(offer)) + ".json"`
- `NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；输入表达式：`DirectoryPath(data)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryPath(data)`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(DirectoryPath(data), DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(offer)) + ".json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Path.Combine(DirectoryPath(data), DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(offer)) + ".json")`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(offer)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(offer)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-99fb40e5b954"></a>

## `NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string) — public static DateSceneMemory? Read(CareerData data, string offer)`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateSceneMemoryScreen.cs.md#symbol-e0190873cf74)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)

**调用：** [`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-f23dfc6f28c7)；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.DateSceneMemory.Version`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`FilePath(data, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilePath(data, offer)`
- `NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`ReconcileDeletedReplies(data, memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReconcileDeletedReplies(data, memory);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path)`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("约会回忆格式无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("约会回忆格式无效。");`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<DateSceneMemory>(File.ReadAllText(path), PortraitDesigns.Json)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Deserialize<DateSceneMemory>(File.ReadAllText(path), PortraitDesigns.Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f4609a0121d1"></a>

## `NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string) — public static bool RemoveReply(DateSceneMemory memory, string turnId)`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-f23dfc6f28c7)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryTurn.Complete`；`NationalSpire.DateMemoryTurn.Frames`；`NationalSpire.DateMemoryTurn.Id`；`NationalSpire.DateMemoryTurn.Lines`；`NationalSpire.DateSceneMemory.Turns`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`turn.Frames.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Frames.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`memory.Turns.FirstOrDefault(t => t.Id == turnId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = memory.Turns.FirstOrDefault(t => t.Id == turnId)`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`turn.Lines.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Lines.Clear();`

**赋值（含属性/字段和局部值）：**

- `turn.Complete` = `false`

<a id="symbol-f23dfc6f28c7"></a>

## `NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory) — public static void ReconcileDeletedReplies(CareerData data, DateSceneMemory memory)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`](DateSceneMemories.cs.md#symbol-8302de288689)；[`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-99fb40e5b954)；[`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-4fa62fbdceed)

**调用：** [`NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`](DateSceneMemories.cs.md#symbol-f4609a0121d1)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneMemories.RemoveReply(NationalSpire.DateSceneMemory, string)`；输入表达式：`RemoveReply(memory, turn.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveReply(memory, turn.Id);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene?.OfferId == memory.OfferId && t.ReplyDeleted)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == memory.OfferId && t.ReplyDeleted)) RemoveReply(memory, turn.Id);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4fa62fbdceed"></a>

## `NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory) — public static void Save(CareerData data, DateSceneMemory memory)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)

**调用：** [`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`](DateSceneMemories.cs.md#symbol-9455c4e36faf)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-f23dfc6f28c7)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?, System.Text.Encoding)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.UTF8Encoding.UTF8Encoding(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneMemories.Cache`；`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.PortraitDesigns.Json`；`NationalSpire.PrivateConversation.DeletedDateDiaries`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；输入表达式：`DirectoryPath(data)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryPath(data)`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`FilePath(data, memory.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilePath(data, memory.OfferId)`
- `NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`ReconcileDeletedReplies(data, memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReconcileDeletedReplies(data, memory);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`Cache.Remove(DirectoryPath(data))`；返回值紧邻使用处：`ExpressionStatementSyntax: Cache.Remove(DirectoryPath(data));`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`c.DeletedDateDiaries.Contains(memory.OfferId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.DeletedDateDiaries.Contains(memory.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Any(c => c.DeletedDateDiaries.Contains(memory.OfferId))`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateMessages.Mailbox(data).Conversations.Values.Any(c => c.DeletedDateDiaries.Contains(memory.OfferId))) return;`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + "." + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(path)!);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temporary, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path, true);`
- `System.IO.File.WriteAllText(string, string?, System.Text.Encoding)`；输入表达式：`File.WriteAllText(temporary, JsonSerializer.Serialize(memory, PortraitDesigns.Json), new UTF8Encoding(false))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temporary, JsonSerializer.Serialize(memory, PortraitDesigns.Json), new UTF8Encoding(false));`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(memory, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(memory, PortraitDesigns.Json)`
- `System.Text.UTF8Encoding.UTF8Encoding(bool)`；输入表达式：`new UTF8Encoding(false)`；返回值紧邻使用处：`ArgumentSyntax: new UTF8Encoding(false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a32b756f581f"></a>

## `NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string) — public static void Delete(CareerData data, string offer)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)；[`Removed()`](DateDiaryScreen.cs.md#symbol-d4d8f582fe1c)

**调用：** [`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`](DateSceneMemories.cs.md#symbol-9455c4e36faf)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.IO.File.Delete(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneMemories.Cache`；`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；输入表达式：`DirectoryPath(data)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryPath(data)`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`FilePath(data, offer)`；返回值紧邻使用处：`ArgumentSyntax: FilePath(data, offer)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`Cache.Remove(DirectoryPath(data))`；返回值紧邻使用处：`ExpressionStatementSyntax: Cache.Remove(DirectoryPath(data));`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(FilePath(data, offer))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(FilePath(data, offer));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8302de288689"></a>

## `NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string) — public static List<DateSceneMemory> ForPerson(CareerData data, string person, out string warning)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)

**调用：** [`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`](DateSceneMemories.cs.md#symbol-9455c4e36faf)；[`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-f23dfc6f28c7)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.Directory.EnumerateFiles(string, string)`；`System.IO.Directory.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.FileInfo.FileInfo(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryTurn.Lines`；`NationalSpire.DateMemoryTurn.User`；`NationalSpire.DateSceneMemories.Cache`；`NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；`NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；`NationalSpire.DateSceneMemory.Ended`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.DateSceneMemory.People`；`NationalSpire.DateSceneMemory.Turns`；`NationalSpire.DateSceneMemory.Version`；`NationalSpire.PortraitDesigns.Json`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.DeletedDateDiaries`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneMemories.DirectoryPath(NationalSpire.CareerData)`；输入表达式：`DirectoryPath(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DirectoryPath(data)`
- `NationalSpire.DateSceneMemories.ReconcileDeletedReplies(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`ReconcileDeletedReplies(data, memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReconcileDeletedReplies(data, memory);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.People.ContainsKey(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.People.ContainsKey(person) && !deleted.Contains(m.OfferId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cache.TryGetValue(directory, out var cached)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Cache.TryGetValue(directory, out var cached)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`deleted.Contains(m.OfferId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !deleted.Contains(m.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`memory.Turns.Any(t => t.User.Length > 0 || t.Lines.Count > 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: memory is { Version: 1 } && memory.Turns.Any(t => t.User.Length > 0 || t.Lines.Count > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy(f => f.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy(f => f.Name).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`files.Select(f => f.Name + ":" + f.Length + ":" + f.LastWriteTimeUtc.Ticks)`；返回值紧邻使用处：`ArgumentSyntax: files.Select(f => f.Name + ":" + f.Length + ":" + f.LastWriteTimeUtc.Ticks)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`conversations.Values.SelectMany(c => c.DeletedDateDiaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversations.Values.SelectMany(c => c.DeletedDateDiaries).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`conversations.Values.SelectMany(c => c.DeletedDateDiaries).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversations.Values.SelectMany(c => c.DeletedDateDiaries).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy(f => f.Name).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(directory) ? Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy(f => f.Name).ToList() : []`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`cached.Memories.Where(m => m.People.ContainsKey(person) && !deleted.Contains(m.OfferId) && (m.Ended || conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId) == "ended")).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return cached.Memories.Where(m => m.People.ContainsKey(person) && !deleted.Contains(m.OfferId) && (m.Ended || conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId) == "ended")).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cached.Memories.Where(m => m.People.ContainsKey(person) && !deleted.Contains(m.OfferId) && (m.Ended || conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId) == "ended"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cached.Memories.Where(m => m.People.ContainsKey(person) && !deleted.Contains(m.OfferId) && (m.Ended || conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId) == "ended")).ToList`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.DateSceneStates.GetValueOrDefault(m.OfferId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversations.GetValueOrDefault(m.Host)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`errors.Add("一份回忆读取失败：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: errors.Add("一份回忆读取失败：" + e.Message);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(memory);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneMemory>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneMemory>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.IO.Directory.EnumerateFiles(string, string)`；输入表达式：`Directory.EnumerateFiles(directory, "*.json")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateFiles(directory, "*.json").Select`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(directory)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(directory) ? Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy(f => f.Name).ToList() : []`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(file.FullName)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(file.FullName)`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new FileInfo(p)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<DateSceneMemory>(File.ReadAllText(file.FullName), PortraitDesigns.Json)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Deserialize<DateSceneMemory>(File.ReadAllText(file.FullName), PortraitDesigns.Json)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", errors)`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n", errors)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('|', files.Select(f => f.Name + ":" + f.Length + ":" + f.LastWriteTimeUtc.Ticks))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join('|', files.Select(f => f.Name + ":" + f.Length + ":" + f.LastWriteTimeUtc.Ticks))`

**赋值（含属性/字段和局部值）：**

- `Cache[directory]` = `cached = (stamp, result, string.Join("\n", errors))`
- `cached` = `(stamp, result, string.Join("\n", errors))`
- `warning` = `cached.Warning`

<a id="symbol-0929ad334607"></a>

## `NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine) — public static DateSceneLine CopyLine(DateSceneLine line)`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryRecorder.Capture(string, int, NationalSpire.DateSceneLine, NationalSpire.DateMemoryFrame)`](DateSceneMemories.cs.md#symbol-9b3816f4efa8)；[`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`](DateSceneMemoryPlayback.cs.md#symbol-428af8387aa7)

**调用：** `NationalSpire.DateSceneLine.DateSceneLine()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Speaker = line.Speaker, Text = line.Text, Emotion = line.Emotion, Narration = line.Narration, Background = line.Background }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { Speaker = line.Speaker, Text = line.Text, Emotion = line.Emotion, Narration = line.Narration, Background = line.Background }`

**赋值（含属性/字段和局部值）：**

- `Background` = `line.Background`
- `Emotion` = `line.Emotion`
- `Narration` = `line.Narration`
- `Speaker` = `line.Speaker`
- `Text` = `line.Text`

<a id="symbol-f89ef1794aeb"></a>

## `NationalSpire.DateSceneMemories.SameLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine) — public static bool SameLine(DateSceneLine a, DateSceneLine b)`

来源：源码第 186 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryRecorder.Capture(string, int, NationalSpire.DateSceneLine, NationalSpire.DateMemoryFrame)`](DateSceneMemories.cs.md#symbol-9b3816f4efa8)；[`NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`](DateSceneMemories.cs.md#symbol-949d37f3d89e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
