using System.Collections;
using System.Reflection;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
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
    public static void AddLocal(StartRunLobby lobby, UnlockState unlocks, int ascension) =>
        RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int)), lobby, unlocks, ascension);
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
        _ = RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int));
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
                    "PlayerChanged" => count == 2 && method.GetParameters()[1].ParameterType == typeof(bool),
                    "PlayerConnected" or "RemotePlayerDisconnected" or "LocalPlayerDisconnected" or "PlayerReadyChanged" => count == 1,
                    "AscensionChanged" or "SeedChanged" or "ModifiersChanged" or "MaxAscensionChanged" => count == 0,
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
