using System.Diagnostics;

namespace NationalSpire;

// 固定项目、累计统计；页面计时和帧检测不执行磁盘写入。
public static class UiPerformance
{
    public enum Work { Render, Clear, Profiles, Community, Matches, Avatar, Honors, Store, Frame, AvatarControl, PostCard, GroupRender, MemberRows, MemberFilter, Count }
    private sealed class Cost { public long Calls, Ticks, Bytes, Maximum; public long Over50; }
    private static readonly Cost[] Costs = Enumerable.Range(0, (int)Work.Count).Select(_ => new Cost()).ToArray();
    private static readonly object Gate = new();
    private static readonly string[] Pages = ["首页", "日程", "赛事", "赛事与俱乐部", "结算", "社区", "选手档案", "模组设置", "生涯生活", "通讯", "其他"];
    private static readonly Cost[] PageFrames = Pages.Select(_ => new Cost()).ToArray();
    private sealed record SlowOperation(DateTime Utc, string Page, double Milliseconds, long AllocatedBytes);
    private static readonly SlowOperation?[] Recent = new SlowOperation?[32];
    private static int _next;
    public readonly struct Scope : IDisposable
    {
        private readonly Work _work;
        private readonly string? _page;
        private readonly long _time, _bytes;
        public Scope(Work work, string? page) { _work = work; _page = page; _time = Stopwatch.GetTimestamp(); _bytes = GC.GetAllocatedBytesForCurrentThread(); }
        public void Dispose()
        {
            long ticks = Stopwatch.GetTimestamp() - _time, bytes = GC.GetAllocatedBytesForCurrentThread() - _bytes;
            Record(_work, ticks, bytes);
            if (_page != null && ticks > Stopwatch.Frequency / 20)
                lock(Gate) { Recent[_next] = new(DateTime.UtcNow, _page, ticks * 1000.0 / Stopwatch.Frequency, bytes); _next = (_next + 1) % Recent.Length; }
        }
    }
    public static Scope Measure(Work work, string? page = null) => new(work, page);
    private static void Record(Work work, long ticks, long bytes)
    {
        lock (Gate)
        {
            var c = Costs[(int)work]; c.Calls++; c.Ticks += ticks; c.Bytes += bytes;
            c.Maximum = Math.Max(c.Maximum, ticks); if (ticks > Stopwatch.Frequency / 20) c.Over50++;
        }
    }
    public static void Frame(ref long previous, string page)
    {
        long now = Stopwatch.GetTimestamp();
        if (previous != 0)
        {
            long ticks = now - previous; Record(Work.Frame, ticks, 0);
            int index = Array.IndexOf(Pages, page); if (index < 0) index = Pages.Length - 1;
            lock(Gate) { var c = PageFrames[index]; c.Calls++; c.Ticks += ticks; c.Maximum = Math.Max(c.Maximum,ticks); if(ticks > Stopwatch.Frequency / 20) c.Over50++; }
        }
        previous = now;
    }
    public static object Snapshot()
    {
        lock (Gate) return new { CapturedUtc=DateTime.UtcNow, ProcessId=Environment.ProcessId,
            Note="各阶段存在包含关系，不可相加。帧间隔包含游戏和其他模组工作，只表示发生卡顿的页面，不代表该页面独自造成全部耗时。分配量不等于存活内存。",
            Stages = Costs.Select((c, i) => new { Stage = ((Work)i).ToString(), c.Calls,
            TotalMs = c.Ticks * 1000.0 / Stopwatch.Frequency, MaxMs = c.Maximum * 1000.0 / Stopwatch.Frequency,
            c.Bytes, FramesOrCallsOver50Ms = c.Over50 }).ToArray(),
            Pages = PageFrames.Select((c,i)=>new { Page=Pages[i], c.Calls, MaxFrameMs=c.Maximum*1000.0/Stopwatch.Frequency, FramesOver50Ms=c.Over50 }).ToArray(),
            RecentSlowOperations = Recent.Where(x=>x!=null).OrderBy(x=>x!.Utc).ToArray() };
    }
}
