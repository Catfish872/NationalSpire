using Godot;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

public partial class MatchArenaBackdrop : Control
{
    public bool Launch { get; init; }
    public override void _Draw()
    {
        float w=Size.X, h=Size.Y;
        var top=new Vector2(w*.565523f,0); var bottom=new Vector2(w*.385523f,h);
        DrawPolygon([Vector2.Zero,top,bottom,new(0,h)],[new("26313b"),new("20303b"),new("172a38"),new("1d2d39")]);
        DrawPolygon([top,new(w,0),new(w,h),bottom],[new("17383b"),new("17313b"),new("162a38"),new("18313b")]);
        DrawLine(top,bottom,new Color("80e7db53"),1.6f,true);
        DrawRect(new Rect2(Vector2.Zero,Size),new Color("4d6570"),false,1);
        if (!Launch) return;
        var center=new Vector2(w*.5f,176);
        Vector2[] Diamond(float r)=>[center+new Vector2(0,-r),center+new Vector2(r,0),center+new Vector2(0,r),center+new Vector2(-r,0)];
        DrawColoredPolygon(Diamond(94),new Color("29474f")); DrawColoredPolygon(Diamond(74),new Color("152d38"));
        var loop=Diamond(74).Append(center+new Vector2(0,-74)).ToArray();DrawPolyline(loop,new Color("75c6bf"),2,true);
    }

}

public partial class CareerScreen
{
    private static Button ArenaIconButton(string title, string icon, Action open, bool choice=false)
    {
        int size=choice?16:19;
        float content=Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+29;
        float width=choice?content+26:Math.Max(182,content+34);
        var button=new Button { Text=title, CustomMinimumSize=new(width,choice?34:52), ToggleMode=choice,
            SizeFlagsHorizontal=SizeFlags.ShrinkEnd, SizeFlagsVertical=SizeFlags.ShrinkCenter, MouseDefaultCursorShape=CursorShape.PointingHand };
        ButtonIcon(button,icon,19);
        button.AddThemeFontSizeOverride("font_size",size);
        foreach (string state in ButtonStates)
        {
            bool selected=choice && state is "pressed" or "hover_pressed";
            bool hover=state is "hover" or "hover_pressed" or "pressed";
            var style=CareerVisuals.Box(hover?"28434c":choice?"1d3040":"00000000",selected?"80e7db":hover?"658c91":choice?"395365":"304a5a",6,4);
            style.ContentMarginLeft=style.ContentMarginRight=(width-content)/2;
            button.AddThemeStyleboxOverride(state,style);
            var color=state=="disabled"? new Color("82939e") : selected? CareerVisuals.Teal : choice?CareerVisuals.Muted:CareerVisuals.Ink;
            button.AddThemeColorOverride(state=="normal"?"font_color":"font_"+state+"_color",color);
            button.AddThemeColorOverride("icon_"+state+"_color",color);
        }
        button.Pressed+=open;
        return button;
    }

