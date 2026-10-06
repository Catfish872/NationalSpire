using System.Text;
using System.Text.Json;
using System.Security.Cryptography;
using NationalSpire.Coop;

namespace NationalSpire;

public static partial class Diagnostics
{
    private static string TraceKey(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value)));

    /// <summary>按生涯和对局独立保存，结算清除实时状态后仍可核对原路线与显示结果。</summary>
    public static void RecordMatch(CoopWorld world, string stage, object? detail = null, bool includePlan = false)
    {
        using var measure = new LogMeasure(LogWork.Match, stage);
        try
        {
            if (world.Run is not { } run) return;
            var match = world.World.Matches.FirstOrDefault(m => m.Id == run.MatchId);
            object? Progress(LiveMatchState? live) => live is { Steps.Count: > 0 } ? RivalSimulation.At(live, run.Clock) : null;
            var last = run.Rival?.Steps.LastOrDefault();
            var differences = new List<string>();
            if (last != null && match != null)
            {
                if (run.Rival!.Cleared != match.OpponentWon) differences.Add("路线通关结果与结算依据不同");
                if (!run.Rival.Cleared && last.Floor != match.OpponentFloor) differences.Add("路线死亡楼层与结算依据不同");
                if (match.OpponentSeconds is { } seconds && Math.Abs(last.End - seconds) > .01) differences.Add("路线结束时间与结算依据不同");
            }
            string line;
            using (new LogMeasure(LogWork.Serialize, stage)) line = JsonSerializer.Serialize(new
            {
                utc = DateTimeOffset.UtcNow, version = ModVersion, stage, world = world.World.WorldId,
                run.Attempt, run.MatchId, run.Seed, run.ResumeCount, run.Phase, run.Clock, run.Act, run.Floor,
                run.Players, opponents = run.Opponents, progress = Progress(run.Rival),
                members = run.RivalMembers.ToDictionary(p => p.Key, p => Progress(p.Value)),
                match = match == null ? null : new { match.OpponentPrepared, match.OpponentWon, match.OpponentFloor, match.OpponentSeconds, match.Status },
                plannedEnd = last == null ? null : new { last.Floor, last.End, run.Rival!.Cleared }, differences,
                plan = includePlan ? run.Rival : null, memberPlans = includePlan ? run.RivalMembers : null, detail
            }, Json);
            line = Redact(line);
            var waiting = new LogMeasure(LogWork.WaitForWrite, stage);
            lock (Gate)
            {
                waiting.Dispose();
                if (_directory == null) return;
                using var writing = new LogMeasure(LogWork.Write, stage);
                string folder = Path.Combine(_directory, "matches", TraceKey(world.World.WorldId));
                Directory.CreateDirectory(folder);
                File.AppendAllText(Path.Combine(folder, TraceKey(run.Attempt) + ".jsonl"), line + "\n", new UTF8Encoding(false));
            }
        }
        catch (Exception e) { Error("match.diagnostics", e); }
    }

    private static IEnumerable<KeyValuePair<string, string>> ReadMatchTraces(string? worldId, bool latestOnly = false)
    {
        string? directory;
        lock (Gate) directory = _directory;
        if (directory == null || string.IsNullOrEmpty(worldId)) yield break;
        FileInfo[] files;
        try
        {
            string folder = Path.Combine(directory, "matches", TraceKey(worldId));
            if (!Directory.Exists(folder)) yield break;
            var ordered = new DirectoryInfo(folder).EnumerateFiles("*.jsonl").OrderByDescending(f => f.LastWriteTimeUtc);
            files = (latestOnly ? ordered.Take(1) : ordered).ToArray();
        }
        catch (Exception e) { Error("match.diagnostics.read", e); yield break; }
        // 每次只处理一份比赛记录，避免所有比赛正文同时驻留内存；读取时释放写入锁。
        foreach (var file in files)
        {
            string? content = null;
            try
            {
                // 在写入锁内打开当前文件，写入器关闭后取得完整记录边界。
                var input = OpenTraceSnapshot(file.FullName, out long length);
                using var snapshot = new TraceSnapshot(input, length);
                using var reader = new StreamReader(snapshot, Encoding.UTF8, true);
                content = Redact(reader.ReadToEnd());
            }
            catch (Exception e) { Error("match.diagnostics.read", e); }
            if (content != null) yield return new(file.Name, content);
        }
    }

    private static FileStream OpenTraceSnapshot(string path, out long length)
    {
        lock (Gate)
        {
            var input = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
            try { length = input.Length; return input; }
            catch { input.Dispose(); throw; }
        }
    }

    // 限定为打开文件时已经写完的字节，持续追加不会让本次导出无限延长。
    private sealed class TraceSnapshot(FileStream input, long length) : Stream
    {
        private readonly long _length = length;
        private long _remaining = length;
        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => _length;
        public override long Position { get => _length - _remaining; set => throw new NotSupportedException(); }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int read = input.Read(buffer, offset, (int)Math.Min(count, _remaining));
            _remaining -= read; return read;
        }
        public override int Read(Span<byte> buffer)
        {
            int read = input.Read(buffer[..(int)Math.Min(buffer.Length, _remaining)]);
            _remaining -= read; return read;
        }
        public override void Flush() { }
        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        protected override void Dispose(bool disposing) { if (disposing) input.Dispose(); base.Dispose(disposing); }
    }
}
