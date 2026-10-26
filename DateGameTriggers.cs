namespace NationalSpire;

public sealed record DateGameObservation(int Floor, int Act, int Hp, int MaxHp, double Seconds, int GoldSpent = 0);
public sealed record DateGameNpc(string Person, RivalProgress Progress, int MaxHp);
public sealed record DateGameCue(string Person, string Key, string Text, bool Chat, string Context = "");
public sealed record DateGameFact(string Trigger, int Act, int Floor, double Value, string Person = "");

/// <summary>确定性触发判定与去重；台词选取由调用者提供随机数。</summary>
public static class DateGameTriggers
{
    // 短暂条件先保留事实，再等待播报和聊天冷却；存档恢复继续使用同一组去重键。
    private static bool Remember(DateGameState state, DateGameFact fact)
    {
        int index = state.Facts.FindIndex(f => f.Trigger == fact.Trigger && f.Act == fact.Act && f.Person == fact.Person);
        if (index < 0) { state.Facts.Add(fact); return true; }
        if (state.Facts[index].Value >= fact.Value) return false;
        state.Facts[index] = fact; return true;
    }
    public static bool Observe(DateGameState state, DateGameObservation player, IReadOnlyList<DateGameNpc> npcs)
    {
        bool changed = player.GoldSpent > 0 && Remember(state, new("gold-spent", player.Act, player.Floor, player.GoldSpent));
        foreach (var npc in npcs)
        {
            double damage = npc.MaxHp > 0 ? 100.0 * (npc.Progress.Step.HpBefore - npc.Progress.Hp) / npc.MaxHp : 0;
            if (damage > 0) changed |= Remember(state, new("npc-damage", npc.Progress.Step.Act, npc.Progress.Step.Floor, damage, npc.Person));
            int gap = Math.Abs(player.Floor - npc.Progress.Step.Floor);
            if (gap > 0) changed |= Remember(state, new("floor-gap", player.Act, player.Floor, gap, npc.Person));
        }
        return changed;
    }
    public static bool CombatWon(DateGameState state, string kind, int act, int floor, double started, double ended, bool complete)
    {
        string trigger = kind switch { "Elite" => "elite-fast", "Boss" => "boss-fast", _ => "" };
        if (!complete || trigger.Length == 0 || !double.IsFinite(started) || !double.IsFinite(ended) || started < 0 || ended < started) return false;
        // 同一层多次回调保持第一次完整战斗的结果。
        if (state.Facts.Any(f => f.Trigger == trigger && f.Act == act && f.Floor == floor)) return false;
        state.Facts.Add(new(trigger, act, floor, ended - started)); return true;
    }
    private static bool PerAct(string trigger) => trigger is "npc-damage" or "gold-spent" or "elite-fast" or "boss-fast";
    public static DateGameCue? Next(DateGameState state, IReadOnlyList<DateGameRule> rules, DateGameObservation player, IReadOnlyList<DateGameNpc> npcs, int choice, DateGameTiming? timing = null)
    {
        timing ??= new();
        if (npcs.Count == 0 || player.Seconds - state.LastSpeech < timing.SpeechSeconds) return null;
        foreach (var rule in rules.Where(r => r.Enabled && r.Lines.Count > 0))
        {
            if (rule.Chat && (state.PendingChat.Length > 0 || player.Seconds - state.LastChat < Math.Max(DateGames.ChatRequestInterval, timing.ChatSeconds))) continue;
            if (PerAct(rule.Trigger) || rule.Trigger == "floor-gap")
            {
                foreach (var fact in state.Facts.Where(f => f.Trigger == rule.Trigger && (rule.Trigger is "elite-fast" or "boss-fast" ? f.Value < rule.Threshold : f.Value >= rule.Threshold)))
                {
                    string factKey = rule.Trigger + (PerAct(rule.Trigger) ? "/act/" + fact.Act : "");
                    if (state.Fired.Contains(factKey)) continue;
                    var speaker = npcs.FirstOrDefault(n => n.Person == fact.Person) ?? npcs[(choice & int.MaxValue) % npcs.Count];
                    string context = $"触发事实：第{fact.Act + 1}幕，第{fact.Floor}层；{LabelFact(fact)}。";
                    return new(speaker.Person, factKey, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat, context);
                }
                continue;
            }
            foreach (var npc in npcs)
            {
                var progress = npc.Progress;
                bool match = rule.Trigger switch
                {
                    "fast" => player.Floor >= Math.Max(20, timing.FastMinimumFloor) && player.Seconds / player.Floor <= rule.Threshold,
                    "act1" => player.Act >= 1,
                    "act2" => player.Act >= 2,
                    "npc-death" => progress.Dead,
                    "player-danger" => player.MaxHp > 0 && 100.0 * player.Hp / player.MaxHp <= rule.Threshold,
                    _ => false
                };
                if (!match) continue;
                bool perNpc = rule.Trigger == "npc-death";
                string key = rule.Trigger + (perNpc ? "/" + npc.Person : "");
                if (state.Fired.Contains(key)) continue;
                var speaker = perNpc ? npc : npcs[(choice & int.MaxValue) % npcs.Count];
                return new(speaker.Person, key, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat);
            }
        }
        return null;
    }
    private static string LabelFact(DateGameFact fact) => fact.Trigger switch
    {
        "gold-spent" => $"玩家本层实际花费{fact.Value:0}金币",
        "elite-fast" => $"玩家精英战获胜，用时{fact.Value:F1}秒",
        "boss-fast" => $"玩家首领战获胜，用时{fact.Value:F1}秒",
        "npc-damage" => $"该NPC单层损失{fact.Value:F1}%最大生命",
        _ => $"玩家与该NPC相差{fact.Value:0}层"
    };
    public static void Record(DateGameState state, DateGameCue cue, double seconds)
    {
        state.Fired.Add(cue.Key);
        state.LastSpeech = seconds;
        if (cue.Chat) { state.LastChat = seconds; state.PendingChat = cue.Text; }
    }
}
