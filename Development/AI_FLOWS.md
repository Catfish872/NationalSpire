# AI 请求、交互与记忆

## 随机事件流程

首页或日历的 EventCards → OpenRandomEvent → EventCommand 接收开始、停止、跳过或选择。RandomEvents.Start 在当天首次开始时通过 EventPools.SelectRandom 读取当前模板的有效素材，默认110条，抽取0—3名可交流人物；最近24项素材参与排重，当前池全部用过后从当前池重新抽取。人物、Seed、Category、Materials 和 PublicPosts 此时保存，重新生成继续复用。日历问号只表示日期。每次开始保存一次 generating；ProcessEventAsync 使用现有 PrivateForegroundQueue、EnterPrivateQueue 和 RequestPrivateAsync(task:event)，成功或失败再保存一次。进入事件页面与途中弹窗本身不会发起随机事件模型请求；开始生成才调用一次模型。

RandomEventPrompts.Compose 的前两条消息固定为 system:当前 world 模板、WorldGuidance世界观使用引导与 EffectInstructions按当前经营身份生成的效果说明、参与者引导及玩家事实要求 与 user:当前 event 模板、已保存 PublicPosts 近期公开原帖正文、PlayerRecord生成的独立玩家资料及精简战绩、已保存 Materials。参与者引导说明相关人物是本次参与者，人物效果使用其中的人物编号，相关人物为空时创作玩家独自经历的单人事件。玩家事实要求为：玩家信息必须以提供的事实为基准，不允许编造玩家的历史经历和比赛战绩。该要求由程序加入首次生成、自由行动续写和试写的系统消息。引导单独拼接，旧 Format 保留原文供旧模板识别；已有 Materials 直接复用。首次生成及试写在末尾追加 user:InitialFormat，要求 title、story 和2—4条 option/result/effects；此请求只说明首次创作任务。攻击性弱化版的 event 默认内容由 PromptPresets/reduced-aggression.json 提供，原样采用作者当前配置中的基础故事要求及千恋万花人物语气示例；其他三种内置模板沿用 Story。已有个人修改仍由 PromptLibrary.Get 优先读取。格式与效果说明由程序提供。编辑、恢复默认、导入和导出沿 PromptScreen/PromptTransfer；旧 JSON 缺少 event 时按所属模板补齐当前默认内容；旧自建模板沿原基础模板查询规则处理。EditableText 仅移除可识别的完整原版 Format 段，保留自定义创作文字；读取旧存档覆盖、选择旧自建模板、导入和导出共用该函数。Format 保留原版 LegacyInitialFormat 与 LegacyEffects 的逐字组合，供旧模板识别。实际 InitialFormat 移除笼统的数值正负表示增加和减少，由各效果分别说明。EffectInstructions 明确五类人物目标均为NPC，status/learning只调整NPC模拟比赛能力；补齐整数、商品/品牌/国家编号、临时状态期限、建设非负点数及约战日期/进阶/模式的解释。OwnedClubs.IsOwner为真时才加入clubFans整条示例和说明；未经营俱乐部时系统消息不出现该效果。首次、自由行动和试写共用Compose；Story及Continuation沿用原文。Materials 包含人物性格战绩及关系、ChatTimeline 会话总结、合并后最近20项私聊/群聊及共同经历、CommunityMemorySearch 检索的8项社区材料及其帖子正文和评论上下文、相关国家九项指标及说明、当天比赛与活动、钱包及收入参考、库存、商品价格、品牌和有关俱乐部。随机事件的 Profiles 使用 includeConversation:false、includePlayer:false，交流统一由 ChatTimeline 提供，玩家段落由 PlayerRecord 单独提供；私聊及群聊的 Profiles 默认行为保持原样。恶意行为可选人物只有好感≤0的本次人物。公开方式归界面。

自由行动沿 EventCommand → RandomEvents.Custom 保存 CustomAction 和 CustomState=generating，随后复用 ProcessEventAsync 的队列、event 连接方案、思维解析和保存回调，额外调用一次模型。Compose(custom:true) 在相同前两条消息之后追加 assistant:原标题与故事的JSON、user:Continuation及玩家行动JSON。Continuation 使用已批准的50—200字结局要求，明确延续上文故事的文风、叙述口吻和人物说话方式，并遵循当前模板的具体文风要求；当前引导采用字段说明，移除了原短篇过程概述示例。模型只输出 result/effects；原选项及其结局、效果不加入续写请求。可编辑模板每次重新读取，人物资料、私聊/群聊、总结和帖子沿用本次保存的 Materials，近期公开原帖正文沿用 PublicPosts。新帖发布后，已展开事件继续使用首次材料；新事件重新选择。旧事件缺少 PublicPosts 时默认为空，仍使用原 Materials。世界观模板、随机事件模板、玩家资料及战绩、Materials 相同时，前两条消息逐字一致，后端可以复用文本前缀缓存；修改模板后采用修改后的文字。

首次模型逐行输出 title、story 和含 option/result/effects 的选项。RandomEventParser.Feed 保留跨分片 JSON，LiveStory 还原尚未结束的正文字符串；完整选项进入 Options。自定义模式累计单个JSON对象，兼容多行缩进及代码围栏，流式期间提取 result 字符串；Finish 完整解析后将 CustomAction 直接绑定到选项 Text。Validate 在首次模式要求故事及2—4个完整选项，自定义模式要求一个完整结局。ProcessEventAsync 每100毫秒最多更新一次 EventLive，另在入队和获得名额时立即通知。Phase 区分排队、等待响应、思考和书写；Reasoning 复用 RequestPrivateAsync 的专用思维字段与 LeadingReasoningStream 标签解析。自由行动成功只替换 CustomOption/CustomReasoning/CustomState，原故事与选项保留。RandomEventEffects.Check 检查预览和可执行状态；玩家确认时 ChooseCustom 将此选项追加到原列表，再调用原 Choose，沿同一效果、共同经历及公开事实入口结算。

PromptTesting.TestSources(event) 提供本日新事件及已经保存材料的事件。CreateTestSession 复制一次生涯，选择新事件时只在副本中抽取，其他事件直接复用 Materials。试写沿 event 连接和 PrivateForegroundQueue，通过同一 Compose、传输、解析、验证和效果预览入口完成一次请求；结果写入独立 PromptTestSession，保留前后两版，效果执行和正式事件保存次数均为零。连接及生涯检查沿原试写规则。

Choose 先检查整个选项，再应用一次，保存 Selected、Public 和 complete。钱包美元在此除以10一次；库存使用 ConsumerEngine.ChangeInventory；好感使用 PrivateMessages.ChangeFavour；临时百分比进入 NpcLearning.EventStatuses，长期百分比进入 ChanceShift；品牌行情使用 CareerMarket.EventPrice → Price → MarketClearing 原结算入口；建设使用 NationalDevelopment.Contribute；约战复用 PrivateAppointments.Error/CreateMatch，直接进入原日程。库存、钱包、人物编号和约战日期采用原规则，数值建议在材料中提供。

人物效果通过 RandomEventEffects.Person 统一提取 favour/impression/status/learning/challenge 的目标编号，Check 调用 CheckEffects 按当前存档中可交流人物检查；名单外的现有NPC同样可以结算。失败时 Check 调用 Diagnostics.RecordEventCheck 保存原效果、选项、故事、生成资料和人物匹配结果，再返回原错误。相同事件、选项及错误在对应诊断文件仍存在时复用该文件；旧记录清理后再次失败可以重新记录。Choose 在 Apply 完成后，将所选效果中的人物编号去重补入 People，再调用 Remember 和公开资料入口。原抽取人物保留，其他未选选项的人物保持原状。预览、普通选项、自由行动及多人命令均使用这一处理。旧 ready 事件进入页面即可重新检查，使用原已生成故事和效果；complete 事件沿原完成凭证返回。Materials 仍保存生成当时的人物与记忆资料，结算增加的 People 用于经历、显示、公开资料及后续约战赛果。

所选故事、行动与结局写成 RequestKind:event 的 PrivateTurn，参与人物各一份，共用 UserOrder，event:事件编号去重。ReplyDeleted=true，User 保存共同经历。ChatTimeline.PrivateHistory 将其标为共同经历；External 按事件轮次编号去重并保留知情人。原自动总结在后续聊天达到既有阈值时整理这些记录。没有会话时建立 EventOnly 会话供上下文读取，出现普通聊天后联系人列表显示。ListedInCommunications 同时供联系人列表和通讯初次打开时的自动选择使用。UnreadInCommunications 在原 SeenCount 之后仅统计可见的非 event 轮次，历史事件记录立即适用；共同经历仍进入上下文和自动总结。原清除私聊记忆入口同时清除事件轮次。约战完成后 RememberMatches 追加真实赛果；待赛、进行中均不写结果。公开选择调用 CareerLife.AddEvent，参与者包含本地玩家编号，沿用原发帖优先级与跳日/赛后时机。

跳过不提交选项效果或人物记录，生成中跳过同时取消请求。Stop 取消请求并将有旧选项的事件恢复为 ready，首次生成则改为 failed；命令保存一次，取消后的后台任务只清理队列和流式字典。重新生成期间保存原故事、选项和思维记录，成功才整体替换，失败继续使用上一版。关闭界面允许后台继续；切换生涯或事件状态改变后旧结果不提交。进程中断保留 generating 与材料，重新进入可重试；重试使用当前 event 方案及模板。Selected/complete 随生涯保存，用于重复点击与重载去重。旧存档缺省空 RandomEvents 和 Reasoning，首次 CareerLife.Ensure 添加未来问号。

参与者引导加入前的验证：CustomEventChecks 45项通过，包含真实诊断存档副本中的人物、私聊/群聊和帖子、模板替换、共同前缀、文风衔接原文、分片与多行JSON、停止/失败恢复、序列化读回和重复确认。当前配置模型 gemini-3.5-flash 的真实首次生成16.305351秒、自由行动续写3.6289311秒，结局及3项效果解析成功；结局245字符、其中206个汉字，长度要求为模型创作指导。实际请求前两条消息逐字相同，共19918字符。服务未提供可核实的缓存命中统计。原始完整请求、结果和耗时位于维护者本地 .artifacts/commerce-polish-20261021/live。原随机事件85项及日期旅途33项回归证据仍位于 .artifacts/commerce-revision-20261021。

