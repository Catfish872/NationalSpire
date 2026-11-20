# LeagueCardChoices.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`494A2C16D61FFA11E4A0C858AAF27D184D764E639B7781D2C0E9F485279CFB5B`。来源：[源码](../../LeagueCardChoices.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueDuel`。

字段、事件及初始值（源码原样）：

```csharp
private int[] _choicePlan=[];
private int _choiceIndex;
private bool _choicesChanged;
private readonly Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _selectors=[];
```

<a id="symbol-3bed2d6b33ef"></a>

## `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel) — private static bool Find(Player p,out LeagueDuel duel)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.GridChoice(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>)`](LeagueCardChoices.cs.md#symbol-d8e8571f3ace)；[`NationalSpire.LeagueDuel.HandChoice(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, bool>?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>)`](LeagueCardChoices.cs.md#symbol-0e62aaaafd9c)；[`NationalSpire.LeagueDuel.OneChoice(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Players.Player, bool, ref System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel?>)`](LeagueCardChoices.cs.md#symbol-e80c9634744d)；[`NationalSpire.LeagueDuel.PileChoice(MegaCrit.Sts2.Core.Entities.Cards.CardPile, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, bool>?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>)`](LeagueCardChoices.cs.md#symbol-8409991ce13b)；[`NationalSpire.LeagueDuel.RivalSelectionStack(MegaCrit.Sts2.Core.Entities.Players.Player, ref System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector>)`](LeagueCardChoices.cs.md#symbol-23c6c1b63ea0)；[`NationalSpire.LeagueDuel.UpgradeChoice(MegaCrit.Sts2.Core.Entities.Players.Player, ref System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel?>)`](LeagueCardChoices.cs.md#symbol-4c49c75f8136)

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`LeagueNativeMatch.For(p)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueNativeMatch.For(p)!`

**赋值（含属性/字段和局部值）：**

- `duel` = `LeagueNativeMatch.For(p)!`

<a id="symbol-251ed5837391"></a>

## `NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string) — private CardModel[] SelectActual(IEnumerable<CardModel> candidates,PileType pile,int min,int max,string purpose="")`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.GridChoice(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>)`](LeagueCardChoices.cs.md#symbol-d8e8571f3ace)；[`NationalSpire.LeagueDuel.HandChoice(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, bool>?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>)`](LeagueCardChoices.cs.md#symbol-0e62aaaafd9c)；[`NationalSpire.LeagueDuel.OneChoice(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Players.Player, bool, ref System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel?>)`](LeagueCardChoices.cs.md#symbol-e80c9634744d)；[`NationalSpire.LeagueDuel.PileChoice(MegaCrit.Sts2.Core.Entities.Cards.CardPile, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, bool>?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>)`](LeagueCardChoices.cs.md#symbol-8409991ce13b)；[`NationalSpire.LeagueDuel.UpgradeChoice(MegaCrit.Sts2.Core.Entities.Players.Player, ref System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel?>)`](LeagueCardChoices.cs.md#symbol-4c49c75f8136)

**调用：** [`NationalSpire.LeagueNativeMatch.RecordSelection(MegaCrit.Sts2.Core.Entities.Players.Player)`](LeagueNativeMatch.cs.md#symbol-e6f333245e4e)；[`NationalSpire.LeagueSolverLink.Menu(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`](LeagueSolverLink.cs.md#symbol-f476bafa7737)；[`NationalSpire.LeagueSolverLink.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int)`](LeagueSolverLink.cs.md#symbol-306fe0a674de)；`MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetEntryForNetId(int)`；`System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel._choiceIndex`；`NationalSpire.LeagueDuel._choicePlan`；`NationalSpire.LeagueDuel._choicesChanged`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.RecordSelection(MegaCrit.Sts2.Core.Entities.Players.Player)`；`NationalSpire.LeagueSolverLink.Menu(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`；`NationalSpire.LeagueSolverLink.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetEntryForNetId(int)`；输入表达式：`MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetEntryForNetId(plan[i++])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =MegaCrit.Sts2.Core.Multiplayer.Serialization.ModelIdSerializationCache.GetEntryForNetId(plan[i++])`
- `NationalSpire.LeagueNativeMatch.RecordSelection(MegaCrit.Sts2.Core.Entities.Players.Player)`；输入表达式：`LeagueNativeMatch.RecordSelection(Rival)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueNativeMatch.RecordSelection(Rival);`
- `NationalSpire.LeagueSolverLink.Menu(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>)`；输入表达式：`LeagueSolverLink.Menu(cards)`；返回值紧邻使用处：`BinaryExpressionSyntax: menu==LeagueSolverLink.Menu(cards)`
- `NationalSpire.LeagueSolverLink.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int)`；输入表达式：`LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`cards.Where(c=>c.Id.Entry==id&&c.CurrentUpgradeLevel==level).ElementAtOrDefault(occurrence)`；返回值紧邻使用处：`IsPatternExpressionSyntax: cards.Where(c=>c.Id.Entry==id&&c.CurrentUpgradeLevel==level).ElementAtOrDefault(occurrence) is not {} match`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max).Select(i=>cards[i])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max).Select(i=>cards[i]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =candidates.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max).Select(i=>cards[i]).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return LeagueSolverLink.SelectActual(cards,(int)pile,purpose,effect,min,max).Select(i=>cards[i]).ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Where(c=>c.Id.Entry==id&&c.CurrentUpgradeLevel==level)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c=>c.Id.Entry==id&&c.CurrentUpgradeLevel==level).ElementAtOrDefault`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(min,cards.Length)`；返回值紧邻使用处：`BinaryExpressionSyntax: count>=Math.Min(min,cards.Length)`

**赋值（含属性/字段和局部值）：**

- `_choiceIndex` = `0`
- `_choiceIndex` = `i`
- `_choicePlan` = `[]`
- `_choicesChanged` = `true`
- `chosen[k]` = `match`
- `effect` = `plannedEffect`
- `found` = `false`

<a id="symbol-de6736b83858"></a>

## `NationalSpire.LeagueDuel.InstallSelections(HarmonyLib.Harmony) — internal static void InstallSelections(Harmony h)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)

