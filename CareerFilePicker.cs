using Godot;
using Environment = System.Environment;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _filePickerDirectory = PromptTransfer.Desktop;
    private static string SavedFilePickerDirectory()
    {
        using var config = new ConfigFile(); config.Load("user://NationalSpire_file_picker.cfg");
        string folder = config.GetValue("browser", "directory", "").AsString();
        return Directory.Exists(folder) ? folder : "";
    }
    private void PickNestedFile(string title, string[] extensions, Action<string> selected, Action<string[]>? multiple = null)
    {
        var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog;
        if (parent == null) { OpenFilePicker(title, extensions, selected, multiple); return; }
        parent.Hide(); _dialogOverlay = null; _cancelDialog = null;
        bool Alive() => IsInstanceValid(parent) && !parent.IsQueuedForDeletion();
        OpenFilePicker(title, extensions, file => { if (Alive()) selected(file); }, multiple == null ? null : paths => { if (Alive()) multiple(paths); });
        var picker = _dialogOverlay;
        void Restore() { if (Alive() && (_dialogOverlay == null || _dialogOverlay == picker)) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }
        if (picker != null) picker.TreeExiting += () => Callable.From(Restore).CallDeferred(); else Restore();
    }
    // 使用游戏内文件浏览器，支持磁盘和目录导航，避免独立系统窗口触发失焦静音。
    private void OpenFilePicker(string title, string[] extensions, Action<string> selected, Action<string[]>? multiple = null)
    {
        string saved = SavedFilePickerDirectory();
        string folder = saved.Length > 0 ? saved : Directory.Exists(_filePickerDirectory) ? _filePickerDirectory : PromptTransfer.Desktop, chosen = "";
        var history = new Stack<string>();
        var entries = new List<(string Path, bool Directory)>();
        ItemList list = null!; Label status = null!; LineEdit location = null!, search = null!;
        void Refresh()
        {
            chosen = ""; list.Clear(); entries.Clear(); location.Text = folder;
            try
            {
                var dirs = Directory.EnumerateDirectories(folder).Where(p => (File.GetAttributes(p) & FileAttributes.Hidden) == 0);
                var files = Directory.EnumerateFiles(folder).Where(p => extensions.Contains(Path.GetExtension(p), StringComparer.OrdinalIgnoreCase));
                string query = search.Text.Trim();
                entries.AddRange(dirs.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, true)).Take(2000));
                entries.AddRange(files.Where(p => Path.GetFileName(p).Contains(query, StringComparison.OrdinalIgnoreCase)).Order(StringComparer.CurrentCulture).Select(p => (p, false)).Take(2000));
                foreach (var entry in entries) list.AddItem((entry.Directory ? "▸  " : "     ") + Path.GetFileName(entry.Path));
                status.Text = entries.Count == 0 ? "此文件夹没有匹配的文件。" : "双击文件夹进入，选中文件后点击“选择文件”。";
            }
            catch (Exception e) when (e is IOException or UnauthorizedAccessException or ArgumentException) { status.Text = "无法访问此文件夹，请选择其他位置。"; }
        }
        void Navigate(string path, bool remember = true)
        {
            if (string.IsNullOrWhiteSpace(path)) return;
            if (remember && folder != path) history.Push(folder);
            folder = path; search.Text = ""; Refresh();
        }
        void Complete()
        {
            _filePickerDirectory = folder;
            string path = chosen;
            var paths = list.GetSelectedItems().Where(i => !entries[i].Directory).Select(i => entries[i].Path).ToArray();
            Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) { if (multiple != null) multiple(paths); else selected(path); } }).CallDeferred();
        }
        ShowCareerDialog(title, "浏览文件夹并选择文件。支持 " + string.Join("、", extensions), () =>
        {
            if (multiple == null ? chosen.Length == 0 || !File.Exists(chosen) : !list.GetSelectedItems().Any(i => !entries[i].Directory && File.Exists(entries[i].Path)))
            { status.Text = "请先选中文件。"; return false; }
            Complete(); return true;
        }, "选择文件", box =>
        {
            box.Name = "CareerFilePicker"; box.CustomMinimumSize = new(900, 0); box.AddThemeConstantOverride("separation", 12);
            var nav = new HBoxContainer(); nav.AddThemeConstantOverride("separation", 10); box.AddChild(nav);
            nav.AddChild(Button("返回", () => { if (history.Count > 0) Navigate(history.Pop(), false); }, 100));
            nav.AddChild(Button("上一级", () => Navigate(Directory.GetParent(folder)?.FullName ?? folder), 120));
            var drives = new OptionButton { Name = "FilePickerDrive", CustomMinimumSize = new(150, 48), FitToLongestItem = false }; nav.AddChild(drives);
            var roots = DriveInfo.GetDrives().Select(d => d.Name).ToArray();
            drives.AddItem("选择磁盘"); foreach (string root in roots) drives.AddItem(root);
            drives.ItemSelected += index => { if (index > 0) Navigate(roots[index - 1]); };
            nav.AddChild(Button("桌面", () => Navigate(PromptTransfer.Desktop), 100));
            nav.AddChild(Button("文档", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), 100));
            nav.AddChild(Button("图片", () => Navigate(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), 100));
            var savePath = Button("保存路径", () =>
            {
                if (!Directory.Exists(folder)) { status.Text = "请打开一个可访问的文件夹后保存。"; return; }
                using var config = new ConfigFile(); config.Load("user://NationalSpire_file_picker.cfg");
                config.SetValue("browser", "directory", Path.GetFullPath(folder));
                if (config.Save("user://NationalSpire_file_picker.cfg") != Error.Ok) { status.Text = "路径保存失败，请重试。"; return; }
                _filePickerDirectory = folder; status.Text = "已保存当前文件夹，下次导入时会从这里开始浏览。";
            }, 130); savePath.Name = "FilePickerSavePath"; nav.AddChild(savePath);
            location = new LineEdit { Name = "FilePickerLocation", Editable = false, CustomMinimumSize = new(0, 42) }; box.AddChild(location);
            search = new LineEdit { Name = "FilePickerSearch", PlaceholderText = "搜索当前文件夹中的名称", CustomMinimumSize = new(0, 42) }; box.AddChild(search);
            list = new ItemList { Name = "FilePickerList", CustomMinimumSize = new(0, 340), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            if (multiple != null) list.SelectMode = ItemList.SelectModeEnum.Multi;
            list.AddThemeFontSizeOverride("font_size", 18); list.AddThemeColorOverride("font_color", _ink); box.AddChild(list);
            status = Text("", 16, _muted); box.AddChild(status);
            list.ItemSelected += index => { chosen = entries[(int)index].Directory ? "" : entries[(int)index].Path; status.Text = chosen.Length == 0 ? "双击进入文件夹。" : "已选择 " + Path.GetFileName(chosen); };
            list.MultiSelected += (_, _) => status.Text = "已选择 " + list.GetSelectedItems().Count(i => !entries[i].Directory) + " 个文件（Ctrl / Shift 可多选）";
            list.ItemActivated += index =>
            {
                var entry = entries[(int)index];
                if (entry.Directory) Navigate(entry.Path);
                else { chosen = entry.Path; Complete(); _cancelDialog?.Invoke(); }
            };
            search.TextChanged += _ => Refresh(); Refresh();
        });
    }
}
