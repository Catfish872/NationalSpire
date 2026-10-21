using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void GiftReceipt(PrivateOffer offer)
    {
        var card = new PanelContainer { Name = "GiftReceipt" };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 10, 16)); _privateBody!.AddChild(card);
        var box = Inner(card); box.AddThemeConstantOverride("separation", 12);
        box.AddChild(PrivateText((offer.Kind == OathAttachments.Kind ? "解除誓约 · " : "礼物 · ") + offer.State, 20, _gold));
        box.AddChild(PrivateSelectableText(offer.Detail, 17, _ink));
    }
    private void PrivateOathAttachment()
    {
        var attachment = new PrivateOffer { Kind = OathAttachments.Kind, Participants = [_privatePerson] };
        if (OathAttachments.Prepare(ViewData, _privatePerson, attachment) is { } error) { Notice(error, true); return; }
        AttachPrivate(attachment);
    }
    private void PrivateGiftPicker() => PrivateGiftPicker(null);
    private void PrivateGiftPicker(ConsumerComposer? shop, PrivateOffer? previous = null) => ConsumerEditor(false, shop, previous);
    private void PrivateActivityPicker() => PrivateActivityPicker("", "");
    private void PrivateActivityPicker(string goodId, string verbId, ConsumerComposer? shop = null, PrivateOffer? previous = null)
        => ConsumerEditor(true, shop, previous, goodId, verbId);
}
