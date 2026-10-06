# 国运尖塔（National Spire）

《杀戮尖塔 2》生涯与社区模组：当其他人的尖塔水平下降 1000 倍，只有玩家保持不变。从社区选拔走向职业联赛和世界总决赛，经营俱乐部，与选手交流，让比赛结果影响世界与日常生活。

[Steam 创意工坊](https://steamcommunity.com/sharedfiles/filedetails/?id=3809501471) · [问题反馈](https://github.com/Catfish872/NationalSpire/issues)

本项目源码公开，采用 **PolyForm Noncommercial 1.0.0**，禁止未经授权的商业使用。允许在许可证规定的非商业用途范围内使用、修改和分发，分发时应保留许可证及相关声明。完整条款见 [LICENSE](LICENSE)。

## 主要功能

- **职业生涯**：社区赛事、赛区联赛、俱乐部联赛、国家队赛事与世界总决赛，记录战绩、通关进阶和荣誉。
- **俱乐部经营**：招募、合同商谈、首发与轮换、青训、培养和转会，支持创建自己的俱乐部。
- **国运与生活**：赛事影响国运，结合赞助、收入、生活事件和双周刊形成持续发展的世界。
- **社区与私信**：可选 AI 生成帖子、评论及私信；支持分享帖子、约战、合同、好感与关系、学习和短期状态等交互。
- **角色自定义**：编辑头像、身份、战绩、基础通关率、性格与打法，通过原始 PNG 文件导入和分享角色卡。
- **多人模式**：支持 Steam 联机生涯，由房主同步生涯数据，开赛前共同准备。

玩家进行游戏原生战斗，AI 对手的成绩由模组模拟；比赛根据通关情况、游戏记录的用时及失败楼层等规则结算。

## 当前更新计划

请其他开发者暂时不要涉及以下项目的功能实现，以免设计重叠或相互冲突。

- [ ] 支持弹幕在上方区域飘动。
- [ ] 支持切换与导出生涯存档。
- [ ] 添加队群与群聊系统。
- [ ] 支持删除自建角色，并兼容现有赛程及其他涉及角色信息的功能模块。
- [ ] 多人模式允许随时加入，不再锁定参与玩家。
- [ ] 允许 AI 自定义邀约或由玩家发起邀约；邀约日期到来时，玩家可以通过“＋”菜单响应。
- [ ] 为自建俱乐部添加教练机制，增强轮换与青训的加成能力。
- [ ] 允许玩家退出首发。
- [ ] 允许玩家担任教练，并通过私聊“＋”菜单定制训练计划，在指定培养周期内获得永久成长，类似现有的对话成长机制。
- [ ] 添加更多随机发帖事件和遗物收藏。
- [ ] 添加更多可选提示词模板。
- [ ] 修复成为职业选手后，未自动取消此前非职业赛事报名的问题。

## 安装

推荐通过 [Steam 创意工坊](https://steamcommunity.com/sharedfiles/filedetails/?id=3809501471)订阅并安装。当前源码对应的版本见 [NationalSpire.json](NationalSpire.json)。

手动安装时，将以下两个文件放入游戏目录的 `mods/NationalSpire/`：

```text
Slay the Spire 2/
└─ mods/
   └─ NationalSpire/
      ├─ NationalSpire.dll
      └─ NationalSpire.json
```

替换文件前退出游戏。多人联机时，各成员应使用相同的游戏分支与模组版本。

## AI 配置

AI 内容为可选功能。在游戏内“模组设置”中启用 AI 社区，填写支持 Chat Completions 的服务地址、模型名称和 API 密钥。提示词模板也在游戏内管理。

启用后，生成所需的人物资料、比赛信息、相关帖子与聊天内容会发送至你配置的服务。调用费用和可用模型由服务提供方决定。密钥通过 Windows 加密接口保存在本机，仓库不包含密钥和玩家存档。

## 从源码构建

当前项目面向 Windows，需要：

- .NET 9 SDK。
- 本机安装的《杀戮尖塔 2》。构建引用游戏目录中的 `sts2.dll`、`0Harmony.dll` 和 `Steamworks.NET.dll`。
- 项目使用 `Godot.NET.Sdk/4.5.1`，由项目依赖还原获取。

克隆仓库后，在仓库根目录执行；将 `Sts2Dir` 替换为实际游戏路径：

```powershell
git clone https://github.com/Catfish872/NationalSpire.git
cd NationalSpire

dotnet build NationalSpire.csproj -c Release `
  -p:Sts2Dir="D:\SteamLibrary\steamapps\common\Slay the Spire 2" `
  -p:DeployMod=false
```

构建产物为 `.godot/mono/temp/bin/Release/NationalSpire.dll`。与仓库中的 `NationalSpire.json` 一起安装即可。

项目默认会将构建结果复制到 `Sts2Dir` 下的 `mods/NationalSpire/`。上述命令使用 `DeployMod=false` 关闭自动复制；需要自动安装时，在游戏退出后将其改为 `true`。

游戏程序集由本机游戏提供，本仓库不分发这些文件。

## 源码结构

| 位置 | 内容 |
| --- | --- |
| `Career*.cs`、`Esports*.cs` | 生涯、赛事与世界数据 |
| `OwnedClub*.cs`、`ClubOperations.cs` | 玩家俱乐部与阵容管理 |
| `Ai*.cs`、`Private*.cs`、`Community*.cs` | AI 服务、私信与社区 |
| `Live*.cs`、`Match*.cs` | 局内比赛、解说与结算 |
| `Coop/` | 多人生涯与同步 |
| `PromptPresets/` | 内置提示词模板 |
| `Cameos/` | 内置人物资源 |
| `Diagnostics.cs`、`LogPerformance.cs` | 问题报告与性能记录 |

## 问题反馈

通过 [GitHub Issues](https://github.com/Catfish872/NationalSpire/issues)反馈时，注明游戏版本及分支、模组版本、单人或多人模式，以及发生问题的操作过程。游戏内“模组设置 → 导出问题报告”可导出诊断信息。

发布诊断文件前检查其中的存档、聊天与个人信息，仅公开你愿意分享的内容。
