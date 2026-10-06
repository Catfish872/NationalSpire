using System.Buffers.Binary;
using System.Text.Json;

namespace NationalSpire;

/// <summary>保存头像副本，不保存文件路径；同一份图像可随多人生涯同步。</summary>
public sealed class PlayerAvatar
{
    public const int MaxBytes = 36 * 1024;
    public const int MaxText = 52000;
    public string Source { get; set; } = "auto";
    public string Label { get; set; } = "自动头像";
    public string Png { get; set; } = "";
    public static PlayerAvatar Read(string json)
    {
        if (json.Length > MaxText) throw new ArgumentException("头像内容过大。");
        var value = JsonSerializer.Deserialize<PlayerAvatar>(json) ?? throw new ArgumentException("头像内容为空。");
        value.Validate(); return value;
    }
    public void Validate()
    {
        if (Source is not ("auto" or "character" or "card" or "steam" or "image") || Label == null || Label.Length > 128 || Png == null)
            throw new ArgumentException("头像设置无效。");
        if (Source == "auto") { if (Png.Length != 0) throw new ArgumentException("自动头像不应包含图片。"); return; }
        if (Png.Length > (MaxBytes + 2) / 3 * 4) throw new ArgumentException("头像图片过大。");
        byte[] bytes;
        try { bytes = Convert.FromBase64String(Png); } catch (FormatException) { throw new ArgumentException("头像图片格式无效。"); }
        if (bytes.Length < 45 || bytes.Length > MaxBytes || !bytes.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })
            || BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(8, 4)) != 13 || !bytes.AsSpan(12, 4).SequenceEqual("IHDR"u8))
            throw new ArgumentException("头像需要有效的 PNG 图片。");
        int width = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(16, 4)), height = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(20, 4));
        if (width < 1 || width > 192 || height != width) throw new ArgumentException("头像尺寸无效。");
        int offset = 8; bool pixels = false, ended = false;
        while (offset <= bytes.Length - 12)
        {
            int length = BinaryPrimitives.ReadInt32BigEndian(bytes.AsSpan(offset, 4));
            if (length < 0 || length > bytes.Length - offset - 12) throw new ArgumentException("头像图片不完整。");
            var type = bytes.AsSpan(offset + 4, 4); pixels |= type.SequenceEqual("IDAT"u8);
            offset += length + 12;
            if (type.SequenceEqual("IEND"u8)) { ended = length == 0 && offset == bytes.Length; break; }
        }
        if (!pixels || !ended) throw new ArgumentException("头像图片不完整。");
    }
}
