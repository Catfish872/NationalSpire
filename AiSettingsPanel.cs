using Godot;

namespace NationalSpire;

/// <summary>单人和多人主机共用配置表单，保存与生成由当前生涯入口提供。</summary>
public static class AiSettingsPanel
{
    public static Label Build(VBoxContainer box, AiOptions options, Action save, Action generate, Action prompts,
        Action<string, bool> notice, Action? editing = null, string saveText = "保存设置")
    {
        Label Text(string value)
        {
            var label = new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            label.AddThemeFontSizeOverride("font_size", 16); label.AddThemeColorOverride("font_color", CareerVisuals.Muted); box.AddChild(label); return label;
        }
        void Button(string title, Action action)
        {
            var button = new BroadcastButton { Text = title, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin };
            button.Pressed += action; box.AddChild(button);
        }
        void Save() { try { save(); } catch (Exception e) { notice("设置未能保存：" + e.Message, true); } }
        LineEdit Input(string title, string value, string name)
        {
            Text(title); var input = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            input.TextChanged += _ => editing?.Invoke(); box.AddChild(input); return input;
        }
        var commitNumbers = new List<Func<bool>>();
        void Number(string title, string name, int value, int min, int max, Action<int> update)
        {
            Text($"{title}（{min}—{max}）");
            var row = new HBoxContainer(); box.AddChild(row);
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
            if (key == null || string.IsNullOrWhiteSpace(key.Text)) return;
            Diagnostics.Record("ai.credential.commit", new { source = "save-button" });
            var error = AiService.PersistKey(key.Text.Trim());
            key.Text = "";
            key.PlaceholderText = error == null ? "已保存，留空保留当前密钥" : "已暂存，本次启动可用";
            if (error != null) notice(error, true);
        }
        Button("提示词配置", prompts);
        var enabled = new CheckBox { Text = "启用 AI 社区", ButtonPressed = options.Enabled };
        enabled.Toggled += value => { editing?.Invoke(); options.Enabled = value; Save(); }; box.AddChild(enabled);
        var communityDanmaku = new CheckBox { Text = "实时社区弹幕", ButtonPressed = options.CommunityDanmaku };
        communityDanmaku.TooltipText = "每次社区内容更新后，额外调用一次 AI，把刚发生的社区动态转写成局内飘屏弹幕，风格跟随当前提示词模板。会多消耗一次 API 调用。";
        communityDanmaku.Toggled += value => { editing?.Invoke(); options.CommunityDanmaku = value; Save(); };
        box.AddChild(communityDanmaku);
        Text("开启后，AI 每次生成社区内容都会顺手写一批弹幕，存进实时社区库；局内会与静态词库一起抽取。");
        var communityStats = AiDanmakuStore.Stats();
        var communitySpan = AiDanmakuStore.Span();
        Text(communityStats.Count == 0
            ? $"社区库当前为空。库里的弹幕每 {AiDanmakuStore.ExpiryDays} 天清理一轮过时内容，避免旧话题一直占着抽取名额。"
            : $"社区库当前 {communityStats.Count} 条，覆盖生涯第 {communitySpan.Oldest}—{communitySpan.Newest} 天；"
              + $"每 {AiDanmakuStore.ExpiryDays} 天清理一轮，超过 {AiDanmakuStore.ExpiryDays} 天未更新的弹幕会被淘汰（全过期时保留最新 {AiDanmakuStore.MinimumKept} 条）。");

        var endpoint = Input("服务地址（自动补全 /chat/completions）", options.Endpoint, "AiEndpoint");
        var model = Input("模型名称", options.Model, "AiModel");
        Text("API 密钥（加密保存在本机）");
        key = new LineEdit { Name = "AiKey", Secret = true, PlaceholderText = AiService.HasKey ? "已保存，留空保留当前密钥" : "请输入 API 密钥", CustomMinimumSize = new(0, 42) };
        key.TextChanged += _ => editing?.Invoke();
        box.AddChild(key);
        var fetch = new BroadcastButton { Name = "AiFetchModels", Text = "获取模型列表", CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = Control.SizeFlags.ShrinkBegin };
        box.AddChild(fetch);
        var modelStatus = Text("使用当前填写的密钥查询，留空时使用已保存密钥。"); modelStatus.Name = "AiModelStatus";
        var modelChoices = new VBoxContainer { Visible = false }; box.AddChild(modelChoices);
        var filter = new LineEdit { Name = "AiModelFilter", PlaceholderText = "搜索模型", CustomMinimumSize = new(0, 42) }; modelChoices.AddChild(filter);
        var picker = new OptionButton { Name = "AiModelList", FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }; modelChoices.AddChild(picker);
        var details = new TextEdit { Name = "AiModelError", Visible = false, Editable = false, CustomMinimumSize = new(0, 110), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(details);
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
            int revision = queryRevision; string address = endpoint.Text.Trim(), credential = key.Text;
            fetch.Disabled = true; fetch.Text = "正在获取…"; modelStatus.Text = "正在查询模型列表…"; details.Visible = false;
            bool Current() => GodotObject.IsInstanceValid(fetch) && !fetch.IsQueuedForDeletion() && fetch.IsInsideTree() && revision == queryRevision;
            try
            {
                var result = await AiService.FetchModelsAsync(address, credential);
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
        Button("删除已保存密钥", () => { var error = AiService.PersistKey(""); key.Text = ""; key.PlaceholderText = "请输入 API 密钥"; InvalidateModels(); notice(error ?? "本机密钥已删除。", error != null); });
        Number("每次最多生成帖子数", "AiNewsPostCount", options.MaxNewsPosts, 1, AiOptions.MaximumNewsPostCount, value => options.MaxNewsPosts = value);
        Text("按待生成事件选取，不足时不会凑数。数量越多，生成时间和用量通常越高；默认 3 篇。");
        Number("最大并发数", "AiConcurrency", options.MaxConcurrentRequests, 1, 16, value => options.MaxConcurrentRequests = value);
        Number("请求发送间隔 · 秒，0 表示无需间隔", "AiRequestInterval", options.MinimumIntervalSeconds, 0, 300, value => options.MinimumIntervalSeconds = value);
        Number("最长等待时间 · 分钟", "AiTimeout", options.RequestTimeoutMinutes, 2, 30, value => options.RequestTimeoutMinutes = value);
        var status = Text("当前状态：" + PlayerFacingText.AiStatus(AiService.Status));
        Button(saveText, () =>
        {
            Diagnostics.Record("ai.settings.save-clicked", new { enteredCredential = !string.IsNullOrWhiteSpace(key.Text), available = AiService.HasKey });
            try
            {
                // 点击保存时也提交仍在编辑的数字，不依赖焦点事件先后顺序。
                bool valid = true;
                foreach (var commit in commitNumbers) if (!commit()) valid = false;
                if (!valid) { Diagnostics.Record("ai.settings.save-rejected", new { reason = "number" }); return; }
                options.Endpoint = endpoint.Text.Trim(); options.Model = model.Text.Trim();
                if (!Uri.TryCreate(options.Endpoint, UriKind.Absolute, out var uri) || uri.Scheme is not ("http" or "https") || options.Model.Length == 0)
                    throw new ArgumentException("请填写有效的服务地址和模型名称。");
                save();
                CommitKey();
                Diagnostics.Record("ai.settings.saved", new { enabled = options.Enabled, available = AiService.HasKey });
                if (!options.Enabled) { notice("设置已保存。", false); return; }
                if (!AiService.HasKey) { notice("设置已保存，请填写 API 密钥。", true); return; }
                generate(); notice("设置已保存。", false);
            }
            catch (Exception e) { Diagnostics.Record("ai.settings.save-failed", new { error = e.GetType().Name }); notice(e.Message, true); }
        });
        return status;
    }
}
