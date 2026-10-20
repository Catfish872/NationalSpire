using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _developmentCountry = "", _developmentIndicator = "industry";
    private void DevelopmentScreen(CareerData d)
    {
        if (_developmentCountry.Length == 0) _developmentCountry = d.Esports.Country;
        var columns = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _content.AddChild(columns);
        var nations = new VBoxContainer { CustomMinimumSize = new(160, 0) }; columns.AddChild(nations);
        nations.AddChild(Text("国运排名", 20, _gold));
        int rank = 0;
        foreach (var row in CircuitLedger.NationTable(d))
        {
            rank++; string country = row.Country;
            nations.AddChild(FilterButton($"{rank:00}  {country}\n{row.Points:N0}", country == _developmentCountry, () => { _developmentCountry = country; Render(); }, 160));
        }
        var main = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; columns.AddChild(main);
        var nation = d.Esports.Nations.First(n => n.Country == _developmentCountry);
        var header = Card(); main.AddChild(header); var body = Inner(header);
        body.AddChild(Text(nation.Country + " / 国家发展", 32, _gold));
        var metrics = new HBoxContainer(); body.AddChild(metrics);
        foreach (var (title, value) in new[] { ("人均GDP / 年", $"${nation.Gdp:N0}"), ("本季贡献", NationalDevelopment.SeasonFortune(d, nation.Country, d.Season).ToString("N0")), ("经济增长", $"{nation.GdpGrowth:+0.0%;-0.0%;0.0%}"), ("维护资金", nation.MaintenanceFunding + " / 120") })
        {
            var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; metrics.AddChild(box);
            box.AddChild(Text(title, 15, _muted)); box.AddChild(Text(value, 27, CareerVisuals.Teal));
        }
        var groups = new HBoxContainer(); main.AddChild(groups);
        foreach (var group in NationalDevelopment.All.GroupBy(i => i.Group))
        {
            var card = Card(); groups.AddChild(card); var box = Inner(card); box.AddChild(Text(group.Key, 24, _gold));
            foreach (var indicator in group)
            {
                int level = NationalDevelopment.Level(nation, indicator.Id);
                var button = FilterButton(indicator.Name + $"  {level:00}", _developmentIndicator == indicator.Id, () => { _developmentIndicator = indicator.Id; Render(); }, 0);
                button.AddThemeColorOverride("font_color", MarketVisuals.LevelColor(level)); box.AddChild(button);
                double enhancement = NationalDevelopment.Enhancement(nation, indicator.Id, d.Day);
                box.AddChild(new DevelopmentGauge { Level = level, Enhancement = enhancement });
                if (enhancement > 0) box.AddChild(Text($"发展活力 +{enhancement:0%}", 15, _gold));
            }
        }
        var lower = new HBoxContainer(); main.AddChild(lower);
        var detail = Card(); lower.AddChild(detail); var description = Inner(detail);
        var selected = NationalDevelopment.All.First(i => i.Id == _developmentIndicator);
        description.AddChild(Text(selected.Name, 26, _gold));
        description.AddChild(Text(NationalDevelopment.Description(selected.Id, NationalDevelopment.Level(nation, selected.Id)), 21, _ink));
        var report = Card(); lower.AddChild(report); var news = Inner(report); news.AddChild(Text("赛场贡献与发展", 23, _gold));
        foreach (var contribution in d.Esports.CircuitAwards.Where(a => a.Country == nation.Country && a.Fortune > 0).OrderByDescending(a => a.Day).Take(4))
            news.AddChild(Text($"{GameCalendar.Text(d, contribution.Day)} · {CareerEngine.DisplayName(d, contribution.PersonId)}\n{contribution.Event}  +{contribution.Fortune}国运", 17, _ink));
        if (nation.LastReport.Length > 0) news.AddChild(Text(nation.LastReport, 16, CareerVisuals.Teal));
    }
}
