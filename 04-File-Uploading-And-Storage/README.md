# 04. Робота з файлами: Завантаження через InputFile та Web API

> **Технології**: .NET 10, Blazor Server, InputFile, IBrowserFile, MultipartFormDataContent, ASP.NET Core Web API.

---

## 📌 Огляд модуля
Модуль демонструє повноцінний процес завантаження файлів (зображень, документів) від клієнта Blazor до бекенду Web API:

1. **Клієнтський шар (`BlazorServerProject`)**:
   - Використання стандартного компонента `<InputFile OnChange="HandleFileSelected" />`.
   - Отримання метаданих (`IBrowserFile.Name`, `Size`, `ContentType`).
   - Потокове читання вмісту файлу через `OpenReadStream(maxAllowedSize)` без надмірного споживання оперативної пам'яті.
   - Формування мультипарт-запиту `MultipartFormDataContent` і передача по HTTP.
2. **Серверний шар (`WebApiProject`)**:
   - Обробка вхідного `IFormFile`.
   - Валідація розширення файлу, розміру та генерація безпечного імені файлу.
   - Збереження у сховище сервера.

---

## 🚀 Як запустити
1. Запустіть бекенд Web API:
   ```bash
   cd WebApiProject
   dotnet run
   ```
2. В іншому терміналі запустіть клієнт Blazor:
   ```bash
   cd BlazorServerProject
   dotnet run
   ```
