# 游戏、日期、阵容与界面

## 原版比赛输入与模组输出

| 环节 | 输入/上游 | 负责模块 | 输出/下游 |
| --- | --- | --- | --- |
| 比赛准备 | CareerMatch、报名、当前席位、角色选择、固定种子 | CareerEngine、CircuitWorld、MatchRules、TeamPreparation、GameBridge | 原版开局参数、已准备对手结果与用时、归属绑定 |
| 单人原版开局/恢复 | 原版 RunManager 与当前保存、模组生涯/比赛绑定 | GameBridge、CareerRunBinding、MatchRecovery | 实际原版对局；属于其他生涯的对局要求完成或玩家手动放弃 |
| 多人原版开局/恢复 | CoopRun、出场名单、角色、种子、Attempt、ResumeCount、NativeSave | CoopNativeRun、NativeLobbyApi、CoopRuntime | 原版合作大厅和对局、检查点、暂停恢复 |
| 实际战斗证据 | 原版卡组、生命、牌面、金币、药水、结算记录 | GameBridge.ReadEvidence、RunEvidence、GameText | CareerResult、战报、周刊与 AI 事实 |
| 结束与失败选择 | 双方通关、失败楼层、固定对手用时、玩家用时 | CareerEngine.FinishMatch、SettlementRecord、FailureDecision、MatchRecovery；打完后按 SettlementRecords.InitialTab 自动进结算页（CareerScreen.ShowSettlement） | 正式赛果、奖励、待重赛选择、后续赛事 |
| 玩家主动代打本场 | 玩家在赛事里真打的成绩（按局内证据判定，各进阶一致）、角色卡自填胜率、界面选中角色 | CareerScreen.Matches 的“模拟本场”按钮、GameBridge.ResolveCharacter、CareerEngine.SimulateMatch、MatchRules.PlayerRun、MatchRules.PlayerRunAvailable、MatchRules.PlayerRecord；角色编辑面板玩家卡片按 MatchRules.SubstituteRate 把「历史胜率／自定义胜率」直接显示在数字框里 | 与真打完全相同的结算：CareerEngine.FinishMatch 的赛果、奖金、荣誉、战报和失败待选择；既没自填也没真打历史时锁住代打 |
| 局内转播 | 当前实际地图/房间/战斗，固定对手成绩和用时 | LiveRunBridge、LiveMaps、RivalSimulation、LiveCommentary、LiveVoices；多人 CoopLive / CoopBroadcast | 对手进度、生命、解说、弹幕、地图显示 |

开赛角色选择保留皮肤职业名称。界面名称、实际游戏职业编号、发给 AI 的原职业名称分别处理。界面优化不能更改角色资源或共享字体。

## 日期推进的实际步骤

CareerEngine.AdvanceOneDay 检查 Failure、PendingMatchId、当日或以前待打且已报名比赛。允许时 MoveToNextDay → PublishMatchDay → CareerStore.Save。

MoveToNextDay 按以下顺序执行：

1. 将已过期未报名比赛标成未报名。
2. EsportsWorld.EndDay 处理当天；WeeklyJournal.CloseWeek 捕获期刊事实。
3. Day 加一；SocialAppointments.Expire 更新过期活动。
4. 超过季末时结算赛季、增加 Season、清理较旧赛程，EsportsWorld.StartSeason 建立新赛季。
5. 单人 CareerLife.Advance；ClubOperations.Advance；OwnedClubs.Advance。
6. 发布待公开生活事实、SimulateWorld、AvatarHonors.Capture、CareerCommerce.RefreshOffers。
7. 现代赛事 CircuitWorld.AutoEntry。

AdvanceToDay 逐天执行以上过程，现有单次循环最多 84 天；遇待处理比赛、失败、待完成对局或到期活动按既有条件停下。finally 在实际推进后发布比赛日事实、压缩积压任务并保存。

跳过四周的测量案例实际只推进一天，原因是到达已确认活动；不能据该案例报告完整四周执行耗时。一天结束后的国际赛事创建与排名处理属于 EndDay / SimulateWorld 的下游，可能同时影响社区与奖励。

## 席位、历史名单和后续赛事

