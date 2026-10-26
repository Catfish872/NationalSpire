# 模块与功能

## 逻辑层与职责
ChatTranscript 负责只读聊天正文筛选与 Markdown 导出；ChatUtilitiesScreen 负责当前会话导出和模型方案弹窗。AiTaskRoutePicker 提供主设置中的任务方案控件；聊天快捷入口使用单层 PopupMenu，直接列出 AiOptions.ConnectionProfiles 的方案名称与当前选择。两处通过 AiRouting.Assign 集中处理校验、保存回调及回滚。模型请求、凭据、消息持久化继续沿原入口执行。

PersonalityPools 负责两级性格池合同、校验、交换、加权抽样和人物风格快照；IdentityGender 在生成人物时读取池类别决定性别，PersonalityLibrary 共用资料出口提供两层风格。PersonalityPoolScreen 管理模板编辑草稿；PromptTransfer 复用 PersonalityPools.Validate/Read 交换总提示词中的完整性格池，独立性格文件仍由 PersonalityPools.Import/Export 负责。NpcGenerationScreen 组合新世界设置与导入清单，并将总提示词携带的性格池交给原比例编辑器；PercentageAllocation 独立计算保留锁定项、限制可用额度后的均摊百分比，PercentageSlider 负责 HSlider 滑块数值的可编辑呈现，同文件的 PercentageLockButton 绘制灰色开锁/闭锁图标；NpcGenerationScreen 分别管理大类及各小类组的窗口内锁定状态。NpcGeneration 复用 MatchRules/AiOptions 应用世界设置，复用 CharacterCards 和 CharacterDesignPackage 处理新档批量导入。AiSettingsPanel 提供原设置及开档共用的比赛水平选择器；PromptLibrary 负责模板枚举与覆盖切换。CareerStore、CareerLibraryScreen 与 CoopRuntime 分别负责原有保存/切换/联机发布时机。角色来源筛选沿 CreatedCard/EditedCard 现有字段判定。



ChatTools统一管理send_message工具定义、原协议转换、提示词末尾引导及原交互字段转换。ChatToolRequest按调用索引拼接参数，ChatReplyStream逐字符还原Reasoning和Replies，完整返回后再解析Interactions。PrivateMessagePrompts/GroupChatPrompts决定请求材料，AiService.RequestPrivateAsync接收普通正文及工具，私聊和群聊处理器继续调用各自原业务执行入口。多人约会在同一工具协议中扩展Speaker、个人交互Actor、date_choice、date_join和date_game，解析后仍经DateSceneEffects、DateSceneInvitations和DateGames的原入口执行。DateScenes.Guidance共用同一场景规则及素材，ChatTools.SceneGuidance只负责程序格式说明转换。工具模式关闭原生思考，通过工具同时提交分析说明、正文和交互；解析保留普通正文和旧工具兼容。ChatToolToggle负责本机共用开关，数据归属和请求关系分别见DATA_CONTRACTS与AI_FLOWS。

GroupChatPrompts.SpeechFormat提供普通群聊发言格式及完整示例，ChatTools.GroupSpeech引用其中的接话顺序规则，工具正文按Replies中的Speaker排列；ActorFormat保留交互字段规则。GroupStreamParser统一提取标准和变体标题中的人物编号，供AiGroupChats完成回复及GroupChatScreen实时显示；群成员、真人与封禁检查仍由GroupChats.SpeechUnavailable执行。

随机事件由 RandomEvents 负责日期、抽取、选择、自定义行动和经历记录，EventPools 共用随机事件和选手日常的默认分类、模板覆盖、缓存与批量编辑转换，EventPoolScreen 提供提示词配置中的事件池入口。RandomEventPrompts/RandomEventParser/AiService.ProcessEventAsync 共用首次及自由行动的材料、流式传输、思维解析和保存；Compose通过PlayerRecord读取当前生涯或试写副本的累计胜平负及最近5场四列赛果。RandomEventEffects 统一检查、显示与应用效果，Person 统一提取人物效果目标，Choose 将所选目标补入 People 后记录经历与公开资料。RandomEventScreen 是首页和日历共用入口，RandomEventCustomScreen 是同一 EventStoryView 的输入、预览与确认部分；EventJourney 统一记录途中停留与自动发布暂停，EventJourneyScreen 连接途中窗口、首页和结果页继续行程。钱包、库存、人物好感、学习、行情、国家建设及约战调用已有模块。CoopRandomEvents 负责成员命令及仅发给事件发起人的流式结果，完整快照过滤见 PERSISTENCE_AND_COOP。具体状态、保存次数、上下文范围及旧档行为见 AI_FLOWS 和 DATA_CONTRACTS。

