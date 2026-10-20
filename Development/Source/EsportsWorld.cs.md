# EsportsWorld.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D4CA46A3CF85C6481C92D40342F9E4ACB3BA51FCCA1B66F54CF578E7A4E6A90D`。来源：[源码](../../EsportsWorld.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EsportsWorld`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Countries = ["中国", "日本", "韩国", "德国", "法国", "巴西", "英国", "美国"];
private static readonly string[][] ClubNames = [ ["龙门竞技", "长夜俱乐部"], ["月见竞技", "赤枫俱乐部"], ["白虎电竞", "晨星竞技"], ["莱茵守望", "黑森林竞技"], ["白鸢俱乐部", "蔚蓝竞技"], ["金羽竞技", "雨林俱乐部"], ["王冠竞技", "雾港俱乐部"], ["极光竞技", "边境俱乐部"] ];
private static readonly string[] Characters = ["铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君"];
private static readonly string[] Styles = ["力量与高费攻击", "中毒与弃牌", "充能球与集中", "奥斯蒂与末日", "辉星与铸剑"];
```

<a id="symbol-921c23662473"></a>

## `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData) — public static string LicenseName(CareerData d)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.PaintMentionText(Godot.RichTextLabel, NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>?, bool)`](MentionScreen.cs.md#symbol-97692853b81c)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.EsportsWorld.AfterPlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool)`](EsportsWorld.cs.md#symbol-c0b4fbf0a978)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** `System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.License`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(d.Esports.License, 0, 3)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(d.Esports.License, 0, 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3ba0e806ba5c"></a>

## `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string) — public static CareerClub? Club(CareerData d, string id)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Club(string, string)`](PrivatePublicContext.cs.md#symbol-e7161b994cde)；[`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer)`](CareerCommerce.cs.md#symbol-4e9fe3d551a9)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CharacterCardPng.Reference(NationalSpire.CareerData, string)`](CharacterCardPng.cs.md#symbol-6126f1f4718d)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-fe0f4a1b42d8)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.CircuitPeople.Ensure(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-f59ba7354968)；[`NationalSpire.ClubAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](ClubAudience.cs.md#symbol-2ba02e4068ba)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.ClubOperations.TryTransfer(NationalSpire.CareerData, NationalSpire.CareerClub)`](ClubOperations.cs.md#symbol-91ececd875b5)；[`NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-e679a8998422)；[`NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-e6f5b5e37a12)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-ed217f617f49)；[`NationalSpire.MarketDynamics.Sponsors(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-80d7f294a5d5)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubSchedule.ApplyNextRegion(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-f50b11cb9486)；[`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-b24bb65463ab)；[`NationalSpire.OwnedClubSchedule.SetLineup(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<string>)`](OwnedClubSchedule.cs.md#symbol-78f0326d7e56)；[`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.Clubs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.FirstOrDefault(c => c.Id == id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Clubs.FirstOrDefault(c => c.Id == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-54b1e9fa0cf0"></a>

## `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string) — public static string ClubName(CareerData d, string id)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)；[`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerEngine.SimulateWorld(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-f80c37dd1019)；[`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CareerNarrative.cs.md#symbol-63592bc97cd1)；[`NationalSpire.CareerNarrative.Feature(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CareerNarrative.cs.md#symbol-d15ddefbd3f2)；[`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-2125ea5bc3b0)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PaintMentionText(Godot.RichTextLabel, NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>?, bool)`](MentionScreen.cs.md#symbol-97692853b81c)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.Coop.CoopRules.ProposalLabel(NationalSpire.Coop.CoopWorld, string, string, int)`](Coop/CoopRules.cs.md#symbol-c3d56826da72)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)；[`NationalSpire.EsportsWorld.TransferWindow(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-d57dc117ca97)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivateCareerContext.cs.md#symbol-2e7904202268)；[`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivatePublicContext.cs.md#symbol-9d0bf89294e6)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.SeasonCeremony.ClubAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord, int, int, string)`](SeasonCeremony.cs.md#symbol-fe41ed2f86ab)；[`NationalSpire.SeasonCeremony.CreateWeeklyCover(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](SeasonCeremony.cs.md#symbol-336cc50dfb1f)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)；[`Preview()`](EventPoolScreen.cs.md#symbol-b782199d79a0)；[`Render(string)`](WorldEvents.cs.md#symbol-0a7400ef15d9)；[`Side(string, string)`](PrivateAppointments.cs.md#symbol-023dd4ead03f)

**调用：** [`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Name`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`Club(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Club(d, id)?.Name`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc31e7fdf9be"></a>

## `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string) — public static string ClubOf(CareerData d, string id)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-dd22ca4c2081)；[`NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](CircuitWorld.cs.md#symbol-5de3ffb44c8c)；[`NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-77e4a21ef766)；[`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-ce6c8ab6f6c1)；[`NationalSpire.EsportsWorld.HistoricClub(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](EsportsWorld.cs.md#symbol-81aa159a5766)；[`NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-b71e93b6ac2e)；[`NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](EsportsWorld.cs.md#symbol-941a3a6d3975)；[`NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-dcf87e8a91bd)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.EsportsCareer.ClubId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.ClubId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4649beba59f6"></a>

## `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string) — public static string CountryOf(CareerData d, string id)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-dd22ca4c2081)；[`NationalSpire.CircuitWorld.Replace(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](CircuitWorld.cs.md#symbol-5de3ffb44c8c)；[`NationalSpire.CircuitWorld.Snapshot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-77e4a21ef766)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-ce6c8ab6f6c1)；[`NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](EsportsWorld.cs.md#symbol-9f5901f85a89)；[`NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](EsportsWorld.cs.md#symbol-941a3a6d3975)；[`NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-dcf87e8a91bd)；[`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-fdba5c7c50e5)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.Country`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81aa159a5766"></a>

## `NationalSpire.EsportsWorld.HistoricClub(NationalSpire.CareerData, NationalSpire.WorldCompetition, string) — public static string HistoricClub(CareerData d, WorldCompetition c, string id)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.EntrantClubs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, id)`；返回值紧邻使用处：`ArgumentSyntax: ClubOf(d, id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`c.EntrantClubs.GetValueOrDefault(id, ClubOf(d, id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => c.EntrantClubs.GetValueOrDefault(id, ClubOf(d, id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f5901f85a89"></a>

## `NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string) — public static string HistoricCountry(CareerData d, WorldCompetition c, string id)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)

**调用：** [`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.EntrantCountries`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`CountryOf(d, id)`；返回值紧邻使用处：`ArgumentSyntax: CountryOf(d, id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`c.EntrantCountries.GetValueOrDefault(id, CountryOf(d, id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => c.EntrantCountries.GetValueOrDefault(id, CountryOf(d, id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3cac74060cf6"></a>

## `NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string) — public static int RatingOf(CareerData d, string id)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Rating`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Rating`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.Rating`

**赋值（含属性/字段和局部值）：**


<a id="symbol-62a2968b7960"></a>

## `NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData) — public static bool CanEnterMasters(CareerData d)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)

**调用：** `string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.EsportsCareer.Honors`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("continental-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("worldcup-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("worldfinal-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Any(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind is "worldfinal" or "continental" or "worldcup")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.CircuitAwards.Any(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind is "worldfinal" or "continental" or "worldcup")          || d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-"))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-"))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.CircuitAwards.Any(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind is "worldfinal" or "continental" or "worldcup")          || d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-"))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c10dfd5a2e0e"></a>

## `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson) — public static bool IsProfessional(CareerPerson p)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoContent.Ensure(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-be5fe8cf27bd)；[`NationalSpire.CareerEngine.WorldActivity(NationalSpire.CareerData, System.Random)`](CareerEngine.cs.md#symbol-03d4a3e5e0cd)；[`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-77d0573f3e7a)；[`NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CareerNarrative.cs.md#symbol-63592bc97cd1)；[`NationalSpire.CareerNarrative.NewsAudience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-0dd83004ae4e)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-89a5b7a8727b)；[`NationalSpire.CharacterDeletion.Candidates(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.CareerPerson)`](CharacterDeletion.cs.md#symbol-5613d18b588d)；[`NationalSpire.CircuitPeople.Ensure(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-f59ba7354968)；[`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-d77bf6cf914a)；[`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`](CircuitWorld.cs.md#symbol-4d6f1758c06b)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubOperations.TryTransfer(NationalSpire.CareerData, NationalSpire.CareerClub)`](ClubOperations.cs.md#symbol-91ececd875b5)；[`NationalSpire.CoachLineups.MemberError(NationalSpire.CareerData, string, string, string, string?, string?)`](CoachLineups.cs.md#symbol-ee32acfaf806)；[`NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CoachLineups.cs.md#symbol-f16167ebabfe)；[`NationalSpire.CoachLineups.RefreshAiStarters(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-f8128db20387)；[`NationalSpire.CoachLineups.Roster(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-e679a8998422)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)；[`NationalSpire.EsportsWorld.TransferWindow(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-d57dc117ca97)；[`NationalSpire.MatchRules.SimulatePerformance(NationalSpire.CareerPerson, int, string, bool, double, double, int, int?)`](MatchRules.cs.md#symbol-ce476ea84a29)；[`NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random)`](NationalDevelopment.cs.md#symbol-620f6dd04f3a)；[`NationalSpire.SeasonCeremony.Preview(NationalSpire.CareerData)`](SeasonCeremony.cs.md#symbol-0a574d9cff35)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)；[`NationalSpire.WorldEvents.PublishDaily(NationalSpire.CareerData, System.Random, string)`](WorldEvents.cs.md#symbol-8fcd6ba2bc77)；[`NationalSpire.WorldPeople.Enrich(NationalSpire.CareerData)`](WorldPeople.cs.md#symbol-243cbdaa90c2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c0445cae874d"></a>

## `NationalSpire.EsportsWorld.StageName(string) — public static string StageName(string kind)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8ca865fa29de"></a>

## `NationalSpire.EsportsWorld.CupRound(string, int) — public static string CupRound(string kind, int round)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** `System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(round - 1, 0, 2)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(round - 1, 0, 2)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(round - 1, 0, 3)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(round - 1, 0, 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fce13966e68e"></a>

## `NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition) — public static IEnumerable<CareerStanding> Ranked(WorldCompetition c)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-dfb7f2f9a1ef)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivateCareerContext.cs.md#symbol-2e7904202268)；[`NationalSpire.SettlementRecords.Capture(NationalSpire.CareerData, NationalSpire.CareerMatch, int)`](SettlementRecord.cs.md#symbol-8ce7adcb9168)；[`NationalSpire.SettlementRecords.CaptureCompetition(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.WorldCompetition, int, System.Collections.Generic.Dictionary<string, int>)`](SettlementRecord.cs.md#symbol-62f41904fd5e)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStanding.Clears`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CareerStanding.Points`；`NationalSpire.CareerStanding.Wins`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Table`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Table.OrderByDescending(x => x.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Table.OrderByDescending(x => x.Points).ThenByDescending`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Entrants.IndexOf(x.PersonId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => c.Entrants.IndexOf(x.PersonId)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins).ThenByDescending(x => x.Clears).ThenBy(x => c.Entrants.IndexOf(x.PersonId))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins).ThenByDescending(x => x.Clears).ThenBy(x => c.Entrants.IndexOf(x.PersonId))`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins).ThenByDescending(x => x.Clears)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins).ThenByDescending(x => x.Clears).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins).ThenByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fcdf6a1b178e"></a>

## `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData) — public static WorldCompetition? PlayerLeague(CareerData d)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AwardSeason(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-5263bac7b01c)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-dfb7f2f9a1ef)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.EsportsWorld.NextGoal(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-469e0396c2c6)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?)`](OwnedClubSchedule.cs.md#symbol-e637b6152d8b)；[`NationalSpire.OwnedClubSchedule.Rebuild(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](OwnedClubSchedule.cs.md#symbol-def76591afef)

**调用：** [`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`Club(d, d.Esports.ClubId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Club(d, d.Esports.ClubId)?.Country`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == "league" && c.Country == (Club(d, d.Esports.ClubId)?.Country ?? d.Esports.Country))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == "league" && c.Country == (Club(d, d.Esports.ClubId)?.Country ?? d.Esports.Country))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dfb7f2f9a1ef"></a>

## `NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData) — public static int DomesticRank(CareerData d)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AwardSeason(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-5263bac7b01c)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** [`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-fce13966e68e)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStanding.PersonId`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.PlayerEntered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`PlayerLeague(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerLeague(d)`
- `NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；输入表达式：`Ranked(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(c).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Ranked(c).ToList()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(c).ToList().FindIndex`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`Ranked(c).ToList().FindIndex(x => x.PersonId == "player")`；返回值紧邻使用处：`BinaryExpressionSyntax: Ranked(c).ToList().FindIndex(x => x.PersonId == "player") + 1`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ca5840a56e8d"></a>

## `NationalSpire.EsportsWorld.Initialize(NationalSpire.CareerData) — public static void Initialize(CareerData d)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`](EsportsWorld.cs.md#symbol-ae784907b7fa)；[`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-6c986135b9e6)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult)`](PrivateAppointments.cs.md#symbol-31b52db37f88)；[`NationalSpire.RegionalOrganizations.ClubName(NationalSpire.CareerData, string, string)`](RegionalOrganizations.cs.md#symbol-2dfd9499c981)；[`NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`](WorldPeople.cs.md#symbol-731e781389c6)；`NationalSpire.CareerClub.CareerClub()`；`NationalSpire.CareerPerson.CareerPerson()`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Color`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Motto`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Region`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.Win`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Initialized`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsWorld.Characters`；`NationalSpire.EsportsWorld.ClubNames`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsWorld.Styles`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult)`；`NationalSpire.RegionalOrganizations.ClubName(NationalSpire.CareerData, string, string)`；`NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerClub.CareerClub()`；输入表达式：`new CareerClub              {                  Id = $"c{country}{club}", Name = country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}"), Country = Countries[country],                  Color = new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[(country + club) % 4],                  Motto = club == 0 ? "传统强队，重视稳定的赛季成绩" : "新锐阵容，愿意给有成绩的新选手机会"              }`；返回值紧邻使用处：`ArgumentSyntax: new CareerClub              {                  Id = $"c{country}{club}", Name = country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}"), Country = Countries[country],                  Color = new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[(country + club) % 4],                  Motto = club == 0 ? "传统强队，重视稳定的赛季成绩" : "新锐阵容，愿意给有成绩的新选手机会"              }`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, "p" + i)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, "p" + i) is { } p`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, id)`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "ecosystem", "新的职业赛制公布：从社区走向世界", "社区杯→城市公开赛→青训选拔→职业俱乐部。国内联赛前二获得洲际杯候选资格；每两个赛季举行国家队世界杯，国家队还要求进阶八通关履历。所有国家的赛事都会独立进行。", "赛事公告", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "ecosystem", "新的职业赛制公布：从社区走向世界", "社区杯→城市公开赛→青训选拔→职业俱乐部。国内联赛前二获得洲际杯候选资格；每两个赛季举行国家队世界杯，国家队还要求进阶八通关履历。所有国家的赛事都会独立进行。", "赛事公告", false);`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = "caster", Name = "解说席·闻笙", Role = "解说员", Country = "中国", Region = "赛事转播", MaxAscension = 4, Character = "静默猎手", Style = "按传统流派解释打法", Wins = 4, Losses = 51, Voice = "善于营造大赛气氛，不理解玩家真实思路" }`；返回值紧邻使用处：`ArgumentSyntax: new CareerPerson { Id = "caster", Name = "解说席·闻笙", Role = "解说员", Country = "中国", Region = "赛事转播", MaxAscension = 4, Character = "静默猎手", Style = "按传统流派解释打法", Wins = 4, Losses = 51, Voice = "善于营造大赛气氛，不理解玩家真实思路" }`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = "desk", Name = "尖塔赛事中心", Role = "赛事记者", Country = "中国", Region = "国际赛事编辑部", MaxAscension = 2, Character = "铁甲战士", Style = "整理公开战报", Wins = 2, Losses = 32, Voice = "区分事实与评论，只引用已确认赛果" }`；返回值紧邻使用处：`ArgumentSyntax: new CareerPerson { Id = "desk", Name = "尖塔赛事中心", Role = "赛事记者", Country = "中国", Region = "国际赛事编辑部", MaxAscension = 2, Character = "铁甲战士", Style = "整理公开战报", Wins = 2, Losses = 32, Voice = "区分事实与评论，只引用已确认赛果" }`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = $"fan{country}_{i}", Name = WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true), Country = Countries[country], Region = Countries[country] + "社区", Role = "普通玩家", MaxAscension = i + 1, Character = Characters[(country + i) % 5], Style = "偏爱稀有牌", Rating = 650 + country * 8, Wins = 1 + i, Losses = 40 + country, Voice = i == 0 ? "主队球迷，情绪热烈" : "普通观众，经常在第一幕失败" }`；返回值紧邻使用处：`ArgumentSyntax: new CareerPerson { Id = $"fan{country}_{i}", Name = WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true), Country = Countries[country], Region = Countries[country] + "社区", Role = "普通玩家", MaxAscension = i + 1, Character = Characters[(country + i) % 5], Style = "偏爱稀有牌", Rating = 650 + country * 8, Wins = 1 + i, Losses = 40 + country, Voice = i == 0 ? "主队球迷，情绪热烈" : "普通观众，经常在第一幕失败" }`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = $"y{country}_{i}", Name = WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false), Country = Countries[country], Region = Countries[country] + "青训中心", ClubId = $"c{country}{i}", Role = "青训选手", MaxAscension = 6 + i, Character = Characters[(country + i) % 5], Style = Styles[(country + i) % 5], Rating = 1040 + i * 60, Wins = 6 + i, Losses = 55 + country, Voice = "渴望职业合同，容易模仿明星的构筑" }`；返回值紧邻使用处：`ArgumentSyntax: new CareerPerson { Id = $"y{country}_{i}", Name = WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false), Country = Countries[country], Region = Countries[country] + "青训中心", ClubId = $"c{country}{i}", Role = "青训选手", MaxAscension = 6 + i, Character = Characters[(country + i) % 5], Style = Styles[(country + i) % 5], Rating = 1040 + i * 60, Wins = 6 + i, Losses = 55 + country, Voice = "渴望职业合同，容易模仿明星的构筑" }`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = id, Name = WorldPeople.Name(d, id, Countries[country], false) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: p = new CareerPerson { Id = id, Name = WorldPeople.Name(d, id, Countries[country], false) }`
- `NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`；输入表达式：`EndDay(d, day, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: EndDay(d, day, false);`
- `NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；输入表达式：`MakeOffers(d, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: MakeOffers(d, false);`
- `NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`；输入表达式：`StartSeason(d, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: StartSeason(d, true);`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult)`；输入表达式：`PrivateAppointments.IsPrivate(r)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateAppointments.IsPrivate(r)`
- `NationalSpire.RegionalOrganizations.ClubName(NationalSpire.CareerData, string, string)`；输入表达式：`RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}")`；返回值紧邻使用处：`ConditionalExpressionSyntax: country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}")`
- `NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`；输入表达式：`WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true)`
- `NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`；输入表达式：`WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false)`
- `NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`；输入表达式：`WorldPeople.Name(d, id, Countries[country], false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = WorldPeople.Name(d, id, Countries[country], false)`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.BestClear = d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Clubs.Add(new CareerClub              {                  Id = $"c{country}{club}", Name = country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}"), Country = Countries[country],                  Color = new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[(country + club) % 4],                  Motto = club == 0 ? "传统强队，重视稳定的赛季成绩" : "新锐阵容，愿意给有成绩的新选手机会"              })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Clubs.Add(new CareerClub              {                  Id = $"c{country}{club}", Name = country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}"), Country = Countries[country],                  Color = new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[(country + club) % 4],                  Motto = club == 0 ? "传统强队，重视稳定的赛季成绩" : "新锐阵容，愿意给有成绩的新选手机会"              });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.People.Add(new CareerPerson { Id = "caster", Name = "解说席·闻笙", Role = "解说员", Country = "中国", Region = "赛事转播", MaxAscension = 4, Character = "静默猎手", Style = "按传统流派解释打法", Wins = 4, Losses = 51, Voice = "善于营造大赛气氛，不理解玩家真实思路" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Add(new CareerPerson { Id = "caster", Name = "解说席·闻笙", Role = "解说员", Country = "中国", Region = "赛事转播", MaxAscension = 4, Character = "静默猎手", Style = "按传统流派解释打法", Wins = 4, Losses = 51, Voice = "善于营造大赛气氛，不理解玩家真实思路" });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.People.Add(new CareerPerson { Id = "desk", Name = "尖塔赛事中心", Role = "赛事记者", Country = "中国", Region = "国际赛事编辑部", MaxAscension = 2, Character = "铁甲战士", Style = "整理公开战报", Wins = 2, Losses = 32, Voice = "区分事实与评论，只引用已确认赛果" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Add(new CareerPerson { Id = "desk", Name = "尖塔赛事中心", Role = "赛事记者", Country = "中国", Region = "国际赛事编辑部", MaxAscension = 2, Character = "铁甲战士", Style = "整理公开战报", Wins = 2, Losses = 32, Voice = "区分事实与评论，只引用已确认赛果" });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.People.Add(new CareerPerson { Id = $"fan{country}_{i}", Name = WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true), Country = Countries[country], Region = Countries[country] + "社区", Role = "普通玩家", MaxAscension = i + 1, Character = Characters[(country + i) % 5], Style = "偏爱稀有牌", Rating = 650 + country * 8, Wins = 1 + i, Losses = 40 + country, Voice = i == 0 ? "主队球迷，情绪热烈" : "普通观众，经常在第一幕失败" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Add(new CareerPerson { Id = $"fan{country}_{i}", Name = WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true), Country = Countries[country], Region = Countries[country] + "社区", Role = "普通玩家", MaxAscension = i + 1, Character = Characters[(country + i) % 5], Style = "偏爱稀有牌", Rating = 650 + country * 8, Wins = 1 + i, Losses = 40 + country, Voice = i == 0 ? "主队球迷，情绪热烈" : "普通观众，经常在第一幕失败" });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.People.Add(new CareerPerson { Id = $"y{country}_{i}", Name = WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false), Country = Countries[country], Region = Countries[country] + "青训中心", ClubId = $"c{country}{i}", Role = "青训选手", MaxAscension = 6 + i, Character = Characters[(country + i) % 5], Style = Styles[(country + i) % 5], Rating = 1040 + i * 60, Wins = 6 + i, Losses = 55 + country, Voice = "渴望职业合同，容易模仿明星的构筑" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Add(new CareerPerson { Id = $"y{country}_{i}", Name = WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false), Country = Countries[country], Region = Countries[country] + "青训中心", ClubId = $"c{country}{i}", Role = "青训选手", MaxAscension = 6 + i, Character = Characters[(country + i) % 5], Style = Styles[(country + i) % 5], Rating = 1040 + i * 60, Wins = 6 + i, Losses = 55 + country, Voice = "渴望职业合同，容易模仿明星的构筑" });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.People.Add(p)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Add(p);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Matches.RemoveAll(m => m.Kind == "legacy" && m.Status == "待赛" && m.Id != d.PendingMatchId)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.RemoveAll(m => m.Kind == "legacy" && m.Status == "待赛" && m.Id != d.PendingMatchId);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(d.Esports.License, d.Esports.BestClear >= 8 ? 3 : d.Wins >= 2 ? 2 : d.Wins >= 1 ? 1 : 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.License = Math.Max(d.Esports.License, d.Esports.BestClear >= 8 ? 3 : d.Wins >= 2 ? 2 : d.Wins >= 1 ? 1 : 0)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(p.Losses, 70 + country * 9 + i * 3)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Losses = Math.Max(p.Losses, 70 + country * 9 + i * 3)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(p.Wins, 12 + i * 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Wins = Math.Max(p.Wins, 12 + i * 2)`

**赋值（含属性/字段和局部值）：**

- `Character` = `"静默猎手"`
- `Character` = `"铁甲战士"`
- `Character` = `Characters[(country + i) % 5]`
- `ClubId` = `$"c{country}{i}"`
- `Color` = `new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[(country + club) % 4]`
- `Country` = `"中国"`
- `Country` = `Countries[country]`
- `d.Esports.BestClear` = `d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max()`
- `d.Esports.Initialized` = `true`
- `d.Esports.License` = `Math.Max(d.Esports.License, d.Esports.BestClear >= 8 ? 3 : d.Wins >= 2 ? 2 : d.Wins >= 1 ? 1 : 0)`
- `Id` = `"caster"`
- `Id` = `"desk"`
- `Id` = `$"c{country}{club}"`
- `Id` = `$"fan{country}_{i}"`
- `Id` = `$"y{country}_{i}"`
- `Id` = `id`
- `Losses` = `32`
- `Losses` = `40 + country`
- `Losses` = `51`
- `Losses` = `55 + country`
- `MaxAscension` = `2`
- `MaxAscension` = `4`
- `MaxAscension` = `6 + i`
- `MaxAscension` = `i + 1`
- `Motto` = `club == 0 ? "传统强队，重视稳定的赛季成绩" : "新锐阵容，愿意给有成绩的新选手机会"`
- `Name` = `"尖塔赛事中心"`
- `Name` = `"解说席·闻笙"`
- `Name` = `country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}")`
- `Name` = `WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true)`
- `Name` = `WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false)`
- `Name` = `WorldPeople.Name(d, id, Countries[country], false)`
- `p.Character` = `Characters[(country + i) % 5]`
- `p.ClubId` = `""`
- `p.ClubId` = `$"c{country}{i / 4}"`
- `p.Country` = `Countries[country]`
- `p.Country` = `d.Esports.Country`
- `p.Losses` = `Math.Max(p.Losses, 70 + country * 9 + i * 3)`
- `p.MaxAscension` = `6 + i % 2`
- `p.MaxAscension` = `i == 5 ? 9 : 8`
- `p.Rating` = `1280 + i * 18 + country * 7`
- `p.Region` = `Countries[country] + "职业赛区"`
- `p.Role` = `"青训选手"`
- `p.Role` = `i == 5 ? "世界顶尖" : "职业选手"`
- `p.Style` = `Styles[(country + i) % 5]`
- `p.Voice` = `new[] { "传统派，喜欢用熟悉流派解释比赛", "谨慎，会先核对交手战绩", "自信，败给强者后愿意承认差距", "重视俱乐部荣誉，偏爱本队选手" }[i % 4]`
- `p.Wins` = `Math.Max(p.Wins, 12 + i * 2)`
- `p` = `new CareerPerson { Id = id, Name = WorldPeople.Name(d, id, Countries[country], false) }`
- `Rating` = `1040 + i * 60`
- `Rating` = `650 + country * 8`
- `Region` = `"国际赛事编辑部"`
- `Region` = `"赛事转播"`
- `Region` = `Countries[country] + "青训中心"`
- `Region` = `Countries[country] + "社区"`
- `Role` = `"解说员"`
- `Role` = `"普通玩家"`
- `Role` = `"青训选手"`
- `Role` = `"赛事记者"`
- `Style` = `"按传统流派解释打法"`
- `Style` = `"偏爱稀有牌"`
- `Style` = `"整理公开战报"`
- `Style` = `Styles[(country + i) % 5]`
- `Voice` = `"渴望职业合同，容易模仿明星的构筑"`
- `Voice` = `"区分事实与评论，只引用已确认赛果"`
- `Voice` = `"善于营造大赛气氛，不理解玩家真实思路"`
- `Voice` = `i == 0 ? "主队球迷，情绪热烈" : "普通观众，经常在第一幕失败"`
- `Wins` = `1 + i`
- `Wins` = `2`
- `Wins` = `4`
- `Wins` = `6 + i`

<a id="symbol-1e2b623aabf2"></a>

## `NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool) — public static void StartSeason(CareerData d, bool migrating = false)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.EsportsWorld.Initialize(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-ca5840a56e8d)

**调用：** [`Add(int, string, string, int, int, string, int)`](EsportsWorld.cs.md#symbol-5183cd28391b)；[`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)；[`NationalSpire.EsportsWorld.CupRound(string, int)`](EsportsWorld.cs.md#symbol-8ca865fa29de)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-6c986135b9e6)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)；[`NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-dcf87e8a91bd)；[`NationalSpire.EsportsWorld.StageName(string)`](EsportsWorld.cs.md#symbol-c0445cae874d)；[`NationalSpire.EsportsWorld.TransferWindow(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-d57dc117ca97)；`NationalSpire.CareerStanding.CareerStanding()`；`NationalSpire.WorldCompetition.WorldCompetition()`；`NationalSpire.WorldFixture.WorldFixture()`；`string.StartsWith(string)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Insert(int, T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `Add(int, string, string, int, int, string, int)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`；`NationalSpire.ClubOffer.ExpiresDay`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.NationalTeam`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.EsportsWorld.CupRound(string, int)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.StageName(string)`；`NationalSpire.EsportsWorld.TransferWindow(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(int, string, string, int, int, string, int)`；输入表达式：`Add(26 - (rounds - r) * 2, cup, StageName(cup) + " · " + CupRound(cup, r), r == rounds ? 9 : 8, 400 + r * 180, round: r)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(26 - (rounds - r) * 2, cup, StageName(cup) + " · " + CupRound(cup, r), r == rounds ? 9 : 8, 400 + r * 180, round: r);`
- `Add(int, string, string, int, int, string, int)`；输入表达式：`Add(28, "masters", "世界纪录邀请赛", 10, 1200, d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating).First().Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(28, "masters", "世界纪录邀请赛", 10, 1200, d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating).First().Id);`
- `Add(int, string, string, int, int, string, int)`；输入表达式：`Add(3, "local", "街区周末杯", 0, 45, locals[d.Season % locals.Count].Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(3, "local", "街区周末杯", 0, 45, locals[d.Season % locals.Count].Id);`
- `Add(int, string, string, int, int, string, int)`；输入表达式：`Add(6, "city", "城市新秀公开赛", 3, 100, d.People.First(p => p.Role == "青训选手" && p.Country == d.Esports.Country).Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(6, "city", "城市新秀公开赛", 3, 100, d.People.First(p => p.Role == "青训选手" && p.Country == d.Esports.Country).Id);`
- `Add(int, string, string, int, int, string, int)`；输入表达式：`Add(9 + r * 3, "league", $"职业联赛 · 第 {r} 轮", 8, 260, round: r)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(9 + r * 3, "league", $"职业联赛 · 第 {r} 轮", 8, 260, round: r);`
- `Add(int, string, string, int, int, string, int)`；输入表达式：`Add(9, "academy", "职业青训选拔赛", 6, 180, "p15")`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(9, "academy", "职业青训选拔赛", 6, 180, "p15");`
- `NationalSpire.CareerStanding.CareerStanding()`；输入表达式：`new CareerStanding { PersonId = id }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => new CareerStanding { PersonId = id }`
- `NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.StartSeason(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.StartSeason(d);`
- `NationalSpire.EsportsWorld.CupRound(string, int)`；输入表达式：`CupRound(cup, r)`；返回值紧邻使用处：`BinaryExpressionSyntax: StageName(cup) + " · " + CupRound(cup, r)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Country == country && IsProfessional(p)`
- `NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；输入表达式：`MakeOffers(d, d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-")))`；返回值紧邻使用处：`ExpressionStatementSyntax: MakeOffers(d, d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-")));`
- `NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；输入表达式：`MakeOffers(d, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: MakeOffers(d, false);`
- `NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；输入表达式：`RefreshLeagueMatches(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshLeagueMatches(d);`
- `NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SnapshotEntrants(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: SnapshotEntrants(d, c);`
- `NationalSpire.EsportsWorld.StageName(string)`；输入表达式：`StageName(cup)`；返回值紧邻使用处：`BinaryExpressionSyntax: StageName(cup) + " · "`
- `NationalSpire.EsportsWorld.TransferWindow(NationalSpire.CareerData)`；输入表达式：`TransferWindow(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: TransferWindow(d);`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new WorldCompetition { Id = $"league-{d.Season}-{Array.IndexOf(Countries, country)}", Name = country + "职业联赛", Country = country, Season = d.Season, Entrants = entrants, Table = entrants.Select(id => new CareerStanding { PersonId = id }).ToList() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new WorldCompetition { Id = $"league-{d.Season}-{Array.IndexOf(Countries, country)}", Name = country + "职业联赛", Country = country, Season = d.Season, Entrants = entrants, Table = entrants.Select(id => new CareerStanding { PersonId = id }).ToList() }`
- `NationalSpire.WorldFixture.WorldFixture()`；输入表达式：`new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = start + 9 + round * 3, Round = round, HomeId = rotation[i], AwayId = rotation[7 - i] }`；返回值紧邻使用处：`ArgumentSyntax: new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = start + 9 + round * 3, Round = round, HomeId = rotation[i], AwayId = rotation[7 - i] }`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("continental-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("worldcup-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("worldfinal-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-")`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(Countries, country)`；返回值紧邻使用处：`InterpolationSyntax: {Array.IndexOf(Countries, country)}`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-"))`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-"))`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating).First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating).First().Id`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.First(p => p.Role == "青训选手" && p.Country == d.Esports.Country)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.First(p => p.Role == "青训选手" && p.Country == d.Esports.Country).Id`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Matches.OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.OrderBy(m => m.Day).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating).First`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8).Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entrants.Select(id => new CareerStanding { PersonId = id })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entrants.Select(id => new CareerStanding { PersonId = id }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.OrderBy(m => m.Day).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Matches = d.Matches.OrderBy(m => m.Day).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8).Select(p => p.Id).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8).Select(p => p.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.Country == d.Esports.Country && p.Role == "普通玩家").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Country == d.Esports.Country && p.Role == "普通玩家").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entrants.Select(id => new CareerStanding { PersonId = id }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Table = entrants.Select(id => new CareerStanding { PersonId = id }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entrants.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entrants.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == country && IsProfessional(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == d.Esports.Country && p.Role == "普通玩家")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == d.Esports.Country && p.Role == "普通玩家").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.MaxAscension == 9)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.MaxAscension == 9).OrderByDescending`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Fixtures.Add(new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = start + 9 + round * 3, Round = round, HomeId = rotation[i], AwayId = rotation[7 - i] })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Fixtures.Add(new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = start + 9 + round * 3, Round = round, HomeId = rotation[i], AwayId = rotation[7 - i] });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Competitions.Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.Add(c);`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`rotation.Insert(1, rotation[^1])`；返回值紧邻使用处：`ExpressionStatementSyntax: rotation.Insert(1, rotation[^1]);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.Competitions.RemoveAll(c => c.Season < d.Season - 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.RemoveAll(c => c.Season < d.Season - 4);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.Offers.RemoveAll(o => o.ExpiresDay < d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.RemoveAll(o => o.ExpiresDay < d.Day);`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`rotation.RemoveAt(rotation.Count - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: rotation.RemoveAt(rotation.Count - 1);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take`

**赋值（含属性/字段和局部值）：**

- `AwayId` = `rotation[7 - i]`
- `Country` = `country`
- `d.Esports.NationalTeam` = `false`
- `d.Matches` = `d.Matches.OrderBy(m => m.Day).ToList()`
- `Day` = `start + 9 + round * 3`
- `Entrants` = `entrants`
- `HomeId` = `rotation[i]`
- `Id` = `$"{c.Id}-{round}-{i}"`
- `Id` = `$"league-{d.Season}-{Array.IndexOf(Countries, country)}"`
- `Name` = `country + "职业联赛"`
- `PersonId` = `id`
- `Round` = `round`
- `Season` = `d.Season`
- `Table` = `entrants.Select(id => new CareerStanding { PersonId = id }).ToList()`

<a id="symbol-5183cd28391b"></a>

## `Add(int, string, string, int, int, string, int) — void Add(int day, string kind, string title, int ascension, int prize, string opponent = "", int round = 0)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`NationalSpire.CareerMatch.CareerMatch()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Prize`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CareerMatch.Seed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + kind + d.Season + round)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}`
- `NationalSpire.CareerMatch.CareerMatch()`；输入表达式：`new CareerMatch { Day = start + day, Kind = kind, Event = title, OpponentId = opponent, RequiredAscension = ascension, Prize = prize, Round = round, Seed = $"NS{d.Season:X}{day:X}{CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}" }`；返回值紧邻使用处：`ArgumentSyntax: new CareerMatch { Day = start + day, Kind = kind, Event = title, OpponentId = opponent, RequiredAscension = ascension, Prize = prize, Round = round, Seed = $"NS{d.Season:X}{day:X}{CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}" }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Any(m => m.Id == d.PendingMatchId && m.Day == start + day)`；返回值紧邻使用处：`BinaryExpressionSyntax: migrating && start + day < d.Day || d.Matches.Any(m => m.Id == d.PendingMatchId && m.Day == start + day)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Matches.Add(new CareerMatch { Day = start + day, Kind = kind, Event = title, OpponentId = opponent, RequiredAscension = ascension, Prize = prize, Round = round, Seed = $"NS{d.Season:X}{day:X}{CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.Add(new CareerMatch { Day = start + day, Kind = kind, Event = title, OpponentId = opponent, RequiredAscension = ascension, Prize = prize, Round = round, Seed = $"NS{d.Season:X}{day:X}{CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}" });`

**赋值（含属性/字段和局部值）：**

- `Day` = `start + day`
- `Event` = `title`
- `Kind` = `kind`
- `OpponentId` = `opponent`
- `Prize` = `prize`
- `RequiredAscension` = `ascension`
- `Round` = `round`
- `Seed` = `$"NS{d.Season:X}{day:X}{CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}"`

<a id="symbol-b71e93b6ac2e"></a>

## `NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition) — private static string LeagueSlot(CareerData d, WorldCompetition c)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.PlayerEntered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubOf(d, id) == d.Esports.ClubId`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Entrants.LastOrDefault(id => ClubOf(d, id) == d.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.LastOrDefault(id => ClubOf(d, id) == d.Esports.ClubId) ?? c.Entrants[^1]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6b77d7c9e9bf"></a>

## `NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData) — public static bool RefreshLeagueMatches(CareerData d)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** [`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-bf4a0401a0ec)；[`NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-b71e93b6ac2e)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-fdba5c7c50e5)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.SchedulePlayer(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.SchedulePlayer(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.SchedulePlayer(d, c);`
- `NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LeagueSlot(d, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.AwayId == LeagueSlot(d, c)`
- `NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LeagueSlot(d, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.HomeId == LeagueSlot(d, c)`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`PlayerLeague(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerLeague(d)`
- `NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LeagueRosterRepair.Apply(d, c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LeagueRosterRepair.Apply(d, c)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == LeagueSlot(d, c) || f.AwayId == LeagueSlot(d, c)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == LeagueSlot(d, c) || f.AwayId == LeagueSlot(d, c)))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.Kind == "league" && m.Day > (d.Season - 1) * 28 && m.Day <= d.Season * 28 && m.Status == "待赛")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in d.Matches.Where(m => m.Kind == "league" && m.Day > (d.Season - 1) * 28 && m.Day <= d.Season * 28 && m.Status == "待赛"))          {              var f = c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == LeagueSlot(d, c) || f.AwayId == LeagueSlot(d, c)));              if (f == null) continue;              m.CompetitionId = c.Id; m.FixtureId = f.Id; m.Event = c.Name + $" · 第 {m.Round} 轮";              m.OpponentId = f.HomeId == LeagueSlot(d, c) ? f.AwayId : f.HomeId;          }`

**赋值（含属性/字段和局部值）：**

- `d.Standings` = `c.PlayerEntered ? c.Table : []`
- `m.CompetitionId` = `c.Id`
- `m.Event` = `c.Name + $" · 第 {m.Round} 轮"`
- `m.FixtureId` = `f.Id`
- `m.OpponentId` = `f.HomeId == LeagueSlot(d, c) ? f.AwayId : f.HomeId`

<a id="symbol-4b9f3e1bf70a"></a>

## `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static string? EntryReason(CareerData d, CareerMatch m)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.ExcludedAutomaticPreview(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CareerEngine.cs.md#symbol-ff6b96537297)；[`NationalSpire.CareerEngine.NextAvailable(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-0b8521a25ad9)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?)`](Coop/CoopRules.cs.md#symbol-570bf786ec18)；[`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-b694be794ed8)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.PlayerSimulation.Run(NationalSpire.CareerData, NationalSpire.CareerMatch, string, string, int?)`](PlayerSimulation.cs.md#symbol-4d8d262e25f1)；[`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；[`NationalSpire.PublicSchedule.Capture(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](PublicSchedule.cs.md#symbol-0253014360da)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-62a2968b7960)；[`NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-dfb7f2f9a1ef)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Round`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, m.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(d, m.OpponentId) == null`
- `NationalSpire.EsportsWorld.CanEnterMasters(NationalSpire.CareerData)`；输入表达式：`CanEnterMasters(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CanEnterMasters(d) ? null : "仅邀请国际赛事冠军，且需要进阶九通关履历。"`
- `NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`；输入表达式：`DomesticRank(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DomesticRank(d) is < 1 or > 2`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`PlayerLeague(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerLeague(d)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d) + 19)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, SeasonCalendar.Start(d) + 19)}`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateAppointments.IsPrivate(m)) return CareerEngine.Person(d, m.OpponentId) == null ? "约战对象已不存在。" : null;`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + 19`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`cup.Fixtures.Any(f => f.Id == m.FixtureId && (f.HomeId == "player" || f.AwayId == "player"))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !cup.Fixtures.Any(f => f.Id == m.FixtureId && (f.HomeId == "player" || f.AwayId == "player"))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)?.Modern`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == m.Kind)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == m.Kind)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b694be794ed8"></a>

