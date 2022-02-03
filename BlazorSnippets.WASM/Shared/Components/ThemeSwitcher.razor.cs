using BlazorComponentUtilities;
using BlazorSnippets.WASM.Contracts;
using BlazorSnippets.WASM.Shared.Themes;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorSnippets.WASM.Shared.Components
{
    public partial class ThemeSwitcher : IAsyncDisposable
    {
        [Inject] IJSRuntime JsRuntime { get; set; }

        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        [Inject] IThemeService ThemeService { get; set; }

        public CssBuilder CssClass;

        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }


        private IEnumerable<Theme>? AvailableThemes { get; set; }

        private string Id { get; set; } = $"theme-switcher-{Guid.NewGuid()}";

        public ThemeSwitcher()
        {
            moduleTask = new(() => JsRuntime.InvokeAsync<IJSObjectReference>(
              "import", "./js/themeswitcher.js").AsTask());
        }

        protected override void OnInitialized()
        {
            CssClass = new CssBuilder("form-select").AddClassFromAttributes(AdditionalAttributes);
            AvailableThemes = ThemeService.GetThemes();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var module = await moduleTask.Value;
                await module.InvokeVoidAsync("SetInitialTheme", Id);
            }
        }

        private async Task UpdateTheme(ChangeEventArgs args)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("ChangeTheme", args.Value);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }


    }
}