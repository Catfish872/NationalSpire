using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private PopupMenu? _chatModelPopup;
    private bool ChatModelPickerOpen => IsInstanceValid(_chatModelPopup) && _chatModelPopup!.GetParent() is Button anchor && CareerDropdownLayer.At(anchor).Showing(anchor);

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
        var dropdown = CareerDropdownLayer.At(anchor);
        if (dropdown.Showing(anchor)) { dropdown.Close(); return; }
        var data = ViewData;
        AiRouting.Ensure(data.Ai);
        var popup = new PopupMenu { Name = "ChatModelPicker", HideOnCheckableItemSelection = true };
        _chatModelPopup = popup; anchor.AddChild(popup);
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
            }
            catch (Exception e)
            {
                ShowCareerDialog("方案未保存", e.Message, () => true, "关闭", showCancel: false);
            }
        };
        dropdown.Open(anchor,popup,() => {
            if (_chatModelPopup == popup) _chatModelPopup = null;
            popup.QueueFree();
        });
    }
}
