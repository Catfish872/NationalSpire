using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control? _promptOverlay;
    private void OpenPromptSettings(CareerData data)
    {
        if (_promptOverlay != null) return;
        var drafts = PromptLibrary.Sections.ToDictionary(s => s.Id, s => PromptLibrary.Get(data.Ai, s.Id));
        string selected = "world";
        var shade = new ColorRect { Name = "PromptEditor", Color = new Color(0, 0, 0, .82f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 20 };
        _promptOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (var edge in new[] { "left", "right" }) margin.AddThemeConstantOverride("margin_" + edge, 90);
        foreach (var edge in new[] { "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 60);
        var panel = Card(); margin.AddChild(panel); var box = Inner(panel);
        box.AddChild(Text("提示词配置", 28, _gold));
        box.AddChild(Text("调整世界观与写作风格。回复格式、人物资料和历史记忆仍由模组管理。", 16, _muted));
        var templateTabs = new HBoxContainer(); templateTabs.AddThemeConstantOverride("separation", 12); box.AddChild(templateTabs);
        var templateNote = Text("", 16, _muted); box.AddChild(templateNote);
        var tabs = new HFlowContainer(); tabs.AddThemeConstantOverride("h_separation", 12); tabs.AddThemeConstantOverride("v_separation", 12); box.AddChild(tabs);
        var state = Text("", 16, CareerVisuals.Teal); box.AddChild(state);
        var editor = new TextEdit { Name = "PromptText", SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 300), WrapMode = TextEdit.LineWrappingMode.Boundary };
        editor.AddThemeFontSizeOverride("font_size", 18); box.AddChild(editor);
        var count = Text("", 14, _muted); box.AddChild(count);
        var buttons = new Dictionary<string, Button>();
        var templatePicker = new OptionButton { Name = "PromptTemplatePicker", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(280, 50) };
        templateTabs.AddChild(templatePicker);
        Button deleteTemplate = null!;
        bool loading = false;
        void Show()
        {
            loading = true; editor.Text = drafts[selected]; loading = false;
            var template = PromptLibrary.Template(data.Ai);
            deleteTemplate.Visible = PromptLibrary.CanDeleteTemplate(data.Ai, template.Id);
            templateNote.Text = template.Description;
            state.Text = template.Name + " / " + (PromptLibrary.IsCustom(data.Ai, selected) ? "已保存修改" : "使用模板原文");
            count.Text = $"{editor.Text.Length} 字 · 保存后用于后续生成，已发出的请求保持原样。";
            foreach (var pair in buttons) pair.Value.SetPressedNoSignal(pair.Key == selected);
            templatePicker.Clear();
            foreach (var item in PromptLibrary.AvailableTemplates(data.Ai)) { templatePicker.AddItem(item.Name); if (item.Id == template.Id) templatePicker.Select(templatePicker.ItemCount - 1); }
        }
        void SaveDrafts()
        {
            foreach (var section in PromptLibrary.Sections)
                if (drafts[section.Id] != PromptLibrary.Get(data.Ai, section.Id)) PromptLibrary.Save(data.Ai, section.Id, drafts[section.Id]);
        }
        bool ChangeTemplate(Action change, string message, bool saveDrafts = true)
        {
            string previousTemplate = data.Ai.PromptTemplate;
            var previous = new Dictionary<string, string>(data.Ai.PromptOverrides);
            var banks = data.Ai.PromptTemplateOverrides.ToDictionary(p => p.Key, p => new Dictionary<string, string>(p.Value));
            var custom = new Dictionary<string, CustomPromptTemplate>(data.Ai.CustomPromptTemplates ?? new());
            try
            {
                if (saveDrafts) SaveDrafts();
                change(); SaveAiSettings(data);
                foreach (var section in PromptLibrary.Sections) drafts[section.Id] = PromptLibrary.Get(data.Ai, section.Id);
                Show(); count.Text = message; return true;
            }
            catch (Exception e)
            {
                data.Ai.PromptTemplate = previousTemplate; data.Ai.PromptOverrides = previous;
                data.Ai.PromptTemplateOverrides = banks; data.Ai.CustomPromptTemplates = custom;
                count.Text = e is ArgumentException ? e.Message : "未能保存，请检查存档文件夹的写入权限。";
                return false;
            }
        }
        templatePicker.ItemSelected += index =>
        {
            var available = PromptLibrary.AvailableTemplates(data.Ai);
            var template = available[(int)index];
            templatePicker.Select(available.ToList().FindIndex(t => t.Id == PromptLibrary.TemplateId(data.Ai)));
            if (PromptLibrary.TemplateId(data.Ai) == template.Id) return;
            ShowCareerDialog("切换提示词模板", $"保存当前编辑并切换到“{template.Name}”？", () =>
                ChangeTemplate(() => PromptLibrary.SelectTemplate(data.Ai, template.Id), "模板已切换。"));
        };
        templateTabs.AddChild(Button("新增模板", () =>
        {
            var available = PromptLibrary.AvailableTemplates(data.Ai);
            LineEdit name = null!; OptionButton basis = null!; Label error = null!;
            ShowCareerDialog("新增提示词模板", "复制基础模板的当前内容，独立保存。", () =>
            {
                try { PromptLibrary.ValidateTemplateName(data.Ai, name.Text); }
                catch (ArgumentException e) { error.Text = e.Message; return false; }
                bool saved = ChangeTemplate(() => PromptLibrary.CreateTemplate(data.Ai, name.Text, available[basis.Selected].Id), "模板已创建，正在编辑新模板。");
                if (!saved) { error.Text = count.Text; error.Show(); }
                return saved;
            }, "创建并使用", contents: contents =>
            {
                contents.AddChild(Text("基础模板", 18, _ink));
                basis = new OptionButton { Name = "NewPromptTemplateBase", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 50) };
                foreach (var item in available) basis.AddItem(item.Name);
                basis.Select(available.ToList().FindIndex(t => t.Id == PromptLibrary.TemplateId(data.Ai))); contents.AddChild(basis);
                contents.AddChild(Text("新模板名称", 18, _ink));
                name = new LineEdit { Name = "NewPromptTemplateName", PlaceholderText = "输入模板名称", MaxLength = 40, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 50) };
                contents.AddChild(name); error = Text("", 16, new Color("ef777d")); contents.AddChild(error);
            });
        }, 180));
        deleteTemplate = Button("删除模板", () =>
        {
            string id = PromptLibrary.TemplateId(data.Ai);
            if (!PromptLibrary.CanDeleteTemplate(data.Ai, id)) return;
            var template = PromptLibrary.Template(data.Ai);
            string fallback = PromptLibrary.Templates.Single(t => t.Id == PromptLibrary.DeletionFallback(data.Ai, id)).Name;
            Label error = null!;
            ShowCareerDialog("删除模板", "", () =>
            {
                bool saved = ChangeTemplate(() => PromptLibrary.DeleteTemplate(data.Ai, id), "模板已删除，已切换到“" + fallback + "”。", false);
                if (!saved) { error.Text = count.Text; error.Show(); }
                return saved;
            }, "确认删除", contents: contents =>
            {
                contents.AddChild(Text(template.Name, 22, _ink));
                contents.AddChild(Text("删除后无法恢复，将切换至「" + fallback + "」。", 17, _muted));
                error = Text("", 16, new Color("ef777d")); error.Hide(); contents.AddChild(error);
            }, compact: true);
        }, 160);
        deleteTemplate.Name = "DeletePromptTemplate";
        deleteTemplate.AddThemeColorOverride("font_color", new Color("eea3ab"));
        templateTabs.AddChild(deleteTemplate);
        editor.TextChanged += () => { if (!loading) { drafts[selected] = editor.Text; count.Text = $"{editor.Text.Length} 字 · 修改尚未保存"; } };
        foreach (var section in PromptLibrary.Sections)
        {
            string id = section.Id;
            var button = Button(section.Name, () => { selected = id; Show(); }, 145);
            button.ToggleMode = true; buttons[id] = button; tabs.AddChild(button);
        }
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);
        void Confirm(string title, string question, Action action) => ShowCareerDialog(title, question, () => { action(); return true; });
        actions.AddChild(Button("保存修改", () => Confirm("保存提示词", "保存所有场景的修改？修改后将用于后续生成。", () =>
        {
            var previous = new Dictionary<string, string>(data.Ai.PromptOverrides);
            try
            {
                SaveDrafts();
                SaveAiSettings(data); Show(); count.Text = "提示词已保存。";
            }
            catch (Exception e) { data.Ai.PromptOverrides = previous; count.Text = e is ArgumentException ? e.Message : "未能保存，请检查存档文件夹的写入权限。"; }
        }), 180));
        actions.AddChild(Button("恢复当前项默认", () => Confirm("恢复默认提示词", "恢复当前模板的原文？此项修改将被清除。", () =>
        {
            string id = selected; var previous = new Dictionary<string, string>(data.Ai.PromptOverrides);
            try { PromptLibrary.Reset(data.Ai, id); SaveAiSettings(data); drafts[id] = PromptLibrary.Get(data.Ai, id); Show(); count.Text = "当前项已恢复默认。"; }
            catch { data.Ai.PromptOverrides = previous; count.Text = "未能保存，请检查存档文件夹的写入权限。"; }
        }), 220));
        actions.AddChild(Button("测试当前编辑", () => OpenPromptTest(data, shade, drafts, selected), 190));
        void CloseEditor() { _promptOverlay = null; shade.QueueFree(); }
        actions.AddChild(Button("返回设置", () =>
        {
            bool dirty = PromptLibrary.Sections.Any(s => drafts[s.Id] != PromptLibrary.Get(data.Ai, s.Id));
            if (dirty) Confirm("放弃未保存修改", "还有未保存的修改，直接返回设置？", CloseEditor);
            else CloseEditor();
        }, 180));
        var transfer = new HBoxContainer(); transfer.AddThemeConstantOverride("separation", 12); box.AddChild(transfer);
        transfer.AddChild(Button("导出到桌面", () =>
        {
            try
            {
                string path = PromptTransfer.WriteDesktop(PromptTransfer.Export(data.Ai, drafts));
                count.Text = "已导出当前模板及全部场景（包括未保存的编辑）。";
                // 只打开文件所在位置，不执行导出的内容。
                var result = OS.ShellShowInFileManager(path);
                if (result != Error.Ok) count.Text = "导出成功，文件位于 " + path;
            }
            catch (Exception e) { count.Text = e is ArgumentException ? e.Message : "导出失败，请检查桌面文件夹的写入权限。"; }
        }, 200));
        transfer.AddChild(Button("导入 JSON", () => OpenPromptImport(data, () =>
        {
            foreach (var section in PromptLibrary.Sections) drafts[section.Id] = PromptLibrary.Get(data.Ai, section.Id);
            Show(); count.Text = "提示词已导入并保存。";
        }), 190));
        Show();
    }

    private void OpenPromptImport(CareerData data, Action imported)
        => OpenFilePicker("选择提示词 JSON", [".json"], path => ConfirmPromptImport(data, path, imported));

    private void ConfirmPromptImport(CareerData data, string path, Action imported)
    {
        PromptTransfer.Bundle bundle;
        try { bundle = PromptTransfer.Read(File.ReadAllText(path)); }
        catch (Exception e)
        {
            ShowCareerDialog("无法导入提示词", e is ArgumentException ? e.Message : "文件不是有效的提示词 JSON，请重新选择。", () => true, "知道了");
            return;
        }
        Label preview = null!;
        string? destination = PromptLibrary.TemplateId(data.Ai);
        ShowCareerDialog("导入提示词", "选择需要覆盖的模板。导入将替换目标模板的全部场景，并保存；当前未保存的编辑会丢弃。", () =>
        {
            string oldTemplate = data.Ai.PromptTemplate;
            var old = new Dictionary<string, string>(data.Ai.PromptOverrides);
            var banks = data.Ai.PromptTemplateOverrides.ToDictionary(p => p.Key, p => new Dictionary<string, string>(p.Value));
            var custom = new Dictionary<string, CustomPromptTemplate>(data.Ai.CustomPromptTemplates ?? new());
            try { PromptTransfer.Apply(data.Ai, bundle, destination); SaveAiSettings(data); imported(); return true; }
            catch
            {
                data.Ai.PromptTemplate = oldTemplate; data.Ai.PromptOverrides = old; data.Ai.PromptTemplateOverrides = banks; data.Ai.CustomPromptTemplates = custom;
                preview.Text = "导入未保存，请检查存档文件夹的写入权限。"; return false;
            }
        }, contents: box =>
        {
            string template = bundle.CustomTemplate?.Name ?? PromptLibrary.Templates.Single(t => t.Id == bundle.Template).Name;
            preview = Text($"{Path.GetFileName(path)}\n{template} · {bundle.Sections.Count} 个场景 · {bundle.Sections.Count(p => !p.Value.FollowDefault)} 项自定义", 17, _muted); box.AddChild(preview);
            box.AddChild(Text("导入到", 18, _ink));
            var targets = PromptLibrary.AvailableTemplates(data.Ai).ToList();
            var picker = new OptionButton { Name = "PromptImportTarget", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            foreach (var target in targets) picker.AddItem(target.Name);
            picker.AddItem("使用文件中的模板（" + template + "）");
            picker.Select(targets.FindIndex(t => t.Id == destination));
            picker.ItemSelected += index => destination = index < targets.Count ? targets[(int)index].Id : null;
            box.AddChild(picker);
        }, confirmText: "导入并保存");
    }
}