## `NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData) — public static bool ClearInvalidRegistrations(CareerData d)`

来源：源码第 182 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerEngine.PublishMatchDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-1e1428a365f6)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.EsportsWorld.AfterPlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool)`](EsportsWorld.cs.md#symbol-c0b4fbf0a978)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)

**调用：** [`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RegistrationDeclined`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EntryReason(d, match)`；返回值紧邻使用处：`BinaryExpressionSyntax: EntryReason(d, match) != null`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.Registered && m.Status == "待赛" && m.Id != d.PendingMatchId              && m.Kind is "local" or "city" or "academy")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in d.Matches.Where(m => m.Registered && m.Status == "待赛" && m.Id != d.PendingMatchId              && m.Kind is "local" or "city" or "academy"))              if (EntryReason(d, match) != null) { match.Registered = false; match.RegistrationDeclined = true; changed = true; }`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `match.Registered` = `false`
- `match.RegistrationDeclined` = `true`

<a id="symbol-3857851acceb"></a>

## `NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool) — public static string? Register(CareerData d, CareerMatch m, bool value)`

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-ce6c8ab6f6c1)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-b71e93b6ac2e)；[`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`](EsportsWorld.cs.md#symbol-83220601bb1f)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-713d46cc7d52)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)；[`NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`](EsportsWorld.cs.md#symbol-941a3a6d3975)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RegistrationDeclined`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.NationalTeam`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "international-entry-" + d.Season, m.Kind == "worldcup" ? $"国家队官宣：你将代表{d.Esports.Country}出征" : $"洲际杯首秀：你代表{ClubName(d, d.Esports.ClubId)}进入十六强", "淘汰赛签表已经确认。每轮胜者晋级，平局按抽签时公布的种子顺位判定；后续轮次自动报名。", "国际赛事", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "international-entry-" + d.Season, m.Kind == "worldcup" ? $"国家队官宣：你将代表{d.Esports.Country}出征" : $"洲际杯首秀：你代表{ClubName(d, d.Esports.ClubId)}进入十六强", "淘汰赛签表已经确认。每轮胜者晋级，平局按抽签时公布的种子顺位判定；后续轮次自动报名。", "国际赛事", true);`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "league-entry-" + d.Season, $"{ClubName(d, d.Esports.ClubId)}确认首发：你进入职业联赛", "三轮联赛席位已经确认，赛程将依次推进。积分前二的争夺，将决定国际赛事资格。", "俱乐部", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "league-entry-" + d.Season, $"{ClubName(d, d.Esports.ClubId)}确认首发：你进入职业联赛", "三轮联赛席位已经确认，赛程将依次推进。积分前二的争夺，将决定国际赛事资格。", "俱乐部", true);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {ClubName(d, d.Esports.ClubId)}`
- `NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`CupSlot(d, c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CupSlot(d, c)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EntryReason(d, m)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EntryReason(d, m)`
- `NationalSpire.EsportsWorld.LeagueSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LeagueSlot(d, c)`；返回值紧邻使用处：`ArgumentSyntax: LeagueSlot(d, c)`
- `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；输入表达式：`Milestone(d, "national-debut", "身披国家队战袍", $"你被选为{d.Esports.Country}代表，出征国家队世界杯。", 350, 200)`；返回值紧邻使用处：`ExpressionStatementSyntax: Milestone(d, "national-debut", "身披国家队战袍", $"你被选为{d.Esports.Country}代表，出征国家队世界杯。", 350, 200);`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`PlayerLeague(d)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: PlayerLeague(d)!`
- `NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`RefreshCupMatches(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshCupMatches(d, c);`
- `NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；输入表达式：`RefreshLeagueMatches(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshLeagueMatches(d);`
- `NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；输入表达式：`ReplaceEntrant(d, c, LeagueSlot(d, c), "player")`；返回值紧邻使用处：`ExpressionStatementSyntax: ReplaceEntrant(d, c, LeagueSlot(d, c), "player");`
- `NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string)`；输入表达式：`ReplaceEntrant(d, c, slot, "player")`；返回值紧邻使用处：`ExpressionStatementSyntax: ReplaceEntrant(d, c, slot, "player");`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.First(x => x.Season == d.Season && x.Kind == m.Kind)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.First(x => x.Season == d.Season && x.Kind == m.Kind)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)?.Modern`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(x => x.CompetitionId == c.Id && x.Status == "待赛" && x.Day >= d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var game in d.Matches.Where(x => x.CompetitionId == c.Id && x.Status == "待赛" && x.Day >= d.Day)) game.Registered = true;`