| 操作 | 上游规则 | 实际输出 | 下游依赖 |
| --- | --- | --- | --- |
| 签约、解约、转会 | OwnedClubs、PrivateContracts、合同与资金 | 合同、人物所属、席位、预约到队 | 阵容、工资、培训、下一赛季与赛程 |
| 交换首发 | ClubCoaching / CoachLineups、资格和席位 | 当前首发与轮换变化 | OwnedClubSchedule.UpdateLineup |
| 教练回到选手 | ClubCoaching 对应操作 | 教练岗位、轮换或首发安排按该操作规则变更 | 培养系数、未来名单、界面与合同 |
| 删除自建人物 | CharacterDeletion.Delete | 人物移入 DeletedPeople；清理有效引用与合同；合格替补补位 | 历史显示保留；未来对阵与人物池更新 |
| 旧档删除首发空位 | CharacterDeletion.RepairStarters | 限定删除造成的缺位；当前对局或失败待选择时沿原判断处理 | NormalizeRoster、UpdateLineup、未来 Fixture |
| 日常名单更新 | OwnedClubSchedule.UpdateLineup | 先 RepairStarters；未完成当前赛季团队赛事的最新 Rosters；只改同一组全未结束且未进行的对阵 | changed Fixture Id 集合传给 UpdatePlayerMatches；不重建所有玩家比赛 |
| 联赛历史短名单 | LeagueRosterRepair | 检测具体受影响联赛，保留已有有效人物并补足现有规则所需名单 | 后续团体赛事读取名单，不改已完成个人成绩 |
| 联赛衍生国际赛事 | CircuitWorld 对应生成入口 | 历史名单经当前补员分支处理后形成新赛程 | 玩家可推进、未来对手与荣誉 |
| 世界总决赛重入 | CircuitWorld 固定赛季 finalId 与生成流程 | 查找已有赛事、按当前分支生成/继续，不因异常重入无限添加同 Id 赛事 | 抽签、开赛与后续晋级 |

人物所属俱乐部、当前席位、赛事历史名单、单场 Fixture 和正式成绩是独立记录。人物已删除仍由 CareerEngine.Person 从 DeletedPeople 读取历史显示。不能把全部旧名单替换成当前阵容作为普通兼容处理。

上述是当前工作区行为。修复的验证证据仍需对照对应测试或产物，不用本章概述代替实际存档问题验证。

## 地图与转播依赖

LiveMaps.Read 以 run.Acts 为范围：

- 当前幕直接 Copy(run.Map)，读取玩家实际地图。
- 其他幕通过 StandardActMap 与原随机源预测，再复制路线。
- 单幕预测异常记录 live.map_prediction / live.independent_route，为该幕生成独立模拟路线；不关闭整套转播。

Copy 输出 RouteNode；RivalSimulation 构建/调整对手路径；Matches 检查当前实际图是否与对手路径兼容。黄金罗盘等换图经局内更新路径处理显示，固定对手结果和总用时不重新随机。

增加幕的用时仍以开赛前决定值为准。动态满足条件才追加幕时的既有完成行为沿用用户确认范围。本次地图兼容修复没有扩大到重新计算比赛总时长或设计新增幕规则。

单人与多人读取实际地图、独立路线、转播面板与最终成绩分别有入口。地图模拟失败、玩家和对手分处不同幕、同幕换图不能通过“关闭 UI”一概处理。具体函数输入输出见 LiveMaps、LiveMatch、LiveRunBridge 与 CoopLive 的索引。

## 页面、流式显示与资源

| 输入/触发 | 页面处理 | 输出及其他依赖 |
| --- | --- | --- |
| 打开生涯/切换页面 | CareerScreen.Open、Render、ViewData、各页面构造 | 单人数据或多人 Refresh 个人视图；构造控件和主题 |
| 人物名录 | ProfileScreen 的筛选与已加载范围 | 原筛选、排序、批次数量；CareerListCache 复用空卡片，重新绑定人物、头像、评分及点击回调 |
| 社区列表 | CommunityScreen 条目范围、搜索、未读 | 帖子卡片、头像、排版；阅读状态与生成状态分别保存 |
| 通讯与成员选择 | PrivateMemoryScreen、GroupChatDialogs、GroupChatScreen、PrivateListRows | 完整候选筛选；侧栏按视口复用按钮；搜索私信人物仍最多40项；成员弹窗与侧栏分别组织 |
| 流式正文变化 | PrivateMessageScreen / GroupChatScreen 的增量文本更新 | 复用发言控件、头像、查看与思考按钮；完成后显示实际卡片与变化 |
| 结构状态变化 | 群 Revision、轮次状态、日期、成员状态等签名 | 重建需要改变的记录布局；和每个字的刷新分开 |
| 清理页面 | CareerVisuals.ClearContent | 先隐藏、禁用旧控件，保留父主题至帧末 QueueFree；避免退回默认字体再次排版 |
| 字体与主题 | CareerVisuals.InterfaceFont / CreateTheme | 读取原版共享 MSDF 字体，建立模组自己的 Theme；缓存资源引用 |
| 头像 | CareerAvatars、AvatarImages、AvatarSources、PlayerAvatar 等 | 读取皮肤/人物图、框和缩略图；由相关资源缓存维护 |

