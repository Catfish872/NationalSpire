using Godot;

namespace NationalSpire;

/// <summary>单人和多人主机共用配置表单，保存与生成由当前生涯入口提供。</summary>
public static class AiSettingsPanel
{
    public static OptionButton RivalLevelPicker(int level, bool team = false)
    {
        var picker = new OptionButton { Name = "RivalLevel", CustomMinimumSize = new(0, 52), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
        int[] levels = [100, 1000, 10000];
        string[] times = team ? ["1 小时 7 分 30 秒", "1 小时 30 分钟", "2 小时 15 分钟"] : ["45 分钟", "1 小时", "1 小时 30 分钟"];
        for (int i = 0; i < levels.Length; i++) picker.AddItem($"下降 {levels[i]} 倍 · 职业{(team ? "队伍" : "选手")}约 {times[i]}", levels[i]);
        picker.Select(Array.IndexOf(levels, level) is var index && index >= 0 ? index : 1);
        return picker;
    }

    public static Label Build(VBoxContainer box, AiOptions options, Action save, Action generate, Action prompts,
        Action<string, bool> notice, Action? editing = null, string saveText = "保存设置", Action<Action>? confirmSwitch = null)
    {
        AiRouting.Ensure(options);
        var columns = new HBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
        columns.AddThemeConstantOverride("separation", 22); box.AddChild(columns);
        var editorPanel = new PanelContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.2f };
        editorPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102330", "385565", 10, 18)); columns.AddChild(editorPanel);
        var editor = new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }; editor.AddThemeConstantOverride("separation", 10); editorPanel.AddChild(editor);
        var routePanel = new PanelContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
        routePanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("122735", "426575", 10, 18)); columns.AddChild(routePanel);
        var routes = new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }; routes.AddThemeConstantOverride("separation", 13); routePanel.AddChild(routes);
        string selected = AiRouting.Default; bool loading = false, creating = false, deleteKey = false;
        string? draftKey = AiService.ProfileKey(selected);
        Label Text(string value)
        {
            var label = new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            label.AddThemeFontSizeOverride("font_size", 16); label.AddThemeColorOverride("font_color", CareerVisuals.Muted); editor.AddChild(label); return label;
        }
        void Button(string title, Action action)
        {
            var button = new BroadcastButton { Text = title, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin };
            button.Pressed += action; editor.AddChild(button);
        }
        void Save() { try { save(); } catch (Exception e) { notice("设置未能保存：" + e.Message, true); } }
        LineEdit Input(string title, string value, string name)
        {
            Text(title); var input = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            input.TextChanged += _ => editing?.Invoke(); editor.AddChild(input); return input;
        }
        var commitNumbers = new List<Func<bool>>();
        void Number(string title, string name, int value, int min, int max, Action<int> update)
        {
            Text($"{title}（{min}—{max}）");
            var row = new HBoxContainer(); editor.AddChild(row);
            int saved = Math.Clamp(value, min, max);
            var input = new LineEdit { Name = name, Text = saved.ToString(), CustomMinimumSize = new(150, 44), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            row.AddChild(input);
            bool Commit()
            {
                if (!int.TryParse(input.Text.Trim(), out int number) || number < min || number > max)
                {
                    input.Text = saved.ToString();
                    notice($"{title}请输入 {min}—{max} 之间的整数，已保留原值 {saved}。", true);
                    return false;
                }
                input.Text = number.ToString();
                if (number != saved) { saved = number; update(number); Save(); }
                return true;
            }
            input.TextChanged += _ => editing?.Invoke();
            input.FocusExited += () => Commit(); input.TextSubmitted += _ => Commit();
            commitNumbers.Add(Commit);
            foreach (int delta in new[] { -1, 1 })
            {
                var step = new BroadcastButton { Text = delta < 0 ? "−" : "+", CustomMinimumSize = new(44, 44), FocusMode = Control.FocusModeEnum.None };
                step.Pressed += () => { if (!Commit()) return; editing?.Invoke(); input.Text = Math.Clamp(saved + delta, min, max).ToString(); Commit(); };
                row.AddChild(step);
            }
        }
        LineEdit? key = null;
        void CommitKey()
        {
            string? value = deleteKey ? "" : !string.IsNullOrWhiteSpace(key!.Text) ? key.Text.Trim() : creating ? draftKey : null;
            if (value == null) return;
            var error = AiService.PersistKey(value, selected);
            draftKey = value; key!.Text = ""; deleteKey = false;
            key.PlaceholderText = AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥";
            if (error != null) notice(error, true);
        }
        Text("连接方案").AddThemeColorOverride("font_color", CareerVisuals.Gold);
        var selectionRow = new HBoxContainer(); editor.AddChild(selectionRow);
        var profiles = new OptionButton { Name = "AiProfiles", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }; selectionRow.AddChild(profiles);
        var create = new BroadcastButton { Name = "AiNewProfile", Text = "＋ 新建", CustomMinimumSize = new(96, 46) }; selectionRow.AddChild(create);
        var saveRow = new HBoxContainer(); editor.AddChild(saveRow);
        var profileName = new LineEdit { Name = "AiProfileName", Text = options.ConnectionProfiles[selected].Name, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
        saveRow.AddChild(profileName); profileName.TextChanged += _ => editing?.Invoke();
        var saveButton = new BroadcastButton { Name = "AiSaveProfile", Text = saveText, CustomMinimumSize = new(128, 46) }; saveRow.AddChild(saveButton);
        Button("提示词配置", prompts);
        var enabled = new CheckBox { Text = "启用 AI 社区", ButtonPressed = options.Enabled };
        enabled.Toggled += value => { editing?.Invoke(); options.Enabled = value; Save(); }; editor.AddChild(enabled);
        var endpoint = Input("服务地址（自动补全 /chat/completions）", options.ConnectionProfiles[selected].Endpoint, "AiEndpoint");
        var model = Input("模型名称", options.ConnectionProfiles[selected].Model, "AiModel");
        Text("API 密钥（加密保存在本机）");
        key = new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasProfileKey(selected) ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) };
        key.TextChanged += _ => editing?.Invoke();
        editor.AddChild(key);
        var fetch = new BroadcastButton { Name = "AiFetchModels", Text = "获取模型列表", CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin };
        editor.AddChild(fetch);
        var modelStatus = Text("使用当前填写的密钥查询，留空时使用已保存密钥。"); modelStatus.Name = "AiModelStatus";
        var modelChoices = new VBoxContainer { Visible = false }; editor.AddChild(modelChoices);
        var filter = new LineEdit { Name = "AiModelFilter", PlaceholderText = "搜索模型", CustomMinimumSize = new(0, 42) }; modelChoices.AddChild(filter);
        var picker = new OptionButton { Name = "AiModelList", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }; modelChoices.AddChild(picker);
        var details = new TextEdit { Name = "AiModelError", Visible = false, Editable = false, CustomMinimumSize = new(0, 110), WrapMode = TextEdit.LineWrappingMode.Boundary }; editor.AddChild(details);
        details.AddThemeFontSizeOverride("font_size", 16);
        IReadOnlyList<string> models = []; string[] filtered = []; int queryRevision = 0;
        void FilterModels()
        {
            filtered = models.Where(m => m.Contains(filter.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray();
            picker.Clear(); picker.AddItem(filtered.Length == 0 ? "没有匹配的模型" : "选择模型，填入上方输入框");
            foreach (string id in filtered) picker.AddItem(id); picker.Select(0); picker.Disabled = filtered.Length == 0;
        }
        void InvalidateModels()
        { queryRevision++; models = []; modelChoices.Visible = false; details.Visible = false; modelStatus.Text = "地址或密钥已修改，请重新获取模型列表。"; }
        endpoint.TextChanged += _ => InvalidateModels(); key.TextChanged += _ => InvalidateModels();
        filter.TextChanged += _ => FilterModels();
        picker.ItemSelected += index =>
        {
            if (index < 1 || index > filtered.Length) return;
            model.Text = filtered[(int)index - 1]; editing?.Invoke(); modelStatus.Text = "已填入模型名称，点击保存后生效。";
        };
        fetch.Pressed += async () =>
        {
            if (fetch.Disabled) return;
            editing?.Invoke();
            int revision = queryRevision; string address = endpoint.Text.Trim(); string? credential = string.IsNullOrWhiteSpace(key.Text) ? draftKey : key.Text;
            fetch.Disabled = true; fetch.Text = "正在获取…"; modelStatus.Text = "正在查询模型列表…"; details.Visible = false;
            bool Current() => GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion() && fetch.IsInsideTree() && revision == queryRevision;
            try
            {
                var result = await AiService.FetchModelsAsync(address, credential, selected);
                if (!Current()) return;
                models = result; filter.Text = ""; FilterModels(); modelChoices.Visible = models.Count > 0;
                modelStatus.Text = models.Count == 0 ? "接口返回的模型列表为空，可手动填写模型名称。" : $"已获取 {models.Count} 个模型，支持搜索选择。";
            }
            catch (Exception e)
            {
                if (!Current()) return;
                modelStatus.Text = "获取失败，详情如下。也可手动填写模型名称。";
                details.Text = AiService.FailureReason(e); details.Visible = true;
            }
            finally
            {
                if (GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion()) { fetch.Disabled = false; fetch.Text = "获取模型列表"; }
            }
        };
        Button("删除已保存密钥", () => { deleteKey = true; draftKey = ""; key.Text = ""; key.PlaceholderText = "保存后删除此方案密钥"; editing?.Invoke(); InvalidateModels(); });
        Number("每次最多生成帖子数", "AiNewsPostCount", options.MaxNewsPosts, 1, AiOptions.MaximumNewsPostCount, value => options.MaxNewsPosts = value);
        Text("按待生成事件选取，不足时不会凑数。数量越多，生成时间和用量通常越高；默认 3 篇。");
        Number("最大并发数", "AiConcurrency", options.MaxConcurrentRequests, 1, 16, value => options.MaxConcurrentRequests = value);
        Number("请求发送间隔 · 秒，0 表示无需间隔", "AiRequestInterval", options.MinimumIntervalSeconds, 0, 300, value => options.MinimumIntervalSeconds = value);
        Number("最长等待时间 · 分钟", "AiTimeout", options.RequestTimeoutMinutes, 2, 30, value => options.RequestTimeoutMinutes = value);
        var status = Text("当前状态：" + PlayerFacingText.AiStatus(AiService.Status));
        var routeControls = new List<AiTaskRoutePicker>();
        var applyAll = new BroadcastButton { Name = "AiApplyAll", Text = "将当前方案应用到所有", CustomMinimumSize = new(0, 46) };
        saveButton.Pressed += () =>
        {
            Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });
            try
            {
                // 点击保存时也提交仍在编辑的数字，不依赖焦点事件先后顺序。
                bool valid = true;
                foreach (var commit in commitNumbers) if (!commit()) valid = false;
                if (!valid) { Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" }); return; }
                string name = profileName.Text.Trim(), address = endpoint.Text.Trim(), modelId = model.Text.Trim();
                if (name.Length == 0) throw new ArgumentException("请填写方案名称。");
                if (options.ConnectionProfiles.Any(p => p.Key != selected && p.Value.Name == name)) throw new ArgumentException("方案名称已存在，请修改名称。");
                if (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme is not ("http" or "https") || modelId.Length == 0)
                    throw new ArgumentException("请填写有效的服务地址和模型名称。");
                var prior = options.ConnectionProfiles.GetValueOrDefault(selected);
                options.ConnectionProfiles[selected] = new() { Name = name, Endpoint = address, Model = modelId };
                if (selected == AiRouting.Default) { options.Endpoint = address; options.Model = modelId; }
                try { save(); }
                catch
                {
                    if (prior == null) options.ConnectionProfiles.Remove(selected); else options.ConnectionProfiles[selected] = prior;
                    if (selected == AiRouting.Default && prior != null) { options.Endpoint = prior.Endpoint; options.Model = prior.Model; }
                    throw;
                }
                CommitKey(); creating = false;
                RefreshProfiles(); RefreshRoutes();
                Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });
                if (!options.Enabled) { notice("设置已保存。", false); return; }
                if (!AiService.HasProfileKey(selected)) { notice("设置已保存，请填写 API 密钥。", true); return; }
                generate(); notice("设置已保存。", false);
            }
            catch (Exception e) { Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name }); notice(e.Message, true); }
        };
        var routeTitle = new Label { Text = "任务使用方案" }; routeTitle.AddThemeFontSizeOverride("font_size", 22); routeTitle.AddThemeColorOverride("font_color", CareerVisuals.Gold); routes.AddChild(routeTitle);
        routes.AddChild(applyAll);
        foreach (var task in AiRouting.Tasks)
        {
            var panel = new AiTaskRoutePicker(); routes.AddChild(panel);
            panel.Configure(options, task.Id, save, notice); routeControls.Add(panel);
        }
        void RefreshRoutes()
        {
            loading = true;
            foreach (var route in routeControls) route.Refresh();
            applyAll.Disabled = creating; loading = false;
        }
        void RefreshProfiles()
        {
            loading = true; profiles.Clear(); int i = 0;
            foreach (var entry in options.ConnectionProfiles)
            { profiles.AddItem(entry.Value.Name); profiles.SetItemMetadata(i, entry.Key); if (entry.Key == selected) profiles.Select(i); i++; }
            if (creating) { profiles.AddItem(profileName.Text); profiles.SetItemMetadata(i, selected); profiles.Select(i); }
            loading = false;
        }
        bool Dirty()
        {
            if (creating || deleteKey || !string.IsNullOrWhiteSpace(key.Text)) return true;
            var saved = options.ConnectionProfiles[selected];
            return profileName.Text != saved.Name || endpoint.Text != saved.Endpoint || model.Text != saved.Model;
        }
        void Load(string id, bool fresh)
        {
            var source = options.ConnectionProfiles[id]; draftKey = AiService.ProfileKey(id);
            selected = fresh ? Guid.NewGuid().ToString("N") : id; creating = fresh; deleteKey = false;
            profileName.Text = fresh ? AiRouting.NextName(options) : source.Name;
            endpoint.Text = source.Endpoint; model.Text = source.Model; key.Text = "";
            key.PlaceholderText = !string.IsNullOrWhiteSpace(draftKey) ? "已保存，留空保留当前密钥" : "请输入 API 密钥";
            InvalidateModels(); RefreshProfiles(); RefreshRoutes();
        }
        void Switch(Action action)
        {
            if (!Dirty()) { action(); return; }
            RefreshProfiles();
            if (confirmSwitch != null) confirmSwitch(action);
        }
        profiles.ItemSelected += index =>
        {
            if (loading) return;
            string target = profiles.GetItemMetadata((int)index).AsString();
            if (target != selected) Switch(() => Load(target, false));
        };
        create.Pressed += () => { string source = creating ? AiRouting.Default : selected; Switch(() => Load(source, true)); };
        applyAll.Pressed += () => { foreach (var task in AiRouting.Tasks) options.TaskProfiles[task.Id] = selected; Save(); RefreshRoutes(); notice("当前方案已应用到所有任务。", false); };
        RefreshProfiles(); RefreshRoutes();
        return status;
    }
}
