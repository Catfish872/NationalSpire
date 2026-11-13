using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace NationalSpire;

/// <summary>从约会继续原版未结束的对局，核对当前生涯保存的比赛。</summary>
public static class DateGameReturn
{
    internal static CareerMatch? SavedMatch(CareerData data, string host, string offer, SerializableRun saved)
    {
        var match = DateGames.InProgress(data, host, offer);
        return match != null && CareerRunBinding.Find(data, saved.SerializableRng?.Seed ?? "",
            saved.Players?.FirstOrDefault()?.CharacterId?.ToString() ?? "", saved.Ascension,
            saved.Players?.Count ?? 0, saved.GameMode.ToString(), saved.StartTime)?.Id == match.Id ? match : null;
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
}

public partial class CareerScreen
{
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
