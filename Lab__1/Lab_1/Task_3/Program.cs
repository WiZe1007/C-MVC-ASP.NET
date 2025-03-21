using Microsoft.EntityFrameworkCore;
using Task_3.Data; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// ����������� EF Core ��� ������ � SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

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

// ����������� ������� �� ������������� Home/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run(); 
