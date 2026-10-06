namespace NationalSpire;

/// <summary>参赛 ID 与人物主键、姓名分别保存，转会及退役沿用原 ID。</summary>
public static class PlayerIdentity
{
    public const int Version = 5;
    private static readonly Dictionary<string, string> Translated = new(StringComparer.Ordinal);
    private static readonly Dictionary<string, string[]> LocalNames = new()
    {
        ["中国"] = "折枝 听潮 白榆 砚北 夜航 归鸿 长夏 半拍 鹤川 青岚 灯芯 山雀 野渡 迟墨 雨停 乌龙 山外 鱼白 未央 临界 远山 照野 溪午 满弦 藏锋 星垂 无眠 逐鹿 南烛 怀谷 风筝 岩盐 纸鸢 凉月 漫游 澄空 镜湖 雁回 薄荷 小满 千帆 破晓 白露 苍耳 飞絮 尘光 失重 燕麦 无隅 微澜 琥珀 一横 九霄 帆影 青柠 云隙 逆旅 无声 鹭洲 候鸟 晴川 木槿 棋子 冷萃 青瓦 轻舟 远岫 月蚀 留白 北纬 凛冬 啄木 音阶 平仄 寒枝 向晚 临风 山止 见微 不二 浮生 戏鱼 十七 此间 沉舟 澈然 竹里 空青 玄鸟 行简 桑落 灯塔 天青 桔梗 浅滩 凌波 墨池 雾港 回响".Split(' '),
        ["日本"] = "しぐれ こはく ツバメ 朔夜 あまね カゲロウ ひばり なぎさ 霧雨 すばる かなた 白夜 ゆらぎ いぶき ハルカ 十六夜 すずめ あさぎ シオン ほたる 水鏡 みなも つむぎ ヨル きさらぎ うたたね 紅葉 くろねこ うぐいす しずく カナリア 灯火 あおば ゆきね アカツキ さざなみ こよみ さくらもち ふゆの ヒスイ 銀河 うつろ まひる モノクロ ひなた おぼろ いろは キリサメ 月影 らせん こだま ネムリ つばき わたあめ うみねこ せつな ヤマネ 青磁 なゆた よすが カラス たそがれ あずき ひかり こもれび アオイ さかさま くおん クローバー 凪 みかづき あかり しらす はやて コトリ ましろ かすみ リンドウ さとり うるは".Split(' '),
        ["韩国"] = "새벽 여울 달빛 노을 하늘 은하 바람 소나기 서리 구름 파도 이슬 별숲 잔향 나루 겨울 바다 온유 해솔 다온 푸름 여름 초승달 백야 도깨비 미르 시나브로 여우 모래 산들 나비 라온 윤슬 해오름 한울 보름달 달무리 소금 보리 새봄 초록 낙엽 메아리 가람 고요 여명 수평선 물결 한별 유성 까치 안개 빛결 은빛 도토리 피리 봄비 별하 솔잎 단풍 새벽별 하늬 달보드레 푸른밤 너울 흰눈 여백 호수 비상 물안개 작은별 겨울비 별무리 검은새 소담 강산 파랑 노랑 아침 햇살".Split(' '),
        ["德国"] = "Falkenflug Kiesel Abendrot Zunder Nebelwald Schachzug Lautlos Wirbelwind Mohn Schwarztee Fernweh Silberfuchs Glutstück Morgenstern Wildpfad Eiskante Hafenlicht Funkenflug Waldgeist Nachtzug Sturmvogel Kranich Sternwarte Bergfink Eisvogel Zeitlos Wellenritt Graureiher Grenzgang Freigeist Leuchtspur Kometenschweif Moorlicht Wolkenbruch Efeu Bernstein Regenbogen Tiefgang Zeitsprung Blaupause Widerschein Pfeilflug Seewind Schattenriss Glanzpunkt Rotkehlchen Abendsegler Schneefall Zaunkönig Nordlicht Kupferdraht Felsenfest Flugbahn Rosenholz Wintergast Dämmerung Lichtblick Sturmglas Salzkorn Weitblick".Split(' '),
        ["法国"] = "Équinoxe Luciole Brume Alouette Cendre Quartz Sillage Éclipse Minuit Aubépine Mirage Velours Frisson Aquarelle Aurore Liseron Canopée Écume Pivoine Mistral Cobalt Papillon Ardoise Orage CerfVolant Silhouette Caillou Boussole Grenat Hirondelle Lueur Nuage Élan FeuFollet Muscade Pénombre Azimut Hublot Zéphyr Saturne Ronce Pollen Nautile Galet Bivouac Balise Mésange Vertige Fougère Reflet Clairière Étincelle Corail Opaline Rivage Céleste Nocturne Tambour Sablier Domino".Split(' '),
        ["巴西"] = "Vagalume Garoa Sabiá Horizonte Faísca Maré Sertão Neblina Mandacaru Capivara Brisa Estrela Trovão Pitanga Raposa Orvalho Trilha Ipê Cajueiro Sombra Arara Samba Raiz Luar Cascata Flecha Farol Centelha Jangada Jasmim Pontal VentoSul Sereno Tucano OndaLivre Andorinha Fagulha Bambu Relâmpago Mangue Cajá Carcará Cruzeiro Lince Prisma Alvorada Açucena Areia Girassol Xadrez Malícia Caju Tatu Mirante Rubi Violeta Fênix Canela Candeia Eclipse".Split(' '),
        ["英国"] = "Kestrel Foxglove Bracken Wicket Humbug Puddle Crumpet Rookery Nightjar Telltale Bramble Skylark Teacup Thistle Larkspur Dovetail Hearth Cobble Fern Kiln Pebble Turncoat Riddle Juniper Pippin Hawthorn Mariner Wren Lantern Badger Kipper Rowan Saffron Cricket Seabird Treacle Tundra Bellwether Hush Fathom Velvet Spindle Harrier Finch Copper Clifftop Wayfarer Hazel Magpie Borough Otter Parchment Celandine Archway Tern Lichen Driftwood Chaffinch Rook Snowdrop".Split(' '),
        ["美国"] = "Sidequest Afterhours Kickflip Lowkey Switchback Wildcard Firefly Redshift Outlier Sundial Shortcut Freefall Baseline Milkshake Hologram Matchstick Daybreak Jukebox Crosswind Echoes Paperplane Beeline PocketAce Softshell Tiebreak Flatline Roadrunner Halftone Snowcap Backbeat Fastlane Dustbowl Lockstep Glitchwork Bluejay Oddball Zipline Scrapbook Headwind Offbeat Cyclone Whiplash Heatwave Launchpad Moonshot Raincheck DiceRoll Daydream Wildfire Starlit Goldrush Ricochet Fieldwork Hightide Nightshift Glasswing Checkmate Motive Hardstop Parallax".Split(' ')
    };
    static PlayerIdentity()
    {
        var additions = new Dictionary<string, string>
        {
            ["中国"] = "长安客 小鱼干 纸飞机 零时差 不知秋 拾荒者 白日梦 第七弦 山海间 旧唱片 林间鹿 夜未央 风来信 无名氏 雨中曲 局外人 南风起 未完待续 月亮邮差 半糖冰茶 今天早睡 不期而遇 随便打打 周末限定 认真路过 昨夜长风 一叶知秋 藏在云里 单程车票 起名好难 空山来客 深夜便利店 最后一班车 还有一张牌 请叫我阿白 吃完这碗面 又忘带钥匙 明天不上班 猫在键盘上 不想起昵称 等一个晴天 想喝热可可 今天吃什么 风吹哪页读哪页 这次一定早睡 刚刚才热身 路过的普通人 我要这张白卡 别催在思考 已经在路上 雪落无声 留点能量 夜宵选手 一口乌龙 云游四海 靠窗座位 落日放映 过期胶卷 晚风来访 小岛电台 海盐汽水 此处留白 走走停停 不赶末班车 山顶有风 天台看月亮 三点半醒来 回合还没结束 再来一局就睡 十年磨一剑 空罐头 旧书签 小螺号 南瓜灯 蓝墨水 随风去 问归期 逆风行 余音在 柳叶刀 黄昏线 九分甜 夜航船 回声谷 白开水 一点点 早八人 阿七 大橘 再会 乘风 一瓢 清醒 枕流 自在 柒 凛 野 柚 Q糖 阿布07 小北_ 再见昨天 初见_3 二两月光 迟到五分钟 牌序随缘 山川慢慢 灯火可亲 手边有茶", 
            ["日本"] = "ねこまんま 夜ふかし もちもち ねむたい コーヒー牛乳 放課後 よりみち たまごやき 空き缶 かえる帰る あと一枚 月の裏側 夕焼け小焼け あした晴れ 雨宿り中 どらやき 靴ひも ひとやすみ 迷子の地図 きつねうどん まめだいふく おかわり 深夜ラジオ 風まかせ ゆっくり歩く ひつじ雲 となりのネコ まだ眠い しおむすび 青いしおり ねこ日和 みちくさ 三日坊主 ほうじ茶 こたつむり 花より団子 ミルクティー おひるね隊 さいごの一手 ひとくち つきあかり ソーダ水 クロネコ7 みずいろ_ 404ねこ まる01 しろくま便 夜明け前 夕立ち 銀のスプーン", 
            ["韩国"] = "밤산책 고양이발 낮잠중 커피한잔 달빛우체국 오늘도맑음 한판더 천천히걷기 마지막한장 길잃은참새 우유식빵 바람따라 구름다리 작은우산 잠깐만요 퇴근길 치즈고양이 파란연필 반달곰 기억상자 책갈피 별을세다 물방울소리 주말오후 라면먹자 졸린토끼 늦은편지 종이비행기 보라빛밤 귤한조각 빈의자 산책하는달 내일봐요 새벽두시 흰종이 단추하나 눈오는날 나무그늘 조용한숲 햇살한줌 노을사진 달토끼7 모카_02 구름404 하늘빛 빵한입 별자리표 오늘은휴식 우산속 둘이서", 
            ["德国"] = "Halbwach NochEinZug OhneZucker Kaffeepause Feierabend Kurvenlicht Stadtstreicher Regenschirm Wolkenzähler Nachtschicht Brotzeit Punktlandung Umweg Fundstück Würfelglück Zwischenraum Zugvogel Federleicht Altpapier Gegenlicht Satzzeichen Windstille Kaffeesatz Mondfahrt Spätzünder Funkstille Lesezeichen Schnellhefter Schneekugel Kreidekreis Blattsalat Warteschleife Zimmerpflanze Türspion Sonntagskind Leerlauf Streuselkuchen Landkarte Doppelklick Tintenfleck EinBisschenMeer BesserSpät Gleis7 nullacht halbsowild Pause_03 OhnePlan letzterVersuch Tapetenwechsel Unterwegs", 
            ["法国"] = "PetitMatin SansSucre EncoreUnTour ÀContretemps ChatDeGouttière DemiSommeil PainPerdu AuHasard PluieFine BoutDeFicelle LuneRousse DernierMétro GrainDeSel BleuNuit RienDeGrave TroisPetitsPoints CaféCrème PasPressé HorsPiste PommeDePin EnPassant PetitBiscuit ChatPerché SansBruit EntreDeux ToutDoux UnPeuTard ÀBientôt FausseNote LeCoinTranquille CarnetBleu AprèsMinuit PetitNuage VentDebout SousLaPluie CroqueLune ThéFroid ZéroSouci Dimanche ParIci NuitBlanche RueDesChats EncoreMoi PresquePrêt Lundi_7 Café404 sixièmeSens PetitCaillou SansFaçon AuRevoir", 
            ["巴西"] = "PãoDeQueijo CaféSemAçúcar SóMaisUma GatoDeBotas ChuvaMansa PéNaEstrada MeiaLua FimDeTarde SemPressa ViraLata DeBoa QuaseLá MãoLeve CantoDoMar PéDeVento SolDeInverno NoiteAdentro SóUmMinuto BomDePapo JogoVirado PingoDeChuva CaraDeSono ÚltimoCafé MaisOuMenos ReiDoSofá ArrozComFeijão TôChegando SemRoteiro MeuCantinho CantoLivre BoraLá LuaDePapel PassoCurto VentoNaCara FicaPraDepois GoleDeÁgua GatoNoturno DiaDeFolga NaSaideira TudoAzul PontoFinal RuaSemNome UmTanto FelizAcaso Caju_7 Cafézinho404 MaisUmDia TardeDemais NaMoral PéNoChão", 
            ["英国"] = "NotQuiteTea MindTheGap RainOnSunday BiscuitTin SpareChange JustPassing QuitePossibly HalfPastLate LostUmbrella TeaBeforeThree NearlyThere MildlyConcerned AnotherCuppa LastBusHome WrongPlatform PocketLint NoFixedPlan LittleDetour GardenGate SpareKey ProperSleep CheekyPigeon SpareBiscuit EarlyDoors OneMoreRound KettleOn SmallHours LateForTea InGoodTime Paperback CoastIsClear UnderTheWeather SecondBreakfast ByTheWindow BackInFive UnfinishedBusiness BestBeforeMaybe MidnightToast PostcardHome NotBadActually CloudCounter TinRoof LowerCase OakAndAsh QuietPlease LuckySocks NeedMoreTea seventh_tea 3AM_biscuit okaythen", 
            ["美国"] = "MostlyHarmless NotYetCoffee OneMoreTry SleepSchedule CtrlZ MaybeLater CasualTuesday LastSlice ExtraPickles PressAnyKey AlmostReady JustChillin IdleHands PizzaAtMidnight MissingSock PaperTiger WindowSeat TinyVictory NextExit LeftOnRead GoodEnough SmallPotato OpenTab AfterTheRain LateCheckout LuckyPenny ColdPizza PocketRocket EasyDoesIt StaticNoise OverEasy NoRush SpareBattery SideOfFries CoffeeFirst PatchNotes FriendlyFire PizzaTheory ZeroContext NapTime LoFiKid NightOwlClub ctrl_alt_nap byteSized 8bitMango NotFound404 room_312 just_vibing off_script beRightBack SilverLining SodaPop PocketUniverse SlowSunday AlmostMonday RetroKid BlinkTwice MoonToast"
        };
        foreach (var (country, names) in additions)
            LocalNames[country] = LocalNames[country].Concat(names.Split(' ', StringSplitOptions.RemoveEmptyEntries)).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
        foreach (var (country, translated) in ReadableHandles.Translations)
        {
            var original = LocalNames[country];
            if (original.Length != translated.Length) throw new InvalidOperationException(country + "昵称译名数量不匹配");
            for (int i = 0; i < original.Length; i++) Translated.TryAdd(original[i], translated[i]);
            LocalNames[country] = translated.Concat(ReadableHandles.ExtraNames[country]).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
        }
    }
    public static int HandlePoolSize => HumanNames.NameCount + HumanNames.WholeHandleCount;
    public static bool Eligible(CareerPerson p) => p.MaxAscension >= 6 || p.Role is "主播" or "教练" or "退役选手";
    public static void Ensure(CareerData data)
    {
        IdentityGender.Ensure(data);
        RegionalOrganizations.Ensure(data);
        if (data.IdentityVersion > 0 && data.IdentityVersion < 3)
        {
            var known = data.Results.Select(r => r.OpponentId)
                .Concat(data.Matches.Where(m => m.Registered || m.Status != "待赛").Select(m => m.OpponentId))
                .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))
                .Concat(data.CommunityMemories.SelectMany(m => m.People))
                .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People))))
                .ToHashSet();
            foreach (var p in data.People.Where(p => p.CameoId.Length == 0 && Eligible(p) && p.Handle.Length > 0 && !known.Contains(p.Id)))
            { if (!p.HandleAliases.Contains(p.Handle)) p.HandleAliases.Add(p.Handle); p.Handle = ""; }
        }
        if (data.IdentityVersion < Version)
        {
            var reserved = data.People.Select(p => p.Name).Concat(data.People.Select(p => p.Handle)).Concat(data.PlayerNameAliases).Append(CareerEngine.Name(data)).ToHashSet(StringComparer.OrdinalIgnoreCase);
            foreach (var p in data.People.Where(p => p.Country != "中国" && p.Handle.Length > 0).OrderBy(p => p.Id, StringComparer.Ordinal))
            {
                string original = p.Handle;
                if (!Translated.TryGetValue(original, out var translated))
                {
                    int end = original.Length;
                    while (end > 0 && char.IsAsciiDigit(original[end - 1])) end--;
                    if (end == original.Length || !Translated.TryGetValue(original[..end], out var stem)) continue;
                    translated = stem + original[end..];
                }
                if (translated == original) continue;
                string candidate = translated; int suffix = 2;
                while (!reserved.Add(candidate)) candidate = translated + suffix++;
                if (!p.HandleAliases.Contains(original)) p.HandleAliases.Add(original);
                p.Handle = candidate;
            }
            // 名称字段同步，已发表的原文保留；旧 ID 作为搜索别名和记忆中的身份对照。
            foreach (var snapshot in data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent))
                if (data.People.FirstOrDefault(p => p.Id == snapshot.Id) is { } person)
                { snapshot.Handle = person.Handle; snapshot.HandleAliases = person.HandleAliases.ToList(); }
            foreach (var result in data.Results)
                if (data.People.FirstOrDefault(p => p.Id == result.OpponentId) is { } person) result.Opponent = person.PublicName;
            foreach (var profile in data.WeeklyEditions.SelectMany(w => w.Profiles))
                if (data.People.FirstOrDefault(p => p.Id == profile.Id) is { } person) profile.Name = person.PublicName;
        }
        ContentPoolMigration.Refresh(data);
        foreach (var p in data.People.Where(p => p.CameoId.Length > 0 && p.Handle.Length == 0))
            if (CameoContent.People.FirstOrDefault(c => c.Key == p.CameoId) is { } cameo) p.Handle = cameo.Name;
        var used = data.People.Select(p => p.Name).Concat(data.People.Where(p => p.Handle.Length > 0).Select(p => p.Handle)).Concat(data.PlayerNameAliases).Append(CareerEngine.Name(data)).ToHashSet(StringComparer.OrdinalIgnoreCase);
        foreach (var p in data.People.Where(p => p.Handle.Length == 0 && Eligible(p)).OrderBy(p => p.Id, StringComparer.Ordinal))
        {
            int seed = CareerEngine.StableHash(data.WorldId + ":handle:" + p.Id);
            string country = LocalNames.ContainsKey(p.Country) ? p.Country : "美国";
            var random = new Random(seed);
            string candidate = HumanNames.Nickname(country, p.Gender, random);
            int attempts = 0;
            while (!used.Add(candidate))
            {
                candidate = HumanNames.Nickname(country, p.Gender, random);
                if (++attempts > 2048) candidate += attempts;
            }
            p.Handle = candidate;
        }
        var handles = data.People.ToDictionary(p => p.Id, p => p.Handle);
        foreach (var p in data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent))
            if (p.Handle.Length == 0) p.Handle = handles.GetValueOrDefault(p.Id, "");
        data.IdentityVersion = Version;
    }
}
