using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private sealed class PrivateListRow
    {
        public required ContactRowButton Button;
        public required MarginContainer Inset;
        public required HBoxContainer Layout;
        public required Control Words;
        public required CareerAvatar Picture;
        public required GroupAvatar Emblem;
        public required Label Title, Preview, LastChat;
        public required Control Symbol;
        public required RelationshipIcon Relationship;
        public required TextureRect GroupSymbol;
        public string Id = "";
        public bool Group;
    }
    private readonly List<PrivateListRow> _privateRows = [];
    private readonly List<ChatContact> _privateEntries = [];
    private Dictionary<string, ChatContacts.Events> _privateEvents = [];
    private ScrollContainer? _privateListScroll;
    private Label? _privateListEmpty;

    private PrivateListRow CreatePrivateListRow()
    {
        var button = new ContactRowButton { CustomMinimumSize = new(0, 94) }; _privateList!.AddChild(button);
        var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var layout = new HBoxContainer(); inset.AddChild(layout);
        var portrait = new Control { CustomMinimumSize = new(40, 40), SizeFlagsVertical = SizeFlags.ShrinkCenter }; layout.AddChild(portrait);
        var picture = new CareerAvatar { Size = new(40, 40), Position = new(0, -2) }; portrait.AddChild(picture);
        var emblem = new GroupAvatar { Size = new(40, 40), Position = new(0, -2) }; portrait.AddChild(emblem);
        var words = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; layout.AddChild(words);
        var title = PrivateLine("", 19, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; words.AddChild(title);
        var symbol = new Control { Name = "ContactRightSymbol", Size = new(18, 18), MouseFilter = MouseFilterEnum.Ignore }; button.AddChild(symbol);
        var relationship = new RelationshipIcon { Tight = true }; symbol.AddChild(relationship);
        var groupSymbol = new TextureRect { Texture = AffectionArt.Texture("contact-group"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
            StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }; symbol.AddChild(groupSymbol); groupSymbol.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var preview = PrivateLine("", 14, _muted); preview.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; words.AddChild(preview);
        var lastChat = PrivateLine("", 11, _muted); lastChat.Name = "ContactLastChat"; lastChat.HorizontalAlignment = HorizontalAlignment.Right; lastChat.MouseFilter = MouseFilterEnum.Ignore; button.AddChild(lastChat);
        var row = new PrivateListRow { Button = button, Inset = inset, Layout = layout, Words = words, Picture = picture, Emblem = emblem, Title = title, Preview = preview,
            Relationship = relationship, GroupSymbol = groupSymbol, LastChat = lastChat, Symbol = symbol };
        void PositionDetails()
        {
            if (!title.IsInsideTree()) return;
            Vector2 at = button.GetGlobalTransformWithCanvas().AffineInverse() * title.GlobalPosition;
            symbol.Position = new(Math.Max(0, button.Size.X - 24), at.Y + (title.Size.Y - 18) / 2);
            lastChat.Position = new(72, button.Size.Y - 24); lastChat.Size = new(Math.Max(0, button.Size.X - 78), 18);
        }
        void PositionWords()
        {
            float oldHeight = title.GetThemeFont("font").GetHeight(17);
            title.Position = new(0, 4); title.Size = new(Math.Max(0, words.Size.X - 22), title.GetMinimumSize().Y);
            preview.Position = new(0, oldHeight + (row.Group ? 6 : 8) + 2); preview.Size = new(words.Size.X, preview.GetMinimumSize().Y);
            PositionDetails();
        }
        button.Resized += PositionDetails; title.ItemRectChanged += PositionDetails; words.Resized += PositionWords;
        button.Pressed += () => { if (row.Group) SelectGroup(row.Id); else SelectPrivate(row.Id); };
        button.GuiInput += input =>
        {
            if (input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Right })
            { button.AcceptEvent(); ShowChatContextMenu(row.Id, row.Group, _privateOverlay!.GetLocalMousePosition()); }
        };
        PrivateIgnoreMouse(inset); PrivateIgnoreMouse(symbol); return row;
    }

    private void ShowPrivateListRows()
    {
        if (_privateListScroll == null || _privateList == null || !IsInstanceValid(_privateList)) return;
        using var timing = UiPerformance.Measure(UiPerformance.Work.PrivateListRows, "通讯");
        int first = Math.Clamp(_privateListScroll.ScrollVertical / 94 - 1, 0, Math.Max(0, _privateEntries.Count - 1));
        int visible = Math.Min(_privateEntries.Count - first, (int)Math.Ceiling(Math.Max(500, _privateListScroll.Size.Y) / 94) + 3);
        var data = ViewData; var box = PrivateMessages.Mailbox(data);
        for (int i = 0; i < visible; i++)
        {
            if (i == _privateRows.Count) _privateRows.Add(CreatePrivateListRow());
            var row = _privateRows[i]; var entry = _privateEntries[first + i]; (row.Id, row.Group) = (entry.Id, entry.Group);
            row.Button.Position = new(0, (first + i) * 94); row.Button.Size = new(_privateList.Size.X, 94); row.Button.Show();
            row.Picture.Visible = !row.Group; row.Emblem.Visible = row.Group;
            row.Relationship.Visible = !row.Group && _contactPreferences.ShowRelationships; row.GroupSymbol.Visible = row.Group;
            string preview; int unread;
            if (row.Group)
            {
                var g = data.Chats.Groups.Single(g => g.Id == row.Id);
                row.Emblem.Update(data, g);
                unread = g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data));
                row.Title.Text = g.Name + (unread > 0 ? "  ●" : "");
                preview = g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text ?? g.Turns.LastOrDefault()?.Text ?? $"{g.Members.Count} 位成员";
            }
            else
            {
                var p = CareerEngine.Person(data, row.Id)!; var c = box.Conversations.GetValueOrDefault(row.Id);
                unread = c == null ? 0 : PrivateMessages.UnreadInCommunications(c);
                row.Title.Text = p.PublicName + (unread > 0 ? "  ●" : "");
                preview = c?.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications) is { } t ? t.Status == "complete" && !t.ReplyDeleted ? t.Reply : t.User : "开始聊天";
                row.Picture.PersonId = p.Id; row.Picture.Art = CareerAvatars.ForPerson(data, p.Id); row.Picture.Identity = AvatarHonors.ForPerson(data, p.Id);
                string bond = RelationshipPresentation.IconBond(box.Relations.GetValueOrDefault(p.Id) ?? new());
                row.Relationship.Visible &= bond != "unfamiliar";
                if (row.Relationship.Bond != bond) { row.Relationship.Bond = bond; row.Relationship.QueueRedraw(); }
            }
            string contactKey = row.Group ? "group:" + row.Id : row.Id;
            row.LastChat.Text = ChatContacts.LastChatText(data.Day, entry.Day);
            row.Button.EventIndicators(_privateEvents.GetValueOrDefault(contactKey));
            preview = preview.Replace('\n', ' ');
            var elements = new System.Globalization.StringInfo(preview);
            row.Preview.Text = elements.LengthInTextElements > 12 ? elements.SubstringByTextElements(0, 12) + "…" : preview;
            int margin = row.Group ? 12 : 10;
            foreach (string edge in new[] { "left", "right", "top", "bottom" }) row.Inset.AddThemeConstantOverride("margin_" + edge, margin);
            row.Inset.AddThemeConstantOverride("margin_left", margin + 14);
            row.Inset.AddThemeConstantOverride("margin_bottom", margin + 12);
            row.Layout.AddThemeConstantOverride("separation", margin);
            row.Words.EmitSignal(Control.SignalName.Resized);
            bool selected = row.Group ? row.Id == _privateGroup : row.Id == _privatePerson;
            row.Button.Bind(ChatPinned(contactKey), false, selected);
        }
        for (int i = visible; i < _privateRows.Count; i++) _privateRows[i].Button.Hide();
        if (_privateListEmpty != null) _privateListEmpty.Visible = _privateEntries.Count == 0 && _chatFilter != "群聊";
    }
}
