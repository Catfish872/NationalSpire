using Godot;
using System.IO.Compression;
using System.Text.Json;

namespace NationalSpire;

/// <summary>可移植角色包：沿用PNG人物资料字段，并保存立绘设计、图片与播放映射；导入时分配新的角色身份。</summary>
public static class CharacterDesignPackage
{
    public sealed class Manifest
    {
        public string Format { get; set; } = "national-spire-character-design";
        public int Version { get; set; } = 3;
        public PortraitDesign? Design { get; set; }
        public string DefaultEmotionId { get; set; } = "neutral";
        public string SelectedOutfit { get; set; } = "default";
        public List<Binding> Sprites { get; set; } = [];
    }
    public sealed class Binding
    {
        public string Outfit { get; set; } = "";
        public string Id { get; set; } = "";
        public string Emotion { get; set; } = "";
        public string File { get; set; } = "";
        public string Hash { get; set; } = "";
    }
    public sealed record Imported(CareerPerson Person, Manifest Metadata, PortraitDesign Design, Dictionary<string, byte[]> Images);
    public static string Write(CareerData data, CareerPerson person, PlayerAvatar avatar, string directory, PortraitDesign? sourceDesign = null, DateSceneAssets? sourceAssets = null)
    {
        var design = sourceDesign ?? PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person.Id), person.Id) ?? PortraitDesigns.Create(data, person.Id, person);
        if (PortraitDesigns.Error(design) is { } error) throw new InvalidDataException(error);
        var assets = sourceAssets ?? DateSceneAssetStore.Read(data, person.Id);
        var manifest = new Manifest { DefaultEmotionId = design.DefaultEmotionId, SelectedOutfit = design.SelectedOutfit, Design = design };
        var images = new Dictionary<string, byte[]>();
        foreach (var (outfit, sprites) in assets.Outfits)
        {
            if (!PortraitDesigns.SafeId(outfit)) throw new InvalidDataException("套装编号无效。");
            foreach (var (id, hash) in sprites)
            {
                if (!PortraitDesigns.SafeId(id)) throw new InvalidDataException("立绘编号无效。");
                string file = $"sprites/{outfit}/{id}.png";
                byte[] bytes = File.ReadAllBytes(DateSceneAssetStore.BlobPath(hash));
                if (DateSceneAssetStore.Hash(bytes) != hash) throw new InvalidDataException("立绘缓存校验失败，请重新导入：" + id);
                using var image = DateSceneAssetStore.ReadImage(bytes, true);
                manifest.Sprites.Add(new() { Outfit = outfit, Id = id, Emotion = DateSceneAssetStore.EmotionForSprite(design, id) ?? id, File = file, Hash = hash }); images.Add(file, bytes);
            }
        }
        byte[] card = CharacterCardPng.Export(data, person, avatar);
        byte[] metadata = JsonSerializer.SerializeToUtf8Bytes(manifest, PortraitDesigns.Json);
        if (images.Count > 500 || images.Values.Sum(b => (long)b.Length) + card.Length + metadata.Length > MaxTotal || metadata.Length > MaxMetadata) throw new InvalidDataException("角色设计包过大，请精简立绘后重试。");
        Directory.CreateDirectory(directory);
        string safe = string.Concat(person.PublicName.Take(36).Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c));
        string path = Path.Combine(directory, "国运尖塔-角色设计-" + safe + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + "-" + Guid.NewGuid().ToString("N")[..6] + ".zip"), temp = path + ".tmp";
        try
        {
            using (var archive = ZipFile.Open(temp, ZipArchiveMode.Create))
            {
                void Add(string file, byte[] bytes) { using var stream = archive.CreateEntry(file, CompressionLevel.Optimal).Open(); stream.Write(bytes); }
                Add("character.png", card); Add("character-design.json", metadata);
                foreach (var (file, bytes) in images) Add(file, bytes);
            }
            File.Move(temp, path); return path;
        }
        finally { if (File.Exists(temp)) File.Delete(temp); }
    }
    private const long MaxTotal = 512L * 1024 * 1024;
    private const int MaxMetadata = 4 * 1024 * 1024;
    public static Imported Read(CareerData data, string path, bool portraitsOnly = false)
    {
        if (new FileInfo(path).Length > MaxTotal) throw new InvalidDataException("角色设计包超过512MB。");
        using var stream = File.OpenRead(path);
        return Read(data, stream, portraitsOnly);
    }
    public static Imported Read(CareerData data, Stream source, bool portraitsOnly = false)
    {
        using var archive = new ZipArchive(source, ZipArchiveMode.Read, leaveOpen: true);
        if (archive.Entries.Count > 512 || archive.Entries.Sum(e => e.Length) > MaxTotal) throw new InvalidDataException("角色设计包内容过大。");
        var entries = new Dictionary<string, ZipArchiveEntry>(StringComparer.OrdinalIgnoreCase);
        foreach (var entry in archive.Entries)
        {
            string file = entry.FullName;
            if (file.Contains('\\') || file.StartsWith('/') || file.Contains(':') || file.Split('/').Any(p => p is ".." or ".") || !entries.TryAdd(file, entry)) throw new InvalidDataException("角色设计包含有无效或重复路径。");
        }
        byte[] Bytes(string file, int limit)
        {
            if (!entries.TryGetValue(file, out var entry) || entry.Length <= 0 || entry.Length > limit) throw new InvalidDataException("角色设计包缺少或超出大小限制：" + file);
            using var stream = entry.Open(); byte[] bytes = new byte[(int)entry.Length]; stream.ReadExactly(bytes); if (stream.ReadByte() != -1) throw new InvalidDataException("文件长度校验失败。"); return bytes;
        }
        byte[] metadata = Bytes("character-design.json", MaxMetadata);
        var manifest = JsonSerializer.Deserialize<Manifest>(metadata, PortraitDesigns.Json) ?? throw new InvalidDataException("角色设计清单为空。");
        if (manifest.Format != "national-spire-character-design" || manifest.Version is not (1 or 2 or 3) || manifest.Sprites == null) throw new InvalidDataException("角色设计格式或版本无效。");
        // 旧包只读取播放所需ID；Relation、记忆及设计说明均不进入新角色。
        var legacyIds = new List<string>();
        if (manifest.Version == 1)
        {
            using var document = JsonDocument.Parse(metadata);
            if (Property(document.RootElement, "Design") is { ValueKind: JsonValueKind.Object } legacy)
            {
                if (Property(legacy, "DefaultEmotionId") is { ValueKind: JsonValueKind.String } emotion) manifest.DefaultEmotionId = emotion.GetString()!;
                if (Property(legacy, "SelectedOutfit") is { ValueKind: JsonValueKind.String } outfit) manifest.SelectedOutfit = outfit.GetString()!;
                if (Property(legacy, "Emotions") is { ValueKind: JsonValueKind.Array } emotions)
                    foreach (var item in emotions.EnumerateArray())
                        if (Property(item, "Id") is { ValueKind: JsonValueKind.String } id && PortraitDesigns.SafeId(id.GetString()!)) legacyIds.Add(id.GetString()!);
            }
        }
        if (manifest.DefaultEmotionId == null || manifest.SelectedOutfit == null || !PortraitDesigns.SafeId(manifest.DefaultEmotionId) || !PortraitDesigns.SafeId(manifest.SelectedOutfit)) throw new InvalidDataException("默认立绘或套装编号无效。");
        var person = portraitsOnly ? CharacterCards.New(data) : CharacterCardPng.Import(data, Bytes("character.png", 16 * 1024 * 1024), AvatarImages.FromCardPng);
        var design = manifest.Version == 3 && manifest.Design != null ? manifest.Design : PortraitDesigns.Create(data, person.Id, person);
        design.PersonId = person.Id;
        design.DefaultEmotionId = manifest.DefaultEmotionId; design.SelectedOutfit = manifest.SelectedOutfit;
        if (manifest.Version < 3) design.Outfits = [];
        design.StyleLibraryInitialized = true;
        var images = new Dictionary<string, byte[]>(); var bindings = new HashSet<string>();
        foreach (var item in manifest.Sprites)
        {
            if (item == null || item.Outfit == null || item.Id == null || !PortraitDesigns.SafeId(item.Outfit) || !PortraitDesigns.SafeId(item.Id) || item.File != $"sprites/{item.Outfit}/{item.Id}.png" || !bindings.Add(item.File)) throw new InvalidDataException("立绘映射无效或重复。");
            if (manifest.Version == 1) item.Emotion = legacyIds.OrderByDescending(id => id.Length).FirstOrDefault(id => MatchesEmotion(item.Id, id)) ?? item.Id;
            if (item.Emotion == null || !PortraitDesigns.SafeId(item.Emotion) || !MatchesEmotion(item.Id, item.Emotion)) throw new InvalidDataException("情绪差分映射无效。");
            byte[] bytes = Bytes(item.File, 64 * 1024 * 1024);
            if (DateSceneAssetStore.Hash(bytes) != item.Hash) throw new InvalidDataException("立绘摘要与清单不一致：" + item.Id);
            using var image = DateSceneAssetStore.ReadImage(bytes, true); images.Add(item.File, bytes);
        }
        foreach (string id in manifest.Sprites.Select(s => s.Emotion).Append(manifest.DefaultEmotionId).Distinct())
            if (!design.Emotions.Any(e => e.Id == id)) design.Emotions.Add(new() { Id = id, Name = id });
        foreach (string id in manifest.Sprites.Select(s => s.Outfit).Append(manifest.SelectedOutfit).Distinct())
            if (!design.Outfits.Any(o => o.Id == id)) design.Outfits.Add(new() { Id = id, Name = id == "default" ? "日常套装" : "套装" + (design.Outfits.Count + 1) });
        if (PortraitDesigns.Error(design) is { } error) throw new InvalidDataException(error);
        return new(person, manifest, design, images);
    }
    private static JsonElement? Property(JsonElement item, string name) => item.ValueKind == JsonValueKind.Object
        ? item.EnumerateObject().Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).Select(p => (JsonElement?)p.Value).FirstOrDefault() : null;
    private static bool MatchesEmotion(string id, string emotion) => id == emotion || id.StartsWith(emotion + "_", StringComparison.Ordinal)
        && id.Length > emotion.Length + 1 && id[(emotion.Length + 1)..].All(c => c is >= '0' and <= '9');
    public sealed class Installation : IDisposable
    {
        private readonly Dictionary<string, byte[]?> _before = [];
        private bool _committed;
        public Installation(CareerData data, Imported package) : this(data, package.Person.Id, package.Design, PackageAssets(package)) { }
        public static DateSceneAssets PackageAssets(Imported package)
        {
            var assets = new DateSceneAssets { OutfitId = package.Metadata.SelectedOutfit };
            foreach (var item in package.Metadata.Sprites)
            {
                string hash = item.Hash; DateSceneAssetStore.Store(package.Images[item.File], hash);
                if (!assets.Outfits.TryGetValue(item.Outfit, out var sprites)) assets.Outfits[item.Outfit] = sprites = [];
                sprites.Add(item.Id, hash);
            }
            return assets;
        }
        public Installation(CareerData data, string person, PortraitDesign design, DateSceneAssets assets)
        {
            foreach (string path in new[] { PortraitDesignStore.FilePath(data, person), DateSceneAssetStore.PathFor(data, person) }) _before[path] = File.Exists(path) ? File.ReadAllBytes(path) : null;
            try
            {
                PortraitDesignStore.Save(PortraitDesignStore.FilePath(data, person), design);
                DateSceneAssetStore.Save(data, person, assets);
            }
            catch { Dispose(); throw; }
        }
        public void Commit() => _committed = true;
        public void Dispose()
        {
            if (_committed) return;
            foreach (var (path, bytes) in _before)
            {
                if (bytes == null) { if (File.Exists(path)) File.Delete(path); }
                else { string temp = path + ".restore.tmp"; File.WriteAllBytes(temp, bytes); File.Move(temp, path, true); }
            }
            _committed = true;
        }
    }
    public static string ExportDirectory()
    {
        string desktop = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
        return desktop.Length > 0 ? desktop : ProjectSettings.GlobalizePath("user://portrait_exports");
    }
}
