namespace NationalSpire;

/// <summary>缓存可见轮次引用；分页只改变显示范围，轮次内容由原会话管理。</summary>
public sealed class ChatHistoryPage<T>(Func<T, string> id)
{
    private IReadOnlyList<T>? _source;
    private int _sourceCount = -1;
    private long _revision = -1;
    private List<T> _turns = [];
    private bool _initial = true;
    public int Size { get; private set; } = 10;
    public int Page { get; private set; }
    public int Count => _turns.Count;
    public int Pages => Math.Max(1, (Count + Size - 1) / Size);
    public bool IsLatest => Page == Pages - 1;
    public IEnumerable<T> Visible => _turns.Skip(Page * Size).Take(Size);
    public T? Next => _turns.Skip((Page + 1) * Size).FirstOrDefault();
    public void Reset(int size)
    { Size = size; Page = 0; _source = null; _sourceCount = -1; _revision = -1; _turns = []; _initial = true; }
    public bool Bind(IReadOnlyList<T> source, long revision, Func<T, bool> visible, bool follow)
    {
        if (ReferenceEquals(_source, source) && _sourceCount == source.Count && _revision == revision) return false;
        string anchor = Visible.Select(id).FirstOrDefault() ?? "";
        bool latest = _initial || IsLatest && follow;
        _source = source; _sourceCount = source.Count; _revision = revision; _turns = source.Where(visible).ToList();
        if (latest) Latest();
        else
        {
            int index = _turns.FindIndex(t => id(t) == anchor);
            Page = index >= 0 ? index / Size : Math.Min(Page, Pages - 1);
        }
        _initial = false; return true;
    }
    public void Move(int page) => Page = Math.Clamp(page, 0, Pages - 1);
    public void Latest() => Page = Pages - 1;
    public void Resize(int size)
    { int first = Page * Size; Size = size; Move(first / Size); }
}
