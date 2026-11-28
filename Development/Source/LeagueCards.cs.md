# LeagueCards.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`DA4F6961EF9589676208E98D6CC99642A8A96FE097E6F3A78D935D4B2D4D0CAC`。来源：[源码](../../LeagueCards.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueAlbum`、`NationalSpire.LeagueFinish`、`NationalSpire.LeagueReceipt`、`NationalSpire.LeagueCards`、`NationalSpire.LeagueCards.Entry`、`NationalSpire.LeagueCards.Upgrade`。

字段、事件及初始值（源码原样）：

```csharp
public const int PackCost=5000;
public static readonly string[] Grades=["白卡","蓝卡","金卡","先古"];
public static readonly int[] Bids=[60,700,8000,40000];
public static readonly int[] Supply=[4,16,100,2500];
private static CharacterModel[]? _roles;
private static Dictionary<string,Entry>? _catalog;
private static readonly Dictionary<string,HashSet<string>> Membership=[];
private static IGrouping<string,Entry>[][]? _groups;
public const int DeckSize=35,UpgradeBudget=8,NeutralLimit=5;
internal static readonly int[] RarityLimits=[DeckSize,10,5,1];
private static readonly Lazy<Dictionary<string,Dictionary<string,int>>> Basics=new(()=>Roles.ToDictionary(r=>r.Id.Entry,r=>{
        var counts=new Dictionary<string,int>();var start=r.StartingDeck.Where(c=>c.Rarity.ToString()=="Basic").GroupBy(c=>c.Id.Entry).OrderByDescending(g=>g.Count()).Select(g=>g.First()).ToArray();
        foreach(var (tag,n) in new[]{(MegaCrit.Sts2.Core.Entities.Cards.CardTag.Strike,2),(MegaCrit.Sts2.Core.Entities.Cards.CardTag.Defend,3)}){
            bool attack=n==2;var card=start.FirstOrDefault(c=>c.Tags.Contains(tag))??start.FirstOrDefault(c=>!counts.ContainsKey(c.Id.Entry)&&(attack?c.Type.ToString()=="Attack":c.GainsBlock));
            if(card!=null&&!counts.ContainsKey(card.Id.Entry))counts[card.Id.Entry]=n;
        }return counts;}));
internal static readonly System.Reflection.MethodInfo Method =
            RuntimeApi.Bind(typeof(CardModel), nameof(CardModel.UpgradeInternal), false);
```

<a id="symbol-9f3727c7c418"></a>

## `NationalSpire.LeagueAlbum.Owned — public Dictionary<string,int> Owned`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-42f8a4b1ebaa"></a>

## `NationalSpire.LeagueAlbum.PackRoles — public List<string>? PackRoles`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-722c3b1317e7"></a>

## `NationalSpire.LeagueAlbum.Decks — public Dictionary<string,Dictionary<string,int>> Decks`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-50a34a8a62e2"></a>

## `NationalSpire.LeagueAlbum.Upgrades — public Dictionary<string,Dictionary<string,int>> Upgrades`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0227d6b5524f"></a>

## `NationalSpire.LeagueAlbum.StandardDecks — public HashSet<string> StandardDecks`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-916385a80f95"></a>

## `NationalSpire.LeagueAlbum.Captain — public string Captain`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f29a9a7b8135"></a>

## `NationalSpire.LeagueAlbum.Rating — public int Rating`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0334b36b1421"></a>

## `NationalSpire.LeagueAlbum.DuelWins — public int DuelWins`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-aca93fd70eb7"></a>

## `NationalSpire.LeagueAlbum.DuelLosses — public int DuelLosses`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3975bd9f0c80"></a>

## `NationalSpire.LeagueAlbum.LastDuel — public LeagueReceipt? LastDuel`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4d2b84252289"></a>

## `NationalSpire.LeagueAlbum.Packs — public int Packs`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-02cb6f59ed2a"></a>

## `NationalSpire.LeagueAlbum.BlueWait — public int BlueWait`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d7e5373799ee"></a>

## `NationalSpire.LeagueAlbum.GoldWait — public int GoldWait`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c0d6700cafbf"></a>

## `NationalSpire.LeagueAlbum.AncientPending — public int AncientPending`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-646035080f77"></a>

## `NationalSpire.LeagueAlbum.Latest — public List<string> Latest`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d824e093e892"></a>

## `NationalSpire.LeagueAlbum.MarketDay — public int MarketDay`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d034e54c7f2a"></a>

## `NationalSpire.LeagueAlbum.Purchased — public HashSet<string> Purchased`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d57f3c8fff1d"></a>

## `NationalSpire.LeagueFinish.Report — public DuelReport? Report`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a9a9bb870cd1"></a>

## `NationalSpire.LeagueCards.Entry.Id — public string Id`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Model`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d6accd38270"></a>

## `NationalSpire.LeagueCards.Entry.Title — public string Title`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`；`NationalSpire.LeagueCards.Entry.Model`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(Model.Title)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GameText.Plain(Model.Title)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-89edbb7f382f"></a>

## `NationalSpire.LeagueCards.Entry.PartyHint — public string PartyHint`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Model`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Enum.ToString()`；输入表达式：`Model.MultiplayerConstraint.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: Model.MultiplayerConstraint.ToString()!="MultiplayerOnly"`
- `System.Enum.ToString()`；输入表达式：`Model.TargetType.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: Model.TargetType.ToString()=="AnyAlly"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-de594f00e6a0"></a>

## `NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry) — public static int Ask(CareerData d, Entry card)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.PackCost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{(d.AvatarWorldId.Length>0?d.AvatarWorldId:d.WorldId)}:卡价:{d.Day}:{card.Id}")`；返回值紧邻使用处：`CastExpressionSyntax: (uint)CareerEngine.StableHash($"{(d.AvatarWorldId.Length>0?d.AvatarWorldId:d.WorldId)}:卡价:{d.Day}:{card.Id}")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b849eca4c22c"></a>

## `NationalSpire.LeagueCards.Roles — public static CharacterModel[] Roles`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.GameBridge.Characters()`；`NationalSpire.LeagueCards._roles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().ToArray`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`GameBridge.Characters().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _roles ??= GameBridge.Characters().ToArray()`

