using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalSpire;

/// <summary>仅交换可编辑提示词。默认项保留跟随模板更新的语义，不交换账户配置。</summary>
public static class PromptTransfer
{
    public sealed class Bundle
    {
        [JsonRequired] public string Format { get; set; } = "national-spire-prompts";
        [JsonRequired] public int Version { get; set; } = 1;
        [JsonRequired] public string Template { get; set; } = "";
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public CustomPromptTemplate? CustomTemplate { get; set; }
        [JsonRequired] public Dictionary<string, Section> Sections { get; set; } = [];
    }
    public sealed class Section
    {
        [JsonRequired] public bool FollowDefault { get; set; }
        [JsonRequired] public string Text { get; set; } = "";
    }
    private static readonly JsonSerializerOptions Json = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
    };
    public static string Export(AiOptions options, IReadOnlyDictionary<string, string> drafts)
    {
        var bundle = new Bundle { Template = PromptLibrary.TemplateId(options) };
        if (options.CustomPromptTemplates?.TryGetValue(bundle.Template, out var custom) == true)
        { bundle.Version = 2; bundle.CustomTemplate = custom; }
        foreach (var section in PromptLibrary.Sections)
        {
            string text = drafts[section.Id];
            bundle.Sections[section.Id] = new() { Text = text,
                FollowDefault = Normalize(text) == Normalize(PromptLibrary.Default(options, section.Id)) };
        }
        Validate(bundle);
        return JsonSerializer.Serialize(bundle, Json);
    }
    public static Bundle Read(string text)
    {
        var bundle = JsonSerializer.Deserialize<Bundle>(text, Json) ?? throw new ArgumentException("文件中没有提示词内容。");
        Validate(bundle); return bundle;
    }
    private static string Normalize(string text) => text.Replace("\r\n", "\n").Trim();
    private static void Validate(Bundle bundle)
    {
        if (bundle.Sections?.Remove("private-style", out var oldStyle) == true && bundle.Sections.TryGetValue("private", out var guide))
        {
            if (!guide.FollowDefault || !oldStyle.FollowDefault)
            {
                guide.Text = PromptLibrary.MergePrivateText(guide.FollowDefault ? PrivateMessagePrompts.Guide : guide.Text, oldStyle.Text);
                guide.FollowDefault = false;
            }
        }
        if (bundle.CustomTemplate?.Sections?.Remove("private-style", out var customStyle) == true)
            bundle.CustomTemplate.Sections["private"] = PromptLibrary.MergePrivateText(bundle.CustomTemplate.Sections.GetValueOrDefault("private", PrivateMessagePrompts.Guide), customStyle);
        // 旧文件只补新增私信模块，已有模块的完整性检查保持不变。
        foreach (var id in PrivateMessagePrompts.SectionIds)
        {
            var section = PromptLibrary.Sections.First(s => s.Id == id);
            bundle.Sections?.TryAdd(id, new() { FollowDefault = true, Text = section.DefaultText });
            bundle.CustomTemplate?.Sections?.TryAdd(id, section.DefaultText);
        }
        if (bundle.Format != "national-spire-prompts" || bundle.Version is not (1 or 2))
            throw new ArgumentException("不支持此提示词文件格式或版本。");
        if (bundle.Version == 1)
        {
            if (bundle.CustomTemplate != null || !PromptLibrary.Templates.Any(t => t.Id == bundle.Template)) throw new ArgumentException("文件中的提示词模板不存在。");
        }
        else
        {
            var custom = bundle.CustomTemplate;
            if (custom == null || !bundle.Template.StartsWith("custom-", StringComparison.Ordinal) || !Guid.TryParseExact(bundle.Template[7..], "N", out _)
                || !PromptLibrary.Templates.Any(t => t.Id == custom.BaseTemplate)
                || custom.Sections == null || custom.Sections.Count != PromptLibrary.Sections.Count
                || PromptLibrary.Sections.Any(s => !custom.Sections.TryGetValue(s.Id, out var text) || string.IsNullOrWhiteSpace(text)))
                throw new ArgumentException("文件中的自建模板不完整。");
            PromptLibrary.ValidateTemplateName(new(), custom.Name);
        }
        if (bundle.Sections == null || bundle.Sections.Count != PromptLibrary.Sections.Count
            || PromptLibrary.Sections.Any(s => !bundle.Sections.TryGetValue(s.Id, out var item) || item == null || string.IsNullOrWhiteSpace(item.Text)))
            throw new ArgumentException("文件需要包含全部场景，每项提示词不能为空。");
    }
    public static void Apply(AiOptions options, Bundle bundle, string? targetTemplate = null)
    {
        Validate(bundle);
        if (targetTemplate != null)
        {
            if (!PromptLibrary.AvailableTemplates(options).Any(t => t.Id == targetTemplate))
                throw new ArgumentException("请选择已有的目标模板。");
            // 按来源模板解释默认项，再写入目标；不同模板的默认内容不能直接互换标记。
            var source = new AiOptions { PromptTemplate = bundle.Template };
            if (bundle.CustomTemplate is { } definition) source.CustomPromptTemplates[bundle.Template] = definition;
            var texts = bundle.Sections.ToDictionary(p => p.Key,
                p => p.Value.FollowDefault ? PromptLibrary.Default(source, p.Key) : p.Value.Text);
            PromptLibrary.SelectTemplate(options, targetTemplate);
            options.PromptOverrides = texts.Where(p => Normalize(p.Value) != Normalize(PromptLibrary.Default(options, p.Key)))
                .ToDictionary(p => p.Key, p => p.Value);
            options.PrivatePromptVersion = 1;
            return;
        }
        var overrides = bundle.Sections.Where(p => !p.Value.FollowDefault).ToDictionary(p => p.Key, p => p.Value.Text);
        if (bundle.CustomTemplate is { } custom)
        {
            string name = custom.Name.Trim(), original = name;
            int suffix = 2;
            while (PromptLibrary.AvailableTemplates(options).Any(t => t.Id != bundle.Template && t.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                name = original[..Math.Min(original.Length, 32)] + "（" + suffix++ + "）";
            options.CustomPromptTemplates ??= new();
            options.CustomPromptTemplates[bundle.Template] = new() { Name = name, BaseTemplate = custom.BaseTemplate, Sections = new(custom.Sections) };
        }
        PromptLibrary.SelectTemplate(options, bundle.Template);
        options.PromptOverrides = overrides;
        options.PrivatePromptVersion = 1;
    }
    public static string Desktop => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    public static string WriteDesktop(string json)
    {
        if (string.IsNullOrWhiteSpace(Desktop) || !Directory.Exists(Desktop)) throw new IOException("无法找到系统桌面文件夹。");
        string path = Path.Combine(Desktop, $"国运尖塔提示词-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid().ToString("N")[..6]}.json");
        File.WriteAllText(path, json, new System.Text.UTF8Encoding(false)); return path;
    }
}
