namespace NationalSpire;

/// <summary>当前帖子的一次界面投影；层级、折叠和计数只用于阅读。</summary>
internal static class CommunityDiscussionLayout
{
    internal sealed class Item(CommunityReply reply, Item? parent, int floor, bool visible)
    {
        public CommunityReply Reply { get; } = reply;
        public Item? Parent { get; } = parent;
        public int Floor { get; } = floor;
        public int Depth { get; } = parent == null ? 0 : parent.Depth + 1;
        public bool Visible { get; } = visible;
        public int Descendants { get; set; }
    }

    public static List<Item> Build(CommunityPost post, IReadOnlySet<string> collapsed)
    {
        var items = new List<Item>(post.Replies.Count);
        var byId = new Dictionary<string, Item>();
        int floor = 0;
        foreach (var reply in CommunityThreads.ReadingOrder(post))
        {
            // 沿既有阅读顺序绑定已出现的父节点；缺失父节点或循环引用作为独立入口显示。
            byId.TryGetValue(reply.ParentId, out var parent);
            var item = new Item(reply, parent, parent?.Floor ?? ++floor,
                parent == null || parent.Visible && !collapsed.Contains(parent.Reply.Id));
            items.Add(item); byId[reply.Id] = item;
        }
        for (int i = items.Count - 1; i >= 0; i--)
            if (items[i].Parent is { } parent) parent.Descendants += items[i].Descendants + 1;
        return items;
    }
}
