using Godot;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire.Coop;

/// <summary>主机模拟一条队伍路线；个人生命各自变化，客机只显示同一份比赛进度。</summary>
public sealed class CoopLive(CoopCoordinator session)
{
    private LiveRaceHud? _hud;
    private CoopBroadcast? _broadcast;
    private BroadcastUiState _layout = CoopSettings.ReadLayout();
    private readonly HashSet<string> _heard = [];
    private string _attached = "";
    private string _diagnosticState = "";
    private string _diagnosticAttempt = "";
    private int _diagnosticResume = -1;
    private readonly Dictionary<string, RivalMapOverlay> _maps = [];
    public void Close() { if (_hud != null && GodotObject.IsInstanceValid(_hud)) _hud.QueueFree(); _broadcast?.Dispose(); _broadcast = null; _heard.Clear(); foreach (var map in _maps.Values.Where(GodotObject.IsInstanceValid)) map.QueueFree(); _maps.Clear(); _hud = null; _attached = ""; }
    public void Update()
    {
        if (session.World?.Run is not { } live || !RunManager.Instance.IsInProgress || NRun.Instance == null) { Close(); return; }
        var state = RunManager.Instance.DebugOnlyGetState();
        if (state == null || state.Rng.StringSeed != live.Seed || !state.Players.Select(p => p.NetId).Order().SequenceEqual(live.Characters.Keys.Order())) return;
        bool attached = _attached != live.Attempt || _hud == null || !GodotObject.IsInstanceValid(_hud);
        bool planChanged = false;
        if (_attached != live.Attempt || _hud == null || !GodotObject.IsInstanceValid(_hud))
        {
            Close(); _attached = live.Attempt; _hud = new(); NRun.Instance.GlobalUi.AddChild(_hud);
            _hud.Restore(_layout); _hud.LayoutChanged += layout => { _layout = layout; CoopSettings.SaveLayout(layout); };
            _hud.AddAction("暂停并离开房间", ConfirmStop);
            if (session.Host) _broadcast = new(session);
        }
        if (session.Host)
        {
            if (state.Map is NullActMap) return;
            live.Clock = RunManager.Instance.RunTime; live.Floor = state.TotalFloor; live.Act = state.CurrentActIndex;
            live.Players = state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList();
            var match = session.World.World.Matches.Single(m => m.Id == live.MatchId);
            if (live.Rival == null)
            {
                var maps = new List<RouteNode>();
                for (int i = 0; i < state.Acts.Count; i++)
                {
                    bool second = match.RequiredAscension >= 10 && i == state.Acts.Count - 1;
                    ActMap map = i == state.CurrentActIndex ? state.Map : new StandardActMap(GameCompatibility.MapRng(state.Rng, i + 1), state.Acts[i], true, false, second);
                    var nodes = map.GetAllMapPoints().Append(map.StartingMapPoint).Append(map.BossMapPoint);
                    if (second && map.SecondBossMapPoint != null) nodes = nodes.Append(map.SecondBossMapPoint);
                    maps.AddRange(nodes.DistinctBy(p => p.coord).Select(p => new RouteNode(i, p.coord.row, p.coord.col, p.PointType.ToString(), p.Children.Where(c => second || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())));
                }
                var leader = CareerEngine.Person(session.World.World, live.Opponents[0])!;
                var route = RivalSimulation.Route(maps, leader, match.Seed);
                var coordinates = route.Select(n => (n.Act, n.Row, n.Col)).ToHashSet();
                var shared = route.Select(n => n with { Children = n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList() }).ToList();
                live.Rival = RivalSimulation.Create(match, leader, shared, 80);
                foreach (string id in live.Opponents)
                {
                    var npc = CareerEngine.Person(session.World.World, id)!;
                    int hp = GameBridge.Characters().FirstOrDefault(c => c.Title.GetFormattedText() == npc.Character)?.StartingHp ?? 75;
                    live.RivalMembers[id] = RivalSimulation.Create(match, npc, shared, hp);
                }
                live.Commentary.Add("双方队伍已经出发，本场按整队通关结果判定胜负。");
                Diagnostics.RecordMatch(session.World, "route-created", includePlan: true);
            }
            if (CareerEngine.Person(session.World.World, live.Opponents[0]) is { } teamLeader)
                RivalSimulation.UpgradeHealthPlan(live.Rival, match, teamLeader, live.Clock);
            foreach (var pair in live.RivalMembers)
                if (CareerEngine.Person(session.World.World, pair.Key) is { } npc)
                    RivalSimulation.UpgradeHealthPlan(pair.Value, match, npc, live.Clock);
            planChanged = RivalSimulation.TryAdjustPace(live.Rival, live.Clock, live.Act, live.Floor);
            foreach (var member in live.RivalMembers.Values)
                for (int i = 0; i < Math.Min(member.Steps.Count, live.Rival.Steps.Count); i++)
                { member.Steps[i].Start = live.Rival.Steps[i].Start; member.Steps[i].End = live.Rival.Steps[i].End;
                    member.Steps[i].HpCheckpointSeconds = live.Rival.Steps[i].HpCheckpointSeconds;
                    member.Steps[i].HpCheckpointFraction = live.Rival.Steps[i].HpCheckpointFraction; }
            _broadcast?.Tick();
            session.PublishLive();
        }
        var lines = new List<string> { "共同生涯  /  团队赛", $"我方第 {live.Act + 1} 幕 · {live.Floor} 层 · {MatchRules.Time(live.Clock)}" };
        foreach (var player in live.Players) lines.Add(session.World.Members.First(m => m.SteamId == player.Id).Name + $"  {player.Hp}/{player.MaxHp}" + (player.Dead ? " · 暂时倒下" : ""));
        if (live.Rival is { Steps.Count: > 0 })
        {
            var progress = RivalSimulation.At(live.Rival, live.Clock);
            lines.Add($"\n对方第 {progress.Step.Act + 1} 幕 · {progress.Step.Floor} 层" + (progress.Finished ? progress.Dead ? " · 全队止步" : " · 已通关" : " · " + RivalSimulation.RoomName(progress.Step.Kind)));
            foreach (var rival in live.RivalMembers)
                lines.Add(CareerEngine.DisplayName(session.World.World, rival.Key) + $"  {RivalSimulation.At(rival.Value, live.Clock).Hp}/{rival.Value.MaxHp}");
        }

        if (!session.Full) lines.Add("队员连接中断，正在暂停比赛");
        _hud!.SetRace("团队赛事转播", string.Join("\n", lines), live.Players.Sum(p => p.Hp), live.Players.Sum(p => p.MaxHp), false, live.Clock);
        var rivalProgress = live.Rival is { Steps.Count: > 0 } ? RivalSimulation.At(live.Rival, live.Clock) : null;
        var localPlayers = state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList();
        string diagnosticState = $"{live.Attempt}:{live.ResumeCount}:{live.Phase}:{state.TotalFloor}:{live.Floor}:{state.CurrentRoom?.RoomType}:{rivalProgress?.Step.Floor}:{rivalProgress?.Finished}:{rivalProgress?.Dead}:"
            + string.Join(',', localPlayers.Select(p => p.Dead)) + ":" + string.Join(',', live.Players.Select(p => p.Dead));
        if (attached || planChanged || diagnosticState != _diagnosticState)
        {
            string stage = _diagnosticAttempt != live.Attempt ? "live-attached" : _diagnosticResume != live.ResumeCount ? "resumed" : planChanged ? "pace-adjusted" : "progress";
            Diagnostics.RecordMatch(session.World, stage, new
            {
                session.Host, displayed = lines, localClock = RunManager.Instance.RunTime, localFloor = state.TotalFloor,
                localAct = state.CurrentActIndex, row = state.CurrentMapPoint?.coord.row, col = state.CurrentMapPoint?.coord.col,
                room = state.CurrentRoom?.RoomType.ToString(), localPlayers
            }, includePlan: attached || planChanged || _diagnosticResume != live.ResumeCount);
            _diagnosticState = diagnosticState; _diagnosticAttempt = live.Attempt; _diagnosticResume = live.ResumeCount;
        }
        foreach (var speech in live.Speeches.Where(s => !_heard.Contains(s.Id)))
        {
            _heard.Add(speech.Id); string id = speech.Speaker;
            var speechMatch = session.World.World.Matches.Single(m => m.Id == live.MatchId);
            if (speech.Role != "thought" && CommentatorSelection.Participants(session.World.World, speechMatch, live.Opponents).Contains(id)) continue;
            _hud.Say(LiveVoices.Byline(id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场", speech.Role), speech.Text, speech.Topic,
                id.Length > 0 ? CareerAvatars.ForPerson(session.World.World, id) : null,
                id.Length > 0 ? AvatarHonors.ForPerson(session.World.World, id) : null);
        }
        _heard.IntersectWith(live.Speeches.Select(s => s.Id));
        UpdateMap(live, state.CurrentActIndex);
    }
    private void ConfirmStop()
    {
        if (NRun.Instance == null) return;
        var cover = new ColorRect { Color = new(0, 0, 0, .78f), Theme = CareerVisuals.CreateTheme() };
        NRun.Instance.GlobalUi.AddChild(cover); cover.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var center = new CenterContainer(); cover.AddChild(center); center.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var panel = new PanelContainer { CustomMinimumSize = new(580, 180) }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142431", "69dfd3", 12, 26)); center.AddChild(panel);
        var body = new VBoxContainer(); panel.AddChild(body);
        body.AddChild(new Label { Text = "暂停并离开房间？\n保留最近一次安全检查点，当前战斗可能需要重打。\n其他队员会返回生涯等待，单人模式可以正常使用。" });
        var buttons = new HBoxContainer(); body.AddChild(buttons);
        var yes = new Button { Text = "确认离开", CustomMinimumSize = new(180, 48) }; buttons.AddChild(yes);
        var no = new Button { Text = "继续比赛", CustomMinimumSize = new(180, 48) }; buttons.AddChild(no);
        no.Pressed += () => cover.QueueFree();
        yes.Pressed += async () =>
        {
            yes.Disabled = no.Disabled = true;
            try { await CoopRuntime.Current!.Pause(); CoopRuntime.Current.Disconnect(); }
            catch (Exception e) { Diagnostics.Error("coop.stop", e); }
            finally { if (GodotObject.IsInstanceValid(cover)) cover.QueueFree(); }
        };
    }
    private void UpdateMap(CoopRun live, int act)
    {
        if (live.Rival == null || NMapScreen.Instance is not { IsOpen: true } screen)
        { foreach (var map in _maps.Values.Where(GodotObject.IsInstanceValid)) map.Hide(); return; }
        var points = LiveCompatibility.MapPoints(screen); if (points.Count == 0) return;
        var parent = points.Values.First().GetParent();
        for (int i = 0; i < live.Opponents.Count; i++)
        {
            string id = live.Opponents[i];
            if (!live.RivalMembers.TryGetValue(id, out var member)) continue;
            if (_maps.TryGetValue(id, out var old) && GodotObject.IsInstanceValid(old) && old.GetParent() != parent)
            { old.QueueFree(); _maps.Remove(id); }
            if (!_maps.TryGetValue(id, out var overlay) || !GodotObject.IsInstanceValid(overlay))
            {
                overlay = new RivalMapOverlay { Art = CareerAvatars.ForPerson(session.World!.World, id), Identity = AvatarHonors.ForPerson(session.World.World, id),
                    BadgeOffset = new(25 + i / 2 * 240, -48 + i % 2 * 78) };
                _maps[id] = overlay; parent.AddChild(overlay);
            }
            overlay.Show();
            Vector2 Position(NMapPoint point) => overlay.GetGlobalTransformWithCanvas().AffineInverse() * (point.GetGlobalTransformWithCanvas() * (point is NNormalMapPoint ? Vector2.Zero : point.Size * .5f));
            var progress = RivalSimulation.At(member, live.Clock);
            var path = i == 0 ? live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select(s => Position(points[new(s.Col, s.Row)])).ToList() : new List<Vector2>();
            Vector2? at = progress.Step.Act == act && points.TryGetValue(new(progress.Step.Col, progress.Step.Row), out var point) ? Position(point) : null;
            overlay.UpdateState(path, at, CareerEngine.DisplayName(session.World!.World, id), progress.Hp, member.MaxHp, progress.Dead);
        }
    }
}
