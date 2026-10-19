using Godot;

namespace NationalSpire;

/// <summary>联系人行的悬停底色、分隔线和本机置顶/隐藏标志。</summary>
public partial class ContactRowButton : Button
{
    private bool _pinned, _hidden, _selected;
    private ChatContacts.Events _events;
    public void EventIndicators(ChatContacts.Events events)
    { if (_events == events) return; _events = events; QueueRedraw(); }
    public void Bind(bool pinned, bool hidden, bool selected)
    {
        if (_pinned == pinned && _hidden == hidden && _selected == selected) return;
        _pinned = pinned; _hidden = hidden; _selected = selected; QueueRedraw();
    }
    public override void _Ready()
    {
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "focus" })
            AddThemeStyleboxOverride(state, new StyleBoxFlat { BgColor = state is "normal" or "focus" ? Colors.Transparent : new Color("294353") });
        Resized += QueueRedraw;
    }
    public override void _Draw()
    {
        if (_selected) DrawRect(new Rect2(Vector2.Zero, Size), new Color("7298af20"));
        DrawLine(new(0, Size.Y - 1), new(Size.X, Size.Y - 1), new Color("29465899"), 1, true);
        float y = 41 - (_pinned && _hidden ? 18 : 9);
        if (_pinned) { DrawTextureRect(AffectionArt.Texture("contact-pin"), new Rect2(3, y, 17, 17), false); y += 20; }
        if (_hidden) DrawTextureRect(AffectionArt.Texture("contact-hidden"), new Rect2(3, y, 17, 17), false);
        float x = 3;
        if (_events.Match) { DrawTextureRect(AffectionArt.Texture("calendar-crossed-swords"), new Rect2(x, Size.Y - 26, 17, 17), false, _events.MatchToday ? new Color("d9bd7e") : Colors.White); x += 24; }
        if (_events.Date) { DrawTextureRect(AffectionArt.Texture("calendar-date"), new Rect2(x, Size.Y - 26, 17, 17), false, _events.DateToday ? new Color("d9bd7e") : Colors.White); x += 24; }
        if (_events.Wedding) GiftRingMark.DrawDiamond(this, new Rect2(x, Size.Y - 26, 17, 17), false, _events.WeddingToday ? new Color("d9bd7e") : Colors.White);
    }
}
