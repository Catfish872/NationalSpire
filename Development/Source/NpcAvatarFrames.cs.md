# NpcAvatarFrames.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EA1F1CAF265C1748D0DDE024BD278A853CB795757D6D6FE78FA2C464BDD5F2B0`。来源：[源码](../../NpcAvatarFrames.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.NpcAvatarFrames`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly AvatarFrame[] Special =
    [
        new("friend", "好友", "8fd8d0", 0, "好感达到 30"),
        new("intimate", "亲密", "c8b5ec", 0, "好感达到 45"),
        new("lover", "恋人", "efa5bc", 0, "交往关系为恋人"),
        new("cat", "猫咪", "edcdae", 0, "好感超过 25"),
        new("oath", "钻戒誓约", "dce6f1", 0, "完成婚礼且维持婚约")
    ];
```

<a id="symbol-231b10c705ed"></a>

## `NationalSpire.NpcAvatarFrames.Choices — public static IEnumerable<AvatarFrame> Choices`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.Frames`；`NationalSpire.NpcAvatarFrames.Special`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`AvatarHonors.Frames.Concat(Special)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => AvatarHonors.Frames.Concat(Special)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-810d8a8cbd67"></a>

## `NationalSpire.NpcAvatarFrames.Requirement(string) — public static string Requirement(string id)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`Preview()`](NpcAvatarFrameScreen.cs.md#symbol-e09ed14299e2)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarFrame.Requirement`；`NationalSpire.AvatarHonors.Frames`；`NationalSpire.NpcAvatarFrames.Special`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvatarHonors.Frames.FirstOrDefault(f => f.Id == id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: AvatarHonors.Frames.FirstOrDefault(f => f.Id == id) is { Grade: > 0 } honor`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Special.FirstOrDefault(f => f.Id == id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Special.FirstOrDefault(f => f.Id == id) is { } special`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c31464eed81"></a>

## `NationalSpire.NpcAvatarFrames.Description(string) — public static string Description(string id)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Preview()`](NpcAvatarFrameScreen.cs.md#symbol-e09ed14299e2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f789cabb01cd"></a>

## `NationalSpire.NpcAvatarFrames.Find(string) — public static AvatarFrame? Find(string id)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.AvatarIdentity.DisplayFrame`](AvatarHonors.cs.md#symbol-e379de45a23f)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`](NpcAvatarFrames.cs.md#symbol-fd1fec9d14c5)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarHonors.Frames`；`NationalSpire.NpcAvatarFrames.Special`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fd1fec9d14c5"></a>

## `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string) — public static string? Locked(PrivateRelation relation, string id)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)

**调用：** [`NationalSpire.NpcAvatarFrames.Find(string)`](NpcAvatarFrames.cs.md#symbol-f789cabb01cd)；[`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`](RelationshipPresentation.cs.md#symbol-bac5ded19066)

**字段、属性、事件及方法组引用：** `NationalSpire.NpcAvatarFrames.Find(string)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NpcAvatarFrames.Find(string)`；输入表达式：`Find(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Find(id) == null`
- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`RelationshipPresentation.OathAppearance(relation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !RelationshipPresentation.OathAppearance(relation)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8c2dcfe0344a"></a>

## `NationalSpire.NpcAvatarFrames.Select(NationalSpire.CareerData, string, string) — public static string? Select(CareerData data, string person, string id)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`Save()`](NpcAvatarFrameScreen.cs.md#symbol-a1802dcac073)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, person) == null`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.IsHuman(data, person) || CareerEngine.Person(data, person) == null`
- `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；输入表达式：`Locked(data, person, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Locked(data, person, id) is { } error`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).NpcAvatarFrames`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`choices.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Remove(person);`

**赋值（含属性/字段和局部值）：**

- `choices[person]` = `id`

<a id="symbol-312d47fec9fa"></a>

## `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string) — public static string? Locked(CareerData data, string person, string id)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.NpcAvatarFrames.Select(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-8c2dcfe0344a)；[`Preview()`](NpcAvatarFrameScreen.cs.md#symbol-e09ed14299e2)；[`Save()`](NpcAvatarFrameScreen.cs.md#symbol-a1802dcac073)

**调用：** [`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-c5235b150918)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`](NpcAvatarFrames.cs.md#symbol-fd1fec9d14c5)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarFrame.Requirement`；`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`；`NationalSpire.AvatarHonors.Frames`；`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.Earned(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvatarHonors.Earned(data, person).ContainsKey`
- `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`；输入表达式：`Locked(PrivateMessages.Relation(data, person), id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Locked(PrivateMessages.Relation(data, person), id) is { } error`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Relation(data, person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`AvatarHonors.Earned(data, person).ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvatarHonors.Earned(data, person).ContainsKey(id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvatarHonors.Frames.FirstOrDefault(f => f.Id == id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: AvatarHonors.Frames.FirstOrDefault(f => f.Id == id) is { Grade: > 0 } honor`

**赋值（含属性/字段和局部值）：**
