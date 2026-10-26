using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Globalization;

namespace NationalSpire;

public sealed class DateSceneRequest
{
    public bool GameInvitation { get; set; }
    public string GameContext { get; set; } = "";
    public string GameChatRequest { get; set; } = "";
    public string GameMatchId { get; set; } = "";
    public string GameEvent { get; set; } = "";
    public List<DateSceneParticipant> Participants { get; set; } = [];
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
    public string Speaker { get; set; } = "";
    public string Text { get; set; } = "";
    public string Emotion { get; set; } = "neutral";
    public bool Narration { get; set; }
    public string Background { get; set; } = "";
}
/// <summary>约会视图沿用已赴约的活动；逐句标注只能选择已有句段和差分编号。</summary>
public static class DateScenes
{
    public const string Protocol = """
当前进入约会场景，继续使用双方已有私聊记录和关系。围绕约会地点、共同活动与彼此感受展开交流。
以下规则负责约会场景的组织及显示格式，人物语气、性格和用词沿前文规定。台词逐句输出：每个完整句子单独成行，每行开头填写Scene、Emotion、Background；连续属于同一人物的句子也逐句重新标注。Scene填dialogue或narration；Emotion依据这一句的情绪与动作从该人物可用编号重新选择，背景填写本轮可用编号，沿用当前背景时填current。情绪变化时切换对应差分，只有默认图的人物沿用默认编号。旁白按完整语句标注，描述环境及人物动作。
场景连续性：currentBackground是本轮开始时实际显示的地点与时段，说明见backgrounds；Title、Detail是原活动安排。优先承接当前地点和最近已经发生的行动。只有人物实际到达新地点或时间实际变化时，才在对应句段填写新背景编号，之后沿用current。current承接最近一次已发生的转场；回忆、提及其他地点、计划和待选建议均保持现场背景。空的currentBackground表示开场尚未选图，此时依据开场实际地点选择背景。
台词示例：
[Scene: dialogue, Emotion: neutral, Background: current]今天想先去哪里走走？
旁白示例：
[Scene: narration, Emotion: neutral, Background: current]窗边透进柔和的光，桌上的茶还冒着热气。
开场先描写约定地点及人物外观、姿态，再由人物说话。后续承接玩家本轮消息。玩家的发言和行动由玩家决定。活动、赠礼等交互继续使用各自格式。
正文结束后，提供两个简短且不同的玩家回应或动作建议，各用一行 [DateChoice: 建议文字]，每项最多24个字。建议由玩家选择后才发生，正文中保持尚未执行。建议须承接本轮对话；只输出这两条标记，不另写选项标题。
""";
    public static string Guidance(DateSceneRequest scene, bool tools = false)
    {
        string Format(string text) => tools ? ChatTools.SceneGuidance(text) : text;
        return Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId))
        + "\n历史记录会合并同人物、同情绪的连续片段；本轮输出仍逐句标注。当前场景资料（每人的emotions指向emotionSets中同名的完整差分字典）：" + PromptMaterials(scene)
        + (scene.Participants.Count > 1 ? "\n" + Format(DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene)) : "")
        + (scene.GameInvitation ? "\n" + Format(DateGames.InvitationProtocol) : "")
        + (scene.GameContext.Length > 0 ? "\n本轮消息中提供了当前对局编号、最新进程与聊天缘由，承接该进程交流。" + Format("依据玩家提出的具体技巧，使用现有Skill标记记录确实产生的学习。") : "");
    }
    private static string PromptMaterials(DateSceneRequest scene)
    {
        var sets = new Dictionary<string, Dictionary<string, string>>();
        var references = new Dictionary<string, string>(StringComparer.Ordinal);
        string Register(Dictionary<string, string> emotions)
        {
            string key = JsonSerializer.Serialize(emotions.OrderBy(p => p.Key, StringComparer.Ordinal), DateSceneParty.PromptJson);
            if (references.TryGetValue(key, out var existing)) return existing;
            string id = "emotions" + (sets.Count + 1);
            references.Add(key, id); sets.Add(id, emotions); return id;
        }
        // 全文描述保留；相同的素材字典只发送一次，主联系人的顶层旧字段由参与者资料替代。
        var participants = scene.Participants.Select(p => new
        { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray();
        string? singleEmotions = participants.Length == 0 ? Register(scene.Emotions) : null;
        var material = new Dictionary<string, object?>
        {
            ["Title"] = scene.Title, ["Detail"] = scene.Detail, ["Opening"] = scene.Opening,
            ["participants"] = participants, ["emotionSets"] = sets,
            ["backgrounds"] = scene.Backgrounds, ["currentBackground"] = scene.CurrentBackground
        };
        if (singleEmotions != null) { material["defaultEmotion"] = scene.DefaultEmotionId; material["emotions"] = singleEmotions; }
        return JsonSerializer.Serialize(material, DateSceneParty.PromptJson);
    }
    public static bool SafeBackgroundId(string id) => id.Length is > 0 and <= 100 && id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-');
    public static bool OneToOne(CareerData data, PrivateOffer offer, PrivateConversation? conversation) => offer.Kind == "activity" && offer.GroupId.Length == 0
        && (offer.Participants.Count == 0 || offer.Participants.Distinct().Count() == 2
            && offer.Participants.Contains(GroupChats.Human(data)) && conversation != null && offer.Participants.Contains(conversation.PersonId));
    public static bool Available(CareerData data, PrivateOffer offer, PrivateConversation? conversation = null) => DateSceneParty.Eligible(data, offer, conversation)
        && DateGroupBridge.SourceActive(data, offer)
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
            DateGroupBridge.Sync(data, offer);
            DateDiaries.Begin(conversation, offer);
            var reflection = PrivateMessages.Enqueue(data, conversation.PersonId, $"（系统事件：本次约会《{offer.Title}》已结束。请给玩家发送相处后的感想，并整理自己的约会日记。）", queueAfterCurrent: true);
            reflection.Scene = new() { OfferId = offerId, Title = offer.Title, Detail = offer.Detail, Ending = true };
            if (entered) WeddingAppointments.Complete(data, offer);

        }
        return null;
    }
    public static string? Validate(CareerData data, PrivateConversation conversation, DateSceneRequest request, bool retained = false)
    {
        var offer = conversation.Offers.FirstOrDefault(o => o.Id == request.OfferId);
        if (request.Ending)
        {
            if (offer?.Kind != "activity" || offer.GroupId.Length > 0 || conversation.DateSceneStates.GetValueOrDefault(request.OfferId) != "ended") return "约会结束状态无效。";
            request.Title = offer.Title; request.Detail = offer.Detail + (WeddingAppointments.IsWedding(offer) ? "\n" + WeddingAppointments.Description(data, offer) : ""); return null;
        }
        if (offer == null || !Available(data, offer, conversation)) return "请在约定当天确认活动赴约，再进入场景；已结束的场景保持关闭。";
        if (request.Emotions == null || !request.Emotions.ContainsKey(request.DefaultEmotionId) || request.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))) return "立绘差分编号无效，请重新导入。";
        if (!PortraitDesigns.SafeId(request.OutfitId)) return "套装编号无效，请重新选择立绘套装。";
        if (request.Backgrounds == null || request.Backgrounds.Keys.Any(id => !SafeBackgroundId(id))) return "背景编号无效，请重新导入。";
        if (DateSceneParty.Validate(data, conversation, offer, request) is { } partyError) return partyError;
        request.Title = offer.Title; request.Detail = offer.Detail + (WeddingAppointments.IsWedding(offer) ? "\n" + WeddingAppointments.Description(data, offer) : "");
        if (request.GameInvitation && (data.LocalHumanId.Length > 0 || data.PendingMatchId != null)) return "请在单人生涯的空闲时发起约会切磋。";
        if (DateGames.ValidateContext(data, conversation, request, retained) is { } gameError) return gameError;
        return null;
    }
    public static List<string> Choices(PrivateStreamParser parser) => parser.Directives
        .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))
        .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList();
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
        foreach (var line in result)
        {
            var speaker = DateSceneParty.ForSpeaker(scene, line.Speaker);
            if (!speaker.Emotions.ContainsKey(line.Emotion)) line.Emotion = speaker.DefaultEmotionId;
        }
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
        string speaker = DateSceneParty.Resolve(scene, fields?.GetValueOrDefault("Speaker", "") ?? "");
        var original = scene;
        scene = DateSceneParty.ForSpeaker(scene, speaker);
        string kind = fields?.GetValueOrDefault("Scene", "").ToLowerInvariant() ?? "";
        string? emotion = fields?.ContainsKey("Emotion") == true ? EmotionId(scene, fields["Emotion"]) ?? scene.DefaultEmotionId : null;
        string background = fields?.GetValueOrDefault("Background", "") ?? "";
        void Add(string part)
        {
            var lines = new List<DateSceneLine>();
            foreach (var sentence in SplitSentences(part, kind is "narration" or "旁白", int.MaxValue))
            {
                string sentenceEmotion = sentence.Narration ? scene.DefaultEmotionId : emotion ?? InferEmotion(scene, sentence.Text);
                foreach (var line in Split(sentence.Text, sentence.Narration))
                {
                    line.Speaker = line.Narration ? "" : speaker;
                    line.Emotion = sentenceEmotion;
                    lines.Add(line);
                }
                // 显式差分作用于完整句；为显示长度拆出的片段共享该句差分。
                if (!sentence.Narration) emotion = null;
            }
            if (lines.Count > 0 && original.Backgrounds.ContainsKey(background)) { lines[0].Background = background; background = ""; }
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
        => SplitSentences(text, narration, MaxLineCharacters);
    private static List<(int Start, int End)> ExpressionSpans(string text)
    {
        // 括号颜文字及常见文字表情作为完整单元；中文动作描述继续走旁白识别。
        const string pattern = @"[^\s\u3400-\u9fff，。！？；：“”‘’（）().!?:;]{0,24}[（(](?<face>[^（）()\r\n]{1,64})[）)][^\s\u3400-\u9fff，。！？；：“”‘’（）().!?:;]{0,24}"
            + @"(?:[ \t]+[\p{S}\p{M}\p{P}\u2500-\u257f]{1,16}){0,2}(?:[ \t]+[zZ](?:[ \t]*[zZ]){0,4})?"
            + @"|(?<![a-zA-Z0-9_])(?:[:;=8][-^']?[)(/\\DPpOo]|[\p{L}\p{S}][_^﹏‿ω][\p{L}\p{S}])(?![a-zA-Z0-9_])";
        var result = new List<(int, int)>();
        foreach (Match match in Regex.Matches(text, pattern, RegexOptions.CultureInvariant))
        {
            string face = match.Groups["face"].Value;
            if (face.Any(ch => ch is >= '\u3400' and <= '\u9fff') || match.Length > 120) continue;
            if (face.Length > 1 && !face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))) continue;
            result.Add((match.Index, match.Index + match.Length));
        }
        return result;
    }
    private static int SentenceTail(string text, int at, Dictionary<int, int> expressions)
    {
        while (at < text.Length)
        {
            if ("。！？!?…\"”’」』）)".Contains(text[at])) { at++; continue; }
            if (expressions.TryGetValue(at, out int end)) { at = end; continue; }
            if (Rune.TryGetRuneAt(text, at, out var rune) && Rune.GetUnicodeCategory(rune) is UnicodeCategory.OtherSymbol or UnicodeCategory.ModifierSymbol)
            { at += StringInfo.GetNextTextElement(text, at).Length; continue; }
            break;
        }
        return at;
    }
    private static List<DateSceneLine> SplitSentences(string text, bool narration, int limit)
    {
        var result = new List<DateSceneLine>(); var buffer = new StringBuilder(); int depth = 0;
        var expressions = ExpressionSpans(text).ToDictionary(span => span.Start, span => span.End);
        void Flush()
        {
            if (buffer.Length == 0) return;
            string value = buffer.ToString(); buffer.Clear();
            if (string.IsNullOrWhiteSpace(value)) { if (result.Count > 0) result[^1].Text += value; return; }
            string trimmed = value.Trim();
            bool objective = narration || (trimmed.StartsWith('（') || trimmed.StartsWith('(')) && Regex.IsMatch(trimmed, "旁白|环境|阳光|灯光|风声|夜色|街道|窗外|微风|空气|抬起|低下|转身|望向|看向|走近|站在|坐在|微笑|轻轻|缓缓|她|他|少女|少年|女孩|男孩|耳朵|尾巴|指尖|脸颊|掌心|目光|视线|脚步|身旁|嘴角|双眼|嘴唇|肩膀");
            foreach (string part in ShortParts(value, objective ? int.MaxValue : limit)) result.Add(new() { Text = part, Narration = objective });
        }
        for (int i = 0; i < text.Length; i++)
        {
            if (expressions.TryGetValue(i, out int expressionEnd))
            { buffer.Append(text, i, expressionEnd - i); i = expressionEnd - 1; continue; }
            char ch = text[i];
            if (ch is '（' or '(' && depth == 0) Flush();
            buffer.Append(ch);
            if (ch is '（' or '(') depth++;
            if (ch is '）' or ')' && depth > 0) { depth--; if (depth == 0) Flush(); }
            else if (depth == 0 && (ch is '。' or '！' or '？' or '!' or '?' or '\n' || ch == '.' && (i + 1 == text.Length || char.IsWhiteSpace(text[i + 1]))))
            {
                int end = SentenceTail(text, i + 1, expressions);
                buffer.Append(text, i + 1, end - i - 1); i = end - 1;
                Flush();
            }
        }
        Flush(); return result;
    }
    private static IEnumerable<string> ShortParts(string text, int limit)
    {
        int[] starts = StringInfo.ParseCombiningCharacters(text); int from = 0;
        var expressions = ExpressionSpans(text);
        bool CanCut(int at) => at == text.Length || at > 0 && text[at - 1] != '、' && text[at] != '、'
            && !expressions.Any(span => at > span.Start && at < span.End);
        while (from < starts.Length)
        {
            int through = from + Math.Min(limit, starts.Length - from), natural = -1;
            for (int i = from; i < through; i++)
            {
                char ch = text[starts[i]];
                if (i - from >= 16 && ("，,；;：:".Contains(ch) || char.IsWhiteSpace(ch))
                    && (i + 1 == starts.Length || CanCut(starts[i + 1]))) natural = i + 1;
            }
            if (through - from == limit && through < starts.Length && natural > from) through = natural;
            int fallback = through;
            while (through > from && through < starts.Length && !CanCut(starts[through])) through--;
            if (through == from)
            {
                through = fallback;
                while (through < starts.Length && !CanCut(starts[through])) through++;
            }
            yield return text[starts[from]..(through < starts.Length ? starts[through] : text.Length)]; from = through;
        }
    }
    public static List<DateSceneLine> Lines(PrivateTurn turn)
    {
        var source = turn.SceneLines.Count > 0 && string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply ? turn.SceneLines : Split(turn.Reply);
        return JoinNarration(source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine
        { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))
            .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList());
    }
    public static string PromptHistory(PrivateTurn turn, string host)
    {
        var result = new StringBuilder(); var body = new StringBuilder(); DateSceneLine? current = null;
        void Flush()
        {
            if (current == null) return;
            if (result.Length > 0) result.Append('\n');
            string background = current.Background.Length > 0 ? current.Background : "current";
            if (current.Narration)
                result.Append("[Scene: narration, Background: ").Append(background).Append(']')
                    .Append(DisplayText(new() { Narration = true, Text = body.ToString() }));
            else result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)
                .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background).Append(']').Append(body.ToString().Trim());
            body.Clear();
        }
        foreach (var line in Lines(turn))
        {
            // 历史恢复真实的说话人/情绪/转场边界；界面自动分页无需重复完整显示标签。
            bool same = current != null && line.Narration == current.Narration && line.Speaker == current.Speaker
                && (line.Narration || line.Emotion == current.Emotion) && line.Background.Length == 0;
            if (!same) { Flush(); current = line; }
            body.Append(line.Text);
        }
        Flush(); return result.ToString();
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
    public static string BackgroundAt(IEnumerable<DateSceneLine> lines, int index, string initial, ISet<string>? available = null)
        => lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0 && line.Background != "current"
            && (available == null || available.Contains(line.Background)))?.Background ?? initial;
    public static string DisplayText(DateSceneLine line) => line.Narration
        ? line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "").Trim() : line.Text.Trim();
    public static string History(PrivateConversation conversation, string offerId, string currentTurn, int index, string player, string npc)
    {
        var entries = HistoryEntries(conversation, offerId, currentTurn, index, player, npc);
        return entries.Count > 0 ? string.Join("\n\n", entries.Select(e => e.Text)) : "约会开始后的对话会显示在这里。";
    }
    public static IReadOnlyList<DateHistoryEntry> HistoryEntries(PrivateConversation conversation, string offerId, string currentTurn, int index, string player, string npc)
    {
        var result = new List<DateHistoryEntry>();
        foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == offerId))
        {
            if (!turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && string.IsNullOrEmpty(turn.Scene?.GameEvent) && turn.User.Length > 0) result.Add(new(turn.Id, player + "\n" + turn.User, false));
            if (!turn.ReplyDeleted && turn.Status == "complete")
            {
                var text = new StringBuilder();
                foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue))
                {
                    if (!line.Narration) text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc);
                    text.AppendLine(DisplayText(line)).AppendLine();
                }
                if (text.Length > 0) result.Add(new(turn.Id, text.ToString().TrimEnd(), true));
            }
            if (turn.Id == currentTurn) break;
        }
        return result;
    }
}
