using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace NationalSpire;

public static class GameCardKnowledge
{
    public static IEnumerable<CardReference> Read()
    {
        foreach (var model in ModelDb.AllCards.DistinctBy(c => c.Id))
        {
            CardReference? reference = null;
            try
            {
                var card = model.ToMutable();
                string name = GameText.Plain(card.Title);
                string Describe() => GameText.Plain(card.Title) + " · " + card.Pool.Title + " · " + card.Type
                    + " · 费用" + (card.EnergyCost.CostsX ? "X" : card.EnergyCost.GetWithModifiers(CostModifiers.All).ToString())
                    + "：" + GameText.Plain(card.GetDescriptionForPile(PileType.None));
                string description = Describe();
                if (card.MaxUpgradeLevel > 0) { card.UpgradeInternal(); card.FinalizeUpgradeInternal(); description += "\n" + Describe(); }
                reference = new(model.Id.ToString(), name, description);
            }
            catch (Exception error) { Diagnostics.Error("card-reference:" + model.Id, error); }
            if (reference != null) yield return reference;
        }
    }
}
