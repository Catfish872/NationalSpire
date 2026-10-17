using Godot;

namespace NationalSpire;

/// <summary>输入框底栏：私信及群聊分页和轮数作为整体居中，工具和发送保留两侧位置。</summary>
public partial class ChatComposerLayout : Container
{
    internal const float ButtonScale = .9f;
    internal const float SendWidthIncrease = 20;
    internal const float SendEdgeCompensation = SendWidthIncrease * (1 - ButtonScale) / 2;
    internal static void CompactButtons(Control parent)
    {
        foreach (var child in parent.GetChildren().OfType<Control>().ToArray())
        {
            if (child is not BaseButton button) { CompactButtons(child); continue; }
            int index = button.GetIndex();
            var slot = new ChatComposerButtonSlot { Name = button.Name + "Slot", Visible = button.Visible,
                SizeFlagsHorizontal = button.SizeFlagsHorizontal, SizeFlagsVertical = button.SizeFlagsVertical };
            parent.RemoveChild(button); parent.AddChild(slot); parent.MoveChild(slot, index); slot.AddChild(button);
            button.VisibilityChanged += () => slot.Visible = button.Visible;
        }
    }
    private bool _centerPages;
    public bool CenterPages
    {
        get => _centerPages;
        set { if (_centerPages == value) return; _centerPages = value; UpdateMinimumSize(); QueueSort(); }
    }

    public override Vector2 _GetMinimumSize()
    {
        var parts = GetChildren().OfType<Control>().ToArray();
        if (parts.Length != 4) return Vector2.Zero;
        var sizes = parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray();
        float halfPages = (sizes[1].X + 6 + sizes[2].X) / 2;
        float width = CenterPages && parts[1].Visible
            ? 2 * Math.Max(sizes[0].X + 14 + halfPages, halfPages + 14 + sizes[3].X)
            : sizes.Sum(s => s.X) + 34;
        return new(width, sizes.Max(s => s.Y));
    }

    public override void _Notification(int what)
    {
        if (what != NotificationSortChildren) return;
        var parts = GetChildren().OfType<Control>().ToArray();
        if (parts.Length != 4) return;
        var sizes = parts.Select(p => p.Visible ? p.GetCombinedMinimumSize() : Vector2.Zero).ToArray();
        float pageX = sizes[0].X + 14;
        if (CenterPages && parts[1].Visible)
        {
            float first = parts[1].GetChild<Control>(0).GetCombinedMinimumSize().X;
            float last = parts[2].GetChild<Control>(parts[2].GetChildCount() - 1).GetCombinedMinimumSize().X;
            pageX = (Size.X - sizes[1].X - 6 - sizes[2].X) / 2 + (last - first) * (1 - ButtonScale) / 4;
        }
        float optionsX = pageX + sizes[1].X + 6;
        // 右侧放大及发送共用一个槽位，保持发送靠右并给中间分页组留出间距。
        float sendSpace = CenterPages ? (Size.X - sizes[1].X) / 2 - 6 - sizes[2].X - 14 : Size.X - optionsX - sizes[2].X - 14;
        float extra = SendWidthIncrease - SendEdgeCompensation;
        float originalMinimum = sizes[3].X - extra;
        float sendWidth = Math.Clamp(sendSpace, originalMinimum, Math.Max(150, originalMinimum)) + extra;
        FitChildInRect(parts[0], new Rect2(0, 0, sizes[0].X, Size.Y));
        FitChildInRect(parts[1], new Rect2(pageX, 0, sizes[1].X, Size.Y));
        FitChildInRect(parts[2], new Rect2(optionsX, 0, sizes[2].X, Size.Y));
        // 补偿0.9缩放新增的右侧内缩，同时用相同补偿量减小组内间距。
        FitChildInRect(parts[3], new Rect2(Size.X - sendWidth + SendEdgeCompensation, 0, sendWidth, Size.Y));
    }
}

/// <summary>保留底栏按钮的原布局占位，围绕中心等比缩小绘制与点击区域。</summary>
public partial class ChatComposerButtonSlot : Container
{
    public override Vector2 _GetMinimumSize() => GetChildCount() == 0 ? Vector2.Zero : GetChild<Control>(0).GetCombinedMinimumSize();
    public override void _Notification(int what)
    {
        if (what != NotificationSortChildren || GetChildCount() == 0) return;
        var button = GetChild<Control>(0);
        FitChildInRect(button, new Rect2(Vector2.Zero, Size));
        button.PivotOffset = button.Size / 2; button.Scale = Vector2.One * ChatComposerLayout.ButtonScale;
    }
}

