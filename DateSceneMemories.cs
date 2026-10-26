using Godot;
using System.Text;
using System.Text.Json;

namespace NationalSpire;

// Player-owned playback data lives outside CareerData, chat memory and request contracts.
public sealed class DateSceneMemory
{
    public int Version { get; set; } = 1;
    public string OfferId { get; set; } = "";
    public string Host { get; set; } = "";
    public string Player { get; set; } = "";
    public string Title { get; set; } = "";
    public int Season { get; set; }
    public int Day { get; set; }
    public bool Ended { get; set; }
    public Dictionary<string, DateMemoryPerson> People { get; set; } = [];
    public Dictionary<string, string> Backgrounds { get; set; } = [];
    public List<DateMemoryTurn> Turns { get; set; } = [];
    public DateMemoryFrame? Initial { get; set; }
}

/// <summary>Collects display-only turns and exact shown frames; callers control persistence.</summary>
public sealed class DateMemoryRecorder(DateSceneMemory memory)
{
    public DateSceneMemory Memory { get; } = memory;
    public bool Dirty { get; set; }
    public string PendingChoice { get; set; } = "";
    private readonly Dictionary<string, (string User, string Reply, string Status, bool Deleted)> _seen = [];
    public DateMemoryFrame? LastFrame { get; private set; } = memory.Turns.SelectMany(t => t.Frames.OrderBy(p => p.Key).Select(p => p.Value)).LastOrDefault() ?? memory.Initial;
    public void Sync(PrivateConversation conversation)
    {
        foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == Memory.OfferId && !t.Scene.Ending))
        {
            var signature = (turn.User, turn.Reply, turn.Status, turn.ReplyDeleted);
            if (_seen.TryGetValue(turn.Id, out var before) && before == signature) continue;
            _seen[turn.Id] = signature;
            var entry = Memory.Turns.FirstOrDefault(t => t.Id == turn.Id);
            if (entry == null) { entry = new() { Id = turn.Id, UserFrame = LastFrame }; Memory.Turns.Add(entry); }
            // 重试也可来自已播放部分内容的失败轮次；界面可能只观察到重新开始发送。
            if (turn.Status == "queued" || turn.Status == "sending" && (entry.Complete || before.Status != "sending"))
            { entry.Lines.Clear(); entry.Frames.Clear(); }
            string user = turn.UserDeleted || turn.Scene!.Opening || turn.Scene.GameEvent.Length > 0 ? "" : turn.User;
            if (entry.User != user) entry.Choice = false;
            entry.User = user;
            if (PendingChoice.Length > 0 && entry.User == PendingChoice) { entry.Choice = true; PendingChoice = ""; }
            entry.Complete = turn.Status == "complete" && !turn.ReplyDeleted;
            if (entry.Complete)
            {
                var lines = DateScenes.Lines(turn).Select(DateSceneMemories.CopyLine).ToList();
                foreach (int index in entry.Frames.Keys.ToList())
                    if (index >= lines.Count || index >= entry.Lines.Count || !DateSceneMemories.SameLine(lines[index], entry.Lines[index])) entry.Frames.Remove(index);
                entry.Lines = lines;
            }
            if (turn.ReplyDeleted) { entry.Lines.Clear(); entry.Frames.Clear(); }
            Dirty = true;
        }
    }
    public void Capture(string turn, int index, DateSceneLine line, DateMemoryFrame frame)
    {
        var entry = Memory.Turns.FirstOrDefault(t => t.Id == turn);
        if (entry == null || index < 0) return;
        if (index < entry.Lines.Count && DateSceneMemories.SameLine(entry.Lines[index], line) && entry.Frames.TryGetValue(index, out var previous)
            && JsonSerializer.Serialize(previous) == JsonSerializer.Serialize(frame)) return;
        while (entry.Lines.Count <= index) entry.Lines.Add(new());
        entry.Lines[index] = DateSceneMemories.CopyLine(line); entry.Frames[index] = frame;
        LastFrame = frame; Memory.Initial ??= frame; Dirty = true;
    }
}
public sealed class DateMemoryPerson
{
    public string Name { get; set; } = "";
    public string Default { get; set; } = "";
    public Dictionary<string, string> Emotions { get; set; } = [];
}
public sealed class DateMemoryTurn
{
    public string Id { get; set; } = "";
    public string User { get; set; } = "";
    public bool Choice { get; set; }
    public bool Complete { get; set; }
    public DateMemoryFrame? UserFrame { get; set; }
    public List<DateSceneLine> Lines { get; set; } = [];
    public Dictionary<int, DateMemoryFrame> Frames { get; set; } = [];
}
public sealed class DateMemoryFrame
{
    public Dictionary<string, DatePortraitPlacement> Placements { get; set; } = [];
    public string Background { get; set; } = "";
    public string Speaker { get; set; } = "";
    public List<string> Cast { get; set; } = [];
    public Dictionary<string, string> Portraits { get; set; } = [];
    public Dictionary<string, string> Anchors { get; set; } = [];
    public int FontSize { get; set; } = 1;
    public double Fade { get; set; }
    public double Spacing { get; set; } = 1;
    public double Blur { get; set; } = 3;
    public double Scale { get; set; } = 1;
    public double X { get; set; }
    public double Y { get; set; }
    public bool Outline { get; set; } = true;
    public bool Badge { get; set; } = true;
    public int Favour { get; set; }
    public string Relationship { get; set; } = "";
    public int? Bond { get; set; }
    public bool Oath { get; set; }
}
public static class DateSceneMemories
{
    private const string SettingsPath = "user://NationalSpire_date_scene.cfg";
    private static readonly Dictionary<string, (string Stamp, List<DateSceneMemory> Memories, string Warning)> Cache = [];
    public static bool Recording
    {
        get { using var config = new ConfigFile(); config.Load(SettingsPath); return config.GetValue("scene", "record_dates", true).AsBool(); }
        set
        {
            using var config = new ConfigFile(); config.Load(SettingsPath); config.SetValue("scene", "record_dates", value);
            if (config.Save(SettingsPath) != Error.Ok) throw new IOException("保存回忆记录设置失败。");
        }
    }
    public static string DirectoryPath(CareerData data) => Path.Combine(ProjectSettings.GlobalizePath("user://national_spire_date_memories"), PortraitDesignStore.Key(data, "date-memories"));
    public static string FilePath(CareerData data, string offer) => Path.Combine(DirectoryPath(data), DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(offer)) + ".json");
    public static DateSceneMemory? Read(CareerData data, string offer)
    {
        string path = FilePath(data, offer);
        if (!File.Exists(path)) return null;
        var memory = JsonSerializer.Deserialize<DateSceneMemory>(File.ReadAllText(path), PortraitDesigns.Json);
        if (memory == null || memory.Version != 1 || memory.OfferId != offer) throw new InvalidDataException("约会回忆格式无效。");
        ReconcileDeletedReplies(data, memory);
        return memory;
    }
    public static bool RemoveReply(DateSceneMemory memory, string turnId)
    {
        var turn = memory.Turns.FirstOrDefault(t => t.Id == turnId);
        if (turn == null || turn.Lines.Count == 0 && turn.Frames.Count == 0 && !turn.Complete) return false;
        turn.Lines.Clear(); turn.Frames.Clear(); turn.Complete = false;
        return true;
    }
    public static void ReconcileDeletedReplies(CareerData data, DateSceneMemory memory)
    {
        var conversation = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host);
        if (conversation == null) return;
        foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == memory.OfferId && t.ReplyDeleted)) RemoveReply(memory, turn.Id);
    }
    public static void Save(CareerData data, DateSceneMemory memory)
    {
        if (PrivateMessages.Mailbox(data).Conversations.Values.Any(c => c.DeletedDateDiaries.Contains(memory.OfferId))) return;
        ReconcileDeletedReplies(data, memory);
        string path = FilePath(data, memory.OfferId); Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        string temporary = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try { File.WriteAllText(temporary, JsonSerializer.Serialize(memory, PortraitDesigns.Json), new UTF8Encoding(false)); File.Move(temporary, path, true); Cache.Remove(DirectoryPath(data)); }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    public static void Delete(CareerData data, string offer)
    {
        File.Delete(FilePath(data, offer)); Cache.Remove(DirectoryPath(data));
    }
    public static List<DateSceneMemory> ForPerson(CareerData data, string person, out string warning)
    {
        string directory = DirectoryPath(data);
        var files = Directory.Exists(directory) ? Directory.EnumerateFiles(directory, "*.json").Select(p => new FileInfo(p)).OrderBy(f => f.Name).ToList() : [];
        string stamp = string.Join('|', files.Select(f => f.Name + ":" + f.Length + ":" + f.LastWriteTimeUtc.Ticks));
        if (!Cache.TryGetValue(directory, out var cached) || cached.Stamp != stamp)
        {
            var result = new List<DateSceneMemory>(); var errors = new List<string>();
            foreach (var file in files)
            {
                try
                {
                    var memory = JsonSerializer.Deserialize<DateSceneMemory>(File.ReadAllText(file.FullName), PortraitDesigns.Json);
                    if (memory is { Version: 1 } && memory.Turns.Any(t => t.User.Length > 0 || t.Lines.Count > 0)) result.Add(memory);
                }
                catch (Exception e) { errors.Add("一份回忆读取失败：" + e.Message); }
            }
            Cache[directory] = cached = (stamp, result, string.Join("\n", errors));
        }
        warning = cached.Warning;
        foreach (var memory in cached.Memories) ReconcileDeletedReplies(data, memory);
        var conversations = PrivateMessages.Mailbox(data).Conversations;
        var deleted = conversations.Values.SelectMany(c => c.DeletedDateDiaries).ToHashSet();
        return cached.Memories.Where(m => m.People.ContainsKey(person) && !deleted.Contains(m.OfferId)
            && (m.Ended || conversations.GetValueOrDefault(m.Host)?.DateSceneStates.GetValueOrDefault(m.OfferId) == "ended")).ToList();
    }
    public static DateSceneLine CopyLine(DateSceneLine line) => new() { Speaker = line.Speaker, Text = line.Text, Emotion = line.Emotion, Narration = line.Narration, Background = line.Background };
    public static bool SameLine(DateSceneLine a, DateSceneLine b) => a.Speaker == b.Speaker && a.Narration == b.Narration && a.Emotion == b.Emotion && a.Background == b.Background && a.Text == b.Text;
}
