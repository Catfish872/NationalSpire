using CombatSolver;
using CombatSolver.HotKernel;
using CombatSolver.HotSearch;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace NationalSpire.Solver;

public sealed partial class LeagueForecast
{
    private sealed record SelectionMenu(ushort Group,PileType Pile,int Hash,PlanChoiceEffect Effect,Dictionary<ushort,(string Id,int Level,int Occurrence)> Options,List<(string Id,int Level,int Occurrence)> Cards);
    private sealed record SelectionPath(HotChoiceSelection[] Selections,SelectionMenu[] Menus);

    public static int MenuKey(IEnumerable<CardModel> cards)
        => HashMenu(cards.Select(c=>(c.Id.Entry,c.CurrentUpgradeLevel)));

    private static int HashMenu(IEnumerable<(string Id,int Level)> cards)
    {
        unchecked{
            int hash=17;
            foreach(var card in cards){
                hash=hash*31+ModelIdSerializationCache.GetNetIdForEntry(card.Id);
                hash=hash*31+card.Level;
            }
            return hash;
        }
    }

    private static void ExtendChoices(in CombatHotState before,HotAction action,in CombatHotState state,HotColdSidecar? cold,HotRules rules,HotEvalLookup lookup,HotExecScratch scratch,
        SelectionPath prior,Stack<SelectionPath> branches,int width,int incoming)
    {
        if(prior.Selections.Length>=HotLimits.MaxChoicesPerAction)return;
        var options=new HotChoiceSelection[HotLimits.MaxCards];
        var copies=new byte[options.Length];
        int count=HotCombatEngine.EnumerateChoiceOptionsWithClasses(in state,cold,rules,scratch,options,copies);
        var kind=scratch.PendingChoiceKind;
        var pile=HotPlanMaterializer.MapPileType(kind);
        var effect=HotPlanMaterializer.InferPlanChoiceEffect(scratch.PendingChoiceSourceCardDefId,kind,rules);
        var group=scratch.PendingChoiceGroupSeq;
        var previous=prior.Menus.LastOrDefault();
        bool merge=group!=0 && previous?.Group==group && previous.Pile==pile;
        var source=merge?previous!:ReadMenu(in before,action,in state,cold,rules,scratch,options,copies,count,pile,effect);
        bool retain=HotCombatEngine.GetPowerAmountById(in state,rules,0,HotPowerId.RetainHandPower)>0;
        int recommended=-1;
        if(HotRolloutEvaluator.TryPickDeterministicGreedyChoice(in state,cold,rules,lookup.CardRoles,kind,
            scratch.PendingChoiceSourceCardDefId,scratch.PendingChoiceMin,scratch.PendingChoiceMax,
            Math.Max(0,incoming-state.Player.Block),retain,options,count,prior.Selections,out var preferred))
            recommended=Array.IndexOf(options,preferred,0,count);
        var candidates=Enumerable.Range(0,count).OrderByDescending(i=>i==recommended)
            .ThenByDescending(i=>options[i].Kind==HotChoiceKind.None).Take(width).Reverse();
        foreach(int i in candidates){
            var menu=source with{Cards=[..source.Cards]};
            if(options[i].Kind!=HotChoiceKind.None){
                if(!menu.Options.TryGetValue(options[i].CardUidOrIndex,out var token))continue;
                menu.Cards.Add(token);
            }
            SelectionMenu[] menus=merge?[..prior.Menus[..^1],menu]:[..prior.Menus,menu];
            branches.Push(new([..prior.Selections,options[i]],menus));
        }
    }

