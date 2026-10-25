namespace NationalSpire;

// 原文负责显示和检索；程序在生成事实时另存的职业名称版本只供 AI 使用。
public static class AiGeneratedText
{
    public static string Source(CommunityPost post) => post.AiSourceBody ?? post.SourceBody;
    public static string Memory(CommunityMemory memory) => memory.AiText ?? memory.Text;
    public static string Attachment(CareerData data, PrivateOffer offer)
    {
        if (offer.Kind == CommunitySharing.Kind && offer.Quote is { } quote) return CommunitySharing.Text(data, quote);
        string text = offer.AiDetail ?? offer.Detail;
        if (offer.Kind == "gift" && RelationshipGifts.Special(offer.GoodId))
            text = text.Replace("附加请求：缔结誓约；接受礼物后确定誓约关系。", RelationshipGifts.Description(offer), StringComparison.Ordinal)
                .Replace("附加请求：接受礼物后可以择期举办婚礼；完成婚礼活动后正式缔结誓约。", RelationshipGifts.Description(offer), StringComparison.Ordinal);
        const string report = "社区举报案件材料\n";
        if (offer.Kind == CommunityReporting.Kind && offer.AiDetail != null && text.StartsWith(report, StringComparison.Ordinal))
        {
            var node = System.Text.Json.Nodes.JsonNode.Parse(text[report.Length..])!;
            GameCalendar.ConvertJsonDates(data, node);
            return report + node.ToJsonString(new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        }
        return text;
    }
    public static string? Different(string original, string ai) => original == ai ? null : ai;
}
