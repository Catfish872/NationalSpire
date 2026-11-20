using System.Text;

namespace NationalSpire;

// AI 读取 Describe 生成的简报。Replay 只供玩家回看，旧记录可以缺少此项。
public sealed class DuelReport
{
    public bool OpponentOpens { get; set; }
    public bool PlayersWon { get; set; }
    public string Note { get; set; } = "";
    public List<DuelParticipant> People { get; set; } = [];
    public List<DuelRound> Rounds { get; set; } = [];
    public List<DuelCardFace> PlayedFaces { get; set; } = [];
    public DuelReplay? Replay { get; set; }

    public string Describe(IEnumerable<string>? providedCards = null)
    {
        var text = new StringBuilder();
        string Side(bool rival) => string.Join("、", People.Where(p => p.Opponent == rival).Select(p => p.Name));
        text.Append($"{Side(false)} 对阵 {Side(true)}，{Side(OpponentOpens)}先手。共 {Rounds.Count} 回合，{Side(!PlayersWon)}获胜。");
        if (Note.Length > 0) text.Append(Note);
        foreach (var p in People)
            text.Append($"\n{p.Name}（{p.Character}）  生命 {p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}");
        text.Append("\n逐回合战况按选手列出。格挡记录实际抵消量，伤害记录对方实际失血。");
        foreach (var round in Rounds)
        {
            text.Append($"\n第{round.Number}回合  ");
            text.AppendJoin(" ／ ", round.Totals.Select((s, i) =>
                $"{People[i].Name} 出牌{s.Cards}，攻击意图{s.Attack}，格挡{s.Block}，伤害{s.Damage}，抽牌{s.Draw}，耗能{s.Energy}" +
                (s.DoomIntent == 0 && s.Doom == 0 ? "" : $"，灾厄意图{s.DoomIntent}，施加{s.Doom}")));
        }
        var highlights = Rounds.Where(r => r.Sequence.Count > 0).ToList();
        if (highlights.Count > 0) text.Append($"\n其中{highlights.Count}个关键回合的完整出牌顺序");
        foreach (var r in highlights) {
            int last=-1;
            string Card(DuelCardStep step){
                var prefix=step.Actor==last?"":People[step.Actor].Name+"使用";last=step.Actor;
                return prefix+step.Card+(step.Generated?"（战中获得）":"")+(People.Count>2 && step.Target.Length>0?"〔"+step.Target+"〕":"");
            }
            text.Append($"\n第{r.Number}回合  ").AppendJoin(" → ",r.Sequence.Select(run=>{
                string part=string.Join(" → ",run.Cards.Select(Card));
                return run.Repeats==1?part:"（"+part+"）×"+run.Repeats;
            }));
        }
        if (providedCards != null) text.Append("\n玩家的牌组信息见正式战报。");
        var seen = (providedCards ?? []).Select(GameText.Plain).ToHashSet(StringComparer.Ordinal);
        foreach (var p in People)
        {
            if (!p.Opponent && providedCards != null) continue;
            var sample = p.Deck.Select(f=>f.Text).Where(seen.Add).ToList();
            if (sample.Count > 0) text.Append($"\n{p.Name}的部分牌面  ").AppendJoin("；", sample);
        }
        var extra = PlayedFaces.Select(f=>f.Text).Where(seen.Add).ToList();
        if (extra.Count > 0) text.Append("\n关键回合另见牌面  ").AppendJoin("；", extra);
        return text.ToString();
    }
}

public sealed class DuelReplay
{
    public List<DuelCardFace> Faces { get; set; } = [];
    // 按参赛者顺序保存起始牌组，重复编号保留卡牌张数。
    public List<List<int>> Decks { get; set; } = [];
    public Dictionary<int,List<DuelReplayStep>> Rounds { get; set; } = [];
}

public sealed record DuelReplayStep(int Actor,int Face,string Card,string Target,bool Generated);

public sealed class DuelParticipant
{
    public string PersonId { get; set; } = "";
    public string Name { get; set; } = "";
    public string Character { get; set; } = "";
    public bool Opponent { get; set; }
    public int OpenHp { get; set; }
    public int OpenMax { get; set; }
    public int EndHp { get; set; }
    public int EndMax { get; set; }
    public List<DuelCardFace> Deck { get; set; } = [];
}

public sealed class DuelRound
{
    public int Number { get; set; }
    public List<DuelTurnTotals> Totals { get; set; } = [];
    public List<DuelSequenceRun> Sequence { get; set; } = [];
}

public sealed record DuelCardFace(string Id,string Text,int? Level=null,string? State=null);
public sealed record DuelCardStep(int Actor,string Card,string Target,bool Generated);
public sealed record DuelSequenceRun(List<DuelCardStep> Cards,int Repeats);

public sealed class DuelTurnTotals
{
    public int Cards { get; set; }
    public int Draw { get; set; }
    public int Energy { get; set; }
    public int Attack { get; set; }
    public int DoomIntent { get; set; }
    public int Doom { get; set; }
    public int Block { get; set; }
    public int Damage { get; set; }
}
