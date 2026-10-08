using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void RenderTeamPreparations(CareerData data)
    {
        foreach (var competition in TeamPreparations.Available(data))
        {
            var card = Card(); card.Name = "TeamPreparationCard"; _content.AddChild(card); var box = Inner(card);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 22); box.AddChild(row);
            var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);
            words.AddChild(Text("集体备赛 · " + competition.Name, 23, _gold));
            words.AddChild(Text("AI队友通关率 +16% · 持续3轮 · 与临时训练取较高值", 17, _muted));
            var current = data.TeamPreparations.FirstOrDefault(p => p.CompetitionId == competition.Id && p.Remaining > 0);
            var button = Button(current == null ? "安排备赛 " + CareerMoney.Format(TeamPreparations.Cost) : "备赛生效 · 剩余" + current.Remaining + "轮", () =>
            {
                if (MultiplayerCommand("team-preparation", competition.Id)) return;
                var error = TeamPreparations.Buy(data, competition.Id); CareerStore.Save(data); Render(); if (error != null) Notice(error, true);
            }, 265);
            button.Disabled = current != null; row.AddChild(button);
        }
    }
}
