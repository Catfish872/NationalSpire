# Coop/CoopCareerSession.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`CDD53FD309382574CDC181865F680BBBA4D86E62F5A54866C98DF3EBA452FBA7`。来源：[源码](../../../Coop/CoopCareerSession.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopCareerSession`。

字段、事件及初始值（源码原样）：

```csharp
private readonly CoopCoordinator _session;
private readonly Control _menu;
private long _revision = -1;
private string _presence = "";
private CoopCommand? _pending;
private int _queuedCeremony;
private Action? _accepted;
public event Action<string, bool>? Message;
```

<a id="symbol-f3a7fbdbf138"></a>

## `NationalSpire.Coop.CoopCareerSession.Data — public CareerData Data`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a6c737f6fb75"></a>

## `NationalSpire.Coop.CoopCareerSession.Host — public bool Host`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ec8ff85d1683"></a>

## `NationalSpire.Coop.CoopCareerSession.Alive — public bool Alive`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-265e10bd04e3"></a>

## `NationalSpire.Coop.CoopCareerSession.Status — public string Status`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Host`；`NationalSpire.Coop.CoopCoordinator.Online`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-57e14b126cd6"></a>

## `NationalSpire.Coop.CoopCareerSession.CanResume — public bool CanResume`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Host`；`NationalSpire.Coop.CoopCoordinator.Full`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-af2098cc8d2d"></a>

## `NationalSpire.Coop.CoopCareerSession.RunStatus — public string RunStatus`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopRun.FailureReason`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Native`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-874eac9d9e97"></a>

## `NationalSpire.Coop.CoopCareerSession.ProposalId — public string ProposalId`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopProposal.Id`；`NationalSpire.Coop.CoopWorld.Proposal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cbe9a2f65cf3"></a>

