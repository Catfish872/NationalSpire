using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace NationalSpire;

/// <summary>等待原版结算和解锁写入后回到原约会；返回标记支持重载后恢复。</summary>
public static class DateGameReturn
{
    private static int _returning;
    private static WeakReference<CareerData>? _finishedData;
    private static string _finishedId = "";
    internal static void RecordBoundHistory(CareerData d, CareerMatch match)
    {
        if (d.PendingSettlementId!=match.Id && d.Failure?.Result.MatchId!=match.Id) return;
        _finishedData = new(d); _finishedId = match.Id;
    }
    private static string RecordedId(CareerData d) =>
        _finishedData?.TryGetTarget(out var origin) == true && ReferenceEquals(origin, d) &&
        (_finishedId == d.PendingSettlementId || _finishedId == d.Failure?.Result.MatchId) ? _finishedId : "";

    internal static string ReturnId(CareerData d)
    {
        string id = RecordedId(d);
        // When leaving a live run only its own history can claim the menu. At startup a saved date may resume.
        return id.Length > 0 || Transitioning ? id : Pending(d)?.Id ?? "";
    }
    internal static void Opened() { _finishedData = null; _finishedId = ""; }
    internal static bool Transitioning => _returning > 0;
    internal static void BeginFinalReturn() => _returning++;
    internal static void EndFinalReturn() => _returning--;
    internal static async Task AfterMainMenu(Task original, NGame game)
    {
        try
        {
            await original;
            // A newly mounted menu is handled in _Ready, inside the native transition. Also cover a reused menu.
            try
            {
                if (!Coop.CoopRuntime.Bound && GodotObject.IsInstanceValid(game) && game.IsInsideTree() && game.MainMenu is { } menu)
                    CareerScreen.ReturnToDate(menu);
            }
            catch (Exception e) { Diagnostics.Error("match.return.menu", e); }
        }
        finally { EndFinalReturn(); }
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
}

// This is the native final return action, after the player's game-over screens and unlocks.
[HarmonyPatch(typeof(NGame), nameof(NGame.ReturnToMainMenuAfterRun))]
public static class DateGameMenuReturnPatch
{
    public static void Prefix() => DateGameReturn.BeginFinalReturn();
    public static void Postfix(NGame __instance, ref Task __result) => __result = DateGameReturn.AfterMainMenu(__result, __instance);
    public static void Finalizer(Exception? __exception)
    {
        if (__exception != null) DateGameReturn.EndFinalReturn();
    }
}

public partial class CareerScreen
{
    internal static void ReturnToDate(NMainMenu menu)
    {
        var data=CareerStore.Data; string id=DateGameReturn.ReturnId(data);
        if (id.Length==0 || !IsInstanceValid(menu) || !menu.IsInsideTree() || Current!=null) return;
        OpenCareerView(menu, null, "结算", id);
        if (Current != null) DateGameReturn.Opened();
    }
    private bool ResumeSettledDate(CareerData data, CareerMatch match)
    {
        var game=match.DateGame!;
        var c = PrivateMessages.Conversation(data, game.Host);
        if (!c.Offers.Any(o => o.Id == game.OfferId && DateScenes.Available(data, o, c)))
        { game.ReturnPending=false; CareerStore.Save(data); return false; }
        _tab="赛事"; _reviewId=""; Render(); OpenPrivateMessages(game.Host);
        OpenDateSceneReady(game.OfferId, false, true, () =>
        {
            StartDateGameReply(match, "result");
            Diagnostics.Record("date.game.restored", new { match = match.Id, offer = game.OfferId, visible = _dateView?.IsVisibleInTree() == true });
        });
        return true;
    }
}
