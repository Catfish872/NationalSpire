# DuelRecorder.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A0D9261B696CBA7F196D542DAEBAD5823249AA953468C52E5BA8158A0A1472E9`。来源：[源码](../../DuelRecorder.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DuelRecorder`、`NationalSpire.DuelRecorder.Round`、`NationalSpire.DuelRecorder.Play`。

字段、事件及初始值（源码原样）：

```csharp
private readonly RunState _run;
private readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer _choices=RunManager.Instance.PlayerChoiceSynchronizer;
private readonly DuelReport _report;
private readonly DuelReplay _replay = new();
private readonly Dictionary<DuelCardFace,int> _faceIndices = [];
private readonly List<Player> _players = [];
private readonly Dictionary<Creature, int> _owners = [];
private readonly SortedDictionary<int, Round> _rounds = [];
private readonly Dictionary<CardPlay, Play> _started = new(ReferenceEqualityComparer.Instance);
private readonly CombatHistory _history = CombatManager.Instance.History;
private int _cursor;
internal readonly DuelRound Data = new() { Number = number };
internal readonly List<Play> Plays = [];
internal bool Knockout;
internal readonly int Actor = actor;
internal readonly string Id = id, Name = name, Target = target;
private DuelCardFace? _face;
internal readonly bool Generated = generated;
internal bool Finished, HasChoice;
internal uint? TargetId;
private readonly List<HashSet<CardModel>> _originalCards = [];
```

<a id="symbol-2152e5dd5daf"></a>

## `NationalSpire.DuelRecorder.Play.RecordedFace — internal DuelCardFace RecordedFace`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`](DuelRecorder.cs.md#symbol-e43bc219adb5)

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`；`NationalSpire.DuelRecorder.Play._face`；`NationalSpire.DuelRecorder.Play.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`；输入表达式：`ArchiveFace(Id,snapshot)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _face ??= ArchiveFace(Id,snapshot)`

**赋值（含属性/字段和局部值）：**

- `_face` ??= `ArchiveFace(Id,snapshot)`

<a id="symbol-f88df75f8f4d"></a>

## `NationalSpire.DuelRecorder.Play.Face — internal string Face`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DuelCardFace.Text`；`NationalSpire.DuelRecorder.Play.RecordedFace`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-33e6292045f0"></a>

## `NationalSpire.DuelRecorder.DuelRecorder(MegaCrit.Sts2.Core.Runs.RunState, bool) — internal DuelRecorder(RunState run, bool opponentOpens)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-f78a44bdbc8e)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`](DuelRecorder.cs.md#symbol-f175b873a9da)；`NationalSpire.DuelReport.DuelReport()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Data`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.DuelRecorder._choices`；`NationalSpire.DuelRecorder._cursor`；`NationalSpire.DuelRecorder._history`；`NationalSpire.DuelRecorder._report`；`NationalSpire.DuelRecorder._run`；`NationalSpire.DuelRecorder.PlayerChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult)`；`NationalSpire.DuelRecorder.Read()`；`NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`；`NationalSpire.DuelReport.OpponentOpens`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(CareerStore.Data)`；返回值紧邻使用处：`BinaryExpressionSyntax: member?.Name ?? CareerEngine.Name(CareerStore.Data)`
- `NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`；输入表达式：`Register(player, member?.Name ?? CareerEngine.Name(CareerStore.Data), player.Deck.Cards, false, member?.PersonId ?? "player")`；返回值紧邻使用处：`ExpressionStatementSyntax: Register(player, member?.Name ?? CareerEngine.Name(CareerStore.Data), player.Deck.Cards, false, member?.PersonId ?? "player");`
- `NationalSpire.DuelReport.DuelReport()`；输入表达式：`new() { OpponentOpens = opponentOpens }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _report = new() { OpponentOpens = opponentOpens }`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`_history.Entries.Count()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _cursor = _history.Entries.Count()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Members.FirstOrDefault(m => m.SteamId == player.NetId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: world?.Members.FirstOrDefault(m => m.SteamId == player.NetId)`

**赋值（含属性/字段和局部值）：**

- `_choices.PlayerChoiceReceived` += `PlayerChoice`
- `_cursor` = `_history.Entries.Count()`
- `_history.Changed` += `Read`
- `_report` = `new() { OpponentOpens = opponentOpens }`
- `_run` = `run`
- `OpponentOpens` = `opponentOpens`

<a id="symbol-6f69544656aa"></a>

## `NationalSpire.DuelRecorder.SelectDeck<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, int>, System.Func<T, int>, System.Func<T, MegaCrit.Sts2.Core.Models.ModelId?>) — internal static IEnumerable<T> SelectDeck<T>(IEnumerable<T> cards, Func<T,int> upgrade, Func<T,int> floor, Func<T,ModelId?> id)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`](DuelRecorder.cs.md#symbol-f175b873a9da)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-3b790044a598)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor).DistinctBy(id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor).DistinctBy(id).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.Where(c => id(c) != null).OrderByDescending(upgrade)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor).DistinctBy(id).Take(6)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor).DistinctBy(id).Take(6)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Where(c => id(c) != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c => id(c) != null).OrderByDescending`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`id(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: id(c) != null`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c => id(c) != null).OrderByDescending(upgrade).ThenByDescending(floor).DistinctBy`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cbb6f3d99bf9"></a>

