# LeagueLegendDraft.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`768A0568F06D23E5E389F1F6D999EC584330BFB9E010EC154D068426AC0A4973`。来源：[源码](../../LeagueLegendDraft.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueLegendDraft`、`NationalSpire.LeagueLegendDraft.Kit`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string,Kit> Kits=new(){
        ["力量重击"]=new("2POMMEL_STRIKE 2SWORD_BOOMERANG 2TWIN_STRIKE 2THUNDERCLAP 2SETUP_STRIKE 2ANGER 2HEADBUTT","2INFLAME 2BLOODLETTING 2BATTLE_TRANCE WHIRLWIND DISMANTLE 2MIND_BLAST","2OFFERING 2ONE_TWO_PUNCH DEMON_FORM","APOTHEOSIS","APOTHEOSIS 2MIND_BLAST 2POMMEL_STRIKE 2INFLAME"),
        ["毒素积累"]=new("2DEADLY_POISON 2POISONED_STAB 2BACKFLIP 2PIERCING_WAIL 2PREPARED 2SNAKEBITE 2DODGE_AND_ROLL","2BOUNCING_FLASK 2ACCELERANT 2BUBBLE_BUBBLE 2MIRAGE NOXIOUS_FUMES CALCULATED_GAMBLE","2ADRENALINE 2BURST CORROSIVE_WAVE","WRAITH_FORM","WRAITH_FORM 2ADRENALINE 2BUBBLE_BUBBLE"),
        ["闪电输出"]=new("2BALL_LIGHTNING 2ZAP 2TURBO 2HOLOGRAM 2COOLHEADED 2COMPILE_DRIVER 2LIGHTNING_ROD","2TESLA_COIL 2TEMPEST 2SKIM 2OVERCLOCK LOOP GLACIER","2DEFRAGMENT 2VOLTAIC ECHO_FORM","BIASED_COGNITION","BIASED_COGNITION 2DEFRAGMENT 2ZAP"),
        ["辉星爆发"]=new("2SOLAR_STRIKE 2VENERATE 2GLOW 2GATHER_LIGHT 2CLOAK_OF_STARS 2FALLING_STAR 2HIDDEN_CACHE","2BLACK_HOLE 2RADIATE ROYAL_GAMBLE 2GLIMMER STARDUST ALIGNMENT GAMMA_BLAST","2BIG_BANG SEVEN_STARS 2COMET","THE_SEALED_THRONE","2BLACK_HOLE 2BIG_BANG 2VENERATE"),
        ["瞄准重射"]=new("2HEAVY_SHOT 2QUICK_SHOT 2NOCK 2RECALL 2BOW_SMACK 2KI_CHANT 2RAIN_SHOT","2RAPID_SHOT 2WREST 2SERRATED_ARROWS HOBBLING_SHOT UPROOT TRICK_SHOT BRACE","QUIVER YAH SKY_SHOT REPEAT_SHOT HONING","DIVINE_SHOT","QUIVER SKY_SHOT 2RAPID_SHOT 2WREST"),
        ["消耗精简"]=new("2HAVOC 2TRUE_GRIT 2POMMEL_STRIKE 2SHRUG_IT_OFF 2CINDER 2TWIN_STRIKE 2HEADBUTT","2BURNING_PACT 2FEEL_NO_PAIN 2SECOND_WIND 2FORGOTTEN_RITUAL 2EVIL_EYE","2FIEND_FIRE 2PACTS_END OFFERING","CORRUPTION","CORRUPTION 2FIEND_FIRE 2PACTS_END"),
        ["弃牌周转"]=new("2PREPARED 2DAGGER_THROW 2UNTOUCHABLE 2FLICK_FLACK 2BACKFLIP 2SLICE 2DEFLECT","2ACROBATICS 2CALCULATED_GAMBLE 2TACTICIAN 2REFLEX 2MEMENTO_MORI","2ADRENALINE TOOLS_OF_THE_TRADE STORM_OF_STEEL AFTERIMAGE","WRAITH_FORM","2CALCULATED_GAMBLE 2REFLEX 2TACTICIAN WRAITH_FORM"),
        ["冰霜防御"]=new("2COOLHEADED 2COLD_SNAP 2BARRAGE 2TURBO 2HOLOGRAM 2DUALCAST 2BALL_LIGHTNING","2GLACIER 2HAILSTORM 2DARKNESS CHILL SKIM 2MIND_BLAST","2DEFRAGMENT ICE_LANCE SHATTER MULTI_CAST","QUADCAST","2MIND_BLAST CHILL 2DEFRAGMENT SKIM"),
        ["召唤防守"]=new("2UNLEASH 2BODYGUARD 2GRAVE_WARDEN 2WISP 2POKE 2AFTERLIFE 2FLATTEN","2DIRGE 2BONE_SHARDS 2RIGHT_HAND_HAND 2SIC_EM DEBILITATE PARSE","2SQUEEZE 2NEUROSURGE REANIMATE","PROTECTOR","PROTECTOR REANIMATE 2UNLEASH 2BODYGUARD"),
        ["君王之剑"]=new("2SPOILS_OF_BATTLE 2REFINE_BLADE 2WROUGHT_IN_WAR 2GATHER_LIGHT 2HIDDEN_CACHE 2GLOW 2GUIDING_STAR","2SUMMON_FORTH 2CONQUEROR 2PRODUCTION 2PARRY GLIMMER GAMMA_BLAST","2BIG_BANG 2SWORD_SAGE ANOINTED","APOTHEOSIS","APOTHEOSIS ANOINTED 2SWORD_SAGE"),
        ["箭矢周转"]=new("2QUICK_SHOT 2RECALL 2NOCK 2HEAVY_SHOT 2BOW_SMACK 2KI_CHANT 2RAIN_SHOT","2UPROOT 2WREST 2SERRATED_ARROWS 2RAPID_SHOT 2LOCKED_IN","2QUIVER YAH REPEAT_SHOT SKY_SHOT","DIVINE_SHOT","2QUIVER 2RAPID_SHOT 2LOCKED_IN"),
        ["灾厄积累"]=new("2SCOURGE 2NEGATIVE_PULSE 2GRAVE_WARDEN 2WISP 2INVOKE 2BODYGUARD 2BLIGHT_STRIKE","2DEATHBRINGER 2COUNTDOWN 2NO_ESCAPE 2SHROUD 2PARSE","2END_OF_DAYS 2NEUROSURGE TIMES_UP","APOTHEOSIS","APOTHEOSIS 2NEUROSURGE 2NO_ESCAPE"),
        ["辉星续航"]=new("2SOLAR_STRIKE 2VENERATE 2GLOW 2GATHER_LIGHT 2CLOAK_OF_STARS 2FALLING_STAR 2HIDDEN_CACHE","2CHILD_OF_THE_STARS 2BLACK_HOLE 2GLIMMER ROYAL_GAMBLE RADIATE 2STARDUST","2BIG_BANG GENESIS COMET DECISIONS_DECISIONS","THE_SEALED_THRONE","2BIG_BANG 2VENERATE 2STARDUST"),
        ["哇音强攻"]=new("2WAH_HAMMER 2WAH_TOUCH 2WAH_SWEEP 2KI_CHANT 2CHO_READY 2KI_WHIP 2KI_HOP","2WAH_CHO 2WAH_KI 2RHYTHM_STRIKE 2VIOLENT_CHORD 2MOTIF","2WAH_SYMPHONY WAH_CHO_KI CODA KI_VERSE","LOST_LUTE","LOST_LUTE 2VIOLENT_CHORD 2MOTIF 2WAH_SWEEP"),
        ["格挡反击"]=new("2BODY_SLAM 2SHRUG_IT_OFF 2POMMEL_STRIKE 2BLOOD_WALL 2HEADBUTT 2IRON_WAVE 2ARMAMENTS","2FLAME_BARRIER 2BATTLE_TRANCE 2BLOODLETTING 2RAGE 2EVIL_EYE","BARRICADE 2IMPERVIOUS 2JUGGERNAUT","APOTHEOSIS","APOTHEOSIS BARRICADE 2BODY_SLAM 2POMMEL_STRIKE"),
        ["守势用毒"]=new("2DEADLY_POISON 2POISONED_STAB 2BACKFLIP 2PIERCING_WAIL 2PREPARED 2SNAKEBITE 2DODGE_AND_ROLL","2ACCELERANT 2MIRAGE 2FOOTWORK 2BOUNCING_FLASK BUBBLE_BUBBLE LEG_SWEEP","2ADRENALINE 2BURST AFTERIMAGE","WRAITH_FORM","WRAITH_FORM 2ADRENALINE 2MIRAGE"),
        ["黑暗蓄能"]=new("2COOLHEADED 2HOTFIX 2DUALCAST 2HOLOGRAM 2TURBO 2COMPILE_DRIVER 2CHARGE_BATTERY","2DARKNESS 2SHADOW_SHIELD 2LOOP 2SKIM 2OVERCLOCK","2CONSUMING_SHADOW 2MULTI_CAST REBOOT","QUADCAST","QUADCAST 2DARKNESS 2SHADOW_SHIELD 2COOLHEADED"),
        ["召唤与灾厄"]=new("2UNLEASH 2BODYGUARD 2GRAVE_WARDEN 2INVOKE 2SCOURGE 2NEGATIVE_PULSE 2WISP","2DEATHBRINGER 2SHROUD 2NO_ESCAPE 2DIRGE 2COUNTDOWN","2NEUROSURGE REANIMATE END_OF_DAYS TIMES_UP","PROTECTOR","PROTECTOR 2NEUROSURGE 2NO_ESCAPE"),
        ["低费过渡"]=new("2SOLAR_STRIKE 2GLOW 2FALLING_STAR 2CLOAK_OF_STARS 2HIDDEN_CACHE 2GATHER_LIGHT 2GUIDING_STAR","2LUNAR_BLAST GAMMA_BLAST 2BLACK_HOLE 2GLIMMER ALIGNMENT 2RADIATE","2BIG_BANG 2GOLD_AXE MASTER_OF_STRATEGY","THE_SEALED_THRONE","2BIG_BANG 2LUNAR_BLAST 2BLACK_HOLE"),
        ["拉伸防守"]=new("2DEEP_STRETCH 2CHO_BARBS 2CHO_READY 2KI_CHANT 2WAH_SWEEP 2KI_WHIP 2WAH_HAMMER","2MOTIF 2CHO_KI 2WAH_CHO 2CHO_LIMBS SONG_PATH STEADY_CADENCE","2CHO_CHORUS 2WAH_CHO_KI CODA","LOST_LUTE","LOST_LUTE 2CHO_CHORUS 2MOTIF"),
        ["力量连击"]=new("2SWORD_BOOMERANG 2TWIN_STRIKE 2POMMEL_STRIKE 2THUNDERCLAP 2SETUP_STRIKE 2SHRUG_IT_OFF 2ANGER","2WHIRLWIND 2INFLAME 2BLOODLETTING 2BATTLE_TRANCE 2DISMANTLE","2ONE_TWO_PUNCH 2OFFERING DEMON_FORM","BRIGHTEST_FLAME","2ONE_TWO_PUNCH 2POMMEL_STRIKE 2INFLAME"),
        ["充能球连锁"]=new("2DUALCAST 2COOLHEADED 2BALL_LIGHTNING 2COMPILE_DRIVER 2ZAP 2HOLOGRAM 2TURBO","2GLACIER 2DARKNESS 2TEMPEST 2DOUBLE_ENERGY 2MIND_BLAST","2DEFRAGMENT 2RAINBOW MULTI_CAST","QUADCAST","2MIND_BLAST 2DEFRAGMENT 2DUALCAST"),
        ["持续召唤"]=new("2UNLEASH 2AFTERLIFE 2BODYGUARD 2INVOKE 2GRAVE_WARDEN 2WISP 2POKE","2DIRGE 2RIGHT_HAND_HAND 2CAPTURE_SPIRIT SIC_EM 2CALCIFY PARSE","2SQUEEZE NEUROSURGE ANOINTED DEVOUR_LIFE","PROTECTOR","PROTECTOR ANOINTED NEUROSURGE 2INVOKE"),
        ["铸剑防守"]=new("2SPOILS_OF_BATTLE 2REFINE_BLADE 2WROUGHT_IN_WAR 2HIDDEN_CACHE 2GLOW 2GUIDING_STAR 2GATHER_LIGHT","2CONQUEROR 2PARRY 2BULWARK 2PRODUCTION 2SUMMON_FORTH","2BIG_BANG 2SEEKING_EDGE SWORD_SAGE","APOTHEOSIS","APOTHEOSIS 2BIG_BANG SWORD_SAGE"),
        ["悲伤转化"]=new("2JEST 2MOURNING_BLOW 2SORROWFUL_STRIKE 2KI_CHANT 2WAH_HAMMER 2WAH_TOUCH 2QUICK_SHOT","2PUNCH_OF_JOY GROWTH 2RUMMAGE ALL_IS_WELL 2ANGUISH 2VITRIOL","2BRIGHTEN_UP ECSTASY ENNUI GOLD_AXE","BRIGHTEST_FLAME","2BRIGHTEN_UP GOLD_AXE 2PUNCH_OF_JOY"),
        ["锻造强攻"]=new("2PERFECTED_STRIKE 2POMMEL_STRIKE 2TWIN_STRIKE 2SETUP_STRIKE 2ARMAMENTS 2SHRUG_IT_OFF 2HEADBUTT","2BATTLE_TRANCE 2BLOODLETTING 2DISMANTLE INFLAME UPPERCUT 2MIND_BLAST","2HELLRAISER 2OFFERING AGGRESSION","APOTHEOSIS","APOTHEOSIS 2MIND_BLAST 2HELLRAISER"),
        ["保留蓄势"]=new("2BACKFLIP 2PREPARED 2DAGGER_THROW 2UNTOUCHABLE 2DEFLECT 2PREDATOR 2FLICK_FLACK","2FLECHETTES 2ACROBATICS 2CALCULATED_GAMBLE 2TACTICIAN 2MIND_BLAST","WELL_LAID_PLANS 2ADRENALINE 2GOLD_AXE","SUPPRESS","2MIND_BLAST 2FLECHETTES 2ADRENALINE"),
        ["零费回收"]=new("2CLAW 2BEAM_CELL 2GO_FOR_THE_EYES 2HOLOGRAM 2COOLHEADED 2TURBO 2COMPILE_DRIVER","2FTL 2SCRAPE 2FINESSE 2OVERCLOCK SKIM BOOT_SEQUENCE","2ALL_FOR_ONE REBOOT GOLD_AXE SUPERCRITICAL","APOTHEOSIS","APOTHEOSIS 2ALL_FOR_ONE 2HOLOGRAM"),
        ["啾音护身"]=new("2CHO_BARBS 2CHO_READY 2CHO_FIRM 2KI_CHANT 2WAH_SWEEP 2KI_WHIP 2WAH_HAMMER","2WAH_CHO 2CHO_KI 2RHYTHM_STRIKE 2MOTIF SONG_PATH STEADY_CADENCE","2CHO_CHORUS WAH_CHO_KI 2CODA","LOST_LUTE","LOST_LUTE 2MOTIF WAH_CHO_KI 2WAH_CHO"),
        ["叽音蓄势"]=new("2KI_CHANT 2KI_HOP 2KI_WHIP 2WAH_SWEEP 2WAH_HAMMER 2CHO_FIRM 2CHO_READY","2MOTIF 2CHO_KI 2WAH_KI 2WAH_CHO 2RHYTHM_STRIKE","2KI_VERSE 2WAH_CHO_KI CODA","LOST_LUTE","LOST_LUTE 2MOTIF 2WAH_CHO_KI"),
        ["悲伤与喜悦"]=new("2JEST 2MOURNING_BLOW 2SORROWFUL_STRIKE 2KI_CHANT 2QUICK_SHOT 2WAH_SWEEP 2RECALL","2PUNCH_OF_JOY 2GROWTH 2RUMMAGE 2ANGUISH 2VITRIOL","2BRIGHTEN_UP ECSTASY ENNUI GOLD_AXE","BRIGHTEST_FLAME","2PUNCH_OF_JOY 2BRIGHTEN_UP GOLD_AXE"),
        ["三种旋律"]=new("2KI_CHANT 2KI_HOP 2KI_WHIP 2WAH_SWEEP 2WAH_HAMMER 2CHO_FIRM 2CHO_READY","2MOTIF 2CHO_KI 2WAH_KI 2WAH_CHO 2RHYTHM_STRIKE","2WAH_CHO_KI 2CODA KI_VERSE","LOST_LUTE","LOST_LUTE 2MOTIF 2WAH_CHO_KI"),
    };
