# CommunityReplyExpressions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`92B7AF50E3FBA5A72D7D35A6FAB1C1CA7D38A64236CBD324F585A7B472747B59`。来源：[源码](../../CommunityReplyExpressions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityReplyExpressions`。

字段、事件及初始值（源码原样）：

```csharp
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
```

<a id="symbol-c53b052266e4"></a>

## `NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?) — public static Action<bool> Attach(TextEdit editor, VBoxContainer parent, HBoxContainer actions, Control? toolbar = null)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** [`NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int)`](CommunityReplyExpressions.cs.md#symbol-8fcfa40b1631)；[`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)；[`UpdateTabs()`](CommunityReplyExpressions.cs.md#symbol-e1005af78c7c)；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int)`；`Show(bool)`；`UpdateTabs()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`kaomojiButton.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: kaomojiButton.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Hide();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("1d3040")`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor = new Color("1d3040")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`choices.AddThemeConstantOverride("h_separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddThemeConstantOverride("h_separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`choices.AddThemeConstantOverride("v_separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddThemeConstantOverride("v_separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`controls.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", new StyleBoxFlat          {              BgColor = new Color("1d3040"), CornerRadiusTopLeft = 8, CornerRadiusTopRight = 8,              CornerRadiusBottomLeft = 8, CornerRadiusBottomRight = 8,              ContentMarginLeft = 20, ContentMarginRight = 12, ContentMarginTop = 16, ContentMarginBottom = 16          })`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", new StyleBoxFlat          {              BgColor = new Color("1d3040"), CornerRadiusTopLeft = 8, CornerRadiusTopRight = 8,              CornerRadiusBottomLeft = 8, CornerRadiusBottomRight = 8,              ContentMarginLeft = 20, ContentMarginRight = 12, ContentMarginTop = 16, ContentMarginBottom = 16          });`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer { Name = "ExpressionChoices", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer { Name = "ExpressionChoices", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(emojiButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(emojiButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(kaomojiButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(kaomojiButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choiceScroll.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: choiceScroll.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(choiceScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(choiceScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(controls)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(controls);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`toolbar.GetIndex()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = toolbar.GetIndex()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`parent.MoveChild(controls, actionIndex)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.MoveChild(controls, actionIndex);`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`parent.RemoveChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.RemoveChild(toolbar);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "ReplyExpressionPanel", Visible = false, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill,              MouseFilter = Control.MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "ReplyExpressionPanel", Visible = false, SizeFlagsHorizontal = Control.SizeFlags.ExpandFill,              MouseFilter = Control.MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "ExpressionScroll", CustomMinimumSize = new(0, 88),              HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, VerticalScrollMode = ScrollContainer.ScrollMode.ShowAlways, FollowFocus = true,              MouseFilter = Control.MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { Name = "ExpressionScroll", CustomMinimumSize = new(0, 88),              HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, VerticalScrollMode = ScrollContainer.ScrollMode.ShowAlways, FollowFocus = true,              MouseFilter = Control.MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat          {              BgColor = new Color("1d3040"), CornerRadiusTopLeft = 8, CornerRadiusTopRight = 8,              CornerRadiusBottomLeft = 8, CornerRadiusBottomRight = 8,              ContentMarginLeft = 20, ContentMarginRight = 12, ContentMarginTop = 16, ContentMarginBottom = 16          }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat          {              BgColor = new Color("1d3040"), CornerRadiusTopLeft = 8, CornerRadiusTopRight = 8,              CornerRadiusBottomLeft = 8, CornerRadiusBottomRight = 8,              ContentMarginLeft = 20, ContentMarginRight = 12, ContentMarginTop = 16, ContentMarginBottom = 16          }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "ReplyExpressionControls", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "ReplyExpressionControls", SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: kaomojiButton.CustomMinimumSize = new Vector2(side, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 88)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 88)`
- `NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int)`；输入表达式：`CategoryButton("😊", "ReplyEmojiButton", 26)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CategoryButton("😊", "ReplyEmojiButton", 26)`
- `NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int)`；输入表达式：`CategoryButton("OwO", "ReplyKaomojiButton", 16)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CategoryButton("OwO", "ReplyKaomojiButton", 16)`
- `Show(bool)`；输入表达式：`Show(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Show(false)`
- `Show(bool)`；输入表达式：`Show(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Show(true)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(48, actions.Size.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(48, actions.Size.Y)`
- `UpdateTabs()`；输入表达式：`UpdateTabs()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateTabs();`