**赋值（含属性/字段和局部值）：**

- `_roles` ??= `GameBridge.Characters().ToArray()`

<a id="symbol-c73339d60774"></a>

## `NationalSpire.LeagueCards.OriginalRoles — internal static CharacterModel[] OriginalRoles`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`](GameCharacterNames.cs.md#symbol-67e74be938f6)；[`NationalSpire.NpcCharacters.Index(string)`](NpcCharacters.cs.md#symbol-8f7f43f17d89)；`object.GetType()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；`NationalSpire.LeagueCards.Roles`；`NationalSpire.NpcCharacters.Index(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；输入表达式：`GameCharacterNames.IsOriginal(c.GetType())`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCharacterNames.IsOriginal(c.GetType())&&NpcCharacters.Index(c.Id.Entry)>=0`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(c.Id.Entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcCharacters.Index(c.Id.Entry)>=0`
- `object.GetType()`；输入表达式：`c.GetType()`；返回值紧邻使用处：`ArgumentSyntax: c.GetType()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Roles.Where(c=>GameCharacterNames.IsOriginal(c.GetType())&&NpcCharacters.Index(c.Id.Entry)>=0).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Roles.Where(c=>GameCharacterNames.IsOriginal(c.GetType())&&NpcCharacters.Index(c.Id.Entry)>=0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.Where(c=>GameCharacterNames.IsOriginal(c.GetType())&&NpcCharacters.Index(c.Id.Entry)>=0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Roles.Where(c=>GameCharacterNames.IsOriginal(c.GetType())&&NpcCharacters.Index(c.Id.Entry)>=0).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0192fefb8352"></a>

## `NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum) — internal static string[] Pool(LeagueAlbum a)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.PackRoles`；`NationalSpire.LeagueCards.OriginalRoles`；`NationalSpire.LeagueCards.Roles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.Any(r=>r.Id.Entry==g)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g=>Roles.Any(r=>r.Id.Entry==g)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`(a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`OriginalRoles.Select(r=>r.Id.Entry)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OriginalRoles.Select(r=>r.Id.Entry).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`OriginalRoles.Select(r=>r.Id.Entry).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =OriginalRoles.Select(r=>r.Id.Entry).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`(a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g)).Distinct().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =(a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g)).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g)).Distinct`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`active.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: active.Add(id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`active.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !active.Contains(id)`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`active.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return active.ToArray();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-982f653da27b"></a>

## `NationalSpire.LeagueCards.Catalog — public static IReadOnlyDictionary<string,Entry> Catalog`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueCards.Build()`](LeagueCards.cs.md#symbol-3f3a683f5af2)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards._catalog`；`NationalSpire.LeagueCards.Build()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Build()`；输入表达式：`Build()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _catalog ??= Build()`

**赋值（含属性/字段和局部值）：**

- `_catalog` ??= `Build()`

<a id="symbol-3f3a683f5af2"></a>

## `NationalSpire.LeagueCards.Build() — private static Dictionary<string,Entry> Build()`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Catalog`](LeagueCards.cs.md#symbol-982f653da27b)

**调用：** [`Add(MegaCrit.Sts2.Core.Models.CardModel, string)`](LeagueCards.cs.md#symbol-6b27243bfa9f)；[`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`](GameCharacterNames.cs.md#symbol-67e74be938f6)；`MegaCrit.Sts2.Core.Models.ModelDb.CardPool<T>()`；`object.GetType()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `Add(MegaCrit.Sts2.Core.Models.CardModel, string)`；`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；`NationalSpire.LeagueCards.Roles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(MegaCrit.Sts2.Core.Models.CardModel, string)`；输入表达式：`Add(c,"COLORLESS")`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(c,"COLORLESS");`
- `Add(MegaCrit.Sts2.Core.Models.CardModel, string)`；输入表达式：`Add(c,c.Pool.IsColorless?"COLORLESS":role.Id.Entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(c,c.Pool.IsColorless?"COLORLESS":role.Id.Entry);`
- `MegaCrit.Sts2.Core.Models.ModelDb.CardPool<T>()`；输入表达式：`ModelDb.CardPool<ColorlessCardPool>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.CardPool<ColorlessCardPool>().AllCards`
- `NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；输入表达式：`GameCharacterNames.IsOriginal(r.GetType())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r=>GameCharacterNames.IsOriginal(r.GetType())`
- `object.GetType()`；输入表达式：`r.GetType()`；返回值紧邻使用处：`ArgumentSyntax: r.GetType()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`role.CardPool.AllCards.Concat(role.StartingDeck)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in role.CardPool.AllCards.Concat(role.StartingDeck)) Add(c,c.Pool.IsColorless?"COLORLESS":role.Id.Entry);`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Roles.OrderByDescending(r=>GameCharacterNames.IsOriginal(r.GetType()))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var role in Roles.OrderByDescending(r=>GameCharacterNames.IsOriginal(r.GetType()))) foreach(var c in role.CardPool.AllCards.Concat(role.StartingDeck)) Add(c,c.Pool.IsColorless?"COLORLESS":role.Id.Entry);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ModelDb.AllCards.Where(c=>c.Rarity.ToString()=="Ancient"&&c.Pool.IsColorless)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in ModelDb.AllCards.Where(c=>c.Rarity.ToString()=="Ancient"&&c.Pool.IsColorless)) Add(c,"COLORLESS");`
- `System.Enum.ToString()`；输入表达式：`c.Rarity.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rarity.ToString()=="Ancient"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6b27243bfa9f"></a>

## `Add(MegaCrit.Sts2.Core.Models.CardModel, string) — void Add(CardModel model,string group)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Build()`](LeagueCards.cs.md#symbol-3f3a683f5af2)

