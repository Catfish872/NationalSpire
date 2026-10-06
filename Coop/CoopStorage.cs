using System.Text.Json;

namespace NationalSpire.Coop;

/// <summary>清单最后提交；任何中断都只能恢复一组经过校验的世界与原版对局。</summary>
public sealed class CoopStorage(string root)
{
    public string Root { get; } = root;
    private sealed record Manifest(string Directory, string WorldHash, string RunHash);
    public sealed record Checkpoint(CoopWorld World, byte[]? Run);
    private string DirectoryFor(string id)
    {
        if (!Guid.TryParseExact(id, "N", out _)) throw new InvalidDataException("生涯标识无效。");
        return Path.Combine(Root, id);
    }
    public IEnumerable<Checkpoint> List()
    {
        if (!Directory.Exists(Root)) yield break;
        foreach (var dir in Directory.GetDirectories(Root))
        {
            Checkpoint? cp = null;
            try { cp = Load(Path.GetFileName(dir)); } catch { }
            if (cp != null) yield return cp;
        }
    }
    public static CoopWorld PublicCopy(CoopWorld world)
    {
        return CoopJson.Read<CoopWorld>(CoopJson.PublicBytes(world));
    }
    public void BackupBeforeDevelopment(CoopWorld world, byte[]? run)
    {
        string dir = Path.Combine(DirectoryFor(world.Id), "pre-development3");
        Directory.CreateDirectory(dir);
        string file = Path.Combine(dir, "world.json");
        if (File.Exists(file)) return;
        if (run != null) Durable(Path.Combine(dir, "run.bin"), run);
        Durable(file, CoopJson.PublicBytes(world));
    }
    public void Delete(string id)
    {
        // 仅移动经过 GUID 校验的存档目录，退出列表后仍可从本机备份恢复。
        string source = Path.GetFullPath(DirectoryFor(id));
        string rootPath = Path.GetFullPath(Root).TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
        if (!source.StartsWith(rootPath, StringComparison.OrdinalIgnoreCase)) throw new InvalidDataException("存档路径无效。");
        if (!Directory.Exists(source)) return;
        if ((File.GetAttributes(source) & FileAttributes.ReparsePoint) != 0) throw new InvalidDataException("不能删除重定向目录。");
        string deleted = Path.Combine(Root, ".deleted"); Directory.CreateDirectory(deleted);
        Directory.Move(source, Path.Combine(deleted, id + "-" + Guid.NewGuid().ToString("N")));
    }
    public void Save(CoopWorld world, byte[]? run)
    {
        string dir = DirectoryFor(world.Id); Directory.CreateDirectory(dir);
        string id = Guid.NewGuid().ToString("N"), checkpoint = Path.Combine(dir, id); Directory.CreateDirectory(checkpoint);
        byte[] bytes = CoopJson.PublicBytes(world.CheckpointHeader(id));
        Durable(Path.Combine(checkpoint, "world.json"), bytes);
        if (run != null) Durable(Path.Combine(checkpoint, "run.bin"), run);
        var manifest = new Manifest(id, CoopJson.Hash(bytes), run == null ? "" : CoopJson.Hash(run));
        string current = Path.Combine(dir, "current.json"), next = current + ".tmp";
        Durable(next, CoopJson.Bytes(manifest));
        if (File.Exists(current)) File.Replace(next, current, Path.Combine(dir, "previous.json"));
        else File.Move(next, current);
        // 保留当前与上一份完整检查点，不无限积累每次操作的副本。
        var keep = new HashSet<string> { id };
        try { keep.Add(CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, "previous.json"))).Directory); } catch { }
        foreach (var old in Directory.GetDirectories(dir))
            if (Guid.TryParseExact(Path.GetFileName(old), "N", out _) && !keep.Contains(Path.GetFileName(old)))
                try { Directory.Delete(old, true); } catch { }
    }
    public Checkpoint Load(string id)
    {
        string dir = DirectoryFor(id);
        foreach (string name in new[] { "current.json", "previous.json" })
        {
            try
            {
                var m = CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, name)));
                if (!Guid.TryParseExact(m.Directory, "N", out _)) continue;
                string cp = Path.Combine(dir, m.Directory); byte[] bytes = File.ReadAllBytes(Path.Combine(cp, "world.json"));
                if (CoopJson.Hash(bytes) != m.WorldHash) continue;
                var w = CoopJson.Read<CoopWorld>(bytes);
                if (w.Id != id || w.Schema != 1) continue;
                byte[]? run = m.RunHash.Length == 0 ? null : File.ReadAllBytes(Path.Combine(cp, "run.bin"));
                if (run != null && CoopJson.Hash(run) != m.RunHash) continue;
                if (w.Run?.Phase == "running" && run == null) continue;
                CoopJson.Detached(w.World); return new(w, run);
            }
            catch (Exception e) when (e is IOException or JsonException or InvalidDataException) { }
        }
        throw new InvalidDataException("没有可恢复的完整共同生涯检查点。");
    }
    private static void Durable(string file, byte[] bytes)
    {
        using var stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None, 65536, FileOptions.WriteThrough);
        stream.Write(bytes); stream.Flush(true);
    }
}
