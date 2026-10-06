using System.Globalization;

namespace NationalSpire;

public static class CareerNames
{
    public static string? Validate(CareerData data, string value)
    {
        string name = value.Trim();
        if (name.Length == 0) return "请输入新的游戏名。";
        if (new StringInfo(name).LengthInTextElements > 32) return "游戏名最多填写 32 个字符。";
        if (name.Any(c => char.IsControl(c) || c is '[' or ']' or '<' or '>' || char.GetUnicodeCategory(c) == UnicodeCategory.Format))
            return "游戏名不能包含换行、隐藏字符或标记符号。";
        if (data.People.Any(p => p.HandleAliases.Append(p.PublicName).Append(p.Name).Contains(name, StringComparer.OrdinalIgnoreCase)))
            return "这个名字已有其他人物使用，请换一个名字。";
        return null;
    }
    public static string? Rename(CareerData data, string value)
    {
        string name = value.Trim();
        if (Validate(data, name) is { } error) return error;
        string old = CareerEngine.Name(data);
        if (old == name) return null;
        var previous = data.PlayerAlias; var aliases = data.PlayerNameAliases.ToList();
        if (!data.PlayerNameAliases.Contains(old, StringComparer.OrdinalIgnoreCase)) data.PlayerNameAliases.Add(old);
        data.PlayerAlias = name;
        try { CareerStore.Save(data); }
        catch { data.PlayerAlias = previous; data.PlayerNameAliases = aliases; return "改名未能保存，请检查存档文件夹的写入权限。"; }
        return null;
    }
}
