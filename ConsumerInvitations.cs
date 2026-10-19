namespace NationalSpire;

/// <summary>已购商品的私聊邀约草稿；日期与接受结果交给统一活动规则。</summary>
public static class ConsumerInvitations
{
    public const string Kind = "date-invitation";
    public static bool IsWedding(PrivateOffer offer) => offer.GoodId == "grand-wedding";
    public static bool Purchased(CareerData data, string good)
        => data.Life.Consumer.Goods.Any(g => g.Id == good) || data.Life.Consumer.BoughtDay.ContainsKey(good);
    public static string? Create(CareerData data, string goodId, string verbId, IReadOnlyList<string> people, bool buy = false)
    {
        if (ConsumerInvitationStock.Active(data)) return ConsumerInvitationStock.ActiveMessage;
        var good = ConsumerCatalog.Get(goodId); var verb = good?.Verbs.FirstOrDefault(v => v.Id == verbId);
        if (good == null || verbId.Length > 0 && verb == null) return "这件商品没有对应的约会活动。";
        int slots = verb?.Slots ?? good.Slots;
        if (slots <= 0) return "这件商品没有对应的约会活动。";
        if (people.Count == 0 || people.Count > slots || people.Distinct().Count() != people.Count || people.Any(id => !ConsumerEngine.CanInvite(data, id)))
            return "请选择好感达到5的角色，并检查邀约人数。";
        if (good.Id == "grand-wedding" && people.Any(id => PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(id)?.RingReceived != true))
            return "请先向邀约对象赠送誓约之戒。";
        foreach (string person in people)
            if (PrivateMessages.Conversation(data, person).GiftDrafts.Any(a => a.Kind == Kind && a.GoodId == goodId && a.GoodVerb == verbId)) return "这项约会邀请已附在所选人物的私聊中。";
        if (buy && verb != null) return "请从已购资产选择活动。";
        if (!buy && ConsumerInvitationStock.Available(data, goodId, verbId) == 0) return "这项邀约的可用库存或活动次数不足。";
        if (verb != null && CareerMoney.Balance(data) < ConsumerEngine.HospitalityFee(data, good) / 10m) return "招待费用不足。";
        if (buy && ConsumerEngine.Buy(data, goodId) is { } error) return error;
        string reservation = ConsumerInvitationStock.Reserve(data, goodId, verbId, people);
        string title = verb?.Name ?? good.Name;
        foreach (string person in people)
            PrivateMessages.Conversation(data, person).GiftDrafts.Add(new()
            {
                Kind = Kind, GoodId = goodId, GoodVerb = verbId, Title = title, InvitationReservation = reservation,
                Detail = "约会内容：" + title + (verb == null ? "" : " · " + good.Name) + "。请在留言中商谈日期与安排，等待对方回应。"
            });
        return null;
    }
    public static string? Prepare(CareerData data, string person, PrivateOffer attachment)
    {
        if (ConsumerInvitationStock.Active(data)) return ConsumerInvitationStock.ActiveMessage;
        var source = PrivateMessages.Conversation(data, person).GiftDrafts.FirstOrDefault(a => a.Id == attachment.Id && a.Kind == Kind);
        if (source == null) return "约会邀请草稿已移除，请重新从商城邀约。";
        if (ConsumerInvitationStock.Validate(data, person, source) is { } error) return error;
        attachment.GoodId = source.GoodId; attachment.GoodVerb = source.GoodVerb; attachment.Title = source.Title;
        attachment.InvitationReservation = source.InvitationReservation; attachment.Detail = source.Detail; attachment.AiDetail = null; return null;
    }
    public static IEnumerable<PrivateOffer> Pending(PrivateConversation conversation)
    {
        var handled = conversation.Offers.Where(o => o.SourceInvitationId.Length > 0).Select(o => o.SourceInvitationId).ToHashSet();
        return conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments).Where(a => a.Kind == Kind && !handled.Contains(a.Id)).DistinctBy(a => a.Id);
    }
    public static string Context(PrivateConversation conversation)
        => string.Join("\n", Pending(conversation).Select(a => $"待回应约会邀请{PrivateInteractionIds.Number(conversation, a)}《{a.Title}》：{a.Detail}"));
    public const string Protocol = """
约会邀请附件是玩家已发出的真实请求；结合人物意愿、留言、记忆和日程回应。接受时必须附 [Activity: 接受, Id: 邀请编号, Season: 赛季数, Day: 赛季内日期]，完整回复后程序立即记入日程。尚无明确日期时，可以提议今天或未来的具体日期；需要继续商谈则只交流，待接受并确定日期时再给标记。拒绝使用 [Activity: 拒绝, Id: 邀请编号]。
这些已接受的约会使用原活动编号继续 [Activity: 改期, Id: 活动编号, Season: 赛季数, Day: 新日期] 或 [Activity: 取消, Id: 活动编号]；商谈达成后的改期立即生效。普通活动邀请仍沿玩家确认流程。编号来自程序，不根据商品名称编造编号。
盛大婚礼也使用上述接受、改期和取消流程。正式完成婚礼由程序在婚礼场景结束后记录，婚礼前按已赠婚戒的关系交流。
""";
}
