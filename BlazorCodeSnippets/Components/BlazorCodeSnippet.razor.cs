using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text;

namespace BlazorCodeSnippets.Components
{
    public partial class BlazorCodeSnippet : IAsyncDisposable
    {
        [Inject] IHttpClientFactory HttpClientFactory { get; set; }

        [Inject] NavigationManager NavigationManager { get; set; }

        [Parameter] public string SnippetFilePath { get; set; }

        [Parameter] public SnippetLanguage Language { get; set; } = SnippetLanguage.Default;

        [Parameter] public RenderFragment FileNotFound { get; set; }

        [Parameter] public bool AllowCopy { get; set; } = false;

        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }

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
            var client = HttpClientFactory.CreateClient("BlazorCodeSnippetClient");
            client.BaseAddress = new Uri(NavigationManager.BaseUri);

            try
            {
                file = await client.GetByteArrayAsync(SnippetFilePath);
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

        private async Task CopySnippetToClipboard()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("copyToClipboard");
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