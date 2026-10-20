namespace NationalSpire;

public sealed class AiConnectionProfile
{
    public string Name { get; set; } = "default";
    public string Endpoint { get; set; } = "https://api.deepseek.com/v1";
    public string Model { get; set; } = "deepseek-flash";
}

/// <summary>所有模型任务共用的方案选择入口；凭据由本机加密存储管理。</summary>
public static class AiRouting
{
    public const string Default = "default";
    public static readonly (string Id, string Name)[] Tasks =
    [
        ("weekly", "周刊与介绍"), ("news", "发帖"), ("discussion", "回帖"),
        ("private", "私聊"), ("group", "群聊"), ("private-summary", "私聊总结"),
        ("group-summary", "群聊总结"), ("arbitration", "聊天仲裁"), ("event", "随机事件")
    ];

    public static void Ensure(AiOptions options)
    {
        if (options.ConnectionProfiles.Count > 0) return;
        options.ConnectionProfiles[Default] = new() { Name = Default, Endpoint = options.Endpoint, Model = options.Model };
    }

    public static string Category(string task) => task switch
    {
        "profiles" => "weekly", "private-long-summary" => "private-summary",
        "group-long-summary" => "group-summary", _ => task
    };

    public static string ProfileId(AiOptions options, string task)
    {
        Ensure(options);
        return options.TaskProfiles.GetValueOrDefault(Category(task), Default);
    }

    public static AiConnectionProfile Profile(AiOptions options, string task)
        => options.ConnectionProfiles[ProfileId(options, task)];

    public static string NextName(AiOptions options)
    {
        Ensure(options);
        string name = Default; int number = 1;
        while (options.ConnectionProfiles.Values.Any(p => p.Name == name)) name = Default + ++number;
        return name;
    }
}

public readonly record struct AiConnection(string ProfileId, string Name, string Endpoint, string Model, string? Key);
