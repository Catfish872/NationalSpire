using Godot;
using System.Text.Json;

namespace NationalSpire;

/// <summary>本机共用形象包；人物只保存独立设计和图片引用，图片沿用内容摘要缓存。</summary>
public static class AppearanceLibrary
{
    public sealed record Entry(string Id, string Name, bool BuiltIn);
    public sealed class Package
    {
        public string Name { get; set; } = "";
        public PortraitDesign Design { get; set; } = new();
        public Dictionary<string, Dictionary<string, string>> Outfits { get; set; } = [];
    }
    private static readonly Entry[] BuiltIns = [new("haruka", "井上遥香", true), new("charlotte", "夏洛特·赖特", true), new("alili", "阿莉莉", true)];
    public static string DirectoryPath => ProjectSettings.GlobalizePath("user://national_spire_portraits/library");
    private static string PathFor(string id) => Path.Combine(DirectoryPath, id + ".json");
    public static Entry[] List()
    {
        var entries = new List<Entry>(BuiltIns);
        if (Directory.Exists(DirectoryPath))
            foreach (string path in Directory.EnumerateFiles(DirectoryPath, "*.json"))
            {
                string id = Path.GetFileNameWithoutExtension(path);
                if (BuiltIns.Any(e => e.Id == id)) continue;
                using var json = JsonDocument.Parse(File.ReadAllText(path));
                entries.Add(new(id, json.RootElement.GetProperty("Name").GetString()!, false));
            }
        return entries.ToArray();
    }
    public static Entry Import(CareerData data, string path, CharacterDesignPackage.Imported? imported = null)
    {
        using var file = File.OpenRead(path);
        string id = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(file)).ToLowerInvariant();
        if (File.Exists(PathFor(id))) return new(id, Load(data, new(id, "", false)).Name, false);
        file.Position = 0;
        return Save(id, imported ?? CharacterDesignPackage.Read(data, file));
    }
    private static Entry Save(string id, CharacterDesignPackage.Imported imported, string? name = null)
    {
        var package = new Package { Name = name ?? imported.Person.PublicName, Design = imported.Design };
        foreach (var item in imported.Metadata.Sprites)
        {
            string hash = item.Hash; DateSceneAssetStore.Store(imported.Images[item.File], hash);
            if (!package.Outfits.TryGetValue(item.Outfit, out var sprites)) package.Outfits[item.Outfit] = sprites = [];
            sprites.Add(item.Id, hash);
        }
        Directory.CreateDirectory(DirectoryPath);
        string target = PathFor(id), temp = target + ".tmp";
        try { File.WriteAllText(temp, JsonSerializer.Serialize(package, PortraitDesigns.Json)); File.Move(temp, target, true); }
        finally { if (File.Exists(temp)) File.Delete(temp); }
        return new(id, package.Name, false);
    }
    public static Package Load(CareerData data, Entry entry)
    {
        string path = PathFor(entry.Id);
        if (!File.Exists(path) && entry.BuiltIn)
        {
            using var stream = typeof(AppearanceLibrary).Assembly.GetManifestResourceStream("NationalSpire.Appearance." + entry.Id + ".zip")!;
            Save(entry.Id, CharacterDesignPackage.Read(data, stream), entry.Name);
        }
        return JsonSerializer.Deserialize<Package>(File.ReadAllText(path), PortraitDesigns.Json)!;
    }
    public static (PortraitDesign Design, DateSceneAssets Assets) Apply(CareerData data, string person, Package package)
    {
        var design = Coop.CoopJson.Copy(package.Design); design.PersonId = person;
        var assets = DateSceneAssetStore.Read(data, person);
        assets.Outfits = Coop.CoopJson.Copy(package.Outfits); assets.OutfitId = design.SelectedOutfit;
        using var installation = new CharacterDesignPackage.Installation(data, person, design, assets);
        installation.Commit();
        return (design, assets);
    }
    public static string? Preview(Package package) => package.Outfits.GetValueOrDefault(package.Design.SelectedOutfit)?
        .FirstOrDefault(p => p.Key == package.Design.DefaultEmotionId || p.Key.StartsWith(package.Design.DefaultEmotionId + "_", StringComparison.Ordinal)).Value;
}
