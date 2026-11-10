using System.IO.Compression;
using System.Text.Json;
using NationalSpire.Coop;

namespace NationalSpire;

public sealed record CareerLibraryEntry(string Path, string Name, int Season, int Day, bool Current, string Date);

public static class CareerLibrary
{
    private static string Selection(string original) => original + ".selected";
    public static string SelectedPath(string original)
    {
        if (!File.Exists(Selection(original))) return original;
        string file = File.ReadAllText(Selection(original)).Trim();
        string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, file);
        return ValidName(file) && File.Exists(path) ? path : original;
    }
    private static bool ValidName(string file) => file == "national_spire_career.json" || file.StartsWith("national_spire_career-") && file.EndsWith(".json") && Guid.TryParseExact(file[22..^5], "N", out _);
    internal static IEnumerable<string> SavedPaths(string folder) => !Directory.Exists(folder) ? [] :
        Directory.EnumerateFiles(folder, "national_spire_career*.json").Where(f => ValidName(Path.GetFileName(f))).OrderByDescending(File.GetLastWriteTimeUtc);
    internal static string DisplayName(CareerData data, string? original = null) =>
        string.IsNullOrWhiteSpace(data.SaveName) ? original ?? CareerEngine.Name(data) : data.SaveName;
    internal static string CheckedName(string name)
    {
        name = name.Trim();
        if (name.Length is 0 or > 80 || name.Any(char.IsControl))
            throw new InvalidDataException("请输入 1 到 80 个字符的存档名称。");
        return name;
    }
    internal static string CheckedPath(string original, string path)
    {
        path = Path.GetFullPath(path);
        if (!string.Equals(Path.GetDirectoryName(Path.GetFullPath(original)), Path.GetDirectoryName(path), StringComparison.OrdinalIgnoreCase) || !ValidName(Path.GetFileName(path)))
            throw new InvalidDataException("生涯路径无效。");
        return path;
    }
    public static void Select(string original, string path)
    {
        path = CheckedPath(original, path);
        File.WriteAllText(Selection(original) + ".tmp", System.IO.Path.GetFileName(path)); File.Move(Selection(original) + ".tmp", Selection(original), true);
    }
    public static IEnumerable<CareerLibraryEntry> List(string original)
    {
        string selected = SelectedPath(original), folder = System.IO.Path.GetDirectoryName(original)!;
        if (!Directory.Exists(folder)) yield break;
        foreach (string file in SavedPaths(folder))
        {
            CareerData? d = null; try { using var input = File.OpenRead(file); d = JsonText.Read<CareerData>(input, CoopJson.Options); } catch { }
            if (d != null) yield return new(file, DisplayName(d), d.Season, SeasonCalendar.Day(d, d.Day), file == selected, GameCalendar.Text(d, d.Day));
        }
    }
    public static string Create(string original, CareerData data)
    {
        GameCalendar.Initialize(data);
        string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, "national_spire_career-" + Guid.NewGuid().ToString("N") + ".json");
        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!); File.WriteAllBytes(path, CoopJson.PublicBytes(data)); return path;
    }
    public static string Delete(string original, string path)
    {
        path = CheckedPath(original, path);
        string folder = Path.GetDirectoryName(path)!, file = Path.GetFileName(path);
        if (string.Equals(path, System.IO.Path.GetFullPath(SelectedPath(original)), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("请先切换到另一份生涯，再删除当前生涯。");
        string backup = System.IO.Path.Combine(folder, ".deleted", file + "-" + Guid.NewGuid().ToString("N"));
        var files = Directory.GetFiles(folder, file + ".*").Where(p =>
        {
            string suffix = p[path.Length..];
            return suffix is ".bak" or ".tmp" or ".run" or ".run.backup" || suffix.StartsWith(".pre-") || suffix.StartsWith(".reset-") || suffix.StartsWith(".broken-");
        }).Append(path).ToArray();
        Directory.CreateDirectory(backup);
        var moved = new List<string>();
        try
        {
            foreach (string source in files) { File.Move(source, System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source))); moved.Add(source); }
        }
        catch
        {
            foreach (string source in moved.AsEnumerable().Reverse()) File.Move(System.IO.Path.Combine(backup, System.IO.Path.GetFileName(source)), source);
            Directory.Delete(backup); throw;
        }
        return backup;
    }
    public static byte[] Export(CareerData data, byte[]? run = null, byte[]? backup = null)
    {
        using var buffer = new MemoryStream();
        using (var zip = new ZipArchive(buffer, ZipArchiveMode.Create, true))
        {
            using (var stream = zip.CreateEntry("career.json").Open()) stream.Write(CoopJson.PublicBytes(data));
            if (run != null) { using var stream = zip.CreateEntry("run.save").Open(); stream.Write(run); }
            if (backup != null) { using var stream = zip.CreateEntry("run.backup").Open(); stream.Write(backup); }
        }
        return buffer.ToArray();
    }
    public static string Import(string original, byte[] bytes)
    {
        using var zip = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read);
        var entry = zip.GetEntry("career.json") ?? throw new InvalidDataException("文件没有单人生涯记录。");
        using var stream = entry.Open(); var data = JsonText.Read<CareerData>(stream, CoopJson.Options) ?? throw new InvalidDataException("生涯内容为空。");
        if (data.Version > 4 || data.People is not { Count: > 0 } || data.Season < 1 || data.LongSeasonsFrom < 0 || data.Day <= SeasonCalendar.Start(data) || data.Day > SeasonCalendar.End(data)
            || data.Matches == null || data.Results == null || data.Posts == null || data.Standings == null || data.Ai == null) throw new InvalidDataException("生涯版本或内容无效。");
        byte[]? run = null;
        if (zip.GetEntry("run.save") is { } native) { using var source = native.Open(); using var target = new MemoryStream(); source.CopyTo(target); run = target.ToArray(); }
        byte[]? backup = null;
        if (zip.GetEntry("run.backup") is { } nativeBackup) { using var source = nativeBackup.Open(); using var target = new MemoryStream(); source.CopyTo(target); backup = target.ToArray(); }
        if (data.PendingMatchId != null && run == null && backup == null) throw new InvalidDataException("这份生涯包缺少未完成对局的原版存档。");
        string path = Create(original, data); if (run != null) File.WriteAllBytes(path + ".run", run); if (backup != null) File.WriteAllBytes(path + ".run.backup", backup); return path;
    }
    public static string ExportDesktop(string name, byte[] bytes)
    {
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "国运尖塔-" + string.Concat(name.Select(c => System.IO.Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)) + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".zip");
        File.WriteAllBytes(path, bytes); return path;
    }
}
