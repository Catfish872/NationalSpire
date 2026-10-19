using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void DrawPortraitStyles(VBoxContainer parent, PortraitDesign design)
    {
        design.ModelConstraints ??= [];
        var body = new VBoxContainer { Name = "PortraitModelConstraints", Visible = false };
        body.AddThemeConstantOverride("separation", 10);
        Button toggle = null!;
        toggle = Button("画风调试与噪点控制  ▾", () => { body.Visible = !body.Visible; toggle.Text = body.Visible ? "画风调试与噪点控制  ▴" : "画风调试与噪点控制  ▾"; }, 300);
        toggle.Name = "PortraitStyleToggle"; toggle.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; parent.AddChild(toggle); parent.AddChild(body);
        body.AddChild(Text("选择绘制模型并调整约束；参考图片与画风要求在外部生图对话中上传。", 15, _muted));
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); body.AddChild(row);
        var choice = new OptionButton { Name = "PortraitModelChoice", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) };
        foreach (var model in PortraitModelPrompts.Models) choice.AddItem(model.Name);
        int index = Array.FindIndex(PortraitModelPrompts.Models, m => m.Id == design.PromptModel);
        choice.Select(Math.Max(0, index)); if (index < 0) design.PromptModel = PortraitModelPrompts.Models[0].Id;
        row.AddChild(choice);
        var input = new TextEdit { Name = "PortraitModelPrompt", Text = PortraitModelPrompts.Get(design), CustomMinimumSize = new(0, 220), WrapMode = TextEdit.LineWrappingMode.Boundary };
        input.AddThemeFontSizeOverride("font_size", 17); body.AddChild(input);
        input.TextChanged += () => design.ModelConstraints[design.PromptModel] = input.Text;
        choice.ItemSelected += selected => { design.PromptModel = PortraitModelPrompts.Models[(int)selected].Id; input.Text = PortraitModelPrompts.Get(design); };
        row.AddChild(Button("恢复该模型预设", () => { design.ModelConstraints.Remove(design.PromptModel); input.Text = PortraitModelPrompts.Default(design.PromptModel); }, 190));
    }
}
