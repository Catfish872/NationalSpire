using System.Text.Json;

namespace NationalSpire.Coop;

public sealed record CoopDiagnosticRequest(string Id, string Epoch);
public sealed record CoopDiagnosticPart(string Id, string Epoch, CoopPart Part);

public sealed partial class CoopCoordinator
{
    public Func<Dictionary<string, string>>? CaptureDiagnostics { get; set; }
    private string _diagnosticId = "", _diagnosticEpoch = "";
    private DateTime _lastDiagnosticRequest;
    private readonly Dictionary<ulong, CoopAssembler> _diagnosticAssemblers = [];
    private readonly Dictionary<ulong, Dictionary<string, string>> _diagnosticReports = [];

    public async Task<Dictionary<string, string>> CollectDiagnostics(TimeSpan? timeout = null)
    {
        if (!Host || World == null) return [];
        if (_diagnosticId.Length > 0) throw new InvalidOperationException("正在收集队友报告，请稍候。");
        var members = World.Members.Where(m => m.SteamId != Self).ToArray();
        var online = Online;
        _diagnosticId = Guid.NewGuid().ToString("N"); _diagnosticEpoch = World.Epoch;
        _diagnosticAssemblers.Clear(); _diagnosticReports.Clear();
        try
        {
            foreach (var member in members.Where(m => online.Contains(m.SteamId)))
            {
                _diagnosticAssemblers[member.SteamId] = new();
                Send(member.SteamId, "diagnostics-request", new CoopDiagnosticRequest(_diagnosticId, _diagnosticEpoch));
            }
            var until = DateTime.UtcNow + (timeout ?? TimeSpan.FromSeconds(20));
            while (!_closed && World?.Epoch == _diagnosticEpoch && DateTime.UtcNow < until
                && _diagnosticAssemblers.Keys.Any(id => !_diagnosticReports.ContainsKey(id))) await Task.Delay(100);
            var files = new Dictionary<string, string>();
            var statuses = new List<object>();
            foreach (var member in members)
            {
                bool received = _diagnosticReports.TryGetValue(member.SteamId, out var report);
                statuses.Add(new { member.SteamId, member.Name, status = received ? "已收集" : online.Contains(member.SteamId) ? "超时或连接中断" : "离线，无法收集" });
                if (received) foreach (var entry in report!) files[$"peers/{member.SteamId}/{entry.Key}"] = entry.Value;
            }
            files["peers/collection.json"] = JsonSerializer.Serialize(statuses, CoopJson.Options);
            return files;
        }
        finally { _diagnosticId = ""; _diagnosticAssemblers.Clear(); _diagnosticReports.Clear(); }
    }

    private void ReceiveDiagnostic(ulong sender, CoopWire wire)
    {
        if (World == null) return;
        if (wire.Kind == "diagnostics-request" && !Host && sender == World.Owner)
        {
            var request = Read<CoopDiagnosticRequest>(wire);
            if (request.Epoch != World.Epoch || !Guid.TryParseExact(request.Id, "N", out _) || DateTime.UtcNow - _lastDiagnosticRequest < TimeSpan.FromSeconds(10)) return;
            _lastDiagnosticRequest = DateTime.UtcNow;
            Dictionary<string, string> files;
            try { files = CaptureDiagnostics?.Invoke() ?? new() { ["notes.txt"] = "此客户端无法提供运行日志。" }; }
            catch (Exception error) { files = new() { ["notes.txt"] = "读取日志失败：" + Diagnostics.Redact(error.ToString()) }; }
            // 发出前脱敏，房主不接触客机的服务密钥或原版存档。
            var safe = files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value));
            foreach (var part in CoopAssembler.Split(CoopJson.Bytes(safe)))
                Send(sender, "diagnostics-part", new CoopDiagnosticPart(request.Id, request.Epoch, part));
        }
        else if (wire.Kind == "diagnostics-part" && Host && _diagnosticId.Length > 0 && _diagnosticAssemblers.TryGetValue(sender, out var assembler))
        {
            var part = Read<CoopDiagnosticPart>(wire);
            if (part.Id != _diagnosticId || part.Epoch != _diagnosticEpoch || _diagnosticReports.ContainsKey(sender)) return;
            if (part.Part.Total > 4 * 1024 * 1024) throw new InvalidDataException("队友报告超出大小限制。");
            if (assembler.Add(part.Part) is not { } bytes) return;
            if (bytes.Length > 8 * 1024 * 1024) throw new InvalidDataException("队友报告解压后超出大小限制。");
            var files = CoopJson.Read<Dictionary<string, string>>(bytes);
            if (files.Count > 16 || files.Keys.Any(key => !AllowedReportName(key))) throw new InvalidDataException("队友报告条目无效。");
            _diagnosticReports[sender] = files.ToDictionary(p => p.Key, p => Diagnostics.Redact(p.Value));
        }
    }
    private static bool AllowedReportName(string name) => name is "runtime.json" or "summary.json" or "error-counts.json" or "session-events.jsonl"
        or "mod-log.txt" or "game-log-1.txt" or "game-log-2.txt" or "game-log-3.txt" or "notes.txt" or "latest-match.jsonl";
}
