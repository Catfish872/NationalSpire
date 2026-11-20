using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Combat.History;
using MegaCrit.Sts2.Core.Combat.History.Entries;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Powers;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace NationalSpire;

internal sealed class DuelRecorder : IDisposable
{
    private readonly RunState _run;
    private readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer _choices=RunManager.Instance.PlayerChoiceSynchronizer;
    private readonly DuelReport _report;
    private readonly DuelReplay _replay = new();
    private readonly Dictionary<DuelCardFace,int> _faceIndices = [];
    private readonly List<Player> _players = [];
    private readonly Dictionary<Creature, int> _owners = [];
    private readonly SortedDictionary<int, Round> _rounds = [];
    private readonly Dictionary<CardPlay, Play> _started = new(ReferenceEqualityComparer.Instance);
    private readonly CombatHistory _history = CombatManager.Instance.History;
    private int _cursor;

    private sealed class Round(int number)
    {
        internal readonly DuelRound Data = new() { Number = number };
        internal readonly List<Play> Plays = [];
        internal bool Knockout;
    }
    private sealed class Play(int actor, string id, string name, SerializableCard? snapshot, string target, bool generated)
    {
        internal readonly int Actor = actor;
        internal readonly string Id = id, Name = name, Target = target;
        private DuelCardFace? _face;
        internal DuelCardFace RecordedFace => _face ??= ArchiveFace(Id,snapshot);
        internal string Face => RecordedFace.Text;
        internal readonly bool Generated = generated;
        internal bool Finished, HasChoice;
        internal uint? TargetId;
    }
    internal DuelRecorder(RunState run, bool opponentOpens)
    {
        _run = run;
        _report = new() { OpponentOpens = opponentOpens };
        var world = run.Players.Count > 1 ? Coop.CoopRuntime.Current?.Session?.World : null;
        foreach (var player in run.Players)
        {
            var member = world?.Members.FirstOrDefault(m => m.SteamId == player.NetId);
            Register(player, member?.Name ?? CareerEngine.Name(CareerStore.Data), player.Deck.Cards, false, member?.PersonId ?? "player");
        }
        _cursor = _history.Entries.Count();
        _history.Changed += Read;
        _choices.PlayerChoiceReceived+=PlayerChoice;
    }
    internal static IEnumerable<T> SelectDeck<T>(IEnumerable<T> cards, Func<T,int> upgrade, Func<T,int> floor, Func<T,ModelId?> id)
        => cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor).DistinctBy(id).Take(6);

    private static SerializableCard? Snapshot(CardModel card)
    {
        try { return card.ToSerializable(); } catch { return null; }
    }
    internal static string CardFace(SerializableCard? snapshot)
    {
        if(snapshot?.Id==null)return "";
        try { var face=CardModel.FromSerializable(snapshot); return GameText.Plain(face.Title + "：" + face.GetDescriptionForPile(PileType.None)); }
        catch { return ""; } // 已卸载素材或缺少显示上下文时，牌名仍可进入实战牌序。
    }
    private static DuelCardFace ArchiveFace(string id,SerializableCard? snapshot){
        string? state=null;
        if(snapshot?.Enchantment!=null || snapshot?.Props!=null){
            try{state=System.Text.Json.JsonSerializer.Serialize(snapshot);}
            catch(System.NotSupportedException){ /* 模组的扩展字段无法写入时仍保留当时显示的牌效。 */ }
        }
        return new(id,CardFace(snapshot),snapshot?.CurrentUpgradeLevel,state);
    }
    internal void Register(Player player, string name, IEnumerable<CardModel> deck, bool opponent, string? personId)
    {
        if (!_owners.TryAdd(player.Creature, _players.Count)) return;
        _players.Add(player);
        var cards = deck.ToList();
        _originalCards.Add(cards.ToHashSet());
        var faces = new Dictionary<CardModel,int>(ReferenceEqualityComparer.Instance);
        var deckIndices = new List<int>(cards.Count);
        foreach (var card in cards)
        {
            if (!faces.TryGetValue(card, out int index))
                faces[card] = index = FaceIndex(ArchiveFace(card.Id.Entry,Snapshot(card)));
            deckIndices.Add(index);
        }
        _replay.Decks.Add(deckIndices);
        var displayName=name;
        for(int n=2;_report.People.Any(p=>p.Name==displayName);n++)displayName=name+" "+n;
        _report.People.Add(new() {
            PersonId = personId ?? "", Name = displayName, Opponent = opponent,
            Character = CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id),
            OpenHp = player.Creature.CurrentHp, OpenMax = player.Creature.MaxHp,
            Deck = SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()
        });
    }
    private int FaceIndex(DuelCardFace face)
    {
        if (_faceIndices.TryGetValue(face,out int index)) return index;
        _faceIndices.Add(face,index=_replay.Faces.Count);
        _replay.Faces.Add(face);
        return index;
    }
    private int Owner(Creature? actor) => actor == null ? -1 : _owners.TryGetValue(actor,out int index) ? index :
        actor.PetOwner is {} owner ? _owners.GetValueOrDefault(owner.Creature,-1) : -1;
    private Round Current(Creature actor)
    {
        int n = Math.Max(1,actor.CombatState?.RoundNumber ?? 1);
        if (!_rounds.TryGetValue(n,out var round)) _rounds[n]=round=new(n);
        while(round.Data.Totals.Count < _players.Count) round.Data.Totals.Add(new());
        return round;
    }
    internal void Declare(Creature actor,int amount,bool doom)
    {
        if (Owner(actor) is var index && index >= 0) {
            var total=Current(actor).Data.Totals[index];
            if(doom) total.DoomIntent+=amount; else total.Attack+=amount;
        }
    }
    internal void Block(Creature actor,int amount)
    {
        int index=Owner(actor);
        if(index>=0) Current(actor).Data.Totals[index].Block+=amount;
    }
    private void Read()
    {
        var entries=_history.Entries as IReadOnlyList<CombatHistoryEntry> ?? _history.Entries.ToList();
        if(_cursor>entries.Count) _cursor=0;
        while(_cursor<entries.Count) {
            var e=entries[_cursor++];
            if(e.Actor.CombatState?.RunState!=_run) continue;
            int actor=Owner(e.Actor);
            var round=Current(e.Actor);
            switch(e) {
                case CardPlayStartedEntry start when actor>=0:
                    var play=start.CardPlay;
                    string name=GameText.Plain(play.Card.Title);
                    var step=new Play(actor,play.Card.Id.Entry,name,Snapshot(play.Card),
                        play.Target is {} target ? (_owners.TryGetValue(target,out var who)?_report.People[who].Name:target.Name) : "",
                        play.Card.DeckVersion==null && !_originalCards[actor].Contains(play.Card)){TargetId=play.Target?.CombatId};
                    _started[play]=step;round.Plays.Add(step);
                    break;
                case CardPlayFinishedEntry end when _started.Remove(end.CardPlay,out var finished):
                    finished.Finished=true;round.Data.Totals[finished.Actor].Cards++;
                    break;
                case CardDrawnEntry when actor>=0: round.Data.Totals[actor].Draw++; break;
                case EnergySpentEntry energy when actor>=0: round.Data.Totals[actor].Energy+=energy.Amount;break;
                case DamageReceivedEntry hit:
                    if(actor>=0) round.Data.Totals[actor].Block+=hit.Result.BlockedDamage;
                    int dealer=Owner(hit.Dealer);
                    if(dealer>=0 && hit.Receiver.Side!=hit.Dealer!.Side) round.Data.Totals[dealer].Damage+=hit.Result.UnblockedDamage;
                    if(hit.Result.WasTargetKilled && _owners.ContainsKey(hit.Receiver)) round.Knockout=true;
                    break;
                case PowerReceivedEntry {Power:DoomPower,Amount:>0} doom when Owner(doom.Applier) is var giver && giver>=0:
                    round.Data.Totals[giver].Doom+=(int)doom.Amount;break;
            }
        }
    }
    private readonly List<HashSet<CardModel>> _originalCards = [];
    internal void Choice(Player player){
        foreach(var (card,play) in _started)if(card.Player==player)play.HasChoice=true;
    }
    private void PlayerChoice(Player player,uint id,MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult result)=>Choice(player);
    private List<DuelSequenceRun> Sequence(List<Play> plays){
        var keys=new Dictionary<(int,string,string,uint?,bool),int>(); int next=0;
        var actions=plays.Select(p=>{
            if(p.HasChoice || p.Face.Length==0)return next++;
            var key=(p.Actor,p.Id,p.Face,p.TargetId,p.Generated);
            if(!keys.TryGetValue(key,out int id))keys[key]=id=next++;
            return id;
        }).ToArray();
        return LeagueSolverLink.ReportRuns(actions).Select(run=>new DuelSequenceRun(
            plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count)).ToList();
    }
    internal DuelReport Finish(bool won)
    {
        Read(); _report.PlayersWon=won;
        for(int i=0;i<_players.Count;i++) {
            _report.People[i].EndHp=_players[i].Creature.CurrentHp;
            _report.People[i].EndMax=_players[i].Creature.MaxHp;
        }
        foreach(var r in _rounds.Values) {
            while(r.Data.Totals.Count<_players.Count) r.Data.Totals.Add(new());
            r.Plays.RemoveAll(p=>!p.Finished);
            _replay.Rounds.Add(r.Data.Number,r.Plays.Select(p=>
                new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)).ToList());
        }
        var played=_rounds.Values.Where(r=>r.Plays.Count>0).ToList();
        var candidates=played.Where(r=>r.Knockout || r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id)).ToList();
        var rng=new Random(CareerEngine.StableHash(_run.Rng.StringSeed));
        if(candidates.Count==0 && played.Count>0) candidates.Add(played[rng.Next(played.Count)]);
        if(candidates.Count>0) {
            var first=candidates[rng.Next(candidates.Count)];
            var seen=first.Plays.Select(p=>(p.Actor,p.Id)).ToHashSet();
            var others=candidates.Where(r=>r!=first).ToList();
            if(others.Count==0)others=played.Where(r=>r!=first).ToList();
            var second=others.OrderBy(_=>rng.Next())
                .MaxBy(r=>r.Plays.Select(p=>(p.Actor,p.Id)).Distinct().Count(p=>!seen.Contains(p)));
            foreach(var r in _rounds.Values.Where(r=>r==first || r==second)) {
                r.Data.Sequence=Sequence(r.Plays);
                _report.PlayedFaces.AddRange(r.Plays.Where(p=>p.Face.Length>0).Select(p=>p.RecordedFace));
            }
        }
        _report.Rounds=_rounds.Values.Select(r=>r.Data).ToList();
        _report.PlayedFaces=_report.PlayedFaces.Distinct().ToList();
        _report.Replay=_replay;
        return _report;
    }
    public void Dispose(){_history.Changed-=Read;_choices.PlayerChoiceReceived-=PlayerChoice;}
}
