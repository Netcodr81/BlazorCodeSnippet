namespace BlazorSnippets.WASM.Services
{
    public class LanguagesService : ILanguagesService
    {
        public List<string> GetAvailableLanguages()
        {

            return CustomEnum.BaseClass.Enumeration.GetAll(typeof(SnippetLanguage)).Where(x => x.DisplayName != "Default").Select(x => new string(x.DisplayName)).ToList();
        }
    }
}
