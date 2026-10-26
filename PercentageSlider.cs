using Godot;
using System.Globalization;

namespace NationalSpire;

/// <summary>沿用 HSlider 的拖动和键盘行为，滑块数值可单击编辑。</summary>
public partial class PercentageSlider : HSlider
{
    private const float ThumbWidth = 84, ThumbHeight = 34;
    private PanelContainer _thumb = null!;
    private Label _caption = null!;
    private LineEdit _editor = null!;
    private Vector2 _pressed;
    private bool _thumbPressed, _dragged, _committing;

    public override void _Ready()
    {
        MinValue = 0; MaxValue = 100; Step = .1; Scrollable = false;
        CustomMinimumSize = new(230, 40); SizeFlagsHorizontal = SizeFlags.ExpandFill;
        var transparent = new GradientTexture2D { Width = (int)ThumbWidth, Height = (int)ThumbHeight,
            Gradient = new Gradient { Colors = [Colors.Transparent, Colors.Transparent] } };
        foreach (string state in new[] { "grabber", "grabber_highlight", "grabber_disabled" }) AddThemeIconOverride(state, transparent);
        AddThemeStyleboxOverride("slider", new StyleBoxFlat { BgColor = new("304959"), CornerRadiusTopLeft = 3, CornerRadiusBottomLeft = 3,
            CornerRadiusTopRight = 3, CornerRadiusBottomRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 });
        AddThemeStyleboxOverride("grabber_area", new StyleBoxFlat { BgColor = new("70b7bb"), ContentMarginTop = 3, ContentMarginBottom = 3 });
        AddThemeStyleboxOverride("grabber_area_highlight", new StyleBoxFlat { BgColor = CareerVisuals.Teal, ContentMarginTop = 3, ContentMarginBottom = 3 });
        _thumb = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore };
        _thumb.AddThemeStyleboxOverride("panel", CareerVisuals.Box("294b5a", "80bfc5", 8, 0)); AddChild(_thumb);
        _caption = new Label { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, MouseFilter = MouseFilterEnum.Ignore };
        _caption.AddThemeFontSizeOverride("font_size", 17); _caption.AddThemeColorOverride("font_color", CareerVisuals.Ink); _thumb.AddChild(_caption);
        _editor = new LineEdit { Name = "PercentageInput", Visible = false, Alignment = HorizontalAlignment.Center, SelectAllOnFocus = true };
        _editor.AddThemeFontSizeOverride("font_size", 17); _editor.AddThemeStyleboxOverride("normal", CareerVisuals.Box("152d3c", "80e7db", 8, 0)); AddChild(_editor);
        _editor.TextSubmitted += _ => Commit(); _editor.FocusExited += Commit;
        ValueChanged += _ => LayoutThumb(); Resized += LayoutThumb;
        GuiInput += HandleInput; TooltipText = "拖动滑块；单击百分比可输入。"; LayoutThumb();
    }

    private void LayoutThumb()
    {
        if (_thumb == null) return;
        var position = new Vector2((float)(Value / 100) * Math.Max(0, Size.X - ThumbWidth), (Size.Y - ThumbHeight) / 2);
        _thumb.Position = _editor.Position = position; _thumb.Size = _editor.Size = new(ThumbWidth, ThumbHeight);
        _caption.Text = Value.ToString("0.#", CultureInfo.InvariantCulture) + "%";
    }

    private void HandleInput(InputEvent input)
    {
        if (!Editable) return;
        if (input is InputEventMouseButton { ButtonIndex: MouseButton.Left } mouse)
        {
            if (mouse.Pressed) { _pressed = mouse.Position; _thumbPressed = _thumb.GetRect().HasPoint(mouse.Position); _dragged = false; }
            else if (_thumbPressed && !_dragged)
            {
                _editor.Text = Value.ToString("0.#", CultureInfo.InvariantCulture) + "%"; _editor.Show();
                _editor.GrabFocus(); _editor.SelectAll();
            }
        }
        if (input is InputEventMouseMotion motion && motion.ButtonMask.HasFlag(MouseButtonMask.Left) && motion.Position.DistanceTo(_pressed) > 3) _dragged = true;
        if (input is InputEventKey { Pressed: true, Keycode: Key.Enter })
        { _editor.Text = Value.ToString("0.#", CultureInfo.InvariantCulture) + "%"; _editor.Show(); _editor.GrabFocus(); _editor.SelectAll(); AcceptEvent(); }
    }

    public void Refresh() => LayoutThumb();

    public void Commit()
    {
        if (_editor == null || !_editor.Visible || _committing) return;
        _committing = true;
        string text = _editor.Text.Trim().TrimEnd('%', '％');
        if (double.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out double value) && double.IsFinite(value)) Value = Math.Clamp(value, 0, 100);
        _editor.Hide(); _committing = false; LayoutThumb();
    }
}

/// <summary>配置窗口的比例锁开关；状态由所属比例组持有。</summary>
public partial class PercentageLockButton : Button
{
    private readonly StyleBoxFlat _body = new() { BgColor = Colors.Transparent,
        BorderWidthLeft = 2, BorderWidthRight = 2, BorderWidthTop = 2, BorderWidthBottom = 2,
        CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 };
    public override void _Ready()
    {
        ToggleMode = true; Flat = true; CustomMinimumSize = new(28, 40);
        MouseDefaultCursorShape = CursorShape.PointingHand;
        Toggled += _ => UpdateState(); MouseEntered += QueueRedraw; MouseExited += QueueRedraw;
        UpdateState();
    }

    private void UpdateState()
    {
        TooltipText = ButtonPressed ? "比例已锁定 · 点击解锁" : "点击锁定当前比例";
        QueueRedraw();
    }

    public override void _Draw()
    {
        var center = Size / 2;
        var color = new Color(IsHovered() ? "c9d0d5" : "9ba8b2");
        _body.BorderColor = color;
        DrawStyleBox(_body, new Rect2(center + new Vector2(-8, -2), new Vector2(16, 13)));
        var shackle = center + (ButtonPressed ? new Vector2(0, -6) : new Vector2(4, -8));
        DrawArc(shackle, 5, Mathf.Pi, Mathf.Tau, 20, color, 2, true);
        DrawLine(shackle + new Vector2(-5, 0), new Vector2(shackle.X - 5, center.Y - 2), color, 2, true);
        DrawLine(shackle + new Vector2(5, 0), new Vector2(shackle.X + 5, center.Y + (ButtonPressed ? -2 : -5)), color, 2, true);
        DrawLine(center + new Vector2(0, 3), center + new Vector2(0, 6), color, 2, true);
    }
}