ConsumerPickerScreen.ConsumerEditor 是聊天赠礼、活动与商城附件的共同编辑入口。ConsumerProducts 共用图标卡片、名称搜索、常驻分类和奢侈等级两排标签与每页10项翻页；商品按 ConsumerEngine.Price 降序排列，同价保留目录顺序，自行约定活动位于全部等级的第一张卡片。ConsumerEdit 仅保存当前弹窗中的对象、数量、日期和文字草稿。PeoplePickerScreen.PeoplePicker 统一群成员和商城人物选择的头像、筛选、搜索与可见行复用；熟悉的人按好感降序排列，同值保留候选顺序。ConsumerCommerceScreen 最终费用确认调用原 ConsumerAttachments.Prepare；单人保存成功或多人回执后才进入会话。具体流程见 GAME_AND_UI 的商城附件章节。

公历统一入口为 GameCalendar：CalendarStartYear 随生涯保存，Date/Text/Iso/Day 负责累计天数与公历互换；NormalizeFields 供活动、约战解析共用。AiWireProtocol 在既有 JSON 遍历中调用 ConvertDateField，CommunitySharing 与 AiGeneratedText 负责旧结构化附件的日期显示，聊天正文保留原文。

正式关系由 RelationshipGifts.Accept 与 OathAttachments.Respond 写入 PrivateRelation；WeddingAppointments 将已接受的誓约之戒或盛大婚礼连接到原活动日程；RelationshipPresentation.CompleteWedding 在活动完成时统一写入誓约与婚礼状态，并更新当前玩家信箱的NPC头像框选择。AvatarHonors 和 NpcAvatarFrames 读取正式状态与原荣誉决定外观。普通好感变动继续调用原 ChangeFavour。

Diagnostics.Record、RecordEvent 和 RecordMatch 负责各自记录的字段与脱敏，统一调用 LogStorage.WriteLog → AppendLog 完整写入与五份轮换。Configure 调用 MigrateLogs 处理旧独立事件及对局文件。ReadLogs 为 Export、CapturePeerLogs、ReadEventRecords 与 ReadMatchTraces 提供打开时固定长度的完整文件快照，TraceSnapshot 约束读取边界；普通会话、待写队列、效果错误摘要和错误计数的归属及范围见 DATA_CONTRACTS。LogPerformance 只累计固定阶段并覆盖固定统计文件。CoopDiagnostics 管理一次收集的缓存、缺片重发和释放；CoopWire 的诊断分支共用原压缩、分片和完整性校验入口。自动保存补丁及实际提交证据见 PERSISTENCE_AND_COOP。

