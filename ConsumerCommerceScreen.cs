using Godot;
using System.Text.Json;

namespace NationalSpire;

public sealed record ConsumerComposer(string Good, string Person, string Group, List<string> People);

public partial class CareerScreen
{
    private void ConsumerTarget(Good good, bool activity) => ConsumerEditor(activity, new(good.Id, "", "", []));
    private void ConsumerConfirmPurchase(CareerData data, Good good, int quantity)
    {
        ShowCareerDialog("确认购买", $"{good.Name} ×{quantity}\n支付 ${ConsumerEngine.Price(good) * (decimal)quantity:N0}\n"
            + (good.Instant ? "付款后立即单人使用，本次购买不进入库存。" : good.Promo ? "购买后立即执行运营。" : "购买后加入库存。"),
            () => { ConsumerSubmit(data, good, "", [], quantity); return true; }, "确认购买");
    }
    private void ConsumerAttachmentConfirmation(ConsumerComposer target, PrivateOffer attachment, Action? returnTo = null)
    {
        var data = ViewData; var good = ConsumerCatalog.Get(attachment.GoodId)!;
        int quantity = attachment.Kind == "activity" ? 1 : attachment.Quantity;
        int buy = ConsumerAttachments.ToBuy(data, good, quantity);
        string explanation = good.Instant
            ? "拒绝或移除附件后，商品返回当天临时物品，可再次使用；下一天清除。已接受的活动保留至赴约。"
            : attachment.Kind == "gift" ? "对方接受才扣除赠送物品，拒绝后物品保留。" : $"活动后物品继续保留，赴约招待费 ${ConsumerEngine.HospitalityFee(good):N0}。";
        _openingDialogReturn = returnTo ?? (() =>
        {
            if (attachment.Kind == "gift") PrivateGiftPicker(target, attachment);
            else PrivateActivityPicker(good.Id, attachment.GoodVerb, target, attachment);
        });
        Label? error = null;
        ShowCareerDialog("确认费用与附件", "", () =>
        {
            var command = new PrivateMessageCommand { Request = attachment, Part = target.Group };
            void Accepted()
            {
                _multiplayer?.Refresh();
                if (target.Group.Length > 0) OpenPrivateMessages(group: target.Group); else OpenPrivateMessages(target.Person);
                RestoreConsumerDrafts(); RefreshPrivateAttachments();
            }
            if (_multiplayer != null) _multiplayer.Send("consumer-attach", target.Person, JsonSerializer.Serialize(command), accepted: Accepted);
            else
            {
                string? result = EconomicActions.Save(data, d => ConsumerAttachments.Prepare(d, target.Person, target.Group, attachment));
                if (result != null) { error!.Text = result; error.Show(); return false; }
                Callable.From(Accepted).CallDeferred();
            }
            return true;
        }, "确认并添加", contents: box =>
        {
            var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "688b8b", 10, 18)); box.AddChild(card);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); card.AddChild(row);
            row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) });
            var summary = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; summary.AddThemeConstantOverride("separation", 8); row.AddChild(summary);
            summary.AddChild(Text(good.Name + " ×" + quantity, 23, _gold));
            summary.AddChild(Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink));
            if (attachment.Kind == "activity") summary.AddChild(Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal));
            var metrics = new HBoxContainer(); metrics.AddThemeConstantOverride("separation", 24); box.AddChild(metrics);
            foreach (var metric in new[] { ("使用现有", (quantity - buy).ToString()), ("本次补购", buy.ToString()), ("本次支付", $"${ConsumerEngine.Price(good) * (decimal)buy:N0}") })
            {
                var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; metrics.AddChild(column); column.AddChild(Text(metric.Item1, 14, _muted)); column.AddChild(Text(metric.Item2, 25, CareerVisuals.Teal));
            }
            box.AddChild(Text(explanation, 16, _muted));
            error = Text("", 16, new("efb3aa")); error.Name = "ConsumerAttachmentError"; error.Hide(); box.AddChild(error);
        }, returnOutsideChat: true);
        _openingDialogReturn = null;
    }
    private void RestoreConsumerDrafts()
    {
        var d = ViewData;
        foreach (var old in PrivateAttachments.Where(a => a.ConsumerAttachmentId.Length > 0).ToArray())
            if (ConsumerAttachments.Find(d, old)?.State != "draft") PrivateAttachments.Remove(old);
        foreach (var saved in d.Life.Consumer.Attachments.Where(x => x.State == "draft" && (x.Group.Length > 0 ? x.Group == _privateGroup : _privateGroup.Length == 0 && x.Person == _privatePerson)))
            if (!PrivateAttachments.Any(a => a.ConsumerAttachmentId == saved.Id)) PrivateAttachments.Add(Coop.CoopJson.Copy(saved.Offer));
    }
    private void RemoveConsumerDraft(PrivateOffer a)
    {
        void Accepted() { _multiplayer?.Refresh(); PrivateAttachments.RemoveAll(x => x.ConsumerAttachmentId == a.ConsumerAttachmentId); RefreshPrivateAttachments(); }
        if (_multiplayer != null) _multiplayer.Send("consumer-remove", _privatePerson, JsonSerializer.Serialize(new PrivateMessageCommand { Entry = a.ConsumerAttachmentId }), accepted: Accepted);
        else { ConsumerAttachments.Remove(ViewData, a.ConsumerAttachmentId); CareerStore.Save(ViewData); Accepted(); }
    }
}
