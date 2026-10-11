using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private sealed class PrivateListRow
    {
        public required Button Button;
        public required MarginContainer Inset;
        public required HBoxContainer Layout;
        public required VBoxContainer Words;
        public required CareerAvatar Picture;
        public required Label Emblem, Title, Preview;
        public string Id = "";
        public bool Group;
    }
    private readonly List<PrivateListRow> _privateRows = [];
    private readonly List<(string Id, bool Group)> _privateEntries = [];
    private ScrollContainer? _privateListScroll;
    private Label? _privateListEmpty;

    private PrivateListRow CreatePrivateListRow()
    {
        var button = PrivateButton("", () => { }, 0);
        button.CustomMinimumSize = new(0, 82); _privateList!.AddChild(button);
        var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var layout = new HBoxContainer(); inset.AddChild(layout);
        var picture = new CareerAvatar { CustomMinimumSize = new(40, 40), SizeFlagsVertical = SizeFlags.ShrinkCenter }; layout.AddChild(picture);
        var emblem = PrivateLine("群", 23, CareerVisuals.Teal); emblem.CustomMinimumSize = new(38, 0); layout.AddChild(emblem);
        var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; layout.AddChild(words);
        var title = PrivateLine("", 17, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; words.AddChild(title);
        var preview = PrivateLine("", 14, _muted); preview.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; words.AddChild(preview);
        var row = new PrivateListRow { Button = button, Inset = inset, Layout = layout, Words = words, Picture = picture, Emblem = emblem, Title = title, Preview = preview };
        button.Pressed += () => { if (row.Group) SelectGroup(row.Id); else SelectPrivate(row.Id); };
        PrivateIgnoreMouse(inset); return row;
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
            var row = _privateRows[i]; (row.Id, row.Group) = _privateEntries[first + i];
            row.Button.Position = new(0, (first + i) * 94); row.Button.Size = new(_privateList.Size.X, 82); row.Button.Show();
            row.Picture.Visible = !row.Group; row.Emblem.Visible = row.Group;
            string preview; int unread;
            if (row.Group)
            {
                var g = data.Chats.Groups.Single(g => g.Id == row.Id);
                unread = g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(data));
                row.Title.Text = g.Name + (unread > 0 ? "  ●" : "");
                preview = g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text ?? g.Turns.LastOrDefault()?.Text ?? $"{g.Members.Count} 位成员";
            }
            else
            {
                var p = CareerEngine.Person(data, row.Id)!; var c = box.Conversations.GetValueOrDefault(row.Id);
                unread = c == null ? 0 : c.Turns.Count(t => t.Status == "complete") - c.SeenCount;
                row.Title.Text = p.PublicName + (unread > 0 ? "  ●" : "");
                preview = c?.Turns.LastOrDefault(t => !(t.UserDeleted && t.ReplyDeleted)) is { } t ? t.Status == "complete" && !t.ReplyDeleted ? t.Reply : t.User : "开始聊天";
                if (preview.Length > 25) preview = preview[..25] + "…";
                row.Picture.PersonId = p.Id; row.Picture.Art = CareerAvatars.ForPerson(data, p.Id); row.Picture.Identity = AvatarHonors.ForPerson(data, p.Id);
            }
            row.Preview.Text = preview.Replace('\n', ' ');
            int margin = row.Group ? 12 : 10;
            foreach (string edge in new[] { "left", "right", "top", "bottom" }) row.Inset.AddThemeConstantOverride("margin_" + edge, margin);
            row.Layout.AddThemeConstantOverride("separation", margin); row.Words.AddThemeConstantOverride("separation", row.Group ? 6 : 8);
            bool selected = row.Group ? row.Id == _privateGroup : row.Id == _privatePerson;
            row.Button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(selected ? "334b60" : "142536", selected ? "d8bc7e" : "334b60", 8, 10));
        }
        for (int i = visible; i < _privateRows.Count; i++) _privateRows[i].Button.Hide();
        if (_privateListEmpty != null) _privateListEmpty.Visible = _privateEntries.Count == 0 && _chatFilter != "群聊";
    }
}
