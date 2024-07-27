using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using BookStore.Data;
using BookStore.Models;
using System.Text;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure; // Bu satýrý eklemeyi unutma

var builder = WebApplication.CreateBuilder(args);

// Configuration setup
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
new MySqlServerVersion(new Version(8, 0, 38)))); // MySQL sürümünü burada belirtiyoruz

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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