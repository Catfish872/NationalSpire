# LeagueDuel.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`74C14455FC2AF9DFC7274B20A02D73059670AC82D0B98ED001E3C0A50DBDFDA6`。来源：[源码](../../LeagueDuel.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueDuel`、`NationalSpire.LeagueDuel.Hit`。

字段、事件及初始值（源码原样）：

```csharp
internal readonly Random _rng;
internal readonly Player Rival;
internal readonly CardModel[] Deck;
internal readonly string OpponentName;
internal readonly int Tier;
internal string[] SetupCards=[];
internal readonly HashSet<Creature> Stunned=[];
internal int? OpeningHp;
internal int OpeningMax;
public readonly List<Hit> Pending;
private readonly Dictionary<string,int>? _upgrades;
```

<a id="symbol-fc2256bac5a5"></a>

## `NationalSpire.LeagueDuel.Hit.DoomSource — public CardModel? DoomSource`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a3e574e31eec"></a>

## `NationalSpire.LeagueDuel.Hit.Doom — public bool Doom`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-83cd52462f7a"></a>

## `NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?) — internal LeagueDuel(Player rival,CardModel[] deck,int seed,string opponentName,int tier,Dictionary<string,int>? upgrades,List<Hit>? pending=null)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** `System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel._rng`；`NationalSpire.LeagueDuel._upgrades`；`NationalSpire.LeagueDuel.Deck`；`NationalSpire.LeagueDuel.OpponentName`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueDuel.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Random.Random(int)`；输入表达式：`new(seed)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _rng=new(seed)`

**赋值（含属性/字段和局部值）：**

- `_rng` = `new(seed)`
- `_upgrades` = `upgrades`
- `Deck` = `deck`
- `OpponentName` = `opponentName`
- `Pending` = `pending??[]`
- `Rival` = `rival`
- `Tier` = `tier`

<a id="symbol-af76d282a609"></a>

## `NationalSpire.LeagueDuel.Attach(MegaCrit.Sts2.Core.Entities.Creatures.Creature) — internal void Attach(Creature actor)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-f78a44bdbc8e)

