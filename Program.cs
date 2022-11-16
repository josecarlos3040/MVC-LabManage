using Microsoft.EntityFrameworkCore;
using MvcLabManager.Models;

var builder = WebApplication.CreateBuilder(args); 


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LabManagerContext>(options => options.UseMySQL("server=localhost;database=labmanager;user=root;password=IFju303030;"));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
