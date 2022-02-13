using BlazorCodeSnippets.Infrastructure.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorCodeSnippet();
builder.Services.AddTransient<IThemeService, ThemeService>();
builder.Services.AddTransient<ILanguagesService, LanguagesService>();
builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri("http://localhost:5049/")
});

builder.Services.AddBlazorCodeSnippet();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
