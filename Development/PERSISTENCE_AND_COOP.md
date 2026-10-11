# 保存、广播与恢复

## 单人生涯保存的顺序

CareerStore.Save 首先检查 ExternalSave：多人或专用视图传入时执行该回调，不写入单人默认文件。

普通单人顺序：

1. 进入 Gate，确定传入 CareerData 已绑定的 Paths 文件路径。
2. 全部生涯序列化为 JSON 字符串，写入同目录 .tmp。
3. 主文件存在时比较已验证的文件长度、修改时间；缓存失效才重新 Read 校验。
4. 主文件有效时复制到 .bak；损坏 JSON 或结构无效时保留原有正常备份。
5. 将 .tmp 移动替换主文件，更新已验证标记。
6. 保存的是当前 _data 时，另行保存本机 AI 设置。

读档 Read 使用 File.ReadAllText 再反序列化。Save 将生涯序列化为字符串，再写入临时文件。

Data 属性不只是获取字段：首次读取会加载文件、恢复备份、迁移、修复阵容、恢复中断生成、载入 AI 设置，必要时再次 Save。性能与依赖检查必须包含 getter 的这些工作。

## 加载、切换与删除

| 操作 | 当前调用与处理 | 后续依赖 |
| --- | --- | --- |
| 加载 | CareerStore.Data → Read；异常保留 broken 文件并尝试 .bak；执行各迁移和 Recover | 页面取得绑定实例，queued/sending 等恢复为既有可重试状态 |
| 切换生涯 | Save 旧实例 → 校验目标 → CareerLibrary.Select → Data 加载；失败恢复旧选择与旧实例 | 请求完成仍按原绑定实例/路径处理；当前页面切换到新实例 |
| 删除生涯 | 与 Save 使用同一 Gate；撤销被删实例路径绑定 | 异步旧实例不能重建已删除文件；原版当前对局仍由原版管理 |
| 单人重置 | 保存并另存旧文件 → 创建新生涯并绑定同路径 → 保存 | 旧备份与新实例用途分开 |
| 导入导出 | CareerLibrary 与对应格式入口 | 不因导入模组资料而改写原版单人对局 |

单人 Save 不声称具有多人 WriteThrough + Flush(true) 的完全相同持久性。进程中断与断电也不是同一测试条件。

## 多人命令提交的完整顺序

| 顺序 | 函数 | 输入与状态 | 输出交给谁 |
| --- | --- | --- | --- |
| 1 | CoopCareerSession.Send → Retry / 网络 command | 生涯 Id、Epoch、Revision、命令 Id、类型、对象、参数 | 房主 Execute |
| 2 | CoopRules.Apply | 身份、会话、操作版本、已处理 Receipts、在线名单 | 复制后执行规则，返回 World 与 Outcome；重复命令复用旧结果 |
| 3 | Execute → Commit(..., broadcast:false) | 接受结果或实际变更 | CoopStorage.Save 先写入检查点，再替换房主当前 World |
| 4 | Execute → reply | 处理结果与已提交 World.Revision | 本人回执或发送给客机 |
| 5 | Broadcast | 最新 World、NativeSave、每名接收者 | 每人自己的完整快照分片 |
| 6 | 客机 Receive(snapshot) | 完整组装的快照，校验成员/会话/版本 | 先保存客机检查点，再更新当前 World/NativeSave |
| 7 | CompleteReplies、Changed | 已确认回执与已收到对应版本 | 个人操作完成；CoopCareerSession.Refresh 重建视图；页面刷新 |
| 8 | 房主 TriggerAi / StartPrivate / StartGroup | 已成功且非重复的命令 | 相关生成入口，不因同命令重发再次生成 |

回执“房主已确认”与“客机已经取得对应资料”分成两步。CompleteReplies 等到快照 Revision 达到回执要求后才继续。提前确认或只改房主内存，会改变这套实际完成条件。

## 多人 AI 的 current / save / progress

