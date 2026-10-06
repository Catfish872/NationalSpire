using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Managers;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using System.Reflection;

namespace NationalSpire.Coop;

public static class CoopSettings
{
    public static string Root => ProjectSettings.GlobalizePath("user://national_spire_coop");
    public static CoopStorage Storage => new(Path.Combine(Root, "worlds"));
    public static BroadcastUiState ReadLayout()
    { try { return CoopJson.Read<BroadcastUiState>(File.ReadAllBytes(Path.Combine(Root, "hud.json"))); } catch { return new(); } }
    public static void SaveLayout(BroadcastUiState layout)
    {
        try { Directory.CreateDirectory(Root); string path = Path.Combine(Root, "hud.json"); File.WriteAllBytes(path + ".tmp", CoopJson.Bytes(layout)); File.Move(path + ".tmp", path, true); }
        catch (Exception e) { Diagnostics.Error("coop.hud.layout", e); }
    }
}

/// <summary>暂停流程的场景操作与联机状态分开，允许用真实后端验证异步退出流程。</summary>
public interface ICoopPauseScene
{
    bool NeedsReturn { get; }
    Task ReturnToMenu();
    Task Reveal();
}
public sealed class CoopGamePauseScene : ICoopPauseScene
{
    public bool NeedsReturn => NGame.Instance is { } game && (RunManager.Instance.IsInProgress || game.MainMenu == null);
    public Task ReturnToMenu() => NGame.Instance!.ReturnToMainMenu();
    public async Task Reveal() { if (NGame.Instance is { } game) await game.Transition.FadeIn(.2f); }
}

