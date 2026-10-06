namespace NationalSpire;

public static partial class LiveCommentary
{
    // 复用已有生涯持久化字典；各组最多记录 24 个关注点，与句子历史分开。
    private static List<string> FocusHistory(BroadcastMemory memory, string category)
    {
        string key = "$focus:" + category;
        return memory.SharedPhrases.GetValueOrDefault(key, []);
    }

    private static void RememberFocus(BroadcastMemory memory, string category, string focus)
    {
        var values = FocusHistory(memory, category);
        values.Add(focus);
        if (values.Count > 24) values.RemoveRange(0, values.Count - 24);
        memory.SharedPhrases["$focus:" + category] = values;
    }

    private static string? ChooseFocus(BroadcastMemory memory, string category, IEnumerable<string> candidates,
        string seed, Func<string, string> family)
    {
        var history = FocusHistory(memory, category).TakeLast(category == "victory" ? 6 : 12).ToList();
        var choices = candidates.Distinct().ToList();
        // 同时存在多个真实角度时，优先切换关注点；重要结果仍由调用方直接播报。
        if (choices.Any(t => family(t) != history.LastOrDefault()))
            choices.RemoveAll(t => family(t) == history.LastOrDefault());
        return choices.OrderBy(t => history.Count(h => h == family(t)) * 100
            + CareerEngine.StableHash(seed + ":focus:" + t) % 100).FirstOrDefault();
    }

    private static string TopicFamily(string topic) => topic switch
    {
        "cards" or "cards_repeat" => "cards",
        "damage" or "damage_record" => "damage",
        "clean" or "clean_streak" or "elite_clean" or "healthy_chat" => "clean",
        "elite_route" or "elite_repeat" or "elite_risk" => "elite_route",
        "skip_reward" or "skip_repeat" => "skip",
        "energy" or "energy_repeat" => "energy",
        "discard_potion" or "discard_repeat" => "discard",
        _ => topic
    };

    private static string DetailFamily(string topic) => topic switch
    {
        "victory_sprint" or "victory_fast" => "speed",
        "victory_low" or "victory_normal" or "victory_healthy" => "health",
        "potion_first" or "potion_repeat" => "potion_frequency",
        "shop_rich" or "shop_mid" or "shop_poor" => "budget",
        _ => topic
    };
}
