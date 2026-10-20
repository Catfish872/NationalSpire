using Godot;

namespace NationalSpire;

/// <summary>已定稿的矢量美术按层嵌入；纹理按资源名惰性缓存，进度与数字由控件绘制。</summary>
public static class AffectionArt
{
    private static readonly Dictionary<string, Texture2D> Textures = new(StringComparer.Ordinal);
    public static Texture2D Texture(string name)
    {
        if (Textures.TryGetValue(name, out var texture)) return texture;
        using var stream = typeof(AffectionArt).Assembly.GetManifestResourceStream("NationalSpire.Affection." + name + ".svg")
            ?? throw new InvalidDataException("缺少关系美术资源：" + name);
        using var reader = new StreamReader(stream);
        using var image = new Image();
        if (image.LoadSvgFromString(reader.ReadToEnd()) != Error.Ok) throw new InvalidDataException("关系美术资源无法读取：" + name);
        return Textures[name] = ImageTexture.CreateFromImage(image);
    }
    public static readonly string[] Numbers = ["c27a89", "c2bddb", "e6c98e", "a1e5dd", "d0c3f5", "ffe3ef"];
    public static readonly string[] ProgressColors = ["74324a", "c2bddb", "e6c98e", "a1e5dd", "d0c3f5", "f3a6c7"];
}

public partial class AffectionBadge : Control
{
    public PrivateRelation Relation { get; set; } = new();
    public bool Compact { get; init; }
    private int _display;
    private long _revision = -1;
    public void Bind(PrivateRelation relation)
    {
        if (ReferenceEquals(Relation, relation) && _revision == relation.Revision && _display == relation.Favour) return;
        Relation = relation; _revision = relation.Revision; SetProcess(true); QueueRedraw();
    }
    public override void _Ready()
    {
        MouseFilter = MouseFilterEnum.Ignore; SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        Resized += QueueRedraw; _display = Relation.DisplayFavour();
        SetProcess(_display != Relation.Favour);
    }
    public override void _Process(double delta)
    {
        int next = Relation.DisplayFavour();
        if (_display != next) { _display = next; QueueRedraw(); }
        if (next == Relation.Favour) SetProcess(false);
    }
    public override void _Draw()
    {
        int tier = RelationshipPresentation.Tier(_display);
        string bond = RelationshipPresentation.OathAppearance(Relation) ? "oath" : Relation.Appearance.Lover && _display >= 60 ? "lover" : "none";
        string asset = $"badge-{(bond == "lover" ? 5 : tier)}-{bond}";
        float scale = Math.Min(Size.X / (Compact ? 60 : 80), Size.Y / 68);
        var center = Size / 2;
        var bounds = new Rect2(center - new Vector2(40,34) * scale, new Vector2(80,68) * scale);
        DrawTextureRect(AffectionArt.Texture(asset + "-base"), bounds, false);
        Vector2[] line = bond == "oath"
            ? [new(-21.2f,12),new(-22.4f,-9.7f),new(0,-20.7f),new(22.4f,-9.7f),new(21.2f,12)]
            : [new(-22,13.5f),new(-24,-12),new(0,-24),new(24,-12),new(22,13.5f)];
        if (bond == "oath") for (int i=0; i<line.Length; i++) line[i].X *= .94f;
        float length = 0; for (int i=1; i<line.Length; i++) length += line[i-1].DistanceTo(line[i]);
        float remaining = length * RelationshipPresentation.Progress(_display);
        for (int i=1; i<line.Length && remaining > 0; i++)
        {
            float segment = line[i-1].DistanceTo(line[i]);
            var end = line[i-1].Lerp(line[i], Math.Min(1, remaining / segment));
            DrawLine(center + line[i-1]*scale, center + end*scale, new Color(AffectionArt.ProgressColors[tier]), 2.9f*scale, true);
            remaining -= segment;
        }
        DrawTextureRect(AffectionArt.Texture(asset + "-cover"), bounds, false);
        var font = GetThemeDefaultFont();
        int fontSize = (int)Math.Round((_display <= -100 ? 16 : _display < 0 ? 19 : _display >= 100 ? 20 : 22) * scale);
        if (Compact) fontSize = Math.Max(_display <= -100 ? 12 : 14, fontSize) - 1;
        string text = _display.ToString(System.Globalization.CultureInfo.InvariantCulture);
        var size = font.GetStringSize(text, fontSize: fontSize);
        var position = center + new Vector2(-size.X/2, (font.GetAscent(fontSize)-font.GetDescent(fontSize))/2);
        DrawString(font, position, text, fontSize: fontSize, modulate: new Color(bond == "oath" ? "662d57" : AffectionArt.Numbers[tier]));
    }
}

public partial class RelationshipIcon : Control
{
    public string Bond { get; set; } = "none";
    public bool Tight { get; init; }
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); Resized += QueueRedraw; }
    public override void _Draw()
    {
        float size = Math.Min(Size.X, Size.Y);
        var rect = new Rect2((Size-new Vector2(size,size))/2, new(size,size));
        var texture = AffectionArt.Texture("bond-" + Bond);
        if (Tight) DrawTextureRectRegion(texture, rect, new Rect2(24, 24, 144, 144));
        else DrawTextureRect(texture, rect, false);
    }
}
