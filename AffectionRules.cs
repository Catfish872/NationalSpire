namespace NationalSpire;

public enum RomanceDifficulty { Natural, Charming, Reserved, Insulated }

/// <summary>好感增长、约会倍率、赠礼减益及商城价格的统一规则。编辑角色直接设置数值。</summary>
public static class AffectionRules
{
    public static RomanceDifficulty Mode(CareerData data, PrivateTurn? turn = null) => Normalize(turn?.AffectionDifficulty ?? data.RomanceDifficulty);
    public static RomanceDifficulty Normalize(RomanceDifficulty mode) => Enum.IsDefined(mode) ? mode : RomanceDifficulty.Natural;
    public static string Name(RomanceDifficulty mode) => mode switch { RomanceDifficulty.Charming => "人见人爱", RomanceDifficulty.Reserved => "慢热磁场", RomanceDifficulty.Insulated => "绝缘体质", _ => "自然相处" };
    public static double GainRate(RomanceDifficulty mode) => mode switch { RomanceDifficulty.Charming => .75, RomanceDifficulty.Insulated => .25, _ => .5 };
    public static int PriceRate(CareerData data) => Mode(data) == RomanceDifficulty.Insulated ? 2 : 1;
    public static bool Strict(RomanceDifficulty mode) => mode is RomanceDifficulty.Reserved or RomanceDifficulty.Insulated;
    public static double DateRate(RomanceDifficulty mode, bool date, double delta) => !date ? 1
        : delta > 0 ? mode == RomanceDifficulty.Insulated ? 1 : 2
        : mode == RomanceDifficulty.Charming ? 1 : 2;
    public static double Dialogue(CareerData data, PrivateTurn turn, double delta, bool group = false)
    {
        var mode = Mode(data, turn);
        double result = delta * (delta > 0 ? GainRate(mode) : !group && Strict(mode) ? 2 : 1);
        if (!group && Strict(mode) && result > 0) result = Math.Min(3, result);
        return result * DateRate(mode, !group && turn.Scene is { Ending: false }, delta);
    }
    public static int Apply(CareerData data, string person, double delta, bool gift = false)
    {
        if (!double.IsFinite(delta) || delta == 0) return 0;
        var relation = PrivateMessages.Relation(data, person);
        bool positive = delta > 0;
        double remainder = gift ? positive ? relation.GiftRemainder : relation.GiftLossRemainder : positive ? relation.GainRemainder : relation.LossRemainder;
        double sum = Math.Abs(delta) + Math.Clamp(remainder, 0, .999999999);
        int integer = (int)Math.Min(200, Math.Floor(sum + 1e-9));
        int before = relation.Favour; relation.Favour = Math.Clamp(before + (positive ? integer : -integer), -100, 100);
        double remaining = positive && relation.Favour == 100 || !positive && relation.Favour == -100 ? 0 : Math.Max(0, sum - Math.Floor(sum + 1e-9));
        if (gift) { if (positive) relation.GiftRemainder = remaining; else relation.GiftLossRemainder = remaining; }
        else { if (positive) relation.GainRemainder = remaining; else relation.LossRemainder = remaining; }
        relation.Revision++; data.Life.Relationships[person] = relation.Favour;
        if (data.AffectionLinkedClearChance && relation.Favour != before) CareerTraining.InvalidateForecast(data);
        return relation.Favour - before;
    }
    public static double GiftFactors(RomanceDifficulty mode, params double[] factors)
    {
        if (!Strict(mode)) return factors.Aggregate(1d, (value, f) => value * f);
        double product = 1, penalty = 0, bonuses = 1;
        foreach (double f in factors)
        {
            double adjusted = f < 1 ? 2 * f - 1 : f;
            product *= Math.Max(0, adjusted);
            if (adjusted < 0) penalty += adjusted;
            if (f > 1) bonuses *= f;
        }
        // 多个负因子累计损失，避免相乘后出现负负得正。
        return mode == RomanceDifficulty.Insulated && penalty < 0 ? Math.Max(-1, penalty) * bonuses : product;
    }
    public static double GiftValue(RomanceDifficulty mode, GiftItem item, int count, int favour, double mood)
    {
        double baseGain = ConsumerGifts.PriceGain(item.UnitPrice);
        double preference = baseGain == 0 ? 1 : ConsumerGifts.PriceGain(item.UnitPrice * item.Preference) / baseGain;
        double at(long n) => baseGain * GiftFactors(mode, preference, ConsumerGifts.FavourFactor(favour), mood < 0 ? .5 : mood > 0 ? 1.5 : 1, ConsumerGifts.RepeatFactor(n));
        int varied = (int)Math.Min(count, Math.Max(0, 9 - item.ReceivedBefore)); double value = 0;
        for (int i = 0; i < varied; i++) value += at(item.ReceivedBefore + i);
        return value + (count - varied) * at(9);
    }
    public static string Guidance(CareerData data, PrivateTurn? turn)
    {
        var mode = Mode(data, turn);
        return "好感结算：Favour仍填写按人物真实反应评估的基础目标值；程序统一处理攻略难度与约会倍率。请只输出一次好感目标。"
            + (turn?.Scene is { Ending: false } ? "约会中的互动更容易影响关系：主动倾听、记住偏好、体贴照顾、真诚分享、接住玩笑等细小积极行为也可带来轻微好感增长；敷衍、冷落、冒犯或越界也可带来轻微下降。逐轮结合对方性格与本次行为判断，明确的情绪触动及时体现为Favour变化；平淡交流可保持原值。只评估基础变化，倍率由程序应用。" : "")
            + (Strict(mode) ? "当前角色对关系中的疏忽更敏感：玩家忽视其已经表达的意愿、敷衍重要话题、失约、越界玩笑或轻视感受时，可依据具体行为表达轻微失望、难过或疏远，并给出较低的基础好感目标；轻度伤害也可触发。对方自身经历或环境造成的悲伤应归于其真实原因。" : "");
    }
    public static string Description(RomanceDifficulty mode) => mode switch
    {
        RomanceDifficulty.Charming => "比自然相处更容易拉近关系，约会中的失误也更容易获得谅解。",
        RomanceDifficulty.Reserved => "比自然相处更注重耐心与分寸。聊天升温更慢，送礼更讲究心意，疏忽也更容易伤害关系。",
        RomanceDifficulty.Insulated => "比自然相处更难打动对方。关系升温缓慢，失礼的赠礼可能适得其反，消费也更昂贵。",
        _ => "默认的相处节奏：通过聊天、赠礼与约会逐渐建立关系，约会中的情绪变化更鲜明。"
    };
}