## `NationalSpire.Coop.CoopCareerSession.Team — public IReadOnlyList<CareerTeamMember> Team`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](../LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.GameBridge.Characters()`](../GameBridge.cs.md#symbol-1233494dda40)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.CareerTeamMember.CareerTeamMember(string, string, string, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.RandomCharacterChoice`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.Prize`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Character`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.RandomCharacter`；`NationalSpire.Coop.CoopMember.Results`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.GameBridge.Characters()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`.Title.GetFormattedText()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == character`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(last.Prize)`；返回值紧邻使用处：`BinaryExpressionSyntax: last.Event + " · " + last.Outcome + " · 收入 " + CareerMoney.Format(last.Prize)`
- `NationalSpire.CareerTeamMember.CareerTeamMember(string, string, string, string)`；输入表达式：`new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,              character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail)`；返回值紧邻使用处：`ReturnStatementSyntax: return new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,              character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail);`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`run.Characters.ContainsKey(m.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_session.Online.Contains(m.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`m.Results.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = m.Results.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)).Select(m =>      {          var last = m.Results.LastOrDefault();          string character = _session.World!.Run?.Characters.GetValueOrDefault(m.SteamId) ?? m.Character;          string detail = last == null ? "尚无本生涯战绩" : last.Event + " · " + last.Outcome + " · 收入 " + CareerMoney.Format(last.Prize);          return new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,              character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail);      })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)).Select(m =>      {          var last = m.Results.LastOrDefault();          string character = _session.World!.Run?.Characters.GetValueOrDefault(m.SteamId) ?? m.Character;          string detail = last == null ? "尚无本生涯战绩" : last.Event + " · " + last.Outcome + " · 收入 " + CareerMoney.Format(last.Prize);          return new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,              character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail);      }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)).Select(m =>      {          var last = m.Results.LastOrDefault();          string character = _session.World!.Run?.Characters.GetValueOrDefault(m.SteamId) ?? m.Character;          string detail = last == null ? "尚无本生涯战绩" : last.Event + " · " + last.Outcome + " · 收入 " + CareerMoney.Format(last.Prize);          return new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,              character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail);      }).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)).Select(m =>      {          var last = m.Results.LastOrDefault();          string character = _session.World!.Run?.Characters.GetValueOrDefault(m.SteamId) ?? m.Character;          string detail = last == null ? "尚无本生涯战绩" : last.Event + " · " + last.Outcome + " · 收入 " + CareerMoney.Format(last.Prize);          return new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,              character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail);      }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Characters.GetValueOrDefault(m.SteamId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _session.World!.Run?.Characters.GetValueOrDefault(m.SteamId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a5fdcb31eacc"></a>

## `NationalSpire.Coop.CoopCareerSession.Opponents(NationalSpire.CareerMatch) — public IReadOnlyList<string> Opponents(CareerMatch match)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopRules.Opponents(NationalSpire.Coop.CoopWorld, NationalSpire.CareerMatch)`](CoopRules.cs.md#symbol-ddfb352cda97)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Id`；`NationalSpire.CareerPerson.Id`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRules.Opponents(NationalSpire.Coop.CoopWorld, NationalSpire.CareerMatch)`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRules.Opponents(NationalSpire.Coop.CoopWorld, NationalSpire.CareerMatch)`；输入表达式：`CoopRules.Opponents(_session.World, match)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopRules.Opponents(_session.World, match).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CoopRules.Opponents(_session.World, match).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopRules.Opponents(_session.World, match).Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CoopRules.Opponents(_session.World, match).Select(p => p.Id).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _session.World!.Run is { } run && run.MatchId == match.Id ? run.Opponents :          CoopRules.Opponents(_session.World, match).Select(p => p.Id).ToList()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c2c3a50b1c6"></a>

## `NationalSpire.Coop.CoopCareerSession.HasVoted — public bool HasVoted`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._pending`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.ProposalId`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopProposal.Votes`；`NationalSpire.Coop.CoopWorld.Proposal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`.Votes.Contains(_session.Self)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Proposal?.Votes.Contains(_session.Self)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c54c011ffcc7"></a>

## `NationalSpire.Coop.CoopCareerSession.ProposalText — public string ProposalText`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopProposal.Label`；`NationalSpire.Coop.CoopProposal.Participants`；`NationalSpire.Coop.CoopProposal.Votes`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Proposal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("  /  ", _session.World.Members.Where(m => p.Participants.Contains(m.SteamId)).Select(m => m.Name + (p.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认")))`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Label + "\n" + string.Join("  /  ", _session.World.Members.Where(m => p.Participants.Contains(m.SteamId)).Select(m => m.Name + (p.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认")))`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`p.Participants.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => p.Participants.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`p.Votes.Contains(m.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_session.World.Members.Where(m => p.Participants.Contains(m.SteamId)).Select(m => m.Name + (p.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))`；返回值紧邻使用处：`ArgumentSyntax: _session.World.Members.Where(m => p.Participants.Contains(m.SteamId)).Select(m => m.Name + (p.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_session.World.Members.Where(m => p.Participants.Contains(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _session.World.Members.Where(m => p.Participants.Contains(m.SteamId)).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-be42258ccf13"></a>

## `NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control) — public CoopCareerSession(CoopCoordinator session, Control menu)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.EnterCareer()`](CoopScreen.cs.md#symbol-88e296cd2158)；[`NationalSpire.Coop.CoopScreen.OpenCareerOrRoom(Godot.Control)`](CoopScreen.cs.md#symbol-eee7991d404e)

**调用：** [`NationalSpire.Coop.CoopCareerSession.Refresh()`](CoopCareerSession.cs.md#symbol-d972d69103cb)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._menu`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Refresh()`；`NationalSpire.Coop.CoopCareerSession.Replied(NationalSpire.Coop.CoopReply)`；`NationalSpire.Coop.CoopCoordinator.Replied`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCareerSession.Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`

**赋值（含属性/字段和局部值）：**

- `_menu` = `menu`
- `_session.Replied` += `Replied`
- `_session` = `session`

<a id="symbol-d972d69103cb"></a>

## `NationalSpire.Coop.CoopCareerSession.Refresh() — public bool Refresh()`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.CoopCareerSession(NationalSpire.Coop.CoopCoordinator, Godot.Control)`](CoopCareerSession.cs.md#symbol-be42258ccf13)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`](CoopCareerSession.cs.md#symbol-b761b96e0df4)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；`int.ToString()`；`NationalSpire.AiOptions.AiOptions()`；`object.ReferenceEquals(object?, object?)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopCareerSession._pending`；`NationalSpire.Coop.CoopCareerSession._presence`；`NationalSpire.Coop.CoopCareerSession._queuedCeremony`；`NationalSpire.Coop.CoopCareerSession._revision`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Alive`；`NationalSpire.Coop.CoopCareerSession.Data`；`NationalSpire.Coop.CoopCareerSession.Host`；`NationalSpire.Coop.CoopCareerSession.RunStatus`；`NationalSpire.Coop.CoopCareerSession.SaveReading(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.ReadPosts`；`NationalSpire.Coop.CoopMember.ReadWeeks`；`NationalSpire.Coop.CoopMember.SeenSettlement`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.WeeklyEdition.SeenRevision`；`NationalSpire.WeeklyEdition.Week`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`season.ToString()`；返回值紧邻使用处：`ArgumentSyntax: season.ToString()`
- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: Data.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(Data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(Data)) post.SeenRevision = member.ReadPosts.GetValueOrDefault(post.Id);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(Data)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var thread in CommunityThreads.All(Data))          {              if (thread.AuthorId == member.PersonId) thread.AuthorId = "player";              foreach (var reply in thread.Replies) if (reply.AuthorId == member.PersonId) reply.AuthorId = "player";          }`
- `NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`Send("ceremony-read", season.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Send("ceremony-read", season.ToString());`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(w.World.Esports.PlayerContract)`；返回值紧邻使用处：`ConditionalExpressionSyntax: w.World.Esports.PlayerContract == null ? null : CoopJson.Copy(w.World.Esports.PlayerContract)`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`CoopRules.View(w, member)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Data = CoopRules.View(w, member)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(Data, view)`；返回值紧邻使用处：`BinaryExpressionSyntax: Alive && ReferenceEquals(Data, view)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', _session.Online.Order())`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Join(',', _session.Online.Order()) + "|"`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`_session.Online.Order()`；返回值紧邻使用处：`ArgumentSyntax: _session.Online.Order()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`Data.Results.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Data.Results.LastOrDefault()?.MatchId`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Members.Single(m => m.SteamId == _session.Self)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = w.Members.Single(m => m.SteamId == _session.Self)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`member.ReadPosts.GetValueOrDefault(post.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.SeenRevision = member.ReadPosts.GetValueOrDefault(post.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`member.ReadWeeks.GetValueOrDefault(issue.Week)`；返回值紧邻使用处：`AssignmentExpressionSyntax: issue.SeenRevision = member.ReadWeeks.GetValueOrDefault(issue.Week)`

**赋值（含属性/字段和局部值）：**

- `_presence` = `presence`
- `_queuedCeremony` = `0`
- `_revision` = `w.Revision`
- `Data.Ai` = `AiSettingsStore.Load(new())`
- `Data.Esports.PlayerContract` = `w.World.Esports.PlayerContract == null ? null : CoopJson.Copy(w.World.Esports.PlayerContract)`
- `Data.ExternalCurrent` = `() => Alive && ReferenceEquals(Data, view)`
- `Data.ExternalSave` = `SaveReading`
- `Data.PendingMatchId` = `w.World.Failure == null ? w.Run?.MatchId : null`
- `Data.PendingSettlementId` = `member.SeenSettlement == Data.Results.LastOrDefault()?.MatchId ? "" : Data.Results.LastOrDefault()?.MatchId ?? ""`
- `Data` = `CoopRules.View(w, member)`
- `issue.SeenRevision` = `member.ReadWeeks.GetValueOrDefault(issue.Week)`
- `post.SeenRevision` = `member.ReadPosts.GetValueOrDefault(post.Id)`
- `reply.AuthorId` = `"player"`
- `thread.AuthorId` = `"player"`

<a id="symbol-34fbd3119785"></a>

## `NationalSpire.Coop.CoopCareerSession.SaveReading(NationalSpire.CareerData) — private void SaveReading(CareerData data)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`](CoopCareerSession.cs.md#symbol-b761b96e0df4)；`NationalSpire.Coop.CoopReading.CoopReading()`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingSettlementId`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.SeenRevision`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopCareerSession._pending`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Alive`；`NationalSpire.Coop.CoopCareerSession.Data`；`NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopMember.ReadPosts`；`NationalSpire.Coop.CoopMember.ReadWeeks`；`NationalSpire.Coop.CoopMember.SeenSettlement`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopReading.Posts`；`NationalSpire.Coop.CoopReading.Settlement`；`NationalSpire.Coop.CoopReading.Weeks`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.WeeklyEdition.SeenRevision`；`NationalSpire.WeeklyEdition.Week`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`Send("reading", text: System.Text.Json.JsonSerializer.Serialize(reading, CoopJson.Options))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send("reading", text: System.Text.Json.JsonSerializer.Serialize(reading, CoopJson.Options));`
- `NationalSpire.Coop.CoopReading.CoopReading()`；输入表达式：`new CoopReading()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopReading()`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(data, Data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(data, Data)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`data.Results.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Results.LastOrDefault()?.MatchId`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`_session.World!.Members.Single(m => m.SteamId == _session.Self)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _session.World!.Members.Single(m => m.SteamId == _session.Self)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`CommunityThreads.All(data).Where(p => p.SeenRevision > member.ReadPosts.GetValueOrDefault(p.Id)).Take(80)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(data).Where(p => p.SeenRevision > member.ReadPosts.GetValueOrDefault(p.Id)).Take(80)) reading.Posts[post.Id] = post.SeenRevision;`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => p.SeenRevision > member.ReadPosts.GetValueOrDefault(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => p.SeenRevision > member.ReadPosts.GetValueOrDefault(p.Id)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Where(w => w.SeenRevision > member.ReadWeeks.GetValueOrDefault(w.Week))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var week in data.WeeklyEditions.Where(w => w.SeenRevision > member.ReadWeeks.GetValueOrDefault(w.Week))) reading.Weeks[week.Week] = week.SeenRevision;`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`member.ReadPosts.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.SeenRevision > member.ReadPosts.GetValueOrDefault(p.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`member.ReadWeeks.GetValueOrDefault(w.Week)`；返回值紧邻使用处：`BinaryExpressionSyntax: w.SeenRevision > member.ReadWeeks.GetValueOrDefault(w.Week)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(reading, CoopJson.Options)`；返回值紧邻使用处：`ArgumentSyntax: text: System.Text.Json.JsonSerializer.Serialize(reading, CoopJson.Options)`

**赋值（含属性/字段和局部值）：**

- `reading.Posts[post.Id]` = `post.SeenRevision`
- `reading.Settlement` = `id`
- `reading.Weeks[week.Week]` = `week.SeenRevision`

<a id="symbol-b761b96e0df4"></a>

## `NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?) — public void Send(string kind, string target = "", string text = "", int number = 0, string parent = "", Action? accepted = null)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Refresh()`](CoopCareerSession.cs.md#symbol-d972d69103cb)；[`NationalSpire.Coop.CoopCareerSession.SaveReading(NationalSpire.CareerData)`](CoopCareerSession.cs.md#symbol-34fbd3119785)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-11ae699cefda)；`int.TryParse(string?, out int)`；`NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._accepted`；`NationalSpire.Coop.CoopCareerSession._pending`；`NationalSpire.Coop.CoopCareerSession._queuedCeremony`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Alive`；`NationalSpire.Coop.CoopCareerSession.Host`；`NationalSpire.Coop.CoopCareerSession.Message`；`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(target, out int season)`；返回值紧邻使用处：`IfStatementSyntax: if (int.TryParse(target, out int season)) _queuedCeremony = Math.Max(_queuedCeremony, season);`
- `NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；输入表达式：`new(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pending = new(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent)`
- `NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；输入表达式：`_session.Retry(_pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: _session.Retry(_pending);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke("房间已断开，请返回队伍重新加入。", true)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Message?.Invoke("房间已断开，请返回队伍重新加入。", true)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke("已提交准备，等待同步。", false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Message?.Invoke("已提交准备，等待同步。", false)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke("正在同步上一项操作。", false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Message?.Invoke("正在同步上一项操作。", false)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(e.Message, true)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Message?.Invoke(e.Message, true)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ArgumentSyntax: Guid.NewGuid().ToString("N")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_queuedCeremony, season)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _queuedCeremony = Math.Max(_queuedCeremony, season)`

**赋值（含属性/字段和局部值）：**

- `_accepted` = `accepted`
- `_accepted` = `null`
- `_pending` = `new(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent)`
- `_pending` = `null`
- `_queuedCeremony` = `Math.Max(_queuedCeremony, season)`

<a id="symbol-c41a79096294"></a>

## `NationalSpire.Coop.CoopCareerSession.Replied(NationalSpire.Coop.CoopReply) — private void Replied(CoopReply reply)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.StartsWith(string)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._accepted`；`NationalSpire.Coop.CoopCareerSession._pending`；`NationalSpire.Coop.CoopCareerSession.Message`；`NationalSpire.Coop.CoopCareerSession.ProposalId`；`NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopOutcome.Accepted`；`NationalSpire.Coop.CoopOutcome.Message`；`NationalSpire.Coop.CoopReply.Id`；`NationalSpire.Coop.CoopReply.Outcome`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string)`；输入表达式：`_pending.Kind.StartsWith("dm-")`；返回值紧邻使用处：`BinaryExpressionSyntax: _pending.Kind is "reading" or "ceremony-read" || _pending.Kind.StartsWith("dm-")`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: action?.Invoke()`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(reply.Outcome.Accepted ? (ProposalId.Length > 0 ? "提议已提交，等待队员确认。" : "操作已完成。") : reply.Outcome.Message, !reply.Outcome.Accepted)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Message?.Invoke(reply.Outcome.Accepted ? (ProposalId.Length > 0 ? "提议已提交，等待队员确认。" : "操作已完成。") : reply.Outcome.Message, !reply.Outcome.Accepted)`

**赋值（含属性/字段和局部值）：**

- `_accepted` = `null`
- `_pending` = `null`

<a id="symbol-6fb4f052a4e3"></a>

## `NationalSpire.Coop.CoopCareerSession.SaveAi(NationalSpire.CareerData) — public void SaveAi(CareerData data)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`](../AiService.cs.md#symbol-19e0ca89f9d7)；[`NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-ba3b31b1bb7c)；[`NationalSpire.Coop.CoopAi.Stop()`](CoopAi.cs.md#symbol-db98f42d4f99)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`](../WeeklyJournal.cs.md#symbol-182dc6fd73e0)；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`；`NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.Coop.CoopAi.Stop()`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Host`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopRuntime.Ai`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.RefreshConcurrency(NationalSpire.AiOptions?)`；输入表达式：`AiService.RefreshConcurrency(data.Ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.RefreshConcurrency(data.Ai);`
- `NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Save(data.Ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiSettingsStore.Save(data.Ai);`
- `NationalSpire.Coop.CoopAi.Stop()`；输入表达式：`.Stop()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CoopRuntime.Current!.Ai?.Stop()`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`_session.Commit(world, _session.NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: _session.Commit(world, _session.NativeSave);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(_session.World!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(_session.World!)`
- `NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`；输入表达式：`WeeklyJournal.ActivateLatest(world.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyJournal.ActivateLatest(world.World);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("AI 设置由主机管理。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("AI 设置由主机管理。");`

**赋值（含属性/字段和局部值）：**

- `world.World.Ai.Enabled` = `data.Ai.Enabled`

<a id="symbol-b759806eeebc"></a>

## `NationalSpire.Coop.CoopCareerSession.Generate(bool) — public void Generate(bool retry = false)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopAi.Process(bool)`](CoopAi.cs.md#symbol-3046e7db594f)；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAi.Process(bool)`；`NationalSpire.Coop.CoopCareerSession.Host`；`NationalSpire.Coop.CoopCareerSession.Message`；`NationalSpire.Coop.CoopRuntime.Ai`；`NationalSpire.Coop.CoopRuntime.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAi.Process(bool)`；输入表达式：`CoopRuntime.Current!.Ai!.Process(retry)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = CoopRuntime.Current!.Ai!.Process(retry)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke("生成与重试由主机处理。", false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Message?.Invoke("生成与重试由主机处理。", false)`

**赋值（含属性/字段和局部值）：**

- `_` = `CoopRuntime.Current!.Ai!.Process(retry)`

<a id="symbol-cf5687c76814"></a>

## `NationalSpire.Coop.CoopCareerSession.OpenRoom() — public void OpenRoom()`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`](CoopScreen.cs.md#symbol-c9ac083daf6c)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._menu`；`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`；输入表达式：`CoopScreen.Open(_menu, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CoopScreen.Open(_menu, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-24a80da4bec4"></a>

## `NationalSpire.Coop.CoopCareerSession.Export() — public async Task<string> Export()`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.CollectDiagnostics(System.TimeSpan?)`](CoopDiagnostics.cs.md#symbol-3673c645e7c7)；[`NationalSpire.Coop.CoopStorage.PublicCopy(NationalSpire.Coop.CoopWorld)`](CoopStorage.cs.md#symbol-9dfe7ef480f7)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](../Diagnostics.cs.md#symbol-a22f068c4d41)；`Godot.ProjectSettings.GlobalizePath(string)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `<anonymous type: NationalSpire.Coop.CoopWorld world, byte[] originalRun, ulong[] online, ulong self>.online`；`<anonymous type: NationalSpire.Coop.CoopWorld world, byte[] originalRun, ulong[] online, ulong self>.originalRun`；`<anonymous type: NationalSpire.Coop.CoopWorld world, byte[] originalRun, ulong[] online, ulong self>.self`；`<anonymous type: NationalSpire.Coop.CoopWorld world, byte[] originalRun, ulong[] online, ulong self>.world`；`NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCoordinator.CollectDiagnostics(System.TimeSpan?)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Status`；`NationalSpire.Coop.CoopSettings.Root`；`NationalSpire.Coop.CoopStorage.PublicCopy(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://logs")`；返回值紧邻使用处：`ArgumentSyntax: ProjectSettings.GlobalizePath("user://logs")`
- `NationalSpire.Coop.CoopCoordinator.CollectDiagnostics(System.TimeSpan?)`；输入表达式：`_session.CollectDiagnostics()`；返回值紧邻使用处：`AwaitExpressionSyntax: await _session.CollectDiagnostics()`
- `NationalSpire.Coop.CoopStorage.PublicCopy(NationalSpire.Coop.CoopWorld)`；输入表达式：`CoopStorage.PublicCopy(_session.World)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: world = CoopStorage.PublicCopy(_session.World)`
- `NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`；输入表达式：`Diagnostics.Export(_session.World.World, System.IO.Path.Combine(CoopSettings.Root, _session.World.Id),              ProjectSettings.GlobalizePath("user://logs"), CoopRuntime.Current?.Status ?? "房间已关闭",              new { world = CoopStorage.PublicCopy(_session.World), originalRun = _session.NativeSave, online = _session.Online.ToArray(), self = _session.Self }, reports)`；返回值紧邻使用处：`ReturnStatementSyntax: return Diagnostics.Export(_session.World.World, System.IO.Path.Combine(CoopSettings.Root, _session.World.Id),              ProjectSettings.GlobalizePath("user://logs"), CoopRuntime.Current?.Status ?? "房间已关闭",              new { world = CoopStorage.PublicCopy(_session.World), originalRun = _session.NativeSave, online = _session.Online.ToArray(), self = _session.Self }, reports);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_session.Online.ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: online = _session.Online.ToArray()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("房间已关闭，请重新连接后导出。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("房间已关闭，请重新连接后导出。");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`System.IO.Path.Combine(CoopSettings.Root, _session.World.Id)`；返回值紧邻使用处：`ArgumentSyntax: System.IO.Path.Combine(CoopSettings.Root, _session.World.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d673a0c6f401"></a>

## `NationalSpire.Coop.CoopCareerSession.Dispose() — public void Dispose()`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCareerSession._session`；`NationalSpire.Coop.CoopCareerSession.Replied(NationalSpire.Coop.CoopReply)`；`NationalSpire.Coop.CoopCoordinator.Replied`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_session.Replied` -= `Replied`
