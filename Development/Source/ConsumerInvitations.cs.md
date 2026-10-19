# ConsumerInvitations.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B7C350B675E63F38DD63D2F77228E04A183C15DAEDF45655820C8DC2C45A343D`。来源：[源码](../../ConsumerInvitations.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerInvitations`。

字段、事件及初始值（源码原样）：

```csharp
public const string Kind = "date-invitation";
public const string Protocol = """
约会邀请附件是玩家已发出的真实请求；结合人物意愿、留言、记忆和日程回应。接受时必须附 [Activity: 接受, Id: 邀请编号, Season: 赛季数, Day: 赛季内日期]，完整回复后程序立即记入日程。尚无明确日期时，可以提议今天或未来的具体日期；需要继续商谈则只交流，待接受并确定日期时再给标记。拒绝使用 [Activity: 拒绝, Id: 邀请编号]。
这些已接受的约会使用原活动编号继续 [Activity: 改期, Id: 活动编号, Season: 赛季数, Day: 新日期] 或 [Activity: 取消, Id: 活动编号]；商谈达成后的改期立即生效。普通活动邀请仍沿玩家确认流程。编号来自程序，不根据商品名称编造编号。
盛大婚礼也使用上述接受、改期和取消流程。正式完成婚礼由程序在婚礼场景结束后记录，婚礼前按已赠婚戒的关系交流。
""";
```

<a id="symbol-79a9e4bf9389"></a>

## `NationalSpire.ConsumerInvitations.IsWedding(NationalSpire.PrivateOffer) — public static bool IsWedding(PrivateOffer offer)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.ChatContacts.PendingEvents(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateConversation>, System.Collections.Generic.IReadOnlySet<string>)`](ChatContacts.cs.md#symbol-bc725c5627a8)；[`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-ad51c0c18b5f)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.GoodId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4e66aa5d5d7e"></a>

## `NationalSpire.ConsumerInvitations.Purchased(NationalSpire.CareerData, string) — public static bool Purchased(CareerData data, string good)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerState.BoughtDay`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.OwnedGood.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`data.Life.Consumer.BoughtDay.ContainsKey(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Life.Consumer.Goods.Any(g => g.Id == good) || data.Life.Consumer.BoughtDay.ContainsKey(good)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Consumer.Goods.Any(g => g.Id == good)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Life.Consumer.Goods.Any(g => g.Id == good) || data.Life.Consumer.BoughtDay.ContainsKey(good)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cc2d01b16094"></a>

