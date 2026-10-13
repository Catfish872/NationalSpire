using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _worldSection = "国运榜";
    private string? _competitionId;
    // 「国家发展」当前查看的国家；null / 找不到时回落到本国。只影响界面，不写存档。
    private string? _nationFocus;
    private void World(CareerData data)
    {
        if (_worldSection == "俱乐部" && _clubDraft != null) { ClubWizard(data); return; }
        if (_worldSection == "俱乐部" && OwnedClubs.IsOwner(data)) { OwnedClubPanel(data); return; }
        if (_worldSection == "颁奖盛典") { Ceremony(data); return; }
        AddHeading("世界电竞中心", $"{EsportsWorld.Countries.Length} 个国家 · {data.Esports.Clubs.Count} 家俱乐部 · {data.People.Count} 位世界居民");
        var identity = Card(); _content.AddChild(identity); var ib = Inner(identity);
        ib.AddChild(WithAvatar(data, "player", Text($"{EsportsWorld.LicenseName(data)}    /    {EsportsWorld.ClubName(data, data.Esports.ClubId)}", 27, _gold), 64));
        ib.AddChild(Text($"国籍：{data.Esports.Country}    ·    {(data.Esports.NationalTeam ? "本赛季国家队代表" : "尚未入选本赛季国家队")}    ·    连胜 {data.Esports.WinStreak}", 17, _ink));
        ib.AddChild(Text("当前目标：" + EsportsWorld.NextGoal(data), 18, CareerVisuals.Teal));
        ib.AddChild(Text(CareerNarrative.PlayerEvaluation(data), 16, _muted));
        var tabs = new HFlowContainer(); _content.AddChild(tabs);
        foreach (string section in new[] { "国运榜", "国家发展", "人气榜", "世界荣誉", "世界积分", "赛事总览", "俱乐部", "荣誉室", "晋级规则" }) tabs.AddChild(Button(section, () => OpenWorldSection(section), 155));
        if (_worldSection == "国运榜") { NationRanking(data); return; }
        if (_worldSection == "国家发展") { NationDevelopment(data); return; }
        if (_worldSection == "人气榜") { FanChart(data); return; }
        if (_worldSection == "世界荣誉") { WorldHonors(data); return; }
        if (_worldSection == "世界积分") { CircuitRanking(data); return; }
        if (_worldSection == "俱乐部") { Clubs(data); return; }
        if (_worldSection == "荣誉室") { Honors(data); return; }
        if (_worldSection == "晋级规则") { if (data.Esports.Competitions.Any(c => c.Season == data.Season && c.Modern)) ModernRules(); else CompetitionRules(); return; }
        if (_competitionId != null)
        {
            var competition = data.Esports.Competitions.FirstOrDefault(c => c.Id == _competitionId);
            if (competition != null) Competition(data, competition);
            else _content.AddChild(Text("暂时找不到这项赛事，请返回赛事总览。", 18, _muted));
            return;
        }
        var offers = data.Esports.Offers.Count(o => o.ExpiresDay >= data.Day);
        if (offers > 0) _content.AddChild(Button($"收到 {offers} 份俱乐部合同 · 前往查看   →", () => OpenWorldSection("俱乐部"), 410));
        int sponsors = data.Esports.SponsorOffers.Count(o => o.ExpiresDay >= data.Day);
        if (sponsors > 0) _content.AddChild(Button($"收到 {sponsors} 份赞助邀请 · 前往查看   →", () => OpenWorldSection("俱乐部"), 410));
        _content.AddChild(Text(data.Season % 2 == 0 ? "本赛季焦点：国家队世界杯" : "本赛季焦点：洲际俱乐部冠军杯", 24, _gold));
        _content.AddChild(Text(data.Esports.Competitions.Any(c => c.Season == data.Season && c.Modern) ? SeasonCalendar.Length(data) == 84 ? $"本赛区联赛共 {CircuitWorld.RoundCount(EsportsWorld.PlayerLeague(data)!)} 轮，世界大赛在赛季末举行。获得资格后，可在日程查看比赛。" : "比赛日期可在日程查看。" : "比赛日期可在日程查看。", 16, _muted));
        var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); _content.AddChild(grid);
        foreach (var c in data.Esports.Competitions.Where(c => c.Season == data.Season).OrderBy(c => c.Kind == "league" ? 1 : 0).ThenBy(c => c.Country == data.Esports.Country ? 0 : 1))
        {
            var card = Card(); grid.AddChild(card); var box = Inner(card);
            box.AddChild(Text($"{c.Country}    /    {c.Entrants.Count} 个席位    /    {(c.Finished ? "已结束" : "进行中")}", 14, _muted));
            box.AddChild(Text(c.Name, 25, c.Kind == "league" ? _ink : _gold));
            box.AddChild(Text(c.Finished ? "冠军：" + (c.TeamEvent ? CircuitWorld.TeamName(data, c, c.ChampionTeam) : CareerEngine.DisplayName(data, c.ChampionId)) : $"已完成 {c.Fixtures.Count(f => f.Finished)} / {c.Fixtures.Count} 场已排定比赛", 17, _muted));
            if (c.PlayerEntered) box.AddChild(Text("你已确认参赛席位", 15, CareerVisuals.Teal));
            box.AddChild(Button("查看积分 / 对阵   ↗", () => OpenCompetition(c.Id), 230));
        }
        _content.AddChild(Text("往届国际赛事", 23, _gold));
        var past = data.Esports.Competitions.Where(c => c.Season < data.Season && c.Kind != "league").OrderByDescending(c => c.Season).ToList();
        if (past.Count == 0) _content.AddChild(Text("首届赛事仍在进行，冠军尚未诞生。", 17, _muted));
        foreach (var c in past) _content.AddChild(Button($"第 {c.Season} 赛季 · {c.Name} · 冠军 {(c.TeamEvent ? CircuitWorld.TeamName(data, c, c.ChampionTeam) : CareerEngine.DisplayName(data, c.ChampionId))}", () => OpenCompetition(c.Id), 700));
    }
    private void Competition(CareerData data, WorldCompetition c)
    {
        if (c.Modern) { ModernCompetition(data, c); return; }
        _content.AddChild(Text($"第 {c.Season} 赛季 / {c.Name}", 28, _gold));
        if (c.Finished) _content.AddChild(WithAvatar(data, c.ChampionId, Text($"冠军：{CareerEngine.DisplayName(data, c.ChampionId)}    ·    {(c.Kind == "worldcup" ? EsportsWorld.HistoricCountry(data, c, c.ChampionId) : EsportsWorld.ClubName(data, EsportsWorld.HistoricClub(data, c, c.ChampionId)))}", 23, CareerVisuals.Teal), 56));
        if (c.Kind == "league")
        {
            _content.AddChild(Text("排名依次比较：积分、胜场、通关次数、赛前顺位。三轮结束后，前二获得国际赛事候选资格。", 16, _muted));
            var table = Card(); _content.AddChild(table); var tb = Inner(table); int rank = 0;
            foreach (var row in EsportsWorld.Ranked(c))
            {
                var line = new HBoxContainer(); tb.AddChild(line);
                var name = PersonLink(data, row.PersonId, $"{++rank:00}   {CareerEngine.DisplayName(data, row.PersonId)}   ↗", 36); line.AddChild(name);
                line.AddChild(Text($"{EsportsWorld.ClubName(data, EsportsWorld.HistoricClub(data, c, row.PersonId))}    ·    {row.Points} 分    ·    {row.Wins} 胜 {row.Draws} 平 {row.Losses} 负    ·    {row.Clears} 次通关", 16, row.PersonId == "player" ? _gold : _muted));
            }
        }
        else
        {
            _content.AddChild(Text("单败淘汰，通关优先；双方通关比用时，双方失败比楼层，完全相同按赛前种子顺位晋级。你的后续比赛在晋级后自动报名。", 16, _muted));
            _content.AddChild(Text("赛前种子顺位：" + string.Join(" / ", c.Entrants.Select((id, i) => $"{i + 1} {CareerEngine.DisplayName(data, id)}")), 15, _muted));
        }
        foreach (var round in c.Fixtures.GroupBy(f => f.Round).OrderBy(g => g.Key))
        {
            _content.AddChild(Text(c.Kind == "league" ? $"第 {round.Key} 轮" : EsportsWorld.CupRound(c.Kind, round.Key), 23, _gold));
            var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); _content.AddChild(grid);
            foreach (var f in round)
            {
                var card = Card(); grid.AddChild(card); var box = Inner(card);
                box.AddChild(Text($"第 {SeasonCalendar.Day(data, f.Day)} 天    ·    {(f.Finished ? f.Walkover ? "弃权判定" : f.Draw ? "平局" : "已结束" : "待赛")}", 14, _muted));
                foreach (string id in new[] { f.HomeId, f.AwayId })
                {
                    var name = PersonLink(data, id, (f.Finished && f.WinnerId == id ? "◆ " : "   ") + CareerEngine.DisplayName(data, id) + "   ↗", 40);
                    name.SizeFlagsHorizontal = SizeFlags.ExpandFill; box.AddChild(name);
                }
                if (f.Finished && !f.Walkover) box.AddChild(Text($"{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}\n{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}", 16, _muted));
            }
        }
    }
    private int _clubLimit = 8;
    private void Clubs(CareerData data)
    {
        ClubEntry(data);
        _content.AddChild(Text("合同与转会", 24, _gold));
        _content.AddChild(Text($"转会窗口：每赛季第1—{SeasonCalendar.LeagueDeadline(data)}天。自由选手可随时签约；错过联赛报名期，将参加下季联赛。", 16, _muted));
        if (data.Esports.PlayerContract is { } current)
        {
            var own = Card(); _content.AddChild(own); var ob = Inner(own);
            ob.AddChild(Text("当前合同 · " + EsportsWorld.ClubName(data, current.ClubId), 24, _gold));
            ob.AddChild(Text(CareerCommerce.ClubTerms(current), 17, _ink));
            ob.AddChild(Text($"本季球队目标：{CareerCommerce.ClubWins(data, current.ClubId)} / {current.GoalWins} 胜" + (data.Esports.ClubGoalSeason == data.Season ? " · 奖励已发放" : ""), 17, CareerVisuals.Teal));
        }
        var offers = data.Esports.Offers.Where(o => o.ExpiresDay >= data.Day).ToList();
        if (offers.Count == 0) _content.AddChild(Text(data.Esports.License < 3 ? "通过青训选拔后，俱乐部会发来第一批合同。" : "目前没有待处理合同。合同机会会随新赛季与国际成绩更新。", 17, _muted));
        foreach (var offer in offers)
        {
            var club = EsportsWorld.Club(data, offer.ClubId)!; var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text($"{club.Name} / {club.Country}", 24, new Color(club.Color)));
            box.AddChild(Text(club.Identity + " · " + club.Motto, 16, CareerVisuals.Teal));
            box.AddChild(Text(CareerCommerce.ClubTerms(offer), 17, _ink));
            box.AddChild(Text($"邀请剩余 {offer.ExpiresDay - data.Day + 1} 天 · 每季津贴与目标奖励各领取一次", 16, _muted));
            box.AddChild(TeamButton("接受合同", () => { if (MultiplayerCommand("propose-club", offer.ClubId)) return; var error = EsportsWorld.AcceptOffer(data, offer); Render(); Notice(error ?? "签约成功！前往日程查看比赛。", error != null); }, 180));
        }
        ShowSponsors(data);
        ClubDirectory(data);
    }
    private void ClubDirectory(CareerData data)
    {
        _content.AddChild(Text("世界俱乐部名录", 24, _gold));
        var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); _content.AddChild(grid);
        _content.AddChild(Text($"共 {data.Esports.Clubs.Count} 家俱乐部 · 当前显示 {Math.Min(_clubLimit, data.Esports.Clubs.Count)} 家", 15, _muted));
        foreach (var club in data.Esports.Clubs.OrderBy(c => c.Country == data.Esports.Country ? 0 : 1).Take(_clubLimit))
        {
            var card = Card(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332", club.Color)); grid.AddChild(card); var box = Inner(card);
            box.AddChild(Text(club.Country + "    /    累计冠军 " + club.Titles, 14, _muted));
            box.AddChild(Text(club.Name + (club.Id == data.Esports.ClubId ? "  ·  你的俱乐部" : ""), 24, new Color(club.Color)));
            box.AddChild(Text(club.Identity + " · " + club.Motto, 16, _muted));
            var sponsor = data.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.EndSeason >= data.Season);
            if (sponsor != null) box.AddChild(Text("合作品牌：" + sponsor.Brand, 15, _muted));
            box.AddChild(Text((club.Id == data.Esports.OwnedClub?.ClubId ? $"俱乐部关注 {data.Esports.OwnedClub.Fans:N0}" : $"可用资金 {CareerMoney.Format(club.Budget)}") + $" · 青训 {data.People.Count(p => p.ClubId == club.Id && p.Role == "青训选手")} 人", 16, CareerVisuals.Teal));
            if (club.SeasonReport.Length > 0) box.AddChild(Text(club.SeasonReport, 15, _muted));
            foreach (var entry in club.Ledger.TakeLast(3))
                box.AddChild(Text($"第{entry.Day}天 · {entry.Title} · {(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))}", 14, _muted));
            if (club.TrainingFund > 0) box.AddChild(Text($"待使用专项资金 {CareerMoney.Format(club.TrainingFund)}", 15, _gold));
            foreach (var p in data.People.Where(p => p.ClubId == club.Id && EsportsWorld.IsProfessional(p)).OrderByDescending(p => p.Rating))
                box.AddChild(PersonLink(data, p.Id, $"{p.PublicName}  ·  {ClubRole(data, club.Id, p.Id)}  ↗", 40));
            if (data.Esports.ClubId == club.Id) box.AddChild(PersonLink(data, "player", CareerEngine.Name(data) + " · " + ClubRole(data, club.Id, GroupChats.Human(data)) + "  ↗", 40));
            foreach (var p in data.People.Where(p => p.ClubId == club.Id && !EsportsWorld.IsProfessional(p)))
                box.AddChild(PersonLink(data, p.Id, $"{p.PublicName} · {p.Role}  ↗", 32));
        }
        if (_clubLimit < data.Esports.Clubs.Count) _content.AddChild(Button("显示更多俱乐部", () => { int y = _scroll.ScrollVertical; _clubLimit += 8; Render(); _ = RestoreScrollAsync(y, _renderVersion); }, 220));
    }
    // 真国运魔改尖塔：国运沉淀成的社会发展指标。上半是"当前查看的国家"的明细（默认本国，
    // 点下表任何国家名都能切换），下半是按列渲染的各国对比表。
    private void NationDevelopment(CareerData data)
    {
        NationalDevelopment.Ensure(data);
        _content.AddChild(Text("国家发展 · 社会指标", 30, _gold));
        _content.AddChild(Text("国际赛事赢下的国运，每赛季沉淀成各国的经济、社会与民生指标。维持三项要各缴 40 点，剩下的才用来升级；国运不足的国家会逐渐败落。", 17, _muted));
        var home = data.Esports.Nations.FirstOrDefault(n => n.Country == data.Esports.Country);
        var focus = data.Esports.Nations.FirstOrDefault(n => n.Country == _nationFocus) ?? home ?? data.Esports.Nations.FirstOrDefault();
        if (focus != null)
        {
            bool mine = ReferenceEquals(focus, home);
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            int fortune = NationalDevelopment.SeasonFortune(data, focus.Country, data.Season - 1);
            // 人均 GDP 是年化值（一季 = 84 天或 28 天），所以年化与一季产出一起给，避免"一季怎么这么高"的误读。
            box.AddChild(Text($"{focus.Country}    ·    人均 GDP {focus.Gdp:N0} 美元/年（一季产出 ≈{NationalDevelopment.QuarterlyGdp(data, focus):N0}）    ·    本季增速 {focus.GdpGrowth:P1}" + (mine ? "    ·    我的国家" : ""), 25, _gold));
            box.AddChild(Text(NationalDevelopment.GdpReading(focus.GdpGrowth), 17, CareerVisuals.Teal));
            // 增速的构成读存档里结算当时记下的数字（不是拿升级后的等级反推），这样"国运值多少增速"看得见。
            if (focus.GrowthConvergence != 0)
                box.AddChild(Text($"增速怎么来的：基础 {focus.GrowthBase:P2} + 等级 {focus.GrowthLevel:P2} + 国运 {focus.GrowthFortunePart:P2}" +
                    $"    （结算时国运 {focus.GrowthFortune}，收敛系数 ×{focus.GrowthConvergence:0.00}）", 16, _muted));
            else
                box.AddChild(Text("增速构成会在下一次赛季结算时记录。", 15, _muted));
            box.AddChild(Text($"上赛季国运 {fortune}    ·    " + (fortune >= 120 ? "三项维护均可缴纳" : fortune >= 80 ? "只能保住两项维护" : fortune >= 40 ? "只能保住一项维护" : "三项维护都缴不上，指标将全面下滑"), 16, _muted));
            if (focus.LastReport.Length > 0) box.AddChild(Text("最近一次公报 · " + focus.LastReport, 16, _muted));
            foreach (var group in new[] { "经济", "社会", "民生" })
            {
                box.AddChild(Text(group, 20, CareerVisuals.Teal));
                foreach (var indicator in NationalDevelopment.InGroup(group))
                {
                    int level = NationalDevelopment.Level(focus, indicator.Id);
                    box.AddChild(Text($"{indicator.Name}    等级 {level}" + (indicator.Id == "income" ? $"    （参考人均 GDP {NationalDevelopment.IncomeBand(level)}）" : ""), 19, LevelColor(level)));
                    box.AddChild(Text(NationalDevelopment.Description(indicator.Id, level), 16, _muted));
                }
            }
            if (!mine && home != null) box.AddChild(Button($"← 回到我的国家（{home.Country}）", () => FocusNation(home.Country), 300));
        }
        _content.AddChild(Text("各国对比", 24, _gold));
        _content.AddChild(Text("点国家名可以查看该国的九项指标明细；金色一行是你的国家，带 ◆ 的是正在查看的国家。", 15, _muted));
        var rows = NationalDevelopment.TableRows(data);
        if (rows.Count == 0) { _content.AddChild(Text("暂时没有国家资料。", 17, _muted)); return; }
        var table = Card(); _content.AddChild(table); var body = Inner(table);
        var grid = new GridContainer { Columns = NationalDevelopment.TableColumns.Count, SizeFlagsHorizontal = SizeFlags.ShrinkBegin };
        grid.AddThemeConstantOverride("h_separation", 10); grid.AddThemeConstantOverride("v_separation", 6); body.AddChild(grid);
        foreach (var column in NationalDevelopment.TableColumns)
            grid.AddChild(NationCell(column.Kind == NationalDevelopment.TableCell.Separator ? "｜" : column.Header, _muted, column.Width, 16, column.Center));
        foreach (var row in rows)
        {
            bool viewing = focus != null && row.Country == focus.Country;
            for (int c = 0; c < row.Cells.Length; c++)
            {
                var column = NationalDevelopment.TableColumns[c];
                string text = row.Cells[c];
                if (column.Kind == NationalDevelopment.TableCell.Country)
                {
                    var name = Button((viewing ? "◆ " : "") + text, () => FocusNation(row.Country), column.Width);
                    name.TooltipText = $"查看{row.Country}的九项指标明细";
                    name.AddThemeColorOverride("font_color", row.Mine ? _gold : _ink);
                    grid.AddChild(name);
                }
                else if (column.Kind == NationalDevelopment.TableCell.Level)
                    grid.AddChild(NationCell(text, row.Mine ? _gold : LevelColor(int.Parse(text)), column.Width, 17, true));
                else if (column.Kind == NationalDevelopment.TableCell.Separator) grid.AddChild(NationCell("", _muted, column.Width, 16, true));
                else if (column.Kind == NationalDevelopment.TableCell.Gdp) grid.AddChild(NationCell(text, row.Mine ? _gold : _ink, column.Width, 17, true));
                else grid.AddChild(NationCell(text, _gold, column.Width, 15, true));
            }
        }
    }

    /// <summary>对比表里的单元格：列宽固定、不换行，所以同一列的数字天然对齐（不再靠空格凑）。</summary>
    private Label NationCell(string text, Color color, float width, int size, bool center)
    {
        var label = Text(text, size, color);
        label.AutowrapMode = TextServer.AutowrapMode.Off;
        label.SizeFlagsHorizontal = SizeFlags.ShrinkBegin;
        label.SizeFlagsVertical = SizeFlags.ShrinkCenter;
        label.VerticalAlignment = VerticalAlignment.Center;
        label.CustomMinimumSize = new Vector2(width, 0);
        if (center) label.HorizontalAlignment = HorizontalAlignment.Center;
        return label;
    }

    /// <summary>切换对比表上方明细卡片的国家；只重画当前页，不改变存档。</summary>
    private void FocusNation(string country)
    {
        if (_nationFocus == country) return;
        int y = _scroll.ScrollVertical;
        _nationFocus = country;
        Render();
        _ = RestoreScrollAsync(y, _renderVersion);
    }

    private Color LevelColor(int level) => level >= 7 ? _gold : level <= 3 ? new Color("ee929d") : _ink;

    private void Honors(CareerData data)
    {
        _content.AddChild(Text("荣誉陈列室", 29, _gold));
        _content.AddChild(Text("一路赢得的冠军和荣誉，都留在这里。", 16, _muted));
        CeremonyInvitation(data);
        if (data.Esports.Honors.Count == 0) _content.AddChild(Text("这里的第一件纪念，将来自你的第一场晋级。", 20, _ink));
        var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); _content.AddChild(grid);
        foreach (var h in data.Esports.Honors.AsEnumerable().Reverse())
        {
            var card = Card(); grid.AddChild(card); var box = Inner(card);
            box.AddChild(Text($"第 {h.Season} 赛季    /    第 {SeasonCalendar.Day(data, h.Day)} 天", 14, _muted));
            box.AddChild(Text("◆ " + h.Title, 25, _gold)); box.AddChild(Text(h.Detail, 17, _ink));
        }
        _content.AddChild(Text("交手档案", 24, _gold));
        foreach (var rival in data.Esports.Duels.OrderByDescending(x => x.LastDay).Take(12))
            _content.AddChild(PersonLink(data, rival.PersonId, $"{CareerEngine.DisplayName(data, rival.PersonId)}    ·    你 {rival.Wins} 胜 {rival.Draws} 平 {rival.Losses} 负    ↗", 44));
    }
    private void CompetitionRules()
    {
        foreach (var (title, description) in new[]
        {
            ("社区与城市", "赢下街区杯，进入城市公开赛；再赢一场，就有机会参加青训选拔。双方都通关的平局也能取得资格。"),
            ("青训与职业合同", "青训选拔从进阶 6 开始。通过后，国内俱乐部会向你发来合同。"),
            ("国内职业联赛", "取得职业资格、签约俱乐部后即可报名。联赛共三轮，排名前二可争取国际赛事席位。比赛日期见日程。"),
            ("洲际俱乐部冠军杯", "每国两家俱乐部各派一名代表，十六位选手争夺冠军。一路获胜即可晋级，决赛从进阶 9 开始。"),
            ("国家队世界杯", "每两个赛季举行一次，八个国家各派一人。取得当季联赛前二，并在生涯赛事中通关进阶 8，即可争取国家队席位。"),
            ("比赛胜负", "通关胜过未通关。都通关时比较速度，都未通关时比较楼层。成绩完全相同，赛前排名较高者晋级。"),
            ("世界纪录挑战", "赢得国际冠军，并在生涯赛事中通关进阶 9，即可受邀挑战进阶 10。"),
            ("个人挑战", "可以选择高于比赛要求的进阶。每提高一级，单场奖金和获胜或平局时的关注奖励增加 15%。赛事战报按比赛规定的进阶记录。"),
            ("跨越赛季", "已经取得的资格、合同和荣誉会保留到下赛季，国家队席位则重新选拔。")
        })
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card); box.AddChild(Text(title, 24, _gold)); box.AddChild(Text(description, 18, _ink));
        }
    }
}

