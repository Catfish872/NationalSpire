using Godot;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using System.Text.Json;

namespace NationalSpire;

// 名称与生命上限分别缓存；原版名称读取原始资源，生命上限读取当前职业模型，均按语言失效。
public static class GameCharacterNames
{
    private static readonly object Gate = new();
    private static string? _language;
    private static IReadOnlyDictionary<string, string> _originals = new Dictionary<string, string>();
    private static string? _healthLanguage;
    private static IReadOnlyDictionary<string, int> _startingHp = new Dictionary<string, int>();
    public static int StartingHp(string character)
    {
        string language = LocManager.Instance.Language;
        lock (Gate)
        {
            if (_healthLanguage != language)
            {
                var chinese = Read("zhs");
                var english = Read("eng");
                var names = new List<(string Name, int Hp)>();
                foreach (var model in GameBridge.Characters())
                {
                    string key = model.Id.Entry + ".title";
                    foreach (string name in new[] { model.Id.ToString(), model.Id.Entry, model.Title.GetFormattedText(),
                        chinese.GetValueOrDefault(key, ""), english.GetValueOrDefault(key, "") })
                        if (name.Length > 0) names.Add((name, model.StartingHp));
                }
                _startingHp = names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)
                    .Where(g => g.Select(n => n.Hp).Distinct().Count() == 1)
                    .ToDictionary(g => g.Key, g => g.First().Hp, StringComparer.OrdinalIgnoreCase);
                _healthLanguage = language;
            }
            return _startingHp.GetValueOrDefault(character, 75);
        }
    }
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
