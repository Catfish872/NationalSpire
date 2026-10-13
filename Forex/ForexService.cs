using ForexSpire;

namespace NationalSpire;

/// <summary>原生宿主适配；单人直接保存，联机日期由房主候选世界回调处理。</summary>
public static class ForexService
{
    public static bool LegacyPatchLoaded => AppDomain.CurrentDomain.GetAssemblies().Any(a => a.GetName().Name == "ForexSpire");
    public static bool IsSinglePlayer(CareerData data) =>
        data.ExternalSave == null && data.CooperativeMembers <= 1 && string.IsNullOrEmpty(data.LocalHumanId);

    public static List<ForexFixture> Snapshot(CareerData data)
    {
        var facts = new List<ForexFixture>();
        foreach (var competition in data.Esports.Competitions.Where(c => ForexMath.IsInternational(c.Kind)))
        foreach (var fixture in competition.Fixtures.Where(f => f.Finished && !f.Draw && !f.Walkover &&
            f.HomeId.Length > 0 && f.AwayId.Length > 0 && (f.WinnerId == f.HomeId || f.WinnerId == f.AwayId)))
        {
            string key = competition.Id + ":" + (fixture.Id.Length > 0 ? fixture.Id :
                $"{fixture.Round}:{fixture.Day}:{fixture.HomeId}:{fixture.AwayId}");
            string Country(string id) => competition.EntrantCountries.GetValueOrDefault(id) ??
                (id == "player" ? data.Esports.Country : CareerEngine.Person(data, id)?.Country ?? "");
            facts.Add(new(key, competition.Name, competition.Kind, fixture.Round,
                Country(fixture.HomeId), Country(fixture.AwayId), fixture.WinnerId == fixture.HomeId));
        }
        return facts;
    }

    public static ForexState Ensure(CareerData data)
    {
        if (!IsSinglePlayer(data)) throw new InvalidOperationException("联机视图须通过房主命令处理外汇。");
        data.Forex ??= new();
        if (data.Forex.ForexVersion > 3) throw new NotSupportedException("此外汇存档来自更新版本。");
        ForexMarket.Initialize(data.Forex, data.Day, data.Forex.Initialized ? [] : Snapshot(data), data.WorldId);
        return data.Forex;
    }

    // 在日推进前初始化，确保第一次推进不会被误当作初始化。
    public static void BeginDay(CareerData data)
    {
        if (IsSinglePlayer(data) && !LegacyPatchLoaded) Ensure(data);
    }

    public static void AdvanceDay(CareerData data, List<ForexFixture> previousDay)
    {
        if (!LegacyPatchLoaded && data.ForexDailySink is { } sink) { sink(data, previousDay); return; }
        if (!IsSinglePlayer(data) || LegacyPatchLoaded) return;
        try
        {
            var next = Ensure(data).Copy();
            if (ForexMarket.Advance(next, DayFacts(data, previousDay)))
            {
                data.Forex = next;
                PublishNews(data, next);
            }
        }
        catch (Exception error)
        {
            // 保留未推进的水位，不伪造成功；交易入口会拒绝陈旧报价。
            Diagnostics.Error("forex.daily", error);
        }
    }

    public static ForexDay DayFacts(CareerData data, List<ForexFixture> previousDay)
    {
        var drift = new Dictionary<string, double>();
        double Fortune(string country, bool season) => data.Esports.CircuitAwards
            .Where(a => a.Country == country && (!season || a.Season == data.Season)).Sum(a => (double)a.Fortune);
        foreach (var pair in ForexRules.Pairs)
            drift[pair.Id] = ForexMath.Drift(Fortune(pair.Country, false), Fortune(ForexRules.BaseCountry, false),
                Fortune(pair.Country, true), Fortune(ForexRules.BaseCountry, true),
                ForexRules.DriftA, ForexRules.DriftB, ForexRules.DriftCap);
        return new() { WorldId = data.WorldId, Day = data.Day, Season = data.Season,
            Fixtures = previousDay.Concat(Snapshot(data)).GroupBy(f => f.Key).Select(g => g.Last()).ToList(), Drift = drift };
    }

