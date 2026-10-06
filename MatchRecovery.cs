namespace NationalSpire;

/// <summary>恢复检查与档案列表使用不同范围；未结算比赛不能受最近战报数量限制。</summary>
public static class MatchRecovery
{
    public static IEnumerable<string> HistoryCandidates(IEnumerable<string> files, long pendingSince) => files
        .Where(file => pendingSince <= 0 || !long.TryParse(Path.GetFileNameWithoutExtension(file), out long time) || time >= pendingSince - 5)
        .OrderByDescending(file => file, StringComparer.Ordinal);

    public static string Message(bool multiplayer, bool hasSave, bool inProgress) => multiplayer
        ? "多人比赛进度由房主保存，请通过“全队继续比赛”恢复。"
        : inProgress ? "比赛仍在进行，请先返回当前对局。"
        : hasSave ? "比赛存档已找到，请返回主菜单继续对局。"
        : "当前游戏档案没有可继续的单人对局。可以重新检查；确认存档已丢失后，可取消失效比赛，不计失败。";
}
