namespace NationalSpire;

/// <summary>以完整分句维护内容库，初始化时合并；运行期间只抽取所需条目。</summary>
internal static class ContentPools
{
    internal static string[] Words(string text) => text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    internal static void Append(Dictionary<string, string[]> target, string text)
    {
        foreach (string row in text.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            int split = row.IndexOf('=');
            string key = row[..split];
            target[key] = target.GetValueOrDefault(key, []).Concat(row[(split + 1)..].Split('|', StringSplitOptions.TrimEntries)).Distinct().ToArray();
        }
    }
}
