using Infrastructure.Models;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); 
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepository<Product>, ProductRepository>();

var app = builder.Build();
app.MapRazorPages();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.Run();