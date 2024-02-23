using ProjectForStudy;
using ProjectForStudy.Components;
using ProjectForStudy.Models;

var builder = WebApplication.CreateBuilder(args);

ConfigureService(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static void ConfigureService(IServiceCollection services)
{
    services.AddRazorComponents().AddInteractiveServerComponents();
    services.AddSingleton<ContactService>();
   
}