    private const int CharacterTileHeight = 60, CharacterTileInset = 18, CharacterCaptionGap = 16;
    private static OptionButton ArenaCharacterMenu(IReadOnlyList<CharacterModel> characters, int first, int selected, Action<int> choose)
    {
        var picker = new OptionButton { Name = "OtherCharacters", AccessibilityName = "选择其他出战角色",
            CustomMinimumSize = new(0, CharacterTileHeight), SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = HorizontalAlignment.Left,
            FitToLongestItem = false, ClipText = true, AllowReselect = true,
            TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, MouseDefaultCursorShape = CursorShape.PointingHand };
        var theme = CareerVisuals.CreateTheme();
        foreach (string state in ButtonStates)
        {
            var style = (StyleBoxFlat)theme.GetStylebox(state, "OptionButton").Duplicate();
            style.ContentMarginLeft = style.ContentMarginRight = CharacterTileInset;
            style.ContentMarginTop = style.ContentMarginBottom = (CharacterTileHeight - CareerAvatarIcon.Pixels) / 2;
            picker.AddThemeStyleboxOverride(state, style);
            picker.AddThemeColorOverride("icon_" + state + "_color", Colors.White);
        }
        picker.AddThemeColorOverride("icon_focus_color", Colors.White);
        picker.AddThemeConstantOverride("icon_max_width", CareerAvatarIcon.Pixels);
        picker.AddThemeConstantOverride("h_separation", CharacterCaptionGap);
        picker.AddThemeFontSizeOverride("font_size", 22);
        var menu = picker.GetPopup();
        menu.AddThemeConstantOverride("icon_max_width", CareerAvatarIcon.Pixels);
        menu.AddThemeConstantOverride("h_separation", CharacterCaptionGap);
        for (int i = first; i < characters.Count; i++) picker.AddItem(PlayerArchive.CharacterName(characters[i].Id), i);

        void LoadPortrait(int item)
        {
            if (picker.GetItemIcon(item) != null) return;
            var art = AvatarAssets.Load(characters[picker.GetItemId(item)].Id.ToString(), 0, false);
            picker.SetItemIcon(item, new CareerAvatarIcon { Art = art });
        }
        if (selected >= first && selected < characters.Count) LoadPortrait(selected - first);
        void LoadMenuPortraits()
        {
            for (int i = 0; i < picker.ItemCount; i++) LoadPortrait(i);
            menu.AboutToPopup -= LoadMenuPortraits;
        }
        menu.AboutToPopup += LoadMenuPortraits;
        picker.ItemSelected += item => { LoadPortrait((int)item); choose(picker.GetItemId((int)item)); };
        return picker;
    }

