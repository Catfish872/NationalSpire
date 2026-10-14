using Godot;

namespace NationalSpire;

// 缓存控件，不缓存人物、帖子或权限；每次展示都重新绑定当前资料。
internal partial class CareerListCache : Control
{
    internal sealed class ProfileRow
    {
        internal required PanelContainer Card;
        internal required Label Role, RealName, Character, Rating;
        internal required Button Name;
        internal required CareerAvatar Avatar;
        internal Action? Open;
    }
    internal readonly List<ProfileRow> Profiles = [];
    private MarketTerminal? _market;
    internal MarketTerminal Market
    {
        get { if (_market == null) { _market = new MarketTerminal(); AddChild(_market); } return _market; }
    }
    private bool _idle;
    private string? _glyphs;
    private int _glyphPosition;
    private int _iconPosition;
    private int _relicPosition;
    internal static CareerListCache For(Node menu)
    {
        var existing = menu.GetChildren().OfType<CareerListCache>().FirstOrDefault();
        if (existing != null) return existing;
        var cache = new CareerListCache { Name = "NationalSpireListCache", Visible = false, Theme = CareerVisuals.CreateTheme(), _idle = true };
        menu.AddChild(cache); return cache;
    }
    public override void _Process(double delta)
    {
        // 主菜单空闲时逐帧准备空控件，不读取生涯，不保存，不修改字体资源。
        if (!_idle || CareerScreen.Current != null || Coop.CoopScreen.Current != null) return;
        if (!Market.Prepare(2)) return;
        if (_iconPosition < LifestyleArt.Sections.Length) { LifestyleArt.Icon(LifestyleArt.Sections[_iconPosition++]); return; }
        if (_relicPosition < CareerRelics.Catalog.Length) { RelicArt.Read(CareerRelics.Catalog[_relicPosition++].Id); return; }
        _glyphs ??= new string(string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray());
        if (_glyphPosition < _glyphs.Length)
        {
            int length = Math.Min(32, _glyphs.Length - _glyphPosition);
            CareerVisuals.WarmText(_glyphs.Substring(_glyphPosition, length)); _glyphPosition += length;
        }
        else if (Profiles.Count < 36) AddProfile();
        else { _idle = false; _glyphs = null; SetProcess(false); }
    }
    internal ProfileRow AddProfile()
    {
        var card = new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill, Theme = Theme };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332")); AddChild(card);
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 16); card.AddChild(box);
        Label Label(int size, Color color)
        {
            var label = new Label { MouseFilter = MouseFilterEnum.Ignore, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            label.AddThemeFontSizeOverride("font_size", size); label.AddThemeConstantOverride("line_spacing", 8); label.AddThemeColorOverride("font_color", color); return label;
        }
        var role = Label(13, CareerVisuals.Muted); box.AddChild(role);
        var line = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; line.AddThemeConstantOverride("separation", 12); box.AddChild(line);
        var avatarButton = new BroadcastButton { CustomMinimumSize = new(52, 52), SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter, FocusMode = FocusModeEnum.All };
        foreach (string state in new[] { "normal", "hover", "pressed" }) avatarButton.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        line.AddChild(avatarButton);
        var avatar = new CareerAvatar { CustomMinimumSize = new(52, 52) }; avatarButton.AddChild(avatar); avatar.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var name = new BroadcastButton { CustomMinimumSize = new(0, 48), Alignment = HorizontalAlignment.Left, SizeFlagsHorizontal = SizeFlags.ExpandFill, AutowrapMode = TextServer.AutowrapMode.WordSmart };
        name.AddThemeColorOverride("font_color", CareerVisuals.Ink); name.AddThemeFontSizeOverride("font_size", 23); line.AddChild(name);
        var realName = Label(14, CareerVisuals.Muted); box.AddChild(realName);
        var character = Label(16, CareerVisuals.Ink); box.AddChild(character);
        var rating = Label(14, CareerVisuals.Gold); box.AddChild(rating);
        var row = new ProfileRow { Card = card, Role = role, Name = name, RealName = realName, Character = character, Rating = rating, Avatar = avatar };
        name.Pressed += () => row.Open?.Invoke(); avatarButton.Pressed += () => row.Open?.Invoke();
        avatarButton.MouseEntered += () => avatar.Modulate = new Color(1.15f, 1.15f, 1.15f);
        avatarButton.MouseExited += () => avatar.Modulate = Colors.White;
        Profiles.Add(row); return row;
    }
    internal void Release()
    {
        if (_market != null)
        {
            _market.Unbind(); _market.Hide();
            if (_market.GetParent() != this) _market.Reparent(this);
        }
        foreach (var row in Profiles.Where(r => r.Card.GetParent() != this))
        { row.Open = null; row.Card.Hide(); row.Card.Reparent(this); }
    }

}

public partial class CareerScreen
{
    private CareerListCache? _listCache;
    private void AddProfileCards(CareerData data, GridContainer grid, IEnumerable<CareerPerson> people)
    {
        int index = 0;
        foreach (var person in people)
        {
            var row = index < _listCache!.Profiles.Count ? _listCache.Profiles[index] : _listCache.AddProfile(); index++;
            string id = person.Id; row.Open = () => OpenPerson(id);
            row.Role.Text = CareerMoney.Display(person.Role + "  /  " + person.Country + "  ·  " + IdentityGender.Of(data, id));
            row.Name.Text = CareerMoney.Display(person.PublicName + "   ↗");
            row.RealName.Text = CareerMoney.Display(person.Name); row.RealName.Visible = person.Handle.Length > 0 && person.Name.Length > 0;
            row.Character.Text = CareerMoney.Display(person.Character + " / " + EsportsWorld.ClubName(data, person.ClubId));
            row.Rating.Text = $"最高进阶 {person.MaxAscension}    ·    {person.Rating} 分";
            row.Avatar.PersonId = id; row.Avatar.Art = CareerAvatars.ForPerson(data, id); row.Avatar.Identity = AvatarHonors.ForPerson(data, id);
            row.Avatar.Modulate = Colors.White;
            ((Control)row.Avatar.GetParent()).TooltipText = CareerEngine.DisplayName(data, id) + " · " + row.Avatar.Identity.Description + "\n查看人物档案";
            row.Card.Reparent(grid); row.Card.Show();
        }
    }
}