**调用：** [`NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueCards.cs.md#symbol-18182181d83f)；`NationalSpire.LeagueCards.Entry.Entry(MegaCrit.Sts2.Core.Models.CardModel, string, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.LeagueCards.Membership`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`CollectionTier(model)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CollectionTier(model)`
- `NationalSpire.LeagueCards.Entry.Entry(MegaCrit.Sts2.Core.Models.CardModel, string, int)`；输入表达式：`new(model,group,tier)`；返回值紧邻使用处：`ArgumentSyntax: new(model,group,tier)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`cards.TryAdd(model.Id.Entry,new(model,group,tier))`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.TryAdd(model.Id.Entry,new(model,group,tier));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Membership.TryGetValue(group,out var ids)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Membership.TryGetValue(group,out var ids)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`ids.Add(model.Id.Entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: ids.Add(model.Id.Entry);`

**赋值（含属性/字段和局部值）：**

- `ids` = `[]`
- `Membership[group]` = `ids=[]`

<a id="symbol-18182181d83f"></a>

## `NationalSpire.LeagueCards.CollectionTier(MegaCrit.Sts2.Core.Models.CardModel) — internal static int CollectionTier(CardModel model)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(MegaCrit.Sts2.Core.Models.CardModel, string)`](LeagueCards.cs.md#symbol-6b27243bfa9f)；[`NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`](DuelReportScreen.cs.md#symbol-ca484e5b67df)

**调用：** `System.Enum.ToString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Enum.ToString()`；输入表达式：`model.Rarity.ToString()`；返回值紧邻使用处：`SwitchExpressionSyntax: model.Rarity.ToString() switch {"Common" or "Basic"=>0,"Uncommon"=>1,"Rare"=>2,"Ancient"=>3,_=>-1}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5a63583066af"></a>

## `NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string) — internal static bool InRole(Entry c,string role)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-91440ab7fb30)；[`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-af27d1eb2fda)

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Membership`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`.Contains(c.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Membership.GetValueOrDefault(role)?.Contains(c.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Membership.GetValueOrDefault(role)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Membership.GetValueOrDefault(role)?.Contains(c.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af27d1eb2fda"></a>

## `NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string) — internal static bool Usable(Entry c,string role)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-66c78042d433)

