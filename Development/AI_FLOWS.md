# AI 请求、交互与记忆

## 随机事件流程

首页或日历的 EventCards → OpenRandomEvent → EventCommand 接收开始、停止、跳过或选择。RandomEvents.Start 在当天首次开始时通过 EventPools.SelectRandom 读取当前模板的有效素材，默认110条，抽取0—3名可交流人物；最近24项素材参与排重，当前池全部用过后从当前池重新抽取。人物、Seed、Category 和 Materials 此时保存，重新生成继续复用。日历问号只表示日期。每次开始保存一次 generating；ProcessEventAsync 使用现有 PrivateForegroundQueue、EnterPrivateQueue 和 RequestPrivateAsync(task:event)，成功或失败再保存一次。进入事件页面与途中弹窗本身不会发起随机事件模型请求；开始生成才调用一次模型。

RandomEventPrompts.Compose 返回 system 与本次 user 两段。system 由 PromptLibrary.Get(options,"event") 与固定 RandomEventPrompts.Format 拼接；四种内置模板的可编辑部分为 Story。正式生成与试写共用 Compose，默认最终请求原文保持一致。编辑、恢复默认、导入和导出沿 PromptScreen/PromptTransfer；旧 JSON 和旧自建模板缺少 event 时补齐 Story。EditableText 仅移除可识别的完整原版 Format 段，保留自定义创作文字；读取旧存档覆盖、选择旧自建模板、导入和导出共用该函数。其他自定义文字保持原样，程序始终追加固定协议。Materials 包含玩家身份、人物性格战绩及关系、ChatTimeline 会话总结、合并后最近20项交流、CommunityMemorySearch 按整次请求检索的8项社区材料、相关国家九项指标及说明、当天比赛与活动、钱包及收入参考、库存、商品价格、品牌和有关俱乐部。Profiles 使用 includeConversation:false，交流统一由 ChatTimeline 提供。恶意行为可选人物只有好感≤0的本次人物。公开方式由界面选择。

模型逐行输出 title、story 和含 option/result/effects 的选项。RandomEventParser.Feed 保留跨分片 JSON，LiveStory 还原尚未结束的正文字符串；完整选项进入 Options。ProcessEventAsync 每100毫秒最多更新一次 EventLive，另在入队和获得名额时立即通知。Phase 区分排队、等待响应、思考和书写；Reasoning 复用 RequestPrivateAsync 的专用思维字段与 LeadingReasoningStream 标签解析。RandomEventParser.Validate 共用于正式生成与试写，要求故事及2—4个具有结局的选项。RandomEventEffects.Check 检查后开放点击；生成中的已解析选项提前显示效果。ready/failed 及中断后遗留的 generating 均可重新生成；正在运行时显示停止按钮。

PromptTesting.TestSources(event) 提供本日新事件及已经保存材料的事件。CreateTestSession 复制一次生涯，选择新事件时只在副本中抽取，其他事件直接复用 Materials。试写沿 event 连接和 PrivateForegroundQueue，通过同一 Compose、传输、解析、验证和效果预览入口完成一次请求；结果写入独立 PromptTestSession，保留前后两版，效果执行和正式事件保存次数均为零。连接及生涯检查沿原试写规则。

Choose 先检查整个选项，再应用一次，保存 Selected、Public 和 complete。钱包美元在此除以10一次；库存使用 ConsumerEngine.ChangeInventory；好感使用 PrivateMessages.ChangeFavour；临时百分比进入 NpcLearning.EventStatuses，长期百分比进入 ChanceShift；品牌行情使用 CareerMarket.EventPrice → Price → MarketClearing 原结算入口；建设使用 NationalDevelopment.Contribute；约战复用 PrivateAppointments.Error/CreateMatch，直接进入原日程。库存、钱包、人物编号和约战日期采用原规则，数值建议在材料中提供。

所选故事、行动与结局写成 RequestKind:event 的 PrivateTurn，参与人物各一份，共用 UserOrder，event:事件编号去重。ReplyDeleted=true，User 保存共同经历。ChatTimeline.PrivateHistory 将其标为共同经历；External 按事件轮次编号去重并保留知情人。原自动总结在后续聊天达到既有阈值时整理这些记录。没有会话时建立 EventOnly 会话供上下文读取，出现普通聊天后联系人列表显示。ListedInCommunications 同时供联系人列表和通讯初次打开时的自动选择使用。UnreadInCommunications 在原 SeenCount 之后仅统计可见的非 event 轮次，历史事件记录立即适用；共同经历仍进入上下文和自动总结。原清除私聊记忆入口同时清除事件轮次。约战完成后 RememberMatches 追加真实赛果；待赛、进行中均不写结果。公开选择调用 CareerLife.AddEvent，参与者包含本地玩家编号，沿用原发帖优先级与跳日/赛后时机。

跳过不提交选项效果或人物记录，生成中跳过同时取消请求。Stop 取消请求并将有旧选项的事件恢复为 ready，首次生成则改为 failed；命令保存一次，取消后的后台任务只清理队列和流式字典。重新生成期间保存原故事、选项和思维记录，成功才整体替换，失败继续使用上一版。关闭界面允许后台继续；切换生涯或事件状态改变后旧结果不提交。进程中断保留 generating 与材料，重新进入可重试；重试使用当前 event 方案及模板。Selected/complete 随生涯保存，用于重复点击与重载去重。旧存档缺省空 RandomEvents 和 Reasoning，首次 CareerLife.Ensure 添加未来问号。

2026-10-21 v0.27：RandomEventChecks 通过85项，EventJourneyChecks 通过33项；社区182项、周刊53项、独立试写19项通过。默认实际请求原文逐字比较通过，旧模板拆分和往返通过。请求使用模拟传输，存储使用回调；本轮未新增真实模型调用。原始记录在 .artifacts/v027-checks-final，既有 DeepSeek 故事验证仍在 .artifacts/random-events-verified。

## 按任务选择连接方案

AiRouting.Tasks 定义九项选择：weekly 周刊与介绍、news 发帖、discussion 回帖、private 私聊、group 群聊、private-summary 私聊总结、group-summary 群聊总结、arbitration 聊天仲裁、event 随机事件。随机事件未单独指定方案时使用 default。Category 将 profiles 归入 weekly，将 private-long-summary/group-long-summary 归入各自总结。自动帖子正文和同次生成的首批评论共用 news；玩家发帖或留言后生成的回应使用 discussion。两种聊天仲裁共用 arbitration，大小总结及手动/自动总结使用各自聊天的总结方案。

全部请求通过 AiService.Connection(options, task) → AiRouting.ProfileId 读取任务指向，再从 ConnectionProfiles 取得地址、模型和显示名称，从 ProfileKey 取得该方案密钥。返回 AiConnection 值快照。新闻、回帖、周刊在原队列及间隔等待结束后取得快照；普通聊天和仲裁在等待结束后调用 RequestPrivateAsync，SummaryRequest 在原总结信号量通过后调用同一入口。请求消息结构、解析器、总结条件、并发和间隔继续由原模块管理。

RequestPrivateAsync 的 task 缺省 private；群聊调用者传 group，两种仲裁传 arbitration，总结调用者传 private-summary/group-summary。BuildNewsPayload 可接收本次快照模型，独立 BuildPayload 查询 news。每次实际发送只取得一次连接快照，各请求持有地址、模型和密钥字符串引用。请求期间编辑设置后，已发送请求继续用本次快照完成；完成结果仍检查生涯、轮次和原任务状态。失败保存沿原入口处理，再次点击重试时读取当时的任务选择及已保存方案。

