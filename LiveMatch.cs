namespace NationalSpire;

public sealed class BroadcastUiState
{
    public int PositionVersion { get; set; }
    public bool Collapsed { get; set; }
    public float X { get; set; } = -1;
    public float Y { get; set; }
}

public sealed class LiveMatchState
{
    public int Version { get; set; } = 1;
    public double PaceNeutralUntil { get; set; }
    public int PaceVersion { get; set; }
    public int HealthPlanVersion { get; set; }
    public int MaxHp { get; set; }
    public bool Cleared { get; set; }
    public List<RivalStep> Steps { get; set; } = [];
    public BroadcastMemory Commentary { get; set; } = new();
    public bool CommentaryEnabled { get; set; } = true;
    public List<int> PaceAdjustedActs { get; set; } = [];
}
public sealed class RivalStep
{
    public int Act { get; set; }
    public int Row { get; set; }
    public int Col { get; set; }
    public int Floor { get; set; }
    public string Kind { get; set; } = "";
    public double Start { get; set; }
    public double End { get; set; }
    public double HpCheckpointSeconds { get; set; }
    public double HpCheckpointFraction { get; set; }
    public int HpBefore { get; set; }
    public int HpAfter { get; set; }
    public int BattleLoss { get; set; }
    public string Action { get; set; } = "";
}
public sealed record RouteNode(int Act, int Row, int Col, string Kind, List<(int Row, int Col)> Children);
public sealed record RivalProgress(RivalStep Step, int Hp, bool Finished, bool Dead);

/// <summary>仅模拟对手的比赛记录，使用独立随机源，时间与原生对局计时对应。</summary>
public static class RivalSimulation
{
    public static bool Combat(string kind) => kind is "Monster" or "Elite" or "Boss" or "Unknown";
    public static string RoomName(string kind) => kind switch { "Monster" => "普通战斗", "Elite" => "精英战斗", "Boss" => "首领战", "RestSite" => "休息处", "Shop" => "商店", "Treasure" => "宝箱", "Ancient" => "先古之民", _ => "事件" };
    public static List<RouteNode> Route(IReadOnlyList<RouteNode> nodes, CareerPerson person, string seed)
    {
        var rng = new Random(CareerEngine.StableHash(seed + ":route:" + person.Id));
        var chosen = new List<RouteNode>();
        foreach (var act in nodes.GroupBy(n => n.Act).OrderBy(g => g.Key))
        {
            var points = act.ToDictionary(n => (n.Row, n.Col));
            var current = act.OrderBy(n => n.Row).ThenBy(n => n.Col).First();
            var seen = new HashSet<(int, int)>();
            while (seen.Add((current.Row, current.Col)))
            {
                chosen.Add(current);
                var children = current.Children.Where(points.ContainsKey).Select(c => points[c]).OrderBy(n => n.Col).ToList();
                if (children.Count == 0) break;
                double preference(RouteNode n) => n.Kind switch
                {
                    "Elite" => person.MaxAscension >= 8 ? .8 : -.8,
                    "RestSite" => .55,
                    "Unknown" => person.Style.Contains("谨慎") ? .1 : .45,
                    "Shop" => .25, _ => 0
                };
                current = children.Select(n => (Node: n, Score: rng.NextDouble() * 2 + preference(n))).OrderByDescending(x => x.Score).First().Node;
            }
        }
        return chosen;
    }
    public static LiveMatchState Create(CareerMatch match, CareerPerson person, IReadOnlyList<RouteNode> maps, int maxHp)
    {
        var route = Route(maps, person, match.Seed);
        if (route.Count == 0) throw new InvalidOperationException("对手地图尚未生成");
        if (!match.OpponentWon)
        {
            // 止步位置落在真实战斗节点，随后结算沿用同一楼层。
            int target = Math.Clamp(match.OpponentFloor - 1, 0, route.Count - 1);
            var battles = Enumerable.Range(0, route.Count).Where(i => Combat(route[i].Kind)).ToList();
            if (battles.Count > 0) target = battles.OrderBy(i => Math.Abs(i - target)).ThenBy(i => i).First();
            route = route.Take(target + 1).ToList(); match.OpponentFloor = route.Count;
        }
        var rng = new Random(CareerEngine.StableHash(match.Seed + ":timeline:" + person.Id));
        var weights = route.Select(n => (n.Kind switch { "Boss" => 260, "Elite" => 165, "Monster" => 100, "Unknown" => 65, "RestSite" => 28, "Ancient" => 35, _ => 36 }) * (.65 + rng.NextDouble() * .7)).ToArray();
        double duration = Math.Max(1, match.OpponentSeconds ?? 1800), sum = weights.Sum(), time = 0;
        maxHp = Math.Max(1, maxHp);
        var live = new LiveMatchState { MaxHp = maxHp, Cleared = match.OpponentWon };
        for (int i = 0; i < route.Count; i++)
        {
            var node = route[i];
            var step = new RivalStep { Act = node.Act, Row = node.Row, Col = node.Col, Floor = i + 1, Kind = node.Kind, Start = time };
            time += duration * weights[i] / sum; step.End = i == route.Count - 1 ? duration : time;
            live.Steps.Add(step);
        }
        PlanHealth(live, match, person, 0, match.RequiredAscension >= 2 ? Math.Max(1, (int)(maxHp * .8)) : maxHp);
        return live;
    }

