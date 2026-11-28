# LeagueEffectTargets.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`943FFA03375245763DBB0697836FC321A80D8652B0BC7CDF59C4E07DF3AC8323`。来源：[源码](../../LeagueEffectTargets.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueNativeMatch`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly HashSet<MethodBase> EffectPatches=[];
private static readonly HashSet<Type> SeenPowers=[];
private static readonly HashSet<Type> SeenTargetCards=[];
private static readonly Dictionary<Type,MethodInfo[]> TargetMethods=[];
private static Harmony _leagueHarmony=null!;
[ThreadStatic] private static bool _passApplication;
```

<a id="symbol-e5c8dd52e1ac"></a>

## `NationalSpire.LeagueNativeMatch.InstallEffectTargets(HarmonyLib.Harmony) — private static void InstallEffectTargets(Harmony h)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)

**调用：** [`Register(string, string)`](LeagueEffectTargets.cs.md#symbol-4bb2eee3d331)；`HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.EnumeratorMoveNext(System.Reflection.MethodBase)`；`HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MemberInfo.GetCustomAttribute<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._leagueHarmony`；`Register(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived"))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived"))`
- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay"))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay"))`
- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon"))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon"))`
- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(SleightOfFleshPower),"AfterPowerAmountChanged"))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(SleightOfFleshPower),"AfterPowerAmountChanged"))`
- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(StranglePower),"AfterCardPlayed"))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(StranglePower),"AfterCardPlayed"))`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(body,"MoveNext")`；返回值紧邻使用处：`ConditionalExpressionSyntax: body==null?applied:AccessTools.DeclaredMethod(body,"MoveNext")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(mark,"AfterSideTurnEnd")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(mark,"AfterSideTurnEnd")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(mark,"BeforeCardPlayed")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(mark,"BeforeCardPlayed")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(power,nameof(PowerModel.AfterApplied))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.DeclaredMethod(power,nameof(PowerModel.AfterApplied))`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CardModel),nameof(CardModel.OnPlayWrapper))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(CardModel),nameof(CardModel.OnPlayWrapper))`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CombatState),"IterateHookListeners")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(CombatState),"IterateHookListeners")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(InterceptPower),"RefreshCoveringNames")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(InterceptPower),"RefreshCoveringNames")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(MultiplayerScalingModel),nameof(MultiplayerScalingModel.ModifyBlockMultiplicative))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(MultiplayerScalingModel),nameof(MultiplayerScalingModel.ModifyBlockMultiplicative))`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(PowerModel),"ApplyInternal")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(PowerModel),"ApplyInternal")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(SleightOfFleshPower),"AfterPowerAmountChanged")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(SleightOfFleshPower),"AfterPowerAmountChanged")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(StranglePower),"AfterCardPlayed")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(StranglePower),"AfterCardPlayed")`
- `HarmonyLib.AccessTools.EnumeratorMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.EnumeratorMoveNext(AccessTools.DeclaredMethod(typeof(CombatState),"IterateHookListeners"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.EnumeratorMoveNext(AccessTools.DeclaredMethod(typeof(CombatState),"IterateHookListeners"))`
- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(PowerCmd))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(typeof(PowerCmd)).Single`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"ModifyPowerAmountReceived")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"ModifyPowerAmountReceived")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PowerCmd),"ModifyAmount")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(PowerCmd),"ModifyAmount")`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsSecondaryEnemy))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsSecondaryEnemy))`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ThornDamage)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ThornDamage)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AutoPlayTeams)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AutoPlayTeams)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FindExistingOsty)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FindExistingOsty)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(SleightOfFleshPower),"AfterPowerAmountChanged")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FleshOpponent)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(SleightOfFleshPower),"AfterPowerAmountChanged")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FleshOpponent)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(StranglePower),"AfterCardPlayed")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StrangleDamage)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(StranglePower),"AfterCardPlayed")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StrangleDamage)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(mark,"AfterSideTurnEnd"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EndCardMark)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(mark,"AfterSideTurnEnd"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EndCardMark)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(mark,"BeforeCardPlayed"),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(mark,"BeforeCardPlayed"),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareAutoPlay)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareAutoPlay)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(CardModel),nameof(CardModel.OnPlayWrapper)),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareCardTargets)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(CardModel),nameof(CardModel.OnPlayWrapper)),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareCardTargets)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(InterceptPower),"RefreshCoveringNames"),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterNames)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(InterceptPower),"RefreshCoveringNames"),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterNames)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(MultiplayerScalingModel),nameof(MultiplayerScalingModel.ModifyBlockMultiplicative)),             postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelBlockScaling)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(MultiplayerScalingModel),nameof(MultiplayerScalingModel.ModifyBlockMultiplicative)),             postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelBlockScaling)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(PowerModel),"ApplyInternal"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PreparePowerOwner)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(PowerModel),"ApplyInternal"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PreparePowerOwner)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.GetDeclaredMethods(typeof(PowerCmd)).Single(m=>m.Name=="Apply"&&!m.IsGenericMethod),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingPower)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.GetDeclaredMethods(typeof(PowerCmd)).Single(m=>m.Name=="Apply"&&!m.IsGenericMethod),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingPower)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"ModifyPowerAmountReceived"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelDoom)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"ModifyPowerAmountReceived"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelDoom)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(PowerCmd),"ModifyAmount"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingStack)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(PowerCmd),"ModifyAmount"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingStack)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsSecondaryEnemy)),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelPet)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsSecondaryEnemy)),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelPet)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(body==null?applied:AccessTools.DeclaredMethod(body,"MoveNext"),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterNames)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(body==null?applied:AccessTools.DeclaredMethod(body,"MoveNext"),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterNames)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(listeners,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterListeners)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(listeners,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterListeners)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AutoPlayTeams))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AutoPlayTeams))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelBlockScaling))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelBlockScaling))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelDoom))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelDoom))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelPet))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelPet))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EndCardMark))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EndCardMark))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterListeners))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterListeners))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterNames))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterNames))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FindExistingOsty))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FindExistingOsty))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FleshOpponent))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FleshOpponent))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingPower))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingPower))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingStack))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingStack))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareAutoPlay))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareAutoPlay))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareCardTargets))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareCardTargets))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PreparePowerOwner))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PreparePowerOwner))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StrangleDamage))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StrangleDamage))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ThornDamage))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ThornDamage))`
- `Register(string, string)`；输入表达式：`Register("Cards","BeatDown BouncingFlask Chill Conflagration CrushUnder DaggerSpray Deathbringer DyingStar EchoingSlash EndOfDays Haze HighFive Hyperbeam MementoMori MeteorShower Mirage Misery NegativePulse Outbreak PiercingWail Resonance Shiv Shockwave SovereignBlade Stomp SweepingBeam Thunderclap")`；返回值紧邻使用处：`ExpressionStatementSyntax: Register("Cards","BeatDown BouncingFlask Chill Conflagration CrushUnder DaggerSpray Deathbringer DyingStar EchoingSlash EndOfDays Haze HighFive Hyperbeam MementoMori MeteorShower Mirage Misery NegativePulse Outbreak PiercingWail Resonance Shiv Shockwave SovereignBlade Stomp SweepingBeam Thunderclap");`
- `Register(string, string)`；输入表达式：`Register("Orbs","LightningOrb DarkOrb GlassOrb FrostOrb")`；返回值紧邻使用处：`ExpressionStatementSyntax: Register("Orbs","LightningOrb DarkOrb GlassOrb FrostOrb");`
- `Register(string, string)`；输入表达式：`Register("Powers","BlackHolePower CacophonyPower CorrosiveWavePower CountdownPower ExplosiveArrowsPower GodByrdPower GravityPower HailstormPower HauntPower HellraiserPower InfernoPower JuggernautPower NecroMasteryPower NoxiousFumesPower PanachePower RollingBoulderPower SerpentFormPower SmokestackPower SpeedsterPower TheBombPower ViolentChordPower")`；返回值紧邻使用处：`ExpressionStatementSyntax: Register("Powers","BlackHolePower CacophonyPower CorrosiveWavePower CountdownPower ExplosiveArrowsPower GodByrdPower GravityPower HailstormPower HauntPower HellraiserPower InfernoPower JuggernautPower NecroMasteryPower NoxiousFumesPower PanachePower RollingBoulderPower SerpentFormPower SmokestackPower SpeedsterPower TheBombPower ViolentChordPower");`
- `Register(string, string)`；输入表达式：`Register("Powers","PoisonPower")`；返回值紧邻使用处：`ExpressionStatementSyntax: Register("Powers","PoisonPower");`
- `Register(string, string)`；输入表达式：`Register("Relics","CharonsAshes FestivePopper ForgottenSoul Kusarigama LetterOpener LostWisp Metronome MercuryHourglass MrStruggles ParryingShield ScreamingFlagon StoneCalendar Tingsha")`；返回值紧邻使用处：`ExpressionStatementSyntax: Register("Relics","CharonsAshes FestivePopper ForgottenSoul Kusarigama LetterOpener LostWisp Metronome MercuryHourglass MrStruggles ParryingShield ScreamingFlagon StoneCalendar Tingsha");`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredMethods(typeof(PowerCmd)).Single(m=>m.Name=="Apply"&&!m.IsGenericMethod)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.GetDeclaredMethods(typeof(PowerCmd)).Single(m=>m.Name=="Apply"&&!m.IsGenericMethod)`
- `System.Reflection.MemberInfo.GetCustomAttribute<T>()`；输入表达式：`applied.GetCustomAttribute<System.Runtime.CompilerServices.AsyncStateMachineAttribute>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: applied.GetCustomAttribute<System.Runtime.CompilerServices.AsyncStateMachineAttribute>()?.StateMachineType`

**赋值（含属性/字段和局部值）：**

- `_leagueHarmony` = `h`

<a id="symbol-4bb2eee3d331"></a>

## `Register(string, string) — void Register(string group,string names)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.InstallEffectTargets(HarmonyLib.Harmony)`](LeagueEffectTargets.cs.md#symbol-e5c8dd52e1ac)

**调用：** [`NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase)`](LeagueEffectTargets.cs.md#symbol-94808d795a03)；[`NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`](LeagueEffectTargets.cs.md#symbol-d9333bab0888)；[`NationalSpire.LeagueNativeMatch.Nested(System.Type)`](LeagueEffectTargets.cs.md#symbol-f360a5e17097)；[`NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type)`](LeagueEffectTargets.cs.md#symbol-48c3c345518a)；`HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；`string.Contains(string)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(string)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Reflection.Assembly.GetType(string)`；`System.Reflection.MethodBase.GetMethodBody()`；`System.Type.IsAssignableFrom(System.Type?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase)`；`NationalSpire.LeagueNativeMatch.EffectPatches`；`NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`；`NationalSpire.LeagueNativeMatch.Nested(System.Type)`；`NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(owner)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var m in AccessTools.GetDeclaredMethods(owner)){                     if(m.IsStatic||m.IsAbstract||m.GetMethodBody()==null||(!m.Name.Contains("OnPlay")&&owner==t&&m.Name.StartsWith("get_")))continue;                     if((!FindOwner(owner,t,out _)&&CardArgument(m)<0)||!PatchProcessor.ReadMethodBody(m).Any(op=>op.Value is MethodInfo mi&&(SideGetter(mi,t)||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower"))))continue;                     if(EffectPatches.Add(m))h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)));                 }`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides))`
- `HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；输入表达式：`PatchProcessor.ReadMethodBody(m)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PatchProcessor.ReadMethodBody(m).Any`
- `NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase)`；输入表达式：`CardArgument(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: CardArgument(m)<0`
- `NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`；输入表达式：`FindOwner(owner,t,out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !FindOwner(owner,t,out _)`
- `NationalSpire.LeagueNativeMatch.Nested(System.Type)`；输入表达式：`Nested(t)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var owner in Nested(t))foreach(var m in AccessTools.GetDeclaredMethods(owner)){                     if(m.IsStatic||m.IsAbstract||m.GetMethodBody()==null||(!m.Name.Contains("OnPlay")&&owner==t&&m.Name.StartsWith("get_")))continue;                     if((!FindOwner(owner,t,out _)&&CardArgument(m)<0)||!PatchProcessor.ReadMethodBody(m).Any(op=>op.Value is MethodInfo mi&&(SideGetter(mi,t)||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower"))))continue;                     if(EffectPatches.Add(m))h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)));                 }`
- `NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type)`；输入表达式：`SideGetter(mi,t)`；返回值紧邻使用处：`BinaryExpressionSyntax: SideGetter(mi,t)||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower")`
- `string.Contains(string)`；输入表达式：`m.Name.Contains("OnPlay")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !m.Name.Contains("OnPlay")`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`names.Split(' ')`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(string n in names.Split(' ')){                 var t=asm.GetType("MegaCrit.Sts2.Core.Models."+group+"."+n);if(t==null)continue;                 foreach(var owner in Nested(t))foreach(var m in AccessTools.GetDeclaredMethods(owner)){                     if(m.IsStatic||m.IsAbstract||m.GetMethodBody()==null||(!m.Name.Contains("OnPlay")&&owner==t&&m.Name.StartsWith("get_")))continue;                     if((!FindOwner(owner,t,out _)&&CardArgument(m)<0)||!PatchProcessor.ReadMethodBody(m).Any(op=>op.Value is MethodInfo mi&&(SideGetter(mi,t)||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower"))))continue;                     if(EffectPatches.Add(m))h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)));                 }             }`
- `string.StartsWith(string)`；输入表达式：`m.Name.StartsWith("get_")`；返回值紧邻使用处：`BinaryExpressionSyntax: !m.Name.Contains("OnPlay")&&owner==t&&m.Name.StartsWith("get_")`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`EffectPatches.Add(m)`；返回值紧邻使用处：`IfStatementSyntax: if(EffectPatches.Add(m))h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PatchProcessor.ReadMethodBody(m).Any(op=>op.Value is MethodInfo mi&&(SideGetter(mi,t)||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower")))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PatchProcessor.ReadMethodBody(m).Any(op=>op.Value is MethodInfo mi&&(SideGetter(mi,t)||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower")))`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`asm.GetType("MegaCrit.Sts2.Core.Models."+group+"."+n)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =asm.GetType("MegaCrit.Sts2.Core.Models."+group+"."+n)`
- `System.Reflection.MethodBase.GetMethodBody()`；输入表达式：`m.GetMethodBody()`；返回值紧邻使用处：`BinaryExpressionSyntax: m.GetMethodBody()==null`
- `System.Type.IsAssignableFrom(System.Type?)`；输入表达式：`typeof(OrbModel).IsAssignableFrom(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5a8f63229113"></a>

## `NationalSpire.LeagueNativeMatch.DuelPet(MegaCrit.Sts2.Core.Entities.Creatures.Creature, ref bool) — private static void DuelPet(Creature __instance,ref bool __result)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(owner)!=null`

**赋值（含属性/字段和局部值）：**

- `__result` = `true`

<a id="symbol-1f487c61d77d"></a>

## `NationalSpire.LeagueNativeMatch.FighterListeners(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase) — private static IEnumerable<CodeInstruction> FighterListeners(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.LoadLocal(int, bool)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetMethodBody()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterForHooks))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterForHooks))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`i.Calls(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player)))`；返回值紧邻使用处：`IfStatementSyntax: if(i.Calls(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player)))){                 yield return CodeInstruction.LoadLocal(list).MoveLabelsFrom(i).MoveBlocksFrom(i);                 yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterForHooks)));             }else yield return i;`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterForHooks)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterForHooks)));`
- `HarmonyLib.CodeInstruction.LoadLocal(int, bool)`；输入表达式：`CodeInstruction.LoadLocal(list)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CodeInstruction.LoadLocal(list).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`CodeInstruction.LoadLocal(list).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return CodeInstruction.LoadLocal(list).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`CodeInstruction.LoadLocal(list).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CodeInstruction.LoadLocal(list).MoveLabelsFrom(i).MoveBlocksFrom`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`__originalMethod.GetMethodBody()!.LocalVariables.Single(v=>v.LocalType==typeof(List<AbstractModel>))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: __originalMethod.GetMethodBody()!.LocalVariables.Single(v=>v.LocalType==typeof(List<AbstractModel>)).LocalIndex`
- `System.Reflection.MethodBase.GetMethodBody()`；输入表达式：`__originalMethod.GetMethodBody()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: __originalMethod.GetMethodBody()!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a8e0498a1bba"></a>

