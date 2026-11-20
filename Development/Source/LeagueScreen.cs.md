# LeagueScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`895F6B01ECA93ED348DE2CAA9E542B4B60F491C14CCE71FCC4B40D953F01B349`。来源：[源码](../../LeagueScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] LeaguePages=["集卡","开包","收藏","交易","组卡","对战"];
private static readonly string[] SuitColors=["8faab5","68d7ec","f0bf6d","ed95ce"];
private int _leaguePage;
private string _leagueFilter="";
private bool _leagueBusy;
private string _leagueRival="";
private HashSet<string>? _poolDraft;
private readonly LinkedList<((CardModel,bool) Key,MegaCrit.Sts2.Core.Nodes.Cards.NCard Face)> _recentFaces=new();
private static readonly AudioStreamMP3?[] PackSounds=new AudioStreamMP3?[3];
```

<a id="symbol-0cfda266604d"></a>

## `NationalSpire.CareerScreen.LeaguePage(string) — private static bool LeaguePage(string s)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.LeaguePages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`LeaguePages.Contains(s)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>LeaguePages.Contains(s)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-74fb1d846f7f"></a>

## `NationalSpire.CareerScreen.LeagueSound(string) — private static void LeagueSound(string sound)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Animate()`](LeagueArenaScreen.cs.md#symbol-920ca2d97f7a)；[`NationalSpire.CareerScreen.Opening.Reveal()`](LeagueArenaScreen.cs.md#symbol-a63c53a4d9b3)；[`NationalSpire.CareerScreen.RankedReport(NationalSpire.LeagueReceipt, bool)`](LeagueArenaScreen.cs.md#symbol-53c6da8a2b7e)

**调用：** `MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；输入表达式：`SfxCmd.Play(sound)`；返回值紧邻使用处：`ExpressionStatementSyntax: SfxCmd.Play(sound);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-46069e214cbd"></a>

## `NationalSpire.CareerScreen.LeagueGo(string) — private void LeagueGo(string dest)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.CareerScreen.MirrorAppointmentArena(NationalSpire.CareerData, NationalSpire.CareerMatch)`](LeagueArenaScreen.cs.md#symbol-6ac7616bf9f0)；[`NationalSpire.CareerScreen.OpenLeagueResult(Godot.Control, NationalSpire.ICareerSession?, string, bool?, NationalSpire.LeagueFinish?)`](LeagueNativeMatch.cs.md#symbol-c1cb4b5f9df0)；[`NationalSpire.CareerScreen.OpenTeamReceipt(Godot.Control, NationalSpire.ICareerSession, string)`](LeagueTeamMatch.cs.md#symbol-36421958cb8a)

**调用：** [`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._deckOffset`；`NationalSpire.CareerScreen._deckQuery`；`NationalSpire.CareerScreen._leagueFilter`；`NationalSpire.CareerScreen._leaguePage`；`NationalSpire.CareerScreen._poolDraft`；`NationalSpire.CareerScreen.OpenLifePage(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage(dest)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenLifePage(dest);`

**赋值（含属性/字段和局部值）：**

- `_deckOffset` = `0`
- `_deckQuery` = `""`
- `_leagueFilter` = `""`
- `_leaguePage` = `0`
- `_poolDraft` = `null`

<a id="symbol-c5858ab8fb69"></a>

## `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?) — private void LeagueAction(string action,string id="",int n=0,Control? origin=null)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply(string)`](LeagueDeckEditor.cs.md#symbol-904d637856af)；[`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.CareerScreen.OpenLeagueResult(Godot.Control, NationalSpire.ICareerSession?, string, bool?, NationalSpire.LeagueFinish?)`](LeagueNativeMatch.cs.md#symbol-c1cb4b5f9df0)

**调用：** [`Done()`](LeagueScreen.cs.md#symbol-d964f7e2b387)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)；`Godot.Control.GetGlobalRect()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Rect2.GetCenter()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `Done()`；`NationalSpire.CareerScreen._deckShelf`；`NationalSpire.CareerScreen._deckSlots`；`NationalSpire.CareerScreen._deckStrip`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Done()`；输入表达式：`Done()`；返回值紧邻使用处：`ExpressionStatementSyntax: Done();`
- `Godot.Control.GetGlobalRect()`；输入表达式：`.GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetGlobalRect().GetCenter`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_deckStrip)`；返回值紧邻使用处：`BinaryExpressionSyntax: _deckStrip!=null&&IsInstanceValid(_deckStrip)`
- `Godot.Rect2.GetCenter()`；输入表达式：`.GetGlobalRect().GetCenter()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: (source??origin)?.GetGlobalRect().GetCenter()`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("league",action,id,n,accepted:Done)`；返回值紧邻使用处：`IfStatementSyntax: if(MultiplayerCommand("league",action,id,n,accepted:Done))return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(err,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(err,true);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(ViewData);`
- `NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`；输入表达式：`LeagueCards.Apply(ViewData,action,id,n)`；返回值紧邻使用处：`IsPatternExpressionSyntax: LeagueCards.Apply(ViewData,action,id,n) is {} err`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_deckShelf.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: action=="add"?_deckShelf.GetValueOrDefault(id):origin`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_deckSlots.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: action=="remove"?_deckSlots.GetValueOrDefault(id):action=="add"?_deckShelf.GetValueOrDefault(id):origin`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d964f7e2b387"></a>

## `Done() — void Done()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)

