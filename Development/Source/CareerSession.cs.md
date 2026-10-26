# CareerSession.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C7B6F681C00AA03BDC6ADD02DDD89BAFD4E46A9222861FFBCDB36EA0473E3F6B`。来源：[源码](../../CareerSession.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ICareerSession`、`NationalSpire.CareerTeamMember`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
event Action<string, bool>? Message;
private ICareerSession? _multiplayer;
```

<a id="symbol-043a6e698c45"></a>

## `NationalSpire.ICareerSession.Data —  CareerData Data`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-909669a82c58"></a>

## `NationalSpire.ICareerSession.Host —  bool Host`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-966a55f8f5ad"></a>

## `NationalSpire.ICareerSession.Alive —  bool Alive`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d7c45efdfa1e"></a>

## `NationalSpire.ICareerSession.Status —  string Status`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fc30135ca882"></a>

## `NationalSpire.ICareerSession.ProposalId —  string ProposalId`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-58745a7b6ebb"></a>

## `NationalSpire.ICareerSession.Team —  IReadOnlyList<CareerTeamMember> Team`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a688107298ab"></a>

## `NationalSpire.ICareerSession.Opponents(NationalSpire.CareerMatch) — IReadOnlyList<string> Opponents(CareerMatch match);`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Side(bool)`](BroadcastVisuals.cs.md#symbol-f3d2df3d6c54)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-54f70b1ea502"></a>

## `NationalSpire.ICareerSession.ProposalText —  string ProposalText`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8fc0e8c96f3f"></a>

## `NationalSpire.ICareerSession.HasVoted —  bool HasVoted`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bae3aaaf496d"></a>

## `NationalSpire.ICareerSession.Refresh() — bool Refresh();`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-98ac2ebb0f25)；[`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-b8f072aaa76f)；[`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-bf6f71fa2076)；[`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e21b0ff1d18b"></a>

## `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?) — void Send(string kind, string target = "", string text = "", int number = 0, string parent = "", Action? accepted = null);`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.RefreshPrivateProposal()`](PrivateMessageScreen.cs.md#symbol-fcf77d9c4194)；[`NationalSpire.CareerScreen.RemoveConsumerDraft(NationalSpire.PrivateOffer)`](ConsumerCommerceScreen.cs.md#symbol-635682b51731)；[`NationalSpire.CareerScreen.ReserveConsumerDraft(NationalSpire.PrivateOffer)`](ConsumerCommerceScreen.cs.md#symbol-27b7a54df1f4)；[`Save()`](NpcAvatarFrameScreen.cs.md#symbol-a1802dcac073)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-64829595f834"></a>

## `NationalSpire.ICareerSession.SaveAi(NationalSpire.CareerData) — void SaveAi(CareerData data);`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-485b9c9c8acb)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ccebd9f9e61d"></a>

## `NationalSpire.ICareerSession.Generate(bool) — void Generate(bool retry = false);`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GenerateContent(System.Action, bool)`](CareerSession.cs.md#symbol-1a6f5b7e24d2)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c0271c6664ef"></a>

## `NationalSpire.ICareerSession.OpenRoom() — void OpenRoom();`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e416b0553c93"></a>

## `NationalSpire.ICareerSession.RunStatus —  string RunStatus`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6fedddd88988"></a>

## `NationalSpire.ICareerSession.CanResume —  bool CanResume`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2b6e92b44f01"></a>

## `NationalSpire.ICareerSession.Export() — Task<string> Export();`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`](CareerSession.cs.md#symbol-a90f33a1d9ae)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b345ad92eddb"></a>

## `NationalSpire.CareerScreen.ShowDiagnosticFile(string) — private void ShowDiagnosticFile(string path)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer)`](CareerSession.cs.md#symbol-a90f33a1d9ae)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** [`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.OS.ShellShowInFileManager(string, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Notice(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`Godot.GodotObject.IsInstanceValid(this)`；返回值紧邻使用处：`IfStatementSyntax: if (Godot.GodotObject.IsInstanceValid(this))              Notice(result == Godot.Error.Ok ? "问题报告已导出，文件夹已打开。" : "报告已保存，文件夹未能打开：" + path, false);`
- `Godot.OS.ShellShowInFileManager(string, bool)`；输入表达式：`Godot.OS.ShellShowInFileManager(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Godot.OS.ShellShowInFileManager(path)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(result == Godot.Error.Ok ? "问题报告已导出，文件夹已打开。" : "报告已保存，文件夹未能打开：" + path, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(result == Godot.Error.Ok ? "问题报告已导出，文件夹已打开。" : "报告已保存，文件夹未能打开：" + path, false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a90f33a1d9ae"></a>

## `NationalSpire.CareerScreen.AddMultiplayerReportButton(Godot.VBoxContainer) — private void AddMultiplayerReportButton(Godot.VBoxContainer box)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.ShowDiagnosticFile(string)`](CareerSession.cs.md#symbol-b345ad92eddb)；[`NationalSpire.ICareerSession.Export()`](CareerSession.cs.md#symbol-2b6e92b44f01)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ShowDiagnosticFile(string)`；`NationalSpire.ICareerSession.Export()`；`NationalSpire.ICareerSession.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`Godot.GodotObject.IsInstanceValid(button)`；返回值紧邻使用处：`IfStatementSyntax: if (Godot.GodotObject.IsInstanceValid(button)) { button.Disabled = false; button.Text = session.Host ? "导出全队问题报告" : "导出本机问题报告"; }`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`Godot.GodotObject.IsInstanceValid(this)`；返回值紧邻使用处：`IfStatementSyntax: if (Godot.GodotObject.IsInstanceValid(this)) Notice("报告导出失败：" + e.Message, true);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(button);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(session.Host ? "导出全队问题报告" : "导出本机问题报告", async () =>          {              if (button == null || button.Disabled) return;              button.Disabled = true; button.Text = session.Host ? "正在收集队友日志…" : "正在导出…";              try { ShowDiagnosticFile(await session.Export()); }              catch (Exception e) { if (Godot.GodotObject.IsInstanceValid(this)) Notice("报告导出失败：" + e.Message, true); }              finally { if (Godot.GodotObject.IsInstanceValid(button)) { button.Disabled = false; button.Text = session.Host ? "导出全队问题报告" : "导出本机问题报告"; } }          }, 280)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button = Button(session.Host ? "导出全队问题报告" : "导出本机问题报告", async () =>          {              if (button == null || button.Disabled) return;              button.Disabled = true; button.Text = session.Host ? "正在收集队友日志…" : "正在导出…";              try { ShowDiagnosticFile(await session.Export()); }              catch (Exception e) { if (Godot.GodotObject.IsInstanceValid(this)) Notice("报告导出失败：" + e.Message, true); }              finally { if (Godot.GodotObject.IsInstanceValid(button)) { button.Disabled = false; button.Text = session.Host ? "导出全队问题报告" : "导出本机问题报告"; } }          }, 280)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("报告导出失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("报告导出失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.ShowDiagnosticFile(string)`；输入表达式：`ShowDiagnosticFile(await session.Export())`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDiagnosticFile(await session.Export());`
- `NationalSpire.ICareerSession.Export()`；输入表达式：`session.Export()`；返回值紧邻使用处：`AwaitExpressionSyntax: await session.Export()`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `false`
- `button.Disabled` = `true`
- `button.Text` = `session.Host ? "导出全队问题报告" : "导出本机问题报告"`
- `button.Text` = `session.Host ? "正在收集队友日志…" : "正在导出…"`
- `button` = `Button(session.Host ? "导出全队问题报告" : "导出本机问题报告", async () =>          {              if (button == null || button.Disabled) return;              button.Disabled = true; button.Text = session.Host ? "正在收集队友日志…" : "正在导出…";              try { ShowDiagnosticFile(await session.Export()); }              catch (Exception e) { if (Godot.GodotObject.IsInstanceValid(this)) Notice("报告导出失败：" + e.Message, true); }              finally { if (Godot.GodotObject.IsInstanceValid(button)) { button.Disabled = false; button.Text = session.Host ? "导出全队问题报告" : "导出本机问题报告"; } }          }, 280)`

<a id="symbol-5f88d8120995"></a>

## `NationalSpire.CareerScreen.ViewData — private CareerData ViewData`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerStore.Data`；`NationalSpire.ICareerSession.Data`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-babd46c04a9f"></a>

## `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?) — private bool MultiplayerCommand(string kind, string target = "", string text = "", int number = 0, string parent = "", Action? accepted = null)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ChooseCharacter(int)`](CareerScreen.cs.md#symbol-2e29f360fdfb)；[`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)；[`NationalSpire.CareerScreen.AdvanceCareerDay()`](MarketScreen.cs.md#symbol-871f6318461f)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-5700a0d050b5)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.ClubLeaveDialog()`](ClubDepartureScreen.cs.md#symbol-6954ceb20cdf)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-f212593005f6)；[`NationalSpire.CareerScreen.ContinueEventJourney()`](EventJourneyScreen.cs.md#symbol-ec3a0ef51c59)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.RandomEventSettings()`](RandomEventScreen.cs.md#symbol-6c1195d3802b)；[`NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-b0bc87216d33)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData)`](TeamPreparationScreen.cs.md#symbol-57b7570c5a7d)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`Vote(int)`](CommunityScreen.cs.md#symbol-8f211a670431)

**调用：** [`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send(kind, target, text, number, parent, accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send(kind, target, text, number, parent, accepted);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a13f3923812a"></a>

## `NationalSpire.CareerScreen.TeamButton(string, System.Action, int) — private Godot.Button TeamButton(string text, Action action, int width = 180)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.CoachManagement(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-7f703533cff4)；[`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.ICareerSession.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(text, action, width)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(text, action, width)`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `true`
- `button.TooltipText` = `"由房主操作。"`

<a id="symbol-485b9c9c8acb"></a>

## `NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData) — private void SaveAiSettings(CareerData data)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ChangeTemplate(System.Action, string, bool)`](PromptScreen.cs.md#symbol-32c868c23420)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.ConfirmPromptImport(NationalSpire.CareerData, string, System.Action)`](PromptScreen.cs.md#symbol-b9da8509093b)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ICareerSession.SaveAi(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-64829595f834)；[`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-182dc6fd73e0)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ICareerSession.SaveAi(NationalSpire.CareerData)`；`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.ICareerSession.SaveAi(NationalSpire.CareerData)`；输入表达式：`_multiplayer.SaveAi(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.SaveAi(data);`
- `NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`；输入表达式：`WeeklyJournal.ActivateLatest(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyJournal.ActivateLatest(data);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1a6f5b7e24d2"></a>

## `NationalSpire.CareerScreen.GenerateContent(System.Action, bool) — private void GenerateContent(Action single, bool retry = false)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)

**调用：** [`NationalSpire.ICareerSession.Generate(bool)`](CareerSession.cs.md#symbol-ccebd9f9e61d)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.ICareerSession.Generate(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ICareerSession.Generate(bool)`；输入表达式：`_multiplayer.Generate(retry)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Generate(retry);`
- `System.Action.Invoke()`；输入表达式：`single()`；返回值紧邻使用处：`ExpressionStatementSyntax: single();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0aab3af4bc96"></a>

## `NationalSpire.CareerScreen.RenderTeam() — private void RenderTeam()`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)

**调用：** [`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CareerTeamMember.Character`；`NationalSpire.CareerTeamMember.Detail`；`NationalSpire.CareerTeamMember.Id`；`NationalSpire.CareerTeamMember.Name`；`NationalSpire.ICareerSession.Team`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new Godot.GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Godot.GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(_tab == "结算" ? "本场队员" : "我方阵容 · 全员共同出战", 22, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(_tab == "结算" ? "本场队员" : "我方阵容 · 全员共同出战", 22, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(WithAvatar(ViewData, member.Id, Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink), 54, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(WithAvatar(ViewData, member.Id, Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink), 54, true));`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_tab == "结算" ? "本场队员" : "我方阵容 · 全员共同出战", 22, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(_tab == "结算" ? "本场队员" : "我方阵容 · 全员共同出战", 22, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(ViewData, member.Id, Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink), 54, true)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(ViewData, member.Id, Text(member.Name + " · " + member.Character + "\n" + member.Detail, 17, _ink), 54, true)`

**赋值（含属性/字段和局部值）：**

- `Columns` = `2`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-5830f879d8f9"></a>

## `NationalSpire.CareerScreen.CloseCurrent() — public static void CloseCurrent()`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-b889ef6fb033)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-dc951f669f46)

**调用：** [`NationalSpire.CareerScreen.Close()`](CareerScreen.cs.md#symbol-80dfd99fda3e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Close()`；`NationalSpire.CareerScreen.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Close()`；输入表达式：`.Close()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Current?.Close()`

**赋值（含属性/字段和局部值）：**
