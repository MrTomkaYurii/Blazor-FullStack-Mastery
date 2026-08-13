namespace BlazorAdvancedPatterns.Services.AppState;

public interface IAppStateService
{
    int Counter { get; }
    IReadOnlyList<string> CartItems { get; }
    event Action? OnChange;
    void IncrementCounter();
    void AddCartItem(string item);
    void ClearCart();
}

public class AppStateService : IAppStateService
{
    private readonly List<string> _cartItems = new();

    public int Counter { get; private set; } = 0;
    public IReadOnlyList<string> CartItems => _cartItems.AsReadOnly();

    public event Action? OnChange;

    public void IncrementCounter()
    {
        Counter++;
        NotifyStateChanged();
    }

    public void AddCartItem(string item)
    {
        if (!string.IsNullOrWhiteSpace(item))
        {
            _cartItems.Add(item);
            NotifyStateChanged();
        }
    }

    public void ClearCart()
    {
        _cartItems.Clear();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
