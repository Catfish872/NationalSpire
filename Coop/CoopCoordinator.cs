using System.Text.Json;

namespace NationalSpire.Coop;

public sealed record CoopSnapshot(CoopWorld World, byte[]? Run);
public sealed record CoopHello(int Protocol, string Compatibility, string Token, string Name);
public sealed record CoopReply(string Id, CoopOutcome Outcome, long Revision = -1);
public sealed record CoopHeartbeat(string Epoch, ulong[] Online);

/// <summary>经过身份校验的命令统一提交，存档成功后才向客机确认。</summary>
public sealed partial class CoopCoordinator : IDisposable
{
    private readonly ICoopTransport _transport;
    private readonly CoopStorage _storage;
    private readonly string _compatibility, _token, _name;
    private readonly IReadOnlySet<string> _characters;
    private readonly Dictionary<ulong, DateTime> _seen = [];
    private readonly Dictionary<ulong, (DateTime At, int Count)> _rates = [];
    private readonly CoopAssembler _assembler = new();
    private readonly CoopAssembler _liveAssembler = new();
    private DateTime _lastHello, _lastHeartbeat;
    private bool _closed;
    private string _lastJoinError = "";
    private readonly Dictionary<string, (CoopCommand Command, DateTime Sent, CoopReply? Reply)> _pendingCommands = [];
    public CoopWorld? World { get; private set; }
    public byte[]? NativeSave { get; private set; }
    public ulong Self => _transport.Self;
    public bool Host => Self == _transport.Owner;
    public HashSet<ulong> Online => _seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key).Append(Self).ToHashSet();
    public bool Full => World is { } w && (w.Run != null ? w.Run.Characters.Keys.All(Online.Contains) : Online.Count is >= 2 and <= 4);
    public string Status { get; private set; } = "正在同步共同生涯";
    public event Action? Changed;
    public event Action<string>? TriggerAi;
    public event Action<CoopWire>? RunMessage;
    public event Action<CoopReply>? Replied;
    public CoopCoordinator(ICoopTransport transport, CoopStorage storage, string compatibility, string token, string name, IReadOnlySet<string> characters, CoopStorage.Checkpoint? hostWorld = null)
    {
        _transport = transport; _storage = storage; _compatibility = compatibility; _token = token; _name = name; _characters = characters;
        if (hostWorld != null)
        {
            if (!Host || hostWorld.World.Owner != Self) throw new InvalidOperationException("只有原主机能恢复这个世界。");
            if (hostWorld.World.Members.Any(m => m.Life.Version < CareerLife.Version))
                storage.BackupBeforeDevelopment(hostWorld.World, hostWorld.Run);
            World = hostWorld.World; NativeSave = hostWorld.Run; World.Epoch = Guid.NewGuid().ToString("N"); World.Proposal = null;
            foreach (var member in World.Members) PrivateMessageCommands.Recover(member.Life);
            GroupChats.Recover(World.World);
            OwnedClubs.RepairContractRoster(World.World, World.Members.Select(m => m.Life.Mailbox));
            OwnedClubs.EnsureMarket(World.World);
            CircuitPeople.Replenish(World.World);
            EsportsWorld.ClearInvalidRegistrations(World.World);
            EsportsWorld.RefreshLeagueMatches(World.World);
            PlayerIdentity.Ensure(World.World);
            PersonalityLibrary.EnsureAll(World.World);
            NpcRecords.Ensure(World.World);
            CoopRules.AdvanceMembers(World);
            WeeklyJournal.Recover(World.World);
            WeeklyJournal.ActivateLatest(World.World);
            CommunityThreads.RecoverInterrupted(World.World); Commit(World, NativeSave, false);
        }
        _transport.Received += Receive;
    }
    public void Tick()
    {
        if (_closed) return;
        _transport.Update();
        if (!Host)
            foreach (var pending in _pendingCommands.Values.ToArray())
                if (pending.Reply == null && DateTime.UtcNow - pending.Sent >= TimeSpan.FromSeconds(3)) Retry(pending.Command);
        if (!Host && World == null && DateTime.UtcNow - _lastHello > TimeSpan.FromSeconds(3))
        { _lastHello = DateTime.UtcNow; Send(_transport.Owner, "hello", new CoopHello(CoopWorld.Protocol, _compatibility, _token, _name)); }
        if (DateTime.UtcNow - _lastHeartbeat > TimeSpan.FromSeconds(3))
        {
            _lastHeartbeat = DateTime.UtcNow;
            if (Host && World is { Run: null, Proposal: null } idle &&
                !idle.World.MatchHumanIds.ToHashSet().SetEquals(idle.Members.Where(m => Online.Contains(m.SteamId)).Select(m => m.PersonId)))
            {
                var copy = CoopJson.Copy(idle); CoopJson.Detached(copy.World);
                CoopRules.SetParticipants(copy, Online); copy.Revision++; Commit(copy, null);
            }
            if (Host && World != null) foreach (var m in World.Members.Where(m => m.SteamId != Self)) Send(m.SteamId, "ping", new CoopHeartbeat(World.Epoch, Online.ToArray()));
            else if (World != null) Send(_transport.Owner, "pong", World.Epoch);
            Changed?.Invoke();
        }
    }
    private void Send<T>(ulong peer, string kind, T value)
    { if (_transport.Peers.Contains(peer)) _transport.Send(peer, new(kind, JsonSerializer.Serialize(value, CoopJson.Options))); }
    public void SendRun(string kind, object payload)
    {
        if (World == null) return;
        if (Host) foreach (var m in World.Members.Where(m => m.SteamId != Self)) Send(m.SteamId, kind, payload);
        else Send(World.Owner, kind, payload);
    }
    private static T Read<T>(CoopWire wire) => JsonSerializer.Deserialize<T>(wire.Payload, CoopJson.Options) ?? throw new InvalidDataException("房间消息为空。");
    private void Receive(ulong sender, CoopWire wire)
    {
        if (_closed || sender == Self) return;
        try
        {
            if (wire.Kind == "hello" && Host && World != null)
            {
                var hello = Read<CoopHello>(wire);
                string? error = hello.Token != _token ? "房间邀请码已经失效或不属于这个房间，请使用房主当前显示的邀请码。"
                    : hello.Protocol != CoopWorld.Protocol ? $"国运尖塔联机协议不同：房主 {CoopWorld.Protocol}，客机 {hello.Protocol}。请双方更新模组并完全重启游戏。"
                    : CoopContentIdentity.Difference(_compatibility, hello.Compatibility);
                if (error != null)
                {
                    RecordJoinError(error);
                    Send(sender, "error", error); return;
                }
                var copy = CoopJson.Copy(World); CoopJson.Detached(copy.World);
                CoopRules.AddMember(copy, sender, hello.Name); copy.Proposal = null; _seen[sender] = DateTime.UtcNow;
                Commit(copy, NativeSave); return;
            }
            if (!Host && sender != _transport.Owner) return;
            if (Host && (World == null || !World.Members.Any(m => m.SteamId == sender) || !_seen.ContainsKey(sender))) return;
            if (wire.Kind is "diagnostics-request" or "diagnostics-part") { ReceiveDiagnostic(sender, wire); return; }
            if (wire.Kind == "private-chunk") { ReceivePrivate(wire); return; }
            switch (wire.Kind)
            {
                case "ping" when !Host:
                    var heartbeat = Read<CoopHeartbeat>(wire);
                    if (World != null && heartbeat.Epoch != World.Epoch) { World = null; NativeSave = null; break; }
                    _seen.Clear(); foreach (ulong id in heartbeat.Online) _seen[id] = DateTime.UtcNow;
                    _seen[sender] = DateTime.UtcNow; Send(sender, "pong", heartbeat.Epoch); break;
                case "pong" when Host:
                    if (Read<string>(wire) == World!.Epoch) _seen[sender] = DateTime.UtcNow; break;
                case "snapshot" when !Host:
                    if (_assembler.Add(Read<CoopPart>(wire)) is not { } bytes) break;
                    var snapshot = CoopJson.Read<CoopSnapshot>(bytes);
                    if (snapshot.World.Owner != sender || snapshot.World.Schema != 1 || !snapshot.World.Members.Any(m => m.SteamId == Self)) throw new InvalidDataException("存档成员不匹配。");
                    if (World != null && (World.Id != snapshot.World.Id || World.Epoch == snapshot.World.Epoch && World.Revision > snapshot.World.Revision)) break;
                    _storage.Save(snapshot.World, snapshot.Run); World = snapshot.World; NativeSave = snapshot.Run;
                    CoopJson.Detached(World.World); _seen[sender] = DateTime.UtcNow; Status = "已同步";
                    foreach (var group in World.World.Chats.Groups.Where(g => !GroupChats.Busy(g))) { AiService.GroupLive.Remove(World.Id + "/group/" + group.Id); AiService.GroupReasoningLive.Remove(World.Id + "/group/" + group.Id); }
                    CompleteReplies(); Changed?.Invoke(); break;
                case "command" when Host:
                    var command = Read<CoopCommand>(wire);
                    if (!Rate(sender)) { Send(sender, "reply", new CoopReply(command.Id, new(false, "操作过于频繁，请稍后再试。"))); break; }
                    Execute(sender, command); break;
                case "reply" when !Host:
                    var reply = Read<CoopReply>(wire);
                    if (!_pendingCommands.TryGetValue(reply.Id, out var pending)) break;
                    _pendingCommands[reply.Id] = (pending.Command, pending.Sent, reply);
                    if (reply.Outcome.Accepted && pending.Command.Kind == "confirm" && World?.Proposal?.Id == pending.Command.Target)
                        World.Proposal.Votes.Add(Self);
                    Status = reply.Outcome.Accepted ? "主机已确认，正在同步。" : reply.Outcome.Message;
                    CompleteReplies(); Changed?.Invoke(); break;
                case "error": Status = Read<string>(wire); RecordJoinError(Status); Changed?.Invoke(); break;
                case "live" when !Host:
                    if (_liveAssembler.Add(Read<CoopPart>(wire)) is not { } liveBytes) break;
                    var live = CoopJson.Read<CoopRun>(liveBytes);
                    if (World?.Run is { } current && current.Attempt == live.Attempt && current.ResumeCount == live.ResumeCount && current.Phase != "paused") { World.Run = live; Changed?.Invoke(); } break;
                default:
                    if (wire.Kind.StartsWith("run-", StringComparison.Ordinal)) RunMessage?.Invoke(new(wire.Kind, JsonSerializer.Serialize(new { sender, payload = wire.Payload })));
                    break;
            }
        }
        catch (Exception e) { Status = "同步操作失败：" + e.Message; Diagnostics.Error("coop.receive", e); Changed?.Invoke(); }
    }
    private void RecordJoinError(string error)
    {
        if (_lastJoinError == error) return;
        _lastJoinError = error;
        Diagnostics.Record("coop.join.rejected", error);
        Console.WriteLine("[NationalSpire] " + error);
    }
    private bool Rate(ulong sender)
    {
        var rate = _rates.GetValueOrDefault(sender);
        if (DateTime.UtcNow - rate.At > TimeSpan.FromSeconds(10)) rate = (DateTime.UtcNow, 0);
        _rates[sender] = (rate.At, rate.Count + 1); return rate.Count < 30;
    }
    public CoopCommand Submit(string kind, string target = "", string text = "", int number = 0, string parent = "")
    {
        var w = World ?? throw new InvalidOperationException("世界尚未同步。");
        var command = new CoopCommand(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent);
        Retry(command); return command;
    }
    public void Retry(CoopCommand command)
    {
        if (Host) { Execute(Self, command); return; }
        if (_pendingCommands.TryGetValue(command.Id, out var previous)
            && (previous.Reply != null || DateTime.UtcNow - previous.Sent < TimeSpan.FromSeconds(3))) return;
        _pendingCommands[command.Id] = (command, DateTime.UtcNow, null);
        Send(_transport.Owner, "command", command);
    }
    private void CompleteReplies()
    {
        foreach (var pending in _pendingCommands.Values.ToArray())
        {
            if (World != null && (pending.Command.World != World.Id || pending.Command.Epoch != World.Epoch))
            {
                _pendingCommands.Remove(pending.Command.Id);
                Replied?.Invoke(new(pending.Command.Id, new(false, "房间会话已改变，请重新操作。")));
                continue;
            }
            if (pending.Reply is not { } reply) continue;
            if (reply.Outcome.Accepted && (World == null || World.Revision < reply.Revision)) continue;
            _pendingCommands.Remove(reply.Id);
            Replied?.Invoke(reply);
        }
    }
    private void Execute(ulong sender, CoopCommand command)
    {
        if (World == null) return;
        var result = CoopRules.Apply(World, sender, command, Online, _characters);
        Diagnostics.Record("coop.command", new { world = World.Id, sender, command.Id, command.Kind, command.Revision, result.Outcome.Accepted, result.Outcome.Duplicate, result.Outcome.Message });
        bool changed = !result.Outcome.Duplicate && (result.Outcome.Accepted || result.World.Revision > World.Revision);
        if (changed) Commit(result.World, result.World.Run?.Attempt == World.Run?.Attempt && result.World.Run != null ? NativeSave : null, false);
        // 持久化后先回执，再发送完整世界；客机收到相应版本后才继续后续操作。
        var reply = new CoopReply(command.Id, result.Outcome, World.Revision); Status = reply.Outcome.Message;
        if (sender != Self) Send(sender, "reply", reply); else Replied?.Invoke(reply);
        if (changed || result.Outcome.Duplicate && sender != Self) Broadcast();
        Changed?.Invoke();
        if (result.Outcome.Accepted && !result.Outcome.Duplicate) TriggerAi?.Invoke(command.Kind);
        if (result.Outcome.Accepted && !result.Outcome.Duplicate) StartPrivate(sender, command);
        if (result.Outcome.Accepted && !result.Outcome.Duplicate) StartGroup(sender, command);
    }
    public void Commit(CoopWorld world, byte[]? nativeSave, bool broadcast = true)
    {
        if (!Host || _closed || world.Owner != Self || World != null && World.Id != world.Id) throw new InvalidOperationException("无权提交这个世界。");
        _storage.Save(world, nativeSave); World = world; NativeSave = nativeSave; CoopJson.Detached(World.World);
        if (broadcast) Broadcast(); Changed?.Invoke();
    }
    public void Broadcast()
    {
        if (!Host || World == null) return;
        foreach (ulong peer in World.Members.Select(m => m.SteamId).Where(p => p != Self && _seen.ContainsKey(p)))
        {
            var view = PrivateSnapshot(World, peer);
            var settings = AiSettingsStore.Load(new());
            view.World.PrivatePromptSnapshot = PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds).Append("world").ToDictionary(id => id, id => PromptLibrary.Get(settings, id));
            var parts = CoopAssembler.Split(CoopJson.PublicBytes(new CoopSnapshot(view, NativeSave))).ToArray();
            foreach (var part in parts) Send(peer, "snapshot", part);
        }
    }
    public void PublishLive()
    {
        if (!Host || World?.Run == null) return;
        var parts = CoopAssembler.Split(CoopJson.Bytes(World.Run)).ToArray();
        foreach (var member in World.Members.Where(m => m.SteamId != Self))
            foreach (var part in parts) Send(member.SteamId, "live", part);
    }
    public void Dispose() { _closed = true; _transport.Received -= Receive; _transport.Dispose(); }
}
