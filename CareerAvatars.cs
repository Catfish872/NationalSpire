using Godot;

namespace NationalSpire;

public sealed record AvatarArt(Texture2D? Texture, Color Accent, string Description);

public static class CareerAvatars
{
    public static string MainCharacter(CareerData data, string personId)
    {
        if (personId == "player" && data.PlayerCard is { Character.Length: > 0 } card) return card.Character;
        if (personId == "player" && data.HumanIds.Count > 0) return data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "IRONCLAD";
        if (personId != "player") return CareerEngine.Person(data, personId)?.Character ?? "";
        var available = GameBridge.Characters().Select(character => character.Id.ToString()).ToHashSet(StringComparer.OrdinalIgnoreCase);
        foreach (var player in PlayerArchive.Read().Recent.FirstOrDefault()?.Players ?? [])
        {
            string character = player.Character.ToString();
            if (available.Contains(character)) return character;
        }
        return "IRONCLAD";
    }
    public static int HomeCardVariation(CareerData data) =>
        data.HumanIds.Count > 0 ? CareerEngine.StableHash($"{data.WorldId}:home-card:{data.Results.LastOrDefault()?.MatchId}:{data.SelectedCharacter}") :
        CareerEngine.StableHash($"{data.WorldId}:home-card:{PlayerArchive.Read().Recent.FirstOrDefault()?.StartTime ?? 0}");
    public static AvatarArt ForPerson(CareerData data, string personId)
    {
        var selected = personId == "player" ? data.SelectedAvatar : data.HumanAvatars.GetValueOrDefault(personId) ?? CareerEngine.Person(data, personId)?.Avatar;
        if (AvatarImages.Read(selected) is { } custom) return custom;
        return Automatic(data, personId);
    }
    public static AvatarArt Automatic(CareerData data, string personId)
    {
        if (CameoAssets.ForPerson(CareerEngine.Person(data, personId)?.CameoId ?? "") is { } cameo) return cameo;
        // 个人视图仍有独立随机源，头像则统一使用世界和人物的真实身份。
        string id = personId == "player" && data.LocalHumanId.Length > 0 ? data.LocalHumanId : personId;
        string world = data.AvatarWorldId.Length > 0 ? data.AvatarWorldId : data.WorldId;
        int variant = CareerEngine.StableHash(world + ":avatar:" + id);
        return AvatarAssets.Load(MainCharacter(data, personId), variant, id != "player" && variant % 3 != 0);
    }
}

public partial class CareerAvatar : Control
{
    private StyleBoxFlat? _frame;
    public string PersonId { get; init; } = "";
    private AvatarIdentity? _identity;
    public AvatarIdentity? Identity { get => _identity; set { _identity = value; _frame = null; QueueRedraw(); } }
    private AvatarArt _art = new(null, CareerVisuals.Teal, "");
    public AvatarArt Art { get => _art; set { _art = value; _frame = null; QueueRedraw(); } }
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        var bounds = new Rect2(Vector2.Zero, Size);
        _frame ??= CareerVisuals.Box("0b1b22", Identity?.Frame.Color ?? Art.Accent.ToHtml(), 8, 0);
        DrawStyleBox(_frame, bounds);
        float inset = Identity is { Frame.Grade: > 0 } framed ? Math.Min(Size.X, Size.Y) * (framed.Frame.Grade >= 6 ? .14f : .105f) : 4;
        var inner = bounds.Grow(-inset);
        if (Art.Texture is { } texture && GodotObject.IsInstanceValid(texture) && texture.GetWidth() > 0 && texture.GetHeight() > 0)
        {
            // 仅取卡面中心的正方形；绘制资源，不添加拦截鼠标的子控件。
            float edge = Math.Min(texture.GetWidth(), texture.GetHeight());
            var source = new Rect2((texture.GetWidth() - edge) / 2, (texture.GetHeight() - edge) / 2, edge, edge);
            DrawTextureRectRegion(texture, inner, source);
        }
        else
        {
            var center = Size / 2;
            DrawCircle(center + new Vector2(0, -Size.Y * .15f), Size.X * .14f, Art.Accent);
            DrawArc(center + new Vector2(0, Size.Y * .33f), Size.X * .27f, Mathf.Pi, Mathf.Tau, 24, Art.Accent, Math.Max(3, Size.X * .1f), true);
        }
        if (Identity is { } identity) DrawHonors(identity);
    }
    private void DrawHonors(AvatarIdentity identity)
    {
        var color = new Color(identity.Frame.Color);
        int grade = identity.Frame.Grade;
        float w = Size.X, h = Size.Y;
        if (grade > 0) DrawMetalFrame(identity.Frame);
        float radius = Math.Clamp(w * .175f, 7, 17);
        if (identity.Ascension >= 0)
        {
            var center = new Vector2(w - radius - 1, h - radius - 1);
            DrawCircle(center, radius, new Color("06101c"));
            DrawArc(center, radius - 1, 0, Mathf.Tau, 32, color, Math.Max(1.5f, radius * .16f), true);
            DrawArc(center, radius - 3, Mathf.Pi, Mathf.Tau * .92f, 16, color.Lightened(.35f), 1, true);
            string number = identity.Ascension.ToString(); int fontSize = (int)(radius * 1.35f);
            var font = GetThemeDefaultFont(); var textSize = font.GetStringSize(number, fontSize: fontSize);
            DrawString(font, center + new Vector2(-textSize.X / 2, (font.GetAscent(fontSize) - font.GetDescent(fontSize)) / 2), number, fontSize: fontSize, modulate: Colors.White);
        }
        if (identity.Role.Length == 0) return;
        var origin = new Vector2(radius + 1, h - radius - 1);
        DrawCircle(origin, radius, new Color("0c1925"));
        DrawArc(origin, radius - 1, 0, Mathf.Tau, 24, new Color("7cc5c0"), 1, true);
        float unit = radius / 8;
        Vector2 At(float x, float y) => origin + new Vector2(x, y) * unit;
        void Line(float x, float y, float x2, float y2) => DrawLine(At(x, y), At(x2, y2), Colors.White, 1.3f, true);
        switch (identity.Role)
        {
            case "主播": DrawColoredPolygon([At(-2, -4), At(4, 0), At(-2, 4)], Colors.White); break;
            case "解说员":
                DrawLine(At(0, -4), At(0, 0), Colors.White, 3 * unit, true);
                DrawArc(At(0, 0), 3.5f * unit, 0, Mathf.Pi, 12, Colors.White, 1, true); Line(0, 3, 0, 5); Line(-2, 5, 2, 5); break;
            case "教练":
                DrawRect(new Rect2(At(-4, -4), new Vector2(8, 7) * unit), Colors.White, false, 1); Line(-2, 1, 2, -2); Line(0, 3, 0, 5); break;
            case "赛事记者": Line(-3, 3, 3, -3); Line(-3, 3, -4, 5); Line(-2, 5, 4, 5); break;
            default: Line(-3, -4, 3, -4); Line(-3, 4, 3, 4); Line(-3, -4, 3, 4); Line(3, -4, -3, 4); break;
        }
    }
}