public partial class CoopRuntime : Node
{
    public static CoopRuntime? Current { get; private set; }
    public CoopCoordinator? Session { get; private set; }
    public CoopNativeRun? Native { get; private set; }
    public CoopAi? Ai { get; private set; }
    public string Status { get; private set; } = "";
    public string InviteCode { get; private set; } = "";
    private CoopSteam? _connecting;
    private bool _busy, _pausing;
    private Task? _pauseTask;
    private string _completedPause = "";
    public ICoopPauseScene PauseScene { get; set; } = new CoopGamePauseScene();
    public bool Pausing => _pausing;
    private int _connectionGeneration;
    private double _liveTick;
    private CoopLive? _live;
    public Task? MenuReturn { get; set; }
    public bool ReturningToMenu => MenuReturn is { IsCompleted: false };
    public static bool Bound => Current?.Session?.World != null;
    public static CoopRuntime Ensure()
    {
        if (Current != null && IsInstanceValid(Current)) return Current;
        var runtime = new CoopRuntime { Name = "NationalSpireCooperative" };
        ((SceneTree)Engine.GetMainLoop()).Root.CallDeferred(Node.MethodName.AddChild, runtime); Current = runtime; return runtime;
    }
    public static string Compatibility => CoopContentIdentity.Create(Diagnostics.ModVersion, ModelIdSerializationCache.Hash,
        MegaCrit.Sts2.Core.Modding.ModManager.GetNonGameplayRelevantModNameList());
    public async Task Connect(bool host, string name, string worldName = "共同生涯", int capacity = 2, string country = "中国", string code = "", string savedId = "")
    {
        if (_busy || _pausing || Session != null || RunManager.Instance.IsInProgress) throw new InvalidOperationException("请先退出当前房间或对局。");
        if (CoopCompatibility.Check() is { } compatibilityError) throw new InvalidOperationException(compatibilityError);
        _busy = true;
        int generation = ++_connectionGeneration;
        try
        {
            _connecting = new CoopSteam();
            CoopStorage.Checkpoint? checkpoint = null;
            if (host)
            {
                checkpoint = savedId.Length > 0 ? CoopSettings.Storage.Load(savedId) : new(CoopRules.Create(_connecting.Self, worldName, name, capacity, country), null);
                if (checkpoint.World.Owner != _connecting.Self) throw new InvalidOperationException("这个检查点属于另一名主机。");
                if (checkpoint.World.Run is { Terminal: null } savedRun) savedRun.Phase = "paused";
                checkpoint.World.CareerStarted |= checkpoint.World.RosterLocked || checkpoint.World.World.Day > 1;
                checkpoint.World.World.Ai.Enabled = AiSettingsStore.Load(new()).Enabled;
                await _connecting.Host(checkpoint.World.Capacity);
            }
            else await _connecting.Join(code);
            if (generation != _connectionGeneration) throw new OperationCanceledException("已取消连接。");
            InviteCode = _connecting.Code;
            Session = new(_connecting, CoopSettings.Storage, Compatibility, _connecting.Token, name, GameBridge.Characters().Select(c => c.Id.ToString()).ToHashSet(), checkpoint);
            _connecting = null; Native = new(Session); Ai = new(Session);
            Session.CaptureDiagnostics = () => Diagnostics.CapturePeerLogs(ProjectSettings.GlobalizePath("user://logs"), Native?.Status ?? Status, Session.World?.World.WorldId);
            _resumeRequired = Session.World?.Run != null; _pausedCount = Session.World?.Run?.ResumeCount ?? 0;
            Session.RunMessage += Native.Message;
            Session.TriggerAi += kind => { if (kind is "confirm" or "post" or "reply" or "dm-confirm" or "dm-arbitration-apology") _ = Ai.Process(); };
            _live = new(Session); Status = "房间已连接";
            if (host && checkpoint?.World.CareerStarted == true) _ = Ai.Process();
        }
        catch { _connecting?.Dispose(); _connecting = null; throw; }
        finally { _busy = false; }
    }
    public void CancelConnection()
    {
        _connectionGeneration++; _connecting?.Dispose(); _connecting = null;
    }
    public override void _Process(double delta)
    {
        try
        {
            Session?.Tick();
            if (Session == null) return;
            // 等待转场结束时仍处理大厅通信，但不触发新的开赛和界面更新。
            if (_pausing) { Native?.PumpPendingNetwork(); return; }
            if (Session.World?.Run == null) _resumeRequired = false;
            if (Session.Host && Session.Full && Session.World?.Run?.Terminal != null) FinishTerminal();
            if (_resumeRequired && (Session.World?.Run?.ResumeCount ?? 0) > _pausedCount) _resumeRequired = false;
            if (Session.World?.Run is { Phase: "paused" } paused)
            {
                _resumeRequired = true; _pausedCount = paused.ResumeCount;
                if (Native?.HasConnection == true) { _ = Pause(); return; }
            }
            if (!ReturningToMenu) Native?.Update();
            if (Session.World?.Proposal != null && !RunManager.Instance.IsInProgress && !ReturningToMenu &&
                Native?.Entering != true && NGame.Instance?.MainMenu is { } menu && CareerScreen.Current == null && CoopScreen.Current == null)
                CoopScreen.OpenCareerOrRoom(menu);
            if (Session.World?.Run is { Terminal: null } && !_pausing && (Native?.NeedsPause == true || Native?.Launched == true && !RunManager.Instance.IsInProgress)) { _ = Pause(); return; }
            _liveTick += delta;
            if (_liveTick >= 1) { _liveTick = 0; _live?.Update(); }
        }
        catch (Exception e) { Status = e.Message; Diagnostics.Error("coop.runtime", e); }
    }
    public Task Pause()
    {
        if (_pauseTask is { IsCompleted: false }) return _pauseTask;
        if (Session == null) return Task.CompletedTask;
        var run = Session.World?.Run;
        string key = $"{Session.World?.Epoch}/{run?.Attempt}/{run?.ResumeCount}";
        if (_completedPause == key && Native?.HasConnection != true && !PauseScene.NeedsReturn) return Task.CompletedTask;
        return _pauseTask = PauseCore(key);
    }
    private async Task PauseCore(string key)
    {
        _pausing = true;
        var session = Session!;
        var native = Native;
        _resumeRequired = session.World?.Run != null;
        _pausedCount = session.World?.Run?.ResumeCount ?? 0;
        try
        {
            // 中途退出恢复最近一次原版安全检查点，不能用半个战斗状态覆盖它。
            if (session.World?.Run is { Terminal: null } run)
            {
                if (session.Host && run.Phase != "paused")
                {
                    var paused = CoopJson.Copy(session.World); paused.Run!.Phase = "paused"; paused.Run.FailureReason = native?.LastError ?? ""; paused.Proposal = null; paused.Revision++;
                    session.Commit(paused, session.NativeSave);
                    session.SendRun("run-return", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount });
                }
                else if (!session.Host && run.Phase != "paused" && native?.PauseRequestedByHost != true)
                {
                    // 只有客机主动退出或检测到断线时请求暂停；执行房主通知不得回送请求。
                    session.SendRun("run-pause", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount });
                }
                Diagnostics.Record("coop.pause.begin", new { session.Host, run.Attempt, run.ResumeCount, run.Phase, remote = native?.PauseRequestedByHost });
                Diagnostics.RecordMatch(session.World!, "pause", new { session.Host, remote = native?.PauseRequestedByHost }, includePlan: true);
            }
            await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
            native?.StopConnection();
            // 对端已经离线时不能无限等待。中断通信后给原版加载任务时间退出。
            if (native != null)
            {
                try { await native.WaitForEntry().WaitAsync(TimeSpan.FromSeconds(8)); }
                catch (TimeoutException e) { Diagnostics.Error("coop.pause.entry-timeout", e); }
            }
            if (MenuReturn is { IsCompleted: false } returning) await returning.WaitAsync(TimeSpan.FromSeconds(30));
            else if (PauseScene.NeedsReturn) await PauseScene.ReturnToMenu();
            Status = native?.LastError.Length > 0 ? "比赛连接失败：" + native.LastError : "比赛已暂停。全员返回后可从最近检查点继续。";
        }
        catch (Exception e) { Status = "暂停转场失败，最近检查点仍保留。请退出游戏后恢复：" + e.Message; Diagnostics.Error("coop.pause", e); }
        finally
        {
            native?.Close(); _live?.Close();
            try { await PauseScene.Reveal(); }
            catch (Exception e) { Diagnostics.Error("coop.pause.fade-in", e); }
            finally { _completedPause = key; _pausing = false; Diagnostics.Record("coop.pause.end", new { key }); }
        }
    }
    private bool _resumeRequired;
    private int _pausedCount;
    public bool ResumeRequired => _resumeRequired;
    public void Disconnect()
    {
        if (RunManager.Instance.IsInProgress || Native?.Entering == true) throw new InvalidOperationException("请先完成转场并保存退出当前对局。");
        Ai?.Stop(); Native?.Close(); _live?.Close(); Session?.Dispose(); Session = null; Native = null; Ai = null; _live = null;
        InviteCode = ""; _resumeRequired = false;
    }
    public void Complete(RunHistory history)
    {
        if (Session?.World?.Run is not { } run || history.Seed != run.Seed || history.Ascension != run.Ascension) return;
        if (!history.Players.Select(p => p.Id).Order().SequenceEqual(run.Characters.Keys.Order())) return;
        if (history.WasAbandoned && (_pausing || _resumeRequired || run.Phase == "paused" || !Session.Full || Native?.NeedsPause == true))
        { Status = "比赛已暂停，等待全队恢复后继续。"; return; }
        Diagnostics.RecordMatch(Session.World, "native-completed", new
        {
            Session.Host, history.Win, history.WasAbandoned, history.RunTime,
            route = history.MapPointHistory.Select((act, index) => new
            {
                act = index, steps = act.Select(point => new
                {
                    kind = point.MapPointType.ToString(),
                    rooms = point.Rooms.Select(room => new { kind = room.RoomType.ToString(), model = room.ModelId?.ToString(), room.TurnsTaken }),
                    players = point.PlayerStats.Select(p => new { p.PlayerId, p.CurrentHp, p.MaxHp, p.DamageTaken, p.HpHealed })
                })
            })
        }, includePlan: true);
        if (!Session.Host) return;
        var details = history.Players.ToDictionary(p => p.Id, p => GameBridge.ReadPlayerHistory(history, p));
        var players = history.Players.Select(p =>
        {
            var evidence = details[p.Id].Evidence;
            return new CoopLivePlayer(p.Id, p.Character.ToString(), evidence.FinalHp ?? 0, evidence.MaxHp ?? 0, evidence.FinalHp == 0);
        }).ToList();
        var recorded = CoopJson.Copy(Session.World);
        recorded.Run!.Terminal = new(history.Win && !history.WasAbandoned, history.MapPointHistory.Sum(a => a.Count), history.RunTime, players) { Details = details };
        recorded.Revision++;
        Session.Commit(recorded, Session.NativeSave);
        if (Session.Full) FinishTerminal();
        else Status = "比赛结果已保存，队员全部返回后统一结算。";
    }
    private void FinishTerminal()
    {
        if (Session?.World?.Run is not { Terminal: { } result } run || !Session.Host || !Session.Full) return;
        var next = CoopRules.Settle(Session.World, run.Attempt, result.Win, false, result.Floor, result.Seconds, result.Players, result.Details);
        Session.Commit(next, null); _ = Ai!.Process(); Status = "比赛已经结算";
    }
}