/// <summary>聊天输入区按右侧聊天栏高度展开，表情和附件占用框内空间。</summary>
public partial class ChatComposerPanel : PanelContainer
{
    private Control? _bounds;
    private VBoxContainer? _body;
    private TextEdit? _editor;
    private ScrollContainer? _attachments;
    private Control? _heading;
    private ScrollContainer? _headingViewport;
    private float _attachmentHeight = 72;
    private bool _resizeQueued;
    public bool Expanded { get; private set; }
    public event Action<bool>? ExpansionChanged;

    public void Bind(Control bounds, VBoxContainer body, TextEdit editor, ScrollContainer attachments, Control heading)
    {
        _bounds = bounds; _body = body; _editor = editor; _attachments = attachments; _heading = heading;
        var chat = heading.GetParent<Container>(); int index = heading.GetIndex();
        _headingViewport = new ScrollContainer { Name = "PrivateIdentityViewport", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, FollowFocus = true };
        chat.RemoveChild(heading); chat.AddChild(_headingViewport); chat.MoveChild(_headingViewport, index);
        heading.SizeFlagsHorizontal = SizeFlags.ExpandFill; _headingViewport.AddChild(heading);
        editor.SizeFlagsVertical = SizeFlags.ExpandFill;
        bounds.Resized += QueueResize; body.MinimumSizeChanged += QueueResize; heading.MinimumSizeChanged += QueueResize;
        TreeExiting += () => bounds.Resized -= QueueResize;
        QueueResize();
    }
    public void Toggle() => SetExpanded(!Expanded);
    public void SetExpanded(bool value)
    {
        if (Expanded == value) return;
        Expanded = value; ExpansionChanged?.Invoke(value); QueueResize();
    }
    public void SetAttachmentHeight(float height)
    { _attachmentHeight = height; QueueResize(); }
    private void QueueResize()
    {
        if (_resizeQueued || !IsInsideTree()) return;
        _resizeQueued = true; Callable.From(ResizeComposer).CallDeferred();
    }
    private void ResizeComposer()
    {
        _resizeQueued = false;
        if (!IsInsideTree() || IsQueuedForDeletion() || _bounds == null || _body == null || _editor == null || _attachments == null) return;
        float height = Expanded ? _bounds.Size.Y * .6f : 0;
        _editor.CustomMinimumSize = new(0, Expanded ? 36 : 68);
        float attachmentHeight = _attachmentHeight;
        if (Expanded && _attachments.Visible)
        {
            float fixedHeight = _body.GetCombinedMinimumSize().Y - _attachments.GetCombinedMinimumSize().Y + GetThemeStylebox("panel").GetMinimumSize().Y;
            attachmentHeight = Math.Min(attachmentHeight, Math.Max(0, height - fixedHeight));
        }
        _attachments.CustomMinimumSize = new(0, attachmentHeight);
        CustomMinimumSize = new(0, height);
        if (_heading == null || _headingViewport == null) return;
        float headingHeight = _heading.GetCombinedMinimumSize().Y;
        if (Expanded)
        {
            var chat = GetParent<VBoxContainer>();
            var siblings = chat.GetChildren().OfType<Control>().Where(c => c.Visible).ToArray();
            float otherHeight = siblings.Where(c => c != this && c != _headingViewport).Sum(c => c.GetCombinedMinimumSize().Y);
            float margins = _bounds.GetThemeStylebox("panel").GetMinimumSize().Y + chat.GetThemeConstant("separation") * (siblings.Length - 1);
            headingHeight = Math.Min(headingHeight, Math.Max(0, _bounds.Size.Y - height - margins - otherHeight));
        }
        _headingViewport.CustomMinimumSize = new(0, headingHeight);
    }
}

/// <summary>对角箭头表示输入区放大与还原，使用当前界面的矢量线条。</summary>
public partial class ChatComposerExpandIcon : Control
{
    public bool Expanded { get; set; }
    public override void _Ready() { SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); Resized += QueueRedraw; }
    public override void _Draw()
    {
        var center = Size / 2; Color color = CareerVisuals.Ink;
        foreach (int side in new[] { -1, 1 })
        {
            var outer = center + new Vector2(side * 9, -side * 9);
            var inner = center + new Vector2(side * 2, -side * 2);
            DrawLine(inner, outer, color, 1.8f, true);
            var tip = Expanded ? inner : outer; float direction = Expanded ? side : -side;
            DrawPolyline([tip + new Vector2(direction * 6, 0), tip, tip + new Vector2(0, -direction * 6)], color, 1.8f, true);
        }
    }
}
