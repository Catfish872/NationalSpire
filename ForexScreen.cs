using Godot;
using ForexSpire;
using System.Globalization;

namespace NationalSpire;

/// <summary>顶部金色入口与不需要滚动的交易工作台。</summary>
public partial class CareerScreen
{
    private string _forexPair = "CNY/JPY", _forexCashInput = "1000", _forexMarginInput = "1000", _forexLoanInput = "5000";
    private int _forexLeverageIndex = 4, _forexVisibleBars = 60, _forexPositionPage, _forexRecordPage;
    private readonly Color _forexUp = new("8fddb1"), _forexDown = new("f19aa8");

    private static double ForexInput(string text) =>
        double.TryParse(text.Trim().TrimStart('$'), NumberStyles.Number, CultureInfo.InvariantCulture, out double dollars) &&
        double.IsFinite(dollars) && dollars > 0 ? dollars / 10 : 0;
    private static string ForexAmountText(double units) =>
        (Math.Floor(Math.Max(0, units) * 1000) / 100).ToString("0.##", CultureInfo.InvariantCulture);

    private static void StyleForexEntry(Godot.Button button, bool active)
    {
        button.AddThemeColorOverride("font_color", CareerVisuals.Gold);
        button.AddThemeColorOverride("font_hover_color", new Color("fff0be"));
        button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(active ? "544122" : "302b20", "b99556", 6, 10));
        button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("574329", "efd59c", 6, 10));
        button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("6a5030", "efd59c", 6, 10));
    }

    private Label FxLine(string value, int size = 14, Color? color = null)
    {
        var label = Text(value, size, color ?? _muted);
        label.AddThemeConstantOverride("line_spacing", 0);
        label.AutowrapMode = TextServer.AutowrapMode.Off;
        label.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
        label.TooltipText = value;
        return label;
    }
    private Godot.Button FxButton(string value, Action action, float width = 0, float height = 30)
    {
        var button = Button(value, action, width); button.CustomMinimumSize = new(width, height);
        button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        button.AddThemeFontSizeOverride("font_size", 14);
        foreach (string name in new[] { "normal", "hover", "pressed", "disabled" })
        {
            var style = (StyleBox)button.GetThemeStylebox(name).Duplicate();
            style.ContentMarginTop = style.ContentMarginBottom = 4;
            style.ContentMarginLeft = style.ContentMarginRight = 7;
            button.AddThemeStyleboxOverride(name, style);
        }
        return button;
    }
    private VBoxContainer FxPanel(Node parent)
    {
        var panel = Card(); panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332", "304554", 7, 12));
        parent.AddChild(panel); var box = Inner(panel); box.AddThemeConstantOverride("separation", 5); return box;
    }
    private LineEdit FxInput(string value, Action<string> changed)
    {
        var input = new LineEdit { Text = value, PlaceholderText = "美元", CustomMinimumSize = new(0, 32), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        input.AddThemeFontSizeOverride("font_size", 15); input.TextChanged += text => changed(text); return input;
    }

    private void Forex(CareerData d)
    {
        if (_multiplayer == null && !ForexService.IsSinglePlayer(d)) { _content.AddChild(FxLine("请从对应生涯进入外汇交易。")); return; }
        if (ForexService.LegacyPatchLoaded) { _content.AddChild(FxLine("请禁用旧 ForexSpire 补丁并重启，避免双重结算。", 18, _gold)); return; }
        var state = _multiplayer == null ? ForexService.Ensure(d) : d.Forex!;
        var account = state.Account;
        string? blocked = _multiplayer == null ? ForexService.TradeError(d) :
            d.Failure != null ? MatchFailure.Locked(d) :
            _multiplayer.RunStatus.Length > 0 ? "当前比赛尚未结束，请完成后再交易。" :
            _multiplayer.ProposalId.Length > 0 ? "请先完成或取消团队提议。" :
            _multiplayer.Team.Count < 2 ? "至少需要两位在线队员。" :
            state.LastDay != d.Day ? "外汇结算日期异常，暂不能交易。" : null;

        var summary = new HBoxContainer(); summary.AddThemeConstantOverride("separation", 8); _content.AddChild(summary);
        foreach (var item in new[] { ("账户权益", account.Equity(p => state.Prices[p])), ("可用余额", account.Cash), ("已用保证金", account.UsedMargin), ("待还借款", account.Debt) })
        {
            var box = FxPanel(summary); box.AddChild(FxLine(item.Item1, 13));
            box.AddChild(FxLine(ForexService.Money(item.Item2), 21, _ink));
        }
        if (blocked != null) _content.AddChild(FxLine(blocked, 13, _forexDown));

        var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 10); _content.AddChild(columns);
        var market = FxPanel(columns);
        var marketPanel = (Control)market.GetParent(); marketPanel.CustomMinimumSize = new(204, 0);
        marketPanel.SizeFlagsHorizontal = SizeFlags.Fill; marketPanel.SizeFlagsVertical = SizeFlags.ShrinkBegin;
        market.AddChild(FxLine("市场  /  CNY", 18, _gold));
        foreach (var pair in ForexRules.Pairs)
        {
            double price = state.Prices[pair.Id]; var history = state.Candles[pair.Id];
            double previous = history.Count > 1 ? history[^2] : state.Bars[pair.Id][^1].Open;
            double change = (price / previous - 1) * 100;
            var select = FxButton(pair.Id + "  " + pair.Name + "\n" + ForexService.Price(pair.Id, price) + "   " +
                change.ToString("+0.00;-0.00;0.00", CultureInfo.InvariantCulture) + "%", () => { _forexPair = pair.Id; Render(); }, height: 52);
            select.AddThemeColorOverride("font_color", change >= 0 ? _forexUp : _forexDown);
            if (_forexPair == pair.Id) select.AddThemeStyleboxOverride("normal", CareerVisuals.Box("28434c", "658c91", 5, 5));
            market.AddChild(select);
        }
        market.AddChild(FxLine("上涨做多获利 · 下跌做空获利", 11));
        if (_multiplayer == null)
        {
            var import = FxButton(state.LegacyImported ? "旧账户已导入" : "导入旧账户", () =>
                ShowCareerDialog("导入旧外汇账户", "仅导入同一世界、同一天的旧资产。已有原生交易时不覆盖，旧文件保留。", () =>
                { var error = ForexService.ImportLegacy(d); Render(); Notice(error ?? "旧账户已导入。", error != null); return true; }));
            import.Disabled = blocked != null || state.LegacyImported; market.AddChild(import);
        }

        var middle = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; middle.AddThemeConstantOverride("separation", 7); columns.AddChild(middle);
        var chartBox = FxPanel(middle);
        var chartTitle = new HBoxContainer(); chartTitle.AddThemeConstantOverride("separation", 8); chartBox.AddChild(chartTitle);
        chartTitle.AddChild(FxLine(_forexPair + "   " + ForexService.Price(_forexPair, state.Prices[_forexPair]), 21, _gold));
        var day = FxButton("推进一天 →", () => ForexNextDay(d), 126, 32); StyleForexEntry(day, false); chartTitle.AddChild(day);
        day.TooltipText = "推进一个生涯日，更新行情并结算持仓、借款；比赛日先完成比赛。";
        day.Disabled = d.Failure != null || d.PendingMatchId != null ||
            CareerEngine.NextMatch(d) is { } next && next.Day <= d.Day || _multiplayer is { Host: false };
        var chartOptions = new HBoxContainer(); chartOptions.AddThemeConstantOverride("separation", 5); chartBox.AddChild(chartOptions);
        chartOptions.AddChild(FxLine("日K · 第 " + state.LastDay + " 天收盘", 12));
        foreach (int count in new[] { 30, 60, 90 })
        {
            var range = FxButton(count + "根", () => { _forexVisibleBars = count; Render(); }, 48, 26);
            range.SizeFlagsHorizontal = SizeFlags.ShrinkBegin;
            if (count == _forexVisibleBars) range.AddThemeColorOverride("font_color", _gold);
            chartOptions.AddChild(range);
        }
        chartBox.AddChild(new ForexChart { Name = "ForexPriceChart", CustomMinimumSize = new(320, 220),
            SizeFlagsHorizontal = SizeFlags.ExpandFill, Bars = state.Bars[_forexPair].ToArray(),
            VisibleBars = _forexVisibleBars, Digits = ForexRules.Pair(_forexPair)!.Digits, MouseFilter = MouseFilterEnum.Ignore });
        var historyHint = FxLine("前置行情为模拟历史 · 影线为模拟区间 · 按日收盘结算", 11);
        historyHint.TooltipText = "补全的历史和影线只用于图表；最新收盘与当前报价一致，不用于日内强平。"; chartBox.AddChild(historyHint);
        ForexTable(middle, d, state, blocked);

        var right = new VBoxContainer { CustomMinimumSize = new(328, 0), SizeFlagsHorizontal = SizeFlags.Fill, SizeFlagsVertical = SizeFlags.ShrinkBegin };
        right.AddThemeConstantOverride("separation", 7); columns.AddChild(right);

        // 资金存取：直接命名全部存入/取出，不再让用户切换百分比基准。
        var walletBox = FxPanel(right);
        walletBox.AddChild(FxLine("资金存取  ·  生涯 " + CareerMoney.Format(CareerMoney.Balance(d)), 16, _gold));
        var walletRow = new HBoxContainer(); walletRow.AddChild(FxLine("金额 $", 13));
        var cash = FxInput(_forexCashInput, text => _forexCashInput = text); walletRow.AddChild(cash); walletBox.AddChild(walletRow);
        var transfer = new HBoxContainer(); transfer.AddThemeConstantOverride("separation", 5); walletBox.AddChild(transfer);
        var deposit = FxButton("存入账户", () => ForexAction(d, "deposit", ForexInput(cash.Text)), height: 32);
        var withdraw = FxButton("取回生涯", () => ForexAction(d, "withdraw", ForexInput(cash.Text)), height: 32);
        deposit.Disabled = withdraw.Disabled = blocked != null; transfer.AddChild(deposit); transfer.AddChild(withdraw);
        var fullTransfer = new HBoxContainer(); fullTransfer.AddThemeConstantOverride("separation", 5); walletBox.AddChild(fullTransfer);
        var allIn = FxButton("全部存入", () => ForexAction(d, "deposit", ForexInput(ForexAmountText((double)CareerMoney.Balance(d)))));
        var allOut = FxButton("全部取出", () => ForexAction(d, "withdraw", ForexInput(ForexAmountText(ForexTrading.Withdrawable(state)))));
        allIn.Disabled = blocked != null || CareerMoney.Balance(d) <= 0;
        allOut.Disabled = blocked != null || ForexTrading.Withdrawable(state) <= 0;
        allIn.TooltipText = "将生涯钱包全部可用资金存入外汇账户。";
        allOut.TooltipText = "将可取现金取回生涯钱包，保留持仓保证金与待还借款。";
        fullTransfer.AddChild(allIn); fullTransfer.AddChild(allOut);
        walletBox.AddChild(FxLine("最多可取 " + ForexService.Money(ForexTrading.Withdrawable(state)), 12));

        var order = FxPanel(right); order.AddChild(FxLine("下单  /  " + _forexPair, 18, _gold));
        var marginRow = new HBoxContainer(); marginRow.AddChild(FxLine("保证金 $", 13));
        var margin = FxInput(_forexMarginInput, text => _forexMarginInput = text); marginRow.AddChild(margin); order.AddChild(marginRow);
        var percentages = new HBoxContainer(); percentages.AddThemeConstantOverride("separation", 4); order.AddChild(percentages);
        foreach (int percent in new[] { 10, 25, 50, 100 })
            percentages.AddChild(FxButton(percent + "%", () => margin.Text = ForexAmountText(Math.Min(ForexRules.MaxMargin,
                account.Cash * percent / 100.0 / (1 + ForexMath.OpenFee(1, ForexRules.Leverages[_forexLeverageIndex])))), height: 26));
        percentages.TooltipText = "使用外汇账户可用余额的相应比例，已预留开仓手续费。";
        var leverageRow = new HBoxContainer(); leverageRow.AddChild(FxLine("杠杆", 13)); order.AddChild(leverageRow);
        var leverage = new OptionButton { CustomMinimumSize = new(0, 30), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        leverage.AddThemeFontSizeOverride("font_size", 14);
        foreach (int value in ForexRules.Leverages) leverage.AddItem(value + "×");
        leverage.Select(_forexLeverageIndex); leverageRow.AddChild(leverage);
        var fee = FxLine("", 12); var risk = FxLine("", 12); order.AddChild(fee); order.AddChild(risk);
        void UpdateEstimate()
        {
            int lev = ForexRules.Leverages[_forexLeverageIndex]; double units = ForexInput(margin.Text), cost = ForexMath.OpenFee(units, lev);
            fee.Text = "手续费 " + ForexService.Money(cost) + " · 合计 " + ForexService.Money(units + cost);
            fee.TooltipText = "名义仓位 " + ForexService.Money(units * lev) + "；保证金与手续费只扣一次。";
            risk.Text = "反向 " + (90.0 / lev).ToString("0.##", CultureInfo.InvariantCulture) + "% 触及强平";
        }
        leverage.ItemSelected += index => { _forexLeverageIndex = (int)index; UpdateEstimate(); };
        margin.TextChanged += _ => UpdateEstimate(); UpdateEstimate();
        var directions = new HBoxContainer(); directions.AddThemeConstantOverride("separation", 5); order.AddChild(directions);
        var buy = FxButton("做多 ↑", () => ForexAction(d, "open", ForexInput(margin.Text), direction: 1), height: 34);
        var sell = FxButton("做空 ↓", () => ForexAction(d, "open", ForexInput(margin.Text), direction: -1), height: 34);
        buy.Disabled = sell.Disabled = blocked != null; buy.AddThemeColorOverride("font_color", _forexUp); sell.AddThemeColorOverride("font_color", _forexDown);
        directions.AddChild(buy); directions.AddChild(sell);
        order.AddChild(FxLine("保证金 $100～$50,000 · 无持仓费", 11));

        var credit = FxButton("借还款  ·  待还 " + ForexService.Money(account.Debt) + "  ↗", () => ForexLoanDialog(d), height: 34);
        credit.Disabled = blocked != null; right.AddChild(credit);
    }

    private void ForexLoanDialog(CareerData data)
    {
        var state = _multiplayer == null ? ForexService.Ensure(data) : data.Forex!;
        var account = state.Account;
        OptionButton mode = null!; LineEdit amount = null!; Label hint = null!;
        void UpdateQuote()
        {
            bool full = mode.Selected == 2; amount.Editable = !full;
            if (full && amount.Text != ForexAmountText(account.Debt)) amount.Text = ForexAmountText(account.Debt);
            hint.Text = account.Loan == null
                ? "可借 $500～$50,000 · 日利率 " + (ForexMath.LoanDailyRate(ForexInput(amount.Text)) * 100).ToString("0.##", CultureInfo.InvariantCulture) + "%"
                : "待还 " + ForexService.Money(account.Debt) + " · 日利率 " + (account.Loan.DailyRate * 100).ToString("0.##", CultureInfo.InvariantCulture) + "%";
        }
        ShowCareerDialog("借还款", "外汇可用余额 " + ForexService.Money(account.Cash) + "。借款按生涯日复利计息。", () =>
        {
            if (mode.Selected == 2 && account.Cash < account.Debt) { hint.Text = "可用余额不足以还清，请选择部分还款。"; return false; }
            ForexAction(data, mode.Selected == 0 ? "borrow" : "repay", mode.Selected == 2 ? account.Debt : ForexInput(amount.Text));
            return true;
        }, "确认", contents: box =>
        {
            mode = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            mode.AddItem("借入资金"); mode.AddItem("部分还款"); mode.AddItem("全部还清");
            mode.Select(account.Loan == null ? 0 : 1); box.AddChild(mode);
            box.AddChild(FxLine("金额（美元）", 15));
            amount = FxInput(_forexLoanInput, text => _forexLoanInput = text); box.AddChild(amount);
            hint = FxLine("", 14, _gold); box.AddChild(hint);
            mode.ItemSelected += _ => UpdateQuote(); amount.TextChanged += _ => UpdateQuote(); UpdateQuote();
        });
    }

    private void ForexTable(VBoxContainer parent, CareerData data, ForexState state, string? blocked)
    {
        var panels = new HBoxContainer(); panels.AddThemeConstantOverride("separation", 8); parent.AddChild(panels);
        var positions = FxPanel(panels); ((Control)positions.GetParent()).CustomMinimumSize = new(0, 250);
        positions.AddChild(FxLine("持仓  /  " + state.Account.Positions.Count + " 笔", 17, _gold));
        int positionPages = Math.Max(1, (state.Account.Positions.Count + 1) / 2);
        _forexPositionPage = Math.Clamp(_forexPositionPage, 0, positionPages - 1);
        if (state.Account.Positions.Count == 0) positions.AddChild(FxLine("暂无持仓，存入资金后下单。", 13));
        foreach (var position in state.Account.Positions.Skip(_forexPositionPage * 2).Take(2))
        {
            double price = state.Prices.GetValueOrDefault(position.Pair, position.Entry), pnl = position.Equity(price) - position.Margin;
            var row = new HBoxContainer { CustomMinimumSize = new(0, 74) }; row.AddThemeConstantOverride("separation", 4); positions.AddChild(row);
            var text = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; text.AddThemeConstantOverride("separation", 1); row.AddChild(text);
            text.AddChild(FxLine(position.Pair + " " + (position.Dir > 0 ? "多" : "空") + position.Leverage + "×", 14, _ink));
            text.AddChild(FxLine("市值 " + ForexService.Money(position.Shares * price) + " · 盈亏 " + ForexService.Money(pnl), 12, pnl >= 0 ? _forexUp : _forexDown));
            text.AddChild(FxLine("保证金 " + ForexService.Money(position.Margin) + " · 强平 " + ForexService.Price(position.Pair, position.LiquidationPrice), 11));
            string detail = "保证金 " + ForexService.Money(position.Margin) + "\n持仓权益 " + ForexService.Money(position.Equity(price)) +
                "\n名义仓位 " + ForexService.Money(position.Notional) + "\n当前名义市值 " + ForexService.Money(position.Shares * price) +
                "\n浮动盈亏 " + ForexService.Money(pnl) + "\n开仓 " + ForexService.Price(position.Pair, position.Entry) +
                " · 强平 " + ForexService.Price(position.Pair, position.LiquidationPrice);
            var actions = new VBoxContainer(); actions.AddThemeConstantOverride("separation", 3); row.AddChild(actions);
            actions.AddChild(FxButton("详情", () => ShowCareerDialog(position.Pair + " · 持仓", detail, () => true, "关闭", showCancel: false), 44));
            var close = FxButton("平仓", () => ForexAction(data, "close", 0, position.Id), 44); close.Disabled = blocked != null; actions.AddChild(close);
        }
        ForexPager(positions, _forexPositionPage, positionPages, page => { _forexPositionPage = page; Render(); });

        var records = FxPanel(panels); ((Control)records.GetParent()).CustomMinimumSize = new(0, 250);
        records.AddChild(FxLine("结算与成交", 17, _gold));
        int recordPages = Math.Max(1, (state.Records.Count + 4) / 5); _forexRecordPage = Math.Clamp(_forexRecordPage, 0, recordPages - 1);
        if (state.Records.Count == 0) records.AddChild(FxLine("点击“推进一天”生成日结算。", 13));
        foreach (var record in state.Records.Skip(_forexRecordPage * 5).Take(5))
        {
            string value = "第" + record.Day + "天  " + record.Text +
                (record.Kind is "daily" or "signal" or "import" ? "" : " · " + ForexService.Money(record.Amount));
            var show = FxButton(value, () => ShowCareerDialog("记录详情", value, () => true, "关闭", showCancel: false), height: 26);
            show.Alignment = HorizontalAlignment.Left; show.ClipText = true; show.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; show.TooltipText = value;
            if (record.Kind == "liquidation") show.AddThemeColorOverride("font_color", _forexDown); records.AddChild(show);
        }
        ForexPager(records, _forexRecordPage, recordPages, page => { _forexRecordPage = page; Render(); });
    }
    private void ForexPager(VBoxContainer box, int page, int pages, Action<int> change)
    {
        var row = new HBoxContainer(); box.AddChild(row);
        var previous = FxButton("←", () => change(page - 1), 45); previous.Disabled = page == 0;
        var next = FxButton("→", () => change(page + 1), 45); next.Disabled = page + 1 >= pages;
        row.AddChild(previous); row.AddChild(FxLine((page + 1) + " / " + pages, 12)); row.AddChild(next);
    }
    private void ForexNextDay(CareerData data)
    {
        _forexRecordPage = 0;
        if (MultiplayerCommand("propose-advance", number: data.Day + 1, accepted: () => { _multiplayer?.Refresh(); Render(); })) return;
        bool advanced = CareerEngine.AdvanceOneDay(data); Render();
        if (!advanced) Notice("请先完成或放弃当前比赛。", true);
    }

    private void ForexAction(CareerData data, string action, double amount, int positionId = 0, int direction = 1)
    {
        if (_multiplayer != null)
        {
            string payload = System.Text.Json.JsonSerializer.Serialize(new ForexOrder(action, amount, _forexPair,
                direction, ForexRules.Leverages[_forexLeverageIndex], positionId));
            MultiplayerCommand("forex-" + action, text: payload, accepted: () =>
            {
                if (!IsInstanceValid(this) || IsQueuedForDeletion()) return;
                _multiplayer?.Refresh(); Render();
            });
            return;
        }
        var error = ForexService.Trade(data, action, amount, _forexPair, direction, ForexRules.Leverages[_forexLeverageIndex], positionId);
        int scroll = _scroll.ScrollVertical; Render(); _ = RestoreScrollAsync(scroll, _renderVersion);
        Notice(error ?? "交易已完成并保存。", error != null);
    }

    /// <summary>所有 UI 跨日入口共享的确认；真实推进仍使用宿主逐日循环。</summary>
    private void RequestCareerAdvance(CareerData data, int target, Action? after = null)
    {
        if (MatchFailure.Locked(data) is { } failure) { Notice(failure, true); return; }
        if (data.PendingMatchId != null) { Notice("请先完成当前比赛。", true); return; }
        void Advance()
        {
            if (MultiplayerCommand("propose-advance", number: target)) return;
            if (!CareerStore.IsCurrent(data)) { Notice("生涯已切换。", true); return; }
            int count = CareerEngine.AdvanceToDay(data, target);
            _selectedDay = data.Day;
            if (after != null) after(); else Render();
            if (count == 0) Notice("日期未推进，请检查当前比赛或活动。", true);
        }
        int positions = _multiplayer != null ? data.ForexGroupPositions :
            !ForexService.LegacyPatchLoaded && ForexService.IsSinglePlayer(data) ? ForexService.Ensure(data).Account.Positions.Count : 0;
        if (target > data.Day + 1 && positions > 0)
        {
            int span = Math.Min(84, target - data.Day);
            ShowCareerDialog("确认跳过日期", "计划最多推进 " + span + " 天，" + (_multiplayer == null ? "当前账户" : "全队账户") + "共有 " + positions +
                " 笔外汇持仓。每一天都会收盘、计息和检查强平；未来赛果与行情无法预先确定。\n推进仍会在比赛或待处理活动处停下。", () => { Advance(); return true; }, "确认推进");
        }
        else Advance();
    }
}


