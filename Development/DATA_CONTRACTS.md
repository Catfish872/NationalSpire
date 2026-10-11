# 数据归属与使用约定

## 单人与多人数据

| 数据 | 管理者与写入入口 | 输入来源 | 下游使用者 |
| --- | --- | --- | --- |
| CareerData | 单人由 CareerStore 绑定实例和文件；多人由 CoopWorld.World 管理共享部分 | 生涯规则、游戏事实、AI 成品 | 页面、模拟、上下文、迁移、序列化 |
| CoopWorld | 房主 CoopCoordinator；操作经 CoopRules，AI 经保存回调 | 命令结果、成员状态、最新共享生涯、原版比赛状态 | 检查点、Broadcast、个人视图、原版恢复 |
| CoopMember | CoopRules 及个人交互保存合并 | SteamId、个人身份、资金、生活、私信、战绩、已读信息 | 个人视图、本人快照、群聊记忆来源 |
| 多人个人 CareerData 视图 | CoopRules.View → CoopCareerSession 或 AI Current | 共享生涯复制后覆盖该成员的个人数据 | 共用单人页面与规则；修改结果按用途合并回房主 |
| ExternalCurrent / ExternalSave | 会话或公共 AI 任务建立；JsonIgnore | 当前绑定、会话编号、代次、个人视图 | CareerStore.IsCurrent / Save、AI 完成后的有效性与保存 |
| PrivateMemorySources | 多人聊天 Current 填入其他真人信箱；JsonIgnore | 当前各成员信箱副本 | ChatTimeline；群聊交互通过 CaptureGroup 合并实际变更 |
| AiOptions、密钥 | AiSettingsStore、本机设置与请求入口 | 设置界面、加密密钥或环境变量 | 本机 AI 调用；公开序列化排除本机配置，保留公开 Enabled |
| PrivatePromptSnapshot | Broadcast 填入各聊天场景与 world 模板 | 房主本机模板库 | 客机相关界面/上下文读取；房主生成重新读取本机设置 |

多人个人视图不是独立共享生涯，也不能代替房主最新数据。复制有不同用途：规则执行前的副本用于失败时保留原数据；个人视图用于兼容共用规则；网络副本用于剔除接收者不应看到的数据。三者不能仅因都调用 Copy 就视作重复。

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

入群消息是独立 Entry，不增加聊天轮次。新成员能查看群里原记录，加入位置按全局 Order 表示。

最新总结删除且没有其他总结完整覆盖其范围时，原文起点回退到被删总结的 From。聊天与再总结都恢复这一段直到当前最新记录，不按配置额外裁剪恢复区间。非最新总结删除不回退；其确认框提示“删除这条总结可能导致永久丢失记忆”。

外部会话记录只按既有窗口选择，不等待来源总结成功。当前会话总结读取本会话材料，群聊总结不将外部私信原文写入群摘要。详细选择见[AI 流程](AI_FLOWS.md)。

## 赛事、阵容、资料与记忆

| 数据 | 生产者 | 下游使用者与独立性 |
| --- | --- | --- |
| 人物 ClubId、合同、首发/轮换/青训/教练席位 | 人物与俱乐部规则 | 彼此是独立字段，修改 ClubId 不等于签约；训练与赛程分别读取相应关系 |
| WorldCompetition.Rosters、Fixtures、Table | 赛事生成与名单更新 | 历史名单、实际单场对阵、排名；已完成比赛不因当前席位改变而重新写入 |
| CareerMatch / CareerResult / RunEvidence | 排赛、比赛准备、原版证据和结算 | 开赛、转播、历史、战报、荣誉、模型事实；通关与比赛胜负分别保存 |
| Character / CharacterId | 人物、GameBridge.ReadEvidence、结算 | 界面可以显示皮肤名称；发给 AI 的职业转换由 CharacterIdentity 处理 |
| CommunityPost 原始主题/事实/赛果与正文/Replies | 事件发布、玩家提交、模型应用 | 原始事实与模型正文分开；parentId 指向同帖上文 |
| CommunityMemory | 公开事实和讨论整理 | 本地检索、上下文；来源 PostId、人物和日期参与过滤 |
| CommunityPost.AiSourceBody / CommunityMemory.AiText / PrivateOffer.AiDetail | RememberMatch、CoopRules.Settle、Remember、PrepareAttachments 在生成职业事实时填写；仅有差异时保存 | 原字段负责界面和检索；AiGeneratedText 供请求读取，缺失回退原字段。WhenWritingNull 省略空字段。旧档不迁移，既有 JSON 深复制、保存、权限过滤和广播继续管理这些字段 |
| WeeklyEdition 与生成阶段 | WeeklyJournal 捕获事实；AiWeekly 应用结果 | 双周档案、文章、界面、重试；事实快照和生成状态不是同一项数据 |
| 人物简介/记忆/关系/状态 | 档案、周刊、聊天与交互 | 供后续上下文使用；旧自由文本不属于本次职业入口转换的范围 |

具体读写引用见 Source 中的字段与属性引用。索引记录引用事实，不能仅凭“引用了字段”推断该函数会修改字段；写入条件和先后顺序以流程与函数体为准。
