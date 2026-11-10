using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    // 子弹窗关闭后先恢复原窗口，再继续下一步，保留编辑草稿和取消路径。
    private void PortraitImportDialog(string title, string message, Action<VBoxContainer, Action<Action>> contents)
    {
        var parent = _dialogOverlay; var cancel = _cancelDialog; var returnTo = _returnDialog;
        parent?.Hide(); _dialogOverlay = null; _cancelDialog = _returnDialog = null;
        Action? next = null;
        ShowCareerDialog(title, message, () => true, "返回", box => contents(box, action => { next = action; _cancelDialog?.Invoke(); }), showCancel: false);
        var child = _dialogOverlay!;
        child.TreeExiting += () => Callable.From(() =>
        {
            if (!IsInstanceValid(this) || IsQueuedForDeletion()) return;
            if (parent != null)
            {
                if (!IsInstanceValid(parent) || parent.IsQueuedForDeletion()) return;
                if (_dialogOverlay != null && _dialogOverlay != child) return;
                _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnTo; parent.Show();
            }
            next?.Invoke();
        }).CallDeferred();
    }
    private void ConfirmPortraitEmotions(CareerData data, PortraitPackageImport.Plan plan, PortraitDesign design, Action<HashSet<string>> apply)
    {
        if (!CareerStore.IsCurrent(data)) return;
        var unknown = plan.Unknown(design);
        if (unknown.Length == 0) { apply([]); return; }
        PortraitImportDialog("确认新情绪差分", "以下PNG对应新的或尚未启用的情绪ID。请逐项选择，再确认导入。", (box, finish) =>
        {
            box.Name = "PortraitUnknownEmotions"; box.CustomMinimumSize = new(860, 0);
            var choices = new Dictionary<string, bool>();
            var scroll = new BroadcastScroll { CustomMinimumSize = new(0, Math.Min(360, unknown.Length * 66)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; rows.AddThemeConstantOverride("separation", 12); scroll.AddChild(rows);
            Button confirm = null!;
            for (int i = 0; i < unknown.Length; i++)
            {
                var item = unknown[i];
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); rows.AddChild(row);
                var name = Text(Path.GetFileName(item.File) + " → " + item.Emotion, 18, _ink);
                name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.CustomMinimumSize = new(380, 48);
                name.ClipText = true; name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; name.TooltipText = item.File; row.AddChild(name);
                var skip = Button("取消导入", () => { }, 180); skip.Name = "PortraitSkip_" + i;
                var accept = Button("新建并导入", () => { }, 180); accept.Name = "PortraitAccept_" + i;
                foreach (var button in new[] { skip, accept }) { button.CustomMinimumSize = new(180, 48); button.ToggleMode = true; row.AddChild(button); }
                void Choose(bool value)
                {
                    choices[item.File] = value; skip.SetPressedNoSignal(!value); accept.SetPressedNoSignal(value);
                    skip.Modulate = value ? Colors.White : CareerVisuals.Teal; accept.Modulate = value ? CareerVisuals.Teal : Colors.White;
                    confirm.Disabled = choices.Count != unknown.Length;
                }
                skip.Pressed += () => Choose(false); accept.Pressed += () => Choose(true);
            }
            confirm = Button("确认导入", () => finish(() => { if (CareerStore.IsCurrent(data)) apply(choices.Where(p => p.Value).Select(p => p.Key).ToHashSet(StringComparer.Ordinal)); }), 180);
            confirm.Name = "PortraitConfirmImport"; confirm.Disabled = true; confirm.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; box.AddChild(confirm);
        });
    }
}
