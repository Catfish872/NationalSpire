using Godot;
using System.Security.Cryptography;
using System.Text.Json;

namespace NationalSpire;

public sealed class PortraitStyleGroup
{
    public string Id { get; set; } = "style_" + Guid.NewGuid().ToString("N");
    public string Name { get; set; } = "新画风参考组";
    public string Requirements { get; set; } = "提取线条、明暗色块、局部渐变、发束与高光、衣褶归纳和细节密度；人物身份、性别、年龄、身体比例与服装遵循角色设定。";
    public string PrimaryId { get; set; } = "";
    public List<PortraitStyleImage> Images { get; set; } = [];
}
public sealed class PortraitStyleImage
{
    public string Id { get; set; } = "";
    public string Extension { get; set; } = ".png";
    public string Name { get; set; } = "";
    public bool Enabled { get; set; } = true;
}
public sealed record PortraitStyleEntry(PortraitStyleImage Image, string File, int Order);

/// <summary>本地画风参考的分组、原图缓存、主参考及导出顺序；图片与生涯数据独立保存。</summary>
public static class PortraitStyleReferences
{
    public static string CacheDirectory => ProjectSettings.GlobalizePath("user://national_spire_portraits/references");
    public static string LibraryDirectory
    {
        get
        {
            string? assembly = Path.GetDirectoryName(typeof(PortraitStyleReferences).Assembly.Location);
            string executable = Path.GetDirectoryName(OS.GetExecutablePath()) ?? AppContext.BaseDirectory;
            string project = ProjectSettings.GlobalizePath("res://");
            string[] candidates = [Path.Combine(assembly ?? executable, "portrait-style-library"),
                Path.Combine(executable, "mods", "NationalSpire", "portrait-style-library"),
                Path.Combine(project, ".godot", "mono", "temp", "bin", "Debug", "portrait-style-library"),
                Path.Combine(project, ".godot", "mono", "temp", "bin", "Release", "portrait-style-library")];
            return candidates.FirstOrDefault(p => File.Exists(Path.Combine(p, "library.json"))) ?? candidates[1];
        }
    }
    public static PortraitStyleGroup? Selected(PortraitDesign design) => design.SelectedStyleGroup.Length == 0 ? null
        : design.StyleGroups.SingleOrDefault(g => g.Id == design.SelectedStyleGroup) ?? throw new InvalidDataException("画风参考组已失效，请重新选择。");
    public static PortraitStyleGroup AddGroup(PortraitDesign design)
    {
        var group = new PortraitStyleGroup(); design.StyleGroups.Add(group); design.SelectedStyleGroup = group.Id; design.StyleLibraryInitialized = true; return group;
    }
    public static void EnsureLibrary(PortraitDesign design, string? directory = null)
    {
        if (design.StyleLibraryInitialized || design.StyleGroups.Count > 0) return;
        string source = directory ?? LibraryDirectory, path = Path.Combine(source, "library.json");
        if (!File.Exists(path)) return;
        var groups = JsonSerializer.Deserialize<List<PortraitStyleGroup>>(File.ReadAllText(path), PortraitDesigns.Json) ?? throw new InvalidDataException("画风参考库为空。");
        if (groups.Any(g => !PortraitDesigns.SafeId(g.Id)) || groups.Select(g => g.Id).Distinct().Count() != groups.Count) throw new InvalidDataException("画风参考库编号无效。");
        foreach (var group in groups)
        {
            if (group.Images.Select(i => i.Id).Distinct().Count() != group.Images.Count) throw new InvalidDataException("参考组中存在重复图片。");
            foreach (var item in group.Images)
            {
                try { _ = ReadBytes(item, CacheDirectory); }
                catch (Exception e) when (e is IOException or InvalidDataException or UnauthorizedAccessException) { Store(item, Bytes(item, Path.Combine(source, "images"))); }
            }
            NormalizePrimary(group);
        }
        design.StyleGroups = groups; design.SelectedStyleGroup = groups.FirstOrDefault()?.Id ?? ""; design.StyleLibraryInitialized = true;
    }
    public static PortraitStyleImage Import(PortraitStyleGroup group, string path)
    {
        string extension = Path.GetExtension(path).ToLowerInvariant(); if (extension == ".jpeg") extension = ".jpg";
        if (extension is not (".png" or ".jpg" or ".webp")) throw new InvalidDataException("请选择 PNG、JPG 或 WebP 图片。");
        byte[] bytes = File.ReadAllBytes(path);
        using var image = Decode(bytes, extension);
        var item = new PortraitStyleImage { Id = Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant(), Extension = extension, Name = Path.GetFileName(path) };
        Store(item, bytes);
        var existing = group.Images.FirstOrDefault(i => i.Id == item.Id);
        if (existing != null) { existing.Enabled = true; NormalizePrimary(group); return existing; }
        group.Images.Add(item); NormalizePrimary(group); return item;
    }
    private static void Store(PortraitStyleImage item, byte[] bytes)
    {
        Directory.CreateDirectory(CacheDirectory); string path = AssetPath(item, CacheDirectory);
        if (File.Exists(path) && Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path))).Equals(item.Id, StringComparison.OrdinalIgnoreCase)) return;
        string temporary = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try { File.WriteAllBytes(temporary, bytes); File.Move(temporary, path, true); }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    private static string AssetPath(PortraitStyleImage item, string directory)
    {
        if (item.Id.Length != 64 || item.Id.Any(c => !char.IsAsciiHexDigit(c)) || item.Extension is not (".png" or ".jpg" or ".webp"))
            throw new InvalidDataException("参考图编号或格式无效，请重新导入。");
        return Path.Combine(directory, item.Id.ToLowerInvariant() + item.Extension);
    }
    public static byte[] Bytes(PortraitStyleImage item, string? directory = null)
    {
        byte[] bytes = ReadBytes(item, directory ?? CacheDirectory);
        using var image = Decode(bytes, item.Extension); return bytes;
    }
    private static byte[] ReadBytes(PortraitStyleImage item, string directory)
    {
        string path = AssetPath(item, directory);
        if (!File.Exists(path)) throw new FileNotFoundException($"参考图“{item.Name}”缺失，请重新导入。");
        byte[] bytes = File.ReadAllBytes(path);
        if (!Convert.ToHexString(SHA256.HashData(bytes)).Equals(item.Id, StringComparison.OrdinalIgnoreCase)) throw new InvalidDataException($"参考图“{item.Name}”内容已变化，请重新导入。");
        return bytes;
    }
    private static Image Decode(byte[] bytes, string extension)
    {
        var image = new Image();
        var error = extension switch { ".png" => image.LoadPngFromBuffer(bytes), ".jpg" => image.LoadJpgFromBuffer(bytes), ".webp" => image.LoadWebpFromBuffer(bytes), _ => Error.FileUnrecognized };
        if (error != Error.Ok || image.IsEmpty()) { image.Dispose(); throw new InvalidDataException("参考图解码失败，请选择完整的 PNG、JPG 或 WebP 图片。"); }
        return image;
    }
    public static Texture2D Thumbnail(PortraitStyleImage item)
    {
        using var image = Decode(ReadBytes(item, CacheDirectory), item.Extension);
        double scale = Math.Min(1, 220d / Math.Max(image.GetWidth(), image.GetHeight()));
        image.Resize(Math.Max(1, (int)(image.GetWidth() * scale)), Math.Max(1, (int)(image.GetHeight() * scale)), Image.Interpolation.Lanczos);
        return ImageTexture.CreateFromImage(image);
    }
    public static void SetPrimary(PortraitStyleGroup group, PortraitStyleImage item)
    {
        if (!group.Images.Contains(item)) throw new InvalidOperationException("参考图已移出当前组。");
        item.Enabled = true; group.PrimaryId = item.Id;
    }
    public static void NormalizePrimary(PortraitStyleGroup group)
    {
        if (!group.Images.Any(i => i.Enabled && i.Id == group.PrimaryId)) group.PrimaryId = group.Images.FirstOrDefault(i => i.Enabled)?.Id ?? "";
    }
    public static List<PortraitStyleEntry> Entries(PortraitDesign design)
    {
        var group = Selected(design); if (group == null) return [];
        if (!PortraitDesigns.SafeId(group.Id) || string.IsNullOrWhiteSpace(group.Name)) throw new InvalidDataException("请填写有效的画风参考组名称与编号。");
        if (group.Images.Select(i => i.Id).Distinct().Count() != group.Images.Count) throw new InvalidDataException("参考组中存在重复图片。");
        var selected = group.Images.Where(i => i.Enabled).OrderBy(i => i.Id == group.PrimaryId ? 0 : 1).ToArray();
        if (selected.Length == 0 || selected[0].Id != group.PrimaryId) throw new InvalidDataException("请勾选参考图片并选择主参考。");
        return selected.Select((item, i) => { _ = AssetPath(item, CacheDirectory); return new PortraitStyleEntry(item, $"references/{group.Id}/{i + 1:00}-{item.Id}{item.Extension}", i + 1); }).ToList();
    }
    public static string Instructions(PortraitDesign design, bool editing, string neutral)
    {
        var entries = Entries(design); if (entries.Count == 0) return editing ? $"上传图1：{neutral}，提供当前人物身份、服装与比例。" : "按下方角色设定生成基准立绘。";
        var group = Selected(design)!;
        string order = string.Join("\n", entries.Select(e => $"上传图{e.Order + (editing ? 1 : 0)}：{e.File}，{(e.Order == 1 ? "主画风参考" : "辅助画风参考")}（{e.Image.Name}）。"));
        return $"画风参考组：{group.Name}\n画风要求：{group.Requirements}\n" + (editing ? $"上传图1：{neutral}，提供当前人物身份、服装与比例。\n" : "") + order
            + "\n风格图片只提供线条、明暗组织、局部渐变、材质笔触、发束高光及细节密度。主参考决定整体绘制方式，辅助参考补充共同特征。人物性别、年龄、种族、面容、身体比例、发型、服装与饰品严格遵循角色设定及人物基准，避免继承风格图中的具体人物、校服、标志性饰品和姿势。风格样本的白底仅用于观察，最终输出按透明PNG要求制作。";
    }
}
