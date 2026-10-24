namespace NationalSpire;

/// <summary>私信和群聊共同使用附件编号及实际物品资料，交互动作由标记决定。</summary>
public static class ChatAttachments
{
    public const string ResponseGuide = "请根据交互格式要求来回应附件，口头回复不会视为成功回应。";
    public static string ResponseInstructions(CareerData data, PrivateOffer a, string number, GroupChat? group = null, string sender = "")
    {
        if (ChatTools.InPrompt) return ChatTools.AttachmentGuide + (a.Kind == "gift" ? "\n" + RelationshipGifts.Description(a) : "");
        string protocol = a.Kind switch
        {
            "gift" => group == null ? GiftProtocol : GroupGiftProtocol,
            OathAttachments.Kind => group == null ? OathAttachments.Protocol : OathAttachments.GroupProtocol,
            "activity" => group == null ? SocialAppointments.Protocol : SocialAppointments.GroupProtocol,
            "match" => PrivateMessagePrompts.MatchProtocol,
            "training" => ClubCoaching.Protocol,
            "lineup" => CoachLineups.Protocol,
            "contract" => PrivateMessagePrompts.ContractProtocol,
            _ => ""
        };
        if (protocol.Length == 0) return ResponseGuide;
        // 从固定协议提取完整示例，附件与系统提示共用字段定义。
        var examples = System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")
            .Select(m => m.Value).ToList();
        if (a.Kind == "match") examples = new[] { "接受", "拒绝", "改期" }
            .Select(action => examples[0].Replace("Match: 邀请", "Match: " + action)).ToList();
        if (a.Kind == "activity") examples.RemoveAll(e => e.StartsWith("[Activity: 邀请,"));
        string actor = group?.Alias(a.ActorId.Length > 0 ? a.ActorId : a.Participants.FirstOrDefault(p => p != sender) ?? "") ?? "";
        var formats = new List<string>();
        foreach (string example in examples)
        {
            string text = System.Text.RegularExpressions.Regex.Replace(example, @"(?<=Id: )\d+", _ => number);
            if (a.Kind is "activity" or "match")
            {
                text = System.Text.RegularExpressions.Regex.Replace(text, @"(?<=Date: )\d{4}-\d{2}-\d{2}", _ => GameCalendar.Iso(data, PrivateAppointments.Date(data, a)));
            }
            if (a.Kind == "activity") text = text.Replace("Title: 一起看录像", "Title: " + a.Title)
                .Replace("Detail: 讨论今天的比赛", "Detail: " + a.Detail);
            if (a.Kind == "match") text = text.Replace("Ascension: 6", "Ascension: " + a.Ascension).Replace("Mode: 切磋", "Mode: " + a.Mode);
            if (group != null)
            {
                if (a.Kind == "activity") text = text.Replace("Actor: p1", "Actor: " + group.Alias(sender))
                    .Replace("Participants: p1|p2|p3", "Participants: " + string.Join("|", a.Participants.Select(group.Alias)));
                else if (a.Kind is "gift" or OathAttachments.Kind) text = text.Replace("Actor: p2", "Actor: " + actor);
                else text = text.TrimEnd(']') + ", Actor: " + actor + (a.Kind == "match" ? ", Target: " + group.Alias(sender) : "") + "]";
                if (a.Kind is "training" or "match" or "contract" && a.Participants.Count > 1)
                {
                    formats.AddRange(a.Participants.Where(p => p != sender).Select(p => text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),
                        "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]"))));
                    continue;
                }
            }
            formats.Add(text);
        }
        if (group != null && a.Kind == "training" && a.CoachId.Length > 0)
        {
            formats.Insert(0, $"[Training: 同意, Id: {number}, Actor: {group.Alias(a.CoachId)}]");
            formats.Insert(1, $"[Training: 拒绝, Id: {number}, Actor: {group.Alias(a.CoachId)}]");
        }
        return ResponseGuide + "\n交互格式：\n" + (group == null ? "" : "[Actions]\n") + string.Join("\n", formats)
            + (a.Kind == "gift" ? "\n" + RelationshipGifts.Description(a) : "")
            + (a.Kind == "activity" ? "\n接受时按玩家附件填写活动资料；改期时填写商谈后的日期和内容；取消时填写对应活动的资料。" : "");
    }
    public const string GiftProtocol = """
玩家可以通过礼物附件赠送物品。附件列明礼物编号、物品、数量、赠送者和接收者。根据人物关系、当前交流和个人意愿决定接受或拒绝。
人物决定接受或拒绝礼物时，必须在本轮回复中输出对应的 Gift 标记，程序据此登记礼物处理结果。
每条礼物标记完整填写 Gift、Id。Gift 填接受或拒绝，Id 填对应礼物附件的编号。
接受礼物：
[Gift: 接受, Id: 12]
拒绝礼物：
[Gift: 拒绝, Id: 12]
只有标记才登记交互，口头答应无法触发实际效果。
普通礼物附件附有确定恋人关系的请求时，接受礼物后成为恋人。接受誓约之戒或盛大婚礼后，双方可以择期举办婚礼；完成婚礼活动后正式缔结誓约。拒绝礼物则保持当前关系。
""";
    public static string GroupGiftProtocol => GiftProtocol
        .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")
        .Replace("[Gift: 接受, Id: 12]", "[Gift: 接受, Id: 12, Actor: p2]")
        .Replace("[Gift: 拒绝, Id: 12]", "[Gift: 拒绝, Id: 12, Actor: p2]");

    public static PrivateOffer? Find(PrivateConversation c, PrivateTurn turn, string kind, Dictionary<string, string> fields)
    {
        var id = PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"));
        var candidates = turn.Attachments.Where(a => a.Kind == kind).ToArray();
        if (!string.IsNullOrEmpty(id) && id != "0")
            return candidates.FirstOrDefault(a => a.Id == id)
                ?? c.Turns.SelectMany(t => t.Attachments).FirstOrDefault(a => a.Kind == kind && a.Id == id);
        var matching = candidates.Where(a => (!fields.TryGetValue("Title", out var title) || a.Title == title)
            && (!fields.TryGetValue("Day", out var day) || a.Day.ToString() == day)
            && (!fields.TryGetValue("Season", out var season) || a.Season.ToString() == season)).ToArray();
        return matching.Length == 1 ? matching[0] : null;
    }

    public static string? Prepare(CareerData d, string person, PrivateOffer a, bool shopping = false)
    {
        if (a.Kind == OathAttachments.Kind) return OathAttachments.Prepare(d, person, a);
        if (a.Kind == "activity")
        {
            if (string.IsNullOrWhiteSpace(a.Title) || a.Season < 1 || a.Day < 1 || a.Day > SeasonCalendar.Length(d, a.Season)) return "请选择活动名称和日期。";
            if (PrivateAppointments.Date(d, a) < d.Day) return SocialAppointments.ExpiredDate;
            a.Detail = a.Detail.Trim();
            return WeddingAppointments.Error(d, a);
        }
        var good = ConsumerCatalog.Get(a.GoodId);
        if (good == null || !good.Giftable || a.Quantity < 1) return "请选择礼物和数量。";
        if (!shopping && ConsumerAttachments.Find(d, a) == null && ConsumerAttachments.Available(d, good) < a.Quantity) return "现有物品数量不足。";
        if (RelationshipGifts.Error(d, person, a) is { } relationshipError) return relationshipError;
        a.RelationshipIntent = RelationshipGifts.Intent(a);
        a.ActorId = person; a.Title = good.Name;
        a.Detail = $"赠送者：{CareerEngine.Name(d)}\n接收者：{CareerEngine.DisplayName(d, person)}\n礼物：{good.Name}×{a.Quantity}";
        if (RelationshipGifts.Description(a) is { Length: > 0 } description) a.Detail += "\n" + description;
        return null;
    }

    public static string Material(CareerData data, PrivateOffer a, string number) => a.Kind == "activity"
        ? $"[Activity: 邀请, Id: {number}, Title: {a.Title}, Date: {GameCalendar.Iso(data, PrivateAppointments.Date(data, a))}, Detail: {a.Detail}]"
        : AiGeneratedText.Attachment(data, a);

    public static void Gift(CareerData d, PrivateConversation c, PrivateTurn turn, Dictionary<string, string> fields)
    {
        string action = fields.GetValueOrDefault("Gift", "");
        if (action is not ("接受" or "拒绝")) return;
        var a = Find(c, turn, "gift", fields);
        if (a == null) { turn.Error += "\n请在礼物附件中明确本次处理的礼物编号。"; return; }
        string receipt = a.GroupId + "/" + a.Id;
        if (a.ActorId != c.PersonId || d.Life.Consumer.GiftReceipts.Contains(receipt)) return;
        if (action == "接受")
        {
            if (RelationshipGifts.Error(d, c.PersonId, a) is { } relationshipError) { turn.Error += "\n" + relationshipError; return; }
            var goods = d.Life.Consumer.Goods.Where(g => g.Id == a.GoodId && !g.Consumed).ToArray();
            bool prepaid = ConsumerCatalog.Get(a.GoodId)?.Instant == true && ConsumerAttachments.Find(d, a) != null;
            if (!prepaid && goods.Sum(g => g.Quantity) < a.Quantity) { turn.Error += "\n礼物库存已变化，请调整赠送数量。"; return; }
            long remaining = prepaid ? 0 : a.Quantity;
            foreach (var good in goods) { long count = Math.Min(remaining, good.Quantity); good.Quantity -= count; remaining -= count; }
            RelationshipGifts.Accept(d, c.PersonId, a);
        }
        ConsumerAttachments.Resolve(d, a, action == "接受");
        d.Life.Consumer.GiftReceipts.Add(receipt);
        c.Offers.Add(new() { Id = a.Id, Kind = "gift", TurnId = turn.Id, GoodId = a.GoodId, Quantity = a.Quantity,
            ConsumerAttachmentId = a.ConsumerAttachmentId, ActorId = a.ActorId, Title = a.Title, Detail = a.Detail, RelationshipIntent = a.RelationshipIntent, State = action == "接受" ? "已接受" : "已拒绝" });
    }
}
