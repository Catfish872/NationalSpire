using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private int _ceremonySeason;
    private string _ceremonySection = "获奖名单";
    private bool _ceremonyRules;

    private void OpenCeremony() => OpenWorldSection("颁奖盛典");

    private Control CeremonyWeeklyCover(CareerData data, WeeklySlide slide, bool large)
    {
        var record = data.Ceremonies.FirstOrDefault(c => c.Season == slide.CeremonySeason);
        bool annual = record?.YearTop.Count > 0;
        var panel = new PanelContainer { Name = "CeremonyWeeklyCover", MouseFilter = MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172d3d", "d2ac66", 10, large ? 26 : 10));
        if (large) { panel.CustomMinimumSize = new Vector2(0, 260); panel.SizeFlagsHorizontal = SizeFlags.ExpandFill; }
        else panel.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var box = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Ignore };
        box.AddThemeConstantOverride("separation", large ? 10 : 3); panel.AddChild(box);
        var imprint = CeremonyLine("NATIONAL SPIRE  /  HONOURS", large ? 15 : 10, CareerVisuals.Teal);
        imprint.HorizontalAlignment = HorizontalAlignment.Center; box.AddChild(imprint);
        box.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(large ? 112 : 72, large ? 112 : 72),
            SizeFlagsHorizontal = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore });
        var title = CeremonyLine(annual ? "年度荣誉特刊" : "赛季荣誉特刊", large ? 32 : 21, _gold);
        title.HorizontalAlignment = HorizontalAlignment.Center; box.AddChild(title);
        var caption = CeremonyLine(annual ? $"第 {record!.Year} 年 · 年度 TOP 20 与各项大奖" : $"第 {slide.CeremonySeason} 赛季 · 荣誉揭晓", large ? 18 : 12, _ink);
        caption.HorizontalAlignment = HorizontalAlignment.Center; box.AddChild(caption);
        return panel;
    }

    private static Label CeremonyLine(string value, int size, Color color, float width = 0)
    {
        var label = Text(value, size, color);
        label.AutowrapMode = TextServer.AutowrapMode.Off;
        label.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
        label.ClipText = true;
        label.CustomMinimumSize = new Vector2(width, 0);
        label.SizeFlagsVertical = SizeFlags.ShrinkCenter;
        if (width > 0) label.SizeFlagsHorizontal = SizeFlags.Fill;
        label.TooltipText = value;
        return label;
    }

    private static string CeremonySelf(CareerData data) => data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player";
    private bool CeremonyOwn(CareerData data, CeremonyAward award) =>
        award.WinnerId == CeremonySelf(data) || award.Recipients.Contains(CeremonySelf(data))
        || award.WinnerName.Length == 0 && award.Recipients.Count == 0 && award.ClubId.Length > 0 && award.ClubId == data.Esports.ClubId;

    private string CeremonyWinner(CareerData data, CeremonyAward award) => award.WinnerName.Length > 0 ? award.WinnerName : award.ClubId.Length > 0
        ? EsportsWorld.ClubName(data, award.ClubId) : award.WinnerId == "player" && data.LocalHumanId.Length > 0 ? "共同参赛阵容" : CareerEngine.DisplayName(data, award.WinnerId);

    private void CeremonyInvitation(CareerData data)
    {
        var latest = data.Ceremonies.OrderByDescending(c => c.Season).FirstOrDefault();
        var card = Card(); card.Name = "CeremonyInvitation";
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("202f37", "8d794f", 10, 20));
        _content.AddChild(card);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 20); card.AddChild(row);
        row.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(72, 72), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        var caption = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(caption);
        caption.AddChild(Text(latest == null ? "赛季颁奖盛典" : latest.YearTop.Count > 0
            ? $"第 {latest.Year} 年度荣誉之夜" : $"第 {latest.Season} 赛季 · 荣誉揭晓", 23, _gold));
        string honors = latest == null ? "" : string.Join(" · ", latest.Awards.Where(a => CeremonyOwn(data, a)).Select(a => a.Title));
        caption.AddChild(Text(latest == null ? "赛季结束后揭晓奖项，历届荣誉在这里保存。"
            : honors.Length > 0 ? "你的本届荣誉  ·  " + honors : "本届获奖名单与选手排名已经公布。", 16, _ink));
        var enter = Button(latest == null ? "查看盛典   →" : "查看本届盛典   →", () =>
        { _ceremonySeason = latest?.Season ?? 0; _ceremonySection = "获奖名单"; OpenCeremony(); }, 210);
        enter.SizeFlagsVertical = SizeFlags.ShrinkCenter; Emphasize(enter); row.AddChild(enter);
    }

    private void Ceremony(CareerData data)
    {
        var archives = data.Ceremonies.OrderByDescending(c => c.Season).ToList();
        CeremonyRecord? record = archives.FirstOrDefault(c => c.Season == _ceremonySeason) ?? archives.FirstOrDefault();
        var controls = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        controls.AddThemeConstantOverride("separation", 12); _content.AddChild(controls);
        controls.AddChild(Button("荣誉室", () => OpenWorldSection("荣誉室"), 120));
        if (archives.Count > 0)
        {
            var selection = new OptionButton { Name = "CeremonyArchive", CustomMinimumSize = new Vector2(240, 48) };
            foreach (var item in archives) selection.AddItem(item.YearTop.Count > 0
                ? $"第 {item.Year} 年度 · 第 {item.Season} 赛季" : $"第 {item.Season} 赛季", item.Season);
            selection.Select(Math.Max(0, archives.FindIndex(c => c.Season == record?.Season)));
            selection.ItemSelected += chosen =>
            { _ceremonySeason = selection.GetItemId((int)chosen); _scroll.ScrollVertical = 0; Render(); };
            controls.AddChild(selection);
        }
        controls.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        if (record == null)
        {
            AddHeading("赛季颁奖盛典", "第一个赛季结束后揭晓奖项，并自动展示本届盛典。");
            return;
        }
        if (_ceremonySection == "年度 TOP 20" && record.YearTop.Count == 0) _ceremonySection = "本季排名";
        CeremonyHero(data, record);
        var sections = new HBoxContainer { Name = "CeremonySections" }; sections.AddThemeConstantOverride("separation", 10); _content.AddChild(sections);
        var sectionNames = record.YearTop.Count > 0 ? new List<string> { "获奖名单", "年度 TOP 20", "本季排名" } : new List<string> { "获奖名单", "本季排名" };
        foreach (string section in sectionNames)
        {
            var button = Button(section, () => { _ceremonySection = section; _scroll.ScrollVertical = 0; Render(); }, 180);
            if (section == _ceremonySection) Emphasize(button); sections.AddChild(button);
        }
        if (_ceremonySection == "获奖名单") CeremonyAwards(data, record);
        else CeremonyRanking(data, _ceremonySection == "年度 TOP 20" ? (record.FullYear.Count > 0 ? record.FullYear : record.YearTop) : (record.FullSeason.Count > 0 ? record.FullSeason : record.SeasonTop));

        var rules = Button(_ceremonyRules ? "收起评选依据" : "查看评选依据", () =>
        { int y = _scroll.ScrollVertical; _ceremonyRules = !_ceremonyRules; Render(); _ = RestoreScrollAsync(y, _renderVersion); }, 180);
        _content.AddChild(rules);
        if (_ceremonyRules)
        {
            var method = Card(); _content.AddChild(method); var explanation = Inner(method);
            explanation.AddChild(Text(record.RulesVersion >= 2 ? SeasonCeremony.ScoringRules : "此届按旧版规则授予，保留原始得分与荣誉。新规则从更新后举行的盛典执行。", 16, _ink));
            if (record.RulesVersion >= 2) explanation.AddChild(Text(SeasonCeremony.ClubRules + "新秀以首次职业参赛记录为准，至少出场两次。", 16, _muted));
            var self = (_ceremonySection == "年度 TOP 20" ? record.FullYear : record.FullSeason).FirstOrDefault(r=>r.Id==CeremonySelf(data));
            if (self != null) foreach (string line in self.Breakdown) explanation.AddChild(Text(line, 15, _muted));
        }
    }

    private void CeremonyHero(CareerData data, CeremonyRecord record)
    {
        var personal = record.Awards.Where(a => CeremonyOwn(data, a)).OrderByDescending(a => a.Title.StartsWith("年度")).ToList();
        var feature = personal.FirstOrDefault(a => a.WinnerId == CeremonySelf(data)) ?? personal.FirstOrDefault() ?? record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).FirstOrDefault();
        var hero = Card(); hero.Name = "CeremonyHero";
        hero.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1e303d", "c4a56b", 12, 26));
        if (hero is BroadcastPanel panel) panel.Accent = new Color("e5bc72");
        _content.AddChild(hero);
        var stage = new HBoxContainer(); stage.AddThemeConstantOverride("separation", 28); hero.AddChild(stage);
        var medal = new CeremonyMedallion { CustomMinimumSize = new Vector2(152, 174), SizeFlagsVertical = SizeFlags.ShrinkCenter };
        stage.AddChild(medal);
        if (feature?.WinnerId.Length > 0)
        {
            medal.ShowCrown = false;
            var portrait = Avatar(data, feature.WinnerId, 76, true); medal.AddChild(portrait);
            portrait.SetAnchorsAndOffsetsPreset(LayoutPreset.Center);
            portrait.OffsetLeft = portrait.OffsetTop = -38; portrait.OffsetRight = portrait.OffsetBottom = 38;
        }
        var opening = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; opening.AddThemeConstantOverride("separation", 8); stage.AddChild(opening);
        opening.AddChild(CeremonyLine($"NATIONAL SPIRE   /   SEASON {record.Season:00}", 13, CareerVisuals.Teal));
        opening.AddChild(Text(record.YearTop.Count > 0 ? $"第 {record.Year} 年度荣誉之夜" : $"第 {record.Season} 赛季 · 颁奖盛典", 32, _gold));
        var annualTop = record.YearTop.FirstOrDefault(r => r.Id == CeremonySelf(data));
        if (annualTop != null) opening.AddChild(Text($"你入选年度 TOP 20 · 第 {annualTop.Place} 名 · 关注 +120", 24, CareerVisuals.Teal));
        if (feature != null) opening.AddChild(Text(CeremonyWinner(data, feature) + "  ·  " + feature.Title, 24, _ink));
        opening.AddChild(Text(personal.Count > 0 ? $"你在本届获得 {personal.Count} 项荣誉，成绩已收入生涯档案。"
            : "本届荣誉已经揭晓，正式比赛的每一份成绩都有记录。", 16, _muted));
    }

    private void CeremonyAwards(CareerData data, CeremonyRecord record)
    {
        var awards = record.Awards.OrderByDescending(a => CeremonyOwn(data, a)).ThenByDescending(a => a.Title.StartsWith("年度")).ToList();
        if (awards.Count == 0) { _content.AddChild(Text("本季正式比赛尚不足以评出奖项。赛季记录已经保留。", 18, _muted)); return; }
        var grid = new GridContainer { Name = "CeremonyAwardGrid", Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); _content.AddChild(grid);
        foreach (var award in awards)
        {
            bool own = CeremonyOwn(data, award);
            var card = Card(); card.Name = "CeremonyAward_" + award.Title.Replace(' ', '_');
            card.CustomMinimumSize = new Vector2(0, 186);
            card.AddThemeStyleboxOverride("panel", CareerVisuals.Box(own ? "243b3d" : "142737", own ? "bfa266" : "3d5665", 10, 22));
            if (card is BroadcastPanel panel) panel.Accent = own ? _gold : CareerVisuals.Teal;
            grid.AddChild(card); var box = Inner(card);
            var title = new HBoxContainer(); box.AddChild(title);
            title.AddChild(CeremonyLine(award.Title, 20, _gold));
            if (own) title.AddChild(CeremonyLine("你的荣誉", 13, CareerVisuals.Teal, 72));
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);
            if (award.WinnerId.Length > 0) row.AddChild(Avatar(data, award.WinnerId, 62, true));
            else row.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(62, 62) });
            var identity = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter };
            row.AddChild(identity);
            var name = CeremonyLine(CeremonyWinner(data, award), 25, _ink); name.Name = "CeremonyWinnerName"; identity.AddChild(name);
            identity.AddChild(CeremonyLine($"评选得分  {award.Score}", 15, _muted));
            box.AddChild(Text(award.Reason, 15, _muted));
            if (own) box.AddChild(Text($"获奖关注 +{SeasonCeremony.RewardAmount(award)} · 已收入荣誉档案", 15, CareerVisuals.Teal));
        }
    }

    private void CeremonyRanking(CareerData data, List<CeremonyRank> entries)
    {
        if (entries.Count == 0) { _content.AddChild(Text("本期尚无可展示的正式比赛成绩。", 18, _muted)); return; }
        int playerRank = entries.FindIndex(r => r.Id == CeremonySelf(data));
        _content.AddChild(Text(playerRank >= 0
            ? $"你位列第 {(entries[playerRank].Place > 0 ? entries[playerRank].Place : playerRank + 1)} 名 · {entries[playerRank].Score} 分"
            : "本期前二十名 · 按正式比赛评选得分排名", 23, _gold));
        // 整行占满内容区；姓名独占剩余宽度，排名、战绩与得分均保持单行。
        var list = new VBoxContainer { Name = "CeremonyRanking", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        list.AddThemeConstantOverride("separation", 7); _content.AddChild(list);
        var header = new MarginContainer(); header.AddThemeConstantOverride("margin_left", 18); header.AddThemeConstantOverride("margin_right", 18);
        list.AddChild(header);
        var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 18); header.AddChild(columns);
        columns.AddChild(CeremonyLine("名次", 14, _muted, 54));
        columns.AddChild(CeremonyLine("选手", 14, _muted));
        foreach (string caption in new[] { "出场", "获胜", "通关", "评选得分" })
        {
            var label = CeremonyLine(caption, 14, _muted, caption == "评选得分" ? 110 : 76);
            label.HorizontalAlignment = HorizontalAlignment.Right; columns.AddChild(label);
        }
        var visible = entries.Where((r, i) => (r.Place > 0 ? r.Place : i + 1) <= 20 || r.Id == CeremonySelf(data)).ToList();
        for (int i = 0; i < visible.Count; i++)
        {
            var entry = visible[i]; bool own = entry.Id == CeremonySelf(data);
            var strip = new PanelContainer { Name = $"CeremonyRank_{i + 1}", SizeFlagsHorizontal = SizeFlags.ExpandFill };
            strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(own ? "27403f" : i < 3 ? "233646" : "142535", own ? "d2ac66" : "344c59", 7, 18)); list.AddChild(strip);
            var line = new HBoxContainer(); line.AddThemeConstantOverride("separation", 18); strip.AddChild(line);
            var rank = CeremonyLine($"{(entry.Place > 0 ? entry.Place : i + 1):00}", 25, i < 3 || own ? _gold : _muted, 54); rank.Name = "CeremonyRankNumber"; line.AddChild(rank);
            var name = CeremonyLine((entry.Name.Length > 0 ? entry.Name : CareerEngine.DisplayName(data, entry.Id)) + (entry.Shared ? " · 共同成绩" : ""), 21, own ? _gold : _ink);
            name.Name = "CeremonyRankName";
            line.AddChild(WithAvatar(data, entry.Id, name, 44, true));
            foreach (var metric in new[] { (entry.Matches, 76), (entry.Wins, 76), (entry.Clears, 76), (entry.Score, 110) })
            {
                var value = CeremonyLine(metric.Item1.ToString(), metric.Item2 == 110 ? 24 : 18, metric.Item2 == 110 ? _gold : _muted, metric.Item2);
                value.HorizontalAlignment = HorizontalAlignment.Right; value.Name = metric.Item2 == 110 ? "CeremonyRankScore" : "CeremonyRankStat"; line.AddChild(value);
            }
        }
        if (playerRank < 0) _content.AddChild(Text("你本期的完整比赛记录可在生涯战报中查看。", 15, _muted));
    }
}
public partial class CeremonyMedallion : Control
{
    public bool ShowCrown { get; set; } = true;
    private float _time;
    public override void _Process(double delta) { _time += (float)delta; QueueRedraw(); }
    public override void _Draw()
    {
        var center = Size / 2; float radius = Math.Min(Size.X, Size.Y) * .38f;
        var gold = new Color("e7c27e"); var pale = new Color("fae7bc");
        for (int i = 0; i < 24; i++)
        {
            float angle = i * Mathf.Tau / 24 + _time * .06f;
            Vector2 direction = new(Mathf.Cos(angle), Mathf.Sin(angle));
            DrawLine(center + direction * (radius * 1.03f), center + direction * (radius * (i % 3 == 0 ? 1.25f : 1.14f)),
                gold with { A = i % 3 == 0 ? .62f : .28f }, i % 3 == 0 ? 2 : 1, true);
        }
        DrawCircle(center, radius, new Color("253c45"));
        DrawArc(center, radius, 0, Mathf.Tau, 96, gold, 4, true);
        DrawArc(center, radius * .87f, 0, Mathf.Tau, 96, new Color("7c7864"), 2, true);
        if (!ShowCrown) return;
        Vector2 P(float x, float y) => center + new Vector2(x, y) * radius;
        DrawColoredPolygon([P(-.63f, -.34f), P(-.32f, -.12f), P(0, -.59f), P(.32f, -.12f), P(.63f, -.34f), P(.48f, .29f), P(-.48f, .29f)], gold);
        DrawLine(P(-.38f, .42f), P(.38f, .42f), pale, 5, true);
        DrawCircle(P(0, -.6f), 5, pale);
        for (int i = -1; i <= 1; i++) DrawCircle(P(i * .28f, -.13f), 3, pale);
    }
}
