namespace NationalSpire;

/// <summary>新世界配置；仅在生成入口使用本地文件路径，世界中保存人物资料及性格池快照。</summary>
public sealed class NpcGenerationSetup
{
    public PersonalityPool Pool { get; set; } = PersonalityPools.Defaults();
    public List<OpeningRole> SavedRoles { get; set; } = [];
    public List<string> ExcludedPacks { get; set; } = [];
    public List<string> Files { get; set; } = [];
    public int RivalLevel { get; set; } = 1000;
    public AiOptions? Ai { get; set; }
    public CareerOpeningPlayer Personal { get; set; } = new();
    public CareerOpeningWorld World { get; set; } = new();
    public string? TeamCountry { get; set; }
    public string? WorldId { get; set; }
    public string PlayerName { get; set; } = CareerEngine.PlayerName;
}

public static class NpcGeneration
{
    public static string ResolvePlayerName(NpcGenerationSetup setup) =>
        setup.Personal.Name.Trim() is { Length: > 0 } name ? name : string.IsNullOrWhiteSpace(setup.PlayerName) ? CareerEngine.PlayerName : setup.PlayerName.Trim();

    public static CareerData Create(AiOptions ai, NpcGenerationSetup setup)
    {
        var data = CareerEngine.CreateNew(personalityPool: setup.Pool, worldId: setup.WorldId, playerName: ResolvePlayerName(setup), country: EsportsWorld.Countries.Contains(setup.Personal.Country) ? setup.Personal.Country : "中国"); ApplySettings(data, setup, ai); return data;
    }

    public static void ApplySettings(CareerData data, NpcGenerationSetup setup, AiOptions inherited)
    {
        MatchRules.SetRivalLevel(data, setup.RivalLevel);
        data.Ai = Coop.CoopJson.Copy(setup.Ai ?? inherited);
        data.Ai.PersonalityPool = Coop.CoopJson.Copy(setup.Pool);
        if (data.Ai.Enabled && data.Posts.FirstOrDefault(p => p.EventKey == "ecosystem") is { } opening)
        {
            opening.AiPending = true;
            opening.Schedule ??= PublicSchedule.Capture(data, opening.RelatedPeople);
        }
    }

    // 调用者只将导入完成的全新世界发布给存档/联机；安装失败时回滚本地立绘绑定。
    public sealed class ImportBatch : IDisposable
    {
        private readonly List<CharacterDesignPackage.Installation> _assets = [];
        public ImportBatch(CareerData fresh, NpcGenerationSetup setup, CareerData? artOwner = null)
        {
            try
            {
                artOwner ??= fresh;
                fresh.ExcludedAppearancePacks = setup.ExcludedPacks.ToList();
                OpeningLibrary.Apply(fresh, artOwner, setup.SavedRoles, _assets);
                foreach (string path in setup.Files.Distinct(StringComparer.OrdinalIgnoreCase))
                {
                    try
                    {
                        var info = new FileInfo(path);
                        if (info.Length > 512L * 1024 * 1024) throw new InvalidDataException("文件超过 512 MiB。");
                        CharacterDesignPackage.Imported? package = Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? CharacterDesignPackage.Read(fresh, path) : null;
                        var person = package?.Person ?? CharacterCardPng.Import(fresh, File.ReadAllBytes(path));
                        if (CharacterCards.Apply(fresh, new() { Create = true, Target = person.Id, Person = person }) is { } error) throw new InvalidDataException(error);
                        if (package != null) _assets.Add(new(artOwner, package));
                    }
                    catch (Exception e) { throw new InvalidDataException(Path.GetFileName(path) + "：" + e.Message, e); }
                }
            }
            catch { Dispose(); throw; }
        }
        public void Commit() { foreach (var asset in _assets) asset.Commit(); }
        public void Dispose() { foreach (var asset in _assets.AsEnumerable().Reverse()) asset.Dispose(); _assets.Clear(); }
    }
}
