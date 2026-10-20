# ChatContacts.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`08413CB1044501D24D9C5509A43B8A67A056A9FAA537AC29421BACEFAF803704`。来源：[源码](../../ChatContacts.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatContactPreferences`、`NationalSpire.ChatContact`、`NationalSpire.ChatContacts`、`NationalSpire.ChatContacts.Events`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly StringComparer Names = StringComparer.Create(CultureInfo.GetCultureInfo("zh-CN"), true);
private static readonly Encoding Chinese = ChineseEncoding();
```

<a id="symbol-f403d7a8757e"></a>

## `NationalSpire.ChatContactPreferences.Pinned — public List<string> Pinned`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-887b7c3903dc"></a>

## `NationalSpire.ChatContactPreferences.Hidden — public HashSet<string> Hidden`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-54867513c8d0"></a>

## `NationalSpire.ChatContactPreferences.Sort — public string Sort`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-43af133816ee"></a>

## `NationalSpire.ChatContactPreferences.Reverse — public bool Reverse`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8a804ab4931b"></a>

## `NationalSpire.ChatContactPreferences.ShowHidden — public bool ShowHidden`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d53f35e84bf6"></a>

## `NationalSpire.ChatContactPreferences.ShowRelationships — public bool ShowRelationships`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7524b2a7fc80"></a>

## `NationalSpire.ChatContactPreferences.Pin(string) — public void Pin(string key)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.List<T>.Insert(int, T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatContactPreferences.Pinned`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`Pinned.Insert(0, key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pinned.Insert(0, key);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`Pinned.Remove(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Pinned.Remove(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d1c4d9fbbd07"></a>

## `NationalSpire.ChatContactPreferences.Hide(string) — public void Hide(string key)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatContactPreferences.Hidden`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`Hidden.Add(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Hidden.Add(key);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`Hidden.Remove(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Hidden.Remove(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a881df3d005b"></a>

## `NationalSpire.ChatContact.Key — public string Key`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ChatContact.Group`；`NationalSpire.ChatContact.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bc725c5627a8"></a>

## `NationalSpire.ChatContacts.PendingEvents(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateConversation>, System.Collections.Generic.IReadOnlySet<string>) — public static Events PendingEvents(CareerData data, IEnumerable<PrivateConversation> conversations, IReadOnlySet<string> pendingMatches)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatContacts.EventIndicators(NationalSpire.CareerData)`](ChatContacts.cs.md#symbol-e894a486e226)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`NationalSpire.ChatContacts.Events.Events(bool, bool, bool, bool, bool, bool)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatContacts.Events.Events(bool, bool, bool, bool, bool, bool)`；输入表达式：`new(match, date, matchToday, dateToday, wedding, weddingToday)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(match, date, matchToday, dateToday, wedding, weddingToday);`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, o)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateAppointments.Date(data, o)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.DateSceneStates.GetValueOrDefault(o.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.GetValueOrDefault(o.Id) != "ended"`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.DateSceneStates.GetValueOrDefault(o.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused"`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`pendingMatches.Contains(o.MatchId)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "match" && o.State == "已确认" && pendingMatches.Contains(o.MatchId)`

**赋值（含属性/字段和局部值）：**

- `date` = `true`
- `dateToday` |= `day == data.Day`
- `match` = `true`
- `matchToday` |= `day == data.Day`
- `wedding` = `true`
- `weddingToday` |= `day == data.Day`

<a id="symbol-e894a486e226"></a>

## `NationalSpire.ChatContacts.EventIndicators(NationalSpire.CareerData) — public static Dictionary<string, Events> EventIndicators(CareerData data)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)

**调用：** [`NationalSpire.ChatContacts.PendingEvents(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateConversation>, System.Collections.Generic.IReadOnlySet<string>)`](ChatContacts.cs.md#symbol-bc725c5627a8)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.ChatContacts.PendingEvents(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateConversation>, System.Collections.Generic.IReadOnlySet<string>)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatContacts.PendingEvents(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateConversation>, System.Collections.Generic.IReadOnlySet<string>)`；输入表达式：`PendingEvents(data, [p.Value], matches)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PendingEvents(data, [p.Value], matches)`
- `NationalSpire.ChatContacts.PendingEvents(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateConversation>, System.Collections.Generic.IReadOnlySet<string>)`；输入表达式：`PendingEvents(data, group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value), matches)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result["group:" + group.Id] = PendingEvents(data, group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value), matches)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Human(data) + "/"`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in GroupChats.Visible(data))              result["group:" + group.Id] = PendingEvents(data, group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value), matches);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith(human, StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Key.StartsWith(human, StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Matches.Where(m => m.Status == "待赛" && m.Registered).Select(m => m.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Status == "待赛" && m.Registered).Select(m => m.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value)`；返回值紧邻使用处：`ArgumentSyntax: group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.ToDictionary(p => p.Key, p => PendingEvents(data, [p.Value], matches))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.ToDictionary(p => p.Key, p => PendingEvents(data, [p.Value], matches))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`data.Matches.Where(m => m.Status == "待赛" && m.Registered).Select(m => m.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.Where(m => m.Status == "待赛" && m.Registered).Select(m => m.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Status == "待赛" && m.Registered)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Status == "待赛" && m.Registered).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select`

**赋值（含属性/字段和局部值）：**

- `result["group:" + group.Id]` = `PendingEvents(data, group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value), matches)`

<a id="symbol-f0f9556075d1"></a>

## `NationalSpire.ChatContacts.LastChatText(int, int) — public static string LastChatText(int today, int day)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bf07ae6b62d9"></a>

## `NationalSpire.ChatContacts.ChineseEncoding() — private static Encoding ChineseEncoding()`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Text.Encoding.GetEncoding(int)`；`System.Text.Encoding.RegisterProvider(System.Text.EncodingProvider)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Encoding.GetEncoding(int)`；输入表达式：`Encoding.GetEncoding(936)`；返回值紧邻使用处：`ReturnStatementSyntax: return Encoding.GetEncoding(936);`
- `System.Text.Encoding.RegisterProvider(System.Text.EncodingProvider)`；输入表达式：`Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-208788551526"></a>

## `NationalSpire.ChatContacts.Initial(string) — public static char Initial(string name)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`](ChatContacts.cs.md#symbol-9d6a9ed3895a)

**调用：** `char.ToString()`；`char.ToUpperInvariant(char)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatContacts.Chinese`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.ToString()`；输入表达式：`first.ToString()`；返回值紧邻使用处：`ArgumentSyntax: first.ToString()`
- `char.ToUpperInvariant(char)`；输入表达式：`char.ToUpperInvariant(first)`；返回值紧邻使用处：`ReturnStatementSyntax: return char.ToUpperInvariant(first);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`name.FirstOrDefault(char.IsLetterOrDigit)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = name.FirstOrDefault(char.IsLetterOrDigit)`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Chinese.GetBytes(first.ToString())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Chinese.GetBytes(first.ToString())`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9d6a9ed3895a"></a>

## `NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string) — public static List<ChatContact> List(CareerData data, ChatContactPreferences preferences, string filter, string query)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)

**调用：** [`NationalSpire.ChatContacts.Initial(string)`](ChatContacts.cs.md#symbol-208788551526)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-eb7a8aaa6a38)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.ChatContact.ChatContact(string, bool, string, int, long, int)`；`string.Contains(string, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `(string key, int i).i`；`(string key, int i).key`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.ChatContact.Day`；`NationalSpire.ChatContact.Favour`；`NationalSpire.ChatContact.Group`；`NationalSpire.ChatContact.Key`；`NationalSpire.ChatContact.Name`；`NationalSpire.ChatContact.Order`；`NationalSpire.ChatContactPreferences.Hidden`；`NationalSpire.ChatContactPreferences.Pinned`；`NationalSpire.ChatContactPreferences.Reverse`；`NationalSpire.ChatContactPreferences.ShowHidden`；`NationalSpire.ChatContactPreferences.Sort`；`NationalSpire.ChatContacts.Initial(string)`；`NationalSpire.ChatContacts.Names`；`NationalSpire.GroupChat.Entries`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.PrivateConversation.Hidden`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.UserOrder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatContact.ChatContact(string, bool, string, int, long, int)`；输入表达式：`new(group.Id, true, group.Name, 0, order, Math.Max(turn?.Day ?? 0, entry?.Day ?? 0))`；返回值紧邻使用处：`ArgumentSyntax: new(group.Id, true, group.Name, 0, order, Math.Max(turn?.Day ?? 0, entry?.Day ?? 0))`
- `NationalSpire.ChatContact.ChatContact(string, bool, string, int, long, int)`；输入表达式：`new(id, false, p.PublicName, box.Relations.GetValueOrDefault(id)?.Favour ?? 0, Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0), turn?.Day ?? 0)`；返回值紧邻使用处：`ArgumentSyntax: new(id, false, p.PublicName, box.Relations.GetValueOrDefault(id)?.Favour ?? 0, Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0), turn?.Day ?? 0)`
- `NationalSpire.ChatContacts.Initial(string)`；输入表达式：`Initial(e.Name)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => Initial(e.Name)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !people.TryGetValue(id, out var p) || !PrivateMessages.CanChat(data, id) || GroupChats.IsHuman(data, id)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, p.Id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Name(data, id).Contains`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(data).Where`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, id)`
- `NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation)`；输入表达式：`PrivateMessages.ListedInCommunications(c)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => PrivateMessages.ListedInCommunications(c)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`g.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: query.Length == 0 || g.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`k.StartsWith("group:", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !k.StartsWith("group:", StringComparison.Ordinal)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`pins.ContainsKey(e.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !pins.ContainsKey(e.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`pins.ContainsKey(e.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => pins.ContainsKey(e.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`people.TryGetValue(id, out var p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !people.TryGetValue(id, out var p)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`preferences.Hidden.Contains(e.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !preferences.Hidden.Contains(e.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.Any(id => GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`BinaryExpressionSyntax: query.Length == 0 || g.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || g.Members.Any(id => GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase))`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId).Concat(preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId).Concat(preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`others.Concat(groups)`；返回值紧邻使用处：`AssignmentExpressionSyntax: others = others.Concat(groups)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`pinned.Concat(others)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pinned.Concat(others).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId).Concat(preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))).Distinct()`；返回值紧邻使用处：`ConditionalExpressionSyntax: query.Length > 0 ? data.People.Where(p => !GroupChats.IsHuman(data, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))).Select(p => p.Id)                  : box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId).Concat(preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`g.First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.First().i`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`preferences.Pinned.Select((key, i) => (key, i)).GroupBy(p => p.key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: preferences.Pinned.Select((key, i) => (key, i)).GroupBy(p => p.key).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`.Replies.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Replies.LastOrDefault()?.Order`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`group.Entries.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Entries.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`group.Turns.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: box.Conversations.GetValueOrDefault(id)?.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`entries.Where(e => pins.ContainsKey(e.Key)).OrderBy(e => pins[e.Key])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.Where(e => pins.ContainsKey(e.Key)).OrderBy(e => pins[e.Key])`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(e => e.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Order).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(e => Initial(e.Name))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => Initial(e.Name)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.Where(e => !e.Group).OrderBy(e => e.Favour)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderByDescending(e => e.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderByDescending(e => e.Order).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderByDescending(e => Initial(e.Name))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderByDescending(e => Initial(e.Name)).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.Where(e => !e.Group).OrderByDescending(e => e.Favour)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.Where(e => e.Group).OrderByDescending(e => e.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => e.Group).OrderByDescending(e => e.Order).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`preferences.Pinned.Select((key, i) => (key, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: preferences.Pinned.Select((key, i) => (key, i)).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.People.Where(p => !GroupChats.IsHuman(data, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))).Select(p => p.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: query.Length > 0 ? data.People.Where(p => !GroupChats.IsHuman(data, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))).Select(p => p.Id)                  : box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select(c => c.PersonId).Concat(preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`others.Where(e => e.Group).OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = others.Where(e => e.Group).OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`preferences.Pinned.Select((key, i) => (key, i)).GroupBy(p => p.key).ToDictionary(g => g.Key, g => g.First().i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = preferences.Pinned.Select((key, i) => (key, i)).GroupBy(p => p.key).ToDictionary(g => g.Key, g => g.First().i)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.ToDictionary(p => p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.ToDictionary(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entries.Where(e => preferences.ShowHidden || !preferences.Hidden.Contains(e.Key)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: entries = entries.Where(e => preferences.ShowHidden || !preferences.Hidden.Contains(e.Key)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`pinned.Concat(others).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return pinned.Concat(others).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: box.Conversations.Values.Where(c => PrivateMessages.ListedInCommunications(c)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => !GroupChats.IsHuman(data, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => !GroupChats.IsHuman(data, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`entries.Where(e => !pins.ContainsKey(e.Key))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.Where(e => !pins.ContainsKey(e.Key))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`entries.Where(e => pins.ContainsKey(e.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Where(e => pins.ContainsKey(e.Key)).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`entries.Where(e => preferences.ShowHidden || !preferences.Hidden.Contains(e.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Where(e => preferences.ShowHidden || !preferences.Hidden.Contains(e.Key)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`GroupChats.Visible(data).Where(g => query.Length == 0 || g.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || g.Members.Any(id => GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in GroupChats.Visible(data).Where(g => query.Length == 0 || g.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || g.Members.Any(id => GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase))))              {                  var turn = group.Turns.LastOrDefault(); var entry = group.Entries.LastOrDefault();                  long order = Math.Max(Math.Max(turn?.Order ?? 0, turn?.Replies.LastOrDefault()?.Order ?? 0), entry?.Order ?? 0);                  entries.Add(new(group.Id, true, group.Name, 0, order, Math.Max(turn?.Day ?? 0, entry?.Day ?? 0)));              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`others.Where(e => !e.Group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => !e.Group).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`others.Where(e => !e.Group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => !e.Group).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`others.Where(e => e.Group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => e.Group).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))`；返回值紧邻使用处：`ArgumentSyntax: preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Conversations.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: box.Conversations.GetValueOrDefault(id)?.Hidden`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Conversations.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: box.Conversations.GetValueOrDefault(id)?.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Relations.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: box.Relations.GetValueOrDefault(id)?.Favour`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entries.Add(new(group.Id, true, group.Name, 0, order, Math.Max(turn?.Day ?? 0, entry?.Day ?? 0)))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.Add(new(group.Id, true, group.Name, 0, order, Math.Max(turn?.Day ?? 0, entry?.Day ?? 0)));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entries.Add(new(id, false, p.PublicName, box.Relations.GetValueOrDefault(id)?.Favour ?? 0, Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0), turn?.Day ?? 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.Add(new(id, false, p.PublicName, box.Relations.GetValueOrDefault(id)?.Favour ?? 0, Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0), turn?.Day ?? 0));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<ChatContact>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<ChatContact>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ("type", _) => others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: (_, true) => others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderBy(e => Initial(e.Name)).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ("name", false) => others.OrderBy(e => Initial(e.Name)).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderBy(e => Initial(e.Name)).ThenBy(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => Initial(e.Name)).ThenBy(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderByDescending(e => Initial(e.Name)).ThenByDescending(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ("name", true) => others.OrderByDescending(e => Initial(e.Name)).ThenByDescending(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ("favour", true) => others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ("favour", false) => others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(e => e.Order).ThenBy(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`others.OrderByDescending(e => Initial(e.Name)).ThenByDescending(e => e.Name, Names)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderByDescending(e => Initial(e.Name)).ThenByDescending(e => e.Name, Names).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`others.Where(e => e.Group).OrderByDescending(e => e.Order).ThenByDescending(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: others.Where(e => e.Group).OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ToArray`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(turn?.Day ?? 0, entry?.Day ?? 0)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(turn?.Day ?? 0, entry?.Day ?? 0)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(Math.Max(turn?.Order ?? 0, turn?.Replies.LastOrDefault()?.Order ?? 0), entry?.Order ?? 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(Math.Max(turn?.Order ?? 0, turn?.Replies.LastOrDefault()?.Order ?? 0), entry?.Order ?? 0)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(turn?.Order ?? 0, turn?.Replies.LastOrDefault()?.Order ?? 0)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(turn?.Order ?? 0, turn?.Replies.LastOrDefault()?.Order ?? 0)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0)`

**赋值（含属性/字段和局部值）：**

- `entries` = `entries.Where(e => preferences.ShowHidden || !preferences.Hidden.Contains(e.Key)).ToList()`
- `others` = `(preferences.Sort, preferences.Reverse) switch          {              ("favour", false) => others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),              ("favour", true) => others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),              ("name", false) => others.OrderBy(e => Initial(e.Name)).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),              ("name", true) => others.OrderByDescending(e => Initial(e.Name)).ThenByDescending(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),              ("type", _) => others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),              (_, true) => others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),              _ => others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)          }`
- `others` = `others.Concat(groups)`
