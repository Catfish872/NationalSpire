# CharacterCards.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5BA9296E11FA8830E0A602FBE888A498736B27209025EE23210D047A5C921AA5`。来源：[源码](../../CharacterCards.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CharacterCardEdit`、`NationalSpire.CharacterCards`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Templates = ["普通玩家", "主播", "解说员", "青训选手", "职业选手", "世界顶尖", "教练", "赛事记者"];
```

<a id="symbol-626aebda9aeb"></a>

## `NationalSpire.CharacterCardEdit.Create — public bool Create`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-77fd15e2be0a"></a>

## `NationalSpire.CharacterCardEdit.Target — public string Target`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ac6bc0da4e0b"></a>

## `NationalSpire.CharacterCardEdit.Person — public CareerPerson Person`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.CareerPerson.CareerPerson()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3c3ff9c389dd"></a>

## `NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string) — public static CareerPerson Read(CareerData data, string id)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-9a2f255d8204)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)；[`NationalSpire.CoachLineups.Candidates(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-17ae59ab26cf)；[`NationalSpire.CoachLineups.Person(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-559e961ef669)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CharacterIdentity.OriginalName(string)`](CharacterIdentity.cs.md#symbol-94292e3754dd)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityLibrary.cs.md#symbol-902b2bd837d2)；`NationalSpire.CareerPerson.CareerPerson()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Losses`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerData.Rating`；`NationalSpire.CareerData.SelectedAvatar`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CharacterCards.Templates`；`NationalSpire.CharacterIdentity.OriginalName(string)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Handle = CareerEngine.Name(data)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, id) ?? throw new InvalidDataException("人物已不存在。")`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Role = "参赛选手", Character = CharacterIdentity.OriginalName(data.SelectedCharacter) ?? (data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "铁甲战士"), Style = "", Id = "player" }`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.PlayerCard == null ? new CareerPerson { Role = "参赛选手", Character = CharacterIdentity.OriginalName(data.SelectedCharacter) ?? (data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "铁甲战士"), Style = "", Id = "player" } : CoopJson.Copy(data.PlayerCard)`
- `NationalSpire.CharacterIdentity.OriginalName(string)`；输入表达式：`CharacterIdentity.OriginalName(data.SelectedCharacter)`；返回值紧邻使用处：`BinaryExpressionSyntax: CharacterIdentity.OriginalName(data.SelectedCharacter) ?? (data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "铁甲战士")`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(CareerEngine.Person(data, id) ?? throw new InvalidDataException("人物已不存在。"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(CareerEngine.Person(data, id) ?? throw new InvalidDataException("人物已不存在。"))`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(data.PlayerCard)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.PlayerCard == null ? new CareerPerson { Role = "参赛选手", Character = CharacterIdentity.OriginalName(data.SelectedCharacter) ?? (data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "铁甲战士"), Style = "", Id = "player" } : CoopJson.Copy(data.PlayerCard)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(data.SelectedAvatar)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Avatar = CoopJson.Copy(data.SelectedAvatar)`
- `NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PersonalityLibrary.Ensure(data, p)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.Ensure(data, p);`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Templates.Contains(npc.Role)`；返回值紧邻使用处：`BinaryExpressionSyntax: npc.AbilityTemplate.Length == 0 && Templates.Contains(npc.Role)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.PlayerNameAliases.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.HandleAliases = data.PlayerNameAliases.ToList()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("人物已不存在。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("人物已不存在。")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, data.Esports.BestClear)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.MaxAscension = Math.Max(0, data.Esports.BestClear)`

**赋值（含属性/字段和局部值）：**

