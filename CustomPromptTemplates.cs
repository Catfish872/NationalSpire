namespace NationalSpire;

public sealed class CustomPromptTemplate
{
    public string Name { get; set; } = "";
    public string BaseTemplate { get; set; } = PromptLibrary.DefaultTemplate;
    public Dictionary<string, string> Sections { get; set; } = new();
}

public static partial class PromptLibrary
{
    public static bool CanDeleteTemplate(AiOptions options, string id) => !Templates.Any(t => t.Id == id)
        && options.CustomPromptTemplates?.ContainsKey(id) == true;

    public static string DeletionFallback(AiOptions options, string id) =>
        options.CustomPromptTemplates?.TryGetValue(id, out var custom) == true && Templates.Any(t => t.Id == custom.BaseTemplate)
            ? custom.BaseTemplate : DefaultTemplate;

    public static void DeleteTemplate(AiOptions options, string id)
    {
        if (!CanDeleteTemplate(options, id)) throw new ArgumentException("只能删除自建提示词模板。");
        // 先恢复基础模板的独立修改，再清理被删除模板的内容与覆盖项。
        if (TemplateId(options) == id) SelectTemplate(options, DeletionFallback(options, id));
        options.CustomPromptTemplates.Remove(id);
        options.PromptTemplateOverrides?.Remove(id);
    }

    public static IReadOnlyList<PromptTemplate> AvailableTemplates(AiOptions options) => Templates.Concat(
        (options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存"))).ToArray();

    public static string ValidateTemplateName(AiOptions options, string name, string? exceptId = null)
    {
        name = name.Trim();
        if (name.Length is < 1 or > 40 || name.Any(char.IsControl)) throw new ArgumentException("模板名称需要 1—40 个字符。");
        if (AvailableTemplates(options).Any(t => t.Id != exceptId && t.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            throw new ArgumentException("已有同名模板，请换一个名称。");
        return name;
    }

    public static string CreateTemplate(AiOptions options, string name, string baseId)
    {
        name = ValidateTemplateName(options, name);
        if (!AvailableTemplates(options).Any(t => t.Id == baseId)) throw new ArgumentException("请选择基础模板。");
        // 将基础模板的有效内容复制为新模板原文，后续编辑或更新互不影响。
        string builtIn = options.CustomPromptTemplates?.TryGetValue(baseId, out var custom) == true ? custom.BaseTemplate : baseId;
        var source = new AiOptions { PromptTemplate = baseId, CustomPromptTemplates = options.CustomPromptTemplates ?? new(),
            PromptOverrides = baseId == TemplateId(options) ? options.PromptOverrides : options.PromptTemplateOverrides?.GetValueOrDefault(baseId) ?? new() };
        var created = new CustomPromptTemplate { Name = name, BaseTemplate = builtIn,
            Sections = Sections.ToDictionary(s => s.Id, s => Get(source, s.Id)) };
        string id = "custom-" + Guid.NewGuid().ToString("N");
        options.CustomPromptTemplates ??= new(); options.CustomPromptTemplates.Add(id, created);
        SelectTemplate(options, id);
        return id;
    }
}
