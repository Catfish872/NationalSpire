# LeagueSeasonRoster.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B829053286592ADB95F41FA3847E9830D7B8E28534EAD971B4C1BCCA2CC4F51D`。来源：[源码](../../LeagueSeasonRoster.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueSeasonRoster`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-b1e9bbf26da3"></a>

## `NationalSpire.LeagueSeasonRoster.Prepare(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>) — internal static bool Prepare(CareerData world,IReadOnlyList<string> available)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData)`](LeagueLadder.cs.md#symbol-fc32b34df886)

**调用：** [`NationalSpire.LeagueArchetypes.Name(string, string)`](LeagueArchetypes.cs.md#symbol-eed6465b998c)；[`NationalSpire.NpcCharacters.Index(string)`](NpcCharacters.cs.md#symbol-8f7f43f17d89)；[`Record(int, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](LeagueSeasonRoster.cs.md#symbol-4a92d2e35cdf)；`NationalSpire.LeagueSeasonRoster.LeagueSeasonRoster(int, NationalSpire.LeagueBracket[])`；`System.ArraySegment<T>.ArraySegment(T[], int, int)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.CareerPerson Person, string Role).Person`；`(NationalSpire.CareerPerson Person, string Role).Role`；`(string Role, string Plan).Plan`；`(string Role, string Plan).Role`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.LeagueRoster`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Style`；`NationalSpire.LeagueArchetypes.Name(string, string)`；`NationalSpire.LeagueSeasonRoster.Season`；`NationalSpire.NpcCharacters.Index(string)`；`Record(int, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueArchetypes.Name(string, string)`；输入表达式：`LeagueArchetypes.Name(x.Role!,x.Person.Style)`；返回值紧邻使用处：`ArgumentSyntax: Plan:LeagueArchetypes.Name(x.Role!,x.Person.Style)`
- `NationalSpire.LeagueSeasonRoster.LeagueSeasonRoster(int, NationalSpire.LeagueBracket[])`；输入表达式：`new(world.Season,brackets.ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: world.LeagueRoster=new(world.Season,brackets.ToArray())`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(p.Character)`；返回值紧邻使用处：`ArgumentSyntax: NpcCharacters.Index(p.Character)`
- `Record(int, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`；输入表达式：`Record(tier,new ArraySegment<CareerPerson>(people,offset,count))`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(tier,new ArraySegment<CareerPerson>(people,offset,count));`
- `Record(int, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`；输入表达式：`Record(tier.Key,tier)`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(tier.Key,tier);`
- `System.ArraySegment<T>.ArraySegment(T[], int, int)`；输入表达式：`new ArraySegment<CareerPerson>(people,offset,count)`；返回值紧邻使用处：`ArgumentSyntax: new ArraySegment<CareerPerson>(people,offset,count)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`people.GroupBy(p=>p.MaxAscension switch{>=10=>3,9=>2,>=6=>1,_=>0})`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var tier in people.GroupBy(p=>p.MaxAscension switch{>=10=>3,9=>2,>=6=>1,_=>0}))Record(tier.Key,tier);`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))             .Where(x=>x.Role!=null).GroupBy(x=>(Role:x.Role!,Plan:LeagueArchetypes.Name(x.Role!,x.Person.Style)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))             .Where(x=>x.Role!=null).GroupBy(x=>(Role:x.Role!,Plan:LeagueArchetypes.Name(x.Role!,x.Person.Style)))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`groups.OrderBy(g=>g.Key.Role,StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: groups.OrderBy(g=>g.Key.Role,StringComparer.Ordinal).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Select(x=>x.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(x=>x.Person).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))             .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy(p=>p.Id,StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy(p=>p.Id,StringComparer.Ordinal).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`available.ToDictionary(NpcCharacters.Index)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =available.ToDictionary(NpcCharacters.Index)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))             .Where(x=>x.Role!=null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))             .Where(x=>x.Role!=null).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`roles.GetValueOrDefault(NpcCharacters.Index(p.Character))`；返回值紧邻使用处：`ArgumentSyntax: Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`world.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !world.HumanIds.Contains(p.Id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<LeagueBracket>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<LeagueBracket>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`brackets.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: brackets.ToArray()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy(p=>p.Id,StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy(p=>p.Id,StringComparer.Ordinal).ToArray`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`groups.OrderBy(g=>g.Key.Role,StringComparer.Ordinal).ThenBy(g=>g.Key.Plan,StringComparer.Ordinal)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var group in groups.OrderBy(g=>g.Key.Role,StringComparer.Ordinal).ThenBy(g=>g.Key.Plan,StringComparer.Ordinal)){             var people=group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy(p=>p.Id,StringComparer.Ordinal).ToArray();             int n=people.Length, offset=0;             void Record(int tier,IEnumerable<CareerPerson> members){                 var styles=members.GroupBy(p=>p.Style).ToDictionary(g=>g.Key,g=>g.Select(p=>p.Id).ToArray());                 if(styles.Count>0)brackets.Add(new(group.Key.Role,group.Key.Plan,tier,styles));             }             if(n<4){                 foreach(var tier in people.GroupBy(p=>p.MaxAscension switch{>=10=>3,9=>2,>=6=>1,_=>0}))Record(tier.Key,tier);             }else for(int tier=0;tier<4;tier++){                 int count=n/4+(tier<n%4?1:0);Record(tier,new ArraySegment<CareerPerson>(people,offset,count));offset+=count;             }         }`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy`

**赋值（含属性/字段和局部值）：**

- `offset` += `count`
- `world.LeagueRoster` = `new(world.Season,brackets.ToArray())`

<a id="symbol-4a92d2e35cdf"></a>

## `Record(int, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>) — void Record(int tier,IEnumerable<CareerPerson> members)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueSeasonRoster.Prepare(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](LeagueSeasonRoster.cs.md#symbol-b1e9bbf26da3)

**调用：** `NationalSpire.LeagueBracket.LeagueBracket(string, string, int, System.Collections.Generic.Dictionary<string, string[]>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `(string Role, string Plan).Plan`；`(string Role, string Plan).Role`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Style`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueBracket.LeagueBracket(string, string, int, System.Collections.Generic.Dictionary<string, string[]>)`；输入表达式：`new(group.Key.Role,group.Key.Plan,tier,styles)`；返回值紧邻使用处：`ArgumentSyntax: new(group.Key.Role,group.Key.Plan,tier,styles)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`members.GroupBy(p=>p.Style)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: members.GroupBy(p=>p.Style).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(p=>p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(p=>p.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.Select(p=>p.Id).ToArray()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g=>g.Select(p=>p.Id).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`members.GroupBy(p=>p.Style).ToDictionary(g=>g.Key,g=>g.Select(p=>p.Id).ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =members.GroupBy(p=>p.Style).ToDictionary(g=>g.Key,g=>g.Select(p=>p.Id).ToArray())`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`brackets.Add(new(group.Key.Role,group.Key.Plan,tier,styles))`；返回值紧邻使用处：`ExpressionStatementSyntax: brackets.Add(new(group.Key.Role,group.Key.Plan,tier,styles));`

**赋值（含属性/字段和局部值）：**
