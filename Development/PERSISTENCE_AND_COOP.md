# 保存、广播与恢复

通讯模型快捷选择沿 SaveAiSettings 保存：单人使用现有 CareerStore/AiSettingsStore 路径，联机房主使用 CoopCareerSession.SaveAi，客机按钮沿原权限禁用。聊天导出只读取当前玩家视图和当前会话，将正文写入独立 Markdown 文件；存档、记忆、分页与广播保持原状。

## 自动保存诊断入口
性格池编辑及总提示词合并导入沿现有 SaveAiSettings 保存设备模板；总提示词预览显示类别与具体性格数量，保存失败恢复原模板、覆盖、事件池、性格池及 PrivatePromptVersion，导入窗口保持可重试。新世界独立持有 NpcPersonalityPool，人物快照沿原 CareerPerson.Personality 与 CharacterCards 命令保存和广播。单人初始生成采用 ReplaceFreshCareer：先保存备份旧数据，再写入完整新世界，写入异常恢复原内存数据。存档创建窗口先安装导入设计，整份生涯保存后提交安装；切换失败时已保存的新档继续拥有完整设计资料。

“配置新世界”将上一生涯 AiOptions 复制为窗口草稿，模板切换沿 SelectTemplate 保留各模板覆盖。NpcGeneration.ApplySettings 共用于单人与房主新世界：比赛水平沿 MatchRules.SetRivalLevel，AI 配置保持独立副本，并将新世界最终选定的 setup.Pool 深复制到 AiOptions.PersonalityPool，以便总提示词导出与实际开档设置一致。旧生涯人物快照保持原归属。ReplaceFreshCareer 保留传入新世界的配置，旧 ResetCareer 入口显式继承原配置；新建另一生涯在原 SwitchCareer 完成后应用并保存所选设置。联机首次保存共同世界后保存房主本机 AI 配置，公开广播沿 CoopJson 的既有过滤。密钥填入后仅交给 AiService.PersistKey；其他方案与任务路由保留，旧存档读取和恢复检查点路径保持原有行为。

联机新建由房主展示 NpcGenerationScreen 并通过 CoopRuntime.Connect 传入临时配置；新世界的玩家姓名经 NpcGeneration.ResolvePlayerName 交给 CoopRules.Create 的 playerName 和 CoopCoordinator 的 name，队伍名称仍保存在共同世界 PlayerAlias。恢复检查点及加入房间继续使用原成员流程。CoopRules.Create 仅接收池与稳定世界 ID，保持规则层独立于本地文件读取。PNG/ZIP 批量导入在 Runtime 使用 NpcGeneration.ImportBatch，协调器首次 Commit 保存世界后提交 Installation，连接失败且尚未持久化时回滚设计绑定。恢复检查点沿旧入口跳过初始配置。共同世界广播所生成人物的性格快照；立绘图片延续本机资产库机制，客机需自行导入对应素材。联机窗口等待异步连接完成，失败时保留配置与文件清单，取消会调用 CancelConnection 并释放临时窗口。用户关闭配置窗口、取消或输入校验失败时当前生涯保持原记录。



CoopSaveEntryPatch 在原版 RunSaveManager.SaveRun(AbstractRoom) 前记录 ShouldSave、网络类型、尝试编号及当前阶段，使原版因 ShouldSave 跳过下层保存的情况也留下入口证据。该补丁只观察入口。原 CoopSavePatch 仍拦截 SerializableRun 的联机保存并调用 CoopNativeRun.Save。Save 对客机、对局不存在和暂停分别记录跳过原因；正式保存前记录旧检查点字节数、实际章节、运行秒数、访问地图坐标数和各玩家生命，ValidateRun 后编码一次、Commit 一次，成功后记录新字节数、哈希及 Revision。诊断失败由 Diagnostics 自身处理，比赛的保存和广播顺序沿用原实现。

2026-10-21 本机两个独立 Godot 进程使用真实原版对局、Harmony 保存入口和 ENet，房主25项、客机7项通过。两次地图推进为130.2374和260.1274毫秒，均包含原版操作、同步和保存等待，Revision 各增加1；此次未单独测量内部步骤及分配量。入口、实际保存前和提交后记录均存在。测试没有加载报告者第三方角色模组，也没有验证 Steam 跨机重连；报告者返回首层的原始原因仍待对应现场。原始记录保留在本地 .artifacts/log-stress-20261021-c/native-save。

事件池配置沿 AiOptions.EventPoolOverrides 保存，编辑器一次保存调用一次 SaveAiSettings。单人 CareerStore.Save 成功保存当前生涯后更新 AiSettingsStore；多人 SaveAi 先保存房主本机 AI 配置，再递增世界 Revision 并沿原 Commit 广播公开状态。配置不新增网络消息类型，整池按现有 AiOptions 公开过滤保留在房主本机。WorldEvents.PublishDaily 经 EventPools.Get(CareerData) 读取素材：共同世界采用房主本机配置，单人采用当前 data.Ai。个人随机事件命令沿 CoopRandomEvents 的房主配置建立 Seed、Category、Materials，再通过原成员状态保存与事件流式回复。退出重进和断线重连使用已保存事件分类，修改模板影响后续首次抽取。旧配置缺少覆盖字段时默认空字典，旧事件缺少 Category 时按原内置 Seed 映射背景。失败恢复配置与草稿的顺序见 GAME_AND_UI。

## 随机事件的个人资料与共同效果

随机事件详细诊断由执行模型请求的设备在本机保存，房主代成员执行时保存在房主。RequestPrivateAsync 在 task:event 请求前和请求结束各写入一次完整诊断，原生成、保存和广播次数沿用现有流程。CapturePeerLogs 收集普通五份日志、随机事件、当前世界的比赛记录、会话记录及最近五份原版游戏日志全文；现场字段及轮换见 DATA_CONTRACTS 的随机事件诊断记录。

CoopCoordinator.CollectDiagnostics 重复点击复用正在进行的同一任务。房主向在线成员发送 diagnostics-request；成员在游戏线程调用 CaptureDiagnostics 一次，后台序列化、脱敏、压缩并缓存该次分片。Tick/PumpDiagnostics 每次发送一个24000字节分片。房主每三秒请求尚缺分片，成员复用缓存重发；完整收到后后台校验、解压、读取与脱敏，主线程 Tick 发布报告。诊断专用 CoopAssembler 使用既有分片格式，完整报告按实际大小组装，普通业务同步的原有容量条件继续由其独立分支处理。缺片和损坏片在诊断通道内重试，日志记录真实错误；游戏同步状态继续按原流程运行。

默认收集在成员保持在线时继续等待；调用者可显式提供 timeout。离线、关闭会话或切换 Epoch 后，已收集报告及未收集成员状态一并输出。完成后 diagnostics-done 清理成员缓存，协调器 Dispose 调用 CloseDiagnostics；房主 finally 等待解码任务后清理组装、报告和后台任务引用。一次报告会暂存完整字节数组和分片，内存随本次报告大小增加，收集结束释放引用；这不是常量内存的流式 ZIP。导出只读当前保留范围，实际磁盘或网络故障写入报告状态。

共同 World.Journey 保存原目的日期及随机事件暂停日，通过原世界快照同步；成员 View 从 World 复制该字段，事件故事仍属于各成员。ExecuteProposal 每推进一天按比赛和活动优先、途中事件其次的顺序停止；继续行程复用 propose-advance，沿原权限执行。CoopAi 在建立新自动发布任务及下一轮处理前检查暂停日，已开始的任务继续完成。关闭或重启后暂停规则随保存恢复；成员进入事件、留在当日与继续原行程均使用共同日期。

RandomEventRecord 归成员 Life.RandomEvents，保存日期、状态、素材、人物、Materials及PublicPosts材料快照、故事、思维文字、选项、选择编号、公开选择及约战结果凭证，也保存 CustomAction/CustomState/CustomOption/CustomReasoning。CoopRules.EventCommand 在现有权威副本上建立个人 View，执行 Start/Stop/Skip/Choose/Custom/ChooseCustom，再 Capture。event-settings复用原命令：Target为enabled/disabled，Number为最小间隔，Text为最大间隔的十进制整数。房主从已核实发送者建立个人View，调用SetFrequency再Capture，只更新该成员Life；沿原Apply/Commit保存和广播。StartEvent只接收event-start/event-custom，设置命令产生零次AI请求。设置由成员快照及检查点恢复，重新连接后各自保留。event-custom 的 Text 为玩家行动，event-custom-choose 的 Text 为 public/private。Stop 取消同一成员事件请求并恢复旧选项，后续响应按 generating 状态检查放弃。两种选择命令都将新比赛、市场及国家建设同步回 World；钱包、库存、关系及经历归成员 Life。保存沿 Apply → Commit 递增操作版本并广播。

CoopCoordinator.StartEvent 接受 event-start 与 event-custom；Current 读取发起人的最新视图，Save 核对世界、epoch及首次或自定义 generating 状态，只将同一事件的结果合入当前成员。每次完成或失败复制一次世界、递增一次 Revision，调用原 Commit。SceneLines 与随机事件 EventLive 使用 private-chunk；随机事件用 event:编号区分，仅发送发起人，包含正文、选项、Reasoning 和 Phase。客机在 State=generating 或 CustomState=generating 时接收事件分片。分片属于内存显示，完整结果通过原快照保存与接收流程落盘。旧版分片缺省空 Reasoning 与排队阶段。public 偏好属于本机 ChatPreferences，按生涯键保存；最终选择的 Public 随事件进入成员快照。CustomEventCoopChecks 的真实双协调器、内存网络与磁盘检查点11项通过：续写流式、一次请求、个人隔离、确认前余额、进程重建后恢复及重发去重；Steam网络未实测。

PrivateSnapshot 与 SnapshotEncoder 同时清除共同 World.Life 和其他成员的 RandomEvents；收件人保留自己的故事及材料。四名成员分别编码、解码的隔离检查通过。真实 Steam 跨机延迟及断线重连未在本次实测。关闭进程后未完成事件保留材料供重试；complete 与 Selected 保证已完成事件重复点击只读取结果。

## 数量购买、会话管理与主动联系

