using Godot;

namespace NationalSpire;

/// <summary>在评论卡片的左侧空隙绘制回复关系；容器布局变化时重画。</summary>
public partial class CommunityDiscussionLines : VBoxContainer
{
    private readonly Dictionary<Control, List<Control>> _branches = new();
    private readonly HashSet<Control> _observedCards = [];
    private readonly HashSet<Control> _toggles = [];
    private ArrayMesh? _guideMesh;
    public const int Gutter = 32;
    public const int Indent = 32;
    public const int MaximumIndentDepth = 5;
    public static readonly Color GuideColor = new("9ccfdf8c");
    public const float AnchorY = 32;

    public override void _Ready()
    {
        MouseFilter = MouseFilterEnum.Ignore;
        SortChildren += QueueRedraw;
        Resized += QueueRedraw;
    }

    public void ConnectReply(Control parent, Control child)
    {
        if (!_branches.TryGetValue(parent, out var children))
        {
            _branches[parent] = children = [];
        }
        children.Add(child);
        if (_observedCards.Add(parent)) parent.ItemRectChanged += QueueRedraw;
        if (_observedCards.Add(child)) child.ItemRectChanged += QueueRedraw;
        QueueRedraw();
    }

    public void RegisterToggle(Control card)
    {
        _toggles.Add(card);
        if (_observedCards.Add(card)) card.ItemRectChanged += QueueRedraw;
        QueueRedraw();
    }

    public override void _ExitTree() { _guideMesh?.Dispose(); _guideMesh = null; }

    public override void _Draw()
    {
        var inverse = GetGlobalTransform().AffineInverse();
        var strokes = new List<Rect2>(); var holes = new List<Rect2>();
        const float halfWidth = .9f;
        foreach (var card in _toggles)
        {
            if (!IsInstanceValid(card) || !card.IsVisibleInTree()) continue;
            var center = inverse * card.GlobalPosition + new Vector2(-Gutter / 2f, AnchorY);
            holes.Add(new Rect2(center - new Vector2(11, 11), new Vector2(22, 22)));
        }
        foreach (var (parent, children) in _branches)
        {
            if (!IsInstanceValid(parent) || !parent.IsVisibleInTree()) continue;
            Vector2 from = inverse * parent.GlobalPosition + new Vector2(-Gutter / 2f, AnchorY);
            float bottom = from.Y;
            foreach (var child in children)
            {
                if (!IsInstanceValid(child) || !child.IsVisibleInTree()) continue;
                Vector2 to = inverse * child.GlobalPosition + new Vector2(-3, AnchorY);
                bottom = Math.Max(bottom, to.Y);
                strokes.Add(new Rect2(from.X - halfWidth, to.Y - halfWidth, to.X - from.X + halfWidth, halfWidth * 2));
            }
            if (bottom > from.Y) strokes.Add(new Rect2(from.X - halfWidth, from.Y, halfWidth * 2, bottom - from.Y + halfWidth));
        }
        var rectangles = GuideGeometry(strokes, holes);
        var vertices = new Vector2[rectangles.Count * 4]; var indices = new int[rectangles.Count * 6];
        for (int i = 0; i < rectangles.Count; i++)
        {
            var rectangle = rectangles[i]; int v = i * 4, t = i * 6;
            vertices[v] = rectangle.Position; vertices[v + 1] = new(rectangle.End.X, rectangle.Position.Y);
            vertices[v + 2] = rectangle.End; vertices[v + 3] = new(rectangle.Position.X, rectangle.End.Y);
            indices[t] = v; indices[t + 1] = v + 1; indices[t + 2] = v + 2;
            indices[t + 3] = v; indices[t + 4] = v + 2; indices[t + 5] = v + 3;
        }
        _guideMesh?.Dispose(); _guideMesh = null;
        if (rectangles.Count == 0) return;
        var arrays = new Godot.Collections.Array(); arrays.Resize((int)Mesh.ArrayType.Max);
        arrays[(int)Mesh.ArrayType.Vertex] = vertices; arrays[(int)Mesh.ArrayType.Index] = indices;
        _guideMesh = new ArrayMesh(); _guideMesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, arrays);
        DrawMesh(_guideMesh, null, Transform2D.Identity, GuideColor);
    }

    // 扫描线求笔画并集，再扣除圆圈间隙；输出互不重叠的矩形，以一次网格绘制保留统一透明度。
    internal static List<Rect2> GuideGeometry(IReadOnlyList<Rect2> strokes, IReadOnlyList<Rect2> holes)
    {
        var result = new List<Rect2>();
        if (strokes.Count == 0) return result;
        var all = strokes.Concat(holes).ToArray();
        var xs = all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct().Order().ToArray();
        var columns = xs.Select((x, i) => (x, i)).ToDictionary(p => p.x, p => p.i);
        var events = new SortedDictionary<float, List<(int Begin, int End, int Delta, bool Hole)>>();
        void Add(Rect2 rect, bool hole)
        {
            foreach (var (y, delta) in new[] { (rect.Position.Y, 1), (rect.End.Y, -1) })
            {
                if (!events.TryGetValue(y, out var entries)) events[y] = entries = [];
                entries.Add((columns[rect.Position.X], columns[rect.End.X], delta, hole));
            }
        }
        foreach (var stroke in strokes) Add(stroke, false);
        foreach (var hole in holes) Add(hole, true);
        var paint = new int[xs.Length]; var cut = new int[xs.Length]; float previous = events.First().Key;
        foreach (var (y, entries) in events)
        {
            int start = -1;
            for (int x = 0; x < xs.Length; x++)
            {
                bool filled = x < xs.Length - 1 && paint[x] > 0 && cut[x] == 0;
                if (filled && start < 0) start = x;
                if (!filled && start >= 0)
                { if (y > previous) result.Add(new Rect2(xs[start], previous, xs[x] - xs[start], y - previous)); start = -1; }
            }
            foreach (var entry in entries)
                for (int x = entry.Begin; x < entry.End; x++) (entry.Hole ? cut : paint)[x] += entry.Delta;
            previous = y;
        }
        return result;
    }
}

