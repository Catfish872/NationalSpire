namespace NationalSpire;

public sealed class InvitationReservation
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string GoodId { get; set; } = "";
    public string Verb { get; set; } = "";
    public List<string> People { get; set; } = [];
    public bool Consumed { get; set; }
}

/// <summary>草稿和待回应消息预留库存；一批来宾首次接受时结算一次。</summary>
public static class ConsumerInvitationStock
{
    public const string ActiveMessage = "有正在进行中的约会事件";
    public static bool Active(CareerData data) => PrivateMessages.Mailbox(data).Conversations.Values.Any(c =>
        c.DateSceneStates.Any(p => p.Value is "active" or "paused")
        || c.Turns.Any(t => t.Scene is { Opening: true } s && c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended"));
    public static bool Ticket(Good good) => good.Slots > 0;
    private static Dictionary<string, int> Legacy(CareerData data)
    {
        var used = PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers)
            .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId).GroupBy(o => o.GoodId).ToDictionary(g => g.Key, g => g.Count());
        return data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good))
            .GroupBy(g => g.Id).ToDictionary(g => g.Key, g => Math.Max(0, g.Count() - used.GetValueOrDefault(g.Key)));
    }
    public static void Initialize(CareerData data) => data.Life.Consumer.InvitationStock ??= Legacy(data);
    public static int Available(CareerData data, string goodId, string verb = "", string except = "")
        => Availability(data, except).GetValueOrDefault((goodId, verb));
    public static Dictionary<(string Good, string Verb), int> Availability(CareerData data, string except = "")
    {
        var live = PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c)))
            .Where(a => a.Kind == ConsumerInvitations.Kind).Select(a => a.InvitationReservation).ToHashSet();
        var counts = (data.Life.Consumer.InvitationStock ?? Legacy(data)).ToDictionary(p => (p.Key, ""), p => p.Value);
        foreach (var owned in data.Life.Consumer.Goods.Where(g => g.Durable))
        {
            foreach (var verb in ConsumerCatalog.Get(owned.Id)?.Verbs ?? [])
                counts[(owned.Id, verb.Id)] = owned.UsedSeason == data.Season && owned.UsedVerbs.Contains(verb.Id) ? 0 : 1;
        }
        foreach (var reservation in data.Life.Consumer.InvitationReservations.Values.Where(r => !r.Consumed && r.Id != except && live.Contains(r.Id)))
        {
            var key = (reservation.GoodId, reservation.Verb); counts[key] = Math.Max(0, counts.GetValueOrDefault(key) - 1);
        }
        return counts;
    }
    public static string Reserve(CareerData data, string goodId, string verb, IReadOnlyList<string> people)
    {
        Initialize(data);
        var item = new InvitationReservation { GoodId = goodId, Verb = verb, People = people.ToList() };
        data.Life.Consumer.InvitationReservations.Add(item.Id, item); return item.Id;
    }
    public static string? Validate(CareerData data, string person, PrivateOffer invitation)
    {
        if (ConsumerInvitations.IsWedding(invitation) && PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person)?.RingReceived != true)
            return "婚礼邀约对象需要已收到誓约之戒。";
        Initialize(data);
        if (invitation.InvitationReservation.Length == 0)
        {
            if (Available(data, invitation.GoodId, invitation.GoodVerb) == 0) return "邀约商品库存不足，请重新购买。";
            invitation.InvitationReservation = Reserve(data, invitation.GoodId, invitation.GoodVerb, [person]);
        }
        var saved = data.Life.Consumer.InvitationReservations.GetValueOrDefault(invitation.InvitationReservation);
        return saved == null || saved.GoodId != invitation.GoodId || saved.Verb != invitation.GoodVerb || !saved.People.Contains(person)
            ? "邀约预留记录无效。" : null;
    }
    public static string? Accept(CareerData data, string person, PrivateOffer invitation)
    {
        if (Validate(data, person, invitation) is { } error) return error;
        var item = data.Life.Consumer.InvitationReservations[invitation.InvitationReservation];
        if (item.Consumed) return null;
        if (Available(data, item.GoodId, item.Verb, item.Id) == 0) return "邀约库存已用完，本次约定尚未建立。";
        if (item.Verb.Length > 0)
        {
            if (ConsumerEngine.Use(data, item.GoodId, item.Verb, [person], planned: true) is { } useError) return useError;
        }
        else
        {
            data.Life.Consumer.InvitationStock![item.GoodId]--;
            if (data.Life.Consumer.Goods.FirstOrDefault(g => g.Id == item.GoodId && !g.Consumed) is { } purchased) purchased.Consumed = true;
        }
        item.Consumed = true; return null;
    }
}
