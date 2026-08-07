# 03. Інтеграція Blazor із зовнішніми REST API (HttpClient)

> **Технології**: .NET 10, Blazor, HttpClient, IHttpClientFactory, System.Text.Json, REST API Consumption.

---

## 📌 Огляд модуля
Модуль демонструє патерни взаємодії Blazor-клієнта з віддаленими веб-службами (REST Web API):

1. **Реєстрація та впровадження `HttpClient`**:
   - Використання фабрики `IHttpClientFactory` у `Program.cs`.
   - Налаштування `BaseAddress`, заголовків та тайм-аутів.
2. **Асинхронний обмін даними**:
   - Методи `GetFromJsonAsync<T>`, `PostAsJsonAsync`, `PutAsJsonAsync`, `DeleteAsync`.
   - Обробка індикаторів завантаження (`isLoading = true/false`) під час очікування відповіді.
   - Обробка статус-кодів помилок (`HttpResponseMessage.IsSuccessStatusCode`) та винятків мережі.

---

## 🚀 Як запустити
```bash
cd BlazorCallWebApiExamples
dotnet run
```
