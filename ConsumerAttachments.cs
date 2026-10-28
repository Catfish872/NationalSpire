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
    public PrivateOffer Offer { get; set; } = new();
}

public static class ConsumerAttachments
{
    public static long Available(CareerData d, Good good) => good.Instant
        ? d.Life.Consumer.TemporaryGoods.Where(x => x.Id == good.Id && x.Day == d.Day).Sum(x => x.Quantity)
        : d.Life.Consumer.Goods.Where(x => x.Id == good.Id && !x.Consumed).Sum(x => x.Quantity);
    public static int ToBuy(CareerData d, Good good, int quantity) => (int)Math.Max(0, quantity - Available(d, good));
    public static ConsumerAttachment? Find(CareerData d, PrivateOffer a) => d.Life.Consumer.Attachments.FirstOrDefault(x => x.Id == a.ConsumerAttachmentId);
    public static string? Prepare(CareerData d, string person, string group, PrivateOffer a)
    {
        ConsumerEngine.Ensure(d);
        if (Find(d, a) != null) return null;
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
        if (buy > 0 && ConsumerEngine.Buy(d, good.Id, quantity: buy) is { } paymentError) return paymentError;
        a.ConsumerAttachmentId = Guid.NewGuid().ToString("N"); a.GroupId = group;
        if (good.Instant) Take(d, good.Id, a.Quantity);
        d.Life.Consumer.Attachments.Add(new() { Id = a.ConsumerAttachmentId, Person = person, Group = group, Day = d.Day, Offer = Coop.CoopJson.Copy(a) });
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
        if (Find(d, a) is not { } saved || saved.State is "returned" or "used") return;
        if (accepted) { saved.State = a.Kind == "activity" ? "accepted" : "used"; return; }
        saved.State = "returned";
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
        var good = ConsumerCatalog.Get(a.GoodId)!; var verb = good.Activities.Single(v => v.Id == a.GoodVerb);
        var guests = a.Participants.Where(id => !GroupChats.IsHuman(d, id)).ToArray();
        if (Find(d, a) is { } saved) saved.State = "used";
        ConsumerEngine.Season(d);
        var s = d.Life.Consumer; s.PartyCount++;
        foreach (string id in guests)
        { PrivateMessages.ChangeFavour(d, id, s.InvitedThisSeason.GetValueOrDefault(id) == 0 ? verb.Favor : 1); s.InvitedThisSeason[id] = s.InvitedThisSeason.GetValueOrDefault(id) + 1; }
        if (publicly) ConsumerEvents.Activity(d, good, verb, guests);
        return null;
    }
}