专属约会使用 DateScenes、DateSceneScreen、DateSceneView；DateSceneParty 管理不限人数的 NPC 名单与人物白名单，DateSceneCast 管理最多三个在场立绘槽位，DateSceneInvitations 负责接受后加入原日程，DateGroupBridge 连接群聊活动与唯一场景副本。DateDefaultPortraits 提供默认透明剪影；DatePresentation 负责首次展示偏好的预检和事务保存，DatePresentationScreen复用原对话框、形象库和播报版本，让单人与多人共用每名角色的本机选择。DateSceneEffects 通过原私信交互入口分派各人物的关系、状态、档案和学习效果。DateGames、DateGameScreen、DateGameTriggers、LiveDateGame 把约战附件、开局/取消、手机私信、可编辑预制台词与接受请求后暂停接入原 GameBridge/LiveRunBridge；DateGames管理请求人物、台词和30秒有效期，LiveRaceHud复用原SpeechPanel构建请求组，LiveRequestButton只负责缓存轮廓、计时显示及到期隐藏事件，业务清理继续由DateGames负责；DateGameContent 负责十类公共事件配置与七种口吻的分文件JSON导出、验证和独立导入；每份性格文件直接管理各事件说明与候选句，DateGameVoices.EventLines为导出及编辑器共用出口，Event为LiveDateGame提供已选NPC的完整事件发言；CareerData只保存改过的台词，LiveCommentary/LiveVoices在选句时保留事实模板，经DateGameVoices在播报时应用对应人物的改写。DateGameVoices 提供七种本地口吻，DateGameReturn 等待原生结算后恢复原约会。DateSceneTesting 是仅内存状态的开发者预览。场景请求经过 PrivateMessageCommands → AiService.ProcessPrivateAsync，场景标记由 PrivateStreamParser 与 DateScenes.TaggedLines 解析，正文留在原 PrivateTurn。PortraitDesignStore、DateSceneAssetStore 和 DateSceneBackgrounds 管理本机设计与图片，CharacterDesignPackage 负责独立素材 ZIP 往返；PortraitPackageImport 统一角色包／纯立绘包识别、文件校验、情绪ID规划及独立草稿合并，PortraitPackageImportScreen 负责类型选择和逐文件确认，CharacterCardScreen 与 DateSceneAssetScreen 共用该流程。PortraitPromptExport单独导出生成提示词包，固定包含基准立绘提示词、表情差分提示词、使用说明三份Markdown。普通私聊与约会共用 ChatTimeline、AiService.SummarizePrivateAsync 与记忆管理。DateDiaries 管理单次约会日记及带持久删除标记的条目移除，DateDiaryScreen 复用 PR 作者的列表与卡片界面。 DateSceneMemories管理本机回忆契约与原子保存，DateMemoryRecorder收集展示用轮次；DateSceneMemoryScreen连接设置、画面捕获及结束检查点，DateMemoryPlayback复用DateSceneView只读回放。日记入口按参与者关联同场回忆，回忆文件与生涯记忆、提示词及网络快照独立。结束约会通过原私聊队列生成一次普通感想及隐藏日记；日记集合仅供查看，普通请求沿原聊天与总结机制组织上下文。

联系人行、日历、徽章、商品图标与数量控件采用 PR 原控件：ContactRowButton、CalendarDayButton、AffectionVisuals、ConsumerProductArt、ConsumerGiftControls。通讯分类、置顶、右键和管理继续调用现有入口；ChatContacts 只组织显示资料。

