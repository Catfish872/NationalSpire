# Compatibility/LeagueSolver/LeagueForecast.Projection.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`26199A4AF439703405E25A63FF5F6B48D6802532AC03F10265BEEFCB58A35D27`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueForecast.Projection.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueForecast`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Player _live=rival;
private Player? _actor;
private readonly Dictionary<CardModel,CardModel> _originals=new(ReferenceEqualityComparer.Instance);
private static readonly AccessTools.FieldRef<PlayerCombatState,int> StarBalance=AccessTools.FieldRefAccess<PlayerCombatState,int>("_stars");
private readonly Dictionary<Creature,int> _aims=[];
```

<a id="symbol-f2559c94c021"></a>

## `NationalSpire.Solver.LeagueForecast.Prepare() — public static void Prepare()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Solver.LeagueForecast.InstallDuelHooks()`](LeagueForecast.DuelRules.cs.md#symbol-64d43e425e59)；`CombatSolver.SolverWarmup.StartBackgroundWarmup()`；`HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(System.RuntimeMethodHandle)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast.InstallDuelHooks()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.SolverWarmup.StartBackgroundWarmup()`；输入表达式：`SolverWarmup.StartBackgroundWarmup()`；返回值紧邻使用处：`ExpressionStatementSyntax: SolverWarmup.StartBackgroundWarmup();`
- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(type)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var method in AccessTools.GetDeclaredMethods(type))                 if(method.Name is nameof(HotCombatEngine.Step) or nameof(HotCombatEngine.EnumerateLegalActions)                     or nameof(HotEvaluator.EvaluateState) or nameof(HotEvaluator.ExtractStage1))                     RuntimeHelpers.PrepareMethod(method.MethodHandle);`
- `NationalSpire.Solver.LeagueForecast.InstallDuelHooks()`；输入表达式：`InstallDuelHooks()`；返回值紧邻使用处：`ExpressionStatementSyntax: InstallDuelHooks();`
- `System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(System.RuntimeMethodHandle)`；输入表达式：`RuntimeHelpers.PrepareMethod(method.MethodHandle)`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeHelpers.PrepareMethod(method.MethodHandle);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c0fdc3118f7"></a>

## `NationalSpire.Solver.LeagueForecast.Capture(bool) — private CombatRootSnapshot Capture(bool attacking)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)；[`NationalSpire.Solver.LeagueForecast.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int)`](LeagueForecast.Choices.cs.md#symbol-621299823e37)

