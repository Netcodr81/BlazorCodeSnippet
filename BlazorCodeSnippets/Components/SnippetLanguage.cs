using CustomEnum;

namespace BlazorCodeSnippets.Components
{
    public class SnippetLanguage : Enumeration<string>
    {

        public static SnippetLanguage Csharp = new SnippetLanguage("language-csharp", "C#");
        public static SnippetLanguage Cshtml = new SnippetLanguage("language-cshtml", "Cshtml");
        public static SnippetLanguage CPlusPlus = new SnippetLanguage("language-cpp", "C++");
        public static SnippetLanguage Docker = new SnippetLanguage("language-docker", "Docker");
        public static SnippetLanguage Django = new SnippetLanguage("language-django", "Django");
        public static SnippetLanguage Erlang = new SnippetLanguage("language-erlang", "Erlang");
        public static SnippetLanguage Fsharp = new SnippetLanguage("language-fsharp", "F#");
        public static SnippetLanguage Excel = new SnippetLanguage("language-excel", "Excel");
        public static SnippetLanguage GCode = new SnippetLanguage("language-gcode", "G-Code");
        public static SnippetLanguage Go = new SnippetLanguage("language-go", "Go");
        public static SnippetLanguage Http = new SnippetLanguage("language-http", "Http");
        public static SnippetLanguage Html = new SnippetLanguage("language-html", "HTML");
        public static SnippetLanguage Java = new SnippetLanguage("language-java", "Java");
        public static SnippetLanguage JavaScript = new SnippetLanguage("language-javascript", "JavaScript");
        public static SnippetLanguage Json = new SnippetLanguage("language-json", "Json");
        public static SnippetLanguage Kotlin = new SnippetLanguage("language-kotlin", "Kotlin");
        public static SnippetLanguage Nginx = new SnippetLanguage("language-nginx", "Nginx");
        public static SnippetLanguage Less = new SnippetLanguage("language-less", "Less");
        public static SnippetLanguage Markdown = new SnippetLanguage("language-markdown", "Markdown");
        public static SnippetLanguage ObjectiveC = new SnippetLanguage("language-objectivec", "Objective C");
        public static SnippetLanguage Powershell = new SnippetLanguage("language-powershell", "PowerShell");
        public static SnippetLanguage PlainText = new SnippetLanguage("language-plaintext", "Plain Text");
        public static SnippetLanguage PHP = new SnippetLanguage("language-php", "PHP");
        public static SnippetLanguage Perl = new SnippetLanguage("language-perl", "Perl");
        public static SnippetLanguage Python = new SnippetLanguage("language-python", "Python");
        public static SnippetLanguage Razor = new SnippetLanguage("language-razor", "Razor");
        public static SnippetLanguage RSS = new SnippetLanguage("language-rss", "RSS");
        public static SnippetLanguage SCSS = new SnippetLanguage("language-scss", "SCSS");
        public static SnippetLanguage SQL = new SnippetLanguage("language-sql", "SQL");
        public static SnippetLanguage SVG = new SnippetLanguage("language-svg", "SVG");
        public static SnippetLanguage TSQL = new SnippetLanguage("language-tsql", "TSQL");
        public static SnippetLanguage TypeScript = new SnippetLanguage("language-typescript", "TypeScript");
        public static SnippetLanguage VBNET = new SnippetLanguage("language-vbnet", "VB.NET");
        public static SnippetLanguage VBScript = new SnippetLanguage("language-vbscript", "VBScript");
        public static SnippetLanguage XML = new SnippetLanguage("language-xml", "XML");
        public static SnippetLanguage YAML = new SnippetLanguage("language-naml", "YAML");
        public static SnippetLanguage Default = new SnippetLanguage("language-nohighlight", "Default");

        public SnippetLanguage(string value, string displayName) : base(value, displayName)
        {

        }
    }
}