## `NationalSpire.LeagueNativeMatch.FighterForHooks(MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AbstractModel>) — private static Player? FighterForHooks(Creature c,List<AbstractModel> models)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(c)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: For(c)?.Rival`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`models.Add(c.Monster!)`；返回值紧邻使用处：`ExpressionStatementSyntax: models.Add(c.Monster!);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b6a887bb9b08"></a>

## `NationalSpire.LeagueNativeMatch.FindExistingOsty(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase) — private static IEnumerable<CodeInstruction> FindExistingOsty(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(__originalMethod.DeclaringType,"summoner")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Field(__originalMethod.DeclaringType,"summoner")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(SummonerTeam))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueNativeMatch),nameof(SummonerTeam))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(ICombatState),"Allies")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.PropertyGetter(typeof(ICombatState),"Allies")`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`i.Calls(AccessTools.PropertyGetter(typeof(ICombatState),"Allies"))`；返回值紧邻使用处：`IfStatementSyntax: if(i.Calls(AccessTools.PropertyGetter(typeof(ICombatState),"Allies"))){                 yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);                 yield return new CodeInstruction(OpCodes.Ldfld,owner);                 yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(SummonerTeam)));             }else yield return i;`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(SummonerTeam)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(SummonerTeam)));`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldfld,owner)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldfld,owner);`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dca4c0c18a8f"></a>

