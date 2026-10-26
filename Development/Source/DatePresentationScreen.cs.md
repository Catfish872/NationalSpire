# DatePresentationScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`91F26DBDBDD4107D37B1B2EB8593B9BF2FD4A57211E066E0062D8787181E742D`。来源：[源码](../../DatePresentationScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private bool _datePresentationPending;
```

<a id="symbol-ae7a16c86641"></a>

## `NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool) — private bool ConfigureDatePresentation(CareerData data, IReadOnlyList<string> people, Action completed, Action cancelled, bool firstOnly = true)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)

**调用：** [`Default(string)`](DatePresentationScreen.cs.md#symbol-927bbd82bd6a)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AppearanceLibrary.List()`](AppearanceLibrary.cs.md#symbol-1f96a80ecca2)；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool)`](DatePresentation.cs.md#symbol-8371585517ce)；[`NationalSpire.DatePresentation.Pending(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](DatePresentation.cs.md#symbol-9855f582740d)；[`NationalSpire.DatePresentation.Save(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.DatePresentation.Selection>)`](DatePresentation.cs.md#symbol-6b2ede6c9f6f)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；[`Select(int)`](DatePresentationScreen.cs.md#symbol-dbcf354665de)；`System.Action.Invoke()`；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Default(string)`；`NationalSpire.AppearanceLibrary.Entry.Name`；`NationalSpire.AppearanceLibrary.List()`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._datePresentationPending`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Labels`；`NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool)`；`NationalSpire.DatePresentation.Pending(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.DatePresentation.Save(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.DatePresentation.Selection>)`；`NationalSpire.DatePresentation.Selection.Outfit`；`NationalSpire.DatePresentation.Selection.Person`；`NationalSpire.DatePresentation.Selection.Portrait`；`NationalSpire.DatePresentation.Selection.Voice`；`NationalSpire.DatePresentation.Source.Current`；`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PortraitOutfit.Id`；`NationalSpire.PortraitOutfit.Name`；`Select(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Default(string)`；输入表达式：`Default(selection.Person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture = Default(selection.Person)`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { foreach (var image in textures.Values.Distinct()) image.Dispose(); _datePresentationPending = false; if (!IsInstanceValid(this) || IsQueuedForDeletion() || !CareerStore.IsCurrent(data)) return; if (saved) completed(); else cancelled(); }).CallDeferred()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Callable.From(() => { foreach (var image in textures.Values.Distinct()) image.Dispose(); _datePresentationPending = false; if (!IsInstanceValid(this) || IsQueuedForDeletion() || !CareerStore.IsCurrent(data)) return; if (saved) completed(); else cancelled(); }).CallDeferred()`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { foreach (var image in textures.Values.Distinct()) image.Dispose(); _datePresentationPending = false; if (!IsInstanceValid(this) || IsQueuedForDeletion() || !CareerStore.IsCurrent(data)) return; if (saved) completed(); else cancelled(); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { foreach (var image in textures.Values.Distinct()) image.Dispose(); _datePresentationPending = false; if (!IsInstanceValid(this) || IsQueuedForDeletion() || !CareerStore.IsCurrent(data)) return; if (saved) completed(); else cancelled(); }).CallDeferred`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`fields.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rows.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddThemeConstantOverride("separation", 18);`
- `Godot.GodotObject.Dispose()`；输入表达式：`image.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Dispose();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(this) || IsQueuedForDeletion()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(art)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(art);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(voice)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(voice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(fields);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rows.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(rows)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(rows);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`art.AddItem("当前角色立绘 · " + outfit.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: art.AddItem("当前角色立绘 · " + outfit.Name);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`art.AddItem("形象包 · " + entry.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: art.AddItem("形象包 · " + entry.Name);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`art.AddItem(IdentityGender.Of(data, selection.Person) == "女" ? "默认女性剪影" : "默认男性剪影")`；返回值紧邻使用处：`ExpressionStatementSyntax: art.AddItem(IdentityGender.Of(data, selection.Person) == "女" ? "默认女性剪影" : "默认男性剪影");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`voice.AddItem("对局播报 · " + label)`；返回值紧邻使用处：`ExpressionStatementSyntax: voice.AddItem("对局播报 · " + label);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateSetupPortrait_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateSetupPortrait_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateSetupVoice_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateSetupVoice_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }`
- `Godot.OptionButton.Select(int)`；输入表达式：`art.Select(current)`；返回值紧邻使用处：`ExpressionStatementSyntax: art.Select(current);`
- `Godot.OptionButton.Select(int)`；输入表达式：`voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice)))`；返回值紧邻使用处：`ExpressionStatementSyntax: voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice)));`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { CustomMinimumSize = new(100, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, Texture = Default(selection.Person) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { CustomMinimumSize = new(100, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, Texture = Default(selection.Person) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330)))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(100, 154)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(100, 154)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(850, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(850, 0)`
- `NationalSpire.AppearanceLibrary.List()`；输入表达式：`AppearanceLibrary.List()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AppearanceLibrary.List()`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { CustomMinimumSize = new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { CustomMinimumSize = new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, selection.Person)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data, selection.Person)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(firstOnly ? "首次约会 · 立绘与播报口吻" : "立绘与播报口吻", "同一角色在单人和多人约会中共用这些选择。", () => { try { DatePresentation.Save(data, selections); saved = true; return true; } catch (Exception e) { status.Text = e.Message; return false; } }, "确认并继续", box => { box.Name = "DatePresentationSetup"; box.CustomMinimumSize = new(850, 0); var scroll = new BroadcastScroll { CustomMinimumSize = new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; rows.AddThemeConstantOverride("separation", 18); scroll.AddChild(rows); foreach (var selection in selections) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 20); rows.AddChild(row); var preview = new TextureRect { CustomMinimumSize = new(100, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, Texture = Default(selection.Person) }; row.AddChild(preview); var fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; fields.AddThemeConstantOverride("separation", 10); row.AddChild(fields); fields.AddChild(Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold)); var art = new OptionButton { Name = "DateSetupPortrait_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }; fields.AddChild(art); art.AddItem(IdentityGender.Of(data, selection.Person) == "女" ? "默认女性剪影" : "默认男性剪影"); var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person); var outfits = design?.Outfits.ToArray() ?? []; foreach (var outfit in outfits) art.AddItem("当前角色立绘 · " + outfit.Name); foreach (var entry in library) art.AddItem("形象包 · " + entry.Name); var voice = new OptionButton { Name = "DateSetupVoice_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }; fields.AddChild(voice); foreach (string label in DateGameVoices.Labels) voice.AddItem("对局播报 · " + label); voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice))); voice.ItemSelected += index => selection.Voice = DateGameVoices.Ids[(int)index]; void Select(int index) { selection.Portrait = index == 0 ? DatePresentation.Source.Default : index <= outfits.Length ? DatePresentation.Source.Current : DatePresentation.Source.Library; if (selection.Portrait == DatePresentation.Source.Current) selection.Outfit = outfits[index - 1].Id; if (selection.Portrait == DatePresentation.Source.Library) selection.Library = library[index - outfits.Length - 1]; try { if (index == 0) preview.Texture = Default(selection.Person); else { var prepared = DatePresentation.Prepare(data, selection); string hash = DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k]).First(); if (!textures.TryGetValue(hash, out var image)) textures[hash] = image = DateSceneAssetStore.Texture(hash); preview.Texture = image; } if (status != null) status.Text = "确认后保存；下次约会沿用本次选择。"; } catch (Exception e) { preview.Texture = Default(selection.Person); if (status != null) status.Text = e.Message; } } art.ItemSelected += index => Select((int)index); int current = selection.Portrait == DatePresentation.Source.Current ? Array.FindIndex(outfits, o => o.Id == selection.Outfit) + 1 : 0; art.Select(current); Select(current); } status = Text("确认后保存；下次约会沿用本次选择。", 16, _muted); box.AddChild(status); }, cancelText: "返回")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(firstOnly ? "首次约会 · 立绘与播报口吻" : "立绘与播报口吻", "同一角色在单人和多人约会中共用这些选择。", () => { try { DatePresentation.Save(data, selections); saved = true; return true; } catch (Exception e) { status.Text = e.Message; return false; } }, "确认并继续", box => { box.Name = "DatePresentationSetup"; box.CustomMinimumSize = new(850, 0); var scroll = new BroadcastScroll { CustomMinimumSize = new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; rows.AddThemeConstantOverride("separation", 18); scroll.AddChild(rows); foreach (var selection in selections) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 20); rows.AddChild(row); var preview = new TextureRect { CustomMinimumSize = new(100, 154), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, Texture = Default(selection.Person) }; row.AddChild(preview); var fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; fields.AddThemeConstantOverride("separation", 10); row.AddChild(fields); fields.AddChild(Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold)); var art = new OptionButton { Name = "DateSetupPortrait_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }; fields.AddChild(art); art.AddItem(IdentityGender.Of(data, selection.Person) == "女" ? "默认女性剪影" : "默认男性剪影"); var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person); var outfits = design?.Outfits.ToArray() ?? []; foreach (var outfit in outfits) art.AddItem("当前角色立绘 · " + outfit.Name); foreach (var entry in library) art.AddItem("形象包 · " + entry.Name); var voice = new OptionButton { Name = "DateSetupVoice_" + selection.Person, CustomMinimumSize = new(0, 44), FitToLongestItem = false }; fields.AddChild(voice); foreach (string label in DateGameVoices.Labels) voice.AddItem("对局播报 · " + label); voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice))); voice.ItemSelected += index => selection.Voice = DateGameVoices.Ids[(int)index]; void Select(int index) { selection.Portrait = index == 0 ? DatePresentation.Source.Default : index <= outfits.Length ? DatePresentation.Source.Current : DatePresentation.Source.Library; if (selection.Portrait == DatePresentation.Source.Current) selection.Outfit = outfits[index - 1].Id; if (selection.Portrait == DatePresentation.Source.Library) selection.Library = library[index - outfits.Length - 1]; try { if (index == 0) preview.Texture = Default(selection.Person); else { var prepared = DatePresentation.Prepare(data, selection); string hash = DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k]).First(); if (!textures.TryGetValue(hash, out var image)) textures[hash] = image = DateSceneAssetStore.Texture(hash); preview.Texture = image; } if (status != null) status.Text = "确认后保存；下次约会沿用本次选择。"; } catch (Exception e) { preview.Texture = Default(selection.Person); if (status != null) status.Text = e.Message; } } art.ItemSelected += index => Select((int)index); int current = selection.Portrait == DatePresentation.Source.Current ? Array.FindIndex(outfits, o => o.Id == selection.Outfit) + 1 : 0; art.Select(current); Select(current); } status = Text("确认后保存；下次约会沿用本次选择。", 16, _muted); box.AddChild(status); }, cancelText: "返回");`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("确认后保存；下次约会沿用本次选择。", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("确认后保存；下次约会沿用本次选择。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerEngine.DisplayName(data, selection.Person), 23, _gold)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool)`；输入表达式：`DatePresentation.Initial(data, p, firstOnly)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => DatePresentation.Initial(data, p, firstOnly)`
- `NationalSpire.DatePresentation.Pending(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`DatePresentation.Pending(data, people)`；返回值紧邻使用处：`ConditionalExpressionSyntax: firstOnly ? DatePresentation.Pending(data, people) : people.Distinct().ToArray()`
- `NationalSpire.DatePresentation.Save(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.DatePresentation.Selection>)`；输入表达式：`DatePresentation.Save(data, selections)`；返回值紧邻使用处：`ExpressionStatementSyntax: DatePresentation.Save(data, selections);`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(data, selection.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: IdentityGender.Of(data, selection.Person) == "女"`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, selection.Person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, selection.Person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person)`
- `Select(int)`；输入表达式：`Select((int)index)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: index => Select((int)index)`
- `Select(int)`；输入表达式：`Select(current)`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(current);`
- `System.Action.Invoke()`；输入表达式：`cancelled()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancelled();`
- `System.Action.Invoke()`；输入表达式：`completed()`；返回值紧邻使用处：`ExpressionStatementSyntax: completed();`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(outfits, o => o.Id == selection.Outfit)`；返回值紧邻使用处：`BinaryExpressionSyntax: Array.FindIndex(outfits, o => o.Id == selection.Outfit) + 1`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(DateGameVoices.Ids, selection.Voice)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(DateGameVoices.Ids, selection.Voice)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Texture2D>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Texture2D>()`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`textures.Values.Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var image in textures.Values.Distinct()) image.Dispose();`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`targets.Select(p => DatePresentation.Initial(data, p, firstOnly))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: targets.Select(p => DatePresentation.Initial(data, p, firstOnly)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`people.Distinct().ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: firstOnly ? DatePresentation.Pending(data, people) : people.Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`targets.Select(p => DatePresentation.Initial(data, p, firstOnly)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = targets.Select(p => DatePresentation.Initial(data, p, firstOnly)).ToList()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`.Outfits.ToArray()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: design?.Outfits.ToArray()`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(185, _stage.Size.Y - 330)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(185, _stage.Size.Y - 330)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, Array.IndexOf(DateGameVoices.Ids, selection.Voice))`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 44)`
- `CustomMinimumSize` = `new(0, Math.Clamp(targets.Length * 185, 185, Math.Max(185, _stage.Size.Y - 330)))`
- `CustomMinimumSize` = `new(100, 154)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `FitToLongestItem` = `false`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"DateSetupPortrait_" + selection.Person`
- `Name` = `"DateSetupVoice_" + selection.Person`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `Default(selection.Person)`
- `_datePresentationPending` = `false`
- `_datePresentationPending` = `true`
- `art.ItemSelected` += `index => Select((int)index)`
- `box.CustomMinimumSize` = `new(850, 0)`
- `box.Name` = `"DatePresentationSetup"`
- `dialog.TreeExiting` += `() => Callable.From(() => { foreach (var image in textures.Values.Distinct()) image.Dispose(); _datePresentationPending = false; if (!IsInstanceValid(this) || IsQueuedForDeletion() || !CareerStore.IsCurrent(data)) return; if (saved) completed(); else cancelled(); }).CallDeferred()`
- `saved` = `true`
- `selection.Voice` = `DateGameVoices.Ids[(int)index]`
- `status.Text` = `e.Message`
- `status` = `Text("确认后保存；下次约会沿用本次选择。", 16, _muted)`
- `voice.ItemSelected` += `index => selection.Voice = DateGameVoices.Ids[(int)index]`

<a id="symbol-927bbd82bd6a"></a>

## `Default(string) — Texture2D Default(string id)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)；[`Select(int)`](DatePresentationScreen.cs.md#symbol-dbcf354665de)

**调用：** [`NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string)`](DateDefaultPortraits.cs.md#symbol-5c7df7a4e40d)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string)`；输入表达式：`DateDefaultPortraits.Texture(data, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: image = DateDefaultPortraits.Texture(data, id)`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: "default:" + IdentityGender.Of(data, id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`textures.TryGetValue(key, out var image)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !textures.TryGetValue(key, out var image)`

**赋值（含属性/字段和局部值）：**

- `image` = `DateDefaultPortraits.Texture(data, id)`
- `textures[key]` = `image = DateDefaultPortraits.Texture(data, id)`

<a id="symbol-dbcf354665de"></a>

## `Select(int) — void Select(int index)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)

**调用：** [`Default(string)`](DatePresentationScreen.cs.md#symbol-927bbd82bd6a)；[`NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`](DatePresentation.cs.md#symbol-dba968a252db)；[`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `Default(string)`；`NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`；`NationalSpire.DatePresentation.Selection.Library`；`NationalSpire.DatePresentation.Selection.Outfit`；`NationalSpire.DatePresentation.Selection.Person`；`NationalSpire.DatePresentation.Selection.Portrait`；`NationalSpire.DatePresentation.Source.Current`；`NationalSpire.DatePresentation.Source.Default`；`NationalSpire.DatePresentation.Source.Library`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitOutfit.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Default(string)`；输入表达式：`Default(selection.Person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview.Texture = Default(selection.Person)`
- `NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`；输入表达式：`DatePresentation.Prepare(data, selection)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DatePresentation.Prepare(data, selection)`
- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`DateSceneAssetStore.Texture(hash)`；返回值紧邻使用处：`AssignmentExpressionSyntax: image = DateSceneAssetStore.Texture(hash)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`textures.TryGetValue(hash, out var image)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !textures.TryGetValue(hash, out var image)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k]).First()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k]).First()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.SpriteKeys(prepared.Assets, prepared.Design, prepared.Design.DefaultEmotionId).Select(k => prepared.Assets.Sprites[k]).First`

**赋值（含属性/字段和局部值）：**

- `image` = `DateSceneAssetStore.Texture(hash)`
- `preview.Texture` = `Default(selection.Person)`
- `preview.Texture` = `image`
- `selection.Library` = `library[index - outfits.Length - 1]`
- `selection.Outfit` = `outfits[index - 1].Id`
- `selection.Portrait` = `index == 0 ? DatePresentation.Source.Default : index <= outfits.Length ? DatePresentation.Source.Current : DatePresentation.Source.Library`
- `status.Text` = `"确认后保存；下次约会沿用本次选择。"`
- `status.Text` = `e.Message`
- `textures[hash]` = `image = DateSceneAssetStore.Texture(hash)`
