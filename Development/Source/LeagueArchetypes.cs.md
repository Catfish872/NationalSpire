# LeagueArchetypes.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1FA2C5BE83D31AE8AD78ABC16FA599B16A358C47270F824152D9B0DB3E740A8A`。来源：[源码](../../LeagueArchetypes.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueArchetypes`、`NationalSpire.LeagueArchetypes.Plan`、`NationalSpire.LeagueArchetypes.Engine`、`NationalSpire.LeagueArchetypes.Pairing`。

字段、事件及初始值（源码原样）：

```csharp
internal readonly string[] Keys=Terms.Split(',');
internal readonly string[] Anchors=Core.Split(' '), Partners=Support.Split(' ');
internal readonly HashSet<string> Starters=Sources.Split(' ').ToHashSet(), Finishers=Payoffs.Split(' ').ToHashSet();
internal readonly HashSet<string> Draw=(draw+" FLASH_OF_STEEL FINESSE MASTER_OF_STRATEGY THINKING_AHEAD").Split(' ').ToHashSet();
internal readonly HashSet<string> Energy=(energy+" PRODUCTION DISCOVERY").Split(' ').ToHashSet();
internal static readonly Dictionary<string,Engine> Engines=new(){
        ["IRONCLAD"]=new("POMMEL_STRIKE SHRUG_IT_OFF BATTLE_TRANCE BURNING_PACT OFFERING DARK_EMBRACE","OFFERING BLOODLETTING PYRE HAVOC CORRUPTION"),
        ["SILENT"]=new("BACKFLIP ACROBATICS ESCAPE_PLAN PREPARED ADRENALINE REFLEX","ADRENALINE TACTICIAN BULLET_TIME"),
        ["DEFECT"]=new("COOLHEADED SKIM OVERCLOCK MACHINE_LEARNING","TURBO CHARGE_BATTERY AGGREGATE DOUBLE_ENERGY"),
        ["NECROBINDER"]=new("CAPTURE_SPIRIT PARSE GLIMPSE_BEYOND GRAVE_WARDEN REAVE NEUROSURGE","WISP BORROWED_TIME INVOKE NEUROSURGE"),
        ["REGENT"]=new("GLIMMER PROPHESIZE BIG_BANG GLOW DECISIONS_DECISIONS","BIG_BANG ALIGNMENT ORBIT DECISIONS_DECISIONS"),
        ["FOOL"]=new("RUMMAGE KI_CHANT ENNUI MOTIF WREST PUNCH_OF_JOY ECSTASY BRIGHTEN_UP","KI_REST ENCORE YAH KI_VERSE PUNCH_OF_JOY ECSTASY BRIGHTEN_UP")};
internal static readonly Dictionary<string,(string Guard,string Sustain)> Defense=new(){
        ["IRONCLAD"]=("SHRUG_IT_OFF TRUE_GRIT EVIL_EYE FLAME_BARRIER IRON_WAVE IMPERVIOUS","FEEL_NO_PAIN UNMOVABLE BARRICADE"),
        ["SILENT"]=("BACKFLIP LEG_SWEEP CLOAK_AND_DAGGER DODGE_AND_ROLL DEFLECT MIRAGE","FOOTWORK AFTERIMAGE WRAITH_FORM"),
        ["DEFECT"]=("LEAP GLACIER COOLHEADED COLD_SNAP CHILL CHARGE_BATTERY","GLACIER LOOP DEFRAGMENT"),
        ["NECROBINDER"]=("GRAVE_WARDEN BONE_SHARDS BODYGUARD NEGATIVE_PULSE DELAY","SHROUD DANSE_MACABRE AFTERLIFE"),
        ["REGENT"]=("GATHER_LIGHT BULWARK PARTICLE_WALL CLOAK_OF_STARS","PARRY NEUTRON_AEGIS CHILD_OF_THE_STARS"),
        ["FOOL"]=("JEST BOUNCE CHO_FIRM CHO_READY HARMONIC_SHIELD","DEEP_STRETCH HIDDEN_ROOTS SONG_PATH")};
private static readonly Dictionary<string,Pairing> PartnersByCard=new[]{
        Pair("DIRGE CAPTURE_SPIRIT SEVERANCE GRAVE_WARDEN REAVE SEANCE","DEVOUR_LIFE"),
        Pair("DEADLY_POISON BOUNCING_FLASK NOXIOUS_FUMES CORROSIVE_WAVE HAZE POISONED_STAB SNAKEBITE OUTBREAK","MIRAGE"),
        Pair("BLADE_DANCE CLOAK_AND_DAGGER INFINITE_BLADES HIDDEN_DAGGERS LEADING_STRIKE UP_MY_SLEEVE STORM_OF_STEEL","KNIFE_TRAP ACCURACY"),
        Pair("ACROBATICS PREPARED CALCULATED_GAMBLE DAGGER_THROW TOOLS_OF_THE_TRADE SURVIVOR STORM_OF_STEEL","TACTICIAN REFLEX")
    }.SelectMany(pair=>pair.Uses.Select(id=>(id,pair))).ToDictionary(x=>x.id,x=>x.pair);
private static readonly Plan[] Plans=[
            new("IRONCLAD","力量重击","力量,高伤,高费","INFLAME DEMON_FORM SETUP_STRIKE","BLUDGEON UPPERCUT POMMEL_STRIKE SHRUG_IT_OFF ONE_TWO_PUNCH FIGHT_ME SHOCKWAVE EXPECT_A_FIGHT PROWESS","INFLAME DEMON_FORM SETUP_STRIKE","BLUDGEON UPPERCUT POMMEL_STRIKE ONE_TWO_PUNCH FIGHT_ME"),
            new("IRONCLAD","消耗精简","消耗,精简,去留","BURNING_PACT TRUE_GRIT DARK_EMBRACE","FEEL_NO_PAIN CORRUPTION SECOND_WIND EVIL_EYE ASHEN_STRIKE FINESSE FLASH_OF_STEEL BRAND DRUM_OF_BATTLE FORGOTTEN_RITUAL FIEND_FIRE PACTS_END CINDER","BURNING_PACT TRUE_GRIT SECOND_WIND EVIL_EYE CORRUPTION","FEEL_NO_PAIN DARK_EMBRACE ASHEN_STRIKE FIEND_FIRE"),
            new("IRONCLAD","生命交换","生命交换,续航,生命余量","BLOODLETTING HEMOKINESIS RUPTURE","OFFERING BLOOD_WALL SHRUG_IT_OFF CRIMSON_MANTLE BRAND SPITE TEAR_ASUNDER INFERNO","BLOODLETTING HEMOKINESIS OFFERING BLOOD_WALL","RUPTURE INFERNO HEMOKINESIS TEAR_ASUNDER"),
            new("IRONCLAD","格挡反击","格挡,防御","BODY_SLAM BARRICADE SHRUG_IT_OFF","IMPERVIOUS FLAME_BARRIER IRON_WAVE UNMOVABLE JUGGERNAUT SECOND_WIND BLOOD_WALL PROLONG STONE_ARMOR","SHRUG_IT_OFF IMPERVIOUS FLAME_BARRIER IRON_WAVE","BODY_SLAM JUGGERNAUT"),
            new("IRONCLAD","力量连击","多次攻击,多段","INFLAME ONE_TWO_PUNCH SWORD_BOOMERANG","WHIRLWIND TWIN_STRIKE POMMEL_STRIKE SHRUG_IT_OFF SETUP_STRIKE CONFLAGRATION FIGHT_ME DISMANTLE VOLLEY","INFLAME SETUP_STRIKE","SWORD_BOOMERANG TWIN_STRIKE WHIRLWIND ONE_TWO_PUNCH"),
            new("IRONCLAD","锻造强攻","升级,可靠攻击","ARMAMENTS AGGRESSION PERFECTED_STRIKE","POMMEL_STRIKE HEADBUTT TWIN_STRIKE IRON_WAVE SETUP_STRIKE HELLRAISER SEEKER_STRIKE ASHEN_STRIKE ULTIMATE_STRIKE","ARMAMENTS AGGRESSION","PERFECTED_STRIKE TWIN_STRIKE POMMEL_STRIKE ULTIMATE_STRIKE"),
            new("SILENT","毒素积累","中毒,毒素","DEADLY_POISON BOUNCING_FLASK ACCELERANT","NOXIOUS_FUMES CORROSIVE_WAVE BUBBLE_BUBBLE BACKFLIP LEG_SWEEP HAZE POISONED_STAB SNAKEBITE OUTBREAK MIRAGE","DEADLY_POISON BOUNCING_FLASK POISONED_STAB NOXIOUS_FUMES HAZE","ACCELERANT BUBBLE_BUBBLE MIRAGE"),
            new("SILENT","弃牌周转","弃牌,过牌","ACROBATICS TACTICIAN REFLEX","PREPARED CALCULATED_GAMBLE DAGGER_THROW TOOLS_OF_THE_TRADE UNTOUCHABLE FLICK_FLACK MEMENTO_MORI SURVIVOR HIDDEN_DAGGERS STORM_OF_STEEL MASTER_PLANNER RICOCHET","ACROBATICS PREPARED DAGGER_THROW SURVIVOR CALCULATED_GAMBLE","TACTICIAN REFLEX FLICK_FLACK RICOCHET"),
            new("SILENT","小刀连击","小刀,连续出牌,多次出牌","BLADE_DANCE ACCURACY CLOAK_AND_DAGGER","INFINITE_BLADES AFTERIMAGE FINISHER BACKFLIP LEADING_STRIKE UP_MY_SLEEVE PHANTOM_BLADES KNIFE_TRAP SERPENT_FORM","BLADE_DANCE CLOAK_AND_DAGGER INFINITE_BLADES LEADING_STRIKE UP_MY_SLEEVE","ACCURACY FINISHER KNIFE_TRAP AFTERIMAGE"),
            new("SILENT","守势用毒","稳定防守,格挡与中毒","BACKFLIP DEADLY_POISON LEG_SWEEP","DODGE_AND_ROLL FOOTWORK NOXIOUS_FUMES ACCELERANT MIRAGE HAZE SNAKEBITE SHADOWMELD","DEADLY_POISON NOXIOUS_FUMES HAZE SNAKEBITE","ACCELERANT MIRAGE BACKFLIP LEG_SWEEP"),
            new("SILENT","低费快攻","低费,攻击积极","BACKSTAB SLICE FINISHER","ADRENALINE DEFLECT DAGGER_THROW BACKFLIP FLASH_OF_STEEL AFTERIMAGE STRANGLE SERPENT_FORM LEADING_STRIKE PANACHE","BACKSTAB SLICE LEADING_STRIKE FLASH_OF_STEEL","FINISHER STRANGLE AFTERIMAGE SERPENT_FORM"),
            new("SILENT","保留蓄势","保留","WELL_LAID_PLANS PREDATOR BULLET_TIME","BACKFLIP BURST SKEWER ESCAPE_PLAN EXPERTISE SIDESTEP NIGHTMARE FLECHETTES STORM_OF_STEEL","WELL_LAID_PLANS PREDATOR BACKFLIP EXPERTISE","BULLET_TIME SKEWER FLECHETTES"),
            new("DEFECT","闪电输出","闪电球,闪电","BALL_LIGHTNING ZAP STORM","CAPACITOR DUALCAST BARRAGE COMPILE_DRIVER LIGHTNING_ROD TEMPEST TESLA_COIL THUNDER VOLTAIC","ZAP BALL_LIGHTNING STORM TEMPEST","DUALCAST BARRAGE COMPILE_DRIVER THUNDER"),
            new("DEFECT","冰霜防御","冰霜,防御球","GLACIER COOLHEADED COLD_SNAP","CHILL DEFRAGMENT LOOP DUALCAST ECHO_FORM BARRAGE HAILSTORM ICE_LANCE HOTFIX FOCUSED_STRIKE CAPACITOR","GLACIER COOLHEADED COLD_SNAP CHILL","DEFRAGMENT LOOP BARRAGE HAILSTORM"),
            new("DEFECT","集中强化","集中,能力牌","DEFRAGMENT CAPACITOR BIASED_COGNITION","GLACIER COOLHEADED BALL_LIGHTNING LOOP HOTFIX FOCUSED_STRIKE SYNCHRONIZE RAINBOW SIGNAL_BOOST","GLACIER COOLHEADED BALL_LIGHTNING RAINBOW","DEFRAGMENT LOOP FOCUSED_STRIKE HOTFIX SYNCHRONIZE"),
            new("DEFECT","黑暗蓄能","黑暗","DARKNESS LOOP MULTI_CAST","DUALCAST GLACIER COOLHEADED CAPACITOR SHATTER SHADOW_SHIELD NULL CONSUMING_SHADOW DEFRAGMENT MODDED QUADCAST","DARKNESS CONSUMING_SHADOW","DUALCAST MULTI_CAST LOOP QUADCAST"),
            new("DEFECT","充能球连锁","球位,触发,连锁,混合","MULTI_CAST DUALCAST RAINBOW","CAPACITOR COOLHEADED BALL_LIGHTNING GLACIER CHAOS GLASSWORK COOLANT SYNCHRONIZE SHATTER QUADCAST","RAINBOW COOLHEADED BALL_LIGHTNING GLACIER CHAOS GLASSWORK","DUALCAST MULTI_CAST QUADCAST"),
            new("DEFECT","零费回收","零费,过牌","CLAW ALL_FOR_ONE SCRAPE","HOLOGRAM OVERCLOCK SKIM GO_FOR_THE_EYES FLASH_OF_STEEL FINESSE FERAL FTL BEAM_CELL MOMENTUM_STRIKE","CLAW GO_FOR_THE_EYES FLASH_OF_STEEL BEAM_CELL FTL","ALL_FOR_ONE SCRAPE HOLOGRAM"),
            new("NECROBINDER","召唤攻击","攻击,奥斯蒂参与","BODYGUARD UNLEASH POKE","RIGHT_HAND_HAND FETCH AFTERLIFE CALCIFY FLATTEN RATTLE SQUEEZE SIC_EM HIGH_FIVE","BODYGUARD AFTERLIFE","UNLEASH POKE RIGHT_HAND_HAND FLATTEN SIC_EM"),
            new("NECROBINDER","召唤防守","承担,稳定性,稳定,承担压力","BODYGUARD REANIMATE AFTERLIFE","PULL_AGGRO NECRO_MASTERY INVOKE SPUR SACRIFICE CLEANSE MELANCHOLY SIC_EM DIRGE","BODYGUARD REANIMATE AFTERLIFE DIRGE","PULL_AGGRO SACRIFICE SIC_EM"),
            new("NECROBINDER","灾厄积累","末日,灾厄,逐步积累","SCOURGE NO_ESCAPE COUNTDOWN","DEATHBRINGER SHROUD TIMES_UP END_OF_DAYS NEGATIVE_PULSE DEATHS_DOOR OBLIVION SLEIGHT_OF_FLESH","SCOURGE NO_ESCAPE COUNTDOWN NEGATIVE_PULSE","SHROUD DEATHS_DOOR END_OF_DAYS"),
            new("NECROBINDER","召唤与灾厄","混合","BODYGUARD SCOURGE SHROUD","NO_ESCAPE DEATHBRINGER AFTERLIFE RIGHT_HAND_HAND NEGATIVE_PULSE DEATHS_DOOR PULL_AGGRO SPUR","BODYGUARD SCOURGE NO_ESCAPE NEGATIVE_PULSE","SHROUD RIGHT_HAND_HAND PULL_AGGRO"),
            new("NECROBINDER","持续召唤","支援,召唤,持续","INVOKE NECRO_MASTERY AFTERLIFE","BODYGUARD RIGHT_HAND_HAND REANIMATE FETCH GRAVE_WARDEN HAUNT DIRGE DEVOUR_LIFE SEVERANCE SIC_EM CAPTURE_SPIRIT","AFTERLIFE BODYGUARD DIRGE GRAVE_WARDEN","NECRO_MASTERY RIGHT_HAND_HAND SIC_EM"),
            new("REGENT","辉星爆发","辉星,集中输出","VENERATE ROYAL_GAMBLE COMET","GENESIS METEOR_SHOWER RADIATE CHILD_OF_THE_STARS GLOW GATHER_LIGHT HIDDEN_CACHE SOLAR_STRIKE BLACK_HOLE","VENERATE ROYAL_GAMBLE GLOW GENESIS","COMET RADIATE METEOR_SHOWER"),
            new("REGENT","君王之剑","铸剑,铸造","REFINE_BLADE THE_SMITH SUMMON_FORTH","FURNACE SWORD_SAGE SPOILS_OF_BATTLE SEEKING_EDGE WROUGHT_IN_WAR CONQUEROR BEAT_INTO_SHAPE BULWARK BIG_BANG","REFINE_BLADE SUMMON_FORTH FURNACE BULWARK","THE_SMITH SWORD_SAGE SEEKING_EDGE CONQUEROR"),
            new("REGENT","辉星续航","余量,保留,续航,高费","GENESIS CHILD_OF_THE_STARS VENERATE","BLACK_HOLE GLOW RADIATE CLOAK_OF_STARS GATHER_LIGHT HIDDEN_CACHE SOLAR_STRIKE ALIGNMENT PARTICLE_WALL","VENERATE GENESIS GLOW ROYAL_GAMBLE","RADIATE CLOAK_OF_STARS BLACK_HOLE PARTICLE_WALL"),
            new("REGENT","低费过渡","低费","GLOW VENERATE FALLING_STAR","PARTICLE_WALL COLLISION_COURSE PHOTON_CUT CLOAK_OF_STARS PALE_BLUE_DOT MAKE_IT_SO LUNAR_BLAST MONOLOGUE FLASH_OF_STEEL","GLOW VENERATE","FALLING_STAR COLLISION_COURSE PARTICLE_WALL"),
            new("REGENT","铸剑防守","铸剑与防御,防御并行,防守","PARRY REFINE_BLADE BULWARK","FURNACE SUMMON_FORTH SPOILS_OF_BATTLE THE_SMITH SWORD_SAGE WROUGHT_IN_WAR BIG_BANG BEAT_INTO_SHAPE SEEKING_EDGE CONQUEROR","REFINE_BLADE BULWARK FURNACE","PARRY SWORD_SAGE SEEKING_EDGE"),
            new("FOOL","瞄准重射","瞄准,沉重","NOCK HEAVY_SHOT ARCHERY","BRACE RECALL QUICK_SHOT QUIVER HONING LOCKED_IN DISLIKE_YOU HOBBLING_SHOT SHOW_OFF","NOCK BRACE RECALL QUIVER","HEAVY_SHOT QUICK_SHOT HOBBLING_SHOT"),
            new("FOOL","箭矢周转","召回,箭袋,松脱,多次攻击,取箭","RECALL QUICK_SHOT WREST","QUIVER UPROOT HOBBLING_SHOT YAH ARROW_STAB TRICK_SHOT EPIC_RETRIEVAL BOW_SMACK SERRATED_ARROWS","QUICK_SHOT HOBBLING_SHOT TRICK_SHOT","RECALL WREST UPROOT"),
            new("FOOL","拉伸防守","拉伸,空窗","DEEP_STRETCH HIDDEN_ROOTS JEST","BOUNCE HOBBLING_SHOT HEAVY_SHOT NOCK BLOSSOM_SHOT CHO_KI WHISTLING_ARROWS CHO_READY","JEST BOUNCE DEEP_STRETCH","HIDDEN_ROOTS HEAVY_SHOT HOBBLING_SHOT"),
            new("FOOL","悲伤转化","悲伤,生长","BRIGHTEN_UP GROWTH ECSTASY","SELF_DEPRECATE ALL_IS_WELL JEST ENNUI ANGUISH RUMMAGE SORROWFUL_STRIKE MOURNING_BLOW CHO_KI","JEST ENNUI RUMMAGE SORROWFUL_STRIKE MOURNING_BLOW","ECSTASY GROWTH BRIGHTEN_UP"),
            new("FOOL","哇音强攻","哇牌","WAH_HAMMER WAH_SWEEP VIOLENT_CHORD","WAH_BLAST WAH_TOUCH RHYTHM_STRIKE WAH_SYMPHONY WAH_KI WAH_CHO CHO_CHORUS MOTIF","WAH_TOUCH WAH_SWEEP WAH_KI WAH_CHO","WAH_HAMMER RHYTHM_STRIKE VIOLENT_CHORD"),
            new("FOOL","啾音护身","啾牌,歌之道","SONG_PATH CHO_FIRM CHO_CHORUS","CHO_READY CHO_LIMBS HARMONIC_SHIELD MOTIF MELODIC_SHOT CHO_BARBS CHO_KI WAH_CHO WAH_CHO_KI LULLABY","CHO_FIRM CHO_READY CHO_KI CHO_LIMBS","SONG_PATH HARMONIC_SHIELD CHO_CHORUS"),
            new("FOOL","叽音蓄势","休止符,叽牌","KI_REST TUNE KI_VERSE","KI_WHIP KI_CHANT RHYTHM_STRIKE WAH_KI CHO_KI KI_HOP CHO_CHORUS CODA","KI_CHANT KI_HOP WAH_KI CHO_KI","KI_VERSE KI_WHIP RHYTHM_STRIKE"),
            new("FOOL","三种旋律","曲中意,三种旋律","MOTIF HARMONIC_SHIELD WAH_CHO_KI","CHO_KI WAH_KI LULLABY MELODIC_SHOT STEADY_CADENCE CODA KI_VERSE WAH_SYMPHONY CHO_CHORUS WAH_SWEEP CHO_READY KI_WHIP","CHO_KI WAH_KI WAH_CHO_KI CHO_READY","MOTIF HARMONIC_SHIELD CODA"),
            new("FOOL","悲伤与喜悦","喜悦,狂喜","PUNCH_OF_JOY ECSTASY JEST","ENNUI ALL_IS_WELL ANGUISH BRIGHTEN_UP GROWTH RUMMAGE SORROWFUL_STRIKE MOURNING_BLOW VITRIOL","JEST RUMMAGE ENNUI VITRIOL MOURNING_BLOW","PUNCH_OF_JOY ECSTASY BRIGHTEN_UP"),
    ];
private static readonly Dictionary<string,Plan[]> ByRole=Plans.GroupBy(x=>x.Role).ToDictionary(g=>g.Key,g=>g.ToArray());
private static readonly int[][] Styles=[
        [0,1,2,3,4,5,0,1,0,2,1,4,5,1,5,3,0,2],
        [0,1,2,3,4,5,3,1,2,4,5,2,0,1,2,1,4,3],
        [0,1,2,3,4,5,0,1,2,4,3,5,5,4,2,1,4,2],
        [0,1,2,3,4,1,4,2,0,1,3,1,4,0,2,4,2,4],
        [0,1,2,3,4,2,0,1,2,3,1,0,2,4,2,4,2,1],
        [0,1,1,4,2,3,0,0,1,1,1,2,5,6,2,8,2,7],
    ];
```

