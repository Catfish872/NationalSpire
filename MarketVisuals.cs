using Godot;

namespace NationalSpire;

/// <summary>市场专用样式在主线程按类别缓存，不修改全局主题或字体。</summary>
internal static class MarketVisuals
{
    private static readonly Dictionary<(string, bool, bool), StyleBoxFlat> Cards = [];
    private static readonly Dictionary<(string, int), StyleBoxFlat> Actions = [];
    public static Color Accent(string sector) => new(sector switch {
        "训练装备" => "e4b367", "电竞设备" => "a99aef", "日常消费" or "做多" => "70d4bc", "做空" => "f095a3", _ => "81b8ec" });
    public static StyleBoxFlat Card(string sector, bool selected, bool hover = false)
    {
        var key = (sector, selected, hover);
        if (Cards.TryGetValue(key, out var style)) return style;
        var accent = Accent(sector);
        style = CareerVisuals.Box("0e1e2b", "345363", 9, 12);
        style.BgColor = new Color(new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f), .94f);
        style.BorderColor = new Color(accent, selected ? .95f : hover ? .65f : .26f);
        style.BorderWidthLeft = selected ? 4 : 3;
        return Cards[key] = style;
    }
    public static void Style(Button button, string sector, bool selected = false)
    {
        button.AddThemeStyleboxOverride("normal", Card(sector, selected));
        button.AddThemeStyleboxOverride("hover", Card(sector, selected, true));
        button.AddThemeStyleboxOverride("pressed", Card(sector, true));
    }
    public static void ActionStyle(Button button, string action)
    {
        var accent = Accent(action);
        foreach (var (state, strength) in new[] { ("normal", 0), ("hover", 1), ("pressed", 2) })
        {
            if (!Actions.TryGetValue((action, strength), out var style))
            {
                style = CareerVisuals.Box("10232f", "345363", 7, 10);
                style.BgColor = new Color("10232f").Lerp(accent, .12f + strength * .09f);
                style.BorderColor = new Color(accent, .65f + strength * .15f);
                Actions[(action, strength)] = style;
            }
            button.AddThemeStyleboxOverride(state, style);
            button.AddThemeColorOverride(state == "normal" ? "font_color" : "font_" + state + "_color", accent);
        }
        button.Icon = LifestyleArt.Icon(action);
        button.CustomMinimumSize = new(0, 48);
    }
    public static Color LevelColor(int level) => new(level switch {
        <= 2 => "b96c7c", <= 4 => "e4ab65", <= 6 => "70d4bc", <= 8 => "ad9ded", _ => "f0cf85" });
}

internal partial class MarketAssetButton : Button
{
    private readonly Label _name = new(), _sector = new(), _price = new(), _change = new();
    private readonly TextureRect _icon = new() { CustomMinimumSize = new(23, 23), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
        StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
    internal MarketAssetButton()
    {
        SizeFlagsHorizontal = SizeFlags.ExpandFill; CustomMinimumSize = new(0, 92);
        var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore };
        margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (var side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, side == "left" ? 14 : 9);
        AddChild(margin);
        var box = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; margin.AddChild(box);
        var heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; box.AddChild(heading); heading.AddChild(_icon); heading.AddChild(_name);
        box.AddChild(_sector);
        var quote = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; box.AddChild(quote); quote.AddChild(_price); quote.AddChild(_change);
        foreach (var label in new[] { _name, _sector, _price, _change })
        {
            label.MouseFilter = MouseFilterEnum.Ignore; label.ClipText = true; label.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            label.AddThemeFontSizeOverride("font_size", label == _sector ? 12 : 16);
        }
        _name.SizeFlagsStretchRatio = 5; _change.HorizontalAlignment = HorizontalAlignment.Right;
        _name.AddThemeColorOverride("font_color", new Color("e5eef2"));
    }
    internal void Bind(MarketAsset asset, MarketQuote quote, bool watched, bool selected)
    {
        _name.Text = (watched ? "★ " : "") + asset.Name; _sector.Text = asset.Country + "  /  " + asset.Sector;
        _sector.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));
        _icon.Texture = LifestyleArt.Icon(asset.Sector);
        _price.Text = asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Compact(quote.Price);
        decimal change = quote.Price / quote.Previous - 1;
        _change.Text = $"{change:+0.00%;-0.00%;0.00%}";
        _change.AddThemeColorOverride("font_color", change >= 0 ? CareerVisuals.Teal : new Color("f095a3"));
        TooltipText = asset.Name + " · " + asset.Country + " · " + asset.Sector;
        MarketVisuals.Style(this, asset.Sector, selected);
    }
}

