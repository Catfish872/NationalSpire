namespace NationalSpire.Coop;

public static partial class CoopRules
{
    public static void InitializeMarket(CoopWorld world)
    {
        BindMarket(world);
        CareerMarket.Initialize(world.World);
    }
    private static string? Trade(CoopWorld transaction, CoopMember member, MarketOrder order)
    {
        // Apply 已复制完整操作数据。交易修改共同报价与本人资金，并检查所有成员的强平条件。
        // 这里的引用均属于尚未提交的副本，不连接原始存档，也不传给界面或异步任务。
        var data = new CareerData { Day = transaction.World.Day, Market = transaction.World.Market, Credits = member.Credits, Life = member.Life,
            MarketAccounts = transaction.World.MarketAccounts };
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
            CareerMarket.Accounts(data.Market, world.Members.Select(member => member.Life.Trading).ToArray(), day);
        };
    }
}
