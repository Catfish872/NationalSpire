using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenEventPoolSettings(CareerData data)
    {
        if (_stage.GetNodeOrNull("EventPoolEditor") != null) return;
        string template = PromptLibrary.TemplateId(data.Ai), category = "event:日常";
        var drafts = EventPools.Overrides(data.Ai); bool dirty = false, loading = false, bulkMode = false, titleFocused = false;
        int selected = -1; var entries = new List<EventPoolEntry>();
        var shade = new ColorRect { Name = "EventPoolEditor", Color = new("09131df5"), MouseFilter = MouseFilterEnum.Stop, ZIndex = 22 };
        _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 26);
        var card = Card(); margin.AddChild(card); var box = Inner(card); box.AddThemeConstantOverride("separation", 12);
        var heading = new HBoxContainer(); box.AddChild(heading);
        heading.AddChild(Text("事件池", 28, _gold));
        var templateName = Text(PromptLibrary.Template(data.Ai).Name, 17, _muted); templateName.SizeFlagsHorizontal = SizeFlags.ExpandFill; templateName.HorizontalAlignment = HorizontalAlignment.Right; heading.AddChild(templateName);
        var tabs = new HBoxContainer(); tabs.AddThemeConstantOverride("separation", 12); box.AddChild(tabs);
        var summary = Text("", 16, _muted); box.AddChild(summary);
        var body = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 16); box.AddChild(body);
        var categories = new ItemList { Name = "PoolCategories", CustomMinimumSize = new(170, 0), SizeFlagsVertical = SizeFlags.ExpandFill }; body.AddChild(categories);
        var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; content.AddThemeConstantOverride("separation", 10); body.AddChild(content);
        var section = Text("", 21, _gold); content.AddChild(section);
        var prefixHelp = Text(EventPools.ParticipantUsage, 14, _muted);
        prefixHelp.Name = "PoolParticipantUsage";
        prefixHelp.AutowrapMode = TextServer.AutowrapMode.WordSmart;
        content.AddChild(prefixHelp);
        var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 10); content.AddChild(toolbar);
        var single = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; single.AddThemeConstantOverride("separation", 14); content.AddChild(single);
        var list = new ItemList { Name = "PoolEntries", CustomMinimumSize = new(240, 0), SizeFlagsVertical = SizeFlags.ExpandFill, MaxTextLines = 2 }; single.AddChild(list);
        var form = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; form.AddThemeConstantOverride("separation", 8); single.AddChild(form);
        var title = new LineEdit { Name = "PoolEntryTitle", PlaceholderText = "标题" }; form.AddChild(title);
        var detail = new TextEdit { Name = "PoolEntryDetail", SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }; detail.AddThemeFontSizeOverride("font_size", 18); form.AddChild(detail);
        var tokens = new HBoxContainer(); form.AddChild(tokens);
        var preview = Text("", 16, CareerVisuals.Teal); preview.AutowrapMode = TextServer.AutowrapMode.WordSmart; preview.CustomMinimumSize = new(0, 48); form.AddChild(preview);
        var bulkBox = new VBoxContainer { Visible = false, SizeFlagsVertical = SizeFlags.ExpandFill }; content.AddChild(bulkBox);
        var bulkHelp = Text("", 15, _muted); bulkHelp.AutowrapMode = TextServer.AutowrapMode.WordSmart; bulkBox.AddChild(bulkHelp);
        var bulk = new CodeEdit { Name = "PoolBulkText", GuttersDrawLineNumbers = true, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }; bulk.AddThemeFontSizeOverride("font_size", 17); bulkBox.AddChild(bulk);
        foreach (var items in new[] { categories, list })
        {
            items.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0e202e", "355568", 6, 10));
            foreach (string state in new[] { "selected", "selected_focus" }) items.AddThemeStyleboxOverride(state, CareerVisuals.Box("284b57", "70c8bd", 4, 5));
            items.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
            items.AddThemeColorOverride("font_color", _ink); items.AddThemeColorOverride("font_selected_color", _gold);
            items.AddThemeFontSizeOverride("font_size", 18); items.AddThemeConstantOverride("v_separation", 10);
        }
        foreach (var input in new TextEdit[] { detail, bulk })
        {
            input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1c29", "355568", 6, 12));
            input.AddThemeStyleboxOverride("focus", CareerVisuals.Box("0c1c29", "70c8bd", 6, 12));
            input.AddThemeColorOverride("font_color", _ink);
        }
        var status = Text("", 16, CareerVisuals.Teal); status.AutowrapMode = TextServer.AutowrapMode.WordSmart; box.AddChild(status);
        var actions = new HFlowContainer(); actions.AddThemeConstantOverride("h_separation", 12); box.AddChild(actions);
        var typeButtons = new Dictionary<bool, Button>(); Button toggle = null!;
        bool Daily() => category.StartsWith("daily:");
        void Heading()
        {
            var definition = EventPools.Categories.Single(c => c.Id == category);
            section.Text = definition.Group + " / " + definition.Name + $" · {entries.Count} 条";
        }
        void Changed() { drafts[category] = entries; dirty = true; status.Text = "修改尚未保存"; Heading(); }
        bool Commit()
        {
            if (!bulkMode) return true;
            try
            {
                var parsed = EventPools.ParseBulk(category, bulk.Text);
                if (!parsed.SequenceEqual(entries)) { entries = parsed; selected = entries.Count == 0 ? -1 : Math.Clamp(selected, 0, entries.Count - 1); Changed(); }
                return true;
            }
            catch (ArgumentException error) { status.Text = error.Message; return false; }
        }
        void Preview()
        {
            var person = data.People.FirstOrDefault(p => p.ClubId.Length > 0);
            string name = person?.PublicName ?? GroupChats.Name(data, GroupChats.Human(data));
            string team = person == null ? "俱乐部" : EsportsWorld.ClubName(data, person.ClubId);
            string rendered = (title.Text + "\n" + detail.Text).Replace("{人}", name).Replace("{队}", team);
            preview.Text = Daily() && selected >= 0 ? "替换预览：" + (rendered.Length > 90 ? rendered[..90] + "…" : rendered) : "";
        }
        string Caption(EventPoolEntry e) { string s = Daily() ? e.Title : e.Detail; s = s.Replace('\n', ' '); return s.Length > 22 ? s[..22] + "…" : s; }
        void SelectEntry(int index)
        {
            selected = index; loading = true;
            title.Text = index >= 0 ? entries[index].Title : ""; detail.Text = index >= 0 ? entries[index].Detail : "";
            detail.PlaceholderText = index >= 0 ? "" : "此分类暂无素材，点击新增或批量编辑添加。";
            title.Editable = detail.Editable = index >= 0; loading = false; Preview();
        }
        void FillList()
        {
            list.Clear(); foreach (var entry in entries) { int i = list.AddItem(Caption(entry)); list.SetItemTooltip(i, entry.Detail); }
            selected = entries.Count == 0 ? -1 : Math.Clamp(selected, 0, entries.Count - 1);
            if (selected >= 0) list.Select(selected); SelectEntry(selected);
        }
        void ShowCategory()
        {
            entries = EventPools.Entries(drafts, category).ToList(); selected = entries.Count > 0 ? 0 : -1;
            Heading();
            summary.Text = "分类固定，内容可自由增删。保存后用于后续抽取，已有故事和帖子保留原文。";
            title.Visible = tokens.Visible = preview.Visible = Daily();
            prefixHelp.Visible = !Daily();
            FillList();
            loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false;
            bulkHelp.Text = Daily() ? "每行填写：标题｜内容。{人}替换为选手，{队}替换为俱乐部；内容换行写为 \\n。" : "每行一条故事素材；素材中的换行写为 \\n。";
            status.Text = drafts.ContainsKey(category) ? "当前分类使用自定义内容" : "当前分类跟随内置内容更新";
            if (EventPools.Categories.Where(c => c.Group == "随机事件").All(c => EventPools.Entries(drafts, c.Id).Count == 0))
                status.Text += " · 随机事件全部为空，使用内置池";
        }
        void ShowCategories(bool daily)
        {
            categories.Clear(); string group = "";
            foreach (var pair in typeButtons) pair.Value.SetPressedNoSignal(pair.Key == daily);
            foreach (var c in EventPools.Categories.Where(c => (c.Group != "随机事件") == daily))
            {
                if (c.Group != group) { int header = categories.AddItem(c.Group); categories.SetItemDisabled(header, true); categories.SetItemMetadata(header, ""); group = c.Group; }
                int i = categories.AddItem(c.Name); categories.SetItemMetadata(i, c.Id); if (c.Id == category) categories.Select(i);
            }
        }
        foreach (bool daily in new[] { false, true })
        {
            var button = Button(daily ? "选手日常" : "随机事件", () =>
            { if (!Commit()) { foreach (var pair in typeButtons) pair.Value.SetPressedNoSignal(pair.Key == Daily()); return; } category = daily ? "daily:观众" : "event:日常"; ShowCategories(daily); ShowCategory(); }, 150);
            button.Name = daily ? "DailyPoolTab" : "RandomPoolTab"; button.ToggleMode = true; typeButtons[daily] = button; tabs.AddChild(button);
        }
        categories.ItemSelected += i =>
        {
            string next = categories.GetItemMetadata((int)i).AsString();
            if (!Commit()) { for (int n = 0; n < categories.ItemCount; n++) if (categories.GetItemMetadata(n).AsString() == category) categories.Select(n); return; }
            category = next; ShowCategory();
        };
        list.ItemSelected += i => SelectEntry((int)i);
        void Edit()
        {
            if (loading || selected < 0) return;
            entries[selected] = new(Daily() ? title.Text : "", detail.Text); list.SetItemText(selected, Caption(entries[selected])); Changed(); Preview();
        }
        title.TextChanged += _ => Edit(); detail.TextChanged += Edit;
        title.FocusEntered += () => titleFocused = true; detail.FocusEntered += () => titleFocused = false;
        bulk.TextChanged += () => { if (!loading) { dirty = true; status.Text = "批量编辑尚未保存"; } };
        foreach (string token in new[] { "{人}", "{队}" }) tokens.AddChild(Button("插入" + token, () =>
        { if (titleFocused) { title.InsertTextAtCaret(token); Edit(); } else detail.InsertTextAtCaret(token); }, 110));
        toolbar.AddChild(Button("新增", () => { if (!Commit()) return; bulkMode = false; single.Show(); bulkBox.Hide(); toggle.Text = "批量编辑"; entries.Add(new("", "")); Changed(); selected = entries.Count - 1; FillList(); detail.GrabFocus(); }, 90));
        toolbar.AddChild(Button("删除", () => { if (!Commit() || selected < 0) return; entries.RemoveAt(selected); Changed(); FillList(); loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }, 90));
        toggle = Button("批量编辑", () =>
        {
            if (!Commit()) return; bulkMode = !bulkMode; single.Visible = !bulkMode; bulkBox.Visible = bulkMode;
            toggle.Text = bulkMode ? "单条编辑" : "批量编辑";
            if (bulkMode) { loading = true; bulk.Text = EventPools.BulkText(category, entries); loading = false; }
            else FillList();
        }, 145); toggle.Name = "TogglePoolBulk"; toolbar.AddChild(toggle);
        var save = Button("保存事件池", () =>
        {
            if (!Commit()) return;
            var previous = data.Ai.EventPoolOverrides.GetValueOrDefault(template);
            try
            {
                EventPools.Save(data.Ai, drafts, template); SaveAiSettings(data); dirty = false;
                var current = EventPools.Get(data.Ai);
                status.Text = $"已保存 · 随机事件 {current.Random.Length} 条 · 选手日常 {current.DailyCount} 条" + (current.RandomUsesDefault ? " · 随机事件全部为空，使用内置池" : "");
            }
            catch (Exception error)
            {
                if (previous == null) data.Ai.EventPoolOverrides.Remove(template); else data.Ai.EventPoolOverrides[template] = previous;
                status.Text = error is ArgumentException ? error.Message : "未能保存，请检查配置文件夹的写入权限。";
            }
        }, 170); save.Name = "SaveEventPools"; actions.AddChild(save);
        actions.AddChild(Button("恢复当前分类默认", () => ShowCareerDialog("恢复分类默认", "恢复后，该分类将跟随内置内容更新。", () =>
        { drafts.Remove(category); dirty = true; ShowCategory(); status.Text = "已恢复默认，保存后生效。"; return true; }), 220));
        actions.AddChild(Button("返回提示词配置", () =>
        {
            if (dirty) ShowCareerDialog("返回提示词配置", "事件池还有未保存的编辑，放弃这些编辑并返回？", () => { shade.QueueFree(); return true; }, "放弃并返回");
            else shade.QueueFree();
        }, 200));
        ShowCategories(false); ShowCategory();
    }
}
