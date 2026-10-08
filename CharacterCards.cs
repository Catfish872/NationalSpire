using System.Globalization;
using System.Text.Json;
using NationalSpire.Coop;

namespace NationalSpire;

public sealed class CharacterCardEdit
{
    public bool Create { get; set; }
    public string Target { get; set; } = "";
    public CareerPerson Person { get; set; } = new();
}

/// <summary>角色卡只编辑公开资料和模拟能力，内部身份与既有赛果保持稳定。</summary>
public static class CharacterCards
{
    public static readonly string[] Templates = ["普通玩家", "主播", "解说员", "青训选手", "职业选手", "世界顶尖", "教练", "赛事记者"];
    public static CareerPerson Read(CareerData data, string id)
    {
        if (id != "player")
        {
            var npc = CoopJson.Copy(CareerEngine.Person(data, id) ?? throw new InvalidDataException("人物已不存在。"));
            if (npc.AbilityTemplate.Length == 0 && Templates.Contains(npc.Role)) npc.AbilityTemplate = npc.Role;
            return npc;
        }
        var p = data.PlayerCard == null ? new CareerPerson { Role = "参赛选手", Character = CharacterIdentity.OriginalName(data.SelectedCharacter) ?? (data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "铁甲战士"), Style = "", Id = "player" } : CoopJson.Copy(data.PlayerCard);
        if (data.PlayerCard == null) PersonalityLibrary.Ensure(data, p);
        p.Id = "player"; p.Handle = CareerEngine.Name(data); p.Gender = data.PlayerGender;
        p.HandleAliases = data.PlayerNameAliases.ToList();
        p.Country = data.Esports.Country; p.ClubId = data.Esports.ClubId;
        p.Rating = data.Rating; p.Wins = data.Wins; p.Losses = data.Losses; p.Avatar = CoopJson.Copy(data.SelectedAvatar);
        if (data.PlayerCard == null) p.MaxAscension = Math.Max(0, data.Esports.BestClear);
        return p;
    }
    public static CareerPerson New(CareerData data)
    {
        var p = new CareerPerson { Id = "custom-" + Guid.NewGuid().ToString("N"), Country = data.Esports.Country,
            Gender = "男", Character = "铁甲战士", Style = "偏爱大卡组，选牌积极。" };
        ApplyTemplate(p, "普通玩家"); PersonalityLibrary.Ensure(data, p); return p;
    }
    public static void ApplyTemplate(CareerPerson p, string name)
    {
        if (!Templates.Contains(name)) throw new InvalidDataException("角色模板无效。");
        p.AbilityTemplate = name; p.Role = name; p.CustomClearChance = null;
        (p.MaxAscension, p.Rating, p.Wins, p.Losses) = name switch
        {
            "世界顶尖" => (9, 1660, 90, 270), "职业选手" => (8, 1390, 38, 152),
            "青训选手" => (6, 1110, 15, 110), "主播" => (5, 1090, 18, 142),
            "解说员" or "教练" => (6, 1170, 27, 153), _ => (2, 830, 6, 74)
        };
    }
    public static CharacterCardEdit Decode(string json)
    {
        return JsonSerializer.Deserialize<CharacterCardEdit>(json) ?? throw new InvalidDataException("角色卡为空。");
    }
    public static string Encode(CharacterCardEdit edit)
    {
        var source = edit.Person;
        var publicEdit = new CharacterCardEdit { Target = edit.Target, Create = edit.Create, Person = new()
        {
            Handle = source.Handle, Name = source.Name, Gender = source.Gender, Country = source.Country,
            ClubId = source.ClubId, SupportedClubId = source.SupportedClubId, Role = source.Role,
            AbilityTemplate = source.AbilityTemplate, Character = source.Character, MaxAscension = source.MaxAscension,
            Rating = source.Rating, Wins = source.Wins, Losses = source.Losses, CustomClearChance = source.CustomClearChance,
            Style = source.Style, Temperament = source.Temperament, Voice = source.Voice, Biography = source.Biography,
            Personality = source.Personality, Avatar = source.Avatar
        } };
        string json = JsonSerializer.Serialize(publicEdit, CoopJson.Options);
        return json;
    }
    public static string? ClubLock(CareerData d, string id)
    {
        if (id == "player")
        {
            if (d.HumanIds.Count > 0) return "多人队伍通过俱乐部合同统一转会。";
            if (d.Esports.OwnedClub != null) return "自建俱乐部由你经营，归属保持不变。";
            if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.PlayerEntered)) return "本赛季已报名，俱乐部与赛区待休赛期调整。";
        }
        if (d.Esports.OwnedClub is { } owned && (owned.Contracts.Any(c => c.PersonId == id) || owned.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id)))
            return "已有俱乐部合同，请通过解约或转会调整归属。";
        return null;
    }
    internal static void CheckImportedFields(CareerData d, CareerPerson person)
    {
        if (Validate(d, new() { Create = true, Target = person.Id, Person = person }, true) is { } error)
            throw new InvalidDataException(error);
    }
    private static string? Validate(CareerData d, CharacterCardEdit edit, bool preview = false)
    {
        if (!preview && d.PendingMatchId != null) return "请在比赛结束后编辑角色。";
        if (edit.Person == null) return "角色资料为空。";
        var p = edit.Person;
        if (edit.Create && (edit.Target.Length != 39 || !edit.Target.StartsWith("custom-", StringComparison.Ordinal) || d.People.Any(x => x.Id == edit.Target))) return "新角色编号无效。";
        if (!edit.Create && edit.Target != "player" && !d.People.Any(p => p.Id == edit.Target)) return "人物已不存在。";
        string[] fields = [p.Handle, p.Name, p.Role, p.Country, p.Character, p.Style, p.Temperament, p.Voice, p.Biography, p.SupportedClubId, p.ClubId, p.AbilityTemplate];
        if (fields.Any(s => s == null || s.Length > 1200 || s.Any(c => char.IsControl(c) && c != '\n'))) return "文字过长或包含无效字符。";
        if (string.IsNullOrWhiteSpace(p.Handle) || new StringInfo(p.Handle.Trim()).LengthInTextElements > 32 || p.Handle.Any(c => c is '[' or ']' or '<' or '>' || char.IsControl(c) || char.GetUnicodeCategory(c) == UnicodeCategory.Format)) return "游戏 ID 请填写 1—32 个可见字符。";
        if (p.Name.Length > 64 || p.Role.Length is 0 or > 40 || p.Character.Length is 0 or > 120) return "请检查姓名、职业和擅长角色。";
        if (!preview && (d.People.Where(x => x.Id != edit.Target && !(edit.Target == "player" && x.Id == d.LocalHumanId)).Any(x => x.PublicName.Equals(p.Handle.Trim(), StringComparison.OrdinalIgnoreCase) || x.HandleAliases.Contains(p.Handle.Trim(), StringComparer.OrdinalIgnoreCase)) || edit.Target != "player" && p.Handle.Trim().Equals(CareerEngine.Name(d), StringComparison.OrdinalIgnoreCase))) return "这个游戏 ID 已有人使用。";
        if (!EsportsWorld.Countries.Contains(p.Country) || !IdentityGender.Choices.Contains(p.Gender)) return "请选择赛区和性别。";
        if (p.AbilityTemplate.Length > 0 && !Templates.Contains(p.AbilityTemplate)) return "能力模板无效。";
        if (p.MaxAscension is < 0 or > 10 || p.Rating is < 0 or > 100000 || p.Wins is < 0 or > 1000000 || p.Losses is < 0 or > 1000000) return "进阶、评分或胜负场数超出范围。";
        if (p.CustomClearChance is { } rate && (!double.IsFinite(rate) || rate < 0 || rate > 1)) return "模拟通关率应在 0%—100% 之间。";
        if (p.Personality == null || p.Personality.AttitudeMin < -5 || p.Personality.AttitudeMax > 5 || p.Personality.AttitudeMin > -1 || p.Personality.AttitudeMax < 1) return "态度下界为 -5 至 -1，上界为 1 至 5。";
        if (p.Personality.Dimensions().Append(p.Personality.Kind).Any(s => s == null || s.Length > 1200)) return "性格描述过长。";
        if (p.ClubId.Length > 0 && EsportsWorld.Club(d, p.ClubId) == null || p.SupportedClubId.Length > 0 && EsportsWorld.Club(d, p.SupportedClubId) == null) return "俱乐部已不存在。";
        var old = edit.Create ? null : Read(d, edit.Target);
        bool changedClub = old?.ClubId != p.ClubId;
        if (old != null && (changedClub || edit.Target == "player" && p.Country != old.Country) && ClubLock(d, edit.Target) is { } locked) return locked;
        if (changedClub && p.ClubId.Length > 0 && p.ClubId == d.Esports.OwnedClub?.ClubId) return "加入自建俱乐部请在自由市场签约。";
        try { p.Avatar.Validate(); } catch { return "头像数据无效，请重新选择。"; }
        return null;
    }
    public static string? Apply(CareerData d, CharacterCardEdit edit)
    {
        if (Validate(d, edit) is { } error) return error;
        var input = edit.Person;
        var p = edit.Create ? new CareerPerson { Id = edit.Target, CreatedCard = true } : Read(d, edit.Target);
        if (p.PublicName.Length > 0 && p.PublicName != input.Handle.Trim() && !p.HandleAliases.Contains(p.PublicName)) p.HandleAliases.Add(p.PublicName);
        p.Identities = p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct().ToList();
        p.Handle = input.Handle.Trim(); p.Name = input.Name.Trim(); p.Gender = p.CameoId.Length > 0 ? "男" : input.Gender;
        if (edit.Target != "player" && p.Gender == IdentityGender.Unset) p.Gender = IdentityGender.Assigned(d, p.Id);
        p.Role = input.Role.Trim(); p.AbilityTemplate = input.AbilityTemplate; p.CustomClearChance = input.CustomClearChance;
        p.Country = input.Country; p.Region = input.Country + "赛区"; p.ClubId = input.ClubId; p.SupportedClubId = input.SupportedClubId;
        p.Character = input.Character.Trim(); p.Style = input.Style.Trim(); p.Temperament = input.Temperament.Trim(); p.Voice = input.Voice.Trim();
        p.Biography = input.Biography.Trim(); p.Personality = CoopJson.Copy(input.Personality); p.Personality.Version = PersonalityLibrary.Version;
        p.Avatar = CoopJson.Copy(input.Avatar); p.Wins = input.Wins; p.Losses = input.Losses; p.Rating = input.Rating; p.MaxAscension = input.MaxAscension;
        p.RecordVersion = NpcRecords.Version; p.EditedCard = true; p.AiIntroduction = ""; p.IntroductionDay = 0;
        if (edit.Target == "player")
        {
            d.PlayerCard = p; d.PlayerAlias = p.Handle; d.PlayerGender = p.Gender; d.SelectedAvatar = p.Avatar; d.PlayerNameAliases = p.HandleAliases;
            d.Rating = p.Rating; d.Wins = p.Wins; d.Losses = p.Losses;
            bool affiliationChanged = d.Esports.ClubId != p.ClubId || d.Esports.Country != p.Country;
            d.Esports.ClubId = p.ClubId; d.Esports.Country = p.Country;
            if (affiliationChanged) { d.Esports.PlayerContract = null; d.Esports.Offers.Clear(); }
            d.PlayerIntroduction = "";
        }
        else
        {
            d.People = d.People.Where(x => x.Id != p.Id).Append(p).ToList();
            CircuitPeople.Replenish(d);
            foreach (var m in d.Matches.Where(m => m.OpponentId == p.Id && m.Status == "待赛"))
            { m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; }
        }
        return null;
    }
    public static string? Save(CareerData d, CharacterCardEdit edit)
    {
        var before = CoopJson.Copy(d);
        if (Apply(d, edit) is { } error) return error;
        try { CareerStore.Save(d); return null; }
        catch (Exception e)
        {
            d.People = before.People; d.Matches = before.Matches; d.Esports = before.Esports; d.PlayerCard = before.PlayerCard;
            d.PlayerAlias = before.PlayerAlias; d.PlayerGender = before.PlayerGender; d.SelectedAvatar = before.SelectedAvatar;
            d.PlayerNameAliases = before.PlayerNameAliases; d.Rating = before.Rating; d.Wins = before.Wins; d.Losses = before.Losses; d.PlayerIntroduction = before.PlayerIntroduction;
            Diagnostics.Error("character-card.save", e); return "角色未能保存，请重试。";
        }
    }
}
