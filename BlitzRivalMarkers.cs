using System.Reflection;
using Godot;
using MegaCrit.Sts2.Core.Map;

namespace NationalSpire;

public sealed record LiveMapRival(string Id, string Name, RivalProgress Progress, int MaxHp, IReadOnlyList<RivalStep> Steps);

/// <summary>复用对手头像与已走路线控件，将快速模式的位置投影到游戏顶部的实际房间节点。</summary>
public sealed class BlitzRivalMarkers : IDisposable
{
    private static readonly Type? PointType = typeof(ActMap).Assembly.GetType("MegaCrit.Sts2.Core.Nodes.CommonUi.NBlitzTopBarMapPoint");
    private static readonly PropertyInfo? Point = PointType?.GetProperty("Point");
    private readonly Dictionary<string, RivalMapOverlay> _overlays = [];
    private Dictionary<MapCoord, Control> _points = [];
    private Node? _parent;
    private ActMap? _map;
    private double _artRetryAt;

    public void Update(CareerData data, Control globalUi, ActMap map, int act, double seconds, IReadOnlyList<LiveMapRival> rivals)
    {
        if (_map != map || !GodotObject.IsInstanceValid(_parent)
            || _points.Values.Any(p => !GodotObject.IsInstanceValid(p) || p.IsQueuedForDeletion()))
        {
            Dispose();
            _parent = globalUi.FindChild("BlitzMapPoints", true, false);
            _map = map;
            if (_parent == null) return;
            _points = _parent.GetChildren().OfType<Control>().Where(c => PointType?.IsInstanceOfType(c) == true)
                .ToDictionary(c => ((MapPoint)Point!.GetValue(c)!).coord);
        }
        if (_points.Count == 0) { _map = null; return; }
        var ordered = _points.OrderBy(p => p.Key.row).ToArray();
        bool refreshArt = seconds >= _artRetryAt;
        if (refreshArt) _artRetryAt = seconds + 3;
        MapCoord Location(LiveMapRival rival) => rival.Progress.Step.Act == act
            ? new(rival.Progress.Step.Col, rival.Progress.Step.Row)
            : rival.Progress.Step.Act < act ? ordered[0].Key : ordered[^1].Key;
        string Detail(LiveMapRival rival) => rival.Name + $" · 第{rival.Progress.Step.Act + 1}幕 · 第{rival.Progress.Step.Floor}层\n生命 {rival.Progress.Hp}/{rival.MaxHp} · "
            + (rival.Progress.Finished ? rival.Progress.Dead ? "已出局" : "已通关" : RivalSimulation.RoomName(rival.Progress.Step.Kind));
        var groups = rivals.GroupBy(r => (Location(r), Side: Math.Sign(r.Progress.Step.Act - act)));
        foreach (var group in groups)
        {
            if (!_points.TryGetValue(group.Key.Item1, out var point)) continue;
            var members = group.ToArray();
            string tooltip = string.Join("\n\n", members.Select(Detail));
            for (int i = 0; i < members.Length; i++)
            {
                var rival = members[i];
                if (!_overlays.TryGetValue(rival.Id, out var overlay) || !GodotObject.IsInstanceValid(overlay))
                {
                    overlay = new RivalMapOverlay { Compact = true, Art = CareerAvatars.ForPerson(data, rival.Id) };
                    _overlays[rival.Id] = overlay; _parent!.AddChild(overlay);
                }
                if (refreshArt && !AvatarAssets.Usable(overlay.Art.Texture)) overlay.RefreshArt(CareerAvatars.ForPerson(data, rival.Id));
                overlay.Show();
                overlay.BadgeOffset = new(-13 + (i - (members.Length - 1) / 2f) * 8, -42);
                Vector2 Position(Control node) => overlay.GetGlobalTransformWithCanvas().AffineInverse()
                    * (node.GetGlobalTransformWithCanvas() * (node.Size * .5f));
                var path = rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))
                    .Select(s => Position(_points[new(s.Col, s.Row)])).ToList();
                var marker = Position(point) + new Vector2(group.Key.Side * 28, 0);
                overlay.UpdateState(path, marker, rival.Name, rival.Progress.Hp, rival.MaxHp, rival.Progress.Dead,
                    tooltip, group.Key.Side == 0 ? "" : $"{rival.Progress.Step.Act + 1}幕");
            }
        }
    }
    public void Hide() { foreach (var overlay in _overlays.Values.Where(GodotObject.IsInstanceValid)) overlay.Hide(); }
    public void Dispose()
    {
        foreach (var overlay in _overlays.Values.Where(GodotObject.IsInstanceValid)) overlay.QueueFree();
        _overlays.Clear(); _points.Clear(); _parent = null; _map = null;
    }
}
