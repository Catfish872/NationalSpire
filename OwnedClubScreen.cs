using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private ClubDraft? _clubDraft;
    private int _clubStep, _marketPage;
    private bool _clubContractsExpanded;
    private string _marketTier = "全部", _ownerSection = "阵容";
    private readonly Dictionary<string, ClubSigning> _signChoices = [];
    private bool CanManageClub => _multiplayer?.Host != false;
    private VBoxContainer ClubCard(string title, string? subtitle = null, bool accent = false)
    {
        var card = Card(); _content.AddChild(card);
        if (accent) { card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193340", "8da98f", 8, 24)); if (card is BroadcastPanel b) b.Accent = _gold; }
        var box = Inner(card); box.AddThemeConstantOverride("separation", 16);
        box.AddChild(Text(title, accent ? 29 : 23, accent ? _gold : _ink));
        if (!string.IsNullOrEmpty(subtitle)) box.AddChild(Text(subtitle, 17, _muted));
        return box;
    }
    private Button ClubButton(string label, Action action, int width = 180)
    {
        var button = Button(label, action, width);
        button.Disabled = !CanManageClub;
        if (!CanManageClub) button.TooltipText = "由房主管理俱乐部";
        return button;
    }
    private void RefreshClub()
    { int y = _scroll.ScrollVertical; Render(); _ = RestoreScrollAsync(y, _renderVersion); }
    private OptionButton ClubSelect(string[] labels, int index, Action<int> changed)
    {
        var select = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(180, 46), Disabled = !CanManageClub };
        foreach (string label in labels) select.AddItem(label);
        select.Select(Math.Clamp(index, 0, labels.Length - 1)); select.ItemSelected += n => changed((int)n); return select;
    }
    private void ClubAction(CareerData data, string kind, string text = "", string target = "", Action? success = null)
    {
        if (MultiplayerCommand("owned-" + kind, target, text, accepted: success)) return;
        var error = OwnedClubs.Command(data, kind, target, text);
        if (error == null) success?.Invoke(); Render(); Notice(error ?? "已完成", error != null);
    }
    private void ClubInvitation(CareerData d)
    {
        if (OwnedClubs.IsOwner(d) || !OwnedClubs.CanJoinThisSeason(d) || d.Credits < OwnedClubs.FoundingCost) return;
        var box = ClubCard("现在可以组建自己的俱乐部", OwnedClubs.EntryText(d), true);
        box.AddChild(Text("选择首发与轮换，签下俱乐部赞助，以自己的名字参加联赛。", 19, _ink));
        box.AddChild(ClubButton("筹备新俱乐部  →", BeginClubDraft, 260));
    }
    private void BeginClubDraft()
    {
        _clubDraft ??= new(); _clubStep = 0; _marketPage = 0;
        if (_tab == "赛事与俱乐部" && _worldSection == "俱乐部" && _competitionId == null)
        { _scroll.ScrollVertical = 0; Render(); }
        else OpenWorldSection("俱乐部");
    }
    private void ClubEntry(CareerData d)
    {
        var box = ClubCard("组建自己的俱乐部", OwnedClubs.EntryText(d), true);
        box.AddChild(Text($"筹备费 {CareerMoney.Format(OwnedClubs.FoundingCost)}，选手签约费另计。最后确认才扣款。", 19, _ink));
        bool time = OwnedClubs.CanJoinThisSeason(d), money = d.Credits >= OwnedClubs.FoundingCost;
        var create = ClubButton("开始筹备  →", BeginClubDraft, 230); create.Disabled |= !time || !money || d.PendingMatchId != null; box.AddChild(create);
        if (!time) box.AddChild(Text("本季已开赛，下赛季联赛开始前开放。", 17, _muted));
        else if (!money) box.AddChild(Text("筹备资金还差 " + CareerMoney.Format(OwnedClubs.FoundingCost - d.Credits), 17, _muted));
    }
    private void ClubWizard(CareerData d)
    {
        AddHeading("组建俱乐部", "俱乐部资料  /  招募阵容  /  合同确认");
        if (!OwnedClubs.CanJoinThisSeason(d)) { _clubDraft = null; ClubEntry(d); return; }
        var draft = _clubDraft!;
        if (draft.Region.Length == 0) draft.Region = d.Esports.Country;
        var steps = new HFlowContainer(); _content.AddChild(steps);
        foreach (var (label, step) in new[] { ("1  俱乐部资料", 0), ("2  招募阵容", 1), ("3  确认合同", 2) })
            steps.AddChild(Button((_clubStep == step ? "●  " : "") + label, () => { _clubStep = step; Render(); }, 235));
        if (_clubStep == 0)
        {
            var box = ClubCard("从这里开始", "全体真人自动加入新俱乐部并固定首发，确认前仍属于原俱乐部。", true);
            var name = new LineEdit { Text = draft.Name, PlaceholderText = "输入俱乐部名称", MaxLength = 20, CustomMinimumSize = new(0, 52), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            name.TextChanged += value => draft.Name = value; box.AddChild(name);
            box.AddChild(Text("参赛地区", 18, _ink));
            var region = ClubSelect(EsportsWorld.Countries, Array.IndexOf(EsportsWorld.Countries, draft.Region), i => draft.Region = EsportsWorld.Countries[i]);
            region.Name = "ClubDraftRegion"; box.AddChild(region);
            box.AddChild(Text("俱乐部代表色", 18, _ink));
            var colors = new HFlowContainer(); box.AddChild(colors);
            string[] names = ["青绿", "鎏金", "紫晶", "玫红", "冰蓝"];
            for (int i = 0; i < names.Length; i++)
            {
                string color = OwnedClubs.Colors[i];
                var choice = Button((draft.Color == color ? "✓ " : "") + names[i], () => { draft.Color = color; Render(); }, 125);
                choice.Modulate = new Color(color); colors.AddChild(choice);
            }
            box.AddChild(Text($"首发固定 {Math.Max(3, OwnedClubs.ActiveHumans(d).Count)} 人，轮换至少 3 人。需签约 {OwnedClubs.RequiredAiStarters(d)} 名 AI 首发，青训自选。", 18, _ink));
            box.AddChild(Button("选择选手  →", () => { _clubStep = 1; Render(); }, 220));
        }
        else if (_clubStep == 1)
        {
            var summary = ClubCard($"首发 {OwnedClubs.ActiveHumans(d).Count + draft.Signings.Count(s => s.Position == "首发")} 人  ·  轮换 {OwnedClubs.Humans(d).Except(OwnedClubs.ActiveHumans(d)).Count() + draft.Signings.Count(s => s.Position == "轮换")} 人  ·  青训 {draft.Signings.Count(s => s.Position == "青训")} 人",
                $"预计初付 {CareerMoney.Format(OwnedClubs.InitialCost(d, draft))}  /  周薪 {CareerMoney.Format(OwnedClubs.WeeklyWages(d, draft))}", true);
            summary.AddChild(Button("查看合同结算  →", () => { _clubStep = 2; Render(); }, 240));
            foreach (var s in draft.Signings.ToList())
            {
                summary.AddChild(Button($"已选  {CareerEngine.DisplayName(d, s.PersonId)} · {s.Position} · {OwnedClubs.PlanName(s.Plan)}    移除", () => { draft.Signings.Remove(s); RefreshClub(); }, 0));
                var p = CareerEngine.Person(d, s.PersonId)!;
                string[] positions = ["首发", "轮换", "青训", "教练"];
                summary.AddChild(ClubSelect(positions, Array.IndexOf(positions, s.Position), i => { s.Position = positions[i]; RefreshClub(); }));
            }
            ClubMarket(d, true);
        }
        else ClubReview(d, draft);
        _content.AddChild(Button("退出筹备", () => ShowCareerDialog("退出筹备", "放弃当前草案？尚未扣款，原俱乐部和合同均不变。", () => { _clubDraft = null; Render(); return true; }), 180));
    }
    private void ClubMarket(CareerData d, bool draftMode)
    {
        var filters = new HFlowContainer(); _content.AddChild(filters);
        foreach (string tier in new[] { "全部", "明星选手", "职业主力", "潜力轮换", "青训新秀" })
            filters.AddChild(Button((_marketTier == tier ? "● " : "") + tier, () => { _marketTier = tier; _marketPage = 0; Render(); }, 165));
        var candidates = OwnedClubs.Candidates(d).Where(p => (_marketTier == "全部" || OwnedClubs.Tier(p) == _marketTier)
            && (!draftMode || !_clubDraft!.Signings.Any(s => s.PersonId == p.Id))).ToList();
        _marketPage = Math.Clamp(_marketPage, 0, Math.Max(0, (candidates.Count - 1) / 5));
        _content.AddChild(Text($"自由市场 · {candidates.Count} 人 · 第 {_marketPage + 1} 页", 17, _muted));
        _content.AddChild(Text("轮换、青训分别提供陪练加成；各组前三人全额计算，第4人约30%、第5人约16%，之后继续递减。", 17, _muted));
        foreach (var p in candidates.Skip(_marketPage * 5).Take(5))
        {
            if (!_signChoices.TryGetValue(p.Id, out var selection)) _signChoices[p.Id] = selection = new() { PersonId = p.Id, Position = p.MaxAscension >= 9 ? "首发" : "轮换" };
            var box = ClubCard(OwnedClubs.Tier(p) + "  /  " + p.PublicName);
            box.AddChild(PersonLink(d, p.Id, $"进阶 {p.MaxAscension}  ·  {p.Character}  ·  历史 {p.Wins} 胜 {p.Losses} 负   查看档案 ↗", 52));
            box.AddChild(Text($"A8 预计通关率 {MatchRules.ClearChance(d, p, 8) * 100:0.#}% · {p.Style}", 18, CareerVisuals.Teal));
            box.AddChild(Text("可签为首发、轮换、青训或教练。", 16, _muted));
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); box.AddChild(row);
            string[] plans = ["steady", "performance", "growth"];
            if (!plans.Contains(selection.Plan)) selection.Plan = plans[0];
            row.AddChild(ClubSelect(plans.Select(OwnedClubs.PlanName).ToArray(), Array.IndexOf(plans, selection.Plan), i => { selection.Plan = plans[i]; RefreshClub(); }));
            string[] roles = ["首发", "轮换", "青训", "教练"];
            row.AddChild(ClubSelect(roles, Array.IndexOf(roles, selection.Position), i => { selection.Position = roles[i]; RefreshClub(); }));
            if (!draftMode && selection.Position == "首发")
            {
                var replacements = OwnedClubs.ReplaceableStarters(d);
                if (replacements.Count > 0)
                {
                    if (!replacements.Contains(selection.ReplaceId)) selection.ReplaceId = replacements[0];
                    box.AddChild(ClubSelect(replacements.Select(id => "转为轮换 · " + CareerEngine.DisplayName(d, id)).ToArray(), replacements.IndexOf(selection.ReplaceId), i => selection.ReplaceId = replacements[i]));
                }
                else { selection.ReplaceId = ""; box.AddChild(Text(OwnedClubs.StarterReplacementError(d, "")!, 16, _muted)); }
            }
            ClubPracticePreview(d, box, selection, draftMode);
            var q = OwnedClubs.Quote(p, selection.Plan);
            box.AddChild(Text($"签约费 {CareerMoney.Format(q.Signing)}    周薪 {CareerMoney.Format(q.Wage)}    每次获胜奖金 {CareerMoney.Format(q.WinBonus)}    合约 {q.Days / 7} 周", 18, _gold));
            box.AddChild(Text(selection.Plan == "growth" && selection.Position != "教练" ? "每周积累长期成长，随已有提升逐渐减慢。" : "到期自动续约，免重复签约费。", 16, _muted));
            var add = ClubButton(draftMode ? "加入签约草案" : selection.Position == "教练" ? "签约这位教练" : "签约这位选手", () =>
            {
                var signing = new ClubSigning { PersonId = p.Id, Plan = selection.Plan, Position = selection.Position, ReplaceId = selection.ReplaceId };
                if (draftMode) { _clubDraft!.Signings.Add(signing); RefreshClub(); }
                else ShowCareerDialog("确认签约", $"{p.PublicName} · {signing.Position}\n初付 {CareerMoney.Format(q.Signing)}，周薪 {CareerMoney.Format(q.Wage)}，获胜奖金 {CareerMoney.Format(q.WinBonus)}。合约到期自动续约。", () => { ClubAction(d, "recruit", JsonSerializer.Serialize(signing)); return true; });
            }, 220);
            bool full = selection.Position == "首发" && (draftMode ? _clubDraft!.Signings.Count(s => s.Position == "首发") >= OwnedClubs.RequiredAiStarters(d) : selection.ReplaceId.Length == 0);
            add.Disabled |= full; box.AddChild(add);
            if (full && draftMode) box.AddChild(Text("首发席位已满，请调整签约草案。", 16, _muted));
        }
        var pages = new HFlowContainer(); _content.AddChild(pages);
        if (_marketPage > 0) pages.AddChild(Button("上一页", () => { _marketPage--; Render(); }, 150));
        if ((_marketPage + 1) * 5 < candidates.Count) pages.AddChild(Button("下一页", () => { _marketPage++; Render(); }, 150));
    }
    private void ClubPracticePreview(CareerData d, VBoxContainer box, ClubSigning signing, bool draftMode)
    {
        if (signing.Position == "首发") return;
        double factor = draftMode ? _clubDraft!.Signings.Where(s => s.Position == "教练").Select(s => ClubCoaching.Factor(CareerEngine.Person(d, s.PersonId)!)).DefaultIfEmpty(1).Max() : ClubCoaching.Factor(d);
        if (signing.Position == "教练")
        {
            double afterFactor = Math.Max(factor, ClubCoaching.Factor(CareerEngine.Person(d, signing.PersonId)!));
            box.AddChild(Text($"陪练系数 ×{afterFactor:0.#} · 多名教练取最高值", 17, CareerVisuals.Teal)); return;
        }
        List<string> Group(string role) => draftMode ? _clubDraft!.Signings.Where(s => s.Position == role).Select(s => s.PersonId).ToList()
            : OwnedClubs.PositionList(d.Esports.OwnedClub!, role).ToList();
        var reserves = Group("轮换"); var youth = Group("青训");
        double before = (OwnedClubs.GroupPractice(d, reserves, 8) + OwnedClubs.GroupPractice(d, youth, 8)) * factor;
        var group = signing.Position == "轮换" ? reserves : youth;
        if (!group.Contains(signing.PersonId)) group.Add(signing.PersonId);
        double after = (OwnedClubs.GroupPractice(d, reserves, 8) + OwnedClubs.GroupPractice(d, youth, 8)) * factor;
        box.AddChild(Text($"首发 A8 通关率加成 +{after * 100:0.00}% · 签约增量 {(after - before) * 100:+0.00;-0.00;0.00}%", 17, CareerVisuals.Teal));
        if (group.Count > 3) box.AddChild(Text($"{signing.Position}已有 {group.Count} 人，第4人起陪练收益大幅递减。", 16, _muted));
    }
    private void ClubWeeklyFinance(VBoxContainer box, OwnedSponsor? sponsor, int fans, decimal wages, int achievement = 0)
    {
        int sponsorship = OwnedClubs.SponsorWeekly(sponsor, fans) + achievement;
        int audience = OwnedClubs.AudienceIncome(fans), income = sponsorship + audience;
        decimal cost = wages + OwnedClubs.WeeklyOverhead, net = income - cost;
        var row = new HBoxContainer { Name = "ClubWeeklyFinance", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        row.AddThemeConstantOverride("separation", 14); box.AddChild(row);
        void Metric(string title, string amount, string detail, Color color, bool accent = false)
        {
            var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 };
            panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(accent ? "203c43" : "132733", accent ? "527d7b" : "304b5a", 8, 18));
            row.AddChild(panel);
            var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; column.AddThemeConstantOverride("separation", 10); panel.AddChild(column);
            column.AddChild(Text(title, 18, _muted)); column.AddChild(Text(amount, 28, color)); column.AddChild(Text(detail, 15, _muted));
        }
        Metric("俱乐部周收入", CareerMoney.Format(income), $"赞助 {CareerMoney.Format(sponsorship)}\n会员与周边 {CareerMoney.Format(audience)}", _ink);
        Metric("俱乐部周支出", CareerMoney.Format(cost), $"工资 {CareerMoney.Format(wages)}\n运营 {CareerMoney.Format(OwnedClubs.WeeklyOverhead)}", _ink);
        Metric("预计周结余", (net >= 0 ? "+" : "−") + CareerMoney.Format(Math.Abs(net)), "不含比赛奖金\n及个人收支", net >= 0 ? CareerVisuals.Teal : new Color("ee929d"), true);
        if (net < 0)
        {
            var target = OwnedClubs.BreakEvenFans(sponsor, cost - achievement);
            box.AddChild(Text(target is { } number ? $"预计达到 {number:N0} 关注可收支平衡。" : "当前阵容需要比赛奖金补足支出。", 16, _muted));
        }
    }
    private void ClubProfileActions(CareerData d, CareerPerson p, VBoxContainer box)
    {
        if (!OwnedClubs.IsOwner(d) || OwnedClubs.Humans(d).Contains(p.Id)) return;
        var o = d.Esports.OwnedClub!;
        if (o.Contracts.FirstOrDefault(c => c.PersonId == p.Id) is { } contract)
        {
            string replacement = "";
            bool needsReplacement = o.Starters.Contains(p.Id) && o.Starters.Count <= Math.Max(3, OwnedClubs.ActiveHumans(d).Count);
            if (needsReplacement && o.Reserves.Count > 3)
            {
                replacement = o.Reserves[0];
                box.AddChild(ClubSelect(o.Reserves.Select(id => "接替首发 · " + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => replacement = o.Reserves[i]));
            }
            var release = ClubButton("解除合同", () => ShowCareerDialog("解除合同", $"{p.PublicName} · 补偿 {CareerMoney.Format(OwnedClubs.ExitFee(d, contract))}", () => { ClubAction(d, "release", replacement, p.Id); return true; }), 180);
            release.Disabled |= needsReplacement && o.Reserves.Count <= 3 || o.Reserves.Contains(p.Id) && o.Reserves.Count <= 3;
            box.AddChild(release);
            if (release.Disabled && CanManageClub) box.AddChild(Text("解约后需保留 3 名首发、3 名轮换，请先补充阵容。", 16, _muted));
            return;
        }
        if (o.Transfers.FirstOrDefault(t => !t.Arrived && t.Contract.PersonId == p.Id) is { } incoming)
        { box.AddChild(Text($"已签约，第 {incoming.ArrivalSeason} 赛季加盟 · {incoming.Position}", 18, _gold)); return; }
        if (!OwnedClubs.IsRecruitable(p) || p.ClubId == d.Esports.ClubId) return;
        bool transfer = p.ClubId.Length > 0;
        if (!_signChoices.TryGetValue(p.Id, out var selection)) _signChoices[p.Id] = selection = new() { PersonId = p.Id, Position = p.MaxAscension >= 9 ? "首发" : "轮换" };
        box.AddChild(Text(transfer ? "洽谈下赛季转会" : "签约加入俱乐部", 22, _gold));
        string[] plans = ["steady", "performance", "growth"];
        if (!plans.Contains(selection.Plan)) selection.Plan = plans[0];
        string[] positions = ["首发", "轮换", "青训", "教练"];
        box.AddChild(ClubSelect(plans.Select(OwnedClubs.PlanName).ToArray(), Array.IndexOf(plans, selection.Plan), i => { selection.Plan = plans[i]; RefreshClub(); }));
        box.AddChild(ClubSelect(positions, Array.IndexOf(positions, selection.Position), i => { selection.Position = positions[i]; RefreshClub(); }));
        if (selection.Position == "首发")
        {
            var replacements = OwnedClubs.ReplaceableStarters(d);
            if (replacements.Count > 0)
            {
                if (!replacements.Contains(selection.ReplaceId)) selection.ReplaceId = replacements[0];
                box.AddChild(ClubSelect(replacements.Select(id => (transfer ? "下赛季转为轮换 · " : "转为轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), replacements.IndexOf(selection.ReplaceId), i => { selection.ReplaceId = replacements[i]; RefreshClub(); }));
            }
            else selection.ReplaceId = "";
        }
        var quote = OwnedClubs.Quote(p, selection.Plan); int fee = transfer ? OwnedClubs.TransferFee(p) : 0;
        box.AddChild(Text((transfer ? $"转会 {CareerMoney.Format(fee)} · " : "") + $"签约 {CareerMoney.Format(quote.Signing)} · 周薪 {CareerMoney.Format(quote.Wage)}\n获胜奖金 {CareerMoney.Format(quote.WinBonus)} · 合约 {quote.Days / 7} 周", 18, _gold));
        box.AddChild(Text(transfer ? "现在支付转会与签约费，下赛季报到后开始发薪。本季仍在原队比赛。" : "确认后支付签约费，立即加入所选阵容。", 17, _muted));
        ClubPracticePreview(d, box, selection, false);
        string? error = transfer ? OwnedClubs.TransferError(d, selection) : OwnedClubs.RecruitError(d, selection);
        if (error != null) box.AddChild(Text(error, 16, _muted));
        var sign = ClubButton(transfer ? "签订转会合同" : selection.Position == "教练" ? "签约这位教练" : "签约这位选手", () => ShowCareerDialog(transfer ? "确认转会" : "确认签约", $"{p.PublicName} · {selection.Position} · " + (transfer ? $"第 {d.Season + 1} 赛季加盟" : "立即加盟") + $"\n初付 {CareerMoney.Format(fee + quote.Signing)}，到队后周薪 {CareerMoney.Format(quote.Wage)}。", () => { ClubAction(d, transfer ? "transfer" : "recruit", JsonSerializer.Serialize(selection)); return true; }), 240);
        sign.Disabled |= error != null; box.AddChild(sign);
    }
    private void ClubReview(CareerData d, ClubDraft draft)
    {
        var box = ClubCard(draft.Name.Length == 0 ? "尚未填写俱乐部名称" : draft.Name, $"确认后扣款并加入本季{draft.Region}俱乐部联赛", true);
        foreach (string role in new[] { "首发", "轮换", "青训", "教练" })
        {
            var names = draft.Signings.Where(s => s.Position == role).Select(s => CareerEngine.DisplayName(d, s.PersonId));
            if (role == "首发") names = OwnedClubs.ActiveHumans(d).Select(id => CareerEngine.DisplayName(d, id)).Concat(names);
            box.AddChild(Text(role + "  " + string.Join("、", names.DefaultIfEmpty("未选择")), 19, _ink));
        }
        box.AddChild(Text(d.CooperativeMembers > 1 || _multiplayer != null ? "比赛由全体真人出战。" : "首发固定 3 人，轮换可在成立后交换上场。", 17, _muted));
        box.AddChild(Button(_clubContractsExpanded ? "收起合同明细" : $"查看 {draft.Signings.Count} 份合同明细", () => { _clubContractsExpanded = !_clubContractsExpanded; Render(); }, 250));
        if (_clubContractsExpanded) foreach (var signing in draft.Signings)
        {
            var q = OwnedClubs.Quote(CareerEngine.Person(d, signing.PersonId)!, signing.Plan);
            box.AddChild(Text($"{CareerEngine.DisplayName(d, signing.PersonId)} · {signing.Position} · {OwnedClubs.PlanName(signing.Plan)} · {q.Days / 7} 周\n签约 {CareerMoney.Format(q.Signing)} · 周薪 {CareerMoney.Format(q.Wage)} · 获胜奖金 {CareerMoney.Format(q.WinBonus)}", 17, _ink));
        }
        box = ClubCard("俱乐部赞助");
        string[] sponsors = ["steady", "results", "fans"];
        string[] plans = ["稳定经营", "赢球奖励", "关注收益"];
        box.AddChild(ClubSelect(sponsors.Select((id, i) => OwnedClubs.SponsorQuote(d, id).Brand + " · " + plans[i]).ToArray(), Array.IndexOf(sponsors, draft.Sponsor), i => { draft.Sponsor = sponsors[i]; RefreshClub(); }));
        var sponsor = OwnedClubs.SponsorQuote(d, draft.Sponsor);
        box.AddChild(Text(RegionalOrganizations.SponsorDescription(sponsor.Brand), 16, _muted));
        box.AddChild(Text($"每次赢球获赞助奖金 {CareerMoney.Format(sponsor.WinBonus)}，选手奖金另付。", 17, _muted));
        int fans = OwnedClubs.StartingFans(d); decimal wages = OwnedClubs.WeeklyWages(d, draft), initial = OwnedClubs.InitialCost(d, draft);
        box = ClubCard("俱乐部收支", $"初始关注 {fans:N0}");
        ClubWeeklyFinance(box, sponsor, fans, wages);
        box = ClubCard("确认成立", accent: true);
        box.AddChild(Text("本次支付 " + CareerMoney.Format(initial), 28, _gold));
        box.AddChild(Text($"筹备费 {CareerMoney.Format(OwnedClubs.FoundingCost)} · 签约费 {CareerMoney.Format(initial - OwnedClubs.FoundingCost)}", 17, _muted));
        string? error = OwnedClubs.CreationError(d, draft);
        if (error != null) box.AddChild(Text(error, 18, new Color("ee929d")));
        if (OwnedClubs.HumanWages(d) > 0) box.AddChild(Text("队友周薪每人 $1,400，已计入工资；每次获胜另付 $1,000。", 17, _muted));
        var confirm = ClubButton("确认成立并签约", () => ShowCareerDialog("成立 " + draft.Name, $"退出原俱乐部，确认所有合同并加入本季联赛？\n本次扣款 {CareerMoney.Format(initial)}。", () =>
        { ClubAction(d, "create", JsonSerializer.Serialize(draft), success: () => { _clubDraft = null; _ownerSection = "阵容"; }); return true; }, "确认成立"), 270);
        confirm.Disabled |= error != null; box.AddChild(confirm);
    }
    private void OwnedClubPanel(CareerData d)
    {
        _content.AddChild(Button("← 返回赛事与俱乐部", () => OpenWorldSection("国运榜"), 230));
        var o = d.Esports.OwnedClub!;
        var box = ClubCard(EsportsWorld.ClubName(d, o.ClubId), $"第 {o.FoundedDay} 天成立  ·  关注 {o.Fans:N0}  ·  下次周结 第 {o.NextPayDay} 天", true);
        string currentRegion = EsportsWorld.Club(d, o.ClubId)!.Country;
        string selectedRegion = o.NextRegion.Length > 0 ? o.NextRegion : currentRegion;
        var regionRow = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        regionRow.AddThemeConstantOverride("separation", 14); box.AddChild(regionRow);
        regionRow.AddChild(Text("参赛地区", 18, _ink));
        var regionSelect = ClubSelect(EsportsWorld.Countries, Array.IndexOf(EsportsWorld.Countries, selectedRegion), i => selectedRegion = EsportsWorld.Countries[i]);
        regionSelect.Name = "ClubRegion"; regionRow.AddChild(regionSelect);
        regionRow.AddChild(ClubButton("保存地区", () => ClubAction(d, "region", target: selectedRegion), 150));
        box.AddChild(Text(o.NextRegion.Length > 0 ? $"本季：{currentRegion} · 第 {d.Season + 1} 赛季起：{o.NextRegion}"
            : OwnedClubs.CanJoinThisSeason(d) ? "更换后立即调整本季联赛。" : "更换地区从下赛季生效。", 16, _muted));
        decimal wages = o.Contracts.Sum(c => c.Wage) + OwnedClubs.HumanWages(d);
        ClubWeeklyFinance(box, o.Sponsor, o.Fans, wages, OwnedClubs.AchievementWeekly(d));
        if (OwnedClubs.AchievementWeekly(d) > 0) box.AddChild(Text("周收入已含有效的成绩赞助。", 16, _muted));
        if (_multiplayer != null) box.AddChild(Text("房主支付队友周薪 $1,400、每次获胜奖金 $1,000。", 17, _muted));
        if (o.Debt > 0 || o.HumanPayDue.Values.Any(value => value > 0))
        {
            box.AddChild(Text("待付 " + CareerMoney.Format(o.Debt + o.HumanPayDue.Values.Sum()) + (o.Debt > 0 ? " · 陪练和青训暂停" : ""), 19, new Color("ee929d")));
            box.AddChild(ClubButton("补发欠款", () => ShowCareerDialog("补发欠款", "从钱包支付当前可承担的欠款？", () => { ClubAction(d, "debt"); return true; }), 180));
        }
        var tabs = new HFlowContainer(); _content.AddChild(tabs);
        foreach (string section in new[] { "阵容", "招募", "赞助", "账目", "其他俱乐部" })
            tabs.AddChild(Button((_ownerSection == section ? "● " : "") + section, () => { _ownerSection = section; Render(); }, 150));
        if (_ownerSection == "其他俱乐部") { ClubDirectory(d); return; }
        if (_ownerSection == "招募") { ClubMarket(d, false); return; }
        if (_ownerSection == "赞助")
        {
            var sb = ClubCard("俱乐部赞助", "8 周一约。提前选择品牌，下期生效；不操作则原品牌续约。");
            if (o.Sponsor is { } active) sb.AddChild(Text($"{active.Brand}  ·  每周 {CareerMoney.Format(OwnedClubs.SponsorWeekly(active, o.Fans))}  ·  赢球 {CareerMoney.Format(active.WinBonus)}  ·  第 {active.EndDay} 天到期", 20, _gold));
            foreach (string id in new[] { "steady", "results", "fans" })
            {
                var s = OwnedClubs.SponsorQuote(d, id);
                sb.AddChild(Text(RegionalOrganizations.SponsorDescription(s.Brand), 16, _muted));
                sb.AddChild(ClubButton($"{s.Brand} · 周结 {CareerMoney.Format(OwnedClubs.SponsorWeekly(s, o.Fans))} · 赢球 {CareerMoney.Format(s.WinBonus)}", () => ShowCareerDialog("确认下期赞助", "选择 " + s.Brand + "？当前合同按期执行。", () => { ClubAction(d, "sponsor", target: id); return true; }), 0));
            }
            if (o.NextSponsor.Length > 0) sb.AddChild(Text("下期已选 " + OwnedClubs.SponsorQuote(d, o.NextSponsor).Brand, 18, CareerVisuals.Teal));
            sb.AddChild(Text("成绩赞助 · 持续 8 周，同类取最高档", 21, _gold));
            sb.AddChild(Text("连胜奖励每季每档一次。关注超过 1 万后，新增关注逐渐减少。", 16, _muted));
            sb.AddChild(Text("联赛三连胜 · 关注 +600 · 签约奖 $6,000 · 每周 +$3,000\n联赛五连胜 · 关注 +1,200 · 签约奖 $12,000 · 每周 +$6,000", 17, _ink));
            sb.AddChild(Text("联赛冠军 · 关注 +3,000 · 签约奖 $20,000 · 每周 +$10,000\n亚军 +2,000 / $14,000 / $7,000，季军 +1,200 / $8,000 / $4,000\n其余名次也有奖励，洲际赛按名次翻倍。", 17, _muted));
            foreach (var deal in o.AchievementSponsors.Where(s => s.EndDay > d.Day).OrderByDescending(s => s.Weekly))
                sb.AddChild(Text($"{deal.Title} · 每周 {CareerMoney.Format(deal.Weekly)} · 第 {deal.EndDay} 天到期", 17, CareerVisuals.Teal));
            ShowSponsors(d); return;
        }
        if (_ownerSection == "账目")
        {
            var lb = ClubCard("经营流水", "俱乐部收支计入钱包，以下单独列出经营记录。");
            foreach (var e in o.Ledger.TakeLast(32).Reverse()) lb.AddChild(Text($"第 {e.Day} 天  ·  {e.Title}  ·  {(e.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs(e.Amount))}", 18, e.Amount >= 0 ? CareerVisuals.Teal : _ink));
            return;
        }
        CoachManagement(d);
        _content.AddChild(Text("轮换与青训各组前三人全额陪练，第4人起大幅递减。青训每周成长并测评进阶。", 17, _muted));
        _content.AddChild(Text(_multiplayer != null ? "全体真人固定出战。" : "首发固定 3 人，可与轮换交换；调整从尚未开打的对阵生效。", 17, _muted));
        foreach (var t in o.Transfers.Where(t => !t.Arrived))
            _content.AddChild(PersonLink(d, t.Contract.PersonId, $"第 {t.ArrivalSeason} 赛季加盟 · {CareerEngine.DisplayName(d, t.Contract.PersonId)} · {t.Position}", 48));
        foreach (string role in new[] { "首发", "轮换", "青训", "教练" })
        {
            var rb = ClubCard(role + "  /  " + OwnedClubs.PositionList(o, role).Count + " 人");
            foreach (string id in OwnedClubs.PositionList(o, role))
            {
                bool human = OwnedClubs.Humans(d).Contains(id);
                rb.AddChild(PersonLink(d, id, CareerEngine.DisplayName(d, id) + (human ? " · " + role + (ClubCoaching.PlayerCoach(d) && id == "player" ? " · 兼任教练" : "") : role == "教练" ? $" · 陪练系数 ×{ClubCoaching.Factor(CareerEngine.Person(d, id)!):0.#}" : " · " + OwnedClubs.Tier(CareerEngine.Person(d, id)!)), 54));
                if (human)
                {
                    if (OwnedClubs.PaidHumans(d).Contains(id))
                        rb.AddChild(Text($"周薪 {CareerMoney.Format(OwnedClubs.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(OwnedClubs.HumanWinBonus)} · 待付 {CareerMoney.Format(o.HumanPayDue.GetValueOrDefault(id))}", 17, _muted));
                    continue;
                }
                var c = o.Contracts.Single(c => c.PersonId == id); var p = CareerEngine.Person(d, id)!;
                rb.AddChild(Text((role == "教练" ? "" : $"进阶 {p.MaxAscension} · A8 预计通关率 {MatchRules.ClearChance(d, p, 8) * 100:0.#}%\n") + $"{OwnedClubs.PlanName(c.Plan)} · 周薪 {CareerMoney.Format(c.Wage)} · 获胜 {CareerMoney.Format(c.WinBonus)} · 第 {c.EndDay} 天续约", 17, _muted));
                var partners = o.Contracts.Where(other => role != "教练" && other.Position != "教练" && other.PersonId != id && OwnedClubs.Position(o, other.PersonId) != role).Select(other => other.PersonId).ToList();
                var actions = new HFlowContainer(); rb.AddChild(actions);
                if (partners.Count > 0)
                {
                    string other = partners[0];
                    actions.AddChild(ClubSelect(partners.Select(i => "交换 · " + CareerEngine.DisplayName(d, i) + "（" + OwnedClubs.Position(o, i) + "）").ToArray(), 0, i => other = partners[i]));
                    actions.AddChild(ClubButton("确认交换", () => ShowCareerDialog("调整阵容", $"交换 {p.PublicName} 与 {CareerEngine.DisplayName(d, other)} 的位置？", () => { ClubAction(d, "swap", other, id); return true; }), 150));
                }
                if (role is "轮换" or "青训")
                {
                    string destination = role == "青训" ? "轮换" : "青训";
                    actions.AddChild(ClubButton("调入" + destination, () => ShowCareerDialog("调整阵容", $"将 {p.PublicName} 调入{destination}？", () => { ClubAction(d, "position", destination, id); return true; }), 150));
                }
                else if (role == "首发" && o.Reserves.Count > 3)
                {
                    string replacement = o.Reserves[0];
                    actions.AddChild(ClubSelect(o.Reserves.Select(i => "解约后首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = o.Reserves[i]));
                    actions.AddChild(ClubButton("解约并更换首发", () => ShowCareerDialog("解除首发合同", $"向 {p.PublicName} 支付 {CareerMoney.Format(OwnedClubs.ExitFee(d, c))}，由 {CareerEngine.DisplayName(d, replacement)} 接替首发。", () => { ClubAction(d, "release", replacement, id); return true; }), 220));
                }
                if (role != "教练") actions.AddChild(ClubButton("转任教练", () => CoachAppointmentDialog(d, id), 150));
                if (role != "首发") actions.AddChild(ClubButton("解除合同", () => ShowCareerDialog("解除合同", $"{p.PublicName} 的解约补偿为 {CareerMoney.Format(OwnedClubs.ExitFee(d, c))}。", () => { ClubAction(d, "release", target: id); return true; }), 150));
            }
            if (OwnedClubs.PositionList(o, role).Count == 0) rb.AddChild(Text("前往招募选择选手。", 17, _muted));
        }
    }
}
