# AI 请求、交互与记忆

## 按任务选择连接方案

AiRouting.Tasks 定义八项选择：weekly 周刊与介绍、news 发帖、discussion 回帖、private 私聊、group 群聊、private-summary 私聊总结、group-summary 群聊总结、arbitration 聊天仲裁。Category 将 profiles 归入 weekly，将 private-long-summary/group-long-summary 归入各自总结。自动帖子正文和同次生成的首批评论共用 news；玩家发帖或留言后生成的回应使用 discussion。两种聊天仲裁共用 arbitration，大小总结及手动/自动总结使用各自聊天的总结方案。

全部请求通过 AiService.Connection(options, task) → AiRouting.ProfileId 读取任务指向，再从 ConnectionProfiles 取得地址、模型和显示名称，从 ProfileKey 取得该方案密钥。返回 AiConnection 值快照。新闻、回帖、周刊在原队列及间隔等待结束后取得快照；普通聊天和仲裁在等待结束后调用 RequestPrivateAsync，SummaryRequest 在原总结信号量通过后调用同一入口。请求消息结构、解析器、总结条件、并发和间隔继续由原模块管理。

RequestPrivateAsync 的 task 缺省 private；群聊调用者传 group，两种仲裁传 arbitration，总结调用者传 private-summary/group-summary。BuildNewsPayload 可接收本次快照模型，独立 BuildPayload 查询 news。每次实际发送只取得一次连接快照，各请求持有地址、模型和密钥字符串引用。请求期间编辑设置后，已发送请求继续用本次快照完成；完成结果仍检查生涯、轮次和原任务状态。失败保存沿原入口处理，再次点击重试时读取当时的任务选择及已保存方案。

提示词试写按 Source.Scene 选择同一任务方案。PromptTestScreen 的确认窗口展示实际接收地址和材料；确认时及排队结束后校验该次连接，地址、模型或密钥变化时提示重新确认。重新测试展示当前方案，响应返回后的配置编辑保持本次结果有效；生涯归属与启用状态仍由 Current 校验。模型列表查询使用编辑框地址和密钥草稿，留空时读取当前方案保存的密钥；返回结果仍由原 queryRevision 和控件有效性决定是否显示。

单人 CareerStore.Load 与多人房主 View/CoopAi 使用 AiSettingsStore.Load 的本机对象。任务编号和方案编号属于本机配置；多人公开序列化继续通过 PublicOptions 仅保留 Enabled。离开设置页面会释放编辑控件及未保存草稿，已经发送的模型请求沿原后台处理完成。切换生涯、日期推进、关闭进程和断线继续使用原 current、恢复及检查点入口；之后重试根据本机当前配置重新选择方案。

验证：--ai-routing-checks 通过21项，使用模拟HTTP传输检查八类任务的实际地址、模型、密钥、旧配置转换、别名分类、重命名、失败后重新分配、发送后修改及公开快照过滤。--response-workflow-checks 通过社区182项、周刊50项、独立试写19项；--model-list-checks 通过29项。首次旧配置转换0.1741毫秒/2304字节，预热一万次后的十万次 Connection 查询累计8.2061毫秒/0字节。这里计量本地查询，真实服务生成和Steam网络耗时另行测量。界面及独立密钥文件验证见 GAME_AND_UI 的模型方案设置章节。

## 总结响应与市场新闻

私信和群聊的小总结、大总结最终都调用 AiService.SummaryRequest → RequestPrivateAsync。非流式响应必须含非空choices数组、message对象和非空content字符串。缺少内容时抛出明确的InvalidDataException，Diagnostics记录响应字段及原始异常栈；不将空内容交给FinishSmallSummary/FinishBigSummary。总结原入口捕获失败、保存SummaryError、清理SummaryStatus；原文、旧总结及覆盖起点保留，下次仍使用原重试入口。没有新增重试机制。

WorldEvents在原随机事件时机按题材加权抽取（国运发展/市场动态各1.5、其余各1），抽中后调用NationalDevelopment.TryPublish或MarketDynamics.TryPublish，不进行额外发布概率或新增轮换。市场新闻仅使用最近七天尚未发布的最多八条公开赛事/经营消息及当前报价，交给CareerEngine.Publish和既有新闻队列；不会读取Trading、个人借款或仓位。模型输出仅用于帖子与评论，不改变价格。

正式比赛 FinishMatch 在 CompleteMatchDay 补齐NPC赛果后，用 WorldEvents.FixtureFacts 读取本赛事、当天、同轮次的已完成对阵，追加到战报 RelatedFacts、SourceBody 和 Body，再由 CommunityThreads.Remember 更新可检索资料。内容包含各席位姓名、通关/楼层、用时及团体比分；同日另一场玩家比赛仍待赛时只写“尚未完成”。AiContext.MatchContext 读取 RelatedFacts，因此即使采用结构化比赛资料而不直接使用 SourceBody，也能获得完整同轮事实。单人模拟、真人对局及多人 Settle 共用此入口，之后沿原保存与新闻生成队列执行，不推迟到下一天，也不调用额外模型。FixtureFacts 同时供市场消息和国运公报使用。
## 输入组织与输出使用

