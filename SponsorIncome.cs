namespace NationalSpire;

/// <summary>赞助金额统一入口。基础金额只确定一次，付款与显示按当前关注计算。</summary>
public static class SponsorIncome
{
    public static int PersonalTier(CareerData d) => 1 + Math.Min(7, d.Esports.CircuitAwards.Count(a =>
        (a.PersonId == "player" || a.PersonId == GroupChats.Human(d)) && a.Place == "冠军" && a.Kind != "league"));
    public static (int Retainer, int Win) PersonalBase(string plan, int tier) => plan switch
    {
        "稳定支持" => (320 * tier, 20 * tier),
        "成绩奖励" => (140 * tier, 65 * tier),
        "品牌推广" => (200 * tier, 25 * tier),
        _ => (0, 0)
    };
    private static (int Retainer, int Win) Basis(CareerData d, SponsorContract contract)
    {
        if (contract.BaseRetainer is { } retainer && contract.BaseWinBonus is { } win) return (retainer, win);
        if (contract.TargetId == "player")
        {
            if (contract.Plan is "稳定支持" or "成绩奖励" or "品牌推广") return PersonalBase(contract.Plan, PersonalTier(d));
            // 无方案的早期合同没有可还原报价，保留当前金额为转换起点。
            double multiplier = CareerAudience.QuoteMultiplier(d.Fans);
            return ((int)Math.Round(contract.Retainer / multiplier), (int)Math.Round(contract.WinBonus / multiplier));
        }
        int support = CareerCommerce.IdentityIndex(d, contract.TargetId) switch { 0 => 3200, 1 => 2000, 2 => 4200, _ => 1600 };
        return (support * (EsportsWorld.Club(d, contract.TargetId)?.Titles > 0 ? 2 : 1), 0);
    }
    public static void Initialize(CareerData d, SponsorContract contract)
    {
        var basis = Basis(d, contract);
        contract.BaseRetainer ??= basis.Retainer; contract.BaseWinBonus ??= basis.Win;
        if (contract.NextOffer is { } next) Initialize(d, next);
    }
    public static void Upgrade(CareerData d)
    {
        foreach (var contract in d.Esports.Sponsors.Where(c => c.EndedDay == 0).Concat(d.Esports.SponsorOffers)) Initialize(d, contract);
    }
    public static int Retainer(CareerData d, SponsorContract contract) => CareerIncome.WithDevelopment(d,
        (int)Math.Round(Basis(d, contract).Retainer * Multiplier(d, contract)) + (contract.TargetId == "player" ? CareerIncome.PersonalAttention(d.Fans) : 0),
        contract.TargetId == "player" ? d.Esports.Country : EsportsWorld.Club(d, contract.TargetId)?.Country ?? "");
    public static int WinBonus(CareerData d, SponsorContract contract) => (int)Math.Round(Basis(d, contract).Win * Multiplier(d, contract));
    private static double Multiplier(CareerData d, SponsorContract contract) => contract.TargetId == "player"
        ? CareerAudience.QuoteMultiplier(d.Fans) : CareerAudience.ClubMultiplier(ClubAudience.Total(d, contract.TargetId));
}
