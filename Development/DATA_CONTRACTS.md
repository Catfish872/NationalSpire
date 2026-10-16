# 数据归属与使用约定

## 单人与多人数据

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
| PrivatePromptSnapshot | Broadcast 填入各聊天场景与 world 模板 | 房主本机模板库 | 客机相关界面/上下文读取；房主生成重新读取本机设置 |

多人个人视图不是独立共享生涯，也不能代替房主最新数据。复制有不同用途：规则执行前的副本用于失败时保留原数据；个人视图用于兼容共用规则；网络副本用于剔除接收者不应看到的数据。三者不能仅因都调用 Copy 就视作重复。

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
- CareerLifeState.Consumer 保存本人商品、购买日期、宣发次数、邀请次数和生成帖子用的递增编号。旧档获得空账户、空物品，原余额不变；耐用品明细保留，较旧普通消费明细会清理，但 BoughtDay 保留每款最近购买日期。ConsumerPurchases 只读合并 BoughtDay/Goods，用于已购徽章及实物收藏，不新增存档字段；本季状态来自 Goods.Season，宣发次数仅在 Consumer.Season 等于当前赛季时使用。Good.Durable 仍代表可举办活动、终身限购的原规则；Good.Collectible 独立决定实物展示，不把杂志等普通商品改成终身限购。Consumed 不参与收藏展示过滤。
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

旧记录可能没有同日顺序。ChatTimeline 明确注明旧记录缺少先后信息。日期仍以天为单位，不新增实际时间字段。

## 聊天、总结与交互

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
| Applied / Effects / 交互历史 | PrivateMessages.Apply、GroupInteractions.Apply | 重复执行判断、展示、整轮重新生成的回退 |
| PrivateMailbox.Relations[NPC] / PrivateRelation | 私信、群聊交互及 PrivateMessages.EditRelation | NPC 对该信箱所属玩家的好感、交往关系和印象；Revision 驱动私信显示更新；多人按 CoopMember.Life 分开保存 |
| Life.Relationships[NPC] | ChangeFavour、EditRelation、回退恢复和旧档迁移 | 生活活动的既有好感读取索引，与 PrivateRelation.Favour 同步 |
| CharacterCardEdit.Relation / CharacterRelationEdit | CharacterCardScreen 仅在输入发生变化时建立；Encode/Decode 传递 | 本次命令的可选修改；Favour 是 -100—100 的目标值，字符串空值表示未编辑，空字符串表示清空；不写入 CareerPerson，不进入 PNG 的 Fields/Bundle |

入群消息是独立 Entry，不增加聊天轮次。新成员能查看群里原记录，加入位置按全局 Order 表示。

聊天显示的 ChatHistoryPage<T> 只持有当前会话可见轮次的引用，页大小默认10、可选5；引用索引通过列表引用、数量及 MemoryRevision / GroupChat.Revision 更新。ChatHistoryScreen 的页码、滚动请求编号和新消息提示属于本机 CareerScreen。输入框操作行读取这些状态；原 PrivateTurn / GroupTurn、附件、交互及总结继续属于生涯记录。群通知按当前页面首轮至下一页面首轮的 Order 读取。

本地 user://NationalSpire_chat.cfg 的分区为 WorldId:本机玩家编号，last 保存人物编号或 group:群编号，size 保存5或10。选择会话与更改轮数写入本地配置；翻页只更新内存。旧 Mailbox.LastPerson 用于首次恢复私信入口；通讯选择改由本地配置记录，dm-select 命令继续保留在原规则入口。群成员档案的返回记录使用 Location.Group / ChatPage / ChatScroll，生命周期为当前生涯界面导航历史。具体调用、失效与保存边界见[聊天分页](GAME_AND_UI.md#私信与群聊历史分页)。

最新总结删除且没有其他总结完整覆盖其范围时，原文起点回退到被删总结的 From。聊天与再总结都恢复这一段直到当前最新记录，不按配置额外裁剪恢复区间。非最新总结删除不回退；其确认框提示“删除这条总结可能导致永久丢失记忆”。

外部会话记录只按既有窗口选择，不等待来源总结成功。当前会话总结读取本会话材料，群聊总结不将外部私信原文写入群摘要。详细选择见[AI 流程](AI_FLOWS.md)。

