using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>开局观察仅写入现有比赛日志，原任务、资源与异常继续交给游戏处理。</summary>
internal sealed class StartDiagnostics : IDisposable
{
    internal static StartDiagnostics? Current { get; private set; }
    private readonly Stopwatch _clock = Stopwatch.StartNew();
    private readonly string _attempt = Guid.NewGuid().ToString("N");
    private readonly object _context;
    private readonly Dictionary<string, int> _resources = [];
    private readonly HashSet<MethodBase> _methods = [];
    private readonly HashSet<object> _sessions = [];
    private readonly object _gate = new();
    private readonly StartDiagnostics? _previous;
    private string? _stage;
    private bool _finished;

    internal StartDiagnostics(CareerData data, CareerMatch match, string character, int ascension)
    {
        _context = new { data.WorldId, data.Season, data.Day, match.Id, match.Seed, character, ascension,
            decision = data.Failure?.Attempt, retry = data.Failure?.RetryRequested, data.PendingMatchId };
        _previous = Current;
        Current = this;
        Write("begin", null);
    }

    internal void Write(string phase, object? detail)
        => Diagnostics.Record("match.start.progress", new { attempt = _attempt, elapsedMs = _clock.Elapsed.TotalMilliseconds,
            context = _context, phase, stage = _stage, detail });

    internal static void Capture(Action action)
    {
        try { action(); }
        catch (Exception error) { Diagnostics.Error("match.start.observer", error); }
    }

    internal void CaptureResource(string path, string phase, int? state = null, Exception? error = null)
        => Capture(() => Resource(path, phase, state, error));
    internal void CaptureMethod(MethodBase method, string phase, Exception? error = null)
        => Capture(() => Method(method, phase, error));
    internal void CaptureSession(AssetLoadingSession session) => Capture(() => Session(session));
    internal void CaptureTask(MethodBase method, Task task) => Capture(() => Observe(method, task));

    internal void Stage(string stage)
    {
        if (_stage != null) Write("stage-complete", null);
        _stage = stage;
        Write("stage-begin", null);
    }

    internal string? Finish(string? error)
    {
        lock (_gate)
        {
            Write(error == null ? "complete" : "failed", new { error, pendingResources = _resources.Keys.ToArray(), sessions = _sessions.Count });
            _finished = true;
        }
        return error;
    }

    private void Used(MethodBase? method)
    {
        if (method == null) return;
        lock (_gate) if (!_methods.Contains(method)) Method(method, "observed");
    }

    internal void Method(MethodBase method, string phase, Exception? error = null)
    {
        lock (_gate)
        {
            object? patches = null;
            if (_methods.Add(method))
            {
                var state = method.GetCustomAttribute<AsyncStateMachineAttribute>()?.StateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                patches = new[] { method, state }.OfType<MethodBase>().Select(m =>
                {
                    var info = Harmony.GetPatchInfo(m);
                    return new
                    {
                        method = m.DeclaringType?.FullName + "." + m.Name,
                        assembly = m.DeclaringType?.Assembly.FullName,
                        patches = info?.Prefixes.Concat(info.Postfixes).Concat(info.Transpilers).Concat(info.Finalizers)
                            .Select(p => new { p.owner, p.priority, p.before, p.after, method = p.PatchMethod.DeclaringType?.FullName + "." + p.PatchMethod.Name,
                                assembly = p.PatchMethod.DeclaringType?.Assembly.FullName }).ToArray()
                    };
                }).ToArray();
            }
            Write("method-" + phase, new { method = method.DeclaringType?.FullName + "." + method.Name, patches, exception = error?.ToString() });
        }
    }

    internal void Resource(string path, string phase, int? state = null, Exception? error = null)
    {
        lock (_gate)
        {
            if (phase == "status")
            {
                if (_resources.TryGetValue(path, out int previous) && previous == state) return;
                _resources[path] = state ?? -1;
            }
            else if (phase == "request") _resources[path] = -1;
            if (phase is "get-complete" or "sync-complete" or "failed" || phase == "status" && state is 0 or 2) _resources.Remove(path);
            Write("resource-" + phase, new { path, state, exception = error?.ToString() });
        }
    }

    internal void Session(AssetLoadingSession session)
    {
        lock (_gate) if (!_sessions.Add(session)) return;
        foreach (string name in new[] { "Process", "FinalizeLoading", "ProcessLoadingQueue", "CheckLoadingStatus", "ProcessVfxQueue" })
            Used(AccessTools.Method(typeof(AssetLoadingSession), name));
        Used(AccessTools.Method(typeof(NAssetLoader), "_Process"));
        foreach (string name in new[] { "LoadThreadedRequest", "LoadThreadedGetStatus", "LoadThreadedGet" })
            Used(AccessTools.Method(typeof(ResourceLoader), name));
        Used(StartResourceSyncDiagnosticsPatch.TargetMethod());
        var fields = new[] { "_name", "_toLoad", "_loading", "_finalizing", "_vfxScenes", "_currentVfxPath" }
            .ToDictionary(name => name, name => AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session) is Queue<string> paths
                ? (object)paths.ToArray() : AccessTools.Field(typeof(AssetLoadingSession), name)?.GetValue(session));
        Write("resources-begin", fields);
        _ = session.Task.ContinueWith(task => Capture(() =>
        {
            Write("resources-end", new { name = fields["_name"], status = task.Status.ToString(), exception = task.Exception?.ToString() });
            lock (_gate) _sessions.Remove(session);
        }), CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
    }