private static readonly Dictionary<string,string[][]> Alternatives=new(){
        ["IRONCLAD"]=[["SHRUG_IT_OFF","IRON_WAVE","BLOOD_WALL"],["THUNDERCLAP","TREMBLE","UPPERCUT"],["HEADBUTT","POMMEL_STRIKE","ARMAMENTS"],["SWORD_BOOMERANG","TWIN_STRIKE"],["BLOODLETTING","FORGOTTEN_RITUAL"],["EVIL_EYE","SECOND_WIND"]],
        ["SILENT"]=[["DODGE_AND_ROLL","BACKFLIP","DEFLECT"],["FLICK_FLACK","UNTOUCHABLE","RICOCHET"],["PREPARED","DAGGER_THROW"],["POISONED_STAB","DEADLY_POISON"],["ACROBATICS","CALCULATED_GAMBLE","EXPERTISE"],["FOOTWORK","LEG_SWEEP"]],
        ["DEFECT"]=[["COOLHEADED","COLD_SNAP"],["BALL_LIGHTNING","ZAP"],["COMPILE_DRIVER","SWEEPING_BEAM"],["SKIM","OVERCLOCK"],["GLACIER","CHILL"],["CHAOS","DARKNESS"]],
        ["NECROBINDER"]=[["GRAVE_WARDEN","AFTERLIFE","BODYGUARD"],["INVOKE","WISP"],["POKE","FLATTEN","SNAP"],["SCOURGE","NEGATIVE_PULSE"],["CAPTURE_SPIRIT","PARSE"],["RIGHT_HAND_HAND","SIC_EM"],["BONE_SHARDS","DELAY"]],
        ["REGENT"]=[["GATHER_LIGHT","CLOAK_OF_STARS"],["GLOW","GUIDING_STAR"],["SOLAR_STRIKE","VENERATE","HIDDEN_CACHE"],["REFINE_BLADE","WROUGHT_IN_WAR","SPOILS_OF_BATTLE"],["GLIMMER","PROPHESIZE"],["GAMMA_BLAST","LUNAR_BLAST"],["CRASH_LANDING","COMET"]],
        ["FOOL"]=[["KI_HOP","KI_WHIP"],["CHO_READY","CHO_FIRM","CHO_BARBS"],["WAH_HAMMER","WAH_SWEEP","WAH_TOUCH"],["HEAVY_SHOT","RAIN_SHOT","FOOLISH_SHOT"],["RECALL","BOW_SMACK"],["CHO_KI","WAH_KI","WAH_CHO"],["WREST","UPROOT"],["RAPID_SHOT","HOBBLING_SHOT"],["REPEAT_SHOT","SKY_SHOT"]],
    };
