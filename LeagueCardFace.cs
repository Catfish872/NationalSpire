using Godot;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;

namespace NationalSpire;

// 收藏特效叠在原框的非透明像素上；牌名、插画、费用和规则文字都由游戏排版。
public partial class LeagueCardFace : Control
{
    internal (CardModel Model,bool Upgraded) Identity {get;private set;}
    private NCard? _face;
    internal NCard? Detach(){
        var face=_face;if(face==null||!face.IsNodeReady())return null;
        _face=null;RemoveChild(face);return face;
    }
    private Color _ink;private int _grade;private bool _lit;
    public void Highlight(bool lit){if(_lit==lit)return;_lit=lit;Arrange();QueueRedraw();}
    public override void _Draw(){
        float h=Size.Y-8,w=Math.Min(Size.X-12,h*.74f);var c=Size*.5f;
        var r=new Rect2(c-new Vector2(w,h)*.5f,new(w,h));float x=r.Position.X,y=r.Position.Y,ex=r.End.X,ey=r.End.Y;
        float k=Math.Min(15,w*.07f);Vector2[] rim=[new(x+k,y),new(ex-k,y),new(ex,y+k),new(ex,ey-k),new(ex-k,ey),new(x+k,ey),new(x,ey-k),new(x,y+k)];
        DrawColoredPolygon(rim,new Color("19252c").Lerp(_ink,_lit?.19f:.075f));
        DrawPolyline([..rim,rim[0]],new Color(_ink,_lit?.77f:.32f),1.4f,true);
        for(int i=0;i<4;i++){float dx=i%2==0?1:-1,dy=i<2?1:-1;var o=new Vector2(dx>0?x:ex,dy>0?y:ey);Vector2 V(float a,float b)=>o+new Vector2(a*dx,b*dy);
            DrawColoredPolygon([V(1,k+15),V(1,k),V(k,1),V(k+15,1),V(k+4,4),V(4,k+4)],new Color(_ink,_lit?.95f:.66f));
        }
        for(int i=0;i<=_grade;i++){var pt=new Vector2(c.X+7*(i-_grade*.5f),ey-3);DrawColoredPolygon([pt+Vector2.Up*2.5f,pt+Vector2.Right*2.5f,pt+Vector2.Down*2.5f,pt+Vector2.Left*2.5f],_ink);}
    }
    private static Shader? _foil;
    private static Shader? _edge;
    private void MountEdge(int grade,Color ink){
        _edge??=new Shader{Code=@"shader_type canvas_item;
            uniform vec4 ink : source_color; uniform int grade; uniform float shift;
            void fragment(){
                vec2 q=abs(UV-0.5);
                vec2 halfsize=vec2(0.5)-vec2(0.024,0.019);
                vec2 d=q-halfsize; float dist=max(max(d.x,d.y),(d.x+d.y+0.034)*0.707);
                float rim=1.0-smoothstep(0.0025,0.011,abs(dist));
                float bloom=(1.0-smoothstep(0.003,0.022,abs(dist)))*0.21;
                float a=atan(UV.y-0.5,UV.x-0.5)/6.283185;
                float track=cos(6.283185*(a-TIME*0.12+shift));
                float glint=smoothstep(0.50,0.98,track);
                if(grade>=2)glint=max(glint,0.70*smoothstep(0.80,0.99,-track));
                vec3 tint=grade==3?mix(ink.rgb,vec3(0.27,0.93,0.96),0.5+0.5*sin(a*6.283185+TIME*0.6)):ink.rgb;
                COLOR=vec4(mix(tint,vec3(1.0),0.48*glint),clamp((rim+bloom)*(0.10+0.055*float(grade)+glint*(0.45+0.12*float(grade))),0.0,0.94));}"};
        var mat=new ShaderMaterial{Shader=_edge};mat.SetShaderParameter("ink",ink);mat.SetShaderParameter("grade",grade);mat.SetShaderParameter("shift",GetInstanceId()%127/127f);
        var light=new ColorRect{Material=mat,MouseFilter=MouseFilterEnum.Ignore};AddChild(light);
        void Place(){float h=Size.Y-8,w=Math.Min(Size.X-12,h*.74f);light.Size=new(w,h);light.Position=(Size-light.Size)*.5f;}
        Resized+=Place;Place();
    }
    public void ShowCard(CardModel model,int grade,Color tint,bool upgraded=false,NCard? reuse=null)
    {
        _grade=grade;_ink=tint;CustomMinimumSize=new(180,272);MouseFilter=MouseFilterEnum.Ignore;
        Identity=(model,upgraded);
        if(reuse!=null){_face=reuse;AddChild(reuse);}else{
        _face=ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>();
        var copy=model.ToMutable();_face.Model=upgraded?LeagueCards.Improve(copy):copy;_face.Ready+=()=>Finish(model,grade,tint);AddChild(_face);}
        MountEdge(grade,tint);Resized+=Arrange;Arrange();
    }
    private void Finish(CardModel model,int grade,Color tint){
        if(_face==null)return;
        _face.UpdateVisuals(PileType.None,CardPreviewMode.Normal);
        if(!ResourceLoader.Exists(model.PortraitPath)){
            var path=new[]{model.BetaPortraitPath,$"res://images/packed/card_portraits/{model.Pool.Title.ToLowerInvariant()}/{model.Id.Entry.ToLowerInvariant()}.png",CardModel.MissingPortraitPath}.FirstOrDefault(p=>ResourceLoader.Exists(p));
            if(path!=null)_face.GetNode<TextureRect>(grade==3?"%AncientPortrait":"%Portrait").Texture=ResourceLoader.Load<Texture2D>(path);
        }
        var source=_face.GetNode<TextureRect>(grade==3?"%AncientBorder":"%Frame");
        var overlay=new TextureRect{Texture=source.Texture,ExpandMode=source.ExpandMode,StretchMode=source.StretchMode,MouseFilter=MouseFilterEnum.Ignore};
        source.AddChild(overlay);overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _foil??=new Shader{Code=@"shader_type canvas_item;
            uniform vec4 ink : source_color;
            uniform float intensity;
            uniform int grade;
            void fragment(){vec4 frame=texture(TEXTURE,UV);
            float metal=dot(frame.rgb,vec3(0.25,0.58,0.17));
            float bevel=pow(abs(UV.x*2.0-1.0),3.0);
            float satin=0.08+0.15*metal+0.09*bevel;
            float phase=fract(UV.x*0.38+UV.y*0.66-TIME*(0.11+float(grade)*0.008)+float(grade)*0.21);
            float gleam=1.0-smoothstep(0.035,0.20,abs(phase-0.42));
            vec3 hue=ink.rgb;
            if(grade>=2) gleam+=0.45*(1.0-smoothstep(0.01,0.036,abs(phase-0.56)));
            if(grade==3) hue=mix(hue,vec3(0.43,0.84,0.87),0.5+0.4*sin(6.28*(UV.y+phase)));
            COLOR=vec4(mix(hue,vec3(0.96,0.91,0.82),clamp(metal*0.30+gleam*0.65,0.0,0.88)),frame.a*(satin*intensity+gleam*(0.32+0.105*float(grade))));}"};
        var material=new ShaderMaterial{Shader=_foil};material.SetShaderParameter("ink",tint);material.SetShaderParameter("grade",grade);material.SetShaderParameter("intensity",.5f+.17f*grade);overlay.Material=material;
    }
    private void Arrange(){if(_face==null)return;float scale=Math.Min((Size.X-24)/300f,(Size.Y-22)/422f)*(_lit?1.027f:1f);_face.Position=Size*.5f;_face.Scale=Vector2.One*scale;}
}
