using Microsoft.EntityFrameworkCore;
using SmartMenu.Data;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("AppDbContext")
    ));

var app = builder.Build();

app.UseStaticFiles(); 

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

string DbPathFile =   Path.Combine(Directory.GetCurrentDirectory(), "SmartMenu.db");

if (!File.Exists(DbPathFile))
{
    // Cria um arquivo totalmente em branco e fecha o manipulador imediatamente
    File.Create(DbPathFile).Dispose(); 
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
