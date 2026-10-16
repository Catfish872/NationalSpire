using Godot;

namespace NationalSpire;

/// <summary>控件常驻主菜单缓存；绑定时读取当前个人视图，离开页面即移除数据与操作回调。</summary>
internal partial class MarketTerminal : VBoxContainer
{
    private CareerData? _data;
    private Action<MarketOrder>? _submit;
    private Action<string>? _person;
    private MarketInspectionResult? _inspection;
    private int _inspectionGeneration;
    private bool _inspectionBusy;
    private MarketEvent[] _selectedEvents = [];
    private readonly Label[] _metrics = new Label[4];
    private readonly MarketAssetButton[] _rows = new MarketAssetButton[8];
    private readonly MarketPositionCard[] _holdings = new MarketPositionCard[5];
    private readonly Label[] _trades = new Label[5];
    private readonly MarketEventRow[] _events = new MarketEventRow[4];
    private readonly Label[] _sources = new Label[3];
    private readonly Dictionary<string, string> _searchText = [];
    private readonly HashSet<string> _watch = [];
    private string _identity = "", _selected = "", _query = "";
    private bool _forex, _watchOnly, _settingAmount;
    private int _portion;
    private int _page, _pageCount = 1, _holdPage, _tradePage, _range = 60, _sort;
    private string _country = "全部", _sector = "全部";
    private Label _name = null!, _quote = null!, _description = null!, _fee = null!, _assetCount = null!;
    private Label _depth = null!, _volatility = null!, _newsTitle = null!, _cost = null!, _notional = null!, _buyPrice = null!, _sellPrice = null!;
    private ProgressBar _volatilityBar = null!;
    private VBoxContainer _overview = null!;
    private Button _pin = null!;
    private MarketAmountInput _amount = null!, _transfer = null!;
    private OptionButton _leverage = null!;
    private HBoxContainer _columns = null!;
    private VBoxContainer _right = null!;
    private ScrollContainer _assetScroll = null!;
    private MarketChart _chart = null!;
    private readonly ConfigFile _preferences = new();
    private bool _loaded;
    private Label Label(string text, int size = 16, Color? color = null)
    {
        var label = new Label { Text = text, SizeFlagsHorizontal = SizeFlags.ExpandFill, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore };
        label.AddThemeFontSizeOverride("font_size", size); label.AddThemeColorOverride("font_color", color ?? CareerVisuals.Muted); return label;
    }
    private Button Button(string text, Action action)
    {
        var button = new Button { Text = text, SizeFlagsHorizontal = SizeFlags.ExpandFill, ClipText = true, CustomMinimumSize = new(0, 40) };
        button.AddThemeFontSizeOverride("font_size", 16); button.Pressed += action; return button;
    }
    private VBoxContainer Panel(Node parent, float ratio = 1)
    {
        var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = ratio };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232f", "345363", 10, 10)); parent.AddChild(panel);
        var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; panel.AddChild(box); return box;
    }
    private static MarketAmountInput Money() => new() { MinValue = 0, MaxValue = long.MaxValue * 10.0, AllowGreater = true, Value = 1000, Step = .01, Prefix = "$", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 46) };
    private IEnumerator<bool>? _builder;
    internal MarketTerminal()
    {
        // 仅替换终端自己的样式，不改共享主题或字体资源。
        Theme = (Theme)CareerVisuals.CreateTheme().Duplicate(); Theme.DefaultFontSize = 16;
        Theme.SetConstant("separation", "VBoxContainer", 6); Theme.SetConstant("separation", "HBoxContainer", 8);
        foreach (string type in new[] { "Button", "OptionButton", "CheckBox" })
        {
            Theme.SetStylebox("normal", type, CareerVisuals.Box("1d3040", "395365", 6, 6));
            Theme.SetStylebox("hover", type, CareerVisuals.Box("28495a", "70d4bc", 6, 6));
            Theme.SetStylebox("pressed", type, CareerVisuals.Box("304f60", "e5c18b", 6, 6));
        }
        Theme.SetStylebox("normal", "LineEdit", CareerVisuals.Box("101c2a", "395365", 6, 6));
        _builder = Build().GetEnumerator();
    }
    internal bool Prepare(double budgetMilliseconds)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        while (_builder != null)
        {
            if (!_builder.MoveNext()) { _builder.Dispose(); _builder = null; break; }
            if (watch.Elapsed.TotalMilliseconds >= budgetMilliseconds) break;
        }
        return _builder == null;
    }
    private IEnumerable<bool> Build()
    {
        SizeFlagsHorizontal = SizeFlags.ExpandFill;
        var top = new HBoxContainer(); AddChild(top);
        string[] titles = ["预计清仓净资产", "可用余额", "持仓保证金", "待偿借款"];
        for (int i = 0; i < 4; i++) { var card = Panel(top); card.AddChild(Label(titles[i], 15)); _metrics[i] = Label("", 27, CareerVisuals.Gold); card.AddChild(_metrics[i]); yield return true; }
        _columns = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; AddChild(_columns);
        var left = Panel(_columns, 22); var center = Panel(_columns, 53); _right = Panel(_columns, 25);
        left.SizeFlagsVertical = SizeFlags.ExpandFill;
        left.AddChild(Label("MARKET / 行情", 21, CareerVisuals.Gold));
        var kinds = new HBoxContainer(); left.AddChild(kinds);
        var brands = Button("品牌", () => { _forex = false; ResetList(); }); brands.Icon = LifestyleArt.Icon("日常消费"); kinds.AddChild(brands);
        var forex = Button("外汇", () => { _forex = true; ResetList(); }); forex.Icon = LifestyleArt.Icon("外汇"); kinds.AddChild(forex);
        var search = new LineEdit { PlaceholderText = "搜索品牌、选手或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        left.AddChild(search); search.TextChanged += value => { _query = value; ResetList(); };
        var filters = new HBoxContainer(); left.AddChild(filters);
        var country = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill }; foreach (string value in new[] { "全部" }.Concat(EsportsWorld.Countries)) country.AddItem(value);
        filters.AddChild(country); country.ItemSelected += i => { _country = country.GetItemText((int)i); ResetList(); };
        var sector = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill }; foreach (string value in new[] { "全部", "训练装备", "电竞设备", "日常消费" }) sector.AddItem(value);
        filters.AddChild(sector); sector.ItemSelected += i => { _sector = sector.GetItemText((int)i); ResetList(); };
        var sort = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill }; foreach (string value in new[] { "当日涨幅", "近7日涨幅", "近30日涨幅", "波动幅度" }) sort.AddItem(value);
        left.AddChild(sort); sort.ItemSelected += i => { _sort = (int)i; ResetList(); };
        var watched = new CheckBox { Text = "只看自选" }; left.AddChild(watched); watched.Toggled += value => { _watchOnly = value; ResetList(); };
        _assetScroll = new ScrollContainer { Name = "MarketAssets", HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled,
            SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 284), MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false };
        left.AddChild(_assetScroll);
        var assetList = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _assetScroll.AddChild(assetList);
        for (int i = 0; i < _rows.Length; i++) { int row = i; _rows[i] = new MarketAssetButton(); _rows[i].Pressed += () => SelectRow(row); assetList.AddChild(_rows[i]); yield return true; }
        yield return true;
        _assetCount = Label(""); left.AddChild(_assetCount);
        var pages = new HBoxContainer(); left.AddChild(pages);
        pages.AddChild(Button("←", () => ChangePage(-1))); pages.AddChild(Button("→", () => ChangePage(1)));
        var heading = new HBoxContainer(); center.AddChild(heading); _name = Label("", 26, CareerVisuals.Gold); heading.AddChild(_name);
        _pin = Button("☆", ToggleWatch); _pin.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; _pin.CustomMinimumSize = new(48, 40); heading.AddChild(_pin);
        _quote = Label("", 30, CareerVisuals.Teal); center.AddChild(_quote);
        _description = Label("", 15); center.AddChild(_description);
        var ranges = new HBoxContainer(); center.AddChild(ranges);
        foreach (int count in new[] { 30, 60, 90, 180 }) ranges.AddChild(Button(count + "日", () => { _range = count; RefreshChart(); }));
        _chart = new MarketChart { CustomMinimumSize = new(0, 270), SizeFlagsHorizontal = SizeFlags.ExpandFill }; center.AddChild(_chart);
        _overview = new VBoxContainer(); center.AddChild(_overview);
        var traits = new HBoxContainer(); _overview.AddChild(traits);
        foreach (string title in new[] { "承接规模", "日常波动" })
        {
            var card = Panel(traits); var caption = new HBoxContainer(); card.AddChild(caption);
            var icon = new TextureRect { Texture = LifestyleArt.Icon(title == "承接规模" ? "外汇" : "波动"), CustomMinimumSize = new(18, 18), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered };
            caption.AddChild(icon); caption.AddChild(Label(title, 13));
            var value = Label("", 21, CareerVisuals.Gold); card.AddChild(value);
            if (title == "承接规模") { _depth = value; card.TooltipText = "承接规模越大，同等金额订单造成的成交价差越小。"; }
            else
            {
                _volatility = value;
                card.TooltipText = "数值越大，日常报价起伏通常越明显。刻度范围0%至3%。";
                _volatilityBar = new ProgressBar { MaxValue = .03, Step = .000001, ShowPercentage = false, CustomMinimumSize = new(0, 5), MouseFilter = MouseFilterEnum.Ignore };
                _volatilityBar.AddThemeStyleboxOverride("background", CareerVisuals.Box("091923", "203844", 3, 0));
                _volatilityBar.AddThemeStyleboxOverride("fill", CareerVisuals.Box("e4b367", "e4b367", 3, 0)); card.AddChild(_volatilityBar);
            }
        }
        var sources = new HFlowContainer(); _overview.AddChild(sources);
        for (int i = 0; i < _sources.Length; i++)
        {
            var source = new HBoxContainer(); sources.AddChild(source);
            source.AddChild(new TextureRect { Texture = LifestyleArt.Icon(i == 0 ? "训练装备" : i == 1 ? "人气榜" : "交易市场"), CustomMinimumSize = new(16, 16), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered });
            _sources[i] = Label("", 13); _sources[i].SizeFlagsHorizontal = SizeFlags.ShrinkBegin;
            _sources[i].AutowrapMode = TextServer.AutowrapMode.Off;
            source.AddChild(_sources[i]);
        }
        _newsTitle = Label("近期动态", 18, CareerVisuals.Gold); center.AddChild(_newsTitle);
        for (int i = 0; i < _events.Length; i++)
        {
            int row = i; _events[i] = new MarketEventRow();
            _events[i].Pressed += () => { if (row < _selectedEvents.Length && _selectedEvents[row].Person.Length > 0) _person?.Invoke(_selectedEvents[row].Person); };
            center.AddChild(_events[i]); yield return true;
        }
        yield return true;
        _right.AddChild(Label("资金存取", 22, CareerVisuals.Gold)); _transfer = Money(); _right.AddChild(_transfer);
        var transfers = new GridContainer { Columns = 2 }; _right.AddChild(transfers);
        foreach (var (action, title) in new[] { ("deposit", "存入"), ("withdraw", "取出"), ("borrow", "借款"), ("repay", "还款") }) { var button = Button(title, () => { decimal amount = _transfer.Amount / 10; _transfer.Apply(); Submit(new(action, Amount: amount)); }); button.Icon = LifestyleArt.Icon(action is "deposit" or "withdraw" ? "外汇" : "收支记录"); transfers.AddChild(button); }
        _right.AddChild(Button("还清借款", () => Submit(new("repay-all"))));
        _right.AddChild(Label("借款 $500—50,000，日利率按金额为0.02% / 0.04% / 0.07%。", 13));
        _right.AddChild(new HSeparator()); _right.AddChild(Label("下单", 22, CareerVisuals.Gold));
        _right.AddChild(Label("保证金", 14));
        _amount = Money(); _amount.Step = .01; _amount.UpdateOnTextChanged = true; _right.AddChild(_amount);
        _amount.GetLineEdit().TextChanged += _ => { if (!_settingAmount) { _portion = 0; RefreshFee(); } };
        _amount.ValueChanged += _ => { if (!_settingAmount) { _portion = 0; RefreshFee(); } };
        var portions = new HBoxContainer(); _right.AddChild(portions);
        foreach (int percent in new[] { 10, 25, 50, 100 }) portions.AddChild(Button(percent + "%", () =>
        {
            _portion = percent; RefreshFee();
        }));
        _right.AddChild(Label("杠杆倍数", 14));
        _leverage = new OptionButton(); foreach (int value in CareerMarket.Leverages) _leverage.AddIconItem(LifestyleArt.Icon("杠杆"), value + " ×"); _right.AddChild(_leverage); _leverage.ItemSelected += _ => RefreshFee();
        var cost = Panel(_right); cost.AddChild(Label("合计扣款", 13)); _cost = Label("", 26, CareerVisuals.Gold); cost.AddChild(_cost);
        Label AmountRow(string title)
        {
            var line = new HBoxContainer(); cost.AddChild(line); line.AddChild(Label(title, 13));
            var value = Label("", 14); value.HorizontalAlignment = HorizontalAlignment.Right; line.AddChild(value); return value;
        }
        _notional = AmountRow("交易总额"); _fee = AmountRow("手续费");
        _buyPrice = Label("", 13); _right.AddChild(_buyPrice);
        var buy = Button("做多", () => Open(1)); MarketVisuals.ActionStyle(buy, "做多"); _right.AddChild(buy);
        _sellPrice = Label("", 13); _right.AddChild(_sellPrice);
        var sell = Button("做空", () => Open(-1)); MarketVisuals.ActionStyle(sell, "做空"); _right.AddChild(sell);
        sell.Name = "Short";
        var bottom = new HBoxContainer(); AddChild(bottom); var holdings = Panel(bottom); var ledger = Panel(bottom);
        holdings.AddChild(Label("持仓", 22, CareerVisuals.Gold));
        for (int i = 0; i < _holdings.Length; i++) { int row = i; _holdings[i] = new MarketPositionCard(() => ClosePosition(row), Submit); holdings.AddChild(_holdings[i]); yield return true; }
        var hp = new HBoxContainer(); holdings.AddChild(hp); hp.AddChild(Button("←", () => { _holdPage = Math.Max(0, _holdPage - 1); RefreshAccount(); })); hp.AddChild(Button("→", () => { _holdPage++; RefreshAccount(); }));
        ledger.AddChild(Label("结算与成交", 22, CareerVisuals.Gold));
        for (int i = 0; i < _trades.Length; i++) { _trades[i] = Label("", 16); ledger.AddChild(_trades[i]); yield return true; }
        var tp = new HBoxContainer(); ledger.AddChild(tp); tp.AddChild(Button("←", () => { _tradePage = Math.Max(0, _tradePage - 1); RefreshAccount(); })); tp.AddChild(Button("→", () => { _tradePage++; RefreshAccount(); }));
        Resized += () =>
        {
            var panel = _right.GetParent(); bool narrow = Size.X < 1050;
            if (narrow && panel.GetParent() == _columns) panel.Reparent(this);
            else if (!narrow && panel.GetParent() != _columns) panel.Reparent(_columns);
        };
    }
    internal void Bind(CareerData d, Action<MarketOrder> submit, Action<string> person)
    {
        Prepare(double.PositiveInfinity);
        if (!ReferenceEquals(_data, d)) _inspection = null;
        _data = d; _submit = submit; _person = person;
        if (_inspection?.Revision != d.Market.Revision) _inspection = null;
        string identity = d.WorldId + ":" + GroupChats.Human(d);
        if (!_loaded) { _preferences.Load("user://NationalSpire_market.cfg"); _loaded = true; }
        if (_identity != identity)
        {
            _identity = identity; _portion = 0; _watch.Clear(); _selected = ""; _page = _holdPage = _tradePage = 0;
            if (_preferences.HasSectionKey(identity, "watch")) foreach (string id in _preferences.GetValue(identity, "watch").AsStringArray()) _watch.Add(id);
        }
        _searchText.Clear(); var links = MarketDynamics.Links(d); var partners = MarketDynamics.Partners(d, links);
        var clubs = links.Where(l => l.Club).GroupBy(l => l.Brand).ToDictionary(g => g.Key,
            g => string.Join(" ", g.Select(l => EsportsWorld.ClubName(d, l.Target)).Distinct()));
        var people = d.People.ToDictionary(p => p.Id);
        foreach (var asset in MarketCatalog.Assets)
            _searchText[asset.Id] = asset.Name + " " + asset.Country + " " + asset.Sector + " " + clubs.GetValueOrDefault(asset.Name) + " " + string.Join(" ", (partners.GetValueOrDefault(asset.Name) ?? []).Select(id => people.TryGetValue(id, out var p) ? p.PublicName + " " + EsportsWorld.ClubName(d, p.ClubId) : id == "player" ? CareerEngine.Name(d) : id));
        RefreshList(); RefreshAccount();
    }
    internal void Unbind() { _data = null; _submit = null; _person = null; _inspection = null; _inspectionGeneration++; _selectedEvents = []; _searchText.Clear(); foreach (var card in _holdings) card?.Bind(null, null); }
    private MarketAsset[] _visible = [];
    private void ResetList() { _page = 0; _assetScroll.ScrollVertical = 0; RefreshList(); }
    private void ChangePage(int direction) { _page = (_page + direction + _pageCount) % _pageCount; _assetScroll.ScrollVertical = 0; RefreshList(); }
    private double SortValue(MarketAsset asset)
    {
        var q = _data!.Market.Quotes[asset.Id];
        if (_sort == 3) return MarketDynamics.Volatility(_data.WorldId, asset);
        decimal previous = _sort == 0 ? q.Previous : q.History[Math.Max(0, q.History.Count - (_sort == 1 ? 8 : 31))].Price;
        return (double)(q.Price / previous - 1);
    }
    private void RefreshList()
    {
        if (_data == null) return;
        var assets = MarketCatalog.Assets.Where(a => a.Forex == _forex && (_country == "全部" || a.Country == _country)
            && (_forex || _sector == "全部" || a.Sector == _sector) && (!_watchOnly || _watch.Contains(a.Id)) && _searchText[a.Id].Contains(_query, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(a => _watch.Contains(a.Id)).ThenByDescending(SortValue).ThenBy(a => a.Id, StringComparer.Ordinal).ToArray();
        _pageCount = Math.Max(1, (assets.Length + _rows.Length - 1) / _rows.Length);
        _page = Math.Min(_page, _pageCount - 1); _visible = assets.Skip(_page * _rows.Length).Take(_rows.Length).ToArray();
        for (int i = 0; i < _rows.Length; i++)
        {
            _rows[i].Visible = i < _visible.Length;
            if (i >= _visible.Length) continue;
            var asset = _visible[i];
            _rows[i].Bind(asset, _data.Market.Quotes[asset.Id], _watch.Contains(asset.Id), asset.Id == _selected);
        }
        _assetCount.Text = $"{assets.Length} 项 · {_page + 1} / {_pageCount}";
        if (!assets.Any(a => a.Id == _selected)) _selected = assets.FirstOrDefault()?.Id ?? "";
        RefreshSelection();
    }
    private void SelectRow(int row) { if (row < _visible.Length) { _selected = _visible[row].Id; RefreshSelection(); } }
    private void RefreshSelection()
    {
        if (_data == null) return;
        if (!MarketCatalog.ById.TryGetValue(_selected, out var asset))
        {
            _name.Text = "没有符合条件的资产"; _name.TooltipText = "";
            _quote.Text = _description.Text = _fee.Text = _cost.Text = _notional.Text = _buyPrice.Text = _sellPrice.Text = "";
            _overview.Hide(); _newsTitle.Hide();
            _selectedEvents = []; foreach (var item in _events) item.Hide(); _chart.Set([], ""); return;
        }
        var quote = _data.Market.Quotes[_selected]; _name.Text = asset.Name; _name.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));
        for (int i = 0; i < _visible.Length; i++) MarketVisuals.Style(_rows[i], _visible[i].Sector, _visible[i].Id == _selected); _pin.Text = _watch.Contains(_selected) ? "★" : "☆";
        _quote.Text = (asset.Forex ? quote.Price.ToString("0.00000") : CareerMoney.Format(quote.Price)) + $"   {quote.Price / quote.Previous - 1:+0.00%;-0.00%;0.00%}";
        _description.Text = asset.Country + " · " + asset.Sector + (asset.Forex ? "\n1 人民币 = " + quote.Price.ToString("0.00000") + " " + asset.Name.Replace("人民币 / ", "") : "");
        _name.TooltipText = asset.Forex ? "" : RegionalOrganizations.SponsorDescription(asset.Name);
        RefreshChart(); _overview.Show();
        var depthQuote = _data.Market.Quotes[asset.Id];
        decimal depth = (depthQuote.ClearingDepthUnits > 0 ? depthQuote.ClearingDepthUnits * MarketExecution.ReferencePrice(depthQuote) : MarketExecution.Depth(asset)) * 10;
        _depth.Text = depth >= 1_000_000_000_000m ? (depth / 1_000_000_000_000m).ToString("0.##") + " 万亿美元" : (depth / 100_000_000m).ToString("0.##") + " 亿美元";
        double volatility = MarketDynamics.Volatility(_data.WorldId, asset); _volatility.Text = volatility.ToString("0.00%"); _volatilityBar.Value = volatility;
        string industry = asset.Sector switch { "训练装备" => "工业与基建", "电竞设备" => "高新与服务产业", _ => "收入与服务产业" };
        string[] sources = asset.Forex ? ["中外国运", "国际赛果"] : [industry, "代言人气", "赛事表现"];
        for (int i = 0; i < _sources.Length; i++)
        {
            var source = (Control)_sources[i].GetParent(); source.Visible = i < sources.Length;
            if (i < sources.Length) { _sources[i].Text = sources[i]; _sources[i].AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector)); }
        }
        ((TextureRect)_sources[0].GetParent().GetChild(0)).Texture = LifestyleArt.Icon(asset.Forex ? "外汇" : asset.Sector);
        _right.GetNode<Control>("Short").Visible = true;
        var news = _data.Market.Events.AsEnumerable().Reverse().Where(e => e.Asset == _selected)
            .Select(e => (Event: e, Title: EventTitle(e, asset))).Where(e => e.Title.Length > 0).Take(_events.Length).ToArray();
        _selectedEvents = news.Select(e => e.Event).ToArray(); _newsTitle.Visible = news.Length > 0;
        for (int i = 0; i < _events.Length; i++) { _events[i].Visible = i < news.Length; if (i < news.Length) _events[i].Bind(news[i].Event, news[i].Title); }
        RefreshFee();
    }
    private void RefreshChart()
    {
        if (_data != null && MarketCatalog.ById.TryGetValue(_selected, out var asset))
            _chart.Set(_data.Market.Quotes[_selected].History.TakeLast(_range).ToArray(), _data.WorldId + asset.Id, asset.Forex ? 1 : 10);
    }
    private string EventTitle(MarketEvent item, MarketAsset asset)
    {
        // 旧版待计价记录保留在存档中，页面选择已经发生的市场事实。
        if (item.Text.Contains("下一日") || item.Text.Contains("次日") || item.Text.Contains("待计入")) return "";
        if (item.Competition.Length > 0)
        {
            string? name = _data!.Esports.Competitions.FirstOrDefault(c => c.Id == item.Competition)?.Name;
            if (name == null) { int end = item.Text.IndexOf("赛果", StringComparison.Ordinal); name = end > 0 ? item.Text[..Math.Min(end, 64)] : "赛事表现"; }
            return name + " · 赛事影响";
        }
        if (item.Text.Contains("已写入") || item.Text.Contains("已计入")) return "";
        string text = item.Text.StartsWith(asset.Name, StringComparison.Ordinal) ? item.Text[asset.Name.Length..].TrimStart(' ', '·', '：') : item.Text;
        return text.Length > 96 ? text[..96] + "…" : text;
    }
    private decimal OrderMargin(MarketAsset asset, int leverage) => _portion > 0
        ? CareerMarket.BudgetMargin(asset, _data!.Life.Trading.Cash, leverage, _portion) : _amount.Amount / 10;
    private void RefreshFee()
    {
        if (_data == null || !MarketCatalog.ById.TryGetValue(_selected, out var asset)) return;
        int leverage = CareerMarket.Leverages[_leverage.Selected];
        if (_portion > 0)
        {
            _settingAmount = true;
            _amount.SetAmount(CareerMarket.BudgetMargin(asset, _data.Life.Trading.Cash, leverage, _portion) * 10);
            _settingAmount = false;
        }
        decimal margin = OrderMargin(asset, leverage);
        decimal fee = CareerMarket.OpenFee(asset, margin, leverage);
        string Quote(decimal value) => asset.Forex ? value.ToString("0.00000") : CareerMoney.Format(value);
        _cost.Text = CareerMoney.Compact(margin + fee); _notional.Text = CareerMoney.Compact(margin * leverage); _fee.Text = CareerMoney.Compact(fee);
        _cost.MouseFilter = _notional.MouseFilter = _fee.MouseFilter = MouseFilterEnum.Pass;
        _cost.TooltipText = CareerMoney.Format(margin + fee); _notional.TooltipText = CareerMoney.Format(margin * leverage); _fee.TooltipText = CareerMoney.Format(fee);
        if (_data.InspectMarket != null)
        {
            _buyPrice.Text = _sellPrice.Text = "正在计算成交均价"; RequestInspection(); return;
        }
        var buy = MarketClearing.Preview(_data, new("open", asset.Id, margin, 1, leverage), false);
        var sell = MarketClearing.Preview(_data, new("open", asset.Id, margin, -1, leverage), false);
        _buyPrice.Text = "预计成交均价  " + Quote(buy.Average); _sellPrice.Text = "预计成交均价  " + Quote(sell.Average);
    }
    private async void RequestInspection()
    {
        int generation = ++_inspectionGeneration;
        await Task.Delay(120);
        if (generation != _inspectionGeneration || _inspectionBusy || _data?.InspectMarket == null || !MarketCatalog.ById.TryGetValue(_selected, out var asset)) return;
        var data = _data; int leverage = CareerMarket.Leverages[_leverage.Selected];
        var request = new MarketInspection(asset.Id, OrderMargin(asset, leverage), leverage, data.Life.Trading.Positions.Skip(_holdPage * 5).Take(5).Select(p => p.Id).ToArray());
        _inspectionBusy = true;
        try
        {
            var result = await data.InspectMarket(request);
            if (generation != _inspectionGeneration || !ReferenceEquals(_data, data) || result.Revision != data.Market.Revision) return;
            _inspection = result;
            string Quote(decimal value) => asset.Forex ? value.ToString("0.00000") : CareerMoney.Format(value);
            _buyPrice.Text = "预计成交均价  " + Quote(result.Buy.Average); _sellPrice.Text = "预计成交均价  " + Quote(result.Sell.Average);
            RefreshAccount(false);
        }
        catch (Exception error)
        {
            Diagnostics.Error("market.remote-preview", error);
            if (generation == _inspectionGeneration && _data != null) _buyPrice.Text = _sellPrice.Text = "报价读取失败，点击下单时重新计算";
        }
        finally { _inspectionBusy = false; if (_data?.InspectMarket != null && generation != _inspectionGeneration) RequestInspection(); }
    }
    private void RefreshAccount(bool requestInspection = true)
    {
        if (_data == null) return; var account = _data.Life.Trading;
        bool remote = _data.InspectMarket != null;
        decimal[] values = [remote ? _inspection?.Net ?? 0 : MarketExecution.LiquidationValue(_data.Market, account, MarketClearing.Accounts(_data)), account.Cash, account.Positions.Sum(p => p.Margin), account.Debt];
        for (int i = 0; i < 4; i++) { _metrics[i].Text = CareerMoney.Compact(values[i]); _metrics[i].TooltipText = CareerMoney.Format(values[i]); _metrics[i].MouseFilter = MouseFilterEnum.Pass; }
        if (remote && _inspection == null) { _metrics[0].Text = "正在计算"; _metrics[0].TooltipText = ""; }
        _holdPage = Math.Min(_holdPage, Math.Max(0, (account.Positions.Count - 1) / 5));
        for (int i = 0; i < 5; i++)
        {
            var p = account.Positions.Skip(_holdPage * 5 + i).FirstOrDefault(); _holdings[i].Visible = p != null || i == 0;
            var exit = p == null ? null : remote ? _inspection?.Exits.GetValueOrDefault(p.Id) : MarketClearing.PreviewClose(_data, p);
            _holdings[i].Bind(p, p == null ? null : _data.Market.Quotes[p.Asset], _data.Market.Revision, exit, remote && exit == null);
        }
        _tradePage = Math.Min(_tradePage, Math.Max(0, (account.Trades.Count - 1) / 5));
        var trades = account.Trades.AsEnumerable().Reverse().Skip(_tradePage * 5).Take(5).ToArray();
        for (int i = 0; i < 5; i++) { _trades[i].Visible = i < trades.Length || i == 0; _trades[i].Text = i < trades.Length ? $"第{trades[i].Day}天 · {trades[i].Text}\n{CareerMoney.Compact(trades[i].Change)}" : "暂无成交"; }
        if (remote && requestInspection) RequestInspection();
    }
    private void ToggleWatch()
    {
        if (_selected.Length == 0) return;
        if (!_watch.Add(_selected)) _watch.Remove(_selected);
        _preferences.SetValue(_identity, "watch", _watch.Order().ToArray()); _preferences.Save("user://NationalSpire_market.cfg"); RefreshList();
    }
    private void Submit(MarketOrder order) => _submit?.Invoke(order);
    internal void SetOrderMargin(decimal margin)
    {
        _portion = 0; _settingAmount = true; _amount.SetAmount(margin * 10); _settingAmount = false; RefreshFee();
    }
    private void Open(int direction)
    {
        if (_data == null || !MarketCatalog.ById.TryGetValue(_selected, out var asset)) return;
        // Apply 会重写输入框文字；提交本身不应取消玩家已选择的比例。
        int leverage = CareerMarket.Leverages[_leverage.Selected]; decimal amount = OrderMargin(asset, leverage);
        _settingAmount = true; _amount.Apply(); _settingAmount = false;
        Submit(new("open", _selected, amount, direction, leverage, QuoteRevision: _data.Market.Revision));
    }
    private void ClosePosition(int row)
    {
        if (_data == null) return; var p = _data.Life.Trading.Positions.Skip(_holdPage * 5 + row).FirstOrDefault();
        if (p != null) Submit(new("close", Position: p.Id, QuoteRevision: _data.Market.Revision));
    }
}