**调用：** [`Apply(System.Type, string, string, int)`](LeagueCardChoices.cs.md#symbol-a6cb79b90717)；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Reflection.Assembly.GetType(string)`

**字段、属性、事件及方法组引用：** `Apply(System.Type, string, string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply(System.Type, string, string, int)`；输入表达式：`Apply(typeof(CardSelectCmd),"FromChooseACardScreen",nameof(OneChoice),4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply(typeof(CardSelectCmd),"FromChooseACardScreen",nameof(OneChoice),4);`
- `Apply(System.Type, string, string, int)`；输入表达式：`Apply(typeof(CardSelectCmd),"FromCombatPile",nameof(PileChoice),5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply(typeof(CardSelectCmd),"FromCombatPile",nameof(PileChoice),5);`
- `Apply(System.Type, string, string, int)`；输入表达式：`Apply(typeof(CardSelectCmd),"FromHand",nameof(HandChoice),5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply(typeof(CardSelectCmd),"FromHand",nameof(HandChoice),5);`
- `Apply(System.Type, string, string, int)`；输入表达式：`Apply(typeof(CardSelectCmd),"FromSimpleGrid",nameof(GridChoice),4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply(typeof(CardSelectCmd),"FromSimpleGrid",nameof(GridChoice),4);`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(stack,"GetSelectorStackForPlayer")`；返回值紧邻使用处：`IsPatternExpressionSyntax: AccessTools.DeclaredMethod(stack,"GetSelectorStackForPlayer") is {} lookup`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CardSelectCmd),"FromHandForUpgrade")`；返回值紧邻使用处：`IsPatternExpressionSyntax: AccessTools.DeclaredMethod(typeof(CardSelectCmd),"FromHandForUpgrade") is {} upgrade`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(lookup,prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(RivalSelectionStack)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(lookup,prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(RivalSelectionStack)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(upgrade,prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(UpgradeChoice)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(upgrade,prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(UpgradeChoice)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueDuel),nameof(RivalSelectionStack))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(RivalSelectionStack))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueDuel),nameof(UpgradeChoice))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueDuel),nameof(UpgradeChoice))`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(CardSelectCmd).Assembly.GetType("MegaCrit.Sts2.Core.CardSelection.CardSelectorStack")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(CardSelectCmd).Assembly.GetType("MegaCrit.Sts2.Core.CardSelection.CardSelectorStack")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a6cb79b90717"></a>

## `Apply(System.Type, string, string, int) — void Apply(Type type,string method,string hook,int parameters)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.InstallSelections(HarmonyLib.Harmony)`](LeagueCardChoices.cs.md#symbol-de6736b83858)

**调用：** `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.GetDeclaredMethods(System.Type)`；输入表达式：`AccessTools.GetDeclaredMethods(type)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AccessTools.GetDeclaredMethods(type).Single`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(target,prefix:new HarmonyMethod(typeof(LeagueDuel),hook))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(target,prefix:new HarmonyMethod(typeof(LeagueDuel),hook));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueDuel),hook)`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueDuel),hook)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`AccessTools.GetDeclaredMethods(type).Single(m=>m.Name==method&&m.GetParameters().Length==parameters)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.GetDeclaredMethods(type).Single(m=>m.Name==method&&m.GetParameters().Length==parameters)`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-23c6c1b63ea0"></a>

## `NationalSpire.LeagueDuel.RivalSelectionStack(MegaCrit.Sts2.Core.Entities.Players.Player, ref System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector>) — private static bool RivalSelectionStack(Player player,ref Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> __result)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel._selectors`；`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；输入表达式：`Find(player,out var duel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Find(player,out var duel)`