参与人物处理使用2026-10-21 profile3诊断副本验证：1596名人物、零初始参与者的四个原选项全部可执行；51项涵盖所选人物去重、好感/印象/状态/学习/约战、共同经历、公开资料、实际赛果、存档读回和客机命令。Godot1600×1000真实鼠标9项通过，从原途中提示进入、选择、查看结果到返回重开；单人存储采用界面测试替身。随机事件85项、途中停留33项、自由行动离线43项及双协调器11项回归通过。原始资料位于维护者本地 .artifacts/event-participants-20261021；本次提示词检查采用实际拼接结果，模型调用次数为零。

RandomEventPrompts.Compose 必须传入当前 CareerData。PlayerRecord 读取该视图的 Wins/Draws/Losses，发送与生涯界面一致的正式比赛累计胜平负；读取 Results 按日期从新到旧取最多5场，仅序列化公历日期、赛事、对手和 Outcome。Outcome 表示赛事胜负，Win 表示是否通关，两者分别使用。少于5场发送已有条目，空 Results 发送空数组，累计战绩继续读取原计数。近期记录包含 Results 中已保存的正式比赛及私下约战，累计计数仍按既有正式比赛口径。

PlayerRecord 同时通过 PrivatePublicContext.PlayerProfile 提供一次独立玩家资料，零参与者事件同样提供。PlayerProfile 与 Profiles 复用 AppendPlayerProfile、AppendAwards、AppendProfileClub、AppendStandings 和 AppendPlayerContract，读取姓名、游戏名、性别、国家、职业、参赛资格、角色卡打法与介绍、擅长角色、身份、地区、说话习惯、性格、俱乐部及岗位、国家队、世界积分、荣誉、赞助、周刊介绍和最高通关。独立段落使用故事场景称呼；公开比赛逐进阶统计和三场详细赛果继续仅用于原聊天 Profiles，事件仍使用既有五场简表。NPC的 Profiles 保留其自身经历、双方交手和当前事实，移除重复的玩家段落、玩家积分榜及合同。原聊天 Profiles 的默认输出和动态分段保持一致。

独立玩家资料及简表在当前模板之后、原 Materials 之前拼接一次，归程序生成的资料。普通生成与自由行动沿 ProcessEventAsync 传入当前生涯；多人沿成员 View 读取个人资料及战绩；试写使用 test.Snapshot，材料选择后保持该副本资料。PlayerRecord 每次组织请求重新计算，未加入事件持久字段；旧事件重试直接补充当前玩家资料及战绩，原 Seed、People、Materials 和已生成正文沿原生命周期保存。玩家资料或战绩变化后下一次请求读取新值，初次与续写在模板、玩家资料、战绩和 Materials 相同时保留同一文本前缀。该段近期赛果用于随机事件；累计战绩与历届荣誉经 PlayerProfile 接入共用 PlayerCompetitionRecord，其他聊天和战报使用同一整理函数。

战绩专项验证并入 EventParticipantChecks，合计62项；实际传输替身检查首次及试写请求携带简表，随机事件87项、途中停留33项及自由行动离线43项通过。真实诊断中的2胜0平0负、两场获胜记录仅增加158字符；五场上限、空记录、乱序日期、赛事胜负与通关分离、成员个人统计和模板/原材料复用均已检查。当前证据位于维护者本地 .artifacts/event-record-20261021；本次没有发起外部模型调用。

随机事件社区来源沿 Materials → CommunityMemorySearch.Retrieve → PrivatePublicContext.CommunitySources → CommunityText → PostTexts/CommunityPromptContext.SelectReplies/Comments。Retrieve 继续使用本次素材、参与者和玩家、当前日期、8条上限及同帖最多2条的原策略。CommunitySources 只把这些命中的现存可见原帖按编号去重，随后进入私聊 Community 共用的 CommunityText，提供完整正文、发帖者、日期和对应事件事实。SelectReplies 的可选 sourceMemories 参数把实际命中的评论加入现有选择起点，再沿同一父回复及后续回应规则整理。私聊、群聊默认省略该参数，原选择规则保持一致。原帖删除或不可用时复用 CommunityText 原有的事实、已生成正文及命中记录保留处理，按编号去重，继续区分事实与发言观点。检索与展开在同一个 Request 内完成，共用可见帖子和词汇计算；退出后释放请求集合。

社区资料作为 Materials 内的字符串随首次 generating 一起保存一次。重试、重新生成、自由行动继续使用该材料；已有事件内的旧数组形式仍作为原 Materials 文本直接拼接，继续兼容。PlayerRecord 读取当前视图，社区资料保持首次材料快照；切换生涯、关闭页面、进程退出和多人断线沿原事件流程处理。没有增加模型请求、保存、广播或新的跨请求缓存，未来日程仍按原范围提供当天比赛与活动。

2026-10-22 EventContextChecks 在3.92MB和18.27MB诊断副本各通过51项；覆盖单人事件、1/3名参与者、独立玩家事实仅出现一次、首次及续写前缀、旧材料、保存读回、命中评论父链和后续回应、删除来源、重试复用、两名多人成员各自的角色卡。较小副本的3名NPC还逐字对照修改前的完整 Profiles、动态分段和 Community 输出，全部一致。ContextSelectionChecks 31项、随机事件87项、旅途33项、含真实私聊群聊记录的 CustomEventChecks 43项通过；本次未调用外部模型或实测Steam网络与游戏界面。

性能原始逐次结果保留在维护者本地 .artifacts/event-context-20261022/after.json 及 large/after.json。每组按0、1、3名参与者各执行3次 Materials+Compose，文件分别记录材料整理、请求组织和整次耗时、当前线程分配量及请求字符数；完整计时包含内部步骤，累计值只相加整次操作。较小副本1596人、70条社区记忆、7篇现存帖，九次完整耗时为25.0046/0.5461/0.3610、6.0475/0.5204/0.4904、0.5601/0.5442/0.5749毫秒，累计34.6492毫秒、3828728字节；较大副本1604人、1137条社区记忆、95篇现存帖，九次为27.6184/3.1059/19.6098、9.5548/2.6842/2.4657、3.0160/2.8320/3.0224毫秒，累计73.9092毫秒、12114552字节。首次操作包含相关函数首次执行开销；测量前已整理3名NPC的原聊天资料。两组和自由行动回归在独立进程同时执行，因此结果含进程间调度影响。每次 Materials 检索一次并展开所选来源，每次 Compose 计算一次玩家段落、序列化一次资料并拼接请求；未保存或广播。多人个人资料已验证，房主及客机网络性能未测量。

## 世界观模板的实际接入

国运日常新版与攻击性弱化版的内置 world 默认内容分别采用作者本机对应模板的当前全文。两份相对原默认值仅增加生活状况要求：新版增加39字符，要求发帖、评论等展现当地民众生活并符合当前国运等级、数值及描述；弱化版增加50字符，在同一要求前补充关注国运数值和变动。其他文字逐字保留。PromptLibrary.BuildCurrent 的 world 常量与内嵌 PromptPresets/reduced-aggression.json 分别提供这两个默认值；读取和覆盖顺序、模板切换、导入导出、保存及广播继续使用下述原入口。个人已保存修改仍优先生效，更新默认值不改写个人配置或已有故事。

2026-10-22 验证：编译后的两个 Default 返回值分别为5575、5557字符，与本机对应配置逐字相等；源码和资源与修改前比较，其他内容保持一致。旧模板缺少板块兼容104项、内置模板47项通过，Debug测试项目及Release模组构建成功。独立PowerShell进程通过反射连续读取每个默认值5次，包含反射调用和计时的完整本地调用耗时：新版4.3579、0.1496、0.0064、0.0022、0.0018毫秒；弱化版13.1499、0.0166、0.0081、0.0025、0.0018毫秒；十次累计17.6968毫秒。对应当前线程分配分别为301872/4408/2488/2496/2504及154016/2456/2464/2472/2480字节，包含PowerShell及反射开销；首次包含原Lazy资源初始化。原始结果保留在维护者本地.artifacts/template-defaults-20261022/verification.json。本次只更新默认文本，没有新增检索、数据复制、保存、广播或缓存；仍使用原模板缓存和个人覆盖入口。真实模型回复、多人网络及游戏界面此次未重新实测。

世界观与游戏知识使用 PromptLibrary.Get(options, world) 读取当前所选模板及个人修改，缺省内容沿原模板查询入口提供。社区发帖、回帖、周刊文章和人物介绍由 AiService.ComposeSystem → PromptLibrary.Editorial 加入系统消息。私聊通过 PrivateMessagePrompts.Compose → Section，群聊通过 GroupChatPrompts.Compose → Section 加入系统消息；两处 Section 优先使用多人房主广播的 PrivatePromptSnapshot，缺省时读取本机当前模板。CoopCoordinator.Broadcast 把房主的 world 与聊天模板一同写入客机快照；房主实际处理聊天时清空旧快照并读取当前房主设置。

约会、约会日记与结束后的普通私聊感想使用同一 PrivateMessagePrompts.Compose，世界观随首条系统消息进入请求，场景及日记引导随后追加。私聊仲裁、社区举报的 SpireArbitration.Compose 和群聊仲裁的 GroupArbitration.Compose 也加入 world。PortraitDesign.Messages 将 world 放进角色外观设计请求的用户资料。私聊小总结、大总结通过 Summarize 读取专用总结模板、人物身份、性格和待总结内容；群聊小总结、大总结通过 SummarizeGroupAsync 读取专用总结模板及原文或小总结；这四种总结请求没有单独拼接 world。

