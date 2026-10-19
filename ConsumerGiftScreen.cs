using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void GiftRecipientPicker(CareerData data, Good good, int quantity, bool wedding = false, string? inviteVerb = null, int inviteSlots = 0, bool buyInvitation = false)
    {
        bool invitation = inviteVerb != null, guests = wedding || invitation;
        if (guests && ConsumerInvitationStock.Active(data)) { Notice(ConsumerInvitationStock.ActiveMessage, true); return; }
        long capacity = guests ? wedding ? 1 : inviteSlots : (long)quantity + ConsumerGifts.Available(data, good.Id);
        var selected = new Dictionary<string, int>(); var invalid = new HashSet<string>();
        var inputTexts = new Dictionary<string, string>();
        var candidates = (guests ? ConsumerEngine.InviteCandidates(data).Where(p => !wedding || PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived == true)
            : ConsumerGifts.Recipients(data, good.Id)).ToArray();
        string query = "", filter = "按最近聊天"; bool direct = true;
        Button? confirm = null; Label? count = null, error = null;
        var familiar = PrivateMessages.Mailbox(data).Conversations.Keys.ToHashSet();
        var opponents = data.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).ToHashSet();
        var authors = CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30).SelectMany(p => p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId)).ToHashSet();
        var recent = CommunitySharing.Recipients(data, "").Select((p, index) => (p.Id, index)).ToDictionary(p => p.Id, p => p.index);
        void Counter()
        {
            long total = selected.Values.Sum(v => (long)v); bool over = total > capacity;
            if (count != null)
            {
                count.Text = (guests ? $"已选择 {selected.Count}/{capacity} 人" : $"赠送 {good.Name} {total}/{capacity}个")
                    + (over ? guests ? "：超过邀约人数" : "：购买数量与可用库存不足" : invalid.Count > 0 ? "：请输入有效数量" : "");
                count.Modulate = over || invalid.Count > 0 ? new Color("f394a4") : CareerVisuals.Teal;
            }
            if (confirm != null) confirm.Disabled = total <= 0 || over || invalid.Count > 0;
        }
        ShowCareerDialog(guests ? good.Name + " · 邀约" : "赠送 " + good.Name, invitation ? $"好感达到5的角色可参与，最多邀请{inviteSlots}人。" : "", () =>
        {
            if (selected.Count == 0 || selected.Values.Sum(v => (long)v) > capacity || invalid.Count > 0) return false;
            if (invitation)
            {
                var people = selected.Keys.ToList();
                void AcceptedInvite() { _multiplayer?.Refresh(); Callable.From(() => { Render(); OpenPrivateMessages(people[0]); }).CallDeferred(); }
                if (MultiplayerCommand("consumer-invite", good.Id, JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)), accepted: AcceptedInvite)) return true;
                string? inviteFailure = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation));
                if (inviteFailure != null) { error!.Text = inviteFailure; return false; }
                AcceptedInvite(); return true;
            }
            var targets = selected.Select(p => new GiftAllocation(p.Key, p.Value)).ToList();
            var order = new GiftPurchase(good.Id, quantity, targets, direct);
            string kind = wedding ? "consumer-wedding" : "consumer-gift";
            string person = targets[0].Person;
            void Accepted()
            {
                _multiplayer?.Refresh();
                Callable.From(() =>
                {
                    Render(); OpenPrivateMessages(person);
                    if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。";
                }).CallDeferred();
                if (_multiplayer == null && !wedding && direct)
                    foreach (var target in targets) _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target.Person);
            }
            if (MultiplayerCommand(kind, wedding ? person : good.Id, JsonSerializer.Serialize(order), accepted: Accepted)) return true;
            string? failure = EconomicActions.Save(data, value => wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order));
            if (failure != null) { error!.Text = failure; return false; }
            Accepted(); return true;
        }, "确定", box =>
        {
            var search = new LineEdit { Name = "GiftPersonSearch", PlaceholderText = "搜索名称", CustomMinimumSize = new(600, 44) }; box.AddChild(search);
            var dropdown = new OptionButton { Name = "GiftPersonFilter", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) };
            foreach (string item in new[] { "按最近聊天", "按好感度", "熟悉的人", "同俱乐部", "近期对手", "近期发帖回帖者", "全部" }) dropdown.AddItem(item); box.AddChild(dropdown);
            var scroll = new ScrollContainer { Name = "GiftPeopleScroll", CustomMinimumSize = new(600, 330), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(list);
            var rows = new List<(HBoxContainer Row, Button Name, ConsumerQuantity Quantity)>(); CareerPerson[] people = [];
            const int rowHeight = 68;
            void Rows()
            {
                int first = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1));
                int visible = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight) + 1);
                while (rows.Count < visible)
                {
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); list.AddChild(row);
                    var amount = new ConsumerQuantity { Minimum = 0, Maximum = guests ? 1 : int.MaxValue }; amount.Initialize(0); amount.Visible = !guests; row.AddChild(amount);
                    var choice = PrivateButton("", () => { }, 0); choice.ToggleMode = true; choice.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                    choice.CustomMinimumSize = new(0, 48); choice.Alignment = HorizontalAlignment.Left;
                    foreach (string state in new[] { "pressed", "hover_pressed" })
                    {
                        var style = CareerVisuals.Box("304f60", "70d4bc", 8, 10);
                        style.BorderWidthLeft = style.BorderWidthRight = style.BorderWidthTop = style.BorderWidthBottom = 2;
                        choice.AddThemeStyleboxOverride(state, style);
                    }
                    choice.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
                    choice.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; row.AddChild(choice);
                    void Update(bool active)
                    {
                        string id = choice.GetMeta("person", "").AsString(); if (id.Length == 0) return;
                        if (wedding) selected.Clear();
                        if (active) selected[id] = amount.Value;
                        else { selected.Remove(id); inputTexts.Remove(id); amount.SetValue(0); }
                        if (!active || amount.Valid) invalid.Remove(id); else invalid.Add(id);
                        choice.SetPressedNoSignal(active);
                        if (wedding) foreach (var r in rows) r.Name.SetPressedNoSignal(selected.ContainsKey(r.Name.GetMeta("person", "").AsString()));
                        Counter();
                    }
                    choice.Toggled += active => { amount.SetValue(active ? 1 : 0); inputTexts.Remove(choice.GetMeta("person", "").AsString()); Update(active); };
                    amount.Changed += () => { inputTexts[choice.GetMeta("person", "").AsString()] = amount.InputText; Update(!amount.Valid || amount.Value > 0); }; rows.Add((row, choice, amount));
                }
                for (int i = 0; i < rows.Count; i++)
                {
                    var (row, choice, amount) = rows[i]; row.Visible = i < visible; if (i >= visible) continue;
                    var person = people[first + i];
                    if (choice.GetMeta("person", "").AsString() != person.Id)
                    {
                        foreach (var avatar in row.GetChildren().OfType<CareerAvatar>().ToArray()) { row.RemoveChild(avatar); avatar.QueueFree(); }
                        var art = Avatar(data, person.Id, 36, false); row.AddChild(art); row.MoveChild(art, 0);
                        choice.SetMeta("person", person.Id); choice.Text = person.PublicName + " · " + person.Role; choice.TooltipText = choice.Text;
                        amount.SetValue(selected.GetValueOrDefault(person.Id));
                        if (inputTexts.TryGetValue(person.Id, out string? raw)) amount.RestoreText(raw);
                        PickerRing(row, data, person.Id);
                    }
                    choice.SetPressedNoSignal(selected.ContainsKey(person.Id)); row.Position = new(0, (first + i) * rowHeight); row.Size = new(list.Size.X, rowHeight - 8);
                }
            }
            void Filter()
            {
                var matches = candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                    .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => data.Esports.ClubId.Length > 0 && p.ClubId == data.Esports.ClubId,
                        "近期对手" => opponents.Contains(p.Id), "近期发帖回帖者" => authors.Contains(p.Id), "按好感度" => PrivateMessages.Favour(data, p.Id) > 0, _ => true });
                people = (filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id))
                    : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)).ToArray();
                list.CustomMinimumSize = new(0, people.Length * rowHeight); scroll.ScrollVertical = 0; Rows();
            }
            count = PrivateLine("", 16, Colors.White); count.Name = "GiftAllocationCount"; box.AddChild(count);
            if (!guests)
            {
                var immediately = new CheckBox { Name = "DirectGift", Text = "直接赠送礼物", ButtonPressed = true }; immediately.Toggled += value => direct = value; box.AddChild(immediately);
            }
            else if (wedding) box.AddChild(Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted));
            error = Text(candidates.Length == 0 ? wedding ? "尚无收到誓约之戒的对象。" : "暂无符合赠送条件的对象。" : "", 15, new Color("ee929d")); box.AddChild(error);
            search.TextChanged += value => { query = value.Trim(); Filter(); }; dropdown.ItemSelected += n => { filter = dropdown.GetItemText((int)n); Filter(); };
            scroll.GetVScrollBar().ValueChanged += _ => Rows(); scroll.Resized += Rows; list.Resized += Rows; Filter(); Counter();
        });
        if (_dialogOverlay != null && CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm") is Button button) { confirm = button; Counter(); }
    }

    private void PrivateGiftPicker()
    {
        var data = ViewData; string person = _privatePerson; var chosen = new Dictionary<string, int>(); var inputs = new List<ConsumerQuantity>();
        Label? error = null; Button? confirm = null;
        void Validate() { if (confirm != null) confirm.Disabled = !chosen.Values.Any(v => v > 0) || inputs.Any(i => !i.Valid); }
        ShowCareerDialog("赠送礼物", "选择库存中的礼物，附到消息后可以填写赠礼留言。", () =>
        {
            var gift = ConsumerGifts.Draft(chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value }));
            if (inputs.Any(i => !i.Valid) || ConsumerGifts.Validate(ViewData, person, gift) is { }) { error!.Text = "请检查库存和礼物数量。"; return false; }
            PrivateCommand("dm-gift-draft", new() { Request = gift }, RefreshPrivateAttachments); return true;
        }, "确认", box =>
        {
            var scroll = new ScrollContainer { CustomMinimumSize = new(600, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); scroll.AddChild(grid);
            foreach (var good in ConsumerCatalog.All.Where(g => g.Giftable && ConsumerGifts.Available(data, g.Id) > 0))
            {
                var card = Card(); grid.AddChild(card); var body = Inner(card); body.AddChild(Text(good.Name, 18, _ink));
                int available = ConsumerGifts.Available(data, good.Id); body.AddChild(Text($"库存 {available:N0}", 15, _muted));
                string? reason = ConsumerGifts.RecipientError(data, person, good.Id);
                if (reason != null) { body.AddChild(Text(reason, 14, _muted)); continue; }
                var input = new ConsumerQuantity { Name = "GiftStock_" + good.Id, Minimum = 0, Maximum = available }; input.Initialize(0); inputs.Add(input); body.AddChild(input);
                input.Changed += () => { chosen[good.Id] = input.Value; Validate(); };
            }
            if (grid.GetChildCount() == 0) box.AddChild(Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted));
            error = Text("", 15, new Color("ee929d")); box.AddChild(error);
        });
        if (_dialogOverlay != null && CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm") is Button button)
        {
            confirm = button; Validate();
            var actions = (HBoxContainer)button.GetParent();
            var shop = PrivateButton("前往商城", () =>
            {
                _cancelDialog?.Invoke(); ClosePrivateMessagesCore(false);
                Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; });
            }, 130); shop.Name = "GiftGoToShop"; actions.AddChild(shop); actions.MoveChild(shop, 0);
            var spacer = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; actions.AddChild(spacer); actions.MoveChild(spacer, 1);
        }
    }
}
