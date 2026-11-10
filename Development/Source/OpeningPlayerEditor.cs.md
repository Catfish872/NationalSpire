# OpeningPlayerEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6FA545991BD64C346E192A1F308B7E013A73FBFB16885ADAD76A131CDF1FEA47`。来源：[源码](../../OpeningPlayerEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningPlayerEditor`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-8ef16a8054cb"></a>

## `NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?) — internal static void Draw(VBoxContainer parent,CareerOpeningPlayer player,string defaultName,string defaultCountry,string? teamCountry=null,Action<string>? countryChanged=null)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawDraft()`](NpcGenerationScreen.cs.md#symbol-d79d22cd9ca9)；[`NationalSpire.Coop.CoopScreen.Render()`](Coop/CoopScreen.cs.md#symbol-adc6058122f7)

**调用：** [`Count(string)`](OpeningPlayerEditor.cs.md#symbol-81960c693b84)；[`DrawOffers()`](OpeningPlayerEditor.cs.md#symbol-f19f33792b7e)；[`Face()`](OpeningPlayerEditor.cs.md#symbol-bfa0e310c4c5)；[`NationalSpire.CareerCommerce.BuildPersonalOffer(NationalSpire.CareerData, int, string, int, int)`](CareerCommerce.cs.md#symbol-a571f0d2f6a3)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ChooseOpeningAvatar(Godot.Control, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>)`](AvatarScreen.cs.md#symbol-8bcfc3ae05f4)；[`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`](OpeningControls.cs.md#symbol-93105b3962ff)；[`NationalSpire.OpeningControls.Field(Godot.Container, string)`](OpeningControls.cs.md#symbol-bd0e4ff57612)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；[`NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`](OpeningControls.cs.md#symbol-c7ec3402431e)；[`NationalSpire.RegionalOrganizations.SponsorCatalog()`](RegionalOrganizations.cs.md#symbol-c12ea64ac22f)；[`NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`](SponsorIncome.cs.md#symbol-9f0fa3e89b54)；[`Number(string, string, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-f2f1b5cd9779)；`decimal.ToString()`；`decimal.TryParse(string?, out decimal)`；`Godot.Button.Button()`；`Godot.ButtonGroup.ButtonGroup()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`NationalSpire.BroadcastButton.BroadcastButton()`；`NationalSpire.CareerAvatar.CareerAvatar()`；`NationalSpire.CareerData.CareerData()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `(string Country, int Sector, string Brand).Brand`；`(string Country, int Sector, string Brand).Sector`；`Count(string)`；`DrawOffers()`；`Face()`；`NationalSpire.CareerCommerce.BuildPersonalOffer(NationalSpire.CareerData, int, string, int, int)`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerOpeningPlayer.Avatar`；`NationalSpire.CareerOpeningPlayer.Biography`；`NationalSpire.CareerOpeningPlayer.Country`；`NationalSpire.CareerOpeningPlayer.Credits`；`NationalSpire.CareerOpeningPlayer.Draws`；`NationalSpire.CareerOpeningPlayer.Fans`；`NationalSpire.CareerOpeningPlayer.Gender`；`NationalSpire.CareerOpeningPlayer.Losses`；`NationalSpire.CareerOpeningPlayer.Name`；`NationalSpire.CareerOpeningPlayer.Sponsor`；`NationalSpire.CareerOpeningPlayer.Wins`；`NationalSpire.CareerScreen.ChooseOpeningAvatar(Godot.Control, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.IdentityGender.Choices`；`NationalSpire.IdentityGender.Unset`；`NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；`NationalSpire.OpeningControls.Field(Godot.Container, string)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；`NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；`NationalSpire.RegionalOrganizations.SponsorCatalog()`；`NationalSpire.SponsorContract.FanBonus`；`NationalSpire.SponsorContract.Plan`；`NationalSpire.SponsorContract.Retainer`；`NationalSpire.SponsorContract.WinBonus`；`NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`；`Number(string, string, string, System.Action<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Count(string)`；输入表达式：`Count(s)`；返回值紧邻使用处：`AssignmentExpressionSyntax: player.Draws=Count(s)`
- `Count(string)`；输入表达式：`Count(s)`；返回值紧邻使用处：`AssignmentExpressionSyntax: player.Fans=Count(s)`
- `Count(string)`；输入表达式：`Count(s)`；返回值紧邻使用处：`AssignmentExpressionSyntax: player.Losses=Count(s)`
- `Count(string)`；输入表达式：`Count(s)`；返回值紧邻使用处：`AssignmentExpressionSyntax: player.Wins=Count(s)`
- `decimal.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: player.Credits?.ToString()`
- `decimal.TryParse(string?, out decimal)`；输入表达式：`decimal.TryParse(s,out var n)`；返回值紧邻使用处：`BinaryExpressionSyntax: decimal.TryParse(s,out var n)&&n>=0`
- `DrawOffers()`；输入表达式：`DrawOffers()`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawOffers();`
- `Face()`；输入表达式：`Face()`；返回值紧邻使用处：`ExpressionStatementSyntax: Face();`
- `Godot.Button.Button()`；输入表达式：`new Button{CustomMinimumSize=new(108,108),SizeFlagsVertical=Control.SizeFlags.ShrinkCenter,AccessibilityName="选择头像",TooltipText="选择头像"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Button{CustomMinimumSize=new(108,108),SizeFlagsVertical=Control.SizeFlags.ShrinkCenter,AccessibilityName="选择头像",TooltipText="选择头像"}`
- `Godot.ButtonGroup.ButtonGroup()`；输入表达式：`new ButtonGroup()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ButtonGroup()`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`cards.AddThemeConstantOverride("h_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.AddThemeConstantOverride("h_separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`cards.AddThemeConstantOverride("v_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.AddThemeConstantOverride("v_separation",8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`dossier.AddThemeConstantOverride("separation",18)`；返回值紧邻使用处：`ExpressionStatementSyntax: dossier.AddThemeConstantOverride("separation",18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`fields.AddThemeConstantOverride("separation",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddThemeConstantOverride("separation",16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation",8);`
- `Godot.Control.Control()`；输入表达式：`new Control()`；返回值紧邻使用处：`ArgumentSyntax: new Control()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`badge.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer{Columns=3}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new GridContainer{Columns=3}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HFlowContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit{PlaceholderText="搜索品牌、赛区或赞助类型",SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LineEdit{PlaceholderText="搜索品牌、赛区或赞助类型",SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit{Text=player.Name,PlaceholderText=defaultName}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LineEdit{Text=player.Name,PlaceholderText=defaultName}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(dossier)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(dossier);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(OpeningControls.Label($"全队代表{teamCountry}参赛，外汇按{teamCountry}报价。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(OpeningControls.Label($"全队代表{teamCountry}参赛，外汇按{teamCountry}报价。"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(fields);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`dossier.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: dossier.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`dossier.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: dossier.AddChild(portrait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(new Control())`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(new Control());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`history.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: history.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(body,"人物介绍").AddChild(bio)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(body,"人物介绍").AddChild(bio);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(details,"国籍").AddChild(nations)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(details,"国籍").AddChild(nations);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(fields,"姓名").AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(fields,"姓名").AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(fields,"性别").AddChild(genders)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(fields,"性别").AddChild(genders);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pager.AddChild(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: pager.AddChild(next);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pager.AddChild(pageLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: pager.AddChild(pageLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pager.AddChild(prev)`；返回值紧邻使用处：`ExpressionStatementSyntax: pager.AddChild(prev);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portrait.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sponsor.AddChild(cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: sponsor.AddChild(cards);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sponsor.AddChild(pager)`；返回值紧邻使用处：`ExpressionStatementSyntax: sponsor.AddChild(pager);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sponsor.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: sponsor.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sponsor.AddChild(tools)`；返回值紧邻使用处：`ExpressionStatementSyntax: sponsor.AddChild(tools);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(filter)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(filter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(none)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(none);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit{Text=player.Biography,PlaceholderText="写下选手的经历、身份或希望别人知道的事",CustomMinimumSize=new(0,66),WrapMode=TextEdit.LineWrappingMode.Boundary}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new TextEdit{Text=player.Biography,PlaceholderText="写下选手的经历、身份或希望别人知道的事",CustomMinimumSize=new(0,66),WrapMode=TextEdit.LineWrappingMode.Boundary}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,66)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,66)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(108,108)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(108,108)`
- `int.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: player.Draws?.ToString()`
- `int.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: player.Fans?.ToString()`
- `int.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: player.Losses?.ToString()`
- `int.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: player.Wins?.ToString()`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text="上一页"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text="上一页"}`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text="无赞助"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text="无赞助"}`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text="下一页"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text="下一页"}`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar{MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CareerAvatar{MouseFilter=Control.MouseFilterEnum.Ignore}`
- `NationalSpire.CareerCommerce.BuildPersonalOffer(NationalSpire.CareerData, int, string, int, int)`；输入表达式：`CareerCommerce.BuildPersonalOffer(preview,o.Sector,o.Brand,1,SponsorIncome.PersonalTier(preview))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerCommerce.BuildPersonalOffer(preview,o.Sector,o.Brand,1,SponsorIncome.PersonalTier(preview))`
- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData{Fans=player.Fans??28}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CareerData{Fans=player.Fans??28}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(contract.Retainer)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(contract.Retainer)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(contract.WinBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(contract.WinBonus)}`
- `NationalSpire.CareerScreen.ChooseOpeningAvatar(Godot.Control, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>)`；输入表达式：`CareerScreen.ChooseOpeningAvatar(parent,player.Avatar,avatar=>{player.Avatar=avatar;Face();})`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>CareerScreen.ChooseOpeningAvatar(parent,player.Avatar,avatar=>{player.Avatar=avatar;Face();})`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(genders,group,gender,gender==(player.Gender.Length==0?IdentityGender.Unset:player.Gender),()=>player.Gender=gender)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(genders,group,gender,gender==(player.Gender.Length==0?IdentityGender.Unset:player.Gender),()=>player.Gender=gender);`
- `NationalSpire.OpeningControls.Chip(Godot.Container, Godot.ButtonGroup, string, bool, System.Action)`；输入表达式：`OpeningControls.Chip(nations,flags,n,n==(player.Country.Length==0?defaultCountry:player.Country),()=>{player.Country=n;countryChanged?.Invoke(n);})`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Chip(nations,flags,n,n==(player.Country.Length==0?defaultCountry:player.Country),()=>{player.Country=n;countryChanged?.Invoke(n);});`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(body,"人物介绍")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(body,"人物介绍").AddChild`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(details,"国籍")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(details,"国籍").AddChild`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(fields,"姓名")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(fields,"姓名").AddChild`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(fields,"性别")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(fields,"性别").AddChild`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("",18,CareerVisuals.Gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Label("",18,CareerVisuals.Gold)`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Label("")`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label($"全队代表{teamCountry}参赛，外汇按{teamCountry}报价。")`；返回值紧邻使用处：`ArgumentSyntax: OpeningControls.Label($"全队代表{teamCountry}参赛，外汇按{teamCountry}报价。")`
- `NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；输入表达式：`OpeningControls.Section(parent,"个人赞助","handshake","品牌与合同")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Section(parent,"个人赞助","handshake","品牌与合同")`
- `NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；输入表达式：`OpeningControls.Section(parent,"生涯起点","chart-no-axes-combined","资金 · 关注 · 战绩")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Section(parent,"生涯起点","chart-no-axes-combined","资金 · 关注 · 战绩")`
- `NationalSpire.OpeningControls.Section(Godot.Container, string, string, string, bool, Godot.Color?)`；输入表达式：`OpeningControls.Section(parent,"选手档案","contact-round","头像 · 身份 · 人物介绍",true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OpeningControls.Section(parent,"选手档案","contact-round","头像 · 身份 · 人物介绍",true)`
- `NationalSpire.RegionalOrganizations.SponsorCatalog()`；输入表达式：`RegionalOrganizations.SponsorCatalog()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RegionalOrganizations.SponsorCatalog().ToArray`
- `NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`；输入表达式：`SponsorIncome.PersonalTier(preview)`；返回值紧邻使用处：`ArgumentSyntax: SponsorIncome.PersonalTier(preview)`
- `Number(string, string, string, System.Action<string>)`；输入表达式：`Number("初始资金（美元）",player.Credits?.ToString()??"","0",s=>player.Credits=decimal.TryParse(s,out var n)&&n>=0?n:null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("初始资金（美元）",player.Credits?.ToString()??"","0",s=>player.Credits=decimal.TryParse(s,out var n)&&n>=0?n:null);`
- `Number(string, string, string, System.Action<string>)`；输入表达式：`Number("负场",player.Losses?.ToString()??"","0",s=>player.Losses=Count(s))`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("负场",player.Losses?.ToString()??"","0",s=>player.Losses=Count(s));`
- `Number(string, string, string, System.Action<string>)`；输入表达式：`Number("个人关注",player.Fans?.ToString()??"","28",s=>{player.Fans=Count(s);refreshTerms();})`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("个人关注",player.Fans?.ToString()??"","28",s=>{player.Fans=Count(s);refreshTerms();});`
- `Number(string, string, string, System.Action<string>)`；输入表达式：`Number("平局",player.Draws?.ToString()??"","0",s=>player.Draws=Count(s))`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("平局",player.Draws?.ToString()??"","0",s=>player.Draws=Count(s));`
- `Number(string, string, string, System.Action<string>)`；输入表达式：`Number("胜场",player.Wins?.ToString()??"","0",s=>player.Wins=Count(s))`；返回值紧邻使用处：`ExpressionStatementSyntax: Number("胜场",player.Wins?.ToString()??"","0",s=>player.Wins=Count(s));`
- `System.Action.Invoke()`；输入表达式：`refreshTerms()`；返回值紧邻使用处：`ExpressionStatementSyntax: refreshTerms();`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(n)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: countryChanged?.Invoke(n)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`catalog.FirstOrDefault(x=>x.Brand==player.Sponsor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =catalog.FirstOrDefault(x=>x.Brand==player.Sponsor)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`RegionalOrganizations.SponsorCatalog().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =RegionalOrganizations.SponsorCatalog().ToArray()`

**赋值（含属性/字段和局部值）：**

- `AccessibilityName` = `"选择头像"`
- `badge.OffsetBottom` = `-8`
- `badge.OffsetLeft` = `badge.OffsetTop=8`
- `badge.OffsetRight` = `badge.OffsetBottom=-8`
- `badge.OffsetTop` = `8`
- `bio.TextChanged` += `()=>player.Biography=bio.Text`
- `Columns` = `3`
- `CustomMinimumSize` = `new(0,66)`
- `CustomMinimumSize` = `new(108,108)`
- `Fans` = `player.Fans??28`
- `filter.TextChanged` += `_=>{page=0;DrawOffers();}`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `name.TextChanged` += `v=>player.Name=v`
- `next.Pressed` += `()=>{page++;DrawOffers();}`
- `none.Pressed` += `()=>{player.Sponsor="";refreshTerms();DrawOffers();}`
- `page` = `0`
- `pageLabel.HorizontalAlignment` = `HorizontalAlignment.Center`
- `pageLabel.SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `PlaceholderText` = `"搜索品牌、赛区或赞助类型"`
- `PlaceholderText` = `"写下选手的经历、身份或希望别人知道的事"`
- `PlaceholderText` = `defaultName`
- `player.Avatar` = `avatar`
- `player.Biography` = `bio.Text`
- `player.Country` = `n`
- `player.Credits` = `decimal.TryParse(s,out var n)&&n>=0?n:null`
- `player.Draws` = `Count(s)`
- `player.Fans` = `Count(s)`
- `player.Gender` = `gender`
- `player.Losses` = `Count(s)`
- `player.Name` = `v`
- `player.Sponsor` = `""`
- `player.Wins` = `Count(s)`
- `portrait.Pressed` += `()=>CareerScreen.ChooseOpeningAvatar(parent,player.Avatar,avatar=>{player.Avatar=avatar;Face();})`
- `prev.Pressed` += `()=>{page--;DrawOffers();}`
- `refreshTerms` = `()=>{              var o=catalog.FirstOrDefault(x=>x.Brand==player.Sponsor);              if(o.Brand==null){summary.Text="无赞助 · 进入生涯后仍可签约";return;}              var preview=new CareerData{Fans=player.Fans??28};              var contract=CareerCommerce.BuildPersonalOffer(preview,o.Sector,o.Brand,1,SponsorIncome.PersonalTier(preview));              summary.Text=$"{o.Brand}  ·  {contract.Plan}    基础赛季支持 {CareerMoney.Format(contract.Retainer)}  ·  胜场奖金 {CareerMoney.Format(contract.WinBonus)}"+(contract.FanBonus>0?$"  ·  关注 +{contract.FanBonus}":"");          }`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `Control.SizeFlags.ShrinkCenter`
- `summary.Text` = `"无赞助 · 进入生涯后仍可签约"`
- `summary.Text` = `$"{o.Brand}  ·  {contract.Plan}    基础赛季支持 {CareerMoney.Format(contract.Retainer)}  ·  胜场奖金 {CareerMoney.Format(contract.WinBonus)}"+(contract.FanBonus>0?$"  ·  关注 +{contract.FanBonus}":"")`
- `Text` = `"上一页"`
- `Text` = `"无赞助"`
- `Text` = `"下一页"`
- `Text` = `player.Biography`
- `Text` = `player.Name`
- `TooltipText` = `"选择头像"`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-bfa0e310c4c5"></a>

## `Face() — void Face()`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)

**调用：** [`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`](AvatarImages.cs.md#symbol-1edd50772202)；[`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)；`NationalSpire.CareerData.CareerData()`；`NationalSpire.PlayerAvatar.PlayerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`；`NationalSpire.CareerOpeningPlayer.Avatar`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(player.Avatar??new())`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(player.Avatar??new())??CareerAvatars.Automatic(new CareerData(),"player")`
- `NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.Automatic(new CareerData(),"player")`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(player.Avatar??new())??CareerAvatars.Automatic(new CareerData(),"player")`
- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData()`；返回值紧邻使用处：`ArgumentSyntax: new CareerData()`
- `NationalSpire.PlayerAvatar.PlayerAvatar()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: player.Avatar??new()`

**赋值（含属性/字段和局部值）：**

- `badge.Art` = `AvatarImages.Read(player.Avatar??new())??CareerAvatars.Automatic(new CareerData(),"player")`

<a id="symbol-f2f1b5cd9779"></a>

## `Number(string, string, string, System.Action<string>) — void Number(string title,string value,string hint,Action<string> set)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)

**调用：** [`NationalSpire.OpeningControls.Field(Godot.Container, string)`](OpeningControls.cs.md#symbol-bd0e4ff57612)；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.OpeningControls.Field(Godot.Container, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit{Text=value,PlaceholderText=hint}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LineEdit{Text=value,PlaceholderText=hint}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`OpeningControls.Field(grid,title).AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpeningControls.Field(grid,title).AddChild(input);`
- `NationalSpire.OpeningControls.Field(Godot.Container, string)`；输入表达式：`OpeningControls.Field(grid,title)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OpeningControls.Field(grid,title).AddChild`

**赋值（含属性/字段和局部值）：**

- `input.TextChanged` += `set.Invoke`
- `PlaceholderText` = `hint`
- `Text` = `value`

<a id="symbol-81960c693b84"></a>

## `Count(string) — int? Count(string s)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)

**调用：** `int.TryParse(string?, out int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(s,out var n)`；返回值紧邻使用处：`BinaryExpressionSyntax: int.TryParse(s,out var n)&&n>=0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f19f33792b7e"></a>

## `DrawOffers() — void DrawOffers()`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawOffers()`](OpeningPlayerEditor.cs.md#symbol-f19f33792b7e)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?, System.Action<string>?)`](OpeningPlayerEditor.cs.md#symbol-8ef16a8054cb)

**调用：** [`DrawOffers()`](OpeningPlayerEditor.cs.md#symbol-f19f33792b7e)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`](OpeningControls.cs.md#symbol-1a0d93051996)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `(string Country, int Sector, string Brand).Brand`；`(string Country, int Sector, string Brand).Country`；`(string Country, int Sector, string Brand).Sector`；`DrawOffers()`；`NationalSpire.CareerOpeningPlayer.Sponsor`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `DrawOffers()`；输入表达式：`DrawOffers()`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawOffers();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cards.AddChild(OpeningControls.Label("没有匹配的品牌"))`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.AddChild(OpeningControls.Label("没有匹配的品牌"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cards.AddChild(pick)`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.AddChild(pick);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,60)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,60)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton{Text=o.Brand+"  ·  "+o.Country+"\n"+types[o.Sector],CustomMinimumSize=new(0,60),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill,ToggleMode=true,ButtonPressed=player.Sponsor==o.Brand}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BroadcastButton{Text=o.Brand+"  ·  "+o.Country+"\n"+types[o.Sector],CustomMinimumSize=new(0,60),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill,ToggleMode=true,ButtonPressed=player.Sponsor==o.Brand}`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(cards)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(cards);`
- `NationalSpire.OpeningControls.Label(string, int, Godot.Color?)`；输入表达式：`OpeningControls.Label("没有匹配的品牌")`；返回值紧邻使用处：`ArgumentSyntax: OpeningControls.Label("没有匹配的品牌")`
- `string.Contains(string, System.StringComparison)`；输入表达式：`(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: o=>(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`filter.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: filter.Text.Trim()`
- `System.Action.Invoke()`；输入表达式：`refreshTerms()`；返回值紧邻使用处：`ExpressionStatementSyntax: refreshTerms();`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`matches.Skip(page*6)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matches.Skip(page*6).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`matches.Skip(page*6).Take(6)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var o in matches.Skip(page*6).Take(6)){                  var pick=new BroadcastButton{Text=o.Brand+"  ·  "+o.Country+"\n"+types[o.Sector],CustomMinimumSize=new(0,60),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill,ToggleMode=true,ButtonPressed=player.Sponsor==o.Brand};                  cards.AddChild(pick);pick.Pressed+=()=>{player.Sponsor=o.Brand;refreshTerms();DrawOffers();};              }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`catalog.Where(o=>(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =catalog.Where(o=>(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`catalog.Where(o=>(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: catalog.Where(o=>(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(page,0,pages-1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: page=Math.Clamp(page,0,pages-1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(matches.Count+5)/6)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(1,(matches.Count+5)/6)`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `player.Sponsor==o.Brand`
- `CustomMinimumSize` = `new(0,60)`
- `next.Disabled` = `page+1==pages`
- `page` = `Math.Clamp(page,0,pages-1)`
- `pageLabel.Text` = `$"{page+1} / {pages}"`
- `pick.Pressed` += `()=>{player.Sponsor=o.Brand;refreshTerms();DrawOffers();}`
- `player.Sponsor` = `o.Brand`
- `prev.Disabled` = `page==0`
- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `o.Brand+"  ·  "+o.Country+"\n"+types[o.Sector]`
- `ToggleMode` = `true`
