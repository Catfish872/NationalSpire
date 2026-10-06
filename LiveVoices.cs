namespace NationalSpire;

public sealed class LiveVoiceState
{
    public int Sequence { get; set; }
    public double LastOptional { get; set; } = -100;
    public Dictionary<string, int> Floors { get; set; } = [];
    public Dictionary<string, List<int>> Recent { get; set; } = [];
    public double NextCrowdAt { get; set; }
    public double LastCueAt { get; set; } = -100;
}

/// <summary>现场发言仅依据已经发生的事情；队列不存档，重载不会补播旧对话。</summary>
public sealed partial class LiveVoices
{
    private sealed record Pending(BroadcastLine Line, double At, double Expires, string? ReplyBank = null);
    private readonly CareerData _data;
    private readonly CareerMatch _match;
    private readonly BroadcastMemory _memory;
    private readonly CareerPerson[] _audience;
    private readonly Queue<Pending> _pending = new();
    private readonly string[] _opponents;
    private double _lastClock;
    private int _lastRivalFloor = -1;
    public LiveVoices(CareerData data, CareerMatch match, BroadcastMemory memory, IEnumerable<string> opponents)
    {
        _data = data; _match = match; _memory = memory; _opponents = opponents.ToArray();
        var excluded = CommentatorSelection.Participants(data, match, _opponents);
        excluded.UnionWith(CommentatorSelection.ForMatch(data, match, _opponents).Select(p => p.Id));
        // 一场固定一批观众，避免每次刷新扫描人物库。
        var candidates = data.People.Where(p => !excluded.Contains(p.Id) && p.Role is not ("解说" or "解说员" or "教练")).ToArray();
        _audience = candidates
            .OrderBy(p => p.Role == "普通玩家" ? 0 : 1)
            .ThenBy(p => CareerEngine.StableHash(match.Seed + ":audience:" + p.Id)).Take(20)
            .Concat(candidates.Where(p => p.Country != data.Esports.Country).OrderBy(p => Hash("foreign:" + p.Id)).Take(4))
            .Concat(candidates.Where(p => p.SupportedClubId.Length > 0).OrderBy(p => Hash("club:" + p.Id)).Take(4))
            .DistinctBy(p => p.Id).ToArray();
    }
    public static string Byline(string name, string role) => role switch
    { "audience" => name + " · 观众", "thought" => name + " · 内心", _ => name + " · 解说" };

