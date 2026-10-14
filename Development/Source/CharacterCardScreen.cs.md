# CharacterCardScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EE8BF3FD93363DE76DF845C4BFD794344431D9D52DD2797C139B505FF3250F32`。来源：[源码](../../CharacterCardScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Control? _characterCardOverlay;
private Action? _closeCharacterCard;
```

<a id="symbol-e038ea7a677f"></a>

## `NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string) — private bool CanEditCharacter(CareerData data, string id)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)

**调用：** `System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.ICareerSession.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a498f622bb3e"></a>

## `NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?) — private void OpenCharacterCard(CareerData data, string? id, CareerPerson? imported = null)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`AutomaticPortrait()`](CharacterCardScreen.cs.md#symbol-545b829b2369)；[`Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`](CharacterCardScreen.cs.md#symbol-0ea19aaa6aaf)；[`CloseEditor()`](CharacterCardScreen.cs.md#symbol-172c824e283a)；[`Controls(Godot.Node)`](CharacterCardScreen.cs.md#symbol-3ed4c80d52c7)；[`Line(Godot.Control, string, string, System.Action<string>, string?)`](CharacterCardScreen.cs.md#symbol-7b4eec980805)；[`Memo(Godot.Control, string, string, System.Action<string>, string?)`](CharacterCardScreen.cs.md#symbol-203ab71fae9d)；[`NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt)`](AvatarImages.cs.md#symbol-f46bb00e33dc)；[`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`](AvatarImages.cs.md#symbol-1edd50772202)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`](CharacterCardScreen.cs.md#symbol-e038ea7a677f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-e74b66910ad6)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ResetNavigation()`](CareerNavigation.cs.md#symbol-870e8f5590bb)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`](CareerDialog.cs.md#symbol-ecc011933bb1)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CharacterCardPng.Export(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar)`](CharacterCardPng.cs.md#symbol-e9bb5cec943f)；[`NationalSpire.CharacterCardPng.ReadFile(NationalSpire.CareerData, string, System.Func<byte[], NationalSpire.PlayerAvatar>)`](CharacterCardPng.cs.md#symbol-f8d3e133c6cd)；[`NationalSpire.CharacterCardPng.WriteDesktop(byte[])`](CharacterCardPng.cs.md#symbol-9dce15912b60)；[`NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string)`](CharacterCards.cs.md#symbol-8233ca321672)；[`NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-e5e79a4ed241)；[`NationalSpire.CharacterCards.Encode(NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-567fa6811160)；[`NationalSpire.CharacterCards.New(NationalSpire.CareerData)`](CharacterCards.cs.md#symbol-3514413c59e6)；[`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-3c3ff9c389dd)；[`NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-4bce7f6af16c)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-ef7276d6a37c)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；[`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`](MatchRules.cs.md#symbol-4f16d2879002)；[`NationalSpire.PersonalityLibrary.SelectKind(NationalSpire.PersonalityProfile, string)`](PersonalityLibrary.cs.md#symbol-267eb91e8c1d)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`](CharacterCardScreen.cs.md#symbol-5a856ec57564)；[`Pair(Godot.Control)`](CharacterCardScreen.cs.md#symbol-f793d19facd1)；[`Section(string)`](CharacterCardScreen.cs.md#symbol-4d8858dfa3ef)；[`SetCharacter(string)`](CharacterCardScreen.cs.md#symbol-3d5aa9185f57)；[`ShowSavedCard()`](CharacterCardScreen.cs.md#symbol-3b5002c5e2d5)；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.ReleaseFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetViewport()`；`Godot.OptionButton.Select(int)`；`Godot.OS.ShellShowInFileManager(string, bool)`；`Godot.SpinBox.Apply()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetFocusOwner()`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`NationalSpire.CareerAvatar.CareerAvatar()`；`NationalSpire.CharacterCardEdit.CharacterCardEdit()`；`NationalSpire.CharacterRelationEdit.CharacterRelationEdit()`；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`AutomaticPortrait()`；`Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；`CloseEditor()`；`Controls(Godot.Node)`；`Line(Godot.Control, string, string, System.Action<string>, string?)`；`Memo(Godot.Control, string, string, System.Action<string>, string?)`；`NationalSpire.AvatarImages.FromCardPng(byte[])`；`NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt)`；`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.CreatedCard`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerScreen._characterCardOverlay`；`NationalSpire.CareerScreen._closeCharacterCard`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`；`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ResetNavigation()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Relation`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.CharacterCardPng.Export(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar)`；`NationalSpire.CharacterCardPng.ReadFile(NationalSpire.CareerData, string, System.Func<byte[], NationalSpire.PlayerAvatar>)`；`NationalSpire.CharacterCardPng.WriteDesktop(byte[])`；`NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string)`；`NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string)`；`NationalSpire.CharacterCards.Encode(NationalSpire.CharacterCardEdit)`；`NationalSpire.CharacterCards.New(NationalSpire.CareerData)`；`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；`NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`；`NationalSpire.CharacterCards.Templates`；`NationalSpire.CharacterDefinition.DisplayName`；`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`；`NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`；`NationalSpire.CharacterIdentity.Source`；`NationalSpire.CharacterRelationEdit.Favour`；`NationalSpire.CharacterRelationEdit.Impression`；`NationalSpire.CharacterRelationEdit.Relationship`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.ICareerSession.Message`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.IdentityGender.Choices`；`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.PersonalityLibrary.Kinds`；`NationalSpire.PersonalityLibrary.SelectKind(NationalSpire.PersonalityProfile, string)`；`NationalSpire.PersonalityProfile.AttitudeMax`；`NationalSpire.PersonalityProfile.AttitudeMin`；`NationalSpire.PersonalityProfile.Curiosity`；`NationalSpire.PersonalityProfile.Evidence`；`NationalSpire.PersonalityProfile.Humor`；`NationalSpire.PersonalityProfile.Kind`；`NationalSpire.PersonalityProfile.Loyalty`；`NationalSpire.PersonalityProfile.Pressure`；`NationalSpire.PersonalityProfile.Social`；`NationalSpire.PlayerAvatar.Source`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.Relationship`；`Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；`OnCardMessage(string, bool)`；`Pair(Godot.Control)`；`Section(string)`；`SetCharacter(string)`；`ShowSavedCard()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AutomaticPortrait()`；输入表达式：`AutomaticPortrait()`；返回值紧邻使用处：`ArgumentSyntax: AutomaticPortrait()`
- `AutomaticPortrait()`；输入表达式：`AutomaticPortrait()`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(avatar) ?? AutomaticPortrait()`
- `AutomaticPortrait()`；输入表达式：`AutomaticPortrait()`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(draft.Avatar) ?? AutomaticPortrait()`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(ability, "选择已安装的角色", characterNames, Array.IndexOf(characterNames, draft.Character), n => { character.Text = characterNames[n]; SetCharacter(character.Text); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice(ability, "选择已安装的角色", characterNames, Array.IndexOf(characterNames, draft.Character), n => { character.Text = characterNames[n]; SetCharacter(character.Text); });`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(identity, "关注俱乐部", new[] { "无固定支持" }.Concat(clubNames.Skip(1)).ToArray(), Array.IndexOf(clubs, draft.SupportedClubId), n => draft.SupportedClubId = clubs[n])`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice(identity, "关注俱乐部", new[] { "无固定支持" }.Concat(clubNames.Skip(1)).ToArray(), Array.IndexOf(clubs, draft.SupportedClubId), n => draft.SupportedClubId = clubs[n]);`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(identity, "所属俱乐部", clubNames, Array.IndexOf(clubs, draft.ClubId), n => draft.ClubId = clubs[n], "CardClub")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Choice(identity, "所属俱乐部", clubNames, Array.IndexOf(clubs, draft.ClubId), n => draft.ClubId = clubs[n], "CardClub")`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(identityFields, "国家 / 地区", EsportsWorld.Countries, Array.IndexOf(EsportsWorld.Countries, draft.Country), n => draft.Country = EsportsWorld.Countries[n], "CardCountry")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Choice(identityFields, "国家 / 地区", EsportsWorld.Countries, Array.IndexOf(EsportsWorld.Countries, draft.Country), n => draft.Country = EsportsWorld.Countries[n], "CardCountry")`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(identityFields, "性别", genders, Array.IndexOf(genders, draft.Gender), n => draft.Gender = genders[n], "CardGender")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Choice(identityFields, "性别", genders, Array.IndexOf(genders, draft.Gender), n => draft.Gender = genders[n], "CardGender")`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(personality, "性格预设", new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds).ToArray(), 0, n =>          {              if (n == 0) return; PersonalityLibrary.SelectKind(draft.Personality, PersonalityLibrary.Kinds[n - 1]);              kind.Text = draft.Personality.Kind; attitudeMin.Value = draft.Personality.AttitudeMin; attitudeMax.Value = draft.Personality.AttitudeMax; social.Text = draft.Personality.Social;          })`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice(personality, "性格预设", new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds).ToArray(), 0, n =>          {              if (n == 0) return; PersonalityLibrary.SelectKind(draft.Personality, PersonalityLibrary.Kinds[n - 1]);              kind.Text = draft.Personality.Kind; attitudeMin.Value = draft.Personality.AttitudeMin; attitudeMax.Value = draft.Personality.AttitudeMax; social.Text = draft.Personality.Social;          });`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(presetRow, "能力预设", CharacterCards.Templates, Array.IndexOf(CharacterCards.Templates, draft.AbilityTemplate.Length > 0 ? draft.AbilityTemplate : draft.Role), _ => { }, "CardPreset")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Choice(presetRow, "能力预设", CharacterCards.Templates, Array.IndexOf(CharacterCards.Templates, draft.AbilityTemplate.Length > 0 ? draft.AbilityTemplate : draft.Role), _ => { }, "CardPreset")`
- `Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`；输入表达式：`Choice(probability, "模拟通关率", ["现有算法", "自定义"], draft.CustomClearChance.HasValue ? 1 : 0, n =>          { draft.CustomClearChance = n == 0 ? null : rate.Value / 100; rate.Editable = n == 1; }, "CardChanceMode")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Choice(probability, "模拟通关率", ["现有算法", "自定义"], draft.CustomClearChance.HasValue ? 1 : 0, n =>          { draft.CustomClearChance = n == 0 ? null : rate.Value / 100; rate.Editable = n == 1; }, "CardChanceMode")`
- `CloseEditor()`；输入表达式：`CloseEditor()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseEditor();`
- `Controls(Godot.Node)`；输入表达式：`Controls(_stage)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where`
- `Controls(Godot.Node)`；输入表达式：`Controls(shade)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(shade).OfType<SpinBox>`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(0, 0, 0, .84f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new(0, 0, 0, .84f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("e9a799")`；返回值紧邻使用处：`ArgumentSyntax: new Color("e9a799")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f08080")`；返回值紧邻使用处：`AssignmentExpressionSyntax: status.Modulate = new Color("f08080")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "CharacterCardEditor", Color = new(0, 0, 0, .84f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 15 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "CharacterCardEditor", Color = new(0, 0, 0, .84f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 15 }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`delete.AddThemeColorOverride("font_color", new Color("e9a799"))`；返回值紧邻使用处：`ExpressionStatementSyntax: delete.AddThemeColorOverride("font_color", new Color("e9a799"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 100)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 100);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 45)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 45);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`presetRow.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: presetRow.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`root.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tabs.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.ReleaseFocus()`；输入表达式：`.ReleaseFocus()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GetViewport().GuiGetFocusOwner()?.ReleaseFocus()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(status)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(status)) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("f08080"); }`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(status)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(status)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`shade.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(status) || shade.IsQueuedForDeletion()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ability.AddChild(presetRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: ability.AddChild(presetRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ability.AddChild(Text("培养加成另计。累计胜负仅修改档案；真人对局由实际战斗决定。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: ability.AddChild(Text("培养加成另计。累计胜负仅修改档案；真人对局由实际战斗决定。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ability.AddChild(Text("胜率为通过的最高进阶胜率，更高或更低进阶将动态调整", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: ability.AddChild(Text("胜率为通过的最高进阶胜率，更高或更低进阶将动态调整", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("取消", CloseEditor, 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("取消", CloseEditor, 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button(create ? "创建并保存" : "保存角色", () =>          {              foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();              GetViewport().GuiGetFocusOwner()?.ReleaseFocus();              if (_multiplayer != null)              {                  string payload;                  try { payload = CharacterCards.Encode(edit); }                  catch (Exception e) { status.Text = e.Message; status.Modulate = new Color("f08080"); return; }                  status.Text = "正在提交，保存成功后关闭。";                  _multiplayer.Send("character-card", text: payload, accepted: () =>                  { _multiplayer.Refresh(); ShowSavedCard(); });                  return;              }              if (CharacterCards.Save(ViewData, edit) is { } error) { status.Text = error; status.Modulate = new Color("f08080"); return; }              ShowSavedCard();          }, 210))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button(create ? "创建并保存" : "保存角色", () =>          {              foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();              GetViewport().GuiGetFocusOwner()?.ReleaseFocus();              if (_multiplayer != null)              {                  string payload;                  try { payload = CharacterCards.Encode(edit); }                  catch (Exception e) { status.Text = e.Message; status.Modulate = new Color("f08080"); return; }                  status.Text = "正在提交，保存成功后关闭。";                  _multiplayer.Send("character-card", text: payload, accepted: () =>                  { _multiplayer.Refresh(); ShowSavedCard(); });                  return;              }              if (CharacterCards.Save(ViewData, edit) is { } error) { status.Text = error; status.Modulate = new Color("f08080"); return; }              ShowSavedCard();          }, 210));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(exportButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(exportButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(importButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(importButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(Button("选择头像", () => OpenAvatarSettings(data, draft.Avatar, avatar =>          { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait()), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(Button("选择头像", () => OpenAvatarSettings(data, draft.Avatar, avatar =>          { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait()), 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(delete)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(delete);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(portrait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(subtitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(subtitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(Text(create ? "创建角色" : "编辑角色", 30, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(Text(create ? "创建角色" : "编辑角色", 30, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(Text(clubLock ?? "已报名的赛事沿用原阵容。自建俱乐部通过签约招募。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(Text(clubLock ?? "已报名的赛事沿用原阵容。自建俱乐部通过签约招募。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`personality.AddChild(Text("-5 偏向嘲讽、挑衅，+5 偏向维护、吹捧。性格决定表达方式。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: personality.AddChild(Text("-5 偏向嘲讽、挑衅，+5 偏向维护、吹捧。性格决定表达方式。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`presetRow.AddChild(apply)`；返回值紧邻使用处：`ExpressionStatementSyntax: presetRow.AddChild(apply);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(pages)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(pages);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(margin);`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.OptionButton.Select(int)`；输入表达式：`mode.Select(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: mode.Select(0);`
- `Godot.OS.ShellShowInFileManager(string, bool)`；输入表达式：`OS.ShellShowInFileManager(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: OS.ShellShowInFileManager(path);`
- `Godot.SpinBox.Apply()`；输入表达式：`input.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: input.Apply();`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(88, 88)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(88, 88)`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GetViewport().GuiGetFocusOwner()?.ReleaseFocus()`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetFocusOwner()`
- `Line(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Line(abilityFields, "擅长角色", draft.Character, SetCharacter, "CardCharacter")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Line(abilityFields, "擅长角色", draft.Character, SetCharacter, "CardCharacter")`
- `Line(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Line(abilityFields, "职业 · 可自定义", draft.Role, v => draft.Role = v, "CardRole")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Line(abilityFields, "职业 · 可自定义", draft.Role, v => draft.Role = v, "CardRole")`
- `Line(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Line(identityFields, "姓名 · 可留空", draft.Name, v => draft.Name = v, "CardRealName")`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(identityFields, "姓名 · 可留空", draft.Name, v => draft.Name = v, "CardRealName");`
- `Line(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Line(identityFields, "游戏 ID", draft.Handle, v => { draft.Handle = v; subtitle.Text = v; }, "CardHandle")`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(identityFields, "游戏 ID", draft.Handle, v => { draft.Handle = v; subtitle.Text = v; }, "CardHandle");`
- `Line(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Line(personality, "性格", draft.Personality.Kind, v => draft.Personality.Kind = v, "CardPersonality")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Line(personality, "性格", draft.Personality.Kind, v => draft.Personality.Kind = v, "CardPersonality")`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(attitude, "对你的印象", relation.Impression, v => (edit.Relation ??= new()).Impression = v, "CardImpression")`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(attitude, "对你的印象", relation.Impression, v => (edit.Relation ??= new()).Impression = v, "CardImpression");`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(attitude, "交往关系", relation.Relationship, v => (edit.Relation ??= new()).Relationship = v, "CardRelationship")`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(attitude, "交往关系", relation.Relationship, v => (edit.Relation ??= new()).Relationship = v, "CardRelationship");`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(identity, "人物简介", draft.Biography, v => draft.Biography = v, "CardBiography")`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(identity, "人物简介", draft.Biography, v => draft.Biography = v, "CardBiography");`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "表达习惯", draft.Voice, v => draft.Voice = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "表达习惯", draft.Voice, v => draft.Voice = v);`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "打法偏好", draft.Style, v => draft.Style = v, "CardStyle")`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "打法偏好", draft.Style, v => draft.Style = v, "CardStyle");`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "关注与好奇", draft.Personality.Curiosity, v => draft.Personality.Curiosity = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "关注与好奇", draft.Personality.Curiosity, v => draft.Personality.Curiosity = v);`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "判断依据", draft.Personality.Evidence, v => draft.Personality.Evidence = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "判断依据", draft.Personality.Evidence, v => draft.Personality.Evidence = v);`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "受挫反应", draft.Personality.Pressure, v => draft.Personality.Pressure = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "受挫反应", draft.Personality.Pressure, v => draft.Personality.Pressure = v);`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "说话动机", draft.Personality.Social, v => draft.Personality.Social = v)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Memo(personality, "说话动机", draft.Personality.Social, v => draft.Personality.Social = v)`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "玩笑习惯", draft.Personality.Humor, v => draft.Personality.Humor = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "玩笑习惯", draft.Personality.Humor, v => draft.Personality.Humor = v);`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "维护立场", draft.Personality.Loyalty, v => draft.Personality.Loyalty = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "维护立场", draft.Personality.Loyalty, v => draft.Personality.Loyalty = v);`
- `Memo(Godot.Control, string, string, System.Action<string>, string?)`；输入表达式：`Memo(personality, "性格概述", draft.Temperament, v => draft.Temperament = v)`；返回值紧邻使用处：`ExpressionStatementSyntax: Memo(personality, "性格概述", draft.Temperament, v => draft.Temperament = v);`
- `NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt)`；输入表达式：`AvatarImages.FromCharacterCardArt(this, AutomaticPortrait())`；返回值紧邻使用处：`AwaitExpressionSyntax: await AvatarImages.FromCharacterCardArt(this, AutomaticPortrait())`
- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(avatar)`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(avatar) ?? AutomaticPortrait()`
- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(draft.Avatar)`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(draft.Avatar) ?? AutomaticPortrait()`
- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(incoming.Avatar)`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(incoming.Avatar) == null`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "CharacterCardScroll", SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "CharacterCardScroll", SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Name = "CardPortrait", CustomMinimumSize = new(88, 88), Art = AvatarImages.Read(draft.Avatar) ?? AutomaticPortrait() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Name = "CardPortrait", CustomMinimumSize = new(88, 88), Art = AvatarImages.Read(draft.Avatar) ?? AutomaticPortrait() }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导出 PNG", async () =>          {              try              {                  foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();                  var avatar = draft.Avatar.Source == "auto" ? await AvatarImages.FromCharacterCardArt(this, AutomaticPortrait()) : draft.Avatar;                  if (!IsInstanceValid(status) || shade.IsQueuedForDeletion()) return;                  string path = CharacterCardPng.WriteDesktop(CharacterCardPng.Export(data, draft, avatar));                  status.Text = "角色卡已导出到桌面。分享时请发送原始 PNG 文件。"; status.Modulate = Colors.White;                  OS.ShellShowInFileManager(path);              }              catch (Exception e) { status.Text = "导出失败：" + e.Message; status.Modulate = new Color("f08080"); }          }, 155)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("导出 PNG", async () =>          {              try              {                  foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();                  var avatar = draft.Avatar.Source == "auto" ? await AvatarImages.FromCharacterCardArt(this, AutomaticPortrait()) : draft.Avatar;                  if (!IsInstanceValid(status) || shade.IsQueuedForDeletion()) return;                  string path = CharacterCardPng.WriteDesktop(CharacterCardPng.Export(data, draft, avatar));                  status.Text = "角色卡已导出到桌面。分享时请发送原始 PNG 文件。"; status.Modulate = Colors.White;                  OS.ShellShowInFileManager(path);              }              catch (Exception e) { status.Text = "导出失败：" + e.Message; status.Modulate = new Color("f08080"); }          }, 155)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入 PNG", () => OpenFilePicker("导入角色卡", [".png"], path =>          {              try              {                  var incoming = CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng);                  if (AvatarImages.Read(incoming.Avatar) == null) throw new InvalidDataException("角色卡头像无法解码。");                  CloseEditor(); OpenCharacterCard(ViewData, null, incoming);              }              catch (Exception e) { if (IsInstanceValid(status)) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("f08080"); } }          }), 155)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("导入 PNG", () => OpenFilePicker("导入角色卡", [".png"], path =>          {              try              {                  var incoming = CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng);                  if (AvatarImages.Read(incoming.Avatar) == null) throw new InvalidDataException("角色卡头像无法解码。");                  CloseEditor(); OpenCharacterCard(ViewData, null, incoming);              }              catch (Exception e) { if (IsInstanceValid(status)) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("f08080"); } }          }), 155)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消", CloseEditor, 150)`；返回值紧邻使用处：`ArgumentSyntax: Button("取消", CloseEditor, 150)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除角色", () => ShowCareerDialog("删除" + draft.PublicName,                  "取消未完成的安排，历史帖子和赛果保留。" + (CharacterDeletion.StarterReplacement(data, draft.Id) is { } replacement                      ? "\n" + replacement.PublicName + "将接替首发，合同待遇不变。" : ""), () =>              {                  if (MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })) return true;                  var error = CharacterDeletion.Delete(data, draft.Id);                  if (error != null) { Notice(error, true); return false; }                  CareerStore.Save(data); _closeCharacterCard?.Invoke(); ResetNavigation(); Render(); return true;              }, "删除角色", compact: true), 145)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("删除角色", () => ShowCareerDialog("删除" + draft.PublicName,                  "取消未完成的安排，历史帖子和赛果保留。" + (CharacterDeletion.StarterReplacement(data, draft.Id) is { } replacement                      ? "\n" + replacement.PublicName + "将接替首发，合同待遇不变。" : ""), () =>              {                  if (MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })) return true;                  var error = CharacterDeletion.Delete(data, draft.Id);                  if (error != null) { Notice(error, true); return false; }                  CareerStore.Save(data); _closeCharacterCard?.Invoke(); ResetNavigation(); Render(); return true;              }, "删除角色", compact: true), 145)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("选择头像", () => OpenAvatarSettings(data, draft.Avatar, avatar =>          { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait()), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("选择头像", () => OpenAvatarSettings(data, draft.Avatar, avatar =>          { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait()), 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("应用预设", () =>          {              CharacterCards.ApplyTemplate(draft, CharacterCards.Templates[preset.Selected]); role.Text = draft.Role;              ascension.Value = draft.MaxAscension; rating.Value = draft.Rating; wins.Value = draft.Wins; losses.Value = draft.Losses;              mode.Select(0); rate.Editable = false; rate.Value = MatchRules.BaseChance(draft, draft.MaxAscension) * 100;          }, 160)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("应用预设", () =>          {              CharacterCards.ApplyTemplate(draft, CharacterCards.Templates[preset.Selected]); role.Text = draft.Role;              ascension.Value = draft.MaxAscension; rating.Value = draft.Rating; wins.Value = draft.Wins; losses.Value = draft.Losses;              mode.Select(0); rate.Editable = false; rate.Value = MatchRules.BaseChance(draft, draft.MaxAscension) * 100;          }, 160)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(create ? "创建并保存" : "保存角色", () =>          {              foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();              GetViewport().GuiGetFocusOwner()?.ReleaseFocus();              if (_multiplayer != null)              {                  string payload;                  try { payload = CharacterCards.Encode(edit); }                  catch (Exception e) { status.Text = e.Message; status.Modulate = new Color("f08080"); return; }                  status.Text = "正在提交，保存成功后关闭。";                  _multiplayer.Send("character-card", text: payload, accepted: () =>                  { _multiplayer.Refresh(); ShowSavedCard(); });                  return;              }              if (CharacterCards.Save(ViewData, edit) is { } error) { status.Text = error; status.Modulate = new Color("f08080"); return; }              ShowSavedCard();          }, 210)`；返回值紧邻使用处：`ArgumentSyntax: Button(create ? "创建并保存" : "保存角色", () =>          {              foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();              GetViewport().GuiGetFocusOwner()?.ReleaseFocus();              if (_multiplayer != null)              {                  string payload;                  try { payload = CharacterCards.Encode(edit); }                  catch (Exception e) { status.Text = e.Message; status.Modulate = new Color("f08080"); return; }                  status.Text = "正在提交，保存成功后关闭。";                  _multiplayer.Send("character-card", text: payload, accepted: () =>                  { _multiplayer.Refresh(); ShowSavedCard(); });                  return;              }              if (CharacterCards.Save(ViewData, edit) is { } error) { status.Text = error; status.Modulate = new Color("f08080"); return; }              ShowSavedCard();          }, 210)`
- `NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`；输入表达式：`CanEditCharacter(data, "")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanEditCharacter(data, "")`
- `NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`；输入表达式：`CanEditCharacter(data, id ?? "")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanEditCharacter(data, id ?? "")`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })) return true;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("请在比赛结束后编辑角色。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("请在比赛结束后编辑角色。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`；输入表达式：`OpenAvatarSettings(data, draft.Avatar, avatar =>          { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenAvatarSettings(data, draft.Avatar, avatar =>          { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait())`
- `NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；输入表达式：`OpenCharacterCard(ViewData, null, incoming)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCharacterCard(ViewData, null, incoming);`
- `NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`；输入表达式：`OpenFilePicker("导入角色卡", [".png"], path =>          {              try              {                  var incoming = CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng);                  if (AvatarImages.Read(incoming.Avatar) == null) throw new InvalidDataException("角色卡头像无法解码。");                  CloseEditor(); OpenCharacterCard(ViewData, null, incoming);              }              catch (Exception e) { if (IsInstanceValid(status)) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("f08080"); } }          })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenFilePicker("导入角色卡", [".png"], path =>          {              try              {                  var incoming = CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng);                  if (AvatarImages.Read(incoming.Avatar) == null) throw new InvalidDataException("角色卡头像无法解码。");                  CloseEditor(); OpenCharacterCard(ViewData, null, incoming);              }              catch (Exception e) { if (IsInstanceValid(status)) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("f08080"); } }          })`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ResetNavigation()`；输入表达式：`ResetNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResetNavigation();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`；输入表达式：`ShowCareerDialog("删除" + draft.PublicName,                  "取消未完成的安排，历史帖子和赛果保留。" + (CharacterDeletion.StarterReplacement(data, draft.Id) is { } replacement                      ? "\n" + replacement.PublicName + "将接替首发，合同待遇不变。" : ""), () =>              {                  if (MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })) return true;                  var error = CharacterDeletion.Delete(data, draft.Id);                  if (error != null) { Notice(error, true); return false; }                  CareerStore.Save(data); _closeCharacterCard?.Invoke(); ResetNavigation(); Render(); return true;              }, "删除角色", compact: true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowCareerDialog("删除" + draft.PublicName,                  "取消未完成的安排，历史帖子和赛果保留。" + (CharacterDeletion.StarterReplacement(data, draft.Id) is { } replacement                      ? "\n" + replacement.PublicName + "将接替首发，合同待遇不变。" : ""), () =>              {                  if (MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })) return true;                  var error = CharacterDeletion.Delete(data, draft.Id);                  if (error != null) { Notice(error, true); return false; }                  CareerStore.Save(data); _closeCharacterCard?.Invoke(); ResetNavigation(); Render(); return true;              }, "删除角色", compact: true)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("-5 偏向嘲讽、挑衅，+5 偏向维护、吹捧。性格决定表达方式。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("-5 偏向嘲讽、挑衅，+5 偏向维护、吹捧。性格决定表达方式。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("保存后应用于当前生涯。", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("保存后应用于当前生涯。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("培养加成另计。累计胜负仅修改档案；真人对局由实际战斗决定。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("培养加成另计。累计胜负仅修改档案；真人对局由实际战斗决定。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("胜率为通过的最高进阶胜率，更高或更低进阶将动态调整", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("胜率为通过的最高进阶胜率，更高或更低进阶将动态调整", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(clubLock ?? "已报名的赛事沿用原阵容。自建俱乐部通过签约招募。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(clubLock ?? "已报名的赛事沿用原阵容。自建俱乐部通过签约招募。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(create ? "创建角色" : "编辑角色", 30, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(create ? "创建角色" : "编辑角色", 30, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(imported != null ? "已读取角色卡，确认资料后创建。" : create ? "从预设开始，填写你的人物档案。" : draft.PublicName, 18, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(imported != null ? "已读取角色卡，确认资料后创建。" : create ? "从预设开始，填写你的人物档案。" : draft.PublicName, 18, _muted)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.CharacterCardEdit.CharacterCardEdit()`；输入表达式：`new CharacterCardEdit { Create = create, Target = draft.Id, Person = draft }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CharacterCardEdit { Create = create, Target = draft.Id, Person = draft }`
- `NationalSpire.CharacterCardPng.Export(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar)`；输入表达式：`CharacterCardPng.Export(data, draft, avatar)`；返回值紧邻使用处：`ArgumentSyntax: CharacterCardPng.Export(data, draft, avatar)`
- `NationalSpire.CharacterCardPng.ReadFile(NationalSpire.CareerData, string, System.Func<byte[], NationalSpire.PlayerAvatar>)`；输入表达式：`CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng)`
- `NationalSpire.CharacterCardPng.WriteDesktop(byte[])`；输入表达式：`CharacterCardPng.WriteDesktop(CharacterCardPng.Export(data, draft, avatar))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterCardPng.WriteDesktop(CharacterCardPng.Export(data, draft, avatar))`
- `NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string)`；输入表达式：`CharacterCards.ApplyTemplate(draft, CharacterCards.Templates[preset.Selected])`；返回值紧邻使用处：`ExpressionStatementSyntax: CharacterCards.ApplyTemplate(draft, CharacterCards.Templates[preset.Selected]);`
- `NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string)`；输入表达式：`CharacterCards.ClubLock(data, draft.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterCards.ClubLock(data, draft.Id)`
- `NationalSpire.CharacterCards.Encode(NationalSpire.CharacterCardEdit)`；输入表达式：`CharacterCards.Encode(edit)`；返回值紧邻使用处：`AssignmentExpressionSyntax: payload = CharacterCards.Encode(edit)`
- `NationalSpire.CharacterCards.New(NationalSpire.CareerData)`；输入表达式：`CharacterCards.New(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: create ? CharacterCards.New(data) : CharacterCards.Read(data, id!)`
- `NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；输入表达式：`CharacterCards.Read(data, id!)`；返回值紧邻使用处：`ConditionalExpressionSyntax: create ? CharacterCards.New(data) : CharacterCards.Read(data, id!)`
- `NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`；输入表达式：`CharacterCards.Save(ViewData, edit)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CharacterCards.Save(ViewData, edit) is { } error`
- `NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`；输入表达式：`CharacterDeletion.Delete(data, draft.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterDeletion.Delete(data, draft.Id)`
- `NationalSpire.CharacterDeletion.StarterReplacement(NationalSpire.CareerData, string)`；输入表达式：`CharacterDeletion.StarterReplacement(data, draft.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CharacterDeletion.StarterReplacement(data, draft.Id) is { } replacement`
- `NationalSpire.CharacterRelationEdit.CharacterRelationEdit()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: edit.Relation ??= new()`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer!.Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer!.Refresh();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer.Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Refresh();`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("character-card", text: payload, accepted: () =>                  { _multiplayer.Refresh(); ShowSavedCard(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("character-card", text: payload, accepted: () =>                  { _multiplayer.Refresh(); ShowSavedCard(); });`
- `NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；输入表达式：`MatchRules.BaseChance(draft, draft.MaxAscension)`；返回值紧邻使用处：`BinaryExpressionSyntax: draft.CustomClearChance ?? MatchRules.BaseChance(draft, draft.MaxAscension)`
- `NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；输入表达式：`MatchRules.BaseChance(draft, draft.MaxAscension)`；返回值紧邻使用处：`BinaryExpressionSyntax: MatchRules.BaseChance(draft, draft.MaxAscension) * 100`
- `NationalSpire.PersonalityLibrary.SelectKind(NationalSpire.PersonalityProfile, string)`；输入表达式：`PersonalityLibrary.SelectKind(draft.Personality, PersonalityLibrary.Kinds[n - 1])`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.SelectKind(draft.Personality, PersonalityLibrary.Kinds[n - 1]);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(draft.Id) ?? new()`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(attitude, "好感", relation.Favour, -100, 100, v => (edit.Relation ??= new()).Favour = (int)v, "CardFavour")`；返回值紧邻使用处：`ExpressionStatementSyntax: Number(attitude, "好感", relation.Favour, -100, 100, v => (edit.Relation ??= new()).Favour = (int)v, "CardFavour");`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(attitudeFields, "态度上界", draft.Personality.AttitudeMax, 1, 5, v => draft.Personality.AttitudeMax = (int)v, "CardAttitudeMax")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(attitudeFields, "态度上界", draft.Personality.AttitudeMax, 1, 5, v => draft.Personality.AttitudeMax = (int)v, "CardAttitudeMax")`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(attitudeFields, "态度下界", draft.Personality.AttitudeMin, -5, -1, v => draft.Personality.AttitudeMin = (int)v, "CardAttitudeMin")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(attitudeFields, "态度下界", draft.Personality.AttitudeMin, -5, -1, v => draft.Personality.AttitudeMin = (int)v, "CardAttitudeMin")`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(numbers, "累计负场", draft.Losses, 0, 1000000, v => draft.Losses = (int)v, "CardLosses")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(numbers, "累计负场", draft.Losses, 0, 1000000, v => draft.Losses = (int)v, "CardLosses")`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(numbers, "累计胜场", draft.Wins, 0, 1000000, v => draft.Wins = (int)v, "CardWins")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(numbers, "累计胜场", draft.Wins, 0, 1000000, v => draft.Wins = (int)v, "CardWins")`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(numbers, "评分", draft.Rating, 0, 100000, v => draft.Rating = (int)v, "CardRating")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(numbers, "评分", draft.Rating, 0, 100000, v => draft.Rating = (int)v, "CardRating")`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(numbers, "最高通关进阶", draft.MaxAscension, 0, 10, v => draft.MaxAscension = (int)v, "CardAscension")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(numbers, "最高通关进阶", draft.MaxAscension, 0, 10, v => draft.MaxAscension = (int)v, "CardAscension")`
- `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`；输入表达式：`Number(probability, "基础通关率 %", (draft.CustomClearChance ?? MatchRules.BaseChance(draft, draft.MaxAscension)) * 100, 0, 100,              v => { if (mode.Selected == 1) draft.CustomClearChance = v / 100; }, "CardChance", .1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: rate = Number(probability, "基础通关率 %", (draft.CustomClearChance ?? MatchRules.BaseChance(draft, draft.MaxAscension)) * 100, 0, 100,              v => { if (mode.Selected == 1) draft.CustomClearChance = v / 100; }, "CardChance", .1)`
- `Pair(Godot.Control)`；输入表达式：`Pair(ability)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Pair(ability)`
- `Pair(Godot.Control)`；输入表达式：`Pair(identity)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Pair(identity)`
- `Pair(Godot.Control)`；输入表达式：`Pair(personality)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Pair(personality)`
- `Section(string)`；输入表达式：`Section("打法与性格")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Section("打法与性格")`
- `Section(string)`；输入表达式：`Section("对你的态度")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Section("对你的态度")`
- `Section(string)`；输入表达式：`Section("身份与归属")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Section("身份与归属")`
- `Section(string)`；输入表达式：`Section("职业与水平")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Section("职业与水平")`
- `SetCharacter(string)`；输入表达式：`SetCharacter(character.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetCharacter(character.Text);`
- `ShowSavedCard()`；输入表达式：`ShowSavedCard()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowSavedCard();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _closeCharacterCard?.Invoke()`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(CharacterCards.Templates, draft.AbilityTemplate.Length > 0 ? draft.AbilityTemplate : draft.Role)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(CharacterCards.Templates, draft.AbilityTemplate.Length > 0 ? draft.AbilityTemplate : draft.Role)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(characterNames, draft.Character)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(characterNames, draft.Character)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(clubs, draft.ClubId)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(clubs, draft.ClubId)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(clubs, draft.SupportedClubId)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(clubs, draft.SupportedClubId)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(EsportsWorld.Countries, draft.Country)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(EsportsWorld.Countries, draft.Country)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(genders, draft.Gender)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(genders, draft.Gender)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "" }.Concat(clubChoices.Select(c => c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "" }.Concat(clubChoices.Select(c => c.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "无固定支持" }.Concat(clubNames.Skip(1))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "无固定支持" }.Concat(clubNames.Skip(1)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "无俱乐部" }.Concat(clubChoices.Select(c => c.Country + " / " + c.Name))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "无俱乐部" }.Concat(clubChoices.Select(c => c.Country + " / " + c.Name)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Esports.Clubs.OrderByDescending(c => c.Id == data.Esports.OwnedClub?.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Clubs.OrderByDescending(c => c.Id == data.Esports.OwnedClub?.ClubId).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CharacterIdentity.Source().Select(c => c.DisplayName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CharacterIdentity.Source().Select(c => c.DisplayName).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`clubChoices.Select(c => c.Country + " / " + c.Name)`；返回值紧邻使用处：`ArgumentSyntax: clubChoices.Select(c => c.Country + " / " + c.Name)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`clubChoices.Select(c => c.Id)`；返回值紧邻使用处：`ArgumentSyntax: clubChoices.Select(c => c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`clubNames.Skip(1)`；返回值紧邻使用处：`ArgumentSyntax: clubNames.Skip(1)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.Esports.Clubs.OrderByDescending(c => c.Id == data.Esports.OwnedClub?.ClubId).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Esports.Clubs.OrderByDescending(c => c.Id == data.Esports.OwnedClub?.ClubId).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { "" }.Concat(clubChoices.Select(c => c.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { "" }.Concat(clubChoices.Select(c => c.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { "无固定支持" }.Concat(clubNames.Skip(1)).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: new[] { "无固定支持" }.Concat(clubNames.Skip(1)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { "无俱乐部" }.Concat(clubChoices.Select(c => c.Country + " / " + c.Name)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { "无俱乐部" }.Concat(clubChoices.Select(c => c.Country + " / " + c.Name)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(draft.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(draft.Id) ?? new()`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(draft.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.HumanIds.Contains(draft.Id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Button>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<VBoxContainer>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<VBoxContainer>()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`Controls(shade).OfType<SpinBox>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();`
- `System.Func<TResult>.Invoke()`；输入表达式：`CharacterIdentity.Source()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CharacterIdentity.Source().Select`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("角色卡头像无法解码。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("角色卡头像无法解码。");`

**赋值（含属性/字段和局部值）：**

- `_characterCardOverlay` = `shade`
- `_closeCharacterCard` = `CloseEditor`
- `(edit.Relation ??= new()).Favour` = `(int)v`
- `(edit.Relation ??= new()).Impression` = `v`
- `(edit.Relation ??= new()).Relationship` = `v`
- `apply.SizeFlagsVertical` = `SizeFlags.ShrinkEnd`
- `Art` = `AvatarImages.Read(draft.Avatar) ?? AutomaticPortrait()`
- `ascension.Value` = `draft.MaxAscension`
- `attitudeMax.Value` = `draft.Personality.AttitudeMax`
- `attitudeMin.Value` = `draft.Personality.AttitudeMin`
- `character.Text` = `characterNames[n]`
- `club.Disabled` = `clubLock != null`
- `Color` = `new(0, 0, 0, .84f)`
- `country.Disabled` = `draft.Id == "player" && clubLock != null`
- `Create` = `create`
- `CustomMinimumSize` = `new(88, 88)`
- `delete.Name` = `"DeleteCustomCharacter"`
- `draft.Avatar` = `avatar`
- `draft.Biography` = `v`
- `draft.ClubId` = `clubs[n]`
- `draft.Country` = `EsportsWorld.Countries[n]`
- `draft.CustomClearChance` = `n == 0 ? null : rate.Value / 100`
- `draft.CustomClearChance` = `v / 100`
- `draft.Gender` = `genders[n]`
- `draft.Handle` = `draft.PublicName`
- `draft.Handle` = `v`
- `draft.Losses` = `(int)v`
- `draft.MaxAscension` = `(int)v`
- `draft.Name` = `v`
- `draft.Personality.AttitudeMax` = `(int)v`
- `draft.Personality.AttitudeMin` = `(int)v`
- `draft.Personality.Curiosity` = `v`
- `draft.Personality.Evidence` = `v`
- `draft.Personality.Humor` = `v`
- `draft.Personality.Kind` = `v`
- `draft.Personality.Loyalty` = `v`
- `draft.Personality.Pressure` = `v`
- `draft.Personality.Social` = `v`
- `draft.Rating` = `(int)v`
- `draft.Role` = `v`
- `draft.Style` = `v`
- `draft.SupportedClubId` = `clubs[n]`
- `draft.Temperament` = `v`
- `draft.Voice` = `v`
- `draft.Wins` = `(int)v`
- `edit.Relation` ??= `new()`
- `entry.Control.FocusMode` = `FocusModeEnum.None`
- `exportButton.Name` = `"ExportCharacterPng"`
- `gender.Disabled` = `draft.CameoId.Length > 0`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `importButton.Disabled` = `!CanEditCharacter(data, "")`
- `importButton.Name` = `"ImportCharacterPng"`
- `kind.Text` = `draft.Personality.Kind`
- `losses.Value` = `draft.Losses`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"CardPortrait"`
- `Name` = `"CharacterCardEditor"`
- `Name` = `"CharacterCardScroll"`
- `payload` = `CharacterCards.Encode(edit)`
- `Person` = `draft`
- `portrait.Art` = `AvatarImages.Read(avatar) ?? AutomaticPortrait()`
- `rate.Editable` = `draft.CustomClearChance.HasValue`
- `rate.Editable` = `false`
- `rate.Editable` = `n == 1`
- `rate.Value` = `MatchRules.BaseChance(draft, draft.MaxAscension) * 100`
- `rate` = `Number(probability, "基础通关率 %", (draft.CustomClearChance ?? MatchRules.BaseChance(draft, draft.MaxAscension)) * 100, 0, 100,              v => { if (mode.Selected == 1) draft.CustomClearChance = v / 100; }, "CardChance", .1)`
- `rating.Value` = `draft.Rating`
- `role.Text` = `draft.Role`
- `session.Message` -= `OnCardMessage`
- `session.Message` += `OnCardMessage`
- `shade.TreeExiting` += `() => session.Message -= OnCardMessage`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `social.Text` = `draft.Personality.Social`
- `status.Modulate` = `Colors.White`
- `status.Modulate` = `new Color("f08080")`
- `status.Name` = `"CardStatus"`
- `status.Text` = `"导出失败：" + e.Message`
- `status.Text` = `"导入失败：" + e.Message`
- `status.Text` = `"角色卡已导出到桌面。分享时请发送原始 PNG 文件。"`
- `status.Text` = `"正在提交，保存成功后关闭。"`
- `status.Text` = `e.Message`
- `status.Text` = `error`
- `subtitle.Text` = `v`
- `Target` = `draft.Id`
- `wins.Value` = `draft.Wins`
- `ZIndex` = `15`

<a id="symbol-3ed4c80d52c7"></a>

## `Controls(Godot.Node) — IEnumerable<Control> Controls(Node node)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Controls(Godot.Node)`](CharacterCardScreen.cs.md#symbol-3ed4c80d52c7)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`Controls(Godot.Node)`](CharacterCardScreen.cs.md#symbol-3ed4c80d52c7)；`Godot.Node.GetChildren(bool)`；`System.Array.Empty<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `Controls(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Controls(Godot.Node)`；输入表达式：`Controls(child)`；返回值紧邻使用处：`ArgumentSyntax: Controls(child)`
- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.GetChildren().SelectMany`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<Control>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: child is Control c ? new[] { c } : Array.Empty<Control>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`(child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: child =>              (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`node.GetChildren().SelectMany(child =>              (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => node.GetChildren().SelectMany(child =>              (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-545b829b2369"></a>

## `AutomaticPortrait() — AvatarArt AutomaticPortrait()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`SetCharacter(string)`](CharacterCardScreen.cs.md#symbol-3d5aa9185f57)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.CameoAssets.ForPerson(string)`](CameoAssets.cs.md#symbol-c95ad2877552)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CameoAssets.ForPerson(string)`；`NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(draft.Character, variation, identityId != "player" && variation % 3 != 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return AvatarAssets.Load(draft.Character, variation, identityId != "player" && variation % 3 != 0);`
- `NationalSpire.CameoAssets.ForPerson(string)`；输入表达式：`CameoAssets.ForPerson(draft.CameoId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CameoAssets.ForPerson(draft.CameoId) is { } cameo`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(world + ":avatar:" + identityId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(world + ":avatar:" + identityId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4d8858dfa3ef"></a>

## `Section(string) — VBoxContainer Section(string title)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 18);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pages.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: pages.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(button);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Visible = index == 0 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Visible = index == 0 }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(title, () =>              {                  for (int i = 0; i < sections.Count; i++) { sections[i].Visible = i == index; tabButtons[i].Modulate = i == index ? CareerVisuals.Teal : Colors.White; }                  scroll.ScrollVertical = 0;              }, 170)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(title, () =>              {                  for (int i = 0; i < sections.Count; i++) { sections[i].Visible = i == index; tabButtons[i].Modulate = i == index ? CareerVisuals.Teal : Colors.White; }                  scroll.ScrollVertical = 0;              }, 170)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`sections.Add(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: sections.Add(content);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`tabButtons.Add(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabButtons.Add(button);`

**赋值（含属性/字段和局部值）：**

- `button.Modulate` = `CareerVisuals.Teal`
- `scroll.ScrollVertical` = `0`
- `sections[i].Visible` = `i == index`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `tabButtons[i].Modulate` = `i == index ? CareerVisuals.Teal : Colors.White`
- `Visible` = `index == 0`

<a id="symbol-49ab81d66251"></a>

## `Field(Godot.Control, string) — VBoxContainer Field(Control parent, string label)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choice(Godot.Control, string, string[], int, System.Action<int>, string?)`](CharacterCardScreen.cs.md#symbol-0ea19aaa6aaf)；[`Line(Godot.Control, string, string, System.Action<string>, string?)`](CharacterCardScreen.cs.md#symbol-7b4eec980805)；[`Memo(Godot.Control, string, string, System.Action<string>, string?)`](CharacterCardScreen.cs.md#symbol-203ab71fae9d)；[`Number(Godot.Control, string, double, double, double, System.Action<double>, string, double)`](CharacterCardScreen.cs.md#symbol-5a856ec57564)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 8);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(label, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(label, 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(box);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(label, 17, _muted)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-f793d19facd1"></a>

## `Pair(Godot.Control) — GridContainer Pair(Control parent)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 18);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(grid);`

**赋值（含属性/字段和局部值）：**

- `Columns` = `2`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-7b4eec980805"></a>

## `Line(Godot.Control, string, string, System.Action<string>, string?) — LineEdit Line(Control parent, string label, string value, Action<string> change, string? name = null)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`Field(Godot.Control, string)`](CharacterCardScreen.cs.md#symbol-49ab81d66251)；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Field(Godot.Control, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(Godot.Control, string)`；输入表达式：`Field(parent, label)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Field(parent, label)`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Text = value, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Text = value, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(input);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `System.Action<T>.Invoke(T)`；输入表达式：`change(value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => change(value)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 46)`
- `input.Name` = `name`
- `input.TextChanged` += `value => change(value)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-0ea19aaa6aaf"></a>

## `Choice(Godot.Control, string, string[], int, System.Action<int>, string?) — OptionButton Choice(Control parent, string label, string[] labels, int selected, Action<int> change, string? name = null)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`Field(Godot.Control, string)`](CharacterCardScreen.cs.md#symbol-49ab81d66251)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Field(Godot.Control, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(Godot.Control, string)`；输入表达式：`Field(parent, label)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Field(parent, label)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(input);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`input.AddItem(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddItem(text);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.OptionButton.Select(int)`；输入表达式：`input.Select(Math.Max(0, selected))`；返回值紧邻使用处：`ExpressionStatementSyntax: input.Select(Math.Max(0, selected));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `System.Action<T>.Invoke(T)`；输入表达式：`change((int)n)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: n => change((int)n)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, selected)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, selected)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 46)`
- `FitToLongestItem` = `false`
- `input.ItemSelected` += `n => change((int)n)`
- `input.Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-5a856ec57564"></a>

## `Number(Godot.Control, string, double, double, double, System.Action<double>, string, double) — SpinBox Number(Control parent, string label, double value, double min, double max, Action<double> change, string name, double step = 1)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`Field(Godot.Control, string)`](CharacterCardScreen.cs.md#symbol-49ab81d66251)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Field(Godot.Control, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(Godot.Control, string)`；输入表达式：`Field(parent, label)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Field(parent, label)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(input);`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { Name = name, MinValue = min, MaxValue = max, Step = step, Value = value, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { Name = name, MinValue = min, MaxValue = max, Step = step, Value = value, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `System.Action<T>.Invoke(T)`；输入表达式：`change(value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => change(value)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 46)`
- `input.ValueChanged` += `value => change(value)`
- `MaxValue` = `max`
- `MinValue` = `min`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `step`
- `Value` = `value`

<a id="symbol-203ab71fae9d"></a>

## `Memo(Godot.Control, string, string, System.Action<string>, string?) — TextEdit Memo(Control parent, string label, string value, Action<string> change, string? name = null)`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`Field(Godot.Control, string)`](CharacterCardScreen.cs.md#symbol-49ab81d66251)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Field(Godot.Control, string)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(Godot.Control, string)`；输入表达式：`Field(parent, label)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Field(parent, label)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`input.AddThemeColorOverride("font_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeColorOverride("font_color", _ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`input.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`input.AddThemeStyleboxOverride("focus", CareerVisuals.Box("10232e", "69bcb3", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeStyleboxOverride("focus", CareerVisuals.Box("10232e", "69bcb3", 8, 14));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1b27", "304e5d", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1b27", "304e5d", 8, 14));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`field.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: field.AddChild(input);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = value, CustomMinimumSize = new(0, 96), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = value, CustomMinimumSize = new(0, 96), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 96)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 96)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0c1b27", "304e5d", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0c1b27", "304e5d", 8, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10232e", "69bcb3", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10232e", "69bcb3", 8, 14)`
- `System.Action<T>.Invoke(T)`；输入表达式：`change(input.Text)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => change(input.Text)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 96)`
- `input.Name` = `name`
- `input.TextChanged` += `() => change(input.Text)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-3d5aa9185f57"></a>

## `SetCharacter(string) — void SetCharacter(string value)`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`AutomaticPortrait()`](CharacterCardScreen.cs.md#symbol-545b829b2369)

**字段、属性、事件及方法组引用：** `AutomaticPortrait()`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.CareerPerson.Character`；`NationalSpire.PlayerAvatar.Source`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AutomaticPortrait()`；输入表达式：`AutomaticPortrait()`；返回值紧邻使用处：`AssignmentExpressionSyntax: portrait.Art = AutomaticPortrait()`

**赋值（含属性/字段和局部值）：**

- `draft.Character` = `value`
- `portrait.Art` = `AutomaticPortrait()`

<a id="symbol-76223a66c27b"></a>

## `OnCardMessage(string, bool) — void OnCardMessage(string message, bool failure)`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Color.Color(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f08080")`；返回值紧邻使用处：`AssignmentExpressionSyntax: status.Modulate = new Color("f08080")`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(status)`；返回值紧邻使用处：`BinaryExpressionSyntax: failure && IsInstanceValid(status)`

**赋值（含属性/字段和局部值）：**

- `status.Modulate` = `new Color("f08080")`
- `status.Text` = `message`

<a id="symbol-172c824e283a"></a>

## `CloseEditor() — void CloseEditor()`

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`ShowSavedCard()`](CharacterCardScreen.cs.md#symbol-3b5002c5e2d5)

**调用：** `Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`NationalSpire.CareerScreen._characterCardOverlay`；`NationalSpire.CareerScreen._closeCharacterCard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`previousFocus.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`previousFocus.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: previousFocus.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(entry.Control)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(entry.Control) && !entry.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(previousFocus)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(shade)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(shade)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`entry.Control.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !entry.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`previousFocus.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !previousFocus.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`shade.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(shade) || shade.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`previousFocus.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree()`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_characterCardOverlay` = `null`
- `_closeCharacterCard` = `null`
- `entry.Control.FocusMode` = `entry.Mode`

<a id="symbol-3b5002c5e2d5"></a>

## `ShowSavedCard() — void ShowSavedCard()`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`CloseEditor()`](CharacterCardScreen.cs.md#symbol-172c824e283a)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)

**字段、属性、事件及方法组引用：** `CloseEditor()`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CharacterCardEdit.Target`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CloseEditor()`；输入表达式：`CloseEditor()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseEditor();`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(edit.Target)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPerson(edit.Target);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(position, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(position, _renderVersion)`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(position, _renderVersion)`
