using System.Diagnostics;
using System.Text.Json;

namespace NationalSpire;

public static partial class Diagnostics
{
    private enum LogWork { Record, Match, Serialize, Redact, WaitForWrite, Write, Export, Capture }
    private sealed class LogCost
    {
        public long Count, Ticks, Bytes, MaxTicks, MaxBytes;
        public string SlowestCategory = "";
        public string LargestAllocationCategory = "";
        public DateTimeOffset SlowestUtc, LargestAllocationUtc;
    }
    private static readonly object CostGate = new();
    private static readonly LogCost[] Costs = Enumerable.Range(0, 8).Select(_ => new LogCost()).ToArray();
    private static readonly DateTimeOffset CostStarted = DateTimeOffset.UtcNow;
    private static int _peakEvents, _peakEventChars;
    private static string _performanceWriteError = "";

    // 只保存固定数量的累计值和最慢现场；不建立待写队列，也不递归记录监测事件。
    private readonly struct LogMeasure(LogWork work, string category = "") : IDisposable
    {
        private readonly long _start = Stopwatch.GetTimestamp();
        private readonly long _bytes = GC.GetAllocatedBytesForCurrentThread();
        public void Dispose()
        {
            long ticks = Stopwatch.GetTimestamp() - _start;
            long bytes = GC.GetAllocatedBytesForCurrentThread() - _bytes;
            lock (CostGate)
            {
                var cost = Costs[(int)work];
                cost.Count++; cost.Ticks += ticks; cost.Bytes += bytes;
                if (bytes > cost.MaxBytes)
                {
                    cost.MaxBytes = bytes; cost.LargestAllocationCategory = category;
                    cost.LargestAllocationUtc = DateTimeOffset.UtcNow;
                }
                if (ticks > cost.MaxTicks)
                {
                    cost.MaxTicks = ticks; cost.SlowestCategory = category;
                    cost.SlowestUtc = DateTimeOffset.UtcNow;
                }
            }
        }
    }

    public static object LoggingPerformance()
    {
        object retained;
        lock (Gate) retained = new { events = Events.Count, eventCharacters = _eventChars,
            peakEvents = _peakEvents, peakEventCharacters = _peakEventChars, errorKinds = ErrorCounts.Count,
            distinctCredentials = Secrets.Count, writeError = _writeError, performanceWriteError = _performanceWriteError };
        lock (CostGate)
            return new { startedUtc = CostStarted, capturedUtc = DateTimeOffset.UtcNow, processId = Environment.ProcessId, retained,
                note = "耗时含线程等待；分配量为调用线程累计分配，并非存活内存。父阶段包含子阶段，禁止相加。导出统计在本次导出结束后更新。",
                stages = Costs.Select((cost, index) => new { stage = ((LogWork)index).ToString(), count = cost.Count,
                    totalMs = cost.Ticks * 1000d / Stopwatch.Frequency, maxMs = cost.MaxTicks * 1000d / Stopwatch.Frequency,
                    allocatedBytes = cost.Bytes, maxAllocatedBytes = cost.MaxBytes,
                    slowestCategory = cost.SlowestCategory, slowestUtc = cost.SlowestUtc,
                    largestAllocationCategory = cost.LargestAllocationCategory, largestAllocationUtc = cost.LargestAllocationUtc }).ToArray() };
    }

    private static void SaveLoggingPerformance()
    {
        try
        {
            string? directory;
            lock (Gate) directory = _directory;
            if (directory == null || !Directory.Exists(directory)) return;
            string json = Redact(JsonSerializer.Serialize(LoggingPerformance(), Json));
            File.WriteAllText(Path.Combine(directory, "logging-performance.json"), json);
        }
        catch (Exception e) { lock (Gate) _performanceWriteError = e.GetType().Name + ": " + e.Message; }
    }
}
