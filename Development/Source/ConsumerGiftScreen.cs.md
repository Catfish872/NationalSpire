# ConsumerGiftScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`510150137B69F9633E29FBDBA2046839576228DE94106CA7D3A13E798BD4DDAD`。来源：[源码](../../ConsumerGiftScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-55244dcd20ef"></a>

## `NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool) — private void GiftRecipientPicker(CareerData data, Good good, int quantity, bool wedding = false, string? inviteVerb = null, int inviteSlots = 0, bool buyInvitation = false)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int)`](ConsumerScreen.cs.md#symbol-244128db5d80)

**调用：** [`Accepted()`](ConsumerGiftScreen.cs.md#symbol-c14691dc9de1)；[`AcceptedInvite()`](ConsumerGiftScreen.cs.md#symbol-c0c726f6b729)；[`Counter()`](ConsumerGiftScreen.cs.md#symbol-7049f492eb6b)；[`Filter()`](ConsumerGiftScreen.cs.md#symbol-d8f83c070522)；`Godot.CheckBox.CheckBox()`；`Godot.Color.Color(string)`；`Godot.Control.Control()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemText(int)`；`Godot.OptionButton.OptionButton()`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.CommunitySharing.Recipients(NationalSpire.CareerData, string)`](CommunitySharing.cs.md#symbol-8baa01608a2d)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.ConsumerEngine.InviteCandidates(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-bc4d833f665b)；[`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-da833f356cc6)；[`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)；[`NationalSpire.ConsumerGifts.Recipients(NationalSpire.CareerData, string)`](ConsumerGifts.cs.md#symbol-83e1975639f6)；[`NationalSpire.ConsumerGifts.Wedding(NationalSpire.CareerData, string)`](ConsumerGifts.cs.md#symbol-905fa376a7e7)；[`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-71fa8e1feaa2)；[`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerInvitations.cs.md#symbol-cc2d01b16094)；`NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int, bool)`；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；`NationalSpire.GiftAllocation.GiftAllocation(string, int)`；`NationalSpire.GiftPurchase.GiftPurchase(string, int, System.Collections.Generic.List<NationalSpire.GiftAllocation>, bool)`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`Rows()`](ConsumerGiftScreen.cs.md#symbol-136ca1d3e38e)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.List()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `Accepted()`；`AcceptedInvite()`；`Counter()`；`Filter()`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CareerResult.OpponentParticipants`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunitySharing.Recipients(NationalSpire.CareerData, string)`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.ConsumerEngine.InviteCandidates(NationalSpire.CareerData)`；`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`；`NationalSpire.ConsumerGifts.Recipients(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerGifts.Wedding(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitationStock.ActiveMessage`；`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.GiftAllocation.Person`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.RingReceived`；`Rows()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Accepted()`；输入表达式：`Accepted()`；返回值紧邻使用处：`ExpressionStatementSyntax: Accepted();`
- `AcceptedInvite()`；输入表达式：`AcceptedInvite()`；返回值紧邻使用处：`ExpressionStatementSyntax: AcceptedInvite();`
- `Counter()`；输入表达式：`Counter()`；返回值紧邻使用处：`ExpressionStatementSyntax: Counter();`
- `Filter()`；输入表达式：`Filter()`；返回值紧邻使用处：`ExpressionStatementSyntax: Filter();`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DirectGift", Text = "直接赠送礼物", ButtonPressed = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DirectGift", Text = "直接赠送礼物", ButtonPressed = true }`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "GiftPersonSearch", PlaceholderText = "搜索名称", CustomMinimumSize = new(600, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "GiftPersonSearch", PlaceholderText = "搜索名称", CustomMinimumSize = new(600, 44) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(count)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(count);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(dropdown)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(dropdown);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(immediately)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(immediately);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`dropdown.AddItem(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: dropdown.AddItem(item);`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`dropdown.GetItemText((int)n)`；返回值紧邻使用处：`AssignmentExpressionSyntax: filter = dropdown.GetItemText((int)n)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "GiftPersonFilter", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "GiftPersonFilter", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`scroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scroll.GetVScrollBar().ValueChanged`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "GiftPeopleScroll", CustomMinimumSize = new(600, 330), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { Name = "GiftPeopleScroll", CustomMinimumSize = new(600, 330), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 330)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 330)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 44)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("consumer-invite", good.Id, JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)), accepted: AcceptedInvite)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("consumer-invite", good.Id, JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)), accepted: AcceptedInvite)) return true;`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand(kind, wedding ? person : good.Id, JsonSerializer.Serialize(order), accepted: Accepted)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand(kind, wedding ? person : good.Id, JsonSerializer.Serialize(order), accepted: Accepted)) return true;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(ConsumerInvitationStock.ActiveMessage, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(ConsumerInvitationStock.ActiveMessage, true);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 16, Colors.White)`；返回值紧邻使用处：`AssignmentExpressionSyntax: count = PrivateLine("", 16, Colors.White)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog(guests ? good.Name + " · 邀约" : "赠送 " + good.Name, invitation ? $"好感达到5的角色可参与，最多邀请{inviteSlots}人。" : "", () => { if (selected.Count == 0 || selected.Values.Sum(v => (long)v) > capacity || invalid.Count > 0) return false; if (invitation) { var people = selected.Keys.ToList(); void AcceptedInvite() { _multiplayer?.Refresh(); Callable.From(() => { Render(); OpenPrivateMessages(people[0]); }).CallDeferred(); } if (MultiplayerCommand("consumer-invite", good.Id, JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)), accepted: AcceptedInvite)) return true; string? inviteFailure = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation)); if (inviteFailure != null) { error!.Text = inviteFailure; return false; } AcceptedInvite(); return true; } var targets = selected.Select(p => new GiftAllocation(p.Key, p.Value)).ToList(); var order = new GiftPurchase(good.Id, quantity, targets, direct); string kind = wedding ? "consumer-wedding" : "consumer-gift"; string person = targets[0].Person; void Accepted() { _multiplayer?.Refresh(); Callable.From(() => { Render(); OpenPrivateMessages(person); if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"; }).CallDeferred(); if (_multiplayer == null && !wedding && direct) foreach (var target in targets) _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target.Person); } if (MultiplayerCommand(kind, wedding ? person : good.Id, JsonSerializer.Serialize(order), accepted: Accepted)) return true; string? failure = EconomicActions.Save(data, value => wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order)); if (failure != null) { error!.Text = failure; return false; } Accepted(); return true; }, "确定", box => { var search = new LineEdit { Name = "GiftPersonSearch", PlaceholderText = "搜索名称", CustomMinimumSize = new(600, 44) }; box.AddChild(search); var dropdown = new OptionButton { Name = "GiftPersonFilter", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }; foreach (string item in new[] { "按最近聊天", "按好感度", "熟悉的人", "同俱乐部", "近期对手", "近期发帖回帖者", "全部" }) dropdown.AddItem(item); box.AddChild(dropdown); var scroll = new ScrollContainer { Name = "GiftPeopleScroll", CustomMinimumSize = new(600, 330), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(list); var rows = new List<(HBoxContainer Row, Button Name, ConsumerQuantity Quantity)>(); CareerPerson[] people = []; const int rowHeight = 68; void Rows() { int first = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1)); int visible = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight) + 1); while (rows.Count < visible) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); list.AddChild(row); var amount = new ConsumerQuantity { Minimum = 0, Maximum = guests ? 1 : int.MaxValue }; amount.Initialize(0); amount.Visible = !guests; row.AddChild(amount); var choice = PrivateButton("", () => { }, 0); choice.ToggleMode = true; choice.SizeFlagsHorizontal = SizeFlags.ExpandFill; choice.CustomMinimumSize = new(0, 48); choice.Alignment = HorizontalAlignment.Left; foreach (string state in new[] { "pressed", "hover_pressed" }) { var style = CareerVisuals.Box("304f60", "70d4bc", 8, 10); style.BorderWidthLeft = style.BorderWidthRight = style.BorderWidthTop = style.BorderWidthBottom = 2; choice.AddThemeStyleboxOverride(state, style); } choice.AddThemeStyleboxOverride("focus", new StyleBoxEmpty()); choice.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; row.AddChild(choice); void Update(bool active) { string id = choice.GetMeta("person", "").AsString(); if (id.Length == 0) return; if (wedding) selected.Clear(); if (active) selected[id] = amount.Value; else { selected.Remove(id); inputTexts.Remove(id); amount.SetValue(0); } if (!active || amount.Valid) invalid.Remove(id); else invalid.Add(id); choice.SetPressedNoSignal(active); if (wedding) foreach (var r in rows) r.Name.SetPressedNoSignal(selected.ContainsKey(r.Name.GetMeta("person", "").AsString())); Counter(); } choice.Toggled += active => { amount.SetValue(active ? 1 : 0); inputTexts.Remove(choice.GetMeta("person", "").AsString()); Update(active); }; amount.Changed += () => { inputTexts[choice.GetMeta("person", "").AsString()] = amount.InputText; Update(!amount.Valid || amount.Value > 0); }; rows.Add((row, choice, amount)); } for (int i = 0; i < rows.Count; i++) { var (row, choice, amount) = rows[i]; row.Visible = i < visible; if (i >= visible) continue; var person = people[first + i]; if (choice.GetMeta("person", "").AsString() != person.Id) { foreach (var avatar in row.GetChildren().OfType<CareerAvatar>().ToArray()) { row.RemoveChild(avatar); avatar.QueueFree(); } var art = Avatar(data, person.Id, 36, false); row.AddChild(art); row.MoveChild(art, 0); choice.SetMeta("person", person.Id); choice.Text = person.PublicName + " · " + person.Role; choice.TooltipText = choice.Text; amount.SetValue(selected.GetValueOrDefault(person.Id)); if (inputTexts.TryGetValue(person.Id, out string? raw)) amount.RestoreText(raw); PickerRing(row, data, person.Id); } choice.SetPressedNoSignal(selected.ContainsKey(person.Id)); row.Position = new(0, (first + i) * rowHeight); row.Size = new(list.Size.X, rowHeight - 8); } } void Filter() { var matches = candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => data.Esports.ClubId.Length > 0 && p.ClubId == data.Esports.ClubId, "近期对手" => opponents.Contains(p.Id), "近期发帖回帖者" => authors.Contains(p.Id), "按好感度" => PrivateMessages.Favour(data, p.Id) > 0, _ => true }); people = (filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id)) : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)).ToArray(); list.CustomMinimumSize = new(0, people.Length * rowHeight); scroll.ScrollVertical = 0; Rows(); } count = PrivateLine("", 16, Colors.White); count.Name = "GiftAllocationCount"; box.AddChild(count); if (!guests) { var immediately = new CheckBox { Name = "DirectGift", Text = "直接赠送礼物", ButtonPressed = true }; immediately.Toggled += value => direct = value; box.AddChild(immediately); } else if (wedding) box.AddChild(Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted)); error = Text(candidates.Length == 0 ? wedding ? "尚无收到誓约之戒的对象。" : "暂无符合赠送条件的对象。" : "", 15, new Color("ee929d")); box.AddChild(error); search.TextChanged += value => { query = value.Trim(); Filter(); }; dropdown.ItemSelected += n => { filter = dropdown.GetItemText((int)n); Filter(); }; scroll.GetVScrollBar().ValueChanged += _ => Rows(); scroll.Resized += Rows; list.Resized += Rows; Filter(); Counter(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(guests ? good.Name + " · 邀约" : "赠送 " + good.Name, invitation ? $"好感达到5的角色可参与，最多邀请{inviteSlots}人。" : "", () => { if (selected.Count == 0 || selected.Values.Sum(v => (long)v) > capacity || invalid.Count > 0) return false; if (invitation) { var people = selected.Keys.ToList(); void AcceptedInvite() { _multiplayer?.Refresh(); Callable.From(() => { Render(); OpenPrivateMessages(people[0]); }).CallDeferred(); } if (MultiplayerCommand("consumer-invite", good.Id, JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)), accepted: AcceptedInvite)) return true; string? inviteFailure = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation)); if (inviteFailure != null) { error!.Text = inviteFailure; return false; } AcceptedInvite(); return true; } var targets = selected.Select(p => new GiftAllocation(p.Key, p.Value)).ToList(); var order = new GiftPurchase(good.Id, quantity, targets, direct); string kind = wedding ? "consumer-wedding" : "consumer-gift"; string person = targets[0].Person; void Accepted() { _multiplayer?.Refresh(); Callable.From(() => { Render(); OpenPrivateMessages(person); if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"; }).CallDeferred(); if (_multiplayer == null && !wedding && direct) foreach (var target in targets) _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target.Person); } if (MultiplayerCommand(kind, wedding ? person : good.Id, JsonSerializer.Serialize(order), accepted: Accepted)) return true; string? failure = EconomicActions.Save(data, value => wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order)); if (failure != null) { error!.Text = failure; return false; } Accepted(); return true; }, "确定", box => { var search = new LineEdit { Name = "GiftPersonSearch", PlaceholderText = "搜索名称", CustomMinimumSize = new(600, 44) }; box.AddChild(search); var dropdown = new OptionButton { Name = "GiftPersonFilter", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }; foreach (string item in new[] { "按最近聊天", "按好感度", "熟悉的人", "同俱乐部", "近期对手", "近期发帖回帖者", "全部" }) dropdown.AddItem(item); box.AddChild(dropdown); var scroll = new ScrollContainer { Name = "GiftPeopleScroll", CustomMinimumSize = new(600, 330), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(list); var rows = new List<(HBoxContainer Row, Button Name, ConsumerQuantity Quantity)>(); CareerPerson[] people = []; const int rowHeight = 68; void Rows() { int first = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1)); int visible = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight) + 1); while (rows.Count < visible) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); list.AddChild(row); var amount = new ConsumerQuantity { Minimum = 0, Maximum = guests ? 1 : int.MaxValue }; amount.Initialize(0); amount.Visible = !guests; row.AddChild(amount); var choice = PrivateButton("", () => { }, 0); choice.ToggleMode = true; choice.SizeFlagsHorizontal = SizeFlags.ExpandFill; choice.CustomMinimumSize = new(0, 48); choice.Alignment = HorizontalAlignment.Left; foreach (string state in new[] { "pressed", "hover_pressed" }) { var style = CareerVisuals.Box("304f60", "70d4bc", 8, 10); style.BorderWidthLeft = style.BorderWidthRight = style.BorderWidthTop = style.BorderWidthBottom = 2; choice.AddThemeStyleboxOverride(state, style); } choice.AddThemeStyleboxOverride("focus", new StyleBoxEmpty()); choice.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; row.AddChild(choice); void Update(bool active) { string id = choice.GetMeta("person", "").AsString(); if (id.Length == 0) return; if (wedding) selected.Clear(); if (active) selected[id] = amount.Value; else { selected.Remove(id); inputTexts.Remove(id); amount.SetValue(0); } if (!active || amount.Valid) invalid.Remove(id); else invalid.Add(id); choice.SetPressedNoSignal(active); if (wedding) foreach (var r in rows) r.Name.SetPressedNoSignal(selected.ContainsKey(r.Name.GetMeta("person", "").AsString())); Counter(); } choice.Toggled += active => { amount.SetValue(active ? 1 : 0); inputTexts.Remove(choice.GetMeta("person", "").AsString()); Update(active); }; amount.Changed += () => { inputTexts[choice.GetMeta("person", "").AsString()] = amount.InputText; Update(!amount.Valid || amount.Value > 0); }; rows.Add((row, choice, amount)); } for (int i = 0; i < rows.Count; i++) { var (row, choice, amount) = rows[i]; row.Visible = i < visible; if (i >= visible) continue; var person = people[first + i]; if (choice.GetMeta("person", "").AsString() != person.Id) { foreach (var avatar in row.GetChildren().OfType<CareerAvatar>().ToArray()) { row.RemoveChild(avatar); avatar.QueueFree(); } var art = Avatar(data, person.Id, 36, false); row.AddChild(art); row.MoveChild(art, 0); choice.SetMeta("person", person.Id); choice.Text = person.PublicName + " · " + person.Role; choice.TooltipText = choice.Text; amount.SetValue(selected.GetValueOrDefault(person.Id)); if (inputTexts.TryGetValue(person.Id, out string? raw)) amount.RestoreText(raw); PickerRing(row, data, person.Id); } choice.SetPressedNoSignal(selected.ContainsKey(person.Id)); row.Position = new(0, (first + i) * rowHeight); row.Size = new(list.Size.X, rowHeight - 8); } } void Filter() { var matches = candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => data.Esports.ClubId.Length > 0 && p.ClubId == data.Esports.ClubId, "近期对手" => opponents.Contains(p.Id), "近期发帖回帖者" => authors.Contains(p.Id), "按好感度" => PrivateMessages.Favour(data, p.Id) > 0, _ => true }); people = (filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id)) : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)).ToArray(); list.CustomMinimumSize = new(0, people.Length * rowHeight); scroll.ScrollVertical = 0; Rows(); } count = PrivateLine("", 16, Colors.White); count.Name = "GiftAllocationCount"; box.AddChild(count); if (!guests) { var immediately = new CheckBox { Name = "DirectGift", Text = "直接赠送礼物", ButtonPressed = true }; immediately.Toggled += value => direct = value; box.AddChild(immediately); } else if (wedding) box.AddChild(Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted)); error = Text(candidates.Length == 0 ? wedding ? "尚无收到誓约之戒的对象。" : "暂无符合赠送条件的对象。" : "", 15, new Color("ee929d")); box.AddChild(error); search.TextChanged += value => { query = value.Trim(); Filter(); }; dropdown.ItemSelected += n => { filter = dropdown.GetItemText((int)n); Filter(); }; scroll.GetVScrollBar().ValueChanged += _ => Rows(); scroll.Resized += Rows; list.Resized += Rows; Filter(); Counter(); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("邀约会附在私聊中，发送后与对方商谈婚礼。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(candidates.Length == 0 ? wedding ? "尚无收到誓约之戒的对象。" : "暂无符合赠送条件的对象。" : "", 15, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text(candidates.Length == 0 ? wedding ? "尚无收到誓约之戒的对象。" : "暂无符合赠送条件的对象。" : "", 15, new Color("ee929d"))`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm") is Button button`
- `NationalSpire.CommunitySharing.Recipients(NationalSpire.CareerData, string)`；输入表达式：`CommunitySharing.Recipients(data, "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunitySharing.Recipients(data, "").Select`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending`
- `NationalSpire.ConsumerEngine.InviteCandidates(NationalSpire.CareerData)`；输入表达式：`ConsumerEngine.InviteCandidates(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ConsumerEngine.InviteCandidates(data).Where`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`ConsumerGifts.Available(data, good.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: (long)quantity + ConsumerGifts.Available(data, good.Id)`
- `NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`；输入表达式：`ConsumerGifts.Purchase(value, order)`；返回值紧邻使用处：`ConditionalExpressionSyntax: wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order)`
- `NationalSpire.ConsumerGifts.Recipients(NationalSpire.CareerData, string)`；输入表达式：`ConsumerGifts.Recipients(data, good.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: guests ? ConsumerEngine.InviteCandidates(data).Where(p => !wedding || PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived == true) : ConsumerGifts.Recipients(data, good.Id)`
- `NationalSpire.ConsumerGifts.Wedding(NationalSpire.CareerData, string)`；输入表达式：`ConsumerGifts.Wedding(value, person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order)`
- `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；输入表达式：`ConsumerInvitationStock.Active(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: guests && ConsumerInvitationStock.Active(data)`
- `NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；输入表达式：`ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation)`
- `NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int, bool)`；输入表达式：`new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)`；返回值紧邻使用处：`ArgumentSyntax: new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation)`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(data, d => ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, good.Id, inviteVerb!, people, buyInvitation))`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(data, value => wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(data, value => wedding ? ConsumerGifts.Wedding(value, person) : ConsumerGifts.Purchase(value, order))`
- `NationalSpire.GiftAllocation.GiftAllocation(string, int)`；输入表达式：`new GiftAllocation(p.Key, p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new GiftAllocation(p.Key, p.Value)`
- `NationalSpire.GiftPurchase.GiftPurchase(string, int, System.Collections.Generic.List<NationalSpire.GiftAllocation>, bool)`；输入表达式：`new GiftPurchase(good.Id, quantity, targets, direct)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GiftPurchase(good.Id, quantity, targets, direct)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `Rows()`；输入表达式：`Rows()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Rows()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>()`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`r.OpponentParticipants.Append(r.OpponentId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => r.OpponentParticipants.Append(r.OpponentId)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`data.Results.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`data.Results.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.AsEnumerable().Reverse().SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.Select(r => r.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Select(r => r.AuthorId).Prepend`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selected.Select(p => new GiftAllocation(p.Key, p.Value))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selected.Select(p => new GiftAllocation(p.Key, p.Value)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`CommunitySharing.Recipients(data, "").Select((p, index) => (p.Id, index))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunitySharing.Recipients(data, "").Select((p, index) => (p.Id, index)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30).SelectMany(p => p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30).SelectMany(p => p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`selected.Values.Sum(v => (long)v)`；返回值紧邻使用处：`BinaryExpressionSyntax: selected.Values.Sum(v => (long)v) > capacity`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(guests ? ConsumerEngine.InviteCandidates(data).Where(p => !wedding || PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived == true) : ConsumerGifts.Recipients(data, good.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (guests ? ConsumerEngine.InviteCandidates(data).Where(p => !wedding || PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived == true) : ConsumerGifts.Recipients(data, good.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`CommunitySharing.Recipients(data, "").Select((p, index) => (p.Id, index)).ToDictionary(p => p.Id, p => p.index)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunitySharing.Recipients(data, "").Select((p, index) => (p.Id, index)).ToDictionary(p => p.Id, p => p.index)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30).SelectMany(p => p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(30).SelectMany(p => p.Replies.Select(r => r.AuthorId).Prepend(p.AuthorId)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Keys.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.Keys.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`data.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`selected.Keys.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selected.Keys.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`selected.Select(p => new GiftAllocation(p.Key, p.Value)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selected.Select(p => new GiftAllocation(p.Key, p.Value)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ConsumerEngine.InviteCandidates(data).Where(p => !wedding || PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived == true)`；返回值紧邻使用处：`ConditionalExpressionSyntax: guests ? ConsumerEngine.InviteCandidates(data).Where(p => !wedding || PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived == true) : ConsumerGifts.Recipients(data, good.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(p.Id)?.RingReceived`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(HBoxContainer Row, Button Name, ConsumerQuantity Quantity)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(HBoxContainer Row, Button Name, ConsumerQuantity Quantity)>()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation))`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new ConsumerOrder(inviteVerb!, people, BuyInvitation: buyInvitation))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(order)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(order)`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: query = value.Trim()`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `true`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(600, 330)`
- `CustomMinimumSize` = `new(600, 44)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"DirectGift"`
- `Name` = `"GiftPeopleScroll"`
- `Name` = `"GiftPersonFilter"`
- `Name` = `"GiftPersonSearch"`
- `PlaceholderText` = `"搜索名称"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `"直接赠送礼物"`
- `confirm` = `button`
- `count.Name` = `"GiftAllocationCount"`
- `count` = `PrivateLine("", 16, Colors.White)`
- `direct` = `value`
- `dropdown.ItemSelected` += `n => { filter = dropdown.GetItemText((int)n); Filter(); }`
- `error!.Text` = `failure`
- `error!.Text` = `inviteFailure`
- `error` = `Text(candidates.Length == 0 ? wedding ? "尚无收到誓约之戒的对象。" : "暂无符合赠送条件的对象。" : "", 15, new Color("ee929d"))`
- `filter` = `dropdown.GetItemText((int)n)`
- `immediately.Toggled` += `value => direct = value`
- `list.Resized` += `Rows`
- `query` = `value.Trim()`
- `scroll.GetVScrollBar().ValueChanged` += `_ => Rows()`
- `scroll.Resized` += `Rows`
- `search.TextChanged` += `value => { query = value.Trim(); Filter(); }`

<a id="symbol-7049f492eb6b"></a>

## `Counter() — void Counter()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`Update(bool)`](ConsumerGiftScreen.cs.md#symbol-73796f12bafd)

**调用：** `Godot.Color.Color(string)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.Good.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f394a4")`；返回值紧邻使用处：`ConditionalExpressionSyntax: over || invalid.Count > 0 ? new Color("f394a4") : CareerVisuals.Teal`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`selected.Values.Sum(v => (long)v)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selected.Values.Sum(v => (long)v)`

**赋值（含属性/字段和局部值）：**

- `confirm.Disabled` = `total <= 0 || over || invalid.Count > 0`
- `count.Modulate` = `over || invalid.Count > 0 ? new Color("f394a4") : CareerVisuals.Teal`
- `count.Text` = `(guests ? $"已选择 {selected.Count}/{capacity} 人" : $"赠送 {good.Name} {total}/{capacity}个") + (over ? guests ? "：超过邀约人数" : "：购买数量与可用库存不足" : invalid.Count > 0 ? "：请输入有效数量" : "")`

<a id="symbol-c0c726f6b729"></a>

## `AcceptedInvite() — void AcceptedInvite()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.ICareerSession.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { Render(); OpenPrivateMessages(people[0]); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { Render(); OpenPrivateMessages(people[0]); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { Render(); OpenPrivateMessages(people[0]); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { Render(); OpenPrivateMessages(people[0]); }).CallDeferred`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(people[0])`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(people[0]);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c14691dc9de1"></a>

## `Accepted() — void Accepted()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.GiftAllocation.Person`；`NationalSpire.ICareerSession.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { Render(); OpenPrivateMessages(person); if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"; }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { Render(); OpenPrivateMessages(person); if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"; }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { Render(); OpenPrivateMessages(person); if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"; })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { Render(); OpenPrivateMessages(person); if (!wedding && !direct && targets.Count > 1) _privateStatus!.Text = $"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"; }).CallDeferred`
- `NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`；输入表达式：`AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target.Person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target.Person)`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(person);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerStore.IsCurrent(data) ? data : null`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target.Person)`
- `_privateStatus!.Text` = `$"已为{targets.Count}位收礼人准备礼物附件，可切换私聊分别留言。"`

<a id="symbol-136ca1d3e38e"></a>

## `Rows() — void Rows()`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Filter()`](ConsumerGiftScreen.cs.md#symbol-d8f83c070522)；[`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Variant.AsString()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`](ConsumerGiftControls.cs.md#symbol-e35b8d3e088f)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ConsumerQuantity.ConsumerQuantity()`](ConsumerGiftControls.cs.md#symbol-0eddfdec0f89)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；[`NationalSpire.ConsumerQuantity.RestoreText(string)`](ConsumerGiftControls.cs.md#symbol-7a371acfafe4)；[`NationalSpire.ConsumerQuantity.SetValue(int)`](ConsumerGiftControls.cs.md#symbol-e2e90c4c8401)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Ceiling(double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`；[`Update(bool)`](ConsumerGiftScreen.cs.md#symbol-73796f12bafd)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.Initialize(int)`；`NationalSpire.ConsumerQuantity.InputText`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.RestoreText(string)`；`NationalSpire.ConsumerQuantity.SetValue(int)`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`；`Update(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`choice.SetPressedNoSignal(selected.ContainsKey(person.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.SetPressedNoSignal(selected.ContainsKey(person.Id));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`choice.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`choice.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddThemeStyleboxOverride(state, style);`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`choice.GetMeta("person", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choice.GetMeta("person", "").AsString`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`choice.SetMeta("person", person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.SetMeta("person", person.Id);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(amount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(art)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(art);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(choice);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`row.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<CareerAvatar>`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`row.MoveChild(art, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.MoveChild(art, 0);`
- `Godot.Node.QueueFree()`；输入表达式：`avatar.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: avatar.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`row.RemoveChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.RemoveChild(avatar);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Variant.AsString()`；输入表达式：`choice.GetMeta("person", "").AsString()`；返回值紧邻使用处：`ArgumentSyntax: choice.GetMeta("person", "").AsString()`
- `Godot.Variant.AsString()`；输入表达式：`choice.GetMeta("person", "").AsString()`；返回值紧邻使用处：`BinaryExpressionSyntax: choice.GetMeta("person", "").AsString() != person.Id`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, (first + i) * rowHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Position = new(0, (first + i) * rowHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: choice.CustomMinimumSize = new(0, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(list.Size.X, rowHeight - 8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Size = new(list.Size.X, rowHeight - 8)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, person.Id, 36, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Avatar(data, person.Id, 36, false)`
- `NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`；输入表达式：`PickerRing(row, data, person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PickerRing(row, data, person.Id);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => { }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => { }, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("304f60", "70d4bc", 8, 10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("304f60", "70d4bc", 8, 10)`
- `NationalSpire.ConsumerQuantity.ConsumerQuantity()`；输入表达式：`new ConsumerQuantity { Minimum = 0, Maximum = guests ? 1 : int.MaxValue }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConsumerQuantity { Minimum = 0, Maximum = guests ? 1 : int.MaxValue }`
- `NationalSpire.ConsumerQuantity.Initialize(int)`；输入表达式：`amount.Initialize(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: amount.Initialize(0);`
- `NationalSpire.ConsumerQuantity.RestoreText(string)`；输入表达式：`amount.RestoreText(raw)`；返回值紧邻使用处：`ExpressionStatementSyntax: amount.RestoreText(raw);`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`amount.SetValue(active ? 1 : 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: amount.SetValue(active ? 1 : 0);`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`amount.SetValue(selected.GetValueOrDefault(person.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: amount.SetValue(selected.GetValueOrDefault(person.Id));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`selected.ContainsKey(person.Id)`；返回值紧邻使用处：`ArgumentSyntax: selected.ContainsKey(person.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`inputTexts.Remove(choice.GetMeta("person", "").AsString())`；返回值紧邻使用处：`ExpressionStatementSyntax: inputTexts.Remove(choice.GetMeta("person", "").AsString());`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`inputTexts.TryGetValue(person.Id, out string? raw)`；返回值紧邻使用处：`IfStatementSyntax: if (inputTexts.TryGetValue(person.Id, out string? raw)) amount.RestoreText(raw);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`row.GetChildren().OfType<CareerAvatar>().ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var avatar in row.GetChildren().OfType<CareerAvatar>().ToArray()) { row.RemoveChild(avatar); avatar.QueueFree(); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`selected.GetValueOrDefault(person.Id)`；返回值紧邻使用处：`ArgumentSyntax: selected.GetValueOrDefault(person.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`rows.Add((row, choice, amount))`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.Add((row, choice, amount));`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`row.GetChildren().OfType<CareerAvatar>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<CareerAvatar>().ToArray`
- `System.Math.Ceiling(double)`；输入表达式：`Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(330, scroll.Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(330, scroll.Size.Y) / rowHeight`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, people.Length - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, people.Length - 1)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight) + 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight) + 1)`
- `Update(bool)`；输入表达式：`Update(!amount.Valid || amount.Value > 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(!amount.Valid || amount.Value > 0);`
- `Update(bool)`；输入表达式：`Update(active)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(active);`

**赋值（含属性/字段和局部值）：**

- `Maximum` = `guests ? 1 : int.MaxValue`
- `Minimum` = `0`
- `amount.Changed` += `() => { inputTexts[choice.GetMeta("person", "").AsString()] = amount.InputText; Update(!amount.Valid || amount.Value > 0); }`
- `amount.Visible` = `!guests`
- `choice.Alignment` = `HorizontalAlignment.Left`
- `choice.CustomMinimumSize` = `new(0, 48)`
- `choice.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `choice.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `choice.Text` = `person.PublicName + " · " + person.Role`
- `choice.ToggleMode` = `true`
- `choice.Toggled` += `active => { amount.SetValue(active ? 1 : 0); inputTexts.Remove(choice.GetMeta("person", "").AsString()); Update(active); }`
- `choice.TooltipText` = `choice.Text`
- `inputTexts[choice.GetMeta("person", "").AsString()]` = `amount.InputText`
- `row.Position` = `new(0, (first + i) * rowHeight)`
- `row.Size` = `new(list.Size.X, rowHeight - 8)`
- `row.Visible` = `i < visible`
- `style.BorderWidthBottom` = `2`
- `style.BorderWidthLeft` = `style.BorderWidthRight = style.BorderWidthTop = style.BorderWidthBottom = 2`
- `style.BorderWidthRight` = `style.BorderWidthTop = style.BorderWidthBottom = 2`
- `style.BorderWidthTop` = `style.BorderWidthBottom = 2`
- `var (row, choice, amount)` = `rows[i]`

<a id="symbol-73796f12bafd"></a>

## `Update(bool) — void Update(bool active)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Rows()`](ConsumerGiftScreen.cs.md#symbol-136ca1d3e38e)

**调用：** [`Counter()`](ConsumerGiftScreen.cs.md#symbol-7049f492eb6b)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；`Godot.Variant.AsString()`；[`NationalSpire.ConsumerQuantity.SetValue(int)`](ConsumerGiftControls.cs.md#symbol-e2e90c4c8401)；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `Counter()`；`NationalSpire.ConsumerQuantity.SetValue(int)`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Counter()`；输入表达式：`Counter()`；返回值紧邻使用处：`ExpressionStatementSyntax: Counter();`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`choice.SetPressedNoSignal(active)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.SetPressedNoSignal(active);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`r.Name.SetPressedNoSignal(selected.ContainsKey(r.Name.GetMeta("person", "").AsString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: r.Name.SetPressedNoSignal(selected.ContainsKey(r.Name.GetMeta("person", "").AsString()));`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`choice.GetMeta("person", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choice.GetMeta("person", "").AsString`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`r.Name.GetMeta("person", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: r.Name.GetMeta("person", "").AsString`
- `Godot.Variant.AsString()`；输入表达式：`choice.GetMeta("person", "").AsString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = choice.GetMeta("person", "").AsString()`
- `Godot.Variant.AsString()`；输入表达式：`r.Name.GetMeta("person", "").AsString()`；返回值紧邻使用处：`ArgumentSyntax: r.Name.GetMeta("person", "").AsString()`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`amount.SetValue(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: amount.SetValue(0);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`selected.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`selected.ContainsKey(r.Name.GetMeta("person", "").AsString())`；返回值紧邻使用处：`ArgumentSyntax: selected.ContainsKey(r.Name.GetMeta("person", "").AsString())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`inputTexts.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: inputTexts.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`selected.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Remove(id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`invalid.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: invalid.Add(id);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`invalid.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: invalid.Remove(id);`

**赋值（含属性/字段和局部值）：**

- `selected[id]` = `amount.Value`

<a id="symbol-d8f83c070522"></a>

## `Filter() — void Filter()`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)

**调用：** `Godot.Vector2.Vector2(float, float)`；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`Rows()`](ConsumerGiftScreen.cs.md#symbol-136ca1d3e38e)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`string.Contains(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`Rows()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, people.Length * rowHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: list.CustomMinimumSize = new(0, people.Length * rowHeight)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Favour(data, p.Id) > 0`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PrivateMessages.Favour(data, p.Id)`
- `Rows()`；输入表达式：`Rows()`；返回值紧邻使用处：`ExpressionStatementSyntax: Rows();`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`authors.Contains(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "近期发帖回帖者" => authors.Contains(p.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`familiar.Contains(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "熟悉的人" => familiar.Contains(p.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`opponents.Contains(p.Id)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "近期对手" => opponents.Contains(p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue))`；返回值紧邻使用处：`ConditionalExpressionSyntax: filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)`；返回值紧邻使用处：`ConditionalExpressionSyntax: filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id))`；返回值紧邻使用处：`ConditionalExpressionSyntax: filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id)) : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id)) : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: people = (filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id)) : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => data.Esports.ClubId.Length > 0 && p.ClubId == data.Esports.ClubId, "近期对手" => opponents.Contains(p.Id), "近期发帖回帖者" => authors.Contains(p.Id), "按好感度" => PrivateMessages.Favour(data, p.Id) > 0, _ => true })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = candidates.Where(p => p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) .Where(p => filter switch { "熟悉的人" => familiar.Contains(p.Id), "同俱乐部" => data.Esports.ClubId.Length > 0 && p.ClubId == data.Esports.ClubId, "近期对手" => opponents.Contains(p.Id), "近期发帖回帖者" => authors.Contains(p.Id), "按好感度" => PrivateMessages.Favour(data, p.Id) > 0, _ => true })`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`recent.GetValueOrDefault(p.Id, int.MaxValue)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => recent.GetValueOrDefault(p.Id, int.MaxValue)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `list.CustomMinimumSize` = `new(0, people.Length * rowHeight)`
- `people` = `(filter == "按好感度" ? matches.OrderByDescending(p => PrivateMessages.Favour(data, p.Id)) : filter == "按最近聊天" ? matches.OrderBy(p => recent.GetValueOrDefault(p.Id, int.MaxValue)) : matches.OrderBy(p => p.PublicName, StringComparer.Ordinal)).ToArray()`
- `scroll.ScrollVertical` = `0`

