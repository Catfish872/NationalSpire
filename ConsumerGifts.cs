using System.Globalization;

namespace NationalSpire;

public sealed class GiftItem
{
    public string GoodId { get; set; } = "";
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
    public long ReceivedBefore { get; set; }
    public double Preference { get; set; } = 1;
    public string Reason { get; set; } = "";
}
public sealed class GiftDelivery
{
    public List<GiftItem> Items { get; set; } = [];
    public bool Sent { get; set; }
    public bool Settled { get; set; }
    public int FavourBefore { get; set; }
    public double Mood { get; set; }
    public int MoodDay { get; set; }
    public int FavourGain { get; set; }
    public double RawGain { get; set; }
    public int MoodDays { get; set; }
}
public sealed record GiftAllocation(string Person, int Quantity);
public sealed record GiftPurchase(string GoodId, int Quantity, List<GiftAllocation> Recipients, bool Direct = true);

/// <summary>库存、分配、送达与收益统一入口；草稿预留库存，发送时扣除，完整回复后一次结算。</summary>
public static class ConsumerGifts
{
    public const string Kind = "gift", WeddingKind = "wedding-invitation";
    public static Dictionary<string, long> ReservedByGood(CareerData data) => PrivateMessages.Mailbox(data).Conversations.Values
        .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? []).GroupBy(i => i.GoodId).ToDictionary(g => g.Key, g => g.Sum(i => (long)i.Quantity));
    public static long Reserved(CareerData data, string good, string except = "") => PrivateMessages.Mailbox(data).Conversations.Values
        .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? []).Where(i => i.GoodId == good).Sum(i => (long)i.Quantity);
    public static int Available(CareerData data, string good, string except = "") => (int)Math.Max(0, data.Life.Consumer.GiftStock.GetValueOrDefault(good) - Reserved(data, good, except));
    public static string? RecipientError(CareerData data, string person, string good)
    {
        if (!PrivateMessages.CanChat(data, person)) return "请选择可私聊的 NPC。";
        return Eligibility(data, CareerEngine.Person(data, person)!, good);
    }
    public static IEnumerable<CareerPerson> Recipients(CareerData data, string good) => PrivateMessages.ChatCandidates(data).Where(p => Eligibility(data, p, good) == null);
    private static string? Eligibility(CareerData data, CareerPerson person, string good)
    {
        if (SpireArbitration.Muted(person)) return "该角色账号已封禁。";
        if (good == "oath-ring")
        {
            var r = PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person.Id) ?? new();
            if (r.Favour != 100 || !r.Appearance.Lover) return "誓约之戒仅能赠送给好感100的恋人。";
        }
        return null;
    }
    public static PrivateOffer Draft(IEnumerable<GiftItem> items) => new() { Kind = Kind, Gift = new() { Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList() } };
    public static string Summary(GiftDelivery gift) => string.Join("\n", gift.Items.Select(i => (ConsumerCatalog.Get(i.GoodId)?.Name ?? i.GoodId) + " · " + i.Quantity + " " + Unit(i.GoodId)));
    public static string Unit(string id) => id switch
    {
        "icecream" or "mouse" => "只", "watch" or "luxwatch" => "块", "milktea" => "杯", "coffee" => "袋", "cake" or "figure" => "个", "poster" or "ski" => "张",
        "laptop" or "console" or "monitor" or "projector" or "camera" or "airpurifier" or "coffeemachine" => "台", "phone" => "部",
        "ebike" or "car" => "辆", "studio" => "间", "oath-ring" => "枚", "sneakers" => "双", "jersey" or "jacket" => "件", "magazine" => "本",
        "keyboard" or "chair" => "把", "earbuds" or "sunglasses" => "副", "plant" => "盆", "lamp" => "盏", "bedding" or "suit" or "cinema" or "apartment" or "coach" or "bespoke-jewelry" => "套",
        "seasonal-bouquet" => "束", "chocolate-box" => "盒", "artisan-perfume" => "瓶", "silk-shawl" or "gem-pendant" => "条", "custom-music-box" => "个", "concert-piano" => "架", _ => "件"
    };
    public static string Number(int n) => n switch { 1 => "一", 2 => "两", 3 => "三", 4 => "四", 5 => "五", 6 => "六", 7 => "七", 8 => "八", 9 => "九", 10 => "十", _ => n.ToString(CultureInfo.InvariantCulture) };
    public static string DefaultMessage(CareerData d, string person, GiftDelivery gift) => $"（{CareerEngine.Name(d)}向{CareerEngine.DisplayName(d, person)}赠送了"
        + string.Join("、", gift.Items.Select(i => Number(i.Quantity) + Unit(i.GoodId) + ConsumerCatalog.Get(i.GoodId)!.Name)) + "。）"
        + (gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1) ? $"（{CareerEngine.DisplayName(d, person)}被赠送了多枚戒指。）" : "");
    public static string? Validate(CareerData d, string person, PrivateOffer attachment, bool inventory = true)
    {
        if (attachment.Kind != Kind || attachment.Gift is not { Sent: false, Items.Count: > 0 } gift || gift.Items.Count > ConsumerCatalog.All.Length) return "礼物附件无效。";
        if (gift.Items.Select(i => i.GoodId).Distinct().Count() != gift.Items.Count) return "同一种礼物请合并数量。";
        foreach (var item in gift.Items)
        {
            if (ConsumerCatalog.Get(item.GoodId) is not { Giftable: true } || item.Quantity <= 0) return "请选择有效的礼物与数量。";
            if (RecipientError(d, person, item.GoodId) is { } error) return error;
            if (inventory && item.Quantity > Available(d, item.GoodId, attachment.Id)) return "礼物库存不足，或已预留给其他人。";
        }
        return null;
    }
    public static string? AddDraft(CareerData d, string person, PrivateOffer input)
    {
        var draft = Draft(input.Gift?.Items ?? []);
        if (Validate(d, person, draft) is { } error) return error;
        draft.Detail = Summary(draft.Gift!);
        PrivateMessages.Conversation(d, person).GiftDrafts.Add(draft); return null;
    }
    public static string? Purchase(CareerData d, GiftPurchase order)
    {
        if (ConsumerCatalog.Get(order.GoodId) is not { Giftable: true } good) return "请选择可赠送的商品。";
        if (order.Quantity < 0) return "购买数量无效。";
        if (order.Quantity > 0 && ConsumerEngine.BuyError(d, good, order.Quantity) is { } error) return error;
        if (order.Recipients.Count == 0 || order.Recipients.Any(r => r.Quantity <= 0) || order.Recipients.Sum(r => (long)r.Quantity) > (long)order.Quantity + Available(d, good.Id)
            || order.Recipients.Select(r => r.Person).Distinct().Count() != order.Recipients.Count) return "请检查赠送数量与人物。";
        foreach (var target in order.Recipients)
        {
            if (Validate(d, target.Person, Draft([new() { GoodId = good.Id, Quantity = target.Quantity }]), false) is { } invalid) return invalid;
            if (order.Direct && (AiService.PrivateBusy(d, target.Person) || PrivateMessages.Conversation(d, target.Person).Turns.Any(t => t.Status is "queued" or "sending"))) return "请等待收礼人的当前私聊回复完成。";
        }
        if (order.Quantity > 0) ConsumerEngine.Buy(d, good.Id, quantity: order.Quantity);
        foreach (var target in order.Recipients)
        {
            var draft = Draft([new() { GoodId = good.Id, Quantity = target.Quantity }]); draft.Detail = Summary(draft.Gift!);
            if (order.Direct)
            {
                var turn = PrivateMessages.Enqueue(d, target.Person, DefaultMessage(d, target.Person, draft.Gift!), attachments: [draft]);
                Deliver(d, target.Person, turn);
            }
            else PrivateMessages.Conversation(d, target.Person).GiftDrafts.Add(draft);
        }
        return null;
    }
    public static string? PrepareSend(CareerData d, string person, List<PrivateOffer> attachments)
    {
        var gifts = attachments.Where(a => a.Kind == Kind).ToArray();
        if (gifts.Length == 0) return null;
        if (gifts.Select(a => a.Id).Distinct().Count() != gifts.Length) return "礼物附件重复。";
        var ids = gifts.Select(a => a.Id).ToHashSet();
        foreach (var gift in gifts)
        {
            if (Validate(d, person, gift, false) is { } error) return error;
            if (!Guid.TryParseExact(gift.Id, "N", out _) || d.Life.Consumer.GiftDeliveryIds.Contains(gift.Id)) return "这份礼物已发送，或附件编号无效。";
            if (PrivateMessages.Mailbox(d).Conversations.Any(c => c.Key != person && c.Value.GiftDrafts.Any(a => a.Id == gift.Id))) return "这份礼物已预留给其他人。";
        }
        var reserved = PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? [])
            .GroupBy(i => i.GoodId).ToDictionary(g => g.Key, g => g.Sum(i => (long)i.Quantity));
        foreach (var group in gifts.SelectMany(a => a.Gift!.Items).GroupBy(i => i.GoodId))
            if (group.Sum(i => (long)i.Quantity) > d.Life.Consumer.GiftStock.GetValueOrDefault(group.Key) - reserved.GetValueOrDefault(group.Key)) return "礼物库存不足，或已预留给其他人。";
        return null;
    }
    public static void Deliver(CareerData d, string person, PrivateTurn turn)
    {
        if (!turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: false })) return;
        var relation = PrivateMessages.Relation(d, person); var npc = CareerEngine.Person(d, person)!;
        foreach (var attachment in turn.Attachments.Where(a => a.Kind == Kind && a.Gift is { Sent: false }))
        {
            var gift = attachment.Gift!; gift.Sent = true; gift.Settled = false; gift.FavourBefore = relation.Favour;
            d.Life.Consumer.GiftDeliveryIds.Add(attachment.Id);
            gift.RawGain = 0; gift.FavourGain = gift.MoodDays = 0;
            gift.Mood = CareerTraining.MoodLevel(npc, d.Day); gift.MoodDay = npc.Learning.MoodDay;
            foreach (var item in gift.Items)
            {
                var good = ConsumerCatalog.Get(item.GoodId)!;
                d.Life.Consumer.GiftStock[item.GoodId] -= item.Quantity;
                item.UnitPrice = ConsumerEngine.Price(good); item.ReceivedBefore = relation.ReceivedGifts.GetValueOrDefault(good.Id);
                relation.ReceivedGifts[good.Id] = item.ReceivedBefore + item.Quantity;
                item.Preference = 1; item.Reason = "";
                if (good.Id == "oath-ring") { relation.RingReceived = true; relation.RingReplyPending = true; relation.RefreshAppearance(); }
            }
            attachment.Detail = Summary(gift); attachment.AiDetail = null;
            PrivateMessages.Conversation(d, person).GiftDrafts.RemoveAll(a => a.Id == attachment.Id);
        }
        relation.Revision++;
        Preserve(d, person);
    }
    public static double PriceGain(double price) => Math.Pow(Math.Max(0, price) / 20, Math.Log(30) / Math.Log(5000));
    public static double FavourFactor(int favour) => 1.75 - 1.5 * Math.Clamp((favour + 50) / 149d, 0, 1);
    public static double RepeatFactor(long previous) => 1 - .9 * Math.Pow(Math.Clamp(previous / 9d, 0, 1), 2);
    public static double RepeatSum(long previous, int count)
    {
        double total = 0; int distinct = (int)Math.Min(count, Math.Max(0, 9 - previous));
        for (int i = 0; i < distinct; i++) total += RepeatFactor(previous + i);
        return total + (count - distinct) * .1;
    }
    public static bool HasDelivered(PrivateTurn turn) => turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: true });
    public static void Settle(CareerData d, PrivateConversation c, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives)
    {
        if (turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(turn.Reply)) return;
        if (!turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: true, Settled: false })) return;
        var relation = PrivateMessages.Relation(d, c.PersonId);
        var difficulty = AffectionRules.Mode(d, turn);
        double lost = turn.Attachments.Where(a => a.Gift is { Settled: true }).Sum(a => Math.Max(0, -a.Gift!.RawGain));
        bool ringEffectApplied = turn.Attachments.Any(a => a.Gift is { Settled: true } prior && prior.Items.Any(i => i.GoodId == "oath-ring"));
        foreach (var attachment in turn.Attachments.Where(a => a.Kind == Kind && a.Gift is { Sent: true, Settled: false }))
        {
            var gift = attachment.Gift!; double value = 0;
            foreach (var item in gift.Items)
            {
                var preference = directives.LastOrDefault(f => f.GetValueOrDefault("Gift") == item.GoodId);
                item.Preference = preference != null && double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor)
                    && double.IsFinite(factor) ? Math.Clamp(factor, .25, 1.75) : 1;
                item.Reason = preference?.GetValueOrDefault("Reason", "") ?? "按中性偏好结算";
                int effectiveCount = item.GoodId == "oath-ring" ? ringEffectApplied ? 0 : 1 : item.Quantity;
                if (item.GoodId == "oath-ring") ringEffectApplied = true;
                gift.RawGain += AffectionRules.GiftValue(difficulty, item, effectiveCount, gift.FavourBefore, gift.Mood);
                value += item.UnitPrice * (double)effectiveCount * item.Preference;
            }
            gift.RawGain *= gift.RawGain > 0 ? AffectionRules.GainRate(difficulty) : 1;
            gift.RawGain *= AffectionRules.DateRate(difficulty, turn.Scene is { Ending: false }, gift.RawGain);
            if (gift.RawGain < 0) { gift.RawGain = Math.Max(gift.RawGain, -Math.Max(0, 3 - lost)); lost += -gift.RawGain; }
            gift.FavourGain = AffectionRules.Apply(d, c.PersonId, gift.RawGain, gift: true);
            double beneficial = Math.Max(0, gift.RawGain);
            gift.MoodDays = gift.Mood < 0 ? -(int)Math.Min(365, Math.Ceiling(beneficial))
                : gift.Mood > 0 && value >= 3000 && beneficial > 0 ? (int)Math.Min(14, Math.Max(1, Math.Floor(beneficial / 3))) : 0;
            gift.Settled = true; ApplyMood(d, c.PersonId, attachment);
            PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), c.PersonId, [nameof(PrivateRelation.Favour)]);
        }
        if (ringEffectApplied) { relation.RingReplyPending = false; relation.OathDeferred = false; relation.OathPromptHidden = false; relation.RefreshAppearance(); }
        Preserve(d, c.PersonId);
    }
    private static void Preserve(CareerData d, string person) => PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), person,
        [nameof(PrivateRelation.ReceivedGifts), nameof(PrivateRelation.GiftRemainder), nameof(PrivateRelation.GiftLossRemainder), nameof(PrivateRelation.RingReceived), nameof(PrivateRelation.RingReplyPending), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.HighestBond)]);
    public static void MergeMood(CareerData d, PrivateMailbox mailbox)
    {
        foreach (var c in mailbox.Conversations.Values)
            foreach (var a in c.Turns.SelectMany(t => t.Attachments).Where(a => a.Gift is { Settled: true })) ApplyMood(d, c.PersonId, a);
    }
    private static void ApplyMood(CareerData d, string person, PrivateOffer attachment)
    {
        var gift = attachment.Gift!; var npc = CareerEngine.Person(d, person); if (npc == null || gift.MoodDays == 0) return;
        var state = npc.Learning; string key = "gift:" + attachment.Id;
        if (!state.Receipts.Add(key)) return;
        if (state.MoodDay != gift.MoodDay || SpireArbitration.ShockDay(npc, d.Day) >= 0 || state.MoodUntil <= d.Day) return;
        int change = gift.MoodDays > 0 ? Math.Min(gift.MoodDays, Math.Max(0, 14 - state.GiftMoodExtension)) : gift.MoodDays;
        if (Math.Sign(state.MoodStrength) != Math.Sign(gift.Mood)) return;
        state.MoodUntil = Math.Max(d.Day, state.MoodUntil + change);
        if (change > 0) state.GiftMoodExtension += change;
        CareerTraining.InvalidateForecast(d);
    }
    public static string? Wedding(CareerData d, string person)
        => ConsumerInvitations.Create(d, "grand-wedding", "", [person], buy: true);
    public const string Protocol = """
赠礼附件由程序核验库存并送达。仅针对本轮附件中的已送达礼物，结合人物资料、性格、记忆和互动历史逐种给出偏好标记：[Gift: 商品Id, Preference: 1.0, Reason: 具体偏好依据]。
Preference 为0.25至1.75的喜爱倍率；中性1.0，不感兴趣可用0.6，明显喜爱可用1.5。偏好先乘商品单价，得到用于好感计算的等效价值。价格曲线、数量、重复赠送衰减、心情和当前好感由程序统一计算。正文自然回应礼物与留言，标记单独附在正文之后。
本轮含已送达礼物时，好感与状态收益由程序结算，省略Favour和Mood标记，Relationship与Attitude仍可描述实际交往。既往赠礼只作为历史参考。本轮标为已结算的礼物保持原收益。
盛大婚礼邀约沿用活动接受与排期标记；婚礼完成读取程序记录。
""";
    public static string Context(PrivateOffer a) => a.Gift is { } gift ? Summary(gift) + "\n" + (gift.Sent ? gift.Settled ? "已送达并结算" : "已送达，待本轮偏好评估" : "待发送")
        + (gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1) ? "\n该角色被赠送了多枚戒指。礼物收益与求婚效果按一枚计算。" : "")
        + "\n" + string.Join("\n", gift.Items.Select(i => $"商品Id={i.GoodId}，单价=${(i.UnitPrice > 0 ? i.UnitPrice : ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!))}，数量={i.Quantity}，此前已收={i.ReceivedBefore}")) : a.Detail;
}
