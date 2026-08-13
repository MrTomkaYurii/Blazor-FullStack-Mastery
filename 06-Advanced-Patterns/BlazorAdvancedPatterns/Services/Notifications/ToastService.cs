namespace BlazorAdvancedPatterns.Services.Notifications;

public enum ToastLevel { Info, Success, Warning, Error }

public record ToastMessage(Guid Id, string Text, ToastLevel Level, DateTime Timestamp);

public interface IToastService
{
    event Action<ToastMessage>? OnShow;
    void ShowInfo(string message);
    void ShowSuccess(string message);
    void ShowWarning(string message);
    void ShowError(string message);
}

public class ToastService : IToastService
{
    public event Action<ToastMessage>? OnShow;

    public void ShowInfo(string message) => ShowToast(message, ToastLevel.Info);
    public void ShowSuccess(string message) => ShowToast(message, ToastLevel.Success);
    public void ShowWarning(string message) => ShowToast(message, ToastLevel.Warning);
    public void ShowError(string message) => ShowToast(message, ToastLevel.Error);

    private void ShowToast(string message, ToastLevel level)
    {
        var toast = new ToastMessage(Guid.NewGuid(), message, level, DateTime.Now);
        OnShow?.Invoke(toast);
    }
}
