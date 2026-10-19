# 模块与功能

AffectionCompetition负责可选的关系与通关率联动：世界开关、最高好感玩家选择、队友成长倍率及直接概率修正。CareerTraining、OwnedClubs、TeamPreparations与MatchRules共用此规则；AffectionSettingsScreen及CoopRules负责设置与权限，AffectionRules/PrivateInteractionHistory维护预测失效。

## 逻辑层与职责

| 层 | 入口与模块 | 输入来自哪里 | 输出交给谁 | 数据或外部副作用 |
| --- | --- | --- | --- | --- |
| 游戏接入 | Entry.Init、MainMenuEntries、GameBridge、LiveCompatibility、RuntimeApi、GameCompatibility | 原版 ModInitializer、菜单、RunManager、战斗与存储接口 | 生涯界面、比赛恢复、证据记录、转播 | 安装 Harmony 补丁、订阅游戏事件；反射读取版本差异接口 |
| 页面与会话 | CareerScreen 各 partial、CareerNavigation、ICareerSession、CoopCareerSession | 当前绑定生涯或多人个人视图、用户操作、流式状态 | 生涯命令、多人 Send、AI 请求入口 | 创建和更新控件；操作保存由规则与会话入口负责 |
| 日程日期显示 | CareerScreen.Calendar、CalendarDayButton、PrivateMessageScreen.OpenPrivateOfferCalendar | 赛事登记、当日世界赛程参与者、活动与NPC关系、本机所选日期 | 单剑/交叉双剑、爱心日历/婚礼钻石、选中底色、今天圆角悬停线、私聊直达日程 | 控件与导航归本机；复用既有绝对日期、保存和赛事规则 |
| 聊天历史显示 | ChatHistoryPage、ChatHistoryScreen、ChatComposerLayout、ChatComposerButtonSlot、ChatComposerPanel、ChatComposerExpandIcon、PrivateMessageScreen、GroupChatScreen、CareerNavigation | 当前会话记录、内容版本、翻页与选择操作、底栏四组控件的最小尺寸 | 私信/群聊分页及轮数组整体居中、底栏等高并缩至90%、输入框60%高度放大与发送还原、发送加宽且右缘/间距保持、当前页面气泡、滚动定位与档案返回 | 缓存当前会话轮次引用；本地配置按世界及玩家保存最近会话与每页轮数；布局只修改控件位置与尺寸 |
| 四场景提示词插入 | PromptInsertionScreen、PromptInsertions；各聊天/社区命令与Compose | 四段共享文字及位置、四场景独立勾选、请求快照 | 四列编辑器、当前输入前后及完整请求前后插入 | 本机防抖/关闭保存，已启用快照随原业务记录保存与同步，历史原文保持 |
| 私信身份与表情 | PrivateMemoryScreen、PrivateMessageScreen、CommunityReplyExpressions | 当前人物与关系、本机配置中的人物详情展开状态、TextEdit光标/选区、当前聊天模式 | 头像/姓名档案入口、关系15字折行及右对齐、关系/好感共用自然高度详情、收起消除边框及好感文字显隐、ID顶端对齐头像、名片按两者底边居中、所有状态共用布局及独立方形状态按钮/右侧说明、ID/关系/好感1.25倍悬停亮度、与社区共用的50项Emoji/41项颜文字两行滚动选择器 | 人物详情展开状态按世界、玩家及人物写入本机聊天配置；表情面板归通讯窗口，关闭释放；插入沿原文字草稿路径，私信/群聊共用入口与分类状态，发送沿原业务 |
| 生涯规则 | CareerEngine、SeasonCalendar、EsportsWorld、CircuitWorld、CircuitLedger | 当前日期、赛事、人物、报名、失败待选择 | 赛程、赛果、奖励、公开事实、档案 | 修改传入生涯数据；部分入口直接调用 CareerStore.Save |
| 合同与培养 | OwnedClubs、OwnedClubSchedule、ClubOperations、ClubCoaching、CoachLineups、CareerTraining | 所属俱乐部、合同、席位、训练计划、预约转会 | 当前阵容、未来比赛名单、培养效果、账目 | 修改俱乐部与发展数据；名单变化传给赛事同步入口 |
| 人物与资料 | WorldPeople、ExpandedPeople、CircuitPeople、CharacterCards、CharacterDeletion、PlayerIdentity、NpcRecords、PersonalityLibrary | 人物身份、编辑、删除、战绩、内容池 | 界面、模拟、候选发言者、提示词 | 维护真实人物编号及历史人物引用；显示名与姓名历史单独处理 |
| 立绘设计与提示词包 | ProfileScreen → PortraitDesignScreen → PortraitDesigns / AiService.InferPortraitAsync / PortraitDesignStore / PortraitPromptExport；PortraitStyleScreen → PortraitModelPrompts；CharacterCardScreen / DateSceneAssetScreen → CharacterDesignPackage | 当前人物资料/记忆、外观/套装/情绪、模型约束、PNG/ZIP角色包 | 可收起模型约束、人物化情绪推测、提示词ZIP（默认稿＋连续编号的expressions.md）、PNG白名单角色与全套立绘ZIP | 私聊连接推测；设计和图片存本机，角色ZIP只携带PNG资料、图片及ID映射，个人态度与记忆保留在生涯 |
| 一对一约会场景 | DateSceneAssetScreen / DateSceneAssetStore；DateSceneBackgroundScreen / DateSceneBackgrounds；DateSceneScreen / DateSceneView / DateSceneWaiting；DateScenes / PrivateMessageCommands / AiPrivateMessages | 当天已赴约的一对一活动、当前套装立绘、本机背景目录、完整私聊回复及玩家输入、逐句情绪/旁白/转场标注 | 按文件名或旧清单导入立绘、预载与导入背景库、AI开场、带长度保护的逐句播放/旁白淡出、兼容情绪标签、原地重生成、姓名框内好感、兴奋双跳、生成等待立绘互动及预制气泡、历史滚动浏览及可滚动输入框优先、可调字间距、背景最近匹配及淡入淡出、共用私聊输入、显示偏好与右键显隐、同情绪随机变体、独立约会提示词、暂返恢复入口、结束后私信感想与第一人称约会日记 | 活动资格由DateScenes校验；消息与效果沿私聊，通讯通过VisibleInCommunications隐藏场景对话并保留结束感想，模型标注只选已有句段及ID；场景状态和日记归个人信箱；图像、显示偏好和播放进度归本机 |
| 角色卡个人态度 | CharacterCardScreen → CharacterCards → PrivateMessages.EditRelation → PrivateInteractionHistory.PreserveRelation | 本次实际编辑的字段、当前玩家 Life、NPC 编号、群聊交互方向 | 私信、群聊、社区与生活中的现有关系读取入口 | 写入同一份 PrivateRelation 和旧好感索引；仅移除被覆盖字段的旧回退数据，PNG 不交换三项 |
| 好感外观与誓约 | RelationshipPresentation、PrivateRelation、AffectionVisuals、PrivateOathScreen、AvatarHonors | 存档反序列化、好感/关系赋值、玩家确认及私信 Oath 标记 | 六档样式、不熟/熟识/恋人/誓约关系图标、四边进度、整数动画、誓约确认与解除请求、婚礼场景结束后自动装扮的誓约徽章及共享头像工厂钻戒框 | Evaluate统一判定；数值先行，大于90才扫描关键词；誓约归个人信箱。40份内嵌SVG按名缓存，等级与职业荣誉继续由头像控件绘制 |
| 社区与刊物 | CommunityThreads、WeeklyJournal、PublicationBacklog、CareerNarrative、CommunityMemorySearch、CommunityPromptContext | 赛果与事件、玩家发帖回帖、公开事实与观点 | 待生成任务、帖子、周刊、人物介绍、检索结果 | 事实、生成任务、成品、已读状态分别保存 |
| 社区赞踩 | CommunityVotes | 主楼和评论正文、人物关注与关系、赛事类型、玩家选择 | Update计算受众净赞数，AudienceScore换算显示，Score叠加手动票，SetVote修改玩家选择 | Remember随内容更新评分，实际变化递增VoteRevision；原JSON键沿用，CommunityVersion=4升级一次，保存交给原入口 |
| 社区讨论显示 | CommunityScreen、CommunityDiscussionLayout、CommunityDiscussionVisuals、CommunityReplyExpressions、MentionComposer | 当前帖子回复、ParentId、既有阅读顺序、赞踩数据、本机折叠编号及编辑器光标与选区 | 评论卡片、统一透明度的父子连线及圆钮留空、后代计数、可切换收起的气泡回复、赞踩控件、圆形折叠按钮、就地回复栏及隔离滚轮传播的Unicode表情选择 | 投影和控件随布局更新；草稿与折叠集合归当前屏幕，ResetNavigation清空；表情选择及提及候选归当前编辑器，提交及赞踩保存沿业务入口 |
| 社区分享 | CommunityShareScreen、CommunitySharing、PrivateMemoryScreen | 主楼/评论编号、作者、当前个人信箱、人物选择及原私聊草稿 | 单选人物窗口、待发引用卡片、发送时来源/父链快照、私信及总结的AI材料 | 草稿归当前屏幕；发送经原dm-send按权威资料重建，Quote/Detail/AiDetail随该轮附件持久化 |
| 社区举报 | CommunityReportButton、ArbitrationScreen、CommunityReporting、SpireArbitration | 来源帖及可选评论编号、权威原文、NPC作者、可选举报原因、人物实力与裁决 | 提交前确认弹窗、作者私聊中的举报卡、官方裁决及既有处罚和致歉 | 确认后重读来源，Text保存原因或默认说明，dm-arbitrate建立Request案件快照，统一仲裁队列执行；原文与审理材料归申请人信箱，公开裁决沿原档案合并 |
| 通讯列表显示 | ChatContacts、ChatContactScreen、PrivateListRows、ContactRowButton、PrivateMessages | 会话顺序、NPC名称/好感、群组、本机显示偏好 | 置顶、隐藏、四种正倒序、显示隐藏、无描边菜单及联系人行、图标状态与可切换关系、待进行事件图标及距上次聊天天数、约会轮次可见过滤 | ConfigFile分生涯和玩家存放；保存/广播生涯次数0；原会话、记忆与总结保持 |
| 攻略难度与好感结算 | AffectionRules、AffectionSettingsScreen、PrivateMessages、ConsumerGifts、ConsumerEngine、CoopRules | 生涯全局难度、原始差量、赠礼因子、约会标识、发送时快照 | 增长缩放、负向倍率、对话上限、赠礼负收益及物价 | 整数好感与四种余数存个人关系；难度由房主统一，沿原轮次/商品/多人保存和回执 |
| 聊天与交互 | PrivateMessageCommands、PrivateMessages、GroupChats、GroupInteractions、ChatTimeline、PrivateInteractionUndo | 用户文字、附件、群成员、AI 标记、旧记录 | 聊天轮次、交互卡片、关系、训练、活动、赛程与帖子；CoachScreen训练卡正文默认收起并在当前窗口维护展开状态 | 交互执行调用对应业务规则；回退依赖已记录的交互历史 |
| 提示词与模型 | PromptLibrary、PromptTemplates、PromptTransfer、AiContext、AiWireProtocol、各 Prompts、AiService、AiRouting、AiSettingsStore、AiRequestQueue、各解析器 | 模板、固定协议、人物与事实、历史记忆、生成任务、本机任务方案 | 最终 messages、连接快照、模型响应、解析后的正文与标记 | HTTP、按方案加密凭据、请求队列、实时字典、生成状态、结果保存回调 |
| 保存与联机 | CareerStore、CareerLibrary、CoopRules、CoopCoordinator、CoopReception、CoopStorage、CoopAi、CoopNativeRun、CoopWire、CoopSteam | 规则结果、模型结果、原版对局、真人命令、网络消息 | 磁盘文件、回执、接收者快照、流式消息、检查点 | 房主提交；客机后台解码、保存、准备独立视图，主线程按原顺序发布；存储按实际目录协调 |
| NPC头像装扮与群头像 | NpcAvatarFrames、NpcAvatarFrameScreen、AvatarHonors、CareerAvatar、GroupAvatar、PrivateListRows、GroupChatScreen | 当前成员信箱的装扮/关系、NPC原荣誉、群成员ID | 默认优先的装扮选择、门槛校验、四种新框、1–4人群头像、发言头像下的紧凑好感徽章 | 装扮ID按玩家存档，单人保存失败回退，多人沿dm-avatar-frame个人命令；原荣誉与关系事实独立保留；SVG缓存，群头像最多复用四节点 |
| 局内显示 | LiveRunBridge、LiveMatch、LiveMaps、LiveRaceHud、LiveVoices、LiveCommentary、LiveCrowd、CoopLive、CoopBroadcast | 原版实际地图与战斗、已确定对手结果及用时 | 对手进度、解说、弹幕、人物头像 | 局内事件订阅；读取资源；播报历史与当前比赛保存 |
| 支撑与诊断 | Diagnostics、UiPerformance、LogPerformance、GameText、各头像与资源模块 | 实际请求、错误、阶段计时、资源、存档副本 | 日志、诊断包、格式化文本和缓存资源 | 凭据脱敏；资源缓存；性能记录 |

