using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private readonly ChatHistoryPage<PrivateTurn> _privatePages = new(t => t.Id);
    private readonly ChatHistoryPage<GroupTurn> _groupPages = new(t => t.Id);
    private static readonly ConfigFile ChatPreferences = new();
    private static bool _chatPreferencesLoaded;
    private string ChatPreferenceKey => ViewData.WorldId + ":" + GroupChats.Human(ViewData);
    private int _chatPageSize = 10, _chatPageScroll = -1;
    private bool _chatNewMessages;
    private Button? _chatEarlier, _chatNewer, _chatLatest;
    private Label? _chatPageLabel;
    private OptionButton? _chatSizePicker;
    private HBoxContainer? _chatPagination, _chatPageOptions;
    private int ChatPage => _privateGroup.Length > 0 ? _groupPages.Page : _privatePages.Page;
    private int ChatPageCount => _privateGroup.Length > 0 ? _groupPages.Pages : _privatePages.Pages;
    private bool ChatAtLatest => ChatPage == ChatPageCount - 1;
    private bool ChatAtBottom => _privateScroll!.ScrollVertical >= _privateScroll.GetVScrollBar().MaxValue - _privateScroll.Size.Y - 90;
    private void LoadChatPreferences()
    {
        if (!_chatPreferencesLoaded) { ChatPreferences.Load("user://NationalSpire_chat.cfg"); _chatPreferencesLoaded = true; }
        _chatPageSize = ChatPreferences.GetValue(ChatPreferenceKey, "size", 10).AsInt32();
    }
    private void SaveChatPreferences()
    {
        string key = ChatPreferenceKey;
        if (ChatPreferences.GetValue(key, "last", "").AsString() == ChatDraftKey
            && ChatPreferences.GetValue(key, "size", 10).AsInt32() == _chatPageSize) return;
        ChatPreferences.SetValue(key, "last", ChatDraftKey); ChatPreferences.SetValue(key, "size", _chatPageSize);
        WriteChatPreferences();
    }
    private static void WriteChatPreferences()
    {
        var error = ChatPreferences.Save("user://NationalSpire_chat.cfg");
        if (error != Error.Ok) GD.PushWarning("聊天显示设置保存失败：" + error);
    }
    private void BuildChatPagination(ChatComposerLayout actions)
    {
        var row = new HBoxContainer { Name = "ChatPagination", Visible = false };
        _chatPagination = row; row.AddThemeConstantOverride("separation", 6); actions.AddChild(row);
        var options = new HBoxContainer { Name = "ChatPageOptions", Visible = false };
        _chatPageOptions = options; options.AddThemeConstantOverride("separation", 6); actions.AddChild(options);
        Button Action(string name, string text, Action click, int width)
        {
            var button = PrivateButton(text, click, width); button.Name = name; button.SizeFlagsVertical = SizeFlags.Fill;
            row.AddChild(button);
            foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled", "focus" })
            {
                var style = (StyleBox)button.GetThemeStylebox(state).Duplicate();
                style.ContentMarginTop = style.ContentMarginBottom = 6; button.AddThemeStyleboxOverride(state, style);
            }
            button.AddThemeFontSizeOverride("font_size", 14); return button;
        }
        _chatEarlier = Action("ChatEarlier", "‹", () => ChangeChatPage(ChatPage - 1), 32); _chatEarlier.TooltipText = "较早记录";
        _chatEarlier.AddThemeFontSizeOverride("font_size", 20);
        _chatPageLabel = PrivateLine("", 14, _muted); _chatPageLabel.Name = "ChatPageLabel";
        _chatPageLabel.CustomMinimumSize = new(90, 0); _chatPageLabel.SizeFlagsHorizontal = SizeFlags.ShrinkCenter;
        _chatPageLabel.HorizontalAlignment = HorizontalAlignment.Center;
        _chatPageLabel.VerticalAlignment = VerticalAlignment.Center; row.AddChild(_chatPageLabel);
        _chatNewer = Action("ChatNewer", "›", () => ChangeChatPage(ChatPage + 1), 32); _chatNewer.TooltipText = "较新记录";
        _chatNewer.AddThemeFontSizeOverride("font_size", 20);
        _chatLatest = Action("ChatLatest", "回到最新", LatestChatPage, 96);
        row.RemoveChild(_chatLatest); options.AddChild(_chatLatest);
        _chatSizePicker = new OptionButton { Name = "ChatPageSize", CustomMinimumSize = new(108, 42), SizeFlagsVertical = SizeFlags.Fill };
        _chatSizePicker.AddItem("每页 5轮"); _chatSizePicker.AddItem("每页 10轮"); _chatSizePicker.Select(_chatPageSize == 5 ? 0 : 1);
        _chatSizePicker.AddThemeFontSizeOverride("font_size", 14);
        options.AddChild(_chatSizePicker);
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled", "focus" })
        {
            var style = (StyleBox)_chatSizePicker.GetThemeStylebox(state).Duplicate();
            style.ContentMarginTop = style.ContentMarginBottom = 6; _chatSizePicker.AddThemeStyleboxOverride(state, style);
        }
        _chatSizePicker.ItemSelected += index =>
        {
            _chatPageSize = index == 0 ? 5 : 10;
            _privatePages.Resize(_chatPageSize); _groupPages.Resize(_chatPageSize);
            SaveChatPreferences(); InvalidateChatPage(0); RefreshPrivateChat();
        };
    }
    private void ResetChatPage()
    {
        _privatePages.Reset(_chatPageSize); _groupPages.Reset(_chatPageSize);
        _chatPagination!.Show();
        _chatPageOptions!.Show();
        _privateActions!.CenterPages = true;
        _privateExpressions?.Invoke(true);
        _chatNewMessages = false; InvalidateChatPage(int.MaxValue);
    }
    private void InvalidateChatPage(int position)
    {
        _privateScrollRevision++; _chatPageScroll = position;
        _privateSignature = _groupSignature = "";
    }
    private void ChangeChatPage(int page)
    {
        if (_privateGroup.Length > 0) _groupPages.Move(page); else _privatePages.Move(page);
        InvalidateChatPage(0); RefreshPrivateChat();
    }
    private void LatestChatPage()
    {
        // 发送完成回调可能先于下一次界面刷新；先读取新增轮次，再定位最新页面。
        BindChatPage(true);
        if (_privateGroup.Length > 0) _groupPages.Latest(); else _privatePages.Latest();
        _chatNewMessages = false; InvalidateChatPage(int.MaxValue); RefreshPrivateChat();
    }
    private void BindChatPage(bool follow)
    {
        int previous;
        if (_privateGroup.Length > 0 && CurrentGroup is { } group)
        {
            previous = _groupPages.Count;
            _groupPages.Bind(group.Turns, group.Revision, GroupTurnVisible, follow);
        }
        else
        {
            var conversation = PrivateMessages.Conversation(ViewData, _privatePerson);
            previous = _privatePages.Count;
            _privatePages.Bind(conversation.Turns, conversation.MemoryRevision, t => !(t.UserDeleted && t.ReplyDeleted), follow);
        }
        int count = _privateGroup.Length > 0 ? _groupPages.Count : _privatePages.Count;
        if (count > previous && previous > 0 && !follow) _chatNewMessages = true;
    }
    private static bool GroupTurnVisible(GroupTurn turn) => turn.Text.Length > 0 || turn.Attachments.Count > 0
        || turn.Replies.Count > 0 || turn.Raw.Length > 0 || turn.Reasoning.Length > 0 || turn.Effects.Count > 0
        || turn.Notices.Count > 0 || turn.Error.Length > 0 || turn.Status is "queued" or "sending";
    private void RefreshChatPagination()
    {
        _chatPageLabel!.Text = $"{ChatPage + 1} / {ChatPageCount} 页";
        _chatEarlier!.Disabled = ChatPage == 0; _chatNewer!.Disabled = ChatAtLatest;
        _chatLatest!.Text = _chatNewMessages ? "最新消息 ●" : "回到最新";
    }
    private void FinishChatPage(bool follow)
    {
        RefreshChatPagination();
        int position = _chatPageScroll; _chatPageScroll = -1;
        if (position >= 0) _ = ScrollChatTo(position);
        else if (follow && ChatAtLatest) _ = ScrollPrivateToBottom();
    }
    private async Task ScrollChatTo(int position)
    {
        int revision = ++_privateScrollRevision, page = ChatPage; string key = ChatDraftKey;
        var tree = GetTree();
        for (int i = 0; i < 3; i++) await ToSignal(tree, SceneTree.SignalName.ProcessFrame);
        if (revision == _privateScrollRevision && _privateOverlay != null && IsInstanceValid(_privateScroll) && key == ChatDraftKey && page == ChatPage)
            _privateScroll!.ScrollVertical = position == int.MaxValue ? (int)_privateScroll.GetVScrollBar().MaxValue : position;
    }
}
