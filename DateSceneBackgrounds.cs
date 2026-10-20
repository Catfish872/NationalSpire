using Godot;
using System.IO.Compression;
using System.Text.Json;

namespace NationalSpire;

public sealed class DateSceneBackground
{
    public string Id { get; set; } = "";
    public string Description { get; set; } = "";
    public string Image { get; set; } = "";
}
public sealed class DateBackgroundLibrary
{
    public List<DateSceneBackground> Images { get; set; } = [];
    public Dictionary<string, string> Descriptions { get; set; } = [];
    public HashSet<string> Removed { get; set; } = [];
}
/// <summary>各角色共用的本机背景库；模型只读取ID与说明，像素沿内容缓存留在本机。</summary>
public static class DateSceneBackgrounds
{
    private const string ResourcePrefix = "NationalSpire.DateBackgrounds.";
    private static readonly Dictionary<string, string> EmbeddedImages = [];
    private static readonly Dictionary<string, string> Descriptions = new()
    {
        ["aquarium"] = "水族馆，室内，蓝色水光与观赏鱼",
        ["art_museum"] = "美术馆，室内，安静的展厅与画作",
        ["auction"] = "拍卖会场，室内，展示台与来宾座席",
        ["aurora_bedroom"] = "极光下的卧室，夜晚，窗外极光",
        ["aurora_street"] = "极光下的街道，夜晚，室外",
        ["bedroom"] = "卧室，室内，休息与交谈",
        ["bedroom_casual_day"] = "日常卧室，白天，室内",
        ["bedroom_casual_night"] = "日常卧室，夜晚，室内",
        ["bedroom_japanese_day"] = "日式卧室，白天，室内",
        ["bedroom_japanese_night"] = "日式卧室，夜晚，室内",
        ["bg_cityRiver_day"] = "城市河岸，白天，室外步道",
        ["bg_cityRiver_evening"] = "城市河岸，傍晚，夕阳下的步道",
        ["bg_cityRiver_night"] = "城市河岸，夜晚，灯光与河水",
        ["championship_contest_venue"] = "冠军赛事场馆，室内，比赛舞台",
        ["cinema"] = "电影院，室内，放映厅",
        ["concert_hall"] = "音乐厅，室内，舞台与观众席",
        ["cruise_day"] = "游轮，白天，海上",
        ["cruise_evening"] = "游轮，傍晚，海上夕阳",
        ["gourmet_street"] = "美食街，室外，小吃店铺",
        ["hot_spring_day"] = "温泉，白天，蒸汽与池水",
        ["hot_spring_night"] = "温泉，夜晚，蒸汽与池水",
        ["kitchen"] = "厨房，室内，烹饪与餐食",
        ["ktv"] = "卡拉OK包间，室内，唱歌娱乐",
        ["lakeside_log_cabin"] = "湖畔木屋，湖边，度假休息",
        ["livehouse"] = "现场音乐演出场地，室内，舞台灯光",
        ["living_room"] = "客厅，室内，日常相处",
        ["manor_exterior"] = "庄园外景，室外，庭院与建筑",
        ["manor_interior"] = "庄园内景，室内，会客空间",
        ["park"] = "公园，室外，散步与绿地",
        ["restaurant"] = "餐厅，室内，用餐与交谈",
        ["seaside_dinner"] = "海边晚餐，傍晚，海景餐桌",
        ["training_room"] = "训练室，室内，电竞设备",
        ["wedding"] = "婚礼现场，仪式与庆祝"
    };
    public static string ResolveImage(string image)
    {
        if (!image.StartsWith(ResourcePrefix, StringComparison.Ordinal)) return image;
        if (EmbeddedImages.TryGetValue(image, out string? hash) && File.Exists(DateSceneAssetStore.BlobPath(hash))) return hash;
        using var input = typeof(DateSceneBackgrounds).Assembly.GetManifestResourceStream(image)
            ?? throw new FileNotFoundException("默认背景资源缺失：" + image);
        using var bytes = new MemoryStream(); input.CopyTo(bytes);
        return EmbeddedImages[image] = DateSceneAssetStore.ImportBackgroundBytes(bytes.ToArray(), Path.GetExtension(image));
    }
    public static Image? Pixels(string image)
    {
        if (image.Length == 64) return DateSceneAssetStore.Pixels(image, false);
        if (!image.StartsWith(ResourcePrefix, StringComparison.Ordinal)) return null;
        using var input = typeof(DateSceneBackgrounds).Assembly.GetManifestResourceStream(image)
            ?? throw new FileNotFoundException("默认背景资源缺失：" + image);
        using var bytes = new MemoryStream(); input.CopyTo(bytes);
        return DateSceneAssetStore.ReadBackgroundImage(bytes.ToArray(), Path.GetExtension(image));
    }
    public static List<DateSceneBackground> AutomaticChoices(IEnumerable<DateSceneBackground> library)
    {
        var items = library.ToList(); var pictures = items.Where(b => b.Image.Length == 64 || b.Image.StartsWith(ResourcePrefix, StringComparison.Ordinal)).ToList();
        return pictures;
    }
    public static string Closest(IEnumerable<DateSceneBackground> library, string context, string current = "")
    {
        // AI负责语义匹配；本地评分用于首帧以及缺失/失效标注的保底。
        static HashSet<string> Terms(string text)
        {
            var terms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (System.Text.RegularExpressions.Match word in System.Text.RegularExpressions.Regex.Matches(text.ToLowerInvariant(), "[a-z0-9]+|[\\u4e00-\\u9fff]+"))
            {
                string value = word.Value; terms.Add(value);
                if (value[0] >= '\u4e00') for (int i = 0; i + 1 < value.Length; i++) terms.Add(value.Substring(i, 2));
            }
            string[][] aliases = [["day", "白天", "日间", "阳光"], ["night", "夜晚", "夜色", "晚上", "深夜"], ["morning", "早晨", "清晨"],
                ["evening", "dusk", "傍晚", "黄昏", "夕阳"], ["cafe", "coffee", "咖啡"], ["park", "公园"], ["beach", "sea", "海边", "沙滩"],
                ["restaurant", "餐厅"], ["indoor", "室内"], ["outdoor", "室外", "户外"], ["home", "house", "家里", "住宅"], ["snow", "ski", "滑雪", "雪地"], ["garden", "花园"]];
            for (int i = 0; i < aliases.Length; i++) if (aliases[i].Any(terms.Contains)) terms.Add("scene:" + i);
            return terms;
        }
        var query = Terms(context);
        return AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0))
            .ThenByDescending(b => b.Id == current).ThenBy(b => b.Id, StringComparer.Ordinal).FirstOrDefault()?.Id ?? "";
    }
    public static readonly string[] Extensions = [".png", ".jpg", ".jpeg", ".webp"];
    private static readonly Dictionary<string, (long Length, DateTime Time, string Image)> PackCache = [];
    public static string FilePath => Path.Combine(DateSceneAssetStore.DirectoryPath, "background-library.json");
    public static bool SafeId(string id) => DateScenes.SafeBackgroundId(id);
    public static string ImageId(string path)
    {
        string id = Path.GetFileNameWithoutExtension(path).Replace(' ', '_');
        if (!SafeId(id)) throw new InvalidDataException("背景文件名请使用文字、数字、下划线或短横线（最多100个字符）。");
        return id;
    }
    public static string PackageDirectory
    {
        get
        {
            string executable = Path.GetDirectoryName(OS.GetExecutablePath()) ?? AppContext.BaseDirectory;
            string assembly = Path.GetDirectoryName(typeof(DateSceneBackgrounds).Assembly.Location) ?? executable;
            string[] candidates = [Path.Combine(assembly, "date-backgrounds"), Path.Combine(executable, "mods", "NationalSpire", "date-backgrounds")];
            return candidates.FirstOrDefault(Directory.Exists) ?? candidates[1];
        }
    }
    private static DateBackgroundLibrary ReadUser() => File.Exists(FilePath)
        ? JsonSerializer.Deserialize<DateBackgroundLibrary>(File.ReadAllText(FilePath), PortraitDesigns.Json) ?? new() : new();
    private static void Save(DateBackgroundLibrary library)
    {
        Directory.CreateDirectory(DateSceneAssetStore.DirectoryPath); string temporary = FilePath + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try { File.WriteAllText(temporary, JsonSerializer.Serialize(library, PortraitDesigns.Json)); File.Move(temporary, FilePath, true); }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    public static List<DateSceneBackground> Read(out string warning, string? packageDirectory = null)
    {
        var items = new Dictionary<string, DateSceneBackground>();
        var errors = new List<string>(); string directory = packageDirectory ?? PackageDirectory;
        if (packageDirectory == null)
            foreach (string resource in typeof(DateSceneBackgrounds).Assembly.GetManifestResourceNames().Where(n => n.StartsWith(ResourcePrefix, StringComparison.Ordinal) && Extensions.Contains(Path.GetExtension(n).ToLowerInvariant())))
            {
                string id = Path.GetFileNameWithoutExtension(resource[ResourcePrefix.Length..]);
                items[id] = new() { Id = id, Image = resource, Description = Descriptions.GetValueOrDefault(id, id.Replace('_', ' ')) };
            }
        if (Directory.Exists(directory))
        {
            foreach (string file in Directory.EnumerateFiles(directory).Where(p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())).Order(StringComparer.Ordinal))
            {
                try
                {
                    string id = ImageId(file); var info = new FileInfo(file);
                    if (!PackCache.TryGetValue(file, out var cached) || cached.Length != info.Length || cached.Time != info.LastWriteTimeUtc || !File.Exists(DateSceneAssetStore.BlobPath(cached.Image)))
                    {
                        cached = (info.Length, info.LastWriteTimeUtc, DateSceneAssetStore.ImportBackground(file)); PackCache[file] = cached;
                    }
                    items[id] = new() { Id = id, Image = cached.Image, Description = Descriptions.GetValueOrDefault(id, id.Replace('_', ' ').Replace('-', ' ')) };
                }
                catch (Exception e) { errors.Add(Path.GetFileName(file) + "：" + e.Message); }
            }
        }
        try
        {
            var library = ReadUser();
            foreach (var item in library.Images)
            {
                if (!SafeId(item.Id) || !File.Exists(DateSceneAssetStore.BlobPath(item.Image))) { errors.Add("背景缺失或编号无效：" + item.Id); continue; }
                items[item.Id] = item;
            }
            foreach (var item in items.Values) if (library.Descriptions.TryGetValue(item.Id, out string? description)) item.Description = description;
            foreach (string id in library.Removed) items.Remove(id);
        }
        catch (Exception e) { errors.Add("本地背景库：" + e.Message); }
        warning = string.Join("\n", errors); return items.Values.ToList();
    }
    public static void Describe(string id, string description)
    {
        if (!SafeId(id)) throw new InvalidDataException("背景ID无效。");
        var library = ReadUser(); library.Descriptions[id] = description.Trim(); Save(library);
    }
    public static void Remove(string id)
    {
        if (!SafeId(id)) throw new InvalidDataException("背景ID无效。");
        var library = ReadUser(); library.Images.RemoveAll(b => b.Id == id); library.Descriptions.Remove(id); library.Removed.Add(id); Save(library);
    }
    public static string RegisterLegacy(string image)
    {
        using var texture = DateSceneAssetStore.Texture(image, false);
        var library = ReadUser(); var existing = library.Images.FirstOrDefault(i => i.Image == image);
        if (existing != null) return existing.Id;
        string id = "imported_" + image[..16];
        library.Images.Add(new() { Id = id, Image = image, Description = "原先导入的背景；可在背景库补充地点与时间说明" }); Save(library); return id;
    }
    public static string Import(string path)
    {
        var library = ReadUser(); var added = new List<DateSceneBackground>();
        if (Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase))
        {
            using var archive = ZipFile.OpenRead(path); long total = 0;
            foreach (var entry in archive.Entries.Where(e => Extensions.Contains(Path.GetExtension(e.Name).ToLowerInvariant()) && !e.FullName.StartsWith("__MACOSX/")))
            {
                if (entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))) throw new InvalidDataException("背景包中的图片路径无效。");
                string id = ImageId(entry.Name); total += entry.Length;
                if (added.Any(i => i.Id == id)) throw new InvalidDataException("背景包中的ID重复：" + id);
                if (entry.Length > 64 * 1024 * 1024 || total > 512L * 1024 * 1024) throw new InvalidDataException("背景包过大，请分批导入。");
                using var input = entry.Open(); using var output = new MemoryStream(); input.CopyTo(output);
                added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') });
            }
        }
        else
        {
            string id = ImageId(path); added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackground(path), Description = id.Replace('_', ' ').Replace('-', ' ') });
        }
        if (added.Count == 0) throw new InvalidDataException("背景包中没有PNG、JPG或WebP图片。");
        foreach (var item in added) { library.Images.RemoveAll(i => i.Id == item.Id); library.Images.Add(item); library.Removed.Remove(item.Id); }
        Save(library); return added[0].Id;
    }
}