**赋值（含属性/字段和局部值）：**

- `actions.Resized` += `() =>          {              float side = Math.Max(48, actions.Size.Y);              emojiButton.CustomMinimumSize = kaomojiButton.CustomMinimumSize = new Vector2(side, 48);          }`
- `BgColor` = `new Color("1d3040")`
- `ContentMarginBottom` = `16`
- `ContentMarginLeft` = `20`
- `ContentMarginRight` = `12`
- `ContentMarginTop` = `16`
- `CornerRadiusBottomLeft` = `8`
- `CornerRadiusBottomRight` = `8`
- `CornerRadiusTopLeft` = `8`
- `CornerRadiusTopRight` = `8`
- `CustomMinimumSize` = `new(0, 88)`
- `editor.DeselectOnFocusLossEnabled` = `false`
- `emojiButton.CustomMinimumSize` = `kaomojiButton.CustomMinimumSize = new Vector2(side, 48)`
- `emojiButton.Pressed` += `() => Show(true)`
- `emojiButton.TooltipText` = `"Emoji / 颜文字；点击高亮按钮收起"`
- `enabled` = `value`
- `FollowFocus` = `true`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `kaomojiButton.CustomMinimumSize` = `new Vector2(side, 48)`
- `kaomojiButton.Pressed` += `() => Show(false)`
- `kaomojiButton.TooltipText` = `"切换到颜文字；再次点击收起"`
- `MouseFilter` = `Control.MouseFilterEnum.Stop`
- `MouseForcePassScrollEvents` = `false`
- `Name` = `"ExpressionChoices"`
- `Name` = `"ExpressionScroll"`
- `Name` = `"ReplyExpressionControls"`
- `Name` = `"ReplyExpressionPanel"`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `toolbar` ??= `actions`
- `VerticalScrollMode` = `ScrollContainer.ScrollMode.ShowAlways`
- `Visible` = `false`

<a id="symbol-e1005af78c7c"></a>

## `UpdateTabs() — void UpdateTabs()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Hide()`](CommunityReplyExpressions.cs.md#symbol-6f59269314da)；[`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)；[`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`emojiButton.SetPressedNoSignal(panel.Visible && emoji)`；返回值紧邻使用处：`ExpressionStatementSyntax: emojiButton.SetPressedNoSignal(panel.Visible && emoji);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`kaomojiButton.SetPressedNoSignal(panel.Visible && !emoji)`；返回值紧邻使用处：`ExpressionStatementSyntax: kaomojiButton.SetPressedNoSignal(panel.Visible && !emoji);`

**赋值（含属性/字段和局部值）：**

- `emojiButton.Visible` = `enabled`
- `kaomojiButton.Visible` = `enabled && panel.Visible`

<a id="symbol-6f59269314da"></a>

## `Hide() — void Hide()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)

**调用：** [`UpdateTabs()`](CommunityReplyExpressions.cs.md#symbol-e1005af78c7c)；`Godot.CanvasItem.Hide()`；`Godot.Control.GrabFocus()`

**字段、属性、事件及方法组引用：** `UpdateTabs()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Hide();`
- `Godot.Control.GrabFocus()`；输入表达式：`editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.GrabFocus();`
- `UpdateTabs()`；输入表达式：`UpdateTabs()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateTabs();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d55dc57a17c6"></a>

## `Insert(string) — void Insert(string value)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)

**调用：** `Godot.Control.GrabFocus()`；`Godot.TextEdit.InsertTextAtCaret(string, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.GrabFocus();`
- `Godot.TextEdit.InsertTextAtCaret(string, int)`；输入表达式：`editor.InsertTextAtCaret(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.InsertTextAtCaret(value);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-489af2991a0b"></a>

## `RevealAsync(Godot.Button, int) — async Task RevealAsync(Button first, int version)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)

