using ChinookAlbumManager.Components;
using Microsoft.EntityFrameworkCore;
using AlbumDetails;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents() // Adds support for Razor Components
    .AddInteractiveServerComponents(); // Adds support for interactive server components

// Register the DbContext with the dependency injection container
builder.Services.AddDbContext<ChinookContext>(options =>
{
    // Configure the DbContext to use SQLite with the connection string from configuration
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Use exception handler for non-development environments
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // Use HSTS (HTTP Strict Transport Security) for production scenarios
    app.UseHsts();
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Serve static files
app.UseStaticFiles();

// Enable antiforgery token validation
app.UseAntiforgery();

// Map Razor Components to the root URL and enable interactive server render mode
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Run the application
app.Run();