随机事件由 RandomEventPrompts.Compose 在首条系统消息先加入 world，再加入 WorldGuidance，最后加入原效果说明；Get 每次读取传入 options，参数缺省时使用 data.Ai。第二条用户消息继续使用原 event 模板、PlayerRecord 和 Materials；首次格式与自由行动续写引导分别沿原后续消息加入。AiRandomEvents.ProcessEventAsync 及 PromptTesting 的事件分支共用 Compose，覆盖首次生成、重试、自由行动与试写。多人 StartEvent.Current 使用房主当前 AiSettingsStore 配置，成员视图继续提供个人战绩及事件材料。已经保存的故事与 Materials 沿原记录保留，下一次生成读取当时的世界观。此处每次新增一次 Get 查询和一次系统消息字符串拼接，增加的字符包括所选 world、WorldGuidance原文及分隔换行；请求次数、材料整理次数、保存和同步次数均沿原流程，没有新增缓存。

2026-10-21 WorldPromptChecks 35项通过，覆盖四个内置模板、自建模板、修改即时生效、导入导出、缺省配置、首次与续写共同前缀及私聊、群聊、发帖、回帖、人物介绍、周刊的实际消息。随机事件87项、途中停留33项和自由行动43项通过。使用18.27MB诊断存档副本、当前 reduced-aggression 模板及 DeepSeek 事件连接，三组固定素材分别生成加入前后完整回复，共六次真实请求，全部通过现有故事、选项、结局和效果解析；每组仅改变系统消息中的世界观，其他消息逐字相同。当前世界观5507字符，每次请求增加5509字符，服务报告增加3632个输入 token。六次外部请求分别26.55、23.18、21.89、21.41、19.21、21.25秒，包含模型和网络等待，每组只抽样一次。完整请求、响应和可阅读对照保留在维护者本地 .artifacts/world-prompt-20261021/live。

同一测试进程中，首次 Compose 4.8303毫秒、当前线程分配287256字节；再次首次模式0.0477、0.0119毫秒，各分配65816字节；续写模式0.0211、0.0121毫秒，各分配66984字节。五次 Compose 累计4.9231毫秒，分别测量完整调用，没有把内部计时重复相加。测试请求约2.99万字符，包含诊断副本中真实人物、交流记录、总结、帖子及经济资料。此项只测请求组织，材料整理与模型等待另列；多人房主和客机网络、游戏内完整交互此次未重新实测。

WorldGuidance的当前原文为：世界观资料用于保持社会背景、人物认知和实力尺度一致。故事以本次素材中的人物、处境和情感为中心，让世界设定通过生活细节自然体现。卡牌、怪物和打法知识在情节确有需要时使用，不要强行套用或强制使用；普通生活题材按其自身的趣味展开。叙述文风与人物语言遵循随机事件模板中的创作要求，文笔优美引人入胜。引导由程序按完整原文加入一次，适用于首次生成、重试、自由行动及试写；世界观、素材、记忆、模板与后续格式消息继续沿原入口组织。

本次世界观使用引导验证：使用用户提供的profile3诊断副本（career.json 3.92MB）和当前DeepSeek连接，礼物场景直接复用原事件保存的Materials，生活偶遇及比赛复盘按同一副本整理材料。每组保留同一世界观全文、事件模板和其他消息，仅增加WorldGuidance及分隔换行，共147字符、服务报告86个输入token。三组共六次真实请求；五份通过原解析器，一份比赛复盘回复首条story漏写右花括号，服务finish_reason为stop，完整原始回复已保留。测试入口现可独立重读已保存请求及响应，逐字核对发送内容后解析，不重复调用模型；当前43项核对通过。随机事件87项、途中停留33项、自由行动43项通过。模板预设逐项核对确认仅新增event，706字符与当前配置原文完全一致，原有其他场景保持相同内容。

对照样本中，加入引导后的生活偶遇正文减少了具体怪物和卡名；粉丝礼物仍采用尖塔周边并列举卡牌，题材多样性尚未达到稳定验证。六份完整回复、请求、原始响应及解析错误位于维护者本地 .artifacts/event-world-guidance-20261021/live。前五次外部请求分别25.25、14.72、15.52、24.47、20.77秒，第六次解析异常前未保存HTTP耗时，标为未记录，未以其他计时替代。

本次副本的Compose首次4.6740毫秒、分配301512字节；再次首次模式0.0512、0.0108毫秒，各分配51808字节；续写模式0.0232、0.0234毫秒，各分配52976字节。五次完整调用累计4.7826毫秒、511080字节，未重复相加内部计时。测试请求约2.09万字符，使用原人物、帖子、交流记录及总结入口；材料整理和外部等待另计，多人房主/客机网络及游戏界面此次未重新实测。

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

导入导出按已知场景逐项检查，额外场景字段保留。events 在缺少 event 时作为随机事件创作要求读取；两者同时存在时 event 优先，events 原文保留。Default 读取自建模板定义，Get 读取个人修改；Read/Apply 的 Validate 在补默认值前处理别名。date 等附加字段只随模板保存和导出，当前请求仍按已知场景读取。Export 将额外个人修改一并写入 Sections；Apply 导入已有目标模板时将额外定义保存到目标模板的覆盖字典，保证再次导出保留原文；未知字段不调用内置场景默认值查询。版本1、2、3共用上述兼容入口。每次操作遍历模板场景及额外字段，配置保存沿原界面入口，没有新增模型调用、保存或广播。配置字典直接读取，不增加缓存。

2026-10-21 使用诊断包内含 date/events 的自建模板执行 `NationalSpire.Tests/Check-PromptCompatibility.ps1`，38项通过，包含13个场景正文往返、额外字段保留、导入内置目标模板后导出、版本1/2/3及新旧随机事件字段同时存在。261220字符模板的导出、读取、应用、再次导出读取完整操作，首次34.66毫秒、再次13.70毫秒；当前线程分配7.43MB和5.48MB。以上为完整操作时间，未与内部步骤重复相加；未执行模型调用或界面文件选择。

EventPools 统一读取随机事件与选手日常池。默认数据来自 RandomEventSeeds 的110条素材及其背景分类、WorldEvents.Topics 的36条普通日常、WorldMatchLife.MatchTopics 的48条赛后日常。固定10个随机事件分类、8个普通日常分类和8个赛后日常分类。随机事件按条目抽取，分类只选择画面；WorldEvents.PublishDaily 通过 Get(CareerData) 读取日常，继续按分类抽取、同类间隔14天、同人间隔42天，赛后分类要求人物近7天有已完成比赛。国运发展与市场动态保留专门候选和各1.5权重，其余分类权重1。被编辑分类按完整列表替换；缺省分类继续使用内置内容；空分类不提供候选；随机事件全部为空时采用内置110条，日常全部为空时继续处理国运和市场候选。

PromptTransfer 新导出 Version=3，EventPools 字段保存当前模板按分类的覆盖列表，键为 event:分类或 daily:分类，条目包含 Title、Detail；未修改分类省略。Read 支持版本1/2/3；旧文件缺少 EventPools 时 Apply 保留目标模板的池配置。新版文件提供 EventPools 时替换目标配置，空字典表示全部跟随内置。CreateTemplate 复制基础模板当前池覆盖，DeleteTemplate 清理对应池。固定 Format 仍由 RandomEventPrompts.Compose 追加，池内容作为选中的材料进入原请求，不新增模型调用。

EventPools.Get(AiOptions) 用 ConditionalWeakTable 按配置对象、当前模板编号与覆盖字典引用缓存 Random/Daily 数组；Save 校验并复制分类列表，替换当前模板字典并清理缓存。切换模板、导入、恢复默认后的保存都会重新构建；普通读取复用数组。WorldEvents 的共同世界视图通过 Get(CareerData) 读取房主 AiSettingsStore，个人随机事件沿原 CoopRandomEvents 的房主配置读取。生成请求只传入抽中的素材，整池保留在本机配置。已经保存的事件素材、材料和分类不随模板变化。

交互格式、字段含义与关键条件由程序固定注入。群聊会将私信协议示例补上 Actor / Target，再注入群聊 Format。可编辑模板仍决定文风，但不承担唯一格式约束。

附件回应提示由 ChatAttachments.ResponseGuide 统一定义，原文为：请根据交互格式要求来回应附件，口头回复不会视为成功回应。PrivateMessagePrompts.UserText 的 AI 材料分支、Context 中玩家界面请求和 GroupChatPrompts.UserText 在每份附件资料末尾调用 ChatAttachments.ResponseInstructions；社区举报的专用资料分支添加 ResponseGuide。覆盖礼物、活动、约战、训练、阵容、合同、比赛记录、帖子、评论引用和附加文字。UserText(forAi:false) 保持检索用原文。固定系统提示词继续使用既有协议；附件提示随当前轮次及历史附件材料组织，每份只添加一次，保存的附件正文保持原值。

ResponseInstructions 输入 PrivateOffer、当前会话使用的附件编号、可选 GroupChat 及发送者编号，返回回应提示和适用的完整格式示例。示例从 GiftProtocol、SocialAppointments.Protocol/GroupProtocol、MatchProtocol、ClubCoaching.Protocol/GroupProtocol、CoachLineups.Protocol、ContractProtocol 提取，代入实际附件编号、活动资料、约战条件和群成员编号。礼物列接受/拒绝；活动列接受/改期/取消；约战列接受/拒绝/改期；群聊训练按全部受训者列出一条接受、一条拒绝示例，教练采用附件中的安排；阵容列同意/拒绝；合同沿用要价格式。群聊普通格式附带 Actions 行，约战或合同仍按对象给出示例；工具模式通过 ChatTools.Describe 将相同业务说明与实际示例转换为带 Type 的 JSON。多人活动和训练示例均只使用 Actor，字段列表以竖线分隔。参考资料类附件返回 ResponseGuide。函数只创建字符串和示例列表；编号映射仍由 PrivateInteractionIds 管理，保存及广播沿调用者原流程执行。

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

## 玩家累计战绩与历届荣誉

PrivatePublicContext.PlayerCompetitionRecord(d, honorDay) 是玩家正式比赛累计与历届荣誉的共用整理入口。输入当前玩家视图，honorDay 缺省为当前日期；返回文字，无存档副作用。总场数使用 Wins + Losses + Draws，胜率使用 Wins / 总场数，明确包含平局并标出统计日期；零场时说明尚无正式比赛记录。CircuitAwards 读取当前玩家编号对应记录，Honors 沿用原个人及合作队伍归属。按截止日期筛选，同一赛事与名次或同一荣誉合并全部赛季，赛季升序排列。