具体文件及函数依赖见[双向源码索引](SOURCE_MAP.md)。partial 类可能分布在不同模块文件，不能把单个文件误当成完整类。

### 关系阶段与赠礼职责

RelationshipPresentation 管理六档好感外观、恋人资格、誓约确认及已达成阶段的回退/恢复。CharacterCards.Apply 在保存人物前校验 CharacterRelationEdit.Bond 的解锁资格，PrivateMessages.EditRelation 保存本人关系并保护手动决定。阶段选择与关系描述共用 PrivateRelation；历史婚戒、婚礼事实独立保存。

ConsumerEngine 统一按数量校验和购买可赠商品，ConsumerGifts 负责库存预留、收礼资格、批量分配、发送扣除和收益结算。ConsumerGiftScreen统一赠礼和消费邀约的人物列表，复用CareerDialog、Avatar、最近聊天排序与私聊附件流程；ConsumerQuantity统一商城和赠礼窗口的整数编辑；ConsumerPurchases负责库存礼品的收藏入口，ConsumerEngine统一邀约好感资格。ConsumerGiftControls 的 PickerRing 为群成员、社区分享、消费邀约和赠礼人物行绘制婚戒状态。赠礼库存属于当前玩家；NPC 的心情时限沿用 CareerTraining 的世界人物状态。

