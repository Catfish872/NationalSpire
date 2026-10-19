using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void AffectionSettings(CareerData data)
    {
        var panel = Card(); _content.AddChild(panel); var box = Inner(panel);
        box.AddChild(Text("攻略难度", 24, _gold));
        var modes = new[] { RomanceDifficulty.Charming, RomanceDifficulty.Natural, RomanceDifficulty.Reserved, RomanceDifficulty.Insulated };
        var picker = new OptionButton { Name = "RomanceDifficulty", CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        foreach (var mode in modes) picker.AddItem(AffectionRules.Name(mode) + (mode == RomanceDifficulty.Natural ? " · 默认" : ""));
        picker.Disabled = _multiplayer is { Host: false };
        picker.Select(Array.IndexOf(modes, AffectionRules.Mode(data))); box.AddChild(picker);
        var detailRow = new HBoxContainer { Name = "AffectionDescriptionRow" }; detailRow.AddThemeConstantOverride("separation", 24); box.AddChild(detailRow);
        var description = Text(AffectionRules.Description(AffectionRules.Mode(data)), 16, _muted);
        description.Name = "AffectionDescription"; description.SizeFlagsHorizontal = SizeFlags.ExpandFill; description.SizeFlagsVertical = SizeFlags.ShrinkCenter; detailRow.AddChild(description);
        var linked = new CheckBox { Name = "AffectionLinkedClearChance", Text = "将NPC通关率与好感挂钩", ButtonPressed = data.AffectionLinkedClearChance,
            Disabled = _multiplayer is { Host: false }, SizeFlagsHorizontal = SizeFlags.ShrinkEnd, SizeFlagsVertical = SizeFlags.ShrinkCenter };
        linked.TooltipText = "队友好感影响训练、交流成长及通关率；其他俱乐部角色的正向好感会降低其通关率。联机采用对该NPC好感最高的玩家。";
        detailRow.AddChild(linked);
        box.AddChild(Text("对本生涯后续交互生效；已发送的私聊沿发送时难度结算。已有好感保留。" + (_multiplayer != null ? "由房主设置，全队共用。" : ""), 15, _muted));
        linked.Toggled += value =>
        {
            if (_multiplayer != null)
            {
                linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance);
                _multiplayer.Send("affection-clear-chance", number: value ? 1 : 0, accepted: () =>
                { _multiplayer.Refresh(); if (IsInstanceValid(linked)) linked.SetPressedNoSignal(ViewData.AffectionLinkedClearChance); });
                return;
            }
            bool previous = data.AffectionLinkedClearChance; AffectionCompetition.Set(data, value);
            try { CareerStore.Save(data); }
            catch (Exception e) { AffectionCompetition.Set(data, previous); linked.SetPressedNoSignal(previous); Notice("保存失败：" + e.Message, true); }
        };
        picker.ItemSelected += index =>
        {
            var mode = modes[(int)index];
            if (_multiplayer != null)
            {
                picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData)));
                _multiplayer.Send("romance-difficulty", number: (int)mode, accepted: () =>
                { _multiplayer.Refresh(); if (IsInstanceValid(picker)) { picker.Select(Array.IndexOf(modes, AffectionRules.Mode(ViewData))); description.Text = AffectionRules.Description(AffectionRules.Mode(ViewData)); } });
                return;
            }
            var previous = data.RomanceDifficulty; data.RomanceDifficulty = mode;
            try { CareerStore.Save(data); description.Text = AffectionRules.Description(mode); Notice("攻略难度已保存。", false); }
            catch (Exception e) { data.RomanceDifficulty = previous; picker.Select(Array.IndexOf(modes, previous)); Notice("保存失败：" + e.Message, true); }
        };
    }
}
