namespace BlazorSnippets.Server.Shared.Themes
{
    public class Theme
    {
        public string Name { get; set; }
        public string GetUrl => $"_content/BlazorCodeSnippets/css/BlazorSnippet/{Name}.min.css";
    }
}
