using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

public sealed record LiveShopChange(ulong Player, string Kind, string Item, int DeckSize, int Gold, string CardType = "");

/// <summary>观察原版已完成的房间记录；创建时跳过存档里的旧记录，取消购买不产生发言。</summary>
public sealed class LiveShopObserver
{
    private sealed record Cursor(int Removed, int Cards, int Relics, int Potions, int Spent);
    private readonly Dictionary<ulong, Cursor> _seen = [];
    private int _floor;
    private bool _disabled;
    public LiveShopObserver(RunState run) { _floor = run.TotalFloor; Read(run, false); }
    public IReadOnlyList<LiveShopChange> Read(RunState run, bool publish = true)
    {
        var result = new List<LiveShopChange>();
        if (_disabled) return result;
        try
        {
            if (_floor != run.TotalFloor) { _seen.Clear(); _floor = run.TotalFloor; }
            foreach (var p in run.Players)
            {
                var h = run.CurrentMapPointHistoryEntry?.GetEntry(p.NetId); if (h == null) continue;
                var before = _seen.GetValueOrDefault(p.NetId, new(0, 0, 0, 0, 0));
                _seen[p.NetId] = new(h.CardsRemoved.Count, h.CardsGained.Count, h.BoughtRelics.Count, h.BoughtPotions.Count, h.GoldSpent);
                if (!publish) continue;
                bool shop = run.CurrentRoom?.RoomType.ToString() == "Shop";
                void Add(string kind, string name, string cardType = "") => result.Add(new(p.NetId, kind, GameText.Plain(name), p.Deck.Cards.Count, p.Gold, cardType));
                foreach (var card in h.CardsGained.Skip(before.Cards))
                    if (card.Id is { } id && ModelDb.GetByIdOrNull<CardModel>(id) is { } model)
                        Add(shop ? h.GoldSpent > before.Spent ? "buy_card" : "gain_card" : "reward_card", model.Title, model.Type.ToString());
                if (!shop) continue;
                foreach (var card in h.CardsRemoved.Skip(before.Removed))
                    if (card.Id is { } id && ModelDb.GetByIdOrNull<CardModel>(id) is { } model)
                        Add(model.Type.ToString() switch { "Attack" => "remove_attack", "Curse" => "remove_curse", _ => "remove_defend" }, model.Title);
                foreach (var id in h.BoughtRelics.Skip(before.Relics))
                    if (ModelDb.GetByIdOrNull<RelicModel>(id) is { } model) Add("buy_relic", model.Title.GetFormattedText());
                foreach (var id in h.BoughtPotions.Skip(before.Potions))
                    if (ModelDb.GetByIdOrNull<PotionModel>(id) is { } model) Add("buy_potion", model.Title.GetFormattedText());
            }
        }
        catch (Exception e) { _disabled = true; Diagnostics.Error("live.shop", e); }
        return result;
    }
}
