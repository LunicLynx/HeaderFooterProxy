var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(o =>
{
    o.Conventions.AddPageRoute("/index", "{**catch-all}");
});

builder.Services.AddHttpClient();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();