AppendPlayerProfile 调用本入口一次，私聊、约会 Context 与随机事件 PlayerRecord → PlayerProfile 因而获得同一份资料；GroupChatPrompts.Compose 在成员资料中调用一次；AiService.PlayerPublicRecord 在新闻和评论上下文调用一次，写入 competitionRecord。新闻荣誉采用该批帖子的最早日期，评论采用当前日期；累计计数明确标注当前统计日期。旧 worldHonors 最近两项与顶层 honors 最近三项由完整归并结果替代，seasonHistory 维持原近期赛季范围。各入口的近期比赛与战斗详情仍沿原材料提供。

每次请求只遍历荣誉并合并赛季，没有新增模型调用、保存、同步或跨请求缓存。旧存档使用原计数和荣誉列表，下一次组织请求直接生效。验证使用工作区 RecentChatRepairChecks 的 --recent-chat-repairs，覆盖五届冠军、平局、零场、日期截点、各入口共用资料及保存副本恢复。

## NPC完整荣誉

PrivatePublicContext.NpcHonors(d, id, name, day) 统一返回具名荣誉文字，day 缺省为当前日期。读取截止日期内全部 CircuitAwards，以及 Ceremonies 中本人获得的个人奖、年度TOP前8名和所属俱乐部集体奖。俱乐部奖以该获奖期间的 EntrantClubs 与已完成且实际参与的 Fixtures 核对归属；年度奖检查对应四个赛季，赛季奖检查当季。本人及俱乐部的历史数据来自原存档，返回文字时不修改记录。

赛事荣誉使用记录中的 Event、Place、Country；Country 表示参赛赛区，不采用赛事举办地。联赛MVP从原获奖 Reason 的俱乐部联赛全称保留赛区；俱乐部集体奖保留获奖俱乐部名称和所属赛区。同一名称、赛区和名次合并全部赛季，以第1、2赛季的形式排列。只输出一个人物荣誉标题和逐项荣誉，不加入颁奖细则。年度TOP仅保留前8名的具体名次及赛季。

排序依次为世界总决赛、国家队世界杯、洲际俱乐部冠军杯、其他国际赛事、国内联赛；同类赛事按名次排列。之后依次为年度个人奖、年度TOP前8、赛季个人奖、联赛MVP、俱乐部集体奖。同类同名次再按最近取得赛季降序排列。

Profiles → AppendAwards 用于私聊、约会和随机事件 Materials 的人物经历；群聊 Compose 在各NPC成员资料中调用；新闻和评论共用的 Persona 写入 worldHonors；BuildWeeklyContext 在选手介绍更新和周刊正文两种请求中写入 honors，并采用周刊截止日期。玩家仍使用 PlayerCompetitionRecord。组织文字只在原请求准备时执行，没有新增模型调用、存档字段、保存、同步或跨请求缓存；已有存档下一次请求直接采用完整记录。

HonorWeddingChecks 的 --honor-wedding-checks 覆盖原诊断人物的完整赛季、历史赛区、排序、MVP、年度TOP边界、日期截止、随机事件材料及其余共用入口，并检查50赛季和人物跨赛区记录。原诊断单人物首次整理9.7毫秒、后续低于0.1毫秒；50赛季整理0.36毫秒、分配141080字节。该两人群聊完整上下文两次为4.03与11.78毫秒、各约3.1MB分配，未增加保存或广播；这些是本地整理测量，未包含模型网络等待，也不代表Steam跨机实测。

## 单人私信完整流程

普通模式的 SocialAppointments.Protocol、GroupProtocol 和 PrivateMessagePrompts.SkillProtocol 保持原协议文字。ChatTools.ActivityIntentGuidance 仅在工具模式的 send_message 总说明接入一次：玩家主动提出活动，就视为有参加意愿；人物答应后就登记活动，无须玩家再重复确认或说明具体小时。ChatTools.ActivityProtocol 从原活动协议生成工具专用文字，说明文字邀约使用邀请和编号0，接受活动附件使用接受和附件编号；工具示例标题为接受玩家活动附件中的安排。普通协议继续采用原动作字段说明和示例标题。ChatTools.OrdinaryGuidance 在工具总说明列出需要登记的各类决定、变化及结束轮日记任务，只有全部未发生时才填写空交互。ChatTools.CompletePrompt 保持本次修改前的消息结构和提交内容，约会结束轮继续使用 DateDiaries.ToolEnding。原工具中的商谈具体时刻及形式引导已移除。活动日期、参数、卡片确认、执行、保存及同步沿原入口处理，每轮模型请求和保存次数保持原实现。工具说明随每次请求构造，模板和上下文继续采用原缓存范围；没有新增长期缓存。

群聊活动在 GroupInteractions.Apply 中先使用 PrivateInteractionIds.Resolve，把模型填写的短编号或完整编号转换为已有活动的内部编号，再确定所属人物。随后同一活动的重复决定沿原去重机制合并，SocialAppointments.Respond 读取同一记录。玩家卡片确认继续通过 group-offer-confirm → SocialAppointments.Confirm 完成。此修正覆盖普通和工具模式，没有新增编号或持久字段。

约会结束的完整记录说明、最后提交要求、工具示例和 Interactions 字段说明共同采用 DateDiaries.ToolEnding。已有日记时仍要求整理日记，DateDiaries.Complete 更新同一 OfferId 的条目；漏交时保留旧日记并记录本轮错误。普通聊天、约会开场及中途保持各自原提交说明。ChatTools.TeachingGuidance 仅插入工具的学习交互说明，使用玩家批准的原文区分玩家与NPC：玩家接受教学、NPC担任教学者时不登记学习，NPC听取新做法、形成新理解并决定采用时按原条件登记。工具内原普通聊天无需任何标记的句子收窄为没有上述学习变化时省略skill交互，其他交互分别判断。普通 SkillProtocol 保持原文。

ProcessPrivateAsync 首次构建 Context 时同时记录 ContextSpan，保存 sending 状态后将同一文本和分段传入 Compose。复用仅在该次请求内有效，跨请求重新读取资料；Compose 仍核对该轮已保存 Context，已有恢复路径保持。三个存档副本共12次完整请求对照逐字一致。294轮私聊的完整本地准备旧路径313.48/127.92/154.08/150.77毫秒，复用后68.17/82.74/78.49/79.93毫秒；后者含 Context，计时不相加，分配约22.47MB/次。首个旧路径测量还包含首次缓存建立，不能当作独立冷启动对照。

### 聊天工具模式

AiOptions.ChatTools 由本机 AiSettingsStore 保存，缺省false。BuildChatToolToggle 在私聊、群聊共用输入栏读取及修改这一份设置；发送、重试、重新生成及约会命令通过 ToolMode 把选择写入对应 PrivateTurn/GroupTurn。多人命令将 ToolMode 随原命令发送，房主重载自己的连接配置后仍使用该轮明确指定的模式；自动生成且没有指定模式的轮次读取执行端 AiOptions。更改按钮只影响后续请求，已经发送的请求沿原模式完成。仲裁、总结、社区及随机事件请求继续使用原协议。

PrivateMessagePrompts.Compose/Context 与 GroupChatPrompts.Compose 进入 ChatTools.Enter 同步作用域。世界观、玩家模板、人物资料、帖子和评论、私聊群聊记录、总结与赛程沿原入口组织；固定交互说明转入 ChatTools.Create 返回的 tools。Describe 从原协议转换参数示例，原业务说明继续是同一来源。私聊合同交互沿用经营俱乐部、人物可招募且不在本俱乐部的条件；Context 明确通过 send_message.Interactions 的 contract 项提交合同条款。群聊保留 Actor/Target/Participants/Related/Coach，Speaker 只确定正文发言者。约会场景写入正文段落的 Scene/Emotion/Background，结束轮增加 date_diary 交互，日记规则共用 DateDiaries.Protocol。

DateDiaries.Guidance 只由 Compose 在 pending.Scene.Ending=true 时添加本次完整约会记录；工具模式要求感想填写到 send_message.Replies，日记填写到 Interactions 的 date_diary 项。普通私聊、开场及中途场景均沿各自说明。ChatTools.Guidance 说明长期性格、观念和习惯变化采用 profile，并以判断依据与具体尖塔学习作区分；CompletePrompt 要求正文已经作出的各类交互决定在 Interactions 中填写。人物资料、学习、状态的判定与结算仍由原业务函数执行。

ChatTools.Create 只提供 send_message，按 Reasoning、Replies、Interactions 的顺序定义三个必填字段，并设置 strict=true。Reasoning 整理本轮事实、人物反应及交互决定；Replies 是完整正文段落数组；Interactions 用 Type 选择原交互字段，没有交互填空数组。群聊段落先写 Speaker，当前约会段落先写场景资料，再写 Reply。严格格式要求每个对象的字段全部必填，原协议可省略的字段通过 anyOf 枚举字段组合，保持原省略含义。比如只调整好感时仍可只提供 Favour，态度和关系沿原值保留。ChatTools.CompletePrompt 在工具模式消息末尾追加原有固定提交说明，玩家模板与前文资料保持原顺序；群聊使用 GroupSpeech 的 Replies 说明并引用 SpeechFormat 的接话顺序规则，ActorFormat 保留交互字段条件。共同活动采用工具专用的 ChatTools.ActivityIntentGuidance，人物同意参加时按实际日期和内容登记邀请。新邀请和处理待处理附件沿各自原动作及编号规则，已赴约活动继续当前场景。

RequestPrivateAsync 仅在这轮携带 ChatToolRequest 时增加 tools、thinking.type=disabled 与指定 send_message 的 tool_choice。工具模式与普通模式共用 TryGetEndpoint：完整的 /chat/completions 路径保持原样，填写服务根地址或 /v1 时补上 /chat/completions；域名、已有路径和查询参数沿玩家配置处理。直接连接官方 api.deepseek.com 与经过 apiagg 等转发服务均采用这一规则。玩家明确填写 /beta 时仍沿该路径请求。ChatTools.Create 保留 strict=true，RequestPrivateAsync 保留指定 send_message 的 tool_choice 和 thinking.type=disabled；普通官方接口接受这些参数的实测结果与 Beta 严格格式保证分别记录。关闭工具模式继续采用原请求。每轮主回复保持一次模型请求，附件与普通聊天使用同一入口。JSON和SSE共用 Feed，按 index 累积函数名、编号和完整参数。ChatReplyStream 逐字符解析参数，跨分片保留 JSON 字符串、转义和 Unicode 状态：Reasoning 进入既有 thinking 回调与轮次 Reasoning；Replies 进入既有正文回调，群聊增加 Speaker，约会增加场景标记。人物编号晚于正文返回时暂存该段文字，获得编号后显示；完成后复核场景位置。完整返回后再将 Interactions 转为原 Directives，由 PrivateMessages.Apply、GroupInteractions.Apply、DateScenes.TaggedLines、DateDiaries.Complete 执行、显示和保存。