## `NationalSpire.LeagueNativeMatch.SummonerTeam(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player) — private static IReadOnlyList<Creature> SummonerTeam(ICombatState state,Player p)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`MegaCrit.Sts2.Core.Combat.ICombatState.GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.ICombatState.GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetTeammatesOf(p.Creature)`；返回值紧邻使用处：`ConditionalExpressionSyntax: For(p)!=null?state.GetTeammatesOf(p.Creature):state.Allies`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(p)!=null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-20e93e6e84c7"></a>

## `NationalSpire.LeagueNativeMatch.FighterNames(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> FighterNames(IEnumerable<CodeInstruction> instructions)`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterDisplayName))`；返回值紧邻使用处：`AssignmentExpressionSyntax: code[i+2].operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterDisplayName))`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PlatformUtil),nameof(PlatformUtil.GetPlayerName))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.Method(typeof(PlatformUtil),nameof(PlatformUtil.GetPlayerName))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Player),nameof(Player.NetId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(Player),nameof(Player.NetId))`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`code[i].Calls(player)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !code[i].Calls(player)`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`code[i+1].Calls(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !code[i+1].Calls(id)`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`code[i+2].Calls(name)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !code[i+2].Calls(name)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`instructions.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =instructions.ToArray()`

**赋值（含属性/字段和局部值）：**

- `code[i].opcode` = `code[i+1].opcode=OpCodes.Nop`
- `code[i].operand` = `code[i+1].operand=null`
- `code[i+1].opcode` = `OpCodes.Nop`
- `code[i+1].operand` = `null`
- `code[i+2].operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterDisplayName))`

<a id="symbol-bcf1bbec184b"></a>

## `NationalSpire.LeagueNativeMatch.FighterDisplayName(MegaCrit.Sts2.Core.Platform.PlatformType, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static string FighterDisplayName(PlatformType platform,Creature fighter)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；`MegaCrit.Sts2.Core.Platform.PlatformUtil.GetPlayerName(MegaCrit.Sts2.Core.Platform.PlatformType, ulong)`；`string.EscapeBbcodeTags()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.OpponentName`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Platform.PlatformUtil.GetPlayerName(MegaCrit.Sts2.Core.Platform.PlatformType, ulong)`；输入表达式：`PlatformUtil.GetPlayerName(platform,fighter.Player!.NetId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: For(fighter) is {} duel         ?duel.OpponentName.EscapeBbcodeTags():PlatformUtil.GetPlayerName(platform,fighter.Player!.NetId)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(fighter)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(fighter) is {} duel`
- `string.EscapeBbcodeTags()`；输入表达式：`duel.OpponentName.EscapeBbcodeTags()`；返回值紧邻使用处：`ConditionalExpressionSyntax: For(fighter) is {} duel         ?duel.OpponentName.EscapeBbcodeTags():PlatformUtil.GetPlayerName(platform,fighter.Player!.NetId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-197d5e8af68f"></a>

## `NationalSpire.LeagueNativeMatch.DuelBlockScaling(MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref decimal) — private static void DuelBlockScaling(Creature? target,ref decimal __result)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(target)!=null`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(target.PetOwner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(target.PetOwner)!=null`

**赋值（含属性/字段和局部值）：**

- `__result` = `1m`

<a id="symbol-399efc9e3bb5"></a>

## `NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo) — private static bool GeneratesCard(MethodInfo call)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.AllyTargetPlayer(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>)`](LeagueEffectTargets.cs.md#symbol-d47ac0f90bb1)；[`NationalSpire.LeagueNativeMatch.CardTargetMethods(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueEffectTargets.cs.md#symbol-9801f9c85a04)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-478bcbcccd99"></a>