    public static void PublishNews(CareerData data, ForexState state)
    {
        var material = ForexNews.Build(data.WorldId, state);
        if (material == null) return;
        if (!CommunityThreads.All(data).Any(p => p.EventKey == material.Key))
            CareerEngine.Publish(data, material.Key, material.Title, material.Body, "外汇市场", true);
        if (CommunityThreads.All(data).Any(p => p.EventKey == material.Key)) state.LastPublishedDay = state.LastDay;
    }

    public static string? TradeError(CareerData data)
    {
        if (!IsSinglePlayer(data)) return "联机操作须通过房主命令提交。";
        if (LegacyPatchLoaded) return "请禁用旧 ForexSpire 补丁并重启游戏，避免双重结算。";
        if (!CareerStore.IsCurrent(data)) return "生涯已切换，请重新打开界面。";
        if (MatchFailure.Locked(data) is { } failure) return failure;
        if (data.PendingMatchId != null) return "请先完成当前比赛，再进行交易。";
        if (Ensure(data).LastDay != data.Day) return "外汇结算日期异常，交易暂不可用。请查看诊断日志。";
        return null;
    }

    public static string? Trade(CareerData data, string action, double amount, string pair = "", int direction = 1, int leverage = 1, int positionId = 0)
    {
        if (TradeError(data) is { } blocked) return blocked;
        var original = Ensure(data);
        var transaction = ForexWallet.Apply(original, CareerMoney.Balance(data), data.Day,
            new(action, amount, pair, direction, leverage, positionId));
        if (transaction.Error != null) return transaction.Error;
        var next = transaction.State!;
        decimal change = transaction.WalletChange;
        int credits = data.Credits;
        decimal fraction = data.Life.CreditFraction;
        var ledger = data.Life.Ledger.ToList();
        try
        {
            data.Forex = next;
            if (change != 0)
            {
                CareerMoney.Add(data, change);
                CareerMoney.Record(data, action == "deposit" ? "外汇账户入金" : "外汇账户出金", change);
            }
            CareerStore.SaveCareerOnly(data);
            return null;
        }
        catch (Exception error)
        {
            data.Forex = original; data.Credits = credits; data.Life.CreditFraction = fraction; data.Life.Ledger = ledger;
            Diagnostics.Error("forex.trade", error);
            return "保存交易失败，未保留本次变更：" + error.Message;
        }
    }

    public static string? ImportLegacy(CareerData data)
    {
        if (TradeError(data) is { } blocked) return blocked;
        string path = Path.Combine(Path.GetDirectoryName(CareerStore.DefaultPath)!, "national_spire_forex.json");
        try
        {
            if (!File.Exists(path)) return "本档案目录没有旧外汇存档。";
            var old = Ensure(data);
            var result = ForexLegacy.Read(File.ReadAllText(path), data.WorldId, data.Day, old);
            if (result.Error != null) return result.Error;
            var imported = result.State!;
            foreach (var competition in data.Esports.Competitions.Where(c => ForexMath.IsInternational(c.Kind)))
            foreach (var fixture in competition.Fixtures.Where(f => f.Finished &&
                f.Round <= imported.SignalledRounds.GetValueOrDefault(competition.Id)))
            {
                string key = competition.Id + ":" + (fixture.Id.Length > 0 ? fixture.Id :
                    $"{fixture.Round}:{fixture.Day}:{fixture.HomeId}:{fixture.AwayId}");
                imported.SettledFixtures.Add(key);
            }
            ForexMarket.Initialize(imported, data.Day, [], data.WorldId);
            imported.ForexVersion = 3; imported.LegacyImported = true;
            imported.Record(data.Day, "import", "旧外汇账户已导入，原旁路文件保留");
            data.Forex = imported;
            try { CareerStore.SaveCareerOnly(data); }
            catch { data.Forex = old; throw; }
            return null;
        }
        catch (Exception error) { Diagnostics.Error("forex.import", error); return "无法导入旧账户：" + error.Message; }
    }

    public static string Money(double amount) => double.IsFinite(amount) && Math.Abs(amount) < (double)decimal.MaxValue
        ? CareerMoney.Format((decimal)amount) : "金额无效";
    public static string Price(string pair, double amount) => amount.ToString("F" + (ForexRules.Pair(pair)?.Digits ?? 5), System.Globalization.CultureInfo.InvariantCulture);
}