/// <summary>图形保持轻量，鼠标与键盘使用完整的按钮命中区域。</summary>
public partial class CommunityReplyButton : Button
{
    public bool MainPost { get; init; }

    public override void _Ready()
    {
        Flat = true;
        CustomMinimumSize = MainPost ? new Vector2(40, 36) : new Vector2(34, 30);
        SizeFlagsHorizontal = SizeFlags.ShrinkBegin;
        MouseDefaultCursorShape = CursorShape.PointingHand;
        AddThemeStyleboxOverride("normal", new StyleBoxEmpty());
        AddThemeStyleboxOverride("hover", CareerVisuals.Box("28495a", "28495a", 6, 0));
        AddThemeStyleboxOverride("pressed", CareerVisuals.Box("304f60", "70d4bc", 6, 0));
        AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));
        MouseEntered += QueueRedraw; MouseExited += QueueRedraw;
        FocusEntered += QueueRedraw; FocusExited += QueueRedraw;
        ButtonDown += QueueRedraw; ButtonUp += QueueRedraw;
        Resized += QueueRedraw;
    }

    public override void _Draw()
    {
        float scale = MainPost ? 1.15f : .85f;
        Vector2 center = Size / 2;
        var color = IsHovered() || HasFocus() ? CareerVisuals.Ink : CareerVisuals.Muted;
        Vector2 P(float x, float y) => center + new Vector2(x, y) * scale;
        DrawPolyline([P(-7, -6), P(7, -6), P(9, -4), P(9, 3), P(7, 5), P(-1, 5),
            P(-6, 9), P(-6, 5), P(-7, 5), P(-9, 3), P(-9, -4), P(-7, -6)], color, 1.5f, true);
        DrawLine(P(-4, -1), P(4, -1), color, 1.3f, true);
    }
}

/// <summary>与回复按钮共用紧凑尺寸，以拇指方向和持续高亮表示赞踩选择。</summary>
public partial class CommunityVoteButton : Button
{
    public int Direction { get; init; } = 1;
    public bool MainPost { get; init; }

    public override void _Ready()
    {
        Flat = true; ToggleMode = true;
        CustomMinimumSize = MainPost ? new Vector2(40, 36) : new Vector2(34, 30);
        SizeFlagsVertical = SizeFlags.ShrinkCenter;
        MouseDefaultCursorShape = CursorShape.PointingHand;
        AddThemeStyleboxOverride("normal", new StyleBoxEmpty());
        AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));
    }

    public override void _Notification(int what)
    {
        // Button 自行处理悬停与按下重画；几何和焦点变化直接走节点通知。
        if (what == NotificationResized || what == NotificationFocusEnter || what == NotificationFocusExit) QueueRedraw();
    }

    public override void _Draw()
    {
        float scale = MainPost ? 1.15f : 1;
        Vector2 center = Size / 2;
        var color = ButtonPressed ? (Direction > 0 ? CareerVisuals.Teal : new Color("f09090"))
            : IsHovered() || HasFocus() ? CareerVisuals.Ink : CareerVisuals.Muted;
        Vector2 P(float x, float y) => center + new Vector2(x, y * Direction) * scale;
        Vector2[] hand = [P(-4, -2), P(0, -7), P(0, -10), P(3, -10), P(4, -7), P(3, -3),
            P(8, -3), P(10, -1), P(8, 6), P(6, 8), P(-4, 8), P(-4, -2)];
        Vector2[] cuff = [P(-8, -2), P(-4, -2), P(-4, 8), P(-8, 8), P(-8, -2)];
        if (ButtonPressed) { DrawColoredPolygon(hand[..^1], color); DrawColoredPolygon(cuff[..^1], color); }
        DrawPolyline(hand, color, 1.5f, true);
        DrawPolyline(cuff, color, 1.5f, true);
    }
}

