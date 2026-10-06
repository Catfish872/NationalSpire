using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Label? _settlementCommunity;
    private string _settlementMatch = "";
    private void RefreshSettlementDiscussion(CareerData data)
    {
        if (_settlementCommunity == null || !IsInstanceValid(_settlementCommunity) || _settlementCommunity.IsQueuedForDeletion()) return;
        var post = CommunityThreads.All(data).FirstOrDefault(p => p.EventKey == "match" + _settlementMatch);
        _settlementCommunity.Text = post == null ? "本场战报已保存。" : post.NewsGeneration.State == "completed" ? $"赛后讨论已更新 · {post.Replies.Count} 条回复"
            : post.NewsGeneration.State == "failed" ? "赛后讨论暂未完成，可在社区重试。"
            : post.AiPending && data.Ai.Enabled ? "赛后讨论正在整理，可以先看看本场成绩。" : "本场战报已刊登，去社区看看。";
    }
    private void Settlement(CareerData data)
    {
        var result = data.Results.LastOrDefault();
        if (result == null) { AddHeading("尚无比赛结算", "完成一场已报名赛事后，战报会显示在这里。"); return; }
        if (data.PendingSettlementId == result.MatchId) { data.PendingSettlementId = ""; CareerStore.Save(data); }
        var match = data.Matches.LastOrDefault(m => m.Id == result.MatchId);
        bool draw = result.Outcome == "平局" || match?.Draw == true;
        bool won = result.Outcome == "获胜" || result.Outcome.Length == 0 && (match?.PlayerWon ?? result.Win);
        var accent = draw ? CareerVisuals.Teal : won ? _gold : new Color("a5bcd5");
        var hero = Card(); hero.Name = "SettlementHero"; hero.AddThemeStyleboxOverride("panel", CareerVisuals.Box(won ? "223039" : "192b3b", accent.ToHtml(false), 12, 26));
        if (hero is BroadcastPanel panel) panel.Accent = accent;
        _content.AddChild(hero); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 30); hero.AddChild(row);
        row.AddChild(new MatchMedallion { Victory = won, Accent = accent, CustomMinimumSize = new Vector2(180, 190), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        var intro = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; intro.AddThemeConstantOverride("separation", 10); row.AddChild(intro);
        intro.AddChild(Text("MATCH RESULT   /   " + result.Event, 16, accent));
        intro.AddChild(Text(draw ? "势均力敌" : won ? "赢下这一场" : result.Outcome == "退赛" ? "本场退赛" : "本场失利", 42, _ink));
        intro.AddChild(Text($"第 {SeasonCalendar.Day(data, result.Day)} 天 · {MatchRules.AscensionLabel(result)}", 17, _muted));
        intro.AddChild(Text(draw ? "双方成绩相同，等待下一次交锋。" : won ? "这场胜利，记入你的生涯。" : "本场成绩已记录，赛季仍在继续。", 19, accent));
        RenderTeam();
        var contenders = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        contenders.AddThemeConstantOverride("h_separation", 18); _content.AddChild(contenders);
        void Contender(string id, string name, string character, string performance, string detail)
        {
            var card = Card(); contenders.AddChild(card); var box = Inner(card);
            box.AddChild(WithAvatar(data, id, Text(name, 26, id == "player" ? accent : _ink), 72, true));
            box.AddChild(Text(character, 16, _muted)); box.AddChild(Text(performance, 23, _ink));
            if (detail.Length > 0) box.AddChild(Text(detail, 16, CareerVisuals.Teal));
        }
        var evidence = new List<string>();
        if (result.Evidence.FinalHp != null && result.Evidence.MaxHp > 0) evidence.Add($"生命 {result.Evidence.FinalHp}/{result.Evidence.MaxHp}");
        if (result.Evidence.PotionsRecorded) evidence.Add($"剩余药水 {result.Evidence.RemainingPotions.Count} 瓶");
        if (result.Evidence.PotionsUsed != null) evidence.Add($"本局用药 {result.Evidence.PotionsUsed} 次");
        Contender("player", CareerEngine.Name(data) + (_multiplayer != null ? " · 我的表现" : ""), result.Character, MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)
            + (!result.Win && result.RunSeconds > 0 ? " · " + MatchRules.Time(result.RunSeconds) : ""), string.Join(" · ", evidence));
        Contender(result.OpponentId, result.Opponent + (_multiplayer != null ? " · 对方队长" : ""), CareerEngine.Person(data, result.OpponentId)?.Character ?? "", result.Settlement?.OpponentPerformance
            ?? (match != null ? MatchRules.Performance(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds) : "对手详细成绩未记录"), "");
        string decider = result.Settlement?.Decider ?? match?.Decider ?? "";
        if (decider.Length > 0) _content.AddChild(Text(decider, 15, _muted));
        var rewards = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }; rewards.AddThemeConstantOverride("h_separation", 18); _content.AddChild(rewards);
        void Reward(string title, string value, string description)
        { var card = Card(); rewards.AddChild(card); var box = Inner(card); box.AddChild(Text(title, 16, _muted)); box.AddChild(Text(value, 29, accent)); box.AddChild(Text(description, 14, _muted)); }
        Reward("本场收入", "+" + CareerMoney.Format(result.Prize), "含本场合同与荣誉奖励");
        Reward("关注变化", $"{result.FansDelta:+0;-0;0}", result.Settlement is { } snapshot ? $"赛后关注 {snapshot.Fans}" : "本场新增关注");
        Reward("选手评分", $"{result.RatingDelta:+0;-0;0}", result.Settlement is { } record ? $"赛后评分 {record.Rating}" : "本场评分变化");
        foreach (string effect in result.LifeEffects) _content.AddChild(Text(effect, 16, CareerVisuals.Teal));
        if (result.PlayedAscension > result.Ascension) _content.AddChild(Text($"本场挑战进阶 {result.PlayedAscension} · 挑战奖励 ×{result.RewardMultiplier:0.00}", 16, CareerVisuals.Teal));
        if (result.WorldImpact.Length > 0 || result.Settlement?.Honors.Count > 0)
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card); box.AddChild(Text("属于这一场的收获", 23, _gold));
            if (result.WorldImpact.Length > 0) box.AddChild(Text(result.WorldImpact, 18, _ink));
            foreach (var honor in result.Settlement?.Honors ?? []) box.AddChild(Text("◆ " + honor, 20, _gold));
        }
        _content.AddChild(Text("赛后排名", 24, _gold));
        if (result.Settlement is { } captured)
        {
            var rankings = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            rankings.AddThemeConstantOverride("h_separation", 18); rankings.AddThemeConstantOverride("v_separation", 14); _content.AddChild(rankings);
            foreach (var standing in captured.Standings)
            {
                var card = Card(); rankings.AddChild(card); var box = Inner(card); box.AddChild(Text(standing.Title, 16, _muted));
                box.AddChild(Text(standing.Value, 31, accent)); box.AddChild(Text(standing.Detail, 16, _ink));
                foreach (string nearby in standing.Nearby) box.AddChild(Text(nearby, 15, nearby.StartsWith('▸') ? _gold : _muted));
            }
            _content.AddChild(Text("排名记录于本场结算时；同日其他比赛尚未结束时，名次仍可能变化。", 14, _muted));
        }
        else _content.AddChild(Text("这份旧战报未保存当时的排名。", 16, _muted));
        if (result.Settlement?.Competition is { } competition) CompetitionOverview(data, competition);
        if (result.Evidence.DefeatedEncounters is { Count: > 0 } encounters)
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text(_multiplayer != null ? "全队击败的精英与 BOSS" : "本局击败的精英与 BOSS", 22, _gold));
            foreach (var act in encounters.GroupBy(e => e.Act))
            {
                box.AddChild(Text($"第 {act.Key} 幕", 17, CareerVisuals.Teal));
                foreach (var encounter in act)
                    box.AddChild(Text($"第 {encounter.Floor} 层 · {(encounter.Kind == "Boss" ? "BOSS" : "精英")} · {encounter.Name}", 16, _ink));
            }
        }
        if (result.Evidence.Badges.Count > 0)
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card); box.AddChild(Text("对局徽章", 22, _gold));
            foreach (var badge in result.Evidence.Badges.Take(6)) box.AddChild(Text("◆ " + badge.Name + "   ·   " + badge.Description, 16, _ink));
        }
        var chart = Card(); _content.AddChild(chart); var cb = Inner(chart); cb.AddChild(Text("最近八场 · 到达楼层", 19, _gold));
        cb.AddChild(new ResultChart { Results = data.Results.TakeLast(8).ToList(), CustomMinimumSize = new Vector2(520, 130), SizeFlagsHorizontal = SizeFlags.ExpandFill });
        _settlementMatch = result.MatchId; _settlementCommunity = Text("", 17, CareerVisuals.Teal); _content.AddChild(_settlementCommunity); RefreshSettlementDiscussion(data);
        var controls = new HBoxContainer(); controls.AddThemeConstantOverride("separation", 12); _content.AddChild(controls);
        controls.AddChild(Button("查看社区讨论", () => { var post = CommunityThreads.All(data).FirstOrDefault(p => p.EventKey == "match" + result.MatchId); if (post != null) OpenPost(post); else OpenCommunity(); }, 220));
        controls.AddChild(Button("继续赛季", () => SwitchTab("首页"), 180));
    }
    private void CompetitionOverview(CareerData data, CompetitionReview review)
    {
        var heading = Card(); heading.Name = "CompetitionOverview"; _content.AddChild(heading); var intro = Inner(heading);
        intro.AddChild(Text("同期赛况   /   " + review.Name, 25, _gold));
        intro.AddChild(Text(review.PreviousMatchDay is { } day
            ? $"从你上次参加本赛事（第 {SeasonCalendar.Day(data, day)} 天）至本次结算 · 名次与积分变化均以该场结算为起点"
            : "截至本次结算的赛事全貌 · 尚无上次排名记录，暂不显示升降", 15, _muted));
        foreach (var table in review.Tables.Where(t => t.Rows.Count > 0))
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text(table.Title, 23, _gold)); box.AddChild(Text(table.Note, 14, _muted));
            bool hasRecord = table.Rows.Any(r => r.Record.Length > 0);
            HBoxContainer Line(Control parent)
            {
                var line = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                line.AddThemeConstantOverride("separation", 16); parent.AddChild(line); return line;
            }
            void Cell(HBoxContainer row, string value, int width, Color color, int size = 17, bool expand = false)
            {
                var label = Text(value, size, color); label.CustomMinimumSize = new Vector2(width, 0);
                label.SizeFlagsHorizontal = expand ? SizeFlags.ExpandFill : SizeFlags.Fill; row.AddChild(label);
            }
            var headerMargin = new MarginContainer(); headerMargin.AddThemeConstantOverride("margin_left", 10); headerMargin.AddThemeConstantOverride("margin_right", 10); box.AddChild(headerMargin);
            var header = Line(headerMargin);
            Cell(header, "名次", 50, _muted, 14); Cell(header, table.Id == "teams" ? "俱乐部" : table.Id == "nations" ? "国家 / 地区" : "选手", 180, _muted, 14, true);
            if (hasRecord) Cell(header, "累计战绩", 140, _muted, 14);
            Cell(header, table.Id == "nations" ? "国运 / 增量" : "积分 / 增量", 160, _muted, 14); Cell(header, "名次变化", 80, _muted, 14);
            var extra = new List<Control>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var r = table.Rows[i];
                var strip = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(r.PlayerRelated ? "254247" : i % 2 == 0 ? "192d3b" : "152532", r.PlayerRelated ? "5c9a9b" : "263e4c", 5, 10));
                box.AddChild(strip); var row = Line(strip);
                Cell(row, r.Rank > 0 ? $"{r.Rank:00}" : "—", 50, r.Rank is > 0 and <= 3 ? _gold : _muted, 21);
                string marker = !r.PlayerRelated ? "" : table.Id == "teams" ? " · 你的俱乐部" : table.Id == "nations" ? " · 你的赛区" : " · 你";
                Cell(row, r.Name + marker, 180, r.PlayerRelated ? _gold : _ink, 18, true);
                if (hasRecord) Cell(row, r.Record, 140, _muted, 15);
                string delta = r.PreviousPoints is { } oldPoints ? $"   ({r.Points - oldPoints:+0;-0;0})" : "";
                Cell(row, r.Points + delta, 160, CareerVisuals.Teal, 18);
                string change = "—"; Color changeColor = _muted;
                if (r.PreviousRank is { } oldRank)
                {
                    int movement = oldRank - r.Rank;
                    change = oldRank == 0 && r.Rank > 0 ? "新上榜" : r.Rank == 0 && oldRank > 0 ? "暂未上榜" : movement == 0 ? "持平" : movement > 0 ? $"↑ {movement}" : $"↓ {-movement}";
                    changeColor = change == "新上榜" || movement > 0 && r.Rank > 0 ? CareerVisuals.Teal : movement < 0 ? new Color("d5a59a") : _muted;
                }
                Cell(row, change, 80, changeColor, 16);
                if (i >= 8 && !r.PlayerRelated) { strip.Visible = false; extra.Add(strip); }
            }
            if (extra.Count > 0)
            {
                bool expanded = false;
                string unit = table.Id == "teams" ? "支队伍" : table.Id == "nations" ? "个国家 / 地区" : "位";
                var toggle = Button($"展开完整榜单 · 共 {table.Rows.Count} {unit}", () => { }, 240); box.AddChild(toggle);
                toggle.Pressed += () => { expanded = !expanded; foreach (var row in extra) row.Visible = expanded; toggle.Text = expanded ? "收起榜单" : $"展开完整榜单 · 共 {table.Rows.Count} {unit}"; };
            }
        }
        var scores = Card(); _content.AddChild(scores); var content = Inner(scores);
        content.AddChild(Text(review.PreviousMatchDay != null ? "这期间的对阵" : "已结束的对阵", 23, _gold));
        if (review.Scores.Count == 0) { content.AddChild(Text("本赛事暂无新增完赛记录。", 16, _muted)); return; }
        var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 12); content.AddChild(grid);
        var hidden = new List<Control>();
        for (int i = 0; i < review.Scores.Count; i++)
        {
            var score = review.Scores[i]; var card = Card(); grid.AddChild(card); var box = Inner(card);
            box.AddChild(Text($"第 {SeasonCalendar.Day(data, score.Day)} 天 · {score.Round}", 14, _muted));
            box.AddChild(Text($"{score.Home}   {score.Score}   {score.Away}", 20, score.PlayerRelated ? _gold : _ink));
            box.AddChild(Text(score.Outcome, 16, CareerVisuals.Teal));
            if (i >= 6) { card.Visible = false; hidden.Add(card); }
        }
        if (hidden.Count > 0)
        {
            bool expanded = false;
            var toggle = Button($"查看全部对阵 · 共 {review.Scores.Count} 场", () => { }, 240); content.AddChild(toggle);
            toggle.Pressed += () => { expanded = !expanded; foreach (var card in hidden) card.Visible = expanded; toggle.Text = expanded ? "收起对阵" : $"查看全部对阵 · 共 {review.Scores.Count} 场"; };
        }
    }

}

