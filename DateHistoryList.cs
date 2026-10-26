using Godot;

namespace NationalSpire;

/// <summary>A displayed player message or the visible segments of one AI response.</summary>
public sealed record DateHistoryEntry(string TurnId, string Text, bool Reply);

/// <summary>Shared history presentation for live dates and recorded playback; deletion is delegated to the controller.</summary>
public partial class DateHistoryList : ScrollContainer
{
    private readonly VBoxContainer _rows = new() { SizeFlagsHorizontal = SizeFlags.ExpandFill };
    private readonly Dictionary<(string Turn, bool Reply), (HBoxContainer Row, RichTextLabel Text)> _cache = [];
    private readonly StyleBoxFlat _normal = CareerVisuals.Box("00000000", "00000000", 6, 10);
    private readonly StyleBoxFlat _highlighted = CareerVisuals.Box("29485970", "00000000", 6, 10);
    private Action<string>? _delete;
    private Font? _font;
    private int _size;
    public override void _Ready()
    {
        HorizontalScrollMode = ScrollMode.Disabled; FocusMode = FocusModeEnum.All;
        _rows.AddThemeConstantOverride("separation", 18); AddChild(_rows);
    }
    public void Populate(IReadOnlyList<DateHistoryEntry> entries, Font font, int size, Action<string>? delete)
    {
        bool appearanceChanged = _font != font || _size != size;
        _font = font; _size = size; _delete = delete;
        if (entries.Count == 0) entries = [new("", "约会开始后的对话会显示在这里。", false)];
        var keys = entries.Select(e => (e.TurnId, e.Reply)).ToHashSet();
        foreach (var key in _cache.Keys.Where(k => !keys.Contains(k)).ToArray())
        {
            var old = _cache[key].Row; old.Hide(); old.Name = "Retired_" + old.GetInstanceId(); old.QueueFree(); _cache.Remove(key);
        }
        int order = 0;
        foreach (var entry in entries)
        {
            if (_cache.TryGetValue((entry.TurnId, entry.Reply), out var cached))
            {
                if (cached.Text.Text != entry.Text) cached.Text.Text = entry.Text;
                if (appearanceChanged) { cached.Text.AddThemeFontOverride("normal_font", font); cached.Text.AddThemeFontSizeOverride("normal_font_size", size); }
                if (cached.Row.GetIndex() != order) _rows.MoveChild(cached.Row, order);
                order++; continue;
            }
            var row = new HBoxContainer { Name = entry.Reply ? "DateHistoryReply" : "DateHistoryPlayer", SizeFlagsHorizontal = SizeFlags.ExpandFill };
            row.SetMeta("turn", entry.TurnId); row.AddThemeConstantOverride("separation", 12);
            var rail = new VBoxContainer { CustomMinimumSize = new(40, 0) }; row.AddChild(rail);
            var guide = new DateHistoryGuide { SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 18), MouseFilter = MouseFilterEnum.Ignore, Visible = entry.Reply };
            rail.AddChild(guide);
            var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(panel);
            panel.AddThemeStyleboxOverride("panel", _normal);
            var text = new RichTextLabel { Text = entry.Text, BbcodeEnabled = false, FitContent = true, ScrollActive = false, SelectionEnabled = true, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            text.AddThemeFontOverride("normal_font", font); text.AddThemeFontSizeOverride("normal_font_size", size);
            text.AddThemeColorOverride("default_color", CareerVisuals.Ink); panel.AddChild(text);
            if (entry.Reply && delete != null)
            {
                var erase = new Button { Name = "DateHistoryErase", CustomMinimumSize = new(40, 38), MouseDefaultCursorShape = CursorShape.PointingHand };
                foreach (string state in new[] { "normal", "hover", "pressed", "focus" }) erase.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
                var icon = new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore, Modulate = new Color(1, 1, 1, .55f) }; erase.AddChild(icon); rail.AddChild(erase);
                void Highlight(bool active)
                {
                    guide.Highlighted = active; guide.QueueRedraw(); icon.Modulate = new Color(1, 1, 1, active ? 1 : .55f);
                    panel.AddThemeStyleboxOverride("panel", active ? _highlighted : _normal);
                }
                erase.MouseEntered += () => Highlight(true); erase.MouseExited += () => Highlight(erase.HasFocus());
                erase.FocusEntered += () => Highlight(true); erase.FocusExited += () => Highlight(false);
                erase.Pressed += () => _delete?.Invoke(entry.TurnId);
            }
            _rows.AddChild(row); _rows.MoveChild(row, order++); _cache[(entry.TurnId, entry.Reply)] = (row, text);
        }
    }
}

public partial class DateHistoryGuide : Control
{
    public bool Highlighted { get; set; }
    public override void _Draw() => DrawLine(new(Size.X / 2, 7), new(Size.X / 2, Math.Max(8, Size.Y - 4)),
        new Color(.66f, .86f, .9f, Highlighted ? .95f : .45f), 2, true);
}
