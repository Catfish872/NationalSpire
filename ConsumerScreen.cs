using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _shopTier = ConsumerCatalog.Mass;
    private string _shopCategory = "全部", _shopSelected = "";
    private bool _shopOwned;
    private int _shopPage;
    private void ConsumerShop(CareerData d)
    {
        var purchases = new ConsumerPurchases(d);
        var available = (_shopOwned ? purchases.Collection : ConsumerCatalog.InTier(_shopTier)).ToArray();
        var groups = available.Select(g => g.Category).Distinct().ToArray();
        if (_shopCategory != "全部" && !groups.Contains(_shopCategory)) _shopCategory = "全部";
        var navigation = new HFlowContainer(); _content.AddChild(navigation);
        foreach (string tier in ConsumerCatalog.TierOrder)
            navigation.AddChild(FilterButton(tier, !_shopOwned && _shopTier == tier, () => { _shopTier = tier; _shopOwned = false; _shopPage = 0; _shopCategory = "全部"; Render(); }, 110));
        navigation.AddChild(FilterButton("我的收藏", _shopOwned, () => { _shopOwned = true; _shopPage = 0; _shopCategory = "全部"; Render(); }, 130));
        var columns = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _content.AddChild(columns);
        var categories = new VBoxContainer { CustomMinimumSize = new(140, 0) }; columns.AddChild(categories);
        foreach (string category in new[] { "全部" }.Concat(groups))
            categories.AddChild(FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140));
        var goods = available.Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray();
        _shopPage = Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / 6));
        if (!goods.Any(g => g.Id == _shopSelected)) _shopSelected = goods.FirstOrDefault()?.Id ?? "";
        var catalog = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 }; columns.AddChild(catalog);
        var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); catalog.AddChild(grid);
        var detail = Card(); detail.SizeFlagsStretchRatio = 1; var body = Inner(detail);
        var cards = new List<(Button Button, Good Good)>();
        void Select(Good good)
        {
            _shopSelected = good.Id;
            foreach (var item in cards) ConsumerVisuals.ProductStyle(item.Button, purchases.ThisSeason(item.Good) || item.Good.Promo, item.Good.Id == _shopSelected);
            foreach (var child in body.GetChildren()) { body.RemoveChild(child); child.QueueFree(); }
            ConsumerDetail(d, good, purchases, body);
        }
        foreach (var good in goods.Skip(_shopPage * 6).Take(6))
        {
            var card = new Button { Name = "Product_" + good.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 235) };
            grid.AddChild(card); cards.Add((card, good)); card.Pressed += () => Select(good);
            var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }; card.AddChild(margin);
            margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 16);
            var box = new VBoxContainer(); margin.AddChild(box);
            string label = purchases.Label(good);
            bool current = purchases.ThisSeason(good) || good.Promo;
            ConsumerVisuals.ProductStyle(card, current, good.Id == _shopSelected);
            var artwork = new Control { CustomMinimumSize = new(0, 100), SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(artwork);
            var art = new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name }; artwork.AddChild(art); art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            if (!_shopOwned && label.Length > 0)
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
            box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(d, good):N0}", 23, CareerVisuals.Teal));
            void IgnoreMouse(Node node)
            {
                if (node is Control control) control.MouseFilter = MouseFilterEnum.Ignore;
                foreach (var child in node.GetChildren()) IgnoreMouse(child);
            }
            IgnoreMouse(margin);
        }
        var pages = new HBoxContainer(); catalog.AddChild(pages);
        if (_shopPage > 0) pages.AddChild(Button("← 上一页", () => { _shopPage--; Render(); }, 140));
        pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + 5) / 6)}", 16, _muted));
        if ((_shopPage + 1) * 6 < goods.Length) pages.AddChild(Button("下一页 →", () => { _shopPage++; Render(); }, 140));
        if (ConsumerCatalog.Get(_shopSelected) is not { } selected) { detail.QueueFree(); catalog.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted)); return; }
        columns.AddChild(detail); ConsumerDetail(d, selected, purchases, body);
    }
    private void ConsumerDetail(CareerData d, Good selected, ConsumerPurchases purchases, VBoxContainer body)
    {
        body.AddThemeConstantOverride("separation", 14);
        Button ShopAction(string label, Action action)
        {
            var button = Button("确认购买", action); body.AddChild(button);
            button.CustomMinimumSize = new(button.GetCombinedMinimumSize().X, button.CustomMinimumSize.Y); button.Text = label; return button;
        }
        body.AddChild(new LifestyleArt { ProductId = selected.Id, Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 205), SizeFlagsHorizontal = SizeFlags.ExpandFill });
        body.AddChild(Text(selected.Name, 28, _gold)); body.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted));
        int quantity = 1;
        var pricing = new HBoxContainer(); pricing.AddThemeConstantOverride("separation", 12); body.AddChild(pricing);
        ConsumerQuantity? amount = null;
        if (selected.Giftable && !_shopOwned) { amount = new() { Name = "ShopQuantity", Minimum = 1 }; amount.Initialize(1); pricing.AddChild(amount); }
        var price = Text($"${ConsumerEngine.Price(d, selected):N0}", 32, CareerVisuals.Teal); price.SizeFlagsVertical = SizeFlags.ShrinkCenter; pricing.AddChild(price);
        if (ConsumerInvitationStock.Ticket(selected)) body.AddChild(Text($"可邀约库存 {ConsumerInvitationStock.Available(d, selected.Id):N0}", 16, _muted));
        if (selected.Giftable) body.AddChild(Text($"可赠库存 {ConsumerGifts.Available(d, selected.Id):N0}", 16, _muted));
        if (selected.Id == "oath-ring") body.AddChild(Text("向好感已满的恋人献上誓约之戒，许下一生的承诺。", 17, _ink));
        if (selected.Id == "grand-wedding")
        {
            body.AddChild(Text("向已收到誓约之戒的对象发起婚礼邀约。", 17, _ink));
            var wedding = ShopAction("邀约", () => GiftRecipientPicker(d, selected, 1, true)); GuardInvitationButton(wedding, d); return;
        }
        if (selected.Promo) body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}\n每赛季最多3次", 18, _ink));
        if (_shopOwned)
        {
            body.AddChild(Text("最近购买 · " + PrivateAppointments.DateText(d, purchases.Day(selected)), 16, _muted));
            if (selected.Giftable && d.Life.Consumer.GiftStock.GetValueOrDefault(selected.Id) > 0)
                ShopAction("赠送", () => GiftRecipientPicker(d, selected, 0)).Disabled = ConsumerGifts.Available(d, selected.Id) == 0;
            if (selected.Slots > 0) { var invite = ShopAction("邀约", () => ConsumerInvite(d, selected, "", selected.Slots)); invite.Disabled = ConsumerInvitationStock.Available(d, selected.Id) == 0; GuardInvitationButton(invite, d); }
            var owned = d.Life.Consumer.Goods.FirstOrDefault(g => g.Id == selected.Id && g.Durable);
            foreach (var verb in selected.Verbs)
            {
                bool used = owned != null && owned.UsedSeason == d.Season && owned.UsedVerbs.Contains(verb.Id);
                var button = Button(verb.Name + (used ? " · 本季已举办" : $" · ${ConsumerEngine.HospitalityFee(d, selected):N0}"), () => ConsumerInvite(d, selected, verb.Id, verb.Slots), 0);
                button.Disabled = used || ConsumerInvitationStock.Available(d, selected.Id, verb.Id) == 0; GuardInvitationButton(button, d); body.AddChild(button);
            }
        }
        else
        {
            if (selected.Durable) body.AddChild(Text("收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name)), 18, _ink));
            string? error = ConsumerEngine.BuyError(d, selected);
            var purchase = ShopAction("购买", () => ConsumerSubmit(d, selected, "", [], quantity)); purchase.Disabled = error != null; purchase.TooltipText = error ?? "";
            Button? gift = null;
            if (selected.Giftable) { gift = ShopAction("赠送", () => GiftRecipientPicker(d, selected, quantity)); gift.Disabled = error != null; }
            var status = Text(error ?? "", 15, new Color("ee929d")); status.Visible = error != null; body.AddChild(status);
            if (amount != null) amount.Changed += () =>
            {
                quantity = amount.Value; price.Text = $"${ConsumerEngine.Price(d, selected) * (decimal)quantity:N0}";
                string? invalid = amount.Valid ? ConsumerEngine.BuyError(d, selected, quantity) : "请输入有效的购买数量。";
                purchase.Disabled = invalid != null; if (gift != null) gift.Disabled = invalid != null;
                status.Text = invalid ?? ""; status.Visible = invalid != null;
            };
            if (selected.Slots > 0)
            {
                var invite = ShopAction("邀约", () => GiftRecipientPicker(d, selected, 0, false, "", selected.Slots, true));
                invite.Disabled = error != null; invite.TooltipText = error ?? "确认对象后购买并预留活动，取消附件可返还库存。"; GuardInvitationButton(invite, d);
            }
        }
    }
    private void ConsumerSubmit(CareerData d, Good good, string verb, List<string> guests, int quantity = 1)
    {
        string kind = verb.Length == 0 ? "consumer-buy" : "consumer-use";
        if (MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests, quantity)))) return;
        var error = EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests, quantity) : ConsumerEngine.Use(value, good.Id, verb, guests));
        Render(); if (error != null) Notice(error, true);
    }
    private void ConsumerInvite(CareerData d, Good good, string verb, int slots)
        => GiftRecipientPicker(d, good, 0, false, verb, slots);
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
            var row = rows[index]; var card = Card(); _content.AddChild(card);
            Inner(card).AddChild(PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42));
        }
    }
}