ConsumerInvitations统一普通约会与盛大婚礼购买/库存邀约的草稿创建、发送前核验和待回应上下文；ConsumerInvitationStock负责旧库存迁移、一次快照计算可用量、共享预留、接受后幂等消耗和进行中场景锁。ConsumerScreen/ConsumerGiftScreen和DateDiaryScreen.PrivateDateInvitationPicker均通过consumer-invite进入，SocialAppointments在完整回复接受后消费并建立日程。DateDiaries负责同次结束请求的日记协议、完整活动记录与个人保存，DateDiaryScreen在人物档案提供粉色入口。DateSceneScreen读取首次当天赴约或已有未结束场景，PrivateMessages清理消息时保留已结束日程。ConsumerProductArt按商品提供32款补全SVG，LifestyleArt维持原有底色及比例。

## 国运、模拟与个人经济

| 模块 | 统一入口 | 输入、输出和下游 |
| --- | --- | --- |
| 逐场国运 | NationalFortune.Confirm | FinishFixture 的已确认赛果 → Fixture 收据、CircuitAward 累计、国家资金和 Contribute；CircuitLedger.Settle 补全最终名次，MatchImpact 提供结算及战报文字 |
| 国家发展 | NationalDevelopment.Contribute / SeasonStart / TryPublish | 国运先补维护再分配建设余额；换季计算 GDP 和维护不足下降；WorldEvents 的原有随机事件时机发布公报，继续使用 Publish 与原有社区生成队列 |
| 玩家模拟 | PlayerSimulation.Sample / Run | 本人真实历史优先、选定进阶优先 → 原抽取成绩 → VaryTime 在保持本场胜负的范围内按均值上下3%浮动用时 → RunPerformance；单人 FinishMatch、多人提议确认后 Settle；失利进入 FailureDecision，MatchFailure.RestoreMatch 统一恢复原种子和对手，确认原失败或进入实际重赛后再正式结算 |
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