手动编辑 NPC 对当前玩家的三项时，仅覆盖实际编辑字段。未编辑字段使用保存时最新值，取消不提交。PrivateInteractionHistory.PreserveRelation 从该玩家的私信会话以及所有群的 `human/NPC/` 交互会话中，删除 Before/After.relation 对应字段；保留整个回退对象及其他数据。NPC 对其他真人或 NPC 的交互方向保持原样。修改后的新回复继续建立正常回退记录，重新生成可以恢复至手动设置后的值。原文、总结、训练、邀约、合同等数据不会因手动编辑三项而删除。

PNG 仍使用 CharacterCardPng.Bundle Version=1 和原 Fields。导出只交换人物资料，导入只建立新人物，不携带好感、关系或印象；新人物使用0、初识、空印象。旧命令缺少 Relation 时按原人物编辑流程执行，旧存档继续由 Mailbox(CareerLifeState) 执行原迁移。字符长度限制取消，必填、非法字符、重名、数值及合同规则保持；多人整体容量限制保持原规则。

## 赛事、阵容、资料与记忆

| 数据 | 生产者 | 下游使用者与独立性 |
| --- | --- | --- |
| 人物 ClubId、合同、首发/轮换/青训/教练席位 | 人物与俱乐部规则 | 彼此是独立字段，修改 ClubId 不等于签约；训练与赛程分别读取相应关系 |
| WorldCompetition.Rosters、Fixtures、Table | 赛事生成与名单更新 | 历史名单、实际单场对阵、排名；已完成比赛不因当前席位改变而重新写入 |
| CareerMatch / CareerResult / RunEvidence | 排赛、比赛准备、原版证据和结算 | 开赛、转播、历史、战报、荣誉、模型事实；通关与比赛胜负分别保存 |
| CeremonyAward.Reason / Title | SeasonCeremony.PersonAward、ClubAwards生成；历史值保留 | CeremonyAwards与CreateWeeklyCover通过AwardDescription统一展示；新Reason也交给Close写入荣誉详情。评选公式独立保留在ScoringRules、ClubRules中，文案不参与得分、奖励与并列判定；具体入口见GAME_AND_UI的“颁奖文案与评选依据” |
| CareerMatch.OpponentPrepared / OpponentWon / OpponentFloor / OpponentSeconds | MatchRules.PrepareOpponent；多人开赛由 CoopRules.Start 生成 | 表示已确定的对手成绩，转播和结算直接读取。更新用时分布不重算已有准备结果，不新增个人速度字段；用时参数和调用关系见 GAME_AND_UI 的“对手成绩与通关用时” |
| Character / CharacterId | 人物、GameBridge.ReadEvidence、结算 | 界面可以显示皮肤名称；发给 AI 的职业转换由 CharacterIdentity 处理 |
| CommunityPost 原始主题/事实/赛果与正文/Replies | 事件发布、玩家提交、模型应用 | 原始事实与模型正文分开；parentId 指向同帖上文 |
| CommunityMemory | 公开事实和讨论整理 | 本地检索、上下文；来源 PostId、人物和日期参与过滤 |
| CommunityPromptContext 的评论集合、PublicMemoryRequest 的共享群聊、AiWireProtocol 的 communitySources | 一次请求内建立 | 发送前序列化；来自现有帖子、评论和群聊。引用编号只用于请求，持久数据仍归原对象管理；PrivateTurn.Context 按原保存节点记录整段材料 |
| CommunityPost.AiSourceBody / CommunityMemory.AiText / PrivateOffer.AiDetail | RememberMatch、CoopRules.Settle、Remember、PrepareAttachments 在生成职业事实时填写；仅有差异时保存 | 原字段负责界面和检索；AiGeneratedText 供请求读取，缺失回退原字段。WhenWritingNull 省略空字段。旧档不迁移，既有 JSON 深复制、保存、权限过滤和广播继续管理这些字段 |
| WeeklyEdition 与生成阶段 | WeeklyJournal 捕获事实；AiWeekly 应用结果 | 双周档案、文章、界面、重试；事实快照和生成状态不是同一项数据 |
| 人物简介/记忆/关系/状态 | 档案、周刊、聊天与交互 | 供后续上下文使用；旧自由文本不属于本次职业入口转换的范围 |

具体读写引用见 Source 中的字段与属性引用。索引记录引用事实，不能仅凭“引用了字段”推断该函数会修改字段；写入条件和先后顺序以流程与函数体为准。
