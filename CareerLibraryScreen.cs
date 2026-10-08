using Godot;
using NationalSpire.Coop;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenCareerLibrary()
    {
        if (ViewData.Failure != null) return;
        ShowCareerDialog("生涯存档", "", () => true, "关闭", box =>
        {
            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); box.AddChild(toolbar);
            if (_multiplayer == null) toolbar.AddChild(Button("新建生涯", () =>
            {
                try { var fresh = CareerEngine.CreateNew(); fresh.Ai = ViewData.Ai; var path = CareerLibrary.Create(CareerStore.DefaultPath, fresh); _boundData = CareerStore.SwitchCareer(path); _cancelDialog?.Invoke(); ResetNavigation(); Render(); }
                catch (Exception e) { Notice(e.Message, true); }
            }, 180));
            toolbar.AddChild(Button("导入存档", () => { _cancelDialog?.Invoke(); OpenFilePicker("导入生涯", [".zip"], path =>
            {
                try { byte[] bytes = File.ReadAllBytes(path); if (CoopStorage.IsArchive(bytes)) CoopSettings.Storage.ImportArchive(bytes); else CareerLibrary.Import(CareerStore.DefaultPath, bytes); OpenCareerLibrary(); Notice("生涯已导入。", false); }
                catch (Exception e) { Notice("导入失败：" + e.Message, true); }
            }); }, 180));
            var scroll = new BroadcastScroll { Name = "CareerLibraryScroll", CustomMinimumSize = new(0, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
            box.AddChild(scroll); var entries = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; entries.AddThemeConstantOverride("separation", 14); scroll.AddChild(entries);
            foreach (var entry in CareerLibrary.List(CareerStore.DefaultPath))
            {
                var card = Card(); entries.AddChild(card); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); card.AddChild(row);
                var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);
                words.AddChild(Text(entry.Name + (entry.Current ? " · 当前" : ""), 21, entry.Current ? CareerVisuals.Teal : _ink));
                words.AddChild(Text($"单人 · 第{entry.Season}赛季第{entry.Day}天", 16, _muted));
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
            }
            var worlds = CoopSettings.Storage.List().ToList();
            foreach (var cp in worlds)
            {
                var card = Card(); entries.AddChild(card); var row = new HBoxContainer(); card.AddChild(row);
                row.AddThemeConstantOverride("separation", 16);
                var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);
                words.AddChild(Text(cp.World.Name, 21, _ink));
                words.AddChild(Text($"多人 · 第{cp.World.World.Season}赛季 · 第{SeasonCalendar.Day(cp.World.World, cp.World.World.Day)}天", 16, _muted));
                row.AddChild(Button("进入房间", () => { _cancelDialog?.Invoke(); var menu = (Control)GetParent(); Close(); CoopScreen.OpenSaved(menu, cp.World.Id); }, 135));
                row.AddChild(Button("导出", () => { try { OS.ShellShowInFileManager(CareerLibrary.ExportDesktop(cp.World.Name, CoopSettings.Storage.ExportArchive(cp.World.Id))); Notice("生涯已导出。", false); } catch (Exception e) { Notice(e.Message, true); } }, 105));
            }
        }, showCancel: false);
    }
}
