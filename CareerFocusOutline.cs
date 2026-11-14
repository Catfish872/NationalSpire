using Godot;

namespace NationalSpire;

// 保留实际焦点，鼠标与键盘共用同一导航位置。只替换当前控件绘制焦点框的样式。
internal partial class CareerFocusOutline : Node
{
    internal const string ThemeMarker = "national_spire_focus_outline";
    private static readonly StringName FocusStyle = "focus";
    private readonly StyleBoxEmpty _hidden = new();
    private Control? _masked;
    private StyleBox? _previousOverride;
    private bool _pointer = true;

    public override void _Ready()
    {
        ProcessMode = ProcessModeEnum.Always;
        GetViewport().GuiFocusChanged += FocusChanged;
        FocusChanged(GetViewport().GuiGetFocusOwner());
    }
    public override void _ExitTree()
    {
        GetViewport().GuiFocusChanged -= FocusChanged;
        Restore();
    }
    public override void _Input(InputEvent input)
    {
        bool pointer;
        switch (input)
        {
            case InputEventMouseButton { Pressed: true }:
            case InputEventScreenTouch { Pressed: true }: pointer = true; break;
            case InputEventKey { Pressed: true, Echo: false }:
            case InputEventJoypadButton { Pressed: true }:
            case InputEventJoypadMotion axis when Mathf.Abs(axis.AxisValue) > .5f: pointer = false; break;
            default: return;
        }
        if (_pointer == pointer) return;
        _pointer = pointer;
        FocusChanged(GetViewport().GuiGetFocusOwner());
    }
    private void FocusChanged(Control? control)
    {
        Restore();
        if (!_pointer || control == null || control is LineEdit or TextEdit ||
            !control.HasThemeConstant(ThemeMarker) || !control.HasThemeStylebox(FocusStyle)) return;
        _masked = control;
        _previousOverride = control.HasThemeStyleboxOverride(FocusStyle) ? control.GetThemeStylebox(FocusStyle) : null;
        control.AddThemeStyleboxOverride(FocusStyle, _hidden);
        control.FocusExited += Restore;
    }
    private void Restore()
    {
        if (_masked is {} control && IsInstanceValid(control))
        {
            control.FocusExited -= Restore;
            if (_previousOverride != null) control.AddThemeStyleboxOverride(FocusStyle, _previousOverride);
            else control.RemoveThemeStyleboxOverride(FocusStyle);
        }
        _previousOverride = null;
        _masked = null;
    }
}
