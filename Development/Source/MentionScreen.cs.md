# MentionScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`791A41781425B258872FB844F1961B03ABA45433B446C2A06BA0DA753CC3C7E7`。来源：[源码](../../MentionScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private PersonMentions? _mentions;
private List<(string Id, string Name)> _mentionNames = [];
private bool _mentionsChecked;
```

<a id="symbol-2764c9b1b0cd"></a>

## `NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?) — private Control MentionText(CareerData data, string source, int size, Color color, IEnumerable<string>? related = null)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Display(string)`](LifeData.cs.md#symbol-4a2afc43261a)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-921c23662473)；[`NationalSpire.PersonMentions.Find(string, System.Collections.Generic.IEnumerable<string>?)`](PersonMentions.cs.md#symbol-c1807cb3a9db)；[`NationalSpire.PersonMentions.PersonMentions(System.Collections.Generic.IEnumerable<(string Id, string Name)>)`](PersonMentions.cs.md#symbol-53fac6a2c838)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.RichTextLabel.AddText(string)`；`Godot.RichTextLabel.Pop()`；`Godot.RichTextLabel.PushColor(Godot.Color)`；`Godot.RichTextLabel.PushMeta(Godot.Variant, Godot.RichTextLabel.MetaUnderline, string)`；`Godot.RichTextLabel.RichTextLabel()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Variant.AsString()`；`string.Substring(int, int)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Display(string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen._mentionNames`；`NationalSpire.CareerScreen._mentions`；`NationalSpire.CareerScreen._mentionsChecked`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；`NationalSpire.PersonMentions.Find(string, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.PersonMentions.Match.Length`；`NationalSpire.PersonMentions.Match.PersonId`；`NationalSpire.PersonMentions.Match.Start`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("9bc3ce")`；返回值紧邻使用处：`ArgumentSyntax: new Color("9bc3ce")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`rich.AddThemeColorOverride("default_color", color)`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.AddThemeColorOverride("default_color", color);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`rich.AddThemeFontSizeOverride("normal_font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.AddThemeFontSizeOverride("normal_font_size", size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`rich.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.RichTextLabel.AddText(string)`；输入表达式：`rich.AddText(text.Substring(mention.Start, mention.Length))`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.AddText(text.Substring(mention.Start, mention.Length));`
- `Godot.RichTextLabel.AddText(string)`；输入表达式：`rich.AddText(text[cursor..])`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.AddText(text[cursor..]);`
- `Godot.RichTextLabel.AddText(string)`；输入表达式：`rich.AddText(text[cursor..mention.Start])`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.AddText(text[cursor..mention.Start]);`
- `Godot.RichTextLabel.Pop()`；输入表达式：`rich.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.Pop();`
- `Godot.RichTextLabel.PushColor(Godot.Color)`；输入表达式：`rich.PushColor(new Color("9bc3ce"))`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.PushColor(new Color("9bc3ce"));`
- `Godot.RichTextLabel.PushMeta(Godot.Variant, Godot.RichTextLabel.MetaUnderline, string)`；输入表达式：`rich.PushMeta(mention.PersonId, RichTextLabel.MetaUnderline.Always, details + "\n点击查看档案")`；返回值紧邻使用处：`ExpressionStatementSyntax: rich.PushMeta(mention.PersonId, RichTextLabel.MetaUnderline.Always, details + "\n点击查看档案");`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { Name = "PersonMentionText", FitContent = true, ScrollActive = false,              SelectionEnabled = true, BbcodeEnabled = false, AutowrapMode = TextServer.AutowrapMode.WordSmart,              SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RichTextLabel { Name = "PersonMentionText", FitContent = true, ScrollActive = false,              SelectionEnabled = true, BbcodeEnabled = false, AutowrapMode = TextServer.AutowrapMode.WordSmart,              SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Variant.AsString()`；输入表达式：`meta.AsString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = meta.AsString()`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(data)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(data)}`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, id) != null`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, mention.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, mention.PersonId)`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerMoney.Display(source)`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPerson(id);`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(text, size, color)`；返回值紧邻使用处：`ReturnStatementSyntax: return PrivateSelectableText(text, size, color);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, data.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(data, data.Esports.ClubId)}`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, person?.ClubId ?? "")`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(data, person?.ClubId ?? "")}`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(data)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.LicenseName(data)}`
- `NationalSpire.PersonMentions.Find(string, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`_mentions!.Find(text, related)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _mentions!.Find(text, related)`
- `NationalSpire.PersonMentions.PersonMentions(System.Collections.Generic.IEnumerable<(string Id, string Name)>)`；输入表达式：`new PersonMentions(names)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mentions = new PersonMentions(names)`
- `string.Substring(int, int)`；输入表达式：`text.Substring(mention.Start, mention.Length)`；返回值紧邻使用处：`ArgumentSyntax: text.Substring(mention.Start, mention.Length)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`data.PlayerNameAliases.Append(CareerEngine.Name(data))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.PublicName).Append(p.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.PublicName).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))).Concat(data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))).Concat(data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))`；返回值紧邻使用处：`ArgumentSyntax: data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`names.SequenceEqual(_mentionNames)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !names.SequenceEqual(_mentionNames)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))).Concat(data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)                  .Select(name => (p.Id, name))).Concat(data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))).ToList()`

**赋值（含属性/字段和局部值）：**

- `_mentionNames` = `names`
- `_mentions` = `new PersonMentions(names)`
- `_mentionsChecked` = `true`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `BbcodeEnabled` = `false`
- `cursor` = `mention.Start + mention.Length`
- `FitContent` = `true`
- `MouseFilter` = `MouseFilterEnum.Pass`
- `Name` = `"PersonMentionText"`
- `rich.MetaClicked` += `meta =>          {              string id = meta.AsString();              if (id == "player" || CareerEngine.Person(data, id) != null) OpenPerson(id);          }`
- `ScrollActive` = `false`
- `SelectionEnabled` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
