# DateGameReturn.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`72F504C1531BC65340DD9753FE3FAAA17F92CD09087EB0C666F86896534AF686`。来源：[源码](../../DateGameReturn.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameReturn`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-dcd87a3e58bb"></a>

## `NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun) — internal static CareerMatch? SavedMatch(CareerData data, string host, string offer, SerializableRun saved)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`](DateGameReturn.cs.md#symbol-5f5af2e8993e)

**调用：** [`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`](CareerRunBinding.cs.md#symbol-98b98bdd8fa3)；[`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-a63bde99754a)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Id`；`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`；`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .CharacterId?.ToString()`
- `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, string, long?)`；输入表达式：`CareerRunBinding.Find(data, saved.SerializableRng?.Seed ?? "",              saved.Players?.FirstOrDefault()?.CharacterId?.ToString() ?? "", saved.Ascension,              saved.Players?.Count ?? 0, saved.GameMode.ToString(), saved.StartTime)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerRunBinding.Find(data, saved.SerializableRng?.Seed ?? "",              saved.Players?.FirstOrDefault()?.CharacterId?.ToString() ?? "", saved.Ascension,              saved.Players?.Count ?? 0, saved.GameMode.ToString(), saved.StartTime)?.Id`
- `NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.InProgress(data, host, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGames.InProgress(data, host, offer)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .FirstOrDefault()?.CharacterId?.ToString()`
- `System.Enum.ToString()`；输入表达式：`saved.GameMode.ToString()`；返回值紧邻使用处：`ArgumentSyntax: saved.GameMode.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5f5af2e8993e"></a>

## `NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string) — internal static Action PrepareSavedResume(CareerData data, string host, string offer)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)

**调用：** [`NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`](DateGameReturn.cs.md#symbol-dcd87a3e58bb)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.MissingMethodException.MissingMethodException(string?)`；`System.Reflection.FieldInfo.GetValue(object?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string match, long StartTime, int CurrentActIndex>.match`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(menu)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(menu)`
- `Godot.Node.IsInsideTree()`；输入表达式：`menu.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !menu.IsInsideTree()`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")?.GetValue(menu)`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NMainMenu), "OnContinueButtonPressed", [typeof(NButton)])`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(NMainMenu), "OnContinueButtonPressed", [typeof(NButton)])              ?? throw new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。")`
- `NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`SavedMatch(data, host, offer, result.SaveData)`；返回值紧邻使用处：`BinaryExpressionSyntax: SavedMatch(data, host, offer, result.SaveData) == null`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("date.game.resume.saved", new { match = data.PendingMatchId, result.SaveData.StartTime, result.SaveData.CurrentActIndex })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("date.game.resume.saved", new { match = data.PendingMatchId, result.SaveData.StartTime, result.SaveData.CurrentActIndex });`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(resume, menu, (object?)null)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => RuntimeApi.Invoke(resume, menu, (object?)null)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("当前原版对局仍在运行，请先关闭生涯界面返回对局。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("当前原版对局仍在运行，请先关闭生涯界面返回对局。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("原版存档与本次约会对局不匹配，请返回对应生涯继续游戏。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("原版存档与本次约会对局不匹配，请返回对应生涯继续游戏。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("原版对局存档读取失败，请返回主菜单检查继续游戏入口。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("原版对局存档读取失败，请返回主菜单检查继续游戏入口。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("主菜单恢复入口尚未就绪，请返回主菜单继续游戏。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("主菜单恢复入口尚未就绪，请返回主菜单继续游戏。");`
- `System.MissingMethodException.MissingMethodException(string?)`；输入表达式：`new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。")`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(menu)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")?.GetValue(menu)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9e75de0044f4"></a>

## `NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch) — private bool ResumeSettledDate(CareerData data, CareerMatch match)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReviewPager(NationalSpire.CareerData, NationalSpire.CareerResult, Godot.HBoxContainer)`](MatchArenaScreen.cs.md#symbol-2553d6834735)

**调用：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.CanvasItem.IsVisibleInTree()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `<anonymous type: string match, string offer, bool visible>.match`；`<anonymous type: string match, string offer, bool visible>.offer`；`<anonymous type: string match, string offer, bool visible>.visible`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._reviewId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`；`NationalSpire.DateGameState.ReturnPending`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`.IsVisibleInTree()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateView?.IsVisibleInTree()`
- `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；输入表达式：`OpenDateSceneReady(game.OfferId, false, true, () =>          {              StartDateGameReply(match, "result");              Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true });          })`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateSceneReady(game.OfferId, false, true, () =>          {              StartDateGameReply(match, "result");              Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true });          });`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(game.Host)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(game.Host);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；输入表达式：`StartDateGameReply(match, "result")`；返回值紧邻使用处：`ExpressionStatementSyntax: StartDateGameReply(match, "result");`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == game.OfferId && DateScenes.Available(data, o, c)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true });`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, game.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, game.Host)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c))`

**赋值（含属性/字段和局部值）：**

- `_reviewId` = `""`
- `_tab` = `"赛事"`
- `game.ReturnPending` = `false`
