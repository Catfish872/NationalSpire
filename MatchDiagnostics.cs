using System.Text;
using System.Text.Json;
using System.Security.Cryptography;
using NationalSpire.Coop;

namespace NationalSpire;

public static partial class Diagnostics
{
    private static string TraceKey(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value)));

    /// <summary>比赛完整记录使用统一轮换，导出时按记录中的生涯编号选择。</summary>
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
                WriteLog("matches.jsonl", line);
            }
        }
        catch (Exception e) { Error("match.diagnostics", e); }
    }

    private static IEnumerable<KeyValuePair<string, string>> ReadMatchTraces(string? worldId)
    {
        if (string.IsNullOrEmpty(worldId)) yield break;
        foreach (var file in ReadLogs("matches.jsonl").Concat(LegacyLogs(Path.Combine("matches", TraceKey(worldId)), "*.jsonl")))
        {
            var content = new StringBuilder();
            foreach (string line in file.Value.Split('\n', StringSplitOptions.RemoveEmptyEntries))
                try
                {
                    using var record = JsonDocument.Parse(line);
                    if (record.RootElement.GetProperty("world").GetString() == worldId) content.AppendLine(line);
                }
                catch (Exception error) { Error("match.diagnostics.read", error); }
            if (content.Length > 0) yield return new(file.Key, Redact(content.ToString()));
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