| 层 | 入口与模块 | 输入来自哪里 | 输出交给谁 | 数据或外部副作用 |
| --- | --- | --- | --- | --- |
| 游戏接入 | Entry.Init、MainMenuEntries、GameBridge、LiveCompatibility、RuntimeApi、GameCompatibility | 原版 ModInitializer、菜单、RunManager、战斗与存储接口 | 生涯界面、比赛恢复、证据记录、转播 | 安装 Harmony 补丁、订阅游戏事件；反射读取版本差异接口 |
| 页面与会话 | CareerScreen 各 partial、CareerNavigation、ICareerSession、CoopCareerSession | 当前绑定生涯或多人个人视图、用户操作、流式状态 | 生涯命令、多人 Send、AI 请求入口 | 创建和更新控件；操作保存由规则与会话入口负责 |
| 通讯菜单与置顶 | ChatManagementScreen.ChatMenuItems、ChatContextMenuScreen、PrivateListRows、CareerDialog | 当前或右键选中的会话编号、本机置顶设置、取消/返回操作 | 共用齿轮与右键功能，管理窗口返回及成员列表更新，置顶排序 | pins写入现有本地聊天配置；会话业务继续调用PrivateCommand/GroupCommand |
| 聊天历史显示 | ChatHistoryPage、ChatHistoryScreen、ChatComposerLayout、ChatComposerButtonSlot、ChatComposerPanel、ChatComposerExpandIcon、PrivateMessageScreen、GroupChatScreen、CareerNavigation | 当前会话记录、内容版本、翻页与选择操作、底栏四组控件的最小尺寸 | 私信/群聊分页及轮数组整体居中、底栏等高并缩至90%、输入框60%高度放大与发送还原、发送加宽且右缘/间距保持、当前页面气泡、滚动定位与档案返回 | 缓存当前会话轮次引用；本地配置按世界及玩家保存最近会话与每页轮数；布局只修改控件位置与尺寸 |
| 私信身份与表情 | PrivateMemoryScreen、PrivateMessageScreen、CommunityReplyExpressions | 当前人物与关系、本机配置中的人物详情展开状态、TextEdit光标/选区、当前聊天模式 | 头像/姓名档案入口、关系15字折行及右对齐、关系/好感共用自然高度详情、收起消除边框及好感文字显隐、ID顶端对齐头像、名片按两者底边居中、所有状态共用布局及独立方形状态按钮/右侧说明、ID/关系/好感1.25倍悬停亮度、与社区共用的50项Emoji/41项颜文字两行滚动选择器 | 人物详情展开状态按世界、玩家及人物写入本机聊天配置；表情面板归通讯窗口，关闭释放；插入沿原文字草稿路径，私信/群聊共用入口与分类状态，发送沿原业务 |
| 生涯规则 | CareerEngine、SeasonCalendar、EsportsWorld、CircuitWorld、CircuitLedger | 当前日期、赛事、人物、报名、失败待选择 | 赛程、赛果、奖励、公开事实、档案 | 修改传入生涯数据；部分入口直接调用 CareerStore.Save |
| 合同与培养 | OwnedClubs、OwnedClubSchedule、ClubOperations、ClubCoaching、CoachLineups、CareerTraining | 所属俱乐部、合同、席位、训练计划、预约转会 | 当前阵容、未来比赛名单、培养效果、账目 | 修改俱乐部与发展数据；名单变化传给赛事同步入口 |
| 退出俱乐部 | ClubDeparture、ClubDepartureScreen；CoachScreen、CareerWorldScreen、CoopRules 调用 | 当前归属、经营资料、待赛及已完赛对阵、真人名单 | 自由选手身份、AI 原队、未来阵容、合同邀请及离队事实 | 统一 Leave 保存；多人沿全员提议、检查点和快照；预约转会继续由 OwnedClubs.ArriveTransfers 履行 |
| 人物与资料 | WorldPeople、ExpandedPeople、CircuitPeople、CharacterCards、CharacterDeletion、PlayerIdentity、NpcRecords、PersonalityLibrary | 人物身份、编辑、删除、战绩、内容池 | 界面、模拟、候选发言者、提示词 | 维护真实人物编号及历史人物引用；显示名与姓名历史单独处理 |
| 角色卡个人态度 | CharacterCardScreen → CharacterCards → PrivateMessages.EditRelation → PrivateInteractionHistory.PreserveRelation | 本次实际编辑的字段、当前玩家 Life、NPC 编号、群聊交互方向 | 私信、群聊、社区与生活中的现有关系读取入口 | 写入同一份 PrivateRelation 和旧好感索引；仅移除被覆盖字段的旧回退数据，PNG 不交换三项 |
| 社区与刊物 | CommunityThreads、WeeklyJournal、PublicationBacklog、CareerNarrative、CommunityMemorySearch、CommunityPromptContext | 赛果与事件、玩家发帖回帖、公开事实与观点 | 待生成任务、帖子、周刊、人物介绍、检索结果 | 事实、生成任务、成品、已读状态分别保存 |
| 社区赞踩 | CommunityVotes | 主楼和评论正文、人物关注与关系、赛事类型、玩家选择 | Update计算受众净赞数，AudienceScore换算显示，Score叠加手动票，SetVote修改玩家选择 | Remember随内容更新评分，实际变化递增VoteRevision；原JSON键沿用，CommunityVersion=5升级一次，保存交给原入口 |
| 社区讨论显示 | CommunityScreen、CommunityDiscussionLayout、CommunityDiscussionVisuals、CommunityReplyExpressions、MentionComposer | 当前帖子回复、ParentId、既有阅读顺序、赞踩数据、本机折叠编号及编辑器光标与选区 | 评论卡片、统一透明度的父子连线及圆钮留空、后代计数、可切换收起的气泡回复、赞踩控件、圆形折叠按钮、就地回复栏及隔离滚轮传播的Unicode表情选择 | 投影和控件随布局更新；草稿与折叠集合归当前屏幕，ResetNavigation清空；表情选择及提及候选归当前编辑器，提交及赞踩保存沿业务入口 |
| 社区分享 | CommunityShareScreen、CommunitySharing、PrivateMemoryScreen | 主楼/评论编号、作者、当前个人信箱、人物选择及原私聊草稿 | 单选人物窗口、待发引用卡片、发送时来源/父链快照、私信及总结的AI材料 | 草稿归当前屏幕；发送经原dm-send按权威资料重建，Quote/Detail/AiDetail随该轮附件持久化 |
| 社区举报 | CommunityReportButton、ArbitrationScreen、CommunityReporting、SpireArbitration | 来源帖及可选评论编号、权威原文、NPC作者、可选举报原因、人物实力与裁决 | 提交前确认弹窗、作者私聊中的举报卡、官方裁决及既有处罚和致歉 | 确认后重读来源，Text保存原因或默认说明，dm-arbitrate建立Request案件快照，统一仲裁队列执行；原文与审理材料归申请人信箱，公开裁决沿原档案合并 |
| 聊天与交互 | PrivateMessageCommands、PrivateMessages、GroupChats、GroupInteractions、ChatTimeline、PrivateInteractionUndo | 用户文字、附件、群成员、AI 标记、旧记录 | 聊天轮次、交互卡片、关系、训练、活动、赛程与帖子；CoachScreen训练卡正文默认收起并在当前窗口维护展开状态 | 交互执行调用对应业务规则；回退依赖已记录的交互历史 |
| 提示词与模型 | PromptLibrary、PromptTemplates、PromptTransfer、AiContext、AiWireProtocol、各 Prompts、AiService、AiRouting、AiSettingsStore、AiRequestQueue、各解析器 | 模板、固定协议、人物与事实、历史记忆、生成任务、本机任务方案 | 最终 messages、连接快照、模型响应、解析后的正文与标记 | HTTP、按方案加密凭据、请求队列、实时字典、生成状态、结果保存回调 |
| 保存与联机 | CareerStore、CareerLibrary、CoopRules、CoopCoordinator、CoopReception、CoopStorage、CoopAi、CoopNativeRun、CoopWire、CoopSteam | 规则结果、模型结果、原版对局、真人命令、网络消息 | 磁盘文件、回执、接收者快照、流式消息、检查点 | 房主提交；客机后台解码、保存、准备独立视图，主线程按原顺序发布；存储按实际目录协调 |
| 局内显示 | LiveRunBridge、LiveMatch、LiveMaps、LiveRaceHud、LiveVoices、LiveCommentary、LiveCrowd、CoopLive、CoopBroadcast | 原版实际地图与战斗、已确定对手结果及用时 | 对手进度、解说、弹幕、人物头像 | 局内事件订阅；读取资源；播报历史与当前比赛保存 |
| 支撑与诊断 | Diagnostics、UiPerformance、LogPerformance、GameText、各头像与资源模块 | 实际请求、错误、阶段计时、资源、存档副本 | 日志、诊断包、格式化文本和缓存资源 | 凭据脱敏；资源缓存；性能记录 |

