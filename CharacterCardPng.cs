using System.Buffers.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalSpire;

/// <summary>PNG 像素保存头像，独立元数据只交换可编辑资料，不交换存档身份与游戏进度。</summary>
public static class CharacterCardPng
{
    private const string Keyword = "national-spire-character";
    private static readonly byte[] Signature = [137, 80, 78, 71, 13, 10, 26, 10];
    private static readonly JsonSerializerOptions Json = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    public sealed class Fields
    {
        public string Handle { get; set; } = "";
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "男";
        public string Country { get; set; } = "中国";
        public string Role { get; set; } = "普通玩家";
        public string AbilityTemplate { get; set; } = "";
        public string Character { get; set; } = "铁甲战士";
        public int MaxAscension { get; set; }
        public int Rating { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public double? CustomClearChance { get; set; }
        public string Style { get; set; } = "";
        public string Temperament { get; set; } = "";
        public string Voice { get; set; } = "";
        public string Biography { get; set; } = "";
        public PersonalityProfile Personality { get; set; } = new();
    }
    public sealed class ClubReference
    {
        public string Name { get; set; } = "";
        public string Country { get; set; } = "";
    }
    public sealed class Bundle
    {
        [JsonRequired] public string Format { get; set; } = "national-spire-character";
        [JsonRequired] public int Version { get; set; } = 1;
        [JsonRequired] public Fields Character { get; set; } = new();
        public ClubReference? Club { get; set; }
        public ClubReference? SupportedClub { get; set; }
    }
    private static ClubReference? Reference(CareerData d, string id)
        => EsportsWorld.Club(d, id) is { } club ? new() { Name = club.Name, Country = club.Country } : null;
    private static string MatchClub(CareerData d, ClubReference? reference, bool affiliation)
    {
        if (reference == null) return "";
        var matches = d.Esports.Clubs.Where(c => c.Name == reference.Name && c.Country == reference.Country).ToArray();
        if (matches.Length != 1 || affiliation && matches[0].Id == d.Esports.OwnedClub?.ClubId) return "";
        return matches[0].Id;
    }
    public static byte[] Export(CareerData d, CareerPerson source, PlayerAvatar portrait)
    {
        portrait.Validate();
        if (portrait.Source == "auto") throw new ArgumentException("请先获取角色的实际头像。");
        var bundle = new Bundle
        {
            Character = JsonSerializer.Deserialize<Fields>(JsonSerializer.Serialize(source, Json), Json)!,
            Club = Reference(d, source.ClubId), SupportedClub = Reference(d, source.SupportedClubId)
        };
        // 名称未编辑过的 NPC 也以当前可见称呼导出。
        if (bundle.Character.Handle.Length == 0) bundle.Character.Handle = source.PublicName;
        var check = JsonSerializer.Deserialize<CareerPerson>(JsonSerializer.Serialize(bundle.Character, Json), Json)!;
        check.Id = "custom-" + Guid.NewGuid().ToString("N"); check.Avatar = portrait;
        CharacterCards.CheckImportedFields(d, check);
        byte[] metadata = Encoding.ASCII.GetBytes(Keyword + "\0" + Convert.ToBase64String(JsonSerializer.SerializeToUtf8Bytes(bundle, Json)));
        byte[] image = Convert.FromBase64String(portrait.Png);
        var chunks = ReadChunks(image);
        using var output = new MemoryStream(); output.Write(Signature);
        foreach (var chunk in chunks)
        {
            if (IsCard(image, chunk.Offset, chunk.Length)) continue;
            if (chunk.Type == "IEND") WriteChunk(output, "tEXt", metadata);
            output.Write(image, chunk.Offset, chunk.Length + 12);
        }
        return output.ToArray();
    }
    public static CareerPerson Import(CareerData d, byte[] file, Func<byte[], PlayerAvatar>? normalizeAvatar = null)
    {
        var chunks = ReadChunks(file);
        Bundle? bundle = null;
        using var picture = new MemoryStream(); picture.Write(Signature);
        foreach (var chunk in chunks)
        {
            if (IsCard(file, chunk.Offset, chunk.Length))
            {
                if (bundle != null) throw new InvalidDataException("图片包含重复的角色资料。");
                int start = chunk.Offset + 8 + Keyword.Length + 1;
                byte[] json;
                try { json = Convert.FromBase64String(Encoding.ASCII.GetString(file, start, chunk.Length - Keyword.Length - 1)); }
                catch (FormatException) { throw new InvalidDataException("图片内的角色资料已损坏。"); }
                try { bundle = JsonSerializer.Deserialize<Bundle>(json, Json); }
                catch (JsonException) { throw new InvalidDataException("图片内的角色资料格式无效。"); }
                if (bundle == null || bundle.Format != Keyword || bundle.Version != 1 || bundle.Character == null)
                    throw new InvalidDataException("不支持这张角色卡的格式或版本。");
            }
            else picture.Write(file, chunk.Offset, chunk.Length + 12);
        }
        if (bundle == null) throw new InvalidDataException("这张图片没有国运尖塔角色资料，请选择导出的原始 PNG 文件。");
        // 只从允许交换的字段建立新角色；额外字段不能恢复旧身份、合同或培养记录。
        var p = JsonSerializer.Deserialize<CareerPerson>(JsonSerializer.Serialize(bundle.Character, Json), Json)!;
        p.Id = "custom-" + Guid.NewGuid().ToString("N");
        p.ClubId = MatchClub(d, bundle.Club, true); p.SupportedClubId = MatchClub(d, bundle.SupportedClub, false);
        byte[] pixels = picture.ToArray();
        p.Avatar = normalizeAvatar != null ? normalizeAvatar(pixels)
            : new() { Source = "image", Label = "角色卡头像", Png = Convert.ToBase64String(pixels) };
        p.Avatar.Validate();
        CharacterCards.CheckImportedFields(d, p);
        return p;
    }
    public static CareerPerson ReadFile(CareerData d, string path, Func<byte[], PlayerAvatar> normalizeAvatar)
    {
        return Import(d, File.ReadAllBytes(path), normalizeAvatar);
    }
    public static string WriteDesktop(byte[] png)
    {
        if (!Directory.Exists(PromptTransfer.Desktop)) throw new IOException("无法找到桌面文件夹。");
        string path = Path.Combine(PromptTransfer.Desktop, $"国运尖塔角色卡-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid():N}.png");
        using var file = new FileStream(path, FileMode.CreateNew, FileAccess.Write); file.Write(png); return path;
    }
    private static bool IsCard(byte[] file, int offset, int length)
        => file.AsSpan(offset + 4, 4).SequenceEqual("tEXt"u8) && length > Keyword.Length
            && file.AsSpan(offset + 8, Keyword.Length + 1).SequenceEqual(Encoding.ASCII.GetBytes(Keyword + "\0"));
    private static List<(int Offset, int Length, string Type)> ReadChunks(byte[] file)
    {
        if (file.Length < 45 || !file.AsSpan(0, 8).SequenceEqual(Signature))
            throw new InvalidDataException("请选择有效的 PNG 角色卡。");
        var chunks = new List<(int Offset, int Length, string Type)>();
        bool header = false, pixels = false, ended = false;
        for (int offset = 8; offset <= file.Length - 12;)
        {
            int length = BinaryPrimitives.ReadInt32BigEndian(file.AsSpan(offset, 4));
            if (length < 0 || length > file.Length - offset - 12) throw new InvalidDataException("PNG 文件不完整。");
            string type = Encoding.ASCII.GetString(file, offset + 4, 4);
            if (Crc(file.AsSpan(offset + 4, length + 4)) != BinaryPrimitives.ReadUInt32BigEndian(file.AsSpan(offset + length + 8, 4)))
                throw new InvalidDataException("PNG 文件校验失败，图片或角色资料已损坏。");
            if (!header)
            {
                if (type != "IHDR" || length != 13) throw new InvalidDataException("PNG 图片头无效。");
                int width = BinaryPrimitives.ReadInt32BigEndian(file.AsSpan(offset + 8, 4));
                int height = BinaryPrimitives.ReadInt32BigEndian(file.AsSpan(offset + 12, 4));
                if (width < 1 || height < 1) throw new InvalidDataException("角色卡头像尺寸无效。");
                header = true;
            }
            else if (type == "IHDR") throw new InvalidDataException("PNG 图片头重复。");
            pixels |= type == "IDAT";
            chunks.Add((offset, length, type)); offset += length + 12;
            if (type == "IEND") { ended = length == 0 && offset == file.Length; break; }
        }
        if (!pixels || !ended) throw new InvalidDataException("PNG 文件不完整。");
        return chunks;
    }
    private static void WriteChunk(Stream output, string type, byte[] bytes)
    {
        Span<byte> number = stackalloc byte[4]; BinaryPrimitives.WriteInt32BigEndian(number, bytes.Length); output.Write(number);
        byte[] content = Encoding.ASCII.GetBytes(type).Concat(bytes).ToArray(); output.Write(content);
        BinaryPrimitives.WriteUInt32BigEndian(number, Crc(content)); output.Write(number);
    }
    private static uint Crc(ReadOnlySpan<byte> bytes)
    {
        uint crc = uint.MaxValue;
        foreach (byte b in bytes) { crc ^= b; for (int bit = 0; bit < 8; bit++) crc = (crc >> 1) ^ ((crc & 1) != 0 ? 0xedb88320u : 0); }
        return ~crc;
    }
}
