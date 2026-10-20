# 数据归属与使用约定

## 结算对阵详情

CompetitionScore.Duels 保存该张总比分卡包含的 CompetitionDuel 列表。每项 Home/Away 为 CompetitionPlayer 列表，Id 用于头像和人物档案，Name 保存结算时姓名；HomePerformance/AwayPerformance 保存格式化后的通关、楼层与用时，WinnerId 标记胜方，Status 为待赛、弃权判定、平局或已结束。合作赛名单来自比赛实际出场记录，整队共用一份成绩。CaptureCompetition 创建这些独立列表，原赛事和人物后续变更各自生效，结算中的姓名和成绩沿用快照。

旧JSON缺少 Duels 时默认空列表。ScoreDuels 的输入为当前 CareerData 与一份 CompetitionReview，返回以 CompetitionScore 对象为键的显示详情字典；有快照时引用已存详情，旧格式时从仍保留的同赛事对阵补充。匹配使用当时的完成编号和截止日期，后续完赛席位保留当时待赛状态。原赛事已经清理时沿用原总比分。详情字典仅属于当前页面，浏览结束后释放。保存、广播与恢复沿用 SettlementRecord 原有归属，见[结算对阵详情](PERSISTENCE_AND_COOP.md#结算对阵详情)。

## 单人与多人数据

### 公历、关系与场景资料

CareerData.CalendarStartYear 是本生涯第1天对应的公历年份，第1天固定为该年1月1日。新建生涯时记录当前年份；旧档缺省0，在 NormalizeRoster 或多人主持者加载时由 GameCalendar.Initialize 写入升级年份，之后随原保存及完整快照固定。文件复制与再次启动读取已保存年份。内部 Day、Season、LongSeasonsFrom 和所有原赛事编号继续用于排序及计算；系统展示经 GameCalendar 换算。原文里的旧日期属于历史文字。

PrivateRelation.SelectedBond 表示主动确认的关系阶段，1为恋人、2为誓约；OathConfirmed 表示当前誓约，RingReceived 和 WeddingCompleted 记录经历。普通好感数值继续使用 Favour。RelationshipGifts 在发送和接受时共用60/85门槛；普通礼物支持恋人请求，专属礼物形成誓约。OathAttachments 接受解除时取消当前誓约，保留婚礼及收礼历史，并回到恋人关系。现有交互快照与 PreserveRelation 负责重新生成的恢复和后续独立关系操作的保留。

PrivateOffer.RelationshipIntent 属于本次礼物请求；ServiceId 将婚礼活动关联到已接受的婚礼礼物。服务编号为 GroupId/礼物Id，私聊的 GroupId 为空。Services 汇总当前玩家私聊及群聊交互会话，按礼物 Quantity 减去已赴约或已结束活动次数；购买、收礼扣库存、赴约使用服务分别沿原入口执行。

PrivateMailbox.NpcAvatarFrames 保存当前玩家为各NPC选择的头像框。缺省使用原荣誉；婚礼完成且当前誓约有效时自动显示钻戒框。CharacterDeletion 删除自建角色时一并删除该信箱的选择记录。其他玩家信箱继续由既有多人个人资料处理。

PrivateTurn.Scene 保存活动编号、套装、可用表情和背景、开场信息；SceneLines 保存台词/旁白及对应表情、背景，拼接文字等于 Reply。PrivateConversation.DateSceneStates 按活动编号记录 active、paused、ended。普通通讯过滤 Scene 轮次的显示和未读，原 Turns、ChatTimeline、自动总结及上下文继续读取这些轮次。旧档缺少 Scene 时为普通私聊，缺少正式关系状态时按原关系文字展示。

素材与播放书签保存于本机 PortraitDesignStore/DateSceneAssetStore 路径，归属键包含生涯及人物；场景正文和进度状态归生涯。ZIP版本3保存 PortraitDesign 元数据、人物和图片，兼容版本1/2；PNG继续使用原角色卡格式。图片尺寸采用原比例，通用图片读取的文件大小与像素保护继续适用。

AppearanceLibrary 共用库位于 `user://national_spire_portraits/library`。每份JSON包含Name、Design和Outfits图片摘要映射；导入包文件名取整包SHA-256，内置包使用haruka、charlotte、alili固定资源编号。这些编号只定位本机素材，不是人物、生涯或网络版本。三个默认ZIP嵌入程序集，首次选择后才写入库；图片共用scenes/images缓存。Apply深复制Design与Outfits，人物配置保留自己的播放设置和背景；库不包含聊天记录、关系或生涯数据。旧存档打开同一素材入口即可使用，原人物配置继续按原路径读取。

### 职业收入、库存和国运字段

ClubOffer.IncomeVersion 标记本人合同已完成工资×2、胜场和目标奖金×3的转换；Esports.IncomeVersion 标记待赛联赛奖金迁移。CareerIncome.Upgrade 对原数值转换一次，新报价调用同一入口。已到账金额继续由原账目保存。

ConsumerState.InventoryVersion 标记实物恢复完成；Goods.Quantity 为持有数量，GiftReceipts 保存已接受礼物的交互收据，LifetimeSpent 使用 decimal，PurchaseCount 与 PromoUsed 使用 long。ConsumerEngine.Ensure 首次读取时恢复目录中可收藏实物的状态，并为 BoughtDay 中仍缺少的实物建立一件记录。后续调用按版本直接返回。重复购买累加同种实物；即时消费品记录账目和事件；Gift 接受才扣除数量。交互回退恢复对应数量差额，并保留其后购买结果。

ConsumerState.PromoUsed 以商品编号记录各运营商品本季累计购买数量，Season 标识所属赛季。ConsumerEngine.RemainingPurchases 将本季记录与 ConsumerCatalog.PromoPerSeason=3 比较，为 BuyError 和商城详情提供同一剩余额度。历史超过3次的记录完整保留，余额和收益沿原记录；新赛季恢复每项3次。没有新增存档字段。单人及多人各玩家沿原 Consumer 数据保存次数。

NationalLegacy.ExtraProgress 保存各满级指标的增强进度，ExtraProgressDay 标记衰减起算日期；读取按14天半衰期计算，新贡献时先将存量折算到当天再追加。CommunityPost.CountryLevels 保存事件当时各相关国家九项等级，用于历史新闻资料。即时私聊、群聊、玩家发帖及讨论请求读取当前国家状态。

### 会话可见性和主动联系字段

GroupChat.Name 是当前显示名称。group-rename 使用 GroupCommand.Text 传入名称，通过统一 GroupChats.Command 写入；GroupEntry.Notice=true 的改名通知保存操作时原名称、新名称、Author、Day 和全局 Order，Revision 驱动界面刷新。使用已有字段序列化，旧档直接使用原 Name；历史通知保持操作当时文本。

PrivateConversation.Hidden 控制会话入口，Forgotten 标记清除；清除时删除 Turns、SmallSummaries、BigSummaries，原 Offers 标记 MemoryDeleted，实际合同、日程和其他影响仍由对应模块管理。新消息重新启用会话。

ProactiveChats.Trigger 跳过 Hidden 私聊和 Dissolved 群聊；单人 StartQueued、联机房主 StartProactiveChats 在启动排队轮次前再次检查同一可见性字段。隐藏保留 ProactiveChatSettings，恢复后继续读取原概率与连续联系次数。CareerLife.Advance → ClubCoaching.Advance 从俱乐部训练计划读取训练进度，按日期、教练与队伍资格结算，与会话可见性分别处理；隐藏期间继续记录每周成长及完成通知位置。

GroupChat.Dissolved 控制解散与恢复，Forgotten 标记整体清除；Departures 按人物保存离群时 ThroughOrder 和当时总结列表，MemoryStarts 保存清除后重新加入可读记录的下界。ChatMembership.Knows、Summaries、Readers 共同约束私聊外部材料、群聊外部材料和公开请求中的群聊记忆。整体清除覆盖现任及已离群成员，并清除相关私聊的保存上下文与总结缓存。

ProactiveChatSettings 在私聊属于该人物会话，在群聊按真人编号保存。默认关闭，MatchChance/EventChance/DayChance 为25/25/0，UnansweredLimit 为3。LastTrigger 对同一日期或比赛去重；EventDay/SeenEvents 记录当天已检查事件。ProactiveReason/ProactiveLast 属于实际聊天轮次，保存和重试沿用同一轮次。文字、附件或私聊请求均作为玩家回应，CountReplies 从最近回应后统计完成的主动联系；失败生成沿原状态保存。

FinalAlwaysReply 默认 false，旧JSON缺少字段时采用同一默认值。ProactiveChatDialog 经原 dm-proactive/group-proactive 命令调用 Configure 写入此字段，同时保留 Unanswered、LastTrigger 和事件记录。世界总决赛、洲际俱乐部冠军杯、世界杯的最终轮次将 MatchChance 按100处理，获胜与失利均适用。启用、可见性、忙碌状态、连续回复上限及同场去重继续由 Trigger 原检查处理。界面名称为夺冠赛必定回复，说明列出胜负均触发及连续次数上限。设置随原信箱、群聊、多人个人视图和检查点保存。

| 数据 | 管理者与写入入口 | 输入来源 | 下游使用者 |
| --- | --- | --- | --- |
| CareerData | 单人由 CareerStore 绑定实例和文件；多人由 CoopWorld.World 管理共享部分 | 生涯规则、游戏事实、AI 成品 | 页面、模拟、上下文、迁移、序列化 |
| CoopWorld | 房主 CoopCoordinator；操作经 CoopRules，AI 经保存回调 | 命令结果、成员状态、最新共享生涯、原版比赛状态 | 检查点、Broadcast、个人视图、原版恢复 |
| CoopMember | CoopRules 及个人交互保存合并 | SteamId、个人身份、资金、生活、私信、战绩、已读信息 | 个人视图、本人快照、群聊记忆来源 |
| 多人个人 CareerData 视图 | AI Current 使用 View；界面使用统一 InterfaceView | 独立副本覆盖本人字段；客机持久保存后可后台准备 | 主线程按来源 World 消费一次；实际修改仍按原用途合并回房主 |
| 客机接收队列与候选快照 | CoopReception / QueueSnapshot / PumpReceived | 压缩分片、流式、回执、运行消息和本机操作 | 保存与可选视图准备完成前不交给页面或原版对局；关闭取消等待与未发送操作 |
| CoopStorage 目录协调 | Schedule 与按绝对路径共享的 Gate | 排队存储操作、当前与上一份文件字节 | 跨实例按目录串行，磁盘读写互斥；恢复格式不变 |
| ExternalCurrent / ExternalSave | 会话或公共 AI 任务建立；JsonIgnore | 当前绑定、会话编号、代次、个人视图 | CareerStore.IsCurrent / Save、AI 完成后的有效性与保存 |
| PrivateMemorySources | 多人聊天 Current 填入其他真人信箱；JsonIgnore | 当前各成员信箱副本 | ChatTimeline；群聊交互通过 CaptureGroup 合并实际变更 |
| AiOptions、密钥 | AiSettingsStore、本机设置与请求入口 | ConnectionProfiles、TaskProfiles、设置界面、按方案加密的密钥或默认方案环境变量 | AiService.Connection 取得发送快照；公开序列化仅保留 Enabled |
| AiOptions.EventPoolOverrides | EventPools.Save、PromptTransfer.Apply、模板创建与删除 | 模板编号 → 固定分类编号 → EventPoolEntry 列表，保存于原本机 AI 配置及单人生涯副本 | EventPools.Get 缓存解析后的随机事件及日常；公开同步继续过滤 AiOptions |
| PrivatePromptSnapshot | Broadcast 填入各聊天场景与 world 模板 | 房主本机模板库 | 客机相关界面/上下文读取；房主生成重新读取本机设置 |

多人个人视图不是独立共享生涯，也不能代替房主最新数据。复制有不同用途：规则执行前的副本用于失败时保留原数据；个人视图用于兼容共用规则；网络副本用于剔除接收者不应看到的数据。三者不能仅因都调用 Copy 就视作重复。

事件池配置以分类是否存在区分跟随默认和自定义：缺少键使用内置，存在空列表表示该分类为空。记录中的 Title 用于日常标题，Detail 用于日常内容或随机事件素材；日常继续替换 {人}、{队}。随机事件新 Category 字段保存抽取时分类，旧记录缺省为空时按原 Seed 查 RandomEventSeeds 的内置映射；已生成自定义事件修改模板后仍保留原画面分类。提示词文件版本3及旧文件缺字段行为见 AI_FLOWS。

## AI 连接方案与本机凭据

AiOptions.ConnectionProfiles 以稳定编号保存 AiConnectionProfile{Name, Endpoint, Model}，TaskProfiles 以八种任务编号指向连接方案编号。旧配置首次由 AiRouting.Ensure 将 Endpoint/Model 写入 default；缺少某任务选择时使用 default。创建方案使用 Guid 的 N 格式编号，重命名只改变 Name。旧 Endpoint/Model 继续作为读取早期配置的来源，保存 default 时同步两项。全局 Enabled、并发、间隔、等待时间、帖子批量与提示词仍属于 AiOptions。

AiSettingsStore.Load 每个进程首次读取 user://national_spire_ai_settings.json，转换旧配置后保留 _options；后续调用复用对象。Save 通过原临时文件替换入口写入，内容与路径均和 _saved 相同时复用已有文件。界面连接字段属于当前控件草稿，保存时才替换该方案；任务分配及一键应用直接修改 TaskProfiles 后调用原保存回调。单人回调为 CareerStore.Save，先保存生涯，再保存本机设置；多人回调为 CoopCareerSession.SaveAi，先保存本机设置，再沿原 Commit 更新 Enabled、Revision、检查点和公开快照。

默认方案沿用 user://national_spire_ai_key.bin；其他方案使用 user://national_spire_ai_key_{稳定编号}.bin。SaveKey 用当前Windows账户的DPAPI加密，并通过临时文件替换；ReadKey 按编号首次读取和解密，Keys 字典缓存明文或空结果，保存时更新缓存。AiService.ProfileKeys 保存本次启动覆盖值，默认方案保留原 _sessionKey 和 NATIONAL_SPIRE_API_KEY 环境变量入口。持久保存失败时原 PersistKey 返回提示并保留当前进程可用值。

AiConnection 保存本次请求的方案编号、名称、地址、模型、密钥。密钥在独立文件和本机缓存中管理；普通配置JSON存储方案资料。CoopJson.PublicOptions 将 AiOptions 转为仅含 Enabled 的公开配置，客机收到房主公开启用状态；房主生成重新读取本机配置。启动恢复直接复用已保存的编号与映射，加载早期配置时建立一次 default；请求重试查询最新映射。UI草稿随控件释放，保存的配置跨生涯共享。

## 国运、模拟与经济数据

- FailureDecision.Result 保存失利待选择的原成绩，Simulated 区分模拟；Opponent 保存原对手通关、楼层与秒数。正式 Results 由确认或实际重赛完成后写入。MatchFailure.RestoreMatch 统一恢复原种子、对手和实际进阶，供 Confirm、Retry 及多人 failure-confirm 调用；新种子准备中断仍可使用原成绩确认。旧 Opponent 缺省 null：原种子且已准备时读取原比赛，否则按原种子调用 MatchRules.Simulate 重建一次。已正式结算的历史继续沿用原记录。

- WorldCompetition.FortuneVersion：0 为旧赛事，整届结束发放；1 为新建国际赛事，逐场发放。旧档已生成赛事保持 0，防止重复发放历史赛果。
- WorldFixture.FortuneSettled 防止重复确认赛果；PromotionSettled 防止重复补充团体晋级贡献；Fortune 保存各人的本场贡献，DevelopmentChanges 保存实际等级变化。预生成成绩不设置收据。
- CircuitAward.Completed 默认 true，兼容旧荣誉。逐场创建记录为 false、积分为 0；最终 Settle 在原记录补充名次和积分。世界荣誉只取完成记录，国运榜读取进行中的贡献；积分完成后主动失效 AvatarHonors 排名缓存。
- NationalLegacy.Indicators 为九项等级，Pending 为三类未用建设余额，MaintenanceFunding 为本赛季维护额度；DevelopmentVersion、ReportSeason 用于迁移和换季去重。首次启用给予当前赛季 120 维护额度，不追扣历史维护。NewsDay/NewsFortune/NewsChanges 保存公报候选，LastReport 供界面读取。
- CareerResult.Simulated 默认 false。模拟成绩仍写入原结果、荣誉、评分、奖金、关注和职业最高进阶；主要战报与结算标明模拟。RunSeconds 保存实际抽取的用时：以原平均用时为基准上下3%，根据原胜负收窄可取范围，平局沿用原整数秒。用时使用 WorldId、match.Seed 和独立用途后缀确定，Sample 返回值随正式结算写入原字段；旧的已完成结果继续保留。模拟不产生原版对局、原版战斗记录、牌组或战斗证据。
- CareerPerson.Fans 可空，null 时从 CareerAudience 读取初值，NPC 首次增加关注时写入整数。真人以 CoopMember.Fans 为准，RefreshPeople 更新显示人物。旧玩家关注不重算。
- CareerData.Market 为公开共同行情。MarketCatalog统一整理地区品牌及CareerCommerce.LegacySponsors提供的旧版品牌，按地区、类别及名称去重，当前201项资产。旧版通用品牌沿用中国地区和原类别。CatalogVersion保存MarketCatalog.Version，由完整资产编号列表及60条起始曲线规则生成；PricingVersion=1 表示旧待处理外汇信号已计入报价。LastDay 为最后更新日，Revision 为报价版本。每项 Quote 保存现价、前价及最多180条价格；SyntheticThrough 区分补入的模拟前史。Market.Events 保存最多240条公开市场事件，NewsDay为已选入新闻的截止日期，同时用于市场新闻七天间隔；只选择最近七天且晚于此日期的最多八条事件。
- CareerLifeState.Trading为本人账户，含Cash、Debt、InterestDay、InterestRate、NextPosition、Positions及最近120条Trades。内部金额显示美元时乘10。CareerData.Credits、CoopMember.Credits、SettlementRecord.Credits改为decimal整数值，钱包小数部分继续使用CreditFraction；CareerResult.Prize、SeasonRecap.Prize及CoopSettlement.Payouts仍记录64位整数赛事收入。报价、保证金、实际到账和账户余额采用decimal。钱包与成交数量继续序列化为JSON数字，旧整数及旧decimal数量可直接读取。超出旧long范围的钱包需使用本版本读取；联机沿用CoopContentIdentity的发布版本一致检查。
- PendingSignal 保存本日外币国减中国的原始信号总和，AppliedSignal 保存已计价的±4范围合计，SignalDay 标识日期。Fixture 每次只应用新合计与旧合计之差，Advance 次日清零但不再次计价。报价表示1人民币兑换的外币数量，正信号降低报价。旧 PricingVersion=0 时 Initialize 将已有 PendingSignal 截至±4计价一次，并处理强平；多人恢复先由 CoopRules.InitializeMarket 绑定全部成员账户再升级。v0.26.20的新外汇赛果 MarketEvent.Change 与品牌一样保存实际相对报价变化，历史事件不重写。
- MarketState.CheckedQuoteCount是仅驻留当前对象的内部缓存。读取存档、JSON复制或恢复检查点时为-1，Initialize核对全部201项资产键；完整目录继续使用原MarketQuote及History对象，缺项沿用原报价及60条起始曲线生成入口。完成后缓存字典数量；相同目录版本及数量进入快速路径。目录编号列表或字典数量变化触发检查。旧CatalogVersion=0/1仍按原规则补充全部不足60条的历史，版本2及新版目录只补缺少报价的资产。缓存随对象释放，序列化与同步携带原CatalogVersion和Quotes。
- MarketQuote.ExecutionBase为外部行情基准，DepthUnits为该基准下的承接数量，BuyUnits、SellUnits为可空MarketNumber。字段缺省null时，Used从旧OrderUnits正负部分读取对应方向已消费数量；首次成交写入两侧字段并将旧OrderUnits归零。Open/Close返回计算结果，旧仓Apply→Consume写旧数量，Price按外部基准及当前新仓数量计算，并更新当日历史及Revision；每日行情和有效赛果Reprice更新基准并清零两侧数量。ExecutionCopy供Net在数值副本中模拟退出，History共享只读。
- MarketPosition.Units及Fill.Units/EndUnits采用MarketNumber；Fill.Direction表示本次实际买入或卖出的方向。Exit.Fee采用MarketNumber，Exit.Proceeds/Profit采用decimal。MarketNumber以BigInteger保存固定28位小数，Round采用偶数舍入；转换器读取旧JSON数字及科学计数法，输出精确JSON数字。字段随原保存、事务复制、快照及检查点传递，其他成员的个人持仓继续由原快照过滤处理。
- 品牌与外汇共用 MarketPosition 的 Margin、Units、Entry、Direction 和 Leverage；Direction=1为做多、-1为做空。Entry 为整笔开仓均价；Leverage保留开仓档位，初始仓位由Entry×Units计算。InitialMargin保存最初保证金，旧仓null时取当前Margin；首次追加前冻结此值和OpeningFee，随后仅增加Margin、扣除个人Cash。OpeningFee保存实际开仓费，旧仓null时用原费用公式还原。追加不改变数量、价格、原手续费或公共行情。
- StopPrice为个人仓位的可空止损触发价，旧档缺省null；品牌按内部十美元单位存储，外汇按原始汇率存储。做多报价≤StopPrice、做空报价≥StopPrice触发整笔平仓；1倍品牌做多也检查止损。旧仓强平适用于全部外汇、品牌做空及大于1倍品牌做多，使用Close计算的当前预计到账与InitialMargin的10%比较；新仓阈值见ExecutionVersion条目。强平与止损同时满足只记强平。旧仓由MarketExecution.Close计算成交均价、平仓费、到账和净盈亏；新仓由MarketClearing.PreviewClose/Close模拟途中触发的其他仓位，再通过Exit计算相同字段。止损触发后的各段成交共同形成最终均价。
- MarketOrder新增可选StopPrice，原字段和默认值兼容；margin操作使用Amount和Position，stop操作使用StopPrice和Position，null表示取消。两者都检查QuoteRevision及本人持仓编号；追加要求正数且不超过Cash。设置止损要求正数，多仓低于当前报价、空仓高于当前报价，取消不受价格条件限制。个人仓位字段随原Trading保存和过滤，不进入其他玩家的公开资料。
- MarketPosition.ExecutionVersion缺省0表示旧仓，Trade新仓明确写1。版本0继续原双侧曲线及10%阈值；版本1使用共同曲线及最坏退出资金到零的条件。旧仓保留Entry、Units、Margin、止损与既有盈亏。
- MarketQuote.ClearingDepthUnits为新仓固定数量K，LongUnits/ShortUnits保存全部账户新多仓/新空仓数量。Price由ExecutionBase和两侧数量共同计算。旧DepthUnits、BuyUnits、SellUnits继续服务旧仓。外部行情刷新旧字段，保留新仓数量。所有字段进入原JSON、事务副本和检查点。
- MarketClearing.Result为单次计算对象，含Quote数值副本、已触发仓位及账户引用、成交金额、均价、手续费和完整执行标志。Commit执行资金与数量变更。MarketState.RevisionCopy供margin/stop复制标量版本，共享只读Quotes与Events；开平仓仍复制完整Market。新仓追加保证金、设置和取消止损递增市场Revision。
- TradingAccounts和InspectMarket为JsonIgnore委托。房主BindMarket绑定当前事务全部成员账户；客机其他成员Trading经原过滤后为空，InspectMarket向房主查询。MarketInspection仅包含本人订单参数及本人持仓编号；MarketInspectionResult返回市场版本、本人净资产、双向订单摘要和本人退出结果。
- MarketOrder.QuoteRevision 约束开仓、平仓、追加保证金和止损设置，必须等于共同报价版本；按钮读取当前绑定视图中的报价版本。网络操作编号和重复收据仍由 CoopCommand 管理。
- CareerLifeState.Consumer 保存本人商品、数量、购买日期、宣发次数、邀请次数和事件编号。ConsumerPurchases 只读合并 BoughtDay/Goods，按未消费实物合计数量，用于持有徽章及实物收藏；宣发次数在 Consumer.Season 等于当前赛季时使用。Good.Durable 表示可举办活动，Good.Collectible 决定库存与实物展示。恢复与数量字段见本章职业收入、库存和国运字段。
- MarketAccounts、MarketSponsors 是 JsonIgnore 委托。BindMarket 在 Apply/Settle 的副本及 InitializeMarket 的恢复资料中绑定：处理所有成员账户（含离线成员）、读取参与者赞助；序列化、个人视图和网络不携带委托。交易输入复用该副本委托，不能指向提交前的旧 CoopWorld。

- CareerClub.Fans 保存普通俱乐部独立关注，AudienceReceipts 按赛事/轮次/对阵去重；OwnedClubState.Fans 保留自建俱乐部原独立关注。ClubAudience.Total 动态叠加现役前三人20%，不把这一部分写回独立关注。
- OwnedSponsor.AudienceVersion 仅保留旧字段兼容，新旧合同都通过 SponsorWeekly/SponsorWinBonus 使用当前俱乐部关注倍率；原 Weekly/WinBonus 基数、合同期限和已支付款项不变。OwnedClubState.HumanWeeklyWage/HumanWinBonus 缺省140/100，创建新俱乐部明确设置280/200，旧存档工资合同不重算。
- SponsorContract.BaseRetainer/BaseWinBonus 为可空基础金额；新报价直接写入，旧合同经 SponsorIncome.Initialize 一次确定，后续粉丝变化不改基础金额。Retainer/WinBonus 保留历史报价兼容，付款和界面读取 SponsorIncome 计算结果。NextOffer 保存已经选择的下期个人方案；到期由 RefreshOffers 转为当前合同并清空旧 NextOffer。PaidSeason 与 CommercialPaidMatches 继续分别防止赛季款、胜场款重复发放。Sponsors/SponsorOffers 属于当前玩家 Esports，多人由 CoopMember 的同名字段保存，View/Capture 及检查点自动包含新字段；未关联玩家的普通俱乐部赞助仍属于共同赛事资料。
- CeremonyAward.AudienceReward 可空；新颁奖写入当时实际关注奖励，旧空值读取90/240。奖项确定后不会随玩家后来的关注变化重算。
- Life.RelicVersion 缺省0，CareerRelics.Upgrade 恢复旧耗尽收藏、保留未领取储蓄，已领取储蓄清零；设为1后不重复迁移。原 Uses/Ended 字段继续反序列化兼容旧档，不作为新版购买次数门槛。
- MarketAccount.InterestRate 缺省0.0003，保留旧借款；新借款时按本金写入对应利率，还款不重定价。
- MarketTerminal 的自选名单位于本机 user://NationalSpire_market.cfg，按WorldId及Human分组。概况和动态属于本机显示状态；EventTitle读取旧事件，MarketEventRow使用记录的Day、Change与Person。旧待处理文本保留在Market.Events，由展示筛选选择当前可见事实。RefreshChart仅使用当前资产历史，切换图表范围保留已整理的概况和动态。Unbind清除当前CareerData、交易与人物回调、选中事件和搜索资料，并解除持仓卡片资料。
其他成员快照中的 Consumer、Trading 会清空，本人数据保留；公共行情一致共享。房主权威存档保留所有账户，用于离线结算和恢复。

## 编号、版本与顺序

| 字段 | 产生或修改者 | 使用者 | 表示什么 |
| --- | --- | --- | --- |
| CareerData.WorldId | 创建、导入及多人绑定 | 请求键、数据归属、头像等 | 生涯身份；不是请求次数 |
| CoopWorld.Id / Epoch | 生涯创建；房主恢复时生成新 Epoch | 命令、快照、流式接收、AI 回调 | 生涯编号与本次房间会话 |
| CoopWorld.Revision | 规则提交、AI 保存、部分房主状态提交 | 回执等待、快照新旧判断、CoopCareerSession.Refresh | 多人操作版本；不同于群聊版本 |
| CoopCommand.Id / Receipts | 本人建立命令；房主记录处理结果 | 现有重发与去重 | 同一操作的唯一编号；重发复用该命令 |
| GroupChat.Revision | GroupChats.Command、生成完成/失败等 | 群聊页面签名、总结完成校验 | 群聊内容变更；流式预留顺序保存不单独增加此值 |
| PrivateConversation.MemoryRevision | 编辑、删除、清空等 | 私信总结完成校验 | 记忆内容是否在请求期间改变 |
| PrivateTurn.Id / GroupTurn.Id | 新发言生成；重试、重新生成保留 | 引擎、Live 字典、流式、交互回退 | 原轮次身份；没有单独的群聊生成代次字段 |
| ChatWorld.Order | GroupChats.NextOrder，锁定 Chats 后递增 | 私信、群聊发言、成员通知、ChatTimeline | 同一生涯各会话记录的先后顺序 |
| UserOrder / ReplyOrder / GroupTurn.Order | 发送或回复提交入口 | 时间线拼接 | 玩家发言与私信回复的顺序 |
| GroupTurn.SpeechOrders | 流式解析器新增发言块时预留 | 最终 GroupReply.Order、页面重新打开时的通知位置 | 每个解析发言块的顺序，不是每名不同 NPC 的顺序 |
| LastReplyOrder | 私信完成时更新 | 通讯列表排序 | 会话最近回复排序；不代替 ChatWorld.Order |
| 交互编号、TurnId、Lane | PrivateInteractionIds、GroupInteractions | 附件匹配、交互卡片、重新生成回退 | 交互属于哪轮、哪个人物方向；不等同于帖子或轮次编号 |
| 作者/帖子/评论短编号 | AiWireProtocol | 输出解码和 ParseReplies | 单次请求的格式编号；真实保存编号仍用于业务引用 |
| CommunityPost.VoteRevision | CommunityVotes.Update / SetVote | 社区投票控件刷新 | 程序评分或玩家选择变化时递增；正文、回复及已读继续使用Revision / SeenRevision |

旧记录可能没有同日顺序。ChatTimeline 明确注明旧记录缺少先后信息。日期仍以天为单位，不新增实际时间字段。

## 聊天、总结与交互

Life.RandomEvents 保存随机事件。State 使用 waiting/generating/ready/failed/complete/skipped；Selected=-1 表示尚未选择。重新生成保留原 Story/Options/Reasoning，成功后整体替换；停止或失败时存在旧选项则回到 ready，首次生成则进入 failed。Reasoning 缺省空字符串，Phase 仅存在于内存 EventLive。Effects 每项包含一个语义作用键及该类型所需字段；故事、行动、结局分开保存。钱包协议使用美元，执行时按原货币规则换算；百分比执行时除以100。默认字段说明来自程序固定的 RandomEventPrompts.Format；可编辑 event 模板仅保存故事要求，正式生成和试写共用 Compose 追加协议；检查、预览与执行统一在 RandomEventEffects。

CareerData.Journey 保存 EventJourney.Destination 与 PausedDay，归共同日历；旧档缺省为零，表示普通停留。ResumePublications 使用 JsonIgnore，仅提示当前界面在恢复时启动原自动生成；重新加载由原主菜单请求入口读取 PausedDay。事件内容仍属于个人 Life.RandomEvents，共同旅途状态不包含人物和故事。

事件经历复用 PrivateTurn：RequestKind=event、Id=event:事件或比赛编号、ReplyDeleted=true。没有聊天历史的人物使用 EventOnly 会话，普通交流后自动显示联系人；事件轮次不计私信未读，SeenCount 保持包含全部完成轮次的原序号含义。ChatMembership 清除私聊时清除相同记录。NpcLearning.EventStatuses 保存来源、名称、截止日及百分比，MoodBonus 只计未到期状态。新增集合缺省为空，旧存档仍按原字段加载。

CoachTrainingPlan.CompletionDay / CompletionOrder 保存训练完成日期及 ChatWorld.Order 中的固定顺序。ClubCoaching.Advance 在进行中转为已完成时写入一次；每周成长、完成状态与顺序随原 CareerLife.Advance 保存。历史已完成训练缺省顺序为0，原历史卡片继续显示；更新时正在进行的训练正常生成完成通知。界面从当前私聊 Offers 或群聊 Interactions.Offers 的训练编号定位计划，MemoryDeleted 与 Forgotten 沿原清除规则过滤。完成通知是同一计划在时间线上的第二处显示，原接受卡片保留原 TurnId。分页、关闭窗口、重新载入及多人序列化均读取这两个字段。撤回训练接受通过 RestoreTraining 恢复计划，完成通知随计划一起恢复或移除。

| 数据 | 写入者 | 消费者与用途 |
| --- | --- | --- |
| PrivateTurn.Context | ProcessPrivateAsync 开始请求前 | Compose 与本轮上下文回查；和 sending 一起保存 |
| GroupTurn.Raw、Reasoning | 生成完成或失败 | 排查、思考过程、重新生成；流式期间主要放在实时字典 |
| PrivateLive / GroupLive、ReasoningLive | 模型流式回调与客机分片接收 | 页面增量显示；完成、失败、退出会清理；不是完整存档正文 |
| queued / sending / complete / failed | 发送、引擎、恢复入口 | 排队、按钮状态、结果提交、重试 |
| PrivateSummary.From / Through | 小总结、合并大总结 | 历史覆盖与删除最新总结恢复 |
| ContextStart / SummarizedThrough | 总结成功、清空、删除最新总结 | 本会话原文选择和自动总结判断 |
| GroupChat.Members / Aliases / Entries | 建群与成员管理 | 可发言人物、历史编号识别、按 Order 显示加入通知 |
| Offers / Attachments / Request | 玩家附件、解析标记、规则结果 | 接受/邀请判断、确认、卡片、上下文、撤回 |
| PrivateOffer.Quote / CommunityQuote / CommunityQuoteReply | CommunitySharing.Create建立预览，PrepareAttachments在dm-send按权威来源重新准备 | 保存社区主楼或评论引用；卡片读取Quote，显示与检索读取Detail，模型及总结沿AiDetail读取结构化上文 |
| PrivateTurn.Request（Kind=community-report） | dm-arbitrate调用CommunityReporting.Create，按权威帖子重建 | RequestKind仍为arbitration；Quote用于举报引用卡，Detail/AiDetail保存案件快照，SpireArbitration.Context与UserText读取 |
| Applied / Effects / 交互历史 | PrivateMessages.Apply、GroupInteractions.Apply | 重复执行判断、展示、整轮重新生成的回退 |
| PrivateMailbox.Relations[NPC] / PrivateRelation | 私信、群聊交互及 PrivateMessages.EditRelation | NPC 对该信箱所属玩家的好感、交往关系和印象；Revision 驱动私信显示更新；多人按 CoopMember.Life 分开保存 |
| Life.Relationships[NPC] | ChangeFavour、EditRelation、回退恢复和旧档迁移 | 生活活动的既有好感读取索引，与 PrivateRelation.Favour 同步 |
| CharacterCardEdit.Relation / CharacterRelationEdit | CharacterCardScreen 仅在输入发生变化时建立；Encode/Decode 传递 | 本次命令的可选修改；Favour 是 -100—100 的目标值，字符串空值表示未编辑，空字符串表示清空；不写入 CareerPerson，不进入 PNG 的 Fields/Bundle |

community-quote附件以PostId和允许为空字符串的ReplyId标识来源；ReplyId为空表示主楼。CommunityQuote保存PostRevision、主楼标题/作者编号与显示名/正文/日期，以及选中内容的ParentId、作者编号与显示名、正文和日期。Parents仅包含所选评论的直系父回复，按根到直接父排列；构造时限定同帖及当前可见日期，缺失父节点处结束，访问集合阻断循环与自身引用。来源帖子取CommunityThreads.All的首个同编号且Day不晚于当前日期的对象，来源回复同样按日期过滤及编号去重。

非玩家主楼有独立SourceBody时，Quote额外保存经GameText.Plain处理的PostSourceBody；PostAiSourceBody为对应AI版本，null表示与PostSourceBody相同。AiDetail包含type=community_quote、sourcePost、parents与quoted；主楼分享在quoted保存正文，sourcePost.body为null；评论分享同时携带主楼正文。sourcePost.recordedEvent读取PostAiSourceBody或其原文回退值。Detail仅保存所选作者、所选正文与来源标题，供界面及检索使用。

Create保存待发时的预览；dm-send的PrepareAttachments按来源编号逐项建立临时引用，全部附件校验通过后统一替换各community-quote的Quote、Detail、AiDetail、MatchId与PostRevision。发送前来源消失或正文尚在准备时返回错误，引用草稿保持原展示。发送后的Attachments持有该轮快照，重试、重新生成、历史和总结沿用已保存文本；后续来源归档或删除仍保留这份历史引用。旧档缺少Quote时为null，序列化跳过null；原Kind=post完整帖子附件和postVersions选择规则保持原义。

社区举报复用PrivateOffer和CommunityQuote；确认弹窗持有临时来源预览，取消时随界面释放，正式案件快照在确认后的权威命令处理中建立。命令以Request.Kind=community-report及Quote.PostId/ReplyId标识来源，PrivateMessageCommand.Text携带可选举报原因；非空白原因经Enqueue.Trim保存到PrivateTurn.User，空白回退到既有社区举报说明；空或null的ReplyId按主楼处理。dm-arbitrate核对真实作者与目标人物相同且为可私聊NPC，重新建立Quote、Detail和AiDetail，客户端提供的正文由权威来源覆盖。PrivateTurn.RequestKind保留arbitration，Request.Kind区分社区案件；Attachments继续保存普通私聊附件。

举报Detail保存可读中文材料：被举报作者与正文、来源帖标题与正文、已记录事件及带作者的讨论。AiDetail保存type=community_report的JSON，含sourcePost（完整主楼、作者、日期、版本、已记录事件）、reported（具体内容、作者及ParentId）、discussionComplete、totalReplies及带编号/作者/日期/ParentId的discussion；事件使用PostAiSourceBody或原文回退值。ContextReplies按当前日期及编号去重：最多40条时完整保留；更长时保留开头两条、近期十六条、被举报评论、其直接回应及这些节点的父链。主楼举报使用默认讨论选取。原帖更新、归档或移除后，已提交Request继续持有当时快照；失败重试重新读取当前人物实力与裁决，案件原文沿用快照。

旧档缺少这类Request时继续使用原私信仲裁。ArbitrationRecord.PostId仍是公开道歉帖编号，来源帖编号属于Request.Quote.PostId。删除申请原文或清空会话沿Manage清空Request和Context；已删除申请的dm-retry返回重新提交提示。UserText按forAi选择案件Detail/AiDetail，使后续聊天与总结保留举报对象，已删除申请跳过案件材料。

入群消息是独立 Entry，不增加聊天轮次。新成员能查看群里原记录，加入位置按全局 Order 表示。

聊天显示的 ChatHistoryPage<T> 只持有当前会话可见轮次的引用，页大小默认10、可选5；引用索引通过列表引用、数量及 MemoryRevision / GroupChat.Revision 更新。ChatHistoryScreen 的页码、滚动请求编号和新消息提示属于本机 CareerScreen。输入框操作行读取这些状态；原 PrivateTurn / GroupTurn、附件、交互及总结继续属于生涯记录。群通知按当前页面首轮至下一页面首轮的 Order 读取。

私信顶部关系/印象详情及好感文字的展开状态保存于本机ChatPreferences：WorldId:本机玩家编号分区中的identity:人物编号布尔值，缺省为true。点击关系或好感按钮同步显示并写入文件一次，普通刷新、切换人物、关闭再打开通讯及重启恢复同一选择。ChatComposerLayout.CenterPages在私信/群聊均为true，CommunityReplyExpressions返回的启用委托在选中任一会话时启用；分类、选项与异步定位编号归当前控件并随会话切换沿用。ChatComposerPanel.Expanded、附件目标高度和尺寸更新待执行标志归当前通讯输入区；放大切换保留草稿，发送恢复默认尺寸，关闭通讯释放。训练详情的_privateExpandedTraining为按计划Id维护的窗口内HashSet，新计划默认收起，普通卡片重建复用，关闭通讯清空。PrivateMoodButton及右侧状态说明属于当前身份控件，重建时收起；原始状态和到期日仍从CareerTraining.MoodLevel/MoodUntil读取。正文仍写入原_privateDrafts，发送使用原PrivateTurn；本次布局状态的生涯序列化字段数为0，旧存档沿原默认值读取。

本地 user://NationalSpire_chat.cfg 的分区为 WorldId:本机玩家编号，last保存人物编号或group:群编号，size保存5或10，pins保存按最近置顶在前排列的人物编号或group:群编号数组，identity:人物编号保存私聊人物详情的展开布尔值。选择会话与更改轮数写入本地配置；翻页只更新内存。旧 Mailbox.LastPerson 用于首次恢复私信入口；通讯选择改由本地配置记录，dm-select 命令继续保留在原规则入口。私聊/群成员档案的返回记录使用Location.PrivatePerson / Group / ChatPage / ChatScroll，生命周期为当前生涯界面导航历史。具体调用、失效与保存边界见[聊天分页](GAME_AND_UI.md#私信与群聊历史分页)。

最新总结删除且没有其他总结完整覆盖其范围时，原文起点回退到被删总结的 From。聊天与再总结都恢复这一段直到当前最新记录，不按配置额外裁剪恢复区间。非最新总结删除不回退；其确认框提示“删除这条总结可能导致永久丢失记忆”。

外部会话记录只按既有窗口选择，不等待来源总结成功。当前会话总结读取本会话材料，群聊总结不将外部私信原文写入群摘要。详细选择见[AI 流程](AI_FLOWS.md)。

手动编辑 NPC 对当前玩家的三项时，仅覆盖实际编辑字段。未编辑字段使用保存时最新值，取消不提交。PrivateInteractionHistory.PreserveRelation 从该玩家的私信会话以及所有群的 `human/NPC/` 交互会话中，删除 Before/After.relation 对应字段；保留整个回退对象及其他数据。NPC 对其他真人或 NPC 的交互方向保持原样。修改后的新回复继续建立正常回退记录，重新生成可以恢复至手动设置后的值。原文、总结、训练、邀约、合同等数据不会因手动编辑三项而删除。

PNG 仍使用 CharacterCardPng.Bundle Version=1 和原 Fields。导出只交换人物资料，导入只建立新人物，不携带好感、关系或印象；新人物使用0、初识、空印象。旧命令缺少 Relation 时按原人物编辑流程执行，旧存档继续由 Mailbox(CareerLifeState) 执行原迁移。字符长度限制取消，必填、非法字符、重名、数值及合同规则保持；多人整体容量限制保持原规则。

## 赛事、阵容、资料与记忆

OwnedTransfer.ArrivalSeason 记录签字时约定的到队赛季；新记录由 TransferSeason 按开赛日期决定，已有记录继续读取所存日期。Arrived 表示已经转移归属及合同，Contract.SignedDay/EndDay 从实际到队日期起算。SourceTurnId/SourceHumanId 将跨季到队交互关联到签字时的私聊轮次；当天到队由外层 PrivateContracts.Confirm 记录同一次合同回退。

PrivateInteractionHistory.Capture 的合同快照增加 refillPeople、refillPosts、refillSavedThreads，按稳定编号保存原补员入口产生的人物及报道。Difference 仍只将实际变化写入 PrivateInteractionUndo，Rewind / RestoreRefills 复用原逐字段回退，恢复对应集合及双方赛事，其他人物、帖子、后来的独立金额变化继续使用当前值。旧回退记录缺少这些键时读取当前集合；加载和启动继续使用原字段默认值。人物模型、合同及赛事版本编号继续沿用。

| 数据 | 生产者 | 下游使用者与独立性 |
| --- | --- | --- |
| 人物 ClubId、合同、首发/轮换/青训/教练席位 | 人物与俱乐部规则 | 彼此是独立字段，修改 ClubId 不等于签约；训练与赛程分别读取相应关系 |
| WorldCompetition.Rosters、Fixtures、Table | 赛事生成与名单更新 | 历史名单、实际单场对阵、排名；已完成比赛不因当前席位改变而重新写入 |
| CareerMatch / CareerResult / RunEvidence | 排赛、比赛准备、原版证据和结算 | 开赛、转播、历史、战报、荣誉、模型事实；通关与比赛胜负分别保存 |
| CeremonyAward.Reason / Title | SeasonCeremony.PersonAward、ClubAwards生成；历史值保留 | CeremonyAwards与CreateWeeklyCover通过AwardDescription统一展示；新Reason也交给Close写入荣誉详情。评选公式独立保留在ScoringRules、ClubRules中，文案不参与得分、奖励与并列判定；具体入口见GAME_AND_UI的“颁奖文案与评选依据” |
| CareerMatch.OpponentPrepared / OpponentWon / OpponentFloor / OpponentSeconds | MatchRules.PrepareOpponent；多人开赛由 CoopRules.Start 生成 | 表示已确定的对手成绩，转播和结算直接读取。更新用时分布不重算已有准备结果，不新增个人速度字段；用时参数和调用关系见 GAME_AND_UI 的“对手成绩与通关用时” |
| Character / CharacterId | 人物、GameBridge.ReadEvidence、结算 | 界面可以显示皮肤名称；发给 AI 的职业转换由 CharacterIdentity 处理 |
| CommunityPost 原始主题/事实/赛果与正文/Replies | 事件发布、玩家提交、模型应用 | 原始事实与模型正文分开；parentId 指向同帖上文 |
| CommunityPost / CommunityReply.AudienceScore | Remember → CommunityVotes.Update | 可空 Int32 受众原始净赞数；沿用 JSON 键 AiNetScore。界面按主楼/NPC 评论乘6、玩家评论乘16，再加手动票 |
| CommunityPost / CommunityReply.PlayerVotes | CommunityVotes.SetVote | 以实际玩家编号为键保存 -1 / +1，取消时移除键；Choice 读取当前玩家，Score 用 Int64 汇总按作者类型放大后的程序评分与全部有效玩家票 |
| CommunityMemory | 公开事实和讨论整理 | 本地检索、上下文；来源 PostId、人物和日期参与过滤 |
| CommunityPromptContext 的评论集合、PublicMemoryRequest 的共享群聊、AiWireProtocol 的 communitySources | 一次请求内建立 | 发送前序列化；来自现有帖子、评论和群聊。引用编号只用于请求，持久数据仍归原对象管理；PrivateTurn.Context 按原保存节点记录整段材料 |
| CommunityPost.AiSourceBody / CommunityMemory.AiText / PrivateOffer.AiDetail | RememberMatch、CoopRules.Settle、Remember、PrepareAttachments 在生成职业事实时填写；仅有差异时保存 | 原字段负责界面和检索；AiGeneratedText 供请求读取，缺失回退原字段。WhenWritingNull 省略空字段。旧档不迁移，既有 JSON 深复制、保存、权限过滤和广播继续管理这些字段 |
| WeeklyEdition 与生成阶段 | WeeklyJournal 捕获事实；AiWeekly 应用结果 | 双周档案、文章、界面、重试；事实快照和生成状态不是同一项数据 |
| 人物简介/记忆/关系/状态 | 档案、周刊、聊天与交互 | 供后续上下文使用；旧自由文本不属于本次职业入口转换的范围 |

社区评分随原帖子与评论保存。AudienceScore使用JsonPropertyName沿用AiNetScore键。CommunityVersion=6表示已升级；单人载入经原Normalize，房主恢复在RecoverInterrupted与Commit前调用Normalize。低于6时遍历Posts / SavedThreads并Remember，重算受众评分，玩家字典继续沿用；达到6直接返回。旧AiScoreRevision由JSON反序列化忽略。

CommunityVotes.Update每次建立人物编号字典、评论编号字典、父编号分组及局部关注缓存。作者关注F、相关人物最大关注P、回复数N形成受众规模R=(12+sqrt(F)+0.25sqrt(P))×赛事倍率×楼层倍率×(1+0.2ln(1+N))。世界杯/世界总决赛/大师赛倍率3、洲际杯2、联赛1.5、其余1；主楼倍率1、评论0.35；少于8字符乘0.6。主楼N取全帖评论数，评论N取直接子评论数。当前玩家读取Fans，其他人物沿CareerAudience.Followers。

支持比例为0.56+min(0.12,0.018log10(1+F))，增加按帖子编号和作者编号确定的固定随机项[-0.28,0.28]；熟人增加0.03，同俱乐部或支持该俱乐部增加0.04，职业选手或有冠军增加0.02；帖子作者在主楼及自己的评论中增加0.04。支持比例限定0.05—0.95。原始分数s=R×固定随机受众项[0.65,1.35]×(2×支持比例-1)。s≥0时四舍五入；s<0时改为round((2u−0.8)×(1+abs(s))^0.2)，u由帖子与作者固定生成。受众倾向及负反馈换算由同一作者在该帖共用，正文及楼层编号影响传播量；词语内容作为原文字保留。

内容通过Remember更新，重复计算相同输入数值稳定。AudienceScore以Int64按主楼/NPC评论乘6、玩家评论乘16；Score再加有效玩家票。SetVote按个人视图LocalHumanId识别玩家，单人取player；-1/0/+1分别点踩、取消、点赞，相同选择返回false，实际变化递增VoteRevision。程序评分变化也递增VoteRevision。调用者沿原保存入口提交，界面读取只计算分数之和。

具体读写引用见 Source 中的字段与属性引用。索引记录引用事实，不能仅凭“引用了字段”推断该函数会修改字段；写入条件和先后顺序以流程与函数体为准。