## `NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool) — public static string? Create(CareerData data, string goodId, string verbId, IReadOnlyList<string> people, bool buy = false)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.CareerScreen.PrivateDateInvitationPicker()`](DateDiaryScreen.cs.md#symbol-cdf7f00bf71b)；[`NationalSpire.ConsumerGifts.Wedding(NationalSpire.CareerData, string)`](ConsumerGifts.cs.md#symbol-905fa376a7e7)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-2aa34d35c1b8)；[`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-d9e767adce72)；[`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-71fa8e1feaa2)；[`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`](ConsumerInvitationStock.cs.md#symbol-83c43c134057)；[`NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerInvitationStock.cs.md#symbol-231e759e9078)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitationStock.ActiveMessage`；`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；`NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.ConsumerInvitations.Kind`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Slots`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GoodVerb.Slots`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.InvitationReservation`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateRelation.RingReceived`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(data) < ConsumerEngine.HospitalityFee(data, good) / 10m`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(goodId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerCatalog.Get(goodId)`
- `NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；输入表达式：`ConsumerEngine.Buy(data, goodId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerEngine.Buy(data, goodId) is { } error`
- `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`；输入表达式：`ConsumerEngine.CanInvite(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConsumerEngine.CanInvite(data, id)`
- `NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerEngine.HospitalityFee(data, good)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerEngine.HospitalityFee(data, good) / 10m`
- `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；输入表达式：`ConsumerInvitationStock.Active(data)`；返回值紧邻使用处：`IfStatementSyntax: if (ConsumerInvitationStock.Active(data)) return ConsumerInvitationStock.ActiveMessage;`
- `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；输入表达式：`ConsumerInvitationStock.Available(data, goodId, verbId)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerInvitationStock.Available(data, goodId, verbId) == 0`
- `NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`ConsumerInvitationStock.Reserve(data, goodId, verbId, people)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerInvitationStock.Reserve(data, goodId, verbId, people)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).GiftDrafts`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = Kind, GoodId = goodId, GoodVerb = verbId, Title = title, InvitationReservation = reservation, Detail = "约会内容：" + title + (verb == null ? "" : " · " + good.Name) + "。请在留言中商谈日期与安排，等待对方回应。" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = Kind, GoodId = goodId, GoodVerb = verbId, Title = title, InvitationReservation = reservation, Detail = "约会内容：" + title + (verb == null ? "" : " · " + good.Name) + "。请在留言中商谈日期与安排，等待对方回应。" }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).GiftDrafts.Any(a => a.Kind == Kind && a.GoodId == goodId && a.GoodVerb == verbId)`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateMessages.Conversation(data, person).GiftDrafts.Any(a => a.Kind == Kind && a.GoodId == goodId && a.GoodVerb == verbId)) return "这项约会邀请已附在所选人物的私聊中。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Any(id => !ConsumerEngine.CanInvite(data, id))`；返回值紧邻使用处：`BinaryExpressionSyntax: people.Count == 0 || people.Count > slots || people.Distinct().Count() != people.Count || people.Any(id => !ConsumerEngine.CanInvite(data, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Any(id => PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(id)?.RingReceived != true)`；返回值紧邻使用处：`BinaryExpressionSyntax: good.Id == "grand-wedding" && people.Any(id => PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(id)?.RingReceived != true)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`people.Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: people.Distinct().Count() != people.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Verbs.FirstOrDefault(v => v.Id == verbId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: good?.Verbs.FirstOrDefault(v => v.Id == verbId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(id)?.RingReceived`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PrivateMessages.Conversation(data, person).GiftDrafts.Add(new() { Kind = Kind, GoodId = goodId, GoodVerb = verbId, Title = title, InvitationReservation = reservation, Detail = "约会内容：" + title + (verb == null ? "" : " · " + good.Name) + "。请在留言中商谈日期与安排，等待对方回应。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Conversation(data, person).GiftDrafts.Add(new() { Kind = Kind, GoodId = goodId, GoodVerb = verbId, Title = title, InvitationReservation = reservation, Detail = "约会内容：" + title + (verb == null ? "" : " · " + good.Name) + "。请在留言中商谈日期与安排，等待对方回应。" });`

**赋值（含属性/字段和局部值）：**

- `Detail` = `"约会内容：" + title + (verb == null ? "" : " · " + good.Name) + "。请在留言中商谈日期与安排，等待对方回应。"`
- `GoodId` = `goodId`
- `GoodVerb` = `verbId`
- `InvitationReservation` = `reservation`
- `Kind` = `Kind`
- `Title` = `title`

<a id="symbol-9f0c7f580228"></a>

## `NationalSpire.ConsumerInvitations.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Prepare(CareerData data, string person, PrivateOffer attachment)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-71fa8e1feaa2)；[`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-ad51c0c18b5f)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitationStock.ActiveMessage`；`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerInvitations.Kind`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.AiDetail`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.InvitationReservation`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；输入表达式：`ConsumerInvitationStock.Active(data)`；返回值紧邻使用处：`IfStatementSyntax: if (ConsumerInvitationStock.Active(data)) return ConsumerInvitationStock.ActiveMessage;`
- `NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ConsumerInvitationStock.Validate(data, person, source)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerInvitationStock.Validate(data, person, source) is { } error`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).GiftDrafts`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).GiftDrafts.FirstOrDefault(a => a.Id == attachment.Id && a.Kind == Kind)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person).GiftDrafts.FirstOrDefault(a => a.Id == attachment.Id && a.Kind == Kind)`

**赋值（含属性/字段和局部值）：**

- `attachment.AiDetail` = `null`
- `attachment.Detail` = `source.Detail`
- `attachment.GoodId` = `source.GoodId`
- `attachment.GoodVerb` = `source.GoodVerb`
- `attachment.InvitationReservation` = `source.InvitationReservation`
- `attachment.Title` = `source.Title`

<a id="symbol-ce030fcb265a"></a>

## `NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation) — public static IEnumerable<PrivateOffer> Pending(PrivateConversation conversation)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`](ConsumerInvitationStock.cs.md#symbol-18ffa12d670c)；[`NationalSpire.ConsumerInvitations.Context(NationalSpire.PrivateConversation)`](ConsumerInvitations.cs.md#symbol-1845d81790ae)；[`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerInvitations.Kind`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.SourceInvitationId`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`handled.Contains(a.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !handled.Contains(a.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments).Where(a => a.Kind == Kind && !handled.Contains(a.Id)).DistinctBy(a => a.Id)`；返回值紧邻使用处：`ReturnStatementSyntax: return conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments).Where(a => a.Kind == Kind && !handled.Contains(a.Id)).DistinctBy(a => a.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`conversation.Offers.Where(o => o.SourceInvitationId.Length > 0).Select(o => o.SourceInvitationId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Offers.Where(o => o.SourceInvitationId.Length > 0).Select(o => o.SourceInvitationId).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`conversation.Offers.Where(o => o.SourceInvitationId.Length > 0).Select(o => o.SourceInvitationId).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.Where(o => o.SourceInvitationId.Length > 0).Select(o => o.SourceInvitationId).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.Where(o => o.SourceInvitationId.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Offers.Where(o => o.SourceInvitationId.Length > 0).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => !t.UserDeleted)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Where(t => !t.UserDeleted).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments).Where(a => a.Kind == Kind && !handled.Contains(a.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Where(t => !t.UserDeleted).SelectMany(t => t.Attachments).Where(a => a.Kind == Kind && !handled.Contains(a.Id)).DistinctBy`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1845d81790ae"></a>

## `NationalSpire.ConsumerInvitations.Context(NationalSpire.PrivateConversation) — public static string Context(PrivateConversation conversation)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation)`](ConsumerInvitations.cs.md#symbol-ce030fcb265a)；[`NationalSpire.PrivateInteractionIds.Number(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](PrivateMessageData.cs.md#symbol-5ca7dee3ea48)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateInteractionIds.Number(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation)`；输入表达式：`Pending(conversation)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pending(conversation).Select`
- `NationalSpire.PrivateInteractionIds.Number(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；输入表达式：`PrivateInteractionIds.Number(conversation, a)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateInteractionIds.Number(conversation, a)}`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Pending(conversation).Select(a => $"待回应约会邀请{PrivateInteractionIds.Number(conversation, a)}《{a.Title}》：{a.Detail}")`；返回值紧邻使用处：`ArgumentSyntax: Pending(conversation).Select(a => $"待回应约会邀请{PrivateInteractionIds.Number(conversation, a)}《{a.Title}》：{a.Detail}")`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", Pending(conversation).Select(a => $"待回应约会邀请{PrivateInteractionIds.Number(conversation, a)}《{a.Title}》：{a.Detail}"))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => string.Join("\n", Pending(conversation).Select(a => $"待回应约会邀请{PrivateInteractionIds.Number(conversation, a)}《{a.Title}》：{a.Detail}"))`

**赋值（含属性/字段和局部值）：**
