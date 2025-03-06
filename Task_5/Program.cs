using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Додаємо підтримку сесій з використанням DMC
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    // Час життя сесії
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); 
}

app.UseHttpsRedirection(); 
app.UseStaticFiles();        

app.UseRouting();           
app.UseAuthorization();     

// Увімкнення сесії
app.UseSession();

// Встановлюємо маршрут за замовчуванням Page1/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Page1}/{action=Index}/{id?}"
);

app.Run(); 
