using Godot;

namespace NationalSpire;

/// <summary>模组设置与聊天快捷入口共用的任务方案卡片。</summary>
public partial class AiTaskRoutePicker : PanelContainer
{
    private AiOptions _options = null!;
    private string _task = "";
    private OptionButton _choice = null!;
    private Label _model = null!;
    private bool _refreshing;

    public void Configure(AiOptions options, string task, Action save, Action<string, bool> notice)
    {
        _options = options; _task = AiRouting.Category(task);
        Name = "AiTaskRoute_" + _task;
        AddThemeStyleboxOverride("panel", CareerVisuals.Box("172f3c", "345363", 7, 12));
        var row = new VBoxContainer(); row.AddThemeConstantOverride("separation", 5); AddChild(row);
        var title = new Label { Text = AiRouting.Tasks.First(t => t.Id == _task).Name };
        title.AddThemeFontSizeOverride("font_size", 18); row.AddChild(title);
        _choice = new OptionButton { Name = "AiRoute_" + _task, FitToLongestItem = false, ClipText = true,
            TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis,
            CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        row.AddChild(_choice);
        _model = new Label { Name = "AiRouteModel", AutowrapMode = TextServer.AutowrapMode.WordSmart };
        _model.AddThemeFontSizeOverride("font_size", 14); _model.AddThemeColorOverride("font_color", CareerVisuals.Muted); row.AddChild(_model);
        _choice.ItemSelected += index =>
        {
            if (_refreshing) return;
            try { AiRouting.Assign(_options, _task, _choice.GetItemMetadata((int)index).AsString(), save); notice("已保存，下次请求使用所选方案。", false); }
            catch (Exception e) { notice("设置未能保存：" + e.Message, true); }
            Refresh();
        };
        Refresh();
    }

    public void Refresh()
    {
        _refreshing = true;
        _choice.Clear(); string assigned = AiRouting.ProfileId(_options, _task); int i = 0;
        foreach (var entry in _options.ConnectionProfiles)
        {
            _choice.AddItem(entry.Value.Name); _choice.SetItemMetadata(i, entry.Key);
            if (entry.Key == assigned) _choice.Select(i);
            i++;
        }
        _model.Text = _options.ConnectionProfiles[assigned].Model;
        _choice.TooltipText = _options.ConnectionProfiles[assigned].Name;
        _refreshing = false;
    }
}
