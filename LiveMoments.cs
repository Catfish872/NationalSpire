namespace NationalSpire;

public static partial class LiveCommentary
{
    public static bool IsCombatLoss(int before, int after, int max, string room)
        => room is "Monster" or "Elite" or "Boss" && max > 0 && before > after && before <= max && after >= 0;

    // 起句表达现场反应，后句依据血量、预算及历史选择；各组件能独立成立。
    private static readonly Dictionary<string, string[]> MomentBanks = [];
    private static readonly Dictionary<string, string[]> MomentTails = [];
    private static string MomentTail(BroadcastMemory m, string key, string seed, int occurrence)
    {
        // 补充点评可留白；近期反复提及的药水次数、钱包或血线逐渐降频。
        int repeats = FocusHistory(m, "details").TakeLast(10).Count(t => t == DetailFamily(key));
        if (!(key == "hurt_clean" && repeats == 0) && !key.StartsWith("victory_", StringComparison.Ordinal)
            && CareerEngine.StableHash(seed + ":detail:" + key + occurrence) % (3 + repeats * 2) != 0) return "";
        var bank = MomentTails[key];
        return SelectPhrase(m, "moment:" + key, bank, seed, occurrence);
    }
    public static BroadcastLine? Potion(BroadcastMemory m, string potion, int hp, int max, string name, string seed, double seconds)
    {
        int count = m.PhraseIndices.GetValueOrDefault("potions_used") + 1; m.PhraseIndices["potions_used"] = count;
        double previous = m.TopicTimes.GetValueOrDefault("potion_observed", -1000);
        int burst = seconds >= previous && seconds - previous <= 30 ? m.PhraseIndices.GetValueOrDefault("potion_burst_count") + 1 : 1;
        m.PhraseIndices["potion_burst_count"] = burst; m.TopicTimes["potion_observed"] = seconds;
        if (seconds - m.TopicTimes.GetValueOrDefault("potion", -1000) < 8) return null;
        var facts = MomentFacts(name, hp, max);
        facts["potion"] = potion;
        facts["burst"] = burst.ToString();
        facts["tail"] = MomentTail(m, hp <= max * .3 ? "potion_low" : count > 1 ? "potion_repeat" : "potion_first", seed, count);
        var line = Speak(m, burst >= 2 ? "potion_burst" : "potion", seconds, seed, facts, true);
        if (line != null) m.TopicTimes["potion"] = seconds;
        return line;
    }
    public static BroadcastLine? DiscardPotion(BroadcastMemory m, string potion, int hp, int max, int left, string name, string seed, double seconds)
    {
        int count = m.PhraseIndices.GetValueOrDefault("potions_discarded") + 1; m.PhraseIndices["potions_discarded"] = count;
        if (seconds - m.TopicTimes.GetValueOrDefault("discard_potion_group", -1000) < 12) return null;
        var facts = MomentFacts(name, hp, max); facts["potion"] = potion; facts["left"] = left.ToString();
        facts["tail"] = MomentTail(m, hp <= max * .3 ? "discard_low" : "discard_normal", seed, count);
        var line = Speak(m, count > 2 ? "discard_repeat" : "discard_potion", seconds, seed, facts, true);
        if (line != null) m.TopicTimes["discard_potion_group"] = seconds;
        return line;
    }
    public static BroadcastLine? Energy(BroadcastMemory m, int floor, int turn, int gain, int current, string name, string seed, double seconds)
    {
        if (gain <= 0) return null;
        string key = $"energy:{floor}:{turn}";
        int total = m.PhraseIndices.GetValueOrDefault(key) + gain; m.PhraseIndices[key] = total;
        if (total < 5 || m.TopicTimes.ContainsKey(key) || seconds - m.TopicTimes.GetValueOrDefault("energy_group", -1000) < 45) return null;
        int count = m.PhraseIndices.GetValueOrDefault("energy_count");
        var line = Speak(m, count > 0 ? "energy_repeat" : "energy", seconds, seed,
            new() { ["name"] = name, ["gain"] = total.ToString(), ["energy"] = current.ToString() }, true);
        if (line != null) { m.TopicTimes[key] = seconds; m.TopicTimes["energy_group"] = seconds; m.PhraseIndices["energy_count"] = count + 1; }
        return line;
    }
    public static BroadcastLine? SkipReward(BroadcastMemory m, int floor, int options, int deck, string name, string seed, double seconds)
    {
        string key = "skipped:" + floor;
        if (options < 1 || m.TopicTimes.ContainsKey(key)) return null;
        m.TopicTimes[key] = seconds;
        int count = m.PhraseIndices.GetValueOrDefault("skipped_count") + 1; m.PhraseIndices["skipped_count"] = count;
        if (count > 2 && count % 3 != 0) return null;
        var facts = new Dictionary<string, string> { ["name"] = name, ["options"] = options.ToString(), ["deck"] = deck.ToString(),
            ["count"] = count.ToString(), ["streak"] = m.CleanStreak.ToString(), ["tail"] = MomentTail(m, m.CleanStreak >= 3 ? "skip_clean" : "skip_normal", seed, count) };
        return Speak(m, count > 1 ? "skip_repeat" : "skip_reward", seconds, seed, facts, true);
    }
    public static BroadcastLine? PlayerVictory(BroadcastMemory m, bool winner, double seconds, int hp, int max, string name, string rival, string seed)
    {
        if (m.TopicTimes.ContainsKey("player_final")) return null;
        var facts = MomentFacts(name, hp, max); facts["rival"] = rival; facts["time"] = MatchRules.Time(seconds);
        facts["bestClean"] = Math.Max(m.BestCleanStreak, m.CleanStreak).ToString();
        facts["bestDamage"] = m.BestDamage.ToString(); facts["bestCards"] = m.BestCards.ToString(); facts["elites"] = m.EliteVisits.ToString();
        var angles = new List<string> { "victory_closing" };
        if (max > 0) angles.Add(hp <= max * .25 ? "victory_low" : hp >= max * .8 ? "victory_healthy" : "victory_normal");
        if (seconds > 0 && seconds < 2700) angles.Add(seconds <= 2100 ? "victory_sprint" : "victory_fast");
        if (Math.Max(m.BestCleanStreak, m.CleanStreak) >= 3) angles.Add("victory_clean_run");
        if (m.BestDamage >= 80) angles.Add("victory_damage");
        if (m.BestCards >= 10) angles.Add("victory_cards");
        if (m.EliteVisits >= 3) angles.Add("victory_route");
        string focus = ChooseFocus(m, "victory", angles, seed, DetailFamily)!;
        facts["tail"] = MomentTail(m, focus, seed, 0);
        var line = Speak(m, winner ? "player_champion" : "player_finished", seconds, seed, facts, true);
        if (line != null) { m.TopicTimes["player_final"] = seconds; RememberFocus(m, "victory", DetailFamily(focus)); }
        return line;
    }
    public static BroadcastLine? PlayerLoss(BroadcastMemory m, int floor, int loss, int hp, int max, string name, string seed, double seconds)
    {
        if (hp <= 0 || max <= 0 || loss < Math.Max(10, max * .16) && !(hp <= max * .2 && loss >= 3)) return null;
        bool danger = hp <= max * .25;
        string key = danger ? "danger:" + floor : "hurt:" + floor;
        if (m.TopicTimes.ContainsKey(key) || seconds - m.TopicTimes.GetValueOrDefault("player_health", -1000) < (danger ? 5 : 30)) return null;
        int count = m.PhraseIndices.GetValueOrDefault("hurt_count") + 1;
        var facts = MomentFacts(name, hp, max); facts["loss"] = loss.ToString(); facts["streak"] = m.CleanStreak.ToString();
        facts["tail"] = m.CleanStreak >= 3 ? MomentTail(m, "hurt_clean", seed, count) : count > 1 ? MomentTail(m, "hurt_repeat", seed, count) : "";
        var line = Speak(m, danger ? "player_danger" : "player_hurt", seconds, seed, facts, true);
        if (line != null) { m.TopicTimes[key] = seconds; m.TopicTimes["player_health"] = seconds; m.PhraseIndices["hurt_count"] = count; }
        return line;
    }
    public static BroadcastLine? UnknownRoom(BroadcastMemory m, int floor, string room, int hp, int max, int gold, string name, string seed, double seconds)
    {
        string topic = room switch { "Treasure" => "question_chest", "Shop" => "question_shop", "Monster" => "question_fight", "Event" => "question_event", _ => "" };
        if (topic.Length == 0 || m.TopicTimes.ContainsKey("room:" + floor + room)) return null;
        m.TopicTimes["room:" + floor + room] = seconds;
        int count = m.PhraseIndices.GetValueOrDefault("count:" + topic) + 1; m.PhraseIndices["count:" + topic] = count;
        // 重复同类房间逐渐降低播报频率；低血量战斗仍及时提示。
        if (!(room == "Monster" && hp <= max * .3) && count > 1 && CareerEngine.StableHash(seed + floor + room) % 3 != 0) return null;
        string tail = room switch { "Shop" => gold >= 200 ? "shop_rich" : gold < 70 ? "shop_poor" : "shop_mid",
            "Treasure" => hp <= max * .3 ? "chest_low" : "chest_normal", "Monster" => hp <= max * .3 ? "fight_low" : "fight_normal",
            _ => hp <= max * .3 ? "event_low" : "event_normal" };
        var facts = MomentFacts(name, hp, max); facts["gold"] = gold.ToString(); facts["tail"] = MomentTail(m, tail, seed, count);
        return Speak(m, topic, seconds, seed, facts, true);
    }
    private static Dictionary<string, string> MomentFacts(string name, int hp, int max) => new() { ["name"] = name, ["hp"] = hp.ToString(), ["max"] = max.ToString() };
}
