namespace NationalSpire;

public readonly record struct RelationshipAppearance(int Tier, bool Lover, bool OathEligible);

/// <summary>好感徽章按数值分档，正式关系由已接受的附件记录决定。</summary>
public static class RelationshipPresentation
{
    public static int Tier(int favour) => favour switch { <= -30 => 0, < 0 => 1, < 25 => 2, < 50 => 3, < 75 => 4, _ => 5 };
    public static (int Low, int High) Range(int tier) => tier switch { 0 => (-100,-30), 1 => (-29,-1), 2 => (0,24), 3 => (25,49), 4 => (50,74), _ => (75,100) };
    public static float Progress(int favour)
    {
        var (low, high) = Range(Tier(favour));
        return Math.Clamp((favour - low) / (float)(high - low), 0, 1);
    }
    public static bool OathAppearance(PrivateRelation? relation) => relation is { OathConfirmed: true, WeddingCompleted: true };
    public static string Bond(PrivateRelation relation) => OathAppearance(relation) ? "oath" : relation.Appearance.Lover ? "lover" : "none";
    public static string IconBond(PrivateRelation relation) => Bond(relation) is var bond && bond != "none" ? bond : relation.Favour < 5 ? "unfamiliar" : "none";
    public static int Unlocked(PrivateRelation relation) => Math.Max(relation.HighestBond, relation.OathConfirmed ? 2 : relation.SelectedBond >= 1 ? 1 : 0);
    public static void CompleteWedding(CareerData data, string person)
    {
        var relation = PrivateMessages.Relation(data, person);
        relation.WeddingCompleted = true;
        relation.RefreshAppearance(); relation.Revision++;
        PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(data), data.Chats, GroupChats.Human(data), person,
            [nameof(PrivateRelation.WeddingCompleted)]);
    }
    public static string Context(PrivateRelation relation) => "\n正式关系：" + (relation.OathConfirmed ? "已缔结誓约" : relation.SelectedBond >= 1 ? "恋人" : "尚未确定恋人关系")
        + "；婚礼记录：" + (relation.WeddingCompleted ? "已举办婚礼。" : "尚未举办婚礼。");
}
