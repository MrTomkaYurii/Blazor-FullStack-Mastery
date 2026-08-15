# Довідник концепцій Blazor (.NET 10 Cheat-Sheet)

## 1. Хостинг-моделі Blazor
- **Blazor Server (InteractiveServer)**: Код виконується на сервері. UI оновлюється через WebSocket (SignalR). Швидкий старт, прямий доступ до БД, але чутливий до затримок мережі.
- **Blazor WebAssembly (InteractiveWebAssembly)**: Застосунок завантажується та виконується безпосередньо у браузері через WebAssembly runtime. Працює офлайн (PWA), розвантажує сервер, але початкове завантаження більше за обсягом.
- **Static SSR (Server-Side Rendering)**: Швидка генерація чистого HTML на сервері без відкриття WebSocket-з'єднання. Ідеально для статичних сторінок та SEO.

---

## 2. Прив'язка даних (Data Binding)
- **Одностороння:** `<span>@userName</span>`
- **Двостороння:** `<input @bind="userName" />`
- **З вибором події:** `<input @bind="userName" @bind:event="oninput" />` (оновлення при кожному натисканні клавіші).

---

## 3. Форми та Валідація
```razor
<EditForm Model="@userModel" OnValidSubmit="HandleValidSubmit">
    <DataAnnotationsValidator />
    <ValidationSummary />

    <div class="mb-3">
        <label>Ім'я:</label>
        <InputText class="form-control" @bind-Value="userModel.Name" />
        <ValidationMessage For="@(() => userModel.Name)" />
    </div>

    <button type="submit" class="btn btn-primary">Зберегти</button>
</EditForm>
```

---

## 4. Патерн AppState для обміну даними
Замість передачі каскадних параметрів використовується Scoped-сервіс із подією сповіщення:
```csharp
public class AppStateService
{
    public int Counter { get; private set; }
    public event Action? OnChange;

    public void Increment()
    {
        Counter++;
        OnChange?.Invoke();
    }
}
```
У компоненті підписка та оновлення:
```razor
@inject AppStateService State
@implements IDisposable

<p>Лічильник: @State.Counter</p>

@code {
    protected override void OnInitialized() => State.OnChange += StateHasChanged;
    public void Dispose() => State.OnChange -= StateHasChanged;
}
```
