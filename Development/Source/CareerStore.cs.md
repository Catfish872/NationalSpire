# CareerStore.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C5BE794CF121C2CCD1DD73D445F89BD3CF9F42FA48EE15539F722E8C13C9BD39`。来源：[源码](../../CareerStore.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerStore`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly JsonSerializerOptions Json = new()
    {
        WriteIndented = false,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.Never
    };
private static readonly object Gate = new();
private static readonly Dictionary<string, (long Length, DateTime Modified)> ValidatedFiles = new();
private static CareerData? _data;
private static string? _loadedPath;
private static readonly Dictionary<CareerData, string> Paths = new();
```

<a id="symbol-19cfb24f1d65"></a>

## `NationalSpire.CareerStore.Stamp(string) — private static (long, DateTime) Stamp(string path)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)

**调用：** `System.IO.FileInfo.FileInfo(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileInfo(path)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d324bdbc3393"></a>

## `NationalSpire.CareerStore.LoadNotice — public static string LoadNotice`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-13f62fe1c4b0"></a>

## `NationalSpire.CareerStore.DefaultPath — public static string DefaultPath`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`；`MegaCrit.Sts2.Core.Saves.SaveManager.GetProfileScopedPath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath(SaveManager.Instance.GetProfileScopedPath("national_spire_career.json"))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath(SaveManager.Instance.GetProfileScopedPath("national_spire_career.json"))`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GetProfileScopedPath(string)`；输入表达式：`SaveManager.Instance.GetProfileScopedPath("national_spire_career.json")`；返回值紧邻使用处：`ArgumentSyntax: SaveManager.Instance.GetProfileScopedPath("national_spire_career.json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb6a09449ab7"></a>

## `NationalSpire.CareerStore.NativeRunPath — public static string NativeRunPath`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`；`MegaCrit.Sts2.Core.Saves.SaveManager.GetProfileScopedPath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath(SaveManager.Instance.GetProfileScopedPath("saves/current_run.save"))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath(SaveManager.Instance.GetProfileScopedPath("saves/current_run.save"))`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GetProfileScopedPath(string)`；输入表达式：`SaveManager.Instance.GetProfileScopedPath("saves/current_run.save")`；返回值紧邻使用处：`ArgumentSyntax: SaveManager.Instance.GetProfileScopedPath("saves/current_run.save")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1b56b90e6589"></a>

## `NationalSpire.CareerStore.FilePath — private static string FilePath`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerLibrary.SelectedPath(string)`](CareerLibrary.cs.md#symbol-8caea35cd8af)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLibrary.SelectedPath(string)`；`NationalSpire.CareerStore.DefaultPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.SelectedPath(string)`；输入表达式：`CareerLibrary.SelectedPath(DefaultPath)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CareerLibrary.SelectedPath(DefaultPath)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ead7461ee7cb"></a>

## `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData) — public static bool IsCurrent(CareerData data)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Alive()`](PortraitDesignScreen.cs.md#symbol-b5e3595bf2d6)；[`Back()`](DateDiaryScreen.cs.md#symbol-178613c1e28c)；[`Current()`](AiWeekly.cs.md#symbol-aa1dd49fa9ef)；[`Current()`](PromptTesting.cs.md#symbol-d7176b5cfda3)；[`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)；[`Import(System.Action<NationalSpire.DateSceneAssets, string>, string[])`](DateSceneAssetScreen.cs.md#symbol-5d9a90f3c871)；[`ImportPackage(string, System.Action?)`](DateSceneAssetScreen.cs.md#symbol-e552da41d09b)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken)`](AiPortraitDesign.cs.md#symbol-b767cc172aa6)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`](AiWeekly.cs.md#symbol-bb0ee823dfc4)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.AiService.WaitForRequestStartAsync(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.AiWorkState>)`](AiService.cs.md#symbol-5ba7da409ec8)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)；[`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?)`](AppearanceLibraryScreen.cs.md#symbol-6c40b8e1641a)；[`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)；[`NationalSpire.CareerScreen.ConfirmPortraitEmotions(NationalSpire.CareerData, NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, System.Action<System.Collections.Generic.HashSet<string>>)`](PortraitPackageImportScreen.cs.md#symbol-af6372ed4930)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)；[`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.DateGameReturn.AfterMainMenu(System.Threading.Tasks.Task, MegaCrit.Sts2.Core.Nodes.NGame)`](DateGameReturn.cs.md#symbol-ccc3c072c00e)；[`NationalSpire.DatePresentation.Save(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.DatePresentation.Selection>)`](DatePresentation.cs.md#symbol-6b2ede6c9f6f)；[`NationalSpire.LiveRunBridge._Process(double)`](LiveRunBridge.cs.md#symbol-d7e63bc009ff)；[`NationalSpire.LiveRunBridge.RunEnded(bool)`](LiveRunBridge.cs.md#symbol-d5b5bb6d87cd)；[`NationalSpire.ProactiveChats.StartQueued(NationalSpire.CareerData)`](ProactiveChats.cs.md#symbol-67e715945068)

**调用：** `object.ReferenceEquals(object?, object?)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerStore.Data`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(Data, data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.ExternalCurrent?.Invoke() ?? ReferenceEquals(Data, data)`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.ExternalCurrent?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9724f0dac935"></a>

## `NationalSpire.CareerStore.Data — public static CareerData Data`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GD.PushWarning(string)`；`Godot.ProjectSettings.GlobalizePath(string)`；[`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-f7d8afb43e10)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-95e97a5c9007)；[`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-e83d7ef9fb98)；[`NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`](DateGames.cs.md#symbol-2c3d1fff3942)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GroupChats.Recover(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-01d7b7cae92b)；[`NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`](NpcRecords.cs.md#symbol-13b4702fac73)；[`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.PersonalityLibrary.NeedsUpgrade(NationalSpire.CareerData)`](PersonalityLibrary.cs.md#symbol-637e2f6b5119)；[`NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`](PrivateMessageCommands.cs.md#symbol-1ce050227fd9)；[`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`](PublicationBacklog.cs.md#symbol-37eb1c83d725)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-182dc6fd73e0)；[`NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-f465ec0d1539)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.DateTime.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Copy(string, string)`；`System.IO.File.Copy(string, string, bool)`；`System.IO.File.Exists(string?)`；`System.IO.File.WriteAllText(string, string?)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CameoContent.Version`；`NationalSpire.CameoState.Version`；`NationalSpire.CareerCommerce.Version`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.AvatarFrames`；`NationalSpire.CareerData.Cameos`；`NationalSpire.CareerData.ContentPoolVersion`；`NationalSpire.CareerData.ContentVersion`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.IdentityVersion`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LongSeasonsFrom`；`NationalSpire.CareerData.NpcSetupPending`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Version`；`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`；`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`；`NationalSpire.CareerLife.Version`；`NationalSpire.CareerLifeState.Version`；`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.RecruitVersion`；`NationalSpire.CareerStore.FilePath`；`NationalSpire.CareerStore.Gate`；`NationalSpire.CareerStore.Json`；`NationalSpire.CareerStore.LoadNotice`；`NationalSpire.CareerStore.Paths`；`NationalSpire.CareerStore.Read(string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerStore._data`；`NationalSpire.CareerStore._loadedPath`；`NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`；`NationalSpire.ContentPoolMigration.Version`；`NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.EsportsCareer.CommerceVersion`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.FreeAgentVersion`；`NationalSpire.EsportsCareer.Initialized`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.GroupChats.Recover(NationalSpire.CareerData)`；`NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.EconomyVersion`；`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`；`NationalSpire.PersonalityLibrary.NeedsUpgrade(NationalSpire.CareerData)`；`NationalSpire.PlayerIdentity.Version`；`NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`；`NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Store`；`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`；`NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`；`NationalSpire.WorldPeople.ContentVersion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 存档读取失败：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 存档读取失败：" + e.Message);`
- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_career.json")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProjectSettings.GlobalizePath("user://national_spire_career.json")`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(_data.Ai)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _data.Ai = AiSettingsStore.Load(_data.Ai)`
- `NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`；输入表达式：`CareerEngine.CreateNew()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _data = CareerEngine.CreateNew()`
- `NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`；输入表达式：`CareerEngine.NormalizeRoster(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: repairedContracts |= CareerEngine.NormalizeRoster(_data)`
- `NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`；输入表达式：`CareerNarrative.RepairNews(_data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerNarrative.RepairNews(_data)`
- `NationalSpire.CareerStore.Read(string)`；输入表达式：`Read(path + ".bak")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _data = Read(path + ".bak")`
- `NationalSpire.CareerStore.Read(string)`；输入表达式：`Read(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _data = Read(path)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`Save(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(_data);`
- `NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.Normalize(_data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.Normalize(_data)`
- `NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.RecoverInterrupted(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: upgradedCommunity |= CommunityThreads.RecoverInterrupted(_data)`
- `NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`；输入表达式：`DateGames.Upgrade(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: upgradedCommunity |= DateGames.Upgrade(_data)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("career.load", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("career.load", e);`
- `NationalSpire.GroupChats.Recover(NationalSpire.CareerData)`；输入表达式：`GroupChats.Recover(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupChats.Recover(_data);`
- `NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`；输入表达式：`NpcRecords.Ensure(_data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NpcRecords.Ensure(_data)`
- `NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`；输入表达式：`OwnedClubs.RepairContractRoster(_data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.RepairContractRoster(_data)`
- `NationalSpire.PersonalityLibrary.NeedsUpgrade(NationalSpire.CareerData)`；输入表达式：`PersonalityLibrary.NeedsUpgrade(_data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PersonalityLibrary.NeedsUpgrade(_data)`
- `NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`；输入表达式：`PrivateMessageCommands.Recover(_data.Life)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessageCommands.Recover(_data.Life);`
- `NationalSpire.PublicationBacklog.Compact(NationalSpire.CareerData, bool)`；输入表达式：`PublicationBacklog.Compact(_data, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: PublicationBacklog.Compact(_data, false);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Store)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Store)`
- `NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`；输入表达式：`WeeklyJournal.ActivateLatest(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: upgradedCommunity |= WeeklyJournal.ActivateLatest(_data)`
- `NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`；输入表达式：`WeeklyJournal.Recover(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: upgradedCommunity |= WeeklyJournal.Recover(_data)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_data.People.Any(p => p.Id.StartsWith("free-agent-") && p.RecruitVersion < 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: _data.Esports.OwnedClub is { EconomyVersion: < 1 } || _data.Esports.FreeAgentVersion < 2 || _data.People.Any(p => p.Id.StartsWith("free-agent-") && p.RecruitVersion < 1)`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.UtcNow.ToString("yyyyMMddHHmmss")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + ".broken-" + DateTime.UtcNow.ToString("yyyyMMddHHmmss")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(path)!);`
- `System.IO.File.Copy(string, string)`；输入表达式：`File.Copy(legacy, path)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Copy(legacy, path);`
- `System.IO.File.Copy(string, string)`；输入表达式：`File.Copy(path, path + ".pre-ecosystem1")`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Copy(path, path + ".pre-ecosystem1");`
- `System.IO.File.Copy(string, string)`；输入表达式：`File.Copy(path, path + ".pre-v4")`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Copy(path, path + ".pre-v4");`
- `System.IO.File.Copy(string, string, bool)`；输入表达式：`File.Copy(path, path + ".broken-" + DateTime.UtcNow.ToString("yyyyMMddHHmmss"), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Copy(path, path + ".broken-" + DateTime.UtcNow.ToString("yyyyMMddHHmmss"), true);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(cameoBackup)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(cameoBackup)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(legacy + ".migrated")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(legacy + ".migrated")`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(legacy)`；返回值紧邻使用处：`BinaryExpressionSyntax: !File.Exists(path) && File.Exists(legacy)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(lifeBackup)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(lifeBackup)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path + ".bak")`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(path + ".bak")) { try { _data = Read(path + ".bak"); LoadNotice = "主生涯文件损坏，已恢复最近备份。原文件已另存。"; } catch (NotSupportedException) { throw; } catch { LoadNotice = "生涯文件及备份均无法读取，已保留原文件并建立新生涯。"; } } else LoadNotice = "生涯文件无法读取，已保留原文件并建立新生涯。";`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path + ".pre-commerce1")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path + ".pre-commerce1")`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path + ".pre-ecosystem1")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path + ".pre-ecosystem1")`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path + ".pre-v4")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path + ".pre-v4")`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(path)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(path)) _data = Read(path);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: cameos && File.Exists(path)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: lifeUpgrade && File.Exists(path)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: commerce && File.Exists(path)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: expanding && File.Exists(path)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: upgrading && File.Exists(path)`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(cameoBackup, JsonSerializer.Serialize(_data, Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(cameoBackup, JsonSerializer.Serialize(_data, Json));`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(legacy + ".migrated", path)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(legacy + ".migrated", path);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(lifeBackup, JsonSerializer.Serialize(_data, Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(lifeBackup, JsonSerializer.Serialize(_data, Json));`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(path + ".pre-commerce1", JsonSerializer.Serialize(_data, Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(path + ".pre-commerce1", JsonSerializer.Serialize(_data, Json));`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(path + ".pre-ecosystem1", JsonSerializer.Serialize(_data, Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(path + ".pre-ecosystem1", JsonSerializer.Serialize(_data, Json));`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(path + ".pre-v4", JsonSerializer.Serialize(_data, Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(path + ".pre-v4", JsonSerializer.Serialize(_data, Json));`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(_data, Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(_data, Json)`
- `string.StartsWith(string)`；输入表达式：`p.Id.StartsWith("free-agent-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Id.StartsWith("free-agent-") && p.RecruitVersion < 1`

**赋值（含属性/字段和局部值）：**

- `LoadNotice` = `""`
- `LoadNotice` = `"主生涯文件损坏，已恢复最近备份。原文件已另存。"`
- `LoadNotice` = `"俱乐部与商业合作已更新。此前奖励已保留，个人赞助可重新选择。"`
- `LoadNotice` = `"新赛季将迎来团队联赛和世界总决赛。当前比赛照常进行，旧生涯已备份。"`
- `LoadNotice` = `"本季保留已公布日期，下一赛季延长至12周。公开选拔每两周举办，社区刊物改为双周刊。"`
- `LoadNotice` = `"活动与培养已更新，旧项目已核验，漏发收益会在活动记录中注明。升级前存档已备份。"`
- `LoadNotice` = `"生涯已更新，原有战绩和奖励已保留，并已备份存档。"`
- `LoadNotice` = `"生涯文件及备份均无法读取，已保留原文件并建立新生涯。"`
- `LoadNotice` = `"生涯文件无法读取，已保留原文件并建立新生涯。"`
- `Paths[_data]` = `path`
- `_data.Ai` = `AiSettingsStore.Load(_data.Ai)`
- `_data.NpcSetupPending` = `true`
- `_data.Version` = `4`
- `_data` = `CareerEngine.CreateNew()`
- `_data` = `Read(path + ".bak")`
- `_data` = `Read(path)`
- `_data` = `null`
- `_loadedPath` = `path`
- `repairedContracts` |= `CareerEngine.NormalizeRoster(_data)`
- `upgradedCommunity` |= `CommunityThreads.RecoverInterrupted(_data)`
- `upgradedCommunity` |= `DateGames.Upgrade(_data)`
- `upgradedCommunity` |= `WeeklyJournal.ActivateLatest(_data)`
- `upgradedCommunity` |= `WeeklyJournal.Recover(_data)`

<a id="symbol-bd7895ebe52b"></a>

## `NationalSpire.CareerStore.Read(string) — private static CareerData Read(string path)`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerStore.SwitchCareer(string)`](CareerStore.cs.md#symbol-67c415b86d89)

**调用：** [`NationalSpire.CareerStore.Stamp(string)`](CareerStore.cs.md#symbol-19cfb24f1d65)；[`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.IO.File.ReadAllText(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.NotSupportedException.NotSupportedException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.LongSeasonsFrom`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.NpcPersonalityPool`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerData.Version`；`NationalSpire.CareerStore.Json`；`NationalSpire.CareerStore.Stamp(string)`；`NationalSpire.CareerStore.ValidatedFiles`；`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Stamp(string)`；输入表达式：`Stamp(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ValidatedFiles[path] = Stamp(path)`
- `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；输入表达式：`PersonalityPools.Validate(data.NpcPersonalityPool)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityPools.Validate(data.NpcPersonalityPool);`
- `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.End(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day > SeasonCalendar.End(data)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day <= SeasonCalendar.Start(data)`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯存档为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("生涯存档为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯数据结构不完整。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("生涯数据结构不完整。");`
- `System.NotSupportedException.NotSupportedException(string?)`；输入表达式：`new NotSupportedException("生涯文件来自更新版本，请更新模组后再打开。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new NotSupportedException("生涯文件来自更新版本，请更新模组后再打开。");`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<CareerData>(File.ReadAllText(path), Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<CareerData>(File.ReadAllText(path), Json) ?? throw new InvalidDataException("生涯存档为空。")`

**赋值（含属性/字段和局部值）：**

- `ValidatedFiles[path]` = `Stamp(path)`

<a id="symbol-ad8f6e4706a1"></a>

## `NationalSpire.CareerStore.Save(NationalSpire.CareerData?) — public static void Save(CareerData? data = null)`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ChooseCharacter(int)`](CareerScreen.cs.md#symbol-2e29f360fdfb)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessNewsAsync(string?, NationalSpire.CareerData?)`](AiService.cs.md#symbol-1773c3383336)；[`NationalSpire.AiService.ProcessNewsBatchAsync(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiService.cs.md#symbol-483c895c168a)；[`NationalSpire.AiService.ProcessWeeklyAsync(NationalSpire.CareerData?)`](AiWeekly.cs.md#symbol-bb0ee823dfc4)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)；[`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CareerEngine.AdvanceOneDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-5b81bcd72cc1)；[`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)；[`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-efe3762d8665)；[`NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`](CareerNames.cs.md#symbol-68b4cb4672cb)；[`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`](DateGameScreen.cs.md#symbol-ad300bbb552d)；[`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-5700a0d050b5)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.RandomEventSettings()`](RandomEventScreen.cs.md#symbol-6c1195d3802b)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderTeamPreparations(NationalSpire.CareerData)`](TeamPreparationScreen.cs.md#symbol-57b7570c5a7d)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-485b9c9c8acb)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)；[`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-b15d2f44132b)；[`NationalSpire.CareerStore.SwitchCareer(string)`](CareerStore.cs.md#symbol-67c415b86d89)；[`NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](CharacterCards.cs.md#symbol-4bce7f6af16c)；[`NationalSpire.CircuitWorld.ReplayTie(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CircuitWorld.cs.md#symbol-561246434113)；[`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.SetPlayerCoach(NationalSpire.CareerData, bool)`](ClubCoaching.cs.md#symbol-fa4109028289)；[`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-68aeffe9f915)；[`NationalSpire.ClubDeparture.Leave(NationalSpire.CareerData)`](ClubDeparture.cs.md#symbol-1579a5b3a3c8)；[`NationalSpire.CommunityThreads.MarkProgramRead(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-7398f6d1a869)；[`NationalSpire.CommunityThreads.MarkRead(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-d891e2f0e3ea)；[`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`](CommunityThreads.cs.md#symbol-4de765d004ff)；[`NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`](EconomicActions.cs.md#symbol-d99b9fe32a07)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.GameBridge.ReleaseMissingRun()`](GameBridge.cs.md#symbol-0d1c45a81336)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；[`NationalSpire.IdentityGender.SetPlayer(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-449fc02b003e)；[`NationalSpire.LiveRunBridge._Ready()`](LiveRunBridge.cs.md#symbol-26fa8bae2af0)；[`NationalSpire.LiveRunBridge.EnsurePlan(ref bool)`](LiveRunBridge.cs.md#symbol-0dd1ac28e6cd)；[`NationalSpire.LiveRunBridge.FinishCombat()`](LiveRunBridge.cs.md#symbol-1e798ae2b209)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-e97dde3c003f)；[`NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-a1b523b0541a)；[`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)；[`NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-2a700a81b2ac)；[`NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-98b9722b6128)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-b24bb65463ab)；[`Save()`](NpcAvatarFrameScreen.cs.md#symbol-a1802dcac073)；[`Vote(int)`](CommunityScreen.cs.md#symbol-8f211a670431)

**调用：** [`NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-ba3b31b1bb7c)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.CareerStore.Stamp(string)`](CareerStore.cs.md#symbol-19cfb24f1d65)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`object.ReferenceEquals(object?, object?)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Copy(string, string, bool)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerStore._data`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Gate`；`NationalSpire.CareerStore.Json`；`NationalSpire.CareerStore.Paths`；`NationalSpire.CareerStore.Read(string)`；`NationalSpire.CareerStore.Stamp(string)`；`NationalSpire.CareerStore.ValidatedFiles`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiSettingsStore.Save(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Save(data.Ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiSettingsStore.Save(data.Ai);`
- `NationalSpire.CareerStore.Read(string)`；输入表达式：`Read(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Read(path)`
- `NationalSpire.CareerStore.Stamp(string)`；输入表达式：`Stamp(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ValidatedFiles[path] = Stamp(path)`
- `NationalSpire.CareerStore.Stamp(string)`；输入表达式：`Stamp(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: stamp != Stamp(path)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("career.save", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("career.save", e);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_data, data)`；返回值紧邻使用处：`IfStatementSyntax: if (ReferenceEquals(_data, data)) AiSettingsStore.Save(data.Ai);`
- `System.Action<T>.Invoke(T)`；输入表达式：`detached(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: detached(data);`
- `System.Action<T>.Invoke(T)`；输入表达式：`external(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: external(data);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Paths.TryGetValue(data, out var path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Paths.TryGetValue(data, out var path)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`ValidatedFiles.TryGetValue(path, out var stamp)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ValidatedFiles.TryGetValue(path, out var stamp)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("生涯未绑定存档路径。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("生涯未绑定存档路径。");`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(path)!);`
- `System.IO.File.Copy(string, string, bool)`；输入表达式：`File.Copy(path, path + ".bak", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Copy(path, path + ".bak", true);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(path))                  {                      try                      {                          if (!ValidatedFiles.TryGetValue(path, out var stamp) || stamp != Stamp(path)) _ = Read(path);                          File.Copy(path, path + ".bak", true);                      }                      catch (InvalidDataException) { /* 已损坏的主文件不能覆盖正常备份。 */ }                      catch (JsonException) { /* 已损坏的主文件不能覆盖正常备份。 */ }                  }`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temp, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temp, path, true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(temp, JsonSerializer.Serialize(data, Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temp, JsonSerializer.Serialize(data, Json));`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(data, Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(data, Json)`

**赋值（含属性/字段和局部值）：**

- `_` = `Read(path)`
- `data` ??= `Data`
- `ValidatedFiles[path]` = `Stamp(path)`

<a id="symbol-291d6faecac3"></a>

## `NationalSpire.CareerStore.ResetCareer() — public static CareerData ResetCareer()`

来源：源码第 169 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-b15d2f44132b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ai`；`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`；输入表达式：`CareerEngine.CreateNew()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.CreateNew()`
- `NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`；输入表达式：`ReplaceFreshCareer(fresh)`；返回值紧邻使用处：`ReturnStatementSyntax: return ReplaceFreshCareer(fresh);`

**赋值（含属性/字段和局部值）：**

- `fresh.Ai` = `Data.Ai`

<a id="symbol-b15d2f44132b"></a>

## `NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData) — public static CareerData ReplaceFreshCareer(CareerData fresh)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerStore.ResetCareer()`](CareerStore.cs.md#symbol-291d6faecac3)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.DateTime.ToString(string?)`；`System.IO.File.Copy(string, string, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Gate`；`NationalSpire.CareerStore.Paths`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerStore._data`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`Save(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(_data);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`Save(old)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(old);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`Paths.Remove(fresh)`；返回值紧邻使用处：`ExpressionStatementSyntax: Paths.Remove(fresh);`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + ".reset-" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")`
- `System.IO.File.Copy(string, string, bool)`；输入表达式：`File.Copy(path, path + ".reset-" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Copy(path, path + ".reset-" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"), false);`

**赋值（含属性/字段和局部值）：**

- `Paths[_data]` = `path`
- `_data` = `fresh`
- `_data` = `old`

<a id="symbol-67c415b86d89"></a>

## `NationalSpire.CareerStore.SwitchCareer(string) — public static CareerData SwitchCareer(string path)`

来源：源码第 189 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.CareerLibrary.Select(string, string)`](CareerLibrary.cs.md#symbol-e83d55812872)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-7f4fa41ad4c0)；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.Path.GetFullPath(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerLibrary.Select(string, string)`；`NationalSpire.CareerStore._data`；`NationalSpire.CareerStore._loadedPath`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.DefaultPath`；`NationalSpire.CareerStore.Gate`；`NationalSpire.CareerStore.Paths`；`NationalSpire.CareerStore.Read(string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.Select(string, string)`；输入表达式：`CareerLibrary.Select(DefaultPath, path)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLibrary.Select(DefaultPath, path);`
- `NationalSpire.CareerLibrary.Select(string, string)`；输入表达式：`CareerLibrary.Select(DefaultPath, previousPath)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLibrary.Select(DefaultPath, previousPath);`
- `NationalSpire.CareerStore.Read(string)`；输入表达式：`Read(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Read(path)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`Save(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(previous);`
- `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Locked(Data)`；返回值紧邻使用处：`ArgumentSyntax: MatchFailure.Locked(Data)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(MatchFailure.Locked(Data))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(MatchFailure.Locked(Data));`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFullPath(path) == Path.GetFullPath(Paths[previous])`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(Paths[previous])`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFullPath(path) == Path.GetFullPath(Paths[previous])`

**赋值（含属性/字段和局部值）：**

- `_` = `Read(path)`
- `_data` = `null`
- `_data` = `previous`
- `_loadedPath` = `null`
- `_loadedPath` = `previousPath`

<a id="symbol-1b17c0b3af7f"></a>

## `NationalSpire.CareerStore.DeleteCareer(string, string) — public static void DeleteCareer(string original, string path)`

来源：源码第 213 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.CareerLibrary.Delete(string, string)`](CareerLibrary.cs.md#symbol-261c89b42954)；`string.Equals(string?, string?, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.Path.GetFullPath(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerLibrary.Delete(string, string)`；`NationalSpire.CareerStore._data`；`NationalSpire.CareerStore._loadedPath`；`NationalSpire.CareerStore.Gate`；`NationalSpire.CareerStore.Paths`；`NationalSpire.CareerStore.ValidatedFiles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLibrary.Delete(string, string)`；输入表达式：`CareerLibrary.Delete(original, path)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLibrary.Delete(original, path);`
- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(path, Path.GetFullPath(_loadedPath), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: _data != null && _loadedPath != null && string.Equals(path, Path.GetFullPath(_loadedPath), StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`Paths.Remove(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Paths.Remove(data);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`ValidatedFiles.Remove(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: ValidatedFiles.Remove(path);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Paths.Where(p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)).Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Paths.Where(p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)).Select(p => p.Key).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Paths.Where(p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)).Select(p => p.Key).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var data in Paths.Where(p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)).Select(p => p.Key).ToArray())              {                  data.ExternalCurrent = () => false; data.ExternalSave = _ => { };                  Paths.Remove(data);              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Paths.Where(p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Paths.Where(p => string.Equals(Path.GetFullPath(p.Value), path, StringComparison.OrdinalIgnoreCase)).Select`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先切换到另一份生涯，再删除当前生涯。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先切换到另一份生涯，再删除当前生涯。");`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(_loadedPath)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFullPath(_loadedPath)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(p.Value)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFullPath(p.Value)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: path = Path.GetFullPath(path)`

**赋值（含属性/字段和局部值）：**

- `data.ExternalCurrent` = `() => false`
- `data.ExternalSave` = `_ => { }`
- `path` = `Path.GetFullPath(path)`

<a id="symbol-bdb986450a1c"></a>

## `NationalSpire.CareerStore.ExportDiagnostics() — public static string ExportDiagnostics()`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)

**调用：** [`NationalSpire.AiSettingsStore.ReadKey(string)`](AiSettingsStore.cs.md#symbol-ca446a961f94)；[`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`](Diagnostics.cs.md#symbol-a22f068c4d41)；[`NationalSpire.Diagnostics.RegisterSecret(string?)`](Diagnostics.cs.md#symbol-4f621c46a4ca)；`Godot.ProjectSettings.GlobalizePath(string)`；`System.Environment.GetEnvironmentVariable(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.Status`；`NationalSpire.AiSettingsStore.ReadKey(string)`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Gate`；`NationalSpire.CareerStore.Paths`；`NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`；`NationalSpire.Diagnostics.RegisterSecret(string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://logs")`；返回值紧邻使用处：`ArgumentSyntax: ProjectSettings.GlobalizePath("user://logs")`
- `NationalSpire.AiSettingsStore.ReadKey(string)`；输入表达式：`AiSettingsStore.ReadKey()`；返回值紧邻使用处：`ArgumentSyntax: AiSettingsStore.ReadKey()`
- `NationalSpire.Diagnostics.Export(NationalSpire.CareerData, string, string, string, object?, System.Collections.Generic.IReadOnlyDictionary<string, string>?)`；输入表达式：`Diagnostics.Export(data, Paths[data], ProjectSettings.GlobalizePath("user://logs"), AiService.Status)`；返回值紧邻使用处：`ReturnStatementSyntax: return Diagnostics.Export(data, Paths[data], ProjectSettings.GlobalizePath("user://logs"), AiService.Status);`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(AiSettingsStore.ReadKey())`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(AiSettingsStore.ReadKey());`
- `NationalSpire.Diagnostics.RegisterSecret(string?)`；输入表达式：`Diagnostics.RegisterSecret(System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RegisterSecret(System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY"));`
- `System.Environment.GetEnvironmentVariable(string)`；输入表达式：`System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY")`；返回值紧邻使用处：`ArgumentSyntax: System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY")`

**赋值（含属性/字段和局部值）：**
