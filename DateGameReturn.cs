using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace NationalSpire;

/// <summary>等待原版结算和解锁写入后回到原约会；返回标记支持重载后恢复。</summary>
public static class DateGameReturn
{
    private static int _returning;
    internal static bool Transitioning => _returning > 0;
    internal static async Task AfterMainMenu(Task original, NGame game)
    {
        var data = CareerStore.Data;
        if (Pending(data) == null) { await original; return; }
        _returning++;
        try
        {
            await original;
            try
            {
                // 原版完成旧场景释放和新菜单挂载后，统一恢复约会并入队战后回复。
                if (!GodotObject.IsInstanceValid(game) || !game.IsInsideTree()) return;
                await game.ToSignal(game.GetTree(), SceneTree.SignalName.ProcessFrame);
                if (_returning == 1 && GodotObject.IsInstanceValid(game) && CareerStore.IsCurrent(data) && game.MainMenu is { } menu)
                    CareerScreen.ReturnToDate(menu);
            }
            catch (Exception e) { Diagnostics.Error("date.game.restore", e); }
        }
        finally { _returning--; }
    }
    internal static CareerMatch? SavedMatch(CareerData data, string host, string offer, SerializableRun saved)
    {
        var match = DateGames.InProgress(data, host, offer);
        return match != null && CareerRunBinding.Find(data, saved.SerializableRng?.Seed ?? "",
            saved.Players?.FirstOrDefault()?.CharacterId?.ToString() ?? "", saved.Ascension,
            saved.Players?.Count ?? 0, saved.GameMode == GameMode.Standard, saved.StartTime)?.Id == match.Id ? match : null;
    }
    internal static Action PrepareSavedResume(CareerData data, string host, string offer)
    {
        if (RunManager.Instance.IsInProgress) throw new InvalidOperationException("当前原版对局仍在运行，请先关闭生涯界面返回对局。");
        var menu = NGame.Instance?.MainMenu;
        if (menu == null || !GodotObject.IsInstanceValid(menu) || !menu.IsInsideTree())
            throw new InvalidOperationException("主菜单恢复入口尚未就绪，请返回主菜单继续游戏。");
        // 沿用主菜单已经读取的同一份原版存档及其恢复流程，避免跨生涯或重建对局。
        var result = AccessTools.Field(typeof(NMainMenu), "_readRunSaveResult")?.GetValue(menu) as ReadSaveResult<SerializableRun>;
        if (result?.Success != true || result.SaveData == null)
            throw new InvalidOperationException("原版对局存档读取失败，请返回主菜单检查继续游戏入口。");
        if (SavedMatch(data, host, offer, result.SaveData) == null)
            throw new InvalidOperationException("原版存档与本次约会对局不匹配，请返回对应生涯继续游戏。");
        var resume = AccessTools.Method(typeof(NMainMenu), "OnContinueButtonPressed", [typeof(NButton)])
            ?? throw new MissingMethodException("原版继续游戏入口不可用，请从主菜单继续游戏。");
        Diagnostics.Record("date.game.resume.saved", new { match = data.PendingMatchId, result.SaveData.StartTime, result.SaveData.CurrentActIndex });
        return () => RuntimeApi.Invoke(resume, menu, (object?)null);
    }
    public static CareerMatch? Pending(CareerData data) => data.Matches.LastOrDefault(m => m.DateGame?.ReturnPending == true && m.Status == "已结算");
    private static bool CurrentRun() => Pending(CareerStore.Data) is { } match && LiveRunBridge.Current?.DateGameMatchId == match.Id;
    internal static async Task AfterIntro(Task original, NGameOverScreen screen)
    {
        await original;
        if (!CurrentRun() || !GodotObject.IsInstanceValid(screen) || !screen.IsInsideTree()) return;
        try
        {
            // 沿用原版的分数、徽章和发现流程；该方法的按钮参数只供信号签名使用。
            if (AccessTools.Field(typeof(NGameOverScreen), "_isAnimatingSummary")?.GetValue(screen) is false)
                AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen")!.Invoke(screen, [null]);
        }
        catch (Exception e) { Diagnostics.Error("date.game.summary", e); }
    }
    internal static async Task AfterSummary(Task original, NGameOverScreen screen)
    {
        await original;
        if (!CurrentRun() || !GodotObject.IsInstanceValid(screen) || !screen.IsInsideTree()) return;
        try { if (NGame.Instance is { } game) await game.ReturnToMainMenuAfterRun(); }
        catch (Exception e) { Diagnostics.Error("date.game.return", e); }
    }
}

[HarmonyPatch(typeof(NGame), nameof(NGame.ReturnToMainMenuAfterRun))]
public static class DateGameMenuReturnPatch
{
    public static void Postfix(NGame __instance, ref Task __result)
    { if (DateGameReturn.Pending(CareerStore.Data) != null) __result = DateGameReturn.AfterMainMenu(__result, __instance); }
}

[HarmonyPatch(typeof(NGameOverScreen), "AnimateIn")]
public static class DateGameIntroPatch
{
    public static bool Prepare() => AccessTools.Method(typeof(NGameOverScreen), "OpenSummaryScreen") != null
        && AccessTools.Method(typeof(NGameOverScreen), "AnimateIn")?.ReturnType == typeof(Task)
        && AccessTools.Method(typeof(NGameOverScreen), "AnimateRunSummary")?.ReturnType == typeof(Task);
    public static void Postfix(NGameOverScreen __instance, ref Task __result)
    { if (DateGameReturn.Pending(CareerStore.Data) != null) __result = DateGameReturn.AfterIntro(__result, __instance); }
}
[HarmonyPatch(typeof(NGameOverScreen), "AnimateRunSummary")]
public static class DateGameSummaryPatch
{
    public static bool Prepare() => DateGameIntroPatch.Prepare();
    public static void Postfix(NGameOverScreen __instance, ref Task __result)
    { if (DateGameReturn.Pending(CareerStore.Data) != null) __result = DateGameReturn.AfterSummary(__result, __instance); }
}

public partial class CareerScreen
{
    internal static void ReturnToDate(NMainMenu menu)
    {
        var data = CareerStore.Data; var match = DateGameReturn.Pending(data);
        if (match?.DateGame is not { } game || !IsInstanceValid(menu) || !menu.IsInsideTree() || Current != null) return;
        var c = PrivateMessages.Conversation(data, game.Host);
        if (!c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c)))
        { game.ReturnPending = false; CareerStore.Save(data); return; }
        OpenView(menu, null, "通讯");
        if (Current is not { } screen) return;
        screen.OpenPrivateMessages(game.Host);
        screen.OpenDateSceneReady(game.OfferId, false, true, () =>
        {
            screen.StartDateGameReply(match, "result");
            Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = screen._dateView?.IsVisibleInTree() == true });
        });
    }
}
