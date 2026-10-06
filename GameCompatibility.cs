using System.Reflection;
using System.Text.Json;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Random;

namespace NationalSpire;

public static class GameCompatibility
{
    private static readonly Lazy<SeedApi> Seeds = new(() => new(typeof(StringHelper), typeof(Rng)));
    public static string SeedMode => Seeds.Value.Description;
    public static Rng ActRng(string seed) => (Rng)Seeds.Value.FromText(seed, "act_selection");
    public static Rng MapRng(object runRng, int act) => (Rng)Seeds.Value.FromRun(runRng, $"act_{act}_map");
    public static string Version()
    {
        try
        {
            var reader = typeof(NGame).GetMethod("GetGameVersion", BindingFlags.Public | BindingFlags.Static, Type.EmptyTypes);
            if (reader?.Invoke(null, null) is string version) return version;
            string directory = Path.GetDirectoryName(typeof(NGame).Assembly.Location)!;
            foreach (string file in new[] { Path.Combine(directory, "release_info.json"), Path.Combine(directory, "..", "release_info.json") })
                if (File.Exists(file))
                { using var json = JsonDocument.Parse(File.ReadAllText(file)); return json.RootElement.GetProperty("version").GetString() ?? "未知版本"; }
        }
        catch (Exception e) { Diagnostics.Error("compat.version", e); }
        return typeof(NGame).Assembly.GetName().Version?.ToString() ?? "未知版本";
    }
}
