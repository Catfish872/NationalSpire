# CareerCommerce.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`56CCD0BC49D4F085AC27A70DB6EF53D40E06081F4846C4AB31827C1BF2690357`。来源：[源码](../../CareerCommerce.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerCommerce`。

字段、事件及初始值（源码原样）：

```csharp
public const int Version = 1;
private static readonly string[] Identities = ["争冠强队", "青训俱乐部", "商业俱乐部", "重建俱乐部"];
private static readonly string[][] Brands = [
        ["篝火训练用品", "橡木装备", "远行运动", "磐石护具"],
        ["星港外设", "棱镜显示", "雷鸣键盘", "疾风竞技椅"],
        ["金羽饮品", "云帆通讯", "晨钟咖啡", "晴空影像"] ];
```

<a id="symbol-0d09d372bf3d"></a>

## `NationalSpire.CareerCommerce.LegacySponsors(int) — internal static IReadOnlyList<string> LegacySponsors(int plan)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RegionalOrganizations.SponsorCatalog()`](RegionalOrganizations.cs.md#symbol-c12ea64ac22f)；[`NationalSpire.RegionalOrganizations.SponsorDescription(string)`](RegionalOrganizations.cs.md#symbol-421e3c666278)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.Brands`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e72ebe7c108f"></a>

## `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string) — public static int IdentityIndex(CareerData d, string club)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`](CareerCommerce.cs.md#symbol-87ae7b47fe11)；[`NationalSpire.CareerCommerce.ProfessionalCount(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-73af8a465ddb)；[`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.CareerCommerce.YouthCount(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-51707cea034a)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.CircuitLedger.CreateContract(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-fe0f4a1b42d8)；[`NationalSpire.RegionalOrganizations.Ensure(NationalSpire.CareerData)`](RegionalOrganizations.cs.md#symbol-cd501c70073c)；[`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":club:" + club)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(d.WorldId + ":club:" + club) % 4`

**赋值（含属性/字段和局部值）：**


<a id="symbol-73af8a465ddb"></a>

## `NationalSpire.CareerCommerce.ProfessionalCount(NationalSpire.CareerData, string) — public static int ProfessionalCount(CareerData d, string club)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.Ensure(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-f59ba7354968)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)

