using System.Collections;
using System.Reflection;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace NationalSpire.Coop;

/// <summary>隔离两个游戏分支的大堂成员和握手签名，不把分支特有类型写入模组接口。</summary>
public static class NativeLobbyApi
{
    public sealed record Member(ulong Id, bool Ready, CharacterModel? Character = null, SerializableUnlockState? Unlocks = null);
    private static readonly Dictionary<(Type, string), MemberInfo> Members = [];
    private static MemberInfo Find(Type type, string name)
    {
        if (Members.TryGetValue((type, name), out var found)) return found;
        return Members[(type, name)] = (MemberInfo?)type.GetProperty(name) ?? type.GetField(name)
            ?? throw new MissingMemberException(type.FullName, name);
    }
    private static object? Read(object value, string name) => Find(value.GetType(), name) switch
    { PropertyInfo p => p.GetValue(value), FieldInfo f => f.GetValue(value), _ => throw new NotSupportedException() };
    private static void Write(object value, string name, object content)
    {
        switch (Find(value.GetType(), name))
        { case PropertyInfo p: p.SetValue(value, content); break; case FieldInfo f: f.SetValue(value, content); break; }
    }
    public static Member Player(object player, bool full = true) => new((ulong)Read(player, "id")!, (bool)Read(player, "isReady")!,
        full ? (CharacterModel)Read(player, "character")! : null, full ? (SerializableUnlockState)Read(player, "unlockState")! : null);
    public static IReadOnlyList<Member> Players(StartRunLobby lobby) => ((IEnumerable)Read(lobby, "Players")!).Cast<object>().Select(p => Player(p)).ToList();
    public static Member Local(StartRunLobby lobby) => Player(Read(lobby, "LocalPlayer")!);
    public static IReadOnlyList<Member> Players(LoadRunLobby lobby)
    {
        if (typeof(LoadRunLobby).GetProperty("Players") is { } players)
            return ((IEnumerable)players.GetValue(lobby)!).Cast<object>().Select(p => Player(p, false)).ToList();
        var ready = RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong));
        return ((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>().Select(id => new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!)).ToList();
    }
    private static ConstructorInfo StartConstructor() => typeof(StartRunLobby).GetConstructor(
        [typeof(GameMode), typeof(bool), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])
        ?? typeof(StartRunLobby).GetConstructor([typeof(GameMode), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])
        ?? throw new MissingMethodException(typeof(StartRunLobby).FullName, ".ctor");
    public static StartRunLobby CreateStart(GameMode mode, INetGameService service, IStartRunLobbyListener listener, int members)
    {
        var constructor = StartConstructor();
        return (StartRunLobby)constructor.Invoke(constructor.GetParameters().Length == 5
            ? [mode, false, service, listener, members] : [mode, service, listener, members]);
    }
    private static MethodInfo AddLocalMethod() => typeof(StartRunLobby).GetMethods().Any(m => m.Name == "AddLocalHostPlayer"
        && m.GetParameters().Length >= 3 && m.GetParameters()[2].ParameterType == typeof(int))
        ? RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int), typeof(int))
        : RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int));
    public static void AddLocal(StartRunLobby lobby, UnlockState unlocks, int ascension)
    {
        var add = AddLocalMethod();
        if (add.GetParameters().Length >= 3 && add.GetParameters()[2].ParameterType == typeof(int))
            RuntimeApi.Invoke(add, lobby, unlocks, ascension, 5);
        else RuntimeApi.Invoke(add, lobby, unlocks, ascension);
    }
    public static ClientLobbyJoinRequestMessage JoinRequest(UnlockState unlocks, int ascension)
    {
        object request = new ClientLobbyJoinRequestMessage { unlockState = unlocks.ToSerializable() };
        if (request.GetType().GetField("maxAscensionUnlocked") != null) Write(request, "maxAscensionUnlocked", ascension);
        else { Write(request, "maxStandardAscension", ascension); Write(request, "maxBlitzAscension", 5); }
        return (ClientLobbyJoinRequestMessage)request;
    }
    public static void SetCharacter(StartRunLobby lobby, CharacterModel character) =>
        RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel)), lobby, character);
    private static MethodInfo DisconnectMethod() => RuntimeApi.Bind(typeof(NetHostGameService), "DisconnectClient", false,
        typeof(ulong), typeof(NetError), typeof(bool));
    public static void Disconnect(NetHostGameService service, ulong player, NetError error) =>
        RuntimeApi.Invoke(DisconnectMethod(), service, player, error, false);
    public static MethodInfo MultiplayerStart(Type acts, Type modifiers)
    {
        bool players = typeof(NGame).GetMethods().Any(m => m.Name == "StartNewMultiplayerRun"
            && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(List<Player>));
        if (players)
        {
            _ = RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string));
            return RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(List<Player>), typeof(StartRunLobby),
                typeof(bool), acts, modifiers, typeof(string), typeof(int));
        }
        return RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool),
            acts, modifiers, typeof(string), typeof(int));
    }
    public static Task StartMultiplayer(MethodInfo start, NGame game, StartRunLobby lobby, IReadOnlyList<ActModel> acts,
        IReadOnlyList<ModifierModel> modifiers, string seed, int ascension)
    {
        if (start.GetParameters()[0].ParameterType == typeof(List<Player>))
        {
            // 游戏大厅已确定角色；每台电脑复用游戏创建流程，为名单中的每人创建一次。
            var players = RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string)), lobby, seed);
            return (Task)RuntimeApi.Invoke(start, game, players, lobby, true, acts, modifiers, seed, ascension)!;
        }
        return (Task)RuntimeApi.Invoke(start, game, lobby, true, acts, modifiers, seed, ascension)!;
    }
    public static object? Version()
    {
        var type = typeof(NetHostGameService).Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo");
        return type == null ? null : RuntimeApi.Invoke(RuntimeApi.Bind(type, "LocalDefault", true), null);
    }
    public static T Service<T>(object? version) where T : class
    {
        var constructor = Constructor(typeof(T));
        return (T)constructor.Invoke(constructor.GetParameters().Length == 0 ? [] : [version ?? throw new InvalidOperationException("当前游戏需要联机版本信息。")]);
    }
    private static ConstructorInfo Constructor(Type type)
    {
        var versionType = type.Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo");
        return (versionType == null ? type.GetConstructor(Type.EmptyTypes) : type.GetConstructor([versionType]))
            ?? throw new MissingMethodException(type.FullName, "联机服务构造函数");
    }
    public static Task<NetErrorInfo?> Connect(object initializer, NetClientGameService service, CancellationToken token = default) =>
        (Task<NetErrorInfo?>)RuntimeApi.Invoke(RuntimeApi.Bind(initializer.GetType(), "Connect", false, service.GetType(), typeof(CancellationToken)), initializer, service, token)!;
    public static T Listener<T>(Func<MethodInfo, object?[], object?> callback) where T : class
    {
        var listener = DispatchProxy.Create<T, NativeLobbyListener>();
        ((NativeLobbyListener)(object)listener).Callback = callback; return listener;
    }
    // 未知必需接口应在转场前失败；可选尾部参数由 RuntimeApi 沿用原版默认值。
    public static void Validate()
    {
        _ = Constructor(typeof(NetHostGameService)); _ = Constructor(typeof(NetClientGameService));
        var versionType = typeof(NetHostGameService).Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo");
        if (versionType != null) _ = RuntimeApi.Bind(versionType, "LocalDefault", true);
        var startPlayer = typeof(StartRunLobby).GetProperty("LocalPlayer")?.PropertyType ?? throw new MissingMemberException("StartRunLobby.LocalPlayer");
        foreach (string name in new[] { "id", "isReady", "character", "unlockState" }) _ = Find(startPlayer, name);
        _ = Find(typeof(StartRunLobby), "Players");
        _ = StartConstructor(); _ = AddLocalMethod(); _ = DisconnectMethod();
        _ = RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel));
        var join = typeof(ClientLobbyJoinRequestMessage);
        foreach (string name in join.GetField("maxAscensionUnlocked") != null
            ? new[] { "maxAscensionUnlocked" } : new[] { "maxStandardAscension", "maxBlitzAscension" }) _ = Find(join, name);
        if (typeof(LoadRunLobby).GetProperty("Players") is { } players)
        {
            var player = players.PropertyType.GetGenericArguments().Single(); _ = Find(player, "id"); _ = Find(player, "isReady");
        }
        else { _ = Find(typeof(LoadRunLobby), "ConnectedPlayerIds"); _ = RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong)); }
        foreach (Type listener in new[] { typeof(IStartRunLobbyListener), typeof(ILoadRunLobbyListener) })
            foreach (var method in listener.GetMethods())
            {
                int count = method.GetParameters().Length;
                bool valid = method.Name switch
                {
                    "BeginRun" => method.ReturnType == typeof(void) && (count == 0 || method.GetParameters().Select(p => p.ParameterType).SequenceEqual(new[] { typeof(string), typeof(List<ActModel>), typeof(IReadOnlyList<ModifierModel>) })),
                    "ShouldAllowRunToBegin" => count == 0 && method.ReturnType == typeof(Task<bool>),
                    "PlayerChanged" => count == 1 || count == 2 && method.GetParameters()[1].ParameterType == typeof(bool),
                    "PlayerConnected" or "RemotePlayerDisconnected" or "LocalPlayerDisconnected" or "PlayerReadyChanged" => count == 1,
                    "AscensionChanged" or "SeedChanged" or "ModifiersChanged" or "MaxAscensionChanged" => count == 0,
                    "GameModeChanged" => count == 0 && method.ReturnType == typeof(void),
                    _ => false
                };
                if (!valid) throw new MissingMethodException("尚未适配的大厅回调：" + listener.Name + "." + method.Name);
            }
        _ = RuntimeApi.Bind(typeof(MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer), "Connect", false, typeof(NetClientGameService), typeof(CancellationToken));
    }
}

// 运行时实现当前游戏提供的接口，避免旧接口变化导致 Assembly.GetTypes 整体失败。
public class NativeLobbyListener : DispatchProxy
{
    public Func<MethodInfo, object?[], object?> Callback { get; set; } = null!;
    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args) => Callback(targetMethod!, args ?? []);
}