    internal void Observe(MethodBase method, Task task)
        => _ = task.ContinueWith(t => Capture(() => Method(method, t.IsCanceled ? "cancelled" : t.IsFaulted ? "failed" : "complete", t.Exception)),
            CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

    public void Dispose()
    {
        lock (_gate)
        {
            if (!_finished) Write("left", new { pendingResources = _resources.Keys.ToArray(), sessions = _sessions.Count });
            if (ReferenceEquals(Current, this)) Current = _stage == null ? _previous : null;
            _resources.Clear(); _methods.Clear(); _sessions.Clear();
        }
    }
}

[HarmonyPatch]
internal static class StartMethodDiagnosticsPatch
{
    internal static IEnumerable<MethodBase> TargetMethods()
    {
        foreach (var (type, name) in new[] { (typeof(NGame), "StartRun"), (typeof(PreloadManager), "LoadRunAssets"),
            (typeof(PreloadManager), "LoadActAssets"), (typeof(RunManager), "FinalizeStartingRelics"),
            (typeof(RunManager), "EnterAct"), (typeof(NTransition), "FadeOut"), (typeof(NTransition), "FadeIn") })
        {
            var method = AccessTools.Method(type, name);
            if (method != null) yield return method;
            else Diagnostics.Record("match.start.observer", new { method = type.FullName + "." + name, state = "接口不存在" });
        }
    }
    internal static void Prefix(MethodBase __originalMethod, out StartDiagnostics? __state)
    {
        __state = StartDiagnostics.Current;
        __state?.CaptureMethod(__originalMethod, "begin");
    }
    internal static void Postfix(MethodBase __originalMethod, Task __result, StartDiagnostics? __state)
        => __state?.CaptureTask(__originalMethod, __result);
    internal static void Finalizer(MethodBase __originalMethod, Exception? __exception, StartDiagnostics? __state)
    { if (__exception != null) __state?.CaptureMethod(__originalMethod, "failed", __exception); }
}

[HarmonyPatch(typeof(NAssetLoader), nameof(NAssetLoader.LoadInTheBackground))]
internal static class StartSessionDiagnosticsPatch
{
    internal static void Prefix(AssetLoadingSession session) => StartDiagnostics.Current?.CaptureSession(session);
}

[HarmonyPatch(typeof(ResourceLoader), nameof(ResourceLoader.LoadThreadedRequest))]
internal static class StartResourceRequestDiagnosticsPatch
{
    internal static void Prefix(string path) => StartDiagnostics.Current?.CaptureResource(path, "request");
    internal static void Postfix(string path, Error __result)
        => StartDiagnostics.Current?.CaptureResource(path, __result == Error.Ok ? "request-complete" : "failed", (int)__result);
    internal static void Finalizer(string path, Exception? __exception)
    { if (__exception != null) StartDiagnostics.Current?.CaptureResource(path, "failed", error: __exception); }
}

[HarmonyPatch(typeof(ResourceLoader), nameof(ResourceLoader.LoadThreadedGetStatus))]
internal static class StartResourceStatusDiagnosticsPatch
{
    internal static void Postfix(string path, ResourceLoader.ThreadLoadStatus __result)
        => StartDiagnostics.Current?.CaptureResource(path, "status", (int)__result);
}

[HarmonyPatch(typeof(ResourceLoader), nameof(ResourceLoader.LoadThreadedGet))]
internal static class StartResourceGetDiagnosticsPatch
{
    internal static void Prefix(string path) => StartDiagnostics.Current?.CaptureResource(path, "get-begin");
    internal static void Postfix(string path) => StartDiagnostics.Current?.CaptureResource(path, "get-complete");
    internal static void Finalizer(string path, Exception? __exception)
    { if (__exception != null) StartDiagnostics.Current?.CaptureResource(path, "failed", error: __exception); }
}

[HarmonyPatch]
internal static class StartResourceSyncDiagnosticsPatch
{
    internal static MethodBase TargetMethod() => typeof(ResourceLoader).GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Single(m => m.Name == nameof(ResourceLoader.Load) && !m.IsGenericMethod && m.GetParameters().Length == 3);
    internal static void Prefix(string path) => StartDiagnostics.Current?.CaptureResource(path, "sync-begin");
    internal static void Postfix(string path) => StartDiagnostics.Current?.CaptureResource(path, "sync-complete");
    internal static void Finalizer(string path, Exception? __exception)
    { if (__exception != null) StartDiagnostics.Current?.CaptureResource(path, "failed", error: __exception); }
}
