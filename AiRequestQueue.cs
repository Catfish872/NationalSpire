namespace NationalSpire;

/// <summary>独立任务共享并发上限；涉及相同内容的更新依次提交。</summary>
internal sealed class AiRequestQueue
{
    private readonly object _gate = new();
    private readonly List<Pending> _waiting = [];
    private readonly HashSet<(CareerData Data, string Key)> _occupied = [];
    private int _active;
    private int _limit = 3;
    private sealed record Pending(HashSet<(CareerData Data, string Key)> Keys, TaskCompletionSource<IDisposable> Completion, Action<string>? Waiting);
    internal void Configure(int limit)
    {
        lock (_gate) { _limit = Math.Clamp(limit, 1, 16); Dispatch(); }
    }
    internal Task<IDisposable> EnterAsync(CareerData data, IEnumerable<string> keys, Action<string>? waiting = null)
    {
        lock (_gate)
        {
            var request = new Pending(keys.Select(key => (data, key)).ToHashSet(), new(TaskCreationOptions.RunContinuationsAsynchronously), waiting);
            _waiting.Add(request); Dispatch(); return request.Completion.Task;
        }
    }
    private void Dispatch()
    {
        var earlier = new HashSet<(CareerData Data, string Key)>();
        foreach (var request in _waiting.ToArray())
        {
            if (_active >= _limit) { request.Waiting?.Invoke("已达到最大并发数，正在等待空位……"); continue; }
            if (request.Keys.Overlaps(_occupied) || request.Keys.Overlaps(earlier))
            { request.Waiting?.Invoke("这份内容正在更新，完成后继续……"); earlier.UnionWith(request.Keys); continue; }
            _waiting.Remove(request); _active++; _occupied.UnionWith(request.Keys);
            request.Waiting?.Invoke("");
            request.Completion.SetResult(new Lease(this, request.Keys));
        }
    }
    private sealed class Lease(AiRequestQueue owner, HashSet<(CareerData Data, string Key)> keys) : IDisposable
    {
        private int _released;
        public void Dispose()
        {
            if (Interlocked.Exchange(ref _released, 1) != 0) return;
            lock (owner._gate) { owner._active--; owner._occupied.ExceptWith(keys); owner.Dispatch(); }
        }
    }
}
