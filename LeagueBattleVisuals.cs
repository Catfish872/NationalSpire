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
    private static readonly Action<NCreature,Creature> SetVisualEntity=AccessTools.PropertySetter(typeof(NCreature),nameof(NCreature.Entity)).CreateDelegate<Action<NCreature,Creature>>();
    private static void InstallVisuals(Harmony h){
        h.Patch(AccessTools.DeclaredMethod(typeof(NCreature),nameof(NCreature.SetAnimationTrigger)),
            prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(BeginRoleAnimation)){priority=Priority.First},
            finalizer:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EndRoleAnimation)){priority=Priority.Last});
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
        if(AccessTools.DeclaredMethod(typeof(CombatManager),"EndCardOrPotionEffect") is {} endEffects)
            h.Patch(endEffects,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EffectsEnded)));
        else h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Hooks.Hook),"AfterCardPlayed"),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(EndExtraPlay)));
    }
    // 只在本机派发同步动画通知时切换节点读取的实体；不修改战斗实体、玩家名单或联网资料。
    private static void BeginRoleAnimation(NCreature __instance,out Creature? __state){
        __state=null;
        if(__instance.Entity is not {Monster:LeagueOpponent opponent} actor||(opponent.Fighter??Current) is not {} fighter)return;
        var visual=fighter.VisualCharacter;
        if(visual.MaxHp!=actor.MaxHp)visual.SetMaxHpInternal(actor.MaxHp);
        if(visual.CurrentHp!=actor.CurrentHp)visual.SetCurrentHpInternal(actor.CurrentHp);
        __state=actor;SetVisualEntity(__instance,visual);
    }
    private static void EndRoleAnimation(NCreature __instance,Creature? __state){
        if(__state!=null)SetVisualEntity(__instance,__state);
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
        if(For(cardPlay.Card.Owner) is {} duel)__result=RevealBeforePlay(__result,cardPlay,duel);
    }
    // 回合外由卡效引起的出牌也有结束时机。嵌套自动出牌沿用外层出牌或该选手的行动。
    private static void EffectsEnded(CombatManager __instance,MegaCrit.Sts2.Core.Entities.Players.Player player){
        if(For(player) is {DisplayingTurn:false} duel&&!__instance.IsExecutingCardOrPotionEffect(player))EndPlayDisplay(duel);
    }
    private static void EndExtraPlay(CardPlay cardPlay,ref Task __result){
        if(For(cardPlay.Card.Owner) is {DisplayingTurn:false} duel&&NCombatRoom.Instance?.GetNodeOrNull<LeagueRivalPlays>(PlayGalleryPath) is {} gallery&&gallery.ExtraPlay==cardPlay)
            __result=Finish(__result);
        async Task Finish(Task effects){try{await effects;}finally{if(GodotObject.IsInstanceValid(gallery)&&gallery.ExtraPlay==cardPlay)gallery.End(duel);}}
    }
    private const string PlayGalleryPath="LeaguePlaysLayer/LeagueRivalPlays";
    internal static void EndPlayDisplay(LeagueDuel duel)=>NCombatRoom.Instance?.GetNodeOrNull<LeagueRivalPlays>(PlayGalleryPath)?.End(duel);
    private static async Task RevealBeforePlay(Task before,CardPlay play,LeagueDuel duel){
        await before;duel.Exit.ThrowIfCancellationRequested();if(For(duel.Rival)!=duel||NCombatRoom.Instance is not {} room)return;
        var gallery=room.GetNodeOrNull<LeagueRivalPlays>(PlayGalleryPath);
        if(gallery==null){
            var layer=new CanvasLayer{Layer=9,Name="LeaguePlaysLayer"};room.AddChild(layer);
            gallery=new LeagueRivalPlays{Name="LeagueRivalPlays",MouseFilter=Control.MouseFilterEnum.Ignore};layer.AddChild(gallery);gallery.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        }
        if(room.GetCreatureNode(duel.Rival.Creature) is {} lead){gallery.Reveal(duel,play,lead.GetGlobalTransformWithCanvas().Origin);
            var timer=room.GetTree().CreateTimer(.95);
            if(!duel.Exit.CanBeCanceled){await room.ToSignal(timer,SceneTreeTimer.SignalName.Timeout);return;}
            // 房间可以在展示中退出；计时器和离场信号都能结束这次等待。
            var shown=new TaskCompletionSource();timer.Timeout+=shown.SetResult;
            try{await shown.Task.WaitAsync(duel.Exit);}finally{timer.Timeout-=shown.SetResult;}}
    }
}

