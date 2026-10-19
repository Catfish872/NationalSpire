using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void DateDiaryDialog(CareerData data, string person)
        => DateDiaryEntryDialog(data, person, "");
    private void DateDiaryEntryDialog(CareerData data, string person, string offerId)
    {
        var conversation = PrivateMessages.Conversation(data, person);
        ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box =>
        {
            var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);
            foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day))
            {
                var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId);
                card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card);
                var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body);
                body.AddChild(Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0")));
                body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink));
                body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));
            }
        }, showCancel: false);
    }
    private void GuardInvitationButton(Button button, CareerData data)
    {
        if (!ConsumerInvitationStock.Active(data)) return;
        button.Disabled = true; button.TooltipText = ConsumerInvitationStock.ActiveMessage;
        button.GuiInput += input => { if (input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left }) Notice(ConsumerInvitationStock.ActiveMessage, true); };
    }
    private void PrivateDateInvitationPicker()
    {
        var data = ViewData; string person = _privatePerson;
        if (ConsumerInvitationStock.Active(data)) { Notice(ConsumerInvitationStock.ActiveMessage, true); return; }
        if (!ConsumerEngine.CanInvite(data, person)) { Notice("邀请约会需要对方好感达到5。", true); return; }
        (Good Good, string Verb, string Title)? choice = null; Label? error = null; Button? confirm = null;
        ShowCareerDialog("邀请约会", "选择库存中的活动，附到消息后填写邀约留言。", () =>
        {
            if (choice is not { } item) return false;
            void Done() { _multiplayer?.Refresh(); RefreshPrivateAttachments(); }
            if (MultiplayerCommand("consumer-invite", item.Good.Id, JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person])), accepted: Done)) return true;
            string? failure = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person]));
            if (failure != null) { error!.Text = failure; return false; }
            Done(); return true;
        }, "邀约", box =>
        {
            var scroll = new BroadcastScroll { CustomMinimumSize = new(680, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list);
            var options = ConsumerCatalog.All.SelectMany(g => g.Verbs.Length > 0 ? g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name))
                : ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : []);
            var available = ConsumerInvitationStock.Availability(data); var buttons = new List<Button>();
            foreach (var item in options.Where(o => available.GetValueOrDefault((o.Good.Id, o.Verb)) > 0))
            {
                var button = PrivateButton(item.Title + $" · 可用 {available[(item.Good.Id, item.Verb)]}", () => { }, 0);
                button.Alignment = HorizontalAlignment.Left; button.ToggleMode = true; button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                button.Pressed += () => { choice = item; foreach (var b in buttons) b.SetPressedNoSignal(b == button); if (confirm != null) confirm.Disabled = false; };
                buttons.Add(button); list.AddChild(button);
            }
            if (buttons.Count == 0) list.AddChild(Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted));
            error = Text("", 16, new Color("ee929d")); box.AddChild(error);
        });
        confirm = _dialogOverlay?.FindChild("CareerDialogConfirm", true, false) as Button; if (confirm != null) confirm.Disabled = true;
        if (confirm?.GetParent() is HBoxContainer footer)
        {
            var shop = PrivateButton("前往商城", () =>
            {
                _cancelDialog?.Invoke(); ClosePrivateMessagesCore(false);
                Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; });
            }, 130); shop.Name = "DateInviteGoToShop"; footer.AddChild(shop); footer.MoveChild(shop, 0);
            var spacer = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; footer.AddChild(spacer); footer.MoveChild(spacer, 1);
        }
    }
}
