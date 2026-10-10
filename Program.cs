using Configuration_Options;
using Configuration_Options.Models;
using Configuration_Options.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Register site settings from appsettings.json to the SiteOptions class.
builder.Services.Configure<SiteOptions>(
    builder.Configuration.GetSection("SiteOptions"));


// Add services to the container.
builder.Services.AddRazorPages();

// Add the repository implementation to the DI(Dependency Injection) container.
builder.Services.AddSingleton<IBlogRepository, JsonBlogRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();