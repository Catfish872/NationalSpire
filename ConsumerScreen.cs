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
        var navigation = new HFlowContainer(); _content.AddChild(navigation);
        foreach (string tier in ConsumerCatalog.TierOrder)
            navigation.AddChild(FilterButton(tier, !_shopOwned && _shopTier == tier, () => { _shopTier = tier; _shopOwned = false; _shopPage = 0; _shopCategory = "全部"; Render(); }, 110));
        navigation.AddChild(FilterButton("我的收藏", _shopOwned, () => { _shopOwned = true; _shopPage = 0; Render(); }, 130));
        var columns = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _content.AddChild(columns);
        var categories = new VBoxContainer { CustomMinimumSize = new(140, 0) }; columns.AddChild(categories);
        foreach (string category in new[] { "全部" }.Concat(ConsumerCatalog.Categories(_shopTier)))
            categories.AddChild(FilterButton(category, _shopCategory == category, () => { _shopCategory = category; _shopPage = 0; Render(); }, 140));
        var goods = ConsumerCatalog.InTier(_shopTier).Where(g => _shopCategory == "全部" || g.Category == _shopCategory).ToArray();
        if (_shopOwned) goods = d.Life.Consumer.Goods.Where(g => g.Durable).Select(g => ConsumerCatalog.Get(g.Id)).OfType<Good>().ToArray();
        _shopPage = Math.Min(_shopPage, Math.Max(0, (goods.Length - 1) / 6));
        if (!goods.Any(g => g.Id == _shopSelected)) _shopSelected = goods.FirstOrDefault()?.Id ?? "";
        var catalog = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 }; columns.AddChild(catalog);
        var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); catalog.AddChild(grid);
        foreach (var good in goods.Skip(_shopPage * 6).Take(6))
        {
            var card = Card(); grid.AddChild(card); var box = Inner(card);
            box.AddChild(new LifestyleArt { Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 100), SizeFlagsHorizontal = SizeFlags.ExpandFill });
            box.AddChild(Text(good.Category, 14, _muted));
            box.AddChild(Button(good.Name, () => { _shopSelected = good.Id; Render(); }, 0));
            box.AddChild(Text(_shopOwned ? "已收藏" : $"${ConsumerEngine.Price(good):N0}", 23, CareerVisuals.Teal));
        }
        var pages = new HBoxContainer(); catalog.AddChild(pages);
        if (_shopPage > 0) pages.AddChild(Button("← 上一页", () => { _shopPage--; Render(); }, 140));
        pages.AddChild(Text($"{_shopPage + 1} / {Math.Max(1, (goods.Length + 5) / 6)}", 16, _muted));
        if ((_shopPage + 1) * 6 < goods.Length) pages.AddChild(Button("下一页 →", () => { _shopPage++; Render(); }, 140));
        if (ConsumerCatalog.Get(_shopSelected) is not { } selected) { catalog.AddChild(Text(_shopOwned ? "尚未拥有收藏品" : "没有符合条件的商品", 18, _muted)); return; }
        var detail = Card(); detail.SizeFlagsStretchRatio = 1; columns.AddChild(detail); var body = Inner(detail);
        body.AddChild(new LifestyleArt { Category = selected.Category + " " + selected.Name, CustomMinimumSize = new(0, 205), SizeFlagsHorizontal = SizeFlags.ExpandFill });
        body.AddChild(Text(selected.Name, 28, _gold)); body.AddChild(Text(selected.Tier + " / " + selected.Category, 15, _muted));
        body.AddChild(Text($"${ConsumerEngine.Price(selected):N0}", 32, CareerVisuals.Teal));
        if (selected.Promo) body.AddChild(Text($"本次新增关注 {CareerAudience.PromotionGain(d.Fans, ConsumerEngine.Price(selected), ConsumerEngine.Uses(d, selected.Id)):N0}\n每赛季最多3次", 18, _ink));
        if (_shopOwned)
        {
            var owned = d.Life.Consumer.Goods.First(g => g.Id == selected.Id);
            foreach (var verb in selected.Verbs)
            {
                bool used = owned.UsedSeason == d.Season && owned.UsedVerbs.Contains(verb.Id);
                var button = Button(verb.Name + (used ? " · 本季已举办" : $" · ${ConsumerEngine.HospitalityFee(selected):N0}"), () => ConsumerInvite(d, selected, verb.Id, verb.Slots), 0);
                button.Disabled = used; body.AddChild(button);
            }
        }
        else
        {
            if (selected.Durable) body.AddChild(Text("收藏后可举办\n" + string.Join("\n", selected.Verbs.Select(v => v.Name)), 18, _ink));
            string? error = ConsumerEngine.BuyError(d, selected);
            var purchase = Button(error ?? "确认购买", () => ConsumerSubmit(d, selected, "", []), 0); purchase.Disabled = error != null; body.AddChild(purchase);
            if (selected.Slots > 0 && error == null) body.AddChild(Button("邀请同行", () => ConsumerInvite(d, selected, "", selected.Slots), 0));
        }
    }
    private void ConsumerSubmit(CareerData d, Good good, string verb, List<string> guests)
    {
        string kind = verb.Length == 0 ? "consumer-buy" : "consumer-use";
        if (MultiplayerCommand(kind, good.Id, text: JsonSerializer.Serialize(new ConsumerOrder(verb, guests)))) return;
        var error = EconomicActions.Save(d, value => verb.Length == 0 ? ConsumerEngine.Buy(value, good.Id, guests) : ConsumerEngine.Use(value, good.Id, verb, guests));
        Render(); if (error != null) Notice(error, true);
    }
    private void ConsumerInvite(CareerData d, Good good, string verb, int slots)
    {
        var selected = new HashSet<string>();
        ShowCareerDialog(good.Name, $"最多邀请{slots}位选手；好感达到5即可邀请。", () => { ConsumerSubmit(d, good, verb, selected.ToList()); return true; }, "确认", box =>
        {
            var search = new LineEdit { PlaceholderText = "搜索选手", SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(search);
            var scroll = new ScrollContainer { CustomMinimumSize = new(500, 340), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(list);
            var counter = Text("已选择0人", 16, _muted); box.AddChild(counter);
            void Fill(string query)
            {
                foreach (var child in list.GetChildren()) { list.RemoveChild(child); child.QueueFree(); }
                foreach (var person in d.People.Where(p => ConsumerEngine.CanInvite(d, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))).OrderByDescending(p => p.ClubId == d.Esports.ClubId).Take(40))
                {
                    var button = Button(person.PublicName, () => { }, 320); button.ToggleMode = true; button.ButtonPressed = selected.Contains(person.Id);
                    button.Toggled += pressed =>
                    {
                        if (pressed && selected.Count >= slots) button.SetPressedNoSignal(false);
                        else if (pressed) selected.Add(person.Id); else selected.Remove(person.Id);
                        counter.Text = $"已选择{selected.Count}人";
                    };
                    list.AddChild(button);
                }
            }
            search.TextChanged += Fill; Fill("");
        });
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
            var row = rows[index]; var card = Card(); _content.AddChild(card);
            Inner(card).AddChild(PersonLink(d, row.Id, $"{index + 1:00}   {CareerEngine.DisplayName(d, row.Id)}   {row.Fans:N0}关注", 42));
        }
    }
}
