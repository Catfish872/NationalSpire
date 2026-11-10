namespace NationalSpire;

/// <summary>每个生涯、玩家及NPC共用一份单人/多人约会展示偏好；复用形象包与本地素材事务。</summary>
public static class DatePresentation
{
    public enum Source { Default, Current, Library }
    public sealed class Selection
    {
        public string Person { get; init; } = "";
        public Source Portrait { get; set; }
        public string Outfit { get; set; } = "";
        public AppearanceLibrary.Entry? Library { get; set; }
        public string Voice { get; set; } = "";
    }
    public static string[] Pending(CareerData data, IEnumerable<string> people)
        => people.Distinct().Where(p => !DateSceneAssetStore.Read(data, p).PresentationConfirmed).ToArray();
    public static Selection Initial(CareerData data, string person, bool first)
    {
        var assets = DateSceneAssetStore.Read(data, person);
        var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person);
        string outfit = "", selected = design?.SelectedOutfit ?? "";
        if (design != null && (first || !assets.UseDefaultPortrait))
            foreach (var candidate in design.Outfits.OrderByDescending(o => o.Id == selected))
            {
                design.SelectedOutfit = candidate.Id;
                if (DateSceneAssetStore.Ready(assets, design) == null) { outfit = candidate.Id; break; }
            }
        return new() { Person = person, Portrait = outfit.Length > 0 ? Source.Current : Source.Default,
            Outfit = outfit, Voice = first || !DateGameVoices.Ids.Contains(assets.GameVoice) ? DateGameVoices.Default(data, person) : assets.GameVoice };
    }
    public static (PortraitDesign Design, DateSceneAssets Assets) Prepare(CareerData data, Selection selection)
    {
        if (CareerEngine.Person(data, selection.Person) == null || !DateGameVoices.Ids.Contains(selection.Voice)) throw new InvalidDataException("角色或播报口吻已失效，请重新选择。");
        PortraitDesign design; DateSceneAssets assets;
        if (selection.Portrait == Source.Library)
        {
            if (selection.Library == null) throw new InvalidDataException("请选择形象包。");
            (design, assets) = AppearanceLibrary.Prepare(data, selection.Person, AppearanceLibrary.Load(data, selection.Library));
        }
        else
        {
            design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person) ?? PortraitDesigns.Create(data, selection.Person);
            assets = DateSceneAssetStore.Read(data, selection.Person);
            if (selection.Portrait == Source.Current) design.SelectedOutfit = selection.Outfit;
        }
        assets.OutfitId = design.SelectedOutfit;
        if (selection.Portrait != Source.Default && (!design.Outfits.Any(o => o.Id == design.SelectedOutfit) || DateSceneAssetStore.Ready(assets, design) != null))
            throw new InvalidDataException(CareerEngine.DisplayName(data, selection.Person) + "的所选套装缺少可用默认立绘，请选择其他立绘。");
        assets.UseDefaultPortrait = selection.Portrait == Source.Default;
        assets.PresentationConfirmed = true; assets.GameVoice = selection.Voice; assets.OutfitId = design.SelectedOutfit;
        return (design, assets);
    }
    public static void Save(CareerData data, IReadOnlyList<Selection> selections)
    {
        if (!CareerStore.IsCurrent(data)) throw new InvalidOperationException("生涯已切换，请重新打开约会。");
        if (selections.Select(s => s.Person).Distinct().Count() != selections.Count) throw new InvalidDataException("角色选择重复。");
        var prepared = selections.Select(s => (s.Person, Value: Prepare(data, s))).ToArray();
        var installations = new List<CharacterDesignPackage.Installation>();
        try
        {
            foreach (var item in prepared) installations.Add(new(data, item.Person, item.Value.Design, item.Value.Assets));
            foreach (var install in installations) install.Commit();
        }
        finally { foreach (var install in installations.AsEnumerable().Reverse()) install.Dispose(); }
    }
}
