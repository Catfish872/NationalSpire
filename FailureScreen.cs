using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private async void ResolveFailure(string action)
    {
        if (_starting || ViewData.Failure == null) return;
        if (MultiplayerCommand(action == "confirm" ? "failure-confirm" : "failure-retry", text: action)) return;
        var data = ViewData;
        if (action == "confirm")
        {
            MatchFailure.Confirm(data); Render();
            _ = AiService.ProcessPendingAsync(data); return;
        }
        var character = data.RandomCharacter ? GameBridge.RandomChoice() : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == data.SelectedCharacter);
        if (character == null) { Notice("本次出场角色无法读取。", true); return; }
        var match = MatchFailure.Retry(data, action == "new");
        CareerStore.Save(data); _starting = true; Render();
        var error = await GameBridge.StartMatch(match, character, data.SelectedAscension);
        _starting = false;
        if (error != null) { Notice(error, true); Render(); }
        else Close();
    }
}
