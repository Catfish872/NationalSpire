using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void AddPrivateOath(CareerData data, PrivateRelation relation)
    {
        if (relation.OathConfirmed ? relation.OathReleaseReason.Length == 0 : !relation.Appearance.OathEligible) return;
        if (!relation.OathConfirmed && relation.OathDeferred && relation.OathPromptHidden) return;
        string person = _privatePerson;
        var card = new PanelContainer { Name = "PrivateOathPrompt" };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("243448", "bca4c4", 8, 16)); _privateBody!.AddChild(card);
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 12); card.AddChild(box);
        if (relation.OathConfirmed)
        {
            box.AddChild(PrivateText(CareerEngine.DisplayName(data, person) + "提出解除誓约", 19, new Color("f3c4da")));
            box.AddChild(PrivateSelectableText(relation.OathReleaseReason, 17, _ink));
            var reply = new TextEdit { Name = "OathReleaseReply", PlaceholderText = "写下给对方的回复…", CustomMinimumSize = new(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary };
            reply.AddThemeFontSizeOverride("font_size", 17); box.AddChild(reply);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);
            void Decide(string part) => PrivateCommand("dm-oath-release", new() { Text = reply.Text, Part = part });
            row.AddChild(PrivateButton("回复并解除誓约", () => Decide("release"), 180));
            row.AddChild(PrivateButton("回复并继续沟通", () => Decide("keep"), 180));
        }
        else if (relation.OathDeferred)
        {
            box.AddChild(PrivateText("搁置誓约：点击好感徽章后再次求婚", 19, new Color("f3c4da")));
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);
            row.AddChild(PrivateButton("重新求婚", () => PrivateCommand("dm-oath-open", new()), 140));
            row.AddChild(PrivateButton("确认收起", () => PrivateCommand("dm-oath-close", new()), 140));
        }
        else
        {
            box.AddChild(PrivateText($"是否为{CareerEngine.DisplayName(data, person)}戴上钻戒？", 19, new Color("f3c4da")));
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);
            row.AddChild(PrivateButton("确认誓约", () => PrivateCommand("dm-oath-confirm", new()), 140));
            row.AddChild(PrivateButton("暂不处理", () => PrivateCommand("dm-oath-defer", new()), 140));
        }
    }
}
