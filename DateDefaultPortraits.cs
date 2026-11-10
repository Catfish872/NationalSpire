using Godot;

namespace NationalSpire;

/// <summary>内置透明人物剪影；作为缺少个人立绘时的展示资源，不写入玩家导入包。</summary>
public static class DateDefaultPortraits
{
    public static PortraitDesign Design(string person) => new() { PersonId = person, SelectedOutfit = "default",
        Emotions = [new() { Id = "neutral", Name = "平淡", Description = "默认人物剪影" }] };
    public static Texture2D Texture(CareerData data, string person)
    {
        string gender = IdentityGender.Of(data, person) == "女" ? "female" : "male";
        using var stream = typeof(DateDefaultPortraits).Assembly.GetManifestResourceStream("NationalSpire.DateDefaults." + gender + ".png")!;
        using var bytes = new MemoryStream(); stream.CopyTo(bytes);
        using var image = new Image();
        if (image.LoadPngFromBuffer(bytes.ToArray()) != Error.Ok) throw new InvalidDataException("默认人物剪影读取失败。");
        return ImageTexture.CreateFromImage(image);
    }
}
