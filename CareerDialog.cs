using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    protected Control? _dialogOverlay;
    protected Action? _cancelDialog;
    private Action? _returnDialog;
    private Action? _openingDialogReturn;

    // 使用主视口内的控件，避免创建独立窗口触发游戏的失焦静音。
    // Extensions compiled against either published signature must be able to bind the exact CLR method.
    protected void ShowCareerDialog(string title, string message, Func<bool> confirm, string confirmText, Action<VBoxContainer>? contents,
        bool showCancel, bool compact, string cancelText, bool returnOutsideChat)
        => ShowCareerDialog(title, message, confirm, confirmText, contents, showCancel, compact, cancelText, returnOutsideChat, null, null);

    protected void ShowCareerDialog(string title, string message, Func<bool> confirm, string confirmText = "确认", Action<VBoxContainer>? contents = null,
        bool showCancel = true, bool compact = false, string cancelText = "取消", bool returnOutsideChat = false,
        StyleBoxFlat? surface = null, Action<HBoxContainer, Button, Button>? footer = null)
    {
        if (_dialogOverlay != null) return;
        var returnTo = _openingDialogReturn;
        bool openedOutsideChat = _privateOverlay == null;
        var previousFocus = GetViewport().GuiGetFocusOwner();

        // The scope includes controls created during a refresh while the modal is open.
        var focus = _stage.FocusBehaviorRecursive;
        _stage.FocusBehaviorRecursive = FocusBehaviorRecursiveEnum.Disabled;
        var shade = new ColorRect { Name = "CareerDialog", FocusBehaviorRecursive = FocusBehaviorRecursiveEnum.Enabled, Color = new Color(0, 0, 0, .68f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 40 };
        _dialogOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var center = new CenterContainer { MouseFilter = MouseFilterEnum.Ignore }; shade.AddChild(center); center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var panel = _privateOverlay != null || surface != null ? new PanelContainer() : Card();
        if (_privateOverlay != null) panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 26));
        if (_privateOverlay != null && title == "聊天记忆")
        {
            panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 2, 30));
            panel.AddChild(new PrivateOrnament { Kind = "archiveWindow", MouseFilter = MouseFilterEnum.Ignore });
        }
        if (surface != null) panel.AddThemeStyleboxOverride("panel",surface);
        panel.Name = "CareerDialogPanel"; panel.CustomMinimumSize = new Vector2(compact ? 500 : 660, 0); panel.MouseFilter = MouseFilterEnum.Stop;
        center.AddChild(panel); var box = Inner(panel); box.CustomMinimumSize = new Vector2(compact ? 440 : 600, 0); box.AddThemeConstantOverride("separation", 22);
        box.AddChild(Text(title, compact ? 24 : 27, _gold)); if (message.Length > 0) box.AddChild(Text(message, 18, _ink));
        bool closed = false;
        void CloseDialog()
        {
            if (closed) return; closed = true;
            _dialogOverlay = null; _cancelDialog = _returnDialog = null; shade.Hide(); _stage.RemoveChild(shade); shade.QueueFree();
            _stage.FocusBehaviorRecursive = focus;
            if (IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()) previousFocus.GrabFocus();
        }
        _cancelDialog = CloseDialog;
        void Return()
        {
            CloseDialog();
            if (returnTo != null) Callable.From(() =>
            {
                if (IsInstanceValid(this) && IsInsideTree() && !IsQueuedForDeletion() && _dialogOverlay == null &&
                    (_privateOverlay != null || returnOutsideChat || openedOutsideChat)) returnTo();
            }).CallDeferred();
        }
        _returnDialog = Return;
        try
        {
            contents?.Invoke(box);
            var actions = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; actions.AddThemeConstantOverride("separation", 14); box.AddChild(actions);
            var cancel = _privateOverlay != null ? PrivateButton(cancelText, Return, 110) : Button(cancelText, Return, 130); cancel.Name = "CareerDialogCancel"; if (showCancel) actions.AddChild(cancel);
            bool submitting = false;
            void Accept()
            {
                if (closed || submitting) return;
                submitting = true;
                try
                {
                    if (confirm() && !closed) { if (confirmText is "关闭" or "完成") Return(); else CloseDialog(); }
                }
                finally { submitting = false; }
            }
            string acceptText = returnTo != null && confirmText is "关闭" or "完成" ? "返回" : confirmText;
            var accept = _privateOverlay != null ? PrivateButton(acceptText, Accept, 150) : Button(acceptText, Accept, 170); accept.Name = "CareerDialogConfirm";
            if (_privateOverlay == null) accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("2c505c", "63d4c5", 8, 12));
            else if (confirmText != "关闭") { accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12)); accept.AddThemeColorOverride("font_color", new Color("172330")); }
            if (compact)
            {
                accept.CustomMinimumSize = new Vector2(140, 48); cancel.CustomMinimumSize = new Vector2(110, 48);
                accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("57363e", "bb7981", 8, 12));
                accept.AddThemeColorOverride("font_color", new Color("fff0ee"));
            }
            actions.AddChild(accept);
            footer?.Invoke(actions,cancel,accept);
            if (showCancel) cancel.GrabFocus(); else { cancel.QueueFree(); accept.GrabFocus(); }
        }
        catch
        {
            CloseDialog();
            throw;
        }
    }
}
