using System.Text.Json;

namespace NationalSpire.Coop;

public sealed record CoopDiagnosticRequest(string Id, string Epoch, int[]? Missing = null);
public sealed record CoopDiagnosticPart(string Id, string Epoch, CoopPart Part);

public sealed partial class CoopCoordinator
{
    public Func<Dictionary<string, string>>? CaptureDiagnostics { get; set; }
    private string _diagnosticId = "", _diagnosticEpoch = "";
    private readonly Dictionary<ulong, CoopAssembler> _diagnosticAssemblers = [];
    private readonly Dictionary<ulong, Dictionary<string, string>> _diagnosticReports = [];
    private readonly Dictionary<ulong, Task<Dictionary<string, string>>> _diagnosticDecoding = [];
    private Task<Dictionary<string, string>>? _diagnosticCollection;
    private CoopDiagnosticRequest? _diagnosticSending;
    private Task<CoopPart[]>? _diagnosticPreparing;
    private Queue<int> _diagnosticIndices = [];
    private bool _diagnosticSendStarted;

    public Task<Dictionary<string, string>> CollectDiagnostics(TimeSpan? timeout = null)
        => _diagnosticCollection is { IsCompleted: false } running ? running : _diagnosticCollection = CollectDiagnosticReports(timeout);

    private async Task<Dictionary<string, string>> CollectDiagnosticReports(TimeSpan? timeout)
    {
        if (!Host || World == null) return [];
        var members = World.Members.Where(m => m.SteamId != Self).ToArray();
        var online = Online;
        _diagnosticId = Guid.NewGuid().ToString("N"); _diagnosticEpoch = World.Epoch;
        _diagnosticAssemblers.Clear(); _diagnosticReports.Clear(); _diagnosticDecoding.Clear();
        var started = DateTime.UtcNow; var requested = DateTime.MinValue;
        try
        {
            foreach (var member in members.Where(m => online.Contains(m.SteamId))) _diagnosticAssemblers[member.SteamId] = new(diagnostic: true);
            while (!_closed && World?.Epoch == _diagnosticEpoch
                && (timeout == null || DateTime.UtcNow - started < timeout)
                && _diagnosticAssemblers.Keys.Any(id => !_diagnosticReports.ContainsKey(id) && Online.Contains(id)))
            {
                if (DateTime.UtcNow - requested >= TimeSpan.FromSeconds(3))
                {
                    requested = DateTime.UtcNow;
                    foreach (var pair in _diagnosticAssemblers.Where(p => !_diagnosticReports.ContainsKey(p.Key) && !_diagnosticDecoding.ContainsKey(p.Key) && Online.Contains(p.Key)))
                        SendDiagnostic(pair.Key, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch, pair.Value.Missing()));
                }
                await Task.Delay(100);
            }
            var files = new Dictionary<string, string>(); var statuses = new List<object>();
            foreach (var member in members)
            {
                bool received = _diagnosticReports.TryGetValue(member.SteamId, out var report);
                statuses.Add(new { member.SteamId, member.Name, status = received ? "已收集" : online.Contains(member.SteamId) ? "超时或连接中断，已保留本机报告" : "离线，无法收集" });
                if (received) foreach (var entry in report!) files[$"peers/{member.SteamId}/{entry.Key}"] = entry.Value;
                SendDiagnostic(member.SteamId, "diagnostics-done", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch));
            }
            files["peers/collection.json"] = JsonSerializer.Serialize(statuses, CoopJson.Options);
            return files;
        }
        finally
        {
            _diagnosticId = "";
            try { await Task.WhenAll(_diagnosticDecoding.Values.ToArray()); } catch (Exception error) { Diagnostics.Error("coop.diagnostics.finish", error); }
            _diagnosticAssemblers.Clear(); _diagnosticReports.Clear(); _diagnosticDecoding.Clear();
        }
    }

    private void SendDiagnostic<T>(ulong peer, string kind, T value)
    {
        try { Send(peer, kind, value); }
        catch (Exception error) { Diagnostics.Error("coop.diagnostics.send", error); }
    }

    // 捕获回调使用游戏线程，压缩和解压在后台进行；每次更新发送一个现有协议分片。
    private void PumpDiagnostics()
    {
        if (_closed || _diagnosticSending != null && (World?.Epoch != _diagnosticSending.Epoch || !Online.Contains(World.Owner)))
        { _diagnosticSending = null; _diagnosticPreparing = null; _diagnosticIndices.Clear(); }
        foreach (var pair in _diagnosticDecoding.Where(p => p.Value.IsCompleted).ToArray())
        {
            _diagnosticDecoding.Remove(pair.Key);
            if (pair.Value.IsCompletedSuccessfully) _diagnosticReports[pair.Key] = pair.Value.Result;
            else { Diagnostics.Error("coop.diagnostics.decode", pair.Value.Exception!); _diagnosticAssemblers[pair.Key] = new(diagnostic: true); }
        }
        if (_diagnosticSending is not { } sending || _diagnosticPreparing is not { IsCompleted: true } prepared) return;
        if (!prepared.IsCompletedSuccessfully)
        {
            Diagnostics.Error("coop.diagnostics.prepare", prepared.Exception!); _diagnosticSending = null; _diagnosticPreparing = null; return;
        }
        if (!_diagnosticSendStarted)
        { _diagnosticIndices = new(Enumerable.Range(0, prepared.Result.Length)); _diagnosticSendStarted = true; }
        if (_diagnosticIndices.TryDequeue(out int index))
            SendDiagnostic(World!.Owner, "diagnostics-part", new CoopDiagnosticPart(sending.Id, sending.Epoch, prepared.Result[index]));
    }

    private void ReceiveDiagnostic(ulong sender, CoopWire wire)
    {
        try
        {
            if (World == null) return;
            if (wire.Kind == "diagnostics-done" && !Host && sender == World.Owner)
            {
                var done = Read<CoopDiagnosticRequest>(wire);
                if (_diagnosticSending?.Id == done.Id && _diagnosticSending.Epoch == done.Epoch)
                { _diagnosticSending = null; _diagnosticPreparing = null; _diagnosticIndices.Clear(); }
            }
            else if (wire.Kind == "diagnostics-request" && !Host && sender == World.Owner)
            {
                var request = Read<CoopDiagnosticRequest>(wire);
                if (request.Epoch != World.Epoch || !Guid.TryParseExact(request.Id, "N", out _)) return;
                if (_diagnosticSending?.Id == request.Id)
                {
                    if (_diagnosticPreparing is { IsCompletedSuccessfully: true } ready && _diagnosticSendStarted)
                        _diagnosticIndices = new((request.Missing ?? Enumerable.Range(0, ready.Result.Length).ToArray()).Where(i => i >= 0 && i < ready.Result.Length));
                    return;
                }
                if (_diagnosticPreparing is { IsCompleted: false }) return;
                Dictionary<string, string> files;
                try { files = CaptureDiagnostics?.Invoke() ?? new() { ["notes.txt"] = "此客户端无法提供运行日志。" }; }
                catch (Exception error) { files = new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }; }
                _diagnosticSending = request; _diagnosticSendStarted = false;
                _diagnosticPreparing = Task.Run(() => CoopAssembler.Split(CoopJson.Bytes(files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value))), diagnostic: true).ToArray());
                _diagnosticIndices.Clear();
                _ = _diagnosticPreparing.ContinueWith(task => { _ = task.Exception; }, TaskContinuationOptions.OnlyOnFaulted);
            }
            else if (wire.Kind == "diagnostics-part" && Host && _diagnosticId.Length > 0 && _diagnosticAssemblers.TryGetValue(sender, out var assembler))
            {
                var part = Read<CoopDiagnosticPart>(wire);
                if (part.Id != _diagnosticId || part.Epoch != _diagnosticEpoch || _diagnosticReports.ContainsKey(sender) || _diagnosticDecoding.ContainsKey(sender)) return;
                if (assembler.Collect(part.Part, DateTime.UtcNow) is not { } complete) return;
                _diagnosticDecoding[sender] = Task.Run(() => CoopJson.Read<Dictionary<string, string>>(complete.Decode(diagnostic: true))
                    .Where(p => AllowedReportName(p.Key)).ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value)));
            }
        }
        catch (Exception error)
        {
            Diagnostics.Error("coop.diagnostics.receive", error);
            if (Host && _diagnosticAssemblers.ContainsKey(sender)) _diagnosticAssemblers[sender] = new(diagnostic: true);
        }
    }
    private void CloseDiagnostics()
    {
        _diagnosticSending = null; _diagnosticPreparing = null; _diagnosticIndices.Clear(); _diagnosticCollection = null;
    }
    private static bool AllowedReportName(string name) => name.Length > 0 && !name.StartsWith('/') && !name.Contains("..") && !name.Contains(':') && !name.Contains('\\');
}