<a id="symbol-cd70b308c5e8"></a>

## `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string) — private static bool Has(Dictionary<string,int> deck,string ids)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)

**调用：** `string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(char, System.StringSplitOptions)`；输入表达式：`ids.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Split(' ').Any`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.Split(' ').Any(deck.ContainsKey)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>ids.Split(' ').Any(deck.ContainsKey)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3d135612b1a"></a>

## `NationalSpire.LeagueArchetypes.Pair(string, string) — private static Pairing Pair(string sources,string uses)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.LeagueArchetypes.Pairing.Pairing(System.Collections.Generic.HashSet<string>, System.Collections.Generic.HashSet<string>)`；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueArchetypes.Pairing.Pairing(System.Collections.Generic.HashSet<string>, System.Collections.Generic.HashSet<string>)`；输入表达式：`new(sources.Split(' ').ToHashSet(),uses.Split(' ').ToHashSet())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>new(sources.Split(' ').ToHashSet(),uses.Split(' ').ToHashSet())`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`sources.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sources.Split(' ').ToHashSet`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`uses.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: uses.Split(' ').ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`sources.Split(' ').ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: sources.Split(' ').ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`uses.Split(' ').ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: uses.Split(' ').ToHashSet()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2806ebbec6ce"></a>

## `NationalSpire.LeagueArchetypes.HasPartner(string, System.Collections.Generic.Dictionary<string, int>) — internal static bool HasPartner(string id,Dictionary<string,int> deck)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Pairing.Sources`；`NationalSpire.LeagueArchetypes.PartnersByCard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PartnersByCard.TryGetValue(id,out var pair)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PartnersByCard.TryGetValue(id,out var pair)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`pair.Sources.Any(deck.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: !PartnersByCard.TryGetValue(id,out var pair)||pair.Sources.Any(deck.ContainsKey)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4a2f709b2968"></a>

