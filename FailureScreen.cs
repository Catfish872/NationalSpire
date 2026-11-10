using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void OpenConfirmedTiebreak(CareerData data, CareerResult? decision)
    {
        if (decision is not { Outcome: "平局" } || data.Failure != null || data.PendingMatchId != null) return;
        if (!data.Matches.Any(m => m.Id == decision.MatchId && m.Status == "待赛")) return;
        _tab = "赛事";
        _arenaMatchId = decision.MatchId;
        _reviewId = "";
        _backHistory.Clear();
        _scroll.ScrollVertical = 0;
    }

    private async void ResolveFailure(string action)
    {
        if (_starting || ViewData.Failure == null) return;
        if (MultiplayerCommand(action == "confirm" ? "failure-confirm" : "failure-retry", text: action)) return;
        var data = ViewData;
        var result = data.Failure!.Result;
        if (action == "confirm")
        {
            MatchFailure.Confirm(data);
            OpenConfirmedTiebreak(data, result);
            Render();
            _ = AiService.ProcessPendingAsync(data); return;
        }
        var character = result.Simulated
            ? GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == result.CharacterId)
            : data.RandomCharacter ? GameBridge.RandomChoice() : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == data.SelectedCharacter);
        if (character == null) { Notice("本次出场角色无法读取。", true); return; }
        var match = MatchFailure.Retry(data, action == "new");
        CareerStore.Save(data); _starting = true; Render();
        var error = await GameBridge.StartMatch(match, character, result.PlayedAscension ?? result.Ascension);
        _starting = false;
        if (error != null) { Notice(error, true); Render(); }
        else Close();
    }
}