| 请求 | 主要组织入口 | 上游数据 | 输出使用者 |
| --- | --- | --- | --- |
| 社区新闻 | AiService.ProcessNewsAsync、AiContext、AiPrompts、AiWireProtocol.Encode | 待发布事件、比赛事实、候选人物、模板、公开记忆 | 新闻响应应用入口更新原帖与回复，CommunityThreads 更新任务和记忆 |
| 社区回帖 | ProcessInteractionsAsync → BuildDiscussionPrompt → AiWireProtocol | 本次玩家留言、目标帖及相关帖、人物与记忆、输出权限 | ApplyDiscussion → ParseReplies；正文、父评论和作者编号分别处理 |
| 双周人物介绍/文章 | ProcessWeeklyAsync → ProcessEdition → BuildWeeklyContext | WeeklyJournal 固定的当期事实、已生成介绍、期刊模板 | ApplyWeeklyResponse 更新该期人物或文章，再保存阶段状态 |
| 私信 | ProcessPrivateAsync → Context → Compose → RequestPrivateAsync | 当前人物、关系、赛程、公开资料、附件、总结、按顺序排列的会话 | PrivateStreamParser → PrivateMessages.Apply → 对应业务规则 |
| 群聊 | ProcessGroupAsync → GroupChatPrompts.Compose → RequestPrivateAsync | 群成员、俱乐部、关系、活动、公开资料、总结、时间线 | GroupStreamParser → GroupInteractions.Apply → 私信交互与业务规则 |
| 私信/群聊仲裁 | SpireArbitration.Compose / GroupArbitration.Compose | 申请、完整相关往来与裁决 | Parse / Apply / Complete 记录裁决、封禁、致歉等 |
| 私信总结 | SummarizePrivateAsync → Summarize / SummaryRequest | 自己的有效聊天窗口及既有总结 | FinishSmallSummary / FinishBigSummary 更新总结和窗口 |
| 群聊总结 | SummarizeGroupAsync → SummaryRequest | 本群未覆盖完成轮次、成员通知、实际交互；大总结读取选定小总结 | 更新 SmallSummaries / BigSummaries 和 SummarizedThrough |
| 提示词试写 | PromptTesting、PromptTestData | 隔离试写资料与选定模板 | 试写结果显示；不是正式生涯交互提交 |

具体函数签名与上下游调用见[索引](SOURCE_MAP.md)。私信与群聊使用流式通道，社区新闻与互动等待完整响应后应用；不要把不同请求的返回处理混用。

## 经济和国家发展的公开事实

ConsumerEngine.Buy/Use → ConsumerEvents.Purchase/Activity → CareerLife.AddEvent，立即保存购买或已完成活动事实，不立即创建帖子。Purchase 合并当前玩家同日尚未进入帖子和周刊的购物记录，同时更新对应 life-fact 公开事实；Activity 每次单独记录完成情况和参加者，避免不同聚会混用名单。购物事实含商品、价格、同行人和实际新增关注。单人后续推进日期由 CareerLife.PublishPending 选择过去7天、早于当天的最多4条未发布生活事件；多人由 CoopRules.AdvanceMembers 合并成员事件，按原条件选择最多8条。两者通过原 CareerEngine.Publish 生成生活近况帖子，模型按已经发生的事实报道和讨论。PostId 防止重复发布，已有帖子不改写。关闭 AI 时沿用原生活事件发布条件，不另设补发队列。

NationalDevelopment.TryPublish 经 CareerEngine.Publish 写入 SourceBody、RelatedPeople、Schedule 与 CommunityMemories。人物选择、新闻生成、评论分支和检索继续使用原入口；公报包含国运及实际指标变化，WorldEvents.FixtureFacts读取已结算WorldFixture及SeasonCeremony.Participants，提供贡献来源比赛、真实出场者和团队比分。品牌新闻正文包含个人/俱乐部赞助对象及胜负，新闻按Competition归并补充赛果；单纯经营消息不添加虚构的赛事因果。NationalFortune.Impact 经 MatchImpact 进入 CareerResult.WorldImpact、比赛帖子和事实记录。

模拟比赛使用 FinishMatch/Settle 产生正式赛果，MatchRules.Report 标明模拟，不构造不存在的牌组或战斗证据。新增经济操作不直接调用模型，也没有另一套输出协议。行情、持仓及全部商品库存不自动拼入聊天上下文；个人账户不进入其他成员快照。

