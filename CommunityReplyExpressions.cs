using Godot;

namespace NationalSpire;

/// <summary>社区回复与私信共用的 Unicode 表情选择器，插入沿用 TextEdit 的光标与撤销操作。</summary>
internal static class CommunityReplyExpressions
{
    private static readonly (string Text, string Label)[] Emoji =
    [
        ("😀", "开心"), ("😄", "大笑"), ("😂", "笑哭"), ("😊", "微笑"),
        ("😍", "喜欢"), ("😎", "酷"), ("🤔", "思考"), ("😮", "惊讶"),
        ("😢", "难过"), ("😭", "大哭"), ("😡", "生气"), ("😅", "冒汗"),
        ("👍", "赞"), ("👎", "踩"), ("👏", "鼓掌"), ("🙏", "感谢"),
        ("💪", "加油"), ("🎉", "庆祝"), ("❤️", "爱心"), ("🔥", "火热"),
        ("✨", "闪耀"), ("💯", "满分"), ("👀", "关注"), ("🤝", "握手"),
        ("💀", "骷髅"), ("🙃", "倒脸"), ("😉", "眨眼"), ("🥰", "喜爱"),
        ("😘", "飞吻"), ("😋", "美味"), ("🤣", "笑翻"), ("🥲", "含泪微笑"),
        ("🥹", "感动"), ("😴", "睡觉"), ("🤯", "震惊"), ("😱", "惊恐"),
        ("🤡", "小丑"), ("🤷", "摊手"), ("🤦", "捂脸"), ("🫡", "敬礼"),
        ("😆", "笑眯眼"), ("😇", "天使"), ("😏", "得意"), ("😤", "哼"), ("😔", "失落"),
        ("😬", "尴尬"), ("🤫", "嘘"), ("🤗", "抱抱"), ("🥳", "派对"), ("✅", "完成")
    ];
    private static readonly string[] Kaomoji =
    [
        "(＾▽＾)", "(≧▽≦)", "(＾ω＾)ノ", "(๑•ω•๑)",
        "(￣▽￣)", "(づ｡◕‿‿◕｡)づ", "(╯°□°）╯︵ ┻━┻", "¯\\_(ツ)_/¯",
        "(T_T)", "(；´д｀)", "(・_・;)", "(⊙_⊙)",
        "(¬_¬)", "(｡･ω･｡)", "(ง •_•)ง", "(￣^￣)ゞ",
        "(＾▽＾)ノ", "(≧ω≦)", "(づ￣ ³￣)づ", "ヾ(≧▽≦*)o", "(￣▽￣)ノ",
        "(oﾟvﾟ)ノ", "(｡>﹏<｡)", "(╥﹏╥)", "(；￣Д￣)", "Σ(°△°|||)",
        "(≧﹏≦)", "(¬‿¬)", "(￣o￣) . z Z", "┬─┬ノ( º _ ºノ)", "(☞ﾟヮﾟ)☞",
        "(^_^)v", "(≧∇≦)ﾉ", "(o^^o)", "( ´▽｀)", "(￣ε￣)",
        "(>_<)", "(；ω；)", "(｀・ω・´)", "( ˘ω˘ )", "m(_ _)m"
    ];

