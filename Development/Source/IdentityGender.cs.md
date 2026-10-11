# IdentityGender.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1A2DF95E98B620E448C769FD9064434E2B95022BE3A5B1BAE980A08012E998AF`。来源：[源码](../../IdentityGender.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.IdentityGender`。

字段、事件及初始值（源码原样）：

```csharp
public const string Unset = "未设置";
public static readonly string[] Choices = [Unset, "男", "女"];
```

<a id="symbol-9b3f1de1d44a"></a>

## `NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string) — public static string Assigned(CareerData data, string id)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-9a2f255d8204)；[`NationalSpire.IdentityGender.Ensure(NationalSpire.CareerData)`](IdentityGender.cs.md#symbol-95c66fc7bbdb)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；[`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-3dba497c8606)；[`NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`](WorldPeople.cs.md#symbol-731e781389c6)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(data.WorldId + ":gender:" + id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(data.WorldId + ":gender:" + id)`
- `System.Random.Next(int)`；输入表达式：`new Random(CareerEngine.StableHash(data.WorldId + ":gender:" + id)).Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Random(CareerEngine.StableHash(data.WorldId + ":gender:" + id)).Next(2) == 0`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(data.WorldId + ":gender:" + id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Random(CareerEngine.StableHash(data.WorldId + ":gender:" + id)).Next`

**赋值（含属性/字段和局部值）：**


<a id="symbol-961507352d98"></a>

## `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string) — public static string Of(CareerData data, string id)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?)`](AiDiscussion.cs.md#symbol-92d85bbd4154)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.IdentityGender.Ensure(NationalSpire.CareerData)`](IdentityGender.cs.md#symbol-95c66fc7bbdb)；[`NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivatePublicContext.cs.md#symbol-9d0bf89294e6)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)；[`NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`](WorldPeople.cs.md#symbol-731e781389c6)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-9b3f1de1d44a)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Choices`；`NationalSpire.IdentityGender.Unset`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, id)`
- `NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；输入表达式：`Assigned(data, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.HumanIds.Contains(id) || id.StartsWith("human-") ? Unset : Assigned(data, id)`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("human-")`；返回值紧邻使用处：`BinaryExpressionSyntax: data.HumanIds.Contains(id) || id.StartsWith("human-")`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Choices.Contains(data.PlayerGender)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Choices.Contains(data.PlayerGender) ? data.PlayerGender : Unset`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.HumanIds.Contains(id) || id.StartsWith("human-")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-95c66fc7bbdb"></a>

## `NationalSpire.IdentityGender.Ensure(NationalSpire.CareerData) — public static void Ensure(CareerData data)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PlayerIdentity.Ensure(NationalSpire.CareerData)`](PlayerIdentity.cs.md#symbol-340085e81d95)

**调用：** [`NationalSpire.HumanNames.KnownGender(string, string)`](HumanNames.cs.md#symbol-a5552e5b910e)；[`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-9b3f1de1d44a)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CommunityPost.PeopleAtEvent`；`NationalSpire.HumanNames.KnownGender(string, string)`；`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Choices`；`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Unset`；`NationalSpire.WeeklyEdition.Profiles`；`NationalSpire.WeeklyProfile.Gender`；`NationalSpire.WeeklyProfile.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.HumanNames.KnownGender(string, string)`；输入表达式：`HumanNames.KnownGender(person.Country, person.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: HumanNames.KnownGender(person.Country, person.Name) ?? Assigned(data, person.Id)`
- `NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；输入表达式：`Assigned(data, person.Id)`；返回值紧邻使用处：`ArgumentSyntax: Assigned(data, person.Id)`
- `NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；输入表达式：`Assigned(data, person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: HumanNames.KnownGender(person.Country, person.Name) ?? Assigned(data, person.Id)`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`Of(data, profile.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: profile.Gender = Of(data, profile.Id)`
- `string.StartsWith(string)`；输入表达式：`person.Id.StartsWith("human-")`；返回值紧邻使用处：`BinaryExpressionSyntax: data.HumanIds.Contains(person.Id) || person.Id.StartsWith("human-")`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Posts.Concat(data.SavedThreads)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Posts.Concat(data.SavedThreads).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Choices.Contains(data.PlayerGender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Choices.Contains(data.PlayerGender)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Choices.Contains(person.Gender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Choices.Contains(person.Gender)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent))             if (person.Gender.Length == 0 || person.CameoId.Length > 0)                 person.Gender = genders.GetValueOrDefault(person.Id, Assigned(data, person.Id));`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.WeeklyEditions.SelectMany(w => w.Profiles)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var profile in data.WeeklyEditions.SelectMany(w => w.Profiles))             if (profile.Gender.Length == 0) profile.Gender = Of(data, profile.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`data.People.ToDictionary(p => p.Id, p => p.Gender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.ToDictionary(p => p.Id, p => p.Gender)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`genders.GetValueOrDefault(person.Id, Assigned(data, person.Id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.Gender = genders.GetValueOrDefault(person.Id, Assigned(data, person.Id))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.HumanIds.Contains(person.Id) || person.Id.StartsWith("human-")`

**赋值（含属性/字段和局部值）：**

- `data.PlayerGender` = `Unset`
- `person.Gender` = `"男"`
- `person.Gender` = `genders.GetValueOrDefault(person.Id, Assigned(data, person.Id))`
- `person.Gender` = `HumanNames.KnownGender(person.Country, person.Name) ?? Assigned(data, person.Id)`
- `person.Gender` = `Unset`
- `profile.Gender` = `Of(data, profile.Id)`

<a id="symbol-449fc02b003e"></a>

## `NationalSpire.IdentityGender.SetPlayer(NationalSpire.CareerData, string) — public static string? SetPlayer(CareerData data, string gender)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.IdentityGender.Choices`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Choices.Contains(gender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Choices.Contains(gender)`

**赋值（含属性/字段和局部值）：**

- `data.PlayerGender` = `gender`
- `data.PlayerGender` = `previous`
