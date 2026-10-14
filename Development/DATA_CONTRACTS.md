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
| AiOptions、密钥 | AiSettingsStore、本机设置与请求入口 | 设置界面、加密密钥或环境变量 | 本机 AI 调用；公开序列化排除本机配置，保留公开 Enabled |
| PrivatePromptSnapshot | Broadcast 填入各聊天场景与 world 模板 | 房主本机模板库 | 客机相关界面/上下文读取；房主生成重新读取本机设置 |

多人个人视图不是独立共享生涯，也不能代替房主最新数据。复制有不同用途：规则执行前的副本用于失败时保留原数据；个人视图用于兼容共用规则；网络副本用于剔除接收者不应看到的数据。三者不能仅因都调用 Copy 就视作重复。

## 国运、模拟与经济数据

- WorldCompetition.FortuneVersion：0 为旧赛事，整届结束发放；1 为新建国际赛事，逐场发放。旧档已生成赛事保持 0，防止重复发放历史赛果。
- WorldFixture.FortuneSettled 防止重复确认赛果；PromotionSettled 防止重复补充团体晋级贡献；Fortune 保存各人的本场贡献，DevelopmentChanges 保存实际等级变化。预生成成绩不设置收据。
- CircuitAward.Completed 默认 true，兼容旧荣誉。逐场创建记录为 false、积分为 0；最终 Settle 在原记录补充名次和积分。世界荣誉只取完成记录，国运榜读取进行中的贡献；积分完成后主动失效 AvatarHonors 排名缓存。
- NationalLegacy.Indicators 为九项等级，Pending 为三类未用建设余额，MaintenanceFunding 为本赛季维护额度；DevelopmentVersion、ReportSeason 用于迁移和换季去重。首次启用给予当前赛季 120 维护额度，不追扣历史维护。NewsDay/NewsFortune/NewsChanges 保存公报候选，LastReport 供界面读取。
- CareerResult.Simulated 默认 false。模拟成绩仍写入原结果、荣誉、评分、奖金、关注和职业最高进阶；主要战报与结算标明模拟。模拟不产生原版对局、原版战斗记录、牌组或战斗证据。
- CareerPerson.Fans 可空，null 时从 CareerAudience 读取初值，NPC 首次增加关注时写入整数。真人以 CoopMember.Fans 为准，RefreshPeople 更新显示人物。旧玩家关注不重算。
- CareerData.Market 为公开共同行情。CatalogVersion=2 表示199项资产及60天起始曲线初始化完成；LastDay 为最后更新日，Revision 为报价版本。每项 Quote 保存现价、前价及最多180条价格；SyntheticThrough 区分补入的模拟前史，PendingSignal 保存待下一交易日结算的汇率赛事影响。Market.Events 保存最多240条公开市场事件，NewsDay 为已选入新闻的截止日期。
- CareerLifeState.Trading 为本人账户，含 Cash、Debt、InterestDay、InterestRate、NextPosition、Positions 和最近 120 条 Trades。金额为内部 Credits 单位，显示美元为十倍；报价、仓位使用 decimal，钱包余数仍用 CreditFraction。
- PendingSignal 保存外币国减中国的赛事强弱信号，下一交易日以负号计入报价后清零；报价表示1人民币兑换的外币数量。旧价格、历史、持仓和待处理信号不迁移。MarketEvent.Change 对外汇赛果事件保留同一强弱信号，对品牌报价事件表示价格变化；外汇消息正文不把该字段当成涨幅。
- 品牌与外汇共用 MarketPosition 的 Margin、Units、Entry、Direction 和 Leverage，品牌只允许Direction=1；1倍品牌旧仓不自动平仓，大于1倍沿用外汇10%权益阈值。CloseValue 统一手动/自动平仓返回金额；品牌两种平仓均扣0.1%卖出费，外汇免费，无新增存档字段。
- MarketOrder.QuoteRevision 只约束买入和平仓，必须等于共同报价版本；按钮读取当前绑定视图中的报价版本。网络操作编号和重复收据仍由 CoopCommand 管理。
- CareerLifeState.Consumer 保存本人商品、购买日期、宣发次数、邀请次数和生成帖子用的递增编号。旧档获得空账户、空物品，原余额不变；耐用品保留，较旧一次性消费历史由账目和帖子保留。
- MarketAccounts、MarketSponsors 是 JsonIgnore 委托。BindMarket 在 Apply/Settle 的副本中绑定：处理所有成员账户（含离线成员）、读取参与者赞助；序列化、个人视图和网络不携带委托。

- CareerClub.Fans 保存普通俱乐部独立关注，AudienceReceipts 按赛事/轮次/对阵去重；OwnedClubState.Fans 保留自建俱乐部原独立关注。ClubAudience.Total 动态叠加现役前三人20%，不把这一部分写回独立关注。
- OwnedSponsor.AudienceVersion 缺省0沿用旧收入公式，新报价1使用俱乐部关注倍率。OwnedClubState.HumanWeeklyWage/HumanWinBonus 缺省140/100，创建新俱乐部明确设置280/200，旧存档合同不重算。
- CeremonyAward.AudienceReward 可空；新颁奖写入当时实际关注奖励，旧空值读取90/240。奖项确定后不会随玩家后来的关注变化重算。
- Life.RelicVersion 缺省0，CareerRelics.Upgrade 恢复旧耗尽收藏、保留未领取储蓄，已领取储蓄清零；设为1后不重复迁移。原 Uses/Ended 字段继续反序列化兼容旧档，不作为新版购买次数门槛。
- MarketAccount.InterestRate 缺省0.0003，保留旧借款；新借款时按本金写入对应利率，还款不重定价。
- MarketTerminal 的自选名单位于本机 user://NationalSpire_market.cfg，按WorldId及Human分组；不进生涯、不广播。控件缓存不持有离开页面后的CareerData或交易回调。
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
| CommunityPost.AiSourceBody / CommunityMemory.AiText / PrivateOffer.AiDetail | RememberMatch、CoopRules.Settle、Remember、PrepareAttachments 在生成职业事实时填写；仅有差异时保存 | 原字段负责界面和检索；AiGeneratedText 供请求读取，缺失回退原字段。WhenWritingNull 省略空字段。旧档不迁移，既有 JSON 深复制、保存、权限过滤和广播继续管理这些字段 |
| WeeklyEdition 与生成阶段 | WeeklyJournal 捕获事实；AiWeekly 应用结果 | 双周档案、文章、界面、重试；事实快照和生成状态不是同一项数据 |
| 人物简介/记忆/关系/状态 | 档案、周刊、聊天与交互 | 供后续上下文使用；旧自由文本不属于本次职业入口转换的范围 |

具体读写引用见 Source 中的字段与属性引用。索引记录引用事实，不能仅凭“引用了字段”推断该函数会修改字段；写入条件和先后顺序以流程与函数体为准。
