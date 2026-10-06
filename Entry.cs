using Godot;
using Godot.Bridge;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Platform;

namespace NationalSpire;

[ModInitializer("Init")]
public static class Entry
{
    public static void Init()
    {
        Diagnostics.Configure(ProjectSettings.GlobalizePath("user://national_spire_diagnostics"));
        Diagnostics.RegisterSecret(AiSettingsStore.ReadKey());
        Diagnostics.RegisterSecret(System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY"));
        Diagnostics.RuntimeSnapshot = () => new
        {
            gameVersion = GameCompatibility.Version(),
            godot = Engine.GetVersionInfo()["string"].AsString(),
            mods = ModManager.Mods.Select(m => new { id = m.manifest?.id, name = m.manifest?.name, version = m.manifest?.version, state = m.state.ToString(), source = m.modSource.ToString() }).ToArray(),
            live = LiveRunBridge.Current?.DiagnosticSnapshot(),
            cooperative = new { world = Coop.CoopRuntime.Current?.Session?.World?.Id,
                revision = Coop.CoopRuntime.Current?.Session?.World?.Revision, host = Coop.CoopRuntime.Current?.Session?.Host,
                connected = Coop.CoopRuntime.Current?.Session?.Online.Count, phase = Coop.CoopRuntime.Current?.Session?.World?.Run?.Phase,
                attempt = Coop.CoopRuntime.Current?.Session?.World?.Run?.Attempt, status = Coop.CoopRuntime.Current?.Status }
        };
        AppDomain.CurrentDomain.UnhandledException += (_, e) => { if (e.ExceptionObject is Exception error) Diagnostics.Error("unhandled", error); };
        TaskScheduler.UnobservedTaskException += (_, e) => Diagnostics.Error("task.unobserved", e.Exception);
        Diagnostics.Record("mod.loaded", new { version = Diagnostics.ModVersion, game = GameCompatibility.Version() });
        CareerEngine.PlayerNameSource = () => PlatformUtil.GetPlayerNameRaw(PlatformUtil.PrimaryPlatform, PlatformUtil.GetLocalPlayerId(PlatformUtil.PrimaryPlatform));
        CharacterIdentity.Source = () => GameBridge.Characters().Select(c => new CharacterDefinition(c.Id.ToString(), PlayerArchive.CharacterName(c.Id))).ToArray();
        ScriptManagerBridge.LookupScriptsInAssembly(typeof(Entry).Assembly);
        LiveCompatibility.Install(new Harmony("nationalspire.career"), typeof(Entry).Assembly);
        GD.Print("[NationalSpire] 生涯与社区模块已加载");
    }
}