## `NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>) — internal static bool CanSupportAnother(string id,Dictionary<string,int> deck)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`](LeagueLegendDraft.cs.md#symbol-c210ac44d176)；[`Supply(System.Collections.Generic.HashSet<string>, int, bool)`](LeagueLadder.cs.md#symbol-62785f74805d)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Pairing.Sources`；`NationalSpire.LeagueArchetypes.Pairing.Uses`；`NationalSpire.LeagueArchetypes.PartnersByCard`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PartnersByCard.TryGetValue(id,out var pair)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PartnersByCard.TryGetValue(id,out var pair)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`pair.Sources.Sum(k=>deck.GetValueOrDefault(k))`；返回值紧邻使用处：`BinaryExpressionSyntax: pair.Sources.Sum(k=>deck.GetValueOrDefault(k))>pair.Uses.Sum(k=>deck.GetValueOrDefault(k))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`pair.Uses.Sum(k=>deck.GetValueOrDefault(k))`；返回值紧邻使用处：`BinaryExpressionSyntax: pair.Sources.Sum(k=>deck.GetValueOrDefault(k))>pair.Uses.Sum(k=>deck.GetValueOrDefault(k))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(k)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: k=>deck.GetValueOrDefault(k)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0609e465e6ba"></a>

## `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>) — internal static bool Enabled(string id,Dictionary<string,int> deck)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Counts(string)`](LeagueLadder.cs.md#symbol-46ae9fc8bdac)；[`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)；[`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)

