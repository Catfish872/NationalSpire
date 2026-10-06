using HarmonyLib;
using MegaCrit.Sts2.Core.Multiplayer.Transport.Steam;
using Steamworks;

namespace NationalSpire.Coop;

// Steam 回调为进程级广播，各房间只能处理自己监听端口或连接的事件。
[HarmonyPatch(typeof(SteamHost), "OnNetStatusChanged")]
public static class CoopSteamHostCallbacks
{
    public static bool Prefix(SteamNetConnectionStatusChangedCallback_t data, HSteamListenSocket ____socket)
        => !CoopRuntime.Bound || Owns(____socket.m_HSteamListenSocket, data.m_info.m_hListenSocket.m_HSteamListenSocket);
    public static bool Owns(uint socket, uint incoming) => socket != 0 && socket == incoming;
}

[HarmonyPatch(typeof(MegaCrit.Sts2.Core.Multiplayer.Transport.Steam.SteamClient), "OnNetStatusChanged")]
public static class CoopSteamClientCallbacks
{
    public static bool Prefix(SteamNetConnectionStatusChangedCallback_t data, HSteamNetConnection? ____conn)
        => !CoopRuntime.Bound || ____conn is { } connection && connection == data.m_hConn;
}
