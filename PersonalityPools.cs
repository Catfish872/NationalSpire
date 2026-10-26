using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalSpire;

public sealed class PersonalityPool
{
    public string Format { get; set; } = "national-spire-personalities";
    public int Version { get; set; } = 1;
    public List<PersonalityCategory> Categories { get; set; } = [];
}
public sealed class PersonalityCategory
{
    public string Id { get; set; } = "category_" + Guid.NewGuid().ToString("N");
    public string Name { get; set; } = "新类别";
    public string Gender { get; set; } = "女";
    public double Weight { get; set; } = 1;
    public string Prompt { get; set; } = "";
    public List<PersonalityStyle> Styles { get; set; } = [];
}
public sealed class PersonalityStyle
{
    public string Id { get; set; } = "style_" + Guid.NewGuid().ToString("N");
    public string Name { get; set; } = "新性格";
    public double Weight { get; set; } = 1;
    public string Prompt { get; set; } = "";
}
public sealed class PersonalitySelection
{
    public string CategoryId { get; set; } = "";
    public string CategoryName { get; set; } = "";
    public string Gender { get; set; } = "";
    public string StyleId { get; set; } = "";
    public string StyleName { get; set; } = "";
    public string CategoryPrompt { get; set; } = "";
    public string StylePrompt { get; set; } = "";
}

/// <summary>两级权重抽样与性别约束共用入口；角色保存所选提示词快照，独立于编辑池后续变化。</summary>
public static class PersonalityPools
{
    public const string NeutralGender = "中性";
    public static readonly string[] Genders = ["男", "女", NeutralGender];
    public static bool AllowsGender(string categoryGender, string personGender) =>
        personGender is "男" or "女" && (categoryGender == NeutralGender || categoryGender == personGender);
    public static readonly JsonSerializerOptions Json = new() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow };
    public static PersonalityPool Defaults() => new() { Categories = [
        new() { Id = "male", Name = "男性风格", Gender = "男", Prompt = "按人物已有的经历、性格及关系自然表达，保持个人说话习惯。", Styles = [new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }] },
        new() { Id = "female", Name = "女性风格", Gender = "女", Prompt = "语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。", Styles = [
            new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" },
            new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" },
            new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" },
            new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" },
            new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" }
        ] }
    ] };
    public static void Validate(PersonalityPool pool)
    {
        if (pool == null || pool.Format != "national-spire-personalities" || pool.Version != 1 || pool.Categories == null || pool.Categories.Count is < 1 or > 256)
            throw new InvalidDataException("请选择有效的性格池 JSON，包含 1—256 个类别。");
        bool Weight(double w) => double.IsFinite(w) && w is >= 0 and <= 1000000;
        bool Text(string s, int max) => s != null && s.Length <= max && s.All(c => !char.IsControl(c) || c is '\n' or '\r' or '\t');
        bool Id(string id) => id != null && id.Length is >= 1 and <= 64 && id[0] is >= 'a' and <= 'z'
            && id.All(c => c is >= 'a' and <= 'z' or >= '0' and <= '9' or '_');
        if (pool.Categories.Select(c => c?.Id).Distinct().Count() != pool.Categories.Count) throw new InvalidDataException("类别 ID 应各不相同。");
        foreach (var c in pool.Categories)
        {
            if (c == null || !Id(c.Id) || !Text(c.Name, 80) || string.IsNullOrWhiteSpace(c.Name) || !Genders.Contains(c.Gender)
                || !Weight(c.Weight) || !Text(c.Prompt, 16000) || c.Styles == null || c.Styles.Count is < 1 or > 512)
                throw new InvalidDataException("请检查类别名称、ID、适用性别、权重及具体性格列表。");
            if (c.Styles.Select(s => s?.Id).Distinct().Count() != c.Styles.Count || c.Styles.Any(s => s == null || !Id(s.Id)
                || !Text(s.Name, 80) || string.IsNullOrWhiteSpace(s.Name) || !Weight(s.Weight) || !Text(s.Prompt, 16000)))
                throw new InvalidDataException(c.Name + "：具体性格需要独立 ID、名称、有效权重和提示词。");
            if (c.Weight > 0 && !c.Styles.Any(s => s.Weight > 0)) throw new InvalidDataException(c.Name + "：请为至少一种性格设置正权重。");
        }
        if (!pool.Categories.Any(c => c.Weight > 0)) throw new InvalidDataException("请为至少一个类别设置正权重。");
    }
    public static string Export(PersonalityPool pool) { Validate(pool); return JsonSerializer.Serialize(pool, Json); }
    public static PersonalityPool Import(string text)
    {
        if (text.Length > 8 * 1024 * 1024) throw new InvalidDataException("性格池文件超过 8 MiB，请拆分后导入。");
        var pool = JsonSerializer.Deserialize<PersonalityPool>(text, Json) ?? throw new InvalidDataException("性格池为空。"); Validate(pool); return pool;
    }
    public static PersonalityPool Read(AiOptions options) => Coop.CoopJson.Copy(options.PersonalityPool ?? Defaults());
    private static T Pick<T>(IEnumerable<T> items, Func<T, double> weight, double sample)
    {
        var choices = items.Where(i => weight(i) > 0).ToArray(); double total = choices.Sum(weight), remaining = sample * total;
        foreach (var choice in choices) { remaining -= weight(choice); if (remaining < 0) return choice; }
        return choices[^1];
    }
    public static PersonalityCategory? Category(CareerData data, string id)
    {
        if (data.NpcPersonalityPool == null) return null;
        var random = new Random(CareerEngine.StableHash(data.WorldId + ":personality-category:" + id));
        return Pick(data.NpcPersonalityPool.Categories, c => c.Weight, random.NextDouble());
    }
    public static void Assign(CareerData data, CareerPerson person)
    {
        if (person.Personality.Selection != null || person.EditedCard || person.CreatedCard || person.CameoId.Length > 0 || GroupChats.IsHuman(data, person.Id)) return;
        var category = Category(data, person.Id); if (category == null || !AllowsGender(category.Gender, person.Gender)) return;
        var random = new Random(CareerEngine.StableHash(data.WorldId + ":personality-style:" + person.Id));
        Select(person.Personality, category, Pick(category.Styles, s => s.Weight, random.NextDouble()));
    }
    public static void Select(PersonalityProfile profile, PersonalityCategory category, PersonalityStyle style) => profile.Selection = new()
    { CategoryId = category.Id, CategoryName = category.Name, Gender = category.Gender, StyleId = style.Id, StyleName = style.Name, CategoryPrompt = category.Prompt, StylePrompt = style.Prompt };
    public static string? SelectionError(PersonalityProfile profile, string gender)
    {
        var s = profile.Selection; if (s == null) return null;
        if (!AllowsGender(s.Gender, gender)) return "所选性格类别的适用性别与人物性别不同，请重新选择性格。";
        try { Validate(new() { Categories = [new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt,
            Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }] }); }
        catch (Exception e) when (e is InvalidDataException or ArgumentException) { return e.Message; }
        return null;
    }
}
