using Godot;

namespace NationalSpire;

/// <summary>逐句播放与输入共用一块渐变面板；动画和字速只改变本地展示。</summary>
public partial class DateSceneView : Control
{
    public TextEdit Editor { get; private set; } = null!;
    public VBoxContainer Attachments { get; private set; } = null!;
    public Button Send { get; private set; } = null!;
    public Label Status { get; private set; } = null!;
    public Action? Advance, Submit, AddAttachment, Settings, Exit, Tick, RetryStop, ReturnToEdit, Regenerate;
    public Button RegenerateButton { get; private set; } = null!;
    public Func<bool>? Blocked;
    public Func<string>? HistoryText;
    public bool HistoryOpen => _history?.Visible == true;
    public bool DialogueHidden => _interface?.Visible == false;
    public bool InputMode { get; private set; }
    public const double InstantSpeed = 300;
    public double TextSpeed { get; set; } = 75;
    private TextureRect _background = null!, _backgroundPrevious = null!, _sprite = null!;
    private ShaderMaterial _backgroundMaterial = null!;
    private ShaderMaterial _previousBackgroundMaterial = null!;
    private Texture2D? _backgroundTexture, _previousBackgroundTexture, _queuedBackgroundTexture;
    private string _backgroundId = "";
    private string _queuedBackgroundId = "";
    private float _backgroundBlend = 1;
    private Control _dialog = null!;
    private Control _interface = null!;
    private HBoxContainer _navigation = null!;
    private float _spriteScale = 1, _spriteX, _spriteY;
    private PanelContainer _nameBox = null!;
    private Control _favourHost = null!;
    private AffectionBadge _favourBadge = null!;
    private Label _relationText = null!, _relationDetail = null!;
    private int? _lastFavour;
    private double _deltaUntil;
    private string _favourDelta = "";
    private bool _showAffectionBadge = true;
    public void AffectionVisibility(bool visible)
    {
        _showAffectionBadge = visible;
        _favourHost.Visible = visible;
        Layout();
    }
    public void Relationship(PrivateRelation relation)
    {
        _favourBadge.Bind(relation);
        if (_lastFavour is int previous && previous != relation.Favour)
        { _favourDelta = $"  {relation.Favour - previous:+0;-0}"; _deltaUntil = Time.GetTicksMsec() + 3500; }
        _lastFavour = relation.Favour;
        _relationText.Text = (relation.OathConfirmed ? "誓约" : relation.SelectedBond >= 1 ? "恋人" : relation.Relationship)
            + (Time.GetTicksMsec() < _deltaUntil ? _favourDelta : "");
        _relationDetail.Text = relation.Impression;
    }
    private MarginContainer _margin = null!;
    private Gradient _glass = null!;
    private PanelContainer _history = null!;
    private RichTextLabel _historyText = null!;
    private int _historyScrollPending;
    private VBoxContainer _body = null!, _composer = null!;
    private RichTextLabel _text = null!;
    private FontVariation _lineFont = null!, _editorFont = null!, _nameFont = null!, _historyFont = null!;
    private readonly Dictionary<(ulong Font, int Size), float> _fontGaps = [];
    private Label _name = null!, _hint = null!;
    private HBoxContainer _settings = null!;
    private ScrollContainer _attachmentScroll = null!;
    private double _poll, _typing;
    private float _alpha, _targetAlpha, _jump;
    private float _jumpDuration = .28f, _jumpHeight = 9;
    private float _spriteBaseY;
    private bool _hintDismissed, _firstTypeFrame, _layingOut;
    private readonly Dictionary<ulong, float> _headRatios = [];
    private Button _waitAction = null!, _editFailure = null!;
    private static readonly Color Ink = new("eff4f6");
    private Button ActionButton(string text, Action action, string name, int width = 100)
    {
        var button = new Button { Name = name, Text = text, CustomMinimumSize = new(width, 48), FocusMode = FocusModeEnum.None };
        button.AddThemeFontSizeOverride("font_size", 18); button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("243d50", "638698", 7, 10));
        button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("38576b", "99c5ce", 7, 10)); button.Pressed += action; return button;
    }
    public override void _Ready()
    {
        Name = "DateScene"; MouseFilter = MouseFilterEnum.Stop; ZIndex = 30;
        var backdrop = new ColorRect { Name = "DateBackdrop", Color = new Color("0d1926"), MouseFilter = MouseFilterEnum.Ignore }; AddChild(backdrop); backdrop.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _backgroundPrevious = new TextureRect { Name = "DatePreviousBackground", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore };
        AddChild(_backgroundPrevious); _backgroundPrevious.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _background = new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore };
        AddChild(_background); _background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _backgroundMaterial = new ShaderMaterial { Shader = new Shader { Code = """
            shader_type canvas_item;
            uniform bool blur_on = true;
            uniform float blur_radius = 3.0;
            uniform float fade_alpha = 1.0;
            void fragment() {
                // Pyramid levels prefilter every pixel; tent reconstruction smooths level transitions.
                vec4 original = textureLod(TEXTURE, UV, 0.0);
                vec4 color = original;
                if (blur_on && blur_radius > 0.0) {
                    float level = log2(max(1.0, blur_radius));
                    vec2 step_uv = TEXTURE_PIXEL_SIZE * max(1.0, blur_radius) * 0.65;
                    vec4 sum = vec4(0.0);
                    for (int x=-1; x<=1; x++) { for (int y=-1; y<=1; y++) {
                        float weight = (x==0 ? 2.0 : 1.0) * (y==0 ? 2.0 : 1.0);
                        sum += textureLod(TEXTURE, clamp(UV+vec2(float(x),float(y))*step_uv,vec2(0.0),vec2(1.0)), level) * weight;
                    }}
                    color = mix(original, sum / 16.0, min(1.0, blur_radius));
                }
                COLOR=vec4(color.rgb,color.a*fade_alpha);
            }
            """ } }; _background.Material = _backgroundMaterial; _background.TextureFilter = TextureFilterEnum.LinearWithMipmaps;
        _previousBackgroundMaterial = new ShaderMaterial { Shader = _backgroundMaterial.Shader }; _backgroundPrevious.Material = _previousBackgroundMaterial; _backgroundPrevious.TextureFilter = TextureFilterEnum.LinearWithMipmaps;
        _sprite = new TextureRect { Name = "DateSprite", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
        AddChild(_sprite);
        _interface = new Control { Name = "DateInterface", MouseFilter = MouseFilterEnum.Ignore }; AddChild(_interface); _interface.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _dialog = new Control { Name = "DateDialogue", MouseFilter = MouseFilterEnum.Stop }; _interface.AddChild(_dialog);
        _glass = new Gradient { Offsets = [0, .05f, 1], Colors = [new Color(0,0,0,0), new Color(0,0,0,.75f), new Color(0,0,0,1)] };
        var glass = new TextureRect { Name = "DateGlass", ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, Texture = new GradientTexture2D { Width = 4, Height = 2048, FillFrom = new(.5f, 0), FillTo = new(.5f, 1),
            Gradient = _glass }, MouseFilter = MouseFilterEnum.Ignore };
        _dialog.AddChild(glass); glass.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _margin = new MarginContainer { MouseFilter = MouseFilterEnum.Pass }; _dialog.AddChild(_margin); _margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _margin.AddThemeConstantOverride("margin_top", 40); _margin.AddThemeConstantOverride("margin_bottom", 64);
        _body = new VBoxContainer { MouseFilter = MouseFilterEnum.Pass }; _body.AddThemeConstantOverride("separation", 10); _margin.AddChild(_body);
        _nameBox = new PanelContainer { Name = "DateSpeakerBox", MouseFilter = MouseFilterEnum.Ignore }; _interface.AddChild(_nameBox);
        _nameBox.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b3dd9", "63869880", 5, 12));
        _name = new Label { Name = "DateSpeaker", MouseFilter = MouseFilterEnum.Ignore }; _name.AddThemeFontSizeOverride("font_size", 31); _name.AddThemeColorOverride("font_color", new("ead09c")); _nameBox.AddChild(_name);
        _favourHost = new Control { Name = "DateFavour", MouseFilter = MouseFilterEnum.Ignore }; _interface.AddChild(_favourHost);
        var relationButton = new Button { Name = "DateRelationshipDetails", TooltipText = "查看关系与印象", MouseDefaultCursorShape = CursorShape.PointingHand };
        relationButton.AddThemeStyleboxOverride("normal", CareerVisuals.Box("182838dc", "b38ba780", 14, 0));
        relationButton.AddThemeStyleboxOverride("hover", CareerVisuals.Box("302d42ec", "e5b8cf", 14, 0));
        _favourHost.AddChild(relationButton); relationButton.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var badge = new Control { Position = new(8, 4), Size = new(80, 68), MouseFilter = MouseFilterEnum.Ignore }; _favourHost.AddChild(badge);
        _favourBadge = new AffectionBadge(); badge.AddChild(_favourBadge);
        _relationText = new Label { Name = "DateRelationship", Position = new(96, 23), Size = new(170, 30), TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseFilter = MouseFilterEnum.Ignore };
        _relationText.AddThemeColorOverride("font_color", new("f1ccdf")); _relationText.AddThemeFontSizeOverride("font_size", 19); _favourHost.AddChild(_relationText);
        _relationDetail = new Label { Name = "DateImpression", Position = new(0, 84), Size = new(280, 0), AutowrapMode = TextServer.AutowrapMode.WordSmart, Visible = false, MouseFilter = MouseFilterEnum.Ignore };
        _relationDetail.AddThemeColorOverride("font_color", new("eadce5")); _relationDetail.AddThemeConstantOverride("outline_size", 5); _favourHost.AddChild(_relationDetail);
        relationButton.Pressed += () => _relationDetail.Visible = !_relationDetail.Visible;
        _text = new RichTextLabel { Name = "DateLine", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass,
            VisibleCharactersBehavior = TextServer.VisibleCharactersBehavior.GlyphsLtr };
        _text.AddThemeFontSizeOverride("normal_font_size", 30); _text.AddThemeColorOverride("default_color", Ink); _body.AddChild(_text);
        _composer = new VBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; _composer.AddThemeConstantOverride("separation", 8); _body.AddChild(_composer);
        _attachmentScroll = new ScrollContainer { Visible = false, CustomMinimumSize = new(0, 80), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; _composer.AddChild(_attachmentScroll);
        Attachments = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _attachmentScroll.AddChild(Attachments);
        Editor = new TextEdit { Name = "DateInput", PlaceholderText = "输入回应…", SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 65), WrapMode = TextEdit.LineWrappingMode.Boundary };
        Editor.AddThemeFontSizeOverride("font_size", 30); Editor.AddThemeStyleboxOverride("normal", new StyleBoxEmpty()); Editor.AddThemeStyleboxOverride("focus", new StyleBoxEmpty()); _composer.AddChild(Editor);
        Editor.GuiInput += input => { if (input is InputEventKey { Pressed: true, Echo: false, CtrlPressed: true, Keycode: Key.Enter }) { AcceptEvent(); Submit?.Invoke(); } };
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); _composer.AddChild(actions);
        var tools = new HBoxContainer(); tools.AddThemeConstantOverride("separation", 12); actions.AddChild(tools);
        tools.AddChild(ActionButton("+", () => AddAttachment?.Invoke(), "DateAttachments", 48));
        actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        Send = ActionButton("发送", () => Submit?.Invoke(), "DateSend", 150); actions.AddChild(Send);
        Send.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 7, 10)); Send.AddThemeColorOverride("font_color", new Color("172330"));
        CommunityReplyExpressions.Attach(Editor, _composer, tools, actions);
        _hint = new Label { Name = "DateAdvanceHint", Text = "单击继续  ›", HorizontalAlignment = HorizontalAlignment.Right, MouseFilter = MouseFilterEnum.Ignore }; _hint.AddThemeColorOverride("font_color", new("b3c7cf")); _body.AddChild(_hint);
        _hintDismissed = DateSceneAssetStore.ContinueHintDismissed();
        Status = new Label { Name = "DateStatus", AutowrapMode = TextServer.AutowrapMode.WordSmart, MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore }; Status.AddThemeFontSizeOverride("font_size", 15); Status.AddThemeColorOverride("font_color", new("c1d1d8")); _body.AddChild(Status);
        _waitAction = ActionButton("停止生成", () => RetryStop?.Invoke(), "DateWaitAction", 150); _waitAction.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; _body.AddChild(_waitAction);
        _editFailure = ActionButton("编辑文字", () => ReturnToEdit?.Invoke(), "DateFailureEdit", 150); _editFailure.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; _body.AddChild(_editFailure);
        _settings = new HBoxContainer { Name = "DateHoverBar", Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Stop, Modulate = new(1,1,1,0) }; _settings.AddThemeConstantOverride("separation", 18); _interface.AddChild(_settings);
        _settings.AddChild(ActionButton("场景设置", () => Settings?.Invoke(), "DateSettings", 140));
        _navigation = new HBoxContainer { Name = "DateNavigation" }; _navigation.AddThemeConstantOverride("separation", 12); _interface.AddChild(_navigation);
        _navigation.AddChild(ActionButton("历史记录  Q", () => { if (HistoryOpen) CloseHistory(); else OpenHistory(); }, "DateHistoryButton", 145));
        _navigation.AddChild(ActionButton("退出约会  Esc", () => Exit?.Invoke(), "DateExit", 155));
        RegenerateButton = ActionButton("重新生成", () => Regenerate?.Invoke(), "DateRegenerate", 140); _settings.AddChild(RegenerateButton);
        foreach (var button in _settings.GetChildren().OfType<Button>())
        {
            foreach (string state in new[] { "normal", "hover", "pressed", "focus", "disabled" }) button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
            foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_focus_color" }) button.AddThemeColorOverride(state, Colors.White);
        }
        _history = new PanelContainer { Name = "DateHistory", Visible = false, MouseFilter = MouseFilterEnum.Stop };
        _history.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202bf5", "547787", 0, 42)); AddChild(_history); _history.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var historyBody = new VBoxContainer(); historyBody.AddThemeConstantOverride("separation", 22); _history.AddChild(historyBody);
        var historyTitle = new Label { Text = "对话记录" }; historyTitle.AddThemeFontSizeOverride("font_size", 28); historyTitle.AddThemeColorOverride("font_color", new("ead09c")); historyBody.AddChild(historyTitle);
        _historyText = new RichTextLabel { Name = "DateHistoryText", BbcodeEnabled = false, ScrollActive = true, SizeFlagsVertical = SizeFlags.ExpandFill, SelectionEnabled = true, FocusMode = FocusModeEnum.All };
        _historyText.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        _historyText.AddThemeFontSizeOverride("normal_font_size", 27); _historyText.AddThemeColorOverride("default_color", Ink); historyBody.AddChild(_historyText);
        var historyHint = new Label { Text = "滚轮 / PageUp / PageDown 浏览 · Q / 右键 / Esc 返回", HorizontalAlignment = HorizontalAlignment.Center };
        historyHint.AddThemeFontSizeOverride("font_size", 16); historyHint.AddThemeColorOverride("font_color", new("a8bcc8")); historyBody.AddChild(historyHint);
        GuiInput += Click; _dialog.GuiInput += Click;
        FontVariation SpacedFont(Control control, string key)
        {
            var font = new FontVariation { BaseFont = control.GetThemeFont(key) }; control.AddThemeFontOverride(key, font); return font;
        }
        _lineFont = SpacedFont(_text, "normal_font"); _editorFont = SpacedFont(Editor, "font");
        _nameFont = SpacedFont(_name, "font"); _historyFont = SpacedFont(_historyText, "normal_font");
        Resized += Layout; _body.MinimumSizeChanged += Layout; _name.MinimumSizeChanged += Layout;
        Preferences(1, 0); Presentation(1, 0, 0, true); ShowWaiting("正在准备场景…");
    }
    private void Click(InputEvent e)
    {
        if (HistoryOpen || DialogueHidden || InputMode || !_text.Visible || Blocked?.Invoke() == true) return;
        if (e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left })
        {
            AcceptEvent();
            if (!_hintDismissed) { _hintDismissed = true; _hint.Hide(); try { DateSceneAssetStore.DismissContinueHint(); } catch (Exception error) { Status.Text = error.Message; } }
            if (_text.VisibleCharacters >= 0 && _text.VisibleCharacters < _text.GetTotalCharacterCount()) _text.VisibleCharacters = -1; else Advance?.Invoke();
        }
    }
    public override void _Input(InputEvent e)
    {
        if (!IsVisibleInTree() || Blocked?.Invoke() == true) return;
        if (e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left } click
            && WaitingClick(GetGlobalTransformWithCanvas().AffineInverse() * click.Position))
        { GetViewport().SetInputAsHandled(); return; }
        if (e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Right } right
            && new Rect2(Vector2.Zero, Size).HasPoint(GetGlobalTransformWithCanvas().AffineInverse() * right.Position))
        {
            if (HistoryOpen) CloseHistory(); else SetDialogueVisible(DialogueHidden);
            GetViewport().SetInputAsHandled(); return;
        }
        if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Q, CtrlPressed: false, AltPressed: false, MetaPressed: false }
            && (HistoryOpen || GetViewport().GuiGetFocusOwner() is not (TextEdit or LineEdit)))
        {
            if (HistoryOpen) CloseHistory(); else OpenHistory();
            GetViewport().SetInputAsHandled(); return;
        }
        bool up = e is InputEventKey { Pressed: true, Keycode: Key.Pageup } || e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.WheelUp };
        bool down = e is InputEventKey { Pressed: true, Keycode: Key.Pagedown } || e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.WheelDown };
        if (HistoryOpen && e is InputEventKey { Pressed: true, Keycode: Key.Escape }) { CloseHistory(); GetViewport().SetInputAsHandled(); return; }
        if (!up && !down) return;
        if (e is InputEventMouseButton mouse)
        {
            if (!new Rect2(Vector2.Zero, Size).HasPoint(GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)) return;
            if (!HistoryOpen && InputMode && Editor.IsVisibleInTree()
                && new Rect2(Vector2.Zero, Editor.Size).HasPoint(Editor.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)
                && Editor.GetVScrollBar().MaxValue > Editor.GetVScrollBar().Page)
                return;
            if (!HistoryOpen && _text.IsVisibleInTree()
                && new Rect2(Vector2.Zero, _text.Size).HasPoint(_text.GetGlobalTransformWithCanvas().AffineInverse() * mouse.Position)
                && _text.GetVScrollBar().MaxValue > _text.GetVScrollBar().Page)
                return;
            if (!HistoryOpen)
                for (Node? hovered = GetViewport().GuiGetHoveredControl(); hovered != null && hovered != this; hovered = hovered.GetParent())
                    if (hovered.Name == "ReplyExpressionPanel" || hovered == _attachmentScroll) return;
        }
        if (!HistoryOpen) { if (up) { OpenHistory(); GetViewport().SetInputAsHandled(); } return; }
        GetViewport().SetInputAsHandled();
        if (_historyScrollPending > 0) return;
        var bar = _historyText.GetVScrollBar(); double bottom = Math.Max(bar.MinValue, bar.MaxValue - bar.Page);
        if (down && bar.Value >= bottom - 1) { CloseHistory(); return; }
        double distance = e is InputEventKey ? Math.Max(60, bar.Page * .85) : 70;
        bar.Value = Math.Clamp(bar.Value + (up ? -distance : distance), bar.MinValue, bottom);
    }
    private void OpenHistory()
    {
        _historyText.Text = HistoryText?.Invoke() ?? "约会开始后的对话会显示在这里。";
        _history.Show(); _historyText.GrabFocus(); _historyScrollPending = 2;
    }
    private void CloseHistory()
    {
        _history.Hide(); _historyScrollPending = 0;
        SetDialogueVisible(true);
    }
    private void SetDialogueVisible(bool visible)
    {
        _interface.Visible = visible;
        if (!visible) Editor.ReleaseFocus(); else if (InputMode) Editor.GrabFocus();
    }
    public void GoBack()
    {
        if (HistoryOpen) CloseHistory(); else Exit?.Invoke();
    }
    private void Layout()
    {
        if (_layingOut) return; _layingOut = true;
        float width = Size.X, height = Size.Y, inset = width * .055f + 34;
        foreach (string side in new[] { "left", "right" }) _margin.AddThemeConstantOverride("margin_" + side, (int)inset);
        float panelHeight = Math.Max(height * .32f, _body.GetCombinedMinimumSize().Y + 104);
        _dialog.Position = new(0, height - panelHeight); _dialog.Size = new(width, panelHeight);
        _glass.SetOffset(1, Math.Min(.99f, 15 / panelHeight));
        float badgeHeight = Math.Max(28, _name.GetCombinedMinimumSize().Y + 18);
        _favourHost.Size = new(280, 76);
        _nameBox.GetThemeStylebox("panel").ContentMarginRight = 12;
        _nameBox.Size = _nameBox.GetCombinedMinimumSize(); _nameBox.Position = new(inset - 12, _dialog.Position.Y - _nameBox.Size.Y - 8);
        _navigation.Position = new(width - 354, 22); _navigation.Size = new(320, 44);
        _favourHost.Position = new(width - 310, 90);
        _sprite.Size = new Vector2(height * .62f * 1.3f, height * .93f * 1.3f) * _spriteScale;
        var anchor = _positionAnchor ??= WaitingDefault ?? _waitingAnchor ?? _sprite.Texture;
        if (anchor != null) RememberSprite(anchor);
        float top = anchor == null ? 0 : _headRatios.GetValueOrDefault(anchor.GetInstanceId());
        _spriteBaseY = height * .4f - top * _sprite.Size.Y - 160 + _spriteY;
        _sprite.Position = new((width - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _spriteBaseY);
        _settings.Position = new(width * .25f, height * .945f); _settings.Size = new(width * .5f, Math.Max(48, height * .05f));
        _layingOut = false;
    }
    private void SetTextSpacing(FontVariation font, int size, double extra)
    {
        var source = font.BaseFont; var key = (source.GetInstanceId(), size);
        if (!_fontGaps.TryGetValue(key, out float gap))
        {
            const string sample = "约会聊天文字";
            source.GetStringSize(sample, fontSize: size);
            var server = TextServerManager.GetPrimaryInterface(); float total = 0; int count = 0;
            foreach (char character in sample)
                foreach (var rid in source.GetRids())
                {
                    if (!server.FontHasChar(rid, character)) continue;
                    long glyph = server.FontGetGlyphIndex(rid, size, character, 0);
                    float advance = server.FontGetGlyphAdvance(rid, size, glyph).X;
                    float ink = server.FontGetGlyphSize(rid, new Vector2I(size, 0), glyph).X;
                    if (advance > ink && ink > 0) { total += advance - ink; count++; }
                    break;
                }
            _fontGaps[key] = gap = count > 0 ? total / count : Math.Max(1, size * .08f);
        }
        font.SpacingGlyph = source.GetSpacing(TextServer.SpacingType.Glyph) + (int)Math.Round(gap * Math.Clamp(double.IsFinite(extra) ? extra : 1, 0, 3));
    }
    public void Preferences(int fontSize, double fade, double spacing = 1)
    {
        int offset = (Math.Clamp(fontSize, 0, 2) - 1) * 5;
        _name.AddThemeFontSizeOverride("font_size", 31 + offset); _text.AddThemeFontSizeOverride("normal_font_size", 30 + offset); Editor.AddThemeFontSizeOverride("font_size", 30 + offset);
        SetTextSpacing(_nameFont, 31 + offset, spacing); SetTextSpacing(_lineFont, 30 + offset, spacing);
        SetTextSpacing(_editorFont, 30 + offset, spacing); SetTextSpacing(_historyFont, 27 + offset, spacing);
        _text.CustomMinimumSize = new(0, _lineFont.GetHeight(30 + offset) * 3 + 8);
        float amount = (float)Math.Clamp(fade, 0, 1);
        _glass.Colors = [new Color(0,0,0,0), new Color(0,0,0,.75f * (1 - amount)), new Color(0,0,0,1 - .5f * amount)];
        _historyText.AddThemeFontSizeOverride("normal_font_size", 27 + offset); Layout();
    }
    public void Presentation(double scale, double x, double y, bool outline)
    {
        _spriteScale = (float)Math.Clamp(double.IsFinite(scale) ? scale : 1, .25, 2.5);
        _spriteX = (float)Math.Clamp(double.IsFinite(x) ? x : 0, -4096, 4096);
        _spriteY = (float)Math.Clamp(double.IsFinite(y) ? y : 0, -4096, 4096);
        _text.AddThemeConstantOverride("outline_size", outline ? 4 : 0); _text.AddThemeColorOverride("font_outline_color", Colors.Black);
        Editor.AddThemeConstantOverride("outline_size", outline ? 4 : 0); Editor.AddThemeColorOverride("font_outline_color", Colors.Black);
        Layout();
    }
    public void Background(string background, bool blur, double amount = 3)
    {
        _backgroundMaterial.SetShaderParameter("blur_on", blur);
        _previousBackgroundMaterial.SetShaderParameter("blur_on", blur);
        float radius = (float)(double.IsFinite(amount) ? Math.Clamp(amount, 0, 20) : 3);
        _backgroundMaterial.SetShaderParameter("blur_radius", radius);
        _previousBackgroundMaterial.SetShaderParameter("blur_radius", radius);
        if (_backgroundTexture != null && _backgroundId == background) { _queuedBackgroundTexture?.Dispose(); _queuedBackgroundTexture = null; _queuedBackgroundId = ""; return; }
        if (_queuedBackgroundTexture != null && _queuedBackgroundId == background) return;
        var texture = CreateBackground(background);
        if (_backgroundBlend < 1) { _queuedBackgroundTexture?.Dispose(); _queuedBackgroundTexture = texture; _queuedBackgroundId = background; }
        else BeginBackground(texture, background);
    }
    public static Texture2D CreateBackground(string background)
    {
        using var pixels = DateSceneBackgrounds.Pixels(background);
        if (pixels != null)
        {
            pixels.GenerateMipmaps();
            return ImageTexture.CreateFromImage(pixels);
        }
        using var image = Image.CreateEmpty(1, 1, false, Image.Format.Rgba8); image.Fill(new Color("0d1926"));
        return ImageTexture.CreateFromImage(image);
    }
    private void BeginBackground(Texture2D texture, string id)
    {
        _previousBackgroundTexture = _backgroundTexture; _backgroundPrevious.Texture = _previousBackgroundTexture;
        _backgroundTexture = texture; _background.Texture = texture; _backgroundId = id;
        _backgroundBlend = _previousBackgroundTexture == null ? 1 : 0; _backgroundMaterial.SetShaderParameter("fade_alpha", _backgroundBlend);
    }
    public override void _ExitTree()
    {
        _backgroundTexture?.Dispose(); _previousBackgroundTexture?.Dispose(); _queuedBackgroundTexture?.Dispose();
        _backgroundTexture = _previousBackgroundTexture = _queuedBackgroundTexture = null;
        _lineFont?.Dispose(); _editorFont?.Dispose(); _nameFont?.Dispose(); _historyFont?.Dispose();
    }
    public void ShowLine(DateSceneLine line, string speaker, Texture2D sprite)
    {
        EndWaiting();
        InputMode = false; _composer.Hide(); _waitAction.Hide(); _editFailure.Hide(); _text.Show(); _hint.Visible = !_hintDismissed; _name.Visible = _nameBox.Visible = !line.Narration; _name.Text = speaker;
        _favourHost.Visible = _showAffectionBadge;
        if (!line.Narration)
        {
            RememberSprite(sprite);
            // 从旁白返回时从透明开始；旁白期间保留上一张图完成淡出。
            if (_targetAlpha == 0) { _alpha = 0; _sprite.Modulate = new Color(1,1,1,0); }
            _sprite.Texture = sprite;
        }
        _targetAlpha = line.Narration ? 0 : 1;
        _jumpDuration = line.Emotion == "excited" ? .48f : .28f; _jumpHeight = line.Emotion == "excited" ? 23 : 9;
        _jump = line.Narration ? 0 : _jumpDuration;
        _text.Text = DateScenes.DisplayText(line); _text.ScrollToLine(0); _text.VisibleCharacters = TextSpeed >= InstantSpeed ? -1 : 0; _typing = 0; _firstTypeFrame = true; Status.Text = ""; Layout();
    }
    public void ShowInput(string name, bool keepWaiting = false)
    {
        if (!keepWaiting) EndWaiting();
        InputMode = true; _composer.Show(); _waitAction.Hide(); _editFailure.Hide(); _text.Hide(); _hint.Hide(); _name.Show(); _nameBox.Show(); _favourHost.Visible = _showAffectionBadge; _name.Text = name; Status.Text = ""; if (!HistoryOpen && !DialogueHidden) Editor.GrabFocus(); Layout();
    }
    public void AppendLine(DateSceneLine line)
    {
        string text = DateScenes.DisplayText(line);
        if (_text.Text == text) return;
        int visible = _text.VisibleCharacters;
        _text.Text = text;
        _text.VisibleCharacters = visible;
    }
    public void Streaming(bool active)
    {
        _waitAction.Visible = active; _waitAction.Text = "停止生成";
        Status.Text = active ? "正在续写…" : "";
    }
    public void ShowWaiting(string status, bool failed = false)
    { InputMode = false; _composer.Hide(); _text.Hide(); _hint.Hide(); _name.Hide(); _nameBox.Hide(); _favourHost.Visible = _showAffectionBadge; Status.Text = status; _waitAction.Show(); _editFailure.Visible = failed; _waitAction.Text = failed ? "重新生成" : "停止生成"; BeginWaiting(); }
    public void ShowAttachments() => _attachmentScroll.Visible = Attachments.GetChildCount() > 0;
    public override void _Process(double delta)
    {
        _poll += delta;
        if (_poll >= .12) { _poll = 0; Tick?.Invoke(); }
        if (_sprite == null) return;
        TickWaiting(delta);
        if (_historyScrollPending > 0 && --_historyScrollPending == 0) _historyText.GetVScrollBar().Value = _historyText.GetVScrollBar().MaxValue;
        if (HistoryOpen) return;
        if (_backgroundBlend < 1)
        {
            _backgroundBlend = Math.Min(1, _backgroundBlend + (float)delta / .45f); _backgroundMaterial.SetShaderParameter("fade_alpha", _backgroundBlend);
            if (_backgroundBlend >= 1)
            {
                _backgroundPrevious.Texture = null; _previousBackgroundTexture?.Dispose(); _previousBackgroundTexture = null;
                if (_queuedBackgroundTexture is { } queued) { string id = _queuedBackgroundId; _queuedBackgroundTexture = null; _queuedBackgroundId = ""; BeginBackground(queued, id); }
            }
        }
        _alpha = Mathf.MoveToward(_alpha, _targetAlpha, (float)delta * 4); _sprite.Modulate = new Color(1,1,1,_alpha);
        _jump = Math.Max(0, _jump - (float)delta);
        float phase = _jumpDuration > 0 ? 1 - _jump / _jumpDuration : 1;
        float bounce = _waiting ? MathF.Abs(MathF.Sin(phase * MathF.PI * (_waitingDoubleBounce ? 2 : 1)))
            : _jumpHeight > 9 ? MathF.Abs(MathF.Sin(phase * MathF.PI * 2)) * (1 - phase * .55f) : MathF.Sin(phase * MathF.PI);
        _sprite.Position = new(_sprite.Position.X, _spriteBaseY - (_jump > 0 ? bounce * _jumpHeight : 0));
        if (_firstTypeFrame) _firstTypeFrame = false;
        else if (!DialogueHidden && Blocked?.Invoke() != true && _text.Visible && _text.VisibleCharacters >= 0)
        {
            _typing += delta * TextSpeed; _text.VisibleCharacters = TextSpeed >= InstantSpeed ? -1 : Math.Min(_text.GetTotalCharacterCount(), (int)_typing);
        }
        bool hover = GetLocalMousePosition().Y >= Size.Y * .93f;
        _settings.Modulate = new Color(1,1,1,Mathf.MoveToward(_settings.Modulate.A, hover ? 1 : 0, (float)delta * 7));
    }
}