public partial class CareerScreen
{
    private bool _choosingFrame;
    private void AvatarWardrobe(CareerData data, VBoxContainer box)
    {
        var identity = AvatarHonors.ForPerson(data, "player");
        if (!_choosingFrame) return;
        box.AddChild(Text("已解锁的头像框永久保留。", 15, _muted));
        box.AddChild(FilterButton("自动佩戴最高荣誉", data.SelectedAvatarFrame == "auto", () => ChooseFrame(data, "auto"), 235));
        var grid = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); box.AddChild(grid);
        foreach (var frame in AvatarHonors.Frames)
        {
            bool unlocked = data.AvatarFrames.ContainsKey(frame.Id);
            var panel = Card(); panel.SizeFlagsHorizontal = SizeFlags.ExpandFill; grid.AddChild(panel); var details = Inner(panel);
            var preview = new CareerAvatar { Art = CareerAvatars.ForPerson(data, "player"), Identity = new(frame, identity.Ascension, "", ""),
                CustomMinimumSize = new Vector2(64, 64), SizeFlagsHorizontal = SizeFlags.ShrinkCenter,
                Modulate = unlocked ? Colors.White : new Color(.6f, .6f, .6f) };
            details.AddChild(preview);
            var select = FilterButton(frame.Name, data.SelectedAvatarFrame == frame.Id, () => ChooseFrame(data, frame.Id), 0);
            select.Name = "AvatarFrame_" + frame.Id; select.Disabled = !unlocked; details.AddChild(select);
            details.AddChild(Text(unlocked ? data.AvatarFrames[frame.Id].Length > 0 ? data.AvatarFrames[frame.Id] : "已解锁" : frame.Requirement, 14, _muted));
        }
    }
    private void ChooseFrame(CareerData data, string frame)
    {
        if (MultiplayerCommand("frame", frame)) return;
        if (!AvatarHonors.Select(data, frame)) return;
        CareerStore.Save(data); int y = _scroll.ScrollVertical; Render(); _ = RestoreScrollAsync(y, _renderVersion);
    }
    private HBoxContainer WithCharacterAvatar(string character, Control content)
    {
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        row.AddThemeConstantOverride("separation", 12);
        row.AddChild(new CareerAvatar { Art = AvatarAssets.Load(character, 0, false),
            CustomMinimumSize = new Vector2(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        row.AddChild(content); return row;
    }
    private Control Avatar(CareerData data, string personId, int size = 52, bool clickable = true)
    {
        var art = CareerAvatars.ForPerson(data, personId);
        var identity = AvatarHonors.ForPerson(data, personId);
        var picture = new CareerAvatar { PersonId = personId, Art = art, Identity = identity, CustomMinimumSize = new Vector2(size, size),
            SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter };
        if (!clickable) { picture.TooltipText = identity.Description; return picture; }
        var button = new BroadcastButton { CustomMinimumSize = new Vector2(size, size), SizeFlagsHorizontal = SizeFlags.ShrinkBegin,
            SizeFlagsVertical = SizeFlags.ShrinkCenter, TooltipText = CareerEngine.DisplayName(data, personId) + " · " + identity.Description + "\n查看人物档案", FocusMode = FocusModeEnum.All };
        foreach (string state in new[] { "normal", "hover", "pressed" }) button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        button.AddChild(picture); picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        button.MouseEntered += () => picture.Modulate = new Color(1.15f, 1.15f, 1.15f);
        button.MouseExited += () => picture.Modulate = Colors.White;
        button.Pressed += () => OpenPerson(personId);
        return button;
    }
    private HBoxContainer WithAvatar(CareerData data, string id, Control content, int size = 52, bool clickable = true)
    {
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddThemeConstantOverride("separation", 12);
        row.AddChild(Avatar(data, id, size, clickable)); row.AddChild(content); return row;
    }
    private HBoxContainer PersonLink(CareerData data, string id, string caption, int size = 40)
    {
        var button = Button(caption, () => OpenPerson(id)); button.Alignment = HorizontalAlignment.Left;
        button.AutowrapMode = TextServer.AutowrapMode.WordSmart; button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        return WithAvatar(data, id, button, size);
    }
}
