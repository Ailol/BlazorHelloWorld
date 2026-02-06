using BlazorHelloWorld.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// This is like Angular's providers array — you register services here for DI
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Map Razor components — similar to Angular's RouterModule
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
