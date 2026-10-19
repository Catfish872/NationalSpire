using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenDateAssets(CareerData data, string person)
    {
        if (_dialogOverlay != null) return;
        PortraitDesign design; DateSceneAssets assets;
        try
        {
            string path = PortraitDesignStore.FilePath(data, person);
            design = PortraitDesignStore.Read(path, person) ?? PortraitDesigns.Create(data, person);
            PortraitDesignStore.Save(path, design); assets = DateSceneAssetStore.Read(data, person); assets.OutfitId = design.SelectedOutfit;
        }
        catch (Exception e) { Notice("读取立绘失败：" + e.Message, true); return; }
        VBoxContainer list = null!; Label status = null!;
        var selections = new Dictionary<string, string>();
        void Import(Action<DateSceneAssets, string> action, string[] extensions)
        {
            PickNestedFile("导入立绘", extensions, file =>
            {
                if (!CareerStore.IsCurrent(data)) return;
                try
                {
                    var copy = Coop.CoopJson.Copy(assets); action(copy, file); DateSceneAssetStore.Save(data, person, copy); assets = copy;
                    status.Text = "导入完成，编号、画布与透明通道校验通过。"; status.Modulate = Colors.White; Draw();
                }
                catch (Exception e) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("ee929d"); }
            });
        }
        void Draw()
        {
            CareerVisuals.ClearContent(list);
            var add = DateEmotionLink("新增差分", "DateNewEmotion", () => { _cancelDialog?.Invoke(); NewDateEmotion(data, person); });
            add.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; add.CustomMinimumSize = new(150, 48);
            list.AddChild(add);
            foreach (var emotion in design.Emotions.Where(e => e.Enabled))
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 15); list.AddChild(row);
                var label = DateEmotionLink(emotion.Name + " · " + emotion.Id, "EditEmotion_" + emotion.Id, () => { _cancelDialog?.Invoke(); NewDateEmotion(data, person, emotion.Id); });
                label.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                row.AddChild(label);
                var keys = DateSceneAssetStore.SpriteKeys(assets, design, emotion.Id);
                string selectionKey = design.SelectedOutfit + "/" + emotion.Id;
                var files = new OptionButton { Name = "DateSpriteFiles_" + emotion.Id, CustomMinimumSize = new(245, 48), FitToLongestItem = false };
                foreach (string key in keys) files.AddItem(key + ".png");
                if (keys.Length == 0) { files.AddItem(emotion.Id == design.DefaultEmotionId ? "请添加默认立绘" : "使用默认立绘"); files.Disabled = true; }
                int selected = Math.Max(0, Array.IndexOf(keys, selections.GetValueOrDefault(selectionKey)));
                files.Select(selected); if (keys.Length > 0) selections[selectionKey] = keys[selected];
                files.ItemSelected += index => selections[selectionKey] = keys[(int)index]; row.AddChild(files);
                var append = Button("+", () => Import((copy, file) =>
                {
                    DateSceneAssetStore.ImportOne(copy, design, emotion.Id, file, append: true);
                    selections[selectionKey] = DateSceneAssetStore.SpriteKeys(copy, design, emotion.Id).Except(keys).FirstOrDefault() ?? keys.FirstOrDefault() ?? "";
                }, [".png"]), 48);
                append.Name = "DateSpriteAdd_" + emotion.Id; append.TooltipText = "添加PNG"; append.CustomMinimumSize = new(48, 48); row.AddChild(append);
                var remove = Button("", () =>
                {
                    if (!CareerStore.IsCurrent(data) || !selections.TryGetValue(selectionKey, out string? key)) return;
                    try
                    {
                        var copy = Coop.CoopJson.Copy(assets);
                        if (!copy.Sprites.Remove(key)) return;
                        // 内容缓存可被其他套装和角色复用；只移除当前套装的选中绑定。
                        DateSceneAssetStore.Save(data, person, copy); assets = copy;
                        status.Text = "已删除 " + key + ".png"; status.Modulate = Colors.White; Draw();
                    }
                    catch (Exception e) { status.Text = "删除失败：" + e.Message; status.Modulate = new Color("ee929d"); }
                }, 48);
                remove.Name = "DateSpriteDelete_" + emotion.Id; remove.TooltipText = "删除选中的立绘";
                remove.CustomMinimumSize = new(48, 48); remove.Disabled = keys.Length == 0; row.AddChild(remove);
                foreach (var control in new Button[] { files, append, remove })
                {
                    control.AddThemeFontSizeOverride("font_size", 17);
                    foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled" })
                    {
                        var style = (StyleBox)control.GetThemeStylebox(state).Duplicate();
                        style.ContentMarginTop = style.ContentMarginBottom = 8;
                        control.AddThemeStyleboxOverride(state, style);
                    }
                }
                remove.Draw += () =>
                {
                    var center = remove.Size / 2; var color = remove.Disabled ? _muted.Darkened(.45f) : _ink;
                    Vector2 P(float x, float y) => center + new Vector2(x, y);
                    remove.DrawLine(P(-9, -7), P(9, -7), color, 1.8f, true);
                    remove.DrawPolyline([P(-4, -7), P(-4, -10), P(4, -10), P(4, -7)], color, 1.8f, true);
                    remove.DrawPolyline([P(-7, -7), P(-6, 10), P(6, 10), P(7, -7)], color, 1.8f, true);
                    remove.DrawLine(P(-2.5f, -3), P(-2.5f, 6), color, 1.5f, true);
                    remove.DrawLine(P(2.5f, -3), P(2.5f, 6), color, 1.5f, true);
                };
            }
        }
        ShowCareerDialog("立绘与场景 · " + CareerEngine.DisplayName(data, person), $"PNG画布1024×1536，包含真实透明像素。{design.DefaultEmotionId}为默认立绘；缺少的情绪使用默认差分。", () => true, "关闭", box =>
        {
            box.Name = "DateAssetManager"; box.CustomMinimumSize = new(980, 0);
            var selector = new OptionButton { Name = "DateAssetOutfit", CustomMinimumSize = new(0, 46), FitToLongestItem = false };
            foreach (var outfit in design.Outfits) selector.AddItem(outfit.Name);
            selector.Select(design.Outfits.FindIndex(o => o.Id == design.SelectedOutfit)); box.AddChild(selector);
            selector.ItemSelected += i => { design.SelectedOutfit = design.Outfits[(int)i].Id; assets.OutfitId = design.SelectedOutfit; PortraitDesignStore.Save(PortraitDesignStore.FilePath(data, person), design); DateSceneAssetStore.Save(data, person, assets); Draw(); };
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);
            actions.AddChild(Button("编辑立绘设计", () => { _cancelDialog?.Invoke(); OpenPortraitDesigner(data, person); }, 170));
            actions.AddChild(Button("背景库 / 导入背景", () => { _cancelDialog?.Invoke(); OpenDateBackgroundLibrary(data, person); }, 220));
            var scroll = new BroadcastScroll { CustomMinimumSize = new(0, 310), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list);
            status = Text("PNG可命名为proud.png或proud_1.png、proud_2.png。同情绪随机选图；ZIP可批量追加或替换同名图片。", 15, _muted); box.AddChild(status); Draw();
        }, showCancel: false);
        if (_dialogOverlay?.FindChild("CareerDialogConfirm", true, false)?.GetParent() is HBoxContainer footer)
        {
            var import = Button("导入立绘包 ZIP", () => Import((copy, file) => DateSceneAssetStore.ImportPack(copy, design, file), [".zip", ".json"]), 220);
            import.Name = "DateImportPack"; footer.AddChild(import); footer.MoveChild(import, 0);
            var export = Button("导出角色设计", async () =>
            {
                try
                {
                    var character = CharacterCards.Read(data, person);
                    var avatar = character.Avatar.Source == "auto" ? await AvatarImages.FromCharacterCardArt(this, CareerAvatars.ForPerson(data, person)) : character.Avatar;
                    if (!IsInstanceValid(status) || !CareerStore.IsCurrent(data)) return;
                    string zip = CharacterDesignPackage.Write(data, character, avatar, CharacterDesignPackage.ExportDirectory(), design, assets);
                    status.Text = "角色设计ZIP已导出，包含全部套装及立绘差分。"; status.Modulate = Colors.White; OS.ShellShowInFileManager(zip);
                }
                catch (Exception e) { if (IsInstanceValid(status)) { status.Text = "导出失败：" + e.Message; status.Modulate = new Color("ee929d"); } }
            }, 200); export.Name = "DateExportCharacterDesign"; footer.AddChild(export); footer.MoveChild(export, 1);
            var spacer = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; footer.AddChild(spacer); footer.MoveChild(spacer, 2);
        }
    }
    private static Button DateEmotionLink(string text, string name, Action action)
    {
        var button = new Button { Name = name, Text = text, Alignment = HorizontalAlignment.Left, CustomMinimumSize = new(0, 48),
            ClipText = true, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseDefaultCursorShape = CursorShape.PointingHand };
        button.AddThemeFontSizeOverride("font_size", 18);
        button.AddThemeColorOverride("font_color", CareerVisuals.Ink);
        foreach (string state in new[] { "hover", "pressed", "hover_pressed", "focus" }) button.AddThemeColorOverride("font_" + state + "_color", CareerVisuals.Teal);
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "focus" }) button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        button.MouseEntered += button.QueueRedraw; button.MouseExited += button.QueueRedraw;
        button.FocusEntered += button.QueueRedraw; button.FocusExited += button.QueueRedraw;
        button.Draw += () =>
        {
            var font = button.GetThemeFont("font"); float width = Math.Min(button.Size.X, font.GetStringSize(button.Text, fontSize: 18).X);
            float y = (button.Size.Y - font.GetHeight(18)) / 2 + font.GetAscent(18) + 2;
            button.DrawLine(new(0, y), new(width, y), button.IsHovered() || button.HasFocus() ? CareerVisuals.Teal : CareerVisuals.Ink, 1, true);
        };
        button.Pressed += action; return button;
    }
    private void NewDateEmotion(CareerData data, string person, string existing = "")
    {
        LineEdit id = null!, name = null!; TextEdit detail = null!; Label error = null!;
        var original = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)?.Emotions.FirstOrDefault(e => e.Id == existing);
        ShowCareerDialog(existing.Length == 0 ? "新增情绪差分" : "编辑情绪差分", "修改名称与表现说明；更换ID时同步保留各套装中的立绘。默认差分的ID也可修改，回退映射会同步更新。", () =>
        {
            try
            {
                var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person) ?? PortraitDesigns.Create(data, person);
                var assets = DateSceneAssetStore.Read(data, person);
                var emotion = existing.Length == 0 ? PortraitDesigns.NewEmotion(design) : design.Emotions.Single(e => e.Id == existing);
                var previous = Coop.CoopJson.Copy(design);
                if (PortraitDesigns.RenameEmotion(design, emotion, id.Text) is { } issue) { error.Text = issue; return false; }
                emotion.Name = name.Text.Trim(); emotion.Description = detail.Text.Trim();
                if (PortraitDesigns.Error(design) is { } invalid) { error.Text = invalid; return false; }
                DateSceneAssetStore.SaveEmotionEdit(data, person, previous, design, assets, existing, emotion.Id); return true;
            }
            catch (Exception e) { error.Text = e.Message; return false; }
        }, "保存差分", box =>
        {
            id = new LineEdit { Name = "DateEmotionId", PlaceholderText = "情绪ID，例如 curious", CustomMinimumSize = new(0, 42) }; box.AddChild(id);
            name = new LineEdit { Name = "DateEmotionName", PlaceholderText = "情绪名称，例如 好奇", CustomMinimumSize = new(0, 42) }; box.AddChild(name);
            detail = new TextEdit { Name = "DateEmotionDescription", PlaceholderText = "表情变化与符合角色习惯的简单动作", CustomMinimumSize = new(0, 140), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(detail);
            error = Text("", 16, new Color("ee929d")); box.AddChild(error);
            if (original != null) { id.Text = original.Id; name.Text = original.Name; detail.Text = original.Description; }
        });
        if (_dialogOverlay != null) _dialogOverlay.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred();
    }
}