- `Character` = `CharacterIdentity.OriginalName(data.SelectedCharacter) ?? (data.SelectedCharacter.Length > 0 ? data.SelectedCharacter : "铁甲战士")`
- `Id` = `"player"`
- `npc.AbilityTemplate` = `npc.Role`
- `p.Avatar` = `CoopJson.Copy(data.SelectedAvatar)`
- `p.ClubId` = `data.Esports.ClubId`
- `p.Country` = `data.Esports.Country`
- `p.Gender` = `data.PlayerGender`
- `p.Handle` = `CareerEngine.Name(data)`
- `p.HandleAliases` = `data.PlayerNameAliases.ToList()`
- `p.Id` = `"player"`
- `p.Losses` = `data.Losses`
- `p.MaxAscension` = `Math.Max(0, data.Esports.BestClear)`
- `p.Rating` = `data.Rating`
- `p.Wins` = `data.Wins`
- `Role` = `"参赛选手"`
- `Style` = `""`

<a id="symbol-3514413c59e6"></a>

## `NationalSpire.CharacterCards.New(NationalSpire.CareerData) — public static CareerPerson New(CareerData data)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string)`](CharacterCards.cs.md#symbol-8233ca321672)；[`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityLibrary.cs.md#symbol-902b2bd837d2)；`NationalSpire.CareerPerson.CareerPerson()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = "custom-" + Guid.NewGuid().ToString("N"), Country = data.Esports.Country,             Gender = "男", Character = "铁甲战士", Style = "偏爱大卡组，选牌积极。" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerPerson { Id = "custom-" + Guid.NewGuid().ToString("N"), Country = data.Esports.Country,             Gender = "男", Character = "铁甲战士", Style = "偏爱大卡组，选牌积极。" }`
- `NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string)`；输入表达式：`ApplyTemplate(p, "普通玩家")`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyTemplate(p, "普通玩家");`
- `NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PersonalityLibrary.Ensure(data, p)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.Ensure(data, p);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "custom-" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `Character` = `"铁甲战士"`
- `Country` = `data.Esports.Country`
- `Gender` = `"男"`
- `Id` = `"custom-" + Guid.NewGuid().ToString("N")`
- `Style` = `"偏爱大卡组，选牌积极。"`

<a id="symbol-8233ca321672"></a>

## `NationalSpire.CharacterCards.ApplyTemplate(NationalSpire.CareerPerson, string) — public static void ApplyTemplate(CareerPerson p, string name)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CharacterCards.New(NationalSpire.CareerData)`](CharacterCards.cs.md#symbol-3514413c59e6)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CharacterCards.Templates`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Templates.Contains(name)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Templates.Contains(name)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("角色模板无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("角色模板无效。");`

**赋值（含属性/字段和局部值）：**

- `(p.MaxAscension, p.Rating, p.Wins, p.Losses)` = `name switch         {             "世界顶尖" => (9, 1660, 90, 270), "职业选手" => (8, 1390, 38, 152),             "青训选手" => (6, 1110, 15, 110), "主播" => (5, 1090, 18, 142),             "解说员" or "教练" => (6, 1170, 27, 153), _ => (2, 830, 6, 74)         }`
- `p.AbilityTemplate` = `name`
- `p.CustomClearChance` = `null`
- `p.Role` = `name`

<a id="symbol-50bfe43feae0"></a>

## `NationalSpire.CharacterCards.Decode(string) — public static CharacterCardEdit Decode(string json)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** `System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("角色卡为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("角色卡为空。")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<CharacterCardEdit>(json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<CharacterCardEdit>(json) ?? throw new InvalidDataException("角色卡为空。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-567fa6811160"></a>

