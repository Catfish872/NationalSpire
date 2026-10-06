namespace NationalSpire;

public sealed class BroadcastMemory
{
    public LiveVoiceState Voices { get; set; } = new();
    [System.Text.Json.Serialization.JsonIgnore]
    public Dictionary<string, List<string>> SharedPhrases { get; set; } = [];
    public double NextAtmosphereAt { get; set; } = 10;
    public int AtmosphereFloor { get; set; } = -1;
    public int RivalAct { get; set; } = -1;
    public int RivalInjuryFloor { get; set; } = -1;
    public int RivalRecoveryFloor { get; set; } = -1;
    public int CompletedFloor { get; set; }
    public int RouteFloor { get; set; }
    public int Battles { get; set; }
    public int CleanStreak { get; set; }
    public int BestCleanStreak { get; set; }
    public int LongTurns { get; set; }
    public int QuickWins { get; set; }
    public int EliteVisits { get; set; }
    public int UnknownVisits { get; set; }
    public int RestVisits { get; set; }
    public int BestDamage { get; set; }
    public int BestCards { get; set; }
    public int BestDraws { get; set; }
    public int? ObservedGap { get; set; }
    public int LastAnnouncedGap { get; set; }
    public int StableLeader { get; set; }
    public int CandidateLeader { get; set; }
    public double GapChangedAt { get; set; }
    public double LastSpoke { get; set; } = -100;
    public Dictionary<string, double> TopicTimes { get; set; } = [];
    public Dictionary<string, int> PhraseIndices { get; set; } = [];
    public List<string> RecentTopics { get; set; } = [];
    public List<string> RecentLines { get; set; } = [];
}
public sealed class BattleObservation
{
    public bool CompleteObservation { get; set; } = true;
    public int Floor { get; set; }
    public int Turn { get; set; }
    public int Cards { get; set; }
    public int Draws { get; set; }
    public int Damage { get; set; }
    public int HpLost { get; set; }
    public int Hp { get; set; }
    public int MaxHp { get; set; }
    public int PeakCards { get; set; }
    public int PeakDraws { get; set; }
    public int PeakDamage { get; set; }
    public string LastCard { get; set; } = "";
    public string Kind { get; set; } = "Monster";
    public int CrowdHpLost { get; set; }
    public int SmallTargetTurn { get; set; } = -100;
    public double LargeTargetMinHp { get; set; }
}
public sealed record BroadcastLine(string Topic, string Text, bool Analyst)
{
    public string SpeakerId { get; init; } = "";
    public string Role { get; init; } = "commentator";
}

