# LeagueBattleVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BF4F556FB9CDF9978C4CB95E8B96817379458A6594F47AA22E0252C2F46CACBF`。来源：[源码](../../LeagueBattleVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueNativeMatch`、`NationalSpire.LeagueRivalPlays`。

字段、事件及初始值（源码原样）：

```csharp
private static Action<NCreature,float,double> _sizePet=null!;
private readonly Queue<string> _names=new(3);
private Label _caption=null!;
private NCard? _face,_last;
private Tween? _motion,_captionMotion;
```

<a id="symbol-12673676d8ef"></a>

## `NationalSpire.LeagueNativeMatch.InstallVisuals(HarmonyLib.Harmony) — private static void InstallVisuals(Harmony h)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)

**调用：** [`Owner(System.Type, string)`](LeagueBattleVisuals.cs.md#symbol-ae3310a3b9fe)；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Reflection.MethodInfo.CreateDelegate<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._sizePet`；`Owner(System.Type, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"BeforeCardPlayed")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"BeforeCardPlayed")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(NCombatRoom),"AddCreature")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(NCombatRoom),"AddCreature")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(NCreature),"_Ready")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(NCreature),"_Ready")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(NCreature),"OstyScaleToSize")`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.DeclaredMethod(typeof(NCreature),"ScaleAndPositionOsty")??AccessTools.DeclaredMethod(typeof(NCreature),"OstyScaleToSize")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(NCreature),"ScaleAndPositionOsty")`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.DeclaredMethod(typeof(NCreature),"ScaleAndPositionOsty")??AccessTools.DeclaredMethod(typeof(NCreature),"OstyScaleToSize")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(NOrbManager),"OnCombatSetup")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(NOrbManager),"OnCombatSetup")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"BeforeCardPlayed"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ShowPlayedCard)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"BeforeCardPlayed"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ShowPlayedCard)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(NCombatRoom),"AddCreature"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetAdded)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(NCombatRoom),"AddCreature"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetAdded)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(NCreature),"_Ready"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(OrbDisplay)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(NCreature),"_Ready"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(OrbDisplay)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(NOrbManager),"OnCombatSetup"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(SetUpOrbSlots)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(NOrbManager),"OnCombatSetup"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(SetUpOrbSlots)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(size,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetGrew)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(size,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetGrew)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(OrbDisplay))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(OrbDisplay))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetAdded))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetAdded))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetGrew))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetGrew))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(SetUpOrbSlots))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(SetUpOrbSlots))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ShowPlayedCard))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ShowPlayedCard))`
- `Owner(System.Type, string)`；输入表达式：`Owner(typeof(NCombatRoom),"AddCreature")`；返回值紧邻使用处：`ExpressionStatementSyntax: Owner(typeof(NCombatRoom),"AddCreature");`
- `Owner(System.Type, string)`；输入表达式：`Owner(typeof(NOrbManager),"Create")`；返回值紧邻使用处：`ExpressionStatementSyntax: Owner(typeof(NOrbManager),"Create");`
- `Owner(System.Type, string)`；输入表达式：`Owner(typeof(NOrbManager),"get_Player")`；返回值紧邻使用处：`ExpressionStatementSyntax: Owner(typeof(NOrbManager),"get_Player");`
- `System.Reflection.MethodInfo.CreateDelegate<T>()`；输入表达式：`size.CreateDelegate<Action<NCreature,float,double>>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sizePet=size.CreateDelegate<Action<NCreature,float,double>>()`

**赋值（含属性/字段和局部值）：**

- `_sizePet` = `size.CreateDelegate<Action<NCreature,float,double>>()`

<a id="symbol-ae3310a3b9fe"></a>

## `Owner(System.Type, string) — void Owner(Type t,string m)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.InstallVisuals(HarmonyLib.Harmony)`](LeagueBattleVisuals.cs.md#symbol-12673676d8ef)

**调用：** `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(t,m)`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(t,m)`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(t,m),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>h.Patch(AccessTools.DeclaredMethod(t,m),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-088a8c52e9b8"></a>

## `NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature) — private static void OrbDisplay(NCreature __instance)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-f78a44bdbc8e)；[`NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-2e5d42d12c6a)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager.AddSlotAnim(int)`；`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager.Create(MegaCrit.Sts2.Core.Nodes.Combat.NCreature, bool)`；`System.Math.Abs(float)`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`__instance.AddChild(orbs)`；返回值紧邻使用处：`ExpressionStatementSyntax: __instance.AddChild(orbs);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-Math.Abs(body.Scale.X),body.Scale.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: body.Scale=new Vector2(-Math.Abs(body.Scale.X),body.Scale.Y)`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(NCreature),"SetOrbManagerPosition")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.DeclaredMethod(typeof(NCreature),"SetOrbManagerPosition").Invoke`
- `HarmonyLib.AccessTools.PropertySetter(System.Type, string)`；输入表达式：`AccessTools.PropertySetter(typeof(NCreature),nameof(NCreature.OrbManager))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.PropertySetter(typeof(NCreature),nameof(NCreature.OrbManager)).Invoke`
- `MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager.AddSlotAnim(int)`；输入表达式：`orbs.AddSlotAnim(r.PlayerCombatState.OrbQueue.Capacity)`；返回值紧邻使用处：`ExpressionStatementSyntax: orbs.AddSlotAnim(r.PlayerCombatState.OrbQueue.Capacity);`
- `MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager.Create(MegaCrit.Sts2.Core.Nodes.Combat.NCreature, bool)`；输入表达式：`NOrbManager.Create(__instance,false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =NOrbManager.Create(__instance,false)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(body.Scale.X)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Math.Abs(body.Scale.X)`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`AccessTools.DeclaredMethod(typeof(NCreature),"SetOrbManagerPosition").Invoke(__instance,null)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.DeclaredMethod(typeof(NCreature),"SetOrbManagerPosition").Invoke(__instance,null);`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`AccessTools.PropertySetter(typeof(NCreature),nameof(NCreature.OrbManager)).Invoke(__instance,[orbs])`；返回值紧邻使用处：`ExpressionStatementSyntax: AccessTools.PropertySetter(typeof(NCreature),nameof(NCreature.OrbManager)).Invoke(__instance,[orbs]);`

**赋值（含属性/字段和局部值）：**

- `body.Scale` = `new Vector2(-Math.Abs(body.Scale.X),body.Scale.Y)`

<a id="symbol-74e2d061d18a"></a>

## `NationalSpire.LeagueNativeMatch.SetUpOrbSlots(MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager) — private static bool SetUpOrbSlots(NOrbManager __instance)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Fighters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`.GetCreatureNode(f.Rival.Creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetCreatureNode(f.Rival.Creature)?.OrbManager`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Fighters.Any(f=>NCombatRoom.Instance?.GetCreatureNode(f.Rival.Creature)?.OrbManager==__instance)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Fighters.Any(f=>NCombatRoom.Instance?.GetCreatureNode(f.Rival.Creature)?.OrbManager==__instance)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4b556b6aac88"></a>

## `NationalSpire.LeagueNativeMatch.PetAdded(MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static void PetAdded(NCombatRoom __instance,Creature creature)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`Godot.Node.GetParent()`；`Godot.Node.Reparent(Godot.Node, bool)`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`System.Action<T1, T2, T3>.Invoke(T1, T2, T3)`（委托实际目标见流程文档）；`System.Math.Abs(float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._sizePet`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`lead.GetParent()`；返回值紧邻使用处：`ArgumentSyntax: lead.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`lead.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: pet.GetParent()!=lead.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`pet.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: pet.GetParent()!=lead.GetParent()`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`pet.Reparent(lead.GetParent(),true)`；返回值紧邻使用处：`ExpressionStatementSyntax: pet.Reparent(lead.GetParent(),true);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-Math.Abs(pet.Body.Scale.X),pet.Body.Scale.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: pet.Body.Scale=new(-Math.Abs(pet.Body.Scale.X),pet.Body.Scale.Y)`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`__instance.GetCreatureNode(creature)`；返回值紧邻使用处：`IsPatternExpressionSyntax: __instance.GetCreatureNode(creature) is not {} pet`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`__instance.GetCreatureNode(owner.Creature)`；返回值紧邻使用处：`IsPatternExpressionSyntax: __instance.GetCreatureNode(owner.Creature) is not {} lead`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(owner)==null`
- `System.Action<T1, T2, T3>.Invoke(T1, T2, T3)`；输入表达式：`_sizePet(pet,creature.MaxHp,0)`；返回值紧邻使用处：`ExpressionStatementSyntax: _sizePet(pet,creature.MaxHp,0);`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(pet.Body.Scale.X)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Math.Abs(pet.Body.Scale.X)`

**赋值（含属性/字段和局部值）：**

- `pet.Body.Scale` = `new(-Math.Abs(pet.Body.Scale.X),pet.Body.Scale.Y)`

<a id="symbol-3dd73d89fb14"></a>

## `NationalSpire.LeagueNativeMatch.PetGrew(MegaCrit.Sts2.Core.Nodes.Combat.NCreature) — private static void PetGrew(NCreature __instance)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Nodes.Combat.NCreature.GetOstyOffsetFromPlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-offset.X,offset.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: lead.GlobalPosition+new Vector2(-offset.X,offset.Y)`
- `MegaCrit.Sts2.Core.Nodes.Combat.NCreature.GetOstyOffsetFromPlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`NCreature.GetOstyOffsetFromPlayer(creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =NCreature.GetOstyOffsetFromPlayer(creature)`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`.GetCreatureNode(owner.Creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NCombatRoom.Instance?.GetCreatureNode(owner.Creature)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(owner)==null`

**赋值（含属性/字段和局部值）：**

- `__instance.GlobalPosition` = `lead.GlobalPosition+new Vector2(-offset.X,offset.Y)`

<a id="symbol-21d742c9c5dc"></a>

## `NationalSpire.LeagueNativeMatch.ShowPlayedCard(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, ref System.Threading.Tasks.Task) — private static void ShowPlayedCard(CardPlay cardPlay,ref Task __result)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；[`NationalSpire.LeagueNativeMatch.RevealBeforePlay(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Models.CardModel, NationalSpire.LeagueDuel)`](LeagueBattleVisuals.cs.md#symbol-f62bddf48704)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；`NationalSpire.LeagueNativeMatch.RevealBeforePlay(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Models.CardModel, NationalSpire.LeagueDuel)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(cardPlay.Card.Owner)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(cardPlay.Card.Owner) is {} duel`
- `NationalSpire.LeagueNativeMatch.RevealBeforePlay(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Models.CardModel, NationalSpire.LeagueDuel)`；输入表达式：`RevealBeforePlay(__result,cardPlay.Card,duel)`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=RevealBeforePlay(__result,cardPlay.Card,duel)`

**赋值（含属性/字段和局部值）：**

- `__result` = `RevealBeforePlay(__result,cardPlay.Card,duel)`

<a id="symbol-f62bddf48704"></a>

## `NationalSpire.LeagueNativeMatch.RevealBeforePlay(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Models.CardModel, NationalSpire.LeagueDuel) — private static async Task RevealBeforePlay(Task before,CardModel card,LeagueDuel duel)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.ShowPlayedCard(MegaCrit.Sts2.Core.Entities.Cards.CardPlay, ref System.Threading.Tasks.Task)`](LeagueBattleVisuals.cs.md#symbol-21d742c9c5dc)

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；[`NationalSpire.LeagueRivalPlays.Reveal(MegaCrit.Sts2.Core.Models.CardModel, Godot.Vector2)`](LeagueBattleVisuals.cs.md#symbol-e124f7ba9de9)；`Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.CanvasLayer.CanvasLayer()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；`Godot.Node.GetTree()`；`Godot.SceneTree.CreateTimer(double, bool, bool, bool)`；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.LeagueRivalPlays.LeagueRivalPlays()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；`NationalSpire.LeagueRivalPlays.Reveal(MegaCrit.Sts2.Core.Models.CardModel, Godot.Vector2)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`lead.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: lead.GetGlobalTransformWithCanvas().Origin`
- `Godot.CanvasLayer.CanvasLayer()`；输入表达式：`new CanvasLayer{Layer=9,Name="LeaguePlaysLayer"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CanvasLayer{Layer=9,Name="LeaguePlaysLayer"}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`gallery.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: gallery.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`room.ToSignal(room.GetTree().CreateTimer(.95),SceneTreeTimer.SignalName.Timeout)`；返回值紧邻使用处：`AwaitExpressionSyntax: await room.ToSignal(room.GetTree().CreateTimer(.95),SceneTreeTimer.SignalName.Timeout)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layer.AddChild(gallery)`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.AddChild(gallery);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`room.AddChild(layer)`；返回值紧邻使用处：`ExpressionStatementSyntax: room.AddChild(layer);`
- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`room.GetNodeOrNull<LeagueRivalPlays>("LeaguePlaysLayer/LeagueRivalPlays")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =room.GetNodeOrNull<LeagueRivalPlays>("LeaguePlaysLayer/LeagueRivalPlays")`
- `Godot.Node.GetTree()`；输入表达式：`room.GetTree()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: room.GetTree().CreateTimer`
- `Godot.SceneTree.CreateTimer(double, bool, bool, bool)`；输入表达式：`room.GetTree().CreateTimer(.95)`；返回值紧邻使用处：`ArgumentSyntax: room.GetTree().CreateTimer(.95)`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`room.GetCreatureNode(duel.Rival.Creature)`；返回值紧邻使用处：`IsPatternExpressionSyntax: room.GetCreatureNode(duel.Rival.Creature) is {} lead`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`For(duel.Rival)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(duel.Rival)!=duel`
- `NationalSpire.LeagueRivalPlays.LeagueRivalPlays()`；输入表达式：`new LeagueRivalPlays{Name="LeagueRivalPlays",MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`AssignmentExpressionSyntax: gallery=new LeagueRivalPlays{Name="LeagueRivalPlays",MouseFilter=Control.MouseFilterEnum.Ignore}`
- `NationalSpire.LeagueRivalPlays.Reveal(MegaCrit.Sts2.Core.Models.CardModel, Godot.Vector2)`；输入表达式：`gallery.Reveal(card,lead.GetGlobalTransformWithCanvas().Origin)`；返回值紧邻使用处：`ExpressionStatementSyntax: gallery.Reveal(card,lead.GetGlobalTransformWithCanvas().Origin);`

**赋值（含属性/字段和局部值）：**

- `gallery` = `new LeagueRivalPlays{Name="LeagueRivalPlays",MouseFilter=Control.MouseFilterEnum.Ignore}`
- `Layer` = `9`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `Name` = `"LeaguePlaysLayer"`
- `Name` = `"LeagueRivalPlays"`

<a id="symbol-7006c99a5fe9"></a>

## `NationalSpire.LeagueRivalPlays._Ready() — public override void _Ready()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.LeagueRivalPlays._caption`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("172129")`；返回值紧邻使用处：`ArgumentSyntax: new Color("172129")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("efdfba")`；返回值紧邻使用处：`ArgumentSyntax: new Color("efdfba")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_caption.AddThemeColorOverride("font_color",new Color("efdfba"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeColorOverride("font_color",new Color("efdfba"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_caption.AddThemeColorOverride("font_outline_color",new Color("172129"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeColorOverride("font_outline_color",new Color("172129"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_caption.AddThemeConstantOverride("outline_size",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeConstantOverride("outline_size",6);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`_caption.AddThemeFontOverride("font",CareerVisuals.InterfaceText(600))`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeFontOverride("font",CareerVisuals.InterfaceText(600));`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_caption.AddThemeFontSizeOverride("font_size",21)`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeFontSizeOverride("font_size",21);`
- `Godot.Label.Label()`；输入表达式：`new Label{MouseFilter=MouseFilterEnum.Ignore,HorizontalAlignment=HorizontalAlignment.Center,Modulate=Colors.Transparent}`；返回值紧邻使用处：`AssignmentExpressionSyntax: _caption=new Label{MouseFilter=MouseFilterEnum.Ignore,HorizontalAlignment=HorizontalAlignment.Center,Modulate=Colors.Transparent}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_caption);`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`CareerVisuals.InterfaceText(600)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.InterfaceText(600)`

**赋值（含属性/字段和局部值）：**

- `_caption` = `new Label{MouseFilter=MouseFilterEnum.Ignore,HorizontalAlignment=HorizontalAlignment.Center,Modulate=Colors.Transparent}`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `Modulate` = `Colors.Transparent`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-e124f7ba9de9"></a>

## `NationalSpire.LeagueRivalPlays.Reveal(MegaCrit.Sts2.Core.Models.CardModel, Godot.Vector2) — internal void Reveal(CardModel model,Vector2 start)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.RevealBeforePlay(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Models.CardModel, NationalSpire.LeagueDuel)`](LeagueBattleVisuals.cs.md#symbol-f62bddf48704)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.Control.ResetSize()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Node.QueueFree()`；`Godot.PackedScene.Instantiate<T>(Godot.PackedScene.GenEditState)`；`Godot.PropertyTweener.SetEase(Godot.Tween.EaseType)`；`Godot.PropertyTweener.SetTrans(Godot.Tween.TransitionType)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`Godot.Tween.Chain()`；`Godot.Tween.Kill()`；`Godot.Tween.SetParallel(bool)`；`Godot.Tween.TweenCallback(Godot.Callable)`；`Godot.Tween.TweenInterval(double)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Nodes.Cards.NCard.UpdateVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`；`NationalSpire.LeagueRivalPlays._caption`；`NationalSpire.LeagueRivalPlays._captionMotion`；`NationalSpire.LeagueRivalPlays._face`；`NationalSpire.LeagueRivalPlays._last`；`NationalSpire.LeagueRivalPlays._motion`；`NationalSpire.LeagueRivalPlays._names`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(face.QueueFree)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(face.QueueFree)`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(previous.QueueFree)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(previous.QueueFree)`
- `Godot.CanvasItem.Hide()`；输入表达式：`_last.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _last.Hide();`
- `Godot.Control.ResetSize()`；输入表达式：`_caption.ResetSize()`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.ResetSize();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_last)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_last)&&!_last!.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_last!.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_last!.IsQueuedForDeletion()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(face);`
- `Godot.Node.CreateTween()`；输入表达式：`_caption.CreateTween()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _captionMotion=_caption.CreateTween()`
- `Godot.Node.CreateTween()`；输入表达式：`face.CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: face.CreateTween().SetParallel`
- `Godot.Node.CreateTween()`；输入表达式：`previous.CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: previous.CreateTween().SetParallel`
- `Godot.Node.QueueFree()`；输入表达式：`_last.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _last.QueueFree();`
- `Godot.PackedScene.Instantiate<T>(Godot.PackedScene.GenEditState)`；输入表达式：`ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>()`
- `Godot.PropertyTweener.SetEase(Godot.Tween.EaseType)`；输入表达式：`t.TweenProperty(face,"position",at,.18).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenProperty(face,"position",at,.18).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);`
- `Godot.PropertyTweener.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`t.TweenProperty(face,"position",at,.18).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.TweenProperty(face,"position",at,.18).SetTrans(Tween.TransitionType.Cubic).SetEase`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>`
- `Godot.Tween.Chain()`；输入表达式：`retreat.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: retreat.Chain().TweenCallback`
- `Godot.Tween.Chain()`；输入表达式：`retreat.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: retreat.Chain().TweenInterval`
- `Godot.Tween.Chain()`；输入表达式：`retreat.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: retreat.Chain().TweenProperty`
- `Godot.Tween.Chain()`；输入表达式：`t.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Chain().TweenCallback`
- `Godot.Tween.Chain()`；输入表达式：`t.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Chain().TweenInterval`
- `Godot.Tween.Chain()`；输入表达式：`t.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Chain().TweenProperty`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _captionMotion?.Kill()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _motion?.Kill()`
- `Godot.Tween.SetParallel(bool)`；输入表达式：`face.CreateTween().SetParallel()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _motion=face.CreateTween().SetParallel()`
- `Godot.Tween.SetParallel(bool)`；输入表达式：`previous.CreateTween().SetParallel()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =previous.CreateTween().SetParallel()`
- `Godot.Tween.TweenCallback(Godot.Callable)`；输入表达式：`retreat.Chain().TweenCallback(Callable.From(previous.QueueFree))`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.Chain().TweenCallback(Callable.From(previous.QueueFree));`
- `Godot.Tween.TweenCallback(Godot.Callable)`；输入表达式：`t.Chain().TweenCallback(Callable.From(face.QueueFree))`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Chain().TweenCallback(Callable.From(face.QueueFree));`
- `Godot.Tween.TweenInterval(double)`；输入表达式：`_captionMotion.TweenInterval(2.6)`；返回值紧邻使用处：`ExpressionStatementSyntax: _captionMotion.TweenInterval(2.6);`
- `Godot.Tween.TweenInterval(double)`；输入表达式：`retreat.Chain().TweenInterval(.36)`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.Chain().TweenInterval(.36);`
- `Godot.Tween.TweenInterval(double)`；输入表达式：`t.Chain().TweenInterval(.84)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Chain().TweenInterval(.84);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`_captionMotion.TweenProperty(_caption,"modulate:a",0,.3)`；返回值紧邻使用处：`ExpressionStatementSyntax: _captionMotion.TweenProperty(_caption,"modulate:a",0,.3);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`retreat.Chain().TweenProperty(previous,"modulate:a",0,.16)`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.Chain().TweenProperty(previous,"modulate:a",0,.16);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`retreat.TweenProperty(previous,"modulate:a",.72f,.16)`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.TweenProperty(previous,"modulate:a",.72f,.16);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`retreat.TweenProperty(previous,"position",at+new Vector2(-122,-6),.16)`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.TweenProperty(previous,"position",at+new Vector2(-122,-6),.16);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`retreat.TweenProperty(previous,"rotation",-.065f,.16)`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.TweenProperty(previous,"rotation",-.065f,.16);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`retreat.TweenProperty(previous,"scale",Vector2.One*.41f,.16)`；返回值紧邻使用处：`ExpressionStatementSyntax: retreat.TweenProperty(previous,"scale",Vector2.One*.41f,.16);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`t.Chain().TweenProperty(face,"modulate:a",0,.22)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Chain().TweenProperty(face,"modulate:a",0,.22);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`t.TweenProperty(face,"position",at,.18)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.TweenProperty(face,"position",at,.18).SetTrans`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`t.TweenProperty(face,"rotation",0,.18)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenProperty(face,"rotation",0,.18);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`t.TweenProperty(face,"scale",Vector2.One*.60f,.18)`；返回值紧邻使用处：`ExpressionStatementSyntax: t.TweenProperty(face,"scale",Vector2.One*.60f,.18);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-122,-6)`；返回值紧邻使用处：`BinaryExpressionSyntax: at+new Vector2(-122,-6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8)),at.Y-153)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _caption.Position=new Vector2(Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8)),at.Y-153)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X*.62f,Size.Y*.275f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(Size.X*.62f,Size.Y*.275f)`
- `MegaCrit.Sts2.Core.Nodes.Cards.NCard.UpdateVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode)`；输入表达式：`face.UpdateVisuals(PileType.Play,CardPreviewMode.Normal)`；返回值紧邻使用处：`ExpressionStatementSyntax: face.UpdateVisuals(PileType.Play,CardPreviewMode.Normal);`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(model.Title)`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(model.Title)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("  ›  ",_names)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对手出牌   ·   "+string.Join("  ›  ",_names)`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`_names.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: _names.Dequeue();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_names.Enqueue(GameText.Plain(model.Title))`；返回值紧邻使用处：`ExpressionStatementSyntax: _names.Enqueue(GameText.Plain(model.Title));`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(8,Size.X-_caption.Size.X-8)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(8,Size.X-_caption.Size.X-8)`

**赋值（含属性/字段和局部值）：**

- `_caption.Modulate` = `Colors.White`
- `_caption.Position` = `new Vector2(Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8)),at.Y-153)`
- `_caption.Text` = `"对手出牌   ·   "+string.Join("  ›  ",_names)`
- `_captionMotion` = `_caption.CreateTween()`
- `_face` = `face`
- `_last` = `_face`
- `_motion` = `face.CreateTween().SetParallel()`
- `face.Model` = `model`
- `face.MouseFilter` = `MouseFilterEnum.Ignore`
- `face.Position` = `start`
- `face.Rotation` = `.095f`
- `face.Scale` = `Vector2.One*.22f`
