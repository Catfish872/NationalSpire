using HarmonyLib;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.ValueProps;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq.Expressions;

namespace NationalSpire;

// 两代游戏共用同一份逐击记录。差别在于旧版只传目标，新版还传入命中特效。
internal static class LeagueBattleApi
{
    private static readonly MethodInfo NewRun=typeof(RunState).GetMethods().Single(m=>m.Name=="CreateForNewRun");
    private static readonly MethodInfo MakeAnimator=typeof(CharacterModel).GetMethods().Single(m=>m.Name=="GenerateAnimator");
    private static readonly MethodInfo? CharacterVisuals=typeof(CharacterModel).GetProperty("VisualsPath",BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public)?.GetGetMethod(true);
    // 只缓存接口，不缓存路径；皮肤模组可以在两场之间切换职业外观。
    internal static string VisualsPath(CharacterModel role)=>CharacterVisuals?.Invoke(role,null) as string
        ??"res://scenes/creature_visuals/"+role.Id.Entry.ToLowerInvariant()+".tscn";
    private static MethodInfo? _damage;
    private static bool _detailed;
    private static Func<LeagueDuel.Hit,Task>? _deliverWithEffects;
    [ThreadStatic] private static bool _delivery;
    private static bool Delivering(){var value=_delivery;_delivery=false;return value;}
    private static LeagueDuel.Hit? _settling;
    private sealed class IncomingIntent(LeagueDuel.Hit hit) : BlockingPlayerChoiceContext
    {
        private bool _checkedDealer;
        internal bool StopForDeadDealer(Creature dealer){
            if(_checkedDealer||dealer!=hit.Dealer)return dealer.IsDead;
            _checkedDealer=true;
            return dealer.IsDead && dealer.Monster is not MegaCrit.Sts2.Core.Models.Monsters.Osty;
        }
        internal bool Matches(Creature target,Creature? dealer) => target==hit.Target && dealer==hit.Dealer;
    }
    // 仅替换伤害入口对攻击者的检查。目标死亡、反伤和后续卡效仍由游戏各自判断。
    private static IEnumerable<CodeInstruction> CommittedAttack(IEnumerable<CodeInstruction> instructions,MethodBase __originalMethod){
        var state=__originalMethod.DeclaringType!;
        var dealer=AccessTools.Field(state,"dealer");var context=AccessTools.Field(state,"choiceContext");
        var dead=AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.IsDead));
        bool readDealer=false;
        foreach(var i in instructions){
            if(readDealer&&i.Calls(dead)){
                yield return new CodeInstruction(OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);
                yield return new CodeInstruction(OpCodes.Ldfld,context);
                yield return CodeInstruction.Call(typeof(LeagueBattleApi),nameof(StopForDeadDealer));
            }else yield return i;
            readDealer=i.opcode==OpCodes.Ldfld&&Equals(i.operand,dealer);
        }
    }
    private static bool StopForDeadDealer(Creature dealer,PlayerChoiceContext context)=>
        context is IncomingIntent hit?hit.StopForDeadDealer(dealer):dealer.IsDead;
    private static bool OwnTurnLoss(PlayerChoiceContext choiceContext,Creature target,Creature? dealer,CardModel? cardSource,ref Task __result){
        if(choiceContext is not IncomingIntent hit||cardSource!=null||!hit.Matches(target,dealer))return true;
        __result=Task.CompletedTask;return false;
    }
    private static readonly MethodInfo LoseBlockCommand=typeof(CreatureCmd).GetMethods().Single(m=>m.Name=="LoseBlock");
    internal static Task SpendGuard(PlayerChoiceContext context,Creature target,int amount,Creature source)=>
        (Task)RuntimeApi.Invoke(LoseBlockCommand,null,LoseBlockCommand.GetParameters().Length==2?[target,(decimal)amount]:[context,target,(decimal)amount,source])!;
    public static RunState Create(Player[] players,List<ActModel> acts,string seed){
        ModifierModel[] mods=[];
        return (RunState)RuntimeApi.Invoke(NewRun,null,NewRun.GetParameters().Length==7?[players,acts,mods,GameMode.Standard,false,0,seed]:[players,acts,mods,GameMode.Standard,0,seed])!;
    }
    public static CreatureAnimator Animator(CharacterModel role,MegaSprite sprite,Creature creature)
        =>(CreatureAnimator)RuntimeApi.Invoke(MakeAnimator,role,MakeAnimator.GetParameters().Length==2?[sprite,creature]:[sprite])!;
    public static void Install(Harmony h){
        var methods=typeof(CreatureCmd).GetMethods().Where(m=>m.Name=="Damage"&&m.GetParameters() is [_,var targets,var amount,..]&&amount.ParameterType==typeof(decimal)&&targets.ParameterType.IsGenericType&&targets.ParameterType.GetGenericTypeDefinition()==typeof(IEnumerable<>)).ToArray();
        // 旧版的最终伤害入口包含出牌资料，新版的最终入口另外包含计算方式。
        _damage=methods.SingleOrDefault(m=>m.GetParameters()[1].ParameterType.GenericTypeArguments[0].Name=="DamageTargetData")??methods.Single(m=>m.GetParameters().Length==7);
        _detailed=_damage.GetParameters()[1].ParameterType.GenericTypeArguments[0]!=typeof(Creature);
        var type=_detailed?typeof(Detailed<>).MakeGenericType(_damage.GetParameters()[1].ParameterType.GenericTypeArguments[0]):typeof(LeagueBattleApi);
        if(_detailed)_deliverWithEffects=AccessTools.DeclaredMethod(type,"Deliver").CreateDelegate<Func<LeagueDuel.Hit,Task>>();
        h.Patch(_damage,prefix:new HarmonyMethod(type,"Record"));
        h.Patch(AccessTools.AsyncMoveNext(_damage),transpiler:new HarmonyMethod(typeof(LeagueBattleApi),nameof(CommittedAttack)));
        foreach(var effect in LeagueOwnTurnLoss.Effects)
            h.Patch(AccessTools.DeclaredMethod(effect,nameof(AbstractModel.AfterDamageReceived)),prefix:new HarmonyMethod(typeof(LeagueBattleApi),nameof(OwnTurnLoss)));
        if(!_detailed)h.Patch(AccessTools.Method(typeof(Hook),nameof(Hook.ModifyDamage)),prefix:new HarmonyMethod(typeof(LeagueBattleApi),nameof(FixedAmount)));
    }
    private static bool Record(IEnumerable<Creature>? targets,decimal amount,ValueProp props,Creature? dealer,CardModel? cardSource,CardPlay? cardPlay,ref Task<IEnumerable<DamageResult>> __result)
        =>LeagueNativeMatch.Current==null||Delivering()||targets==null||LeagueNativeMatch.QueueHits(targets.Select(c=>(c,(string?)null,false)),amount,props,dealer,cardSource,cardPlay,ModifyDamageHookType.All,ref __result);
    private static bool FixedAmount(Creature? dealer,CardPlay? cardPlay,CardModel? cardSource,ref ModifyDamageHookType modifyDamageHookType){
        if(_settling is {} hit&&dealer==hit.Dealer&&cardPlay==null&&cardSource==null){modifyDamageHookType=hit.Cap;_settling=null;}
        return true;
    }
    public static async Task Deliver(LeagueDuel.Hit hit){
        // 前缀在原生异步方法返回任务之前消耗标记。结算引发的反伤仍是独立的一击。
        _delivery=true;
        if(_detailed){Task work;try{work=_deliverWithEffects!(hit);}finally{_delivery=false;}await work;return;}
        _settling=hit;
        try{await (Task)RuntimeApi.Invoke(_damage!,null,new IncomingIntent(hit),new[]{hit.Target},hit.BeforeCap,hit.Props,hit.Dealer,null,null)!;}
        finally{_settling=null;_delivery=false;}
    }
    private static class Detailed<T> where T:struct{
        private delegate Task<IEnumerable<DamageResult>> Send(PlayerChoiceContext context,IEnumerable<T> targets,decimal amount,ValueProp props,Creature dealer,CardModel? source,CardPlay? play,ModifyDamageHookType mode);
        private static readonly Send Damage=_damage!.CreateDelegate<Send>();
        private static readonly Func<T,(Creature,string?,bool)> Unpack;
        private static readonly Func<Creature,string?,bool,T> Pack;
        static Detailed(){
            var p=Expression.Parameter(typeof(T));var tuple=typeof(ValueTuple<Creature,string,bool>).GetConstructors().Single();
            Unpack=Expression.Lambda<Func<T,(Creature,string?,bool)>>(Expression.New(tuple,Expression.Field(p,"target"),Expression.Field(p,"hitVfx"),Expression.Field(p,"playVfxOnCreatureCenter")),p).Compile();
            var who=Expression.Parameter(typeof(Creature));var fx=Expression.Parameter(typeof(string));var center=Expression.Parameter(typeof(bool));
            var value=Expression.MemberInit(Expression.New(typeof(T).GetConstructor([typeof(Creature)])!,who),Expression.Bind(typeof(T).GetField("hitVfx")!,fx),Expression.Bind(typeof(T).GetField("playVfxOnCreatureCenter")!,center));
            Pack=Expression.Lambda<Func<Creature,string?,bool,T>>(value,who,fx,center).Compile();
        }
        private static bool Record(IEnumerable<T>? targetData,decimal amount,ValueProp props,Creature? dealer,CardModel? cardSource,CardPlay? cardPlay,ModifyDamageHookType modifyDamageHookType,ref Task<IEnumerable<DamageResult>> __result)
            =>LeagueNativeMatch.Current==null||Delivering()||targetData==null||LeagueNativeMatch.QueueHits(targetData.Select(Unpack),amount,props,dealer,cardSource,cardPlay,modifyDamageHookType,ref __result);
        internal static Task Deliver(LeagueDuel.Hit hit)=>Damage(new IncomingIntent(hit),[Pack(hit.Target,hit.Vfx,hit.Center)],hit.BeforeCap,hit.Props,hit.Dealer,null,null,hit.Cap);
    }
}
