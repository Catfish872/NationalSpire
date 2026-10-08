using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Combat.History;
using MegaCrit.Sts2.Core.Combat.History.Entries;
using MegaCrit.Sts2.Core.Context;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>只在已绑定的单人生涯比赛中订阅原生事件；普通对局不建立播报器。</summary>
public partial class LiveRunBridge : Node
{
    public static LiveRunBridge? Current { get; private set; }
    internal object DiagnosticSnapshot() => new { match = _match.Id, seed = _run.Rng.StringSeed,
        act = _run.CurrentActIndex, floor = _run.TotalFloor, hp = _player.Creature.CurrentHp,
        battle = _battle, faulted = _faulted, commentaryFaulted = _commentaryFaulted, ended = _ended,
        healthPlanVersion = _match.Live?.HealthPlanVersion,
        mapCompatible = _mapCompatible, mapPoints = _mapPoints?.Count, mapRetryAt = _mapRetryAt,
        hudVisible = IsInstanceValid(_hud) && _hud.Visible, overlayVisible = IsInstanceValid(_mapOverlay) && _mapOverlay!.Visible,
        // 与其他两个节点一致：Godot 对象可能已被释放但引用仍非 null，必须走 IsInstanceValid。
        danmaku = IsInstanceValid(_danmaku) ? new { enabled = _danmaku!.Options.Enabled, lanes = _danmaku.LaneCount,
            active = _danmaku.ActiveCount, pending = _danmaku.PendingCount,
            spawned = _danmaku.SpawnedTotal, dropped = _danmaku.DroppedTotal,
            droppedLane = _danmaku.DroppedLaneTotal, droppedWide = _danmaku.DroppedWideTotal, starved = _danmaku.StarvedRounds,
            library = SituationDanmaku.Count, librarySource = SituationDanmaku.Source, tier = SituationDanmaku.Tier(_data) } : null };
    private RunState _run = null!;
    private CareerData _data = null!;
    private CareerMatch _match = null!;
    private CareerPerson _rival = null!;
    private Player _player = null!;
    private BattleObservation? _battle;
    private LiveRaceHud _hud = null!;
    private LiveDanmakuLayer? _danmaku;
    /// <summary>本场开始时重置总库的单场统计（片哥配额）。</summary>
    private void ResetDanmakuCounters() => SituationDanmaku.ResetMatchCounters();
    private RivalMapOverlay? _mapOverlay;
    private double _tick;
    private double _mapCheck;
    private bool _faulted, _commentaryFaulted, _ended;
    private double _mapRetryAt, _artRetryAt;
    private int _pendingLoss, _lossFloor = -1;
    private int _potionFloor = -1, _observedPotions, _discardedPotions;
    private int _historyCount;
    private LiveVoices? _voices;
    private LiveShopObserver _shop = null!;
    private Dictionary<MapCoord, NMapPoint>? _mapPoints;
    private NMapScreen? _mapScreen;
    private ActMap? _lastMap;
    private bool _mapCompatible = true;
    public static void Attach(NRun node, RunState run)
    {
        if (node.GetChildren().OfType<LiveRunBridge>().Any()) return;
        var data = CareerStore.Data;
        if (data.PendingMatchId == null) return;
        var match = CareerRunBinding.Find(data, run.Rng.StringSeed, run.Players.FirstOrDefault()?.Character.Id.ToString() ?? "",
            run.AscensionLevel, run.Players.Count, run.GameMode == GameMode.Standard);
        if (match == null)
        {
            Diagnostics.Record("live.binding_skipped", new { data.PendingMatchId, runSeed = run.Rng.StringSeed,
                expectedSeed = data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)?.Seed,
                run.AscensionLevel, players = run.Players.Count, mode = run.GameMode.ToString(),
                character = run.Players.FirstOrDefault()?.Character.Id.ToString(), data.SelectedCharacter, data.SelectedAscension });
            return;
        }
        if (CareerEngine.Person(data, match.OpponentId) is not { } rival) return;
        var player = LocalContext.GetMe(run);
        if (player == null) return;
        var bridge = new LiveRunBridge { _run = run, _data = data, _match = match, _rival = rival, _player = player };
        node.AddChild(bridge);
    }
    public override void _Ready()
    {
        Current = this;
        Diagnostics.Record("live.attached", new { match = _match.Id, seed = _run.Rng.StringSeed, act = _run.CurrentActIndex, floor = _run.TotalFloor });
        _hud = new LiveRaceHud(); ((NRun)GetParent()).GlobalUi.AddChild(_hud);
        _hud.Restore(_data.BroadcastUi);
        _hud.LayoutChanged += layout => { _data.BroadcastUi = layout; CareerStore.Save(_data); };
        // 弹幕层与转播面板同级，只做显示；配置随生涯存档保存，局内即时生效。
        if (_data.BroadcastUi.Danmaku.Normalized().Enabled)
        {
            _danmaku = new LiveDanmakuLayer(); ((NRun)GetParent()).GlobalUi.AddChild(_danmaku);
            _danmaku.Apply(_data.BroadcastUi.Danmaku);
            // 队列空了时由这里补内容，用来凑够「最低同时生成数量」。
            _danmaku.TopUp = TopUpDanmaku;
            ResetDanmakuCounters();
            GD.Print($"[NationalSpire] 弹幕层就绪：词条 {SituationDanmaku.Count} 条（{SituationDanmaku.Source}），" +
                $"当前知名度 {SituationDanmaku.TierName(SituationDanmaku.Tier(_data))}（T{SituationDanmaku.Tier(_data)}），" +
                $"粉丝 {_data.Fans}，荣誉 {_data.Esports.Honors.Count} 项");
        }
        CombatManager.Instance.CombatSetUp += OnCombat;
        CombatManager.Instance.CombatWon += OnWon;
        CombatManager.Instance.History.Changed += OnHistoryChanged;
        _player.Creature.CurrentHpChanged += HpChanged;
        // 中途安装或读档时，从当前战斗开始统计，既有赛程与对手计时继续保留。
        if (_player.Creature.CombatState is { } combat && CombatManager.Instance.IsInProgress) { OnCombat(combat); _battle!.CompleteObservation = false; }
        _historyCount = CombatManager.Instance.History.Entries.Count();
        _shop = new(_run);
        _potionFloor = _run.TotalFloor;
        _observedPotions = _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId).PotionUsed.Count ?? 0;
        _discardedPotions = _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId).PotionDiscarded.Count ?? 0;
    }
    public override void _ExitTree()
    {
        CombatManager.Instance.CombatSetUp -= OnCombat;
        CombatManager.Instance.CombatWon -= OnWon;
        CombatManager.Instance.History.Changed -= OnHistoryChanged;
        _player.Creature.CurrentHpChanged -= HpChanged;
        if (Current == this) Current = null;
        if (IsInstanceValid(_hud)) _hud.QueueFree();
        if (IsInstanceValid(_danmaku)) _danmaku!.QueueFree();
        if (IsInstanceValid(_mapOverlay)) _mapOverlay!.QueueFree();
    }
    internal static void Guard(Action action, bool commentaryOnly = false)
    {
        try { action(); }
        catch (Exception e)
        {
            Diagnostics.Error(commentaryOnly ? "live.commentary" : "live.update", e);
            GD.PushWarning("[NationalSpire] 局内播报暂停：" + e.Message);
            if (Current is { } current)
            {
                if (commentaryOnly) current._commentaryFaulted = true;
                else { current._faulted = true; if (IsInstanceValid(current._hud)) current._hud.Hide(); }
            }
        }
    }
    public override void _Process(double delta)
    {
        if (_ended) return;
        if (_faulted || !CareerStore.IsCurrent(_data) || _data.PendingMatchId != _match.Id)
        { _hud.Hide(); _danmaku?.Hide(); if (IsInstanceValid(_mapOverlay)) _mapOverlay!.Hide(); return; }
        _tick += delta;
        _mapCheck += delta;
        // 词库文件被改动后自动重载，方便直接改 situation/lib-*.json 试词；弹幕层不存在时不做无谓探测。
        if (_danmaku != null) SituationDanmaku.Refresh();
        if (_tick < .2) return;
        _tick = 0;
        Guard(UpdateRace);
    }

    /// <summary>
    /// 弹幕层凑不够「最低同时生成数量」时向这里要一条内容。
    /// 直接走总库：片哥、社区库、通用噪音与静态分库按内置比例抽取，不再有单独的广告/噪音开关。
    /// </summary>
    private string? TopUpDanmaku() => SituationDanmaku.PickAnyFill(Facts(new BroadcastLine("mock", "", false)), _data);
    private static List<RouteNode> CopyMap(ActMap map, int act, bool secondBoss)
    {
        var all = map.GetAllMapPoints().Append(map.StartingMapPoint).Append(map.BossMapPoint);
        if (secondBoss && map.SecondBossMapPoint != null) all = all.Append(map.SecondBossMapPoint);
        return all.DistinctBy(p => p.coord).Select(p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),
            p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())).ToList();
    }
    private void EnsurePlan()
    {
        if (_match.Live != null) { _match.Live.Commentary.SharedPhrases = _data.BroadcastHistory; return; }
        if (_run.Map is NullActMap) return;
        MatchRules.PrepareOpponent(_data, _match);
        var maps = new List<RouteNode>();
        for (int i = 0; i < _run.Acts.Count; i++)
        {
            bool second = _match.RequiredAscension >= 10 && i == _run.Acts.Count - 1;
            ActMap map = i == _run.CurrentActIndex ? _run.Map : new StandardActMap(GameCompatibility.MapRng(_run.Rng, i + 1), _run.Acts[i], false, false, second);
            maps.AddRange(CopyMap(map, i, second));
        }
        var character = GameBridge.Characters().FirstOrDefault(c => c.Title.GetFormattedText() == _rival.Character);
        int hp = character?.StartingHp ?? 75;
        _match.Live = RivalSimulation.Create(_match, _rival, maps, hp);
        _match.Live.Commentary.SharedPhrases = _data.BroadcastHistory;
        CareerStore.Save(_data);
    }
    private void UpdateRace()
    {
        EnsurePlan();
        if (_match.Live is not { Steps.Count: > 0 } live) return;
        _voices ??= new(_data, _match, live.Commentary, [_rival.Id]);
        double seconds = RunManager.Instance.RunTime;
        if (RivalSimulation.UpgradeHealthPlan(live, _match, _rival, seconds)) CareerStore.Save(_data);
        if (RivalSimulation.TryAdjustPace(live, seconds, _run.CurrentActIndex, _run.TotalFloor))
        {
            Diagnostics.Record("live.pace_adjusted", new { match = _match.Id, seconds, playerAct = _run.CurrentActIndex,
                playerFloor = _run.TotalFloor, adjustedActs = live.PaceAdjustedActs, finish = live.Steps[^1].End });
            CareerStore.Save(_data);
        }
        var progress = RivalSimulation.At(live, seconds);
        if (!ReferenceEquals(_lastMap, _run.Map))
        {
            _lastMap = _run.Map; _mapPoints = null;
            CalibrateMap(live);
        }
        // 部分事件原地修改地图对象；地图打开时低频复核，避免显示失效路线。
        if (_mapCheck >= 1 && NMapScreen.Instance?.IsOpen == true)
        { _mapCheck = 0; CalibrateMap(live); }
        if (_run.TotalFloor > live.Commentary.RouteFloor)
        {
            var observation = new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentMapPoint?.PointType.ToString() ?? "", Hp = _player.Creature.CurrentHp, MaxHp = _player.Creature.MaxHp };
            Emit(LiveCommentary.Route(live.Commentary, observation, CareerEngine.Name(_data), _match.Seed, seconds));
            CareerStore.Save(_data);
        }
        Emit(LiveCommentary.Rival(live, progress, CareerEngine.Name(_data), _rival.PublicName, _match.Seed, seconds));
        if (!_commentaryFaulted)
        {
            ObservePotions(live.Commentary, seconds);
            if (_pendingLoss > 0)
            {
                if (_lossFloor != _run.TotalFloor || _player.Creature.CurrentHp <= 0) _pendingLoss = 0;
                else
                {
                    var injury = LiveCommentary.PlayerLoss(live.Commentary, _run.TotalFloor, _pendingLoss, _player.Creature.CurrentHp,
                        _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds);
                    Emit(injury); if (injury != null) _pendingLoss = 0;
                }
            }
            if (_run.CurrentMapPoint?.PointType.ToString() == "Unknown")
                Emit(LiveCommentary.UnknownRoom(live.Commentary, _run.TotalFloor, _run.CurrentRoom?.RoomType.ToString() ?? "",
                    _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, CareerEngine.Name(_data), _match.Seed, seconds));
        }
        if (seconds <= live.PaceNeutralUntil)
            LiveCommentary.RebaseGap(live.Commentary, _run.TotalFloor, progress.Step.Floor, seconds);
        else if (!progress.Finished && !_commentaryFaulted)
            Emit(LiveCommentary.Gap(live.Commentary, _run.TotalFloor, progress.Step.Floor, _run.CurrentActIndex, progress.Step.Act,
                CareerEngine.Name(_data), _rival.PublicName, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _match.Seed));
        if (!_commentaryFaulted)
        {
            foreach (var change in _shop.Read(_run))
                _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, CareerEngine.Name(_data), _run.TotalFloor, seconds, change.CardType);
            _voices.Rival(_run.TotalFloor, _run.CurrentActIndex, _player.Creature.CurrentHp, _player.Creature.MaxHp, progress, live, seconds);
            _voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, _run.TotalFloor, seconds);
            Emit(_voices.Poll(seconds, live.Commentary.LastSpoke));
        }
        if (!_commentaryFaulted && !progress.Finished)
            Emit(LiveCommentary.Atmosphere(live.Commentary, new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,
                _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",
                _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), _match.Seed, seconds));
        string status = progress.Finished ? progress.Dead ? $"止步第 {progress.Step.Floor} 层" : "已通关 · " + MatchRules.Time(_match.OpponentSeconds)
            : $"第 {progress.Step.Act + 1} 幕 · 第 {progress.Step.Floor} 层 · {RivalSimulation.RoomName(progress.Step.Kind)}";
        if (!_mapCompatible && progress.Step.Act == _run.CurrentActIndex) status += " · 独立路线";
        _hud.SetRace(_rival.PublicName, status, progress.Hp, live.MaxHp, progress.Step.Act != _run.CurrentActIndex, seconds);
        if (seconds >= _mapRetryAt)
            try { UpdateMap(live, progress, seconds); }
            catch (Exception e) { Diagnostics.Error("live.map", e); _mapRetryAt = seconds + 5; _mapPoints = null; if (IsInstanceValid(_mapOverlay)) _mapOverlay!.Hide(); GD.PushWarning("[NationalSpire] 地图标记等待重建：" + e.Message); }
    }
    private void ObservePotions(BroadcastMemory memory, double seconds)
    {
        if (_potionFloor != _run.TotalFloor) { _potionFloor = _run.TotalFloor; _observedPotions = _discardedPotions = 0; }
        var roomHistory = _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId);
        var used = roomHistory?.PotionUsed;
        if (used == null) return;
        // 原生房间历史同时记录战斗内外的用药，重载时从已有记录末尾继续观察。
        while (_observedPotions < used.Count)
        {
            var model = ModelDb.GetByIdOrNull<PotionModel>(used[_observedPotions++]);
            if (model == null) continue;
            Emit(LiveCommentary.Potion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,
                _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds));
        }
        while (_discardedPotions < roomHistory!.PotionDiscarded.Count)
        {
            var model = ModelDb.GetByIdOrNull<PotionModel>(roomHistory.PotionDiscarded[_discardedPotions++]);
            if (model == null) continue;
            Emit(LiveCommentary.DiscardPotion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,
                _player.Creature.MaxHp, _player.Potions.Count(), CareerEngine.Name(_data), _match.Seed, seconds));
        }
    }
    public void EnergyGained(PlayerCombatState state, int gain)
    {
        if (_ended || _faulted || _commentaryFaulted || _match.Live == null || !ReferenceEquals(state, _player.PlayerCombatState)
            || !CombatManager.Instance.IsInProgress || CombatManager.Instance.IsEnding) return;
        Emit(LiveCommentary.Energy(_match.Live.Commentary, _run.TotalFloor, state.TurnNumber, gain, state.Energy,
            CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));
    }
    public void RewardSkipped(CardReward reward)
    {
        if (_ended || _faulted || _commentaryFaulted || _match.Live == null || reward.Player != _player || !reward.IsPopulated) return;
        Emit(LiveCommentary.SkipReward(_match.Live.Commentary, _run.TotalFloor, reward.Cards.Count(), _player.Deck.Cards.Count,
            CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));
    }
    public void RunEnded(bool victory)
    {
        if (_ended || _faulted || _match.Live == null || !CareerStore.IsCurrent(_data) || _data.PendingMatchId != _match.Id) return;
        _ended = true;
        if (!victory) return;
        double seconds = RunManager.Instance.RunTime;
        bool winner = !_match.OpponentWon || _match.OpponentSeconds is > 0
            && MatchRules.Compare(new(true, _run.TotalFloor, seconds), new(true, _match.OpponentFloor, _match.OpponentSeconds.Value)) > 0;
        Emit(LiveCommentary.PlayerVictory(_match.Live.Commentary, winner, seconds, _player.Creature.CurrentHp,
            _player.Creature.MaxHp, CareerEngine.Name(_data), _rival.PublicName, _match.Seed));
    }
    private void CalibrateMap(LiveMatchState live)
    {
        // 真实地图校验连线；个人事件或其他模组改图后，以独立赛道状态显示对手，保持已发布的时间和血量连续。
        var steps = live.Steps.Where(s => s.Act == _run.CurrentActIndex).ToList();
        _mapCompatible = steps.All(s => _run.Map.GetPoint(new MapCoord(s.Col, s.Row)) is { } p && p.PointType.ToString() == s.Kind);
        for (int i = 1; _mapCompatible && i < steps.Count; i++)
        {
            var parent = _run.Map.GetPoint(new MapCoord(steps[i - 1].Col, steps[i - 1].Row));
            _mapCompatible = parent != null && parent.Children.Any(c => c.coord == new MapCoord(steps[i].Col, steps[i].Row));
        }
    }

    private void UpdateMap(LiveMatchState live, RivalProgress progress, double seconds)
    {
        var screen = NMapScreen.Instance;
        if (screen == null || !screen.IsOpen || !_mapCompatible) { if (IsInstanceValid(_mapOverlay)) _mapOverlay!.Hide(); return; }
        if (_mapScreen != screen || _mapPoints == null || _mapPoints.Count == 0 || _mapPoints.Values.Any(p => !IsInstanceValid(p) || p.IsQueuedForDeletion()))
        { _mapScreen = screen; _mapPoints = LiveCompatibility.MapPoints(screen); }
        var points = _mapPoints;
        if (points.Count == 0) return;
        var mapParent = points.Values.First().GetParent();
        if (IsInstanceValid(_mapOverlay) && _mapOverlay!.GetParent() != mapParent)
        { _mapOverlay.QueueFree(); _mapOverlay = null; }
        if (!IsInstanceValid(_mapOverlay) || _mapOverlay!.IsQueuedForDeletion())
        {
            _mapOverlay = new RivalMapOverlay { Art = CareerAvatars.ForPerson(_data, _rival.Id), Identity = AvatarHonors.ForPerson(_data, _rival.Id) };
            mapParent.AddChild(_mapOverlay);
        }
        _mapOverlay!.Show();
        if (!AvatarAssets.Usable(_mapOverlay.Art.Texture) && seconds >= _artRetryAt)
        { _artRetryAt = seconds + 3; _mapOverlay.RefreshArt(CareerAvatars.ForPerson(_data, _rival.Id)); }
        var path = new List<Vector2>();
        foreach (var step in live.Steps.Where(s => s.Act == _run.CurrentActIndex && s.Start <= seconds))
        {
            if (points.TryGetValue(new MapCoord(step.Col, step.Row), out var point)) path.Add(MapPosition(point));
        }
        Vector2? marker = null;
        if (progress.Step.Act == _run.CurrentActIndex && points.TryGetValue(new MapCoord(progress.Step.Col, progress.Step.Row), out var at)) marker = MapPosition(at);
        _mapOverlay.UpdateState(path, marker, _rival.PublicName, progress.Hp, live.MaxHp, progress.Dead);
    }
    // 普通地图点以图标中心为原点，先古之民与首领使用控件中心，沿用原生连线定位。
    private Vector2 MapPosition(NMapPoint point) => _mapOverlay!.GetGlobalTransformWithCanvas().AffineInverse()
        * (point.GetGlobalTransformWithCanvas() * (point is NNormalMapPoint ? Vector2.Zero : point.Size * .5f));
    private void OnWon(CombatRoom room) { if (!_commentaryFaulted) Guard(FinishCombat, true); }
    private void OnHistoryChanged()
    {
        if (_commentaryFaulted) return;
        Guard(() =>
        {
            var entries = CombatManager.Instance.History.Entries;
            var list = entries as IReadOnlyList<CombatHistoryEntry> ?? entries.ToList();
            if (list.Count < _historyCount) _historyCount = 0;
            if (_player.Creature.CombatState is { } state)
                for (int i = _historyCount; i < list.Count; i++) History(state, list[i]);
            _historyCount = list.Count;
        }, true);
    }
    private void OnCombat(ICombatState state)
    {
        if (!ReferenceEquals(state.RunState, _run)) return;
        _battle = new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" };
    }
    private void HpChanged(int before, int after)
    {
        if (_battle == null || !CombatManager.Instance.IsInProgress || _battle.Floor != _run.TotalFloor) return;
        if (!LiveCommentary.IsCombatLoss(before, after, _player.Creature.MaxHp, _battle.Kind)) return;
        _battle.HpLost += before - after;
        if (_lossFloor != _run.TotalFloor) { _lossFloor = _run.TotalFloor; _pendingLoss = 0; }
        _pendingLoss += Math.Max(0, before - after);
    }
    public void History(ICombatState state, CombatHistoryEntry entry)
    {
        if (_faulted || _commentaryFaulted || _match.Live == null || !ReferenceEquals(state.RunState, _run) || !CombatManager.Instance.IsInProgress) return;
        _battle ??= new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" };
        int turn = _player.PlayerCombatState?.TurnNumber ?? state.RoundNumber;
        if (turn != _battle.Turn) { _battle.Turn = turn; _battle.Cards = _battle.Draws = _battle.Damage = 0; }
        if (entry is CardPlayFinishedEntry card && card.CardPlay.Card.Owner == _player) { _battle.Cards++; _battle.LastCard = GameText.Plain(card.CardPlay.Card.Title); }
        if (entry is CardDrawnEntry draw && draw.Card.Owner == _player && !draw.FromHandDraw) _battle.Draws++;
        if (entry is DamageReceivedEntry damage && damage.Receiver.IsEnemy && damage.Dealer?.IsEnemy != true) _battle.Damage += damage.Result.UnblockedDamage;
        _battle.PeakCards = Math.Max(_battle.PeakCards, _battle.Cards); _battle.PeakDamage = Math.Max(_battle.PeakDamage, _battle.Damage); _battle.PeakDraws = Math.Max(_battle.PeakDraws, _battle.Draws);
        _battle.Hp = _player.Creature.CurrentHp; _battle.MaxHp = _player.Creature.MaxHp;
        LiveVoiceObservation.Observe(_voices, _battle, state, _player, entry, CareerEngine.Name(_data), RunManager.Instance.RunTime);
        if (entry is CardPlayFinishedEntry && !CombatManager.Instance.IsEnding)
            Emit(LiveCommentary.ObserveTurn(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));
    }
    public void FinishCombat()
    {
        if (_faulted || _battle == null || _match.Live == null) return;
        _battle.Hp = _player.Creature.CurrentHp; _battle.MaxHp = _player.Creature.MaxHp;
        _battle.Turn = Math.Max(_battle.Turn, _player.PlayerCombatState?.TurnNumber ?? 1);
        Emit(LiveCommentary.Finish(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));
        _battle = null; _pendingLoss = 0; CareerStore.Save(_data);
    }
    private void Emit(BroadcastLine? line)
    {
        if (line == null || _commentaryFaulted) return;
        var speakers = CommentatorSelection.ForMatch(_data, _match);
        var person = line.SpeakerId.Length > 0 ? CareerEngine.Person(_data, line.SpeakerId)
            : speakers.Count > 0 ? speakers[(line.Analyst ? 1 : 0) % speakers.Count] : null;
        if (person != null && line.Role != "thought" && CommentatorSelection.Participants(_data, _match).Contains(person.Id)) return;
        string speaker = person != null ? CareerEngine.DisplayName(_data, person.Id) : line.Analyst ? "分析席" : "现场";
        if (_match.Live is { } live)
        {
            live.Commentary.LastSpoke = RunManager.Instance.RunTime;
            if (line.Role == "commentator") _voices?.React(line.Topic, _run.TotalFloor, RunManager.Instance.RunTime);
        }
        _hud.Say(LiveVoices.Byline(speaker, line.Role), line.Text, line.Topic, person != null ? CareerAvatars.ForPerson(_data, person.Id) : null,
            person != null ? AvatarHonors.ForPerson(_data, person.Id) : null);
        PushDanmaku(line, speaker);
    }
    /// <summary>
    /// 把一条局内发言转成弹幕。解说（含现场与分析席）与观众分属两个通道，可分别关闭。
    /// 弹幕文本优先取自局面弹幕库（按知名度分档的串子词条），词库没有覆盖这个话题时才回退到
    /// 观众原话——这样弹幕不会变成解说的复读。弹幕层缺失、关闭或去重命中时静默跳过。
    /// </summary>
    private void PushDanmaku(BroadcastLine line, string speaker)
    {
        if (_danmaku is not { } danmaku || !IsInstanceValid(danmaku)) return;
        bool audience = line.Topic.StartsWith("audience_") || line.Topic.StartsWith("reply_");
        bool thought = line.Topic.StartsWith("thought_");
        if (audience ? !danmaku.Options.Crowd : !danmaku.Options.Commentary) return;
        try
        {
            if (SituationDanmaku.EventFor(line.Topic) is { } evt)
            {
                var picked = SituationDanmaku.Pick(_data, evt, danmaku.Options.FanOut, Facts(line));
                // 泛化嘲讽/护主属于观众口吻，走观众配色；其余按解说配色。
                if (picked.Count > 0) { danmaku.Burst(picked, evt is "mock" or "praise" or "target" ? "audience_danmaku" : "danmaku"); return; }
            }
            // 词库未覆盖的话题：观众与内心独白本身就是弹幕口吻，直接发；解说保留署名以便分辨发言者。
            string text = audience || thought ? line.Text : LiveVoices.Byline(speaker, line.Role) + "：" + line.Text;
            danmaku.Spawn(text, line.Analyst, line.Topic);
        }
        catch (Exception e) { Diagnostics.Error("live.danmaku", e); }
    }

    /// <summary>收集替换弹幕词条占位符所需的事实，全部来自当前对局与生涯数据。</summary>
    private DanmakuFacts Facts(BroadcastLine line) => new()
    {
        Player = CareerEngine.Name(_data),
        Rival = _rival.PublicName,
        Country = _data.Esports.Country,
        Club = _data.Esports.ClubId.Length > 0 ? EsportsWorld.ClubName(_data, _data.Esports.ClubId) : "自建俱乐部",
        Gap = Math.Abs(_run.TotalFloor - (_match.Live?.Steps.LastOrDefault()?.Floor ?? _run.TotalFloor)),
        Loss = _pendingLoss,
        Cards = _battle?.Cards ?? 0,
        Draws = _battle?.Draws ?? 0,
        Turn = _battle?.Turn ?? 0,
        Card = _battle?.LastCard ?? "",
        Hp = _player.Creature.CurrentHp,
        Time = TimeSpan.FromSeconds(RunManager.Instance.RunTime).ToString(@"mm\:ss")
    };
}

