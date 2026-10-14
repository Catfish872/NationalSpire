# 模块与功能

## 逻辑层与职责

| 层 | 入口与模块 | 输入来自哪里 | 输出交给谁 | 数据或外部副作用 |
| --- | --- | --- | --- | --- |
| 游戏接入 | Entry.Init、MainMenuEntries、GameBridge、LiveCompatibility、RuntimeApi、GameCompatibility | 原版 ModInitializer、菜单、RunManager、战斗与存储接口 | 生涯界面、比赛恢复、证据记录、转播 | 安装 Harmony 补丁、订阅游戏事件；反射读取版本差异接口 |
| 页面与会话 | CareerScreen 各 partial、CareerNavigation、ICareerSession、CoopCareerSession | 当前绑定生涯或多人个人视图、用户操作、流式状态 | 生涯命令、多人 Send、AI 请求入口 | 创建和更新控件；操作保存由规则与会话入口负责 |
| 生涯规则 | CareerEngine、SeasonCalendar、EsportsWorld、CircuitWorld、CircuitLedger | 当前日期、赛事、人物、报名、失败待选择 | 赛程、赛果、奖励、公开事实、档案 | 修改传入生涯数据；部分入口直接调用 CareerStore.Save |
| 合同与培养 | OwnedClubs、OwnedClubSchedule、ClubOperations、ClubCoaching、CoachLineups、CareerTraining | 所属俱乐部、合同、席位、训练计划、预约转会 | 当前阵容、未来比赛名单、培养效果、账目 | 修改俱乐部与发展数据；名单变化传给赛事同步入口 |
| 人物与资料 | WorldPeople、ExpandedPeople、CircuitPeople、CharacterCards、CharacterDeletion、PlayerIdentity、NpcRecords、PersonalityLibrary | 人物身份、编辑、删除、战绩、内容池 | 界面、模拟、候选发言者、提示词 | 维护真实人物编号及历史人物引用；显示名与姓名历史单独处理 |
| 角色卡个人态度 | CharacterCardScreen → CharacterCards → PrivateMessages.EditRelation → PrivateInteractionHistory.PreserveRelation | 本次实际编辑的字段、当前玩家 Life、NPC 编号、群聊交互方向 | 私信、群聊、社区与生活中的现有关系读取入口 | 写入同一份 PrivateRelation 和旧好感索引；仅移除被覆盖字段的旧回退数据，PNG 不交换三项 |
| 社区与刊物 | CommunityThreads、WeeklyJournal、PublicationBacklog、CareerNarrative、CommunityMemorySearch | 赛果与事件、玩家发帖回帖、公开事实与观点 | 待生成任务、帖子、周刊、人物介绍、检索结果 | 事实、生成任务、成品、已读状态分别保存 |
| 聊天与交互 | PrivateMessageCommands、PrivateMessages、GroupChats、GroupInteractions、ChatTimeline、PrivateInteractionUndo | 用户文字、附件、群成员、AI 标记、旧记录 | 聊天轮次、交互卡片、关系、训练、活动、赛程与帖子 | 交互执行调用对应业务规则；回退依赖已记录的交互历史 |
| 提示词与模型 | PromptLibrary、PromptTemplates、PromptTransfer、AiContext、AiWireProtocol、各 Prompts、AiService、AiRequestQueue、各解析器 | 模板、固定协议、人物与事实、历史记忆、生成任务 | 最终 messages、模型响应、解析后的正文与标记 | HTTP、请求队列、实时字典、生成状态、结果保存回调 |
| 保存与联机 | CareerStore、CareerLibrary、CoopRules、CoopCoordinator、CoopReception、CoopStorage、CoopAi、CoopNativeRun、CoopWire、CoopSteam | 规则结果、模型结果、原版对局、真人命令、网络消息 | 磁盘文件、回执、接收者快照、流式消息、检查点 | 房主提交；客机后台解码、保存、准备独立视图，主线程按原顺序发布；存储按实际目录协调 |
| 局内显示 | LiveRunBridge、LiveMatch、LiveMaps、LiveRaceHud、LiveVoices、LiveCommentary、LiveCrowd、CoopLive、CoopBroadcast | 原版实际地图与战斗、已确定对手结果及用时 | 对手进度、解说、弹幕、人物头像 | 局内事件订阅；读取资源；播报历史与当前比赛保存 |
| 支撑与诊断 | Diagnostics、UiPerformance、LogPerformance、GameText、各头像与资源模块 | 实际请求、错误、阶段计时、资源、存档副本 | 日志、诊断包、格式化文本和缓存资源 | 凭据脱敏；资源缓存；性能记录 |

具体文件及函数依赖见[双向源码索引](SOURCE_MAP.md)。partial 类可能分布在不同模块文件，不能把单个文件误当成完整类。

## 国运、模拟与个人经济

