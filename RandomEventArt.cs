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
    public static string Category(RandomEventRecord e) => e.Category is { Length: > 0 } category ? category : Category(e.Seed ?? "");
    public static string Select(RandomEventRecord e)
    {
        if (string.IsNullOrEmpty(e.Seed)) return "";
        if (!Pools.TryGetValue(Category(e), out var pool)) pool = Pools[Category(e.Seed)];
        return pool[(int)((uint)CareerEngine.StableHash(e.Id + ":art:" + e.Seed) % pool.Length)];
    }
    private static readonly SemaphoreSlim DecodeSlot = new(1);
    internal static bool IsGameArt(string id) => id.StartsWith("game:", StringComparison.Ordinal);
    private static string GamePath(string id) => "res://images/events/" + id[5..] + ".png";

    private static Image? ReadPixels(string id, CancellationToken token)
    {
        token.ThrowIfCancellationRequested();
        if (id.Length == 0) id = "bg_cityRiver_evening";
        var entry = DateSceneBackgrounds.Read(out _).FirstOrDefault(b => b.Id == id);
        token.ThrowIfCancellationRequested();
        var pixels = entry?.ReadPixels();
        if (!token.IsCancellationRequested) pixels?.GenerateMipmaps();
        return pixels;
    }

    public static Texture2D? Load(string id)
    {
        if (IsGameArt(id))
        {
            string path = GamePath(id);
            return ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null;
        }
        using var pixels = ReadPixels(id, CancellationToken.None);
        return pixels == null ? null : ImageTexture.CreateFromImage(pixels);
    }

    internal static async Task<Texture2D?> LoadAsync(string id, SceneTree tree, CancellationToken token)
    {
        if (IsGameArt(id))
        {
            string path = GamePath(id);
            if (!ResourceLoader.Exists(path) || ResourceLoader.LoadThreadedRequest(path, "Texture2D") != Error.Ok) return null;
            while (ResourceLoader.LoadThreadedGetStatus(path) == ResourceLoader.ThreadLoadStatus.InProgress)
                await tree.ToSignal(tree, SceneTree.SignalName.ProcessFrame);
            return ResourceLoader.LoadThreadedGet(path) as Texture2D;
        }
        await DecodeSlot.WaitAsync(token);
        try
        {
            // Decode and build mipmaps on a private CPU image. Upload only a still-visible request on the Godot thread.
            using var pixels = await Task.Run(() => ReadPixels(id, token), token);
            token.ThrowIfCancellationRequested();
            return pixels == null ? null : ImageTexture.CreateFromImage(pixels);
        }
        finally { DecodeSlot.Release(); }
    }
}

internal partial class EventArtPicture : TextureRect
{
    private CancellationTokenSource? _pending;
    private Texture2D? _owned;

    internal async void ShowArt(string id)
    {
        _pending?.Cancel();
        var request = _pending = new CancellationTokenSource();
        bool gameArt = RandomEventArt.IsGameArt(id);
        try
        {
            var texture = await RandomEventArt.LoadAsync(id, GetTree(), request.Token);
            if (request.IsCancellationRequested || !IsInstanceValid(this) || IsQueuedForDeletion())
            {
                if (!gameArt) texture?.Dispose();
                return;
            }
            SetArt(texture, gameArt);
        }
        catch (Exception e)
        {
            if (!request.IsCancellationRequested)
            {
                SetArt(null, false);
                GD.PushWarning("[NationalSpire] 际遇背景加载失败：" + e.Message);
            }
        }
        finally
        {
            if (_pending == request) _pending = null;
            request.Dispose();
        }
    }
    private void SetArt(Texture2D? texture, bool gameArt)
    {
        var previous = _owned;
        Texture = texture;
        _owned = gameArt ? null : texture;
        if (Material is ShaderMaterial material) material.SetShaderParameter("original", gameArt ? 1f : 0f);
        previous?.Dispose();
    }
    public override void _ExitTree()
    {
        _pending?.Cancel();
        SetArt(null, false);
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
