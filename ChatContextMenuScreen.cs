using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control? _chatContextMenu;
    private Dictionary<string, int> _chatPinRanks = new(StringComparer.Ordinal);

    private bool ChatPinned(string key) => _chatPinRanks.ContainsKey(key);
    private void LoadChatPins()
        => _chatPinRanks = ChatPreferences.GetValue(ChatPreferenceKey, "pins", Array.Empty<string>()).AsStringArray()
            .Distinct(StringComparer.Ordinal).Select((key, rank) => (key, rank)).ToDictionary(x => x.key, x => x.rank, StringComparer.Ordinal);
    private void SetChatPinned(string key, bool pinned)
    {
        var pins = _chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).Where(p => p != key).ToList();
        if (pinned) pins.Insert(0, key);
        ChatPreferences.SetValue(ChatPreferenceKey, "pins", pins.ToArray());
        LoadChatPins(); WriteChatPreferences();
        _privateListSignature = ""; RefreshPrivateList();
    }
    private void CloseChatContextMenu()
    {
        if (_chatContextMenu == null) return;
        _chatContextMenu.Hide(); _chatContextMenu.QueueFree(); _chatContextMenu = null;
    }
    private void ShowChatContextMenu(string id, bool group, Vector2 position)
    {
        if (_dialogOverlay != null) return;
        CloseChatContextMenu();
        var shade = new Control { Name = "ChatContextMenu", MouseFilter = MouseFilterEnum.Stop, ZIndex = 45 };
        _chatContextMenu = shade; _privateOverlay!.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        shade.GuiInput += input =>
        {
            if (input is InputEventMouseButton { Pressed: true }) { CloseChatContextMenu(); shade.AcceptEvent(); }
        };
        var panel = new PanelContainer { MouseFilter = MouseFilterEnum.Stop };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 5, 12)); shade.AddChild(panel);
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 5); panel.AddChild(box);
        var title = PrivateLine(group ? ViewData.Chats.Groups.Single(g => g.Id == id).Name : GroupChats.Name(ViewData, id), 16, _gold);
        title.CustomMinimumSize = new(210, 0); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; box.AddChild(title);
        box.AddChild(new HSeparator());
        foreach (var item in ChatMenuItems(id, group))
        {
            var button = PrivateButton(item.Title, item.Run, 210); button.CustomMinimumSize = new(210, 38);
            button.AddThemeFontSizeOverride("font_size", 16); box.AddChild(button);
        }
        panel.ResetSize();
        panel.Position = new(Math.Clamp(position.X, 8, Math.Max(8, shade.Size.X - panel.Size.X - 8)),
            Math.Clamp(position.Y, 8, Math.Max(8, shade.Size.Y - panel.Size.Y - 8)));
    }
}
