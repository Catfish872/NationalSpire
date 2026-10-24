using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace NationalSpire;

/// <summary>聊天工具共用字段、原有业务说明和交互入口；提示词作用域只覆盖同步组装。</summary>
public static class ChatTools
{
    private static readonly AsyncLocal<bool> PromptMode = new();
    public static bool InPrompt => PromptMode.Value;
    public static bool Enabled(AiOptions options, bool? mode) => mode ?? options.ChatTools;
    public static IDisposable Enter(bool enabled)
    { bool previous = PromptMode.Value; PromptMode.Value = enabled; return new Scope(previous); }
    private sealed class Scope(bool previous) : IDisposable { public void Dispose() => PromptMode.Value = previous; }
    public const string ActivityIntentGuidance = "玩家主动提出活动，就视为有参加意愿；人物答应后就登记活动。无须玩家再重复确认或说明具体小时。";
    public const string TeachingGuidance = "先区分讲解者与学习者。玩家讲解自己已经掌握的做法，属于教学；只有听取新做法、形成新理解并决定采用的非玩家的NPC，才按上述条件登记学习变化。玩家被教学、NPC作为教学者时，不登记学习变化。只有NPC获得教学时，才登记学习变化";
    public const string Guidance = "每轮通过一次 send_message 提交完整回复。先在 Reasoning 中整理本轮相关事实、人物反应和交互决定，再在 Replies 中按顺序填写完整的角色回复，最后在 Interactions 中登记全部实际交互；没有交互填 []。Reasoning 供玩家展开查看，Reply 是聊天正文，沿用当前模板的文风、人物语言与篇幅要求。根据本轮话语和上下文判断交互：新约定采用邀请；处理已有待处理卡片时，按其实际种类和编号登记接受、拒绝或改期。已经确认并赴约的活动按当前场景继续交流。人物在交流中形成长期性格、观念或习惯变化时，按 profile 说明填写交互；同时发生学习变化时，再按 skill 说明填写对应交互。先核实信息再评价属于 profile 的判断依据；学会选牌、出牌或构筑等具体做法属于 skill。两者同时发生时分别填写。各项交互的适用条件与参数含义见 Interactions。";
    public const string OrdinaryGuidance = "普通交流指本轮没有符合各项交互说明、需要登记的决定或变化：没有比赛约战、训练计划、阵容调整、生活活动、合同、赠礼、誓约或代发帖子的决定，没有好感、态度、关系、长期学习、临时状态或长期人物资料变化，也没有本次要求提交的约会日记。只有这些交互均未发生时，Interactions 才填 []，Replies 仍填写完整正文。约会、出游和按日期安排的交流、聊天都属于生活活动。例如玩家提出今晚交流一下，人物答应后，本轮就有生活活动邀请，按 activity 填写。已经赴约后的交谈，根据本轮实际发生的变化登记交互。";
    public static readonly string GroupSpeech = "Replies 按实际发言顺序填写，每段先填 Speaker 人物编号，再填该人物的完整 Reply；Speaker 填本群可发言的 NPC 编号，真人消息由本人发送。交互中的 Actor、Target 各按其说明填写。\n" + GroupChatPrompts.SpeechFormat.Split('\n')[1];
    public const string AttachmentGuide = "请根据附件的内容和实际商谈，在 send_message 的 Interactions 中登记处理结果。参数使用这个附件的编号、人物与日期；接受、拒绝或改期按对应交互说明填写。";
    public static List<Dictionary<string, string>> CompletePrompt(List<Dictionary<string, string>> messages, bool ending = false)
    {
        if (InPrompt)
        {
            messages.Add(new() { ["role"] = "system", ["content"] = ending ? DateDiaries.ToolEnding : "请调用 send_message 完成本轮回复，按 Reasoning、Replies、Interactions 的顺序填写。Reasoning 根据本轮提供的事实整理人物反应与实际交互决定；Replies 保持前文模板要求的文风、人物语言和篇幅，填写完整正文。正文中已经作出的交互决定，包括邀请、接受、拒绝、改期，以及学习、状态和人物资料变化，都在 Interactions 中填写对应交互。普通聊天也填写完整 Replies，确实没有交互时 Interactions 填 []。" });
        }
        return messages;
    }
    internal sealed record Feature(string Name, string Key, string Description, string[] Fields);
    private static Feature[] Features(bool group) =>
    [
        new("relationship", "", PrivateMessagePrompts.Protocol, ["Favour", "Attitude", "Relationship"]),
        new("skill", "Skill", PrivateMessagePrompts.SkillProtocol.Replace("正向变化须能由", TeachingGuidance + "\n正向变化须能由"), ["Skill", "Topic", "Reason"]),
        new("mood", "Mood", PrivateMessagePrompts.MoodProtocol, ["Mood", "Days", "Reason"]),
        new("profile", "Profile", PrivateMessagePrompts.ProfileProtocol, ["Profile", "Value", "Reason"]),
        new("match", "Match", PrivateMessagePrompts.MatchProtocol, ["Match", "Date", "Ascension", "Mode"]),
        new("contract", "Contract", PrivateMessagePrompts.ContractProtocol, ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"]),
        new("training", "Training", ClubCoaching.Protocol, ["Training", "Id"]),
        new("lineup", "Lineup", CoachLineups.Protocol, ["Lineup", "Id"]),
        new("activity", "Activity", ActivityProtocol(group), ["Activity", "Id", "Title", "Date", "Detail"]),
        new("gift", "Gift", group ? ChatAttachments.GroupGiftProtocol : ChatAttachments.GiftProtocol, ["Gift", "Id"]),
        new("oath", "Oath", group ? OathAttachments.GroupProtocol : OathAttachments.Protocol, ["Oath", "Id"]),
        new("post", "Post", PrivateMessagePrompts.PostProtocol, ["Post", "Title", "Body"])
    ];
    private static string ActivityProtocol(bool group) => (group ? SocialAppointments.GroupProtocol : SocialAppointments.Protocol)
        .Replace("玩家主动提出或暗示活动意愿时，可以商谈活动。", "")
        .Replace("Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。",
            "Activity 填邀请、接受、改期或取消；Id 填对应活动编号。玩家只用聊天文字提出新活动时，人物同意参加后填写 Activity 为邀请、Id 为0；本轮附有活动卡片时，接受该安排填写 Activity 为接受、Id 为附件编号。Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。")
        .Replace("接受玩家提出的活动：", "接受玩家活动附件中的安排：");
    public static string Describe(string protocol)
    {
        // 旧协议仍是业务含义的唯一来源，工具示例只转换表达形式。
        string result = Regex.Replace(protocol, @"\[(?:Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Gift|Oath|Training|Lineup|Scene|DateDiary):[^\r\n\]]+\]", m =>
        {
            var sample = new PrivateStreamParser("Actor", "Target", "Participants", "Related", "Coach"); sample.Feed(m.Value); sample.Finish();
            var fields = sample.Directives.FirstOrDefault() ?? sample.SceneCues.FirstOrDefault().Fields;
            return fields == null ? m.Value : JsonSerializer.Serialize(fields.ToDictionary(p => p.Key, p =>
                p.Key is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" && int.TryParse(p.Value, out int n) ? (object)n : p.Value),
                new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        });
        return result.Replace("在正文后附加", "调用对应工具").Replace("在回复末尾附", "调用对应工具提交")
            .Replace("在本轮回复中输出对应的", "在本轮调用对应工具提交")
            .Replace("日记标记放在正文之后，内容中的方括号改用中文圆括号。", "日记内容写入工具参数。")
            .Replace("隐藏日记标记", "日记工具参数").Replace("标记", "工具参数").Replace("交互格式", "工具参数").Replace("方括号内的内容使用全角括号代替半角方括号。", "");
    }
    public static ChatToolRequest Create(CareerData data, PrivateConversation? conversation = null, PrivateTurn? turn = null, GroupChat? group = null)
    {
        var features = Features(group != null).ToList();
        if (turn?.Scene is { Ending: false } scene)
            features.Add(new("scene", "Scene", DateScenes.Guidance(scene, tools: true), ["Scene", "Emotion", "Background"]));
        if (turn?.Scene is { Ending: true })
            features.Add(new("date_diary", "DateDiary", DateDiaries.ToolEnding, ["DateDiary", "Location"]));
        if (group == null && conversation != null && CareerEngine.Person(data, conversation.PersonId) is { } person
            && !(OwnedClubs.CanOperate(data) && person.ClubId != data.Esports.ClubId && OwnedClubs.IsRecruitable(person)))
            features.RemoveAll(f => f.Name == "contract");
        var definitions = features.Where(f => f.Name != "scene").Select(f =>
        {
            var fields = f.Fields.ToList();
            if (group != null) fields.Add("Actor");
            if (group != null) fields.AddRange(f.Name switch
            {
                "relationship" or "match" => ["Target"], "activity" => ["Participants"],
                "post" => ["Related"], "training" => ["Coach"], _ => Array.Empty<string>()
            });
            var properties = fields.ToDictionary(k => k, k => (object)new Dictionary<string, object>
            {
                ["type"] = k is "Favour" or "Skill" or "Mood" or "Days" or "Ascension" or "Signing" or "Wage" or "WinBonus" or "Weeks" ? "integer" : "string",
                ["description"] = k switch
                {
                    "Actor" => "作出决定或变化的人物编号，活动采用实际发起人。",
                    "Target" => "关系或约战的对方人物编号。",
                    "Participants" => "共同活动已经谈妥的完整参与者编号，以竖线分隔。",
                    "Related" => "发帖希望回应的人物编号，以竖线分隔。",
                    "Coach" => "训练教练的人物编号。",
                    "Id" => "邀请新活动填0；接受、拒绝或改期时填写本轮对应类型的待处理卡片实际编号。",
                    _ => "含义和适用条件见本工具说明中的 " + k + "。"
                }
            });
            properties["Type"] = new { type = "string", @enum = new[] { f.Name } };
            var required = new List<string> { "Type" };
            if (f.Key.Length > 0) required.AddRange(f.Fields);
            if (group != null) required.Add("Actor");
            if (group != null && f.Name is "relationship" or "match") required.Add("Target");
            if (group != null && f.Name == "activity") required.Add("Participants");
            // 活动意愿统一放在工具总说明，字段说明只保留动作与参数规则。
            string description = Describe(f.Description);
            if (f.Name == "skill") description = description.Replace("普通聊天无需附带任何工具参数。", "本轮没有上述学习变化时省略 skill 交互，其他交互按各自说明判断。");
            if (group != null)
                description = description.Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")
                    .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法")
                    + "\n" + Describe(string.Join("\n", GroupChatPrompts.ActorFormat.Split('\n').Where((line, index) => index is 0 or 2 or 7
                        || f.Name == "match" && index == 3 || f.Name is "relationship" or "skill" && index == 4
                        || f.Name == "training" && index == 5 || f.Name == "post" && index == 6)));

            // 严格格式要求对象内的字段全部必填，用字段组合保留原协议的可省略参数。
            string[] optional = properties.Keys.Except(required).ToArray();
            object[] variants = Enumerable.Range(0, 1 << optional.Length).Select(mask =>
            {
                var selected = properties.Where(p => required.Contains(p.Key) || (mask & (1 << Array.IndexOf(optional, p.Key))) != 0).ToDictionary(p => p.Key, p => p.Value);
                return (object)new { type = "object", properties = selected, required = selected.Keys.ToArray(), additionalProperties = false };
            }).ToArray();
            return (object)new { description = description.Replace("对应工具", "对应交互项").Replace("本工具", "本交互项"), anyOf = variants };
        }).ToArray();
        var replyProperties = new Dictionary<string, object>();
        if (group != null) replyProperties["Speaker"] = new { type = "string", description = "本段实际发言者，填写本群可发言的NPC编号，先于 Reply 填写。" };
        if (turn?.Scene is { Ending: false })
            foreach (string key in new[] { "Scene", "Emotion", "Background" })
                replyProperties[key] = new { type = "string", description = "沿用本次约会场景资料中的 " + key + "，先于 Reply 填写。" };
        replyProperties["Reply"] = new { type = "string", description = "本段完整正文，保持当前模板要求的文风与篇幅，包含角色语言或约会旁白。" };
        string replyDescription = turn?.Scene is { Ending: false } active
            ? Describe(DateScenes.Guidance(active, tools: true)) : "按发言顺序填写完整正文。";
        object[] interactions = definitions;
        var exampleReply = new Dictionary<string, object>();
        if (group != null) exampleReply["Speaker"] = "p2";
        if (turn?.Scene is { Ending: false } exampleScene)
        { exampleReply["Scene"] = "dialogue"; exampleReply["Emotion"] = exampleScene.DefaultEmotionId; exampleReply["Background"] = "current"; }
        exampleReply["Reply"] = "明天再切磋一局吧，我把今天没弄明白的地方整理好。";
        var exampleAction = new Dictionary<string, object> { ["Type"] = "match", ["Match"] = "邀请", ["Date"] = "2026-01-18", ["Ascension"] = 6, ["Mode"] = "切磋" };
        if (group != null)
        {
            exampleReply["Reply"] = "明天一起看录像吧，我把今天没弄明白的地方整理好。";
            exampleAction = new() { ["Type"] = "activity", ["Activity"] = "邀请", ["Id"] = "0", ["Title"] = "一起看录像", ["Date"] = "2026-01-18", ["Detail"] = "讨论今天的比赛", ["Actor"] = "p2", ["Participants"] = "p1|p2" };
        }
        string exampleReasoning = group != null ? "共同活动已有成员同意参加，按实际日期、内容与谈妥的参与者登记一项活动邀请。" : "双方已经表达再次切磋的意向，按本轮实际日期与进阶登记邀请。";
        bool ending = turn?.Scene?.Ending == true;
        if (ending)
        {
            exampleReply["Reply"] = "今天和你聊得很开心，回去路上还在想我们刚才说的事。";
            exampleReasoning = "本次相处已结束，根据完整记录发送感想，并整理这场约会的日记。";
            exampleAction = new() { ["Type"] = "date_diary", ["DateDiary"] = "今天和他按约定见面，聊起各自最近的生活。原本只想简单说几句，后来却越聊越放松。离开时，我还惦记着刚才没说完的话。", ["Location"] = "地点未明确" };
        }
        string example = JsonSerializer.Serialize(new { Reasoning = exampleReasoning, Replies = new[] { exampleReply }, Interactions = new[] { exampleAction } }, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        object[] tools = [new { type = "function", function = new { name = "send_message", strict = true, description = Guidance + (group != null ? "\n共同活动已有日期，且正文中有人明确表示参加时，Interactions 同时登记 activity 邀请，填写已谈妥的活动内容和参与者。正文与交互登记同一个决定。" : "") + "\n以下只演示参数组织，人物、日期、进阶和正文取自本轮实际交流：\n" + example + "\n" + ActivityIntentGuidance + "\n" + OrdinaryGuidance + (ending ? "\n" + DateDiaries.ToolEnding : ""),
            parameters = new { type = "object", properties = new Dictionary<string, object>
            {
                ["Reasoning"] = new { type = "string", description = (group != null ? "区分生活活动与比赛约战：生活活动已有日期且成员明确同意参加时，按已谈妥的活动内容和完整参与者登记同一项活动邀请；比赛约战再填写比赛进阶与方式。" : "") + "先核对人物、日期、待处理卡片的实际类型和编号、当前活动是否已经确认或赴约，再根据已有事实和交流资料整理人物反应、回复安排及实际交互决定。新约定采用邀请；正在履行的活动继续当前场景。" },
                ["Replies"] = new { type = "array", description = replyDescription, items = new { type = "object", properties = replyProperties, required = replyProperties.Keys.ToArray(), additionalProperties = false } },
                ["Interactions"] = new { type = "array", description = ending ? DateDiaries.ToolEnding : "必须填写本轮的全部实际交互，无交互填 []。每项的 Type 选择其类型，其余字段按该项说明填写。", items = new { anyOf = interactions } }
            }, required = new[] { "Reasoning", "Replies", "Interactions" }, additionalProperties = false } } }];
        return new(features, tools, group != null);
    }
}

public sealed class ChatToolCall
{
    public int Index { get; set; }
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    private readonly StringBuilder _arguments = new();
    public string Arguments { get => _arguments.ToString(); set { _arguments.Clear(); _arguments.Append(value); } }
    internal void AppendArguments(string? value) => _arguments.Append(value);
}

/// <summary>按索引拼接流式工具参数，完整返回后转换为原交互字段；单项错误保留其余正文和交互。</summary>
public sealed class ChatToolRequest
{
    private readonly Dictionary<string, ChatTools.Feature> _features;
    private readonly Dictionary<int, ChatReplyStream> _streams = [];
    public object[] Definitions { get; }
    public bool Group { get; }
    public List<ChatToolCall> Calls { get; } = [];
    public string Error { get; private set; } = "";
    internal ChatToolRequest(IEnumerable<ChatTools.Feature> features, object[] definitions, bool group)
    { _features = features.ToDictionary(f => f.Name, StringComparer.OrdinalIgnoreCase); Definitions = definitions; Group = group; }
    public void Feed(JsonElement message, Action<string>? progress = null, Action<string>? reasoning = null)
    {
        if (!message.TryGetProperty("tool_calls", out var calls) || calls.ValueKind != JsonValueKind.Array) return;
        int fallback = 0;
        foreach (var item in calls.EnumerateArray())
        {
            int index = item.TryGetProperty("index", out var n) ? n.GetInt32() : fallback; fallback++;
            var call = Calls.FirstOrDefault(c => c.Index == index);
            if (call == null) { call = new() { Index = index }; Calls.Add(call); }
            if (item.TryGetProperty("id", out var id)) call.Id += id.GetString();
            if (item.TryGetProperty("function", out var function))
            {
                if (function.TryGetProperty("name", out var name)) call.Name += name.GetString();
                if (function.TryGetProperty("arguments", out var args)) call.AppendArguments(args.GetString());
                if (call.Name == "send_message")
                {
                    if (!_streams.TryGetValue(index, out var reader))
                    { reader = new(Group); _streams[index] = reader; reader.Feed(call.Arguments, progress, reasoning); }
                    else if (function.TryGetProperty("arguments", out args)) reader.Feed(args.GetString() ?? "", progress, reasoning);
                }
            }
        }
    }
    private IEnumerable<(Dictionary<string, string> Fields, string Reply, string Speaker)> Read()
    {
        foreach (var call in Calls.OrderBy(c => c.Index))
        {
            JsonDocument? json = null;
            try
            {
                json = JsonDocument.Parse(call.Arguments);
            }
            catch (JsonException e) { RecordError(call.Name, e.Message); }
            if (json == null) continue;
            using (json)
            {
                var root = json.RootElement;
                if (call.Name != "send_message")
                {
                    if (ReadItem(call.Name, root) is { } legacy) yield return legacy;
                    continue;
                }
                if (root.ValueKind != JsonValueKind.Object) { RecordError(call.Name, "参数应为对象"); continue; }
                if (root.TryGetProperty("Replies", out var replies) && replies.ValueKind == JsonValueKind.Array)
                    foreach (var reply in replies.EnumerateArray())
                    {
                        if (reply.ValueKind != JsonValueKind.Object) { RecordError(call.Name, "正文段落应为对象"); continue; }
                        var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                        foreach (string key in new[] { "Scene", "Emotion", "Background" })
                            if (reply.TryGetProperty(key, out var value)) fields[key] = Value(value);
                        yield return (fields, reply.TryGetProperty("Reply", out var text) ? Value(text) : "", reply.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : "");
                    }
                if (root.TryGetProperty("Reply", out var simple)) yield return (new(), Value(simple), root.TryGetProperty("Speaker", out var speaker) ? Value(speaker) : "");
                if (root.TryGetProperty("Interactions", out var interactions) && interactions.ValueKind == JsonValueKind.Array)
                    foreach (var item in interactions.EnumerateArray())
                        if (item.ValueKind == JsonValueKind.Object && item.TryGetProperty("Type", out var type)
                            && ReadItem(Value(type), item) is { } action) yield return action;
            }
        }
    }
    private string Value(JsonElement value)
    {
        try { return value.ValueKind == JsonValueKind.String ? value.GetString()!
            : value.ValueKind == JsonValueKind.Array ? string.Join("|", value.EnumerateArray().Select(v => v.ToString())) : value.ToString(); }
        catch (InvalidOperationException e) { RecordError("send_message", e.Message); return value.GetRawText(); }
    }
    private (Dictionary<string, string> Fields, string Reply, string Speaker)? ReadItem(string name, JsonElement item)
    {
        if (!_features.TryGetValue(name, out var feature)) { RecordError(name, "未知交互类型"); return null; }
        if (item.ValueKind != JsonValueKind.Object) { RecordError(name, "参数应为对象"); return null; }
        var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase); string reply = "", speaker = "";
        foreach (var p in item.EnumerateObject())
        {
            string value = Value(p.Value);
            if (p.Name == "Reply") reply = value;
            else if (p.Name == "Speaker") speaker = value;
            else if (feature.Fields.Contains(p.Name) || Group && p.Name is "Actor" or "Target" or "Participants" or "Related" or "Coach") fields[p.Name] = value;
        }
        return (fields, reply, speaker);
    }
    private void RecordError(string name, string reason)
    { string text = "工具 " + name + " 参数未能读取：" + reason; if (!Error.Contains(text, StringComparison.Ordinal)) Error += "\n" + text; }
    public string FallbackText()
    {
        var seen = new HashSet<string>(StringComparer.Ordinal); var replies = new List<string>();
        foreach (var x in Read().Where(x => x.Reply.Length > 0))
        {
            string text = Group ? "[Speaker: " + (x.Speaker.Length > 0 ? x.Speaker : x.Fields.GetValueOrDefault("Actor", "")) + "]\n" + x.Reply : x.Reply;
            if (x.Fields.Count == 0 || x.Fields.ContainsKey("Scene") || seen.Add(text)) replies.Add(text);
        }
        return string.Join("\n", replies);
    }
    public void Apply(PrivateStreamParser parser)
    {
        int sceneOffset = 0;
        foreach (var (fields, reply, _) in Read())
        {
            if (fields.ContainsKey("Scene"))
            {
                int offset = parser.Text.IndexOf(reply, sceneOffset, StringComparison.Ordinal);
                parser.SceneCues.Add((Math.Max(0, offset), fields));
                if (offset >= 0) sceneOffset = offset + reply.Length;
            }
            else if (fields.Count > 0 && !parser.Directives.Any(old => old.Count == fields.Count && old.All(p => fields.GetValueOrDefault(p.Key) == p.Value))) parser.Directives.Add(fields);
        }
    }
}

/// <summary>只增量读取正文段落的字符串；参数全文由调用记录保存，交互在完整解析后执行。</summary>
internal sealed class ChatReplyStream(bool group)
{
    private sealed class Frame(char kind, bool replies, bool paragraph)
    {
        public char Kind = kind;
        public bool Replies = replies, Paragraph = paragraph, KeyExpected = kind == '{', Opened;
        public string Key = "";
        public Dictionary<string, string> Metadata = [];
        public StringBuilder Pending = new();
    }
    private readonly Stack<Frame> _frames = new();
    private readonly StringBuilder _token = new();
    private bool _quoted, _key, _escape;
    private int _unicodeLeft, _unicode;
    private string _field = "";
    private Frame? _owner;
    public void Feed(string chunk, Action<string>? progress, Action<string>? reasoning)
    {
        var output = new StringBuilder(); var analysis = new StringBuilder();
        void Flush(Frame frame)
        {
            if (frame.Pending.Length == 0 || frame.Paragraph && group && !frame.Metadata.ContainsKey("Speaker")) return;
            int count = frame.Pending.Length;
            if (char.IsHighSurrogate(frame.Pending[count - 1])) count--;
            if (count == 0) return;
            if (!frame.Paragraph)
            { analysis.Append(frame.Pending.ToString(0, count)); frame.Pending.Remove(0, count); return; }
            if (!frame.Opened)
            {
                if (group) output.Append("[Speaker: ").Append(frame.Metadata["Speaker"]).Append("]\n");
                else if (frame.Metadata.ContainsKey("Scene"))
                    output.Append("[Scene: ").Append(frame.Metadata["Scene"]).Append(", Emotion: ").Append(frame.Metadata.GetValueOrDefault("Emotion", "neutral"))
                        .Append(", Background: ").Append(frame.Metadata.GetValueOrDefault("Background", "current")).Append(']');
                frame.Opened = true;
            }
            output.Append(frame.Pending.ToString(0, count)); frame.Pending.Remove(0, count);
        }
        void Character(char c)
        {
            if (!_key && _owner != null && (_owner.Paragraph && _field == "Reply" || _frames.Count == 1 && _field == "Reasoning")) _owner.Pending.Append(c);
            else if (_key || _owner?.Paragraph == true && _field is "Speaker" or "Scene" or "Emotion" or "Background") _token.Append(c);
        }
        foreach (char c in chunk)
        {
            if (_quoted)
            {
                if (_unicodeLeft > 0)
                {
                    int digit = c is >= '0' and <= '9' ? c - '0' : c is >= 'a' and <= 'f' ? c - 'a' + 10 : c is >= 'A' and <= 'F' ? c - 'A' + 10 : 0;
                    _unicode = (_unicode << 4) + digit;
                    if (--_unicodeLeft == 0) Character((char)_unicode);
                }
                else if (_escape)
                {
                    _escape = false;
                    if (c == 'u') { _unicodeLeft = 4; _unicode = 0; }
                    else Character(c switch { 'n' => '\n', 'r' => '\r', 't' => '\t', 'b' => '\b', 'f' => '\f', _ => c });
                }
                else if (c == '\\') _escape = true;
                else if (c == '"')
                {
                    _quoted = false;
                    if (_key && _owner != null) { _owner.Key = _token.ToString(); _owner.KeyExpected = false; }
                    else if (_owner?.Paragraph == true && _field is "Speaker" or "Scene" or "Emotion" or "Background") _owner.Metadata[_field] = _token.ToString();
                    _token.Clear();
                    if (_owner != null && (_owner.Paragraph || _field == "Reasoning")) Flush(_owner);
                }
                else Character(c);
                continue;
            }
            _frames.TryPeek(out var parent);
            if (c == '"')
            { _quoted = true; _owner = parent; _key = parent?.KeyExpected == true; _field = parent?.Key ?? ""; _token.Clear(); }
            else if (c is '{' or '[')
                _frames.Push(new(c, c == '[' && parent?.Key == "Replies", c == '{' && parent?.Replies == true));
            else if (c is '}' or ']')
            {
                if (_frames.TryPop(out var frame) && frame.Paragraph)
                { Flush(frame); if (frame.Opened) output.Append('\n'); }
            }
            else if (c == ',' && parent?.Kind == '{') { parent.KeyExpected = true; parent.Key = ""; }
        }
        if (_owner != null && (_owner.Paragraph || _field == "Reasoning")) Flush(_owner);
        if (analysis.Length > 0) reasoning?.Invoke(analysis.ToString());
        if (output.Length > 0) progress?.Invoke(output.ToString());
    }
}
