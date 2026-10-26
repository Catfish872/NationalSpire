using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private bool _npcSetupOpening;
    internal static void SelectNpcGeneration(Control parent, AiOptions ai, Func<NpcGenerationSetup, Task> selected, Action? cancelled = null)
    {
        var screen = new CareerScreen { Theme = CareerVisuals.CreateTheme() }; parent.AddChild(screen); screen.SetProcess(false); screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        screen._stage = new Control(); screen.AddChild(screen._stage); screen.Resized += screen.FitStage; screen.FitStage();
        bool complete = false;
        screen.OpenNpcGeneration(ai, _ => { }, selectedAsync: async plan => { await selected(plan); complete = true; }, team: true);
        screen._dialogOverlay!.TreeExiting += () => { if (!complete) cancelled?.Invoke(); if (!screen.IsQueuedForDeletion()) screen.QueueFree(); };
    }

    private void OpenNpcGeneration(AiOptions ai, Action<NpcGenerationSetup> selected, bool required = false,
        Func<NpcGenerationSetup, Task>? selectedAsync = null, int rivalLevel = 1000, bool team = false)
    {
        var setup = new NpcGenerationSetup { Pool = PersonalityPools.Read(ai), Ai = Coop.CoopJson.Copy(ai), RivalLevel = rivalLevel };
        AiRouting.Ensure(setup.Ai);
        if (!setup.Ai.ConnectionProfiles.ContainsKey(AiRouting.Default)) setup.Ai.ConnectionProfiles[AiRouting.Default] = new() { Endpoint = setup.Ai.Endpoint, Model = setup.Ai.Model };
        var connection = setup.Ai.ConnectionProfiles[AiRouting.Default];
        Label status = null!; GridContainer weights = null!; VBoxContainer files = null!;
        LineEdit endpoint = null!, model = null!, key = null!;
        var sliders = new List<PercentageSlider>(); bool busy = false;
        async Task SubmitAsync()
        {
            busy = true; status.Text = "正在生成角色并建立房间……";
            var dialog = _dialogOverlay;
            try { await selectedAsync!(Coop.CoopJson.Copy(setup)); if (IsInstanceValid(this) && !IsQueuedForDeletion() && _dialogOverlay == dialog) _cancelDialog?.Invoke(); }
            catch (Exception e) { if (IsInstanceValid(status) && !status.IsQueuedForDeletion()) status.Text = "配置未应用：" + e.Message; }
            finally { busy = false; }
        }
        void Files()
        {
            CareerVisuals.ClearContent(files); files.Visible = setup.Files.Count > 0;
            foreach (var path in setup.Files.ToArray())
            {
                var row = new HBoxContainer(); files.AddChild(row);
                var name = Text(Path.GetFileName(path), 16, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.AutowrapMode = TextServer.AutowrapMode.WordSmart; row.AddChild(name);
                row.AddChild(Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90));
            }
        }
        void Weights()
        {
            CareerVisuals.ClearContent(weights); sliders.Clear();
            var categories = setup.Pool.Categories;
            var categoryValues = PercentageAllocation.Normalize(categories.Select(c => c.Weight));
            var categorySliders = new List<PercentageSlider>();
            var categoryLocks = new bool[categories.Count];
            bool updating = false;
            void AddSlider(HBoxContainer row, PercentageSlider slider, bool[] locks, int index)
            {
                var toggle = new PercentageLockButton { Name = slider.Name + "_Lock" };
                row.AddChild(toggle); row.AddChild(slider);
                toggle.Toggled += locked =>
                {
                    slider.Commit(); locks[index] = locked;
                    slider.Editable = !locked && locks.Length > 1;
                };
            }
            for (int i = 0; i < categories.Count; i++) categories[i].Weight = categoryValues[i];
            foreach (var category in categories)
            {
                int index = categories.IndexOf(category);
                var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142734", "365565", 8, 14)); weights.AddChild(panel);
                var column = new VBoxContainer(); column.AddThemeConstantOverride("separation", 8); panel.AddChild(column);
                column.AddChild(Text(category.Name + " · " + category.Gender, 19, _gold));
                var parentSlider = new PercentageSlider { Name = "CategoryPercent_" + category.Id, Value = category.Weight, Editable = categories.Count > 1 };
                sliders.Add(parentSlider); categorySliders.Add(parentSlider);
                var parentRow = new HBoxContainer(); parentRow.AddThemeConstantOverride("separation", 6); column.AddChild(parentRow);
                AddSlider(parentRow, parentSlider, categoryLocks, index);
                parentSlider.ValueChanged += value =>
                {
                    if (updating) return; updating = true;
                    var adjusted = PercentageAllocation.Adjust(categories.Select(c => c.Weight).ToArray(), index, value, categoryLocks);
                    for (int j = 0; j < categories.Count; j++) { categories[j].Weight = adjusted[j]; categorySliders[j].SetValueNoSignal(adjusted[j]); categorySliders[j].Refresh(); }
                    updating = false;
                };
                column.AddChild(new HSeparator());
                column.AddChild(Text("类别内性格 · 合计 100%", 15, _muted));
                var styles = category.Styles; var values = PercentageAllocation.Normalize(styles.Select(s => s.Weight)); var children = new List<PercentageSlider>();
                var childLocks = new bool[styles.Count];
                for (int j = 0; j < styles.Count; j++) styles[j].Weight = values[j];
                foreach (var style in styles)
                {
                    int childIndex = styles.IndexOf(style);
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 10); column.AddChild(row);
                    var name = Text(style.Name, 17, _ink); name.CustomMinimumSize = new(76, 0); name.SizeFlagsHorizontal = SizeFlags.Fill;
                    name.AutowrapMode = TextServer.AutowrapMode.WordSmart; row.AddChild(name);
                    var slider = new PercentageSlider { Name = "StylePercent_" + category.Id + "_" + style.Id, Value = style.Weight, Editable = styles.Count > 1 };
                    sliders.Add(slider); children.Add(slider); AddSlider(row, slider, childLocks, childIndex);
                    slider.ValueChanged += value =>
                    {
                        if (updating) return; updating = true;
                        var adjusted = PercentageAllocation.Adjust(styles.Select(s => s.Weight).ToArray(), childIndex, value, childLocks);
                        for (int k = 0; k < styles.Count; k++) { styles[k].Weight = adjusted[k]; children[k].SetValueNoSignal(adjusted[k]); children[k].Refresh(); }
                        updating = false;
                    };
                }
            }
        }
        ShowCareerDialog("配置新世界", "", () =>
        {
            if (busy) return false;
            try
            {
                foreach (var slider in sliders) slider.Commit();
                PersonalityPools.Validate(setup.Pool);
                string address = endpoint.Text.Trim(), modelId = model.Text.Trim();
                if (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme is not ("https" or "http") || modelId.Length == 0)
                    throw new ArgumentException("请填写有效的服务地址和模型名称。");
                connection.Endpoint = setup.Ai.Endpoint = address; connection.Model = setup.Ai.Model = modelId;
                if (!string.IsNullOrWhiteSpace(key.Text))
                {
                    if (AiService.PersistKey(key.Text.Trim()) is { } error) throw new IOException(error);
                    key.Text = ""; key.PlaceholderText = "已保存 · 留空保留";
                }
                if (AiService.HasProfileKey(AiRouting.Default)) setup.Ai.Enabled = true;
                if (selectedAsync != null) { _ = SubmitAsync(); return false; }
                selected(setup); return true;
            }
            catch (Exception e) { status.Text = "配置未应用：" + e.Message; return false; }
        }, "生成并开始", box =>
        {
            box.CustomMinimumSize = new(1040, 0); box.AddThemeConstantOverride("separation", 16);
            var scroll = new BroadcastScroll { Name = "NewWorldScroll", CustomMinimumSize = new(0, 550), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; content.AddThemeConstantOverride("separation", 12); scroll.AddChild(content);
            HBoxContainer SettingRow(string title)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); content.AddChild(row);
                var label = Text(title, 20, _gold); label.CustomMinimumSize = new(190, 0); row.AddChild(label); return row;
            }
            var level = AiSettingsPanel.RivalLevelPicker(setup.RivalLevel, team); level.CustomMinimumSize = new(0, 44);
            level.ItemSelected += i => setup.RivalLevel = level.GetItemId((int)i); SettingRow("NPC 游戏下降水平").AddChild(level);
            var templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray();
            var worlds = new OptionButton { Name = "WorldPromptTemplate", FitToLongestItem = false, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            void RefreshWorlds()
            {
                templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray(); worlds.Clear();
                foreach (var template in templates) worlds.AddItem(template.Name);
                worlds.AddSeparator(); worlds.AddItem("导入提示词…");
                worlds.Select(Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai)));
            }
            RefreshWorlds();
            worlds.ItemSelected += i =>
            {
                if (busy) { RefreshWorlds(); return; }
                if (i < templates.Length) { PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id); return; }
                RefreshWorlds();
                PickNestedFile("选择提示词 JSON", [".json"], path =>
                {
                    try
                    {
                        var imported = Coop.CoopJson.Copy(setup.Ai);
                        var bundle = PromptTransfer.Read(File.ReadAllText(path));
                        PromptTransfer.Apply(imported, bundle);
                        setup.Ai = imported; connection = setup.Ai.ConnectionProfiles[AiRouting.Default];
                        if (bundle.PersonalityPool != null) { setup.Pool = PersonalityPools.Read(imported); Weights(); }
                        RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected)
                            + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。";
                    }
                    catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; }
                });
            };
            SettingRow("世界设定").AddChild(worlds);
            content.AddChild(new HSeparator());
            content.AddChild(Text("API 配置", 20, _gold));
            content.AddChild(Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted));
            LineEdit Input(VBoxContainer parent, string title, string value, string name)
            {
                parent.AddChild(Text(title, 16, _muted));
                var input = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                parent.AddChild(input); return input;
            }
            var credentials = new HBoxContainer(); credentials.AddThemeConstantOverride("separation", 16); content.AddChild(credentials);
            var addressColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.5f }; credentials.AddChild(addressColumn);
            endpoint = Input(addressColumn, "服务地址", connection.Endpoint, "WorldApiEndpoint");
            var secretColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; credentials.AddChild(secretColumn);
            var modelColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; credentials.AddChild(modelColumn);
            key = Input(secretColumn, "密钥 · 加密保存在本机", "", "WorldApiKey"); key.Secret = true;
            key.PlaceholderText = AiService.HasProfileKey(AiRouting.Default) ? "已保存 · 留空保留" : "填写 API 密钥";
            model = Input(modelColumn, "模型", connection.Model, "WorldApiModel");
            content.AddChild(new HSeparator());
            var peopleRow = new HBoxContainer(); peopleRow.AddThemeConstantOverride("separation", 24); content.AddChild(peopleRow);
            var peopleColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; peopleColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(peopleColumn);
            peopleColumn.AddChild(Text("NPC 性格与角色配置", 20, _gold));
            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); peopleColumn.AddChild(toolbar);
            toolbar.AddChild(Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path =>
            { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180));
            toolbar.AddChild(Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths =>
            {
                foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path);
                Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。";
            }); }, 180));
            var playerColumn = new VBoxContainer { CustomMinimumSize = new(300, 0) }; playerColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(playerColumn);
            playerColumn.AddChild(Text("你的名字：", 20, _gold));
            var playerName = new LineEdit { Name = "WorldPlayerName", Text = setup.PlayerName, PlaceholderText = CareerEngine.PlayerName,
                CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill };
            playerName.AddThemeFontSizeOverride("font_size", 17); playerColumn.AddChild(playerName);
            playerName.TextChanged += value => { if (!busy) setup.PlayerName = value; };
            files = new VBoxContainer(); content.AddChild(files); Files();
            var proportions = new VBoxContainer { Name = "WorldProportions", Visible = false }; proportions.AddThemeConstantOverride("separation", 10);
            var toggle = new CareerDisclosureButton { Name = "WorldProportionsToggle", Text = "配置人物比例", ArrowOnLeft = true,
                Flat = true, ToggleMode = true, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand };
            toggle.AddThemeFontSizeOverride("font_size", 18);
            toggle.AddThemeColorOverride("font_color", _muted);
            toggle.AddThemeColorOverride("font_hover_color", _ink);
            toggle.AddThemeColorOverride("font_pressed_color", _ink);
            toggle.AddThemeColorOverride("font_hover_pressed_color", _ink);
            foreach (string state in new[] { "normal", "hover", "pressed", "focus" })
                toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 });
            toggle.Pressed += () =>
            {
                if (busy) { toggle.ButtonPressed = proportions.Visible; return; }
                proportions.Visible = !proportions.Visible;
                toggle.ButtonPressed = proportions.Visible; toggle.QueueRedraw();
                scroll.CustomMinimumSize = new(0, proportions.Visible ? 770 : 550);
            }; content.AddChild(toggle); content.AddChild(proportions);
            var allocationHint = Text("各大类、每类内部各合计 100%。点击锁固定比例；其余未锁定项均摊差额，调整上限为剩余额度。", 16, _muted);
            allocationHint.AutowrapMode = TextServer.AutowrapMode.WordSmart; proportions.AddChild(allocationHint);
            weights = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; weights.AddThemeConstantOverride("h_separation", 16); weights.AddThemeConstantOverride("v_separation", 16);
            proportions.AddChild(weights); Weights();
            status = Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted); status.AutowrapMode = TextServer.AutowrapMode.WordSmart; box.AddChild(status);
        }, showCancel: !required);
        if (required) _returnDialog = () => { };
    }

    private void BeginNpcSetup(bool reset)
    {
        _cancelDialog?.Invoke();
        OpenNpcGeneration(ViewData.Ai, plan =>
        {
            var fresh = NpcGeneration.Create(ViewData.Ai, plan);
            using var imported = new NpcGeneration.ImportBatch(fresh, plan.Files);
            if (reset) _boundData = CareerStore.ReplaceFreshCareer(fresh);
            else
            {
                var path = CareerLibrary.Create(CareerStore.DefaultPath, fresh); imported.Commit(); _boundData = CareerStore.SwitchCareer(path);
                _boundData.Ai = fresh.Ai; CareerStore.Save(_boundData);
            }
            imported.Commit(); _npcSetupOpening = false; _confirmReset = false; ResetNavigation();
            Callable.From(Render).CallDeferred();
        }, required: ViewData.NpcSetupPending, rivalLevel: ViewData.RivalLevel);
    }
}