/// <summary>分享使用与回复相同的紧凑命中区域，以三个相连节点表示转发。</summary>
public partial class CommunityShareButton : Button
{
    public bool MainPost { get; init; }

    public override void _Ready()
    {
        Flat = true;
        CustomMinimumSize = MainPost ? new Vector2(40, 36) : new Vector2(34, 30);
        SizeFlagsVertical = SizeFlags.ShrinkCenter;
        MouseDefaultCursorShape = CursorShape.PointingHand;
        AddThemeStyleboxOverride("normal", new StyleBoxEmpty());
        AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));
    }

    public override void _Notification(int what)
    {
        if (what == NotificationResized || what == NotificationFocusEnter || what == NotificationFocusExit) QueueRedraw();
    }

    public override void _Draw()
    {
        float scale = MainPost ? 1.15f : .85f;
        Vector2 center = Size / 2;
        var color = IsHovered() || HasFocus() ? CareerVisuals.Ink : CareerVisuals.Muted;
        Vector2 P(float x, float y) => center + new Vector2(x, y) * scale;
        DrawLine(P(-4, -1.5f), P(4, -6), color, 1.5f, true);
        DrawLine(P(-4, 1.5f), P(4, 6), color, 1.5f, true);
        foreach (var point in new[] { P(-7, 0), P(7, -7), P(7, 7) })
            DrawArc(point, 3 * scale, 0, Mathf.Tau, 24, color, 1.5f, true);
    }
}

/// <summary>警示牌形举报入口，主楼与评论共用图形和按钮反馈。</summary>
public partial class CommunityReportButton : Button
{
    public bool MainPost { get; init; }

    public override void _Ready()
    {
        Flat = true;
        CustomMinimumSize = MainPost ? new Vector2(40, 36) : new Vector2(34, 30);
        SizeFlagsVertical = SizeFlags.ShrinkCenter;
        MouseDefaultCursorShape = CursorShape.PointingHand;
        AddThemeStyleboxOverride("normal", new StyleBoxEmpty());
        AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));
    }

    public override void _Notification(int what)
    {
        if (what == NotificationResized || what == NotificationFocusEnter || what == NotificationFocusExit) QueueRedraw();
    }

    public override void _Draw()
    {
        float scale = MainPost ? 1.15f : .85f;
        Vector2 center = Size / 2;
        var color = Disabled ? CareerVisuals.Muted with { A = .35f }
            : IsHovered() || HasFocus() ? CareerVisuals.Gold : CareerVisuals.Muted;
        Vector2 P(float x, float y) => center + new Vector2(x, y) * scale;
        DrawPolyline([P(0, -11), P(12, 10), P(-12, 10), P(0, -11)], color, 1.5f, true);
        DrawLine(P(0, -3), P(0, 2), color, 1.8f, true);
        DrawCircle(P(0, 5), 1 * scale, color);
    }
}

public partial class CommunityBranchToggle : Button
{
    public bool Collapsed { get; init; }

    public override void _Ready()
    {
        Flat = true;
        CustomMinimumSize = new Vector2(28, 28);
        MouseDefaultCursorShape = CursorShape.PointingHand;
        foreach (string state in new[] { "normal", "hover", "pressed", "focus" })
            AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        MouseEntered += QueueRedraw; MouseExited += QueueRedraw;
        FocusEntered += QueueRedraw; FocusExited += QueueRedraw;
        Resized += QueueRedraw;
    }

    public override void _Draw()
    {
        Vector2 center = Size / 2;
        bool highlighted = IsHovered() || HasFocus();
        var color = highlighted ? CommunityDiscussionLines.GuideColor.Lightened(.15f) : CommunityDiscussionLines.GuideColor;
        DrawCircle(center, 9, new Color("142332"));
        DrawArc(center, 9, 0, Mathf.Tau, 32, color, 1.4f, true);
        if (Collapsed)
            DrawColoredPolygon(new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p).ToArray(), color);
        else DrawLine(center + new Vector2(-4, 0), center + new Vector2(4, 0), color, 1.5f, true);
    }
}
