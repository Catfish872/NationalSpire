using Godot;
using NationalSpire.Coop;

namespace NationalSpire;

public partial class CareerScreen
{
    private HBoxContainer SaveRow(VBoxContainer entries, string initialName, string season, string date, bool current,
        Func<string,Task> rename, bool editable=true)
    {
        var card=Card(); entries.AddChild(card);
        if (current)
        {
            var selected=CareerVisuals.Box("19323e","80c9c4",8,16);
            selected.SetBorderWidthAll(2); card.AddThemeStyleboxOverride("panel",selected);
        }
        var row=new HBoxContainer(); row.AddThemeConstantOverride("separation",10); card.AddChild(row);
        var words=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}; row.AddChild(words);
        var title=new HBoxContainer(); title.AddThemeConstantOverride("separation",6); words.AddChild(title);
        var label=DashboardLabel(initialName,21,_ink);
        label.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; label.TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis;
        label.TooltipText=initialName;
        var display=new HBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}; title.AddChild(display);
        display.AddChild(label);
        var edit=new Button {Name="EditSaveName",Flat=true,Icon=NavigationIcon("pencil"),ExpandIcon=true,
            MouseDefaultCursorShape=CursorShape.PointingHand,CustomMinimumSize=new(26,28),TooltipText="编辑存档名称", Visible=editable};
        edit.IconAlignment=HorizontalAlignment.Center; edit.AddThemeConstantOverride("icon_max_width",16);
        foreach (var state in ButtonStates.Append("focus")) edit.AddThemeStyleboxOverride(state,new StyleBoxEmpty());
        edit.AddThemeColorOverride("icon_normal_color",_muted); edit.AddThemeColorOverride("icon_hover_color",CareerVisuals.Teal);
        edit.AddThemeColorOverride("icon_focus_color",CareerVisuals.Teal); display.AddChild(edit);
        var input=new LineEdit {Name="CareerSaveNameInput",Visible=false,MaxLength=80,SizeFlagsHorizontal=SizeFlags.ExpandFill};
        title.AddChild(input);
        void Fit()
        {
            float available=Math.Max(0,title.Size.X-(edit.Visible?edit.GetCombinedMinimumSize().X+display.GetThemeConstant("separation"):0));
            float width=label.GetThemeFont("font").GetStringSize(label.Text,fontSize:21).X;
            label.CustomMinimumSize=new(Math.Min(available,Mathf.Ceil(width)+2),0);
        }
        title.Resized+=Fit; Callable.From(Fit).CallDeferred();
        words.AddChild(DashboardLabel(season,16,_muted)); words.AddChild(DashboardLabel("日期  "+date,16,_muted));
        bool editing=false, saving=false;
        void Finish()
        {
            editing=false; input.Hide(); display.Show(); Fit();
        }
        async void Commit()
        {
            if (!editing || saving) return;
            try
            {
                string value=CareerLibrary.CheckedName(input.Text);
                if (value!=label.Text)
                {
                    saving=true; input.Editable=false; await rename(value);
                    if (!IsInstanceValid(input) || input.IsQueuedForDeletion()) return;
                    label.Text=value; label.TooltipText=value;
                }
                Finish();
            }
            catch (Exception error) { if (IsInstanceValid(input) && input.IsInsideTree()) { Notice(error.Message,true); input.GrabFocus(); } }
            finally { saving=false; if (IsInstanceValid(input)) input.Editable=true; }
        }
        edit.Pressed+=()=>{ editing=true; display.Hide(); input.Text=label.Text; input.Show(); input.GrabFocus(); input.SelectAll(); };
        input.TextSubmitted+=_=>Commit(); input.FocusExited+=Commit;
        input.GuiInput+=ev=>
        {
            if (!saving && ev is InputEventKey {Pressed:true, Keycode:Key.Escape})
            { input.AcceptEvent(); Finish(); edit.GrabFocus(); }
        };
        row.ChildEnteredTree+=item=>{ if (item is Button action) action.SizeFlagsVertical=SizeFlags.ShrinkCenter; };
        return row;
    }

    private void OpenCareerLibrary()
    {
        if (ViewData.Failure != null) return;
        ShowCareerDialog("生涯存档", "", () => true, "关闭", async box =>
        {
            box.GetParent<PanelContainer>().CustomMinimumSize=new(880,0);
            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); box.AddChild(toolbar);
            if (_multiplayer == null) toolbar.AddChild(Button("新建生涯", () =>
            {
                try { BeginNpcSetup(false); }
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
                string displayName=entry.Name;
                var row=SaveRow(entries,displayName,$"单人 · 第{entry.Season}赛季",entry.Date,entry.Current && _multiplayer==null,name=>
                {
                    CareerStore.RenameCareer(CareerStore.DefaultPath,entry.Path,name); displayName=name; return Task.CompletedTask;
                });
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
                        string path = CareerLibrary.ExportDesktop(displayName, CareerLibrary.Export(data,
                            data.PendingMatchId != null && File.Exists(native) ? File.ReadAllBytes(native) : null,
                            data.PendingMatchId != null && File.Exists(native + ".backup") ? File.ReadAllBytes(native + ".backup") : null));
                        OS.ShellShowInFileManager(path); Notice("生涯已导出。", false);
                    }
                    catch (Exception e) { Notice("导出失败：" + e.Message, true); }
                }, 105));
                var deleteButton = Button("删除", () => ConfirmCareerDeletion(displayName, entry.Season, entry.Date,
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
                string displayName=CareerLibrary.DisplayName(cp.World.World,cp.World.Name);
                var active=CoopRuntime.Current?.Session;
                bool current=active?.World?.Id==cp.World.Id;
                var row=SaveRow(entries,displayName,$"多人 · 第{cp.World.World.Season}赛季",GameCalendar.Text(cp.World.World,cp.World.World.Day),current,async name=>
                {
                    var session=CoopRuntime.Current?.Session;
                    if (session?.World?.Id==cp.World.Id) await session.RenameSaveAsync(cp.World.Id,name);
                    else await CoopSettings.Storage.RenameAsync(cp.World.Id,name);
                    displayName=name;
                }, !current || active!.Host);
                row.AddChild(Button("进入房间", () => { _cancelDialog?.Invoke(); var menu = (Control)GetParent(); Close(); CoopScreen.OpenSaved(menu, cp.World.Id); }, 135));
                row.AddChild(Button("导出", async () => { try { var archive = await CoopSettings.Storage.ExportArchiveAsync(cp.World.Id); if (!IsInstanceValid(this) || IsQueuedForDeletion()) return; OS.ShellShowInFileManager(CareerLibrary.ExportDesktop(displayName, archive)); Notice("生涯已导出。", false); } catch (Exception e) { if (IsInstanceValid(this) && !IsQueuedForDeletion()) Notice(e.Message, true); } }, 105));
                var deleteButton = Button("删除", () => ConfirmCareerDeletion(displayName, cp.World.World.Season, GameCalendar.Text(cp.World.World, cp.World.World.Day), () =>
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
