using Godot;
using NationalSpire.Coop;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenCareerLibrary()
    {
        if (ViewData.Failure != null) return;
        ShowCareerDialog("生涯存档", "", () => true, "关闭", async box =>
        {
            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); box.AddChild(toolbar);
            if (_multiplayer == null) toolbar.AddChild(Button("新建生涯", () =>
            {
                try { var fresh = CareerEngine.CreateNew(); fresh.Ai = ViewData.Ai; var path = CareerLibrary.Create(CareerStore.DefaultPath, fresh); _boundData = CareerStore.SwitchCareer(path); _cancelDialog?.Invoke(); ResetNavigation(); Render(); }
                catch (Exception e) { Notice(e.Message, true); }
            }, 180));
            toolbar.AddChild(Button("导入存档", () => { _cancelDialog?.Invoke(); OpenFilePicker("导入生涯", [".zip"], async path =>
            {
                try { byte[] bytes = File.ReadAllBytes(path); if (CoopStorage.IsArchive(bytes)) await CoopSettings.Storage.ImportArchiveAsync(bytes); else CareerLibrary.Import(CareerStore.DefaultPath, bytes); if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; OpenCareerLibrary(); Notice("生涯已导入。", false); }
                catch (Exception e) { if (IsInstanceValid(this) && !IsQueuedForDeletion()) Notice("导入失败：" + e.Message, true); }
            }); }, 180));
            var scroll = new BroadcastScroll { Name = "CareerLibraryScroll", CustomMinimumSize = new(0, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
            box.AddChild(scroll); var entries = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; entries.AddThemeConstantOverride("separation", 14); scroll.AddChild(entries);
            foreach (var entry in CareerLibrary.List(CareerStore.DefaultPath))
            {
                var card = Card(); entries.AddChild(card); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); card.AddChild(row);
                var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);
                words.AddChild(Text(entry.Name + (entry.Current ? " · 当前" : ""), 21, entry.Current ? CareerVisuals.Teal : _ink));
                words.AddChild(Text($"单人 · 第{entry.Season}赛季 · {entry.Date}", 16, _muted));
                var switchButton = Button("切换", () =>
                {
                    try { _boundData = CareerStore.SwitchCareer(entry.Path); _cancelDialog?.Invoke(); ResetNavigation(); Render(); }
                    catch (Exception e) { Notice(e.Message, true); }
                }, 105); switchButton.Disabled = entry.Current || _multiplayer != null; row.AddChild(switchButton);
                row.AddChild(Button("导出", () =>
                {
                    try
                    {
                        if (entry.Current) CareerStore.Save();
                        var data = CoopJson.Read<CareerData>(File.ReadAllBytes(entry.Path));
                        string native = entry.Current && data.PendingMatchId != null ? GameBridge.NativeCareerPath : entry.Path + ".run";
                        string path = CareerLibrary.ExportDesktop(entry.Name, CareerLibrary.Export(data,
                            data.PendingMatchId != null && File.Exists(native) ? File.ReadAllBytes(native) : null,
                            data.PendingMatchId != null && File.Exists(native + ".backup") ? File.ReadAllBytes(native + ".backup") : null));
                        OS.ShellShowInFileManager(path); Notice("生涯已导出。", false);
                    }
                    catch (Exception e) { Notice("导出失败：" + e.Message, true); }
                }, 105));
                var deleteButton = Button("删除", () => ConfirmCareerDeletion(entry.Name, entry.Season, entry.Date,
                    () => CareerStore.DeleteCareer(CareerStore.DefaultPath, entry.Path)), 105);
                deleteButton.Name = "DeleteCareer_" + System.IO.Path.GetFileNameWithoutExtension(entry.Path);
                deleteButton.Disabled = entry.Current;
                if (entry.Current) deleteButton.TooltipText = "先切换到另一份生涯，再删除当前生涯。";
                row.AddChild(deleteButton);
            }
            List<CoopStorage.Checkpoint> worlds;
            try { worlds = await CoopSettings.Storage.ListAsync(); }
            catch (Exception error) { if (IsInstanceValid(this) && !IsQueuedForDeletion()) Notice(error.Message, true); return; }
            if (!IsInstanceValid(entries) || entries.IsQueuedForDeletion() || !IsInstanceValid(box) || box.IsQueuedForDeletion()) return;
            foreach (var cp in worlds)
            {
                var card = Card(); entries.AddChild(card); var row = new HBoxContainer(); card.AddChild(row);
                row.AddThemeConstantOverride("separation", 16);
                var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);
                words.AddChild(Text(cp.World.Name, 21, _ink));
                words.AddChild(Text($"多人 · 第{cp.World.World.Season}赛季 · {GameCalendar.Text(cp.World.World, cp.World.World.Day)}", 16, _muted));
                row.AddChild(Button("进入房间", () => { _cancelDialog?.Invoke(); var menu = (Control)GetParent(); Close(); CoopScreen.OpenSaved(menu, cp.World.Id); }, 135));
                row.AddChild(Button("导出", async () => { try { var archive = await CoopSettings.Storage.ExportArchiveAsync(cp.World.Id); if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; OS.ShellShowInFileManager(CareerLibrary.ExportDesktop(cp.World.Name, archive)); Notice("生涯已导出。", false); } catch (Exception e) { if (IsInstanceValid(this) && !IsQueuedForDeletion()) Notice(e.Message, true); } }, 105));
                var deleteButton = Button("删除", () => ConfirmCareerDeletion(cp.World.Name, cp.World.World.Season, GameCalendar.Text(cp.World.World, cp.World.World.Day), () =>
                {
                    if (CoopRuntime.Current?.Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");
                }, async () =>
                {
                    if (CoopRuntime.Current?.Session?.World?.Id == cp.World.Id) throw new InvalidOperationException("请先退出这份生涯的房间，再删除存档。");
                    await CoopSettings.Storage.DeleteAsync(cp.World.Id);
                }), 105);
                deleteButton.Name = "DeleteCareer_" + cp.World.Id;
                deleteButton.Disabled = CoopRuntime.Current?.Session?.World?.Id == cp.World.Id;
                if (deleteButton.Disabled) deleteButton.TooltipText = "先退出这份生涯的房间，再删除存档。";
                row.AddChild(deleteButton);
            }
        }, showCancel: false);
    }

    private void ConfirmCareerDeletion(string name, int season, string date, Action delete, Func<Task>? deleteAsync = null)
    {
        _cancelDialog?.Invoke();
        Label? failure = null;
        bool deleting = false;
        async Task DeleteAsync()
        {
            deleting = true;
            try
            {
                delete(); await deleteAsync!();
                if (!IsInstanceValid(failure) || failure!.IsQueuedForDeletion()) return;
                _cancelDialog?.Invoke(); OpenCareerLibrary(); Notice("生涯已删除，本机备份已保留。", false);
            }
            catch (Exception error) { if (IsInstanceValid(failure) && !failure!.IsQueuedForDeletion()) { failure.Text = "删除失败：" + error.Message; failure.Show(); } }
            finally { deleting = false; }
        }
        ShowCareerDialog("删除生涯", "", () =>
        {
            if (deleteAsync != null) { if (!deleting) _ = DeleteAsync(); return false; }
            try { delete(); _cancelDialog?.Invoke(); OpenCareerLibrary(); Notice("生涯已删除，本机备份已保留。", false); return true; }
            catch (Exception e)
            {
                failure!.Text = e is IOException { HResult: unchecked((int)0x80070020) } ? "删除失败：存档文件正在使用，请稍后重试。" : "删除失败：" + e.Message;
                failure.Show(); return false;
            }
        }, "删除", box =>
        {
            box.AddChild(Text(name, 23, _ink));
            box.AddChild(Text($"第{season}赛季 · {date}", 16, _muted));
            box.AddChild(Text("从列表移除，文件保留在本机备份中。", 17, _muted));
            failure = Text("", 16, new Color("f29b9b")); failure.Hide(); box.AddChild(failure);
        }, compact: true);
        if (_dialogOverlay?.FindChild("CareerDialogCancel", true, false) is Button cancel) cancel.Pressed += OpenCareerLibrary;
    }
}
