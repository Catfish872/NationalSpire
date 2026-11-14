using Godot;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

public partial class CareerScreen
{
    private enum LeagueControl { Action,Primary,Filter,Step,Back }
    private static Button LeagueButton(string title,Action pressed,float width,bool selected=false,string accent="d9ba83",Texture2D? emblem=null,LeagueControl kind=LeagueControl.Action){
        bool primary=kind==LeagueControl.Primary,flat=kind is LeagueControl.Filter or LeagueControl.Back,step=kind==LeagueControl.Step;
        var button=new Button{Text=CareerMoney.Display(title),CustomMinimumSize=new(width,step?38:flat?42:52),MouseDefaultCursorShape=CursorShape.PointingHand,
            Icon=emblem,ExpandIcon=true,SizeFlagsHorizontal=SizeFlags.ShrinkCenter};
        button.AddThemeConstantOverride("icon_max_width",34);button.AddThemeConstantOverride("h_separation",10);
        var ink=new Color(accent);
        foreach(var (state,fill,border) in new[]{("normal",selected?"29343b":"14222e",selected?accent:"3a4b53"),("hover","344046",accent),("pressed","394649",accent),("disabled","131c24","2a3740")}){
            var style=CareerVisuals.Box(fill,border,width<65?10:4,width<65?3:9);
            style.BorderWidthBottom=selected&&state=="normal"?3:1;style.CornerRadiusTopRight=style.CornerRadiusBottomLeft=width<65?10:12;
            if(flat){style.BorderWidthRight=style.BorderWidthLeft=style.BorderWidthTop=0;style.BorderWidthBottom=selected||state=="hover"?2:0;style.BgColor=new Color(ink,selected?.13f:state=="hover"?.09f:0);}
            if(primary)style.ContentMarginRight=34;
            if(primary&&state!="disabled"){style.BgColor=new Color(state=="normal"?"ddbf8c":"f5ddb1");style.BorderColor=new Color("f4daa3");}
            if(step){style.CornerRadiusTopLeft=style.CornerRadiusTopRight=style.CornerRadiusBottomLeft=style.CornerRadiusBottomRight=18;style.ContentMarginLeft=style.ContentMarginRight=2;
                style.SetBorderWidthAll(0);style.BgColor=state=="hover"?new Color(ink,.25f):new Color(ink,0f);}
            button.AddThemeStyleboxOverride(state,style);
        }
        button.AddThemeColorOverride("font_color",selected?ink:new Color("d6dddf"));button.AddThemeColorOverride("font_hover_color",ink);
        button.AddThemeColorOverride("font_disabled_color",new Color("62717c"));button.AddThemeFontSizeOverride("font_size",width<65?21:17);
        if(primary){foreach(var state in new[]{"font_color","font_hover_color","font_pressed_color"})button.AddThemeColorOverride(state,new Color("19272e"));button.AddThemeFontSizeOverride("font_size",21);}
        button.Draw+=()=>{
            var sz=button.Size;var color=primary&&!button.Disabled?new Color("775e39"):new Color(ink,button.Disabled?.18f:selected?.92f:.61f);
            if(step&&button.Text=="＋")button.DrawLine(new(0,9),new(0,sz.Y-9),new Color(ink,.3f),1,true);
            if(step&&button.Text=="−")button.DrawLine(new(sz.X-1,9),new(sz.X-1,sz.Y-9),new Color(ink,.3f),1,true);
            if(kind==LeagueControl.Filter){var c=new Vector2(10,sz.Y/2);button.DrawColoredPolygon([c+Vector2.Up*3,c+Vector2.Right*3,c+Vector2.Down*3,c+Vector2.Left*3],color);}
            if(primary||kind==LeagueControl.Back){float dir=primary?1:-1;Vector2 c=new(primary?sz.X-15:16,sz.Y/2);button.DrawPolyline([c+new Vector2(-3*dir,-5),c+new Vector2(2*dir,0),c+new Vector2(-3*dir,5)],color,1.6f,true);}
            if(primary)button.DrawLine(new(12,sz.Y-5),new(sz.X-17,sz.Y-5),color,1,true);
        };
        button.Pressed+=pressed;return button;
    }
}