/// <summary>约会入口及公开方式共用同一套折角、信封和星芒图形。</summary>
public partial class DateChoiceButton : Button
{
    public string Caption { get; set; } = "专属约会";
    public string Subtitle { get; set; } = "";
    public bool Public { get; set; }
    public override void _Ready()
    {
        MouseDefaultCursorShape = CursorShape.PointingHand;
        foreach (string state in new[] { "normal", "hover", "pressed", "focus", "disabled" }) AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        MouseEntered += QueueRedraw; MouseExited += QueueRedraw; FocusEntered += QueueRedraw; FocusExited += QueueRedraw; Resized += QueueRedraw;
    }
    public override void _Draw()
    {
        bool large = Subtitle.Length > 0, hover = IsHovered() || HasFocus(); float w = Size.X, h = Size.Y, cut = large ? 18 : 10;
        Color accent = new(Public ? "e4c98e" : "e5b1cd");
        Vector2[] polygon = [new(cut, 1), new(w - 1, 1), new(w - 1, h - cut), new(w - cut, h - 1), new(1, h - 1), new(1, cut)];
        DrawColoredPolygon(polygon, new Color(Public ? hover ? "4d4335" : "34333a" : hover ? "52394e" : "352c42"));
        DrawPolyline([..polygon, polygon[0]], accent with { A = hover ? 1 : .65f }, 1.4f, true);
        Vector2 c = large ? new(w / 2, 40) : new(25, h / 2);
        float r = large ? 16 : 10;
        DrawPolyline([c + new Vector2(-r, -r * .6f), c + new Vector2(r, -r * .6f), c + new Vector2(r, r * .6f), c + new Vector2(-r, r * .6f), c + new Vector2(-r, -r * .6f)], accent, 1.4f, true);
        DrawPolyline([c + new Vector2(-r, -r * .6f), c + new Vector2(0, r * .15f), c + new Vector2(r, -r * .6f)], accent, 1.4f, true);
        Vector2 star = c + new Vector2(r + 7, -r);
        DrawColoredPolygon([star + new Vector2(0, -5), star + new Vector2(2, -1), star + new Vector2(5, 0), star + new Vector2(2, 1), star + new Vector2(0, 5), star + new Vector2(-2, 1), star + new Vector2(-5, 0), star + new Vector2(-2, -1)], accent);
        var font = GetThemeFont("font"); int size = large ? 23 : 18; float tw = font.GetStringSize(Caption, fontSize: size).X;
        DrawString(font, new(large ? (w - tw) / 2 : 45, large ? 88 : (h + font.GetAscent(size) - font.GetDescent(size)) / 2), Caption, fontSize: size, modulate: accent);
        if (large) DrawString(font, new(14, 121), Subtitle, HorizontalAlignment.Center, w - 28, 15, new Color("c8bccb"));
    }
}