**调用：** [`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`IdentityIndex(d, club)`；返回值紧邻使用处：`SwitchExpressionSyntax: IdentityIndex(d, club) switch { 0 => 7, 1 => 5, 2 => 6, _ => 4 }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-51707cea034a"></a>

## `NationalSpire.CareerCommerce.YouthCount(NationalSpire.CareerData, string) — public static int YouthCount(CareerData d, string club)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.Ensure(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-f59ba7354968)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)

**调用：** [`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`IdentityIndex(d, club)`；返回值紧邻使用处：`SwitchExpressionSyntax: IdentityIndex(d, club) switch { 0 => 2, 1 => 5, 2 => 1, _ => 3 }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-87ae7b47fe11"></a>

## `NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool) — public static void ConfigureClub(CareerData d, CareerClub club, bool fresh)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CircuitPeople.Ensure(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-f59ba7354968)；[`NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData)`](ClubDeparture.cs.md#symbol-1579a5b3a3c8)

**调用：** [`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.RegionalOrganizations.ClubDescription(NationalSpire.CareerData, NationalSpire.CareerClub, int)`](RegionalOrganizations.cs.md#symbol-4c326b6a0e3d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Identity`；`NationalSpire.CareerClub.Motto`；`NationalSpire.CareerClub.OperatingIncome`；`NationalSpire.CareerCommerce.Identities`；`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.RegionalOrganizations.ClubDescription(NationalSpire.CareerData, NationalSpire.CareerClub, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`IdentityIndex(d, club.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = IdentityIndex(d, club.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + club.Id + ":finance")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + club.Id + ":finance")`
- `NationalSpire.RegionalOrganizations.ClubDescription(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；输入表达式：`RegionalOrganizations.ClubDescription(d, club, kind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: club.Motto = RegionalOrganizations.ClubDescription(d, club, kind)`

**赋值（含属性/字段和局部值）：**

- `club.Budget` = `(kind switch { 0 => 60000, 1 => 28000, 2 => 48000, _ => 20000 }) + seed % 6001`
- `club.Identity` = `Identities[kind]`
- `club.Motto` = `RegionalOrganizations.ClubDescription(d, club, kind)`
- `club.OperatingIncome` = `(kind switch { 0 => 10000, 1 => 7500, 2 => 12000, _ => 6500 }) + seed % 151`

<a id="symbol-d734109c7eea"></a>

## `NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData) — public static void Upgrade(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)

**调用：** [`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`](CareerCommerce.cs.md#symbol-87ae7b47fe11)；[`NationalSpire.CareerCommerce.CopyTerms(NationalSpire.ClubOffer, NationalSpire.ClubOffer)`](CareerCommerce.cs.md#symbol-a924f1bfbba3)；[`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`](CommunityThreads.cs.md#symbol-981631ecddfc)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`](SponsorIncome.cs.md#symbol-efb9102304ba)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`；`NationalSpire.CareerCommerce.CopyTerms(NationalSpire.ClubOffer, NationalSpire.ClubOffer)`；`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.Version`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerHonor.Detail`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerHonor.Title`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Revision`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.SourceTitle`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.ClubPaidSeason`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.CommerceVersion`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorContract.TargetId`；`NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；输入表达式：`Capture(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(d);`
- `NationalSpire.CareerCommerce.ConfigureClub(NationalSpire.CareerData, NationalSpire.CareerClub, bool)`；输入表达式：`ConfigureClub(d, club, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConfigureClub(d, club, false);`
- `NationalSpire.CareerCommerce.CopyTerms(NationalSpire.ClubOffer, NationalSpire.ClubOffer)`；输入表达式：`CopyTerms(Quote(d, club), offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: CopyTerms(Quote(d, club), offer);`
- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`Quote(d, club)`；返回值紧邻使用处：`ArgumentSyntax: Quote(d, club)`
- `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`；输入表达式：`Quote(d, current)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.PlayerContract = Quote(d, current)`
- `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；输入表达式：`RefreshOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshOffers(d);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "："`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`CircuitLedger.Remember(d, "commerce-transition", CareerEngine.Name(d) + "：" + correction, ["player"])`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.Remember(d, "commerce-transition", CareerEngine.Name(d) + "：" + correction, ["player"]);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).Where`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(d, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(d, post);`
- `NationalSpire.CommunityThreads.SetWork(NationalSpire.AiWorkState, string, string)`；输入表达式：`CommunityThreads.SetWork(post.NewsGeneration, "superseded")`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.SetWork(post.NewsGeneration, "superseded");`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, d.Esports.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, d.Esports.ClubId) is { } current`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, offer.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, offer.ClubId) is { } club`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.IsOwner(d)`
- `NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`；输入表达式：`SponsorIncome.Upgrade(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: SponsorIncome.Upgrade(d);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors.Any(s => s.TargetId == "player" && !s.Accepted)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Sponsors.Any(s => s.TargetId == "player" && !s.Accepted))          {              const string correction = "此前自动安排的品牌支持已经结束，已发放奖励保留。新的个人赞助由选手确认后生效。";              CircuitLedger.Remember(d, "commerce-transition", CareerEngine.Name(d) + "：" + correction, ["player"]);              // 结束事件使用升级当天的日期，避免把后来的合同状态写入早期记忆。              foreach (var post in CommunityThreads.All(d).Where(p => p.EventKey is "honor-sponsor-local" or "honor-sponsor-global"))              {                  if (post.AiPending)                  {                      post.AiPending = false;                      CommunityThreads.SetWork(post.NewsGeneration, "superseded");                      post.Title = "早期参赛支持";                      post.Body = $"{CareerEngine.Name(d)}此前获得的参赛支持已保留。新的个人赞助由选手自行选择。";                      post.SourceTitle = post.Title; post.SourceBody = post.Body;                      if (!post.Replies.Any(r => r.AuthorId == "player")) post.Replies.Clear();                      d.CommunityMemories.RemoveAll(m => m.PostId == post.Id);                      CommunityThreads.Remember(d, post); post.Revision++;                  }              }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Any(r => r.AuthorId == "player")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !post.Replies.Any(r => r.AuthorId == "player")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(d).Where(p => p.EventKey is "honor-sponsor-local" or "honor-sponsor-global")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(d).Where(p => p.EventKey is "honor-sponsor-local" or "honor-sponsor-global"))              {                  if (post.AiPending)                  {                      post.AiPending = false;                      CommunityThreads.SetWork(post.NewsGeneration, "superseded");                      post.Title = "早期参赛支持";                      post.Body = $"{CareerEngine.Name(d)}此前获得的参赛支持已保留。新的个人赞助由选手自行选择。";                      post.SourceTitle = post.Title; post.SourceBody = post.Body;                      if (!post.Replies.Any(r => r.AuthorId == "player")) post.Replies.Clear();                      d.CommunityMemories.RemoveAll(m => m.PostId == post.Id);                      CommunityThreads.Remember(d, post); post.Revision++;                  }              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Honors.Where(h => h.Id is "sponsor-local" or "sponsor-global")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var honor in d.Esports.Honors.Where(h => h.Id is "sponsor-local" or "sponsor-global"))          { honor.Title = "早期参赛支持"; honor.Detail = "此前获得的参赛支持已保留。个人赞助可在商业合作中自行选择。"; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors.Where(s => s.TargetId == "player" && !s.Accepted)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sponsor in d.Esports.Sponsors.Where(s => s.TargetId == "player" && !s.Accepted)) sponsor.EndedDay = d.Day;`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`post.Replies.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Clear();`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.CommunityMemories.RemoveAll(m => m.PostId == post.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.CommunityMemories.RemoveAll(m => m.PostId == post.Id);`

**赋值（含属性/字段和局部值）：**

- `d.Esports.ClubPaidSeason` = `d.Season`
- `d.Esports.CommerceVersion` = `Version`
- `d.Esports.PlayerContract` = `Quote(d, current)`
- `honor.Detail` = `"此前获得的参赛支持已保留。个人赞助可在商业合作中自行选择。"`
- `honor.Title` = `"早期参赛支持"`
- `post.AiPending` = `false`
- `post.Body` = `$"{CareerEngine.Name(d)}此前获得的参赛支持已保留。新的个人赞助由选手自行选择。"`
- `post.SourceBody` = `post.Body`
- `post.SourceTitle` = `post.Title`
- `post.Title` = `"早期参赛支持"`
- `sponsor.EndedDay` = `d.Day`

<a id="symbol-81a4731f8949"></a>

## `NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub) — public static ClubOffer Quote(CareerData d, CareerClub club)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.EsportsWorld.MakeOffers(NationalSpire.CareerData, bool)`](EsportsWorld.cs.md#symbol-6c986135b9e6)

**调用：** [`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)；[`NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`](CareerIncome.cs.md#symbol-9e5daaaeb774)；`NationalSpire.ClubOffer.ClubOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.ClubOffer.ExpiresDay`；`NationalSpire.ClubOffer.FanBonus`；`NationalSpire.ClubOffer.GoalReward`；`NationalSpire.ClubOffer.GoalWins`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.ClubOffer.SigningBonus`；`NationalSpire.ClubOffer.WinBonus`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`IdentityIndex(d, club.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = IdentityIndex(d, club.Id)`
- `NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`；输入表达式：`CareerIncome.Upgrade(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerIncome.Upgrade(offer);`
- `NationalSpire.ClubOffer.ClubOffer()`；输入表达式：`new ClubOffer { ClubId = club.Id, ExpiresDay = d.Day + 28, SigningBonus = signing,              SeasonPay = (kind switch { 0 => 2400, 1 => 1200, 2 => 1800, _ => 1000 }) * tier * 2,              WinBonus = (kind switch { 0 => 25, 1 => 30, 2 => 15, _ => 45 }) * tier * 2,              FanBonus = kind == 2 ? 30 : 0, GoalWins = kind == 0 ? 4 : kind == 3 ? 2 : 3,              GoalReward = (kind switch { 0 => 400, 1 => 330, 2 => 260, _ => 360 }) * tier * 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ClubOffer { ClubId = club.Id, ExpiresDay = d.Day + 28, SigningBonus = signing,              SeasonPay = (kind switch { 0 => 2400, 1 => 1200, 2 => 1800, _ => 1000 }) * tier * 2,              WinBonus = (kind switch { 0 => 25, 1 => 30, 2 => 15, _ => 45 }) * tier * 2,              FanBonus = kind == 2 ? 30 : 0, GoalWins = kind == 0 ? 4 : kind == 3 ? 2 : 3,              GoalReward = (kind switch { 0 => 400, 1 => 330, 2 => 260, _ => 360 }) * tier * 2 }`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Count(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind != "league")`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.CircuitAwards.Count(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind != "league")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, club.Budget / 5)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, club.Budget / 5)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(7, d.Esports.CircuitAwards.Count(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind != "league"))`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 + Math.Min(7, d.Esports.CircuitAwards.Count(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind != "league"))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(Math.Max(0, club.Budget / 5), (kind switch { 0 => 3000, 1 => 1400, 2 => 2400, _ => 1800 }) * tier * 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Math.Max(0, club.Budget / 5), (kind switch { 0 => 3000, 1 => 1400, 2 => 2400, _ => 1800 }) * tier * 2)`

**赋值（含属性/字段和局部值）：**

- `ClubId` = `club.Id`
- `ExpiresDay` = `d.Day + 28`
- `FanBonus` = `kind == 2 ? 30 : 0`
- `GoalReward` = `(kind switch { 0 => 400, 1 => 330, 2 => 260, _ => 360 }) * tier * 2`
- `GoalWins` = `kind == 0 ? 4 : kind == 3 ? 2 : 3`
- `SeasonPay` = `(kind switch { 0 => 2400, 1 => 1200, 2 => 1800, _ => 1000 }) * tier * 2`
- `SigningBonus` = `signing`
- `WinBonus` = `(kind switch { 0 => 25, 1 => 30, 2 => 15, _ => 45 }) * tier * 2`

<a id="symbol-a924f1bfbba3"></a>

## `NationalSpire.CareerCommerce.CopyTerms(NationalSpire.ClubOffer, NationalSpire.ClubOffer) — private static void CopyTerms(ClubOffer from, ClubOffer to)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ClubOffer.FanBonus`；`NationalSpire.ClubOffer.GoalReward`；`NationalSpire.ClubOffer.GoalWins`；`NationalSpire.ClubOffer.IncomeVersion`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.ClubOffer.SigningBonus`；`NationalSpire.ClubOffer.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `to.FanBonus` = `from.FanBonus`
- `to.GoalReward` = `from.GoalReward`
- `to.GoalWins` = `from.GoalWins`
- `to.IncomeVersion` = `from.IncomeVersion`
- `to.SeasonPay` = `from.SeasonPay`
- `to.SigningBonus` = `from.SigningBonus`
- `to.WinBonus` = `from.WinBonus`

<a id="symbol-3a2c86700d2c"></a>

## `NationalSpire.CareerCommerce.ClubTerms(NationalSpire.ClubOffer) — public static string ClubTerms(ClubOffer c)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.PrivatePublicContext.AppendPlayerContract(System.Text.StringBuilder, NationalSpire.CareerData)`](PrivateCareerContext.cs.md#symbol-8d6d43dee6a4)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.ClubOffer.FanBonus`；`NationalSpire.ClubOffer.GoalReward`；`NationalSpire.ClubOffer.GoalWins`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.ClubOffer.SigningBonus`；`NationalSpire.ClubOffer.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(c.GoalReward)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(c.GoalReward)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(c.SeasonPay)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(c.SeasonPay)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(c.SigningBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(c.SigningBonus)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(c.WinBonus)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(c.WinBonus)}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aeb7e7ee6d76"></a>

## `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData) — public static SponsorContract? ActiveSponsor(CareerData d)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.PrivatePublicContext.AppendPlayerProfile(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson?, System.Collections.Generic.HashSet<string>, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-8909708d3f8d)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.StartSeason`；`NationalSpire.SponsorContract.TargetId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors.LastOrDefault(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Sponsors.LastOrDefault(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3523341b8f0b"></a>

## `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData) — public static void RefreshOffers(CareerData d)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-bc24477e89ba)；[`NationalSpire.EsportsWorld.AfterPlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool)`](EsportsWorld.cs.md#symbol-c0b4fbf0a978)

**调用：** [`NationalSpire.CareerAudience.Quote(int, int)`](CareerAudience.cs.md#symbol-b5169ddb9dda)；[`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-aeb7e7ee6d76)；[`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerIncome.Upgrade(NationalSpire.CareerData)`](CareerIncome.cs.md#symbol-f4fa17ce6d3d)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；[`NationalSpire.RegionalOrganizations.SponsorDescription(string)`](RegionalOrganizations.cs.md#symbol-421e3c666278)；[`NationalSpire.RegionalOrganizations.Sponsors(string, int)`](RegionalOrganizations.cs.md#symbol-f76b5db64641)；[`NationalSpire.RegionalOrganizations.SponsorSlogan(string)`](RegionalOrganizations.cs.md#symbol-473ef110259c)；[`NationalSpire.SponsorIncome.PersonalBase(string, int)`](SponsorIncome.cs.md#symbol-1eb1e1e5420e)；[`NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`](SponsorIncome.cs.md#symbol-9f0fa3e89b54)；[`NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`](SponsorIncome.cs.md#symbol-efb9102304ba)；`NationalSpire.SponsorContract.SponsorContract()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `(int Retainer, int Win).Retainer`；`(int Retainer, int Win).Win`；`NationalSpire.CareerAudience.Quote(int, int)`；`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.Brands`；`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerIncome.Upgrade(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.SponsorOffers`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.RegionalOrganizations.SponsorDescription(string)`；`NationalSpire.RegionalOrganizations.Sponsors(string, int)`；`NationalSpire.RegionalOrganizations.SponsorSlogan(string)`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.BaseRetainer`；`NationalSpire.SponsorContract.BaseWinBonus`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.Description`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.ExpiresDay`；`NationalSpire.SponsorContract.FanBonus`；`NationalSpire.SponsorContract.Id`；`NationalSpire.SponsorContract.NextOffer`；`NationalSpire.SponsorContract.PaidSeason`；`NationalSpire.SponsorContract.Plan`；`NationalSpire.SponsorContract.Retainer`；`NationalSpire.SponsorContract.SignedDay`；`NationalSpire.SponsorContract.Slogan`；`NationalSpire.SponsorContract.StartSeason`；`NationalSpire.SponsorContract.TargetId`；`NationalSpire.SponsorContract.WinBonus`；`NationalSpire.SponsorIncome.PersonalBase(string, int)`；`NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`；`NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.Quote(int, int)`；输入表达式：`CareerAudience.Quote(basis.Retainer, d.Fans)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Retainer = CareerAudience.Quote(basis.Retainer, d.Fans)`
- `NationalSpire.CareerAudience.Quote(int, int)`；输入表达式：`CareerAudience.Quote(basis.Win, d.Fans)`；返回值紧邻使用处：`AssignmentExpressionSyntax: WinBonus = CareerAudience.Quote(basis.Win, d.Fans)`
- `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；输入表达式：`ActiveSponsor(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActiveSponsor(d)`
- `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；输入表达式：`Capture(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(d);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "更新个人赞助"`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":brand:" + plan + ":" + d.Season)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + ":brand:" + plan + ":" + d.Season)`
- `NationalSpire.CareerIncome.Upgrade(NationalSpire.CareerData)`；输入表达式：`CareerIncome.Upgrade(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerIncome.Upgrade(d);`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "sponsor-renew-" + next.Id, "赞助", CareerEngine.Name(d) + "更新个人赞助",                      $"{next.Brand}的{next.Plan}方案已生效，收入随关注数变化。", ["player"])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "sponsor-renew-" + next.Id, "赞助", CareerEngine.Name(d) + "更新个人赞助",                      $"{next.Brand}的{next.Plan}方案已生效，收入随关注数变化。", ["player"]);`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`CircuitLedger.Remember(d, $"sponsor-invitations-{d.Season}-{d.Day}", $"{CareerEngine.Name(d)}收到三份个人赞助邀请，等待本人选择确认。", ["player"])`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.Remember(d, $"sponsor-invitations-{d.Season}-{d.Day}", $"{CareerEngine.Name(d)}收到三份个人赞助邀请，等待本人选择确认。", ["player"]);`
- `NationalSpire.RegionalOrganizations.SponsorDescription(string)`；输入表达式：`RegionalOrganizations.SponsorDescription(brand)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Description = RegionalOrganizations.SponsorDescription(brand)`
- `NationalSpire.RegionalOrganizations.Sponsors(string, int)`；输入表达式：`RegionalOrganizations.Sponsors(w.Country, plan)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RegionalOrganizations.Sponsors(w.Country, plan)`
- `NationalSpire.RegionalOrganizations.SponsorSlogan(string)`；输入表达式：`RegionalOrganizations.SponsorSlogan(brand)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Slogan = RegionalOrganizations.SponsorSlogan(brand)`
- `NationalSpire.SponsorContract.SponsorContract()`；输入表达式：`new() { Id = $"player-{startSeason}-{d.Day}-{plan}", TargetId = "player", Brand = brand,                  Plan = name, StartSeason = startSeason, EndSeason = startSeason + 1,                  ExpiresDay = d.Day + 28, BaseRetainer = basis.Retainer, BaseWinBonus = basis.Win,                  Retainer = CareerAudience.Quote(basis.Retainer, d.Fans), WinBonus = CareerAudience.Quote(basis.Win, d.Fans), FanBonus = plan == 2 ? 35 * tier : 0,                  Description = RegionalOrganizations.SponsorDescription(brand), Slogan = RegionalOrganizations.SponsorSlogan(brand) }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = $"player-{startSeason}-{d.Day}-{plan}", TargetId = "player", Brand = brand,                  Plan = name, StartSeason = startSeason, EndSeason = startSeason + 1,                  ExpiresDay = d.Day + 28, BaseRetainer = basis.Retainer, BaseWinBonus = basis.Win,                  Retainer = CareerAudience.Quote(basis.Retainer, d.Fans), WinBonus = CareerAudience.Quote(basis.Win, d.Fans), FanBonus = plan == 2 ? 35 * tier : 0,                  Description = RegionalOrganizations.SponsorDescription(brand), Slogan = RegionalOrganizations.SponsorSlogan(brand) }`
- `NationalSpire.SponsorIncome.PersonalBase(string, int)`；输入表达式：`SponsorIncome.PersonalBase(name, tier)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SponsorIncome.PersonalBase(name, tier)`
- `NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`；输入表达式：`SponsorIncome.PersonalTier(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SponsorIncome.PersonalTier(d)`
- `NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`；输入表达式：`SponsorIncome.Upgrade(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: SponsorIncome.Upgrade(d);`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Brands[plan].Contains(previous.Brand)`；返回值紧邻使用处：`BinaryExpressionSyntax: regional.Contains(previous.Brand) || Brands[plan].Contains(previous.Brand)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`regional.Contains(previous.Brand)`；返回值紧邻使用处：`BinaryExpressionSyntax: regional.Contains(previous.Brand) || Brands[plan].Contains(previous.Brand)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Sponsors.LastOrDefault(s => s.TargetId == "player" && s.Accepted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = w.Sponsors.LastOrDefault(s => s.TargetId == "player" && s.Accepted)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`w.Sponsors.Where(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.EndSeason < d.Season).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var contract in w.Sponsors.Where(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.EndSeason < d.Season).ToArray())          {              if (contract.NextOffer is { } next)              {                  contract.EndedDay = d.Day; contract.NextOffer = null;                  next.StartSeason = d.Season; next.EndSeason = d.Season + 1; next.Accepted = true; next.SignedDay = d.Day;                  next.PaidSeason = d.Season - 1; w.Sponsors.Add(next);                  CareerLife.AddEvent(d, "sponsor-renew-" + next.Id, "赞助", CareerEngine.Name(d) + "更新个人赞助",                      $"{next.Brand}的{next.Plan}方案已生效，收入随关注数变化。", ["player"]);              }              else              {                  while (contract.EndSeason < d.Season) contract.EndSeason += 2;              }              w.SponsorOffers.Clear();          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Sponsors.Where(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.EndSeason < d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: w.Sponsors.Where(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.EndSeason < d.Season).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`w.SponsorOffers.Add(new() { Id = $"player-{startSeason}-{d.Day}-{plan}", TargetId = "player", Brand = brand,                  Plan = name, StartSeason = startSeason, EndSeason = startSeason + 1,                  ExpiresDay = d.Day + 28, BaseRetainer = basis.Retainer, BaseWinBonus = basis.Win,                  Retainer = CareerAudience.Quote(basis.Retainer, d.Fans), WinBonus = CareerAudience.Quote(basis.Win, d.Fans), FanBonus = plan == 2 ? 35 * tier : 0,                  Description = RegionalOrganizations.SponsorDescription(brand), Slogan = RegionalOrganizations.SponsorSlogan(brand) })`；返回值紧邻使用处：`ExpressionStatementSyntax: w.SponsorOffers.Add(new() { Id = $"player-{startSeason}-{d.Day}-{plan}", TargetId = "player", Brand = brand,                  Plan = name, StartSeason = startSeason, EndSeason = startSeason + 1,                  ExpiresDay = d.Day + 28, BaseRetainer = basis.Retainer, BaseWinBonus = basis.Win,                  Retainer = CareerAudience.Quote(basis.Retainer, d.Fans), WinBonus = CareerAudience.Quote(basis.Win, d.Fans), FanBonus = plan == 2 ? 35 * tier : 0,                  Description = RegionalOrganizations.SponsorDescription(brand), Slogan = RegionalOrganizations.SponsorSlogan(brand) });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`w.Sponsors.Add(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: w.Sponsors.Add(next);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`w.SponsorOffers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: w.SponsorOffers.Clear();`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`w.SponsorOffers.RemoveAll(s => s.ExpiresDay < d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: w.SponsorOffers.RemoveAll(s => s.ExpiresDay < d.Day);`

**赋值（含属性/字段和局部值）：**

- `BaseRetainer` = `basis.Retainer`
- `BaseWinBonus` = `basis.Win`
- `Brand` = `brand`
- `contract.EndedDay` = `d.Day`
- `contract.EndSeason` += `2`
- `contract.NextOffer` = `null`
- `Description` = `RegionalOrganizations.SponsorDescription(brand)`
- `EndSeason` = `startSeason + 1`
- `ExpiresDay` = `d.Day + 28`
- `FanBonus` = `plan == 2 ? 35 * tier : 0`
- `Id` = `$"player-{startSeason}-{d.Day}-{plan}"`
- `next.Accepted` = `true`
- `next.EndSeason` = `d.Season + 1`
- `next.PaidSeason` = `d.Season - 1`
- `next.SignedDay` = `d.Day`
- `next.StartSeason` = `d.Season`
- `Plan` = `name`
- `Retainer` = `CareerAudience.Quote(basis.Retainer, d.Fans)`
- `Slogan` = `RegionalOrganizations.SponsorSlogan(brand)`
- `StartSeason` = `startSeason`
- `TargetId` = `"player"`
- `WinBonus` = `CareerAudience.Quote(basis.Win, d.Fans)`

<a id="symbol-3ed7cf5a8f49"></a>

## `NationalSpire.CareerCommerce.SponsorTerms(NationalSpire.CareerData, NationalSpire.SponsorContract) — public static string SponsorTerms(CareerData d, SponsorContract c)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；[`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d4ed607773ea)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.FanBonus`；`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(SponsorIncome.Retainer(d, c))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(SponsorIncome.Retainer(d, c))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(SponsorIncome.WinBonus(d, c))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(SponsorIncome.WinBonus(d, c))}`
- `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Retainer(d, c)`；返回值紧邻使用处：`ArgumentSyntax: SponsorIncome.Retainer(d, c)`
- `NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.WinBonus(d, c)`；返回值紧邻使用处：`ArgumentSyntax: SponsorIncome.WinBonus(d, c)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dde63e77bf01"></a>

## `NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract) — public static string? AcceptSponsor(CareerData d, SponsorContract offer)`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-aeb7e7ee6d76)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.SponsorTerms(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-3ed7cf5a8f49)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d66156cc1ea9)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；`NationalSpire.CareerHonor.CareerHonor()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.SponsorTerms(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerHonor.Day`；`NationalSpire.CareerHonor.Detail`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerHonor.Season`；`NationalSpire.CareerHonor.Title`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.Milestones`；`NationalSpire.EsportsCareer.SponsorOffers`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.ExpiresDay`；`NationalSpire.SponsorContract.Id`；`NationalSpire.SponsorContract.NextOffer`；`NationalSpire.SponsorContract.PaidSeason`；`NationalSpire.SponsorContract.SignedDay`；`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；输入表达式：`ActiveSponsor(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ActiveSponsor(d) is { } active`
- `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；输入表达式：`RefreshOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshOffers(d);`
- `NationalSpire.CareerCommerce.SponsorTerms(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorTerms(d, offer)`；返回值紧邻使用处：`InterpolationSyntax: {SponsorTerms(d, offer)}`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "与"`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerHonor.CareerHonor()`；输入表达式：`new() { Id = "sponsor-confirmed", Title = "首份个人赞助", Detail = fact, Day = d.Day, Season = d.Season }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = "sponsor-confirmed", Title = "首份个人赞助", Detail = fact, Day = d.Day, Season = d.Season }`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "sponsor-confirmed-" + offer.Id, "赞助", CareerEngine.Name(d) + "与" + offer.Brand + "达成合作", fact, ["player"], true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "sponsor-confirmed-" + offer.Id, "赞助", CareerEngine.Name(d) + "与" + offer.Brand + "达成合作", fact, ["player"], true);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "个人赞助签约支持", payment)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "个人赞助签约支持", payment);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Initialize(d, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: SponsorIncome.Initialize(d, offer);`
- `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Retainer(d, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SponsorIncome.Retainer(d, offer)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Honors.Add(new() { Id = "sponsor-confirmed", Title = "首份个人赞助", Detail = fact, Day = d.Day, Season = d.Season })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Honors.Add(new() { Id = "sponsor-confirmed", Title = "首份个人赞助", Detail = fact, Day = d.Day, Season = d.Season });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Milestones.Add("sponsor-confirmed")`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Milestones.Add("sponsor-confirmed");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Sponsors.Add(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Sponsors.Add(offer);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`d.Esports.SponsorOffers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.SponsorOffers.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.Esports.Milestones.Contains("sponsor-confirmed")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.Milestones.Contains("sponsor-confirmed")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.Esports.SponsorOffers.Contains(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.SponsorOffers.Contains(offer)`

**赋值（含属性/字段和局部值）：**

- `active.NextOffer` = `offer`
- `d.Credits` += `payment`
- `Day` = `d.Day`
- `Detail` = `fact`
- `Id` = `"sponsor-confirmed"`
- `offer.Accepted` = `true`
- `offer.PaidSeason` = `d.Season`
- `offer.SignedDay` = `d.Day`
- `Season` = `d.Season`
- `Title` = `"首份个人赞助"`

<a id="symbol-4e9fe3d551a9"></a>

## `NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer) — public static void SignedClub(CareerData d, ClubOffer offer)`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)

**调用：** [`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`](CareerCommerce.cs.md#symbol-d9f436df636e)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.ClubOffer.SigningBonus`；`NationalSpire.EsportsCareer.ClubPaidSeason`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；输入表达式：`Capture(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(d);`
- `NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；输入表达式：`Spend(d, club, offer.SigningBonus + pay)`；返回值紧邻使用处：`ExpressionStatementSyntax: Spend(d, club, offer.SigningBonus + pay);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "俱乐部签约与本季报酬", offer.SigningBonus + pay)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "俱乐部签约与本季报酬", offer.SigningBonus + pay);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, offer.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, offer.ClubId) is { } club`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `pay`
- `d.Esports.ClubPaidSeason` = `d.Season`
- `d.Esports.PlayerContract` = `offer`

<a id="symbol-9f53c8b6cc20"></a>

## `NationalSpire.CareerCommerce.ClubWins(NationalSpire.CareerData, string) — public static int ClubWins(CareerData d, string club)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Count(f => f.Finished && f.WinnerId == "player" && c.EntrantClubs.GetValueOrDefault("player") == club)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.Count(f => f.Finished && f.WinnerId == "player" && c.EntrantClubs.GetValueOrDefault("player") == club)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind is "league" or "continental")          .Sum(c => c.Fixtures.Count(f => f.Finished && f.WinnerId == "player" && c.EntrantClubs.GetValueOrDefault("player") == club))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind is "league" or "continental")          .Sum(c => c.Fixtures.Count(f => f.Finished && f.WinnerId == "player" && c.EntrantClubs.GetValueOrDefault("player") == club))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind is "league" or "continental")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind is "league" or "continental")          .Sum`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.EntrantClubs.GetValueOrDefault("player")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.EntrantClubs.GetValueOrDefault("player") == club`

**赋值（含属性/字段和局部值）：**


<a id="symbol-61ee1540f58f"></a>

## `NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch) — public static void PlayerMatch(CareerData d, CareerMatch match)`

来源：源码第 161 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitLedger.cs.md#symbol-dd115cb81ebf)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)

**调用：** [`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-aeb7e7ee6d76)；[`NationalSpire.CareerCommerce.ClubWins(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-9f53c8b6cc20)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`](CareerCommerce.cs.md#symbol-d9f436df636e)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d4ed607773ea)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.ClubWins(NationalSpire.CareerData, string)`；`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.ClubOffer.FanBonus`；`NationalSpire.ClubOffer.GoalReward`；`NationalSpire.ClubOffer.GoalWins`；`NationalSpire.ClubOffer.WinBonus`；`NationalSpire.EsportsCareer.ClubGoalSeason`；`NationalSpire.EsportsCareer.CommercialPaidMatches`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.SponsorContract.FanBonus`；`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；输入表达式：`ActiveSponsor(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ActiveSponsor(d) is { } sponsor`
- `NationalSpire.CareerCommerce.ClubWins(NationalSpire.CareerData, string)`；输入表达式：`ClubWins(d, contract.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubWins(d, contract.ClubId) >= contract.GoalWins`
- `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；输入表达式：`RefreshOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshOffers(d);`
- `NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；输入表达式：`Spend(d, club, contract.WinBonus + goal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Spend(d, club, contract.WinBonus + goal);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(goal)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(goal)}`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`CircuitLedger.Remember(d, "club-goal-" + d.Season, $"{CareerEngine.Name(d)}完成{EsportsWorld.ClubName(d, contract.ClubId)}本季{contract.GoalWins}胜目标，获得额外奖励{CareerMoney.Format(goal)}。", ["player"])`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.Remember(d, "club-goal-" + d.Season, $"{CareerEngine.Name(d)}完成{EsportsWorld.ClubName(d, contract.ClubId)}本季{contract.GoalWins}胜目标，获得额外奖励{CareerMoney.Format(goal)}。", ["player"]);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, contract.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, contract.ClubId) is { } club`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, contract.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d, contract.ClubId)}`
- `NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.WinBonus(d, sponsor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Credits += SponsorIncome.WinBonus(d, sponsor)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`competition.EntrantClubs.GetValueOrDefault("player")`；返回值紧邻使用处：`BinaryExpressionSyntax: competition.EntrantClubs.GetValueOrDefault("player") != contract.ClubId`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.CommercialPaidMatches.Add(match.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.CommercialPaidMatches.Add(match.Id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.Esports.CommercialPaidMatches.Contains(match.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !match.PlayerWon || d.Esports.CommercialPaidMatches.Contains(match.Id)`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`d.Esports.CommercialPaidMatches.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.CommercialPaidMatches.RemoveAt(0);`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `contract.WinBonus`
- `d.Credits` += `goal`
- `d.Credits` += `SponsorIncome.WinBonus(d, sponsor)`
- `d.Esports.ClubGoalSeason` = `d.Season`
- `d.Fans` += `contract.FanBonus`
- `d.Fans` += `sponsor.FanBonus`
- `goal` = `contract.GoalReward`

<a id="symbol-f162ea564744"></a>

## `NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData) — public static void SeasonStart(CareerData d)`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-bc24477e89ba)

**调用：** [`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-aeb7e7ee6d76)；[`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`](CareerCommerce.cs.md#symbol-d9f436df636e)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.ClubOffer.ClubId`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.EsportsCareer.ClubPaidSeason`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.PaidSeason`；`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；输入表达式：`ActiveSponsor(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ActiveSponsor(d) is { } sponsor`
- `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；输入表达式：`Capture(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(d);`
- `NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`；输入表达式：`RefreshOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshOffers(d);`
- `NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int)`；输入表达式：`Spend(d, club, contract.SeasonPay)`；返回值紧邻使用处：`ExpressionStatementSyntax: Spend(d, club, contract.SeasonPay);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "新赛季合同与赞助收入", d.Credits - before)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "新赛季合同与赞助收入", d.Credits - before);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, contract.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, contract.ClubId) is { } club`
- `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Retainer(d, sponsor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Credits += SponsorIncome.Retainer(d, sponsor)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.Sponsors.RemoveAll(s => s.EndSeason < d.Season - 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Sponsors.RemoveAll(s => s.EndSeason < d.Season - 4);`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `contract.SeasonPay`
- `d.Credits` += `SponsorIncome.Retainer(d, sponsor)`
- `d.Esports.ClubPaidSeason` = `d.Season`
- `sponsor.PaidSeason` = `d.Season`

<a id="symbol-42a4cc11a866"></a>

## `NationalSpire.CareerCommerce.TrainingInvestment(int, int) — public static int TrainingInvestment(int amount, int scale)`

来源：源码第 193 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)

**调用：** `System.Math.Log(double)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Log(double)`；输入表达式：`Math.Log(amount / (double)scale)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 + Math.Log(amount / (double)scale)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(scale * (1 + Math.Log(amount / (double)scale)))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(scale * (1 + Math.Log(amount / (double)scale)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a91e3e6065a8"></a>

## `NationalSpire.CareerCommerce.Develop(NationalSpire.CareerPerson, int, string, double) — public static int Develop(CareerPerson person, int investment, string seed, double pace = 1)`

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`](CareerLife.cs.md#symbol-1479dc400873)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`System.Math.Floor(double)`；`System.Math.Log(double)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.RatingGrowthRemainder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(seed + person.Id) % 10001`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(amount)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Floor(amount)`
- `System.Math.Log(double)`；输入表达式：`Math.Log(1 + investment / 420.0)`；返回值紧邻使用处：`BinaryExpressionSyntax: 12 * Math.Log(1 + investment / 420.0)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, person.Rating - (620 + person.MaxAscension * 95))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, person.Rating - (620 + person.MaxAscension * 95)) / 180.0`

**赋值（含属性/字段和局部值）：**

- `person.Rating` = `checked(person.Rating + gain)`
- `person.RatingGrowthRemainder` = `amount - gain`

<a id="symbol-b028852b9e6d"></a>

## `NationalSpire.CareerCommerce.Operate(NationalSpire.CareerData) — public static void Operate(CareerData d)`

来源：源码第 207 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-d77bf6cf914a)

**调用：** [`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)

**字段、属性、事件及方法组引用：** `NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`；输入表达式：`ClubOperations.Advance(d)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ClubOperations.Advance(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-02ba08b48a24"></a>

## `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData) — public static void Capture(CareerData d)`

来源：源码第 208 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer)`](CareerCommerce.cs.md#symbol-4e9fe3d551a9)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)

**调用：** [`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-aeb7e7ee6d76)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；[`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d4ed607773ea)；`NationalSpire.CommercialSnapshot.CommercialSnapshot()`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CommercialSnapshot.Day`；`NationalSpire.CommercialSnapshot.Summary`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.CommercialHistory`；`NationalSpire.EsportsCareer.SponsorOffers`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.FanBonus`；`NationalSpire.SponsorContract.StartSeason`；`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；输入表达式：`ActiveSponsor(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActiveSponsor(d)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(SponsorIncome.Retainer(d, sponsor))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(SponsorIncome.Retainer(d, sponsor))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(SponsorIncome.WinBonus(d, sponsor))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(SponsorIncome.WinBonus(d, sponsor))}`
- `NationalSpire.CommercialSnapshot.CommercialSnapshot()`；输入表达式：`new() { Day = d.Day, Summary = summary }`；返回值紧邻使用处：`ArgumentSyntax: new() { Day = d.Day, Summary = summary }`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "效力" + EsportsWorld.ClubName(d, d.Esports.ClubId)`
- `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Retainer(d, sponsor)`；返回值紧邻使用处：`ArgumentSyntax: SponsorIncome.Retainer(d, sponsor)`
- `NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.WinBonus(d, sponsor)`；返回值紧邻使用处：`ArgumentSyntax: SponsorIncome.WinBonus(d, sponsor)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('、', d.Esports.SponsorOffers.Take(3).Select(s => s.Brand))`；返回值紧邻使用处：`BinaryExpressionSyntax: "；待确认邀请：" + string.Join('、', d.Esports.SponsorOffers.Take(3).Select(s => s.Brand))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`history.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: history.LastOrDefault()?.Day`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`history.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: history.LastOrDefault()?.Summary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Esports.SponsorOffers.Take(3).Select(s => s.Brand)`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.SponsorOffers.Take(3).Select(s => s.Brand)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Esports.SponsorOffers.Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.SponsorOffers.Take(3).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`history.Add(new() { Day = d.Day, Summary = summary })`；返回值紧邻使用处：`ExpressionStatementSyntax: history.Add(new() { Day = d.Day, Summary = summary });`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`history.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: history.RemoveAt(0);`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`history.RemoveAt(history.Count - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: history.RemoveAt(history.Count - 1);`

**赋值（含属性/字段和局部值）：**

- `Day` = `d.Day`
- `Summary` = `summary`

<a id="symbol-01673c83d2ed"></a>

## `NationalSpire.CareerCommerce.PublicState(NationalSpire.CareerData, int) — public static string PublicState(CareerData d, int day)`

来源：源码第 220 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.PlayerPublicRecord(NationalSpire.CareerData, int, bool)`](AiContext.cs.md#symbol-99772c8e0814)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CommercialSnapshot.Day`；`NationalSpire.CommercialSnapshot.Summary`；`NationalSpire.EsportsCareer.CommercialHistory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CommercialHistory.LastOrDefault(s => s.Day <= day)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.CommercialHistory.LastOrDefault(s => s.Day <= day)?.Summary`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9f436df636e"></a>

## `NationalSpire.CareerCommerce.Spend(NationalSpire.CareerData, NationalSpire.CareerClub, int) — private static void Spend(CareerData d, CareerClub club, int amount)`

来源：源码第 221 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerCommerce.SignedClub(NationalSpire.CareerData, NationalSpire.ClubOffer)`](CareerCommerce.cs.md#symbol-4e9fe3d551a9)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`](ClubOperations.cs.md#symbol-a68dccdac5af)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.SeasonReport`；`NationalSpire.CareerClub.TrainingFund`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(amount - available)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(amount - available)}`
- `NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；输入表达式：`ClubOperations.Entry(club, d.Day, "股东补充合同资金", amount - available)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Entry(club, d.Day, "股东补充合同资金", amount - available);`
- `NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；输入表达式：`ClubOperations.Entry(club, d.Day, "履行选手合同", -amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Entry(club, d.Day, "履行选手合同", -amount);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, club.Budget - club.TrainingFund)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, club.Budget - club.TrainingFund)`

**赋值（含属性/字段和局部值）：**

- `club.Budget` -= `amount`
- `club.Budget` += `amount - available`
- `club.SeasonReport` += `$" 股东补充{CareerMoney.Format(amount - available)}，履行选手合同。"`
