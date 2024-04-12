using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Song.Data;
using Song.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PlaylistsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PlaylistsContext") ?? throw new InvalidOperationException("Connection string 'PlaylistsContext' not found.")));
builder.Services.AddDbContext<AlbumsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlbumsContext") ?? throw new InvalidOperationException("Connection string 'AlbumsContext' not found.")));
builder.Services.AddDbContext<ArtistsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ArtistsContext") ?? throw new InvalidOperationException("Connection string 'ArtistsContext' not found.")));
builder.Services.AddDbContext<UsersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UsersContext") ?? throw new InvalidOperationException("Connection string 'UsersContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedDataArtist.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedDataAlbums.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedDataPlaylists.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
