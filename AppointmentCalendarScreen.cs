using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control AppointmentCalendar(CareerData data, int season, IEnumerable<string> participants, int selected, Action<int> choose)
    {
        var people = participants.Distinct().ToArray();
        var box = new VBoxContainer { Name = "AppointmentCalendar", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        box.AddThemeConstantOverride("separation", 12);
        var grid = new GridContainer { Columns = 7 };
        grid.AddThemeConstantOverride("h_separation", 8); grid.AddThemeConstantOverride("v_separation", 8); box.AddChild(grid);
        var details = new VBoxContainer(); details.AddThemeConstantOverride("separation", 8);
        Button? initial = null;
        for (int n = 1; n <= SeasonCalendar.Length(data, season); n++)
        {
            int date = n, absolute = SeasonCalendar.Start(data, season) + date;
            var entries = people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute)).Distinct().ToArray();
            string description = string.Join("\n", entries.Select(e => e.Description).Distinct());
            var button = new CalendarDayButton
            {
                Name = "Day" + date, Number = GameCalendar.Date(data, absolute).ToString("M/d"),
                Description = entries.Any(e => e.Occupied) ? "有安排" : entries.Length > 0 ? "可报名" : "空闲",
                Today = absolute == data.Day, Selected = date == selected, Registered = entries.Any(e => e.Occupied),
                Disabled = absolute < data.Day, TooltipText = description, CustomMinimumSize = new(96, 88)
            };
            button.Pressed += () =>
            {
                choose(date);
                foreach (var child in grid.GetChildren().OfType<CalendarDayButton>()) child.SelectDate(child == button);
            };
            grid.AddChild(button);
            if (date == selected || initial == null && !button.Disabled) initial = button;
            if (description.Length > 0) details.AddChild(Text($"{GameCalendar.Text(data, absolute)} · {description}", 14, _muted));
        }
        box.Ready += async () =>
        {
            await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
            await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
            if (IsInstanceValid(box) && box.IsInsideTree() && initial != null)
                (box.GetParent()?.GetParent() as ScrollContainer)?.EnsureControlVisible(initial);
        };
        box.AddChild(details); return box;
    }
}
