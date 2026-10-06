using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Combat.History.Entries;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire.Coop;

/// <summary>只由主机读取原版战斗事实；分别记录队员表现，共用播报间隔。</summary>
public sealed class CoopBroadcast : IDisposable
{
    private readonly CoopCoordinator _session;
    private readonly Dictionary<ulong, BattleObservation> _battles = [];
    private int _historyCount, _speakerTurn;
    private LiveVoices? _voices;
    private LiveShopObserver? _shop;
    public CoopBroadcast(CoopCoordinator session)
    {
        _session = session;
        if (RunManager.Instance.DebugOnlyGetState() is { } run) _shop = new(run);
        CombatManager.Instance.CombatSetUp += Started;
        CombatManager.Instance.CombatWon += Won;
        CombatManager.Instance.History.Changed += Changed;
        if (CombatManager.Instance.IsInProgress) Initialize(false);
        _historyCount = CombatManager.Instance.History.Entries.Count();
    }
    private bool Active => _session.Host && _session.World?.Run is { Terminal: null } live
        && RunManager.Instance.DebugOnlyGetState()?.Rng.StringSeed == live.Seed;
    private void Guard(Action action) { try { if (Active) { RestoreClock(); action(); } } catch (Exception e) { Diagnostics.Error("coop.commentary", e); } }
    private void Started(ICombatState state) => Guard(() => Initialize(true));
    private void Initialize(bool complete)
    {
        _battles.Clear(); _historyCount = 0;
        var state = RunManager.Instance.DebugOnlyGetState(); if (state == null) return;
        foreach (var p in state.Players)
            _battles[p.NetId] = new() { Floor = state.TotalFloor, Kind = state.CurrentRoom?.RoomType.ToString() ?? "Monster", Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp, CompleteObservation = complete };
    }
    private BroadcastMemory Memory(ulong id)
    {
        var live = _session.World!.Run!;
        if (!live.Broadcasts.TryGetValue(id, out var memory)) live.Broadcasts[id] = memory = new();
        memory.SharedPhrases = _session.World.World.BroadcastHistory;
        return memory;
    }
    private void RestoreClock()
    {
        var live = _session.World!.Run!; double now = RunManager.Instance.RunTime;
        foreach (var memory in live.Broadcasts.Values.Concat(live.Rival == null ? [] : new[] { live.Rival.Commentary }))
        {
            if (memory.LastSpoke <= now) continue;
            double shift = memory.LastSpoke - now + 6;
            memory.LastSpoke -= shift;
            foreach (string topic in memory.TopicTimes.Keys.ToArray()) memory.TopicTimes[topic] -= shift;
            memory.NextAtmosphereAt = Math.Min(memory.NextAtmosphereAt, now + 10);
        }
    }
    private bool CanSpeak => RunManager.Instance.RunTime - Memory(0).LastSpoke >= 6;
    public void Tick() => Guard(() =>
    {
        var state = RunManager.Instance.DebugOnlyGetState()!;
        var live = _session.World!.Run!; var match = _session.World.World.Matches.Single(m => m.Id == live.MatchId);
        double now = RunManager.Instance.RunTime; var shared = Memory(ulong.MaxValue);
        if (live.Rival is { Steps.Count: > 0 } rival)
        {
            var progress = RivalSimulation.At(rival, now);
            if (CanSpeak || progress.Finished) Broadcast(_session, LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now));
            if (now <= rival.PaceNeutralUntil) LiveCommentary.RebaseGap(shared, state.TotalFloor, progress.Step.Floor, now);
            else if (CanSpeak && !progress.Finished)
                Broadcast(_session, LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,
                    _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed));
        }
        _voices ??= new(_session.World.World, match, shared, live.Opponents);
        _shop ??= new(state);
        foreach (var change in _shop.Read(state))
            _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, Name(change.Player), state.TotalFloor, now, change.CardType);
        if (live.Rival is { Steps.Count: > 0 } route)
            _voices.Rival(state.TotalFloor, state.CurrentActIndex, state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp),
                RivalSimulation.At(route, now), route, now,
                live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp)));
        _voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, state.TotalFloor, now);
        Broadcast(_session, _voices.Poll(now, Memory(0).LastSpoke));
        if (!CanSpeak) return;
        var players = state.Players.Where(p => p.Creature.CurrentHp > 0).ToArray();
        for (int i = 0; i < players.Length; i++)
        {
            var p = players[(_speakerTurn + i) % players.Length]; var memory = Memory(p.NetId);
            var battle = _battles.GetValueOrDefault(p.NetId);
            var observation = new BattleObservation { Floor = state.TotalFloor, Kind = state.CurrentMapPoint?.PointType.ToString() ?? "",
                Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp };
            var line = LiveCommentary.Route(memory, observation, Name(p.NetId), live.Seed + p.NetId, now);
            line ??= LiveCommentary.Atmosphere(memory, new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,
                CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,
                state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,
                battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), live.Seed + p.NetId, now);
            if (line == null) continue;
            if (line.Topic == "opening") line = line with { Text = line.Text.Replace("两位", "两支队伍") };
            Broadcast(_session, line); _speakerTurn = (_speakerTurn + i + 1) % players.Length; break;
        }
    });
    private void Changed() => Guard(() =>
    {
        if (!CombatManager.Instance.IsInProgress) return;
        var state = RunManager.Instance.DebugOnlyGetState()!;
        var entries = CombatManager.Instance.History.Entries.ToList();
        if (_historyCount > entries.Count) _historyCount = 0;
        if (_battles.Count == 0) Initialize(false);
        foreach (var entry in entries.Skip(_historyCount)) foreach (var p in state.Players)
        {
            if (!_battles.TryGetValue(p.NetId, out var b)) continue;
            int turn = p.PlayerCombatState?.TurnNumber ?? 1;
            if (b.Turn != turn) { b.Turn = turn; b.Cards = b.Draws = b.Damage = 0; }
            if (entry is CardPlayFinishedEntry card && card.CardPlay.Card.Owner == p) { b.Cards++; b.LastCard = GameText.Plain(card.CardPlay.Card.Title); }
            if (entry is CardDrawnEntry draw && draw.Card.Owner == p && !draw.FromHandDraw) b.Draws++;
            if (entry is DamageReceivedEntry damage)
            {
                if (damage.Receiver.IsEnemy && damage.Dealer == p.Creature) b.Damage += damage.Result.UnblockedDamage;
                if (damage.Receiver == p.Creature) b.HpLost += Math.Max(0, damage.Result.UnblockedDamage);
            }
            b.PeakCards = Math.Max(b.PeakCards, b.Cards); b.PeakDraws = Math.Max(b.PeakDraws, b.Draws); b.PeakDamage = Math.Max(b.PeakDamage, b.Damage);
            b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;
            if (p.Creature.CombatState is { } combat)
                LiveVoiceObservation.Observe(_voices, b, combat, p, entry, Name(p.NetId), RunManager.Instance.RunTime);
            if (entry is CardPlayFinishedEntry played && played.CardPlay.Card.Owner == p && !CombatManager.Instance.IsEnding && CanSpeak)
                Broadcast(_session, LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));
        }
        _historyCount = entries.Count;
    });
    private string Name(ulong id) => _session.World!.Members.Single(m => m.SteamId == id).Name;
    private void Won(CombatRoom room) => Guard(() =>
    {
        var state = RunManager.Instance.DebugOnlyGetState()!;
        foreach (var p in state.Players)
        {
            if (!_battles.TryGetValue(p.NetId, out var b)) continue;
            b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;
            if (b.Hp <= 0) { b.CompleteObservation = false; continue; }
            Broadcast(_session, LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));
        }
        _battles.Clear();
    });
    private void Broadcast(CoopCoordinator session, BroadcastLine? line)
    {
        if (line == null) return;
        if (EmitLine(session, line) && line.Role == "commentator")
            _voices?.React(line.Topic, RunManager.Instance.DebugOnlyGetState()?.TotalFloor ?? 0, RunManager.Instance.RunTime);
    }
    public static void Emit(CoopCoordinator session, BroadcastLine? line) => EmitLine(session, line);
    private static bool EmitLine(CoopCoordinator session, BroadcastLine? line)
    {
        if (line == null || session.World?.Run is not { } live) return false;
        double now = RunManager.Instance.RunTime;
        var shared = live.Broadcasts.GetValueOrDefault(0UL);
        if (shared == null) live.Broadcasts[0] = shared = new();
        if (now - shared.LastSpoke < 6 && line.Topic is not ("rival_dead" or "rival_clear")) return false;
        shared.LastSpoke = now;
        var speakers = CommentatorSelection.ForMatch(session.World.World, session.World.World.Matches.Single(m => m.Id == live.MatchId), live.Opponents);
        string speaker = line.SpeakerId.Length > 0 ? line.SpeakerId : speakers.Count == 0 ? "" : speakers[(line.Analyst ? 1 : 0) % speakers.Count].Id;
        live.Speeches.Add(new(Guid.NewGuid().ToString("N"), speaker, line.Text, line.Topic) { Role = line.Role });
        while (live.Speeches.Count > 6) live.Speeches.RemoveAt(0);
        return true;
    }
    public void Dispose()
    {
        CombatManager.Instance.CombatSetUp -= Started; CombatManager.Instance.CombatWon -= Won; CombatManager.Instance.History.Changed -= Changed;
    }
}
