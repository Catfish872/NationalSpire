# ExpandedPeople.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1B6A99184C032F9A385FF59EB1659E3C3BCCFA2ADE7D8E83EDB890FBD9F4F60E`。来源：[源码](../../ExpandedPeople.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.WorldPeople`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, string[]> RoleBios = new();
```

<a id="symbol-e0e51594f12d"></a>

## `NationalSpire.WorldPeople.WorldPeople() — static WorldPeople()`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.ContentPools.Append(System.Collections.Generic.Dictionary<string, string[]>, string)`](ContentPools.cs.md#symbol-0a02f29bf822)；[`NationalSpire.ContentPools.Words(string)`](ContentPools.cs.md#symbol-5d478310fd36)；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ContentPools.Append(System.Collections.Generic.Dictionary<string, string[]>, string)`；`NationalSpire.ContentPools.Words(string)`；`NationalSpire.HumanNames.AdditionalFamilies`；`NationalSpire.HumanNames.CommonFamilies`；`NationalSpire.NamePools.CrowdEnds`；`NationalSpire.NamePools.CrowdStarts`；`NationalSpire.WorldPeople.FamilyNames`；`NationalSpire.WorldPeople.FanBios`；`NationalSpire.WorldPeople.GivenNames`；`NationalSpire.WorldPeople.NickEnds`；`NationalSpire.WorldPeople.NickStarts`；`NationalSpire.WorldPeople.ProBios`；`NationalSpire.WorldPeople.RoleBios`；`NationalSpire.WorldPeople.Styles`；`NationalSpire.WorldPeople.YouthBios`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ContentPools.Append(System.Collections.Generic.Dictionary<string, string[]>, string)`；输入表达式：`ContentPools.Append(RoleBios, """  职业选手=赛前会整理自己熟悉的种子记录，临场仍在努力适应意外奖励。|经常在训练室最后一个离开，喜欢把当天最难的选择留到晚上琢磨。|偏爱和固定队友复盘，遇到分歧会各自重打一遍再讨论。|把训练安排写在纸质日历上，比赛日会提前很久到场。|常把旧战报翻出来对照，想知道最近的进步究竟在哪里。|比赛前习惯关掉社区通知，结束以后再一条条补看。|话不算多，聊到熟悉的角色和遗物时却会讲很久。|会带着同一只杯子参加训练，说是方便记得喝水。|常陪青训打练习局，对自己擅长的组合很有耐心。|喜欢用失败的对局做笔记，成功的牌组则单独收藏。|面对陌生种子会放慢前几层，先找熟悉的构筑方向。|常在比赛前散步，回训练室以后才正式打开战报。|会主动问队友最近练了什么，碰上有趣的构筑会留下来试。|训练中容易和人争论选牌，复盘后又愿意承认看错。|更喜欢小范围聊打法，公开采访里通常先谈团队。|把出场机会看得很重，替补时也会完整看完队友的比赛。  青训选手=随身带着一本选牌笔记，空白处常写着还没想明白的问题。|训练结束后喜欢留下一局，试试当天被教练指出的选择。|会把喜欢的职业选手加入观赛提醒，努力记住对方的升级顺序。|刚开始接触正式训练，遇到好成绩会藏不住高兴。|与同组伙伴轮流提供练习种子，赛后常一起讨论最难的房间。|容易在奖励面前犹豫，正在训练中练习更快做决定。|喜欢把失败截屏存起来，希望下次能少犯同样的错误。|第一次穿队服时拍了很多照片，现在仍认真准备每次试训。|会把每周最满意的训练记录单独保存，低谷时拿出来提醒自己。|对职业赛场充满期待，日常训练偶尔会给自己加练。|还在寻找最合适的角色，会向不同队友请教打法。|常把观赛心得写成长段文字，实战中仍需要慢慢消化。  普通玩家=晚饭以后才有空开一局，常在睡前补看当天的赛果。|每到比赛日就和朋友一起守社区，自己打牌时倒很随意。|喜欢收集好看的卡图，偶尔因为舍不得跳过奖励把牌组越拿越厚。|通勤路上刷赛区动态，下班回家再试试看来的构筑。|把观赛当作日常消遣，最熟悉的是本地队伍的那些名字。|自己经常开局很有信心，打到一半又开始找攻略。|习惯边听音乐边爬塔，正式比赛时反而会安静看完。|周末和朋友互换失败种子，讨论时比自己操作还认真。|对稀有卡总抱着期待，抽不到时也会在社区自嘲几句。|经常看比赛看到忘记时间，自己的游戏进度却不紧不慢。|喜欢记住社区里有趣的发言，遇到熟面孔会顺口接话。|偶尔参加本地活动，更多时候在观众席给熟人加油。|一开始只是陪朋友看比赛，后来也逐渐认全了主队阵容。|自己的牌组收藏夹比通关记录丰富，闲时总想换一种玩法。|喜欢聊选手日常，战术讨论听不懂时会直接问。|常在深夜逛社区，遇到热闹话题就留几句评论。  主播=直播时会把犹豫的选项念出来，也常和弹幕一起选错。|喜欢边打边讲自己的想法，失误以后会把录像留给观众吐槽。|直播间熟人不少，比赛日会带大家一起看本地队伍。|平时播挑战局，观众更爱看其临场改主意的样子。|常把失败片段剪成短视频，胜利时反而会安静复盘一会儿。|说话节奏快，认真做选择时又会突然沉默。|喜欢邀请朋友连麦讨论，遇到陌生机制就现场查资料。|把观众提供的种子列成清单，逐个尝试并记录结果。|会在赛后聊很久，常从比赛说到自己的练习失误。|节目安排随心，碰上关注选手的比赛就临时改成观赛。|直播时常开玩笑，但对认真求助的观众很有耐心。|以陪伴式直播为主，熟悉不少社区常客的昵称。|喜欢做角色主题挑战，遇到过不去的关口会反复研究。|胜负心藏不住，失败后先自嘲几句再开下一局。|经常整理观众的问题，隔一阵就做一次回顾。|对冷门牌很有兴趣，试验失败也愿意公开展示。  退役选手=退役后仍保留比赛笔记，看到新选手会想起自己初次上场的时候。|如今更常坐在观众席，碰上熟悉对手仍会认真看完。|偶尔在社区分享旧赛季的经历，谈起失误时比当年坦然。|离开正式阵容后有了更多观赛时间，也开始接触不熟悉的角色。|常受邀参加赛后讨论，对年轻选手的紧张很有体会。|仍会和老队友约练习局，胜负心偶尔还像职业时期一样强。|退役后开始整理旧录像，希望把值得记住的比赛留下来。|对赛场气氛很熟悉，谈到自己当年的关键选择仍会停下来想。|偶尔参加社区活动，更多时候给熟识的后辈加油。|保持着固定练习习惯，但已经能接受自己状态的起伏。|在公开讨论中常补充选手视角，也愿意听新一代的想法。|离开赛场后尝试解说，遇到熟悉局面仍会忍不住替选手着急。|把过去的队服和赛事证件收在一起，偶尔会拍照分享。|更愿意聊比赛过程里的犹豫，而非单纯重复最终结果。|仍关注原俱乐部，对新人进入阵容很有兴趣。|如今有时间陪朋友慢慢打，偶尔也会认真复刻旧牌组。  教练=训练结束会逐个询问选手最难做的选择，再安排下一次练习。|喜欢用具体战报展开讨论，对泛泛而谈的复盘耐心不多。|赛前把重点写得很短，希望选手上场后还记得住。|关注队员近期状态，安排训练时会留出独自整理的时间。|擅长组织队内讨论，也会承认自己有没看懂的打法。|经常陪青训看职业战报，先问他们想选什么再谈意见。|会把同一种子的不同结果放在一起，让队员自己找差别。|更愿意让选手解释想法，训练中常留下一串待讨论的问题。|喜欢整理角色专项练习，对稳定发挥尤其上心。|负责轮换和训练安排，比赛日通常比选手更早到场。|会在失败后先整理事实，再和选手逐步讨论。|重视队内交流，尝试让经验不同的成员一起复盘。|对路线选择准备得细，碰上陌生奖励也会谨慎评估。|常跟踪其他赛区的公开战报，筛选适合队伍尝试的思路。|对队员的惯用构筑很熟，训练时会安排一些变化。|愿意花时间听年轻选手说明失误，希望找出能练习的部分。  赛事记者=习惯在采访前翻完近期战报，提问时更在意选手自己的感受。|长期记录本地联赛，对阵容变动和青训故事尤其熟悉。|喜欢从赛场之外寻找细节，采访稿常带着日常生活的气息。|会把不同赛季的公告保存在一起，方便核对时间顺序。|报道比赛时注重事实，人物栏目里更愿意写选手的犹豫和习惯。|经常在赛后等待选手缓过情绪，再开始提问。|关注小型赛事，想记录那些还没被大多数人认识的名字。|喜欢回访采访过的新人，看看几周之后有什么变化。|对本地俱乐部很熟，但遇到没有确认的消息仍会继续求证。|写稿前习惯整理一条时间线，避免把训练和正式比赛混在一起。|常在社区收集观众好奇的问题，再带到采访中。|会为值得纪念的比赛保留长篇笔记，平时报道则力求简明。|擅长记住选手公开说过的小目标，赛后会询问进展。|对退役选手的近况感兴趣，常做离开赛场后的回访。|喜欢从一场比赛的具体选择聊到选手平时的训练。|比赛日忙着整理赛果，休赛时才有空慢慢写人物稿。  解说员=看比赛时喜欢先报清现场变化，精彩回合会忍不住提高音量。|会提前翻阅对阵双方的战报，现场更重视观众能直接看到的转折。|偏爱关注选手犹豫的瞬间，也会坦然承认自己猜错了。|搭档说快时会补充关键数字，比赛紧张时自己也容易坐不住。|喜欢用自己的爬塔失误调节气氛，关键时刻又会认真盯住手牌。|对本地赛区很熟，遇到新名字会提前做些功课。|看到漂亮防守比大伤害还高兴，赛后常回看那几个回合。|解说时习惯把前后几场表现连起来看，尽量给变化留位置。|会在赛前记住双方惯用角色，临场遇到意外选择就格外有兴趣。|关注比赛节奏，看到追赶和反超时情绪尤其明显。|喜欢和搭档交换第一反应，有时也会互相纠正判断。|面对僵持会放慢语速，突然出现转折时又很难掩住兴奋。|解说之外也常看社区赛，对普通玩家遇到的困难很有体会。|重视把已发生的事情说清楚，精彩之处会留给观众一起反应。|常把赛后想补充的话写进笔记，下一次转播前再翻一遍。|对药水和路线取舍有兴趣，自己练习时也常在这些地方纠结。  """)`；返回值紧邻使用处：`ExpressionStatementSyntax: ContentPools.Append(RoleBios, """  职业选手=赛前会整理自己熟悉的种子记录，临场仍在努力适应意外奖励。|经常在训练室最后一个离开，喜欢把当天最难的选择留到晚上琢磨。|偏爱和固定队友复盘，遇到分歧会各自重打一遍再讨论。|把训练安排写在纸质日历上，比赛日会提前很久到场。|常把旧战报翻出来对照，想知道最近的进步究竟在哪里。|比赛前习惯关掉社区通知，结束以后再一条条补看。|话不算多，聊到熟悉的角色和遗物时却会讲很久。|会带着同一只杯子参加训练，说是方便记得喝水。|常陪青训打练习局，对自己擅长的组合很有耐心。|喜欢用失败的对局做笔记，成功的牌组则单独收藏。|面对陌生种子会放慢前几层，先找熟悉的构筑方向。|常在比赛前散步，回训练室以后才正式打开战报。|会主动问队友最近练了什么，碰上有趣的构筑会留下来试。|训练中容易和人争论选牌，复盘后又愿意承认看错。|更喜欢小范围聊打法，公开采访里通常先谈团队。|把出场机会看得很重，替补时也会完整看完队友的比赛。  青训选手=随身带着一本选牌笔记，空白处常写着还没想明白的问题。|训练结束后喜欢留下一局，试试当天被教练指出的选择。|会把喜欢的职业选手加入观赛提醒，努力记住对方的升级顺序。|刚开始接触正式训练，遇到好成绩会藏不住高兴。|与同组伙伴轮流提供练习种子，赛后常一起讨论最难的房间。|容易在奖励面前犹豫，正在训练中练习更快做决定。|喜欢把失败截屏存起来，希望下次能少犯同样的错误。|第一次穿队服时拍了很多照片，现在仍认真准备每次试训。|会把每周最满意的训练记录单独保存，低谷时拿出来提醒自己。|对职业赛场充满期待，日常训练偶尔会给自己加练。|还在寻找最合适的角色，会向不同队友请教打法。|常把观赛心得写成长段文字，实战中仍需要慢慢消化。  普通玩家=晚饭以后才有空开一局，常在睡前补看当天的赛果。|每到比赛日就和朋友一起守社区，自己打牌时倒很随意。|喜欢收集好看的卡图，偶尔因为舍不得跳过奖励把牌组越拿越厚。|通勤路上刷赛区动态，下班回家再试试看来的构筑。|把观赛当作日常消遣，最熟悉的是本地队伍的那些名字。|自己经常开局很有信心，打到一半又开始找攻略。|习惯边听音乐边爬塔，正式比赛时反而会安静看完。|周末和朋友互换失败种子，讨论时比自己操作还认真。|对稀有卡总抱着期待，抽不到时也会在社区自嘲几句。|经常看比赛看到忘记时间，自己的游戏进度却不紧不慢。|喜欢记住社区里有趣的发言，遇到熟面孔会顺口接话。|偶尔参加本地活动，更多时候在观众席给熟人加油。|一开始只是陪朋友看比赛，后来也逐渐认全了主队阵容。|自己的牌组收藏夹比通关记录丰富，闲时总想换一种玩法。|喜欢聊选手日常，战术讨论听不懂时会直接问。|常在深夜逛社区，遇到热闹话题就留几句评论。  主播=直播时会把犹豫的选项念出来，也常和弹幕一起选错。|喜欢边打边讲自己的想法，失误以后会把录像留给观众吐槽。|直播间熟人不少，比赛日会带大家一起看本地队伍。|平时播挑战局，观众更爱看其临场改主意的样子。|常把失败片段剪成短视频，胜利时反而会安静复盘一会儿。|说话节奏快，认真做选择时又会突然沉默。|喜欢邀请朋友连麦讨论，遇到陌生机制就现场查资料。|把观众提供的种子列成清单，逐个尝试并记录结果。|会在赛后聊很久，常从比赛说到自己的练习失误。|节目安排随心，碰上关注选手的比赛就临时改成观赛。|直播时常开玩笑，但对认真求助的观众很有耐心。|以陪伴式直播为主，熟悉不少社区常客的昵称。|喜欢做角色主题挑战，遇到过不去的关口会反复研究。|胜负心藏不住，失败后先自嘲几句再开下一局。|经常整理观众的问题，隔一阵就做一次回顾。|对冷门牌很有兴趣，试验失败也愿意公开展示。  退役选手=退役后仍保留比赛笔记，看到新选手会想起自己初次上场的时候。|如今更常坐在观众席，碰上熟悉对手仍会认真看完。|偶尔在社区分享旧赛季的经历，谈起失误时比当年坦然。|离开正式阵容后有了更多观赛时间，也开始接触不熟悉的角色。|常受邀参加赛后讨论，对年轻选手的紧张很有体会。|仍会和老队友约练习局，胜负心偶尔还像职业时期一样强。|退役后开始整理旧录像，希望把值得记住的比赛留下来。|对赛场气氛很熟悉，谈到自己当年的关键选择仍会停下来想。|偶尔参加社区活动，更多时候给熟识的后辈加油。|保持着固定练习习惯，但已经能接受自己状态的起伏。|在公开讨论中常补充选手视角，也愿意听新一代的想法。|离开赛场后尝试解说，遇到熟悉局面仍会忍不住替选手着急。|把过去的队服和赛事证件收在一起，偶尔会拍照分享。|更愿意聊比赛过程里的犹豫，而非单纯重复最终结果。|仍关注原俱乐部，对新人进入阵容很有兴趣。|如今有时间陪朋友慢慢打，偶尔也会认真复刻旧牌组。  教练=训练结束会逐个询问选手最难做的选择，再安排下一次练习。|喜欢用具体战报展开讨论，对泛泛而谈的复盘耐心不多。|赛前把重点写得很短，希望选手上场后还记得住。|关注队员近期状态，安排训练时会留出独自整理的时间。|擅长组织队内讨论，也会承认自己有没看懂的打法。|经常陪青训看职业战报，先问他们想选什么再谈意见。|会把同一种子的不同结果放在一起，让队员自己找差别。|更愿意让选手解释想法，训练中常留下一串待讨论的问题。|喜欢整理角色专项练习，对稳定发挥尤其上心。|负责轮换和训练安排，比赛日通常比选手更早到场。|会在失败后先整理事实，再和选手逐步讨论。|重视队内交流，尝试让经验不同的成员一起复盘。|对路线选择准备得细，碰上陌生奖励也会谨慎评估。|常跟踪其他赛区的公开战报，筛选适合队伍尝试的思路。|对队员的惯用构筑很熟，训练时会安排一些变化。|愿意花时间听年轻选手说明失误，希望找出能练习的部分。  赛事记者=习惯在采访前翻完近期战报，提问时更在意选手自己的感受。|长期记录本地联赛，对阵容变动和青训故事尤其熟悉。|喜欢从赛场之外寻找细节，采访稿常带着日常生活的气息。|会把不同赛季的公告保存在一起，方便核对时间顺序。|报道比赛时注重事实，人物栏目里更愿意写选手的犹豫和习惯。|经常在赛后等待选手缓过情绪，再开始提问。|关注小型赛事，想记录那些还没被大多数人认识的名字。|喜欢回访采访过的新人，看看几周之后有什么变化。|对本地俱乐部很熟，但遇到没有确认的消息仍会继续求证。|写稿前习惯整理一条时间线，避免把训练和正式比赛混在一起。|常在社区收集观众好奇的问题，再带到采访中。|会为值得纪念的比赛保留长篇笔记，平时报道则力求简明。|擅长记住选手公开说过的小目标，赛后会询问进展。|对退役选手的近况感兴趣，常做离开赛场后的回访。|喜欢从一场比赛的具体选择聊到选手平时的训练。|比赛日忙着整理赛果，休赛时才有空慢慢写人物稿。  解说员=看比赛时喜欢先报清现场变化，精彩回合会忍不住提高音量。|会提前翻阅对阵双方的战报，现场更重视观众能直接看到的转折。|偏爱关注选手犹豫的瞬间，也会坦然承认自己猜错了。|搭档说快时会补充关键数字，比赛紧张时自己也容易坐不住。|喜欢用自己的爬塔失误调节气氛，关键时刻又会认真盯住手牌。|对本地赛区很熟，遇到新名字会提前做些功课。|看到漂亮防守比大伤害还高兴，赛后常回看那几个回合。|解说时习惯把前后几场表现连起来看，尽量给变化留位置。|会在赛前记住双方惯用角色，临场遇到意外选择就格外有兴趣。|关注比赛节奏，看到追赶和反超时情绪尤其明显。|喜欢和搭档交换第一反应，有时也会互相纠正判断。|面对僵持会放慢语速，突然出现转折时又很难掩住兴奋。|解说之外也常看社区赛，对普通玩家遇到的困难很有体会。|重视把已发生的事情说清楚，精彩之处会留给观众一起反应。|常把赛后想补充的话写进笔记，下一次转播前再翻一遍。|对药水和路线取舍有兴趣，自己练习时也常在这些地方纠结。  """);`
- `NationalSpire.ContentPools.Words(string)`；输入表达式：`ContentPools.Words(familyAdd[i])`；返回值紧邻使用处：`ArgumentSyntax: ContentPools.Words(familyAdd[i])`
- `NationalSpire.ContentPools.Words(string)`；输入表达式：`ContentPools.Words(givenAdd[i])`；返回值紧邻使用处：`ArgumentSyntax: ContentPools.Words(givenAdd[i])`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`styleAdd[i].Split('|')`；返回值紧邻使用处：`ArgumentSyntax: styleAdd[i].Split('|')`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`FamilyNames[i].Concat(ContentPools.Words(familyAdd[i]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FamilyNames[i].Concat(ContentPools.Words(familyAdd[i])).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i]).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`FanBios.Concat(RoleBios["普通玩家"])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FanBios.Concat(RoleBios["普通玩家"]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`GivenNames[i].Concat(ContentPools.Words(givenAdd[i]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GivenNames[i].Concat(ContentPools.Words(givenAdd[i])).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`NickEnds.Concat(NamePools.CrowdEnds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NickEnds.Concat(NamePools.CrowdEnds).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`NickStarts.Concat(NamePools.CrowdStarts)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NickStarts.Concat(NamePools.CrowdStarts).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`ProBios.Concat(RoleBios["职业选手"])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProBios.Concat(RoleBios["职业选手"]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Styles[i].Concat(styleAdd[i].Split('|'))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Styles[i].Concat(styleAdd[i].Split('|')).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`YouthBios.Concat(RoleBios["青训选手"])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: YouthBios.Concat(RoleBios["青训选手"]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`FamilyNames[i].Concat(ContentPools.Words(familyAdd[i])).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FamilyNames[i].Concat(ContentPools.Words(familyAdd[i])).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i]).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i]).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`GivenNames[i].Concat(ContentPools.Words(givenAdd[i])).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GivenNames[i].Concat(ContentPools.Words(givenAdd[i])).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`NickEnds.Concat(NamePools.CrowdEnds).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NickEnds.Concat(NamePools.CrowdEnds).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`NickStarts.Concat(NamePools.CrowdStarts).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NickStarts.Concat(NamePools.CrowdStarts).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`FamilyNames[i].Concat(ContentPools.Words(familyAdd[i])).Distinct().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: FamilyNames[i] = FamilyNames[i].Concat(ContentPools.Words(familyAdd[i])).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i]).Distinct().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: FamilyNames[i] = FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i]).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`FanBios.Concat(RoleBios["普通玩家"]).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: FanBios = FanBios.Concat(RoleBios["普通玩家"]).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`GivenNames[i].Concat(ContentPools.Words(givenAdd[i])).Distinct().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: GivenNames[i] = GivenNames[i].Concat(ContentPools.Words(givenAdd[i])).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`NickEnds.Concat(NamePools.CrowdEnds).Distinct().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: NickEnds = NickEnds.Concat(NamePools.CrowdEnds).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`NickStarts.Concat(NamePools.CrowdStarts).Distinct().ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: NickStarts = NickStarts.Concat(NamePools.CrowdStarts).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`ProBios.Concat(RoleBios["职业选手"]).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ProBios = ProBios.Concat(RoleBios["职业选手"]).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Styles[i].Concat(styleAdd[i].Split('|')).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Styles[i] = Styles[i].Concat(styleAdd[i].Split('|')).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`YouthBios.Concat(RoleBios["青训选手"]).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: YouthBios = YouthBios.Concat(RoleBios["青训选手"]).ToArray()`

**赋值（含属性/字段和局部值）：**

- `FamilyNames[i]` = `FamilyNames[i].Concat(ContentPools.Words(familyAdd[i])).Distinct().ToArray()`
- `FamilyNames[i]` = `FamilyNames[i].Concat(HumanNames.AdditionalFamilies[i]).Concat(HumanNames.CommonFamilies[i]).Distinct().ToArray()`
- `FanBios` = `FanBios.Concat(RoleBios["普通玩家"]).ToArray()`
- `GivenNames[i]` = `GivenNames[i].Concat(ContentPools.Words(givenAdd[i])).Distinct().ToArray()`
- `NickEnds` = `NickEnds.Concat(NamePools.CrowdEnds).Distinct().ToArray()`
- `NickStarts` = `NickStarts.Concat(NamePools.CrowdStarts).Distinct().ToArray()`
- `ProBios` = `ProBios.Concat(RoleBios["职业选手"]).ToArray()`
- `Styles[i]` = `Styles[i].Concat(styleAdd[i].Split('|')).ToArray()`
- `YouthBios` = `YouthBios.Concat(RoleBios["青训选手"]).ToArray()`

<a id="symbol-ffc4ca6e2307"></a>

## `NationalSpire.WorldPeople.Biography(string, int) — public static string Biography(string role, int seed)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.Add(NationalSpire.CareerData, string, string, string, string, int)`](CircuitPeople.cs.md#symbol-1bc89c911651)；[`NationalSpire.ContentPoolMigration.Refresh(NationalSpire.CareerData)`](ContentPoolMigration.cs.md#symbol-fb1d019899b2)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.WorldPeople.FanBios`；`NationalSpire.WorldPeople.ProBios`；`NationalSpire.WorldPeople.RoleBios`；`NationalSpire.WorldPeople.YouthBios`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`RoleBios.GetValueOrDefault(role, FanBios)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => RoleBios.GetValueOrDefault(role, FanBios)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d239e2d11a5b"></a>

## `NationalSpire.WorldPeople.PlayingStyle(int, int) — public static string PlayingStyle(int character, int seed)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.Add(NationalSpire.CareerData, string, string, string, string, int)`](CircuitPeople.cs.md#symbol-1bc89c911651)；[`NationalSpire.ContentPoolMigration.Refresh(NationalSpire.CareerData)`](ContentPoolMigration.cs.md#symbol-fb1d019899b2)；[`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-3dba497c8606)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.WorldPeople.Styles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