| 委托 | 私信 | 群聊 | 依赖与用途 |
| --- | --- | --- | --- |
| Current | 校验房间与发送者，读取最新个人视图、信箱和本机配置 | 同样建立最新 View，并提供其他成员信箱用于相关记忆 | 每次调用可能复制整份数据；跨 await 后重新获取，保留期间其他操作 |
| Save | 复制最新 World，再合并该成员信箱、关系、顺序及实际业务变化 | 复制最新 World，CaptureGroup 合并 Chats、Matches、OwnedClub 等，再处理对应信箱与人物 | Revision 加一 → Commit；不能用请求开始的旧整份 World 覆盖 |
| progress | 当前正文与思考分片交给接收方 | 只发送给该群里的其他真人成员 | 更新实时显示；与完整快照是不同通道 |

群聊开始时 sending 状态依靠 Save 合并进入房主当前数据。后面的 Current 从这份数据读取；仅删除开始 Save，完成时可能取得旧 queued，而无法走原完成提交条件。

群聊流式新发言块预留 SpeechOrders 后也会 Save。它同时导致检查点、版本更新与完整广播。减去这一保存会影响客机重新打开聊天时的通知与发言顺序，不仅影响磁盘开销。

公共 AI 使用 ExternalCurrent / ExternalSave，CoopAi 完成时只合并该任务的新帖子、回复、周刊与资料；保留期间其他成员内容。业务规则执行前的 World 副本仍用于错误时不提交部分修改。

## 完整快照与流式分片的区别

| 项目 | 完整 snapshot | private-chunk |
| --- | --- | --- |
| 内容 | 接收者可见生涯、请求状态、发言顺序、成员资料、配套 NativeSave、模板快照等 | World、Epoch、Person、Turn、Text、Sequence、Reasoning |
| 产生入口 | Broadcast → PublicBytes → SnapshotEncoder → Encode → Split | StartPrivate / StartGroup progress → Bytes → Split |
| 隐私 | 剔除不属于接收者的群和其他人信箱；本机 AI 配置与密钥排除 | 私信向本人；群聊向群内真人 |
| 接收 | 组装、校验、保存检查点、更新数据、刷新 | 校验会话、接收权限、顺序；更新 Live 字典 |
| 发言顺序 | 有 SpeechOrders 与其他实际记录 | 当前字段中没有 SpeechOrders |
| 重新生成 | 最新状态由完整资料与版本同步 | Turn 复用，消息不带独立生成代次 |

Broadcast 对当前 CoopSnapshot 调用原 PublicBytes 一次。SnapshotEncoder 只保存只读字节、字段位置和群成员编号；构造时扫描一次，不引用可修改的 CareerData 集合。每个接收者 Encode 按旧 PrivateSnapshot 的规则输出完整资料：公共 Life.Mailbox 为空、其他真人信箱为空、群聊仅保留属于接收者的群、PrivatePromptSnapshot 使用实际授权模板。其余已序列化字段原样复制，不另写字段清单，不重编码正文。每人结果分别交给 Split 压缩分片；Broadcast 返回后释放计划。

PrivateSnapshot 原深复制接口保留，作为完整结果对照和既有调用兼容入口。SnapshotBytes 为单次编码入口，内部创建同样的计划。

CoopAssembler.Add 按分片编号直接复制到预分配数组。大小校验、重复分片比较、哈希、解压及原有失败处理均保留，客机仍在完整验证后保存检查点。

### 个人视图的复制边界

CoopRules.View 先从 CareerData.EncodingHeader、EsportsCareer.EncodingHeader 获得两个顶层临时对象，替换原 View 已经负责替换的个人字段。只执行属性赋值；Honors 使用新筛选列表，禁止对共享集合执行 Remove、Add 或 Clear。临时对象不返回、不交给 Capture 或业务规则、不跨 await 保存。随后 CoopJson.Copy 使用原 Options 完成序列化及反序列化，形成最终独立视图；Detached、AvatarWorldId、LocalHumanId 在解码后设置。忽略字段与默认值继续由原序列化器处理。