/// <summary>由可核实的局内事实选择解说；累计表现与发言冷却分别记录。</summary>
public static partial class LiveCommentary
{
    private static readonly Dictionary<string, string[]> Lines = [];
    public static BroadcastLine? Speak(BroadcastMemory memory, string topic, double seconds, string seed, Dictionary<string, string> facts, bool force = false)
    {
        var bank = Lines.GetValueOrDefault(topic) ?? AtmosphereBanks.GetValueOrDefault(topic) ?? MomentBanks.GetValueOrDefault(topic);
        string worldTopic = "world_" + (topic is "cards_repeat" ? "cards" : topic is "skip_repeat" ? "skip_reward" : topic);
        if (bank == null) return null;
        if (!force && (seconds - memory.LastSpoke < 6 || seconds - memory.TopicTimes.GetValueOrDefault(topic, -1000) < 110)) return null;
        // 普通点评按关注点降频，避免换一套措辞继续反复评价同一种表现。
        string family = TopicFamily(topic);
        int repeats = FocusHistory(memory, "topics").TakeLast(12).Count(t => t == family);
        if (!force && repeats >= 3 && CareerEngine.StableHash(seed + topic + (int)(seconds / 110)) % 3 != 0) return null;
        int index = memory.PhraseIndices.GetValueOrDefault(topic, CareerEngine.StableHash(seed + topic) % bank.Length);
        string main = SelectPhrase(memory, topic, bank, seed, index);
        // 有条件的事实补句优先；一条最多附加一段，不累加语气填充。
        string tail = facts.GetValueOrDefault("tail", "");
        string text = main + tail;
        foreach (var (key, value) in facts) text = text.Replace("{" + key + "}", value, StringComparison.Ordinal);
        if (text.Contains('{')) return null;
        if (tail.Length == 0) text = LiveSpeechComposer.Compose(text, worldTopic, memory, seed, index, facts);
        RememberPhrase(memory, topic, main, bank.Length);
        if (facts.TryGetValue("tail", out string? suppliedTail))
            foreach (var (key, variants) in MomentTails)
                foreach (string phrase in variants.Where(p => p.Length > 0 && suppliedTail.Contains(p, StringComparison.Ordinal)))
                {
                    RememberPhrase(memory, "moment:" + key, phrase, variants.Length);
                    RememberFocus(memory, "details", DetailFamily(key));
                }
        RememberFocus(memory, "topics", family);
        memory.PhraseIndices[topic] = index + 1; memory.TopicTimes[topic] = seconds; memory.LastSpoke = seconds;
        memory.RecentTopics.Add(topic); if (memory.RecentTopics.Count > 8) memory.RecentTopics.RemoveAt(0);
        memory.RecentLines.Add(text); if (memory.RecentLines.Count > 5) memory.RecentLines.RemoveAt(0);
        return new(topic, text, index % 2 == 1);
    }
    private static string SelectPhrase(BroadcastMemory memory, string key, string[] bank, string seed, int index)
    {
        int start = CareerEngine.StableHash(seed + ":phrase:" + key + ":" + index) % bank.Length;
        var recent = memory.SharedPhrases.GetValueOrDefault(key);
        for (int i = 0; i < bank.Length; i++)
        {
            string phrase = bank[(start + i) % bank.Length];
            if (recent == null || !recent.Contains(phrase)) return phrase;
        }
        return bank[start];
    }
    private static void RememberPhrase(BroadcastMemory memory, string key, string phrase, int variants)
    {
        if (phrase.Length == 0) return;
        if (!memory.SharedPhrases.TryGetValue(key, out var recent)) memory.SharedPhrases[key] = recent = [];
        recent.Remove(phrase); recent.Add(phrase);
        int window = Math.Min(12, Math.Max(1, variants - 1));
        if (recent.Count > window) recent.RemoveRange(0, recent.Count - window);
    }
    private static Dictionary<string, string> Facts(BattleObservation b, string name, BroadcastMemory m) => new()
    {
        ["name"] = name, ["cards"] = b.Cards.ToString(), ["draws"] = b.Draws.ToString(), ["damage"] = b.Damage.ToString(),
        ["record"] = m.BestDamage.ToString(), ["card"] = b.LastCard.Length > 0 ? b.LastCard : "牌", ["hp"] = b.Hp.ToString(), ["max"] = b.MaxHp.ToString(), ["turn"] = b.Turn.ToString(),
        ["streak"] = m.CleanStreak.ToString(), ["elites"] = m.EliteVisits.ToString(), ["unknowns"] = m.UnknownVisits.ToString()
    };
    public static BroadcastLine? ObserveTurn(BroadcastMemory m, BattleObservation b, string name, string seed, double seconds)
    {
        var facts = Facts(b, name, m);
        var candidates = new List<string>();
        if (b.Cards >= 10) candidates.Add(m.LongTurns >= 2 ? "cards_repeat" : "cards");
        if (b.Damage >= 60) candidates.Add("damage");
        if (b.Draws >= 7) candidates.Add("draws");
        candidates.RemoveAll(t => seconds - m.TopicTimes.GetValueOrDefault(t, -1000) < 110);
        string? topic = b.Damage >= 80 && b.Damage > m.BestDamage * 1.3 && m.BestDamage >= 60 ? "damage_record"
            : ChooseFocus(m, "topics", candidates, seed + b.Floor + ":" + b.Turn, TopicFamily);
        if (topic == null) return null;
        // 同一场同一回合只播一次，重载和高频伤害不会制造重复发言。
        string key = $"turn:{b.Floor}:{b.Turn}";
        if (m.TopicTimes.ContainsKey(key)) return null;
        var line = Speak(m, topic, seconds, seed, facts);
        if (line != null) m.TopicTimes[key] = seconds;
        return line;
    }
    public static BroadcastLine? Finish(BroadcastMemory m, BattleObservation b, string name, string seed, double seconds)
    {
        if (b.Floor <= m.CompletedFloor) return null;
        m.CompletedFloor = b.Floor; m.Battles++;
        m.CleanStreak = b.CompleteObservation && b.HpLost == 0 ? m.CleanStreak + 1 : 0;
        m.BestCleanStreak = Math.Max(m.BestCleanStreak, m.CleanStreak);
        if (b.PeakCards >= 10) m.LongTurns++;
        if (b.Turn <= 2) m.QuickWins++;
        m.BestCards = Math.Max(m.BestCards, b.PeakCards); m.BestDraws = Math.Max(m.BestDraws, b.PeakDraws); m.BestDamage = Math.Max(m.BestDamage, b.PeakDamage);
        var candidates = new List<string>();
        if (b.CompleteObservation && b.HpLost == 0 && b.Kind == "Elite") candidates.Add("elite_clean");
        if (m.CleanStreak >= 3 && m.CleanStreak % 2 == 1) candidates.Add("clean_streak");
        if (b.Turn <= 2 && (m.QuickWins <= 2 || m.QuickWins % 3 == 0)) candidates.Add("quick");
        if (b.CompleteObservation && b.HpLost == 0 && m.CleanStreak == 1) candidates.Add("clean");
        candidates.RemoveAll(t => seconds - m.TopicTimes.GetValueOrDefault(t, -1000) < 110);
        string? topic = b.Kind == "Boss" ? "boss" : b.Hp <= b.MaxHp * .2 ? "recovery"
            : ChooseFocus(m, "topics", candidates, seed + ":finish:" + b.Floor, TopicFamily);
        return topic == null ? null : Speak(m, topic, seconds, seed, Facts(b, name, m), b.Kind == "Boss");
    }
    public static BroadcastLine? Route(BroadcastMemory m, BattleObservation b, string name, string seed, double seconds)
    {
        if (b.Floor <= m.RouteFloor) return null;
        m.RouteFloor = b.Floor;
        if (b.Kind == "Elite") m.EliteVisits++;
        if (b.Kind == "Unknown") m.UnknownVisits++;
        if (b.Kind == "RestSite") m.RestVisits++;
        string? topic = b.Kind == "Elite" ? (b.Hp <= b.MaxHp * .35 ? "elite_risk" : m.EliteVisits >= 3 ? "elite_repeat" : "elite_route")
            : b.Kind == "RestSite" && b.Hp < b.MaxHp * .7 ? "rest_route"
            : b.Kind == "Unknown" && m.UnknownVisits % 3 == 0 ? "unknown_route" : null;
        return topic == null ? null : Speak(m, topic, seconds, seed, Facts(b, name, m));
    }
    // 重分配行进时间期间只更新观察基准，不把视觉追赶解释为竞技表现。
    public static void RebaseGap(BroadcastMemory m, int playerFloor, int rivalFloor, double seconds)
    {
        int gap = playerFloor - rivalFloor;
        m.ObservedGap = m.LastAnnouncedGap = gap;
        m.CandidateLeader = m.StableLeader = Math.Abs(gap) >= 2 ? Math.Sign(gap) : 0;
        m.GapChangedAt = seconds;
        m.TopicTimes["gap"] = seconds;
    }