具体文件及函数依赖见[双向源码索引](SOURCE_MAP.md)。partial 类可能分布在不同模块文件，不能把单个文件误当成完整类。

## 国运、模拟与个人经济

职业收入统一由 CareerIncome 提供关注收益、旧合同转换和临时国运加成。CareerCommerce.RefreshOffers 先转换本人合同及报价，SponsorIncome.Retainer 同时供合同展示与实际付款使用；OwnedClubs.AudienceIncome 供周结与盈亏平衡查询使用。NPC 雇佣报价仍由 OwnedClubs.Quote 计算。

国运贡献经 NationalFortune.Amount → Confirm → NationalDevelopment.Contribute。每点贡献提供7点建设进度，按比赛编号、国家和日期确定随机分配；九项现状描述、当日升降和建设目标分别由 Snapshot/Describe/Context 提供给新闻、回帖及聊天。满级指标的 ExtraProgress 经 Enhancement 换算为临时增强，IncomeBonus 参与个人赞助和俱乐部会员收入。

聊天界面共用入口：ChatSettingsMenu 集中通讯工具入口，OpenChatDialog 切换设置与确认窗口；AppointmentCalendar 提供约战和活动的日历；GiftReceipt 显示礼物回执；TrainingCompletions / TrainingCompletionsThrough 按训练完成顺序组织私聊与群聊卡片。其输入、生命周期和调用关系见 GAME_AND_UI 的聊天历史章节。

