using System.IO.Compression;

namespace NationalSpire.Coop;

public sealed record CoopWire(string Kind, string Payload = "");

/// <summary>传输层分块只负责还原完整消息，收到全部分块并校验后才交给原有操作处理。</summary>
public sealed class CoopPacketAssembly
{
    private const int ChunkSize = 24000;
    public sealed record Part(string Id, int Index, int Total, string Hash, byte[] Bytes);
    private sealed class Pending(Part first)
    {
        public Part Header { get; } = first;
        public Dictionary<int, byte[]> Parts { get; } = [];
    }
    private readonly Dictionary<(ulong Peer, string Id), Pending> _pending = [];
    public static IEnumerable<byte[]> Pack(CoopWire wire)
    {
        byte[] bytes = CoopJson.Bytes(wire);
        if (bytes.Length <= 60000) { yield return bytes; yield break; }
        string id = Guid.NewGuid().ToString("N"), hash = CoopJson.Hash(bytes);
        for (int offset = 0, index = 0; offset < bytes.Length; index++)
        {
            int size = Math.Min(ChunkSize, bytes.Length - offset);
            var part = new Part(id, index, bytes.Length, hash, bytes.AsSpan(offset, size).ToArray());
            yield return CoopJson.Bytes(new CoopWire("packet-part", System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options)));
            offset += size;
        }
    }
    public CoopWire? Read(ulong peer, byte[] bytes)
    {
        var wire = CoopJson.Read<CoopWire>(bytes);
        if (wire.Kind != "packet-part") return wire;
        var p = System.Text.Json.JsonSerializer.Deserialize<Part>(wire.Payload, CoopJson.Options)
            ?? throw new InvalidDataException("消息分块为空。");
        long offset = (long)p.Index * ChunkSize;
        if (!Guid.TryParseExact(p.Id, "N", out _) || p.Total < 1 || p.Index < 0 || offset >= p.Total
            || p.Bytes == null || p.Bytes.Length != Math.Min(ChunkSize, p.Total - offset))
            throw new InvalidDataException("消息分块无效。");
        var key = (peer, p.Id);
        if (!_pending.TryGetValue(key, out var pending)) _pending[key] = pending = new(p);
        if (pending.Header.Total != p.Total || pending.Header.Hash != p.Hash)
            throw new InvalidDataException("消息分块信息不一致。");
        if (pending.Parts.TryGetValue(p.Index, out var previous) && !previous.AsSpan().SequenceEqual(p.Bytes))
            throw new InvalidDataException("消息分块内容冲突。");
        pending.Parts[p.Index] = p.Bytes;
        int count = (p.Total - 1) / ChunkSize + 1;
        if (pending.Parts.Count != count) return null;
        _pending.Remove(key);
        byte[] result = new byte[p.Total];
        for (int i = 0; i < count; i++) pending.Parts[i].CopyTo(result, i * ChunkSize);
        if (CoopJson.Hash(result) != p.Hash) throw new InvalidDataException("消息分块校验失败。");
        return CoopJson.Read<CoopWire>(result);
    }
    public void RetainPeers(IReadOnlySet<ulong> peers)
    {
        foreach (var key in _pending.Keys.Where(k => !peers.Contains(k.Peer)).ToArray()) _pending.Remove(key);
    }
    public void Clear() => _pending.Clear();
}

public interface ICoopTransport : IDisposable
{
    ulong Self { get; }
    ulong Owner { get; }
    IReadOnlySet<ulong> Peers { get; }
    event Action<ulong, CoopWire>? Received;
    void Send(ulong peer, CoopWire wire);
    void Update();
}
public sealed record CoopPart(string Id, int Index, int Count, int Total, string Hash, byte[] Bytes);
public sealed class CoopAssembler
{
    private CoopPart? _header;
    private readonly Dictionary<int, byte[]> _parts = [];
    private DateTime _started;
    public static IEnumerable<CoopPart> Split(byte[] raw)
    {
        using var output = new MemoryStream();
        using (var zip = new BrotliStream(output, CompressionLevel.Fastest, true)) zip.Write(raw);
        byte[] bytes = output.ToArray(); const int size = 24000;
        if (bytes.Length > 32 * 1024 * 1024) throw new InvalidDataException("共同生涯超出同步容量。");
        string id = Guid.NewGuid().ToString("N"), hash = CoopJson.Hash(bytes);
        int count = (bytes.Length + size - 1) / size;
        for (int i = 0; i < count; i++) yield return new(id, i, count, bytes.Length, hash, bytes[(i * size)..Math.Min(bytes.Length, (i + 1) * size)]);
    }
    public byte[]? Add(CoopPart p)
    {
        if (p.Total is < 1 or > 32 * 1024 * 1024 || p.Count != (p.Total + 23999) / 24000 || p.Index < 0 || p.Index >= p.Count || p.Bytes.Length != Math.Min(24000, p.Total - p.Index * 24000))
            throw new InvalidDataException("同步分片无效。");
        if (_header?.Id != p.Id || DateTime.UtcNow - _started > TimeSpan.FromSeconds(60))
        { _header = p; _parts.Clear(); _started = DateTime.UtcNow; }
        if (_header.Total != p.Total || _header.Hash != p.Hash || _header.Count != p.Count) throw new InvalidDataException("同步分片元数据不一致。");
        if (_parts.TryGetValue(p.Index, out var old) && !old.AsSpan().SequenceEqual(p.Bytes)) throw new InvalidDataException("重复分片冲突。");
        _parts[p.Index] = p.Bytes;
        if (_parts.Count != p.Count) return null;
        byte[] bytes = Enumerable.Range(0, p.Count).SelectMany(i => _parts[i]).ToArray(); _parts.Clear(); _header = null;
        if (CoopJson.Hash(bytes) != p.Hash) throw new InvalidDataException("同步校验失败。");
        using var zip = new BrotliStream(new MemoryStream(bytes), CompressionMode.Decompress);
        using var result = new MemoryStream(); byte[] buffer = new byte[65536]; int read;
        while ((read = zip.Read(buffer)) > 0) { if (result.Length + read > 96 * 1024 * 1024) throw new InvalidDataException("同步数据解压超限。"); result.Write(buffer, 0, read); }
        return result.ToArray();
    }
}