训练完成的 CompletionDay / CompletionOrder 与 CoachTrainingPlan 一起序列化。单人 CareerLife.Advance 调用 ClubCoaching.Advance；多人 AdvanceMembers 在成员视图执行生活结算，Capture 合并 Esports.CoachTraining 和经营者 OwnedClub，并更新共享 Chats.Order。后续完整快照及检查点包含完成位置，界面按所属会话训练编号读取。训练结算复用原保存和广播步骤。双协调器经内存传输与实际磁盘检查点验证房主、客机、重新载入的完成顺序一致；真实 Steam 跨机传输待测。

group-rename：单人 CareerScreen.GroupCommand → GroupChats.Command → CareerStore.Save → 成功回调更新管理窗口 → 列表/群聊签名失效；多人 ICareerSession.Send → CoopRules.GroupCommand 在成员视图执行同一入口 → CaptureGroup → 原提交、检查点、完整广播和回执。名称与通知共同提交。保存异常沿现有界面状态显示，单人内存沿原保存流程保留，重新启动读取成功保存的快照。生成中的 ProcessGroupAsync 在发送完成、流式顺序预留及失败收尾时通过 Current 取得最新群数据，再保存回复，保留期间的改名。离开界面后原生成任务继续；切换生涯/房间沿原世界及 epoch 检查，断线后的名称与通知由检查点恢复。改名自身创建一条通知及字符串，复用原单人保存或多人事务副本和完整快照；新增后台任务及模型请求次数均为0。

consumer-attach/consumer-reserve/consumer-remove 沿原 ICareerSession.Send → CoopRules.Apply 在成员 View 调用 ConsumerAttachments.Prepare/Remove → Capture → Commit，保存后才回执、编码及广播。consumer-reserve 使用 buyMissing=false，只预留本人已有库存；它与 consumer-remove 作为通信操作允许部分队员离线及比赛进行中执行。consumer-attach 保留原购买条件：2—4位在线队员且当前比赛结束。付款、库存预留量、临时数量、购物事实与成员钱包在同一次世界提交中完成。原命令收据处理重发，附件编号校验归属、状态和内容；其他成员视图缺少原预留记录时拒绝赠礼结算，保持各自库存。

单人添加与移除附件均沿 EconomicActions.Save 复制一次生涯并保存一次；Prepare 使用附件副本，保存失败恢复原 Life、钱包及库存，界面继续保留原草稿供重试。确认添加前只编辑弹窗草稿；成功后 ReservedQuantity 与 draft 一起保存，取消或拒绝归还，接受核销。切换会话或重新打开时 RestoreConsumerDrafts 按人物/群聊和 draft 状态恢复。主客机断线恢复读取同一检查点，切换存档重新绑定对应 ConsumerState；未发送即时附件下一天过期，非即时预留及已发送/接受附件沿各自生命周期保留。

consumer-buy 由 CoopRules.Apply 在世界副本上创建成员视图，将 ConsumerOrder.Quantity 传入 ConsumerEngine.Buy，成功后 Capture 提交本人 Life.Consumer、余额与事件；库存随原快照序列化。私聊模型保存回调除 Mailbox/Relationships 外同步该成员 Consumer，使 Gift 的扣除和原回复一起提交。群聊使用 CaptureGroup 提交当前成员数据和共享 Chats，并合并 PrivateMemorySources 中其他真人信箱的实际修改。

dm-proactive/dm-manage 与 group-proactive/group-manage 使用原命令、事务副本和回执。AdvanceMembers 在各成员个人视图触发主动联系；Settle 在正式赛后按各成员配置触发，并将 Chats 与个人 Life 合并。房主 Tick 的 StartProactiveChats 将已有 queued 轮次交给 StartPrivate/StartGroup；原互斥、保存、流式广播、退出和重连入口继续管理生成。

专项验证使用两个真实 CoopCoordinator、内存传输与实际 CoopStorage 磁盘检查点：客机购买5件物品、配置30/45/10概率及4次上限、开启私聊及群聊 FinalAlwaysReply、隐藏会话、关闭两端后重新载入、重连与恢复会话，共17项检查通过。私聊设置、创建群聊、群聊设置从客机提交至接收完成分别246.97、285.90、269.15毫秒，含规则副本、磁盘、编码及接收，分配分别78061952、77882792、77775856字节；这些整体时间包含内部步骤。两个实例均在本机，Steam跨机网络留待联机实测。

单人当季首发调整经 SetPlayerPosition → UpdateLineup → InvalidateForecast → CareerStore.Save 执行。生产保存继续写临时文件、保留有效备份并替换目标文件；本次实测使用隔离绑定文件。名单调整在保存前发生，保存异常沿原 CareerStore 抛出并记录，内存保持该次调整；重新启动读取最近成功保存的文件。单人岗位功能沿原 PlayerFeatures 范围提供，设置界面与 OwnedClubs.Command 共用该入口。旧下一季预约继续由原 SeasonStart 处理。

## 退出俱乐部

单人 ClubLeaveDialog 确认时读取最新 ViewData，经 ClubDeparture.Error 后调用 Leave：移交原队 → 清除真人归属、合同及相关安排 → Replenish → RefreshClub → 刷新邀请及训练预测 → AddEvent → 一次 CareerStore.Save。随后清除本页建队草稿、恢复阵容分区并 Render。取消只关闭窗口；离开页面或关闭进程后读取最近保存的归属。保存沿用原临时文件、备份和替换步骤，实际写入异常继续沿原保存入口处理；本功能没有增加独立存储或恢复机制。

多人同一按钮提交 propose-leave-club，复用 CoopRules.Apply 的房主权限、在线人数、当前对局、会话版本、收据和提议规则。房主建立全队离队提议，所有参与者确认后由 ExecuteProposal 调用同一 ClubDeparture.Leave，个人钱包继续保存在各 CoopMember。命令规则在原世界副本执行；Detached 保存回调继续交给协调器，成功后沿原 Commit 检查点 → 回执 → 完整广播 → 客机检查点 → 刷新顺序完成。各 CareerClub.Transfers 随原快照持久保存。重复确认使用原收据，取消保留原俱乐部，断线恢复使用最新成功保存的检查点。

验证覆盖两个真实 CoopCoordinator、内存传输、双方实际磁盘检查点、关闭并重建协调器、客机重连及再次接受合同；2人和4人的提议、取消、全员确认由规则检查覆盖。真实 Steam 跨机发送待实测。生产 CareerStore 的隔离文件保存、Read 重新读取、备份和再签约均通过；具体耗时见本地 PERFORMANCE 的退出俱乐部章节。

## 结算对阵详情

单人 FinishMatch 在原赛果与同日比赛完成后调用 SettlementRecords.Capture，将 CompetitionScore.Duels 连同 SettlementRecord 写入 CareerResult；末尾沿原 CareerStore.Save 提交。多人 CoopRules.Settle 仍为各成员生成结算快照，随后沿原成员资料合并、检查点、回执和广播提交。新字段随现有 JSON 对象读取与复制，版本标识继续使用现有发布版本，比赛编号继续使用原 FixtureKey。

页面通过 ScoreDuels 读取持久化详情，旧格式补充使用本次渲染的临时字典。打开、展开和切换对阵的保存与广播次数为零。离开页面后释放局部详情；切换存档后从目标生涯读取对应快照；推进日期后历史详情继续沿用结算时数据。进程关闭及断线沿原已提交生涯和多人检查点恢复。新字段的 JSON 往返、后续原资料变更隔离及原赛事清理已通过规则专项；实际跨机发送、接收及断线恢复耗时待实测。

## 聊天页面的本地设置

ChatHistoryScreen 使用 Godot ConfigFile 读取 user://NationalSpire_chat.cfg，进程内首次打开通讯读取一次；WorldId:本机玩家编号分区保存 last、size 与 pins。pins按最近置顶在前保存人物编号或group:群编号，置顶操作写入本机配置一次，生涯保存及网络广播次数为0。选择会话及改变页大小时比较当前值，发生变化才保存一次。翻页与滚动在本机内存完成。配置写入失败记录 Godot 警告，当前界面继续使用已选择值。重新打开恢复最近私信或群聊，随后进入最新页面；查看私聊人物或群成员档案后的Back从导航历史恢复对应会话、页面及滚动位置。

私信状态按钮及其右侧说明归当前身份控件，点击仅修改可见性，重建时收起；私信关系/好感按钮共用的人物详情展开设置归本机聊天配置；底栏居中状态、保留中心的按钮缩放占位、输入框放大状态与表情面板归当前通讯窗口。点击人物详情写入本机聊天设置一次；生涯保存与业务广播次数为0。放大/还原输入框、切换表情分类及插入的专用保存/广播次数为0；插入通过原TextEdit与草稿字典保留文字。私信与群聊共用表情入口及当前分类，关闭通讯清空训练详情展开集合并释放表情控件，人物详情展开状态由本机配置保留，原文字及附件草稿继续沿CareerScreen生命周期管理。头像与姓名打开档案共用OpenPrivatePerson，先将当前私聊人物、页码、滚动值写入本机Location，再保留输入草稿并沿关闭通讯和Visit入口跳转。返回沿OpenPrivateMessages及SelectPrivate恢复，读取和保存调用仍使用原偏好与已读入口。该布局改动沿用现有存档结构与房主/客机命令、检查点流程；真实联机交互与分阶段耗时仍待验证。

