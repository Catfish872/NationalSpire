using Godot;

namespace NationalSpire;

/// <summary>题材只决定画面；事件人物、故事和结果仍在开始时生成。</summary>
public static class RandomEventArt
{
    public const string UnknownIcon = "res://images/atlases/ui_atlas.sprites/map/icons/map_unknown.tres";
    private static readonly Dictionary<string, string[]> Pools = new()
    {
        ["日常"] = ["living_room", "park", "bg_cityRiver_day", "game:wood_carvings"],
        ["饮食"] = ["gourmet_street", "restaurant", "kitchen", "game:tea_master"],
        ["阅读"] = ["art_museum", "living_room", "game:self_help_book", "game:waterlogged_scriptorium"],
        ["户外"] = ["park", "bg_cityRiver_day", "manor_exterior", "game:dense_vegetation"],
        ["夜色"] = ["bg_cityRiver_night", "aurora_street", "bg_cityRiver_evening"],
        ["训练"] = ["training_room", "championship_contest_venue", "game:battleworn_dummy"],
        ["手作"] = ["training_room", "art_museum", "game:wood_carvings", "game:tinker_time"],
        ["交易"] = ["auction", "gourmet_street", "game:relic_trader"],
        ["相聚"] = ["living_room", "restaurant", "park", "game:round_tea_party"],
        ["音乐"] = ["concert_hall", "livehouse", "ktv"],
    };
    public static string Category(string seed) => RandomEventSeeds.Category(seed);
    public static string Category(RandomEventRecord e) => e.Category.Length > 0 ? e.Category : Category(e.Seed);
    public static string Select(RandomEventRecord e)
    {
        if (e.Seed.Length == 0) return "";
        var pool = Pools[Category(e)];
        return pool[(int)((uint)CareerEngine.StableHash(e.Id + ":art:" + e.Seed) % pool.Length)];
    }
    public static Texture2D? Load(string id)
    {
        if (id.Length == 0) id = "bg_cityRiver_evening";
        if (id.StartsWith("game:", StringComparison.Ordinal))
        {
            string path = "res://images/events/" + id[5..] + ".png";
            return ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null;
        }
        var entry = DateSceneBackgrounds.Read(out _).FirstOrDefault(b => b.Id == id);
        return entry == null ? null : DateSceneView.CreateBackground(entry.Image);
    }
}

/// <summary>日历、入口与等待画面统一绘制同一问号纹章。</summary>
public partial class EventEmblem : Control
{
    private Texture2D? _icon;
    public override void _Ready()
    {
        MouseFilter = MouseFilterEnum.Ignore;
        if (ResourceLoader.Exists(RandomEventArt.UnknownIcon))
        {
            var icon = GD.Load<Texture2D>(RandomEventArt.UnknownIcon);
            _icon = icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon;
        }
        Resized += QueueRedraw;
    }
    public override void _Draw()
    {
        var c = Size / 2; float r = Math.Min(Size.X, Size.Y) * .43f;
        var gold = new Color("c7ae7a");
        DrawCircle(c, r, new Color("182d3b"));
        DrawArc(c, r, -.3f, Mathf.Pi * .82f, 30, gold, 1, true);
        DrawArc(c, r, Mathf.Pi - .3f, Mathf.Pi * 1.82f, 30, gold, 1, true);
        foreach (int sign in new[] { -1, 1 })
        {
            var p = c + new Vector2(sign * r, 0);
            DrawColoredPolygon([p + new Vector2(-3, 0), p + new Vector2(0, -3), p + new Vector2(3, 0), p + new Vector2(0, 3)], CareerVisuals.Teal);
        }
        if (_icon != null) DrawTextureRect(_icon, new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f), false, gold);
        else
        {
            var font = GetThemeDefaultFont(); int size = (int)(r * 1.4f);
            var measure = font.GetStringSize("?", fontSize: size);
            DrawString(font, c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), "?", fontSize: size, modulate: gold);
        }
    }
}