当前字体实现按游戏共享中文字体资源建立模组主题，资源缺失时建立模组自己的系统字体；不会修改读取到的原版共享 Font 属性。实际源码并非“所有控件一律改成 MegaLabel”，不能用此前建议代替当前实现说明。

缓存分类必须写清楚：不可变资源引用、单次检索结果、当前页面控件、可变生涯视图、网络快照各有不同生命周期。主题和字体共享资源不能原地修改；多人可变视图不能跨操作版本复用；页面缓存需要说明日期、阵容、帖子、身份和存档切换时如何更新。

## 世界俱乐部名录的玩家岗位与点击身份

CareerWorldScreen.ClubDirectory 接收当前 CareerData，按现有俱乐部排序及 _clubLimit 创建名录。只有 data.Esports.ClubId 等于正在显示的俱乐部编号时，才创建本地玩家条目。

岗位文字调用 CircuitScreen.ClubRole(data, club.Id, GroupChats.Human(data))。GroupChats.Human 读取 LocalHumanId；为空时返回单人身份 player。多人个人视图由 CoopRules.View 提供本地成员身份，因此房主和客机分别查询自己的席位。这个调用只读取数据，不保存、不广播、不修改合同、阵容、赛程或版本。

ClubRole 沿用 NPC 的同一入口：自建俱乐部调用 OwnedClubs.Position，依次检查首发、轮换、教练，其他情况显示青训；普通俱乐部检查当前赛季 league 的俱乐部名单，名单内显示本季首发，否则显示轮换选手。兼任教练仍按这个既有顺序显示选手席位。退出首发申请尚未执行时，显示当前席位；新赛季执行后显示新的席位。没有新增字段或旧档迁移。

岗位查询的成员编号与界面点击编号分别使用：PersonLink 的 id 仍为 player，姓名仍由 CareerEngine.Name 提供。PersonLink 创建的头像和姓名按钮沿用 OpenPerson(player)，进入当前本地玩家档案；不将多人成员编号交给原来以 player 表示自己的档案入口。刷新页面时重新读取当前个人视图，没有新增缓存或失效规则。

验证：生产程序集通过66项检查，覆盖单人创建、退出首发申请及取消、新赛季轮换、多人成员出场切换、个人视图和 JSON 重新读取；每组查询前后数据摘要相同，新增保存次数为0。真实 Godot、游戏资源及生产界面源码通过85项检查，包含实际鼠标点击姓名与头像后进入当前玩家档案。界面测试使用既有存储与游戏接入替身，多人身份由测试视图提供，没有执行真实 Steam 联机。

性能边界：只计时岗位查询或页面同步构建，不含后续帧布局、动画、网络及模型。生产岗位查询首次3.19毫秒，后续最大0.11毫秒；小名单页面构建10.47—33.51毫秒；1596人物、49俱乐部档案默认显示8家，首次272.70毫秒、再次78.23毫秒。没有新增数据复制、保存或同步步骤。

## 控件缓存的归属与更新

MainMenuEntries.Bind 调用 CareerListCache.For，缓存是当前主菜单的隐藏子节点。主菜单空闲且没有单人/多人生涯界面时，_Process 每帧准备少量字体字形或一个空人物卡片，默认准备36张；不访问 CareerStore、不加载生涯、不保存、不修改 Font。完成后停止处理。

CareerScreen.OpenView 获取同一缓存。Render、Close、ExitTree 将卡片隐藏并归还，先清空 Open 回调。AddProfileCards 对当前筛选结果重新绑定所有字段、头像身份、人物编号和点击回调。增加显示数量时按需补充空卡片；不缓存人物选择结果。主菜单销毁时一并销毁缓存。

PrivateListRows 只复用当前通讯弹窗内的侧栏按钮。RefreshPrivateList 保留完整排序、筛选编号列表；ShowPrivateListRows 按滚动位置、视口高度重绑按钮，前后保留少量条目。点击读取当前 Id/Group，关闭弹窗后清空列表。私信正文未增加持久气泡缓存，仍使用既有流式增量更新。

CareerVisuals.CreateTheme 缓存模组主题，InterfaceFont 仍引用原版字体且不修改资源参数。Card 在加入场景前指定同一主题，避免临时使用引擎默认字体。字体、颜色、大小、点击入口和选择范围按原实现保留。

## 反射和原版补丁的核对方式

游戏补丁由 LiveCompatibility.Install 按实际接口安装；GameCompatibility、RuntimeApi、NativeLobbyApi 用反射处理游戏差异。静态索引只能列出代码查找方法与 Invoke，无法确定每个玩家的其他模组补丁链。

修改这些入口时，文档要列出目标类型与方法、签名选择、补丁前后读取内容、失配现有处理、单人/多人/原版普通流程边界，以及实际游戏验证范围。只检查本机游戏成员存在，不等于完整跨版本或其他模组组合验证。