**赋值（含属性/字段和局部值）：**

- `c.PlayerEntered` = `true`
- `d.Esports.NationalTeam` = `true`
- `game.Registered` = `true`
- `m.Registered` = `false`
- `m.Registered` = `true`
- `m.Registered` = `value`
- `m.RegistrationDeclined` = `!value`
- `m.RegistrationDeclined` = `false`
- `m.RegistrationDeclined` = `true`

<a id="symbol-941a3a6d3975"></a>

## `NationalSpire.EsportsWorld.ReplaceEntrant(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, string) — private static void ReplaceEntrant(CareerData d, WorldCompetition c, string oldId, string newId)`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStanding.PersonId`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, newId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantClubs[newId] = ClubOf(d, newId)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`CountryOf(d, newId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantCountries[newId] = CountryOf(d, newId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`c.EntrantClubs.Remove(oldId)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.EntrantClubs.Remove(oldId);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`c.EntrantCountries.Remove(oldId)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.EntrantCountries.Remove(oldId);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Table.FirstOrDefault(x => x.PersonId == oldId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Table.FirstOrDefault(x => x.PersonId == oldId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => !f.Finished)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var f in c.Fixtures.Where(f => !f.Finished)) { if (f.HomeId == oldId) f.HomeId = newId; if (f.AwayId == oldId) f.AwayId = newId; }`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Entrants.IndexOf(oldId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Entrants.IndexOf(oldId)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("赛事席位缺失。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("赛事席位缺失。");`