解析接受普通 assistant content、旧独立功能工具、缺少 Interactions 的统一回复及单项参数错误。普通正文和工具正文同时存在时，先出现的正文来源负责显示，完整原返回仍记录；工具交互继续处理。工具完成原因 tool_calls 按完整响应处理。单项读取失败记录原因，正文与其他完整交互继续处理；连接中断、停止、跨天及切换存档沿既有请求取消、状态检查、失败、重试和保存入口。每轮一次主请求，工具执行后直接完成本轮。

PrivateTurn/GroupTurn.ToolCalls 保存该轮原始函数名、编号与完整参数，随原生涯和多人快照提交。后续上下文读取原正文、实际交互及现有总结，原始工具参数与 Reasoning 作为查看及诊断资料保存，不额外逐轮附加。重新生成和重试清除原调用数据；清除聊天或修改NPC回复时相应清除调用数据。ChatToolRequest、ChatReplyStream 及字符串缓冲只属于当前请求，完成或失败后随调用释放，没有新增长期缓存。工具定义按模式、群聊与场景资料生成，每次请求生成一次；切换模式后可重新建立模型前缀缓存。检索材料的原顺序和范围保留，两处提示词预览显示实际工具定义。保存节点与多人流式广播继续复用原入口。

诊断新增 chat.tools.request、chat.tools.response、chat.tools.applied，均调用已有 Diagnostics.Record，复用现有五份轮换文件。请求记录完整messages及tools，返回记录完整函数调用，应用记录具体轮次、解析字段及错误。trace/context关联传输，turnId关联执行；没有新增独立自动日志文件或长期内存队列。

当前统一工具模式实测使用用户确认转发至官方 API 的现有连接，模型编号 deepseek。月光邮局诊断原轮次无附件约战与有附件约战各连续五次，均一次请求、两次保存回调，含完整分析说明、正文及实际约战卡片；正文100—314字符，首段1.81—3.98秒、完整3.39—5.68秒。原约会诊断三种场景循环连续五次，均完整显示分析说明和5—8段场景，完整3.14—5.58秒、两次保存回调。群聊沿原存档人物及上下文，通过 group-send 发送明确活动附件后连续五次，均三条正文、一项有效活动交互、五次保存回调、无交互错误，完整3.57—4.91秒。群聊原句仅提出今晚交流的样本，有继续询问内容并填写空交互的情况；这些资料单独保留，未算入明确活动附件的五次通过。每类五次均在同一组提示词和工具定义下执行；后续群聊专用说明调整未改变私聊和约会的请求定义。该结果说明这些样本通过，不代表所有未来回复都能正确判断交互。
2026-10-25 官方地址修复验证：修改前使用临时密钥直接请求 https://api.deepseek.com/v1/chat/completions，模型 deepseek-v4-flash，保留与移除 strict 各六次，覆盖诊断中的训练接受、普通私聊、群聊邀约、约会开场和结束，十二次均返回完整 send_message 参数并通过格式检查；相同失败请求经 /beta/chat/completions、strict=true 仍返回 anyOf 参数格式错误。修改后通过生产 RequestPrivateAsync 的真实 HTTP 传输直接请求官方 /v1/chat/completions，保留 strict=true、指定 send_message 并关闭模型思考，返回 HTTP 200、261字正文及工具调用，185次正文回调，首段4126.70毫秒、整次6333.27毫秒、一次请求。该次复测使用保留的诊断请求资料和生产流式解析，没有执行游戏内交互结算。另以模拟响应验证七种配置地址在普通和工具模式下的最终路径，共十四项通过；首次39.27毫秒，后续0.046—13.12毫秒，十四次累计58.25毫秒，逐次分配16400—1577872字节。每次各一次请求，未增加保存、同步或长期缓存。既有工具模式生命周期回归235项通过，包含私聊、群聊、约会、日记和测试文件保存恢复。模拟响应检查与真实网络测试分别记录。本轮没有经 apiagg 进行实网复测，也没有运行 Godot 界面或 Steam 多人连接。

上述请求、完整参数和结果分别保留在本地 .artifacts/unified-reply-strict-private-final、unified-reply-strict-date-final、unified-reply-strict-group-activity-final。该组统一工具、普通正文、旧独立工具及缺少交互字段的离线回归通过；原群聊与约会诊断全文重放、原字段定义一致性、逐字符转义及Unicode解析通过；主客机协调器模拟14项通过。该组保存由回调计数，后续完整生命周期与界面证据见下段。按钮悬浮说明为开启严格工具调用及使用API允许的强制工具调用，其余文字保留，包括已测试DeepSeek官方API、其他渠道可用性未知。

完整入口回归由工作区 NationalSpire.Tests/ToolModeCoverageChecks.cs 的 --tool-mode-coverage 执行，离线235项覆盖私聊和群聊的开关、发送、重新生成、失败重试、纯附件、主动联系、停止及重试，12类交互在两种聊天中的逐字参数转换，以及约会开场、中途、暂停继续、失败修订、结束失败重试、重复结束、结束后重新生成。保存回调将完整副本写入测试文件并反序列化核对；测试项目链接生产源码并使用存储替身。只传输原协议的六类请求核对 tools、tool_choice、thinking 均未注入；完整调用关系另经源码核对，覆盖仲裁、总结、形象设计、随机事件及试写。

最终提示词的真实 DeepSeek 验证保留在本地 .artifacts/tool-mode-dates-final 与 tool-mode-all-final。约会连续5次完整流程，每次开场、中途、暂停继续、结束各一次请求、共8次保存回调，结束感想110—160字符，日记内容与地点完整，只有结束轮包含日记要求。五次全流程耗时16704.61/16680.65/15813.01/13839.28/15054.13毫秒，包含网络、模型和测试文件读写。另有17次原请求重放验证赠礼接受和拒绝、约战、发帖、合同、训练、阵容、水平、状态与人物资料；其中人物资料连续5次经 PrivateMessages.Apply 写入并检查字段值，再保存及读取副本。普通安慰样本未形成状态变化，空交互单独记录。私聊、群聊各3次关系询问、活动邀约、解除誓约经过实际命令和处理器；活动及解除誓约均登记，原有关系未改变的询问保持空交互。该组共23次真实请求；原请求重放除人物资料外核对模型与解析结果，其他业务规则由原253项交互测试覆盖。

NationalSpire.MultiplayerTests/ToolLifecycleUiChecks.cs 的 --production-ui --tool-lifecycle-ui 使用真实生产程序集和 Godot 控件、隔离用户目录，重放真实模型结束回复。15项检查覆盖两处悬浮文字、私聊群聊共享开关、设置清除内存后从文件恢复、两种提示词预览、赴约、场景发送、模拟结束连接失败、原界面重试、感想和日记显示；4次请求、13次保存回调，截图保留在本地 .artifacts/tool-mode-production-ui。该保存使用 ExternalSave 写测试文件，不包含正式 CareerStore 备份链；真实Steam多人及游戏内实际网络故障未实测。主客机协调器工具模拟14项、群聊1746项及模型返回兼容46项通过。

最终增量分片性能保留在本地 .artifacts/tool-unified-complete/offline-performance.json：1000字符61片三次0.7243/0.6981/0.6577毫秒，分配329104/320944/310600字节；300000字符18001片三次125.9346/128.4647/121.4367毫秒，分配50630360/45376976/45376976字节。测量包含工具构造、模拟分片编码、增量处理及全文解析。18项命令处理包含测试文件序列化、写入和反序列化，首次370.31毫秒，再次134.38—243.46毫秒；首次含初始化，不能当作群聊上下文单项性能。该次修改增加固定说明文本，工具构造、请求数、保存和广播入口维持原路径。

本地分片处理包含工具定义构造、模拟JSON分片创建、增量读取及最终全文解析，1000字符三次0.746/0.762/0.695毫秒，分配328784/320624/310280字节；300000字符18001片三次134.69/145.07/113.63毫秒，分配50635288/45376656/45376656字节。这里含JSON编码后的网络分片对象分配，不等于游戏常驻占用或单帧成本。约会无网络全文重放首次140.20毫秒、再次5.14/7.43/3.80/2.92毫秒，首次含上下文和解析初始化。含服务等待的完整请求与本地步骤分别记录，嵌套耗时不累加。请求内字符串随本轮完成释放；完整调用参数沿原聊天保存与清理机制保留，自动诊断沿已有五份轮换入口保存。

旧版独立功能工具模式的模型实测使用当时存档副本、月光邮局原旅行邀约、玩家修改后的模板和当前连接的deepseek。两次关闭中一次缺少交互，两次开启均生成活动确认卡片；另一次11人群聊工具邀约登记成功。完整私聊本地准备24.26/39.19/28.51/19.65毫秒（依次关闭/开启/关闭/开启）；11人、1646名人物、120篇帖子群聊准备60.38毫秒、分配约21.0MB。服务等待单列为5.0至8.0秒。另有两次复用原轮次上下文的对照，关闭均遗漏、开启均登记；这组不作为新鲜上下文的耗时依据。真实Godot鼠标操作核对共享按钮、悬浮说明和1600×1000/1280×800布局。模拟主客机协调器验证模式传递、正文回传、交互归属及保存同步；真实Steam多人未实测。完整请求与回包保留在本地 .artifacts/chat-tools-20261024-final，界面证据位于 .artifacts/chat-tools-ui。

