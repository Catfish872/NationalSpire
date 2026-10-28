using System.Text;

namespace NationalSpire;

public static partial class Diagnostics
{
    private const int RetainedLogFiles = 5;
    private sealed record PendingLog(string Path, string Line, int Bytes);
    private static readonly Dictionary<string, Queue<PendingLog>> PendingLogs = [];
    private static readonly Dictionary<string, long> PendingBytes = [];
    private static Task? _retryLogs;
    private static long _expiredPendingRecords;
    private sealed class LogWriter(string path, FileStream stream)
    {
        internal readonly string Path = path;
        internal readonly FileStream Stream = stream;
        internal bool NeedsTrim = true;
    }
    private static readonly Dictionary<string, LogWriter> LogWriters = [];

    private static void CloseLogWriter(string name)
    {
        if (!LogWriters.Remove(name, out var writer)) return;
        try { writer.Stream.Dispose(); }
        catch (Exception error) { _writeError = Redact(error.ToString()); }
    }

    private static void CloseLogWriters()
    {
        foreach (string name in LogWriters.Keys.ToArray()) CloseLogWriter(name);
    }

    private static FileInfo[] LogFiles(string directory, string name) => new DirectoryInfo(directory).EnumerateFiles(name + "*")
        .Where(f => f.Name == name || f.Name.StartsWith(name + ".previous", StringComparison.Ordinal))
        .OrderByDescending(f => f.Name == name).ThenByDescending(f => f.LastWriteTimeUtc).ThenByDescending(f => f.Name).ToArray();

    private static IEnumerable<KeyValuePair<string, string>> LegacyLogs(string folder, string pattern)
    {
        string? root;
        lock (Gate) root = _directory;
        if (root == null) yield break;
        string path = Path.Combine(root, folder);
        string[] files;
        try { files = Directory.Exists(path) ? Directory.GetFiles(path, pattern, SearchOption.AllDirectories) : []; }
        catch (Exception error) { Error("log.legacy.read", error); yield break; }
        foreach (string file in files.OrderBy(File.GetLastWriteTimeUtc))
        {
            string? value = null;
            try { using var input = OpenTraceSnapshot(file, out long length); using var snapshot = new TraceSnapshot(input, length);
                using var reader = new StreamReader(snapshot, Encoding.UTF8, true); value = reader.ReadToEnd(); }
            catch (Exception error) { Error("log.legacy.read", error); }
            if (value != null) yield return new(Path.GetFileName(file), value);
        }
    }

    private static void MigrateLogs()
    {
        lock (Gate)
        {
            if (_directory == null) return;
            foreach (var source in new[] { (Folder: "random-events", Pattern: "*.json", Name: "random-events.jsonl"), (Folder: "matches", Pattern: "*.jsonl", Name: "matches.jsonl") })
            {
                string folder = Path.Combine(_directory, source.Folder);
                try
                {
                    if (!Directory.Exists(folder)) continue;
                    foreach (string file in Directory.GetFiles(folder, source.Pattern, SearchOption.AllDirectories).OrderBy(File.GetLastWriteTimeUtc))
                    {
                        // 旧文件整体成功写入后才移除，读取失败的文件仍可随报告导出。
                        string value = Redact(File.ReadAllText(file, Encoding.UTF8)).TrimEnd('\r', '\n');
                        if (AppendLog(Path.Combine(_directory, source.Name), value)) File.Delete(file);
                    }
                }
                catch (Exception error) { _writeError = Redact(error.ToString()); }
            }
        }
    }

