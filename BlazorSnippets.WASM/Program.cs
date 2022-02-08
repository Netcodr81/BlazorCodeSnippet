using BlazorCodeSnippets.Infrastructure.Extensions;
using BlazorSnippets.WASM;
using BlazorSnippets.WASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddBlazorCodeSnippet();
builder.Services.AddTransient<IThemeService, ThemeService>();
builder.Services.AddTransient<ILanguagesService, LanguagesService>();
await builder.Build().RunAsync();