**调用：** [`NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`](LeagueCards.cs.md#symbol-4eb35465f771)；`HarmonyLib.AccessTools.Field(System.Type, string)`；`MegaCrit.Sts2.Core.Combat.CombatState.CreateCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；`System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Random.Next()`；`System.Reflection.FieldInfo.SetValue(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`；`NationalSpire.LeagueDuel._rng`；`NationalSpire.LeagueDuel._upgrades`；`NationalSpire.LeagueDuel.Deck`；`NationalSpire.LeagueDuel.Rival`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(Player),"<Creature>k__BackingField")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(typeof(Player),"<Creature>k__BackingField").SetValue`
- `MegaCrit.Sts2.Core.Combat.CombatState.CreateCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`((CombatState)actor.CombatState!).CreateCard(c,Rival)`；返回值紧邻使用处：`ArgumentSyntax: ((CombatState)actor.CombatState!).CreateCard(c,Rival)`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；输入表达式：`Rival.PlayerCombatState!.DrawPile.AddInternal(LeagueCards.ApplyAllocation(((CombatState)actor.CombatState!).CreateCard(c,Rival),remaining),-1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rival.PlayerCombatState!.DrawPile.AddInternal(LeagueCards.ApplyAllocation(((CombatState)actor.CombatState!).CreateCard(c,Rival),remaining),-1,true);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；输入表达式：`Rival.ResetCombatState()`；返回值紧邻使用处：`ExpressionStatementSyntax: Rival.ResetCombatState();`
- `NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`；输入表达式：`LeagueCards.ApplyAllocation(((CombatState)actor.CombatState!).CreateCard(c,Rival),remaining)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.ApplyAllocation(((CombatState)actor.CombatState!).CreateCard(c,Rival),remaining)`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`.ToDictionary()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _upgrades?.ToDictionary()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Deck.OrderBy(_=>_rng.Next())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in Deck.OrderBy(_=>_rng.Next()))Rival.PlayerCombatState!.DrawPile.AddInternal(LeagueCards.ApplyAllocation(((CombatState)actor.CombatState!).CreateCard(c,Rival),remaining),-1,true);`
- `System.Random.Next()`；输入表达式：`_rng.Next()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>_rng.Next()`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`AccessTools.Field(typeof(Player),"<Creature>k__BackingField").SetValue(Rival,actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.Field(typeof(Player),"<Creature>k__BackingField").SetValue(Rival,actor);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0b7f3276ecd9"></a>

## `NationalSpire.LeagueDuel.Act() — internal async Task Act()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Enemy(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-531731d36b7d)；[`NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-2e5d42d12c6a)

**调用：** [`Identify()`](LeagueDuel.cs.md#symbol-31678f6b407a)；[`NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueNativeMatch.cs.md#symbol-1ebfa08e7076)；[`NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>)`](ArchitectFinal.cs.md#symbol-09629ccb5931)；[`NationalSpire.LeagueSolverLink.Choose(decimal[], int[])`](LeagueSolverLink.cs.md#symbol-fc82d47e0248)；[`NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int)`](LeagueSolverLink.cs.md#symbol-09cdebc60677)；[`NationalSpire.LeagueSolverLink.Rest()`](LeagueSolverLink.cs.md#symbol-f083c8d9e98a)；[`NationalSpire.LeagueTurnPlan.Choose(MegaCrit.Sts2.Core.Entities.Players.Player, decimal, int)`](LeagueTurnPlan.cs.md#symbol-df3baa0c08bc)；[`ReadNext()`](LeagueDuel.cs.md#symbol-7b7d38e67716)；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Models.CardModel, bool, bool)`；`MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；`MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；`MegaCrit.Sts2.Core.Commands.CardPileCmd.Draw(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, decimal, MegaCrit.Sts2.Core.Entities.Players.Player, bool)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.MoveToBottomInternal(MegaCrit.Sts2.Core.Models.CardModel)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.MoveToTopInternal(MegaCrit.Sts2.Core.Models.CardModel)`；`MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo.ResourceInfo()`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AfterTurnStart(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.BeforeTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddMaxEnergyToCurrent()`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.EndOfTurnCleanup()`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.ResetEnergy()`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；`MegaCrit.Sts2.Core.Hooks.Hook.AfterEnergyReset(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Hooks.Hook.AfterFlush(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardModel>)`；`MegaCrit.Sts2.Core.Hooks.Hook.AfterModifyingHandDraw(MegaCrit.Sts2.Core.Combat.ICombatState, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>)`；`MegaCrit.Sts2.Core.Hooks.Hook.AfterPlayerTurnStart(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Hooks.Hook.BeforeFlush(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Hooks.Hook.BeforeHandDraw(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；`MegaCrit.Sts2.Core.Hooks.Hook.ModifyHandDraw(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, decimal, out System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>)`；`MegaCrit.Sts2.Core.Hooks.Hook.ShouldEtherealTrigger(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.CardModel)`；`MegaCrit.Sts2.Core.Hooks.Hook.ShouldFlush(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Hooks.Hook.ShouldPlayerResetEnergy(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`MegaCrit.Sts2.Core.Models.CardModel.OnPlayWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, bool, MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo, bool)`；`MegaCrit.Sts2.Core.Models.CardModel.OnTurnEndInHandWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；`MegaCrit.Sts2.Core.Models.CardModel.SpendResources()`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.Generic.Queue<T>.Queue()`；`System.Math.Max(decimal, decimal)`；`System.Math.Max(int, int)`；`System.Math.Min(decimal, decimal)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `Identify()`；`NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Hit.Props`；`NationalSpire.LeagueDuel.Hit.Target`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueDuel.SetupCards`；`NationalSpire.LeagueDuel.Tier`；`NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.LeagueNativeMatch.Fighters`；`NationalSpire.LeagueNativeMatch.PlanHost`；`NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>)`；`NationalSpire.LeagueSolverLink.Aim`；`NationalSpire.LeagueSolverLink.Choose(decimal[], int[])`；`NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int)`；`NationalSpire.LeagueSolverLink.Rest()`；`NationalSpire.LeagueTurnPlan.Choose(MegaCrit.Sts2.Core.Entities.Players.Player, decimal, int)`；`ReadNext()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Identify()`；输入表达式：`Identify()`；返回值紧邻使用处：`ExpressionStatementSyntax: Identify();`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetOpponentsOf(Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(Rival.Creature).Any`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetOpponentsOf(Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(Rival.Creature).First`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetOpponentsOf(Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(Rival.Creature).Where`
- `MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Models.CardModel, bool, bool)`；输入表达式：`CardCmd.Exhaust(context,c,true,true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await CardCmd.Exhaust(context,c,true,true)`
- `MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Models.CardModel, bool, bool)`；输入表达式：`MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(context,c,true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(context,c,true)`
- `MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；输入表达式：`CardPileCmd.Add(c,PileType.Discard,skipVisuals:true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await CardPileCmd.Add(c,PileType.Discard,skipVisuals:true)`
- `MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；输入表达式：`CardPileCmd.Add(c,PileType.Play,skipVisuals:true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await CardPileCmd.Add(c,PileType.Play,skipVisuals:true)`
- `MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；输入表达式：`MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(discard,PileType.Discard,skipVisuals:true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(discard,PileType.Discard,skipVisuals:true)`
- `MegaCrit.Sts2.Core.Commands.CardPileCmd.Draw(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, decimal, MegaCrit.Sts2.Core.Entities.Players.Player, bool)`；输入表达式：`MegaCrit.Sts2.Core.Commands.CardPileCmd.Draw(context,draw,Rival,true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await MegaCrit.Sts2.Core.Commands.CardPileCmd.Draw(context,draw,Rival,true)`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.MoveToBottomInternal(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`s.DrawPile.MoveToBottomInternal(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.DrawPile.MoveToBottomInternal(c);`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.MoveToTopInternal(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`s.DrawPile.MoveToTopInternal(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.DrawPile.MoveToTopInternal(c);`
- `MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo.ResourceInfo()`；输入表达式：`new(){EnergySpent=cost,EnergyValue=cost,StarsSpent=stars,StarValue=stars}`；返回值紧邻使用处：`ArgumentSyntax: new(){EnergySpent=cost,EnergyValue=cost,StarsSpent=stars,StarValue=stars}`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AfterTurnStart(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；输入表达式：`s.OrbQueue.AfterTurnStart(context)`；返回值紧邻使用处：`AwaitExpressionSyntax: await s.OrbQueue.AfterTurnStart(context)`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.BeforeTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；输入表达式：`s.OrbQueue.BeforeTurnEnd(context)`；返回值紧邻使用处：`AwaitExpressionSyntax: await s.OrbQueue.BeforeTurnEnd(context)`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddMaxEnergyToCurrent()`；输入表达式：`s.AddMaxEnergyToCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.AddMaxEnergyToCurrent();`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.EndOfTurnCleanup()`；输入表达式：`s.EndOfTurnCleanup()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.EndOfTurnCleanup();`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；输入表达式：`s.IncrementTurnNumber()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.IncrementTurnNumber();`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.ResetEnergy()`；输入表达式：`s.ResetEnergy()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.ResetEnergy();`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；输入表达式：`new BlockingPlayerChoiceContext()`；返回值紧邻使用处：`ArgumentSyntax: new BlockingPlayerChoiceContext()`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；输入表达式：`new BlockingPlayerChoiceContext()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BlockingPlayerChoiceContext()`
- `MegaCrit.Sts2.Core.Hooks.Hook.AfterEnergyReset(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`Hook.AfterEnergyReset(state,Rival)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Hook.AfterEnergyReset(state,Rival)`
- `MegaCrit.Sts2.Core.Hooks.Hook.AfterFlush(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardModel>)`；输入表达式：`Hook.AfterFlush(state,Rival,context,discard,retain)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Hook.AfterFlush(state,Rival,context,discard,retain)`
- `MegaCrit.Sts2.Core.Hooks.Hook.AfterModifyingHandDraw(MegaCrit.Sts2.Core.Combat.ICombatState, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>)`；输入表达式：`Hook.AfterModifyingHandDraw(state,modifiers)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Hook.AfterModifyingHandDraw(state,modifiers)`
- `MegaCrit.Sts2.Core.Hooks.Hook.AfterPlayerTurnStart(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`Hook.AfterPlayerTurnStart(state,context,Rival)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Hook.AfterPlayerTurnStart(state,context,Rival)`
- `MegaCrit.Sts2.Core.Hooks.Hook.BeforeFlush(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`Hook.BeforeFlush(state,Rival)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Hook.BeforeFlush(state,Rival)`
- `MegaCrit.Sts2.Core.Hooks.Hook.BeforeHandDraw(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；输入表达式：`Hook.BeforeHandDraw(state,Rival,context)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Hook.BeforeHandDraw(state,Rival,context)`
- `MegaCrit.Sts2.Core.Hooks.Hook.ModifyHandDraw(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, decimal, out System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>)`；输入表达式：`Hook.ModifyHandDraw(state,Rival,5,out var modifiers)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Hook.ModifyHandDraw(state,Rival,5,out var modifiers)`
- `MegaCrit.Sts2.Core.Hooks.Hook.ShouldEtherealTrigger(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Hook.ShouldEtherealTrigger(state,c)`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)&&Hook.ShouldEtherealTrigger(state,c)`
- `MegaCrit.Sts2.Core.Hooks.Hook.ShouldFlush(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`Hook.ShouldFlush(state,Rival)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Hook.ShouldFlush(state,Rival)`
- `MegaCrit.Sts2.Core.Hooks.Hook.ShouldPlayerResetEnergy(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`Hook.ShouldPlayerResetEnergy(state,Rival)`；返回值紧邻使用处：`IfStatementSyntax: if(Hook.ShouldPlayerResetEnergy(state,Rival))s.ResetEnergy();else s.AddMaxEnergyToCurrent();`
- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`c.CanPlay()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.CanPlay()`
- `MegaCrit.Sts2.Core.Models.CardModel.OnPlayWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, bool, MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo, bool)`；输入表达式：`card.OnPlayWrapper(new BlockingPlayerChoiceContext(),target,true,new(){EnergySpent=cost,EnergyValue=cost,StarsSpent=stars,StarValue=stars},true)`；返回值紧邻使用处：`AwaitExpressionSyntax: await card.OnPlayWrapper(new BlockingPlayerChoiceContext(),target,true,new(){EnergySpent=cost,EnergyValue=cost,StarsSpent=stars,StarValue=stars},true)`
- `MegaCrit.Sts2.Core.Models.CardModel.OnTurnEndInHandWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext)`；输入表达式：`c.OnTurnEndInHandWrapper(context)`；返回值紧邻使用处：`AwaitExpressionSyntax: await c.OnTurnEndInHandWrapper(context)`
- `MegaCrit.Sts2.Core.Models.CardModel.SpendResources()`；输入表达式：`card.SpendResources()`；返回值紧邻使用处：`AwaitExpressionSyntax: await card.SpendResources()`
- `NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`LeagueNativeMatch.ConsumeStun(Rival.Creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueNativeMatch.ConsumeStun(Rival.Creature)`
- `NationalSpire.LeagueNativeMatch.SharePlan(System.Collections.Generic.List<int>)`；输入表达式：`LeagueNativeMatch.SharePlan(wire)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeagueNativeMatch.SharePlan(wire)`
- `NationalSpire.LeagueSolverLink.Choose(decimal[], int[])`；输入表达式：`advisor!.Choose(amounts,props)`；返回值紧邻使用处：`AwaitExpressionSyntax: await advisor!.Choose(amounts,props)`
- `NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int)`；输入表达式：`LeagueSolverLink.Open(Rival,Tier,SetupCards,preference)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeagueSolverLink.Open(Rival,Tier,SetupCards,preference)`
- `NationalSpire.LeagueSolverLink.Rest()`；输入表达式：`advisor.Rest()`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach(var (instance,t) in advisor.Rest()){if(!identities.TryGetValue(instance,out var next))break;wire.AddRange([next,t]);}`
- `NationalSpire.LeagueTurnPlan.Choose(MegaCrit.Sts2.Core.Entities.Players.Player, decimal, int)`；输入表达式：`LeagueTurnPlan.Choose(Rival,threat,Math.Min(Tier,2))`；返回值紧邻使用处：`BinaryExpressionSyntax: best??LeagueTurnPlan.Choose(Rival,threat,Math.Min(Tier,2))`
- `ReadNext()`；输入表达式：`ReadNext()`；返回值紧邻使用处：`AssignmentExpressionSyntax: (card,target)=ReadNext()`
- `ReadNext()`；输入表达式：`ReadNext()`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (card,target)=ReadNext()`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',',s.Hand.Cards.Select(c=>c.Id.Entry))`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Energy+":"+s.Stars+":"+string.Join(',',s.Hand.Cards.Select(c=>c.Id.Entry))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,decimal>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,decimal>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<CardModel,int>(ReferenceEqualityComparer.Instance)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<CardModel,int>(ReferenceEqualityComparer.Instance)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`identities.TryGetValue(instance,out var next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !identities.TryGetValue(instance,out var next)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`seen.TryGetValue(key,out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: seen.TryGetValue(key,out var previous)&&(queued<=previous||queued>=state.Allies.Where(c=>c.IsAlive).Sum(c=>c.CurrentHp+c.Block))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Hand.Cards.Any(c=>c.CanPlay())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !s.Hand.Cards.Any(c=>c.CanPlay())`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Allies.Any(c=>c.IsAlive)`；返回值紧邻使用处：`BinaryExpressionSyntax: !skip&&Rival.Creature.IsAlive&&state.Allies.Any(c=>c.IsAlive)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.GetOpponentsOf(Rival.Creature).Any(t=>t.IsHittable&&(int?)t.CombatId==preference)`；返回值紧邻使用处：`ConditionalExpressionSyntax: state.GetOpponentsOf(Rival.Creature).Any(t=>t.IsHittable&&(int?)t.CombatId==preference)?preference:(int)state.GetOpponentsOf(Rival.Creature).First(t=>t.IsHittable).CombatId!.Value`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`s.Hand.Cards.Contains(c)`；返回值紧邻使用处：`IfStatementSyntax: if(s.Hand.Cards.Contains(c)){              await CardPileCmd.Add(c,PileType.Play,skipVisuals:true);await c.OnTurnEndInHandWrapper(context);              if(c.Keywords.Contains(CardKeyword.Ethereal))await CardCmd.Exhaust(context,c,true,true);              else await CardPileCmd.Add(c,PileType.Discard,skipVisuals:true);          }`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`LeagueNativeMatch.Fighters.TakeWhile(f=>f!=this).Count()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueNativeMatch.Fighters.TakeWhile(f=>f!=this).Count()`
- `System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate)).Except(bottom)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate)).Except(bottom).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.GetOpponentsOf(Rival.Creature).First(t=>t.IsHittable)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(Rival.Creature).First(t=>t.IsHittable).CombatId`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null).OrderBy(c=>c.Player!.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null).OrderBy(c=>c.Player!.NetId).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`incoming.Select(h=>(int)h.Props)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: incoming.Select(h=>(int)h.Props).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`incoming.Select(h=>h.Amount)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: incoming.Select(h=>h.Amount).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`s.Hand.Cards.Select(c=>c.Id.Entry)`；返回值紧邻使用处：`ArgumentSyntax: s.Hand.Cards.Select(c=>c.Id.Entry)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`Pending.Where(h=>h.Dealer==Rival.Creature).Sum(h=>h.Amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Pending.Where(h=>h.Dealer==Rival.Creature).Sum(h=>h.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`Pending.Where(h=>h.Target==Rival.Creature).Sum(h=>h.Amount)`；返回值紧邻使用处：`BinaryExpressionSyntax: Pending.Where(h=>h.Target==Rival.Creature).Sum(h=>h.Amount)-Rival.Creature.Block`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`state.Allies.Where(c=>c.IsAlive).Sum(c=>c.CurrentHp+c.Block)`；返回值紧邻使用处：`BinaryExpressionSyntax: queued>=state.Allies.Where(c=>c.IsAlive).Sum(c=>c.CurrentHp+c.Block)`
- `System.Collections.Generic.IEnumerable<TSource>.TakeWhile<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueNativeMatch.Fighters.TakeWhile(f=>f!=this)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueNativeMatch.Fighters.TakeWhile(f=>f!=this).Count`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`incoming.Select(h=>(int)h.Props).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =incoming.Select(h=>(int)h.Props).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`incoming.Select(h=>h.Amount).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =incoming.Select(h=>h.Amount).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Pending.Where(h=>h.Target==Rival.Creature).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Pending.Where(h=>h.Target==Rival.Creature).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`s.DrawPile.Cards.Where(c=>c.Enchantment?.ShouldStartAtBottomOfDrawPile==true).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =s.DrawPile.Cards.Where(c=>c.Enchantment?.ShouldStartAtBottomOfDrawPile==true).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate)).Except(bottom).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate)).Except(bottom).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`s.Hand.Cards.Where(c=>!c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)&&Hook.ShouldEtherealTrigger(state,c)).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in s.Hand.Cards.Where(c=>!c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)&&Hook.ShouldEtherealTrigger(state,c)).ToArray())              await MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(context,c,true);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`s.Hand.Cards.Where(c=>c.HasTurnEndInHandEffect).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =s.Hand.Cards.Where(c=>c.HasTurnEndInHandEffect).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null).OrderBy(c=>c.Player!.NetId).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null).OrderBy(c=>c.Player!.NetId).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Pending.Where(h=>h.Dealer==Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pending.Where(h=>h.Dealer==Rival.Creature).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Pending.Where(h=>h.Target==Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pending.Where(h=>h.Target==Rival.Creature).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Pending.Where(h=>h.Target==Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pending.Where(h=>h.Target==Rival.Creature).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.DrawPile.Cards.Where(c=>c.Enchantment?.ShouldStartAtBottomOfDrawPile==true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.DrawPile.Cards.Where(c=>c.Enchantment?.ShouldStartAtBottomOfDrawPile==true).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate)).Except`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Hand.Cards.Where(c=>!c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)&&Hook.ShouldEtherealTrigger(state,c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Hand.Cards.Where(c=>!c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)&&Hook.ShouldEtherealTrigger(state,c)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Hand.Cards.Where(c=>c.HasTurnEndInHandEffect)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Hand.Cards.Where(c=>c.HasTurnEndInHandEffect).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Allies.Where(c=>c.IsAlive)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Allies.Where(c=>c.IsAlive).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null).OrderBy`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`c.Keywords.Contains(CardKeyword.Ethereal)`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`c.Keywords.Contains(CardKeyword.Ethereal)`；返回值紧邻使用处：`IfStatementSyntax: if(c.Keywords.Contains(CardKeyword.Ethereal))await CardCmd.Exhaust(context,c,true,true);              else await CardPileCmd.Add(c,PileType.Discard,skipVisuals:true);`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`c.Keywords.Contains(CardKeyword.Innate)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>c.Keywords.Contains(CardKeyword.Innate)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`(flush&&!c.ShouldRetainThisTurn?discard:retain).Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: (flush&&!c.ShouldRetainThisTurn?discard:retain).Add(c);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`wire.AddRange([identities[chosen],aim])`；返回值紧邻使用处：`ExpressionStatementSyntax: wire.AddRange([identities[chosen],aim]);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`wire.AddRange([next,t])`；返回值紧邻使用处：`ExpressionStatementSyntax: wire.AddRange([next,t]);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardModel>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardModel>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<int>()`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`sequence.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: sequence.Clear();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`sequence.Enqueue((wire[j],wire[j+1]))`；返回值紧邻使用处：`ExpressionStatementSyntax: sequence.Enqueue((wire[j],wire[j+1]));`
- `System.Collections.Generic.Queue<T>.Queue()`；输入表达式：`new Queue<(int Id,int Aim)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Queue<(int Id,int Aim)>()`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,Pending.Where(h=>h.Target==Rival.Creature).Sum(h=>h.Amount)-Rival.Creature.Block)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(0,Pending.Where(h=>h.Target==Rival.Creature).Sum(h=>h.Amount)-Rival.Creature.Block)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(draw,innate.Length)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(draw,innate.Length)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,s.TurnNumber-1)`；返回值紧邻使用处：`BinaryExpressionSyntax: seat+Math.Max(0,s.TurnNumber-1)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(CardPile.MaxCardsInHand,Math.Max(draw,innate.Length))`；返回值紧邻使用处：`AssignmentExpressionSyntax: draw=Math.Min(CardPile.MaxCardsInHand,Math.Max(draw,innate.Length))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(Tier,2)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(Tier,2)`

**赋值（含属性/字段和局部值）：**

- `(card,target)` = `ReadNext()`
- `aim` = `(int)Rival.Creature.CombatId!.Value`
- `aim` = `state.GetOpponentsOf(Rival.Creature).Any(t=>t.IsHittable&&(int?)t.CombatId==preference)?preference:(int)state.GetOpponentsOf(Rival.Creature).First(t=>t.IsHittable).CombatId!.Value`
- `draw` = `Math.Min(CardPile.MaxCardsInHand,Math.Max(draw,innate.Length))`
- `EnergySpent` = `cost`
- `EnergyValue` = `cost`
- `j` += `2`
- `preference` = `(int)players[(seat+Math.Max(0,s.TurnNumber-1))%players.Length].CombatId!.Value`
- `seen[key]` = `queued`
- `StarsSpent` = `stars`
- `StarValue` = `stars`
- `var (card,target)` = `ReadNext()`
- `var (cost,stars)` = `await card.SpendResources()`
- `wire` = `await LeagueNativeMatch.SharePlan(wire)`

<a id="symbol-31678f6b407a"></a>

## `Identify() — void Identify()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.Act()`](LeagueDuel.cs.md#symbol-0b7f3276ecd9)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`identities.TryAdd(instance,identities.Count)`；返回值紧邻使用处：`ExpressionStatementSyntax: identities.TryAdd(instance,identities.Count);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b7d38e67716"></a>

