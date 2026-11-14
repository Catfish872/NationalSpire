using Godot;
namespace NationalSpire;

// 封签从中央裂开，四角和封边跟随两片封套退场；稀有牌用同色光尘回应。
public partial class LeagueSeal : Control
{
    public Color Ink=new("e5bf7a");private float _age;public bool Burst;
    public override void _Process(double delta){_age+=(float)delta;QueueRedraw();if(_age>(Burst?1.05:1.35))QueueFree();}
    public override void _Draw(){
        var mid=Size*.5f;float p=Math.Clamp(_age/(Burst?1:.95f),0,1);
        if(!Burst){
            float split=Mathf.Ease(Math.Clamp((p-.48f)/.52f,0,1),2.2f);
            for(int side=-1;side<=1;side+=2){
                var edge=mid+new Vector2(side*split*Size.X*.65f,0);float w=135,h=155;
                Vector2[] points=[edge+new Vector2(side*w,-h),edge+new Vector2(0,-h),edge+new Vector2(side*6,-43),edge+new Vector2(-side*5,15),edge+new Vector2(0,h),edge+new Vector2(side*w,h)];
                DrawColoredPolygon(points,new Color(side==1?"2e3238":"26343d"));DrawPolyline(points,Ink,2,true);
                for(int i=0;i<7;i++)DrawLine(edge+new Vector2(side*12,-135+i*3),edge+new Vector2(side*122,-135+i*3),new Color(Ink,.45f),1);
                DrawArc(edge,72,side==1?-Mathf.Pi/2:Mathf.Pi/2,side==1?Mathf.Pi/2:3*Mathf.Pi/2,44,Ink,2,true);
            }
        }
        float light=Burst?p:Math.Clamp((p-.45f)*2,0,1);
        if(light<=0)return;
        for(int i=0;i<46;i++){float angle=i*2.39996f;var dir=Vector2.Right.Rotated(angle);
            float rad=(Burst?140:270)*Mathf.Sqrt(light)*(.48f+.52f*((i*17)%31)/31f);
            var pos=mid+dir*rad;var glow=new Color(Ink,(1-light)*(.3f+.7f*(i%3)/2));
            DrawLine(pos-dir*(3+8*(1-light)),pos+dir*2,glow,1+(i%2),true);}
    }
}