/// <summary>四条市场事件复用日期、标题和报价变化控件，人物链接沿用事件记录。</summary>
internal partial class MarketEventRow : Button
{
    private readonly Label _day = new(), _title = new(), _change = new();
    internal MarketEventRow()
    {
        SizeFlagsHorizontal = SizeFlags.ExpandFill; CustomMinimumSize = new(0, 62);
        var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore };
        margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, 8);
        AddChild(margin);
        var row = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; margin.AddChild(row);
        var text = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore }; row.AddChild(text);
        text.AddChild(_day); text.AddChild(_title); row.AddChild(_change);
        foreach (var label in new[] { _day, _title, _change }) { label.MouseFilter = MouseFilterEnum.Ignore; label.AddThemeFontSizeOverride("font_size", label == _day ? 12 : 15); }
        _day.AddThemeColorOverride("font_color", CareerVisuals.Muted);
        _title.SizeFlagsHorizontal = SizeFlags.ExpandFill; _title.AutowrapMode = TextServer.AutowrapMode.WordSmart; _title.MaxLinesVisible = 2;
        _change.CustomMinimumSize = new(72, 0); _change.HorizontalAlignment = HorizontalAlignment.Right; _change.VerticalAlignment = VerticalAlignment.Center;
        MarketVisuals.Style(this, "", false);
    }
    internal void Bind(MarketEvent item, string title)
    {
        _day.Text = $"第 {item.Day} 天"; _title.Text = title;
        _change.Text = item.Change.ToString("+0.00%;-0.00%;0.00%");
        _change.AddThemeColorOverride("font_color", item.Change >= 0 ? CareerVisuals.Teal : new Color("f095a3"));
        MouseDefaultCursorShape = item.Person.Length > 0 ? CursorShape.PointingHand : CursorShape.Arrow;
    }
}

internal partial class DevelopmentGauge : Control
{
    public int Level { get; init; }
    public DevelopmentGauge() { CustomMinimumSize = new(0, 16); SizeFlagsHorizontal = SizeFlags.ExpandFill; MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        float width = (Size.X - 8 * 4) / 9;
        var color = MarketVisuals.LevelColor(Level);
        for (int i = 0; i < 9; i++)
        {
            var rect = new Rect2(i * (width + 4), 1, width, Size.Y - 2);
            DrawRect(rect, i < Level ? color : new Color("0b1822"));
            DrawRect(rect, new Color(color, i < Level ? .8f : .22f), false, 1);
        }
    }
}

