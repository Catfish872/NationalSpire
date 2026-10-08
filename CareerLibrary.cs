using System.IO.Compression;
using System.Text.Json;
using NationalSpire.Coop;

namespace NationalSpire;

public sealed record CareerLibraryEntry(string Path, string Name, int Season, int Day, bool Current);

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
    public static void Select(string original, string path)
    {
        if (System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(original)) != System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(path)) || !ValidName(System.IO.Path.GetFileName(path))) throw new InvalidDataException("生涯路径无效。");
        File.WriteAllText(Selection(original) + ".tmp", System.IO.Path.GetFileName(path)); File.Move(Selection(original) + ".tmp", Selection(original), true);
    }
    public static IEnumerable<CareerLibraryEntry> List(string original)
    {
        string selected = SelectedPath(original), folder = System.IO.Path.GetDirectoryName(original)!;
        if (!Directory.Exists(folder)) yield break;
        foreach (string file in Directory.GetFiles(folder, "national_spire_career*.json").Where(f => ValidName(System.IO.Path.GetFileName(f))).OrderByDescending(File.GetLastWriteTimeUtc))
        {
            CareerData? d = null; try { d = CoopJson.Read<CareerData>(File.ReadAllBytes(file)); } catch { }
            if (d != null) yield return new(file, CareerEngine.Name(d), d.Season, SeasonCalendar.Day(d, d.Day), file == selected);
        }
    }
    public static string Create(string original, CareerData data)
    {
        string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(original)!, "national_spire_career-" + Guid.NewGuid().ToString("N") + ".json");
        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!); File.WriteAllBytes(path, CoopJson.PublicBytes(data)); return path;
    }
    public static void SwitchNative(CareerData current, string currentPath, CareerData target, string targetPath, string native)
    {
        if (current.PendingMatchId == null && (File.Exists(native) || File.Exists(native + ".backup"))) throw new InvalidOperationException("请先完成当前原版对局。");
        if (current.PendingMatchId != null && File.Exists(native)) File.Copy(native, currentPath + ".run", true);
        if (current.PendingMatchId != null && File.Exists(native + ".backup")) File.Copy(native + ".backup", currentPath + ".run.backup", true);
        byte[]? oldNative = File.Exists(native) ? File.ReadAllBytes(native) : null;
        byte[]? oldBackup = File.Exists(native + ".backup") ? File.ReadAllBytes(native + ".backup") : null;
        try
        {
            if (target.PendingMatchId != null && File.Exists(targetPath + ".run"))
            { Directory.CreateDirectory(System.IO.Path.GetDirectoryName(native)!); File.Copy(targetPath + ".run", native, true); }
            else if (target.PendingMatchId != null && File.Exists(targetPath + ".run.backup")) File.Copy(targetPath + ".run.backup", native, true);
            else if (target.PendingMatchId != null) throw new InvalidDataException("这份生涯缺少未完成对局的原版存档。");
            else if (current.PendingMatchId != null && File.Exists(native)) File.Delete(native);
            if (target.PendingMatchId != null && File.Exists(targetPath + ".run.backup")) File.Copy(targetPath + ".run.backup", native + ".backup", true);
            else if (File.Exists(native + ".backup")) File.Delete(native + ".backup");
        }
        catch { RestoreNative(native, oldNative, oldBackup); throw; }
    }
    public static void RestoreNative(string native, byte[]? run, byte[]? backup)
    {
        foreach (var item in new[] { (Path: native, Bytes: run), (Path: native + ".backup", Bytes: backup) })
            if (item.Bytes != null) { Directory.CreateDirectory(System.IO.Path.GetDirectoryName(item.Path)!); File.WriteAllBytes(item.Path, item.Bytes); }
            else if (File.Exists(item.Path)) File.Delete(item.Path);
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
        using var stream = entry.Open(); using var reader = new StreamReader(stream); var data = JsonSerializer.Deserialize<CareerData>(reader.ReadToEnd(), CoopJson.Options) ?? throw new InvalidDataException("生涯内容为空。");
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
