# DateGames.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D2E85D7DD6CA665F652D53C9A3072B7F1F332F4FFC880AC8104B6A7A76491990`。来源：[源码](../../DateGames.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameState`、`NationalSpire.DateGameRule`、`NationalSpire.DateGames`。

字段、事件及初始值（源码原样）：

```csharp
public const string AttachmentKind = "date-game";
public const double ChatRequestSeconds = 20;
public const double ChatRequestInterval = 20;
public const string InvitationProtocol = "玩家邀请大家在约会期间一起玩《杀戮尖塔2》切磋。每名参与者依据意愿回应，随后各自输出 [DateGame: 接受, Actor: 完整PersonId] 或 [DateGame: 拒绝, Actor: 完整PersonId]。全部接受后玩家可开始游戏。";
```

<a id="symbol-304585b4231c"></a>

## `NationalSpire.DateGameState.Host — public string Host`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f1394d47ec2e"></a>

## `NationalSpire.DateGameState.OfferId — public string OfferId`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-74e6e6681265"></a>

## `NationalSpire.DateGameState.TurnId — public string TurnId`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-60c58762647a"></a>

## `NationalSpire.DateGameState.People — public List<string> People`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-356a12b25a5f"></a>

## `NationalSpire.DateGameState.Voices — public Dictionary<string, string> Voices`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-16dedd40b6e0"></a>

## `NationalSpire.DateGameState.ReturnPending — public bool ReturnPending`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-53c095fefc43"></a>

## `NationalSpire.DateGameState.ResultTurnId — public string ResultTurnId`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6b695250d859"></a>

## `NationalSpire.DateGameState.Companions — public List<CareerMatch> Companions`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-55f0684bfdb3"></a>

## `NationalSpire.DateGameState.Fired — public HashSet<string> Fired`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7f1acb75b0b8"></a>

## `NationalSpire.DateGameState.Facts — public List<DateGameFact> Facts`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f907b138b70a"></a>

## `NationalSpire.DateGameState.PendingChat — public string PendingChat`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c5331ecdaaf9"></a>

## `NationalSpire.DateGameState.PendingSpeaker — public string PendingSpeaker`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-36eca8e4a182"></a>

## `NationalSpire.DateGameState.PendingLine — public string PendingLine`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-daa2cdb220b4"></a>

## `NationalSpire.DateGameState.PendingUntil — public double PendingUntil`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0bd7e54465fe"></a>

## `NationalSpire.DateGameState.Snapshot — public string Snapshot`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-77a9c686e36f"></a>

## `NationalSpire.DateGameState.LastChat — public double LastChat`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-25c5be6f4d44"></a>

## `NationalSpire.DateGameState.LastSpeech — public double LastSpeech`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-db2e56e7151f"></a>

## `NationalSpire.DateGameRule.Trigger — public string Trigger`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f255bbabe7da"></a>

## `NationalSpire.DateGameRule.Enabled — public bool Enabled`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-67c9aadf9ee7"></a>

## `NationalSpire.DateGameRule.Chat — public bool Chat`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a4b0fc4d755f"></a>

## `NationalSpire.DateGameRule.Threshold — public double Threshold`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b58bb57f4804"></a>

## `NationalSpire.DateGameRule.Lines — public List<string> Lines`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5947a9bb0cb9"></a>

## `NationalSpire.DateGames.RequestChat(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string, double) — public static void RequestChat(CareerData data, DateGameState game, string person, string line, string context, double seconds)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateGameState.LastChat`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.PendingLine`；`NationalSpire.DateGameState.PendingSpeaker`；`NationalSpire.DateGameState.PendingUntil`；`NationalSpire.DateGames.ChatRequestSeconds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, person) + "："`

**赋值（含属性/字段和局部值）：**

