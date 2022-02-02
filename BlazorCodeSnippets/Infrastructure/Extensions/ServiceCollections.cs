using Microsoft.Extensions.DependencyInjection;

namespace BlazorCodeSnippets.Infrastructure.Extensions
{
    public static class ServiceCollections
    {
        public static void AddBlazorCodeSnippet(this IServiceCollection services)
        {
            services.AddHttpClient("BlazorCodeSnippetClient");
        }
    }
}
