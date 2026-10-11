namespace NationalSpire;

// 原文负责显示和检索；程序在生成事实时另存的职业名称版本只供 AI 使用。
public static class AiGeneratedText
{
    public static string Source(CommunityPost post) => post.AiSourceBody ?? post.SourceBody;
    public static string Memory(CommunityMemory memory) => memory.AiText ?? memory.Text;
    public static string Attachment(PrivateOffer offer) => offer.AiDetail ?? offer.Detail;
    public static string? Different(string original, string ai) => original == ai ? null : ai;
}
