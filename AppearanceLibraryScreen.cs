using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void BuildAppearanceLibrary(VBoxContainer parent, CareerData data, string person,
        Action<(PortraitDesign Design, DateSceneAssets Assets)> applied, Action<string, Action>? importPackage = null)
    {
        var panel = new PanelContainer(); panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232f", "365664", 12, 14)); parent.AddChild(panel);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 20); panel.AddChild(row);
        var preview = new TextureRect { Name = "AppearancePreview", CustomMinimumSize = new(112, 154),
            ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered };
        row.AddChild(preview);
        var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 8); row.AddChild(body);
        body.AddChild(Text("形象包库", 21, _gold));
        var choices = new OptionButton { Name = "AppearancePackages", FitToLongestItem = false, CustomMinimumSize = new(0, 42) }; body.AddChild(choices);
        var info = Text("选择形象包后预览；导入的形象包可供其他角色直接使用。", 15, _muted); body.AddChild(info);
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); body.AddChild(actions);
        AppearanceLibrary.Entry[] entries = []; AppearanceLibrary.Package? selected = null;
        var apply = Button("应用到当前角色", () =>
        {
            if (selected == null || !CareerStore.IsCurrent(data)) return;
            try { applied(AppearanceLibrary.Apply(data, person, selected)); info.Text = "已应用 · " + selected.Name; }
            catch (Exception e) { info.Text = "应用失败：" + e.Message; }
        }, 190); apply.Name = "AppearanceApply"; apply.Disabled = true; actions.AddChild(apply);
        void Select(int index)
        {
            selected = null; apply.Disabled = true; preview.Texture?.Dispose(); preview.Texture = null;
            if (index == 0) return;
            try
            {
                selected = AppearanceLibrary.Load(data, entries[index - 1]);
                if (AppearanceLibrary.Preview(selected) is { } hash) preview.Texture = DateSceneAssetStore.Texture(hash);
                info.Text = $"{selected.Outfits.Count}套服装 · {selected.Outfits.Values.Sum(s => s.Count)}张立绘 · 可供所有存档选择";
                apply.Disabled = false;
            }
            catch (Exception e) { info.Text = "读取失败：" + e.Message; }
        }
        void Refresh(string id = "")
        {
            entries = AppearanceLibrary.List(); choices.Clear(); choices.AddItem("选择已保存的形象包");
            foreach (var entry in entries) choices.AddItem(entry.Name + (entry.BuiltIn ? " · 内置" : ""));
            int index = Array.FindIndex(entries, e => e.Id == id) + 1; choices.Select(index); Select(index);
        }
        choices.ItemSelected += index => Select((int)index);
        actions.AddChild(Button(importPackage == null ? "导入并保存形象包" : "导入角色 / 立绘包", () => PickNestedFile("导入角色形象包", [".zip"], path =>
        {
            if (!CareerStore.IsCurrent(data)) return;
            if (importPackage != null)
            {
                Callable.From(() => { if (IsInstanceValid(info)) importPackage(path, () =>
                {
                    try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); }
                    catch (Exception e) { info.Text = "立绘已导入，形象库保存失败：" + e.Message; }
                }); }).CallDeferred(); return;
            }
            try { var entry = AppearanceLibrary.Import(data, path); Refresh(entry.Id); }
            catch (Exception e) { info.Text = "导入失败：" + e.Message; }
        }), 200));
        preview.TreeExiting += () => preview.Texture?.Dispose();
        Refresh();
    }
}
