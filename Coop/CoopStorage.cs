using System.Text.Json;

namespace NationalSpire.Coop;

using System.IO.Compression;

/// <summary>清单最后提交；任何中断都只能恢复一组经过校验的世界与原版对局。</summary>
public sealed class CoopStorage(string root)
{
    private sealed class DirectoryWork { public readonly object Gate = new(); public Task Tail = Task.CompletedTask; public int Writes; }
    private static readonly object DirectoriesGate = new();
    private static readonly Dictionary<string, DirectoryWork> Directories = new(StringComparer.OrdinalIgnoreCase);
    private DirectoryWork Work(string id)
    {
        string path = Path.GetFullPath(DirectoryFor(id));
        lock (DirectoriesGate)
        { if (!Directories.TryGetValue(path, out var work)) Directories[path] = work = new(); return work; }
    }
    private Task<T> Schedule<T>(string id, Func<T> action, CancellationToken token = default, bool write = false)
    {
        var work = Work(id);
        lock (DirectoriesGate)
        {
            var previous = work.Tail;
            if (write) work.Writes++;
            var task = Task.Run(async () =>
            {
                try
                {
                    // 前一项错误由原调用者处理；目录协调不新增业务重试或阻断后续操作。
                    try { await previous.ConfigureAwait(false); } catch { }
                    token.ThrowIfCancellationRequested();
                    return action();
                }
                finally { if (write) lock (DirectoriesGate) work.Writes--; }
            });
            work.Tail = task.ContinueWith(t => { _ = t.Exception; }, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
            return task;
        }
    }
    public Task SaveAsync(CoopWorld world, byte[]? run, CancellationToken token = default)
        => Schedule(world.Id, () => { Save(world, run); return true; }, token, true);
    public Task<Checkpoint> LoadAsync(string id) => Schedule(id, () => Load(id));
    public Task<byte[]> ExportArchiveAsync(string id) => Schedule(id, () => ExportArchive(id));
    public Task DeleteAsync(string id) => Schedule(id, () => { Delete(id); return true; });
    public Task<string> ImportArchiveAsync(byte[] bytes) => Task.Run(() => ImportArchive(bytes));
    public async Task<List<Checkpoint>> ListAsync()
    {
        string[] dirs = await Task.Run(() => Directory.Exists(Root) ? Directory.GetDirectories(Root) : []);
        var result = new List<Checkpoint>();
        foreach (string dir in dirs)
            try { result.Add(await LoadAsync(Path.GetFileName(dir))); } catch { }
        return result;
    }
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
    public static bool IsArchive(byte[] bytes)
    {
        using var zip = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read);
        return zip.GetEntry("world.json") != null;
    }
    public byte[] ExportArchive(string id)
    {
        var checkpoint = Load(id);
        using var buffer = new MemoryStream();
        using (var zip = new ZipArchive(buffer, ZipArchiveMode.Create, true))
        {
            using (var stream = zip.CreateEntry("world.json").Open()) stream.Write(CoopJson.PublicBytes(checkpoint.World));
            if (checkpoint.Run != null) { using var stream = zip.CreateEntry("run.bin").Open(); stream.Write(checkpoint.Run); }
        }
        return buffer.ToArray();
    }
    public string ImportArchive(byte[] bytes)
    {
        using var zip = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read);
        using var source = (zip.GetEntry("world.json") ?? throw new InvalidDataException("没有多人生涯内容。")).Open();
        using var buffer = new MemoryStream(); source.CopyTo(buffer); var world = CoopJson.Read<CoopWorld>(buffer.ToArray());
        if (world.Schema != 1 || !Guid.TryParseExact(world.Id, "N", out _) || world.Owner == 0 || world.Members.Count < 2 || world.Members.Select(m => m.SteamId).Distinct().Count() != world.Members.Count || world.World.People.Count == 0) throw new InvalidDataException("多人生涯结构无效。");
        byte[]? run = null;
        if (zip.GetEntry("run.bin") is { } native) { using var stream = native.Open(); using var target = new MemoryStream(); stream.CopyTo(target); run = target.ToArray(); }
        if (world.Run is { Phase: "running", Terminal: null } && run == null) throw new InvalidDataException("比赛存档缺失。");
        lock (DirectoriesGate)
        {
            if (Directory.Exists(DirectoryFor(world.Id)) || Work(world.Id).Writes > 0)
            { world.Id = Guid.NewGuid().ToString("N"); world.World.WorldId = world.Id; }
            Directory.CreateDirectory(DirectoryFor(world.Id));
        }
        world.Proposal = null; Save(world, run); return world.Id;
    }
    public void BackupBeforeDevelopment(CoopWorld world, byte[]? run)
    {
        lock (Work(world.Id).Gate)
        {
        string dir = Path.Combine(DirectoryFor(world.Id), "pre-development3");
        Directory.CreateDirectory(dir);
        string file = Path.Combine(dir, "world.json");
        if (File.Exists(file)) return;
        if (run != null) Durable(Path.Combine(dir, "run.bin"), run);
        Durable(file, CoopJson.PublicBytes(world));
        }
    }
    public void Delete(string id)
    {
        lock (Work(id).Gate)
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
    }
    public void Save(CoopWorld world, byte[]? run)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.CoopSave);
        string dir = DirectoryFor(world.Id);
        string id = Guid.NewGuid().ToString("N"), checkpoint = Path.Combine(dir, id);
        byte[] bytes;
        using (UiPerformance.Measure(UiPerformance.Work.CoopSerialize)) bytes = CoopJson.PublicBytes(world.CheckpointHeader(id));
        lock (Work(world.Id).Gate)
        {
        Directory.CreateDirectory(checkpoint);
        using (UiPerformance.Measure(UiPerformance.Work.CoopWriteWorld)) Durable(Path.Combine(checkpoint, "world.json"), bytes);
        if (run != null) using (UiPerformance.Measure(UiPerformance.Work.CoopWriteRun)) Durable(Path.Combine(checkpoint, "run.bin"), run);
        Manifest manifest;
        using (UiPerformance.Measure(UiPerformance.Work.CoopHash)) manifest = new Manifest(id, CoopJson.Hash(bytes), run == null ? "" : CoopJson.Hash(run));
        string current = Path.Combine(dir, "current.json"), next = current + ".tmp";
        using (UiPerformance.Measure(UiPerformance.Work.CoopManifest))
        {
            Durable(next, CoopJson.Bytes(manifest));
            if (File.Exists(current)) File.Replace(next, current, Path.Combine(dir, "previous.json"));
            else File.Move(next, current);
        }
        // 保留当前与上一份完整检查点，不无限积累每次操作的副本。
        using var cleanup = UiPerformance.Measure(UiPerformance.Work.CoopCleanup);
        var keep = new HashSet<string> { id };
        try { keep.Add(CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, "previous.json"))).Directory); } catch { }
        foreach (var old in Directory.GetDirectories(dir))
            if (Guid.TryParseExact(Path.GetFileName(old), "N", out _) && !keep.Contains(Path.GetFileName(old)))
                try { Directory.Delete(old, true); } catch { }
        }
    }
    public Checkpoint Load(string id)
    {
        string dir = DirectoryFor(id);
        var candidates = new List<(Manifest Manifest, byte[] World, byte[]? Run)>();
        lock (Work(id).Gate)
        {
        foreach (string name in new[] { "current.json", "previous.json" })
        {
            try
            {
                var m = CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, name)));
                if (!Guid.TryParseExact(m.Directory, "N", out _)) continue;
                string cp = Path.Combine(dir, m.Directory); byte[] bytes = File.ReadAllBytes(Path.Combine(cp, "world.json"));
                byte[]? run = m.RunHash.Length == 0 ? null : File.ReadAllBytes(Path.Combine(cp, "run.bin"));
                candidates.Add((m, bytes, run));
            }
            catch (Exception e) when (e is IOException or JsonException or InvalidDataException) { }
        }
        }
        foreach (var (m, bytes, run) in candidates)
        {
            try
            {
                if (CoopJson.Hash(bytes) != m.WorldHash) continue;
                var w = CoopJson.Read<CoopWorld>(bytes);
                if (w.Id != id || w.Schema != 1) continue;
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
