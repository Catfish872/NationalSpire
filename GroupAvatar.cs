using Godot;

namespace NationalSpire;

/// <summary>通讯列表复用四个简化头像节点，成员顺序与群消息顺序独立。</summary>
public partial class GroupAvatar : Control
{
    private readonly List<CareerAvatar> _pictures = [];
    public static string[] Members(CareerData data, GroupChat group) => group.Members.Distinct(StringComparer.Ordinal)
        .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null)
        .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal).Take(4).ToArray();
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += Arrange; }
    public void Update(CareerData data, GroupChat group)
    {
        var ids = Members(data, group);
        for (int i = 0; i < ids.Length; i++)
        {
            if (i == _pictures.Count) { var picture = new CareerAvatar { Simplified = true }; _pictures.Add(picture); AddChild(picture); }
            _pictures[i].PersonId = ids[i]; _pictures[i].Art = CareerAvatars.ForPerson(data, ids[i]); _pictures[i].Show();
        }
        for (int i = ids.Length; i < _pictures.Count; i++) _pictures[i].Hide();
        Arrange(); QueueRedraw();
    }
    private void Arrange()
    {
        var visible = _pictures.Where(p => p.Visible).ToArray();
        float edge = Math.Min(Size.X, Size.Y), gap = 2, half = (edge - gap) / 2;
        for (int i = 0; i < visible.Length; i++)
        {
            var position = visible.Length switch
            {
                1 => Vector2.Zero,
                2 => new Vector2(i * (half + gap), (edge - half) / 2),
                3 => i == 0 ? new Vector2((edge - half) / 2, 0) : new Vector2((i - 1) * (half + gap), half + gap),
                _ => new Vector2(i % 2 * (half + gap), i / 2 * (half + gap))
            };
            visible[i].Position = position; visible[i].Size = Vector2.One * (visible.Length == 1 ? edge : half);
        }
    }
    public override void _Draw()
    {
        if (_pictures.Any(p => p.Visible)) return;
        DrawStyleBox(CareerVisuals.Box("203448", "526b78", 6, 0), new(Vector2.Zero, Size));
        DrawCircle(Size / 2 - new Vector2(0, 5), 5, CareerVisuals.Teal);
        DrawArc(Size / 2 + new Vector2(0, 10), 9, Mathf.Pi, Mathf.Tau, 16, CareerVisuals.Teal, 3, true);
    }
}