## `ReadNext() — (CardModel?,Creature?) ReadNext()`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.Act()`](LeagueDuel.cs.md#symbol-0b7f3276ecd9)

**调用：** `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.TryDequeue(out T)`

**字段、属性、事件及方法组引用：** `(int Id, int Aim).Aim`；`(int Id, int Aim).Id`；`NationalSpire.LeagueDuel.Rival`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`x.CanPlay()`；返回值紧邻使用处：`BinaryExpressionSyntax: identities.TryGetValue(x,out var instance)&&instance==move.Id&&x.CanPlay()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`identities.TryGetValue(x,out var instance)`；返回值紧邻使用处：`BinaryExpressionSyntax: identities.TryGetValue(x,out var instance)&&instance==move.Id`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Hand.Cards.FirstOrDefault(x=>identities.TryGetValue(x,out var instance)&&instance==move.Id&&x.CanPlay())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =s.Hand.Cards.FirstOrDefault(x=>identities.TryGetValue(x,out var instance)&&instance==move.Id&&x.CanPlay())`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Creatures.FirstOrDefault(t=>t.CombatId==move.Aim&&t.IsAlive)`；返回值紧邻使用处：`ConditionalExpressionSyntax: move.Aim<0?null:state.Creatures.FirstOrDefault(t=>t.CombatId==move.Aim&&t.IsAlive)`
- `System.Collections.Generic.Queue<T>.TryDequeue(out T)`；输入表达式：`sequence.TryDequeue(out var move)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !sequence.TryDequeue(out var move)`

**赋值（含属性/字段和局部值）：**
