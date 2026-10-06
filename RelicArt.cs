using Godot;

namespace NationalSpire;

internal static class RelicArt
{
    private static readonly Dictionary<string, Texture2D> Cache = [];
    internal static Texture2D? Read(string id)
    {
        if (Cache.TryGetValue(id, out var cached) && GodotObject.IsInstanceValid(cached)) return cached;
        string name = id.ToLowerInvariant();
        foreach (string path in new[] { $"res://images/relics/{name}.png", $"res://images/atlases/relic_atlas.sprites/{name}.tres" })
        {
            try { if (ResourceLoader.Exists(path) && ResourceLoader.Load<Texture2D>(path) is { } texture) return Cache[id] = texture; }
            catch (Exception e) { Diagnostics.Error("figurine.art." + id, e); }
        }
        return null;
    }
}
