using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.Orbs;
using MegaCrit.Sts2.Core.Nodes.Rooms;

namespace NationalSpire;

public static partial class LeagueNativeMatch {
    private static Action<NCreature,float,double> _sizePet=null!;
    private static void InstallVisuals(Harmony h){
        h.Patch(AccessTools.DeclaredMethod(typeof(CardPileCmd),nameof(CardPileCmd.Add),[typeof(IEnumerable<CardModel>),typeof(CardPile),typeof(CardPilePosition),typeof(AbstractModel),typeof(bool),typeof(bool)]),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(RivalPlayPileVisuals)));
        // 原生控件需要从场上角色找到持有者；仅在负责显示球和排列随从的入口补足敌方身份。
        void Owner(Type t,string m)=>h.Patch(AccessTools.DeclaredMethod(t,m),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));
        Owner(typeof(NOrbManager),"Create");Owner(typeof(NOrbManager),"get_Player");Owner(typeof(NCombatRoom),"AddCreature");
        h.Patch(AccessTools.DeclaredMethod(typeof(NOrbManager),"OnCombatSetup"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(SetUpOrbSlots)));
        h.Patch(AccessTools.DeclaredMethod(typeof(NCreature),"_Ready"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(OrbDisplay)));
        h.Patch(AccessTools.DeclaredMethod(typeof(NCombatRoom),"AddCreature"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetAdded)));
        var size=AccessTools.DeclaredMethod(typeof(NCreature),"ScaleAndPositionOsty")??AccessTools.DeclaredMethod(typeof(NCreature),"OstyScaleToSize");
        _sizePet=size.CreateDelegate<Action<NCreature,float,double>>();h.Patch(size,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(PetGrew)));
        h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"BeforeCardPlayed"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ShowPlayedCard)));
    }
    // 自动出牌有时先把牌移入出牌区，随后才通知出牌。敌方在通知时已有专属展示。
    private static void RivalPlayPileVisuals(CardPile newPile,ref bool skipVisuals){
        if(!skipVisuals&&newPile.Type==PileType.Play&&Current!=null)
            skipVisuals=Fighters.Any(f=>f.Rival.PlayerCombatState?.PlayPile==newPile);
    }
    private static void OrbDisplay(NCreature __instance){
        if(__instance.Entity?.Monster is not LeagueOpponent monster||(monster.Fighter??Current)?.Rival is not {} r)return;
        var body=__instance.Body;body.Scale=new Vector2(-Math.Abs(body.Scale.X),body.Scale.Y);
        if(__instance.Entity!=r.Creature||__instance.OrbManager!=null||r.PlayerCombatState==null)return;
        var orbs=NOrbManager.Create(__instance,false);
        AccessTools.PropertySetter(typeof(NCreature),nameof(NCreature.OrbManager)).Invoke(__instance,[orbs]);
        __instance.AddChild(orbs);AccessTools.DeclaredMethod(typeof(NCreature),"SetOrbManagerPosition").Invoke(__instance,null);
        if(r.PlayerCombatState.OrbQueue.Capacity>0)orbs.AddSlotAnim(r.PlayerCombatState.OrbQueue.Capacity);
    }
    private static bool SetUpOrbSlots(NOrbManager __instance)=>!Fighters.Any(f=>NCombatRoom.Instance?.GetCreatureNode(f.Rival.Creature)?.OrbManager==__instance);
    private static void PetAdded(NCombatRoom __instance,Creature creature){
        if(creature.PetOwner is not {} owner||For(owner)==null||__instance.GetCreatureNode(creature) is not {} pet||__instance.GetCreatureNode(owner.Creature) is not {} lead)return;
        if(pet.GetParent()!=lead.GetParent())pet.Reparent(lead.GetParent(),true);
        if(creature.Monster?.Id.Entry=="OSTY"){pet.Body.Scale=new(-Math.Abs(pet.Body.Scale.X),pet.Body.Scale.Y);_sizePet(pet,creature.MaxHp,0);}
    }
    private static void PetGrew(NCreature __instance){
        var creature=__instance.Entity;if(creature.PetOwner is not {} owner||For(owner)==null||NCombatRoom.Instance?.GetCreatureNode(owner.Creature) is not {} lead)return;
        var offset=NCreature.GetOstyOffsetFromPlayer(creature);__instance.GlobalPosition=lead.GlobalPosition+new Vector2(-offset.X,offset.Y);
    }
    private static void ShowPlayedCard(CardPlay cardPlay,ref Task __result){
        if(For(cardPlay.Card.Owner) is {} duel)__result=RevealBeforePlay(__result,cardPlay.Card,duel);
    }
    private static async Task RevealBeforePlay(Task before,CardModel card,LeagueDuel duel){
        await before;if(For(duel.Rival)!=duel||NCombatRoom.Instance is not {} room)return;
        var gallery=room.GetNodeOrNull<LeagueRivalPlays>("LeaguePlaysLayer/LeagueRivalPlays");
        if(gallery==null){
            var layer=new CanvasLayer{Layer=9,Name="LeaguePlaysLayer"};room.AddChild(layer);
            gallery=new LeagueRivalPlays{Name="LeagueRivalPlays",MouseFilter=Control.MouseFilterEnum.Ignore};layer.AddChild(gallery);gallery.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        }
        if(room.GetCreatureNode(duel.Rival.Creature) is {} lead){gallery.Reveal(card,lead.GetGlobalTransformWithCanvas().Origin);
            await room.ToSignal(room.GetTree().CreateTimer(.95),SceneTreeTimer.SignalName.Timeout);}
    }
}

