using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void MarketScreen(CareerData d)
    {
        var terminal = _listCache!.Market;
        terminal.Reparent(_content); terminal.Show();
        terminal.Bind(d, order => MarketSubmit(ViewData, order), OpenPerson);
    }
    private void MarketSubmit(CareerData d, MarketOrder order)
    {
        if (MultiplayerCommand("market", text: JsonSerializer.Serialize(order))) return;
        var error = EconomicActions.Trade(d, order);
        Render(); Notice(error ?? "交易已完成并保存。", error != null);
    }
}
