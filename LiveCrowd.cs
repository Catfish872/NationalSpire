namespace NationalSpire;

public sealed partial class LiveVoices
{
    private bool _finished;
    private int _crowdFloor = -1;
    private void RestoreVoiceClock(double now)
    {
        if (now < _lastClock)
        {
            _pending.Clear();
            _memory.Voices.NextCrowdAt = now + 30;
            _memory.Voices.LastCueAt = now;
        }
        _lastClock = now;
    }
    private void ClearCombatChatter(bool keepFinishingHit = false)
    {
        var kept = _pending.Where(p => keepFinishingHit && (p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)
                || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal))
            || !p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)
                && !p.Line.Topic.Contains("_cue_", StringComparison.Ordinal)).ToArray();
        _pending.Clear(); foreach (var entry in kept) _pending.Enqueue(entry);
    }
    // 与解说事件独立计时；不扫描全体人物，不调用 AI，也不在菜单或战斗结束后续播闲聊。
    public void Ambient(bool combat, int floor, double now)
    {
        RestoreVoiceClock(now);
        if (_crowdFloor != floor) { ClearCombatChatter(); _crowdFloor = floor; }
        else if (!combat) ClearCombatChatter(keepFinishingHit: true);
        var state = _memory.Voices;
        if (!combat || _finished) { state.NextCrowdAt = now + 25; return; }
        if (state.NextCrowdAt <= 0 || state.NextCrowdAt > now + 90)
            state.NextCrowdAt = now + 25 + Hash("idle:first:" + floor) % 26;
        if (now < state.NextCrowdAt) return;
        state.NextCrowdAt = now + 32 + Hash("idle:wait:" + state.Sequence + floor) % 29;
        if (_pending.Count > 0 || now - state.LastOptional < 24) return;
        var person = Spectator("idle"); if (person == null) return;
        string tone = Tone(person);
        string clubId = person.SupportedClubId;
        var club = _data.Esports.Clubs.FirstOrDefault(c => c.Id == clubId);
        var clubTarget = club == null ? null : _opponents.Select(id => CareerEngine.Person(_data, id)).FirstOrDefault(p => p?.ClubId == clubId);
        string? supported = club != null && clubId == _data.Esports.ClubId ? CareerEngine.Name(_data) : clubTarget?.PublicName;
        int draw = Hash("idle:kind:" + state.Sequence + floor) % 8;
        string kind = draw == 0 && person.Country != _data.Esports.Country ? "foreign_" + (tone is "doubt" or "tease" ? "bait" : "fan")
            : draw == 1 && supported != null ? "club"
            : draw == 2 ? "chat" : draw == 3 ? "noise"
            : tone == "doubt" ? "expert" : tone == "support" ? "cheer" : tone == "tease" ? "bait" : "newbie";
        var facts = new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data), ["country"] = person.Country,
            ["club"] = club?.Name ?? "", ["supported"] = supported ?? "" };
        string? reply = kind == "chat" && Hash("idle:reply:" + state.Sequence) % 3 == 0 ? "reply_idle_chat" : null;
        Add(Line("audience_idle_" + kind, "audience", person, facts), now, reply, lifetime: 24);
    }
    // 卡名梗与战损梗只接受真实事件。每类隔数层才有机会再次出现，连续出同一张牌不会刷屏。
    public void Cue(string scene, string name, int floor, double now, int loss = 0)
    {
        if (!LiveVoiceCatalog.Banks.ContainsKey("audience_cue_" + scene)
            || !LiveVoiceCatalog.Banks.ContainsKey("host_cue_" + scene)) return;
        RestoreVoiceClock(now);
        if (_crowdFloor != floor) { ClearCombatChatter(); _crowdFloor = floor; }
        if (_finished || _pending.Count > 0 || now - _memory.Voices.LastCueAt < 55
            || floor - _memory.Voices.Floors.GetValueOrDefault("cue:" + scene, -20) < 4) return;
        _memory.Voices.Floors["cue:" + scene] = floor;
        if (Hash("cue:chance:" + scene + floor) % 3 == 0) return;
        var person = Spectator("cue:" + scene); if (person == null) return;
        _memory.Voices.LastCueAt = now;
        bool host = Hash("cue:host:" + scene + floor) % 4 == 0;
        var facts = new Dictionary<string, string> { ["name"] = name, ["loss"] = loss.ToString() };
        Add(Line((host ? "host_cue_" : "audience_cue_") + scene, host ? "commentator" : "audience", host ? null : person, facts), now, lifetime: 23);
    }
}

internal static class LiveCueRules
{
    internal static string? CardScene(string id, bool attackWithBlock) => id switch
    {
        "COSMIC_INDIFFERENCE" => "cosmic", "IRON_WAVE" => "iron_wave",
        "APOTHEOSIS" => "apotheosis", "ECHO_FORM" => "echo", "BIASED_COGNITION" => "bias",
        _ => attackWithBlock ? "attack_block" : null
    };
}
