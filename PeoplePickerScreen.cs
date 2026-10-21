using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    /// <summary>群成员和商城附件共用搜索、分类、头像与可见行复用。</summary>
    private void PeoplePicker(VBoxContainer box, IReadOnlyList<CareerPerson> candidates, HashSet<string> selected, bool single, Action changed, int height = 220)
    {
        var d = ViewData; string search = "", filter = "全部";
        var opponents = d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i);
        var authors = CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i);
        var familiar = d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)
            .Concat(d.Life.Mailbox.Relations.Keys).Concat(GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)).ToHashSet();
        var searchBox = new LineEdit { Name = "RecipientSearch", PlaceholderText = "搜索人物名称", CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(searchBox);
        var filters = new HFlowContainer(); filters.AddThemeConstantOverride("h_separation", 6); filters.AddThemeConstantOverride("v_separation", 6); box.AddChild(filters);
        var scroll = new ScrollContainer { Name = "RecipientScroll", CustomMinimumSize = new(0, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
        var list = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(list);
        var count = Text("", 14, CareerVisuals.Teal); box.AddChild(count);
        CareerPerson[] people = []; var rows = new List<(HBoxContainer Row, CheckBox Check)>(); const int rowHeight = 64;
        void ShowRows()
        {
            using var timing = UiPerformance.Measure(UiPerformance.Work.MemberRows);
            int first = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1));
            int visible = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(height, scroll.Size.Y) / rowHeight) + 1);
            while (rows.Count < visible)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 10); list.AddChild(row);
                var check = new CheckBox { SizeFlagsHorizontal = SizeFlags.ExpandFill, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis };
                check.AddThemeFontSizeOverride("font_size", 17); check.AddThemeStyleboxOverride("normal", CareerVisuals.Box("172c3b", "324e60", 6, 8)); check.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("2a4854", "70d4bc", 6, 8));
                row.AddChild(check); rows.Add((row, check));
                check.Toggled += value =>
                {
                    string id = check.GetMeta("person").AsString();
                    if (value) { if (single) selected.Clear(); selected.Add(id); } else selected.Remove(id);
                    foreach (var other in rows) other.Check.SetPressedNoSignal(selected.Contains(other.Check.GetMeta("person", "").AsString()));
                    count.Text = "已选择 " + selected.Count + " 人"; changed();
                };
            }
            for (int i = 0; i < rows.Count; i++)
            {
                var (row, check) = rows[i]; row.Visible = i < visible; if (i >= visible) continue;
                var person = people[first + i];
                if (check.GetMeta("person", "").AsString() != person.Id)
                {
                    foreach (var old in row.GetChildren().OfType<Control>().Where(c => c != check).ToArray()) { row.RemoveChild(old); old.QueueFree(); }
                    var avatar = Avatar(d, person.Id, 38, false); row.AddChild(avatar); row.MoveChild(avatar, 0);
                    check.Name = "Recipient_" + person.Id; check.SetMeta("person", person.Id); check.Text = person.PublicName + " · " + person.Role;
                    check.TooltipText = person.PublicName + " · " + person.Role + " · 好感 " + PrivateMessages.Favour(d, person.Id); PickerRing(row, d, person.Id);
                }
                check.SetPressedNoSignal(selected.Contains(person.Id)); row.Position = new(0, (first + i) * rowHeight); row.Size = new(list.Size.X, rowHeight - 8);
            }
        }
        void Refresh()
        {
            using var timing = UiPerformance.Measure(UiPerformance.Work.MemberFilter);
            people = candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId, "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true })
                .OrderBy(p => filter == "熟悉的人" ? -PrivateMessages.Favour(d, p.Id) : filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0).ToArray();
            list.CustomMinimumSize = new(0, people.Length * rowHeight); scroll.ScrollVertical = 0; ShowRows();
            count.Text = people.Length == 0 ? "暂无匹配人物，请调整搜索或分类。" : "已选择 " + selected.Count + " 人 · 共 " + people.Length + " 人";
        }
        foreach (string f in new[] { "全部", "熟悉的人", "同俱乐部", "近期对手", "近期发帖回帖者" })
        {
            var button = FilterButton(f, f == filter, () => { filter = f; foreach (var b in filters.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == f); Refresh(); }, 0);
            button.ToggleMode = true; button.SetPressedNoSignal(f == filter); button.AddThemeFontSizeOverride("font_size", 14); button.CustomMinimumSize = new(0, 34); filters.AddChild(button);
        }
        searchBox.TextChanged += value => { search = value.Trim(); Refresh(); }; scroll.GetVScrollBar().ValueChanged += _ => ShowRows(); list.Resized += ShowRows; scroll.Resized += ShowRows; Refresh();
    }
}
