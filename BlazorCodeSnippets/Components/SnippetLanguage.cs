using CustomEnum;

namespace BlazorCodeSnippets.Components
{
    public class SnippetLanguage : Enumeration<string>
    {

        public static SnippetLanguage Csharp = new SnippetLanguage("language-csharp", "C#");
        public static SnippetLanguage Cshtml = new SnippetLanguage("language-cshtml", "Cshtml");
        public static SnippetLanguage Fsharp = new SnippetLanguage("language-fsharp", "F#");
        public static SnippetLanguage Excel = new SnippetLanguage("language-excel", "Excel");
        public static SnippetLanguage Http = new SnippetLanguage("language-http", "Http");
        public static SnippetLanguage Html = new SnippetLanguage("language-html", "HTML");
        public static SnippetLanguage JavaScript = new SnippetLanguage("language-javascript", "JavaScript");
        public static SnippetLanguage Json = new SnippetLanguage("language-json", "Json");
        public static SnippetLanguage Less = new SnippetLanguage("language-less", "Less");
        public static SnippetLanguage Markdown = new SnippetLanguage("language-markdown", "Markdown");
        public static SnippetLanguage Powershell = new SnippetLanguage("language-powershell", "PowerShell");
        public static SnippetLanguage PlainText = new SnippetLanguage("language-plaintext", "Plain Text");
        public static SnippetLanguage Razor = new SnippetLanguage("language-razor", "Razor");
        public static SnippetLanguage SCSS = new SnippetLanguage("language-scss", "SCSS");
        public static SnippetLanguage SQL = new SnippetLanguage("language-sql", "SQL");
        public static SnippetLanguage TSQL = new SnippetLanguage("language-tsql", "TSQL");
        public static SnippetLanguage TypeScript = new SnippetLanguage("language-typescript", "TypeScript");
        public static SnippetLanguage VBNET = new SnippetLanguage("language-vbnet", "VB.NET");
        public static SnippetLanguage VBScript = new SnippetLanguage("language-vbscript", "VBScript");
        public static SnippetLanguage YAML = new SnippetLanguage("language-naml", "YAML");
        public static SnippetLanguage Default = new SnippetLanguage("language-nohighlight", "Default");

        public SnippetLanguage(string value, string displayName) : base(value, displayName)
        {

        }
    }
}