**调用：** [`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)；[`NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`](LeagueArchetypes.cs.md#symbol-cd70b308c5e8)；[`NationalSpire.LeagueArchetypes.HasPartner(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-2806ebbec6ce)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；`NationalSpire.LeagueArchetypes.HasPartner(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Model`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`Enabled("WREST",deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: Enabled("WREST",deck)&&Has(deck,"WREST RECALL UPROOT")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"BIG_BANG GLOW ROYAL_GAMBLE VENERATE GENESIS")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "ALIGNMENT" or "DECISIONS_DECISIONS"=>Has(deck,"BIG_BANG GLOW ROYAL_GAMBLE VENERATE GENESIS")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"BURNING_PACT TRUE_GRIT SECOND_WIND CORRUPTION EVIL_EYE")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "DARK_EMBRACE" or "FEEL_NO_PAIN"=>Has(deck,"BURNING_PACT TRUE_GRIT SECOND_WIND CORRUPTION EVIL_EYE")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"GLACIER COOLHEADED COLD_SNAP CHILL")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "LOOP" or "DEFRAGMENT"=>Has(deck,"GLACIER COOLHEADED COLD_SNAP CHILL")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"GLOW ROYAL_GAMBLE VENERATE GENESIS BIG_BANG")`；返回值紧邻使用处：`BinaryExpressionSyntax: Has(deck,"GLOW ROYAL_GAMBLE VENERATE GENESIS BIG_BANG")&&Has(deck,"RADIATE COMET COLLISION_COURSE PARTICLE_WALL CLOAK_OF_STARS ALIGNMENT")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"JEST ENNUI BRIGHTEN_UP MOURNING_BLOW SORROWFUL_STRIKE RUMMAGE VITRIOL")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "PUNCH_OF_JOY" or "ECSTASY"=>Has(deck,"JEST ENNUI BRIGHTEN_UP MOURNING_BLOW SORROWFUL_STRIKE RUMMAGE VITRIOL")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"QUICK_SHOT HEAVY_SHOT HOBBLING_SHOT MELODIC_SHOT")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "WREST"=>Has(deck,"QUICK_SHOT HEAVY_SHOT HOBBLING_SHOT MELODIC_SHOT")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"RADIATE COMET COLLISION_COURSE PARTICLE_WALL CLOAK_OF_STARS ALIGNMENT")`；返回值紧邻使用处：`BinaryExpressionSyntax: Has(deck,"GLOW ROYAL_GAMBLE VENERATE GENESIS BIG_BANG")&&Has(deck,"RADIATE COMET COLLISION_COURSE PARTICLE_WALL CLOAK_OF_STARS ALIGNMENT")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"REFINE_BLADE SUMMON_FORTH FURNACE BULWARK THE_SMITH SPOILS_OF_BATTLE")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "PARRY"=>Has(deck,"REFINE_BLADE SUMMON_FORTH FURNACE BULWARK THE_SMITH SPOILS_OF_BATTLE")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"SCOURGE NO_ESCAPE COUNTDOWN DEATHBRINGER NEGATIVE_PULSE OBLIVION")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "SHROUD"=>Has(deck,"SCOURGE NO_ESCAPE COUNTDOWN DEATHBRINGER NEGATIVE_PULSE OBLIVION")`
- `NationalSpire.LeagueArchetypes.Has(System.Collections.Generic.Dictionary<string, int>, string)`；输入表达式：`Has(deck,"WREST RECALL UPROOT")`；返回值紧邻使用处：`BinaryExpressionSyntax: Enabled("WREST",deck)&&Has(deck,"WREST RECALL UPROOT")`
- `NationalSpire.LeagueArchetypes.HasPartner(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`HasPartner(id,deck)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "TACTICIAN" or "REFLEX"=>HasPartner(id,deck)`
- `string.StartsWith(string)`；输入表达式：`k.StartsWith("CHO_")`；返回值紧邻使用处：`BinaryExpressionSyntax: k.StartsWith("WAH_")||k.StartsWith("KI_")||k.StartsWith("CHO_")`
- `string.StartsWith(string)`；输入表达式：`k.StartsWith("CHO_")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: k=>k.StartsWith("CHO_")`
- `string.StartsWith(string)`；输入表达式：`k.StartsWith("KI_")`；返回值紧邻使用处：`BinaryExpressionSyntax: k.StartsWith("WAH_")||k.StartsWith("KI_")`
- `string.StartsWith(string)`；输入表达式：`k.StartsWith("WAH_")`；返回值紧邻使用处：`BinaryExpressionSyntax: k.StartsWith("WAH_")||k.StartsWith("KI_")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Any(p=>LeagueCards.Catalog[p.Key].Model.EnergyCost.Canonical>=2)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "DANSE_MACABRE"=>deck.Any(p=>LeagueCards.Catalog[p.Key].Model.EnergyCost.Canonical>=2)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Keys.Any(k=>k.StartsWith("CHO_"))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "SONG_PATH"=>deck.Keys.Any(k=>k.StartsWith("CHO_"))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Keys.Any(k=>k.StartsWith("WAH_")||k.StartsWith("KI_")||k.StartsWith("CHO_"))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "MOTIF" or "KI_VERSE"=>deck.Keys.Any(k=>k.StartsWith("WAH_")||k.StartsWith("KI_")||k.StartsWith("CHO_"))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8cffe8f79fa2"></a>

## `NationalSpire.LeagueArchetypes.Resolve(string, string) — internal static Plan Resolve(string role,string style)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-8456a000aa0c)；[`NationalSpire.LeagueArchetypes.Name(string, string)`](LeagueArchetypes.cs.md#symbol-eed6465b998c)；[`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；[`NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`](LeagueNativeMatch.cs.md#symbol-a60b957088cc)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.NpcCharacters.Index(string)`](NpcCharacters.cs.md#symbol-8f7f43f17d89)；[`NationalSpire.WorldPeople.StyleIndex(int, string)`](WorldPeople.cs.md#symbol-96edbe6fcf7d)；`string.Contains(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LeagueArchetypes.ByRole`；`NationalSpire.LeagueArchetypes.Plan.Keys`；`NationalSpire.LeagueArchetypes.Styles`；`NationalSpire.NpcCharacters.Index(string)`；`NationalSpire.WorldPeople.StyleIndex(int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(style)`；返回值紧邻使用处：`CastExpressionSyntax: (uint)CareerEngine.StableHash(style)`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(role)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =NpcCharacters.Index(role)`
- `NationalSpire.WorldPeople.StyleIndex(int, string)`；输入表达式：`WorldPeople.StyleIndex(character,style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =WorldPeople.StyleIndex(character,style)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`style.Contains(k,StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: k=>style.Contains(k,StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`best.Keys.Any(style.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: best!=null&&best.Keys.Any(style.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`choices.MaxBy(p=>p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal)).Sum(k=>k.Length))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =choices.MaxBy(p=>p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal)).Sum(k=>k.Length))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal)).Sum(k=>k.Length)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal)).Sum(k=>k.Length)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal)).Sum`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eed6465b998c"></a>

## `NationalSpire.LeagueArchetypes.Name(string, string) — internal static string Name(string role,string style)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.LeagueSeasonRoster.Prepare(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](LeagueSeasonRoster.cs.md#symbol-b1e9bbf26da3)

**调用：** [`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Plan.Title`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`Resolve(role,style)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Resolve(role,style).Title`

**赋值（含属性/字段和局部值）：**
