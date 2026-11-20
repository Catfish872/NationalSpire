# LeagueTeamMatch.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4C50E7B8125A1BCB1135A3FECD2EC050AE4A286088D3F2494DE1C904B26102FB`。来源：[源码](../../LeagueTeamMatch.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueNativeMatch`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private static string? _teamAttempt;
private string? _teamReceipt;
```

<a id="symbol-07cb19073635"></a>

## `NationalSpire.LeagueNativeMatch.IsTeamMatch — internal static bool IsTeamMatch`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._teamAttempt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-40715405ce22"></a>

## `NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int) — private static void EquipDeck(RunState run,Player player,IEnumerable<CardModel> cards,IReadOnlyDictionary<string,int>? upgrades,int tier)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`](LeagueNativeMatch.cs.md#symbol-a60b957088cc)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`](LeagueCards.cs.md#symbol-4eb35465f771)；[`NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`](LeagueLadder.cs.md#symbol-9d40de0014e6)；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；`MegaCrit.Sts2.Core.Entities.Cards.CardPile.Clear(bool)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；`MegaCrit.Sts2.Core.Runs.RunState.CreateCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；`System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`；`NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.AddInternal(MegaCrit.Sts2.Core.Models.CardModel, int, bool)`；输入表达式：`player.Deck.AddInternal(LeagueCards.ApplyAllocation(run.CreateCard(c,player),allocation),-1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: player.Deck.AddInternal(LeagueCards.ApplyAllocation(run.CreateCard(c,player),allocation),-1,true);`
- `MegaCrit.Sts2.Core.Entities.Cards.CardPile.Clear(bool)`；输入表达式：`player.Deck.Clear(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: player.Deck.Clear(true);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；输入表达式：`player.Creature.SetCurrentHpInternal(player.Creature.MaxHp)`；返回值紧邻使用处：`ExpressionStatementSyntax: player.Creature.SetCurrentHpInternal(player.Creature.MaxHp);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；输入表达式：`player.Creature.SetMaxHpInternal(LeagueLadder.Health(player.Character,tier))`；返回值紧邻使用处：`ExpressionStatementSyntax: player.Creature.SetMaxHpInternal(LeagueLadder.Health(player.Character,tier));`
- `MegaCrit.Sts2.Core.Runs.RunState.CreateCard(MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`run.CreateCard(c,player)`；返回值紧邻使用处：`ArgumentSyntax: run.CreateCard(c,player)`
- `NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`；输入表达式：`LeagueCards.ApplyAllocation(run.CreateCard(c,player),allocation)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.ApplyAllocation(run.CreateCard(c,player),allocation)`
- `NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`LeagueLadder.Health(player.Character,tier)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Health(player.Character,tier)`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`.ToDictionary()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: upgrades?.ToDictionary()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81e11d18adc7"></a>

## `NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>) — public static async Task StartTeam(CoopCoordinator session,StartRunLobby lobby,IReadOnlyList<ActModel> acts)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](Coop/CoopNativeRun.cs.md#symbol-ddd22369fd06)

**调用：** [`Begin()`](LeagueTeamMatch.cs.md#symbol-7d973fd93537)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`](LeagueArenaScreen.cs.md#symbol-b602cebe9951)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](Coop/NativeLobbyApi.cs.md#symbol-433695ce5c9e)；[`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)；[`NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string)`](LeagueBattleApi.cs.md#symbol-3ef9bfd7ad99)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?)`](LeagueDuel.cs.md#symbol-83cd52462f7a)；[`NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`](LeagueLadder.cs.md#symbol-a46e08a27495)；[`NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`](LeagueLadder.cs.md#symbol-9d40de0014e6)；[`NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string)`](LeagueLadder.cs.md#symbol-9dbd4f842c20)；[`NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int)`](LeagueLadder.cs.md#symbol-5aa41a3b4644)；[`NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`](LeagueLadder.cs.md#symbol-fc32b34df886)；[`NationalSpire.LeagueLadder.RivalOpens(int)`](LeagueLadder.cs.md#symbol-3b4c257e5975)；[`NationalSpire.LeagueLadder.Tier(int)`](LeagueLadder.cs.md#symbol-b15a71b48f9a)；[`NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`](LeagueLadder.cs.md#symbol-8988ba35b084)；[`NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`](LeagueTeamMatch.cs.md#symbol-40715405ce22)；[`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)；[`NationalSpire.LeagueSolverLink.Prepare()`](LeagueSolverLink.cs.md#symbol-1ecd89ef590b)；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Entities.Players.Player.InitializeSeed(string)`；`MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；`MegaCrit.Sts2.Core.Unlocks.UnlockState.FromSerializable(MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState)`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`NationalSpire.LeagueLadder.Draw.Draw(NationalSpire.CareerData)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Linq.Enumerable.Repeat<TResult>(TResult, int)`；`System.Random.Next()`；`System.Random.Random(int)`；`System.Threading.CancellationTokenSource.CancellationTokenSource()`

**字段、属性、事件及方法组引用：** `(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Name`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).PersonId`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Role`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Style`；`(string Name, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier, string Style, string? PersonId).Tier`；`Begin()`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.LeagueRoster`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.MirrorAppointment`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Name`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Coop.NativeLobbyApi.Member.Character`；`NationalSpire.Coop.NativeLobbyApi.Member.Id`；`NationalSpire.Coop.NativeLobbyApi.Member.Unlocks`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Rating`；`NationalSpire.LeagueAlbum.Upgrades`；`NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`；`NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueDuel.Exit`；`NationalSpire.LeagueDuel.OpeningHp`；`NationalSpire.LeagueDuel.OpeningMax`；`NationalSpire.LeagueDuel.OpponentName`；`NationalSpire.LeagueDuel.PersonId`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueDuel.SetupCards`；`NationalSpire.LeagueDuel.Tier`；`NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`；`NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`；`NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string)`；`NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int)`；`NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`；`NationalSpire.LeagueLadder.RivalOpens(int)`；`NationalSpire.LeagueLadder.Tier(int)`；`NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`；`NationalSpire.LeagueNativeMatch._appointmentId`；`NationalSpire.LeagueNativeMatch._mirrorExit`；`NationalSpire.LeagueNativeMatch._opener`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch._teamAttempt`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`；`NationalSpire.LeagueNativeMatch.Install()`；`NationalSpire.LeagueNativeMatch.Team`；`NationalSpire.LeagueSolverLink.Prepare()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Begin()`；输入表达式：`Begin()`；返回值紧邻使用处：`AwaitExpressionSyntax: await Begin()`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m=>Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(rival.Role,p.UnlockState,botId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Player.CreateForNewRun(rival.Role,p.UnlockState,botId)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.InitializeSeed(string)`；输入表达式：`bot.InitializeSeed(record.Seed+":"+botId)`；返回值紧邻使用处：`ExpressionStatementSyntax: bot.InitializeSeed(record.Seed+":"+botId);`
- `MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；输入表达式：`a.ToMutable()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a=>a.ToMutable()`
- `MegaCrit.Sts2.Core.Unlocks.UnlockState.FromSerializable(MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState)`；输入表达式：`UnlockState.FromSerializable(m.Unlocks!)`；返回值紧邻使用处：`ArgumentSyntax: UnlockState.FromSerializable(m.Unlocks!)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(first.Rival.Character.IconTexture,CareerVisuals.Teal,first.OpponentName)`；返回值紧邻使用处：`ArgumentSyntax: new(first.Rival.Character.IconTexture,CareerVisuals.Teal,first.OpponentName)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(world.World,lead.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(world.World,lead.PersonId)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(record.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.StableHash(record.Seed)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(record.Seed+":"+p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(record.Seed+":"+p.NetId)`
- `NationalSpire.CareerScreen.OpeningGate(string, NationalSpire.AvatarArt, int, string, string, NationalSpire.AvatarArt, int, string, string, string, System.Func<System.Threading.Tasks.Task>)`；输入表达式：`screen.OpeningGate(appointment?.Event ?? "镜面对决   /   团体匹配",CareerAvatars.ForPerson(world.World,lead.PersonId),LeagueLadder.Tier(lead.Life.League.Rating),              world.Name,string.Join(" · ",world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name)),new(first.Rival.Character.IconTexture,CareerVisuals.Teal,first.OpponentName),first.Tier,"联赛对手",string.Join(" · ",Team.Select(f=>f.OpponentName)),_opener?"对手先手":"你方先手",Begin)`；返回值紧邻使用处：`AwaitExpressionSyntax: await screen.OpeningGate(appointment?.Event ?? "镜面对决   /   团体匹配",CareerAvatars.ForPerson(world.World,lead.PersonId),LeagueLadder.Tier(lead.Life.League.Rating),              world.Name,string.Join(" · ",world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name)),new(first.Rival.Character.IconTexture,CareerVisuals.Teal,first.OpponentName),first.Tier,"联赛对手",string.Join(" · ",Team.Select(f=>f.OpponentName)),_opener?"对手先手":"你方先手",Begin)`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Players(lobby)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Players(lobby).Select`
- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`LeagueArchetypes.Resolve(rival.Role.Id.Entry,rival.Style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueArchetypes.Resolve(rival.Role.Id.Entry,rival.Style)`
- `NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string)`；输入表达式：`LeagueBattleApi.Create(roster,acts.Select(a=>a.ToMutable()).ToList(),record.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueBattleApi.Create(roster,acts.Select(a=>a.ToMutable()).ToList(),record.Seed)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(a)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueCards.Deck(a)!`
- `NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?)`；输入表达式：`new(bot,cards,rng.Next(),rival.Name,rival.Tier,LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng),pending){PersonId=rival.PersonId,Exit=_mirrorExit.Token,OpeningMax=hp,OpeningHp=hp,SetupCards=plan.Anchors}`；返回值紧邻使用处：`ArgumentSyntax: new(bot,cards,rng.Next(),rival.Name,rival.Tier,LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng),pending){PersonId=rival.PersonId,Exit=_mirrorExit.Token,OpeningMax=hp,OpeningHp=hp,SetupCards=plan.Anchors}`
- `NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`；输入表达式：`LeagueLadder.Build(rival.Role,rng,rival.Tier,rival.Style)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueLadder.Build(rival.Role,rng,rival.Tier,rival.Style).ToArray`
- `NationalSpire.LeagueLadder.Draw.Draw(NationalSpire.CareerData)`；输入表达式：`new LeagueLadder.Draw(world.World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueLadder.Draw(world.World)`
- `NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`LeagueLadder.Health(rival.Role,rival.Tier)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueLadder.Health(rival.Role,rival.Tier)`
- `NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string)`；输入表达式：`LeagueLadder.Invited(world.World.LeagueRoster!,draw,appointment.OpponentId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueLadder.Invited(world.World.LeagueRoster!,draw,appointment.OpponentId)!`
- `NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int)`；输入表达式：`LeagueLadder.Match(world.World.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating))`；返回值紧邻使用处：`ConditionalExpressionSyntax: Team.Count==0 && appointment!=null ? LeagueLadder.Invited(world.World.LeagueRoster!,draw,appointment.OpponentId)!.Value                  : LeagueLadder.Match(world.World.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating))`
- `NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`；输入表达式：`LeagueLadder.PrepareRoster(world.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueLadder.PrepareRoster(world.World);`
- `NationalSpire.LeagueLadder.RivalOpens(int)`；输入表达式：`LeagueLadder.RivalOpens(seed)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _opener=LeagueLadder.RivalOpens(seed)`
- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`LeagueLadder.Tier(a.Rating)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Tier(a.Rating)`
- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`LeagueLadder.Tier(lead.Life.League.Rating)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.Tier(lead.Life.League.Rating)`
- `NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`；输入表达式：`LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng)`；返回值紧邻使用处：`ArgumentSyntax: LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng)`
- `NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`；输入表达式：`EquipDeck(run,p,LeagueCards.Deck(a)!.SelectMany(k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value)),a.Upgrades.GetValueOrDefault(a.Captain),LeagueLadder.Tier(a.Rating))`；返回值紧邻使用处：`ExpressionStatementSyntax: EquipDeck(run,p,LeagueCards.Deck(a)!.SelectMany(k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value)),a.Upgrades.GetValueOrDefault(a.Captain),LeagueLadder.Tier(a.Rating));`
- `NationalSpire.LeagueNativeMatch.Install()`；输入表达式：`Install()`；返回值紧邻使用处：`ExpressionStatementSyntax: Install();`
- `NationalSpire.LeagueSolverLink.Prepare()`；输入表达式：`LeagueSolverLink.Prepare()`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueSolverLink.Prepare();`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",Team.Select(f=>f.OpponentName))`；返回值紧邻使用处：`ArgumentSyntax: string.Join(" · ",Team.Select(f=>f.OpponentName))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name))`；返回值紧邻使用处：`ArgumentSyntax: string.Join(" · ",world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`record.Characters.ContainsKey(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m=>record.Characters.ContainsKey(m.SteamId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`roster.Any(h=>h.NetId==botId)`；返回值紧邻使用处：`BinaryExpressionSyntax: roster.Any(h=>h.NetId==botId)||Team.Any(f=>f.Rival.NetId==botId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Team.Any(f=>f.Rival.NetId==botId)`；返回值紧邻使用处：`BinaryExpressionSyntax: roster.Any(h=>h.NetId==botId)||Team.Any(f=>f.Rival.NetId==botId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.World.Matches.FirstOrDefault(m=>m.Id==record.MatchId&&m.MirrorAppointment)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =world.World.Matches.FirstOrDefault(m=>m.Id==record.MatchId&&m.MirrorAppointment)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`roster.OrderBy(p=>p.NetId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var p in roster.OrderBy(p=>p.NetId)){              var member=world.Members.Single(m=>m.SteamId==p.NetId);var a=member.Life.League;              EquipDeck(run,p,LeagueCards.Deck(a)!.SelectMany(k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value)),a.Upgrades.GetValueOrDefault(a.Captain),LeagueLadder.Tier(a.Rating));              var rng=new Random(CareerEngine.StableHash(record.Seed+":"+p.NetId));              var rival=Team.Count==0 && appointment!=null ? LeagueLadder.Invited(world.World.LeagueRoster!,draw,appointment.OpponentId)!.Value                  : LeagueLadder.Match(world.World.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating));var cards=LeagueLadder.Build(rival.Role,rng,rival.Tier,rival.Style).ToArray();              var plan=LeagueArchetypes.Resolve(rival.Role.Id.Entry,rival.Style);              ulong botId=ulong.MaxValue-(ulong)Team.Count;while(roster.Any(h=>h.NetId==botId)||Team.Any(f=>f.Rival.NetId==botId))botId--;              var bot=Player.CreateForNewRun(rival.Role,p.UnlockState,botId);bot.RunState=run;bot.InitializeSeed(record.Seed+":"+botId);              int hp=LeagueLadder.Health(rival.Role,rival.Tier);              Team.Add(new(bot,cards,rng.Next(),rival.Name,rival.Tier,LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng),pending){PersonId=rival.PersonId,Exit=_mirrorExit.Token,OpeningMax=hp,OpeningHp=hp,SetupCards=plan.Anchors});          }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`acts.Select(a=>a.ToMutable())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: acts.Select(a=>a.ToMutable()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`NativeLobbyApi.Players(lobby).Select(m=>Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Players(lobby).Select(m=>Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Team.Select(f=>f.OpponentName)`；返回值紧邻使用处：`ArgumentSyntax: Team.Select(f=>f.OpponentName)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name)`；返回值紧邻使用处：`ArgumentSyntax: world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`LeagueCards.Deck(a)!.SelectMany(k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value))`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.Deck(a)!.SelectMany(k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members.Single(m=>m.SteamId==p.NetId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =world.Members.Single(m=>m.SteamId==p.NetId)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members.Single(m=>m.SteamId==session.Self)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =world.Members.Single(m=>m.SteamId==session.Self)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`NativeLobbyApi.Players(lobby).Select(m=>Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =NativeLobbyApi.Players(lobby).Select(m=>Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`acts.Select(a=>a.ToMutable()).ToList()`；返回值紧邻使用处：`ArgumentSyntax: acts.Select(a=>a.ToMutable()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Upgrades.GetValueOrDefault(a.Captain)`；返回值紧邻使用处：`ArgumentSyntax: a.Upgrades.GetValueOrDefault(a.Captain)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Team.Add(new(bot,cards,rng.Next(),rival.Name,rival.Tier,LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng),pending){PersonId=rival.PersonId,Exit=_mirrorExit.Token,OpeningMax=hp,OpeningHp=hp,SetupCards=plan.Anchors})`；返回值紧邻使用处：`ExpressionStatementSyntax: Team.Add(new(bot,cards,rng.Next(),rival.Name,rival.Tier,LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng),pending){PersonId=rival.PersonId,Exit=_mirrorExit.Token,OpeningMax=hp,OpeningHp=hp,SetupCards=plan.Anchors});`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<LeagueDuel.Hit>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<LeagueDuel.Hit>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`LeagueLadder.Build(rival.Role,rng,rival.Tier,rival.Style).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueLadder.Build(rival.Role,rng,rival.Tier,rival.Style).ToArray()`
- `System.Linq.Enumerable.Repeat<TResult>(TResult, int)`；输入表达式：`Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value)`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`ArgumentSyntax: rng.Next()`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(record.Seed+":"+p.NetId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Random(CareerEngine.StableHash(record.Seed+":"+p.NetId))`
- `System.Threading.CancellationTokenSource.CancellationTokenSource()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mirrorExit=new()`

**赋值（含属性/字段和局部值）：**

- `_appointmentId` = `appointment?.Id`
- `_mirrorExit` = `new()`
- `_opener` = `LeagueLadder.RivalOpens(seed)`
- `_returning` = `false`
- `_run` = `run`
- `_teamAttempt` = `record.Attempt`
- `bot.RunState` = `run`
- `Current` = `Team[0]`
- `Exit` = `_mirrorExit.Token`
- `OpeningHp` = `hp`
- `OpeningMax` = `hp`
- `PersonId` = `rival.PersonId`
- `SetupCards` = `plan.Anchors`

<a id="symbol-7d973fd93537"></a>

## `Begin() — async Task Begin()`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.CareerScreen.CloseCurrent()`](CareerSession.cs.md#symbol-5830f879d8f9)；[`NationalSpire.CareerScreen.UseOpening(string?)`](LeagueArenaScreen.cs.md#symbol-714fe2bbacbd)；[`NationalSpire.Coop.CoopScreen.CloseCurrent()`](Coop/CoopScreen.cs.md#symbol-3f7660e3fc51)；[`NationalSpire.LeagueEncounter.ForMatch(MegaCrit.Sts2.Core.Runs.RunState, int)`](LeagueNativeMatch.cs.md#symbol-fa5ea0b30eea)；[`NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState)`](LeagueNativeMatch.cs.md#symbol-4d22b3101f75)；[`NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`](LeagueNativeMatch.cs.md#symbol-c7bf6cbb732d)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)；`MegaCrit.Sts2.Core.Assets.PreloadManager.LoadActAssets(MegaCrit.Sts2.Core.Models.ActModel)`；`MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；`MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer.Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer, System.Collections.Generic.IEnumerable<ulong>)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer.InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；`MegaCrit.Sts2.Core.Runs.RunManager.EnterRoomDebug(MegaCrit.Sts2.Core.Rooms.RoomType, MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；`MegaCrit.Sts2.Core.Runs.RunManager.Launch()`；`MegaCrit.Sts2.Core.Runs.RunManager.SetActInternal(int)`；`MegaCrit.Sts2.Core.Runs.RunManager.SetUpNewMultiplayer(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, bool, System.DateTimeOffset?)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CloseCurrent()`；`NationalSpire.CareerScreen.UseOpening(string?)`；`NationalSpire.Coop.CoopScreen.CloseCurrent()`；`NationalSpire.LeagueDuel.Exit`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueEncounter.ForMatch(MegaCrit.Sts2.Core.Runs.RunState, int)`；`NationalSpire.LeagueNativeMatch._matchVenue`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch._teamAttempt`；`NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`；`NationalSpire.LeagueNativeMatch.PlayerTurn(MegaCrit.Sts2.Core.Combat.CombatState)`；`NationalSpire.LeagueNativeMatch.Release()`；`NationalSpire.LeagueNativeMatch.Team`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Assets.PreloadManager.LoadActAssets(MegaCrit.Sts2.Core.Models.ActModel)`；输入表达式：`PreloadManager.LoadActAssets(run.Act)`；返回值紧邻使用处：`AwaitExpressionSyntax: await PreloadManager.LoadActAssets(run.Act)`
- `MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`；输入表达式：`PreloadManager.LoadRunAssets(roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList())`；返回值紧邻使用处：`AwaitExpressionSyntax: await PreloadManager.LoadRunAssets(roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList())`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；输入表达式：`lobby.CleanUp(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: lobby.CleanUp(false);`
- `MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer.Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer, System.Collections.Generic.IEnumerable<ulong>)`；输入表达式：`game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer,roster.Select(p=>p.NetId))`；返回值紧邻使用处：`ExpressionStatementSyntax: game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer,roster.Select(p=>p.NetId));`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeIn(.24f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeIn(.24f)`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeOut(.24f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeOut(.24f)`
- `MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer.InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；输入表达式：`game.ReactionContainer.InitializeNetworking(lobby.NetService)`；返回值紧邻使用处：`ExpressionStatementSyntax: game.ReactionContainer.InitializeNetworking(lobby.NetService);`
- `MegaCrit.Sts2.Core.Runs.RunManager.EnterRoomDebug(MegaCrit.Sts2.Core.Rooms.RoomType, MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；输入表达式：`mgr.EnterRoomDebug(RoomType.Monster,model:encounter,showTransition:false)`；返回值紧邻使用处：`AwaitExpressionSyntax: await mgr.EnterRoomDebug(RoomType.Monster,model:encounter,showTransition:false)`
- `MegaCrit.Sts2.Core.Runs.RunManager.Launch()`；输入表达式：`mgr.Launch()`；返回值紧邻使用处：`ExpressionStatementSyntax: mgr.Launch();`
- `MegaCrit.Sts2.Core.Runs.RunManager.SetActInternal(int)`；输入表达式：`mgr.SetActInternal(run.CurrentActIndex)`；返回值紧邻使用处：`AwaitExpressionSyntax: await mgr.SetActInternal(run.CurrentActIndex)`
- `MegaCrit.Sts2.Core.Runs.RunManager.SetUpNewMultiplayer(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, bool, System.DateTimeOffset?)`；输入表达式：`mgr.SetUpNewMultiplayer(run,lobby,false)`；返回值紧邻使用处：`ExpressionStatementSyntax: mgr.SetUpNewMultiplayer(run,lobby,false);`
- `NationalSpire.CareerScreen.CloseCurrent()`；输入表达式：`CareerScreen.CloseCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.CloseCurrent();`
- `NationalSpire.CareerScreen.UseOpening(string?)`；输入表达式：`CareerScreen.UseOpening()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerScreen.UseOpening()`
- `NationalSpire.Coop.CoopScreen.CloseCurrent()`；输入表达式：`CoopScreen.CloseCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopScreen.CloseCurrent();`
- `NationalSpire.LeagueEncounter.ForMatch(MegaCrit.Sts2.Core.Runs.RunState, int)`；输入表达式：`LeagueEncounter.ForMatch(run,seed)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _matchVenue=LeagueEncounter.ForMatch(run,seed)`
- `NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`EnterMatchScene(game,run)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EnterMatchScene(game,run)`
- `NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`；输入表达式：`InstallExit(scene)`；返回值紧邻使用处：`ExpressionStatementSyntax: InstallExit(scene);`
- `NationalSpire.LeagueNativeMatch.Release()`；输入表达式：`Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: Release();`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`roster.Select(p=>p.Character)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.Select(p=>p.Character).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`roster.Select(p=>p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: roster.Select(p=>p.NetId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Team.Select(f=>f.Rival.Character)`；返回值紧邻使用处：`ArgumentSyntax: Team.Select(f=>f.Rival.Character)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList()`；返回值紧邻使用处：`ArgumentSyntax: roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList()`

**赋值（含属性/字段和局部值）：**

- `_matchVenue` = `LeagueEncounter.ForMatch(run,seed)`
- `_room` = `room`
- `_teamAttempt` = `null`
- `CombatManager.Instance.TurnStarted` += `PlayerTurn`
- `scene.TreeExiting` += `()=>{if(_run==run&&!_returning){_teamAttempt=null;Release();}}`

<a id="symbol-20c50965f995"></a>

## `NationalSpire.LeagueNativeMatch.EndTeam(bool) — internal static async Task EndTeam(bool won)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.FinalEndHooks.Check(MegaCrit.Sts2.Core.Combat.CombatManager, ref System.Threading.Tasks.Task<bool>)`](ArchitectFinal.cs.md#symbol-45c020867c72)

**调用：** [`NationalSpire.CareerScreen.OpenTeamReceipt(Godot.Control, NationalSpire.ICareerSession, string)`](LeagueTeamMatch.cs.md#symbol-36421958cb8a)；[`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`](Coop/CoopCareerSession.cs.md#symbol-be42258ccf13)；[`NationalSpire.Coop.CoopRules.FinishLeagueTeam(NationalSpire.Coop.CoopCoordinator, string, bool?, NationalSpire.DuelReport?)`](Coop/CoopRules.cs.md#symbol-32aed8cb856a)；[`NationalSpire.DuelRecorder.Finish(bool)`](DuelRecorder.cs.md#symbol-2f331da503dd)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)；`MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenu()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenTeamReceipt(Godot.Control, NationalSpire.ICareerSession, string)`；`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopRules.FinishLeagueTeam(NationalSpire.Coop.CoopCoordinator, string, bool?, NationalSpire.DuelReport?)`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.DuelRecorder.Finish(bool)`；`NationalSpire.LeagueNativeMatch._appointmentId`；`NationalSpire.LeagueNativeMatch._report`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._teamAttempt`；`NationalSpire.LeagueNativeMatch.Release()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenu()`；输入表达式：`game.ReturnToMainMenu()`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.ReturnToMainMenu()`
- `NationalSpire.CareerScreen.OpenTeamReceipt(Godot.Control, NationalSpire.ICareerSession, string)`；输入表达式：`CareerScreen.OpenTeamReceipt(menu,view,id)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.OpenTeamReceipt(menu,view,id);`
- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`CareerScreen.OpenView(menu,view,"结算")`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.OpenView(menu,view,"结算");`
- `NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`；输入表达式：`new CoopCareerSession(session,menu)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CoopCareerSession(session,menu)`
- `NationalSpire.Coop.CoopRules.FinishLeagueTeam(NationalSpire.Coop.CoopCoordinator, string, bool?, NationalSpire.DuelReport?)`；输入表达式：`CoopRules.FinishLeagueTeam(session,id,won,session.Host?_report?.Finish(won):null)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.FinishLeagueTeam(session,id,won,session.Host?_report?.Finish(won):null);`
- `NationalSpire.DuelRecorder.Finish(bool)`；输入表达式：`.Finish(won)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _report?.Finish(won)`
- `NationalSpire.LeagueNativeMatch.Release()`；输入表达式：`Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: Release();`

**赋值（含属性/字段和局部值）：**

- `_returning` = `true`
- `_teamAttempt` = `null`

<a id="symbol-36421958cb8a"></a>

## `NationalSpire.CareerScreen.OpenTeamReceipt(Godot.Control, NationalSpire.ICareerSession, string) — internal static void OpenTeamReceipt(Control menu,ICareerSession view,string id)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.EndTeam(bool)`](LeagueTeamMatch.cs.md#symbol-20c50965f995)

**调用：** [`NationalSpire.CareerScreen.LeagueGo(string)`](LeagueScreen.cs.md#symbol-46069e214cbd)；[`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.CareerScreen.PresentTeamReceipt()`](LeagueTeamMatch.cs.md#symbol-70a7f721c6f0)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._teamReceipt`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.LeagueGo(string)`；`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.CareerScreen.PresentTeamReceipt()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`screen.LeagueGo("对战")`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.LeagueGo("对战");`
- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`OpenView(menu,view,"生涯生活")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenView(menu,view,"生涯生活");`
- `NationalSpire.CareerScreen.PresentTeamReceipt()`；输入表达式：`screen.PresentTeamReceipt()`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.PresentTeamReceipt();`

**赋值（含属性/字段和局部值）：**

- `screen._teamReceipt` = `id`

<a id="symbol-70a7f721c6f0"></a>

## `NationalSpire.CareerScreen.PresentTeamReceipt() — private void PresentTeamReceipt()`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.OpenTeamReceipt(Godot.Control, NationalSpire.ICareerSession, string)`](LeagueTeamMatch.cs.md#symbol-36421958cb8a)

**调用：** [`NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-9fa96420666c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerScreen._teamReceipt`；`NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.LeagueAlbum.LastDuel`；`NationalSpire.LeagueFinish.Match`；`NationalSpire.LeagueReceipt.Fight`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.LeagueAward(NationalSpire.LeagueReceipt)`；输入表达式：`LeagueAward(receipt)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueAward(receipt);`

**赋值（含属性/字段和局部值）：**

- `_teamReceipt` = `null`
