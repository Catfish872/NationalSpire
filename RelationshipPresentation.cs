using System.Text.RegularExpressions;

namespace NationalSpire;

public readonly record struct RelationshipAppearance(int Tier, bool Lover, bool OathEligible);

/// <summary>个人关系展示的唯一判定入口。数值先分档，高于90才扫描关系文字；誓约由玩家确认。</summary>
public static class RelationshipPresentation
{
    private static readonly string[] Lovers = ["恋人", "情人", "爱人", "情侣", "伴侣", "男朋友", "女朋友", "男友", "女友", "专属"];
    private static readonly string[] Spouses = ["妻子", "丈夫", "老公", "老婆", "终身伴侣", "誓约", "夫妻", "配偶"];
    private static readonly Regex Negative = new(@"(?:不是|并非|并不|不再|尚未|还未|未曾|没有|拒绝|解除|取消|曾是|曾经是|前任|前|非)(?:成为|是|作为|的|了|一对|彼此的|对方的)?(?:终身)?\s*$", RegexOptions.CultureInvariant);
    public static int Tier(int favour) => favour switch { <= -30 => 0, < 0 => 1, < 25 => 2, < 50 => 3, < 75 => 4, _ => 5 };
    public static (int Low, int High) Range(int tier) => tier switch { 0 => (-100,-30), 1 => (-29,-1), 2 => (0,24), 3 => (25,49), 4 => (50,74), _ => (75,100) };
    public static float Progress(int favour)
    {
        var (low, high) = Range(Tier(favour));
        return Math.Clamp((favour - low) / (float)(high - low), 0, 1);
    }
    public static RelationshipAppearance Evaluate(int favour, string relationship)
    {
        int tier = Tier(favour);
        if (favour <= 90) return new(tier, false, false);
        bool spouse = HasKeyword(relationship, Spouses);
        return new(tier, spouse || HasKeyword(relationship, Lovers), favour == 100 && spouse);
    }
    private static bool HasKeyword(string text, IEnumerable<string> words)
    {
        foreach (string word in words)
            for (int index = text.IndexOf(word, StringComparison.Ordinal); index >= 0; index = text.IndexOf(word, index + word.Length, StringComparison.Ordinal))
            {
                string prefix = text.Substring(Math.Max(0, index - 12), Math.Min(12, index));
                if (!Negative.IsMatch(prefix)) return true;
            }
        return false;
    }
    public static bool IsRomantic(string relationship) => HasKeyword(relationship, Lovers) || HasKeyword(relationship, Spouses);
    public static bool OathAppearance(PrivateRelation? relation) => relation is { OathConfirmed: true, WeddingCompleted: true };
    public static string Bond(PrivateRelation relation) => OathAppearance(relation) ? "oath" : relation.Appearance.Lover ? "lover" : "none";
    public static void CompleteWedding(CareerData data, string person)
    {
        var relation = PrivateMessages.Relation(data, person);
        if (relation.WeddingCompleted) return;
        relation.WeddingCompleted = true; relation.OathConfirmed = true; relation.HighestBond = 2; relation.SelectedBond = 2;
        relation.OathDeferred = false; relation.OathPromptHidden = false; relation.OathReleaseReason = relation.OathReleaseTurn = "";
        relation.RefreshAppearance(); relation.Revision++;
        var mailbox = PrivateMessages.Mailbox(data); mailbox.NpcAvatarFrames[person] = "oath";
        PrivateInteractionHistory.PreserveRelation(mailbox, data.Chats, GroupChats.Human(data), person,
            [nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.HighestBond), nameof(PrivateRelation.SelectedBond),
             nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.OathReleaseReason), nameof(PrivateRelation.OathReleaseTurn)]);
    }
    public static string IconBond(PrivateRelation relation) => Bond(relation) is var bond && bond != "none" ? bond : relation.Favour < 5 ? "unfamiliar" : "none";
    public static int Unlocked(PrivateRelation relation) => Math.Max(relation.HighestBond, relation.OathConfirmed ? 2 : relation.Appearance.Lover ? 1 : 0);
    public static string? EditError(PrivateRelation relation, int value) => value is < 0 or > 2 ? "请选择有效的交往关系。"
        : value > Unlocked(relation) ? "该交往关系尚未达成。" : null;
    public static void Edit(PrivateRelation relation, int value)
    {
        if (EditError(relation, value) is { } error) throw new ArgumentException(error);
        relation.HighestBond = Unlocked(relation); relation.SelectedBond = value;
        relation.OathConfirmed = value == 2; relation.OathDeferred = true; relation.OathPromptHidden = true;
        relation.OathReleaseReason = relation.OathReleaseTurn = "";
        relation.Relationship = value switch { 2 => "婚约", 1 => "恋人", _ => "熟人" };
    }
    public static string? Decide(CareerData data, string person, string kind, PrivateMessageCommand command)
    {
        var r = PrivateMessages.Relation(data, person);
        if (kind == "dm-oath-release")
        {
            if (!r.OathConfirmed || r.OathReleaseReason.Length == 0) return "当前没有待处理的解除誓约请求。";
            if (command.Part is not ("release" or "keep")) return "请选择解除誓约或继续沟通。";
            if (string.IsNullOrWhiteSpace(command.Text)) return "请先填写给对方的回复。";
            PrivateMessages.Enqueue(data, person, command.Text).PromptInsertions = PromptInsertions.Copy(command.PromptInsertions);
            if (command.Part == "release") { r.OathConfirmed = false; r.OathDeferred = true; }
            r.OathReleaseReason = r.OathReleaseTurn = "";
        }
        else
        {
            if (r.OathConfirmed) return null;
            if (!r.Appearance.OathEligible) return "当前好感或交往关系尚未达到誓约条件。";
            if (kind == "dm-oath-confirm") { r.OathConfirmed = true; r.HighestBond = 2; r.SelectedBond = null; r.OathDeferred = false; r.OathPromptHidden = false; }
            else if (kind == "dm-oath-defer") { r.OathDeferred = true; r.OathPromptHidden = false; }
            else if (kind == "dm-oath-close") { r.OathDeferred = true; r.OathPromptHidden = true; }
            else if (kind == "dm-oath-open") { r.OathDeferred = false; r.OathPromptHidden = false; }
            else return "誓约操作无效。";
        }
        r.Revision++;
        // 玩家明确处理的决定独立于旧AI轮次的撤回。
        PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(data), data.Chats, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person,
            [nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.HighestBond), nameof(PrivateRelation.SelectedBond), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.OathReleaseReason), nameof(PrivateRelation.OathReleaseTurn)]);
        return null;
    }
    public static void RequestRelease(PrivateRelation relation, PrivateTurn turn, string reason)
    {
        if (!relation.OathConfirmed || relation.OathReleaseReason.Length > 0 || turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(turn.Reply) || string.IsNullOrWhiteSpace(reason)) return;
        relation.OathReleaseReason = reason.Trim(); relation.OathReleaseTurn = turn.Id; relation.Revision++;
    }
    public static string Context(PrivateRelation relation) => (relation.OathConfirmed
        ? "\n誓约记录：玩家已确认缔结誓约。" + (relation.OathReleaseReason.Length > 0 ? "待玩家回复与处理的解除请求：" + relation.OathReleaseReason : "")
        : "\n誓约记录：当前未缔结誓约，正式确认由玩家在界面操作。")
        + (relation.RingReceived || relation.OathConfirmed ? "\n婚戒记录：" + (relation.RingReceived ? "已收到誓约之戒" : "尚未赠送")
            + "；婚礼记录：" + (relation.WeddingCompleted ? "已完成婚礼。" : "尚未举办婚礼。") : "");
}
