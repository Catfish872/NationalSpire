using HarmonyLib;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

public sealed partial class LeagueDuel
{
    private static bool Find(Player p,out LeagueDuel duel){duel=LeagueNativeMatch.For(p)!;return duel!=null;}
    private static Task<IEnumerable<CardModel>> Choose(IEnumerable<CardModel> cards,int min,int max)=>Task.FromResult<IEnumerable<CardModel>>(cards.Take(min>0?min:max).ToArray());
    internal static void InstallSelections(Harmony h){
        var stack=typeof(CardSelectCmd).Assembly.GetType("MegaCrit.Sts2.Core.CardSelection.CardSelectorStack");
        if(stack!=null&&AccessTools.DeclaredMethod(stack,"GetSelectorStackForPlayer") is {} lookup)
            h.Patch(lookup,prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(RivalSelectionStack)));
        void Apply(Type type,string method,string hook,int parameters){
            var target=AccessTools.GetDeclaredMethods(type).Single(m=>m.Name==method&&m.GetParameters().Length==parameters);
            h.Patch(target,prefix:new HarmonyMethod(typeof(LeagueDuel),hook));
        }
        Apply(typeof(CardSelectCmd),"FromHand",nameof(HandChoice),5);Apply(typeof(CardSelectCmd),"FromSimpleGrid",nameof(GridChoice),4);
        Apply(typeof(CardSelectCmd),"FromCombatPile",nameof(PileChoice),5);Apply(typeof(CardSelectCmd),"FromChooseACardScreen",nameof(OneChoice),4);
        if(AccessTools.DeclaredMethod(typeof(CardSelectCmd),"FromHandForUpgrade") is {} upgrade)
            h.Patch(upgrade,prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(UpgradeChoice)));
    }
    private readonly Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _selectors=[];
    private static bool RivalSelectionStack(Player player,ref Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> __result){
        if(!Find(player,out var duel))return true;__result=duel._selectors;return false;
    }
    private static bool UpgradeChoice(Player player,ref Task<CardModel?> __result){
        if(!Find(player,out _))return true;
        __result=Task.FromResult(player.PlayerCombatState!.Hand.Cards.FirstOrDefault(c=>c.IsUpgradable));return false;
    }
    private static bool HandChoice(Player player,CardSelectorPrefs prefs,Func<CardModel,bool>? filter,ref Task<IEnumerable<CardModel>> __result){
        if(!Find(player,out _))return true;__result=Choose(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),prefs.MinSelect,prefs.MaxSelect);return false;}
    private static bool GridChoice(IReadOnlyList<CardModel> cardsIn,Player player,CardSelectorPrefs prefs,ref Task<IEnumerable<CardModel>> __result){
        if(!Find(player,out _))return true;__result=Choose(cardsIn,prefs.MinSelect,prefs.MaxSelect);return false;}
    private static bool PileChoice(CardPile pile,Player player,CardSelectorPrefs prefs,Func<CardModel,bool>? filter,ref Task<IEnumerable<CardModel>> __result){
        if(!Find(player,out _))return true;__result=Choose(pile.Cards.Where(c=>filter?.Invoke(c)??true),prefs.MinSelect,prefs.MaxSelect);return false;}
    private static bool OneChoice(IReadOnlyList<CardModel> cards,Player player,bool canSkip,ref Task<CardModel?> __result){
        if(!Find(player,out _))return true;__result=Task.FromResult(cards.FirstOrDefault());return false;}
}
