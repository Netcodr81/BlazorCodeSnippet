using BlazorSnippets.WASM.Shared.Themes;

namespace BlazorSnippets.WASM.Contracts
{
    public interface IThemeService
    {
        public IEnumerable<Theme> GetThemes();
    }
}
