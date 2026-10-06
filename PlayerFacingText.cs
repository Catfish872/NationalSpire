namespace NationalSpire;

/// <summary>错误保留服务商原文，显示前隐藏凭据。</summary>
public static class PlayerFacingText
{
    public static string AiError(string detail) => string.IsNullOrWhiteSpace(detail)
        ? "未记录错误详情，请重试后查看。" : Diagnostics.Redact(detail);

    public static string AiErrorPreview(string detail)
    {
        string text = AiError(detail).Replace("\r", "").Replace("\n", " · ");
        return text.Length <= 180 ? text : text[..180] + "……";
    }

    public static string AiStatus(string status) => status switch
    {
        "尚未请求" => "尚未开始生成",
        "等待请求间隔" => "正在等待设置的请求间隔……",
        "社区回应已排队" => "正在等候生成……",
        "离线社区模式" => "AI 已关闭",
        "社区已有离线回应" or "社区回应已更新" => "社区有新回复",
        "正在生成社区讨论" => "正在撰写帖子……",
        "正在生成社区回应" => "正在撰写回复……",
        _ when status.StartsWith("已发布 ") => status.Replace(" 篇 AI 更新", " 篇新内容"),
        _ when status.StartsWith("正在") || status.StartsWith("第 ") => status,
        _ => AiError(status)
    };
}