## `NationalSpire.LeagueNativeMatch.PrepareCardTargets(MegaCrit.Sts2.Core.Models.CardModel) — private static void PrepareCardTargets(CardModel __instance)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.CardTargetMethods(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueEffectTargets.cs.md#symbol-9801f9c85a04)；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`object.GetType()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._leagueHarmony`；`NationalSpire.LeagueNativeMatch.CardTargetMethods(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.SeenTargetCards`；`NationalSpire.LeagueNativeMatch.TargetMethods`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AllyTargetPlayer)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AllyTargetPlayer)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AllyTargetPlayer))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AllyTargetPlayer))`
- `NationalSpire.LeagueNativeMatch.CardTargetMethods(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`CardTargetMethods(__instance)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CardTargetMethods(__instance).ToArray`
- `object.GetType()`；输入表达式：`__instance.GetType()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =__instance.GetType()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`TargetMethods.TryGetValue(cardType,out var methods)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TargetMethods.TryGetValue(cardType,out var methods)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`SeenTargetCards.Add(cardType)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SeenTargetCards.Add(cardType)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CardTargetMethods(__instance).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: methods=CardTargetMethods(__instance).ToArray()`

**赋值（含属性/字段和局部值）：**

- `methods` = `CardTargetMethods(__instance).ToArray()`
- `TargetMethods[cardType]` = `methods=CardTargetMethods(__instance).ToArray()`

<a id="symbol-9801f9c85a04"></a>

## `NationalSpire.LeagueNativeMatch.CardTargetMethods(MegaCrit.Sts2.Core.Models.CardModel) — private static IEnumerable<MethodInfo> CardTargetMethods(CardModel card)`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.PrepareCardTargets(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueEffectTargets.cs.md#symbol-478bcbcccd99)

**调用：** [`NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo)`](LeagueEffectTargets.cs.md#symbol-399efc9e3bb5)；[`NationalSpire.LeagueNativeMatch.Nested(System.Type)`](LeagueEffectTargets.cs.md#symbol-f360a5e17097)；`HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；`object.Equals(object?, object?)`；`object.GetType()`；`System.Collections.Generic.IEnumerable<TFirst>.Zip<TFirst, TSecond>(System.Collections.Generic.IEnumerable<TSecond>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Reflection.MethodBase.GetMethodBody()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo)`；`NationalSpire.LeagueNativeMatch.Nested(System.Type)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(type)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var method in AccessTools.GetDeclaredMethods(type)){             if(method.GetMethodBody()==null)continue;             var body=PatchProcessor.ReadMethodBody(method).ToArray();             if(body.Any(i=>i.Value is MethodInfo call && GeneratesCard(call)) ||                 (card.TargetType==TargetType.AnyAlly && body.Zip(body.Skip(1)).Any(p=>Equals(p.First.Value,target)&&Equals(p.Second.Value,player))))                 yield return method;         }`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(MegaCrit.Sts2.Core.Entities.Cards.CardPlay),"Target")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(MegaCrit.Sts2.Core.Entities.Cards.CardPlay),"Target")`
- `HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；输入表达式：`PatchProcessor.ReadMethodBody(method)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PatchProcessor.ReadMethodBody(method).ToArray`
- `NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo)`；输入表达式：`GeneratesCard(call)`；返回值紧邻使用处：`BinaryExpressionSyntax: i.Value is MethodInfo call && GeneratesCard(call)`
- `NationalSpire.LeagueNativeMatch.Nested(System.Type)`；输入表达式：`Nested(card.GetType())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var type in Nested(card.GetType()))foreach(var method in AccessTools.GetDeclaredMethods(type)){             if(method.GetMethodBody()==null)continue;             var body=PatchProcessor.ReadMethodBody(method).ToArray();             if(body.Any(i=>i.Value is MethodInfo call && GeneratesCard(call)) ||                 (card.TargetType==TargetType.AnyAlly && body.Zip(body.Skip(1)).Any(p=>Equals(p.First.Value,target)&&Equals(p.Second.Value,player))))                 yield return method;         }`
- `object.Equals(object?, object?)`；输入表达式：`Equals(p.First.Value,target)`；返回值紧邻使用处：`BinaryExpressionSyntax: Equals(p.First.Value,target)&&Equals(p.Second.Value,player)`
- `object.Equals(object?, object?)`；输入表达式：`Equals(p.Second.Value,player)`；返回值紧邻使用处：`BinaryExpressionSyntax: Equals(p.First.Value,target)&&Equals(p.Second.Value,player)`
- `object.GetType()`；输入表达式：`card.GetType()`；返回值紧邻使用处：`ArgumentSyntax: card.GetType()`
- `System.Collections.Generic.IEnumerable<TFirst>.Zip<TFirst, TSecond>(System.Collections.Generic.IEnumerable<TSecond>)`；输入表达式：`body.Zip(body.Skip(1))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Zip(body.Skip(1)).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`body.Any(i=>i.Value is MethodInfo call && GeneratesCard(call))`；返回值紧邻使用处：`BinaryExpressionSyntax: body.Any(i=>i.Value is MethodInfo call && GeneratesCard(call)) ||                 (card.TargetType==TargetType.AnyAlly && body.Zip(body.Skip(1)).Any(p=>Equals(p.First.Value,target)&&Equals(p.Second.Value,player)))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`body.Zip(body.Skip(1)).Any(p=>Equals(p.First.Value,target)&&Equals(p.Second.Value,player))`；返回值紧邻使用处：`BinaryExpressionSyntax: card.TargetType==TargetType.AnyAlly && body.Zip(body.Skip(1)).Any(p=>Equals(p.First.Value,target)&&Equals(p.Second.Value,player))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`body.Skip(1)`；返回值紧邻使用处：`ArgumentSyntax: body.Skip(1)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PatchProcessor.ReadMethodBody(method).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =PatchProcessor.ReadMethodBody(method).ToArray()`
- `System.Reflection.MethodBase.GetMethodBody()`；输入表达式：`method.GetMethodBody()`；返回值紧邻使用处：`BinaryExpressionSyntax: method.GetMethodBody()==null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d47ac0f90bb1"></a>

## `NationalSpire.LeagueNativeMatch.AllyTargetPlayer(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> AllyTargetPlayer(IEnumerable<CodeInstruction> instructions)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo)`](LeagueEffectTargets.cs.md#symbol-399efc9e3bb5)；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`System.Reflection.MethodBase.GetParameters()`；`System.Reflection.MethodInfo.GetGenericArguments()`；`System.Reflection.MethodInfo.MakeGenericMethod(params System.Type[])`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(LeagueNativeMatch),name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.DeclaredMethod(typeof(LeagueNativeMatch),name).MakeGenericMethod`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`；返回值紧邻使用处：`AssignmentExpressionSyntax: instruction.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(MegaCrit.Sts2.Core.Entities.Cards.CardPlay),"Target")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(MegaCrit.Sts2.Core.Entities.Cards.CardPlay),"Target")`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`instruction.Calls(player)`；返回值紧邻使用处：`BinaryExpressionSyntax: afterTarget&&instruction.Calls(player)`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`instruction.Calls(target)`；返回值紧邻使用处：`AssignmentExpressionSyntax: afterTarget=instruction.Calls(target)`
- `NationalSpire.LeagueNativeMatch.GeneratesCard(System.Reflection.MethodInfo)`；输入表达式：`GeneratesCard(call)`；返回值紧邻使用处：`BinaryExpressionSyntax: instruction.operand is MethodInfo call && GeneratesCard(call)`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`call.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: call.GetParameters()[0]`
- `System.Reflection.MethodInfo.GetGenericArguments()`；输入表达式：`call.GetGenericArguments()`；返回值紧邻使用处：`ArgumentSyntax: call.GetGenericArguments()`
- `System.Reflection.MethodInfo.MakeGenericMethod(params System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(LeagueNativeMatch),name).MakeGenericMethod(call.GetGenericArguments())`；返回值紧邻使用处：`AssignmentExpressionSyntax: instruction.operand=AccessTools.DeclaredMethod(typeof(LeagueNativeMatch),name).MakeGenericMethod(call.GetGenericArguments())`

**赋值（含属性/字段和局部值）：**

- `afterTarget` = `instruction.Calls(target)`
- `instruction.opcode` = `OpCodes.Call`
- `instruction.operand` = `AccessTools.DeclaredMethod(typeof(LeagueNativeMatch),name).MakeGenericMethod(call.GetGenericArguments())`
- `instruction.operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`

<a id="symbol-42ebe31dc5f7"></a>

## `NationalSpire.LeagueNativeMatch.GenerateForTargets<T>(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition) — private static async Task GenerateForTargets<T>(IEnumerable<Creature> targets,PileType pileType,int count,Player? creator,CardPilePosition position) where T:CardModel`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.GenerateForTarget<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`](LeagueEffectTargets.cs.md#symbol-07799f66fb88)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.GenerateForTarget<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.GenerateForTarget<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`；输入表达式：`GenerateForTarget<T>(target,pileType,count,creator,position)`；返回值紧邻使用处：`AwaitExpressionSyntax: await GenerateForTarget<T>(target,pileType,count,creator,position)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-07799f66fb88"></a>

## `NationalSpire.LeagueNativeMatch.GenerateForTarget<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition) — private static Task GenerateForTarget<T>(Creature target,PileType pileType,int count,Player? creator,CardPilePosition position) where T:CardModel`

