using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Combat.History;
using MegaCrit.Sts2.Core.Combat.History.Entries;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace NationalSpire;

internal static class LiveVoiceObservation
{
    public static void Observe(LiveVoices? voices, BattleObservation battle, ICombatState state, Player player,
        CombatHistoryEntry entry, string name, double now)
    {
        if (voices == null || player.Creature.CurrentHp <= 0) return;
        // 最后一击通常紧邻战斗结束，仍允许短暂播报；其他战斗事件不在结算阶段补播。
        if (CombatManager.Instance.IsEnding && entry is not DamageReceivedEntry { Result.WasTargetKilled: true }) return;
        if (entry is CardPlayStartedEntry started && started.CardPlay.Card.Owner == player
            && started.CardPlay.Card.TargetType == TargetType.AnyEnemy
            && started.CardPlay.Card.Type == CardType.Attack
            && started.CardPlay.Target?.Monster?.Id.Entry == "QUEEN"
            && state.Enemies.Any(e => e.IsAlive && e.Monster?.Id.Entry == "TORCH_HEAD_AMALGAM"))
            voices.Cue("ignore_torch", name, battle.Floor, now);
        if (entry is CardPlayFinishedEntry card && card.CardPlay.Card.Owner == player)
        {
            string? cue = LiveCueRules.CardScene(card.CardPlay.Card.Id.Entry,
                card.CardPlay.Card.Type == CardType.Attack && card.CardPlay.Card.GainsBlock);
            if (cue != null) voices.Cue(cue, name, battle.Floor, now);
        }
        if (entry is not DamageReceivedEntry damage) return;
        if (damage.Dealer == player.Creature && damage.Receiver.IsEnemy && damage.Result.UnblockedDamage > 0
            && damage.CardSource?.TargetType == TargetType.AnyEnemy
            && state.Enemies.Any(e => e != damage.Receiver && e.IsAlive && e.MaxHp >= damage.Receiver.MaxHp * 1.6))
        {
            battle.SmallTargetTurn = battle.Turn;
            battle.LargeTargetMinHp = damage.Receiver.MaxHp * 1.6;
        }
        if (damage.Dealer == player.Creature && damage.Receiver.IsEnemy && damage.Result.WasTargetKilled)
        {
            if (damage.Result.OverkillDamage == 0) voices.Cue("exact_lethal", name, battle.Floor, now);
            else if (damage.Result.OverkillDamage >= 30) voices.Cue("overkill", name, battle.Floor, now);
        }
        if (damage.Receiver != player.Creature || damage.Dealer?.IsEnemy != true) return;
        battle.CrowdHpLost += Math.Max(0, damage.Result.UnblockedDamage);
        if (battle.CrowdHpLost < Math.Max(12, player.Creature.MaxHp * .18)) return;
        bool largeStillAlive = state.Enemies.Any(e => e.IsAlive && e.MaxHp >= battle.LargeTargetMinHp);
        voices.Cue(battle.SmallTargetTurn >= battle.Turn - 1 && largeStillAlive ? "small_focus" : "hurt",
            name, battle.Floor, now, battle.CrowdHpLost);
    }
}
