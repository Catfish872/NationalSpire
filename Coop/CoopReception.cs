using System.Diagnostics;

namespace NationalSpire.Coop;

public sealed partial class CoopCoordinator
{
    private sealed record ReceivedWork(Func<bool> Step, Action? Finished = null, Action? Cancelled = null, bool Snapshot = false);
    private readonly Queue<ReceivedWork> _received = [];
    private readonly CancellationTokenSource _receiveLifetime = new();
    private int _viewReaders;
    private (CoopWorld Source, CareerData Data)? _preparedView;
    public bool Receiving => !Host && _received.Count != 0;

    internal void RegisterView() => _viewReaders++;
    internal void UnregisterView() { _viewReaders--; if (_viewReaders == 0) _preparedView = null; }
    internal CareerData InterfaceView()
    {
        if (_preparedView is { } ready && ReferenceEquals(ready.Source, World))
        { _preparedView = null; return ready.Data; }
        return CoopRules.InterfaceView(World!, Self);
    }

    // 等待调用前已经接收的事件；后续消息不会无限延长等待，完成回调在事件出队后执行。
    public Task WaitForReceived()
    {
        if (_closed) return Task.FromCanceled(new CancellationToken(true));
        if (!Receiving) return Task.CompletedTask;
        var done = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        _received.Enqueue(new(() => true, () => done.TrySetResult(), () => done.TrySetCanceled()));
        return done.Task;
    }
    public void ApplyReceived(Action action)
    {
        void Apply() { _preparedView = null; action(); }
        if (_closed) return;
        if (!Receiving) Apply();
        else _received.Enqueue(new(() => true, Apply));
    }

    // 命令编号在点击时预留，实际发送版本在前面的同步完成后读取；已发送命令仍由 Retry 管理。
    public void SubmitReady(CoopCommand intent, Action<CoopCommand> sending, Action<Exception> failed)
    {
        void Submit()
        {
            try
            {
                if (_closed || World == null || World.Id != intent.World || World.Epoch != intent.Epoch)
                    throw new InvalidOperationException("房间会话已改变，请重新操作。");
                var command = intent with { Revision = World.Revision };
                sending(command); Retry(command);
            }
            catch (Exception error) { failed(error); }
        }
        if (!Receiving) Submit();
        else _received.Enqueue(new(() => true, Submit, () => failed(new OperationCanceledException("房间已断开，请返回队伍重新加入。"))));
    }

    private void PumpReceived()
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.CoopReceive);
        long started = Stopwatch.GetTimestamp();
        while (!_closed && _received.TryPeek(out var work))
        {
            bool complete;
            try { complete = work.Step(); }
            catch (Exception error) { ReceiveError(error); complete = true; }
            if (!complete) break;
            _received.Dequeue();
            try { work.Finished?.Invoke(); }
            catch (Exception error) { ReceiveError(error); }
            if (work.Snapshot || Stopwatch.GetElapsedTime(started).TotalMilliseconds >= 4) break;
        }
    }
    private void ReceiveError(Exception error)
    { Status = "同步操作失败：" + error.Message; Diagnostics.Error("coop.receive", error); Changed?.Invoke(); }

    private void QueueSnapshot(ulong sender, CoopAssembler.Complete complete)
    {
        Task<CoopSnapshot>? decoding = null;
        Task<CareerData?>? saving = null;
        CoopSnapshot? snapshot = null;
        bool prepare = false, published = false;
        bool Step()
        {
            if (decoding == null)
            {
                decoding = Task.Run(() =>
                { using var timing = UiPerformance.Measure(UiPerformance.Work.CoopDecode); return CoopJson.Read<CoopSnapshot>(complete.Decode()); }, _receiveLifetime.Token);
                return false;
            }
            if (!decoding.IsCompleted) return false;
            if (snapshot == null)
            {
                snapshot = decoding.GetAwaiter().GetResult();
                if (snapshot.World.Owner != sender || snapshot.World.Schema != 1 || !snapshot.World.Members.Any(m => m.SteamId == Self))
                    throw new InvalidDataException("存档成员不匹配。");
                if (World != null && (World.Id != snapshot.World.Id || World.Epoch == snapshot.World.Epoch && World.Revision > snapshot.World.Revision)) return true;
                prepare = _viewReaders > 0;
                saving = SaveReceived(snapshot, prepare, Self);
                return false;
            }
            if (!saving!.IsCompleted) return false;
            using var publishing = UiPerformance.Measure(UiPerformance.Work.CoopPublish);
            var view = saving.GetAwaiter().GetResult();
            World = snapshot.World; NativeSave = snapshot.Run;
            CoopJson.Detached(World.World);
            _preparedView = prepare && view != null ? (World, view) : null;
            _seen[sender] = DateTime.UtcNow; Status = "已同步";
            foreach (var group in World.World.Chats.Groups.Where(g => !GroupChats.Busy(g)))
            { AiService.GroupLive.Remove(World.Id + "/group/" + group.Id); AiService.GroupReasoningLive.Remove(World.Id + "/group/" + group.Id); }
            published = true; return true;
        }
        _received.Enqueue(new(Step, () => { if (published) { CompleteReplies(); Changed?.Invoke(); } }, Snapshot: true));
    }
    private async Task<CareerData?> SaveReceived(CoopSnapshot snapshot, bool prepare, ulong self)
    {
        // 即使保存任务已经完成，后续个人视图转换也必须在后台继续。
        await _storage.SaveAsync(snapshot.World, snapshot.Run, _receiveLifetime.Token).ConfigureAwait(ConfigureAwaitOptions.ForceYielding);
        if (!prepare || _receiveLifetime.IsCancellationRequested) return null;
        // 个人视图准备失败不能撤销已经持久保存的同步；界面仍可使用原转换入口。
        try { using var timing = UiPerformance.Measure(UiPerformance.Work.CoopPrepareView); return CoopRules.InterfaceView(snapshot.World, self); }
        catch (Exception error) { Diagnostics.Error("coop.view.prepare", error); return null; }
    }
    private void CloseReceived()
    {
        _receiveLifetime.Cancel(); _preparedView = null;
        while (_received.TryDequeue(out var work)) work.Cancelled?.Invoke();
    }
}
