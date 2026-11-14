using Godot;
namespace NationalSpire;

// 收藏封套和翻面演出使用同一张可缩放的矢量封面，不受窗口分辨率影响。
public partial class LeagueFoil : Control
{
    public Color Ink=new("dfbc79");
    public bool Wide;
    public override void _Draw()
    {
        var sz=Size; if(sz.X<2||sz.Y<2)return;
        var center=Wide?new Vector2(sz.X*.77f,sz.Y*.51f):sz*.5f;
        float r=Wide?Math.Min(sz.Y*.43f,sz.X*.25f):Math.Min(sz.X*.42f,sz.Y*.34f);
        DrawRect(new(Vector2.Zero,sz),new Color("101d2b"));
        for(int i=0;i<28;i++){
            float x=sz.X*i/27;DrawLine(new(x-sz.Y*.32f,sz.Y), new(x,0),new Color(Ink,.045f),1,true);
        }
        for(int i=0;i<4;i++) DrawArc(center,r*(.52f+i*.15f),0,Mathf.Tau,100,new Color(Ink,i==2?.58f:.22f),i==2?1.7f:1f,true);
        for(int i=0;i<40;i++){
            var dir=Vector2.Up.Rotated(i*Mathf.Tau/40);
            DrawLine(center+dir*r*.88f,center+dir*r*(i%5==0?1.02f:.94f),new Color(Ink,.56f),1,true);
        }
        Vector2[] peak=[center+new Vector2(-.48f,.39f)*r,center+new Vector2(-.13f,-.04f)*r,center+new Vector2(0,-.62f)*r,center+new Vector2(.16f,-.21f)*r,center+new Vector2(.48f,.39f)*r];
        DrawColoredPolygon(peak,new Color("34444b")); DrawPolyline(peak,Ink,2,true);
        DrawLine(peak[2],center+new Vector2(.04f,.36f)*r,Ink,1,true);
        DrawLine(peak[0],peak[^1],Ink,2,true);
        for(int i=0;i<4;i++){var p=new Vector2((i%2==0?14:sz.X-14),(i<2?14:sz.Y-14));DrawLine(p,p+new Vector2(i%2==0?17:-17,0),Ink);DrawLine(p,p+new Vector2(0,i<2?13:-13),Ink);}
    }
}
