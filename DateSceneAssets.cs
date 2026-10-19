using Godot;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text.Json;

namespace NationalSpire;

public sealed class DateSceneAssets
{
    public string OutfitId { get; set; } = "";
    public Dictionary<string, Dictionary<string, string>> Outfits { get; set; } = [];
    [System.Text.Json.Serialization.JsonIgnore]
    public Dictionary<string, string> Sprites { get => Outfits.TryGetValue(OutfitId, out var sprites) ? sprites : Outfits[OutfitId] = []; set => Outfits[OutfitId] = value; }
    public string Background { get; set; } = "";
    public double SpriteScale { get; set; } = 1;
    public double SpriteX { get; set; }
    public double SpriteY { get; set; }
    public bool TextOutline { get; set; } = true;
    public bool ShowAffectionBadge { get; set; } = true;
    public bool AutoBackground { get; set; } = true;
    public bool Blur { get; set; } = true;
    public double BlurAmount { get; set; } = 3;
    public double TextSpeed { get; set; } = 75;
    public int FontSize { get; set; } = 1;
    public double LetterSpacing { get; set; } = 1;
    public double PanelFade { get; set; }
    public Dictionary<string, DateSceneBookmark> Bookmarks { get; set; } = [];
}
public sealed class DateSceneBookmark
{
    public string Turn { get; set; } = "";
    public string ReplyHash { get; set; } = "";
    public int Index { get; set; }
}
/// <summary>角色立绘与背景仅保存在本机；文件名或清单映射决定ID，内容摘要决定缓存路径。</summary>
public static class DateSceneAssetStore
{
    public static string? EmotionForSprite(PortraitDesign design, string id)
    {
        if (design.Emotions.Any(e => e.Enabled && e.Id == id)) return id;
        int split = id.LastIndexOf('_');
        if (split <= 0 || split == id.Length - 1 || !id[(split + 1)..].All(char.IsAsciiDigit)) return null;
        string emotion = id[..split];
        return design.Emotions.Any(e => e.Enabled && e.Id == emotion) ? emotion : null;
    }
    public static string[] SpriteKeys(DateSceneAssets assets, PortraitDesign design, string emotion)
        => assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion).Order(StringComparer.Ordinal).ToArray();
    public static bool ContinueHintDismissed()
    {
        using var config = new ConfigFile(); config.Load("user://NationalSpire_date_scene.cfg");
        return config.GetValue("scene", "continue_hint_dismissed", false).AsBool();
    }
    public static void DismissContinueHint()
    {
        using var config = new ConfigFile(); config.Load("user://NationalSpire_date_scene.cfg");
        config.SetValue("scene", "continue_hint_dismissed", true);
        if (config.Save("user://NationalSpire_date_scene.cfg") != Error.Ok) throw new IOException("场景提示偏好保存失败。");
    }
    public static string DirectoryPath => ProjectSettings.GlobalizePath("user://national_spire_portraits/scenes");
    public static string PathFor(CareerData data, string person) => Path.Combine(DirectoryPath, PortraitDesignStore.Key(data, person) + ".json");
    public static DateSceneAssets Read(CareerData data, string person)
    {
        string path = PathFor(data, person);
        var assets = File.Exists(path) ? JsonSerializer.Deserialize<DateSceneAssets>(File.ReadAllText(path), PortraitDesigns.Json) ?? new() : new();
        if (!assets.Blur) { assets.BlurAmount = 0; assets.Blur = true; }
        return assets;
    }
    public static void Save(CareerData data, string person, DateSceneAssets assets)
    {
        Directory.CreateDirectory(DirectoryPath); string path = PathFor(data, person), temporary = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try { File.WriteAllText(temporary, JsonSerializer.Serialize(assets, PortraitDesigns.Json)); File.Move(temporary, path, true); }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    public static string Hash(byte[] bytes) => Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
    public static string BlobPath(string hash)
    {
        if (hash.Length != 64 || hash.Any(c => !char.IsAsciiHexDigit(c))) throw new InvalidDataException("图像缓存编号无效。");
        return Path.Combine(DirectoryPath, "images", hash + ".png");
    }
    private static void Store(byte[] bytes, string hash)
    {
        string path = BlobPath(hash); Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        if (File.Exists(path) && Hash(File.ReadAllBytes(path)) == hash) return;
        string temp = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try { File.WriteAllBytes(temp, bytes); File.Move(temp, path, true); } finally { if (File.Exists(temp)) File.Delete(temp); }
    }
    public static Image ReadImage(byte[] bytes, bool sprite)
    {
        if (bytes.Length < 24 || bytes.Length > 64 * 1024 * 1024 || !bytes.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })) throw new InvalidDataException("请选择完整的PNG图片（单张至多64MB）。");
        uint width = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.AsSpan(16, 4)), height = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.AsSpan(20, 4));
        if (sprite && (width != 1024 || height != 1536)) throw new InvalidDataException("立绘画布须为1024×1536。");
        if (width == 0 || height == 0 || (long)width * height > 32 * 1024 * 1024) throw new InvalidDataException("图片尺寸过大或无效，请缩小至约定画布。");
        var image = new Image();
        if (image.LoadPngFromBuffer(bytes) != Error.Ok || image.IsEmpty()) { image.Dispose(); throw new InvalidDataException("PNG图片无法读取。"); }
        if (sprite && (image.GetWidth() != 1024 || image.GetHeight() != 1536 || image.DetectAlpha() == Image.AlphaMode.None))
        { image.Dispose(); throw new InvalidDataException("立绘须为1024×1536且包含透明像素的PNG，请按导出清单统一画布与Alpha。"); }
        if (sprite)
        {
            image.Convert(Image.Format.Rgba8); byte[] pixels = image.GetData(); bool visible = false;
            for (int i = 3; i < pixels.Length; i += 4) if (pixels[i] > 0) { visible = true; break; }
            if (!visible) { image.Dispose(); throw new InvalidDataException("立绘完全透明，请导入含有人物的PNG。"); }
        }
        return image;
    }
    public static void ImportOne(DateSceneAssets assets, PortraitDesign design, string id, string file, bool append = false)
    {
        if (!design.Emotions.Any(e => e.Enabled && e.Id == id)) throw new InvalidDataException("该情绪ID未在当前设计中启用。");
        string filename = Path.GetFileNameWithoutExtension(file);
        assets.OutfitId = design.SelectedOutfit;
        if (append)
        {
            string emotion = id; int index = 1;
            do { id = emotion + "_" + index++; } while (assets.Sprites.ContainsKey(id) || design.Emotions.Any(e => e.Id == id));
        }
        else if (EmotionForSprite(design, filename) == id) id = filename;
        byte[] bytes = File.ReadAllBytes(file); using var image = ReadImage(bytes, true);
        string hash = Hash(bytes); Store(bytes, hash); assets.OutfitId = design.SelectedOutfit; assets.Sprites[id] = hash;
    }
    public static string StoreSprite(byte[] bytes)
    {
        using var image = ReadImage(bytes, true); string hash = Hash(bytes); Store(bytes, hash); return hash;
    }
    public static void SaveEmotionEdit(CareerData data, string person, PortraitDesign previous, PortraitDesign design, DateSceneAssets assets, string oldId, string newId)
    {
        var copy = Coop.CoopJson.Copy(assets);
        if (oldId.Length > 0 && oldId != newId)
            foreach (var sprites in copy.Outfits.Values)
            {
                var changes = sprites.Where(p => EmotionForSprite(previous, p.Key) == oldId).ToArray();
                if (sprites.Keys.Any(key => EmotionForSprite(previous, key) != oldId && EmotionForSprite(previous, key) != EmotionForSprite(design, key)))
                    throw new InvalidDataException("新ID会占用另一情绪的立绘编号，请换一个ID。");
                foreach (var item in changes)
                {
                    string key = newId + item.Key[oldId.Length..];
                    if (sprites.ContainsKey(key) || EmotionForSprite(design, key) != newId) throw new InvalidDataException("新ID与现有立绘编号冲突，请换一个ID。");
                }
                foreach (var item in changes) { sprites.Remove(item.Key); sprites.Add(newId + item.Key[oldId.Length..], item.Value); }
            }
        Save(data, person, copy);
        try { PortraitDesignStore.Save(PortraitDesignStore.FilePath(data, person), design); }
        catch { Save(data, person, assets); throw; }
    }
    public static void ImportPack(DateSceneAssets assets, PortraitDesign design, string path)
    {
        using var archive = Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? ZipFile.OpenRead(path) : null;
        if (archive != null && !archive.Entries.Any(e => e.FullName == "manifest.json")) { ImportNamedPack(assets, design, archive); return; }
        byte[] Read(string name)
        {
            if (name.Contains('\\') || name.StartsWith('/') || name.Split('/').Any(p => p is ".." or "." || p.Contains(':'))) throw new InvalidDataException("清单中的图片路径无效。");
            if (archive != null)
            {
                var found = archive.Entries.Where(e => e.FullName == name).ToArray();
                if (found.Length != 1) throw new InvalidDataException("立绘包缺少或重复文件：" + name);
                if (found[0].Length > 64 * 1024 * 1024) throw new InvalidDataException("单张图片超过64MB，请按标准画布重新导出。");
                using var input = found[0].Open(); using var output = new MemoryStream(); input.CopyTo(output); return output.ToArray();
            }
            string root = Path.GetFullPath(Path.GetDirectoryName(path)!) + Path.DirectorySeparatorChar;
            string resolved = Path.GetFullPath(Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar)));
            if (!resolved.StartsWith(root, StringComparison.OrdinalIgnoreCase)) throw new InvalidDataException("图片路径超出清单目录。");
            return File.ReadAllBytes(resolved);
        }
        using var json = JsonDocument.Parse(archive == null ? File.ReadAllBytes(path) : Read("manifest.json")); var manifest = json.RootElement;
        string character = "character_" + Hash(System.Text.Encoding.UTF8.GetBytes(design.PersonId))[..16];
        if (manifest.GetProperty("characterId").GetString() != character || manifest.GetProperty("outfitId").GetString() != design.SelectedOutfit) throw new InvalidDataException("清单与当前角色或套装不匹配，请使用该角色当前套装导出的清单。");
        var accepted = new Dictionary<string, (string Hash, byte[] Bytes)>(); var allowed = design.Emotions.Where(e => e.Enabled).Select(e => e.Id).ToHashSet();
        foreach (var entry in manifest.GetProperty("sprites").EnumerateArray())
        {
            string id = entry.GetProperty("emotionId").GetString() ?? "", file = entry.GetProperty("file").GetString() ?? "";
            if (!allowed.Contains(id) || accepted.ContainsKey(id) || !file.EndsWith('/' + id + ".png", StringComparison.Ordinal)) throw new InvalidDataException("情绪ID、文件名或启用状态与设计不匹配：" + id);
            byte[] bytes = Read(file); using var image = ReadImage(bytes, true); accepted.Add(id, (Hash(bytes), bytes));
        }
        if (!accepted.ContainsKey(design.DefaultEmotionId)) throw new InvalidDataException("立绘包缺少默认差分：" + design.DefaultEmotionId);
        foreach (var item in accepted.Values) Store(item.Bytes, item.Hash);
        assets.OutfitId = design.SelectedOutfit; assets.Sprites = accepted.ToDictionary(p => p.Key, p => p.Value.Hash);
    }
    private static void ImportNamedPack(DateSceneAssets assets, PortraitDesign design, ZipArchive archive)
    {
        var accepted = new Dictionary<string, (string Hash, byte[] Bytes)>();
        long total = 0;
        foreach (var entry in archive.Entries.Where(e => e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/")))
        {
            if (entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':')))
                throw new InvalidDataException("立绘包中的图片路径无效。");
            string id = Path.GetFileNameWithoutExtension(entry.Name);
            if (EmotionForSprite(design, id) == null || accepted.ContainsKey(id)) throw new InvalidDataException("PNG文件名须为情绪ID或情绪ID_数字，且文件名唯一：" + id);
            total += entry.Length;
            if (entry.Length > 64 * 1024 * 1024 || total > 512L * 1024 * 1024) throw new InvalidDataException("立绘包过大，请按标准画布分批导入。");
            using var input = entry.Open(); using var output = new MemoryStream(); input.CopyTo(output); byte[] bytes = output.ToArray();
            using var image = ReadImage(bytes, true); accepted.Add(id, (Hash(bytes), bytes));
        }
        if (accepted.Count == 0) throw new InvalidDataException("立绘包中没有PNG图片。");
        var merged = new Dictionary<string, string>(assets.Outfits.GetValueOrDefault(design.SelectedOutfit) ?? []);
        foreach (var item in accepted) merged[item.Key] = item.Value.Hash;
        if (!merged.Keys.Any(id => EmotionForSprite(design, id) == design.DefaultEmotionId)) throw new InvalidDataException($"请提供{design.DefaultEmotionId}.png或{design.DefaultEmotionId}_数字.png默认立绘。");
        foreach (var item in accepted.Values) Store(item.Bytes, item.Hash);
        assets.OutfitId = design.SelectedOutfit; assets.Sprites = merged;
    }
    public static string ImportBackground(string path)
    {
        if (new FileInfo(path).Length > 64 * 1024 * 1024) throw new InvalidDataException("背景图片超过64MB，请缩小后导入。");
        return ImportBackgroundBytes(File.ReadAllBytes(path), Path.GetExtension(path));
    }
    public static string ImportBackgroundBytes(byte[] bytes, string extension)
    {
        if (bytes.Length > 64 * 1024 * 1024) throw new InvalidDataException("背景图片超过64MB，请缩小后导入。");
        using var image = new Image(); string ext = extension.ToLowerInvariant();
        var result = ext switch { ".jpg" or ".jpeg" => image.LoadJpgFromBuffer(bytes), ".webp" => image.LoadWebpFromBuffer(bytes), _ => image.LoadPngFromBuffer(bytes) };
        if (result != Error.Ok || image.IsEmpty()) throw new InvalidDataException("背景图片无法读取。");
        bytes = image.SavePngToBuffer(); using var validated = ReadImage(bytes, false);
        string hash = Hash(bytes); Store(bytes, hash); return hash;
    }
    public static Texture2D Texture(string hash, bool sprite = true)
    {
        byte[] bytes = File.ReadAllBytes(BlobPath(hash)); if (Hash(bytes) != hash) throw new InvalidDataException("立绘缓存已损坏，请重新导入。");
        using var image = ReadImage(bytes, sprite); return ImageTexture.CreateFromImage(image);
    }
    public static string? Ready(DateSceneAssets assets, PortraitDesign? design)
    {
        if (design == null) return "请先为当前套装导入立绘。";
        assets.OutfitId = design.SelectedOutfit;
        foreach (string key in SpriteKeys(assets, design, design.DefaultEmotionId))
            try { using var texture = Texture(assets.Sprites[key]); return null; } catch { }
        return $"请先导入有效的{design.DefaultEmotionId}.png或{design.DefaultEmotionId}_数字.png默认差分。";
    }
}
