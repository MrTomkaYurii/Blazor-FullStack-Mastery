# Blazor Full-Stack Mastery (.NET 10)

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512bd4.svg?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-Modern-239120.svg?style=flat-square&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Blazor](https://img.shields.io/badge/Blazor-Server%20%26%20WASM-512bd4.svg?style=flat-square&logo=blazor)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![Data Access](https://img.shields.io/badge/Data%20Access-Dapper%20%26%20SQL-blue.svg?style=flat-square)](https://github.com/DapperLib/Dapper)
[![Architecture](https://img.shields.io/badge/Architecture-AppState%20%26%20JSInterop-green.svg?style=flat-square)](https://github.com/)

Повний практичний курс та посібник з розробки сучасних інтерактивних веб-застосунків на платформі **Blazor** (.NET 10). Охоплює повний цикл навчання: від перших сторінок і компонентів до реактивного керування станом, валідації форм, викликів JS Interop, потокового завантаження файлів, інтеграції з REST API та створення повноцінних Full-Stack рішень з реляційними базами даних (**MS SQL Server + Dapper**).

---

## 🗺️ Дорожня карта курсу (Roadmap)

```mermaid
flowchart TD
    classDef bBasic fill:#0284c7,stroke:#38bdf8,color:#ffffff,stroke-width:2px;
    classDef bComp fill:#0d9488,stroke:#2dd4bf,color:#ffffff,stroke-width:2px;
    classDef bApi fill:#7e22ce,stroke:#c084fc,color:#ffffff,stroke-width:2px;
    classDef bUpload fill:#ea580c,stroke:#fb923c,color:#ffffff,stroke-width:2px;
    classDef bFull fill:#16a34a,stroke:#4ade80,color:#ffffff,stroke-width:2px;
    classDef bAdv fill:#be185d,stroke:#f472b6,color:#ffffff,stroke-width:2px;

    B1["01. Blazor Basics<br/>Перші сторінки, @page маршрутизація, NavLink, структура проєкту"]:::bBasic
    B2["02. Components & Forms<br/>DataBinding, EventCallback, EditForm, DataAnnotations, IJSRuntime"]:::bComp
    B3["03. HttpClient & Web API<br/>IHttpClientFactory, споживання REST API, обробка JSON"]:::bApi
    B4["04. File Uploading<br/>InputFile, IBrowserFile стрімінг, multipart передача на Web API"]:::bUpload
    B5["05. Full-Stack Dapper<br/>MS SQL Server, зв'язки Many-to-Many (M:N), збережені процедури"]:::bFull
    B6["06. Advanced Patterns<br/>AppState патерн, LocalStorage Theme, Virtualize 10k+, Toasts, Auth"]:::bAdv

    B1 --> B2 --> B3 --> B4 --> B5 --> B6
```

---

## 📚 Каталог модулів репозиторію

| Модуль | Тематика | Ключові технології | Гілка |
|:---|:---|:---|:---:|
| **[01-Blazor-Basics-FirstApps](01-Blazor-Basics-FirstApps/)** | Основи та старт | `Blazor Server`, `@page`, `NavMenu`, `NavLink`, життєвий цикл першого застосунку | `feat/01-blazor-basics-firstapps` |
| **[02-Components-Forms-Interop](02-Components-Forms-Interop/)** | Компоненти, Форми та JS | `@bind`, `EventCallback`, `<EditForm>`, `DataAnnotationsValidator`, `IJSRuntime`, `Generic Host` | `feat/02-components-forms-interop` |
| **[03-HttpClient-WebApi-Integration](03-HttpClient-WebApi-Integration/)** | Інтеграція з REST API | `HttpClient`, `IHttpClientFactory`, `GetFromJsonAsync`, асинхронне завантаження | `feat/03-httpclient-webapi` |
| **[04-File-Uploading-And-Storage](04-File-Uploading-And-Storage/)** | Завантаження файлів | `<InputFile>`, `IBrowserFile`, `OpenReadStream()`, `MultipartFormDataContent`, `Web API` | `feat/04-file-uploading` |
| **[05-FullStack-Dapper-ManyToMany](05-FullStack-Dapper-ManyToMany/)** | Full-Stack з базою даних | `MS SQL Server`, `Dapper`, зв'язки `Many-to-Many` (M:N), збережені процедури, `database_sql.sql` | `feat/05-fullstack-dapper-database` |
| **[06-Advanced-Patterns](06-Advanced-Patterns/)** | Передові патерни | `AppState Pattern`, `LocalStorage (Dark Mode)`, `<Virtualize>` 10,000+ рядків, `Toast Notifications`, `<AuthorizeView>` | `feat/06-advanced-patterns` |

---

## 🛠️ Вимоги та швидкий старт

- **SDK:** .NET 10.0 SDK або новіший.
- **СУБД:** Microsoft SQL Server (LocalDB / Express / Docker) для модуля 05.
- **IDE:** Visual Studio 2022/2026, JetBrains Rider або VS Code.

```bash
# Клонування репозиторію
git clone https://github.com/MrTomkaYurii/Blazor-FullStack-Mastery.git
cd Blazor-FullStack-Mastery

# Запуск інтерактивного полігону передових патернів
cd 06-Advanced-Patterns/BlazorAdvancedPatterns
dotnet run
```