    private int Hash(string key) => CareerEngine.StableHash(_match.Seed + ":voices:" + key);
    private string Phrase(string bank, Dictionary<string, string> facts)
    {
        if (!LiveVoiceCatalog.Banks.TryGetValue(bank, out var lines)) return "";
        var state = _memory.Voices;
        if (!state.Recent.TryGetValue(bank, out var recent)) state.Recent[bank] = recent = [];
        int start = Hash(bank + ":" + state.Sequence++) % lines.Length;
        string historyKey = "$voice:" + bank;
        if (!_memory.SharedPhrases.TryGetValue(historyKey, out var history)) _memory.SharedPhrases[historyKey] = history = [];
        int index = Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length)
            .FirstOrDefault(i => !recent.Contains(i) && !history.Contains(lines[i]),
                Enumerable.Range(0, lines.Length).Select(i => (start + i) % lines.Length).FirstOrDefault(i => !history.Contains(lines[i]), start));
        recent.Remove(index); recent.Add(index);
        if (recent.Count > Math.Min(10, lines.Length - 1)) recent.RemoveAt(0);
        history.Remove(lines[index]); history.Add(lines[index]);
        if (history.Count > Math.Min(10, lines.Length - 1)) history.RemoveAt(0);
        string text = LiveSpeechComposer.Compose(lines[index], bank, _memory, _match.Seed, state.Sequence, facts);
        foreach (var (key, value) in facts) text = text.Replace("{" + key + "}", value, StringComparison.Ordinal);
        return text.Contains('{') ? "" : text;
    }
    private string Tone(CareerPerson person)
    {
        PersonalityLibrary.Ensure(_data, person);
        int attitude = PersonalityLibrary.Attitude(_data, person.Id, person.Personality, _match.Seed);
        return person.Personality.Kind switch
        {
            "故意挑事者" or "反串拱火者" or "看戏起哄者" or "刻薄玩笑者" => "tease",
            "直率求助者" or "自嘲找同伴者" => "curious",
            _ => attitude <= -1 ? "doubt" : attitude >= 2 ? "support" : "curious"
        };
    }
    private CareerPerson? Spectator(string scene, string? exclude = null, bool reply = false)
    {
        var people = _audience.Where(p => p.Id != exclude).ToArray();
        if (reply) people = people.Where(p => Tone(p) is "support" or "tease").ToArray();
        return people.Length == 0 ? null : people[Hash(scene + _memory.Voices.Sequence) % people.Length];
    }
    private BroadcastLine? Line(string bank, string role, CareerPerson? person, Dictionary<string, string> facts)
    {
        string text = Phrase(bank, facts);
        return text.Length == 0 ? null : new BroadcastLine(bank, text, _memory.Voices.Sequence % 2 == 0) { SpeakerId = person?.Id ?? "", Role = role };
    }
    private void Add(BroadcastLine? line, double now, string? replyBank = null, bool priority = false, double lifetime = 35)
    {
        if (line == null) return;
        if (priority) _pending.Clear();
        if (_pending.Count >= 3) return;
        _pending.Enqueue(new(line, now + (priority ? 0 : 8), now + lifetime, replyBank));
    }
    public void React(string topic, int floor, double now)
    {
        if (topic is "player_champion" or "player_finished") { _pending.Clear(); _finished = true; return; }
        string? scene = topic switch
        {
            "cards" or "cards_repeat" => "cards", "draws" => "draws",
            "damage" or "damage_record" => "damage", "clean" or "clean_streak" => "clean",
            "elite_clean" => "elite", "quick" => "quick", "boss" => "boss",
            "gap_act" => "cross", "gap_extend" or "gap_lead" => "lead",
            "player_danger" => "danger", "recovery" => "survived", "reward_skip" or "skip_reward" or "skip_repeat" => "skip",
            "elite_risk" => "risk", "potion_burst" => "thirst",
            _ => null
        };
        if (scene == null || floor - _memory.Voices.Floors.GetValueOrDefault(scene, -10) < 3 || _pending.Count > 0) return;
        _memory.Voices.Floors[scene] = floor;
        var person = Spectator(scene); if (person == null) return;
        string tone = Tone(person), bank = "audience_" + scene + "_" + tone;
        var facts = new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data) };
        string? reply = tone == "doubt" && LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene) ? "reply_" + scene : null;
        Add(Line(bank, "audience", person, facts), now, reply);
    }
    public void Shop(string kind, string item, int deckSize, int gold, string name, int floor, double now, string cardType = "")
    {
        var facts = new Dictionary<string, string> { ["item"] = item, ["name"] = name, ["deck"] = deckSize.ToString(), ["gold"] = gold.ToString() };
        if (kind == "reward_card")
        {
            if (_pending.Count > 0 || _memory.Voices.Floors.GetValueOrDefault("card_gain", -10) == floor) return;
            _memory.Voices.Floors["card_gain"] = floor;
            if (Hash("card_gain:" + floor) % 3 == 0) return;
            var viewer = Spectator("card_gain"); if (viewer == null) return;
            string type = cardType is "Attack" or "Skill" or "Power" ? cardType.ToLowerInvariant() : "other";
            Add(Line("audience_gain_" + type, "audience", viewer, facts), now, lifetime: 24);
            return;
        }
        Add(Line("shop_" + kind, "commentator", null, facts), now, priority: true);
        // 商店赠送或异步结算尚未记录花费时，只报获得卡牌，不推测花钱。
        if (kind == "gain_card") return;
        string scene = kind == "remove_curse" ? "curse" : kind.StartsWith("remove") ? deckSize <= 10 ? "small" : "remove" : "buy";
        var person = Spectator(scene); if (person == null) return;
        string tone = Tone(person);
        Add(Line("audience_" + scene + "_" + tone, "audience", person, facts), now,
            tone == "doubt" && LiveVoiceCatalog.Banks.ContainsKey("reply_" + scene) ? "reply_" + scene : null);
    }
    public void Rival(int floor, int act, int hp, int maxHp, RivalProgress progress, LiveMatchState live, double now,
        IEnumerable<(string Id, RivalProgress Progress, int MaxHp)>? members = null)
    {
        if (progress.Finished)
        {
            var remaining = _pending.Where(p => p.Line.Role != "thought").ToArray();
            _pending.Clear(); foreach (var entry in remaining) _pending.Enqueue(entry);
        }
        if (progress.Finished || floor == _lastRivalFloor || now <= live.PaceNeutralUntil || now - _memory.Voices.LastOptional < 35 || _pending.Count > 0) return;
        _lastRivalFloor = floor;
        var candidates = members?.Where(m => !m.Progress.Finished).ToArray()
            ?? _opponents.Select(id => (Id: id, Progress: progress, MaxHp: live.MaxHp)).ToArray();
        if (candidates.Length == 0) return;
        var rival = candidates[Hash("rival:" + floor) % candidates.Length];
        var person = CareerEngine.Person(_data, rival.Id); if (person == null) return;
        int gap = floor - progress.Step.Floor;
        string? scene = gap >= 2 && hp <= maxHp * .25 && rival.Progress.Hp > rival.MaxHp * .3 ? "chance"
            : gap >= 5 && rival.Progress.Hp <= rival.MaxHp * .3 ? "hurt_behind"
            : gap >= 5 && hp >= maxHp * .85 ? "healthy_lead"
            : act > progress.Step.Act && gap >= 3 ? "cross"
            : gap >= 9 ? "far" : gap >= 4 ? "behind"
            : rival.Progress.Hp <= rival.MaxHp * .25 ? "danger"
            : gap <= -4 ? "ahead" : null;
        if (scene == null || !RivalSimulation.Combat(rival.Progress.Step.Kind)
            || floor - _memory.Voices.Floors.GetValueOrDefault("thought:" + scene, -12) < 5) return;
        _memory.Voices.Floors["thought:" + scene] = floor;
        PersonalityLibrary.Ensure(_data, person);
        string temper = person.Personality.AttitudeMin <= -3 ? "proud" : "anxious";
        var facts = new Dictionary<string, string> { ["gap"] = Math.Abs(gap).ToString(), ["hp"] = rival.Progress.Hp.ToString(), ["name"] = CareerEngine.Name(_data) };
        Add(Line("thought_" + scene + "_" + temper, "thought", person, facts), now);
    }
    public BroadcastLine? Poll(double now, double lastCommentary)
    {
        RestoreVoiceClock(now);
        if (_memory.Voices.LastOptional > now) _memory.Voices.LastOptional = now;
        while (_pending.TryPeek(out var old) && old.Expires < now) _pending.Dequeue();
        if (!_pending.TryPeek(out var next) || now < next.At || now - lastCommentary < 8) return null;
        if (next.Line.Role != "commentator" && now - _memory.Voices.LastOptional < 22) return null;
        _pending.Dequeue();
        if (next.Line.Role != "commentator") _memory.Voices.LastOptional = now;
        if (next.ReplyBank != null && Hash(next.Line.Text) % 3 != 0 && Spectator(next.ReplyBank, next.Line.SpeakerId, true) is { } responder)
        {
            var facts = new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data) };
            // 只有上一句真正显示过，才允许出现反驳它的回话。
            Add(Line(next.ReplyBank, "audience", responder, facts), now);
        }
        return next.Line;
    }
}
