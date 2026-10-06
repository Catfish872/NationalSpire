using Godot;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

public static class AvatarAssets
{
    private static readonly Dictionary<string, AvatarArt> Cache = new(StringComparer.Ordinal);
    public static void Invalidate() { Cache.Clear(); WeeklyCache.Clear(); }
    private static readonly Dictionary<string, AvatarArt> WeeklyCache = new();
    private static readonly Dictionary<string, string> CharacterAliases = new(StringComparer.OrdinalIgnoreCase)
    {
        ["铁甲战士"] = "IRONCLAD", ["静默猎手"] = "SILENT", ["故障机器人"] = "DEFECT",
        ["亡灵契约师"] = "NECROBINDER", ["储君"] = "REGENT"
    };
    public static AvatarArt Load(string character, int variation, bool preferCard, int newsImportance = 0)
    {
        // 每职业复用固定卡面集合，避免人物列表同步加载大量不同纹理。
        variation = preferCard ? (int)((uint)variation % 12) : 0;
        string key = character + ":" + variation + ":" + preferCard + ":" + newsImportance;
        if (Cache.TryGetValue(key, out var cached) && Usable(cached.Texture)) return cached;
        Cache.Remove(key);
        var model = ResolveCharacter(character);
        if (model == null) return Cache[key] = new(null, CareerVisuals.Teal, character.Length == 0 ? "尚无常用角色" : character);
        Color color = CareerVisuals.Teal;
        try { color = model.NameColor.Lightened(.25f); } catch { }
        AvatarArt? Card()
        {
            try
            {
                string rarity = newsImportance >= 3 ? "Rare" : newsImportance == 2 ? "Uncommon" : "Common";
                var cards = model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)
                    .ThenBy(c => CareerEngine.StableHash(variation + ":" + c.Id)).Take(8);
                foreach (var card in cards)
                {
                    try
                    {
                        if (!ResourceLoader.Exists(card.PortraitPath)) continue;
                        if (ResourceLoader.Load<Texture2D>(card.PortraitPath) is { } texture && Usable(texture)) return new(texture, color, model.Title.GetFormattedText() + " · " + card.Title);
                    }
                    catch { /* 缺少卡面时继续查找同职业的其他卡牌。 */ }
                }
            }
            catch { }
            return null;
        }
        if (preferCard && Card() is { } art) return Cache[key] = art;
        try
        {
            // 局内预加载通常只包含玩家职业，对手头像从角色公布的资源路径独立加载。
            foreach (var path in model.AssetPaths.Concat(model.AssetPathsCharacterSelect).Distinct().Where(p => p.Contains("character_icon_", StringComparison.OrdinalIgnoreCase)))
                if (ResourceLoader.Exists(path) && ResourceLoader.Load<Texture2D>(path) is { } texture && Usable(texture))
                    return Cache[key] = new(texture, color, model.Title.GetFormattedText());
            if (model.IconTexture is { } icon && Usable(icon)) return Cache[key] = new(icon, color, model.Title.GetFormattedText());
        }
        catch { /* Mod 角色可能没有原生顶栏头像，改用卡面。 */ }
        if (Card() is { } fallback) return Cache[key] = fallback;
        return Cache[key] = new(null, color, character);
    }
    private static CharacterModel? ResolveCharacter(string character)
    {
        string alias = CharacterAliases.GetValueOrDefault(character, character);
        var model = GameBridge.Characters().FirstOrDefault(c => c.Id.ToString().Equals(alias, StringComparison.OrdinalIgnoreCase)
            || c.Id.Entry.Equals(alias, StringComparison.OrdinalIgnoreCase));
        if (model == null)
        {
            foreach (var candidate in GameBridge.Characters())
            {
                try { if (candidate.Title.GetFormattedText() == character) { model = candidate; break; } }
                catch { /* 单个 Mod 的本地化资源异常不影响其他角色。 */ }
            }
        }
        return model;
    }
    public static AvatarArt? LoadCard(string id, string description)
    {
        string key = "fixed:" + id;
        if (Cache.TryGetValue(key, out var cached) && Usable(cached.Texture)) return cached;
        var card = GameBridge.Characters().SelectMany(c => c.CardPool.AllCards).FirstOrDefault(c => c.Id.Entry == id);
        if (card == null || !ResourceLoader.Exists(card.PortraitPath)) return null;
        var texture = ResourceLoader.Load<Texture2D>(card.PortraitPath);
        return Usable(texture) ? Cache[key] = new(texture, CareerVisuals.Teal, description) : null;
    }
    public static AvatarArt LoadWeekly(CareerData data, WeeklyEdition issue, WeeklySlide slide)
    {
        if (CameoAssets.ForStory(slide) is { } cameo) return cameo;
        var model = ResolveCharacter(slide.Character);
        if (model == null) return Load(slide.Character, 0, true, slide.Importance);
        try
        {
            var cards = model.CardPool.AllCards.DistinctBy(c => c.Id).ToDictionary(c => c.Id.ToString());
            var previousSlides = data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2).SelectMany(w => w.Slides).ToList();
            // 旧刊尚未保存配图标识时，按旧抽取规则恢复其实际封面，供新刊避重。
            foreach (var old in previousSlides.Where(s => s.ArtCardId.Length == 0))
            {
                var oldIssue = data.WeeklyEditions.First(w => w.Slides.Contains(old));
                if (oldIssue.ArtVersion > 0) continue;
                var oldModel = ResolveCharacter(old.Character);
                if (oldModel == null) continue;
                int variant = (int)((uint)CareerEngine.StableHash($"weekly:{oldIssue.Week}:{old.Id}") % 12);
                string rarity = old.Importance >= 3 ? "Rare" : old.Importance == 2 ? "Uncommon" : "Common";
                old.ArtCardId = oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)
                    .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)
                    .FirstOrDefault(c => ResourceLoader.Exists(c.PortraitPath))?.Id.ToString() ?? "";
            }
            var previous = previousSlides.Select(s => s.ArtCardId).Where(id => id.Length > 0);
            var same = issue.Slides.Where(s => s != slide).Select(s => s.ArtCardId).Where(id => id.Length > 0);
            var order = WeeklyArtChoice.Order(cards.Values.Select(c => new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString())),
                slide.Importance, $"{data.WorldId}:weekly:{issue.Week}:{slide.Id}", previous, same);
            if (cards.ContainsKey(slide.ArtCardId)) order = new[] { slide.ArtCardId }.Concat(order).Distinct();
            foreach (string id in order.Take(16))
            {
                var card = cards[id];
                string key = model.Id + ":" + id;
                if (!WeeklyCache.TryGetValue(key, out var art) || !Usable(art.Texture))
                {
                    if (!ResourceLoader.Exists(card.PortraitPath)) continue;
                    try
                    {
                        var texture = ResourceLoader.Load<Texture2D>(card.PortraitPath);
                        if (!Usable(texture)) continue;
                        art = new(texture, model.NameColor.Lightened(.25f), model.Title.GetFormattedText() + " · " + card.Title);
                        if (WeeklyCache.Count >= 64) WeeklyCache.Remove(WeeklyCache.Keys.First());
                        WeeklyCache[key] = art;
                    }
                    catch { continue; }
                }
                if (slide.ArtCardId != id) { slide.ArtCardId = id; CareerStore.Save(data); }
                return art;
            }
        }
        catch (Exception e) { Diagnostics.Error("weekly.art", e); }
        return Load(slide.Character, CareerEngine.StableHash(data.WorldId + issue.Week + slide.Id), true, slide.Importance);
    }
    public static bool Usable(Texture2D? texture) => texture != null && GodotObject.IsInstanceValid(texture) && texture.GetWidth() > 0 && texture.GetHeight() > 0;
}