public partial class MarketChart : Control
{
    private MarketPoint[] _points = [];
    private string _seed = "";
    private int _hover = -1;
    private decimal _displayScale = 1;
    public MarketPoint[] Points { get => _points; set => Set(value, _seed); }
    public void Set(MarketPoint[] points, string seed, decimal displayScale = 1) { _points = points; _seed = seed; _displayScale = displayScale; _hover = -1; QueueRedraw(); }
    public override void _Ready() { Resized += QueueRedraw; MouseExited += () => { _hover = -1; QueueRedraw(); }; }
    public override void _GuiInput(InputEvent e)
    {
        if (e is InputEventMouseMotion mouse && _points.Length > 0) { _hover = Math.Clamp((int)((mouse.Position.X - 8) / Math.Max(1, Size.X - 90) * _points.Length), 0, _points.Length - 1); QueueRedraw(); }
    }
    public override void _Draw()
    {
        if (_points.Length == 0 || Size.X < 100) return;
        var font = GetThemeDefaultFont(); var area = new Rect2(8, 30, Size.X - 90, Size.Y - 60);
        decimal low = _points.Min(p => p.Price) * .988m, high = _points.Max(p => p.Price) * 1.012m, range = high - low;
        float Y(decimal value) => area.End.Y - (float)((value - low) / range) * area.Size.Y;
        DrawRect(new Rect2(Vector2.Zero, Size), new Color("0b1c25"));
        for (int i = 0; i <= 4; i++)
        {
            float y = area.Position.Y + area.Size.Y * i / 4; DrawLine(new(8, y), new(area.End.X, y), new Color("29434b"));
            DrawString(font, new(area.End.X + 8, y + 5), ((high - range * i / 4) * _displayScale).ToString(_displayScale == 1 ? "0.0000" : "0.00"), fontSize: 13, modulate: CareerVisuals.Muted);
        }
        float step = area.Size.X / _points.Length;
        for (int i = 0; i < _points.Length; i++)
        {
            decimal close = _points[i].Price, open = i == 0 ? close : _points[i - 1].Price;
            decimal wick = close * (decimal)(.002 + (CareerEngine.StableHash(_seed + _points[i].Day) % 1000) / 100000.0);
            var color = close >= open ? new Color("82d7b5") : new Color("ee98aa"); float x = area.Position.X + step * (i + .5f);
            DrawLine(new(x, Y(Math.Max(open, close) + wick)), new(x, Y(Math.Min(open, close) - wick)), color, 1.3f);
            DrawRect(new Rect2(x - Math.Max(1, step * .3f), Y(Math.Max(open, close)), Math.Max(2, step * .6f), Math.Max(2, Math.Abs(Y(open) - Y(close)))), color);
        }
        var last = _points[^1]; DrawLine(new(8, Y(last.Price)), new(area.End.X, Y(last.Price)), CareerVisuals.Gold, 1);
        DrawString(font, new(8, Size.Y - 8), _points[0].Day > 0 ? "D" + _points[0].Day : "开市前", fontSize: 13, modulate: CareerVisuals.Muted);
        DrawString(font, new(area.End.X - 48, Size.Y - 8), "D" + last.Day, fontSize: 13, modulate: CareerVisuals.Muted);
        if (_hover >= 0 && _hover < _points.Length)
        {
            float x = area.Position.X + step * (_hover + .5f); DrawLine(new(x, 28), new(x, area.End.Y), new Color("7b9b9c"));
            DrawString(font, new(10, 20), $"第{_points[_hover].Day}天  开 {(_hover > 0 ? _points[_hover - 1].Price : _points[_hover].Price) * _displayScale:0.0000}  收 {_points[_hover].Price * _displayScale:0.0000}", fontSize: 14, modulate: CareerVisuals.Gold);
        }
    }
}
