using System.IO.Compression;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace NationalSpire;

/// <summary>保留有界的运行记录；导出时合并生涯、请求和游戏日志，统一隐藏凭据。</summary>
public static partial class Diagnostics
{
    public const string ModVersion = "0.26.7";

    // 开赛失败逐次记录；读取诊断资料失败时仍保留最初的异常及其余资料。
    public static string RecordStartFailure(string stage, Exception error,
        IReadOnlyDictionary<string, Func<object?>> context, string category = "match.start")
    {
        var values = new Dictionary<string, object?>();
        foreach (var item in context)
        {
            try { values[item.Key] = item.Value(); }
            catch (Exception readError) { values[item.Key] = new { readError = readError.ToString() }; }
        }
        Record(category, new { stage, modVersion = ModVersion, context = values, exception = error.ToString() });
        return $"开赛失败：{stage}\n{Redact(error.GetBaseException().Message)}";
    }
    private const int LogLimit = 2 * 1024 * 1024;
    private static readonly object Gate = new();
    private static readonly Queue<string> Events = new();
    private static readonly HashSet<string> Secrets = [];
    private static (string Raw, string Url, string Json)[] SecretForms = [];
    private static readonly string UserHome = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    private static readonly string EscapedUserHome = UserHome.Replace("\\", "\\\\");
    private static readonly Dictionary<string, int> ErrorCounts = [];
    private static readonly JsonSerializerOptions Json = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    private static string? _directory;
    private static int _eventChars;
    private static string _writeError = "";
    public static Func<object>? RuntimeSnapshot { get; set; }

    static Diagnostics() => AppDomain.CurrentDomain.ProcessExit += (_, _) => SaveLoggingPerformance();

    public static void Configure(string directory)
    {
        lock (Gate) _directory = directory;
    }

    public static void RegisterSecret(string? secret)
    {
        if (string.IsNullOrEmpty(secret)) return;
        lock (Gate)
        {
            if (!Secrets.Add(secret)) return;
            // 历史凭据继续参与脱敏，重复注册不重新准备匹配资料。
            SecretForms = Secrets.OrderByDescending(s => s.Length)
                .Select(s => (s, Uri.EscapeDataString(s), JsonSerializer.Serialize(s, Json)[1..^1])).ToArray();
        }
    }

    public static string Redact(string text)
    {
        using var measure = new LogMeasure(LogWork.Redact);
        (string Raw, string Url, string Json)[] forms;
        lock (Gate) forms = SecretForms;
            foreach (var secret in forms)
            {
                text = text.Replace(secret.Raw, "[已隐藏凭据]", StringComparison.Ordinal);
                text = text.Replace(secret.Url, "[已隐藏凭据]", StringComparison.OrdinalIgnoreCase);
                text = text.Replace(secret.Json, "[已隐藏凭据]", StringComparison.Ordinal);
            }
        text = Regex.Replace(text, @"(?i)(https?://)[^/\s:@]+:[^/\s@]+@", "$1[已隐藏凭据]@");
        // 地址的查询参数可能承载自建服务凭据，全部隐藏其值。
        text = Regex.Replace(text, @"([?&][\w.-]+=)[^\s&#""<>\\]+", "$1[已隐藏参数]");
        text = Regex.Replace(text, @"(?i)(bearer\s+)[^\s""<>\\]+", "$1[已隐藏凭据]");
        text = Regex.Replace(text, @"(?i)((?:api[_-]?key|authorization|access[_-]?token|password|secret)(?:\\?[""'])?\s*[:=]\s*(?:\\?[""'])?)[^\s,""'<>}\\]+", "$1[已隐藏凭据]");
        text = Regex.Replace(text, @"\bsk-[A-Za-z0-9_-]{8,}\b", "[已隐藏凭据]");
        if (UserHome.Length > 0) text = text.Replace(UserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase)
            .Replace(EscapedUserHome, "[用户目录]", StringComparison.OrdinalIgnoreCase);
        return text;
    }

    public static void Record(string category, object detail)
    {
        using var measure = new LogMeasure(LogWork.Record, category);
        // 诊断记录失败不能中断比赛或 AI 更新。
        try
        {
            string body;
            using (new LogMeasure(LogWork.Serialize, category)) body = detail is string s ? s : JsonSerializer.Serialize(detail, Json);
            body = Redact(body);
            bool clipped = body.Length > 131072;
            if (clipped) body = body[..131072];
            string line;
            using (new LogMeasure(LogWork.Serialize, category)) line = JsonSerializer.Serialize(new { utc = DateTimeOffset.UtcNow, category, detail = body, clipped }, Json);
            var waiting = new LogMeasure(LogWork.WaitForWrite, category);
            lock (Gate)
            {
                waiting.Dispose();
                Events.Enqueue(line); _eventChars += line.Length;
                while (Events.Count > 512 || _eventChars > LogLimit) _eventChars -= Events.Dequeue().Length;
                _peakEvents = Math.Max(_peakEvents, Events.Count); _peakEventChars = Math.Max(_peakEventChars, _eventChars);
                if (_directory == null) return;
                using var writing = new LogMeasure(LogWork.Write, category);
                Directory.CreateDirectory(_directory);
                string path = Path.Combine(_directory, "national-spire.log");
                if (File.Exists(path) && new FileInfo(path).Length > LogLimit)
                    File.Move(path, path + ".previous", true);
                File.AppendAllText(path, line + "\n", Encoding.UTF8);
            }
        }
        catch (Exception e) { lock (Gate) _writeError = e.GetType().Name + ": " + e.Message; }
    }

