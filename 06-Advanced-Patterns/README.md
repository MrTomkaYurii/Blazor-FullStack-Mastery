# 06. Передові архітектурні патерни Blazor (.NET 10)

> **Технології**: .NET 10, Blazor Server, AppState Pattern, LocalStorage, Virtualization, Toast Notifications, Role-Based Auth.

---

## 📌 Огляд модуля
Інтерактивний демонстраційний проєкт передових патернів розробки на сучасному Blazor:

1. **AppState Pattern (`/state`)**:
   - Централізований реактивний сервіс стану без необхідності передавати `EventCallback` через багато рівнів компонентів.
2. **LocalStorage через чистий JS Interop (`/theme`)**:
   - Сервіс `ILocalStorageService` для зберігання вибору темної/світлої теми без важких зовнішніх пакетів.
3. **Віртуалізація списків (`/virtualize`)**:
   - Робота компонента `<Virtualize>` з вибіркою у 10 000+ записів та миттєвим пошуком при 60 FPS.
4. **Спливаючі сповіщення (`/toasts`)**:
   - Реактивна підписка через `IToastService` та контейнер `ToastContainer` з автоматичним закриттям через 3.5 секунди.
5. **Рольова авторизація (`/auth`)**:
   - Кастомний `CustomAuthenticationStateProvider` та робота з `<AuthorizeView Roles="Admin">`.

---

## 🚀 Як запустити
```bash
cd BlazorAdvancedPatterns
dotnet run
```
