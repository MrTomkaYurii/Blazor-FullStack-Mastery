# 02. Компоненти, Події, Валідація форм та JS Interop

> **Технології**: .NET 10, Data Binding (@bind), EventCallback, EditForm, DataAnnotations, IJSRuntime, Component Lifecycle.

---

## 📌 Огляд модуля
Розширений практичний комплекс, що покриває фундаментальні інструменти Blazor для розробки інтерактивних інтерфейсів:

1. **`BlazorEventsBindings`**:
   - Одностороння та двостороння прив'язка даних (`@bind`, `@bind:event="oninput"`).
   - Обробка подій миші й клавіатури, зворотні виклики через `EventCallback<T>`.
2. **`BlazorForms`**:
   - Робота з формами за допомогою компонента `<EditForm>`.
   - Валідація моделі через `DataAnnotationsValidator` (`[Required]`, `[StringLength]`, `[Range]`).
   - Виведення повідомлень про помилки через `<ValidationMessage>` та `<ValidationSummary>`.
3. **`BlazorJS`**:
   - Взаємодія з JavaScript через інтерфейс `IJSRuntime`.
   - Виклик JS-функцій із C# (`InvokeVoidAsync`, `InvokeAsync<T>`).
   - Виклик методів C# із JavaScript (`[JSInvokable]`).
4. **`BlazorRC`**:
   - Повний життєвий цикл компонента: `OnInitializedAsync`, `OnParametersSetAsync`, `OnAfterRenderAsync`, `Dispose`.
5. **`BlazorServerDefaultDemo` & `BlazorWebAssemblyDefaultDemo`**:
   - Порівняння архітектури та відмінностей Blazor Server (SignalR WebSocket) та Blazor WebAssembly (клієнтський WebAssembly).
6. **Інфраструктурні приклади (`EX_01_GH` – `EX_04_Log`)**:
   - Generic Host, контейнер залежностей (Dependency Injection), робота з `appsettings.json` та логування.

---

## 🚀 Як запустити
Оберіть потрібний проєкт, наприклад форми:
```bash
cd BlazorForms
dotnet run
```
