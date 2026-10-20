using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void GiftReceipt(PrivateOffer offer)
    {
        var card = new PanelContainer { Name = "GiftReceipt" };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 10, 16)); _privateBody!.AddChild(card);
        var box = Inner(card); box.AddThemeConstantOverride("separation", 12);
        box.AddChild(PrivateText((offer.Kind == OathAttachments.Kind ? "解除誓约 · " : "礼物 · ") + offer.State, 20, _gold));
        box.AddChild(PrivateSelectableText(offer.Detail, 17, _ink));
    }
    private void PrivateOathAttachment()
    {
        var attachment = new PrivateOffer { Kind = OathAttachments.Kind, Participants = [_privatePerson] };
        if (OathAttachments.Prepare(ViewData, _privatePerson, attachment) is { } error) { Notice(error, true); return; }
        AttachPrivate(attachment);
    }
    private void PrivateGiftPicker()
    {
        var d = ViewData;
        var goods = d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)
            .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))
            .Where(x => x.Good?.Collectible == true).ToArray();
        int selected = 0; ConsumerQuantity? quantity = null; CheckButton? relationship = null; Label? relationshipHint = null;
        ShowCareerDialog("赠送礼物", "接收者：" + GroupChats.Name(d, _privatePerson), () =>
        {
            if (goods.Length == 0) return true;
            if (!quantity!.Valid) { Notice("请输入有效的赠礼数量。", true); return false; }
            var item = goods[selected];
            var attachment = new PrivateOffer { Kind = "gift", GoodId = item.Good!.Id, Quantity = (int)quantity!.Value, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = _privatePerson, Participants = [_privatePerson] };
            if (ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message) { Notice(message, true); return false; }
            AttachPrivate(attachment); return true;
        }, "添加到消息", box =>
        {
            if (goods.Length == 0) { box.AddChild(PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted)); return; }
            var picker = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(520, 48) };
            foreach (var item in goods) picker.AddItem(item.Good!.Name + " · 持有 " + item.Quantity);
            box.AddChild(picker);
            quantity = new ConsumerQuantity { Minimum = 1, Maximum = (int)Math.Min(int.MaxValue, goods[0].Quantity) }; quantity.Initialize(1); box.AddChild(quantity);
            relationship = new CheckButton { Text = "附加确定恋人关系的请求", CustomMinimumSize = new(520, 44) }; box.AddChild(relationship);
            relationshipHint = Text("", 16, CareerVisuals.Teal); box.AddChild(relationshipHint);
            void RelationshipChoice()
            {
                bool special = RelationshipGifts.Special(goods[selected].Good!.Id);
                var relation = PrivateMessages.Relation(d, _privatePerson);
                relationship.Visible = !special && relation.Favour >= 60 && relation.SelectedBond is not >= 1 && !relation.OathConfirmed;
                relationshipHint.Text = special ? "好感达到85后可以赠送；对方接受后确定誓约关系。" : relationship.Visible ? "对方接受礼物后，确定恋人关系。" : "";
                relationshipHint.Visible = relationshipHint.Text.Length > 0;
            }
            picker.ItemSelected += index => { selected = (int)index; quantity.Maximum = (int)Math.Min(int.MaxValue, goods[selected].Quantity); quantity.SetValue(Math.Min(quantity.Value, quantity.Maximum)); RelationshipChoice(); };
            RelationshipChoice();
        });
    }

    private void PrivateActivityPicker() => PrivateActivityPicker("", "");
    private void PrivateActivityPicker(string goodId, string verbId)
    {
        var d = ViewData;
        var people = (_privateGroup.Length > 0 ? _groupSelection : new List<string> { _privatePerson }).ToArray();
        var activities = d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))
            .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))
            .Concat(WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)
                .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id))).ToArray();
        int chosen = -1; LineEdit? title = null; TextEdit? detail = null; SpinBox? season = null; int day = SeasonCalendar.Day(d, d.Day);
        ShowCareerDialog("约定活动", "接受后记入日程，赴约时选择公开或私密。", () =>
        {
            var attachment = new PrivateOffer { Kind = "activity", Title = title!.Text.Trim(), Detail = detail!.Text.Trim(), Season = (int)season!.Value, Day = day,
                Participants = new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList() };
            if (chosen >= 0) { attachment.GoodId = activities[chosen].Good.Id; attachment.GoodVerb = activities[chosen].Verb.Id; attachment.ServiceId = activities[chosen].ServiceId; }
            if (ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message) { Notice(message, true); return false; }
            AttachPrivate(attachment); return true;
        }, "添加到消息", box =>
        {
            var picker = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(560, 44) }; picker.AddItem("自行约定活动");
            foreach (var item in activities) picker.AddItem(item.Verb.Name + " · " + item.Good.Name);
            box.AddChild(picker);
            title = new LineEdit { PlaceholderText = "活动名称", SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(title);
            detail = new TextEdit { PlaceholderText = "活动内容", CustomMinimumSize = new(740, 80), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(detail);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);
            season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = d.Season, Prefix = "赛季 ", CustomMinimumSize = new(200, 44), UpdateOnTextChanged = true }; row.AddChild(season);
            var selected = Text($"{GameCalendar.Text(d, SeasonCalendar.Start(d) + day)}", 17, CareerVisuals.Teal); row.AddChild(selected);
            var scroll = new ScrollContainer { CustomMinimumSize = new(740, 230), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(calendar);
            void Calendar()
            {
                CareerVisuals.ClearContent(calendar);
                calendar.AddChild(AppointmentCalendar(d, (int)season.Value, people, day, value =>
                { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; }));
            }
            season.ValueChanged += value => { day = Math.Min(day, SeasonCalendar.Length(d, (int)value)); selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)}"; Calendar(); };
            box.AddThemeConstantOverride("separation", 12);
            Calendar();
            picker.ItemSelected += index => { chosen = (int)index - 1; if (chosen >= 0) { title.Text = activities[chosen].Verb.Name; detail.Text = "使用" + activities[chosen].Good.Name + "开展" + title.Text; } };
            int initial = Array.FindIndex(activities, a => a.Good.Id == goodId && a.Verb.Id == verbId);
            if (initial >= 0) { chosen = initial; picker.Select(initial + 1); title.Text = activities[initial].Verb.Name; detail.Text = "使用" + activities[initial].Good.Name + "开展" + title.Text; }
        });
    }
}