```

<a id="symbol-3aa7ddd8a690"></a>

## `NationalSpire.LeagueLegendDraft.Expand(string) — private static IEnumerable<string> Expand(string specification)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`](LeagueLegendDraft.cs.md#symbol-c210ac44d176)；[`NationalSpire.LeagueLegendDraft.ForgeOrder(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan)`](LeagueLegendDraft.cs.md#symbol-33b903b8097f)

**调用：** `string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(char, System.StringSplitOptions)`；输入表达式：`specification.Split(' ')`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var item in specification.Split(' ')){             if(item[0]=='2'){yield return item[1..];yield return item[1..];}             else yield return item;         }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c210ac44d176"></a>

## `NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random) — internal static List<CardModel>? Build(LeagueArchetypes.Plan plan,LeagueCards.Entry[] pool,Random rng)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)

**调用：** [`Add(NationalSpire.LeagueCards.Entry)`](LeagueLegendDraft.cs.md#symbol-74772b611b35)；[`NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-4a2f709b2968)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueLegendDraft.Expand(string)`](LeagueLegendDraft.cs.md#symbol-3aa7ddd8a690)；[`Required(string)`](LeagueLegendDraft.cs.md#symbol-252d9912a1e9)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.Enumerable.Repeat<TResult>(TResult, int)`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `Add(NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueArchetypes.Engine.Draw`；`NationalSpire.LeagueArchetypes.Engine.Energy`；`NationalSpire.LeagueArchetypes.Engines`；`NationalSpire.LeagueArchetypes.Plan.Role`；`NationalSpire.LeagueArchetypes.Plan.Title`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.NeutralLimit`；`NationalSpire.LeagueLegendDraft.Alternatives`；`NationalSpire.LeagueLegendDraft.Expand(string)`；`NationalSpire.LeagueLegendDraft.Kit.Ancient`；`NationalSpire.LeagueLegendDraft.Kit.Blues`；`NationalSpire.LeagueLegendDraft.Kit.Commons`；`NationalSpire.LeagueLegendDraft.Kit.Forge`；`NationalSpire.LeagueLegendDraft.Kit.Golds`；`NationalSpire.LeagueLegendDraft.Kits`；`Required(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(c);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(catalog[to])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(catalog[to]);`
- `NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.CanSupportAnother(k,counts)`；返回值紧邻使用处：`BinaryExpressionSyntax: catalog.TryGetValue(k,out var c)&&c.Tier==old.Tier&&(k==from||counts.GetValueOrDefault(k)<2)&&                 (!engine.Draw.Contains(from)||engine.Draw.Contains(k))&&(!engine.Energy.Contains(from)||engine.Energy.Contains(k))&&                 (c.Group!="COLORLESS"||old.Group=="COLORLESS"||neutral<LeagueCards.NeutralLimit)&&LeagueArchetypes.CanSupportAnother(k,counts)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Fixed(c)`
- `NationalSpire.LeagueLegendDraft.Expand(string)`；输入表达式：`Expand(bands[grade])`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var id in Expand(bands[grade])){             if(!catalog.TryGetValue(id,out var c)||c.Tier!=grade)return null;             Add(c);         }`
- `NationalSpire.LeagueLegendDraft.Expand(string)`；输入表达式：`Expand(kit.Forge)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Expand(kit.Forge).GroupBy`
- `Required(string)`；输入表达式：`Required(k)`；返回值紧邻使用处：`BinaryExpressionSyntax: counts.GetValueOrDefault(k)>Required(k)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`counts.Remove(from)`；返回值紧邻使用处：`ExpressionStatementSyntax: counts.Remove(from);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`catalog.TryGetValue(id,out var c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !catalog.TryGetValue(id,out var c)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`catalog.TryGetValue(k,out var c)`；返回值紧邻使用处：`BinaryExpressionSyntax: catalog.TryGetValue(k,out var c)&&c.Tier==old.Tier`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Kits.TryGetValue(plan.Title,out var kit)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Kits.TryGetValue(plan.Title,out var kit)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`engine.Draw.Contains(from)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !engine.Draw.Contains(from)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`engine.Draw.Contains(k)`；返回值紧邻使用处：`BinaryExpressionSyntax: !engine.Draw.Contains(from)||engine.Draw.Contains(k)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`engine.Energy.Contains(from)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !engine.Energy.Contains(from)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`engine.Energy.Contains(k)`；返回值紧邻使用处：`BinaryExpressionSyntax: !engine.Energy.Contains(from)||engine.Energy.Contains(k)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`counts.Values.Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: counts.Values.Sum()!=LeagueCards.DeckSize`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g=>g.Count()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Expand(kit.Forge).GroupBy(id=>id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Expand(kit.Forge).GroupBy(id=>id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`counts.OrderBy(p=>p.Key,StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: counts.OrderBy(p=>p.Key,StringComparer.Ordinal).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`counts.OrderBy(p=>p.Key,StringComparer.Ordinal).SelectMany(p=>Enumerable.Repeat(catalog[p.Key].Model,p.Value))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: counts.OrderBy(p=>p.Key,StringComparer.Ordinal).SelectMany(p=>Enumerable.Repeat(catalog[p.Key].Model,p.Value)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`group.Where(k=>catalog.TryGetValue(k,out var c)&&c.Tier==old.Tier&&(k==from||counts.GetValueOrDefault(k)<2)&&                 (!engine.Draw.Contains(from)||engine.Draw.Contains(k))&&(!engine.Energy.Contains(from)||engine.Energy.Contains(k))&&                 (c.Group!="COLORLESS"||old.Group=="COLORLESS"||neutral<LeagueCards.NeutralLimit)&&LeagueArchetypes.CanSupportAnother(k,counts)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =group.Where(k=>catalog.TryGetValue(k,out var c)&&c.Tier==old.Tier&&(k==from||counts.GetValueOrDefault(k)<2)&&                 (!engine.Draw.Contains(from)||engine.Draw.Contains(k))&&(!engine.Energy.Contains(from)||engine.Energy.Contains(k))&&                 (c.Group!="COLORLESS"||old.Group=="COLORLESS"||neutral<LeagueCards.NeutralLimit)&&LeagueArchetypes.CanSupportAnother(k,counts)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`group.Where(k=>counts.GetValueOrDefault(k)>Required(k)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =group.Where(k=>counts.GetValueOrDefault(k)>Required(k)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`Expand(kit.Forge).GroupBy(id=>id).ToDictionary(g=>g.Key,g=>g.Count())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Expand(kit.Forge).GroupBy(id=>id).ToDictionary(g=>g.Key,g=>g.Count())`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`pool.ToDictionary(c=>c.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.ToDictionary(c=>c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`counts.OrderBy(p=>p.Key,StringComparer.Ordinal).SelectMany(p=>Enumerable.Repeat(catalog[p.Key].Model,p.Value)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return counts.OrderBy(p=>p.Key,StringComparer.Ordinal).SelectMany(p=>Enumerable.Repeat(catalog[p.Key].Model,p.Value)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Where(k=>catalog.TryGetValue(k,out var c)&&c.Tier==old.Tier&&(k==from||counts.GetValueOrDefault(k)<2)&&                 (!engine.Draw.Contains(from)||engine.Draw.Contains(k))&&(!engine.Energy.Contains(from)||engine.Energy.Contains(k))&&                 (c.Group!="COLORLESS"||old.Group=="COLORLESS"||neutral<LeagueCards.NeutralLimit)&&LeagueArchetypes.CanSupportAnother(k,counts))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Where(k=>catalog.TryGetValue(k,out var c)&&c.Tier==old.Tier&&(k==from||counts.GetValueOrDefault(k)<2)&&                 (!engine.Draw.Contains(from)||engine.Draw.Contains(k))&&(!engine.Energy.Contains(from)||engine.Energy.Contains(k))&&                 (c.Group!="COLORLESS"||old.Group=="COLORLESS"||neutral<LeagueCards.NeutralLimit)&&LeagueArchetypes.CanSupportAnother(k,counts)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Where(k=>counts.GetValueOrDefault(k)>Required(k))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Where(k=>counts.GetValueOrDefault(k)>Required(k)).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`counts.GetValueOrDefault(k)`；返回值紧邻使用处：`BinaryExpressionSyntax: counts.GetValueOrDefault(k)<2`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`counts.GetValueOrDefault(k)`；返回值紧邻使用处：`BinaryExpressionSyntax: counts.GetValueOrDefault(k)>Required(k)`
- `System.Linq.Enumerable.Repeat<TResult>(TResult, int)`；输入表达式：`Enumerable.Repeat(catalog[p.Key].Model,p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>Enumerable.Repeat(catalog[p.Key].Model,p.Value)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(options.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(options.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(sources.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(sources.Length)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-74772b611b35"></a>

## `Add(NationalSpire.LeagueCards.Entry) — void Add(LeagueCards.Entry c)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`](LeagueLegendDraft.cs.md#symbol-c210ac44d176)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`counts.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: counts.GetValueOrDefault(c.Id)+1`

**赋值（含属性/字段和局部值）：**

- `counts[c.Id]` = `counts.GetValueOrDefault(c.Id)+1`

<a id="symbol-252d9912a1e9"></a>

## `Required(string) — int Required(string id)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`](LeagueLegendDraft.cs.md#symbol-c210ac44d176)

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Plan.Finishers`；`NationalSpire.LeagueArchetypes.Plan.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`plan.Finishers.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: plan.Anchors.Contains(id)||plan.Starters.Contains(id)||plan.Finishers.Contains(id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`plan.Starters.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: plan.Anchors.Contains(id)||plan.Starters.Contains(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Anchors.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: plan.Anchors.Contains(id)||plan.Starters.Contains(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`forgeCopies.GetValueOrDefault(id)`；返回值紧邻使用处：`ArgumentSyntax: forgeCopies.GetValueOrDefault(id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(forgeCopies.GetValueOrDefault(id),                 plan.Anchors.Contains(id)||plan.Starters.Contains(id)||plan.Finishers.Contains(id)?1:0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Math.Max(forgeCopies.GetValueOrDefault(id),                 plan.Anchors.Contains(id)||plan.Starters.Contains(id)||plan.Finishers.Contains(id)?1:0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-33b903b8097f"></a>

## `NationalSpire.LeagueLegendDraft.ForgeOrder(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan) — internal static IEnumerable<CardModel> ForgeOrder(CardModel[] cards,LeagueArchetypes.Plan plan)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`](LeagueLadder.cs.md#symbol-1b55dcf28341)

**调用：** [`NationalSpire.LeagueLegendDraft.Expand(string)`](LeagueLegendDraft.cs.md#symbol-3aa7ddd8a690)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Plan.Title`；`NationalSpire.LeagueLegendDraft.Expand(string)`；`NationalSpire.LeagueLegendDraft.Kit.Forge`；`NationalSpire.LeagueLegendDraft.Kits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLegendDraft.Expand(string)`；输入表达式：`Expand(kit.Forge)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var key in Expand(kit.Forge)){             int i=remaining.FindIndex(c=>c.Id.Entry==key&&c.MaxUpgradeLevel>0);if(i<0)continue;             selected.Add(remaining[i]);remaining.RemoveAt(i);         }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Kits.TryGetValue(plan.Title,out var kit)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Kits.TryGetValue(plan.Title,out var kit)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`cards.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =cards.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`selected.Add(remaining[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Add(remaining[i]);`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`remaining.FindIndex(c=>c.Id.Entry==key&&c.MaxUpgradeLevel>0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =remaining.FindIndex(c=>c.Id.Entry==key&&c.MaxUpgradeLevel>0)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CardModel>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardModel>()`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`remaining.RemoveAt(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: remaining.RemoveAt(i);`

**赋值（含属性/字段和局部值）：**
