# FailureScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`79E512C81BB6DBE7B60ADDAE9BAF6875D2BC8A51571A3A5742588FDC72FCDC2A`。来源：[源码](../../FailureScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-64d5a395c405"></a>

## `NationalSpire.CareerScreen.ResolveFailure(string) — private async void ResolveFailure(string action)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`](AiService.cs.md#symbol-8243488b636b)；[`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.GameBridge.RandomChoice()`](GameBridge.cs.md#symbol-e436ec882e7b)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-e4be787ed490)；[`NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool)`](FailureDecision.cs.md#symbol-e81edcf0cf5a)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.RandomCharacter`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.Simulated`；`NationalSpire.CareerScreen._starting`；`NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.FailureDecision.Result`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.GameBridge.RandomChoice()`；`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；`NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData)`；`NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == data.SelectedCharacter`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == failed.CharacterId`
- `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessPendingAsync(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPendingAsync(data)`
- `NationalSpire.CareerScreen.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand(action == "confirm" ? "failure-confirm" : "failure-retry", text: action)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand(action == "confirm" ? "failure-confirm" : "failure-retry", text: action)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("本次出场角色无法读取。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("本次出场角色无法读取。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `NationalSpire.GameBridge.RandomChoice()`；输入表达式：`GameBridge.RandomChoice()`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.RandomCharacter ? GameBridge.RandomChoice() : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == data.SelectedCharacter)`
- `NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`GameBridge.StartMatch(match, character, failed.PlayedAscension ?? failed.Ascension)`；返回值紧邻使用处：`AwaitExpressionSyntax: await GameBridge.StartMatch(match, character, failed.PlayedAscension ?? failed.Ascension)`
- `NationalSpire.MatchFailure.Confirm(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Confirm(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchFailure.Confirm(data);`
- `NationalSpire.MatchFailure.Retry(NationalSpire.CareerData, bool)`；输入表达式：`MatchFailure.Retry(data, action == "new")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MatchFailure.Retry(data, action == "new")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == data.SelectedCharacter)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.RandomCharacter ? GameBridge.RandomChoice() : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == data.SelectedCharacter)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == failed.CharacterId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: failed.Simulated             ? GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == failed.CharacterId)             : data.RandomCharacter ? GameBridge.RandomChoice() : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == data.SelectedCharacter)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPendingAsync(data)`
- `_starting` = `false`
- `_starting` = `true`
