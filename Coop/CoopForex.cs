using ForexSpire;
using System.Text.Json;

namespace NationalSpire.Coop;

/// <summary>在现有房主候选世界内执行，保存/收据/广播仍由 CoopCoordinator 处理。</summary>
public static class CoopForex
{
    public static void Attach(CoopWorld world)
    {
        if (ForexService.LegacyPatchLoaded) return;
        var data = world.World;
        data.Forex ??= new();
        ForexMarket.Initialize(data.Forex, data.Day, data.Forex.Initialized ? [] : ForexService.Snapshot(data), data.WorldId);
        foreach (var member in world.Members)
        {
            member.Forex ??= new();
            member.Forex.Account ??= new();
            member.Forex.Records ??= [];
            if (member.Forex.LastDay == 0) member.Forex.LastDay = data.Day;
        }
        data.ForexDailySink = (_, previous) =>
        {
            var accounts = world.Members.ToDictionary(m => m.PersonId, m => m.Forex);
            var result = ForexCoop.Advance(data.Forex, accounts, ForexService.DayFacts(data, previous));
            if (!result.Advanced) return;
            data.Forex = result.Market;
            foreach (var member in world.Members) member.Forex = result.Members[member.PersonId];
            ForexService.PublishNews(data, data.Forex);
        };
    }

    public static ForexState View(CoopWorld world, CoopMember member)
    {
        var market = world.World.Forex?.Copy() ?? new();
        ForexMarket.Initialize(market, world.World.Day, [], world.Id);
        var portfolio = member.Forex ?? new ForexPortfolio { LastDay = world.World.Day };
        return ForexCoop.View(market, portfolio);
    }

    public static string? Command(CoopWorld world, CoopMember member, CoopCommand command)
    {
        if (ForexService.LegacyPatchLoaded) return "请禁用旧 ForexSpire 补丁并重启游戏。";
        if (world.Proposal != null) return "请先完成或取消当前团队提议。";
        var order = JsonSerializer.Deserialize<ForexOrder>(command.Text);
        if (order == null || command.Kind != "forex-" + order.Action) return "外汇命令不一致。";
        // 可执行动作以纯交易服务白名单为准，不接受导入或客户端指定成员。
        if (order.Action is not ("deposit" or "withdraw" or "open" or "close" or "borrow" or "repay"))
            return "外汇操作无效。";
        var result = ForexCoop.Trade(world.World.Forex!, member.Forex,
            member.Credits + member.Life.CreditFraction, world.World.Day, order);
        if (result.Error != null) return result.Error;
        member.Forex = result.Portfolio!;
        member.Credits = checked((int)decimal.Floor(result.Wallet));
        member.Life.CreditFraction = result.Wallet - member.Credits;
        if (result.Change != 0)
        {
            member.Life.Ledger.Add(new() { Day = world.World.Day,
                Title = order.Action == "deposit" ? "外汇账户入金" : "外汇账户出金",
                Amount = result.Change, Balance = result.Wallet });
            if (member.Life.Ledger.Count > 96) member.Life.Ledger.RemoveAt(0);
        }
        return null;
    }
}