旧版独立功能工具模式的补充模型实测位于本地 .artifacts/chat-tools-other-interactions-20261024：使用上述同一存档副本、当前模板和deepseek，共15次请求，均有可显示正文。私聊赠礼接受扣除2件、拒绝保留原3件；私聊及11人群聊约战生成待确认卡片，代发帖生成待确认草稿，群聊赠礼归属月光邮局并扣除2件。训练登记一周计划，阵容调整登记下赛季待生效请求，合同登记完整报价，均经原业务入口执行且没有交互错误。教学、持续习惯变化各测试2次，各有1次正文明确表示采纳而未调用工具，另1次分别实际记录学习和档案变化；工具模式仍有偶发遗漏。安慰场景回复仍表达担忧，没有状态工具，不能据此断言状态交互遗漏。参数核对另发现4次调用省略Reply、1次群聊赠礼多填Target；这些样本均有正常正文并正常结算。PowerShell反射驱动首次准备276.11/301.46毫秒，其余43.27至155.77毫秒，含宿主及首次调用开销，与前述C#驱动测量条件不同；服务等待2.53至10.49秒。测试未修改真实生涯、全局设置及实现源码，样本数不代表长期成功率；本轮没有实测誓约解除、约会场景及结束日记的模型调用。

群聊人物标题回归位于本地 .artifacts/group-speaker-robustness-20261024。诊断包190554中的三次完整响应逐字重放，经 ProcessGroupAsync、原交互执行与完成保存回调，均保留全部5条发言；另一次连接提前结束保留原传输失败处理。诊断原请求的13条消息仅替换固定正文格式说明，12项工具定义与原记录逐项相同，重新调用deepseek两次均显示5条发言，分别登记1项、2项工具，Error与Notices为空；总耗时13.86/22.03秒，每轮一次请求、7次保存回调。测试保存回调仅计数，未改写正式存档；本次未启动真实游戏或Steam多人。

该存档包含1596名人物、7篇帖子、6名群成员与1轮群聊。无网络的三次完整响应重放耗时134.37/5.81/21.32毫秒，分配5059680/3163584/2795144字节，每次7次保存回调；首项包含首次上下文与解析初始化。解析器已初始化后的404字符逐字解析为0.0389/0.0348毫秒、各分配25616字节；40499字符及500条发言为2.31/2.36毫秒、各分配2496944字节。完整响应重放与单独解析是不同测量，耗时不相加。标题检查覆盖22种写法及任意两段、逐字分片，普通正文编号引用、普通括号及未闭合的中文括号继续显示。群聊本地回归1747项、普通模式主客机模拟13项、工具模式主客机模拟14项通过。

统一工具模式的随机对照保留在本地 .artifacts/tool-mode-random-20261024。ToolModeCoverageChecks 的 random 模式以固定种子20261024抽取文案并打乱顺序，私聊、单NPC群聊分别覆盖文字活动邀约、代发帖、长期判断习惯、普通闲聊、词义询问和未采纳的错误打法假设，共12次真实DeepSeek请求，另保留首次发现问题的1次请求。全部复用完整生产提示词、命令、处理器与原业务执行；保存回调写入隔离文件，反序列化后逐项核对人物状态与群聊交互会话。代发帖2次建立待确认草稿，长期习惯2次实际写入判断依据。6次对照均未登记活动、帖子、学习、状态或人物档案变化；其中1次按原关系规则将好感从7更新到10。文字活动邀约2次均错误填写接受及编号0，私聊Error或群聊Notices记录缺少活动附件编号，实际没有建立活动；另一次首次请求同样失败，因此该项仍未通过。完整12次请求合计42620.19毫秒，包含服务等待与文件保存，逐次2304.92—4681.32毫秒；37次保存回调合计613.21毫秒，逐场景25.08—72.04毫秒、累计线程分配20.71—53.66MB，包含完整测试存档序列化及文件写入，与生产上下文单项性能不同。本轮测试未启动游戏、Godot或真实Steam多人，正式提示词与玩家存档未修改。

活动说明统一来自 SocialAppointments.Protocol，普通私聊、普通群聊、附件说明及 ChatTools.Features/Describe 均复用；说明区分文字新提议的邀请和附件安排的接受。PrivateAppointments.Respond 对比赛约战已有接受且没有本轮约战请求时改为邀请的处理，两种输出模式经原 PrivateMessages.Apply 或 GroupInteractions.Apply 进入该函数，转换继续生效。生活活动统一通过 SocialAppointments.Respond：完成日期换算、已有活动编号解析及附件匹配后，接受动作的 Id 为空或0且没有匹配到已有活动或附件时，将本次局部 action 改为邀请，沿原创建流程建立待确认活动。有效附件、已有活动、其他无效编号、改期和取消继续使用原处理。原字段字典、模型返回及已保存旧轮次保持原内容；转换在每次执行该交互时生效，重新生成、保存及多人广播仍由原调用者完成。

只调整活动说明的真实模型验证位于本地 .artifacts/tool-activity-clarification-20261024。工具模式下，私聊和单NPC群聊的文字邀约、活动附件接受各5次；另有普通模式对应4次，共24次。工具群聊文字邀约5次生成待确认活动，两种工具聊天的附件接受各5次生成已确认活动；工具私聊文字邀约1次生成待确认活动，4次错误填写接受和编号0。普通私聊两次、普通群聊附件一次通过，普通群聊文字邀约同样填写接受和编号0，活动未建立。当时实际通过19/24，失败5次均有Error或Notices；没有其他功能交互。这组记录用于保留共用执行入口修复前的失败依据。

执行入口修复后的验证位于本地 .artifacts/activity-conversion-final-20261024：ToolModeCoverageChecks.ActivityCompatibility 将上述5条原始失败返回经真实命令及Process处理器重放，全部建立待确认活动；另有36种私聊/群聊、普通/工具模式组合检查空编号、0、其他无效编号、有效附件、0编号唯一附件匹配、已有活动、改期、取消及空交互，均符合各自原有处理或本次转换。ActivityInteractions 再调用真实DeepSeek24次，工具模式四种组合各连续5次、普通模式四种组合各1次，全部有正文、正确活动状态、相同日期和参与者、保存及反序列化后相同活动；新文字邀请保持待确认，接受有效附件为已确认。没有额外功能交互。测试共116项检查通过；原群聊回归1748项及模拟主客机传输13项通过。本轮使用单NPC群聊及存储替身写隔离文件，未启动真实游戏、Godot或Steam多人。

修复后真实请求合计74863.73毫秒，逐次2423.31—4491.14毫秒，含模型、网络及测试保存；65次保存回调合计946.58毫秒，逐场景保存累计分配20.73—53.93MB，包含完整测试存档序列化。已完成前置重放后，Respond 独立测量正常0条活动五次0.0298/0.0257/0.0296/0.0330/0.0298毫秒、各1288字节；2000条未编号既有活动五次71.8002/77.9157/70.4493/69.2038/73.6678毫秒、601472/592200/592200/592200/592200字节，包含原Ensure建立编号及全部原活动检查。这里不是进程冷启动性能；独立步骤与完整请求嵌套，耗时不相加。转换只增加一次固定条件判断，每条交互执行一次，沿用原集合、保存次数、同步入口及缓存规则。

### 场景、关系与公历协议

专属约会由 dm-date-open/dm-send 发起，沿用同一私聊处理器、同一模型方案、公开帖子选择和自动总结。普通模式在请求末尾附加 DateScenes.Guidance，保留 Scene/Emotion/Background 括号格式及该次真实素材编号。工具模式由 ChatTools.Create 调用 Guidance(scene, tools: true)，从同一 Protocol 转换场景输出说明：每段在 send_message.Replies 中填写 Scene/Emotion/Background/Reply，场景资料与叙述规则沿用同一来源。PrivateStreamParser 记录 SceneCues；完成后 TaggedLines 生成显示元数据，原 Reply 保留正文。回复成功沿原解析与请求状态判断。结束约会的 dm-date-end → DateScenes.Leave 更新场景和婚礼状态，DateDiaries.Begin 建立当次条目，PrivateMessages.Enqueue 将结束感想作为隐藏系统事件排入原私聊队列。当前场景仍在生成时先取消旧请求，结束轮通过 queueAfterCurrent 留在其后；原请求 finally 再启动排队轮。单人 PrivateCommand 和多人 StartPrivate 都将 dm-date-end 交给同一处理器。重复结束读取 ended 状态，排队次数保持一次。

ProcessPrivateAsync 只对 Scene.Ending=false 的当前约会启用 PrivateStreamParser.SceneJson。正文中完整的场景 JSON 对象可包含 Scene/Emotion/Background 及可选 Reply；Scene 为 dialogue 或 narration，三个场景字段均为字符串，其余普通 JSON 保留原文。ReadSceneJson 将对象转成同一 SceneCues，并将 Reply 写入可见正文，随后紧跟的文字继续使用该场景。流式状态记录括号深度、字符串和转义，跨分片保持；未完成 JSON 在 Finish 时恢复原文。普通私聊、群聊和结束日记沿原解析路径。该处理只改变显示资料，不新增交互、网络请求、保存节点或自动日志；缓冲随本轮解析器释放，完整正文和场景行沿原 PrivateTurn 保存、同步和重试机制管理。工具模式和普通模式约会都可读取这种场景对象。

旧版独立功能工具模式的约会回归位于本地 .artifacts/date-tool-repair-20261024-live，复用测试入口 --date-tool-checks。193454 诊断包的三轮原始回复经过 dm-regenerate、ProcessPrivateAsync、交互执行及两次保存回调重放：开场台词与旁白、第二轮纯旁白及第三轮正文前的场景 JSON 均恢复对应显示资料，第三轮保留完整台词。仅替换 scene 工具说明，将原始请求的全部消息与其他11项工具逐项保留，deepseek 实测三轮均调用 scene、显示正文、完成状态且 Error 为空；分别3/5/3段，表情与背景进入原显示资料。每轮一次请求、两次保存回调，完整耗时8616.11/4258.10/4995.10毫秒，分配7169024/3715232/4098928字节；耗时含服务等待，不作为本地性能。无网络三轮完整重放164.88/6.05/9.52毫秒，分配3452320/2175896/1657520字节，首次含初始化。216字符逐字解析首次0.06毫秒、再次0.03毫秒，各分配17152字节；216000字符含2000项场景对象，16.90/16.52毫秒、各分配15373088字节。保存回调仅计数，正式生涯和设置保持原文件。分片、普通 JSON、未完成文本、普通模式逐字说明及原交互解析均通过，模型返回兼容46项、交互规则253项通过。真实 Godot 画面、真实磁盘保存与 Steam 多人本轮未实测。