// 门扇和中央徽章共享一条中轴。背景、门扇和火花均随窗口尺寸绘制。
public partial class LeagueGate : Control
{
    private double _time;private float _door,_impact;
    public float Door {get=>_door;set{_door=value;QueueRedraw();}}
    public float Impact {get=>_impact;set{_impact=value;QueueRedraw();}}
    public override void _Process(double delta){_time+=delta;QueueRedraw();}
    public override void _Draw(){
        var s=Size;var c=s*.5f;float unit=Math.Min(s.X/1700,s.Y/900);if(unit<=0)return;
        DrawRect(new(Vector2.Zero,s),new Color("0c1722"));var gold=new Color("e7c588");var blue=new Color("7fc8cd");
        for(int k=0;k<2;k++){
            int dir=k==0?-1:1;Color tone=k==0?blue:gold;
            Vector2[] band=[c+new Vector2(dir*s.X*.56f,-s.Y*.36f),c+new Vector2(dir*s.X*.10f,-62*unit),c+new Vector2(dir*s.X*.13f,115*unit),c+new Vector2(dir*s.X*.56f,s.Y*.42f)];
            DrawColoredPolygon(band,new Color(k==0?"152b35":"292a2a"));DrawLine(band[0],band[1],new Color(tone,.38f),2*unit,true);
            DrawLine(band[2],band[3],new Color(tone,.26f),unit,true);
        }
        foreach(int r in new[]{81,91,105})DrawArc(c,r*unit,0,Mathf.Tau,100,new Color(gold,r==91?.65f:.21f),1.5f*unit,true);
        for(int i=0;i<60;i++){var v=Vector2.Up.Rotated(i*Mathf.Tau/60);DrawLine(c+v*95*unit,c+v*(i%5==0?104:98)*unit,new Color(gold,.63f),unit,true);}
        DrawArc(c,109*unit,(float)_time,(float)_time+.75f,20,blue,2*unit,true);
        if(_door<=0)return;
        foreach(int dir in new[]{-1,1}){
            float at=c.X+dir*(1-_door)*(c.X+50*unit);
            Vector2 Q(float x,float y)=>new(at+dir*x*unit,y*s.Y);
            Vector2[] edge=[Q(28,0),Q(28,.30f),Q(0,.38f),Q(0,.62f),Q(28,.70f),Q(28,1)];
            Vector2[] panel=[..edge,Q(s.X/unit,1),Q(s.X/unit,0)];DrawColoredPolygon(panel,new Color(dir<0?"1c303b":"303439"));DrawPolyline(edge,gold,4*unit,true);
            for(int n=1;n<=4;n++){var stroke=edge.Select(p=>p+Vector2.Right*dir*(9+n*n*9)*unit).ToArray();DrawPolyline(stroke,new Color(dir<0?blue:gold,n==2?.55f:.18f),2*unit,true);}
            var hc=new Vector2(at,c.Y);DrawArc(hc,66*unit,dir<0?Mathf.Pi*.5f:-Mathf.Pi*.5f,dir<0?Mathf.Pi*1.5f:Mathf.Pi*.5f,50,gold,3*unit,true);
        }
        if(_impact<=0)return;float t=1-_impact;DrawLine(new(c.X,0),new(c.X,s.Y),new Color("ffedcd",_impact),6*unit,true);
        for(int i=0;i<32;i++){var v=Vector2.Right.Rotated(i*2.39996f);float r=(28+t*(80+i%6*25))*unit;DrawLine(c+v*r,c+v*(r+12*unit*_impact),new Color(gold,_impact),2*unit,true);}
    }
}