**调用：** `Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetParent()`；`Godot.Node.GetTree()`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`panel.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !panel.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`first.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: first.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(panel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(panel)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`panel.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !GodotObject.IsInstanceValid(panel) || !panel.IsVisibleInTree() || panel.IsQueuedForDeletion()`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`panel.ToSignal(tree, SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await panel.ToSignal(tree, SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetParent()`；输入表达式：`ancestor.GetParent()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ancestor = ancestor.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`panel.GetParent()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = panel.GetParent()`
- `Godot.Node.GetTree()`；输入表达式：`panel.GetTree()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = panel.GetTree()`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`scroll.EnsureControlVisible(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.EnsureControlVisible(actions);`

**赋值（含属性/字段和局部值）：**

- `ancestor` = `ancestor.GetParent()`

<a id="symbol-5bada39e1ed4"></a>

## `Show(bool) — void Show(bool showEmoji)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)

**调用：** [`Hide()`](CommunityReplyExpressions.cs.md#symbol-6f59269314da)；[`Insert(string)`](CommunityReplyExpressions.cs.md#symbol-d55dc57a17c6)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.CommunityReplyExpressions.ExpressionButton(string, string, bool)`](CommunityReplyExpressions.cs.md#symbol-720c69a41581)；[`RevealAsync(Godot.Button, int)`](CommunityReplyExpressions.cs.md#symbol-489af2991a0b)；[`UpdateTabs()`](CommunityReplyExpressions.cs.md#symbol-e1005af78c7c)；`Godot.CanvasItem.Show()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `(string Text, string Label).Label`；`(string Text, string Label).Text`；`Hide()`；`Insert(string)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CommunityReplyExpressions.Emoji`；`NationalSpire.CommunityReplyExpressions.ExpressionButton(string, string, bool)`；`NationalSpire.CommunityReplyExpressions.Kaomoji`；`RevealAsync(Godot.Button, int)`；`UpdateTabs()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`panel.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Show();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(option)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(option);`
- `Hide()`；输入表达式：`Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: Hide();`
- `Insert(string)`；输入表达式：`Insert(value)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Insert(value)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(choices);`
- `NationalSpire.CommunityReplyExpressions.ExpressionButton(string, string, bool)`；输入表达式：`ExpressionButton(value, (emoji ? "ReplyEmoji_" : "ReplyKaomoji_") + i, emoji)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExpressionButton(value, (emoji ? "ReplyEmoji_" : "ReplyKaomoji_") + i, emoji)`
- `RevealAsync(Godot.Button, int)`；输入表达式：`RevealAsync(first!, ++request)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RevealAsync(first!, ++request)`
- `UpdateTabs()`；输入表达式：`UpdateTabs()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateTabs();`

**赋值（含属性/字段和局部值）：**

- `_` = `RevealAsync(first!, ++request)`
- `choiceScroll.ScrollVertical` = `0`
- `emoji` = `showEmoji`
- `first` ??= `option`
- `option.Pressed` += `() => Insert(value)`
- `option.TooltipText` = `emoji ? Emoji[i].Label : value`

<a id="symbol-8fcfa40b1631"></a>

## `NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int) — private static Button CategoryButton(string text, string name, int fontSize)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Button.Button()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = name, Text = text, Alignment = HorizontalAlignment.Center,              ToggleMode = true, CustomMinimumSize = new Vector2(48, 48),              SizeFlagsVertical = Control.SizeFlags.Fill, MouseDefaultCursorShape = Control.CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = name, Text = text, Alignment = HorizontalAlignment.Center,              ToggleMode = true, CustomMinimumSize = new Vector2(48, 48),              SizeFlagsVertical = Control.SizeFlags.Fill, MouseDefaultCursorShape = Control.CursorShape.PointingHand }`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", fontSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", fontSize);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, style);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(48, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(48, 48)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill, border, 8, 5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box(fill, border, 8, 5)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Center`
- `CustomMinimumSize` = `new Vector2(48, 48)`
- `MouseDefaultCursorShape` = `Control.CursorShape.PointingHand`
- `Name` = `name`
- `SizeFlagsVertical` = `Control.SizeFlags.Fill`
- `style.ContentMarginBottom` = `1.5f`
- `style.ContentMarginLeft` = `5.5f`
- `style.ContentMarginRight` = `4.5f`
- `style.ContentMarginTop` = `8.5f`
- `Text` = `text`
- `ToggleMode` = `true`

<a id="symbol-720c69a41581"></a>

## `NationalSpire.CommunityReplyExpressions.ExpressionButton(string, string, bool) — private static Button ExpressionButton(string text, string name, bool emoji)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)

**调用：** `Godot.Button.Button()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = name, Text = text, CustomMinimumSize = new Vector2(emoji ? 42 : 0, 40),              SizeFlagsVertical = Control.SizeFlags.ShrinkCenter, MouseDefaultCursorShape = Control.CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = name, Text = text, CustomMinimumSize = new Vector2(emoji ? 42 : 0, 40),              SizeFlagsVertical = Control.SizeFlags.ShrinkCenter, MouseDefaultCursorShape = Control.CursorShape.PointingHand }`
- `Godot.Color.Color(string)`；输入表达式：`new Color("142332")`；返回值紧邻使用处：`ArgumentSyntax: new Color("142332")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(emoji ? emojiFill : kaomojiFill)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor = new Color(emoji ? emojiFill : kaomojiFill)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state, new Color("142332"))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state, new Color("142332"));`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", emoji ? 24 : 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", emoji ? 24 : 17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, new StyleBoxFlat              {                  BgColor = new Color(emoji ? emojiFill : kaomojiFill),                  CornerRadiusTopLeft = 6, CornerRadiusTopRight = 6, CornerRadiusBottomLeft = 6, CornerRadiusBottomRight = 6,                  ContentMarginLeft = 6, ContentMarginRight = 6, ContentMarginTop = 2, ContentMarginBottom = 2              })`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, new StyleBoxFlat              {                  BgColor = new Color(emoji ? emojiFill : kaomojiFill),                  CornerRadiusTopLeft = 6, CornerRadiusTopRight = 6, CornerRadiusBottomLeft = 6, CornerRadiusBottomRight = 6,                  ContentMarginLeft = 6, ContentMarginRight = 6, ContentMarginTop = 2, ContentMarginBottom = 2              });`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat              {                  BgColor = new Color(emoji ? emojiFill : kaomojiFill),                  CornerRadiusTopLeft = 6, CornerRadiusTopRight = 6, CornerRadiusBottomLeft = 6, CornerRadiusBottomRight = 6,                  ContentMarginLeft = 6, ContentMarginRight = 6, ContentMarginTop = 2, ContentMarginBottom = 2              }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat              {                  BgColor = new Color(emoji ? emojiFill : kaomojiFill),                  CornerRadiusTopLeft = 6, CornerRadiusTopRight = 6, CornerRadiusBottomLeft = 6, CornerRadiusBottomRight = 6,                  ContentMarginLeft = 6, ContentMarginRight = 6, ContentMarginTop = 2, ContentMarginBottom = 2              }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(emoji ? 42 : 0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(emoji ? 42 : 0, 40)`

**赋值（含属性/字段和局部值）：**

- `BgColor` = `new Color(emoji ? emojiFill : kaomojiFill)`
- `ContentMarginBottom` = `2`
- `ContentMarginLeft` = `6`
- `ContentMarginRight` = `6`
- `ContentMarginTop` = `2`
- `CornerRadiusBottomLeft` = `6`
- `CornerRadiusBottomRight` = `6`
- `CornerRadiusTopLeft` = `6`
- `CornerRadiusTopRight` = `6`
- `CustomMinimumSize` = `new Vector2(emoji ? 42 : 0, 40)`
- `MouseDefaultCursorShape` = `Control.CursorShape.PointingHand`
- `Name` = `name`
- `SizeFlagsVertical` = `Control.SizeFlags.ShrinkCenter`
- `Text` = `text`
