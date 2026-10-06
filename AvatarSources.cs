using Godot;
using MegaCrit.Sts2.Core.Models;
using Steamworks;

namespace NationalSpire;

public sealed record AvatarChoice(string Id, string Name, string Group, Func<AvatarArt?> Read);

public static class AvatarSources
{
    public static IReadOnlyList<AvatarChoice> Characters() => GameBridge.Characters().Select(c =>
        new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false))).ToList();
    public static IReadOnlyList<AvatarChoice> Cards()
    {
        var result = new List<AvatarChoice>();
        foreach (var card in ModelDb.AllCards.DistinctBy(c => c.Id))
        {
            try
            {
                string path = card.PortraitPath, name = GameText.Plain(card.Title);
                if (!ResourceLoader.Exists(path)) continue;
                result.Add(new(card.Id.ToString(), name, "卡图", () =>
                    ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null));
            }
            catch { /* 个别模组资源无效时，其余卡图仍可选择。 */ }
        }
        return result.OrderBy(c => c.Name, StringComparer.CurrentCulture).ToList();
    }
    public static async Task<PlayerAvatar> Steam()
    {
        if (!SteamUser.BLoggedOn()) throw new ArgumentException("请先登录 Steam。");
        var id = SteamUser.GetSteamID(); int handle = SteamFriends.GetLargeFriendAvatar(id);
        for (int i = 0; handle == -1 && i < 40; i++) { await Task.Delay(250); handle = SteamFriends.GetLargeFriendAvatar(id); }
        if (handle <= 0 || !SteamUtils.GetImageSize(handle, out uint width, out uint height) || width is 0 or > 192 || height is 0 or > 192)
            throw new ArgumentException("暂时无法取得 Steam 头像，请稍后重试。");
        byte[] rgba = new byte[width * height * 4];
        if (!SteamUtils.GetImageRGBA(handle, rgba, rgba.Length)) throw new ArgumentException("无法读取 Steam 头像。");
        using var image = Image.CreateFromData((int)width, (int)height, false, Image.Format.Rgba8, rgba);
        return AvatarImages.FromImage(image, "steam", "Steam 头像");
    }
}