来源：源码第 166 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.GenerateForTargets<T>(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`](LeagueEffectTargets.cs.md#symbol-42ebe31dc5f7)

**调用：** [`AddToRival()`](LeagueEffectTargets.cs.md#symbol-03fbd21e77f1)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；`MegaCrit.Sts2.Core.Commands.CardPileCmd.AddToCombatAndPreview<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`

**字段、属性、事件及方法组引用：** `AddToRival()`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AddToRival()`；输入表达式：`AddToRival()`；返回值紧邻使用处：`ReturnStatementSyntax: return AddToRival();`
- `MegaCrit.Sts2.Core.Commands.CardPileCmd.AddToCombatAndPreview<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`；输入表达式：`CardPileCmd.AddToCombatAndPreview<T>(target,pileType,count,creator,position)`；返回值紧邻使用处：`ReturnStatementSyntax: return CardPileCmd.AddToCombatAndPreview<T>(target,pileType,count,creator,position);`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(target)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(target) is {} fighter`

**赋值（含属性/字段和局部值）：**


<a id="symbol-03fbd21e77f1"></a>

## `AddToRival() — async Task AddToRival()`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.GenerateForTarget<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`](LeagueEffectTargets.cs.md#symbol-07799f66fb88)

**调用：** `MegaCrit.Sts2.Core.Combat.ICombatState.CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Commands.CardPileCmd.AddGeneratedCardToCombat(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.ICombatState.CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`state.CreateCard<T>(fighter.Rival)`；返回值紧邻使用处：`ArgumentSyntax: state.CreateCard<T>(fighter.Rival)`
- `MegaCrit.Sts2.Core.Commands.CardPileCmd.AddGeneratedCardToCombat(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Players.Player?, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition)`；输入表达式：`CardPileCmd.AddGeneratedCardToCombat(state.CreateCard<T>(fighter.Rival),pileType,creator,position)`；返回值紧邻使用处：`AwaitExpressionSyntax: await CardPileCmd.AddGeneratedCardToCombat(state.CreateCard<T>(fighter.Rival),pileType,creator,position)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a0a1c444bf34"></a>

## `NationalSpire.LeagueNativeMatch.PreparePowerOwner(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static void PreparePowerOwner(PowerModel __instance,Creature owner)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；[`NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?)`](LeagueEffectTargets.cs.md#symbol-0ae60a6af107)；[`NationalSpire.LeagueNativeMatch.Nested(System.Type)`](LeagueEffectTargets.cs.md#symbol-f360a5e17097)；`HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；`object.GetType()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetMethodBody()`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._leagueHarmony`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?)`；`NationalSpire.LeagueNativeMatch.Nested(System.Type)`；`NationalSpire.LeagueNativeMatch.SeenPowers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(type)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var method in AccessTools.GetDeclaredMethods(type)){             if(method.IsAbstract||method.GetMethodBody()==null)continue;object? prev=null;             if(method.Name=="AfterRemoved"&&method.GetParameters() is [{ParameterType:var old}]&&old==typeof(Creature)&&PatchProcessor.ReadMethodBody(method).Any(op=>op.Value is MethodInfo {Name:"get_Player",DeclaringType:var c}&&c==old)){                 _leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));continue;             }             foreach(var op in PatchProcessor.ReadMethodBody(method)){                 if(IsOwnerPair(prev,op.Value)){_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)));break;}                 prev=op.Value;             }         }`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair))`
- `HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；输入表达式：`PatchProcessor.ReadMethodBody(method)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var op in PatchProcessor.ReadMethodBody(method)){                 if(IsOwnerPair(prev,op.Value)){_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)));break;}                 prev=op.Value;             }`
- `HarmonyLib.PatchProcessor.ReadMethodBody(System.Reflection.MethodBase)`；输入表达式：`PatchProcessor.ReadMethodBody(method)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PatchProcessor.ReadMethodBody(method).Any`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(owner)==null`
- `NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?)`；输入表达式：`IsOwnerPair(prev,op.Value)`；返回值紧邻使用处：`IfStatementSyntax: if(IsOwnerPair(prev,op.Value)){_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)));break;}`
- `NationalSpire.LeagueNativeMatch.Nested(System.Type)`；输入表达式：`Nested(__instance.GetType())`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var type in Nested(__instance.GetType()))foreach(var method in AccessTools.GetDeclaredMethods(type)){             if(method.IsAbstract||method.GetMethodBody()==null)continue;object? prev=null;             if(method.Name=="AfterRemoved"&&method.GetParameters() is [{ParameterType:var old}]&&old==typeof(Creature)&&PatchProcessor.ReadMethodBody(method).Any(op=>op.Value is MethodInfo {Name:"get_Player",DeclaringType:var c}&&c==old)){                 _leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));continue;             }             foreach(var op in PatchProcessor.ReadMethodBody(method)){                 if(IsOwnerPair(prev,op.Value)){_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)));break;}                 prev=op.Value;             }         }`
- `object.GetType()`；输入表达式：`__instance.GetType()`；返回值紧邻使用处：`ArgumentSyntax: __instance.GetType()`
- `object.GetType()`；输入表达式：`__instance.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: __instance.GetType().Assembly`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`SeenPowers.Add(__instance.GetType())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SeenPowers.Add(__instance.GetType())`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PatchProcessor.ReadMethodBody(method).Any(op=>op.Value is MethodInfo {Name:"get_Player",DeclaringType:var c}&&c==old)`；返回值紧邻使用处：`BinaryExpressionSyntax: method.Name=="AfterRemoved"&&method.GetParameters() is [{ParameterType:var old}]&&old==typeof(Creature)&&PatchProcessor.ReadMethodBody(method).Any(op=>op.Value is MethodInfo {Name:"get_Player",DeclaringType:var c}&&c==old)`
- `System.Reflection.MethodBase.GetMethodBody()`；输入表达式：`method.GetMethodBody()`；返回值紧邻使用处：`BinaryExpressionSyntax: method.GetMethodBody()==null`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`method.GetParameters()`；返回值紧邻使用处：`IsPatternExpressionSyntax: method.GetParameters() is [{ParameterType:var old}]`

**赋值（含属性/字段和局部值）：**

- `prev` = `op.Value`

<a id="symbol-0ae60a6af107"></a>

## `NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?) — private static bool IsOwnerPair(object? first,object? second)`

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.PowerOwnerPair(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>)`](LeagueEffectTargets.cs.md#symbol-8003911790c8)；[`NationalSpire.LeagueNativeMatch.PreparePowerOwner(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-a0a1c444bf34)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8003911790c8"></a>

## `NationalSpire.LeagueNativeMatch.PowerOwnerPair(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> PowerOwnerPair(IEnumerable<CodeInstruction> instructions)`

来源：源码第 192 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?)`](LeagueEffectTargets.cs.md#symbol-0ae60a6af107)；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`；返回值紧邻使用处：`AssignmentExpressionSyntax: i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`
- `NationalSpire.LeagueNativeMatch.IsOwnerPair(object?, object?)`；输入表达式：`IsOwnerPair(prev,original)`；返回值紧邻使用处：`IfStatementSyntax: if(IsOwnerPair(prev,original)){i.opcode=OpCodes.Call;i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer));}`

**赋值（含属性/字段和局部值）：**

- `i.opcode` = `OpCodes.Call`
- `i.operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`
- `prev` = `original`

<a id="symbol-f360a5e17097"></a>

## `NationalSpire.LeagueNativeMatch.Nested(System.Type) — private static IEnumerable<Type> Nested(Type t)`

来源：源码第 196 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.CardTargetMethods(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueEffectTargets.cs.md#symbol-9801f9c85a04)；[`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)；[`NationalSpire.LeagueNativeMatch.Nested(System.Type)`](LeagueEffectTargets.cs.md#symbol-f360a5e17097)；[`NationalSpire.LeagueNativeMatch.PreparePowerOwner(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-a0a1c444bf34)；[`Register(string, string)`](LeagueEffectTargets.cs.md#symbol-4bb2eee3d331)

**调用：** [`NationalSpire.LeagueNativeMatch.Nested(System.Type)`](LeagueEffectTargets.cs.md#symbol-f360a5e17097)；`System.Type.GetNestedTypes(System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Nested(System.Type)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.Nested(System.Type)`；输入表达式：`Nested(child)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var item in Nested(child))yield return item;`
- `System.Type.GetNestedTypes(System.Reflection.BindingFlags)`；输入表达式：`t.GetNestedTypes(BindingFlags.Public|BindingFlags.NonPublic)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var child in t.GetNestedTypes(BindingFlags.Public|BindingFlags.NonPublic))foreach(var item in Nested(child))yield return item;`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7730fb03b2c9"></a>

## `NationalSpire.LeagueNativeMatch.FleshOpponent(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase) — private static IEnumerable<CodeInstruction> FleshOpponent(IEnumerable<CodeInstruction> code,MethodBase __originalMethod)`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；输入表达式：`AccessTools.GetDeclaredFields(__originalMethod.DeclaringType)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(FleshTarget))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueNativeMatch),nameof(FleshTarget))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsEnemy))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsEnemy))`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`i.Calls(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsEnemy)))`；返回值紧邻使用处：`IfStatementSyntax: if(i.Calls(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsEnemy)))){                 yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);                 yield return new CodeInstruction(OpCodes.Ldfld,power);                 yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FleshTarget)));             }else yield return i;`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FleshTarget)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FleshTarget)));`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldfld,power)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldfld,power);`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(SleightOfFleshPower))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(SleightOfFleshPower))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e0c529374457"></a>

## `NationalSpire.LeagueNativeMatch.FleshTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Models.Powers.SleightOfFleshPower) — private static bool FleshTarget(Creature target,SleightOfFleshPower power)`

来源：源码第 208 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._room`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b864f0d27d65"></a>

## `NationalSpire.LeagueNativeMatch.EndCardMark(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Combat.CombatSide, ref System.Threading.Tasks.Task) — private static bool EndCardMark(PowerModel __instance,CombatSide side,ref Task __result)`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Commands.PowerCmd.Remove(MegaCrit.Sts2.Core.Models.PowerModel?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._room`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.PowerCmd.Remove(MegaCrit.Sts2.Core.Models.PowerModel?)`；输入表达式：`PowerCmd.Remove(__instance)`；返回值紧邻使用处：`ConditionalExpressionSyntax: __instance.Applier.Side==side?PowerCmd.Remove(__instance):Task.CompletedTask`

**赋值（含属性/字段和局部值）：**

- `__result` = `__instance.Applier.Side==side?PowerCmd.Remove(__instance):Task.CompletedTask`

<a id="symbol-1fe2098b7769"></a>

## `NationalSpire.LeagueNativeMatch.StrangleDamage(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase) — private static IEnumerable<CodeInstruction> StrangleDamage(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod)`

来源：源码第 214 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；输入表达式：`AccessTools.GetDeclaredFields(__originalMethod.DeclaringType)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(StrangleHit))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueNativeMatch),nameof(StrangleHit))`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(StrangleHit)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(StrangleHit)));`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldfld,mark)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldfld,mark);`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(StranglePower))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(StranglePower))`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f254d1716b55"></a>

