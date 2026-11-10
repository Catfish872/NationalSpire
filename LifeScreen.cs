using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _lifeSection = "消费商城";
    private int _lifeHistoryLimit = 8;
    private void Life(CareerData d)
    {
        if (_lifeSection == "活动与计划") { _tab = "日程"; _calendarMode = "计划"; Calendar(d); return; }
        if (_lifeSection == "收支记录") { AssetsPage(d); return; }
        if (_lifeSection == "人气榜") { FanChart(d); return; }
        if (_lifeSection == "公开消息") { LifeNews(d); return; }
        bool nation = _lifeSection is "国运榜" or "国家发展" or "世界荣誉";
        if (nation)
        {
            var options = new HFlowContainer(); SecondaryTabInset(_content).AddChild(options);
            foreach (var name in new[] { "国运榜","国家发展","世界荣誉" })
                options.AddChild(FilterButton(name, _lifeSection == name, () => OpenLifePage(name), 140));
        }
        else if (_lifeSection != "交易市场")
        {
            var tabs = TabStrip(_content,30,secondary:true);
            tabs.AddChild(UnderlineTab("消费商城", () => OpenLifePage("消费商城"), _lifeSection == "消费商城"));
            tabs.AddChild(UnderlineTab("遗物手办", () => OpenLifePage("我的空间"), _lifeSection == "我的空间"));
        }
        if (_lifeSection != "消费商城") AddLifeRepairNotices(d, _content);
        switch (_lifeSection)
        {
            case "国运榜": NationRanking(d); break;
            case "国家发展": DevelopmentScreen(d); break;
            case "世界荣誉": WorldHonors(d); break;
            case "交易市场": MarketScreen(d); break;
            case "我的空间": LifeCollection(d); break;
            default: ConsumerShop(d); break;
        }
    }
    private static void AddLifeRepairNotices(CareerData data, VBoxContainer target)
    {
        foreach (string note in data.Life.RepairNotices.TakeLast(4)) target.AddChild(Text(note, 16, CareerVisuals.Teal));
    }
    private void ConfirmLife(string title, string question, Action action) => ShowCareerDialog(title, question, () => { action(); return true; });
    private void LifeCollection(CareerData d)
    {
        CareerRelics.Shop(d);
        _content.AddChild(Text($"遗物手办 · 已收藏 {d.Life.Figurines.Count} / {CareerRelics.Catalog.Length}", 25, _gold));
        _content.AddChild(Text("摆在这里，陪伴你的职业生涯。效果仅用于赛场之外，不会把遗物带入对局。", 17, _ink));
        _content.AddChild(Text("同款收藏长期生效。货架每14天更新，国运排名越高，可选藏品越多。", 15, _muted));
        _content.AddChild(Text($"本期手办 · {d.Esports.Country}国运第{CircuitLedger.NationTable(d).FindIndex(n => n.Country == d.Esports.Country) + 1}名 · {GameCalendar.Text(d, d.Life.RestockDay)}上新", 23, _gold));
        var store = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        store.AddThemeConstantOverride("h_separation", 16); store.AddThemeConstantOverride("v_separation", 16); _content.AddChild(store);
        foreach (var item in CareerRelics.Offers(d)) FigurineCard(d, store, item, false);
        if (d.Life.Shop.Count == 0) _content.AddChild(Text("本期没有新藏品上架。现有收藏继续生效。", 18, _muted));
        _content.AddChild(Text("已拥有的收藏", 23, _gold));
        var owned = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        owned.AddThemeConstantOverride("h_separation", 16); owned.AddThemeConstantOverride("v_separation", 16); _content.AddChild(owned);
        foreach (var item in CareerRelics.Catalog.Where(r => d.Life.Figurines.ContainsKey(r.Id))) FigurineCard(d, owned, item, true);
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
        if (!owned && price < item.Price) box.AddChild(Text($"原价 {CareerMoney.Format(item.Price)} · 送货员七折", 14, _muted));
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
            input = new LineEdit { Name = "CareerRenameInput", Text = CareerEngine.Name(data), CustomMinimumSize = new Vector2(500, 48) }; box.AddChild(input);
            status = Text("旧内容保留原名。", 16, _muted); box.AddChild(status);
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
            box.AddChild(Text(e.Title, 21, _gold)); box.AddChild(Text($"{GameCalendar.Text(d, e.Day)} · {e.Topic}", 15, _muted)); box.AddChild(Text(e.Detail, 17, _ink));
            var post = CommunityThreads.All(d).FirstOrDefault(p => p.Id == e.PostId && p.NewsGeneration.State == "completed");
            if (post != null) box.AddChild(Button("查看相关讨论", () => OpenPost(post), 190));
        }
        if (events.Count == 0) _content.AddChild(Text("公开活动和项目成果会在这里公布。", 17, _muted));
        if (events.Count > _lifeHistoryLimit) _content.AddChild(Button("查看更早消息", () => { _lifeHistoryLimit += 12; Render(); }, 200));
    }
}
