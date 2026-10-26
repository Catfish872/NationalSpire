using System.Diagnostics;
using System.Reflection;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Nodes;

namespace NationalSpire;

/// <summary>跟随整个开局任务存活的加载提示；超时只提示，原生任务仍由调用者等待。</summary>
public partial class MatchStartWatch : CanvasLayer
{
    private const double NoticeSeconds = 30;
    private static MatchStartWatch? _active;
    private readonly Stopwatch _clock = Stopwatch.StartNew();
    private string _match = "", _stage = "准备开局";
    private readonly Dictionary<Task, string> _loads = [];
    private Func<bool> _hasSave = () => false;
    private Action _quit = () => { };
    private Control? _panel;
    private Label? _detail;
    private double _nextNotice = NoticeSeconds, _refreshAt;
    private bool _finished;
    public static bool IsActive => _active is { _finished: false } watch && IsInstanceValid(watch);

    public static MatchStartWatch Begin(Node parent, string match, Func<bool> hasSave, Action quit)
    {
        if (IsActive) throw new InvalidOperationException("已有一场对局正在加载，请等待加载完成。");
        var watch = new MatchStartWatch { Name = "NationalSpireMatchLoading", Layer = 1024,
            ProcessMode = ProcessModeEnum.Always, _match = match, _hasSave = hasSave, _quit = quit };
        parent.AddChild(watch);
        _active = watch;
        return watch;
    }

    public void Stage(string stage)
    {
        if (_finished) return;
        _stage = stage;
        Diagnostics.Record("match.loading.stage", new { match = _match, stage, elapsedMs = _clock.ElapsedMilliseconds });
    }

    // 补丁仅观察本模组开局期间的原生加载，保持任务的结果、异常和完成顺序。
    internal static Task Observe(Task original, string stage)
    {
        if (!IsActive) return original;
        return _active!.ObserveLoad(original, stage);
    }
    private async Task ObserveLoad(Task original, string stage)
    {
        _loads[original] = stage;
        long started = _clock.ElapsedMilliseconds;
        Diagnostics.Record("match.loading.assets", new { match = _match, stage, elapsedMs = started });
        try { await original; }
        catch (Exception error) { Diagnostics.Error("match.loading.assets.failure:" + stage, error); throw; }
        finally
        {
            _loads.Remove(original);
            Diagnostics.Record("match.loading.assets.finished", new { match = _match, stage, status = original.Status.ToString(), milliseconds = _clock.ElapsedMilliseconds - started });
        }
    }

    public override void _Process(double delta)
    {
        if (_finished) return;
        double seconds = _clock.Elapsed.TotalSeconds;
        if (_panel == null && seconds >= _nextNotice) ShowNotice();
        if (_detail != null && seconds >= _refreshAt) { _refreshAt = seconds + 1; RefreshDetail(); }
    }
    private string CurrentStage => _loads.Values.LastOrDefault() ?? _stage;
    private bool HasSavedRun()
    {
        try { return _hasSave(); }
        catch (Exception error) { Diagnostics.Error("match.loading.save_status", error); return false; }
    }
    private void ShowNotice()
    {
        bool saved = HasSavedRun();
        Diagnostics.Record("match.loading.slow", new { match = _match, stage = CurrentStage, elapsedMs = _clock.ElapsedMilliseconds,
            hasRunSave = saved, loads = _loads.Select(p => new { stage = p.Value, status = p.Key.Status.ToString() }).ToArray(),
            nativeAssets = GameCompatibility.AssetLoadingStatus(),
            build = typeof(GameBridge).Assembly.ManifestModule.ModuleVersionId });
        _panel = new Control { Name = "LoadingNotice", Theme = CareerVisuals.CreateTheme(), MouseFilter = Control.MouseFilterEnum.Stop };
        AddChild(_panel); _panel.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var shade = new ColorRect { Color = new Color(0, 0, 0, .8f), MouseFilter = Control.MouseFilterEnum.Ignore };
        _panel.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var margin = new MarginContainer(); _panel.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 24);
        var center = new CenterContainer(); margin.AddChild(center);
        var box = new PanelContainer { CustomMinimumSize = new Vector2(520, 0) }; center.AddChild(box);
        box.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182b3b", "789aa4", 12, 24));
        var column = new VBoxContainer(); box.AddChild(column);
        var title = new Label { Text = "对局加载时间较长" }; title.AddThemeFontSizeOverride("font_size", 25);
        title.AddThemeColorOverride("font_color", CareerVisuals.Gold); column.AddChild(title);
        _detail = new Label { CustomMinimumSize = new Vector2(470, 0) }; column.AddChild(_detail);
        var buttons = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; column.AddChild(buttons);
        var wait = new Button { Text = "继续等待", CustomMinimumSize = new Vector2(150, 48), Name = "KeepWaiting" };
        var quit = new Button { Text = "退出游戏", CustomMinimumSize = new Vector2(150, 48), Name = "QuitGame" };
        buttons.AddChild(wait); buttons.AddChild(quit);
        wait.Pressed += () => { ClearNotice(); _nextNotice = _clock.Elapsed.TotalSeconds + NoticeSeconds; };
        quit.Pressed += () =>
        {
            try { Diagnostics.Record("match.loading.quit", new { match = _match, stage = CurrentStage, hasRunSave = HasSavedRun() }); _quit(); }
            catch (Exception error) { Diagnostics.Error("match.loading.quit.failure", error); _detail!.Text = "退出游戏时出现异常：\n" + Diagnostics.Redact(error.GetBaseException().Message); }
        };
        RefreshDetail(); wait.GrabFocus();
    }
    private void RefreshDetail()
    {
        if (_detail == null) return;
        _detail.Text = $"正在等待：{CurrentStage}\n开局已用时 {(int)_clock.Elapsed.TotalSeconds} 秒。\n\n"
            + "可以继续等待，或退出游戏后重新进入。\n"
            + (HasSavedRun() ? "对局已保存；重启后可从主菜单继续游戏。" : "生涯资料已保留；原版对局尚未完成保存。")
            + "\n加载阶段已记录到诊断日志。";
    }
    private void ClearNotice()
    {
        _detail = null;
        if (_panel != null) { _panel.Hide(); _panel.QueueFree(); _panel = null; }
    }
    public void Finish()
    {
        if (_finished) return;
        _finished = true;
        if (_active == this) _active = null;
        ClearNotice(); QueueFree();
    }
    public override void _ExitTree() { _finished = true; if (_active == this) _active = null; }
}

[HarmonyPatch]
public static class MatchStartLoadPatch
{
    public static IEnumerable<MethodBase> TargetMethods()
    {
        foreach (string name in new[] { "LoadRunAssets", "LoadActAssets", "LoadRoomAssets", "LoadCommonAndMainMenuAssets" })
            if (AccessTools.Method(typeof(PreloadManager), name) is { ReturnType: var type } method && type == typeof(Task)) yield return method;
    }
    public static void Postfix(MethodBase __originalMethod, ref Task __result)
    {
        string stage = __originalMethod.Name switch
        {
            "LoadRunAssets" => "角色资源", "LoadActAssets" => "章节资源", "LoadRoomAssets" => "房间资源",
            _ => "主菜单资源"
        };
        __result = MatchStartWatch.Observe(__result, stage);
    }
}