// 牌面同时最多保留两张。文字保留最近三次实际出牌，即使连击在同一帧发生，也能读清先后顺序。
internal partial class LeagueRivalPlays : Control {
    private readonly Queue<string> _names=new(3);
    private Label _caption=null!;
    private NCard? _face,_last;
    private Tween? _motion,_captionMotion;
    public override void _Ready(){
        _caption=new Label{MouseFilter=MouseFilterEnum.Ignore,HorizontalAlignment=HorizontalAlignment.Center,Modulate=Colors.Transparent};
        _caption.AddThemeFontOverride("font",CareerVisuals.InterfaceText(600));
        _caption.AddThemeFontSizeOverride("font_size",21);_caption.AddThemeConstantOverride("outline_size",6);
        _caption.AddThemeColorOverride("font_color",new Color("efdfba"));_caption.AddThemeColorOverride("font_outline_color",new Color("172129"));
        AddChild(_caption);
    }
    internal void Reveal(CardModel model,Vector2 start){
        var at=new Vector2(Size.X*.62f,Size.Y*.275f);
        _motion?.Kill();_captionMotion?.Kill();
        if(IsInstanceValid(_last)&&!_last!.IsQueuedForDeletion()){_last.Hide();_last.QueueFree();}
        _last=_face;
        if(IsInstanceValid(_last)&&!_last!.IsQueuedForDeletion()){
            var previous=_last;var retreat=previous.CreateTween().SetParallel();
            retreat.TweenProperty(previous,"position",at+new Vector2(-122,-6),.16);
            retreat.TweenProperty(previous,"scale",Vector2.One*.41f,.16);retreat.TweenProperty(previous,"rotation",-.065f,.16);
            retreat.TweenProperty(previous,"modulate:a",.72f,.16);retreat.Chain().TweenInterval(.36);
            retreat.Chain().TweenProperty(previous,"modulate:a",0,.16);retreat.Chain().TweenCallback(Callable.From(previous.QueueFree));
        }
        if(_names.Count==3)_names.Dequeue();_names.Enqueue(GameText.Plain(model.Title));
        _caption.Text="对手出牌   ·   "+string.Join("  ›  ",_names);_caption.ResetSize();
        _caption.Position=new Vector2(Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8)),at.Y-153);
        _caption.Modulate=Colors.White;_captionMotion=_caption.CreateTween();_captionMotion.TweenInterval(2.6);_captionMotion.TweenProperty(_caption,"modulate:a",0,.3);
        var face=ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>();_face=face;
        face.Model=model;AddChild(face);face.UpdateVisuals(PileType.Play,CardPreviewMode.Normal);
        face.MouseFilter=MouseFilterEnum.Ignore;face.Scale=Vector2.One*.22f;face.Position=start;face.Rotation=.095f;
        var t=_motion=face.CreateTween().SetParallel();t.TweenProperty(face,"position",at,.18).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);
        t.TweenProperty(face,"scale",Vector2.One*.60f,.18);t.TweenProperty(face,"rotation",0,.18);
        t.Chain().TweenInterval(.84);t.Chain().TweenProperty(face,"modulate:a",0,.22);t.Chain().TweenCallback(Callable.From(face.QueueFree));
    }
}
