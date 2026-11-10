# GameCardKnowledge.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D02033E4B6AD884DA8D5FACC050B5AB7E4AA02E52FB42E1BA11CDC7CE92F8A64`。来源：[源码](../../GameCardKnowledge.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCardKnowledge`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-58b00f45030f"></a>

## `NationalSpire.GameCardKnowledge.Read() — public static IEnumerable<CardReference> Read()`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Describe()`](GameCardKnowledge.cs.md#symbol-5a0afbe041e1)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`MegaCrit.Sts2.Core.Models.CardModel.FinalizeUpgradeInternal()`；`MegaCrit.Sts2.Core.Models.CardModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.CardModel.UpgradeInternal()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.CardReference.CardReference(string, string, string)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `Describe()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Describe()`；输入表达式：`Describe()`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + Describe()`
- `Describe()`；输入表达式：`Describe()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Describe()`
- `MegaCrit.Sts2.Core.Models.CardModel.FinalizeUpgradeInternal()`；输入表达式：`card.FinalizeUpgradeInternal()`；返回值紧邻使用处：`ExpressionStatementSyntax: card.FinalizeUpgradeInternal();`
- `MegaCrit.Sts2.Core.Models.CardModel.ToMutable()`；输入表达式：`model.ToMutable()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = model.ToMutable()`
- `MegaCrit.Sts2.Core.Models.CardModel.UpgradeInternal()`；输入表达式：`card.UpgradeInternal()`；返回值紧邻使用处：`ExpressionStatementSyntax: card.UpgradeInternal();`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`model.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: model.Id.ToString()`
- `NationalSpire.CardReference.CardReference(string, string, string)`；输入表达式：`new(model.Id.ToString(), name, description)`；返回值紧邻使用处：`AssignmentExpressionSyntax: reference = new(model.Id.ToString(), name, description)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("card-reference:" + model.Id, error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("card-reference:" + model.Id, error);`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.Title)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameText.Plain(card.Title)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ModelDb.AllCards.DistinctBy(c => c.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var model in ModelDb.AllCards.DistinctBy(c => c.Id))         {             CardReference? reference = null;             try             {                 var card = model.ToMutable();                 string name = GameText.Plain(card.Title);                 string Describe() => GameText.Plain(card.Title) + " · " + card.Pool.Title + " · " + card.Type                     + " · 费用" + (card.EnergyCost.CostsX ? "X" : card.EnergyCost.GetWithModifiers(CostModifiers.All).ToString())                     + "：" + GameText.Plain(card.GetDescriptionForPile(PileType.None));                 string description = Describe();                 if (card.MaxUpgradeLevel > 0) { card.UpgradeInternal(); card.FinalizeUpgradeInternal(); description += "\n" + Describe(); }                 reference = new(model.Id.ToString(), name, description);             }             catch (Exception error) { Diagnostics.Error("card-reference:" + model.Id, error); }             if (reference != null) yield return reference;         }`

**赋值（含属性/字段和局部值）：**

- `description` += `"\n" + Describe()`
- `reference` = `new(model.Id.ToString(), name, description)`

<a id="symbol-5a0afbe041e1"></a>

## `Describe() — string Describe()`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCardKnowledge.Read()`](GameCardKnowledge.cs.md#symbol-58b00f45030f)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`int.ToString()`；`MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetWithModifiers(MegaCrit.Sts2.Core.Entities.Cards.CostModifiers)`；`MegaCrit.Sts2.Core.Models.CardModel.GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`card.EnergyCost.GetWithModifiers(CostModifiers.All).ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: card.EnergyCost.CostsX ? "X" : card.EnergyCost.GetWithModifiers(CostModifiers.All).ToString()`
- `MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetWithModifiers(MegaCrit.Sts2.Core.Entities.Cards.CostModifiers)`；输入表达式：`card.EnergyCost.GetWithModifiers(CostModifiers.All)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: card.EnergyCost.GetWithModifiers(CostModifiers.All).ToString`
- `MegaCrit.Sts2.Core.Models.CardModel.GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`card.GetDescriptionForPile(PileType.None)`；返回值紧邻使用处：`ArgumentSyntax: card.GetDescriptionForPile(PileType.None)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.GetDescriptionForPile(PileType.None))`；返回值紧邻使用处：`BinaryExpressionSyntax: GameText.Plain(card.Title) + " · " + card.Pool.Title + " · " + card.Type                     + " · 费用" + (card.EnergyCost.CostsX ? "X" : card.EnergyCost.GetWithModifiers(CostModifiers.All).ToString())                     + "：" + GameText.Plain(card.GetDescriptionForPile(PileType.None))`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameText.Plain(card.Title) + " · "`

**赋值（含属性/字段和局部值）：**