群聊改名入口：ChatManagementScreen.ChatManageDialog → CareerScreen.GroupCommand → GroupChats.Command，使用已有 Name、Entries 和 Revision，由原保存与多人 CaptureGroup 同步，GroupChatScreen、GroupChatPrompts 和 SummarizeGroupAsync 读取。

生活与会话入口：ConsumerCommerceScreen 复用聊天赠礼、成员选择与活动日历编辑器，最终确认才调用 ConsumerAttachments.Prepare。ConsumerAttachments 统一付款附件、临时物品、拒绝返还和即时活动赴约；ConsumerEngine.Season 共用跨赛季邀请计数清理。ConsumerEngine.Buy 统一数量购买与库存迁移；ChatAttachments 统一附件资料、标记格式和礼物实际扣除；SocialAppointments 统一邀约、接受、改期、取消、赴约。ChatMembership 统一私聊隐藏与清除、群聊解散与恢复、移出成员和可见记忆范围。ProactiveChats 统一设置、触发、已回复轮数和请求启动；单人与联机共享规则，联机启动由 CoopCoordinator.StartProactiveChats 执行。

CardKnowledge.Find 统一读取玩家本轮文字中的卡牌名称；GameCardKnowledge 从游戏已加载定义建立资料，语言变化更新索引。WorldEvents.AfterMatch 与 Advance 共用 PublishDaily；WorldMatchLife 提供48条赛后生活素材。CoachLineups.RefreshAiStarters 在 CircuitWorld.StartSeason 中接续人物补员、先于阵容请求生效与新赛程生成。