    private static Button ArenaTextAction(string title, string icon, Color hover, Action activate)
    {
        const int iconSize = 20, fontSize = 16, gap = 7;
        float textWidth = Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title, fontSize: fontSize).X);
        var button = new Button { Text = title, CustomMinimumSize = new(iconSize + gap + textWidth, 34),
            Alignment = HorizontalAlignment.Right, SizeFlagsVertical = SizeFlags.ShrinkCenter,
            MouseDefaultCursorShape = CursorShape.PointingHand };
        var empty = new StyleBoxEmpty();
        foreach (var state in ButtonStates.Append("focus")) button.AddThemeStyleboxOverride(state, empty);
        ButtonIcon(button, icon, iconSize);
        button.AddThemeConstantOverride("h_separation", gap);
        button.AddThemeFontSizeOverride("font_size", fontSize);
        button.AddThemeColorOverride("font_color", CareerVisuals.Muted);
        button.AddThemeColorOverride("icon_normal_color", CareerVisuals.Muted.Lightened(.18f));
        foreach (var state in new[] { "hover", "focus", "pressed", "hover_pressed" })
        {
            button.AddThemeColorOverride("font_" + state + "_color", hover);
            button.AddThemeColorOverride("icon_" + state + "_color", hover);
        }
        button.Draw += () =>
        {
            if (button.IsHovered() || button.HasFocus())
                button.DrawLine(new(button.Size.X - textWidth, button.Size.Y - 2), new(button.Size.X, button.Size.Y - 2), hover, 1);
        };
        button.Pressed += activate;
        return button;
    }

    private Button MatchReviewButton(CareerData data)
    {
        var button=ArenaIconButton("比赛回顾","history",()=>OpenReview(data.Results.LastOrDefault()?.MatchId??""));
        button.Disabled=data.Results.Count==0;
        return button;
    }
    private CareerResult? ReviewRecord(CareerData d) => d.Failure?.Result ??
        d.Results.LastOrDefault(r=>r.MatchId==(_reviewId.Length>0?_reviewId:d.PendingSettlementId)) ?? d.Results.LastOrDefault();
    private bool IsLatestReview(CareerData d) => d.Failure!=null || ReviewRecord(d)==d.Results.LastOrDefault();
    private void OpenReview(string id) => Visit(()=>{_tab="结算";_reviewId=id;});
    private void AcknowledgeReview(CareerData d)
    {
        if(d.Failure==null && _tab=="结算" && d.PendingSettlementId.Length>0 && ReviewRecord(d)?.MatchId==d.PendingSettlementId)
        { d.PendingSettlementId=""; CareerStore.Save(d); }
    }
    private void ReviewPager(CareerData d,CareerResult result)
    {
        var bar=TabStrip(_content,14); int i=d.Results.IndexOf(result);
        void Page(int index) { AcknowledgeReview(d); _reviewId=d.Results[index].MatchId; _scroll.ScrollVertical=0;Render(); }
        if(i>0) bar.AddChild(FramedAction("上一场",()=>Page(i-1),"chevron-left",width:140,height:40));
        else bar.AddChild(new Control {CustomMinimumSize=new(140,40),MouseFilter=MouseFilterEnum.Ignore});
        if(i>=0 && i<d.Results.Count-1) bar.AddChild(FramedAction("下一场",()=>Page(i+1),"chevron-right",trailing:true,width:140,height:40));
        else bar.AddChild(FramedAction("返回赛场",()=>
        {
            AcknowledgeReview(d);
            if(d.Matches.FirstOrDefault(m=>m.Id==result.MatchId && m.DateGame?.ReturnPending==true) is { } date && ResumeSettledDate(d,date)) return;
            _reviewId=""; _arenaMatchId=""; _tab="赛事"; _backHistory.Clear();_scroll.ScrollVertical=0;Render();
        },"chevron-right",trailing:true,width:140,height:40));
    }
    private static string ArenaCharacterName(string id)
    {
        var character=GameBridge.Characters().FirstOrDefault(c=>c.Id.ToString().Equals(id,StringComparison.OrdinalIgnoreCase) || c.Id.Entry.Equals(id,StringComparison.OrdinalIgnoreCase));
        return character==null?id:PlayerArchive.CharacterName(character.Id);
    }
    private Label? _arenaCharacter;
    private void MatchArena(CareerData d,string title,string opponent,string opponentName,string state,string playerCharacter,Color accent,
        out HBoxContainer actions, int day, Action? launch=null, string? playerPerformance=null, string? rivalPerformance=null, string source="赛事")
    {
        var host=new Control { Name=launch==null?"SettlementHero":"MatchHero", CustomMinimumSize=new(0,480) };
        _content.AddChild(host);
        var backdrop=new MatchArenaBackdrop { Launch=launch!=null, MouseFilter=MouseFilterEnum.Ignore };
        host.AddChild(backdrop); backdrop.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        void Center(Control node,float fraction,float y,float width,float height)
        {
            host.AddChild(node); node.AnchorLeft=node.AnchorRight=fraction; node.OffsetLeft=-width/2;
            node.OffsetRight=width/2; node.OffsetTop=y; node.OffsetBottom=y+height;
        }
        Label Line(string value,int size,Color color)
        {
            var label=Text(value,size,color);label.HorizontalAlignment=HorizontalAlignment.Center;label.VerticalAlignment=VerticalAlignment.Center; return label;
        }
        void Participant(string id,string name,string character,bool player,string? performance)
        {
            float x=player ? .207f : .793f;
            Center(Avatar(d,id,170),x,77,170,170);
            var link=CaptionButton(name,()=>OpenPerson(id));
            bool longName=CareerVisuals.InterfaceText().GetStringSize(name,fontSize:30).X>394;
            link.AutowrapMode=TextServer.AutowrapMode.WordSmart; link.TooltipText=name;
            link.AddThemeFontSizeOverride("font_size",longName ? 23 : 30); link.AddThemeColorOverride("font_color",player?_gold:_ink);
            Center(link,x,longName ? 249 : 257,420,longName ? 65 : 52);
            var person=CareerEngine.Person(d,id);
            string country=player?d.Esports.Country:person?.Country??"", club=player?d.Esports.ClubId:person?.ClubId??"";
            var detail=Line($"{country} · {EsportsWorld.ClubName(d,club)}\n最高进阶 {(player?Math.Max(0,d.AvatarHighestClear):person?.MaxAscension??0)} · {ArenaCharacterName(character)}",17,_muted);
            if(player && launch!=null)_arenaCharacter=detail;
            Center(detail,x,315,400,68);
            if(!string.IsNullOrWhiteSpace(performance)) Center(Line(performance,21,_ink),x,390,410,42);
        }
        var date=Text(GameCalendar.Date(d,day).ToString("yyyy.MM.dd"),14,_muted); Put(host,date,28,20,200,26);
        var src=Line(source,14,_muted);src.HorizontalAlignment=HorizontalAlignment.Right;Center(src,1,20,180,26);src.OffsetLeft=-210;src.OffsetRight=-28;
        Participant("player",CareerEngine.Name(d),playerCharacter,true,playerPerformance);
        Center(Line(title,19,_gold),.5f,20,426,60);
        if(launch!=null)
        {
            var emblem=CaptionButton("",launch); emblem.Name="ArenaStart";emblem.Icon=NavigationIcon(state=="前往比赛日"?"fast-forward":"swords-start");
            emblem.ExpandIcon=true;emblem.IconAlignment=HorizontalAlignment.Center;emblem.AddThemeConstantOverride("icon_max_width",73);
            emblem.AddThemeColorOverride("icon_normal_color",CareerVisuals.Teal);emblem.TooltipText=state;emblem.Disabled=_multiplayer is {Host:false};
            foreach (var style in ButtonStates.Append("focus")) emblem.AddThemeStyleboxOverride(style,new StyleBoxEmpty());
            foreach (var style in new[]{"hover","focus","pressed"}) emblem.AddThemeColorOverride("icon_"+style+"_color",_gold);
            Center(emblem,.5f,86,170,180);
            var heading=CaptionButton(state,launch); heading.Name="ArenaStateAction";heading.Disabled=emblem.Disabled;
            int size=state=="前往比赛日"?35:42;
            heading.AddThemeFontSizeOverride("font_size",size); heading.AddThemeColorOverride("font_color",CareerVisuals.Teal);
            foreach (var style in ButtonStates.Append("focus")) heading.AddThemeStyleboxOverride(style,new StyleBoxEmpty());
            heading.Draw+=()=>
            {
                if (heading.Disabled || emblem.IsHovered() || !(heading.IsHovered() || heading.HasFocus())) return;
                float width=heading.GetThemeFont("font").GetStringSize(state,fontSize:size).X;
                float x=(heading.Size.X-width)/2, y=heading.Size.Y-3;
                heading.DrawLine(new(x,y),new(x+width,y),CareerVisuals.Teal,2);
            };
            emblem.MouseEntered+=heading.QueueRedraw; emblem.MouseExited+=heading.QueueRedraw;
            Center(heading,.5f,274,300,57);
        }
        else
        {
            Center(new MatchMedallion {Victory=state=="胜利",Accent=accent,MouseFilter=MouseFilterEnum.Ignore},.5f,86,170,180);
            Center(Line(state,42,accent),.5f,274,300,57);
            Center(Line(state=="胜利"?"VICTORY":state=="失败"?"DEFEAT":"DRAW",15,_muted),.5f,339,200,24);
        }
        actions=new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}; actions.AddThemeConstantOverride("separation",20);
        actions.MouseFilter=MouseFilterEnum.Ignore;
        Center(actions,.5f,340,360,40);
        Participant(opponent,opponentName,CareerEngine.Person(d,opponent)?.Character??"",false,rivalPerformance);
    }
}
