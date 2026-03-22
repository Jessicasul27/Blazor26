

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp2026.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Ensure the application is properly configured
            builder.RootComponents.Add<App>("#app"); // Add the root component
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); // Add HttpClient service

            await builder.Build().RunAsync();
        }
    }
}
//Install - Package Microsoft.AspNetCore.Components.WebAssembly
