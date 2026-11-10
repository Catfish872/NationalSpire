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
        var recent = PlayerArchive.Read().Recent.FirstOrDefault();
        if (recent != null)
        {
            var available = GameBridge.Characters();
            foreach (var player in recent.Players)
            {
                string character = player.Character.ToString();
                if (available.Any(c => c.Id.ToString().Equals(character, StringComparison.OrdinalIgnoreCase))) return character;
            }
        }
        return "IRONCLAD";
    }
    public static int HomeCardVariation(CareerData data) =>
        data.HumanIds.Count > 0 ? CareerEngine.StableHash($"{data.WorldId}:home-card:{data.Results.LastOrDefault()?.MatchId}:{data.SelectedCharacter}") :
        CareerEngine.StableHash($"{data.WorldId}:home-card:{PlayerArchive.Read().Recent.FirstOrDefault()?.StartTime ?? 0}");
    public static AvatarArt ForPerson(CareerData data, string personId)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Avatar);
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

// Both the native option button and its popup draw the same framed portrait as a character tile.
internal partial class CareerAvatarIcon : Texture2D
{
    internal const int Pixels = 48;
    internal AvatarArt Art { get; init; } = new(null, CareerVisuals.Teal, "");
    private StyleBoxFlat? _frame;
    public override int _GetWidth() => Pixels;
    public override int _GetHeight() => Pixels;
    public override bool _HasAlpha() => true;
    public override void _Draw(Rid canvas, Vector2 pos, Color modulate, bool transpose) =>
        _DrawRect(canvas, new Rect2(pos, new Vector2(Pixels, Pixels)), false, modulate, transpose);
    public override void _DrawRect(Rid canvas, Rect2 rect, bool tile, Color modulate, bool transpose)
    {
        _frame ??= CareerAvatar.PortraitFrame(Art);
        _frame.Draw(canvas, rect);
        CareerAvatar.DrawFace(canvas, rect, rect.Grow(-CareerAvatar.ArtworkInset * rect.Size.X / Pixels), Art, modulate);
    }
}

public partial class CareerAvatar : Control
{
    internal const float ArtworkInset = 4;
    private StyleBoxFlat? _frame;
    public string PersonId { get; set; } = "";
    public bool Simplified { get; init; }
    private AvatarIdentity? _identity;
    public AvatarIdentity? Identity { get => _identity; set { _identity = value; _frame = null; QueueRedraw(); } }
    private AvatarArt _art = new(null, CareerVisuals.Teal, "");
    public AvatarArt Art { get => _art; set { _art = value; _frame = null; QueueRedraw(); } }
    internal static StyleBoxFlat PortraitFrame(AvatarArt art, AvatarIdentity? identity = null, bool simplified = false) =>
        CareerVisuals.Box("0b1b22", identity?.UseOathFrame == true || identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat"
            ? "00000000" : identity?.DisplayFrame.Color ?? art.Accent.ToHtml(), simplified ? 3 : 8, 0);

    private static Rect2 PortraitRegion(Texture2D texture)
    {
        var size = texture.GetSize();
        var square = Vector2.One * Math.Min(size.X, size.Y);
        return new Rect2((size - square) / 2, square);
    }
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        var bounds = new Rect2(Vector2.Zero, Size);
        _frame ??= PortraitFrame(Art, Identity, Simplified);
        float inset = Identity?.UseOathFrame == true || Identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat" ? Math.Min(Size.X, Size.Y) * .09f
            : Identity is { DisplayFrame.Grade: > 0 } framed ? Math.Min(Size.X, Size.Y) * (framed.DisplayFrame.Grade >= 6 ? .14f : .105f) : Simplified ? Math.Min(2, Size.X * .06f) : ArtworkInset;
        var inner = bounds.Grow(-inset);
        DrawStyleBox(_frame, Identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat" ? inner : bounds);
        DrawFace(GetCanvasItem(), bounds, inner, Art, Colors.White);
        if (Identity is { } identity) DrawHonors(identity);
    }

