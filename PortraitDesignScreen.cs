using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenPortraitDesigner(CareerData data, string id)
    {
        if (_dialogOverlay != null) return;
        PortraitDesign design; string path = PortraitDesignStore.FilePath(data, id);
        try { design = PortraitDesignStore.Read(path, id) ?? PortraitDesigns.Create(data, id); }
        catch (Exception e) { Notice("读取立绘设计失败：" + e.Message, true); return; }
        var person = CharacterCards.Read(data, id);
        var oldFocus = GetViewport().GuiGetFocusOwner();
        IEnumerable<Control> Controls(Node node) => node.GetChildren().SelectMany(child => (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child)));
        var focus = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToArray();
        foreach (var f in focus) f.Control.FocusMode = FocusModeEnum.None;
        var shade = new ColorRect { Name = "PortraitDesigner", Color = new(0, 0, 0, .78f), ZIndex = 40, MouseFilter = MouseFilterEnum.Stop };
        _dialogOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string side in new[] { "left", "right" }) margin.AddThemeConstantOverride("margin_" + side, 65);
        foreach (string side in new[] { "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 32);
        var panel = new PanelContainer { Name = "PortraitDesignerPanel" }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 24)); margin.AddChild(panel);
        var root = new VBoxContainer(); root.AddThemeConstantOverride("separation", 16); panel.AddChild(root);
        root.AddChild(Text("设计立绘", 26, _gold));
        var header = new HBoxContainer { Name = "PortraitIdentity", CustomMinimumSize = new(0, 89) }; header.AddThemeConstantOverride("separation", 20); root.AddChild(header);
        var avatar = Avatar(data, id, 72, false); avatar.SizeFlagsVertical = SizeFlags.ShrinkCenter; header.AddChild(avatar);
        var identity = new PrivateIdentityLayout { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }; header.AddChild(identity);
        var title = PrivateIdentityButton("PortraitName", () => { }); title.Text = person.PublicName; title.Alignment = HorizontalAlignment.Left;
        title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; title.TooltipText = person.PublicName; title.AddThemeFontSizeOverride("font_size", 28); identity.AddChild(title);
        var role = PrivateLine(person.Role + (ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : "") + "  /  " + person.Country, 14, _muted);
        role.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; identity.AddChild(role);
        root.AddChild(new HSeparator { Modulate = new Color("688498") });
        var tabs = new HBoxContainer(); tabs.AddThemeConstantOverride("separation", 14); root.AddChild(tabs);
        var scroll = new BroadcastScroll { Name = "PortraitScroll", SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; root.AddChild(scroll);
        var page = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; page.AddThemeConstantOverride("separation", 16); scroll.AddChild(page);
        var status = Text(design.Notes, 15, _muted); status.Name = "PortraitStatus"; status.MaxLinesVisible = 2; status.TooltipText = design.Notes; root.AddChild(status);
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 14); root.AddChild(actions);
        CancellationTokenSource? pending = null; bool closed = false; int selectedTab = 0;
        var idEditors = new List<Func<bool>>();
        bool Alive() => !closed && IsInstanceValid(shade) && !shade.IsQueuedForDeletion() && CareerStore.IsCurrent(data);
        void Message(string text, bool error = false) { status.Text = text; status.TooltipText = text; status.Modulate = error ? new Color("ee929d") : Colors.White; }
        bool CommitIds() { foreach (var commit in idEditors) if (!commit()) return false; return true; }
        LineEdit Field(Control parent, string label, string value, Action<string> changed, string name)
        {
            var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 7); parent.AddChild(box);
            box.AddChild(Text(label, 15, _muted));
            var input = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            input.AddThemeFontSizeOverride("font_size", 18); input.ExpandToTextLength = false; box.AddChild(input); input.TextChanged += value => changed(value); return input;
        }
        GridContainer Grid(Control parent)
        {
            var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 24); grid.AddThemeConstantOverride("v_separation", 16); parent.AddChild(grid); return grid;
        }
        void DrawPage()
        {
            if (!CommitIds()) return;
            idEditors.Clear();
            foreach (var child in page.GetChildren()) { page.RemoveChild(child); child.QueueFree(); }
            if (selectedTab == 0)
            {
                DrawPortraitStyles(page, design);
                page.AddChild(new HSeparator());
                var grid = Grid(page);
                foreach (var (key, label) in PortraitDesigns.BasicFields) Field(grid, label, design.Basics.GetValueOrDefault(key, ""), v => design.Basics[key] = v, "PortraitBasic_" + key);
            }
            else if (selectedTab == 1)
            {
                foreach (var emotion in design.Emotions)
                {
                    var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1d3344", "38586c", 7, 12)); page.AddChild(card);
                    var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 9); card.AddChild(box);
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); box.AddChild(row);
                    var enabled = new CheckBox { Name = "PortraitEnabled_" + emotion.Id, ButtonPressed = emotion.Enabled, Disabled = emotion.Id == design.DefaultEmotionId, TooltipText = emotion.Id == design.DefaultEmotionId ? "平淡差分作为基准保留" : "加入导出包" };
                    row.AddChild(enabled); enabled.Toggled += value => emotion.Enabled = value;
                    var label = new LineEdit { Name = "PortraitEmotion_" + emotion.Id, Text = emotion.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) };
                    row.AddChild(label); label.TextChanged += value => emotion.Name = value;
                    if (PortraitDesigns.CustomEmotion(emotion))
                    {
                        var code = new LineEdit { Name = "PortraitEmotionId_" + emotion.Id, Text = emotion.Id, CustomMinimumSize = new(260, 42), ExpandToTextLength = false,
                            TooltipText = "情绪ID：小写字母开头，可含数字和下划线，最长64位。回车或离开输入栏时应用；新导出的文件名和清单使用此ID。" };
                        code.AddThemeFontSizeOverride("font_size", 15); row.AddChild(code);
                        bool CommitId()
                        {
                            if (PortraitDesigns.RenameEmotion(design, emotion, code.Text) is { } error)
                            { code.Modulate = new Color("ee929d"); Message(error, true); return false; }
                            bool corrected = code.Modulate != Colors.White; code.Text = emotion.Id; code.Modulate = Colors.White;
                            if (corrected) Message("情绪ID已更新；再次导出时生成对应文件名与清单。");
                            return true;
                        }
                        idEditors.Add(CommitId); code.TextSubmitted += _ => CommitId(); code.FocusExited += () => CommitId();
                    }
                    else
                    {
                        var code = Text("ID · " + emotion.Id, 13, _muted); code.CustomMinimumSize = new(110, 0); code.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
                        code.AutowrapMode = TextServer.AutowrapMode.Off; code.TooltipText = emotion.Id; row.AddChild(code);
                    }
                    box.AddChild(Text("表情与动作", 15, _muted));
                    var description = new TextEdit { Name = "PortraitExpression_" + emotion.Id, Text = emotion.Description, CustomMinimumSize = new(0, 102),
                        SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
                    description.AddThemeFontSizeOverride("font_size", 17); box.AddChild(description); description.TextChanged += () => emotion.Description = description.Text;
                }
                var addEmotion = Button("＋ 添加情绪差分", () => { if (!CommitIds()) return; PortraitDesigns.NewEmotion(design); DrawPage(); }, 210);
                addEmotion.Name = "PortraitNewEmotion"; page.AddChild(addEmotion);
            }
            else
            {
                var selector = new HBoxContainer(); selector.AddThemeConstantOverride("separation", 12); page.AddChild(selector);
                var choice = new OptionButton { Name = "PortraitOutfitChoice", FitToLongestItem = false, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 46) };
                foreach (var item in design.Outfits) choice.AddItem(item.Name);
                int index = design.Outfits.FindIndex(o => o.Id == design.SelectedOutfit); choice.Select(index); selector.AddChild(choice);
                choice.ItemSelected += value => { design.SelectedOutfit = design.Outfits[(int)value].Id; DrawPage(); };
                var add = Button("+", () => { PortraitDesigns.NewOutfit(design); DrawPage(); }, 46); add.Name = "PortraitNewOutfit"; selector.AddChild(add);
                var outfit = design.Outfits[index];
                Field(page, "套装名称", outfit.Name, value => { outfit.Name = value; choice.SetItemText(index, value); }, "PortraitOutfitName");
                var grid = Grid(page);
                foreach (var (key, label) in PortraitDesigns.OutfitFields) Field(grid, label, outfit.Fields.GetValueOrDefault(key, ""), v => outfit.Fields[key] = v, "PortraitOutfit_" + key);
            }
        }
        var tabButtons = new List<Button>();
        foreach (string text in new[] { "基本设定", "情绪差分", "服装搭配" })
        {
            int index = tabButtons.Count; var tab = Button(text, () =>
            {
                if (!CommitIds()) return;
                selectedTab = index; for (int i = 0; i < tabButtons.Count; i++) tabButtons[i].Modulate = i == index ? CareerVisuals.Teal : Colors.White;
                scroll.ScrollVertical = 0; DrawPage();
            }, 165); tab.Name = "PortraitTab" + index; tabs.AddChild(tab); tabButtons.Add(tab);
        }
        tabButtons[0].Modulate = CareerVisuals.Teal; DrawPage();
        void Close()
        {
            if (closed) return;
            if (!CommitIds()) return;
            try { PortraitDesignStore.Save(path, design); }
            catch (Exception e) { Message("保存失败，编辑内容仍保留：" + e.Message, true); return; }
            closed = true; pending?.Cancel(); _dialogOverlay = null; _cancelDialog = null; shade.Hide(); shade.QueueFree();
            foreach (var f in focus) if (IsInstanceValid(f.Control) && !f.Control.IsQueuedForDeletion()) f.Control.FocusMode = f.Mode;
            if (IsInstanceValid(oldFocus) && oldFocus.IsInsideTree() && oldFocus.IsVisibleInTree()) oldFocus.GrabFocus();
        }
        _cancelDialog = Close;
        shade.TreeExiting += () => { closed = true; pending?.Cancel(); };
        Button? infer = null;
        async Task Infer()
        {
            if (pending != null) { pending.Cancel(); return; }
            if (!CommitIds()) return;
            var cancel = new CancellationTokenSource(); pending = cancel;
            var baseline = JsonSerializer.Deserialize<PortraitDesign>(JsonSerializer.Serialize(design, PortraitDesigns.Json), PortraitDesigns.Json)!;
            infer!.Text = "停止推测"; Message("正在结合人物资料和互动记忆推测；可继续编辑。");
            try
            {
                string response = await AiService.InferPortraitAsync(data, id, baseline, cancel.Token);
                cancel.Token.ThrowIfCancellationRequested(); if (!Alive()) return;
                int changes = PortraitDesigns.MergeInference(design, baseline, response); PortraitDesignStore.Save(path, design);
                int position = scroll.ScrollVertical; DrawPage(); scroll.ScrollVertical = position;
                Message($"已补全 {changes} 项设定；手动编辑的字段已保留。" + design.Notes);
            }
            catch (OperationCanceledException) { if (Alive()) Message("已停止推测，当前编辑已保留。"); }
            catch (Exception e) { if (Alive()) Message("推测未完成，可重试或直接编辑：" + AiService.FailureReason(e), true); }
            finally { pending = null; cancel.Dispose(); if (Alive()) infer!.Text = "根据资料推测"; }
        }
        infer = Button("根据资料推测", () => { _ = Infer(); }, 180); infer.Name = "PortraitInfer"; actions.AddChild(infer);
        actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        actions.AddChild(Button("保存并关闭", Close, 165));
        var export = Button("导出该套装提示词", () =>
        {
            if (!CommitIds()) return;
            try
            {
                PortraitDesignStore.Save(path, design);
                string destination = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                if (string.IsNullOrWhiteSpace(destination)) destination = ProjectSettings.GlobalizePath("user://portrait_exports");
                string zip = PortraitPromptExport.Write(destination, design, person.PublicName); Message("已导出：" + zip); OS.ShellShowInFileManager(zip);
            }
            catch (Exception e) { Message("导出失败，编辑内容已保留：" + e.Message, true); }
        }, 240); export.Name = "PortraitExport"; actions.AddChild(export);
    }
}
