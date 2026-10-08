using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using Godot;
using MegaCrit.Sts2.Core.Saves;

namespace NationalSpire;

public static class CareerStore
{
    private static readonly JsonSerializerOptions Json = new()
    {
        WriteIndented = false,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.Never
    };
    private static readonly object Gate = new();
    private static readonly Dictionary<string, (long Length, DateTime Modified)> ValidatedFiles = new();
    private static (long, DateTime) Stamp(string path) { var f = new FileInfo(path); return (f.Length, f.LastWriteTimeUtc); }
    private static CareerData? _data;
    private static string? _loadedPath;
    private static readonly Dictionary<CareerData, string> Paths = new();
    public static string LoadNotice { get; private set; } = "";
    public static string DefaultPath => ProjectSettings.GlobalizePath(SaveManager.Instance.GetProfileScopedPath("national_spire_career.json"));
    private static string FilePath => CareerLibrary.SelectedPath(DefaultPath);
    public static bool IsCurrent(CareerData data) => data.ExternalCurrent?.Invoke() ?? ReferenceEquals(Data, data);
    public static CareerData Data
    {
        get
        {
            lock (Gate)
            {
                var path = FilePath;
                if (_data != null && _loadedPath == path) return _data;
                _data = null;
                LoadNotice = "";
                // 旧版全局存档仅迁移一次；原文件保留，其他档案不会再次导入。
                var legacy = ProjectSettings.GlobalizePath("user://national_spire_career.json");
                if (!File.Exists(path) && File.Exists(legacy) && !File.Exists(legacy + ".migrated"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                    File.Copy(legacy, path);
                    File.WriteAllText(legacy + ".migrated", path);
                }
                try
                {
                    if (File.Exists(path))
                        _data = Read(path);
                }
                catch (NotSupportedException) { throw; }
                catch (Exception e)
                {
                    Diagnostics.Error("career.load", e);
                    GD.PushWarning("[NationalSpire] 存档读取失败：" + e.Message);
                    File.Copy(path, path + ".broken-" + DateTime.UtcNow.ToString("yyyyMMddHHmmss"), true);
                    if (File.Exists(path + ".bak"))
                    {
                        try { _data = Read(path + ".bak"); LoadNotice = "主生涯文件损坏，已恢复最近备份。原文件已另存。"; }
                        catch (NotSupportedException) { throw; }
                        catch { LoadNotice = "生涯文件及备份均无法读取，已保留原文件并建立新生涯。"; }
                    }
                    else LoadNotice = "生涯文件无法读取，已保留原文件并建立新生涯。";
                }
                _data ??= CareerEngine.CreateNew();
                PrivateMessageCommands.Recover(_data.Life);
                bool clubMarket = _data.Esports.EcosystemVersion >= 1 && (_data.Esports.OwnedClub is { EconomyVersion: < 1 } || _data.Esports.FreeAgentVersion < 2 || _data.People.Any(p => p.Id.StartsWith("free-agent-") && p.RecruitVersion < 1));
                bool cameos = _data.Cameos.Version < CameoContent.Version && _data.Esports.EcosystemVersion >= 0;
                string cameoBackup = path + ".pre-cameos" + CameoContent.Version;
                if (cameos && File.Exists(path) && !File.Exists(cameoBackup))
                    File.WriteAllText(cameoBackup, JsonSerializer.Serialize(_data, Json));
                bool upgrading = _data.Version < 4 || !_data.Esports.Initialized;
                bool identities = _data.IdentityVersion < PlayerIdentity.Version || _data.ContentPoolVersion < ContentPoolMigration.Version;
                bool enriching = _data.ContentVersion < WorldPeople.ContentVersion;
                bool expanding = _data.Esports.EcosystemVersion == 0;
                bool lifeUpgrade = _data.Life.Version < CareerLife.Version && _data.Esports.EcosystemVersion >= 0;
                string lifeBackup = path + ".pre-life" + CareerLife.Version;
                if (lifeUpgrade && File.Exists(path) && !File.Exists(lifeBackup))
                    File.WriteAllText(lifeBackup, JsonSerializer.Serialize(_data, Json));
                bool commerce = _data.Esports.CommerceVersion < CareerCommerce.Version && _data.Esports.EcosystemVersion >= 0;
                if (commerce && File.Exists(path) && !File.Exists(path + ".pre-commerce1"))
                    File.WriteAllText(path + ".pre-commerce1", JsonSerializer.Serialize(_data, Json));
                if (expanding && File.Exists(path) && !File.Exists(path + ".pre-ecosystem1"))
                {
                    if (LoadNotice.Length == 0) File.Copy(path, path + ".pre-ecosystem1");
                    else File.WriteAllText(path + ".pre-ecosystem1", JsonSerializer.Serialize(_data, Json));
                }
                if (upgrading && File.Exists(path) && !File.Exists(path + ".pre-v4"))
                {
                    if (LoadNotice.Length == 0) File.Copy(path, path + ".pre-v4");
                    else File.WriteAllText(path + ".pre-v4", JsonSerializer.Serialize(_data, Json));
                }
                bool calendarUpgrade = _data.LongSeasonsFrom == 0 && _data.Esports.EcosystemVersion >= 0;
                bool avatarUpgrade = _data.AvatarFrames.Count == 0;
                bool personalityUpgrade = PersonalityLibrary.NeedsUpgrade(_data);
                bool recordsUpgrade = NpcRecords.Ensure(_data);
                bool repairedContracts = OwnedClubs.RepairContractRoster(_data);
                repairedContracts |= CareerEngine.NormalizeRoster(_data);
                PublicationBacklog.Compact(_data, false);
                bool editedNews = CareerNarrative.RepairNews(_data);
                bool upgradedCommunity = CommunityThreads.Normalize(_data);
                upgradedCommunity |= CommunityThreads.RecoverInterrupted(_data);
                upgradedCommunity |= WeeklyJournal.Recover(_data);
                if (upgrading) LoadNotice = "生涯已更新，原有战绩和奖励已保留，并已备份存档。";
                if (expanding) LoadNotice = "新赛季将迎来团队联赛和世界总决赛。当前比赛照常进行，旧生涯已备份。";
                else if (calendarUpgrade) LoadNotice = "本季保留已公布日期，下一赛季延长至12周。公开选拔每两周举办，社区刊物改为双周刊。";
                _data.Version = 4;
                _data.Ai = AiSettingsStore.Load(_data.Ai);
                upgradedCommunity |= WeeklyJournal.ActivateLatest(_data);
                _loadedPath = path;
                Paths[_data] = path;
                if (lifeUpgrade) LoadNotice = "活动与培养已更新，旧项目已核验，漏发收益会在活动记录中注明。升级前存档已备份。";
                else if (commerce) LoadNotice = "俱乐部与商业合作已更新。此前奖励已保留，个人赞助可重新选择。";
                if (repairedContracts || clubMarket || recordsUpgrade || personalityUpgrade || cameos || lifeUpgrade || avatarUpgrade || commerce || calendarUpgrade || identities || upgrading || expanding || enriching || editedNews || upgradedCommunity || !File.Exists(path)) Save(_data);
                return _data;
            }
        }
    }

    private static CareerData Read(string path)
    {
        var data = JsonSerializer.Deserialize<CareerData>(File.ReadAllText(path), Json)
            ?? throw new InvalidDataException("生涯存档为空。");
        if (data.Version > 4) throw new NotSupportedException("生涯文件来自更新版本，请更新模组后再打开。");
        if (data.Day < 1 || data.Season < 1 || data.LongSeasonsFrom < 0 || data.Day <= SeasonCalendar.Start(data) || data.Day > SeasonCalendar.End(data) || data.People is not { Count: > 0 }
            || data.Matches == null || data.Results == null || data.Posts == null || data.Standings == null || data.Ai == null)
            throw new InvalidDataException("生涯数据结构不完整。");
        ValidatedFiles[path] = Stamp(path);
        return data;
    }

    public static void Save(CareerData? data = null)
    {
        if (data?.ExternalSave is { } external) { external(data); return; }
        try
        {
            lock (Gate)
            {
                data ??= Data;
                if (!Paths.TryGetValue(data, out var path)) throw new InvalidOperationException("生涯未绑定存档路径。");
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                var temp = path + ".tmp";
                File.WriteAllText(temp, JsonSerializer.Serialize(data, Json));
                if (File.Exists(path))
                {
                    try
                    {
                        if (!ValidatedFiles.TryGetValue(path, out var stamp) || stamp != Stamp(path)) _ = Read(path);
                        File.Copy(path, path + ".bak", true);
                    }
                    catch (InvalidDataException) { /* 已损坏的主文件不能覆盖正常备份。 */ }
                    catch (JsonException) { /* 已损坏的主文件不能覆盖正常备份。 */ }
                }
                File.Move(temp, path, true);
                ValidatedFiles[path] = Stamp(path);
                if (ReferenceEquals(_data, data)) AiSettingsStore.Save(data.Ai);
            }
        }
        catch (Exception e) { Diagnostics.Error("career.save", e); throw; }
    }

    public static CareerData ResetCareer()
    {
        lock (Gate)
        {
            var old = Data;
            var path = Paths[old];
            Save(old);
            File.Copy(path, path + ".reset-" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"), false);
            _data = CareerEngine.CreateNew();
            _data.Ai = old.Ai;
            Paths[_data] = path;
            Save(_data);
            return _data;
        }
    }

    public static CareerData SwitchCareer(string path)
    {
        lock (Gate)
        {
            if (Data.Failure != null) throw new InvalidOperationException(MatchFailure.Locked(Data));
            var previous = Data;
            if (Path.GetFullPath(path) == Path.GetFullPath(Paths[previous])) return previous;
            Save(previous);
            var incoming = Read(path);
            string native = GameBridge.NativeCareerPath;
            byte[]? run = File.Exists(native) ? File.ReadAllBytes(native) : null;
            byte[]? backup = File.Exists(native + ".backup") ? File.ReadAllBytes(native + ".backup") : null;
            string previousPath = Paths[previous];
            try
            {
                CareerLibrary.SwitchNative(previous, previousPath, incoming, path, native); CareerLibrary.Select(DefaultPath, path);
                _data = null; _loadedPath = null;
                return Data;
            }
            catch
            {
                CareerLibrary.RestoreNative(native, run, backup); CareerLibrary.Select(DefaultPath, previousPath);
                _data = previous; _loadedPath = previousPath; throw;
            }
        }
    }

    public static string ExportDiagnostics()
    {
        var data = Data;
        Diagnostics.RegisterSecret(AiSettingsStore.ReadKey());
        Diagnostics.RegisterSecret(System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY"));
        lock (Gate) return Diagnostics.Export(data, Paths[data], ProjectSettings.GlobalizePath("user://logs"), AiService.Status);
    }
}

