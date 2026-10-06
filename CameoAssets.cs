using Godot;

namespace NationalSpire;

public static class CameoAssets
{
    private static readonly Dictionary<string, Texture2D> Cache = new();
    public static AvatarArt? ForPerson(string key)
    {
        var person = CameoContent.People.FirstOrDefault(p => p.Key == key);
        if (person == null) return null;
        if (key != "caichu") return Load(person.Portrait, person.Name);
        try
        {
            return AvatarAssets.LoadCard("COSMIC_INDIFFERENCE", "宇宙冷漠");
        }
        catch (Exception e) { Diagnostics.Error("cameo.card", e); }
        return null;
    }
    public static AvatarArt? ForStory(WeeklySlide slide) => CameoContent.FindStory(slide) is { } story ? Load(story.Image, story.Title) : null;
    private static AvatarArt? Load(string file, string description)
    {
        if (Cache.TryGetValue(file, out var existing) && AvatarAssets.Usable(existing)) return new(existing, CareerVisuals.Teal, description);
        try
        {
            using var stream = typeof(CameoAssets).Assembly.GetManifestResourceStream("NationalSpire.Cameos." + file);
            if (stream == null) return null;
            using var buffer = new MemoryStream(); stream.CopyTo(buffer);
            using var image = new Image();
            var error = file.EndsWith(".jpg", StringComparison.Ordinal) ? image.LoadJpgFromBuffer(buffer.ToArray()) : image.LoadPngFromBuffer(buffer.ToArray());
            if (error != Error.Ok) throw new InvalidDataException("彩蛋图片无法读取：" + file);
            var texture = ImageTexture.CreateFromImage(image); Cache[file] = texture;
            return new(texture, CareerVisuals.Teal, description);
        }
        catch (Exception e) { Diagnostics.Error("cameo.image", e); return null; }
    }
}
