using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private bool _datePresentationPending;
    private bool ConfigureDatePresentation(CareerData data, IReadOnlyList<string> people, Action completed, Action cancelled, bool firstOnly = true)
    {
        if (_datePresentationPending) return true;
        var targets = firstOnly ? DatePresentation.Pending(data, people) : people.Distinct().ToArray();
        if (targets.Length == 0) return false;
        if (_dialogOverlay != null) return true;
        var selections = targets.Select(p => DatePresentation.Initial(data, p, firstOnly)).ToList();
        var library = AppearanceLibrary.List(); var textures = new Dictionary<string, Texture2D>(); bool saved = false;
        Texture2D Default(string id)
        {
            string key = "default:" + IdentityGender.Of(data, id);
            if (!textures.TryGetValue(key, out var image)) textures[key] = image = DateDefaultPortraits.Texture(data, id);
            return image;
        }
        Label status = null!;
        _datePresentationPending = true;
        ShowCareerDialog(firstOnly ? "首次约会 · 立绘与播报口吻" : "立绘与播报口吻", "同一角色在单人和多人约会中共用这些选择。", () =>
        {
            try
            {
                DatePresentation.Save(data, selections); saved = true;
                return true;
            }
            catch (Exception e) { status.Text = e.Message; return false; }
        }, "确认并继续", box =>
        {
            box.Name = "DatePresentationSetup"; box.CustomMinimumSize = new(850, 0);
            var scroll = new BroadcastScroll { CustomMinimumSize = new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; rows.AddThemeConstantOverride("separation", 18); scroll.AddChild(rows);
            foreach (var selection in selections)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 20); rows.AddChild(row);
                var preview = new TextureRect { CustomMinimumSize = new(100, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, Texture = Default(selection.Person) }; row.AddChild(preview);
                var fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; fields.AddThemeConstantOverride("separation", 10); row.AddChild(fields);
                fields.AddChild(Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold));
                var art = new OptionButton { Name = "DateSetupPortrait_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }; fields.AddChild(art);
                art.AddItem(IdentityGender.Of(data, selection.Person) == "女" ? "默认女性剪影" : "默认男性剪影");
                var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person);
                var outfits = design?.Outfits.ToArray() ?? [];
                foreach (var outfit in outfits) art.AddItem("当前角色立绘 · " + outfit.Name);
                foreach (var entry in library) art.AddItem("形象包 · " + entry.Name);
                var voice = new OptionButton { Name = "DateSetupVoice_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }; fields.AddChild(voice);
                foreach (string label in DateGameVoices.Labels) voice.AddItem("对局播报 · " + label);
                voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice)));
                voice.ItemSelected += index => selection.Voice = DateGameVoices.Ids[(int)index];
                void Select(int index)
                {
                    selection.Portrait = index == 0 ? DatePresentation.Source.Default : index <= outfits.Length ? DatePresentation.Source.Current : DatePresentation.Source.Library;
                    if (selection.Portrait == DatePresentation.Source.Current) selection.Outfit = outfits[index - 1].Id;
                    if (selection.Portrait == DatePresentation.Source.Library) selection.Library = library[index - outfits.Length - 1];
                    try
                    {
                        if (index == 0) preview.Texture = Default(selection.Person);
                        else
                        {
                            var prepared = DatePresentation.Prepare(data, selection);
                            string hash = DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k]).First();
                            if (!textures.TryGetValue(hash, out var image)) textures[hash] = image = DateSceneAssetStore.Texture(hash);
                            preview.Texture = image;
                        }
                        if (status != null) status.Text = "确认后保存；下次约会沿用本次选择。";
                    }
                    catch (Exception e) { preview.Texture = Default(selection.Person); if (status != null) status.Text = e.Message; }
                }
                art.ItemSelected += index => Select((int)index);
                int current = selection.Portrait == DatePresentation.Source.Current ? Array.FindIndex(outfits, o => o.Id == selection.Outfit) + 1 : 0;
                art.Select(current); Select(current);
            }
            status = Text("确认后保存；下次约会沿用本次选择。", 16, _muted); box.AddChild(status);
        }, cancelText: "返回");
        var dialog = _dialogOverlay!;
        dialog.TreeExiting += () => Callable.From(() =>
        {
            foreach (var image in textures.Values.Distinct()) image.Dispose();
            _datePresentationPending = false;
            if (!IsInstanceValid(this) || IsQueuedForDeletion() || !CareerStore.IsCurrent(data)) return;
            if (saved) completed(); else cancelled();
        }).CallDeferred();
        return true;
    }
}
