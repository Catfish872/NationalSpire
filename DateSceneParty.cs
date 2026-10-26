using System.Text.Json;

namespace NationalSpire;

/// <summary>约会参与者及白名单；台词与交互通过稳定人物编号归属。</summary>
public sealed class DateSceneParticipant
{
    public string PersonId { get; set; } = "";
    public string Name { get; set; } = "";
    public string OutfitId { get; set; } = "";
    public string DefaultEmotionId { get; set; } = "neutral";
    public Dictionary<string, string> Emotions { get; set; } = [];
}

public static class DateSceneParty
{
    internal static readonly JsonSerializerOptions PromptJson = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    public const int VisibleMaximum = 3;
    public const string Protocol = """
本轮是多人在场的连续约会场景。前文以单个私信对象表述的人称在此扩展为参与者名单中的全部NPC；逐人保留原人物设定、说话方式、用词约束和私人记忆边界。
本轮至少让两名在场NPC直接回应彼此，围绕同一个话题往返接话；已经说过话的人应再次回应后续人物。组织为A→B→A、A→B→C→A→B等连续交流，每次接话1—2个短句，在同一轮内完成数次往返。NPC可以追问、补充、打趣或接续其他NPC的动作，分别保持自己的观点；玩家的发言和行动由玩家决定。人数较多时由当前相关的2—3人展开互动，其余人保留在场。玩家明确指定单独回答或保持沉默时依照该要求。
每个完整台词句子都独立写一个Scene标记，即使说话人相同也重新写Speaker和Emotion。每句依据当前语气、动作及对上一人的反应重新选择表情；情绪相同可以复用，发生变化时立即改用相应可用编号。每句填写说话者的完整PersonId，并使用该人物自己的可用Emotion编号：
[Scene: dialogue, Speaker: 人物PersonId, Emotion: neutral, Background: current]台词
旁白仍使用Scene: narration。台词只属于Speaker标明的人物，玩家的发言和行动由玩家决定。
每个关系、状态、档案或学习标记都填写Actor为实际发生变化的NPC完整PersonId，例如 [Favour: 23, Actor: 人物PersonId]、[Skill: 1, Topic: 防御, Reason: 学会依据下回合伤害保留格挡, Actor: 人物PersonId]。关系变化的对象为玩家。其余交互由本次活动的主联系人处理。
""";
    public static string ExchangeExample(DateSceneRequest scene)
    {
        if (scene.Participants.Count < 2) return "";
        var a = scene.Participants[0]; var b = scene.Participants[1];
        string Changed(DateSceneParticipant p) => p.Emotions.Keys.FirstOrDefault(id => id != p.DefaultEmotionId) ?? p.DefaultEmotionId;
        string Line(DateSceneParticipant p, string emotion, string text) => $"[Scene: dialogue, Speaker: {p.PersonId}, Emotion: {emotion}, Background: current]{text}";
        return "\n交错与逐句标注示例（只示范结构，具体话题根据当前情境）：\n"
            + Line(a, a.DefaultEmotionId, b.Name + "，你刚才也注意到了？") + "\n"
            + Line(b, Changed(b), "嗯，我还想听你多说一点。") + "\n"
            + Line(a, Changed(a), "好，那我们一起想想。") + "\n"
            + Line(b, b.DefaultEmotionId, "我有一个想法，大家听听看？");
    }
    public static List<string> People(CareerData data, PrivateOffer offer, string host)
        => new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null).Distinct().ToList();
    public static bool Eligible(CareerData data, PrivateOffer offer, PrivateConversation? conversation)
        => conversation != null && offer.Kind == "activity" && offer.GroupId.Length == 0
            && People(data, offer, conversation.PersonId).Count >= 1
            && (offer.Participants.Count == 0 || offer.Participants.Contains(GroupChats.Human(data)));
    public static string? Validate(CareerData data, PrivateConversation conversation, PrivateOffer offer, DateSceneRequest request)
    {
        var people = People(data, offer, conversation.PersonId);
        // 旧单人场景继续沿用顶层立绘字段。
        if (request.Participants.Count == 0) return people.Count == 1 ? null : "请重新打开场景以载入所有参与者的立绘。";
        if (request.Participants.Count != people.Count || !request.Participants.Select(p => p.PersonId).ToHashSet().SetEquals(people)) return "参与者名单已变化，请重新打开场景。";
        foreach (var member in request.Participants)
        {
            if (!PrivateMessages.CanChat(data, member.PersonId)) return "参与者当前无法聊天。";
            if (!PortraitDesigns.SafeId(member.OutfitId) || member.Emotions.Count == 0 || member.Emotions.Count > 100
                || !member.Emotions.ContainsKey(member.DefaultEmotionId) || member.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))) return "参与者立绘差分编号无效。";
            member.Name = CareerEngine.DisplayName(data, member.PersonId);
        }
        return null;
    }
    public static string Resolve(DateSceneRequest scene, string speaker)
        => scene.Participants.FirstOrDefault(p => p.PersonId == speaker || p.Name == speaker)?.PersonId
            ?? scene.Participants.FirstOrDefault()?.PersonId ?? "";
    public static DateSceneRequest ForSpeaker(DateSceneRequest scene, string speaker)
    {
        var member = scene.Participants.FirstOrDefault(p => p.PersonId == speaker);
        return member == null ? scene : new() { Emotions = member.Emotions, DefaultEmotionId = member.DefaultEmotionId };
    }
    public static float Position(int count, int index) => count switch { 2 => .3f + .4f * index, 3 => .2f + .3f * index, _ => .5f };
    public static string Context(CareerData data, DateSceneRequest scene)
        => "主联系人使用前文人物资料、关系与记忆。其余约会参与者资料（人物编号仅用于归属）：\n" + JsonSerializer.Serialize(scene.Participants.Skip(1).Select(p => new
        {
            p.PersonId, p.Name,
            profile = PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!),
            relation = RelationContext(PrivateMessages.Relation(data, p.PersonId)),
            memory = PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten
                ? string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text)
                    .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3)
                        .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))) : ""
        }), PromptJson);
    private static object RelationContext(PrivateRelation relation) => new { relation.Favour, relation.Impression, relation.Relationship, relation.SelectedBond, relation.OathConfirmed };
    public static string SharedMemory(CareerData data, string person, string excludeTurn)
    {
        var turns = PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten)
            .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted
                && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day).ThenBy(t => t.ReplyOrder).TakeLast(5);
        return string.Join("", turns.Select(t => "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n"
            + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t) + "\n" + (t.UserDeleted || t.Scene.GameEvent.Length > 0 ? "" : "玩家：" + t.User + "\n")
            + string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l)))));
    }
}
