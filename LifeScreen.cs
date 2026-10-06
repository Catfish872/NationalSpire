using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _lifeSection = "活动与计划";
    private int _lifeHistoryLimit = 8;
    private void Life(CareerData d)
    {
        AddHeading("赛场之外", "安排一点自己的生活，也看看这些选择后来怎样了。");
        foreach (string message in d.Life.RepairNotices.TakeLast(4)) _content.AddChild(Text(message, 16, CareerVisuals.Teal));
        _content.AddChild(Text($"可用资金 {CareerMoney.Format(CareerMoney.Balance(d))} · 已记录比赛奖金 {CareerMoney.Format(d.Life.PrizeTotal)}", 18, _gold));
        var tabs = new HBoxContainer(); _content.AddChild(tabs);
        foreach (string name in new[] { "活动与计划", "我的空间", "公开消息", "收支记录" })
            tabs.AddChild(FilterButton(name, _lifeSection == name, () => { _lifeSection = name; _lifeHistoryLimit = 8; Render(); }, 165));
        if (_lifeSection == "我的空间") { LifeCollection(d); return; }
        if (_lifeSection == "公开消息") { LifeNews(d); return; }
        if (_lifeSection == "收支记录")
        {
            foreach (var entry in d.Life.Ledger.AsEnumerable().Reverse().Take(40))
                _content.AddChild(Text($"第{entry.Day}天 · {entry.Title}\n{(entry.Amount >= 0 ? "+" : "−")}{CareerMoney.Format(Math.Abs((long)entry.Amount))} · 余额 {CareerMoney.Format(entry.Balance)}", 18, _ink));
            if (d.Life.Ledger.Count == 0) _content.AddChild(Text("新的收入和花销会记在这里。", 18, _muted));
            return;
        }
        var available = d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day).ToList();
        _content.AddChild(Text("这一轮，想做些什么？", 23, _gold));
        if (available.Count > 0)
        {
            _content.AddChild(Text($"从 {available.Count} 项安排中选择一项。其他邀请随本轮结束，之后还会有新的机会。", 17, _muted));
            _content.AddChild(Button("这轮先不安排", () => ConfirmLife("跳过这轮安排", "本轮所有邀请将结束，新的机会将在日程推进后出现。", () => { if (MultiplayerCommand("skip")) return; CareerLife.SkipRound(d); Render(); }), 210));
        }
        if (available.Count == 0) _content.AddChild(Text("暂时没有新的活动邀请。日程推进后，会陆续出现新的机会。", 17, _muted));
        foreach (var a in available) ActivityCard(d, a);
        var ongoing = d.Life.Activities.Where(a => a.Status == "进行中").OrderBy(a => a.FinishDay).ToList();
        if (ongoing.Count > 0) _content.AddChild(Text("正在进行", 23, _gold));
        foreach (var a in ongoing) ActivityCard(d, a);
        var completed = d.Life.Activities.Where(a => a.Status == "已完成").OrderByDescending(a => a.FinishDay).ToList();
        if (completed.Count > 0) _content.AddChild(Text("留下的经历", 23, _gold));
        foreach (var a in completed.Take(_lifeHistoryLimit)) ActivityCard(d, a);
        if (completed.Count > _lifeHistoryLimit) _content.AddChild(Button("查看更多经历", () => { _lifeHistoryLimit += 8; Render(); }, 200));
    }
    private void ActivityCard(CareerData d, LifeActivity a)
    {
        var card = Card(); _content.AddChild(card); var box = Inner(card);
        box.AddThemeConstantOverride("separation", 16);
        box.AddChild(Text(a.Title + " · " + a.Kind, 22, _gold));
        if (!CareerTraining.IsTraining(a) && !ClubPrograms.IsTraining(a))
        {
            string detail = a.Detail.Split('。')[0];
            if (detail.Length > 0) box.AddChild(Text(detail, 17, _ink));
        }
        if (a.Status == "可安排")
        {
            if (CareerTraining.IsTraining(a) && CareerTraining.Kind(a.Title) is not ("team" or "team-growth"))
            {
                var people = CareerTraining.Targets(d);
                var select = new OptionButton { CustomMinimumSize = new Vector2(280, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                foreach (var p in people) select.AddItem(p.PublicName + (CareerTraining.ActiveRoster(d, p.Id) ? " · 当前参赛" : " · 轮换"));
                select.Select(Math.Max(0, people.FindIndex(p => p.Id == a.PersonId)));
                select.ItemSelected += index => { a.PersonId = people[(int)index].Id; Render(); };
                box.AddChild(select);
            }
            int cost = CareerRelics.Cost(d, a), duration = CareerRelics.Duration(d, a);
            box.AddChild(Text($"费用 {CareerMoney.Format(cost)} · {duration} 天", 16, _muted));
            if (cost < a.Cost || duration < a.Duration) box.AddChild(Text($"原价 {CareerMoney.Format(a.Cost)} / {a.Duration} 天 · 已计入当前筹备与手办优惠", 14, CareerVisuals.Teal));
            var effects = Text(CareerLife.Expected(d, a), 19, CareerVisuals.Teal);
            if (CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a))
            {
                effects.TooltipText = ClubPrograms.IsTraining(a) ? ClubPrograms.Details(d, a) : CareerTraining.Details(d, a);
                effects.MouseFilter = MouseFilterEnum.Pass; effects.MouseDefaultCursorShape = CursorShape.Help;
            }
            box.AddChild(effects);
            var actions = new HBoxContainer(); box.AddChild(actions);
            var accept = Button("选择这项安排", () => ConfirmLife("确认安排", $"{a.Title}\n{CareerLife.Expected(d, a)}\n费用 {CareerMoney.Format(CareerRelics.Cost(d, a))}，本轮只选这一项。", () => { if (MultiplayerCommand("activity", a.Id)) return; var error = CareerLife.Accept(d, a.Id, CareerTraining.IsTraining(a) ? a.PersonId : ""); Render(); Notice(error ?? "安排已确认，可以在这里查看进展。", error != null); }), 180);
            accept.Disabled = d.Credits < cost || a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中"); actions.AddChild(accept);

        }
        else
        {
            box.AddChild(Text(a.Status == "进行中" ? $"第{a.StartedDay}天开始 · 预计第{a.FinishDay}天完成" : $"第{a.FinishDay}天完成 · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}", 16, _muted));
            box.AddChild(Text(a.Result, 18, CareerVisuals.Teal));
            if ((CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)) && a.Status == "进行中") box.AddChild(Text(CareerLife.Expected(d, a), 18, _muted));
        }
    }
    private void ConfirmLife(string title, string question, Action action) => ShowCareerDialog(title, question, () => { action(); return true; });
    private void LifeCollection(CareerData d)
    {
        CareerRelics.Shop(d);
        _content.AddChild(Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold));
        _content.AddChild(Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink));
        _content.AddChild(Text("同款只保留一件。限次手办用完后可在商店再次购入，恢复全部次数；活动优惠合计最多抵扣原价的 20%。", 15, _muted));
        var owned = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        owned.AddThemeConstantOverride("h_separation", 16); owned.AddThemeConstantOverride("v_separation", 16); _content.AddChild(owned);
        foreach (var item in CareerRelics.Catalog.Where(r => d.Life.Figurines.ContainsKey(r.Id))) FigurineCard(d, owned, item, true);
        _content.AddChild(Text($"本期手办 · 每期最多 4 款 · 第 {d.Life.RestockDay} 天上新", 23, _gold));
        var store = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        store.AddThemeConstantOverride("h_separation", 16); store.AddThemeConstantOverride("v_separation", 16); _content.AddChild(store);
        foreach (var item in CareerRelics.Offers(d)) FigurineCard(d, store, item, false);
        if (d.Life.Collection.Count > 0)
        {
            _content.AddChild(Text("生活纪念", 23, _gold));
            foreach (var item in d.Life.Collection.Values.TakeLast(_lifeHistoryLimit).Reverse()) _content.AddChild(Text("◆ " + item, 17, _ink));
            if (d.Life.Collection.Count > _lifeHistoryLimit) _content.AddChild(Button("查看更多收藏", () => { _lifeHistoryLimit += 12; Render(); }, 190));
        }
    }
    private void FigurineCard(CareerData d, GridContainer parent, CareerRelics.Item item, bool owned)
    {
        var card = Card(); parent.AddChild(card); var box = Inner(card);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);
        var texture = RelicArt.Read(item.Id);
        if (texture != null) row.AddChild(new TextureRect { Texture = texture, CustomMinimumSize = new Vector2(76, 76),
            ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore });
        else row.AddChild(Text("◆", 40, _gold));
        var title = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(title);
        title.AddChild(Text(item.Name + " · 手办", 22, _gold));
        int price = CareerRelics.PurchasePrice(d, item);
        title.AddChild(Text(owned ? CareerRelics.Status(d, item) : CareerMoney.Format(price), 16, CareerVisuals.Teal));
        if (!owned && price < item.Price) box.AddChild(Text($"原价 {CareerMoney.Format(item.Price)} · 送货员 85 折", 14, _muted));
        box.AddChild(Text(item.Effect, 17, _ink));
        if (!owned)
        {
            bool collected = d.Life.Figurines.ContainsKey(item.Id);
            bool canBuy = CareerRelics.CanBuy(d, item);
            bool refill = collected && canBuy;
            var purchase = Button(refill ? "重新购买 · 恢复次数" : collected ? "已经收藏" : "购买手办", () => ConfirmLife(refill ? "恢复手办次数" : "购买手办", refill ? $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 重新购买{item.Name}手办，将次数恢复为 {item.Uses} 次？" : $"花费 {CareerMoney.Format(CareerRelics.PurchasePrice(d, item))} 收藏{item.Name}手办？", () =>
            { if (MultiplayerCommand("relic", item.Id)) return; var error = CareerRelics.Buy(d, item.Id); Render(); Notice(error ?? (refill ? item.Name + $"手办已恢复 {item.Uses} 次。" : item.Name + "手办已摆上展示架。"), error != null); }), 170);
            purchase.Disabled = !canBuy || d.Credits < price; box.AddChild(purchase);
        }
    }
    private void RenamePlayer(CareerData data)
    {
        LineEdit input = null!; Label status = null!;
        ShowCareerDialog("修改游戏名", "只修改当前生涯的名字。旧帖子保留原文，点击旧名字仍可查看你的档案。", () =>
        {
            if (MultiplayerCommand("rename", text: input.Text)) return true;
            if (CareerNames.Rename(data, input.Text) is { } error) { status.Text = error; return false; }
            Render(); Notice("游戏名已更新。", false); return true;
        }, "确认改名", box =>
        {
            input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), MaxLength = 128, CustomMinimumSize = new Vector2(500, 48) }; box.AddChild(input);
            status = Text("最多 32 个字符。", 16, _muted); box.AddChild(status);
        });
        input?.GrabFocus();
    }
    private void LifeNews(CareerData d)
    {
        _content.AddChild(Text("活动公告与公开进展", 23, _gold));
        var events = d.Life.Events.OrderByDescending(e => e.Day).ThenByDescending(e => e.Important).ToList();
        foreach (var e in events.Take(_lifeHistoryLimit))
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text(e.Title, 21, _gold)); box.AddChild(Text($"第{e.Day}天 · {e.Topic}", 15, _muted)); box.AddChild(Text(e.Detail, 17, _ink));
            var post = CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed");
            if (post != null) box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190));
        }
        if (events.Count == 0) _content.AddChild(Text("公开活动和项目成果会在这里公布。", 17, _muted));
        if (events.Count > _lifeHistoryLimit) _content.AddChild(Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200));
    }
}
