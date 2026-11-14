using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using System.Reflection;
using System.Reflection.Emit;

namespace NationalSpire;

public static partial class LeagueNativeMatch {
    // 普通冒险里的敌方名单以玩家为中心。镜面对决只在实战中的敌方持有者读取这份名单时调整阵营。
    // 从原方法中取得实际卡牌、能力或球的实例，因此同一个回合内双方各自触发的效果不会串用阵营。
    private static readonly HashSet<MethodBase> EffectPatches=[];
    private static readonly HashSet<Type> SeenPowers=[];
    private static Harmony _leagueHarmony=null!;
    private static void InstallEffectTargets(Harmony h){
        _leagueHarmony=h;
        h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(AutoPlayTeams)));
        h.Patch(AccessTools.DeclaredMethod(typeof(CardCmd),"AutoPlay"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PrepareAutoPlay)));
        var listeners=AccessTools.EnumeratorMoveNext(AccessTools.DeclaredMethod(typeof(CombatState),"IterateHookListeners"));
        h.Patch(listeners,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FighterListeners)));
        h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(typeof(OstyCmd),"Summon")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(FindExistingOsty)));
        h.Patch(AccessTools.DeclaredMethod(typeof(PowerModel),"ApplyInternal"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PreparePowerOwner)));
        var thorns=typeof(MegaCrit.Sts2.Core.Models.Powers.ThornsPower);
        h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(thorns,"BeforeDamageReceived")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ThornDamage)));
        var asm=typeof(CardModel).Assembly;
        h.Patch(AccessTools.Method(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"ModifyPowerAmountReceived"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DuelDoom)));
        h.Patch(AccessTools.GetDeclaredMethods(typeof(PowerCmd)).Single(m=>m.Name=="Apply"&&!m.IsGenericMethod),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingPower)));
        h.Patch(AccessTools.Method(typeof(PowerCmd),"ModifyAmount"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PendingStack)));
        void Register(string group,string names){
            foreach(string n in names.Split(' ')){
                var t=asm.GetType("MegaCrit.Sts2.Core.Models."+group+"."+n);if(t==null)continue;
                foreach(var owner in Nested(t))foreach(var m in AccessTools.GetDeclaredMethods(owner)){
                    if(m.IsStatic||m.IsAbstract||m.GetMethodBody()==null||(!m.Name.Contains("OnPlay")&&owner==t&&m.Name.StartsWith("get_")))continue;
                    if(!FindOwner(owner,t,out _)||!PatchProcessor.ReadMethodBody(m).Any(op=>op.Value is MethodInfo mi&&(mi.DeclaringType==typeof(ICombatState)&&(mi.Name=="get_HittableEnemies"||t.Name=="FrostOrb"&&mi.Name=="get_Players")||mi.DeclaringType==typeof(CreatureCmd)&&mi.Name=="Damage"&&(typeof(OrbModel).IsAssignableFrom(t)||t.Name=="PoisonPower"))))continue;
                    if(EffectPatches.Add(m))h.Patch(m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ResolveEffectSides)));
                }
            }
        }
        Register("Cards","BeatDown BouncingFlask Chill Conflagration CrushUnder DaggerSpray Deathbringer DyingStar EchoingSlash EndOfDays Haze MementoMori Misery NegativePulse Outbreak PiercingWail Resonance Shiv Shockwave SovereignBlade Stomp SweepingBeam Thunderclap");
        Register("Powers","BlackHolePower CacophonyPower CorrosiveWavePower CountdownPower ExplosiveArrowsPower GodByrdPower GravityPower HailstormPower HauntPower HellraiserPower InfernoPower JuggernautPower NecroMasteryPower NoxiousFumesPower PanachePower RollingBoulderPower SerpentFormPower SmokestackPower SpeedsterPower TheBombPower ViolentChordPower");
        Register("Relics","CharonsAshes FestivePopper ForgottenSoul Kusarigama LetterOpener LostWisp Metronome MercuryHourglass MrStruggles ParryingShield ScreamingFlagon StoneCalendar Tingsha");
        Register("Powers","PoisonPower");
        Register("Orbs","LightningOrb DarkOrb GlassOrb FrostOrb");
    }
    // 原版在每次事件开始前收集场上的卡牌、球、药水及其效果。敌方选手既有怪物行动，也有自己的手牌，两者各登记一次。
    private static IEnumerable<CodeInstruction> FighterListeners(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod){
        int list=__originalMethod.GetMethodBody()!.LocalVariables.Single(v=>v.LocalType==typeof(List<AbstractModel>)).LocalIndex;
        foreach(var i in instructions){
            if(i.Calls(AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player)))){
                yield return CodeInstruction.LoadLocal(list).MoveLabelsFrom(i).MoveBlocksFrom(i);
                yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(FighterForHooks)));
            }else yield return i;
        }
    }
    private static Player? FighterForHooks(Creature c,List<AbstractModel> models){
        if(For(c)?.Rival is {} r){models.Add(c.Monster!);return r;}
        return c.Player;
    }
    // 奥斯迪倒下后仍留在场上。再次召唤时原版从召唤者一方寻找原来的随从，随后沿用原版复活动作。
    private static IEnumerable<CodeInstruction> FindExistingOsty(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod){
        var owner=AccessTools.Field(__originalMethod.DeclaringType,"summoner");
        foreach(var i in instructions){
            if(i.Calls(AccessTools.PropertyGetter(typeof(ICombatState),"Allies"))){
                yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);
                yield return new CodeInstruction(OpCodes.Ldfld,owner);
                yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),nameof(SummonerTeam)));
            }else yield return i;
        }
    }
    private static IReadOnlyList<Creature> SummonerTeam(ICombatState state,Player p)=>For(p)!=null?state.GetTeammatesOf(p.Creature):state.Allies;
    // 对手实际首次获得某个能力时才检查该类型。只替换“能力持有者的玩家资料”，不改变判断召唤物、怪物或受击者的逻辑。
    private static void PreparePowerOwner(PowerModel __instance,Creature owner){
        if(For(owner)==null||__instance.GetType().Assembly!=typeof(PowerModel).Assembly||!SeenPowers.Add(__instance.GetType()))return;
        foreach(var type in Nested(__instance.GetType()))foreach(var method in AccessTools.GetDeclaredMethods(type)){
            if(method.IsAbstract||method.GetMethodBody()==null)continue;object? prev=null;
            if(method.Name=="AfterRemoved"&&method.GetParameters() is [{ParameterType:var old}]&&old==typeof(Creature)&&PatchProcessor.ReadMethodBody(method).Any(op=>op.Value is MethodInfo {Name:"get_Player",DeclaringType:var c}&&c==old)){
                _leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));continue;
            }
            foreach(var op in PatchProcessor.ReadMethodBody(method)){
                if(IsOwnerPair(prev,op.Value)){_leagueHarmony.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PowerOwnerPair)));break;}
                prev=op.Value;
            }
        }
    }
    private static bool IsOwnerPair(object? first,object? second)=>first is MethodInfo {Name:"get_Owner",DeclaringType:var t}&&t==typeof(PowerModel)&&second is MethodInfo {Name:"get_Player",DeclaringType:var c}&&c==typeof(Creature);
    private static IEnumerable<CodeInstruction> PowerOwnerPair(IEnumerable<CodeInstruction> instructions){
        object? prev=null;
        foreach(var i in instructions){var original=i.operand;if(IsOwnerPair(prev,original)){i.opcode=OpCodes.Call;i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer));}prev=original;yield return i;}
    }
    private static IEnumerable<Type> Nested(Type t){yield return t;foreach(var child in t.GetNestedTypes(BindingFlags.Public|BindingFlags.NonPublic))foreach(var item in Nested(child))yield return item;}
    // 只改自动出牌缺少目标时使用的候选名单；手动指定的目标与卡牌自身生命代价保持原样。
    private static IEnumerable<CodeInstruction> AutoPlayTeams(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod){
        var card=AccessTools.GetDeclaredFields(__originalMethod.DeclaringType).Single(f=>f.FieldType==typeof(CardModel)&&f.Name=="card");
        foreach(var i in instructions){
            if(i.operand is MethodInfo m&&typeof(ICombatState).IsAssignableFrom(m.DeclaringType)&&m.Name is "get_HittableEnemies" or "get_Allies"){
                yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);
                yield return new CodeInstruction(OpCodes.Ldfld,card);
                yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Allies"?nameof(AutoAllies):nameof(EffectEnemies)));
            }else yield return i;
        }
    }
    private static void PrepareAutoPlay(CardModel card,ref Creature? target,ref bool skipCardPileVisuals){
        if(For(card.Owner)==null)return;
        // 敌方卡牌已有独立的出牌展示，不占用本地玩家的手牌动画节点。
        skipCardPileVisuals=true;
        if(target==null&&card.TargetType==MegaCrit.Sts2.Core.Entities.Cards.TargetType.AnyAlly)
            target=card.Owner.RunState.Rng.CombatTargets.NextItem(Fighters.Select(f=>f.Rival.Creature).Where(c=>c.IsAlive&&c!=card.Owner.Creature));
    }
    private static IReadOnlyList<Creature> AutoAllies(ICombatState state,CardModel card)=>For(card.Owner) is {} d?state.GetTeammatesOf(d.Rival.Creature):state.Allies;
    private static bool FindOwner(Type from,Type model,out List<FieldInfo> path){
        path=[];if(from==model)return true;
        foreach(var f in AccessTools.GetDeclaredFields(from).Where(f=>!f.IsStatic&&(f.FieldType==model||f.FieldType==from.DeclaringType)&&f.FieldType!=from)){
            if(!FindOwner(f.FieldType,model,out var tail))continue;path=[f,..tail];return true;
        }
        return false;
    }
    private static IEnumerable<CodeInstruction> ResolveEffectSides(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod){
        var t=__originalMethod.DeclaringType!;var model=t;while(model.DeclaringType!=null)model=model.DeclaringType;
        FindOwner(t,model,out var path);
        foreach(var i in instructions){
            if(i.operand is MethodInfo dmg&&dmg.DeclaringType==typeof(CreatureCmd)&&dmg.Name=="Damage"&&dmg.GetParameters() is [_,var targets,var amount,..] pars&&amount.ParameterType==typeof(decimal)){
                if(model.Name=="PoisonPower"&&pars.Length==6)i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(PoisonHit));
                else if(pars.Length==5&&(typeof(OrbModel).IsAssignableFrom(model)||model.Name is "ExplosiveArrowsPower" or "ViolentChordPower" or "HailstormPower"))
                    i.operand=AccessTools.Method(typeof(LeagueNativeMatch),targets.ParameterType==typeof(Creature)?nameof(OrbHit):nameof(EffectHit));
                yield return i;continue;
            }
            if(i.operand is MethodInfo m&&m.DeclaringType==typeof(ICombatState)&&(m.Name=="get_HittableEnemies"||m.Name=="get_Players"&&model.Name=="FrostOrb")){
                yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);
                foreach(var field in path)yield return new CodeInstruction(OpCodes.Ldfld,field);
                yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(LeagueNativeMatch),m.Name=="get_Players"?nameof(TeamPlayers):nameof(EffectEnemies)));
            }else yield return i;
        }
    }
    private static bool QueueDoom(PowerModel power,Creature target,decimal amount,Creature? applier,CardModel? source){
        if(power is not MegaCrit.Sts2.Core.Models.Powers.DoomPower||amount<=0||applier==null||applier.Side==target.Side||Current is not {} duel||target.CombatState!=duel.Rival.Creature.CombatState||!target.CanReceivePowers)return false;
        duel.Pending.Add(new(applier,target,amount,(MegaCrit.Sts2.Core.ValueProps.ValueProp)(-1),null,false){ DoomSource=source,Doom=true });
        if(duel.Rival.Creature.Monster is LeagueOpponent active)Refresh(active);return true;
    }
    [ThreadStatic] private static bool _passApplication;
    private static bool PendingPower(PowerModel power,Creature target,decimal amount,Creature? applier,CardModel? cardSource,ref Task __result){
        if(_passApplication||!QueueDoom(power,target,amount,applier,cardSource))return true;__result=Task.CompletedTask;return false;
    }
    private static bool PendingStack(PowerModel power,decimal offset,Creature? applier,CardModel? cardSource,ref Task<int> __result){
        if(_passApplication||!QueueDoom(power,power.Owner,offset,applier,cardSource))return true;__result=Task.FromResult(power.Amount);return false;
    }
    private static void DuelDoom(ICombatState combatState,PowerModel canonicalPower,Creature target,Creature? giver,ref decimal __result){
        if(giver?.Side==target.Side&&__result>0&&canonicalPower is MegaCrit.Sts2.Core.Models.Powers.DoomPower&&Current?.Rival.Creature.CombatState==combatState)__result=AddedDoom((int)__result);
    }
    // 每次只折算原版即将增加的层数；最接近的整数，正好半层时向上。
    internal static int AddedDoom(int layers)=>(int)decimal.Round(layers/4m,0,MidpointRounding.AwayFromZero);
    private static Task<IEnumerable<DamageResult>> PoisonHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,CardModel? source,MegaCrit.Sts2.Core.Entities.Cards.CardPlay? play){
        if(Current is {} duel&&target.CombatState==_room?.CombatState){
            var sourceActor=target.GetPower<MegaCrit.Sts2.Core.Models.Powers.PoisonPower>()?.Applier;
            var dealer=sourceActor!=null&&sourceActor.Side!=target.Side?sourceActor:target.CombatState!.GetOpponentsOf(target).First(c=>c.IsAlive);
            Task<IEnumerable<DamageResult>> result=null!;
            if(!QueueHits([(target,null,false)],amount,props&~MegaCrit.Sts2.Core.ValueProps.ValueProp.Unblockable,dealer,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result))return result;
        }
        return CreatureCmd.Damage(ctx,target,amount,props,source,play);
    }
    private static Task<IEnumerable<DamageResult>> OrbHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,Creature dealer){
        if(Current!=null)return EffectHit(ctx,[target],amount,props,dealer);
        return CreatureCmd.Damage(ctx,target,amount,props,dealer);
    }
    private static Task<IEnumerable<DamageResult>> EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,IEnumerable<Creature> targets,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,Creature dealer){
        Task<IEnumerable<DamageResult>> result=null!;
        if(Current!=null&&!QueueHits(targets.Select(t=>(t,(string?)null,false)),amount,props,dealer,null,null,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result))return result;
        return CreatureCmd.Damage(ctx,targets,amount,props,dealer);
    }
    private static IEnumerable<CodeInstruction> ThornDamage(IEnumerable<CodeInstruction> code){
        foreach(var i in code){
            if(i.operand is MethodInfo m&&m.DeclaringType==typeof(CreatureCmd)&&m.Name=="Damage"&&m.GetParameters() is [_,var target,var amount,_,_,_,_]&&target.ParameterType==typeof(Creature)&&amount.ParameterType==typeof(decimal))
                i.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(ThornHit));
            yield return i;
        }
    }
    private static Task<IEnumerable<DamageResult>> ThornHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext ctx,Creature target,decimal amount,MegaCrit.Sts2.Core.ValueProps.ValueProp props,Creature dealer,CardModel? source,MegaCrit.Sts2.Core.Entities.Cards.CardPlay? play){
        Task<IEnumerable<DamageResult>> result=null!;
        if(Current!=null&&!QueueHits([(target,null,false)],amount,props,dealer,source,play,MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType.All,ref result))return result;
        return CreatureCmd.Damage(ctx,target,amount,props,dealer,source,play);
    }
    private static IReadOnlyList<Creature> EffectEnemies(ICombatState state,AbstractModel effect){
        var rival=(effect switch{PowerModel power=>For(power.Owner),CardModel card=>For(card.Owner),OrbModel orb=>For(orb.Owner),RelicModel relic=>For(relic.Owner),_=>null})?.Rival;if(rival==null||rival.Creature.CombatState!=state)return state.HittableEnemies;
        bool enemy=effect switch{PowerModel p=>p.Owner==rival.Creature,CardModel c=>c.Owner==rival,OrbModel o=>o.Owner==rival,RelicModel r=>r.Owner==rival,_=>false};
        return enemy?state.GetOpponentsOf(rival.Creature).Where(c=>c.IsHittable).ToArray():state.HittableEnemies;
    }
    private static IReadOnlyList<Player> TeamPlayers(ICombatState state,OrbModel orb)=>For(orb.Owner)!=null?Fighters.Select(f=>f.Rival).Where(p=>p.Creature.IsAlive).ToArray():state.Players;
}
