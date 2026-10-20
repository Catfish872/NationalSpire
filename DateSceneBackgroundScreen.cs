using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenDateBackgroundLibrary(CareerData data, string person)
    {
        var items = DateSceneBackgrounds.Read(out string warning); string selected = items.FirstOrDefault()?.Id ?? "";
        Button remove = null!;
        OptionButton choices = null!; TextEdit description = null!; Label status = null!; TextureRect preview = null!; Texture2D? texture = null;
        void Commit()
        {
            var item = items.FirstOrDefault(i => i.Id == selected); if (item == null) return;
            if (item.Description == description.Text.Trim()) return;
            DateSceneBackgrounds.Describe(selected, description.Text); item.Description = description.Text.Trim();
        }
        void Preview()
        {
            preview.Texture = null; texture?.Dispose(); texture = null;
            var item = items.FirstOrDefault(i => i.Id == selected); description.Editable = item != null; description.Text = item?.Description ?? "";
            if (item == null) return;
            try { texture = DateSceneView.CreateBackground(item.Image); preview.Texture = texture; }
            catch (Exception e) { status.Text = e.Message; }
        }
        void Choices()
        {
            choices.Clear(); foreach (var item in items) choices.AddItem(item.Id);
            if (!items.Any(i => i.Id == selected)) selected = items.FirstOrDefault()?.Id ?? "";
            choices.Disabled = remove.Disabled = items.Count == 0;
            if (items.Count == 0) { choices.AddItem("请导入背景图片或ZIP背景包"); choices.Select(0); }
            else choices.Select(items.FindIndex(i => i.Id == selected)); Preview();
        }
        ShowCareerDialog("背景库", "各角色共用。文件名作为背景ID，说明可填写地点、室内外、时间和天气，供场景匹配使用。", () =>
        {
            try { Commit(); } catch (Exception e) { status.Text = e.Message; return false; }
            Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateAssets(data, person); }).CallDeferred(); return true;
        }, "返回立绘与场景", box =>
        {
            box.Name = "DateBackgroundLibrary"; box.CustomMinimumSize = new(820, 0);
            var import = Button("导入背景图片 / 背景包 ZIP", () =>
            {
                try { Commit(); } catch (Exception e) { status.Text = e.Message; return; }
                PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>
                {
                    try { selected = DateSceneBackgrounds.Import(path); items = DateSceneBackgrounds.Read(out string issues); status.Text = issues.Length > 0 ? issues : "导入完成。可填写背景说明。"; Choices(); }
                    catch (Exception e) { status.Text = "导入失败：" + e.Message; }
                });
            }, 360); import.Name = "DateBackgroundImport";
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); box.AddChild(actions); actions.AddChild(import);
            remove = Button("删除所选背景", () =>
            {
                try { DateSceneBackgrounds.Remove(selected); items = DateSceneBackgrounds.Read(out _); status.Text = "所选背景已从背景库移除。"; Choices(); }
                catch (Exception e) { status.Text = e.Message; }
            }, 220); remove.Name = "DateBackgroundDelete"; actions.AddChild(remove);
            choices = new OptionButton { Name = "DateBackgroundLibraryChoice", CustomMinimumSize = new(0, 44), FitToLongestItem = false }; box.AddChild(choices);
            preview = new TextureRect { CustomMinimumSize = new(0, 180), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }; box.AddChild(preview);
            description = new TextEdit { Name = "DateBackgroundDescription", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary, PlaceholderText = "例如：海边步道，傍晚，夕阳，晴天，室外" }; box.AddChild(description);
            choices.ItemSelected += index => { try { Commit(); selected = items[(int)index].Id; Preview(); } catch (Exception e) { status.Text = e.Message; } };
            status = Text(warning, 15, _muted); box.AddChild(status); Choices();
        }, showCancel: false);
        if (_dialogOverlay != null) _dialogOverlay.TreeExiting += () => { texture?.Dispose(); texture = null; };
    }
}
