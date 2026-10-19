using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private ChatContactPreferences _contactPreferences = new();
    private Control? _contactMenu;
    private void LoadContactPreferences()
    {
        try { _contactPreferences = JsonSerializer.Deserialize<ChatContactPreferences>(ChatPreferences.GetValue(ChatPreferenceKey, "contacts", "{}").AsString()) ?? new(); }
        catch { _contactPreferences = new(); }
        _contactPreferences.Pinned ??= []; _contactPreferences.Hidden ??= [];
    }
    private void SaveContactPreferences()
    {
        ChatPreferences.SetValue(ChatPreferenceKey, "contacts", JsonSerializer.Serialize(_contactPreferences)); WriteChatPreferences();
        _privateListSignature = ""; RefreshPrivateList();
    }
    private void CloseContactMenu()
    {
        if (IsInstanceValid(_contactMenu)) { _contactMenu!.Hide(); _contactMenu.QueueFree(); }
        _contactMenu = null;
    }
    private void ContactMenu(Vector2 position, Action<VBoxContainer> contents, int width = 216)
    {
        CloseContactMenu();
        var overlay = new Control { Name = "ContactMenu", MouseFilter = MouseFilterEnum.Stop, ZIndex = 42 }; _contactMenu = overlay;
        _privateOverlay!.AddChild(overlay); overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        overlay.GuiInput += e => { if (e is InputEventMouseButton { Pressed: true }) { overlay.AcceptEvent(); CloseContactMenu(); } };
        var panel = new PanelContainer { Name = "ContactMenuPanel", MouseFilter = MouseFilterEnum.Stop }; overlay.AddChild(panel);
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192d3e", "526d80", 6, 4));
        var box = new VBoxContainer { CustomMinimumSize = new(width, 0) }; box.AddThemeConstantOverride("separation", 2); panel.AddChild(box); contents(box);
        var size = panel.GetCombinedMinimumSize();
        panel.Position = new(Math.Clamp(position.X, 4, Math.Max(4, overlay.Size.X - size.X - 4)), Math.Clamp(position.Y, 4, Math.Max(4, overlay.Size.Y - size.Y - 4)));
    }
    private Button ContactMenuItem(string text, Action action, bool check = false)
    {
        Button button = check ? new ContactMenuCheck() : new Button();
        button.Text = text; button.CustomMinimumSize = new(0, 36); button.Alignment = HorizontalAlignment.Left; button.FocusMode = FocusModeEnum.None;
        button.AddThemeFontSizeOverride("font_size", 16);
        foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_hover_pressed_color", "font_focus_color" }) button.AddThemeColorOverride(state, _ink);
        foreach (string state in new[] { "normal", "focus", "hover", "pressed", "hover_pressed" })
            button.AddThemeStyleboxOverride(state, new StyleBoxFlat { BgColor = state is "normal" or "focus" || check && state == "pressed" ? Colors.Transparent : new Color("375468"),
                ContentMarginLeft = 12, ContentMarginRight = check ? 38 : 12, ContentMarginTop = 6, ContentMarginBottom = 6 });
        button.Pressed += action; return button;
    }
    private void ContactActions(string id, bool group, Vector2 position)
    {
        string key = group ? "group:" + id : id;
        ContactMenu(position, box =>
        {
            box.AddChild(ContactMenuItem(_contactPreferences.Pinned.Contains(key) ? "取消置顶" : "置顶", () => { _contactPreferences.Pin(key); SaveContactPreferences(); CloseContactMenu(); }));
            box.AddChild(ContactMenuItem(_contactPreferences.Hidden.Contains(key) ? "取消隐藏" : "隐藏", () => { _contactPreferences.Hide(key); SaveContactPreferences(); CloseContactMenu(); }));
        }, 132);
    }
    private void ContactSort(Control anchor)
    {
        ContactMenu(anchor.GlobalPosition + new Vector2(0, anchor.Size.Y + 6) - _privateOverlay!.GlobalPosition, box =>
        {
            var buttons = new Dictionary<string, Button>();
            void Highlight()
            {
                foreach (var (id, button) in buttons)
                    ((StyleBoxFlat)button.GetThemeStylebox("normal")).BgColor = _contactPreferences.Sort == id ? new Color("2b4355") : Colors.Transparent;
            }
            foreach (var (id, label) in new[] { ("favour", "按好感度"), ("time", "按时间"), ("name", "按首字母"), ("type", "按类别") })
            {
                bool nextReverse = false;
                var button = ContactMenuItem(label + "正序", () =>
                {
                    _contactPreferences.Sort = id; _contactPreferences.Reverse = nextReverse; nextReverse = !nextReverse;
                    buttons[id].Text = label + (nextReverse ? "倒序" : "正序"); SaveContactPreferences(); Highlight();
                });
                button.Name = "ContactSort_" + id; buttons[id] = button; box.AddChild(button);
            }
            Highlight();
            var hidden = ContactMenuItem("展示隐藏的聊天", () => { }, true); hidden.Name = "ShowHiddenChats"; hidden.ButtonPressed = _contactPreferences.ShowHidden; box.AddChild(hidden);
            hidden.Toggled += value => { _contactPreferences.ShowHidden = value; SaveContactPreferences(); };
            var relationships = ContactMenuItem("展示人物关系图标", () => { }, true); relationships.Name = "ShowContactRelationships"; relationships.ButtonPressed = _contactPreferences.ShowRelationships; box.AddChild(relationships);
            relationships.Toggled += value => { _contactPreferences.ShowRelationships = value; SaveContactPreferences(); };
        });
    }
    private void BuildContactSearch(VBoxContainer sidebar)
    {
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 6); sidebar.AddChild(row);
        var search = new LineEdit { Name = "ContactSearch", PlaceholderText = "搜索选手或群聊", CustomMinimumSize = new(216, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(search);
        foreach (string state in new[] { "normal", "focus" })
        {
            var style = (StyleBox)search.GetThemeStylebox(state).Duplicate(); style.ContentMarginTop = style.ContentMarginBottom = 8;
            search.AddThemeStyleboxOverride(state, style);
        }
        search.TextChanged += value => { _privateQuery = value; _privateListSignature = ""; RefreshPrivateList(); };
        var sort = PrivateButton("", () => { }, 42); sort.Name = "ContactSort"; sort.TooltipText = "聊天排序"; sort.Pressed += () => ContactSort(sort); row.AddChild(sort);
        var icon = new ContactSortIcon { MouseFilter = MouseFilterEnum.Ignore }; sort.AddChild(icon); icon.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
    }
}
public partial class ContactMenuCheck : Button
{
    public ContactMenuCheck() { ToggleMode = true; Toggled += _ => QueueRedraw(); Resized += QueueRedraw; }
    public override void _Draw()
    {
        var origin = new Vector2(Size.X - 28, (Size.Y - 16) / 2);
        DrawRect(new Rect2(origin, new(16, 16)), new Color("b6cad4"), false, 1.2f);
        if (ButtonPressed) DrawPolyline([origin + new Vector2(3, 8), origin + new Vector2(7, 12), origin + new Vector2(13, 4)], CareerVisuals.Teal, 2, true);
    }
}
public partial class ContactSortIcon : Control
{
    public override void _Draw()
    {
        var c = Size / 2; var ink = new Color("dce7ee");
        void Line(float x, float y, float a, float b) => DrawLine(c + new Vector2(x, y), c + new Vector2(a, b), ink, 1.8f, true);
        Line(-9, -8, -9, 8); Line(-13, 4, -9, 8); Line(-9, 8, -5, 4);
        Line(-1, -7, 12, -7); Line(-1, 0, 9, 0); Line(-1, 7, 6, 7);
    }
}