提示词试写按 Source.Scene 选择同一任务方案。PromptTestScreen 的确认窗口展示实际接收地址和材料；确认时及排队结束后校验该次连接，地址、模型或密钥变化时提示重新确认。重新测试展示当前方案，响应返回后的配置编辑保持本次结果有效；生涯归属与启用状态仍由 Current 校验。模型列表查询使用编辑框地址和密钥草稿，留空时读取当前方案保存的密钥；返回结果仍由原 queryRevision 和控件有效性决定是否显示。

单人 CareerStore.Load 与多人房主 View/CoopAi 使用 AiSettingsStore.Load 的本机对象。任务编号和方案编号属于本机配置；多人公开序列化继续通过 PublicOptions 仅保留 Enabled。离开设置页面会释放编辑控件及未保存草稿，已经发送的模型请求沿原后台处理完成。切换生涯、日期推进、关闭进程和断线继续使用原 current、恢复及检查点入口；之后重试根据本机当前配置重新选择方案。

验证：--ai-routing-checks 通过22项，使用模拟HTTP传输检查九类任务的实际地址、模型、密钥、旧配置转换、别名分类、重命名、失败后重新分配、发送后修改及公开快照过滤。--response-workflow-checks 通过社区182项、周刊50项、独立试写19项；--model-list-checks 通过29项。2026-10-20 首次旧配置转换0.1663毫秒/2304字节，预热一万次后的十万次 Connection 查询累计7.9069毫秒/0字节。这里计量本地查询，真实服务生成和Steam网络耗时另行测量。界面及独立密钥文件验证见 GAME_AND_UI 的模型方案设置章节。

## 总结响应与市场新闻

私信和群聊的小总结、大总结最终都调用 AiService.SummaryRequest → RequestPrivateAsync。非流式响应必须含非空choices数组、message对象和非空content字符串。缺少内容时抛出明确的InvalidDataException，Diagnostics记录响应字段及原始异常栈；不将空内容交给FinishSmallSummary/FinishBigSummary。总结原入口捕获失败、保存SummaryError、清理SummaryStatus；原文、旧总结及覆盖起点保留，下次仍使用原重试入口。没有新增重试机制。

WorldEvents在原随机事件时机按题材加权抽取（国运发展/市场动态各1.5、其余各1），抽中后调用NationalDevelopment.TryPublish或MarketDynamics.TryPublish，不进行额外发布概率或新增轮换。市场新闻仅使用最近七天尚未发布的最多八条公开赛事/经营消息及当前报价，交给CareerEngine.Publish和既有新闻队列；不会读取Trading、个人借款或仓位。模型输出仅用于帖子与评论，不改变价格。

正式比赛 FinishMatch 在 CompleteMatchDay 补齐NPC赛果后，用 WorldEvents.FixtureFacts 读取本赛事、当天、同轮次的已完成对阵，追加到战报 RelatedFacts、SourceBody 和 Body，再由 CommunityThreads.Remember 更新可检索资料。内容包含各席位姓名、通关/楼层、用时及团体比分；同日另一场玩家比赛仍待赛时只写“尚未完成”。AiContext.MatchContext 读取 RelatedFacts，因此即使采用结构化比赛资料而不直接使用 SourceBody，也能获得完整同轮事实。单人模拟、真人对局及多人 Settle 共用此入口，之后沿原保存与新闻生成队列执行，不推迟到下一天，也不调用额外模型。FixtureFacts 同时供市场消息和国运公报使用。
## 输入组织与输出使用

| 请求 | 主要组织入口 | 上游数据 | 输出使用者 |
| --- | --- | --- | --- |
| 社区新闻 | AiService.ProcessNewsAsync、AiContext、AiPrompts、AiWireProtocol.Encode | 待发布事件、比赛事实、候选人物、模板、公开记忆 | ApplyNewsResponse 更新原帖与回复，CommunityThreads.Remember 更新任务、记忆和程序评分 |
| 社区回帖 | ProcessInteractionsAsync → BuildDiscussionPrompt → AiWireProtocol | 本次玩家留言、目标帖及相关帖、人物与记忆 | ApplyDiscussionCore → ParseReplies；正文、父评论和作者编号分别处理，再经 Remember 计算程序评分 |
| 双周人物介绍/文章 | ProcessWeeklyAsync → ProcessEdition → BuildWeeklyContext | WeeklyJournal 固定的当期事实、已生成介绍、期刊模板 | ApplyWeeklyResponse 更新该期人物或文章，再保存阶段状态 |
| 私信 | ProcessPrivateAsync → Context → Compose → RequestPrivateAsync | 当前人物、关系、赛程、公开资料、附件、总结、按顺序排列的会话 | PrivateStreamParser → PrivateMessages.Apply → 对应业务规则 |
| 群聊 | ProcessGroupAsync → GroupChatPrompts.Compose → RequestPrivateAsync | 群成员、俱乐部、关系、活动、公开资料、总结、时间线 | GroupStreamParser → GroupInteractions.Apply → 私信交互与业务规则 |
| 私信/群聊仲裁及社区举报 | SpireArbitration.Compose / GroupArbitration.Compose | 普通仲裁读取完整相关往来；社区举报读取来源帖快照、具体被举报内容、人物实力与既有裁决 | Parse / Apply / Complete 记录裁决、封禁、致歉等 |
| 私信总结 | SummarizePrivateAsync → Summarize / SummaryRequest | 自己的有效聊天窗口及既有总结 | FinishSmallSummary / FinishBigSummary 更新总结和窗口 |
| 群聊总结 | SummarizeGroupAsync → SummaryRequest | 本群未覆盖完成轮次、成员通知、实际交互；大总结读取选定小总结 | 更新 SmallSummaries / BigSummaries 和 SummarizedThrough |
| 提示词试写 | PromptTesting、PromptTestData | 隔离试写资料与选定模板 | 试写结果显示；不是正式生涯交互提交 |

具体函数签名与上下游调用见[索引](SOURCE_MAP.md)。私信与群聊使用流式通道，社区新闻与互动等待完整响应后应用；不要把不同请求的返回处理混用。

## 经济和国家发展的公开事实

OwnedClubs.Advance 在周结欠款大于零时，经 CareerLife.AddEvent 写入生活事件和 life-fact 公开事实。标题包含 OwnedClub.ClubId 对应的俱乐部名称；正文通过 OwnedClub.ManagerId 和 CareerEngine.DisplayName 写入经营者，接续俱乐部名称、欠款及陪练与青训暂停情况。每个欠款周结执行一次名称查询和文本拼接，事件编号继续使用 club-debt- 加周结日期。CareerLife.PublishPending 将这些原始事实传给帖子 SourceBody，后续 AI 发帖、评论、周刊与公开事实检索共用已保存的文字。名称在事件发生时写入，历史事件和已发布正文沿用原记录。此步骤随既有日期推进保存与多人广播执行。

ConsumerEngine.Buy/Use → ConsumerEvents.Purchase/Activity → CareerLife.AddEvent，立即保存购买或已完成活动事实，不立即创建帖子。Purchase 合并当前玩家同日尚未进入帖子和周刊的购物记录，同时更新对应 life-fact 公开事实；Activity 每次单独记录完成情况和参加者，避免不同聚会混用名单。购物事实含商品、价格、同行人和实际新增关注。单人后续推进日期由 CareerLife.PublishPending 选择过去7天、早于当天的最多4条未发布生活事件；多人由 CoopRules.AdvanceMembers 合并成员事件，按原条件选择最多8条。两者通过原 CareerEngine.Publish 生成生活近况帖子，模型按已经发生的事实报道和讨论。PostId 防止重复发布，已有帖子不改写。关闭 AI 时沿用原生活事件发布条件，不另设补发队列。