PrivateCommand / GroupCommand 继续负责发送、交互与已读。已读只在最新页面调用原 dm-read / group-read；单人进入 CareerStore.Save，多人进入 ICareerSession.Send 与原房主提交、检查点和回执流程。最近会话选择通过上述本地配置保存，旧 dm-select 命令保留在规则与网络兼容入口。记录分页只选择控件使用的原轮次引用，生涯原文、总结及模型上下文仍由原存储与生成流程处理。调用与缓存生命周期见[聊天分页](GAME_AND_UI.md#私信与群聊历史分页)。

社区分享选择框及待发community-quote由当前CareerScreen管理，确认人物后保存到该人物的附件草稿，输入正文继续使用原独立草稿。打开私聊沿OpenPrivateMessages及原通讯已读、本地选择配置入口执行；Create和Prepare只整理引用数据。SendPrivate通过原PrivateCommand发送，PrivateMessageCommands.Apply在dm-send调用PrepareAttachments，以当前单人数据或房主的成员个人视图重新查找来源，并在全部附件通过校验后写回社区引用。原封禁、正在生成及比赛失败校验继续由既有私信入口处理。实际轮次沿原一次命令保存、队列保存和生成完成保存；新增专用保存或独立请求为0。

多人继续使用原dm-send命令、身份检查、个人信箱归属及PrivateSnapshot过滤。客户端提交的来源编号由房主当前资料重新查找，作者、正文、父链和AI材料从该资料生成。已发送引用随PrivateTurn.Attachments保存和同步；发送前来源消失时返回原命令错误并保留待发引用，发送后来源变化或删除保留历史快照。重试、重新生成及删除用户消息/清空会话沿原附件处理规则执行。具体字段和旧档默认值见[聊天、总结与交互](DATA_CONTRACTS.md#聊天总结与交互)。

分享专项域验证加载与最终生产DLL相同的程序集，以内存保存/传输替身确认发送权威重建、引用整体校验失败保留原快照、历史来源删除后保留引用、用户正文编辑与删除NPC回复保留引用、删除用户消息/清空会话移除附件、重试/再生成沿用固定引用。生产PrivateSnapshot/CoopJson在合成世界中验证本人成员信箱保留、其他成员及世界信箱过滤、PrivateMemorySources序列化忽略，以及知情NPC的私聊材料范围。完整私信生成记录两次内存保存回调；辅助函数单测保存和HTTP均为0。实际生涯文件写盘、跨机接收与网络重连的分享恢复效果留待游戏实测，数据和边界见[社区讨论树与回复入口](GAME_AND_UI.md#社区讨论树与回复入口)。

社区举报由ReportDiscussion先显示作者、原文和来源帖的确认弹窗；打开与取消产生0次保存、0次业务请求，社区编辑器正文及选区保留。确认时重读来源并核对作者、正文、NPC可聊状态与比赛失败锁；成功后关闭弹窗、打开作者私聊，调用PrivateCommand(dm-arbitrate)，Text携带确认框原因；非空白原因经Enqueue保存为PrivateTurn.User，空白输入由命令端填入默认举报说明；社区、私聊正文和附件草稿保留各自原存储。权威PrivateMessageCommands.Apply检查在途请求、比赛失败锁与来源，CommunityReporting.Create完成案件快照后建立一个queued轮次。命令沿既有保存入口提交，后台开始保存sending及Context，完成保存裁决/致歉/Reasoning；举报快照构建本身执行0次保存、0次HTTP。离开页面后队列继续遵守既有current与轮次校验，切换生涯时旧异步结果沿原检查失效。停止或关闭进程后的Recover将轮次标为failed并保留Request，重试继续使用原案件快照；删除申请后重试要求重新提交。

在合作存档里仍只举报NPC内容；沿既有dm-arbitrate命令，房主从成员View的权威帖子重建案件，再Capture到申请成员Life.Mailbox。Request与Context随个人信箱过滤；公开ArbitrationRecord及其处罚继续按原Merge进入人物档案。合成房主/客机命令验证目标绑定、权威正文覆盖、回执去重与PrivateSnapshot仅保留收件人信箱。真实联机发送、接收、检查点写盘与断线恢复尚待游戏环境验证；计时及边界见[社区讨论树与回复入口](GAME_AND_UI.md#社区讨论树与回复入口)。

## 多人约会与约会切磋的保存

场景主轮次仍归主联系人信箱。DateSceneInvitations 在受邀者私信完成后写回同一玩家信箱的原活动 Participants；房主 StartPrivate 对 dm-date-invite 使用 Replacement 解析实际受邀者，并将私密分片仅发回发起玩家。DatePartyEffects 的学习及档案变更在原 MergePrivateLearning / PrivateProfileChanges.Merge 中按人物去重合并。SceneLines.Speaker 随现有 CoopPrivateChunk 传递。约会切磋的GameMatchId与GameChatRequest随原Scene保存；本局进度取LiveDateGame写入绑定对局的Snapshot。请求取得队列名额后刷新事实，修订沿原命令、交互撤回及存储顺序执行；额外保存和广播次数为0。游戏切磋仍限定单人生涯。活动选人衣服标记读取当前机器的立绘缓存，展示与窗口缓存均属于本机界面数据。PrivateMessageCommand.ToolMode随原命令发送；开场、重新输入、局内请求与结算续聊、结束和重试保存于排队轮次，加入邀请保存于Replacement指定的受邀者轮次。工具参数在完整返回后进入ToolCalls，格式转换继续在房主原请求处理器执行；新旧协议保持相同的保存与广播节点。旧单人轮次缺少参与列表及 Speaker 时继续用主联系人。

约会沿用原 private 提示词、房主快照与本机设置读取入口。场景情绪字典的 emotionSets 引用与连续显示片段的历史标签合并只属于请求组织；人物素材、Scene/SceneLines、聊天原文、保存次数、检查点和广播次数均沿原流程。

约会历史逐轮删除复用 dm-delete 的权威业务提交：单人先由 CareerStore.Save 保存一次；联机继续由主机执行个人信箱命令和现有回执去重，发起客户端在成功回执后 Refresh 取得新视图，再修改本机回忆。普通对话与约会共用 PrivateMessages.Manage，约会清除分句/选项缓存并追溯多人物派生轮次的未确认事项。回忆清理采用 DateSceneMemories.RemoveReply，仅移除同轮回复与画面；关闭录制时仍更新已存文件，追加范围保持原状。Read、Save 和 ForPerson 对现存源轮次的 ReplyDeleted 做删除对齐，保留原文已归档的独立回忆；这也防止一次本机文件写入失败后重新显示已删原文。业务命令与本机回忆文件分步提交，本机写入失败保留源删除结果并在确认框提示重试。世界切换后停止旧回调，迟到成功回执只关闭发起它的确认框。存档结构继续兼容旧版本。

立绘布局继续保存于各人物既有 DateSceneAssets 本机文件。SpriteY 保留旧文件的屏幕坐标方向，DatePortraitPlacement.FromAssets 将其转换为界面中的向上正值；保存时反向转换。当前场景的个人X位移固定为自动站位，旧 SpriteX 字段保留用于历史数据兼容。DateScenePortraitSettings 默认选中所有对象，沿同一写入入口修改本次约会各人的指定数值；选择范围只属于当前设置窗口。单个人物仍按稳定编号独立设置。它追踪实际修改人物，滑动过程只改内存与显示，拖动结束、数字确认、换人及退出时通过 DateSceneAssetStore.Save 原子替换对应文件；失败保留待保存标记并显示提示。世界/本机玩家键变化后停止旧窗口的提交。关闭并重新进入从各自文件恢复。单人及联机各端均为本机显示偏好，业务存档与广播新增次数为0；素材、对话与模型路由沿原模块处理。回忆帧另外冻结个人布局和实际出场名单，播放时恢复当时设置。画面恢复按稳定人物编号复用立绘控件及当前透明度，仅新增或移除名单变化的人物；冻结的好感值直接显示。这些绘制修订沿用既有回忆格式和业务数据。DateCastRoster的最近四次完整发言队列与最近发言人只属于展示层，连续同人显示片段共享一次计数，旁白跳过且保持最近发言人；按本轮文本和已播放下标重建，Clear同时重置队列和最近发言人，AI输入、人物记忆、关系与联机快照保持原契约。

可选约会回忆由DateSceneMemories单独保存于`user://national_spire_date_memories/<世界及本机玩家哈希>/<OfferId哈希>.json`；复用PortraitDesignStore.Key隔离世界和LocalHumanId，单人使用player。记录开关归`NationalSpire_date_scene.cfg`的scene.record_dates，缺省true，既有明确false保持关闭，写入保留其他设置。录制在本机展示层读取当前私信视图；房主与客机分别保存自己的回忆，业务保存、网络广播及检查点新增次数为0。记录以临时文件写完后替换，失败保留旧档并给出状态/日志；流式更新在内存完成，完成、推进、暂停、关闭与开关操作仅在有变化时写入。结束命令成功后标记Ended；重连/重新打开沿同一活动文件续接。切换世界/玩家时校验档案键，阻止旧场景内容写入新分区。关闭开关停止追加并保留已有文件，结束时仍可完成已保存条目的Ended标志。图片沿既有不可变哈希缓存复用，存储增加来自文字和实际用到的图像；用户手动清除该缓存会影响回忆素材。删除回忆只删除该OfferId的本机JSON并清除索引缓存，图片缓存继续供其他绑定与回忆复用。整篇日记删除经原PrivateMessageCommands/CoopRules个人信箱命令保存：单人保存一次，联机由房主Capture当前成员信箱后提交和回传；成功回执才删除发起客户端本机文件。其他成员日记保持原状。删除标记阻止回忆索引与迟到写入重建条目；本机文件清理失败会显示错误，日记删除状态继续有效。

ForPerson按目录内文件名、长度及修改时间缓存读取结果，Save使当前分区缓存失效；旧条目和缺少文件正常显示总结，损坏记录给出读取提示。当前界面保留一个约会的内存缓冲以支持中途开启；重新进入时加载已保存记录。2026-10-22隔离渲染测试：两轮约会原子保存2.59毫秒/6.7KiB；50次重复检索累计7.09毫秒；502轮约1.08MiB档案保存8.69毫秒、分配约4.72MiB，载入8.64毫秒。这些为序列化与文件操作的整体耗时，图片首次编码和磁盘外设差异另计；真实Steam客户端磁盘、跨设备迁移与网络场景未实测。回看只调用本机读取和展示，API调用、业务提交和好感更新次数为0。

约会切磋仅使用现有单人生涯原生入口；CareerMatch.DateGame 与 CareerData.DateGameRules、DateGameTiming、DateGameVoiceEdits 跟随生涯保存。台词导入在单人生涯的规则编辑器内暂存，保存时经DateGameContent.Validate/Apply统一应用并调用CareerStore.Save一次；取消释放草稿，验证失败保留原设置。导出读取当前编辑稿，向桌面写入七份性格JSON、独立触发条件JSON及说明的ZIP，临时文件完成后重命名；对局播报读内存配置，沿原事件保存节奏执行。完整默认库只在首次导出/校验时构建并缓存，生涯仅持久化改写差异；台词导入不改变已触发集合与既定赛果。联机生涯沿原约会切磋入口限制。CareerStore.Load调用DateGames.Upgrade移除start/ambient、补齐四项新条件并把快速推进起始楼层提升至至少20，保留已有启用状态与台词。额外 NPC 模拟首次建立及节奏改变、新触发事实、事件播报合并为同一次轮询内至多一次额外保存；战斗胜利事实随原FinishCombat保存；正常播放和立绘切换产生零次业务保存。NPC 请求聊天时通过RequestChat保存PendingChat、PendingSpeaker、PendingLine和PendingUntil，沿同轮changed合并至多一次CareerStore.Save；后续逐帧轮廓仅更新界面，到期轮询清空四项并保存一次。截止时间从原版RunTime起点校准，以有效游戏帧累计小数秒；重载按原版时间重建起点并恢复剩余时长，最多20秒，旧档缺少截止时间时首次恢复补20秒并沿原台词恢复人物。新请求同步写LastChat，按请求出现时间计算至少20秒间隔；已有更长的ChatSeconds配置继续生效。已接受请求等待安全帧期间冻结到期；进入约会后原生计时、战斗与动作队列一同暂停。开始与返回对局保存本机阅读书签。待赛与已进入原生对局共享原 Status 表示；开局界面另外核对 PendingMatchId 与局内恢复回调，避免局内聊天被误判为等待开局。生成等待、播放、输入或失败时均可经原 dm-date-pause 命令返回对局，保存原活动为 paused 并保留输入草稿。书签失败记录 date.game.bookmark；命令保存失败或活动失效也会进入界面清理的 finally，强制关闭局内覆盖层并释放原生暂停。恢复回调在清理前取走，重复关闭与节点退出复用同一释放入口。后台生成继续沿原队列完成。手动继续恢复编辑区；回应NPC请求保存新事件轮次并生成，流式回复和两条建议由同一请求完成。SceneChoices跟随原PrivateTurn快照保存并在多人个人信箱中同步；建议选项及开始/取消、返回/结束选项共用本机布局：中心X坐标相同，上下排列，文字框上方整体居中。该布局调整只更新控件位置与尺寸，保存和广播次数为0；本机输入模式、手机返回活动和原生暂停委托仅归当前页面。重启后缺少原生恢复委托时，DateGames.InProgress 仍从持久化 PendingMatchId 与 DateGame.Host/OfferId 识别当前约会对局，输入区的手动继续选项及退出确认弹窗保留恢复入口。DateGameReturn.PrepareSavedResume 校验主菜单缓存的原版存档与同一生涯绑定；验证通过后保存约会暂停状态、清理覆盖层并调用原版继续游戏入口，沿游戏已有流程载入原存档。检查失败保留场景与草稿、显示错误原因；恢复入口准备过程只读，不复制、替换或删除原版存档。原版存档恢复继续依赖 CareerRunBinding、MatchRecovery；恢复后的桥接读取已有模拟与已触发集合。未处理请求在重载后按保留的剩余时长等待玩家接受；已进入私信队列的轮次沿 Recover 变为可重试失败状态。真实对局结算保存 ReturnPending，DateGameReturn 等待原版分数与解锁写入，经DateGameMenuReturnPatch包装的原版ReturnToMainMenuAfterRun任务完成及下一帧再恢复原约会；转场中的MenuPatch延后处理。该任务异常原样传播，恢复阶段异常记录date.game.restore，保留待办供下次恢复；成功入队结算续聊后清除标记，ResultTurnId使重复通知复用已有轮次。结算续聊允许排在既有请求之后，旧请求finally释放锁后继续；普通回应请求仍要求当前队列空闲。补丁仅对当前绑定的约会对局生效，恢复失败保留下一次进入时的恢复机会。

group-offer-date 继续经过原群聊权威命令与保存广播；DateGroupBridge 在群聊临时信箱替换之前创建主联系人场景副本。相同来源重复进入复用原副本；结束和加入人物同步群聊活动；CoopRules.Capture与StartPrivate.Save通过DateGroupBridge.Merge提交有更新版本的来源日程，仅合并State和Participants，保留群聊消息和其他字段。群成员身份、场景来源编号及版本共同限定合并范围，重复或旧版本合并保持原状态。DateGroupBridge.SourceActive统一检查共享来源仍为已确认或已赴约；场景可用性、发出加入邀请及接受邀请均调用该入口。Sync和Merge只更新仍开放的共享活动；群聊因其他消息产生较高Revision时，其携带的旧活动副本同样受到终态保护。来源已结束、已取消或已移除时，旧本地场景停止接收新轮次，迟到加入转为expired，原参与者名单与终态保留。原日程库存结算沿 SocialAppointments.Attend。群聊婚礼附件保存 WeddingServiceIds、兼容首项 ServiceId 与包含结婚对象和宾客的 Participants；接受或改期沿 GroupInteractions/SocialAppointments 复制全部服务编号并建立共同日程，取消及改期保留服务次数。赴约将原活动设为已赴约，逐份计用；带 DateSourceGroup 的副本用于展示和对话。场景结束由 WeddingAppointments.Complete 逐个调用原关系入口更新当前玩家与所选对象的婚约经历，其他玩家和宾客的关系保留。新列表沿原 JSON 快照、交互撤回、保存、命令回执和广播传递，旧档缺少列表时使用 ServiceId。参与者素材在各客户端本机读取，默认剪影嵌入程序集；跨人物和玩家素材保持隔离。验证使用隔离 Godot 项目、合成生涯及本地 SSE 响应替身，覆盖参与者接受/拒绝/过期、人物归属、交互撤回、学习、失败修订、约战附件与取消、群聊日程唯一性、序列化及本地测试隔离。真实模型响应时间、原版整局中的暂停/赛后自动恢复、Steam 联机检查点及断线恢复须进行游戏测试。

首次约会设置由OpenDateSceneReady在创建场景/排队开场前检查参与者；每个未确认NPC显示一次。首次选择优先当前角色已导入且含有效默认PNG的套装，先检查当前套装再检查其余套装；此预检只读本地素材，确认前保持文件原样。全部缺失时选择性别剪影。DatePresentation.Save先准备全部角色，随后复用CharacterDesignPackage.Installation安装两份本地JSON；任一安装失败时逆序还原，全部成功后提交。取消不写确认标记。形象包复用AppearanceLibrary.Prepare的同一绑定规则。首次判断按世界/玩家/角色隔离，联机保留各端美术自主选择；世界关系和聊天保存继续走原权威入口。活动中新增成员在输入阶段触发同一流程；确认后刷新立绘名单。OpenRunDate和结算ReturnToDate把生成动作作为ready回调，确保首次弹窗关闭后再接续。取消局内首次弹窗走CloseDateScene归还原生暂停。手动输入模式以空轮次编号兼容尚无聊天记录的活动，后续Tick保留输入状态。场景设置可以重新选择，已开始对局沿既有Voices更新规则保存。开发者测试仅读取展示偏好。

## 角色包与立绘包导入

PortraitPackageImport.Read先读取并校验包，图片与导入选择暂存在本次窗口。Merge仅建立设计/素材草稿并写入可共享的图片内容缓存。DateSceneAssetScreen确认后由CharacterDesignPackage.Installation备份原设计和素材文件，保存两份JSON后Commit；任一写入失败恢复原文件。人物编辑器的纯立绘导入保留pendingDesign/pendingAssets，保存或导出时安装；保存角色成功后Commit，取消或关闭窗口时Dispose恢复原本地绑定。取消后共用内容缓存继续可复用。窗口草稿在关闭进程后自然释放，既有角色资料及已提交素材继续按原路径读取。

素材按生涯及人物键保存在本机，导入图片及未知ID确认产生0次AI请求、0次生涯广播；人物创建/保存继续沿原CharacterCards和character-card权限及房主回执机制。CanEditCharacter限制角色创建，纯素材编辑沿本机权限。所有延迟确认检查CareerStore.IsCurrent，父窗口销毁时放弃后续回调。真实Steam跨机和进程中断时两份素材JSON的写盘恢复仍待实测；本轮覆盖内存草稿取消、安装事务回滚和Godot实际文件选择器调用链。

## 单人生涯保存的顺序

社区主楼或评论改票由DiscussionVotes调用CommunityVotes.SetVote，实际变化后一次CareerStore.Save。保存抛错时恢复改票前选择及VoteRevision，再显示错误；成功后刷新本行按钮和数值。PlayerVotes随帖子JSON保存，页面切换和重新启动继续读取保存记录。旧内容通过CommunityVersion=5的一次升级取得程序评分。

新闻与社区回帖入队异常进入各自原失败收尾，任务状态保存后释放已取得的队列凭据，回帖先清理 ScheduledInteractions。单人继续由 CareerStore.Save 提交，多人公共新闻继续由 CoopAi.ExternalSave 合并改变的帖子并提交原检查点与广播，社区回帖继续使用原公共保存回调。成功路径的保存次数与提交顺序沿用原流程；入队失败新增执行原本被跳过的那次失败状态保存。保存自身失败仍向调用者报告，函数 finally 负责释放队列凭据。已保存失败状态在重启后继续供原重试入口读取；旧中断记录由 RecoverInterrupted 转为 failed。执行步骤与验证入口见[社区与周刊状态依赖](AI_FLOWS.md#社区与周刊状态依赖)。

CareerStore.Save 首先检查 ExternalSave：多人或专用视图传入时执行该回调，不写入单人默认文件。

普通单人顺序：

1. 进入 Gate，确定传入 CareerData 已绑定的 Paths 文件路径。
2. 全部生涯序列化为 JSON 字符串，写入同目录 .tmp。
3. 主文件存在时比较已验证的文件长度、修改时间；缓存失效才重新 Read 校验。
4. 主文件有效时复制到 .bak；损坏 JSON 或结构无效时保留原有正常备份。
5. 将 .tmp 移动替换主文件，更新已验证标记。
6. 保存的是当前 _data 时，另行保存本机 AI 设置。

读档 Read 使用 File.ReadAllText 再反序列化。Save 将生涯序列化为字符串，再写入临时文件。

Data 属性不只是获取字段：首次读取会加载文件、恢复备份、迁移、修复阵容、恢复中断生成、载入 AI 设置，必要时再次 Save。性能与依赖检查必须包含 getter 的这些工作。

## 经济操作的提交、同步与恢复

实际或模拟比赛失利、未通关获胜的 FinishMatch 在写入正式赛果前保存 Failure.Result 与原对手 Opponent，返回待选择界面。确认结果经 MatchFailure.RestoreMatch 恢复原比赛参数，再执行完整结算；实际重赛沿原 GameBridge 保存绑定并启动游戏，开局成功后清除原 Failure。退出或切换后由完整生涯恢复待选择。旧 Opponent 缺省值在再次选择时补齐，计算发生在该次选择中。单人正式资料、多人个人战绩、国运、行情、帖子及结算收据在最终确认或实际重赛完成时写入。原始尝试、确认及重赛选择写入既有诊断轮换文件，待选择对象清除后仍可按比赛、种子、时间和尝试编号追溯。

多人 Settle 的待选择分支保留 Run.Terminal 和 decision 阶段，失利与未通关获胜共用此分支。failure-retry 保存 RetryRequested 并建立原 start 投票；取消投票保留 Terminal，failure-confirm 仍可结算原实际或模拟成绩。全队确认时在 Apply 候选副本中清除旧 Run 并 Prepare；成功形成新实际对局，失败返回原 World。每条命令继续执行原检查点、回执和广播；断线及进程关闭后从已提交检查点恢复。二人/四人专项已实际写入、读取检查点，并验证取消后确认与真实重赛最终结算；Steam断线和原版启动的本轮实际操作待实测。

FinishMatch → CompleteMatchDay在原赛后保存之前完成当天NPC赛果、签表、奖励和行情。单人仍由FinishMatch末尾Save提交；多人仍在CoopRules.Settle副本中计算，之后Distribute/Capture、Commit、检查点和广播一次完成。没有增加保存或广播，没有修改重试、回执及断线恢复。Fixture的MarketSettled和已完成标识、AddRound已有轮次判定确保再次EndDay不重复结算。玩家同日其他未赛场次保持待赛；其他人的私人持仓仍由原快照过滤规则处理。

市场推进按钮复用propose-advance，客机不能单独推进；重复订单、旧报价、正在同步等处理继续由现有命令入口决定。CareerScreen只在个人视图新增Simulated结果且待阅编号匹配时切换结算，普通完整同步不会反复跳转。新闻素材消费、NextWorldEventDay、NewsDay、NewsFortune与生成帖子仍随原日期推进保存；离开页面、切换存档不另建任务或缓存。

持续赞助沿用 CareerCommerce.AcceptSponsor 的一次 CareerStore.Save；多人仍通过 sponsor 命令在 Apply 副本中调用，由 Capture 保存本人 Sponsors/SponsorOffers，Commit 写检查点后回执和广播。自动续约及下期生效在原日期推进或比赛 RefreshOffers 中执行，没有额外保存、广播、后台任务或重试。PaidSeason 和 CommercialPaidMatches 继续控制付款；NextOffer 与基础金额在同一合同对象内序列化。消费新增的待发布生活事件及公开事实均位于 EconomicActions.Save 原有六项提交范围，保存失败会和资金、物品一起恢复。已保存消费离开页面仍保留，后续推进由原发布流程处理。

v0.26.18专项118项、既有合同42项、商城展示107项、既有经济122项、实际Godot界面78项通过。覆盖三类赞助初签/重复操作/旧合同转换/涨粉/续约/预约切换/重复赛季、二人和四人命令与检查点完整读回、消费保存失败恢复、购物活动合并及重复发布。未调用模型；本轮没有重复强制终止进程或真实Steam断线测试，不把检查点读回等同于这些测试。

Release本机逐次性能记录：每次1000组个人赛季款和胜场款计算，稳定支持0.2571/0.1657/0.1649/0.1647/0.2020毫秒，成绩奖励0.1923/0.1737/0.1723/0.1675/0.9897毫秒，品牌推广0.1036/0.0870/0.0872/0.0865/0.0868毫秒；每批分配88字节（含计时对象）。10次购物业务与事件合并为0.9178/0.0654/0.0315/0.0293/0.0276毫秒，合计1.0716毫秒，分配26536/24832/24552/25088/24552字节；此项不含磁盘保存。依次为所有成员复制完整个人视图并计算赞助文本，二人5次81.83—124.24毫秒、累计499.46毫秒；四人183.72—230.62毫秒、累计1034.58毫秒，单批约24.38/54.26MB；这是包含原有View深复制的整批耗时，不能当作赞助公式或网络时延。无新增缓存。

实际Godot界面1280×720赞助首次/再次处理86.97/23.05毫秒，首帧97.97/30.03毫秒，分配19552/19136字节；1920×1080处理23.39/23.88毫秒，首帧30.15/30.47毫秒，各17344字节。1920测试在1280之后，不能称为全新进程冷启动。商城1280首次首帧168.06毫秒，复访62.48毫秒。原始记录位于本地 `.artifacts/sponsor-consumer-20261014/`；计时包含嵌套步骤，不能相加充当总耗时。构建成功，NuGet漏洞信息服务不可访问产生NU1900警告。

单人消费按钮 → EconomicActions.Save → 深复制当前 CareerData 一次并 Detached → ConsumerEngine 校验修改 → 将 Life、Credits、Fans、Posts、SavedThreads、CommunityMemories 交回原实例 → 原 CareerStore.Save。保存异常恢复这六个字段原引用并提示失败，原实例和绑定路径不变。处理同步完成，中间无 await；候选副本不传给其他请求。消费另改公开事实和本人关系。

单人交易按钮 → EconomicActions.Trade → 新建只含 Day、Credits、Market 及独立资金资料的输入，深复制 Trading、CreditFraction 和 Ledger；买卖会改价，因此同时深复制 Market；存取与借还不改价，沿用只读引用。不提供聊天、帖子或人物集合。CareerMarket.Trade 校验并修改输入，成功后提交 Credits、Life.Trading、Life.CreditFraction、Life.Ledger、Market，保留 CareerData 和 Life 原实例。Persist 共用原 CareerStore.Save，恰好保存一次完整生涯；失败恢复这五项原值/原引用。候选对象不进入异步或网络。

多人 market / consumer-buy / consumer-use 使用原 Apply：鉴权、纪元、版本和重复收据校验后复制整个 CoopWorld。交易复用该副本的日期、行情、本人 Life、钱包及绑定到该副本的 MarketAccounts，调用统一 Trade；报价变化引起的其他成员强平也在同一副本完成，不再复制全部个人视图。此输入不保存、不广播、不交给异步任务。商城沿用 View → Buy/Use → Capture。失败丢弃整个副本，成功仍由 Commit 保存检查点，再回执与完整广播。

行情和国运在日期/赛果原事务中更新，不单独保存或广播。Apply/Settle 在各自副本绑定 MarketAccounts，跨天和报价变更处理所有成员，包括离线账户。快照同时保存行情、余额、借款、仓位和赛果。客机仍先后台保存检查点，再按原顺序发布 World、完成回执和刷新。没有新增重试队列，原 Id、Epoch、Revision、流式依赖和接收顺序不变。

Account是单账户包装，调用Accounts(MarketState,IReadOnlyList<MarketAccount>,day)。CoopRules.BindMarket的MarketAccounts委托一次传入全部成员账户，包括离线成员。统一结算先处理原借款利息，再扫描全部仓位，用Close的整笔预计到账判断强平、用外部基准Price判断止损，将已触发仓位加入本次操作内的队列与去重集合。每完成一笔平仓并Apply更新对应方向的承接数量，再扫描剩余持仓；已经触发的仓位即使因前一笔成交使报价恢复，也继续成交。两种条件同时成立优先记强平。同一仓位只入队、成交一次；队列不跨操作保存，不是恢复重试机制。

Trade开平仓、Fixture和Advance共用上述入口；没有异步间隙、额外保存或广播。margin与stop修改本人Trading，新仓同时更新市场Revision；EconomicActions经RevisionCopy复制标量版本并复制个人资金资料，成功一次保存，失败完整恢复。追加与止损设置、取消均检查QuoteRevision；界面输入时不提交，确认后立即收起编辑区，避免同一展开表单重复确认。多人仍由原命令Id、Epoch和Revision去重与鉴权。旧档无StopPrice时不增加止损，InitialMargin在首次追加前从旧Margin填写，原成本及手续费不重新定价。

行情目录补齐与旧档PricingVersion升级共用原加载事务。Initialize按统一品牌目录补齐缺少的报价和60条起始曲线，记录目录指纹；首次检查资产键后使用当前MarketState的CheckedQuoteCount缓存。JSON复制及恢复检查点重建运行期缓存。原Quote、History、钱包和仓位继续沿用；补齐结果随原保存或Commit提交。离开页面、关闭进程及断线继续由原完整存档和检查点恢复。旧档 PricingVersion 升级在原加载事务中处理遗留信号；多人恢复由 InitializeMarket 先绑定全部账户，再 Initialize，最后沿原恢复 Commit 保存。结果待选择和同成绩加赛均在正式 Fixture 之前返回，因此没有行情变化；确认结果只正式结算一次。重赛不需要撤销已计价信号，也没有新增封锁交易条件。

PrivateSnapshot 与 SnapshotEncoder 同时清空共同 Life 及其他成员 Life 的 Consumer、Trading，本人数据保留。编码使用只读默认空值字节，不共享可修改个人集合。消费事实按原公开事件处理；私信保存回调读取最新成员，只合并对应信箱、关系与交互，不覆盖交易账户。

关闭页面不撤销已提交操作。关闭进程或断线时，原临时文件/完整检查点机制恢复前一次或本次完整提交，不能只恢复扣款而丢失入账。已完成写入的操作保留，未收到回执的重复命令由原收据识别。购物、交易及模拟不创建或修改原版对局文件。恢复旧多人存档时，CoopCoordinator 在原恢复提交前初始化行情和国家发展。

验证范围包括旧档、重复提交、个人隔离、保存异常、180天行情、单人/二人/四人结算，以及19组既有回归。原13个强制终止进程时机验证资金、商品、行情及聊天恢复；交易优化额外验证写入临时文件时终止、保存完成后终止。房主终止、四人客机终止后重连、四人全员重启由实际ENet进程验证，未使用多个Steam账号测试互联网传输。最终Release正常流程二人房主82项、客机21项；四人房主110项、每名客机21项，总计276项通过。

2026-10-14最终经济规则122项、经济改版141项通过。后者包含14组有效及无效交易的新旧路径全文哈希比较，成功操作恰好保存一次，拒绝不保存，保存失败恢复原字段。另用玩家日志中的约36.9MB生涯执行21项真实文件检查，5次旧入口与5次账户复制入口的最终完整存档哈希相同；原入口含实际保存耗时519.56—1232.98毫秒，新入口231.46—250.86毫秒，分配由约117.5—119.9MB降至41.35MB。测试顺序旧入口先、新入口后，存在运行时预热差异；后续旧入口仍为519.56—540.90毫秒。不含磁盘的新交易准备与提交为0.10—0.45毫秒。

199项资产、每项180天行情：每日更新5次为1.26—7.12毫秒，累计12.31毫秒；行情序列化5次16.35—16.69毫秒，累计82.75毫秒。完整命令副本与交易各3次，二人为124.80—134.70毫秒，四人为54.80—111.49毫秒；两组顺序不同，包含预热差异。二人实际检查点保存56.07—56.51毫秒，四人为47.52—50.22毫秒。独立步骤耗时不能相加冒充端到端帧停顿。原始逐次耗时、累计耗时及分配量位于本地 `.artifacts/economy-revision-20261014/`。

上一轮PR功能接入曾以旧诊断存档比较44组AI请求全文；这轮关注、国运和行情事实有明确变化，不沿用上一轮哈希一致结论。当前总结检查使用本地固定响应，覆盖私信和群聊大小总结失败、原文保留及原入口重试；不调用模型。旧日志缺少模型原始返回和完整异常栈，不能确认其全部越界均来自空choices；现入口已消除直接读取choices[0]的越界，并记录可定位的响应结构与异常栈。

## 加载、切换与删除

GameCalendar.Initialize 在新建和旧档规范化入口写入 CalendarStartYear，沿原完整生涯保存。多人主持者加载世界时固定旧档年份；成员视图与检查点复制同一字段，客机使用收到的年份。后续真实日期只用于首次初始化。

场景操作由 PrivateMessageCommands.Apply 执行；多人由 CoopRules 与 CoopPrivateMessages 将该成员 Life 合并回世界，保存检查点后广播。Scene/SceneLines/DateSceneStates、正式关系、婚礼服务引用与头像框选择跟随原个人资料；公开婚礼事件跟随原共享事件合并。客机看自己的私人记录，其他成员取得既有权限范围内的快照。

专属约会开始、暂停、结束分别走原私聊命令的保存与同步。结束后追加的感想通过原私聊生成与回调保存，DateDiaries 与 Mailbox 一起归当前成员并参与原个人可见快照；已排队轮次、失败轮次和完成结果随检查点恢复。结束生成前后沿原 sending/complete 两次保存回调，流式分片沿私聊通道，仅发送所属玩家。日记窗口只读会话，打开、翻阅和关闭的保存、广播与模型调用次数均为零。模型返回时通过 current/save 回调读取最新实例；离开页面释放界面素材，暂停或已保存场景可以恢复。关闭进程后正在生成的轮次沿原 Recover 恢复为可重试状态；场景已有正文和状态随生涯读回。两协调器、内存传输及实际磁盘检查点的12项验证通过，覆盖固定年份、赴约、开场、暂停、结束、个人可见性、重连。最近一次赴约/开场/暂停/结束命令整段耗时298.22/525.30/252.31/235.75毫秒，分配71.44/152.61/70.89/70.89MB，包含复制、文件与传输准备，不能作为单个本地计算步骤；真实Steam发送、断线及进程强制终止未实测。

| 操作 | 当前调用与处理 | 后续依赖 |
| --- | --- | --- |
| 加载 | CareerStore.Data → Read；异常保留 broken 文件并尝试 .bak；执行各迁移和 Recover | 页面取得绑定实例，queued/sending 等恢复为既有可重试状态 |
| 切换生涯 | Save 旧实例 → 校验目标 → CareerLibrary.Select → Data 加载；失败恢复旧选择与旧实例 | 请求完成仍按原绑定实例/路径处理；当前页面切换到新实例 |
| 删除生涯 | 与 Save 使用同一 Gate；撤销被删实例路径绑定 | 异步旧实例不能重建已删除文件；原版当前对局仍由原版管理 |
| 单人重置 | 保存并另存旧文件 → 创建新生涯并绑定同路径 → 保存 | 旧备份与新实例用途分开 |
| 导入导出 | CareerLibrary 与对应格式入口 | 不因导入模组资料而改写原版单人对局 |

单人 Save 不声称具有多人 WriteThrough + Flush(true) 的完全相同持久性。进程中断与断电也不是同一测试条件。

## 新仓成交与客机预览

EconomicActions.Trade复制个人资金资料；open/close复制Market，margin/stop经RevisionCopy复制标量并共享只读报价。CareerMarket.Trade在候选资料调用MarketClearing.Preview/Close→Commit，全部分段成交与自动退出完成后，Persist保存一次。失败沿原回调恢复钱包、Trading和Market引用。日期和赛果通过Price→MarketClearing.Reprice在原事务内处理。旧仓继续原双侧成交计算。

BindMarket把TradingAccounts绑定当前操作副本的全部成员，含离线成员。CoopRules.Trade复用这些引用，Preview产生结果后Commit修改副本。原Apply→检查点保存→替换World→回执→各接收者快照顺序继续执行。同一订单触发的各成员仓位退出随同一检查点提交。QuoteRevision包含新仓追加保证金与止损变化，供后续订单重新核对执行条件。

market-query沿CoopCoordinator原成员和发送方检查，再核对世界编号及Epoch。ReceiveMarket→CoopRules.InspectMarket→MarketClearing.Inspect读取房主当前资料，返回请求者净资产、双向订单摘要和指定本人仓位退出结果。market-answer经房主身份检查，按请求编号完成等待；等待上限10秒，结束时删除请求记录。查询对Revision、Receipts、存档与广播均保持只读。PrivateSnapshot/SnapshotEncoder继续过滤其他人的Trading。客户端按页面代次、对象引用和报价版本应用结果，实际交易仍由原CoopCommand及MarketOrder版本检查处理。离开页面后过期响应随请求完成释放，关闭进程和断线继续使用原检查点恢复完整交易。

## 多人命令提交的完整顺序

community-vote复用原CoopCommand：Target为帖子编号，Parent为空表示主楼或填写回复编号，Number为-1 / 0 / +1。CoopRules.Apply从已校验发送者取得member.PersonId，并传给同一CommunityVotes.SetVote，玩家身份由房主确定。该操作沿用成员、World、Epoch、Revision、收据去重与失败待选择检查；在线人数和正在比赛两处许可名单允许投票。接受后继续执行下表的单次检查点、回执和按接收者广播流程，界面以提交后的快照更新。CoopRuntime.TriggerAi继续使用现有发帖、回复等触发名单，community-vote产生0次新AI请求。

| 顺序 | 函数 | 输入与状态 | 输出交给谁 |
| --- | --- | --- | --- |
| 1 | CoopCareerSession.Send / CoopScreen.Submit → SubmitReady → Retry / 网络 command | 点击保留 Id 和参数、占用 pending；客机等待此前收到的事件，再读取 Revision；房主直接发送 | Execute；原 Retry 重发实际发送的完整命令 |
| 2 | CoopRules.Apply | 身份、会话、操作版本、已处理 Receipts、在线名单 | 复制后执行规则，返回 World 与 Outcome；重复命令复用旧结果 |
| 3 | Execute → Commit(..., broadcast:false) | 接受结果或实际变更 | CoopStorage.Save 先写入检查点，再替换房主当前 World |
| 4 | Execute → reply | 处理结果与已提交 World.Revision | 本人回执或发送给客机 |
| 5 | Broadcast | 最新 World、NativeSave、每名接收者 | 每人自己的完整快照分片 |
| 6 | Receive → Collect → QueueSnapshot → PumpReceived | 收齐分片入队；后台 Decode / Read；主线程校验成员、会话、版本；后台 SaveReceived | 检查点持久保存及可选个人视图准备完成后，一起更新 World / NativeSave |
| 7 | CompleteReplies、Changed | 已确认回执与已收到对应版本 | 个人操作完成；CoopCareerSession.Refresh 重建视图；页面刷新 |
| 8 | 房主 TriggerAi / StartPrivate / StartGroup | 已成功且非重复的命令 | 相关生成入口，不因同命令重发再次生成 |

回执“房主已确认”与“客机已经取得对应资料”分成两步。CompleteReplies 等到快照 Revision 达到回执要求后才继续。提前确认或只改房主内存，会改变这套实际完成条件。

### 客机后台接收与操作顺序

CoopReception.cs 集中管理客机队列。Receive 在主线程收集 snapshot 分片，最后一片到达后才放入完整消息。队首快照在后台执行 Complete.Decode 与 Read，产生独立 CoopSnapshot。后面的完整快照保留压缩分片，一次只解码、保存一份。

private-chunk、live、reply、run-*、诊断消息，以及 ApplyReceived / SubmitReady 按入队顺序处理。private 与 live 组装超时使用实际接收时间。ping 立即更新在线名单并发送 pong，Epoch 检查仍按队列顺序进行。房主 ReceiveNow、Execute、Commit、保存节点及广播数量保持原流程。

SaveReceived 调用 SaveAsync，持久保存成功后按需在后台建立独立 InterfaceView。PumpReceived 每帧最多发布一份 World / NativeSave；先移除队首，再调用 CompleteReplies / Changed，避免回执等待自身。普通事件累计处理达到4毫秒后停止本帧循环；单项处理、界面刷新及整帧没有4毫秒上限。

WaitForReceived 只等待调用前已经收到的事件。完成或取消通过异步继续的 TaskCompletionSource 返回。CoopNativeRun 的新局/读档响应、准备校验、开始比赛等待此入口。随机角色 PlayerChanged 使用 ApplyReceived，并核对原 generation、attempt、Epoch、resume。等待期间原版连接通信和战斗网络继续执行；实际断线与 Pause 不等待存储队列。

界面点击时沿原 pending 防止重复操作。SubmitReady 到达队首时只更新 Revision，保留命令 Id 和参数，再调用原 Retry、Receipts 与 CompleteReplies。关闭页面解除订阅，已经点击的操作继续；会话关闭取消未发送操作和等待。已开始的持久写入完成当前清单步骤，未开始的 SaveAsync 检查取消令牌。没有新增业务重试或房主迁移。

## 角色卡保存与多人归属

单人 CharacterCards.Save 先执行现有 CoopJson.Copy(data) 保存操作前资料，再调用 Apply，成功后仅调用一次 CareerStore.Save。失败时沿原 catch 恢复人物、比赛、俱乐部及玩家资料，并恢复本次新增修改涉及的 Life 和 Chats；这两份恢复数据复用已取得的副本，不新增复制、保存或重试节点。校验失败在 Apply 修改前返回。

多人 character-card 命令：Decode → 本人卡片使用 View 与原个人资料合并；NPC 沿原权限仅允许房主编辑，调用 CharacterCards.Apply(w.World, edit, member.Life, member.PersonId)。人物资料修改共同 World，三项写入该成员 Life，群聊旧回退字段修改共同 Chats 中对应的 `member.PersonId/NPC/` 会话。其他成员 Life、NPC 对 NPC 的 Chats.Relations 不修改。RefreshPeople 再从各成员信箱重建 HumanFavours，供公共社区资料使用。

CoopRules.Apply 仍在完整副本上执行，失败返回原 World，成功沿原 Revision、Receipts、Commit、回执、Broadcast、客机检查点及 Refresh 顺序处理。Relation 随 character-card 的原 JSON 命令传递，不改变网络分片或快照隐私规则；角色卡命令本来就不受普通聊天正文长度限制，整份数据容量限制保留。重复命令仍由原 Receipts 去重。

旧PNG与存档不增加字段迁移；三项保存在已存在的个人信箱。离开编辑窗口前没有保存，取消丢弃草稿；保存成功后页面跳转不影响磁盘提交。期间其他交流改变未编辑字段时，Relation 的空值不会覆盖这些字段。模型请求继续运行并使用原完成合并；断线、关闭进程、推进日期和切换存档均使用原会话与恢复机制，不增加新流程。验证包含实际单人文件重新读取、单人保存失败整份数据一致、二人/四人回执重试及房主/客机真实检查点；本次未重复强制终止游戏进程或真实Steam断线测试。

## 多人 AI 的 current / save / progress

多人私聊确认合同属于 CoopRules.PrivateCommand 的原命令事务。PrivateContracts.Confirm 在独立个人视图中执行签约及赛前到队，Capture 合并人物、俱乐部、资金、补员报道和合同；确认合同与重新生成成功时，同时将 Matches、Esports.Competitions 写回当前事务副本。CoopRules.Apply 接受后沿原单次 Commit、检查点、回执及各接收者快照处理。视图内 CareerStore.Save 使用原 Detached 回调；生涯共享数据由房主事务提交。跨季到队仍由原季节推进入口执行，已保存的 SourceTurnId/SourceHumanId 用于把到队前后差异记录到原私聊轮次。

| 委托 | 私信 | 群聊 | 依赖与用途 |
| --- | --- | --- | --- |
| Current | 校验房间与发送者，读取最新个人视图、信箱和本机配置 | 同样建立最新 View，并提供其他成员信箱用于相关记忆 | 每次调用可能复制整份数据；跨 await 后重新获取，保留期间其他操作 |
| Save | 复制最新 World，再合并该成员信箱、关系、顺序及实际业务变化 | 复制最新 World，CaptureGroup 合并 Chats、Matches、OwnedClub 等，再处理对应信箱与人物 | Revision 加一 → Commit；不能用请求开始的旧整份 World 覆盖 |
| progress | 当前正文与思考分片交给接收方 | 只发送给该群里的其他真人成员 | 更新实时显示；与完整快照是不同通道 |

群聊开始时 sending 状态依靠 Save 合并进入房主当前数据。后面的 Current 从这份数据读取；仅删除开始 Save，完成时可能取得旧 queued，而无法走原完成提交条件。

群聊流式新发言块预留 SpeechOrders 后也会 Save。它同时导致检查点、版本更新与完整广播。减去这一保存会影响客机重新打开聊天时的通知与发言顺序，不仅影响磁盘开销。

私信和群聊前台请求在取得队列名额后启动请求超时，等待名额期间仍可通过同一取消对象停止。private.queue 与 private.prepared/group.prepared 将排队、准备分别记录，private.timing 继续记录传输首段和总耗时。流式收到 finish_reason=stop 后立即完成并释放响应；保留此前及该帧内的 usage，后续单独的 usage 尾帧跳过。完成后仍通过 Current 核对最新世界、轮次与状态，再沿原 Save 提交；失败与取消继续进入原恢复和重试路径。计时与终止帧处理沿用现有消息类型，检查点、版本递增及广播入口保持原规则。

公共 AI 使用 ExternalCurrent / ExternalSave，CoopAi 完成时只合并该任务的新帖子、回复、周刊与资料；保留期间其他成员内容。业务规则执行前的 World 副本仍用于错误时不提交部分修改。

CommunityVotes.Update在CommunityThreads.Remember中、原保存前统一计算主楼及评论。读取只使用已存AudienceScore和PlayerVotes。每次Update建立本次人物、评论、父子索引及关注缓存，计算量随人物数、评论数及正文长度增长，缓存随调用结束释放。额外生涯复制、保存与业务广播次数为0。Normalize低于版本4时升级一次，达到4时常数时间返回；房主恢复通过相同入口计算，客机读取已保存的房主快照。

ProcessDiscussion将本任务新回复和完成状态合并到房主最新帖子，再调用Remember重新计算整帖评分。ProcessPublications保留当前PlayerVotes / VoteRevision，同编号原评论沿用最新对象，新评论保留最新玩家票，期间其他回复继续合并；替换完成后Remember计算最新正文的评分。ExternalSave继续复制最新World、应用本任务变化、递增World.Revision并Commit。任务代次、世界编号及Epoch继续控制切换后的有效性；评分随原检查点、广播及客机保存一起提交。

2026-10-17验证覆盖完整JSON往返、旧评分升级、玩家票保留和实际界面保存失败恢复。CoopCoordinator并发检查使用实际CoopStorage文件保存及内存消息传输，覆盖房主/客机独立票、乱序生成、失败重试、新闻与回帖交错、资金变化保留及帖子完整同步。真实Steam传输、断线恢复和真实API本轮待测。入口为CommunityVoteChecks、CoopCommunityConcurrencyChecks及CommunityPrUiChecks，本地证据位于.artifacts/pr12-validation-20261017。

## 完整快照与流式分片的区别

| 项目 | 完整 snapshot | private-chunk |
| --- | --- | --- |
| 内容 | 接收者可见生涯、请求状态、发言顺序、成员资料、配套 NativeSave、模板快照等 | World、Epoch、Person、Turn、Text、Sequence、Reasoning |
| 产生入口 | Broadcast → PublicBytes → SnapshotEncoder → Encode → Split | StartPrivate / StartGroup progress → Bytes → Split |
| 隐私 | 剔除不属于接收者的群和其他人信箱；本机 AI 配置与密钥排除 | 私信向本人；群聊向群内真人 |
| 接收 | 组装、校验、保存检查点、更新数据、刷新 | 校验会话、接收权限、顺序；更新 Live 字典 |
| 发言顺序 | 有 SpeechOrders 与其他实际记录 | 当前字段中没有 SpeechOrders |
| 重新生成 | 最新状态由完整资料与版本同步 | Turn 复用，消息不带独立生成代次 |

Broadcast 对当前 CoopSnapshot 调用原 PublicBytes 一次。SnapshotEncoder 只保存只读字节、字段位置和群成员编号；构造时扫描一次，不引用可修改的 CareerData 集合。每个接收者 Encode 按旧 PrivateSnapshot 的规则输出完整资料：公共 Life.Mailbox 为空、其他真人信箱为空、群聊仅保留属于接收者的群、PrivatePromptSnapshot 使用实际授权模板。其余已序列化字段原样复制，不另写字段清单，不重编码正文。每人结果分别交给 Split 压缩分片；Broadcast 返回后释放计划。

PrivateSnapshot 原深复制接口保留，作为完整结果对照和既有调用兼容入口。SnapshotBytes 为单次编码入口，内部创建同样的计划。

CoopAssembler.Collect 按编号保存分片引用；收齐后返回 Complete 并清空当前组装状态。Complete.Decode 复制分片到预分配数组，执行原哈希、解压与容量校验。Add 复用这两个入口，供原同步调用和私信/live 使用。完整快照在后台解码；原大小检查、重复分片比较及失败处理保留。

### 个人视图的复制边界

CoopRules.View 先从 CareerData.EncodingHeader、EsportsCareer.EncodingHeader 获得两个顶层临时对象，替换原 View 已经负责替换的个人字段。只执行属性赋值；Honors 使用新筛选列表，禁止对共享集合执行 Remove、Add 或 Clear。临时对象不返回、不交给 Capture 或业务规则、不跨 await 保存。随后 CoopJson.Copy 使用原 Options 完成序列化及反序列化，形成最终独立视图；Detached、AvatarWorldId、LocalHumanId 在解码后设置。忽略字段与默认值继续由原序列化器处理。

返回视图的可变集合与房主、成员数据独立。StartPrivate、StartGroup、规则命令与界面使用最终视图，跨等待仍重新读取当前 World。事务 World 的深复制、Capture 合并、Revision、Receipts 与提交顺序保持现有流程。

CoopCareerSession.Refresh 根据共同生涯 Revision 与在线/运行/待操作签名刷新。群聊页面的内容签名使用群 Revision、状态、日期、成员封禁等，未将每条流式正文当作整个页面重建条件。流式文本另行增量更新。

CoopRules.InterfaceView 集中执行原 Refresh 的个人字段和已读字段转换，输入候选快照与 self，返回独立 CareerData，不读取 Godot 控件或本机设置。CoopCareerSession 构造/Dispose 调用 RegisterView / UnregisterView；有订阅时 SaveReceived 准备一份视图。主线程按来源 World 对象一致性消费一次，其他情况仍调用同一转换。ApplyReceived、reply 投票写入和 live 更新使预备视图失效。Dispose 后 Alive 为 false，旧 ExternalCurrent / ExternalSave 不继续提交已读操作。

重新生成同轮时，Turn 不能单独区分两次生成。现有接收还使用会话、房主连续递增的分片序号及 queued/sending 状态。接收专项检查在二人与四人协调器中集中投递：原轮完成快照、旧分片、同编号重新生成状态、新正文与思考分片，按接收顺序逐项保存后显示新生成结果。这个检查不代表任意伪造序号或不遵循当前可靠传输顺序的消息都具有同样含义。

## 保存与同步计时

UiPerformance 保存固定阶段累计次数、总量、最大值及线程分配量，统计不会逐次写磁盘。CoopJson.Copy、CoopRules.View、CoopStorage.Save、Broadcast、Encode、压缩、完整组装分别计时。Save 区分原序列化、世界文件持久写入、原版文件持久写入、哈希、清单提交与旧检查点清理。父阶段包含子阶段，禁止直接相加；诊断导出沿用 UiPerformance.Snapshot。

CoopReceive 记录主线程队列及回调，CoopDecode 记录后台解码，CoopPublish 记录主线程发布，CoopPrepareView 记录后台视图准备。内部 Measured 事件供隔离测试记录每次计算的线程、耗时和分配量；生产没有订阅者，不逐次写文件。队友报告白名单包含既有 ui-performance.json。

当前实测证据在工作区 `.artifacts/coop-background-20261012/`，生成入口为 `NationalSpire.MultiplayerTests/Report-CoopAcceptance.ps1`。最终二人、四人各6场，逐名成员记录；同一份1716人、133篇帖子存档，实际Godot4.5.1渲染与原版ENet传输，.NET9、Windows、RTX4060 Laptop、Debug构建、本地模型分片，60帧上限。每场修改前后各一次，四人/九人及间隔/集中分片依次执行；这不是同一场景多次采样的统计分布。初次开群与后续开群分别保留，不能把不同分片方式当成相同输入的重复样本。

客机保存187次，单次最大88.08毫秒；解码187次，单次最大132.79毫秒；视图准备189次，单次最大119.57毫秒，以上均在后台线程。全部客机场景的主线程 CoopReceive 最大2.53毫秒，累计56.73毫秒；CoopPublish 最大0.23毫秒，累计3.01毫秒。Save包含序列化、写入、哈希与清单提交，View包含Copy，Receive包含完成回调；不能把这些嵌套计时相加。完整操作耗时、各步骤次数、逐次分配及线程见 `comparison.json`、`stages.csv`、`calls.csv`，测量起止之间的保存数会受阅读状态及心跳交错影响，不用次数差异宣称减少保存节点。

客机群聊最长帧从127.69—198.68毫秒降到56.81—155.19毫秒，超过100毫秒的帧累计从118次降到8次；私信从112.95—142.21毫秒变为135.34—164.41毫秒，社区从229.23—322.72毫秒变为255.93—330.38毫秒。长帧包含界面刷新、垃圾回收、渲染和同机其他进程竞争。后台接收改善了群聊停顿，私信和社区的最长帧未一致改善。房主生成与保存未移到后台，仍有最高4139.77毫秒长帧；部分客机社区长帧仍超过300毫秒。不能把后台计算时间与整帧混用，不能称全部停顿已消除。

正确性验收使用 `NationalSpire.Tests/Run-CoopAcceptance.ps1`，19组回归通过，包含多人规则、社区交付、群聊、私信、总结、仲裁及交互、训练、角色卡关系、阵容、俱乐部、合同、赛季、并发与恢复。接收专项另验证持久保存前不发布状态与正文、心跳继续、World/NativeSave配对、独立视图哈希、排队点击保留参数且使用新Revision、迟到分片、同编号重新生成、集中六份快照每帧一份、不合并不丢失、取消、跨实例12次保存、导入导出删除及保存失败后的后续操作。最终请求90组逐条和整体SHA-256与修改前相同，差异0、错误0，不调用模型。

最终Release构建0警告、0错误；安装前通过 `Run-ReleaseAcceptance.ps1` 使用最终生产程序集复验实际界面133项、原版二人合作101项及90组请求哈希相同。`release/release.json` 保存实际程序集SHA-256，不用Debug测量冒充最终Release性能数字。

强制终止实际子进程13次，包含单人临时文件、queued、重新生成、完成结果，多人world/run/manifest/完成阶段以及对应异步保存；每次重新读取保留完整配套检查点或已完成结果。原版二人/四人大厅、战斗、强制终止客机与房主、全进程关闭后恢复及重复暂停的实测边界见[游戏与界面](GAME_AND_UI.md#多人后台接收期间的原版对局与界面)。接收队列取消与磁盘写入中的进程终止分开检查，不能以普通异常测试替代进程终止。

## 多人检查点的保存与恢复

CoopStorage.Save：

1. 为本次保存生成检查点编号。
2. CheckpointHeader 形成带编号的数据，PublicBytes 排除本机 AI 配置；序列化在目录锁之外。
3. Durable 写 world.json、存在时写 run.bin；WriteThrough，Flush(true)。
4. 计算世界与原版对局的哈希；持久写入 current.json.tmp。
5. 替换 current.json，同时保留 previous.json；首次使用 Move。
6. 保留当前和上一份完整目录，清除更旧检查点。

Load 在目录锁内复制 current、previous 清单及 world.json / run.bin 字节，在锁外依次校验目录编号、哈希、生涯结构和原版对局配套，只恢复通过的一组。文件格式、当前与上一份、WriteThrough / Flush(true) 沿用原机制。

目录协调以实际绝对路径为键，跨 CoopStorage 实例共享 Gate。Save 的磁盘写入、清单替换和清理，与 Load 的文件复制、Delete 的目录移动使用同一个 Gate。Schedule 串行连接同目录的 SaveAsync、LoadAsync、ExportArchiveAsync、DeleteAsync；前项异常由原调用者处理，不阻断后项。Tail 仅保留完成信号，不保留完整资料或导出字节。

ListAsync 后台列出目录，逐项使用 LoadAsync；损坏目录沿原列表规则略过。ImportArchiveAsync 后台复用原解析与校验；编号已存在或有排队写入时另设编号，在协调锁内预留目录，再调用原 Save。CoopRuntime.Connect 使用 LoadAsync，等待后检查连接 generation。CoopScreen.Entrance、CareerLibraryScreen 的多人列表、导入、导出、删除使用异步入口；完成后核对控件有效性。关闭页面不撤销已经点击的文件操作；重复删除沿按钮 pending 处理。

客机收到完整快照也调用这套保存。房主的完整资料与客机的脱敏资料不是同一范围；客机不是新的房主，恢复仍由原房主主持。

## 中断和恢复的现有职责

| 情况 | 当前负责入口 | 当前处理及验证边界 |
| --- | --- | --- |
| 模型异常/超时/停止 | AI catch、命令 Cancel、RestoreInterrupted | 保存 failed 等既有状态；使用原重试入口，不新增自动重试 |
| 关闭聊天页面 | 后台 current 与绑定会话、页面有效性判断 | 生成可继续，结果保存不依赖页面控件仍在；当前任务的真实极端操作覆盖仍需单列 |
| 请求期间推进日期/俱乐部变化 | 完成后的 current、业务规则 | 读取最新日期、人物与规则；过期邀约仍提示原因 |
| 切换单人生涯 | 绑定实例、Paths、IsCurrent 等 | 数据归属按入口分别处理；公共与私信入口不能假定完全相同 |
| 游戏进程中断 | CareerStore 加载 Recover、CoopCoordinator 恢复构造 | 未完成请求恢复为既有失败状态；实时原文不是完整已提交结果 |
| 客机命令未收到回执 | CoopCoordinator.Tick / Retry / Receipts | 沿用原命令重发和去重；不重复扣款或交互 |
| 真人断线/房主退出 | CoopRuntime、CoopNativeRun、协调器关闭与 Epoch | 缺员暂停，原检查点恢复；旧会话回调失效，不增加房主迁移 |
| 检查点写入中断 | Manifest 最后替换、current / previous Load | 恢复完整配套资料；实际中断测试与写入逻辑核对分开记录 |

CoopNativeRun 的原版存储与检查点钩子属于独立链路。序列化、保存节点或广播修改必须连同原版恢复一起审阅，不能仅验证 CareerData 文本相同。

2026-10-21 自动保存专项使用 `NationalSpire.MultiplayerTests/Run-Production.ps1 -Members 2 -AutomaticSave`。专项启用真实 CoopSavePatch、绑定 CoopRuntime.Session/Native、设置原版 shouldSave=true，通过 EnterMapCoord 触发 SaveManager → RunSaveManager → CoopSavePatch → CoopNativeRun.Save → Commit → Storage/Broadcast。普通既有模式仍使用原来的显式保存测试；该模式只能证明已有检查点恢复，不能证明自然推进触发自动保存。专项不直接调用 Native.Save 制造推进后的检查点。

本地两个进程的房主25项、客机7项通过，检查首次地图入口和下一层自动更新检查点、两人最新生命101、客机完整快照一致、三次暂停恢复后牌组生命章节及双方地图一致。首个地图推进完整操作121.17毫秒，下一层229.45毫秒，均包含原版房间进入、同步及保存等待，Revision各增加1；未单独测量各内部步骤和分配量。平台为本机 ENet，菜单转场使用测试实现；没有加载报告者的第三方角色模组，没有验证 Steam 跨机断线或实际画面点击。原始资料在 `.artifacts/import-reconnect-20261021/`。该诊断包恢复文件停留在开局10秒的原因尚未复现，本次未修改多人生产保存逻辑。