    internal static void DrawFace(Rid canvas, Rect2 bounds, Rect2 inner, AvatarArt art, Color modulate)
    {
        if (art.Texture is { } texture && AvatarAssets.Usable(texture))
        {
            texture.DrawRectRegion(canvas, inner, PortraitRegion(texture), modulate);
            return;
        }
        var center = bounds.GetCenter();
        var size = bounds.Size;
        var color = art.Accent * modulate;
        RenderingServer.CanvasItemAddCircle(canvas, center + new Vector2(0, -size.Y * .15f), size.X * .14f, color);
        Span<Vector2> shoulders = stackalloc Vector2[24];
        var origin = center + new Vector2(0, size.Y * .33f);
        for (int i = 0; i < shoulders.Length; i++)
            shoulders[i] = origin + Vector2.FromAngle(Mathf.Pi + Mathf.Pi * i / (shoulders.Length - 1)) * (size.X * .27f);
        RenderingServer.CanvasItemAddPolyline(canvas, shoulders, [color], Math.Max(3, size.X * .1f), true);
    }

    private void DrawHonors(AvatarIdentity identity)
    {
        var color = new Color(identity.UseOathFrame ? "dce6f1" : identity.DisplayFrame.Color);
        int grade = identity.DisplayFrame.Grade;
        float w = Size.X, h = Size.Y;
        if (identity.UseOathFrame) DrawTextureRect(AffectionArt.Texture("oath-frame"), new Rect2(-Size * .1f, Size * 1.2f), false);
        else if (identity.SelectedFrame is "friend" or "intimate" or "lover" or "cat") DrawTextureRect(AffectionArt.Texture("frame-" + identity.SelectedFrame), new Rect2(Vector2.Zero, Size), false);
        else if (grade > 0) DrawMetalFrame(identity.DisplayFrame);
        float radius = Math.Clamp(w * .175f, 7, 17);
        if (identity.Ascension >= 0)
        {
            var center = new Vector2(w - radius - 1, h - radius - 1);
            DrawCircle(center, radius, new Color("06101c"));
            DrawArc(center, radius - 1, 0, Mathf.Tau, 32, color, Math.Max(1.5f, radius * .16f), true);
            DrawArc(center, radius - 3, Mathf.Pi, Mathf.Tau * .92f, 16, color.Lightened(.35f), 1, true);
            string number = identity.Ascension.ToString(System.Globalization.CultureInfo.InvariantCulture);
            int fontSize = (int)(radius * 1.35f);
            var font = GetThemeDefaultFont();
            var size = font.GetStringSize(number,fontSize:fontSize);
            DrawString(font,center + new Vector2(-size.X/2,(font.GetAscent(fontSize)-font.GetDescent(fontSize))/2),
                number,fontSize:fontSize,modulate:Colors.White);
        }
        if (identity.Role.Length == 0 || identity.SelectedFrame == "cat") return;
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
    private Control Avatar(CareerData data, string personId, int size = 52, bool clickable = true, Action? open = null)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.AvatarControl);
        var picture = new CareerAvatar { PersonId = personId, CustomMinimumSize = new Vector2(size, size),
            SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter };
        if (!clickable) { BindPortrait(data, personId, picture); return picture; }
        var button = new BroadcastButton { CustomMinimumSize = new Vector2(size, size), SizeFlagsHorizontal = SizeFlags.ShrinkBegin,
            SizeFlagsVertical = SizeFlags.ShrinkCenter, FocusMode = FocusModeEnum.All };
        BindPortrait(data, personId, picture, button);
        foreach (string state in new[] { "normal", "hover", "pressed" }) button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        button.AddChild(picture); picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        button.MouseEntered += () => picture.Modulate = new Color(1.15f, 1.15f, 1.15f);
        button.MouseExited += () => picture.Modulate = Colors.White;
        button.Pressed += open ?? (() => OpenPerson(personId));
        return button;
    }
    private static void BindPortrait(CareerData data, string id, CareerAvatar picture, Button? button = null)
    {
        var art = CareerAvatars.ForPerson(data, id);
        var identity = AvatarHonors.ForPerson(data, id);
        if (picture.Art != art) picture.Art = art;
        if (picture.Identity != identity) picture.Identity = identity;
        if (button == null) picture.TooltipText = identity.Description;
        else button.TooltipText = CareerEngine.DisplayName(data, id) + " · " + identity.Description + "\n查看人物档案";
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