    // 各功能共用完整记录写入和五份轮换；轮换点控制历史长度，单条记录始终完整。
    private static bool AppendLog(string path, string line)
    {
        string name = Path.GetFileName(path);
        try
        {
            if (LogWriters.TryGetValue(name, out var writer) && writer.Path != path)
            {
                CloseLogWriter(name); writer = null;
            }
            writer ??= Open();
            if (writer.Stream.Length >= LogLimit)
            {
                CloseLogWriter(name);
                string archive = path + ".previous";
                if (File.Exists(archive)) archive += "." + DateTime.UtcNow.Ticks + "-" + Guid.NewGuid().ToString("N");
                File.Move(path, archive);
                writer = Open();
            }
            Append(writer.Stream, line);
            if (writer.NeedsTrim)
            {
                writer.NeedsTrim = false;
                foreach (var file in LogFiles(Path.GetDirectoryName(path)!, name).Skip(RetainedLogFiles))
                    try { file.Delete(); }
                    catch (Exception error) { writer.NeedsTrim = true; _writeError = Redact(error.ToString()); }
            }
            return true;

            LogWriter Open()
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                var opened = new LogWriter(path, new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read | FileShare.Delete));
                LogWriters[name] = opened;
                return opened;
            }
        }
        catch (Exception error) { _writeError = Redact(error.ToString()); CloseLogWriter(name); return false; }

        static void Append(FileStream output, string value)
        {
            long start = output.Length;
            try
            {
                output.Position = start;
                byte[] bytes = Encoding.UTF8.GetBytes(value + "\n");
                output.Write(bytes); output.Flush();
            }
            catch { output.SetLength(start); throw; }
        }
    }

    private static void WriteLog(string name, string line)
    {
        lock (Gate)
        {
            if (_directory == null) return;
            string path = Path.Combine(_directory, name);
            if ((!PendingLogs.TryGetValue(name, out var pending) || pending.Count == 0) && AppendLog(path, line)) return;
            pending ??= new(); PendingLogs[name] = pending;
            int bytes = Encoding.UTF8.GetByteCount(line) + 1;
            pending.Enqueue(new(path, line, bytes));
            long retained = PendingBytes.GetValueOrDefault(name) + bytes;
            // 写入暂不可用时，内存沿用五份日志的保留范围，至少保留最新完整记录。
            while (pending.Count > 1 && retained > (long)LogLimit * RetainedLogFiles)
            { retained -= pending.Dequeue().Bytes; _expiredPendingRecords++; }
            PendingBytes[name] = retained;
            if (_retryLogs == null || _retryLogs.IsCompleted) _retryLogs = Task.Run(RetryLogs);
        }
    }

    private static async Task RetryLogs()
    {
        while (true)
        {
            await Task.Delay(1000).ConfigureAwait(false);
            lock (Gate)
            {
                foreach (var pair in PendingLogs)
                    while (pair.Value.TryPeek(out var record) && AppendLog(record.Path, record.Line))
                    { pair.Value.Dequeue(); PendingBytes[pair.Key] -= record.Bytes; }
                if (PendingLogs.Values.All(q => q.Count == 0)) { _retryLogs = null; return; }
            }
        }
    }

    private static IEnumerable<KeyValuePair<string, string>> ReadLogs(string name)
    {
        string? directory;
        lock (Gate) directory = _directory;
        if (directory == null) yield break;
        var snapshots = new List<(string Name, TraceSnapshot Stream)>();
        string pending;
        lock (Gate)
        {
            try
            {
                foreach (var file in (Directory.Exists(directory) ? LogFiles(directory, name) : []).Reverse())
                    try { var input = OpenTraceSnapshot(file.FullName, out long length); snapshots.Add((file.Name, new(input, length))); }
                    catch (Exception error) { _writeError = Redact(error.ToString()); }
            }
            catch (Exception error) { _writeError = Redact(error.ToString()); }
            pending = PendingLogs.TryGetValue(name, out var queue)
                ? string.Join('\n', queue.Where(p => Path.GetDirectoryName(p.Path) == directory).Select(p => p.Line)) : "";
        }
        try
        {
            foreach (var item in snapshots)
            {
                string? text = null;
                try { using var reader = new StreamReader(item.Stream, Encoding.UTF8, true, leaveOpen: true); text = reader.ReadToEnd(); }
                catch (Exception error) { lock (Gate) _writeError = Redact(error.ToString()); }
                if (text != null) yield return new(item.Name, text);
            }
            if (pending.Length > 0) yield return new(name + ".pending", pending);
        }
        finally { foreach (var item in snapshots) item.Stream.Dispose(); }
    }
}
