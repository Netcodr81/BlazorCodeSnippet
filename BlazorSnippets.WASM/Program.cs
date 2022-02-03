using BlazorCodeSnippets.Infrastructure.Extensions;
using BlazorSnippets.WASM;
using BlazorSnippets.WASM.Contracts;
using BlazorSnippets.WASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddBlazorCodeSnippet();
builder.Services.AddTransient<IThemeService, ThemeService>();
await builder.Build().RunAsync();