NationalDevelopment.TryPublish 经 CareerEngine.Publish 写入 SourceBody、RelatedPeople、Schedule 与 CommunityMemories。人物选择、新闻生成、评论分支和检索继续使用原入口；公报包含国运及实际指标变化，WorldEvents.FixtureFacts读取已结算WorldFixture及SeasonCeremony.Participants，提供贡献来源比赛、真实出场者和团队比分。品牌新闻正文包含个人/俱乐部赞助对象及胜负，新闻按Competition归并补充赛果；单纯经营消息不添加虚构的赛事因果。NationalFortune.Impact 经 MatchImpact 进入 CareerResult.WorldImpact、比赛帖子和事实记录。

模拟比赛使用 FinishMatch/Settle 产生正式赛果，MatchRules.Report 标明模拟，不构造不存在的牌组或战斗证据。新增经济操作不直接调用模型，也没有另一套输出协议。行情、持仓及全部商品库存不自动拼入聊天上下文；个人账户不进入其他成员快照。

## 模板与固定协议

PromptLibrary / PromptTemplates / PromptPresets 提供内置和自定义文本，PromptTransfer 负责导入导出。旧模板缺少新场景时使用该场景默认文本补齐，不要求玩家原模板已有全部场景。

EventPools 统一读取随机事件与选手日常池。默认数据来自 RandomEventSeeds 的110条素材及其背景分类、WorldEvents.Topics 的36条普通日常、WorldMatchLife.MatchTopics 的48条赛后日常。固定10个随机事件分类、8个普通日常分类和8个赛后日常分类。随机事件按条目抽取，分类只选择画面；WorldEvents.PublishDaily 通过 Get(CareerData) 读取日常，继续按分类抽取、同类间隔14天、同人间隔42天，赛后分类要求人物近7天有已完成比赛。国运发展与市场动态保留专门候选和各1.5权重，其余分类权重1。被编辑分类按完整列表替换；缺省分类继续使用内置内容；空分类不提供候选；随机事件全部为空时采用内置110条，日常全部为空时继续处理国运和市场候选。

PromptTransfer 新导出 Version=3，EventPools 字段保存当前模板按分类的覆盖列表，键为 event:分类或 daily:分类，条目包含 Title、Detail；未修改分类省略。Read 支持版本1/2/3；旧文件缺少 EventPools 时 Apply 保留目标模板的池配置。新版文件提供 EventPools 时替换目标配置，空字典表示全部跟随内置。CreateTemplate 复制基础模板当前池覆盖，DeleteTemplate 清理对应池。固定 Format 仍由 RandomEventPrompts.Compose 追加，池内容作为选中的材料进入原请求，不新增模型调用。

EventPools.Get(AiOptions) 用 ConditionalWeakTable 按配置对象、当前模板编号与覆盖字典引用缓存 Random/Daily 数组；Save 校验并复制分类列表，替换当前模板字典并清理缓存。切换模板、导入、恢复默认后的保存都会重新构建；普通读取复用数组。WorldEvents 的共同世界视图通过 Get(CareerData) 读取房主 AiSettingsStore，个人随机事件沿原 CoopRandomEvents 的房主配置读取。生成请求只传入抽中的素材，整池保留在本机配置。已经保存的事件素材、材料和分类不随模板变化。

交互格式、字段含义与关键条件由程序固定注入。群聊会将私信协议示例补上 Actor / Target，再注入群聊 Format。可编辑模板仍决定文风，但不承担唯一格式约束。

附件回应提示由 ChatAttachments.ResponseGuide 统一定义，原文为：请根据交互格式要求来回应附件，口头回复不会视为成功回应。PrivateMessagePrompts.UserText 的 AI 材料分支、Context 中玩家界面请求和 GroupChatPrompts.UserText 在每份附件资料末尾调用 ChatAttachments.ResponseInstructions；社区举报的专用资料分支添加 ResponseGuide。覆盖礼物、活动、约战、训练、阵容、合同、比赛记录、帖子、评论引用和附加文字。UserText(forAi:false) 保持检索用原文。固定系统提示词继续使用既有协议；附件提示随当前轮次及历史附件材料组织，每份只添加一次，保存的附件正文保持原值。

ResponseInstructions 输入 PrivateOffer、当前会话使用的附件编号、可选 GroupChat 及发送者编号，返回回应提示和适用的完整格式示例。示例从 GiftProtocol、SocialAppointments.Protocol/GroupProtocol、MatchProtocol、ClubCoaching.Protocol、CoachLineups.Protocol、ContractProtocol 提取，代入实际附件编号、活动资料、约战条件和群成员编号。礼物列接受/拒绝；活动列接受/改期/取消；约战列接受/拒绝/改期；训练列受训者接受，群聊另列指定教练同意/拒绝；阵容列同意/拒绝；合同沿用要价格式。群聊附带 Actions 行，多名训练、约战或合同对象分别具有完整示例。参考资料类附件返回 ResponseGuide。函数只创建字符串和示例列表；编号映射仍由 PrivateInteractionIds 管理，保存及广播沿调用者原流程执行。

验证：附件格式与原业务检查共891项，覆盖六类交互的私聊/群聊完整字段、实际编号、多人训练及取消活动名单。当前存档的11个场景分别调用 deepseek 与 ollama，每对请求的 messages 完全相同；deepseek 的7个场景、ollama 的11个场景达到预期标记及程序执行结果。deepseek 私聊收礼、群聊收礼、群聊拒礼及群聊取消活动遗漏标记。两模型均有日程或比赛细节偏离资料的正文，本次标记通过数量仅表示交互执行。群聊共同活动多条接受标记按同一附件归并为一项；新生成的取消记录复制附件 Participants。测试使用存档副本，经原解析器和交互入口执行，正式存档保持原值。11次本地上下文整理累计分别818.83/808.15毫秒，分配180749464/180737736字节；两个进程各重新启动一次，首次最高169.92/166.25毫秒。外部请求累计37.93/98.24秒，单列于本地整理；群聊冷启动100毫秒目标仍待完成。原始请求、响应、逐次计时和语义核对保留在本地验证资料。

后端思维预算调整后的 deepseek 复测使用同样11个场景，逐项确认完整请求与前次相同。预期交互执行仍为7/11：群聊取消活动恢复正确，私聊活动改期本次遗漏标记；私聊收礼、群聊收礼、群聊拒礼继续遗漏。群聊接受共同活动本次输出一条标记，正确登记一项活动。服务端报告 reasoning_tokens 合计由1043变为3302，外部请求累计57.38秒；单轮样例用于记录实际表现，稳定性结论仍需后续证据。

ChatAttachmentLiveChecks 的 stranger 参数使用存档中已有、可发言、无私聊与关系条目、无共同群聊记忆且属于其他俱乐部或自由身份的人物；群聊在测试副本中通过 GroupChats.Create 创建三名此类 NPC 的会话。测试记录保存各场景开始前的关系、好感、私聊轮数与共同群聊数。半夜三点百香果（普通玩家、初识、好感0、私聊0轮、共同群聊0个）的11场 deepseek 测试保持玩家发言及系统提示词与前次相同；10个需要交互的场景全部输出对应标记，纯讨论保持零交互。群聊改期输出三条相同改期标记，产生三份待确认安排，后续已在群聊交互入口合并同轮相同活动标记；其余10个场景交互执行达到预期。请求总输入152744 token，单次13077—15003 token；人物、上下文长度及群聊人数同时变化，此结果用于定位场景差异。11次本地整理累计852.65毫秒，分配155031816字节；外部请求累计55.20秒。正文还将新群成员称为队伍成员，人物身份表述仍有偏差。

