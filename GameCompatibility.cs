using System.Reflection;
using System.Text.Json;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Random;

namespace NationalSpire;

public static class GameCompatibility
{
    /// <summary>仅在开局长时间等待时读取加载队列；版本字段缺失作为诊断缺口返回。</summary>
    public static object AssetLoadingStatus()
    {
        try
        {
            const BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;
            // 读取已存在的节点，避免 Instance 属性在节点缺失时构造游离的加载器。
            if (typeof(NAssetLoader).GetField("_instance", flags)?.GetValue(null) is not NAssetLoader loader
                || !Godot.GodotObject.IsInstanceValid(loader)) return new { available = false };
            object? session = typeof(NAssetLoader).GetField("_currentSession", flags)?.GetValue(loader);
            object? Read(string name) => session?.GetType().GetField(name, flags)?.GetValue(session);
            object Queue(string field)
            {
                if (Read(field) is not IEnumerable<string> paths) return new { available = false };
                return new { count = (paths as System.Collections.ICollection)?.Count,
                    paths = paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing"
                        ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray() };
            }
            return new { available = true, insideTree = loader.IsInsideTree(), processing = loader.IsProcessing(),
                canProcess = loader.CanProcess(), processMode = loader.ProcessMode.ToString(),
                name = Read("_name"), toLoad = Queue("_toLoad"), loading = Queue("_loading"), finalizing = Queue("_finalizing"),
                vfx = Queue("_vfxScenes"), currentVfx = Read("_currentVfxPath"), vfxLoading = Read("_vfxLoading") };
        }
        catch (Exception error) { return new { available = false, error = error.GetBaseException().Message }; }
    }
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
