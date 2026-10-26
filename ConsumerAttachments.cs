namespace NationalSpire;

public sealed class ConsumerTemporaryGood
{
    public string Id { get; set; } = "";
    public int Day { get; set; }
    public long Quantity { get; set; }
}

/// <summary>已付款附件的独立身份跨越草稿、聊天轮次和改期记录。</summary>
public sealed class ConsumerAttachment
{
    public string Id { get; set; } = "";
    public string Person { get; set; } = "";
    public string Group { get; set; } = "";
    public int Day { get; set; }
    public string State { get; set; } = "draft";
    public long ReservedQuantity { get; set; }
    public PrivateOffer Offer { get; set; } = new();
}

public static class ConsumerAttachments
{
    public static long Available(CareerData d, Good good) => good.Instant
        ? d.Life.Consumer.TemporaryGoods.Where(x => x.Id == good.Id && x.Day == d.Day).Sum(x => x.Quantity)
        : d.Life.Consumer.Goods.Where(x => x.Id == good.Id && !x.Consumed).Sum(x => x.Quantity);
    public static int ToBuy(CareerData d, Good good, int quantity) => (int)Math.Max(0, quantity - Available(d, good));
    public static ConsumerAttachment? Find(CareerData d, PrivateOffer a) => d.Life.Consumer.Attachments.FirstOrDefault(x => x.Id == a.ConsumerAttachmentId);
    public static string? Validate(CareerData d, string person, string group, PrivateOffer a, string state)
    {
        if (a.ConsumerAttachmentId.Length == 0) return null;
        if (Find(d, a) is not { } saved) return "这份附件的库存记录属于原赠送者，请由原赠送者继续处理。";
        if (saved.State != state) return "这份附件已处理，请重新选择物品。";
        if (saved.Person != person || saved.Group != group || saved.Offer.Kind != a.Kind
            || saved.Offer.GoodId != a.GoodId || saved.Offer.Quantity != a.Quantity
            || saved.Offer.RelationshipIntent != a.RelationshipIntent)
            return "这份附件的接收者、商品或数量已变化，请重新选择。";
        return null;
    }
    public static string? ValidateDrafts(CareerData d, string person, string group, List<PrivateOffer> attachments)
    {
        var ids = new HashSet<string>();
        foreach (var a in attachments.Where(a => a.ConsumerAttachmentId.Length > 0))
        {
            if (!ids.Add(a.ConsumerAttachmentId)) return "每份库存附件只能发送一次。";
            if (Validate(d, group.Length > 0 ? a.ActorId : person, group, a, "draft") is { } error) return error;
        }
        return null;
    }
    public static string? Prepare(CareerData d, string person, string group, PrivateOffer a, bool buyMissing = true)
    {
        ConsumerEngine.Ensure(d);
        if (a.ConsumerAttachmentId.Length > 0) return Validate(d, person, group, a, "draft");
        if (a.Kind is not ("gift" or "activity")) return "请选择礼物或活动附件。";
        var good = ConsumerCatalog.Get(a.GoodId);
        if (good == null || a.Quantity < 1) return "请选择商品和数量。";
        if (group.Length > 0 && !GroupChats.Visible(d).Any(g => g.Id == group && g.Members.Contains(person))) return "请选择有效的群聊和成员。";
        if (ChatAttachments.Prepare(d, person, a, shopping: true) is { } error) return error;
        if (a.Kind == "activity")
        {
            var verb = good.Activities.FirstOrDefault(v => v.Id == a.GoodVerb);
            if (verb == null) return "请选择这件商品对应的活动。";
            var guests = a.Participants.Where(id => !GroupChats.IsHuman(d, id)).ToArray();
            if (ConsumerEngine.Guests(d, guests, verb.Slots) is { } guestError) return guestError;
        }
        int buy = ToBuy(d, good, a.Kind == "activity" ? 1 : a.Quantity);
        if (!buyMissing && buy > 0) return "可用库存不足，请调整赠送数量。";
        if (buy > 0 && ConsumerEngine.Buy(d, good.Id, quantity: buy) is { } paymentError) return paymentError;
        a.ConsumerAttachmentId = Guid.NewGuid().ToString("N"); a.GroupId = group;
        if (good.Instant) Take(d, good.Id, a.Quantity);
        long reserved = 0;
        if (!good.Instant && a.Kind == "gift")
        {
            long remaining = a.Quantity;
            foreach (var stack in d.Life.Consumer.Goods.Where(g => g.Id == good.Id && !g.Consumed))
            {
                long taken = Math.Min(stack.Quantity, remaining); stack.Quantity -= taken; remaining -= taken;
                if (remaining == 0) break;
            }
            // 零数量记录保留购买元数据，便于取消附件与重生成恢复同一批库存。
            reserved = a.Quantity;
        }
        d.Life.Consumer.Attachments.Add(new() { Id = a.ConsumerAttachmentId, Person = person, Group = group, Day = d.Day,
            ReservedQuantity = reserved, Offer = Coop.CoopJson.Copy(a) });
        return null;
    }
    private static void Take(CareerData d, string id, int quantity)
    {
        long remaining = quantity;
        foreach (var x in d.Life.Consumer.TemporaryGoods.Where(x => x.Id == id && x.Day == d.Day))
        { long count = Math.Min(x.Quantity, remaining); x.Quantity -= count; remaining -= count; }
        d.Life.Consumer.TemporaryGoods.RemoveAll(x => x.Quantity == 0);
    }
    public static void Sent(CareerData d, IEnumerable<PrivateOffer> attachments)
    {
        foreach (var a in attachments)
            if (Find(d, a) is { State: "draft" } saved) { saved.State = "pending"; saved.Offer = Coop.CoopJson.Copy(a); }
    }
    public static void Resolve(CareerData d, PrivateOffer a, bool accepted)
    {
        if (Find(d, a) is not { } saved || saved.State is "returned" or "used" or "expired") return;
        if (accepted) { saved.State = a.Kind == "activity" ? "accepted" : "used"; return; }
        saved.State = "returned";
        a = saved.Offer;
        if (saved.ReservedQuantity > 0 && ConsumerCatalog.Get(a.GoodId) is { } good)
        { ConsumerEngine.ChangeInventory(d, good, saved.ReservedQuantity); return; }
        if (ConsumerCatalog.Get(a.GoodId)?.Instant != true) return;
        var stack = d.Life.Consumer.TemporaryGoods.FirstOrDefault(x => x.Id == a.GoodId && x.Day == d.Day);
        if (stack == null) d.Life.Consumer.TemporaryGoods.Add(new() { Id = a.GoodId, Day = d.Day, Quantity = a.Quantity });
        else stack.Quantity += a.Quantity;
    }
    public static string? Remove(CareerData d, string id)
    {
        if (d.Life.Consumer.Attachments.FirstOrDefault(x => x.Id == id && x.State == "draft") is { } saved) Resolve(d, saved.Offer, false);
        return null;
    }
    public static void Advance(CareerData d)
    {
        d.Life.Consumer.TemporaryGoods.RemoveAll(x => x.Day < d.Day);
        foreach (var x in d.Life.Consumer.Attachments.Where(x => x.State == "draft" && x.Day < d.Day && ConsumerCatalog.Get(x.Offer.GoodId)?.Instant == true)) x.State = "expired";
    }
    public static string? Attend(CareerData d, PrivateOffer a, bool publicly)
    {
        if (Find(d, a) is not { State: "accepted" } saved) return "这项活动的付款记录已不可使用。";
        var good = ConsumerCatalog.Get(a.GoodId)!; var verb = good.Activities.Single(v => v.Id == a.GoodVerb);
        var guests = a.Participants.Where(id => !GroupChats.IsHuman(d, id)).ToArray();
        if (ConsumerEngine.Guests(d, guests, verb.Slots) is { } error) return error;
        saved.State = "used";
        ConsumerEngine.Season(d);
        var s = d.Life.Consumer; s.PartyCount++;
        foreach (string id in guests)
        { PrivateMessages.ChangeFavour(d, id, s.InvitedThisSeason.GetValueOrDefault(id) == 0 ? verb.Favor : 1); s.InvitedThisSeason[id] = s.InvitedThisSeason.GetValueOrDefault(id) + 1; }
        if (publicly) ConsumerEvents.Activity(d, good, verb, guests);
        return null;
    }
}
