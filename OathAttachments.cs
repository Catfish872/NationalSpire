namespace NationalSpire;

/// <summary>解除誓约由玩家附件发起，接受标记沿用聊天交互的保存及撤回流程。</summary>
public static class OathAttachments
{
    public const string Kind = "oath-release";
    public const string Protocol = """
玩家可以通过解除誓约附件提出解除当前誓约。人物同意解除或决定拒绝时，必须在本轮回复中输出对应的Oath标记，程序据此登记处理结果。
每条标记完整填写Oath、Id。Oath填接受或拒绝；Id填解除誓约附件的编号。
接受解除：
[Oath: 接受, Id: 14]
拒绝解除：
[Oath: 拒绝, Id: 14]
接受后解除当前誓约；拒绝后保持当前誓约。已有聊天记录和婚礼经历继续保留。只有标记才登记交互，口头答应无法触发实际效果。
""";
    public static string GroupProtocol => Protocol.Replace("每条标记完整填写Oath、Id。", "每条标记完整填写Oath、Id、Actor。Actor填收到附件的人物编号。")
        .Replace("Id: 14]", "Id: 14, Actor: p2]");
    public static string? Prepare(CareerData data, string person, PrivateOffer offer)
    {
        if (!PrivateMessages.Relation(data, person).OathConfirmed) return "当前与这位选手没有誓约。";
        offer.ActorId = person; offer.Title = "解除誓约";
        offer.Detail = CareerEngine.Name(data) + "向" + CareerEngine.DisplayName(data, person) + "提出解除当前誓约，等待对方接受或拒绝。";
        return null;
    }
    public static void Respond(CareerData data, PrivateConversation conversation, PrivateTurn turn, Dictionary<string, string> fields)
    {
        string action = fields.GetValueOrDefault("Oath", "");
        if (action is not ("接受" or "拒绝")) return;
        var attachment = ChatAttachments.Find(conversation, turn, Kind, fields);
        if (attachment == null) { turn.Error += "\n请在解除誓约附件中明确本次处理的编号。"; return; }
        if (attachment.ActorId != conversation.PersonId || conversation.Offers.Any(o => o.Kind == Kind && o.Id == attachment.Id)) return;
        var relation = PrivateMessages.Relation(data, conversation.PersonId);
        if (action == "接受")
        {
            relation.OathConfirmed = false; relation.SelectedBond = 1; relation.RefreshAppearance(); relation.Revision++;
        }
        conversation.Offers.Add(new() { Id = attachment.Id, Kind = Kind, TurnId = turn.Id, ActorId = attachment.ActorId,
            Title = attachment.Title, Detail = attachment.Detail, State = action == "接受" ? "已解除" : "已拒绝" });
    }
}