## `NationalSpire.LeagueNativeMatch.StrangleHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Models.Powers.StranglePower) — private static Task<IEnumerable<DamageResult>> StrangleHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,CardModel? source,MegaCrit.Sts2.Core.Entities.Cards.CardPlay? play,StranglePower mark)`

来源：源码第 224 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；`MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`；输入表达式：`CreatureCmd.Damage(ctx,target,amount,props,source,play)`；返回值紧邻使用处：`ReturnStatementSyntax: return CreatureCmd.Damage(ctx,target,amount,props,source,play);`
- `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`；输入表达式：`QueueHits([(target,null,false)],amount,props&~MegaCrit.Sts2.Core.ValueProps.ValueProp.Unblockable,mark.Applier,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !QueueHits([(target,null,false)],amount,props&~MegaCrit.Sts2.Core.ValueProps.ValueProp.Unblockable,mark.Applier,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bfcc5c218e36"></a>

## `NationalSpire.LeagueNativeMatch.AutoPlayTeams(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase) — private static IEnumerable<CodeInstruction> AutoPlayTeams(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Type.IsAssignableFrom(System.Type?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；输入表达式：`AccessTools.GetDeclaredFields(__originalMethod.DeclaringType)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Allies"?nameof(AutoAllies):nameof(EffectEnemies))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Allies"?nameof(AutoAllies):nameof(EffectEnemies))`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Allies"?nameof(AutoAllies):nameof(EffectEnemies)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Allies"?nameof(AutoAllies):nameof(EffectEnemies)));`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldfld,card)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldfld,card);`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(CardModel)&&f.Name=="card")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(CardModel)&&f.Name=="card")`
- `System.Type.IsAssignableFrom(System.Type?)`；输入表达式：`typeof(ICombatState).IsAssignableFrom(m.DeclaringType)`；返回值紧邻使用处：`BinaryExpressionSyntax: i.operand is MethodInfo m&&typeof(ICombatState).IsAssignableFrom(m.DeclaringType)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a955401df3dc"></a>

## `NationalSpire.LeagueNativeMatch.PrepareAutoPlay(MegaCrit.Sts2.Core.Models.CardModel, ref MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref bool) — private static void PrepareAutoPlay(CardModel card,ref Creature? target,ref bool skipCardPileVisuals)`

