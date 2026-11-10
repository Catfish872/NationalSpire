using System.IO.Compression;
using System.Text.Json;

namespace NationalSpire;

/// <summary>先识别并校验整包，再由界面统一确认新情绪；合并结果保持为独立草稿。</summary>
public static class PortraitPackageImport
{
    public sealed record Sprite(string File, string Id, string Emotion, string Outfit, byte[] Bytes);
    public sealed class Plan
    {
        public CharacterDesignPackage.Imported? Character { get; init; }
        public PortraitDesign? SourceDesign { get; init; }
        public List<Sprite> Sprites { get; init; } = [];
        public Sprite[] Unknown(PortraitDesign design) => Sprites.Where(s => !design.Emotions.Any(e => e.Enabled && e.Id == s.Emotion)).ToArray();
    }
    private const long MaxTotal = 512L * 1024 * 1024;
    private static void CheckPath(string name)
    {
        if (name.Contains('\\') || name.StartsWith('/') || name.Contains(':') || name.Split('/').Any(p => p is "." or ".."))
            throw new InvalidDataException("压缩包含有无效路径：" + name);
    }
    public static string EmotionId(PortraitDesign design, string id)
    {
        if (!PortraitDesigns.SafeId(id)) throw new InvalidDataException("PNG文件名请使用小写英文字母开头的情绪ID，可附加_数字：" + id);
        if (design.Emotions.Any(e => e.Id == id)) return id;
        int split = id.LastIndexOf('_');
        return split > 0 && split < id.Length - 1 && id[(split + 1)..].All(char.IsAsciiDigit) ? id[..split] : id;
    }
    public static Plan Read(CareerData? data, string path, PortraitDesign design)
    {
        if (new FileInfo(path).Length > MaxTotal) throw new InvalidDataException("压缩包超过512MB，请分批导入。");
        using var archive = Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? ZipFile.OpenRead(path) : null;
        var entries = new Dictionary<string, ZipArchiveEntry>(StringComparer.OrdinalIgnoreCase);
        if (archive != null)
        {
            if (archive.Entries.Count > 1024 || archive.Entries.Sum(e => e.Length) > MaxTotal) throw new InvalidDataException("压缩包内容过大，请分批导入。");
            foreach (var entry in archive.Entries)
            {
                CheckPath(entry.FullName);
                if (!entries.TryAdd(entry.FullName, entry)) throw new InvalidDataException("压缩包含有重复路径：" + entry.FullName);
            }
            if (entries.ContainsKey("character-design.json"))
            {
                if (data == null) throw new InvalidDataException("这是角色设计包，请通过立绘与场景或导入角色入口选择导入方式。");
                bool hasCard = entries.ContainsKey("character.png");
                var character = CharacterDesignPackage.Read(data, path, portraitsOnly: !hasCard);
                return new Plan { Character = hasCard ? character : null, SourceDesign = character.Design, Sprites = character.Metadata.Sprites.Select(s =>
                    new Sprite(s.File, s.Id, EmotionId(design, s.Id), s.Outfit, character.Images[s.File])).ToList() };
            }
        }
        long total = 0;
        byte[] Bytes(string name, int limit)
        {
            CheckPath(name);
            Stream stream;
            long length;
            if (archive != null)
            {
                if (!entries.TryGetValue(name, out var entry)) throw new InvalidDataException("立绘包缺少文件：" + name);
                length = entry.Length;
                if (length <= 0 || length > limit || (total += length) > MaxTotal) throw new InvalidDataException("立绘包文件过大或为空：" + name);
                stream = entry.Open();
            }
            else
            {
                string root = Path.GetFullPath(Path.GetDirectoryName(path)!) + Path.DirectorySeparatorChar;
                string file = Path.GetFullPath(Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar)));
                if (!file.StartsWith(root, StringComparison.OrdinalIgnoreCase)) throw new InvalidDataException("图片路径超出清单目录。");
                length = new FileInfo(file).Length;
                if (length <= 0 || length > limit || (total += length) > MaxTotal) throw new InvalidDataException("立绘包文件过大或为空：" + name);
                stream = File.OpenRead(file);
            }
            using (stream) { byte[] bytes = new byte[(int)length]; stream.ReadExactly(bytes); if (stream.ReadByte() != -1) throw new InvalidDataException("文件长度校验失败。"); return bytes; }
        }
        var result = new Plan(); var ids = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        void Add(string file)
        {
            string id = Path.GetFileNameWithoutExtension(file), emotion = EmotionId(design, id);
            if (!file.EndsWith(".png", StringComparison.OrdinalIgnoreCase)) throw new InvalidDataException("立绘清单请引用PNG文件：" + file);
            if (!ids.Add(id)) throw new InvalidDataException("立绘包中的PNG文件名重复：" + id);
            byte[] bytes = Bytes(file, 64 * 1024 * 1024); using var image = DateSceneAssetStore.ReadImage(bytes, true);
            result.Sprites.Add(new(file, id, emotion, design.SelectedOutfit, bytes));
        }
        if (archive == null || entries.ContainsKey("manifest.json"))
        {
            using var json = JsonDocument.Parse(Bytes(archive == null ? Path.GetFileName(path) : "manifest.json", 4 * 1024 * 1024));
            foreach (var sprite in json.RootElement.GetProperty("sprites").EnumerateArray())
                Add(sprite.GetProperty("file").GetString() ?? "");
        }
        else foreach (var entry in archive!.Entries.Where(e => e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/", StringComparison.Ordinal))) Add(entry.FullName);
        if (result.Sprites.Count == 0) throw new InvalidDataException("压缩包内没有立绘PNG图片，请选择包含立绘的文件包。");
        return result;
    }
    public static (PortraitDesign Design, DateSceneAssets Assets, int Count) Merge(Plan plan, PortraitDesign source, DateSceneAssets original, ISet<string> acceptedUnknown)
    {
        var unknown = plan.Unknown(source).Select(s => s.File).ToHashSet(StringComparer.Ordinal);
        var sprites = plan.Sprites.Where(s => !unknown.Contains(s.File) || acceptedUnknown.Contains(s.File)).ToArray();
        var design = Coop.CoopJson.Copy(source); var assets = Coop.CoopJson.Copy(original);
        var outfits = sprites.Select(s => s.Outfit).Distinct().ToDictionary(id => id, id => id);
        var reservedOutfits = design.Outfits.Select(o => o.Id).Concat(assets.Outfits.Keys).Concat(outfits.Keys).ToHashSet(StringComparer.Ordinal);
        if (plan.SourceDesign is { } sourceDesign)
        {
            foreach (string id in outfits.Keys.ToArray())
            {
                if (id == sourceDesign.SelectedOutfit) outfits[id] = design.SelectedOutfit;
                else if (id == design.SelectedOutfit)
                {
                    string stem = id[..Math.Min(48, id.Length)] + "_import", destination = stem; int suffix = 2;
                    while (!reservedOutfits.Add(destination)) destination = stem + suffix++;
                    outfits[id] = destination;
                }
            }
        }
        foreach (var sprite in sprites)
        {
            var emotion = design.Emotions.FirstOrDefault(e => e.Id == sprite.Emotion);
            if (emotion == null) design.Emotions.Add(new() { Id = sprite.Emotion, Name = sprite.Emotion });
            else emotion.Enabled = true;
            string outfit = outfits[sprite.Outfit];
            if (!design.Outfits.Any(o => o.Id == outfit))
            {
                var incoming = plan.SourceDesign?.Outfits.FirstOrDefault(o => o.Id == sprite.Outfit);
                var copy = incoming == null ? new PortraitOutfit { Name = outfit } : Coop.CoopJson.Copy(incoming);
                copy.Id = outfit; design.Outfits.Add(copy);
            }
            if (!assets.Outfits.TryGetValue(outfit, out var bindings)) assets.Outfits[outfit] = bindings = [];
            string hash = DateSceneAssetStore.Hash(sprite.Bytes); DateSceneAssetStore.Store(sprite.Bytes, hash); bindings[sprite.Id] = hash;
        }
        if (PortraitDesigns.Error(design) is { } error) throw new InvalidDataException(error);
        assets.OutfitId = design.SelectedOutfit;
        if (sprites.Length > 0) assets.UseDefaultPortrait = false;
        return (design, assets, sprites.Length);
    }
}