**调用：** [`NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-5a63583066af)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string)`；输入表达式：`InRole(c,role)`；返回值紧邻使用处：`BinaryExpressionSyntax: InRole(c,role)||c.Group=="COLORLESS"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d2d7f45e81c8"></a>

## `NationalSpire.LeagueCards.Groups — private static IGrouping<string,Entry>[][] Groups`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.Enumerable.Range(int, int)`

**字段、属性、事件及方法组引用：** `(string Key, NationalSpire.LeagueCards.Entry c).c`；`(string Key, NationalSpire.LeagueCards.Entry c).Key`；`NationalSpire.LeagueCards._groups`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Membership`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0,4).Select(t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,4).Select(t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Value.Select(id=>(p.Key,c:Catalog[id]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Value.Select(id=>(p.Key,c:Catalog[id])).Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0,4).Select(t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _groups??=Enumerable.Range(0,4).Select(t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,4).Select`

**赋值（含属性/字段和局部值）：**

- `_` = `Catalog`
- `_groups` ??= `Enumerable.Range(0,4).Select(t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()).ToArray()`

<a id="symbol-92f715052b3d"></a>

## `NationalSpire.LeagueCards.GroupName(string) — public static string GroupName(string id)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.CareerScreen.MirrorAppointmentArena(NationalSpire.CareerData, NationalSpire.CareerMatch)`](LeagueArenaScreen.cs.md#symbol-6ac7616bf9f0)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`；`NationalSpire.LeagueCards.Roles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`r.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: r.Title.GetFormattedText()`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(r.Title.GetFormattedText())`；返回值紧邻使用处：`ConditionalExpressionSyntax: Roles.FirstOrDefault(r=>r.Id.Entry==id) is {} r?GameText.Plain(r.Title.GetFormattedText()):id`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.FirstOrDefault(r=>r.Id.Entry==id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Roles.FirstOrDefault(r=>r.Id.Entry==id) is {} r`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bad4f2bcbcee"></a>

## `NationalSpire.LeagueCards.Offers(NationalSpire.CareerData) — public static IEnumerable<Entry> Offers(CareerData d)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.League`；`NationalSpire.LeagueAlbum.MarketDay`；`NationalSpire.LeagueAlbum.Purchased`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Supply`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:挂牌:{d.Day}:{c.Id}")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash($"{d.WorldId}:挂牌:{d.Day}:{c.Id}")%Supply[c.Tier]`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`d.Life.League.Purchased.Contains(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.League.MarketDay==d.Day && d.Life.League.Purchased.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.Values.Where(c=>CareerEngine.StableHash($"{d.WorldId}:挂牌:{d.Day}:{c.Id}")%Supply[c.Tier]==0 && !(d.Life.League.MarketDay==d.Day && d.Life.League.Purchased.Contains(c.Id)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Catalog.Values.Where(c=>CareerEngine.StableHash($"{d.WorldId}:挂牌:{d.Day}:{c.Id}")%Supply[c.Tier]==0 && !(d.Life.League.MarketDay==d.Day && d.Life.League.Purchased.Contains(c.Id)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-330c11ebf6f4"></a>

## `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum) — public static Dictionary<string,int>? Deck(LeagueAlbum a)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)；[`NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`](LeagueCards.cs.md#symbol-ab1c8ff6fb5d)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-66c78042d433)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Decks`；`NationalSpire.LeagueCards.Roles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.Any(r=>r.Id.Entry==a.Captain)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Roles.Any(r=>r.Id.Entry==a.Captain)?a.Decks.GetValueOrDefault(a.Captain):null`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Decks.GetValueOrDefault(a.Captain)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Roles.Any(r=>r.Id.Entry==a.Captain)?a.Decks.GetValueOrDefault(a.Captain):null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b5fd3c07325e"></a>

## `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?) — public static int Fixed(Entry c,string? role=null)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Available(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-dc858d2fe947)；[`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`](LeagueCards.cs.md#symbol-ee6cdcfca4b6)；[`NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-91440ab7fb30)；[`NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-66c78042d433)；[`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`](LeagueLegendDraft.cs.md#symbol-c210ac44d176)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Basics`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Basics.Value.GetValueOrDefault(role??c.Group)?.GetValueOrDefault(c.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Basics.Value.GetValueOrDefault(role??c.Group)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Basics.Value.GetValueOrDefault(role??c.Group)?.GetValueOrDefault(c.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-91440ab7fb30"></a>

## `NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string) — private static void PrepareDeck(LeagueAlbum a,string role)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** [`Add(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-f53e4e2a89a7)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-5a63583066af)；[`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`](LeagueCards.cs.md#symbol-ee6cdcfca4b6)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Enum.ToString()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `Add(NationalSpire.LeagueCards.Entry)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LeagueAlbum.Decks`；`NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueAlbum.StandardDecks`；`NationalSpire.LeagueAlbum.Upgrades`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string)`；`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(c);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>CareerEngine.StableHash(c.Id)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(c,role)`；返回值紧邻使用处：`BinaryExpressionSyntax: Fixed(c,role)==0`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(c,role)`；返回值紧邻使用处：`BinaryExpressionSyntax: Fixed(c,role)>0`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(c,role)`；返回值紧邻使用处：`BinaryExpressionSyntax: i<Fixed(c,role)`
- `NationalSpire.LeagueCards.InRole(NationalSpire.LeagueCards.Entry, string)`；输入表达式：`InRole(c,role)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>InRole(c,role)`
- `NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；输入表达式：`Limit(deck,c,role:role)`；返回值紧邻使用处：`BinaryExpressionSyntax: Limit(deck,c,role:role)==null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`upgrades.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: upgrades.Remove(id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`a.StandardDecks.Add(role)`；返回值紧邻使用处：`ExpressionStatementSyntax: a.StandardDecks.Add(role);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`a.StandardDecks.Contains(role)`；返回值紧邻使用处：`IfStatementSyntax: if(a.StandardDecks.Contains(role))return;`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`deck.Values.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.Values.Sum()<DeckSize`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`old.Keys.Any(id=>!Catalog.ContainsKey(id))`；返回值紧邻使用处：`IfStatementSyntax: if(old.Keys.Any(id=>!Catalog.ContainsKey(id)))return;`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`old.OrderByDescending(p=>upgrades?.GetValueOrDefault(p.Key)>0)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach(var (id,n) in old.OrderByDescending(p=>upgrades?.GetValueOrDefault(p.Key)>0)){              if(!Catalog.TryGetValue(id,out var c)||Fixed(c,role)>0)continue;              for(int i=0;i<n&&Limit(deck,c,role:role)==null;i++)Add(c);          }`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Catalog.Values.Where(c=>InRole(c,role)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Catalog.Values.Where(c=>InRole(c,role)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0).ThenBy(c=>CareerEngine.StableHash(c.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0).ThenBy(c=>CareerEngine.StableHash(c.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`upgrades.Keys.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var id in upgrades.Keys.ToArray()){int n=Math.Min(upgrades[id],deck.GetValueOrDefault(id));if(n==0)upgrades.Remove(id);else upgrades[id]=n;}`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.Values.Where(c=>InRole(c,role))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.Values.Where(c=>InRole(c,role)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>Fixed(c,role)>0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in pool.Where(c=>Fixed(c,role)>0))for(int i=0;i<Fixed(c,role);i++)Add(c);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`Catalog.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.ContainsKey(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(p.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: upgrades?.GetValueOrDefault(p.Key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Decks.GetValueOrDefault(role)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Decks.GetValueOrDefault(role)??[]`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Owned.GetValueOrDefault(c.Id)>0`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Upgrades.GetValueOrDefault(role)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =a.Upgrades.GetValueOrDefault(role)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)<=pass`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(id)`；返回值紧邻使用处：`ArgumentSyntax: deck.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(id,out var c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.TryGetValue(id,out var c)`
- `System.Enum.ToString()`；输入表达式：`c.Model.MultiplayerConstraint.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly"`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0).ThenBy(c=>CareerEngine.StableHash(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0).ThenBy(c=>CareerEngine.StableHash(c.Id)).ToArray`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(upgrades[id],deck.GetValueOrDefault(id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(upgrades[id],deck.GetValueOrDefault(id))`

**赋值（含属性/字段和局部值）：**

- `a.Decks[role]` = `deck`
- `upgrades[id]` = `n`

<a id="symbol-f53e4e2a89a7"></a>

## `Add(NationalSpire.LeagueCards.Entry) — void Add(Entry c)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-91440ab7fb30)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueCards.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Owned.GetValueOrDefault(c.Id)<n`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)+1`

**赋值（含属性/字段和局部值）：**

- `a.Owned[c.Id]` = `n`
- `deck[c.Id]` = `n`

<a id="symbol-66c78042d433"></a>

## `NationalSpire.LeagueCards.Ready(NationalSpire.LeagueAlbum) — public static bool Ready(LeagueAlbum a)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Launch()`](LeagueArenaScreen.cs.md#symbol-0e458038824c)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.MirrorAppointmentArena(NationalSpire.CareerData, NationalSpire.CareerMatch)`](LeagueArenaScreen.cs.md#symbol-6ac7616bf9f0)；[`NationalSpire.Coop.CoopRules.PrepareMirror(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>, NationalSpire.CareerMatch?)`](Coop/CoopRules.cs.md#symbol-616076122cda)

**调用：** [`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-af27d1eb2fda)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.StandardDecks`；`NationalSpire.LeagueCards.Basics`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`Deck(a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Deck(a) is {} d`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(c,a.Captain)`；返回值紧邻使用处：`ArgumentSyntax: Fixed(c,a.Captain)`
- `NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`；输入表达式：`Usable(c,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: Catalog.TryGetValue(p.Key,out var c)&&Usable(c,a.Captain)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Basics.Value.TryGetValue(a.Captain,out var fixedCards)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.StandardDecks.Contains(a.Captain)&&Deck(a) is {} d&&d.Values.Sum()==DeckSize&&Basics.Value.TryGetValue(a.Captain,out var fixedCards)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`a.StandardDecks.Contains(a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.StandardDecks.Contains(a.Captain)&&Deck(a) is {} d`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`d.Values.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Values.Sum()==DeckSize`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.All(p=>Catalog.TryGetValue(p.Key,out var c)&&Usable(c,a.Captain)&&p.Value>0&&p.Value<=Math.Max(2,Fixed(c,a.Captain)))`；返回值紧邻使用处：`BinaryExpressionSyntax: a.StandardDecks.Contains(a.Captain)&&Deck(a) is {} d&&d.Values.Sum()==DeckSize&&Basics.Value.TryGetValue(a.Captain,out var fixedCards)&&fixedCards.All(p=>d.GetValueOrDefault(p.Key)==p.Value)&&d.All(p=>Catalog.TryGetValue(p.Key,out var c)&&Usable(c,a.Captain)&&p.Value>0&&p.Value<=Math.Max(2,Fixed(c,a.Captain)))`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`fixedCards.All(p=>d.GetValueOrDefault(p.Key)==p.Value)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.StandardDecks.Contains(a.Captain)&&Deck(a) is {} d&&d.Values.Sum()==DeckSize&&Basics.Value.TryGetValue(a.Captain,out var fixedCards)&&fixedCards.All(p=>d.GetValueOrDefault(p.Key)==p.Value)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.GetValueOrDefault(p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.GetValueOrDefault(p.Key)==p.Value`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(p.Key,out var c)`；返回值紧邻使用处：`BinaryExpressionSyntax: Catalog.TryGetValue(p.Key,out var c)&&Usable(c,a.Captain)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(2,Fixed(c,a.Captain))`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Value<=Math.Max(2,Fixed(c,a.Captain))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ef07629a8beb"></a>

## `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry) — public static int UpgradeCost(Entry entry)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`](LeagueCards.cs.md#symbol-ab1c8ff6fb5d)；[`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-86ddd4ab46bb)；[`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`](LeagueLadder.cs.md#symbol-1b55dcf28341)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c7bdf32dc0de"></a>

## `NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string) — public static int Upgraded(LeagueAlbum a,string id)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`](LeagueCards.cs.md#symbol-ab1c8ff6fb5d)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Upgrades`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain)?.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Upgrades.GetValueOrDefault(a.Captain)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain)?.GetValueOrDefault(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-86ddd4ab46bb"></a>

## `NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum) — public static int Points(LeagueAlbum a)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`](LeagueCards.cs.md#symbol-ab1c8ff6fb5d)

**调用：** [`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-ef07629a8beb)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Upgrades`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；输入表达式：`UpgradeCost(e)`；返回值紧邻使用处：`BinaryExpressionSyntax: UpgradeCost(e)*p.Value`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`.Sum(p=>Catalog.TryGetValue(p.Key,out var e)?UpgradeCost(e)*p.Value:0)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain)?.Sum(p=>Catalog.TryGetValue(p.Key,out var e)?UpgradeCost(e)*p.Value:0)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Upgrades.GetValueOrDefault(a.Captain)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain)?.Sum(p=>Catalog.TryGetValue(p.Key,out var e)?UpgradeCost(e)*p.Value:0)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(p.Key,out var e)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Catalog.TryGetValue(p.Key,out var e)?UpgradeCost(e)*p.Value:0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f7cfc6d3c1a6"></a>

## `NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel) — public static CardModel Improve(CardModel instance)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReportCard(NationalSpire.DuelCardFace, out Godot.VBoxContainer)`](DuelReportScreen.cs.md#symbol-ca484e5b67df)；[`NationalSpire.GameCardKnowledge.Read()`](GameCardKnowledge.cs.md#symbol-58b00f45030f)；[`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)；[`NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?)`](LeagueCards.cs.md#symbol-4eb35465f771)

**调用：** [`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`MegaCrit.Sts2.Core.Models.CardModel.FinalizeUpgradeInternal()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Upgrade.Method`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.FinalizeUpgradeInternal()`；输入表达式：`instance.FinalizeUpgradeInternal()`；返回值紧邻使用处：`ExpressionStatementSyntax: instance.FinalizeUpgradeInternal();`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(Upgrade.Method, instance)`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeApi.Invoke(Upgrade.Method, instance);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4eb35465f771"></a>

## `NationalSpire.LeagueCards.ApplyAllocation(MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.Dictionary<string, int>?) — internal static CardModel ApplyAllocation(CardModel live,Dictionary<string,int>? remaining)`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.Attach(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueDuel.cs.md#symbol-af76d282a609)；[`NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`](LeagueTeamMatch.cs.md#symbol-40715405ce22)

**调用：** [`NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueCards.cs.md#symbol-f7cfc6d3c1a6)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`Improve(live)`；返回值紧邻使用处：`ExpressionStatementSyntax: Improve(live);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: remaining?.GetValueOrDefault(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ab1c8ff6fb5d"></a>

## `NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int) — public static bool AdjustUpgrade(LeagueAlbum a,Entry e,int change)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** [`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-86ddd4ab46bb)；[`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-ef07629a8beb)；[`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-c7bdf32dc0de)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Upgrades`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.UpgradeBudget`；`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`Deck(a)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Deck(a)?.GetValueOrDefault(e.Id)`
- `NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；输入表达式：`Points(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: Points(a)+UpgradeCost(e)`
- `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；输入表达式：`UpgradeCost(e)`；返回值紧邻使用处：`BinaryExpressionSyntax: Points(a)+UpgradeCost(e)`
- `NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`；输入表达式：`Upgraded(a,e.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Upgraded(a,e.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`a.Upgrades.Remove(a.Captain)`；返回值紧邻使用处：`ExpressionStatementSyntax: a.Upgrades.Remove(a.Captain);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`counts.Remove(e.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: counts.Remove(e.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`a.Upgrades.TryGetValue(a.Captain,out var counts)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !a.Upgrades.TryGetValue(a.Captain,out var counts)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(e.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Deck(a)?.GetValueOrDefault(e.Id)`

**赋值（含属性/字段和局部值）：**

- `a.Upgrades[a.Captain]` = `counts=[]`
- `counts[e.Id]` = `next`
- `counts` = `[]`

<a id="symbol-532fff3c1eac"></a>

## `NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string) — public static int Reserved(LeagueAlbum a,string id)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** `System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Decks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`a.Decks.Values.Select(x=>x.GetValueOrDefault(id)).DefaultIfEmpty().Max()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>a.Decks.Values.Select(x=>x.GetValueOrDefault(id)).DefaultIfEmpty().Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>()`；输入表达式：`a.Decks.Values.Select(x=>x.GetValueOrDefault(id)).DefaultIfEmpty()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.Decks.Values.Select(x=>x.GetValueOrDefault(id)).DefaultIfEmpty().Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.Decks.Values.Select(x=>x.GetValueOrDefault(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.Decks.Values.Select(x=>x.GetValueOrDefault(id)).DefaultIfEmpty`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`x.GetValueOrDefault(id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>x.GetValueOrDefault(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee6cdcfca4b6"></a>

## `NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?) — public static string? Limit(Dictionary<string,int> deck,Entry e,string? outgoing=null,string? role=null)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-91440ab7fb30)

**调用：** [`Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`](LeagueCards.cs.md#symbol-642d01e1429c)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.Grades`；`NationalSpire.LeagueCards.NeutralLimit`；`NationalSpire.LeagueCards.RarityLimits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；输入表达式：`Count(c=>c.Group=="COLORLESS")`；返回值紧邻使用处：`BinaryExpressionSyntax: Count(c=>c.Group=="COLORLESS")>=NeutralLimit`
- `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>)`；输入表达式：`Count(c=>c.Tier==e.Tier)`；返回值紧邻使用处：`BinaryExpressionSyntax: Count(c=>c.Tier==e.Tier)>=RarityLimits[e.Tier]`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(e,role)`；返回值紧邻使用处：`ArgumentSyntax: Fixed(e,role)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`deck.Values.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.Values.Sum()-(outgoing==null?0:1)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(e.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(e.Id)>=Math.Max(2,Fixed(e,role))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(2,Fixed(e,role))`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(e.Id)>=Math.Max(2,Fixed(e,role))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-642d01e1429c"></a>

## `Count(System.Func<NationalSpire.LeagueCards.Entry, bool>) — int Count(Func<Entry,bool> match)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`](LeagueCards.cs.md#symbol-ee6cdcfca4b6)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Catalog`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`deck.Sum(x=>Catalog.TryGetValue(x.Key,out var c)&&match(c)?x.Value-(x.Key==outgoing?1:0):0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>deck.Sum(x=>Catalog.TryGetValue(x.Key,out var c)&&match(c)?x.Value-(x.Key==outgoing?1:0):0)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(x.Key,out var c)`；返回值紧邻使用处：`BinaryExpressionSyntax: Catalog.TryGetValue(x.Key,out var c)&&match(c)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`match(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: Catalog.TryGetValue(x.Key,out var c)&&match(c)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a4faf18d19e7"></a>

## `NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry) — public static bool CanReplace(LeagueAlbum a,string old,Entry next)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** [`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`](LeagueCards.cs.md#symbol-ee6cdcfca4b6)；[`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-af27d1eb2fda)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`Deck(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Deck(a)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(previous,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: Fixed(previous,a.Captain)==0`
- `NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；输入表达式：`Limit(deck,next,old,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: Limit(deck,next,old,a.Captain)==null`
- `NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`；输入表达式：`Usable(next,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck!=null&&deck.TryGetValue(old,out int have)&&have>0&&old!=next.Id              &&(!Catalog.TryGetValue(old,out var previous)||Fixed(previous,a.Captain)==0)              &&Usable(next,a.Captain)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`deck.TryGetValue(old,out int have)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck!=null&&deck.TryGetValue(old,out int have)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(next.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(next.Id)<a.Owned.GetValueOrDefault(next.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(next.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(next.Id)<a.Owned.GetValueOrDefault(next.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(old,out var previous)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.TryGetValue(old,out var previous)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ed27c1c3a4a7"></a>

## `NationalSpire.LeagueCards.RemoveOne(NationalSpire.LeagueAlbum, System.Collections.Generic.Dictionary<string, int>, string) — private static void RemoveOne(LeagueAlbum a,Dictionary<string,int> deck,string id)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Upgrades`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`a.Upgrades.Remove(a.Captain)`；返回值紧邻使用处：`ExpressionStatementSyntax: a.Upgrades.Remove(a.Captain);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`deck.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: deck.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`ups.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ups.Remove(id);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Upgrades.GetValueOrDefault(a.Captain)`；返回值紧邻使用处：`IsPatternExpressionSyntax: a.Upgrades.GetValueOrDefault(a.Captain) is {} ups`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`ups.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ups.GetValueOrDefault(id)>=count`

**赋值（含属性/字段和局部值）：**

- `deck[id]` = `count-1`
- `ups[id]` = `count-1`

<a id="symbol-4da370a40a7a"></a>

## `NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int) — public static string? Apply(CareerData d,string action,string id,int n)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.FinishLeagueTeam(NationalSpire.Coop.CoopCoordinator, string, bool?, NationalSpire.DuelReport?)`](Coop/CoopRules.cs.md#symbol-32aed8cb856a)

**调用：** [`Ensure(int, int, int)`](LeagueCards.cs.md#symbol-1de089225868)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`](LeagueCards.cs.md#symbol-ab1c8ff6fb5d)；[`NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-de594f00e6a0)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`](LeagueCards.cs.md#symbol-ee6cdcfca4b6)；[`NationalSpire.LeagueCards.Offers(NationalSpire.CareerData)`](LeagueCards.cs.md#symbol-bad4f2bcbcee)；[`NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-0192fefb8352)；[`NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-91440ab7fb30)；[`NationalSpire.LeagueCards.RemoveOne(NationalSpire.LeagueAlbum, System.Collections.Generic.Dictionary<string, int>, string)`](LeagueCards.cs.md#symbol-ed27c1c3a4a7)；[`NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-532fff3c1eac)；[`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-af27d1eb2fda)；[`Pay(decimal, string)`](LeagueCards.cs.md#symbol-732cc2e35841)；`NationalSpire.LeagueReceipt.LeagueReceipt(NationalSpire.LeagueFinish, bool, int, int, int)`；`string.IsNullOrEmpty(string?)`；`string.Split(char, int, System.StringSplitOptions)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ElementAt<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`；`System.Random.Next(int, int)`；`System.Random.Next(int)`；`System.Random.Random(int)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Ensure(int, int, int)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.LeagueAlbum.AncientPending`；`NationalSpire.LeagueAlbum.BlueWait`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.DuelLosses`；`NationalSpire.LeagueAlbum.DuelWins`；`NationalSpire.LeagueAlbum.GoldWait`；`NationalSpire.LeagueAlbum.LastDuel`；`NationalSpire.LeagueAlbum.Latest`；`NationalSpire.LeagueAlbum.MarketDay`；`NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueAlbum.PackRoles`；`NationalSpire.LeagueAlbum.Packs`；`NationalSpire.LeagueAlbum.Purchased`；`NationalSpire.LeagueAlbum.Rating`；`NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`；`NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Bids`；`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.Groups`；`NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；`NationalSpire.LeagueCards.Offers(NationalSpire.CareerData)`；`NationalSpire.LeagueCards.PackCost`；`NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`；`NationalSpire.LeagueCards.RemoveOne(NationalSpire.LeagueAlbum, System.Collections.Generic.Dictionary<string, int>, string)`；`NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string)`；`NationalSpire.LeagueCards.Roles`；`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`；`NationalSpire.LeagueFinish.Match`；`NationalSpire.LeagueFinish.Tier`；`NationalSpire.LeagueLadder.Names`；`NationalSpire.LeagueReceipt.Fight`；`Pay(decimal, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Ensure(int, int, int)`；输入表达式：`Ensure(1,10,a.BlueWait)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(1,10,a.BlueWait);`
- `Ensure(int, int, int)`；输入表达式：`Ensure(2,80,a.GoldWait)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(2,80,a.GoldWait);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:{d.LocalHumanId}:卡包:{a.Packs++}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{d.WorldId}:{d.LocalHumanId}:卡包:{a.Packs++}")`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d)<PackCost*n`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d)<price`
- `NationalSpire.LeagueCards.AdjustUpgrade(NationalSpire.LeagueAlbum, NationalSpire.LeagueCards.Entry, int)`；输入表达式：`AdjustUpgrade(a,target,action=="upgrade"?1:-1)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AdjustUpgrade(a,target,action=="upgrade"?1:-1)`
- `NationalSpire.LeagueCards.Ask(NationalSpire.CareerData, NationalSpire.LeagueCards.Entry)`；输入表达式：`Ask(d,entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Ask(d,entry)`
- `NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`；输入表达式：`CanReplace(a,pair[0],next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanReplace(a,pair[0],next)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`Deck(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Deck(a)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`Deck(a)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Deck(a)!`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(entry,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: Fixed(entry,a.Captain)>0`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`Fixed(entry,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: have<=Fixed(entry,a.Captain)`
- `NationalSpire.LeagueCards.Limit(System.Collections.Generic.Dictionary<string, int>, NationalSpire.LeagueCards.Entry, string?, string?)`；输入表达式：`Limit(deck,entry,role:a.Captain)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Limit(deck,entry,role:a.Captain) is {} err`
- `NationalSpire.LeagueCards.Offers(NationalSpire.CareerData)`；输入表达式：`Offers(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Offers(d).Any`
- `NationalSpire.LeagueCards.Pool(NationalSpire.LeagueAlbum)`；输入表达式：`Pool(a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pool(a).Append`
- `NationalSpire.LeagueCards.PrepareDeck(NationalSpire.LeagueAlbum, string)`；输入表达式：`PrepareDeck(a,id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrepareDeck(a,id);`
- `NationalSpire.LeagueCards.RemoveOne(NationalSpire.LeagueAlbum, System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`RemoveOne(a,deck,id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveOne(a,deck,id);`
- `NationalSpire.LeagueCards.RemoveOne(NationalSpire.LeagueAlbum, System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`RemoveOne(a,full,pair[0])`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveOne(a,full,pair[0]);`
- `NationalSpire.LeagueCards.RemoveOne(NationalSpire.LeagueAlbum, System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`RemoveOne(a,legacy,id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveOne(a,legacy,id);`
- `NationalSpire.LeagueCards.Reserved(NationalSpire.LeagueAlbum, string)`；输入表达式：`Reserved(a,id)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned-Reserved(a,id)`
- `NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`；输入表达式：`Usable(entry,a.Captain)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Usable(entry,a.Captain)`
- `NationalSpire.LeagueReceipt.LeagueReceipt(NationalSpire.LeagueFinish, bool, int, int, int)`；输入表达式：`new(finish,n==1,before,a.Rating,prize)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.LastDuel=new(finish,n==1,before,a.Rating,prize)`
- `Pay(decimal, string)`；输入表达式：`Pay(-PackCost*n,"联赛卡包 × "+n)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(-PackCost*n,"联赛卡包 × "+n);`
- `Pay(decimal, string)`；输入表达式：`Pay(-price,"购入 · "+entry.Title)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(-price,"购入 · "+entry.Title);`
- `Pay(decimal, string)`；输入表达式：`Pay((decimal)Bids[entry.Tier]*n,"出售 · "+entry.Title+" × "+n)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay((decimal)Bids[entry.Tier]*n,"出售 · "+entry.Title+" × "+n);`
- `Pay(decimal, string)`；输入表达式：`Pay(prize,"集卡联赛胜场奖金")`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(prize,"集卡联赛胜场奖金");`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(finish.Match)`；返回值紧邻使用处：`BinaryExpressionSyntax: finish.Tier<0 || finish.Tier>=LeagueLadder.Names.Length || string.IsNullOrEmpty(finish.Match)`
- `string.Split(char, int, System.StringSplitOptions)`；输入表达式：`id.Split('|',2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =id.Split('|',2)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`legacy.TryGetValue(id,out var copies)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !legacy.TryGetValue(id,out var copies)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`a.Purchased.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: a.Purchased.Add(id);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`a.Purchased.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: a.Purchased.Clear();`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`pool.Contains(g.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g=>pool.Contains(g.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Offers(d).Any(c=>c.Id==id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Offers(d).Any(c=>c.Id==id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.Any(r=>r.Id.Entry==g)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Roles.Any(r=>r.Id.Entry==g)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.Any(r=>r.Id.Entry==g)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g=>Roles.Any(r=>r.Id.Entry==g)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`Pool(a).Append("COLORLESS")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pool(a).Append("COLORLESS").ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`tiers.Contains(1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: tiers.Contains(1)?0:a.BlueWait+1`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`tiers.Contains(2)`；返回值紧邻使用处：`ConditionalExpressionSyntax: tiers.Contains(2)?0:a.GoldWait+1`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`group.Count()`；返回值紧邻使用处：`ArgumentSyntax: group.Count()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tiers.Count(x=>x==1)`；返回值紧邻使用处：`BinaryExpressionSyntax: tiers.Count(x=>x==1)>1`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`chosen.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: chosen.Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAt<TSource>(int)`；输入表达式：`group.ElementAt(rng.Next(group.Count()))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =group.ElementAt(rng.Next(group.Count()))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Roles.FirstOrDefault(r=>r.Id.Entry==id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Roles.FirstOrDefault(r=>r.Id.Entry==id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Groups.Select(groups=>groups.Where(g=>pool.Contains(g.Key)).ToArray())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Groups.Select(groups=>groups.Where(g=>pool.Contains(g.Key)).ToArray()).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Groups.Select(groups=>groups.Where(g=>pool.Contains(g.Key)).ToArray()).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Groups.Select(groups=>groups.Where(g=>pool.Contains(g.Key)).ToArray()).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`groups.Where(g=>pool.Contains(g.Key)).ToArray()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: groups=>groups.Where(g=>pool.Contains(g.Key)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`Pool(a).Append("COLORLESS").ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Pool(a).Append("COLORLESS").ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`chosen.Distinct().Where(g=>Roles.Any(r=>r.Id.Entry==g)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =chosen.Distinct().Where(g=>Roles.Any(r=>r.Id.Entry==g)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(a.PackRoles??[]).Where(g=>!Roles.Any(r=>r.Id.Entry==g))`；返回值紧邻使用处：`SpreadElementSyntax: ..(a.PackRoles??[]).Where(g=>!Roles.Any(r=>r.Id.Entry==g))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`chosen.Distinct().Where(g=>Roles.Any(r=>r.Id.Entry==g))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: chosen.Distinct().Where(g=>Roles.Any(r=>r.Id.Entry==g)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`groups.Where(g=>pool.Contains(g.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: groups.Where(g=>pool.Contains(g.Key)).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`Catalog.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.ContainsKey(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =a.Owned.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(pick.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Owned.GetValueOrDefault(pick.Id)+1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =deck.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`full.GetValueOrDefault(next.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: full.GetValueOrDefault(next.Id)+1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(id,out var entry)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.TryGetValue(id,out var entry)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(id,out var target)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.TryGetValue(id,out var target)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Catalog.TryGetValue(pair[1],out var next)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Catalog.TryGetValue(pair[1],out var next)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`a.Latest.Add(pick.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: a.Latest.Add(pick.Id);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,a.Rating-change)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.Rating=Math.Max(0,a.Rating-change)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(6,Roles.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: selected.Count<Math.Min(6,Roles.Length)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(6,Roles.Length)`；返回值紧邻使用处：`InterpolationSyntax: {Math.Min(6,Roles.Length)}`
- `System.Random.Next(int, int)`；输入表达式：`Random.Shared.Next(16,21)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Random.Shared.Next(16,21)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(10)`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.Next(10)==0`
- `System.Random.Next(int)`；输入表达式：`rng.Next(choices.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(choices.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(group.Count())`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(group.Count())`
- `System.Random.Next(int)`；输入表达式：`rng.Next(totalWeight)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rng.Next(totalWeight)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{d.WorldId}:{d.LocalHumanId}:卡包:{a.Packs++}"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Random(CareerEngine.StableHash($"{d.WorldId}:{d.LocalHumanId}:卡包:{a.Packs++}"))`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<LeagueFinish>(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length==0?null:System.Text.Json.JsonSerializer.Deserialize<LeagueFinish>(id)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<string[]>(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: System.Text.Json.JsonSerializer.Deserialize<string[]>(id)??[]`

**赋值（含属性/字段和局部值）：**

- `a.BlueWait` = `tiers.Contains(1)?0:a.BlueWait+1`
- `a.Captain` = `id`
- `a.GoldWait` = `tiers.Contains(2)?0:a.GoldWait+1`
- `a.LastDuel` = `new(finish,n==1,before,a.Rating,prize)`
- `a.Latest` = `[]`
- `a.MarketDay` = `d.Day`
- `a.Owned[id]` -= `n`
- `a.Owned[id]` = `owned+1`
- `a.Owned[pick.Id]` = `a.Owned.GetValueOrDefault(pick.Id)+1`
- `a.PackRoles` = `[..selected,..(a.PackRoles??[]).Where(g=>!Roles.Any(r=>r.Id.Entry==g))]`
- `a.Rating` += `change`
- `a.Rating` = `Math.Max(0,a.Rating-change)`
- `deck[id]` = `have+1`
- `full[next.Id]` = `full.GetValueOrDefault(next.Id)+1`
- `tier` = `3`
- `tiers[i]` = `roll<3?2:roll<43?1:0`
- `tiers[i]` = `tier=3`

<a id="symbol-732cc2e35841"></a>

## `Pay(decimal, string) — void Pay(decimal units,string title)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** [`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d,units)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d,units);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d,title,units)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d,title,units);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1de089225868"></a>

## `Ensure(int, int, int) — void Ensure(int tier, int threshold,int wait)`

来源：源码第 192 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCards.Apply(NationalSpire.CareerData, string, string, int)`](LeagueCards.cs.md#symbol-4da370a40a7a)

**调用：** `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(tiers,t=>tiers.Count(v=>v==t)>1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: i=Array.FindIndex(tiers,t=>tiers.Count(v=>v==t)>1)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(tiers,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Array.IndexOf(tiers,0)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`tiers.Contains(tier)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !tiers.Contains(tier)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tiers.Count(v=>v==t)`；返回值紧邻使用处：`BinaryExpressionSyntax: tiers.Count(v=>v==t)>1`

**赋值（含属性/字段和局部值）：**

- `i` = `Array.FindIndex(tiers,t=>tiers.Count(v=>v==t)>1)`
- `tiers[i]` = `tier`
