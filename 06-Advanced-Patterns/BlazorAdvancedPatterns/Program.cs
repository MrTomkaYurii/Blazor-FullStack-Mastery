using BlazorAdvancedPatterns.Services.AppState;
using BlazorAdvancedPatterns.Services.Auth;
using BlazorAdvancedPatterns.Services.Notifications;
using BlazorAdvancedPatterns.Services.Storage;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Modern Advanced Blazor Services
builder.Services.AddScoped<IAppStateService, AppStateService>();
builder.Services.AddScoped<IToastService, ToastService>();
builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
