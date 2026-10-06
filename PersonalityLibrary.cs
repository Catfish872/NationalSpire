namespace NationalSpire;

public sealed class PersonalityProfile
{
    public int Version { get; set; }
    public string Kind { get; set; } = "";
    public int AttitudeMin { get; set; }
    public int AttitudeMax { get; set; }
    public string Evidence { get; set; } = "";
    public string Social { get; set; } = "";
    public string Pressure { get; set; } = "";
    public string Humor { get; set; } = "";
    public string Loyalty { get; set; } = "";
    public string Curiosity { get; set; } = "";
    public IEnumerable<string> Dimensions() => new[] { Evidence, Social, Pressure, Humor, Loyalty, Curiosity };
}

public static partial class PersonalityLibrary
{
    public const int Version = 3;
    public const int MinimumAttitude = -5, MaximumAttitude = 5;
    // 仅随社区人物资料提供一次；数值表示倾向，具体表达由人物性格决定。
    public const string AttitudeScale = "attitude是人物持续的态度倾向，范围[-5,5]。负值偏向不满、质疑，正值偏向喜欢、支持；绝对值越大越强烈，0表示没有明显正负倾向。态度在不同帖子间延续，涉及玩家时随双方好感变化。人物结合性格和已有发言表达对具体事情的看法。";
    // 存档版本与随机范围仅供程序使用，人物资料只发送有含义的性格维度。
    public static object PromptProfile(PersonalityProfile p) => new
    {
        性格类型 = p.Kind, 判断事情的习惯 = p.Evidence, 交往习惯 = p.Social,
        面对压力 = p.Pressure, 玩笑偏好 = p.Humor, 亲疏立场 = p.Loyalty, 求知倾向 = p.Curiosity,
        性格使用说明 = "性格内容服务于玩家命令与指令，以及其他优先级更高的提示。先遵循这些要求并结合当前情境，不冲突时才参考性格。"
    };
    public static string AttitudeMeaning(int value) => value switch
    {
        <= -4 => "强烈不满，容易挑衅或嘲讽", -3 => "明显不满，容易质疑或反驳", -2 => "有些不满或戒备",
        -1 => "略有保留或不耐烦", 0 => "没有明显正负倾向", 1 => "略有好意", 2 => "愿意亲近或认可",
        3 => "明显喜欢或支持", 4 => "很喜欢，容易偏心维护", _ => "非常喜欢，容易热烈维护或吹捧"
    };
    private sealed record Disposition(string Name, int Min, int Max, string Social);
    public static int Combinations => Dispositions.Length * Banks.Aggregate(1, (n, bank) => n * bank.Length);
    public static string[] Kinds => Dispositions.Select(d => d.Name).ToArray();
    public static void SelectKind(PersonalityProfile profile, string kind)
    {
        var value = Dispositions.First(d => d.Name == kind);
        profile.Version = Version; profile.Kind = value.Name;
        profile.AttitudeMin = Math.Min(-1, value.Min); profile.AttitudeMax = Math.Max(1, value.Max); profile.Social = value.Social;
    }
    public static bool NeedsUpgrade(CareerData data) => data.People.Any(p => !data.HumanIds.Contains(p.Id) && p.Personality.Version < Version);
    public static void EnsureAll(CareerData data)
    {
        foreach (var person in data.People.Where(p => !data.HumanIds.Contains(p.Id))) Ensure(data, person);
    }
    public static void Ensure(CareerData data, CareerPerson person)
    {
        NormalizeRange(person.Personality);
        if (person.EditedCard || person.Personality.Version >= Version) return;
        var random = new Random(CareerEngine.StableHash(WorldKey(data) + ":personality-v3:" + person.Id));
        var disposition = Dispositions[random.Next(Dispositions.Length)];
        // 彩蛋原文明确规定的性格优先，身份、经历和原文不参与重置。
        if (person.CameoId == "guangtou") disposition = Dispositions.Single(d => d.Name == "热心同好");
        string Pick(int dimension) => Banks[dimension][random.Next(Banks[dimension].Length)];
        person.Personality = new()
        {
            Version = Version, Kind = disposition.Name, AttitudeMin = Math.Min(-1, disposition.Min), AttitudeMax = Math.Max(1, disposition.Max),
            Social = disposition.Social, Evidence = Pick(0), Pressure = Pick(1), Humor = Pick(2), Loyalty = Pick(3), Curiosity = Pick(4)
        };
        if (person.CameoId == "weijimi") person.Personality.Pressure = "依赖关键牌，抓到关键牌时会惊声尖叫，兴奋很容易传到说话里。";
    }
    private static string WorldKey(CareerData data) => data.AvatarWorldId.Length > 0 ? data.AvatarWorldId : data.WorldId;
    public static void NormalizeRange(PersonalityProfile profile)
    { profile.AttitudeMin = Math.Clamp(profile.AttitudeMin, -5, -1); profile.AttitudeMax = Math.Clamp(profile.AttitudeMax, 1, 5); }
    public static int WeightedAttitude(int min, int max, int favour, double sample)
    {
        min = Math.Clamp(min, -5, -1); max = Math.Clamp(max, 1, 5);
        double lambda = 5 * Math.Pow(Math.Clamp(favour, -100, 100) / 100.0, 3);
        var weights = Enumerable.Range(min, max - min + 1).Select(k => Math.Exp(lambda * k)).ToArray();
        double threshold = Math.Clamp(sample, 0, .999999999999) * weights.Sum();
        for (int i = 0; i < weights.Length; i++) { threshold -= weights[i]; if (threshold < 0) return min + i; }
        return max;
    }
    public static int Attitude(CareerData data, string personId, PersonalityProfile profile, string occasion, int favour = 0)
    {
        // 同份材料重试保持人物条件，新的事件或留言独立取值；不向记忆写入内部参数。
        var random = new Random(CareerEngine.StableHash(WorldKey(data) + ":attitude-v3:" + occasion + ":" + personId));
        return WeightedAttitude(profile.AttitudeMin, profile.AttitudeMax, favour, random.NextDouble());
    }
    public static int CommunityAttitude(CareerData data, string personId, PersonalityProfile profile, string target = "community", int favour = 0)
    {
        if (target == "player" && data.LocalHumanId.Length > 0) target = data.LocalHumanId;
        // 每组人物关系使用固定的初始样本，重启、换帖、切换模板均不重新取样。
        // 好感变化只重新计算同一样本的位置，正向变化不会使态度降低。
        var initial = new Random(CareerEngine.StableHash(WorldKey(data) + ":community-attitude:" + personId + ":" + target));
        return WeightedAttitude(profile.AttitudeMin, profile.AttitudeMax, favour, initial.NextDouble());
    }
}

