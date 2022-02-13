using BlazorSnippets.Server.Shared.Themes;

namespace BlazorSnippets.Server.Contracts
{
    public interface IThemeService
    {
        public IEnumerable<Theme> GetThemes();
    }
}
