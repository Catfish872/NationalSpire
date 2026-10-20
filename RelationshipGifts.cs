namespace NationalSpire;

/// <summary>赠礼关系请求在发送及接受时使用同一门槛；普通礼物继续按原库存流程执行。</summary>
public static class RelationshipGifts
{
    public static bool Special(string good) => good is "oath-ring" or "grand-wedding";
    public static int Intent(PrivateOffer offer) => Special(offer.GoodId) ? 2 : offer.RelationshipIntent == 1 ? 1 : 0;
    public static string? Error(CareerData data, string person, PrivateOffer offer)
    {
        int intent = Intent(offer), favour = PrivateMessages.Favour(data, person);
        return intent >= 2 && favour < 85 ? "缔结誓约需要好感达到85。"
            : intent == 1 && favour < 60 ? "确定恋人关系需要好感达到60。" : null;
    }
    public static string Description(PrivateOffer offer) => Intent(offer) switch
    {
        1 => "附加请求：确定恋人关系；接受礼物后成为恋人。",
        2 => "附加请求：缔结誓约；接受礼物后确定誓约关系。",
        _ => ""
    };
    public static void Accept(CareerData data, string person, PrivateOffer offer)
    {
        int intent = Intent(offer); if (intent == 0) return;
        var relation = PrivateMessages.Relation(data, person);
        relation.SelectedBond = Math.Max(relation.SelectedBond ?? 0, intent);
        if (intent >= 2) relation.OathConfirmed = true;
        if (offer.GoodId == "oath-ring") relation.RingReceived = true;
        relation.RefreshAppearance(); relation.Revision++;
    }
}
