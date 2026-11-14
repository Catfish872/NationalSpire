namespace NationalSpire;

internal static class LeagueArchetypes
{
    internal sealed record Plan(string Role,string Title,string Terms,string Core,string Support){
        internal readonly string[] Keys=Terms.Split(',');
        internal readonly string[] Anchors=Core.Split(' '), Partners=Support.Split(' ');
    }
    internal sealed class Engine(string draw,string energy){
        internal readonly HashSet<string> Draw=(draw+" FLASH_OF_STEEL FINESSE MASTER_OF_STRATEGY THINKING_AHEAD").Split(' ').ToHashSet();
        internal readonly HashSet<string> Energy=(energy+" PRODUCTION DISCOVERY").Split(' ').ToHashSet();
    }
    internal static readonly Dictionary<string,Engine> Engines=new(){
        ["IRONCLAD"]=new("POMMEL_STRIKE SHRUG_IT_OFF BATTLE_TRANCE BURNING_PACT OFFERING DARK_EMBRACE","OFFERING BLOODLETTING PYRE HAVOC CORRUPTION"),
        ["SILENT"]=new("BACKFLIP ACROBATICS ESCAPE_PLAN PREPARED ADRENALINE REFLEX","ADRENALINE TACTICIAN BULLET_TIME"),
        ["DEFECT"]=new("COOLHEADED SKIM OVERCLOCK MACHINE_LEARNING","TURBO CHARGE_BATTERY AGGREGATE DOUBLE_ENERGY"),
        ["NECROBINDER"]=new("CAPTURE_SPIRIT PARSE GLIMPSE_BEYOND GRAVE_WARDEN REAVE NEUROSURGE","WISP BORROWED_TIME INVOKE NEUROSURGE"),
        ["REGENT"]=new("GLIMMER PROPHESIZE BIG_BANG GLOW DECISIONS_DECISIONS","BIG_BANG ALIGNMENT ORBIT DECISIONS_DECISIONS"),
        ["FOOL"]=new("RUMMAGE KI_CHANT ENNUI MOTIF WREST PUNCH_OF_JOY ECSTASY BRIGHTEN_UP","KI_REST ENCORE YAH KI_VERSE PUNCH_OF_JOY ECSTASY BRIGHTEN_UP")};
    private static bool Has(Dictionary<string,int> deck,string ids)=>ids.Split(' ').Any(deck.ContainsKey);
    // 固定的三张防御之外，区分立即救场与能反复提供防守的配合。
    internal static readonly Dictionary<string,(string Guard,string Sustain)> Defense=new(){
        ["IRONCLAD"]=("SHRUG_IT_OFF TRUE_GRIT EVIL_EYE FLAME_BARRIER IRON_WAVE IMPERVIOUS","FEEL_NO_PAIN UNMOVABLE BARRICADE"),
        ["SILENT"]=("BACKFLIP LEG_SWEEP CLOAK_AND_DAGGER DODGE_AND_ROLL DEFLECT","FOOTWORK AFTERIMAGE WRAITH_FORM"),
        ["DEFECT"]=("LEAP GLACIER COOLHEADED COLD_SNAP CHILL CHARGE_BATTERY","GLACIER LOOP DEFRAGMENT"),
        ["NECROBINDER"]=("GRAVE_WARDEN BONE_SHARDS BODYGUARD NEGATIVE_PULSE DELAY","SHROUD DANSE_MACABRE AFTERLIFE"),
        ["REGENT"]=("GATHER_LIGHT BULWARK PARTICLE_WALL CLOAK_OF_STARS","PARRY NEUTRON_AEGIS CHILD_OF_THE_STARS"),
        ["FOOL"]=("JEST BOUNCE CHO_FIRM CHO_READY HARMONIC_SHIELD","DEEP_STRETCH HIDDEN_ROOTS SONG_PATH")};
    // 只有牌组已经提供触发条件时，才把条件收益计入运转名额。
    internal static bool Enabled(string id,Dictionary<string,int> deck)=>id switch{
        "DARK_EMBRACE" or "FEEL_NO_PAIN"=>Has(deck,"BURNING_PACT TRUE_GRIT SECOND_WIND CORRUPTION EVIL_EYE"),
        "LOOP" or "DEFRAGMENT"=>Has(deck,"GLACIER COOLHEADED COLD_SNAP CHILL"),
        "SHROUD"=>Has(deck,"SCOURGE NO_ESCAPE COUNTDOWN DEATHBRINGER NEGATIVE_PULSE"),
        "DANSE_MACABRE"=>deck.Any(p=>LeagueCards.Catalog[p.Key].Model.EnergyCost.Canonical>=2),
        "PARRY"=>Has(deck,"REFINE_BLADE SUMMON_FORTH FURNACE BULWARK THE_SMITH SPOILS_OF_BATTLE"),
        "CHILD_OF_THE_STARS"=>Has(deck,"GLOW ROYAL_GAMBLE VENERATE GENESIS BIG_BANG")&&Has(deck,"RADIATE COMET COLLISION_COURSE PARTICLE_WALL CLOAK_OF_STARS ALIGNMENT"),
        "PUNCH_OF_JOY" or "ECSTASY"=>Has(deck,"JEST ENNUI BRIGHTEN_UP MOURNING_BLOW"),
        "SONG_PATH"=>deck.Keys.Any(k=>k.StartsWith("CHO_")),
        "TACTICIAN" or "REFLEX"=>Has(deck,"ACROBATICS PREPARED CALCULATED_GAMBLE DAGGER_THROW TOOLS_OF_THE_TRADE"),
        "ALIGNMENT" or "DECISIONS_DECISIONS"=>Has(deck,"BIG_BANG GLOW ROYAL_GAMBLE VENERATE GENESIS"),
        "MOTIF" or "KI_VERSE"=>deck.Keys.Any(k=>k.StartsWith("WAH_")||k.StartsWith("KI_")||k.StartsWith("CHO_")),
        "WREST"=>Has(deck,"QUICK_SHOT HEAVY_SHOT HOBBLING_SHOT MELODIC_SHOT"),
        "YAH"=>Enabled("WREST",deck)&&Has(deck,"WREST RECALL UPROOT"),_=>true};
    private static readonly Plan[] Plans=[
            new("IRONCLAD","力量重击","力量,高伤,高费","INFLAME DEMON_FORM PRIMAL_FORCE","BLUDGEON UPPERCUT POMMEL_STRIKE SHRUG_IT_OFF"),
            new("IRONCLAD","消耗精简","消耗,精简,去留","BURNING_PACT TRUE_GRIT DARK_EMBRACE","FEEL_NO_PAIN CORRUPTION SECOND_WIND EVIL_EYE ASHEN_STRIKE FINESSE FLASH_OF_STEEL"),
            new("IRONCLAD","生命交换","生命交换,续航,生命余量","BLOODLETTING HEMOKINESIS RUPTURE","CRUELTY OFFERING BLOOD_WALL SHRUG_IT_OFF"),
            new("IRONCLAD","格挡反击","格挡,防御","BODY_SLAM BARRICADE SHRUG_IT_OFF","IMPERVIOUS FLAME_BARRIER IRON_WAVE UNMOVABLE"),
            new("IRONCLAD","力量连击","多次攻击,多段","INFLAME ONE_TWO_PUNCH SWORD_BOOMERANG","WHIRLWIND TWIN_STRIKE POMMEL_STRIKE SHRUG_IT_OFF"),
            new("IRONCLAD","锻造强攻","升级,可靠攻击","ARMAMENTS AGGRESSION PERFECTED_STRIKE","POMMEL_STRIKE HEADBUTT TWIN_STRIKE IRON_WAVE"),
            new("SILENT","毒素积累","中毒,毒素","DEADLY_POISON BOUNCING_FLASK ACCELERANT","NOXIOUS_FUMES CORROSIVE_WAVE BUBBLE_BUBBLE BACKFLIP LEG_SWEEP"),
            new("SILENT","弃牌周转","弃牌,过牌","ACROBATICS TACTICIAN REFLEX","PREPARED CALCULATED_GAMBLE DAGGER_THROW TOOLS_OF_THE_TRADE UNTOUCHABLE FLICK_FLACK MEMENTO_MORI"),
            new("SILENT","小刀连击","小刀,连续出牌,多次出牌","BLADE_DANCE ACCURACY CLOAK_AND_DAGGER","INFINITE_BLADES AFTERIMAGE FINISHER BACKFLIP"),
            new("SILENT","守势用毒","稳定防守,格挡与中毒","BACKFLIP DEADLY_POISON LEG_SWEEP","DODGE_AND_ROLL FOOTWORK NOXIOUS_FUMES ACCELERANT"),
            new("SILENT","低费快攻","低费,攻击积极","BACKSTAB SLICE FINISHER","ADRENALINE DEFLECT DAGGER_THROW BACKFLIP FLASH_OF_STEEL"),
            new("SILENT","保留蓄势","保留","WELL_LAID_PLANS PREDATOR BULLET_TIME","BACKFLIP BURST SKEWER ESCAPE_PLAN"),
            new("DEFECT","闪电输出","闪电球,闪电","BALL_LIGHTNING ZAP STORM","CAPACITOR DUALCAST BARRAGE COMPILE_DRIVER"),
            new("DEFECT","冰霜防御","冰霜,防御球","GLACIER COOLHEADED COLD_SNAP","CHILL DEFRAGMENT LOOP DUALCAST ECHO_FORM BARRAGE HAILSTORM"),
            new("DEFECT","集中强化","集中,能力牌","DEFRAGMENT CAPACITOR BIASED_COGNITION","GLACIER COOLHEADED BALL_LIGHTNING LOOP"),
            new("DEFECT","黑暗蓄能","黑暗","DARKNESS LOOP MULTI_CAST","DUALCAST GLACIER COOLHEADED CAPACITOR SHATTER"),
            new("DEFECT","充能球连锁","球位,触发,连锁,混合","MULTI_CAST DUALCAST RAINBOW","CAPACITOR COOLHEADED BALL_LIGHTNING GLACIER"),
            new("DEFECT","零费回收","零费,过牌","CLAW ALL_FOR_ONE SCRAPE","HOLOGRAM OVERCLOCK SKIM GO_FOR_THE_EYES FLASH_OF_STEEL FINESSE"),
            new("NECROBINDER","召唤攻击","攻击,奥斯蒂参与","BODYGUARD UNLEASH POKE","RIGHT_HAND_HAND FETCH BONE_SHARDS AFTERLIFE"),
            new("NECROBINDER","召唤防守","承担,稳定性,稳定,承担压力","BODYGUARD REANIMATE AFTERLIFE","PULL_AGGRO NECRO_MASTERY INVOKE SPUR"),
            new("NECROBINDER","灾厄积累","末日,灾厄,逐步积累","SCOURGE NO_ESCAPE COUNTDOWN","DEATHBRINGER SHROUD TIMES_UP END_OF_DAYS"),
            new("NECROBINDER","召唤与灾厄","混合","BODYGUARD SCOURGE SHROUD","NO_ESCAPE DEATHBRINGER AFTERLIFE RIGHT_HAND_HAND"),
            new("NECROBINDER","持续召唤","支援,召唤,持续","INVOKE NECRO_MASTERY AFTERLIFE","BODYGUARD RIGHT_HAND_HAND REANIMATE FETCH GRAVE_WARDEN HAUNT SOUL_STORM"),
            new("REGENT","辉星爆发","辉星,集中输出","VENERATE ROYAL_GAMBLE COMET","GENESIS METEOR_SHOWER RADIATE CHILD_OF_THE_STARS"),
            new("REGENT","君王之剑","铸剑,铸造","REFINE_BLADE THE_SMITH SUMMON_FORTH","FURNACE SWORD_SAGE SPOILS_OF_BATTLE SEEKING_EDGE"),
            new("REGENT","辉星续航","余量,保留,续航,高费","GENESIS CHILD_OF_THE_STARS VENERATE","BLACK_HOLE GLOW RADIATE CLOAK_OF_STARS"),
            new("REGENT","低费过渡","低费","GLOW VENERATE FALLING_STAR","PARTICLE_WALL COLLISION_COURSE PHOTON_CUT CLOAK_OF_STARS"),
            new("REGENT","铸剑防守","铸剑与防御,防御并行,防守","PARRY REFINE_BLADE BULWARK","FURNACE SUMMON_FORTH SPOILS_OF_BATTLE THE_SMITH SWORD_SAGE"),
            new("FOOL","瞄准重射","瞄准,沉重","NOCK HEAVY_SHOT ARCHERY","BRACE RECALL QUICK_SHOT QUIVER"),
            new("FOOL","箭矢周转","召回,箭袋,松脱,多次攻击,取箭","RECALL QUICK_SHOT WREST","QUIVER UPROOT HOBBLING_SHOT YAH"),
            new("FOOL","拉伸防守","拉伸,空窗","DEEP_STRETCH HIDDEN_ROOTS JEST","BOUNCE HOBBLING_SHOT HEAVY_SHOT NOCK"),
            new("FOOL","悲伤转化","悲伤,生长","BRIGHTEN_UP GROWTH ECSTASY","SELF_DEPRECATE ALL_IS_WELL JEST ENNUI"),
            new("FOOL","哇音强攻","哇牌","WAH_HAMMER WAH_SWEEP VIOLENT_CHORD","WAH_BLAST WAH_TOUCH RHYTHM_STRIKE"),
            new("FOOL","啾音护身","啾牌,歌之道","SONG_PATH CHO_FIRM CHO_CHORUS","CHO_READY CHO_LIMBS HARMONIC_SHIELD MOTIF MELODIC_SHOT"),
            new("FOOL","叽音蓄势","休止符,叽牌","KI_REST TUNE KI_VERSE","KI_WHIP KI_CHANT RHYTHM_STRIKE"),
            new("FOOL","三种旋律","曲中意,三种旋律","MOTIF HARMONIC_SHIELD WAH_CHO_KI","CHO_KI WAH_KI LULLABY MELODIC_SHOT"),
            new("FOOL","悲伤与喜悦","喜悦,狂喜","PUNCH_OF_JOY ECSTASY JEST","ENNUI ALL_IS_WELL ANGUISH BRIGHTEN_UP GROWTH"),
    ];
    private static readonly Dictionary<string,Plan[]> ByRole=Plans.GroupBy(x=>x.Role).ToDictionary(g=>g.Key,g=>g.ToArray());
    // 顺序对应 WorldPeople 的六条基础偏好及十二条扩充偏好；自定义档案按实际文字匹配。
    private static readonly int[][] Styles=[
        [0,1,2,3,4,5,0,1,0,2,1,4,5,1,5,3,0,2],
        [0,1,2,3,4,5,3,1,2,4,5,2,0,1,2,1,4,3],
        [0,1,2,3,4,5,0,1,2,4,3,5,5,4,2,1,4,2],
        [0,1,2,3,4,1,4,2,0,1,3,1,4,0,2,4,2,4],
        [0,1,2,3,4,2,0,1,2,3,1,0,2,4,2,4,2,1],
        [0,1,1,4,2,3,0,0,1,1,1,2,5,6,2,8,2,7],
    ];
    internal static Plan Resolve(string role,string style){
        var choices=ByRole[role];int character=NpcCharacters.Index(role),index=WorldPeople.StyleIndex(character,style);
        if(index>=0&&index<Styles[character].Length)return choices[Styles[character][index]];
        var best=choices.MaxBy(p=>p.Keys.Where(k=>style.Contains(k,StringComparison.Ordinal)).Sum(k=>k.Length));
        return best!=null&&best.Keys.Any(style.Contains)?best:choices[(int)((uint)CareerEngine.StableHash(style)%choices.Length)];
    }
    internal static string Name(string role,string style)=>Resolve(role,style).Title;
}