[HarmonyPatch(typeof(NMainMenu), "_Ready")]
public static class CoopMenuPatch
{
    public static void Postfix(NMainMenu __instance)
    {
        var button = new Button { Text = "国运尖塔：多人模式", Theme = CareerVisuals.CreateTheme() };
        __instance.AddChild(button); button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.BottomLeft);
        button.OffsetLeft = 40; button.OffsetRight = 350; button.OffsetTop = -178; button.OffsetBottom = -114;
        button.Pressed += () => CoopScreen.Open(__instance);
        if (CoopRuntime.Bound) Callable.From(() => CoopScreen.OpenCareerOrRoom(__instance)).CallDeferred();
    }
}
[HarmonyPatch(typeof(ActiveScreenContext), nameof(ActiveScreenContext.GetCurrentScreen))]
public static class CoopContextPatch
{ public static void Postfix(ref IScreenContext? __result) { if (__result is NMainMenu && CoopScreen.Current != null) __result = CoopScreen.Current; } }

[HarmonyPatch(typeof(RunSaveManager), nameof(RunSaveManager.GetRunSavePath))]
public static class CoopPathPatch
{
    public static void Postfix(string fileName, ref string __result)
    {
        if (CoopRuntime.Bound && fileName.StartsWith("current_run_mp", StringComparison.Ordinal))
            __result = "national_spire_coop_native/" + CoopRuntime.Current!.Session!.World!.Id + "/" + Path.GetFileName(fileName);
    }
}
[HarmonyPatch]
public static class CoopSavePatch
{
    public static MethodBase TargetMethod() => AccessTools.Method(typeof(RunSaveManager), nameof(RunSaveManager.SaveRun), [typeof(SerializableRun), typeof(bool)]);
    public static bool Prefix(SerializableRun save, bool isMultiplayer, ref Task __result)
    {
        if (!isMultiplayer || !CoopRuntime.Bound) return true;
        try { CoopRuntime.Current!.Native!.Save(save); __result = Task.CompletedTask; }
        catch (Exception e) { Diagnostics.Error("coop.checkpoint", e); __result = Task.FromException(e); }
        return false;
    }
}
[HarmonyPatch(typeof(SaveManager), nameof(SaveManager.SaveRunHistory))]
public static class CoopHistoryPatch
{
    public static bool Prefix(RunHistory history)
    {
        if (!CoopRuntime.Bound) return true;
        try { CoopRuntime.Current!.Complete(history); } catch (Exception e) { Diagnostics.Error("coop.settlement", e); }
        return false;
    }
}

// 原版“保存并退出”正在切换场景时，暂停流程等待同一次切换，避免重入。
[HarmonyPatch(typeof(NGame), nameof(NGame.ReturnToMainMenu))]
public static class CoopReturnPatch
{
    public static void Postfix(Task __result)
    { if (CoopRuntime.Bound) CoopRuntime.Current!.MenuReturn = __result; }
}

// 原版断线弹窗流程也会返回主菜单。共同生涯统一交给暂停流程，避免重复转场和遮挡操作的断线弹窗。
[HarmonyPatch(typeof(RunManager), "ReturnToMainMenuWithError")]
public static class CoopDisconnectMenuPatch
{
    public static bool Prefix(RunManager __instance, ref Task __result)
    {
        var runtime = CoopRuntime.Current;
        if (runtime?.Session?.World?.Run == null || runtime.Native?.OwnsConnection(__instance.NetService) != true) return true;
        __result = runtime.Pause();
        return false;
    }
}
