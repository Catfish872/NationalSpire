using CombatSolver.HotKernel;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;

namespace NationalSpire.Solver;

public sealed partial class LeagueForecast
{
    private readonly record struct PlannedHit(byte Dealer, byte Target, decimal Amount, bool Doom, bool Unblockable = false);
    private sealed class IntentLedger(Func<int, int> scaleDoom)
    {
        internal readonly List<PlannedHit> Moves = [];
        internal readonly Func<int, int> ScaleDoom = scaleDoom;
        internal IntentLedger Fork()
        {
            var child = new IntentLedger(ScaleDoom);
            child.Moves.AddRange(Moves);
            return child;
        }
    }

    [ThreadStatic] private static IntentLedger? _outgoing;
    [ThreadStatic] private static Player? _historyPlayer;
    [ThreadStatic] private static bool _poison;

    private static void InstallDuelHooks()
    {
        var h = new Harmony("nationalspire.league.forecast");
        void Patch(Type type, string method, string prefix) =>
            h.Patch(AccessTools.DeclaredMethod(type, method),
                prefix: new HarmonyMethod(typeof(LeagueForecast), prefix));
        Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.DispatchCorePowerHook), nameof(ApplyDuelPower));
        Patch(typeof(HotRelics), nameof(HotRelics.HandleAfterDamageReceived), nameof(OwnTurnRelic));
        Patch(typeof(HotRootBuilder), nameof(HotRootBuilder.CaptureLiveHistoryAndMelodies), nameof(ReadOpponentHistory));
        Patch(typeof(HotKeywords), nameof(HotKeywords.FromEnumerable), nameof(ProjectKeywords));
        Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.DealDamageInternal), nameof(DeclareAttack));
        Patch(typeof(HotCombatEngine), nameof(HotCombatEngine.ApplyPowerCore), nameof(DeclareDoom));
        h.Patch(AccessTools.DeclaredMethod(typeof(HotCombatEngine),nameof(HotCombatEngine.TriggerPoison)),
            prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(StartPoison)),
            finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(FinishPoison)));
    }

    // 游戏允许模组扩展关键词。推演只能计算游戏本体声明的关键词；实际卡牌由游戏执行。
    private static readonly HashSet<CardKeyword> GameKeywords = typeof(CardKeyword).GetFields()
        .Where(field => field.IsLiteral).Select(field => (CardKeyword)field.GetValue(null)!).ToHashSet();
    private static void ProjectKeywords(ref IEnumerable<CardKeyword>? __0)
    {
        if (__0 != null) __0 = __0.Where(GameKeywords.Contains);
    }

    // 临时角色持有复制的卡牌。求解器查阅实战记录时，应使用记录中实际出牌的角色。
    private static void ReadOpponentHistory(ref CombatState __0, ref Player __1)
    {
        if (_historyPlayer is not {} opponent) return;
        __0 = (CombatState)opponent.Creature.CombatState!;
        __1 = opponent;
    }

    private static HotStepResult TryStep(ref CombatHotState state, ref HotColdSidecar? cold, HotRules rules,
        HotExecScratch scratch, HotAction action, ReadOnlySpan<HotChoiceSelection> choices,
        IntentLedger parent, out IntentLedger child)
    {
        var previous = _outgoing;
        _outgoing = child = parent.Fork();
        try { return HotCombatEngine.Step(ref state, ref cold, rules, scratch, action, choices); }
        finally { _outgoing = previous; }
    }

    [ThreadStatic] private static byte? _delivery;
    [ThreadStatic] private static bool _capped;
    private static readonly HashSet<HotPowerId> OwnPowers = OwnTurnEffects<HotPowerId>();
    private static readonly HashSet<HotRelicId> OwnRelics = OwnTurnEffects<HotRelicId>();
    private static HashSet<T> OwnTurnEffects<T>() where T: struct,Enum =>
        Enum.GetValues<T>().Where(id=>LeagueOwnTurnLoss.Effects.Any(effect=>effect.Name==id.ToString())).ToHashSet();
    private static void StartPoison(out bool __state){__state=_poison;_poison=true;}
    private static void FinishPoison(bool __state)=>_poison=__state;
    private static bool ApplyDuelPower([HarmonyArgument(4)]HotHookMask hook,[HarmonyArgument(6)]HotPowerId powerId,[HarmonyArgument(7)]ref HotHookArgs args)
    {
        if(hook==HotHookMask.ModifyDamageMultiplicative && _outgoing!=null && powerId==HotPowerId.ColossusPower)return false;
        if(_delivery!=args.ActorSlot || args.TargetSlot!=0)return true;
        return hook switch{
            HotHookMask.ModifyDamageCap=>_capped,
            HotHookMask.AfterDamageReceived=>!OwnPowers.Contains(powerId),
            _=>true
        };
    }
    private static bool OwnTurnRelic([HarmonyArgument(4)]HotRelicId relicId,[HarmonyArgument(7)]ref HotHookArgs args)=>_delivery!=args.ActorSlot || args.TargetSlot!=0 || !OwnRelics.Contains(relicId);
    private static void Deliver(ref CombatHotState state,ref HotColdSidecar? cold,HotRules rules,HotExecScratch scratch,
        byte dealer,decimal amount,bool powered,bool unblockable,bool capped)
    {
        _delivery=dealer;_capped=capped;
        try{HotCombatEngine.DealDamageInternal(ref state,ref cold,rules,scratch,dealer,0,(int)amount,powered,unblockable,-1,0,capOnlyModifiers:true);}
        finally{_delivery=null;_capped=false;}
    }

    private static bool DeclareAttack([HarmonyArgument(0)]ref CombatHotState s, [HarmonyArgument(1)]ref HotColdSidecar? cold,
        [HarmonyArgument(2)]HotRules rules, [HarmonyArgument(3)]HotExecScratch scratch, [HarmonyArgument(4)]byte dealerSlot,
        [HarmonyArgument(5)]byte targetSlot, [HarmonyArgument(6)]int baseDamage, [HarmonyArgument(7)]bool isPoweredAttack, [HarmonyArgument(8)]bool isUnblockable,
        [HarmonyArgument(9)]int cardIdx, [HarmonyArgument(10)]ushort cardDefId, [HarmonyArgument(12)]bool capOnlyModifiers, ref int __result)
    {
        if (_outgoing is not {} ledger)return true;
        if(_poison && dealerSlot==byte.MaxValue && targetSlot>=3)dealerSlot=0;
        if (dealerSlot == byte.MaxValue || (dealerSlot < 3) == (targetSlot < 3))
            return true;
        if (!HotCombatEngine.IsCreatureSlotValid(in s, dealerSlot) || !HotCombatEngine.IsCreatureSlotValid(in s, targetSlot)
            || HotCombatEngine.GetCreatureRef(ref s, dealerSlot).CurrentHp <= 0 || HotCombatEngine.GetCreatureRef(ref s, targetSlot).CurrentHp <= 0)
            return true;
        decimal amount = HotCombatEngine.ComputeModifiedDamage(ref s, ref cold, rules, scratch,
            dealerSlot, targetSlot, baseDamage, isPoweredAttack, cardIdx, cardDefId, capOnlyModifiers);
        ledger.Moves.Add(new(dealerSlot, targetSlot, amount, false, isUnblockable));
        HotCombatEngine.t_lastHitTotalPlusOverkill = 0;
        __result = 0;
        return false;
    }

    private static bool DeclareDoom([HarmonyArgument(2)]HotRules rules, [HarmonyArgument(4)]byte ownerSlot,
        [HarmonyArgument(5)]byte applierSlot, [HarmonyArgument(6)]ushort powerDefId,
        [HarmonyArgument(7)]ref int amount, ref int __result)
    {
        if (_outgoing is not {} ledger || amount <= 0 || applierSlot == byte.MaxValue
            || powerDefId == 0 || powerDefId != rules.GetPowerDefId(HotPowerId.DoomPower)) return true;
        if ((ownerSlot < 3) == (applierSlot < 3))
        {
            amount = ledger.ScaleDoom(amount);
            return true;
        }
        ledger.Moves.Add(new(applierSlot, ownerSlot, amount, true));
        __result = 0;
        return false;
    }
}