    public static BroadcastLine? Gap(BroadcastMemory m, int playerFloor, int rivalFloor, int playerAct, int rivalAct,
        string name, string rival, int hp, int maxHp, double seconds, string seed)
    {
        int gap = playerFloor - rivalFloor;
        int leader = Math.Abs(gap) >= 2 ? Math.Sign(gap) : 0;
        if (m.ObservedGap == null) { m.ObservedGap = gap; m.CandidateLeader = leader; m.GapChangedAt = seconds; return null; }
        m.ObservedGap = gap;
        if (m.CandidateLeader != leader) { m.CandidateLeader = leader; m.GapChangedAt = seconds; }
        if (leader == 0 || seconds - m.GapChangedAt < 15 || seconds - m.TopicTimes.GetValueOrDefault("gap", -1000) < 80) return null;
        int previous = m.LastAnnouncedGap;
        string? topic = leader > 0 && m.StableLeader < 0 ? "gap_overtake" : leader < 0 && m.StableLeader > 0 ? "gap_lost_lead"
            : previous == 0 ? (leader > 0 ? playerAct > rivalAct ? "gap_act" : "gap_lead" : "gap_behind")
            : leader > 0 && previous > 0 && gap >= previous + 3 ? "gap_extend"
            : leader > 0 && previous > 0 && gap <= previous - 3 ? "gap_fading"
            : leader < 0 && previous < 0 && gap >= previous + 3 ? "gap_chasing" : null;
        if (topic == null) return null;
        var facts = new Dictionary<string, string> { ["name"] = name, ["rival"] = rival, ["gap"] = Math.Abs(gap).ToString(),
            ["previous"] = Math.Abs(previous).ToString(), ["playerAct"] = (playerAct + 1).ToString(), ["rivalAct"] = (rivalAct + 1).ToString(),
            ["rivalFloor"] = rivalFloor.ToString(), ["hp"] = hp.ToString(), ["max"] = maxHp.ToString() };
        var line = Speak(m, topic, seconds, seed, facts);
        if (line != null) { m.LastAnnouncedGap = gap; m.StableLeader = leader; m.TopicTimes["gap"] = seconds; }
        return line;
    }
}