<a id="symbol-53b0d3e663d2"></a>

## `NationalSpire.CareerScreen.PrivateGiftPicker() — private void PrivateGiftPicker()`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetParent()`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；[`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-da833f356cc6)；[`NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`](ConsumerGifts.cs.md#symbol-719a54192f66)；[`NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-0819c021af70)；[`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ConsumerGifts.cs.md#symbol-cfd7b7ca0a55)；[`NationalSpire.ConsumerQuantity.ConsumerQuantity()`](ConsumerGiftControls.cs.md#symbol-0eddfdec0f89)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；`NationalSpire.GiftItem.GiftItem()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；[`Validate()`](ConsumerGiftScreen.cs.md#symbol-2ac5dc464a3f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；`NationalSpire.ConsumerCatalog.All`；`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；`NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.Initialize(int)`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.Good.Giftable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.PrivateMessageCommand.Request`；`Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 16);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(shop)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(shop);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(spacer)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(spacer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"库存 {available:N0}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"库存 {available:N0}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(good.Name, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(good.Name, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(reason, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(reason, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(grid);`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`grid.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: grid.GetChildCount() == 0`
- `Godot.Node.GetParent()`；输入表达式：`button.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (HBoxContainer)button.GetParent()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`actions.MoveChild(shop, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.MoveChild(shop, 0);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`actions.MoveChild(spacer, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.MoveChild(spacer, 1);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(600, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(600, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 350)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 350)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessagesCore(false);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("前往商城", () => { _cancelDialog?.Invoke(); ClosePrivateMessagesCore(false); Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; }); }, 130)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("前往商城", () => { _cancelDialog?.Invoke(); ClosePrivateMessagesCore(false); Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; }); }, 130)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-gift-draft", new() { Request = gift }, RefreshPrivateAttachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-gift-draft", new() { Request = gift }, RefreshPrivateAttachments);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("赠送礼物", "选择库存中的礼物，附到消息后可以填写赠礼留言。", () => { var gift = ConsumerGifts.Draft(chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value })); if (inputs.Any(i => !i.Valid) || ConsumerGifts.Validate(ViewData, person, gift) is { }) { error!.Text = "请检查库存和礼物数量。"; return false; } PrivateCommand("dm-gift-draft", new() { Request = gift }, RefreshPrivateAttachments); return true; }, "确认", box => { var scroll = new ScrollContainer { CustomMinimumSize = new(600, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); scroll.AddChild(grid); foreach (var good in ConsumerCatalog.All.Where(g => g.Giftable && ConsumerGifts.Available(data, g.Id) > 0)) { var card = Card(); grid.AddChild(card); var body = Inner(card); body.AddChild(Text(good.Name, 18, _ink)); int available = ConsumerGifts.Available(data, good.Id); body.AddChild(Text($"库存 {available:N0}", 15, _muted)); string? reason = ConsumerGifts.RecipientError(data, person, good.Id); if (reason != null) { body.AddChild(Text(reason, 14, _muted)); continue; } var input = new ConsumerQuantity { Name = "GiftStock_" + good.Id, Minimum = 0, Maximum = available }; input.Initialize(0); inputs.Add(input); body.AddChild(input); input.Changed += () => { chosen[good.Id] = input.Value; Validate(); }; } if (grid.GetChildCount() == 0) box.AddChild(Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted)); error = Text("", 15, new Color("ee929d")); box.AddChild(error); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("赠送礼物", "选择库存中的礼物，附到消息后可以填写赠礼留言。", () => { var gift = ConsumerGifts.Draft(chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value })); if (inputs.Any(i => !i.Valid) || ConsumerGifts.Validate(ViewData, person, gift) is { }) { error!.Text = "请检查库存和礼物数量。"; return false; } PrivateCommand("dm-gift-draft", new() { Request = gift }, RefreshPrivateAttachments); return true; }, "确认", box => { var scroll = new ScrollContainer { CustomMinimumSize = new(600, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); scroll.AddChild(grid); foreach (var good in ConsumerCatalog.All.Where(g => g.Giftable && ConsumerGifts.Available(data, g.Id) > 0)) { var card = Card(); grid.AddChild(card); var body = Inner(card); body.AddChild(Text(good.Name, 18, _ink)); int available = ConsumerGifts.Available(data, good.Id); body.AddChild(Text($"库存 {available:N0}", 15, _muted)); string? reason = ConsumerGifts.RecipientError(data, person, good.Id); if (reason != null) { body.AddChild(Text(reason, 14, _muted)); continue; } var input = new ConsumerQuantity { Name = "GiftStock_" + good.Id, Minimum = 0, Maximum = available }; input.Initialize(0); inputs.Add(input); body.AddChild(input); input.Changed += () => { chosen[good.Id] = input.Value; Validate(); }; } if (grid.GetChildCount() == 0) box.AddChild(Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted)); error = Text("", 15, new Color("ee929d")); box.AddChild(error); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂无可赠送的库存，请先在消费商城购买。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"库存 {available:N0}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"库存 {available:N0}", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Name, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Name, 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(reason, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(reason, 14, _muted)`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; });`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm") is Button button`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`ConsumerGifts.Available(data, g.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerGifts.Available(data, g.Id) > 0`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`ConsumerGifts.Available(data, good.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerGifts.Available(data, good.Id)`
- `NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；输入表达式：`ConsumerGifts.Draft(chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value }))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerGifts.Draft(chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value }))`
- `NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`；输入表达式：`ConsumerGifts.RecipientError(data, person, good.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerGifts.RecipientError(data, person, good.Id)`
- `NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerGifts.Validate(ViewData, person, gift)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerGifts.Validate(ViewData, person, gift) is { }`
- `NationalSpire.ConsumerQuantity.ConsumerQuantity()`；输入表达式：`new ConsumerQuantity { Name = "GiftStock_" + good.Id, Minimum = 0, Maximum = available }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConsumerQuantity { Name = "GiftStock_" + good.Id, Minimum = 0, Maximum = available }`
- `NationalSpire.ConsumerQuantity.Initialize(int)`；输入表达式：`input.Initialize(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.Initialize(0);`
- `NationalSpire.GiftItem.GiftItem()`；输入表达式：`new GiftItem { GoodId = p.Key, Quantity = p.Value }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new GiftItem { GoodId = p.Key, Quantity = p.Value }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Request = gift }`；返回值紧邻使用处：`ArgumentSyntax: new() { Request = gift }`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`inputs.Any(i => !i.Valid)`；返回值紧邻使用处：`BinaryExpressionSyntax: inputs.Any(i => !i.Valid) || ConsumerGifts.Validate(ViewData, person, gift) is { }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value })`；返回值紧邻使用处：`ArgumentSyntax: chosen.Where(p => p.Value > 0).Select(p => new GiftItem { GoodId = p.Key, Quantity = p.Value })`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ConsumerCatalog.All.Where(g => g.Giftable && ConsumerGifts.Available(data, g.Id) > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var good in ConsumerCatalog.All.Where(g => g.Giftable && ConsumerGifts.Available(data, g.Id) > 0)) { var card = Card(); grid.AddChild(card); var body = Inner(card); body.AddChild(Text(good.Name, 18, _ink)); int available = ConsumerGifts.Available(data, good.Id); body.AddChild(Text($"库存 {available:N0}", 15, _muted)); string? reason = ConsumerGifts.RecipientError(data, person, good.Id); if (reason != null) { body.AddChild(Text(reason, 14, _muted)); continue; } var input = new ConsumerQuantity { Name = "GiftStock_" + good.Id, Minimum = 0, Maximum = available }; input.Initialize(0); inputs.Add(input); body.AddChild(input); input.Changed += () => { chosen[good.Id] = input.Value; Validate(); }; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`chosen.Where(p => p.Value > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: chosen.Where(p => p.Value > 0).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`inputs.Add(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: inputs.Add(input);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<ConsumerQuantity>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<ConsumerQuantity>()`
- `Validate()`；输入表达式：`Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate();`

**赋值（含属性/字段和局部值）：**

- `Columns` = `2`
- `CustomMinimumSize` = `new(600, 350)`
- `GoodId` = `p.Key`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Maximum` = `available`
- `Minimum` = `0`
- `Name` = `"GiftStock_" + good.Id`
- `Quantity` = `p.Value`
- `Request` = `gift`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_lifeSection` = `"消费商城"`
- `_shopOwned` = `false`
- `_tab` = `"生涯生活"`
- `chosen[good.Id]` = `input.Value`
- `confirm` = `button`
- `error!.Text` = `"请检查库存和礼物数量。"`
- `error` = `Text("", 15, new Color("ee929d"))`
- `input.Changed` += `() => { chosen[good.Id] = input.Value; Validate(); }`
- `shop.Name` = `"GiftGoToShop"`

<a id="symbol-2ac5dc464a3f"></a>

## `Validate() — void Validate()`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateGiftPicker()`](ConsumerGiftScreen.cs.md#symbol-53b0d3e663d2)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerQuantity.Valid`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`chosen.Values.Any(v => v > 0)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !chosen.Values.Any(v => v > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`inputs.Any(i => !i.Valid)`；返回值紧邻使用处：`BinaryExpressionSyntax: !chosen.Values.Any(v => v > 0) || inputs.Any(i => !i.Valid)`

**赋值（含属性/字段和局部值）：**

- `confirm.Disabled` = `!chosen.Values.Any(v => v > 0) || inputs.Any(i => !i.Valid)`