**赋值（含属性/字段和局部值）：**

- `c.EntrantClubs[newId]` = `ClubOf(d, newId)`
- `c.EntrantCountries[newId]` = `CountryOf(d, newId)`
- `c.Entrants[index]` = `newId`
- `f.AwayId` = `newId`
- `f.HomeId` = `newId`
- `row.PersonId` = `newId`

<a id="symbol-dcf87e8a91bd"></a>

## `NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition) — private static void SnapshotEntrants(CareerData d, WorldCompetition c)`

来源：源码第 238 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Entrants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => ClubOf(d, id)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`CountryOf(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CountryOf(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`c.Entrants.ToDictionary(id => id, id => ClubOf(d, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantClubs = c.Entrants.ToDictionary(id => id, id => ClubOf(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`c.Entrants.ToDictionary(id => id, id => CountryOf(d, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.EntrantCountries = c.Entrants.ToDictionary(id => id, id => CountryOf(d, id))`

**赋值（含属性/字段和局部值）：**

- `c.EntrantClubs` = `c.Entrants.ToDictionary(id => id, id => ClubOf(d, id))`
- `c.EntrantCountries` = `c.Entrants.ToDictionary(id => id, id => CountryOf(d, id))`

<a id="symbol-ce6c8ab6f6c1"></a>

## `NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition) — private static string CupSlot(CareerData d, WorldCompetition c)`

来源：源码第 243 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-713d46cc7d52)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)

**调用：** [`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubOf(d, id) == d.Esports.ClubId`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`CountryOf(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CountryOf(d, id) == d.Esports.Country`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.FirstOrDefault(id => ClubOf(d, id) == d.Esports.ClubId) ?? c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Kind == "worldcup" ? c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country) : c.Entrants.FirstOrDefault(id => ClubOf(d, id) == d.Esports.ClubId) ?? c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Entrants.FirstOrDefault(id => ClubOf(d, id) == d.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.FirstOrDefault(id => ClubOf(d, id) == d.Esports.ClubId) ?? c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ae784907b7fa"></a>

## `NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool) — public static void EndDay(CareerData d, int day, bool publish = true)`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.EsportsWorld.Initialize(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-ca5840a56e8d)

**调用：** [`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**字段、属性、事件及方法组引用：** `NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`；输入表达式：`SettleDay(d, day, publish, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SettleDay(d, day, publish, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f3ef54e98cea"></a>

## `NationalSpire.EsportsWorld.CompleteMatchDay(NationalSpire.CareerData) — public static void CompleteMatchDay(CareerData d)`

来源：源码第 248 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`；输入表达式：`SettleDay(d, d.Day, true, false)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SettleDay(d, d.Day, true, false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0a6be40070dd"></a>

## `NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool) — private static void SettleDay(CareerData d, int day, bool publish, bool includePlayer)`

来源：源码第 250 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.CompleteMatchDay(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-f3ef54e98cea)；[`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`](EsportsWorld.cs.md#symbol-ae784907b7fa)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`](CircuitWorld.cs.md#symbol-0318d361b72c)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int)`](EsportsWorld.cs.md#symbol-f01370ecf4a3)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.CupRound(string, int)`](EsportsWorld.cs.md#symbol-8ca865fa29de)；[`NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-dfb7f2f9a1ef)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-fce13966e68e)；[`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-713d46cc7d52)；[`NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](EsportsWorld.cs.md#symbol-562b8ecacdbf)；[`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-fdba5c7c50e5)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；[`NationalSpire.SeasonCalendar.LeagueEnd(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-694fe9ba6582)；[`NationalSpire.TeamPreparations.Complete(NationalSpire.CareerData, NationalSpire.WorldCompetition, int)`](TeamPreparation.cs.md#symbol-c4cffd0043d5)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`；`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`；`NationalSpire.EsportsWorld.CupRound(string, int)`；`NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.LeagueEnd(NationalSpire.CareerData)`；`NationalSpire.TeamPreparations.Complete(NationalSpire.CareerData, NationalSpire.WorldCompetition, int)`；`NationalSpire.WorldCompetition.ChampionId`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, f.AwayId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, f.AwayId)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, f.HomeId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, f.HomeId)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, f.WinnerId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, f.WinnerId)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.DisplayName(d, id)`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "qualification-" + d.Season, $"国际赛事资格到手：你以联赛第 {rank} 名出线", $"{c.Name}收官，你获得国际赛事候选资格。前往赛事中心确认报名，代表{ClubName(d, d.Esports.ClubId)}出场。", "晋级", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "qualification-" + d.Season, $"国际赛事资格到手：你以联赛第 {rank} 名出线", $"{c.Name}收官，你获得国际赛事候选资格。前往赛事中心确认报名，代表{ClubName(d, d.Esports.ClubId)}出场。", "晋级", true);`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, $"knockout-{c.Id}-{round}", c.Name + " · " + CupRound(c.Kind, round) + "战报", "晋级名单：" + string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id))) + "。下一轮签表已经更新。", "国际赛事", true, winners.Take(3).ToList())`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, $"knockout-{c.Id}-{round}", c.Name + " · " + CupRound(c.Kind, round) + "战报", "晋级名单：" + string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id))) + "。下一轮签表已经更新。", "国际赛事", true, winners.Take(3).ToList());`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, $"roundup-{c.Id}-{day}", $"海外赛场：{c.Name}战报", string.Join("；", c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}")), "海外赛区", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, $"roundup-{c.Id}-{day}", $"海外赛场：{c.Name}战报", string.Join("；", c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}")), "海外赛区", true);`
- `NationalSpire.CircuitWorld.AdvanceCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition, int, bool)`；输入表达式：`CircuitWorld.AdvanceCompetition(d, c, day, publish)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.AdvanceCompetition(d, c, day, publish);`
- `NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`；输入表达式：`CircuitWorld.CreateFinals(d, publish)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.CreateFinals(d, publish);`
- `NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int)`；输入表达式：`AddCupRound(c, winners, round + 1, day + 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddCupRound(c, winners, round + 1, day + 2);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {ClubName(d, d.Esports.ClubId)}`
- `NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`；输入表达式：`CreateInternational(d, publish)`；返回值紧邻使用处：`ExpressionStatementSyntax: CreateInternational(d, publish);`
- `NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`；输入表达式：`Crown(d, c, publish)`；返回值紧邻使用处：`ExpressionStatementSyntax: Crown(d, c, publish);`
- `NationalSpire.EsportsWorld.CupRound(string, int)`；输入表达式：`CupRound(c.Kind, round)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Name + " · " + CupRound(c.Kind, round)`
- `NationalSpire.EsportsWorld.DomesticRank(NationalSpire.CareerData)`；输入表达式：`DomesticRank(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DomesticRank(d)`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`PlayerLeague(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PlayerLeague(d) is { } league`
- `NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；输入表达式：`Ranked(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(c).First`
- `NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`RefreshCupMatches(d, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshCupMatches(d, c);`
- `NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`SimulateFixture(d, c, f)`；返回值紧邻使用处：`ExpressionStatementSyntax: SimulateFixture(d, c, f);`
- `NationalSpire.LeagueRosterRepair.Apply(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LeagueRosterRepair.Apply(d, league)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueRosterRepair.Apply(d, league);`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, day)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Day(d, day) == SeasonCalendar.LeagueEnd(d)`
- `NationalSpire.SeasonCalendar.LeagueEnd(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.LeagueEnd(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Day(d, day) == SeasonCalendar.LeagueEnd(d)`
- `NationalSpire.TeamPreparations.Complete(NationalSpire.CareerData, NationalSpire.WorldCompetition, int)`；输入表达式：`TeamPreparations.Complete(d, c, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: TeamPreparations.Complete(d, c, day);`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "晋级名单：" + string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id)))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}"))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("；", c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}"))`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(Countries, c.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: Array.IndexOf(Countries, c.Country) == (day + d.Season) % Countries.Length`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.All(f => f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Kind == "league" && !c.Finished && c.Fixtures.All(f => f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`fixtures.All(f => f.Finished)`；返回值紧邻使用处：`IfStatementSyntax: if (fixtures.All(f => f.Finished))                  {                      var winners = fixtures.Select(f => f.WinnerId).ToList();                      if (publish && winners.Count > 1) CareerEngine.Publish(d, $"knockout-{c.Id}-{round}", c.Name + " · " + CupRound(c.Kind, round) + "战报", "晋级名单：" + string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id))) + "。下一轮签表已经更新。", "国际赛事", true, winners.Take(3).ToList());                      if (winners.Count == 1) { c.Finished = true; c.ChampionId = winners[0]; Crown(d, c, publish); }                      else { AddCupRound(c, winners, round + 1, day + 2); RefreshCupMatches(d, c); }                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => f.Day == day)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Kind != "league" && !c.Finished && c.Fixtures.Any(f => f.Day == day)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => f.Day == day)`；返回值紧邻使用处：`BinaryExpressionSyntax: publish && c.Kind == "league" && c.Fixtures.Any(f => f.Day == day)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern)) CircuitWorld.CreateFinals(d, publish);              else CreateInternational(d, publish);`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`Ranked(c).First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(c).First().PersonId`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；输入表达式：`c.Fixtures.Max(f => f.Round)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Max(f => f.Round)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}")`；返回值紧邻使用处：`ArgumentSyntax: c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`fixtures.Select(f => f.WinnerId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fixtures.Select(f => f.WinnerId).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`winners.Select(id => CareerEngine.DisplayName(d, id))`；返回值紧邻使用处：`ArgumentSyntax: winners.Select(id => CareerEngine.DisplayName(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`c.Fixtures.Where(f => f.Day == day).Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day == day).Take(2).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`winners.Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: winners.Take(3).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.Day == day && !f.Finished && (includePlayer || f.HomeId != "player" && f.AwayId != "player")).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var f in c.Fixtures.Where(f => f.Day == day && !f.Finished && (includePlayer || f.HomeId != "player" && f.AwayId != "player")).ToList()) SimulateFixture(d, c, f);`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.Round == round).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(f => f.Round == round).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season).ToList())          {              foreach (var f in c.Fixtures.Where(f => f.Day == day && !f.Finished && (includePlayer || f.HomeId != "player" && f.AwayId != "player")).ToList()) SimulateFixture(d, c, f);              TeamPreparations.Complete(d, c, day);              if (c.Modern) { CircuitWorld.AdvanceCompetition(d, c, day, publish); continue; }              if (c.Kind == "league" && !c.Finished && c.Fixtures.All(f => f.Finished))              {                  c.Finished = true; c.ChampionId = Ranked(c).First().PersonId; Crown(d, c, publish);                  if (c.PlayerEntered)                  {                      int rank = DomesticRank(d);                      if (rank <= 2 && publish) CareerEngine.Publish(d, "qualification-" + d.Season, $"国际赛事资格到手：你以联赛第 {rank} 名出线", $"{c.Name}收官，你获得国际赛事候选资格。前往赛事中心确认报名，代表{ClubName(d, d.Esports.ClubId)}出场。", "晋级", true);                  }              }              if (c.Kind != "league" && !c.Finished && c.Fixtures.Any(f => f.Day == day))              {                  int round = c.Fixtures.Max(f => f.Round);                  var fixtures = c.Fixtures.Where(f => f.Round == round).ToList();                  if (fixtures.All(f => f.Finished))                  {                      var winners = fixtures.Select(f => f.WinnerId).ToList();                      if (publish && winners.Count > 1) CareerEngine.Publish(d, $"knockout-{c.Id}-{round}", c.Name + " · " + CupRound(c.Kind, round) + "战报", "晋级名单：" + string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id))) + "。下一轮签表已经更新。", "国际赛事", true, winners.Take(3).ToList());                      if (winners.Count == 1) { c.Finished = true; c.ChampionId = winners[0]; Crown(d, c, publish); }                      else { AddCupRound(c, winners, round + 1, day + 2); RefreshCupMatches(d, c); }                  }              }              if (publish && c.Kind == "league" && c.Fixtures.Any(f => f.Day == day) && c.Country != d.Esports.Country && Array.IndexOf(Countries, c.Country) == (day + d.Season) % Countries.Length)                  CareerEngine.Publish(d, $"roundup-{c.Id}-{day}", $"海外赛场：{c.Name}战报", string.Join("；", c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}")), "海外赛区", true);          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`fixtures.Select(f => f.WinnerId).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fixtures.Select(f => f.WinnerId).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`winners.Take(3).ToList()`；返回值紧邻使用处：`ArgumentSyntax: winners.Take(3).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Day == day && !f.Finished && (includePlayer || f.HomeId != "player" && f.AwayId != "player"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day == day && !f.Finished && (includePlayer || f.HomeId != "player" && f.AwayId != "player")).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Day == day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day == day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Round == round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Round == round).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season).ToList`

**赋值（含属性/字段和局部值）：**

- `c.ChampionId` = `Ranked(c).First().PersonId`
- `c.ChampionId` = `winners[0]`
- `c.Finished` = `true`

<a id="symbol-562b8ecacdbf"></a>

## `NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — private static void SimulateFixture(CareerData d, WorldCompetition c, WorldFixture f)`

来源：源码第 289 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** [`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)；[`NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`](MatchRules.cs.md#symbol-08f53c7e29ff)；[`Run(string, string)`](EsportsWorld.cs.md#symbol-f996697a7a19)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.IndexOf(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.WorldId`；`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`；`NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`；`NationalSpire.RunPerformance.Cleared`；`NationalSpire.RunPerformance.Floor`；`NationalSpire.RunPerformance.Seconds`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayCleared`；`NationalSpire.WorldFixture.AwayFloor`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwaySeconds`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.HomeCleared`；`NationalSpire.WorldFixture.HomeFloor`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeSeconds`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Walkover`；`Run(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`；输入表达式：`FinishFixture(d, c, f, draw ? "" : score > 0 ? f.HomeId : f.AwayId, draw)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishFixture(d, c, f, draw ? "" : score > 0 ? f.HomeId : f.AwayId, draw);`
- `NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`；输入表达式：`FinishFixture(d, c, f, missingHome && missingAway ? "" : missingHome ? f.AwayId : f.HomeId, missingHome && missingAway)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishFixture(d, c, f, missingHome && missingAway ? "" : missingHome ? f.AwayId : f.HomeId, missingHome && missingAway);`
- `NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`；输入表达式：`MatchRules.Compare(a, b)`；返回值紧邻使用处：`AssignmentExpressionSyntax: score = MatchRules.Compare(a, b)`
- `NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`；输入表达式：`MatchRules.Compare(a, b)`；返回值紧邻使用处：`ConditionalExpressionSyntax: walkover ? (f.HomeId == "player" ? -1 : 1) : MatchRules.Compare(a, b)`
- `Run(string, string)`；输入表达式：`Run(f.AwayId, d.WorldId + ":" + f.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Run(f.AwayId, d.WorldId + ":" + f.Id)`
- `Run(string, string)`；输入表达式：`Run(f.AwayId, d.WorldId + f.Id + ":replay:" + replay)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b = Run(f.AwayId, d.WorldId + f.Id + ":replay:" + replay)`
- `Run(string, string)`；输入表达式：`Run(f.HomeId, d.WorldId + ":" + f.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Run(f.HomeId, d.WorldId + ":" + f.Id)`
- `Run(string, string)`；输入表达式：`Run(f.HomeId, d.WorldId + f.Id + ":replay:" + replay)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a = Run(f.HomeId, d.WorldId + f.Id + ":replay:" + replay)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.DeletedPeople.ContainsKey(f.HomeId) || d.DeletedPeople.ContainsKey(f.AwayId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(f.AwayId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.DeletedPeople.ContainsKey(f.AwayId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.DeletedPeople.ContainsKey(f.HomeId) || d.DeletedPeople.ContainsKey(f.AwayId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(f.HomeId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.DeletedPeople.ContainsKey(f.HomeId)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Entrants.IndexOf(f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.IndexOf(f.HomeId) < c.Entrants.IndexOf(f.AwayId)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Entrants.IndexOf(f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Entrants.IndexOf(f.HomeId) < c.Entrants.IndexOf(f.AwayId)`

**赋值（含属性/字段和局部值）：**

- `a` = `Run(f.HomeId, d.WorldId + f.Id + ":replay:" + replay)`
- `b` = `Run(f.AwayId, d.WorldId + f.Id + ":replay:" + replay)`
- `draw` = `false`
- `f.AwayCleared` = `b.Cleared`
- `f.AwayFloor` = `b.Floor`
- `f.AwaySeconds` = `b.Seconds`
- `f.HomeCleared` = `a.Cleared`
- `f.HomeFloor` = `a.Floor`
- `f.HomeSeconds` = `a.Seconds`
- `f.Walkover` = `true`
- `f.Walkover` = `walkover`
- `score` = `c.Entrants.IndexOf(f.HomeId) < c.Entrants.IndexOf(f.AwayId) ? 1 : -1`
- `score` = `MatchRules.Compare(a, b)`
- `walkover` |= `a.Floor < 0 || b.Floor < 0`

<a id="symbol-f996697a7a19"></a>

## `Run(string, string) — RunPerformance Run(string id, string seed)`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](EsportsWorld.cs.md#symbol-562b8ecacdbf)

**调用：** [`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)；`NationalSpire.RunPerformance.RunPerformance(bool, int, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；输入表达式：`MatchRules.Simulate(d, id, asc, seed, f.Day, d.CooperativeMembers > 1, c, f.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == "player" ? new(false, 0, 0)              : MatchRules.Simulate(d, id, asc, seed, f.Day, d.CooperativeMembers > 1, c, f.Id)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(false, 0, 0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == "player" ? new(false, 0, 0)              : MatchRules.Simulate(d, id, asc, seed, f.Day, d.CooperativeMembers > 1, c, f.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-38ed5773dbb2"></a>

## `NationalSpire.EsportsWorld.ResolvePlayerFixture(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool) — public static void ResolvePlayerFixture(CareerData d, CareerMatch m, bool playerClear, bool abandoned)`

来源：源码第 319 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)；[`NationalSpire.LeagueRosterRepair.Affected(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](LeagueRosterRepair.cs.md#symbol-652e80792134)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.PlayerFloor`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`；`NationalSpire.LeagueRosterRepair.Affected(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldFixture.AwayCleared`；`NationalSpire.WorldFixture.AwayFloor`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwaySeconds`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeCleared`；`NationalSpire.WorldFixture.HomeFloor`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeSeconds`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Walkover`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`；输入表达式：`FinishFixture(d, c, f, m.Draw ? "" : m.PlayerWon ? "player" : m.OpponentId, m.Draw)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishFixture(d, c, f, m.Draw ? "" : m.PlayerWon ? "player" : m.OpponentId, m.Draw);`
- `NationalSpire.LeagueRosterRepair.Affected(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LeagueRosterRepair.Affected(d, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueRosterRepair.Affected(d, c) && f.HomeId != "player"`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c?.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)`

**赋值（含属性/字段和局部值）：**

- `f.AwayCleared` = `f.AwayId == "player" ? playerClear : m.OpponentWon`
- `f.AwayFloor` = `f.AwayId == "player" ? m.PlayerFloor : m.OpponentFloor`
- `f.AwayId` = `"player"`
- `f.AwaySeconds` = `f.AwayId == "player" ? m.PlayerSeconds : m.OpponentSeconds`
- `f.HomeCleared` = `f.HomeId == "player" ? playerClear : m.OpponentWon`
- `f.HomeFloor` = `f.HomeId == "player" ? m.PlayerFloor : m.OpponentFloor`
- `f.HomeId` = `"player"`
- `f.HomeSeconds` = `f.HomeId == "player" ? m.PlayerSeconds : m.OpponentSeconds`
- `f.Walkover` = `abandoned`

<a id="symbol-f16aef3da82a"></a>

## `NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool) — private static void FinishFixture(CareerData d, WorldCompetition c, WorldFixture f, string winner, bool draw)`

来源：源码第 338 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.ResolvePlayerFixture(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool)`](EsportsWorld.cs.md#symbol-38ed5773dbb2)；[`NationalSpire.EsportsWorld.SimulateFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](EsportsWorld.cs.md#symbol-562b8ecacdbf)

**调用：** [`NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerAudience.cs.md#symbol-889a215412c7)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`](CircuitWorld.cs.md#symbol-4d6f1758c06b)；[`NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](NationalFortune.cs.md#symbol-e7b2ae3450b4)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)；[`NationalSpire.SeasonCeremony.RecordParticipants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](SeasonCeremony.cs.md#symbol-c2189cc9f951)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.CareerPerson.Form`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerStanding.Clears`；`NationalSpire.CareerStanding.Draws`；`NationalSpire.CareerStanding.Losses`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CareerStanding.Points`；`NationalSpire.CareerStanding.Wins`；`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；`NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`；`NationalSpire.SeasonCeremony.RecordParticipants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Table`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayCleared`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeCleared`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`CareerAudience.Fixture(d, c, f)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerAudience.Fixture(d, c, f);`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, id) is { } individual`
- `NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`CareerMarket.Fixture(d, c, f)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Fixture(d, c, f);`
- `NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`；输入表达式：`CircuitWorld.CooperativeRoster(d, c, id, f.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Cooperative && id != "player" ? CircuitWorld.CooperativeRoster(d, c, id, f.Id)                  : new List<CareerPerson>()`
- `NationalSpire.NationalFortune.Confirm(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`NationalFortune.Confirm(d, c, f)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalFortune.Confirm(d, c, f);`
- `NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.SettleResults(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.SettleResults(d);`
- `NationalSpire.SeasonCeremony.RecordParticipants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`SeasonCeremony.RecordParticipants(d, c, f)`；返回值紧邻使用处：`ExpressionStatementSyntax: SeasonCeremony.RecordParticipants(d, c, f);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(id)`；返回值紧邻使用处：`IfStatementSyntax: if (d.DeletedPeople.ContainsKey(id)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Table.FirstOrDefault(x => x.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Table.FirstOrDefault(x => x.PersonId == id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`people.Add(individual)`；返回值紧邻使用处：`ExpressionStatementSyntax: people.Add(individual);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CareerPerson>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Cooperative && id != "player" ? CircuitWorld.CooperativeRoster(d, c, id, f.Id)                  : new List<CareerPerson>()`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(person.Rating + (draw ? 2 : winner == id ? 12 : -5), 900, 2100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.Rating = Math.Clamp(person.Rating + (draw ? 2 : winner == id ? 12 : -5), 900, 2100)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(person.MaxAscension, c.Modern ? f.Ascension : (f.Day - 1) % 28 + 1 == 26 && c.Kind != "league" ? 9 : 8)`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.MaxAscension = Math.Max(person.MaxAscension, c.Modern ? f.Ascension : (f.Day - 1) % 28 + 1 == 26 && c.Kind != "league" ? 9 : 8)`

**赋值（含属性/字段和局部值）：**

- `f.Draw` = `draw`
- `f.Finished` = `true`
- `f.WinnerId` = `winner`
- `person.Form` = `(person.Form + (draw ? "平" : winner == id ? "胜" : "负"))`
- `person.Form` = `person.Form[^5..]`
- `person.MaxAscension` = `Math.Max(person.MaxAscension, c.Modern ? f.Ascension : (f.Day - 1) % 28 + 1 == 26 && c.Kind != "league" ? 9 : 8)`
- `person.Rating` = `Math.Clamp(person.Rating + (draw ? 2 : winner == id ? 12 : -5), 900, 2100)`
- `person.Role` = `"世界顶尖"`
- `table.Points` += `3`

<a id="symbol-01f0f7a4d4dc"></a>

## `NationalSpire.EsportsWorld.BreakKnockoutTie(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static void BreakKnockoutTie(CareerData d, CareerMatch m)`

来源：源码第 367 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Decider`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.First(x => x.Id == m.CompetitionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.First(x => x.Id == m.CompetitionId)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Entrants.IndexOf("player")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Entrants.IndexOf("player")`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Entrants.IndexOf(m.OpponentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Entrants.IndexOf(m.OpponentId)`

**赋值（含属性/字段和局部值）：**

- `m.Decider` = `$"双方成绩相同；按赛前种子顺位判定（你为 {own + 1} 号，对手为 {opponent + 1} 号）。"`
- `m.Draw` = `false`
- `m.PlayerWon` = `own < opponent`

<a id="symbol-c5417410642e"></a>

## `NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool) — private static void CreateInternational(CareerData d, bool publish)`

来源：源码第 376 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int)`](EsportsWorld.cs.md#symbol-f01370ecf4a3)；[`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-fce13966e68e)；[`NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3cac74060cf6)；[`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-713d46cc7d52)；[`NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-dcf87e8a91bd)；[`NationalSpire.EsportsWorld.StageName(string)`](EsportsWorld.cs.md#symbol-c0445cae874d)；`NationalSpire.WorldCompetition.WorldCompetition()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.DeletedPeople`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int)`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.EsportsWorld.StageName(string)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.Entrants`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "draw-" + d.Season, cup.Name + "抽签揭晓", $"{entrants.Count} 个席位已经确定。{(kind == "worldcup" ? "各国代表为国家荣誉出战" : "各俱乐部代表争夺洲际最高荣誉")}。签表可在电竞世界查看，国内联赛前二可确认自己的候选席位。", "国际赛事", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "draw-" + d.Season, cup.Name + "抽签揭晓", $"{entrants.Count} 个席位已经确定。{(kind == "worldcup" ? "各国代表为国家荣誉出战" : "各俱乐部代表争夺洲际最高荣誉")}。签表可在电竞世界查看，国内联赛前二可确认自己的候选席位。", "国际赛事", true);`
- `NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int)`；输入表达式：`AddCupRound(cup, entrants, 1, (d.Season - 1) * 28 + (kind == "worldcup" ? 22 : 20))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddCupRound(cup, entrants, 1, (d.Season - 1) * 28 + (kind == "worldcup" ? 22 : 20));`
- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubOf(d, id) == club.Id`
- `NationalSpire.EsportsWorld.Ranked(NationalSpire.WorldCompetition)`；输入表达式：`Ranked(league)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(league).Where`
- `NationalSpire.EsportsWorld.RatingOf(NationalSpire.CareerData, string)`；输入表达式：`RatingOf(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => RatingOf(d, id)`
- `NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`RefreshCupMatches(d, cup)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshCupMatches(d, cup);`
- `NationalSpire.EsportsWorld.SnapshotEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`SnapshotEntrants(d, cup)`；返回值紧邻使用处：`ExpressionStatementSyntax: SnapshotEntrants(d, cup);`
- `NationalSpire.EsportsWorld.StageName(string)`；输入表达式：`StageName(kind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = StageName(kind)`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new WorldCompetition { Id = kind + "-" + d.Season, Kind = kind, Name = StageName(kind), Season = d.Season, Country = "国际", Entrants = entrants }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new WorldCompetition { Id = kind + "-" + d.Season, Kind = kind, Name = StageName(kind), Season = d.Season, Country = "国际", Entrants = entrants }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.DeletedPeople.ContainsKey(s.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.DeletedPeople.ContainsKey(s.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind == kind)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind == kind)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`league.EntrantClubs.Values.Contains(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Country == league.Country && league.EntrantClubs.Values.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`eligible.FirstOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: eligible.FirstOrDefault() is { } selected`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`eligible.FirstOrDefault(id => ClubOf(d, id) == club.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: eligible.FirstOrDefault(id => ClubOf(d, id) == club.Id) is { } selected`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`entrants.OrderByDescending(id => RatingOf(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId)).Select(s => s.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId)).Select(s => s.PersonId).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy(id => id, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: entrants = entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy(id => id, StringComparer.Ordinal).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId)).Select(s => s.PersonId).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId)).Select(s => s.PersonId).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c => c.Country == league.Country && league.EntrantClubs.Values.Contains(c.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var club in d.Esports.Clubs.Where(c => c.Country == league.Country && league.EntrantClubs.Values.Contains(c.Id)))                  if (eligible.FirstOrDefault(id => ClubOf(d, id) == club.Id) is { } selected) entrants.Add(selected);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var league in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league"))          {              var eligible = Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId)).Select(s => s.PersonId).ToList();              if (kind == "worldcup") { if (eligible.FirstOrDefault() is { } selected) entrants.Add(selected); }              else foreach (var club in d.Esports.Clubs.Where(c => c.Country == league.Country && league.EntrantClubs.Values.Contains(c.Id)))                  if (eligible.FirstOrDefault(id => ClubOf(d, id) == club.Id) is { } selected) entrants.Add(selected);          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Ranked(league).Where(s => s.PersonId != "player" && !d.DeletedPeople.ContainsKey(s.PersonId)).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Competitions.Add(cup)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Competitions.Add(cup);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entrants.Add(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: entrants.Add(selected);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy(id => id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy(id => id, StringComparer.Ordinal).ToList`

**赋值（含属性/字段和局部值）：**

- `Country` = `"国际"`
- `entrants` = `entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy(id => id, StringComparer.Ordinal).ToList()`
- `Entrants` = `entrants`
- `Id` = `kind + "-" + d.Season`
- `Kind` = `kind`
- `Name` = `StageName(kind)`
- `Season` = `d.Season`

<a id="symbol-f01370ecf4a3"></a>

## `NationalSpire.EsportsWorld.AddCupRound(NationalSpire.WorldCompetition, System.Collections.Generic.List<string>, int, int) — private static void AddCupRound(WorldCompetition c, List<string> entrants, int round, int day)`

来源：源码第 395 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** `NationalSpire.WorldFixture.WorldFixture()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.WorldFixture.WorldFixture()`；输入表达式：`new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = day, Round = round, HomeId = round == 1 ? entrants[i] : entrants[i * 2], AwayId = round == 1 ? entrants[^(i + 1)] : entrants[i * 2 + 1] }`；返回值紧邻使用处：`ArgumentSyntax: new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = day, Round = round, HomeId = round == 1 ? entrants[i] : entrants[i * 2], AwayId = round == 1 ? entrants[^(i + 1)] : entrants[i * 2 + 1] }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Fixtures.Add(new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = day, Round = round, HomeId = round == 1 ? entrants[i] : entrants[i * 2], AwayId = round == 1 ? entrants[^(i + 1)] : entrants[i * 2 + 1] })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Fixtures.Add(new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = day, Round = round, HomeId = round == 1 ? entrants[i] : entrants[i * 2], AwayId = round == 1 ? entrants[^(i + 1)] : entrants[i * 2 + 1] });`

**赋值（含属性/字段和局部值）：**

- `AwayId` = `round == 1 ? entrants[^(i + 1)] : entrants[i * 2 + 1]`
- `Day` = `day`
- `HomeId` = `round == 1 ? entrants[i] : entrants[i * 2]`
- `Id` = `$"{c.Id}-{round}-{i}"`
- `Round` = `round`

<a id="symbol-713d46cc7d52"></a>

## `NationalSpire.EsportsWorld.RefreshCupMatches(NationalSpire.CareerData, NationalSpire.WorldCompetition) — private static void RefreshCupMatches(CareerData d, WorldCompetition c)`

来源：源码第 399 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.CreateInternational(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-c5417410642e)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** [`NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-ce6c8ab6f6c1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Id`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.CupSlot(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`CupSlot(d, c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.PlayerEntered ? "player" : CupSlot(d, c)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => f.Finished && (f.HomeId == "player" || f.AwayId == "player") && f.WinnerId != "player")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.PlayerEntered && c.Fixtures.Any(f => f.Finished && (f.HomeId == "player" || f.AwayId == "player") && f.WinnerId != "player")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == slot || f.AwayId == slot))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == slot || f.AwayId == slot))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.Kind == c.Kind && m.Day > (d.Season - 1) * 28 && m.Status == "待赛")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in d.Matches.Where(m => m.Kind == c.Kind && m.Day > (d.Season - 1) * 28 && m.Status == "待赛"))          {              m.CompetitionId = c.Id;              string slot = c.PlayerEntered ? "player" : CupSlot(d, c);              var f = c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == slot || f.AwayId == slot));              if (f == null)              {                  bool lost = c.PlayerEntered && c.Fixtures.Any(f => f.Finished && (f.HomeId == "player" || f.AwayId == "player") && f.WinnerId != "player");                  if (lost) { m.Status = "未晋级"; m.Registered = false; }                  continue;              }              m.FixtureId = f.Id; m.OpponentId = f.HomeId == slot ? f.AwayId : f.HomeId;              if (c.PlayerEntered) m.Registered = true;          }`

**赋值（含属性/字段和局部值）：**

- `m.CompetitionId` = `c.Id`
- `m.FixtureId` = `f.Id`
- `m.OpponentId` = `f.HomeId == slot ? f.AwayId : f.HomeId`
- `m.Registered` = `false`
- `m.Registered` = `true`
- `m.Status` = `"未晋级"`

<a id="symbol-c2c7de2d1f49"></a>

## `NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool) — private static void Crown(CareerData d, WorldCompetition c, bool publish)`

来源：源码第 417 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-4649beba59f6)；[`NationalSpire.EsportsWorld.HistoricClub(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](EsportsWorld.cs.md#symbol-81aa159a5766)；[`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-6c986135b9e6)；[`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`](EsportsWorld.cs.md#symbol-83220601bb1f)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Titles`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerPerson.Titles`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.HistoricClub(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.ChampionId`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, c.ChampionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.DisplayName(d, c.ChampionId)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, c.ChampionId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, c.ChampionId) is { } p`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "champion-" + c.Id, $"{c.Name}落幕：{name}夺冠", $"{(c.Kind == "worldcup" ? CountryOf(d, c.ChampionId) : ClubName(d, ClubOf(d, c.ChampionId)))}收获本赛季冠军。完整对阵与结果已收录在赛事档案。", c.Kind == "league" ? "国内联赛" : "国际赛事", true, [c.ChampionId])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "champion-" + c.Id, $"{c.Name}落幕：{name}夺冠", $"{(c.Kind == "worldcup" ? CountryOf(d, c.ChampionId) : ClubName(d, ClubOf(d, c.ChampionId)))}收获本赛季冠军。完整对阵与结果已收录在赛事档案。", c.Kind == "league" ? "国内联赛" : "国际赛事", true, [c.ChampionId]);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`Club(d, HistoricClub(d, c, c.ChampionId))`；返回值紧邻使用处：`IsPatternExpressionSyntax: Club(d, HistoricClub(d, c, c.ChampionId)) is { } club`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, ClubOf(d, c.ChampionId))`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Kind == "worldcup" ? CountryOf(d, c.ChampionId) : ClubName(d, ClubOf(d, c.ChampionId))`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {ClubName(d, d.Esports.ClubId)}`
- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`ClubOf(d, c.ChampionId)`；返回值紧邻使用处：`ArgumentSyntax: ClubOf(d, c.ChampionId)`
- `NationalSpire.EsportsWorld.CountryOf(NationalSpire.CareerData, string)`；输入表达式：`CountryOf(d, c.ChampionId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Kind == "worldcup" ? CountryOf(d, c.ChampionId) : ClubName(d, ClubOf(d, c.ChampionId))`
- `NationalSpire.EsportsWorld.HistoricClub(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`HistoricClub(d, c, c.ChampionId)`；返回值紧邻使用处：`ArgumentSyntax: HistoricClub(d, c, c.ChampionId)`
- `NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；输入表达式：`MakeOffers(d, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: MakeOffers(d, true);`
- `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；输入表达式：`Milestone(d, honorId, c.Name + "冠军", $"第 {d.Season} 赛季，{ClubName(d, d.Esports.ClubId)}的你登上冠军领奖台。", c.Kind == "worldcup" ? 2200 : c.Kind == "continental" ? 1400 : 500, c.Kind == "league" ? 500 : 1500)`；返回值紧邻使用处：`ExpressionStatementSyntax: Milestone(d, honorId, c.Name + "冠军", $"第 {d.Season} 赛季，{ClubName(d, d.Esports.ClubId)}的你登上冠军领奖台。", c.Kind == "worldcup" ? 2200 : c.Kind == "continental" ? 1400 : 500, c.Kind == "league" ? 500 : 1500);`
- `NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；输入表达式：`RefreshLeagueMatches(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshLeagueMatches(d);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c0b4fbf0a978"></a>

## `NationalSpire.EsportsWorld.AfterPlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool) — public static void AfterPlayerMatch(CareerData d, CareerMatch m, bool runClear, bool abandoned)`

来源：源码第 431 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)

**调用：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-b694be794ed8)；[`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-921c23662473)；[`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-6c986135b9e6)；[`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`](EsportsWorld.cs.md#symbol-83220601bb1f)；`NationalSpire.CareerDuel.CareerDuel()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerDuel.Draws`；`NationalSpire.CareerDuel.LastDay`；`NationalSpire.CareerDuel.Losses`；`NationalSpire.CareerDuel.PersonId`；`NationalSpire.CareerDuel.Wins`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.Duels`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.WinStreak`；`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；输入表达式：`CareerCommerce.RefreshOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerCommerce.RefreshOffers(d);`
- `NationalSpire.CareerDuel.CareerDuel()`；输入表达式：`new CareerDuel { PersonId = m.OpponentId }`；返回值紧邻使用处：`AssignmentExpressionSyntax: duel = new CareerDuel { PersonId = m.OpponentId }`
- `NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；输入表达式：`ClearInvalidRegistrations(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearInvalidRegistrations(d);`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`LicenseName(d)`；返回值紧邻使用处：`InterpolationSyntax: {LicenseName(d)}`
- `NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`；输入表达式：`MakeOffers(d, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: MakeOffers(d, false);`
- `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；输入表达式：`Milestone(d, "clear-" + m.RequiredAscension, $"进阶 {m.RequiredAscension} 通关认证", "职业圈正在研究这份通关战报，不同赛区开始关注你的下一场表现。", (m.RequiredAscension) >= 9 ? 500 : 200, 120)`；返回值紧邻使用处：`ExpressionStatementSyntax: Milestone(d, "clear-" + m.RequiredAscension, $"进阶 {m.RequiredAscension} 通关认证", "职业圈正在研究这份通关战报，不同赛区开始关注你的下一场表现。", (m.RequiredAscension) >= 9 ? 500 : 200, 120);`
- `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；输入表达式：`Milestone(d, "license-" + target, target == 3 ? "取得职业资格" : target == 2 ? "获得青训邀请" : "走出社区赛场", $"{m.Event}的成绩通过认证，你现在是{LicenseName(d)}。", target * 65, target * 50)`；返回值紧邻使用处：`ExpressionStatementSyntax: Milestone(d, "license-" + target, target == 3 ? "取得职业资格" : target == 2 ? "获得青训邀请" : "走出社区赛场", $"{m.Event}的成绩通过认证，你现在是{LicenseName(d)}。", target * 65, target * 50);`
- `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`；输入表达式：`Milestone(d, "streak-3", "三连胜，新星升起", "连续三场赛事获胜，你第一次登上赛区焦点栏目。", 120, 100)`；返回值紧邻使用处：`ExpressionStatementSyntax: Milestone(d, "streak-3", "三连胜，新星升起", "连续三场赛事获胜，你第一次登上赛区焦点栏目。", 120, 100);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Duels.FirstOrDefault(x => x.PersonId == m.OpponentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = w.Duels.FirstOrDefault(x => x.PersonId == m.OpponentId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`w.Duels.Add(duel)`；返回值紧邻使用处：`ExpressionStatementSyntax: w.Duels.Add(duel);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(w.BestClear, m.RequiredAscension)`；返回值紧邻使用处：`AssignmentExpressionSyntax: w.BestClear = Math.Max(w.BestClear, m.RequiredAscension)`

**赋值（含属性/字段和局部值）：**

- `duel.LastDay` = `d.Day`
- `duel` = `new CareerDuel { PersonId = m.OpponentId }`
- `PersonId` = `m.OpponentId`
- `w.BestClear` = `Math.Max(w.BestClear, m.RequiredAscension)`
- `w.License` = `target`
- `w.WinStreak` = `m.PlayerWon ? w.WinStreak + 1 : m.Draw ? w.WinStreak : 0`

<a id="symbol-83220601bb1f"></a>

## `NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int) — public static void Milestone(CareerData d, string id, string title, string detail, int fans, int money)`

来源：源码第 452 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.EsportsWorld.AfterPlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool)`](EsportsWorld.cs.md#symbol-c0b4fbf0a978)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.Register(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](EsportsWorld.cs.md#symbol-3857851acceb)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；`NationalSpire.CareerHonor.CareerHonor()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerHonor.Day`；`NationalSpire.CareerHonor.Detail`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerHonor.Season`；`NationalSpire.CareerHonor.Title`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.Milestones`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "honor-" + id, title, detail, "生涯里程碑", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "honor-" + id, title, detail, "生涯里程碑", true);`
- `NationalSpire.CareerHonor.CareerHonor()`；输入表达式：`new CareerHonor { Id = id, Title = title, Detail = detail, Season = d.Season, Day = d.Day }`；返回值紧邻使用处：`ArgumentSyntax: new CareerHonor { Id = id, Title = title, Detail = detail, Season = d.Season, Day = d.Day }`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.IsOwner(d)) return;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Honors.Add(new CareerHonor { Id = id, Title = title, Detail = detail, Season = d.Season, Day = d.Day })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Honors.Add(new CareerHonor { Id = id, Title = title, Detail = detail, Season = d.Season, Day = d.Day });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Milestones.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Milestones.Add(id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.Esports.Milestones.Contains(id)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Milestones.Contains(id)) return;`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `money`
- `d.Fans` += `fans`
- `Day` = `d.Day`
- `Detail` = `detail`
- `Id` = `id`
- `Season` = `d.Season`
- `Title` = `title`

<a id="symbol-6c986135b9e6"></a>

## `NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool) — private static void MakeOffers(CareerData d, bool international)`

来源：源码第 460 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.AfterPlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool)`](EsportsWorld.cs.md#symbol-c0b4fbf0a978)；[`NationalSpire.EsportsWorld.Crown(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](EsportsWorld.cs.md#symbol-c2c7de2d1f49)；[`NationalSpire.EsportsWorld.Initialize(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-ca5840a56e8d)；[`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** [`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Identity`；`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.ClubOffer.ExpiresDay`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.Teams`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`CareerCommerce.Quote(d, club)`；返回值紧邻使用处：`ArgumentSyntax: CareerCommerce.Quote(d, club)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + c.Id + d.Season)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id)))`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`league.EntrantClubs.Values.Contains(c.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)).DistinctBy(c => c.Identity.Length > 0 ? c.Identity : c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)).DistinctBy(c => c.Identity.Length > 0 ? c.Identity : c.Id).Take`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Offers.FirstOrDefault(o => o.ClubId == club.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Offers.FirstOrDefault(o => o.ClubId == club.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)).DistinctBy(c => c.Identity.Length > 0 ? c.Identity : c.Id).Take(3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)).DistinctBy(c => c.Identity.Length > 0 ? c.Identity : c.Id).Take(3)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(c => c.Id != d.Esports.ClubId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var club in candidates.Where(c => c.Id != d.Esports.ClubId))          {              var offer = d.Esports.Offers.FirstOrDefault(o => o.ClubId == club.Id);              if (offer != null) { offer.ExpiresDay = Math.Max(offer.ExpiresDay, d.Day + 28); continue; }              d.Esports.Offers.Add(CareerCommerce.Quote(d, club));          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))              .OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)              .Where`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Offers.Add(CareerCommerce.Quote(d, club))`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Add(CareerCommerce.Quote(d, club));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`league.Teams.Contains(c.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(offer.ExpiresDay, d.Day + 28)`；返回值紧邻使用处：`AssignmentExpressionSyntax: offer.ExpiresDay = Math.Max(offer.ExpiresDay, d.Day + 28)`

**赋值（含属性/字段和局部值）：**

- `offer.ExpiresDay` = `Math.Max(offer.ExpiresDay, d.Day + 28)`

<a id="symbol-09ff5941397c"></a>

## `NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer) — public static string? AcceptOffer(CareerData d, ClubOffer offer)`

来源：源码第 472 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-fecbe30f550e)

**调用：** [`NationalSpire.CareerCommerce.ClubTerms(NationalSpire.ClubOffer)`](CareerCommerce.cs.md#symbol-3a2c86700d2c)；[`NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer)`](CareerCommerce.cs.md#symbol-4e9fe3d551a9)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-713aae182e5e)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-6b77d7c9e9bf)；[`NationalSpire.GameCalendar.Range(NationalSpire.CareerData, int, int)`](GameCalendar.cs.md#symbol-57fa2dd71e81)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；[`NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-bca858704a5e)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.ClubTerms(NationalSpire.ClubOffer)`；`NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；`NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.ClubOffer.ExpiresDay`；`NationalSpire.ClubOffer.SigningBonus`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Range(NationalSpire.CareerData, int, int)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.ClubTerms(NationalSpire.ClubOffer)`；输入表达式：`CareerCommerce.ClubTerms(offer)`；返回值紧邻使用处：`InterpolationSyntax: {CareerCommerce.ClubTerms(offer)}`
- `NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer)`；输入表达式：`CareerCommerce.SignedClub(d, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerCommerce.SignedClub(d, offer);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "contract-" + d.Season + "-" + d.Esports.ClubId, "转会", $"{CareerEngine.Name(d)}加盟{ClubName(d, d.Esports.ClubId)}", $"从{old}开启新篇章，签约奖励已经到账。{CareerCommerce.ClubTerms(offer)}", ["player"], true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "contract-" + d.Season + "-" + d.Esports.ClubId, "转会", $"{CareerEngine.Name(d)}加盟{ClubName(d, d.Esports.ClubId)}", $"从{old}开启新篇章，签约奖励已经到账。{CareerCommerce.ClubTerms(offer)}", ["player"], true);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.AutoEntry(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.AutoEntry(d);`
- `NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.LeavePreseason(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.LeavePreseason(d);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubName(d, d.Esports.ClubId)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {ClubName(d, d.Esports.ClubId)}`
- `NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；输入表达式：`RefreshLeagueMatches(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshLeagueMatches(d);`
- `NationalSpire.GameCalendar.Range(NationalSpire.CareerData, int, int)`；输入表达式：`GameCalendar.Range(d, SeasonCalendar.Start(d) + 1, SeasonCalendar.Start(d) + deadline)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Range(d, SeasonCalendar.Start(d) + 1, SeasonCalendar.Start(d) + deadline)}`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.IsOwner(d)) return "你正在经营自己的俱乐部。";`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, d.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Day(d, d.Day) > deadline`
- `NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.LeagueDeadline(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern) ? SeasonCalendar.LeagueDeadline(d) : 12`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + 1`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + deadline`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.Modern || c.Fixtures.Any(f => f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern) ? SeasonCalendar.LeagueDeadline(d) : 12`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season && c.PlayerEntered && !c.Finished && (!c.Modern || c.Fixtures.Any(f => f.Finished)))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.PendingMatchId != null || d.Esports.Competitions.Any(c => c.Season == d.Season && c.PlayerEntered && !c.Finished && (!c.Modern || c.Fixtures.Any(f => f.Finished)))`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`d.Esports.Offers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.Esports.Offers.Contains(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.Offers.Contains(offer)`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `offer.SigningBonus`
- `d.Esports.ClubId` = `offer.ClubId`

<a id="symbol-d57dc117ca97"></a>

## `NationalSpire.EsportsWorld.TransferWindow(NationalSpire.CareerData) — private static void TransferWindow(CareerData d)`

来源：源码第 488 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.StartSeason(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-1e2b623aabf2)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "transfer-" + d.Season, $"转会窗口：{a.PublicName}加盟{ClubName(d, a.ClubId)}", $"{Countries[country]}赛区完成阵容调整，{b.PublicName}同时转投{ClubName(d, b.ClubId)}。两支俱乐部都把国际赛事资格列为新赛季目标。", "转会", true, [a.Id, b.Id])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "transfer-" + d.Season, $"转会窗口：{a.PublicName}加盟{ClubName(d, a.ClubId)}", $"{Countries[country]}赛区完成阵容调整，{b.PublicName}同时转投{ClubName(d, b.ClubId)}。两支俱乐部都把国际赛事资格列为新赛季目标。", "转会", true, [a.Id, b.Id]);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, a.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {ClubName(d, a.ClubId)}`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`ClubName(d, b.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {ClubName(d, b.ClubId)}`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsProfessional(p) && p.Country == Countries[country]`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`roster.First(p => p.ClubId == $"c{country}0")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = roster.First(p => p.ClubId == $"c{country}0")`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`roster.First(p => p.ClubId == $"c{country}1")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = roster.First(p => p.ClubId == $"c{country}1")`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => IsProfessional(p) && p.Country == Countries[country]).OrderBy(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => IsProfessional(p) && p.Country == Countries[country]).OrderBy(p => p.Rating).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => IsProfessional(p) && p.Country == Countries[country]).OrderBy(p => p.Rating).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => IsProfessional(p) && p.Country == Countries[country]).OrderBy(p => p.Rating).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => IsProfessional(p) && p.Country == Countries[country])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => IsProfessional(p) && p.Country == Countries[country]).OrderBy`

**赋值（含属性/字段和局部值）：**

- `(a.ClubId, b.ClubId)` = `(b.ClubId, a.ClubId)`

<a id="symbol-469e0396c2c6"></a>

## `NationalSpire.EsportsWorld.NextGoal(NationalSpire.CareerData) — public static string NextGoal(CareerData d)`

来源：源码第 496 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)

**调用：** [`NationalSpire.CareerEngine.NextMatch(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-c3698aa12773)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.NextMatch(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.PlayerEntered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.NextMatch(NationalSpire.CareerData)`；输入表达式：`CareerEngine.NextMatch(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.NextMatch(d) is { } next`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`PlayerLeague(d)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PlayerLeague(d)?.PlayerEntered`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, next.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, next.Day)}`

**赋值（含属性/字段和局部值）：**
