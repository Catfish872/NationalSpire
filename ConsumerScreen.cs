using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private const int ShopRows = 3, ShopColumns = 2, MinProductHeight = 184, ProductGap = 14, ShopPagerHeight = 40;
    private const int ShopPageSize = ShopRows * ShopColumns;
    private string _shopTier = ConsumerCatalog.Mass;
    private string _shopCategory = "全部", _shopSelected = "";
    private bool _shopOwned;
    private int _shopPage;
    private void OpenShopShelf(string? tier)
    {
        void Select()
        {
            _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = tier == null;
            if (tier != null) _shopTier = tier;
            _shopPage = 0; _shopCategory = "全部"; _shopSelected = "";
        }
        if (_tab == "生涯生活" && _lifeSection == "消费商城") { Select(); Render(); }
        else Visit(Select);
    }

    private void ConsumerShop(CareerData d)
    {
        var purchases = new ConsumerPurchases(d);
        var available = (_shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)).ToArray();
        var groups = available.Select(g => g.Category).Distinct().ToArray();
        if (_shopCategory != "全部" && !groups.Contains(_shopCategory)) _shopCategory = "全部";
        _content.SizeFlagsVertical = SizeFlags.ExpandFill;
        var inset = Inset(0, 0);
        inset.SizeFlagsVertical = SizeFlags.ExpandFill;
        inset.AddThemeConstantOverride("margin_bottom", 4); _content.AddChild(inset);
        var shelf = new VBoxContainer(); shelf.AddThemeConstantOverride("separation", 12); inset.AddChild(shelf);

        HBoxContainer ShelfRow(Control filters, Control products, Control purchase)
        {
            var row = new HBoxContainer();
            row.AddThemeConstantOverride("separation", ProductGap); shelf.AddChild(row);
            filters.CustomMinimumSize = new(140, 0);
            products.SizeFlagsHorizontal = purchase.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            products.SizeFlagsStretchRatio = 2;
            row.AddChild(filters); row.AddChild(products); row.AddChild(purchase);
            return row;
        }
        static Control Spacer() => new() { MouseFilter = MouseFilterEnum.Ignore };
        var tiers = new HBoxContainer { Name = "ShopTiers" }; tiers.AddThemeConstantOverride("separation", 8);
        var collection = new HBoxContainer();
        collection.AddChild(FilterButton("我的收藏", _shopOwned, () => OpenShopShelf(null), 130));
        ShelfRow(Spacer(), tiers, collection);
        foreach (string tier in ConsumerCatalog.TierOrder)
        {
            var filter = FilterButton(tier, !_shopOwned && _shopTier == tier, () => OpenShopShelf(tier), 0);
            filter.SizeFlagsHorizontal = SizeFlags.ExpandFill; tiers.AddChild(filter);
        }
        var filterScroll = new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
        var filters = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        filters.AddThemeConstantOverride("separation", 12); filterScroll.AddChild(filters);
        foreach (string category in new[] { "全部" }.Concat(groups))
        {
            var button = FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 0);
            button.SizeFlagsHorizontal = SizeFlags.ExpandFill; filters.AddChild(button);
        }
        AddLifeRepairNotices(d, filters);
        var goods = available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray();
        _shopPage = Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / ShopPageSize));
        var pageGoods = goods.Skip(_shopPage * ShopPageSize).Take(ShopPageSize).ToArray();
        if (!pageGoods.Any(g => g.Id == _shopSelected)) _shopSelected = pageGoods.FirstOrDefault()?.Id ?? "";
        var grid = new GridContainer { Name = "ShopGrid", Columns = ShopColumns };
        grid.AddThemeConstantOverride("h_separation", ProductGap);
        grid.AddThemeConstantOverride("v_separation", ProductGap);
        var detail = Card(); detail.Name = "ShopPurchase";
        ShelfRow(filterScroll, grid, detail).SizeFlagsVertical = SizeFlags.ExpandFill;
        var body = Inner(detail);
        body.AddThemeConstantOverride("separation", 8);
        var cards = new List<(Button Button, Good Good)>();
        void Select(Good good)
        {
            _shopSelected = good.Id;
            foreach (var item in cards) ConsumerVisuals.ProductStyle(item.Button, purchases.ThisSeason(item.Good) || item.Good.Promo, item.Good.Id == _shopSelected);
            foreach (var child in body.GetChildren()) { body.RemoveChild(child); child.QueueFree(); }
            ConsumerDetail(d, good, purchases, body);
        }
        foreach (var good in pageGoods)
        {
            var card = new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, MinProductHeight) };
            grid.AddChild(card); cards.Add((card, good)); card.Pressed += () => Select(good);
            var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }; card.AddChild(margin);
            margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            margin.AddThemeConstantOverride("margin_left", 16);
            margin.AddThemeConstantOverride("margin_right", 16);
            margin.AddThemeConstantOverride("margin_top", 12);
            margin.AddThemeConstantOverride("margin_bottom", 16);
            var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 3); margin.AddChild(box);
            string label = purchases.Label(good);
            bool current = purchases.ThisSeason(good) || good.Promo;
            ConsumerVisuals.ProductStyle(card, current, good.Id == _shopSelected);
            var artwork = new Control { CustomMinimumSize = new(0, 42), SizeFlagsVertical = SizeFlags.ExpandFill }; box.AddChild(artwork);
            var art = new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name }; artwork.AddChild(art); art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            if (label.Length > 0)
            {
                var badge = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }; artwork.AddChild(badge);
                badge.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight); badge.GrowHorizontal = GrowDirection.Begin;
                badge.AddThemeStyleboxOverride("panel", ConsumerVisuals.Style(current, true));
                var row = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; badge.AddChild(row);
                row.AddChild(new ConsumerSeal { Current = current, Ticket = good.Repeatable, Promo = good.Promo, Count = purchases.Promotions(good) });
                var caption = Text(label, 14, ConsumerVisuals.Accent(current));
                caption.AutowrapMode = TextServer.AutowrapMode.Off;
                row.AddChild(caption);
            }
            box.AddChild(Text(good.Category, 14, _muted));
            box.AddChild(Text(good.Name, 20, _ink));
            box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(good):N0}", 23, CareerVisuals.Teal));
            void IgnoreMouse(Node node)
            {
                if (node is Control control) control.MouseFilter = MouseFilterEnum.Ignore;
                foreach (var child in node.GetChildren()) IgnoreMouse(child);
            }
            IgnoreMouse(margin);
        }
        // Keep all three rows the same height, including pages with only one product.
        for (int slot = pageGoods.Length; slot < ShopPageSize; slot++)
            grid.AddChild(new Control { CustomMinimumSize = new(0, MinProductHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill,
                SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });
        var pages = new HBoxContainer { Name = "ShopPagination", CustomMinimumSize = new(0, ShopPagerHeight) };
        ShelfRow(Spacer(), pages, Spacer());
        if (_shopPage > 0) pages.AddChild(FramedAction("← 上一页", () => { _shopPage--; Render(); }, width: 140, height: ShopPagerHeight));
        pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + ShopPageSize - 1) / ShopPageSize)}", 16, _muted));
        if ((_shopPage + 1) * ShopPageSize < goods.Length) pages.AddChild(FramedAction("下一页 →", () => { _shopPage++; Render(); }, width: 140, height: ShopPagerHeight));
        if (ConsumerCatalog.Get(_shopSelected) is { } selected) ConsumerDetail(d, selected, purchases, body);
        else body.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted));
    }

    private void ConsumerDetail(CareerData d, Good selected, ConsumerPurchases purchases, VBoxContainer body)
    {
        body.AddChild(new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name,
            CustomMinimumSize = new(0, 160), SizeFlagsHorizontal = SizeFlags.ExpandFill });
        var info = new HBoxContainer(); info.AddThemeConstantOverride("separation", 18); body.AddChild(info);
        var product = new VBoxContainer { Name = "ShopProductSummary", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        product.AddThemeConstantOverride("separation", 5); info.AddChild(product);
        product.AddChild(Text(selected.Name, 28, _gold));
        product.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted));
        body.AddChild(Text($"${ConsumerEngine.Price(selected):N0}", 32, CareerVisuals.Teal));
        if (selected.Durable)
        {
            var activities = new VBoxContainer { Name = "ShopCollectionActivities", SizeFlagsHorizontal = SizeFlags.ExpandFill };
            activities.AddThemeConstantOverride("separation", 4); info.AddChild(activities);
            activities.AddChild(Text("收藏后可举办", 15, _muted));
            foreach (var verb in selected.Verbs) activities.AddChild(Text(verb.Name, 17, _ink));
        }
        if (selected.Promo)
        {
            body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}", 18, _ink));
            body.AddChild(Text($"每赛季限{ConsumerCatalog.PromoPerSeason}次 · 本季剩余{ConsumerEngine.RemainingPurchases(d, selected)}次", 16, _muted));
        }
        if (!selected.Collectible) body.AddChild(Text("即时消费", 16, _muted));
        if (selected.Instant && ConsumerAttachments.Available(d, selected) > 0)
            body.AddChild(Text($"当天临时保留 ×{ConsumerAttachments.Available(d, selected)} · {GameCalendar.Text(d, d.Day)}有效", 16, CareerVisuals.Teal));

        if (_shopOwned) body.AddChild(new Control { SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 10);
        if (selected.Giftable) actions.AddChild(Button("赠送礼物", () => ConsumerTarget(selected, false), 0));
        if (selected.Activities.Any()) actions.AddChild(Button("邀约活动", () => ConsumerTarget(selected, true), 0));
        if (actions.GetChildCount() > 0)
        {
            foreach (var button in actions.GetChildren().OfType<Button>()) button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            body.AddChild(actions);
        }
        else actions.Free();
        if (_shopOwned)
        {
            body.AddChild(Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted));
            if (selected.Durable) body.AddChild(Text("使用聊天输入栏的＋添加活动附件，约定日期和同行者。", 16, _muted));
            return;
        }

        body.AddChild(Hairline("3a5360"));
        var quantity = new ConsumerQuantity { Minimum = 1, Maximum = Math.Max(1, ConsumerEngine.RemainingPurchases(d, selected)) };
        quantity.Initialize(1); body.AddChild(quantity);
        string? error = ConsumerEngine.BuyError(d, selected);
        var purchase = Button(error ?? "确认购买", () => ConsumerConfirmPurchase(d, selected, quantity.Value), 0);
        purchase.Disabled = error != null; body.AddChild(purchase);
        quantity.Changed += () =>
        {
            string? message = quantity.Valid ? ConsumerEngine.BuyError(d, selected, quantity.Value) : "请输入有效的购买数量。";
            purchase.Text = message ?? $"购买 · ${ConsumerEngine.Price(selected) * (decimal)quantity.Value:N0}";
            purchase.Disabled = message != null;
        };
    }
    private void ConsumerSubmit(CareerData d, Good good, string verb, List<string> guests, int quantity = 1)
    {
        string kind = verb.Length == 0 ? "consumer-buy" : "consumer-use";
        if (MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity)))) return;
        var error = EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests));
        Render(); if (error != null) Notice(error, true);
    }
    private void FanChart(CareerData d)
    {
        var current = GroupChats.Human(d);
        var rows = d.People.Where(p => !d.HumanIds.Contains(p.Id) || p.Id != current).Select(p => (Id: p.Id, Fans: CareerAudience.Followers(p)))
            .Append((Id: "player", Fans: d.Fans)).OrderByDescending(p => p.Fans).ThenBy(p => p.Id, StringComparer.Ordinal).ToList();
        int rank = rows.FindIndex(p => p.Id == "player") + 1;
        var hero = Card(); _content.AddChild(hero); var heroBody = Inner(hero);
        heroBody.AddChild(Text("AUDIENCE / 关注与声望", 15, _muted));
        heroBody.AddChild(PersonLink(d, "player", CareerEngine.Name(d) + " · " + CareerAudience.Title(d.Fans), 82));
        var metrics = new HBoxContainer(); heroBody.AddChild(metrics);
        foreach (var (title, value) in new[] { ("关注者", d.Fans.ToString("N0")), ("世界排名", "#" + rank), ("新赞助报价", "×" + CareerAudience.QuoteMultiplier(d.Fans).ToString("0.00")) })
        {
            var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; metrics.AddChild(box);
            box.AddChild(Text(title, 16, _muted)); box.AddChild(Text(value, 32, _gold));
        }
        var next = CareerAudience.Titles.FirstOrDefault(t => t.Floor > d.Fans);
        if (next.Floor > 0)
        {
            heroBody.AddChild(Text($"下一称号 · {next.Name}  /  {next.Floor:N0}关注", 17, CareerVisuals.Teal));
            heroBody.AddChild(new ProgressBar { MaxValue = next.Floor, Value = d.Fans, ShowPercentage = false, CustomMinimumSize = new(0, 10) });
        }
        var podium = new HBoxContainer(); _content.AddChild(podium);
        foreach (int position in new[] { 1, 0, 2 }.Where(i => i < rows.Count))
        {
            var winner = rows[position]; var card = Card(); podium.AddChild(card); var box = Inner(card);
            box.AddChild(Text(position == 0 ? "01 / 人气之巅" : $"{position + 1:00} / 焦点选手", 18, position == 0 ? _gold : _muted));
            box.AddChild(PersonLink(d, winner.Id, CareerEngine.DisplayName(d, winner.Id), position == 0 ? 76 : 60));
            box.AddChild(Text(winner.Fans.ToString("N0"), 26, CareerVisuals.Teal));
            box.AddChild(Text(CareerAudience.Title(winner.Fans), 16, _muted));
        }
        _content.AddChild(Text("世界人气榜", 24, _gold));
        foreach (int index in Enumerable.Range(0, Math.Min(20, rows.Count)).Concat(Enumerable.Range(Math.Max(0, rank - 3), Math.Min(5, rows.Count - Math.Max(0, rank - 3)))).Distinct())
        {
            var row=rows[index];BoardLine(_content,d,index+1,CareerEngine.DisplayName(d,row.Id),CareerAudience.Title(row.Fans),$"{row.Fans:N0} 关注",row.Id,row.Id=="player");
        }
    }
}
