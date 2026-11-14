# LeagueBattleApi.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8132E4DCDFC8A2EC999D84F65A8674020D9E371774F1E65482B4E22B723A4C92`。来源：[源码](../../LeagueBattleApi.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueBattleApi`、`NationalSpire.LeagueBattleApi.Detailed<T>`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly MethodInfo NewRun=typeof(RunState).GetMethods().Single(m=>m.Name=="CreateForNewRun");
private static readonly MethodInfo MakeAnimator=typeof(CharacterModel).GetMethods().Single(m=>m.Name=="GenerateAnimator");
private static MethodInfo? _damage;
private static bool _detailed;
private static Func<LeagueDuel.Hit,Task>? _deliverWithEffects;
[ThreadStatic] private static bool _delivery;
private static Creature? _settling;
private static readonly MethodInfo LoseBlockCommand=typeof(CreatureCmd).GetMethods().Single(m=>m.Name=="LoseBlock");
private static readonly Send Damage=_damage!.CreateDelegate<Send>();
private static readonly Func<T,(Creature,string?,bool)> Unpack;
private static readonly Func<Creature,string?,bool,T> Pack;
```

<a id="symbol-8e2524ed4980"></a>

## `NationalSpire.LeagueBattleApi.Delivering() — private static bool Delivering()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueBattleApi.Detailed<T>.Record(System.Collections.Generic.IEnumerable<T>?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueBattleApi.cs.md#symbol-ed3c116afc58)；[`NationalSpire.LeagueBattleApi.Record(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueBattleApi.cs.md#symbol-91446c9c5697)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi._delivery`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_delivery` = `false`

<a id="symbol-3002944bf337"></a>

## `NationalSpire.LeagueBattleApi.SpendGuard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — internal static Task SpendGuard(PlayerChoiceContext context,Creature target,int amount,Creature source)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`](LeagueNativeMatch.cs.md#symbol-bea557065b97)

**调用：** [`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.LoseBlockCommand`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(LoseBlockCommand,null,LoseBlockCommand.GetParameters().Length==2?[target,(decimal)amount]:[context,target,(decimal)amount,source])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(LoseBlockCommand,null,LoseBlockCommand.GetParameters().Length==2?[target,(decimal)amount]:[context,target,(decimal)amount,source])!`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`LoseBlockCommand.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LoseBlockCommand.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3ef9bfd7ad99"></a>

## `NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string) — public static RunState Create(Player[] players,List<ActModel> acts,string seed)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.NewRun`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(NewRun,null,NewRun.GetParameters().Length==7?[players,acts,mods,GameMode.Standard,false,0,seed]:[players,acts,mods,GameMode.Standard,0,seed])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(NewRun,null,NewRun.GetParameters().Length==7?[players,acts,mods,GameMode.Standard,false,0,seed]:[players,acts,mods,GameMode.Standard,0,seed])!`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`NewRun.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NewRun.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9f23a519955"></a>

## `NationalSpire.LeagueBattleApi.Animator(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — public static CreatureAnimator Animator(CharacterModel role,MegaSprite sprite,Creature creature)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueOpponent.GenerateAnimator(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite)`](LeagueNativeMatch.cs.md#symbol-ff658a1871b3)

**调用：** [`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.MakeAnimator`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(MakeAnimator,role,MakeAnimator.GetParameters().Length==2?[sprite,creature]:[sprite])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(MakeAnimator,role,MakeAnimator.GetParameters().Length==2?[sprite,creature]:[sprite])!`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`MakeAnimator.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MakeAnimator.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5be518807d86"></a>

## `NationalSpire.LeagueBattleApi.Install(HarmonyLib.Harmony) — public static void Install(Harmony h)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)

**调用：** `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SingleOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetParameters()`；`System.Reflection.MethodInfo.CreateDelegate<T>()`；`System.Type.GetGenericTypeDefinition()`；`System.Type.GetMethods()`；`System.Type.MakeGenericType(params System.Type[])`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi._damage`；`NationalSpire.LeagueBattleApi._deliverWithEffects`；`NationalSpire.LeagueBattleApi._detailed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(type,"Deliver")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.DeclaredMethod(type,"Deliver").CreateDelegate<Func<LeagueDuel.Hit,Task>>`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(Hook),nameof(Hook.ModifyDamage))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(Hook),nameof(Hook.ModifyDamage))`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(_damage,prefix:new HarmonyMethod(type,"Record"))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(_damage,prefix:new HarmonyMethod(type,"Record"));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(Hook),nameof(Hook.ModifyDamage)),prefix:new HarmonyMethod(typeof(LeagueBattleApi),nameof(FixedAmount)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(Hook),nameof(Hook.ModifyDamage)),prefix:new HarmonyMethod(typeof(LeagueBattleApi),nameof(FixedAmount)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(type,"Record")`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(type,"Record")`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueBattleApi),nameof(FixedAmount))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueBattleApi),nameof(FixedAmount))`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`methods.Single(m=>m.GetParameters().Length==7)`；返回值紧邻使用处：`BinaryExpressionSyntax: methods.SingleOrDefault(m=>m.GetParameters()[1].ParameterType.GenericTypeArguments[0].Name=="DamageTargetData")??methods.Single(m=>m.GetParameters().Length==7)`
- `System.Collections.Generic.IEnumerable<TSource>.SingleOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`methods.SingleOrDefault(m=>m.GetParameters()[1].ParameterType.GenericTypeArguments[0].Name=="DamageTargetData")`；返回值紧邻使用处：`BinaryExpressionSyntax: methods.SingleOrDefault(m=>m.GetParameters()[1].ParameterType.GenericTypeArguments[0].Name=="DamageTargetData")??methods.Single(m=>m.GetParameters().Length==7)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`typeof(CreatureCmd).GetMethods().Where(m=>m.Name=="Damage"&&m.GetParameters() is [_,var targets,var amount,..]&&amount.ParameterType==typeof(decimal)&&targets.ParameterType.IsGenericType&&targets.ParameterType.GetGenericTypeDefinition()==typeof(IEnumerable<>)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(CreatureCmd).GetMethods().Where(m=>m.Name=="Damage"&&m.GetParameters() is [_,var targets,var amount,..]&&amount.ParameterType==typeof(decimal)&&targets.ParameterType.IsGenericType&&targets.ParameterType.GetGenericTypeDefinition()==typeof(IEnumerable<>)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`typeof(CreatureCmd).GetMethods().Where(m=>m.Name=="Damage"&&m.GetParameters() is [_,var targets,var amount,..]&&amount.ParameterType==typeof(decimal)&&targets.ParameterType.IsGenericType&&targets.ParameterType.GetGenericTypeDefinition()==typeof(IEnumerable<>))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(CreatureCmd).GetMethods().Where(m=>m.Name=="Damage"&&m.GetParameters() is [_,var targets,var amount,..]&&amount.ParameterType==typeof(decimal)&&targets.ParameterType.IsGenericType&&targets.ParameterType.GetGenericTypeDefinition()==typeof(IEnumerable<>)).ToArray`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`_damage.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: _damage.GetParameters()[1]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: m.GetParameters()[1]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`IsPatternExpressionSyntax: m.GetParameters() is [_,var targets,var amount,..]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`
- `System.Reflection.MethodInfo.CreateDelegate<T>()`；输入表达式：`AccessTools.DeclaredMethod(type,"Deliver").CreateDelegate<Func<LeagueDuel.Hit,Task>>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _deliverWithEffects=AccessTools.DeclaredMethod(type,"Deliver").CreateDelegate<Func<LeagueDuel.Hit,Task>>()`
- `System.Type.GetGenericTypeDefinition()`；输入表达式：`targets.ParameterType.GetGenericTypeDefinition()`；返回值紧邻使用处：`BinaryExpressionSyntax: targets.ParameterType.GetGenericTypeDefinition()==typeof(IEnumerable<>)`
- `System.Type.GetMethods()`；输入表达式：`typeof(CreatureCmd).GetMethods()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(CreatureCmd).GetMethods().Where`
- `System.Type.MakeGenericType(params System.Type[])`；输入表达式：`typeof(Detailed<>).MakeGenericType(_damage.GetParameters()[1].ParameterType.GenericTypeArguments[0])`；返回值紧邻使用处：`ConditionalExpressionSyntax: _detailed?typeof(Detailed<>).MakeGenericType(_damage.GetParameters()[1].ParameterType.GenericTypeArguments[0]):typeof(LeagueBattleApi)`

**赋值（含属性/字段和局部值）：**

- `_damage` = `methods.SingleOrDefault(m=>m.GetParameters()[1].ParameterType.GenericTypeArguments[0].Name=="DamageTargetData")??methods.Single(m=>m.GetParameters().Length==7)`
- `_deliverWithEffects` = `AccessTools.DeclaredMethod(type,"Deliver").CreateDelegate<Func<LeagueDuel.Hit,Task>>()`
- `_detailed` = `_damage.GetParameters()[1].ParameterType.GenericTypeArguments[0]!=typeof(Creature)`

<a id="symbol-91446c9c5697"></a>

## `NationalSpire.LeagueBattleApi.Record(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>) — private static bool Record(IEnumerable<Creature>? targets,decimal amount,ValueProp props,Creature? dealer,CardModel? cardSource,CardPlay? cardPlay,ref Task<IEnumerable<DamageResult>> __result)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueBattleApi.Delivering()`](LeagueBattleApi.cs.md#symbol-8e2524ed4980)；[`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.Delivering()`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueBattleApi.Delivering()`；输入表达式：`Delivering()`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueNativeMatch.Current==null||Delivering()`
- `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`；输入表达式：`LeagueNativeMatch.QueueHits(targets.Select(c=>(c,(string?)null,false)),amount,props,dealer,cardSource,cardPlay,ModifyDamageHookType.All,ref __result)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueNativeMatch.Current==null||Delivering()||targets==null||LeagueNativeMatch.QueueHits(targets.Select(c=>(c,(string?)null,false)),amount,props,dealer,cardSource,cardPlay,ModifyDamageHookType.All,ref __result)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targets.Select(c=>(c,(string?)null,false))`；返回值紧邻使用处：`ArgumentSyntax: targets.Select(c=>(c,(string?)null,false))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b12ba8272415"></a>

## `NationalSpire.LeagueBattleApi.FixedAmount(MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Models.CardModel?, ref MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType) — private static bool FixedAmount(Creature? dealer,CardPlay? cardPlay,CardModel? cardSource,ref ModifyDamageHookType modifyDamageHookType)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi._settling`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_settling` = `null`
- `modifyDamageHookType` = `ModifyDamageHookType.None`

<a id="symbol-0e3bd31351e4"></a>

## `NationalSpire.LeagueBattleApi.Deliver(NationalSpire.LeagueDuel.Hit) — public static async Task Deliver(LeagueDuel.Hit hit)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`](LeagueNativeMatch.cs.md#symbol-bea557065b97)

**调用：** [`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi._damage`；`NationalSpire.LeagueBattleApi._deliverWithEffects`；`NationalSpire.LeagueBattleApi._delivery`；`NationalSpire.LeagueBattleApi._detailed`；`NationalSpire.LeagueBattleApi._settling`；`NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Hit.Props`；`NationalSpire.LeagueDuel.Hit.Target`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；输入表达式：`new BlockingPlayerChoiceContext()`；返回值紧邻使用处：`ArgumentSyntax: new BlockingPlayerChoiceContext()`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(_damage!,null,new BlockingPlayerChoiceContext(),new[]{hit.Target},hit.Amount,hit.Props,hit.Dealer,null,null)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(_damage!,null,new BlockingPlayerChoiceContext(),new[]{hit.Target},hit.Amount,hit.Props,hit.Dealer,null,null)!`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`_deliverWithEffects!(hit)`；返回值紧邻使用处：`AssignmentExpressionSyntax: work=_deliverWithEffects!(hit)`

**赋值（含属性/字段和局部值）：**

- `_delivery` = `false`
- `_delivery` = `true`
- `_settling` = `hit.Dealer`
- `_settling` = `null`
- `work` = `_deliverWithEffects!(hit)`

<a id="symbol-17a1907ab25e"></a>

## `NationalSpire.LeagueBattleApi.Detailed<T>.Detailed() — static Detailed()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>()`；`System.Linq.Expressions.Expression.Bind(System.Reflection.MemberInfo, System.Linq.Expressions.Expression)`；`System.Linq.Expressions.Expression.Field(System.Linq.Expressions.Expression, string)`；`System.Linq.Expressions.Expression.Lambda<TDelegate>(System.Linq.Expressions.Expression, params System.Linq.Expressions.ParameterExpression[]?)`；`System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.NewExpression, params System.Linq.Expressions.MemberBinding[])`；`System.Linq.Expressions.Expression.New(System.Reflection.ConstructorInfo, params System.Linq.Expressions.Expression[]?)`；`System.Linq.Expressions.Expression.Parameter(System.Type)`；`System.Linq.Expressions.Expression<TDelegate>.Compile()`；`System.Type.GetConstructor(System.Type[])`；`System.Type.GetConstructors()`；`System.Type.GetField(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.Detailed<T>.Pack`；`NationalSpire.LeagueBattleApi.Detailed<T>.Unpack`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>()`；输入表达式：`typeof(ValueTuple<Creature,string,bool>).GetConstructors().Single()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(ValueTuple<Creature,string,bool>).GetConstructors().Single()`
- `System.Linq.Expressions.Expression.Bind(System.Reflection.MemberInfo, System.Linq.Expressions.Expression)`；输入表达式：`Expression.Bind(typeof(T).GetField("hitVfx")!,fx)`；返回值紧邻使用处：`ArgumentSyntax: Expression.Bind(typeof(T).GetField("hitVfx")!,fx)`
- `System.Linq.Expressions.Expression.Bind(System.Reflection.MemberInfo, System.Linq.Expressions.Expression)`；输入表达式：`Expression.Bind(typeof(T).GetField("playVfxOnCreatureCenter")!,center)`；返回值紧邻使用处：`ArgumentSyntax: Expression.Bind(typeof(T).GetField("playVfxOnCreatureCenter")!,center)`
- `System.Linq.Expressions.Expression.Field(System.Linq.Expressions.Expression, string)`；输入表达式：`Expression.Field(p,"hitVfx")`；返回值紧邻使用处：`ArgumentSyntax: Expression.Field(p,"hitVfx")`
- `System.Linq.Expressions.Expression.Field(System.Linq.Expressions.Expression, string)`；输入表达式：`Expression.Field(p,"playVfxOnCreatureCenter")`；返回值紧邻使用处：`ArgumentSyntax: Expression.Field(p,"playVfxOnCreatureCenter")`
- `System.Linq.Expressions.Expression.Field(System.Linq.Expressions.Expression, string)`；输入表达式：`Expression.Field(p,"target")`；返回值紧邻使用处：`ArgumentSyntax: Expression.Field(p,"target")`
- `System.Linq.Expressions.Expression.Lambda<TDelegate>(System.Linq.Expressions.Expression, params System.Linq.Expressions.ParameterExpression[]?)`；输入表达式：`Expression.Lambda<Func<Creature,string?,bool,T>>(value,who,fx,center)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Expression.Lambda<Func<Creature,string?,bool,T>>(value,who,fx,center).Compile`
- `System.Linq.Expressions.Expression.Lambda<TDelegate>(System.Linq.Expressions.Expression, params System.Linq.Expressions.ParameterExpression[]?)`；输入表达式：`Expression.Lambda<Func<T,(Creature,string?,bool)>>(Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter")),p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Expression.Lambda<Func<T,(Creature,string?,bool)>>(Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter")),p).Compile`
- `System.Linq.Expressions.Expression.MemberInit(System.Linq.Expressions.NewExpression, params System.Linq.Expressions.MemberBinding[])`；输入表达式：`Expression.MemberInit(Expression.New(typeof(T).GetConstructor([typeof(Creature)])!,who),Expression.Bind(typeof(T).GetField("hitVfx")!,fx),Expression.Bind(typeof(T).GetField("playVfxOnCreatureCenter")!,center))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Expression.MemberInit(Expression.New(typeof(T).GetConstructor([typeof(Creature)])!,who),Expression.Bind(typeof(T).GetField("hitVfx")!,fx),Expression.Bind(typeof(T).GetField("playVfxOnCreatureCenter")!,center))`
- `System.Linq.Expressions.Expression.New(System.Reflection.ConstructorInfo, params System.Linq.Expressions.Expression[]?)`；输入表达式：`Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter"))`；返回值紧邻使用处：`ArgumentSyntax: Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter"))`
- `System.Linq.Expressions.Expression.New(System.Reflection.ConstructorInfo, params System.Linq.Expressions.Expression[]?)`；输入表达式：`Expression.New(typeof(T).GetConstructor([typeof(Creature)])!,who)`；返回值紧邻使用处：`ArgumentSyntax: Expression.New(typeof(T).GetConstructor([typeof(Creature)])!,who)`
- `System.Linq.Expressions.Expression.Parameter(System.Type)`；输入表达式：`Expression.Parameter(typeof(bool))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Expression.Parameter(typeof(bool))`
- `System.Linq.Expressions.Expression.Parameter(System.Type)`；输入表达式：`Expression.Parameter(typeof(Creature))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Expression.Parameter(typeof(Creature))`
- `System.Linq.Expressions.Expression.Parameter(System.Type)`；输入表达式：`Expression.Parameter(typeof(string))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Expression.Parameter(typeof(string))`
- `System.Linq.Expressions.Expression.Parameter(System.Type)`；输入表达式：`Expression.Parameter(typeof(T))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Expression.Parameter(typeof(T))`
- `System.Linq.Expressions.Expression<TDelegate>.Compile()`；输入表达式：`Expression.Lambda<Func<Creature,string?,bool,T>>(value,who,fx,center).Compile()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Pack=Expression.Lambda<Func<Creature,string?,bool,T>>(value,who,fx,center).Compile()`
- `System.Linq.Expressions.Expression<TDelegate>.Compile()`；输入表达式：`Expression.Lambda<Func<T,(Creature,string?,bool)>>(Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter")),p).Compile()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Unpack=Expression.Lambda<Func<T,(Creature,string?,bool)>>(Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter")),p).Compile()`
- `System.Type.GetConstructor(System.Type[])`；输入表达式：`typeof(T).GetConstructor([typeof(Creature)])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: typeof(T).GetConstructor([typeof(Creature)])!`
- `System.Type.GetConstructors()`；输入表达式：`typeof(ValueTuple<Creature,string,bool>).GetConstructors()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(ValueTuple<Creature,string,bool>).GetConstructors().Single`
- `System.Type.GetField(string)`；输入表达式：`typeof(T).GetField("hitVfx")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: typeof(T).GetField("hitVfx")!`
- `System.Type.GetField(string)`；输入表达式：`typeof(T).GetField("playVfxOnCreatureCenter")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: typeof(T).GetField("playVfxOnCreatureCenter")!`

**赋值（含属性/字段和局部值）：**

- `Pack` = `Expression.Lambda<Func<Creature,string?,bool,T>>(value,who,fx,center).Compile()`
- `Unpack` = `Expression.Lambda<Func<T,(Creature,string?,bool)>>(Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter")),p).Compile()`

<a id="symbol-ed3c116afc58"></a>

## `NationalSpire.LeagueBattleApi.Detailed<T>.Record(System.Collections.Generic.IEnumerable<T>?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>) — private static bool Record(IEnumerable<T>? targetData,decimal amount,ValueProp props,Creature? dealer,CardModel? cardSource,CardPlay? cardPlay,ModifyDamageHookType modifyDamageHookType,ref Task<IEnumerable<DamageResult>> __result)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueBattleApi.Delivering()`](LeagueBattleApi.cs.md#symbol-8e2524ed4980)；[`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.Delivering()`；`NationalSpire.LeagueBattleApi.Detailed<T>.Unpack`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueBattleApi.Delivering()`；输入表达式：`Delivering()`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueNativeMatch.Current==null||Delivering()`
- `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`；输入表达式：`LeagueNativeMatch.QueueHits(targetData.Select(Unpack),amount,props,dealer,cardSource,cardPlay,modifyDamageHookType,ref __result)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueNativeMatch.Current==null||Delivering()||targetData==null||LeagueNativeMatch.QueueHits(targetData.Select(Unpack),amount,props,dealer,cardSource,cardPlay,modifyDamageHookType,ref __result)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targetData.Select(Unpack)`；返回值紧邻使用处：`ArgumentSyntax: targetData.Select(Unpack)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3b7414a8f3b1"></a>

## `NationalSpire.LeagueBattleApi.Detailed<T>.Deliver(NationalSpire.LeagueDuel.Hit) — internal static Task Deliver(LeagueDuel.Hit hit)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；`NationalSpire.LeagueBattleApi.Detailed<T>.Send.Invoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<T>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`（委托实际目标见流程文档）；`System.Func<T1, T2, T3, TResult>.Invoke(T1, T2, T3)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.Detailed<T>.Damage`；`NationalSpire.LeagueBattleApi.Detailed<T>.Pack`；`NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Center`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Hit.Props`；`NationalSpire.LeagueDuel.Hit.Target`；`NationalSpire.LeagueDuel.Hit.Vfx`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；输入表达式：`new BlockingPlayerChoiceContext()`；返回值紧邻使用处：`ArgumentSyntax: new BlockingPlayerChoiceContext()`
- `NationalSpire.LeagueBattleApi.Detailed<T>.Send.Invoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<T>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType)`；输入表达式：`Damage(new BlockingPlayerChoiceContext(),[Pack(hit.Target,hit.Vfx,hit.Center)],hit.Amount,hit.Props,hit.Dealer,null,null,ModifyDamageHookType.None)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Damage(new BlockingPlayerChoiceContext(),[Pack(hit.Target,hit.Vfx,hit.Center)],hit.Amount,hit.Props,hit.Dealer,null,null,ModifyDamageHookType.None)`
- `System.Func<T1, T2, T3, TResult>.Invoke(T1, T2, T3)`；输入表达式：`Pack(hit.Target,hit.Vfx,hit.Center)`；返回值紧邻使用处：`ExpressionElementSyntax: Pack(hit.Target,hit.Vfx,hit.Center)`

**赋值（含属性/字段和局部值）：**