来源：源码第 240 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`MegaCrit.Sts2.Core.Random.Rng.NextItem<T>(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Fighters`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Random.Rng.NextItem<T>(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`card.Owner.RunState.Rng.CombatTargets.NextItem(Fighters.Select(f=>f.Rival.Creature).Where(c=>c.IsAlive&&c!=card.Owner.Creature))`；返回值紧邻使用处：`AssignmentExpressionSyntax: target=card.Owner.RunState.Rng.CombatTargets.NextItem(Fighters.Select(f=>f.Rival.Creature).Where(c=>c.IsAlive&&c!=card.Owner.Creature))`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(card.Owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(card.Owner)==null`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Fighters.Select(f=>f.Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Fighters.Select(f=>f.Rival.Creature).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Fighters.Select(f=>f.Rival.Creature).Where(c=>c.IsAlive&&c!=card.Owner.Creature)`；返回值紧邻使用处：`ArgumentSyntax: Fighters.Select(f=>f.Rival.Creature).Where(c=>c.IsAlive&&c!=card.Owner.Creature)`

**赋值（含属性/字段和局部值）：**

- `skipCardPileVisuals` = `true`
- `target` = `card.Owner.RunState.Rng.CombatTargets.NextItem(Fighters.Select(f=>f.Rival.Creature).Where(c=>c.IsAlive&&c!=card.Owner.Creature))`

<a id="symbol-cf54dad36cc2"></a>

## `NationalSpire.LeagueNativeMatch.AutoAllies(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.CardModel) — private static IReadOnlyList<Creature> AutoAllies(ICombatState state,CardModel card)`

来源：源码第 247 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`MegaCrit.Sts2.Core.Combat.ICombatState.GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.ICombatState.GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetTeammatesOf(d.Rival.Creature)`；返回值紧邻使用处：`ConditionalExpressionSyntax: For(card.Owner) is {} d?state.GetTeammatesOf(d.Rival.Creature):state.Allies`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(card.Owner)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(card.Owner) is {} d`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9333bab0888"></a>

## `NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>) — private static bool FindOwner(Type from,Type model,out List<FieldInfo> path)`

来源：源码第 248 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`](LeagueEffectTargets.cs.md#symbol-d9333bab0888)；[`NationalSpire.LeagueNativeMatch.ResolveEffectSides(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase)`](LeagueEffectTargets.cs.md#symbol-09d3958e73f5)；[`Register(string, string)`](LeagueEffectTargets.cs.md#symbol-4bb2eee3d331)

**调用：** [`NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`](LeagueEffectTargets.cs.md#symbol-d9333bab0888)；`HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredFields(System.Type)`；输入表达式：`AccessTools.GetDeclaredFields(from)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredFields(from).Where`
- `NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`；输入表达式：`FindOwner(f.FieldType,model,out var tail)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !FindOwner(f.FieldType,model,out var tail)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredFields(from).Where(f=>!f.IsStatic&&(f.FieldType==model||f.FieldType==from.DeclaringType)&&f.FieldType!=from)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var f in AccessTools.GetDeclaredFields(from).Where(f=>!f.IsStatic&&(f.FieldType==model||f.FieldType==from.DeclaringType)&&f.FieldType!=from)){             if(!FindOwner(f.FieldType,model,out var tail))continue;path=[f,..tail];return true;         }`

**赋值（含属性/字段和局部值）：**

- `path` = `[]`
- `path` = `[f,..tail]`

<a id="symbol-48c3c345518a"></a>

## `NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type) — private static bool SideGetter(MethodInfo m,Type model)`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.ResolveEffectSides(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase)`](LeagueEffectTargets.cs.md#symbol-09d3958e73f5)；[`Register(string, string)`](LeagueEffectTargets.cs.md#symbol-4bb2eee3d331)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-94808d795a03"></a>

## `NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase) — private static int CardArgument(MethodBase m)`

来源：源码第 256 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.ResolveEffectSides(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase)`](LeagueEffectTargets.cs.md#symbol-09d3958e73f5)；[`Register(string, string)`](LeagueEffectTargets.cs.md#symbol-4bb2eee3d331)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`m.GetParameters().FirstOrDefault(p=>p.ParameterType==typeof(CardModel))`；返回值紧邻使用处：`IsPatternExpressionSyntax: m.GetParameters().FirstOrDefault(p=>p.ParameterType==typeof(CardModel)) is {} card`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09d3958e73f5"></a>

## `NationalSpire.LeagueNativeMatch.ResolveEffectSides(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>, System.Reflection.MethodBase) — private static IEnumerable<CodeInstruction> ResolveEffectSides(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod)`

来源：源码第 257 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase)`](LeagueEffectTargets.cs.md#symbol-94808d795a03)；[`NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`](LeagueEffectTargets.cs.md#symbol-d9333bab0888)；[`NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type)`](LeagueEffectTargets.cs.md#symbol-48c3c345518a)；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；`HarmonyLib.CodeInstruction.LoadArgument(int, bool)`；`HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；`HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.IsAssignableFrom(System.Type?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase)`；`NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`；`NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Players"?nameof(TeamPlayers):m.Name=="get_Enemies"?nameof(CardOpponents):nameof(EffectEnemies))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Players"?nameof(TeamPlayers):m.Name=="get_Enemies"?nameof(CardOpponents):nameof(EffectEnemies))`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(PoisonHit))`；返回值紧邻使用处：`AssignmentExpressionSyntax: i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(PoisonHit))`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),targets.ParameterType==typeof(Creature)?nameof(OrbHit):nameof(EffectHit))`；返回值紧邻使用处：`AssignmentExpressionSyntax: i.operand=AccessTools.Method(typeof(LeagueNativeMatch),targets.ParameterType==typeof(Creature)?nameof(OrbHit):nameof(EffectHit))`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Players"?nameof(TeamPlayers):m.Name=="get_Enemies"?nameof(CardOpponents):nameof(EffectEnemies)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Players"?nameof(TeamPlayers):m.Name=="get_Enemies"?nameof(CardOpponents):nameof(EffectEnemies)));`
- `HarmonyLib.CodeInstruction.CodeInstruction(System.Reflection.Emit.OpCode, object)`；输入表达式：`new CodeInstruction(OpCodes.Ldfld,field)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new CodeInstruction(OpCodes.Ldfld,field);`
- `HarmonyLib.CodeInstruction.LoadArgument(int, bool)`；输入表达式：`CodeInstruction.LoadArgument(captured?0:CardArgument(__originalMethod))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CodeInstruction.LoadArgument(captured?0:CardArgument(__originalMethod)).MoveLabelsFrom`
- `HarmonyLib.CodeInstruction.MoveBlocksFrom(HarmonyLib.CodeInstruction)`；输入表达式：`CodeInstruction.LoadArgument(captured?0:CardArgument(__originalMethod)).MoveLabelsFrom(i).MoveBlocksFrom(i)`；返回值紧邻使用处：`YieldStatementSyntax: yield return CodeInstruction.LoadArgument(captured?0:CardArgument(__originalMethod)).MoveLabelsFrom(i).MoveBlocksFrom(i);`
- `HarmonyLib.CodeInstruction.MoveLabelsFrom(HarmonyLib.CodeInstruction)`；输入表达式：`CodeInstruction.LoadArgument(captured?0:CardArgument(__originalMethod)).MoveLabelsFrom(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CodeInstruction.LoadArgument(captured?0:CardArgument(__originalMethod)).MoveLabelsFrom(i).MoveBlocksFrom`
- `NationalSpire.LeagueNativeMatch.CardArgument(System.Reflection.MethodBase)`；输入表达式：`CardArgument(__originalMethod)`；返回值紧邻使用处：`ConditionalExpressionSyntax: captured?0:CardArgument(__originalMethod)`
- `NationalSpire.LeagueNativeMatch.FindOwner(System.Type, System.Type, out System.Collections.Generic.List<System.Reflection.FieldInfo>)`；输入表达式：`FindOwner(t,model,out var path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FindOwner(t,model,out var path)`
- `NationalSpire.LeagueNativeMatch.SideGetter(System.Reflection.MethodInfo, System.Type)`；输入表达式：`SideGetter(m,model)`；返回值紧邻使用处：`BinaryExpressionSyntax: i.operand is MethodInfo m&&SideGetter(m,model)`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`dmg.GetParameters()`；返回值紧邻使用处：`IsPatternExpressionSyntax: dmg.GetParameters() is [_,var targets,var amount,..] pars`
- `System.Type.IsAssignableFrom(System.Type?)`；输入表达式：`typeof(OrbModel).IsAssignableFrom(model)`；返回值紧邻使用处：`BinaryExpressionSyntax: typeof(OrbModel).IsAssignableFrom(model)||model.Name is "ExplosiveArrowsPower" or "ViolentChordPower" or "HailstormPower"`

**赋值（含属性/字段和局部值）：**

- `i.operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(PoisonHit))`
- `i.operand` = `AccessTools.Method(typeof(LeagueNativeMatch),targets.ParameterType==typeof(Creature)?nameof(OrbHit):nameof(EffectHit))`
- `model` = `model.DeclaringType`

<a id="symbol-ebb77af45201"></a>

## `NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?) — private static bool QueueDoom(PowerModel power,Creature target,decimal amount,Creature? applier,CardModel? source)`

来源：源码第 274 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.PendingPower(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, ref System.Threading.Tasks.Task)`](LeagueEffectTargets.cs.md#symbol-fba84bd095e8)；[`NationalSpire.LeagueNativeMatch.PendingStack(MegaCrit.Sts2.Core.Models.PowerModel, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, ref System.Threading.Tasks.Task<int>)`](LeagueEffectTargets.cs.md#symbol-172cad5ff820)

**调用：** [`NationalSpire.DuelRecorder.Declare(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, bool)`](DuelRecorder.cs.md#symbol-38f735caf04b)；[`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)；`NationalSpire.LeagueDuel.Hit.Hit(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, string?, bool)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder.Declare(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, bool)`；`NationalSpire.LeagueDuel.Hit.Doom`；`NationalSpire.LeagueDuel.Hit.DoomSource`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch._report`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.Declare(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, bool)`；输入表达式：`.Declare(applier,(int)amount,true)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _report?.Declare(applier,(int)amount,true)`
- `NationalSpire.LeagueDuel.Hit.Hit(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, string?, bool)`；输入表达式：`new(applier,target,amount,(MegaCrit.Sts2.Core.ValueProps.ValueProp)(-1),null,false){ DoomSource=source,Doom=true }`；返回值紧邻使用处：`ArgumentSyntax: new(applier,target,amount,(MegaCrit.Sts2.Core.ValueProps.ValueProp)(-1),null,false){ DoomSource=source,Doom=true }`
- `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；输入表达式：`Refresh(active)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(active);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`duel.Pending.Add(new(applier,target,amount,(MegaCrit.Sts2.Core.ValueProps.ValueProp)(-1),null,false){ DoomSource=source,Doom=true })`；返回值紧邻使用处：`ExpressionStatementSyntax: duel.Pending.Add(new(applier,target,amount,(MegaCrit.Sts2.Core.ValueProps.ValueProp)(-1),null,false){ DoomSource=source,Doom=true });`

**赋值（含属性/字段和局部值）：**

- `Doom` = `true`
- `DoomSource` = `source`

<a id="symbol-fba84bd095e8"></a>

## `NationalSpire.LeagueNativeMatch.PendingPower(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, ref System.Threading.Tasks.Task) — private static bool PendingPower(PowerModel power,Creature target,decimal amount,Creature? applier,CardModel? cardSource,ref Task __result)`

来源：源码第 281 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`](LeagueEffectTargets.cs.md#symbol-ebb77af45201)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._passApplication`；`NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`；输入表达式：`QueueDoom(power,target,amount,applier,cardSource)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !QueueDoom(power,target,amount,applier,cardSource)`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.CompletedTask`

<a id="symbol-172cad5ff820"></a>

## `NationalSpire.LeagueNativeMatch.PendingStack(MegaCrit.Sts2.Core.Models.PowerModel, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, ref System.Threading.Tasks.Task<int>) — private static bool PendingStack(PowerModel power,decimal offset,Creature? applier,CardModel? cardSource,ref Task<int> __result)`

来源：源码第 284 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`](LeagueEffectTargets.cs.md#symbol-ebb77af45201)；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._passApplication`；`NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`；输入表达式：`QueueDoom(power,power.Owner,offset,applier,cardSource)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !QueueDoom(power,power.Owner,offset,applier,cardSource)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult(power.Amount)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult(power.Amount)`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult(power.Amount)`

<a id="symbol-fc0ab243f3ba"></a>

## `NationalSpire.LeagueNativeMatch.DuelDoom(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref decimal) — private static void DuelDoom(ICombatState combatState,PowerModel canonicalPower,Creature target,Creature? giver,ref decimal __result)`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.AddedDoom(int)`](LeagueEffectTargets.cs.md#symbol-fba49341454f)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.AddedDoom(int)`；`NationalSpire.LeagueNativeMatch.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.AddedDoom(int)`；输入表达式：`AddedDoom((int)__result)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=AddedDoom((int)__result)`

**赋值（含属性/字段和局部值）：**

- `__result` = `AddedDoom((int)__result)`

<a id="symbol-fba49341454f"></a>

## `NationalSpire.LeagueNativeMatch.AddedDoom(int) — internal static int AddedDoom(int layers)`

来源：源码第 291 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.DuelDoom(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref decimal)`](LeagueEffectTargets.cs.md#symbol-fc0ab243f3ba)

**调用：** `decimal.Round(decimal, int, System.MidpointRounding)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int, System.MidpointRounding)`；输入表达式：`decimal.Round(layers/4m,0,MidpointRounding.AwayFromZero)`；返回值紧邻使用处：`CastExpressionSyntax: (int)decimal.Round(layers/4m,0,MidpointRounding.AwayFromZero)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee7b115c5652"></a>

