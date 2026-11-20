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
    private int[] _choicePlan=[];
    private int _choiceIndex;
    private bool _choicesChanged;
    private CardModel[] SelectActual(IEnumerable<CardModel> candidates,PileType pile,int min,int max,string purpose=""){
        LeagueNativeMatch.RecordSelection(Rival);
        var cards=candidates.ToArray();if(cards.Length==0)return [];
        int effect=-1;
        if(_choiceIndex<_choicePlan.Length){
            var plan=_choicePlan;int i=_choiceIndex;
            int source=plan[i++],menu=plan[i++],plannedEffect=plan[i++],count=plan[i++];
            if(source==(int)pile||pile==PileType.None){
                effect=plannedEffect;
                if(menu==LeagueSolverLink.Menu(cards)&&count>=Math.Min(min,cards.Length)&&count<=max){
                    var chosen=new CardModel[count];
                    bool found=true;
                    for(int k=0;k<count;k++){
                        string id=MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetEntryForNetId(plan[i++]);
                        int level=plan[i++],occurrence=plan[i++];
                        if(cards.Where(c=>c.Id.Entry==id&&c.CurrentUpgradeLevel==level).ElementAtOrDefault(occurrence) is not {} match){found=false;break;}
                        chosen[k]=match;
                    }
                    if(found){_choiceIndex=i;return chosen;}
                }
            }
            _choicePlan=[];_choiceIndex=0;_choicesChanged=true;
        }
        _choicesChanged=true;
        return LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max).Select(i=>cards[i]).ToArray();
    }
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
        if(!Find(player,out var duel))return true;
        __result=Task.FromResult(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault());return false;
    }
    private static bool HandChoice(Player player,CardSelectorPrefs prefs,Func<CardModel,bool>? filter,ref Task<IEnumerable<CardModel>> __result){
        if(!Find(player,out var duel))return true;__result=Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),PileType.Hand,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey));return false;}
    private static bool GridChoice(IReadOnlyList<CardModel> cardsIn,Player player,CardSelectorPrefs prefs,ref Task<IEnumerable<CardModel>> __result){
        if(!Find(player,out var duel))return true;__result=Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(cardsIn,PileType.None,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey));return false;}
    private static bool PileChoice(CardPile pile,Player player,CardSelectorPrefs prefs,Func<CardModel,bool>? filter,ref Task<IEnumerable<CardModel>> __result){
        if(!Find(player,out var duel))return true;__result=Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(pile.Cards.Where(c=>filter?.Invoke(c)??true),pile.Type,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey));return false;}
    private static bool OneChoice(IReadOnlyList<CardModel> cards,Player player,bool canSkip,ref Task<CardModel?> __result){
        if(!Find(player,out var duel))return true;__result=Task.FromResult(duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault());return false;}
}