| 模块 | 统一入口 | 输入、输出和下游 |
| --- | --- | --- |
| 逐场国运 | NationalFortune.Confirm | FinishFixture 的已确认赛果 → Fixture 收据、CircuitAward 累计、国家资金和 Contribute；CircuitLedger.Settle 补全最终名次，MatchImpact 提供结算及战报文字 |
| 国家发展 | NationalDevelopment.Contribute / SeasonStart / TryPublish | 国运先补维护再分配建设余额；换季计算 GDP 和维护不足下降；WorldEvents 的原有随机事件时机发布公报，继续使用 Publish 与原有社区生成队列 |
| 玩家模拟 | PlayerSimulation.Sample / Run | 本人真实历史优先、选定进阶优先 → RunPerformance；单人 FinishMatch、多人提议确认后 Settle，共用实际比赛结算入口 |
| 关注与报价 | CareerAudience、ClubAudience、SeasonCeremony | 玩家和NPC共用比赛/冠军奖励；ClubAudience.Total 汇总独立关注及现役选手影响；新报价共用两条倍率曲线；奖项保存实际AudienceReward供单人及多人收据使用 |
| 消费 | ConsumerEngine.Buy / Use | 商品目录、本人 Consumer、邀请对象与关系 → 钱包、物品、关系和公开事实；单人 EconomicActions.Save，多人 Apply/Capture |
| 消费事件 | ConsumerEvents.Purchase / Activity | 成功购买、活动结果 → 当天购物合并记录或独立已完成聚会记录；CareerLife.AddEvent 保存公开事实，原日期推进流程汇总发布 |
| 持续赞助收入 | SponsorIncome → CareerCommerce / CircuitLedger / OwnedClubs | 基础合同金额、付款时关注 → 个人赛季款和胜场款、普通俱乐部赛季款、自建俱乐部周款和胜场款；个人 RefreshOffers 自动续约并应用 NextOffer，原付款收据、保存及多人命令继续使用 |
| 商城购买展示 | ConsumerShop → ConsumerPurchases / ConsumerVisuals / ConsumerSeal | 本人 BoughtDay、Goods、PromoUsed 与商品目录 → 本季徽章、宣发进度、实物收藏与最近购买日期；每次刷新只读整理一次，不保存、不广播，样式缓存不含玩家资料；我的空间不接入 |
| 行情与交易 | CareerMarket、MarketDynamics、MarketExecution | Initialize补前史并迁移旧待计价信号；Advance按独立基准更新日行情；Fixture在正式赛果中即时计价；MarketExecution统一深度、买卖均价、预计清仓价值和实际到账，Trade执行资金及公共报价变更；WorldEvents通过TryPublish使用公开行情进入原AI新闻队列 |
| 经济提交 | EconomicActions.Save / Trade / Persist、CoopRules.Trade | 单人消费复制完整资料；交易复制资金资料，买卖另复制共同报价；统一Persist提交原生涯实例，异常回退资金与报价；多人复用Apply完整副本及MarketAccounts，处理其他成员强平，避免第二次复制整个生涯 |

MarketScreen/日程/无赛事页面通过AdvanceCareerDay共用日期推进；ConsumerShop.Select只重建ConsumerDetail。MarketPositionCard将持仓信息、平仓和保证金/止损编辑分开；Edit/Preview仅改本机控件，Apply/Send输出MarketOrder，经MarketTerminal.Submit→MarketScreen.MarketSubmit→单人EconomicActions.Trade或多人market命令→CareerMarket.Trade。MarketScreen → MarketTerminal复用CareerListCache的分帧预建控件；卡片Bind更新个人仓位、报价及版本并收起编辑区，Unbind对全部卡片Bind(null,null)，解除缓存中的仓位、报价和编辑状态。LifestyleArt提供本机缓存导航图标和原生商品插画。ConsumerScreen、MarketScreen、DevelopmentScreen使用现有CareerScreen、头像及样式入口，不修改游戏共享字体。没有独立网络协议、后台保存队列或重试机制。数据归属见DATA_CONTRACTS，提交顺序见PERSISTENCE_AND_COOP，规则与数值见GAME_AND_UI。

## 运行入口与非直接调用

品牌目录：MarketCatalog.Build→RegionalOrganizations.SponsorCatalog→地区Sponsors及CareerCommerce.LegacySponsors→统一Assets/ById及Version。CareerEngine.NormalizeRoster、日期/赛果及CoopRules.InitializeMarket共用CareerMarket.Initialize；检查、缺项生成、CheckedQuoteCount及原UpgradePricing均在此入口完成。市场搜索：MarketTerminal.Bind→MarketDynamics.Links→有效Sponsors、真人委托和自建俱乐部赞助，结果交给Partners及直接俱乐部名称索引；ResetList与ChangePage共用RefreshList。数据和生命周期见DATA_CONTRACTS及GAME_AND_UI。

市场展示：MarketTerminal.RefreshSelection→MarketExecution.Depth / MarketDynamics.Volatility→固定概况控件；RefreshSelection→EventTitle→四个MarketEventRow.Bind→日期、标题、报价变化与原人物回调。图表范围按钮→RefreshChart→MarketChart.Set。订单输入→RefreshFee→OpenFee及两次MarketExecution.Open→扣款、费用和方向均价；做多/做空→Open→统一Submit。MarketVisuals.ActionStyle提供按动作与状态缓存的样式，LifestyleArt.Icon提供做多、做空、确认、收起、清除及波动图标；保证金和止损编辑沿用MarketPositionCard.Apply/Send。界面刷新、切换个人视图、离开页面和Unbind的生命周期沿用本章原入口。

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
