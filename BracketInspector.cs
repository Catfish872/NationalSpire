using Godot;

namespace NationalSpire;

// A match can be inspected with a pointer or pinned with a click/keyboard activation.
public partial class BracketInspector : PanelContainer
{
    private const int CardWidth = 430;
    private Button? _target;
    private ScrollContainer _viewport = null!;
    private readonly ScrollContainer _scroll = new() { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
    private Control? _details;
    private bool _pinned;

    internal void Attach(Control stage, ScrollContainer viewport)
    {
        if (stage.GetNodeOrNull<BracketInspector>("BracketInspector") is { } previous)
        {
            previous.Dismiss();
            previous.Name = "RetiredInspector_" + previous.GetInstanceId();
            previous.QueueFree();
        }
        _viewport = viewport;
        Name = "BracketInspector";
        ZIndex = 18;
        MouseFilter = MouseFilterEnum.Stop;
        CustomMinimumSize = new(CardWidth, 0);
        AddThemeStyleboxOverride("panel", CareerVisuals.Box("11232f", "72948f", 7, 17));
        stage.AddChild(this);
        AddChild(_scroll);
        Dismiss();
        void OnVisibilityChanged() { if (!viewport.IsVisibleInTree()) Dismiss(); }
        viewport.VisibilityChanged += OnVisibilityChanged;
        viewport.TreeExiting += OnViewportExit;
        TreeExiting += () =>
        {
            if (!IsInstanceValid(viewport)) return;
            viewport.VisibilityChanged -= OnVisibilityChanged;
            viewport.TreeExiting -= OnViewportExit;
        };
        MouseExited += HideAfterPointerLeaves;
    }

    private void OnViewportExit()
    {
        Dismiss();
        QueueFree();
    }

    internal void Bind(Button button, Func<Control> content)
    {
        void ShowCard()
        {
            if (_target != button)
            {
                if (_details != null)
                {
                    _scroll.RemoveChild(_details);
                    _details.QueueFree();
                }
                _target = button;
                _details = content();
                _details.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                _scroll.AddChild(_details);
                _scroll.ScrollVertical = 0;
                Size = new(CardWidth, 210);
                Show();
                SetProcess(true);
            }
            PositionCard();
        }
        button.MouseEntered += () => { if (!_pinned) ShowCard(); };
        button.FocusEntered += () => { if (!_pinned) ShowCard(); };
        button.MouseExited += HideAfterPointerLeaves;
        button.FocusExited += () => { if (!_pinned && _target == button) HideAfterPointerLeaves(); };
        button.Pressed += () =>
        {
            if (_target == button && _pinned) { Dismiss(); return; }
            ShowCard();
            _pinned = true;
        };
    }

    private void HideAfterPointerLeaves()
    {
        Callable.From(() =>
        {
            if (!_pinned && _target != null && !_target.GetGlobalRect().HasPoint(GetGlobalMousePosition()) &&
                !GetGlobalRect().HasPoint(GetGlobalMousePosition())) Dismiss();
        }).CallDeferred();
    }

    private void Dismiss()
    {
        _target = null;
        _pinned = false;
        Hide();
        SetProcess(false);
    }

    private void PositionCard()
    {
        if (_target == null || !_target.IsVisibleInTree() || !_viewport.GetGlobalRect().Intersects(_target.GetGlobalRect()))
        {
            Dismiss();
            return;
        }
        var stage = (Control)GetParent();
        var inverse = stage.GetGlobalTransform().AffineInverse();
        var rect = _target.GetGlobalRect();
        var left = inverse * rect.Position;
        var right = inverse * rect.End;
        var region = _viewport.GetGlobalRect();
        var min=inverse*region.Position+new Vector2(6,6);
        var max=inverse*region.End-new Vector2(_viewport.GetVScrollBar().Visible?18:6,_viewport.GetHScrollBar().Visible?18:6);
        float visibleHeight=max.Y-min.Y;
        float height=Mathf.Clamp(_details!.GetCombinedMinimumSize().Y+34,94,Math.Max(94,visibleHeight));
        Size=new(CardWidth,height);
        float x=right.X+10+CardWidth<=max.X ? right.X+10 : left.X-CardWidth-10;
        Position=new(Mathf.Clamp(x,min.X,Math.Max(min.X,max.X-CardWidth)),
            Mathf.Clamp(left.Y,min.Y,Math.Max(min.Y,max.Y-height)));
    }

    public override void _Process(double delta) => PositionCard();
    public override void _Input(InputEvent input)
    {
        if (!Visible) return;
        if (input is InputEventKey { Pressed:true, Keycode:Key.Escape })
        { GetViewport().SetInputAsHandled(); Dismiss(); }
        if (input is InputEventMouseButton {Pressed:true, ButtonIndex:MouseButton.Left} && IsInstanceValid(_target) &&
            !_target!.GetGlobalRect().HasPoint(((InputEventMouseButton)input).Position) && !GetGlobalRect().HasPoint(((InputEventMouseButton)input).Position)) Dismiss();
    }
}
