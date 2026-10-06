namespace NationalSpire;

internal static class NamePools
{
    internal static readonly string[] CrowdStarts = ContentPools.Words("桥洞下的 广场上的 烘焙坊的 车窗边的 电梯里的 河堤上的 屋檐下的 校门口的 阳台上的 球场边的 画室里的 茶馆里的 音乐教室的 码头边的 走廊尽头的 公园里的 山路上的 露营地的 地铁口的 机场里的 温室里的 灯下的 海岬上的 剧院里的 放映厅的 书报亭的 修车铺的 水族馆的 博物馆的 花店里的 旧车站的 新街口的 早班 清晨 黄昏 雨后 入冬 盛夏 初春 深秋 假日 课间 下班后 半夜三点 周二中午 周日清早 周六晚饭前 傍晚六点 开学第一天 考完试的 刚睡醒的 吃饱了的 快迟到的 忘带伞的 找座位的 等外卖的 晒太阳的 看落日的 听广播的 发呆中的 走错路的 慢慢来的 写完作业的 刚下地铁的 戴围巾的 穿拖鞋的 背着相机的 拎着饭盒的 抱着枕头的 忘了关灯的 还没刷牙的 躲雨中的 放空中的 准备午睡的 买错车票的 找遥控器的 想吃夜宵的 在等周五的 没抢到票的 跟着导航的 排队买面包的 不加辣的 少冰半糖的 多加一份的 最后一排的 第二扇窗的 靠近出口的 沿着海岸的 顺着风的 隔着玻璃的 转角遇见的 倒数第二个 不小心路过的 准点下班的 跟猫商量的 把茶放凉的 忘记充电的 趁热吃饭的 躺平五分钟的 暂时离线的 空闲中的 藏在被窝的 停在半路的 独自散步的 等一场雪的 不急着走的 刚买菜的 刚泡好茶的 抄近路的 一脸困意的 带错课本的 回头张望的 看云识天气的 拐错弯的 收完衣服的 揣着零钱的 坐过站的 散场以后的 沿街溜达的 周三的 午休的 最晚到场的 后门溜进来的");
    internal static readonly string[] CrowdEnds = ContentPools.Words("花生 米糕 麻薯 团子 烤栗子 小馄饨 汤圆 豆花 烧饼 蛋挞 奶黄包 芝麻糊 红豆汤 冰棍 山楂片 小麻花 饭团 鸡蛋仔 糯米团 栗子糕 铜锣烧 鲷鱼烧 豆乳 蛋包饭 苹果派 可颂 贝果 松饼 玛芬 曲奇 吐司 卷饼 酸奶 鲜橙汁 冰美式 桃子 枇杷 荔枝 山竹 小番茄 百香果 花椰菜 胡萝卜 土豆泥 西兰花 玉米粒 甜豌豆 南瓜子 小海豹 水獭 羊驼 熊猫 刺猬 乌龟 鸭嘴兽 小浣熊 穿山甲 考拉 斑鸠 灰雁 鹦鹉 雨燕 黑天鹅 猫头鹰 小狐狸 橘猫 三花 布偶猫 小柯基 哈士奇 秋田犬 萨摩耶 金毛 法斗 小杜宾 暹罗猫 三明治 饭勺 锅铲 保温杯 笔筒 订书机 卷尺 橡皮擦 回形针 胶带 便利贴 钥匙扣 旧磁带 胶片 相框 万花筒 留声机 八音盒 口琴 手风琴 小鼓 风向标 指南针 日历 时钟 扑克 骰子 弹珠 毽子 陀螺 积木 拼图 飞盘 网球 篮球 羽毛球 小木船 潜水艇 宇航员 灯泡 电池 插头 网线 键帽 软盘 存储卡 计算器 路由器 半张草稿 备用雨伞 空信封 印章 手账 铅笔 橡皮鸭 温度计 小闹钟 鞋带 纽扣 线团 手套 口罩 围巾 旧毛衣 羊毛袜 帽檐 双肩包 帆布袋 行李牌 月票 车票 邮票 雪花球 玻璃珠 水晶石 鹅卵石 银杏叶 四叶草 蒲公英 松果 榛子 橡果 樱桃核 桂花枝 芦苇 紫藤 小雏菊 铃兰 金盏花 向日葵 花盆 喷壶 洒水壶 蚊香盘 纸灯笼 小竹篮 草帽 折叠椅 野餐垫 沙漏 猫抓板 藤编筐 茶叶罐 旧唱针 随身听 小夜灯 薄荷糖 牛轧糖 黑巧克力 橘子皮 罐装汽水 饼干屑 碎冰 方糖");
    // 地区意象分别组合，每个组件可以自然修饰本组实物；整词昵称提供另一种结构。
    private static readonly Dictionary<string, string> Places = new()
    {
        ["中国"] = "江南 北平 长安 洛阳 金陵 苏州 扬州 成都 泉州 大理 河西 南山 东篱 西窗 北巷 茶山 竹林 古渡 荷塘 石桥 雨巷 溪边 城南 山脚 林间 巷口 湖心 江畔 西岭 南浦 东山 云端 海角 岭南 松间 梅园 雁荡 衡山 渔港 雪乡",
        ["日本"] = "镰仓 京都 浅草 奈良 神户 札幌 箱根 宇治 小樽 横滨 高尾 富士山下 伊豆 江之岛 仙台 金泽 秋叶原 函馆 盛冈 长崎 名古屋 吉野 神社前 山手线 河口湖 屋久岛 飞驒 信州 出云 四国 北陆 九州 东海道 隅田川 多摩川 琵琶湖",
        ["韩国"] = "汉江 釜山 济州 首尔 江陵 仁川 全州 大邱 水原 光州 大田 浦项 蔚山 春川 庆州 丽水 木浦 南山 弘大 明洞 城北 圣水洞 梨泰院 东大门 海云台 广安里 西归浦 北村 雪岳山 南怡岛 竹绿苑 龙山 汝矣岛 汉城旧街 月尾岛 松岛",
        ["德国"] = "柏林 汉堡 不来梅 科隆 波恩 莱茵河 多瑙河 黑森林 巴伐利亚 慕尼黑 德累斯顿 莱比锡 海德堡 吕贝克 亚琛 波茨坦 纽伦堡 杜塞尔多夫 霍恩湖 波罗的海 鲁尔区 莱茵兰 勃兰登堡 巴登 萨克森 图林根 阿尔卑斯山下 康斯坦茨 奥格斯堡 梅森 耶拿 雷根斯堡 威玛 乌尔姆 特里尔 林道",
        ["法国"] = "巴黎 里昂 尼斯 马赛 波尔多 图卢兹 南特 里尔 第戎 鲁昂 阿维尼翁 蒙彼利埃 塞纳河 卢瓦尔河 诺曼底 布列塔尼 普罗旺斯 阿尔萨斯 香槟区 勃艮第 蒙马特 左岸 巴士底 拉丁区 圣马洛 翁弗勒尔 昂热 科尔马 安纳西 阿尔勒 枫丹白露 凡尔赛 卡昂 雷恩 格勒诺布尔 阿维龙",
        ["巴西"] = "里约 圣保罗 巴伊亚 累西腓 萨尔瓦多 马瑙斯 库里蒂巴 福塔莱萨 贝伦 桑托斯 纳塔尔 奥林达 巴西利亚 潘塔纳尔 亚马孙河 伊帕内玛 科帕卡巴纳 博塔弗戈 乌巴图巴 维多利亚 卡诺阿 塞拉多 南里奥格兰德 米纳斯 巴拉那 圣卡塔琳娜 伊瓜苏 帕拉蒂 诺罗尼亚 博尼图 若昂佩索阿 佩洛塔斯 伊塔卡雷 马拉若 塔帕若斯 阿拉卡茹",
        ["英国"] = "伦敦 约克 巴斯 布莱顿 布里斯托 爱丁堡 格拉斯哥 牛津 剑桥 利物浦 曼彻斯特 诺丁汉 德文 康沃尔 多塞特 湖区 高地 设得兰 奥克尼 怀特岛 泰晤士河 剑河 科茨沃尔德 萨里 肯特 威尔士 峰区 贝尔法斯特 阿伯丁 卡迪夫 朴次茅斯 纽卡斯尔 温莎 诺福克 苏塞克斯 坎特伯雷",
        ["美国"] = "西雅图 波特兰 丹佛 波士顿 芝加哥 奥斯汀 迈阿密 新奥尔良 旧金山 洛杉矶 圣迭戈 布鲁克林 曼哈顿 皇后区 布朗克斯 底特律 匹兹堡 圣路易斯 纳什维尔 孟菲斯 菲尼克斯 图森 圣菲 阿尔伯克基 费城 巴尔的摩 奥克兰 伯克利 萨克拉门托 麦迪逊 安娜堡 大峡谷 密歇根湖 太浩湖 黄石公园 大苏尔"
    };
    private static readonly Dictionary<string, string> Objects = new()
    {
        ["中国"] = "来信 晚风 旧梦 月色 纸鸢 灯笼 画册 茶客 烟雨 渔火 竹笛 琴声 诗稿 墨迹 书生 游记 木舟 青瓦 柳絮 落雪 晨钟 鹿鸣 鸟语 松涛 星夜 蝉声 飞花 旅人 胡琴 酒旗 小调 花信 芦笛 铜铃 春水",
        ["日本"] = "风铃 饭团 邮筒 车票 小猫 夜樱 冷麦茶 雨伞 便当 竹篮 咖喱饭 团扇 绘马 鲤鱼旗 蓝窗帘 旧电车 手账 纸灯 橘子汽水 鹿仙贝 樱饼 铃铛 黑板 口琴 书店 明信片 鲷鱼烧 焙茶 丸子 地图 竹蜻蜓 木屐 鲣鱼干 玻璃杯 旧漫画 杂货铺",
        ["韩国"] = "晚风 年糕 白熊 咖啡杯 小木屋 明信片 紫菜包饭 热汤 浪花 花灯 日记 薄荷茶 栗子 牛奶盒 蓝屋顶 小巷 信箱 小雨伞 春雨 烤红薯 书签 塑料椅 橘子筐 风筝 路边摊 海鸥 老钟 纸袋 旧唱片 小餐车 夜灯 油菜花 椰子面包 便签本 烤鱿鱼 玉米茶",
        ["德国"] = "旧钟 黑麦面包 钢笔 椒盐卷饼 松针 木雕 留声机 火车票 铃塔 烤苹果 胶片 啤酒杯 小风车 石板路 瓷杯 笔记本 单车 旧地图 野餐篮 咖啡豆 邮差 旅行箱 手套 围巾 锡兵 木偶 棋盘 铜钥匙 风向标 老书店 山屋 红电车 小邮局 栗树 玻璃球 木口哨",
        ["法国"] = "可颂 手风琴 旧书摊 蓝窗帘 明信片 雨燕 面包篮 薰衣草 咖啡馆 鹅卵石 贝雷帽 茶匙 红围巾 油画 夜曲 花店 小码头 旧海报 软糖 白瓷盘 玻璃瓶 木桌 蝴蝶标本 胶片相机 风帆 栗子摊 长笛 唱片店 小钟楼 百叶窗 素描本 奶油泡芙 蜂蜜罐 灰鸽子 陶碗 旧皮箱",
        ["巴西"] = "椰子水 桑巴鼓 沙滩椅 水豚 彩房 巨嘴鸟 帆船 足球 街角咖啡 晾衣绳 吊床 木吉他 海风 腰果 手鼓 草帽 芝士面包 独木舟 风铃 芒果树 蓝拖鞋 烤玉米 石子路 彩旗 旧球鞋 雨林信笺 橡胶球 小货摊 棕榈叶 窗台花 小皮鼓 夜灯 铁皮箱 香蕉叶 篮筐 日落",
        ["英国"] = "茶壶 红伞 猫头鹰 知更鸟 饼干罐 旧报纸 羊毛袜 邮筒 电话亭 藤椅 野花 壁炉 木门 煎饼 雨靴 牛奶瓶 旧唱片 麦穗 板球帽 火车票 纸风车 旧望远镜 小山雀 格纹围巾 老怀表 泥炭火 绣球花 橡树叶 旧书包 黄铜门铃 白帆船 热可可 旧灯罩 小园丁 灰松鼠 风笛",
        ["美国"] = "滑板 球帽 苹果派 点唱机 旧皮卡 甜甜圈 苏打水 棒球卡 牛仔靴 胶片 公路地图 霓虹灯 咖啡壶 玉米饼 旧招牌 冰淇淋车 便携电台 橄榄球 野餐盒 木吉他 摄影集 旧录像带 枫糖浆 冰咖啡 邮件箱 仙人掌 溜冰鞋 马蹄铁 黄校车 蓝棒球 海报 汽车旅馆 旧磁带 烤棉花糖 露营灯 雪地靴"
    };
    internal static readonly Dictionary<string, string> Singles = new()
    {
        ["中国"] = "回到山里 灯灭以后 云向北走 茶凉续水 还差半步 此间有风 今晚听雨 江湖散人 春山可望 与鹤同归 西窗读雪 石上听泉 终南望月 白马过溪 提灯赴约 月落无声 沙洲独行 睡到自然醒 先吃一口饭 末班船 不羡仙 山川载酒 小楼春雨 苔上雪 江河故人 夏虫语冰 半生闲 客从远方来 千山月 薄暮微光 温酒等雪 上山摘月亮 一只小饕餮 海棠依旧 借我半壶酒 长夜有星 窗外下雨了吗 先把杯子放下 人间小事 过了这座桥 不记得密码 下课去吹风 等锅开 木头脑袋 容我想想 江东一叶 小城故事 围炉听书 竹马旧事 蓝调时分 水果忍者 菠萝吹雪 咸鱼翻个身 烤面包大师 河狸先生 猫说先别动 还有半杯茶 随手一张 十四行诗 差点就赢了 吃饱再说 什么都想尝尝 番茄没有酱 这站该下车",
        ["日本"] = "Haruto Yuto Yuma Kota Taichi Naoki Ryota Daiki Yusuke Satoshi Kazuki Kohei Shota Tsubasa Akira Masato Rina Mio Nana Hana Yui Mei Rin Hina Saki Noa Erika Miku 春天的便利店 猫把笔叼走了 自动门没开 借来的漫画 明天交作业 搭错一班电车 铃声响三遍 下课后见 四叠半日记 雨停再回家",
        ["韩国"] = "Junseo Dohyun Taemin Seungmin Hyunwoo Minho Junho Donghae Jinyoung Taehyun Jaehyun Seongjin Woobin Jiwan Yunho Seungho Eunseo Chaewon Seoyeon Minji Yerin Sohee Dami Nayoung Haeun Sujin Yeji Bomi 多加一份鱼饼 今天吃拌饭 看完这集就睡 猫占了我的坐垫 辣酱忘了放 月亮像米糕 晒被子的下午 最后一个鲷鱼饼 热汤慢慢喝 海浪拍了三下",
        ["德国"] = "Paul Simon Julian Niklas Hannes Ben Noah Henry Valentin Lennart Till Nils Jan Arne Jannik Fabian Mia Hannah Emma Lena Klara Lotta Nele Frieda Greta Johanna Luisa Marlene 明天再修自行车 面包屑掉了两颗 整点差一分钟 末班车准时到 羊在山坡上 草坪刚剪过 还没找到钥匙 长椅上的星期天 咖啡要趁热 棋盘少了一只马",
        ["法国"] = "Gabriel Raphael Adam Paul Victor Gaspard Augustin Basile Clement Etienne Adrien Thibault Anatole Baptiste Maxime Valentin Louise Jeanne Alice Adele Margot Juliette Chloe Ines Celia Amelie Clara Ninon 雨后去散步 买完面包回家 小猫打翻颜料 第三个街角 长笛吹慢一点 露台还留着椅子 黄油抹厚一点 半句旧情诗 信封上画朵花 周日的早午餐",
        ["巴西"] = "Miguel Gabriel Arthur Heitor Samuel Bernardo Nicolas Murilo Henrique Matheus Gustavo Vinicius Andre Daniel Thiago Diego Sofia Helena Alice Laura Beatriz Isabela Manuela Luiza Mariana Camila Leticia Clara 再踢十分钟 海风吹乱球衣 椰子留一半 给吊床让个位子 芒果还没熟 转角有人弹吉他 慢慢晾干球鞋 这一杯加冰 明天还去沙滩 敲鼓敲到太阳落",
        ["英国"] = "William Thomas James Henry Edward Samuel Toby Felix Alistair Angus Callum Hamish Ewan Rhys Dylan Owen Amelia Isla Lily Poppy Florence Ivy Maisie Elsie Freya Imogen Phoebe Matilda 牛奶先倒还是后倒 茶匙掉进杯子里 饼干蘸得太久 雨还要下多久 壁炉旁边最暖 草坪上有只獾 礼拜天去旧书店 再等五分钟 鸽子抢走薯条 下车记得带伞",
        ["美国"] = "Jackson Grayson Levi Hudson Lincoln Brooks Asher Silas Parker Colton Sawyer Easton Bennett Wesley Everett Spencer Harper Avery Brooklyn Addison Scarlett Peyton Quinn Hailey Madison Skylar Kinsley Reagan 披萨边留给我 热狗多放芥末 汽水还剩一点 球赛打到加时 轮胎漏气了 公路上听老歌 晒伤了一只胳膊 午饭多来份薯条 把窗户摇下来 咖啡续杯谢谢"
    };
    internal static readonly Dictionary<string, string[]> Handles = Places.ToDictionary(pair => pair.Key,
        pair => ContentPools.Words(pair.Value)
            .SelectMany(place => ContentPools.Words(Objects[pair.Key]).SelectMany(item => new[] { place + "的" + item, place + item })).Distinct(StringComparer.OrdinalIgnoreCase).ToArray());
}
