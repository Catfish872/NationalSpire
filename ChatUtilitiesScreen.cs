using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private PopupMenu? _chatModelPopup;
    private bool ChatModelPickerOpen => IsInstanceValid(_chatModelPopup) && _chatModelPopup!.Visible;

    private void ExportChatTranscript()
    {
        try
        {
            var data = ViewData;
            var document = CurrentGroup is { } group ? ChatTranscript.Group(data, group)
                : ChatTranscript.Private(data, PrivateMessages.Conversation(data, _privatePerson));
            string directory = PromptTransfer.Desktop;
            if (string.IsNullOrWhiteSpace(directory)) directory = ProjectSettings.GlobalizePath("user://chat_exports");
            string path = ChatTranscript.Write(data, document, directory);
            ShowCareerDialog("聊天记录已导出", $"已导出 {document.Messages.Count} 条消息。\n保存位置：{path}", () => true, "完成",
                box => box.AddChild(PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200)), showCancel: false);
        }
        catch (Exception e)
        {
            ShowCareerDialog("导出失败", e.Message, () => true, "关闭", showCancel: false);
        }
    }

    private void BuildChatModelButton(HBoxContainer tools)
    {
        var button = PrivateButton("", () => { }, 48); button.Name = "ChatModelButton";
        button.Icon = AffectionArt.Texture("chat-model"); button.ExpandIcon = true;
        button.AddThemeConstantOverride("icon_max_width", 24); button.SizeFlagsVertical = SizeFlags.Fill;
        button.TooltipText = "切换当前聊天类型的模型方案";
        button.Pressed += () => ShowChatModelPicker(button, _privateGroup.Length > 0 ? "group" : "private");
        ConfigureModelPermission(button); tools.AddChild(button);
    }

    private void ConfigureModelPermission(Button button)
    {
        button.Disabled = _multiplayer is { Host: false };
        if (button.Disabled) button.TooltipText = "模型方案由房主设置。";
    }

    private void ShowChatModelPicker(Button anchor, string task)
    {
        if (_dialogOverlay != null || _multiplayer is { Host: false }) return;
        if (ChatModelPickerOpen) { _chatModelPopup!.Hide(); return; }
        var data = ViewData;
        AiRouting.Ensure(data.Ai);
        var viewport = GetViewport().GetVisibleRect().Size;
        var popup = new PopupMenu { Name = "ChatModelPicker", HideOnCheckableItemSelection = true, WrapControls = false,
            MaxSize = new((int)(viewport.X - 16), (int)(viewport.Y * .6f)) };
        _chatModelPopup = popup; anchor.AddChild(popup);
        popup.AddThemeFontSizeOverride("font_size", 16);
        popup.AddThemeConstantOverride("v_separation", 14);
        popup.AddThemeStyleboxOverride("panel", CareerVisuals.Box("122735", "426575", 8, 10));
        string selected = AiRouting.ProfileId(data.Ai, task);
        foreach (var (id, profile) in data.Ai.ConnectionProfiles)
        {
            var name = new System.Globalization.StringInfo(profile.Name);
            int index = popup.ItemCount;
            popup.AddRadioCheckItem(name.LengthInTextElements > 24 ? name.SubstringByTextElements(0, 24) + "…" : profile.Name);
            popup.SetItemMetadata(index, id); popup.SetItemChecked(index, id == selected);
            popup.SetItemTooltip(index, profile.Name + "\n" + profile.Model);
        }
        popup.IdPressed += id =>
        {
            try
            {
                if (!ReferenceEquals(ViewData.Ai, data.Ai)) throw new InvalidOperationException("生涯已切换，请重新选择方案。");
                AiRouting.Assign(data.Ai, task, popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString(), () => SaveAiSettings(ViewData));
                popup.Hide();
            }
            catch (Exception e)
            {
                popup.Hide();
                ShowCareerDialog("方案未保存", e.Message, () => true, "关闭", showCancel: false);
            }
        };
        popup.PopupHide += () => RetireChatModelPopup(popup, anchor);
        popup.TreeExiting += () => { if (_chatModelPopup == popup) _chatModelPopup = null; };
        var transform = anchor.GetGlobalTransformWithCanvas();
        var size = popup.GetContentsMinimumSize() * Math.Min(transform.Scale.X, transform.Scale.Y);
        size = size.Ceil().Min(popup.MaxSize);
        var origin = transform.Origin;
        var position = new Vector2(Math.Clamp(origin.X, 8, Math.Max(8, viewport.X - size.X - 8)), Math.Max(8, origin.Y - size.Y - 8));
        popup.PopupOnParent(new Rect2I((Vector2I)position, (Vector2I)size));
        // Godot 4.5 的 PopupMenu 在弹出前按全文高度重设 MinSize；同帧恢复限制以启用原生滚动。
        popup.MinSize = (Vector2I)size; popup.Size = (Vector2I)size;
        popup.Position = (Vector2I)position + (popup.IsEmbedded() ? Vector2I.Zero : GetWindow().Position);
    }
    private async void RetireChatModelPopup(PopupMenu popup, Button anchor)
    {
        // An outside press dismisses PopupMenu before Button emits Pressed on release.
        // Consume that same click on its opener so the release cannot immediately reopen it.
        bool closingClick = IsInstanceValid(anchor) && !anchor.Disabled && Input.IsMouseButtonPressed(MouseButton.Left);
        if (closingClick)
        {
            anchor.Disabled = true;
            while (IsInstanceValid(this) && IsInsideTree() && Input.IsMouseButtonPressed(MouseButton.Left))
                await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
            if (IsInstanceValid(anchor)) ConfigureModelPermission(anchor);
        }
        if (IsInstanceValid(popup)) popup.QueueFree();
    }
}
