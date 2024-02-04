using KouintaBooksApp.Client.Pages;
using KouintaBooksApp.Components;
using KouintaBooksApp.Data;
using KouintaBooksApp.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.BookRepositories;
using SharedLibrary.SeedRepositories;
using SharedLibrary.SharedRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//https link
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!)
});

//Enable Controllers
builder.Services.AddControllers();

//Implementations
builder.Services.AddScoped<IBookRepo, BookRepo>();
builder.Services.AddSingleton<SharedServices>();
builder.Services.AddTransient<ISeedService, SeedRepo>();

//Database Connection
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string not found")));

var app = builder.Build();

//Seed Service run
await SeedAsync(app.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//Enablw Controllers
app.MapControllers();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(KouintaBooksApp.Client._Imports).Assembly);

app.Run();

//run each time the App starts
static async Task SeedAsync(IServiceProvider services)
{
    var scope = services.CreateScope();
    var seedService = scope.ServiceProvider.GetRequiredService<ISeedService>();
    await seedService.SeedDataAsync();
}