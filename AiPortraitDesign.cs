namespace NationalSpire;

public static partial class AiService
{
    public static async Task<string> InferPortraitAsync(CareerData data, string person, PortraitDesign draft, CancellationToken token)
    {
        if (!data.Ai.Enabled) throw new InvalidOperationException("启用 AI 后可根据人物资料推测外观；当前设定可直接编辑与导出。");
        var messages = PortraitDesigns.Messages(data, person, draft);
        PrivateForegroundQueue.Configure(data.Ai.MaxConcurrentRequests);
        using var cancel = CancellationTokenSource.CreateLinkedTokenSource(token);
        cancel.CancelAfter(TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)));
        using var lease = await EnterPrivateQueue(data, "portrait/" + person, cancel.Token);
        cancel.Token.ThrowIfCancellationRequested();
        if (!CareerStore.IsCurrent(data)) throw new OperationCanceledException("生涯已切换。", cancel.Token);
        return await RequestPrivateAsync(data.Ai, messages, false, null, cancel.Token, context: "portrait-design/" + person, task: "private");
    }
}