## `NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel) — private static SerializableCard? Snapshot(CardModel card)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Read()`](DuelRecorder.cs.md#symbol-1f3b4be880f6)；[`NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`](DuelRecorder.cs.md#symbol-f175b873a9da)

**调用：** `MegaCrit.Sts2.Core.Models.CardModel.ToSerializable()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.ToSerializable()`；输入表达式：`card.ToSerializable()`；返回值紧邻使用处：`ReturnStatementSyntax: return card.ToSerializable();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3056ade97b7"></a>

## `NationalSpire.DuelRecorder.CardFace(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?) — internal static string CardFace(SerializableCard? snapshot)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`](DuelRecorder.cs.md#symbol-e43bc219adb5)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-3b790044a598)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard)`；`MegaCrit.Sts2.Core.Models.CardModel.GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard)`；输入表达式：`CardModel.FromSerializable(snapshot)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CardModel.FromSerializable(snapshot)`
- `MegaCrit.Sts2.Core.Models.CardModel.GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`face.GetDescriptionForPile(PileType.None)`；返回值紧邻使用处：`BinaryExpressionSyntax: face.Title + "：" + face.GetDescriptionForPile(PileType.None)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(face.Title + "：" + face.GetDescriptionForPile(PileType.None))`；返回值紧邻使用处：`ReturnStatementSyntax: return GameText.Plain(face.Title + "：" + face.GetDescriptionForPile(PileType.None));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e43bc219adb5"></a>

## `NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?) — private static DuelCardFace ArchiveFace(string id,SerializableCard? snapshot)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Play.RecordedFace`](DuelRecorder.cs.md#symbol-2152e5dd5daf)；[`NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`](DuelRecorder.cs.md#symbol-f175b873a9da)

