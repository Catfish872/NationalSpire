using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void ManualMemoryCard(VBoxContainer list, ManualChatMemory memory)
    {
        var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101f2d", "3c5469", 3, 20)); list.AddChild(card);
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 14); card.AddChild(box);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);
        var title = PrivateLine(ManualChatMemories.Heading(ViewData, memory), 16, _gold); title.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(title);
        row.AddChild(PrivateButton("编辑", () => OpenChatDialog(() => EditManualMemory(memory)), 72));
        row.AddChild(PrivateButton("删除", () => OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () =>
        {
            var dialog = _dialogOverlay;
            void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); }
            if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted);
            else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted);
            return false;
        }, "删除")), 72));
        box.AddChild(PrivateSelectableText(memory.Text, 18, _ink));
    }

    private void EditManualMemory(ManualChatMemory? memory = null)
    {
        string group = _privateGroup, person = _privatePerson, id = memory?.Id ?? Guid.NewGuid().ToString("N");
        string action = memory == null ? "add" : "edit";
        TextEdit? input = null; Label? status = null; Control? dialog = null;
        void Fail(string message)
        {
            if (_dialogOverlay != dialog || !IsInstanceValid(status)) return;
            status!.Text = PlayerFacingText.LongError(message); status.Show();
        }
        ShowCareerDialog(memory == null ? "新建记忆总结" : "编辑手动记忆", "记录需要保留的经历、约定与细节，保存后用于后续聊天。", () =>
        {
            if (ManualChatMemories.Validate(input!.Text) is { } error) { Fail(error); input.GrabFocus(); return false; }
            void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); }
            if (group.Length > 0) GroupCommand("group-memory-" + action, new() { Text = input.Text, Interaction = new() { Entry = id } }, Accepted, group, Fail);
            else PrivateCommand("dm-memory-" + action, new() { Text = input.Text, Entry = id }, Accepted, person, Fail);
            return false;
        }, "保存", box =>
        {
            input = PrivateEditor(memory?.Text ?? ""); input.Name = "ManualMemoryEditor";
            input.PlaceholderText = "在此编写，或使用 Ctrl+V 粘贴记忆总结……"; box.AddChild(input);
            var count = PrivateLine("", 14, _muted); count.Name = "ManualMemoryCount"; box.AddChild(count);
            status = PrivateText("", 15, new Color("ee929d")); status.Name = "ManualMemoryError"; status.Hide(); box.AddChild(status);
            void Changed() { count.Text = $"{input.Text.Length} / {ManualChatMemories.MaxLength} 字"; status.Hide(); }
            input.TextChanged += Changed; Changed();
            if (_multiplayer is { } session)
            {
                void Message(string text, bool error) { if (error) Fail(text); }
                session.Message += Message; input.TreeExiting += () => session.Message -= Message;
            }
        });
        dialog = _dialogOverlay;
        Callable.From(() => { if (IsInstanceValid(input) && input!.IsVisibleInTree()) input.GrabFocus(); }).CallDeferred();
    }
}