| 模块 | 统一入口 | 输入、输出和下游 |
| --- | --- | --- |
| 逐场国运 | NationalFortune.Confirm | FinishFixture 的已确认赛果 → Fixture 收据、CircuitAward 累计、国家资金和 Contribute；CircuitLedger.Settle 补全最终名次，MatchImpact 提供结算及战报文字 |
| 国家发展 | NationalDevelopment.Contribute / SeasonStart / TryPublish | 有符号国运按原三类随机权重推动九项升级或降级；满级溢出投入一项增强，每次有效投入进入结算说明；换季更新GDP和增强衰减；WorldEvents 沿原时机发布上升或下降公报，继续使用 Publish 与原有社区生成队列 |
| 玩家模拟 | PlayerSimulation.WinChance / Sample / Run | 当前资料胜率决定保障获胜的概率；本人真实历史优先、选定进阶优先采样通关及失败楼层，VaryTime 按同类平均用时上下3%浮动；EnsureWin 仅在保障获胜且实际成绩未胜时降低本场对手成绩。多人传入参赛成员合计胜负平的胜率。单人 FinishMatch、多人提议确认后 Settle；失利进入 FailureDecision，MatchFailure.RestoreMatch 恢复原种子和对手，确认原失败或实际重赛后正式结算。成绩文字共用 MatchRules.Performance，图表按通关标记显示满高 |
| 关注与报价 | CareerAudience、ClubAudience、SeasonCeremony | 玩家和NPC共用比赛/冠军奖励；ClubAudience.Total 汇总独立关注及现役选手影响；新报价共用两条倍率曲线；奖项保存实际AudienceReward供单人及多人收据使用 |
| 消费 | ConsumerEngine.Buy / Use | 商品目录、本人 Consumer、邀请对象与关系 → 钱包、物品、关系和公开事实；单人 EconomicActions.Save，多人 Apply/Capture |
| 消费事件 | ConsumerEvents.Purchase / Activity | 成功购买、活动结果 → 当天购物合并记录或独立已完成聚会记录；CareerLife.AddEvent 保存公开事实，原日期推进流程汇总发布 |
| 持续赞助收入 | SponsorIncome → CareerCommerce / CircuitLedger / OwnedClubs | 基础合同金额、付款时关注 → 个人赛季款和胜场款、普通俱乐部赛季款、自建俱乐部周款和胜场款；个人 RefreshOffers 自动续约并应用 NextOffer，原付款收据、保存及多人命令继续使用 |
| 商城购买展示 | ConsumerShop → ConsumerPurchases / ConsumerVisuals / ConsumerSeal | 本人 BoughtDay、Goods、PromoUsed 与商品目录 → 本季徽章、宣发进度、实物收藏与最近购买日期；每次刷新只读整理一次，不保存、不广播，样式缓存不含玩家资料；我的空间不接入 |
| 行情与交易 | CareerMarket、MarketDynamics、MarketExecution、MarketClearing、MarketNumber | Initialize补前史并迁移旧待计价信号；Advance按独立基准更新日行情；Fixture在正式赛果中即时计价；MarketExecution保留旧仓成交；MarketClearing统一新仓曲线、分段强平、预览和提交，Trade执行资金及公共报价变更；WorldEvents通过TryPublish使用公开行情进入原AI新闻队列 |
| 经济提交 | EconomicActions.Save / Trade / Persist、CoopRules.Trade | 单人消费复制完整资料；交易复制资金资料，买卖另复制共同报价；统一Persist提交原生涯实例，异常回退资金与报价；多人复用Apply完整副本、MarketAccounts及TradingAccounts，处理其他成员强平，避免第二次复制整个生涯 |

MarketScreen/日程/无赛事页面通过AdvanceCareerDay共用日期推进；ConsumerShop.Select只重建ConsumerDetail。MarketPositionCard将持仓信息、平仓和保证金/止损编辑分开；Edit/Preview仅改本机控件，Apply/Send输出MarketOrder，经MarketTerminal.Submit→MarketScreen.MarketSubmit→单人EconomicActions.Trade或多人market命令→CareerMarket.Trade。MarketScreen → MarketTerminal复用CareerListCache的分帧预建控件；卡片Bind更新个人仓位、报价及版本并收起编辑区，Unbind对全部卡片Bind(null,null)，解除缓存中的仓位、报价和编辑状态。LifestyleArt提供本机缓存导航图标和原生商品插画。ConsumerScreen、MarketScreen、DevelopmentScreen使用现有CareerScreen、头像及样式入口，不修改游戏共享字体。没有独立网络协议、后台保存队列或重试机制。数据归属见DATA_CONTRACTS，提交顺序见PERSISTENCE_AND_COOP，规则与数值见GAME_AND_UI。

## 运行入口与非直接调用

品牌目录：MarketCatalog.Build→RegionalOrganizations.SponsorCatalog→地区Sponsors及CareerCommerce.LegacySponsors→统一Assets/ById及Version。CareerEngine.NormalizeRoster、日期/赛果及CoopRules.InitializeMarket共用CareerMarket.Initialize；检查、缺项生成、CheckedQuoteCount及原UpgradePricing均在此入口完成。市场搜索：MarketTerminal.Bind→MarketDynamics.Links→有效Sponsors、真人委托和自建俱乐部赞助，结果交给Partners及直接俱乐部名称索引；ResetList与ChangePage共用RefreshList。数据和生命周期见DATA_CONTRACTS及GAME_AND_UI。