/// <summary>持仓信息与平仓操作分离；五张卡片常驻终端缓存，每次仅更新文字和样式。</summary>
internal partial class MarketPositionCard : PanelContainer
{
    private readonly Label _title = new(), _terms = new(), _profit = new(), _proceeds = new(), _preview = new();
    private readonly TextureRect _icon = new() { CustomMinimumSize = new(24, 24), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
        StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
    private readonly Button _close;
    private readonly HBoxContainer _actions = new();
    private readonly VBoxContainer _editor = new() { Visible = false };
    private readonly MarketAmountInput _input = new() { MinValue = 0, MaxValue = long.MaxValue * 10.0, AllowGreater = true, SizeFlagsHorizontal = SizeFlags.ExpandFill };
    private readonly Button _apply, _clear;
    private readonly Action<MarketOrder> _submit;
    private MarketPosition? _position;
    private MarketQuote? _quote;
    private long _revision;
    private bool _margin;
    internal MarketPositionCard(Action close, Action<MarketOrder> submit)
    {
        _submit = submit;
        SizeFlagsHorizontal = SizeFlags.ExpandFill;
        var box = new VBoxContainer(); AddChild(box);
        var header = new HBoxContainer(); box.AddChild(header); header.AddChild(_icon); header.AddChild(_title);
        _close = new Button { Text = "平仓", Icon = LifestyleArt.Icon("交易市场"), CustomMinimumSize = new(80, 36) };
        _close.Pressed += close; header.AddChild(_close);
        box.AddChild(_terms); box.AddChild(_profit); box.AddChild(_proceeds);
        box.AddChild(_actions);
        Button ActionButton(string title, string icon, Action action)
        {
            var button = new Button { Text = title, Icon = LifestyleArt.Icon(icon), SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 36) };
            button.Pressed += action; return button;
        }
        _actions.AddChild(ActionButton("追加保证金", "外汇", () => Edit(true)));
        _actions.AddChild(ActionButton("设置止损", "交易市场", () => Edit(false)));
        box.AddChild(_editor); _editor.AddChild(_input); _editor.AddChild(_preview);
        var buttons = new HBoxContainer(); _editor.AddChild(buttons);
        _apply = ActionButton("确认追加", "确认", Apply); buttons.AddChild(_apply);
        _clear = ActionButton("取消止损", "清除", () => Send(new("stop", Position: _position!.Id, QuoteRevision: _revision))); buttons.AddChild(_clear);
        buttons.AddChild(ActionButton("收起", "收起", () => _editor.Hide()));
        _input.ValueChanged += _ => Preview();
        foreach (var label in new[] { _title, _terms, _profit, _proceeds, _preview })
        {
            label.SizeFlagsHorizontal = SizeFlags.ExpandFill; label.AutowrapMode = TextServer.AutowrapMode.WordSmart;
            label.MouseFilter = MouseFilterEnum.Ignore; label.AddThemeFontSizeOverride("font_size", label == _title ? 18 : 15);
        }
        _terms.AddThemeColorOverride("font_color", CareerVisuals.Muted);
    }
    internal void Bind(MarketPosition? p, MarketQuote? quote, long revision = 0)
    {
        _position = p; _quote = quote; _revision = revision; _editor.Hide();
        _actions.Visible = p != null;
        _close.Visible = _icon.Visible = _terms.Visible = _profit.Visible = _proceeds.Visible = p != null;
        if (p == null) { _title.Text = "暂无持仓"; return; }
        var asset = MarketCatalog.ById[p.Asset];
        AddThemeStyleboxOverride("panel", MarketVisuals.Card(asset.Sector, false)); _icon.Texture = LifestyleArt.Icon(asset.Sector);
        _title.Text = asset.Name + $"  ·  {(p.Direction > 0 ? "做多 ↑" : "做空 ↓")}  开仓 {p.Leverage}×";
        _title.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));
        _terms.Text = $"保证金 {CareerMoney.Compact(p.Margin)}  ·  初始仓位 {CareerMoney.Compact(p.Entry * p.Units)}\n建仓价 "
            + Price(p.Entry) + " · 止损 " + (p.StopPrice is { } stop ? Price(stop) : "未设置");
        var exit = MarketExecution.Close(p, quote!); decimal profit = exit.Profit;
        _terms.MouseFilter = _profit.MouseFilter = _proceeds.MouseFilter = MouseFilterEnum.Pass;
        _terms.TooltipText = "保证金 " + CareerMoney.Format(p.Margin) + " · 初始仓位 " + CareerMoney.Format(p.Entry * p.Units);
        _profit.TooltipText = CareerMoney.Format(profit);
        _proceeds.TooltipText = "平仓手续费 " + CareerMoney.Format(exit.Fee) + " · 预计到账 " + CareerMoney.Format(exit.Proceeds);
        _profit.Text = "平仓预计净盈亏 " + (profit > 0 ? "+" : "") + CareerMoney.Compact(profit);
        _profit.AddThemeColorOverride("font_color", profit >= 0 ? CareerVisuals.Teal : new Color("f095a3"));
        _proceeds.Text = "预计成交均价 " + (asset.Forex ? exit.Fill.Average.ToString("0.00000") : CareerMoney.Compact(exit.Fill.Average))
            + "\n平仓手续费 " + CareerMoney.Compact(exit.Fee) + " · 预计到账 " + CareerMoney.Compact(exit.Proceeds);
    }
    private string Price(decimal value) => MarketCatalog.ById[_position!.Asset].Forex ? value.ToString("0.00000") : CareerMoney.Compact(value);
    private decimal DisplayScale => MarketCatalog.ById[_position!.Asset].Forex ? 1 : 10;
    private void Edit(bool margin)
    {
        if (_position == null) return;
        _margin = margin; _input.Prefix = margin || DisplayScale == 10 ? "$" : "";
        _input.Step = margin || DisplayScale == 10 ? .01 : .00001;
        _input.SetAmount(margin ? 0 : (_position.StopPrice ?? _quote!.Price) * DisplayScale);
        _apply.Text = margin ? "确认追加" : "保存止损";
        _clear.Visible = !margin && _position.StopPrice != null;
        _editor.Show(); Preview(); _input.GetLineEdit().GrabFocus();
    }
    private void Preview()
    {
        if (_position == null) return;
        if (!_margin) { _preview.Text = "当前报价 " + Price(_quote!.Price) + (_position.Direction > 0 ? "；低于此价设置止损。" : "；高于此价设置止损。") + "\n触发后按实际成交均价平仓。"; return; }
        decimal addition = _input.Amount / 10;
        var equity = CareerMarket.Equity(_position, _quote!.Price);
        string Leverage(MarketNumber funds) => funds > 0 ? (_quote.Price * _position.Units / funds).ToString("0.##") + "×" : "权益已耗尽";
        _preview.Text = "保证金 " + CareerMoney.Compact(_position.Margin) + " → " + CareerMoney.Compact(_position.Margin + addition)
            + "\n实际杠杆 " + Leverage(equity) + " → " + Leverage(equity + addition) + " · 追加免手续费";
    }
    private void Apply()
    {
        if (_position == null || !_editor.Visible) return;
        _input.Apply();
        Send(_margin ? new("margin", Amount: _input.Amount / 10, Position: _position.Id, QuoteRevision: _revision)
            : new("stop", Position: _position.Id, QuoteRevision: _revision, StopPrice: _input.Amount / DisplayScale));
    }
    private void Send(MarketOrder order) { _editor.Hide(); _submit(order); }
}
