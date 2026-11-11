using System.Reflection;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens;
using MegaCrit.Sts2.Core.Nodes.Screens.Capstones;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>把少量版本相关探测集中在入口；地图节点通过公开场景树获取。</summary>
public static class LiveCompatibility
{
    private const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    // 原版提供对局计时暂停时才使用它。旧版仍可从暂停菜单判断是否应暂缓约会请求。
    private static class DateTimer
    {
        private static readonly PropertyInfo? Pause = typeof(RunManager).GetProperty("IsPaused", Flags);
        internal static readonly Func<RunManager, bool>? Read = Pause?.GetMethod?.CreateDelegate<Func<RunManager, bool>>();
        internal static readonly Action<RunManager, bool>? Write = Pause?.SetMethod?.CreateDelegate<Action<RunManager, bool>>();
    }
    internal static bool IsDateRunPaused() => DateTimer.Read?.Invoke(RunManager.Instance)
        ?? (NCapstoneContainer.Instance?.CurrentCapstoneScreen is NCapstoneSubmenuStack { ScreenType: NetScreenType.PauseMenu });
    internal static void SetDateTimerPaused(bool paused) => DateTimer.Write?.Invoke(RunManager.Instance, paused);
    private static readonly MethodInfo? StateReader = new[] { "GetRunState", "GetState", "DebugOnlyGetState" }
        .Select(name => typeof(RunManager).GetMethod(name, Flags, Type.EmptyTypes))
        .FirstOrDefault(m => m != null && typeof(RunState).IsAssignableFrom(m.ReturnType));
    private static readonly FieldInfo? RunField = typeof(NRun).GetFields(Flags).FirstOrDefault(f => f.FieldType == typeof(RunState));
    public static RunState? ReadState(NRun node) => StateReader?.Invoke(RunManager.Instance, null) as RunState ?? RunField?.GetValue(node) as RunState;
    public static Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, NMapPoint> MapPoints(Node screen)
    {
        var result = new Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, NMapPoint>();
        void Visit(Node node)
        {
            if (node is NMapPoint point && !point.IsQueuedForDeletion()) result[point.Point.coord] = point;
            foreach (var child in node.GetChildren()) Visit(child);
        }
        Visit(screen); return result;
    }
    public static void Install(Harmony harmony, Assembly assembly)
    {
        foreach (var type in assembly.GetTypes().Where(t => t.GetCustomAttributes(typeof(HarmonyPatch), false).Length > 0))
        {
            try { harmony.CreateClassProcessor(type).Patch(); }
            catch (Exception e) { Diagnostics.Error("patch:" + type.Name, e); GD.PushWarning($"[NationalSpire] {type.Name} 接口暂不可用，其他模块继续加载：{e.GetBaseException().Message}"); }
        }
    }
}
