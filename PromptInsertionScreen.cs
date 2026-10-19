using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenPromptInsertions(string scene)
    {
        var settings = PromptInsertions.Settings;
        string title = scene switch { "group" => "群聊", "community" => "社区", "date" => "约会场景", _ => "私聊" };
        ShowCareerDialog("提示词插入 · " + title, "四段文字和位置共用；勾选仅对当前输入场景生效。编辑内容自动保存。", () => true, "关闭", box =>
        {
            box.Name = "PromptInsertionDialog";
            box.CustomMinimumSize = new(Math.Clamp(_stage.Size.X - 150, 900, 1260), 0);
            var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddThemeConstantOverride("separation", 14); box.AddChild(row);
            var status = Text("", 15, _muted); box.AddChild(status);
            var timer = new Godot.Timer { OneShot = true, WaitTime = .4 }; box.AddChild(timer);
            bool dirty = false;
            void Save()
            {
                if (!dirty) return;
                try { PromptInsertions.Save(); dirty = false; status.Text = "已保存"; }
                catch (Exception e) { status.Text = "保存失败：" + e.Message; Notice(status.Text, true); }
            }
            void Changed() { dirty = true; status.Text = "保存中…"; timer.Start(); }
            timer.Timeout += Save; box.TreeExiting += Save;
            for (int i = 0; i < 4; i++)
            {
                int slot = i; var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 };
                column.AddThemeConstantOverride("separation", 10); row.AddChild(column); column.AddChild(Text("提示词 " + (i + 1), 18, _ink));
                var editor = new TextEdit { Name = "PromptInsertionText" + i, Text = settings.Slots[i].Text, PlaceholderText = "输入或粘贴提示词…",
                    CustomMinimumSize = new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420)), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
                editor.AddThemeFontSizeOverride("font_size", 17); column.AddChild(editor);
                var options = new HBoxContainer(); options.AddThemeConstantOverride("separation", 4); column.AddChild(options);
                var enabled = new CheckBox { Name = "PromptInsertionEnabled" + i, ButtonPressed = settings.Enabled[scene][i], TooltipText = "应用于" + title,
                    CustomMinimumSize = new(26, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter };
                foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled" })
                    enabled.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 });
                options.AddChild(enabled);
                var position = new OptionButton { Name = "PromptInsertionPosition" + i, SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false };
                position.AddThemeFontSizeOverride("font_size", 15); foreach (string label in PromptInsertions.Positions) position.AddItem(label);
                position.Select(settings.Slots[i].Position); options.AddChild(position);
                editor.TextChanged += () => { settings.Slots[slot].Text = editor.Text; Changed(); };
                enabled.Toggled += value => { settings.Enabled[scene][slot] = value; Changed(); };
                position.ItemSelected += value => { settings.Slots[slot].Position = (int)value; Changed(); };
            }
        }, showCancel: false);
    }
}