    // 战损按两次恢复之间的完整路线分配，避免提前耗尽生命后逐场保留一血。
    private static void PlanHealth(LiveMatchState live, CareerMatch match, CareerPerson person, int start, int hp)
    {
        var rng = new Random(CareerEngine.StableHash(match.Seed + ":health:3:" + person.Id + ":" + start));
        int maxHp = live.MaxHp;
        for (int i = start; i < live.Steps.Count;)
        {
            var step = live.Steps[i];
            step.HpBefore = hp; step.BattleLoss = 0;
            if (step.Kind == "Ancient" && i > 0)
            {
                hp = Math.Min(maxHp, hp + (int)((maxHp - hp) * (match.RequiredAscension >= 2 ? .8 : 1)));
                step.Action = "幕间恢复"; step.HpAfter = hp; i++; continue;
            }
            if (step.Kind == "RestSite")
            {
                bool rest = hp < maxHp * .68 || (!match.OpponentWon && hp < maxHp * .85);
                if (rest) hp = Math.Min(maxHp, hp + (int)(maxHp * .3));
                step.Action = rest ? "休息恢复" : "锻造卡牌";
                step.HpAfter = hp; i++; continue;
            }
            int end = i + 1;
            while (end < live.Steps.Count && live.Steps[end].Kind is not ("RestSite" or "Ancient")) end++;
            var losses = new int[end - i];
            for (int j = i; j < end; j++)
            {
                if (!Combat(live.Steps[j].Kind) || !live.Cleared && j == live.Steps.Count - 1) continue;
                double severity = live.Steps[j].Kind switch { "Boss" => 1.8, "Elite" => 1.3, "Unknown" => .55, _ => .8 };
                // 通关结果不额外减伤；实力影响战损，但成功通关也会经历明显消耗。
                losses[j - i] = Math.Max(0, (int)Math.Round((7 + rng.NextDouble() * 18 + match.RequiredAscension * 1.1
                    - person.MaxAscension * .6) * severity));
            }
            // 低血量留给接近恢复点或终点的阶段，前面的战斗仍有逐步损血的空间。
            int reserve = Math.Max(1, (int)Math.Round(maxHp * (.12 + rng.NextDouble() * .18)));
            int heal = person.Character == "铁甲战士" ? 6 : 0;
            // 按净消耗分配生命预算，避免战后回血抵消已经压低过的全部伤害。
            double scale = Math.Min(1, Math.Max(0, hp - reserve) / (double)Math.Max(1, losses.Sum(loss => Math.Max(0, loss - heal))));
            double cumulative = 0; int assigned = 0;
            for (int j = i; j < end; j++)
            {
                step = live.Steps[j]; step.HpBefore = hp; step.BattleLoss = 0;
                bool dead = !live.Cleared && j == live.Steps.Count - 1;
                if (Combat(step.Kind))
                {
                    cumulative += Math.Max(0, losses[j - i] - heal) * scale;
                    int total = (int)Math.Floor(cumulative);
                    int loss = dead ? hp : Math.Min(hp - 1, Math.Min(losses[j - i], heal) + total - assigned); assigned = total;
                    hp -= loss; step.BattleLoss = loss;
                    if (hp > 0 && person.Character == "铁甲战士") hp = Math.Min(maxHp, hp + 6);
                    step.Action = dead ? "战斗失利" : step.Kind == "Unknown" ? "事件遭遇战" : "战斗";
                }
                else step.Action = step.Kind == "Shop" ? "采购与整理" : step.Kind == "Treasure" ? "收取遗物" : "选择祝福";
                step.HpAfter = hp;
            }
            i = end;
        }
        live.HealthPlanVersion = 3;
    }

    public static bool UpgradeHealthPlan(LiveMatchState live, CareerMatch match, CareerPerson person, double seconds)
    {
        if (live.HealthPlanVersion >= 3) return false;
        // 旧局已经显示过的生命和当前战斗保持不变，从下一次恢复机会开始使用新计划。
        int start = live.Steps.FindIndex(s => s.Start > seconds && s.Kind is "Ancient" or "RestSite");
        if (start >= 0) PlanHealth(live, match, person, start, live.Steps[start].HpBefore);
        live.HealthPlanVersion = 3;
        return true;
    }

