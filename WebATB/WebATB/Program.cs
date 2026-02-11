using Microsoft.EntityFrameworkCore;
using WebATB.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyContextATB>(opt => 
opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Реєструє контекст бази даних у DI контейнері
// UseNpgsql — підключення PostgreSQL через провайдер Npgsql
// Отримує рядок підключення "DefaultConnection" з appsettings.json

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
