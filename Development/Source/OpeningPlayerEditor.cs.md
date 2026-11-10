# OpeningPlayerEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6666C8A5439CE294653F1C2007C59433B58424894BDB8DC8ED85EA3A1458D7FC`。来源：[源码](../../OpeningPlayerEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OpeningPlayerEditor`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-1e898e8feeab"></a>

## `NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?) — internal static void Draw(VBoxContainer parent, CareerOpeningPlayer player, string defaultName, string defaultCountry, string? teamCountry = null)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawDraft()`](NpcGenerationScreen.cs.md#symbol-d8cd8d2dd3cc)；[`NationalSpire.Coop.CoopScreen.Render()`](Coop/CoopScreen.cs.md#symbol-adc6058122f7)

**调用：** [`Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-74f5096742ca)；[`Count(string, int?, System.Action<int?>)`](OpeningPlayerEditor.cs.md#symbol-b1740a72a851)；[`Field(string)`](OpeningPlayerEditor.cs.md#symbol-0b7e8b91498c)；[`Input(string, string, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-093f6543ff84)；[`NationalSpire.AvatarImages.FromFile(string)`](AvatarImages.cs.md#symbol-2455dc6874f9)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.RegionalOrganizations.SponsorCatalog()`](RegionalOrganizations.cs.md#symbol-c12ea64ac22f)；`decimal.ToString()`；`decimal.TryParse(string?, out decimal)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.FileDialog.FileDialog()`；`Godot.GridContainer.GridContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Window.PopupCenteredRatio(float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`NationalSpire.BroadcastPanel.BroadcastPanel()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string Country, int Sector, string Brand).Brand`；`Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>)`；`Count(string, int?, System.Action<int?>)`；`Field(string)`；`Input(string, string, string, System.Action<string>)`；`NationalSpire.AvatarImages.FromFile(string)`；`NationalSpire.BroadcastPanel.Accent`；`NationalSpire.CareerOpeningPlayer.Avatar`；`NationalSpire.CareerOpeningPlayer.Biography`；`NationalSpire.CareerOpeningPlayer.Country`；`NationalSpire.CareerOpeningPlayer.Credits`；`NationalSpire.CareerOpeningPlayer.Draws`；`NationalSpire.CareerOpeningPlayer.Gender`；`NationalSpire.CareerOpeningPlayer.Losses`；`NationalSpire.CareerOpeningPlayer.Name`；`NationalSpire.CareerOpeningPlayer.Sponsor`；`NationalSpire.CareerOpeningPlayer.Wins`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.IdentityGender.Choices`；`NationalSpire.IdentityGender.Unset`；`NationalSpire.PlayerAvatar.Label`；`NationalSpire.RegionalOrganizations.SponsorCatalog()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>)`；输入表达式：`Choose("个人赞助","无赞助",RegionalOrganizations.SponsorCatalog().Select(s=>s.Brand),player.Sponsor,v=>player.Sponsor=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choose("个人赞助","无赞助",RegionalOrganizations.SponsorCatalog().Select(s=>s.Brand),player.Sponsor,v=>player.Sponsor=v);`
- `Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>)`；输入表达式：`Choose("国籍","沿用 "+defaultCountry, EsportsWorld.Countries,player.Country,v=>player.Country=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choose("国籍","沿用 "+defaultCountry, EsportsWorld.Countries,player.Country,v=>player.Country=v);`
- `Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>)`；输入表达式：`Choose("性别","沿用默认", IdentityGender.Choices.Where(s=>s!=IdentityGender.Unset),player.Gender,v=>player.Gender=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choose("性别","沿用默认", IdentityGender.Choices.Where(s=>s!=IdentityGender.Unset),player.Gender,v=>player.Gender=v);`
- `Count(string, int?, System.Action<int?>)`；输入表达式：`Count("负场",player.Losses,v=>player.Losses=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Count("负场",player.Losses,v=>player.Losses=v);`
- `Count(string, int?, System.Action<int?>)`；输入表达式：`Count("平局",player.Draws,v=>player.Draws=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Count("平局",player.Draws,v=>player.Draws=v);`
- `Count(string, int?, System.Action<int?>)`；输入表达式：`Count("胜场",player.Wins,v=>player.Wins=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Count("胜场",player.Wins,v=>player.Wins=v);`
- `decimal.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: player.Credits?.ToString()`
- `decimal.TryParse(string?, out decimal)`；输入表达式：`decimal.TryParse(s,out var n)`；返回值紧邻使用处：`BinaryExpressionSyntax: decimal.TryParse(s,out var n) && n>=0`
- `Field(string)`；输入表达式：`Field("头像")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field("头像").AddChild`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`title.AddThemeColorOverride("font_color", CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeColorOverride("font_color", CareerVisuals.Gold);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation",8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152633","365565",10,16))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152633","365565",10,16));`
- `Godot.FileDialog.FileDialog()`；输入表达式：`new FileDialog { FileMode=FileDialog.FileModeEnum.OpenFile, Access=FileDialog.AccessEnum.Filesystem, Filters=["*.png,*.jpg,*.jpeg,*.webp ; 人物头像"] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new FileDialog { FileMode=FileDialog.FileModeEnum.OpenFile, Access=FileDialog.AccessEnum.Filesystem, Filters=["*.png,*.jpg,*.jpeg,*.webp ; 人物头像"] }`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 3 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 3 }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "选手档案" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "选手档案" }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = $"全队代表{teamCountry}参赛。外汇也按全队参赛国报价。" }`；返回值紧邻使用处：`ArgumentSyntax: new Label { Text = $"全队代表{teamCountry}参赛。外汇也按全队参赛国报价。" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(biography)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(biography);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(new Label { Text = $"全队代表{teamCountry}参赛。外汇也按全队参赛国报价。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(new Label { Text = $"全队代表{teamCountry}参赛。外汇也按全队参赛国报价。" });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field("头像").AddChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("头像").AddChild(avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.Node.QueueFree()`；输入表达式：`picker.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.QueueFree();`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = player.Biography, PlaceholderText="人物介绍 · 写下希望其他人知道的经历", CustomMinimumSize=new(0,78), WrapMode=TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = player.Biography, PlaceholderText="人物介绍 · 写下希望其他人知道的经历", CustomMinimumSize=new(0,78), WrapMode=TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,78)`
- `Godot.Window.PopupCenteredRatio(float)`；输入表达式：`picker.PopupCenteredRatio(.7f)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.PopupCenteredRatio(.7f);`
- `Input(string, string, string, System.Action<string>)`；输入表达式：`Input("初始资金（美元）",player.Credits?.ToString() ?? "","沿用默认",s=>player.Credits=decimal.TryParse(s,out var n) && n>=0 ? n : null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Input("初始资金（美元）",player.Credits?.ToString() ?? "","沿用默认",s=>player.Credits=decimal.TryParse(s,out var n) && n>=0 ? n : null);`
- `Input(string, string, string, System.Action<string>)`；输入表达式：`Input("姓名",player.Name,defaultName,v=>player.Name=v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Input("姓名",player.Name,defaultName,v=>player.Name=v);`
- `NationalSpire.AvatarImages.FromFile(string)`；输入表达式：`AvatarImages.FromFile(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: player.Avatar=AvatarImages.FromFile(path)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { Text=player.Avatar?.Label ?? "选择头像", CustomMinimumSize=new(0,42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { Text=player.Avatar?.Label ?? "选择头像", CustomMinimumSize=new(0,42) }`
- `NationalSpire.BroadcastPanel.BroadcastPanel()`；输入表达式：`new BroadcastPanel { Accent = CareerVisuals.Teal }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastPanel { Accent = CareerVisuals.Teal }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152633","365565",10,16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("152633","365565",10,16)`
- `NationalSpire.RegionalOrganizations.SponsorCatalog()`；输入表达式：`RegionalOrganizations.SponsorCatalog()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RegionalOrganizations.SponsorCatalog().Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`RegionalOrganizations.SponsorCatalog().Select(s=>s.Brand)`；返回值紧邻使用处：`ArgumentSyntax: RegionalOrganizations.SponsorCatalog().Select(s=>s.Brand)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`IdentityGender.Choices.Where(s=>s!=IdentityGender.Unset)`；返回值紧邻使用处：`ArgumentSyntax: IdentityGender.Choices.Where(s=>s!=IdentityGender.Unset)`

**赋值（含属性/字段和局部值）：**

- `Accent` = `CareerVisuals.Teal`
- `Access` = `FileDialog.AccessEnum.Filesystem`
- `avatar.Pressed` += `() => {             var picker=new FileDialog { FileMode=FileDialog.FileModeEnum.OpenFile, Access=FileDialog.AccessEnum.Filesystem, Filters=["*.png,*.jpg,*.jpeg,*.webp ; 人物头像"] };             body.AddChild(picker); picker.FileSelected += path => { try { player.Avatar=AvatarImages.FromFile(path); avatar.Text=player.Avatar.Label; } catch(Exception e){avatar.Text=e.Message;} picker.QueueFree(); };             picker.Canceled += picker.QueueFree; picker.PopupCenteredRatio(.7f);         }`
- `avatar.Text` = `e.Message`
- `avatar.Text` = `player.Avatar.Label`
- `biography.TextChanged` += `() => player.Biography=biography.Text`
- `Columns` = `3`
- `CustomMinimumSize` = `new(0,42)`
- `CustomMinimumSize` = `new(0,78)`
- `FileMode` = `FileDialog.FileModeEnum.OpenFile`
- `Filters` = `["*.png,*.jpg,*.jpeg,*.webp ; 人物头像"]`
- `picker.Canceled` += `picker.QueueFree`
- `picker.FileSelected` += `path => { try { player.Avatar=AvatarImages.FromFile(path); avatar.Text=player.Avatar.Label; } catch(Exception e){avatar.Text=e.Message;} picker.QueueFree(); }`
- `PlaceholderText` = `"人物介绍 · 写下希望其他人知道的经历"`
- `player.Avatar` = `AvatarImages.FromFile(path)`
- `player.Biography` = `biography.Text`
- `player.Country` = `v`
- `player.Credits` = `decimal.TryParse(s,out var n) && n>=0 ? n : null`
- `player.Draws` = `v`
- `player.Gender` = `v`
- `player.Losses` = `v`
- `player.Name` = `v`
- `player.Sponsor` = `v`
- `player.Wins` = `v`
- `Text` = `"选手档案"`
- `Text` = `$"全队代表{teamCountry}参赛。外汇也按全队参赛国报价。"`
- `Text` = `player.Avatar?.Label ?? "选择头像"`
- `Text` = `player.Biography`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-0b7e8b91498c"></a>

## `Field(string) — VBoxContainer Field(string label)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-74f5096742ca)；[`Input(string, string, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-093f6543ff84)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?)`](OpeningPlayerEditor.cs.md#symbol-1e898e8feeab)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`caption.AddThemeColorOverride("font_color",CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddThemeColorOverride("font_color",CareerVisuals.Muted);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = label }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = label }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(field)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(field);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill }`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `Control.SizeFlags.ExpandFill`
- `Text` = `label`

<a id="symbol-093f6543ff84"></a>

## `Input(string, string, string, System.Action<string>) — void Input(string label, string value, string hint, Action<string> changed)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Count(string, int?, System.Action<int?>)`](OpeningPlayerEditor.cs.md#symbol-b1740a72a851)；[`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?)`](OpeningPlayerEditor.cs.md#symbol-1e898e8feeab)

**调用：** [`Field(string)`](OpeningPlayerEditor.cs.md#symbol-0b7e8b91498c)；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `Field(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string)`；输入表达式：`Field(label)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field(label).AddChild`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Text = value, PlaceholderText = hint, CustomMinimumSize = new(128,42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Text = value, PlaceholderText = hint, CustomMinimumSize = new(128,42) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field(label).AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field(label).AddChild(input);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(128,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(128,42)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(128,42)`
- `input.TextChanged` += `changed.Invoke`
- `PlaceholderText` = `hint`
- `Text` = `value`

<a id="symbol-74f5096742ca"></a>

## `Choose(string, string, System.Collections.Generic.IEnumerable<string>, string, System.Action<string>) — void Choose(string label, string first, IEnumerable<string> source, string value, Action<string> changed)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?)`](OpeningPlayerEditor.cs.md#symbol-1e898e8feeab)

**调用：** [`Field(string)`](OpeningPlayerEditor.cs.md#symbol-0b7e8b91498c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `Field(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string)`；输入表达式：`Field(label)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Field(label).AddChild`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Field(label).AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field(label).AddChild(choice);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choice.AddItem(first)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddItem(first);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choice.AddItem(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddItem(item);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { FitToLongestItem = false }`
- `Godot.OptionButton.Select(int)`；输入表达式：`choice.Select(Array.IndexOf(list,value)+1)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.Select(Array.IndexOf(list,value)+1);`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed(i == 0 ? "" : list[(int)i-1])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => changed(i == 0 ? "" : list[(int)i-1])`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(list,value)`；返回值紧邻使用处：`BinaryExpressionSyntax: Array.IndexOf(list,value)+1`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`source.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`source.Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = source.Distinct().ToArray()`

**赋值（含属性/字段和局部值）：**

- `choice.ItemSelected` += `i => changed(i == 0 ? "" : list[(int)i-1])`
- `FitToLongestItem` = `false`

<a id="symbol-b1740a72a851"></a>

## `Count(string, int?, System.Action<int?>) — void Count(string label,int? current,Action<int?> set)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OpeningPlayerEditor.Draw(Godot.VBoxContainer, NationalSpire.CareerOpeningPlayer, string, string, string?)`](OpeningPlayerEditor.cs.md#symbol-1e898e8feeab)

**调用：** [`Input(string, string, string, System.Action<string>)`](OpeningPlayerEditor.cs.md#symbol-093f6543ff84)；`int.ToString()`；`int.TryParse(string?, out int)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Input(string, string, string, System.Action<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Input(string, string, string, System.Action<string>)`；输入表达式：`Input(label,current?.ToString() ?? "","沿用默认",s => set(int.TryParse(s,out int n) && n>=0 ? n : null))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>             Input(label,current?.ToString() ?? "","沿用默认",s => set(int.TryParse(s,out int n) && n>=0 ? n : null))`
- `int.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: current?.ToString()`
- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(s,out int n)`；返回值紧邻使用处：`BinaryExpressionSyntax: int.TryParse(s,out int n) && n>=0`
- `System.Action<T>.Invoke(T)`；输入表达式：`set(int.TryParse(s,out int n) && n>=0 ? n : null)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => set(int.TryParse(s,out int n) && n>=0 ? n : null)`

**赋值（含属性/字段和局部值）：**
