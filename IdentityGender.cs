namespace NationalSpire;

/// <summary>性别属于人物身份，不随职业、头像、存档读取或性格变化重新分配。</summary>
public static class IdentityGender
{
    public const string Unset = "未设置";
    public static readonly string[] Choices = [Unset, "男", "女"];
    public static string Assigned(CareerData data, string id) =>
        new Random(CareerEngine.StableHash(data.WorldId + ":gender:" + id)).Next(2) == 0 ? "男" : "女";
    public static string Of(CareerData data, string id)
    {
        if (id == "player") return Choices.Contains(data.PlayerGender) ? data.PlayerGender : Unset;
        var person = CareerEngine.Person(data, id);
        if (person == null) return Unset;
        if (person.CameoId.Length > 0) return "男";
        if (person.Gender is "男" or "女") return person.Gender;
        return data.HumanIds.Contains(id) || id.StartsWith("human-") ? Unset : Assigned(data, id);
    }
    public static void Ensure(CareerData data)
    {
        if (!Choices.Contains(data.PlayerGender)) data.PlayerGender = Unset;
        foreach (var person in data.People)
        {
            if (person.CameoId.Length > 0) person.Gender = "男";
            else if (data.HumanIds.Contains(person.Id) || person.Id.StartsWith("human-"))
            { if (!Choices.Contains(person.Gender)) person.Gender = Unset; }
            else if (person.Gender is not ("男" or "女"))
                person.Gender = HumanNames.KnownGender(person.Country, person.Name) ?? Assigned(data, person.Id);
        }
        var genders = data.People.ToDictionary(p => p.Id, p => p.Gender);
        foreach (var person in data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent))
            if (person.Gender.Length == 0 || person.CameoId.Length > 0)
                person.Gender = genders.GetValueOrDefault(person.Id, Assigned(data, person.Id));
        foreach (var profile in data.WeeklyEditions.SelectMany(w => w.Profiles))
            if (profile.Gender.Length == 0) profile.Gender = Of(data, profile.Id);
    }
    public static string? SetPlayer(CareerData data, string gender)
    {
        if (!Choices.Contains(gender)) return "请选择性别。";
        string previous = data.PlayerGender;
        data.PlayerGender = gender;
        try { CareerStore.Save(data); }
        catch { data.PlayerGender = previous; return "性别未能保存，请重试。"; }
        return null;
    }
}
