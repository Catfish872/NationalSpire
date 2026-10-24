using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Globalization;

namespace NationalSpire;

public sealed class DateSceneRequest
{
    public string OfferId { get; set; } = "";
    public string DefaultEmotionId { get; set; } = "neutral";
    public string Title { get; set; } = "";
    public string Detail { get; set; } = "";
    public string OutfitId { get; set; } = "";
    public bool Opening { get; set; }
    public bool Ending { get; set; }
    public Dictionary<string, string> Emotions { get; set; } = [];
    public Dictionary<string, string> Backgrounds { get; set; } = [];
    public string CurrentBackground { get; set; } = "";
}
public sealed class DateSceneLine
{
    public string Text { get; set; } = "";
    public string Emotion { get; set; } = "neutral";
    public bool Narration { get; set; }
    public string Background { get; set; } = "";
}
/// <summary>约会视图沿用已赴约的一对一活动；逐句标注只能选择已有句段和差分编号。</summary>
public static class DateScenes
{
    public const string Protocol = """
当前进入约会场景，继续使用双方已有私聊记录和关系。围绕约会地点、共同活动与彼此感受展开交流。
台词与旁白分行输出，每段开头填写Scene、Emotion、Background。Scene填dialogue或narration；Emotion填写本轮可用表情编号；Background填写本轮可用背景编号，沿用当前背景时填current。人物台词保持角色原有说话方式；旁白描述环境及人物动作。
台词示例：
[Scene: dialogue, Emotion: neutral, Background: current]今天想先去哪里走走？
旁白示例：
[Scene: narration, Emotion: neutral, Background: current]窗边透进柔和的光，桌上的茶还冒着热气。
开场先描写约定地点及人物外观、姿态，再由人物说话。后续承接玩家本轮消息。玩家的发言和行动由玩家决定。活动、赠礼等交互继续使用各自格式。
""";
    public static string Guidance(DateSceneRequest scene, bool tools = false)
    {
        string protocol = Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId);
        if (tools)
        {
            string Example(string kind, string reply) => JsonSerializer.Serialize(new { Scene = kind, Emotion = scene.DefaultEmotionId, Background = "current", Reply = reply },
                new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            protocol = protocol.Replace("台词与旁白分行输出，每段开头填写Scene、Emotion、Background。", "每段台词或旁白按顺序写入 send_message 的 Replies，每段先填 Scene、Emotion、Background，再填写这一段完整文字 Reply。")
                .Replace("[Scene: dialogue, Emotion: " + scene.DefaultEmotionId + ", Background: current]今天想先去哪里走走？", Example("dialogue", "今天想先去哪里走走？"))
                .Replace("[Scene: narration, Emotion: " + scene.DefaultEmotionId + ", Background: current]窗边透进柔和的光，桌上的茶还冒着热气。", Example("narration", "窗边透进柔和的光，桌上的茶还冒着热气。"))
                .Replace("台词示例：", "Replies 中的台词参数示例：").Replace("旁白示例：", "Replies 中的旁白参数示例：")
                .Replace("各自格式", "Interactions 中各项的参数规则");
        }
        return protocol + "\n当前场景资料：" + JsonSerializer.Serialize(new { scene.Title, scene.Detail, scene.Opening, defaultEmotion = scene.DefaultEmotionId,
            emotions = scene.Emotions, backgrounds = scene.Backgrounds, currentBackground = scene.CurrentBackground });
    }
    public static bool SafeBackgroundId(string id) => id.Length is > 0 and <= 100 && id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-');
    public static bool OneToOne(CareerData data, PrivateOffer offer, PrivateConversation? conversation) => offer.Kind == "activity" && offer.GroupId.Length == 0
        && (offer.Participants.Count == 0 || offer.Participants.Distinct().Count() == 2
            && offer.Participants.Contains(GroupChats.Human(data)) && conversation != null && offer.Participants.Contains(conversation.PersonId));
    public static bool Available(CareerData data, PrivateOffer offer, PrivateConversation? conversation = null) => OneToOne(data, offer, conversation)
        && offer.State == "已赴约" && (PrivateAppointments.Date(data, offer) == data.Day || conversation != null && (conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused" || conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)))
        && conversation?.DateSceneStates.GetValueOrDefault(offer.Id) != "ended";
    public static string? Leave(CareerData data, PrivateConversation conversation, string offerId, bool end)
    {
        if (conversation.DateSceneStates.GetValueOrDefault(offerId) == "ended") return end ? null : "这场约会已经结束。";
        var offer = conversation.Offers.FirstOrDefault(o => o.Id == offerId);
        if (offer == null || !Available(data, offer, conversation)) return "当前约会已不可继续。";
        bool entered = conversation.DateSceneStates.GetValueOrDefault(offerId) is "active" or "paused"
            || conversation.Turns.Any(t => t.Scene is { Opening: true } scene && scene.OfferId == offerId);
        conversation.DateSceneStates[offerId] = end ? "ended" : "paused";
        if (end && conversation.Turns.LastOrDefault(t => t.Status is "queued" or "sending" && t.Scene?.OfferId == offerId) is { } turn)
        {
            PrivateMessageCommands.RestoreInterrupted(turn, "本次约会已结束，生成已停止。");
            AiService.CancelPrivate(data, conversation.PersonId);
        }
        if (end)
        {
            offer.State = "已结束";
            DateDiaries.Begin(conversation, offer);
            var reflection = PrivateMessages.Enqueue(data, conversation.PersonId, $"（系统事件：本次约会《{offer.Title}》已结束。请给玩家发送相处后的感想，并整理自己的约会日记。）", queueAfterCurrent: true);
            reflection.Scene = new() { OfferId = offerId, Title = offer.Title, Detail = offer.Detail, Ending = true };
            if (entered) WeddingAppointments.Complete(data, offer);

        }
        return null;
    }
    public static string? Validate(CareerData data, PrivateConversation conversation, DateSceneRequest request)
    {
        var offer = conversation.Offers.FirstOrDefault(o => o.Id == request.OfferId);
        if (request.Ending)
        {
            if (offer?.Kind != "activity" || offer.GroupId.Length > 0 || conversation.DateSceneStates.GetValueOrDefault(request.OfferId) != "ended") return "约会结束状态无效。";
            request.Title = offer.Title; request.Detail = offer.Detail; return null;
        }
        if (offer == null || !Available(data, offer, conversation)) return "请在约定当天确认一对一活动的赴约，再进入场景；已结束的场景保持关闭。";
        if (request.Emotions == null || !request.Emotions.ContainsKey(request.DefaultEmotionId) || request.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))) return "立绘差分编号无效，请重新导入。";
        if (!PortraitDesigns.SafeId(request.OutfitId)) return "套装编号无效，请重新选择立绘套装。";
        if (request.Backgrounds == null || request.Backgrounds.Keys.Any(id => !SafeBackgroundId(id))) return "背景编号无效，请重新导入。";
        request.Title = offer.Title; request.Detail = offer.Detail;
        return null;
    }
    public static List<DateSceneLine> TaggedLines(PrivateStreamParser parser, DateSceneRequest scene)
    {
        string source = parser.Text; int start = source.Length - source.TrimStart().Length, end = source.TrimEnd().Length;
        if (end <= start) return [];
        var cues = parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList();
        var result = new List<DateSceneLine>(); int position = start; Dictionary<string, string>? fields = null;
        void Segment(int limit)
        {
            var lines = ReadSegment(source[position..limit], scene, fields);
            // 纯空白片段也保留在相邻句段，以保持正文与元数据的逐字一致。
            if (lines.Count == 0 && limit > position && result.Count > 0 && string.IsNullOrWhiteSpace(source[position..limit])) result[^1].Text += source[position..limit];
            result.AddRange(lines); position = limit;
        }
        foreach (var cue in cues) { Segment(cue.Offset); fields = cue.Fields; }
        Segment(end);
        foreach (var line in result) if (!scene.Emotions.ContainsKey(line.Emotion)) line.Emotion = scene.DefaultEmotionId;
        return JoinNarration(result);
    }
    private static string? EmotionId(DateSceneRequest scene, string value)
    {
        value = value.Trim().Trim('"', '\'', '`');
        foreach (var (id, description) in scene.Emotions)
        {
            string name = description.Split('：', ':')[0].Trim();
            if (id.Equals(value, StringComparison.OrdinalIgnoreCase) || name.Equals(value, StringComparison.OrdinalIgnoreCase)) return id;
        }
        foreach (string part in value.Split(['/', '／', '·', '|'], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
            if (part != value && EmotionId(scene, part) is { } found) return found;
        return null;
    }
    private static string InferEmotion(DateSceneRequest scene, string text)
    {
        if (scene.Emotions.Count < 2) return scene.DefaultEmotionId;
        var families = new[]
        {
            ("excited|兴奋|激动", "太棒了|太好了|好耶|耶！|哇！|迫不及待|激动"),
            ("shy|bashful|害羞", "害羞|脸红|不好意思|别这样看我|心跳|羞"),
            ("sad|depressed|沮丧|难过", "难过|伤心|失落|想哭|沮丧|眼泪"),
            ("angry|annoyed|懊恼|生气", "生气|气死|可恶|恼火|烦死|懊恼"),
            ("proud|骄傲|得意", "得意|骄傲|厉害吧|夸我|交给我|当然啦"),
            ("disgusted|disdain|嫌弃", "嫌弃|恶心|讨厌|受不了|真是的"),
            ("patient|忍耐|克制", "忍住|忍耐|冷静一下|克制|深呼吸"),
            ("surprised|惊讶|吃惊", "没想到|真的吗|居然|吓一跳|惊讶"),
            ("happy|开心|愉快", "开心|高兴|哈哈|嘿嘿|真好|喜欢|谢谢你")
        };
        foreach (var (names, words) in families)
            if (Regex.IsMatch(text, words))
                foreach (var (id, description) in scene.Emotions)
                    if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;
        return scene.DefaultEmotionId;
    }
    private static List<DateSceneLine> ReadSegment(string text, DateSceneRequest scene, Dictionary<string, string>? fields)
    {
        var result = new List<DateSceneLine>();
        string kind = fields?.GetValueOrDefault("Scene", "").ToLowerInvariant() ?? "";
        string? emotion = fields?.ContainsKey("Emotion") == true ? EmotionId(scene, fields["Emotion"]) ?? scene.DefaultEmotionId : null;
        string background = fields?.GetValueOrDefault("Background", "") ?? "";
        void Add(string part)
        {
            var lines = Split(part, kind is "narration" or "旁白");
            foreach (var line in lines)
            {
                line.Narration |= kind is "narration" or "旁白";
                line.Emotion = line.Narration ? scene.DefaultEmotionId : emotion ?? InferEmotion(scene, line.Text);
            }
            if (lines.Count > 0 && scene.Backgrounds.ContainsKey(background)) { lines[0].Background = background; background = ""; }
            if (lines.Count == 0 && part.Length > 0 && result.Count > 0) result[^1].Text += part;
            result.AddRange(lines);
        }
        int at = 0;
        // 兼容已在用的圆括号ID和单独Emotion标签，仅移除白名单ID或明确元数据。
        foreach (Match tag in Regex.Matches(text, @"[\[（(【](?<value>[^\]\r\n）)】]{1,80})[\]）)】]"))
        {
            string value = tag.Groups["value"].Value.Trim();
            bool explicitEmotion = Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase);
            string candidate = explicitEmotion ? Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase) : value;
            string? found = EmotionId(scene, candidate);
            bool narration = value is "旁白" or "narration";
            if (found == null && !explicitEmotion && !narration) continue;
            Add(text[at..tag.Index]); at = tag.Index + tag.Length;
            if (narration) { kind = "narration"; emotion = null; }
            else { kind = "dialogue"; emotion = found ?? scene.DefaultEmotionId; }
        }
        Add(text[at..]); return result;
    }
    public static string? ReplyFailure(string text) => Regex.IsMatch(text,
        @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)
        ? "本轮回复包含模型拒绝生成的内容，请重新生成或编辑文字后发送。" : null;
    public const int MaxLineCharacters = 48;
    public static List<DateSceneLine> Split(string text, bool narration = false)
    {
        var result = new List<DateSceneLine>(); var buffer = new StringBuilder(); int depth = 0;
        void Flush()
        {
            if (buffer.Length == 0) return;
            string value = buffer.ToString(); buffer.Clear();
            if (string.IsNullOrWhiteSpace(value)) { if (result.Count > 0) result[^1].Text += value; return; }
            string trimmed = value.Trim();
            bool objective = narration || (trimmed.StartsWith('（') || trimmed.StartsWith('(')) && Regex.IsMatch(trimmed, "旁白|环境|阳光|灯光|风声|夜色|街道|窗外|微风|空气|抬起|低下|转身|望向|看向|走近|站在|坐在|微笑|轻轻|缓缓|她|他|少女|少年|女孩|男孩|耳朵|尾巴|指尖|脸颊|掌心|目光|视线|脚步|身旁|嘴角|双眼|嘴唇|肩膀");
            foreach (string part in ShortParts(value, objective ? int.MaxValue : MaxLineCharacters)) result.Add(new() { Text = part, Narration = objective });
        }
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch is '（' or '(' && depth == 0) Flush();
            buffer.Append(ch);
            if (ch is '（' or '(') depth++;
            if (ch is '）' or ')' && depth > 0) { depth--; if (depth == 0) Flush(); }
            else if (depth == 0 && (ch is '。' or '！' or '？' or '!' or '?' or '\n' || ch == '.' && (i + 1 == text.Length || char.IsWhiteSpace(text[i + 1]))))
            {
                while (i + 1 < text.Length && "。！？!?…\"”’」』）)".Contains(text[i + 1])) buffer.Append(text[++i]);
                Flush();
            }
        }
        Flush(); return result;
    }
    private static IEnumerable<string> ShortParts(string text, int limit)
    {
        int[] starts = StringInfo.ParseCombiningCharacters(text); int from = 0;
        while (from < starts.Length)
        {
            int through = from + Math.Min(limit, starts.Length - from), natural = -1;
            for (int i = from; i < through; i++)
            {
                char ch = text[starts[i]];
                if ("。！？!?\n".Contains(ch) || ch == '…' && i + 1 < starts.Length && text[starts[i + 1]] == '…')
                { through = i + 1; while (through < starts.Length && through - from < limit && "。！？!?…\"”’」』）)".Contains(text[starts[through]])) through++; break; }
                if (i - from >= 16 && ("，,；;：:、".Contains(ch) || char.IsWhiteSpace(ch))) natural = i + 1;
            }
            if (through - from == limit && through < starts.Length && natural > from) through = natural;
            yield return text[starts[from]..(through < starts.Length ? starts[through] : text.Length)]; from = through;
        }
    }
    public static List<DateSceneLine> Lines(PrivateTurn turn)
    {
        var source = turn.SceneLines.Count > 0 && string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply ? turn.SceneLines : Split(turn.Reply);
        return JoinNarration(source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine
        { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))
            .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList());
    }
    private static List<DateSceneLine> JoinNarration(List<DateSceneLine> lines)
    {
        var result = new List<DateSceneLine>();
        foreach (var line in lines)
        {
            if (line.Narration && line.Background.Length == 0 && result.LastOrDefault() is { Narration: true } previous
                && !Regex.IsMatch(previous.Text, "[。！？!?….][\\s\\\"”’」』）)]*$")) previous.Text += line.Text;
            else result.Add(line);
        }
        return result;
    }
    public static string BackgroundAt(IEnumerable<DateSceneLine> lines, int index, string initial)
        => lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0)?.Background ?? initial;
    public static string DisplayText(DateSceneLine line) => line.Narration
        ? line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "").Trim() : line.Text.Trim();
    public static string History(PrivateConversation conversation, string offerId, string currentTurn, int index, string player, string npc)
    {
        var result = new StringBuilder();
        foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == offerId))
        {
            if (!turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && turn.User.Length > 0) result.AppendLine(player).AppendLine(turn.User).AppendLine();
            if (!turn.ReplyDeleted && turn.Status == "complete")
                foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue))
                {
                    if (!line.Narration) result.AppendLine(npc);
                    result.AppendLine(DisplayText(line)).AppendLine();
                }
            if (turn.Id == currentTurn) break;
        }
        return result.Length > 0 ? result.ToString().TrimEnd() : "约会开始后的对话会显示在这里。";
    }
}
