using System.Runtime.InteropServices;
using Steamworks;

namespace NationalSpire.Coop;

/// <summary>生涯使用独立消息通道和 Invisible 大厅，不占用原版对局的普通大厅。</summary>
public sealed class CoopSteam : ICoopTransport
{
    private const int Channel = 19831;
    private CSteamID _lobby;
    private readonly HashSet<ulong> _peers = [];
    private readonly Queue<(ulong Peer, string Kind, int Batch, byte[] Bytes)> _outgoing = [];
    private readonly Queue<(ulong Peer, string Kind, int Batch, byte[] Bytes)> _control = [];
    private readonly Dictionary<(ulong Peer, string Kind), int> _currentBatch = [];
    private readonly HashSet<(ulong Peer, string Kind, int Batch)> _startedBatches = [];
    private int _nextBatch;
    private readonly CoopPacketAssembly _packets = new();
    private readonly Callback<SteamNetworkingMessagesSessionRequest_t> _requests;
    private CallResult<LobbyCreated_t>? _create;
    private CallResult<LobbyEnter_t>? _enter;
    private bool _closed;
    private TaskCompletionSource? _pending;
    public ulong Self { get; } = SteamUser.GetSteamID().m_SteamID;
    public ulong Owner { get; private set; }
    public IReadOnlySet<ulong> Peers => _peers;
    public string Code { get; private set; } = "";
    public string Token { get; private set; } = "";
    public event Action<ulong, CoopWire>? Received;
    public CoopSteam()
    {
        if (!SteamUser.BLoggedOn()) throw new InvalidOperationException("请先登录 Steam。");
        _requests = Callback<SteamNetworkingMessagesSessionRequest_t>.Create(r =>
        {
            if (!_closed && Member(r.m_identityRemote.GetSteamID64())) SteamNetworkingMessages.AcceptSessionWithUser(ref r.m_identityRemote);
        });
    }
    private bool Member(ulong id)
    {
        if (_lobby == CSteamID.Nil) return false;
        for (int i = 0; i < SteamMatchmaking.GetNumLobbyMembers(_lobby); i++)
            if (SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i).m_SteamID == id) return true;
        return false;
    }
    public async Task Host(int capacity)
    {
        var ready = _pending = new TaskCompletionSource();
        _create = CallResult<LobbyCreated_t>.Create((r, error) =>
        {
            if (_closed) return;
            if (error || r.m_eResult != EResult.k_EResultOK) { ready.TrySetException(new IOException("Steam 创建房间失败。")); return; }
            _lobby = new(r.m_ulSteamIDLobby); Owner = Self; Token = Guid.NewGuid().ToString("N"); Code = _lobby.m_SteamID + "-" + Token;
            SteamMatchmaking.SetLobbyData(_lobby, "nationalspire", CoopWorld.Protocol.ToString());
            SteamMatchmaking.SetLobbyData(_lobby, "career_owner", Self.ToString());
            ready.TrySetResult();
        });
        _create.Set(SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeInvisible, capacity));
        await ready.Task.WaitAsync(TimeSpan.FromSeconds(30));
    }
    public async Task Join(string code)
    {
        var parts = code.Trim().Split('-');
        if (parts.Length != 2 || !ulong.TryParse(parts[0], out ulong lobby) || !Guid.TryParseExact(parts[1], "N", out _)) throw new InvalidDataException("房间邀请代码无效。");
        Token = parts[1]; var ready = _pending = new TaskCompletionSource();
        _enter = CallResult<LobbyEnter_t>.Create((r, error) =>
        {
            if (_closed) return;
            if (error || r.m_EChatRoomEnterResponse != (uint)EChatRoomEnterResponse.k_EChatRoomEnterResponseSuccess) { ready.TrySetException(new IOException("无法进入 Steam 房间。")); return; }
            _lobby = new(r.m_ulSteamIDLobby);
            if (SteamMatchmaking.GetLobbyData(_lobby, "nationalspire") != CoopWorld.Protocol.ToString() || !ulong.TryParse(SteamMatchmaking.GetLobbyData(_lobby, "career_owner"), out ulong owner) || !Member(owner))
            { ready.TrySetException(new InvalidDataException("共同生涯房间协议不匹配或主机已离线。")); return; }
            Owner = owner; Code = code.Trim(); ready.TrySetResult();
        });
        _enter.Set(SteamMatchmaking.JoinLobby(new(lobby)));
        await ready.Task.WaitAsync(TimeSpan.FromSeconds(30));
    }
    public void CancelPending(ulong peer, string kind)
    {
        _currentBatch[(peer, kind)] = ++_nextBatch;
        if (_outgoing.Count == 0) return;
        int count = _outgoing.Count;
        for (int i = 0; i < count; i++)
        {
            var item = _outgoing.Dequeue();
            // 只取消尚未开始向 Steam 缓冲区发送的完整排队批次；已发出一半的批次必须保留剩余尾片，避免客机卡在残缺分片。
            if (item.Peer != peer || item.Kind != kind || _startedBatches.Contains((item.Peer, item.Kind, item.Batch)))
                _outgoing.Enqueue(item);
        }
    }
    public bool HasPending(ulong peer, string kind) => _outgoing.Any(item => item.Peer == peer && item.Kind == kind);
    public void Send(ulong peer, CoopWire wire)
    {
        if (_closed || peer == Self) return;
        if (_outgoing.Count + _control.Count > 8000) throw new IOException("房间发送队列超出限制。");
        var queue = wire.Kind is "command" or "reply" or "reading" or "ping" or "pong" or "error" ? _control : _outgoing;
        int batch = _currentBatch.GetValueOrDefault((peer, wire.Kind));
        foreach (byte[] bytes in CoopPacketAssembly.Pack(wire)) queue.Enqueue((peer, wire.Kind, batch, bytes));
    }
    public void Update()
    {
        if (_closed || _lobby == CSteamID.Nil) return;
        _peers.Clear();
        for (int i = 0; i < SteamMatchmaking.GetNumLobbyMembers(_lobby); i++) _peers.Add(SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i).m_SteamID);
        _packets.RetainPeers(_peers);
        // 原版负责 Steam 回调；仅轮询专用频道。
        var messages = new IntPtr[128]; int count = SteamNetworkingMessages.ReceiveMessagesOnChannel(Channel, messages, messages.Length);
        for (int i = 0; i < count; i++)
        {
            var packet = SteamNetworkingMessage_t.FromIntPtr(messages[i]);
            try
            {
                ulong sender = packet.m_identityPeer.GetSteamID64();
                if (packet.m_cbSize is < 1 or > 60000 || !_peers.Contains(sender)) continue;
                byte[] bytes = new byte[packet.m_cbSize]; Marshal.Copy(packet.m_pData, bytes, 0, bytes.Length);
                if (_packets.Read(sender, bytes) is { } wire) Received?.Invoke(sender, wire);
            }
            catch (Exception e) { Diagnostics.Error("coop.packet", e); }
            finally { SteamNetworkingMessage_t.Release(messages[i]); }
        }
        HashSet<ulong> blocked = [];
        for (int n = 0; n < 64; n++)
        {
            var queue = _control.Count > 0 ? _control : _outgoing;
            if (!queue.TryPeek(out var send)) break;
            if (!_peers.Contains(send.Peer)) { queue.Dequeue(); continue; }
            if (blocked.Contains(send.Peer))
            {
                if (!TrySendUnblocked(queue, blocked)) break;
                continue;
            }
            var result = SendPacket(send.Peer, send.Bytes);
            if (result == EResult.k_EResultLimitExceeded)
            {
                blocked.Add(send.Peer);
                if (!TrySendUnblocked(queue, blocked)) break;
                continue;
            }
            queue.Dequeue();
            if (ReferenceEquals(queue, _outgoing)) _startedBatches.Add((send.Peer, send.Kind, send.Batch));
            if (result != EResult.k_EResultOK) throw new IOException("Steam 生涯消息发送失败：" + result);
        }
        if (_outgoing.Count == 0) _startedBatches.Clear();
    }
    private static EResult SendPacket(ulong peer, byte[] bytes)
    {
        var identity = new SteamNetworkingIdentity(); identity.SetSteamID64(peer);
        var pin = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        try { return SteamNetworkingMessages.SendMessageToUser(ref identity, pin.AddrOfPinnedObject(), (uint)bytes.Length, Constants.k_nSteamNetworkingSend_Reliable, Channel); }
        finally { pin.Free(); }
    }
    private bool TrySendUnblocked(Queue<(ulong Peer, string Kind, int Batch, byte[] Bytes)> queue, HashSet<ulong> blocked)
    {
        int total = queue.Count;
        bool sent = false;
        EResult? failed = null;
        for (int i = 0; i < total; i++)
        {
            var item = queue.Dequeue();
            if (!_peers.Contains(item.Peer)) continue;
            if (sent || failed != null || blocked.Contains(item.Peer)) { queue.Enqueue(item); continue; }
            var result = SendPacket(item.Peer, item.Bytes);
            if (result == EResult.k_EResultLimitExceeded) { blocked.Add(item.Peer); queue.Enqueue(item); continue; }
            if (ReferenceEquals(queue, _outgoing)) _startedBatches.Add((item.Peer, item.Kind, item.Batch));
            if (result != EResult.k_EResultOK) { failed = result; continue; }
            sent = true;
        }
        if (failed is { } err) throw new IOException("Steam 生涯消息发送失败：" + err);
        return sent;
    }
    public void Dispose()
    {
        if (_closed) return; _closed = true;
        _pending?.TrySetCanceled(); _pending = null;
        foreach (ulong peer in _peers.Where(p => p != Self)) { var id = new SteamNetworkingIdentity(); id.SetSteamID64(peer); SteamNetworkingMessages.CloseChannelWithUser(ref id, Channel); }
        if (_lobby != CSteamID.Nil) SteamMatchmaking.LeaveLobby(_lobby);
        _requests.Dispose(); _create?.Dispose(); _enter?.Dispose(); _peers.Clear(); _outgoing.Clear(); _control.Clear(); _currentBatch.Clear(); _startedBatches.Clear(); _packets.Clear();
    }
}