**调用：** [`NationalSpire.CareerScreen.DeckMotion(string, string, Godot.Vector2, int)`](LeagueDeckEditor.cs.md#symbol-669631bd65bf)；[`NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-9fa96420666c)；[`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`](LeagueScreen.cs.md#symbol-d1f631d136b9)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.List<T>.ToArray()`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerScreen._deckOffset`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen.DeckMotion(string, string, Godot.Vector2, int)`；`NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`；`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.LeagueAlbum.LastDuel`；`NationalSpire.LeagueAlbum.Latest`；`NationalSpire.LeagueFinish.Match`；`NationalSpire.LeagueReceipt.Fight`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DeckMotion(string, string, Godot.Vector2, int)`；输入表达式：`DeckMotion(action,action=="swap"?id.Split('|')[1]:id,from.Value,_renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=DeckMotion(action,action=="swap"?id.Split('|')[1]:id,from.Value,_renderVersion)`
- `NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`；输入表达式：`LeagueAward(receipt)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueAward(receipt);`
- `NationalSpire.CareerScreen.LeagueReveal(string[], bool)`；输入表达式：`LeagueReveal(ViewData.Life.League.Latest.ToArray(),true)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueReveal(ViewData.Life.League.Latest.ToArray(),true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(position,_renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=RestoreScrollAsync(position,_renderVersion)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`id.Split('|')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: id.Split('|')[1]`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`ViewData.Life.League.Latest.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: ViewData.Life.League.Latest.ToArray()`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<LeagueFinish>(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: System.Text.Json.JsonSerializer.Deserialize<LeagueFinish>(id)?.Match`

**赋值（含属性/字段和局部值）：**

- `_` = `DeckMotion(action,action=="swap"?id.Split('|')[1]:id,from.Value,_renderVersion)`
- `_` = `RestoreScrollAsync(position,_renderVersion)`
- `_deckOffset` = `action=="captain"?0:deckOffset`

<a id="symbol-df3facf7c8b0"></a>

## `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int) — private static HBoxContainer LeagueRow(Control parent,int gap=12)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`CountMark(Godot.Texture2D, string, int, Godot.Color)`](LeagueDeckEditor.cs.md#symbol-c1f645acc6ef)；[`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`](LeagueScreen.cs.md#symbol-86478d7251cc)；[`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`](LeagueScreen.cs.md#symbol-d1f631d136b9)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",gap)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",gap);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c7e40485fba6"></a>

## `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color) — private static Label LeagueNumber(string value,int width,Color color)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`CountMark(Godot.Texture2D, string, int, Godot.Color)`](LeagueDeckEditor.cs.md#symbol-c1f645acc6ef)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`](LeagueScreen.cs.md#symbol-69ed9740453e)；[`NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`](LeagueScreen.cs.md#symbol-86478d7251cc)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text.CustomMinimumSize=new(width,0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value,18,color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(value,18,color)`

**赋值（含属性/字段和局部值）：**

- `text.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `text.CustomMinimumSize` = `new(width,0)`
- `text.HorizontalAlignment` = `HorizontalAlignment.Center`
- `text.VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-86478d7251cc"></a>

## `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string) — private void LeagueMetric(Control row,string title,string value)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)

**调用：** [`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(LeagueNumber(title,40,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(LeagueNumber(title,40,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`group.AddChild(LeagueNumber(value,70,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: group.AddChild(LeagueNumber(value,70,_gold));`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber(title,40,_muted)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber(title,40,_muted)`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber(value,70,_gold)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber(value,70,_gold)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(row,8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(row,8)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6b4f6cdfeec1"></a>

## `NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData) — private void LeagueScreen(CareerData d)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`](LeagueScreen.cs.md#symbol-ac3b4cd4f128)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueGo(string)`](LeagueScreen.cs.md#symbol-46069e214cbd)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`](LeagueScreen.cs.md#symbol-86478d7251cc)；[`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`](LeagueScreen.cs.md#symbol-d1f631d136b9)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.GroupName(string)`](LeagueCards.cs.md#symbol-92f715052b3d)；[`NationalSpire.LeagueCards.Offers(NationalSpire.CareerData)`](LeagueCards.cs.md#symbol-bad4f2bcbcee)；[`NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-0192fefb8352)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueFoil.LeagueFoil()`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.ToArray()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Min(int, int)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._leagueFilter`；`NationalSpire.CareerScreen._leaguePage`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._poolDraft`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Action`；`NationalSpire.CareerScreen.LeagueControl.Filter`；`NationalSpire.CareerScreen.LeagueControl.Primary`；`NationalSpire.CareerScreen.LeagueGo(string)`；`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；`NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；`NationalSpire.CareerScreen.LeaguePages`；`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.LeagueAlbum.BlueWait`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.GoldWait`；`NationalSpire.LeagueAlbum.Latest`；`NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueAlbum.StandardDecks`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`；`NationalSpire.LeagueCards.Grades`；`NationalSpire.LeagueCards.GroupName(string)`；`NationalSpire.LeagueCards.Offers(NationalSpire.CareerData)`；`NationalSpire.LeagueCards.PackCost`；`NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Roles`；`NationalSpire.LeagueFoil.Wide`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；输入表达式：`Count(c=>c.Group=="COLORLESS")`；返回值紧邻使用处：`InterpolationSyntax: {Count(c=>c.Group=="COLORLESS")}`
- `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；输入表达式：`Count(c=>c.Tier==1)`；返回值紧邻使用处：`InterpolationSyntax: {Count(c=>c.Tier==1)}`
- `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；输入表达式：`Count(c=>c.Tier==2)`；返回值紧邻使用处：`InterpolationSyntax: {Count(c=>c.Tier==2)}`
- `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；输入表达式：`Count(c=>c.Tier==3)`；返回值紧邻使用处：`InterpolationSyntax: {Count(c=>c.Tier==3)}`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",10);`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(banner)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(banner);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(LeagueButton("整理为新版 35 张牌组",()=>LeagueAction("captain",album.Captain),235))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(LeagueButton("整理为新版 35 张牌组",()=>LeagueAction("captain",album.Captain),235));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(roleRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(roleRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("选择出战职业，领取该职业的三十五张起始牌。",22,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("选择出战职业，领取该职业的三十五张起始牌。",22,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(LeagueButton("前往开包   →",()=>LeagueGo("开包"),200))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(LeagueButton("前往开包   →",()=>LeagueGo("开包"),200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`banner.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: banner.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(LeagueButton("进入   →",()=>LeagueGo(dest),120))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(LeagueButton("进入   →",()=>LeagueGo(dest),120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(note,17,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(note,17,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(title,25,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(title,25,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(roles)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(roles);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"卡包职业    {draft.Count} 已选    /    至少 {min} 个",23,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"卡包职业    {draft.Count} 已选    /    至少 {min} 个",23,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text("国运尖塔  /  职业联赛",16,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text("国运尖塔  /  职业联赛",16,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text(opening?"联赛典藏卡包":"尖塔藏牌馆",49,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text(opening?"联赛典藏卡包":"尖塔藏牌馆",49,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text(opening?$"每包五张   ·   {LeagueCards.Pool(album).Length} 个职业与无色牌":"收录原画，构筑牌组，迎战联赛选手。",21,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text(opening?$"每包五张   ·   {LeagueCards.Pool(album).Length} 个职业与无色牌":"收录原画，构筑牌组，迎战联赛选手。",21,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(LeagueButton(tag==""?"全部":tag,()=>{_leagueFilter=tag;_leaguePage=0;Render();},98,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter))`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(LeagueButton(tag==""?"全部":tag,()=>{_leagueFilter=tag;_leaguePage=0;Render();},98,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(LeagueButton("取消",()=>{_poolDraft=null;Render();},110))`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(LeagueButton("取消",()=>{_poolDraft=null;Render();},110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(save)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(save);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(LeagueButton("编辑卡池",()=>{_poolDraft=LeagueCards.Pool(album).ToHashSet();Render();},158))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(LeagueButton("编辑卡池",()=>{_poolDraft=LeagueCards.Pool(album).ToHashSet();Render();},158));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(LeagueButton("回顾上次开包",()=>LeagueReveal(album.Latest.ToArray()),180))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(LeagueButton("回顾上次开包",()=>LeagueReveal(album.Latest.ToArray()),180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`nav.AddChild(UnderlineTab(name=="集卡"?"总览":name,()=>LeagueGo(name),_lifeSection==name,105))`；返回值紧邻使用处：`ExpressionStatementSyntax: nav.AddChild(UnderlineTab(name=="集卡"?"总览":name,()=>LeagueGo(name),_lifeSection==name,105));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`roleRow.AddChild(LeagueButton(LeagueCards.GroupName(id),()=>LeagueAction("captain",id),155,album.Captain==id,emblem:role.IconTexture))`；返回值紧邻使用处：`ExpressionStatementSyntax: roleRow.AddChild(LeagueButton(LeagueCards.GroupName(id),()=>LeagueAction("captain",id),155,album.Captain==id,emblem:role.IconTexture));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`roles.AddChild(LeagueButton(LeagueCards.GroupName(id),()=>{if(!draft.Remove(id))draft.Add(id);Render();},155,draft.Contains(id),emblem:role.IconTexture))`；返回值紧邻使用处：`ExpressionStatementSyntax: roles.AddChild(LeagueButton(LeagueCards.GroupName(id),()=>{if(!draft.Remove(id))draft.Add(id);Render();},155,draft.Contains(id),emblem:role.IconTexture));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{Position=new(42,32),CustomMinimumSize=new(620,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{Position=new(42,32),CustomMinimumSize=new(620,0)}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,opening?270:300)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,opening?270:300)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(42,32)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position=new(42,32)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(620,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(620,0)`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d)<LeagueCards.PackCost*count`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(LeagueCards.PackCost*count)`；返回值紧邻使用处：`BinaryExpressionSyntax: (count==1?"开启一包":"开启十包")+"   "+CareerMoney.Format(LeagueCards.PackCost*count)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Card()`
- `NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`DeckEditor(d,deck)`；返回值紧邻使用处：`ExpressionStatementSyntax: DeckEditor(d,deck);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(panel)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("captain",album.Captain)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("captain",album.Captain)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("captain",id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("captain",id)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("pack",n:count)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("pack",n:count)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("pool",ids)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueAction("pool",ids);`
- `NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`；输入表达式：`LeagueArena(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueArena(d);`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("保存卡池",()=>{var ids=System.Text.Json.JsonSerializer.Serialize(draft.Order().ToArray());_poolDraft=null;LeagueAction("pool",ids);},155,kind:LeagueControl.Primary)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("保存卡池",()=>{var ids=System.Text.Json.JsonSerializer.Serialize(draft.Order().ToArray());_poolDraft=null;LeagueAction("pool",ids);},155,kind:LeagueControl.Primary)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("编辑卡池",()=>{_poolDraft=LeagueCards.Pool(album).ToHashSet();Render();},158)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("编辑卡池",()=>{_poolDraft=LeagueCards.Pool(album).ToHashSet();Render();},158)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("回顾上次开包",()=>LeagueReveal(album.Latest.ToArray()),180)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("回顾上次开包",()=>LeagueReveal(album.Latest.ToArray()),180)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("进入   →",()=>LeagueGo(dest),120)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("进入   →",()=>LeagueGo(dest),120)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("前往开包   →",()=>LeagueGo("开包"),200)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("前往开包   →",()=>LeagueGo("开包"),200)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("取消",()=>{_poolDraft=null;Render();},110)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("取消",()=>{_poolDraft=null;Render();},110)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("整理为新版 35 张牌组",()=>LeagueAction("captain",album.Captain),235)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("整理为新版 35 张牌组",()=>LeagueAction("captain",album.Captain),235)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton((count==1?"开启一包":"开启十包")+"   "+CareerMoney.Format(LeagueCards.PackCost*count),()=>LeagueAction("pack",n:count),235,kind:count==10?LeagueControl.Primary:LeagueControl.Action)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton((count==1?"开启一包":"开启十包")+"   "+CareerMoney.Format(LeagueCards.PackCost*count),()=>LeagueAction("pack",n:count),235,kind:count==10?LeagueControl.Primary:LeagueControl.Action)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(LeagueCards.GroupName(id),()=>{if(!draft.Remove(id))draft.Add(id);Render();},155,draft.Contains(id),emblem:role.IconTexture)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton(LeagueCards.GroupName(id),()=>{if(!draft.Remove(id))draft.Add(id);Render();},155,draft.Contains(id),emblem:role.IconTexture)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(LeagueCards.GroupName(id),()=>LeagueAction("captain",id),155,album.Captain==id,emblem:role.IconTexture)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton(LeagueCards.GroupName(id),()=>LeagueAction("captain",id),155,album.Captain==id,emblem:role.IconTexture)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(tag==""?"全部":tag,()=>{_leagueFilter=tag;_leaguePage=0;Render();},98,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton(tag==""?"全部":tag,()=>{_leagueFilter=tag;_leaguePage=0;Render();},98,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter)`
- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`LeagueGo("开包")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueGo("开包")`
- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`LeagueGo(dest)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueGo(dest)`
- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`LeagueGo(name)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueGo(name)`
- `NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；输入表达式：`LeagueGrid(list.OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title),d,_lifeSection)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueGrid(list.OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title),d,_lifeSection);`
- `NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；输入表达式：`LeagueGrid(results.OrderByDescending(card=>card.Tier),d,"回顾")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueGrid(results.OrderByDescending(card=>card.Tier),d,"回顾");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(line,"金卡保底",$"{album.GoldWait} / 80 包")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(line,"金卡保底",$"{album.GoldWait} / 80 包");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(line,"蓝卡保底",$"{album.BlueWait} / 10 包")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(line,"蓝卡保底",$"{album.BlueWait} / 10 包");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(row,"金卡",$"{Count(c=>c.Tier==2)} / 5")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(row,"金卡",$"{Count(c=>c.Tier==2)} / 5");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(row,"蓝卡",$"{Count(c=>c.Tier==1)} / 10")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(row,"蓝卡",$"{Count(c=>c.Tier==1)} / 10");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(row,"牌组",$"{deck.Values.Sum()} / {LeagueCards.DeckSize}")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(row,"牌组",$"{deck.Values.Sum()} / {LeagueCards.DeckSize}");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(row,"无色",$"{Count(c=>c.Group=="COLORLESS")} / 5")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(row,"无色",$"{Count(c=>c.Group=="COLORLESS")} / 5");`
- `NationalSpire.CareerScreen.LeagueMetric(Godot.Control, string, string)`；输入表达式：`LeagueMetric(row,"先古",$"{Count(c=>c.Tier==3)} / 1")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueMetric(row,"先古",$"{Count(c=>c.Tier==3)} / 1");`
- `NationalSpire.CareerScreen.LeagueReveal(string[], bool)`；输入表达式：`LeagueReveal(album.Latest.ToArray())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueReveal(album.Latest.ToArray())`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(_content,14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(_content,14)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(_content,20)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(_content,20)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(_content,26)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(_content,26)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(_content)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(_content)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(box)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(box)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(copy)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(copy)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(_content,24,secondary:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TabStrip(_content,24,secondary:true)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("国运尖塔  /  职业联赛",16,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("国运尖塔  /  职业联赛",16,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("选择出战职业，领取该职业的三十五张起始牌。",22,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("选择出战职业，领取该职业的三十五张起始牌。",22,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"卡包职业    {draft.Count} 已选    /    至少 {min} 个",23,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text($"卡包职业    {draft.Count} 已选    /    至少 {min} 个",23,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(note,17,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(note,17,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(opening?"联赛典藏卡包":"尖塔藏牌馆",49,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(opening?"联赛典藏卡包":"尖塔藏牌馆",49,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(opening?$"每包五张   ·   {LeagueCards.Pool(album).Length} 个职业与无色牌":"收录原画，构筑牌组，迎战联赛选手。",21,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(opening?$"每包五张   ·   {LeagueCards.Pool(album).Length} 个职业与无色牌":"收录原画，构筑牌组，迎战联赛选手。",21,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title,25,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(title,25,_gold)`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab(name=="集卡"?"总览":name,()=>LeagueGo(name),_lifeSection==name,105)`；返回值紧邻使用处：`ArgumentSyntax: UnderlineTab(name=="集卡"?"总览":name,()=>LeagueGo(name),_lifeSection==name,105)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(album)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LeagueCards.Deck(album)?.Values.Sum()`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(album)`；返回值紧邻使用处：`IsPatternExpressionSyntax: LeagueCards.Deck(album) is {} deck`
- `NationalSpire.LeagueCards.GroupName(string)`；输入表达式：`LeagueCards.GroupName(id)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.GroupName(id)`
- `NationalSpire.LeagueCards.Offers(NationalSpire.CareerData)`；输入表达式：`LeagueCards.Offers(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _lifeSection=="交易"?LeagueCards.Offers(d):LeagueCards.Catalog.Values.Where(c=>album.Owned.GetValueOrDefault(c.Id)>0)`
- `NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Pool(album)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Pool(album).Length`
- `NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Pool(album)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Pool(album).ToHashSet`
- `NationalSpire.LeagueFoil.LeagueFoil()`；输入表达式：`new LeagueFoil{Wide=true,CustomMinimumSize=new(0,opening?270:300)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueFoil{Wide=true,CustomMinimumSize=new(0,opening?270:300)}`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(LeagueCards.Grades,tag)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(LeagueCards.Grades,tag)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`draft.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.Add(id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`album.StandardDecks.Contains(album.Captain)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !album.StandardDecks.Contains(album.Captain)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`draft.Contains(id)`；返回值紧邻使用处：`ArgumentSyntax: draft.Contains(id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`draft.Remove(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !draft.Remove(id)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`.Values.Sum()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LeagueCards.Deck(album)?.Values.Sum()`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`deck.Values.Sum()`；返回值紧邻使用处：`InterpolationSyntax: {deck.Values.Sum()}`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`draft.Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: draft.Order().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`album.Latest.Any(LeagueCards.Catalog.ContainsKey)`；返回值紧邻使用处：`IfStatementSyntax: if(album.Latest.Any(LeagueCards.Catalog.ContainsKey)){                     line.AddChild(LeagueButton("回顾上次开包",()=>LeagueReveal(album.Latest.ToArray()),180));                     var results=album.Latest.Select(id=>LeagueCards.Catalog.GetValueOrDefault(id)).OfType<LeagueCards.Entry>();                     LeagueGrid(results.OrderByDescending(card=>card.Tier),d,"回顾");                 }`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[]{""}.Concat(LeagueCards.Grades)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var tag in new[]{""}.Concat(LeagueCards.Grades)){filters.AddChild(LeagueButton(tag==""?"全部":tag,()=>{_leagueFilter=tag;_leaguePage=0;Render();},98,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter));}`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`album.Owned.Count(x=>x.Value>0)`；返回值紧邻使用处：`InterpolationSyntax: {album.Owned.Count(x=>x.Value>0)}`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`list.OrderByDescending(c=>c.Tier)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: list.OrderByDescending(c=>c.Tier).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`results.OrderByDescending(card=>card.Tier)`；返回值紧邻使用处：`ArgumentSyntax: results.OrderByDescending(card=>card.Tier)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`album.Latest.Select(id=>LeagueCards.Catalog.GetValueOrDefault(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: album.Latest.Select(id=>LeagueCards.Catalog.GetValueOrDefault(id)).OfType<LeagueCards.Entry>`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`deck.Where(x=>LeagueCards.Catalog.ContainsKey(x.Key)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =deck.Where(x=>LeagueCards.Catalog.ContainsKey(x.Key)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`draft.Order().ToArray()`；返回值紧邻使用处：`ArgumentSyntax: draft.Order().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`LeagueCards.Pool(album).ToHashSet()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _poolDraft=LeagueCards.Pool(album).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Where(x=>LeagueCards.Catalog.ContainsKey(x.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: deck.Where(x=>LeagueCards.Catalog.ContainsKey(x.Key)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>album.Owned.GetValueOrDefault(c.Id)>0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _lifeSection=="交易"?LeagueCards.Offers(d):LeagueCards.Catalog.Values.Where(c=>album.Owned.GetValueOrDefault(c.Id)>0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`list.Where(c=>LeagueCards.Grades[c.Tier]==_leagueFilter)`；返回值紧邻使用处：`AssignmentExpressionSyntax: list=list.Where(c=>LeagueCards.Grades[c.Tier]==_leagueFilter)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`LeagueCards.Catalog.ContainsKey(x.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>LeagueCards.Catalog.ContainsKey(x.Key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`album.Owned.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: album.Owned.GetValueOrDefault(c.Id)>0`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`LeagueCards.Catalog.GetValueOrDefault(id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>LeagueCards.Catalog.GetValueOrDefault(id)`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`album.Latest.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: album.Latest.ToArray()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`album.Latest.Select(id=>LeagueCards.Catalog.GetValueOrDefault(id)).OfType<LeagueCards.Entry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =album.Latest.Select(id=>LeagueCards.Catalog.GetValueOrDefault(id)).OfType<LeagueCards.Entry>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`list.OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title)`；返回值紧邻使用处：`ArgumentSyntax: list.OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(6,LeagueCards.Roles.Length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(6,LeagueCards.Roles.Length)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(draft.Order().ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =System.Text.Json.JsonSerializer.Serialize(draft.Order().ToArray())`

**赋值（含属性/字段和局部值）：**

- `_leagueFilter` = `tag`
- `_leaguePage` = `0`
- `_poolDraft` = `LeagueCards.Pool(album).ToHashSet()`
- `_poolDraft` = `null`
- `b.Disabled` = `CareerMoney.Balance(d)<LeagueCards.PackCost*count`
- `CustomMinimumSize` = `new(0,opening?270:300)`
- `CustomMinimumSize` = `new(620,0)`
- `list` = `list.Where(c=>LeagueCards.Grades[c.Tier]==_leagueFilter)`
- `panel.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Position` = `new(42,32)`
- `save.Disabled` = `draft.Count<min`
- `Wide` = `true`

<a id="symbol-ac3b4cd4f128"></a>

## `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>) — int Count(Func<LeagueCards.Entry,bool> pred)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Catalog`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`counts.Where(x=>pred(LeagueCards.Catalog[x.Key])).Sum(x=>x.Value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>counts.Where(x=>pred(LeagueCards.Catalog[x.Key])).Sum(x=>x.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`counts.Where(x=>pred(LeagueCards.Catalog[x.Key]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: counts.Where(x=>pred(LeagueCards.Catalog[x.Key])).Sum`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`pred(LeagueCards.Catalog[x.Key])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>pred(LeagueCards.Catalog[x.Key])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ac7580704af1"></a>

## `NationalSpire.CareerScreen.ShelfTop(Godot.Control) — private int ShelfTop(Control page)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`Turn(int)`](LeagueScreen.cs.md#symbol-450b6e2d277b)

**调用：** `Godot.CanvasItem.GetGlobalTransform()`；`Godot.Transform2D.AffineInverse()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`_content.GetGlobalTransform()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _content.GetGlobalTransform().AffineInverse`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`_content.GetGlobalTransform().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: _content.GetGlobalTransform().AffineInverse()*page.GlobalPosition`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,(int)(_content.GetGlobalTransform().AffineInverse()*page.GlobalPosition).Y-60)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Math.Max(0,(int)(_content.GetGlobalTransform().AffineInverse()*page.GlobalPosition).Y-60)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-315dac8c42bd"></a>

## `NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?) — private void LeagueGrid(IEnumerable<LeagueCards.Entry> source,CareerData d,string mode,Control? dest=null)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Browse()`](LeagueDeckEditor.cs.md#symbol-3160728b0b5b)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`Turn(int)`](LeagueScreen.cs.md#symbol-450b6e2d277b)

**调用：** [`FitPage()`](LeagueScreen.cs.md#symbol-be8839d87520)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`](LeagueDeckEditor.cs.md#symbol-947b5653f588)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-de594f00e6a0)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`](LeagueCards.cs.md#symbol-ee6cdcfca4b6)；[`NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-532fff3c1eac)；[`Turn(int)`](LeagueScreen.cs.md#symbol-450b6e2d277b)；`Godot.Color.Color(string)`；`Godot.Color.Lerp(Godot.Color, float)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `FitPage()`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._deckQuery`；`NationalSpire.CareerScreen._deckShelf`；`NationalSpire.CareerScreen._leaguePage`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`；`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；`NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Bids`；`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`；`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；`NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string)`；`Turn(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `FitPage()`；输入表达式：`FitPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: FitPage();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("33434a")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Color("33434a").Lerp`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[c.Tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(SuitColors[c.Tier])`
- `Godot.Color.Lerp(Godot.Color, float)`；输入表达式：`new Color("33434a").Lerp(new Color(SuitColors[c.Tier]),.32f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: plaque.BorderColor=new Color("33434a").Lerp(new Color(SuitColors[c.Tier]),.32f)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation",12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`rail.AddThemeStyleboxOverride("panel",plaque)`；返回值紧邻使用处：`ExpressionStatementSyntax: rail.AddThemeStyleboxOverride("panel",plaque);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer{Columns=5}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new GridContainer{Columns=5}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(add)`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(add);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(LeagueButton("出售",()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell)),85))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(LeagueButton("出售",()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell)),85));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(LeagueNumber("持有 "+owned,76,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(LeagueNumber("持有 "+owned,76,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(LeagueNumber("持有 × "+owned,100,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(LeagueNumber("持有 × "+owned,100,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(next);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(prev)`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(prev);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(Text($"{_leaguePage+1} / {pages}",18,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(Text($"{_leaguePage+1} / {pages}",18,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(rail)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(rail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`dest.AddChild(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: dest.AddChild(page);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`dest.AddChild(Text(mode=="交易"?"今天还没有这种稀有度的挂牌。":mode=="组卡"&&_deckQuery.Length>0?"没有符合搜索条件的牌。":"还没有收录这类卡牌。",20,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: dest.AddChild(Text(mode=="交易"?"今天还没有这种稀有度的挂牌。":mode=="组卡"&&_deckQuery.Length>0?"没有符合搜索条件的牌。":"还没有收录这类卡牌。",20,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(tile)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(tile);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(grid);`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`body.GetChild<Control>(0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _deckShelf[c.Id]=body.GetChild<Control>(0)`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer{SizeFlagsHorizontal=SizeFlags.ShrinkCenter}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer{SizeFlagsHorizontal=SizeFlags.ShrinkCenter}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,38)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bar.CustomMinimumSize=new(0,38)`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d)<price`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(price)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(price)`
- `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；输入表达式：`ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell))`
- `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；输入表达式：`DeckKey("add","加入","加入一张"+c.Title,()=>LeagueAction("add",c.Id,origin:tile),qty<owned&&LeagueCards.Limit(deck,c,role:a.Captain)==null)`；返回值紧邻使用处：`ConditionalExpressionSyntax: full?DeckKey("swap","替换","用"+c.Title+"替换牌组中的一张牌",()=>DeckSwap(c,tile),qty<owned&&deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c)))                     :DeckKey("add","加入","加入一张"+c.Title,()=>LeagueAction("add",c.Id,origin:tile),qty<owned&&LeagueCards.Limit(deck,c,role:a.Captain)==null)`
- `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；输入表达式：`DeckKey("swap","替换","用"+c.Title+"替换牌组中的一张牌",()=>DeckSwap(c,tile),qty<owned&&deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c)))`；返回值紧邻使用处：`ConditionalExpressionSyntax: full?DeckKey("swap","替换","用"+c.Title+"替换牌组中的一张牌",()=>DeckSwap(c,tile),qty<owned&&deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c)))                     :DeckKey("add","加入","加入一张"+c.Title,()=>LeagueAction("add",c.Id,origin:tile),qty<owned&&LeagueCards.Limit(deck,c,role:a.Captain)==null)`
- `NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`；输入表达式：`DeckSwap(c,tile)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>DeckSwap(c,tile)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("add",c.Id,origin:tile)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("add",c.Id,origin:tile)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("buy",c.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("buy",c.Id)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("sell",c.Id,sell)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("sell",c.Id,sell)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("出售",()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell)),85)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("出售",()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell)),85)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("上一页",()=>Turn(_leaguePage-1),120)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("上一页",()=>Turn(_leaguePage-1),120)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("下一页",()=>Turn(_leaguePage+1),120)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("下一页",()=>Turn(_leaguePage+1),120)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(CareerMoney.Format(price),()=>LeagueAction("buy",c.Id),156,emblem:NavigationIcon("coins"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton(CareerMoney.Format(price),()=>LeagueAction("buy",c.Id),156,emblem:NavigationIcon("coins"))`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber("持有 "+owned,76,_muted)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber("持有 "+owned,76,_muted)`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber("持有 × "+owned,100,_muted)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber("持有 × "+owned,100,_muted)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(page)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(page)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(rail,2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(rail,2)`
- `NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；输入表达式：`LeagueTile(c,out var body)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueTile(c,out var body)`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon("coins")`；返回值紧邻使用处：`ArgumentSyntax: emblem:NavigationIcon("coins")`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{_leaguePage+1} / {pages}",18,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{_leaguePage+1} / {pages}",18,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(mode=="交易"?"今天还没有这种稀有度的挂牌。":mode=="组卡"&&_deckQuery.Length>0?"没有符合搜索条件的牌。":"还没有收录这类卡牌。",20,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(mode=="交易"?"今天还没有这种稀有度的挂牌。":mode=="组卡"&&_deckQuery.Length>0?"没有符合搜索条件的牌。":"还没有收录这类卡牌。",20,_muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("1d2b33","536069",16,2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box("1d2b33","536069",16,2)`
- `NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.Ask(d,c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Ask(d,c)`
- `NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.CanReplace(a,k,c)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: k=>LeagueCards.CanReplace(a,k,c)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(a)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueCards.Deck(a)!`
- `NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；输入表达式：`LeagueCards.Limit(deck,c,role:a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.Limit(deck,c,role:a.Captain)==null`
- `NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string)`；输入表达式：`LeagueCards.Reserved(a,c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned-LeagueCards.Reserved(a,c.Id)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`deck.Values.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.Values.Sum()==LeagueCards.DeckSize`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c))`；返回值紧邻使用处：`BinaryExpressionSyntax: qty<owned&&deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`all.Skip(_leaguePage*count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.Skip(_leaguePage*count).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`all.Skip(_leaguePage*count).Take(count)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in all.Skip(_leaguePage*count).Take(count)){             var tile=LeagueTile(c,out var body);grid.AddChild(tile);if(mode=="组卡")_deckShelf[c.Id]=body.GetChild<Control>(0);int owned=a.Owned.GetValueOrDefault(c.Id);             var rail=new PanelContainer{SizeFlagsHorizontal=SizeFlags.ShrinkCenter};             var plaque=CareerVisuals.Box("1d2b33","536069",16,2);plaque.BorderColor=new Color("33434a").Lerp(new Color(SuitColors[c.Tier]),.32f);rail.AddThemeStyleboxOverride("panel",plaque);body.AddChild(rail);             var bar=LeagueRow(rail,2);bar.Alignment=BoxContainer.AlignmentMode.Center;bar.CustomMinimumSize=new(0,38);             if(mode=="交易"){int price=LeagueCards.Ask(d,c);var b=LeagueButton(CareerMoney.Format(price),()=>LeagueAction("buy",c.Id),156,emblem:NavigationIcon("coins"));b.TooltipText="购买"+c.Title;b.Disabled=CareerMoney.Balance(d)<price;bar.AddChild(b);}             else if(mode=="组卡"){int qty=LeagueCards.Deck(a)!.GetValueOrDefault(c.Id);                 bar.AddChild(LeagueNumber("持有 "+owned,76,_muted));                 var deck=LeagueCards.Deck(a)!;bool full=deck.Values.Sum()==LeagueCards.DeckSize;                 var add=full?DeckKey("swap","替换","用"+c.Title+"替换牌组中的一张牌",()=>DeckSwap(c,tile),qty<owned&&deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c)))                     :DeckKey("add","加入","加入一张"+c.Title,()=>LeagueAction("add",c.Id,origin:tile),qty<owned&&LeagueCards.Limit(deck,c,role:a.Captain)==null);bar.AddChild(add);}             else{bar.AddChild(LeagueNumber("持有 × "+owned,100,_muted));int sell=owned-LeagueCards.Reserved(a,c.Id);if(mode=="收藏"&&sell>0)bar.AddChild(LeagueButton("出售",()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell)),85));}         }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`source.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =source.ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =a.Owned.GetValueOrDefault(c.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`LeagueCards.Deck(a)!.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Deck(a)!.GetValueOrDefault(c.Id)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(_leaguePage,0,pages-1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _leaguePage=Math.Clamp(_leaguePage,0,pages-1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(all.Length+count-1)/count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(1,(all.Length+count-1)/count)`
- `Turn(int)`；输入表达式：`Turn(_leaguePage-1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Turn(_leaguePage-1)`
- `Turn(int)`；输入表达式：`Turn(_leaguePage+1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Turn(_leaguePage+1)`

**赋值（含属性/字段和局部值）：**

- `_deckShelf[c.Id]` = `body.GetChild<Control>(0)`
- `_leaguePage` = `Math.Clamp(_leaguePage,0,pages-1)`
- `b.Disabled` = `CareerMoney.Balance(d)<price`
- `b.TooltipText` = `"购买"+c.Title`
- `bar.Alignment` = `BoxContainer.AlignmentMode.Center`
- `bar.CustomMinimumSize` = `new(0,38)`
- `Columns` = `5`
- `dest` ??= `_content`
- `next.Disabled` = `_leaguePage+1==pages`
- `page.TreeExiting` += `()=>viewport.Resized-=FitPage`
- `plaque.BorderColor` = `new Color("33434a").Lerp(new Color(SuitColors[c.Tier]),.32f)`
- `prev.Disabled` = `_leaguePage==0`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `viewport.Resized` -= `FitPage`
- `viewport.Resized` += `FitPage`

<a id="symbol-be8839d87520"></a>

## `FitPage() — void FitPage()`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,Math.Max(0,viewport.Size.Y-36))`；返回值紧邻使用处：`AssignmentExpressionSyntax: page.CustomMinimumSize=new(0,Math.Max(0,viewport.Size.Y-36))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0,viewport.Size.Y-36)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,viewport.Size.Y-36)`

**赋值（含属性/字段和局部值）：**

- `page.CustomMinimumSize` = `new(0,Math.Max(0,viewport.Size.Y-36))`

<a id="symbol-450b6e2d277b"></a>

## `Turn(int) — void Turn(int n)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)

**调用：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerScreen.ShelfTop(Godot.Control)`](LeagueScreen.cs.md#symbol-ac7580704af1)；[`NationalSpire.CareerScreen.StoreFaces(Godot.Control)`](LeagueScreen.cs.md#symbol-65c1aeb6b0cb)；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._deckShelf`；`NationalSpire.CareerScreen._leaguePage`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.ShelfTop(Godot.Control)`；`NationalSpire.CareerScreen.StoreFaces(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.QueueFree()`；输入表达式：`page.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: page.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`dest.RemoveChild(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: dest.RemoveChild(page);`
- `NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；输入表达式：`LeagueGrid(all,d,mode,dest)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueGrid(all,d,mode,dest);`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(y,_renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=RestoreScrollAsync(y,_renderVersion)`
- `NationalSpire.CareerScreen.ShelfTop(Godot.Control)`；输入表达式：`ShelfTop(page)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ShelfTop(page)`
- `NationalSpire.CareerScreen.StoreFaces(Godot.Control)`；输入表达式：`StoreFaces(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: StoreFaces(page);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_deckShelf.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckShelf.Clear();`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(y,_renderVersion)`
- `_leaguePage` = `n`

<a id="symbol-65c1aeb6b0cb"></a>

## `NationalSpire.CareerScreen.StoreFaces(Godot.Control) — private void StoreFaces(Control section)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Browse()`](LeagueDeckEditor.cs.md#symbol-3160728b0b5b)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`Turn(int)`](LeagueScreen.cs.md#symbol-450b6e2d277b)

**调用：** [`NationalSpire.LeagueCardFace.Detach()`](LeagueCardFace.cs.md#symbol-5fdb1791bb4a)；`Godot.Node.GetTree()`；`Godot.Node.IsAncestorOf(Godot.Node)`；`Godot.Node.IsInsideTree()`；`Godot.Node.QueueFree()`；`Godot.SceneTree.GetNodesInGroup(Godot.StringName)`；`System.Collections.Generic.LinkedList<T>.AddFirst(T)`；`System.Collections.Generic.LinkedList<T>.RemoveLast()`

**字段、属性、事件及方法组引用：** `((MegaCrit.Sts2.Core.Models.CardModel, bool) Key, MegaCrit.Sts2.Core.Nodes.Cards.NCard Face).Face`；`NationalSpire.CareerScreen._recentFaces`；`NationalSpire.LeagueCardFace.Detach()`；`NationalSpire.LeagueCardFace.Identity`；`NationalSpire.LeagueCards.DeckSize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetTree().GetNodesInGroup`
- `Godot.Node.IsAncestorOf(Godot.Node)`；输入表达式：`section.IsAncestorOf(face)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !section.IsAncestorOf(face)`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `Godot.Node.QueueFree()`；输入表达式：`_recentFaces.Last!.Value.Face.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _recentFaces.Last!.Value.Face.QueueFree();`
- `Godot.SceneTree.GetNodesInGroup(Godot.StringName)`；输入表达式：`GetTree().GetNodesInGroup("NationalSpireLeagueCards")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var node in GetTree().GetNodesInGroup("NationalSpireLeagueCards")){             if(node is not LeagueCardFace face||!section.IsAncestorOf(face)||face.Detach() is not {} native)continue;             _recentFaces.AddFirst((face.Identity,native));         }`
- `NationalSpire.LeagueCardFace.Detach()`；输入表达式：`face.Detach()`；返回值紧邻使用处：`IsPatternExpressionSyntax: face.Detach() is not {} native`
- `System.Collections.Generic.LinkedList<T>.AddFirst(T)`；输入表达式：`_recentFaces.AddFirst((face.Identity,native))`；返回值紧邻使用处：`ExpressionStatementSyntax: _recentFaces.AddFirst((face.Identity,native));`
- `System.Collections.Generic.LinkedList<T>.RemoveLast()`；输入表达式：`_recentFaces.RemoveLast()`；返回值紧邻使用处：`ExpressionStatementSyntax: _recentFaces.RemoveLast();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-27f378d7dc3d"></a>

## `NationalSpire.CareerScreen.TakeFace(MegaCrit.Sts2.Core.Models.CardModel, bool) — private MegaCrit.Sts2.Core.Nodes.Cards.NCard? TakeFace(CardModel model,bool upgraded)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)

**调用：** `System.Collections.Generic.LinkedList<T>.Remove(System.Collections.Generic.LinkedListNode<T>)`

**字段、属性、事件及方法组引用：** `((MegaCrit.Sts2.Core.Models.CardModel, bool) Key, MegaCrit.Sts2.Core.Nodes.Cards.NCard Face).Face`；`((MegaCrit.Sts2.Core.Models.CardModel, bool) Key, MegaCrit.Sts2.Core.Nodes.Cards.NCard Face).Key`；`NationalSpire.CareerScreen._recentFaces`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.LinkedList<T>.Remove(System.Collections.Generic.LinkedListNode<T>)`；输入表达式：`_recentFaces.Remove(n)`；返回值紧邻使用处：`ExpressionStatementSyntax: _recentFaces.Remove(n);`

**赋值（含属性/字段和局部值）：**

- `n` = `n.Next`

<a id="symbol-3fa69e107266"></a>

## `NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?) — private PanelContainer LeagueTile(LeagueCards.Entry card,out VBoxContainer body,bool upgraded=false,Action? inspectAction=null)`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`](DuelReportScreen.cs.md#symbol-ca484e5b67df)；[`Reveal()`](LeagueScreen.cs.md#symbol-31cea69eebc3)

**调用：** [`NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`](LeagueScreen.cs.md#symbol-69ed9740453e)；[`NationalSpire.CareerScreen.TakeFace(MegaCrit.Sts2.Core.Models.CardModel, bool)`](LeagueScreen.cs.md#symbol-27f378d7dc3d)；[`NationalSpire.LeagueCardFace.Highlight(bool)`](LeagueCardFace.cs.md#symbol-2232c5fe9aae)；[`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)；`Godot.Button.Button()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.AddToGroup(Godot.StringName, bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueCardFace.LeagueCardFace()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.TakeFace(MegaCrit.Sts2.Core.Models.CardModel, bool)`；`NationalSpire.LeagueCardFace.Highlight(bool)`；`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.PartyHint`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button{Flat=true,MouseDefaultCursorShape=CursorShape.PointingHand,TooltipText="放大查看 · "+card.Title+(card.PartyHint.Length>0?"\n"+card.PartyHint:"")}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Button{Flat=true,MouseDefaultCursorShape=CursorShape.PointingHand,TooltipText="放大查看 · "+card.Title+(card.PartyHint.Length>0?"\n"+card.PartyHint:"")}`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[card.Tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(SuitColors[card.Tier])`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[card.Tier])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Color(SuitColors[card.Tier])`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",6);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`inspect.AddThemeStyleboxOverride("hover",new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: inspect.AddThemeStyleboxOverride("hover",new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`inspect.AddThemeStyleboxOverride("normal",new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: inspect.AddThemeStyleboxOverride("normal",new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`tile.AddThemeStyleboxOverride("panel",mat)`；返回值紧邻使用处：`ExpressionStatementSyntax: tile.AddThemeStyleboxOverride("panel",mat);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`inspect.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: inspect.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(display)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(display);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`display.AddChild(inspect)`；返回值紧邻使用处：`ExpressionStatementSyntax: display.AddChild(inspect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tile.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: tile.AddChild(body);`
- `Godot.Node.AddToGroup(Godot.StringName, bool)`；输入表达式：`display.AddToGroup("NationalSpireLeagueCards")`；返回值紧邻使用处：`ExpressionStatementSyntax: display.AddToGroup("NationalSpireLeagueCards");`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill,CustomMinimumSize=new(185,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill,CustomMinimumSize=new(185,0)}`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new StyleBoxEmpty()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: body=new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(185,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(185,0)`
- `NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`；输入表达式：`LeagueInspect(card,upgraded)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueInspect(card,upgraded)`
- `NationalSpire.CareerScreen.TakeFace(MegaCrit.Sts2.Core.Models.CardModel, bool)`；输入表达式：`TakeFace(card.Model,upgraded)`；返回值紧邻使用处：`ArgumentSyntax: TakeFace(card.Model,upgraded)`
- `NationalSpire.LeagueCardFace.Highlight(bool)`；输入表达式：`display.Highlight(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>display.Highlight(false)`
- `NationalSpire.LeagueCardFace.Highlight(bool)`；输入表达式：`display.Highlight(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>display.Highlight(true)`
- `NationalSpire.LeagueCardFace.LeagueCardFace()`；输入表达式：`new LeagueCardFace()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueCardFace()`
- `NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；输入表达式：`display.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),upgraded,TakeFace(card.Model,upgraded))`；返回值紧邻使用处：`ExpressionStatementSyntax: display.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),upgraded,TakeFace(card.Model,upgraded));`

**赋值（含属性/字段和局部值）：**

- `body` = `new VBoxContainer()`
- `CustomMinimumSize` = `new(185,0)`
- `Flat` = `true`
- `inspect.FocusEntered` += `()=>display.Highlight(true)`
- `inspect.FocusExited` += `()=>display.Highlight(false)`
- `inspect.MouseEntered` += `()=>display.Highlight(true)`
- `inspect.MouseExited` += `()=>display.Highlight(false)`
- `inspect.Pressed` += `inspectAction??(()=>LeagueInspect(card,upgraded))`
- `mat.ContentMarginBottom` = `5`
- `mat.ContentMarginLeft` = `mat.ContentMarginRight=5`
- `mat.ContentMarginRight` = `5`
- `mat.ContentMarginTop` = `8`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `TooltipText` = `"放大查看 · "+card.Title+(card.PartyHint.Length>0?"\n"+card.PartyHint:"")`

<a id="symbol-69ed9740453e"></a>

## `NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool) — private void LeagueInspect(LeagueCards.Entry card,bool upgraded=false)`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)

**调用：** [`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueCardFace.LeagueCardFace()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Back`；`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.PartyHint`；`NationalSpire.LeagueCards.Entry.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CenterContainer()`
- `Godot.Color.Color(string)`；输入表达式：`new Color("09111bea")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color("09111bea")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[card.Tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(SuitColors[card.Tier])`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect{Name="LeagueCardInspection",Color=new Color("09111bea"),MouseFilter=MouseFilterEnum.Stop,ZIndex=110}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ColorRect{Name="LeagueCardInspection",Color=new Color("09111bea"),MouseFilter=MouseFilterEnum.Stop,ZIndex=110}`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation",16);`
- `Godot.Control.GrabFocus()`；输入表达式：`close.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: close.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`(_dialogOverlay??_stage).AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: (_dialogOverlay??_stage).AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(column);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(close)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(close);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(face);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(LeagueNumber(card.PartyHint,320,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(LeagueNumber(card.PartyHint,320,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(center);`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>shade.QueueFree()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(400,558)`；返回值紧邻使用处：`AssignmentExpressionSyntax: face.CustomMinimumSize=new(400,558)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("返回",()=>shade.QueueFree(),155,kind:LeagueControl.Back)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("返回",()=>shade.QueueFree(),155,kind:LeagueControl.Back)`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber(card.PartyHint,320,_gold)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber(card.PartyHint,320,_gold)`
- `NationalSpire.LeagueCardFace.LeagueCardFace()`；输入表达式：`new LeagueCardFace()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueCardFace()`
- `NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；输入表达式：`face.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),upgraded)`；返回值紧邻使用处：`ExpressionStatementSyntax: face.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),upgraded);`

**赋值（含属性/字段和局部值）：**

- `Color` = `new Color("09111bea")`
- `face.CustomMinimumSize` = `new(400,558)`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"LeagueCardInspection"`
- `shade.GuiInput` += `e=>{if(e is InputEventMouseButton {Pressed:true,ButtonIndex:MouseButton.Left})shade.QueueFree();}`
- `ZIndex` = `110`

<a id="symbol-7bcdb9dae8c1"></a>

## `NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int) — private static void PlayPackSound(Control parent,int tier)`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Reveal()`](LeagueScreen.cs.md#symbol-31cea69eebc3)；[`ShowAll()`](LeagueScreen.cs.md#symbol-3bc4c46bb4f4)

**调用：** `Godot.AudioStreamMP3.AudioStreamMP3()`；`Godot.AudioStreamPlayer.AudioStreamPlayer()`；`Godot.AudioStreamPlayer.Play(float)`；`Godot.Mathf.LinearToDb(float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`System.Math.Min(int, int)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PackSounds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.AudioStreamMP3.AudioStreamMP3()`；输入表达式：`new AudioStreamMP3{Data=data.ToArray()}`；返回值紧邻使用处：`AssignmentExpressionSyntax: PackSounds[i]=new AudioStreamMP3{Data=data.ToArray()}`
- `Godot.AudioStreamPlayer.AudioStreamPlayer()`；输入表达式：`new AudioStreamPlayer{Stream=PackSounds[i],VolumeDb=Mathf.LinearToDb(volume*volume)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new AudioStreamPlayer{Stream=PackSounds[i],VolumeDb=Mathf.LinearToDb(volume*volume)}`
- `Godot.AudioStreamPlayer.Play(float)`；输入表达式：`player.Play()`；返回值紧邻使用处：`ExpressionStatementSyntax: player.Play();`
- `Godot.Mathf.LinearToDb(float)`；输入表达式：`Mathf.LinearToDb(volume*volume)`；返回值紧邻使用处：`AssignmentExpressionSyntax: VolumeDb=Mathf.LinearToDb(volume*volume)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(player)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(player);`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`data.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Data=data.ToArray()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`input.CopyTo(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.CopyTo(data);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(2,tier)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(2,tier)`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(CareerScreen).Assembly.GetManifestResourceStream($"NationalSpire.CardPacks.{file}.mp3")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: typeof(CareerScreen).Assembly.GetManifestResourceStream($"NationalSpire.CardPacks.{file}.mp3")!`

**赋值（含属性/字段和局部值）：**

- `Data` = `data.ToArray()`
- `PackSounds[i]` = `new AudioStreamMP3{Data=data.ToArray()}`
- `player.Finished` += `player.QueueFree`
- `Stream` = `PackSounds[i]`
- `VolumeDb` = `Mathf.LinearToDb(volume*volume)`

<a id="symbol-d1f631d136b9"></a>

## `NationalSpire.CareerScreen.LeagueReveal(string[], bool) — private void LeagueReveal(string[] ids,bool opening=false)`

来源：源码第 164 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Done()`](LeagueScreen.cs.md#symbol-d964f7e2b387)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)

**调用：** [`HighestFrom(int)`](LeagueScreen.cs.md#symbol-714f28298263)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Reveal()`](LeagueScreen.cs.md#symbol-31cea69eebc3)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`NationalSpire.LeagueSeal.LeagueSeal()`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `HighestFrom(int)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.LeagueSeal.Ink`；`Reveal()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CenterContainer()`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0b141df8")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color("0b141df8")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[Math.Max(0,highest)])`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ink=new Color(SuitColors[Math.Max(0,highest)])`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect{Color=new Color("0b141df8"),MouseFilter=MouseFilterEnum.Stop,ZIndex=100}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ColorRect{Color=new Color("0b141df8"),MouseFilter=MouseFilterEnum.Stop,ZIndex=100}`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`stack.AddThemeConstantOverride("separation",28)`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.AddThemeConstantOverride("separation",28);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`frame.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(overlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(overlay);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`frame.AddChild(stack)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddChild(stack);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`overlay.AddChild(frame)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.AddChild(frame);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`overlay.AddChild(seal)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.AddChild(seal);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stack.AddChild(Text("联赛典藏    /    开包揭晓",29,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.AddChild(Text("联赛典藏    /    开包揭晓",29,_gold));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `HighestFrom(int)`；输入表达式：`HighestFrom(0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =HighestFrom(0)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(stack,18)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(stack,18)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(stack)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(stack)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("联赛典藏    /    开包揭晓",29,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("联赛典藏    /    开包揭晓",29,_gold)`
- `NationalSpire.LeagueSeal.LeagueSeal()`；输入表达式：`new LeagueSeal{Ink=new Color(SuitColors[Math.Max(0,highest)]),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueSeal{Ink=new Color(SuitColors[Math.Max(0,highest)]),MouseFilter=MouseFilterEnum.Ignore}`
- `Reveal()`；输入表达式：`Reveal()`；返回值紧邻使用处：`ExpressionStatementSyntax: Reveal();`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Tween>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Tween>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,highest)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,highest)`

**赋值（含属性/字段和局部值）：**

- `Color` = `new Color("0b141df8")`
- `Ink` = `new Color(SuitColors[Math.Max(0,highest)])`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `ZIndex` = `100`

<a id="symbol-714f28298263"></a>

## `HighestFrom(int) — int HighestFrom(int start)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`](LeagueScreen.cs.md#symbol-d1f631d136b9)；[`ShowAll()`](LeagueScreen.cs.md#symbol-3bc4c46bb4f4)

**调用：** `System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier).DefaultIfEmpty(-1).Max()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier).DefaultIfEmpty(-1).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier).DefaultIfEmpty(-1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier).DefaultIfEmpty(-1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`ids.Skip(start)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Skip(start).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-31cea69eebc3"></a>

## `Reveal() — void Reveal()`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueReveal(string[], bool)`](LeagueScreen.cs.md#symbol-d1f631d136b9)；[`Reveal()`](LeagueScreen.cs.md#symbol-31cea69eebc3)

**调用：** [`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)；[`NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int)`](LeagueScreen.cs.md#symbol-7bcdb9dae8c1)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`Reveal()`](LeagueScreen.cs.md#symbol-31cea69eebc3)；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Color.Color(string)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Node.GetChildCount(bool)`；`Godot.PropertyTweener.SetEase(Godot.Tween.EaseType)`；`Godot.PropertyTweener.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.Kill()`；`Godot.Tween.TweenCallback(Godot.Callable)`；`Godot.Tween.TweenInterval(double)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueFoil.LeagueFoil()`；`NationalSpire.LeagueSeal.LeagueSeal()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；`NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueFoil.Ink`；`NationalSpire.LeagueSeal.Burst`；`NationalSpire.LeagueSeal.Ink`；`Reveal()`；`ShowAll()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{                     back.Hide();face.Show();                     if(opening){PlayPackSound(_stage,card.Tier);highestHeard=Math.Max(highestHeard,card.Tier);}                     if(card.Tier>0){var dust=new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore};slot.AddChild(dust);dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);}                 })`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(()=>{                     back.Hide();face.Show();                     if(opening){PlayPackSound(_stage,card.Tier);highestHeard=Math.Max(highestHeard,card.Tier);}                     if(card.Tier>0){var dust=new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore};slot.AddChild(dust);dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);}                 })`
- `Godot.CanvasItem.Hide()`；输入表达式：`back.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: back.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`face.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: face.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`face.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: face.Show();`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[card.Tier])`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ink=new Color(SuitColors[card.Tier])`
- `Godot.Control.Control()`；输入表达式：`new Control{CustomMinimumSize=new(218,310)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Control{CustomMinimumSize=new(218,310)}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`back.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: back.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`face.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: face.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(LeagueButton("查看全部",ShowAll,160))`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(LeagueButton("查看全部",ShowAll,160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(LeagueButton("开启下一包",()=>{index+=5;Reveal();},180))`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(LeagueButton("开启下一包",()=>{index+=5;Reveal();},180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(Text($"{index/5+1} / {(ids.Length+4)/5} 包",20,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(Text($"{index/5+1} / {(ids.Length+4)/5} 包",20,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(slot)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(slot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slot.AddChild(back)`；返回值紧邻使用处：`ExpressionStatementSyntax: slot.AddChild(back);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slot.AddChild(dust)`；返回值紧邻使用处：`ExpressionStatementSyntax: slot.AddChild(dust);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slot.AddChild(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: slot.AddChild(face);`
- `Godot.Node.CreateTween()`；输入表达式：`slot.CreateTween()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =slot.CreateTween()`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`row.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: row.GetChildCount()-1`
- `Godot.PropertyTweener.SetEase(Godot.Tween.EaseType)`；输入表达式：`t.TweenProperty(face,"scale:x",1,.24).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenProperty(face,"scale:x",1,.24).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);`
- `Godot.PropertyTweener.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`t.TweenProperty(face,"scale:x",1,.24).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.TweenProperty(face,"scale:x",1,.24).SetTrans(Tween.TransitionType.Cubic).SetEase`
- `Godot.Tween.Kill()`；输入表达式：`t.Kill()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Kill();`
- `Godot.Tween.TweenCallback(Godot.Callable)`；输入表达式：`t.TweenCallback(Callable.From(()=>{                     back.Hide();face.Show();                     if(opening){PlayPackSound(_stage,card.Tier);highestHeard=Math.Max(highestHeard,card.Tier);}                     if(card.Tier>0){var dust=new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore};slot.AddChild(dust);dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);}                 }))`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenCallback(Callable.From(()=>{                     back.Hide();face.Show();                     if(opening){PlayPackSound(_stage,card.Tier);highestHeard=Math.Max(highestHeard,card.Tier);}                     if(card.Tier>0){var dust=new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore};slot.AddChild(dust);dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);}                 }));`
- `Godot.Tween.TweenInterval(double)`；输入表达式：`t.TweenInterval((index==0?1.1:.18)+pos*.19+(card.Tier>1?.24:0))`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenInterval((index==0?1.1:.18)+pos*.19+(card.Tier>1?.24:0));`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`t.TweenProperty(back,"scale:x",.01,.15)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenProperty(back,"scale:x",.01,.15);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`t.TweenProperty(face,"scale:x",1,.24)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.TweenProperty(face,"scale:x",1,.24).SetTrans`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.01f,1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: face.Scale=new(.01f,1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(109,155)`；返回值紧邻使用处：`AssignmentExpressionSyntax: back.PivotOffset=new(109,155)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(109,155)`；返回值紧邻使用处：`AssignmentExpressionSyntax: face.PivotOffset=new(109,155)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(218,310)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(218,310)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("查看全部",ShowAll,160)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("查看全部",ShowAll,160)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("开启下一包",()=>{index+=5;Reveal();},180)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton("开启下一包",()=>{index+=5;Reveal();},180)`
- `NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；输入表达式：`LeagueTile(card,out _)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueTile(card,out _)`
- `NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int)`；输入表达式：`PlayPackSound(_stage,card.Tier)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayPackSound(_stage,card.Tier);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{index/5+1} / {(ids.Length+4)/5} 包",20,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{index/5+1} / {(ids.Length+4)/5} 包",20,_muted)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(buttons)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(buttons);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(row);`
- `NationalSpire.LeagueFoil.LeagueFoil()`；输入表达式：`new LeagueFoil{Ink=new Color(SuitColors[card.Tier])}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueFoil{Ink=new Color(SuitColors[card.Tier])}`
- `NationalSpire.LeagueSeal.LeagueSeal()`；输入表达式：`new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore}`
- `Reveal()`；输入表达式：`Reveal()`；返回值紧邻使用处：`ExpressionStatementSyntax: Reveal();`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`ids.Skip(index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Skip(index).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`ids.Skip(index).Take(5)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(string id in ids.Skip(index).Take(5)){                 if(!LeagueCards.Catalog.TryGetValue(id,out var card))continue;                 var slot=new Control{CustomMinimumSize=new(218,310)};row.AddChild(slot);                 var face=LeagueTile(card,out _);slot.AddChild(face);face.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);face.PivotOffset=new(109,155);face.Scale=new(.01f,1);face.Hide();                 var back=new LeagueFoil{Ink=new Color(SuitColors[card.Tier])};slot.AddChild(back);back.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);back.PivotOffset=new(109,155);                 int pos=row.GetChildCount()-1;var t=slot.CreateTween();tweens.Add(t);t.TweenInterval((index==0?1.1:.18)+pos*.19+(card.Tier>1?.24:0));t.TweenProperty(back,"scale:x",.01,.15);t.TweenCallback(Callable.From(()=>{                     back.Hide();face.Show();                     if(opening){PlayPackSound(_stage,card.Tier);highestHeard=Math.Max(highestHeard,card.Tier);}                     if(card.Tier>0){var dust=new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore};slot.AddChild(dust);dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);}                 }));t.TweenProperty(face,"scale:x",1,.24).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);             }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`LeagueCards.Catalog.TryGetValue(id,out var card)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Catalog.TryGetValue(id,out var card)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`tweens.Add(t)`；返回值紧邻使用处：`ExpressionStatementSyntax: tweens.Add(t);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`tweens.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: tweens.Clear();`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(highestHeard,card.Tier)`；返回值紧邻使用处：`AssignmentExpressionSyntax: highestHeard=Math.Max(highestHeard,card.Tier)`

**赋值（含属性/字段和局部值）：**

- `back.PivotOffset` = `new(109,155)`
- `Burst` = `true`
- `CustomMinimumSize` = `new(218,310)`
- `face.PivotOffset` = `new(109,155)`
- `face.Scale` = `new(.01f,1)`
- `highestHeard` = `Math.Max(highestHeard,card.Tier)`
- `index` += `5`
- `Ink` = `new Color(SuitColors[card.Tier])`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-3bc4c46bb4f4"></a>

## `ShowAll() — void ShowAll()`

来源：源码第 186 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`HighestFrom(int)`](LeagueScreen.cs.md#symbol-714f28298263)；[`NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int)`](LeagueScreen.cs.md#symbol-7bcdb9dae8c1)；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.QueueFree()`；`Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `HighestFrom(int)`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`overlay.IsQueuedForDeletion()`；返回值紧邻使用处：`IfStatementSyntax: if(overlay.IsQueuedForDeletion())return;`
- `Godot.Node.QueueFree()`；输入表达式：`overlay.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.QueueFree();`
- `Godot.Tween.Kill()`；输入表达式：`t.Kill()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Kill();`
- `HighestFrom(int)`；输入表达式：`HighestFrom(index)`；返回值紧邻使用处：`ConditionalExpressionSyntax: index==0?highest:HighestFrom(index)`
- `NationalSpire.CareerScreen.PlayPackSound(Godot.Control, int)`；输入表达式：`PlayPackSound(_stage,remaining)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayPackSound(_stage,remaining);`

**赋值（含属性/字段和局部值）：**