    public static RivalProgress At(LiveMatchState live, double seconds)
    {
        var step = live.Steps.FirstOrDefault(s => seconds < s.End) ?? live.Steps[^1];
        bool finished = seconds >= live.Steps[^1].End;
        double fraction = Math.Clamp((seconds - step.Start) / Math.Max(.01, step.End - step.Start), 0, 1);
        if (step.HpCheckpointSeconds > step.Start && seconds >= step.HpCheckpointSeconds)
            fraction = step.HpCheckpointFraction + (1 - step.HpCheckpointFraction)
                * Math.Clamp((seconds - step.HpCheckpointSeconds) / Math.Max(.01, step.End - step.HpCheckpointSeconds), 0, 1);
        // 战损分三次出现，回血在房间结束结算；致死伤害在终点才出现。
        int beats = Math.Min(3, (int)(fraction * 4));
        int hp = step.HpBefore - (int)Math.Floor(step.BattleLoss * beats / 4.0);
        if (finished) hp = step.HpAfter;
        return new(step, Math.Max(finished && !live.Cleared ? 0 : 1, hp), finished, finished && !live.Cleared);
    }

    /// <summary>跨幕落后时适度重分配后续房间耗时，终点、路线与战损保持原定结果。</summary>
    public static bool TryAdjustPace(LiveMatchState live, double seconds, int playerAct, int playerFloor)
    {
        if (!double.IsFinite(seconds) || seconds < 0 || live.Steps.Count < 3) return false;
        var steps = live.Steps;
        int current = steps.FindIndex(s => seconds < s.End);
        if (current < 0) return false;
        var at = steps[current];
        int gap = playerFloor - at.Floor;
        if (playerAct <= at.Act || gap < 2 || playerFloor <= at.Floor) return false;
        // 旧存档允许采用新的速度，但同一幕在新规则下只调整一次。
        if (live.PaceVersion >= 2 && live.PaceAdjustedActs.Contains(at.Act)) return false;
        int stop = steps.FindIndex(current + 1, s => s.Act > at.Act);
        if (stop < 0) return false;
        var durations = steps.Select(s => s.End - s.Start).ToArray();
        if (durations.Any(d => !double.IsFinite(d) || d <= 0)) return false;
        double finish = steps[^1].End;
        if (!double.IsFinite(finish)) return false;
        double speed = 2.4 + 1.6 * Math.Clamp((gap - 2) / 12.0, 0, 1);
        var savings = new double[steps.Count];
        var laterWeights = new double[steps.Count];
        for (int i = current; i < stop; i++)
        {
            double remaining = i == current ? steps[i].End - seconds : durations[i];
            double minimum = steps[i].Kind == "Boss" ? 45 : Combat(steps[i].Kind) ? 22 : 6;
            savings[i] = Math.Max(0, remaining - Math.Max(minimum, remaining / speed));
        }
        // 把提前的时间分散到下一幕的房间，逐渐恢复常速，终点时间不变。
        for (int i = stop; i < steps.Count; i++)
            laterWeights[i] = durations[i] * Math.Min(1, (i - stop + 1) / 4.0);
        double requested = savings.Sum(), later = laterWeights.Sum();
        double gain = Math.Min(requested, Math.Min(1500, Math.Min(finish * .28, later * .55)));
        if (gain < 5 || requested <= 0 || later <= 0) return false;
        double fraction = Math.Clamp((seconds - at.Start) / durations[current], 0, 1);
        if (at.HpCheckpointSeconds > at.Start && seconds >= at.HpCheckpointSeconds)
            fraction = at.HpCheckpointFraction + (1 - at.HpCheckpointFraction)
                * Math.Clamp((seconds - at.HpCheckpointSeconds) / (at.End - at.HpCheckpointSeconds), 0, 1);
        at.HpCheckpointSeconds = seconds;
        at.HpCheckpointFraction = fraction;
        double time = at.Start;
        for (int i = current; i < steps.Count; i++)
        {
            double duration = durations[i] - savings[i] * gain / requested + laterWeights[i] * gain / later;
            steps[i].Start = time;
            time += duration;
            steps[i].End = i == steps.Count - 1 ? finish : time;
        }
        if (live.PaceVersion < 2) live.PaceAdjustedActs.Clear();
        live.PaceVersion = 2;
        live.PaceAdjustedActs.Add(at.Act);
        live.PaceNeutralUntil = Math.Max(live.PaceNeutralUntil, steps[stop].End + 90);
        return true;
    }
}