    // 求解器将等效选项合并搜索。实战菜单保留每张实体牌，连续多选也沿用第一次展示时的位置。
    private static SelectionMenu ReadMenu(in CombatHotState before,HotAction action,in CombatHotState state,HotColdSidecar? cold,
        HotRules rules,HotExecScratch scratch,HotChoiceSelection[] options,byte[] copies,int count,PileType pile,PlanChoiceEffect effect)
    {
        var cards=new List<(string Id,int Level)>();
        var byUid=new Dictionary<ushort,(string Id,int Level,int Occurrence)>();
        var seen=new Dictionary<(string,int),int>();
        void Add(ushort uid,string id,int level){
            var key=(id,level);
            int occurrence=seen.GetValueOrDefault(key);
            seen[key]=occurrence+1;
            byUid.Add(uid,(id,level,occurrence));
            cards.Add(key);
        }
        var kind=scratch.PendingChoiceKind;
        ushort source=scratch.PendingChoiceSourceCardDefId;
        if(kind==HotChoiceKind.GeneratedCard){
            var generated=HotCombatEngine.GetPendingGeneratedChoiceOptions();
            bool upgrade=HotPlanMaterializer.ShouldUpgradeGeneratedChoiceOptions(in before,in state,rules,action,source);
            for(int i=0;i<generated.Length;i++){
                var def=rules.Cards[generated[i]];
                Add((ushort)i,def.Entry,upgrade && def.MaxUpgradeLevel>0?1:0);
            }
        }else{
            var zone=HotPlanMaterializer.MapHotPileKind(kind);
            int start=HotPiles.ZoneStart(in state,zone),size=HotPiles.ZoneCount(in state,zone);
            var selected=HotCombatEngine.GetPendingFilteredChoiceUids();
            var excluded=HotCombatEngine.GetPendingExcludedChoiceUids();
            var filter=source==0?HotCustomCardId.None:rules.Cards[source].CardId;
            var indices=new int[count];
            for(int i=0;i<count;i++)
                indices[i]=options[i].Kind==HotChoiceKind.None?-1:HotCombatEngine.FindCardIndexByUid(in state,zone,options[i].CardUidOrIndex);
            for(int offset=0;offset<size;offset++){
                ref readonly var card=ref state.Cards[start+offset];
                if((!selected.IsEmpty && !selected.Contains(card.CardUid)) || excluded.Contains(card.CardUid)
                    || !HotCombatEngine.MatchesChoiceFilter(in state,in card,rules,filter))continue;
                for(int i=0;i<count;i++){
                    int idx=indices[i];
                    if(idx<0 || copies[i]==0 || !HotCombatEngine.AreChoiceEquivalentCards(in state,zone,idx-start,offset,in state.Cards[idx],in card,cold))continue;
                    copies[i]--;
                    Add(card.CardUid,rules.Cards[card.CardDefId].Entry,card.UpgradeLevel);
                    break;
                }
            }
        }
        return new(scratch.PendingChoiceGroupSeq,pile,HashMenu(cards),effect,byUid,[]);
    }

    private static int[] Wire(SelectionPath path){
        if(path.Menus.Length==0)return [];
        var result=new List<int>();
        foreach(var menu in path.Menus){
            result.AddRange([(int)menu.Pile,menu.Hash,(int)menu.Effect,menu.Cards.Count]);
            foreach(var (id,level,occurrence) in menu.Cards)
                result.AddRange([ModelIdSerializationCache.GetNetIdForEntry(id),level,occurrence]);
        }
        return result.ToArray();
    }

    public static int[] SelectActual(CardModel[] cards,int pile,string purpose,int effect,int min,int max)
    {
        if(cards.Length==0 || max==0)return [];
        var owner=cards.Select(c=>c.Owner).FirstOrDefault(p=>p?.Creature.CombatState!=null);
        if(owner==null)return Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray();
        using var projection=new LeagueForecast(owner,0,[],v=>v,-1,default);
        var bundle=projection.Capture(false).HotRoot;
        var state=bundle.RootState;
        var lookup=new HotEvalLookup(bundle.Rules);
        var defs=bundle.Rules.Cards;
        var originalIds=projection.OriginalCards(in state).ToDictionary(pair=>pair.Value,pair=>pair.Key);
        bool drop=effect is (int)PlanChoiceEffect.Discard or (int)PlanChoiceEffect.Exhaust or (int)PlanChoiceEffect.DiscardAndDraw
            || effect<0 && purpose is "TO_DISCARD" or "TO_REMOVE" or "TO_EXHAUST";
        bool upgrade=effect==(int)PlanChoiceEffect.Upgrade || purpose=="TO_UPGRADE";
        var ranked=new List<(int Index,int Value)>();
        var kind=(PileType)pile switch{PileType.Hand=>HotChoiceKind.HandCard,PileType.Draw=>HotChoiceKind.DrawPile,
            PileType.Discard=>HotChoiceKind.DiscardPile,PileType.Exhaust=>HotChoiceKind.ExhaustPile,_=>HotChoiceKind.GeneratedCard};
        for(int i=0;i<cards.Length;i++){
            int def=Array.FindIndex(defs,d=>d?.Entry==cards[i].Id.Entry);
            int value=def<=0?0:HotRolloutEvaluator.ComputeGenericChoiceCardQuality(in state,bundle.RootCold,bundle.Rules,lookup.CardRoles,
                new(kind,originalIds.GetValueOrDefault(cards[i],ushort.MaxValue),(ushort)def),0,state.Energy,upgrade,
                HotCombatEngine.GetPowerAmountById(in state,bundle.Rules,0,HotPowerId.RetainHandPower)>0);
            ranked.Add((i,value));
        }
        var ordered=drop?ranked.OrderBy(x=>x.Value):ranked.OrderByDescending(x=>x.Value);
        return ordered.Take(Math.Min(drop?min:max,cards.Length)).Select(x=>x.Index).ToArray();
    }
}
