using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void MarketScreen(CareerData d)
    {
        var advance = TeamButton("推进一天 →", AdvanceCareerDay, 180);
        advance.Icon = LifestyleArt.Icon("活动与计划"); _content.AddChild(advance);
        var terminal = _listCache!.Market;
        terminal.Reparent(_content); terminal.Show();
        terminal.Bind(d, order => MarketSubmit(ViewData, order), OpenPerson);
    }
    private void AdvanceCareerDay()
    {
        var data = ViewData;
        if (MultiplayerCommand("propose-advance", number: data.Day + 1)) return;
        bool advanced = CareerEngine.AdvanceOneDay(data);
        Render(); if (!advanced) Notice("比赛日需先完成或放弃比赛。", true);
    }
    private void MarketSubmit(CareerData d, MarketOrder order)
    {
        if (MultiplayerCommand("market", text: JsonSerializer.Serialize(order))) return;
        var error = EconomicActions.Trade(d, order);
        Render(); Notice(error ?? "交易已完成并保存。", error != null);
    }
}
