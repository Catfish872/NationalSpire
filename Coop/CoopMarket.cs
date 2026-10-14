namespace NationalSpire.Coop;

public static partial class CoopRules
{
    private static string? Trade(CoopWorld transaction, CoopMember member, MarketOrder order)
    {
        // Apply 已经复制了整个操作数据。交易只读取行情、日期与本人资金，复用该副本中的账户。
        // 这里的引用均属于尚未提交的副本，不连接原始存档，也不传给界面或异步任务。
        var data = new CareerData { Day = transaction.World.Day, Market = transaction.World.Market, Credits = member.Credits, Life = member.Life };
        var error = CareerMarket.Trade(data, order);
        if (error == null) member.Credits = data.Credits;
        return error;
    }
    private static void BindMarket(CoopWorld world)
    {
        world.World.MarketSponsors = id => world.Members
            .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))
            .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"));
        world.World.MarketAccounts = (data, day) =>
        {
            foreach (var member in world.Members) CareerMarket.Account(data.Market, member.Life.Trading, day);
        };
    }
}