[HarmonyPatch(typeof(NRun), nameof(NRun._Ready))]
public static class LiveRunReadyPatch
{
    public static bool Prepare() => AccessTools.Method(typeof(NRun), nameof(NRun._Ready), Type.EmptyTypes) != null;
    public static void Postfix(NRun __instance) => LiveRunBridge.Guard(() =>
    {
        if (LiveCompatibility.ReadState(__instance) is { } state) LiveRunBridge.Attach(__instance, state);
        else GD.PushWarning("[NationalSpire] 当前版本未提供局内状态，生涯比赛仍可正常进行。");
    });
}

[HarmonyPatch(typeof(PlayerCombatState), nameof(PlayerCombatState.GainEnergy))]
public static class LiveEnergyPatch
{
    public static bool Prepare() => AccessTools.Method(typeof(PlayerCombatState), nameof(PlayerCombatState.GainEnergy), [typeof(decimal)]) != null;
    public static void Prefix(PlayerCombatState __instance, out int __state) => __state = __instance.Energy;
    public static void Postfix(PlayerCombatState __instance, int __state)
        => LiveRunBridge.Guard(() => LiveRunBridge.Current?.EnergyGained(__instance, Math.Max(0, __instance.Energy - __state)), true);
}

[HarmonyPatch(typeof(CardReward), nameof(CardReward.OnSkipped))]
public static class LiveSkippedRewardPatch
{
    public static bool Prepare() => AccessTools.Method(typeof(CardReward), nameof(CardReward.OnSkipped), Type.EmptyTypes) != null;
    public static void Postfix(CardReward __instance) => LiveRunBridge.Guard(() => LiveRunBridge.Current?.RewardSkipped(__instance), true);
}

[HarmonyPatch(typeof(RunManager), nameof(RunManager.OnEnded))]
public static class LiveVictoryPatch
{
    public static bool Prepare() => AccessTools.Method(typeof(RunManager), nameof(RunManager.OnEnded), [typeof(bool)]) != null;
    public static void Prefix(bool isVictory) => LiveRunBridge.Guard(() => LiveRunBridge.Current?.RunEnded(isVictory), true);
}