## `NationalSpire.LeagueNativeMatch.PoisonHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?) — private static Task<IEnumerable<DamageResult>> PoisonHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,CardModel? source,MegaCrit.Sts2.Core.Entities.Cards.CardPlay? play)`

来源：源码第 292 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.GetPower<T>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`target.CombatState!.GetOpponentsOf(target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: target.CombatState!.GetOpponentsOf(target).First`
- `MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`；输入表达式：`CreatureCmd.Damage(ctx,target,amount,props,source,play)`；返回值紧邻使用处：`ReturnStatementSyntax: return CreatureCmd.Damage(ctx,target,amount,props,source,play);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.GetPower<T>()`；输入表达式：`target.GetPower<MegaCrit.Sts2.Core.Models.Powers.PoisonPower>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: target.GetPower<MegaCrit.Sts2.Core.Models.Powers.PoisonPower>()?.Applier`
- `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`；输入表达式：`QueueHits([(target,null,false)],amount,props&~MegaCrit.Sts2.Core.ValueProps.ValueProp.Unblockable,dealer,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !QueueHits([(target,null,false)],amount,props&~MegaCrit.Sts2.Core.ValueProps.ValueProp.Unblockable,dealer,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`target.CombatState!.GetOpponentsOf(target).First(c=>c.IsAlive)`；返回值紧邻使用处：`ConditionalExpressionSyntax: sourceActor!=null&&sourceActor.Side!=target.Side?sourceActor:target.CombatState!.GetOpponentsOf(target).First(c=>c.IsAlive)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-144f6521bbaf"></a>

## `NationalSpire.LeagueNativeMatch.OrbHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static Task<IEnumerable<DamageResult>> OrbHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,Creature dealer)`

来源：源码第 301 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-71ee665e8771)；`MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`CreatureCmd.Damage(ctx,target,amount,props,dealer)`；返回值紧邻使用处：`ReturnStatementSyntax: return CreatureCmd.Damage(ctx,target,amount,props,dealer);`
- `NationalSpire.LeagueNativeMatch.EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`EffectHit(ctx,[target],amount,props,dealer)`；返回值紧邻使用处：`ReturnStatementSyntax: return EffectHit(ctx,[target],amount,props,dealer);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-71ee665e8771"></a>

## `NationalSpire.LeagueNativeMatch.EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static Task<IEnumerable<DamageResult>> EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,IEnumerable<Creature> targets,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,Creature dealer)`

来源：源码第 305 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.OrbHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-144f6521bbaf)

**调用：** [`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；`MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`CreatureCmd.Damage(ctx,targets,amount,props,dealer)`；返回值紧邻使用处：`ReturnStatementSyntax: return CreatureCmd.Damage(ctx,targets,amount,props,dealer);`
- `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`；输入表达式：`QueueHits(targets.Select(t=>(t,(string?)null,false)),amount,props,dealer,null,null,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !QueueHits(targets.Select(t=>(t,(string?)null,false)),amount,props,dealer,null,null,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targets.Select(t=>(t,(string?)null,false))`；返回值紧邻使用处：`ArgumentSyntax: targets.Select(t=>(t,(string?)null,false))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a96e62e4a2c2"></a>

## `NationalSpire.LeagueNativeMatch.ThornDamage(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> ThornDamage(IEnumerable<CodeInstruction> code)`

来源：源码第 310 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(ThornHit))`；返回值紧邻使用处：`AssignmentExpressionSyntax: i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(ThornHit))`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`IsPatternExpressionSyntax: m.GetParameters() is [_,var target,var amount,_,_,_,_]`

**赋值（含属性/字段和局部值）：**

- `i.operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(ThornHit))`

<a id="symbol-4719d5d30a29"></a>

## `NationalSpire.LeagueNativeMatch.ThornHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?) — private static Task<IEnumerable<DamageResult>> ThornHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,Creature dealer,CardModel? source,MegaCrit.Sts2.Core.Entities.Cards.CardPlay? play)`

来源：源码第 317 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；`MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.CreatureCmd.Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`；输入表达式：`CreatureCmd.Damage(ctx,target,amount,props,dealer,source,play)`；返回值紧邻使用处：`ReturnStatementSyntax: return CreatureCmd.Damage(ctx,target,amount,props,dealer,source,play);`
- `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`；输入表达式：`QueueHits([(target,null,false)],amount,props,dealer,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !QueueHits([(target,null,false)],amount,props,dealer,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1504862aee7d"></a>

## `NationalSpire.LeagueNativeMatch.EffectEnemies(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.AbstractModel) — private static IReadOnlyList<Creature> EffectEnemies(ICombatState state,AbstractModel effect)`

来源：源码第 322 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetOpponentsOf(rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(rival.Creature).Where`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(power.Owner)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: PowerModel power=>For(power.Owner)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(card.Owner)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: CardModel card=>For(card.Owner)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(orb.Owner)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: OrbModel orb=>For(orb.Owner)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(relic.Owner)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: RelicModel relic=>For(relic.Owner)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`state.GetOpponentsOf(rival.Creature).Where(c=>c.IsHittable).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: enemy?state.GetOpponentsOf(rival.Creature).Where(c=>c.IsHittable).ToArray():state.HittableEnemies`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.GetOpponentsOf(rival.Creature).Where(c=>c.IsHittable)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.GetOpponentsOf(rival.Creature).Where(c=>c.IsHittable).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ebd81f72bada"></a>

## `NationalSpire.LeagueNativeMatch.TeamPlayers(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.OrbModel) — private static IReadOnlyList<Player> TeamPlayers(ICombatState state,OrbModel orb)`

来源：源码第 327 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Fighters`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(orb.Owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(orb.Owner)!=null`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Fighters.Select(f=>f.Rival)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Fighters.Select(f=>f.Rival).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Fighters.Select(f=>f.Rival).Where(p=>p.Creature.IsAlive).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: For(orb.Owner)!=null?Fighters.Select(f=>f.Rival).Where(p=>p.Creature.IsAlive).ToArray():state.Players`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Fighters.Select(f=>f.Rival).Where(p=>p.Creature.IsAlive)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Fighters.Select(f=>f.Rival).Where(p=>p.Creature.IsAlive).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e03fa69528cb"></a>

## `NationalSpire.LeagueNativeMatch.CardOpponents(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Models.CardModel) — private static IReadOnlyList<Creature> CardOpponents(ICombatState state,CardModel card)`

来源：源码第 328 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`state.GetOpponentsOf(duel.Rival.Creature)`；返回值紧邻使用处：`ConditionalExpressionSyntax: For(card.Owner) is {} duel&&duel.Rival.Creature.CombatState==state?state.GetOpponentsOf(duel.Rival.Creature):state.Enemies`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(card.Owner)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(card.Owner) is {} duel`

**赋值（含属性/字段和局部值）：**
