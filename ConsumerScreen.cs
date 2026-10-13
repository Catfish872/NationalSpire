using Godot;

namespace NationalSpire;

/// <summary>消费品与投资 · 界面：商城（四档 + 分类 + 已持有 + 动用）与人气榜。
/// 文案全部在 ConsumerText.cs，改文案不用碰这个文件。</summary>
public partial class CareerScreen
{
    private string _shopTier = ConsumerCatalog.Mass;

    // ───────────────────────── 商城 ─────────────────────────

    private void ConsumerShop(CareerData d)
    {
        ConsumerEngine.Ensure(d);
        AddHeading(ConsumerText.ShopTitle, ConsumerText.ShopIntro);
        _content.AddChild(Text(ConsumerText.ShopBalance(CareerMoney.Format(CareerMoney.Balance(d)), d.Fans, ConsumerEngine.SegmentLabel(d.Fans), d.Consumer.PurchaseCount), 18, _gold));
        var tabs = new HBoxContainer(); _content.AddChild(tabs);
        foreach (string tier in ConsumerCatalog.TierOrder)
            tabs.AddChild(FilterButton(tier, _shopTier == tier, () => { _shopTier = tier; Render(); }, 120));
        _content.AddChild(Text(TierHint(_shopTier), 16, _muted));

        foreach (string category in ConsumerCatalog.Categories(_shopTier))
        {
            _content.AddChild(Text(category, 22, CareerVisuals.Teal));
            var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); _content.AddChild(grid);
            foreach (var good in ConsumerCatalog.InTier(_shopTier).Where(g => g.Category == category)) ShopCard(d, grid, good);
        }
        OwnedGoods(d);
    }

    private static string TierHint(string tier) => tier switch
    {
        ConsumerCatalog.Mass => ConsumerText.TierMassHint,
        ConsumerCatalog.Middle => ConsumerText.TierMiddleHint,
        ConsumerCatalog.Rich => ConsumerText.TierRichHint,
        ConsumerCatalog.Luxury => ConsumerText.TierLuxuryHint,
        _ => ConsumerText.TierPromoHint
    };

    private void ShopCard(CareerData d, GridContainer parent, Good good)
    {
        var card = Card(); parent.AddChild(card); var box = Inner(card);
        box.AddChild(Text(good.Name, 22, _gold));
        box.AddChild(Text($"${good.Price:N0}", 17, CareerVisuals.Teal));
        if (good.Durable)
            box.AddChild(Text(ConsumerText.DurableState + "\n" + ConsumerText.DurableVerbs(string.Join(" / ", good.Verbs.Select(v => ConsumerText.VerbSlot(v.Name, v.Slots)))), 15, _muted));
        else if (good.Promo) box.AddChild(Text(ConsumerText.PromoState(Remaining(d, good), ConsumerEngine.PromoPercent(good.Id)), 15, _muted));
        else if (good.Repeatable) box.AddChild(Text(ConsumerText.RepeatState(ConsumerCatalog.RepeatCooldown), 15, _muted));
        else box.AddChild(Text(ConsumerText.MassState, 15, _muted));
        string? error = ConsumerEngine.BuyError(d, good);
        var buy = Button(error == null ? ConsumerText.Buy : error, () =>
        {
            var message = ConsumerEngine.Buy(d, good.Id);
            Render(); Notice(message ?? $"{good.Name} 已入账，帖子已经发出。", message != null);
        }, 150);
        buy.Disabled = error != null;
        box.AddChild(buy);
        if (good.Slots > 0 && error == null)
            box.AddChild(Button(ConsumerText.BuyWith(good.Slots), () => MultiPickDialog(d, $"{good.Name} · 邀请",
                ConsumerText.BuyInviteIntro(good.Slots, ConsumerEngine.InviteFavourGate), ConsumerText.Buy, good.Slots, ids =>
                {
                    var message = ConsumerEngine.Buy(d, good.Id, ids);
                    Render(); Notice(message ?? $"{good.Name} 已入账，帖子已经发出。", message != null);
                }), 220));
    }

    private static int Remaining(CareerData d, Good good)
        => Math.Max(0, ConsumerCatalog.PromoPerSeason - d.Consumer.PromoUsed.GetValueOrDefault(good.Id));

    private void OwnedGoods(CareerData d)
    {
        // 只列"现在仍然算耐用品"的持有物：目录改过档位（比如超级奢侈旅游改成娱乐）时，旧档里的记录不会变成空卡片。
        var mine = d.Consumer.Goods.Where(g => g.Durable && ConsumerCatalog.Get(g.Id) is { Durable: true }).ToList();
        if (mine.Count == 0) return;
        _content.AddChild(Text(ConsumerText.OwnedTitle, 24, _gold));
        foreach (var owned in mine)
        {
            var good = ConsumerCatalog.Get(owned.Id);
            if (good == null) continue;
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text(ConsumerText.OwnedLeft(good.Name, ConsumerEngine.VerbsLeft(d, owned)), 21, _gold));
            foreach (var verb in good.Verbs)
            {
                bool used = owned.UsedVerbs.Contains(verb.Id);
                var line = new HBoxContainer(); line.AddThemeConstantOverride("separation", 14); box.AddChild(line);
                line.AddChild(Text(ConsumerText.VerbLine(verb.Name, verb.Slots, verb.Favor, $"${ConsumerEngine.HospitalityFee(good):N0}"), 16, used ? _muted : _ink));
                if (used) { line.AddChild(Text(ConsumerText.VerbUsed, 15, _muted)); continue; }
                line.AddChild(Button(ConsumerText.VerbOpen, () => MultiPickDialog(d, $"{good.Name} · {verb.Name}",
                    ConsumerText.InviteIntro(verb.Slots, ConsumerEngine.InviteFavourGate, verb.Favor) + "\n" + ConsumerText.InviteFee($"${ConsumerEngine.HospitalityFee(good):N0}"),
                    ConsumerText.VerbOpen, verb.Slots, ids =>
                    {
                        var error = ConsumerEngine.Use(d, good.Id, verb.Id, ids);
                        Render(); Notice(error ?? $"{verb.Name}结束，帖子已经发出。", error != null);
                    }), 160));
            }
        }
    }

    /// <summary>多人选择弹窗：party 邀请与"带人一起消费"共用同一套（全世界搜索 + 好感门槛置灰 + 限人数）。</summary>
    private void MultiPickDialog(CareerData d, string title, string intro, string confirmText, int slots, Action<List<string>> onConfirm)
    {
        var selected = new HashSet<string>();
        Label counter = null!;
        VBoxContainer list = null!;
        ShowCareerDialog(title, intro, () => { onConfirm(selected.ToList()); return true; }, confirmText, box =>
        {
            counter = Text(ConsumerText.InviteChosen(0, slots), 16, CareerVisuals.Teal);
            box.AddChild(counter);
            var search = new LineEdit { PlaceholderText = ConsumerText.PickerSearchHint, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(460, 46) };
            box.AddChild(search);
            var scroll = new ScrollContainer { CustomMinimumSize = new Vector2(0, 320), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            box.AddChild(scroll);
            list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            scroll.AddChild(list);
            void Fill(string query)
            {
                foreach (var child in list.GetChildren()) child.QueueFree();
                // 搜索走 @人物 的同一套（全世界按昵称/姓名）；空查询时先给"本队 + 好感达标"的默认名单。
                var people = query.Length > 0 ? PersonMentions.Search(d, query, 100) : ConsumerEngine.InviteCandidates(d).Take(100).ToList();
                if (people.Count == 0) { list.AddChild(Text(ConsumerText.PickerEmpty, 16, _muted)); return; }
                foreach (var person in people)
                {
                    int favour = PrivateMessages.Favour(d, person.Id);
                    bool familiar = favour >= ConsumerEngine.InviteFavourGate;
                    string note = familiar ? $"好感 {favour}" : ConsumerText.PickerNotFamiliar(ConsumerEngine.InviteFavourGate);
                    var check = new CheckBox { Text = $"{person.PublicName} · {person.Role} · {note}", Disabled = !familiar };
                    check.ButtonPressed = selected.Contains(person.Id);
                    check.Toggled += pressed =>
                    {
                        if (pressed) { if (selected.Count >= slots) { check.ButtonPressed = false; return; } selected.Add(person.Id); }
                        else selected.Remove(person.Id);
                        counter.Text = ConsumerText.InviteChosen(selected.Count, slots);
                    };
                    list.AddChild(check);
                }
            }
            search.TextChanged += text => Fill(text.Trim());
            Fill("");
            box.AddChild(Text(ConsumerText.InviteEmptyHint, 14, _muted));
        });
    }

    /// <summary>单人选对象：复用 @人物 的全世界搜索；置灰的行会写明"为什么不能选"。</summary>
    private void PersonPicker(CareerData d, string title, LifeCatalog.Plan plan, Action<CareerPerson> onPick)
    {
        VBoxContainer list = null!;
        ShowCareerDialog(title, ConsumerText.PickerIntro, () => true, "关闭", box =>
        {
            var search = new LineEdit { PlaceholderText = ConsumerText.PickerSearchHint, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(460, 46) };
            box.AddChild(search);
            var scroll = new ScrollContainer { CustomMinimumSize = new Vector2(0, 380), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            box.AddChild(scroll);
            list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            scroll.AddChild(list);
            void Fill(string query)
            {
                foreach (var child in list.GetChildren()) child.QueueFree();
                // 有任何输入就在全世界找；空查询时给"没有阻挡原因"的默认名单。
                var people = query.Length > 0
                    ? PersonMentions.Search(d, query, 80)
                    : d.People.Where(p => p.Id != "player" && CareerLife.TargetBlockers(d, plan, p).Count == 0)
                        .OrderByDescending(p => p.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId)
                        .ThenByDescending(p => p.Rating).Take(80).ToList();
                if (people.Count == 0)
                {
                    list.AddChild(Text(query.Length > 0 ? ConsumerText.PickerEmpty : ConsumerText.NoEligibleTarget, 16, _muted));
                    return;
                }
                foreach (var person in people)
                {
                    var blockers = CareerLife.TargetBlockers(d, plan, person);
                    bool eligible = blockers.Count == 0;
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); list.AddChild(row);
                    bool mine = person.ClubId.Length > 0 && person.ClubId == d.Esports.ClubId;
                    row.AddChild(Text($"{person.PublicName} · {person.Role}" + (person.ClubId.Length > 0 ? " · " + EsportsWorld.ClubName(d, person.ClubId) : "") + (mine ? "（本队）" : ""), 17, eligible ? (mine ? _gold : _ink) : _muted));
                    if (!eligible) row.AddChild(Text(ConsumerText.BlockedBy(string.Join("、", blockers)), 14, new Color("ee929d")));
                    var pick = Button(ConsumerText.PickerPick, () => onPick(person), 130);
                    pick.Disabled = !eligible;
                    row.AddChild(pick);
                }
            }
            search.TextChanged += text => Fill(text.Trim());
            Fill("");
        });
    }

    // ───────────────────────── 人气榜 ─────────────────────────

    private void FanChart(CareerData d)
    {
        ConsumerEngine.Ensure(d);
        var rows = ConsumerEngine.Chart(d);
        int rank = rows.FindIndex(r => r.Player) + 1;
        AddHeading(ConsumerText.ChartTitle, ConsumerText.ChartIntro(rows.Count - 1));
        _content.AddChild(Text(ConsumerText.ChartMine(rank, rows.Count, d.Fans, ConsumerEngine.SegmentLabel(d.Fans)), 20, _gold));
        var top = Card(); _content.AddChild(top); var tb = Inner(top);
        foreach (var row in rows.Take(20))
        {
            int place = rows.IndexOf(row) + 1;
            var line = new HBoxContainer(); line.AddThemeConstantOverride("separation", 16); tb.AddChild(line);
            line.AddChild(Text($"{place:00}", 18, place <= 3 ? _gold : _muted));
            line.AddChild(Text(row.Name + (row.Player ? "（你）" : ""), 18, row.Player ? _gold : _ink));
            var fans = Text($"{row.Fans:N0}", 17, _muted); fans.HorizontalAlignment = HorizontalAlignment.Right; fans.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            line.AddChild(fans);
        }
        if (rank > 20)
        {
            _content.AddChild(Text(ConsumerText.ChartNearby, 22, CareerVisuals.Teal));
            var near = Card(); _content.AddChild(near); var nb = Inner(near);
            foreach (var row in rows.Skip(Math.Max(0, rank - 3)).Take(5))
            {
                int place = rows.IndexOf(row) + 1;
                nb.AddChild(Text($"{place:00}   {row.Name}{(row.Player ? "（你）" : "")}   {row.Fans:N0}", 17, row.Player ? _gold : _ink));
            }
        }
        if (d.Consumer.LastChartLine.Length > 0) _content.AddChild(Text(ConsumerText.ChartRecent + d.Consumer.LastChartLine, 15, _muted));
    }
}