- `game.LastChat` = `seconds`
- `game.PendingChat` = `CareerEngine.DisplayName(data, person) + "：" + line + (context.Length > 0 ? "\n" + context : "")`
- `game.PendingLine` = `line`
- `game.PendingSpeaker` = `person`
- `game.PendingUntil` = `seconds + ChatRequestSeconds`

<a id="symbol-85fed0382e62"></a>

## `NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState) — public static void ClearChatRequest(DateGameState game)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGames.FollowUp(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateGames.cs.md#symbol-7a75a34b8321)；[`NationalSpire.DateGames.TickChatRequest(NationalSpire.CareerData, NationalSpire.DateGameState, double, bool)`](DateGames.cs.md#symbol-924652d5a4a0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.PendingLine`；`NationalSpire.DateGameState.PendingSpeaker`；`NationalSpire.DateGameState.PendingUntil`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `game.PendingChat` = `game.PendingSpeaker = game.PendingLine = ""`
- `game.PendingLine` = `""`
- `game.PendingSpeaker` = `game.PendingLine = ""`
- `game.PendingUntil` = `0`

<a id="symbol-924652d5a4a0"></a>

## `NationalSpire.DateGames.TickChatRequest(NationalSpire.CareerData, NationalSpire.DateGameState, double, bool) — public static bool TickChatRequest(CareerData data, DateGameState game, double seconds, bool accepted = false)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState)`](DateGames.cs.md#symbol-85fed0382e62)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.PendingLine`；`NationalSpire.DateGameState.PendingSpeaker`；`NationalSpire.DateGameState.PendingUntil`；`NationalSpire.DateGameState.People`；`NationalSpire.DateGames.ChatRequestSeconds`；`NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, game.PendingSpeaker)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, game.PendingSpeaker) + "："`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, p)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, p) + "："`
- `NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState)`；输入表达式：`ClearChatRequest(game)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearChatRequest(game);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`game.People.FirstOrDefault(p => game.PendingChat.StartsWith(CareerEngine.DisplayName(data, p) + "：", StringComparison.Ordinal))`；返回值紧邻使用处：`BinaryExpressionSyntax: game.People.FirstOrDefault(p => game.PendingChat.StartsWith(CareerEngine.DisplayName(data, p) + "：", StringComparison.Ordinal)) ?? game.Host`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`game.PendingChat.Split('\n')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: game.PendingChat.Split('\n')[0]`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`game.PendingChat.StartsWith(CareerEngine.DisplayName(data, p) + "：", StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => game.PendingChat.StartsWith(CareerEngine.DisplayName(data, p) + "：", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`game.PendingLine.StartsWith(prefix, StringComparison.Ordinal)`；返回值紧邻使用处：`IfStatementSyntax: if (game.PendingLine.StartsWith(prefix, StringComparison.Ordinal)) game.PendingLine = game.PendingLine[prefix.Length..];`

**赋值（含属性/字段和局部值）：**

- `game.PendingLine` = `game.PendingChat.Split('\n')[0]`
- `game.PendingLine` = `game.PendingLine[prefix.Length..]`
- `game.PendingSpeaker` = `game.People.FirstOrDefault(p => game.PendingChat.StartsWith(CareerEngine.DisplayName(data, p) + "：", StringComparison.Ordinal)) ?? game.Host`
- `game.PendingUntil` = `seconds + ChatRequestSeconds`

<a id="symbol-e6d10e3baa71"></a>

## `NationalSpire.DateGames.ValidateContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool) — public static string? ValidateContext(CareerData data, PrivateConversation conversation, DateSceneRequest request, bool retained = false)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`object.ReferenceEquals(object?, object?)`；`string.IndexOf(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.PlayerFloor`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.Win`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.Snapshot`；`NationalSpire.DateSceneRequest.GameChatRequest`；`NationalSpire.DateSceneRequest.GameContext`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.GameMatchId`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, match.OpponentId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, match.OpponentId)}`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(match.PlayerSeconds ?? 0)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Time(match.PlayerSeconds ?? 0)}`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => ReferenceEquals(t.Scene, request))`；返回值紧邻使用处：`BinaryExpressionSyntax: retained || conversation.Turns.Any(t => ReferenceEquals(t.Scene, request))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == matchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.FirstOrDefault(m => m.Id == matchId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.LastOrDefault(r => r.MatchId == match.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Results.LastOrDefault(r => r.MatchId == match.Id)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(t.Scene, request)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => ReferenceEquals(t.Scene, request)`
- `string.IndexOf(string, System.StringComparison)`；输入表达式：`request.GameContext.IndexOf(legacyChat, StringComparison.Ordinal)`；返回值紧邻使用处：`IsPatternExpressionSyntax: request.GameContext.IndexOf(legacyChat, StringComparison.Ordinal) is >= 0 and var at`

**赋值（含属性/字段和局部值）：**

- `chat` = `belongs ? game!.PendingChat : ""`
- `chat` = `request.GameContext[(at + legacyChat.Length)..]`
- `request.GameChatRequest` = `belongs ? chat : ""`
- `request.GameContext` += `$"\n本局已经结束。玩家到达{match.PlayerFloor}层，用时{MatchRules.Time(match.PlayerSeconds ?? 0)}，" + (result == null ? "" : $"原版通关：{(result.Win ? "是" : "否")}；切磋结果：{result.Outcome}。") + $"\n{CareerEngine.DisplayName(data, match.OpponentId)}的模拟成绩：{match.OpponentFloor}层，{(match.OpponentWon ? "通关" : "未通关")}。" + "\n从结束对局的这一刻主动开始交流，结合本局表现与刚才的聊天说出感想。"`
- `request.GameContext` = `belongs ? game!.Snapshot + (chat.Length > 0 ? "\nNPC发起聊天：" + chat : "") : ""`
- `request.GameMatchId` = `belongs ? match!.Id : ""`

<a id="symbol-795971cadfe5"></a>

## `NationalSpire.DateGames.PromptContext(NationalSpire.DateSceneRequest) — public static string PromptContext(DateSceneRequest request)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.GameContext`；`NationalSpire.DateSceneRequest.GameMatchId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-89bfe888bf25"></a>

## `NationalSpire.DateGames.HistorySource(NationalSpire.PrivateTurn) — public static string HistorySource(PrivateTurn turn)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.DateSceneParty.SharedMemory(NationalSpire.CareerData, string, string)`](DateSceneParty.cs.md#symbol-5315c2e1b812)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.GameContext`；`NationalSpire.DateSceneRequest.GameMatchId`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7a75a34b8321"></a>

## `NationalSpire.DateGames.FollowUp(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest) — public static string? FollowUp(CareerData data, PrivateConversation conversation, DateSceneRequest request)`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-57be9d2323cb)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState)`](DateGames.cs.md#symbol-85fed0382e62)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`](PrivateMessages.cs.md#symbol-0e61d4a7bbb5)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.ResultTurnId`；`NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.GameMatchId`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateBusy(data, conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(data, conversation.PersonId) || conversation.Turns.Any(t => t.Status is "queued" or "sending")`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(request)`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Scene = Coop.CoopJson.Copy(request)`
- `NationalSpire.DateGames.ClearChatRequest(NationalSpire.DateGameState)`；输入表达式：`ClearChatRequest(game)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearChatRequest(game);`
- `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；输入表达式：`DateScenes.Validate(data, conversation, request)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateScenes.Validate(data, conversation, request) is { } error`
- `NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；输入表达式：`PrivateMessages.Enqueue(data, conversation.PersonId, request.GameEvent == "result" ? "（对局结束，请根据本局过程和结果主动继续约会对话。）" : "（玩家回应了聊天请求。请结合刚才提出的事情和双方当前的对局进程，主动接着说。）", queueAfterCurrent: request.GameEvent == "result")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Enqueue(data, conversation.PersonId, request.GameEvent == "result" ? "（对局结束，请根据本局过程和结果主动继续约会对话。）" : "（玩家回应了聊天请求。请结合刚才提出的事情和双方当前的对局进程，主动接着说。）", queueAfterCurrent: request.GameEvent == "result")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Id == game.ResultTurnId && !t.ReplyDeleted)`；返回值紧邻使用处：`BinaryExpressionSyntax: request.GameEvent == "result" && game.ResultTurnId.Length > 0 && conversation.Turns.Any(t => t.Id == game.ResultTurnId && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(data, conversation.PersonId) || conversation.Turns.Any(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.First(m => m.Id == request.GameMatchId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.First(m => m.Id == request.GameMatchId).DateGame`

**赋值（含属性/字段和局部值）：**

- `conversation.DateSceneStates[request.OfferId]` = `"active"`
- `game.ResultTurnId` = `turn.Id`
- `request.Ending` = `false`
- `request.GameInvitation` = `request.Opening = request.Ending = false`
- `request.Opening` = `request.Ending = false`
- `turn.Scene` = `Coop.CoopJson.Copy(request)`

<a id="symbol-5a10729d8f4b"></a>

## `NationalSpire.DateGames.Cancel(NationalSpire.CareerData, string, string) — public static string? Cancel(CareerData data, string host, string offer)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-3304c1dab1cc)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Status`；`NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`；输入表达式：`Find(data, host, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(data, host, offer)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, host)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, host).Offers`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, host).Offers.Where(o => o.MatchId == match.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var card in PrivateMessages.Conversation(data, host).Offers.Where(o => o.MatchId == match.Id)) card.State = "已取消";`

**赋值（含属性/字段和局部值）：**

- `card.State` = `"已取消"`
- `match.Status` = `"已取消"`

<a id="symbol-3304c1dab1cc"></a>

## `NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string) — public static CareerMatch? Find(CareerData data, string host, string offer)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-30dbc76323ef)；[`NationalSpire.DateGames.Cancel(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-5a10729d8f4b)；[`NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateGames.cs.md#symbol-e72b5454cf31)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Status`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.LastOrDefault(m => m.DateGame is { } g && g.Host == host && g.OfferId == offer && m.Status == "待赛")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => data.Matches.LastOrDefault(m => m.DateGame is { } g && g.Host == host && g.OfferId == offer && m.Status == "待赛")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-30dbc76323ef"></a>

## `NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string) — public static CareerMatch? AwaitingStart(CareerData data, string host, string offer)`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)；[`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](DateGameScreen.cs.md#symbol-60cf62536a73)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-3304c1dab1cc)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`；输入表达式：`Find(data, host, offer)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.PendingMatchId == null ? Find(data, host, offer) : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a63bde99754a"></a>

## `NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string) — public static CareerMatch? InProgress(CareerData data, string host, string offer)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.DateGameReturn.SavedMatch(NationalSpire.CareerData, string, string, MegaCrit.Sts2.Core.Saves.SerializableRun)`](DateGameReturn.cs.md#symbol-dcd87a3e58bb)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Status`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId && m.Status == "待赛" && m.DateGame is { } g && g.Host == host && g.OfferId == offer)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.PendingMatchId == null ? null : data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId && m.Status == "待赛" && m.DateGame is { } g && g.Host == host && g.OfferId == offer)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e72b5454cf31"></a>

## `NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>) — public static void Respond(CareerData data, PrivateConversation c, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneEffects.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int)`](DateSceneEffects.cs.md#symbol-02f9d7b85cad)

**调用：** `NationalSpire.DateGameState.DateGameState()`；[`NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-3304c1dab1cc)；[`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](DateSceneParty.cs.md#symbol-f9cb6b2133b0)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateAppointments.CreateMatch(NationalSpire.CareerData, string, int, int, string, string)`](PrivateAppointments.cs.md#symbol-6eff879f1d6c)；`NationalSpire.PrivateOffer.PrivateOffer()`；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`；`NationalSpire.DateGameState.People`；`NationalSpire.DateGameState.TurnId`；`NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`；`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateAppointments.CreateMatch(NationalSpire.CareerData, string, int, int, string, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameState.DateGameState()`；输入表达式：`new() { Host = c.PersonId, OfferId = offer.Id, TurnId = turn.Id, People = people }`；返回值紧邻使用处：`AssignmentExpressionSyntax: match.DateGame = new() { Host = c.PersonId, OfferId = offer.Id, TurnId = turn.Id, People = people }`
- `NationalSpire.DateGames.Find(NationalSpire.CareerData, string, string)`；输入表达式：`Find(data, c.PersonId, scene.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Find(data, c.PersonId, scene.OfferId) != null`
- `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；输入表达式：`DateSceneParty.People(data, offer, c.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneParty.People(data, offer, c.PersonId)`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, offer, c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateScenes.Available(data, offer, c)`
- `NationalSpire.PrivateAppointments.CreateMatch(NationalSpire.CareerData, string, int, int, string, string)`；输入表达式：`PrivateAppointments.CreateMatch(data, c.PersonId, data.Day, 0, "切磋", "约会")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateAppointments.CreateMatch(data, c.PersonId, data.Day, 0, "切磋", "约会")`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = "match", Id = "date-game-" + match.Id, TurnId = turn.Id, MatchId = match.Id, State = "已确认", Mode = "切磋", Season = data.Season, Day = SeasonCalendar.Day(data, data.Day), Title = "约会对局" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = "match", Id = "date-game-" + match.Id, TurnId = turn.Id, MatchId = match.Id, State = "已确认", Mode = "切磋", Season = data.Season, Day = SeasonCalendar.Day(data, data.Day), Title = "约会对局" }`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, data.Day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Day = SeasonCalendar.Day(data, data.Day)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.ContainsKey("Actor")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.ContainsKey("Actor")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.ContainsKey("DateGame")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.ContainsKey("DateGame") && (d.GetValueOrDefault("Actor") == person || people.Count == 1 && !d.ContainsKey("Actor"))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.Id == scene.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.FirstOrDefault(o => o.Id == scene.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`directives.LastOrDefault(d => d.ContainsKey("DateGame") && (d.GetValueOrDefault("Actor") == person || people.Count == 1 && !d.ContainsKey("Actor")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = directives.LastOrDefault(d => d.ContainsKey("DateGame") && (d.GetValueOrDefault("Actor") == person || people.Count == 1 && !d.ContainsKey("Actor")))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault("DateGame")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: answer?.GetValueOrDefault("DateGame")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.GetValueOrDefault("Actor")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.GetValueOrDefault("Actor") == person`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(new() { Kind = "match", Id = "date-game-" + match.Id, TurnId = turn.Id, MatchId = match.Id, State = "已确认", Mode = "切磋", Season = data.Season, Day = SeasonCalendar.Day(data, data.Day), Title = "约会对局" })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(new() { Kind = "match", Id = "date-game-" + match.Id, TurnId = turn.Id, MatchId = match.Id, State = "已确认", Mode = "切磋", Season = data.Season, Day = SeasonCalendar.Day(data, data.Day), Title = "约会对局" });`

**赋值（含属性/字段和局部值）：**

- `Day` = `SeasonCalendar.Day(data, data.Day)`
- `Host` = `c.PersonId`
- `Id` = `"date-game-" + match.Id`
- `Kind` = `"match"`
- `MatchId` = `match.Id`
- `Mode` = `"切磋"`
- `OfferId` = `offer.Id`
- `People` = `people`
- `Season` = `data.Season`
- `State` = `"已确认"`
- `Title` = `"约会对局"`
- `TurnId` = `turn.Id`
- `match.DateGame` = `new() { Host = c.PersonId, OfferId = offer.Id, TurnId = turn.Id, People = people }`

<a id="symbol-f6f62ee5a1dd"></a>

## `NationalSpire.DateGames.Defaults() — public static List<DateGameRule> Defaults()`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerData.DateGameRules`](CareerData.cs.md#symbol-630d9e8af5d8)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)；[`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`](DateGames.cs.md#symbol-c824a5233693)

**调用：** `NationalSpire.DateGameRule.DateGameRule()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameRule.Chat`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameRule.Trigger`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "act1", Chat = true, Lines = ["第一幕过了！刚才那场战斗我们聊聊吧。"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "act1", Chat = true, Lines = ["第一幕过了！刚才那场战斗我们聊聊吧。"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "act2", Chat = true, Lines = ["第二幕也过了，接下来需要调整哪些地方？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "act2", Chat = true, Lines = ["第二幕也过了，接下来需要调整哪些地方？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "boss-fast", Threshold = 60, Chat = true, Lines = ["首领战结束得好快。刚才决定胜负的是哪一步？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "boss-fast", Threshold = 60, Chat = true, Lines = ["首领战结束得好快。刚才决定胜负的是哪一步？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "elite-fast", Threshold = 30, Chat = true, Lines = ["精英这么快就打完了！刚才那套配合可以教教我吗？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "elite-fast", Threshold = 30, Chat = true, Lines = ["精英这么快就打完了！刚才那套配合可以教教我吗？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "fast", Threshold = 65, Chat = true, Lines = ["你走得好快！刚才选牌是怎么考虑的？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "fast", Threshold = 65, Chat = true, Lines = ["你走得好快！刚才选牌是怎么考虑的？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "floor-gap", Threshold = 12, Chat = true, Lines = ["我们的进度已经差了好多层，聊聊各自遇到的情况吧？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "floor-gap", Threshold = 12, Chat = true, Lines = ["我们的进度已经差了好多层，聊聊各自遇到的情况吧？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "gold-spent", Threshold = 300, Chat = true, Lines = ["这一层买了不少东西呢。想听你说说，这些东西准备怎么搭配？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "gold-spent", Threshold = 300, Chat = true, Lines = ["这一层买了不少东西呢。想听你说说，这些东西准备怎么搭配？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "npc-damage", Threshold = 35, Chat = true, Lines = ["这一层损失了好多生命，我想听听你的判断。"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "npc-damage", Threshold = 35, Chat = true, Lines = ["这一层损失了好多生命，我想听听你的判断。"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "npc-death", Chat = true, Lines = ["我这边倒下了……陪我想想刚才哪里可以更稳一点？"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "npc-death", Chat = true, Lines = ["我这边倒下了……陪我想想刚才哪里可以更稳一点？"] }`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new() { Trigger = "player-danger", Threshold = 25, Lines = ["你的生命有点低了，我们稳一点吧。"] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Trigger = "player-danger", Threshold = 25, Lines = ["你的生命有点低了，我们稳一点吧。"] }`

**赋值（含属性/字段和局部值）：**

- `Chat` = `true`
- `Lines` = `["你的生命有点低了，我们稳一点吧。"]`
- `Lines` = `["你走得好快！刚才选牌是怎么考虑的？"]`
- `Lines` = `["我们的进度已经差了好多层，聊聊各自遇到的情况吧？"]`
- `Lines` = `["我这边倒下了……陪我想想刚才哪里可以更稳一点？"]`
- `Lines` = `["第一幕过了！刚才那场战斗我们聊聊吧。"]`
- `Lines` = `["第二幕也过了，接下来需要调整哪些地方？"]`
- `Lines` = `["精英这么快就打完了！刚才那套配合可以教教我吗？"]`
- `Lines` = `["这一层买了不少东西呢。想听你说说，这些东西准备怎么搭配？"]`
- `Lines` = `["这一层损失了好多生命，我想听听你的判断。"]`
- `Lines` = `["首领战结束得好快。刚才决定胜负的是哪一步？"]`
- `Threshold` = `12`
- `Threshold` = `25`
- `Threshold` = `300`
- `Threshold` = `30`
- `Threshold` = `35`
- `Threshold` = `60`
- `Threshold` = `65`
- `Trigger` = `"act1"`
- `Trigger` = `"act2"`
- `Trigger` = `"boss-fast"`
- `Trigger` = `"elite-fast"`
- `Trigger` = `"fast"`
- `Trigger` = `"floor-gap"`
- `Trigger` = `"gold-spent"`
- `Trigger` = `"npc-damage"`
- `Trigger` = `"npc-death"`
- `Trigger` = `"player-danger"`

<a id="symbol-4695e14bac35"></a>

## `NationalSpire.DateGames.Label(string) — public static string Label(string trigger)`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c824a5233693"></a>

## `NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>) — public static List<DateGameRule> UpgradeRules(IEnumerable<DateGameRule> rules)`

来源：源码第 169 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)；[`NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`](DateGames.cs.md#symbol-2c3d1fff3942)

**调用：** [`NationalSpire.DateGames.Defaults()`](DateGames.cs.md#symbol-f6f62ee5a1dd)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGames.Defaults()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.Defaults()`；输入表达式：`Defaults()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Defaults()`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(r.Trigger)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => ids.Contains(r.Trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`result.All(old => old.Trigger != r.Trigger)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => result.All(old => old.Trigger != r.Trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`rules.Where(r => ids.Contains(r.Trigger)).DistinctBy(r => r.Trigger)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rules.Where(r => ids.Contains(r.Trigger)).DistinctBy(r => r.Trigger).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`defaults.Select(r => r.Trigger)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: defaults.Select(r => r.Trigger).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`defaults.Select(r => r.Trigger).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = defaults.Select(r => r.Trigger).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rules.Where(r => ids.Contains(r.Trigger)).DistinctBy(r => r.Trigger).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = rules.Where(r => ids.Contains(r.Trigger)).DistinctBy(r => r.Trigger).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`defaults.Where(r => result.All(old => old.Trigger != r.Trigger))`；返回值紧邻使用处：`ArgumentSyntax: defaults.Where(r => result.All(old => old.Trigger != r.Trigger))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rules.Where(r => ids.Contains(r.Trigger))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rules.Where(r => ids.Contains(r.Trigger)).DistinctBy`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange(defaults.Where(r => result.All(old => old.Trigger != r.Trigger)))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange(defaults.Where(r => result.All(old => old.Trigger != r.Trigger)));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2c3d1fff3942"></a>

## `NationalSpire.DateGames.Upgrade(NationalSpire.CareerData) — public static bool Upgrade(CareerData data)`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)

**调用：** [`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`](DateGames.cs.md#symbol-c824a5233693)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameRules`；`NationalSpire.CareerData.DateGameTiming`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameTiming.FastMinimumFloor`；`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`；输入表达式：`UpgradeRules(data.DateGameRules)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UpgradeRules(data.DateGameRules)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.DateGameRules.Select(r => r.Trigger)`；返回值紧邻使用处：`ArgumentSyntax: data.DateGameRules.Select(r => r.Trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rules.Select(r => r.Trigger)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rules.Select(r => r.Trigger).SequenceEqual`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`rules.Select(r => r.Trigger).SequenceEqual(data.DateGameRules.Select(r => r.Trigger))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !rules.Select(r => r.Trigger).SequenceEqual(data.DateGameRules.Select(r => r.Trigger))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(20, data.DateGameTiming.FastMinimumFloor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.DateGameTiming.FastMinimumFloor = Math.Max(20, data.DateGameTiming.FastMinimumFloor)`

**赋值（含属性/字段和局部值）：**

- `data.DateGameRules` = `rules`
- `data.DateGameTiming.FastMinimumFloor` = `Math.Max(20, data.DateGameTiming.FastMinimumFloor)`
