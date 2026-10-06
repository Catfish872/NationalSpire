namespace NationalSpire;

public sealed record AtmosphereContext(string Name, string Rival, string Event, string Character, int Ascension,
    int Floor, int Act, string Kind, int Hp, int MaxHp, int Gold, int Turn, bool InCombat);

public static partial class LiveCommentary
{
    // 各分句独立成立，事实与语气分别选择，组合保持明确指向。
    private static readonly Dictionary<string, string[]> AtmosphereBanks = [];

    public static BroadcastLine? Atmosphere(BroadcastMemory m, AtmosphereContext c, string seed, double seconds)
    {
        if (seconds < m.NextAtmosphereAt || seconds - m.LastSpoke < 32 || c.Floor == m.AtmosphereFloor) return null;
        var topics = new List<string>();
        if (c.Floor <= 3 && !m.TopicTimes.ContainsKey("opening")) topics.Add("opening");
        else
        {
            if (c.Act == 0 && c.Floor <= 8) topics.Add("early_chat");
            if (c.Kind == "Shop") topics.Add("shop_chat");
            if (c.Kind == "RestSite") topics.Add("rest_chat");
            if (c.Kind is "Unknown" or "Event" && !c.InCombat) topics.Add("unknown_chat");
            if (c.InCombat && c.Turn >= 5) topics.Add("long_battle");
            if (m.Battles >= 2 && c.Hp >= c.MaxHp * .8) topics.Add("healthy_chat");
        }
        topics.RemoveAll(t => m.PhraseIndices.GetValueOrDefault("count:" + t) >= 2 || seconds - m.TopicTimes.GetValueOrDefault(t, -1000) < 140);
        if (topics.Count == 0) return null;
        string topic = ChooseFocus(m, "topics", topics, seed + ":chat:" + c.Floor, TopicFamily)!;
        var facts = new Dictionary<string, string> { ["name"] = c.Name, ["rival"] = c.Rival, ["event"] = c.Event, ["character"] = c.Character, ["asc"] = c.Ascension.ToString(),
            ["floor"] = c.Floor.ToString(), ["hp"] = c.Hp.ToString(), ["max"] = c.MaxHp.ToString(), ["gold"] = c.Gold.ToString(), ["turn"] = c.Turn.ToString() };
        var line = Speak(m, topic, seconds, seed, facts);
        if (line != null)
        {
            m.AtmosphereFloor = c.Floor; m.PhraseIndices["count:" + topic] = m.PhraseIndices.GetValueOrDefault("count:" + topic) + 1;
            m.NextAtmosphereAt = seconds + 58 + CareerEngine.StableHash(seed + c.Floor) % 34;
        }
        return line;
    }
    public static BroadcastLine? Rival(LiveMatchState live, RivalProgress progress, string name, string rival, string seed, double seconds)
    {
        var m = live.Commentary; var step = progress.Step;
        var facts = new Dictionary<string, string> { ["name"] = name, ["rival"] = rival, ["floor"] = step.Floor.ToString(), ["act"] = (step.Act + 1).ToString(),
            ["hp"] = progress.Hp.ToString(), ["max"] = live.MaxHp.ToString(), ["time"] = MatchRules.Time(live.Steps[^1].End), ["room"] = RivalSimulation.RoomName(step.Kind) };
        if (progress.Finished)
        {
            // 终局事实立即播报，界面同时清理过时的对手血量描述。
            if (m.TopicTimes.ContainsKey("rival_final")) return null;
            var line = Speak(m, progress.Dead ? "rival_dead" : "rival_clear", seconds, seed, facts, true);
            if (line != null) m.TopicTimes["rival_final"] = seconds;
            return line;
        }
        if (m.RivalAct < 0) m.RivalAct = step.Act;
        if (step.Act != m.RivalAct)
        {
            var line = Speak(m, "rival_act", seconds, seed, facts);
            if (line != null) { m.RivalAct = step.Act; return line; }
        }
        if (seconds - m.TopicTimes.GetValueOrDefault("rival_health", -1000) < 65) return null;
        int loss = step.HpBefore - progress.Hp;
        if (m.RivalInjuryFloor != step.Floor && loss >= Math.Max(12, live.MaxHp * .2))
        {
            facts["loss"] = loss.ToString();
            var line = Speak(m, progress.Hp <= live.MaxHp * .25 ? "rival_danger" : "rival_hurt", seconds, seed, facts);
            if (line != null) { m.RivalInjuryFloor = step.Floor; m.TopicTimes["rival_health"] = seconds; return line; }
        }
        var previous = live.Steps.LastOrDefault(s => s.End <= seconds);
        if (previous != null && seconds - previous.End < 30 && previous.HpAfter - previous.HpBefore >= live.MaxHp * .15 && m.RivalRecoveryFloor != previous.Floor)
        {
            facts["gain"] = (previous.HpAfter - previous.HpBefore).ToString(); facts["hp"] = previous.HpAfter.ToString();
            var line = Speak(m, "rival_recover", seconds, seed, facts);
            if (line != null) { m.RivalRecoveryFloor = previous.Floor; m.TopicTimes["rival_health"] = seconds; return line; }
        }
        return null;
    }
}
