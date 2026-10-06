using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private PromptTestSession? _promptTestSession;
    private Action? _closePromptTest;

    private void OpenPromptTest(CareerData data, Control editor, Dictionary<string, string> drafts, string section)
    {
        if (_closePromptTest != null) return;
        editor.Hide();
        var shade = new ColorRect { Name = "PromptTest", Color = new Color(0, 0, 0, .85f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 30 };
        _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 45);
        var panel = Card(); margin.AddChild(panel); var box = Inner(panel);
        box.AddChild(Text("提示词试写", 28, _gold));
        box.AddChild(Text("使用当前编辑。每次试写调用一次 AI，仅在这里预览，保留前后两次结果供比较。", 17, _muted));
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);
        var scenes = new[] { "news", "discussion", "profiles", "weekly" };
        var sceneNames = new[] { "自动发帖", "玩家帖子与回复", "选手介绍", "双周刊" };
        var sceneChoice = new OptionButton { Name = "PromptTestScene", CustomMinimumSize = new Vector2(250, 48) };
        for (int i = 0; i < scenes.Length; i++) sceneChoice.AddItem(sceneNames[i]);
        row.AddChild(sceneChoice);
        var sourceChoice = new OptionButton { Name = "PromptTestSource", SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis };
        row.AddChild(sourceChoice);
        var message = new TextEdit { Name = "PromptTestMessage", PlaceholderText = "填写要让社区回应的测试留言……", CustomMinimumSize = new Vector2(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary };
        message.AddThemeFontSizeOverride("font_size", 18); box.AddChild(message);
        var material = new TextEdit { Name = "PromptTestMaterial", Editable = false, Visible = false, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
        material.AddThemeFontSizeOverride("font_size", 16); box.AddChild(material);
        var compare = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; compare.AddThemeConstantOverride("separation", 16); box.AddChild(compare);
        TextEdit Preview(string title, string name)
        {
            var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; compare.AddChild(column); column.AddChild(Text(title, 18, _gold));
            var text = new TextEdit { Name = name, Editable = false, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
            text.AddThemeFontSizeOverride("font_size", 18); column.AddChild(text); return text;
        }
        var previous = Preview("上一次", "PromptTestPrevious"); var current = Preview("这一次", "PromptTestCurrent");
        var status = Text("", 16, CareerVisuals.Teal); box.AddChild(status);
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);
        List<PromptTestSource> sources = [];
        string scene = _promptTestSession?.Source.Scene ?? (scenes.Contains(section) ? section : "news");
        sceneChoice.Select(Array.IndexOf(scenes, scene));
        message.Text = _promptTestSession?.Message ?? "";
        bool showingMaterial = false;
        string localError = "";
        void ChooseSources()
        {
            sources = AiService.TestSources(data, scene); sourceChoice.Clear();
            foreach (var source in sources) sourceChoice.AddItem(source.Label);
            int remembered = sources.FindIndex(s => s == _promptTestSession?.Source);
            if (sources.Count > 0) sourceChoice.Select(Math.Max(0, remembered));
            else sourceChoice.AddItem("当前还没有可用材料");
            message.Visible = scene == "discussion";
        }
        PromptTestSession Prepare()
        {
            if (_promptTestSession?.Running == true) return _promptTestSession;
            if (sourceChoice.Selected < 0 || sourceChoice.Selected >= sources.Count) throw new ArgumentException("当前场景还没有可用材料，请选择其他场景。");
            var source = sources[sourceChoice.Selected];
            if (_promptTestSession?.Source != source || _promptTestSession.Message != message.Text)
                _promptTestSession = AiService.CreateTestSession(data, source, message.Text);
            return _promptTestSession;
        }
        void ShowMaterial()
        {
            try
            {
                localError = "";
                var test = Prepare();
                using var parsed = System.Text.Json.JsonDocument.Parse(test.Context);
                material.Text = System.Text.Json.JsonSerializer.Serialize(parsed.RootElement, new System.Text.Json.JsonSerializerOptions
                    { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            }
            catch (Exception e) { material.Text = e.Message; localError = e.Message; }
        }
        Button send = null!;
        send = Button("开始测试", () =>
        {
            if (_promptTestSession?.Running == true) return;
            try
            {
                localError = "";
                var test = Prepare();
                string endpoint = data.Ai.Endpoint;
                string service = Uri.TryCreate(endpoint, UriKind.Absolute, out var address) ? address.GetLeftPart(UriPartial.Authority) : "尚未填写有效地址";
                ShowCareerDialog("确认试写", $"向 {service} 发送所选材料、相关人物与历史记录，以及当前编辑的提示词？\n消耗一次 AI 请求。结果仅供预览，材料可在“查看本次材料”中检查。", () =>
                {
                    if (data.Ai.Endpoint != endpoint) { localError = "接收地址已改变，请重新确认。"; return true; }
                    _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true);
                    Refresh();
                    return true;
                }, "发送并测试");
            }
            catch (Exception e) { localError = e.Message; status.Text = e.Message; }
        }, 180);
        actions.AddChild(send);
        var inspect = Button("查看本次材料", () => { showingMaterial = !showingMaterial; material.Visible = showingMaterial; compare.Visible = !showingMaterial; if (showingMaterial) ShowMaterial(); }, 210);
        actions.AddChild(inspect);
        void CloseTest()
        {
            _closePromptTest = null; shade.Hide(); shade.QueueFree();
            if (IsInstanceValid(editor)) editor.Show();
        }
        _closePromptTest = CloseTest;
        actions.AddChild(Button("返回编辑", CloseTest, 170));
        sceneChoice.ItemSelected += index => { localError = ""; scene = scenes[(int)index]; ChooseSources(); if (showingMaterial) ShowMaterial(); };
        sourceChoice.ItemSelected += _ => { localError = ""; if (showingMaterial) ShowMaterial(); };
        message.TextChanged += () => { if (showingMaterial && _promptTestSession?.Running != true) ShowMaterial(); };
        void Refresh()
        {
            var test = _promptTestSession;
            bool busy = test?.Running == true;
            send.Disabled = busy || sources.Count == 0; sceneChoice.Disabled = busy; sourceChoice.Disabled = busy; message.Editable = !busy;
            send.Text = test == null || test.Work.State == "idle" ? "开始测试" : "重新测试";
            if (previous.Text != (test?.Previous ?? "")) previous.Text = test?.Previous ?? "";
            if (current.Text != (test?.Result ?? "")) current.Text = test?.Result ?? "";
            if (test != null) status.Text = test.Work.State switch {
                "queued" => test.Work.WaitReason.Length > 0 ? test.Work.WaitReason : "正在等候空闲位置……",
                "sending" => "正在试写，可以返回继续编辑。",
                "completed" => "试写完成。同一材料可重新测试，或返回编辑后再比较。",
                "failed" => test.Work.Error,
                _ => "材料已经选好，点击开始测试。" };
            else status.Text = sources.Count == 0 ? "当前场景还没有可用材料，请选择其他场景。" : "选择材料后开始测试。";
            if (localError.Length > 0) status.Text = localError;
        }
        ChooseSources(); Refresh();
        var timer = new Godot.Timer { WaitTime = .25, Autostart = true }; shade.AddChild(timer); timer.Timeout += Refresh;
    }
}
