using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Connection;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Audio;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.Unlocks;
using System.Text.Json;

namespace NationalSpire.Coop;

public interface ICoopNativePlatform
{
    object? Version();
    Task<string> Host(NetHostGameService service, int members);
    Task<NetErrorInfo?> Join(NetClientGameService service, string lobby, CancellationToken token);
    Task BeginNew(StartRunLobby lobby, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, string seed, int ascension, CancellationToken token = default);
    Task BeginSaved(LoadRunLobby lobby, CancellationToken token = default);
}
public sealed class CoopSteamRunPlatform : ICoopNativePlatform
{
    public object? Version() => NativeLobbyApi.Version();
    public async Task<string> Host(NetHostGameService service, int members)
    {
        await LeaveOriginalLobby();
        if (await service.StartSteamHost(members) is { } error) throw new IOException(error.ToString());
        return service.GetRawLobbyIdentifier() ?? throw new IOException("原版未返回联机大厅标识。");
    }
    public async Task<NetErrorInfo?> Join(NetClientGameService service, string lobby, CancellationToken token)
    {
        await LeaveOriginalLobby(token);
        return ulong.TryParse(lobby, out ulong id) ? await NativeLobbyApi.Connect(SteamClientConnectionInitializer.FromLobby(id), service, token) : throw new IOException("原版大厅标识无效。");
    }
    private static async Task LeaveOriginalLobby(CancellationToken token = default)
    {
        var stack = NGame.Instance?.MainMenu?.SubmenuStack;
        if (stack?.SubmenusOpen != true) return;
        if (RunManager.Instance.IsInProgress) throw new InvalidOperationException("请先退出正在进行的原版对局。");
        // 经原版关闭流程释放被生涯界面遮住的选人/读档大厅及其网络服务。
        while (stack.SubmenusOpen) stack.Pop();
        Diagnostics.Record("coop.native.menu-cleanup", "已退出原版子菜单，等待其延迟关闭监听端口。");
        await Task.Delay(1100, token);
    }
    public async Task BeginNew(StartRunLobby lobby, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, string seed, int ascension, CancellationToken token = default)
    {
        var game = NGame.Instance ?? throw new InvalidOperationException("游戏场景尚未初始化。");
        var start = RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool),
            acts.GetType(), modifiers.GetType(), typeof(string), typeof(int));
        // 与原版选人大厅一致，在任何对局节点创建前初始化远端光标和表情通信。
        game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer, NativeLobbyApi.Players(lobby).Select(p => p.Id));
        game.ReactionContainer.InitializeNetworking(lobby.NetService);
        CareerScreen.CloseCurrent(); CoopScreen.CloseCurrent();
        NAudioManager.Instance?.StopMusic();
        var character = NativeLobbyApi.Local(lobby).Character!;
        SfxCmd.Play(character.CharacterTransitionSfx);
        await game.Transition.FadeOut(.4f, character.CharacterSelectTransitionPath);
        try
        {
            token.ThrowIfCancellationRequested();
            await (Task)RuntimeApi.Invoke(start, game, lobby, true, acts, modifiers, seed, ascension)!;
            lobby.CleanUp(false);
        }
        finally { await game.Transition.FadeIn(.2f); }
    }
    public async Task BeginSaved(LoadRunLobby lobby, CancellationToken token = default)
    {
        var game = NGame.Instance ?? throw new InvalidOperationException("游戏场景尚未初始化。");
        var setup = RuntimeApi.Bind(typeof(RunManager), "SetUpSavedMultiplayer", false, typeof(RunState), typeof(LoadRunLobby));
        var load = RuntimeApi.Bind(typeof(NGame), "LoadRun", false, typeof(RunState), typeof(SerializableRoom));
        var state = RunState.FromSerializable(lobby.Run);
        var character = state.Players.Single(p => p.NetId == lobby.NetService.NetId).Character;
        game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer, state.Players.Select(p => p.NetId));
        game.ReactionContainer.InitializeNetworking(lobby.NetService);
        CareerScreen.CloseCurrent(); CoopScreen.CloseCurrent();
        NAudioManager.Instance?.StopMusic(); SfxCmd.Play(character.CharacterTransitionSfx);
        await game.Transition.FadeOut(.4f, character.CharacterSelectTransitionPath);
        try
        {
            token.ThrowIfCancellationRequested();
            await (Task)RuntimeApi.Invoke(setup, RunManager.Instance, state, lobby)!;
            token.ThrowIfCancellationRequested();
            await (Task)RuntimeApi.Invoke(load, game, state, lobby.Run.PreFinishedRoom)!;
            lobby.CleanUp(false);
        }
        finally { await game.Transition.FadeIn(.2f); }
    }
}
public sealed class CoopNativeRun(CoopCoordinator session, ICoopNativePlatform? platform = null)
{
    private readonly ICoopNativePlatform _platform = platform ?? new CoopSteamRunPlatform();
    private IStartRunLobbyListener StartListener => NativeLobbyApi.Listener<IStartRunLobbyListener>(Callback);
    private ILoadRunLobbyListener LoadListener => NativeLobbyApi.Listener<ILoadRunLobbyListener>(Callback);
    private object? Callback(System.Reflection.MethodInfo method, object?[] args)
    {
        switch (method.Name)
        {
            case "ShouldAllowRunToBegin": return ShouldAllowRunToBegin();
            case "BeginRun":
                if (args.Length == 0) BeginRun();
                else BeginRun((string)args[0]!, (List<ActModel>)args[1]!, (IReadOnlyList<ModifierModel>)args[2]!);
                break;
            case "PlayerChanged": PlayerChanged(NativeLobbyApi.Player(args[0]!), (bool)args[1]!); break;
            case "RemotePlayerDisconnected": if (!_stopping && (_launched || _entering)) NeedsPause = true; break;
            case "LocalPlayerDisconnected": if (!_stopping && HasConnection) NeedsPause = true; break;
        }
        return null;
    }
    private INetGameService? _service;
    private StartRunLobby? _start;
    private LoadRunLobby? _load;
    private string _attempt = "", _lobby = "";
    private bool _busy, _launched, _failed, _stopping;
    public bool PauseRequestedByHost { get; private set; }
    private bool _entering;
    private TaskCompletionSource? _entryCompleted;
    private int _generation;
    private CancellationTokenSource _lifetime = new();
    private DateTime _announced, _began;
    private DateTime _checkedStage;
    private string _waitingStage = "";
    public string Status { get; private set; } = "";
    public string LastError { get; private set; } = "";
    public bool Launched => _launched;
    public bool Entering => _entering;
    public Task WaitForEntry() => _entryCompleted?.Task ?? Task.CompletedTask;
    public bool HasConnection => _service != null;
    public bool OwnsConnection(INetGameService service) => _service != null && ReferenceEquals(_service, service);
    public void StopConnection()
    {
        // 先中断对局通信，让等待远端消息的原版加载任务能够结束。
        _stopping = true; _lifetime.Cancel();
        if (_service?.IsConnected == true) _service.Disconnect(NetError.Quit);
    }
    public void PumpPendingNetwork() { if (!_launched) _service?.Update(); }
    public bool NeedsPause { get; private set; }
    public void Update()
    {
        if (_failed || _stopping && _service != null) return;
        PumpPendingNetwork();
        if (session.Host && !_launched && session.Full)
        {
            if (_start != null && NativeLobbyApi.Players(_start) is var starting && starting.Count == session.World!.Run!.Characters.Count && !NativeLobbyApi.Local(_start).Ready
                && starting.Where(p => p.Id != session.Self).All(p => p.Ready)) _start.SetReady(true);
            if (_load != null && NativeLobbyApi.Players(_load) is var loading && loading.Count == session.World!.Run!.Characters.Count && !loading.First(p => p.Id == session.Self).Ready
                && loading.Where(p => p.Id != session.Self).All(p => p.Ready)) _load.SetReady(true);
        }
        if (session.World?.Run == null) { if (_launched && !RunManager.Instance.IsInProgress) Close(); return; }
        if (session.World.Run.Terminal != null || session.World.Run.Phase == "paused" || !session.World.Run.Characters.ContainsKey(session.Self)) return;
        if (session.Host && session.Full && CoopRuntime.Current?.ResumeRequired != true && !_busy && _service == null && !RunManager.Instance.IsInProgress) _ = Host();
        if (_launched && !session.Full) NeedsPause = true;
        if (_service != null && !_launched && DateTime.UtcNow - _checkedStage > TimeSpan.FromSeconds(2))
        {
            _checkedStage = DateTime.UtcNow;
            string stage = WaitingStage();
            if (stage != _waitingStage)
            {
                _waitingStage = stage;
                Diagnostics.Record("coop.native.wait", new { host = session.Host, attempt = _attempt, stage });
            }
            Status = stage;
        }
        if (_service != null && !_launched && DateTime.UtcNow - _began > TimeSpan.FromSeconds(90))
            Fail(new TimeoutException("等待队员开赛超时，检查点已保留。" + _waitingStage + "。请检查双方联机模组是否一致。"));
        if (session.Host && _lobby.Length > 0 && !_launched && DateTime.UtcNow - _announced > TimeSpan.FromSeconds(4))
        { _announced = DateTime.UtcNow; session.SendRun("run-host", new { epoch = session.World.Epoch, attempt = _attempt, resume = session.World.Run.ResumeCount, lobby = _lobby, load = session.NativeSave != null }); }
    }
    private string WaitingStage()
    {
        if (_entering) return "正在载入对局场景";
        var players = _start != null ? NativeLobbyApi.Players(_start) : _load != null ? NativeLobbyApi.Players(_load) : null;
        if (players == null) return "等待原版大厅响应";
        int capacity = session.World!.Run!.Characters.Count;
        if (players.Count < capacity) return $"等待原版大厅成员同步（{players.Count}/{capacity}）";
        var waiting = players.Where(p => !p.Ready).Select(p => session.World.Members.FirstOrDefault(m => m.SteamId == p.Id)?.Name ?? "队员");
        string names = string.Join("、", waiting);
        return names.Length > 0 ? "等待确认角色与准备状态：" + names : "全员已准备，正在校验对局资料";
    }
    private async Task Host()
    {
        int generation = _generation;
        _stopping = false; PauseRequestedByHost = false;
        _busy = true; _began = DateTime.UtcNow; LastError = "";
        try
        {
            _attempt = session.World!.Run!.Attempt;
            NativeLobbyApi.Validate();
            var service = NativeLobbyApi.Service<NetHostGameService>(_platform.Version()); _service = service;
            service.ClientConnected += id => { if (!session.World!.Run!.Characters.ContainsKey(id)) service.DisconnectClient(id, NetError.Quit); };
            service.ClientDisconnected += (_, _) => { if (!_stopping && generation == _generation && ReferenceEquals(service, _service) && (_launched || _entering)) NeedsPause = true; };
            string lobbyId = await _platform.Host(service, session.World.Run!.Characters.Count);
            if (generation != _generation) { if (service.IsConnected) service.Disconnect(NetError.Quit); return; }
            if (session.NativeSave is { } bytes)
            {
                var save = Decode(bytes); Validate(save);
                _load = new(service, LoadListener, save); _load.AddLocalHostPlayer();
            }
            else
            {
                _start = new(GameMode.Standard, service, StartListener, session.World.Run!.Characters.Count);
                NativeLobbyApi.AddLocal(_start, UnlockState.all, 10); _start.SetLocalCharacter(Character());
                _start.SetSeed(session.World.Run.Seed); _start.SyncAscensionChange(session.World.Run.Ascension);
            }
            _lobby = lobbyId;
            Status = "等待全体队员进入比赛";
        }
        catch (Exception e) { if (generation == _generation) Fail(e); }
        finally { if (generation == _generation) _busy = false; }
    }
    public void Message(CoopWire wire)
    {
        using var envelope = JsonDocument.Parse(wire.Payload); ulong sender = envelope.RootElement.GetProperty("sender").GetUInt64();
        using var doc = JsonDocument.Parse(envelope.RootElement.GetProperty("payload").GetString()!);
        var value = doc.RootElement;
        if (session.World?.Run is not { } run || value.GetProperty("attempt").GetString() != run.Attempt) return;
        if (!value.TryGetProperty("epoch", out var epoch) || epoch.GetString() != session.World.Epoch) return;
        if (!value.TryGetProperty("resume", out var resume) || resume.GetInt32() != run.ResumeCount) return;
        if (wire.Kind == "run-failed" && session.World.Members.Any(m => m.SteamId == sender))
        {
            string error = value.GetProperty("error").GetString() ?? "队友连接失败";
            LastError = Diagnostics.Redact(error.Length > 2000 ? error[..2000] : error);
            Status = "比赛连接失败：" + LastError; NeedsPause = true;
            Diagnostics.Record("coop.native.remote-failure", new { sender, error = LastError }); return;
        }
        if (wire.Kind == "run-pause" && session.Host && run.Phase != "paused" && session.World.Members.Any(m => m.SteamId == sender)) { NeedsPause = true; return; }
        if (wire.Kind == "run-return" && !session.Host && sender == session.World.Owner)
        { if (!_stopping && HasConnection) { PauseRequestedByHost = true; NeedsPause = true; } return; }
        if (wire.Kind == "run-host" && !session.Host && run.Characters.ContainsKey(session.Self) && sender == session.World.Owner && run.Phase != "paused" && CoopRuntime.Current?.ResumeRequired != true && !_busy && !_launched && _service == null)
            _ = Join(value.GetProperty("lobby").GetString()!, value.GetProperty("load").GetBoolean());
    }
    private async Task Join(string lobby, bool load)
    {
        int generation = _generation;
        _stopping = false; PauseRequestedByHost = false;
        _busy = true; _began = DateTime.UtcNow; LastError = "";
        try
        {
            _attempt = session.World!.Run!.Attempt;
            NativeLobbyApi.Validate();
            var service = NativeLobbyApi.Service<NetClientGameService>(_platform.Version()); _service = service;
            service.Disconnected += _ => { if (!_stopping && generation == _generation && ReferenceEquals(service, _service) && (_launched || _entering)) NeedsPause = true; };
            var connected = new TaskCompletionSource(); service.ConnectedToHost += () => connected.TrySetResult();
            service.RegisterMessageHandler<InitialGameInfoMessage>((_, _) => { });
            if (load) service.RegisterMessageHandler<ClientLoadJoinResponseMessage>((message, _) =>
            {
                try { _load = new(service, LoadListener, message); Validate(_load.Run); _load.SetReady(true); }
                catch (Exception e) { Fail(e); }
            });
            else service.RegisterMessageHandler<ClientLobbyJoinResponseMessage>((message, _) =>
            {
                try { _start = new(GameMode.Standard, service, StartListener, session.World.Run!.Characters.Count); _start.InitializeFromMessage(message); _start.SetLocalCharacter(Character()); _start.SetReady(true); }
                catch (Exception e) { Fail(e); }
            });
            using var timeout = CancellationTokenSource.CreateLinkedTokenSource(_lifetime.Token); timeout.CancelAfter(TimeSpan.FromSeconds(30));
            if (await _platform.Join(service, lobby, timeout.Token) is { } error) throw new IOException(error.ToString());
            await connected.Task.WaitAsync(timeout.Token);
            if (generation != _generation) return;
            if (load) service.SendMessage(new ClientLoadJoinRequestMessage());
            else service.SendMessage(new ClientLobbyJoinRequestMessage { maxAscensionUnlocked = 10, unlockState = UnlockState.all.ToSerializable() });
        }
        catch (Exception e) { if (generation == _generation) Fail(e); }
        finally { if (generation == _generation) _busy = false; }
    }
    private CharacterModel Character() => session.World!.Run!.Characters[session.Self] == CareerEngine.RandomCharacterChoice
        ? GameBridge.RandomChoice() : GameBridge.Characters().Single(c => c.Id.ToString() == session.World.Run.Characters[session.Self]);
    public static byte[] Encode(SerializableRun save)
    { var writer = new PacketWriter { WarnOnGrow = false }; writer.Write(save); return writer.Buffer[..writer.BytePosition]; }
    public static SerializableRun Decode(byte[] bytes)
    { var reader = new PacketReader(); reader.Reset(bytes); return reader.Read<SerializableRun>(); }
    private void Validate(SerializableRun save)
    {
        var state = RunState.FromSerializable(save); var run = session.World!.Run!;
        if (state.Rng.StringSeed != run.Seed || state.AscensionLevel != run.Ascension || !state.Players.Select(p => p.NetId).Order().SequenceEqual(run.Characters.Keys.Order())
            || state.Players.Any(p => run.Characters[p.NetId] != p.Character.Id.ToString())) throw new InvalidDataException("原版对局与共同生涯绑定不一致。");
    }
    public Task<bool> ShouldAllowRunToBegin()
    {
        var run = session.World?.Run;
        bool match = run != null && run.Phase != "paused" && (!session.Host || session.Full) && (_load == null || NativeLobbyApi.Players(_load).Count == run.Characters.Count) && (_start == null || NativeLobbyApi.Players(_start).Count == run.Characters.Count && NativeLobbyApi.Players(_start).All(p => run.Characters.TryGetValue(p.Id, out string? character) && (character == p.Character!.Id.ToString() || character == CareerEngine.RandomCharacterChoice && p.Character is MegaCrit.Sts2.Core.Models.Characters.RandomCharacter)) && _start.Seed == run.Seed && _start.Ascension == run.Ascension);
        return Task.FromResult(match);
    }
    public async void BeginRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> modifiers)
    {
        int generation = _generation;
        var completed = _entryCompleted = new();
        try
        {
            if (!await ShouldAllowRunToBegin()) throw new InvalidDataException("队伍开赛条件发生变化。");
            var lobby = _start!; _entering = true;
            await _platform.BeginNew(lobby, acts, modifiers, seed, session.World!.Run!.Ascension, _lifetime.Token);
            if (generation != _generation) return;
            _start = null;
            _launched = true;
            if (session.Host) Save(RunManager.Instance.ToSave(null));
            Status = "比赛进行中";
        }
        catch (Exception e) { if (generation == _generation) Fail(e); }
        finally { completed.TrySetResult(); if (generation == _generation) _entering = false; }
    }
    public async void BeginRun()
    {
        int generation = _generation;
        var completed = _entryCompleted = new();
        try
        {
            var lobby = _load!; Validate(lobby.Run);
            if (!await ShouldAllowRunToBegin()) throw new InvalidDataException("队伍尚未全部连接。");
            _entering = true;
            await _platform.BeginSaved(lobby, _lifetime.Token);
            if (generation != _generation) return;
            _load = null; Status = "比赛已恢复";
            _launched = true;
        }
        catch (Exception e) { if (generation == _generation) Fail(e); }
        finally { completed.TrySetResult(); if (generation == _generation) _entering = false; }
    }
    public void Save(SerializableRun save)
    {
        if (!session.Host || session.World?.Run == null || session.World.Run.Phase == "paused") return;
        Validate(save); var next = session.World.RunCheckpoint(); next.Run!.Phase = "running";
        session.Commit(next, Encode(save));
    }
    private void Fail(Exception e)
    {
        _failed = true; NeedsPause = true; LastError = Diagnostics.Redact(e.Message);
        Status = "比赛连接失败：" + LastError; Diagnostics.Error("coop.native", e);
        if (session.World?.Run is { } run)
            session.SendRun("run-failed", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount, error = LastError });
    }
    public void Close()
    {
        _stopping = true; _generation++; _lifetime.Cancel(); _lifetime.Dispose(); _lifetime = new();
        var service = _service; _service = null;
        _start?.CleanUp(false); _load?.CleanUp(false); _start = null; _load = null;
        if (service?.IsConnected == true) service.Disconnect(NetError.Quit);
        _launched = _busy = _failed = _entering = NeedsPause = PauseRequestedByHost = false; _lobby = "";
        _waitingStage = ""; _checkedStage = default;
    }
    private void PlayerChanged(NativeLobbyApi.Member player, bool isRandomCharacterResolution)
    {
        if (!isRandomCharacterResolution || session.World?.Run is not { } run || run.Characters.GetValueOrDefault(player.Id) != CareerEngine.RandomCharacterChoice) return;
        // 原版大厅已统一确定结果，存档只记录实际角色，恢复时不再随机。
        run.Characters[player.Id] = player.Character!.Id.ToString();
        var member = session.World.Members.Single(m => m.SteamId == player.Id); member.Character = player.Character.Id.ToString();
    }
}
