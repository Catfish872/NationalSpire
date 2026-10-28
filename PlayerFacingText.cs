using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace NationalSpire;

/// <summary>为超长错误生成界面摘要，完整原文由诊断日志保留。</summary>
public static class PlayerFacingText
{
    public static string AiError(string detail) => string.IsNullOrWhiteSpace(detail)
        ? "未记录错误详情，请重试后查看。" : Diagnostics.Redact(LongError(detail));

    /// <summary>短错误原样返回；长错误提取接口实际说明，最终显示最多1000字符。</summary>
    public static string LongError(string detail)
    {
        detail = Diagnostics.ErrorExplanation(detail);
        if (detail.Length <= Diagnostics.ErrorTextLimit) return detail;
        string reason = detail, metadata = "";
        var status = Regex.Match(detail, @"HTTP \d{3}[^\r\n{<]*").Value;
        int start = detail.IndexOf('{'), end = detail.LastIndexOf('}');
        if (start >= 0 && end > start)
        {
            try
            {
                using var json = JsonDocument.Parse(detail.AsMemory(start, end - start + 1));
                var root = json.RootElement;
                if (root.ValueKind == JsonValueKind.Object)
                {
                    var error = root.TryGetProperty("error", out var value) ? value : default;
                    reason = Field(error, "message") ?? Field(root, "message")
                        ?? (error.ValueKind == JsonValueKind.String ? error.GetString() : null)
                        ?? Field(root, "detail") ?? detail;
                    foreach (string key in new[] { "code", "type", "param", "request_id" })
                        if ((Field(error, key) ?? Field(root, key)) is { Length: > 0 } field)
                            metadata += $"\n{key}: {Head(field, 120)}";
                }
            }
            catch (JsonException) { /* 非JSON错误沿原文字处理。 */ }
        }
        if (reason.Contains("<html", StringComparison.OrdinalIgnoreCase) || reason.Contains("<!DOCTYPE html", StringComparison.OrdinalIgnoreCase))
        {
            var headings = new List<string>();
            foreach (string tag in new[] { "title", "h1", "h2", "p" })
            {
                var match = Regex.Match(reason, $@"<{tag}\b[^>]*>([^<]*)</{tag}\s*>", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string heading = WebUtility.HtmlDecode(Head(match.Groups[1].Value, 240)).Trim();
                    if (heading.Length > 0 && !headings.Any(h => h.Contains(heading))) headings.Add(heading);
                }
            }
            reason = "接口返回了错误网页。" + (headings.Count > 0 ? " " + string.Join(" · ", headings) : "");
        }
        const string suffix = "\n完整报错已保留在诊断记录中。";
        string prefix = status.Length > 0 && !reason.StartsWith(status) ? Head(status, 120).Trim() + "\n" : "";
        string text = Diagnostics.Redact(prefix + Head(reason, Diagnostics.ErrorTextLimit) + metadata);
        return Head(text, Diagnostics.ErrorTextLimit - suffix.Length) + suffix;
    }

    private static string? Field(JsonElement element, string name) => element.ValueKind == JsonValueKind.Object
        && element.TryGetProperty(name, out var value) && value.ValueKind is JsonValueKind.String or JsonValueKind.Number
        ? value.ToString() : null;

    private static string Head(string text, int length) => text.Length <= length ? text : text[..(length - 1)] + "…";

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
