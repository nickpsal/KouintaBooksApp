using KouintaBooksApp.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.BookRepositories;
using SharedLibrary.SharedRepo;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Services.AddScoped(http => new HttpClient
        {
            BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        });

        //Services
        builder.Services.AddSingleton<SharedServices>();
        builder.Services.AddScoped<IBookRepo, BookService>();

        await builder.Build().RunAsync();
    }
}