结束轮 Compose 改用 DateDiaries.Guidance，传入本次约会全部已完成轮次，一次模型调用同时输出普通私聊感想与隐藏 DateDiary/Location。PrivateStreamParser 分离标记，PrivateMessages.Apply 沿原交互规则处理，DateDiaries.Complete 保存日记和地点，再沿原完成保存回调提交。Location 位于标记闭合括号之后或日记末尾的明确地点字段也可提取，普通感想显示时移除字段。缺少日记标记保留感想并提示，玩家可沿原重新生成重试；自动总结仍按原条件执行，日记功能没有单独再调用第二次模型。普通请求沿原聊天、自动总结与公开材料组织，不附加 DateDiaries 列表。

普通约会场景最终正文经 DateScenes.ReplyFailure 检查，规则复用 PR 中的道德审查拒绝表达与 NSFW 检测；游戏名和比赛讨论沿正常正文处理。检测对象为最终正文，不读取 Reasoning；命中时轮次 failed，交互效果保持执行前状态，由玩家使用原重试按钮继续。结束感想沿普通私聊路径。

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

GroupInteractions.Apply 从当前群的本轮及此前轮次读取附件，按附件编号去重，当前附件优先。Expand 将训练 Actor 名单展开为每名受训者，兼容旧回复中的逐人记录；旧教练表态沿兼容路径跳过，教练身份及训练条件由 ClubCoaching.TrainingError 读取附件判断。新活动 Actor 表示完整参与者，进入现有执行代码时转换为内部 GroupParticipants；旧回复的 Actor 与 Participants 组合仍可解析。同一附件的逐人活动回应沿原安排保留完整名单，已有活动改期沿用原名单。同轮相同训练决定去重；相同活动决定合并为一个安排。多人接受同一附件后，活动归入附件发起者的同一交互记录，不为每人复制日程。

每个群的人物交互记录继续由 GroupChats.InLane 交给 PrivateMessages.Apply 或 SocialAppointments.Respond。ClubCoaching.AcceptTraining 通过 ChatAttachments.Find 在当前人物会话内寻找当前或历史附件；接受后建立该受训者的训练与接受记录，拒绝后记录拒绝。相同附件已有接受记录时再次接受复用原计划；新附件仍按原规则替换当前训练。训练的教练、期限、内容和资格判断保持由原训练模块负责。群内本轮生成的临时 PrivateTurn 同时携带明确引用的历史附件；查找范围保持在当前群的对应人物记录中。各群及私聊的同号附件分别处理。新建、改期、取消及训练变化沿 PrivateInteractionHistory 保存与回退，广播仍由原命令和生成完成回调执行。

模型材料统一使用 Actor，存档中的 PrivateOffer.Participants 继续保存实际参与者。ChatTools.CompletePrompt 在返回完整请求前调用 GroupInteractions.PromptText，仅把旧 Activity 标记或 JSON 中的 Participants 转为 Actor；字段前后顺序和多行 JSON 均可转换，聊天原文及已保存总结保持原值。训练说明由 ClubCoaching.GroupProtocol 同时供普通和工具格式读取，工具示例仍由 Describe 转换，新增说明没有附加系统消息。PrivateMessagePrompts.Context 经 GroupChatPrompts.InteractionContext 读取当前人物参加的群活动，判断依据仍是实际保存的参与者；同一活动能进入每名参与者的私聊资料。

验证入口 NationalSpire.Tests/GroupBatchChecks.cs 使用原诊断中14人、65轮历史和已有总结的存档副本，经官方 https://api.deepseek.com/v1/chat/completions、deepseek-v4-flash 实际请求。最终连续5次工具模式均完整登记多人训练及多人活动，受训人数分别2、3、4、5、11，含跨轮回应；工具保持 strict=true、指定 send_message、thinking.type=disabled。普通模式另测5次，其中4次未交标记，1次返回的训练与活动两条标记均解析执行成功。此前一次跨轮工具测试漏人，修改训练逐人判断说明后重新连续验证，失败原文与最终结果均保留在本地。97项针对性本地检查涵盖批量/逐人/混合返回、去重、跨轮、拒绝、工具数组名单、群间同号隔离、旧格式、保存重读和参与者私聊读取；另有1750项群聊与13项模拟主客机传输检查通过。真实返回重放10次分别测量分片解析、业务执行及保存重读，复用原生产入口。

最终10次请求的完整上下文为14.3万—14.8万字符，保留原历史窗口和总结；仅把自动总结触发间隔调整为1000以隔离主回复测试，原材料仍保留。真实 SSE 在测试中先缓冲用于保存原文，再交原流式解析，验证分片与实际登记，不测首字延迟。工具5次网络分别6.31、5.96、7.45、5.65、4.77秒；每次主回复请求一次，保存回调分别6、6、10、6、5次（含流式发言顺序保存）。上下文首次整理分别153.25、72.55、66.65、66.69、118.56毫秒，再次整理74.73、30.95、31.56、32.85、32.08毫秒；首次分配38.46—39.12MB，再次17.55—18.16MB。100毫秒目标在两次首次整理中仍超标。测试没有实际游戏界面点击，也没有真实远程客机或断线测试；保存、赴约和私聊读取使用存档副本中的真实业务入口。

上述正文点名的测试后，又按玩家要求进行高难度验证：每轮正文严格为大家训练，仅一份训练附件，保留原群14名成员、65轮历史、总结、私聊与帖子资料。五次使用随机种子251025至251029选择2、3、4、5、11名受训者，全部实际工具返回均覆盖对应名单，训练登记及保存重读通过。额外教练表态沿旧格式兼容跳过，逐人多条回复继续兼容；训练说明保持根据训练附件的安排，逐一决定每名受训者接受或拒绝的原文。普通模式同条件另测5次，2次分别返回2人、3人的有效训练接受，全部解析登记；其余3次没有交互标记。模型漏交和程序解析结果分别记录。

高难度工具5次的首次上下文整理为105.63、115.42、69.66、96.55、81.42毫秒，再次为60.79、39.14、30.51、34.57、40.25毫秒；首次分配37.64—37.84MB，再次约16.74MB。网络分别5.86、4.76、4.39、6.64、5.29秒，每次主请求一次、保存回调6、6、6、8、8次。普通模式首次51.95—90.04毫秒，再次21.15—121.78毫秒，个别再次执行也超过100毫秒。最终普通群聊回归1744项及模拟主客机传输13项通过，工具模式模拟传输14项通过。单独运行旧 CoachChecks 整套检查时，在预约教练仍在原队的合同断言失败，尚未运行到训练检查；本次没有修改该合同转会流程，此项保留为未通过记录，不计入群聊附件通过数。

最终针对性检查扩展至116项，增加原私聊历史、私聊与群聊总结原文保留，以及受训者私聊读取实际训练的检查。PrivateMessagePrompts.OfferContext 对已拒绝的训练单独生成实际人物、周数和内容组成的拒绝结果文字，已接受分支原文保留；该分支仅描述保存结果，训练协议原文沿用玩家确认版本。私聊拒绝附件经 PrivateMessages.Apply 保存后，不建立新训练；下一轮 Context 及保存重读均显示已拒绝，原有训练与已接受文字保持。真实返回重放同时复查这些人物的训练资料与原私聊、总结保持情况。

拒绝资料修正后，重新从原诊断构造上述5次高难度工具请求与5次普通请求，10份完整 messages 与真实测试保存的请求逐字一致。最终源码下重放10份真实返回，工具解析0.322—0.397毫秒、业务执行0.567—6.663毫秒、JSON序列化及重读173.253—194.960毫秒；普通解析0.021—0.132毫秒、业务执行0.037—10.300毫秒、JSON序列化及重读183.824—260.103毫秒。这里的保存测量只含测试存档副本的序列化和反序列化，磁盘写入与真实网络广播没有计入；上下文、解析、执行与保存各自计时，不与包含它们的整次请求时间相加。全部原始逐次耗时和分配量保留在本地验证结果中。

CardKnowledge.Find 分别由 PrivateMessagePrompts.Compose、GroupChatPrompts.Compose、AiDiscussion 的玩家发帖/回帖材料调用。输入仅为本轮玩家文字，首次按 SourceVersion 建立首字索引，完整名称按最长匹配并按卡牌编号去重；当前语言变化后重建。动态描述位于本轮资料，固定指令前缀沿用原值。匹配结果统一使用卡牌参考资料标题，紧接说明：以下资料由卡名匹配自动补充。请结合上下文，只有确实在谈对应卡牌时才参考其效果；日常用词按原意理解，顺着当前话题自然回应。空匹配继续返回空字符串。检索、卡牌效果与玩家模板保持原流程，语境判断由生成回复的模型结合聊天材料执行。GameCardKnowledge 使用当前加载卡牌定义生成名称及效果资料。此处只生成请求材料，保存、广播和缓存失效条件沿用原流程。

2026-10-21 使用当前已保存的群聊连接 deepseek、玩家当前模板、生产 GroupChatPrompts.Compose 和596张游戏卡牌定义，建立三组模拟群聊：废土游戏辐射病、上班受打击、辐射卡伤害计算。每组旧新各请求一次，共六次；组内除卡牌资料标题及说明外，其余请求前缀哈希一致，卡牌效果逐字一致。辐射病旧回复转入赛事与打牌，新回复承接废土游戏求救；受打击两组均主要回应加班与吃饭；正常卡牌两组均计算出9/12点。该结果是有限样本，不能推断全部聊天都会正确判断。语境说明一次增加60字符，沿原固定前缀缓存；新旧每组请求字符约17357—17646。索引已建立后首次命中约0.23毫秒，后两次约0.01毫秒及更低；具体分配与原始请求、返回保留在本地 .artifacts/card-reference-ab-20261021，未使用玩家私聊、群聊或社区历史。

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
| GroupInteractions | Actor / Target / Related 与标记，兼容旧 Participants | 解析完整参与者或受训者名单，按人物方向建立 Lane，复用私信规则 | 卡片、关系、训练、活动、发帖等 |
| PrivateMessages.Apply | 有效轮次、标记及原好感 | 合同/约战提案、关系、学习、状态、资料、训练与活动规则结果 | 保存、卡片、记忆、回退 |
| 各业务规则 | 人物、日期、附件、合同、席位、资金等 | 成功状态或原因；有的提案等待玩家确认 | 不因正文“同意了”而自动成功 |