同一测试入口的 groupSize 参数指定包含玩家的总人数，excludedName 按人物公开名称排除成员；先加入陌生接收者，再优先选择当前存档玩家俱乐部成员，GroupChats.Create 在副本中创建群聊。10人群包含玩家、半夜三点百香果和8名同俱乐部成员，成员排除月光邮局。deepseek 五次实测输入24427—25868 token；活动接受、礼物接受、礼物拒绝、活动取消、活动改期的目标操作均执行成功。礼物接受同时输出另一成员的收礼标记及三条历史训练编号30的接受标记；请求历史资料中确实包含该训练附件及接受示例，现有交互检查拒绝这些额外操作，库存最终由4变为2。其余四次交互标记与本轮附件一致。本次活动改期生成一项待确认安排，前次三份重复安排已通过本地复现检查修复。五次本地整理151.9783、36.8、151.45、63.5、70.87毫秒（后四项为四舍五入值），累计474.5971毫秒，分配91115840字节；外部请求累计36.6337171秒，输入125182 token，其中缓存命中86528 token。完整逐次数据保留在本地 attachment-formats-deepseek-ten-member 验证资料。

群聊附件的对象行读取 PrivateOffer.Participants；处理人行读取 ActorId。对象名单为空时省略对象行。礼物界面选择器同时填写接收者和参与者名单；群聊实测脚本也按这个入口构造附件。格式组织按附件数量顺序遍历，仅生成本次消息字符串，保存和广播继续由调用者执行。

社区 news / discussion 的 ComposeSystem在可编辑模板后追加EvidencePrompt和原场景正文协议。程序评分通过CommunityThreads.Remember → CommunityVotes.Update计算。AI继续生成标题、正文、作者编号和父回复编号；受众评分由本地算法根据人气、内容倾向及讨论热度计算。

职业名称仅在程序资料入口转换。Entry.Init 将 CharacterIdentity.OriginalSource 绑定 GameCharacterNames.Originals，将 Source 绑定 GameCharacterNames.Definitions(GameBridge.Characters())。Originals 从游戏程序集的具体 CharacterModel 类型取得 ModelDb.GetId；当前注册模型属于其他程序集时排除该编号，按当前语言读取原始 characters.json；缺少条目时回退英文。它不读取或修改合并过皮肤文本的共享本地化表。名称表按语言缓存，首次读取及语言切换重新建立。没有手写原版编号或中文名称表。

CharacterIdentity.OriginalName 查询上述原版表；Name 处理人物等独立职业字段，ForResult 处理 CharacterId/Character。非原版职业从实际 CharacterModel.Title.GetFormattedText 取得界面名；已卸载职业保留记录名称，只有编号时保留编号。重名显示文字沿原规则保留，不根据名字猜测职业来源。Name 和 ForResult 的查询计时进入 UiPerformance.CharacterName；游戏资源读取、解析、分类和界面名读取有独立统计。Source 读取失败沿既有日志处理返回空资料，不增加重试。

| 转换入口 | 输入字段 | 下游 |
| --- | --- | --- |
| AiContext.PlayerPublicRecord | PlayerCard.Character、正式战报 CharacterId | 新闻上下文、提示词试写 |
| AiContext.MatchContext | 玩家战报、PeopleAtEvent 的对手职业、过往对阵战报 | 社区比赛事实 |
| AiDiscussion.Persona | CareerPerson.Character | 发帖、回帖的人物资料 |
| PrivatePublicContext.CharacterProfile / Profiles | NPC职业、玩家角色卡和当前职业、正式战报 | 私信、群聊、仲裁、相关人物资料 |
| GroupChatPrompts.Compose | PlayerCard.Character | 群聊玩家资料 |
| WeeklyJournal.CloseWeek | 新期人物背景的职业、新战报焦点事实 | 新期介绍与文章输入 |
| CareerNarrative.Feature | CareerPerson.Character | 新生成的程序人物介绍 |

AiWireProtocol.Encode、两个聊天 Compose、私信总结均不扫描全文。玩家消息、姓名、卡名、可编辑模板、已保存总结及历史正文原样传递。周刊的 slide.Character 是插图键，BuildWeeklyContext 不传此字段，不能改写插图资源键。

程序生成比赛文字的两个入口同时保存原文与可选的 AI 用文本。原文用于界面和检索；AI 文本在填写职业字段时生成，不扫描整段文章：

| 写入入口 | 保存的输入与输出 | 后续读取与请求用途 |
| --- | --- | --- |
| CareerEngine.FinishMatch → CommunityThreads.RememberMatch | Character 写入 CommunityMemory.Text；ForResult 返回值填入同一事实的 AiText，仅有差异时保存。Id 为帖子编号加 :result，同编号已有记录时不更新 | Retrieve 在原 Text 上过滤、计分、排序，选定后将 AiGeneratedText.Memory 写入返回副本的 Text。新闻、回帖、周刊及聊天公共资料使用这个副本 |
| CoopRules.Settle | details 中队员 Character 追加 SourceBody，ForResult 返回值追加 AiSourceBody。资源摘要与牌组文字共用原样后缀。Remember 将 AiSourceBody 传播至 :fact.AiText | MatchContext.cooperative.facts、BuildDiscussionPrompt.officialRecord、BuildNewsContext.facts 与 PostTexts 的事件事实通过 AiGeneratedText.Source 读取。原帖归档移出后，PrivatePublicContext.Community 通过 AiGeneratedText.Memory 读取保存事实 |

PrivatePublicContext.PostTexts 用同一次评论选取生成 Original/Ai 两份文本；PostText 返回 Ai。PrepareAttachments 将 Original 保存到 PrivateOffer.Detail，Ai 仅有差异时保存到 AiDetail。PrivateMessagePrompts.Context 的检索查询调用 UserText(forAi:false)，聊天时间线、本轮消息、公开会话记录与私信总结调用默认 UserText，使用 AiGeneratedText.Attachment；群聊 UserText 同样使用该入口，供群聊、时间线和群聊总结使用。角色发言、玩家原话及已有总结不改写。

AiGeneratedText 的 Source/Memory/Attachment 各自读取可选字段，缺失时返回原字段。新增字段使用 WhenWritingNull；Retrieve/PrivateAcquaintance 返回的事实副本只在原 Text 字段放入 AI 文本，不向模型增加存档字段。历史正文不补写，原战报 Character 与开赛界面保持皮肤名。新增文本随现有 JSON 深复制、保存和广播传递；没有新增保存节点、操作版本或请求重试。请求期间离开、推进、切换与崩溃恢复继续由原调用者处理。实测记录与未验证范围保留在维护者本地验收资料中。

CareerNarrative.Evaluation 中的未转换职业仅由 ProfileScreen 用于档案界面，不进入当前 AI 请求。CareerEngine.WorldActivity 也有未转换文字，但唯一调用前，EcosystemVersion >= 1 的分支已执行 WorldEvents.Advance 并返回，因此当前 AdvanceDay 不会执行该函数。两者不计入上述实际遗漏。WorldEvents 当前题材没有读取职业字段。

作者编号与显示名用途不同。AiWireProtocol 的短编号转换、姓名历史处理与职业名称转换也是不同功能；删除职业扫描不能连带删除其他编号转换。

## 社区检索的计算复用

GroupChatPrompts.Compose 创建一个 CommunityMemorySearch.Request，交给各成员的 Community 和 PostText；PrivateMessagePrompts.Context 同样传给社区与刊物话题匹配。GetTerms 以完整文字为键，复用 Terms 的检索词集合。文字发生变化时使用新键。集合仅供读取，没有缓存人物选择或权限；同步 Compose 返回后不保存 Request。

MatchesTopic 仍要求两个非闲聊词命中。Retrieve 的词频统计仅检查查询词，但最终计分仍按原文词集合的原顺序累加，保持浮点分数和同分排序。候选、日期、人物权重、排除范围、选帖数量、回复分支与保密判断仍由原规则计算。

