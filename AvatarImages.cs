using Godot;

namespace NationalSpire;

public static class AvatarImages
{
    private static readonly Dictionary<string, AvatarArt> Cache = [];
    public static PlayerAvatar FromFile(string path)
    {
        string extension = Path.GetExtension(path).ToLowerInvariant();
        using var image = new Image(); byte[] bytes = File.ReadAllBytes(path);
        var error = extension switch { ".png" => image.LoadPngFromBuffer(bytes), ".jpg" or ".jpeg" => image.LoadJpgFromBuffer(bytes), ".webp" => image.LoadWebpFromBuffer(bytes), _ => Error.FileUnrecognized };
        if (error != Error.Ok) throw new ArgumentException("无法读取图片，请选择 PNG、JPG 或 WebP 图片。");
        return FromImage(image, "image", "自定义头像");
    }
    public static PlayerAvatar FromArt(AvatarArt art, string source)
    {
        if (!AvatarAssets.Usable(art.Texture)) throw new ArgumentException("这张图片当前不可用。");
        using var image = TextureImage(art.Texture!);
        return FromImage(image, source, art.Description);
    }
    public static PlayerAvatar FromCardPng(byte[] png)
    {
        using var image = new Image();
        if (image.LoadPngFromBuffer(png) != Error.Ok) throw new InvalidDataException("无法解码角色卡头像。");
        return FromImage(image, "image", "角色卡头像");
    }
    public static async Task<PlayerAvatar> FromCharacterCardArt(Node owner, AvatarArt art)
    {
        if (AvatarAssets.Usable(art.Texture)) return FromArt(art, "image");
        // 未安装对应角色资源时，将界面实际显示的默认头像绘制为图片。
        var viewport = new SubViewport { Size = new(192, 192), TransparentBg = true, Disable3D = true,
            RenderTargetUpdateMode = SubViewport.UpdateMode.Once };
        owner.AddChild(viewport);
        try
        {
            viewport.AddChild(new CareerAvatar { Size = new(192, 192), Art = art });
            await owner.ToSignal(RenderingServer.Singleton, RenderingServer.SignalName.FramePostDraw);
            using var image = viewport.GetTexture().GetImage();
            return FromImage(image, "image", art.Description);
        }
        finally { viewport.QueueFree(); }
    }
    private static Image TextureImage(Texture2D texture)
    {
        // 原版卡图使用压缩图集；AtlasTexture.GetImage 直接裁剪会得到空图，先解压图集再取区域。
        if (texture is AtlasTexture atlas)
        {
            using var source = TextureImage(atlas.Atlas);
            var region = atlas.Region;
            if (region.Size.X == 0) region.Size = new(source.GetWidth(), region.Size.Y);
            if (region.Size.Y == 0) region.Size = new(region.Size.X, source.GetHeight());
            return source.GetRegion(new((int)region.Position.X, (int)region.Position.Y, (int)region.Size.X, (int)region.Size.Y));
        }
        var image = texture.GetImage();
        if (image.IsCompressed() && image.Decompress() != Error.Ok) { image.Dispose(); throw new ArgumentException("无法解码这张图片。"); }
        return image;
    }
    public static PlayerAvatar FromImage(Image image, string source, string label)
    {
        if (image.IsEmpty()) throw new ArgumentException("图片尺寸无效。");
        if (image.IsCompressed() && image.Decompress() != Error.Ok) throw new ArgumentException("无法解码这张图片。");
        int edge = Math.Min(image.GetWidth(), image.GetHeight());
        using var square = image.GetRegion(new((image.GetWidth() - edge) / 2, (image.GetHeight() - edge) / 2, edge, edge));
        square.Convert(Image.Format.Rgba8);
        int size = Math.Min(edge, 192); square.Resize(size, size, Image.Interpolation.Lanczos);
        byte[] png = square.SavePngToBuffer();
        while (png.Length > PlayerAvatar.MaxBytes && size > 48) { size = size * 3 / 4; square.Resize(size, size, Image.Interpolation.Lanczos); png = square.SavePngToBuffer(); }
        var avatar = new PlayerAvatar { Source = source, Label = label[..Math.Min(label.Length, 128)], Png = Convert.ToBase64String(png) };
        avatar.Validate(); return avatar;
    }
    public static AvatarArt? Read(PlayerAvatar? avatar)
    {
        if (avatar == null || avatar.Source == "auto") return null;
        if (Cache.TryGetValue(avatar.Png, out var art)) return art;
        try
        {
            avatar.Validate(); using var image = new Image();
            if (image.LoadPngFromBuffer(Convert.FromBase64String(avatar.Png)) != Error.Ok) return null;
            art = new(ImageTexture.CreateFromImage(image), CareerVisuals.Teal, avatar.Label);
            if (Cache.Count >= 32) Cache.Remove(Cache.Keys.First());
            Cache[avatar.Png] = art; return art;
        }
        catch { return null; }
    }
}