GroupStreamParser 是生成处理和 GroupChatScreen 实时显示共用的人物标题入口。标准 [Speaker: p2] 沿原路径识别；行首或缩进后的简写兼容编号与姓名换位、Speaker/发言人/说话人/人物/角色标签、大小写、中英文冒号，以及方括号、中文方括号和圆括号。裸写 Speaker: p2 后换行、p2：正文也进入同一编号提取函数。简写要求标题中有一个明确的p编号；普通括号、简写标题中的多个编号及正文中间的[p3]引用按原正文保留。编号归属仍由群成员表及 SpeechUnavailable 核对。解析器仅保留当前未结束标题和本轮已有消息；换行或完整标题结束后释放标题内容，静态正则与标签表复用，未新增跨请求缓存或自动日志。

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

CommunityPromptContext.SelectReplies 对整次请求的已选帖子统一选择评论：取参与者（含玩家）最近八条，再取与查询至少匹配两个有效词组、按匹配数除以评论词组数平方根排序的八条。词组采用英文数字词及相邻汉字对，沿用 CommunityMemorySearch 的日常用语过滤表。可选 sourceMemories 另将实际检索命中的评论设为起点，随机事件使用该参数，原私聊和群聊保持缺省调用。重复评论按帖子编号和评论编号合并；每个起点补齐全部父回复，再补一条日期最近、同日按原评论顺序靠后的直接回应。最终评论数量随父回复链长度变化。时间相同的候选使用评论编号确定顺序。Comments 输出原评论全文、作者、日期和回复对象，标题关联到同次请求内的完整原帖；观点标签与原始事件事实分别提供。

私聊、群聊、随机事件与上述新闻入口共用 Request.RecentPlayerPosts(data, day)：在当前请求可见原帖集合中，按过去28个游戏日、玩家作者或关联玩家的PersonalPost、发布日期降序取最多三篇；先取三篇再合并已有来源，重复不递补。每次同步整理只筛选和排序一次，Request 按生涯对象和日期缓存，调用结束释放。常规检索的数量、候选及排序照旧；群聊整个请求共享三篇。私聊已有当前版本完整帖子附件时，该帖直接使用附件，消耗补充名额。普通NPC新闻继续由原常规检索选择。

PrivatePublicContext.PostBodies 共用 PostTexts(includeConversation:false)，返回完整标题、作者、日期、原文和已有原始事件事实。Community 与 CommunitySources 合并近期原帖和常规结果，再用 suppliedBodies 排除前部已提供的正文；评论仍由同一个 SelectReplies 对合并集合选择，并在后部提供父回复及回应。私聊通过 ContextSpan 的 player-public 段，在固定系统模板后、人物资料前输出原帖；群聊在系统模板后输出同一组正文，再提供群成员资料。随机事件 Materials 保存 PublicPosts，并从社区资料中排除重复正文；Compose 将其放在 event 模板后、玩家资料前。随机事件自由行动与首次生成的前两条消息保持相同。原帖及模板不变时，这段文本不受当前聊天查询影响；新帖发布或原帖更新后，下次新请求重新组织前缀。私聊原保存 Context 与当前重建内容不一致时继续使用原保存全文，不用当前资料改写过去事实。旧事件沿原 Materials 恢复。私聊和群聊没有新增持久化字段；随机事件的 PublicPosts 随原两次保存和个人快照传递，检索本身新增保存、广播和模型调用次数均为零。

PublicEntryChecks 使用第168天诊断存档重建场景，检查两名无私聊历史的路人、查询变化、两路正文去重、0/1/2名参与者事件、6/40人群聊、事件保存往返、发新帖后的前缀更新及旧事件快照保留，离线51项通过。真实DeepSeek私聊追加一次请求，模型明确提及玩家已发布失联公告；实际输入67196 token，命中缓存49152 token，这是完整玩家模板请求，不能当作本次补充增量。公告正文329字符；原社区片段的只读对照中，私聊增加331字符、群聊增加329字符、事件消息增加339字符，常规已选同帖时零增加。不同帖长和评论分支会改变增量。

正常2224条社区记录下，完整私聊首次116.194毫秒，后续4.766至8.960毫秒；两名NPC群聊首次14.992毫秒，后续5.028至8.037毫秒；事件材料首次14.923毫秒。22240条扩展记录的私聊三次224.291/45.326/34.202毫秒，群聊38.952/58.732/34.586毫秒，事件17.696/15.938/16.437毫秒。40名NPC群聊首次59.861毫秒、再次48.596毫秒，分配24178648/21817864字节。逐次准确值、累计值及分配量以本地 public-context-settings-20261022/entries/checks.json 为准；完整调用包含内部步骤，不能相加为一次耗时。以上使用生产上下文代码及游戏替身，无磁盘保存和网络广播，真实Steam通信未实测。

GroupChatPrompts.Compose 在早部放置背景帖正文，在当前材料部分放置新增话题正文及全请求的评论分支。PrivateMessagePrompts.Context 生成同样分开的正文与评论；OrderContext 按固定来源编号组织背景正文，话题正文和评论位于当前材料部分。排序后的帖子之间保留分段空白。已有 PrivateTurn.Context 仍作为本轮保存快照使用；没有保存快照的请求使用本次整理结果。

自动发帖的 BuildNewsContext 对整个批次调用一次 Retrieve，常规最多六条；社区回帖的 BuildDiscussionPrompt 对整个请求常规取八条；周刊取五条。CommunityThreads.Remember 分别保存事件事实全文、已生成帖子正文全文，以及每次更新时最后十二条评论的全文。Put 按记录编号更新，之前保存的其他评论继续留在 CommunityMemories。Retrieve 常规结果对同一 PostId 最多选两条；人物列表前三人的匹配权重各为8，其余各为3，人物得分累加，日期得分为1/(1+间隔天数/28)。自动发帖采用文字片段相交或人物相交的候选条件。

BuildNewsContext 与 BuildDiscussionPrompt 分别将当前 pending / targets 传入 Retrieve 的可选 playerTopics 参数。缺省调用保持原有选择。当前目标作者或关联人物包含实际玩家编号，或目标 EventKey 对应截至请求日期已经核实的玩家比赛结果时，Retrieve 在常规结果之后补充近期公开原帖：候选为玩家自发帖，以及 PersonalPost 为真且关联玩家的私聊发布帖；发布日期在请求日期减27至请求日期之间，按日期从近到远先取三篇，整个请求共用名额。同日沿现有帖子枚举顺序。然后按 PostId 合并常规命中、excludedPosts 和 excludedMemories 对应帖子，重复项直接消耗候选名额，后续帖子不递补。普通NPC新闻继续由常规检索选择。

新闻与回帖的近期公开帖补充直接读取 Remember 已保存的 :fact 原帖记录，该编号的 Kind 仍按原有规则保留 opinion。常规与补充命中一起经过 Retrieve 最后的同一段记录输出及 AiWireProtocol.Encode，标题、正文、署名、日期、来源与观点分类使用同一份原始资料；常规已命中同帖评论时继续沿原评论及来源展开提供内容。补充不会另行选择整帖评论。候选可见性复用 Request.Posts，词汇与原帖记录复用同一 Request 的 Search；每次请求至多筛选和排序一次公开帖集合，返回集合只增加最多三条既有记录引用。缓存于请求结束后释放；新闻与回帖补充无新增模型调用、存档字段、保存或网络广播。单人及房主/个人视图均读取调用者已有 CareerData，IsHuman 识别 player 与 HumanIds；旧档使用既有原帖记录。请求失败、离开、切档和断线仍由原请求与保存流程处理。

PlayerPublicContextChecks 用私聊发布、同帖评论命中、当前目标已提供正文、28天边界、未来帖子、实际多人编号和匹配比赛事实验证上述入口；常规及补充取得的同一原帖记录与 Encode 输出逐字相等，重复时第四篇不递补。诊断场景按第168天恢复，移除后来生成的第24周周刊及同日后续私聊发布帖；旧网络日志曾截断，所用材料为存档重建。原常规六条逐字段一致，额外一篇失联公告进入新闻与回帖请求。当前 DeepSeek 连接各生成一次前后对照，原存档系统模板一致，输入由88722增至88920 token；修改后评论明确提及6月11日协寻公告及失联数周，两份回复均通过 ReadResponseCompletion → Decode → ApplyResponse 的真实解析和整批提交。针对性23项、原上下文31项、社区182项及周刊51项检查通过。

该诊断副本2224条公开记录下，启用补充的三次检索为7.128/6.428/6.904毫秒，各分配1419840字节；原规则为6.651/6.580/6.353毫秒，分配1115928至1116280字节。首次完整新闻上下文104.212毫秒、分配17043448字节，重复三次8.116/7.511/7.723毫秒、分配1880896至1882776字节。扩展为22240条记录时，原规则首次词汇缓存构建285.854毫秒，重复57.072/72.285毫秒；补充开启后复用该缓存的三次为56.985/64.221/55.802毫秒，各约1084万字节。首次缓存分配约1.20亿字节，另一轮首次曾为314.228毫秒，以上大样本不是补充路径独立冷启动对照。上下文总耗时包含内部检索，分别记录，不相加；网络生成71.314/68.625秒另列。性能来自独立测试进程使用生产上下文源码与游戏替身；多人仅检查实际编号，无真实房主、客机网络计时。完整逐次数据、请求、回复及安装哈希在维护者本地 .artifacts/player-public-fix-20261022，源码依赖索引使用真实生产引用重新生成，307文件、4581成员、0编译诊断、0未绑定调用。

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