**调用：** [`Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueForecast.Projection.cs.md#symbol-8bf6377c2850)；`CombatSolver.CombatRootSnapshot.Capture(MegaCrit.Sts2.Core.Combat.CombatState, bool, CombatSolver.PotionHpThresholds?, CombatSolver.CapturedHotRoot?)`；`HarmonyLib.AccessTools.Field(System.Type, string)`；`HarmonyLib.AccessTools.FieldRef<T, F>.Invoke(T)`（委托实际目标见流程文档）；`MegaCrit.Sts2.Core.Combat.CombatState.AddCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Combat.CombatState.AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Combat.CombatState.CombatState(MegaCrit.Sts2.Core.Models.EncounterModel?, MegaCrit.Sts2.Core.Runs.IRunState?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>?, MegaCrit.Sts2.Core.Models.Dread.DominionModel?)`；`MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；`MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot.ArrowSlot(MegaCrit.Sts2.Core.Entities.Players.Player)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AddCapacity(int)`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Clear()`；`MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Insert(int, MegaCrit.Sts2.Core.Models.OrbModel)`；`MegaCrit.Sts2.Core.Entities.Players.Player.AddRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Entities.Players.Player.RemoveRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, bool)`；`MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddPetInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainEnergy(decimal)`；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；`MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；`MegaCrit.Sts2.Core.Models.MonsterModel.RollMove(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；`MegaCrit.Sts2.Core.Models.MonsterModel.SetUpForCombat()`；`MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.RelicModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic)`；`MegaCrit.Sts2.Core.Models.RelicModel.ToSerializable()`；`MegaCrit.Sts2.Core.Runs.RunRngSet.LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet)`；`MegaCrit.Sts2.Core.Runs.RunRngSet.ToSerializable()`；`MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, MegaCrit.Sts2.Core.Runs.GameMode, bool, int, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Reflection.FieldInfo.GetValue(object?)`

**字段、属性、事件及方法组引用：** `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._historyPlayer`；`NationalSpire.Solver.LeagueForecast._live`；`NationalSpire.Solver.LeagueForecast._originals`；`NationalSpire.Solver.LeagueForecast.StarBalance`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CombatSolver.CombatRootSnapshot.Capture(MegaCrit.Sts2.Core.Combat.CombatState, bool, CombatSolver.PotionHpThresholds?, CombatSolver.CapturedHotRoot?)`；输入表达式：`CombatRootSnapshot.Capture(board,potionThresholds:PotionHpThresholds.Default)`；返回值紧邻使用处：`ReturnStatementSyntax: return CombatRootSnapshot.Capture(board,potionThresholds:PotionHpThresholds.Default);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(_live.Creature,actor.Creature)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(_live.Creature,actor.Creature);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(realPet,pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(realPet,pet);`
- `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Copy(realTargets[i],targets[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(realTargets[i],targets[i]);`
- `HarmonyLib.AccessTools.Field(System.Type, string)`；输入表达式：`AccessTools.Field(typeof(PlayerCombatState),"_arrows")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue`
- `HarmonyLib.AccessTools.FieldRef<T, F>.Invoke(T)`；输入表达式：`StarBalance(ps)`；返回值紧邻使用处：`AssignmentExpressionSyntax: StarBalance(ps)=old.Stars`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`board.AddCard(card,actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddCard(card,actor);`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`board.AddCreature(pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddCreature(pet);`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`board.AddCreature(target)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddCreature(target);`
- `MegaCrit.Sts2.Core.Combat.CombatState.AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`board.AddPlayer(actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: board.AddPlayer(actor);`
- `MegaCrit.Sts2.Core.Combat.CombatState.CombatState(MegaCrit.Sts2.Core.Models.EncounterModel?, MegaCrit.Sts2.Core.Runs.IRunState?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel>?, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RunModel>?, MegaCrit.Sts2.Core.Models.Dread.DominionModel?)`；输入表达式：`new CombatState(runState:run,badgeModels:run.BadgeModels,runModels:run.RunModels)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CombatState(runState:run,badgeModels:run.BadgeModels,runModels:run.RunModels)`
- `MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；输入表达式：`board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null)`
- `MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel, MegaCrit.Sts2.Core.Combat.CombatSide, string?)`；输入表达式：`board.CreateCreature(ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable(),CombatSide.Player,null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =board.CreateCreature(ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable(),CombatSide.Player,null)`
- `MegaCrit.Sts2.Core.Combat.ICombatState.GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；输入表达式：`dest.AddInternal(card,-1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: dest.AddInternal(card,-1,true);`
- `MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot.ArrowSlot(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`new ArrowSlot(actor){Status=slot.Status}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ArrowSlot(actor){Status=slot.Status}`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.AddCapacity(int)`；输入表达式：`ps.OrbQueue.AddCapacity(old.OrbQueue.Capacity-ps.OrbQueue.Capacity)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.OrbQueue.AddCapacity(old.OrbQueue.Capacity-ps.OrbQueue.Capacity);`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Clear()`；输入表达式：`ps.OrbQueue.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.OrbQueue.Clear();`
- `MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue.Insert(int, MegaCrit.Sts2.Core.Models.OrbModel)`；输入表达式：`ps.OrbQueue.Insert(ps.OrbQueue.Orbs.Count,clone)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.OrbQueue.Insert(ps.OrbQueue.Orbs.Count,clone);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.AddRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, int, bool)`；输入表达式：`actor.AddRelicInternal(RelicModel.FromSerializable(r.ToSerializable()),-1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.AddRelicInternal(RelicModel.FromSerializable(r.ToSerializable()),-1,true);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(_live.Character,_live.UnlockState,MegaCrit.Sts2.Core.Context.LocalContext.NetId ?? 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Player.CreateForNewRun(_live.Character,_live.UnlockState,MegaCrit.Sts2.Core.Context.LocalContext.NetId ?? 1)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.RemoveRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel, bool)`；输入表达式：`actor.RemoveRelicInternal(r,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.RemoveRelicInternal(r,true);`
- `MegaCrit.Sts2.Core.Entities.Players.Player.ResetCombatState()`；输入表达式：`actor.ResetCombatState()`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.ResetCombatState();`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AddPetInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`ps.AddPetInternal(pet)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.AddPetInternal(pet);`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.GainEnergy(decimal)`；输入表达式：`ps.GainEnergy(old.Energy-ps.Energy)`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.GainEnergy(old.Energy-ps.Energy);`
- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.IncrementTurnNumber()`；输入表达式：`ps.IncrementTurnNumber()`；返回值紧邻使用处：`ExpressionStatementSyntax: ps.IncrementTurnNumber();`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`orb.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (OrbModel)orb.MutableClone()`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`original.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (CardModel)original.MutableClone()`
- `MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；输入表达式：`a.CanonicalInstance.ToMutable()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a=>a.CanonicalInstance.ToMutable()`
- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable`
- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<MockAttackMonster>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>()`
- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<MockPlatingMonster>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>()`
- `MegaCrit.Sts2.Core.Models.MonsterModel.RollMove(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；输入表达式：`target.Monster.RollMove([actor.Creature])`；返回值紧邻使用处：`ExpressionStatementSyntax: target.Monster.RollMove([actor.Creature]);`
- `MegaCrit.Sts2.Core.Models.MonsterModel.SetUpForCombat()`；输入表达式：`target.Monster!.SetUpForCombat()`；返回值紧邻使用处：`ExpressionStatementSyntax: target.Monster!.SetUpForCombat();`
- `MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；输入表达式：`enemy.ToMutable()`；返回值紧邻使用处：`ArgumentSyntax: enemy.ToMutable()`
- `MegaCrit.Sts2.Core.Models.MonsterModel.ToMutable()`；输入表达式：`ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable()`；返回值紧邻使用处：`ArgumentSyntax: ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable()`
- `MegaCrit.Sts2.Core.Models.RelicModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic)`；输入表达式：`RelicModel.FromSerializable(r.ToSerializable())`；返回值紧邻使用处：`ArgumentSyntax: RelicModel.FromSerializable(r.ToSerializable())`
- `MegaCrit.Sts2.Core.Models.RelicModel.ToSerializable()`；输入表达式：`r.ToSerializable()`；返回值紧邻使用处：`ArgumentSyntax: r.ToSerializable()`
- `MegaCrit.Sts2.Core.Runs.RunRngSet.LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet)`；输入表达式：`run.Rng.LoadFromSerializable(_live.RunState.Rng.ToSerializable())`；返回值紧邻使用处：`ExpressionStatementSyntax: run.Rng.LoadFromSerializable(_live.RunState.Rng.ToSerializable());`
- `MegaCrit.Sts2.Core.Runs.RunRngSet.ToSerializable()`；输入表达式：`_live.RunState.Rng.ToSerializable()`；返回值紧邻使用处：`ArgumentSyntax: _live.RunState.Rng.ToSerializable()`
- `MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, MegaCrit.Sts2.Core.Runs.GameMode, bool, int, string)`；输入表达式：`RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,_live.RunState.Rng.StringSeed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,_live.RunState.Rng.StringSeed)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_originals.Add(card,original)`；返回值紧邻使用处：`ExpressionStatementSyntax: _originals.Add(card,original);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`arrows.Add(slot,next)`；返回值紧邻使用处：`ExpressionStatementSyntax: arrows.Add(slot,next);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<ArrowSlot,ArrowSlot>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<ArrowSlot,ArrowSlot>()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`ps.AllPiles.First(p=>p.Type==pile.Type)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ps.AllPiles.First(p=>p.Type==pile.Type)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`actor.Relics.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var r in actor.Relics.ToArray())actor.RemoveRelicInternal(r,true);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =realTargets.Select(other=>{              MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);              board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;          }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList()`；返回值紧邻使用处：`ArgumentSyntax: _live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`slots.Add(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.Add(next);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`slots.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: slots.Clear();`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)!`

**赋值（含属性/字段和局部值）：**

- `_actor` = `actor`
- `_aims[target]` = `checked((int)other.CombatId!.Value)`
- `_historyPlayer` = `_live`
- `_historyPlayer` = `null`
- `board.RoundNumber` = `_live.Creature.CombatState!.RoundNumber`
- `card.Owner` = `null!`
- `clone.Owner` = `actor`
- `clone.Owner` = `null!`
- `StarBalance(ps)` = `old.Stars`
- `Status` = `slot.Status`

<a id="symbol-8bf6377c2850"></a>

## `Copy(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — void Copy(Creature src,Creature dst)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Capture(bool)`](LeagueForecast.Projection.cs.md#symbol-1c0fdc3118f7)

**调用：** `MegaCrit.Sts2.Core.Entities.Creatures.Creature.GainBlockInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；`MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；`MegaCrit.Sts2.Core.Models.PowerModel.ApplyInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, bool)`；`MegaCrit.Sts2.Core.Models.Powers.ImpaledPower.AddArrow(MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot)`；`object.GetType()`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._live`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.GainBlockInternal(decimal)`；输入表达式：`dst.GainBlockInternal(src.Block)`；返回值紧邻使用处：`ExpressionStatementSyntax: dst.GainBlockInternal(src.Block);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；输入表达式：`dst.SetCurrentHpInternal(src.CurrentHp)`；返回值紧邻使用处：`ExpressionStatementSyntax: dst.SetCurrentHpInternal(src.CurrentHp);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；输入表达式：`dst.SetMaxHpInternal(src.MaxHp)`；返回值紧邻使用处：`ExpressionStatementSyntax: dst.SetMaxHpInternal(src.MaxHp);`
- `MegaCrit.Sts2.Core.Models.AbstractModel.MutableClone()`；输入表达式：`power.MutableClone()`；返回值紧邻使用处：`CastExpressionSyntax: (PowerModel)power.MutableClone()`
- `MegaCrit.Sts2.Core.Models.PowerModel.ApplyInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, bool)`；输入表达式：`copy.ApplyInternal(dst,power.Amount,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.ApplyInternal(dst,power.Amount,true);`
- `MegaCrit.Sts2.Core.Models.Powers.ImpaledPower.AddArrow(MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot)`；输入表达式：`impaled.AddArrow(arrow)`；返回值紧邻使用处：`ExpressionStatementSyntax: impaled.AddArrow(arrow);`
- `object.GetType()`；输入表达式：`power.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: power.GetType().Assembly`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(realTargets,power.Applier)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Array.IndexOf(realTargets,power.Applier) is int i`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`arrows.TryGetValue(a,out var arrow)`；返回值紧邻使用处：`IfStatementSyntax: if(arrows.TryGetValue(a,out var arrow))impaled.AddArrow(arrow);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`foreign.Arrows.Any(arrows.ContainsKey)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !foreign.Arrows.Any(arrows.ContainsKey)`

**赋值（含属性/字段和局部值）：**

- `copy.Applier` = `power.Applier==_live.Creature?actor.Creature:Array.IndexOf(realTargets,power.Applier) is int i&&i>=0?targets[i]:null`

<a id="symbol-22dc42205291"></a>

## `NationalSpire.Solver.LeagueForecast.OriginalCards(in CombatSolver.HotKernel.CombatHotState) — private Dictionary<ushort,CardModel> OriginalCards(in CombatHotState state)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)；[`NationalSpire.Solver.LeagueForecast.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int)`](LeagueForecast.Choices.cs.md#symbol-621299823e37)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._originals`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`result.Add(state.Cards[index++].CardUid,_originals[card])`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(state.Cards[index++].CardUid,_originals[card]);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<ushort,CardModel>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<ushort,CardModel>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6cb7d1f580d7"></a>

## `NationalSpire.Solver.LeagueForecast.Dispose() — public void Dispose()`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Solver.LeagueForecast._actor`；`NationalSpire.Solver.LeagueForecast._aims`；`NationalSpire.Solver.LeagueForecast._originals`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；输入表达式：`.AfterCombatEnd()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .PlayerCombatState?.AfterCombatEnd()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_aims.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _aims.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_originals.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _originals.Clear();`

**赋值（含属性/字段和局部值）：**

- `_actor` = `null`