返回视图的可变集合与房主、成员数据独立。StartPrivate、StartGroup、规则命令与界面使用最终视图，跨等待仍重新读取当前 World。事务 World 的深复制、Capture 合并、Revision、Receipts 与提交顺序保持现有流程。

CoopCareerSession.Refresh 根据共同生涯 Revision 与在线/运行/待操作签名刷新。群聊页面的内容签名使用群 Revision、状态、日期、成员封禁等，未将每条流式正文当作整个页面重建条件。流式文本另行增量更新。

重新生成同轮时，Turn 不能单独区分两次生成。现有接收还使用会话、分片序号及 queued/sending 状态。旧分片与新生成交错需要真实投递验证；静态字段检查没有证明所有交错均已覆盖。

## 保存与同步计时

UiPerformance 保存固定阶段累计次数、总量、最大值及线程分配量，统计不会逐次写磁盘。CoopJson.Copy、CoopRules.View、CoopStorage.Save、Broadcast、Encode、压缩、完整组装分别计时。Save 区分原序列化、世界文件持久写入、原版文件持久写入、哈希、清单提交与旧检查点清理。父阶段包含子阶段，禁止直接相加；诊断导出沿用 UiPerformance.Snapshot。

## 多人检查点的保存与恢复

CoopStorage.Save：

1. 为本次保存建立新检查点目录。
2. CheckpointHeader 形成带检查点编号的数据，PublicBytes 排除本机 AI 配置。
3. Durable 写 world.json、存在时写 run.bin；WriteThrough，Flush(true)。
4. 计算世界与原版对局的哈希；持久写入 current.json.tmp。
5. 替换 current.json，同时保留 previous.json；首次使用 Move。
6. 保留当前和上一份完整目录，清除更旧检查点。

Load 依次尝试 current、previous，检查目录编号、哈希、生涯与结构、原版对局配套。只恢复校验通过的一组资料。

客机收到完整快照也调用这套保存。房主的完整资料与客机的脱敏资料不是同一范围；客机不是新的房主，恢复仍由原房主主持。

## 中断和恢复的现有职责

| 情况 | 当前负责入口 | 当前处理及验证边界 |
| --- | --- | --- |
| 模型异常/超时/停止 | AI catch、命令 Cancel、RestoreInterrupted | 保存 failed 等既有状态；使用原重试入口，不新增自动重试 |
| 关闭聊天页面 | 后台 current 与绑定会话、页面有效性判断 | 生成可继续，结果保存不依赖页面控件仍在；当前任务的真实极端操作覆盖仍需单列 |
| 请求期间推进日期/俱乐部变化 | 完成后的 current、业务规则 | 读取最新日期、人物与规则；过期邀约仍提示原因 |
| 切换单人生涯 | 绑定实例、Paths、IsCurrent 等 | 数据归属按入口分别处理；公共与私信入口不能假定完全相同 |
| 游戏进程中断 | CareerStore 加载 Recover、CoopCoordinator 恢复构造 | 未完成请求恢复为既有失败状态；实时原文不是完整已提交结果 |
| 客机命令未收到回执 | CoopCoordinator.Tick / Retry / Receipts | 沿用原命令重发和去重；不重复扣款或交互 |
| 真人断线/房主退出 | CoopRuntime、CoopNativeRun、协调器关闭与 Epoch | 缺员暂停，原检查点恢复；旧会话回调失效，不增加房主迁移 |
| 检查点写入中断 | Manifest 最后替换、current / previous Load | 恢复完整配套资料；实际中断测试与写入逻辑核对分开记录 |

CoopNativeRun 的原版存储与检查点钩子属于独立链路。序列化、保存节点或广播修改必须连同原版恢复一起审阅，不能仅验证 CareerData 文本相同。