// 牌面同时最多保留两张。文字保留最近三次实际出牌，即使连击在同一帧发生，也能读清先后顺序。
internal partial class LeagueRivalPlays : Control {
    private readonly Queue<string> _names=new(3);
    private Label _caption=null!;
    private NCard? _face,_last;
    private LeagueDuel? _owner;
    internal CardPlay? ExtraPlay {get;private set;}
    private Tween? _motion,_fade;
    public override void _Ready(){
        _caption=new Label{MouseFilter=MouseFilterEnum.Ignore,HorizontalAlignment=HorizontalAlignment.Center,Modulate=Colors.Transparent};
        _caption.AddThemeFontOverride("font",CareerVisuals.InterfaceText(600));
        _caption.AddThemeFontSizeOverride("font_size",21);_caption.AddThemeConstantOverride("outline_size",6);
        _caption.AddThemeColorOverride("font_color",new Color("efdfba"));_caption.AddThemeColorOverride("font_outline_color",new Color("172129"));
        AddChild(_caption);
    }
    private static void RemoveFace(NCard? face){if(IsInstanceValid(face)&&!face!.IsQueuedForDeletion()){face.Hide();face.QueueFree();}}
    private void ClearPlays(){
        RemoveFace(_face);RemoveFace(_last);_face=_last=null;_names.Clear();_caption.Text="";Hide();
    }
    internal void End(LeagueDuel owner){
        if(_owner!=owner)return;
        _owner=null;ExtraPlay=null;_fade=CreateTween();_fade.TweenProperty(this,"modulate:a",0,.22);
        _fade.TweenCallback(Callable.From(ClearPlays));
    }
    internal void Reveal(LeagueDuel owner,CardPlay play,Vector2 start){
        var at=new Vector2(Size.X*.62f,Size.Y*.275f);
        _motion?.Kill();
        if(_owner!=owner){_fade?.Kill();ClearPlays();ExtraPlay=null;_owner=owner;Modulate=Colors.White;Show();}
        if(!owner.DisplayingTurn)ExtraPlay??=play;
        var model=play.Card;
        RemoveFace(_last);
        _last=_face;
        if(IsInstanceValid(_last)&&!_last!.IsQueuedForDeletion()){
            var previous=_last;var retreat=previous.CreateTween().SetParallel();
            retreat.TweenProperty(previous,"position",at+new Vector2(-122,-6),.16);
            retreat.TweenProperty(previous,"scale",Vector2.One*.41f,.16);retreat.TweenProperty(previous,"rotation",-.065f,.16);
            retreat.TweenProperty(previous,"modulate:a",.72f,.16);
        }
        if(_names.Count==3)_names.Dequeue();_names.Enqueue(GameText.Plain(model.Title));
        _caption.Text="对手出牌   ·   "+string.Join("  ›  ",_names);_caption.ResetSize();
        _caption.Position=new Vector2(Math.Clamp(at.X-_caption.Size.X/2,8,Math.Max(8,Size.X-_caption.Size.X-8)),at.Y-153);
        _caption.Modulate=Colors.White;
        var face=ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>();_face=face;
        face.Model=model;AddChild(face);face.UpdateVisuals(PileType.Play,CardPreviewMode.Normal);
        face.MouseFilter=MouseFilterEnum.Ignore;face.Scale=Vector2.One*.22f;face.Position=start;face.Rotation=.095f;
        var t=_motion=face.CreateTween().SetParallel();t.TweenProperty(face,"position",at,.18).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);
        t.TweenProperty(face,"scale",Vector2.One*.60f,.18);t.TweenProperty(face,"rotation",0,.18);
    }
}
