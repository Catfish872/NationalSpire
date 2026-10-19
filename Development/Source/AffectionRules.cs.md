# AffectionRules.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5040256D187147620B868DE32E25DBD74DCD2A884CB8C45C0E77E0BFA38BCAED`。来源：[源码](../../AffectionRules.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RomanceDifficulty`、`NationalSpire.AffectionRules`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-8616d6a806d2"></a>

## `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?) — public static RomanceDifficulty Mode(CareerData data, PrivateTurn? turn = null)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.Dialogue(NationalSpire.CareerData, NationalSpire.PrivateTurn, double, bool)`](AffectionRules.cs.md#symbol-e5dadfed16da)；[`NationalSpire.AffectionRules.Guidance(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-32589a32bec0)；[`NationalSpire.AffectionRules.PriceRate(NationalSpire.CareerData)`](AffectionRules.cs.md#symbol-fbb5cb80f765)；[`NationalSpire.CareerScreen.AffectionSettings(NationalSpire.CareerData)`](AffectionSettingsScreen.cs.md#symbol-2fc9af32beab)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)；[`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`](PrivateMessages.cs.md#symbol-7823819594c6)

**调用：** [`NationalSpire.AffectionRules.Normalize(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-17662e776a05)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.Normalize(NationalSpire.RomanceDifficulty)`；`NationalSpire.CareerData.RomanceDifficulty`；`NationalSpire.PrivateTurn.AffectionDifficulty`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.Normalize(NationalSpire.RomanceDifficulty)`；输入表达式：`Normalize(turn?.AffectionDifficulty ?? data.RomanceDifficulty)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Normalize(turn?.AffectionDifficulty ?? data.RomanceDifficulty)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-17662e776a05"></a>

## `NationalSpire.AffectionRules.Normalize(NationalSpire.RomanceDifficulty) — public static RomanceDifficulty Normalize(RomanceDifficulty mode)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-8616d6a806d2)

**调用：** `System.Enum.IsDefined<TEnum>(TEnum)`

**字段、属性、事件及方法组引用：** `NationalSpire.RomanceDifficulty.Natural`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Enum.IsDefined<TEnum>(TEnum)`；输入表达式：`Enum.IsDefined(mode)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Enum.IsDefined(mode) ? mode : RomanceDifficulty.Natural`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9bae9ef9e418"></a>

## `NationalSpire.AffectionRules.Name(NationalSpire.RomanceDifficulty) — public static string Name(RomanceDifficulty mode)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AffectionSettings(NationalSpire.CareerData)`](AffectionSettingsScreen.cs.md#symbol-2fc9af32beab)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.RomanceDifficulty.Charming`；`NationalSpire.RomanceDifficulty.Insulated`；`NationalSpire.RomanceDifficulty.Reserved`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e859cd7c259e"></a>

## `NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty) — public static double GainRate(RomanceDifficulty mode)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.Dialogue(NationalSpire.CareerData, NationalSpire.PrivateTurn, double, bool)`](AffectionRules.cs.md#symbol-e5dadfed16da)；[`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.RomanceDifficulty.Charming`；`NationalSpire.RomanceDifficulty.Insulated`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fbb5cb80f765"></a>

## `NationalSpire.AffectionRules.PriceRate(NationalSpire.CareerData) — public static int PriceRate(CareerData data)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-d9e767adce72)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-96ce04ee8974)

**调用：** [`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-8616d6a806d2)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；`NationalSpire.RomanceDifficulty.Insulated`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；输入表达式：`Mode(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: Mode(data) == RomanceDifficulty.Insulated`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d3925b1452c8"></a>

## `NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty) — public static bool Strict(RomanceDifficulty mode)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.Dialogue(NationalSpire.CareerData, NationalSpire.PrivateTurn, double, bool)`](AffectionRules.cs.md#symbol-e5dadfed16da)；[`NationalSpire.AffectionRules.GiftFactors(NationalSpire.RomanceDifficulty, params double[])`](AffectionRules.cs.md#symbol-c435af7816ac)；[`NationalSpire.AffectionRules.Guidance(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-32589a32bec0)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.RomanceDifficulty.Insulated`；`NationalSpire.RomanceDifficulty.Reserved`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d47b24120861"></a>

## `NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double) — public static double DateRate(RomanceDifficulty mode, bool date, double delta)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.Dialogue(NationalSpire.CareerData, NationalSpire.PrivateTurn, double, bool)`](AffectionRules.cs.md#symbol-e5dadfed16da)；[`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.RomanceDifficulty.Charming`；`NationalSpire.RomanceDifficulty.Insulated`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e5dadfed16da"></a>

## `NationalSpire.AffectionRules.Dialogue(NationalSpire.CareerData, NationalSpire.PrivateTurn, double, bool) — public static double Dialogue(CareerData data, PrivateTurn turn, double delta, bool group = false)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.PendingFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](PrivateMessages.cs.md#symbol-1d48affe95ec)

**调用：** [`NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double)`](AffectionRules.cs.md#symbol-d47b24120861)；[`NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-e859cd7c259e)；[`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-8616d6a806d2)；[`NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-d3925b1452c8)；`System.Math.Min(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double)`；`NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty)`；`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；`NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double)`；输入表达式：`DateRate(mode, !group && turn.Scene is { Ending: false }, delta)`；返回值紧邻使用处：`BinaryExpressionSyntax: result * DateRate(mode, !group && turn.Scene is { Ending: false }, delta)`
- `NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty)`；输入表达式：`GainRate(mode)`；返回值紧邻使用处：`ConditionalExpressionSyntax: delta > 0 ? GainRate(mode) : !group && Strict(mode) ? 2 : 1`
- `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；输入表达式：`Mode(data, turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mode(data, turn)`
- `NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`；输入表达式：`Strict(mode)`；返回值紧邻使用处：`BinaryExpressionSyntax: !group && Strict(mode)`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(3, result)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result = Math.Min(3, result)`

**赋值（含属性/字段和局部值）：**

- `result` = `Math.Min(3, result)`

<a id="symbol-85ae2ed8ebb4"></a>

## `NationalSpire.AffectionRules.Apply(NationalSpire.CareerData, string, double, bool) — public static int Apply(CareerData data, string person, double delta, bool gift = false)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessages.cs.md#symbol-056e9f8e0046)

**调用：** [`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`System.Math.Abs(double)`；`System.Math.Clamp(double, double, double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Floor(double)`；`System.Math.Max(double, double)`；`System.Math.Min(double, double)`；`double.IsFinite(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AffectionLinkedClearChance`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.GainRemainder`；`NationalSpire.PrivateRelation.GiftLossRemainder`；`NationalSpire.PrivateRelation.GiftRemainder`；`NationalSpire.PrivateRelation.LossRemainder`；`NationalSpire.PrivateRelation.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(data);`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, person)`
- `System.Math.Abs(double)`；输入表达式：`Math.Abs(delta)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(delta) + Math.Clamp(remainder, 0, .999999999)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(remainder, 0, .999999999)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(delta) + Math.Clamp(remainder, 0, .999999999)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(before + (positive ? integer : -integer), -100, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.Favour = Math.Clamp(before + (positive ? integer : -integer), -100, 100)`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(sum + 1e-9)`；返回值紧邻使用处：`ArgumentSyntax: Math.Floor(sum + 1e-9)`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(sum + 1e-9)`；返回值紧邻使用处：`BinaryExpressionSyntax: sum - Math.Floor(sum + 1e-9)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, sum - Math.Floor(sum + 1e-9))`；返回值紧邻使用处：`ConditionalExpressionSyntax: positive && relation.Favour == 100 || !positive && relation.Favour == -100 ? 0 : Math.Max(0, sum - Math.Floor(sum + 1e-9))`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(200, Math.Floor(sum + 1e-9))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(200, Math.Floor(sum + 1e-9))`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(delta)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(delta)`

**赋值（含属性/字段和局部值）：**

- `data.Life.Relationships[person]` = `relation.Favour`
- `relation.Favour` = `Math.Clamp(before + (positive ? integer : -integer), -100, 100)`
- `relation.GainRemainder` = `remaining`
- `relation.GiftLossRemainder` = `remaining`
- `relation.GiftRemainder` = `remaining`
- `relation.LossRemainder` = `remaining`

<a id="symbol-c435af7816ac"></a>

## `NationalSpire.AffectionRules.GiftFactors(NationalSpire.RomanceDifficulty, params double[]) — public static double GiftFactors(RomanceDifficulty mode, params double[] factors)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`at(long)`](AffectionRules.cs.md#symbol-e7d2c260590f)

**调用：** [`NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-d3925b1452c8)；`System.Collections.Generic.IEnumerable<TSource>.Aggregate<TSource, TAccumulate>(TAccumulate, System.Func<TAccumulate, TSource, TAccumulate>)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`；`NationalSpire.RomanceDifficulty.Insulated`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`；输入表达式：`Strict(mode)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Strict(mode)`
- `System.Collections.Generic.IEnumerable<TSource>.Aggregate<TSource, TAccumulate>(TAccumulate, System.Func<TAccumulate, TSource, TAccumulate>)`；输入表达式：`factors.Aggregate(1d, (value, f) => value * f)`；返回值紧邻使用处：`ReturnStatementSyntax: return factors.Aggregate(1d, (value, f) => value * f);`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(-1, penalty)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(-1, penalty) * bonuses`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, adjusted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: product *= Math.Max(0, adjusted)`

**赋值（含属性/字段和局部值）：**

- `bonuses` *= `f`
- `penalty` += `adjusted`
- `product` *= `Math.Max(0, adjusted)`

<a id="symbol-476b2d98ce24"></a>

## `NationalSpire.AffectionRules.GiftValue(NationalSpire.RomanceDifficulty, NationalSpire.GiftItem, int, int, double) — public static double GiftValue(RomanceDifficulty mode, GiftItem item, int count, int favour, double mood)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)

**调用：** [`NationalSpire.ConsumerGifts.PriceGain(double)`](ConsumerGifts.cs.md#symbol-c88c446ec911)；`System.Math.Max(long, long)`；`System.Math.Min(long, long)`；[`at(long)`](AffectionRules.cs.md#symbol-e7d2c260590f)

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.PriceGain(double)`；`NationalSpire.GiftItem.Preference`；`NationalSpire.GiftItem.ReceivedBefore`；`NationalSpire.GiftItem.UnitPrice`；`at(long)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.PriceGain(double)`；输入表达式：`ConsumerGifts.PriceGain(item.UnitPrice * item.Preference)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerGifts.PriceGain(item.UnitPrice * item.Preference) / baseGain`
- `NationalSpire.ConsumerGifts.PriceGain(double)`；输入表达式：`ConsumerGifts.PriceGain(item.UnitPrice)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerGifts.PriceGain(item.UnitPrice)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(0, 9 - item.ReceivedBefore)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, 9 - item.ReceivedBefore)`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(count, Math.Max(0, 9 - item.ReceivedBefore))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(count, Math.Max(0, 9 - item.ReceivedBefore))`
- `at(long)`；输入表达式：`at(9)`；返回值紧邻使用处：`BinaryExpressionSyntax: (count - varied) * at(9)`
- `at(long)`；输入表达式：`at(item.ReceivedBefore + i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: value += at(item.ReceivedBefore + i)`

**赋值（含属性/字段和局部值）：**

- `value` += `at(item.ReceivedBefore + i)`

<a id="symbol-e7d2c260590f"></a>

## `at(long) — double at(long n)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.GiftValue(NationalSpire.RomanceDifficulty, NationalSpire.GiftItem, int, int, double)`](AffectionRules.cs.md#symbol-476b2d98ce24)

**调用：** [`NationalSpire.AffectionRules.GiftFactors(NationalSpire.RomanceDifficulty, params double[])`](AffectionRules.cs.md#symbol-c435af7816ac)；[`NationalSpire.ConsumerGifts.FavourFactor(int)`](ConsumerGifts.cs.md#symbol-47e7114c75eb)；[`NationalSpire.ConsumerGifts.RepeatFactor(long)`](ConsumerGifts.cs.md#symbol-6a2d01a43a87)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.GiftFactors(NationalSpire.RomanceDifficulty, params double[])`；`NationalSpire.ConsumerGifts.FavourFactor(int)`；`NationalSpire.ConsumerGifts.RepeatFactor(long)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.GiftFactors(NationalSpire.RomanceDifficulty, params double[])`；输入表达式：`GiftFactors(mode, preference, ConsumerGifts.FavourFactor(favour), mood < 0 ? .5 : mood > 0 ? 1.5 : 1, ConsumerGifts.RepeatFactor(n))`；返回值紧邻使用处：`BinaryExpressionSyntax: baseGain * GiftFactors(mode, preference, ConsumerGifts.FavourFactor(favour), mood < 0 ? .5 : mood > 0 ? 1.5 : 1, ConsumerGifts.RepeatFactor(n))`
- `NationalSpire.ConsumerGifts.FavourFactor(int)`；输入表达式：`ConsumerGifts.FavourFactor(favour)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerGifts.FavourFactor(favour)`
- `NationalSpire.ConsumerGifts.RepeatFactor(long)`；输入表达式：`ConsumerGifts.RepeatFactor(n)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerGifts.RepeatFactor(n)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-32589a32bec0"></a>

## `NationalSpire.AffectionRules.Guidance(NationalSpire.CareerData, NationalSpire.PrivateTurn?) — public static string Guidance(CareerData data, PrivateTurn? turn)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?, bool)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)

**调用：** [`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-8616d6a806d2)；[`NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-d3925b1452c8)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；`NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；输入表达式：`Mode(data, turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mode(data, turn)`
- `NationalSpire.AffectionRules.Strict(NationalSpire.RomanceDifficulty)`；输入表达式：`Strict(mode)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Strict(mode) ? "当前角色对关系中的疏忽更敏感：玩家忽视其已经表达的意愿、敷衍重要话题、失约、越界玩笑或轻视感受时，可依据具体行为表达轻微失望、难过或疏远，并给出较低的基础好感目标；轻度伤害也可触发。对方自身经历或环境造成的悲伤应归于其真实原因。" : ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3d1e544d7431"></a>

## `NationalSpire.AffectionRules.Description(NationalSpire.RomanceDifficulty) — public static string Description(RomanceDifficulty mode)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AffectionSettings(NationalSpire.CareerData)`](AffectionSettingsScreen.cs.md#symbol-2fc9af32beab)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.RomanceDifficulty.Charming`；`NationalSpire.RomanceDifficulty.Insulated`；`NationalSpire.RomanceDifficulty.Reserved`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