    public static void Error(string category, Exception error)
    {
        string signature = category + ":" + error.GetType().Name + ":" + error.Message;
        int count;
        lock (Gate)
        {
            if (ErrorCounts.Count >= 64 && !ErrorCounts.ContainsKey(signature)) ErrorCounts.Remove(ErrorCounts.Keys.First());
            count = ErrorCounts.GetValueOrDefault(signature) + 1; ErrorCounts[signature] = count;
        }
        if (count <= 3 || count % 100 == 0) Record(category, new { occurrences = count, exception = error.ToString() });
    }

    public static Dictionary<string, string> CapturePeerLogs(string gameLogDirectory, string status, string? worldId = null)
    {
        using var measure = new LogMeasure(LogWork.Capture);
        var files = new Dictionary<string, string>(); var notes = new List<string>();
        files["summary.json"] = JsonSerializer.Serialize(new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow, status, logging = LoggingPerformance() }, Json);
        files["ui-performance.json"] = JsonSerializer.Serialize(UiPerformance.Snapshot(), Json);
        try { if (RuntimeSnapshot != null) files["runtime.json"] = JsonSerializer.Serialize(RuntimeSnapshot(), Json); }
        catch (Exception e) { notes.Add(e.Message); }
        string? directory;
        lock (Gate)
        {
            files["error-counts.json"] = JsonSerializer.Serialize(ErrorCounts, Json);
            string events = string.Join('\n', Events); files["session-events.jsonl"] = events.Length > 262144 ? events[^262144..] : events;
            directory = _directory;
        }
        void Tail(string path, string entry)
        {
            try
            {
                using var input = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                long skipped = Math.Max(0, input.Length - 262144); input.Seek(skipped, SeekOrigin.Begin);
                using var reader = new StreamReader(input, Encoding.UTF8, true);
                if (skipped > 0) reader.ReadLine();
                files[entry] = reader.ReadToEnd(); notes.Add(entry + " ← " + Path.GetFileName(path) + (skipped > 0 ? "（仅末尾256 KiB）" : ""));
            }
            catch (Exception e) { notes.Add(entry + "：" + e.Message); }
        }
        if (directory != null && File.Exists(Path.Combine(directory, "national-spire.log"))) Tail(Path.Combine(directory, "national-spire.log"), "mod-log.txt");
        try
        {
            int index = 0;
            if (Directory.Exists(gameLogDirectory)) foreach (var log in new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log").OrderByDescending(f => f.LastWriteTimeUtc).Take(3))
                Tail(log.FullName, "game-log-" + (++index) + ".txt");
            if (index == 0) notes.Add("未找到游戏日志。");
        }
        catch (Exception e) { notes.Add(e.Message); }
        foreach (var trace in ReadMatchTraces(worldId, latestOnly: true)) files["latest-match.jsonl"] = trace.Value;
        files["notes.txt"] = string.Join('\n', notes);
        return files.ToDictionary(p => p.Key, p => Redact(p.Value));
    }