/// <summary>静态绘制赛后奖章，避免依赖额外纹理或常驻动画。</summary>
public partial class MatchMedallion : Control
{
    public bool Victory { get; set; }
    public Color Accent { get; set; } = CareerVisuals.Gold;
    public override void _Draw()
    {
        var center = Size / 2;
        Vector2 P(float x, float y) => center + new Vector2(x, y);
        DrawCircle(center, 77, new Color(Accent, .07f));
        for (int side = -1; side <= 1; side += 2)
        {
            for (int i = 0; i < 7; i++)
            {
                float angle = Mathf.DegToRad(24 + i * 18); var stem = P(side * 65 * Mathf.Sin(angle), 65 * Mathf.Cos(angle));
                DrawColoredPolygon([stem, stem + new Vector2(side * 15, -9), stem + new Vector2(side * 12, -24), stem + new Vector2(side * 2, -14)], i % 2 == 0 ? Accent : Accent.Darkened(.3f));
            }
        }
        Vector2[] rim = [P(0, -64), P(48, -34), P(48, 26), P(0, 59), P(-48, 26), P(-48, -34), P(0, -64)];
        DrawColoredPolygon(rim[..^1], new Color("122435")); DrawPolyline(rim, Accent, 3, true);
        DrawPolyline(rim.Select(p => center + (p - center) * .86f).ToArray(), Accent.Darkened(.45f), 1, true);
        if (Victory)
        {
            DrawColoredPolygon([P(-25, -27), P(25, -27), P(19, 1), P(0, 17), P(-19, 1)], Accent);
            DrawColoredPolygon([P(-25, -27), P(0, -27), P(0, 17), P(-19, 1)], Accent.Lightened(.22f));
            DrawArc(P(-24, -17), 12, Mathf.Pi * .5f, Mathf.Pi * 1.5f, 14, Accent, 4, true);
            DrawArc(P(24, -17), 12, -Mathf.Pi * .5f, Mathf.Pi * .5f, 14, Accent, 4, true);
            DrawLine(P(0, 12), P(0, 29), Accent, 5, true); DrawLine(P(-16, 30), P(16, 30), Accent, 5, true);
        }
        else
        {
            DrawColoredPolygon([P(0, -29), P(21, 0), P(0, 29), P(-21, 0)], Accent);
            DrawColoredPolygon([P(0, -29), P(0, 29), P(-21, 0)], Accent.Lightened(.22f));
        }
    }
}
