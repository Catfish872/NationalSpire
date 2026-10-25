using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private sealed record ConsumerChoice(Good? Good, GoodVerb? Verb = null, string Service = "")
    {
        public string Caption => Verb?.Name ?? Good?.Name ?? "自行约定活动";
        public string Category => Good?.Category ?? "自行约定";
        public string Key => (Good?.Id ?? "custom") + "/" + Verb?.Id + "/" + Service;
    }
    private sealed class ConsumerEdit
    {
        public ConsumerChoice? Choice;
        public HashSet<string> People = [];
        public string Group = "", Title = "", Detail = "";
        public int Quantity = 1, Season, Day, Relationship;
    }
    private void ConsumerProducts(VBoxContainer box, ConsumerChoice[] choices, ConsumerEdit edit, Action changed)
    {
        string category = "全部", tier = "全部", query = ""; int page = 0;
        var ordered = choices.OrderByDescending(c => c.Good == null).ThenByDescending(c => c.Good is { } g ? ConsumerEngine.Price(g) : 0).ToArray();
        var search = new LineEdit { Name = "AttachmentProductSearch", PlaceholderText = "搜索商品或活动名称", CustomMinimumSize = new(0, 42) }; box.AddChild(search);
        var tabs = new HFlowContainer(); tabs.AddThemeConstantOverride("h_separation", 7); tabs.AddThemeConstantOverride("v_separation", 7); box.AddChild(tabs);
        var tiers = new HFlowContainer { Name = "AttachmentProductTiers" }; tiers.AddThemeConstantOverride("h_separation", 7); tiers.AddThemeConstantOverride("v_separation", 7); box.AddChild(tiers);
        var grid = new GridContainer { Name = "AttachmentProductGrid", Columns = 5, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 10); grid.AddThemeConstantOverride("v_separation", 10); box.AddChild(grid);
        var footer = new HBoxContainer(); footer.AddThemeConstantOverride("separation", 12); box.AddChild(footer);
        var previous = Button("←", () => { }, 48); previous.Name = "AttachmentProductsPrevious"; footer.AddChild(previous);
        var label = Text("", 15, _muted); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; footer.AddChild(label);
        var next = Button("→", () => { }, 48); next.Name = "AttachmentProductsNext"; footer.AddChild(next);
        previous.Pressed += () => { page--; Refresh(); }; next.Pressed += () => { page++; Refresh(); };
        void Refresh()
        {
            using var timing = UiPerformance.Measure(UiPerformance.Work.ConsumerProducts);
            var items = ordered.Where(c => category == "全部" || c.Category == category).Where(c => tier == "全部" || c.Good?.Tier == tier)
                .Where(c => c.Caption.Contains(query, StringComparison.OrdinalIgnoreCase) || c.Good?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true).ToArray();
            page = Math.Clamp(page, 0, Math.Max(0, (items.Length - 1) / 10)); CareerVisuals.ClearContent(grid);
            previous.Disabled = page == 0; next.Disabled = (page + 1) * 10 >= items.Length;
            label.Text = items.Length == 0 ? "暂无匹配商品" : $"第 {page + 1} / {Math.Max(1, (items.Length + 9) / 10)} 页 · 共 {items.Length} 项";
            foreach (var choice in items.Skip(page * 10).Take(10))
            {
                var card = new Button { Name = "AttachmentProduct_" + choice.Key.Replace("/", "_"), CustomMinimumSize = new(0, 138), SizeFlagsHorizontal = SizeFlags.ExpandFill, TooltipText = choice.Caption + (choice.Good == null ? "" : " · " + choice.Good.Name) };
                ConsumerVisuals.ProductStyle(card, false, edit.Choice?.Key == choice.Key); grid.AddChild(card);
                var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }; card.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 9);
                var content = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; content.AddThemeConstantOverride("separation", 4); margin.AddChild(content);
                if (choice.Good is { } good) content.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(0, 61), MouseFilter = MouseFilterEnum.Ignore });
                else content.AddChild(new TextureRect { Texture = LifestyleArt.Icon("活动与计划"), CustomMinimumSize = new(0, 61), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore });
                var name = Text(choice.Caption, 16, _ink); name.MouseFilter = MouseFilterEnum.Ignore; name.MaxLinesVisible = 2; content.AddChild(name);
                var detail = Text(choice.Good == null ? "填写自己的安排" : choice.Verb != null ? choice.Good.Name : "持有 " + ConsumerAttachments.Available(ViewData, choice.Good), 13, CareerVisuals.Teal); detail.MouseFilter = MouseFilterEnum.Ignore; content.AddChild(detail);
                card.Pressed += () => { edit.Choice = choice; changed(); Refresh(); };
            }
        }
        foreach (string value in new[] { "全部" }.Concat(choices.Select(c => c.Category).Distinct()))
        {
            var tab = FilterButton(value, value == category, () => { category = value; page = 0; foreach (var b in tabs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0);
            tab.ToggleMode = true; tab.SetPressedNoSignal(value == category); tab.CustomMinimumSize = new(0, 34); tab.AddThemeFontSizeOverride("font_size", 14); tabs.AddChild(tab);
        }
        foreach (string value in new[] { "全部" }.Concat(ConsumerCatalog.TierOrder.Where(t => choices.Any(c => c.Good?.Tier == t))))
        {
            var tab = FilterButton(value, value == tier, () => { tier = value; page = 0; foreach (var b in tiers.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == value); Refresh(); }, 0);
            tab.Name = "AttachmentTier_" + value; tab.ToggleMode = true; tab.SetPressedNoSignal(value == tier); tab.CustomMinimumSize = new(0, 34); tab.AddThemeFontSizeOverride("font_size", 14); tiers.AddChild(tab);
        }
        search.TextChanged += text => { query = text.Trim(); page = 0; Refresh(); }; Refresh();
    }
    private void ConsumerEditor(bool activity, ConsumerComposer? shop, PrivateOffer? previous = null, string goodId = "", string verbId = "", ConsumerEdit? retained = null)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.ConsumerEditor);
        var d = ViewData; bool shopping = shop != null;
        string person = shop?.Person ?? _privatePerson, group = shop?.Group ?? _privateGroup;
        var initialPeople = shop?.People ?? (group.Length > 0 ? _groupSelection : new List<string> { person });
        var choices = activity
            ? ConsumerCatalog.All.Where(g => shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0).SelectMany(g => g.Activities.Select(v => new ConsumerChoice(g, v)))
                .Concat(WeddingAppointments.Services(d).Where(s => !shopping && initialPeople.Count == 1 && initialPeople[0] == s.Person).Select(s => new ConsumerChoice(ConsumerCatalog.Get(s.GoodId), WeddingAppointments.Verb, s.Id))).ToArray()
            : ConsumerCatalog.All.Where(g => g.Giftable && (shopping ? g.Id == shop!.Good : ConsumerAttachments.Available(d, g) > 0)).Select(g => new ConsumerChoice(g)).ToArray();
        if (activity && !shopping) choices = new[] { new ConsumerChoice(null) }.Concat(choices).ToArray();
        var edit = retained ?? new ConsumerEdit { People = initialPeople.Where(id => id.Length > 0 && !GroupChats.IsHuman(d, id)).ToHashSet(), Group = group, Season = previous?.Season ?? d.Season, Day = previous?.Day ?? SeasonCalendar.Day(d, d.Day), Quantity = previous?.Quantity ?? 1, Relationship = previous?.RelationshipIntent ?? 0 };
        if (retained == null)
        {
            edit.Choice = choices.FirstOrDefault(c => c.Good?.Id == (previous?.GoodId ?? (shopping ? shop!.Good : goodId)) && (!activity || c.Verb?.Id == (previous?.GoodVerb ?? (shopping ? choices.FirstOrDefault()?.Verb?.Id : verbId)))) ?? choices.FirstOrDefault();
            edit.Title = previous?.Title ?? edit.Choice?.Verb?.Name ?? ""; edit.Detail = previous?.Detail ?? (edit.Choice?.Good is { } g && activity ? "使用" + g.Name + "开展" + edit.Title : "");
        }
        Label? error = null, selection = null, hint = null; ConsumerQuantity? quantity = null; CheckButton? relationship = null; LineEdit? title = null; TextEdit? detail = null; VBoxContainer? calendar = null; SpinBox? season = null; Label? date = null;
        void Error(string text) { error!.Text = text; error.Visible = text.Length > 0; }
        void Calendar()
        {
            if (!activity || calendar == null) return;
            CareerVisuals.ClearContent(calendar);
            calendar.AddChild(AppointmentCalendar(d, edit.Season, edit.People.ToArray(), edit.Day, value => { edit.Day = value; date!.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + value); }));
        }
        void Changed(bool product = false)
        {
            if (error != null) Error("");
            if (_dialogOverlay?.FindChild("CareerDialogConfirm", true, false) is Button confirm) confirm.Text = shopping || edit.Choice?.Good?.Instant == true ? "确认费用" : "添加到消息";
            selection!.Text = edit.Choice?.Caption ?? "暂无可用物品";
            if (quantity != null)
            {
                quantity.Maximum = shopping ? int.MaxValue : (int)Math.Min(int.MaxValue, edit.Choice?.Good is { } g ? ConsumerAttachments.Available(d, g) : 1);
                quantity.Maximum = Math.Max(1, quantity.Maximum); quantity.SetValue(Math.Min(edit.Quantity, quantity.Maximum)); edit.Quantity = quantity.Value;
            }
            if (activity && product)
            {
                edit.Title = edit.Choice?.Verb?.Name ?? ""; edit.Detail = edit.Choice?.Good is { } g ? "使用" + g.Name + "开展" + edit.Title : "";
                title!.Text = edit.Title; detail!.Text = edit.Detail;
            }
            if (relationship != null)
            {
                string id = edit.People.FirstOrDefault() ?? ""; var relation = id.Length > 0 ? PrivateMessages.Relation(d, id) : null; bool special = RelationshipGifts.Special(edit.Choice?.Good?.Id ?? "");
                relationship.Visible = id.Length > 0 && !special && relation!.Favour >= 60 && relation.SelectedBond is not >= 1 && !relation.OathConfirmed;
                hint!.Text = special ? "对方接收后，玩家可以在聊天的“+”号中选择“约定活动”，并选择其中的婚礼活动。从该入口完成婚礼即可正式缔结誓约。" : relationship.Visible ? "对方接受礼物后，确定恋人关系。" : ""; hint.Visible = hint.Text.Length > 0;
            }
        }
        void ReturnEditor() => ConsumerEditor(activity, shop, previous, goodId, verbId, edit);
        ShowCareerDialog(activity ? "约定活动" : "赠送礼物", "", () =>
        {
            if (edit.Choice == null) { Error("请选择物品或活动。"); return false; }
            if (edit.People.Count == 0) { Error(activity ? "请选择同行者。" : "请选择接收礼物的人。"); return false; }
            if (!activity && quantity?.Valid != true) { Error("请输入有效的赠礼数量。"); return false; }
            string target = edit.People.First();
            var attachment = new PrivateOffer { Kind = activity ? "activity" : "gift", Quantity = activity ? 1 : edit.Quantity, GoodId = edit.Choice.Good?.Id ?? "", GoodVerb = edit.Choice.Verb?.Id ?? "", ServiceId = edit.Choice.Service,
                Title = edit.Title.Trim(), Detail = edit.Detail.Trim(), Season = edit.Season, Day = edit.Day, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0,
                ActorId = target, Participants = activity ? new[] { GroupChats.Human(d) }.Concat(edit.People).ToList() : [target] };
            if (ChatAttachments.Prepare(d, target, attachment, shopping: shopping) is { } message) { Error(message); return false; }
            var composer = new ConsumerComposer(attachment.GoodId, target, edit.Group, edit.People.ToList());
            if (shopping || edit.Choice.Good?.Instant == true)
            {
                Callable.From(() => ConsumerAttachmentConfirmation(composer, attachment, ReturnEditor)).CallDeferred();
            }
            else AttachPrivate(attachment);
            return true;
        }, shopping || edit.Choice?.Good?.Instant == true ? "确认费用" : "添加到消息", box =>
        {
            float width = Math.Min(1120, _stage.Size.X - 100); box.CustomMinimumSize = new(width, 0); box.AddThemeConstantOverride("separation", 14);
            var scroll = new ScrollContainer { Name = "ConsumerEditorScroll", CustomMinimumSize = new(0, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 14); scroll.AddChild(body);
            void FitContent() { float height = Math.Clamp(body.GetCombinedMinimumSize().Y, 180, Math.Max(240, Math.Min(650, _stage.Size.Y - 230))); if (scroll.CustomMinimumSize.Y != height) scroll.CustomMinimumSize = new(0, height); }
            body.MinimumSizeChanged += FitContent; body.Resized += FitContent;
            selection = Text(edit.Choice?.Caption ?? "选择物品", 22, _gold); selection.Name = "ConsumerSelectedProduct"; body.AddChild(selection);
            if (!shopping) ConsumerProducts(body, choices, edit, () => Changed(true));
            var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 22); body.AddChild(columns);
            var settings = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; settings.AddThemeConstantOverride("separation", 12); columns.AddChild(settings);
            if (shopping && edit.Choice?.Good is { } good)
            {
                var product = new PanelContainer(); product.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "526f7a", 9, 14)); settings.AddChild(product);
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); product.AddChild(row);
                row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(90, 90) });
                var info = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(info); info.AddChild(Text(good.Category + " · " + good.Tier, 14, _muted)); info.AddChild(Text($"${ConsumerEngine.Price(good):N0}", 27, CareerVisuals.Teal)); info.AddChild(Text("现有 " + ConsumerAttachments.Available(d, good) + " 件 · 确认后补购所需数量", 14, _muted));
                if (activity && choices.Length > 1)
                {
                    var verbs = new HFlowContainer(); settings.AddChild(verbs);
                    foreach (var choice in choices) { var button = FilterButton(choice.Caption, edit.Choice == choice, () => { edit.Choice = choice; Changed(true); foreach (var b in verbs.GetChildren().OfType<Button>()) b.SetPressedNoSignal(b.Text == choice.Caption); }, 0); button.ToggleMode = true; button.SetPressedNoSignal(edit.Choice == choice); verbs.AddChild(button); }
                }
            }
            if (!activity)
            {
                settings.AddChild(Text("赠礼数量", 15, _muted)); quantity = new ConsumerQuantity { Name = "GiftQuantity", Minimum = 1, Maximum = int.MaxValue }; quantity.Initialize(edit.Quantity); settings.AddChild(quantity); quantity.Changed += () => edit.Quantity = quantity.Value;
                relationship = new CheckButton { Text = "附加确定恋人关系的请求", ButtonPressed = edit.Relationship == 1 }; settings.AddChild(relationship); relationship.Toggled += value => edit.Relationship = value ? 1 : 0;
                hint = Text("", 15, CareerVisuals.Teal); settings.AddChild(hint);
            }
            else
            {
                title = new LineEdit { Name = "ActivityTitle", Text = edit.Title, PlaceholderText = "活动名称", CustomMinimumSize = new(0, 42) }; title.TextChanged += value => edit.Title = value; settings.AddChild(title);
                detail = new TextEdit { Name = "ActivityDetail", Text = edit.Detail, PlaceholderText = "补充活动内容", CustomMinimumSize = new(0, 72), WrapMode = TextEdit.LineWrappingMode.Boundary }; detail.TextChanged += () => edit.Detail = detail.Text; settings.AddChild(detail);
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); settings.AddChild(row);
                season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = edit.Season, Prefix = "赛季 ", CustomMinimumSize = new(150, 40), UpdateOnTextChanged = true }; row.AddChild(season);
                date = Text(GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day), 16, CareerVisuals.Teal); row.AddChild(date);
                var dates = new ScrollContainer { CustomMinimumSize = new(0, 210), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; settings.AddChild(dates);
                calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; dates.AddChild(calendar);
                season.ValueChanged += value => { edit.Season = (int)value; edit.Day = Math.Min(edit.Day, SeasonCalendar.Length(d, edit.Season)); date.Text = GameCalendar.Text(d, SeasonCalendar.Start(d, edit.Season) + edit.Day); Calendar(); }; Calendar();
            }
            if (shopping)
            {
                var recipients = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; recipients.AddThemeConstantOverride("separation", 10); columns.AddChild(recipients);
                ConsumerRecipients(recipients, edit, activity, () => { Changed(); Calendar(); });
            }
            else settings.AddChild(Text((activity ? "同行者 · " : "接收者 · ") + string.Join("、", edit.People.Select(id => GroupChats.Name(d, id))), 16, CareerVisuals.Teal));
            error = Text("", 16, new("efb3aa")); error.Name = "ConsumerEditorError"; error.Hide(); box.AddChild(error); Changed();
        }, returnOutsideChat: true);
    }
    private void ConsumerRecipients(VBoxContainer parent, ConsumerEdit edit, bool activity, Action changed)
    {
        var d = ViewData; var tabs = new HBoxContainer(); parent.AddChild(tabs);
        var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 10); parent.AddChild(content);
        void Show(bool groups)
        {
            CareerVisuals.ClearContent(content);
            if (!groups) PeoplePicker(content, d.People.Where(p => PrivateMessages.CanChat(d, p.Id)).ToArray(), edit.People, true, changed);
            else
            {
                var search = new LineEdit { Name = "RecipientGroupSearch", PlaceholderText = "搜索群聊", CustomMinimumSize = new(0, 40) }; content.AddChild(search);
                var scroll = new ScrollContainer { CustomMinimumSize = new(0, 98), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; content.AddChild(scroll);
                var groupList = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(groupList);
                var members = new VBoxContainer(); members.AddThemeConstantOverride("separation", 8); content.AddChild(members);
                void Members()
                {
                    CareerVisuals.ClearContent(members);
                    if (GroupChats.Visible(d).FirstOrDefault(g => g.Id == edit.Group) is not { } group) return;
                    members.AddChild(Text(group.Name + (activity ? " · 选择同行成员" : " · 选择一位接收者"), 16, _gold));
                    PeoplePicker(members, d.People.Where(p => group.Members.Contains(p.Id) && PrivateMessages.CanChat(d, p.Id)).ToArray(), edit.People, !activity, changed, 164);
                }
                void Groups()
                {
                    CareerVisuals.ClearContent(groupList);
                    foreach (var group in GroupChats.Visible(d).Where(g => g.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                    {
                        var button = FilterButton(group.Name + " · " + group.Members.Count + "人", group.Id == edit.Group, () => { edit.Group = group.Id; edit.People.Clear(); Groups(); Members(); changed(); }, 0);
                        button.Name = "RecipientGroup_" + group.Id; groupList.AddChild(button);
                    }
                }
                search.TextChanged += _ => Groups(); Groups(); Members();
            }
            foreach (var button in tabs.GetChildren().OfType<Button>()) button.SetPressedNoSignal(button.Name == (groups ? "RecipientGroups" : "RecipientDirect"));
        }
        var direct = FilterButton("私聊", edit.Group.Length == 0, () => { edit.Group = ""; edit.People.Clear(); Show(false); changed(); }, 0); direct.Name = "RecipientDirect"; direct.ToggleMode = true; tabs.AddChild(direct);
        var groupsTab = FilterButton("群聊", edit.Group.Length > 0, () => { edit.Group = ""; edit.People.Clear(); Show(true); changed(); }, 0); groupsTab.Name = "RecipientGroups"; groupsTab.ToggleMode = true; tabs.AddChild(groupsTab);
        Show(edit.Group.Length > 0);
    }
}