**赋值（含属性/字段和局部值）：**

- `__result` = `duel._selectors`

<a id="symbol-4c49c75f8136"></a>

## `NationalSpire.LeagueDuel.UpgradeChoice(MegaCrit.Sts2.Core.Entities.Players.Player, ref System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel?>) — private static bool UpgradeChoice(Player player,ref Task<CardModel?> __result)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)；[`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；输入表达式：`Find(player,out var duel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Find(player,out var duel)`
- `NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`；输入表达式：`duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault()`；返回值紧邻使用处：`ArgumentSyntax: duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable)`；返回值紧邻使用处：`ArgumentSyntax: player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault())`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault())`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>c.IsUpgradable),PileType.Hand,1,1,"TO_UPGRADE").FirstOrDefault())`

<a id="symbol-0e62aaaafd9c"></a>

## `NationalSpire.LeagueDuel.HandChoice(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, bool>?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>) — private static bool HandChoice(Player player,CardSelectorPrefs prefs,Func<CardModel,bool>? filter,ref Task<IEnumerable<CardModel>> __result)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)；[`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；输入表达式：`Find(player,out var duel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Find(player,out var duel)`
- `NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`；输入表达式：`duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),PileType.Hand,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey)`；返回值紧邻使用处：`ArgumentSyntax: duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),PileType.Hand,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true)`；返回值紧邻使用处：`ArgumentSyntax: player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(c)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: filter?.Invoke(c)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),PileType.Hand,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),PileType.Hand,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(player.PlayerCombatState!.Hand.Cards.Where(c=>filter?.Invoke(c)??true),PileType.Hand,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`

<a id="symbol-d8e8571f3ace"></a>

## `NationalSpire.LeagueDuel.GridChoice(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>) — private static bool GridChoice(IReadOnlyList<CardModel> cardsIn,Player player,CardSelectorPrefs prefs,ref Task<IEnumerable<CardModel>> __result)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)；[`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；输入表达式：`Find(player,out var duel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Find(player,out var duel)`
- `NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`；输入表达式：`duel.SelectActual(cardsIn,PileType.None,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey)`；返回值紧邻使用处：`ArgumentSyntax: duel.SelectActual(cardsIn,PileType.None,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(cardsIn,PileType.None,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(cardsIn,PileType.None,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(cardsIn,PileType.None,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`

<a id="symbol-8409991ce13b"></a>

## `NationalSpire.LeagueDuel.PileChoice(MegaCrit.Sts2.Core.Entities.Cards.CardPile, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, bool>?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>>) — private static bool PileChoice(CardPile pile,Player player,CardSelectorPrefs prefs,Func<CardModel,bool>? filter,ref Task<IEnumerable<CardModel>> __result)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)；[`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；输入表达式：`Find(player,out var duel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Find(player,out var duel)`
- `NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`；输入表达式：`duel.SelectActual(pile.Cards.Where(c=>filter?.Invoke(c)??true),pile.Type,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey)`；返回值紧邻使用处：`ArgumentSyntax: duel.SelectActual(pile.Cards.Where(c=>filter?.Invoke(c)??true),pile.Type,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pile.Cards.Where(c=>filter?.Invoke(c)??true)`；返回值紧邻使用处：`ArgumentSyntax: pile.Cards.Where(c=>filter?.Invoke(c)??true)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(c)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: filter?.Invoke(c)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(pile.Cards.Where(c=>filter?.Invoke(c)??true),pile.Type,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(pile.Cards.Where(c=>filter?.Invoke(c)??true),pile.Type,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult<IEnumerable<CardModel>>(duel.SelectActual(pile.Cards.Where(c=>filter?.Invoke(c)??true),pile.Type,prefs.MinSelect,prefs.MaxSelect,prefs.Prompt.LocEntryKey))`

<a id="symbol-e80c9634744d"></a>

## `NationalSpire.LeagueDuel.OneChoice(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Players.Player, bool, ref System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel?>) — private static bool OneChoice(IReadOnlyList<CardModel> cards,Player player,bool canSkip,ref Task<CardModel?> __result)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`](LeagueCardChoices.cs.md#symbol-3bed2d6b33ef)；[`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Find(MegaCrit.Sts2.Core.Entities.Players.Player, out NationalSpire.LeagueDuel)`；输入表达式：`Find(player,out var duel)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Find(player,out var duel)`
- `NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`；输入表达式：`duel.SelectActual(cards,PileType.None,canSkip?0:1,1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault()`；返回值紧邻使用处：`ArgumentSyntax: duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault()`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult(duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault())`；返回值紧邻使用处：`AssignmentExpressionSyntax: __result=Task.FromResult(duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault())`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.FromResult(duel.SelectActual(cards,PileType.None,canSkip?0:1,1).FirstOrDefault())`
