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
    private async void MarketSubmit(CareerData d, MarketOrder order)
    {
        if (order.Action == "open" && order.Amount > 0 && order.Amount + CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage) <= d.Life.Trading.Cash)
        {
            MarketOrderPreview preview;
            if (d.InspectMarket != null)
            {
                MarketInspectionResult result;
                try { result = await d.InspectMarket(new(order.Asset, order.Amount, order.Leverage, [], true)); }
                catch (Exception exception) { if (IsInstanceValid(this) && IsInsideTree()) Notice("市场预览暂时失败，请重试。" + exception.Message, true); return; }
                if (!IsInstanceValid(this) || !IsInsideTree() || _lifeSection != "交易市场") return;
                if (result.Revision != order.QuoteRevision) { Notice("报价已更新，请查看最新价格后确认。", true); return; }
                preview = order.Direction > 0 ? result.Buy : result.Sell;
            }
            else preview = MarketClearing.Summary(MarketClearing.Preview(d, order));
            if (!preview.Accepted)
            {
                bool available = preview.Margin > 0;
                ShowCareerDialog("调整下单数量", preview.Reason + "。", () =>
                {
                    if (available) _listCache!.Market.SetOrderMargin(preview.Margin);
                    return true;
                }, available ? "应用建议数量" : "自行调整", contents: box =>
                {
                    var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 18); box.AddChild(columns);
                    void Summary(string title, decimal margin, decimal fee, Color accent)
                    {
                        var card = Card(); card.SizeFlagsHorizontal = SizeFlags.ExpandFill; columns.AddChild(card);
                        var content = Inner(card); content.AddChild(Text(title, 18, accent));
                        content.AddChild(Text(CareerMoney.Compact(margin * order.Leverage), 26, accent));
                        content.AddChild(Text("交易总额", 15, _ink));
                        content.AddChild(Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink));
                    }
                    Summary("本次下单", order.Amount, CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage), _gold);
                    Summary("当前可成交", preview.Margin, preview.Fee, CareerVisuals.Teal);
                    box.AddChild(Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink));
                }, showCancel: available, cancelText: "自行调整");
                return;
            }
        }
        if (MultiplayerCommand("market", text: JsonSerializer.Serialize(order))) return;
        var error = EconomicActions.Trade(d, order);
        Render(); Notice(error ?? "交易已完成并保存。", error != null);
    }
}
