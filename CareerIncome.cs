namespace NationalSpire;

/// <summary>职业收入的统一计算及旧合同转换；金额使用生涯内部货币单位。</summary>
public static class CareerIncome
{
    public const int LeaguePrize = 1500;
    public static int Attention(int fans, int basis)
        => (int)Math.Round(basis * (Math.Pow(1 + Math.Max(0, fans) / 100000.0, .4) - 1));
    public static int PersonalAttention(int fans) => Attention(fans, 100000);
    public static int ClubAttention(int fans) => Attention(fans, 27000);
    public static int WithDevelopment(CareerData d, int amount, string country)
        => (int)Math.Round(amount * (1 + NationalDevelopment.IncomeBonus(d, country)));

    public static void Upgrade(ClubOffer offer)
    {
        if (offer.IncomeVersion >= 1) return;
        offer.SeasonPay *= 2;
        offer.WinBonus *= 3;
        offer.GoalReward *= 3;
        offer.IncomeVersion = 1;
    }

    public static void Upgrade(CareerData data)
    {
        if (data.Esports.PlayerContract is { } contract) Upgrade(contract);
        foreach (var offer in data.Esports.Offers) Upgrade(offer);
        if (data.Esports.IncomeVersion < 1)
        {
            foreach (var match in data.Matches.Where(m => m.Kind == "league" && m.Status == "待赛" && m.Prize == 260)) match.Prize = LeaguePrize;
            data.Esports.IncomeVersion = 1;
        }
    }
}
