using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Godot;

namespace NationalSpire;

/// <summary>每个世界、玩家及角色独立的本地美术设计；原子保存，不广播聊天或改变生涯规则。</summary>
public static class PortraitDesignStore
{
    public static string Key(CareerData data, string person) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(
        JsonSerializer.Serialize(new[] { data.WorldId, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person })))).ToLowerInvariant();
    public static string FilePath(CareerData data, string person) => System.IO.Path.Combine(ProjectSettings.GlobalizePath("user://national_spire_portraits"), Key(data, person) + ".json");
    public static PortraitDesign? Read(string path, string person)
    {
        if (!File.Exists(path)) return null;
        var design = JsonSerializer.Deserialize<PortraitDesign>(File.ReadAllText(path), PortraitDesigns.Json) ?? throw new InvalidDataException("立绘资料为空。");
        if (design.PersonId != person || design.Version != 1) throw new InvalidDataException("立绘资料的角色或版本不匹配。");
        design.Basics ??= []; design.Emotions ??= []; design.Outfits ??= [];
        design.StyleGroups ??= [];
        if (design.Outfits.Count == 0 || !design.Outfits.Any(o => o.Id == design.SelectedOutfit)) throw new InvalidDataException("立绘资料缺少当前套装。");
        foreach (var outfit in design.Outfits) outfit.Fields ??= [];
        PortraitDesigns.UpgradeDefaults(design);
        return design;
    }
    public static void Save(string path, PortraitDesign design)
    {
        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path)!);
        string temporary = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try { File.WriteAllText(temporary, JsonSerializer.Serialize(design, PortraitDesigns.Json), new UTF8Encoding(false)); File.Move(temporary, path, true); }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
}
