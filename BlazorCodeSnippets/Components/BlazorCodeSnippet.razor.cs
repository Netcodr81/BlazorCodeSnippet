using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text;

namespace BlazorCodeSnippets.Components
{
    public partial class BlazorCodeSnippet : IAsyncDisposable
    {
        [Inject] HttpClient HttpClient { get; set; }

        [Parameter] public string SnippetFilePath { get; set; }

        [Parameter] public SnippetLanguage Language { get; set; } = SnippetLanguage.Default;

        [Parameter] public RenderFragment FileNotFound { get; set; }

        private string SnippetCode { get; set; }

        private string SelectedLanguage;

        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        private bool FileFound { get; set; } = false;

        [Inject] IJSRuntime _jsRuntime { get; set; }

        public BlazorCodeSnippet()
        {
            moduleTask = new(() => _jsRuntime.InvokeAsync<IJSObjectReference>(
              "import", "./_content/BlazorCodeSnippets/js/codesnippets.js").AsTask());
        }

        protected override async Task OnInitializedAsync()
        {
            SelectedLanguage = Language.Value;
            byte[]? file = null;
            try
            {
                file = await HttpClient.GetByteArrayAsync(SnippetFilePath);
                FileFound = true;
                SnippetCode = Encoding.Default.GetString(file);

                StateHasChanged();

                await HighlightSnippet();
            }
            catch (Exception ex)
            {
                FileFound = false;
            }



        }

        private async Task HighlightSnippet()
        {

            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("highlightSnippet");
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