    public static Action<bool> Attach(TextEdit editor, VBoxContainer parent, HBoxContainer actions, Control? toolbar = null, Action? promptSettings = null)
    {
        // 工具栏和选择项使用键盘焦点时，保留原文字选区供插入操作替换。
        editor.DeselectOnFocusLossEnabled = false;
        toolbar ??= actions;
        int actionIndex = toolbar.GetIndex(); parent.RemoveChild(toolbar);
        var controls = new VBoxContainer { Name = "ReplyExpressionControls", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
        controls.AddThemeConstantOverride("separation", 8);
        parent.AddChild(controls); parent.MoveChild(controls, actionIndex);
        var panel = new PanelContainer { Name = "ReplyExpressionPanel", Visible = false, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill,
            MouseFilter = Control.MouseFilterEnum.Stop, MouseForcePassScrollEvents = false };
        panel.AddThemeStyleboxOverride("panel", new StyleBoxFlat
        {
            BgColor = new Color("1d3040"), CornerRadiusTopLeft = 8, CornerRadiusTopRight = 8,
            CornerRadiusBottomLeft = 8, CornerRadiusBottomRight = 8,
            ContentMarginLeft = 20, ContentMarginRight = 12, ContentMarginTop = 16, ContentMarginBottom = 16
        });
        controls.AddChild(panel); controls.AddChild(toolbar);
        var choices = new HFlowContainer { Name = "ExpressionChoices", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
        choices.AddThemeConstantOverride("h_separation", 8); choices.AddThemeConstantOverride("v_separation", 8);
        var choiceScroll = new ScrollContainer { Name = "ExpressionScroll", CustomMinimumSize = new(0, 88),
            HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, VerticalScrollMode = ScrollContainer.ScrollMode.ShowAlways, FollowFocus = true,
            MouseFilter = Control.MouseFilterEnum.Stop, MouseForcePassScrollEvents = false };
        panel.AddChild(choiceScroll); choiceScroll.AddChild(choices);
        var emojiButton = CategoryButton("😊", "ReplyEmojiButton", 26);
        var kaomojiButton = CategoryButton("OwO", "ReplyKaomojiButton", 16);
        var promptButton = CategoryButton("", "ReplyPromptButton", 26);
        promptButton.Icon = AffectionArt.Texture("prompt-insert"); promptButton.IconAlignment = HorizontalAlignment.Center;
        promptButton.ToggleMode = false; promptButton.TooltipText = "提示词插入"; promptButton.Visible = promptSettings != null;
        promptButton.Pressed += () => promptSettings?.Invoke();
        kaomojiButton.Hide();
        // 跟随同一操作行的实际高度，保持正方形入口和发布、收起按钮上下对齐。
        actions.Resized += () =>
        {
            float side = Math.Max(48, actions.Size.Y);
            emojiButton.CustomMinimumSize = kaomojiButton.CustomMinimumSize = promptButton.CustomMinimumSize = new Vector2(side, 48);
        };
        bool emoji = true, enabled = true; int request = 0;

        void UpdateTabs()
        {
            emojiButton.SetPressedNoSignal(panel.Visible && emoji);
            kaomojiButton.SetPressedNoSignal(panel.Visible && !emoji);
            emojiButton.Visible = enabled;
            kaomojiButton.Visible = enabled && panel.Visible;
            promptButton.Visible = enabled && !panel.Visible && promptSettings != null;
        }
        void Hide()
        {
            request++; panel.Hide(); UpdateTabs(); editor.GrabFocus();
        }
        void Insert(string value)
        {
            request++; editor.InsertTextAtCaret(value); editor.GrabFocus();
        }
        async Task RevealAsync(Button first, int version)
        {
            var tree = panel.GetTree();
            for (int i = 0; i < 2; i++)
            {
                await panel.ToSignal(tree, SceneTree.SignalName.ProcessFrame);
                if (!GodotObject.IsInstanceValid(panel) || !panel.IsVisibleInTree() || panel.IsQueuedForDeletion() || version != request) return;
            }
            for (Node? ancestor = panel.GetParent(); ancestor != null; ancestor = ancestor.GetParent())
                if (ancestor is ScrollContainer scroll) { scroll.EnsureControlVisible(actions); break; }
            first.GrabFocus();
        }
        void Show(bool showEmoji)
        {
            if (panel.Visible && emoji == showEmoji) { Hide(); return; }
            emoji = showEmoji;
            CareerVisuals.ClearContent(choices);
            Button? first = null;
            int count = emoji ? Emoji.Length : Kaomoji.Length;
            for (int i = 0; i < count; i++)
            {
                string value = emoji ? Emoji[i].Text : Kaomoji[i];
                var option = ExpressionButton(value, (emoji ? "ReplyEmoji_" : "ReplyKaomoji_") + i, emoji);
                option.TooltipText = emoji ? Emoji[i].Label : value;
                option.Pressed += () => Insert(value); choices.AddChild(option); first ??= option;
            }
            choiceScroll.ScrollVertical = 0; panel.Show(); UpdateTabs(); _ = RevealAsync(first!, ++request);
        }

        emojiButton.TooltipText = "Emoji / 颜文字；点击高亮按钮收起";
        emojiButton.Pressed += () => Show(true); actions.AddChild(emojiButton);
        kaomojiButton.TooltipText = "切换到颜文字；再次点击收起";
        kaomojiButton.Pressed += () => Show(false); actions.AddChild(kaomojiButton);
        actions.AddChild(promptButton);
        // 私信/群聊共用编辑器时按当前模式切换入口；隐藏同时取消待执行的聚焦。
        return value => { enabled = value; if (!enabled) { request++; panel.Hide(); } UpdateTabs(); };
    }

    private static Button CategoryButton(string text, string name, int fontSize)
    {
        var button = new Button { Name = name, Text = text, Alignment = HorizontalAlignment.Center,
            ToggleMode = true, CustomMinimumSize = new Vector2(48, 48),
            SizeFlagsVertical = Control.SizeFlags.Fill, MouseDefaultCursorShape = Control.CursorShape.PointingHand };
        button.AddThemeFontSizeOverride("font_size", fontSize);
        foreach (var (state, fill, border) in new[]
        {
            ("normal", "1d3040", "395365"), ("hover", "28495a", "70d4bc"),
            ("pressed", "35645e", "80e7db"), ("hover_pressed", "40766e", "a6f4e9"),
            ("focus", "00000000", "789aa4")
        })
        {
            var style = CareerVisuals.Box(fill, border, 8, 5);
            if (text == "😊")
            {
                // 补偿彩色笑脸字形相对字体行框的侧距和基线差，保持总内边距。
                style.ContentMarginLeft = 5.5f; style.ContentMarginRight = 4.5f;
                style.ContentMarginTop = 8.5f; style.ContentMarginBottom = 1.5f;
            }
            button.AddThemeStyleboxOverride(state, style);
        }
        return button;
    }

    private static Button ExpressionButton(string text, string name, bool emoji)
    {
        var button = new Button { Name = name, Text = text, CustomMinimumSize = new Vector2(emoji ? 42 : 0, 40),
            SizeFlagsVertical = Control.SizeFlags.ShrinkCenter, MouseDefaultCursorShape = Control.CursorShape.PointingHand };
        button.AddThemeFontSizeOverride("font_size", emoji ? 24 : 17);
        foreach (var (state, emojiFill, kaomojiFill) in new[]
        {
            ("normal", "00000000", "b8cfdf"), ("hover", "ffffff14", "c9dfeb"),
            ("pressed", "80e7db33", "9ebfd1"), ("focus", "80e7db33", "80b9df33")
        })
        {
            button.AddThemeStyleboxOverride(state, new StyleBoxFlat
            {
                BgColor = new Color(emoji ? emojiFill : kaomojiFill),
                CornerRadiusTopLeft = 6, CornerRadiusTopRight = 6, CornerRadiusBottomLeft = 6, CornerRadiusBottomRight = 6,
                ContentMarginLeft = 6, ContentMarginRight = 6, ContentMarginTop = 2, ContentMarginBottom = 2
            });
        }
        if (!emoji)
            foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_focus_color" })
                button.AddThemeColorOverride(state, new Color("142332"));
        return button;
    }
}
