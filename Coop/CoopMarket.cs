namespace NationalSpire.Coop;

public static partial class CoopRules
{
    public static MarketInspectionResult InspectMarket(CoopWorld world, ulong memberId, MarketInspection request)
    {
        var member = world.Members.Single(m => m.SteamId == memberId);
        var data = new CareerData { Market = world.World.Market, Life = member.Life,
            TradingAccounts = () => world.Members.Select(m => m.Life.Trading).ToArray() };
        return MarketClearing.Inspect(data, request);
    }
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
            MarketAccounts = transaction.World.MarketAccounts, TradingAccounts = transaction.World.TradingAccounts };
        var error = CareerMarket.Trade(data, order);
        if (error == null) member.Credits = data.Credits;
        return error;
    }
    private static void BindMarket(CoopWorld world)
    {
        world.World.TradingAccounts = () => world.Members.Select(m => m.Life.Trading).ToArray();
        world.World.MarketSponsors = id => world.Members
            .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))
            .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"));
        world.World.MarketAccounts = (data, day) =>
        {
            CareerMarket.Accounts(data.Market, world.Members.Select(member => member.Life.Trading).ToArray(), day);
        };
    }
}

public sealed partial class CoopCoordinator
{
    private sealed record MarketQuery(string Id, string World, string Epoch, MarketInspection Request);
    private sealed record MarketAnswer(string Id, string World, string Epoch, MarketInspectionResult? Result, string Error = "");
    private readonly Dictionary<string, TaskCompletionSource<MarketAnswer>> marketQueries = [];
    public async Task<MarketInspectionResult> InspectMarket(MarketInspection request)
    {
        var world = World ?? throw new InvalidOperationException("正在同步市场，请稍后重试。");
        if (Host) return CoopRules.InspectMarket(world, Self, request);
        string id = Guid.NewGuid().ToString("N"); var completion = new TaskCompletionSource<MarketAnswer>(); marketQueries[id] = completion;
        try
        {
            Send(_transport.Owner, "market-query", new MarketQuery(id, world.Id, world.Epoch, request));
            var answer = await completion.Task.WaitAsync(TimeSpan.FromSeconds(10));
            if (World?.Id != answer.World || World.Epoch != answer.Epoch) throw new InvalidOperationException("房间已切换，请重新查看市场。");
            return answer.Result ?? throw new InvalidOperationException(answer.Error);
        }
        finally { marketQueries.Remove(id); }
    }
    private void ReceiveMarket(ulong sender, CoopWire wire)
    {
        if (wire.Kind == "market-query" && Host)
        {
            var query = Read<MarketQuery>(wire);
            if (World?.Id != query.World || World.Epoch != query.Epoch) return;
            MarketAnswer answer;
            try { answer = new(query.Id, World.Id, World.Epoch, CoopRules.InspectMarket(World, sender, query.Request)); }
            catch (Exception error) { Diagnostics.Error("market.preview", error); answer = new(query.Id, World.Id, World.Epoch, null, "市场预览暂时失败，请重新下单。"); }
            Send(sender, "market-answer", answer);
        }
        else if (wire.Kind == "market-answer" && !Host)
        {
            var answer = Read<MarketAnswer>(wire);
            if (marketQueries.TryGetValue(answer.Id, out var completion)) completion.TrySetResult(answer);
        }
    }
}
