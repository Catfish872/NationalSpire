using HarmonyLib;
using MegaCrit.Sts2.Core.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Managers;
using System.Reflection;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace NationalSpire.Coop;

/// <summary>只检查实际使用的接口及存档保护补丁，不按游戏版本号设白名单。</summary>
public static class CoopCompatibility
{
    public static string? Check(bool requirePatches = true)
    {
        var required = new (Type Type, string Name)[] {
            (typeof(NetHostGameService), "StartSteamHost"),
            (typeof(StartRunLobby), "SyncAscensionChange"), (typeof(NGame), "StartNewMultiplayerRun"),
            (typeof(RunSaveManager), "GetRunSavePath"), (typeof(SaveManager), "SaveRunHistory"),
            (typeof(RunManager), "ReturnToMainMenuWithError") };
        foreach (var item in required)
            if (AccessTools.Method(item.Type, item.Name) == null) return $"当前游戏缺少多人接口 {item.Type.Name}.{item.Name}，共同生涯暂不可用。";
        var save = AccessTools.Method(typeof(RunSaveManager), "SaveRun", [typeof(SerializableRun), typeof(bool)]);
        if (save == null) return "当前游戏的多人存档接口尚未适配。";
        try
        {
            NativeLobbyApi.Validate();
            RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool), typeof(List<ActModel>), typeof(List<ModifierModel>), typeof(string), typeof(int));
            RuntimeApi.Bind(typeof(RunManager), "SetUpSavedMultiplayer", false, typeof(RunState), typeof(LoadRunLobby));
            RuntimeApi.Bind(typeof(NGame), "LoadRun", false, typeof(RunState), typeof(SerializableRoom));
            _ = GameCompatibility.ActRng("COOP-COMPATIBILITY");
        }
        catch (Exception e) { Diagnostics.Error("coop.compatibility", e); return "当前游戏的多人开局或读档接口尚未适配，未开始转场。"; }
        if (!requirePatches) return null;
        foreach (var patch in new[] { typeof(CoopPathPatch), typeof(CoopSavePatch), typeof(CoopHistoryPatch) })
        {
            MethodBase method = patch == typeof(CoopSavePatch) ? save : AccessTools.Method(patch == typeof(CoopPathPatch) ? typeof(RunSaveManager) : typeof(SaveManager), patch == typeof(CoopPathPatch) ? "GetRunSavePath" : "SaveRunHistory");
            var info = Harmony.GetPatchInfo(method);
            if (info == null || !info.Prefixes.Concat(info.Postfixes).Any(p => p.PatchMethod.DeclaringType == patch))
                return "多人存档保护尚未生效，共同生涯暂不可用。";
        }
        var disconnect = AccessTools.Method(typeof(RunManager), "ReturnToMainMenuWithError");
        if (Harmony.GetPatchInfo(disconnect)?.Prefixes.Any(p => p.PatchMethod.DeclaringType == typeof(CoopDisconnectMenuPatch)) != true)
            return "多人断线返回处理尚未生效，共同生涯暂不可用。";
        return null;
    }
}
