using ASP.NET.Models;
using Microsoft.EntityFrameworkCore;


string databaseFileName = "PracticeDb.mdf";
string path = AppDomain.CurrentDomain.BaseDirectory;
string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={path}{databaseFileName}; Integrated Security=True; Connect Timeout=10000";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    connectionString
));

var app = builder.Build();

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
    name: "MoviesByReleaseDate",
    pattern: "movie/released/{year}/{month}",
    new {controller = "Movie", action = "ByReleaseDate"},
    new {year = @"\d{4}", month = @"\d{2}"} 
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
