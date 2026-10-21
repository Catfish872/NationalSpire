using Godot;

namespace NationalSpire;

public partial class EventStoryView
{
    public Action<string>? Custom;
    public Action? ConfirmCustom;
    public string CustomInputText => _customInput?.Text ?? "";
    private VBoxContainer _custom = null!, _customEditor = null!, _customEffects = null!;
    private EventStoryButton _customEntry = null!;
    private TextEdit _customInput = null!;
    private RichTextLabel _customResult = null!;
    private Label _customPhase = null!;
    private Button _customGenerate = null!, _customConfirm = null!, _customBack = null!;
    private bool _customExpanded;
    private string _customId = "", _customPreview = "";
    private RandomEventOption? _customEffectsOption;
    private void BuildCustomAction(VBoxContainer parent)
    {
        _custom = new VBoxContainer(); _custom.AddThemeConstantOverride("separation", 12); parent.AddChild(_custom);
        _customEntry = new EventStoryButton { Name = "CustomEventAction", Caption = "写下你的行动", Detail = "用自己的选择，为故事写下另一种结局", Mark = "+" };
        _custom.AddChild(_customEntry);
        var panel = new PanelContainer(); panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1b303edc", "779c9a", 9, 18)); _custom.AddChild(panel);
        _customEditor = new VBoxContainer(); _customEditor.AddThemeConstantOverride("separation", 12); panel.AddChild(_customEditor);
        _customEditor.AddChild(Words("你的行动", 16, Gold));
        _customInput = new TextEdit { Name = "CustomEventInput", PlaceholderText = "你准备怎么做？", CustomMinimumSize = new(0, 112), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        _customInput.AddThemeFontSizeOverride("font_size", 19); _customInput.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0e202d", "456374", 6, 12)); _customEditor.AddChild(_customInput);
        _customPhase = Words("", 14, CareerVisuals.Teal); _customEditor.AddChild(_customPhase);
        _customResult = Rich(20); _customResult.Name = "CustomEventResult"; _customEditor.AddChild(_customResult);
        _customEffects = new VBoxContainer { Name = "CustomEventEffects" }; _customEffects.AddThemeConstantOverride("separation", 10); _customEditor.AddChild(_customEffects);
        var actions = new HFlowContainer(); actions.AddThemeConstantOverride("h_separation", 10); actions.AddThemeConstantOverride("v_separation", 8); _customEditor.AddChild(actions);
        _customBack = ActionButton("返回原选项", () => { _customExpanded = false; panel.Hide(); _customEntry.Show(); _options.Show(); }); _customBack.Name = "CustomEventBack"; actions.AddChild(_customBack);
        _customGenerate = ActionButton("生成行动结局", () => Custom?.Invoke(_customInput.Text)); _customGenerate.Name = "CustomEventGenerate"; actions.AddChild(_customGenerate);
        _customConfirm = ActionButton("确认这个结局", () => ConfirmCustom?.Invoke()); _customConfirm.Name = "CustomEventConfirm";
        _customConfirm.AddThemeStyleboxOverride("normal", CareerVisuals.Box("ceb782", "f0dca7", 7, 12)); _customConfirm.AddThemeColorOverride("font_color", new("152635")); actions.AddChild(_customConfirm);
        _customEntry.Pressed += () => { _customExpanded = true; panel.Show(); _customEntry.Hide(); _options.Hide(); _customInput.GrabFocus(); };
        _customInput.TextChanged += () => { _customConfirm.Visible = false; _customGenerate.Disabled = _customInput.Text.Trim().Length == 0; Tick?.Invoke(); };
        panel.Hide();
    }
    private void DisplayCustom(CareerData d, RandomEventRecord e, EventLive? live, bool busy)
    {
        _custom.Visible = e.State == "ready";
        if (_customId != e.Id)
        {
            _customId = e.Id; _customInput.Text = e.CustomAction; _customExpanded = e.CustomAction.Length > 0; _customPreview = "";
        }
        bool generating = e.CustomState == "generating";
        _customExpanded |= generating;
        _options.Visible = !_customExpanded && e.State != "complete";
        _customEntry.Visible = !_customExpanded; _customEntry.Disabled = busy;
        ((Control)_customEditor.GetParent()).Visible = _customExpanded;
        _customInput.Editable = !busy; _customBack.Disabled = busy;
        _customGenerate.Disabled = busy || _customInput.Text.Trim().Length == 0;
        _customGenerate.Text = e.CustomAction.Length > 0 && e.CustomAction == _customInput.Text.Trim() ? "重新生成结局" : "生成行动结局";
        var option = e.CustomState == "ready" && e.CustomAction == _customInput.Text.Trim() ? e.CustomOption : null;
        string result = generating ? live?.Story ?? "" : option?.Result ?? "";
        _customResult.Visible = result.Length > 0;
        if (result != _customPreview) { _customPreview = result; SetText(_customResult, result); }
        // 正文可能先于完整效果抵达，效果预览按解析完成的选项单独刷新。
        if (!ReferenceEquals(option, _customEffectsOption)) { _customEffectsOption = option; ShowResultEffects(d, option ?? new(), _customEffects); }
        string? error = option == null ? null : RandomEventEffects.Check(d, e, option);
        _customPhase.Text = generating ? live?.Phase ?? "正在准备行动结局" : error ?? (option != null ? "结局预览 · 确认后登记本次经历与效果" : "写下行动，看看故事如何结束");
        _customConfirm.Visible = option != null && !busy; _customConfirm.Disabled = error != null;
    }
}