## `NationalSpire.CharacterCards.Encode(NationalSpire.CharacterCardEdit) — public static string Encode(CharacterCardEdit edit)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** `NationalSpire.CareerPerson.CareerPerson()`；`NationalSpire.CharacterCardEdit.CharacterCardEdit()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.Coop.CoopJson.Options`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new()         {             Handle = source.Handle, Name = source.Name, Gender = source.Gender, Country = source.Country,             ClubId = source.ClubId, SupportedClubId = source.SupportedClubId, Role = source.Role,             AbilityTemplate = source.AbilityTemplate, Character = source.Character, MaxAscension = source.MaxAscension,             Rating = source.Rating, Wins = source.Wins, Losses = source.Losses, CustomClearChance = source.CustomClearChance,             Style = source.Style, Temperament = source.Temperament, Voice = source.Voice, Biography = source.Biography,             Personality = source.Personality, Avatar = source.Avatar         }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Person = new()         {             Handle = source.Handle, Name = source.Name, Gender = source.Gender, Country = source.Country,             ClubId = source.ClubId, SupportedClubId = source.SupportedClubId, Role = source.Role,             AbilityTemplate = source.AbilityTemplate, Character = source.Character, MaxAscension = source.MaxAscension,             Rating = source.Rating, Wins = source.Wins, Losses = source.Losses, CustomClearChance = source.CustomClearChance,             Style = source.Style, Temperament = source.Temperament, Voice = source.Voice, Biography = source.Biography,             Personality = source.Personality, Avatar = source.Avatar         }`
- `NationalSpire.CharacterCardEdit.CharacterCardEdit()`；输入表达式：`new CharacterCardEdit { Target = edit.Target, Create = edit.Create, Person = new()         {             Handle = source.Handle, Name = source.Name, Gender = source.Gender, Country = source.Country,             ClubId = source.ClubId, SupportedClubId = source.SupportedClubId, Role = source.Role,             AbilityTemplate = source.AbilityTemplate, Character = source.Character, MaxAscension = source.MaxAscension,             Rating = source.Rating, Wins = source.Wins, Losses = source.Losses, CustomClearChance = source.CustomClearChance,             Style = source.Style, Temperament = source.Temperament, Voice = source.Voice, Biography = source.Biography,             Personality = source.Personality, Avatar = source.Avatar         } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CharacterCardEdit { Target = edit.Target, Create = edit.Create, Person = new()         {             Handle = source.Handle, Name = source.Name, Gender = source.Gender, Country = source.Country,             ClubId = source.ClubId, SupportedClubId = source.SupportedClubId, Role = source.Role,             AbilityTemplate = source.AbilityTemplate, Character = source.Character, MaxAscension = source.MaxAscension,             Rating = source.Rating, Wins = source.Wins, Losses = source.Losses, CustomClearChance = source.CustomClearChance,             Style = source.Style, Temperament = source.Temperament, Voice = source.Voice, Biography = source.Biography,             Personality = source.Personality, Avatar = source.Avatar         } }`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(publicEdit, CoopJson.Options)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(publicEdit, CoopJson.Options)`

**赋值（含属性/字段和局部值）：**

- `AbilityTemplate` = `source.AbilityTemplate`
- `Avatar` = `source.Avatar`
- `Biography` = `source.Biography`
- `Character` = `source.Character`
- `ClubId` = `source.ClubId`
- `Country` = `source.Country`
- `Create` = `edit.Create`
- `CustomClearChance` = `source.CustomClearChance`
- `Gender` = `source.Gender`
- `Handle` = `source.Handle`
- `Losses` = `source.Losses`
- `MaxAscension` = `source.MaxAscension`
- `Name` = `source.Name`
- `Person` = `new()         {             Handle = source.Handle, Name = source.Name, Gender = source.Gender, Country = source.Country,             ClubId = source.ClubId, SupportedClubId = source.SupportedClubId, Role = source.Role,             AbilityTemplate = source.AbilityTemplate, Character = source.Character, MaxAscension = source.MaxAscension,             Rating = source.Rating, Wins = source.Wins, Losses = source.Losses, CustomClearChance = source.CustomClearChance,             Style = source.Style, Temperament = source.Temperament, Voice = source.Voice, Biography = source.Biography,             Personality = source.Personality, Avatar = source.Avatar         }`
- `Personality` = `source.Personality`
- `Rating` = `source.Rating`
- `Role` = `source.Role`
- `Style` = `source.Style`
- `SupportedClubId` = `source.SupportedClubId`
- `Target` = `edit.Target`
- `Temperament` = `source.Temperament`
- `Voice` = `source.Voice`
- `Wins` = `source.Wins`

<a id="symbol-e5e79a4ed241"></a>

## `NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string) — public static string? ClubLock(CareerData d, string id)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedTransfer.Arrived`；`NationalSpire.OwnedTransfer.Contract`；`NationalSpire.WorldCompetition.PlayerEntered`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season && c.PlayerEntered)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.PlayerEntered)) return "本赛季已报名，俱乐部与赛区待休赛期调整。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Contracts.Any(c => c.PersonId == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned.Contracts.Any(c => c.PersonId == id) || owned.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned.Contracts.Any(c => c.PersonId == id) || owned.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9ac6c3acc6a4"></a>

## `NationalSpire.CharacterCards.CheckImportedFields(NationalSpire.CareerData, NationalSpire.CareerPerson) — internal static void CheckImportedFields(CareerData d, CareerPerson person)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCardPng.Export(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar)`](CharacterCardPng.cs.md#symbol-e9bb5cec943f)；[`NationalSpire.CharacterCardPng.Import(NationalSpire.CareerData, byte[], System.Func<byte[], NationalSpire.PlayerAvatar>?)`](CharacterCardPng.cs.md#symbol-c7101cd02992)

**调用：** [`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)；`NationalSpire.CharacterCardEdit.CharacterCardEdit()`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterCardEdit.CharacterCardEdit()`；输入表达式：`new() { Create = true, Target = person.Id, Person = person }`；返回值紧邻使用处：`ArgumentSyntax: new() { Create = true, Target = person.Id, Person = person }`
- `NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`；输入表达式：`Validate(d, new() { Create = true, Target = person.Id, Person = person }, true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(d, new() { Create = true, Target = person.Id, Person = person }, true) is { } error`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error);`

**赋值（含属性/字段和局部值）：**

- `Create` = `true`
- `Person` = `person`
- `Target` = `person.Id`

<a id="symbol-43d6137cec3b"></a>

## `NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool) — private static string? Validate(CareerData d, CharacterCardEdit edit, bool preview = false)`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-9a2f255d8204)；[`NationalSpire.CharacterCards.CheckImportedFields(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CharacterCards.cs.md#symbol-9ac6c3acc6a4)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-e5e79a4ed241)；[`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-3c3ff9c389dd)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.PersonalityProfile.Dimensions()`](PersonalityLibrary.cs.md#symbol-2a59469d0196)；[`NationalSpire.PlayerAvatar.Validate()`](PlayerAvatar.cs.md#symbol-96ff07617629)；`char.GetUnicodeCategory(char)`；`char.IsControl(char)`；`double.IsFinite(double)`；`string.Equals(string?, System.StringComparison)`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string, System.StringComparison)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Globalization.StringInfo.StringInfo(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string)`；`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；`NationalSpire.CharacterCards.Templates`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.IdentityGender.Choices`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.PersonalityProfile.AttitudeMax`；`NationalSpire.PersonalityProfile.AttitudeMin`；`NationalSpire.PersonalityProfile.Dimensions()`；`NationalSpire.PersonalityProfile.Kind`；`NationalSpire.PlayerAvatar.Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.GetUnicodeCategory(char)`；输入表达式：`char.GetUnicodeCategory(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.GetUnicodeCategory(c) == UnicodeCategory.Format`
- `char.IsControl(char)`；输入表达式：`char.IsControl(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c is '[' or ']' or '<' or '>' || char.IsControl(c)`
- `char.IsControl(char)`；输入表达式：`char.IsControl(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsControl(c) && c != '\n'`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(rate)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(rate)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(d)`
- `NationalSpire.CharacterCards.ClubLock(NationalSpire.CareerData, string)`；输入表达式：`ClubLock(d, edit.Target)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubLock(d, edit.Target) is { } locked`
- `NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；输入表达式：`Read(d, edit.Target)`；返回值紧邻使用处：`ConditionalExpressionSyntax: edit.Create ? null : Read(d, edit.Target)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, p.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(d, p.ClubId) == null`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, p.SupportedClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(d, p.SupportedClubId) == null`
- `NationalSpire.PersonalityProfile.Dimensions()`；输入表达式：`p.Personality.Dimensions()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Personality.Dimensions().Append`
- `NationalSpire.PlayerAvatar.Validate()`；输入表达式：`p.Avatar.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: p.Avatar.Validate();`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`p.Handle.Trim().Equals(CareerEngine.Name(d), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: edit.Target != "player" && p.Handle.Trim().Equals(CareerEngine.Name(d), StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`x.PublicName.Equals(p.Handle.Trim(), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: x.PublicName.Equals(p.Handle.Trim(), StringComparison.OrdinalIgnoreCase) || x.HandleAliases.Contains(p.Handle.Trim(), StringComparer.OrdinalIgnoreCase)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(p.Handle)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(p.Handle) || new StringInfo(p.Handle.Trim()).LengthInTextElements > 32`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`edit.Target.StartsWith("custom-", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !edit.Target.StartsWith("custom-", StringComparison.Ordinal)`
- `string.Trim()`；输入表达式：`p.Handle.Trim()`；返回值紧邻使用处：`ArgumentSyntax: p.Handle.Trim()`
- `string.Trim()`；输入表达式：`p.Handle.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Handle.Trim().Equals`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == edit.Target)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.People.Any(p => p.Id == edit.Target)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(x => x.Id == edit.Target)`；返回值紧邻使用处：`BinaryExpressionSyntax: edit.Target.Length != 39 || !edit.Target.StartsWith("custom-", StringComparison.Ordinal) || d.People.Any(x => x.Id == edit.Target)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(x => x.Id != edit.Target && !(edit.Target == "player" && x.Id == d.LocalHumanId)).Any(x => x.PublicName.Equals(p.Handle.Trim(), StringComparison.OrdinalIgnoreCase) || x.HandleAliases.Contains(p.Handle.Trim(), StringComparer.OrdinalIgnoreCase))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.People.Where(x => x.Id != edit.Target && !(edit.Target == "player" && x.Id == d.LocalHumanId)).Any(x => x.PublicName.Equals(p.Handle.Trim(), StringComparison.OrdinalIgnoreCase) || x.HandleAliases.Contains(p.Handle.Trim(), StringComparer.OrdinalIgnoreCase)) || edit.Target != "player" && p.Handle.Trim().Equals(CareerEngine.Name(d), StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`fields.Any(s => s == null || s.Length > 1200 || s.Any(c => char.IsControl(c) && c != '\n'))`；返回值紧邻使用处：`IfStatementSyntax: if (fields.Any(s => s == null || s.Length > 1200 || s.Any(c => char.IsControl(c) && c != '\n'))) return "文字过长或包含无效字符。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Handle.Any(c => c is '[' or ']' or '<' or '>' || char.IsControl(c) || char.GetUnicodeCategory(c) == UnicodeCategory.Format)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(p.Handle) || new StringInfo(p.Handle.Trim()).LengthInTextElements > 32 || p.Handle.Any(c => c is '[' or ']' or '<' or '>' || char.IsControl(c) || char.GetUnicodeCategory(c) == UnicodeCategory.Format)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Personality.Dimensions().Append(p.Personality.Kind).Any(s => s == null || s.Length > 1200)`；返回值紧邻使用处：`IfStatementSyntax: if (p.Personality.Dimensions().Append(p.Personality.Kind).Any(s => s == null || s.Length > 1200)) return "性格描述过长。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Any(c => char.IsControl(c) && c != '\n')`；返回值紧邻使用处：`BinaryExpressionSyntax: s == null || s.Length > 1200 || s.Any(c => char.IsControl(c) && c != '\n')`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.Personality.Dimensions().Append(p.Personality.Kind)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Personality.Dimensions().Append(p.Personality.Kind).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`x.HandleAliases.Contains(p.Handle.Trim(), StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: x.PublicName.Equals(p.Handle.Trim(), StringComparison.OrdinalIgnoreCase) || x.HandleAliases.Contains(p.Handle.Trim(), StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`EsportsWorld.Countries.Contains(p.Country)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !EsportsWorld.Countries.Contains(p.Country)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`IdentityGender.Choices.Contains(p.Gender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IdentityGender.Choices.Contains(p.Gender)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Templates.Contains(p.AbilityTemplate)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Templates.Contains(p.AbilityTemplate)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(x => x.Id != edit.Target && !(edit.Target == "player" && x.Id == d.LocalHumanId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(x => x.Id != edit.Target && !(edit.Target == "player" && x.Id == d.LocalHumanId)).Any`
- `System.Globalization.StringInfo.StringInfo(string)`；输入表达式：`new StringInfo(p.Handle.Trim())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringInfo(p.Handle.Trim()).LengthInTextElements`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9a2f255d8204"></a>

## `NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit) — public static string? Apply(CareerData d, CharacterCardEdit edit)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-4bce7f6af16c)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-3c3ff9c389dd)；[`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-9b3f1de1d44a)；`NationalSpire.CareerPerson.CareerPerson()`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Losses`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.PlayerAlias`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerData.PlayerIntroduction`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerData.Rating`；`NationalSpire.CareerData.SelectedAvatar`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.AbilityTemplate`；`NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.CreatedCard`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.EditedCard`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Identities`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.RecordVersion`；`NationalSpire.CareerPerson.Region`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CharacterCardEdit.Create`；`NationalSpire.CharacterCardEdit.Person`；`NationalSpire.CharacterCardEdit.Target`；`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`；`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Unset`；`NationalSpire.NpcRecords.Version`；`NationalSpire.PersonalityLibrary.Version`；`NationalSpire.PersonalityProfile.Version`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = edit.Target, CreatedCard = true }`；返回值紧邻使用处：`ConditionalExpressionSyntax: edit.Create ? new CareerPerson { Id = edit.Target, CreatedCard = true } : Read(d, edit.Target)`
- `NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；输入表达式：`Read(d, edit.Target)`；返回值紧邻使用处：`ConditionalExpressionSyntax: edit.Create ? new CareerPerson { Id = edit.Target, CreatedCard = true } : Read(d, edit.Target)`
- `NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`；输入表达式：`Validate(d, edit)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(d, edit) is { } error`
- `NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；输入表达式：`CircuitPeople.Replenish(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitPeople.Replenish(d);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(input.Avatar)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Avatar = CoopJson.Copy(input.Avatar)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(input.Personality)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Personality = CoopJson.Copy(input.Personality)`
- `NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Assigned(d, p.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Gender = IdentityGender.Assigned(d, p.Id)`
- `string.Trim()`；输入表达式：`input.Biography.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Biography = input.Biography.Trim()`
- `string.Trim()`；输入表达式：`input.Character.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Character = input.Character.Trim()`
- `string.Trim()`；输入表达式：`input.Handle.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Handle = input.Handle.Trim()`
- `string.Trim()`；输入表达式：`input.Handle.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: p.PublicName != input.Handle.Trim()`
- `string.Trim()`；输入表达式：`input.Name.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Name = input.Name.Trim()`
- `string.Trim()`；输入表达式：`input.Role.Trim()`；返回值紧邻使用处：`ArgumentSyntax: input.Role.Trim()`
- `string.Trim()`；输入表达式：`input.Role.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Role = input.Role.Trim()`
- `string.Trim()`；输入表达式：`input.Style.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Style = input.Style.Trim()`
- `string.Trim()`；输入表达式：`input.Temperament.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Temperament = input.Temperament.Trim()`
- `string.Trim()`；输入表达式：`input.Voice.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Voice = input.Voice.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`d.People.Where(x => x.Id != p.Id).Append(p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(x => x.Id != p.Id).Append(p).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.Identities.Where(s => s != p.Role).Append(input.Role.Trim())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(x => x.Id != p.Id).Append(p).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.People = d.People.Where(x => x.Id != p.Id).Append(p).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Identities = p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.OpponentId == p.Id && m.Status == "待赛")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in d.Matches.Where(m => m.OpponentId == p.Id && m.Status == "待赛"))             { m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(x => x.Id != p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(x => x.Id != p.Id).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Identities.Where(s => s != p.Role)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Identities.Where(s => s != p.Role).Append`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`p.HandleAliases.Add(p.PublicName)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.HandleAliases.Add(p.PublicName);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`d.Esports.Offers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`p.HandleAliases.Contains(p.PublicName)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.HandleAliases.Contains(p.PublicName)`

**赋值（含属性/字段和局部值）：**

- `CreatedCard` = `true`
- `d.Esports.ClubId` = `p.ClubId`
- `d.Esports.Country` = `p.Country`
- `d.Esports.PlayerContract` = `null`
- `d.Losses` = `p.Losses`
- `d.People` = `d.People.Where(x => x.Id != p.Id).Append(p).ToList()`
- `d.PlayerAlias` = `p.Handle`
- `d.PlayerCard` = `p`
- `d.PlayerGender` = `p.Gender`
- `d.PlayerIntroduction` = `""`
- `d.PlayerNameAliases` = `p.HandleAliases`
- `d.Rating` = `p.Rating`
- `d.SelectedAvatar` = `p.Avatar`
- `d.Wins` = `p.Wins`
- `Id` = `edit.Target`
- `m.Live` = `null`
- `m.OpponentPrepared` = `false`
- `m.OpponentSeconds` = `null`
- `p.AbilityTemplate` = `input.AbilityTemplate`
- `p.AiIntroduction` = `""`
- `p.Avatar` = `CoopJson.Copy(input.Avatar)`
- `p.Biography` = `input.Biography.Trim()`
- `p.Character` = `input.Character.Trim()`
- `p.ClubId` = `input.ClubId`
- `p.Country` = `input.Country`
- `p.CustomClearChance` = `input.CustomClearChance`
- `p.EditedCard` = `true`
- `p.Gender` = `IdentityGender.Assigned(d, p.Id)`
- `p.Gender` = `p.CameoId.Length > 0 ? "男" : input.Gender`
- `p.Handle` = `input.Handle.Trim()`
- `p.Identities` = `p.Identities.Where(s => s != p.Role).Append(input.Role.Trim()).Distinct().ToList()`
- `p.IntroductionDay` = `0`
- `p.Losses` = `input.Losses`
- `p.MaxAscension` = `input.MaxAscension`
- `p.Name` = `input.Name.Trim()`
- `p.Personality.Version` = `PersonalityLibrary.Version`
- `p.Personality` = `CoopJson.Copy(input.Personality)`
- `p.Rating` = `input.Rating`
- `p.RecordVersion` = `NpcRecords.Version`
- `p.Region` = `input.Country + "赛区"`
- `p.Role` = `input.Role.Trim()`
- `p.Style` = `input.Style.Trim()`
- `p.SupportedClubId` = `input.SupportedClubId`
- `p.Temperament` = `input.Temperament.Trim()`
- `p.Voice` = `input.Voice.Trim()`
- `p.Wins` = `input.Wins`

<a id="symbol-4bce7f6af16c"></a>

## `NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit) — public static string? Save(CareerData d, CharacterCardEdit edit)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-9a2f255d8204)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Losses`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.PlayerAlias`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerData.PlayerIntroduction`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerData.Rating`；`NationalSpire.CareerData.SelectedAvatar`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`；输入表达式：`Apply(d, edit)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Apply(d, edit) is { } error`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(d)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("character-card.save", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("character-card.save", e);`

**赋值（含属性/字段和局部值）：**

- `d.Esports` = `before.Esports`
- `d.Losses` = `before.Losses`
- `d.Matches` = `before.Matches`
- `d.People` = `before.People`
- `d.PlayerAlias` = `before.PlayerAlias`
- `d.PlayerCard` = `before.PlayerCard`
- `d.PlayerGender` = `before.PlayerGender`
- `d.PlayerIntroduction` = `before.PlayerIntroduction`
- `d.PlayerNameAliases` = `before.PlayerNameAliases`
- `d.Rating` = `before.Rating`
- `d.SelectedAvatar` = `before.SelectedAvatar`
- `d.Wins` = `before.Wins`
