using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void InviteDateParticipant(string offer)
    {
        string host = _privatePerson;
        var appointment = PrivateMessages.Conversation(ViewData, host).Offers.First(o => o.Id == offer);
        var excluded = new GroupChat { Members = DateSceneParty.People(ViewData, appointment, host) };
        GroupMemberPicker(excluded, people =>
        {
            if (people.Count != 1) { Notice("请选择一位受邀者。", true); return; }
            string target = people[0];
            PrivateCommand("dm-date-invite", new() { Offer = offer, Replacement = target }, () =>
            {
                var data = ViewData;
                if (_multiplayer == null) _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, target);
                Notice("邀请已发送，接受后将加入这项约会。", false);
            });
        }, title: "邀请其他人加入约会", single: true);
    }
    private readonly Dictionary<string, (PortraitDesign Design, DateSceneAssets Assets)> _datePartyArt = [];
    private readonly HashSet<string> _dateDefaultPeople = [];
    private List<DateSceneParticipant> DateParticipants() => _datePartyArt.Select(pair => new DateSceneParticipant
    {
        PersonId = pair.Key, Name = CareerEngine.DisplayName(ViewData, pair.Key), OutfitId = pair.Value.Assets.OutfitId,
        DefaultEmotionId = pair.Value.Design.DefaultEmotionId,
        Emotions = pair.Value.Design.Emotions.Where(e => e.Enabled && (_dateDefaultPeople.Contains(pair.Key) || DateSceneAssetStore.SpriteKeys(pair.Value.Assets, pair.Value.Design, e.Id).Any()))
            .ToDictionary(e => e.Id, e => e.Name + "：" + e.Description)
    }).ToList();
    private void LoadDateParty(CareerData data, string host, string offerId)
    {
        _datePartyArt.Clear(); _dateDefaultPeople.Clear();
        var offer = PrivateMessages.Conversation(data, host).Offers.First(o => o.Id == offerId);
        foreach (string person in DateSceneParty.People(data, offer, host))
        {
            var design = person == host ? _dateDesign : PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person);
            var assets = person == host ? _dateAssets! : DateSceneAssetStore.Read(data, person);
            if (design != null) assets.OutfitId = design.SelectedOutfit;
            if (assets.UseDefaultPortrait || design == null || !DateSceneAssetStore.SpriteKeys(assets, design, design.DefaultEmotionId).Any(k => File.Exists(DateSceneAssetStore.BlobPath(assets.Sprites[k]))))
            {
                _dateDefaultPeople.Add(person); design = DateDefaultPortraits.Design(person);
                if (assets.OutfitId.Length == 0) assets.OutfitId = "default";
            }
            if (person == host) _dateDesign = design;
            _datePartyArt[person] = (design!, assets);
        }
    }
    private bool RefreshDateParty()
    {
        var offer = PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer);
        if (offer == null || DateSceneParty.People(ViewData, offer, _datePerson).ToHashSet().SetEquals(_datePartyArt.Keys)) return true;
        try
        {
            if (ConfigureDatePresentation(ViewData, DateSceneParty.People(ViewData, offer, _datePerson),
                () => { if (_dateView != null) RefreshDateParty(); }, CloseDateScene)) return false;
            LoadDateParty(ViewData, _datePerson, _dateOffer);
            _dateView!.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))));
            ApplyDatePortraitPlacements();
            return true;
        }
        catch (Exception e)
        { CloseDateScene(); Notice("参与者资料读取失败：" + e.Message, true); return false; }
    }
    private IReadOnlyList<Texture2D> PartyWaitingTextures(string person)
    {
        if (!_datePartyArt.TryGetValue(person, out var art)) return [];
        if (_dateDefaultPeople.Contains(person)) return [PartyTexture(person, "neutral")];
        var result = new List<Texture2D>();
        foreach (string hash in art.Design.Emotions.Where(e => e.Enabled)
            .SelectMany(e => DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, e.Id)).Select(k => art.Assets.Sprites[k]).Distinct())
        {
            if (_dateMissingTextures.Contains(hash)) continue;
            try
            {
                if (!_dateTextures.TryGetValue(hash, out var texture)) _dateTextures[hash] = texture = DateSceneAssetStore.Texture(hash);
                result.Add(texture);
            }
            catch (Exception e) { _dateMissingTextures.Add(hash); _dateTextureWarning = "部分立绘读取失败：" + e.Message; }
        }
        return result;
    }
    private Texture2D PartyTexture(string person, string emotion)
    {
        if (_dateDefaultPeople.Contains(person))
        {
            string key = "default:" + IdentityGender.Of(ViewData, person);
            if (!_dateTextures.TryGetValue(key, out var fallback)) _dateTextures[key] = fallback = DateDefaultPortraits.Texture(ViewData, person);
            return fallback;
        }
        if (!_datePartyArt.TryGetValue(person, out var art)) art = (_dateDesign!, _dateAssets!);
        var variants = DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion).ToList();
        if (variants.Count == 0) variants = DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, art.Design.DefaultEmotionId).ToList();
        string chosen = variants[Random.Shared.Next(variants.Count)];
        foreach (string hash in new[] { art.Assets.Sprites[chosen] }.Concat(DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, art.Design.DefaultEmotionId).Select(k => art.Assets.Sprites[k])).Distinct())
        {
            if (_dateMissingTextures.Contains(hash)) continue;
            if (_dateTextures.TryGetValue(hash, out var texture)) return texture;
            try { return _dateTextures[hash] = DateSceneAssetStore.Texture(hash); }
            catch (Exception e) { _dateMissingTextures.Add(hash); _dateTextureWarning = "部分立绘读取失败：" + e.Message; }
        }
        _dateDefaultPeople.Add(person);
        _dateTextureWarning = CareerEngine.DisplayName(ViewData, person) + "的个人立绘读取失败，当前使用默认剪影。";
        return PartyTexture(person, "neutral");
    }
}
