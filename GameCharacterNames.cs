using Godot;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using System.Text.Json;

namespace NationalSpire;

// 原始资源单独读取，不修改游戏的共享本地化表。缓存只含原版名称，按语言失效。
public static class GameCharacterNames
{
    private static readonly object Gate = new();
    private static string? _language;
    private static IReadOnlyDictionary<string, string> _originals = new Dictionary<string, string>();
    public static bool IsOriginal(Type type) => type.Assembly == typeof(CharacterModel).Assembly;
    public static IReadOnlyDictionary<string, string> Originals()
    {
        string language = LocManager.Instance.Language;
        lock (Gate)
        {
            if (_language == language) return _originals;
            using var total = UiPerformance.Measure(UiPerformance.Work.CharacterPrepare);
            Dictionary<string, string> english = Read("eng"), localized = language == "eng" ? english : Read(language);
            using var classify = UiPerformance.Measure(UiPerformance.Work.CharacterClassify);
            var names = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var type in typeof(CharacterModel).Assembly.GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(CharacterModel))))
            {
                var id = ModelDb.GetId(type);
                var registered = ModelDb.GetByIdOrNull<CharacterModel>(id);
                if (registered != null && !IsOriginal(registered.GetType())) continue;
                string key = id.Entry + ".title";
                string? name = localized.GetValueOrDefault(key) ?? english.GetValueOrDefault(key);
                if (name == null) continue;
                names[id.ToString()] = name; names[id.Entry] = name;
            }
            _originals = names; _language = language;
            return names;
        }
    }
    private static Dictionary<string, string> Read(string language)
    {
        string text;
        using (UiPerformance.Measure(UiPerformance.Work.CharacterResourceRead))
        {
            using var file = Godot.FileAccess.Open("res://localization/" + language + "/characters.json", Godot.FileAccess.ModeFlags.Read);
            if (file == null) return new();
            text = file.GetAsText();
        }
        using var parse = UiPerformance.Measure(UiPerformance.Work.CharacterResourceParse);
        return JsonSerializer.Deserialize<Dictionary<string, string>>(text)!;
    }
    public static IEnumerable<CharacterDefinition> Definitions(IEnumerable<CharacterModel> characters)
    {
        using var cost = UiPerformance.Measure(UiPerformance.Work.CharacterDefinitions);
        return characters.Select(c => new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText())).ToArray();
    }
}
