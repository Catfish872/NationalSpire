using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void AddMentionPicker(TextEdit editor, VBoxContainer parent)
    {
        var panel = new PanelContainer { Name = "MentionSuggestions", Visible = false, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102431", "7294aa", 8, 12)); parent.AddChild(panel);
        var list = new VBoxContainer(); list.AddThemeConstantOverride("separation", 6); panel.AddChild(list);
        List<CareerPerson> people = []; List<Button> buttons = []; int selected = 0, at = -1, line = 0; bool choosing = false;
        void Choose(int index)
        {
            if (index < 0 || index >= people.Count || at < 0) return;
            choosing = true;
            editor.Select(line, at, line, editor.GetCaretColumn());
            editor.InsertTextAtCaret(CommunityMentions.Token(ViewData, people[index]) + " ");
            panel.Hide(); editor.GrabFocus(); choosing = false;
        }
        void Highlight()
        {
            for (int i = 0; i < buttons.Count; i++) buttons[i].AddThemeStyleboxOverride("normal",
                CareerVisuals.Box(i == selected ? "365369" : "102431", i == selected ? "ddc58c" : "102431", 5, 9));
        }
        void Refresh()
        {
            if (choosing) return;
            line = editor.GetCaretLine(); string before = editor.GetLine(line)[..editor.GetCaretColumn()]; at = before.LastIndexOf('@');
            string query = at < 0 ? "" : before[(at + 1)..];
            if (at < 0 || query.Any(char.IsWhiteSpace) || query.Contains('〔')) { panel.Hide(); return; }
            people = ViewData.People.Where(p => PrivateMessages.CanChat(ViewData, p.Id) &&
                (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(p => p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase)).ThenBy(p => p.PublicName).Take(6).ToList();
            CareerVisuals.ClearContent(list); buttons.Clear(); selected = 0;
            foreach (var p in people)
            {
                int index = buttons.Count;
                var button = PrivateButton(p.PublicName + "   ·   " + p.Role + "   ·   " + p.Country, () => Choose(index));
                button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.FocusMode = FocusModeEnum.None;
                list.AddChild(button); buttons.Add(button);
            }
            panel.Visible = people.Count > 0; Highlight();
        }
        editor.TextChanged += Refresh; editor.CaretChanged += Refresh;
        editor.GuiInput += ev =>
        {
            if (!panel.Visible || ev is not InputEventKey { Pressed: true } key) return;
            if (key.Keycode is Key.Up or Key.Left or Key.Down or Key.Right)
            {
                selected = (selected + (key.Keycode is Key.Up or Key.Left ? -1 : 1) + people.Count) % people.Count;
                Highlight(); editor.AcceptEvent();
            }
            else if (key.Keycode is Key.Enter or Key.KpEnter or Key.Tab) { Choose(selected); editor.AcceptEvent(); }
            else if (key.Keycode == Key.Escape) { panel.Hide(); editor.AcceptEvent(); }
        };
    }
}