## 单人私信完整流程

ProcessPrivateAsync 首次构建 Context 时同时记录 ContextSpan，保存 sending 状态后将同一文本和分段传入 Compose。复用仅在该次请求内有效，跨请求重新读取资料；Compose 仍核对该轮已保存 Context，已有恢复路径保持。三个存档副本共12次完整请求对照逐字一致。294轮私聊的完整本地准备旧路径313.48/127.92/154.08/150.77毫秒，复用后68.17/82.74/78.49/79.93毫秒；后者含 Context，计时不相加，分配约22.47MB/次。首个旧路径测量还包含首次缓存建立，不能当作独立冷启动对照。

### 场景、关系与公历协议

专属约会由 dm-date-open/dm-send 发起，沿用同一私聊处理器、同一模型方案、公开帖子选择和自动总结。请求末尾附加 DateScenes.Guidance，包括已审阅的 Scene/Emotion/Background 格式及该次真实素材编号。PrivateStreamParser 记录 SceneCues；完成后 TaggedLines 生成显示元数据，原 Reply 保留正文。回复成功沿原解析与请求状态判断。结束约会更新活动与状态，模型调用仍按原自动总结条件进行。

Activity/Match 的新示例使用 Date: yyyy-MM-dd。NormalizeFields 将 Date 换算为原 Season/Day 再进入既有解析和日程校验；旧 Season/Day 仍可解析。各附件的实际日期和完整示例由 ChatAttachments.ResponseInstructions 从统一协议生成。AiWireProtocol 对结构化 JSON 中 day/Day/*Day 整数日期换名为 date/Date/*Date 并输出ISO日期，零日期输出null，Days时长字段维持数值。CommunitySharing.Text(data, quote) 从已保存 Quote 重新组织日期；AiGeneratedText.Attachment(data, offer) 对旧举报JSON的日期字段进行同样转换，原聊天、评论和事件正文逐字保留。

礼物固定格式为 Gift 接受/拒绝；RelationshipGifts.Description 在附件中说明接受后确认恋人或誓约。解除誓约使用 Oath 接受/拒绝与附件编号，口头回答保持原关系和待处理状态。PrivateMessages.Apply 与 GroupInteractions.Apply 都调用 OathAttachments.Respond，群聊同时使用Actor识别实际接受者。

DeepSeek使用当前存档副本实测：恋人礼物接受、解除誓约接受、场景开场、公历私聊活动接受、10人群公历活动接受均执行预期操作。长私聊的解除誓约拒绝两次遗漏标记；程序保持关系且没有登记拒绝。无历史人物复测输出拒绝标记并登记。格式稳定性仍有缺口，原始请求、响应、缓存统计保留在本地验证资料。

长群聊性能实测：13名成员、106轮历史、120条社区帖的完整 Compose 为177.30/157.85/162.35毫秒，分配44.78/35.24/35.25MB。11名成员、9轮历史为26.00/19.08/18.58毫秒。长记录场景尚未达到100毫秒目标。群聊这项测量包含完整本地整理，模型与网络等待另计。

| 顺序 | 函数或回调 | 读取/计算 | 修改与保存 | 谁使用结果 |
| --- | --- | --- | --- | --- |
| 1 | CareerScreen.PrivateCommand → PrivateMessageCommands.Apply | 人物、消息、附件与现有轮次；dm-send经PrepareAttachments按当前权威来源准备社区引用 | 发送建立 queued；重试/重生成修改原轮；CareerStore.Save | 后台处理器根据 queued 找到本次请求 |
| 2 | ProcessPrivateAsync | current 获取绑定数据，检查人物和请求键；进入既有队列 | PrivateRequests 记录本次运行中的取消对象 | 同会话生成判断、取消入口 |
| 3 | 排队结束后的 current | 重新获取当前数据与同一 turn，避免使用排队前资料 | Context 重新构建，写入 turn.Context；Status=sending、清空 Error；save | Compose 使用该轮 Context；中断恢复读取状态 |
| 4 | Compose → RequestPrivateAsync | 模板、固定格式、稳定资料、变化资料、总结、时间线、本轮消息 | 请求日志；发送模型请求 | 流式接收与解析器 |
| 5 | PrivateStreamParser.Feed、Thinking | 正文、标记、reasoning 分片 | 更新 PrivateLive / PrivateReasoningLive；通常每 100ms 通知一次；此处不逐片保存 | 页面与多人 progress 回调 |
| 6 | 响应结束后的 current | 重新获取生涯、人物、轮次、封禁状态；确认仍 sending | ReplyOrder、Reply、Reasoning、Status=complete；PrivateMessages.Apply；清理重新生成状态；更新 LastReplyOrder；save | 页面、业务交互、后续聊天与总结 |
| 7 | SummarizePrivateAsync | 是否达到既有总结条件 | 达到条件时分别保存开始与结果；finally 按现有条件清理状态 | 后续聊天窗口与总结界面 |
| 8 | 页面阅读结束 | 实际已读轮数 | dm-read 存储已读变化 | 通讯列表和未读提示 |

社区引用在dm-send经PrivateMessages.PrepareAttachments → CommunitySharing.Prepare建立发送时快照；本次人物看到所选主楼或评论、来源主楼以及按根到直接父排列的父链。CommunitySharing.Text把这些字段序列化到AiDetail，UserText通过既有AiGeneratedText.Attachment读取；后续ChatTimeline、聊天总结及知情人物的公开记忆沿原附件文本路径读取。普通检索和界面继续使用Detail中的作者、所选正文及来源标题。引用采用独立community-quote类型，原完整帖子附件的postVersions筛选范围保持。

PrivateMessagePrompts.Compose在可编辑模板和既有固定协议后追加CommunitySharing.Protocol。协议说明quoted、sourcePost、parents的作者归属和用途，玩家态度由其另行输入的消息表达；引用正文作为讨论材料。旧自定义私信模板同样取得此协议。已发送轮次的Detail/AiDetail固定保存，重试与重新生成复用该轮附件，来源后续变化由后续新分享读取。本流程沿原dm-send、私信生成及总结请求执行，增加的独立HTTP请求和保存入口均为0。

分享专项以最终Release生产程序集执行真实Compose/Context/UserText和ProcessPrivateAsync，使用完整合成私信传输输入输出及两次ExternalSave回调，确认sourcePost、parents、quoted进入请求、用户另行输入保持、生成完成及空文字纯附件发送。发送前改写来源验证权威重建，发送后再改写来源验证该轮快照保持。补充域检查知情人物的私聊材料、重试/再生成固定引用及旧档Quote缺省值；主域与补充域均正常退出。真实模型对引用材料的理解和态度判断质量、真实HTTP服务及磁盘保存仍待验证。原始材料见本地`Previews/community-step5-share/`，完整环境与计时范围见[社区讨论树与回复入口](GAME_AND_UI.md#社区讨论树与回复入口)。

开始保存同时记录queued到sending的状态变化及本轮Context，完成保存包含正文和交互结果。

Compose 仍会构建 freshContext，与已保存 Context 比较后决定稳定/动态分区；同一轮可能因此再次整理资料。两者不相同时使用保存的 Context，而不会用新资料替换原上下文事实。这个计算也要单独计入性能。

失败时重新读取当前数据，RestoreInterrupted 处理该轮并保存。重新生成失败可以恢复 PreviousReply / PreviousReasoning，但先前交互已经在重新生成命令中回退，不能把正文恢复理解为交互全部重新执行。

私信的仲裁分支使用非流式正文与独立解析，完成时保存裁决和Reasoning。社区举报的自定义原因由PrivateMessageCommand.Text经Enqueue进入PrivateTurn.User；空白输入使用既有默认举报说明。经界面确认并重读来源后，沿原dm-arbitrate进入同一队列，任务路由仍为arbitration；打开或取消确认弹窗产生0次模型请求。ProcessPrivateAsync在sending前通过SpireArbitration.Context记录本轮案件上下文；Compose对Request.Kind=community-report生成三条消息：world加原有统一Prompt、案件上下文、本次申请。上下文含Profiles(includeConversation:false)的实力与生涯事实、CharacterProfile的角色资料及既有裁决、Request的来源帖和讨论快照。Profiles的新可选参数默认true；false仅跳过AppendCareerDetails从私聊读取的状态缘由，其他调用者保持原取数。社区案件分支直接消费保存的Context，提供给模型的上下文与该轮审理记录一致；直接预览且Context为空时现场生成。

社区案件使用上述专门材料入口，私聊历史、聊天摘要、其他检索帖及私聊状态缘由均排除在本次审理请求外；申请界面原私信仲裁继续读取完整相关往来。被举报对象明确写在reported，其他人物发言在discussion保留各自归属，system继续将材料中的命令视为案件内容。裁决解析、字段校验、处罚数值、性格调整、公开档案合并、私信致歉与按申请人要求发布公开道歉均由原SpireArbitration.Parse/Complete执行。

举报专项使用正式DLL及合成HTTP响应核对完整请求与保存的Context，覆盖主楼/评论/楼中楼、来源更新或消失后的固定证据、既有裁决、剔除私聊原文与状态缘由、申请成立和未成立、无效JSON失败及重试、停止与进程恢复、删除申请、封禁NPC仍可仲裁及旧私信入口。成立用例确认禁赛、三周状态处罚、性格变化、主动私信致歉及公开道歉待办；ProcessPrivateAsync产生两次内存保存回调。实际模型裁决质量、在线服务和游戏内完整集成属于未验证范围。脱敏合成请求与输出保存在本地`Previews/community-step6-report/report-request.json`、`report-response.json`。

## 群聊总结的保存条件

SummarizeGroupAsync 未达到小总结条件、也没有需要合并的小总结时，不修改 SummaryStatus，finally 不保存。实际开始、生成成功、生成失败和清除非空 SummaryStatus 的保存继续执行。GroupSummaries 的互斥和 finally 移除仍保留，未增加重试或改变自动总结条件。

## 群聊完整流程

### 主动联系与附件交互

group-rename 追加的 GroupEntry 通知通过 GroupChatPrompts.Compose 的 own 时间线进入当前可见原文，SummarizeGroupAsync 按原窗口读取这些 Entries。当前群名直接读取 GroupChat.Name；已经发送的模型请求保留发送时材料，后续请求使用新名称。主动联系提示词本次沿用原文。

单人 CareerEngine.AdvanceOneDay 和正式 FinishMatch 调用 ProactiveChats.Trigger。Trigger 先读取当日事件，再逐会话检查启用、连续完成回复数、当前请求状态和 LastTrigger；赛后概率、相关事件概率、普通过日概率依次检查，普通过日用于本次缺少相关事件的日期触发。随机种子包含世界、真人、会话、日期或比赛编号。同一会话每次触发最多建立一轮 queued；调用者沿原流程保存后，由 CareerScreen 的 StartQueued 或房主 StartProactiveChats 调用原 AI 入口。关闭页面继续沿已有后台请求生命周期处理；重试读取当前模型方案。

决赛识别在每次 Trigger 中按 match.CompetitionId 查询一次赛事，用 worldfinal/continental/worldcup 类别和 CircuitWorld.RoundCount 比较实际 Round，结果由所有会话共用。FinalAlwaysReply 开启且本场为决赛时，原 Hit 按100%执行；其余事件顺序和随机调用次数沿用原路径。主动请求继续使用原 Prompt 与实际胜负原因。一次赛后最多为每个符合条件的会话建立一轮，失败重试、关闭进程恢复和重新生成继续使用该轮编号；达到次数上限后等待玩家回应。相关字段和旧档默认值见 DATA_CONTRACTS。

Compose 在本轮消息位置追加 ProactiveChats.Prompt，包含真实触发原因，最后一次附加等待玩家回应的提示。主动轮次通过 ProactiveReason 区分，历史组织保留 NPC 回复；CountReplies 在完成后重算连续次数。纯附件发送也重置连续联系次数。

GroupInteractions.Apply 先解析人物编号、附件和成员资格，再按交互人物分组调用 PrivateMessages.Apply 或 SocialAppointments.Respond。同一轮中字段完全相同的 Activity 标记共用一次处理；不同日期、内容或参与者继续作为各自提议处理。共同活动按附件发起者归入同一交互记录；新建、改期和取消沿原交互回退记录保存。三名成员重复输出同一改期的复现检查现产生一项安排。

CardKnowledge.Find 分别由 PrivateMessagePrompts.Compose、GroupChatPrompts.Compose、AiDiscussion 的玩家发帖/回帖材料调用。输入仅为本轮玩家文字，首次按 SourceVersion 建立首字索引，完整名称按最长匹配并按卡牌编号去重；当前语言变化后重建。动态描述位于本轮资料，固定指令前缀沿用原值。GameCardKnowledge 使用当前加载卡牌定义生成名称及效果资料。

| 顺序 | 函数或回调 | 读取/计算 | 修改与保存 | 下游 |
| --- | --- | --- | --- | --- |
| 1 | GroupCommand → GroupChats.Command | 群、发送者、文字、附件或操作 | 建立 queued 轮次并分配玩家 Order；save | ProcessGroupAsync |
| 2 | ProcessGroupAsync / 队列后 current | 当前群与原 turn；同群运行中请求键 | Status=sending；save | 模型请求与恢复 |
| 3 | GroupChatPrompts.Compose | 本群及相关资料 | 完整 messages；本地文本组织不执行业务交互 | RequestPrivateAsync |
| 4 | GroupStreamParser.Feed | 流式正文与 Speaker 块 | raw / GroupLive 更新；新消息块超过已预留 SpeechOrders 时，current 获取最新数据，补齐 Order，并 save | 完整快照、时间线、后续最终 Replies |
| 5 | progress / Reasoning | 当前 raw 与思考文本 | 通常每 100ms 通知；多人发送私密分片 | 页面逐条显示与思考按钮 |
| 6 | parser.Finish → current | 最终解析、最新群和原 turn，确认仍 sending | Raw / Reasoning / Error；有效发言写入 Replies；封禁等发言写 Notices | GroupInteractions.Apply |
| 7 | GroupInteractions.Apply | 最终标记、实际回复、附件、参与人和方向 | 建立交互 Lane；调用 PrivateMessages.Apply 或活动规则；记录 Effects / Offers / Notices | 交互卡片、下方变化、赛程等 |
| 8 | 完成 | 已完成正文与交互 | Status=complete；群 Revision 加一；save；Notify | 页面、多人快照、自动总结 |
| 9 | 自动总结 | 条件和本群原文 | 实际生成时保存开始、结果和清理；无总结工作且状态为空时不保存 | 总结、窗口和原有自动触发机制 |

流式保存按“解析消息块数量增长”触发。一块分片中出现多条发言时一次补齐；分成多块到达可能保存多次。同一人再次发言会产生新消息块。不是每个网络分片都保存，也不是每名 NPC 恰好保存一次。

流式期间只预留顺序，不提前执行交互。Raw 正文在完成或失败时保存，实时出现的每个字没有因为顺序保存而全部进入磁盘。

群聊仲裁走独立 Compose / Apply 分支，保存完成状态与裁决。失败时保存 Raw、Reasoning、Error、failed 状态及群版本；finally 清理实时运行字典。

## 解析器与实际交互

| 层 | 输入 | 返回或修改 | 使用者 |
| --- | --- | --- | --- |
| LeadingReasoningStream | 响应开头完整 think 标签，允许跨分片 | 思考与后续正文分开；思考示例不交给交互解析 | RequestPrivateAsync 的 reasoning 与正文回调 |
| PrivateStreamParser | 私信正文流 | 显示正文、Directives、Error | 私信页面与 PrivateMessages.Apply |
| GroupStreamParser | 群聊正文流、Speaker、统一交互区 | Messages、Actions.Directives、Error | 逐条界面与 GroupInteractions.Apply |
| GroupInteractions | Actor / Target / Participants / Related 与标记 | 解析真实成员，按人物方向建立 Lane，复用私信规则 | 卡片、关系、训练、活动、发帖等 |
| PrivateMessages.Apply | 有效轮次、标记及原好感 | 合同/约战提案、关系、学习、状态、资料、训练与活动规则结果 | 保存、卡片、记忆、回退 |
| 各业务规则 | 人物、日期、附件、合同、席位、资金等 | 成功状态或原因；有的提案等待玩家确认 | 不因正文“同意了”而自动成功 |

当前无附件的约战“接受”按既有统一处理转换为邀请；有附件时核对该请求。邀请与接受仍需玩家确认后进入正式赛程。已经过期的邀约日期仍由规则拒绝并显示原因，不直接通过。

NPC 对 NPC 约战检测后显示暂不支持的卡片说明，不建立无法执行的比赛。封禁 NPC 的发言和交互由当前选择、提示词状态和应用判断共同处理；其记录仍可查看。

Favour 表示目标值，大幅调整进入玩家确认。群聊下方还显示印象、关系、学习、状态与资料变化，并非只有好感。训练、首发调整、活动等复用对应业务模块，须同时覆盖加入普通俱乐部、自建俱乐部、玩家岗位和多人情况。

角色卡手动编辑三项也使用现有个人关系数据，不经过模型标记解析或大幅好感确认。PrivateMessages.EditRelation(data, life, human, NPC, edit) 将本次非空字段写入 PrivateRelation，好感同时写 Life.Relationships，Revision 加一；全部字段未编辑时直接返回。随后 PreserveRelation(box, chats, human, NPC, fields) 处理同方向的旧交互记录。它只删除 Before/After.relation 中指定业务字段，保留回退对象、Revision及其余交互；因此旧好感差量不会减掉手动目标值，编辑印象也不会阻止旧好感、学习、合同等正常回退。新交互照常调用 Record，重新生成仍调用原 Rewind。

私信方向由 box.Conversations[NPC] 决定；群聊方向只匹配各群 Interactions 中完整键 `human/NPC/`，不按前缀猜测，不处理其他真人或NPC目标。群聊重新生成仍通过 InLane 接入 PrivateInteractionHistory.Rewind。手动写入没有改变上下文选择、保密、总结或请求格式；相关资料入口及保存失败恢复见[角色卡流程](GAME_AND_UI.md#角色卡编辑与个人态度)。

## 记忆引入、保密与排序

| 入口 | 来源选择 | 位置与下游 |
| --- | --- | --- |
| 私信 ChatTimeline.PrivateHistory | 对话对象参加的其他群；排除当前私信；每个来源最近 5 个完成轮次；日期不超过当前日期 | 与自己的保留原文按 Day、Order 排列；在当前待回复 UserOrder 之前 |
| 群聊 ChatTimeline.External | 当前群员相关私信、其他相关群；排除当前群 | 与本群记录按时间顺序组织；来源标记人物、群及知情人 |
| ChatTimeline.RelatedGroups | 当前相关 NPC 所参加的其他群，合并去重；不设置每人最多一个群的限制 | External、Summaries |
| ChatTimeline.Summaries | 每个相关来源最后一条大总结，以及覆盖终点晚于该大总结的最后一条小总结 | 前部稳定资料；注明来源与第一人称对应人物 |
| 社区 ChatTimeline.PublicMemories | 该人物确实参加的群，日期有效 | Persona 使用人物可知记忆；没有参加的群不作为其来源 |
| CommunityMemorySearch | 公开事实与观点、人物、日期、已生成状态和排除来源 | PrivatePublicContext、社区与周刊资料；各人选择仍分别执行 |

私信固定说明原文：聊天记录中可能穿插有外部会话记录，表示这段交流记录在对应时间发生于其他群聊。

群聊固定 Privacy 说明外部记录不是在当前群公开过的话；仅所标知情人知道，其余人只能依据当前实际公开的话回应。私信没有复用这段群聊保密说明。

外部会话原文随当前窗口推移消退，不等待来源生成总结。恢复本会话最新总结的原文范围见[数据约定](DATA_CONTRACTS.md)。群聊小总结只读取本群 own 轮次、成员通知和交互资料，不把外部私信原文作为总结输入。

私信和群聊共用 PrivatePublicContext.SelectCommunity 选择历史帖子。每个人按原有的 1/2/1/2/2/2 类候选收集最多十篇；群聊分别收集背景和话题候选，再按帖子编号合并。选中的帖子正文和事件事实完整发送。PostTexts 的 includeConversation=false 分支提供正文；主动附带的帖子继续使用默认的 PostTexts 路径。

CommunityPromptContext.SelectReplies 对整次请求的已选帖子统一选择评论：取参与者（含玩家）最近八条，再取与查询至少匹配两个有效词组、按匹配数除以评论词组数平方根排序的八条。词组采用英文数字词及相邻汉字对，沿用 CommunityMemorySearch 的日常用语过滤表。重复评论按帖子编号和评论编号合并；每个起点补齐全部父回复，再补一条日期最近、同日按原评论顺序靠后的直接回应。最终评论数量随父回复链长度变化。时间相同的候选使用评论编号确定顺序。Comments 输出原评论全文、作者、日期和回复对象，标题关联到同次请求内的完整原帖；观点标签与原始事件事实分别提供。

GroupChatPrompts.Compose 在早部放置背景帖正文，在当前材料部分放置新增话题正文及全请求的评论分支。PrivateMessagePrompts.Context 生成同样分开的正文与评论；OrderContext 按固定来源编号组织背景正文，话题正文和评论位于当前材料部分。排序后的帖子之间保留分段空白。已有 PrivateTurn.Context 仍作为本轮保存快照使用；没有保存快照的请求使用本次整理结果。

自动发帖的 BuildNewsContext 对整个批次调用一次 Retrieve，最多六条；社区回帖的 BuildDiscussionPrompt 对整个请求取八条；周刊取五条。CommunityThreads.Remember 分别保存事件事实全文、已生成帖子正文全文，以及每次更新时最后十二条评论的全文。Put 按记录编号更新，之前保存的其他评论继续留在 CommunityMemories。Retrieve 对同一 PostId 最多选两条；人物列表前三人的匹配权重各为8，其余各为3，人物得分累加，日期得分为1/(1+间隔天数/28)。自动发帖采用文字片段相交或人物相交的候选条件。

发送社区和周刊请求前，AiWireProtocol.Encode 为 memory/communityMemory 中的独立历史评论补充 sourcePostId、sourceReplyId、author 和 parentId。AddMemorySources 按帖子编号合并 communitySources，提供原帖标题、作者、日期、正文、对应事件事实及父评论全文。当前 targets 已提供的正文和父评论沿用该目标资料。源帖已经归档删除时，原 CommunityMemory.Text 继续提供记录。随后移除存档检索编号 Id、PostId，统一转换模型使用的短编号。Kind 保持 fact/opinion 原分类；新增来源字段用于阅读上下文，响应父级权限仍由当前 targets 的 conversation 判定。

BuildNewsContext 和 BuildDiscussionPrompt 各创建一次 ChatTimeline.PublicMemoryRequest。Persona 的群聊记忆引用按群聊编号和可见截止日组成；相同群和截止日的正文仅在 sharedGroupMemories 出现一次。正文包含原有知情人列表、最后一条有效大总结、小总结及最近五轮完成记录。不同截止日期分别保存请求材料。引用按群编号排序，全部人物资料完成后序列化共享材料。PrivateMessages.PublicMemory 继续按人物提供对应私下关系、总结和最近十条私信发言。BuildDiscussionPrompt 的当前目标帖依旧使用 complete=true，保留当日可见评论及其响应编号。

两个聊天Compose每次注入完整world及对应private/group提示词，再追加固定交互协议。PromptOverrides中的有效文本优先于模板默认文本；CustomPromptTemplates和PromptTemplateOverrides是模板资料，实际请求通过Get选择本场景文本。本群Compose读取全部已保存大总结与小总结，再保留从Min(SummarizedThrough, recentStart)开始的原文，使最近RecentRounds轮继续提供逐句内容。ChatTimeline.External对每个相关会话取最后五个完成轮次，每轮包含该轮全部发言；RelatedGroups按成员交集选择来源。人物数、来源数、发言数及正文长度共同决定最终请求大小。

自动总结条件保持当前代码：群聊未覆盖的完成轮数达到 SummaryEvery（默认 25）；私信 ContextStart 之后的有效完成轮数大于 MaximumRounds（默认 50）。删除最新总结回退起点后，下一次回复完成仍按这些条件判断，没有新增或修改触发条件。

CommunityMemorySearch 的跨请求缓存只保存纯词汇计算：CareerData 对应的弱引用索引按记忆编号及原文验证，原文改变后重新计算；评论弱引用缓存按 CommunityReply 实例及 Body 验证。生涯实例和评论释放后由垃圾回收清理。并发请求通过 ConcurrentDictionary 和评论缓存内部同步读取。Terms 使用字符扫描，英文数字下划线和汉字范围与原正则规则一致。

一次 Compose 的 Request 复用可见帖子、作者最近活动、人物相关记录、帖子话题判断，以及同一日期、查询词的文档匹配和词频。Retrieve 针对本次排除项扣除对应词频，再使用原有词汇分数、人物权重、日期权重排序；候选选择与六/八/五条数量规则沿用原入口。不同请求重新读取人物、日期、帖子状态与原文，退出函数后释放请求内集合。一次群聊最多执行每名 NPC 两次候选选择、一次全请求评论选择；每篇选中正文输出一次。缓存和评论选择都只整理请求材料，保存、广播与重试由原 AiService/CoopCoordinator 流程执行。

UiPerformance 增加 GroupContext、PrivateContext、CommunitySelect、CommunityBranches、CommunityRetrieve、CommunityAcquaintance 六项累计统计。父阶段包含内部阶段，统计时分别报告。ContextMaterialChecks 用本地诊断档重建三次相同输入，记录逐次耗时、分配量、完整请求和十个样例的评论选择；PublicDisputes 使用三段真实公开争论及玩家首次私信原话，分别构建私信和三人群聊请求，检查选中的公开评论确实进入 Compose 返回内容，人工核对争执起因、反驳与当事人最终公开表态。群聊为派生测试场景。ContextSelectionChecks 验证争执父链、日期、词汇扫描、共享群聊内容及固定前缀。实际服务端 token 与缓存命中率由网络返回 usage 字段确认，本地字符计数用于同输入前后比较。

## 社区与周刊状态依赖

玩家每条留言分别排队，按配置并发。同帖键与任务标识参与顺序和去重。帖子相关人物保存后参与后续讨论，候选不等于全部允许的发言作者。新闻多帖当前选择范围和社区输出协议由相应入口决定；不使用已删除 covers 来判断回应或建立跨帖跳转。

ProcessNewsBatchAsync 与 ProcessInteractionsAsync 从 EnterQueueAsync 调用开始进入原 try/catch/finally。入队立即抛错或返回任务失败时，原 FailureReason 写入失败原因；新闻将当前批次中尚在处理的帖子标记 failed、递增 Revision 并更新记忆，再由原 Save 提交，ProcessNewsAsync 随后继续下一批。回帖按原 PendingIds 判断 remaining，仍待回复的目标标记 failed，已回应目标沿用 completed；保存后移除本次 ScheduledInteractions 标记。失败任务经原新闻重试或回帖入口在同次运行中重新申请名额。

队列凭据由函数局部 lease 保存，获取成功后一直持有到状态保存及回帖任务标记清理完成，再在 finally 调用 Dispose。保存异常仍由原调用者处理，队列凭据的释放继续执行。EnterQueueAsync 的并发配置、同内容键顺序及等待原因仍由 AiRequestQueue 管理。每批新闻入队一次，每次回帖请求入队一次；成功路径沿用原保存次数和数据复制。局部凭据随请求释放，任务状态继续随原生涯保存；离开页面后任务沿用原执行流程，切换生涯继续使用 IsCurrent 校验，进程恢复沿用 RecoverInterrupted。

社区开始、排队、完成或失败保存的状态不同；开始保存的上下文还用于响应权限核对。AiWireProtocol.Decode、ParseReplies 的作者与 parent 判断依赖本次提供的编号资料。不能只依据模型 JSON 语法正确就认定业务引用正确。

自动发帖输出posts[]的id、title、body、replies；新回复包含id、authorId、parentId、body。ApplyNewsResponse先校验整批正文、作者和父回复引用，再写入成品并调用Remember。缺少必需正文继续进入原失败收尾。

互动响应reactions[]继续按postId及replies[]处理。ApplyDiscussionCore完成正文、禁言和等待状态检查后追加新回复、递增Revision，再调用Remember统一计算主楼与评论评分。

AiWireProtocol沿用原通用字段解析和短编号转换。新闻和互动任务继续沿原queued、sending、成功结果及finally保存顺序提交评分。多人先合并房主最新正文，再调用Remember；成员手动票继续从最新PlayerVotes读取。

新内容与离线回复均由Remember计算评分；旧内容经CommunityVersion=6的一次升级重新计算。具体公式、显示倍率和存档字段兼容见DATA_CONTRACTS，保存与多人合并见PERSISTENCE_AND_COOP。

2026-10-17程序评分检查覆盖新闻、回帖、离线回复、旧字段JSON往返、一次升级、乱序返回及玩家投票保留。实际ProcessNewsAsync和ProcessInteractionsAsync请求由内存传输检查正文协议；真实API与Steam联机另行验收。可复用入口为--community-vote-checks、--community-delivery-checks、--response-workflow-checks。本地证据位于.artifacts/pr12-validation-20261017。

周刊事实由 WeeklyJournal 在逐日流程中捕获，AiWeekly 分人物介绍与文章阶段完成。PublicationBacklog.Select 先使用原赛前、比赛、Priority、近期题材和日期排序，再进行原题材选择，最后将 RelatedPeople 包含 player 或 HumanIds 的帖子稳定排列在前，按 MaxNewsPosts 截取。相同人物相关帖沿用原排序；其余帖沿用原题材顺序。Compact 和 ProcessNewsAsync 继续将当次超额任务设为 superseded，原七天有效范围、分批生成、失败重试与保存入口继续执行。Select 创建本次候选列表和排序集合，读取最近八篇成品；缓存范围为本次选择。建队生活事实仍由次日 PublishPending 汇总进入这条队列。

加载 Recover 将中断任务恢复到既有可重试状态。多人公共结果由 CoopAi 合并，只提交本任务生成内容，保留期间新增真人回复和其他已完成结果。