**调用：** [`NationalSpire.DuelRecorder.CardFace(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`](DuelRecorder.cs.md#symbol-c3056ade97b7)；`NationalSpire.DuelCardFace.DuelCardFace(string, string, int?, string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder.CardFace(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelCardFace.DuelCardFace(string, string, int?, string?)`；输入表达式：`new(id,CardFace(snapshot),snapshot?.CurrentUpgradeLevel,state)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(id,CardFace(snapshot),snapshot?.CurrentUpgradeLevel,state);`
- `NationalSpire.DuelRecorder.CardFace(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`；输入表达式：`CardFace(snapshot)`；返回值紧邻使用处：`ArgumentSyntax: CardFace(snapshot)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(snapshot)`；返回值紧邻使用处：`AssignmentExpressionSyntax: state=System.Text.Json.JsonSerializer.Serialize(snapshot)`

**赋值（含属性/字段和局部值）：**

- `state` = `System.Text.Json.JsonSerializer.Serialize(snapshot)`

<a id="symbol-f175b873a9da"></a>

## `NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?) — internal void Register(Player player, string name, IEnumerable<CardModel> deck, bool opponent, string? personId)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.DuelRecorder(MegaCrit.Sts2.Core.Runs.RunState, bool)`](DuelRecorder.cs.md#symbol-33e6292045f0)；[`NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-f78a44bdbc8e)

**调用：** [`NationalSpire.CharacterIdentity.OriginalName(string)`](CharacterIdentity.cs.md#symbol-94292e3754dd)；[`NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`](DuelRecorder.cs.md#symbol-e43bc219adb5)；[`NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace)`](DuelRecorder.cs.md#symbol-05556a56fbe8)；[`NationalSpire.DuelRecorder.SelectDeck<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, int>, System.Func<T, int>, System.Func<T, MegaCrit.Sts2.Core.Models.ModelId?>)`](DuelRecorder.cs.md#symbol-6f69544656aa)；[`NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel)`](DuelRecorder.cs.md#symbol-cbb6f3d99bf9)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.DuelParticipant.DuelParticipant()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CharacterIdentity.OriginalName(string)`；`NationalSpire.DuelCardFace.Text`；`NationalSpire.DuelParticipant.Character`；`NationalSpire.DuelParticipant.Deck`；`NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelParticipant.OpenHp`；`NationalSpire.DuelParticipant.OpenMax`；`NationalSpire.DuelParticipant.Opponent`；`NationalSpire.DuelParticipant.PersonId`；`NationalSpire.DuelRecorder._originalCards`；`NationalSpire.DuelRecorder._owners`；`NationalSpire.DuelRecorder._players`；`NationalSpire.DuelRecorder._replay`；`NationalSpire.DuelRecorder._report`；`NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`；`NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace)`；`NationalSpire.DuelRecorder.SelectDeck<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, int>, System.Func<T, int>, System.Func<T, MegaCrit.Sts2.Core.Models.ModelId?>)`；`NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.DuelReplay.Decks`；`NationalSpire.DuelReplay.Faces`；`NationalSpire.DuelReport.People`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`player.Character.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: player.Character.Id.ToString()`
- `NationalSpire.CharacterIdentity.OriginalName(string)`；输入表达式：`CharacterIdentity.OriginalName(player.Character.Id.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id)`
- `NationalSpire.DuelParticipant.DuelParticipant()`；输入表达式：`new() {             PersonId = personId ?? "", Name = displayName, Opponent = opponent,             Character = CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id),             OpenHp = player.Creature.CurrentHp, OpenMax = player.Creature.MaxHp,             Deck = SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()         }`；返回值紧邻使用处：`ArgumentSyntax: new() {             PersonId = personId ?? "", Name = displayName, Opponent = opponent,             Character = CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id),             OpenHp = player.Creature.CurrentHp, OpenMax = player.Creature.MaxHp,             Deck = SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()         }`
- `NationalSpire.DuelRecorder.ArchiveFace(string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?)`；输入表达式：`ArchiveFace(card.Id.Entry,Snapshot(card))`；返回值紧邻使用处：`ArgumentSyntax: ArchiveFace(card.Id.Entry,Snapshot(card))`
- `NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace)`；输入表达式：`FaceIndex(ArchiveFace(card.Id.Entry,Snapshot(card)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: index = FaceIndex(ArchiveFace(card.Id.Entry,Snapshot(card)))`
- `NationalSpire.DuelRecorder.SelectDeck<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, int>, System.Func<T, int>, System.Func<T, MegaCrit.Sts2.Core.Models.ModelId?>)`；输入表达式：`SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select`
- `NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Snapshot(card)`；返回值紧邻使用处：`ArgumentSyntax: Snapshot(card)`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(player.Character.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<CardModel,int>(ReferenceEqualityComparer.Instance)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<CardModel,int>(ReferenceEqualityComparer.Instance)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`_owners.TryAdd(player.Creature, _players.Count)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_owners.TryAdd(player.Creature, _players.Count)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`faces.TryGetValue(card, out int index)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !faces.TryGetValue(card, out int index)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_report.People.Any(p=>p.Name==displayName)`；返回值紧邻使用处：`ForStatementSyntax: for(int n=2;_report.People.Any(p=>p.Name==displayName);n++)displayName=name+" "+n;`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`cards.ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: cards.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`deck.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = deck.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Deck = SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_originalCards.Add(cards.ToHashSet())`；返回值紧邻使用处：`ExpressionStatementSyntax: _originalCards.Add(cards.ToHashSet());`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_players.Add(player)`；返回值紧邻使用处：`ExpressionStatementSyntax: _players.Add(player);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_replay.Decks.Add(deckIndices)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replay.Decks.Add(deckIndices);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_report.People.Add(new() {             PersonId = personId ?? "", Name = displayName, Opponent = opponent,             Character = CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id),             OpenHp = player.Creature.CurrentHp, OpenMax = player.Creature.MaxHp,             Deck = SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()         })`；返回值紧邻使用处：`ExpressionStatementSyntax: _report.People.Add(new() {             PersonId = personId ?? "", Name = displayName, Opponent = opponent,             Character = CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id),             OpenHp = player.Creature.CurrentHp, OpenMax = player.Creature.MaxHp,             Deck = SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()         });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`deckIndices.Add(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: deckIndices.Add(index);`
- `System.Collections.Generic.List<T>.List(int)`；输入表达式：`new List<int>(cards.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<int>(cards.Count)`

**赋值（含属性/字段和局部值）：**

- `Character` = `CharacterIdentity.OriginalName(player.Character.Id.ToString()) ?? PlayerArchive.CharacterName(player.Character.Id)`
- `Deck` = `SelectDeck(cards,c=>c.CurrentUpgradeLevel,c=>c.FloorAddedToDeck??0,c=>c.Id).Select(c=>_replay.Faces[faces[c]]).Where(f=>f.Text.Length>0).ToList()`
- `displayName` = `name+" "+n`
- `faces[card]` = `index = FaceIndex(ArchiveFace(card.Id.Entry,Snapshot(card)))`
- `index` = `FaceIndex(ArchiveFace(card.Id.Entry,Snapshot(card)))`
- `Name` = `displayName`
- `OpenHp` = `player.Creature.CurrentHp`
- `OpenMax` = `player.Creature.MaxHp`
- `Opponent` = `opponent`
- `PersonId` = `personId ?? ""`

<a id="symbol-05556a56fbe8"></a>

## `NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace) — private int FaceIndex(DuelCardFace face)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Finish(bool)`](DuelRecorder.cs.md#symbol-2f331da503dd)；[`NationalSpire.DuelRecorder.Register(MegaCrit.Sts2.Core.Entities.Players.Player, string, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, bool, string?)`](DuelRecorder.cs.md#symbol-f175b873a9da)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder._faceIndices`；`NationalSpire.DuelRecorder._replay`；`NationalSpire.DuelReplay.Faces`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_faceIndices.Add(face,index=_replay.Faces.Count)`；返回值紧邻使用处：`ExpressionStatementSyntax: _faceIndices.Add(face,index=_replay.Faces.Count);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_faceIndices.TryGetValue(face,out int index)`；返回值紧邻使用处：`IfStatementSyntax: if (_faceIndices.TryGetValue(face,out int index)) return index;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_replay.Faces.Add(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: _replay.Faces.Add(face);`

**赋值（含属性/字段和局部值）：**

- `index` = `_replay.Faces.Count`

<a id="symbol-4393dcad1bbc"></a>

## `NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?) — private int Owner(Creature? actor)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Block(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int)`](DuelRecorder.cs.md#symbol-b8b26f3b4e34)；[`NationalSpire.DuelRecorder.Declare(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, bool)`](DuelRecorder.cs.md#symbol-38f735caf04b)；[`NationalSpire.DuelRecorder.Read()`](DuelRecorder.cs.md#symbol-1f3b4be880f6)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder._owners`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_owners.TryGetValue(actor,out int index)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _owners.TryGetValue(actor,out int index) ? index :         actor.PetOwner is {} owner ? _owners.GetValueOrDefault(owner.Creature,-1) : -1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_owners.GetValueOrDefault(owner.Creature,-1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: actor.PetOwner is {} owner ? _owners.GetValueOrDefault(owner.Creature,-1) : -1`

**赋值（含属性/字段和局部值）：**


<a id="symbol-38a5eb3de20d"></a>

## `NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private Round Current(Creature actor)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Block(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int)`](DuelRecorder.cs.md#symbol-b8b26f3b4e34)；[`NationalSpire.DuelRecorder.Declare(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, bool)`](DuelRecorder.cs.md#symbol-38f735caf04b)；[`NationalSpire.DuelRecorder.Read()`](DuelRecorder.cs.md#symbol-1f3b4be880f6)

**调用：** `NationalSpire.DuelRecorder.Round.Round(int)`；`NationalSpire.DuelTurnTotals.DuelTurnTotals()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.SortedDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder._players`；`NationalSpire.DuelRecorder._rounds`；`NationalSpire.DuelRecorder.Round.Data`；`NationalSpire.DuelRound.Totals`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.Round.Round(int)`；输入表达式：`new(n)`；返回值紧邻使用处：`AssignmentExpressionSyntax: round=new(n)`
- `NationalSpire.DuelTurnTotals.DuelTurnTotals()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`round.Data.Totals.Add(new())`；返回值紧邻使用处：`ExpressionStatementSyntax: round.Data.Totals.Add(new());`
- `System.Collections.Generic.SortedDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_rounds.TryGetValue(n,out var round)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_rounds.TryGetValue(n,out var round)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,actor.CombatState?.RoundNumber ?? 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(1,actor.CombatState?.RoundNumber ?? 1)`

**赋值（含属性/字段和局部值）：**

- `_rounds[n]` = `round=new(n)`
- `round` = `new(n)`

<a id="symbol-38f735caf04b"></a>

## `NationalSpire.DuelRecorder.Declare(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, bool) — internal void Declare(Creature actor,int amount,bool doom)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`](LeagueEffectTargets.cs.md#symbol-ebb77af45201)；[`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)

**调用：** [`NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](DuelRecorder.cs.md#symbol-38a5eb3de20d)；[`NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](DuelRecorder.cs.md#symbol-4393dcad1bbc)

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.DuelRecorder.Round.Data`；`NationalSpire.DuelRound.Totals`；`NationalSpire.DuelTurnTotals.Attack`；`NationalSpire.DuelTurnTotals.DoomIntent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Current(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Current(actor).Data`
- `NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Owner(actor)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Owner(actor) is var index`

**赋值（含属性/字段和局部值）：**

- `total.Attack` += `amount`
- `total.DoomIntent` += `amount`

<a id="symbol-b8b26f3b4e34"></a>

## `NationalSpire.DuelRecorder.Block(MegaCrit.Sts2.Core.Entities.Creatures.Creature, int) — internal void Block(Creature actor,int amount)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`](LeagueNativeMatch.cs.md#symbol-bea557065b97)

**调用：** [`NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](DuelRecorder.cs.md#symbol-38a5eb3de20d)；[`NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](DuelRecorder.cs.md#symbol-4393dcad1bbc)

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.DuelRecorder.Round.Data`；`NationalSpire.DuelRound.Totals`；`NationalSpire.DuelTurnTotals.Block`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Current(actor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Current(actor).Data`
- `NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Owner(actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Owner(actor)`

**赋值（含属性/字段和局部值）：**

- `Current(actor).Data.Totals[index].Block` += `amount`

<a id="symbol-1f3b4be880f6"></a>

## `NationalSpire.DuelRecorder.Read() — private void Read()`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Finish(bool)`](DuelRecorder.cs.md#symbol-2f331da503dd)

**调用：** [`NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](DuelRecorder.cs.md#symbol-38a5eb3de20d)；[`NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](DuelRecorder.cs.md#symbol-4393dcad1bbc)；[`NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel)`](DuelRecorder.cs.md#symbol-cbb6f3d99bf9)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`NationalSpire.DuelRecorder.Play.Play(int, string, string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?, string, bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DuelParticipant.Name`；`NationalSpire.DuelRecorder._cursor`；`NationalSpire.DuelRecorder._history`；`NationalSpire.DuelRecorder._originalCards`；`NationalSpire.DuelRecorder._owners`；`NationalSpire.DuelRecorder._report`；`NationalSpire.DuelRecorder._run`；`NationalSpire.DuelRecorder._started`；`NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.DuelRecorder.Play.Actor`；`NationalSpire.DuelRecorder.Play.Finished`；`NationalSpire.DuelRecorder.Play.TargetId`；`NationalSpire.DuelRecorder.Round.Data`；`NationalSpire.DuelRecorder.Round.Knockout`；`NationalSpire.DuelRecorder.Round.Plays`；`NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.DuelReport.People`；`NationalSpire.DuelRound.Totals`；`NationalSpire.DuelTurnTotals.Block`；`NationalSpire.DuelTurnTotals.Cards`；`NationalSpire.DuelTurnTotals.Damage`；`NationalSpire.DuelTurnTotals.Doom`；`NationalSpire.DuelTurnTotals.Draw`；`NationalSpire.DuelTurnTotals.Energy`；`NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.Current(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`Current(e.Actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Current(e.Actor)`
- `NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Owner(doom.Applier)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Owner(doom.Applier) is var giver`
- `NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Owner(e.Actor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Owner(e.Actor)`
- `NationalSpire.DuelRecorder.Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`Owner(hit.Dealer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Owner(hit.Dealer)`
- `NationalSpire.DuelRecorder.Play.Play(int, string, string, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard?, string, bool)`；输入表达式：`new Play(actor,play.Card.Id.Entry,name,Snapshot(play.Card),                         play.Target is {} target ? (_owners.TryGetValue(target,out var who)?_report.People[who].Name:target.Name) : "",                         play.Card.DeckVersion==null && !_originalCards[actor].Contains(play.Card)){TargetId=play.Target?.CombatId}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Play(actor,play.Card.Id.Entry,name,Snapshot(play.Card),                         play.Target is {} target ? (_owners.TryGetValue(target,out var who)?_report.People[who].Name:target.Name) : "",                         play.Card.DeckVersion==null && !_originalCards[actor].Contains(play.Card)){TargetId=play.Target?.CombatId}`
- `NationalSpire.DuelRecorder.Snapshot(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Snapshot(play.Card)`；返回值紧邻使用处：`ArgumentSyntax: Snapshot(play.Card)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(play.Card.Title)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GameText.Plain(play.Card.Title)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_owners.ContainsKey(hit.Receiver)`；返回值紧邻使用处：`BinaryExpressionSyntax: hit.Result.WasTargetKilled && _owners.ContainsKey(hit.Receiver)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey, out TValue)`；输入表达式：`_started.Remove(end.CardPlay,out var finished)`；返回值紧邻使用处：`WhenClauseSyntax: when _started.Remove(end.CardPlay,out var finished)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_owners.TryGetValue(target,out var who)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _owners.TryGetValue(target,out var who)?_report.People[who].Name:target.Name`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_originalCards[actor].Contains(play.Card)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_originalCards[actor].Contains(play.Card)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_history.Entries.ToList()`；返回值紧邻使用处：`BinaryExpressionSyntax: _history.Entries as IReadOnlyList<CombatHistoryEntry> ?? _history.Entries.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`round.Plays.Add(step)`；返回值紧邻使用处：`ExpressionStatementSyntax: round.Plays.Add(step);`

**赋值（含属性/字段和局部值）：**

- `_cursor` = `0`
- `_started[play]` = `step`
- `finished.Finished` = `true`
- `round.Data.Totals[actor].Block` += `hit.Result.BlockedDamage`
- `round.Data.Totals[actor].Energy` += `energy.Amount`
- `round.Data.Totals[dealer].Damage` += `hit.Result.UnblockedDamage`
- `round.Data.Totals[giver].Doom` += `(int)doom.Amount`
- `round.Knockout` = `true`
- `TargetId` = `play.Target?.CombatId`

<a id="symbol-93d5f74698d7"></a>

## `NationalSpire.DuelRecorder.Choice(MegaCrit.Sts2.Core.Entities.Players.Player) — internal void Choice(Player player)`

来源：源码第 167 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.PlayerChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult)`](DuelRecorder.cs.md#symbol-6d5d3c65c812)；[`NationalSpire.LeagueNativeMatch.RecordSelection(MegaCrit.Sts2.Core.Entities.Players.Player)`](LeagueNativeMatch.cs.md#symbol-e6f333245e4e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder._started`；`NationalSpire.DuelRecorder.Play.HasChoice`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `play.HasChoice` = `true`

<a id="symbol-6d5d3c65c812"></a>

## `NationalSpire.DuelRecorder.PlayerChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult) — private void PlayerChoice(Player player,uint id,MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult result)`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DuelRecorder.Choice(MegaCrit.Sts2.Core.Entities.Players.Player)`](DuelRecorder.cs.md#symbol-93d5f74698d7)

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder.Choice(MegaCrit.Sts2.Core.Entities.Players.Player)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelRecorder.Choice(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`Choice(player)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Choice(player)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6720ee798acf"></a>

## `NationalSpire.DuelRecorder.Sequence(System.Collections.Generic.List<NationalSpire.DuelRecorder.Play>) — private List<DuelSequenceRun> Sequence(List<Play> plays)`

来源：源码第 171 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Finish(bool)`](DuelRecorder.cs.md#symbol-2f331da503dd)

**调用：** [`NationalSpire.LeagueSolverLink.ReportRuns(int[])`](LeagueSolverLink.cs.md#symbol-d9be4df14cd3)；`NationalSpire.DuelCardStep.DuelCardStep(int, string, string, bool)`；`NationalSpire.DuelSequenceRun.DuelSequenceRun(System.Collections.Generic.List<NationalSpire.DuelCardStep>, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.GetRange(int, int)`

**字段、属性、事件及方法组引用：** `(int Start, int Period, int Count).Count`；`(int Start, int Period, int Count).Period`；`(int Start, int Period, int Count).Start`；`NationalSpire.DuelRecorder.Play.Actor`；`NationalSpire.DuelRecorder.Play.Face`；`NationalSpire.DuelRecorder.Play.Generated`；`NationalSpire.DuelRecorder.Play.HasChoice`；`NationalSpire.DuelRecorder.Play.Id`；`NationalSpire.DuelRecorder.Play.Name`；`NationalSpire.DuelRecorder.Play.Target`；`NationalSpire.DuelRecorder.Play.TargetId`；`NationalSpire.LeagueSolverLink.ReportRuns(int[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DuelCardStep.DuelCardStep(int, string, string, bool)`；输入表达式：`new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)`
- `NationalSpire.DuelSequenceRun.DuelSequenceRun(System.Collections.Generic.List<NationalSpire.DuelCardStep>, int)`；输入表达式：`new DuelSequenceRun(             plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: run=>new DuelSequenceRun(             plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count)`
- `NationalSpire.LeagueSolverLink.ReportRuns(int[])`；输入表达式：`LeagueSolverLink.ReportRuns(actions)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueSolverLink.ReportRuns(actions).Select`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<(int,string,string,uint?,bool),int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<(int,string,string,uint?,bool),int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`keys.TryGetValue(key,out int id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !keys.TryGetValue(key,out int id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`LeagueSolverLink.ReportRuns(actions).Select(run=>new DuelSequenceRun(             plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueSolverLink.ReportRuns(actions).Select(run=>new DuelSequenceRun(             plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`plays.Select(p=>{             if(p.HasChoice || p.Face.Length==0)return next++;             var key=(p.Actor,p.Id,p.Face,p.TargetId,p.Generated);             if(!keys.TryGetValue(key,out int id))keys[key]=id=next++;             return id;         })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plays.Select(p=>{             if(p.HasChoice || p.Face.Length==0)return next++;             var key=(p.Actor,p.Id,p.Face,p.TargetId,p.Generated);             if(!keys.TryGetValue(key,out int id))keys[key]=id=next++;             return id;         }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`plays.Select(p=>{             if(p.HasChoice || p.Face.Length==0)return next++;             var key=(p.Actor,p.Id,p.Face,p.TargetId,p.Generated);             if(!keys.TryGetValue(key,out int id))keys[key]=id=next++;             return id;         }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =plays.Select(p=>{             if(p.HasChoice || p.Face.Length==0)return next++;             var key=(p.Actor,p.Id,p.Face,p.TargetId,p.Generated);             if(!keys.TryGetValue(key,out int id))keys[key]=id=next++;             return id;         }).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`LeagueSolverLink.ReportRuns(actions).Select(run=>new DuelSequenceRun(             plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return LeagueSolverLink.ReportRuns(actions).Select(run=>new DuelSequenceRun(             plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList(),run.Count)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList()`；返回值紧邻使用处：`ArgumentSyntax: plays.GetRange(run.Start,run.Period).Select(p=>new DuelCardStep(p.Actor,p.Name,p.Target,p.Generated)).ToList()`
- `System.Collections.Generic.List<T>.GetRange(int, int)`；输入表达式：`plays.GetRange(run.Start,run.Period)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plays.GetRange(run.Start,run.Period).Select`

**赋值（含属性/字段和局部值）：**

- `id` = `next++`
- `keys[key]` = `id=next++`

<a id="symbol-2f331da503dd"></a>

## `NationalSpire.DuelRecorder.Finish(bool) — internal DuelReport Finish(bool won)`

来源：源码第 182 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.EndTeam(bool)`](LeagueTeamMatch.cs.md#symbol-20c50965f995)；[`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；[`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`](LeagueNativeMatch.cs.md#symbol-1b324a0cbccb)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace)`](DuelRecorder.cs.md#symbol-05556a56fbe8)；[`NationalSpire.DuelRecorder.Read()`](DuelRecorder.cs.md#symbol-1f3b4be880f6)；[`NationalSpire.DuelRecorder.Sequence(System.Collections.Generic.List<NationalSpire.DuelRecorder.Play>)`](DuelRecorder.cs.md#symbol-6720ee798acf)；`NationalSpire.DuelReplayStep.DuelReplayStep(int, int, string, string, bool)`；`NationalSpire.DuelTurnTotals.DuelTurnTotals()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TFirst>.Zip<TFirst, TSecond>(System.Collections.Generic.IEnumerable<TSecond>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Random.Next()`；`System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.DuelParticipant.EndHp`；`NationalSpire.DuelParticipant.EndMax`；`NationalSpire.DuelRecorder._players`；`NationalSpire.DuelRecorder._replay`；`NationalSpire.DuelRecorder._report`；`NationalSpire.DuelRecorder._rounds`；`NationalSpire.DuelRecorder._run`；`NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace)`；`NationalSpire.DuelRecorder.Play.Actor`；`NationalSpire.DuelRecorder.Play.Face`；`NationalSpire.DuelRecorder.Play.Finished`；`NationalSpire.DuelRecorder.Play.Generated`；`NationalSpire.DuelRecorder.Play.Id`；`NationalSpire.DuelRecorder.Play.Name`；`NationalSpire.DuelRecorder.Play.RecordedFace`；`NationalSpire.DuelRecorder.Play.Target`；`NationalSpire.DuelRecorder.Read()`；`NationalSpire.DuelRecorder.Round.Data`；`NationalSpire.DuelRecorder.Round.Knockout`；`NationalSpire.DuelRecorder.Round.Plays`；`NationalSpire.DuelRecorder.Sequence(System.Collections.Generic.List<NationalSpire.DuelRecorder.Play>)`；`NationalSpire.DuelReplay.Rounds`；`NationalSpire.DuelReport.People`；`NationalSpire.DuelReport.PlayedFaces`；`NationalSpire.DuelReport.PlayersWon`；`NationalSpire.DuelReport.Replay`；`NationalSpire.DuelReport.Rounds`；`NationalSpire.DuelRound.Number`；`NationalSpire.DuelRound.Sequence`；`NationalSpire.DuelRound.Totals`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(_run.Rng.StringSeed)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(_run.Rng.StringSeed)`
- `NationalSpire.DuelRecorder.FaceIndex(NationalSpire.DuelCardFace)`；输入表达式：`FaceIndex(p.RecordedFace)`；返回值紧邻使用处：`ArgumentSyntax: FaceIndex(p.RecordedFace)`
- `NationalSpire.DuelRecorder.Read()`；输入表达式：`Read()`；返回值紧邻使用处：`ExpressionStatementSyntax: Read();`
- `NationalSpire.DuelRecorder.Sequence(System.Collections.Generic.List<NationalSpire.DuelRecorder.Play>)`；输入表达式：`Sequence(r.Plays)`；返回值紧邻使用处：`AssignmentExpressionSyntax: r.Data.Sequence=Sequence(r.Plays)`
- `NationalSpire.DuelReplayStep.DuelReplayStep(int, int, string, string, bool)`；输入表达式：`new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)`
- `NationalSpire.DuelTurnTotals.DuelTurnTotals()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_replay.Rounds.Add(r.Data.Number,r.Plays.Select(p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)).ToList())`；返回值紧邻使用处：`ExpressionStatementSyntax: _replay.Rounds.Add(r.Data.Number,r.Plays.Select(p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)).ToList());`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`seen.Contains(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !seen.Contains(p)`
- `System.Collections.Generic.IEnumerable<TFirst>.Zip<TFirst, TSecond>(System.Collections.Generic.IEnumerable<TSecond>)`；输入表达式：`r.Plays.Zip(r.Plays.Skip(1))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: r.Plays.Zip(r.Plays.Skip(1)).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Knockout || r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`r.Plays.Select(p=>(p.Actor,p.Id)).Distinct().Count(p=>!seen.Contains(p))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r=>r.Plays.Select(p=>(p.Actor,p.Id)).Distinct().Count(p=>!seen.Contains(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`_report.PlayedFaces.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _report.PlayedFaces.Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`r.Plays.Select(p=>(p.Actor,p.Id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: r.Plays.Select(p=>(p.Actor,p.Id)).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(_=>rng.Next())                 .MaxBy(r=>r.Plays.Select(p=>(p.Actor,p.Id)).Distinct().Count(p=>!seen.Contains(p)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =others.OrderBy(_=>rng.Next())                 .MaxBy(r=>r.Plays.Select(p=>(p.Actor,p.Id)).Distinct().Count(p=>!seen.Contains(p)))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(_=>rng.Next())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(_=>rng.Next())                 .MaxBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_rounds.Values.Select(r=>r.Data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _rounds.Values.Select(r=>r.Data).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`first.Plays.Select(p=>(p.Actor,p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: first.Plays.Select(p=>(p.Actor,p.Id)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`r.Plays.Select(p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: r.Plays.Select(p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`r.Plays.Select(p=>(p.Actor,p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: r.Plays.Select(p=>(p.Actor,p.Id)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`r.Plays.Where(p=>p.Face.Length>0).Select(p=>p.RecordedFace)`；返回值紧邻使用处：`ArgumentSyntax: r.Plays.Where(p=>p.Face.Length>0).Select(p=>p.RecordedFace)`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`r.Plays.Skip(1)`；返回值紧邻使用处：`ArgumentSyntax: r.Plays.Skip(1)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`first.Plays.Select(p=>(p.Actor,p.Id)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =first.Plays.Select(p=>(p.Actor,p.Id)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_report.PlayedFaces.Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _report.PlayedFaces=_report.PlayedFaces.Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_rounds.Values.Select(r=>r.Data).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _report.Rounds=_rounds.Values.Select(r=>r.Data).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_rounds.Values.Where(r=>r.Plays.Count>0).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_rounds.Values.Where(r=>r.Plays.Count>0).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.Where(r=>r!=first).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =candidates.Where(r=>r!=first).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`played.Where(r=>r!=first).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: others=played.Where(r=>r!=first).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`played.Where(r=>r.Knockout || r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =played.Where(r=>r.Knockout || r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`r.Plays.Select(p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)).ToList()`；返回值紧邻使用处：`ArgumentSyntax: r.Plays.Select(p=>                 new DuelReplayStep(p.Actor,FaceIndex(p.RecordedFace),p.Name,p.Target,p.Generated)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_rounds.Values.Where(r=>r.Plays.Count>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _rounds.Values.Where(r=>r.Plays.Count>0).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_rounds.Values.Where(r=>r==first || r==second)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var r in _rounds.Values.Where(r=>r==first || r==second)) {                 r.Data.Sequence=Sequence(r.Plays);                 _report.PlayedFaces.AddRange(r.Plays.Where(p=>p.Face.Length>0).Select(p=>p.RecordedFace));             }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(r=>r!=first)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(r=>r!=first).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`played.Where(r=>r!=first)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: played.Where(r=>r!=first).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`played.Where(r=>r.Knockout || r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: played.Where(r=>r.Knockout || r.Plays.Zip(r.Plays.Skip(1)).Any(pair=>pair.First.Actor==pair.Second.Actor && pair.First.Id!=pair.Second.Id)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`r.Plays.Where(p=>p.Face.Length>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: r.Plays.Where(p=>p.Face.Length>0).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`candidates.Add(played[rng.Next(played.Count)])`；返回值紧邻使用处：`ExpressionStatementSyntax: candidates.Add(played[rng.Next(played.Count)]);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`r.Data.Totals.Add(new())`；返回值紧邻使用处：`ExpressionStatementSyntax: r.Data.Totals.Add(new());`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`_report.PlayedFaces.AddRange(r.Plays.Where(p=>p.Face.Length>0).Select(p=>p.RecordedFace))`；返回值紧邻使用处：`ExpressionStatementSyntax: _report.PlayedFaces.AddRange(r.Plays.Where(p=>p.Face.Length>0).Select(p=>p.RecordedFace));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`r.Plays.RemoveAll(p=>!p.Finished)`；返回值紧邻使用处：`ExpressionStatementSyntax: r.Plays.RemoveAll(p=>!p.Finished);`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>rng.Next()`
- `System.Random.Next(int)`；输入表达式：`rng.Next(candidates.Count)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(candidates.Count)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(played.Count)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(played.Count)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(_run.Rng.StringSeed))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Random(CareerEngine.StableHash(_run.Rng.StringSeed))`

**赋值（含属性/字段和局部值）：**

- `_report.People[i].EndHp` = `_players[i].Creature.CurrentHp`
- `_report.People[i].EndMax` = `_players[i].Creature.MaxHp`
- `_report.PlayedFaces` = `_report.PlayedFaces.Distinct().ToList()`
- `_report.PlayersWon` = `won`
- `_report.Replay` = `_replay`
- `_report.Rounds` = `_rounds.Values.Select(r=>r.Data).ToList()`
- `others` = `played.Where(r=>r!=first).ToList()`
- `r.Data.Sequence` = `Sequence(r.Plays)`

<a id="symbol-7c4bf8629e94"></a>

## `NationalSpire.DuelRecorder.Dispose() — public void Dispose()`

来源：源码第 216 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DuelRecorder._choices`；`NationalSpire.DuelRecorder._history`；`NationalSpire.DuelRecorder.PlayerChoice(MegaCrit.Sts2.Core.Entities.Players.Player, uint, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult)`；`NationalSpire.DuelRecorder.Read()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_choices.PlayerChoiceReceived` -= `PlayerChoice`
- `_history.Changed` -= `Read`