    public static string Export(CareerData data, string careerPath, string gameLogDirectory, string aiStatus, object? cooperative = null, IReadOnlyDictionary<string, string>? peerReports = null)
    {
        var measure = new LogMeasure(LogWork.Export);
        string path = careerPath + ".diagnostics-" + DateTime.UtcNow.ToString("yyyyMMdd-HHmmss-fff") + "-" + Guid.NewGuid().ToString("N")[..6] + ".zip";
        var notes = new List<string>();
        try
        {
            using var file = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            using var zip = new ZipArchive(file, ZipArchiveMode.Create);
            void Write(string name, string value)
            {
                using var writer = new StreamWriter(zip.CreateEntry(name, CompressionLevel.Fastest).Open(), new UTF8Encoding(false));
                writer.Write(Redact(value));
            }
            void Section(string name, Func<object> read)
            {
                try { Write(name, JsonSerializer.Serialize(read(), Json)); }
                catch (Exception e) { notes.Add(name + "：" + Redact(e.ToString())); }
            }
            void LogFile(string log, string entry)
            {
                try
                {
                    using var input = new FileStream(log, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                    long skipped = Math.Max(0, input.Length - LogLimit);
                    input.Seek(skipped, SeekOrigin.Begin);
                    using var reader = new StreamReader(input, Encoding.UTF8, true);
                    if (skipped > 0) { reader.ReadLine(); notes.Add(entry + $"：仅保留末尾 {LogLimit} 字节，省略较早约 {skipped} 字节。"); }
                    Write(entry, reader.ReadToEnd());
                }
                catch (Exception e) { notes.Add(entry + "：" + Redact(e.ToString())); }
            }
            Section("summary.json", () => new { modVersion = ModVersion, exportedUtc = DateTimeOffset.UtcNow,
                os = System.Runtime.InteropServices.RuntimeInformation.OSDescription, runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
                data.Day, data.Season, data.Version, data.PendingMatchId, data.SelectedCharacter, data.SelectedAscension, aiStatus,
                matches = data.Matches.Count, results = data.Results.Count, posts = data.Posts.Count });
            // 完整模组状态用于核对赛程、种子、路线、楼层引用和生成任务；不读取原版存档或密钥文件。
            Section("career.json", () => data);
            Section("logging-performance.json", LoggingPerformance);
            Section("ui-performance.json", UiPerformance.Snapshot);
            string? performanceDirectory;
            lock (Gate) performanceDirectory = _directory;
            if (performanceDirectory != null && File.Exists(Path.Combine(performanceDirectory, "logging-performance.json")))
                LogFile(Path.Combine(performanceDirectory, "logging-performance.json"), "logging-last-snapshot.json");
            if (performanceDirectory != null && File.Exists(Path.Combine(performanceDirectory, "ui-performance.json")))
                LogFile(Path.Combine(performanceDirectory, "ui-performance.json"), "ui-last-snapshot.json");
            foreach (var trace in ReadMatchTraces(data.WorldId)) Write("matches/" + trace.Key, trace.Value);
            if (cooperative != null) Section("cooperative.json", () => cooperative);
            if (peerReports != null) foreach (var report in peerReports) Write(report.Key, report.Value);
            if (RuntimeSnapshot != null) Section("runtime.json", RuntimeSnapshot);
            else notes.Add("runtime.json：当前环境未提供游戏运行状态。");
            Section("assemblies.json", () => AppDomain.CurrentDomain.GetAssemblies().Select(a => new { name = a.GetName().Name, version = a.GetName().Version?.ToString() }).OrderBy(a => a.name).ToArray());
            string[] events; string? directory;
            lock (Gate)
            {
                events = Events.ToArray(); directory = _directory;
                Section("error-counts.json", () => ErrorCounts.ToDictionary(p => p.Key, p => p.Value));
                if (_writeError.Length > 0) notes.Add("运行日志写入失败：" + Redact(_writeError));
            }
            Write("session-events.jsonl", string.Join('\n', events));
            if (directory != null)
                foreach (string name in new[] { "national-spire.log", "national-spire.log.previous" })
                {
                    string log = Path.Combine(directory, name);
                    if (File.Exists(log)) LogFile(log, "mod-logs/" + name);
                }
            try
            {
                var logs = Directory.Exists(gameLogDirectory) ? new DirectoryInfo(gameLogDirectory).EnumerateFiles("*.log")
                    .OrderByDescending(f => f.LastWriteTimeUtc).Take(3).ToArray() : [];
                if (logs.Length == 0) notes.Add("未找到游戏日志；其余报告内容已保留。");
                foreach (var log in logs) LogFile(log.FullName, "game-logs/" + log.Name);
            }
            catch (Exception e) { notes.Add("游戏日志读取失败：" + Redact(e.ToString())); }
            Write("说明.txt", "问题报告 v" + ModVersion + "\n\n包含当前模组生涯、比赛种子及路线、社区和生成状态、运行环境、最近请求与错误记录。\n"
                + "AI 请求记录含发送的提示词和收到的内容，便于排查上下文与格式问题。凭据已自动隐藏。\n"
                + "请同时说明操作步骤、发生时间以及预期结果。截图可另附。\n"
                + "日志按大小轮换，每份最多导出末尾 2 MiB；单条记录最多保留 131072 个字符并标注 clipped。\n"
                + "matches 目录独立保存本生涯的多人比赛路线与进度，不随普通日志轮换；队友报告附最近一场比赛记录。\n"
                + "导出缺失项及截取情况：\n" + (notes.Count == 0 ? "所有项目读取完成。" : string.Join("\n", notes)));
            return path;
        }
        catch { if (File.Exists(path)) File.Delete(path); throw; }
        finally { measure.Dispose(); SaveLoggingPerformance(); }
    }
}

