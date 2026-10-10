namespace NationalSpire;

/// <summary>共用生涯界面的多人上下文；显示个人视图，操作交给主机，绝不替换单人全局存档。</summary>
public interface ICareerSession : IDisposable
{
    CareerData Data { get; }
    bool Host { get; }
    bool Alive { get; }
    string Status { get; }
    string ProposalId { get; }
    IReadOnlyList<CareerTeamMember> Team { get; }
    IReadOnlyList<string> Opponents(CareerMatch match);
    string ProposalText { get; }
    bool HasVoted { get; }
    bool Refresh();
    event Action<string, bool>? Message;
    void Send(string kind, string target = "", string text = "", int number = 0, string parent = "", Action? accepted = null);
    void SaveAi(CareerData data);
    void Generate(bool retry = false);
    void OpenRoom();
    string RunStatus { get; }
    bool CanResume { get; }
    Task<string> Export();
}

public sealed record CareerTeamMember(string Id, string Name, string Character, string Detail);

public partial class CareerScreen
{
    private void ShowDiagnosticFile(string path)
    {
        var result = Godot.OS.ShellShowInFileManager(path);
        if (Godot.GodotObject.IsInstanceValid(this))
            Notice(result == Godot.Error.Ok ? "问题报告已导出，文件夹已打开。" : "报告已保存，文件夹未能打开：" + path, false);
    }
    private void AddMultiplayerReportButton(Godot.VBoxContainer box)
    {
        var session = _multiplayer!;
        Godot.Button? button = null;
        button = Button(session.Host ? "导出全队问题报告" : "导出本机问题报告", async () =>
        {
            if (button == null || button.Disabled) return;
            button.Disabled = true; button.Text = session.Host ? "正在收集队友日志…" : "正在导出…";
            try { ShowDiagnosticFile(await session.Export()); }
            catch (Exception e) { if (Godot.GodotObject.IsInstanceValid(this)) Notice("报告导出失败：" + e.Message, true); }
            finally { if (Godot.GodotObject.IsInstanceValid(button)) { button.Disabled = false; button.Text = session.Host ? "导出全队问题报告" : "导出本机问题报告"; } }
        }, 280);
        box.AddChild(button);
    }
    private ICareerSession? _multiplayer;
    private CareerData ViewData => _multiplayer?.Data ?? _boundData ?? CareerStore.Data;
    private bool MultiplayerCommand(string kind, string target = "", string text = "", int number = 0, string parent = "", Action? accepted = null)
    {
        if (_multiplayer == null) return false;
        _multiplayer.Send(kind, target, text, number, parent, accepted); return true;
    }
    private Godot.Button TeamButton(string text, Action action, int width = 180)
    {
        var button = Button(text, action, width);
        if (_multiplayer is { Host: false }) { button.Disabled = true; button.TooltipText = "由房主操作。"; }
        return button;
    }
    private void SaveAiSettings(CareerData data)
    { if (_multiplayer != null) _multiplayer.SaveAi(data); else { WeeklyJournal.ActivateLatest(data); CareerStore.Save(data); } }
    private void GenerateContent(Action single, bool retry = false)
    { if (_multiplayer != null) _multiplayer.Generate(retry); else single(); }
    private void RenderTeam()
    {
        if (_multiplayer == null) return;
        var card = Card(); _content.AddChild(card); var box = Inner(card);
        box.AddChild(Text(_tab == "结算" ? "本场队员" : "我方阵容 · 全员共同出战", 22, _gold));
        var grid = new Godot.GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 20); grid.AddThemeConstantOverride("v_separation", 12); box.AddChild(grid);
        foreach (var member in _multiplayer.Team)
            grid.AddChild(WithAvatar(ViewData, member.Id, Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink), 54, true));
    }
    public static void CloseCurrent() => Current?.Close();
}
