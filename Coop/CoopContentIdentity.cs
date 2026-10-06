using System.Globalization;
using System.Text;

namespace NationalSpire.Coop;

/// <summary>比较发布版本和原版内容标识，不把构建路径、调试信息等 DLL 差异当作玩法差异。</summary>
public static class CoopContentIdentity
{
    public static string Create(string release, uint gameContent, IEnumerable<string>? mods = null)
    {
        string identity = "release/" + release + "/" + gameContent.ToString(CultureInfo.InvariantCulture);
        // 此模组修改原版消息编码，却声明为非玩法模组，原版不会阻止不对称安装。
        var wire = (mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)
            || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)).Distinct().Order(StringComparer.Ordinal);
        string signature = string.Join("\n", wire);
        return signature.Length == 0 ? identity : identity + "/" + Convert.ToHexString(Encoding.UTF8.GetBytes(signature));
    }

    public static string? Difference(string local, string remote)
    {
        if (local == remote) return null;
        string[] host = local.Split('/'), guest = remote.Split('/');
        if (host.Length is < 3 or > 4 || guest.Length is < 3 or > 4 || host[0] != "release" || guest[0] != "release")
            return "国运尖塔使用了不同的旧版校验方式。请双方更新模组并完全重启游戏后重新加入。";
        if (host[1] != guest[1])
            return $"国运尖塔版本不同：房主 {host[1]}，客机 {guest[1]}。请双方更新到同一版本并完全重启游戏。";
        if (host[2] != guest[2])
            return $"原版游戏内容校验不同：房主 {host[2]}，客机 {guest[2]}。请确认游戏分支、游戏版本及影响玩法的模组一致。";
        return "联机消息格式不同：双方的 sts2_lan_connect 模组或协议配置不一致。请双方同时停用该模组，或使用相同版本和配置，完全重启游戏后再加入。共同生涯存档会保留。";
    }
}