市场展示：MarketTerminal.RefreshSelection→MarketExecution.Depth / MarketDynamics.Volatility→固定概况控件；RefreshSelection→EventTitle→四个MarketEventRow.Bind→日期、标题、报价变化与原人物回调。图表范围按钮→RefreshChart→MarketChart.Set。订单输入→MarketAmountInput.Amount→OrderMargin/RefreshFee→OpenFee及两次MarketClearing.Preview→扣款、费用和方向均价；做多/做空→Open→统一Submit。MarketVisuals.ActionStyle提供按动作与状态缓存的样式，LifestyleArt.Icon提供做多、做空、确认、收起、清除及波动图标；保证金和止损编辑沿用MarketPositionCard.Apply/Send。界面刷新、切换个人视图、离开页面和Unbind的生命周期沿用本章原入口。

| 安装或建立入口 | 保存的回调或事件 | 实际使用者与时机 |
| --- | --- | --- |
| Entry.Init | CareerEngine.PlayerNameSource | 创建与显示玩家身份时读取平台名称 |
| Entry.Init | CharacterIdentity.Source | 职业别名资料构建时读取 GameBridge.Characters 及 PlayerArchive 的名称 |
| Entry.Init | Diagnostics.RuntimeSnapshot、未处理异常事件 | 导出诊断和异常记录读取游戏、局内及联机会话状态 |
| Entry.Init → ScriptManagerBridge.LookupScriptsInAssembly | Godot 脚本类型 | 场景创建及游戏补丁入口，不表现为普通 C# 直接调用 |
| Entry.Init → LiveCompatibility.Install | Harmony 补丁方法 | 原版菜单、对局、地图、保存等被补丁目标触发；实际目标由兼容层寻找 |
| CareerScreen 绑定 ICareerSession | Data、Refresh、Send、Generate、Export | 共用界面读取多人个人视图，操作交给房主；不替换 CareerStore.Data |
| 单人聊天页面 | current、save、progress | current 重新获取绑定数据；save 写入生涯；progress 更新当前页面 |
| CoopCoordinator.StartPrivate / StartGroup | Current、Save、progress 局部函数 | 共用聊天引擎通过这些委托读取最新数据、合并保存、发送实时消息 |
| CoopAi 任务视图 | ExternalCurrent、ExternalSave | 公共生成引擎检验会话有效性，将生成结果合并回最新多人数据 |
| CoopCoordinator 构造函数 | transport.Received、Changed、TriggerAi、Replied、RunMessage | 网络驱动接收；会话刷新、公共 AI、操作确认及原版对局桥分别使用 |
| CoopBroadcast 构造函数 | CombatSetUp、CombatWon、History.Changed | 游戏战斗事件驱动观察与解说；Dispose 取消订阅 |
| 页面 Button / 信号绑定 | 点击、文本变化、滚动与每帧回调 | 用户或 Godot 触发；函数索引的方法组引用帮助定位，执行顺序仍由信号决定 |

## 跨模块数据流程

比赛事实 → 赛事结算与账目 → 公开原始材料 → 社区和周刊任务 → 模型正文 → 社区记忆 → 后续社区与聊天检索。

用户聊天 → 保存 queued 轮次 → 排队 → 保存 sending → 上下文与模型 → 流式显示 → 解析标记 → 业务规则 → 保存 complete → 自动总结。

多人命令 → 房主规则复制并执行 → 检查点 → 回执 → 按接收者过滤的完整广播 → 客机检查点 → 个人视图 → 界面刷新。

这些流程之间共享日期、人物编号、赛事编号、聊天顺序和关系数据。异步请求完成后读取最新数据，合并范围由单人绑定或多人回调决定。不能把最初构建请求时的数据副本直接当作完成时的全部最新数据。

## 使用和维护边界

AI 生成发言与交互提案，赛事胜负、合同、资金与日程由业务规则决定。解析成功不等于所有业务交互成功。

公开事实、私信记录、群聊记录、来源总结和模型模板用途不同。保密范围由资料选择和固定说明共同形成，不能仅靠模板文风维持。

原版单人对局由原版机制管理。模组生涯切换只切换模组资料；多人原版检查点由现有 CoopNativeRun 与会话桥管理。详细约定分别见[数据](DATA_CONTRACTS.md)、[AI](AI_FLOWS.md)、[保存](PERSISTENCE_AND_COOP.md)和[游戏](GAME_AND_UI.md)章节。
