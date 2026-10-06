using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control? _dialogOverlay;
    private Action? _cancelDialog;

    // 使用主视口内的控件，避免创建独立窗口触发游戏的失焦静音。
    private void ShowCareerDialog(string title, string message, Func<bool> confirm, string confirmText = "确认", Action<VBoxContainer>? contents = null, bool showCancel = true, bool compact = false)
    {
        if (_dialogOverlay != null) return;
        var previousFocus = GetViewport().GuiGetFocusOwner();
        IEnumerable<Control> Controls(Node node)
        {
            foreach (var child in node.GetChildren())
            {
                if (child is Control c) yield return c;
                foreach (var nested in Controls(child)) yield return nested;
            }
        }
        var focus = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList();
        foreach (var entry in focus) entry.Control.FocusMode = FocusModeEnum.None;
        var shade = new ColorRect { Name = "CareerDialog", Color = new Color(0, 0, 0, .68f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 40 };
        _dialogOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var center = new CenterContainer { MouseFilter = MouseFilterEnum.Ignore }; shade.AddChild(center); center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var panel = _privateOverlay != null ? new PanelContainer() : Card();
        if (_privateOverlay != null) panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 26));
        if (_privateOverlay != null && title == "聊天记忆")
        {
            panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 2, 30));
            panel.AddChild(new PrivateOrnament { Kind = "archiveWindow", MouseFilter = MouseFilterEnum.Ignore });
        }
        panel.Name = "CareerDialogPanel"; panel.CustomMinimumSize = new Vector2(compact ? 500 : 660, 0); panel.MouseFilter = MouseFilterEnum.Stop;
        center.AddChild(panel); var box = Inner(panel); box.CustomMinimumSize = new Vector2(compact ? 440 : 600, 0); box.AddThemeConstantOverride("separation", 22);
        box.AddChild(Text(title, compact ? 24 : 27, _gold)); if (message.Length > 0) box.AddChild(Text(message, 18, _ink));
        contents?.Invoke(box);
        var actions = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; actions.AddThemeConstantOverride("separation", 14); box.AddChild(actions);
        bool closed = false;
        void CloseDialog()
        {
            if (closed) return; closed = true;
            _dialogOverlay = null; _cancelDialog = null; shade.Hide(); _stage.RemoveChild(shade); shade.QueueFree();
            foreach (var entry in focus)
                if (IsInstanceValid(entry.Control) && !entry.Control.IsQueuedForDeletion()) entry.Control.FocusMode = entry.Mode;
            if (IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()) previousFocus.GrabFocus();
        }
        _cancelDialog = CloseDialog;
        var cancel = _privateOverlay != null ? PrivateButton("取消", CloseDialog, 110) : Button("取消", CloseDialog, 130); cancel.Name = "CareerDialogCancel"; if (showCancel) actions.AddChild(cancel);
        void Accept() { if (!closed && confirm()) CloseDialog(); }
        var accept = _privateOverlay != null ? PrivateButton(confirmText, Accept, 150) : Button(confirmText, Accept, 170); accept.Name = "CareerDialogConfirm";
        if (_privateOverlay == null) accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("2c505c", "63d4c5", 8, 12));
        else if (confirmText != "关闭") { accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12)); accept.AddThemeColorOverride("font_color", new Color("172330")); }
        if (compact)
        {
            accept.CustomMinimumSize = new Vector2(140, 48); cancel.CustomMinimumSize = new Vector2(110, 48);
            accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("57363e", "bb7981", 8, 12));
            accept.AddThemeColorOverride("font_color", new Color("fff0ee"));
        }
        actions.AddChild(accept);
        if (showCancel) cancel.GrabFocus(); else { cancel.QueueFree(); accept.GrabFocus(); }
    }
}
