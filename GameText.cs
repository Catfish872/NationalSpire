using System.Text.RegularExpressions;

namespace NationalSpire;

/// <summary>把游戏富文本转换为可用于资料和模型输入的牌面文字，保留图标代表的数量。</summary>
public static class GameText
{
    private static readonly Regex Images = new(@"\[img[^\]]*\](.*?)\[/img\]", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
    private static readonly Regex Resources = new(@"res://[A-Za-z0-9_./-]+?\.(?:png|webp|svg|tres|jpg)|uid://[A-Za-z0-9]+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex Tags = new(@"\[[^\]]*\]", RegexOptions.Compiled);
    private static string Icon(string path) => path.Contains("energy", StringComparison.OrdinalIgnoreCase) ? "\uE000" : path.Contains("star_icon", StringComparison.OrdinalIgnoreCase) ? "\uE001" : "";
    public static string Plain(string text)
    {
        string value = Images.Replace(text, m => Icon(m.Groups[1].Value));
        value = Resources.Replace(value, m => Icon(m.Value));
        value = Tags.Replace(value, "");
        foreach (var (symbol, unit) in new[] { ('\uE000', "能量"), ('\uE001', "辉星") })
            value = Regex.Replace(value, @"(?<number>\d+|X)?[ \t]*(?<icons>" + symbol + @"(?:[ \t]*" + symbol + @")*)", m =>
                (m.Groups["number"].Success ? m.Groups["number"].Value : m.Groups["icons"].Value.Count(c => c == symbol).ToString()) + "点" + unit);
        return Regex.Replace(value, @"[ \t]{2,}", " ").Trim();
    }
}