## 模板与固定协议

PromptLibrary / PromptTemplates / PromptPresets 提供内置和自定义文本，PromptTransfer 负责导入导出。旧模板缺少新场景时使用该场景默认文本补齐，不要求玩家原模板已有全部场景。

交互格式、字段含义与关键条件由程序固定注入。群聊会将私信协议示例补上 Actor / Target，再注入群聊 Format。可编辑模板仍决定文风，但不承担唯一格式约束。

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

| 顺序 | 函数或回调 | 读取/计算 | 修改与保存 | 谁使用结果 |
| --- | --- | --- | --- | --- |
| 1 | CareerScreen.PrivateCommand → PrivateMessageCommands.Apply | 人物、消息、附件与现有轮次 | 发送建立 queued；重试/重生成修改原轮；CareerStore.Save | 后台处理器根据 queued 找到本次请求 |
| 2 | ProcessPrivateAsync | current 获取绑定数据，检查人物和请求键；进入既有队列 | PrivateRequests 记录本次运行中的取消对象 | 同会话生成判断、取消入口 |
| 3 | 排队结束后的 current | 重新获取当前数据与同一 turn，避免使用排队前资料 | Context 重新构建，写入 turn.Context；Status=sending、清空 Error；save | Compose 使用该轮 Context；中断恢复读取状态 |
| 4 | Compose → RequestPrivateAsync | 模板、固定格式、稳定资料、变化资料、总结、时间线、本轮消息 | 请求日志；发送模型请求 | 流式接收与解析器 |
| 5 | PrivateStreamParser.Feed、Thinking | 正文、标记、reasoning 分片 | 更新 PrivateLive / PrivateReasoningLive；通常每 100ms 通知一次；此处不逐片保存 | 页面与多人 progress 回调 |
| 6 | 响应结束后的 current | 重新获取生涯、人物、轮次、封禁状态；确认仍 sending | ReplyOrder、Reply、Reasoning、Status=complete；PrivateMessages.Apply；清理重新生成状态；更新 LastReplyOrder；save | 页面、业务交互、后续聊天与总结 |
| 7 | SummarizePrivateAsync | 是否达到既有总结条件 | 达到条件时分别保存开始与结果；finally 按现有条件清理状态 | 后续聊天窗口与总结界面 |
| 8 | 页面阅读结束 | 实际已读轮数 | dm-read 存储已读变化 | 通讯列表和未读提示 |

开始保存并不只是把 queued 改成 sending，还记录本轮使用的 Context。完成保存包含交互结果，而不只是文字。

Compose 仍会构建 freshContext，与已保存 Context 比较后决定稳定/动态分区；同一轮可能因此再次整理资料。两者不相同时使用保存的 Context，而不会用新资料替换原上下文事实。这个计算也要单独计入性能。

失败时重新读取当前数据，RestoreInterrupted 处理该轮并保存。重新生成失败可以恢复 PreviousReply / PreviousReasoning，但先前交互已经在重新生成命令中回退，不能把正文恢复理解为交互全部重新执行。

私信的仲裁分支使用非流式正文与独立解析，完成时保存裁决和 Reasoning。不能用普通聊天的标记执行路径替代仲裁。

## 群聊总结的保存条件

SummarizeGroupAsync 未达到小总结条件、也没有需要合并的小总结时，不修改 SummaryStatus，finally 不保存。实际开始、生成成功、生成失败和清除非空 SummaryStatus 的保存继续执行。GroupSummaries 的互斥和 finally 移除仍保留，未增加重试或改变自动总结条件。

## 群聊完整流程

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

社区开始、排队、完成或失败保存的状态不同；开始保存的上下文还用于响应权限核对。AiWireProtocol.Decode、ParseReplies 的作者与 parent 判断依赖本次提供的编号资料。不能只依据模型 JSON 语法正确就认定业务引用正确。

自动发帖由 ComposeSystem 在可编辑模板之后固定注入 EvidencePrompt 和 SystemPrompt；每帖输出字段为 id、title、body、replies。ApplyNewsResponse 先读取并检查整批字段，之后才提交；任何帖子缺少 title 或 body，GetProperty 会抛出 KeyNotFoundException，已经检查完的其他帖子也尚未保存。自定义 PromptOverrides 可额外描述另一种输出结构，固定协议仍会注入；诊断须核对实际最终请求，不能只读取自定义模板的原始 Sections。

周刊事实由 WeeklyJournal 在逐日流程中捕获，AiWeekly 分人物介绍与文章阶段完成。PublicationBacklog 处理积压，加载 Recover 将中断任务恢复到既有可重试状态。多人公共结果由 CoopAi 合并，只提交本任务生成内容，保留期间新增真人回复和其他已完成结果。
